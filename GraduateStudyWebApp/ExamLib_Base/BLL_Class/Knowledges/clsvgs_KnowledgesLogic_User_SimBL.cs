
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvgs_KnowledgesLogic_User_SimBL
 表名:vgs_KnowledgesLogic_User_Sim(01120933)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 12:57:53
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
public static class  clsvgs_KnowledgesLogic_User_SimBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvgs_KnowledgesLogic_User_SimEN GetObj(this K_mId_vgs_KnowledgesLogic_User_Sim myKey)
{
clsvgs_KnowledgesLogic_User_SimEN objvgs_KnowledgesLogic_User_SimEN = clsvgs_KnowledgesLogic_User_SimBL.vgs_KnowledgesLogic_User_SimDA.GetObjBymId(myKey.Value);
return objvgs_KnowledgesLogic_User_SimEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_KnowledgesLogic_User_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_KnowledgesLogic_User_SimEN SetmId(this clsvgs_KnowledgesLogic_User_SimEN objvgs_KnowledgesLogic_User_SimEN, long lngmId, string strComparisonOp="")
	{
objvgs_KnowledgesLogic_User_SimEN.mId = lngmId; //mId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_KnowledgesLogic_User_SimEN.dicFldComparisonOp.ContainsKey(convgs_KnowledgesLogic_User_Sim.mId) == false)
{
objvgs_KnowledgesLogic_User_SimEN.dicFldComparisonOp.Add(convgs_KnowledgesLogic_User_Sim.mId, strComparisonOp);
}
else
{
objvgs_KnowledgesLogic_User_SimEN.dicFldComparisonOp[convgs_KnowledgesLogic_User_Sim.mId] = strComparisonOp;
}
}
return objvgs_KnowledgesLogic_User_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_KnowledgesLogic_User_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_KnowledgesLogic_User_SimEN SetCourseKnowledgeId(this clsvgs_KnowledgesLogic_User_SimEN objvgs_KnowledgesLogic_User_SimEN, string strCourseKnowledgeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCourseKnowledgeId, convgs_KnowledgesLogic_User_Sim.CourseKnowledgeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseKnowledgeId, 8, convgs_KnowledgesLogic_User_Sim.CourseKnowledgeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCourseKnowledgeId, 8, convgs_KnowledgesLogic_User_Sim.CourseKnowledgeId);
}
objvgs_KnowledgesLogic_User_SimEN.CourseKnowledgeId = strCourseKnowledgeId; //知识点Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_KnowledgesLogic_User_SimEN.dicFldComparisonOp.ContainsKey(convgs_KnowledgesLogic_User_Sim.CourseKnowledgeId) == false)
{
objvgs_KnowledgesLogic_User_SimEN.dicFldComparisonOp.Add(convgs_KnowledgesLogic_User_Sim.CourseKnowledgeId, strComparisonOp);
}
else
{
objvgs_KnowledgesLogic_User_SimEN.dicFldComparisonOp[convgs_KnowledgesLogic_User_Sim.CourseKnowledgeId] = strComparisonOp;
}
}
return objvgs_KnowledgesLogic_User_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_KnowledgesLogic_User_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_KnowledgesLogic_User_SimEN SetKnowledgeGraphId(this clsvgs_KnowledgesLogic_User_SimEN objvgs_KnowledgesLogic_User_SimEN, string strKnowledgeGraphId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strKnowledgeGraphId, 10, convgs_KnowledgesLogic_User_Sim.KnowledgeGraphId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strKnowledgeGraphId, 10, convgs_KnowledgesLogic_User_Sim.KnowledgeGraphId);
}
objvgs_KnowledgesLogic_User_SimEN.KnowledgeGraphId = strKnowledgeGraphId; //知识点图Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_KnowledgesLogic_User_SimEN.dicFldComparisonOp.ContainsKey(convgs_KnowledgesLogic_User_Sim.KnowledgeGraphId) == false)
{
objvgs_KnowledgesLogic_User_SimEN.dicFldComparisonOp.Add(convgs_KnowledgesLogic_User_Sim.KnowledgeGraphId, strComparisonOp);
}
else
{
objvgs_KnowledgesLogic_User_SimEN.dicFldComparisonOp[convgs_KnowledgesLogic_User_Sim.KnowledgeGraphId] = strComparisonOp;
}
}
return objvgs_KnowledgesLogic_User_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_KnowledgesLogic_User_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_KnowledgesLogic_User_SimEN SetClassName(this clsvgs_KnowledgesLogic_User_SimEN objvgs_KnowledgesLogic_User_SimEN, string strClassName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strClassName, 100, convgs_KnowledgesLogic_User_Sim.ClassName);
}
objvgs_KnowledgesLogic_User_SimEN.ClassName = strClassName; //样式名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_KnowledgesLogic_User_SimEN.dicFldComparisonOp.ContainsKey(convgs_KnowledgesLogic_User_Sim.ClassName) == false)
{
objvgs_KnowledgesLogic_User_SimEN.dicFldComparisonOp.Add(convgs_KnowledgesLogic_User_Sim.ClassName, strComparisonOp);
}
else
{
objvgs_KnowledgesLogic_User_SimEN.dicFldComparisonOp[convgs_KnowledgesLogic_User_Sim.ClassName] = strComparisonOp;
}
}
return objvgs_KnowledgesLogic_User_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_KnowledgesLogic_User_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_KnowledgesLogic_User_SimEN SetCourseId(this clsvgs_KnowledgesLogic_User_SimEN objvgs_KnowledgesLogic_User_SimEN, string strCourseId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseId, 8, convgs_KnowledgesLogic_User_Sim.CourseId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCourseId, 8, convgs_KnowledgesLogic_User_Sim.CourseId);
}
objvgs_KnowledgesLogic_User_SimEN.CourseId = strCourseId; //课程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_KnowledgesLogic_User_SimEN.dicFldComparisonOp.ContainsKey(convgs_KnowledgesLogic_User_Sim.CourseId) == false)
{
objvgs_KnowledgesLogic_User_SimEN.dicFldComparisonOp.Add(convgs_KnowledgesLogic_User_Sim.CourseId, strComparisonOp);
}
else
{
objvgs_KnowledgesLogic_User_SimEN.dicFldComparisonOp[convgs_KnowledgesLogic_User_Sim.CourseId] = strComparisonOp;
}
}
return objvgs_KnowledgesLogic_User_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_KnowledgesLogic_User_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_KnowledgesLogic_User_SimEN SetIdCurrEduCls(this clsvgs_KnowledgesLogic_User_SimEN objvgs_KnowledgesLogic_User_SimEN, string strIdCurrEduCls, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdCurrEduCls, 8, convgs_KnowledgesLogic_User_Sim.IdCurrEduCls);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdCurrEduCls, 8, convgs_KnowledgesLogic_User_Sim.IdCurrEduCls);
}
objvgs_KnowledgesLogic_User_SimEN.IdCurrEduCls = strIdCurrEduCls; //教学班流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_KnowledgesLogic_User_SimEN.dicFldComparisonOp.ContainsKey(convgs_KnowledgesLogic_User_Sim.IdCurrEduCls) == false)
{
objvgs_KnowledgesLogic_User_SimEN.dicFldComparisonOp.Add(convgs_KnowledgesLogic_User_Sim.IdCurrEduCls, strComparisonOp);
}
else
{
objvgs_KnowledgesLogic_User_SimEN.dicFldComparisonOp[convgs_KnowledgesLogic_User_Sim.IdCurrEduCls] = strComparisonOp;
}
}
return objvgs_KnowledgesLogic_User_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_KnowledgesLogic_User_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_KnowledgesLogic_User_SimEN SetUserId(this clsvgs_KnowledgesLogic_User_SimEN objvgs_KnowledgesLogic_User_SimEN, string strUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserId, convgs_KnowledgesLogic_User_Sim.UserId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserId, 18, convgs_KnowledgesLogic_User_Sim.UserId);
}
objvgs_KnowledgesLogic_User_SimEN.UserId = strUserId; //用户ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_KnowledgesLogic_User_SimEN.dicFldComparisonOp.ContainsKey(convgs_KnowledgesLogic_User_Sim.UserId) == false)
{
objvgs_KnowledgesLogic_User_SimEN.dicFldComparisonOp.Add(convgs_KnowledgesLogic_User_Sim.UserId, strComparisonOp);
}
else
{
objvgs_KnowledgesLogic_User_SimEN.dicFldComparisonOp[convgs_KnowledgesLogic_User_Sim.UserId] = strComparisonOp;
}
}
return objvgs_KnowledgesLogic_User_SimEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvgs_KnowledgesLogic_User_SimENS">源对象</param>
 /// <param name = "objvgs_KnowledgesLogic_User_SimENT">目标对象</param>
 public static void CopyTo(this clsvgs_KnowledgesLogic_User_SimEN objvgs_KnowledgesLogic_User_SimENS, clsvgs_KnowledgesLogic_User_SimEN objvgs_KnowledgesLogic_User_SimENT)
{
try
{
objvgs_KnowledgesLogic_User_SimENT.mId = objvgs_KnowledgesLogic_User_SimENS.mId; //mId
objvgs_KnowledgesLogic_User_SimENT.CourseKnowledgeId = objvgs_KnowledgesLogic_User_SimENS.CourseKnowledgeId; //知识点Id
objvgs_KnowledgesLogic_User_SimENT.KnowledgeGraphId = objvgs_KnowledgesLogic_User_SimENS.KnowledgeGraphId; //知识点图Id
objvgs_KnowledgesLogic_User_SimENT.ClassName = objvgs_KnowledgesLogic_User_SimENS.ClassName; //样式名称
objvgs_KnowledgesLogic_User_SimENT.CourseId = objvgs_KnowledgesLogic_User_SimENS.CourseId; //课程Id
objvgs_KnowledgesLogic_User_SimENT.IdCurrEduCls = objvgs_KnowledgesLogic_User_SimENS.IdCurrEduCls; //教学班流水号
objvgs_KnowledgesLogic_User_SimENT.UserId = objvgs_KnowledgesLogic_User_SimENS.UserId; //用户ID
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
 /// <param name = "objvgs_KnowledgesLogic_User_SimENS">源对象</param>
 /// <returns>目标对象=>clsvgs_KnowledgesLogic_User_SimEN:objvgs_KnowledgesLogic_User_SimENT</returns>
 public static clsvgs_KnowledgesLogic_User_SimEN CopyTo(this clsvgs_KnowledgesLogic_User_SimEN objvgs_KnowledgesLogic_User_SimENS)
{
try
{
 clsvgs_KnowledgesLogic_User_SimEN objvgs_KnowledgesLogic_User_SimENT = new clsvgs_KnowledgesLogic_User_SimEN()
{
mId = objvgs_KnowledgesLogic_User_SimENS.mId, //mId
CourseKnowledgeId = objvgs_KnowledgesLogic_User_SimENS.CourseKnowledgeId, //知识点Id
KnowledgeGraphId = objvgs_KnowledgesLogic_User_SimENS.KnowledgeGraphId, //知识点图Id
ClassName = objvgs_KnowledgesLogic_User_SimENS.ClassName, //样式名称
CourseId = objvgs_KnowledgesLogic_User_SimENS.CourseId, //课程Id
IdCurrEduCls = objvgs_KnowledgesLogic_User_SimENS.IdCurrEduCls, //教学班流水号
UserId = objvgs_KnowledgesLogic_User_SimENS.UserId, //用户ID
};
 return objvgs_KnowledgesLogic_User_SimENT;
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
public static void CheckProperty4Condition(this clsvgs_KnowledgesLogic_User_SimEN objvgs_KnowledgesLogic_User_SimEN)
{
 clsvgs_KnowledgesLogic_User_SimBL.vgs_KnowledgesLogic_User_SimDA.CheckProperty4Condition(objvgs_KnowledgesLogic_User_SimEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvgs_KnowledgesLogic_User_SimEN objvgs_KnowledgesLogic_User_SimCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvgs_KnowledgesLogic_User_SimCond.IsUpdated(convgs_KnowledgesLogic_User_Sim.mId) == true)
{
string strComparisonOpmId = objvgs_KnowledgesLogic_User_SimCond.dicFldComparisonOp[convgs_KnowledgesLogic_User_Sim.mId];
strWhereCond += string.Format(" And {0} {2} {1}", convgs_KnowledgesLogic_User_Sim.mId, objvgs_KnowledgesLogic_User_SimCond.mId, strComparisonOpmId);
}
if (objvgs_KnowledgesLogic_User_SimCond.IsUpdated(convgs_KnowledgesLogic_User_Sim.CourseKnowledgeId) == true)
{
string strComparisonOpCourseKnowledgeId = objvgs_KnowledgesLogic_User_SimCond.dicFldComparisonOp[convgs_KnowledgesLogic_User_Sim.CourseKnowledgeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_KnowledgesLogic_User_Sim.CourseKnowledgeId, objvgs_KnowledgesLogic_User_SimCond.CourseKnowledgeId, strComparisonOpCourseKnowledgeId);
}
if (objvgs_KnowledgesLogic_User_SimCond.IsUpdated(convgs_KnowledgesLogic_User_Sim.KnowledgeGraphId) == true)
{
string strComparisonOpKnowledgeGraphId = objvgs_KnowledgesLogic_User_SimCond.dicFldComparisonOp[convgs_KnowledgesLogic_User_Sim.KnowledgeGraphId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_KnowledgesLogic_User_Sim.KnowledgeGraphId, objvgs_KnowledgesLogic_User_SimCond.KnowledgeGraphId, strComparisonOpKnowledgeGraphId);
}
if (objvgs_KnowledgesLogic_User_SimCond.IsUpdated(convgs_KnowledgesLogic_User_Sim.ClassName) == true)
{
string strComparisonOpClassName = objvgs_KnowledgesLogic_User_SimCond.dicFldComparisonOp[convgs_KnowledgesLogic_User_Sim.ClassName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_KnowledgesLogic_User_Sim.ClassName, objvgs_KnowledgesLogic_User_SimCond.ClassName, strComparisonOpClassName);
}
if (objvgs_KnowledgesLogic_User_SimCond.IsUpdated(convgs_KnowledgesLogic_User_Sim.CourseId) == true)
{
string strComparisonOpCourseId = objvgs_KnowledgesLogic_User_SimCond.dicFldComparisonOp[convgs_KnowledgesLogic_User_Sim.CourseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_KnowledgesLogic_User_Sim.CourseId, objvgs_KnowledgesLogic_User_SimCond.CourseId, strComparisonOpCourseId);
}
if (objvgs_KnowledgesLogic_User_SimCond.IsUpdated(convgs_KnowledgesLogic_User_Sim.IdCurrEduCls) == true)
{
string strComparisonOpIdCurrEduCls = objvgs_KnowledgesLogic_User_SimCond.dicFldComparisonOp[convgs_KnowledgesLogic_User_Sim.IdCurrEduCls];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_KnowledgesLogic_User_Sim.IdCurrEduCls, objvgs_KnowledgesLogic_User_SimCond.IdCurrEduCls, strComparisonOpIdCurrEduCls);
}
if (objvgs_KnowledgesLogic_User_SimCond.IsUpdated(convgs_KnowledgesLogic_User_Sim.UserId) == true)
{
string strComparisonOpUserId = objvgs_KnowledgesLogic_User_SimCond.dicFldComparisonOp[convgs_KnowledgesLogic_User_Sim.UserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_KnowledgesLogic_User_Sim.UserId, objvgs_KnowledgesLogic_User_SimCond.UserId, strComparisonOpUserId);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--vgs_KnowledgesLogic_User_Sim(v知识点逻辑用户关系_Sim), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:UserId_KnowledgeGraphId_CourseKnowledgeId_id_CurrEduCls
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objvgs_KnowledgesLogic_User_SimEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsvgs_KnowledgesLogic_User_SimEN objvgs_KnowledgesLogic_User_SimEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objvgs_KnowledgesLogic_User_SimEN == null) return true;
if (objvgs_KnowledgesLogic_User_SimEN.mId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and UserId = '{0}'", objvgs_KnowledgesLogic_User_SimEN.UserId);
 if (objvgs_KnowledgesLogic_User_SimEN.KnowledgeGraphId == null)
{
 sbCondition.AppendFormat(" and KnowledgeGraphId is null", objvgs_KnowledgesLogic_User_SimEN.KnowledgeGraphId);
}
else
{
 sbCondition.AppendFormat(" and KnowledgeGraphId = '{0}'", objvgs_KnowledgesLogic_User_SimEN.KnowledgeGraphId);
}
 sbCondition.AppendFormat(" and CourseKnowledgeId = '{0}'", objvgs_KnowledgesLogic_User_SimEN.CourseKnowledgeId);
 if (objvgs_KnowledgesLogic_User_SimEN.IdCurrEduCls == null)
{
 sbCondition.AppendFormat(" and IdCurrEduCls is null", objvgs_KnowledgesLogic_User_SimEN.IdCurrEduCls);
}
else
{
 sbCondition.AppendFormat(" and IdCurrEduCls = '{0}'", objvgs_KnowledgesLogic_User_SimEN.IdCurrEduCls);
}
if (clsvgs_KnowledgesLogic_User_SimBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("mId !=  {0}", objvgs_KnowledgesLogic_User_SimEN.mId);
 sbCondition.AppendFormat(" and UserId = '{0}'", objvgs_KnowledgesLogic_User_SimEN.UserId);
 sbCondition.AppendFormat(" and KnowledgeGraphId = '{0}'", objvgs_KnowledgesLogic_User_SimEN.KnowledgeGraphId);
 sbCondition.AppendFormat(" and CourseKnowledgeId = '{0}'", objvgs_KnowledgesLogic_User_SimEN.CourseKnowledgeId);
 sbCondition.AppendFormat(" and IdCurrEduCls = '{0}'", objvgs_KnowledgesLogic_User_SimEN.IdCurrEduCls);
if (clsvgs_KnowledgesLogic_User_SimBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--vgs_KnowledgesLogic_User_Sim(v知识点逻辑用户关系_Sim), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:UserId_KnowledgeGraphId_CourseKnowledgeId_id_CurrEduCls
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objvgs_KnowledgesLogic_User_SimEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsvgs_KnowledgesLogic_User_SimEN objvgs_KnowledgesLogic_User_SimEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objvgs_KnowledgesLogic_User_SimEN == null) return "";
if (objvgs_KnowledgesLogic_User_SimEN.mId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and UserId = '{0}'", objvgs_KnowledgesLogic_User_SimEN.UserId);
 if (objvgs_KnowledgesLogic_User_SimEN.KnowledgeGraphId == null)
{
 sbCondition.AppendFormat(" and KnowledgeGraphId is null", objvgs_KnowledgesLogic_User_SimEN.KnowledgeGraphId);
}
else
{
 sbCondition.AppendFormat(" and KnowledgeGraphId = '{0}'", objvgs_KnowledgesLogic_User_SimEN.KnowledgeGraphId);
}
 sbCondition.AppendFormat(" and CourseKnowledgeId = '{0}'", objvgs_KnowledgesLogic_User_SimEN.CourseKnowledgeId);
 if (objvgs_KnowledgesLogic_User_SimEN.IdCurrEduCls == null)
{
 sbCondition.AppendFormat(" and IdCurrEduCls is null", objvgs_KnowledgesLogic_User_SimEN.IdCurrEduCls);
}
else
{
 sbCondition.AppendFormat(" and IdCurrEduCls = '{0}'", objvgs_KnowledgesLogic_User_SimEN.IdCurrEduCls);
}
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("mId !=  {0}", objvgs_KnowledgesLogic_User_SimEN.mId);
 sbCondition.AppendFormat(" and UserId = '{0}'", objvgs_KnowledgesLogic_User_SimEN.UserId);
 sbCondition.AppendFormat(" and KnowledgeGraphId = '{0}'", objvgs_KnowledgesLogic_User_SimEN.KnowledgeGraphId);
 sbCondition.AppendFormat(" and CourseKnowledgeId = '{0}'", objvgs_KnowledgesLogic_User_SimEN.CourseKnowledgeId);
 sbCondition.AppendFormat(" and IdCurrEduCls = '{0}'", objvgs_KnowledgesLogic_User_SimEN.IdCurrEduCls);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vgs_KnowledgesLogic_User_Sim
{
public virtual bool UpdRelaTabDate(long lngmId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v知识点逻辑用户关系_Sim(vgs_KnowledgesLogic_User_Sim)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvgs_KnowledgesLogic_User_SimBL
{
public static RelatedActions_vgs_KnowledgesLogic_User_Sim relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvgs_KnowledgesLogic_User_SimDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvgs_KnowledgesLogic_User_SimDA vgs_KnowledgesLogic_User_SimDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvgs_KnowledgesLogic_User_SimDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvgs_KnowledgesLogic_User_SimBL()
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
if (string.IsNullOrEmpty(clsvgs_KnowledgesLogic_User_SimEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvgs_KnowledgesLogic_User_SimEN._ConnectString);
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
public static DataTable GetDataTable_vgs_KnowledgesLogic_User_Sim(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vgs_KnowledgesLogic_User_SimDA.GetDataTable_vgs_KnowledgesLogic_User_Sim(strWhereCond);
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
objDT = vgs_KnowledgesLogic_User_SimDA.GetDataTable(strWhereCond);
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
objDT = vgs_KnowledgesLogic_User_SimDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vgs_KnowledgesLogic_User_SimDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vgs_KnowledgesLogic_User_SimDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vgs_KnowledgesLogic_User_SimDA.GetDataTable_Top(objTopPara);
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
objDT = vgs_KnowledgesLogic_User_SimDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vgs_KnowledgesLogic_User_SimDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vgs_KnowledgesLogic_User_SimDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
public static List<clsvgs_KnowledgesLogic_User_SimEN> GetObjLstByMIdLst(List<long> arrMIdLst)
{
List<clsvgs_KnowledgesLogic_User_SimEN> arrObjLst = new List<clsvgs_KnowledgesLogic_User_SimEN>(); 
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
	clsvgs_KnowledgesLogic_User_SimEN objvgs_KnowledgesLogic_User_SimEN = new clsvgs_KnowledgesLogic_User_SimEN();
try
{
objvgs_KnowledgesLogic_User_SimEN.mId = Int32.Parse(objRow[convgs_KnowledgesLogic_User_Sim.mId].ToString().Trim()); //mId
objvgs_KnowledgesLogic_User_SimEN.CourseKnowledgeId = objRow[convgs_KnowledgesLogic_User_Sim.CourseKnowledgeId].ToString().Trim(); //知识点Id
objvgs_KnowledgesLogic_User_SimEN.KnowledgeGraphId = objRow[convgs_KnowledgesLogic_User_Sim.KnowledgeGraphId] == DBNull.Value ? null : objRow[convgs_KnowledgesLogic_User_Sim.KnowledgeGraphId].ToString().Trim(); //知识点图Id
objvgs_KnowledgesLogic_User_SimEN.ClassName = objRow[convgs_KnowledgesLogic_User_Sim.ClassName] == DBNull.Value ? null : objRow[convgs_KnowledgesLogic_User_Sim.ClassName].ToString().Trim(); //样式名称
objvgs_KnowledgesLogic_User_SimEN.CourseId = objRow[convgs_KnowledgesLogic_User_Sim.CourseId] == DBNull.Value ? null : objRow[convgs_KnowledgesLogic_User_Sim.CourseId].ToString().Trim(); //课程Id
objvgs_KnowledgesLogic_User_SimEN.IdCurrEduCls = objRow[convgs_KnowledgesLogic_User_Sim.IdCurrEduCls] == DBNull.Value ? null : objRow[convgs_KnowledgesLogic_User_Sim.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvgs_KnowledgesLogic_User_SimEN.UserId = objRow[convgs_KnowledgesLogic_User_Sim.UserId].ToString().Trim(); //用户ID
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvgs_KnowledgesLogic_User_SimEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvgs_KnowledgesLogic_User_SimEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrMIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvgs_KnowledgesLogic_User_SimEN> GetObjLstByMIdLstCache(List<long> arrMIdLst)
{
string strKey = string.Format("{0}", clsvgs_KnowledgesLogic_User_SimEN._CurrTabName);
List<clsvgs_KnowledgesLogic_User_SimEN> arrvgs_KnowledgesLogic_User_SimObjLstCache = GetObjLstCache();
IEnumerable <clsvgs_KnowledgesLogic_User_SimEN> arrvgs_KnowledgesLogic_User_SimObjLst_Sel =
arrvgs_KnowledgesLogic_User_SimObjLstCache
.Where(x => arrMIdLst.Contains(x.mId));
return arrvgs_KnowledgesLogic_User_SimObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvgs_KnowledgesLogic_User_SimEN> GetObjLst(string strWhereCond)
{
List<clsvgs_KnowledgesLogic_User_SimEN> arrObjLst = new List<clsvgs_KnowledgesLogic_User_SimEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvgs_KnowledgesLogic_User_SimEN objvgs_KnowledgesLogic_User_SimEN = new clsvgs_KnowledgesLogic_User_SimEN();
try
{
objvgs_KnowledgesLogic_User_SimEN.mId = Int32.Parse(objRow[convgs_KnowledgesLogic_User_Sim.mId].ToString().Trim()); //mId
objvgs_KnowledgesLogic_User_SimEN.CourseKnowledgeId = objRow[convgs_KnowledgesLogic_User_Sim.CourseKnowledgeId].ToString().Trim(); //知识点Id
objvgs_KnowledgesLogic_User_SimEN.KnowledgeGraphId = objRow[convgs_KnowledgesLogic_User_Sim.KnowledgeGraphId] == DBNull.Value ? null : objRow[convgs_KnowledgesLogic_User_Sim.KnowledgeGraphId].ToString().Trim(); //知识点图Id
objvgs_KnowledgesLogic_User_SimEN.ClassName = objRow[convgs_KnowledgesLogic_User_Sim.ClassName] == DBNull.Value ? null : objRow[convgs_KnowledgesLogic_User_Sim.ClassName].ToString().Trim(); //样式名称
objvgs_KnowledgesLogic_User_SimEN.CourseId = objRow[convgs_KnowledgesLogic_User_Sim.CourseId] == DBNull.Value ? null : objRow[convgs_KnowledgesLogic_User_Sim.CourseId].ToString().Trim(); //课程Id
objvgs_KnowledgesLogic_User_SimEN.IdCurrEduCls = objRow[convgs_KnowledgesLogic_User_Sim.IdCurrEduCls] == DBNull.Value ? null : objRow[convgs_KnowledgesLogic_User_Sim.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvgs_KnowledgesLogic_User_SimEN.UserId = objRow[convgs_KnowledgesLogic_User_Sim.UserId].ToString().Trim(); //用户ID
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvgs_KnowledgesLogic_User_SimEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvgs_KnowledgesLogic_User_SimEN);
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
public static List<clsvgs_KnowledgesLogic_User_SimEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvgs_KnowledgesLogic_User_SimEN> arrObjLst = new List<clsvgs_KnowledgesLogic_User_SimEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvgs_KnowledgesLogic_User_SimEN objvgs_KnowledgesLogic_User_SimEN = new clsvgs_KnowledgesLogic_User_SimEN();
try
{
objvgs_KnowledgesLogic_User_SimEN.mId = Int32.Parse(objRow[convgs_KnowledgesLogic_User_Sim.mId].ToString().Trim()); //mId
objvgs_KnowledgesLogic_User_SimEN.CourseKnowledgeId = objRow[convgs_KnowledgesLogic_User_Sim.CourseKnowledgeId].ToString().Trim(); //知识点Id
objvgs_KnowledgesLogic_User_SimEN.KnowledgeGraphId = objRow[convgs_KnowledgesLogic_User_Sim.KnowledgeGraphId] == DBNull.Value ? null : objRow[convgs_KnowledgesLogic_User_Sim.KnowledgeGraphId].ToString().Trim(); //知识点图Id
objvgs_KnowledgesLogic_User_SimEN.ClassName = objRow[convgs_KnowledgesLogic_User_Sim.ClassName] == DBNull.Value ? null : objRow[convgs_KnowledgesLogic_User_Sim.ClassName].ToString().Trim(); //样式名称
objvgs_KnowledgesLogic_User_SimEN.CourseId = objRow[convgs_KnowledgesLogic_User_Sim.CourseId] == DBNull.Value ? null : objRow[convgs_KnowledgesLogic_User_Sim.CourseId].ToString().Trim(); //课程Id
objvgs_KnowledgesLogic_User_SimEN.IdCurrEduCls = objRow[convgs_KnowledgesLogic_User_Sim.IdCurrEduCls] == DBNull.Value ? null : objRow[convgs_KnowledgesLogic_User_Sim.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvgs_KnowledgesLogic_User_SimEN.UserId = objRow[convgs_KnowledgesLogic_User_Sim.UserId].ToString().Trim(); //用户ID
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvgs_KnowledgesLogic_User_SimEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvgs_KnowledgesLogic_User_SimEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvgs_KnowledgesLogic_User_SimCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvgs_KnowledgesLogic_User_SimEN> GetSubObjLstCache(clsvgs_KnowledgesLogic_User_SimEN objvgs_KnowledgesLogic_User_SimCond)
{
List<clsvgs_KnowledgesLogic_User_SimEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvgs_KnowledgesLogic_User_SimEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convgs_KnowledgesLogic_User_Sim.AttributeName)
{
if (objvgs_KnowledgesLogic_User_SimCond.IsUpdated(strFldName) == false) continue;
if (objvgs_KnowledgesLogic_User_SimCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvgs_KnowledgesLogic_User_SimCond[strFldName].ToString());
}
else
{
if (objvgs_KnowledgesLogic_User_SimCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvgs_KnowledgesLogic_User_SimCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvgs_KnowledgesLogic_User_SimCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvgs_KnowledgesLogic_User_SimCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvgs_KnowledgesLogic_User_SimCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvgs_KnowledgesLogic_User_SimCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvgs_KnowledgesLogic_User_SimCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvgs_KnowledgesLogic_User_SimCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvgs_KnowledgesLogic_User_SimCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvgs_KnowledgesLogic_User_SimCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvgs_KnowledgesLogic_User_SimCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvgs_KnowledgesLogic_User_SimCond[strFldName]));
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
public static List<clsvgs_KnowledgesLogic_User_SimEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvgs_KnowledgesLogic_User_SimEN> arrObjLst = new List<clsvgs_KnowledgesLogic_User_SimEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvgs_KnowledgesLogic_User_SimEN objvgs_KnowledgesLogic_User_SimEN = new clsvgs_KnowledgesLogic_User_SimEN();
try
{
objvgs_KnowledgesLogic_User_SimEN.mId = Int32.Parse(objRow[convgs_KnowledgesLogic_User_Sim.mId].ToString().Trim()); //mId
objvgs_KnowledgesLogic_User_SimEN.CourseKnowledgeId = objRow[convgs_KnowledgesLogic_User_Sim.CourseKnowledgeId].ToString().Trim(); //知识点Id
objvgs_KnowledgesLogic_User_SimEN.KnowledgeGraphId = objRow[convgs_KnowledgesLogic_User_Sim.KnowledgeGraphId] == DBNull.Value ? null : objRow[convgs_KnowledgesLogic_User_Sim.KnowledgeGraphId].ToString().Trim(); //知识点图Id
objvgs_KnowledgesLogic_User_SimEN.ClassName = objRow[convgs_KnowledgesLogic_User_Sim.ClassName] == DBNull.Value ? null : objRow[convgs_KnowledgesLogic_User_Sim.ClassName].ToString().Trim(); //样式名称
objvgs_KnowledgesLogic_User_SimEN.CourseId = objRow[convgs_KnowledgesLogic_User_Sim.CourseId] == DBNull.Value ? null : objRow[convgs_KnowledgesLogic_User_Sim.CourseId].ToString().Trim(); //课程Id
objvgs_KnowledgesLogic_User_SimEN.IdCurrEduCls = objRow[convgs_KnowledgesLogic_User_Sim.IdCurrEduCls] == DBNull.Value ? null : objRow[convgs_KnowledgesLogic_User_Sim.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvgs_KnowledgesLogic_User_SimEN.UserId = objRow[convgs_KnowledgesLogic_User_Sim.UserId].ToString().Trim(); //用户ID
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvgs_KnowledgesLogic_User_SimEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvgs_KnowledgesLogic_User_SimEN);
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
public static List<clsvgs_KnowledgesLogic_User_SimEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvgs_KnowledgesLogic_User_SimEN> arrObjLst = new List<clsvgs_KnowledgesLogic_User_SimEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvgs_KnowledgesLogic_User_SimEN objvgs_KnowledgesLogic_User_SimEN = new clsvgs_KnowledgesLogic_User_SimEN();
try
{
objvgs_KnowledgesLogic_User_SimEN.mId = Int32.Parse(objRow[convgs_KnowledgesLogic_User_Sim.mId].ToString().Trim()); //mId
objvgs_KnowledgesLogic_User_SimEN.CourseKnowledgeId = objRow[convgs_KnowledgesLogic_User_Sim.CourseKnowledgeId].ToString().Trim(); //知识点Id
objvgs_KnowledgesLogic_User_SimEN.KnowledgeGraphId = objRow[convgs_KnowledgesLogic_User_Sim.KnowledgeGraphId] == DBNull.Value ? null : objRow[convgs_KnowledgesLogic_User_Sim.KnowledgeGraphId].ToString().Trim(); //知识点图Id
objvgs_KnowledgesLogic_User_SimEN.ClassName = objRow[convgs_KnowledgesLogic_User_Sim.ClassName] == DBNull.Value ? null : objRow[convgs_KnowledgesLogic_User_Sim.ClassName].ToString().Trim(); //样式名称
objvgs_KnowledgesLogic_User_SimEN.CourseId = objRow[convgs_KnowledgesLogic_User_Sim.CourseId] == DBNull.Value ? null : objRow[convgs_KnowledgesLogic_User_Sim.CourseId].ToString().Trim(); //课程Id
objvgs_KnowledgesLogic_User_SimEN.IdCurrEduCls = objRow[convgs_KnowledgesLogic_User_Sim.IdCurrEduCls] == DBNull.Value ? null : objRow[convgs_KnowledgesLogic_User_Sim.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvgs_KnowledgesLogic_User_SimEN.UserId = objRow[convgs_KnowledgesLogic_User_Sim.UserId].ToString().Trim(); //用户ID
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvgs_KnowledgesLogic_User_SimEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvgs_KnowledgesLogic_User_SimEN);
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
List<clsvgs_KnowledgesLogic_User_SimEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvgs_KnowledgesLogic_User_SimEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvgs_KnowledgesLogic_User_SimEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvgs_KnowledgesLogic_User_SimEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvgs_KnowledgesLogic_User_SimEN> arrObjLst = new List<clsvgs_KnowledgesLogic_User_SimEN>(); 
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
	clsvgs_KnowledgesLogic_User_SimEN objvgs_KnowledgesLogic_User_SimEN = new clsvgs_KnowledgesLogic_User_SimEN();
try
{
objvgs_KnowledgesLogic_User_SimEN.mId = Int32.Parse(objRow[convgs_KnowledgesLogic_User_Sim.mId].ToString().Trim()); //mId
objvgs_KnowledgesLogic_User_SimEN.CourseKnowledgeId = objRow[convgs_KnowledgesLogic_User_Sim.CourseKnowledgeId].ToString().Trim(); //知识点Id
objvgs_KnowledgesLogic_User_SimEN.KnowledgeGraphId = objRow[convgs_KnowledgesLogic_User_Sim.KnowledgeGraphId] == DBNull.Value ? null : objRow[convgs_KnowledgesLogic_User_Sim.KnowledgeGraphId].ToString().Trim(); //知识点图Id
objvgs_KnowledgesLogic_User_SimEN.ClassName = objRow[convgs_KnowledgesLogic_User_Sim.ClassName] == DBNull.Value ? null : objRow[convgs_KnowledgesLogic_User_Sim.ClassName].ToString().Trim(); //样式名称
objvgs_KnowledgesLogic_User_SimEN.CourseId = objRow[convgs_KnowledgesLogic_User_Sim.CourseId] == DBNull.Value ? null : objRow[convgs_KnowledgesLogic_User_Sim.CourseId].ToString().Trim(); //课程Id
objvgs_KnowledgesLogic_User_SimEN.IdCurrEduCls = objRow[convgs_KnowledgesLogic_User_Sim.IdCurrEduCls] == DBNull.Value ? null : objRow[convgs_KnowledgesLogic_User_Sim.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvgs_KnowledgesLogic_User_SimEN.UserId = objRow[convgs_KnowledgesLogic_User_Sim.UserId].ToString().Trim(); //用户ID
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvgs_KnowledgesLogic_User_SimEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvgs_KnowledgesLogic_User_SimEN);
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
public static List<clsvgs_KnowledgesLogic_User_SimEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvgs_KnowledgesLogic_User_SimEN> arrObjLst = new List<clsvgs_KnowledgesLogic_User_SimEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvgs_KnowledgesLogic_User_SimEN objvgs_KnowledgesLogic_User_SimEN = new clsvgs_KnowledgesLogic_User_SimEN();
try
{
objvgs_KnowledgesLogic_User_SimEN.mId = Int32.Parse(objRow[convgs_KnowledgesLogic_User_Sim.mId].ToString().Trim()); //mId
objvgs_KnowledgesLogic_User_SimEN.CourseKnowledgeId = objRow[convgs_KnowledgesLogic_User_Sim.CourseKnowledgeId].ToString().Trim(); //知识点Id
objvgs_KnowledgesLogic_User_SimEN.KnowledgeGraphId = objRow[convgs_KnowledgesLogic_User_Sim.KnowledgeGraphId] == DBNull.Value ? null : objRow[convgs_KnowledgesLogic_User_Sim.KnowledgeGraphId].ToString().Trim(); //知识点图Id
objvgs_KnowledgesLogic_User_SimEN.ClassName = objRow[convgs_KnowledgesLogic_User_Sim.ClassName] == DBNull.Value ? null : objRow[convgs_KnowledgesLogic_User_Sim.ClassName].ToString().Trim(); //样式名称
objvgs_KnowledgesLogic_User_SimEN.CourseId = objRow[convgs_KnowledgesLogic_User_Sim.CourseId] == DBNull.Value ? null : objRow[convgs_KnowledgesLogic_User_Sim.CourseId].ToString().Trim(); //课程Id
objvgs_KnowledgesLogic_User_SimEN.IdCurrEduCls = objRow[convgs_KnowledgesLogic_User_Sim.IdCurrEduCls] == DBNull.Value ? null : objRow[convgs_KnowledgesLogic_User_Sim.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvgs_KnowledgesLogic_User_SimEN.UserId = objRow[convgs_KnowledgesLogic_User_Sim.UserId].ToString().Trim(); //用户ID
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvgs_KnowledgesLogic_User_SimEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvgs_KnowledgesLogic_User_SimEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvgs_KnowledgesLogic_User_SimEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvgs_KnowledgesLogic_User_SimEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvgs_KnowledgesLogic_User_SimEN> arrObjLst = new List<clsvgs_KnowledgesLogic_User_SimEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvgs_KnowledgesLogic_User_SimEN objvgs_KnowledgesLogic_User_SimEN = new clsvgs_KnowledgesLogic_User_SimEN();
try
{
objvgs_KnowledgesLogic_User_SimEN.mId = Int32.Parse(objRow[convgs_KnowledgesLogic_User_Sim.mId].ToString().Trim()); //mId
objvgs_KnowledgesLogic_User_SimEN.CourseKnowledgeId = objRow[convgs_KnowledgesLogic_User_Sim.CourseKnowledgeId].ToString().Trim(); //知识点Id
objvgs_KnowledgesLogic_User_SimEN.KnowledgeGraphId = objRow[convgs_KnowledgesLogic_User_Sim.KnowledgeGraphId] == DBNull.Value ? null : objRow[convgs_KnowledgesLogic_User_Sim.KnowledgeGraphId].ToString().Trim(); //知识点图Id
objvgs_KnowledgesLogic_User_SimEN.ClassName = objRow[convgs_KnowledgesLogic_User_Sim.ClassName] == DBNull.Value ? null : objRow[convgs_KnowledgesLogic_User_Sim.ClassName].ToString().Trim(); //样式名称
objvgs_KnowledgesLogic_User_SimEN.CourseId = objRow[convgs_KnowledgesLogic_User_Sim.CourseId] == DBNull.Value ? null : objRow[convgs_KnowledgesLogic_User_Sim.CourseId].ToString().Trim(); //课程Id
objvgs_KnowledgesLogic_User_SimEN.IdCurrEduCls = objRow[convgs_KnowledgesLogic_User_Sim.IdCurrEduCls] == DBNull.Value ? null : objRow[convgs_KnowledgesLogic_User_Sim.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvgs_KnowledgesLogic_User_SimEN.UserId = objRow[convgs_KnowledgesLogic_User_Sim.UserId].ToString().Trim(); //用户ID
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvgs_KnowledgesLogic_User_SimEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvgs_KnowledgesLogic_User_SimEN);
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
public static List<clsvgs_KnowledgesLogic_User_SimEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvgs_KnowledgesLogic_User_SimEN> arrObjLst = new List<clsvgs_KnowledgesLogic_User_SimEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvgs_KnowledgesLogic_User_SimEN objvgs_KnowledgesLogic_User_SimEN = new clsvgs_KnowledgesLogic_User_SimEN();
try
{
objvgs_KnowledgesLogic_User_SimEN.mId = Int32.Parse(objRow[convgs_KnowledgesLogic_User_Sim.mId].ToString().Trim()); //mId
objvgs_KnowledgesLogic_User_SimEN.CourseKnowledgeId = objRow[convgs_KnowledgesLogic_User_Sim.CourseKnowledgeId].ToString().Trim(); //知识点Id
objvgs_KnowledgesLogic_User_SimEN.KnowledgeGraphId = objRow[convgs_KnowledgesLogic_User_Sim.KnowledgeGraphId] == DBNull.Value ? null : objRow[convgs_KnowledgesLogic_User_Sim.KnowledgeGraphId].ToString().Trim(); //知识点图Id
objvgs_KnowledgesLogic_User_SimEN.ClassName = objRow[convgs_KnowledgesLogic_User_Sim.ClassName] == DBNull.Value ? null : objRow[convgs_KnowledgesLogic_User_Sim.ClassName].ToString().Trim(); //样式名称
objvgs_KnowledgesLogic_User_SimEN.CourseId = objRow[convgs_KnowledgesLogic_User_Sim.CourseId] == DBNull.Value ? null : objRow[convgs_KnowledgesLogic_User_Sim.CourseId].ToString().Trim(); //课程Id
objvgs_KnowledgesLogic_User_SimEN.IdCurrEduCls = objRow[convgs_KnowledgesLogic_User_Sim.IdCurrEduCls] == DBNull.Value ? null : objRow[convgs_KnowledgesLogic_User_Sim.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvgs_KnowledgesLogic_User_SimEN.UserId = objRow[convgs_KnowledgesLogic_User_Sim.UserId].ToString().Trim(); //用户ID
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvgs_KnowledgesLogic_User_SimEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvgs_KnowledgesLogic_User_SimEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvgs_KnowledgesLogic_User_SimEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvgs_KnowledgesLogic_User_SimEN> arrObjLst = new List<clsvgs_KnowledgesLogic_User_SimEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvgs_KnowledgesLogic_User_SimEN objvgs_KnowledgesLogic_User_SimEN = new clsvgs_KnowledgesLogic_User_SimEN();
try
{
objvgs_KnowledgesLogic_User_SimEN.mId = Int32.Parse(objRow[convgs_KnowledgesLogic_User_Sim.mId].ToString().Trim()); //mId
objvgs_KnowledgesLogic_User_SimEN.CourseKnowledgeId = objRow[convgs_KnowledgesLogic_User_Sim.CourseKnowledgeId].ToString().Trim(); //知识点Id
objvgs_KnowledgesLogic_User_SimEN.KnowledgeGraphId = objRow[convgs_KnowledgesLogic_User_Sim.KnowledgeGraphId] == DBNull.Value ? null : objRow[convgs_KnowledgesLogic_User_Sim.KnowledgeGraphId].ToString().Trim(); //知识点图Id
objvgs_KnowledgesLogic_User_SimEN.ClassName = objRow[convgs_KnowledgesLogic_User_Sim.ClassName] == DBNull.Value ? null : objRow[convgs_KnowledgesLogic_User_Sim.ClassName].ToString().Trim(); //样式名称
objvgs_KnowledgesLogic_User_SimEN.CourseId = objRow[convgs_KnowledgesLogic_User_Sim.CourseId] == DBNull.Value ? null : objRow[convgs_KnowledgesLogic_User_Sim.CourseId].ToString().Trim(); //课程Id
objvgs_KnowledgesLogic_User_SimEN.IdCurrEduCls = objRow[convgs_KnowledgesLogic_User_Sim.IdCurrEduCls] == DBNull.Value ? null : objRow[convgs_KnowledgesLogic_User_Sim.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvgs_KnowledgesLogic_User_SimEN.UserId = objRow[convgs_KnowledgesLogic_User_Sim.UserId].ToString().Trim(); //用户ID
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvgs_KnowledgesLogic_User_SimEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvgs_KnowledgesLogic_User_SimEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvgs_KnowledgesLogic_User_SimEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool Getvgs_KnowledgesLogic_User_Sim(ref clsvgs_KnowledgesLogic_User_SimEN objvgs_KnowledgesLogic_User_SimEN)
{
bool bolResult = vgs_KnowledgesLogic_User_SimDA.Getvgs_KnowledgesLogic_User_Sim(ref objvgs_KnowledgesLogic_User_SimEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvgs_KnowledgesLogic_User_SimEN GetObjBymId(long lngmId)
{
clsvgs_KnowledgesLogic_User_SimEN objvgs_KnowledgesLogic_User_SimEN = vgs_KnowledgesLogic_User_SimDA.GetObjBymId(lngmId);
return objvgs_KnowledgesLogic_User_SimEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvgs_KnowledgesLogic_User_SimEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvgs_KnowledgesLogic_User_SimEN objvgs_KnowledgesLogic_User_SimEN = vgs_KnowledgesLogic_User_SimDA.GetFirstObj(strWhereCond);
 return objvgs_KnowledgesLogic_User_SimEN;
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
public static clsvgs_KnowledgesLogic_User_SimEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvgs_KnowledgesLogic_User_SimEN objvgs_KnowledgesLogic_User_SimEN = vgs_KnowledgesLogic_User_SimDA.GetObjByDataRow(objRow);
 return objvgs_KnowledgesLogic_User_SimEN;
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
public static clsvgs_KnowledgesLogic_User_SimEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvgs_KnowledgesLogic_User_SimEN objvgs_KnowledgesLogic_User_SimEN = vgs_KnowledgesLogic_User_SimDA.GetObjByDataRow(objRow);
 return objvgs_KnowledgesLogic_User_SimEN;
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
 /// <param name = "lstvgs_KnowledgesLogic_User_SimObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvgs_KnowledgesLogic_User_SimEN GetObjBymIdFromList(long lngmId, List<clsvgs_KnowledgesLogic_User_SimEN> lstvgs_KnowledgesLogic_User_SimObjLst)
{
foreach (clsvgs_KnowledgesLogic_User_SimEN objvgs_KnowledgesLogic_User_SimEN in lstvgs_KnowledgesLogic_User_SimObjLst)
{
if (objvgs_KnowledgesLogic_User_SimEN.mId == lngmId)
{
return objvgs_KnowledgesLogic_User_SimEN;
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
 lngmId = new clsvgs_KnowledgesLogic_User_SimDA().GetFirstID(strWhereCond);
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
 arrList = vgs_KnowledgesLogic_User_SimDA.GetID(strWhereCond);
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
bool bolIsExist = vgs_KnowledgesLogic_User_SimDA.IsExistCondRec(strWhereCond);
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
bool bolIsExist = vgs_KnowledgesLogic_User_SimDA.IsExist(lngmId);
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
 bolIsExist = clsvgs_KnowledgesLogic_User_SimDA.IsExistTable();
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
 bolIsExist = vgs_KnowledgesLogic_User_SimDA.IsExistTable(strTabName);
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
 /// <param name = "objvgs_KnowledgesLogic_User_SimENS">源对象</param>
 /// <param name = "objvgs_KnowledgesLogic_User_SimENT">目标对象</param>
 public static void CopyTo(clsvgs_KnowledgesLogic_User_SimEN objvgs_KnowledgesLogic_User_SimENS, clsvgs_KnowledgesLogic_User_SimEN objvgs_KnowledgesLogic_User_SimENT)
{
try
{
objvgs_KnowledgesLogic_User_SimENT.mId = objvgs_KnowledgesLogic_User_SimENS.mId; //mId
objvgs_KnowledgesLogic_User_SimENT.CourseKnowledgeId = objvgs_KnowledgesLogic_User_SimENS.CourseKnowledgeId; //知识点Id
objvgs_KnowledgesLogic_User_SimENT.KnowledgeGraphId = objvgs_KnowledgesLogic_User_SimENS.KnowledgeGraphId; //知识点图Id
objvgs_KnowledgesLogic_User_SimENT.ClassName = objvgs_KnowledgesLogic_User_SimENS.ClassName; //样式名称
objvgs_KnowledgesLogic_User_SimENT.CourseId = objvgs_KnowledgesLogic_User_SimENS.CourseId; //课程Id
objvgs_KnowledgesLogic_User_SimENT.IdCurrEduCls = objvgs_KnowledgesLogic_User_SimENS.IdCurrEduCls; //教学班流水号
objvgs_KnowledgesLogic_User_SimENT.UserId = objvgs_KnowledgesLogic_User_SimENS.UserId; //用户ID
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
 /// <param name = "objvgs_KnowledgesLogic_User_SimEN">源简化对象</param>
 public static void SetUpdFlag(clsvgs_KnowledgesLogic_User_SimEN objvgs_KnowledgesLogic_User_SimEN)
{
try
{
objvgs_KnowledgesLogic_User_SimEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvgs_KnowledgesLogic_User_SimEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convgs_KnowledgesLogic_User_Sim.mId, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_KnowledgesLogic_User_SimEN.mId = objvgs_KnowledgesLogic_User_SimEN.mId; //mId
}
if (arrFldSet.Contains(convgs_KnowledgesLogic_User_Sim.CourseKnowledgeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_KnowledgesLogic_User_SimEN.CourseKnowledgeId = objvgs_KnowledgesLogic_User_SimEN.CourseKnowledgeId; //知识点Id
}
if (arrFldSet.Contains(convgs_KnowledgesLogic_User_Sim.KnowledgeGraphId, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_KnowledgesLogic_User_SimEN.KnowledgeGraphId = objvgs_KnowledgesLogic_User_SimEN.KnowledgeGraphId == "[null]" ? null :  objvgs_KnowledgesLogic_User_SimEN.KnowledgeGraphId; //知识点图Id
}
if (arrFldSet.Contains(convgs_KnowledgesLogic_User_Sim.ClassName, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_KnowledgesLogic_User_SimEN.ClassName = objvgs_KnowledgesLogic_User_SimEN.ClassName == "[null]" ? null :  objvgs_KnowledgesLogic_User_SimEN.ClassName; //样式名称
}
if (arrFldSet.Contains(convgs_KnowledgesLogic_User_Sim.CourseId, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_KnowledgesLogic_User_SimEN.CourseId = objvgs_KnowledgesLogic_User_SimEN.CourseId == "[null]" ? null :  objvgs_KnowledgesLogic_User_SimEN.CourseId; //课程Id
}
if (arrFldSet.Contains(convgs_KnowledgesLogic_User_Sim.IdCurrEduCls, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_KnowledgesLogic_User_SimEN.IdCurrEduCls = objvgs_KnowledgesLogic_User_SimEN.IdCurrEduCls == "[null]" ? null :  objvgs_KnowledgesLogic_User_SimEN.IdCurrEduCls; //教学班流水号
}
if (arrFldSet.Contains(convgs_KnowledgesLogic_User_Sim.UserId, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_KnowledgesLogic_User_SimEN.UserId = objvgs_KnowledgesLogic_User_SimEN.UserId; //用户ID
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
 /// <param name = "objvgs_KnowledgesLogic_User_SimEN">源简化对象</param>
 public static void AccessFldValueNull(clsvgs_KnowledgesLogic_User_SimEN objvgs_KnowledgesLogic_User_SimEN)
{
try
{
if (objvgs_KnowledgesLogic_User_SimEN.KnowledgeGraphId == "[null]") objvgs_KnowledgesLogic_User_SimEN.KnowledgeGraphId = null; //知识点图Id
if (objvgs_KnowledgesLogic_User_SimEN.ClassName == "[null]") objvgs_KnowledgesLogic_User_SimEN.ClassName = null; //样式名称
if (objvgs_KnowledgesLogic_User_SimEN.CourseId == "[null]") objvgs_KnowledgesLogic_User_SimEN.CourseId = null; //课程Id
if (objvgs_KnowledgesLogic_User_SimEN.IdCurrEduCls == "[null]") objvgs_KnowledgesLogic_User_SimEN.IdCurrEduCls = null; //教学班流水号
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
public static void CheckProperty4Condition(clsvgs_KnowledgesLogic_User_SimEN objvgs_KnowledgesLogic_User_SimEN)
{
 vgs_KnowledgesLogic_User_SimDA.CheckProperty4Condition(objvgs_KnowledgesLogic_User_SimEN);
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
if (clsgs_KnowledgesGraphBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsgs_KnowledgesGraphBL没有刷新缓存机制(clsgs_KnowledgesGraphBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsgs_KnowledgesLogic_UserBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsgs_KnowledgesLogic_UserBL没有刷新缓存机制(clsgs_KnowledgesLogic_UserBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by mId");
//if (arrvgs_KnowledgesLogic_User_SimObjLstCache == null)
//{
//arrvgs_KnowledgesLogic_User_SimObjLstCache = vgs_KnowledgesLogic_User_SimDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngmId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvgs_KnowledgesLogic_User_SimEN GetObjBymIdCache(long lngmId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvgs_KnowledgesLogic_User_SimEN._CurrTabName);
List<clsvgs_KnowledgesLogic_User_SimEN> arrvgs_KnowledgesLogic_User_SimObjLstCache = GetObjLstCache();
IEnumerable <clsvgs_KnowledgesLogic_User_SimEN> arrvgs_KnowledgesLogic_User_SimObjLst_Sel =
arrvgs_KnowledgesLogic_User_SimObjLstCache
.Where(x=> x.mId == lngmId 
);
if (arrvgs_KnowledgesLogic_User_SimObjLst_Sel.Count() == 0)
{
   clsvgs_KnowledgesLogic_User_SimEN obj = clsvgs_KnowledgesLogic_User_SimBL.GetObjBymId(lngmId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvgs_KnowledgesLogic_User_SimObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvgs_KnowledgesLogic_User_SimEN> GetAllvgs_KnowledgesLogic_User_SimObjLstCache()
{
//获取缓存中的对象列表
List<clsvgs_KnowledgesLogic_User_SimEN> arrvgs_KnowledgesLogic_User_SimObjLstCache = GetObjLstCache(); 
return arrvgs_KnowledgesLogic_User_SimObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvgs_KnowledgesLogic_User_SimEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvgs_KnowledgesLogic_User_SimEN._CurrTabName);
List<clsvgs_KnowledgesLogic_User_SimEN> arrvgs_KnowledgesLogic_User_SimObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvgs_KnowledgesLogic_User_SimObjLstCache;
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
string strKey = string.Format("{0}", clsvgs_KnowledgesLogic_User_SimEN._CurrTabName);
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
 /// 获取检查唯一性条件串(Uniqueness)--vgs_KnowledgesLogic_User_Sim(v知识点逻辑用户关系_Sim)
 /// 唯一性条件:UserId_KnowledgeGraphId_CourseKnowledgeId_id_CurrEduCls
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objvgs_KnowledgesLogic_User_SimEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsvgs_KnowledgesLogic_User_SimEN objvgs_KnowledgesLogic_User_SimEN)
{
//检测记录是否存在
string strResult = vgs_KnowledgesLogic_User_SimDA.GetUniCondStr(objvgs_KnowledgesLogic_User_SimEN);
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
if (strInFldName != convgs_KnowledgesLogic_User_Sim.mId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convgs_KnowledgesLogic_User_Sim.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convgs_KnowledgesLogic_User_Sim.AttributeName));
throw new Exception(strMsg);
}
var objvgs_KnowledgesLogic_User_Sim = clsvgs_KnowledgesLogic_User_SimBL.GetObjBymIdCache(lngmId);
if (objvgs_KnowledgesLogic_User_Sim == null) return "";
return objvgs_KnowledgesLogic_User_Sim[strOutFldName].ToString();
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
int intRecCount = clsvgs_KnowledgesLogic_User_SimDA.GetRecCount(strTabName);
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
int intRecCount = clsvgs_KnowledgesLogic_User_SimDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvgs_KnowledgesLogic_User_SimDA.GetRecCount();
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
int intRecCount = clsvgs_KnowledgesLogic_User_SimDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvgs_KnowledgesLogic_User_SimCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvgs_KnowledgesLogic_User_SimEN objvgs_KnowledgesLogic_User_SimCond)
{
List<clsvgs_KnowledgesLogic_User_SimEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvgs_KnowledgesLogic_User_SimEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convgs_KnowledgesLogic_User_Sim.AttributeName)
{
if (objvgs_KnowledgesLogic_User_SimCond.IsUpdated(strFldName) == false) continue;
if (objvgs_KnowledgesLogic_User_SimCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvgs_KnowledgesLogic_User_SimCond[strFldName].ToString());
}
else
{
if (objvgs_KnowledgesLogic_User_SimCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvgs_KnowledgesLogic_User_SimCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvgs_KnowledgesLogic_User_SimCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvgs_KnowledgesLogic_User_SimCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvgs_KnowledgesLogic_User_SimCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvgs_KnowledgesLogic_User_SimCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvgs_KnowledgesLogic_User_SimCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvgs_KnowledgesLogic_User_SimCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvgs_KnowledgesLogic_User_SimCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvgs_KnowledgesLogic_User_SimCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvgs_KnowledgesLogic_User_SimCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvgs_KnowledgesLogic_User_SimCond[strFldName]));
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
 List<string> arrList = clsvgs_KnowledgesLogic_User_SimDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vgs_KnowledgesLogic_User_SimDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vgs_KnowledgesLogic_User_SimDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}