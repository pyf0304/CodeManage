
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvAppraiseTypeBL
 表名:vAppraiseType(01120308)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:44:26
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:微格教学评议(MicroTeachSenate)
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
public static class  clsvAppraiseTypeBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strIdAppraiseType">表关键字</param>
 /// <returns>表对象</returns>
public static clsvAppraiseTypeEN GetObj(this K_IdAppraiseType_vAppraiseType myKey)
{
clsvAppraiseTypeEN objvAppraiseTypeEN = clsvAppraiseTypeBL.vAppraiseTypeDA.GetObjByIdAppraiseType(myKey.Value);
return objvAppraiseTypeEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvAppraiseTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvAppraiseTypeEN SetIdAppraiseType(this clsvAppraiseTypeEN objvAppraiseTypeEN, string strIdAppraiseType, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdAppraiseType, 4, convAppraiseType.IdAppraiseType);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdAppraiseType, 4, convAppraiseType.IdAppraiseType);
}
objvAppraiseTypeEN.IdAppraiseType = strIdAppraiseType; //评议类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvAppraiseTypeEN.dicFldComparisonOp.ContainsKey(convAppraiseType.IdAppraiseType) == false)
{
objvAppraiseTypeEN.dicFldComparisonOp.Add(convAppraiseType.IdAppraiseType, strComparisonOp);
}
else
{
objvAppraiseTypeEN.dicFldComparisonOp[convAppraiseType.IdAppraiseType] = strComparisonOp;
}
}
return objvAppraiseTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvAppraiseTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvAppraiseTypeEN SetAppraiseTypeID(this clsvAppraiseTypeEN objvAppraiseTypeEN, string strAppraiseTypeID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strAppraiseTypeID, convAppraiseType.AppraiseTypeID);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAppraiseTypeID, 4, convAppraiseType.AppraiseTypeID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strAppraiseTypeID, 4, convAppraiseType.AppraiseTypeID);
}
objvAppraiseTypeEN.AppraiseTypeID = strAppraiseTypeID; //评议类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvAppraiseTypeEN.dicFldComparisonOp.ContainsKey(convAppraiseType.AppraiseTypeID) == false)
{
objvAppraiseTypeEN.dicFldComparisonOp.Add(convAppraiseType.AppraiseTypeID, strComparisonOp);
}
else
{
objvAppraiseTypeEN.dicFldComparisonOp[convAppraiseType.AppraiseTypeID] = strComparisonOp;
}
}
return objvAppraiseTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvAppraiseTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvAppraiseTypeEN SetAppraiseTypeName(this clsvAppraiseTypeEN objvAppraiseTypeEN, string strAppraiseTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strAppraiseTypeName, convAppraiseType.AppraiseTypeName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAppraiseTypeName, 50, convAppraiseType.AppraiseTypeName);
}
objvAppraiseTypeEN.AppraiseTypeName = strAppraiseTypeName; //评议类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvAppraiseTypeEN.dicFldComparisonOp.ContainsKey(convAppraiseType.AppraiseTypeName) == false)
{
objvAppraiseTypeEN.dicFldComparisonOp.Add(convAppraiseType.AppraiseTypeName, strComparisonOp);
}
else
{
objvAppraiseTypeEN.dicFldComparisonOp[convAppraiseType.AppraiseTypeName] = strComparisonOp;
}
}
return objvAppraiseTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvAppraiseTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvAppraiseTypeEN SetUserTypeId(this clsvAppraiseTypeEN objvAppraiseTypeEN, string strUserTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserTypeId, 2, convAppraiseType.UserTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strUserTypeId, 2, convAppraiseType.UserTypeId);
}
objvAppraiseTypeEN.UserTypeId = strUserTypeId; //用户类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvAppraiseTypeEN.dicFldComparisonOp.ContainsKey(convAppraiseType.UserTypeId) == false)
{
objvAppraiseTypeEN.dicFldComparisonOp.Add(convAppraiseType.UserTypeId, strComparisonOp);
}
else
{
objvAppraiseTypeEN.dicFldComparisonOp[convAppraiseType.UserTypeId] = strComparisonOp;
}
}
return objvAppraiseTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvAppraiseTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvAppraiseTypeEN SetUserTypeName(this clsvAppraiseTypeEN objvAppraiseTypeEN, string strUserTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserTypeName, 20, convAppraiseType.UserTypeName);
}
objvAppraiseTypeEN.UserTypeName = strUserTypeName; //用户类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvAppraiseTypeEN.dicFldComparisonOp.ContainsKey(convAppraiseType.UserTypeName) == false)
{
objvAppraiseTypeEN.dicFldComparisonOp.Add(convAppraiseType.UserTypeName, strComparisonOp);
}
else
{
objvAppraiseTypeEN.dicFldComparisonOp[convAppraiseType.UserTypeName] = strComparisonOp;
}
}
return objvAppraiseTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvAppraiseTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvAppraiseTypeEN SetMemo(this clsvAppraiseTypeEN objvAppraiseTypeEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convAppraiseType.Memo);
}
objvAppraiseTypeEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvAppraiseTypeEN.dicFldComparisonOp.ContainsKey(convAppraiseType.Memo) == false)
{
objvAppraiseTypeEN.dicFldComparisonOp.Add(convAppraiseType.Memo, strComparisonOp);
}
else
{
objvAppraiseTypeEN.dicFldComparisonOp[convAppraiseType.Memo] = strComparisonOp;
}
}
return objvAppraiseTypeEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvAppraiseTypeENS">源对象</param>
 /// <param name = "objvAppraiseTypeENT">目标对象</param>
 public static void CopyTo(this clsvAppraiseTypeEN objvAppraiseTypeENS, clsvAppraiseTypeEN objvAppraiseTypeENT)
{
try
{
objvAppraiseTypeENT.IdAppraiseType = objvAppraiseTypeENS.IdAppraiseType; //评议类型流水号
objvAppraiseTypeENT.AppraiseTypeID = objvAppraiseTypeENS.AppraiseTypeID; //评议类型ID
objvAppraiseTypeENT.AppraiseTypeName = objvAppraiseTypeENS.AppraiseTypeName; //评议类型名称
objvAppraiseTypeENT.UserTypeId = objvAppraiseTypeENS.UserTypeId; //用户类型Id
objvAppraiseTypeENT.UserTypeName = objvAppraiseTypeENS.UserTypeName; //用户类型名称
objvAppraiseTypeENT.Memo = objvAppraiseTypeENS.Memo; //备注
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
 /// <param name = "objvAppraiseTypeENS">源对象</param>
 /// <returns>目标对象=>clsvAppraiseTypeEN:objvAppraiseTypeENT</returns>
 public static clsvAppraiseTypeEN CopyTo(this clsvAppraiseTypeEN objvAppraiseTypeENS)
{
try
{
 clsvAppraiseTypeEN objvAppraiseTypeENT = new clsvAppraiseTypeEN()
{
IdAppraiseType = objvAppraiseTypeENS.IdAppraiseType, //评议类型流水号
AppraiseTypeID = objvAppraiseTypeENS.AppraiseTypeID, //评议类型ID
AppraiseTypeName = objvAppraiseTypeENS.AppraiseTypeName, //评议类型名称
UserTypeId = objvAppraiseTypeENS.UserTypeId, //用户类型Id
UserTypeName = objvAppraiseTypeENS.UserTypeName, //用户类型名称
Memo = objvAppraiseTypeENS.Memo, //备注
};
 return objvAppraiseTypeENT;
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
public static void CheckProperty4Condition(this clsvAppraiseTypeEN objvAppraiseTypeEN)
{
 clsvAppraiseTypeBL.vAppraiseTypeDA.CheckProperty4Condition(objvAppraiseTypeEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvAppraiseTypeEN objvAppraiseTypeCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvAppraiseTypeCond.IsUpdated(convAppraiseType.IdAppraiseType) == true)
{
string strComparisonOpIdAppraiseType = objvAppraiseTypeCond.dicFldComparisonOp[convAppraiseType.IdAppraiseType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convAppraiseType.IdAppraiseType, objvAppraiseTypeCond.IdAppraiseType, strComparisonOpIdAppraiseType);
}
if (objvAppraiseTypeCond.IsUpdated(convAppraiseType.AppraiseTypeID) == true)
{
string strComparisonOpAppraiseTypeID = objvAppraiseTypeCond.dicFldComparisonOp[convAppraiseType.AppraiseTypeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convAppraiseType.AppraiseTypeID, objvAppraiseTypeCond.AppraiseTypeID, strComparisonOpAppraiseTypeID);
}
if (objvAppraiseTypeCond.IsUpdated(convAppraiseType.AppraiseTypeName) == true)
{
string strComparisonOpAppraiseTypeName = objvAppraiseTypeCond.dicFldComparisonOp[convAppraiseType.AppraiseTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convAppraiseType.AppraiseTypeName, objvAppraiseTypeCond.AppraiseTypeName, strComparisonOpAppraiseTypeName);
}
if (objvAppraiseTypeCond.IsUpdated(convAppraiseType.UserTypeId) == true)
{
string strComparisonOpUserTypeId = objvAppraiseTypeCond.dicFldComparisonOp[convAppraiseType.UserTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convAppraiseType.UserTypeId, objvAppraiseTypeCond.UserTypeId, strComparisonOpUserTypeId);
}
if (objvAppraiseTypeCond.IsUpdated(convAppraiseType.UserTypeName) == true)
{
string strComparisonOpUserTypeName = objvAppraiseTypeCond.dicFldComparisonOp[convAppraiseType.UserTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convAppraiseType.UserTypeName, objvAppraiseTypeCond.UserTypeName, strComparisonOpUserTypeName);
}
if (objvAppraiseTypeCond.IsUpdated(convAppraiseType.Memo) == true)
{
string strComparisonOpMemo = objvAppraiseTypeCond.dicFldComparisonOp[convAppraiseType.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convAppraiseType.Memo, objvAppraiseTypeCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vAppraiseType
{
public virtual bool UpdRelaTabDate(string strIdAppraiseType, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v评议类型(vAppraiseType)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvAppraiseTypeBL
{
public static RelatedActions_vAppraiseType relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvAppraiseTypeDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvAppraiseTypeDA vAppraiseTypeDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvAppraiseTypeDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvAppraiseTypeBL()
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
if (string.IsNullOrEmpty(clsvAppraiseTypeEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvAppraiseTypeEN._ConnectString);
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
public static DataTable GetDataTable_vAppraiseType(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vAppraiseTypeDA.GetDataTable_vAppraiseType(strWhereCond);
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
objDT = vAppraiseTypeDA.GetDataTable(strWhereCond);
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
objDT = vAppraiseTypeDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vAppraiseTypeDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vAppraiseTypeDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vAppraiseTypeDA.GetDataTable_Top(objTopPara);
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
objDT = vAppraiseTypeDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vAppraiseTypeDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vAppraiseTypeDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrIdAppraiseTypeLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvAppraiseTypeEN> GetObjLstByIdAppraiseTypeLst(List<string> arrIdAppraiseTypeLst)
{
List<clsvAppraiseTypeEN> arrObjLst = new List<clsvAppraiseTypeEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrIdAppraiseTypeLst, true);
 string strWhereCond = string.Format("IdAppraiseType in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvAppraiseTypeEN objvAppraiseTypeEN = new clsvAppraiseTypeEN();
try
{
objvAppraiseTypeEN.IdAppraiseType = objRow[convAppraiseType.IdAppraiseType].ToString().Trim(); //评议类型流水号
objvAppraiseTypeEN.AppraiseTypeID = objRow[convAppraiseType.AppraiseTypeID].ToString().Trim(); //评议类型ID
objvAppraiseTypeEN.AppraiseTypeName = objRow[convAppraiseType.AppraiseTypeName].ToString().Trim(); //评议类型名称
objvAppraiseTypeEN.UserTypeId = objRow[convAppraiseType.UserTypeId] == DBNull.Value ? null : objRow[convAppraiseType.UserTypeId].ToString().Trim(); //用户类型Id
objvAppraiseTypeEN.UserTypeName = objRow[convAppraiseType.UserTypeName] == DBNull.Value ? null : objRow[convAppraiseType.UserTypeName].ToString().Trim(); //用户类型名称
objvAppraiseTypeEN.Memo = objRow[convAppraiseType.Memo] == DBNull.Value ? null : objRow[convAppraiseType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvAppraiseTypeEN.IdAppraiseType, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvAppraiseTypeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrIdAppraiseTypeLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvAppraiseTypeEN> GetObjLstByIdAppraiseTypeLstCache(List<string> arrIdAppraiseTypeLst)
{
string strKey = string.Format("{0}", clsvAppraiseTypeEN._CurrTabName);
List<clsvAppraiseTypeEN> arrvAppraiseTypeObjLstCache = GetObjLstCache();
IEnumerable <clsvAppraiseTypeEN> arrvAppraiseTypeObjLst_Sel =
arrvAppraiseTypeObjLstCache
.Where(x => arrIdAppraiseTypeLst.Contains(x.IdAppraiseType));
return arrvAppraiseTypeObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvAppraiseTypeEN> GetObjLst(string strWhereCond)
{
List<clsvAppraiseTypeEN> arrObjLst = new List<clsvAppraiseTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvAppraiseTypeEN objvAppraiseTypeEN = new clsvAppraiseTypeEN();
try
{
objvAppraiseTypeEN.IdAppraiseType = objRow[convAppraiseType.IdAppraiseType].ToString().Trim(); //评议类型流水号
objvAppraiseTypeEN.AppraiseTypeID = objRow[convAppraiseType.AppraiseTypeID].ToString().Trim(); //评议类型ID
objvAppraiseTypeEN.AppraiseTypeName = objRow[convAppraiseType.AppraiseTypeName].ToString().Trim(); //评议类型名称
objvAppraiseTypeEN.UserTypeId = objRow[convAppraiseType.UserTypeId] == DBNull.Value ? null : objRow[convAppraiseType.UserTypeId].ToString().Trim(); //用户类型Id
objvAppraiseTypeEN.UserTypeName = objRow[convAppraiseType.UserTypeName] == DBNull.Value ? null : objRow[convAppraiseType.UserTypeName].ToString().Trim(); //用户类型名称
objvAppraiseTypeEN.Memo = objRow[convAppraiseType.Memo] == DBNull.Value ? null : objRow[convAppraiseType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvAppraiseTypeEN.IdAppraiseType, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvAppraiseTypeEN);
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
public static List<clsvAppraiseTypeEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvAppraiseTypeEN> arrObjLst = new List<clsvAppraiseTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvAppraiseTypeEN objvAppraiseTypeEN = new clsvAppraiseTypeEN();
try
{
objvAppraiseTypeEN.IdAppraiseType = objRow[convAppraiseType.IdAppraiseType].ToString().Trim(); //评议类型流水号
objvAppraiseTypeEN.AppraiseTypeID = objRow[convAppraiseType.AppraiseTypeID].ToString().Trim(); //评议类型ID
objvAppraiseTypeEN.AppraiseTypeName = objRow[convAppraiseType.AppraiseTypeName].ToString().Trim(); //评议类型名称
objvAppraiseTypeEN.UserTypeId = objRow[convAppraiseType.UserTypeId] == DBNull.Value ? null : objRow[convAppraiseType.UserTypeId].ToString().Trim(); //用户类型Id
objvAppraiseTypeEN.UserTypeName = objRow[convAppraiseType.UserTypeName] == DBNull.Value ? null : objRow[convAppraiseType.UserTypeName].ToString().Trim(); //用户类型名称
objvAppraiseTypeEN.Memo = objRow[convAppraiseType.Memo] == DBNull.Value ? null : objRow[convAppraiseType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvAppraiseTypeEN.IdAppraiseType, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvAppraiseTypeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvAppraiseTypeCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvAppraiseTypeEN> GetSubObjLstCache(clsvAppraiseTypeEN objvAppraiseTypeCond)
{
List<clsvAppraiseTypeEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvAppraiseTypeEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convAppraiseType.AttributeName)
{
if (objvAppraiseTypeCond.IsUpdated(strFldName) == false) continue;
if (objvAppraiseTypeCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvAppraiseTypeCond[strFldName].ToString());
}
else
{
if (objvAppraiseTypeCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvAppraiseTypeCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvAppraiseTypeCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvAppraiseTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvAppraiseTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvAppraiseTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvAppraiseTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvAppraiseTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvAppraiseTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvAppraiseTypeCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvAppraiseTypeCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvAppraiseTypeCond[strFldName]));
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
public static List<clsvAppraiseTypeEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvAppraiseTypeEN> arrObjLst = new List<clsvAppraiseTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvAppraiseTypeEN objvAppraiseTypeEN = new clsvAppraiseTypeEN();
try
{
objvAppraiseTypeEN.IdAppraiseType = objRow[convAppraiseType.IdAppraiseType].ToString().Trim(); //评议类型流水号
objvAppraiseTypeEN.AppraiseTypeID = objRow[convAppraiseType.AppraiseTypeID].ToString().Trim(); //评议类型ID
objvAppraiseTypeEN.AppraiseTypeName = objRow[convAppraiseType.AppraiseTypeName].ToString().Trim(); //评议类型名称
objvAppraiseTypeEN.UserTypeId = objRow[convAppraiseType.UserTypeId] == DBNull.Value ? null : objRow[convAppraiseType.UserTypeId].ToString().Trim(); //用户类型Id
objvAppraiseTypeEN.UserTypeName = objRow[convAppraiseType.UserTypeName] == DBNull.Value ? null : objRow[convAppraiseType.UserTypeName].ToString().Trim(); //用户类型名称
objvAppraiseTypeEN.Memo = objRow[convAppraiseType.Memo] == DBNull.Value ? null : objRow[convAppraiseType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvAppraiseTypeEN.IdAppraiseType, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvAppraiseTypeEN);
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
public static List<clsvAppraiseTypeEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvAppraiseTypeEN> arrObjLst = new List<clsvAppraiseTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvAppraiseTypeEN objvAppraiseTypeEN = new clsvAppraiseTypeEN();
try
{
objvAppraiseTypeEN.IdAppraiseType = objRow[convAppraiseType.IdAppraiseType].ToString().Trim(); //评议类型流水号
objvAppraiseTypeEN.AppraiseTypeID = objRow[convAppraiseType.AppraiseTypeID].ToString().Trim(); //评议类型ID
objvAppraiseTypeEN.AppraiseTypeName = objRow[convAppraiseType.AppraiseTypeName].ToString().Trim(); //评议类型名称
objvAppraiseTypeEN.UserTypeId = objRow[convAppraiseType.UserTypeId] == DBNull.Value ? null : objRow[convAppraiseType.UserTypeId].ToString().Trim(); //用户类型Id
objvAppraiseTypeEN.UserTypeName = objRow[convAppraiseType.UserTypeName] == DBNull.Value ? null : objRow[convAppraiseType.UserTypeName].ToString().Trim(); //用户类型名称
objvAppraiseTypeEN.Memo = objRow[convAppraiseType.Memo] == DBNull.Value ? null : objRow[convAppraiseType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvAppraiseTypeEN.IdAppraiseType, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvAppraiseTypeEN);
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
List<clsvAppraiseTypeEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvAppraiseTypeEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvAppraiseTypeEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvAppraiseTypeEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvAppraiseTypeEN> arrObjLst = new List<clsvAppraiseTypeEN>(); 
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
	clsvAppraiseTypeEN objvAppraiseTypeEN = new clsvAppraiseTypeEN();
try
{
objvAppraiseTypeEN.IdAppraiseType = objRow[convAppraiseType.IdAppraiseType].ToString().Trim(); //评议类型流水号
objvAppraiseTypeEN.AppraiseTypeID = objRow[convAppraiseType.AppraiseTypeID].ToString().Trim(); //评议类型ID
objvAppraiseTypeEN.AppraiseTypeName = objRow[convAppraiseType.AppraiseTypeName].ToString().Trim(); //评议类型名称
objvAppraiseTypeEN.UserTypeId = objRow[convAppraiseType.UserTypeId] == DBNull.Value ? null : objRow[convAppraiseType.UserTypeId].ToString().Trim(); //用户类型Id
objvAppraiseTypeEN.UserTypeName = objRow[convAppraiseType.UserTypeName] == DBNull.Value ? null : objRow[convAppraiseType.UserTypeName].ToString().Trim(); //用户类型名称
objvAppraiseTypeEN.Memo = objRow[convAppraiseType.Memo] == DBNull.Value ? null : objRow[convAppraiseType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvAppraiseTypeEN.IdAppraiseType, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvAppraiseTypeEN);
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
public static List<clsvAppraiseTypeEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvAppraiseTypeEN> arrObjLst = new List<clsvAppraiseTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvAppraiseTypeEN objvAppraiseTypeEN = new clsvAppraiseTypeEN();
try
{
objvAppraiseTypeEN.IdAppraiseType = objRow[convAppraiseType.IdAppraiseType].ToString().Trim(); //评议类型流水号
objvAppraiseTypeEN.AppraiseTypeID = objRow[convAppraiseType.AppraiseTypeID].ToString().Trim(); //评议类型ID
objvAppraiseTypeEN.AppraiseTypeName = objRow[convAppraiseType.AppraiseTypeName].ToString().Trim(); //评议类型名称
objvAppraiseTypeEN.UserTypeId = objRow[convAppraiseType.UserTypeId] == DBNull.Value ? null : objRow[convAppraiseType.UserTypeId].ToString().Trim(); //用户类型Id
objvAppraiseTypeEN.UserTypeName = objRow[convAppraiseType.UserTypeName] == DBNull.Value ? null : objRow[convAppraiseType.UserTypeName].ToString().Trim(); //用户类型名称
objvAppraiseTypeEN.Memo = objRow[convAppraiseType.Memo] == DBNull.Value ? null : objRow[convAppraiseType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvAppraiseTypeEN.IdAppraiseType, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvAppraiseTypeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvAppraiseTypeEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvAppraiseTypeEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvAppraiseTypeEN> arrObjLst = new List<clsvAppraiseTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvAppraiseTypeEN objvAppraiseTypeEN = new clsvAppraiseTypeEN();
try
{
objvAppraiseTypeEN.IdAppraiseType = objRow[convAppraiseType.IdAppraiseType].ToString().Trim(); //评议类型流水号
objvAppraiseTypeEN.AppraiseTypeID = objRow[convAppraiseType.AppraiseTypeID].ToString().Trim(); //评议类型ID
objvAppraiseTypeEN.AppraiseTypeName = objRow[convAppraiseType.AppraiseTypeName].ToString().Trim(); //评议类型名称
objvAppraiseTypeEN.UserTypeId = objRow[convAppraiseType.UserTypeId] == DBNull.Value ? null : objRow[convAppraiseType.UserTypeId].ToString().Trim(); //用户类型Id
objvAppraiseTypeEN.UserTypeName = objRow[convAppraiseType.UserTypeName] == DBNull.Value ? null : objRow[convAppraiseType.UserTypeName].ToString().Trim(); //用户类型名称
objvAppraiseTypeEN.Memo = objRow[convAppraiseType.Memo] == DBNull.Value ? null : objRow[convAppraiseType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvAppraiseTypeEN.IdAppraiseType, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvAppraiseTypeEN);
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
public static List<clsvAppraiseTypeEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvAppraiseTypeEN> arrObjLst = new List<clsvAppraiseTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvAppraiseTypeEN objvAppraiseTypeEN = new clsvAppraiseTypeEN();
try
{
objvAppraiseTypeEN.IdAppraiseType = objRow[convAppraiseType.IdAppraiseType].ToString().Trim(); //评议类型流水号
objvAppraiseTypeEN.AppraiseTypeID = objRow[convAppraiseType.AppraiseTypeID].ToString().Trim(); //评议类型ID
objvAppraiseTypeEN.AppraiseTypeName = objRow[convAppraiseType.AppraiseTypeName].ToString().Trim(); //评议类型名称
objvAppraiseTypeEN.UserTypeId = objRow[convAppraiseType.UserTypeId] == DBNull.Value ? null : objRow[convAppraiseType.UserTypeId].ToString().Trim(); //用户类型Id
objvAppraiseTypeEN.UserTypeName = objRow[convAppraiseType.UserTypeName] == DBNull.Value ? null : objRow[convAppraiseType.UserTypeName].ToString().Trim(); //用户类型名称
objvAppraiseTypeEN.Memo = objRow[convAppraiseType.Memo] == DBNull.Value ? null : objRow[convAppraiseType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvAppraiseTypeEN.IdAppraiseType, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvAppraiseTypeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvAppraiseTypeEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvAppraiseTypeEN> arrObjLst = new List<clsvAppraiseTypeEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvAppraiseTypeEN objvAppraiseTypeEN = new clsvAppraiseTypeEN();
try
{
objvAppraiseTypeEN.IdAppraiseType = objRow[convAppraiseType.IdAppraiseType].ToString().Trim(); //评议类型流水号
objvAppraiseTypeEN.AppraiseTypeID = objRow[convAppraiseType.AppraiseTypeID].ToString().Trim(); //评议类型ID
objvAppraiseTypeEN.AppraiseTypeName = objRow[convAppraiseType.AppraiseTypeName].ToString().Trim(); //评议类型名称
objvAppraiseTypeEN.UserTypeId = objRow[convAppraiseType.UserTypeId] == DBNull.Value ? null : objRow[convAppraiseType.UserTypeId].ToString().Trim(); //用户类型Id
objvAppraiseTypeEN.UserTypeName = objRow[convAppraiseType.UserTypeName] == DBNull.Value ? null : objRow[convAppraiseType.UserTypeName].ToString().Trim(); //用户类型名称
objvAppraiseTypeEN.Memo = objRow[convAppraiseType.Memo] == DBNull.Value ? null : objRow[convAppraiseType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvAppraiseTypeEN.IdAppraiseType, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvAppraiseTypeEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvAppraiseTypeEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvAppraiseType(ref clsvAppraiseTypeEN objvAppraiseTypeEN)
{
bool bolResult = vAppraiseTypeDA.GetvAppraiseType(ref objvAppraiseTypeEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strIdAppraiseType">表关键字</param>
 /// <returns>表对象</returns>
public static clsvAppraiseTypeEN GetObjByIdAppraiseType(string strIdAppraiseType)
{
if (strIdAppraiseType.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strIdAppraiseType]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strIdAppraiseType) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strIdAppraiseType]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsvAppraiseTypeEN objvAppraiseTypeEN = vAppraiseTypeDA.GetObjByIdAppraiseType(strIdAppraiseType);
return objvAppraiseTypeEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvAppraiseTypeEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvAppraiseTypeEN objvAppraiseTypeEN = vAppraiseTypeDA.GetFirstObj(strWhereCond);
 return objvAppraiseTypeEN;
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
public static clsvAppraiseTypeEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvAppraiseTypeEN objvAppraiseTypeEN = vAppraiseTypeDA.GetObjByDataRow(objRow);
 return objvAppraiseTypeEN;
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
public static clsvAppraiseTypeEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvAppraiseTypeEN objvAppraiseTypeEN = vAppraiseTypeDA.GetObjByDataRow(objRow);
 return objvAppraiseTypeEN;
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
 /// <param name = "strIdAppraiseType">所给的关键字</param>
 /// <param name = "lstvAppraiseTypeObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvAppraiseTypeEN GetObjByIdAppraiseTypeFromList(string strIdAppraiseType, List<clsvAppraiseTypeEN> lstvAppraiseTypeObjLst)
{
foreach (clsvAppraiseTypeEN objvAppraiseTypeEN in lstvAppraiseTypeObjLst)
{
if (objvAppraiseTypeEN.IdAppraiseType == strIdAppraiseType)
{
return objvAppraiseTypeEN;
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
 string strIdAppraiseType;
 try
 {
 strIdAppraiseType = new clsvAppraiseTypeDA().GetFirstID(strWhereCond);
 return strIdAppraiseType;
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
 arrList = vAppraiseTypeDA.GetID(strWhereCond);
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
bool bolIsExist = vAppraiseTypeDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strIdAppraiseType">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strIdAppraiseType)
{
if (string.IsNullOrEmpty(strIdAppraiseType) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strIdAppraiseType]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = vAppraiseTypeDA.IsExist(strIdAppraiseType);
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
 bolIsExist = clsvAppraiseTypeDA.IsExistTable();
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
 bolIsExist = vAppraiseTypeDA.IsExistTable(strTabName);
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
 /// <param name = "objvAppraiseTypeENS">源对象</param>
 /// <param name = "objvAppraiseTypeENT">目标对象</param>
 public static void CopyTo(clsvAppraiseTypeEN objvAppraiseTypeENS, clsvAppraiseTypeEN objvAppraiseTypeENT)
{
try
{
objvAppraiseTypeENT.IdAppraiseType = objvAppraiseTypeENS.IdAppraiseType; //评议类型流水号
objvAppraiseTypeENT.AppraiseTypeID = objvAppraiseTypeENS.AppraiseTypeID; //评议类型ID
objvAppraiseTypeENT.AppraiseTypeName = objvAppraiseTypeENS.AppraiseTypeName; //评议类型名称
objvAppraiseTypeENT.UserTypeId = objvAppraiseTypeENS.UserTypeId; //用户类型Id
objvAppraiseTypeENT.UserTypeName = objvAppraiseTypeENS.UserTypeName; //用户类型名称
objvAppraiseTypeENT.Memo = objvAppraiseTypeENS.Memo; //备注
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
 /// <param name = "objvAppraiseTypeEN">源简化对象</param>
 public static void SetUpdFlag(clsvAppraiseTypeEN objvAppraiseTypeEN)
{
try
{
objvAppraiseTypeEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvAppraiseTypeEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convAppraiseType.IdAppraiseType, new clsStrCompareIgnoreCase())  ==  true)
{
objvAppraiseTypeEN.IdAppraiseType = objvAppraiseTypeEN.IdAppraiseType; //评议类型流水号
}
if (arrFldSet.Contains(convAppraiseType.AppraiseTypeID, new clsStrCompareIgnoreCase())  ==  true)
{
objvAppraiseTypeEN.AppraiseTypeID = objvAppraiseTypeEN.AppraiseTypeID; //评议类型ID
}
if (arrFldSet.Contains(convAppraiseType.AppraiseTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvAppraiseTypeEN.AppraiseTypeName = objvAppraiseTypeEN.AppraiseTypeName; //评议类型名称
}
if (arrFldSet.Contains(convAppraiseType.UserTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvAppraiseTypeEN.UserTypeId = objvAppraiseTypeEN.UserTypeId == "[null]" ? null :  objvAppraiseTypeEN.UserTypeId; //用户类型Id
}
if (arrFldSet.Contains(convAppraiseType.UserTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvAppraiseTypeEN.UserTypeName = objvAppraiseTypeEN.UserTypeName == "[null]" ? null :  objvAppraiseTypeEN.UserTypeName; //用户类型名称
}
if (arrFldSet.Contains(convAppraiseType.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvAppraiseTypeEN.Memo = objvAppraiseTypeEN.Memo == "[null]" ? null :  objvAppraiseTypeEN.Memo; //备注
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
 /// <param name = "objvAppraiseTypeEN">源简化对象</param>
 public static void AccessFldValueNull(clsvAppraiseTypeEN objvAppraiseTypeEN)
{
try
{
if (objvAppraiseTypeEN.UserTypeId == "[null]") objvAppraiseTypeEN.UserTypeId = null; //用户类型Id
if (objvAppraiseTypeEN.UserTypeName == "[null]") objvAppraiseTypeEN.UserTypeName = null; //用户类型名称
if (objvAppraiseTypeEN.Memo == "[null]") objvAppraiseTypeEN.Memo = null; //备注
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
public static void CheckProperty4Condition(clsvAppraiseTypeEN objvAppraiseTypeEN)
{
 vAppraiseTypeDA.CheckProperty4Condition(objvAppraiseTypeEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Win的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_ComboBoxBindFunction)
 /// </summary>
 /// <param name = "objComboBox">需要绑定当前表的下拉框</param>

public static void BindCbo_IdAppraiseType(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", convAppraiseType.IdAppraiseType); 
List<clsvAppraiseTypeEN> arrObjLst = clsvAppraiseTypeBL.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsvAppraiseTypeEN objvAppraiseTypeEN = new clsvAppraiseTypeEN()
{
IdAppraiseType = "0",
AppraiseTypeName = "选[v评议类型]..."
};
arrObjLst.Insert(0, objvAppraiseTypeEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = convAppraiseType.IdAppraiseType;
objComboBox.DisplayMember = convAppraiseType.AppraiseTypeName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_DdlBindFunction)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>

public static void BindDdl_IdAppraiseType(System.Web.UI.WebControls.DropDownList objDDL )
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[v评议类型]...","0");
string strCondition = string.Format("1 =1 Order By {0}", convAppraiseType.IdAppraiseType); 
IEnumerable<clsvAppraiseTypeEN> arrObjLst = clsvAppraiseTypeBL.GetObjLst(strCondition);
objDDL.DataValueField = convAppraiseType.IdAppraiseType;
objDDL.DataTextField = convAppraiseType.AppraiseTypeName;
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
public static void BindDdl_IdAppraiseTypeCache(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[v评议类型]...","0");
List<clsvAppraiseTypeEN> arrvAppraiseTypeObjLst = GetAllvAppraiseTypeObjLstCache(); 
objDDL.DataValueField = convAppraiseType.IdAppraiseType;
objDDL.DataTextField = convAppraiseType.AppraiseTypeName;
objDDL.DataSource = arrvAppraiseTypeObjLst;
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
if (clsAppraiseTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsAppraiseTypeBL没有刷新缓存机制(clsAppraiseTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsUserTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsUserTypeBL没有刷新缓存机制(clsUserTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by IdAppraiseType");
//if (arrvAppraiseTypeObjLstCache == null)
//{
//arrvAppraiseTypeObjLstCache = vAppraiseTypeDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strIdAppraiseType">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvAppraiseTypeEN GetObjByIdAppraiseTypeCache(string strIdAppraiseType)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvAppraiseTypeEN._CurrTabName);
List<clsvAppraiseTypeEN> arrvAppraiseTypeObjLstCache = GetObjLstCache();
IEnumerable <clsvAppraiseTypeEN> arrvAppraiseTypeObjLst_Sel =
arrvAppraiseTypeObjLstCache
.Where(x=> x.IdAppraiseType == strIdAppraiseType 
);
if (arrvAppraiseTypeObjLst_Sel.Count() == 0)
{
   clsvAppraiseTypeEN obj = clsvAppraiseTypeBL.GetObjByIdAppraiseType(strIdAppraiseType);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvAppraiseTypeObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strIdAppraiseType">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetAppraiseTypeNameByIdAppraiseTypeCache(string strIdAppraiseType)
{
if (string.IsNullOrEmpty(strIdAppraiseType) == true) return "";
//获取缓存中的对象列表
clsvAppraiseTypeEN objvAppraiseType = GetObjByIdAppraiseTypeCache(strIdAppraiseType);
if (objvAppraiseType == null) return "";
return objvAppraiseType.AppraiseTypeName;
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strIdAppraiseType">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByIdAppraiseTypeCache(string strIdAppraiseType)
{
if (string.IsNullOrEmpty(strIdAppraiseType) == true) return "";
//获取缓存中的对象列表
clsvAppraiseTypeEN objvAppraiseType = GetObjByIdAppraiseTypeCache(strIdAppraiseType);
if (objvAppraiseType == null) return "";
return objvAppraiseType.AppraiseTypeName;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvAppraiseTypeEN> GetAllvAppraiseTypeObjLstCache()
{
//获取缓存中的对象列表
List<clsvAppraiseTypeEN> arrvAppraiseTypeObjLstCache = GetObjLstCache(); 
return arrvAppraiseTypeObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvAppraiseTypeEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvAppraiseTypeEN._CurrTabName);
List<clsvAppraiseTypeEN> arrvAppraiseTypeObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvAppraiseTypeObjLstCache;
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
string strKey = string.Format("{0}", clsvAppraiseTypeEN._CurrTabName);
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
public static string Func(string strInFldName, string strOutFldName, string strIdAppraiseType)
{
if (strInFldName != convAppraiseType.IdAppraiseType)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convAppraiseType.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convAppraiseType.AttributeName));
throw new Exception(strMsg);
}
var objvAppraiseType = clsvAppraiseTypeBL.GetObjByIdAppraiseTypeCache(strIdAppraiseType);
if (objvAppraiseType == null) return "";
return objvAppraiseType[strOutFldName].ToString();
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
int intRecCount = clsvAppraiseTypeDA.GetRecCount(strTabName);
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
int intRecCount = clsvAppraiseTypeDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvAppraiseTypeDA.GetRecCount();
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
int intRecCount = clsvAppraiseTypeDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvAppraiseTypeCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvAppraiseTypeEN objvAppraiseTypeCond)
{
List<clsvAppraiseTypeEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvAppraiseTypeEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convAppraiseType.AttributeName)
{
if (objvAppraiseTypeCond.IsUpdated(strFldName) == false) continue;
if (objvAppraiseTypeCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvAppraiseTypeCond[strFldName].ToString());
}
else
{
if (objvAppraiseTypeCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvAppraiseTypeCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvAppraiseTypeCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvAppraiseTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvAppraiseTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvAppraiseTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvAppraiseTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvAppraiseTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvAppraiseTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvAppraiseTypeCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvAppraiseTypeCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvAppraiseTypeCond[strFldName]));
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
 List<string> arrList = clsvAppraiseTypeDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vAppraiseTypeDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vAppraiseTypeDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}