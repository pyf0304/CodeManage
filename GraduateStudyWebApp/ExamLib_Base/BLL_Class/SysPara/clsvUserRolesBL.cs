
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvUserRolesBL
 表名:vUserRoles(01120026)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:50:26
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
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
public static class  clsvUserRolesBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strRoleId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvUserRolesEN GetObj(this K_RoleId_vUserRoles myKey)
{
clsvUserRolesEN objvUserRolesEN = clsvUserRolesBL.vUserRolesDA.GetObjByRoleId(myKey.Value);
return objvUserRolesEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserRolesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUserRolesEN SetRoleId(this clsvUserRolesEN objvUserRolesEN, string strRoleId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRoleId, 8, convUserRoles.RoleId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strRoleId, 8, convUserRoles.RoleId);
}
objvUserRolesEN.RoleId = strRoleId; //角色Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUserRolesEN.dicFldComparisonOp.ContainsKey(convUserRoles.RoleId) == false)
{
objvUserRolesEN.dicFldComparisonOp.Add(convUserRoles.RoleId, strComparisonOp);
}
else
{
objvUserRolesEN.dicFldComparisonOp[convUserRoles.RoleId] = strComparisonOp;
}
}
return objvUserRolesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserRolesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUserRolesEN SetRoleName(this clsvUserRolesEN objvUserRolesEN, string strRoleName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRoleName, 100, convUserRoles.RoleName);
}
objvUserRolesEN.RoleName = strRoleName; //角色名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUserRolesEN.dicFldComparisonOp.ContainsKey(convUserRoles.RoleName) == false)
{
objvUserRolesEN.dicFldComparisonOp.Add(convUserRoles.RoleName, strComparisonOp);
}
else
{
objvUserRolesEN.dicFldComparisonOp[convUserRoles.RoleName] = strComparisonOp;
}
}
return objvUserRolesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserRolesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUserRolesEN SetQuestionnaireSetId(this clsvUserRolesEN objvUserRolesEN, string strQuestionnaireSetId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strQuestionnaireSetId, 4, convUserRoles.QuestionnaireSetId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strQuestionnaireSetId, 4, convUserRoles.QuestionnaireSetId);
}
objvUserRolesEN.QuestionnaireSetId = strQuestionnaireSetId; //问卷集ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUserRolesEN.dicFldComparisonOp.ContainsKey(convUserRoles.QuestionnaireSetId) == false)
{
objvUserRolesEN.dicFldComparisonOp.Add(convUserRoles.QuestionnaireSetId, strComparisonOp);
}
else
{
objvUserRolesEN.dicFldComparisonOp[convUserRoles.QuestionnaireSetId] = strComparisonOp;
}
}
return objvUserRolesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserRolesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUserRolesEN SetQuestionnaireSetName(this clsvUserRolesEN objvUserRolesEN, string strQuestionnaireSetName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strQuestionnaireSetName, 50, convUserRoles.QuestionnaireSetName);
}
objvUserRolesEN.QuestionnaireSetName = strQuestionnaireSetName; //问卷集名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUserRolesEN.dicFldComparisonOp.ContainsKey(convUserRoles.QuestionnaireSetName) == false)
{
objvUserRolesEN.dicFldComparisonOp.Add(convUserRoles.QuestionnaireSetName, strComparisonOp);
}
else
{
objvUserRolesEN.dicFldComparisonOp[convUserRoles.QuestionnaireSetName] = strComparisonOp;
}
}
return objvUserRolesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserRolesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUserRolesEN SetPrjId(this clsvUserRolesEN objvUserRolesEN, string strPrjId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjId, 4, convUserRoles.PrjId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, convUserRoles.PrjId);
}
objvUserRolesEN.PrjId = strPrjId; //PrjId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUserRolesEN.dicFldComparisonOp.ContainsKey(convUserRoles.PrjId) == false)
{
objvUserRolesEN.dicFldComparisonOp.Add(convUserRoles.PrjId, strComparisonOp);
}
else
{
objvUserRolesEN.dicFldComparisonOp[convUserRoles.PrjId] = strComparisonOp;
}
}
return objvUserRolesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserRolesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUserRolesEN SetMemo(this clsvUserRolesEN objvUserRolesEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convUserRoles.Memo);
}
objvUserRolesEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUserRolesEN.dicFldComparisonOp.ContainsKey(convUserRoles.Memo) == false)
{
objvUserRolesEN.dicFldComparisonOp.Add(convUserRoles.Memo, strComparisonOp);
}
else
{
objvUserRolesEN.dicFldComparisonOp[convUserRoles.Memo] = strComparisonOp;
}
}
return objvUserRolesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserRolesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUserRolesEN SetIsInUse(this clsvUserRolesEN objvUserRolesEN, bool bolIsInUse, string strComparisonOp="")
	{
objvUserRolesEN.IsInUse = bolIsInUse; //IsInUse
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUserRolesEN.dicFldComparisonOp.ContainsKey(convUserRoles.IsInUse) == false)
{
objvUserRolesEN.dicFldComparisonOp.Add(convUserRoles.IsInUse, strComparisonOp);
}
else
{
objvUserRolesEN.dicFldComparisonOp[convUserRoles.IsInUse] = strComparisonOp;
}
}
return objvUserRolesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserRolesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUserRolesEN SetUpdDate(this clsvUserRolesEN objvUserRolesEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convUserRoles.UpdDate);
}
objvUserRolesEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUserRolesEN.dicFldComparisonOp.ContainsKey(convUserRoles.UpdDate) == false)
{
objvUserRolesEN.dicFldComparisonOp.Add(convUserRoles.UpdDate, strComparisonOp);
}
else
{
objvUserRolesEN.dicFldComparisonOp[convUserRoles.UpdDate] = strComparisonOp;
}
}
return objvUserRolesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserRolesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUserRolesEN SetUpdUserId(this clsvUserRolesEN objvUserRolesEN, string strUpdUserId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, convUserRoles.UpdUserId);
}
objvUserRolesEN.UpdUserId = strUpdUserId; //修改用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUserRolesEN.dicFldComparisonOp.ContainsKey(convUserRoles.UpdUserId) == false)
{
objvUserRolesEN.dicFldComparisonOp.Add(convUserRoles.UpdUserId, strComparisonOp);
}
else
{
objvUserRolesEN.dicFldComparisonOp[convUserRoles.UpdUserId] = strComparisonOp;
}
}
return objvUserRolesEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvUserRolesENS">源对象</param>
 /// <param name = "objvUserRolesENT">目标对象</param>
 public static void CopyTo(this clsvUserRolesEN objvUserRolesENS, clsvUserRolesEN objvUserRolesENT)
{
try
{
objvUserRolesENT.RoleId = objvUserRolesENS.RoleId; //角色Id
objvUserRolesENT.RoleName = objvUserRolesENS.RoleName; //角色名
objvUserRolesENT.QuestionnaireSetId = objvUserRolesENS.QuestionnaireSetId; //问卷集ID
objvUserRolesENT.QuestionnaireSetName = objvUserRolesENS.QuestionnaireSetName; //问卷集名
objvUserRolesENT.PrjId = objvUserRolesENS.PrjId; //PrjId
objvUserRolesENT.Memo = objvUserRolesENS.Memo; //备注
objvUserRolesENT.IsInUse = objvUserRolesENS.IsInUse; //IsInUse
objvUserRolesENT.UpdDate = objvUserRolesENS.UpdDate; //修改日期
objvUserRolesENT.UpdUserId = objvUserRolesENS.UpdUserId; //修改用户Id
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
 /// <param name = "objvUserRolesENS">源对象</param>
 /// <returns>目标对象=>clsvUserRolesEN:objvUserRolesENT</returns>
 public static clsvUserRolesEN CopyTo(this clsvUserRolesEN objvUserRolesENS)
{
try
{
 clsvUserRolesEN objvUserRolesENT = new clsvUserRolesEN()
{
RoleId = objvUserRolesENS.RoleId, //角色Id
RoleName = objvUserRolesENS.RoleName, //角色名
QuestionnaireSetId = objvUserRolesENS.QuestionnaireSetId, //问卷集ID
QuestionnaireSetName = objvUserRolesENS.QuestionnaireSetName, //问卷集名
PrjId = objvUserRolesENS.PrjId, //PrjId
Memo = objvUserRolesENS.Memo, //备注
IsInUse = objvUserRolesENS.IsInUse, //IsInUse
UpdDate = objvUserRolesENS.UpdDate, //修改日期
UpdUserId = objvUserRolesENS.UpdUserId, //修改用户Id
};
 return objvUserRolesENT;
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
public static void CheckProperty4Condition(this clsvUserRolesEN objvUserRolesEN)
{
 clsvUserRolesBL.vUserRolesDA.CheckProperty4Condition(objvUserRolesEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvUserRolesEN objvUserRolesCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvUserRolesCond.IsUpdated(convUserRoles.RoleId) == true)
{
string strComparisonOpRoleId = objvUserRolesCond.dicFldComparisonOp[convUserRoles.RoleId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUserRoles.RoleId, objvUserRolesCond.RoleId, strComparisonOpRoleId);
}
if (objvUserRolesCond.IsUpdated(convUserRoles.RoleName) == true)
{
string strComparisonOpRoleName = objvUserRolesCond.dicFldComparisonOp[convUserRoles.RoleName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUserRoles.RoleName, objvUserRolesCond.RoleName, strComparisonOpRoleName);
}
if (objvUserRolesCond.IsUpdated(convUserRoles.QuestionnaireSetId) == true)
{
string strComparisonOpQuestionnaireSetId = objvUserRolesCond.dicFldComparisonOp[convUserRoles.QuestionnaireSetId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUserRoles.QuestionnaireSetId, objvUserRolesCond.QuestionnaireSetId, strComparisonOpQuestionnaireSetId);
}
if (objvUserRolesCond.IsUpdated(convUserRoles.QuestionnaireSetName) == true)
{
string strComparisonOpQuestionnaireSetName = objvUserRolesCond.dicFldComparisonOp[convUserRoles.QuestionnaireSetName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUserRoles.QuestionnaireSetName, objvUserRolesCond.QuestionnaireSetName, strComparisonOpQuestionnaireSetName);
}
if (objvUserRolesCond.IsUpdated(convUserRoles.PrjId) == true)
{
string strComparisonOpPrjId = objvUserRolesCond.dicFldComparisonOp[convUserRoles.PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUserRoles.PrjId, objvUserRolesCond.PrjId, strComparisonOpPrjId);
}
if (objvUserRolesCond.IsUpdated(convUserRoles.Memo) == true)
{
string strComparisonOpMemo = objvUserRolesCond.dicFldComparisonOp[convUserRoles.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUserRoles.Memo, objvUserRolesCond.Memo, strComparisonOpMemo);
}
if (objvUserRolesCond.IsUpdated(convUserRoles.IsInUse) == true)
{
if (objvUserRolesCond.IsInUse == true)
{
strWhereCond += string.Format(" And {0} = '1'", convUserRoles.IsInUse);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convUserRoles.IsInUse);
}
}
if (objvUserRolesCond.IsUpdated(convUserRoles.UpdDate) == true)
{
string strComparisonOpUpdDate = objvUserRolesCond.dicFldComparisonOp[convUserRoles.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUserRoles.UpdDate, objvUserRolesCond.UpdDate, strComparisonOpUpdDate);
}
if (objvUserRolesCond.IsUpdated(convUserRoles.UpdUserId) == true)
{
string strComparisonOpUpdUserId = objvUserRolesCond.dicFldComparisonOp[convUserRoles.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUserRoles.UpdUserId, objvUserRolesCond.UpdUserId, strComparisonOpUpdUserId);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vUserRoles
{
public virtual bool UpdRelaTabDate(string strRoleId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v角色(vUserRoles)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvUserRolesBL
{
public static RelatedActions_vUserRoles relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvUserRolesDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvUserRolesDA vUserRolesDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvUserRolesDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvUserRolesBL()
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
if (string.IsNullOrEmpty(clsvUserRolesEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvUserRolesEN._ConnectString);
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
public static DataTable GetDataTable_vUserRoles(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vUserRolesDA.GetDataTable_vUserRoles(strWhereCond);
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
objDT = vUserRolesDA.GetDataTable(strWhereCond);
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
objDT = vUserRolesDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vUserRolesDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vUserRolesDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vUserRolesDA.GetDataTable_Top(objTopPara);
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
objDT = vUserRolesDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vUserRolesDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vUserRolesDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrRoleIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvUserRolesEN> GetObjLstByRoleIdLst(List<string> arrRoleIdLst)
{
List<clsvUserRolesEN> arrObjLst = new List<clsvUserRolesEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrRoleIdLst, true);
 string strWhereCond = string.Format("RoleId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvUserRolesEN objvUserRolesEN = new clsvUserRolesEN();
try
{
objvUserRolesEN.RoleId = objRow[convUserRoles.RoleId].ToString().Trim(); //角色Id
objvUserRolesEN.RoleName = objRow[convUserRoles.RoleName] == DBNull.Value ? null : objRow[convUserRoles.RoleName].ToString().Trim(); //角色名
objvUserRolesEN.QuestionnaireSetId = objRow[convUserRoles.QuestionnaireSetId] == DBNull.Value ? null : objRow[convUserRoles.QuestionnaireSetId].ToString().Trim(); //问卷集ID
objvUserRolesEN.QuestionnaireSetName = objRow[convUserRoles.QuestionnaireSetName] == DBNull.Value ? null : objRow[convUserRoles.QuestionnaireSetName].ToString().Trim(); //问卷集名
objvUserRolesEN.PrjId = objRow[convUserRoles.PrjId] == DBNull.Value ? null : objRow[convUserRoles.PrjId].ToString().Trim(); //PrjId
objvUserRolesEN.Memo = objRow[convUserRoles.Memo] == DBNull.Value ? null : objRow[convUserRoles.Memo].ToString().Trim(); //备注
objvUserRolesEN.IsInUse = clsEntityBase2.TransNullToBool_S(objRow[convUserRoles.IsInUse].ToString().Trim()); //IsInUse
objvUserRolesEN.UpdDate = objRow[convUserRoles.UpdDate] == DBNull.Value ? null : objRow[convUserRoles.UpdDate].ToString().Trim(); //修改日期
objvUserRolesEN.UpdUserId = objRow[convUserRoles.UpdUserId] == DBNull.Value ? null : objRow[convUserRoles.UpdUserId].ToString().Trim(); //修改用户Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvUserRolesEN.RoleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvUserRolesEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrRoleIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvUserRolesEN> GetObjLstByRoleIdLstCache(List<string> arrRoleIdLst)
{
string strKey = string.Format("{0}", clsvUserRolesEN._CurrTabName);
List<clsvUserRolesEN> arrvUserRolesObjLstCache = GetObjLstCache();
IEnumerable <clsvUserRolesEN> arrvUserRolesObjLst_Sel =
arrvUserRolesObjLstCache
.Where(x => arrRoleIdLst.Contains(x.RoleId));
return arrvUserRolesObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvUserRolesEN> GetObjLst(string strWhereCond)
{
List<clsvUserRolesEN> arrObjLst = new List<clsvUserRolesEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvUserRolesEN objvUserRolesEN = new clsvUserRolesEN();
try
{
objvUserRolesEN.RoleId = objRow[convUserRoles.RoleId].ToString().Trim(); //角色Id
objvUserRolesEN.RoleName = objRow[convUserRoles.RoleName] == DBNull.Value ? null : objRow[convUserRoles.RoleName].ToString().Trim(); //角色名
objvUserRolesEN.QuestionnaireSetId = objRow[convUserRoles.QuestionnaireSetId] == DBNull.Value ? null : objRow[convUserRoles.QuestionnaireSetId].ToString().Trim(); //问卷集ID
objvUserRolesEN.QuestionnaireSetName = objRow[convUserRoles.QuestionnaireSetName] == DBNull.Value ? null : objRow[convUserRoles.QuestionnaireSetName].ToString().Trim(); //问卷集名
objvUserRolesEN.PrjId = objRow[convUserRoles.PrjId] == DBNull.Value ? null : objRow[convUserRoles.PrjId].ToString().Trim(); //PrjId
objvUserRolesEN.Memo = objRow[convUserRoles.Memo] == DBNull.Value ? null : objRow[convUserRoles.Memo].ToString().Trim(); //备注
objvUserRolesEN.IsInUse = clsEntityBase2.TransNullToBool_S(objRow[convUserRoles.IsInUse].ToString().Trim()); //IsInUse
objvUserRolesEN.UpdDate = objRow[convUserRoles.UpdDate] == DBNull.Value ? null : objRow[convUserRoles.UpdDate].ToString().Trim(); //修改日期
objvUserRolesEN.UpdUserId = objRow[convUserRoles.UpdUserId] == DBNull.Value ? null : objRow[convUserRoles.UpdUserId].ToString().Trim(); //修改用户Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvUserRolesEN.RoleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvUserRolesEN);
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
public static List<clsvUserRolesEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvUserRolesEN> arrObjLst = new List<clsvUserRolesEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvUserRolesEN objvUserRolesEN = new clsvUserRolesEN();
try
{
objvUserRolesEN.RoleId = objRow[convUserRoles.RoleId].ToString().Trim(); //角色Id
objvUserRolesEN.RoleName = objRow[convUserRoles.RoleName] == DBNull.Value ? null : objRow[convUserRoles.RoleName].ToString().Trim(); //角色名
objvUserRolesEN.QuestionnaireSetId = objRow[convUserRoles.QuestionnaireSetId] == DBNull.Value ? null : objRow[convUserRoles.QuestionnaireSetId].ToString().Trim(); //问卷集ID
objvUserRolesEN.QuestionnaireSetName = objRow[convUserRoles.QuestionnaireSetName] == DBNull.Value ? null : objRow[convUserRoles.QuestionnaireSetName].ToString().Trim(); //问卷集名
objvUserRolesEN.PrjId = objRow[convUserRoles.PrjId] == DBNull.Value ? null : objRow[convUserRoles.PrjId].ToString().Trim(); //PrjId
objvUserRolesEN.Memo = objRow[convUserRoles.Memo] == DBNull.Value ? null : objRow[convUserRoles.Memo].ToString().Trim(); //备注
objvUserRolesEN.IsInUse = clsEntityBase2.TransNullToBool_S(objRow[convUserRoles.IsInUse].ToString().Trim()); //IsInUse
objvUserRolesEN.UpdDate = objRow[convUserRoles.UpdDate] == DBNull.Value ? null : objRow[convUserRoles.UpdDate].ToString().Trim(); //修改日期
objvUserRolesEN.UpdUserId = objRow[convUserRoles.UpdUserId] == DBNull.Value ? null : objRow[convUserRoles.UpdUserId].ToString().Trim(); //修改用户Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvUserRolesEN.RoleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvUserRolesEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvUserRolesCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvUserRolesEN> GetSubObjLstCache(clsvUserRolesEN objvUserRolesCond)
{
List<clsvUserRolesEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvUserRolesEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convUserRoles.AttributeName)
{
if (objvUserRolesCond.IsUpdated(strFldName) == false) continue;
if (objvUserRolesCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvUserRolesCond[strFldName].ToString());
}
else
{
if (objvUserRolesCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvUserRolesCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvUserRolesCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvUserRolesCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvUserRolesCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvUserRolesCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvUserRolesCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvUserRolesCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvUserRolesCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvUserRolesCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvUserRolesCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvUserRolesCond[strFldName]));
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
public static List<clsvUserRolesEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvUserRolesEN> arrObjLst = new List<clsvUserRolesEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvUserRolesEN objvUserRolesEN = new clsvUserRolesEN();
try
{
objvUserRolesEN.RoleId = objRow[convUserRoles.RoleId].ToString().Trim(); //角色Id
objvUserRolesEN.RoleName = objRow[convUserRoles.RoleName] == DBNull.Value ? null : objRow[convUserRoles.RoleName].ToString().Trim(); //角色名
objvUserRolesEN.QuestionnaireSetId = objRow[convUserRoles.QuestionnaireSetId] == DBNull.Value ? null : objRow[convUserRoles.QuestionnaireSetId].ToString().Trim(); //问卷集ID
objvUserRolesEN.QuestionnaireSetName = objRow[convUserRoles.QuestionnaireSetName] == DBNull.Value ? null : objRow[convUserRoles.QuestionnaireSetName].ToString().Trim(); //问卷集名
objvUserRolesEN.PrjId = objRow[convUserRoles.PrjId] == DBNull.Value ? null : objRow[convUserRoles.PrjId].ToString().Trim(); //PrjId
objvUserRolesEN.Memo = objRow[convUserRoles.Memo] == DBNull.Value ? null : objRow[convUserRoles.Memo].ToString().Trim(); //备注
objvUserRolesEN.IsInUse = clsEntityBase2.TransNullToBool_S(objRow[convUserRoles.IsInUse].ToString().Trim()); //IsInUse
objvUserRolesEN.UpdDate = objRow[convUserRoles.UpdDate] == DBNull.Value ? null : objRow[convUserRoles.UpdDate].ToString().Trim(); //修改日期
objvUserRolesEN.UpdUserId = objRow[convUserRoles.UpdUserId] == DBNull.Value ? null : objRow[convUserRoles.UpdUserId].ToString().Trim(); //修改用户Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvUserRolesEN.RoleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvUserRolesEN);
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
public static List<clsvUserRolesEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvUserRolesEN> arrObjLst = new List<clsvUserRolesEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvUserRolesEN objvUserRolesEN = new clsvUserRolesEN();
try
{
objvUserRolesEN.RoleId = objRow[convUserRoles.RoleId].ToString().Trim(); //角色Id
objvUserRolesEN.RoleName = objRow[convUserRoles.RoleName] == DBNull.Value ? null : objRow[convUserRoles.RoleName].ToString().Trim(); //角色名
objvUserRolesEN.QuestionnaireSetId = objRow[convUserRoles.QuestionnaireSetId] == DBNull.Value ? null : objRow[convUserRoles.QuestionnaireSetId].ToString().Trim(); //问卷集ID
objvUserRolesEN.QuestionnaireSetName = objRow[convUserRoles.QuestionnaireSetName] == DBNull.Value ? null : objRow[convUserRoles.QuestionnaireSetName].ToString().Trim(); //问卷集名
objvUserRolesEN.PrjId = objRow[convUserRoles.PrjId] == DBNull.Value ? null : objRow[convUserRoles.PrjId].ToString().Trim(); //PrjId
objvUserRolesEN.Memo = objRow[convUserRoles.Memo] == DBNull.Value ? null : objRow[convUserRoles.Memo].ToString().Trim(); //备注
objvUserRolesEN.IsInUse = clsEntityBase2.TransNullToBool_S(objRow[convUserRoles.IsInUse].ToString().Trim()); //IsInUse
objvUserRolesEN.UpdDate = objRow[convUserRoles.UpdDate] == DBNull.Value ? null : objRow[convUserRoles.UpdDate].ToString().Trim(); //修改日期
objvUserRolesEN.UpdUserId = objRow[convUserRoles.UpdUserId] == DBNull.Value ? null : objRow[convUserRoles.UpdUserId].ToString().Trim(); //修改用户Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvUserRolesEN.RoleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvUserRolesEN);
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
List<clsvUserRolesEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvUserRolesEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvUserRolesEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvUserRolesEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvUserRolesEN> arrObjLst = new List<clsvUserRolesEN>(); 
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
	clsvUserRolesEN objvUserRolesEN = new clsvUserRolesEN();
try
{
objvUserRolesEN.RoleId = objRow[convUserRoles.RoleId].ToString().Trim(); //角色Id
objvUserRolesEN.RoleName = objRow[convUserRoles.RoleName] == DBNull.Value ? null : objRow[convUserRoles.RoleName].ToString().Trim(); //角色名
objvUserRolesEN.QuestionnaireSetId = objRow[convUserRoles.QuestionnaireSetId] == DBNull.Value ? null : objRow[convUserRoles.QuestionnaireSetId].ToString().Trim(); //问卷集ID
objvUserRolesEN.QuestionnaireSetName = objRow[convUserRoles.QuestionnaireSetName] == DBNull.Value ? null : objRow[convUserRoles.QuestionnaireSetName].ToString().Trim(); //问卷集名
objvUserRolesEN.PrjId = objRow[convUserRoles.PrjId] == DBNull.Value ? null : objRow[convUserRoles.PrjId].ToString().Trim(); //PrjId
objvUserRolesEN.Memo = objRow[convUserRoles.Memo] == DBNull.Value ? null : objRow[convUserRoles.Memo].ToString().Trim(); //备注
objvUserRolesEN.IsInUse = clsEntityBase2.TransNullToBool_S(objRow[convUserRoles.IsInUse].ToString().Trim()); //IsInUse
objvUserRolesEN.UpdDate = objRow[convUserRoles.UpdDate] == DBNull.Value ? null : objRow[convUserRoles.UpdDate].ToString().Trim(); //修改日期
objvUserRolesEN.UpdUserId = objRow[convUserRoles.UpdUserId] == DBNull.Value ? null : objRow[convUserRoles.UpdUserId].ToString().Trim(); //修改用户Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvUserRolesEN.RoleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvUserRolesEN);
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
public static List<clsvUserRolesEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvUserRolesEN> arrObjLst = new List<clsvUserRolesEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvUserRolesEN objvUserRolesEN = new clsvUserRolesEN();
try
{
objvUserRolesEN.RoleId = objRow[convUserRoles.RoleId].ToString().Trim(); //角色Id
objvUserRolesEN.RoleName = objRow[convUserRoles.RoleName] == DBNull.Value ? null : objRow[convUserRoles.RoleName].ToString().Trim(); //角色名
objvUserRolesEN.QuestionnaireSetId = objRow[convUserRoles.QuestionnaireSetId] == DBNull.Value ? null : objRow[convUserRoles.QuestionnaireSetId].ToString().Trim(); //问卷集ID
objvUserRolesEN.QuestionnaireSetName = objRow[convUserRoles.QuestionnaireSetName] == DBNull.Value ? null : objRow[convUserRoles.QuestionnaireSetName].ToString().Trim(); //问卷集名
objvUserRolesEN.PrjId = objRow[convUserRoles.PrjId] == DBNull.Value ? null : objRow[convUserRoles.PrjId].ToString().Trim(); //PrjId
objvUserRolesEN.Memo = objRow[convUserRoles.Memo] == DBNull.Value ? null : objRow[convUserRoles.Memo].ToString().Trim(); //备注
objvUserRolesEN.IsInUse = clsEntityBase2.TransNullToBool_S(objRow[convUserRoles.IsInUse].ToString().Trim()); //IsInUse
objvUserRolesEN.UpdDate = objRow[convUserRoles.UpdDate] == DBNull.Value ? null : objRow[convUserRoles.UpdDate].ToString().Trim(); //修改日期
objvUserRolesEN.UpdUserId = objRow[convUserRoles.UpdUserId] == DBNull.Value ? null : objRow[convUserRoles.UpdUserId].ToString().Trim(); //修改用户Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvUserRolesEN.RoleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvUserRolesEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvUserRolesEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvUserRolesEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvUserRolesEN> arrObjLst = new List<clsvUserRolesEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvUserRolesEN objvUserRolesEN = new clsvUserRolesEN();
try
{
objvUserRolesEN.RoleId = objRow[convUserRoles.RoleId].ToString().Trim(); //角色Id
objvUserRolesEN.RoleName = objRow[convUserRoles.RoleName] == DBNull.Value ? null : objRow[convUserRoles.RoleName].ToString().Trim(); //角色名
objvUserRolesEN.QuestionnaireSetId = objRow[convUserRoles.QuestionnaireSetId] == DBNull.Value ? null : objRow[convUserRoles.QuestionnaireSetId].ToString().Trim(); //问卷集ID
objvUserRolesEN.QuestionnaireSetName = objRow[convUserRoles.QuestionnaireSetName] == DBNull.Value ? null : objRow[convUserRoles.QuestionnaireSetName].ToString().Trim(); //问卷集名
objvUserRolesEN.PrjId = objRow[convUserRoles.PrjId] == DBNull.Value ? null : objRow[convUserRoles.PrjId].ToString().Trim(); //PrjId
objvUserRolesEN.Memo = objRow[convUserRoles.Memo] == DBNull.Value ? null : objRow[convUserRoles.Memo].ToString().Trim(); //备注
objvUserRolesEN.IsInUse = clsEntityBase2.TransNullToBool_S(objRow[convUserRoles.IsInUse].ToString().Trim()); //IsInUse
objvUserRolesEN.UpdDate = objRow[convUserRoles.UpdDate] == DBNull.Value ? null : objRow[convUserRoles.UpdDate].ToString().Trim(); //修改日期
objvUserRolesEN.UpdUserId = objRow[convUserRoles.UpdUserId] == DBNull.Value ? null : objRow[convUserRoles.UpdUserId].ToString().Trim(); //修改用户Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvUserRolesEN.RoleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvUserRolesEN);
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
public static List<clsvUserRolesEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvUserRolesEN> arrObjLst = new List<clsvUserRolesEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvUserRolesEN objvUserRolesEN = new clsvUserRolesEN();
try
{
objvUserRolesEN.RoleId = objRow[convUserRoles.RoleId].ToString().Trim(); //角色Id
objvUserRolesEN.RoleName = objRow[convUserRoles.RoleName] == DBNull.Value ? null : objRow[convUserRoles.RoleName].ToString().Trim(); //角色名
objvUserRolesEN.QuestionnaireSetId = objRow[convUserRoles.QuestionnaireSetId] == DBNull.Value ? null : objRow[convUserRoles.QuestionnaireSetId].ToString().Trim(); //问卷集ID
objvUserRolesEN.QuestionnaireSetName = objRow[convUserRoles.QuestionnaireSetName] == DBNull.Value ? null : objRow[convUserRoles.QuestionnaireSetName].ToString().Trim(); //问卷集名
objvUserRolesEN.PrjId = objRow[convUserRoles.PrjId] == DBNull.Value ? null : objRow[convUserRoles.PrjId].ToString().Trim(); //PrjId
objvUserRolesEN.Memo = objRow[convUserRoles.Memo] == DBNull.Value ? null : objRow[convUserRoles.Memo].ToString().Trim(); //备注
objvUserRolesEN.IsInUse = clsEntityBase2.TransNullToBool_S(objRow[convUserRoles.IsInUse].ToString().Trim()); //IsInUse
objvUserRolesEN.UpdDate = objRow[convUserRoles.UpdDate] == DBNull.Value ? null : objRow[convUserRoles.UpdDate].ToString().Trim(); //修改日期
objvUserRolesEN.UpdUserId = objRow[convUserRoles.UpdUserId] == DBNull.Value ? null : objRow[convUserRoles.UpdUserId].ToString().Trim(); //修改用户Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvUserRolesEN.RoleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvUserRolesEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvUserRolesEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvUserRolesEN> arrObjLst = new List<clsvUserRolesEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvUserRolesEN objvUserRolesEN = new clsvUserRolesEN();
try
{
objvUserRolesEN.RoleId = objRow[convUserRoles.RoleId].ToString().Trim(); //角色Id
objvUserRolesEN.RoleName = objRow[convUserRoles.RoleName] == DBNull.Value ? null : objRow[convUserRoles.RoleName].ToString().Trim(); //角色名
objvUserRolesEN.QuestionnaireSetId = objRow[convUserRoles.QuestionnaireSetId] == DBNull.Value ? null : objRow[convUserRoles.QuestionnaireSetId].ToString().Trim(); //问卷集ID
objvUserRolesEN.QuestionnaireSetName = objRow[convUserRoles.QuestionnaireSetName] == DBNull.Value ? null : objRow[convUserRoles.QuestionnaireSetName].ToString().Trim(); //问卷集名
objvUserRolesEN.PrjId = objRow[convUserRoles.PrjId] == DBNull.Value ? null : objRow[convUserRoles.PrjId].ToString().Trim(); //PrjId
objvUserRolesEN.Memo = objRow[convUserRoles.Memo] == DBNull.Value ? null : objRow[convUserRoles.Memo].ToString().Trim(); //备注
objvUserRolesEN.IsInUse = clsEntityBase2.TransNullToBool_S(objRow[convUserRoles.IsInUse].ToString().Trim()); //IsInUse
objvUserRolesEN.UpdDate = objRow[convUserRoles.UpdDate] == DBNull.Value ? null : objRow[convUserRoles.UpdDate].ToString().Trim(); //修改日期
objvUserRolesEN.UpdUserId = objRow[convUserRoles.UpdUserId] == DBNull.Value ? null : objRow[convUserRoles.UpdUserId].ToString().Trim(); //修改用户Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvUserRolesEN.RoleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvUserRolesEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvUserRolesEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvUserRoles(ref clsvUserRolesEN objvUserRolesEN)
{
bool bolResult = vUserRolesDA.GetvUserRoles(ref objvUserRolesEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strRoleId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvUserRolesEN GetObjByRoleId(string strRoleId)
{
if (strRoleId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strRoleId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strRoleId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strRoleId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsvUserRolesEN objvUserRolesEN = vUserRolesDA.GetObjByRoleId(strRoleId);
return objvUserRolesEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvUserRolesEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvUserRolesEN objvUserRolesEN = vUserRolesDA.GetFirstObj(strWhereCond);
 return objvUserRolesEN;
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
public static clsvUserRolesEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvUserRolesEN objvUserRolesEN = vUserRolesDA.GetObjByDataRow(objRow);
 return objvUserRolesEN;
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
public static clsvUserRolesEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvUserRolesEN objvUserRolesEN = vUserRolesDA.GetObjByDataRow(objRow);
 return objvUserRolesEN;
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
 /// <param name = "strRoleId">所给的关键字</param>
 /// <param name = "lstvUserRolesObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvUserRolesEN GetObjByRoleIdFromList(string strRoleId, List<clsvUserRolesEN> lstvUserRolesObjLst)
{
foreach (clsvUserRolesEN objvUserRolesEN in lstvUserRolesObjLst)
{
if (objvUserRolesEN.RoleId == strRoleId)
{
return objvUserRolesEN;
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
 string strRoleId;
 try
 {
 strRoleId = new clsvUserRolesDA().GetFirstID(strWhereCond);
 return strRoleId;
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
 arrList = vUserRolesDA.GetID(strWhereCond);
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
bool bolIsExist = vUserRolesDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strRoleId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strRoleId)
{
if (string.IsNullOrEmpty(strRoleId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strRoleId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = vUserRolesDA.IsExist(strRoleId);
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
 bolIsExist = clsvUserRolesDA.IsExistTable();
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
 bolIsExist = vUserRolesDA.IsExistTable(strTabName);
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
 /// <param name = "objvUserRolesENS">源对象</param>
 /// <param name = "objvUserRolesENT">目标对象</param>
 public static void CopyTo(clsvUserRolesEN objvUserRolesENS, clsvUserRolesEN objvUserRolesENT)
{
try
{
objvUserRolesENT.RoleId = objvUserRolesENS.RoleId; //角色Id
objvUserRolesENT.RoleName = objvUserRolesENS.RoleName; //角色名
objvUserRolesENT.QuestionnaireSetId = objvUserRolesENS.QuestionnaireSetId; //问卷集ID
objvUserRolesENT.QuestionnaireSetName = objvUserRolesENS.QuestionnaireSetName; //问卷集名
objvUserRolesENT.PrjId = objvUserRolesENS.PrjId; //PrjId
objvUserRolesENT.Memo = objvUserRolesENS.Memo; //备注
objvUserRolesENT.IsInUse = objvUserRolesENS.IsInUse; //IsInUse
objvUserRolesENT.UpdDate = objvUserRolesENS.UpdDate; //修改日期
objvUserRolesENT.UpdUserId = objvUserRolesENS.UpdUserId; //修改用户Id
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
 /// <param name = "objvUserRolesEN">源简化对象</param>
 public static void SetUpdFlag(clsvUserRolesEN objvUserRolesEN)
{
try
{
objvUserRolesEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvUserRolesEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convUserRoles.RoleId, new clsStrCompareIgnoreCase())  ==  true)
{
objvUserRolesEN.RoleId = objvUserRolesEN.RoleId; //角色Id
}
if (arrFldSet.Contains(convUserRoles.RoleName, new clsStrCompareIgnoreCase())  ==  true)
{
objvUserRolesEN.RoleName = objvUserRolesEN.RoleName == "[null]" ? null :  objvUserRolesEN.RoleName; //角色名
}
if (arrFldSet.Contains(convUserRoles.QuestionnaireSetId, new clsStrCompareIgnoreCase())  ==  true)
{
objvUserRolesEN.QuestionnaireSetId = objvUserRolesEN.QuestionnaireSetId == "[null]" ? null :  objvUserRolesEN.QuestionnaireSetId; //问卷集ID
}
if (arrFldSet.Contains(convUserRoles.QuestionnaireSetName, new clsStrCompareIgnoreCase())  ==  true)
{
objvUserRolesEN.QuestionnaireSetName = objvUserRolesEN.QuestionnaireSetName == "[null]" ? null :  objvUserRolesEN.QuestionnaireSetName; //问卷集名
}
if (arrFldSet.Contains(convUserRoles.PrjId, new clsStrCompareIgnoreCase())  ==  true)
{
objvUserRolesEN.PrjId = objvUserRolesEN.PrjId == "[null]" ? null :  objvUserRolesEN.PrjId; //PrjId
}
if (arrFldSet.Contains(convUserRoles.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvUserRolesEN.Memo = objvUserRolesEN.Memo == "[null]" ? null :  objvUserRolesEN.Memo; //备注
}
if (arrFldSet.Contains(convUserRoles.IsInUse, new clsStrCompareIgnoreCase())  ==  true)
{
objvUserRolesEN.IsInUse = objvUserRolesEN.IsInUse; //IsInUse
}
if (arrFldSet.Contains(convUserRoles.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvUserRolesEN.UpdDate = objvUserRolesEN.UpdDate == "[null]" ? null :  objvUserRolesEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convUserRoles.UpdUserId, new clsStrCompareIgnoreCase())  ==  true)
{
objvUserRolesEN.UpdUserId = objvUserRolesEN.UpdUserId == "[null]" ? null :  objvUserRolesEN.UpdUserId; //修改用户Id
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
 /// <param name = "objvUserRolesEN">源简化对象</param>
 public static void AccessFldValueNull(clsvUserRolesEN objvUserRolesEN)
{
try
{
if (objvUserRolesEN.RoleName == "[null]") objvUserRolesEN.RoleName = null; //角色名
if (objvUserRolesEN.QuestionnaireSetId == "[null]") objvUserRolesEN.QuestionnaireSetId = null; //问卷集ID
if (objvUserRolesEN.QuestionnaireSetName == "[null]") objvUserRolesEN.QuestionnaireSetName = null; //问卷集名
if (objvUserRolesEN.PrjId == "[null]") objvUserRolesEN.PrjId = null; //PrjId
if (objvUserRolesEN.Memo == "[null]") objvUserRolesEN.Memo = null; //备注
if (objvUserRolesEN.UpdDate == "[null]") objvUserRolesEN.UpdDate = null; //修改日期
if (objvUserRolesEN.UpdUserId == "[null]") objvUserRolesEN.UpdUserId = null; //修改用户Id
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
public static void CheckProperty4Condition(clsvUserRolesEN objvUserRolesEN)
{
 vUserRolesDA.CheckProperty4Condition(objvUserRolesEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Win的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_ComboBoxBindFunction)
 /// </summary>
 /// <param name = "objComboBox">需要绑定当前表的下拉框</param>

public static void BindCbo_RoleId(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", convUserRoles.RoleId); 
List<clsvUserRolesEN> arrObjLst = clsvUserRolesBL.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsvUserRolesEN objvUserRolesEN = new clsvUserRolesEN()
{
RoleId = "0",
RoleName = "选[v角色]..."
};
arrObjLst.Insert(0, objvUserRolesEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = convUserRoles.RoleId;
objComboBox.DisplayMember = convUserRoles.RoleName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_DdlBindFunction)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>

public static void BindDdl_RoleId(System.Web.UI.WebControls.DropDownList objDDL )
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[v角色]...","0");
string strCondition = string.Format("1 =1 Order By {0}", convUserRoles.RoleId); 
IEnumerable<clsvUserRolesEN> arrObjLst = clsvUserRolesBL.GetObjLst(strCondition);
objDDL.DataValueField = convUserRoles.RoleId;
objDDL.DataTextField = convUserRoles.RoleName;
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
public static void BindDdl_RoleIdCache(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[v角色]...","0");
List<clsvUserRolesEN> arrvUserRolesObjLst = GetAllvUserRolesObjLstCache(); 
objDDL.DataValueField = convUserRoles.RoleId;
objDDL.DataTextField = convUserRoles.RoleName;
objDDL.DataSource = arrvUserRolesObjLst;
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
if (clsQuestionnaireSetBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsQuestionnaireSetBL没有刷新缓存机制(clsQuestionnaireSetBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsUserRolesBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsUserRolesBL没有刷新缓存机制(clsUserRolesBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by RoleId");
//if (arrvUserRolesObjLstCache == null)
//{
//arrvUserRolesObjLstCache = vUserRolesDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strRoleId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvUserRolesEN GetObjByRoleIdCache(string strRoleId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvUserRolesEN._CurrTabName);
List<clsvUserRolesEN> arrvUserRolesObjLstCache = GetObjLstCache();
IEnumerable <clsvUserRolesEN> arrvUserRolesObjLst_Sel =
arrvUserRolesObjLstCache
.Where(x=> x.RoleId == strRoleId 
);
if (arrvUserRolesObjLst_Sel.Count() == 0)
{
   clsvUserRolesEN obj = clsvUserRolesBL.GetObjByRoleId(strRoleId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvUserRolesObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strRoleId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetRoleNameByRoleIdCache(string strRoleId)
{
if (string.IsNullOrEmpty(strRoleId) == true) return "";
//获取缓存中的对象列表
clsvUserRolesEN objvUserRoles = GetObjByRoleIdCache(strRoleId);
if (objvUserRoles == null) return "";
return objvUserRoles.RoleName;
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strRoleId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByRoleIdCache(string strRoleId)
{
if (string.IsNullOrEmpty(strRoleId) == true) return "";
//获取缓存中的对象列表
clsvUserRolesEN objvUserRoles = GetObjByRoleIdCache(strRoleId);
if (objvUserRoles == null) return "";
return objvUserRoles.RoleName;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvUserRolesEN> GetAllvUserRolesObjLstCache()
{
//获取缓存中的对象列表
List<clsvUserRolesEN> arrvUserRolesObjLstCache = GetObjLstCache(); 
return arrvUserRolesObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvUserRolesEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvUserRolesEN._CurrTabName);
List<clsvUserRolesEN> arrvUserRolesObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvUserRolesObjLstCache;
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
string strKey = string.Format("{0}", clsvUserRolesEN._CurrTabName);
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
public static string Func(string strInFldName, string strOutFldName, string strRoleId)
{
if (strInFldName != convUserRoles.RoleId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convUserRoles.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convUserRoles.AttributeName));
throw new Exception(strMsg);
}
var objvUserRoles = clsvUserRolesBL.GetObjByRoleIdCache(strRoleId);
if (objvUserRoles == null) return "";
return objvUserRoles[strOutFldName].ToString();
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
int intRecCount = clsvUserRolesDA.GetRecCount(strTabName);
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
int intRecCount = clsvUserRolesDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvUserRolesDA.GetRecCount();
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
int intRecCount = clsvUserRolesDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvUserRolesCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvUserRolesEN objvUserRolesCond)
{
List<clsvUserRolesEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvUserRolesEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convUserRoles.AttributeName)
{
if (objvUserRolesCond.IsUpdated(strFldName) == false) continue;
if (objvUserRolesCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvUserRolesCond[strFldName].ToString());
}
else
{
if (objvUserRolesCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvUserRolesCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvUserRolesCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvUserRolesCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvUserRolesCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvUserRolesCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvUserRolesCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvUserRolesCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvUserRolesCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvUserRolesCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvUserRolesCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvUserRolesCond[strFldName]));
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
 List<string> arrList = clsvUserRolesDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vUserRolesDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vUserRolesDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}