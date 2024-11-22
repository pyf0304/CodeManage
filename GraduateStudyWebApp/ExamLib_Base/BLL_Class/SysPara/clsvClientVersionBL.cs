
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvClientVersionBL
 表名:vClientVersion(01120278)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:45:21
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
public static class  clsvClientVersionBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strClientVersionId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvClientVersionEN GetObj(this K_ClientVersionId_vClientVersion myKey)
{
clsvClientVersionEN objvClientVersionEN = clsvClientVersionBL.vClientVersionDA.GetObjByClientVersionId(myKey.Value);
return objvClientVersionEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClientVersionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvClientVersionEN SetClientVersionId(this clsvClientVersionEN objvClientVersionEN, string strClientVersionId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strClientVersionId, 8, convClientVersion.ClientVersionId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strClientVersionId, 8, convClientVersion.ClientVersionId);
}
objvClientVersionEN.ClientVersionId = strClientVersionId; //客户端版本Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClientVersionEN.dicFldComparisonOp.ContainsKey(convClientVersion.ClientVersionId) == false)
{
objvClientVersionEN.dicFldComparisonOp.Add(convClientVersion.ClientVersionId, strComparisonOp);
}
else
{
objvClientVersionEN.dicFldComparisonOp[convClientVersion.ClientVersionId] = strComparisonOp;
}
}
return objvClientVersionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClientVersionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvClientVersionEN SetClientVersionTypeId(this clsvClientVersionEN objvClientVersionEN, string strClientVersionTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strClientVersionTypeId, convClientVersion.ClientVersionTypeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strClientVersionTypeId, 8, convClientVersion.ClientVersionTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strClientVersionTypeId, 8, convClientVersion.ClientVersionTypeId);
}
objvClientVersionEN.ClientVersionTypeId = strClientVersionTypeId; //客户端版本类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClientVersionEN.dicFldComparisonOp.ContainsKey(convClientVersion.ClientVersionTypeId) == false)
{
objvClientVersionEN.dicFldComparisonOp.Add(convClientVersion.ClientVersionTypeId, strComparisonOp);
}
else
{
objvClientVersionEN.dicFldComparisonOp[convClientVersion.ClientVersionTypeId] = strComparisonOp;
}
}
return objvClientVersionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClientVersionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvClientVersionEN SetClientVersionTypeName(this clsvClientVersionEN objvClientVersionEN, string strClientVersionTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strClientVersionTypeName, 50, convClientVersion.ClientVersionTypeName);
}
objvClientVersionEN.ClientVersionTypeName = strClientVersionTypeName; //客户端版本类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClientVersionEN.dicFldComparisonOp.ContainsKey(convClientVersion.ClientVersionTypeName) == false)
{
objvClientVersionEN.dicFldComparisonOp.Add(convClientVersion.ClientVersionTypeName, strComparisonOp);
}
else
{
objvClientVersionEN.dicFldComparisonOp[convClientVersion.ClientVersionTypeName] = strComparisonOp;
}
}
return objvClientVersionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClientVersionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvClientVersionEN SetVersionDescription(this clsvClientVersionEN objvClientVersionEN, string strVersionDescription, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strVersionDescription, 1000, convClientVersion.VersionDescription);
}
objvClientVersionEN.VersionDescription = strVersionDescription; //版本说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClientVersionEN.dicFldComparisonOp.ContainsKey(convClientVersion.VersionDescription) == false)
{
objvClientVersionEN.dicFldComparisonOp.Add(convClientVersion.VersionDescription, strComparisonOp);
}
else
{
objvClientVersionEN.dicFldComparisonOp[convClientVersion.VersionDescription] = strComparisonOp;
}
}
return objvClientVersionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClientVersionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvClientVersionEN SetVersionNumber(this clsvClientVersionEN objvClientVersionEN, string strVersionNumber, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strVersionNumber, convClientVersion.VersionNumber);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strVersionNumber, 50, convClientVersion.VersionNumber);
}
objvClientVersionEN.VersionNumber = strVersionNumber; //版本号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClientVersionEN.dicFldComparisonOp.ContainsKey(convClientVersion.VersionNumber) == false)
{
objvClientVersionEN.dicFldComparisonOp.Add(convClientVersion.VersionNumber, strComparisonOp);
}
else
{
objvClientVersionEN.dicFldComparisonOp[convClientVersion.VersionNumber] = strComparisonOp;
}
}
return objvClientVersionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClientVersionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvClientVersionEN SetVersionState(this clsvClientVersionEN objvClientVersionEN, bool bolVersionState, string strComparisonOp="")
	{
objvClientVersionEN.VersionState = bolVersionState; //版本状态
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClientVersionEN.dicFldComparisonOp.ContainsKey(convClientVersion.VersionState) == false)
{
objvClientVersionEN.dicFldComparisonOp.Add(convClientVersion.VersionState, strComparisonOp);
}
else
{
objvClientVersionEN.dicFldComparisonOp[convClientVersion.VersionState] = strComparisonOp;
}
}
return objvClientVersionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClientVersionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvClientVersionEN SetVersionUrl(this clsvClientVersionEN objvClientVersionEN, string strVersionUrl, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strVersionUrl, convClientVersion.VersionUrl);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strVersionUrl, 500, convClientVersion.VersionUrl);
}
objvClientVersionEN.VersionUrl = strVersionUrl; //版本文件
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClientVersionEN.dicFldComparisonOp.ContainsKey(convClientVersion.VersionUrl) == false)
{
objvClientVersionEN.dicFldComparisonOp.Add(convClientVersion.VersionUrl, strComparisonOp);
}
else
{
objvClientVersionEN.dicFldComparisonOp[convClientVersion.VersionUrl] = strComparisonOp;
}
}
return objvClientVersionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClientVersionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvClientVersionEN SetUpdDate(this clsvClientVersionEN objvClientVersionEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convClientVersion.UpdDate);
}
objvClientVersionEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClientVersionEN.dicFldComparisonOp.ContainsKey(convClientVersion.UpdDate) == false)
{
objvClientVersionEN.dicFldComparisonOp.Add(convClientVersion.UpdDate, strComparisonOp);
}
else
{
objvClientVersionEN.dicFldComparisonOp[convClientVersion.UpdDate] = strComparisonOp;
}
}
return objvClientVersionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClientVersionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvClientVersionEN SetUpdUser(this clsvClientVersionEN objvClientVersionEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convClientVersion.UpdUser);
}
objvClientVersionEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClientVersionEN.dicFldComparisonOp.ContainsKey(convClientVersion.UpdUser) == false)
{
objvClientVersionEN.dicFldComparisonOp.Add(convClientVersion.UpdUser, strComparisonOp);
}
else
{
objvClientVersionEN.dicFldComparisonOp[convClientVersion.UpdUser] = strComparisonOp;
}
}
return objvClientVersionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClientVersionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvClientVersionEN SetMemo(this clsvClientVersionEN objvClientVersionEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convClientVersion.Memo);
}
objvClientVersionEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClientVersionEN.dicFldComparisonOp.ContainsKey(convClientVersion.Memo) == false)
{
objvClientVersionEN.dicFldComparisonOp.Add(convClientVersion.Memo, strComparisonOp);
}
else
{
objvClientVersionEN.dicFldComparisonOp[convClientVersion.Memo] = strComparisonOp;
}
}
return objvClientVersionEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvClientVersionENS">源对象</param>
 /// <param name = "objvClientVersionENT">目标对象</param>
 public static void CopyTo(this clsvClientVersionEN objvClientVersionENS, clsvClientVersionEN objvClientVersionENT)
{
try
{
objvClientVersionENT.ClientVersionId = objvClientVersionENS.ClientVersionId; //客户端版本Id
objvClientVersionENT.ClientVersionTypeId = objvClientVersionENS.ClientVersionTypeId; //客户端版本类型Id
objvClientVersionENT.ClientVersionTypeName = objvClientVersionENS.ClientVersionTypeName; //客户端版本类型名称
objvClientVersionENT.VersionDescription = objvClientVersionENS.VersionDescription; //版本说明
objvClientVersionENT.VersionNumber = objvClientVersionENS.VersionNumber; //版本号
objvClientVersionENT.VersionState = objvClientVersionENS.VersionState; //版本状态
objvClientVersionENT.VersionUrl = objvClientVersionENS.VersionUrl; //版本文件
objvClientVersionENT.UpdDate = objvClientVersionENS.UpdDate; //修改日期
objvClientVersionENT.UpdUser = objvClientVersionENS.UpdUser; //修改人
objvClientVersionENT.Memo = objvClientVersionENS.Memo; //备注
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
 /// <param name = "objvClientVersionENS">源对象</param>
 /// <returns>目标对象=>clsvClientVersionEN:objvClientVersionENT</returns>
 public static clsvClientVersionEN CopyTo(this clsvClientVersionEN objvClientVersionENS)
{
try
{
 clsvClientVersionEN objvClientVersionENT = new clsvClientVersionEN()
{
ClientVersionId = objvClientVersionENS.ClientVersionId, //客户端版本Id
ClientVersionTypeId = objvClientVersionENS.ClientVersionTypeId, //客户端版本类型Id
ClientVersionTypeName = objvClientVersionENS.ClientVersionTypeName, //客户端版本类型名称
VersionDescription = objvClientVersionENS.VersionDescription, //版本说明
VersionNumber = objvClientVersionENS.VersionNumber, //版本号
VersionState = objvClientVersionENS.VersionState, //版本状态
VersionUrl = objvClientVersionENS.VersionUrl, //版本文件
UpdDate = objvClientVersionENS.UpdDate, //修改日期
UpdUser = objvClientVersionENS.UpdUser, //修改人
Memo = objvClientVersionENS.Memo, //备注
};
 return objvClientVersionENT;
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
public static void CheckProperty4Condition(this clsvClientVersionEN objvClientVersionEN)
{
 clsvClientVersionBL.vClientVersionDA.CheckProperty4Condition(objvClientVersionEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvClientVersionEN objvClientVersionCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvClientVersionCond.IsUpdated(convClientVersion.ClientVersionId) == true)
{
string strComparisonOpClientVersionId = objvClientVersionCond.dicFldComparisonOp[convClientVersion.ClientVersionId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClientVersion.ClientVersionId, objvClientVersionCond.ClientVersionId, strComparisonOpClientVersionId);
}
if (objvClientVersionCond.IsUpdated(convClientVersion.ClientVersionTypeId) == true)
{
string strComparisonOpClientVersionTypeId = objvClientVersionCond.dicFldComparisonOp[convClientVersion.ClientVersionTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClientVersion.ClientVersionTypeId, objvClientVersionCond.ClientVersionTypeId, strComparisonOpClientVersionTypeId);
}
if (objvClientVersionCond.IsUpdated(convClientVersion.ClientVersionTypeName) == true)
{
string strComparisonOpClientVersionTypeName = objvClientVersionCond.dicFldComparisonOp[convClientVersion.ClientVersionTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClientVersion.ClientVersionTypeName, objvClientVersionCond.ClientVersionTypeName, strComparisonOpClientVersionTypeName);
}
if (objvClientVersionCond.IsUpdated(convClientVersion.VersionDescription) == true)
{
string strComparisonOpVersionDescription = objvClientVersionCond.dicFldComparisonOp[convClientVersion.VersionDescription];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClientVersion.VersionDescription, objvClientVersionCond.VersionDescription, strComparisonOpVersionDescription);
}
if (objvClientVersionCond.IsUpdated(convClientVersion.VersionNumber) == true)
{
string strComparisonOpVersionNumber = objvClientVersionCond.dicFldComparisonOp[convClientVersion.VersionNumber];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClientVersion.VersionNumber, objvClientVersionCond.VersionNumber, strComparisonOpVersionNumber);
}
if (objvClientVersionCond.IsUpdated(convClientVersion.VersionState) == true)
{
if (objvClientVersionCond.VersionState == true)
{
strWhereCond += string.Format(" And {0} = '1'", convClientVersion.VersionState);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convClientVersion.VersionState);
}
}
if (objvClientVersionCond.IsUpdated(convClientVersion.VersionUrl) == true)
{
string strComparisonOpVersionUrl = objvClientVersionCond.dicFldComparisonOp[convClientVersion.VersionUrl];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClientVersion.VersionUrl, objvClientVersionCond.VersionUrl, strComparisonOpVersionUrl);
}
if (objvClientVersionCond.IsUpdated(convClientVersion.UpdDate) == true)
{
string strComparisonOpUpdDate = objvClientVersionCond.dicFldComparisonOp[convClientVersion.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClientVersion.UpdDate, objvClientVersionCond.UpdDate, strComparisonOpUpdDate);
}
if (objvClientVersionCond.IsUpdated(convClientVersion.UpdUser) == true)
{
string strComparisonOpUpdUser = objvClientVersionCond.dicFldComparisonOp[convClientVersion.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClientVersion.UpdUser, objvClientVersionCond.UpdUser, strComparisonOpUpdUser);
}
if (objvClientVersionCond.IsUpdated(convClientVersion.Memo) == true)
{
string strComparisonOpMemo = objvClientVersionCond.dicFldComparisonOp[convClientVersion.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClientVersion.Memo, objvClientVersionCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vClientVersion
{
public virtual bool UpdRelaTabDate(string strClientVersionId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v客户端版本(vClientVersion)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvClientVersionBL
{
public static RelatedActions_vClientVersion relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvClientVersionDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvClientVersionDA vClientVersionDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvClientVersionDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvClientVersionBL()
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
if (string.IsNullOrEmpty(clsvClientVersionEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvClientVersionEN._ConnectString);
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
public static DataTable GetDataTable_vClientVersion(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vClientVersionDA.GetDataTable_vClientVersion(strWhereCond);
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
objDT = vClientVersionDA.GetDataTable(strWhereCond);
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
objDT = vClientVersionDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vClientVersionDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vClientVersionDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vClientVersionDA.GetDataTable_Top(objTopPara);
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
objDT = vClientVersionDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vClientVersionDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vClientVersionDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrClientVersionIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvClientVersionEN> GetObjLstByClientVersionIdLst(List<string> arrClientVersionIdLst)
{
List<clsvClientVersionEN> arrObjLst = new List<clsvClientVersionEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrClientVersionIdLst, true);
 string strWhereCond = string.Format("ClientVersionId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvClientVersionEN objvClientVersionEN = new clsvClientVersionEN();
try
{
objvClientVersionEN.ClientVersionId = objRow[convClientVersion.ClientVersionId].ToString().Trim(); //客户端版本Id
objvClientVersionEN.ClientVersionTypeId = objRow[convClientVersion.ClientVersionTypeId].ToString().Trim(); //客户端版本类型Id
objvClientVersionEN.ClientVersionTypeName = objRow[convClientVersion.ClientVersionTypeName] == DBNull.Value ? null : objRow[convClientVersion.ClientVersionTypeName].ToString().Trim(); //客户端版本类型名称
objvClientVersionEN.VersionDescription = objRow[convClientVersion.VersionDescription] == DBNull.Value ? null : objRow[convClientVersion.VersionDescription].ToString().Trim(); //版本说明
objvClientVersionEN.VersionNumber = objRow[convClientVersion.VersionNumber].ToString().Trim(); //版本号
objvClientVersionEN.VersionState = clsEntityBase2.TransNullToBool_S(objRow[convClientVersion.VersionState].ToString().Trim()); //版本状态
objvClientVersionEN.VersionUrl = objRow[convClientVersion.VersionUrl].ToString().Trim(); //版本文件
objvClientVersionEN.UpdDate = objRow[convClientVersion.UpdDate] == DBNull.Value ? null : objRow[convClientVersion.UpdDate].ToString().Trim(); //修改日期
objvClientVersionEN.UpdUser = objRow[convClientVersion.UpdUser] == DBNull.Value ? null : objRow[convClientVersion.UpdUser].ToString().Trim(); //修改人
objvClientVersionEN.Memo = objRow[convClientVersion.Memo] == DBNull.Value ? null : objRow[convClientVersion.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvClientVersionEN.ClientVersionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvClientVersionEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrClientVersionIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvClientVersionEN> GetObjLstByClientVersionIdLstCache(List<string> arrClientVersionIdLst)
{
string strKey = string.Format("{0}", clsvClientVersionEN._CurrTabName);
List<clsvClientVersionEN> arrvClientVersionObjLstCache = GetObjLstCache();
IEnumerable <clsvClientVersionEN> arrvClientVersionObjLst_Sel =
arrvClientVersionObjLstCache
.Where(x => arrClientVersionIdLst.Contains(x.ClientVersionId));
return arrvClientVersionObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvClientVersionEN> GetObjLst(string strWhereCond)
{
List<clsvClientVersionEN> arrObjLst = new List<clsvClientVersionEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvClientVersionEN objvClientVersionEN = new clsvClientVersionEN();
try
{
objvClientVersionEN.ClientVersionId = objRow[convClientVersion.ClientVersionId].ToString().Trim(); //客户端版本Id
objvClientVersionEN.ClientVersionTypeId = objRow[convClientVersion.ClientVersionTypeId].ToString().Trim(); //客户端版本类型Id
objvClientVersionEN.ClientVersionTypeName = objRow[convClientVersion.ClientVersionTypeName] == DBNull.Value ? null : objRow[convClientVersion.ClientVersionTypeName].ToString().Trim(); //客户端版本类型名称
objvClientVersionEN.VersionDescription = objRow[convClientVersion.VersionDescription] == DBNull.Value ? null : objRow[convClientVersion.VersionDescription].ToString().Trim(); //版本说明
objvClientVersionEN.VersionNumber = objRow[convClientVersion.VersionNumber].ToString().Trim(); //版本号
objvClientVersionEN.VersionState = clsEntityBase2.TransNullToBool_S(objRow[convClientVersion.VersionState].ToString().Trim()); //版本状态
objvClientVersionEN.VersionUrl = objRow[convClientVersion.VersionUrl].ToString().Trim(); //版本文件
objvClientVersionEN.UpdDate = objRow[convClientVersion.UpdDate] == DBNull.Value ? null : objRow[convClientVersion.UpdDate].ToString().Trim(); //修改日期
objvClientVersionEN.UpdUser = objRow[convClientVersion.UpdUser] == DBNull.Value ? null : objRow[convClientVersion.UpdUser].ToString().Trim(); //修改人
objvClientVersionEN.Memo = objRow[convClientVersion.Memo] == DBNull.Value ? null : objRow[convClientVersion.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvClientVersionEN.ClientVersionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvClientVersionEN);
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
public static List<clsvClientVersionEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvClientVersionEN> arrObjLst = new List<clsvClientVersionEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvClientVersionEN objvClientVersionEN = new clsvClientVersionEN();
try
{
objvClientVersionEN.ClientVersionId = objRow[convClientVersion.ClientVersionId].ToString().Trim(); //客户端版本Id
objvClientVersionEN.ClientVersionTypeId = objRow[convClientVersion.ClientVersionTypeId].ToString().Trim(); //客户端版本类型Id
objvClientVersionEN.ClientVersionTypeName = objRow[convClientVersion.ClientVersionTypeName] == DBNull.Value ? null : objRow[convClientVersion.ClientVersionTypeName].ToString().Trim(); //客户端版本类型名称
objvClientVersionEN.VersionDescription = objRow[convClientVersion.VersionDescription] == DBNull.Value ? null : objRow[convClientVersion.VersionDescription].ToString().Trim(); //版本说明
objvClientVersionEN.VersionNumber = objRow[convClientVersion.VersionNumber].ToString().Trim(); //版本号
objvClientVersionEN.VersionState = clsEntityBase2.TransNullToBool_S(objRow[convClientVersion.VersionState].ToString().Trim()); //版本状态
objvClientVersionEN.VersionUrl = objRow[convClientVersion.VersionUrl].ToString().Trim(); //版本文件
objvClientVersionEN.UpdDate = objRow[convClientVersion.UpdDate] == DBNull.Value ? null : objRow[convClientVersion.UpdDate].ToString().Trim(); //修改日期
objvClientVersionEN.UpdUser = objRow[convClientVersion.UpdUser] == DBNull.Value ? null : objRow[convClientVersion.UpdUser].ToString().Trim(); //修改人
objvClientVersionEN.Memo = objRow[convClientVersion.Memo] == DBNull.Value ? null : objRow[convClientVersion.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvClientVersionEN.ClientVersionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvClientVersionEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvClientVersionCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvClientVersionEN> GetSubObjLstCache(clsvClientVersionEN objvClientVersionCond)
{
List<clsvClientVersionEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvClientVersionEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convClientVersion.AttributeName)
{
if (objvClientVersionCond.IsUpdated(strFldName) == false) continue;
if (objvClientVersionCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvClientVersionCond[strFldName].ToString());
}
else
{
if (objvClientVersionCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvClientVersionCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvClientVersionCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvClientVersionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvClientVersionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvClientVersionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvClientVersionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvClientVersionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvClientVersionCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvClientVersionCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvClientVersionCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvClientVersionCond[strFldName]));
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
public static List<clsvClientVersionEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvClientVersionEN> arrObjLst = new List<clsvClientVersionEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvClientVersionEN objvClientVersionEN = new clsvClientVersionEN();
try
{
objvClientVersionEN.ClientVersionId = objRow[convClientVersion.ClientVersionId].ToString().Trim(); //客户端版本Id
objvClientVersionEN.ClientVersionTypeId = objRow[convClientVersion.ClientVersionTypeId].ToString().Trim(); //客户端版本类型Id
objvClientVersionEN.ClientVersionTypeName = objRow[convClientVersion.ClientVersionTypeName] == DBNull.Value ? null : objRow[convClientVersion.ClientVersionTypeName].ToString().Trim(); //客户端版本类型名称
objvClientVersionEN.VersionDescription = objRow[convClientVersion.VersionDescription] == DBNull.Value ? null : objRow[convClientVersion.VersionDescription].ToString().Trim(); //版本说明
objvClientVersionEN.VersionNumber = objRow[convClientVersion.VersionNumber].ToString().Trim(); //版本号
objvClientVersionEN.VersionState = clsEntityBase2.TransNullToBool_S(objRow[convClientVersion.VersionState].ToString().Trim()); //版本状态
objvClientVersionEN.VersionUrl = objRow[convClientVersion.VersionUrl].ToString().Trim(); //版本文件
objvClientVersionEN.UpdDate = objRow[convClientVersion.UpdDate] == DBNull.Value ? null : objRow[convClientVersion.UpdDate].ToString().Trim(); //修改日期
objvClientVersionEN.UpdUser = objRow[convClientVersion.UpdUser] == DBNull.Value ? null : objRow[convClientVersion.UpdUser].ToString().Trim(); //修改人
objvClientVersionEN.Memo = objRow[convClientVersion.Memo] == DBNull.Value ? null : objRow[convClientVersion.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvClientVersionEN.ClientVersionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvClientVersionEN);
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
public static List<clsvClientVersionEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvClientVersionEN> arrObjLst = new List<clsvClientVersionEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvClientVersionEN objvClientVersionEN = new clsvClientVersionEN();
try
{
objvClientVersionEN.ClientVersionId = objRow[convClientVersion.ClientVersionId].ToString().Trim(); //客户端版本Id
objvClientVersionEN.ClientVersionTypeId = objRow[convClientVersion.ClientVersionTypeId].ToString().Trim(); //客户端版本类型Id
objvClientVersionEN.ClientVersionTypeName = objRow[convClientVersion.ClientVersionTypeName] == DBNull.Value ? null : objRow[convClientVersion.ClientVersionTypeName].ToString().Trim(); //客户端版本类型名称
objvClientVersionEN.VersionDescription = objRow[convClientVersion.VersionDescription] == DBNull.Value ? null : objRow[convClientVersion.VersionDescription].ToString().Trim(); //版本说明
objvClientVersionEN.VersionNumber = objRow[convClientVersion.VersionNumber].ToString().Trim(); //版本号
objvClientVersionEN.VersionState = clsEntityBase2.TransNullToBool_S(objRow[convClientVersion.VersionState].ToString().Trim()); //版本状态
objvClientVersionEN.VersionUrl = objRow[convClientVersion.VersionUrl].ToString().Trim(); //版本文件
objvClientVersionEN.UpdDate = objRow[convClientVersion.UpdDate] == DBNull.Value ? null : objRow[convClientVersion.UpdDate].ToString().Trim(); //修改日期
objvClientVersionEN.UpdUser = objRow[convClientVersion.UpdUser] == DBNull.Value ? null : objRow[convClientVersion.UpdUser].ToString().Trim(); //修改人
objvClientVersionEN.Memo = objRow[convClientVersion.Memo] == DBNull.Value ? null : objRow[convClientVersion.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvClientVersionEN.ClientVersionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvClientVersionEN);
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
List<clsvClientVersionEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvClientVersionEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvClientVersionEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvClientVersionEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvClientVersionEN> arrObjLst = new List<clsvClientVersionEN>(); 
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
	clsvClientVersionEN objvClientVersionEN = new clsvClientVersionEN();
try
{
objvClientVersionEN.ClientVersionId = objRow[convClientVersion.ClientVersionId].ToString().Trim(); //客户端版本Id
objvClientVersionEN.ClientVersionTypeId = objRow[convClientVersion.ClientVersionTypeId].ToString().Trim(); //客户端版本类型Id
objvClientVersionEN.ClientVersionTypeName = objRow[convClientVersion.ClientVersionTypeName] == DBNull.Value ? null : objRow[convClientVersion.ClientVersionTypeName].ToString().Trim(); //客户端版本类型名称
objvClientVersionEN.VersionDescription = objRow[convClientVersion.VersionDescription] == DBNull.Value ? null : objRow[convClientVersion.VersionDescription].ToString().Trim(); //版本说明
objvClientVersionEN.VersionNumber = objRow[convClientVersion.VersionNumber].ToString().Trim(); //版本号
objvClientVersionEN.VersionState = clsEntityBase2.TransNullToBool_S(objRow[convClientVersion.VersionState].ToString().Trim()); //版本状态
objvClientVersionEN.VersionUrl = objRow[convClientVersion.VersionUrl].ToString().Trim(); //版本文件
objvClientVersionEN.UpdDate = objRow[convClientVersion.UpdDate] == DBNull.Value ? null : objRow[convClientVersion.UpdDate].ToString().Trim(); //修改日期
objvClientVersionEN.UpdUser = objRow[convClientVersion.UpdUser] == DBNull.Value ? null : objRow[convClientVersion.UpdUser].ToString().Trim(); //修改人
objvClientVersionEN.Memo = objRow[convClientVersion.Memo] == DBNull.Value ? null : objRow[convClientVersion.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvClientVersionEN.ClientVersionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvClientVersionEN);
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
public static List<clsvClientVersionEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvClientVersionEN> arrObjLst = new List<clsvClientVersionEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvClientVersionEN objvClientVersionEN = new clsvClientVersionEN();
try
{
objvClientVersionEN.ClientVersionId = objRow[convClientVersion.ClientVersionId].ToString().Trim(); //客户端版本Id
objvClientVersionEN.ClientVersionTypeId = objRow[convClientVersion.ClientVersionTypeId].ToString().Trim(); //客户端版本类型Id
objvClientVersionEN.ClientVersionTypeName = objRow[convClientVersion.ClientVersionTypeName] == DBNull.Value ? null : objRow[convClientVersion.ClientVersionTypeName].ToString().Trim(); //客户端版本类型名称
objvClientVersionEN.VersionDescription = objRow[convClientVersion.VersionDescription] == DBNull.Value ? null : objRow[convClientVersion.VersionDescription].ToString().Trim(); //版本说明
objvClientVersionEN.VersionNumber = objRow[convClientVersion.VersionNumber].ToString().Trim(); //版本号
objvClientVersionEN.VersionState = clsEntityBase2.TransNullToBool_S(objRow[convClientVersion.VersionState].ToString().Trim()); //版本状态
objvClientVersionEN.VersionUrl = objRow[convClientVersion.VersionUrl].ToString().Trim(); //版本文件
objvClientVersionEN.UpdDate = objRow[convClientVersion.UpdDate] == DBNull.Value ? null : objRow[convClientVersion.UpdDate].ToString().Trim(); //修改日期
objvClientVersionEN.UpdUser = objRow[convClientVersion.UpdUser] == DBNull.Value ? null : objRow[convClientVersion.UpdUser].ToString().Trim(); //修改人
objvClientVersionEN.Memo = objRow[convClientVersion.Memo] == DBNull.Value ? null : objRow[convClientVersion.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvClientVersionEN.ClientVersionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvClientVersionEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvClientVersionEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvClientVersionEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvClientVersionEN> arrObjLst = new List<clsvClientVersionEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvClientVersionEN objvClientVersionEN = new clsvClientVersionEN();
try
{
objvClientVersionEN.ClientVersionId = objRow[convClientVersion.ClientVersionId].ToString().Trim(); //客户端版本Id
objvClientVersionEN.ClientVersionTypeId = objRow[convClientVersion.ClientVersionTypeId].ToString().Trim(); //客户端版本类型Id
objvClientVersionEN.ClientVersionTypeName = objRow[convClientVersion.ClientVersionTypeName] == DBNull.Value ? null : objRow[convClientVersion.ClientVersionTypeName].ToString().Trim(); //客户端版本类型名称
objvClientVersionEN.VersionDescription = objRow[convClientVersion.VersionDescription] == DBNull.Value ? null : objRow[convClientVersion.VersionDescription].ToString().Trim(); //版本说明
objvClientVersionEN.VersionNumber = objRow[convClientVersion.VersionNumber].ToString().Trim(); //版本号
objvClientVersionEN.VersionState = clsEntityBase2.TransNullToBool_S(objRow[convClientVersion.VersionState].ToString().Trim()); //版本状态
objvClientVersionEN.VersionUrl = objRow[convClientVersion.VersionUrl].ToString().Trim(); //版本文件
objvClientVersionEN.UpdDate = objRow[convClientVersion.UpdDate] == DBNull.Value ? null : objRow[convClientVersion.UpdDate].ToString().Trim(); //修改日期
objvClientVersionEN.UpdUser = objRow[convClientVersion.UpdUser] == DBNull.Value ? null : objRow[convClientVersion.UpdUser].ToString().Trim(); //修改人
objvClientVersionEN.Memo = objRow[convClientVersion.Memo] == DBNull.Value ? null : objRow[convClientVersion.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvClientVersionEN.ClientVersionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvClientVersionEN);
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
public static List<clsvClientVersionEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvClientVersionEN> arrObjLst = new List<clsvClientVersionEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvClientVersionEN objvClientVersionEN = new clsvClientVersionEN();
try
{
objvClientVersionEN.ClientVersionId = objRow[convClientVersion.ClientVersionId].ToString().Trim(); //客户端版本Id
objvClientVersionEN.ClientVersionTypeId = objRow[convClientVersion.ClientVersionTypeId].ToString().Trim(); //客户端版本类型Id
objvClientVersionEN.ClientVersionTypeName = objRow[convClientVersion.ClientVersionTypeName] == DBNull.Value ? null : objRow[convClientVersion.ClientVersionTypeName].ToString().Trim(); //客户端版本类型名称
objvClientVersionEN.VersionDescription = objRow[convClientVersion.VersionDescription] == DBNull.Value ? null : objRow[convClientVersion.VersionDescription].ToString().Trim(); //版本说明
objvClientVersionEN.VersionNumber = objRow[convClientVersion.VersionNumber].ToString().Trim(); //版本号
objvClientVersionEN.VersionState = clsEntityBase2.TransNullToBool_S(objRow[convClientVersion.VersionState].ToString().Trim()); //版本状态
objvClientVersionEN.VersionUrl = objRow[convClientVersion.VersionUrl].ToString().Trim(); //版本文件
objvClientVersionEN.UpdDate = objRow[convClientVersion.UpdDate] == DBNull.Value ? null : objRow[convClientVersion.UpdDate].ToString().Trim(); //修改日期
objvClientVersionEN.UpdUser = objRow[convClientVersion.UpdUser] == DBNull.Value ? null : objRow[convClientVersion.UpdUser].ToString().Trim(); //修改人
objvClientVersionEN.Memo = objRow[convClientVersion.Memo] == DBNull.Value ? null : objRow[convClientVersion.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvClientVersionEN.ClientVersionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvClientVersionEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvClientVersionEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvClientVersionEN> arrObjLst = new List<clsvClientVersionEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvClientVersionEN objvClientVersionEN = new clsvClientVersionEN();
try
{
objvClientVersionEN.ClientVersionId = objRow[convClientVersion.ClientVersionId].ToString().Trim(); //客户端版本Id
objvClientVersionEN.ClientVersionTypeId = objRow[convClientVersion.ClientVersionTypeId].ToString().Trim(); //客户端版本类型Id
objvClientVersionEN.ClientVersionTypeName = objRow[convClientVersion.ClientVersionTypeName] == DBNull.Value ? null : objRow[convClientVersion.ClientVersionTypeName].ToString().Trim(); //客户端版本类型名称
objvClientVersionEN.VersionDescription = objRow[convClientVersion.VersionDescription] == DBNull.Value ? null : objRow[convClientVersion.VersionDescription].ToString().Trim(); //版本说明
objvClientVersionEN.VersionNumber = objRow[convClientVersion.VersionNumber].ToString().Trim(); //版本号
objvClientVersionEN.VersionState = clsEntityBase2.TransNullToBool_S(objRow[convClientVersion.VersionState].ToString().Trim()); //版本状态
objvClientVersionEN.VersionUrl = objRow[convClientVersion.VersionUrl].ToString().Trim(); //版本文件
objvClientVersionEN.UpdDate = objRow[convClientVersion.UpdDate] == DBNull.Value ? null : objRow[convClientVersion.UpdDate].ToString().Trim(); //修改日期
objvClientVersionEN.UpdUser = objRow[convClientVersion.UpdUser] == DBNull.Value ? null : objRow[convClientVersion.UpdUser].ToString().Trim(); //修改人
objvClientVersionEN.Memo = objRow[convClientVersion.Memo] == DBNull.Value ? null : objRow[convClientVersion.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvClientVersionEN.ClientVersionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvClientVersionEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvClientVersionEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvClientVersion(ref clsvClientVersionEN objvClientVersionEN)
{
bool bolResult = vClientVersionDA.GetvClientVersion(ref objvClientVersionEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strClientVersionId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvClientVersionEN GetObjByClientVersionId(string strClientVersionId)
{
if (strClientVersionId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strClientVersionId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strClientVersionId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strClientVersionId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsvClientVersionEN objvClientVersionEN = vClientVersionDA.GetObjByClientVersionId(strClientVersionId);
return objvClientVersionEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvClientVersionEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvClientVersionEN objvClientVersionEN = vClientVersionDA.GetFirstObj(strWhereCond);
 return objvClientVersionEN;
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
public static clsvClientVersionEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvClientVersionEN objvClientVersionEN = vClientVersionDA.GetObjByDataRow(objRow);
 return objvClientVersionEN;
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
public static clsvClientVersionEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvClientVersionEN objvClientVersionEN = vClientVersionDA.GetObjByDataRow(objRow);
 return objvClientVersionEN;
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
 /// <param name = "strClientVersionId">所给的关键字</param>
 /// <param name = "lstvClientVersionObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvClientVersionEN GetObjByClientVersionIdFromList(string strClientVersionId, List<clsvClientVersionEN> lstvClientVersionObjLst)
{
foreach (clsvClientVersionEN objvClientVersionEN in lstvClientVersionObjLst)
{
if (objvClientVersionEN.ClientVersionId == strClientVersionId)
{
return objvClientVersionEN;
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
 string strClientVersionId;
 try
 {
 strClientVersionId = new clsvClientVersionDA().GetFirstID(strWhereCond);
 return strClientVersionId;
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
 arrList = vClientVersionDA.GetID(strWhereCond);
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
bool bolIsExist = vClientVersionDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strClientVersionId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strClientVersionId)
{
if (string.IsNullOrEmpty(strClientVersionId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strClientVersionId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = vClientVersionDA.IsExist(strClientVersionId);
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
 bolIsExist = clsvClientVersionDA.IsExistTable();
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
 bolIsExist = vClientVersionDA.IsExistTable(strTabName);
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
 /// <param name = "objvClientVersionENS">源对象</param>
 /// <param name = "objvClientVersionENT">目标对象</param>
 public static void CopyTo(clsvClientVersionEN objvClientVersionENS, clsvClientVersionEN objvClientVersionENT)
{
try
{
objvClientVersionENT.ClientVersionId = objvClientVersionENS.ClientVersionId; //客户端版本Id
objvClientVersionENT.ClientVersionTypeId = objvClientVersionENS.ClientVersionTypeId; //客户端版本类型Id
objvClientVersionENT.ClientVersionTypeName = objvClientVersionENS.ClientVersionTypeName; //客户端版本类型名称
objvClientVersionENT.VersionDescription = objvClientVersionENS.VersionDescription; //版本说明
objvClientVersionENT.VersionNumber = objvClientVersionENS.VersionNumber; //版本号
objvClientVersionENT.VersionState = objvClientVersionENS.VersionState; //版本状态
objvClientVersionENT.VersionUrl = objvClientVersionENS.VersionUrl; //版本文件
objvClientVersionENT.UpdDate = objvClientVersionENS.UpdDate; //修改日期
objvClientVersionENT.UpdUser = objvClientVersionENS.UpdUser; //修改人
objvClientVersionENT.Memo = objvClientVersionENS.Memo; //备注
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
 /// <param name = "objvClientVersionEN">源简化对象</param>
 public static void SetUpdFlag(clsvClientVersionEN objvClientVersionEN)
{
try
{
objvClientVersionEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvClientVersionEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convClientVersion.ClientVersionId, new clsStrCompareIgnoreCase())  ==  true)
{
objvClientVersionEN.ClientVersionId = objvClientVersionEN.ClientVersionId; //客户端版本Id
}
if (arrFldSet.Contains(convClientVersion.ClientVersionTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvClientVersionEN.ClientVersionTypeId = objvClientVersionEN.ClientVersionTypeId; //客户端版本类型Id
}
if (arrFldSet.Contains(convClientVersion.ClientVersionTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvClientVersionEN.ClientVersionTypeName = objvClientVersionEN.ClientVersionTypeName == "[null]" ? null :  objvClientVersionEN.ClientVersionTypeName; //客户端版本类型名称
}
if (arrFldSet.Contains(convClientVersion.VersionDescription, new clsStrCompareIgnoreCase())  ==  true)
{
objvClientVersionEN.VersionDescription = objvClientVersionEN.VersionDescription == "[null]" ? null :  objvClientVersionEN.VersionDescription; //版本说明
}
if (arrFldSet.Contains(convClientVersion.VersionNumber, new clsStrCompareIgnoreCase())  ==  true)
{
objvClientVersionEN.VersionNumber = objvClientVersionEN.VersionNumber; //版本号
}
if (arrFldSet.Contains(convClientVersion.VersionState, new clsStrCompareIgnoreCase())  ==  true)
{
objvClientVersionEN.VersionState = objvClientVersionEN.VersionState; //版本状态
}
if (arrFldSet.Contains(convClientVersion.VersionUrl, new clsStrCompareIgnoreCase())  ==  true)
{
objvClientVersionEN.VersionUrl = objvClientVersionEN.VersionUrl; //版本文件
}
if (arrFldSet.Contains(convClientVersion.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvClientVersionEN.UpdDate = objvClientVersionEN.UpdDate == "[null]" ? null :  objvClientVersionEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convClientVersion.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objvClientVersionEN.UpdUser = objvClientVersionEN.UpdUser == "[null]" ? null :  objvClientVersionEN.UpdUser; //修改人
}
if (arrFldSet.Contains(convClientVersion.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvClientVersionEN.Memo = objvClientVersionEN.Memo == "[null]" ? null :  objvClientVersionEN.Memo; //备注
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
 /// <param name = "objvClientVersionEN">源简化对象</param>
 public static void AccessFldValueNull(clsvClientVersionEN objvClientVersionEN)
{
try
{
if (objvClientVersionEN.ClientVersionTypeName == "[null]") objvClientVersionEN.ClientVersionTypeName = null; //客户端版本类型名称
if (objvClientVersionEN.VersionDescription == "[null]") objvClientVersionEN.VersionDescription = null; //版本说明
if (objvClientVersionEN.UpdDate == "[null]") objvClientVersionEN.UpdDate = null; //修改日期
if (objvClientVersionEN.UpdUser == "[null]") objvClientVersionEN.UpdUser = null; //修改人
if (objvClientVersionEN.Memo == "[null]") objvClientVersionEN.Memo = null; //备注
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
public static void CheckProperty4Condition(clsvClientVersionEN objvClientVersionEN)
{
 vClientVersionDA.CheckProperty4Condition(objvClientVersionEN);
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
if (clsClientVersionBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsClientVersionBL没有刷新缓存机制(clsClientVersionBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsClientVersionTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsClientVersionTypeBL没有刷新缓存机制(clsClientVersionTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by ClientVersionId");
//if (arrvClientVersionObjLstCache == null)
//{
//arrvClientVersionObjLstCache = vClientVersionDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strClientVersionId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvClientVersionEN GetObjByClientVersionIdCache(string strClientVersionId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvClientVersionEN._CurrTabName);
List<clsvClientVersionEN> arrvClientVersionObjLstCache = GetObjLstCache();
IEnumerable <clsvClientVersionEN> arrvClientVersionObjLst_Sel =
arrvClientVersionObjLstCache
.Where(x=> x.ClientVersionId == strClientVersionId 
);
if (arrvClientVersionObjLst_Sel.Count() == 0)
{
   clsvClientVersionEN obj = clsvClientVersionBL.GetObjByClientVersionId(strClientVersionId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvClientVersionObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvClientVersionEN> GetAllvClientVersionObjLstCache()
{
//获取缓存中的对象列表
List<clsvClientVersionEN> arrvClientVersionObjLstCache = GetObjLstCache(); 
return arrvClientVersionObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvClientVersionEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvClientVersionEN._CurrTabName);
List<clsvClientVersionEN> arrvClientVersionObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvClientVersionObjLstCache;
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
string strKey = string.Format("{0}", clsvClientVersionEN._CurrTabName);
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
public static string Func(string strInFldName, string strOutFldName, string strClientVersionId)
{
if (strInFldName != convClientVersion.ClientVersionId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convClientVersion.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convClientVersion.AttributeName));
throw new Exception(strMsg);
}
var objvClientVersion = clsvClientVersionBL.GetObjByClientVersionIdCache(strClientVersionId);
if (objvClientVersion == null) return "";
return objvClientVersion[strOutFldName].ToString();
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
int intRecCount = clsvClientVersionDA.GetRecCount(strTabName);
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
int intRecCount = clsvClientVersionDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvClientVersionDA.GetRecCount();
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
int intRecCount = clsvClientVersionDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvClientVersionCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvClientVersionEN objvClientVersionCond)
{
List<clsvClientVersionEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvClientVersionEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convClientVersion.AttributeName)
{
if (objvClientVersionCond.IsUpdated(strFldName) == false) continue;
if (objvClientVersionCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvClientVersionCond[strFldName].ToString());
}
else
{
if (objvClientVersionCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvClientVersionCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvClientVersionCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvClientVersionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvClientVersionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvClientVersionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvClientVersionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvClientVersionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvClientVersionCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvClientVersionCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvClientVersionCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvClientVersionCond[strFldName]));
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
 List<string> arrList = clsvClientVersionDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vClientVersionDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vClientVersionDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}