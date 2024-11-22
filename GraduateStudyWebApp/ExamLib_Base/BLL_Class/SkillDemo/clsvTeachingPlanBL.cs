
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvTeachingPlanBL
 表名:vTeachingPlan(01120388)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:50:13
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
public static class  clsvTeachingPlanBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strIdTeachingPlan">表关键字</param>
 /// <returns>表对象</returns>
public static clsvTeachingPlanEN GetObj(this K_IdTeachingPlan_vTeachingPlan myKey)
{
clsvTeachingPlanEN objvTeachingPlanEN = clsvTeachingPlanBL.vTeachingPlanDA.GetObjByIdTeachingPlan(myKey.Value);
return objvTeachingPlanEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingPlanEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingPlanEN SetIdTeachingPlan(this clsvTeachingPlanEN objvTeachingPlanEN, string strIdTeachingPlan, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdTeachingPlan, 8, convTeachingPlan.IdTeachingPlan);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdTeachingPlan, 8, convTeachingPlan.IdTeachingPlan);
}
objvTeachingPlanEN.IdTeachingPlan = strIdTeachingPlan; //教案流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingPlanEN.dicFldComparisonOp.ContainsKey(convTeachingPlan.IdTeachingPlan) == false)
{
objvTeachingPlanEN.dicFldComparisonOp.Add(convTeachingPlan.IdTeachingPlan, strComparisonOp);
}
else
{
objvTeachingPlanEN.dicFldComparisonOp[convTeachingPlan.IdTeachingPlan] = strComparisonOp;
}
}
return objvTeachingPlanEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingPlanEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingPlanEN SetSubjectName(this clsvTeachingPlanEN objvTeachingPlanEN, string strSubjectName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strSubjectName, convTeachingPlan.SubjectName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSubjectName, 200, convTeachingPlan.SubjectName);
}
objvTeachingPlanEN.SubjectName = strSubjectName; //课题名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingPlanEN.dicFldComparisonOp.ContainsKey(convTeachingPlan.SubjectName) == false)
{
objvTeachingPlanEN.dicFldComparisonOp.Add(convTeachingPlan.SubjectName, strComparisonOp);
}
else
{
objvTeachingPlanEN.dicFldComparisonOp[convTeachingPlan.SubjectName] = strComparisonOp;
}
}
return objvTeachingPlanEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingPlanEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingPlanEN SetTeachingPlanAuthor(this clsvTeachingPlanEN objvTeachingPlanEN, string strTeachingPlanAuthor, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTeachingPlanAuthor, 50, convTeachingPlan.TeachingPlanAuthor);
}
objvTeachingPlanEN.TeachingPlanAuthor = strTeachingPlanAuthor; //教案撰写人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingPlanEN.dicFldComparisonOp.ContainsKey(convTeachingPlan.TeachingPlanAuthor) == false)
{
objvTeachingPlanEN.dicFldComparisonOp.Add(convTeachingPlan.TeachingPlanAuthor, strComparisonOp);
}
else
{
objvTeachingPlanEN.dicFldComparisonOp[convTeachingPlan.TeachingPlanAuthor] = strComparisonOp;
}
}
return objvTeachingPlanEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingPlanEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingPlanEN SetTeachingObject(this clsvTeachingPlanEN objvTeachingPlanEN, string strTeachingObject, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTeachingObject, 5000, convTeachingPlan.TeachingObject);
}
objvTeachingPlanEN.TeachingObject = strTeachingObject; //教学目标
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingPlanEN.dicFldComparisonOp.ContainsKey(convTeachingPlan.TeachingObject) == false)
{
objvTeachingPlanEN.dicFldComparisonOp.Add(convTeachingPlan.TeachingObject, strComparisonOp);
}
else
{
objvTeachingPlanEN.dicFldComparisonOp[convTeachingPlan.TeachingObject] = strComparisonOp;
}
}
return objvTeachingPlanEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingPlanEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingPlanEN SetTeachingEmphases(this clsvTeachingPlanEN objvTeachingPlanEN, string strTeachingEmphases, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTeachingEmphases, 5000, convTeachingPlan.TeachingEmphases);
}
objvTeachingPlanEN.TeachingEmphases = strTeachingEmphases; //教学重点
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingPlanEN.dicFldComparisonOp.ContainsKey(convTeachingPlan.TeachingEmphases) == false)
{
objvTeachingPlanEN.dicFldComparisonOp.Add(convTeachingPlan.TeachingEmphases, strComparisonOp);
}
else
{
objvTeachingPlanEN.dicFldComparisonOp[convTeachingPlan.TeachingEmphases] = strComparisonOp;
}
}
return objvTeachingPlanEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingPlanEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingPlanEN SetTeachingDifficulty(this clsvTeachingPlanEN objvTeachingPlanEN, string strTeachingDifficulty, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTeachingDifficulty, 5000, convTeachingPlan.TeachingDifficulty);
}
objvTeachingPlanEN.TeachingDifficulty = strTeachingDifficulty; //教学难点
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingPlanEN.dicFldComparisonOp.ContainsKey(convTeachingPlan.TeachingDifficulty) == false)
{
objvTeachingPlanEN.dicFldComparisonOp.Add(convTeachingPlan.TeachingDifficulty, strComparisonOp);
}
else
{
objvTeachingPlanEN.dicFldComparisonOp[convTeachingPlan.TeachingDifficulty] = strComparisonOp;
}
}
return objvTeachingPlanEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingPlanEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingPlanEN SetTeachingTool(this clsvTeachingPlanEN objvTeachingPlanEN, string strTeachingTool, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTeachingTool, 5000, convTeachingPlan.TeachingTool);
}
objvTeachingPlanEN.TeachingTool = strTeachingTool; //教学用具
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingPlanEN.dicFldComparisonOp.ContainsKey(convTeachingPlan.TeachingTool) == false)
{
objvTeachingPlanEN.dicFldComparisonOp.Add(convTeachingPlan.TeachingTool, strComparisonOp);
}
else
{
objvTeachingPlanEN.dicFldComparisonOp[convTeachingPlan.TeachingTool] = strComparisonOp;
}
}
return objvTeachingPlanEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingPlanEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingPlanEN SetTeachingProcess(this clsvTeachingPlanEN objvTeachingPlanEN, string strTeachingProcess, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTeachingProcess, 8000, convTeachingPlan.TeachingProcess);
}
objvTeachingPlanEN.TeachingProcess = strTeachingProcess; //教学过程
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingPlanEN.dicFldComparisonOp.ContainsKey(convTeachingPlan.TeachingProcess) == false)
{
objvTeachingPlanEN.dicFldComparisonOp.Add(convTeachingPlan.TeachingProcess, strComparisonOp);
}
else
{
objvTeachingPlanEN.dicFldComparisonOp[convTeachingPlan.TeachingProcess] = strComparisonOp;
}
}
return objvTeachingPlanEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingPlanEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingPlanEN SetTeachingPlanType(this clsvTeachingPlanEN objvTeachingPlanEN, string strTeachingPlanType, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTeachingPlanType, 1, convTeachingPlan.TeachingPlanType);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTeachingPlanType, 1, convTeachingPlan.TeachingPlanType);
}
objvTeachingPlanEN.TeachingPlanType = strTeachingPlanType; //教案类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingPlanEN.dicFldComparisonOp.ContainsKey(convTeachingPlan.TeachingPlanType) == false)
{
objvTeachingPlanEN.dicFldComparisonOp.Add(convTeachingPlan.TeachingPlanType, strComparisonOp);
}
else
{
objvTeachingPlanEN.dicFldComparisonOp[convTeachingPlan.TeachingPlanType] = strComparisonOp;
}
}
return objvTeachingPlanEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingPlanEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingPlanEN SetTeachPlanTypeName(this clsvTeachingPlanEN objvTeachingPlanEN, string strTeachPlanTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTeachPlanTypeName, 50, convTeachingPlan.TeachPlanTypeName);
}
objvTeachingPlanEN.TeachPlanTypeName = strTeachPlanTypeName; //教案类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingPlanEN.dicFldComparisonOp.ContainsKey(convTeachingPlan.TeachPlanTypeName) == false)
{
objvTeachingPlanEN.dicFldComparisonOp.Add(convTeachingPlan.TeachPlanTypeName, strComparisonOp);
}
else
{
objvTeachingPlanEN.dicFldComparisonOp[convTeachingPlan.TeachPlanTypeName] = strComparisonOp;
}
}
return objvTeachingPlanEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingPlanEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingPlanEN SetSimplePlanContent(this clsvTeachingPlanEN objvTeachingPlanEN, string strSimplePlanContent, string strComparisonOp="")
	{
objvTeachingPlanEN.SimplePlanContent = strSimplePlanContent; //简案内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingPlanEN.dicFldComparisonOp.ContainsKey(convTeachingPlan.SimplePlanContent) == false)
{
objvTeachingPlanEN.dicFldComparisonOp.Add(convTeachingPlan.SimplePlanContent, strComparisonOp);
}
else
{
objvTeachingPlanEN.dicFldComparisonOp[convTeachingPlan.SimplePlanContent] = strComparisonOp;
}
}
return objvTeachingPlanEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingPlanEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingPlanEN SetTeachingPlanInDate(this clsvTeachingPlanEN objvTeachingPlanEN, string strTeachingPlanInDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTeachingPlanInDate, 8, convTeachingPlan.TeachingPlanInDate);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTeachingPlanInDate, 8, convTeachingPlan.TeachingPlanInDate);
}
objvTeachingPlanEN.TeachingPlanInDate = strTeachingPlanInDate; //教案入库日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingPlanEN.dicFldComparisonOp.ContainsKey(convTeachingPlan.TeachingPlanInDate) == false)
{
objvTeachingPlanEN.dicFldComparisonOp.Add(convTeachingPlan.TeachingPlanInDate, strComparisonOp);
}
else
{
objvTeachingPlanEN.dicFldComparisonOp[convTeachingPlan.TeachingPlanInDate] = strComparisonOp;
}
}
return objvTeachingPlanEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingPlanEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingPlanEN SetTeachingPlanInTime(this clsvTeachingPlanEN objvTeachingPlanEN, string strTeachingPlanInTime, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTeachingPlanInTime, 6, convTeachingPlan.TeachingPlanInTime);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTeachingPlanInTime, 6, convTeachingPlan.TeachingPlanInTime);
}
objvTeachingPlanEN.TeachingPlanInTime = strTeachingPlanInTime; //教案入库时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingPlanEN.dicFldComparisonOp.ContainsKey(convTeachingPlan.TeachingPlanInTime) == false)
{
objvTeachingPlanEN.dicFldComparisonOp.Add(convTeachingPlan.TeachingPlanInTime, strComparisonOp);
}
else
{
objvTeachingPlanEN.dicFldComparisonOp[convTeachingPlan.TeachingPlanInTime] = strComparisonOp;
}
}
return objvTeachingPlanEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingPlanEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingPlanEN SetMemo(this clsvTeachingPlanEN objvTeachingPlanEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convTeachingPlan.Memo);
}
objvTeachingPlanEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingPlanEN.dicFldComparisonOp.ContainsKey(convTeachingPlan.Memo) == false)
{
objvTeachingPlanEN.dicFldComparisonOp.Add(convTeachingPlan.Memo, strComparisonOp);
}
else
{
objvTeachingPlanEN.dicFldComparisonOp[convTeachingPlan.Memo] = strComparisonOp;
}
}
return objvTeachingPlanEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvTeachingPlanENS">源对象</param>
 /// <param name = "objvTeachingPlanENT">目标对象</param>
 public static void CopyTo(this clsvTeachingPlanEN objvTeachingPlanENS, clsvTeachingPlanEN objvTeachingPlanENT)
{
try
{
objvTeachingPlanENT.IdTeachingPlan = objvTeachingPlanENS.IdTeachingPlan; //教案流水号
objvTeachingPlanENT.SubjectName = objvTeachingPlanENS.SubjectName; //课题名称
objvTeachingPlanENT.TeachingPlanAuthor = objvTeachingPlanENS.TeachingPlanAuthor; //教案撰写人
objvTeachingPlanENT.TeachingObject = objvTeachingPlanENS.TeachingObject; //教学目标
objvTeachingPlanENT.TeachingEmphases = objvTeachingPlanENS.TeachingEmphases; //教学重点
objvTeachingPlanENT.TeachingDifficulty = objvTeachingPlanENS.TeachingDifficulty; //教学难点
objvTeachingPlanENT.TeachingTool = objvTeachingPlanENS.TeachingTool; //教学用具
objvTeachingPlanENT.TeachingProcess = objvTeachingPlanENS.TeachingProcess; //教学过程
objvTeachingPlanENT.TeachingPlanType = objvTeachingPlanENS.TeachingPlanType; //教案类型
objvTeachingPlanENT.TeachPlanTypeName = objvTeachingPlanENS.TeachPlanTypeName; //教案类型名称
objvTeachingPlanENT.SimplePlanContent = objvTeachingPlanENS.SimplePlanContent; //简案内容
objvTeachingPlanENT.TeachingPlanInDate = objvTeachingPlanENS.TeachingPlanInDate; //教案入库日期
objvTeachingPlanENT.TeachingPlanInTime = objvTeachingPlanENS.TeachingPlanInTime; //教案入库时间
objvTeachingPlanENT.Memo = objvTeachingPlanENS.Memo; //备注
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
 /// <param name = "objvTeachingPlanENS">源对象</param>
 /// <returns>目标对象=>clsvTeachingPlanEN:objvTeachingPlanENT</returns>
 public static clsvTeachingPlanEN CopyTo(this clsvTeachingPlanEN objvTeachingPlanENS)
{
try
{
 clsvTeachingPlanEN objvTeachingPlanENT = new clsvTeachingPlanEN()
{
IdTeachingPlan = objvTeachingPlanENS.IdTeachingPlan, //教案流水号
SubjectName = objvTeachingPlanENS.SubjectName, //课题名称
TeachingPlanAuthor = objvTeachingPlanENS.TeachingPlanAuthor, //教案撰写人
TeachingObject = objvTeachingPlanENS.TeachingObject, //教学目标
TeachingEmphases = objvTeachingPlanENS.TeachingEmphases, //教学重点
TeachingDifficulty = objvTeachingPlanENS.TeachingDifficulty, //教学难点
TeachingTool = objvTeachingPlanENS.TeachingTool, //教学用具
TeachingProcess = objvTeachingPlanENS.TeachingProcess, //教学过程
TeachingPlanType = objvTeachingPlanENS.TeachingPlanType, //教案类型
TeachPlanTypeName = objvTeachingPlanENS.TeachPlanTypeName, //教案类型名称
SimplePlanContent = objvTeachingPlanENS.SimplePlanContent, //简案内容
TeachingPlanInDate = objvTeachingPlanENS.TeachingPlanInDate, //教案入库日期
TeachingPlanInTime = objvTeachingPlanENS.TeachingPlanInTime, //教案入库时间
Memo = objvTeachingPlanENS.Memo, //备注
};
 return objvTeachingPlanENT;
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
public static void CheckProperty4Condition(this clsvTeachingPlanEN objvTeachingPlanEN)
{
 clsvTeachingPlanBL.vTeachingPlanDA.CheckProperty4Condition(objvTeachingPlanEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvTeachingPlanEN objvTeachingPlanCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvTeachingPlanCond.IsUpdated(convTeachingPlan.IdTeachingPlan) == true)
{
string strComparisonOpIdTeachingPlan = objvTeachingPlanCond.dicFldComparisonOp[convTeachingPlan.IdTeachingPlan];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingPlan.IdTeachingPlan, objvTeachingPlanCond.IdTeachingPlan, strComparisonOpIdTeachingPlan);
}
if (objvTeachingPlanCond.IsUpdated(convTeachingPlan.SubjectName) == true)
{
string strComparisonOpSubjectName = objvTeachingPlanCond.dicFldComparisonOp[convTeachingPlan.SubjectName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingPlan.SubjectName, objvTeachingPlanCond.SubjectName, strComparisonOpSubjectName);
}
if (objvTeachingPlanCond.IsUpdated(convTeachingPlan.TeachingPlanAuthor) == true)
{
string strComparisonOpTeachingPlanAuthor = objvTeachingPlanCond.dicFldComparisonOp[convTeachingPlan.TeachingPlanAuthor];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingPlan.TeachingPlanAuthor, objvTeachingPlanCond.TeachingPlanAuthor, strComparisonOpTeachingPlanAuthor);
}
if (objvTeachingPlanCond.IsUpdated(convTeachingPlan.TeachingObject) == true)
{
string strComparisonOpTeachingObject = objvTeachingPlanCond.dicFldComparisonOp[convTeachingPlan.TeachingObject];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingPlan.TeachingObject, objvTeachingPlanCond.TeachingObject, strComparisonOpTeachingObject);
}
if (objvTeachingPlanCond.IsUpdated(convTeachingPlan.TeachingEmphases) == true)
{
string strComparisonOpTeachingEmphases = objvTeachingPlanCond.dicFldComparisonOp[convTeachingPlan.TeachingEmphases];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingPlan.TeachingEmphases, objvTeachingPlanCond.TeachingEmphases, strComparisonOpTeachingEmphases);
}
if (objvTeachingPlanCond.IsUpdated(convTeachingPlan.TeachingDifficulty) == true)
{
string strComparisonOpTeachingDifficulty = objvTeachingPlanCond.dicFldComparisonOp[convTeachingPlan.TeachingDifficulty];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingPlan.TeachingDifficulty, objvTeachingPlanCond.TeachingDifficulty, strComparisonOpTeachingDifficulty);
}
if (objvTeachingPlanCond.IsUpdated(convTeachingPlan.TeachingTool) == true)
{
string strComparisonOpTeachingTool = objvTeachingPlanCond.dicFldComparisonOp[convTeachingPlan.TeachingTool];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingPlan.TeachingTool, objvTeachingPlanCond.TeachingTool, strComparisonOpTeachingTool);
}
if (objvTeachingPlanCond.IsUpdated(convTeachingPlan.TeachingProcess) == true)
{
string strComparisonOpTeachingProcess = objvTeachingPlanCond.dicFldComparisonOp[convTeachingPlan.TeachingProcess];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingPlan.TeachingProcess, objvTeachingPlanCond.TeachingProcess, strComparisonOpTeachingProcess);
}
if (objvTeachingPlanCond.IsUpdated(convTeachingPlan.TeachingPlanType) == true)
{
string strComparisonOpTeachingPlanType = objvTeachingPlanCond.dicFldComparisonOp[convTeachingPlan.TeachingPlanType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingPlan.TeachingPlanType, objvTeachingPlanCond.TeachingPlanType, strComparisonOpTeachingPlanType);
}
if (objvTeachingPlanCond.IsUpdated(convTeachingPlan.TeachPlanTypeName) == true)
{
string strComparisonOpTeachPlanTypeName = objvTeachingPlanCond.dicFldComparisonOp[convTeachingPlan.TeachPlanTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingPlan.TeachPlanTypeName, objvTeachingPlanCond.TeachPlanTypeName, strComparisonOpTeachPlanTypeName);
}
//数据类型string(text)在函数:[AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj]中没有处理!
if (objvTeachingPlanCond.IsUpdated(convTeachingPlan.TeachingPlanInDate) == true)
{
string strComparisonOpTeachingPlanInDate = objvTeachingPlanCond.dicFldComparisonOp[convTeachingPlan.TeachingPlanInDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingPlan.TeachingPlanInDate, objvTeachingPlanCond.TeachingPlanInDate, strComparisonOpTeachingPlanInDate);
}
if (objvTeachingPlanCond.IsUpdated(convTeachingPlan.TeachingPlanInTime) == true)
{
string strComparisonOpTeachingPlanInTime = objvTeachingPlanCond.dicFldComparisonOp[convTeachingPlan.TeachingPlanInTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingPlan.TeachingPlanInTime, objvTeachingPlanCond.TeachingPlanInTime, strComparisonOpTeachingPlanInTime);
}
if (objvTeachingPlanCond.IsUpdated(convTeachingPlan.Memo) == true)
{
string strComparisonOpMemo = objvTeachingPlanCond.dicFldComparisonOp[convTeachingPlan.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingPlan.Memo, objvTeachingPlanCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vTeachingPlan
{
public virtual bool UpdRelaTabDate(string strIdTeachingPlan, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v教案(vTeachingPlan)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvTeachingPlanBL
{
public static RelatedActions_vTeachingPlan relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvTeachingPlanDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvTeachingPlanDA vTeachingPlanDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvTeachingPlanDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvTeachingPlanBL()
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
if (string.IsNullOrEmpty(clsvTeachingPlanEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvTeachingPlanEN._ConnectString);
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
public static DataTable GetDataTable_vTeachingPlan(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vTeachingPlanDA.GetDataTable_vTeachingPlan(strWhereCond);
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
objDT = vTeachingPlanDA.GetDataTable(strWhereCond);
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
objDT = vTeachingPlanDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vTeachingPlanDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vTeachingPlanDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vTeachingPlanDA.GetDataTable_Top(objTopPara);
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
objDT = vTeachingPlanDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vTeachingPlanDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vTeachingPlanDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrIdTeachingPlanLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvTeachingPlanEN> GetObjLstByIdTeachingPlanLst(List<string> arrIdTeachingPlanLst)
{
List<clsvTeachingPlanEN> arrObjLst = new List<clsvTeachingPlanEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrIdTeachingPlanLst, true);
 string strWhereCond = string.Format("IdTeachingPlan in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvTeachingPlanEN objvTeachingPlanEN = new clsvTeachingPlanEN();
try
{
objvTeachingPlanEN.IdTeachingPlan = objRow[convTeachingPlan.IdTeachingPlan].ToString().Trim(); //教案流水号
objvTeachingPlanEN.SubjectName = objRow[convTeachingPlan.SubjectName].ToString().Trim(); //课题名称
objvTeachingPlanEN.TeachingPlanAuthor = objRow[convTeachingPlan.TeachingPlanAuthor] == DBNull.Value ? null : objRow[convTeachingPlan.TeachingPlanAuthor].ToString().Trim(); //教案撰写人
objvTeachingPlanEN.TeachingObject = objRow[convTeachingPlan.TeachingObject] == DBNull.Value ? null : objRow[convTeachingPlan.TeachingObject].ToString().Trim(); //教学目标
objvTeachingPlanEN.TeachingEmphases = objRow[convTeachingPlan.TeachingEmphases] == DBNull.Value ? null : objRow[convTeachingPlan.TeachingEmphases].ToString().Trim(); //教学重点
objvTeachingPlanEN.TeachingDifficulty = objRow[convTeachingPlan.TeachingDifficulty] == DBNull.Value ? null : objRow[convTeachingPlan.TeachingDifficulty].ToString().Trim(); //教学难点
objvTeachingPlanEN.TeachingTool = objRow[convTeachingPlan.TeachingTool] == DBNull.Value ? null : objRow[convTeachingPlan.TeachingTool].ToString().Trim(); //教学用具
objvTeachingPlanEN.TeachingProcess = objRow[convTeachingPlan.TeachingProcess] == DBNull.Value ? null : objRow[convTeachingPlan.TeachingProcess].ToString().Trim(); //教学过程
objvTeachingPlanEN.TeachingPlanType = objRow[convTeachingPlan.TeachingPlanType] == DBNull.Value ? null : objRow[convTeachingPlan.TeachingPlanType].ToString().Trim(); //教案类型
objvTeachingPlanEN.TeachPlanTypeName = objRow[convTeachingPlan.TeachPlanTypeName] == DBNull.Value ? null : objRow[convTeachingPlan.TeachPlanTypeName].ToString().Trim(); //教案类型名称
objvTeachingPlanEN.SimplePlanContent = objRow[convTeachingPlan.SimplePlanContent] == DBNull.Value ? null : objRow[convTeachingPlan.SimplePlanContent].ToString().Trim(); //简案内容
objvTeachingPlanEN.TeachingPlanInDate = objRow[convTeachingPlan.TeachingPlanInDate] == DBNull.Value ? null : objRow[convTeachingPlan.TeachingPlanInDate].ToString().Trim(); //教案入库日期
objvTeachingPlanEN.TeachingPlanInTime = objRow[convTeachingPlan.TeachingPlanInTime] == DBNull.Value ? null : objRow[convTeachingPlan.TeachingPlanInTime].ToString().Trim(); //教案入库时间
objvTeachingPlanEN.Memo = objRow[convTeachingPlan.Memo] == DBNull.Value ? null : objRow[convTeachingPlan.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvTeachingPlanEN.IdTeachingPlan, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvTeachingPlanEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrIdTeachingPlanLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvTeachingPlanEN> GetObjLstByIdTeachingPlanLstCache(List<string> arrIdTeachingPlanLst)
{
string strKey = string.Format("{0}", clsvTeachingPlanEN._CurrTabName);
List<clsvTeachingPlanEN> arrvTeachingPlanObjLstCache = GetObjLstCache();
IEnumerable <clsvTeachingPlanEN> arrvTeachingPlanObjLst_Sel =
arrvTeachingPlanObjLstCache
.Where(x => arrIdTeachingPlanLst.Contains(x.IdTeachingPlan));
return arrvTeachingPlanObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvTeachingPlanEN> GetObjLst(string strWhereCond)
{
List<clsvTeachingPlanEN> arrObjLst = new List<clsvTeachingPlanEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvTeachingPlanEN objvTeachingPlanEN = new clsvTeachingPlanEN();
try
{
objvTeachingPlanEN.IdTeachingPlan = objRow[convTeachingPlan.IdTeachingPlan].ToString().Trim(); //教案流水号
objvTeachingPlanEN.SubjectName = objRow[convTeachingPlan.SubjectName].ToString().Trim(); //课题名称
objvTeachingPlanEN.TeachingPlanAuthor = objRow[convTeachingPlan.TeachingPlanAuthor] == DBNull.Value ? null : objRow[convTeachingPlan.TeachingPlanAuthor].ToString().Trim(); //教案撰写人
objvTeachingPlanEN.TeachingObject = objRow[convTeachingPlan.TeachingObject] == DBNull.Value ? null : objRow[convTeachingPlan.TeachingObject].ToString().Trim(); //教学目标
objvTeachingPlanEN.TeachingEmphases = objRow[convTeachingPlan.TeachingEmphases] == DBNull.Value ? null : objRow[convTeachingPlan.TeachingEmphases].ToString().Trim(); //教学重点
objvTeachingPlanEN.TeachingDifficulty = objRow[convTeachingPlan.TeachingDifficulty] == DBNull.Value ? null : objRow[convTeachingPlan.TeachingDifficulty].ToString().Trim(); //教学难点
objvTeachingPlanEN.TeachingTool = objRow[convTeachingPlan.TeachingTool] == DBNull.Value ? null : objRow[convTeachingPlan.TeachingTool].ToString().Trim(); //教学用具
objvTeachingPlanEN.TeachingProcess = objRow[convTeachingPlan.TeachingProcess] == DBNull.Value ? null : objRow[convTeachingPlan.TeachingProcess].ToString().Trim(); //教学过程
objvTeachingPlanEN.TeachingPlanType = objRow[convTeachingPlan.TeachingPlanType] == DBNull.Value ? null : objRow[convTeachingPlan.TeachingPlanType].ToString().Trim(); //教案类型
objvTeachingPlanEN.TeachPlanTypeName = objRow[convTeachingPlan.TeachPlanTypeName] == DBNull.Value ? null : objRow[convTeachingPlan.TeachPlanTypeName].ToString().Trim(); //教案类型名称
objvTeachingPlanEN.SimplePlanContent = objRow[convTeachingPlan.SimplePlanContent] == DBNull.Value ? null : objRow[convTeachingPlan.SimplePlanContent].ToString().Trim(); //简案内容
objvTeachingPlanEN.TeachingPlanInDate = objRow[convTeachingPlan.TeachingPlanInDate] == DBNull.Value ? null : objRow[convTeachingPlan.TeachingPlanInDate].ToString().Trim(); //教案入库日期
objvTeachingPlanEN.TeachingPlanInTime = objRow[convTeachingPlan.TeachingPlanInTime] == DBNull.Value ? null : objRow[convTeachingPlan.TeachingPlanInTime].ToString().Trim(); //教案入库时间
objvTeachingPlanEN.Memo = objRow[convTeachingPlan.Memo] == DBNull.Value ? null : objRow[convTeachingPlan.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvTeachingPlanEN.IdTeachingPlan, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvTeachingPlanEN);
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
public static List<clsvTeachingPlanEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvTeachingPlanEN> arrObjLst = new List<clsvTeachingPlanEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvTeachingPlanEN objvTeachingPlanEN = new clsvTeachingPlanEN();
try
{
objvTeachingPlanEN.IdTeachingPlan = objRow[convTeachingPlan.IdTeachingPlan].ToString().Trim(); //教案流水号
objvTeachingPlanEN.SubjectName = objRow[convTeachingPlan.SubjectName].ToString().Trim(); //课题名称
objvTeachingPlanEN.TeachingPlanAuthor = objRow[convTeachingPlan.TeachingPlanAuthor] == DBNull.Value ? null : objRow[convTeachingPlan.TeachingPlanAuthor].ToString().Trim(); //教案撰写人
objvTeachingPlanEN.TeachingObject = objRow[convTeachingPlan.TeachingObject] == DBNull.Value ? null : objRow[convTeachingPlan.TeachingObject].ToString().Trim(); //教学目标
objvTeachingPlanEN.TeachingEmphases = objRow[convTeachingPlan.TeachingEmphases] == DBNull.Value ? null : objRow[convTeachingPlan.TeachingEmphases].ToString().Trim(); //教学重点
objvTeachingPlanEN.TeachingDifficulty = objRow[convTeachingPlan.TeachingDifficulty] == DBNull.Value ? null : objRow[convTeachingPlan.TeachingDifficulty].ToString().Trim(); //教学难点
objvTeachingPlanEN.TeachingTool = objRow[convTeachingPlan.TeachingTool] == DBNull.Value ? null : objRow[convTeachingPlan.TeachingTool].ToString().Trim(); //教学用具
objvTeachingPlanEN.TeachingProcess = objRow[convTeachingPlan.TeachingProcess] == DBNull.Value ? null : objRow[convTeachingPlan.TeachingProcess].ToString().Trim(); //教学过程
objvTeachingPlanEN.TeachingPlanType = objRow[convTeachingPlan.TeachingPlanType] == DBNull.Value ? null : objRow[convTeachingPlan.TeachingPlanType].ToString().Trim(); //教案类型
objvTeachingPlanEN.TeachPlanTypeName = objRow[convTeachingPlan.TeachPlanTypeName] == DBNull.Value ? null : objRow[convTeachingPlan.TeachPlanTypeName].ToString().Trim(); //教案类型名称
objvTeachingPlanEN.SimplePlanContent = objRow[convTeachingPlan.SimplePlanContent] == DBNull.Value ? null : objRow[convTeachingPlan.SimplePlanContent].ToString().Trim(); //简案内容
objvTeachingPlanEN.TeachingPlanInDate = objRow[convTeachingPlan.TeachingPlanInDate] == DBNull.Value ? null : objRow[convTeachingPlan.TeachingPlanInDate].ToString().Trim(); //教案入库日期
objvTeachingPlanEN.TeachingPlanInTime = objRow[convTeachingPlan.TeachingPlanInTime] == DBNull.Value ? null : objRow[convTeachingPlan.TeachingPlanInTime].ToString().Trim(); //教案入库时间
objvTeachingPlanEN.Memo = objRow[convTeachingPlan.Memo] == DBNull.Value ? null : objRow[convTeachingPlan.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvTeachingPlanEN.IdTeachingPlan, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvTeachingPlanEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvTeachingPlanCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvTeachingPlanEN> GetSubObjLstCache(clsvTeachingPlanEN objvTeachingPlanCond)
{
List<clsvTeachingPlanEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvTeachingPlanEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convTeachingPlan.AttributeName)
{
if (objvTeachingPlanCond.IsUpdated(strFldName) == false) continue;
if (objvTeachingPlanCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvTeachingPlanCond[strFldName].ToString());
}
else
{
if (objvTeachingPlanCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvTeachingPlanCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvTeachingPlanCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvTeachingPlanCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvTeachingPlanCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvTeachingPlanCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvTeachingPlanCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvTeachingPlanCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvTeachingPlanCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvTeachingPlanCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvTeachingPlanCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvTeachingPlanCond[strFldName]));
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
public static List<clsvTeachingPlanEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvTeachingPlanEN> arrObjLst = new List<clsvTeachingPlanEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvTeachingPlanEN objvTeachingPlanEN = new clsvTeachingPlanEN();
try
{
objvTeachingPlanEN.IdTeachingPlan = objRow[convTeachingPlan.IdTeachingPlan].ToString().Trim(); //教案流水号
objvTeachingPlanEN.SubjectName = objRow[convTeachingPlan.SubjectName].ToString().Trim(); //课题名称
objvTeachingPlanEN.TeachingPlanAuthor = objRow[convTeachingPlan.TeachingPlanAuthor] == DBNull.Value ? null : objRow[convTeachingPlan.TeachingPlanAuthor].ToString().Trim(); //教案撰写人
objvTeachingPlanEN.TeachingObject = objRow[convTeachingPlan.TeachingObject] == DBNull.Value ? null : objRow[convTeachingPlan.TeachingObject].ToString().Trim(); //教学目标
objvTeachingPlanEN.TeachingEmphases = objRow[convTeachingPlan.TeachingEmphases] == DBNull.Value ? null : objRow[convTeachingPlan.TeachingEmphases].ToString().Trim(); //教学重点
objvTeachingPlanEN.TeachingDifficulty = objRow[convTeachingPlan.TeachingDifficulty] == DBNull.Value ? null : objRow[convTeachingPlan.TeachingDifficulty].ToString().Trim(); //教学难点
objvTeachingPlanEN.TeachingTool = objRow[convTeachingPlan.TeachingTool] == DBNull.Value ? null : objRow[convTeachingPlan.TeachingTool].ToString().Trim(); //教学用具
objvTeachingPlanEN.TeachingProcess = objRow[convTeachingPlan.TeachingProcess] == DBNull.Value ? null : objRow[convTeachingPlan.TeachingProcess].ToString().Trim(); //教学过程
objvTeachingPlanEN.TeachingPlanType = objRow[convTeachingPlan.TeachingPlanType] == DBNull.Value ? null : objRow[convTeachingPlan.TeachingPlanType].ToString().Trim(); //教案类型
objvTeachingPlanEN.TeachPlanTypeName = objRow[convTeachingPlan.TeachPlanTypeName] == DBNull.Value ? null : objRow[convTeachingPlan.TeachPlanTypeName].ToString().Trim(); //教案类型名称
objvTeachingPlanEN.SimplePlanContent = objRow[convTeachingPlan.SimplePlanContent] == DBNull.Value ? null : objRow[convTeachingPlan.SimplePlanContent].ToString().Trim(); //简案内容
objvTeachingPlanEN.TeachingPlanInDate = objRow[convTeachingPlan.TeachingPlanInDate] == DBNull.Value ? null : objRow[convTeachingPlan.TeachingPlanInDate].ToString().Trim(); //教案入库日期
objvTeachingPlanEN.TeachingPlanInTime = objRow[convTeachingPlan.TeachingPlanInTime] == DBNull.Value ? null : objRow[convTeachingPlan.TeachingPlanInTime].ToString().Trim(); //教案入库时间
objvTeachingPlanEN.Memo = objRow[convTeachingPlan.Memo] == DBNull.Value ? null : objRow[convTeachingPlan.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvTeachingPlanEN.IdTeachingPlan, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvTeachingPlanEN);
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
public static List<clsvTeachingPlanEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvTeachingPlanEN> arrObjLst = new List<clsvTeachingPlanEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvTeachingPlanEN objvTeachingPlanEN = new clsvTeachingPlanEN();
try
{
objvTeachingPlanEN.IdTeachingPlan = objRow[convTeachingPlan.IdTeachingPlan].ToString().Trim(); //教案流水号
objvTeachingPlanEN.SubjectName = objRow[convTeachingPlan.SubjectName].ToString().Trim(); //课题名称
objvTeachingPlanEN.TeachingPlanAuthor = objRow[convTeachingPlan.TeachingPlanAuthor] == DBNull.Value ? null : objRow[convTeachingPlan.TeachingPlanAuthor].ToString().Trim(); //教案撰写人
objvTeachingPlanEN.TeachingObject = objRow[convTeachingPlan.TeachingObject] == DBNull.Value ? null : objRow[convTeachingPlan.TeachingObject].ToString().Trim(); //教学目标
objvTeachingPlanEN.TeachingEmphases = objRow[convTeachingPlan.TeachingEmphases] == DBNull.Value ? null : objRow[convTeachingPlan.TeachingEmphases].ToString().Trim(); //教学重点
objvTeachingPlanEN.TeachingDifficulty = objRow[convTeachingPlan.TeachingDifficulty] == DBNull.Value ? null : objRow[convTeachingPlan.TeachingDifficulty].ToString().Trim(); //教学难点
objvTeachingPlanEN.TeachingTool = objRow[convTeachingPlan.TeachingTool] == DBNull.Value ? null : objRow[convTeachingPlan.TeachingTool].ToString().Trim(); //教学用具
objvTeachingPlanEN.TeachingProcess = objRow[convTeachingPlan.TeachingProcess] == DBNull.Value ? null : objRow[convTeachingPlan.TeachingProcess].ToString().Trim(); //教学过程
objvTeachingPlanEN.TeachingPlanType = objRow[convTeachingPlan.TeachingPlanType] == DBNull.Value ? null : objRow[convTeachingPlan.TeachingPlanType].ToString().Trim(); //教案类型
objvTeachingPlanEN.TeachPlanTypeName = objRow[convTeachingPlan.TeachPlanTypeName] == DBNull.Value ? null : objRow[convTeachingPlan.TeachPlanTypeName].ToString().Trim(); //教案类型名称
objvTeachingPlanEN.SimplePlanContent = objRow[convTeachingPlan.SimplePlanContent] == DBNull.Value ? null : objRow[convTeachingPlan.SimplePlanContent].ToString().Trim(); //简案内容
objvTeachingPlanEN.TeachingPlanInDate = objRow[convTeachingPlan.TeachingPlanInDate] == DBNull.Value ? null : objRow[convTeachingPlan.TeachingPlanInDate].ToString().Trim(); //教案入库日期
objvTeachingPlanEN.TeachingPlanInTime = objRow[convTeachingPlan.TeachingPlanInTime] == DBNull.Value ? null : objRow[convTeachingPlan.TeachingPlanInTime].ToString().Trim(); //教案入库时间
objvTeachingPlanEN.Memo = objRow[convTeachingPlan.Memo] == DBNull.Value ? null : objRow[convTeachingPlan.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvTeachingPlanEN.IdTeachingPlan, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvTeachingPlanEN);
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
List<clsvTeachingPlanEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvTeachingPlanEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvTeachingPlanEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvTeachingPlanEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvTeachingPlanEN> arrObjLst = new List<clsvTeachingPlanEN>(); 
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
	clsvTeachingPlanEN objvTeachingPlanEN = new clsvTeachingPlanEN();
try
{
objvTeachingPlanEN.IdTeachingPlan = objRow[convTeachingPlan.IdTeachingPlan].ToString().Trim(); //教案流水号
objvTeachingPlanEN.SubjectName = objRow[convTeachingPlan.SubjectName].ToString().Trim(); //课题名称
objvTeachingPlanEN.TeachingPlanAuthor = objRow[convTeachingPlan.TeachingPlanAuthor] == DBNull.Value ? null : objRow[convTeachingPlan.TeachingPlanAuthor].ToString().Trim(); //教案撰写人
objvTeachingPlanEN.TeachingObject = objRow[convTeachingPlan.TeachingObject] == DBNull.Value ? null : objRow[convTeachingPlan.TeachingObject].ToString().Trim(); //教学目标
objvTeachingPlanEN.TeachingEmphases = objRow[convTeachingPlan.TeachingEmphases] == DBNull.Value ? null : objRow[convTeachingPlan.TeachingEmphases].ToString().Trim(); //教学重点
objvTeachingPlanEN.TeachingDifficulty = objRow[convTeachingPlan.TeachingDifficulty] == DBNull.Value ? null : objRow[convTeachingPlan.TeachingDifficulty].ToString().Trim(); //教学难点
objvTeachingPlanEN.TeachingTool = objRow[convTeachingPlan.TeachingTool] == DBNull.Value ? null : objRow[convTeachingPlan.TeachingTool].ToString().Trim(); //教学用具
objvTeachingPlanEN.TeachingProcess = objRow[convTeachingPlan.TeachingProcess] == DBNull.Value ? null : objRow[convTeachingPlan.TeachingProcess].ToString().Trim(); //教学过程
objvTeachingPlanEN.TeachingPlanType = objRow[convTeachingPlan.TeachingPlanType] == DBNull.Value ? null : objRow[convTeachingPlan.TeachingPlanType].ToString().Trim(); //教案类型
objvTeachingPlanEN.TeachPlanTypeName = objRow[convTeachingPlan.TeachPlanTypeName] == DBNull.Value ? null : objRow[convTeachingPlan.TeachPlanTypeName].ToString().Trim(); //教案类型名称
objvTeachingPlanEN.SimplePlanContent = objRow[convTeachingPlan.SimplePlanContent] == DBNull.Value ? null : objRow[convTeachingPlan.SimplePlanContent].ToString().Trim(); //简案内容
objvTeachingPlanEN.TeachingPlanInDate = objRow[convTeachingPlan.TeachingPlanInDate] == DBNull.Value ? null : objRow[convTeachingPlan.TeachingPlanInDate].ToString().Trim(); //教案入库日期
objvTeachingPlanEN.TeachingPlanInTime = objRow[convTeachingPlan.TeachingPlanInTime] == DBNull.Value ? null : objRow[convTeachingPlan.TeachingPlanInTime].ToString().Trim(); //教案入库时间
objvTeachingPlanEN.Memo = objRow[convTeachingPlan.Memo] == DBNull.Value ? null : objRow[convTeachingPlan.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvTeachingPlanEN.IdTeachingPlan, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvTeachingPlanEN);
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
public static List<clsvTeachingPlanEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvTeachingPlanEN> arrObjLst = new List<clsvTeachingPlanEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvTeachingPlanEN objvTeachingPlanEN = new clsvTeachingPlanEN();
try
{
objvTeachingPlanEN.IdTeachingPlan = objRow[convTeachingPlan.IdTeachingPlan].ToString().Trim(); //教案流水号
objvTeachingPlanEN.SubjectName = objRow[convTeachingPlan.SubjectName].ToString().Trim(); //课题名称
objvTeachingPlanEN.TeachingPlanAuthor = objRow[convTeachingPlan.TeachingPlanAuthor] == DBNull.Value ? null : objRow[convTeachingPlan.TeachingPlanAuthor].ToString().Trim(); //教案撰写人
objvTeachingPlanEN.TeachingObject = objRow[convTeachingPlan.TeachingObject] == DBNull.Value ? null : objRow[convTeachingPlan.TeachingObject].ToString().Trim(); //教学目标
objvTeachingPlanEN.TeachingEmphases = objRow[convTeachingPlan.TeachingEmphases] == DBNull.Value ? null : objRow[convTeachingPlan.TeachingEmphases].ToString().Trim(); //教学重点
objvTeachingPlanEN.TeachingDifficulty = objRow[convTeachingPlan.TeachingDifficulty] == DBNull.Value ? null : objRow[convTeachingPlan.TeachingDifficulty].ToString().Trim(); //教学难点
objvTeachingPlanEN.TeachingTool = objRow[convTeachingPlan.TeachingTool] == DBNull.Value ? null : objRow[convTeachingPlan.TeachingTool].ToString().Trim(); //教学用具
objvTeachingPlanEN.TeachingProcess = objRow[convTeachingPlan.TeachingProcess] == DBNull.Value ? null : objRow[convTeachingPlan.TeachingProcess].ToString().Trim(); //教学过程
objvTeachingPlanEN.TeachingPlanType = objRow[convTeachingPlan.TeachingPlanType] == DBNull.Value ? null : objRow[convTeachingPlan.TeachingPlanType].ToString().Trim(); //教案类型
objvTeachingPlanEN.TeachPlanTypeName = objRow[convTeachingPlan.TeachPlanTypeName] == DBNull.Value ? null : objRow[convTeachingPlan.TeachPlanTypeName].ToString().Trim(); //教案类型名称
objvTeachingPlanEN.SimplePlanContent = objRow[convTeachingPlan.SimplePlanContent] == DBNull.Value ? null : objRow[convTeachingPlan.SimplePlanContent].ToString().Trim(); //简案内容
objvTeachingPlanEN.TeachingPlanInDate = objRow[convTeachingPlan.TeachingPlanInDate] == DBNull.Value ? null : objRow[convTeachingPlan.TeachingPlanInDate].ToString().Trim(); //教案入库日期
objvTeachingPlanEN.TeachingPlanInTime = objRow[convTeachingPlan.TeachingPlanInTime] == DBNull.Value ? null : objRow[convTeachingPlan.TeachingPlanInTime].ToString().Trim(); //教案入库时间
objvTeachingPlanEN.Memo = objRow[convTeachingPlan.Memo] == DBNull.Value ? null : objRow[convTeachingPlan.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvTeachingPlanEN.IdTeachingPlan, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvTeachingPlanEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvTeachingPlanEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvTeachingPlanEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvTeachingPlanEN> arrObjLst = new List<clsvTeachingPlanEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvTeachingPlanEN objvTeachingPlanEN = new clsvTeachingPlanEN();
try
{
objvTeachingPlanEN.IdTeachingPlan = objRow[convTeachingPlan.IdTeachingPlan].ToString().Trim(); //教案流水号
objvTeachingPlanEN.SubjectName = objRow[convTeachingPlan.SubjectName].ToString().Trim(); //课题名称
objvTeachingPlanEN.TeachingPlanAuthor = objRow[convTeachingPlan.TeachingPlanAuthor] == DBNull.Value ? null : objRow[convTeachingPlan.TeachingPlanAuthor].ToString().Trim(); //教案撰写人
objvTeachingPlanEN.TeachingObject = objRow[convTeachingPlan.TeachingObject] == DBNull.Value ? null : objRow[convTeachingPlan.TeachingObject].ToString().Trim(); //教学目标
objvTeachingPlanEN.TeachingEmphases = objRow[convTeachingPlan.TeachingEmphases] == DBNull.Value ? null : objRow[convTeachingPlan.TeachingEmphases].ToString().Trim(); //教学重点
objvTeachingPlanEN.TeachingDifficulty = objRow[convTeachingPlan.TeachingDifficulty] == DBNull.Value ? null : objRow[convTeachingPlan.TeachingDifficulty].ToString().Trim(); //教学难点
objvTeachingPlanEN.TeachingTool = objRow[convTeachingPlan.TeachingTool] == DBNull.Value ? null : objRow[convTeachingPlan.TeachingTool].ToString().Trim(); //教学用具
objvTeachingPlanEN.TeachingProcess = objRow[convTeachingPlan.TeachingProcess] == DBNull.Value ? null : objRow[convTeachingPlan.TeachingProcess].ToString().Trim(); //教学过程
objvTeachingPlanEN.TeachingPlanType = objRow[convTeachingPlan.TeachingPlanType] == DBNull.Value ? null : objRow[convTeachingPlan.TeachingPlanType].ToString().Trim(); //教案类型
objvTeachingPlanEN.TeachPlanTypeName = objRow[convTeachingPlan.TeachPlanTypeName] == DBNull.Value ? null : objRow[convTeachingPlan.TeachPlanTypeName].ToString().Trim(); //教案类型名称
objvTeachingPlanEN.SimplePlanContent = objRow[convTeachingPlan.SimplePlanContent] == DBNull.Value ? null : objRow[convTeachingPlan.SimplePlanContent].ToString().Trim(); //简案内容
objvTeachingPlanEN.TeachingPlanInDate = objRow[convTeachingPlan.TeachingPlanInDate] == DBNull.Value ? null : objRow[convTeachingPlan.TeachingPlanInDate].ToString().Trim(); //教案入库日期
objvTeachingPlanEN.TeachingPlanInTime = objRow[convTeachingPlan.TeachingPlanInTime] == DBNull.Value ? null : objRow[convTeachingPlan.TeachingPlanInTime].ToString().Trim(); //教案入库时间
objvTeachingPlanEN.Memo = objRow[convTeachingPlan.Memo] == DBNull.Value ? null : objRow[convTeachingPlan.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvTeachingPlanEN.IdTeachingPlan, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvTeachingPlanEN);
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
public static List<clsvTeachingPlanEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvTeachingPlanEN> arrObjLst = new List<clsvTeachingPlanEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvTeachingPlanEN objvTeachingPlanEN = new clsvTeachingPlanEN();
try
{
objvTeachingPlanEN.IdTeachingPlan = objRow[convTeachingPlan.IdTeachingPlan].ToString().Trim(); //教案流水号
objvTeachingPlanEN.SubjectName = objRow[convTeachingPlan.SubjectName].ToString().Trim(); //课题名称
objvTeachingPlanEN.TeachingPlanAuthor = objRow[convTeachingPlan.TeachingPlanAuthor] == DBNull.Value ? null : objRow[convTeachingPlan.TeachingPlanAuthor].ToString().Trim(); //教案撰写人
objvTeachingPlanEN.TeachingObject = objRow[convTeachingPlan.TeachingObject] == DBNull.Value ? null : objRow[convTeachingPlan.TeachingObject].ToString().Trim(); //教学目标
objvTeachingPlanEN.TeachingEmphases = objRow[convTeachingPlan.TeachingEmphases] == DBNull.Value ? null : objRow[convTeachingPlan.TeachingEmphases].ToString().Trim(); //教学重点
objvTeachingPlanEN.TeachingDifficulty = objRow[convTeachingPlan.TeachingDifficulty] == DBNull.Value ? null : objRow[convTeachingPlan.TeachingDifficulty].ToString().Trim(); //教学难点
objvTeachingPlanEN.TeachingTool = objRow[convTeachingPlan.TeachingTool] == DBNull.Value ? null : objRow[convTeachingPlan.TeachingTool].ToString().Trim(); //教学用具
objvTeachingPlanEN.TeachingProcess = objRow[convTeachingPlan.TeachingProcess] == DBNull.Value ? null : objRow[convTeachingPlan.TeachingProcess].ToString().Trim(); //教学过程
objvTeachingPlanEN.TeachingPlanType = objRow[convTeachingPlan.TeachingPlanType] == DBNull.Value ? null : objRow[convTeachingPlan.TeachingPlanType].ToString().Trim(); //教案类型
objvTeachingPlanEN.TeachPlanTypeName = objRow[convTeachingPlan.TeachPlanTypeName] == DBNull.Value ? null : objRow[convTeachingPlan.TeachPlanTypeName].ToString().Trim(); //教案类型名称
objvTeachingPlanEN.SimplePlanContent = objRow[convTeachingPlan.SimplePlanContent] == DBNull.Value ? null : objRow[convTeachingPlan.SimplePlanContent].ToString().Trim(); //简案内容
objvTeachingPlanEN.TeachingPlanInDate = objRow[convTeachingPlan.TeachingPlanInDate] == DBNull.Value ? null : objRow[convTeachingPlan.TeachingPlanInDate].ToString().Trim(); //教案入库日期
objvTeachingPlanEN.TeachingPlanInTime = objRow[convTeachingPlan.TeachingPlanInTime] == DBNull.Value ? null : objRow[convTeachingPlan.TeachingPlanInTime].ToString().Trim(); //教案入库时间
objvTeachingPlanEN.Memo = objRow[convTeachingPlan.Memo] == DBNull.Value ? null : objRow[convTeachingPlan.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvTeachingPlanEN.IdTeachingPlan, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvTeachingPlanEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvTeachingPlanEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvTeachingPlanEN> arrObjLst = new List<clsvTeachingPlanEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvTeachingPlanEN objvTeachingPlanEN = new clsvTeachingPlanEN();
try
{
objvTeachingPlanEN.IdTeachingPlan = objRow[convTeachingPlan.IdTeachingPlan].ToString().Trim(); //教案流水号
objvTeachingPlanEN.SubjectName = objRow[convTeachingPlan.SubjectName].ToString().Trim(); //课题名称
objvTeachingPlanEN.TeachingPlanAuthor = objRow[convTeachingPlan.TeachingPlanAuthor] == DBNull.Value ? null : objRow[convTeachingPlan.TeachingPlanAuthor].ToString().Trim(); //教案撰写人
objvTeachingPlanEN.TeachingObject = objRow[convTeachingPlan.TeachingObject] == DBNull.Value ? null : objRow[convTeachingPlan.TeachingObject].ToString().Trim(); //教学目标
objvTeachingPlanEN.TeachingEmphases = objRow[convTeachingPlan.TeachingEmphases] == DBNull.Value ? null : objRow[convTeachingPlan.TeachingEmphases].ToString().Trim(); //教学重点
objvTeachingPlanEN.TeachingDifficulty = objRow[convTeachingPlan.TeachingDifficulty] == DBNull.Value ? null : objRow[convTeachingPlan.TeachingDifficulty].ToString().Trim(); //教学难点
objvTeachingPlanEN.TeachingTool = objRow[convTeachingPlan.TeachingTool] == DBNull.Value ? null : objRow[convTeachingPlan.TeachingTool].ToString().Trim(); //教学用具
objvTeachingPlanEN.TeachingProcess = objRow[convTeachingPlan.TeachingProcess] == DBNull.Value ? null : objRow[convTeachingPlan.TeachingProcess].ToString().Trim(); //教学过程
objvTeachingPlanEN.TeachingPlanType = objRow[convTeachingPlan.TeachingPlanType] == DBNull.Value ? null : objRow[convTeachingPlan.TeachingPlanType].ToString().Trim(); //教案类型
objvTeachingPlanEN.TeachPlanTypeName = objRow[convTeachingPlan.TeachPlanTypeName] == DBNull.Value ? null : objRow[convTeachingPlan.TeachPlanTypeName].ToString().Trim(); //教案类型名称
objvTeachingPlanEN.SimplePlanContent = objRow[convTeachingPlan.SimplePlanContent] == DBNull.Value ? null : objRow[convTeachingPlan.SimplePlanContent].ToString().Trim(); //简案内容
objvTeachingPlanEN.TeachingPlanInDate = objRow[convTeachingPlan.TeachingPlanInDate] == DBNull.Value ? null : objRow[convTeachingPlan.TeachingPlanInDate].ToString().Trim(); //教案入库日期
objvTeachingPlanEN.TeachingPlanInTime = objRow[convTeachingPlan.TeachingPlanInTime] == DBNull.Value ? null : objRow[convTeachingPlan.TeachingPlanInTime].ToString().Trim(); //教案入库时间
objvTeachingPlanEN.Memo = objRow[convTeachingPlan.Memo] == DBNull.Value ? null : objRow[convTeachingPlan.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvTeachingPlanEN.IdTeachingPlan, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvTeachingPlanEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvTeachingPlanEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvTeachingPlan(ref clsvTeachingPlanEN objvTeachingPlanEN)
{
bool bolResult = vTeachingPlanDA.GetvTeachingPlan(ref objvTeachingPlanEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strIdTeachingPlan">表关键字</param>
 /// <returns>表对象</returns>
public static clsvTeachingPlanEN GetObjByIdTeachingPlan(string strIdTeachingPlan)
{
if (strIdTeachingPlan.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strIdTeachingPlan]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strIdTeachingPlan) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strIdTeachingPlan]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsvTeachingPlanEN objvTeachingPlanEN = vTeachingPlanDA.GetObjByIdTeachingPlan(strIdTeachingPlan);
return objvTeachingPlanEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvTeachingPlanEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvTeachingPlanEN objvTeachingPlanEN = vTeachingPlanDA.GetFirstObj(strWhereCond);
 return objvTeachingPlanEN;
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
public static clsvTeachingPlanEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvTeachingPlanEN objvTeachingPlanEN = vTeachingPlanDA.GetObjByDataRow(objRow);
 return objvTeachingPlanEN;
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
public static clsvTeachingPlanEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvTeachingPlanEN objvTeachingPlanEN = vTeachingPlanDA.GetObjByDataRow(objRow);
 return objvTeachingPlanEN;
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
 /// <param name = "strIdTeachingPlan">所给的关键字</param>
 /// <param name = "lstvTeachingPlanObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvTeachingPlanEN GetObjByIdTeachingPlanFromList(string strIdTeachingPlan, List<clsvTeachingPlanEN> lstvTeachingPlanObjLst)
{
foreach (clsvTeachingPlanEN objvTeachingPlanEN in lstvTeachingPlanObjLst)
{
if (objvTeachingPlanEN.IdTeachingPlan == strIdTeachingPlan)
{
return objvTeachingPlanEN;
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
 string strIdTeachingPlan;
 try
 {
 strIdTeachingPlan = new clsvTeachingPlanDA().GetFirstID(strWhereCond);
 return strIdTeachingPlan;
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
 arrList = vTeachingPlanDA.GetID(strWhereCond);
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
bool bolIsExist = vTeachingPlanDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strIdTeachingPlan">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strIdTeachingPlan)
{
if (string.IsNullOrEmpty(strIdTeachingPlan) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strIdTeachingPlan]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = vTeachingPlanDA.IsExist(strIdTeachingPlan);
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
 bolIsExist = clsvTeachingPlanDA.IsExistTable();
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
 bolIsExist = vTeachingPlanDA.IsExistTable(strTabName);
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
 /// <param name = "objvTeachingPlanENS">源对象</param>
 /// <param name = "objvTeachingPlanENT">目标对象</param>
 public static void CopyTo(clsvTeachingPlanEN objvTeachingPlanENS, clsvTeachingPlanEN objvTeachingPlanENT)
{
try
{
objvTeachingPlanENT.IdTeachingPlan = objvTeachingPlanENS.IdTeachingPlan; //教案流水号
objvTeachingPlanENT.SubjectName = objvTeachingPlanENS.SubjectName; //课题名称
objvTeachingPlanENT.TeachingPlanAuthor = objvTeachingPlanENS.TeachingPlanAuthor; //教案撰写人
objvTeachingPlanENT.TeachingObject = objvTeachingPlanENS.TeachingObject; //教学目标
objvTeachingPlanENT.TeachingEmphases = objvTeachingPlanENS.TeachingEmphases; //教学重点
objvTeachingPlanENT.TeachingDifficulty = objvTeachingPlanENS.TeachingDifficulty; //教学难点
objvTeachingPlanENT.TeachingTool = objvTeachingPlanENS.TeachingTool; //教学用具
objvTeachingPlanENT.TeachingProcess = objvTeachingPlanENS.TeachingProcess; //教学过程
objvTeachingPlanENT.TeachingPlanType = objvTeachingPlanENS.TeachingPlanType; //教案类型
objvTeachingPlanENT.TeachPlanTypeName = objvTeachingPlanENS.TeachPlanTypeName; //教案类型名称
objvTeachingPlanENT.SimplePlanContent = objvTeachingPlanENS.SimplePlanContent; //简案内容
objvTeachingPlanENT.TeachingPlanInDate = objvTeachingPlanENS.TeachingPlanInDate; //教案入库日期
objvTeachingPlanENT.TeachingPlanInTime = objvTeachingPlanENS.TeachingPlanInTime; //教案入库时间
objvTeachingPlanENT.Memo = objvTeachingPlanENS.Memo; //备注
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
 /// <param name = "objvTeachingPlanEN">源简化对象</param>
 public static void SetUpdFlag(clsvTeachingPlanEN objvTeachingPlanEN)
{
try
{
objvTeachingPlanEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvTeachingPlanEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convTeachingPlan.IdTeachingPlan, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingPlanEN.IdTeachingPlan = objvTeachingPlanEN.IdTeachingPlan; //教案流水号
}
if (arrFldSet.Contains(convTeachingPlan.SubjectName, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingPlanEN.SubjectName = objvTeachingPlanEN.SubjectName; //课题名称
}
if (arrFldSet.Contains(convTeachingPlan.TeachingPlanAuthor, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingPlanEN.TeachingPlanAuthor = objvTeachingPlanEN.TeachingPlanAuthor == "[null]" ? null :  objvTeachingPlanEN.TeachingPlanAuthor; //教案撰写人
}
if (arrFldSet.Contains(convTeachingPlan.TeachingObject, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingPlanEN.TeachingObject = objvTeachingPlanEN.TeachingObject == "[null]" ? null :  objvTeachingPlanEN.TeachingObject; //教学目标
}
if (arrFldSet.Contains(convTeachingPlan.TeachingEmphases, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingPlanEN.TeachingEmphases = objvTeachingPlanEN.TeachingEmphases == "[null]" ? null :  objvTeachingPlanEN.TeachingEmphases; //教学重点
}
if (arrFldSet.Contains(convTeachingPlan.TeachingDifficulty, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingPlanEN.TeachingDifficulty = objvTeachingPlanEN.TeachingDifficulty == "[null]" ? null :  objvTeachingPlanEN.TeachingDifficulty; //教学难点
}
if (arrFldSet.Contains(convTeachingPlan.TeachingTool, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingPlanEN.TeachingTool = objvTeachingPlanEN.TeachingTool == "[null]" ? null :  objvTeachingPlanEN.TeachingTool; //教学用具
}
if (arrFldSet.Contains(convTeachingPlan.TeachingProcess, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingPlanEN.TeachingProcess = objvTeachingPlanEN.TeachingProcess == "[null]" ? null :  objvTeachingPlanEN.TeachingProcess; //教学过程
}
if (arrFldSet.Contains(convTeachingPlan.TeachingPlanType, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingPlanEN.TeachingPlanType = objvTeachingPlanEN.TeachingPlanType == "[null]" ? null :  objvTeachingPlanEN.TeachingPlanType; //教案类型
}
if (arrFldSet.Contains(convTeachingPlan.TeachPlanTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingPlanEN.TeachPlanTypeName = objvTeachingPlanEN.TeachPlanTypeName == "[null]" ? null :  objvTeachingPlanEN.TeachPlanTypeName; //教案类型名称
}
if (arrFldSet.Contains(convTeachingPlan.SimplePlanContent, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingPlanEN.SimplePlanContent = objvTeachingPlanEN.SimplePlanContent == "[null]" ? null :  objvTeachingPlanEN.SimplePlanContent; //简案内容
}
if (arrFldSet.Contains(convTeachingPlan.TeachingPlanInDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingPlanEN.TeachingPlanInDate = objvTeachingPlanEN.TeachingPlanInDate == "[null]" ? null :  objvTeachingPlanEN.TeachingPlanInDate; //教案入库日期
}
if (arrFldSet.Contains(convTeachingPlan.TeachingPlanInTime, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingPlanEN.TeachingPlanInTime = objvTeachingPlanEN.TeachingPlanInTime == "[null]" ? null :  objvTeachingPlanEN.TeachingPlanInTime; //教案入库时间
}
if (arrFldSet.Contains(convTeachingPlan.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingPlanEN.Memo = objvTeachingPlanEN.Memo == "[null]" ? null :  objvTeachingPlanEN.Memo; //备注
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
 /// <param name = "objvTeachingPlanEN">源简化对象</param>
 public static void AccessFldValueNull(clsvTeachingPlanEN objvTeachingPlanEN)
{
try
{
if (objvTeachingPlanEN.TeachingPlanAuthor == "[null]") objvTeachingPlanEN.TeachingPlanAuthor = null; //教案撰写人
if (objvTeachingPlanEN.TeachingObject == "[null]") objvTeachingPlanEN.TeachingObject = null; //教学目标
if (objvTeachingPlanEN.TeachingEmphases == "[null]") objvTeachingPlanEN.TeachingEmphases = null; //教学重点
if (objvTeachingPlanEN.TeachingDifficulty == "[null]") objvTeachingPlanEN.TeachingDifficulty = null; //教学难点
if (objvTeachingPlanEN.TeachingTool == "[null]") objvTeachingPlanEN.TeachingTool = null; //教学用具
if (objvTeachingPlanEN.TeachingProcess == "[null]") objvTeachingPlanEN.TeachingProcess = null; //教学过程
if (objvTeachingPlanEN.TeachingPlanType == "[null]") objvTeachingPlanEN.TeachingPlanType = null; //教案类型
if (objvTeachingPlanEN.TeachPlanTypeName == "[null]") objvTeachingPlanEN.TeachPlanTypeName = null; //教案类型名称
if (objvTeachingPlanEN.SimplePlanContent == "[null]") objvTeachingPlanEN.SimplePlanContent = null; //简案内容
if (objvTeachingPlanEN.TeachingPlanInDate == "[null]") objvTeachingPlanEN.TeachingPlanInDate = null; //教案入库日期
if (objvTeachingPlanEN.TeachingPlanInTime == "[null]") objvTeachingPlanEN.TeachingPlanInTime = null; //教案入库时间
if (objvTeachingPlanEN.Memo == "[null]") objvTeachingPlanEN.Memo = null; //备注
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
public static void CheckProperty4Condition(clsvTeachingPlanEN objvTeachingPlanEN)
{
 vTeachingPlanDA.CheckProperty4Condition(objvTeachingPlanEN);
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
if (clsTeachingPlanBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsTeachingPlanBL没有刷新缓存机制(clsTeachingPlanBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsTeachPlanTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsTeachPlanTypeBL没有刷新缓存机制(clsTeachPlanTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by IdTeachingPlan");
//if (arrvTeachingPlanObjLstCache == null)
//{
//arrvTeachingPlanObjLstCache = vTeachingPlanDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strIdTeachingPlan">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvTeachingPlanEN GetObjByIdTeachingPlanCache(string strIdTeachingPlan)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvTeachingPlanEN._CurrTabName);
List<clsvTeachingPlanEN> arrvTeachingPlanObjLstCache = GetObjLstCache();
IEnumerable <clsvTeachingPlanEN> arrvTeachingPlanObjLst_Sel =
arrvTeachingPlanObjLstCache
.Where(x=> x.IdTeachingPlan == strIdTeachingPlan 
);
if (arrvTeachingPlanObjLst_Sel.Count() == 0)
{
   clsvTeachingPlanEN obj = clsvTeachingPlanBL.GetObjByIdTeachingPlan(strIdTeachingPlan);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvTeachingPlanObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvTeachingPlanEN> GetAllvTeachingPlanObjLstCache()
{
//获取缓存中的对象列表
List<clsvTeachingPlanEN> arrvTeachingPlanObjLstCache = GetObjLstCache(); 
return arrvTeachingPlanObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvTeachingPlanEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvTeachingPlanEN._CurrTabName);
List<clsvTeachingPlanEN> arrvTeachingPlanObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvTeachingPlanObjLstCache;
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
string strKey = string.Format("{0}", clsvTeachingPlanEN._CurrTabName);
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
public static string Func(string strInFldName, string strOutFldName, string strIdTeachingPlan)
{
if (strInFldName != convTeachingPlan.IdTeachingPlan)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convTeachingPlan.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convTeachingPlan.AttributeName));
throw new Exception(strMsg);
}
var objvTeachingPlan = clsvTeachingPlanBL.GetObjByIdTeachingPlanCache(strIdTeachingPlan);
if (objvTeachingPlan == null) return "";
return objvTeachingPlan[strOutFldName].ToString();
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
int intRecCount = clsvTeachingPlanDA.GetRecCount(strTabName);
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
int intRecCount = clsvTeachingPlanDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvTeachingPlanDA.GetRecCount();
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
int intRecCount = clsvTeachingPlanDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvTeachingPlanCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvTeachingPlanEN objvTeachingPlanCond)
{
List<clsvTeachingPlanEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvTeachingPlanEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convTeachingPlan.AttributeName)
{
if (objvTeachingPlanCond.IsUpdated(strFldName) == false) continue;
if (objvTeachingPlanCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvTeachingPlanCond[strFldName].ToString());
}
else
{
if (objvTeachingPlanCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvTeachingPlanCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvTeachingPlanCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvTeachingPlanCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvTeachingPlanCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvTeachingPlanCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvTeachingPlanCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvTeachingPlanCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvTeachingPlanCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvTeachingPlanCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvTeachingPlanCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvTeachingPlanCond[strFldName]));
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
 List<string> arrList = clsvTeachingPlanDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vTeachingPlanDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vTeachingPlanDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}