
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvgs_KnowledgesLogicRela_SimBL
 表名:vgs_KnowledgesLogicRela_Sim(01120934)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 12:58:46
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:知识点相关(Knowledges)
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
public static class  clsvgs_KnowledgesLogicRela_SimBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvgs_KnowledgesLogicRela_SimEN GetObj(this K_mId_vgs_KnowledgesLogicRela_Sim myKey)
{
clsvgs_KnowledgesLogicRela_SimEN objvgs_KnowledgesLogicRela_SimEN = clsvgs_KnowledgesLogicRela_SimBL.vgs_KnowledgesLogicRela_SimDA.GetObjBymId(myKey.Value);
return objvgs_KnowledgesLogicRela_SimEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_KnowledgesLogicRela_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_KnowledgesLogicRela_SimEN SetmId(this clsvgs_KnowledgesLogicRela_SimEN objvgs_KnowledgesLogicRela_SimEN, long lngmId, string strComparisonOp="")
	{
objvgs_KnowledgesLogicRela_SimEN.mId = lngmId; //mId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_KnowledgesLogicRela_SimEN.dicFldComparisonOp.ContainsKey(convgs_KnowledgesLogicRela_Sim.mId) == false)
{
objvgs_KnowledgesLogicRela_SimEN.dicFldComparisonOp.Add(convgs_KnowledgesLogicRela_Sim.mId, strComparisonOp);
}
else
{
objvgs_KnowledgesLogicRela_SimEN.dicFldComparisonOp[convgs_KnowledgesLogicRela_Sim.mId] = strComparisonOp;
}
}
return objvgs_KnowledgesLogicRela_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_KnowledgesLogicRela_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_KnowledgesLogicRela_SimEN SetCourseKnowledgeIdA(this clsvgs_KnowledgesLogicRela_SimEN objvgs_KnowledgesLogicRela_SimEN, string strCourseKnowledgeIdA, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCourseKnowledgeIdA, convgs_KnowledgesLogicRela_Sim.CourseKnowledgeIdA);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseKnowledgeIdA, 8, convgs_KnowledgesLogicRela_Sim.CourseKnowledgeIdA);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCourseKnowledgeIdA, 8, convgs_KnowledgesLogicRela_Sim.CourseKnowledgeIdA);
}
objvgs_KnowledgesLogicRela_SimEN.CourseKnowledgeIdA = strCourseKnowledgeIdA; //课程知识点AId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_KnowledgesLogicRela_SimEN.dicFldComparisonOp.ContainsKey(convgs_KnowledgesLogicRela_Sim.CourseKnowledgeIdA) == false)
{
objvgs_KnowledgesLogicRela_SimEN.dicFldComparisonOp.Add(convgs_KnowledgesLogicRela_Sim.CourseKnowledgeIdA, strComparisonOp);
}
else
{
objvgs_KnowledgesLogicRela_SimEN.dicFldComparisonOp[convgs_KnowledgesLogicRela_Sim.CourseKnowledgeIdA] = strComparisonOp;
}
}
return objvgs_KnowledgesLogicRela_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_KnowledgesLogicRela_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_KnowledgesLogicRela_SimEN SetCourseKnowledgeIdB(this clsvgs_KnowledgesLogicRela_SimEN objvgs_KnowledgesLogicRela_SimEN, string strCourseKnowledgeIdB, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCourseKnowledgeIdB, convgs_KnowledgesLogicRela_Sim.CourseKnowledgeIdB);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseKnowledgeIdB, 8, convgs_KnowledgesLogicRela_Sim.CourseKnowledgeIdB);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCourseKnowledgeIdB, 8, convgs_KnowledgesLogicRela_Sim.CourseKnowledgeIdB);
}
objvgs_KnowledgesLogicRela_SimEN.CourseKnowledgeIdB = strCourseKnowledgeIdB; //课程知识点BId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_KnowledgesLogicRela_SimEN.dicFldComparisonOp.ContainsKey(convgs_KnowledgesLogicRela_Sim.CourseKnowledgeIdB) == false)
{
objvgs_KnowledgesLogicRela_SimEN.dicFldComparisonOp.Add(convgs_KnowledgesLogicRela_Sim.CourseKnowledgeIdB, strComparisonOp);
}
else
{
objvgs_KnowledgesLogicRela_SimEN.dicFldComparisonOp[convgs_KnowledgesLogicRela_Sim.CourseKnowledgeIdB] = strComparisonOp;
}
}
return objvgs_KnowledgesLogicRela_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_KnowledgesLogicRela_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_KnowledgesLogicRela_SimEN SetCourseKnowledgeTitleA(this clsvgs_KnowledgesLogicRela_SimEN objvgs_KnowledgesLogicRela_SimEN, string strCourseKnowledgeTitleA, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseKnowledgeTitleA, 100, convgs_KnowledgesLogicRela_Sim.CourseKnowledgeTitleA);
}
objvgs_KnowledgesLogicRela_SimEN.CourseKnowledgeTitleA = strCourseKnowledgeTitleA; //课程知识点标题A
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_KnowledgesLogicRela_SimEN.dicFldComparisonOp.ContainsKey(convgs_KnowledgesLogicRela_Sim.CourseKnowledgeTitleA) == false)
{
objvgs_KnowledgesLogicRela_SimEN.dicFldComparisonOp.Add(convgs_KnowledgesLogicRela_Sim.CourseKnowledgeTitleA, strComparisonOp);
}
else
{
objvgs_KnowledgesLogicRela_SimEN.dicFldComparisonOp[convgs_KnowledgesLogicRela_Sim.CourseKnowledgeTitleA] = strComparisonOp;
}
}
return objvgs_KnowledgesLogicRela_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_KnowledgesLogicRela_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_KnowledgesLogicRela_SimEN SetCourseKnowledgeTitleB(this clsvgs_KnowledgesLogicRela_SimEN objvgs_KnowledgesLogicRela_SimEN, string strCourseKnowledgeTitleB, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseKnowledgeTitleB, 100, convgs_KnowledgesLogicRela_Sim.CourseKnowledgeTitleB);
}
objvgs_KnowledgesLogicRela_SimEN.CourseKnowledgeTitleB = strCourseKnowledgeTitleB; //课程知识点标题B
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_KnowledgesLogicRela_SimEN.dicFldComparisonOp.ContainsKey(convgs_KnowledgesLogicRela_Sim.CourseKnowledgeTitleB) == false)
{
objvgs_KnowledgesLogicRela_SimEN.dicFldComparisonOp.Add(convgs_KnowledgesLogicRela_Sim.CourseKnowledgeTitleB, strComparisonOp);
}
else
{
objvgs_KnowledgesLogicRela_SimEN.dicFldComparisonOp[convgs_KnowledgesLogicRela_Sim.CourseKnowledgeTitleB] = strComparisonOp;
}
}
return objvgs_KnowledgesLogicRela_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_KnowledgesLogicRela_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_KnowledgesLogicRela_SimEN SetRelaTypeId(this clsvgs_KnowledgesLogicRela_SimEN objvgs_KnowledgesLogicRela_SimEN, string strRelaTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRelaTypeId, 2, convgs_KnowledgesLogicRela_Sim.RelaTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strRelaTypeId, 2, convgs_KnowledgesLogicRela_Sim.RelaTypeId);
}
objvgs_KnowledgesLogicRela_SimEN.RelaTypeId = strRelaTypeId; //关系类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_KnowledgesLogicRela_SimEN.dicFldComparisonOp.ContainsKey(convgs_KnowledgesLogicRela_Sim.RelaTypeId) == false)
{
objvgs_KnowledgesLogicRela_SimEN.dicFldComparisonOp.Add(convgs_KnowledgesLogicRela_Sim.RelaTypeId, strComparisonOp);
}
else
{
objvgs_KnowledgesLogicRela_SimEN.dicFldComparisonOp[convgs_KnowledgesLogicRela_Sim.RelaTypeId] = strComparisonOp;
}
}
return objvgs_KnowledgesLogicRela_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_KnowledgesLogicRela_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_KnowledgesLogicRela_SimEN SetKnowledgeGraphId(this clsvgs_KnowledgesLogicRela_SimEN objvgs_KnowledgesLogicRela_SimEN, string strKnowledgeGraphId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strKnowledgeGraphId, 10, convgs_KnowledgesLogicRela_Sim.KnowledgeGraphId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strKnowledgeGraphId, 10, convgs_KnowledgesLogicRela_Sim.KnowledgeGraphId);
}
objvgs_KnowledgesLogicRela_SimEN.KnowledgeGraphId = strKnowledgeGraphId; //知识点图Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_KnowledgesLogicRela_SimEN.dicFldComparisonOp.ContainsKey(convgs_KnowledgesLogicRela_Sim.KnowledgeGraphId) == false)
{
objvgs_KnowledgesLogicRela_SimEN.dicFldComparisonOp.Add(convgs_KnowledgesLogicRela_Sim.KnowledgeGraphId, strComparisonOp);
}
else
{
objvgs_KnowledgesLogicRela_SimEN.dicFldComparisonOp[convgs_KnowledgesLogicRela_Sim.KnowledgeGraphId] = strComparisonOp;
}
}
return objvgs_KnowledgesLogicRela_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_KnowledgesLogicRela_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_KnowledgesLogicRela_SimEN SetSourceAnchor(this clsvgs_KnowledgesLogicRela_SimEN objvgs_KnowledgesLogicRela_SimEN, string strSourceAnchor, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSourceAnchor, 50, convgs_KnowledgesLogicRela_Sim.SourceAnchor);
}
objvgs_KnowledgesLogicRela_SimEN.SourceAnchor = strSourceAnchor; //源锚点
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_KnowledgesLogicRela_SimEN.dicFldComparisonOp.ContainsKey(convgs_KnowledgesLogicRela_Sim.SourceAnchor) == false)
{
objvgs_KnowledgesLogicRela_SimEN.dicFldComparisonOp.Add(convgs_KnowledgesLogicRela_Sim.SourceAnchor, strComparisonOp);
}
else
{
objvgs_KnowledgesLogicRela_SimEN.dicFldComparisonOp[convgs_KnowledgesLogicRela_Sim.SourceAnchor] = strComparisonOp;
}
}
return objvgs_KnowledgesLogicRela_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_KnowledgesLogicRela_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_KnowledgesLogicRela_SimEN SetTargetAnchor(this clsvgs_KnowledgesLogicRela_SimEN objvgs_KnowledgesLogicRela_SimEN, string strTargetAnchor, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTargetAnchor, 50, convgs_KnowledgesLogicRela_Sim.TargetAnchor);
}
objvgs_KnowledgesLogicRela_SimEN.TargetAnchor = strTargetAnchor; //目标锚点
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_KnowledgesLogicRela_SimEN.dicFldComparisonOp.ContainsKey(convgs_KnowledgesLogicRela_Sim.TargetAnchor) == false)
{
objvgs_KnowledgesLogicRela_SimEN.dicFldComparisonOp.Add(convgs_KnowledgesLogicRela_Sim.TargetAnchor, strComparisonOp);
}
else
{
objvgs_KnowledgesLogicRela_SimEN.dicFldComparisonOp[convgs_KnowledgesLogicRela_Sim.TargetAnchor] = strComparisonOp;
}
}
return objvgs_KnowledgesLogicRela_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_KnowledgesLogicRela_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_KnowledgesLogicRela_SimEN SetCourseId(this clsvgs_KnowledgesLogicRela_SimEN objvgs_KnowledgesLogicRela_SimEN, string strCourseId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseId, 8, convgs_KnowledgesLogicRela_Sim.CourseId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCourseId, 8, convgs_KnowledgesLogicRela_Sim.CourseId);
}
objvgs_KnowledgesLogicRela_SimEN.CourseId = strCourseId; //课程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_KnowledgesLogicRela_SimEN.dicFldComparisonOp.ContainsKey(convgs_KnowledgesLogicRela_Sim.CourseId) == false)
{
objvgs_KnowledgesLogicRela_SimEN.dicFldComparisonOp.Add(convgs_KnowledgesLogicRela_Sim.CourseId, strComparisonOp);
}
else
{
objvgs_KnowledgesLogicRela_SimEN.dicFldComparisonOp[convgs_KnowledgesLogicRela_Sim.CourseId] = strComparisonOp;
}
}
return objvgs_KnowledgesLogicRela_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_KnowledgesLogicRela_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_KnowledgesLogicRela_SimEN SetRelaTitle(this clsvgs_KnowledgesLogicRela_SimEN objvgs_KnowledgesLogicRela_SimEN, string strRelaTitle, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRelaTitle, 100, convgs_KnowledgesLogicRela_Sim.RelaTitle);
}
objvgs_KnowledgesLogicRela_SimEN.RelaTitle = strRelaTitle; //关系标题
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_KnowledgesLogicRela_SimEN.dicFldComparisonOp.ContainsKey(convgs_KnowledgesLogicRela_Sim.RelaTitle) == false)
{
objvgs_KnowledgesLogicRela_SimEN.dicFldComparisonOp.Add(convgs_KnowledgesLogicRela_Sim.RelaTitle, strComparisonOp);
}
else
{
objvgs_KnowledgesLogicRela_SimEN.dicFldComparisonOp[convgs_KnowledgesLogicRela_Sim.RelaTitle] = strComparisonOp;
}
}
return objvgs_KnowledgesLogicRela_SimEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvgs_KnowledgesLogicRela_SimENS">源对象</param>
 /// <param name = "objvgs_KnowledgesLogicRela_SimENT">目标对象</param>
 public static void CopyTo(this clsvgs_KnowledgesLogicRela_SimEN objvgs_KnowledgesLogicRela_SimENS, clsvgs_KnowledgesLogicRela_SimEN objvgs_KnowledgesLogicRela_SimENT)
{
try
{
objvgs_KnowledgesLogicRela_SimENT.mId = objvgs_KnowledgesLogicRela_SimENS.mId; //mId
objvgs_KnowledgesLogicRela_SimENT.CourseKnowledgeIdA = objvgs_KnowledgesLogicRela_SimENS.CourseKnowledgeIdA; //课程知识点AId
objvgs_KnowledgesLogicRela_SimENT.CourseKnowledgeIdB = objvgs_KnowledgesLogicRela_SimENS.CourseKnowledgeIdB; //课程知识点BId
objvgs_KnowledgesLogicRela_SimENT.CourseKnowledgeTitleA = objvgs_KnowledgesLogicRela_SimENS.CourseKnowledgeTitleA; //课程知识点标题A
objvgs_KnowledgesLogicRela_SimENT.CourseKnowledgeTitleB = objvgs_KnowledgesLogicRela_SimENS.CourseKnowledgeTitleB; //课程知识点标题B
objvgs_KnowledgesLogicRela_SimENT.RelaTypeId = objvgs_KnowledgesLogicRela_SimENS.RelaTypeId; //关系类型Id
objvgs_KnowledgesLogicRela_SimENT.KnowledgeGraphId = objvgs_KnowledgesLogicRela_SimENS.KnowledgeGraphId; //知识点图Id
objvgs_KnowledgesLogicRela_SimENT.SourceAnchor = objvgs_KnowledgesLogicRela_SimENS.SourceAnchor; //源锚点
objvgs_KnowledgesLogicRela_SimENT.TargetAnchor = objvgs_KnowledgesLogicRela_SimENS.TargetAnchor; //目标锚点
objvgs_KnowledgesLogicRela_SimENT.CourseId = objvgs_KnowledgesLogicRela_SimENS.CourseId; //课程Id
objvgs_KnowledgesLogicRela_SimENT.RelaTitle = objvgs_KnowledgesLogicRela_SimENS.RelaTitle; //关系标题
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
 /// <param name = "objvgs_KnowledgesLogicRela_SimENS">源对象</param>
 /// <returns>目标对象=>clsvgs_KnowledgesLogicRela_SimEN:objvgs_KnowledgesLogicRela_SimENT</returns>
 public static clsvgs_KnowledgesLogicRela_SimEN CopyTo(this clsvgs_KnowledgesLogicRela_SimEN objvgs_KnowledgesLogicRela_SimENS)
{
try
{
 clsvgs_KnowledgesLogicRela_SimEN objvgs_KnowledgesLogicRela_SimENT = new clsvgs_KnowledgesLogicRela_SimEN()
{
mId = objvgs_KnowledgesLogicRela_SimENS.mId, //mId
CourseKnowledgeIdA = objvgs_KnowledgesLogicRela_SimENS.CourseKnowledgeIdA, //课程知识点AId
CourseKnowledgeIdB = objvgs_KnowledgesLogicRela_SimENS.CourseKnowledgeIdB, //课程知识点BId
CourseKnowledgeTitleA = objvgs_KnowledgesLogicRela_SimENS.CourseKnowledgeTitleA, //课程知识点标题A
CourseKnowledgeTitleB = objvgs_KnowledgesLogicRela_SimENS.CourseKnowledgeTitleB, //课程知识点标题B
RelaTypeId = objvgs_KnowledgesLogicRela_SimENS.RelaTypeId, //关系类型Id
KnowledgeGraphId = objvgs_KnowledgesLogicRela_SimENS.KnowledgeGraphId, //知识点图Id
SourceAnchor = objvgs_KnowledgesLogicRela_SimENS.SourceAnchor, //源锚点
TargetAnchor = objvgs_KnowledgesLogicRela_SimENS.TargetAnchor, //目标锚点
CourseId = objvgs_KnowledgesLogicRela_SimENS.CourseId, //课程Id
RelaTitle = objvgs_KnowledgesLogicRela_SimENS.RelaTitle, //关系标题
};
 return objvgs_KnowledgesLogicRela_SimENT;
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
public static void CheckProperty4Condition(this clsvgs_KnowledgesLogicRela_SimEN objvgs_KnowledgesLogicRela_SimEN)
{
 clsvgs_KnowledgesLogicRela_SimBL.vgs_KnowledgesLogicRela_SimDA.CheckProperty4Condition(objvgs_KnowledgesLogicRela_SimEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvgs_KnowledgesLogicRela_SimEN objvgs_KnowledgesLogicRela_SimCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvgs_KnowledgesLogicRela_SimCond.IsUpdated(convgs_KnowledgesLogicRela_Sim.mId) == true)
{
string strComparisonOpmId = objvgs_KnowledgesLogicRela_SimCond.dicFldComparisonOp[convgs_KnowledgesLogicRela_Sim.mId];
strWhereCond += string.Format(" And {0} {2} {1}", convgs_KnowledgesLogicRela_Sim.mId, objvgs_KnowledgesLogicRela_SimCond.mId, strComparisonOpmId);
}
if (objvgs_KnowledgesLogicRela_SimCond.IsUpdated(convgs_KnowledgesLogicRela_Sim.CourseKnowledgeIdA) == true)
{
string strComparisonOpCourseKnowledgeIdA = objvgs_KnowledgesLogicRela_SimCond.dicFldComparisonOp[convgs_KnowledgesLogicRela_Sim.CourseKnowledgeIdA];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_KnowledgesLogicRela_Sim.CourseKnowledgeIdA, objvgs_KnowledgesLogicRela_SimCond.CourseKnowledgeIdA, strComparisonOpCourseKnowledgeIdA);
}
if (objvgs_KnowledgesLogicRela_SimCond.IsUpdated(convgs_KnowledgesLogicRela_Sim.CourseKnowledgeIdB) == true)
{
string strComparisonOpCourseKnowledgeIdB = objvgs_KnowledgesLogicRela_SimCond.dicFldComparisonOp[convgs_KnowledgesLogicRela_Sim.CourseKnowledgeIdB];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_KnowledgesLogicRela_Sim.CourseKnowledgeIdB, objvgs_KnowledgesLogicRela_SimCond.CourseKnowledgeIdB, strComparisonOpCourseKnowledgeIdB);
}
if (objvgs_KnowledgesLogicRela_SimCond.IsUpdated(convgs_KnowledgesLogicRela_Sim.CourseKnowledgeTitleA) == true)
{
string strComparisonOpCourseKnowledgeTitleA = objvgs_KnowledgesLogicRela_SimCond.dicFldComparisonOp[convgs_KnowledgesLogicRela_Sim.CourseKnowledgeTitleA];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_KnowledgesLogicRela_Sim.CourseKnowledgeTitleA, objvgs_KnowledgesLogicRela_SimCond.CourseKnowledgeTitleA, strComparisonOpCourseKnowledgeTitleA);
}
if (objvgs_KnowledgesLogicRela_SimCond.IsUpdated(convgs_KnowledgesLogicRela_Sim.CourseKnowledgeTitleB) == true)
{
string strComparisonOpCourseKnowledgeTitleB = objvgs_KnowledgesLogicRela_SimCond.dicFldComparisonOp[convgs_KnowledgesLogicRela_Sim.CourseKnowledgeTitleB];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_KnowledgesLogicRela_Sim.CourseKnowledgeTitleB, objvgs_KnowledgesLogicRela_SimCond.CourseKnowledgeTitleB, strComparisonOpCourseKnowledgeTitleB);
}
if (objvgs_KnowledgesLogicRela_SimCond.IsUpdated(convgs_KnowledgesLogicRela_Sim.RelaTypeId) == true)
{
string strComparisonOpRelaTypeId = objvgs_KnowledgesLogicRela_SimCond.dicFldComparisonOp[convgs_KnowledgesLogicRela_Sim.RelaTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_KnowledgesLogicRela_Sim.RelaTypeId, objvgs_KnowledgesLogicRela_SimCond.RelaTypeId, strComparisonOpRelaTypeId);
}
if (objvgs_KnowledgesLogicRela_SimCond.IsUpdated(convgs_KnowledgesLogicRela_Sim.KnowledgeGraphId) == true)
{
string strComparisonOpKnowledgeGraphId = objvgs_KnowledgesLogicRela_SimCond.dicFldComparisonOp[convgs_KnowledgesLogicRela_Sim.KnowledgeGraphId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_KnowledgesLogicRela_Sim.KnowledgeGraphId, objvgs_KnowledgesLogicRela_SimCond.KnowledgeGraphId, strComparisonOpKnowledgeGraphId);
}
if (objvgs_KnowledgesLogicRela_SimCond.IsUpdated(convgs_KnowledgesLogicRela_Sim.SourceAnchor) == true)
{
string strComparisonOpSourceAnchor = objvgs_KnowledgesLogicRela_SimCond.dicFldComparisonOp[convgs_KnowledgesLogicRela_Sim.SourceAnchor];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_KnowledgesLogicRela_Sim.SourceAnchor, objvgs_KnowledgesLogicRela_SimCond.SourceAnchor, strComparisonOpSourceAnchor);
}
if (objvgs_KnowledgesLogicRela_SimCond.IsUpdated(convgs_KnowledgesLogicRela_Sim.TargetAnchor) == true)
{
string strComparisonOpTargetAnchor = objvgs_KnowledgesLogicRela_SimCond.dicFldComparisonOp[convgs_KnowledgesLogicRela_Sim.TargetAnchor];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_KnowledgesLogicRela_Sim.TargetAnchor, objvgs_KnowledgesLogicRela_SimCond.TargetAnchor, strComparisonOpTargetAnchor);
}
if (objvgs_KnowledgesLogicRela_SimCond.IsUpdated(convgs_KnowledgesLogicRela_Sim.CourseId) == true)
{
string strComparisonOpCourseId = objvgs_KnowledgesLogicRela_SimCond.dicFldComparisonOp[convgs_KnowledgesLogicRela_Sim.CourseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_KnowledgesLogicRela_Sim.CourseId, objvgs_KnowledgesLogicRela_SimCond.CourseId, strComparisonOpCourseId);
}
if (objvgs_KnowledgesLogicRela_SimCond.IsUpdated(convgs_KnowledgesLogicRela_Sim.RelaTitle) == true)
{
string strComparisonOpRelaTitle = objvgs_KnowledgesLogicRela_SimCond.dicFldComparisonOp[convgs_KnowledgesLogicRela_Sim.RelaTitle];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_KnowledgesLogicRela_Sim.RelaTitle, objvgs_KnowledgesLogicRela_SimCond.RelaTitle, strComparisonOpRelaTitle);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--vgs_KnowledgesLogicRela_Sim(v知识点逻辑关系_Sim), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:CourseKnowledgeIdA_CourseKnowledgeIdB_RelaTypeId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objvgs_KnowledgesLogicRela_SimEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsvgs_KnowledgesLogicRela_SimEN objvgs_KnowledgesLogicRela_SimEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objvgs_KnowledgesLogicRela_SimEN == null) return true;
if (objvgs_KnowledgesLogicRela_SimEN.mId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and CourseKnowledgeIdA = '{0}'", objvgs_KnowledgesLogicRela_SimEN.CourseKnowledgeIdA);
 sbCondition.AppendFormat(" and CourseKnowledgeIdB = '{0}'", objvgs_KnowledgesLogicRela_SimEN.CourseKnowledgeIdB);
 if (objvgs_KnowledgesLogicRela_SimEN.RelaTypeId == null)
{
 sbCondition.AppendFormat(" and RelaTypeId is null", objvgs_KnowledgesLogicRela_SimEN.RelaTypeId);
}
else
{
 sbCondition.AppendFormat(" and RelaTypeId = '{0}'", objvgs_KnowledgesLogicRela_SimEN.RelaTypeId);
}
if (clsvgs_KnowledgesLogicRela_SimBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("mId !=  {0}", objvgs_KnowledgesLogicRela_SimEN.mId);
 sbCondition.AppendFormat(" and CourseKnowledgeIdA = '{0}'", objvgs_KnowledgesLogicRela_SimEN.CourseKnowledgeIdA);
 sbCondition.AppendFormat(" and CourseKnowledgeIdB = '{0}'", objvgs_KnowledgesLogicRela_SimEN.CourseKnowledgeIdB);
 sbCondition.AppendFormat(" and RelaTypeId = '{0}'", objvgs_KnowledgesLogicRela_SimEN.RelaTypeId);
if (clsvgs_KnowledgesLogicRela_SimBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
return bolIsUniqueness;
}

 /// <summary>
 /// 获取唯一性条件串--vgs_KnowledgesLogicRela_Sim(v知识点逻辑关系_Sim), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:CourseKnowledgeIdA_CourseKnowledgeIdB_RelaTypeId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objvgs_KnowledgesLogicRela_SimEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsvgs_KnowledgesLogicRela_SimEN objvgs_KnowledgesLogicRela_SimEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objvgs_KnowledgesLogicRela_SimEN == null) return "";
if (objvgs_KnowledgesLogicRela_SimEN.mId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and CourseKnowledgeIdA = '{0}'", objvgs_KnowledgesLogicRela_SimEN.CourseKnowledgeIdA);
 sbCondition.AppendFormat(" and CourseKnowledgeIdB = '{0}'", objvgs_KnowledgesLogicRela_SimEN.CourseKnowledgeIdB);
 if (objvgs_KnowledgesLogicRela_SimEN.RelaTypeId == null)
{
 sbCondition.AppendFormat(" and RelaTypeId is null", objvgs_KnowledgesLogicRela_SimEN.RelaTypeId);
}
else
{
 sbCondition.AppendFormat(" and RelaTypeId = '{0}'", objvgs_KnowledgesLogicRela_SimEN.RelaTypeId);
}
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("mId !=  {0}", objvgs_KnowledgesLogicRela_SimEN.mId);
 sbCondition.AppendFormat(" and CourseKnowledgeIdA = '{0}'", objvgs_KnowledgesLogicRela_SimEN.CourseKnowledgeIdA);
 sbCondition.AppendFormat(" and CourseKnowledgeIdB = '{0}'", objvgs_KnowledgesLogicRela_SimEN.CourseKnowledgeIdB);
 sbCondition.AppendFormat(" and RelaTypeId = '{0}'", objvgs_KnowledgesLogicRela_SimEN.RelaTypeId);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vgs_KnowledgesLogicRela_Sim
{
public virtual bool UpdRelaTabDate(long lngmId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v知识点逻辑关系_Sim(vgs_KnowledgesLogicRela_Sim)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvgs_KnowledgesLogicRela_SimBL
{
public static RelatedActions_vgs_KnowledgesLogicRela_Sim relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvgs_KnowledgesLogicRela_SimDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvgs_KnowledgesLogicRela_SimDA vgs_KnowledgesLogicRela_SimDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvgs_KnowledgesLogicRela_SimDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvgs_KnowledgesLogicRela_SimBL()
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
if (string.IsNullOrEmpty(clsvgs_KnowledgesLogicRela_SimEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvgs_KnowledgesLogicRela_SimEN._ConnectString);
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
public static DataTable GetDataTable_vgs_KnowledgesLogicRela_Sim(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vgs_KnowledgesLogicRela_SimDA.GetDataTable_vgs_KnowledgesLogicRela_Sim(strWhereCond);
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
objDT = vgs_KnowledgesLogicRela_SimDA.GetDataTable(strWhereCond);
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
objDT = vgs_KnowledgesLogicRela_SimDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vgs_KnowledgesLogicRela_SimDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vgs_KnowledgesLogicRela_SimDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vgs_KnowledgesLogicRela_SimDA.GetDataTable_Top(objTopPara);
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
objDT = vgs_KnowledgesLogicRela_SimDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vgs_KnowledgesLogicRela_SimDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vgs_KnowledgesLogicRela_SimDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrMIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvgs_KnowledgesLogicRela_SimEN> GetObjLstByMIdLst(List<long> arrMIdLst)
{
List<clsvgs_KnowledgesLogicRela_SimEN> arrObjLst = new List<clsvgs_KnowledgesLogicRela_SimEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrMIdLst);
 string strWhereCond = string.Format("mId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvgs_KnowledgesLogicRela_SimEN objvgs_KnowledgesLogicRela_SimEN = new clsvgs_KnowledgesLogicRela_SimEN();
try
{
objvgs_KnowledgesLogicRela_SimEN.mId = Int32.Parse(objRow[convgs_KnowledgesLogicRela_Sim.mId].ToString().Trim()); //mId
objvgs_KnowledgesLogicRela_SimEN.CourseKnowledgeIdA = objRow[convgs_KnowledgesLogicRela_Sim.CourseKnowledgeIdA].ToString().Trim(); //课程知识点AId
objvgs_KnowledgesLogicRela_SimEN.CourseKnowledgeIdB = objRow[convgs_KnowledgesLogicRela_Sim.CourseKnowledgeIdB].ToString().Trim(); //课程知识点BId
objvgs_KnowledgesLogicRela_SimEN.CourseKnowledgeTitleA = objRow[convgs_KnowledgesLogicRela_Sim.CourseKnowledgeTitleA] == DBNull.Value ? null : objRow[convgs_KnowledgesLogicRela_Sim.CourseKnowledgeTitleA].ToString().Trim(); //课程知识点标题A
objvgs_KnowledgesLogicRela_SimEN.CourseKnowledgeTitleB = objRow[convgs_KnowledgesLogicRela_Sim.CourseKnowledgeTitleB] == DBNull.Value ? null : objRow[convgs_KnowledgesLogicRela_Sim.CourseKnowledgeTitleB].ToString().Trim(); //课程知识点标题B
objvgs_KnowledgesLogicRela_SimEN.RelaTypeId = objRow[convgs_KnowledgesLogicRela_Sim.RelaTypeId] == DBNull.Value ? null : objRow[convgs_KnowledgesLogicRela_Sim.RelaTypeId].ToString().Trim(); //关系类型Id
objvgs_KnowledgesLogicRela_SimEN.KnowledgeGraphId = objRow[convgs_KnowledgesLogicRela_Sim.KnowledgeGraphId] == DBNull.Value ? null : objRow[convgs_KnowledgesLogicRela_Sim.KnowledgeGraphId].ToString().Trim(); //知识点图Id
objvgs_KnowledgesLogicRela_SimEN.SourceAnchor = objRow[convgs_KnowledgesLogicRela_Sim.SourceAnchor] == DBNull.Value ? null : objRow[convgs_KnowledgesLogicRela_Sim.SourceAnchor].ToString().Trim(); //源锚点
objvgs_KnowledgesLogicRela_SimEN.TargetAnchor = objRow[convgs_KnowledgesLogicRela_Sim.TargetAnchor] == DBNull.Value ? null : objRow[convgs_KnowledgesLogicRela_Sim.TargetAnchor].ToString().Trim(); //目标锚点
objvgs_KnowledgesLogicRela_SimEN.CourseId = objRow[convgs_KnowledgesLogicRela_Sim.CourseId] == DBNull.Value ? null : objRow[convgs_KnowledgesLogicRela_Sim.CourseId].ToString().Trim(); //课程Id
objvgs_KnowledgesLogicRela_SimEN.RelaTitle = objRow[convgs_KnowledgesLogicRela_Sim.RelaTitle] == DBNull.Value ? null : objRow[convgs_KnowledgesLogicRela_Sim.RelaTitle].ToString().Trim(); //关系标题
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvgs_KnowledgesLogicRela_SimEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvgs_KnowledgesLogicRela_SimEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrMIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvgs_KnowledgesLogicRela_SimEN> GetObjLstByMIdLstCache(List<long> arrMIdLst)
{
string strKey = string.Format("{0}", clsvgs_KnowledgesLogicRela_SimEN._CurrTabName);
List<clsvgs_KnowledgesLogicRela_SimEN> arrvgs_KnowledgesLogicRela_SimObjLstCache = GetObjLstCache();
IEnumerable <clsvgs_KnowledgesLogicRela_SimEN> arrvgs_KnowledgesLogicRela_SimObjLst_Sel =
arrvgs_KnowledgesLogicRela_SimObjLstCache
.Where(x => arrMIdLst.Contains(x.mId));
return arrvgs_KnowledgesLogicRela_SimObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvgs_KnowledgesLogicRela_SimEN> GetObjLst(string strWhereCond)
{
List<clsvgs_KnowledgesLogicRela_SimEN> arrObjLst = new List<clsvgs_KnowledgesLogicRela_SimEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvgs_KnowledgesLogicRela_SimEN objvgs_KnowledgesLogicRela_SimEN = new clsvgs_KnowledgesLogicRela_SimEN();
try
{
objvgs_KnowledgesLogicRela_SimEN.mId = Int32.Parse(objRow[convgs_KnowledgesLogicRela_Sim.mId].ToString().Trim()); //mId
objvgs_KnowledgesLogicRela_SimEN.CourseKnowledgeIdA = objRow[convgs_KnowledgesLogicRela_Sim.CourseKnowledgeIdA].ToString().Trim(); //课程知识点AId
objvgs_KnowledgesLogicRela_SimEN.CourseKnowledgeIdB = objRow[convgs_KnowledgesLogicRela_Sim.CourseKnowledgeIdB].ToString().Trim(); //课程知识点BId
objvgs_KnowledgesLogicRela_SimEN.CourseKnowledgeTitleA = objRow[convgs_KnowledgesLogicRela_Sim.CourseKnowledgeTitleA] == DBNull.Value ? null : objRow[convgs_KnowledgesLogicRela_Sim.CourseKnowledgeTitleA].ToString().Trim(); //课程知识点标题A
objvgs_KnowledgesLogicRela_SimEN.CourseKnowledgeTitleB = objRow[convgs_KnowledgesLogicRela_Sim.CourseKnowledgeTitleB] == DBNull.Value ? null : objRow[convgs_KnowledgesLogicRela_Sim.CourseKnowledgeTitleB].ToString().Trim(); //课程知识点标题B
objvgs_KnowledgesLogicRela_SimEN.RelaTypeId = objRow[convgs_KnowledgesLogicRela_Sim.RelaTypeId] == DBNull.Value ? null : objRow[convgs_KnowledgesLogicRela_Sim.RelaTypeId].ToString().Trim(); //关系类型Id
objvgs_KnowledgesLogicRela_SimEN.KnowledgeGraphId = objRow[convgs_KnowledgesLogicRela_Sim.KnowledgeGraphId] == DBNull.Value ? null : objRow[convgs_KnowledgesLogicRela_Sim.KnowledgeGraphId].ToString().Trim(); //知识点图Id
objvgs_KnowledgesLogicRela_SimEN.SourceAnchor = objRow[convgs_KnowledgesLogicRela_Sim.SourceAnchor] == DBNull.Value ? null : objRow[convgs_KnowledgesLogicRela_Sim.SourceAnchor].ToString().Trim(); //源锚点
objvgs_KnowledgesLogicRela_SimEN.TargetAnchor = objRow[convgs_KnowledgesLogicRela_Sim.TargetAnchor] == DBNull.Value ? null : objRow[convgs_KnowledgesLogicRela_Sim.TargetAnchor].ToString().Trim(); //目标锚点
objvgs_KnowledgesLogicRela_SimEN.CourseId = objRow[convgs_KnowledgesLogicRela_Sim.CourseId] == DBNull.Value ? null : objRow[convgs_KnowledgesLogicRela_Sim.CourseId].ToString().Trim(); //课程Id
objvgs_KnowledgesLogicRela_SimEN.RelaTitle = objRow[convgs_KnowledgesLogicRela_Sim.RelaTitle] == DBNull.Value ? null : objRow[convgs_KnowledgesLogicRela_Sim.RelaTitle].ToString().Trim(); //关系标题
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvgs_KnowledgesLogicRela_SimEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvgs_KnowledgesLogicRela_SimEN);
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
public static List<clsvgs_KnowledgesLogicRela_SimEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvgs_KnowledgesLogicRela_SimEN> arrObjLst = new List<clsvgs_KnowledgesLogicRela_SimEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvgs_KnowledgesLogicRela_SimEN objvgs_KnowledgesLogicRela_SimEN = new clsvgs_KnowledgesLogicRela_SimEN();
try
{
objvgs_KnowledgesLogicRela_SimEN.mId = Int32.Parse(objRow[convgs_KnowledgesLogicRela_Sim.mId].ToString().Trim()); //mId
objvgs_KnowledgesLogicRela_SimEN.CourseKnowledgeIdA = objRow[convgs_KnowledgesLogicRela_Sim.CourseKnowledgeIdA].ToString().Trim(); //课程知识点AId
objvgs_KnowledgesLogicRela_SimEN.CourseKnowledgeIdB = objRow[convgs_KnowledgesLogicRela_Sim.CourseKnowledgeIdB].ToString().Trim(); //课程知识点BId
objvgs_KnowledgesLogicRela_SimEN.CourseKnowledgeTitleA = objRow[convgs_KnowledgesLogicRela_Sim.CourseKnowledgeTitleA] == DBNull.Value ? null : objRow[convgs_KnowledgesLogicRela_Sim.CourseKnowledgeTitleA].ToString().Trim(); //课程知识点标题A
objvgs_KnowledgesLogicRela_SimEN.CourseKnowledgeTitleB = objRow[convgs_KnowledgesLogicRela_Sim.CourseKnowledgeTitleB] == DBNull.Value ? null : objRow[convgs_KnowledgesLogicRela_Sim.CourseKnowledgeTitleB].ToString().Trim(); //课程知识点标题B
objvgs_KnowledgesLogicRela_SimEN.RelaTypeId = objRow[convgs_KnowledgesLogicRela_Sim.RelaTypeId] == DBNull.Value ? null : objRow[convgs_KnowledgesLogicRela_Sim.RelaTypeId].ToString().Trim(); //关系类型Id
objvgs_KnowledgesLogicRela_SimEN.KnowledgeGraphId = objRow[convgs_KnowledgesLogicRela_Sim.KnowledgeGraphId] == DBNull.Value ? null : objRow[convgs_KnowledgesLogicRela_Sim.KnowledgeGraphId].ToString().Trim(); //知识点图Id
objvgs_KnowledgesLogicRela_SimEN.SourceAnchor = objRow[convgs_KnowledgesLogicRela_Sim.SourceAnchor] == DBNull.Value ? null : objRow[convgs_KnowledgesLogicRela_Sim.SourceAnchor].ToString().Trim(); //源锚点
objvgs_KnowledgesLogicRela_SimEN.TargetAnchor = objRow[convgs_KnowledgesLogicRela_Sim.TargetAnchor] == DBNull.Value ? null : objRow[convgs_KnowledgesLogicRela_Sim.TargetAnchor].ToString().Trim(); //目标锚点
objvgs_KnowledgesLogicRela_SimEN.CourseId = objRow[convgs_KnowledgesLogicRela_Sim.CourseId] == DBNull.Value ? null : objRow[convgs_KnowledgesLogicRela_Sim.CourseId].ToString().Trim(); //课程Id
objvgs_KnowledgesLogicRela_SimEN.RelaTitle = objRow[convgs_KnowledgesLogicRela_Sim.RelaTitle] == DBNull.Value ? null : objRow[convgs_KnowledgesLogicRela_Sim.RelaTitle].ToString().Trim(); //关系标题
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvgs_KnowledgesLogicRela_SimEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvgs_KnowledgesLogicRela_SimEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvgs_KnowledgesLogicRela_SimCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvgs_KnowledgesLogicRela_SimEN> GetSubObjLstCache(clsvgs_KnowledgesLogicRela_SimEN objvgs_KnowledgesLogicRela_SimCond)
{
List<clsvgs_KnowledgesLogicRela_SimEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvgs_KnowledgesLogicRela_SimEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convgs_KnowledgesLogicRela_Sim.AttributeName)
{
if (objvgs_KnowledgesLogicRela_SimCond.IsUpdated(strFldName) == false) continue;
if (objvgs_KnowledgesLogicRela_SimCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvgs_KnowledgesLogicRela_SimCond[strFldName].ToString());
}
else
{
if (objvgs_KnowledgesLogicRela_SimCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvgs_KnowledgesLogicRela_SimCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvgs_KnowledgesLogicRela_SimCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvgs_KnowledgesLogicRela_SimCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvgs_KnowledgesLogicRela_SimCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvgs_KnowledgesLogicRela_SimCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvgs_KnowledgesLogicRela_SimCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvgs_KnowledgesLogicRela_SimCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvgs_KnowledgesLogicRela_SimCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvgs_KnowledgesLogicRela_SimCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvgs_KnowledgesLogicRela_SimCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvgs_KnowledgesLogicRela_SimCond[strFldName]));
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
public static List<clsvgs_KnowledgesLogicRela_SimEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvgs_KnowledgesLogicRela_SimEN> arrObjLst = new List<clsvgs_KnowledgesLogicRela_SimEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvgs_KnowledgesLogicRela_SimEN objvgs_KnowledgesLogicRela_SimEN = new clsvgs_KnowledgesLogicRela_SimEN();
try
{
objvgs_KnowledgesLogicRela_SimEN.mId = Int32.Parse(objRow[convgs_KnowledgesLogicRela_Sim.mId].ToString().Trim()); //mId
objvgs_KnowledgesLogicRela_SimEN.CourseKnowledgeIdA = objRow[convgs_KnowledgesLogicRela_Sim.CourseKnowledgeIdA].ToString().Trim(); //课程知识点AId
objvgs_KnowledgesLogicRela_SimEN.CourseKnowledgeIdB = objRow[convgs_KnowledgesLogicRela_Sim.CourseKnowledgeIdB].ToString().Trim(); //课程知识点BId
objvgs_KnowledgesLogicRela_SimEN.CourseKnowledgeTitleA = objRow[convgs_KnowledgesLogicRela_Sim.CourseKnowledgeTitleA] == DBNull.Value ? null : objRow[convgs_KnowledgesLogicRela_Sim.CourseKnowledgeTitleA].ToString().Trim(); //课程知识点标题A
objvgs_KnowledgesLogicRela_SimEN.CourseKnowledgeTitleB = objRow[convgs_KnowledgesLogicRela_Sim.CourseKnowledgeTitleB] == DBNull.Value ? null : objRow[convgs_KnowledgesLogicRela_Sim.CourseKnowledgeTitleB].ToString().Trim(); //课程知识点标题B
objvgs_KnowledgesLogicRela_SimEN.RelaTypeId = objRow[convgs_KnowledgesLogicRela_Sim.RelaTypeId] == DBNull.Value ? null : objRow[convgs_KnowledgesLogicRela_Sim.RelaTypeId].ToString().Trim(); //关系类型Id
objvgs_KnowledgesLogicRela_SimEN.KnowledgeGraphId = objRow[convgs_KnowledgesLogicRela_Sim.KnowledgeGraphId] == DBNull.Value ? null : objRow[convgs_KnowledgesLogicRela_Sim.KnowledgeGraphId].ToString().Trim(); //知识点图Id
objvgs_KnowledgesLogicRela_SimEN.SourceAnchor = objRow[convgs_KnowledgesLogicRela_Sim.SourceAnchor] == DBNull.Value ? null : objRow[convgs_KnowledgesLogicRela_Sim.SourceAnchor].ToString().Trim(); //源锚点
objvgs_KnowledgesLogicRela_SimEN.TargetAnchor = objRow[convgs_KnowledgesLogicRela_Sim.TargetAnchor] == DBNull.Value ? null : objRow[convgs_KnowledgesLogicRela_Sim.TargetAnchor].ToString().Trim(); //目标锚点
objvgs_KnowledgesLogicRela_SimEN.CourseId = objRow[convgs_KnowledgesLogicRela_Sim.CourseId] == DBNull.Value ? null : objRow[convgs_KnowledgesLogicRela_Sim.CourseId].ToString().Trim(); //课程Id
objvgs_KnowledgesLogicRela_SimEN.RelaTitle = objRow[convgs_KnowledgesLogicRela_Sim.RelaTitle] == DBNull.Value ? null : objRow[convgs_KnowledgesLogicRela_Sim.RelaTitle].ToString().Trim(); //关系标题
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvgs_KnowledgesLogicRela_SimEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvgs_KnowledgesLogicRela_SimEN);
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
public static List<clsvgs_KnowledgesLogicRela_SimEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvgs_KnowledgesLogicRela_SimEN> arrObjLst = new List<clsvgs_KnowledgesLogicRela_SimEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvgs_KnowledgesLogicRela_SimEN objvgs_KnowledgesLogicRela_SimEN = new clsvgs_KnowledgesLogicRela_SimEN();
try
{
objvgs_KnowledgesLogicRela_SimEN.mId = Int32.Parse(objRow[convgs_KnowledgesLogicRela_Sim.mId].ToString().Trim()); //mId
objvgs_KnowledgesLogicRela_SimEN.CourseKnowledgeIdA = objRow[convgs_KnowledgesLogicRela_Sim.CourseKnowledgeIdA].ToString().Trim(); //课程知识点AId
objvgs_KnowledgesLogicRela_SimEN.CourseKnowledgeIdB = objRow[convgs_KnowledgesLogicRela_Sim.CourseKnowledgeIdB].ToString().Trim(); //课程知识点BId
objvgs_KnowledgesLogicRela_SimEN.CourseKnowledgeTitleA = objRow[convgs_KnowledgesLogicRela_Sim.CourseKnowledgeTitleA] == DBNull.Value ? null : objRow[convgs_KnowledgesLogicRela_Sim.CourseKnowledgeTitleA].ToString().Trim(); //课程知识点标题A
objvgs_KnowledgesLogicRela_SimEN.CourseKnowledgeTitleB = objRow[convgs_KnowledgesLogicRela_Sim.CourseKnowledgeTitleB] == DBNull.Value ? null : objRow[convgs_KnowledgesLogicRela_Sim.CourseKnowledgeTitleB].ToString().Trim(); //课程知识点标题B
objvgs_KnowledgesLogicRela_SimEN.RelaTypeId = objRow[convgs_KnowledgesLogicRela_Sim.RelaTypeId] == DBNull.Value ? null : objRow[convgs_KnowledgesLogicRela_Sim.RelaTypeId].ToString().Trim(); //关系类型Id
objvgs_KnowledgesLogicRela_SimEN.KnowledgeGraphId = objRow[convgs_KnowledgesLogicRela_Sim.KnowledgeGraphId] == DBNull.Value ? null : objRow[convgs_KnowledgesLogicRela_Sim.KnowledgeGraphId].ToString().Trim(); //知识点图Id
objvgs_KnowledgesLogicRela_SimEN.SourceAnchor = objRow[convgs_KnowledgesLogicRela_Sim.SourceAnchor] == DBNull.Value ? null : objRow[convgs_KnowledgesLogicRela_Sim.SourceAnchor].ToString().Trim(); //源锚点
objvgs_KnowledgesLogicRela_SimEN.TargetAnchor = objRow[convgs_KnowledgesLogicRela_Sim.TargetAnchor] == DBNull.Value ? null : objRow[convgs_KnowledgesLogicRela_Sim.TargetAnchor].ToString().Trim(); //目标锚点
objvgs_KnowledgesLogicRela_SimEN.CourseId = objRow[convgs_KnowledgesLogicRela_Sim.CourseId] == DBNull.Value ? null : objRow[convgs_KnowledgesLogicRela_Sim.CourseId].ToString().Trim(); //课程Id
objvgs_KnowledgesLogicRela_SimEN.RelaTitle = objRow[convgs_KnowledgesLogicRela_Sim.RelaTitle] == DBNull.Value ? null : objRow[convgs_KnowledgesLogicRela_Sim.RelaTitle].ToString().Trim(); //关系标题
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvgs_KnowledgesLogicRela_SimEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvgs_KnowledgesLogicRela_SimEN);
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
List<clsvgs_KnowledgesLogicRela_SimEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvgs_KnowledgesLogicRela_SimEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvgs_KnowledgesLogicRela_SimEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvgs_KnowledgesLogicRela_SimEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvgs_KnowledgesLogicRela_SimEN> arrObjLst = new List<clsvgs_KnowledgesLogicRela_SimEN>(); 
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
	clsvgs_KnowledgesLogicRela_SimEN objvgs_KnowledgesLogicRela_SimEN = new clsvgs_KnowledgesLogicRela_SimEN();
try
{
objvgs_KnowledgesLogicRela_SimEN.mId = Int32.Parse(objRow[convgs_KnowledgesLogicRela_Sim.mId].ToString().Trim()); //mId
objvgs_KnowledgesLogicRela_SimEN.CourseKnowledgeIdA = objRow[convgs_KnowledgesLogicRela_Sim.CourseKnowledgeIdA].ToString().Trim(); //课程知识点AId
objvgs_KnowledgesLogicRela_SimEN.CourseKnowledgeIdB = objRow[convgs_KnowledgesLogicRela_Sim.CourseKnowledgeIdB].ToString().Trim(); //课程知识点BId
objvgs_KnowledgesLogicRela_SimEN.CourseKnowledgeTitleA = objRow[convgs_KnowledgesLogicRela_Sim.CourseKnowledgeTitleA] == DBNull.Value ? null : objRow[convgs_KnowledgesLogicRela_Sim.CourseKnowledgeTitleA].ToString().Trim(); //课程知识点标题A
objvgs_KnowledgesLogicRela_SimEN.CourseKnowledgeTitleB = objRow[convgs_KnowledgesLogicRela_Sim.CourseKnowledgeTitleB] == DBNull.Value ? null : objRow[convgs_KnowledgesLogicRela_Sim.CourseKnowledgeTitleB].ToString().Trim(); //课程知识点标题B
objvgs_KnowledgesLogicRela_SimEN.RelaTypeId = objRow[convgs_KnowledgesLogicRela_Sim.RelaTypeId] == DBNull.Value ? null : objRow[convgs_KnowledgesLogicRela_Sim.RelaTypeId].ToString().Trim(); //关系类型Id
objvgs_KnowledgesLogicRela_SimEN.KnowledgeGraphId = objRow[convgs_KnowledgesLogicRela_Sim.KnowledgeGraphId] == DBNull.Value ? null : objRow[convgs_KnowledgesLogicRela_Sim.KnowledgeGraphId].ToString().Trim(); //知识点图Id
objvgs_KnowledgesLogicRela_SimEN.SourceAnchor = objRow[convgs_KnowledgesLogicRela_Sim.SourceAnchor] == DBNull.Value ? null : objRow[convgs_KnowledgesLogicRela_Sim.SourceAnchor].ToString().Trim(); //源锚点
objvgs_KnowledgesLogicRela_SimEN.TargetAnchor = objRow[convgs_KnowledgesLogicRela_Sim.TargetAnchor] == DBNull.Value ? null : objRow[convgs_KnowledgesLogicRela_Sim.TargetAnchor].ToString().Trim(); //目标锚点
objvgs_KnowledgesLogicRela_SimEN.CourseId = objRow[convgs_KnowledgesLogicRela_Sim.CourseId] == DBNull.Value ? null : objRow[convgs_KnowledgesLogicRela_Sim.CourseId].ToString().Trim(); //课程Id
objvgs_KnowledgesLogicRela_SimEN.RelaTitle = objRow[convgs_KnowledgesLogicRela_Sim.RelaTitle] == DBNull.Value ? null : objRow[convgs_KnowledgesLogicRela_Sim.RelaTitle].ToString().Trim(); //关系标题
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvgs_KnowledgesLogicRela_SimEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvgs_KnowledgesLogicRela_SimEN);
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
public static List<clsvgs_KnowledgesLogicRela_SimEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvgs_KnowledgesLogicRela_SimEN> arrObjLst = new List<clsvgs_KnowledgesLogicRela_SimEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvgs_KnowledgesLogicRela_SimEN objvgs_KnowledgesLogicRela_SimEN = new clsvgs_KnowledgesLogicRela_SimEN();
try
{
objvgs_KnowledgesLogicRela_SimEN.mId = Int32.Parse(objRow[convgs_KnowledgesLogicRela_Sim.mId].ToString().Trim()); //mId
objvgs_KnowledgesLogicRela_SimEN.CourseKnowledgeIdA = objRow[convgs_KnowledgesLogicRela_Sim.CourseKnowledgeIdA].ToString().Trim(); //课程知识点AId
objvgs_KnowledgesLogicRela_SimEN.CourseKnowledgeIdB = objRow[convgs_KnowledgesLogicRela_Sim.CourseKnowledgeIdB].ToString().Trim(); //课程知识点BId
objvgs_KnowledgesLogicRela_SimEN.CourseKnowledgeTitleA = objRow[convgs_KnowledgesLogicRela_Sim.CourseKnowledgeTitleA] == DBNull.Value ? null : objRow[convgs_KnowledgesLogicRela_Sim.CourseKnowledgeTitleA].ToString().Trim(); //课程知识点标题A
objvgs_KnowledgesLogicRela_SimEN.CourseKnowledgeTitleB = objRow[convgs_KnowledgesLogicRela_Sim.CourseKnowledgeTitleB] == DBNull.Value ? null : objRow[convgs_KnowledgesLogicRela_Sim.CourseKnowledgeTitleB].ToString().Trim(); //课程知识点标题B
objvgs_KnowledgesLogicRela_SimEN.RelaTypeId = objRow[convgs_KnowledgesLogicRela_Sim.RelaTypeId] == DBNull.Value ? null : objRow[convgs_KnowledgesLogicRela_Sim.RelaTypeId].ToString().Trim(); //关系类型Id
objvgs_KnowledgesLogicRela_SimEN.KnowledgeGraphId = objRow[convgs_KnowledgesLogicRela_Sim.KnowledgeGraphId] == DBNull.Value ? null : objRow[convgs_KnowledgesLogicRela_Sim.KnowledgeGraphId].ToString().Trim(); //知识点图Id
objvgs_KnowledgesLogicRela_SimEN.SourceAnchor = objRow[convgs_KnowledgesLogicRela_Sim.SourceAnchor] == DBNull.Value ? null : objRow[convgs_KnowledgesLogicRela_Sim.SourceAnchor].ToString().Trim(); //源锚点
objvgs_KnowledgesLogicRela_SimEN.TargetAnchor = objRow[convgs_KnowledgesLogicRela_Sim.TargetAnchor] == DBNull.Value ? null : objRow[convgs_KnowledgesLogicRela_Sim.TargetAnchor].ToString().Trim(); //目标锚点
objvgs_KnowledgesLogicRela_SimEN.CourseId = objRow[convgs_KnowledgesLogicRela_Sim.CourseId] == DBNull.Value ? null : objRow[convgs_KnowledgesLogicRela_Sim.CourseId].ToString().Trim(); //课程Id
objvgs_KnowledgesLogicRela_SimEN.RelaTitle = objRow[convgs_KnowledgesLogicRela_Sim.RelaTitle] == DBNull.Value ? null : objRow[convgs_KnowledgesLogicRela_Sim.RelaTitle].ToString().Trim(); //关系标题
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvgs_KnowledgesLogicRela_SimEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvgs_KnowledgesLogicRela_SimEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvgs_KnowledgesLogicRela_SimEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvgs_KnowledgesLogicRela_SimEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvgs_KnowledgesLogicRela_SimEN> arrObjLst = new List<clsvgs_KnowledgesLogicRela_SimEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvgs_KnowledgesLogicRela_SimEN objvgs_KnowledgesLogicRela_SimEN = new clsvgs_KnowledgesLogicRela_SimEN();
try
{
objvgs_KnowledgesLogicRela_SimEN.mId = Int32.Parse(objRow[convgs_KnowledgesLogicRela_Sim.mId].ToString().Trim()); //mId
objvgs_KnowledgesLogicRela_SimEN.CourseKnowledgeIdA = objRow[convgs_KnowledgesLogicRela_Sim.CourseKnowledgeIdA].ToString().Trim(); //课程知识点AId
objvgs_KnowledgesLogicRela_SimEN.CourseKnowledgeIdB = objRow[convgs_KnowledgesLogicRela_Sim.CourseKnowledgeIdB].ToString().Trim(); //课程知识点BId
objvgs_KnowledgesLogicRela_SimEN.CourseKnowledgeTitleA = objRow[convgs_KnowledgesLogicRela_Sim.CourseKnowledgeTitleA] == DBNull.Value ? null : objRow[convgs_KnowledgesLogicRela_Sim.CourseKnowledgeTitleA].ToString().Trim(); //课程知识点标题A
objvgs_KnowledgesLogicRela_SimEN.CourseKnowledgeTitleB = objRow[convgs_KnowledgesLogicRela_Sim.CourseKnowledgeTitleB] == DBNull.Value ? null : objRow[convgs_KnowledgesLogicRela_Sim.CourseKnowledgeTitleB].ToString().Trim(); //课程知识点标题B
objvgs_KnowledgesLogicRela_SimEN.RelaTypeId = objRow[convgs_KnowledgesLogicRela_Sim.RelaTypeId] == DBNull.Value ? null : objRow[convgs_KnowledgesLogicRela_Sim.RelaTypeId].ToString().Trim(); //关系类型Id
objvgs_KnowledgesLogicRela_SimEN.KnowledgeGraphId = objRow[convgs_KnowledgesLogicRela_Sim.KnowledgeGraphId] == DBNull.Value ? null : objRow[convgs_KnowledgesLogicRela_Sim.KnowledgeGraphId].ToString().Trim(); //知识点图Id
objvgs_KnowledgesLogicRela_SimEN.SourceAnchor = objRow[convgs_KnowledgesLogicRela_Sim.SourceAnchor] == DBNull.Value ? null : objRow[convgs_KnowledgesLogicRela_Sim.SourceAnchor].ToString().Trim(); //源锚点
objvgs_KnowledgesLogicRela_SimEN.TargetAnchor = objRow[convgs_KnowledgesLogicRela_Sim.TargetAnchor] == DBNull.Value ? null : objRow[convgs_KnowledgesLogicRela_Sim.TargetAnchor].ToString().Trim(); //目标锚点
objvgs_KnowledgesLogicRela_SimEN.CourseId = objRow[convgs_KnowledgesLogicRela_Sim.CourseId] == DBNull.Value ? null : objRow[convgs_KnowledgesLogicRela_Sim.CourseId].ToString().Trim(); //课程Id
objvgs_KnowledgesLogicRela_SimEN.RelaTitle = objRow[convgs_KnowledgesLogicRela_Sim.RelaTitle] == DBNull.Value ? null : objRow[convgs_KnowledgesLogicRela_Sim.RelaTitle].ToString().Trim(); //关系标题
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvgs_KnowledgesLogicRela_SimEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvgs_KnowledgesLogicRela_SimEN);
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
public static List<clsvgs_KnowledgesLogicRela_SimEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvgs_KnowledgesLogicRela_SimEN> arrObjLst = new List<clsvgs_KnowledgesLogicRela_SimEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvgs_KnowledgesLogicRela_SimEN objvgs_KnowledgesLogicRela_SimEN = new clsvgs_KnowledgesLogicRela_SimEN();
try
{
objvgs_KnowledgesLogicRela_SimEN.mId = Int32.Parse(objRow[convgs_KnowledgesLogicRela_Sim.mId].ToString().Trim()); //mId
objvgs_KnowledgesLogicRela_SimEN.CourseKnowledgeIdA = objRow[convgs_KnowledgesLogicRela_Sim.CourseKnowledgeIdA].ToString().Trim(); //课程知识点AId
objvgs_KnowledgesLogicRela_SimEN.CourseKnowledgeIdB = objRow[convgs_KnowledgesLogicRela_Sim.CourseKnowledgeIdB].ToString().Trim(); //课程知识点BId
objvgs_KnowledgesLogicRela_SimEN.CourseKnowledgeTitleA = objRow[convgs_KnowledgesLogicRela_Sim.CourseKnowledgeTitleA] == DBNull.Value ? null : objRow[convgs_KnowledgesLogicRela_Sim.CourseKnowledgeTitleA].ToString().Trim(); //课程知识点标题A
objvgs_KnowledgesLogicRela_SimEN.CourseKnowledgeTitleB = objRow[convgs_KnowledgesLogicRela_Sim.CourseKnowledgeTitleB] == DBNull.Value ? null : objRow[convgs_KnowledgesLogicRela_Sim.CourseKnowledgeTitleB].ToString().Trim(); //课程知识点标题B
objvgs_KnowledgesLogicRela_SimEN.RelaTypeId = objRow[convgs_KnowledgesLogicRela_Sim.RelaTypeId] == DBNull.Value ? null : objRow[convgs_KnowledgesLogicRela_Sim.RelaTypeId].ToString().Trim(); //关系类型Id
objvgs_KnowledgesLogicRela_SimEN.KnowledgeGraphId = objRow[convgs_KnowledgesLogicRela_Sim.KnowledgeGraphId] == DBNull.Value ? null : objRow[convgs_KnowledgesLogicRela_Sim.KnowledgeGraphId].ToString().Trim(); //知识点图Id
objvgs_KnowledgesLogicRela_SimEN.SourceAnchor = objRow[convgs_KnowledgesLogicRela_Sim.SourceAnchor] == DBNull.Value ? null : objRow[convgs_KnowledgesLogicRela_Sim.SourceAnchor].ToString().Trim(); //源锚点
objvgs_KnowledgesLogicRela_SimEN.TargetAnchor = objRow[convgs_KnowledgesLogicRela_Sim.TargetAnchor] == DBNull.Value ? null : objRow[convgs_KnowledgesLogicRela_Sim.TargetAnchor].ToString().Trim(); //目标锚点
objvgs_KnowledgesLogicRela_SimEN.CourseId = objRow[convgs_KnowledgesLogicRela_Sim.CourseId] == DBNull.Value ? null : objRow[convgs_KnowledgesLogicRela_Sim.CourseId].ToString().Trim(); //课程Id
objvgs_KnowledgesLogicRela_SimEN.RelaTitle = objRow[convgs_KnowledgesLogicRela_Sim.RelaTitle] == DBNull.Value ? null : objRow[convgs_KnowledgesLogicRela_Sim.RelaTitle].ToString().Trim(); //关系标题
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvgs_KnowledgesLogicRela_SimEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvgs_KnowledgesLogicRela_SimEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvgs_KnowledgesLogicRela_SimEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvgs_KnowledgesLogicRela_SimEN> arrObjLst = new List<clsvgs_KnowledgesLogicRela_SimEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvgs_KnowledgesLogicRela_SimEN objvgs_KnowledgesLogicRela_SimEN = new clsvgs_KnowledgesLogicRela_SimEN();
try
{
objvgs_KnowledgesLogicRela_SimEN.mId = Int32.Parse(objRow[convgs_KnowledgesLogicRela_Sim.mId].ToString().Trim()); //mId
objvgs_KnowledgesLogicRela_SimEN.CourseKnowledgeIdA = objRow[convgs_KnowledgesLogicRela_Sim.CourseKnowledgeIdA].ToString().Trim(); //课程知识点AId
objvgs_KnowledgesLogicRela_SimEN.CourseKnowledgeIdB = objRow[convgs_KnowledgesLogicRela_Sim.CourseKnowledgeIdB].ToString().Trim(); //课程知识点BId
objvgs_KnowledgesLogicRela_SimEN.CourseKnowledgeTitleA = objRow[convgs_KnowledgesLogicRela_Sim.CourseKnowledgeTitleA] == DBNull.Value ? null : objRow[convgs_KnowledgesLogicRela_Sim.CourseKnowledgeTitleA].ToString().Trim(); //课程知识点标题A
objvgs_KnowledgesLogicRela_SimEN.CourseKnowledgeTitleB = objRow[convgs_KnowledgesLogicRela_Sim.CourseKnowledgeTitleB] == DBNull.Value ? null : objRow[convgs_KnowledgesLogicRela_Sim.CourseKnowledgeTitleB].ToString().Trim(); //课程知识点标题B
objvgs_KnowledgesLogicRela_SimEN.RelaTypeId = objRow[convgs_KnowledgesLogicRela_Sim.RelaTypeId] == DBNull.Value ? null : objRow[convgs_KnowledgesLogicRela_Sim.RelaTypeId].ToString().Trim(); //关系类型Id
objvgs_KnowledgesLogicRela_SimEN.KnowledgeGraphId = objRow[convgs_KnowledgesLogicRela_Sim.KnowledgeGraphId] == DBNull.Value ? null : objRow[convgs_KnowledgesLogicRela_Sim.KnowledgeGraphId].ToString().Trim(); //知识点图Id
objvgs_KnowledgesLogicRela_SimEN.SourceAnchor = objRow[convgs_KnowledgesLogicRela_Sim.SourceAnchor] == DBNull.Value ? null : objRow[convgs_KnowledgesLogicRela_Sim.SourceAnchor].ToString().Trim(); //源锚点
objvgs_KnowledgesLogicRela_SimEN.TargetAnchor = objRow[convgs_KnowledgesLogicRela_Sim.TargetAnchor] == DBNull.Value ? null : objRow[convgs_KnowledgesLogicRela_Sim.TargetAnchor].ToString().Trim(); //目标锚点
objvgs_KnowledgesLogicRela_SimEN.CourseId = objRow[convgs_KnowledgesLogicRela_Sim.CourseId] == DBNull.Value ? null : objRow[convgs_KnowledgesLogicRela_Sim.CourseId].ToString().Trim(); //课程Id
objvgs_KnowledgesLogicRela_SimEN.RelaTitle = objRow[convgs_KnowledgesLogicRela_Sim.RelaTitle] == DBNull.Value ? null : objRow[convgs_KnowledgesLogicRela_Sim.RelaTitle].ToString().Trim(); //关系标题
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvgs_KnowledgesLogicRela_SimEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvgs_KnowledgesLogicRela_SimEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvgs_KnowledgesLogicRela_SimEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool Getvgs_KnowledgesLogicRela_Sim(ref clsvgs_KnowledgesLogicRela_SimEN objvgs_KnowledgesLogicRela_SimEN)
{
bool bolResult = vgs_KnowledgesLogicRela_SimDA.Getvgs_KnowledgesLogicRela_Sim(ref objvgs_KnowledgesLogicRela_SimEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvgs_KnowledgesLogicRela_SimEN GetObjBymId(long lngmId)
{
clsvgs_KnowledgesLogicRela_SimEN objvgs_KnowledgesLogicRela_SimEN = vgs_KnowledgesLogicRela_SimDA.GetObjBymId(lngmId);
return objvgs_KnowledgesLogicRela_SimEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvgs_KnowledgesLogicRela_SimEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvgs_KnowledgesLogicRela_SimEN objvgs_KnowledgesLogicRela_SimEN = vgs_KnowledgesLogicRela_SimDA.GetFirstObj(strWhereCond);
 return objvgs_KnowledgesLogicRela_SimEN;
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
public static clsvgs_KnowledgesLogicRela_SimEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvgs_KnowledgesLogicRela_SimEN objvgs_KnowledgesLogicRela_SimEN = vgs_KnowledgesLogicRela_SimDA.GetObjByDataRow(objRow);
 return objvgs_KnowledgesLogicRela_SimEN;
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
public static clsvgs_KnowledgesLogicRela_SimEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvgs_KnowledgesLogicRela_SimEN objvgs_KnowledgesLogicRela_SimEN = vgs_KnowledgesLogicRela_SimDA.GetObjByDataRow(objRow);
 return objvgs_KnowledgesLogicRela_SimEN;
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
 /// <param name = "lngmId">所给的关键字</param>
 /// <param name = "lstvgs_KnowledgesLogicRela_SimObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvgs_KnowledgesLogicRela_SimEN GetObjBymIdFromList(long lngmId, List<clsvgs_KnowledgesLogicRela_SimEN> lstvgs_KnowledgesLogicRela_SimObjLst)
{
foreach (clsvgs_KnowledgesLogicRela_SimEN objvgs_KnowledgesLogicRela_SimEN in lstvgs_KnowledgesLogicRela_SimObjLst)
{
if (objvgs_KnowledgesLogicRela_SimEN.mId == lngmId)
{
return objvgs_KnowledgesLogicRela_SimEN;
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
 long lngmId;
 try
 {
 lngmId = new clsvgs_KnowledgesLogicRela_SimDA().GetFirstID(strWhereCond);
 return lngmId;
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
 arrList = vgs_KnowledgesLogicRela_SimDA.GetID(strWhereCond);
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
bool bolIsExist = vgs_KnowledgesLogicRela_SimDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "lngmId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(long lngmId)
{
//检测记录是否存在
bool bolIsExist = vgs_KnowledgesLogicRela_SimDA.IsExist(lngmId);
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
 bolIsExist = clsvgs_KnowledgesLogicRela_SimDA.IsExistTable();
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
 bolIsExist = vgs_KnowledgesLogicRela_SimDA.IsExistTable(strTabName);
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
 /// <param name = "objvgs_KnowledgesLogicRela_SimENS">源对象</param>
 /// <param name = "objvgs_KnowledgesLogicRela_SimENT">目标对象</param>
 public static void CopyTo(clsvgs_KnowledgesLogicRela_SimEN objvgs_KnowledgesLogicRela_SimENS, clsvgs_KnowledgesLogicRela_SimEN objvgs_KnowledgesLogicRela_SimENT)
{
try
{
objvgs_KnowledgesLogicRela_SimENT.mId = objvgs_KnowledgesLogicRela_SimENS.mId; //mId
objvgs_KnowledgesLogicRela_SimENT.CourseKnowledgeIdA = objvgs_KnowledgesLogicRela_SimENS.CourseKnowledgeIdA; //课程知识点AId
objvgs_KnowledgesLogicRela_SimENT.CourseKnowledgeIdB = objvgs_KnowledgesLogicRela_SimENS.CourseKnowledgeIdB; //课程知识点BId
objvgs_KnowledgesLogicRela_SimENT.CourseKnowledgeTitleA = objvgs_KnowledgesLogicRela_SimENS.CourseKnowledgeTitleA; //课程知识点标题A
objvgs_KnowledgesLogicRela_SimENT.CourseKnowledgeTitleB = objvgs_KnowledgesLogicRela_SimENS.CourseKnowledgeTitleB; //课程知识点标题B
objvgs_KnowledgesLogicRela_SimENT.RelaTypeId = objvgs_KnowledgesLogicRela_SimENS.RelaTypeId; //关系类型Id
objvgs_KnowledgesLogicRela_SimENT.KnowledgeGraphId = objvgs_KnowledgesLogicRela_SimENS.KnowledgeGraphId; //知识点图Id
objvgs_KnowledgesLogicRela_SimENT.SourceAnchor = objvgs_KnowledgesLogicRela_SimENS.SourceAnchor; //源锚点
objvgs_KnowledgesLogicRela_SimENT.TargetAnchor = objvgs_KnowledgesLogicRela_SimENS.TargetAnchor; //目标锚点
objvgs_KnowledgesLogicRela_SimENT.CourseId = objvgs_KnowledgesLogicRela_SimENS.CourseId; //课程Id
objvgs_KnowledgesLogicRela_SimENT.RelaTitle = objvgs_KnowledgesLogicRela_SimENS.RelaTitle; //关系标题
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
 /// <param name = "objvgs_KnowledgesLogicRela_SimEN">源简化对象</param>
 public static void SetUpdFlag(clsvgs_KnowledgesLogicRela_SimEN objvgs_KnowledgesLogicRela_SimEN)
{
try
{
objvgs_KnowledgesLogicRela_SimEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvgs_KnowledgesLogicRela_SimEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convgs_KnowledgesLogicRela_Sim.mId, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_KnowledgesLogicRela_SimEN.mId = objvgs_KnowledgesLogicRela_SimEN.mId; //mId
}
if (arrFldSet.Contains(convgs_KnowledgesLogicRela_Sim.CourseKnowledgeIdA, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_KnowledgesLogicRela_SimEN.CourseKnowledgeIdA = objvgs_KnowledgesLogicRela_SimEN.CourseKnowledgeIdA; //课程知识点AId
}
if (arrFldSet.Contains(convgs_KnowledgesLogicRela_Sim.CourseKnowledgeIdB, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_KnowledgesLogicRela_SimEN.CourseKnowledgeIdB = objvgs_KnowledgesLogicRela_SimEN.CourseKnowledgeIdB; //课程知识点BId
}
if (arrFldSet.Contains(convgs_KnowledgesLogicRela_Sim.CourseKnowledgeTitleA, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_KnowledgesLogicRela_SimEN.CourseKnowledgeTitleA = objvgs_KnowledgesLogicRela_SimEN.CourseKnowledgeTitleA == "[null]" ? null :  objvgs_KnowledgesLogicRela_SimEN.CourseKnowledgeTitleA; //课程知识点标题A
}
if (arrFldSet.Contains(convgs_KnowledgesLogicRela_Sim.CourseKnowledgeTitleB, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_KnowledgesLogicRela_SimEN.CourseKnowledgeTitleB = objvgs_KnowledgesLogicRela_SimEN.CourseKnowledgeTitleB == "[null]" ? null :  objvgs_KnowledgesLogicRela_SimEN.CourseKnowledgeTitleB; //课程知识点标题B
}
if (arrFldSet.Contains(convgs_KnowledgesLogicRela_Sim.RelaTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_KnowledgesLogicRela_SimEN.RelaTypeId = objvgs_KnowledgesLogicRela_SimEN.RelaTypeId == "[null]" ? null :  objvgs_KnowledgesLogicRela_SimEN.RelaTypeId; //关系类型Id
}
if (arrFldSet.Contains(convgs_KnowledgesLogicRela_Sim.KnowledgeGraphId, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_KnowledgesLogicRela_SimEN.KnowledgeGraphId = objvgs_KnowledgesLogicRela_SimEN.KnowledgeGraphId == "[null]" ? null :  objvgs_KnowledgesLogicRela_SimEN.KnowledgeGraphId; //知识点图Id
}
if (arrFldSet.Contains(convgs_KnowledgesLogicRela_Sim.SourceAnchor, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_KnowledgesLogicRela_SimEN.SourceAnchor = objvgs_KnowledgesLogicRela_SimEN.SourceAnchor == "[null]" ? null :  objvgs_KnowledgesLogicRela_SimEN.SourceAnchor; //源锚点
}
if (arrFldSet.Contains(convgs_KnowledgesLogicRela_Sim.TargetAnchor, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_KnowledgesLogicRela_SimEN.TargetAnchor = objvgs_KnowledgesLogicRela_SimEN.TargetAnchor == "[null]" ? null :  objvgs_KnowledgesLogicRela_SimEN.TargetAnchor; //目标锚点
}
if (arrFldSet.Contains(convgs_KnowledgesLogicRela_Sim.CourseId, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_KnowledgesLogicRela_SimEN.CourseId = objvgs_KnowledgesLogicRela_SimEN.CourseId == "[null]" ? null :  objvgs_KnowledgesLogicRela_SimEN.CourseId; //课程Id
}
if (arrFldSet.Contains(convgs_KnowledgesLogicRela_Sim.RelaTitle, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_KnowledgesLogicRela_SimEN.RelaTitle = objvgs_KnowledgesLogicRela_SimEN.RelaTitle == "[null]" ? null :  objvgs_KnowledgesLogicRela_SimEN.RelaTitle; //关系标题
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
 /// <param name = "objvgs_KnowledgesLogicRela_SimEN">源简化对象</param>
 public static void AccessFldValueNull(clsvgs_KnowledgesLogicRela_SimEN objvgs_KnowledgesLogicRela_SimEN)
{
try
{
if (objvgs_KnowledgesLogicRela_SimEN.CourseKnowledgeTitleA == "[null]") objvgs_KnowledgesLogicRela_SimEN.CourseKnowledgeTitleA = null; //课程知识点标题A
if (objvgs_KnowledgesLogicRela_SimEN.CourseKnowledgeTitleB == "[null]") objvgs_KnowledgesLogicRela_SimEN.CourseKnowledgeTitleB = null; //课程知识点标题B
if (objvgs_KnowledgesLogicRela_SimEN.RelaTypeId == "[null]") objvgs_KnowledgesLogicRela_SimEN.RelaTypeId = null; //关系类型Id
if (objvgs_KnowledgesLogicRela_SimEN.KnowledgeGraphId == "[null]") objvgs_KnowledgesLogicRela_SimEN.KnowledgeGraphId = null; //知识点图Id
if (objvgs_KnowledgesLogicRela_SimEN.SourceAnchor == "[null]") objvgs_KnowledgesLogicRela_SimEN.SourceAnchor = null; //源锚点
if (objvgs_KnowledgesLogicRela_SimEN.TargetAnchor == "[null]") objvgs_KnowledgesLogicRela_SimEN.TargetAnchor = null; //目标锚点
if (objvgs_KnowledgesLogicRela_SimEN.CourseId == "[null]") objvgs_KnowledgesLogicRela_SimEN.CourseId = null; //课程Id
if (objvgs_KnowledgesLogicRela_SimEN.RelaTitle == "[null]") objvgs_KnowledgesLogicRela_SimEN.RelaTitle = null; //关系标题
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
public static void CheckProperty4Condition(clsvgs_KnowledgesLogicRela_SimEN objvgs_KnowledgesLogicRela_SimEN)
{
 vgs_KnowledgesLogicRela_SimDA.CheckProperty4Condition(objvgs_KnowledgesLogicRela_SimEN);
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
if (clsgs_KnowledgesLogicRelaBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsgs_KnowledgesLogicRelaBL没有刷新缓存机制(clsgs_KnowledgesLogicRelaBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by mId");
//if (arrvgs_KnowledgesLogicRela_SimObjLstCache == null)
//{
//arrvgs_KnowledgesLogicRela_SimObjLstCache = vgs_KnowledgesLogicRela_SimDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngmId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvgs_KnowledgesLogicRela_SimEN GetObjBymIdCache(long lngmId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvgs_KnowledgesLogicRela_SimEN._CurrTabName);
List<clsvgs_KnowledgesLogicRela_SimEN> arrvgs_KnowledgesLogicRela_SimObjLstCache = GetObjLstCache();
IEnumerable <clsvgs_KnowledgesLogicRela_SimEN> arrvgs_KnowledgesLogicRela_SimObjLst_Sel =
arrvgs_KnowledgesLogicRela_SimObjLstCache
.Where(x=> x.mId == lngmId 
);
if (arrvgs_KnowledgesLogicRela_SimObjLst_Sel.Count() == 0)
{
   clsvgs_KnowledgesLogicRela_SimEN obj = clsvgs_KnowledgesLogicRela_SimBL.GetObjBymId(lngmId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvgs_KnowledgesLogicRela_SimObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvgs_KnowledgesLogicRela_SimEN> GetAllvgs_KnowledgesLogicRela_SimObjLstCache()
{
//获取缓存中的对象列表
List<clsvgs_KnowledgesLogicRela_SimEN> arrvgs_KnowledgesLogicRela_SimObjLstCache = GetObjLstCache(); 
return arrvgs_KnowledgesLogicRela_SimObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvgs_KnowledgesLogicRela_SimEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvgs_KnowledgesLogicRela_SimEN._CurrTabName);
List<clsvgs_KnowledgesLogicRela_SimEN> arrvgs_KnowledgesLogicRela_SimObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvgs_KnowledgesLogicRela_SimObjLstCache;
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
string strKey = string.Format("{0}", clsvgs_KnowledgesLogicRela_SimEN._CurrTabName);
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

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--vgs_KnowledgesLogicRela_Sim(v知识点逻辑关系_Sim)
 /// 唯一性条件:CourseKnowledgeIdA_CourseKnowledgeIdB_RelaTypeId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objvgs_KnowledgesLogicRela_SimEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsvgs_KnowledgesLogicRela_SimEN objvgs_KnowledgesLogicRela_SimEN)
{
//检测记录是否存在
string strResult = vgs_KnowledgesLogicRela_SimDA.GetUniCondStr(objvgs_KnowledgesLogicRela_SimEN);
return strResult;
}


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
public static string Func(string strInFldName, string strOutFldName, long lngmId)
{
if (strInFldName != convgs_KnowledgesLogicRela_Sim.mId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convgs_KnowledgesLogicRela_Sim.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convgs_KnowledgesLogicRela_Sim.AttributeName));
throw new Exception(strMsg);
}
var objvgs_KnowledgesLogicRela_Sim = clsvgs_KnowledgesLogicRela_SimBL.GetObjBymIdCache(lngmId);
if (objvgs_KnowledgesLogicRela_Sim == null) return "";
return objvgs_KnowledgesLogicRela_Sim[strOutFldName].ToString();
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
int intRecCount = clsvgs_KnowledgesLogicRela_SimDA.GetRecCount(strTabName);
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
int intRecCount = clsvgs_KnowledgesLogicRela_SimDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvgs_KnowledgesLogicRela_SimDA.GetRecCount();
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
int intRecCount = clsvgs_KnowledgesLogicRela_SimDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvgs_KnowledgesLogicRela_SimCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvgs_KnowledgesLogicRela_SimEN objvgs_KnowledgesLogicRela_SimCond)
{
List<clsvgs_KnowledgesLogicRela_SimEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvgs_KnowledgesLogicRela_SimEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convgs_KnowledgesLogicRela_Sim.AttributeName)
{
if (objvgs_KnowledgesLogicRela_SimCond.IsUpdated(strFldName) == false) continue;
if (objvgs_KnowledgesLogicRela_SimCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvgs_KnowledgesLogicRela_SimCond[strFldName].ToString());
}
else
{
if (objvgs_KnowledgesLogicRela_SimCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvgs_KnowledgesLogicRela_SimCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvgs_KnowledgesLogicRela_SimCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvgs_KnowledgesLogicRela_SimCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvgs_KnowledgesLogicRela_SimCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvgs_KnowledgesLogicRela_SimCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvgs_KnowledgesLogicRela_SimCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvgs_KnowledgesLogicRela_SimCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvgs_KnowledgesLogicRela_SimCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvgs_KnowledgesLogicRela_SimCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvgs_KnowledgesLogicRela_SimCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvgs_KnowledgesLogicRela_SimCond[strFldName]));
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
 List<string> arrList = clsvgs_KnowledgesLogicRela_SimDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vgs_KnowledgesLogicRela_SimDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vgs_KnowledgesLogicRela_SimDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}