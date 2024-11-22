
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvQuestionNumByKnowledgeIdBL
 表名:vQuestionNumByKnowledgeId(01120937)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 13:06:39
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:知识点相关(Knowledges)
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
public static class  clsvQuestionNumByKnowledgeIdBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strCourseKnowledgeId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvQuestionNumByKnowledgeIdEN GetObj(this K_CourseKnowledgeId_vQuestionNumByKnowledgeId myKey)
{
clsvQuestionNumByKnowledgeIdEN objvQuestionNumByKnowledgeIdEN = clsvQuestionNumByKnowledgeIdBL.vQuestionNumByKnowledgeIdDA.GetObjByCourseKnowledgeId(myKey.Value);
return objvQuestionNumByKnowledgeIdEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionNumByKnowledgeIdEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQuestionNumByKnowledgeIdEN SetCourseKnowledgeId(this clsvQuestionNumByKnowledgeIdEN objvQuestionNumByKnowledgeIdEN, string strCourseKnowledgeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseKnowledgeId, 8, convQuestionNumByKnowledgeId.CourseKnowledgeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCourseKnowledgeId, 8, convQuestionNumByKnowledgeId.CourseKnowledgeId);
}
objvQuestionNumByKnowledgeIdEN.CourseKnowledgeId = strCourseKnowledgeId; //知识点Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionNumByKnowledgeIdEN.dicFldComparisonOp.ContainsKey(convQuestionNumByKnowledgeId.CourseKnowledgeId) == false)
{
objvQuestionNumByKnowledgeIdEN.dicFldComparisonOp.Add(convQuestionNumByKnowledgeId.CourseKnowledgeId, strComparisonOp);
}
else
{
objvQuestionNumByKnowledgeIdEN.dicFldComparisonOp[convQuestionNumByKnowledgeId.CourseKnowledgeId] = strComparisonOp;
}
}
return objvQuestionNumByKnowledgeIdEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionNumByKnowledgeIdEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQuestionNumByKnowledgeIdEN SetCourseId(this clsvQuestionNumByKnowledgeIdEN objvQuestionNumByKnowledgeIdEN, string strCourseId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseId, 8, convQuestionNumByKnowledgeId.CourseId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCourseId, 8, convQuestionNumByKnowledgeId.CourseId);
}
objvQuestionNumByKnowledgeIdEN.CourseId = strCourseId; //课程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionNumByKnowledgeIdEN.dicFldComparisonOp.ContainsKey(convQuestionNumByKnowledgeId.CourseId) == false)
{
objvQuestionNumByKnowledgeIdEN.dicFldComparisonOp.Add(convQuestionNumByKnowledgeId.CourseId, strComparisonOp);
}
else
{
objvQuestionNumByKnowledgeIdEN.dicFldComparisonOp[convQuestionNumByKnowledgeId.CourseId] = strComparisonOp;
}
}
return objvQuestionNumByKnowledgeIdEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionNumByKnowledgeIdEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQuestionNumByKnowledgeIdEN SetQuestionNum(this clsvQuestionNumByKnowledgeIdEN objvQuestionNumByKnowledgeIdEN, int? intQuestionNum, string strComparisonOp="")
	{
objvQuestionNumByKnowledgeIdEN.QuestionNum = intQuestionNum; //题目数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionNumByKnowledgeIdEN.dicFldComparisonOp.ContainsKey(convQuestionNumByKnowledgeId.QuestionNum) == false)
{
objvQuestionNumByKnowledgeIdEN.dicFldComparisonOp.Add(convQuestionNumByKnowledgeId.QuestionNum, strComparisonOp);
}
else
{
objvQuestionNumByKnowledgeIdEN.dicFldComparisonOp[convQuestionNumByKnowledgeId.QuestionNum] = strComparisonOp;
}
}
return objvQuestionNumByKnowledgeIdEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvQuestionNumByKnowledgeIdENS">源对象</param>
 /// <param name = "objvQuestionNumByKnowledgeIdENT">目标对象</param>
 public static void CopyTo(this clsvQuestionNumByKnowledgeIdEN objvQuestionNumByKnowledgeIdENS, clsvQuestionNumByKnowledgeIdEN objvQuestionNumByKnowledgeIdENT)
{
try
{
objvQuestionNumByKnowledgeIdENT.CourseKnowledgeId = objvQuestionNumByKnowledgeIdENS.CourseKnowledgeId; //知识点Id
objvQuestionNumByKnowledgeIdENT.CourseId = objvQuestionNumByKnowledgeIdENS.CourseId; //课程Id
objvQuestionNumByKnowledgeIdENT.QuestionNum = objvQuestionNumByKnowledgeIdENS.QuestionNum; //题目数
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
 /// <param name = "objvQuestionNumByKnowledgeIdENS">源对象</param>
 /// <returns>目标对象=>clsvQuestionNumByKnowledgeIdEN:objvQuestionNumByKnowledgeIdENT</returns>
 public static clsvQuestionNumByKnowledgeIdEN CopyTo(this clsvQuestionNumByKnowledgeIdEN objvQuestionNumByKnowledgeIdENS)
{
try
{
 clsvQuestionNumByKnowledgeIdEN objvQuestionNumByKnowledgeIdENT = new clsvQuestionNumByKnowledgeIdEN()
{
CourseKnowledgeId = objvQuestionNumByKnowledgeIdENS.CourseKnowledgeId, //知识点Id
CourseId = objvQuestionNumByKnowledgeIdENS.CourseId, //课程Id
QuestionNum = objvQuestionNumByKnowledgeIdENS.QuestionNum, //题目数
};
 return objvQuestionNumByKnowledgeIdENT;
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
public static void CheckProperty4Condition(this clsvQuestionNumByKnowledgeIdEN objvQuestionNumByKnowledgeIdEN)
{
 clsvQuestionNumByKnowledgeIdBL.vQuestionNumByKnowledgeIdDA.CheckProperty4Condition(objvQuestionNumByKnowledgeIdEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvQuestionNumByKnowledgeIdEN objvQuestionNumByKnowledgeIdCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvQuestionNumByKnowledgeIdCond.IsUpdated(convQuestionNumByKnowledgeId.CourseKnowledgeId) == true)
{
string strComparisonOpCourseKnowledgeId = objvQuestionNumByKnowledgeIdCond.dicFldComparisonOp[convQuestionNumByKnowledgeId.CourseKnowledgeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionNumByKnowledgeId.CourseKnowledgeId, objvQuestionNumByKnowledgeIdCond.CourseKnowledgeId, strComparisonOpCourseKnowledgeId);
}
if (objvQuestionNumByKnowledgeIdCond.IsUpdated(convQuestionNumByKnowledgeId.CourseId) == true)
{
string strComparisonOpCourseId = objvQuestionNumByKnowledgeIdCond.dicFldComparisonOp[convQuestionNumByKnowledgeId.CourseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionNumByKnowledgeId.CourseId, objvQuestionNumByKnowledgeIdCond.CourseId, strComparisonOpCourseId);
}
if (objvQuestionNumByKnowledgeIdCond.IsUpdated(convQuestionNumByKnowledgeId.QuestionNum) == true)
{
string strComparisonOpQuestionNum = objvQuestionNumByKnowledgeIdCond.dicFldComparisonOp[convQuestionNumByKnowledgeId.QuestionNum];
strWhereCond += string.Format(" And {0} {2} {1}", convQuestionNumByKnowledgeId.QuestionNum, objvQuestionNumByKnowledgeIdCond.QuestionNum, strComparisonOpQuestionNum);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vQuestionNumByKnowledgeId
{
public virtual bool UpdRelaTabDate(string strCourseKnowledgeId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// vQuestionNumByKnowledgeId(vQuestionNumByKnowledgeId)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvQuestionNumByKnowledgeIdBL
{
public static RelatedActions_vQuestionNumByKnowledgeId relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvQuestionNumByKnowledgeIdDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvQuestionNumByKnowledgeIdDA vQuestionNumByKnowledgeIdDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvQuestionNumByKnowledgeIdDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvQuestionNumByKnowledgeIdBL()
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
if (string.IsNullOrEmpty(clsvQuestionNumByKnowledgeIdEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvQuestionNumByKnowledgeIdEN._ConnectString);
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
public static DataTable GetDataTable_vQuestionNumByKnowledgeId(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vQuestionNumByKnowledgeIdDA.GetDataTable_vQuestionNumByKnowledgeId(strWhereCond);
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
objDT = vQuestionNumByKnowledgeIdDA.GetDataTable(strWhereCond);
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
objDT = vQuestionNumByKnowledgeIdDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vQuestionNumByKnowledgeIdDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vQuestionNumByKnowledgeIdDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vQuestionNumByKnowledgeIdDA.GetDataTable_Top(objTopPara);
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
objDT = vQuestionNumByKnowledgeIdDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vQuestionNumByKnowledgeIdDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vQuestionNumByKnowledgeIdDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrCourseKnowledgeIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvQuestionNumByKnowledgeIdEN> GetObjLstByCourseKnowledgeIdLst(List<string> arrCourseKnowledgeIdLst)
{
List<clsvQuestionNumByKnowledgeIdEN> arrObjLst = new List<clsvQuestionNumByKnowledgeIdEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrCourseKnowledgeIdLst, true);
 string strWhereCond = string.Format("CourseKnowledgeId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQuestionNumByKnowledgeIdEN objvQuestionNumByKnowledgeIdEN = new clsvQuestionNumByKnowledgeIdEN();
try
{
objvQuestionNumByKnowledgeIdEN.CourseKnowledgeId = objRow[convQuestionNumByKnowledgeId.CourseKnowledgeId].ToString().Trim(); //知识点Id
objvQuestionNumByKnowledgeIdEN.CourseId = objRow[convQuestionNumByKnowledgeId.CourseId] == DBNull.Value ? null : objRow[convQuestionNumByKnowledgeId.CourseId].ToString().Trim(); //课程Id
objvQuestionNumByKnowledgeIdEN.QuestionNum = objRow[convQuestionNumByKnowledgeId.QuestionNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionNumByKnowledgeId.QuestionNum].ToString().Trim()); //题目数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQuestionNumByKnowledgeIdEN.CourseKnowledgeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQuestionNumByKnowledgeIdEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrCourseKnowledgeIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvQuestionNumByKnowledgeIdEN> GetObjLstByCourseKnowledgeIdLstCache(List<string> arrCourseKnowledgeIdLst)
{
string strKey = string.Format("{0}", clsvQuestionNumByKnowledgeIdEN._CurrTabName);
List<clsvQuestionNumByKnowledgeIdEN> arrvQuestionNumByKnowledgeIdObjLstCache = GetObjLstCache();
IEnumerable <clsvQuestionNumByKnowledgeIdEN> arrvQuestionNumByKnowledgeIdObjLst_Sel =
arrvQuestionNumByKnowledgeIdObjLstCache
.Where(x => arrCourseKnowledgeIdLst.Contains(x.CourseKnowledgeId));
return arrvQuestionNumByKnowledgeIdObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQuestionNumByKnowledgeIdEN> GetObjLst(string strWhereCond)
{
List<clsvQuestionNumByKnowledgeIdEN> arrObjLst = new List<clsvQuestionNumByKnowledgeIdEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQuestionNumByKnowledgeIdEN objvQuestionNumByKnowledgeIdEN = new clsvQuestionNumByKnowledgeIdEN();
try
{
objvQuestionNumByKnowledgeIdEN.CourseKnowledgeId = objRow[convQuestionNumByKnowledgeId.CourseKnowledgeId].ToString().Trim(); //知识点Id
objvQuestionNumByKnowledgeIdEN.CourseId = objRow[convQuestionNumByKnowledgeId.CourseId] == DBNull.Value ? null : objRow[convQuestionNumByKnowledgeId.CourseId].ToString().Trim(); //课程Id
objvQuestionNumByKnowledgeIdEN.QuestionNum = objRow[convQuestionNumByKnowledgeId.QuestionNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionNumByKnowledgeId.QuestionNum].ToString().Trim()); //题目数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQuestionNumByKnowledgeIdEN.CourseKnowledgeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQuestionNumByKnowledgeIdEN);
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
public static List<clsvQuestionNumByKnowledgeIdEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvQuestionNumByKnowledgeIdEN> arrObjLst = new List<clsvQuestionNumByKnowledgeIdEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQuestionNumByKnowledgeIdEN objvQuestionNumByKnowledgeIdEN = new clsvQuestionNumByKnowledgeIdEN();
try
{
objvQuestionNumByKnowledgeIdEN.CourseKnowledgeId = objRow[convQuestionNumByKnowledgeId.CourseKnowledgeId].ToString().Trim(); //知识点Id
objvQuestionNumByKnowledgeIdEN.CourseId = objRow[convQuestionNumByKnowledgeId.CourseId] == DBNull.Value ? null : objRow[convQuestionNumByKnowledgeId.CourseId].ToString().Trim(); //课程Id
objvQuestionNumByKnowledgeIdEN.QuestionNum = objRow[convQuestionNumByKnowledgeId.QuestionNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionNumByKnowledgeId.QuestionNum].ToString().Trim()); //题目数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQuestionNumByKnowledgeIdEN.CourseKnowledgeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQuestionNumByKnowledgeIdEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvQuestionNumByKnowledgeIdCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvQuestionNumByKnowledgeIdEN> GetSubObjLstCache(clsvQuestionNumByKnowledgeIdEN objvQuestionNumByKnowledgeIdCond)
{
List<clsvQuestionNumByKnowledgeIdEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvQuestionNumByKnowledgeIdEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convQuestionNumByKnowledgeId.AttributeName)
{
if (objvQuestionNumByKnowledgeIdCond.IsUpdated(strFldName) == false) continue;
if (objvQuestionNumByKnowledgeIdCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQuestionNumByKnowledgeIdCond[strFldName].ToString());
}
else
{
if (objvQuestionNumByKnowledgeIdCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvQuestionNumByKnowledgeIdCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQuestionNumByKnowledgeIdCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvQuestionNumByKnowledgeIdCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvQuestionNumByKnowledgeIdCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvQuestionNumByKnowledgeIdCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvQuestionNumByKnowledgeIdCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvQuestionNumByKnowledgeIdCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvQuestionNumByKnowledgeIdCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvQuestionNumByKnowledgeIdCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvQuestionNumByKnowledgeIdCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvQuestionNumByKnowledgeIdCond[strFldName]));
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
public static List<clsvQuestionNumByKnowledgeIdEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvQuestionNumByKnowledgeIdEN> arrObjLst = new List<clsvQuestionNumByKnowledgeIdEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQuestionNumByKnowledgeIdEN objvQuestionNumByKnowledgeIdEN = new clsvQuestionNumByKnowledgeIdEN();
try
{
objvQuestionNumByKnowledgeIdEN.CourseKnowledgeId = objRow[convQuestionNumByKnowledgeId.CourseKnowledgeId].ToString().Trim(); //知识点Id
objvQuestionNumByKnowledgeIdEN.CourseId = objRow[convQuestionNumByKnowledgeId.CourseId] == DBNull.Value ? null : objRow[convQuestionNumByKnowledgeId.CourseId].ToString().Trim(); //课程Id
objvQuestionNumByKnowledgeIdEN.QuestionNum = objRow[convQuestionNumByKnowledgeId.QuestionNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionNumByKnowledgeId.QuestionNum].ToString().Trim()); //题目数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQuestionNumByKnowledgeIdEN.CourseKnowledgeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQuestionNumByKnowledgeIdEN);
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
public static List<clsvQuestionNumByKnowledgeIdEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvQuestionNumByKnowledgeIdEN> arrObjLst = new List<clsvQuestionNumByKnowledgeIdEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQuestionNumByKnowledgeIdEN objvQuestionNumByKnowledgeIdEN = new clsvQuestionNumByKnowledgeIdEN();
try
{
objvQuestionNumByKnowledgeIdEN.CourseKnowledgeId = objRow[convQuestionNumByKnowledgeId.CourseKnowledgeId].ToString().Trim(); //知识点Id
objvQuestionNumByKnowledgeIdEN.CourseId = objRow[convQuestionNumByKnowledgeId.CourseId] == DBNull.Value ? null : objRow[convQuestionNumByKnowledgeId.CourseId].ToString().Trim(); //课程Id
objvQuestionNumByKnowledgeIdEN.QuestionNum = objRow[convQuestionNumByKnowledgeId.QuestionNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionNumByKnowledgeId.QuestionNum].ToString().Trim()); //题目数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQuestionNumByKnowledgeIdEN.CourseKnowledgeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQuestionNumByKnowledgeIdEN);
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
List<clsvQuestionNumByKnowledgeIdEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvQuestionNumByKnowledgeIdEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQuestionNumByKnowledgeIdEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvQuestionNumByKnowledgeIdEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvQuestionNumByKnowledgeIdEN> arrObjLst = new List<clsvQuestionNumByKnowledgeIdEN>(); 
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
	clsvQuestionNumByKnowledgeIdEN objvQuestionNumByKnowledgeIdEN = new clsvQuestionNumByKnowledgeIdEN();
try
{
objvQuestionNumByKnowledgeIdEN.CourseKnowledgeId = objRow[convQuestionNumByKnowledgeId.CourseKnowledgeId].ToString().Trim(); //知识点Id
objvQuestionNumByKnowledgeIdEN.CourseId = objRow[convQuestionNumByKnowledgeId.CourseId] == DBNull.Value ? null : objRow[convQuestionNumByKnowledgeId.CourseId].ToString().Trim(); //课程Id
objvQuestionNumByKnowledgeIdEN.QuestionNum = objRow[convQuestionNumByKnowledgeId.QuestionNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionNumByKnowledgeId.QuestionNum].ToString().Trim()); //题目数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQuestionNumByKnowledgeIdEN.CourseKnowledgeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQuestionNumByKnowledgeIdEN);
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
public static List<clsvQuestionNumByKnowledgeIdEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvQuestionNumByKnowledgeIdEN> arrObjLst = new List<clsvQuestionNumByKnowledgeIdEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQuestionNumByKnowledgeIdEN objvQuestionNumByKnowledgeIdEN = new clsvQuestionNumByKnowledgeIdEN();
try
{
objvQuestionNumByKnowledgeIdEN.CourseKnowledgeId = objRow[convQuestionNumByKnowledgeId.CourseKnowledgeId].ToString().Trim(); //知识点Id
objvQuestionNumByKnowledgeIdEN.CourseId = objRow[convQuestionNumByKnowledgeId.CourseId] == DBNull.Value ? null : objRow[convQuestionNumByKnowledgeId.CourseId].ToString().Trim(); //课程Id
objvQuestionNumByKnowledgeIdEN.QuestionNum = objRow[convQuestionNumByKnowledgeId.QuestionNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionNumByKnowledgeId.QuestionNum].ToString().Trim()); //题目数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQuestionNumByKnowledgeIdEN.CourseKnowledgeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQuestionNumByKnowledgeIdEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvQuestionNumByKnowledgeIdEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvQuestionNumByKnowledgeIdEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvQuestionNumByKnowledgeIdEN> arrObjLst = new List<clsvQuestionNumByKnowledgeIdEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQuestionNumByKnowledgeIdEN objvQuestionNumByKnowledgeIdEN = new clsvQuestionNumByKnowledgeIdEN();
try
{
objvQuestionNumByKnowledgeIdEN.CourseKnowledgeId = objRow[convQuestionNumByKnowledgeId.CourseKnowledgeId].ToString().Trim(); //知识点Id
objvQuestionNumByKnowledgeIdEN.CourseId = objRow[convQuestionNumByKnowledgeId.CourseId] == DBNull.Value ? null : objRow[convQuestionNumByKnowledgeId.CourseId].ToString().Trim(); //课程Id
objvQuestionNumByKnowledgeIdEN.QuestionNum = objRow[convQuestionNumByKnowledgeId.QuestionNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionNumByKnowledgeId.QuestionNum].ToString().Trim()); //题目数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQuestionNumByKnowledgeIdEN.CourseKnowledgeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQuestionNumByKnowledgeIdEN);
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
public static List<clsvQuestionNumByKnowledgeIdEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvQuestionNumByKnowledgeIdEN> arrObjLst = new List<clsvQuestionNumByKnowledgeIdEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQuestionNumByKnowledgeIdEN objvQuestionNumByKnowledgeIdEN = new clsvQuestionNumByKnowledgeIdEN();
try
{
objvQuestionNumByKnowledgeIdEN.CourseKnowledgeId = objRow[convQuestionNumByKnowledgeId.CourseKnowledgeId].ToString().Trim(); //知识点Id
objvQuestionNumByKnowledgeIdEN.CourseId = objRow[convQuestionNumByKnowledgeId.CourseId] == DBNull.Value ? null : objRow[convQuestionNumByKnowledgeId.CourseId].ToString().Trim(); //课程Id
objvQuestionNumByKnowledgeIdEN.QuestionNum = objRow[convQuestionNumByKnowledgeId.QuestionNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionNumByKnowledgeId.QuestionNum].ToString().Trim()); //题目数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQuestionNumByKnowledgeIdEN.CourseKnowledgeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQuestionNumByKnowledgeIdEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQuestionNumByKnowledgeIdEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvQuestionNumByKnowledgeIdEN> arrObjLst = new List<clsvQuestionNumByKnowledgeIdEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQuestionNumByKnowledgeIdEN objvQuestionNumByKnowledgeIdEN = new clsvQuestionNumByKnowledgeIdEN();
try
{
objvQuestionNumByKnowledgeIdEN.CourseKnowledgeId = objRow[convQuestionNumByKnowledgeId.CourseKnowledgeId].ToString().Trim(); //知识点Id
objvQuestionNumByKnowledgeIdEN.CourseId = objRow[convQuestionNumByKnowledgeId.CourseId] == DBNull.Value ? null : objRow[convQuestionNumByKnowledgeId.CourseId].ToString().Trim(); //课程Id
objvQuestionNumByKnowledgeIdEN.QuestionNum = objRow[convQuestionNumByKnowledgeId.QuestionNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionNumByKnowledgeId.QuestionNum].ToString().Trim()); //题目数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQuestionNumByKnowledgeIdEN.CourseKnowledgeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQuestionNumByKnowledgeIdEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvQuestionNumByKnowledgeIdEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvQuestionNumByKnowledgeId(ref clsvQuestionNumByKnowledgeIdEN objvQuestionNumByKnowledgeIdEN)
{
bool bolResult = vQuestionNumByKnowledgeIdDA.GetvQuestionNumByKnowledgeId(ref objvQuestionNumByKnowledgeIdEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strCourseKnowledgeId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvQuestionNumByKnowledgeIdEN GetObjByCourseKnowledgeId(string strCourseKnowledgeId)
{
if (strCourseKnowledgeId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strCourseKnowledgeId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strCourseKnowledgeId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strCourseKnowledgeId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsvQuestionNumByKnowledgeIdEN objvQuestionNumByKnowledgeIdEN = vQuestionNumByKnowledgeIdDA.GetObjByCourseKnowledgeId(strCourseKnowledgeId);
return objvQuestionNumByKnowledgeIdEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvQuestionNumByKnowledgeIdEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvQuestionNumByKnowledgeIdEN objvQuestionNumByKnowledgeIdEN = vQuestionNumByKnowledgeIdDA.GetFirstObj(strWhereCond);
 return objvQuestionNumByKnowledgeIdEN;
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
public static clsvQuestionNumByKnowledgeIdEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvQuestionNumByKnowledgeIdEN objvQuestionNumByKnowledgeIdEN = vQuestionNumByKnowledgeIdDA.GetObjByDataRow(objRow);
 return objvQuestionNumByKnowledgeIdEN;
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
public static clsvQuestionNumByKnowledgeIdEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvQuestionNumByKnowledgeIdEN objvQuestionNumByKnowledgeIdEN = vQuestionNumByKnowledgeIdDA.GetObjByDataRow(objRow);
 return objvQuestionNumByKnowledgeIdEN;
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
 /// <param name = "strCourseKnowledgeId">所给的关键字</param>
 /// <param name = "lstvQuestionNumByKnowledgeIdObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvQuestionNumByKnowledgeIdEN GetObjByCourseKnowledgeIdFromList(string strCourseKnowledgeId, List<clsvQuestionNumByKnowledgeIdEN> lstvQuestionNumByKnowledgeIdObjLst)
{
foreach (clsvQuestionNumByKnowledgeIdEN objvQuestionNumByKnowledgeIdEN in lstvQuestionNumByKnowledgeIdObjLst)
{
if (objvQuestionNumByKnowledgeIdEN.CourseKnowledgeId == strCourseKnowledgeId)
{
return objvQuestionNumByKnowledgeIdEN;
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
 string strCourseKnowledgeId;
 try
 {
 strCourseKnowledgeId = new clsvQuestionNumByKnowledgeIdDA().GetFirstID(strWhereCond);
 return strCourseKnowledgeId;
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
 arrList = vQuestionNumByKnowledgeIdDA.GetID(strWhereCond);
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
bool bolIsExist = vQuestionNumByKnowledgeIdDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strCourseKnowledgeId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strCourseKnowledgeId)
{
if (string.IsNullOrEmpty(strCourseKnowledgeId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strCourseKnowledgeId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = vQuestionNumByKnowledgeIdDA.IsExist(strCourseKnowledgeId);
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
 bolIsExist = clsvQuestionNumByKnowledgeIdDA.IsExistTable();
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
 bolIsExist = vQuestionNumByKnowledgeIdDA.IsExistTable(strTabName);
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
 /// <param name = "objvQuestionNumByKnowledgeIdENS">源对象</param>
 /// <param name = "objvQuestionNumByKnowledgeIdENT">目标对象</param>
 public static void CopyTo(clsvQuestionNumByKnowledgeIdEN objvQuestionNumByKnowledgeIdENS, clsvQuestionNumByKnowledgeIdEN objvQuestionNumByKnowledgeIdENT)
{
try
{
objvQuestionNumByKnowledgeIdENT.CourseKnowledgeId = objvQuestionNumByKnowledgeIdENS.CourseKnowledgeId; //知识点Id
objvQuestionNumByKnowledgeIdENT.CourseId = objvQuestionNumByKnowledgeIdENS.CourseId; //课程Id
objvQuestionNumByKnowledgeIdENT.QuestionNum = objvQuestionNumByKnowledgeIdENS.QuestionNum; //题目数
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
 /// <param name = "objvQuestionNumByKnowledgeIdEN">源简化对象</param>
 public static void SetUpdFlag(clsvQuestionNumByKnowledgeIdEN objvQuestionNumByKnowledgeIdEN)
{
try
{
objvQuestionNumByKnowledgeIdEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvQuestionNumByKnowledgeIdEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convQuestionNumByKnowledgeId.CourseKnowledgeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionNumByKnowledgeIdEN.CourseKnowledgeId = objvQuestionNumByKnowledgeIdEN.CourseKnowledgeId; //知识点Id
}
if (arrFldSet.Contains(convQuestionNumByKnowledgeId.CourseId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionNumByKnowledgeIdEN.CourseId = objvQuestionNumByKnowledgeIdEN.CourseId == "[null]" ? null :  objvQuestionNumByKnowledgeIdEN.CourseId; //课程Id
}
if (arrFldSet.Contains(convQuestionNumByKnowledgeId.QuestionNum, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionNumByKnowledgeIdEN.QuestionNum = objvQuestionNumByKnowledgeIdEN.QuestionNum; //题目数
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
 /// <param name = "objvQuestionNumByKnowledgeIdEN">源简化对象</param>
 public static void AccessFldValueNull(clsvQuestionNumByKnowledgeIdEN objvQuestionNumByKnowledgeIdEN)
{
try
{
if (objvQuestionNumByKnowledgeIdEN.CourseId == "[null]") objvQuestionNumByKnowledgeIdEN.CourseId = null; //课程Id
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
public static void CheckProperty4Condition(clsvQuestionNumByKnowledgeIdEN objvQuestionNumByKnowledgeIdEN)
{
 vQuestionNumByKnowledgeIdDA.CheckProperty4Condition(objvQuestionNumByKnowledgeIdEN);
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
if (clscc_KnowledgesExamLibRelaBL.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_KnowledgesExamLibRelaBL没有刷新缓存机制(clscc_KnowledgesExamLibRelaBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by CourseKnowledgeId");
//if (arrvQuestionNumByKnowledgeIdObjLstCache == null)
//{
//arrvQuestionNumByKnowledgeIdObjLstCache = vQuestionNumByKnowledgeIdDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strCourseKnowledgeId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvQuestionNumByKnowledgeIdEN GetObjByCourseKnowledgeIdCache(string strCourseKnowledgeId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvQuestionNumByKnowledgeIdEN._CurrTabName);
List<clsvQuestionNumByKnowledgeIdEN> arrvQuestionNumByKnowledgeIdObjLstCache = GetObjLstCache();
IEnumerable <clsvQuestionNumByKnowledgeIdEN> arrvQuestionNumByKnowledgeIdObjLst_Sel =
arrvQuestionNumByKnowledgeIdObjLstCache
.Where(x=> x.CourseKnowledgeId == strCourseKnowledgeId 
);
if (arrvQuestionNumByKnowledgeIdObjLst_Sel.Count() == 0)
{
   clsvQuestionNumByKnowledgeIdEN obj = clsvQuestionNumByKnowledgeIdBL.GetObjByCourseKnowledgeId(strCourseKnowledgeId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvQuestionNumByKnowledgeIdObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvQuestionNumByKnowledgeIdEN> GetAllvQuestionNumByKnowledgeIdObjLstCache()
{
//获取缓存中的对象列表
List<clsvQuestionNumByKnowledgeIdEN> arrvQuestionNumByKnowledgeIdObjLstCache = GetObjLstCache(); 
return arrvQuestionNumByKnowledgeIdObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvQuestionNumByKnowledgeIdEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvQuestionNumByKnowledgeIdEN._CurrTabName);
List<clsvQuestionNumByKnowledgeIdEN> arrvQuestionNumByKnowledgeIdObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvQuestionNumByKnowledgeIdObjLstCache;
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
string strKey = string.Format("{0}", clsvQuestionNumByKnowledgeIdEN._CurrTabName);
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
public static string Func(string strInFldName, string strOutFldName, string strCourseKnowledgeId)
{
if (strInFldName != convQuestionNumByKnowledgeId.CourseKnowledgeId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convQuestionNumByKnowledgeId.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convQuestionNumByKnowledgeId.AttributeName));
throw new Exception(strMsg);
}
var objvQuestionNumByKnowledgeId = clsvQuestionNumByKnowledgeIdBL.GetObjByCourseKnowledgeIdCache(strCourseKnowledgeId);
if (objvQuestionNumByKnowledgeId == null) return "";
return objvQuestionNumByKnowledgeId[strOutFldName].ToString();
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
int intRecCount = clsvQuestionNumByKnowledgeIdDA.GetRecCount(strTabName);
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
int intRecCount = clsvQuestionNumByKnowledgeIdDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvQuestionNumByKnowledgeIdDA.GetRecCount();
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
int intRecCount = clsvQuestionNumByKnowledgeIdDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvQuestionNumByKnowledgeIdCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvQuestionNumByKnowledgeIdEN objvQuestionNumByKnowledgeIdCond)
{
List<clsvQuestionNumByKnowledgeIdEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvQuestionNumByKnowledgeIdEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convQuestionNumByKnowledgeId.AttributeName)
{
if (objvQuestionNumByKnowledgeIdCond.IsUpdated(strFldName) == false) continue;
if (objvQuestionNumByKnowledgeIdCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQuestionNumByKnowledgeIdCond[strFldName].ToString());
}
else
{
if (objvQuestionNumByKnowledgeIdCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvQuestionNumByKnowledgeIdCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQuestionNumByKnowledgeIdCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvQuestionNumByKnowledgeIdCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvQuestionNumByKnowledgeIdCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvQuestionNumByKnowledgeIdCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvQuestionNumByKnowledgeIdCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvQuestionNumByKnowledgeIdCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvQuestionNumByKnowledgeIdCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvQuestionNumByKnowledgeIdCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvQuestionNumByKnowledgeIdCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvQuestionNumByKnowledgeIdCond[strFldName]));
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
 List<string> arrList = clsvQuestionNumByKnowledgeIdDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vQuestionNumByKnowledgeIdDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vQuestionNumByKnowledgeIdDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}