
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvMicroteachCaseQuantitySenateItems_AvgBL
 表名:vMicroteachCaseQuantitySenateItems_Avg(01120491)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:47:58
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
public static class  clsvMicroteachCaseQuantitySenateItems_AvgBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngIdmicroteachCaseQuantitySenate">表关键字</param>
 /// <returns>表对象</returns>
public static clsvMicroteachCaseQuantitySenateItems_AvgEN GetObj(this K_IdmicroteachCaseQuantitySenate_vMicroteachCaseQuantitySenateItems_Avg myKey)
{
clsvMicroteachCaseQuantitySenateItems_AvgEN objvMicroteachCaseQuantitySenateItems_AvgEN = clsvMicroteachCaseQuantitySenateItems_AvgBL.vMicroteachCaseQuantitySenateItems_AvgDA.GetObjByIdmicroteachCaseQuantitySenate(myKey.Value);
return objvMicroteachCaseQuantitySenateItems_AvgEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseQuantitySenateItems_AvgEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCaseQuantitySenateItems_AvgEN SetIdmicroteachCaseQuantitySenate(this clsvMicroteachCaseQuantitySenateItems_AvgEN objvMicroteachCaseQuantitySenateItems_AvgEN, long lngIdmicroteachCaseQuantitySenate, string strComparisonOp="")
	{
objvMicroteachCaseQuantitySenateItems_AvgEN.IdmicroteachCaseQuantitySenate = lngIdmicroteachCaseQuantitySenate; //微格量化评价流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCaseQuantitySenateItems_AvgEN.dicFldComparisonOp.ContainsKey(convMicroteachCaseQuantitySenateItems_Avg.IdmicroteachCaseQuantitySenate) == false)
{
objvMicroteachCaseQuantitySenateItems_AvgEN.dicFldComparisonOp.Add(convMicroteachCaseQuantitySenateItems_Avg.IdmicroteachCaseQuantitySenate, strComparisonOp);
}
else
{
objvMicroteachCaseQuantitySenateItems_AvgEN.dicFldComparisonOp[convMicroteachCaseQuantitySenateItems_Avg.IdmicroteachCaseQuantitySenate] = strComparisonOp;
}
}
return objvMicroteachCaseQuantitySenateItems_AvgEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseQuantitySenateItems_AvgEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCaseQuantitySenateItems_AvgEN SetIdSenateGaugeItem(this clsvMicroteachCaseQuantitySenateItems_AvgEN objvMicroteachCaseQuantitySenateItems_AvgEN, string strIdSenateGaugeItem, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdSenateGaugeItem, convMicroteachCaseQuantitySenateItems_Avg.IdSenateGaugeItem);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdSenateGaugeItem, 4, convMicroteachCaseQuantitySenateItems_Avg.IdSenateGaugeItem);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdSenateGaugeItem, 4, convMicroteachCaseQuantitySenateItems_Avg.IdSenateGaugeItem);
}
objvMicroteachCaseQuantitySenateItems_AvgEN.IdSenateGaugeItem = strIdSenateGaugeItem; //量表指标流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCaseQuantitySenateItems_AvgEN.dicFldComparisonOp.ContainsKey(convMicroteachCaseQuantitySenateItems_Avg.IdSenateGaugeItem) == false)
{
objvMicroteachCaseQuantitySenateItems_AvgEN.dicFldComparisonOp.Add(convMicroteachCaseQuantitySenateItems_Avg.IdSenateGaugeItem, strComparisonOp);
}
else
{
objvMicroteachCaseQuantitySenateItems_AvgEN.dicFldComparisonOp[convMicroteachCaseQuantitySenateItems_Avg.IdSenateGaugeItem] = strComparisonOp;
}
}
return objvMicroteachCaseQuantitySenateItems_AvgEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseQuantitySenateItems_AvgEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCaseQuantitySenateItems_AvgEN SetSenateScoreAvg(this clsvMicroteachCaseQuantitySenateItems_AvgEN objvMicroteachCaseQuantitySenateItems_AvgEN, float? fltSenateScoreAvg, string strComparisonOp="")
	{
objvMicroteachCaseQuantitySenateItems_AvgEN.SenateScoreAvg = fltSenateScoreAvg; //评议平均分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCaseQuantitySenateItems_AvgEN.dicFldComparisonOp.ContainsKey(convMicroteachCaseQuantitySenateItems_Avg.SenateScoreAvg) == false)
{
objvMicroteachCaseQuantitySenateItems_AvgEN.dicFldComparisonOp.Add(convMicroteachCaseQuantitySenateItems_Avg.SenateScoreAvg, strComparisonOp);
}
else
{
objvMicroteachCaseQuantitySenateItems_AvgEN.dicFldComparisonOp[convMicroteachCaseQuantitySenateItems_Avg.SenateScoreAvg] = strComparisonOp;
}
}
return objvMicroteachCaseQuantitySenateItems_AvgEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvMicroteachCaseQuantitySenateItems_AvgENS">源对象</param>
 /// <param name = "objvMicroteachCaseQuantitySenateItems_AvgENT">目标对象</param>
 public static void CopyTo(this clsvMicroteachCaseQuantitySenateItems_AvgEN objvMicroteachCaseQuantitySenateItems_AvgENS, clsvMicroteachCaseQuantitySenateItems_AvgEN objvMicroteachCaseQuantitySenateItems_AvgENT)
{
try
{
objvMicroteachCaseQuantitySenateItems_AvgENT.IdmicroteachCaseQuantitySenate = objvMicroteachCaseQuantitySenateItems_AvgENS.IdmicroteachCaseQuantitySenate; //微格量化评价流水号
objvMicroteachCaseQuantitySenateItems_AvgENT.IdSenateGaugeItem = objvMicroteachCaseQuantitySenateItems_AvgENS.IdSenateGaugeItem; //量表指标流水号
objvMicroteachCaseQuantitySenateItems_AvgENT.SenateScoreAvg = objvMicroteachCaseQuantitySenateItems_AvgENS.SenateScoreAvg; //评议平均分
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
 /// <param name = "objvMicroteachCaseQuantitySenateItems_AvgENS">源对象</param>
 /// <returns>目标对象=>clsvMicroteachCaseQuantitySenateItems_AvgEN:objvMicroteachCaseQuantitySenateItems_AvgENT</returns>
 public static clsvMicroteachCaseQuantitySenateItems_AvgEN CopyTo(this clsvMicroteachCaseQuantitySenateItems_AvgEN objvMicroteachCaseQuantitySenateItems_AvgENS)
{
try
{
 clsvMicroteachCaseQuantitySenateItems_AvgEN objvMicroteachCaseQuantitySenateItems_AvgENT = new clsvMicroteachCaseQuantitySenateItems_AvgEN()
{
IdmicroteachCaseQuantitySenate = objvMicroteachCaseQuantitySenateItems_AvgENS.IdmicroteachCaseQuantitySenate, //微格量化评价流水号
IdSenateGaugeItem = objvMicroteachCaseQuantitySenateItems_AvgENS.IdSenateGaugeItem, //量表指标流水号
SenateScoreAvg = objvMicroteachCaseQuantitySenateItems_AvgENS.SenateScoreAvg, //评议平均分
};
 return objvMicroteachCaseQuantitySenateItems_AvgENT;
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
public static void CheckProperty4Condition(this clsvMicroteachCaseQuantitySenateItems_AvgEN objvMicroteachCaseQuantitySenateItems_AvgEN)
{
 clsvMicroteachCaseQuantitySenateItems_AvgBL.vMicroteachCaseQuantitySenateItems_AvgDA.CheckProperty4Condition(objvMicroteachCaseQuantitySenateItems_AvgEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvMicroteachCaseQuantitySenateItems_AvgEN objvMicroteachCaseQuantitySenateItems_AvgCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvMicroteachCaseQuantitySenateItems_AvgCond.IsUpdated(convMicroteachCaseQuantitySenateItems_Avg.IdmicroteachCaseQuantitySenate) == true)
{
string strComparisonOpIdmicroteachCaseQuantitySenate = objvMicroteachCaseQuantitySenateItems_AvgCond.dicFldComparisonOp[convMicroteachCaseQuantitySenateItems_Avg.IdmicroteachCaseQuantitySenate];
strWhereCond += string.Format(" And {0} {2} {1}", convMicroteachCaseQuantitySenateItems_Avg.IdmicroteachCaseQuantitySenate, objvMicroteachCaseQuantitySenateItems_AvgCond.IdmicroteachCaseQuantitySenate, strComparisonOpIdmicroteachCaseQuantitySenate);
}
if (objvMicroteachCaseQuantitySenateItems_AvgCond.IsUpdated(convMicroteachCaseQuantitySenateItems_Avg.IdSenateGaugeItem) == true)
{
string strComparisonOpIdSenateGaugeItem = objvMicroteachCaseQuantitySenateItems_AvgCond.dicFldComparisonOp[convMicroteachCaseQuantitySenateItems_Avg.IdSenateGaugeItem];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseQuantitySenateItems_Avg.IdSenateGaugeItem, objvMicroteachCaseQuantitySenateItems_AvgCond.IdSenateGaugeItem, strComparisonOpIdSenateGaugeItem);
}
if (objvMicroteachCaseQuantitySenateItems_AvgCond.IsUpdated(convMicroteachCaseQuantitySenateItems_Avg.SenateScoreAvg) == true)
{
string strComparisonOpSenateScoreAvg = objvMicroteachCaseQuantitySenateItems_AvgCond.dicFldComparisonOp[convMicroteachCaseQuantitySenateItems_Avg.SenateScoreAvg];
strWhereCond += string.Format(" And {0} {2} {1}", convMicroteachCaseQuantitySenateItems_Avg.SenateScoreAvg, objvMicroteachCaseQuantitySenateItems_AvgCond.SenateScoreAvg, strComparisonOpSenateScoreAvg);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vMicroteachCaseQuantitySenateItems_Avg
{
public virtual bool UpdRelaTabDate(long lngIdmicroteachCaseQuantitySenate, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v微格量化评价详细指标_Avg(vMicroteachCaseQuantitySenateItems_Avg)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvMicroteachCaseQuantitySenateItems_AvgBL
{
public static RelatedActions_vMicroteachCaseQuantitySenateItems_Avg relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvMicroteachCaseQuantitySenateItems_AvgDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvMicroteachCaseQuantitySenateItems_AvgDA vMicroteachCaseQuantitySenateItems_AvgDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvMicroteachCaseQuantitySenateItems_AvgDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvMicroteachCaseQuantitySenateItems_AvgBL()
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
if (string.IsNullOrEmpty(clsvMicroteachCaseQuantitySenateItems_AvgEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvMicroteachCaseQuantitySenateItems_AvgEN._ConnectString);
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
public static DataTable GetDataTable_vMicroteachCaseQuantitySenateItems_Avg(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vMicroteachCaseQuantitySenateItems_AvgDA.GetDataTable_vMicroteachCaseQuantitySenateItems_Avg(strWhereCond);
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
objDT = vMicroteachCaseQuantitySenateItems_AvgDA.GetDataTable(strWhereCond);
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
objDT = vMicroteachCaseQuantitySenateItems_AvgDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vMicroteachCaseQuantitySenateItems_AvgDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vMicroteachCaseQuantitySenateItems_AvgDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vMicroteachCaseQuantitySenateItems_AvgDA.GetDataTable_Top(objTopPara);
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
objDT = vMicroteachCaseQuantitySenateItems_AvgDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vMicroteachCaseQuantitySenateItems_AvgDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vMicroteachCaseQuantitySenateItems_AvgDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrIdmicroteachCaseQuantitySenateLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvMicroteachCaseQuantitySenateItems_AvgEN> GetObjLstByIdmicroteachCaseQuantitySenateLst(List<long> arrIdmicroteachCaseQuantitySenateLst)
{
List<clsvMicroteachCaseQuantitySenateItems_AvgEN> arrObjLst = new List<clsvMicroteachCaseQuantitySenateItems_AvgEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrIdmicroteachCaseQuantitySenateLst);
 string strWhereCond = string.Format("IdmicroteachCaseQuantitySenate in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvMicroteachCaseQuantitySenateItems_AvgEN objvMicroteachCaseQuantitySenateItems_AvgEN = new clsvMicroteachCaseQuantitySenateItems_AvgEN();
try
{
objvMicroteachCaseQuantitySenateItems_AvgEN.IdmicroteachCaseQuantitySenate = Int32.Parse(objRow[convMicroteachCaseQuantitySenateItems_Avg.IdmicroteachCaseQuantitySenate].ToString().Trim()); //微格量化评价流水号
objvMicroteachCaseQuantitySenateItems_AvgEN.IdSenateGaugeItem = objRow[convMicroteachCaseQuantitySenateItems_Avg.IdSenateGaugeItem].ToString().Trim(); //量表指标流水号
objvMicroteachCaseQuantitySenateItems_AvgEN.SenateScoreAvg = objRow[convMicroteachCaseQuantitySenateItems_Avg.SenateScoreAvg] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convMicroteachCaseQuantitySenateItems_Avg.SenateScoreAvg].ToString().Trim()); //评议平均分
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvMicroteachCaseQuantitySenateItems_AvgEN.IdmicroteachCaseQuantitySenate, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvMicroteachCaseQuantitySenateItems_AvgEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrIdmicroteachCaseQuantitySenateLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvMicroteachCaseQuantitySenateItems_AvgEN> GetObjLstByIdmicroteachCaseQuantitySenateLstCache(List<long> arrIdmicroteachCaseQuantitySenateLst)
{
string strKey = string.Format("{0}", clsvMicroteachCaseQuantitySenateItems_AvgEN._CurrTabName);
List<clsvMicroteachCaseQuantitySenateItems_AvgEN> arrvMicroteachCaseQuantitySenateItems_AvgObjLstCache = GetObjLstCache();
IEnumerable <clsvMicroteachCaseQuantitySenateItems_AvgEN> arrvMicroteachCaseQuantitySenateItems_AvgObjLst_Sel =
arrvMicroteachCaseQuantitySenateItems_AvgObjLstCache
.Where(x => arrIdmicroteachCaseQuantitySenateLst.Contains(x.IdmicroteachCaseQuantitySenate));
return arrvMicroteachCaseQuantitySenateItems_AvgObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvMicroteachCaseQuantitySenateItems_AvgEN> GetObjLst(string strWhereCond)
{
List<clsvMicroteachCaseQuantitySenateItems_AvgEN> arrObjLst = new List<clsvMicroteachCaseQuantitySenateItems_AvgEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvMicroteachCaseQuantitySenateItems_AvgEN objvMicroteachCaseQuantitySenateItems_AvgEN = new clsvMicroteachCaseQuantitySenateItems_AvgEN();
try
{
objvMicroteachCaseQuantitySenateItems_AvgEN.IdmicroteachCaseQuantitySenate = Int32.Parse(objRow[convMicroteachCaseQuantitySenateItems_Avg.IdmicroteachCaseQuantitySenate].ToString().Trim()); //微格量化评价流水号
objvMicroteachCaseQuantitySenateItems_AvgEN.IdSenateGaugeItem = objRow[convMicroteachCaseQuantitySenateItems_Avg.IdSenateGaugeItem].ToString().Trim(); //量表指标流水号
objvMicroteachCaseQuantitySenateItems_AvgEN.SenateScoreAvg = objRow[convMicroteachCaseQuantitySenateItems_Avg.SenateScoreAvg] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convMicroteachCaseQuantitySenateItems_Avg.SenateScoreAvg].ToString().Trim()); //评议平均分
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvMicroteachCaseQuantitySenateItems_AvgEN.IdmicroteachCaseQuantitySenate, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvMicroteachCaseQuantitySenateItems_AvgEN);
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
public static List<clsvMicroteachCaseQuantitySenateItems_AvgEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvMicroteachCaseQuantitySenateItems_AvgEN> arrObjLst = new List<clsvMicroteachCaseQuantitySenateItems_AvgEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvMicroteachCaseQuantitySenateItems_AvgEN objvMicroteachCaseQuantitySenateItems_AvgEN = new clsvMicroteachCaseQuantitySenateItems_AvgEN();
try
{
objvMicroteachCaseQuantitySenateItems_AvgEN.IdmicroteachCaseQuantitySenate = Int32.Parse(objRow[convMicroteachCaseQuantitySenateItems_Avg.IdmicroteachCaseQuantitySenate].ToString().Trim()); //微格量化评价流水号
objvMicroteachCaseQuantitySenateItems_AvgEN.IdSenateGaugeItem = objRow[convMicroteachCaseQuantitySenateItems_Avg.IdSenateGaugeItem].ToString().Trim(); //量表指标流水号
objvMicroteachCaseQuantitySenateItems_AvgEN.SenateScoreAvg = objRow[convMicroteachCaseQuantitySenateItems_Avg.SenateScoreAvg] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convMicroteachCaseQuantitySenateItems_Avg.SenateScoreAvg].ToString().Trim()); //评议平均分
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvMicroteachCaseQuantitySenateItems_AvgEN.IdmicroteachCaseQuantitySenate, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvMicroteachCaseQuantitySenateItems_AvgEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvMicroteachCaseQuantitySenateItems_AvgCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvMicroteachCaseQuantitySenateItems_AvgEN> GetSubObjLstCache(clsvMicroteachCaseQuantitySenateItems_AvgEN objvMicroteachCaseQuantitySenateItems_AvgCond)
{
List<clsvMicroteachCaseQuantitySenateItems_AvgEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvMicroteachCaseQuantitySenateItems_AvgEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convMicroteachCaseQuantitySenateItems_Avg.AttributeName)
{
if (objvMicroteachCaseQuantitySenateItems_AvgCond.IsUpdated(strFldName) == false) continue;
if (objvMicroteachCaseQuantitySenateItems_AvgCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvMicroteachCaseQuantitySenateItems_AvgCond[strFldName].ToString());
}
else
{
if (objvMicroteachCaseQuantitySenateItems_AvgCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvMicroteachCaseQuantitySenateItems_AvgCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvMicroteachCaseQuantitySenateItems_AvgCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvMicroteachCaseQuantitySenateItems_AvgCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvMicroteachCaseQuantitySenateItems_AvgCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvMicroteachCaseQuantitySenateItems_AvgCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvMicroteachCaseQuantitySenateItems_AvgCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvMicroteachCaseQuantitySenateItems_AvgCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvMicroteachCaseQuantitySenateItems_AvgCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvMicroteachCaseQuantitySenateItems_AvgCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvMicroteachCaseQuantitySenateItems_AvgCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvMicroteachCaseQuantitySenateItems_AvgCond[strFldName]));
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
public static List<clsvMicroteachCaseQuantitySenateItems_AvgEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvMicroteachCaseQuantitySenateItems_AvgEN> arrObjLst = new List<clsvMicroteachCaseQuantitySenateItems_AvgEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvMicroteachCaseQuantitySenateItems_AvgEN objvMicroteachCaseQuantitySenateItems_AvgEN = new clsvMicroteachCaseQuantitySenateItems_AvgEN();
try
{
objvMicroteachCaseQuantitySenateItems_AvgEN.IdmicroteachCaseQuantitySenate = Int32.Parse(objRow[convMicroteachCaseQuantitySenateItems_Avg.IdmicroteachCaseQuantitySenate].ToString().Trim()); //微格量化评价流水号
objvMicroteachCaseQuantitySenateItems_AvgEN.IdSenateGaugeItem = objRow[convMicroteachCaseQuantitySenateItems_Avg.IdSenateGaugeItem].ToString().Trim(); //量表指标流水号
objvMicroteachCaseQuantitySenateItems_AvgEN.SenateScoreAvg = objRow[convMicroteachCaseQuantitySenateItems_Avg.SenateScoreAvg] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convMicroteachCaseQuantitySenateItems_Avg.SenateScoreAvg].ToString().Trim()); //评议平均分
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvMicroteachCaseQuantitySenateItems_AvgEN.IdmicroteachCaseQuantitySenate, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvMicroteachCaseQuantitySenateItems_AvgEN);
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
public static List<clsvMicroteachCaseQuantitySenateItems_AvgEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvMicroteachCaseQuantitySenateItems_AvgEN> arrObjLst = new List<clsvMicroteachCaseQuantitySenateItems_AvgEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvMicroteachCaseQuantitySenateItems_AvgEN objvMicroteachCaseQuantitySenateItems_AvgEN = new clsvMicroteachCaseQuantitySenateItems_AvgEN();
try
{
objvMicroteachCaseQuantitySenateItems_AvgEN.IdmicroteachCaseQuantitySenate = Int32.Parse(objRow[convMicroteachCaseQuantitySenateItems_Avg.IdmicroteachCaseQuantitySenate].ToString().Trim()); //微格量化评价流水号
objvMicroteachCaseQuantitySenateItems_AvgEN.IdSenateGaugeItem = objRow[convMicroteachCaseQuantitySenateItems_Avg.IdSenateGaugeItem].ToString().Trim(); //量表指标流水号
objvMicroteachCaseQuantitySenateItems_AvgEN.SenateScoreAvg = objRow[convMicroteachCaseQuantitySenateItems_Avg.SenateScoreAvg] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convMicroteachCaseQuantitySenateItems_Avg.SenateScoreAvg].ToString().Trim()); //评议平均分
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvMicroteachCaseQuantitySenateItems_AvgEN.IdmicroteachCaseQuantitySenate, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvMicroteachCaseQuantitySenateItems_AvgEN);
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
List<clsvMicroteachCaseQuantitySenateItems_AvgEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvMicroteachCaseQuantitySenateItems_AvgEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvMicroteachCaseQuantitySenateItems_AvgEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvMicroteachCaseQuantitySenateItems_AvgEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvMicroteachCaseQuantitySenateItems_AvgEN> arrObjLst = new List<clsvMicroteachCaseQuantitySenateItems_AvgEN>(); 
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
	clsvMicroteachCaseQuantitySenateItems_AvgEN objvMicroteachCaseQuantitySenateItems_AvgEN = new clsvMicroteachCaseQuantitySenateItems_AvgEN();
try
{
objvMicroteachCaseQuantitySenateItems_AvgEN.IdmicroteachCaseQuantitySenate = Int32.Parse(objRow[convMicroteachCaseQuantitySenateItems_Avg.IdmicroteachCaseQuantitySenate].ToString().Trim()); //微格量化评价流水号
objvMicroteachCaseQuantitySenateItems_AvgEN.IdSenateGaugeItem = objRow[convMicroteachCaseQuantitySenateItems_Avg.IdSenateGaugeItem].ToString().Trim(); //量表指标流水号
objvMicroteachCaseQuantitySenateItems_AvgEN.SenateScoreAvg = objRow[convMicroteachCaseQuantitySenateItems_Avg.SenateScoreAvg] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convMicroteachCaseQuantitySenateItems_Avg.SenateScoreAvg].ToString().Trim()); //评议平均分
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvMicroteachCaseQuantitySenateItems_AvgEN.IdmicroteachCaseQuantitySenate, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvMicroteachCaseQuantitySenateItems_AvgEN);
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
public static List<clsvMicroteachCaseQuantitySenateItems_AvgEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvMicroteachCaseQuantitySenateItems_AvgEN> arrObjLst = new List<clsvMicroteachCaseQuantitySenateItems_AvgEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvMicroteachCaseQuantitySenateItems_AvgEN objvMicroteachCaseQuantitySenateItems_AvgEN = new clsvMicroteachCaseQuantitySenateItems_AvgEN();
try
{
objvMicroteachCaseQuantitySenateItems_AvgEN.IdmicroteachCaseQuantitySenate = Int32.Parse(objRow[convMicroteachCaseQuantitySenateItems_Avg.IdmicroteachCaseQuantitySenate].ToString().Trim()); //微格量化评价流水号
objvMicroteachCaseQuantitySenateItems_AvgEN.IdSenateGaugeItem = objRow[convMicroteachCaseQuantitySenateItems_Avg.IdSenateGaugeItem].ToString().Trim(); //量表指标流水号
objvMicroteachCaseQuantitySenateItems_AvgEN.SenateScoreAvg = objRow[convMicroteachCaseQuantitySenateItems_Avg.SenateScoreAvg] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convMicroteachCaseQuantitySenateItems_Avg.SenateScoreAvg].ToString().Trim()); //评议平均分
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvMicroteachCaseQuantitySenateItems_AvgEN.IdmicroteachCaseQuantitySenate, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvMicroteachCaseQuantitySenateItems_AvgEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvMicroteachCaseQuantitySenateItems_AvgEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvMicroteachCaseQuantitySenateItems_AvgEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvMicroteachCaseQuantitySenateItems_AvgEN> arrObjLst = new List<clsvMicroteachCaseQuantitySenateItems_AvgEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvMicroteachCaseQuantitySenateItems_AvgEN objvMicroteachCaseQuantitySenateItems_AvgEN = new clsvMicroteachCaseQuantitySenateItems_AvgEN();
try
{
objvMicroteachCaseQuantitySenateItems_AvgEN.IdmicroteachCaseQuantitySenate = Int32.Parse(objRow[convMicroteachCaseQuantitySenateItems_Avg.IdmicroteachCaseQuantitySenate].ToString().Trim()); //微格量化评价流水号
objvMicroteachCaseQuantitySenateItems_AvgEN.IdSenateGaugeItem = objRow[convMicroteachCaseQuantitySenateItems_Avg.IdSenateGaugeItem].ToString().Trim(); //量表指标流水号
objvMicroteachCaseQuantitySenateItems_AvgEN.SenateScoreAvg = objRow[convMicroteachCaseQuantitySenateItems_Avg.SenateScoreAvg] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convMicroteachCaseQuantitySenateItems_Avg.SenateScoreAvg].ToString().Trim()); //评议平均分
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvMicroteachCaseQuantitySenateItems_AvgEN.IdmicroteachCaseQuantitySenate, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvMicroteachCaseQuantitySenateItems_AvgEN);
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
public static List<clsvMicroteachCaseQuantitySenateItems_AvgEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvMicroteachCaseQuantitySenateItems_AvgEN> arrObjLst = new List<clsvMicroteachCaseQuantitySenateItems_AvgEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvMicroteachCaseQuantitySenateItems_AvgEN objvMicroteachCaseQuantitySenateItems_AvgEN = new clsvMicroteachCaseQuantitySenateItems_AvgEN();
try
{
objvMicroteachCaseQuantitySenateItems_AvgEN.IdmicroteachCaseQuantitySenate = Int32.Parse(objRow[convMicroteachCaseQuantitySenateItems_Avg.IdmicroteachCaseQuantitySenate].ToString().Trim()); //微格量化评价流水号
objvMicroteachCaseQuantitySenateItems_AvgEN.IdSenateGaugeItem = objRow[convMicroteachCaseQuantitySenateItems_Avg.IdSenateGaugeItem].ToString().Trim(); //量表指标流水号
objvMicroteachCaseQuantitySenateItems_AvgEN.SenateScoreAvg = objRow[convMicroteachCaseQuantitySenateItems_Avg.SenateScoreAvg] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convMicroteachCaseQuantitySenateItems_Avg.SenateScoreAvg].ToString().Trim()); //评议平均分
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvMicroteachCaseQuantitySenateItems_AvgEN.IdmicroteachCaseQuantitySenate, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvMicroteachCaseQuantitySenateItems_AvgEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvMicroteachCaseQuantitySenateItems_AvgEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvMicroteachCaseQuantitySenateItems_AvgEN> arrObjLst = new List<clsvMicroteachCaseQuantitySenateItems_AvgEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvMicroteachCaseQuantitySenateItems_AvgEN objvMicroteachCaseQuantitySenateItems_AvgEN = new clsvMicroteachCaseQuantitySenateItems_AvgEN();
try
{
objvMicroteachCaseQuantitySenateItems_AvgEN.IdmicroteachCaseQuantitySenate = Int32.Parse(objRow[convMicroteachCaseQuantitySenateItems_Avg.IdmicroteachCaseQuantitySenate].ToString().Trim()); //微格量化评价流水号
objvMicroteachCaseQuantitySenateItems_AvgEN.IdSenateGaugeItem = objRow[convMicroteachCaseQuantitySenateItems_Avg.IdSenateGaugeItem].ToString().Trim(); //量表指标流水号
objvMicroteachCaseQuantitySenateItems_AvgEN.SenateScoreAvg = objRow[convMicroteachCaseQuantitySenateItems_Avg.SenateScoreAvg] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convMicroteachCaseQuantitySenateItems_Avg.SenateScoreAvg].ToString().Trim()); //评议平均分
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvMicroteachCaseQuantitySenateItems_AvgEN.IdmicroteachCaseQuantitySenate, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvMicroteachCaseQuantitySenateItems_AvgEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvMicroteachCaseQuantitySenateItems_AvgEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvMicroteachCaseQuantitySenateItems_Avg(ref clsvMicroteachCaseQuantitySenateItems_AvgEN objvMicroteachCaseQuantitySenateItems_AvgEN)
{
bool bolResult = vMicroteachCaseQuantitySenateItems_AvgDA.GetvMicroteachCaseQuantitySenateItems_Avg(ref objvMicroteachCaseQuantitySenateItems_AvgEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngIdmicroteachCaseQuantitySenate">表关键字</param>
 /// <returns>表对象</returns>
public static clsvMicroteachCaseQuantitySenateItems_AvgEN GetObjByIdmicroteachCaseQuantitySenate(long lngIdmicroteachCaseQuantitySenate)
{
clsvMicroteachCaseQuantitySenateItems_AvgEN objvMicroteachCaseQuantitySenateItems_AvgEN = vMicroteachCaseQuantitySenateItems_AvgDA.GetObjByIdmicroteachCaseQuantitySenate(lngIdmicroteachCaseQuantitySenate);
return objvMicroteachCaseQuantitySenateItems_AvgEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvMicroteachCaseQuantitySenateItems_AvgEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvMicroteachCaseQuantitySenateItems_AvgEN objvMicroteachCaseQuantitySenateItems_AvgEN = vMicroteachCaseQuantitySenateItems_AvgDA.GetFirstObj(strWhereCond);
 return objvMicroteachCaseQuantitySenateItems_AvgEN;
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
public static clsvMicroteachCaseQuantitySenateItems_AvgEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvMicroteachCaseQuantitySenateItems_AvgEN objvMicroteachCaseQuantitySenateItems_AvgEN = vMicroteachCaseQuantitySenateItems_AvgDA.GetObjByDataRow(objRow);
 return objvMicroteachCaseQuantitySenateItems_AvgEN;
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
public static clsvMicroteachCaseQuantitySenateItems_AvgEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvMicroteachCaseQuantitySenateItems_AvgEN objvMicroteachCaseQuantitySenateItems_AvgEN = vMicroteachCaseQuantitySenateItems_AvgDA.GetObjByDataRow(objRow);
 return objvMicroteachCaseQuantitySenateItems_AvgEN;
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
 /// <param name = "lngIdmicroteachCaseQuantitySenate">所给的关键字</param>
 /// <param name = "lstvMicroteachCaseQuantitySenateItems_AvgObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvMicroteachCaseQuantitySenateItems_AvgEN GetObjByIdmicroteachCaseQuantitySenateFromList(long lngIdmicroteachCaseQuantitySenate, List<clsvMicroteachCaseQuantitySenateItems_AvgEN> lstvMicroteachCaseQuantitySenateItems_AvgObjLst)
{
foreach (clsvMicroteachCaseQuantitySenateItems_AvgEN objvMicroteachCaseQuantitySenateItems_AvgEN in lstvMicroteachCaseQuantitySenateItems_AvgObjLst)
{
if (objvMicroteachCaseQuantitySenateItems_AvgEN.IdmicroteachCaseQuantitySenate == lngIdmicroteachCaseQuantitySenate)
{
return objvMicroteachCaseQuantitySenateItems_AvgEN;
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
 long lngIdmicroteachCaseQuantitySenate;
 try
 {
 lngIdmicroteachCaseQuantitySenate = new clsvMicroteachCaseQuantitySenateItems_AvgDA().GetFirstID(strWhereCond);
 return lngIdmicroteachCaseQuantitySenate;
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
 arrList = vMicroteachCaseQuantitySenateItems_AvgDA.GetID(strWhereCond);
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
bool bolIsExist = vMicroteachCaseQuantitySenateItems_AvgDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "lngIdmicroteachCaseQuantitySenate">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(long lngIdmicroteachCaseQuantitySenate)
{
//检测记录是否存在
bool bolIsExist = vMicroteachCaseQuantitySenateItems_AvgDA.IsExist(lngIdmicroteachCaseQuantitySenate);
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
 bolIsExist = clsvMicroteachCaseQuantitySenateItems_AvgDA.IsExistTable();
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
 bolIsExist = vMicroteachCaseQuantitySenateItems_AvgDA.IsExistTable(strTabName);
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
 /// <param name = "objvMicroteachCaseQuantitySenateItems_AvgENS">源对象</param>
 /// <param name = "objvMicroteachCaseQuantitySenateItems_AvgENT">目标对象</param>
 public static void CopyTo(clsvMicroteachCaseQuantitySenateItems_AvgEN objvMicroteachCaseQuantitySenateItems_AvgENS, clsvMicroteachCaseQuantitySenateItems_AvgEN objvMicroteachCaseQuantitySenateItems_AvgENT)
{
try
{
objvMicroteachCaseQuantitySenateItems_AvgENT.IdmicroteachCaseQuantitySenate = objvMicroteachCaseQuantitySenateItems_AvgENS.IdmicroteachCaseQuantitySenate; //微格量化评价流水号
objvMicroteachCaseQuantitySenateItems_AvgENT.IdSenateGaugeItem = objvMicroteachCaseQuantitySenateItems_AvgENS.IdSenateGaugeItem; //量表指标流水号
objvMicroteachCaseQuantitySenateItems_AvgENT.SenateScoreAvg = objvMicroteachCaseQuantitySenateItems_AvgENS.SenateScoreAvg; //评议平均分
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
 /// <param name = "objvMicroteachCaseQuantitySenateItems_AvgEN">源简化对象</param>
 public static void SetUpdFlag(clsvMicroteachCaseQuantitySenateItems_AvgEN objvMicroteachCaseQuantitySenateItems_AvgEN)
{
try
{
objvMicroteachCaseQuantitySenateItems_AvgEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvMicroteachCaseQuantitySenateItems_AvgEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convMicroteachCaseQuantitySenateItems_Avg.IdmicroteachCaseQuantitySenate, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCaseQuantitySenateItems_AvgEN.IdmicroteachCaseQuantitySenate = objvMicroteachCaseQuantitySenateItems_AvgEN.IdmicroteachCaseQuantitySenate; //微格量化评价流水号
}
if (arrFldSet.Contains(convMicroteachCaseQuantitySenateItems_Avg.IdSenateGaugeItem, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCaseQuantitySenateItems_AvgEN.IdSenateGaugeItem = objvMicroteachCaseQuantitySenateItems_AvgEN.IdSenateGaugeItem; //量表指标流水号
}
if (arrFldSet.Contains(convMicroteachCaseQuantitySenateItems_Avg.SenateScoreAvg, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCaseQuantitySenateItems_AvgEN.SenateScoreAvg = objvMicroteachCaseQuantitySenateItems_AvgEN.SenateScoreAvg; //评议平均分
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
 /// <param name = "objvMicroteachCaseQuantitySenateItems_AvgEN">源简化对象</param>
 public static void AccessFldValueNull(clsvMicroteachCaseQuantitySenateItems_AvgEN objvMicroteachCaseQuantitySenateItems_AvgEN)
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
public static void CheckProperty4Condition(clsvMicroteachCaseQuantitySenateItems_AvgEN objvMicroteachCaseQuantitySenateItems_AvgEN)
{
 vMicroteachCaseQuantitySenateItems_AvgDA.CheckProperty4Condition(objvMicroteachCaseQuantitySenateItems_AvgEN);
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
if (clsMicroteachCaseQuantitySenateItemsBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsMicroteachCaseQuantitySenateItemsBL没有刷新缓存机制(clsMicroteachCaseQuantitySenateItemsBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by IdmicroteachCaseQuantitySenate");
//if (arrvMicroteachCaseQuantitySenateItems_AvgObjLstCache == null)
//{
//arrvMicroteachCaseQuantitySenateItems_AvgObjLstCache = vMicroteachCaseQuantitySenateItems_AvgDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngIdmicroteachCaseQuantitySenate">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvMicroteachCaseQuantitySenateItems_AvgEN GetObjByIdmicroteachCaseQuantitySenateCache(long lngIdmicroteachCaseQuantitySenate)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvMicroteachCaseQuantitySenateItems_AvgEN._CurrTabName);
List<clsvMicroteachCaseQuantitySenateItems_AvgEN> arrvMicroteachCaseQuantitySenateItems_AvgObjLstCache = GetObjLstCache();
IEnumerable <clsvMicroteachCaseQuantitySenateItems_AvgEN> arrvMicroteachCaseQuantitySenateItems_AvgObjLst_Sel =
arrvMicroteachCaseQuantitySenateItems_AvgObjLstCache
.Where(x=> x.IdmicroteachCaseQuantitySenate == lngIdmicroteachCaseQuantitySenate 
);
if (arrvMicroteachCaseQuantitySenateItems_AvgObjLst_Sel.Count() == 0)
{
   clsvMicroteachCaseQuantitySenateItems_AvgEN obj = clsvMicroteachCaseQuantitySenateItems_AvgBL.GetObjByIdmicroteachCaseQuantitySenate(lngIdmicroteachCaseQuantitySenate);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvMicroteachCaseQuantitySenateItems_AvgObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvMicroteachCaseQuantitySenateItems_AvgEN> GetAllvMicroteachCaseQuantitySenateItems_AvgObjLstCache()
{
//获取缓存中的对象列表
List<clsvMicroteachCaseQuantitySenateItems_AvgEN> arrvMicroteachCaseQuantitySenateItems_AvgObjLstCache = GetObjLstCache(); 
return arrvMicroteachCaseQuantitySenateItems_AvgObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvMicroteachCaseQuantitySenateItems_AvgEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvMicroteachCaseQuantitySenateItems_AvgEN._CurrTabName);
List<clsvMicroteachCaseQuantitySenateItems_AvgEN> arrvMicroteachCaseQuantitySenateItems_AvgObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvMicroteachCaseQuantitySenateItems_AvgObjLstCache;
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
string strKey = string.Format("{0}", clsvMicroteachCaseQuantitySenateItems_AvgEN._CurrTabName);
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
public static string Func(string strInFldName, string strOutFldName, long lngIdmicroteachCaseQuantitySenate)
{
if (strInFldName != convMicroteachCaseQuantitySenateItems_Avg.IdmicroteachCaseQuantitySenate)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convMicroteachCaseQuantitySenateItems_Avg.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convMicroteachCaseQuantitySenateItems_Avg.AttributeName));
throw new Exception(strMsg);
}
var objvMicroteachCaseQuantitySenateItems_Avg = clsvMicroteachCaseQuantitySenateItems_AvgBL.GetObjByIdmicroteachCaseQuantitySenateCache(lngIdmicroteachCaseQuantitySenate);
if (objvMicroteachCaseQuantitySenateItems_Avg == null) return "";
return objvMicroteachCaseQuantitySenateItems_Avg[strOutFldName].ToString();
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
int intRecCount = clsvMicroteachCaseQuantitySenateItems_AvgDA.GetRecCount(strTabName);
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
int intRecCount = clsvMicroteachCaseQuantitySenateItems_AvgDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvMicroteachCaseQuantitySenateItems_AvgDA.GetRecCount();
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
int intRecCount = clsvMicroteachCaseQuantitySenateItems_AvgDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvMicroteachCaseQuantitySenateItems_AvgCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvMicroteachCaseQuantitySenateItems_AvgEN objvMicroteachCaseQuantitySenateItems_AvgCond)
{
List<clsvMicroteachCaseQuantitySenateItems_AvgEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvMicroteachCaseQuantitySenateItems_AvgEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convMicroteachCaseQuantitySenateItems_Avg.AttributeName)
{
if (objvMicroteachCaseQuantitySenateItems_AvgCond.IsUpdated(strFldName) == false) continue;
if (objvMicroteachCaseQuantitySenateItems_AvgCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvMicroteachCaseQuantitySenateItems_AvgCond[strFldName].ToString());
}
else
{
if (objvMicroteachCaseQuantitySenateItems_AvgCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvMicroteachCaseQuantitySenateItems_AvgCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvMicroteachCaseQuantitySenateItems_AvgCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvMicroteachCaseQuantitySenateItems_AvgCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvMicroteachCaseQuantitySenateItems_AvgCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvMicroteachCaseQuantitySenateItems_AvgCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvMicroteachCaseQuantitySenateItems_AvgCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvMicroteachCaseQuantitySenateItems_AvgCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvMicroteachCaseQuantitySenateItems_AvgCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvMicroteachCaseQuantitySenateItems_AvgCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvMicroteachCaseQuantitySenateItems_AvgCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvMicroteachCaseQuantitySenateItems_AvgCond[strFldName]));
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
 List<string> arrList = clsvMicroteachCaseQuantitySenateItems_AvgDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vMicroteachCaseQuantitySenateItems_AvgDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vMicroteachCaseQuantitySenateItems_AvgDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}