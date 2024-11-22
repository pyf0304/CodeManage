
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvXzGrade_psBL
 表名:vXzGrade_ps(01120368)
 * 版本:2024.02.19.1(服务器:WIN-SRV103-116)
 日期:2024/02/27 16:25:23
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:中小学教学(K12Edu)
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
public static class  clsvXzGrade_psBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strIdGradeBase">表关键字</param>
 /// <returns>表对象</returns>
public static clsvXzGrade_psEN GetObj(this K_IdGradeBase_vXzGrade_ps myKey)
{
clsvXzGrade_psEN objvXzGrade_psEN = clsvXzGrade_psBL.vXzGrade_psDA.GetObjByIdGradeBase(myKey.Value);
return objvXzGrade_psEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzGrade_psEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvXzGrade_psEN SetIdGradeBase(this clsvXzGrade_psEN objvXzGrade_psEN, string strIdGradeBase, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdGradeBase, 4, convXzGrade_ps.IdGradeBase);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdGradeBase, 4, convXzGrade_ps.IdGradeBase);
}
objvXzGrade_psEN.IdGradeBase = strIdGradeBase; //年级流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvXzGrade_psEN.dicFldComparisonOp.ContainsKey(convXzGrade_ps.IdGradeBase) == false)
{
objvXzGrade_psEN.dicFldComparisonOp.Add(convXzGrade_ps.IdGradeBase, strComparisonOp);
}
else
{
objvXzGrade_psEN.dicFldComparisonOp[convXzGrade_ps.IdGradeBase] = strComparisonOp;
}
}
return objvXzGrade_psEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzGrade_psEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvXzGrade_psEN SetGradeBaseId(this clsvXzGrade_psEN objvXzGrade_psEN, string strGradeBaseId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strGradeBaseId, convXzGrade_ps.GradeBaseId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strGradeBaseId, 4, convXzGrade_ps.GradeBaseId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strGradeBaseId, 4, convXzGrade_ps.GradeBaseId);
}
objvXzGrade_psEN.GradeBaseId = strGradeBaseId; //年级代号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvXzGrade_psEN.dicFldComparisonOp.ContainsKey(convXzGrade_ps.GradeBaseId) == false)
{
objvXzGrade_psEN.dicFldComparisonOp.Add(convXzGrade_ps.GradeBaseId, strComparisonOp);
}
else
{
objvXzGrade_psEN.dicFldComparisonOp[convXzGrade_ps.GradeBaseId] = strComparisonOp;
}
}
return objvXzGrade_psEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzGrade_psEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvXzGrade_psEN SetGradeBaseName(this clsvXzGrade_psEN objvXzGrade_psEN, string strGradeBaseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strGradeBaseName, convXzGrade_ps.GradeBaseName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strGradeBaseName, 50, convXzGrade_ps.GradeBaseName);
}
objvXzGrade_psEN.GradeBaseName = strGradeBaseName; //年级名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvXzGrade_psEN.dicFldComparisonOp.ContainsKey(convXzGrade_ps.GradeBaseName) == false)
{
objvXzGrade_psEN.dicFldComparisonOp.Add(convXzGrade_ps.GradeBaseName, strComparisonOp);
}
else
{
objvXzGrade_psEN.dicFldComparisonOp[convXzGrade_ps.GradeBaseName] = strComparisonOp;
}
}
return objvXzGrade_psEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzGrade_psEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvXzGrade_psEN SetIsVisible(this clsvXzGrade_psEN objvXzGrade_psEN, bool bolIsVisible, string strComparisonOp="")
	{
objvXzGrade_psEN.IsVisible = bolIsVisible; //是否显示
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvXzGrade_psEN.dicFldComparisonOp.ContainsKey(convXzGrade_ps.IsVisible) == false)
{
objvXzGrade_psEN.dicFldComparisonOp.Add(convXzGrade_ps.IsVisible, strComparisonOp);
}
else
{
objvXzGrade_psEN.dicFldComparisonOp[convXzGrade_ps.IsVisible] = strComparisonOp;
}
}
return objvXzGrade_psEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzGrade_psEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvXzGrade_psEN SetOrderNum(this clsvXzGrade_psEN objvXzGrade_psEN, int? intOrderNum, string strComparisonOp="")
	{
objvXzGrade_psEN.OrderNum = intOrderNum; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvXzGrade_psEN.dicFldComparisonOp.ContainsKey(convXzGrade_ps.OrderNum) == false)
{
objvXzGrade_psEN.dicFldComparisonOp.Add(convXzGrade_ps.OrderNum, strComparisonOp);
}
else
{
objvXzGrade_psEN.dicFldComparisonOp[convXzGrade_ps.OrderNum] = strComparisonOp;
}
}
return objvXzGrade_psEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzGrade_psEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvXzGrade_psEN SetSchoolId(this clsvXzGrade_psEN objvXzGrade_psEN, string strSchoolId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strSchoolId, convXzGrade_ps.SchoolId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSchoolId, 10, convXzGrade_ps.SchoolId);
}
objvXzGrade_psEN.SchoolId = strSchoolId; //学校编号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvXzGrade_psEN.dicFldComparisonOp.ContainsKey(convXzGrade_ps.SchoolId) == false)
{
objvXzGrade_psEN.dicFldComparisonOp.Add(convXzGrade_ps.SchoolId, strComparisonOp);
}
else
{
objvXzGrade_psEN.dicFldComparisonOp[convXzGrade_ps.SchoolId] = strComparisonOp;
}
}
return objvXzGrade_psEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzGrade_psEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvXzGrade_psEN SetSchoolName(this clsvXzGrade_psEN objvXzGrade_psEN, string strSchoolName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strSchoolName, convXzGrade_ps.SchoolName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSchoolName, 50, convXzGrade_ps.SchoolName);
}
objvXzGrade_psEN.SchoolName = strSchoolName; //学校名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvXzGrade_psEN.dicFldComparisonOp.ContainsKey(convXzGrade_ps.SchoolName) == false)
{
objvXzGrade_psEN.dicFldComparisonOp.Add(convXzGrade_ps.SchoolName, strComparisonOp);
}
else
{
objvXzGrade_psEN.dicFldComparisonOp[convXzGrade_ps.SchoolName] = strComparisonOp;
}
}
return objvXzGrade_psEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzGrade_psEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvXzGrade_psEN SetIdSchool(this clsvXzGrade_psEN objvXzGrade_psEN, string strIdSchool, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdSchool, 4, convXzGrade_ps.IdSchool);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdSchool, 4, convXzGrade_ps.IdSchool);
}
objvXzGrade_psEN.IdSchool = strIdSchool; //学校流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvXzGrade_psEN.dicFldComparisonOp.ContainsKey(convXzGrade_ps.IdSchool) == false)
{
objvXzGrade_psEN.dicFldComparisonOp.Add(convXzGrade_ps.IdSchool, strComparisonOp);
}
else
{
objvXzGrade_psEN.dicFldComparisonOp[convXzGrade_ps.IdSchool] = strComparisonOp;
}
}
return objvXzGrade_psEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzGrade_psEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvXzGrade_psEN SetMemo(this clsvXzGrade_psEN objvXzGrade_psEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convXzGrade_ps.Memo);
}
objvXzGrade_psEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvXzGrade_psEN.dicFldComparisonOp.ContainsKey(convXzGrade_ps.Memo) == false)
{
objvXzGrade_psEN.dicFldComparisonOp.Add(convXzGrade_ps.Memo, strComparisonOp);
}
else
{
objvXzGrade_psEN.dicFldComparisonOp[convXzGrade_ps.Memo] = strComparisonOp;
}
}
return objvXzGrade_psEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvXzGrade_psENS">源对象</param>
 /// <param name = "objvXzGrade_psENT">目标对象</param>
 public static void CopyTo(this clsvXzGrade_psEN objvXzGrade_psENS, clsvXzGrade_psEN objvXzGrade_psENT)
{
try
{
objvXzGrade_psENT.IdGradeBase = objvXzGrade_psENS.IdGradeBase; //年级流水号
objvXzGrade_psENT.GradeBaseId = objvXzGrade_psENS.GradeBaseId; //年级代号
objvXzGrade_psENT.GradeBaseName = objvXzGrade_psENS.GradeBaseName; //年级名称
objvXzGrade_psENT.IsVisible = objvXzGrade_psENS.IsVisible; //是否显示
objvXzGrade_psENT.OrderNum = objvXzGrade_psENS.OrderNum; //序号
objvXzGrade_psENT.SchoolId = objvXzGrade_psENS.SchoolId; //学校编号
objvXzGrade_psENT.SchoolName = objvXzGrade_psENS.SchoolName; //学校名称
objvXzGrade_psENT.IdSchool = objvXzGrade_psENS.IdSchool; //学校流水号
objvXzGrade_psENT.Memo = objvXzGrade_psENS.Memo; //备注
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
 /// <param name = "objvXzGrade_psENS">源对象</param>
 /// <returns>目标对象=>clsvXzGrade_psEN:objvXzGrade_psENT</returns>
 public static clsvXzGrade_psEN CopyTo(this clsvXzGrade_psEN objvXzGrade_psENS)
{
try
{
 clsvXzGrade_psEN objvXzGrade_psENT = new clsvXzGrade_psEN()
{
IdGradeBase = objvXzGrade_psENS.IdGradeBase, //年级流水号
GradeBaseId = objvXzGrade_psENS.GradeBaseId, //年级代号
GradeBaseName = objvXzGrade_psENS.GradeBaseName, //年级名称
IsVisible = objvXzGrade_psENS.IsVisible, //是否显示
OrderNum = objvXzGrade_psENS.OrderNum, //序号
SchoolId = objvXzGrade_psENS.SchoolId, //学校编号
SchoolName = objvXzGrade_psENS.SchoolName, //学校名称
IdSchool = objvXzGrade_psENS.IdSchool, //学校流水号
Memo = objvXzGrade_psENS.Memo, //备注
};
 return objvXzGrade_psENT;
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
public static void CheckProperty4Condition(this clsvXzGrade_psEN objvXzGrade_psEN)
{
 clsvXzGrade_psBL.vXzGrade_psDA.CheckProperty4Condition(objvXzGrade_psEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvXzGrade_psEN objvXzGrade_psCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvXzGrade_psCond.IsUpdated(convXzGrade_ps.IdGradeBase) == true)
{
string strComparisonOpIdGradeBase = objvXzGrade_psCond.dicFldComparisonOp[convXzGrade_ps.IdGradeBase];
strWhereCond += string.Format(" And {0} {2} '{1}'", convXzGrade_ps.IdGradeBase, objvXzGrade_psCond.IdGradeBase, strComparisonOpIdGradeBase);
}
if (objvXzGrade_psCond.IsUpdated(convXzGrade_ps.GradeBaseId) == true)
{
string strComparisonOpGradeBaseId = objvXzGrade_psCond.dicFldComparisonOp[convXzGrade_ps.GradeBaseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convXzGrade_ps.GradeBaseId, objvXzGrade_psCond.GradeBaseId, strComparisonOpGradeBaseId);
}
if (objvXzGrade_psCond.IsUpdated(convXzGrade_ps.GradeBaseName) == true)
{
string strComparisonOpGradeBaseName = objvXzGrade_psCond.dicFldComparisonOp[convXzGrade_ps.GradeBaseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convXzGrade_ps.GradeBaseName, objvXzGrade_psCond.GradeBaseName, strComparisonOpGradeBaseName);
}
if (objvXzGrade_psCond.IsUpdated(convXzGrade_ps.IsVisible) == true)
{
if (objvXzGrade_psCond.IsVisible == true)
{
strWhereCond += string.Format(" And {0} = '1'", convXzGrade_ps.IsVisible);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convXzGrade_ps.IsVisible);
}
}
if (objvXzGrade_psCond.IsUpdated(convXzGrade_ps.OrderNum) == true)
{
string strComparisonOpOrderNum = objvXzGrade_psCond.dicFldComparisonOp[convXzGrade_ps.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", convXzGrade_ps.OrderNum, objvXzGrade_psCond.OrderNum, strComparisonOpOrderNum);
}
if (objvXzGrade_psCond.IsUpdated(convXzGrade_ps.SchoolId) == true)
{
string strComparisonOpSchoolId = objvXzGrade_psCond.dicFldComparisonOp[convXzGrade_ps.SchoolId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convXzGrade_ps.SchoolId, objvXzGrade_psCond.SchoolId, strComparisonOpSchoolId);
}
if (objvXzGrade_psCond.IsUpdated(convXzGrade_ps.SchoolName) == true)
{
string strComparisonOpSchoolName = objvXzGrade_psCond.dicFldComparisonOp[convXzGrade_ps.SchoolName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convXzGrade_ps.SchoolName, objvXzGrade_psCond.SchoolName, strComparisonOpSchoolName);
}
if (objvXzGrade_psCond.IsUpdated(convXzGrade_ps.IdSchool) == true)
{
string strComparisonOpIdSchool = objvXzGrade_psCond.dicFldComparisonOp[convXzGrade_ps.IdSchool];
strWhereCond += string.Format(" And {0} {2} '{1}'", convXzGrade_ps.IdSchool, objvXzGrade_psCond.IdSchool, strComparisonOpIdSchool);
}
if (objvXzGrade_psCond.IsUpdated(convXzGrade_ps.Memo) == true)
{
string strComparisonOpMemo = objvXzGrade_psCond.dicFldComparisonOp[convXzGrade_ps.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convXzGrade_ps.Memo, objvXzGrade_psCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vXzGrade_ps
{
public virtual bool UpdRelaTabDate(string strIdGradeBase, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v年级表_ps(vXzGrade_ps)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvXzGrade_psBL
{
public static RelatedActions_vXzGrade_ps relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvXzGrade_psDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvXzGrade_psDA vXzGrade_psDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvXzGrade_psDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvXzGrade_psBL()
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
if (string.IsNullOrEmpty(clsvXzGrade_psEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvXzGrade_psEN._ConnectString);
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
public static DataTable GetDataTable_vXzGrade_ps(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vXzGrade_psDA.GetDataTable_vXzGrade_ps(strWhereCond);
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
objDT = vXzGrade_psDA.GetDataTable(strWhereCond);
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
objDT = vXzGrade_psDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vXzGrade_psDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vXzGrade_psDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vXzGrade_psDA.GetDataTable_Top(objTopPara);
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
objDT = vXzGrade_psDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vXzGrade_psDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vXzGrade_psDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
public static List<clsvXzGrade_psEN> GetObjLstByIdGradeBaseLst(List<string> arrIdGradeBaseLst)
{
List<clsvXzGrade_psEN> arrObjLst = new List<clsvXzGrade_psEN>(); 
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
	clsvXzGrade_psEN objvXzGrade_psEN = new clsvXzGrade_psEN();
try
{
objvXzGrade_psEN.IdGradeBase = objRow[convXzGrade_ps.IdGradeBase].ToString().Trim(); //年级流水号
objvXzGrade_psEN.GradeBaseId = objRow[convXzGrade_ps.GradeBaseId].ToString().Trim(); //年级代号
objvXzGrade_psEN.GradeBaseName = objRow[convXzGrade_ps.GradeBaseName].ToString().Trim(); //年级名称
objvXzGrade_psEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convXzGrade_ps.IsVisible].ToString().Trim()); //是否显示
objvXzGrade_psEN.OrderNum = objRow[convXzGrade_ps.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convXzGrade_ps.OrderNum].ToString().Trim()); //序号
objvXzGrade_psEN.SchoolId = objRow[convXzGrade_ps.SchoolId].ToString().Trim(); //学校编号
objvXzGrade_psEN.SchoolName = objRow[convXzGrade_ps.SchoolName].ToString().Trim(); //学校名称
objvXzGrade_psEN.IdSchool = objRow[convXzGrade_ps.IdSchool] == DBNull.Value ? null : objRow[convXzGrade_ps.IdSchool].ToString().Trim(); //学校流水号
objvXzGrade_psEN.Memo = objRow[convXzGrade_ps.Memo] == DBNull.Value ? null : objRow[convXzGrade_ps.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvXzGrade_psEN.IdGradeBase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvXzGrade_psEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrIdGradeBaseLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvXzGrade_psEN> GetObjLstByIdGradeBaseLstCache(List<string> arrIdGradeBaseLst)
{
string strKey = string.Format("{0}", clsvXzGrade_psEN._CurrTabName);
List<clsvXzGrade_psEN> arrvXzGrade_psObjLstCache = GetObjLstCache();
IEnumerable <clsvXzGrade_psEN> arrvXzGrade_psObjLst_Sel =
arrvXzGrade_psObjLstCache
.Where(x => arrIdGradeBaseLst.Contains(x.IdGradeBase));
return arrvXzGrade_psObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvXzGrade_psEN> GetObjLst(string strWhereCond)
{
List<clsvXzGrade_psEN> arrObjLst = new List<clsvXzGrade_psEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvXzGrade_psEN objvXzGrade_psEN = new clsvXzGrade_psEN();
try
{
objvXzGrade_psEN.IdGradeBase = objRow[convXzGrade_ps.IdGradeBase].ToString().Trim(); //年级流水号
objvXzGrade_psEN.GradeBaseId = objRow[convXzGrade_ps.GradeBaseId].ToString().Trim(); //年级代号
objvXzGrade_psEN.GradeBaseName = objRow[convXzGrade_ps.GradeBaseName].ToString().Trim(); //年级名称
objvXzGrade_psEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convXzGrade_ps.IsVisible].ToString().Trim()); //是否显示
objvXzGrade_psEN.OrderNum = objRow[convXzGrade_ps.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convXzGrade_ps.OrderNum].ToString().Trim()); //序号
objvXzGrade_psEN.SchoolId = objRow[convXzGrade_ps.SchoolId].ToString().Trim(); //学校编号
objvXzGrade_psEN.SchoolName = objRow[convXzGrade_ps.SchoolName].ToString().Trim(); //学校名称
objvXzGrade_psEN.IdSchool = objRow[convXzGrade_ps.IdSchool] == DBNull.Value ? null : objRow[convXzGrade_ps.IdSchool].ToString().Trim(); //学校流水号
objvXzGrade_psEN.Memo = objRow[convXzGrade_ps.Memo] == DBNull.Value ? null : objRow[convXzGrade_ps.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvXzGrade_psEN.IdGradeBase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvXzGrade_psEN);
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
public static List<clsvXzGrade_psEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvXzGrade_psEN> arrObjLst = new List<clsvXzGrade_psEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvXzGrade_psEN objvXzGrade_psEN = new clsvXzGrade_psEN();
try
{
objvXzGrade_psEN.IdGradeBase = objRow[convXzGrade_ps.IdGradeBase].ToString().Trim(); //年级流水号
objvXzGrade_psEN.GradeBaseId = objRow[convXzGrade_ps.GradeBaseId].ToString().Trim(); //年级代号
objvXzGrade_psEN.GradeBaseName = objRow[convXzGrade_ps.GradeBaseName].ToString().Trim(); //年级名称
objvXzGrade_psEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convXzGrade_ps.IsVisible].ToString().Trim()); //是否显示
objvXzGrade_psEN.OrderNum = objRow[convXzGrade_ps.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convXzGrade_ps.OrderNum].ToString().Trim()); //序号
objvXzGrade_psEN.SchoolId = objRow[convXzGrade_ps.SchoolId].ToString().Trim(); //学校编号
objvXzGrade_psEN.SchoolName = objRow[convXzGrade_ps.SchoolName].ToString().Trim(); //学校名称
objvXzGrade_psEN.IdSchool = objRow[convXzGrade_ps.IdSchool] == DBNull.Value ? null : objRow[convXzGrade_ps.IdSchool].ToString().Trim(); //学校流水号
objvXzGrade_psEN.Memo = objRow[convXzGrade_ps.Memo] == DBNull.Value ? null : objRow[convXzGrade_ps.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvXzGrade_psEN.IdGradeBase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvXzGrade_psEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvXzGrade_psCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvXzGrade_psEN> GetSubObjLstCache(clsvXzGrade_psEN objvXzGrade_psCond)
{
List<clsvXzGrade_psEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvXzGrade_psEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convXzGrade_ps.AttributeName)
{
if (objvXzGrade_psCond.IsUpdated(strFldName) == false) continue;
if (objvXzGrade_psCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvXzGrade_psCond[strFldName].ToString());
}
else
{
if (objvXzGrade_psCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvXzGrade_psCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvXzGrade_psCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvXzGrade_psCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvXzGrade_psCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvXzGrade_psCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvXzGrade_psCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvXzGrade_psCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvXzGrade_psCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvXzGrade_psCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvXzGrade_psCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvXzGrade_psCond[strFldName]));
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
public static List<clsvXzGrade_psEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvXzGrade_psEN> arrObjLst = new List<clsvXzGrade_psEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvXzGrade_psEN objvXzGrade_psEN = new clsvXzGrade_psEN();
try
{
objvXzGrade_psEN.IdGradeBase = objRow[convXzGrade_ps.IdGradeBase].ToString().Trim(); //年级流水号
objvXzGrade_psEN.GradeBaseId = objRow[convXzGrade_ps.GradeBaseId].ToString().Trim(); //年级代号
objvXzGrade_psEN.GradeBaseName = objRow[convXzGrade_ps.GradeBaseName].ToString().Trim(); //年级名称
objvXzGrade_psEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convXzGrade_ps.IsVisible].ToString().Trim()); //是否显示
objvXzGrade_psEN.OrderNum = objRow[convXzGrade_ps.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convXzGrade_ps.OrderNum].ToString().Trim()); //序号
objvXzGrade_psEN.SchoolId = objRow[convXzGrade_ps.SchoolId].ToString().Trim(); //学校编号
objvXzGrade_psEN.SchoolName = objRow[convXzGrade_ps.SchoolName].ToString().Trim(); //学校名称
objvXzGrade_psEN.IdSchool = objRow[convXzGrade_ps.IdSchool] == DBNull.Value ? null : objRow[convXzGrade_ps.IdSchool].ToString().Trim(); //学校流水号
objvXzGrade_psEN.Memo = objRow[convXzGrade_ps.Memo] == DBNull.Value ? null : objRow[convXzGrade_ps.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvXzGrade_psEN.IdGradeBase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvXzGrade_psEN);
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
public static List<clsvXzGrade_psEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvXzGrade_psEN> arrObjLst = new List<clsvXzGrade_psEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvXzGrade_psEN objvXzGrade_psEN = new clsvXzGrade_psEN();
try
{
objvXzGrade_psEN.IdGradeBase = objRow[convXzGrade_ps.IdGradeBase].ToString().Trim(); //年级流水号
objvXzGrade_psEN.GradeBaseId = objRow[convXzGrade_ps.GradeBaseId].ToString().Trim(); //年级代号
objvXzGrade_psEN.GradeBaseName = objRow[convXzGrade_ps.GradeBaseName].ToString().Trim(); //年级名称
objvXzGrade_psEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convXzGrade_ps.IsVisible].ToString().Trim()); //是否显示
objvXzGrade_psEN.OrderNum = objRow[convXzGrade_ps.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convXzGrade_ps.OrderNum].ToString().Trim()); //序号
objvXzGrade_psEN.SchoolId = objRow[convXzGrade_ps.SchoolId].ToString().Trim(); //学校编号
objvXzGrade_psEN.SchoolName = objRow[convXzGrade_ps.SchoolName].ToString().Trim(); //学校名称
objvXzGrade_psEN.IdSchool = objRow[convXzGrade_ps.IdSchool] == DBNull.Value ? null : objRow[convXzGrade_ps.IdSchool].ToString().Trim(); //学校流水号
objvXzGrade_psEN.Memo = objRow[convXzGrade_ps.Memo] == DBNull.Value ? null : objRow[convXzGrade_ps.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvXzGrade_psEN.IdGradeBase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvXzGrade_psEN);
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
List<clsvXzGrade_psEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvXzGrade_psEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvXzGrade_psEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvXzGrade_psEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvXzGrade_psEN> arrObjLst = new List<clsvXzGrade_psEN>(); 
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
	clsvXzGrade_psEN objvXzGrade_psEN = new clsvXzGrade_psEN();
try
{
objvXzGrade_psEN.IdGradeBase = objRow[convXzGrade_ps.IdGradeBase].ToString().Trim(); //年级流水号
objvXzGrade_psEN.GradeBaseId = objRow[convXzGrade_ps.GradeBaseId].ToString().Trim(); //年级代号
objvXzGrade_psEN.GradeBaseName = objRow[convXzGrade_ps.GradeBaseName].ToString().Trim(); //年级名称
objvXzGrade_psEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convXzGrade_ps.IsVisible].ToString().Trim()); //是否显示
objvXzGrade_psEN.OrderNum = objRow[convXzGrade_ps.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convXzGrade_ps.OrderNum].ToString().Trim()); //序号
objvXzGrade_psEN.SchoolId = objRow[convXzGrade_ps.SchoolId].ToString().Trim(); //学校编号
objvXzGrade_psEN.SchoolName = objRow[convXzGrade_ps.SchoolName].ToString().Trim(); //学校名称
objvXzGrade_psEN.IdSchool = objRow[convXzGrade_ps.IdSchool] == DBNull.Value ? null : objRow[convXzGrade_ps.IdSchool].ToString().Trim(); //学校流水号
objvXzGrade_psEN.Memo = objRow[convXzGrade_ps.Memo] == DBNull.Value ? null : objRow[convXzGrade_ps.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvXzGrade_psEN.IdGradeBase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvXzGrade_psEN);
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
public static List<clsvXzGrade_psEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvXzGrade_psEN> arrObjLst = new List<clsvXzGrade_psEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvXzGrade_psEN objvXzGrade_psEN = new clsvXzGrade_psEN();
try
{
objvXzGrade_psEN.IdGradeBase = objRow[convXzGrade_ps.IdGradeBase].ToString().Trim(); //年级流水号
objvXzGrade_psEN.GradeBaseId = objRow[convXzGrade_ps.GradeBaseId].ToString().Trim(); //年级代号
objvXzGrade_psEN.GradeBaseName = objRow[convXzGrade_ps.GradeBaseName].ToString().Trim(); //年级名称
objvXzGrade_psEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convXzGrade_ps.IsVisible].ToString().Trim()); //是否显示
objvXzGrade_psEN.OrderNum = objRow[convXzGrade_ps.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convXzGrade_ps.OrderNum].ToString().Trim()); //序号
objvXzGrade_psEN.SchoolId = objRow[convXzGrade_ps.SchoolId].ToString().Trim(); //学校编号
objvXzGrade_psEN.SchoolName = objRow[convXzGrade_ps.SchoolName].ToString().Trim(); //学校名称
objvXzGrade_psEN.IdSchool = objRow[convXzGrade_ps.IdSchool] == DBNull.Value ? null : objRow[convXzGrade_ps.IdSchool].ToString().Trim(); //学校流水号
objvXzGrade_psEN.Memo = objRow[convXzGrade_ps.Memo] == DBNull.Value ? null : objRow[convXzGrade_ps.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvXzGrade_psEN.IdGradeBase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvXzGrade_psEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvXzGrade_psEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvXzGrade_psEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvXzGrade_psEN> arrObjLst = new List<clsvXzGrade_psEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvXzGrade_psEN objvXzGrade_psEN = new clsvXzGrade_psEN();
try
{
objvXzGrade_psEN.IdGradeBase = objRow[convXzGrade_ps.IdGradeBase].ToString().Trim(); //年级流水号
objvXzGrade_psEN.GradeBaseId = objRow[convXzGrade_ps.GradeBaseId].ToString().Trim(); //年级代号
objvXzGrade_psEN.GradeBaseName = objRow[convXzGrade_ps.GradeBaseName].ToString().Trim(); //年级名称
objvXzGrade_psEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convXzGrade_ps.IsVisible].ToString().Trim()); //是否显示
objvXzGrade_psEN.OrderNum = objRow[convXzGrade_ps.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convXzGrade_ps.OrderNum].ToString().Trim()); //序号
objvXzGrade_psEN.SchoolId = objRow[convXzGrade_ps.SchoolId].ToString().Trim(); //学校编号
objvXzGrade_psEN.SchoolName = objRow[convXzGrade_ps.SchoolName].ToString().Trim(); //学校名称
objvXzGrade_psEN.IdSchool = objRow[convXzGrade_ps.IdSchool] == DBNull.Value ? null : objRow[convXzGrade_ps.IdSchool].ToString().Trim(); //学校流水号
objvXzGrade_psEN.Memo = objRow[convXzGrade_ps.Memo] == DBNull.Value ? null : objRow[convXzGrade_ps.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvXzGrade_psEN.IdGradeBase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvXzGrade_psEN);
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
public static List<clsvXzGrade_psEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvXzGrade_psEN> arrObjLst = new List<clsvXzGrade_psEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvXzGrade_psEN objvXzGrade_psEN = new clsvXzGrade_psEN();
try
{
objvXzGrade_psEN.IdGradeBase = objRow[convXzGrade_ps.IdGradeBase].ToString().Trim(); //年级流水号
objvXzGrade_psEN.GradeBaseId = objRow[convXzGrade_ps.GradeBaseId].ToString().Trim(); //年级代号
objvXzGrade_psEN.GradeBaseName = objRow[convXzGrade_ps.GradeBaseName].ToString().Trim(); //年级名称
objvXzGrade_psEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convXzGrade_ps.IsVisible].ToString().Trim()); //是否显示
objvXzGrade_psEN.OrderNum = objRow[convXzGrade_ps.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convXzGrade_ps.OrderNum].ToString().Trim()); //序号
objvXzGrade_psEN.SchoolId = objRow[convXzGrade_ps.SchoolId].ToString().Trim(); //学校编号
objvXzGrade_psEN.SchoolName = objRow[convXzGrade_ps.SchoolName].ToString().Trim(); //学校名称
objvXzGrade_psEN.IdSchool = objRow[convXzGrade_ps.IdSchool] == DBNull.Value ? null : objRow[convXzGrade_ps.IdSchool].ToString().Trim(); //学校流水号
objvXzGrade_psEN.Memo = objRow[convXzGrade_ps.Memo] == DBNull.Value ? null : objRow[convXzGrade_ps.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvXzGrade_psEN.IdGradeBase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvXzGrade_psEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvXzGrade_psEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvXzGrade_psEN> arrObjLst = new List<clsvXzGrade_psEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvXzGrade_psEN objvXzGrade_psEN = new clsvXzGrade_psEN();
try
{
objvXzGrade_psEN.IdGradeBase = objRow[convXzGrade_ps.IdGradeBase].ToString().Trim(); //年级流水号
objvXzGrade_psEN.GradeBaseId = objRow[convXzGrade_ps.GradeBaseId].ToString().Trim(); //年级代号
objvXzGrade_psEN.GradeBaseName = objRow[convXzGrade_ps.GradeBaseName].ToString().Trim(); //年级名称
objvXzGrade_psEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convXzGrade_ps.IsVisible].ToString().Trim()); //是否显示
objvXzGrade_psEN.OrderNum = objRow[convXzGrade_ps.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convXzGrade_ps.OrderNum].ToString().Trim()); //序号
objvXzGrade_psEN.SchoolId = objRow[convXzGrade_ps.SchoolId].ToString().Trim(); //学校编号
objvXzGrade_psEN.SchoolName = objRow[convXzGrade_ps.SchoolName].ToString().Trim(); //学校名称
objvXzGrade_psEN.IdSchool = objRow[convXzGrade_ps.IdSchool] == DBNull.Value ? null : objRow[convXzGrade_ps.IdSchool].ToString().Trim(); //学校流水号
objvXzGrade_psEN.Memo = objRow[convXzGrade_ps.Memo] == DBNull.Value ? null : objRow[convXzGrade_ps.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvXzGrade_psEN.IdGradeBase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvXzGrade_psEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvXzGrade_psEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvXzGrade_ps(ref clsvXzGrade_psEN objvXzGrade_psEN)
{
bool bolResult = vXzGrade_psDA.GetvXzGrade_ps(ref objvXzGrade_psEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strIdGradeBase">表关键字</param>
 /// <returns>表对象</returns>
public static clsvXzGrade_psEN GetObjByIdGradeBase(string strIdGradeBase)
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
clsvXzGrade_psEN objvXzGrade_psEN = vXzGrade_psDA.GetObjByIdGradeBase(strIdGradeBase);
return objvXzGrade_psEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvXzGrade_psEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvXzGrade_psEN objvXzGrade_psEN = vXzGrade_psDA.GetFirstObj(strWhereCond);
 return objvXzGrade_psEN;
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
public static clsvXzGrade_psEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvXzGrade_psEN objvXzGrade_psEN = vXzGrade_psDA.GetObjByDataRow(objRow);
 return objvXzGrade_psEN;
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
public static clsvXzGrade_psEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvXzGrade_psEN objvXzGrade_psEN = vXzGrade_psDA.GetObjByDataRow(objRow);
 return objvXzGrade_psEN;
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
 /// <param name = "lstvXzGrade_psObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvXzGrade_psEN GetObjByIdGradeBaseFromList(string strIdGradeBase, List<clsvXzGrade_psEN> lstvXzGrade_psObjLst)
{
foreach (clsvXzGrade_psEN objvXzGrade_psEN in lstvXzGrade_psObjLst)
{
if (objvXzGrade_psEN.IdGradeBase == strIdGradeBase)
{
return objvXzGrade_psEN;
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
 strIdGradeBase = new clsvXzGrade_psDA().GetFirstID(strWhereCond);
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
 arrList = vXzGrade_psDA.GetID(strWhereCond);
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
bool bolIsExist = vXzGrade_psDA.IsExistCondRec(strWhereCond);
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
bool bolIsExist = vXzGrade_psDA.IsExist(strIdGradeBase);
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
 bolIsExist = clsvXzGrade_psDA.IsExistTable();
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
 bolIsExist = vXzGrade_psDA.IsExistTable(strTabName);
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
 /// <param name = "objvXzGrade_psENS">源对象</param>
 /// <param name = "objvXzGrade_psENT">目标对象</param>
 public static void CopyTo(clsvXzGrade_psEN objvXzGrade_psENS, clsvXzGrade_psEN objvXzGrade_psENT)
{
try
{
objvXzGrade_psENT.IdGradeBase = objvXzGrade_psENS.IdGradeBase; //年级流水号
objvXzGrade_psENT.GradeBaseId = objvXzGrade_psENS.GradeBaseId; //年级代号
objvXzGrade_psENT.GradeBaseName = objvXzGrade_psENS.GradeBaseName; //年级名称
objvXzGrade_psENT.IsVisible = objvXzGrade_psENS.IsVisible; //是否显示
objvXzGrade_psENT.OrderNum = objvXzGrade_psENS.OrderNum; //序号
objvXzGrade_psENT.SchoolId = objvXzGrade_psENS.SchoolId; //学校编号
objvXzGrade_psENT.SchoolName = objvXzGrade_psENS.SchoolName; //学校名称
objvXzGrade_psENT.IdSchool = objvXzGrade_psENS.IdSchool; //学校流水号
objvXzGrade_psENT.Memo = objvXzGrade_psENS.Memo; //备注
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
 /// <param name = "objvXzGrade_psEN">源简化对象</param>
 public static void SetUpdFlag(clsvXzGrade_psEN objvXzGrade_psEN)
{
try
{
objvXzGrade_psEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvXzGrade_psEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convXzGrade_ps.IdGradeBase, new clsStrCompareIgnoreCase())  ==  true)
{
objvXzGrade_psEN.IdGradeBase = objvXzGrade_psEN.IdGradeBase; //年级流水号
}
if (arrFldSet.Contains(convXzGrade_ps.GradeBaseId, new clsStrCompareIgnoreCase())  ==  true)
{
objvXzGrade_psEN.GradeBaseId = objvXzGrade_psEN.GradeBaseId; //年级代号
}
if (arrFldSet.Contains(convXzGrade_ps.GradeBaseName, new clsStrCompareIgnoreCase())  ==  true)
{
objvXzGrade_psEN.GradeBaseName = objvXzGrade_psEN.GradeBaseName; //年级名称
}
if (arrFldSet.Contains(convXzGrade_ps.IsVisible, new clsStrCompareIgnoreCase())  ==  true)
{
objvXzGrade_psEN.IsVisible = objvXzGrade_psEN.IsVisible; //是否显示
}
if (arrFldSet.Contains(convXzGrade_ps.OrderNum, new clsStrCompareIgnoreCase())  ==  true)
{
objvXzGrade_psEN.OrderNum = objvXzGrade_psEN.OrderNum; //序号
}
if (arrFldSet.Contains(convXzGrade_ps.SchoolId, new clsStrCompareIgnoreCase())  ==  true)
{
objvXzGrade_psEN.SchoolId = objvXzGrade_psEN.SchoolId; //学校编号
}
if (arrFldSet.Contains(convXzGrade_ps.SchoolName, new clsStrCompareIgnoreCase())  ==  true)
{
objvXzGrade_psEN.SchoolName = objvXzGrade_psEN.SchoolName; //学校名称
}
if (arrFldSet.Contains(convXzGrade_ps.IdSchool, new clsStrCompareIgnoreCase())  ==  true)
{
objvXzGrade_psEN.IdSchool = objvXzGrade_psEN.IdSchool == "[null]" ? null :  objvXzGrade_psEN.IdSchool; //学校流水号
}
if (arrFldSet.Contains(convXzGrade_ps.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvXzGrade_psEN.Memo = objvXzGrade_psEN.Memo == "[null]" ? null :  objvXzGrade_psEN.Memo; //备注
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
 /// <param name = "objvXzGrade_psEN">源简化对象</param>
 public static void AccessFldValueNull(clsvXzGrade_psEN objvXzGrade_psEN)
{
try
{
if (objvXzGrade_psEN.IdSchool == "[null]") objvXzGrade_psEN.IdSchool = null; //学校流水号
if (objvXzGrade_psEN.Memo == "[null]") objvXzGrade_psEN.Memo = null; //备注
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
public static void CheckProperty4Condition(clsvXzGrade_psEN objvXzGrade_psEN)
{
 vXzGrade_psDA.CheckProperty4Condition(objvXzGrade_psEN);
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
string strCondition = string.Format("1 =1 Order By {0}", convXzGrade_ps.IdGradeBase); 
List<clsvXzGrade_psEN> arrObjLst = clsvXzGrade_psBL.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsvXzGrade_psEN objvXzGrade_psEN = new clsvXzGrade_psEN()
{
IdGradeBase = "0",
GradeBaseName = "选[v年级表_ps]..."
};
arrObjLst.Insert(0, objvXzGrade_psEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = convXzGrade_ps.IdGradeBase;
objComboBox.DisplayMember = convXzGrade_ps.GradeBaseName;
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
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[v年级表_ps]...","0");
string strCondition = string.Format("1 =1 Order By {0}", convXzGrade_ps.IdGradeBase); 
IEnumerable<clsvXzGrade_psEN> arrObjLst = clsvXzGrade_psBL.GetObjLst(strCondition);
objDDL.DataValueField = convXzGrade_ps.IdGradeBase;
objDDL.DataTextField = convXzGrade_ps.GradeBaseName;
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
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[v年级表_ps]...","0");
List<clsvXzGrade_psEN> arrvXzGrade_psObjLst = GetAllvXzGrade_psObjLstCache(); 
objDDL.DataValueField = convXzGrade_ps.IdGradeBase;
objDDL.DataTextField = convXzGrade_ps.GradeBaseName;
objDDL.DataSource = arrvXzGrade_psObjLst;
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
if (clsXzSchoolBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzSchoolBL没有刷新缓存机制(clsXzSchoolBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzGrade_psBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzGrade_psBL没有刷新缓存机制(clsXzGrade_psBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by IdGradeBase");
//if (arrvXzGrade_psObjLstCache == null)
//{
//arrvXzGrade_psObjLstCache = vXzGrade_psDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strIdGradeBase">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvXzGrade_psEN GetObjByIdGradeBaseCache(string strIdGradeBase)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvXzGrade_psEN._CurrTabName);
List<clsvXzGrade_psEN> arrvXzGrade_psObjLstCache = GetObjLstCache();
IEnumerable <clsvXzGrade_psEN> arrvXzGrade_psObjLst_Sel =
arrvXzGrade_psObjLstCache
.Where(x=> x.IdGradeBase == strIdGradeBase 
);
if (arrvXzGrade_psObjLst_Sel.Count() == 0)
{
   clsvXzGrade_psEN obj = clsvXzGrade_psBL.GetObjByIdGradeBase(strIdGradeBase);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvXzGrade_psObjLst_Sel.First();
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
clsvXzGrade_psEN objvXzGrade_ps = GetObjByIdGradeBaseCache(strIdGradeBase);
if (objvXzGrade_ps == null) return "";
return objvXzGrade_ps.GradeBaseName;
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
clsvXzGrade_psEN objvXzGrade_ps = GetObjByIdGradeBaseCache(strIdGradeBase);
if (objvXzGrade_ps == null) return "";
return objvXzGrade_ps.GradeBaseName;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvXzGrade_psEN> GetAllvXzGrade_psObjLstCache()
{
//获取缓存中的对象列表
List<clsvXzGrade_psEN> arrvXzGrade_psObjLstCache = GetObjLstCache(); 
return arrvXzGrade_psObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvXzGrade_psEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvXzGrade_psEN._CurrTabName);
List<clsvXzGrade_psEN> arrvXzGrade_psObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvXzGrade_psObjLstCache;
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
string strKey = string.Format("{0}", clsvXzGrade_psEN._CurrTabName);
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
if (strInFldName != convXzGrade_ps.IdGradeBase)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convXzGrade_ps.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convXzGrade_ps.AttributeName));
throw new Exception(strMsg);
}
var objvXzGrade_ps = clsvXzGrade_psBL.GetObjByIdGradeBaseCache(strIdGradeBase);
if (objvXzGrade_ps == null) return "";
return objvXzGrade_ps[strOutFldName].ToString();
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
int intRecCount = clsvXzGrade_psDA.GetRecCount(strTabName);
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
int intRecCount = clsvXzGrade_psDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvXzGrade_psDA.GetRecCount();
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
int intRecCount = clsvXzGrade_psDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvXzGrade_psCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvXzGrade_psEN objvXzGrade_psCond)
{
List<clsvXzGrade_psEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvXzGrade_psEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convXzGrade_ps.AttributeName)
{
if (objvXzGrade_psCond.IsUpdated(strFldName) == false) continue;
if (objvXzGrade_psCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvXzGrade_psCond[strFldName].ToString());
}
else
{
if (objvXzGrade_psCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvXzGrade_psCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvXzGrade_psCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvXzGrade_psCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvXzGrade_psCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvXzGrade_psCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvXzGrade_psCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvXzGrade_psCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvXzGrade_psCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvXzGrade_psCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvXzGrade_psCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvXzGrade_psCond[strFldName]));
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
 List<string> arrList = clsvXzGrade_psDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vXzGrade_psDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vXzGrade_psDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}