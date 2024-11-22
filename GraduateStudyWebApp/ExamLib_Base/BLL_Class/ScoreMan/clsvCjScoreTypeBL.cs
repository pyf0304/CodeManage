
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvCjScoreTypeBL
 表名:vCjScoreType(01120346)
 * 版本:2024.02.19.1(服务器:WIN-SRV103-116)
 日期:2024/02/27 16:24:13
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:成绩管理(ScoreMan)
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
public static class  clsvCjScoreTypeBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strIdScoreType">表关键字</param>
 /// <returns>表对象</returns>
public static clsvCjScoreTypeEN GetObj(this K_IdScoreType_vCjScoreType myKey)
{
clsvCjScoreTypeEN objvCjScoreTypeEN = clsvCjScoreTypeBL.vCjScoreTypeDA.GetObjByIdScoreType(myKey.Value);
return objvCjScoreTypeEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCjScoreTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCjScoreTypeEN SetIdScoreType(this clsvCjScoreTypeEN objvCjScoreTypeEN, string strIdScoreType, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdScoreType, 4, convCjScoreType.IdScoreType);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdScoreType, 4, convCjScoreType.IdScoreType);
}
objvCjScoreTypeEN.IdScoreType = strIdScoreType; //成绩类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCjScoreTypeEN.dicFldComparisonOp.ContainsKey(convCjScoreType.IdScoreType) == false)
{
objvCjScoreTypeEN.dicFldComparisonOp.Add(convCjScoreType.IdScoreType, strComparisonOp);
}
else
{
objvCjScoreTypeEN.dicFldComparisonOp[convCjScoreType.IdScoreType] = strComparisonOp;
}
}
return objvCjScoreTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCjScoreTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCjScoreTypeEN SetScoreTypeId(this clsvCjScoreTypeEN objvCjScoreTypeEN, string strScoreTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strScoreTypeId, convCjScoreType.ScoreTypeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strScoreTypeId, 4, convCjScoreType.ScoreTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strScoreTypeId, 4, convCjScoreType.ScoreTypeId);
}
objvCjScoreTypeEN.ScoreTypeId = strScoreTypeId; //分数类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCjScoreTypeEN.dicFldComparisonOp.ContainsKey(convCjScoreType.ScoreTypeId) == false)
{
objvCjScoreTypeEN.dicFldComparisonOp.Add(convCjScoreType.ScoreTypeId, strComparisonOp);
}
else
{
objvCjScoreTypeEN.dicFldComparisonOp[convCjScoreType.ScoreTypeId] = strComparisonOp;
}
}
return objvCjScoreTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCjScoreTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCjScoreTypeEN SetScoreTypeName(this clsvCjScoreTypeEN objvCjScoreTypeEN, string strScoreTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strScoreTypeName, convCjScoreType.ScoreTypeName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strScoreTypeName, 10, convCjScoreType.ScoreTypeName);
}
objvCjScoreTypeEN.ScoreTypeName = strScoreTypeName; //分数类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCjScoreTypeEN.dicFldComparisonOp.ContainsKey(convCjScoreType.ScoreTypeName) == false)
{
objvCjScoreTypeEN.dicFldComparisonOp.Add(convCjScoreType.ScoreTypeName, strComparisonOp);
}
else
{
objvCjScoreTypeEN.dicFldComparisonOp[convCjScoreType.ScoreTypeName] = strComparisonOp;
}
}
return objvCjScoreTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCjScoreTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCjScoreTypeEN SetIdMainScoreType(this clsvCjScoreTypeEN objvCjScoreTypeEN, string strIdMainScoreType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdMainScoreType, convCjScoreType.IdMainScoreType);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdMainScoreType, 2, convCjScoreType.IdMainScoreType);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdMainScoreType, 2, convCjScoreType.IdMainScoreType);
}
objvCjScoreTypeEN.IdMainScoreType = strIdMainScoreType; //成绩主类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCjScoreTypeEN.dicFldComparisonOp.ContainsKey(convCjScoreType.IdMainScoreType) == false)
{
objvCjScoreTypeEN.dicFldComparisonOp.Add(convCjScoreType.IdMainScoreType, strComparisonOp);
}
else
{
objvCjScoreTypeEN.dicFldComparisonOp[convCjScoreType.IdMainScoreType] = strComparisonOp;
}
}
return objvCjScoreTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCjScoreTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCjScoreTypeEN SetModifyDate(this clsvCjScoreTypeEN objvCjScoreTypeEN, string strModifyDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strModifyDate, 20, convCjScoreType.ModifyDate);
}
objvCjScoreTypeEN.ModifyDate = strModifyDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCjScoreTypeEN.dicFldComparisonOp.ContainsKey(convCjScoreType.ModifyDate) == false)
{
objvCjScoreTypeEN.dicFldComparisonOp.Add(convCjScoreType.ModifyDate, strComparisonOp);
}
else
{
objvCjScoreTypeEN.dicFldComparisonOp[convCjScoreType.ModifyDate] = strComparisonOp;
}
}
return objvCjScoreTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCjScoreTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCjScoreTypeEN SetModifyUserId(this clsvCjScoreTypeEN objvCjScoreTypeEN, string strModifyUserId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strModifyUserId, 18, convCjScoreType.ModifyUserId);
}
objvCjScoreTypeEN.ModifyUserId = strModifyUserId; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCjScoreTypeEN.dicFldComparisonOp.ContainsKey(convCjScoreType.ModifyUserId) == false)
{
objvCjScoreTypeEN.dicFldComparisonOp.Add(convCjScoreType.ModifyUserId, strComparisonOp);
}
else
{
objvCjScoreTypeEN.dicFldComparisonOp[convCjScoreType.ModifyUserId] = strComparisonOp;
}
}
return objvCjScoreTypeEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvCjScoreTypeENS">源对象</param>
 /// <param name = "objvCjScoreTypeENT">目标对象</param>
 public static void CopyTo(this clsvCjScoreTypeEN objvCjScoreTypeENS, clsvCjScoreTypeEN objvCjScoreTypeENT)
{
try
{
objvCjScoreTypeENT.IdScoreType = objvCjScoreTypeENS.IdScoreType; //成绩类型流水号
objvCjScoreTypeENT.ScoreTypeId = objvCjScoreTypeENS.ScoreTypeId; //分数类型Id
objvCjScoreTypeENT.ScoreTypeName = objvCjScoreTypeENS.ScoreTypeName; //分数类型名称
objvCjScoreTypeENT.IdMainScoreType = objvCjScoreTypeENS.IdMainScoreType; //成绩主类型流水号
objvCjScoreTypeENT.ModifyDate = objvCjScoreTypeENS.ModifyDate; //修改日期
objvCjScoreTypeENT.ModifyUserId = objvCjScoreTypeENS.ModifyUserId; //修改人
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
 /// <param name = "objvCjScoreTypeENS">源对象</param>
 /// <returns>目标对象=>clsvCjScoreTypeEN:objvCjScoreTypeENT</returns>
 public static clsvCjScoreTypeEN CopyTo(this clsvCjScoreTypeEN objvCjScoreTypeENS)
{
try
{
 clsvCjScoreTypeEN objvCjScoreTypeENT = new clsvCjScoreTypeEN()
{
IdScoreType = objvCjScoreTypeENS.IdScoreType, //成绩类型流水号
ScoreTypeId = objvCjScoreTypeENS.ScoreTypeId, //分数类型Id
ScoreTypeName = objvCjScoreTypeENS.ScoreTypeName, //分数类型名称
IdMainScoreType = objvCjScoreTypeENS.IdMainScoreType, //成绩主类型流水号
ModifyDate = objvCjScoreTypeENS.ModifyDate, //修改日期
ModifyUserId = objvCjScoreTypeENS.ModifyUserId, //修改人
};
 return objvCjScoreTypeENT;
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
public static void CheckProperty4Condition(this clsvCjScoreTypeEN objvCjScoreTypeEN)
{
 clsvCjScoreTypeBL.vCjScoreTypeDA.CheckProperty4Condition(objvCjScoreTypeEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvCjScoreTypeEN objvCjScoreTypeCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvCjScoreTypeCond.IsUpdated(convCjScoreType.IdScoreType) == true)
{
string strComparisonOpIdScoreType = objvCjScoreTypeCond.dicFldComparisonOp[convCjScoreType.IdScoreType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCjScoreType.IdScoreType, objvCjScoreTypeCond.IdScoreType, strComparisonOpIdScoreType);
}
if (objvCjScoreTypeCond.IsUpdated(convCjScoreType.ScoreTypeId) == true)
{
string strComparisonOpScoreTypeId = objvCjScoreTypeCond.dicFldComparisonOp[convCjScoreType.ScoreTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCjScoreType.ScoreTypeId, objvCjScoreTypeCond.ScoreTypeId, strComparisonOpScoreTypeId);
}
if (objvCjScoreTypeCond.IsUpdated(convCjScoreType.ScoreTypeName) == true)
{
string strComparisonOpScoreTypeName = objvCjScoreTypeCond.dicFldComparisonOp[convCjScoreType.ScoreTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCjScoreType.ScoreTypeName, objvCjScoreTypeCond.ScoreTypeName, strComparisonOpScoreTypeName);
}
if (objvCjScoreTypeCond.IsUpdated(convCjScoreType.IdMainScoreType) == true)
{
string strComparisonOpIdMainScoreType = objvCjScoreTypeCond.dicFldComparisonOp[convCjScoreType.IdMainScoreType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCjScoreType.IdMainScoreType, objvCjScoreTypeCond.IdMainScoreType, strComparisonOpIdMainScoreType);
}
if (objvCjScoreTypeCond.IsUpdated(convCjScoreType.ModifyDate) == true)
{
string strComparisonOpModifyDate = objvCjScoreTypeCond.dicFldComparisonOp[convCjScoreType.ModifyDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCjScoreType.ModifyDate, objvCjScoreTypeCond.ModifyDate, strComparisonOpModifyDate);
}
if (objvCjScoreTypeCond.IsUpdated(convCjScoreType.ModifyUserId) == true)
{
string strComparisonOpModifyUserId = objvCjScoreTypeCond.dicFldComparisonOp[convCjScoreType.ModifyUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCjScoreType.ModifyUserId, objvCjScoreTypeCond.ModifyUserId, strComparisonOpModifyUserId);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vCjScoreType
{
public virtual bool UpdRelaTabDate(string strIdScoreType, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v成绩类型(vCjScoreType)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvCjScoreTypeBL
{
public static RelatedActions_vCjScoreType relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvCjScoreTypeDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvCjScoreTypeDA vCjScoreTypeDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvCjScoreTypeDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvCjScoreTypeBL()
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
if (string.IsNullOrEmpty(clsvCjScoreTypeEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvCjScoreTypeEN._ConnectString);
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
public static DataTable GetDataTable_vCjScoreType(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vCjScoreTypeDA.GetDataTable_vCjScoreType(strWhereCond);
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
objDT = vCjScoreTypeDA.GetDataTable(strWhereCond);
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
objDT = vCjScoreTypeDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vCjScoreTypeDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vCjScoreTypeDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vCjScoreTypeDA.GetDataTable_Top(objTopPara);
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
objDT = vCjScoreTypeDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vCjScoreTypeDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vCjScoreTypeDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrIdScoreTypeLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvCjScoreTypeEN> GetObjLstByIdScoreTypeLst(List<string> arrIdScoreTypeLst)
{
List<clsvCjScoreTypeEN> arrObjLst = new List<clsvCjScoreTypeEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrIdScoreTypeLst, true);
 string strWhereCond = string.Format("IdScoreType in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCjScoreTypeEN objvCjScoreTypeEN = new clsvCjScoreTypeEN();
try
{
objvCjScoreTypeEN.IdScoreType = objRow[convCjScoreType.IdScoreType].ToString().Trim(); //成绩类型流水号
objvCjScoreTypeEN.ScoreTypeId = objRow[convCjScoreType.ScoreTypeId].ToString().Trim(); //分数类型Id
objvCjScoreTypeEN.ScoreTypeName = objRow[convCjScoreType.ScoreTypeName].ToString().Trim(); //分数类型名称
objvCjScoreTypeEN.IdMainScoreType = objRow[convCjScoreType.IdMainScoreType].ToString().Trim(); //成绩主类型流水号
objvCjScoreTypeEN.ModifyDate = objRow[convCjScoreType.ModifyDate] == DBNull.Value ? null : objRow[convCjScoreType.ModifyDate].ToString().Trim(); //修改日期
objvCjScoreTypeEN.ModifyUserId = objRow[convCjScoreType.ModifyUserId] == DBNull.Value ? null : objRow[convCjScoreType.ModifyUserId].ToString().Trim(); //修改人
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCjScoreTypeEN.IdScoreType, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCjScoreTypeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrIdScoreTypeLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvCjScoreTypeEN> GetObjLstByIdScoreTypeLstCache(List<string> arrIdScoreTypeLst)
{
string strKey = string.Format("{0}", clsvCjScoreTypeEN._CurrTabName);
List<clsvCjScoreTypeEN> arrvCjScoreTypeObjLstCache = GetObjLstCache();
IEnumerable <clsvCjScoreTypeEN> arrvCjScoreTypeObjLst_Sel =
arrvCjScoreTypeObjLstCache
.Where(x => arrIdScoreTypeLst.Contains(x.IdScoreType));
return arrvCjScoreTypeObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvCjScoreTypeEN> GetObjLst(string strWhereCond)
{
List<clsvCjScoreTypeEN> arrObjLst = new List<clsvCjScoreTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCjScoreTypeEN objvCjScoreTypeEN = new clsvCjScoreTypeEN();
try
{
objvCjScoreTypeEN.IdScoreType = objRow[convCjScoreType.IdScoreType].ToString().Trim(); //成绩类型流水号
objvCjScoreTypeEN.ScoreTypeId = objRow[convCjScoreType.ScoreTypeId].ToString().Trim(); //分数类型Id
objvCjScoreTypeEN.ScoreTypeName = objRow[convCjScoreType.ScoreTypeName].ToString().Trim(); //分数类型名称
objvCjScoreTypeEN.IdMainScoreType = objRow[convCjScoreType.IdMainScoreType].ToString().Trim(); //成绩主类型流水号
objvCjScoreTypeEN.ModifyDate = objRow[convCjScoreType.ModifyDate] == DBNull.Value ? null : objRow[convCjScoreType.ModifyDate].ToString().Trim(); //修改日期
objvCjScoreTypeEN.ModifyUserId = objRow[convCjScoreType.ModifyUserId] == DBNull.Value ? null : objRow[convCjScoreType.ModifyUserId].ToString().Trim(); //修改人
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCjScoreTypeEN.IdScoreType, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCjScoreTypeEN);
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
public static List<clsvCjScoreTypeEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvCjScoreTypeEN> arrObjLst = new List<clsvCjScoreTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCjScoreTypeEN objvCjScoreTypeEN = new clsvCjScoreTypeEN();
try
{
objvCjScoreTypeEN.IdScoreType = objRow[convCjScoreType.IdScoreType].ToString().Trim(); //成绩类型流水号
objvCjScoreTypeEN.ScoreTypeId = objRow[convCjScoreType.ScoreTypeId].ToString().Trim(); //分数类型Id
objvCjScoreTypeEN.ScoreTypeName = objRow[convCjScoreType.ScoreTypeName].ToString().Trim(); //分数类型名称
objvCjScoreTypeEN.IdMainScoreType = objRow[convCjScoreType.IdMainScoreType].ToString().Trim(); //成绩主类型流水号
objvCjScoreTypeEN.ModifyDate = objRow[convCjScoreType.ModifyDate] == DBNull.Value ? null : objRow[convCjScoreType.ModifyDate].ToString().Trim(); //修改日期
objvCjScoreTypeEN.ModifyUserId = objRow[convCjScoreType.ModifyUserId] == DBNull.Value ? null : objRow[convCjScoreType.ModifyUserId].ToString().Trim(); //修改人
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCjScoreTypeEN.IdScoreType, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCjScoreTypeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvCjScoreTypeCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvCjScoreTypeEN> GetSubObjLstCache(clsvCjScoreTypeEN objvCjScoreTypeCond)
{
List<clsvCjScoreTypeEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvCjScoreTypeEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convCjScoreType.AttributeName)
{
if (objvCjScoreTypeCond.IsUpdated(strFldName) == false) continue;
if (objvCjScoreTypeCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvCjScoreTypeCond[strFldName].ToString());
}
else
{
if (objvCjScoreTypeCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvCjScoreTypeCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvCjScoreTypeCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvCjScoreTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvCjScoreTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvCjScoreTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvCjScoreTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvCjScoreTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvCjScoreTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvCjScoreTypeCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvCjScoreTypeCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvCjScoreTypeCond[strFldName]));
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
public static List<clsvCjScoreTypeEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvCjScoreTypeEN> arrObjLst = new List<clsvCjScoreTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCjScoreTypeEN objvCjScoreTypeEN = new clsvCjScoreTypeEN();
try
{
objvCjScoreTypeEN.IdScoreType = objRow[convCjScoreType.IdScoreType].ToString().Trim(); //成绩类型流水号
objvCjScoreTypeEN.ScoreTypeId = objRow[convCjScoreType.ScoreTypeId].ToString().Trim(); //分数类型Id
objvCjScoreTypeEN.ScoreTypeName = objRow[convCjScoreType.ScoreTypeName].ToString().Trim(); //分数类型名称
objvCjScoreTypeEN.IdMainScoreType = objRow[convCjScoreType.IdMainScoreType].ToString().Trim(); //成绩主类型流水号
objvCjScoreTypeEN.ModifyDate = objRow[convCjScoreType.ModifyDate] == DBNull.Value ? null : objRow[convCjScoreType.ModifyDate].ToString().Trim(); //修改日期
objvCjScoreTypeEN.ModifyUserId = objRow[convCjScoreType.ModifyUserId] == DBNull.Value ? null : objRow[convCjScoreType.ModifyUserId].ToString().Trim(); //修改人
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCjScoreTypeEN.IdScoreType, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCjScoreTypeEN);
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
public static List<clsvCjScoreTypeEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvCjScoreTypeEN> arrObjLst = new List<clsvCjScoreTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCjScoreTypeEN objvCjScoreTypeEN = new clsvCjScoreTypeEN();
try
{
objvCjScoreTypeEN.IdScoreType = objRow[convCjScoreType.IdScoreType].ToString().Trim(); //成绩类型流水号
objvCjScoreTypeEN.ScoreTypeId = objRow[convCjScoreType.ScoreTypeId].ToString().Trim(); //分数类型Id
objvCjScoreTypeEN.ScoreTypeName = objRow[convCjScoreType.ScoreTypeName].ToString().Trim(); //分数类型名称
objvCjScoreTypeEN.IdMainScoreType = objRow[convCjScoreType.IdMainScoreType].ToString().Trim(); //成绩主类型流水号
objvCjScoreTypeEN.ModifyDate = objRow[convCjScoreType.ModifyDate] == DBNull.Value ? null : objRow[convCjScoreType.ModifyDate].ToString().Trim(); //修改日期
objvCjScoreTypeEN.ModifyUserId = objRow[convCjScoreType.ModifyUserId] == DBNull.Value ? null : objRow[convCjScoreType.ModifyUserId].ToString().Trim(); //修改人
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCjScoreTypeEN.IdScoreType, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCjScoreTypeEN);
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
List<clsvCjScoreTypeEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvCjScoreTypeEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvCjScoreTypeEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvCjScoreTypeEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvCjScoreTypeEN> arrObjLst = new List<clsvCjScoreTypeEN>(); 
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
	clsvCjScoreTypeEN objvCjScoreTypeEN = new clsvCjScoreTypeEN();
try
{
objvCjScoreTypeEN.IdScoreType = objRow[convCjScoreType.IdScoreType].ToString().Trim(); //成绩类型流水号
objvCjScoreTypeEN.ScoreTypeId = objRow[convCjScoreType.ScoreTypeId].ToString().Trim(); //分数类型Id
objvCjScoreTypeEN.ScoreTypeName = objRow[convCjScoreType.ScoreTypeName].ToString().Trim(); //分数类型名称
objvCjScoreTypeEN.IdMainScoreType = objRow[convCjScoreType.IdMainScoreType].ToString().Trim(); //成绩主类型流水号
objvCjScoreTypeEN.ModifyDate = objRow[convCjScoreType.ModifyDate] == DBNull.Value ? null : objRow[convCjScoreType.ModifyDate].ToString().Trim(); //修改日期
objvCjScoreTypeEN.ModifyUserId = objRow[convCjScoreType.ModifyUserId] == DBNull.Value ? null : objRow[convCjScoreType.ModifyUserId].ToString().Trim(); //修改人
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCjScoreTypeEN.IdScoreType, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCjScoreTypeEN);
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
public static List<clsvCjScoreTypeEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvCjScoreTypeEN> arrObjLst = new List<clsvCjScoreTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCjScoreTypeEN objvCjScoreTypeEN = new clsvCjScoreTypeEN();
try
{
objvCjScoreTypeEN.IdScoreType = objRow[convCjScoreType.IdScoreType].ToString().Trim(); //成绩类型流水号
objvCjScoreTypeEN.ScoreTypeId = objRow[convCjScoreType.ScoreTypeId].ToString().Trim(); //分数类型Id
objvCjScoreTypeEN.ScoreTypeName = objRow[convCjScoreType.ScoreTypeName].ToString().Trim(); //分数类型名称
objvCjScoreTypeEN.IdMainScoreType = objRow[convCjScoreType.IdMainScoreType].ToString().Trim(); //成绩主类型流水号
objvCjScoreTypeEN.ModifyDate = objRow[convCjScoreType.ModifyDate] == DBNull.Value ? null : objRow[convCjScoreType.ModifyDate].ToString().Trim(); //修改日期
objvCjScoreTypeEN.ModifyUserId = objRow[convCjScoreType.ModifyUserId] == DBNull.Value ? null : objRow[convCjScoreType.ModifyUserId].ToString().Trim(); //修改人
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCjScoreTypeEN.IdScoreType, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCjScoreTypeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvCjScoreTypeEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvCjScoreTypeEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvCjScoreTypeEN> arrObjLst = new List<clsvCjScoreTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCjScoreTypeEN objvCjScoreTypeEN = new clsvCjScoreTypeEN();
try
{
objvCjScoreTypeEN.IdScoreType = objRow[convCjScoreType.IdScoreType].ToString().Trim(); //成绩类型流水号
objvCjScoreTypeEN.ScoreTypeId = objRow[convCjScoreType.ScoreTypeId].ToString().Trim(); //分数类型Id
objvCjScoreTypeEN.ScoreTypeName = objRow[convCjScoreType.ScoreTypeName].ToString().Trim(); //分数类型名称
objvCjScoreTypeEN.IdMainScoreType = objRow[convCjScoreType.IdMainScoreType].ToString().Trim(); //成绩主类型流水号
objvCjScoreTypeEN.ModifyDate = objRow[convCjScoreType.ModifyDate] == DBNull.Value ? null : objRow[convCjScoreType.ModifyDate].ToString().Trim(); //修改日期
objvCjScoreTypeEN.ModifyUserId = objRow[convCjScoreType.ModifyUserId] == DBNull.Value ? null : objRow[convCjScoreType.ModifyUserId].ToString().Trim(); //修改人
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCjScoreTypeEN.IdScoreType, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCjScoreTypeEN);
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
public static List<clsvCjScoreTypeEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvCjScoreTypeEN> arrObjLst = new List<clsvCjScoreTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCjScoreTypeEN objvCjScoreTypeEN = new clsvCjScoreTypeEN();
try
{
objvCjScoreTypeEN.IdScoreType = objRow[convCjScoreType.IdScoreType].ToString().Trim(); //成绩类型流水号
objvCjScoreTypeEN.ScoreTypeId = objRow[convCjScoreType.ScoreTypeId].ToString().Trim(); //分数类型Id
objvCjScoreTypeEN.ScoreTypeName = objRow[convCjScoreType.ScoreTypeName].ToString().Trim(); //分数类型名称
objvCjScoreTypeEN.IdMainScoreType = objRow[convCjScoreType.IdMainScoreType].ToString().Trim(); //成绩主类型流水号
objvCjScoreTypeEN.ModifyDate = objRow[convCjScoreType.ModifyDate] == DBNull.Value ? null : objRow[convCjScoreType.ModifyDate].ToString().Trim(); //修改日期
objvCjScoreTypeEN.ModifyUserId = objRow[convCjScoreType.ModifyUserId] == DBNull.Value ? null : objRow[convCjScoreType.ModifyUserId].ToString().Trim(); //修改人
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCjScoreTypeEN.IdScoreType, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCjScoreTypeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvCjScoreTypeEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvCjScoreTypeEN> arrObjLst = new List<clsvCjScoreTypeEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCjScoreTypeEN objvCjScoreTypeEN = new clsvCjScoreTypeEN();
try
{
objvCjScoreTypeEN.IdScoreType = objRow[convCjScoreType.IdScoreType].ToString().Trim(); //成绩类型流水号
objvCjScoreTypeEN.ScoreTypeId = objRow[convCjScoreType.ScoreTypeId].ToString().Trim(); //分数类型Id
objvCjScoreTypeEN.ScoreTypeName = objRow[convCjScoreType.ScoreTypeName].ToString().Trim(); //分数类型名称
objvCjScoreTypeEN.IdMainScoreType = objRow[convCjScoreType.IdMainScoreType].ToString().Trim(); //成绩主类型流水号
objvCjScoreTypeEN.ModifyDate = objRow[convCjScoreType.ModifyDate] == DBNull.Value ? null : objRow[convCjScoreType.ModifyDate].ToString().Trim(); //修改日期
objvCjScoreTypeEN.ModifyUserId = objRow[convCjScoreType.ModifyUserId] == DBNull.Value ? null : objRow[convCjScoreType.ModifyUserId].ToString().Trim(); //修改人
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCjScoreTypeEN.IdScoreType, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCjScoreTypeEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvCjScoreTypeEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvCjScoreType(ref clsvCjScoreTypeEN objvCjScoreTypeEN)
{
bool bolResult = vCjScoreTypeDA.GetvCjScoreType(ref objvCjScoreTypeEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strIdScoreType">表关键字</param>
 /// <returns>表对象</returns>
public static clsvCjScoreTypeEN GetObjByIdScoreType(string strIdScoreType)
{
if (strIdScoreType.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strIdScoreType]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strIdScoreType) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strIdScoreType]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsvCjScoreTypeEN objvCjScoreTypeEN = vCjScoreTypeDA.GetObjByIdScoreType(strIdScoreType);
return objvCjScoreTypeEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvCjScoreTypeEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvCjScoreTypeEN objvCjScoreTypeEN = vCjScoreTypeDA.GetFirstObj(strWhereCond);
 return objvCjScoreTypeEN;
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
public static clsvCjScoreTypeEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvCjScoreTypeEN objvCjScoreTypeEN = vCjScoreTypeDA.GetObjByDataRow(objRow);
 return objvCjScoreTypeEN;
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
public static clsvCjScoreTypeEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvCjScoreTypeEN objvCjScoreTypeEN = vCjScoreTypeDA.GetObjByDataRow(objRow);
 return objvCjScoreTypeEN;
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
 /// <param name = "strIdScoreType">所给的关键字</param>
 /// <param name = "lstvCjScoreTypeObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvCjScoreTypeEN GetObjByIdScoreTypeFromList(string strIdScoreType, List<clsvCjScoreTypeEN> lstvCjScoreTypeObjLst)
{
foreach (clsvCjScoreTypeEN objvCjScoreTypeEN in lstvCjScoreTypeObjLst)
{
if (objvCjScoreTypeEN.IdScoreType == strIdScoreType)
{
return objvCjScoreTypeEN;
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
 string strIdScoreType;
 try
 {
 strIdScoreType = new clsvCjScoreTypeDA().GetFirstID(strWhereCond);
 return strIdScoreType;
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
 arrList = vCjScoreTypeDA.GetID(strWhereCond);
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
bool bolIsExist = vCjScoreTypeDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strIdScoreType">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strIdScoreType)
{
if (string.IsNullOrEmpty(strIdScoreType) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strIdScoreType]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = vCjScoreTypeDA.IsExist(strIdScoreType);
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
 bolIsExist = clsvCjScoreTypeDA.IsExistTable();
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
 bolIsExist = vCjScoreTypeDA.IsExistTable(strTabName);
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
 /// <param name = "objvCjScoreTypeENS">源对象</param>
 /// <param name = "objvCjScoreTypeENT">目标对象</param>
 public static void CopyTo(clsvCjScoreTypeEN objvCjScoreTypeENS, clsvCjScoreTypeEN objvCjScoreTypeENT)
{
try
{
objvCjScoreTypeENT.IdScoreType = objvCjScoreTypeENS.IdScoreType; //成绩类型流水号
objvCjScoreTypeENT.ScoreTypeId = objvCjScoreTypeENS.ScoreTypeId; //分数类型Id
objvCjScoreTypeENT.ScoreTypeName = objvCjScoreTypeENS.ScoreTypeName; //分数类型名称
objvCjScoreTypeENT.IdMainScoreType = objvCjScoreTypeENS.IdMainScoreType; //成绩主类型流水号
objvCjScoreTypeENT.ModifyDate = objvCjScoreTypeENS.ModifyDate; //修改日期
objvCjScoreTypeENT.ModifyUserId = objvCjScoreTypeENS.ModifyUserId; //修改人
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
 /// <param name = "objvCjScoreTypeEN">源简化对象</param>
 public static void SetUpdFlag(clsvCjScoreTypeEN objvCjScoreTypeEN)
{
try
{
objvCjScoreTypeEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvCjScoreTypeEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convCjScoreType.IdScoreType, new clsStrCompareIgnoreCase())  ==  true)
{
objvCjScoreTypeEN.IdScoreType = objvCjScoreTypeEN.IdScoreType; //成绩类型流水号
}
if (arrFldSet.Contains(convCjScoreType.ScoreTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvCjScoreTypeEN.ScoreTypeId = objvCjScoreTypeEN.ScoreTypeId; //分数类型Id
}
if (arrFldSet.Contains(convCjScoreType.ScoreTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCjScoreTypeEN.ScoreTypeName = objvCjScoreTypeEN.ScoreTypeName; //分数类型名称
}
if (arrFldSet.Contains(convCjScoreType.IdMainScoreType, new clsStrCompareIgnoreCase())  ==  true)
{
objvCjScoreTypeEN.IdMainScoreType = objvCjScoreTypeEN.IdMainScoreType; //成绩主类型流水号
}
if (arrFldSet.Contains(convCjScoreType.ModifyDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvCjScoreTypeEN.ModifyDate = objvCjScoreTypeEN.ModifyDate == "[null]" ? null :  objvCjScoreTypeEN.ModifyDate; //修改日期
}
if (arrFldSet.Contains(convCjScoreType.ModifyUserId, new clsStrCompareIgnoreCase())  ==  true)
{
objvCjScoreTypeEN.ModifyUserId = objvCjScoreTypeEN.ModifyUserId == "[null]" ? null :  objvCjScoreTypeEN.ModifyUserId; //修改人
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
 /// <param name = "objvCjScoreTypeEN">源简化对象</param>
 public static void AccessFldValueNull(clsvCjScoreTypeEN objvCjScoreTypeEN)
{
try
{
if (objvCjScoreTypeEN.ModifyDate == "[null]") objvCjScoreTypeEN.ModifyDate = null; //修改日期
if (objvCjScoreTypeEN.ModifyUserId == "[null]") objvCjScoreTypeEN.ModifyUserId = null; //修改人
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
public static void CheckProperty4Condition(clsvCjScoreTypeEN objvCjScoreTypeEN)
{
 vCjScoreTypeDA.CheckProperty4Condition(objvCjScoreTypeEN);
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
if (clsCjScoreTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsCjScoreTypeBL没有刷新缓存机制(clsCjScoreTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by IdScoreType");
//if (arrvCjScoreTypeObjLstCache == null)
//{
//arrvCjScoreTypeObjLstCache = vCjScoreTypeDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strIdScoreType">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvCjScoreTypeEN GetObjByIdScoreTypeCache(string strIdScoreType)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvCjScoreTypeEN._CurrTabName);
List<clsvCjScoreTypeEN> arrvCjScoreTypeObjLstCache = GetObjLstCache();
IEnumerable <clsvCjScoreTypeEN> arrvCjScoreTypeObjLst_Sel =
arrvCjScoreTypeObjLstCache
.Where(x=> x.IdScoreType == strIdScoreType 
);
if (arrvCjScoreTypeObjLst_Sel.Count() == 0)
{
   clsvCjScoreTypeEN obj = clsvCjScoreTypeBL.GetObjByIdScoreType(strIdScoreType);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvCjScoreTypeObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvCjScoreTypeEN> GetAllvCjScoreTypeObjLstCache()
{
//获取缓存中的对象列表
List<clsvCjScoreTypeEN> arrvCjScoreTypeObjLstCache = GetObjLstCache(); 
return arrvCjScoreTypeObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvCjScoreTypeEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvCjScoreTypeEN._CurrTabName);
List<clsvCjScoreTypeEN> arrvCjScoreTypeObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvCjScoreTypeObjLstCache;
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
string strKey = string.Format("{0}", clsvCjScoreTypeEN._CurrTabName);
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
public static string Func(string strInFldName, string strOutFldName, string strIdScoreType)
{
if (strInFldName != convCjScoreType.IdScoreType)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convCjScoreType.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convCjScoreType.AttributeName));
throw new Exception(strMsg);
}
var objvCjScoreType = clsvCjScoreTypeBL.GetObjByIdScoreTypeCache(strIdScoreType);
if (objvCjScoreType == null) return "";
return objvCjScoreType[strOutFldName].ToString();
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
int intRecCount = clsvCjScoreTypeDA.GetRecCount(strTabName);
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
int intRecCount = clsvCjScoreTypeDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvCjScoreTypeDA.GetRecCount();
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
int intRecCount = clsvCjScoreTypeDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvCjScoreTypeCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvCjScoreTypeEN objvCjScoreTypeCond)
{
List<clsvCjScoreTypeEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvCjScoreTypeEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convCjScoreType.AttributeName)
{
if (objvCjScoreTypeCond.IsUpdated(strFldName) == false) continue;
if (objvCjScoreTypeCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvCjScoreTypeCond[strFldName].ToString());
}
else
{
if (objvCjScoreTypeCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvCjScoreTypeCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvCjScoreTypeCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvCjScoreTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvCjScoreTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvCjScoreTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvCjScoreTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvCjScoreTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvCjScoreTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvCjScoreTypeCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvCjScoreTypeCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvCjScoreTypeCond[strFldName]));
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
 List<string> arrList = clsvCjScoreTypeDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vCjScoreTypeDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vCjScoreTypeDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}