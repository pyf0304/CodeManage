﻿
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvCurrEduCls_SimBL
 表名:vCurrEduCls_Sim(01120951)
 * 版本:2023.10.12.1(服务器:WIN-SRV103-116)
 日期:2023/10/28 09:48:39
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:日常运行(DailyRunning)
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
public static class  clsvCurrEduCls_SimBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strIdCurrEduCls">表关键字</param>
 /// <returns>表对象</returns>
public static clsvCurrEduCls_SimEN GetObj(this K_IdCurrEduCls_vCurrEduCls_Sim myKey)
{
clsvCurrEduCls_SimEN objvCurrEduCls_SimEN = clsvCurrEduCls_SimBL.vCurrEduCls_SimDA.GetObjByIdCurrEduCls(myKey.Value);
return objvCurrEduCls_SimEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduCls_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCurrEduCls_SimEN SetIdCurrEduCls(this clsvCurrEduCls_SimEN objvCurrEduCls_SimEN, string strIdCurrEduCls, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdCurrEduCls, 8, convCurrEduCls_Sim.IdCurrEduCls);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdCurrEduCls, 8, convCurrEduCls_Sim.IdCurrEduCls);
}
objvCurrEduCls_SimEN.IdCurrEduCls = strIdCurrEduCls; //教学班流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduCls_SimEN.dicFldComparisonOp.ContainsKey(convCurrEduCls_Sim.IdCurrEduCls) == false)
{
objvCurrEduCls_SimEN.dicFldComparisonOp.Add(convCurrEduCls_Sim.IdCurrEduCls, strComparisonOp);
}
else
{
objvCurrEduCls_SimEN.dicFldComparisonOp[convCurrEduCls_Sim.IdCurrEduCls] = strComparisonOp;
}
}
return objvCurrEduCls_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduCls_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCurrEduCls_SimEN SetCurrEduClsId(this clsvCurrEduCls_SimEN objvCurrEduCls_SimEN, string strCurrEduClsId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCurrEduClsId, 15, convCurrEduCls_Sim.CurrEduClsId);
}
objvCurrEduCls_SimEN.CurrEduClsId = strCurrEduClsId; //教学班Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduCls_SimEN.dicFldComparisonOp.ContainsKey(convCurrEduCls_Sim.CurrEduClsId) == false)
{
objvCurrEduCls_SimEN.dicFldComparisonOp.Add(convCurrEduCls_Sim.CurrEduClsId, strComparisonOp);
}
else
{
objvCurrEduCls_SimEN.dicFldComparisonOp[convCurrEduCls_Sim.CurrEduClsId] = strComparisonOp;
}
}
return objvCurrEduCls_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduCls_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCurrEduCls_SimEN SetEduClsName(this clsvCurrEduCls_SimEN objvCurrEduCls_SimEN, string strEduClsName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strEduClsName, convCurrEduCls_Sim.EduClsName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strEduClsName, 100, convCurrEduCls_Sim.EduClsName);
}
objvCurrEduCls_SimEN.EduClsName = strEduClsName; //教学班名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduCls_SimEN.dicFldComparisonOp.ContainsKey(convCurrEduCls_Sim.EduClsName) == false)
{
objvCurrEduCls_SimEN.dicFldComparisonOp.Add(convCurrEduCls_Sim.EduClsName, strComparisonOp);
}
else
{
objvCurrEduCls_SimEN.dicFldComparisonOp[convCurrEduCls_Sim.EduClsName] = strComparisonOp;
}
}
return objvCurrEduCls_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduCls_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCurrEduCls_SimEN SetEduClsTypeId(this clsvCurrEduCls_SimEN objvCurrEduCls_SimEN, string strEduClsTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strEduClsTypeId, convCurrEduCls_Sim.EduClsTypeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strEduClsTypeId, 4, convCurrEduCls_Sim.EduClsTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strEduClsTypeId, 4, convCurrEduCls_Sim.EduClsTypeId);
}
objvCurrEduCls_SimEN.EduClsTypeId = strEduClsTypeId; //教学班类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduCls_SimEN.dicFldComparisonOp.ContainsKey(convCurrEduCls_Sim.EduClsTypeId) == false)
{
objvCurrEduCls_SimEN.dicFldComparisonOp.Add(convCurrEduCls_Sim.EduClsTypeId, strComparisonOp);
}
else
{
objvCurrEduCls_SimEN.dicFldComparisonOp[convCurrEduCls_Sim.EduClsTypeId] = strComparisonOp;
}
}
return objvCurrEduCls_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduCls_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCurrEduCls_SimEN SetCourseId(this clsvCurrEduCls_SimEN objvCurrEduCls_SimEN, string strCourseId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseId, 8, convCurrEduCls_Sim.CourseId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCourseId, 8, convCurrEduCls_Sim.CourseId);
}
objvCurrEduCls_SimEN.CourseId = strCourseId; //课程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduCls_SimEN.dicFldComparisonOp.ContainsKey(convCurrEduCls_Sim.CourseId) == false)
{
objvCurrEduCls_SimEN.dicFldComparisonOp.Add(convCurrEduCls_Sim.CourseId, strComparisonOp);
}
else
{
objvCurrEduCls_SimEN.dicFldComparisonOp[convCurrEduCls_Sim.CourseId] = strComparisonOp;
}
}
return objvCurrEduCls_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduCls_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCurrEduCls_SimEN SetIdXzCollege(this clsvCurrEduCls_SimEN objvCurrEduCls_SimEN, string strIdXzCollege, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdXzCollege, 4, convCurrEduCls_Sim.IdXzCollege);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdXzCollege, 4, convCurrEduCls_Sim.IdXzCollege);
}
objvCurrEduCls_SimEN.IdXzCollege = strIdXzCollege; //学院流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduCls_SimEN.dicFldComparisonOp.ContainsKey(convCurrEduCls_Sim.IdXzCollege) == false)
{
objvCurrEduCls_SimEN.dicFldComparisonOp.Add(convCurrEduCls_Sim.IdXzCollege, strComparisonOp);
}
else
{
objvCurrEduCls_SimEN.dicFldComparisonOp[convCurrEduCls_Sim.IdXzCollege] = strComparisonOp;
}
}
return objvCurrEduCls_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduCls_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCurrEduCls_SimEN SetIdXzMajor(this clsvCurrEduCls_SimEN objvCurrEduCls_SimEN, string strIdXzMajor, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdXzMajor, convCurrEduCls_Sim.IdXzMajor);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdXzMajor, 8, convCurrEduCls_Sim.IdXzMajor);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdXzMajor, 8, convCurrEduCls_Sim.IdXzMajor);
}
objvCurrEduCls_SimEN.IdXzMajor = strIdXzMajor; //专业流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduCls_SimEN.dicFldComparisonOp.ContainsKey(convCurrEduCls_Sim.IdXzMajor) == false)
{
objvCurrEduCls_SimEN.dicFldComparisonOp.Add(convCurrEduCls_Sim.IdXzMajor, strComparisonOp);
}
else
{
objvCurrEduCls_SimEN.dicFldComparisonOp[convCurrEduCls_Sim.IdXzMajor] = strComparisonOp;
}
}
return objvCurrEduCls_SimEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvCurrEduCls_SimENS">源对象</param>
 /// <param name = "objvCurrEduCls_SimENT">目标对象</param>
 public static void CopyTo(this clsvCurrEduCls_SimEN objvCurrEduCls_SimENS, clsvCurrEduCls_SimEN objvCurrEduCls_SimENT)
{
try
{
objvCurrEduCls_SimENT.IdCurrEduCls = objvCurrEduCls_SimENS.IdCurrEduCls; //教学班流水号
objvCurrEduCls_SimENT.CurrEduClsId = objvCurrEduCls_SimENS.CurrEduClsId; //教学班Id
objvCurrEduCls_SimENT.EduClsName = objvCurrEduCls_SimENS.EduClsName; //教学班名
objvCurrEduCls_SimENT.EduClsTypeId = objvCurrEduCls_SimENS.EduClsTypeId; //教学班类型Id
objvCurrEduCls_SimENT.CourseId = objvCurrEduCls_SimENS.CourseId; //课程Id
objvCurrEduCls_SimENT.IdXzCollege = objvCurrEduCls_SimENS.IdXzCollege; //学院流水号
objvCurrEduCls_SimENT.IdXzMajor = objvCurrEduCls_SimENS.IdXzMajor; //专业流水号
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
 /// <param name = "objvCurrEduCls_SimENS">源对象</param>
 /// <returns>目标对象=>clsvCurrEduCls_SimEN:objvCurrEduCls_SimENT</returns>
 public static clsvCurrEduCls_SimEN CopyTo(this clsvCurrEduCls_SimEN objvCurrEduCls_SimENS)
{
try
{
 clsvCurrEduCls_SimEN objvCurrEduCls_SimENT = new clsvCurrEduCls_SimEN()
{
IdCurrEduCls = objvCurrEduCls_SimENS.IdCurrEduCls, //教学班流水号
CurrEduClsId = objvCurrEduCls_SimENS.CurrEduClsId, //教学班Id
EduClsName = objvCurrEduCls_SimENS.EduClsName, //教学班名
EduClsTypeId = objvCurrEduCls_SimENS.EduClsTypeId, //教学班类型Id
CourseId = objvCurrEduCls_SimENS.CourseId, //课程Id
IdXzCollege = objvCurrEduCls_SimENS.IdXzCollege, //学院流水号
IdXzMajor = objvCurrEduCls_SimENS.IdXzMajor, //专业流水号
};
 return objvCurrEduCls_SimENT;
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
public static void CheckProperty4Condition(this clsvCurrEduCls_SimEN objvCurrEduCls_SimEN)
{
 clsvCurrEduCls_SimBL.vCurrEduCls_SimDA.CheckProperty4Condition(objvCurrEduCls_SimEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvCurrEduCls_SimEN objvCurrEduCls_SimCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvCurrEduCls_SimCond.IsUpdated(convCurrEduCls_Sim.IdCurrEduCls) == true)
{
string strComparisonOpIdCurrEduCls = objvCurrEduCls_SimCond.dicFldComparisonOp[convCurrEduCls_Sim.IdCurrEduCls];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduCls_Sim.IdCurrEduCls, objvCurrEduCls_SimCond.IdCurrEduCls, strComparisonOpIdCurrEduCls);
}
if (objvCurrEduCls_SimCond.IsUpdated(convCurrEduCls_Sim.CurrEduClsId) == true)
{
string strComparisonOpCurrEduClsId = objvCurrEduCls_SimCond.dicFldComparisonOp[convCurrEduCls_Sim.CurrEduClsId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduCls_Sim.CurrEduClsId, objvCurrEduCls_SimCond.CurrEduClsId, strComparisonOpCurrEduClsId);
}
if (objvCurrEduCls_SimCond.IsUpdated(convCurrEduCls_Sim.EduClsName) == true)
{
string strComparisonOpEduClsName = objvCurrEduCls_SimCond.dicFldComparisonOp[convCurrEduCls_Sim.EduClsName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduCls_Sim.EduClsName, objvCurrEduCls_SimCond.EduClsName, strComparisonOpEduClsName);
}
if (objvCurrEduCls_SimCond.IsUpdated(convCurrEduCls_Sim.EduClsTypeId) == true)
{
string strComparisonOpEduClsTypeId = objvCurrEduCls_SimCond.dicFldComparisonOp[convCurrEduCls_Sim.EduClsTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduCls_Sim.EduClsTypeId, objvCurrEduCls_SimCond.EduClsTypeId, strComparisonOpEduClsTypeId);
}
if (objvCurrEduCls_SimCond.IsUpdated(convCurrEduCls_Sim.CourseId) == true)
{
string strComparisonOpCourseId = objvCurrEduCls_SimCond.dicFldComparisonOp[convCurrEduCls_Sim.CourseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduCls_Sim.CourseId, objvCurrEduCls_SimCond.CourseId, strComparisonOpCourseId);
}
if (objvCurrEduCls_SimCond.IsUpdated(convCurrEduCls_Sim.IdXzCollege) == true)
{
string strComparisonOpIdXzCollege = objvCurrEduCls_SimCond.dicFldComparisonOp[convCurrEduCls_Sim.IdXzCollege];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduCls_Sim.IdXzCollege, objvCurrEduCls_SimCond.IdXzCollege, strComparisonOpIdXzCollege);
}
if (objvCurrEduCls_SimCond.IsUpdated(convCurrEduCls_Sim.IdXzMajor) == true)
{
string strComparisonOpIdXzMajor = objvCurrEduCls_SimCond.dicFldComparisonOp[convCurrEduCls_Sim.IdXzMajor];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduCls_Sim.IdXzMajor, objvCurrEduCls_SimCond.IdXzMajor, strComparisonOpIdXzMajor);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vCurrEduCls_Sim
{
public virtual bool UpdRelaTabDate(string strIdCurrEduCls, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// vCurrEduCls_Sim(vCurrEduCls_Sim)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvCurrEduCls_SimBL
{
public static RelatedActions_vCurrEduCls_Sim relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvCurrEduCls_SimDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvCurrEduCls_SimDA vCurrEduCls_SimDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvCurrEduCls_SimDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvCurrEduCls_SimBL()
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
if (string.IsNullOrEmpty(clsvCurrEduCls_SimEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvCurrEduCls_SimEN._ConnectString);
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
public static DataTable GetDataTable_vCurrEduCls_Sim(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vCurrEduCls_SimDA.GetDataTable_vCurrEduCls_Sim(strWhereCond);
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
objDT = vCurrEduCls_SimDA.GetDataTable(strWhereCond);
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
objDT = vCurrEduCls_SimDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vCurrEduCls_SimDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vCurrEduCls_SimDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vCurrEduCls_SimDA.GetDataTable_Top(objTopPara);
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
objDT = vCurrEduCls_SimDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vCurrEduCls_SimDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vCurrEduCls_SimDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrIdCurrEduClsLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvCurrEduCls_SimEN> GetObjLstByIdCurrEduClsLst(List<string> arrIdCurrEduClsLst)
{
List<clsvCurrEduCls_SimEN> arrObjLst = new List<clsvCurrEduCls_SimEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrIdCurrEduClsLst, true);
 string strWhereCond = string.Format("IdCurrEduCls in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCurrEduCls_SimEN objvCurrEduCls_SimEN = new clsvCurrEduCls_SimEN();
try
{
objvCurrEduCls_SimEN.IdCurrEduCls = objRow[convCurrEduCls_Sim.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvCurrEduCls_SimEN.CurrEduClsId = objRow[convCurrEduCls_Sim.CurrEduClsId] == DBNull.Value ? null : objRow[convCurrEduCls_Sim.CurrEduClsId].ToString().Trim(); //教学班Id
objvCurrEduCls_SimEN.EduClsName = objRow[convCurrEduCls_Sim.EduClsName].ToString().Trim(); //教学班名
objvCurrEduCls_SimEN.EduClsTypeId = objRow[convCurrEduCls_Sim.EduClsTypeId].ToString().Trim(); //教学班类型Id
objvCurrEduCls_SimEN.CourseId = objRow[convCurrEduCls_Sim.CourseId] == DBNull.Value ? null : objRow[convCurrEduCls_Sim.CourseId].ToString().Trim(); //课程Id
objvCurrEduCls_SimEN.IdXzCollege = objRow[convCurrEduCls_Sim.IdXzCollege] == DBNull.Value ? null : objRow[convCurrEduCls_Sim.IdXzCollege].ToString().Trim(); //学院流水号
objvCurrEduCls_SimEN.IdXzMajor = objRow[convCurrEduCls_Sim.IdXzMajor].ToString().Trim(); //专业流水号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCurrEduCls_SimEN.IdCurrEduCls, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCurrEduCls_SimEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrIdCurrEduClsLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvCurrEduCls_SimEN> GetObjLstByIdCurrEduClsLstCache(List<string> arrIdCurrEduClsLst)
{
string strKey = string.Format("{0}", clsvCurrEduCls_SimEN._CurrTabName);
List<clsvCurrEduCls_SimEN> arrvCurrEduCls_SimObjLstCache = GetObjLstCache();
IEnumerable <clsvCurrEduCls_SimEN> arrvCurrEduCls_SimObjLst_Sel =
arrvCurrEduCls_SimObjLstCache
.Where(x => arrIdCurrEduClsLst.Contains(x.IdCurrEduCls));
return arrvCurrEduCls_SimObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvCurrEduCls_SimEN> GetObjLst(string strWhereCond)
{
List<clsvCurrEduCls_SimEN> arrObjLst = new List<clsvCurrEduCls_SimEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCurrEduCls_SimEN objvCurrEduCls_SimEN = new clsvCurrEduCls_SimEN();
try
{
objvCurrEduCls_SimEN.IdCurrEduCls = objRow[convCurrEduCls_Sim.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvCurrEduCls_SimEN.CurrEduClsId = objRow[convCurrEduCls_Sim.CurrEduClsId] == DBNull.Value ? null : objRow[convCurrEduCls_Sim.CurrEduClsId].ToString().Trim(); //教学班Id
objvCurrEduCls_SimEN.EduClsName = objRow[convCurrEduCls_Sim.EduClsName].ToString().Trim(); //教学班名
objvCurrEduCls_SimEN.EduClsTypeId = objRow[convCurrEduCls_Sim.EduClsTypeId].ToString().Trim(); //教学班类型Id
objvCurrEduCls_SimEN.CourseId = objRow[convCurrEduCls_Sim.CourseId] == DBNull.Value ? null : objRow[convCurrEduCls_Sim.CourseId].ToString().Trim(); //课程Id
objvCurrEduCls_SimEN.IdXzCollege = objRow[convCurrEduCls_Sim.IdXzCollege] == DBNull.Value ? null : objRow[convCurrEduCls_Sim.IdXzCollege].ToString().Trim(); //学院流水号
objvCurrEduCls_SimEN.IdXzMajor = objRow[convCurrEduCls_Sim.IdXzMajor].ToString().Trim(); //专业流水号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCurrEduCls_SimEN.IdCurrEduCls, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCurrEduCls_SimEN);
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
public static List<clsvCurrEduCls_SimEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvCurrEduCls_SimEN> arrObjLst = new List<clsvCurrEduCls_SimEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCurrEduCls_SimEN objvCurrEduCls_SimEN = new clsvCurrEduCls_SimEN();
try
{
objvCurrEduCls_SimEN.IdCurrEduCls = objRow[convCurrEduCls_Sim.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvCurrEduCls_SimEN.CurrEduClsId = objRow[convCurrEduCls_Sim.CurrEduClsId] == DBNull.Value ? null : objRow[convCurrEduCls_Sim.CurrEduClsId].ToString().Trim(); //教学班Id
objvCurrEduCls_SimEN.EduClsName = objRow[convCurrEduCls_Sim.EduClsName].ToString().Trim(); //教学班名
objvCurrEduCls_SimEN.EduClsTypeId = objRow[convCurrEduCls_Sim.EduClsTypeId].ToString().Trim(); //教学班类型Id
objvCurrEduCls_SimEN.CourseId = objRow[convCurrEduCls_Sim.CourseId] == DBNull.Value ? null : objRow[convCurrEduCls_Sim.CourseId].ToString().Trim(); //课程Id
objvCurrEduCls_SimEN.IdXzCollege = objRow[convCurrEduCls_Sim.IdXzCollege] == DBNull.Value ? null : objRow[convCurrEduCls_Sim.IdXzCollege].ToString().Trim(); //学院流水号
objvCurrEduCls_SimEN.IdXzMajor = objRow[convCurrEduCls_Sim.IdXzMajor].ToString().Trim(); //专业流水号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCurrEduCls_SimEN.IdCurrEduCls, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCurrEduCls_SimEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvCurrEduCls_SimCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvCurrEduCls_SimEN> GetSubObjLstCache(clsvCurrEduCls_SimEN objvCurrEduCls_SimCond)
{
List<clsvCurrEduCls_SimEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvCurrEduCls_SimEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convCurrEduCls_Sim.AttributeName)
{
if (objvCurrEduCls_SimCond.IsUpdated(strFldName) == false) continue;
if (objvCurrEduCls_SimCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvCurrEduCls_SimCond[strFldName].ToString());
}
else
{
if (objvCurrEduCls_SimCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvCurrEduCls_SimCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvCurrEduCls_SimCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvCurrEduCls_SimCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvCurrEduCls_SimCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvCurrEduCls_SimCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvCurrEduCls_SimCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvCurrEduCls_SimCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvCurrEduCls_SimCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvCurrEduCls_SimCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvCurrEduCls_SimCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvCurrEduCls_SimCond[strFldName]));
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
public static List<clsvCurrEduCls_SimEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvCurrEduCls_SimEN> arrObjLst = new List<clsvCurrEduCls_SimEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCurrEduCls_SimEN objvCurrEduCls_SimEN = new clsvCurrEduCls_SimEN();
try
{
objvCurrEduCls_SimEN.IdCurrEduCls = objRow[convCurrEduCls_Sim.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvCurrEduCls_SimEN.CurrEduClsId = objRow[convCurrEduCls_Sim.CurrEduClsId] == DBNull.Value ? null : objRow[convCurrEduCls_Sim.CurrEduClsId].ToString().Trim(); //教学班Id
objvCurrEduCls_SimEN.EduClsName = objRow[convCurrEduCls_Sim.EduClsName].ToString().Trim(); //教学班名
objvCurrEduCls_SimEN.EduClsTypeId = objRow[convCurrEduCls_Sim.EduClsTypeId].ToString().Trim(); //教学班类型Id
objvCurrEduCls_SimEN.CourseId = objRow[convCurrEduCls_Sim.CourseId] == DBNull.Value ? null : objRow[convCurrEduCls_Sim.CourseId].ToString().Trim(); //课程Id
objvCurrEduCls_SimEN.IdXzCollege = objRow[convCurrEduCls_Sim.IdXzCollege] == DBNull.Value ? null : objRow[convCurrEduCls_Sim.IdXzCollege].ToString().Trim(); //学院流水号
objvCurrEduCls_SimEN.IdXzMajor = objRow[convCurrEduCls_Sim.IdXzMajor].ToString().Trim(); //专业流水号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCurrEduCls_SimEN.IdCurrEduCls, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCurrEduCls_SimEN);
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
public static List<clsvCurrEduCls_SimEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvCurrEduCls_SimEN> arrObjLst = new List<clsvCurrEduCls_SimEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCurrEduCls_SimEN objvCurrEduCls_SimEN = new clsvCurrEduCls_SimEN();
try
{
objvCurrEduCls_SimEN.IdCurrEduCls = objRow[convCurrEduCls_Sim.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvCurrEduCls_SimEN.CurrEduClsId = objRow[convCurrEduCls_Sim.CurrEduClsId] == DBNull.Value ? null : objRow[convCurrEduCls_Sim.CurrEduClsId].ToString().Trim(); //教学班Id
objvCurrEduCls_SimEN.EduClsName = objRow[convCurrEduCls_Sim.EduClsName].ToString().Trim(); //教学班名
objvCurrEduCls_SimEN.EduClsTypeId = objRow[convCurrEduCls_Sim.EduClsTypeId].ToString().Trim(); //教学班类型Id
objvCurrEduCls_SimEN.CourseId = objRow[convCurrEduCls_Sim.CourseId] == DBNull.Value ? null : objRow[convCurrEduCls_Sim.CourseId].ToString().Trim(); //课程Id
objvCurrEduCls_SimEN.IdXzCollege = objRow[convCurrEduCls_Sim.IdXzCollege] == DBNull.Value ? null : objRow[convCurrEduCls_Sim.IdXzCollege].ToString().Trim(); //学院流水号
objvCurrEduCls_SimEN.IdXzMajor = objRow[convCurrEduCls_Sim.IdXzMajor].ToString().Trim(); //专业流水号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCurrEduCls_SimEN.IdCurrEduCls, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCurrEduCls_SimEN);
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
List<clsvCurrEduCls_SimEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvCurrEduCls_SimEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvCurrEduCls_SimEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvCurrEduCls_SimEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvCurrEduCls_SimEN> arrObjLst = new List<clsvCurrEduCls_SimEN>(); 
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
	clsvCurrEduCls_SimEN objvCurrEduCls_SimEN = new clsvCurrEduCls_SimEN();
try
{
objvCurrEduCls_SimEN.IdCurrEduCls = objRow[convCurrEduCls_Sim.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvCurrEduCls_SimEN.CurrEduClsId = objRow[convCurrEduCls_Sim.CurrEduClsId] == DBNull.Value ? null : objRow[convCurrEduCls_Sim.CurrEduClsId].ToString().Trim(); //教学班Id
objvCurrEduCls_SimEN.EduClsName = objRow[convCurrEduCls_Sim.EduClsName].ToString().Trim(); //教学班名
objvCurrEduCls_SimEN.EduClsTypeId = objRow[convCurrEduCls_Sim.EduClsTypeId].ToString().Trim(); //教学班类型Id
objvCurrEduCls_SimEN.CourseId = objRow[convCurrEduCls_Sim.CourseId] == DBNull.Value ? null : objRow[convCurrEduCls_Sim.CourseId].ToString().Trim(); //课程Id
objvCurrEduCls_SimEN.IdXzCollege = objRow[convCurrEduCls_Sim.IdXzCollege] == DBNull.Value ? null : objRow[convCurrEduCls_Sim.IdXzCollege].ToString().Trim(); //学院流水号
objvCurrEduCls_SimEN.IdXzMajor = objRow[convCurrEduCls_Sim.IdXzMajor].ToString().Trim(); //专业流水号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCurrEduCls_SimEN.IdCurrEduCls, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCurrEduCls_SimEN);
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
public static List<clsvCurrEduCls_SimEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvCurrEduCls_SimEN> arrObjLst = new List<clsvCurrEduCls_SimEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCurrEduCls_SimEN objvCurrEduCls_SimEN = new clsvCurrEduCls_SimEN();
try
{
objvCurrEduCls_SimEN.IdCurrEduCls = objRow[convCurrEduCls_Sim.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvCurrEduCls_SimEN.CurrEduClsId = objRow[convCurrEduCls_Sim.CurrEduClsId] == DBNull.Value ? null : objRow[convCurrEduCls_Sim.CurrEduClsId].ToString().Trim(); //教学班Id
objvCurrEduCls_SimEN.EduClsName = objRow[convCurrEduCls_Sim.EduClsName].ToString().Trim(); //教学班名
objvCurrEduCls_SimEN.EduClsTypeId = objRow[convCurrEduCls_Sim.EduClsTypeId].ToString().Trim(); //教学班类型Id
objvCurrEduCls_SimEN.CourseId = objRow[convCurrEduCls_Sim.CourseId] == DBNull.Value ? null : objRow[convCurrEduCls_Sim.CourseId].ToString().Trim(); //课程Id
objvCurrEduCls_SimEN.IdXzCollege = objRow[convCurrEduCls_Sim.IdXzCollege] == DBNull.Value ? null : objRow[convCurrEduCls_Sim.IdXzCollege].ToString().Trim(); //学院流水号
objvCurrEduCls_SimEN.IdXzMajor = objRow[convCurrEduCls_Sim.IdXzMajor].ToString().Trim(); //专业流水号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCurrEduCls_SimEN.IdCurrEduCls, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCurrEduCls_SimEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvCurrEduCls_SimEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvCurrEduCls_SimEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvCurrEduCls_SimEN> arrObjLst = new List<clsvCurrEduCls_SimEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCurrEduCls_SimEN objvCurrEduCls_SimEN = new clsvCurrEduCls_SimEN();
try
{
objvCurrEduCls_SimEN.IdCurrEduCls = objRow[convCurrEduCls_Sim.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvCurrEduCls_SimEN.CurrEduClsId = objRow[convCurrEduCls_Sim.CurrEduClsId] == DBNull.Value ? null : objRow[convCurrEduCls_Sim.CurrEduClsId].ToString().Trim(); //教学班Id
objvCurrEduCls_SimEN.EduClsName = objRow[convCurrEduCls_Sim.EduClsName].ToString().Trim(); //教学班名
objvCurrEduCls_SimEN.EduClsTypeId = objRow[convCurrEduCls_Sim.EduClsTypeId].ToString().Trim(); //教学班类型Id
objvCurrEduCls_SimEN.CourseId = objRow[convCurrEduCls_Sim.CourseId] == DBNull.Value ? null : objRow[convCurrEduCls_Sim.CourseId].ToString().Trim(); //课程Id
objvCurrEduCls_SimEN.IdXzCollege = objRow[convCurrEduCls_Sim.IdXzCollege] == DBNull.Value ? null : objRow[convCurrEduCls_Sim.IdXzCollege].ToString().Trim(); //学院流水号
objvCurrEduCls_SimEN.IdXzMajor = objRow[convCurrEduCls_Sim.IdXzMajor].ToString().Trim(); //专业流水号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCurrEduCls_SimEN.IdCurrEduCls, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCurrEduCls_SimEN);
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
public static List<clsvCurrEduCls_SimEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvCurrEduCls_SimEN> arrObjLst = new List<clsvCurrEduCls_SimEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCurrEduCls_SimEN objvCurrEduCls_SimEN = new clsvCurrEduCls_SimEN();
try
{
objvCurrEduCls_SimEN.IdCurrEduCls = objRow[convCurrEduCls_Sim.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvCurrEduCls_SimEN.CurrEduClsId = objRow[convCurrEduCls_Sim.CurrEduClsId] == DBNull.Value ? null : objRow[convCurrEduCls_Sim.CurrEduClsId].ToString().Trim(); //教学班Id
objvCurrEduCls_SimEN.EduClsName = objRow[convCurrEduCls_Sim.EduClsName].ToString().Trim(); //教学班名
objvCurrEduCls_SimEN.EduClsTypeId = objRow[convCurrEduCls_Sim.EduClsTypeId].ToString().Trim(); //教学班类型Id
objvCurrEduCls_SimEN.CourseId = objRow[convCurrEduCls_Sim.CourseId] == DBNull.Value ? null : objRow[convCurrEduCls_Sim.CourseId].ToString().Trim(); //课程Id
objvCurrEduCls_SimEN.IdXzCollege = objRow[convCurrEduCls_Sim.IdXzCollege] == DBNull.Value ? null : objRow[convCurrEduCls_Sim.IdXzCollege].ToString().Trim(); //学院流水号
objvCurrEduCls_SimEN.IdXzMajor = objRow[convCurrEduCls_Sim.IdXzMajor].ToString().Trim(); //专业流水号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCurrEduCls_SimEN.IdCurrEduCls, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCurrEduCls_SimEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvCurrEduCls_SimEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvCurrEduCls_SimEN> arrObjLst = new List<clsvCurrEduCls_SimEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCurrEduCls_SimEN objvCurrEduCls_SimEN = new clsvCurrEduCls_SimEN();
try
{
objvCurrEduCls_SimEN.IdCurrEduCls = objRow[convCurrEduCls_Sim.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvCurrEduCls_SimEN.CurrEduClsId = objRow[convCurrEduCls_Sim.CurrEduClsId] == DBNull.Value ? null : objRow[convCurrEduCls_Sim.CurrEduClsId].ToString().Trim(); //教学班Id
objvCurrEduCls_SimEN.EduClsName = objRow[convCurrEduCls_Sim.EduClsName].ToString().Trim(); //教学班名
objvCurrEduCls_SimEN.EduClsTypeId = objRow[convCurrEduCls_Sim.EduClsTypeId].ToString().Trim(); //教学班类型Id
objvCurrEduCls_SimEN.CourseId = objRow[convCurrEduCls_Sim.CourseId] == DBNull.Value ? null : objRow[convCurrEduCls_Sim.CourseId].ToString().Trim(); //课程Id
objvCurrEduCls_SimEN.IdXzCollege = objRow[convCurrEduCls_Sim.IdXzCollege] == DBNull.Value ? null : objRow[convCurrEduCls_Sim.IdXzCollege].ToString().Trim(); //学院流水号
objvCurrEduCls_SimEN.IdXzMajor = objRow[convCurrEduCls_Sim.IdXzMajor].ToString().Trim(); //专业流水号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCurrEduCls_SimEN.IdCurrEduCls, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCurrEduCls_SimEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvCurrEduCls_SimEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvCurrEduCls_Sim(ref clsvCurrEduCls_SimEN objvCurrEduCls_SimEN)
{
bool bolResult = vCurrEduCls_SimDA.GetvCurrEduCls_Sim(ref objvCurrEduCls_SimEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strIdCurrEduCls">表关键字</param>
 /// <returns>表对象</returns>
public static clsvCurrEduCls_SimEN GetObjByIdCurrEduCls(string strIdCurrEduCls)
{
if (strIdCurrEduCls.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strIdCurrEduCls]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strIdCurrEduCls) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strIdCurrEduCls]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsvCurrEduCls_SimEN objvCurrEduCls_SimEN = vCurrEduCls_SimDA.GetObjByIdCurrEduCls(strIdCurrEduCls);
return objvCurrEduCls_SimEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvCurrEduCls_SimEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvCurrEduCls_SimEN objvCurrEduCls_SimEN = vCurrEduCls_SimDA.GetFirstObj(strWhereCond);
 return objvCurrEduCls_SimEN;
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
public static clsvCurrEduCls_SimEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvCurrEduCls_SimEN objvCurrEduCls_SimEN = vCurrEduCls_SimDA.GetObjByDataRow(objRow);
 return objvCurrEduCls_SimEN;
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
public static clsvCurrEduCls_SimEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvCurrEduCls_SimEN objvCurrEduCls_SimEN = vCurrEduCls_SimDA.GetObjByDataRow(objRow);
 return objvCurrEduCls_SimEN;
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
 /// <param name = "strIdCurrEduCls">所给的关键字</param>
 /// <param name = "lstvCurrEduCls_SimObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvCurrEduCls_SimEN GetObjByIdCurrEduClsFromList(string strIdCurrEduCls, List<clsvCurrEduCls_SimEN> lstvCurrEduCls_SimObjLst)
{
foreach (clsvCurrEduCls_SimEN objvCurrEduCls_SimEN in lstvCurrEduCls_SimObjLst)
{
if (objvCurrEduCls_SimEN.IdCurrEduCls == strIdCurrEduCls)
{
return objvCurrEduCls_SimEN;
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
 string strIdCurrEduCls;
 try
 {
 strIdCurrEduCls = new clsvCurrEduCls_SimDA().GetFirstID(strWhereCond);
 return strIdCurrEduCls;
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
 arrList = vCurrEduCls_SimDA.GetID(strWhereCond);
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
bool bolIsExist = vCurrEduCls_SimDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strIdCurrEduCls">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strIdCurrEduCls)
{
if (string.IsNullOrEmpty(strIdCurrEduCls) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strIdCurrEduCls]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = vCurrEduCls_SimDA.IsExist(strIdCurrEduCls);
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
 bolIsExist = clsvCurrEduCls_SimDA.IsExistTable();
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
 bolIsExist = vCurrEduCls_SimDA.IsExistTable(strTabName);
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
 /// <param name = "objvCurrEduCls_SimENS">源对象</param>
 /// <param name = "objvCurrEduCls_SimENT">目标对象</param>
 public static void CopyTo(clsvCurrEduCls_SimEN objvCurrEduCls_SimENS, clsvCurrEduCls_SimEN objvCurrEduCls_SimENT)
{
try
{
objvCurrEduCls_SimENT.IdCurrEduCls = objvCurrEduCls_SimENS.IdCurrEduCls; //教学班流水号
objvCurrEduCls_SimENT.CurrEduClsId = objvCurrEduCls_SimENS.CurrEduClsId; //教学班Id
objvCurrEduCls_SimENT.EduClsName = objvCurrEduCls_SimENS.EduClsName; //教学班名
objvCurrEduCls_SimENT.EduClsTypeId = objvCurrEduCls_SimENS.EduClsTypeId; //教学班类型Id
objvCurrEduCls_SimENT.CourseId = objvCurrEduCls_SimENS.CourseId; //课程Id
objvCurrEduCls_SimENT.IdXzCollege = objvCurrEduCls_SimENS.IdXzCollege; //学院流水号
objvCurrEduCls_SimENT.IdXzMajor = objvCurrEduCls_SimENS.IdXzMajor; //专业流水号
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
 /// <param name = "objvCurrEduCls_SimEN">源简化对象</param>
 public static void SetUpdFlag(clsvCurrEduCls_SimEN objvCurrEduCls_SimEN)
{
try
{
objvCurrEduCls_SimEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvCurrEduCls_SimEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convCurrEduCls_Sim.IdCurrEduCls, new clsStrCompareIgnoreCase())  ==  true)
{
objvCurrEduCls_SimEN.IdCurrEduCls = objvCurrEduCls_SimEN.IdCurrEduCls; //教学班流水号
}
if (arrFldSet.Contains(convCurrEduCls_Sim.CurrEduClsId, new clsStrCompareIgnoreCase())  ==  true)
{
objvCurrEduCls_SimEN.CurrEduClsId = objvCurrEduCls_SimEN.CurrEduClsId == "[null]" ? null :  objvCurrEduCls_SimEN.CurrEduClsId; //教学班Id
}
if (arrFldSet.Contains(convCurrEduCls_Sim.EduClsName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCurrEduCls_SimEN.EduClsName = objvCurrEduCls_SimEN.EduClsName; //教学班名
}
if (arrFldSet.Contains(convCurrEduCls_Sim.EduClsTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvCurrEduCls_SimEN.EduClsTypeId = objvCurrEduCls_SimEN.EduClsTypeId; //教学班类型Id
}
if (arrFldSet.Contains(convCurrEduCls_Sim.CourseId, new clsStrCompareIgnoreCase())  ==  true)
{
objvCurrEduCls_SimEN.CourseId = objvCurrEduCls_SimEN.CourseId == "[null]" ? null :  objvCurrEduCls_SimEN.CourseId; //课程Id
}
if (arrFldSet.Contains(convCurrEduCls_Sim.IdXzCollege, new clsStrCompareIgnoreCase())  ==  true)
{
objvCurrEduCls_SimEN.IdXzCollege = objvCurrEduCls_SimEN.IdXzCollege == "[null]" ? null :  objvCurrEduCls_SimEN.IdXzCollege; //学院流水号
}
if (arrFldSet.Contains(convCurrEduCls_Sim.IdXzMajor, new clsStrCompareIgnoreCase())  ==  true)
{
objvCurrEduCls_SimEN.IdXzMajor = objvCurrEduCls_SimEN.IdXzMajor; //专业流水号
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
 /// <param name = "objvCurrEduCls_SimEN">源简化对象</param>
 public static void AccessFldValueNull(clsvCurrEduCls_SimEN objvCurrEduCls_SimEN)
{
try
{
if (objvCurrEduCls_SimEN.CurrEduClsId == "[null]") objvCurrEduCls_SimEN.CurrEduClsId = null; //教学班Id
if (objvCurrEduCls_SimEN.CourseId == "[null]") objvCurrEduCls_SimEN.CourseId = null; //课程Id
if (objvCurrEduCls_SimEN.IdXzCollege == "[null]") objvCurrEduCls_SimEN.IdXzCollege = null; //学院流水号
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
public static void CheckProperty4Condition(clsvCurrEduCls_SimEN objvCurrEduCls_SimEN)
{
 vCurrEduCls_SimDA.CheckProperty4Condition(objvCurrEduCls_SimEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Web的下拉框-使用Cache
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DdlBindFunctionCache)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_IdCurrEduClsCache(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[vCurrEduCls_Sim]...","0");
List<clsvCurrEduCls_SimEN> arrvCurrEduCls_SimObjLst = GetAllvCurrEduCls_SimObjLstCache(); 
objDDL.DataValueField = convCurrEduCls_Sim.IdCurrEduCls;
objDDL.DataTextField = convCurrEduCls_Sim.EduClsName;
objDDL.DataSource = arrvCurrEduCls_SimObjLst;
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
if (clsCurrEduClsBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsCurrEduClsBL没有刷新缓存机制(clsCurrEduClsBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by IdCurrEduCls");
//if (arrvCurrEduCls_SimObjLstCache == null)
//{
//arrvCurrEduCls_SimObjLstCache = vCurrEduCls_SimDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strIdCurrEduCls">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvCurrEduCls_SimEN GetObjByIdCurrEduClsCache(string strIdCurrEduCls)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvCurrEduCls_SimEN._CurrTabName);
List<clsvCurrEduCls_SimEN> arrvCurrEduCls_SimObjLstCache = GetObjLstCache();
IEnumerable <clsvCurrEduCls_SimEN> arrvCurrEduCls_SimObjLst_Sel =
arrvCurrEduCls_SimObjLstCache
.Where(x=> x.IdCurrEduCls == strIdCurrEduCls 
);
if (arrvCurrEduCls_SimObjLst_Sel.Count() == 0)
{
   clsvCurrEduCls_SimEN obj = clsvCurrEduCls_SimBL.GetObjByIdCurrEduCls(strIdCurrEduCls);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvCurrEduCls_SimObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strIdCurrEduCls">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetEduClsNameByIdCurrEduClsCache(string strIdCurrEduCls)
{
if (string.IsNullOrEmpty(strIdCurrEduCls) == true) return "";
//获取缓存中的对象列表
clsvCurrEduCls_SimEN objvCurrEduCls_Sim = GetObjByIdCurrEduClsCache(strIdCurrEduCls);
if (objvCurrEduCls_Sim == null) return "";
return objvCurrEduCls_Sim.EduClsName;
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strIdCurrEduCls">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByIdCurrEduClsCache(string strIdCurrEduCls)
{
if (string.IsNullOrEmpty(strIdCurrEduCls) == true) return "";
//获取缓存中的对象列表
clsvCurrEduCls_SimEN objvCurrEduCls_Sim = GetObjByIdCurrEduClsCache(strIdCurrEduCls);
if (objvCurrEduCls_Sim == null) return "";
return objvCurrEduCls_Sim.EduClsName;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvCurrEduCls_SimEN> GetAllvCurrEduCls_SimObjLstCache()
{
//获取缓存中的对象列表
List<clsvCurrEduCls_SimEN> arrvCurrEduCls_SimObjLstCache = GetObjLstCache(); 
return arrvCurrEduCls_SimObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvCurrEduCls_SimEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvCurrEduCls_SimEN._CurrTabName);
List<clsvCurrEduCls_SimEN> arrvCurrEduCls_SimObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvCurrEduCls_SimObjLstCache;
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
string strKey = string.Format("{0}", clsvCurrEduCls_SimEN._CurrTabName);
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
 /// 日期:2023-10-28
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_func)
 /// </summary>
 /// <param name = "strInFldName">输入字段名</param>
 /// <param name = "strOutFldName">输出字段名</param>
 /// <param name = "strInValue">输入字段值</param>
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, string strIdCurrEduCls)
{
if (strInFldName != convCurrEduCls_Sim.IdCurrEduCls)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convCurrEduCls_Sim.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convCurrEduCls_Sim.AttributeName));
throw new Exception(strMsg);
}
var objvCurrEduCls_Sim = clsvCurrEduCls_SimBL.GetObjByIdCurrEduClsCache(strIdCurrEduCls);
if (objvCurrEduCls_Sim == null) return "";
return objvCurrEduCls_Sim[strOutFldName].ToString();
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
int intRecCount = clsvCurrEduCls_SimDA.GetRecCount(strTabName);
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
int intRecCount = clsvCurrEduCls_SimDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvCurrEduCls_SimDA.GetRecCount();
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
int intRecCount = clsvCurrEduCls_SimDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvCurrEduCls_SimCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvCurrEduCls_SimEN objvCurrEduCls_SimCond)
{
List<clsvCurrEduCls_SimEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvCurrEduCls_SimEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convCurrEduCls_Sim.AttributeName)
{
if (objvCurrEduCls_SimCond.IsUpdated(strFldName) == false) continue;
if (objvCurrEduCls_SimCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvCurrEduCls_SimCond[strFldName].ToString());
}
else
{
if (objvCurrEduCls_SimCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvCurrEduCls_SimCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvCurrEduCls_SimCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvCurrEduCls_SimCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvCurrEduCls_SimCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvCurrEduCls_SimCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvCurrEduCls_SimCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvCurrEduCls_SimCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvCurrEduCls_SimCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvCurrEduCls_SimCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvCurrEduCls_SimCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvCurrEduCls_SimCond[strFldName]));
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
 List<string> arrList = clsvCurrEduCls_SimDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vCurrEduCls_SimDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vCurrEduCls_SimDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}