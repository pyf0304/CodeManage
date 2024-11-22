
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvPlatDefaRoleBL
 表名:vPlatDefaRole(01120232)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 12:49:32
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
public static class  clsvPlatDefaRoleBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvPlatDefaRoleEN GetObj(this K_mId_vPlatDefaRole myKey)
{
clsvPlatDefaRoleEN objvPlatDefaRoleEN = clsvPlatDefaRoleBL.vPlatDefaRoleDA.GetObjBymId(myKey.Value);
return objvPlatDefaRoleEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPlatDefaRoleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPlatDefaRoleEN SetmId(this clsvPlatDefaRoleEN objvPlatDefaRoleEN, long lngmId, string strComparisonOp="")
	{
objvPlatDefaRoleEN.mId = lngmId; //mId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPlatDefaRoleEN.dicFldComparisonOp.ContainsKey(convPlatDefaRole.mId) == false)
{
objvPlatDefaRoleEN.dicFldComparisonOp.Add(convPlatDefaRole.mId, strComparisonOp);
}
else
{
objvPlatDefaRoleEN.dicFldComparisonOp[convPlatDefaRole.mId] = strComparisonOp;
}
}
return objvPlatDefaRoleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPlatDefaRoleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPlatDefaRoleEN SetIdSchool(this clsvPlatDefaRoleEN objvPlatDefaRoleEN, string strIdSchool, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdSchool, 4, convPlatDefaRole.IdSchool);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdSchool, 4, convPlatDefaRole.IdSchool);
}
objvPlatDefaRoleEN.IdSchool = strIdSchool; //学校流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPlatDefaRoleEN.dicFldComparisonOp.ContainsKey(convPlatDefaRole.IdSchool) == false)
{
objvPlatDefaRoleEN.dicFldComparisonOp.Add(convPlatDefaRole.IdSchool, strComparisonOp);
}
else
{
objvPlatDefaRoleEN.dicFldComparisonOp[convPlatDefaRole.IdSchool] = strComparisonOp;
}
}
return objvPlatDefaRoleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPlatDefaRoleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPlatDefaRoleEN SetSchoolId(this clsvPlatDefaRoleEN objvPlatDefaRoleEN, string strSchoolId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strSchoolId, convPlatDefaRole.SchoolId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSchoolId, 10, convPlatDefaRole.SchoolId);
}
objvPlatDefaRoleEN.SchoolId = strSchoolId; //学校编号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPlatDefaRoleEN.dicFldComparisonOp.ContainsKey(convPlatDefaRole.SchoolId) == false)
{
objvPlatDefaRoleEN.dicFldComparisonOp.Add(convPlatDefaRole.SchoolId, strComparisonOp);
}
else
{
objvPlatDefaRoleEN.dicFldComparisonOp[convPlatDefaRole.SchoolId] = strComparisonOp;
}
}
return objvPlatDefaRoleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPlatDefaRoleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPlatDefaRoleEN SetIsCurrentUse(this clsvPlatDefaRoleEN objvPlatDefaRoleEN, bool bolIsCurrentUse, string strComparisonOp="")
	{
objvPlatDefaRoleEN.IsCurrentUse = bolIsCurrentUse; //是否当前使用
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPlatDefaRoleEN.dicFldComparisonOp.ContainsKey(convPlatDefaRole.IsCurrentUse) == false)
{
objvPlatDefaRoleEN.dicFldComparisonOp.Add(convPlatDefaRole.IsCurrentUse, strComparisonOp);
}
else
{
objvPlatDefaRoleEN.dicFldComparisonOp[convPlatDefaRole.IsCurrentUse] = strComparisonOp;
}
}
return objvPlatDefaRoleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPlatDefaRoleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPlatDefaRoleEN SetSchoolName(this clsvPlatDefaRoleEN objvPlatDefaRoleEN, string strSchoolName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strSchoolName, convPlatDefaRole.SchoolName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSchoolName, 50, convPlatDefaRole.SchoolName);
}
objvPlatDefaRoleEN.SchoolName = strSchoolName; //学校名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPlatDefaRoleEN.dicFldComparisonOp.ContainsKey(convPlatDefaRole.SchoolName) == false)
{
objvPlatDefaRoleEN.dicFldComparisonOp.Add(convPlatDefaRole.SchoolName, strComparisonOp);
}
else
{
objvPlatDefaRoleEN.dicFldComparisonOp[convPlatDefaRole.SchoolName] = strComparisonOp;
}
}
return objvPlatDefaRoleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPlatDefaRoleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPlatDefaRoleEN SetPersonType(this clsvPlatDefaRoleEN objvPlatDefaRoleEN, string strPersonType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPersonType, convPlatDefaRole.PersonType);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPersonType, 30, convPlatDefaRole.PersonType);
}
objvPlatDefaRoleEN.PersonType = strPersonType; //人员类别
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPlatDefaRoleEN.dicFldComparisonOp.ContainsKey(convPlatDefaRole.PersonType) == false)
{
objvPlatDefaRoleEN.dicFldComparisonOp.Add(convPlatDefaRole.PersonType, strComparisonOp);
}
else
{
objvPlatDefaRoleEN.dicFldComparisonOp[convPlatDefaRole.PersonType] = strComparisonOp;
}
}
return objvPlatDefaRoleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPlatDefaRoleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPlatDefaRoleEN SetPrjId(this clsvPlatDefaRoleEN objvPlatDefaRoleEN, string strPrjId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjId, 4, convPlatDefaRole.PrjId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, convPlatDefaRole.PrjId);
}
objvPlatDefaRoleEN.PrjId = strPrjId; //PrjId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPlatDefaRoleEN.dicFldComparisonOp.ContainsKey(convPlatDefaRole.PrjId) == false)
{
objvPlatDefaRoleEN.dicFldComparisonOp.Add(convPlatDefaRole.PrjId, strComparisonOp);
}
else
{
objvPlatDefaRoleEN.dicFldComparisonOp[convPlatDefaRole.PrjId] = strComparisonOp;
}
}
return objvPlatDefaRoleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPlatDefaRoleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPlatDefaRoleEN SetRoleId(this clsvPlatDefaRoleEN objvPlatDefaRoleEN, string strRoleId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strRoleId, convPlatDefaRole.RoleId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRoleId, 8, convPlatDefaRole.RoleId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strRoleId, 8, convPlatDefaRole.RoleId);
}
objvPlatDefaRoleEN.RoleId = strRoleId; //角色Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPlatDefaRoleEN.dicFldComparisonOp.ContainsKey(convPlatDefaRole.RoleId) == false)
{
objvPlatDefaRoleEN.dicFldComparisonOp.Add(convPlatDefaRole.RoleId, strComparisonOp);
}
else
{
objvPlatDefaRoleEN.dicFldComparisonOp[convPlatDefaRole.RoleId] = strComparisonOp;
}
}
return objvPlatDefaRoleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPlatDefaRoleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPlatDefaRoleEN SetMemo(this clsvPlatDefaRoleEN objvPlatDefaRoleEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convPlatDefaRole.Memo);
}
objvPlatDefaRoleEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPlatDefaRoleEN.dicFldComparisonOp.ContainsKey(convPlatDefaRole.Memo) == false)
{
objvPlatDefaRoleEN.dicFldComparisonOp.Add(convPlatDefaRole.Memo, strComparisonOp);
}
else
{
objvPlatDefaRoleEN.dicFldComparisonOp[convPlatDefaRole.Memo] = strComparisonOp;
}
}
return objvPlatDefaRoleEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvPlatDefaRoleENS">源对象</param>
 /// <param name = "objvPlatDefaRoleENT">目标对象</param>
 public static void CopyTo(this clsvPlatDefaRoleEN objvPlatDefaRoleENS, clsvPlatDefaRoleEN objvPlatDefaRoleENT)
{
try
{
objvPlatDefaRoleENT.mId = objvPlatDefaRoleENS.mId; //mId
objvPlatDefaRoleENT.IdSchool = objvPlatDefaRoleENS.IdSchool; //学校流水号
objvPlatDefaRoleENT.SchoolId = objvPlatDefaRoleENS.SchoolId; //学校编号
objvPlatDefaRoleENT.IsCurrentUse = objvPlatDefaRoleENS.IsCurrentUse; //是否当前使用
objvPlatDefaRoleENT.SchoolName = objvPlatDefaRoleENS.SchoolName; //学校名称
objvPlatDefaRoleENT.PersonType = objvPlatDefaRoleENS.PersonType; //人员类别
objvPlatDefaRoleENT.PrjId = objvPlatDefaRoleENS.PrjId; //PrjId
objvPlatDefaRoleENT.RoleId = objvPlatDefaRoleENS.RoleId; //角色Id
objvPlatDefaRoleENT.Memo = objvPlatDefaRoleENS.Memo; //备注
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
 /// <param name = "objvPlatDefaRoleENS">源对象</param>
 /// <returns>目标对象=>clsvPlatDefaRoleEN:objvPlatDefaRoleENT</returns>
 public static clsvPlatDefaRoleEN CopyTo(this clsvPlatDefaRoleEN objvPlatDefaRoleENS)
{
try
{
 clsvPlatDefaRoleEN objvPlatDefaRoleENT = new clsvPlatDefaRoleEN()
{
mId = objvPlatDefaRoleENS.mId, //mId
IdSchool = objvPlatDefaRoleENS.IdSchool, //学校流水号
SchoolId = objvPlatDefaRoleENS.SchoolId, //学校编号
IsCurrentUse = objvPlatDefaRoleENS.IsCurrentUse, //是否当前使用
SchoolName = objvPlatDefaRoleENS.SchoolName, //学校名称
PersonType = objvPlatDefaRoleENS.PersonType, //人员类别
PrjId = objvPlatDefaRoleENS.PrjId, //PrjId
RoleId = objvPlatDefaRoleENS.RoleId, //角色Id
Memo = objvPlatDefaRoleENS.Memo, //备注
};
 return objvPlatDefaRoleENT;
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
public static void CheckProperty4Condition(this clsvPlatDefaRoleEN objvPlatDefaRoleEN)
{
 clsvPlatDefaRoleBL.vPlatDefaRoleDA.CheckProperty4Condition(objvPlatDefaRoleEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvPlatDefaRoleEN objvPlatDefaRoleCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvPlatDefaRoleCond.IsUpdated(convPlatDefaRole.mId) == true)
{
string strComparisonOpmId = objvPlatDefaRoleCond.dicFldComparisonOp[convPlatDefaRole.mId];
strWhereCond += string.Format(" And {0} {2} {1}", convPlatDefaRole.mId, objvPlatDefaRoleCond.mId, strComparisonOpmId);
}
if (objvPlatDefaRoleCond.IsUpdated(convPlatDefaRole.IdSchool) == true)
{
string strComparisonOpIdSchool = objvPlatDefaRoleCond.dicFldComparisonOp[convPlatDefaRole.IdSchool];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPlatDefaRole.IdSchool, objvPlatDefaRoleCond.IdSchool, strComparisonOpIdSchool);
}
if (objvPlatDefaRoleCond.IsUpdated(convPlatDefaRole.SchoolId) == true)
{
string strComparisonOpSchoolId = objvPlatDefaRoleCond.dicFldComparisonOp[convPlatDefaRole.SchoolId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPlatDefaRole.SchoolId, objvPlatDefaRoleCond.SchoolId, strComparisonOpSchoolId);
}
if (objvPlatDefaRoleCond.IsUpdated(convPlatDefaRole.IsCurrentUse) == true)
{
if (objvPlatDefaRoleCond.IsCurrentUse == true)
{
strWhereCond += string.Format(" And {0} = '1'", convPlatDefaRole.IsCurrentUse);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convPlatDefaRole.IsCurrentUse);
}
}
if (objvPlatDefaRoleCond.IsUpdated(convPlatDefaRole.SchoolName) == true)
{
string strComparisonOpSchoolName = objvPlatDefaRoleCond.dicFldComparisonOp[convPlatDefaRole.SchoolName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPlatDefaRole.SchoolName, objvPlatDefaRoleCond.SchoolName, strComparisonOpSchoolName);
}
if (objvPlatDefaRoleCond.IsUpdated(convPlatDefaRole.PersonType) == true)
{
string strComparisonOpPersonType = objvPlatDefaRoleCond.dicFldComparisonOp[convPlatDefaRole.PersonType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPlatDefaRole.PersonType, objvPlatDefaRoleCond.PersonType, strComparisonOpPersonType);
}
if (objvPlatDefaRoleCond.IsUpdated(convPlatDefaRole.PrjId) == true)
{
string strComparisonOpPrjId = objvPlatDefaRoleCond.dicFldComparisonOp[convPlatDefaRole.PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPlatDefaRole.PrjId, objvPlatDefaRoleCond.PrjId, strComparisonOpPrjId);
}
if (objvPlatDefaRoleCond.IsUpdated(convPlatDefaRole.RoleId) == true)
{
string strComparisonOpRoleId = objvPlatDefaRoleCond.dicFldComparisonOp[convPlatDefaRole.RoleId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPlatDefaRole.RoleId, objvPlatDefaRoleCond.RoleId, strComparisonOpRoleId);
}
if (objvPlatDefaRoleCond.IsUpdated(convPlatDefaRole.Memo) == true)
{
string strComparisonOpMemo = objvPlatDefaRoleCond.dicFldComparisonOp[convPlatDefaRole.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPlatDefaRole.Memo, objvPlatDefaRoleCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vPlatDefaRole
{
public virtual bool UpdRelaTabDate(long lngmId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v平台默认角色(vPlatDefaRole)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvPlatDefaRoleBL
{
public static RelatedActions_vPlatDefaRole relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvPlatDefaRoleDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvPlatDefaRoleDA vPlatDefaRoleDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvPlatDefaRoleDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvPlatDefaRoleBL()
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
if (string.IsNullOrEmpty(clsvPlatDefaRoleEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvPlatDefaRoleEN._ConnectString);
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
public static DataTable GetDataTable_vPlatDefaRole(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vPlatDefaRoleDA.GetDataTable_vPlatDefaRole(strWhereCond);
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
objDT = vPlatDefaRoleDA.GetDataTable(strWhereCond);
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
objDT = vPlatDefaRoleDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vPlatDefaRoleDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vPlatDefaRoleDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vPlatDefaRoleDA.GetDataTable_Top(objTopPara);
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
objDT = vPlatDefaRoleDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vPlatDefaRoleDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vPlatDefaRoleDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
public static List<clsvPlatDefaRoleEN> GetObjLstByMIdLst(List<long> arrMIdLst)
{
List<clsvPlatDefaRoleEN> arrObjLst = new List<clsvPlatDefaRoleEN>(); 
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
	clsvPlatDefaRoleEN objvPlatDefaRoleEN = new clsvPlatDefaRoleEN();
try
{
objvPlatDefaRoleEN.mId = Int32.Parse(objRow[convPlatDefaRole.mId].ToString().Trim()); //mId
objvPlatDefaRoleEN.IdSchool = objRow[convPlatDefaRole.IdSchool] == DBNull.Value ? null : objRow[convPlatDefaRole.IdSchool].ToString().Trim(); //学校流水号
objvPlatDefaRoleEN.SchoolId = objRow[convPlatDefaRole.SchoolId].ToString().Trim(); //学校编号
objvPlatDefaRoleEN.IsCurrentUse = clsEntityBase2.TransNullToBool_S(objRow[convPlatDefaRole.IsCurrentUse].ToString().Trim()); //是否当前使用
objvPlatDefaRoleEN.SchoolName = objRow[convPlatDefaRole.SchoolName].ToString().Trim(); //学校名称
objvPlatDefaRoleEN.PersonType = objRow[convPlatDefaRole.PersonType].ToString().Trim(); //人员类别
objvPlatDefaRoleEN.PrjId = objRow[convPlatDefaRole.PrjId] == DBNull.Value ? null : objRow[convPlatDefaRole.PrjId].ToString().Trim(); //PrjId
objvPlatDefaRoleEN.RoleId = objRow[convPlatDefaRole.RoleId].ToString().Trim(); //角色Id
objvPlatDefaRoleEN.Memo = objRow[convPlatDefaRole.Memo] == DBNull.Value ? null : objRow[convPlatDefaRole.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPlatDefaRoleEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPlatDefaRoleEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrMIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvPlatDefaRoleEN> GetObjLstByMIdLstCache(List<long> arrMIdLst)
{
string strKey = string.Format("{0}", clsvPlatDefaRoleEN._CurrTabName);
List<clsvPlatDefaRoleEN> arrvPlatDefaRoleObjLstCache = GetObjLstCache();
IEnumerable <clsvPlatDefaRoleEN> arrvPlatDefaRoleObjLst_Sel =
arrvPlatDefaRoleObjLstCache
.Where(x => arrMIdLst.Contains(x.mId));
return arrvPlatDefaRoleObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvPlatDefaRoleEN> GetObjLst(string strWhereCond)
{
List<clsvPlatDefaRoleEN> arrObjLst = new List<clsvPlatDefaRoleEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPlatDefaRoleEN objvPlatDefaRoleEN = new clsvPlatDefaRoleEN();
try
{
objvPlatDefaRoleEN.mId = Int32.Parse(objRow[convPlatDefaRole.mId].ToString().Trim()); //mId
objvPlatDefaRoleEN.IdSchool = objRow[convPlatDefaRole.IdSchool] == DBNull.Value ? null : objRow[convPlatDefaRole.IdSchool].ToString().Trim(); //学校流水号
objvPlatDefaRoleEN.SchoolId = objRow[convPlatDefaRole.SchoolId].ToString().Trim(); //学校编号
objvPlatDefaRoleEN.IsCurrentUse = clsEntityBase2.TransNullToBool_S(objRow[convPlatDefaRole.IsCurrentUse].ToString().Trim()); //是否当前使用
objvPlatDefaRoleEN.SchoolName = objRow[convPlatDefaRole.SchoolName].ToString().Trim(); //学校名称
objvPlatDefaRoleEN.PersonType = objRow[convPlatDefaRole.PersonType].ToString().Trim(); //人员类别
objvPlatDefaRoleEN.PrjId = objRow[convPlatDefaRole.PrjId] == DBNull.Value ? null : objRow[convPlatDefaRole.PrjId].ToString().Trim(); //PrjId
objvPlatDefaRoleEN.RoleId = objRow[convPlatDefaRole.RoleId].ToString().Trim(); //角色Id
objvPlatDefaRoleEN.Memo = objRow[convPlatDefaRole.Memo] == DBNull.Value ? null : objRow[convPlatDefaRole.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPlatDefaRoleEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPlatDefaRoleEN);
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
public static List<clsvPlatDefaRoleEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvPlatDefaRoleEN> arrObjLst = new List<clsvPlatDefaRoleEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPlatDefaRoleEN objvPlatDefaRoleEN = new clsvPlatDefaRoleEN();
try
{
objvPlatDefaRoleEN.mId = Int32.Parse(objRow[convPlatDefaRole.mId].ToString().Trim()); //mId
objvPlatDefaRoleEN.IdSchool = objRow[convPlatDefaRole.IdSchool] == DBNull.Value ? null : objRow[convPlatDefaRole.IdSchool].ToString().Trim(); //学校流水号
objvPlatDefaRoleEN.SchoolId = objRow[convPlatDefaRole.SchoolId].ToString().Trim(); //学校编号
objvPlatDefaRoleEN.IsCurrentUse = clsEntityBase2.TransNullToBool_S(objRow[convPlatDefaRole.IsCurrentUse].ToString().Trim()); //是否当前使用
objvPlatDefaRoleEN.SchoolName = objRow[convPlatDefaRole.SchoolName].ToString().Trim(); //学校名称
objvPlatDefaRoleEN.PersonType = objRow[convPlatDefaRole.PersonType].ToString().Trim(); //人员类别
objvPlatDefaRoleEN.PrjId = objRow[convPlatDefaRole.PrjId] == DBNull.Value ? null : objRow[convPlatDefaRole.PrjId].ToString().Trim(); //PrjId
objvPlatDefaRoleEN.RoleId = objRow[convPlatDefaRole.RoleId].ToString().Trim(); //角色Id
objvPlatDefaRoleEN.Memo = objRow[convPlatDefaRole.Memo] == DBNull.Value ? null : objRow[convPlatDefaRole.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPlatDefaRoleEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPlatDefaRoleEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvPlatDefaRoleCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvPlatDefaRoleEN> GetSubObjLstCache(clsvPlatDefaRoleEN objvPlatDefaRoleCond)
{
List<clsvPlatDefaRoleEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvPlatDefaRoleEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convPlatDefaRole.AttributeName)
{
if (objvPlatDefaRoleCond.IsUpdated(strFldName) == false) continue;
if (objvPlatDefaRoleCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvPlatDefaRoleCond[strFldName].ToString());
}
else
{
if (objvPlatDefaRoleCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvPlatDefaRoleCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvPlatDefaRoleCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvPlatDefaRoleCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvPlatDefaRoleCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvPlatDefaRoleCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvPlatDefaRoleCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvPlatDefaRoleCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvPlatDefaRoleCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvPlatDefaRoleCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvPlatDefaRoleCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvPlatDefaRoleCond[strFldName]));
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
public static List<clsvPlatDefaRoleEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvPlatDefaRoleEN> arrObjLst = new List<clsvPlatDefaRoleEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPlatDefaRoleEN objvPlatDefaRoleEN = new clsvPlatDefaRoleEN();
try
{
objvPlatDefaRoleEN.mId = Int32.Parse(objRow[convPlatDefaRole.mId].ToString().Trim()); //mId
objvPlatDefaRoleEN.IdSchool = objRow[convPlatDefaRole.IdSchool] == DBNull.Value ? null : objRow[convPlatDefaRole.IdSchool].ToString().Trim(); //学校流水号
objvPlatDefaRoleEN.SchoolId = objRow[convPlatDefaRole.SchoolId].ToString().Trim(); //学校编号
objvPlatDefaRoleEN.IsCurrentUse = clsEntityBase2.TransNullToBool_S(objRow[convPlatDefaRole.IsCurrentUse].ToString().Trim()); //是否当前使用
objvPlatDefaRoleEN.SchoolName = objRow[convPlatDefaRole.SchoolName].ToString().Trim(); //学校名称
objvPlatDefaRoleEN.PersonType = objRow[convPlatDefaRole.PersonType].ToString().Trim(); //人员类别
objvPlatDefaRoleEN.PrjId = objRow[convPlatDefaRole.PrjId] == DBNull.Value ? null : objRow[convPlatDefaRole.PrjId].ToString().Trim(); //PrjId
objvPlatDefaRoleEN.RoleId = objRow[convPlatDefaRole.RoleId].ToString().Trim(); //角色Id
objvPlatDefaRoleEN.Memo = objRow[convPlatDefaRole.Memo] == DBNull.Value ? null : objRow[convPlatDefaRole.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPlatDefaRoleEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPlatDefaRoleEN);
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
public static List<clsvPlatDefaRoleEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvPlatDefaRoleEN> arrObjLst = new List<clsvPlatDefaRoleEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPlatDefaRoleEN objvPlatDefaRoleEN = new clsvPlatDefaRoleEN();
try
{
objvPlatDefaRoleEN.mId = Int32.Parse(objRow[convPlatDefaRole.mId].ToString().Trim()); //mId
objvPlatDefaRoleEN.IdSchool = objRow[convPlatDefaRole.IdSchool] == DBNull.Value ? null : objRow[convPlatDefaRole.IdSchool].ToString().Trim(); //学校流水号
objvPlatDefaRoleEN.SchoolId = objRow[convPlatDefaRole.SchoolId].ToString().Trim(); //学校编号
objvPlatDefaRoleEN.IsCurrentUse = clsEntityBase2.TransNullToBool_S(objRow[convPlatDefaRole.IsCurrentUse].ToString().Trim()); //是否当前使用
objvPlatDefaRoleEN.SchoolName = objRow[convPlatDefaRole.SchoolName].ToString().Trim(); //学校名称
objvPlatDefaRoleEN.PersonType = objRow[convPlatDefaRole.PersonType].ToString().Trim(); //人员类别
objvPlatDefaRoleEN.PrjId = objRow[convPlatDefaRole.PrjId] == DBNull.Value ? null : objRow[convPlatDefaRole.PrjId].ToString().Trim(); //PrjId
objvPlatDefaRoleEN.RoleId = objRow[convPlatDefaRole.RoleId].ToString().Trim(); //角色Id
objvPlatDefaRoleEN.Memo = objRow[convPlatDefaRole.Memo] == DBNull.Value ? null : objRow[convPlatDefaRole.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPlatDefaRoleEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPlatDefaRoleEN);
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
List<clsvPlatDefaRoleEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvPlatDefaRoleEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvPlatDefaRoleEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvPlatDefaRoleEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvPlatDefaRoleEN> arrObjLst = new List<clsvPlatDefaRoleEN>(); 
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
	clsvPlatDefaRoleEN objvPlatDefaRoleEN = new clsvPlatDefaRoleEN();
try
{
objvPlatDefaRoleEN.mId = Int32.Parse(objRow[convPlatDefaRole.mId].ToString().Trim()); //mId
objvPlatDefaRoleEN.IdSchool = objRow[convPlatDefaRole.IdSchool] == DBNull.Value ? null : objRow[convPlatDefaRole.IdSchool].ToString().Trim(); //学校流水号
objvPlatDefaRoleEN.SchoolId = objRow[convPlatDefaRole.SchoolId].ToString().Trim(); //学校编号
objvPlatDefaRoleEN.IsCurrentUse = clsEntityBase2.TransNullToBool_S(objRow[convPlatDefaRole.IsCurrentUse].ToString().Trim()); //是否当前使用
objvPlatDefaRoleEN.SchoolName = objRow[convPlatDefaRole.SchoolName].ToString().Trim(); //学校名称
objvPlatDefaRoleEN.PersonType = objRow[convPlatDefaRole.PersonType].ToString().Trim(); //人员类别
objvPlatDefaRoleEN.PrjId = objRow[convPlatDefaRole.PrjId] == DBNull.Value ? null : objRow[convPlatDefaRole.PrjId].ToString().Trim(); //PrjId
objvPlatDefaRoleEN.RoleId = objRow[convPlatDefaRole.RoleId].ToString().Trim(); //角色Id
objvPlatDefaRoleEN.Memo = objRow[convPlatDefaRole.Memo] == DBNull.Value ? null : objRow[convPlatDefaRole.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPlatDefaRoleEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPlatDefaRoleEN);
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
public static List<clsvPlatDefaRoleEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvPlatDefaRoleEN> arrObjLst = new List<clsvPlatDefaRoleEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPlatDefaRoleEN objvPlatDefaRoleEN = new clsvPlatDefaRoleEN();
try
{
objvPlatDefaRoleEN.mId = Int32.Parse(objRow[convPlatDefaRole.mId].ToString().Trim()); //mId
objvPlatDefaRoleEN.IdSchool = objRow[convPlatDefaRole.IdSchool] == DBNull.Value ? null : objRow[convPlatDefaRole.IdSchool].ToString().Trim(); //学校流水号
objvPlatDefaRoleEN.SchoolId = objRow[convPlatDefaRole.SchoolId].ToString().Trim(); //学校编号
objvPlatDefaRoleEN.IsCurrentUse = clsEntityBase2.TransNullToBool_S(objRow[convPlatDefaRole.IsCurrentUse].ToString().Trim()); //是否当前使用
objvPlatDefaRoleEN.SchoolName = objRow[convPlatDefaRole.SchoolName].ToString().Trim(); //学校名称
objvPlatDefaRoleEN.PersonType = objRow[convPlatDefaRole.PersonType].ToString().Trim(); //人员类别
objvPlatDefaRoleEN.PrjId = objRow[convPlatDefaRole.PrjId] == DBNull.Value ? null : objRow[convPlatDefaRole.PrjId].ToString().Trim(); //PrjId
objvPlatDefaRoleEN.RoleId = objRow[convPlatDefaRole.RoleId].ToString().Trim(); //角色Id
objvPlatDefaRoleEN.Memo = objRow[convPlatDefaRole.Memo] == DBNull.Value ? null : objRow[convPlatDefaRole.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPlatDefaRoleEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPlatDefaRoleEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvPlatDefaRoleEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvPlatDefaRoleEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvPlatDefaRoleEN> arrObjLst = new List<clsvPlatDefaRoleEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPlatDefaRoleEN objvPlatDefaRoleEN = new clsvPlatDefaRoleEN();
try
{
objvPlatDefaRoleEN.mId = Int32.Parse(objRow[convPlatDefaRole.mId].ToString().Trim()); //mId
objvPlatDefaRoleEN.IdSchool = objRow[convPlatDefaRole.IdSchool] == DBNull.Value ? null : objRow[convPlatDefaRole.IdSchool].ToString().Trim(); //学校流水号
objvPlatDefaRoleEN.SchoolId = objRow[convPlatDefaRole.SchoolId].ToString().Trim(); //学校编号
objvPlatDefaRoleEN.IsCurrentUse = clsEntityBase2.TransNullToBool_S(objRow[convPlatDefaRole.IsCurrentUse].ToString().Trim()); //是否当前使用
objvPlatDefaRoleEN.SchoolName = objRow[convPlatDefaRole.SchoolName].ToString().Trim(); //学校名称
objvPlatDefaRoleEN.PersonType = objRow[convPlatDefaRole.PersonType].ToString().Trim(); //人员类别
objvPlatDefaRoleEN.PrjId = objRow[convPlatDefaRole.PrjId] == DBNull.Value ? null : objRow[convPlatDefaRole.PrjId].ToString().Trim(); //PrjId
objvPlatDefaRoleEN.RoleId = objRow[convPlatDefaRole.RoleId].ToString().Trim(); //角色Id
objvPlatDefaRoleEN.Memo = objRow[convPlatDefaRole.Memo] == DBNull.Value ? null : objRow[convPlatDefaRole.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPlatDefaRoleEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPlatDefaRoleEN);
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
public static List<clsvPlatDefaRoleEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvPlatDefaRoleEN> arrObjLst = new List<clsvPlatDefaRoleEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPlatDefaRoleEN objvPlatDefaRoleEN = new clsvPlatDefaRoleEN();
try
{
objvPlatDefaRoleEN.mId = Int32.Parse(objRow[convPlatDefaRole.mId].ToString().Trim()); //mId
objvPlatDefaRoleEN.IdSchool = objRow[convPlatDefaRole.IdSchool] == DBNull.Value ? null : objRow[convPlatDefaRole.IdSchool].ToString().Trim(); //学校流水号
objvPlatDefaRoleEN.SchoolId = objRow[convPlatDefaRole.SchoolId].ToString().Trim(); //学校编号
objvPlatDefaRoleEN.IsCurrentUse = clsEntityBase2.TransNullToBool_S(objRow[convPlatDefaRole.IsCurrentUse].ToString().Trim()); //是否当前使用
objvPlatDefaRoleEN.SchoolName = objRow[convPlatDefaRole.SchoolName].ToString().Trim(); //学校名称
objvPlatDefaRoleEN.PersonType = objRow[convPlatDefaRole.PersonType].ToString().Trim(); //人员类别
objvPlatDefaRoleEN.PrjId = objRow[convPlatDefaRole.PrjId] == DBNull.Value ? null : objRow[convPlatDefaRole.PrjId].ToString().Trim(); //PrjId
objvPlatDefaRoleEN.RoleId = objRow[convPlatDefaRole.RoleId].ToString().Trim(); //角色Id
objvPlatDefaRoleEN.Memo = objRow[convPlatDefaRole.Memo] == DBNull.Value ? null : objRow[convPlatDefaRole.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPlatDefaRoleEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPlatDefaRoleEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvPlatDefaRoleEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvPlatDefaRoleEN> arrObjLst = new List<clsvPlatDefaRoleEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPlatDefaRoleEN objvPlatDefaRoleEN = new clsvPlatDefaRoleEN();
try
{
objvPlatDefaRoleEN.mId = Int32.Parse(objRow[convPlatDefaRole.mId].ToString().Trim()); //mId
objvPlatDefaRoleEN.IdSchool = objRow[convPlatDefaRole.IdSchool] == DBNull.Value ? null : objRow[convPlatDefaRole.IdSchool].ToString().Trim(); //学校流水号
objvPlatDefaRoleEN.SchoolId = objRow[convPlatDefaRole.SchoolId].ToString().Trim(); //学校编号
objvPlatDefaRoleEN.IsCurrentUse = clsEntityBase2.TransNullToBool_S(objRow[convPlatDefaRole.IsCurrentUse].ToString().Trim()); //是否当前使用
objvPlatDefaRoleEN.SchoolName = objRow[convPlatDefaRole.SchoolName].ToString().Trim(); //学校名称
objvPlatDefaRoleEN.PersonType = objRow[convPlatDefaRole.PersonType].ToString().Trim(); //人员类别
objvPlatDefaRoleEN.PrjId = objRow[convPlatDefaRole.PrjId] == DBNull.Value ? null : objRow[convPlatDefaRole.PrjId].ToString().Trim(); //PrjId
objvPlatDefaRoleEN.RoleId = objRow[convPlatDefaRole.RoleId].ToString().Trim(); //角色Id
objvPlatDefaRoleEN.Memo = objRow[convPlatDefaRole.Memo] == DBNull.Value ? null : objRow[convPlatDefaRole.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPlatDefaRoleEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPlatDefaRoleEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvPlatDefaRoleEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvPlatDefaRole(ref clsvPlatDefaRoleEN objvPlatDefaRoleEN)
{
bool bolResult = vPlatDefaRoleDA.GetvPlatDefaRole(ref objvPlatDefaRoleEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvPlatDefaRoleEN GetObjBymId(long lngmId)
{
clsvPlatDefaRoleEN objvPlatDefaRoleEN = vPlatDefaRoleDA.GetObjBymId(lngmId);
return objvPlatDefaRoleEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvPlatDefaRoleEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvPlatDefaRoleEN objvPlatDefaRoleEN = vPlatDefaRoleDA.GetFirstObj(strWhereCond);
 return objvPlatDefaRoleEN;
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
public static clsvPlatDefaRoleEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvPlatDefaRoleEN objvPlatDefaRoleEN = vPlatDefaRoleDA.GetObjByDataRow(objRow);
 return objvPlatDefaRoleEN;
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
public static clsvPlatDefaRoleEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvPlatDefaRoleEN objvPlatDefaRoleEN = vPlatDefaRoleDA.GetObjByDataRow(objRow);
 return objvPlatDefaRoleEN;
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
 /// <param name = "lstvPlatDefaRoleObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvPlatDefaRoleEN GetObjBymIdFromList(long lngmId, List<clsvPlatDefaRoleEN> lstvPlatDefaRoleObjLst)
{
foreach (clsvPlatDefaRoleEN objvPlatDefaRoleEN in lstvPlatDefaRoleObjLst)
{
if (objvPlatDefaRoleEN.mId == lngmId)
{
return objvPlatDefaRoleEN;
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
 lngmId = new clsvPlatDefaRoleDA().GetFirstID(strWhereCond);
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
 arrList = vPlatDefaRoleDA.GetID(strWhereCond);
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
bool bolIsExist = vPlatDefaRoleDA.IsExistCondRec(strWhereCond);
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
bool bolIsExist = vPlatDefaRoleDA.IsExist(lngmId);
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
 bolIsExist = clsvPlatDefaRoleDA.IsExistTable();
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
 bolIsExist = vPlatDefaRoleDA.IsExistTable(strTabName);
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
 /// <param name = "objvPlatDefaRoleENS">源对象</param>
 /// <param name = "objvPlatDefaRoleENT">目标对象</param>
 public static void CopyTo(clsvPlatDefaRoleEN objvPlatDefaRoleENS, clsvPlatDefaRoleEN objvPlatDefaRoleENT)
{
try
{
objvPlatDefaRoleENT.mId = objvPlatDefaRoleENS.mId; //mId
objvPlatDefaRoleENT.IdSchool = objvPlatDefaRoleENS.IdSchool; //学校流水号
objvPlatDefaRoleENT.SchoolId = objvPlatDefaRoleENS.SchoolId; //学校编号
objvPlatDefaRoleENT.IsCurrentUse = objvPlatDefaRoleENS.IsCurrentUse; //是否当前使用
objvPlatDefaRoleENT.SchoolName = objvPlatDefaRoleENS.SchoolName; //学校名称
objvPlatDefaRoleENT.PersonType = objvPlatDefaRoleENS.PersonType; //人员类别
objvPlatDefaRoleENT.PrjId = objvPlatDefaRoleENS.PrjId; //PrjId
objvPlatDefaRoleENT.RoleId = objvPlatDefaRoleENS.RoleId; //角色Id
objvPlatDefaRoleENT.Memo = objvPlatDefaRoleENS.Memo; //备注
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
 /// <param name = "objvPlatDefaRoleEN">源简化对象</param>
 public static void SetUpdFlag(clsvPlatDefaRoleEN objvPlatDefaRoleEN)
{
try
{
objvPlatDefaRoleEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvPlatDefaRoleEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convPlatDefaRole.mId, new clsStrCompareIgnoreCase())  ==  true)
{
objvPlatDefaRoleEN.mId = objvPlatDefaRoleEN.mId; //mId
}
if (arrFldSet.Contains(convPlatDefaRole.IdSchool, new clsStrCompareIgnoreCase())  ==  true)
{
objvPlatDefaRoleEN.IdSchool = objvPlatDefaRoleEN.IdSchool == "[null]" ? null :  objvPlatDefaRoleEN.IdSchool; //学校流水号
}
if (arrFldSet.Contains(convPlatDefaRole.SchoolId, new clsStrCompareIgnoreCase())  ==  true)
{
objvPlatDefaRoleEN.SchoolId = objvPlatDefaRoleEN.SchoolId; //学校编号
}
if (arrFldSet.Contains(convPlatDefaRole.IsCurrentUse, new clsStrCompareIgnoreCase())  ==  true)
{
objvPlatDefaRoleEN.IsCurrentUse = objvPlatDefaRoleEN.IsCurrentUse; //是否当前使用
}
if (arrFldSet.Contains(convPlatDefaRole.SchoolName, new clsStrCompareIgnoreCase())  ==  true)
{
objvPlatDefaRoleEN.SchoolName = objvPlatDefaRoleEN.SchoolName; //学校名称
}
if (arrFldSet.Contains(convPlatDefaRole.PersonType, new clsStrCompareIgnoreCase())  ==  true)
{
objvPlatDefaRoleEN.PersonType = objvPlatDefaRoleEN.PersonType; //人员类别
}
if (arrFldSet.Contains(convPlatDefaRole.PrjId, new clsStrCompareIgnoreCase())  ==  true)
{
objvPlatDefaRoleEN.PrjId = objvPlatDefaRoleEN.PrjId == "[null]" ? null :  objvPlatDefaRoleEN.PrjId; //PrjId
}
if (arrFldSet.Contains(convPlatDefaRole.RoleId, new clsStrCompareIgnoreCase())  ==  true)
{
objvPlatDefaRoleEN.RoleId = objvPlatDefaRoleEN.RoleId; //角色Id
}
if (arrFldSet.Contains(convPlatDefaRole.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvPlatDefaRoleEN.Memo = objvPlatDefaRoleEN.Memo == "[null]" ? null :  objvPlatDefaRoleEN.Memo; //备注
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
 /// <param name = "objvPlatDefaRoleEN">源简化对象</param>
 public static void AccessFldValueNull(clsvPlatDefaRoleEN objvPlatDefaRoleEN)
{
try
{
if (objvPlatDefaRoleEN.IdSchool == "[null]") objvPlatDefaRoleEN.IdSchool = null; //学校流水号
if (objvPlatDefaRoleEN.PrjId == "[null]") objvPlatDefaRoleEN.PrjId = null; //PrjId
if (objvPlatDefaRoleEN.Memo == "[null]") objvPlatDefaRoleEN.Memo = null; //备注
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
public static void CheckProperty4Condition(clsvPlatDefaRoleEN objvPlatDefaRoleEN)
{
 vPlatDefaRoleDA.CheckProperty4Condition(objvPlatDefaRoleEN);
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
if (clsXzSchoolBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzSchoolBL没有刷新缓存机制(clsXzSchoolBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsPlatDefaRoleBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsPlatDefaRoleBL没有刷新缓存机制(clsPlatDefaRoleBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by mId");
//if (arrvPlatDefaRoleObjLstCache == null)
//{
//arrvPlatDefaRoleObjLstCache = vPlatDefaRoleDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngmId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvPlatDefaRoleEN GetObjBymIdCache(long lngmId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvPlatDefaRoleEN._CurrTabName);
List<clsvPlatDefaRoleEN> arrvPlatDefaRoleObjLstCache = GetObjLstCache();
IEnumerable <clsvPlatDefaRoleEN> arrvPlatDefaRoleObjLst_Sel =
arrvPlatDefaRoleObjLstCache
.Where(x=> x.mId == lngmId 
);
if (arrvPlatDefaRoleObjLst_Sel.Count() == 0)
{
   clsvPlatDefaRoleEN obj = clsvPlatDefaRoleBL.GetObjBymId(lngmId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvPlatDefaRoleObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvPlatDefaRoleEN> GetAllvPlatDefaRoleObjLstCache()
{
//获取缓存中的对象列表
List<clsvPlatDefaRoleEN> arrvPlatDefaRoleObjLstCache = GetObjLstCache(); 
return arrvPlatDefaRoleObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvPlatDefaRoleEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvPlatDefaRoleEN._CurrTabName);
List<clsvPlatDefaRoleEN> arrvPlatDefaRoleObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvPlatDefaRoleObjLstCache;
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
string strKey = string.Format("{0}", clsvPlatDefaRoleEN._CurrTabName);
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
public static string Func(string strInFldName, string strOutFldName, long lngmId)
{
if (strInFldName != convPlatDefaRole.mId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convPlatDefaRole.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convPlatDefaRole.AttributeName));
throw new Exception(strMsg);
}
var objvPlatDefaRole = clsvPlatDefaRoleBL.GetObjBymIdCache(lngmId);
if (objvPlatDefaRole == null) return "";
return objvPlatDefaRole[strOutFldName].ToString();
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
int intRecCount = clsvPlatDefaRoleDA.GetRecCount(strTabName);
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
int intRecCount = clsvPlatDefaRoleDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvPlatDefaRoleDA.GetRecCount();
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
int intRecCount = clsvPlatDefaRoleDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvPlatDefaRoleCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvPlatDefaRoleEN objvPlatDefaRoleCond)
{
List<clsvPlatDefaRoleEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvPlatDefaRoleEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convPlatDefaRole.AttributeName)
{
if (objvPlatDefaRoleCond.IsUpdated(strFldName) == false) continue;
if (objvPlatDefaRoleCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvPlatDefaRoleCond[strFldName].ToString());
}
else
{
if (objvPlatDefaRoleCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvPlatDefaRoleCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvPlatDefaRoleCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvPlatDefaRoleCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvPlatDefaRoleCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvPlatDefaRoleCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvPlatDefaRoleCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvPlatDefaRoleCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvPlatDefaRoleCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvPlatDefaRoleCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvPlatDefaRoleCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvPlatDefaRoleCond[strFldName]));
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
 List<string> arrList = clsvPlatDefaRoleDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vPlatDefaRoleDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vPlatDefaRoleDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}