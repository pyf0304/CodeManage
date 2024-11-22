
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvMicroteachCase_Resource_RelGroupByCaseIdBL
 表名:vMicroteachCase_Resource_RelGroupByCaseId(01120427)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:47:41
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
public static class  clsvMicroteachCase_Resource_RelGroupByCaseIdBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strIdMicroteachCase">表关键字</param>
 /// <returns>表对象</returns>
public static clsvMicroteachCase_Resource_RelGroupByCaseIdEN GetObj(this K_IdMicroteachCase_vMicroteachCase_Resource_RelGroupByCaseId myKey)
{
clsvMicroteachCase_Resource_RelGroupByCaseIdEN objvMicroteachCase_Resource_RelGroupByCaseIdEN = clsvMicroteachCase_Resource_RelGroupByCaseIdBL.vMicroteachCase_Resource_RelGroupByCaseIdDA.GetObjByIdMicroteachCase(myKey.Value);
return objvMicroteachCase_Resource_RelGroupByCaseIdEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_RelGroupByCaseIdEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_RelGroupByCaseIdEN SetIdMicroteachCase(this clsvMicroteachCase_Resource_RelGroupByCaseIdEN objvMicroteachCase_Resource_RelGroupByCaseIdEN, string strIdMicroteachCase, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdMicroteachCase, 8, convMicroteachCase_Resource_RelGroupByCaseId.IdMicroteachCase);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdMicroteachCase, 8, convMicroteachCase_Resource_RelGroupByCaseId.IdMicroteachCase);
}
objvMicroteachCase_Resource_RelGroupByCaseIdEN.IdMicroteachCase = strIdMicroteachCase; //微格教学案例流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_RelGroupByCaseIdEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_RelGroupByCaseId.IdMicroteachCase) == false)
{
objvMicroteachCase_Resource_RelGroupByCaseIdEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_RelGroupByCaseId.IdMicroteachCase, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_RelGroupByCaseIdEN.dicFldComparisonOp[convMicroteachCase_Resource_RelGroupByCaseId.IdMicroteachCase] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_RelGroupByCaseIdEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_RelGroupByCaseIdEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_RelGroupByCaseIdEN SetFuncModuleId(this clsvMicroteachCase_Resource_RelGroupByCaseIdEN objvMicroteachCase_Resource_RelGroupByCaseIdEN, string strFuncModuleId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncModuleId, convMicroteachCase_Resource_RelGroupByCaseId.FuncModuleId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncModuleId, 4, convMicroteachCase_Resource_RelGroupByCaseId.FuncModuleId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFuncModuleId, 4, convMicroteachCase_Resource_RelGroupByCaseId.FuncModuleId);
}
objvMicroteachCase_Resource_RelGroupByCaseIdEN.FuncModuleId = strFuncModuleId; //功能模块Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_RelGroupByCaseIdEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_RelGroupByCaseId.FuncModuleId) == false)
{
objvMicroteachCase_Resource_RelGroupByCaseIdEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_RelGroupByCaseId.FuncModuleId, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_RelGroupByCaseIdEN.dicFldComparisonOp[convMicroteachCase_Resource_RelGroupByCaseId.FuncModuleId] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_RelGroupByCaseIdEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_RelGroupByCaseIdEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCase_Resource_RelGroupByCaseIdEN SetResourceNum(this clsvMicroteachCase_Resource_RelGroupByCaseIdEN objvMicroteachCase_Resource_RelGroupByCaseIdEN, int? intResourceNum, string strComparisonOp="")
	{
objvMicroteachCase_Resource_RelGroupByCaseIdEN.ResourceNum = intResourceNum; //资源数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCase_Resource_RelGroupByCaseIdEN.dicFldComparisonOp.ContainsKey(convMicroteachCase_Resource_RelGroupByCaseId.ResourceNum) == false)
{
objvMicroteachCase_Resource_RelGroupByCaseIdEN.dicFldComparisonOp.Add(convMicroteachCase_Resource_RelGroupByCaseId.ResourceNum, strComparisonOp);
}
else
{
objvMicroteachCase_Resource_RelGroupByCaseIdEN.dicFldComparisonOp[convMicroteachCase_Resource_RelGroupByCaseId.ResourceNum] = strComparisonOp;
}
}
return objvMicroteachCase_Resource_RelGroupByCaseIdEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_RelGroupByCaseIdENS">源对象</param>
 /// <param name = "objvMicroteachCase_Resource_RelGroupByCaseIdENT">目标对象</param>
 public static void CopyTo(this clsvMicroteachCase_Resource_RelGroupByCaseIdEN objvMicroteachCase_Resource_RelGroupByCaseIdENS, clsvMicroteachCase_Resource_RelGroupByCaseIdEN objvMicroteachCase_Resource_RelGroupByCaseIdENT)
{
try
{
objvMicroteachCase_Resource_RelGroupByCaseIdENT.IdMicroteachCase = objvMicroteachCase_Resource_RelGroupByCaseIdENS.IdMicroteachCase; //微格教学案例流水号
objvMicroteachCase_Resource_RelGroupByCaseIdENT.FuncModuleId = objvMicroteachCase_Resource_RelGroupByCaseIdENS.FuncModuleId; //功能模块Id
objvMicroteachCase_Resource_RelGroupByCaseIdENT.ResourceNum = objvMicroteachCase_Resource_RelGroupByCaseIdENS.ResourceNum; //资源数
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
 /// <param name = "objvMicroteachCase_Resource_RelGroupByCaseIdENS">源对象</param>
 /// <returns>目标对象=>clsvMicroteachCase_Resource_RelGroupByCaseIdEN:objvMicroteachCase_Resource_RelGroupByCaseIdENT</returns>
 public static clsvMicroteachCase_Resource_RelGroupByCaseIdEN CopyTo(this clsvMicroteachCase_Resource_RelGroupByCaseIdEN objvMicroteachCase_Resource_RelGroupByCaseIdENS)
{
try
{
 clsvMicroteachCase_Resource_RelGroupByCaseIdEN objvMicroteachCase_Resource_RelGroupByCaseIdENT = new clsvMicroteachCase_Resource_RelGroupByCaseIdEN()
{
IdMicroteachCase = objvMicroteachCase_Resource_RelGroupByCaseIdENS.IdMicroteachCase, //微格教学案例流水号
FuncModuleId = objvMicroteachCase_Resource_RelGroupByCaseIdENS.FuncModuleId, //功能模块Id
ResourceNum = objvMicroteachCase_Resource_RelGroupByCaseIdENS.ResourceNum, //资源数
};
 return objvMicroteachCase_Resource_RelGroupByCaseIdENT;
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
public static void CheckProperty4Condition(this clsvMicroteachCase_Resource_RelGroupByCaseIdEN objvMicroteachCase_Resource_RelGroupByCaseIdEN)
{
 clsvMicroteachCase_Resource_RelGroupByCaseIdBL.vMicroteachCase_Resource_RelGroupByCaseIdDA.CheckProperty4Condition(objvMicroteachCase_Resource_RelGroupByCaseIdEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvMicroteachCase_Resource_RelGroupByCaseIdEN objvMicroteachCase_Resource_RelGroupByCaseIdCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvMicroteachCase_Resource_RelGroupByCaseIdCond.IsUpdated(convMicroteachCase_Resource_RelGroupByCaseId.IdMicroteachCase) == true)
{
string strComparisonOpIdMicroteachCase = objvMicroteachCase_Resource_RelGroupByCaseIdCond.dicFldComparisonOp[convMicroteachCase_Resource_RelGroupByCaseId.IdMicroteachCase];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_RelGroupByCaseId.IdMicroteachCase, objvMicroteachCase_Resource_RelGroupByCaseIdCond.IdMicroteachCase, strComparisonOpIdMicroteachCase);
}
if (objvMicroteachCase_Resource_RelGroupByCaseIdCond.IsUpdated(convMicroteachCase_Resource_RelGroupByCaseId.FuncModuleId) == true)
{
string strComparisonOpFuncModuleId = objvMicroteachCase_Resource_RelGroupByCaseIdCond.dicFldComparisonOp[convMicroteachCase_Resource_RelGroupByCaseId.FuncModuleId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCase_Resource_RelGroupByCaseId.FuncModuleId, objvMicroteachCase_Resource_RelGroupByCaseIdCond.FuncModuleId, strComparisonOpFuncModuleId);
}
if (objvMicroteachCase_Resource_RelGroupByCaseIdCond.IsUpdated(convMicroteachCase_Resource_RelGroupByCaseId.ResourceNum) == true)
{
string strComparisonOpResourceNum = objvMicroteachCase_Resource_RelGroupByCaseIdCond.dicFldComparisonOp[convMicroteachCase_Resource_RelGroupByCaseId.ResourceNum];
strWhereCond += string.Format(" And {0} {2} {1}", convMicroteachCase_Resource_RelGroupByCaseId.ResourceNum, objvMicroteachCase_Resource_RelGroupByCaseIdCond.ResourceNum, strComparisonOpResourceNum);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vMicroteachCase_Resource_RelGroupByCaseId
{
public virtual bool UpdRelaTabDate(string strIdMicroteachCase, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v案例资源关系_GroupByCaseId(vMicroteachCase_Resource_RelGroupByCaseId)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvMicroteachCase_Resource_RelGroupByCaseIdBL
{
public static RelatedActions_vMicroteachCase_Resource_RelGroupByCaseId relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvMicroteachCase_Resource_RelGroupByCaseIdDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvMicroteachCase_Resource_RelGroupByCaseIdDA vMicroteachCase_Resource_RelGroupByCaseIdDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvMicroteachCase_Resource_RelGroupByCaseIdDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvMicroteachCase_Resource_RelGroupByCaseIdBL()
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
if (string.IsNullOrEmpty(clsvMicroteachCase_Resource_RelGroupByCaseIdEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvMicroteachCase_Resource_RelGroupByCaseIdEN._ConnectString);
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
public static DataTable GetDataTable_vMicroteachCase_Resource_RelGroupByCaseId(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vMicroteachCase_Resource_RelGroupByCaseIdDA.GetDataTable_vMicroteachCase_Resource_RelGroupByCaseId(strWhereCond);
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
objDT = vMicroteachCase_Resource_RelGroupByCaseIdDA.GetDataTable(strWhereCond);
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
objDT = vMicroteachCase_Resource_RelGroupByCaseIdDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vMicroteachCase_Resource_RelGroupByCaseIdDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vMicroteachCase_Resource_RelGroupByCaseIdDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vMicroteachCase_Resource_RelGroupByCaseIdDA.GetDataTable_Top(objTopPara);
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
objDT = vMicroteachCase_Resource_RelGroupByCaseIdDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vMicroteachCase_Resource_RelGroupByCaseIdDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vMicroteachCase_Resource_RelGroupByCaseIdDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrIdMicroteachCaseLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvMicroteachCase_Resource_RelGroupByCaseIdEN> GetObjLstByIdMicroteachCaseLst(List<string> arrIdMicroteachCaseLst)
{
List<clsvMicroteachCase_Resource_RelGroupByCaseIdEN> arrObjLst = new List<clsvMicroteachCase_Resource_RelGroupByCaseIdEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrIdMicroteachCaseLst, true);
 string strWhereCond = string.Format("IdMicroteachCase in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvMicroteachCase_Resource_RelGroupByCaseIdEN objvMicroteachCase_Resource_RelGroupByCaseIdEN = new clsvMicroteachCase_Resource_RelGroupByCaseIdEN();
try
{
objvMicroteachCase_Resource_RelGroupByCaseIdEN.IdMicroteachCase = objRow[convMicroteachCase_Resource_RelGroupByCaseId.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvMicroteachCase_Resource_RelGroupByCaseIdEN.FuncModuleId = objRow[convMicroteachCase_Resource_RelGroupByCaseId.FuncModuleId].ToString().Trim(); //功能模块Id
objvMicroteachCase_Resource_RelGroupByCaseIdEN.ResourceNum = objRow[convMicroteachCase_Resource_RelGroupByCaseId.ResourceNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachCase_Resource_RelGroupByCaseId.ResourceNum].ToString().Trim()); //资源数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvMicroteachCase_Resource_RelGroupByCaseIdEN.IdMicroteachCase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvMicroteachCase_Resource_RelGroupByCaseIdEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrIdMicroteachCaseLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvMicroteachCase_Resource_RelGroupByCaseIdEN> GetObjLstByIdMicroteachCaseLstCache(List<string> arrIdMicroteachCaseLst)
{
string strKey = string.Format("{0}", clsvMicroteachCase_Resource_RelGroupByCaseIdEN._CurrTabName);
List<clsvMicroteachCase_Resource_RelGroupByCaseIdEN> arrvMicroteachCase_Resource_RelGroupByCaseIdObjLstCache = GetObjLstCache();
IEnumerable <clsvMicroteachCase_Resource_RelGroupByCaseIdEN> arrvMicroteachCase_Resource_RelGroupByCaseIdObjLst_Sel =
arrvMicroteachCase_Resource_RelGroupByCaseIdObjLstCache
.Where(x => arrIdMicroteachCaseLst.Contains(x.IdMicroteachCase));
return arrvMicroteachCase_Resource_RelGroupByCaseIdObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvMicroteachCase_Resource_RelGroupByCaseIdEN> GetObjLst(string strWhereCond)
{
List<clsvMicroteachCase_Resource_RelGroupByCaseIdEN> arrObjLst = new List<clsvMicroteachCase_Resource_RelGroupByCaseIdEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvMicroteachCase_Resource_RelGroupByCaseIdEN objvMicroteachCase_Resource_RelGroupByCaseIdEN = new clsvMicroteachCase_Resource_RelGroupByCaseIdEN();
try
{
objvMicroteachCase_Resource_RelGroupByCaseIdEN.IdMicroteachCase = objRow[convMicroteachCase_Resource_RelGroupByCaseId.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvMicroteachCase_Resource_RelGroupByCaseIdEN.FuncModuleId = objRow[convMicroteachCase_Resource_RelGroupByCaseId.FuncModuleId].ToString().Trim(); //功能模块Id
objvMicroteachCase_Resource_RelGroupByCaseIdEN.ResourceNum = objRow[convMicroteachCase_Resource_RelGroupByCaseId.ResourceNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachCase_Resource_RelGroupByCaseId.ResourceNum].ToString().Trim()); //资源数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvMicroteachCase_Resource_RelGroupByCaseIdEN.IdMicroteachCase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvMicroteachCase_Resource_RelGroupByCaseIdEN);
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
public static List<clsvMicroteachCase_Resource_RelGroupByCaseIdEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvMicroteachCase_Resource_RelGroupByCaseIdEN> arrObjLst = new List<clsvMicroteachCase_Resource_RelGroupByCaseIdEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvMicroteachCase_Resource_RelGroupByCaseIdEN objvMicroteachCase_Resource_RelGroupByCaseIdEN = new clsvMicroteachCase_Resource_RelGroupByCaseIdEN();
try
{
objvMicroteachCase_Resource_RelGroupByCaseIdEN.IdMicroteachCase = objRow[convMicroteachCase_Resource_RelGroupByCaseId.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvMicroteachCase_Resource_RelGroupByCaseIdEN.FuncModuleId = objRow[convMicroteachCase_Resource_RelGroupByCaseId.FuncModuleId].ToString().Trim(); //功能模块Id
objvMicroteachCase_Resource_RelGroupByCaseIdEN.ResourceNum = objRow[convMicroteachCase_Resource_RelGroupByCaseId.ResourceNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachCase_Resource_RelGroupByCaseId.ResourceNum].ToString().Trim()); //资源数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvMicroteachCase_Resource_RelGroupByCaseIdEN.IdMicroteachCase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvMicroteachCase_Resource_RelGroupByCaseIdEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_RelGroupByCaseIdCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvMicroteachCase_Resource_RelGroupByCaseIdEN> GetSubObjLstCache(clsvMicroteachCase_Resource_RelGroupByCaseIdEN objvMicroteachCase_Resource_RelGroupByCaseIdCond)
{
List<clsvMicroteachCase_Resource_RelGroupByCaseIdEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvMicroteachCase_Resource_RelGroupByCaseIdEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convMicroteachCase_Resource_RelGroupByCaseId.AttributeName)
{
if (objvMicroteachCase_Resource_RelGroupByCaseIdCond.IsUpdated(strFldName) == false) continue;
if (objvMicroteachCase_Resource_RelGroupByCaseIdCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvMicroteachCase_Resource_RelGroupByCaseIdCond[strFldName].ToString());
}
else
{
if (objvMicroteachCase_Resource_RelGroupByCaseIdCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvMicroteachCase_Resource_RelGroupByCaseIdCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvMicroteachCase_Resource_RelGroupByCaseIdCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvMicroteachCase_Resource_RelGroupByCaseIdCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvMicroteachCase_Resource_RelGroupByCaseIdCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvMicroteachCase_Resource_RelGroupByCaseIdCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvMicroteachCase_Resource_RelGroupByCaseIdCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvMicroteachCase_Resource_RelGroupByCaseIdCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvMicroteachCase_Resource_RelGroupByCaseIdCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvMicroteachCase_Resource_RelGroupByCaseIdCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvMicroteachCase_Resource_RelGroupByCaseIdCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvMicroteachCase_Resource_RelGroupByCaseIdCond[strFldName]));
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
public static List<clsvMicroteachCase_Resource_RelGroupByCaseIdEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvMicroteachCase_Resource_RelGroupByCaseIdEN> arrObjLst = new List<clsvMicroteachCase_Resource_RelGroupByCaseIdEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvMicroteachCase_Resource_RelGroupByCaseIdEN objvMicroteachCase_Resource_RelGroupByCaseIdEN = new clsvMicroteachCase_Resource_RelGroupByCaseIdEN();
try
{
objvMicroteachCase_Resource_RelGroupByCaseIdEN.IdMicroteachCase = objRow[convMicroteachCase_Resource_RelGroupByCaseId.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvMicroteachCase_Resource_RelGroupByCaseIdEN.FuncModuleId = objRow[convMicroteachCase_Resource_RelGroupByCaseId.FuncModuleId].ToString().Trim(); //功能模块Id
objvMicroteachCase_Resource_RelGroupByCaseIdEN.ResourceNum = objRow[convMicroteachCase_Resource_RelGroupByCaseId.ResourceNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachCase_Resource_RelGroupByCaseId.ResourceNum].ToString().Trim()); //资源数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvMicroteachCase_Resource_RelGroupByCaseIdEN.IdMicroteachCase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvMicroteachCase_Resource_RelGroupByCaseIdEN);
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
public static List<clsvMicroteachCase_Resource_RelGroupByCaseIdEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvMicroteachCase_Resource_RelGroupByCaseIdEN> arrObjLst = new List<clsvMicroteachCase_Resource_RelGroupByCaseIdEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvMicroteachCase_Resource_RelGroupByCaseIdEN objvMicroteachCase_Resource_RelGroupByCaseIdEN = new clsvMicroteachCase_Resource_RelGroupByCaseIdEN();
try
{
objvMicroteachCase_Resource_RelGroupByCaseIdEN.IdMicroteachCase = objRow[convMicroteachCase_Resource_RelGroupByCaseId.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvMicroteachCase_Resource_RelGroupByCaseIdEN.FuncModuleId = objRow[convMicroteachCase_Resource_RelGroupByCaseId.FuncModuleId].ToString().Trim(); //功能模块Id
objvMicroteachCase_Resource_RelGroupByCaseIdEN.ResourceNum = objRow[convMicroteachCase_Resource_RelGroupByCaseId.ResourceNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachCase_Resource_RelGroupByCaseId.ResourceNum].ToString().Trim()); //资源数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvMicroteachCase_Resource_RelGroupByCaseIdEN.IdMicroteachCase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvMicroteachCase_Resource_RelGroupByCaseIdEN);
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
List<clsvMicroteachCase_Resource_RelGroupByCaseIdEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvMicroteachCase_Resource_RelGroupByCaseIdEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvMicroteachCase_Resource_RelGroupByCaseIdEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvMicroteachCase_Resource_RelGroupByCaseIdEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvMicroteachCase_Resource_RelGroupByCaseIdEN> arrObjLst = new List<clsvMicroteachCase_Resource_RelGroupByCaseIdEN>(); 
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
	clsvMicroteachCase_Resource_RelGroupByCaseIdEN objvMicroteachCase_Resource_RelGroupByCaseIdEN = new clsvMicroteachCase_Resource_RelGroupByCaseIdEN();
try
{
objvMicroteachCase_Resource_RelGroupByCaseIdEN.IdMicroteachCase = objRow[convMicroteachCase_Resource_RelGroupByCaseId.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvMicroteachCase_Resource_RelGroupByCaseIdEN.FuncModuleId = objRow[convMicroteachCase_Resource_RelGroupByCaseId.FuncModuleId].ToString().Trim(); //功能模块Id
objvMicroteachCase_Resource_RelGroupByCaseIdEN.ResourceNum = objRow[convMicroteachCase_Resource_RelGroupByCaseId.ResourceNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachCase_Resource_RelGroupByCaseId.ResourceNum].ToString().Trim()); //资源数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvMicroteachCase_Resource_RelGroupByCaseIdEN.IdMicroteachCase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvMicroteachCase_Resource_RelGroupByCaseIdEN);
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
public static List<clsvMicroteachCase_Resource_RelGroupByCaseIdEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvMicroteachCase_Resource_RelGroupByCaseIdEN> arrObjLst = new List<clsvMicroteachCase_Resource_RelGroupByCaseIdEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvMicroteachCase_Resource_RelGroupByCaseIdEN objvMicroteachCase_Resource_RelGroupByCaseIdEN = new clsvMicroteachCase_Resource_RelGroupByCaseIdEN();
try
{
objvMicroteachCase_Resource_RelGroupByCaseIdEN.IdMicroteachCase = objRow[convMicroteachCase_Resource_RelGroupByCaseId.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvMicroteachCase_Resource_RelGroupByCaseIdEN.FuncModuleId = objRow[convMicroteachCase_Resource_RelGroupByCaseId.FuncModuleId].ToString().Trim(); //功能模块Id
objvMicroteachCase_Resource_RelGroupByCaseIdEN.ResourceNum = objRow[convMicroteachCase_Resource_RelGroupByCaseId.ResourceNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachCase_Resource_RelGroupByCaseId.ResourceNum].ToString().Trim()); //资源数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvMicroteachCase_Resource_RelGroupByCaseIdEN.IdMicroteachCase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvMicroteachCase_Resource_RelGroupByCaseIdEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvMicroteachCase_Resource_RelGroupByCaseIdEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvMicroteachCase_Resource_RelGroupByCaseIdEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvMicroteachCase_Resource_RelGroupByCaseIdEN> arrObjLst = new List<clsvMicroteachCase_Resource_RelGroupByCaseIdEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvMicroteachCase_Resource_RelGroupByCaseIdEN objvMicroteachCase_Resource_RelGroupByCaseIdEN = new clsvMicroteachCase_Resource_RelGroupByCaseIdEN();
try
{
objvMicroteachCase_Resource_RelGroupByCaseIdEN.IdMicroteachCase = objRow[convMicroteachCase_Resource_RelGroupByCaseId.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvMicroteachCase_Resource_RelGroupByCaseIdEN.FuncModuleId = objRow[convMicroteachCase_Resource_RelGroupByCaseId.FuncModuleId].ToString().Trim(); //功能模块Id
objvMicroteachCase_Resource_RelGroupByCaseIdEN.ResourceNum = objRow[convMicroteachCase_Resource_RelGroupByCaseId.ResourceNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachCase_Resource_RelGroupByCaseId.ResourceNum].ToString().Trim()); //资源数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvMicroteachCase_Resource_RelGroupByCaseIdEN.IdMicroteachCase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvMicroteachCase_Resource_RelGroupByCaseIdEN);
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
public static List<clsvMicroteachCase_Resource_RelGroupByCaseIdEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvMicroteachCase_Resource_RelGroupByCaseIdEN> arrObjLst = new List<clsvMicroteachCase_Resource_RelGroupByCaseIdEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvMicroteachCase_Resource_RelGroupByCaseIdEN objvMicroteachCase_Resource_RelGroupByCaseIdEN = new clsvMicroteachCase_Resource_RelGroupByCaseIdEN();
try
{
objvMicroteachCase_Resource_RelGroupByCaseIdEN.IdMicroteachCase = objRow[convMicroteachCase_Resource_RelGroupByCaseId.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvMicroteachCase_Resource_RelGroupByCaseIdEN.FuncModuleId = objRow[convMicroteachCase_Resource_RelGroupByCaseId.FuncModuleId].ToString().Trim(); //功能模块Id
objvMicroteachCase_Resource_RelGroupByCaseIdEN.ResourceNum = objRow[convMicroteachCase_Resource_RelGroupByCaseId.ResourceNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachCase_Resource_RelGroupByCaseId.ResourceNum].ToString().Trim()); //资源数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvMicroteachCase_Resource_RelGroupByCaseIdEN.IdMicroteachCase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvMicroteachCase_Resource_RelGroupByCaseIdEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvMicroteachCase_Resource_RelGroupByCaseIdEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvMicroteachCase_Resource_RelGroupByCaseIdEN> arrObjLst = new List<clsvMicroteachCase_Resource_RelGroupByCaseIdEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvMicroteachCase_Resource_RelGroupByCaseIdEN objvMicroteachCase_Resource_RelGroupByCaseIdEN = new clsvMicroteachCase_Resource_RelGroupByCaseIdEN();
try
{
objvMicroteachCase_Resource_RelGroupByCaseIdEN.IdMicroteachCase = objRow[convMicroteachCase_Resource_RelGroupByCaseId.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvMicroteachCase_Resource_RelGroupByCaseIdEN.FuncModuleId = objRow[convMicroteachCase_Resource_RelGroupByCaseId.FuncModuleId].ToString().Trim(); //功能模块Id
objvMicroteachCase_Resource_RelGroupByCaseIdEN.ResourceNum = objRow[convMicroteachCase_Resource_RelGroupByCaseId.ResourceNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachCase_Resource_RelGroupByCaseId.ResourceNum].ToString().Trim()); //资源数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvMicroteachCase_Resource_RelGroupByCaseIdEN.IdMicroteachCase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvMicroteachCase_Resource_RelGroupByCaseIdEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_RelGroupByCaseIdEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvMicroteachCase_Resource_RelGroupByCaseId(ref clsvMicroteachCase_Resource_RelGroupByCaseIdEN objvMicroteachCase_Resource_RelGroupByCaseIdEN)
{
bool bolResult = vMicroteachCase_Resource_RelGroupByCaseIdDA.GetvMicroteachCase_Resource_RelGroupByCaseId(ref objvMicroteachCase_Resource_RelGroupByCaseIdEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strIdMicroteachCase">表关键字</param>
 /// <returns>表对象</returns>
public static clsvMicroteachCase_Resource_RelGroupByCaseIdEN GetObjByIdMicroteachCase(string strIdMicroteachCase)
{
if (strIdMicroteachCase.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strIdMicroteachCase]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strIdMicroteachCase) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strIdMicroteachCase]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsvMicroteachCase_Resource_RelGroupByCaseIdEN objvMicroteachCase_Resource_RelGroupByCaseIdEN = vMicroteachCase_Resource_RelGroupByCaseIdDA.GetObjByIdMicroteachCase(strIdMicroteachCase);
return objvMicroteachCase_Resource_RelGroupByCaseIdEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvMicroteachCase_Resource_RelGroupByCaseIdEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvMicroteachCase_Resource_RelGroupByCaseIdEN objvMicroteachCase_Resource_RelGroupByCaseIdEN = vMicroteachCase_Resource_RelGroupByCaseIdDA.GetFirstObj(strWhereCond);
 return objvMicroteachCase_Resource_RelGroupByCaseIdEN;
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
public static clsvMicroteachCase_Resource_RelGroupByCaseIdEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvMicroteachCase_Resource_RelGroupByCaseIdEN objvMicroteachCase_Resource_RelGroupByCaseIdEN = vMicroteachCase_Resource_RelGroupByCaseIdDA.GetObjByDataRow(objRow);
 return objvMicroteachCase_Resource_RelGroupByCaseIdEN;
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
public static clsvMicroteachCase_Resource_RelGroupByCaseIdEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvMicroteachCase_Resource_RelGroupByCaseIdEN objvMicroteachCase_Resource_RelGroupByCaseIdEN = vMicroteachCase_Resource_RelGroupByCaseIdDA.GetObjByDataRow(objRow);
 return objvMicroteachCase_Resource_RelGroupByCaseIdEN;
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
 /// <param name = "strIdMicroteachCase">所给的关键字</param>
 /// <param name = "lstvMicroteachCase_Resource_RelGroupByCaseIdObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvMicroteachCase_Resource_RelGroupByCaseIdEN GetObjByIdMicroteachCaseFromList(string strIdMicroteachCase, List<clsvMicroteachCase_Resource_RelGroupByCaseIdEN> lstvMicroteachCase_Resource_RelGroupByCaseIdObjLst)
{
foreach (clsvMicroteachCase_Resource_RelGroupByCaseIdEN objvMicroteachCase_Resource_RelGroupByCaseIdEN in lstvMicroteachCase_Resource_RelGroupByCaseIdObjLst)
{
if (objvMicroteachCase_Resource_RelGroupByCaseIdEN.IdMicroteachCase == strIdMicroteachCase)
{
return objvMicroteachCase_Resource_RelGroupByCaseIdEN;
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
 string strIdMicroteachCase;
 try
 {
 strIdMicroteachCase = new clsvMicroteachCase_Resource_RelGroupByCaseIdDA().GetFirstID(strWhereCond);
 return strIdMicroteachCase;
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
 arrList = vMicroteachCase_Resource_RelGroupByCaseIdDA.GetID(strWhereCond);
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
bool bolIsExist = vMicroteachCase_Resource_RelGroupByCaseIdDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strIdMicroteachCase">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strIdMicroteachCase)
{
if (string.IsNullOrEmpty(strIdMicroteachCase) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strIdMicroteachCase]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = vMicroteachCase_Resource_RelGroupByCaseIdDA.IsExist(strIdMicroteachCase);
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
 bolIsExist = clsvMicroteachCase_Resource_RelGroupByCaseIdDA.IsExistTable();
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
 bolIsExist = vMicroteachCase_Resource_RelGroupByCaseIdDA.IsExistTable(strTabName);
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
 /// <param name = "objvMicroteachCase_Resource_RelGroupByCaseIdENS">源对象</param>
 /// <param name = "objvMicroteachCase_Resource_RelGroupByCaseIdENT">目标对象</param>
 public static void CopyTo(clsvMicroteachCase_Resource_RelGroupByCaseIdEN objvMicroteachCase_Resource_RelGroupByCaseIdENS, clsvMicroteachCase_Resource_RelGroupByCaseIdEN objvMicroteachCase_Resource_RelGroupByCaseIdENT)
{
try
{
objvMicroteachCase_Resource_RelGroupByCaseIdENT.IdMicroteachCase = objvMicroteachCase_Resource_RelGroupByCaseIdENS.IdMicroteachCase; //微格教学案例流水号
objvMicroteachCase_Resource_RelGroupByCaseIdENT.FuncModuleId = objvMicroteachCase_Resource_RelGroupByCaseIdENS.FuncModuleId; //功能模块Id
objvMicroteachCase_Resource_RelGroupByCaseIdENT.ResourceNum = objvMicroteachCase_Resource_RelGroupByCaseIdENS.ResourceNum; //资源数
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
 /// <param name = "objvMicroteachCase_Resource_RelGroupByCaseIdEN">源简化对象</param>
 public static void SetUpdFlag(clsvMicroteachCase_Resource_RelGroupByCaseIdEN objvMicroteachCase_Resource_RelGroupByCaseIdEN)
{
try
{
objvMicroteachCase_Resource_RelGroupByCaseIdEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvMicroteachCase_Resource_RelGroupByCaseIdEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convMicroteachCase_Resource_RelGroupByCaseId.IdMicroteachCase, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_RelGroupByCaseIdEN.IdMicroteachCase = objvMicroteachCase_Resource_RelGroupByCaseIdEN.IdMicroteachCase; //微格教学案例流水号
}
if (arrFldSet.Contains(convMicroteachCase_Resource_RelGroupByCaseId.FuncModuleId, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_RelGroupByCaseIdEN.FuncModuleId = objvMicroteachCase_Resource_RelGroupByCaseIdEN.FuncModuleId; //功能模块Id
}
if (arrFldSet.Contains(convMicroteachCase_Resource_RelGroupByCaseId.ResourceNum, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCase_Resource_RelGroupByCaseIdEN.ResourceNum = objvMicroteachCase_Resource_RelGroupByCaseIdEN.ResourceNum; //资源数
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
 /// <param name = "objvMicroteachCase_Resource_RelGroupByCaseIdEN">源简化对象</param>
 public static void AccessFldValueNull(clsvMicroteachCase_Resource_RelGroupByCaseIdEN objvMicroteachCase_Resource_RelGroupByCaseIdEN)
{
try
{
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
public static void CheckProperty4Condition(clsvMicroteachCase_Resource_RelGroupByCaseIdEN objvMicroteachCase_Resource_RelGroupByCaseIdEN)
{
 vMicroteachCase_Resource_RelGroupByCaseIdDA.CheckProperty4Condition(objvMicroteachCase_Resource_RelGroupByCaseIdEN);
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
if (clsMicroteachCase_Resource_RelBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsMicroteachCase_Resource_RelBL没有刷新缓存机制(clsMicroteachCase_Resource_RelBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by IdMicroteachCase");
//if (arrvMicroteachCase_Resource_RelGroupByCaseIdObjLstCache == null)
//{
//arrvMicroteachCase_Resource_RelGroupByCaseIdObjLstCache = vMicroteachCase_Resource_RelGroupByCaseIdDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strIdMicroteachCase">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvMicroteachCase_Resource_RelGroupByCaseIdEN GetObjByIdMicroteachCaseCache(string strIdMicroteachCase)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvMicroteachCase_Resource_RelGroupByCaseIdEN._CurrTabName);
List<clsvMicroteachCase_Resource_RelGroupByCaseIdEN> arrvMicroteachCase_Resource_RelGroupByCaseIdObjLstCache = GetObjLstCache();
IEnumerable <clsvMicroteachCase_Resource_RelGroupByCaseIdEN> arrvMicroteachCase_Resource_RelGroupByCaseIdObjLst_Sel =
arrvMicroteachCase_Resource_RelGroupByCaseIdObjLstCache
.Where(x=> x.IdMicroteachCase == strIdMicroteachCase 
);
if (arrvMicroteachCase_Resource_RelGroupByCaseIdObjLst_Sel.Count() == 0)
{
   clsvMicroteachCase_Resource_RelGroupByCaseIdEN obj = clsvMicroteachCase_Resource_RelGroupByCaseIdBL.GetObjByIdMicroteachCase(strIdMicroteachCase);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvMicroteachCase_Resource_RelGroupByCaseIdObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvMicroteachCase_Resource_RelGroupByCaseIdEN> GetAllvMicroteachCase_Resource_RelGroupByCaseIdObjLstCache()
{
//获取缓存中的对象列表
List<clsvMicroteachCase_Resource_RelGroupByCaseIdEN> arrvMicroteachCase_Resource_RelGroupByCaseIdObjLstCache = GetObjLstCache(); 
return arrvMicroteachCase_Resource_RelGroupByCaseIdObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvMicroteachCase_Resource_RelGroupByCaseIdEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvMicroteachCase_Resource_RelGroupByCaseIdEN._CurrTabName);
List<clsvMicroteachCase_Resource_RelGroupByCaseIdEN> arrvMicroteachCase_Resource_RelGroupByCaseIdObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvMicroteachCase_Resource_RelGroupByCaseIdObjLstCache;
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
string strKey = string.Format("{0}", clsvMicroteachCase_Resource_RelGroupByCaseIdEN._CurrTabName);
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
public static string Func(string strInFldName, string strOutFldName, string strIdMicroteachCase)
{
if (strInFldName != convMicroteachCase_Resource_RelGroupByCaseId.IdMicroteachCase)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convMicroteachCase_Resource_RelGroupByCaseId.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convMicroteachCase_Resource_RelGroupByCaseId.AttributeName));
throw new Exception(strMsg);
}
var objvMicroteachCase_Resource_RelGroupByCaseId = clsvMicroteachCase_Resource_RelGroupByCaseIdBL.GetObjByIdMicroteachCaseCache(strIdMicroteachCase);
if (objvMicroteachCase_Resource_RelGroupByCaseId == null) return "";
return objvMicroteachCase_Resource_RelGroupByCaseId[strOutFldName].ToString();
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
int intRecCount = clsvMicroteachCase_Resource_RelGroupByCaseIdDA.GetRecCount(strTabName);
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
int intRecCount = clsvMicroteachCase_Resource_RelGroupByCaseIdDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvMicroteachCase_Resource_RelGroupByCaseIdDA.GetRecCount();
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
int intRecCount = clsvMicroteachCase_Resource_RelGroupByCaseIdDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_RelGroupByCaseIdCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvMicroteachCase_Resource_RelGroupByCaseIdEN objvMicroteachCase_Resource_RelGroupByCaseIdCond)
{
List<clsvMicroteachCase_Resource_RelGroupByCaseIdEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvMicroteachCase_Resource_RelGroupByCaseIdEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convMicroteachCase_Resource_RelGroupByCaseId.AttributeName)
{
if (objvMicroteachCase_Resource_RelGroupByCaseIdCond.IsUpdated(strFldName) == false) continue;
if (objvMicroteachCase_Resource_RelGroupByCaseIdCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvMicroteachCase_Resource_RelGroupByCaseIdCond[strFldName].ToString());
}
else
{
if (objvMicroteachCase_Resource_RelGroupByCaseIdCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvMicroteachCase_Resource_RelGroupByCaseIdCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvMicroteachCase_Resource_RelGroupByCaseIdCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvMicroteachCase_Resource_RelGroupByCaseIdCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvMicroteachCase_Resource_RelGroupByCaseIdCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvMicroteachCase_Resource_RelGroupByCaseIdCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvMicroteachCase_Resource_RelGroupByCaseIdCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvMicroteachCase_Resource_RelGroupByCaseIdCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvMicroteachCase_Resource_RelGroupByCaseIdCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvMicroteachCase_Resource_RelGroupByCaseIdCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvMicroteachCase_Resource_RelGroupByCaseIdCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvMicroteachCase_Resource_RelGroupByCaseIdCond[strFldName]));
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
 List<string> arrList = clsvMicroteachCase_Resource_RelGroupByCaseIdDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vMicroteachCase_Resource_RelGroupByCaseIdDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vMicroteachCase_Resource_RelGroupByCaseIdDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}