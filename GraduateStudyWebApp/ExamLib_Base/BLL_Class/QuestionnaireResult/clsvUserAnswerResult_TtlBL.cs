
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvUserAnswerResult_TtlBL
 表名:vUserAnswerResult_Ttl(01120023)
 * 版本:2024.11.08.1(服务器:WIN-SRV103-116)
 日期:2024/11/09 22:30:19
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:问卷结果(QuestionnaireResult)
 框架-层名:业务逻辑层(CS)(BusinessLogic,0003)
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
public static class  clsvUserAnswerResult_TtlBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngQuestionId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvUserAnswerResult_TtlEN GetObj(this K_QuestionId_vUserAnswerResult_Ttl myKey)
{
clsvUserAnswerResult_TtlEN objvUserAnswerResult_TtlEN = clsvUserAnswerResult_TtlBL.vUserAnswerResult_TtlDA.GetObjByQuestionId(myKey.Value);
return objvUserAnswerResult_TtlEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserAnswerResult_TtlEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUserAnswerResult_TtlEN SetQuestionId(this clsvUserAnswerResult_TtlEN objvUserAnswerResult_TtlEN, long lngQuestionId, string strComparisonOp="")
	{
objvUserAnswerResult_TtlEN.QuestionId = lngQuestionId; //题目Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUserAnswerResult_TtlEN.dicFldComparisonOp.ContainsKey(convUserAnswerResult_Ttl.QuestionId) == false)
{
objvUserAnswerResult_TtlEN.dicFldComparisonOp.Add(convUserAnswerResult_Ttl.QuestionId, strComparisonOp);
}
else
{
objvUserAnswerResult_TtlEN.dicFldComparisonOp[convUserAnswerResult_Ttl.QuestionId] = strComparisonOp;
}
}
return objvUserAnswerResult_TtlEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserAnswerResult_TtlEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUserAnswerResult_TtlEN SetQuestionnaireSetId(this clsvUserAnswerResult_TtlEN objvUserAnswerResult_TtlEN, string strQuestionnaireSetId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strQuestionnaireSetId, 4, convUserAnswerResult_Ttl.QuestionnaireSetId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strQuestionnaireSetId, 4, convUserAnswerResult_Ttl.QuestionnaireSetId);
}
objvUserAnswerResult_TtlEN.QuestionnaireSetId = strQuestionnaireSetId; //问卷集ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUserAnswerResult_TtlEN.dicFldComparisonOp.ContainsKey(convUserAnswerResult_Ttl.QuestionnaireSetId) == false)
{
objvUserAnswerResult_TtlEN.dicFldComparisonOp.Add(convUserAnswerResult_Ttl.QuestionnaireSetId, strComparisonOp);
}
else
{
objvUserAnswerResult_TtlEN.dicFldComparisonOp[convUserAnswerResult_Ttl.QuestionnaireSetId] = strComparisonOp;
}
}
return objvUserAnswerResult_TtlEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserAnswerResult_TtlEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUserAnswerResult_TtlEN SetAnswerId(this clsvUserAnswerResult_TtlEN objvUserAnswerResult_TtlEN, long? lngAnswerId, string strComparisonOp="")
	{
objvUserAnswerResult_TtlEN.AnswerId = lngAnswerId; //问答ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUserAnswerResult_TtlEN.dicFldComparisonOp.ContainsKey(convUserAnswerResult_Ttl.AnswerId) == false)
{
objvUserAnswerResult_TtlEN.dicFldComparisonOp.Add(convUserAnswerResult_Ttl.AnswerId, strComparisonOp);
}
else
{
objvUserAnswerResult_TtlEN.dicFldComparisonOp[convUserAnswerResult_Ttl.AnswerId] = strComparisonOp;
}
}
return objvUserAnswerResult_TtlEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserAnswerResult_TtlEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUserAnswerResult_TtlEN SetSelTimes(this clsvUserAnswerResult_TtlEN objvUserAnswerResult_TtlEN, int? intSelTimes, string strComparisonOp="")
	{
objvUserAnswerResult_TtlEN.SelTimes = intSelTimes; //选择次数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUserAnswerResult_TtlEN.dicFldComparisonOp.ContainsKey(convUserAnswerResult_Ttl.SelTimes) == false)
{
objvUserAnswerResult_TtlEN.dicFldComparisonOp.Add(convUserAnswerResult_Ttl.SelTimes, strComparisonOp);
}
else
{
objvUserAnswerResult_TtlEN.dicFldComparisonOp[convUserAnswerResult_Ttl.SelTimes] = strComparisonOp;
}
}
return objvUserAnswerResult_TtlEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvUserAnswerResult_TtlENS">源对象</param>
 /// <param name = "objvUserAnswerResult_TtlENT">目标对象</param>
 public static void CopyTo(this clsvUserAnswerResult_TtlEN objvUserAnswerResult_TtlENS, clsvUserAnswerResult_TtlEN objvUserAnswerResult_TtlENT)
{
try
{
objvUserAnswerResult_TtlENT.QuestionId = objvUserAnswerResult_TtlENS.QuestionId; //题目Id
objvUserAnswerResult_TtlENT.QuestionnaireSetId = objvUserAnswerResult_TtlENS.QuestionnaireSetId; //问卷集ID
objvUserAnswerResult_TtlENT.AnswerId = objvUserAnswerResult_TtlENS.AnswerId; //问答ID
objvUserAnswerResult_TtlENT.SelTimes = objvUserAnswerResult_TtlENS.SelTimes; //选择次数
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
 /// <param name = "objvUserAnswerResult_TtlENS">源对象</param>
 /// <returns>目标对象=>clsvUserAnswerResult_TtlEN:objvUserAnswerResult_TtlENT</returns>
 public static clsvUserAnswerResult_TtlEN CopyTo(this clsvUserAnswerResult_TtlEN objvUserAnswerResult_TtlENS)
{
try
{
 clsvUserAnswerResult_TtlEN objvUserAnswerResult_TtlENT = new clsvUserAnswerResult_TtlEN()
{
QuestionId = objvUserAnswerResult_TtlENS.QuestionId, //题目Id
QuestionnaireSetId = objvUserAnswerResult_TtlENS.QuestionnaireSetId, //问卷集ID
AnswerId = objvUserAnswerResult_TtlENS.AnswerId, //问答ID
SelTimes = objvUserAnswerResult_TtlENS.SelTimes, //选择次数
};
 return objvUserAnswerResult_TtlENT;
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
public static void CheckProperty4Condition(this clsvUserAnswerResult_TtlEN objvUserAnswerResult_TtlEN)
{
 clsvUserAnswerResult_TtlBL.vUserAnswerResult_TtlDA.CheckProperty4Condition(objvUserAnswerResult_TtlEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvUserAnswerResult_TtlEN objvUserAnswerResult_TtlCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvUserAnswerResult_TtlCond.IsUpdated(convUserAnswerResult_Ttl.QuestionId) == true)
{
string strComparisonOpQuestionId = objvUserAnswerResult_TtlCond.dicFldComparisonOp[convUserAnswerResult_Ttl.QuestionId];
strWhereCond += string.Format(" And {0} {2} {1}", convUserAnswerResult_Ttl.QuestionId, objvUserAnswerResult_TtlCond.QuestionId, strComparisonOpQuestionId);
}
if (objvUserAnswerResult_TtlCond.IsUpdated(convUserAnswerResult_Ttl.QuestionnaireSetId) == true)
{
string strComparisonOpQuestionnaireSetId = objvUserAnswerResult_TtlCond.dicFldComparisonOp[convUserAnswerResult_Ttl.QuestionnaireSetId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUserAnswerResult_Ttl.QuestionnaireSetId, objvUserAnswerResult_TtlCond.QuestionnaireSetId, strComparisonOpQuestionnaireSetId);
}
if (objvUserAnswerResult_TtlCond.IsUpdated(convUserAnswerResult_Ttl.AnswerId) == true)
{
string strComparisonOpAnswerId = objvUserAnswerResult_TtlCond.dicFldComparisonOp[convUserAnswerResult_Ttl.AnswerId];
strWhereCond += string.Format(" And {0} {2} {1}", convUserAnswerResult_Ttl.AnswerId, objvUserAnswerResult_TtlCond.AnswerId, strComparisonOpAnswerId);
}
if (objvUserAnswerResult_TtlCond.IsUpdated(convUserAnswerResult_Ttl.SelTimes) == true)
{
string strComparisonOpSelTimes = objvUserAnswerResult_TtlCond.dicFldComparisonOp[convUserAnswerResult_Ttl.SelTimes];
strWhereCond += string.Format(" And {0} {2} {1}", convUserAnswerResult_Ttl.SelTimes, objvUserAnswerResult_TtlCond.SelTimes, strComparisonOpSelTimes);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vUserAnswerResult_Ttl
{
public virtual bool UpdRelaTabDate(long lngQuestionId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v用户问卷结果_Ttl(vUserAnswerResult_Ttl)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvUserAnswerResult_TtlBL
{
public static RelatedActions_vUserAnswerResult_Ttl relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvUserAnswerResult_TtlDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvUserAnswerResult_TtlDA vUserAnswerResult_TtlDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvUserAnswerResult_TtlDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvUserAnswerResult_TtlBL()
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
if (string.IsNullOrEmpty(clsvUserAnswerResult_TtlEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvUserAnswerResult_TtlEN._ConnectString);
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
public static DataTable GetDataTable_vUserAnswerResult_Ttl(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vUserAnswerResult_TtlDA.GetDataTable_vUserAnswerResult_Ttl(strWhereCond);
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
objDT = vUserAnswerResult_TtlDA.GetDataTable(strWhereCond);
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
objDT = vUserAnswerResult_TtlDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vUserAnswerResult_TtlDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vUserAnswerResult_TtlDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vUserAnswerResult_TtlDA.GetDataTable_Top(objTopPara);
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
objDT = vUserAnswerResult_TtlDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vUserAnswerResult_TtlDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vUserAnswerResult_TtlDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrQuestionIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvUserAnswerResult_TtlEN> GetObjLstByQuestionIdLst(List<long> arrQuestionIdLst)
{
List<clsvUserAnswerResult_TtlEN> arrObjLst = new List<clsvUserAnswerResult_TtlEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrQuestionIdLst);
 string strWhereCond = string.Format("QuestionId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvUserAnswerResult_TtlEN objvUserAnswerResult_TtlEN = new clsvUserAnswerResult_TtlEN();
try
{
objvUserAnswerResult_TtlEN.QuestionId = Int32.Parse(objRow[convUserAnswerResult_Ttl.QuestionId].ToString().Trim()); //题目Id
objvUserAnswerResult_TtlEN.QuestionnaireSetId = objRow[convUserAnswerResult_Ttl.QuestionnaireSetId] == DBNull.Value ? null : objRow[convUserAnswerResult_Ttl.QuestionnaireSetId].ToString().Trim(); //问卷集ID
objvUserAnswerResult_TtlEN.AnswerId = objRow[convUserAnswerResult_Ttl.AnswerId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convUserAnswerResult_Ttl.AnswerId].ToString().Trim()); //问答ID
objvUserAnswerResult_TtlEN.SelTimes = objRow[convUserAnswerResult_Ttl.SelTimes] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convUserAnswerResult_Ttl.SelTimes].ToString().Trim()); //选择次数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvUserAnswerResult_TtlEN.QuestionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvUserAnswerResult_TtlEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrQuestionIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvUserAnswerResult_TtlEN> GetObjLstByQuestionIdLstCache(List<long> arrQuestionIdLst)
{
string strKey = string.Format("{0}", clsvUserAnswerResult_TtlEN._CurrTabName);
List<clsvUserAnswerResult_TtlEN> arrvUserAnswerResult_TtlObjLstCache = GetObjLstCache();
IEnumerable <clsvUserAnswerResult_TtlEN> arrvUserAnswerResult_TtlObjLst_Sel =
arrvUserAnswerResult_TtlObjLstCache
.Where(x => arrQuestionIdLst.Contains(x.QuestionId));
return arrvUserAnswerResult_TtlObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvUserAnswerResult_TtlEN> GetObjLst(string strWhereCond)
{
List<clsvUserAnswerResult_TtlEN> arrObjLst = new List<clsvUserAnswerResult_TtlEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvUserAnswerResult_TtlEN objvUserAnswerResult_TtlEN = new clsvUserAnswerResult_TtlEN();
try
{
objvUserAnswerResult_TtlEN.QuestionId = Int32.Parse(objRow[convUserAnswerResult_Ttl.QuestionId].ToString().Trim()); //题目Id
objvUserAnswerResult_TtlEN.QuestionnaireSetId = objRow[convUserAnswerResult_Ttl.QuestionnaireSetId] == DBNull.Value ? null : objRow[convUserAnswerResult_Ttl.QuestionnaireSetId].ToString().Trim(); //问卷集ID
objvUserAnswerResult_TtlEN.AnswerId = objRow[convUserAnswerResult_Ttl.AnswerId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convUserAnswerResult_Ttl.AnswerId].ToString().Trim()); //问答ID
objvUserAnswerResult_TtlEN.SelTimes = objRow[convUserAnswerResult_Ttl.SelTimes] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convUserAnswerResult_Ttl.SelTimes].ToString().Trim()); //选择次数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvUserAnswerResult_TtlEN.QuestionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvUserAnswerResult_TtlEN);
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
public static List<clsvUserAnswerResult_TtlEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvUserAnswerResult_TtlEN> arrObjLst = new List<clsvUserAnswerResult_TtlEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvUserAnswerResult_TtlEN objvUserAnswerResult_TtlEN = new clsvUserAnswerResult_TtlEN();
try
{
objvUserAnswerResult_TtlEN.QuestionId = Int32.Parse(objRow[convUserAnswerResult_Ttl.QuestionId].ToString().Trim()); //题目Id
objvUserAnswerResult_TtlEN.QuestionnaireSetId = objRow[convUserAnswerResult_Ttl.QuestionnaireSetId] == DBNull.Value ? null : objRow[convUserAnswerResult_Ttl.QuestionnaireSetId].ToString().Trim(); //问卷集ID
objvUserAnswerResult_TtlEN.AnswerId = objRow[convUserAnswerResult_Ttl.AnswerId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convUserAnswerResult_Ttl.AnswerId].ToString().Trim()); //问答ID
objvUserAnswerResult_TtlEN.SelTimes = objRow[convUserAnswerResult_Ttl.SelTimes] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convUserAnswerResult_Ttl.SelTimes].ToString().Trim()); //选择次数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvUserAnswerResult_TtlEN.QuestionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvUserAnswerResult_TtlEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvUserAnswerResult_TtlCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvUserAnswerResult_TtlEN> GetSubObjLstCache(clsvUserAnswerResult_TtlEN objvUserAnswerResult_TtlCond)
{
List<clsvUserAnswerResult_TtlEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvUserAnswerResult_TtlEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convUserAnswerResult_Ttl.AttributeName)
{
if (objvUserAnswerResult_TtlCond.IsUpdated(strFldName) == false) continue;
if (objvUserAnswerResult_TtlCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvUserAnswerResult_TtlCond[strFldName].ToString());
}
else
{
if (objvUserAnswerResult_TtlCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvUserAnswerResult_TtlCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvUserAnswerResult_TtlCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvUserAnswerResult_TtlCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvUserAnswerResult_TtlCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvUserAnswerResult_TtlCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvUserAnswerResult_TtlCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvUserAnswerResult_TtlCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvUserAnswerResult_TtlCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvUserAnswerResult_TtlCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvUserAnswerResult_TtlCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvUserAnswerResult_TtlCond[strFldName]));
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
public static List<clsvUserAnswerResult_TtlEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvUserAnswerResult_TtlEN> arrObjLst = new List<clsvUserAnswerResult_TtlEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvUserAnswerResult_TtlEN objvUserAnswerResult_TtlEN = new clsvUserAnswerResult_TtlEN();
try
{
objvUserAnswerResult_TtlEN.QuestionId = Int32.Parse(objRow[convUserAnswerResult_Ttl.QuestionId].ToString().Trim()); //题目Id
objvUserAnswerResult_TtlEN.QuestionnaireSetId = objRow[convUserAnswerResult_Ttl.QuestionnaireSetId] == DBNull.Value ? null : objRow[convUserAnswerResult_Ttl.QuestionnaireSetId].ToString().Trim(); //问卷集ID
objvUserAnswerResult_TtlEN.AnswerId = objRow[convUserAnswerResult_Ttl.AnswerId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convUserAnswerResult_Ttl.AnswerId].ToString().Trim()); //问答ID
objvUserAnswerResult_TtlEN.SelTimes = objRow[convUserAnswerResult_Ttl.SelTimes] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convUserAnswerResult_Ttl.SelTimes].ToString().Trim()); //选择次数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvUserAnswerResult_TtlEN.QuestionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvUserAnswerResult_TtlEN);
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
public static List<clsvUserAnswerResult_TtlEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvUserAnswerResult_TtlEN> arrObjLst = new List<clsvUserAnswerResult_TtlEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvUserAnswerResult_TtlEN objvUserAnswerResult_TtlEN = new clsvUserAnswerResult_TtlEN();
try
{
objvUserAnswerResult_TtlEN.QuestionId = Int32.Parse(objRow[convUserAnswerResult_Ttl.QuestionId].ToString().Trim()); //题目Id
objvUserAnswerResult_TtlEN.QuestionnaireSetId = objRow[convUserAnswerResult_Ttl.QuestionnaireSetId] == DBNull.Value ? null : objRow[convUserAnswerResult_Ttl.QuestionnaireSetId].ToString().Trim(); //问卷集ID
objvUserAnswerResult_TtlEN.AnswerId = objRow[convUserAnswerResult_Ttl.AnswerId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convUserAnswerResult_Ttl.AnswerId].ToString().Trim()); //问答ID
objvUserAnswerResult_TtlEN.SelTimes = objRow[convUserAnswerResult_Ttl.SelTimes] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convUserAnswerResult_Ttl.SelTimes].ToString().Trim()); //选择次数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvUserAnswerResult_TtlEN.QuestionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvUserAnswerResult_TtlEN);
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
List<clsvUserAnswerResult_TtlEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvUserAnswerResult_TtlEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvUserAnswerResult_TtlEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvUserAnswerResult_TtlEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvUserAnswerResult_TtlEN> arrObjLst = new List<clsvUserAnswerResult_TtlEN>(); 
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
	clsvUserAnswerResult_TtlEN objvUserAnswerResult_TtlEN = new clsvUserAnswerResult_TtlEN();
try
{
objvUserAnswerResult_TtlEN.QuestionId = Int32.Parse(objRow[convUserAnswerResult_Ttl.QuestionId].ToString().Trim()); //题目Id
objvUserAnswerResult_TtlEN.QuestionnaireSetId = objRow[convUserAnswerResult_Ttl.QuestionnaireSetId] == DBNull.Value ? null : objRow[convUserAnswerResult_Ttl.QuestionnaireSetId].ToString().Trim(); //问卷集ID
objvUserAnswerResult_TtlEN.AnswerId = objRow[convUserAnswerResult_Ttl.AnswerId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convUserAnswerResult_Ttl.AnswerId].ToString().Trim()); //问答ID
objvUserAnswerResult_TtlEN.SelTimes = objRow[convUserAnswerResult_Ttl.SelTimes] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convUserAnswerResult_Ttl.SelTimes].ToString().Trim()); //选择次数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvUserAnswerResult_TtlEN.QuestionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvUserAnswerResult_TtlEN);
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
public static List<clsvUserAnswerResult_TtlEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvUserAnswerResult_TtlEN> arrObjLst = new List<clsvUserAnswerResult_TtlEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvUserAnswerResult_TtlEN objvUserAnswerResult_TtlEN = new clsvUserAnswerResult_TtlEN();
try
{
objvUserAnswerResult_TtlEN.QuestionId = Int32.Parse(objRow[convUserAnswerResult_Ttl.QuestionId].ToString().Trim()); //题目Id
objvUserAnswerResult_TtlEN.QuestionnaireSetId = objRow[convUserAnswerResult_Ttl.QuestionnaireSetId] == DBNull.Value ? null : objRow[convUserAnswerResult_Ttl.QuestionnaireSetId].ToString().Trim(); //问卷集ID
objvUserAnswerResult_TtlEN.AnswerId = objRow[convUserAnswerResult_Ttl.AnswerId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convUserAnswerResult_Ttl.AnswerId].ToString().Trim()); //问答ID
objvUserAnswerResult_TtlEN.SelTimes = objRow[convUserAnswerResult_Ttl.SelTimes] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convUserAnswerResult_Ttl.SelTimes].ToString().Trim()); //选择次数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvUserAnswerResult_TtlEN.QuestionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvUserAnswerResult_TtlEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvUserAnswerResult_TtlEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvUserAnswerResult_TtlEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvUserAnswerResult_TtlEN> arrObjLst = new List<clsvUserAnswerResult_TtlEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvUserAnswerResult_TtlEN objvUserAnswerResult_TtlEN = new clsvUserAnswerResult_TtlEN();
try
{
objvUserAnswerResult_TtlEN.QuestionId = Int32.Parse(objRow[convUserAnswerResult_Ttl.QuestionId].ToString().Trim()); //题目Id
objvUserAnswerResult_TtlEN.QuestionnaireSetId = objRow[convUserAnswerResult_Ttl.QuestionnaireSetId] == DBNull.Value ? null : objRow[convUserAnswerResult_Ttl.QuestionnaireSetId].ToString().Trim(); //问卷集ID
objvUserAnswerResult_TtlEN.AnswerId = objRow[convUserAnswerResult_Ttl.AnswerId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convUserAnswerResult_Ttl.AnswerId].ToString().Trim()); //问答ID
objvUserAnswerResult_TtlEN.SelTimes = objRow[convUserAnswerResult_Ttl.SelTimes] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convUserAnswerResult_Ttl.SelTimes].ToString().Trim()); //选择次数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvUserAnswerResult_TtlEN.QuestionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvUserAnswerResult_TtlEN);
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
public static List<clsvUserAnswerResult_TtlEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvUserAnswerResult_TtlEN> arrObjLst = new List<clsvUserAnswerResult_TtlEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvUserAnswerResult_TtlEN objvUserAnswerResult_TtlEN = new clsvUserAnswerResult_TtlEN();
try
{
objvUserAnswerResult_TtlEN.QuestionId = Int32.Parse(objRow[convUserAnswerResult_Ttl.QuestionId].ToString().Trim()); //题目Id
objvUserAnswerResult_TtlEN.QuestionnaireSetId = objRow[convUserAnswerResult_Ttl.QuestionnaireSetId] == DBNull.Value ? null : objRow[convUserAnswerResult_Ttl.QuestionnaireSetId].ToString().Trim(); //问卷集ID
objvUserAnswerResult_TtlEN.AnswerId = objRow[convUserAnswerResult_Ttl.AnswerId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convUserAnswerResult_Ttl.AnswerId].ToString().Trim()); //问答ID
objvUserAnswerResult_TtlEN.SelTimes = objRow[convUserAnswerResult_Ttl.SelTimes] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convUserAnswerResult_Ttl.SelTimes].ToString().Trim()); //选择次数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvUserAnswerResult_TtlEN.QuestionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvUserAnswerResult_TtlEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvUserAnswerResult_TtlEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvUserAnswerResult_TtlEN> arrObjLst = new List<clsvUserAnswerResult_TtlEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvUserAnswerResult_TtlEN objvUserAnswerResult_TtlEN = new clsvUserAnswerResult_TtlEN();
try
{
objvUserAnswerResult_TtlEN.QuestionId = Int32.Parse(objRow[convUserAnswerResult_Ttl.QuestionId].ToString().Trim()); //题目Id
objvUserAnswerResult_TtlEN.QuestionnaireSetId = objRow[convUserAnswerResult_Ttl.QuestionnaireSetId] == DBNull.Value ? null : objRow[convUserAnswerResult_Ttl.QuestionnaireSetId].ToString().Trim(); //问卷集ID
objvUserAnswerResult_TtlEN.AnswerId = objRow[convUserAnswerResult_Ttl.AnswerId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convUserAnswerResult_Ttl.AnswerId].ToString().Trim()); //问答ID
objvUserAnswerResult_TtlEN.SelTimes = objRow[convUserAnswerResult_Ttl.SelTimes] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convUserAnswerResult_Ttl.SelTimes].ToString().Trim()); //选择次数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvUserAnswerResult_TtlEN.QuestionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvUserAnswerResult_TtlEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvUserAnswerResult_TtlEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvUserAnswerResult_Ttl(ref clsvUserAnswerResult_TtlEN objvUserAnswerResult_TtlEN)
{
bool bolResult = vUserAnswerResult_TtlDA.GetvUserAnswerResult_Ttl(ref objvUserAnswerResult_TtlEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngQuestionId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvUserAnswerResult_TtlEN GetObjByQuestionId(long lngQuestionId)
{
clsvUserAnswerResult_TtlEN objvUserAnswerResult_TtlEN = vUserAnswerResult_TtlDA.GetObjByQuestionId(lngQuestionId);
return objvUserAnswerResult_TtlEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvUserAnswerResult_TtlEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvUserAnswerResult_TtlEN objvUserAnswerResult_TtlEN = vUserAnswerResult_TtlDA.GetFirstObj(strWhereCond);
 return objvUserAnswerResult_TtlEN;
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
public static clsvUserAnswerResult_TtlEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvUserAnswerResult_TtlEN objvUserAnswerResult_TtlEN = vUserAnswerResult_TtlDA.GetObjByDataRow(objRow);
 return objvUserAnswerResult_TtlEN;
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
public static clsvUserAnswerResult_TtlEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvUserAnswerResult_TtlEN objvUserAnswerResult_TtlEN = vUserAnswerResult_TtlDA.GetObjByDataRow(objRow);
 return objvUserAnswerResult_TtlEN;
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
 /// <param name = "lngQuestionId">所给的关键字</param>
 /// <param name = "lstvUserAnswerResult_TtlObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvUserAnswerResult_TtlEN GetObjByQuestionIdFromList(long lngQuestionId, List<clsvUserAnswerResult_TtlEN> lstvUserAnswerResult_TtlObjLst)
{
foreach (clsvUserAnswerResult_TtlEN objvUserAnswerResult_TtlEN in lstvUserAnswerResult_TtlObjLst)
{
if (objvUserAnswerResult_TtlEN.QuestionId == lngQuestionId)
{
return objvUserAnswerResult_TtlEN;
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
 long lngQuestionId;
 try
 {
 lngQuestionId = new clsvUserAnswerResult_TtlDA().GetFirstID(strWhereCond);
 return lngQuestionId;
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
 arrList = vUserAnswerResult_TtlDA.GetID(strWhereCond);
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
bool bolIsExist = vUserAnswerResult_TtlDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "lngQuestionId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(long lngQuestionId)
{
//检测记录是否存在
bool bolIsExist = vUserAnswerResult_TtlDA.IsExist(lngQuestionId);
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
 bolIsExist = clsvUserAnswerResult_TtlDA.IsExistTable();
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
 bolIsExist = vUserAnswerResult_TtlDA.IsExistTable(strTabName);
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
 /// <param name = "objvUserAnswerResult_TtlENS">源对象</param>
 /// <param name = "objvUserAnswerResult_TtlENT">目标对象</param>
 public static void CopyTo(clsvUserAnswerResult_TtlEN objvUserAnswerResult_TtlENS, clsvUserAnswerResult_TtlEN objvUserAnswerResult_TtlENT)
{
try
{
objvUserAnswerResult_TtlENT.QuestionId = objvUserAnswerResult_TtlENS.QuestionId; //题目Id
objvUserAnswerResult_TtlENT.QuestionnaireSetId = objvUserAnswerResult_TtlENS.QuestionnaireSetId; //问卷集ID
objvUserAnswerResult_TtlENT.AnswerId = objvUserAnswerResult_TtlENS.AnswerId; //问答ID
objvUserAnswerResult_TtlENT.SelTimes = objvUserAnswerResult_TtlENS.SelTimes; //选择次数
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
 /// <param name = "objvUserAnswerResult_TtlEN">源简化对象</param>
 public static void SetUpdFlag(clsvUserAnswerResult_TtlEN objvUserAnswerResult_TtlEN)
{
try
{
objvUserAnswerResult_TtlEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvUserAnswerResult_TtlEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convUserAnswerResult_Ttl.QuestionId, new clsStrCompareIgnoreCase())  ==  true)
{
objvUserAnswerResult_TtlEN.QuestionId = objvUserAnswerResult_TtlEN.QuestionId; //题目Id
}
if (arrFldSet.Contains(convUserAnswerResult_Ttl.QuestionnaireSetId, new clsStrCompareIgnoreCase())  ==  true)
{
objvUserAnswerResult_TtlEN.QuestionnaireSetId = objvUserAnswerResult_TtlEN.QuestionnaireSetId == "[null]" ? null :  objvUserAnswerResult_TtlEN.QuestionnaireSetId; //问卷集ID
}
if (arrFldSet.Contains(convUserAnswerResult_Ttl.AnswerId, new clsStrCompareIgnoreCase())  ==  true)
{
objvUserAnswerResult_TtlEN.AnswerId = objvUserAnswerResult_TtlEN.AnswerId; //问答ID
}
if (arrFldSet.Contains(convUserAnswerResult_Ttl.SelTimes, new clsStrCompareIgnoreCase())  ==  true)
{
objvUserAnswerResult_TtlEN.SelTimes = objvUserAnswerResult_TtlEN.SelTimes; //选择次数
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
 /// <param name = "objvUserAnswerResult_TtlEN">源简化对象</param>
 public static void AccessFldValueNull(clsvUserAnswerResult_TtlEN objvUserAnswerResult_TtlEN)
{
try
{
if (objvUserAnswerResult_TtlEN.QuestionnaireSetId == "[null]") objvUserAnswerResult_TtlEN.QuestionnaireSetId = null; //问卷集ID
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
public static void CheckProperty4Condition(clsvUserAnswerResult_TtlEN objvUserAnswerResult_TtlEN)
{
 vUserAnswerResult_TtlDA.CheckProperty4Condition(objvUserAnswerResult_TtlEN);
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
if (clsUserAnswerResultBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsUserAnswerResultBL没有刷新缓存机制(clsUserAnswerResultBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by QuestionId");
//if (arrvUserAnswerResult_TtlObjLstCache == null)
//{
//arrvUserAnswerResult_TtlObjLstCache = vUserAnswerResult_TtlDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngQuestionId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvUserAnswerResult_TtlEN GetObjByQuestionIdCache(long lngQuestionId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvUserAnswerResult_TtlEN._CurrTabName);
List<clsvUserAnswerResult_TtlEN> arrvUserAnswerResult_TtlObjLstCache = GetObjLstCache();
IEnumerable <clsvUserAnswerResult_TtlEN> arrvUserAnswerResult_TtlObjLst_Sel =
arrvUserAnswerResult_TtlObjLstCache
.Where(x=> x.QuestionId == lngQuestionId 
);
if (arrvUserAnswerResult_TtlObjLst_Sel.Count() == 0)
{
   clsvUserAnswerResult_TtlEN obj = clsvUserAnswerResult_TtlBL.GetObjByQuestionId(lngQuestionId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvUserAnswerResult_TtlObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvUserAnswerResult_TtlEN> GetAllvUserAnswerResult_TtlObjLstCache()
{
//获取缓存中的对象列表
List<clsvUserAnswerResult_TtlEN> arrvUserAnswerResult_TtlObjLstCache = GetObjLstCache(); 
return arrvUserAnswerResult_TtlObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvUserAnswerResult_TtlEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvUserAnswerResult_TtlEN._CurrTabName);
List<clsvUserAnswerResult_TtlEN> arrvUserAnswerResult_TtlObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvUserAnswerResult_TtlObjLstCache;
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
string strKey = string.Format("{0}", clsvUserAnswerResult_TtlEN._CurrTabName);
CacheHelper.Remove(strKey);
clsvUserAnswerResult_TtlEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
/// <summary>
/// 获取最新的缓存刷新时间
/// </summary>
/// <returns>最新的缓存刷新时间，字符串型</returns>
public static string GetLastRefreshTime()
{
if (clsvUserAnswerResult_TtlEN._RefreshTimeLst.Count == 0) return "";
return clsvUserAnswerResult_TtlEN._RefreshTimeLst[clsvUserAnswerResult_TtlEN._RefreshTimeLst.Count - 1];
}


 #endregion 缓存操作


 #region 检查唯一性


 #endregion 检查唯一性

 /// <summary>
 /// 映射函数。根据表映射把输入字段值,映射成输出字段值
 /// 作者:pyf
 /// 日期:2024-11-09
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_func)
 /// </summary>
 /// <param name = "strInFldName">输入字段名</param>
 /// <param name = "strOutFldName">输出字段名</param>
 /// <param name = "strInValue">输入字段值</param>
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, long lngQuestionId)
{
if (strInFldName != convUserAnswerResult_Ttl.QuestionId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convUserAnswerResult_Ttl.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convUserAnswerResult_Ttl.AttributeName));
throw new Exception(strMsg);
}
var objvUserAnswerResult_Ttl = clsvUserAnswerResult_TtlBL.GetObjByQuestionIdCache(lngQuestionId);
if (objvUserAnswerResult_Ttl == null) return "";
return objvUserAnswerResult_Ttl[strOutFldName].ToString();
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
int intRecCount = clsvUserAnswerResult_TtlDA.GetRecCount(strTabName);
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
int intRecCount = clsvUserAnswerResult_TtlDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvUserAnswerResult_TtlDA.GetRecCount();
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
int intRecCount = clsvUserAnswerResult_TtlDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvUserAnswerResult_TtlCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvUserAnswerResult_TtlEN objvUserAnswerResult_TtlCond)
{
List<clsvUserAnswerResult_TtlEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvUserAnswerResult_TtlEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convUserAnswerResult_Ttl.AttributeName)
{
if (objvUserAnswerResult_TtlCond.IsUpdated(strFldName) == false) continue;
if (objvUserAnswerResult_TtlCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvUserAnswerResult_TtlCond[strFldName].ToString());
}
else
{
if (objvUserAnswerResult_TtlCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvUserAnswerResult_TtlCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvUserAnswerResult_TtlCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvUserAnswerResult_TtlCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvUserAnswerResult_TtlCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvUserAnswerResult_TtlCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvUserAnswerResult_TtlCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvUserAnswerResult_TtlCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvUserAnswerResult_TtlCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvUserAnswerResult_TtlCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvUserAnswerResult_TtlCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvUserAnswerResult_TtlCond[strFldName]));
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
 List<string> arrList = clsvUserAnswerResult_TtlDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vUserAnswerResult_TtlDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vUserAnswerResult_TtlDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}