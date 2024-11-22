
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvQuestionnaireTtlByTypeBL
 表名:vQuestionnaireTtlByType(01120214)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:49:08
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:问卷维护(QuestionaireEdit)
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
public static class  clsvQuestionnaireTtlByTypeBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strQuestionTypeId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvQuestionnaireTtlByTypeEN GetObj(this K_QuestionTypeId_vQuestionnaireTtlByType myKey)
{
clsvQuestionnaireTtlByTypeEN objvQuestionnaireTtlByTypeEN = clsvQuestionnaireTtlByTypeBL.vQuestionnaireTtlByTypeDA.GetObjByQuestionTypeId(myKey.Value);
return objvQuestionnaireTtlByTypeEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaireTtlByTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQuestionnaireTtlByTypeEN SetQuestionTypeId(this clsvQuestionnaireTtlByTypeEN objvQuestionnaireTtlByTypeEN, string strQuestionTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strQuestionTypeId, 2, convQuestionnaireTtlByType.QuestionTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strQuestionTypeId, 2, convQuestionnaireTtlByType.QuestionTypeId);
}
objvQuestionnaireTtlByTypeEN.QuestionTypeId = strQuestionTypeId; //题目类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionnaireTtlByTypeEN.dicFldComparisonOp.ContainsKey(convQuestionnaireTtlByType.QuestionTypeId) == false)
{
objvQuestionnaireTtlByTypeEN.dicFldComparisonOp.Add(convQuestionnaireTtlByType.QuestionTypeId, strComparisonOp);
}
else
{
objvQuestionnaireTtlByTypeEN.dicFldComparisonOp[convQuestionnaireTtlByType.QuestionTypeId] = strComparisonOp;
}
}
return objvQuestionnaireTtlByTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaireTtlByTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQuestionnaireTtlByTypeEN SetQuestionTypeName(this clsvQuestionnaireTtlByTypeEN objvQuestionnaireTtlByTypeEN, string strQuestionTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strQuestionTypeName, 20, convQuestionnaireTtlByType.QuestionTypeName);
}
objvQuestionnaireTtlByTypeEN.QuestionTypeName = strQuestionTypeName; //题目类型名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionnaireTtlByTypeEN.dicFldComparisonOp.ContainsKey(convQuestionnaireTtlByType.QuestionTypeName) == false)
{
objvQuestionnaireTtlByTypeEN.dicFldComparisonOp.Add(convQuestionnaireTtlByType.QuestionTypeName, strComparisonOp);
}
else
{
objvQuestionnaireTtlByTypeEN.dicFldComparisonOp[convQuestionnaireTtlByType.QuestionTypeName] = strComparisonOp;
}
}
return objvQuestionnaireTtlByTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaireTtlByTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQuestionnaireTtlByTypeEN SetCourseId(this clsvQuestionnaireTtlByTypeEN objvQuestionnaireTtlByTypeEN, string strCourseId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseId, 8, convQuestionnaireTtlByType.CourseId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCourseId, 8, convQuestionnaireTtlByType.CourseId);
}
objvQuestionnaireTtlByTypeEN.CourseId = strCourseId; //课程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionnaireTtlByTypeEN.dicFldComparisonOp.ContainsKey(convQuestionnaireTtlByType.CourseId) == false)
{
objvQuestionnaireTtlByTypeEN.dicFldComparisonOp.Add(convQuestionnaireTtlByType.CourseId, strComparisonOp);
}
else
{
objvQuestionnaireTtlByTypeEN.dicFldComparisonOp[convQuestionnaireTtlByType.CourseId] = strComparisonOp;
}
}
return objvQuestionnaireTtlByTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaireTtlByTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQuestionnaireTtlByTypeEN SetQuestionNum(this clsvQuestionnaireTtlByTypeEN objvQuestionnaireTtlByTypeEN, int? intQuestionNum, string strComparisonOp="")
	{
objvQuestionnaireTtlByTypeEN.QuestionNum = intQuestionNum; //题目数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionnaireTtlByTypeEN.dicFldComparisonOp.ContainsKey(convQuestionnaireTtlByType.QuestionNum) == false)
{
objvQuestionnaireTtlByTypeEN.dicFldComparisonOp.Add(convQuestionnaireTtlByType.QuestionNum, strComparisonOp);
}
else
{
objvQuestionnaireTtlByTypeEN.dicFldComparisonOp[convQuestionnaireTtlByType.QuestionNum] = strComparisonOp;
}
}
return objvQuestionnaireTtlByTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaireTtlByTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQuestionnaireTtlByTypeEN SetOrderNum(this clsvQuestionnaireTtlByTypeEN objvQuestionnaireTtlByTypeEN, int? intOrderNum, string strComparisonOp="")
	{
objvQuestionnaireTtlByTypeEN.OrderNum = intOrderNum; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionnaireTtlByTypeEN.dicFldComparisonOp.ContainsKey(convQuestionnaireTtlByType.OrderNum) == false)
{
objvQuestionnaireTtlByTypeEN.dicFldComparisonOp.Add(convQuestionnaireTtlByType.OrderNum, strComparisonOp);
}
else
{
objvQuestionnaireTtlByTypeEN.dicFldComparisonOp[convQuestionnaireTtlByType.OrderNum] = strComparisonOp;
}
}
return objvQuestionnaireTtlByTypeEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvQuestionnaireTtlByTypeENS">源对象</param>
 /// <param name = "objvQuestionnaireTtlByTypeENT">目标对象</param>
 public static void CopyTo(this clsvQuestionnaireTtlByTypeEN objvQuestionnaireTtlByTypeENS, clsvQuestionnaireTtlByTypeEN objvQuestionnaireTtlByTypeENT)
{
try
{
objvQuestionnaireTtlByTypeENT.QuestionTypeId = objvQuestionnaireTtlByTypeENS.QuestionTypeId; //题目类型Id
objvQuestionnaireTtlByTypeENT.QuestionTypeName = objvQuestionnaireTtlByTypeENS.QuestionTypeName; //题目类型名
objvQuestionnaireTtlByTypeENT.CourseId = objvQuestionnaireTtlByTypeENS.CourseId; //课程Id
objvQuestionnaireTtlByTypeENT.QuestionNum = objvQuestionnaireTtlByTypeENS.QuestionNum; //题目数
objvQuestionnaireTtlByTypeENT.OrderNum = objvQuestionnaireTtlByTypeENS.OrderNum; //序号
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
 /// <param name = "objvQuestionnaireTtlByTypeENS">源对象</param>
 /// <returns>目标对象=>clsvQuestionnaireTtlByTypeEN:objvQuestionnaireTtlByTypeENT</returns>
 public static clsvQuestionnaireTtlByTypeEN CopyTo(this clsvQuestionnaireTtlByTypeEN objvQuestionnaireTtlByTypeENS)
{
try
{
 clsvQuestionnaireTtlByTypeEN objvQuestionnaireTtlByTypeENT = new clsvQuestionnaireTtlByTypeEN()
{
QuestionTypeId = objvQuestionnaireTtlByTypeENS.QuestionTypeId, //题目类型Id
QuestionTypeName = objvQuestionnaireTtlByTypeENS.QuestionTypeName, //题目类型名
CourseId = objvQuestionnaireTtlByTypeENS.CourseId, //课程Id
QuestionNum = objvQuestionnaireTtlByTypeENS.QuestionNum, //题目数
OrderNum = objvQuestionnaireTtlByTypeENS.OrderNum, //序号
};
 return objvQuestionnaireTtlByTypeENT;
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
public static void CheckProperty4Condition(this clsvQuestionnaireTtlByTypeEN objvQuestionnaireTtlByTypeEN)
{
 clsvQuestionnaireTtlByTypeBL.vQuestionnaireTtlByTypeDA.CheckProperty4Condition(objvQuestionnaireTtlByTypeEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvQuestionnaireTtlByTypeEN objvQuestionnaireTtlByTypeCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvQuestionnaireTtlByTypeCond.IsUpdated(convQuestionnaireTtlByType.QuestionTypeId) == true)
{
string strComparisonOpQuestionTypeId = objvQuestionnaireTtlByTypeCond.dicFldComparisonOp[convQuestionnaireTtlByType.QuestionTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaireTtlByType.QuestionTypeId, objvQuestionnaireTtlByTypeCond.QuestionTypeId, strComparisonOpQuestionTypeId);
}
if (objvQuestionnaireTtlByTypeCond.IsUpdated(convQuestionnaireTtlByType.QuestionTypeName) == true)
{
string strComparisonOpQuestionTypeName = objvQuestionnaireTtlByTypeCond.dicFldComparisonOp[convQuestionnaireTtlByType.QuestionTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaireTtlByType.QuestionTypeName, objvQuestionnaireTtlByTypeCond.QuestionTypeName, strComparisonOpQuestionTypeName);
}
if (objvQuestionnaireTtlByTypeCond.IsUpdated(convQuestionnaireTtlByType.CourseId) == true)
{
string strComparisonOpCourseId = objvQuestionnaireTtlByTypeCond.dicFldComparisonOp[convQuestionnaireTtlByType.CourseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaireTtlByType.CourseId, objvQuestionnaireTtlByTypeCond.CourseId, strComparisonOpCourseId);
}
if (objvQuestionnaireTtlByTypeCond.IsUpdated(convQuestionnaireTtlByType.QuestionNum) == true)
{
string strComparisonOpQuestionNum = objvQuestionnaireTtlByTypeCond.dicFldComparisonOp[convQuestionnaireTtlByType.QuestionNum];
strWhereCond += string.Format(" And {0} {2} {1}", convQuestionnaireTtlByType.QuestionNum, objvQuestionnaireTtlByTypeCond.QuestionNum, strComparisonOpQuestionNum);
}
if (objvQuestionnaireTtlByTypeCond.IsUpdated(convQuestionnaireTtlByType.OrderNum) == true)
{
string strComparisonOpOrderNum = objvQuestionnaireTtlByTypeCond.dicFldComparisonOp[convQuestionnaireTtlByType.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", convQuestionnaireTtlByType.OrderNum, objvQuestionnaireTtlByTypeCond.OrderNum, strComparisonOpOrderNum);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vQuestionnaireTtlByType
{
public virtual bool UpdRelaTabDate(string strQuestionTypeId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// vQuestionnaireTtlByType(vQuestionnaireTtlByType)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvQuestionnaireTtlByTypeBL
{
public static RelatedActions_vQuestionnaireTtlByType relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvQuestionnaireTtlByTypeDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvQuestionnaireTtlByTypeDA vQuestionnaireTtlByTypeDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvQuestionnaireTtlByTypeDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvQuestionnaireTtlByTypeBL()
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
if (string.IsNullOrEmpty(clsvQuestionnaireTtlByTypeEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvQuestionnaireTtlByTypeEN._ConnectString);
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
public static DataTable GetDataTable_vQuestionnaireTtlByType(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vQuestionnaireTtlByTypeDA.GetDataTable_vQuestionnaireTtlByType(strWhereCond);
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
objDT = vQuestionnaireTtlByTypeDA.GetDataTable(strWhereCond);
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
objDT = vQuestionnaireTtlByTypeDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vQuestionnaireTtlByTypeDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vQuestionnaireTtlByTypeDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vQuestionnaireTtlByTypeDA.GetDataTable_Top(objTopPara);
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
objDT = vQuestionnaireTtlByTypeDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vQuestionnaireTtlByTypeDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vQuestionnaireTtlByTypeDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrQuestionTypeIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvQuestionnaireTtlByTypeEN> GetObjLstByQuestionTypeIdLst(List<string> arrQuestionTypeIdLst)
{
List<clsvQuestionnaireTtlByTypeEN> arrObjLst = new List<clsvQuestionnaireTtlByTypeEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrQuestionTypeIdLst, true);
 string strWhereCond = string.Format("QuestionTypeId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQuestionnaireTtlByTypeEN objvQuestionnaireTtlByTypeEN = new clsvQuestionnaireTtlByTypeEN();
try
{
objvQuestionnaireTtlByTypeEN.QuestionTypeId = objRow[convQuestionnaireTtlByType.QuestionTypeId].ToString().Trim(); //题目类型Id
objvQuestionnaireTtlByTypeEN.QuestionTypeName = objRow[convQuestionnaireTtlByType.QuestionTypeName] == DBNull.Value ? null : objRow[convQuestionnaireTtlByType.QuestionTypeName].ToString().Trim(); //题目类型名
objvQuestionnaireTtlByTypeEN.CourseId = objRow[convQuestionnaireTtlByType.CourseId] == DBNull.Value ? null : objRow[convQuestionnaireTtlByType.CourseId].ToString().Trim(); //课程Id
objvQuestionnaireTtlByTypeEN.QuestionNum = objRow[convQuestionnaireTtlByType.QuestionNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaireTtlByType.QuestionNum].ToString().Trim()); //题目数
objvQuestionnaireTtlByTypeEN.OrderNum = objRow[convQuestionnaireTtlByType.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaireTtlByType.OrderNum].ToString().Trim()); //序号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQuestionnaireTtlByTypeEN.QuestionTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQuestionnaireTtlByTypeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrQuestionTypeIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvQuestionnaireTtlByTypeEN> GetObjLstByQuestionTypeIdLstCache(List<string> arrQuestionTypeIdLst)
{
string strKey = string.Format("{0}", clsvQuestionnaireTtlByTypeEN._CurrTabName);
List<clsvQuestionnaireTtlByTypeEN> arrvQuestionnaireTtlByTypeObjLstCache = GetObjLstCache();
IEnumerable <clsvQuestionnaireTtlByTypeEN> arrvQuestionnaireTtlByTypeObjLst_Sel =
arrvQuestionnaireTtlByTypeObjLstCache
.Where(x => arrQuestionTypeIdLst.Contains(x.QuestionTypeId));
return arrvQuestionnaireTtlByTypeObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQuestionnaireTtlByTypeEN> GetObjLst(string strWhereCond)
{
List<clsvQuestionnaireTtlByTypeEN> arrObjLst = new List<clsvQuestionnaireTtlByTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQuestionnaireTtlByTypeEN objvQuestionnaireTtlByTypeEN = new clsvQuestionnaireTtlByTypeEN();
try
{
objvQuestionnaireTtlByTypeEN.QuestionTypeId = objRow[convQuestionnaireTtlByType.QuestionTypeId].ToString().Trim(); //题目类型Id
objvQuestionnaireTtlByTypeEN.QuestionTypeName = objRow[convQuestionnaireTtlByType.QuestionTypeName] == DBNull.Value ? null : objRow[convQuestionnaireTtlByType.QuestionTypeName].ToString().Trim(); //题目类型名
objvQuestionnaireTtlByTypeEN.CourseId = objRow[convQuestionnaireTtlByType.CourseId] == DBNull.Value ? null : objRow[convQuestionnaireTtlByType.CourseId].ToString().Trim(); //课程Id
objvQuestionnaireTtlByTypeEN.QuestionNum = objRow[convQuestionnaireTtlByType.QuestionNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaireTtlByType.QuestionNum].ToString().Trim()); //题目数
objvQuestionnaireTtlByTypeEN.OrderNum = objRow[convQuestionnaireTtlByType.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaireTtlByType.OrderNum].ToString().Trim()); //序号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQuestionnaireTtlByTypeEN.QuestionTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQuestionnaireTtlByTypeEN);
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
public static List<clsvQuestionnaireTtlByTypeEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvQuestionnaireTtlByTypeEN> arrObjLst = new List<clsvQuestionnaireTtlByTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQuestionnaireTtlByTypeEN objvQuestionnaireTtlByTypeEN = new clsvQuestionnaireTtlByTypeEN();
try
{
objvQuestionnaireTtlByTypeEN.QuestionTypeId = objRow[convQuestionnaireTtlByType.QuestionTypeId].ToString().Trim(); //题目类型Id
objvQuestionnaireTtlByTypeEN.QuestionTypeName = objRow[convQuestionnaireTtlByType.QuestionTypeName] == DBNull.Value ? null : objRow[convQuestionnaireTtlByType.QuestionTypeName].ToString().Trim(); //题目类型名
objvQuestionnaireTtlByTypeEN.CourseId = objRow[convQuestionnaireTtlByType.CourseId] == DBNull.Value ? null : objRow[convQuestionnaireTtlByType.CourseId].ToString().Trim(); //课程Id
objvQuestionnaireTtlByTypeEN.QuestionNum = objRow[convQuestionnaireTtlByType.QuestionNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaireTtlByType.QuestionNum].ToString().Trim()); //题目数
objvQuestionnaireTtlByTypeEN.OrderNum = objRow[convQuestionnaireTtlByType.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaireTtlByType.OrderNum].ToString().Trim()); //序号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQuestionnaireTtlByTypeEN.QuestionTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQuestionnaireTtlByTypeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvQuestionnaireTtlByTypeCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvQuestionnaireTtlByTypeEN> GetSubObjLstCache(clsvQuestionnaireTtlByTypeEN objvQuestionnaireTtlByTypeCond)
{
List<clsvQuestionnaireTtlByTypeEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvQuestionnaireTtlByTypeEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convQuestionnaireTtlByType.AttributeName)
{
if (objvQuestionnaireTtlByTypeCond.IsUpdated(strFldName) == false) continue;
if (objvQuestionnaireTtlByTypeCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQuestionnaireTtlByTypeCond[strFldName].ToString());
}
else
{
if (objvQuestionnaireTtlByTypeCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvQuestionnaireTtlByTypeCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQuestionnaireTtlByTypeCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvQuestionnaireTtlByTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvQuestionnaireTtlByTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvQuestionnaireTtlByTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvQuestionnaireTtlByTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvQuestionnaireTtlByTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvQuestionnaireTtlByTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvQuestionnaireTtlByTypeCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvQuestionnaireTtlByTypeCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvQuestionnaireTtlByTypeCond[strFldName]));
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
public static List<clsvQuestionnaireTtlByTypeEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvQuestionnaireTtlByTypeEN> arrObjLst = new List<clsvQuestionnaireTtlByTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQuestionnaireTtlByTypeEN objvQuestionnaireTtlByTypeEN = new clsvQuestionnaireTtlByTypeEN();
try
{
objvQuestionnaireTtlByTypeEN.QuestionTypeId = objRow[convQuestionnaireTtlByType.QuestionTypeId].ToString().Trim(); //题目类型Id
objvQuestionnaireTtlByTypeEN.QuestionTypeName = objRow[convQuestionnaireTtlByType.QuestionTypeName] == DBNull.Value ? null : objRow[convQuestionnaireTtlByType.QuestionTypeName].ToString().Trim(); //题目类型名
objvQuestionnaireTtlByTypeEN.CourseId = objRow[convQuestionnaireTtlByType.CourseId] == DBNull.Value ? null : objRow[convQuestionnaireTtlByType.CourseId].ToString().Trim(); //课程Id
objvQuestionnaireTtlByTypeEN.QuestionNum = objRow[convQuestionnaireTtlByType.QuestionNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaireTtlByType.QuestionNum].ToString().Trim()); //题目数
objvQuestionnaireTtlByTypeEN.OrderNum = objRow[convQuestionnaireTtlByType.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaireTtlByType.OrderNum].ToString().Trim()); //序号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQuestionnaireTtlByTypeEN.QuestionTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQuestionnaireTtlByTypeEN);
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
public static List<clsvQuestionnaireTtlByTypeEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvQuestionnaireTtlByTypeEN> arrObjLst = new List<clsvQuestionnaireTtlByTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQuestionnaireTtlByTypeEN objvQuestionnaireTtlByTypeEN = new clsvQuestionnaireTtlByTypeEN();
try
{
objvQuestionnaireTtlByTypeEN.QuestionTypeId = objRow[convQuestionnaireTtlByType.QuestionTypeId].ToString().Trim(); //题目类型Id
objvQuestionnaireTtlByTypeEN.QuestionTypeName = objRow[convQuestionnaireTtlByType.QuestionTypeName] == DBNull.Value ? null : objRow[convQuestionnaireTtlByType.QuestionTypeName].ToString().Trim(); //题目类型名
objvQuestionnaireTtlByTypeEN.CourseId = objRow[convQuestionnaireTtlByType.CourseId] == DBNull.Value ? null : objRow[convQuestionnaireTtlByType.CourseId].ToString().Trim(); //课程Id
objvQuestionnaireTtlByTypeEN.QuestionNum = objRow[convQuestionnaireTtlByType.QuestionNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaireTtlByType.QuestionNum].ToString().Trim()); //题目数
objvQuestionnaireTtlByTypeEN.OrderNum = objRow[convQuestionnaireTtlByType.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaireTtlByType.OrderNum].ToString().Trim()); //序号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQuestionnaireTtlByTypeEN.QuestionTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQuestionnaireTtlByTypeEN);
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
List<clsvQuestionnaireTtlByTypeEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvQuestionnaireTtlByTypeEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQuestionnaireTtlByTypeEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvQuestionnaireTtlByTypeEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvQuestionnaireTtlByTypeEN> arrObjLst = new List<clsvQuestionnaireTtlByTypeEN>(); 
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
	clsvQuestionnaireTtlByTypeEN objvQuestionnaireTtlByTypeEN = new clsvQuestionnaireTtlByTypeEN();
try
{
objvQuestionnaireTtlByTypeEN.QuestionTypeId = objRow[convQuestionnaireTtlByType.QuestionTypeId].ToString().Trim(); //题目类型Id
objvQuestionnaireTtlByTypeEN.QuestionTypeName = objRow[convQuestionnaireTtlByType.QuestionTypeName] == DBNull.Value ? null : objRow[convQuestionnaireTtlByType.QuestionTypeName].ToString().Trim(); //题目类型名
objvQuestionnaireTtlByTypeEN.CourseId = objRow[convQuestionnaireTtlByType.CourseId] == DBNull.Value ? null : objRow[convQuestionnaireTtlByType.CourseId].ToString().Trim(); //课程Id
objvQuestionnaireTtlByTypeEN.QuestionNum = objRow[convQuestionnaireTtlByType.QuestionNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaireTtlByType.QuestionNum].ToString().Trim()); //题目数
objvQuestionnaireTtlByTypeEN.OrderNum = objRow[convQuestionnaireTtlByType.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaireTtlByType.OrderNum].ToString().Trim()); //序号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQuestionnaireTtlByTypeEN.QuestionTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQuestionnaireTtlByTypeEN);
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
public static List<clsvQuestionnaireTtlByTypeEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvQuestionnaireTtlByTypeEN> arrObjLst = new List<clsvQuestionnaireTtlByTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQuestionnaireTtlByTypeEN objvQuestionnaireTtlByTypeEN = new clsvQuestionnaireTtlByTypeEN();
try
{
objvQuestionnaireTtlByTypeEN.QuestionTypeId = objRow[convQuestionnaireTtlByType.QuestionTypeId].ToString().Trim(); //题目类型Id
objvQuestionnaireTtlByTypeEN.QuestionTypeName = objRow[convQuestionnaireTtlByType.QuestionTypeName] == DBNull.Value ? null : objRow[convQuestionnaireTtlByType.QuestionTypeName].ToString().Trim(); //题目类型名
objvQuestionnaireTtlByTypeEN.CourseId = objRow[convQuestionnaireTtlByType.CourseId] == DBNull.Value ? null : objRow[convQuestionnaireTtlByType.CourseId].ToString().Trim(); //课程Id
objvQuestionnaireTtlByTypeEN.QuestionNum = objRow[convQuestionnaireTtlByType.QuestionNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaireTtlByType.QuestionNum].ToString().Trim()); //题目数
objvQuestionnaireTtlByTypeEN.OrderNum = objRow[convQuestionnaireTtlByType.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaireTtlByType.OrderNum].ToString().Trim()); //序号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQuestionnaireTtlByTypeEN.QuestionTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQuestionnaireTtlByTypeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvQuestionnaireTtlByTypeEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvQuestionnaireTtlByTypeEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvQuestionnaireTtlByTypeEN> arrObjLst = new List<clsvQuestionnaireTtlByTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQuestionnaireTtlByTypeEN objvQuestionnaireTtlByTypeEN = new clsvQuestionnaireTtlByTypeEN();
try
{
objvQuestionnaireTtlByTypeEN.QuestionTypeId = objRow[convQuestionnaireTtlByType.QuestionTypeId].ToString().Trim(); //题目类型Id
objvQuestionnaireTtlByTypeEN.QuestionTypeName = objRow[convQuestionnaireTtlByType.QuestionTypeName] == DBNull.Value ? null : objRow[convQuestionnaireTtlByType.QuestionTypeName].ToString().Trim(); //题目类型名
objvQuestionnaireTtlByTypeEN.CourseId = objRow[convQuestionnaireTtlByType.CourseId] == DBNull.Value ? null : objRow[convQuestionnaireTtlByType.CourseId].ToString().Trim(); //课程Id
objvQuestionnaireTtlByTypeEN.QuestionNum = objRow[convQuestionnaireTtlByType.QuestionNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaireTtlByType.QuestionNum].ToString().Trim()); //题目数
objvQuestionnaireTtlByTypeEN.OrderNum = objRow[convQuestionnaireTtlByType.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaireTtlByType.OrderNum].ToString().Trim()); //序号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQuestionnaireTtlByTypeEN.QuestionTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQuestionnaireTtlByTypeEN);
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
public static List<clsvQuestionnaireTtlByTypeEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvQuestionnaireTtlByTypeEN> arrObjLst = new List<clsvQuestionnaireTtlByTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQuestionnaireTtlByTypeEN objvQuestionnaireTtlByTypeEN = new clsvQuestionnaireTtlByTypeEN();
try
{
objvQuestionnaireTtlByTypeEN.QuestionTypeId = objRow[convQuestionnaireTtlByType.QuestionTypeId].ToString().Trim(); //题目类型Id
objvQuestionnaireTtlByTypeEN.QuestionTypeName = objRow[convQuestionnaireTtlByType.QuestionTypeName] == DBNull.Value ? null : objRow[convQuestionnaireTtlByType.QuestionTypeName].ToString().Trim(); //题目类型名
objvQuestionnaireTtlByTypeEN.CourseId = objRow[convQuestionnaireTtlByType.CourseId] == DBNull.Value ? null : objRow[convQuestionnaireTtlByType.CourseId].ToString().Trim(); //课程Id
objvQuestionnaireTtlByTypeEN.QuestionNum = objRow[convQuestionnaireTtlByType.QuestionNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaireTtlByType.QuestionNum].ToString().Trim()); //题目数
objvQuestionnaireTtlByTypeEN.OrderNum = objRow[convQuestionnaireTtlByType.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaireTtlByType.OrderNum].ToString().Trim()); //序号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQuestionnaireTtlByTypeEN.QuestionTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQuestionnaireTtlByTypeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQuestionnaireTtlByTypeEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvQuestionnaireTtlByTypeEN> arrObjLst = new List<clsvQuestionnaireTtlByTypeEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQuestionnaireTtlByTypeEN objvQuestionnaireTtlByTypeEN = new clsvQuestionnaireTtlByTypeEN();
try
{
objvQuestionnaireTtlByTypeEN.QuestionTypeId = objRow[convQuestionnaireTtlByType.QuestionTypeId].ToString().Trim(); //题目类型Id
objvQuestionnaireTtlByTypeEN.QuestionTypeName = objRow[convQuestionnaireTtlByType.QuestionTypeName] == DBNull.Value ? null : objRow[convQuestionnaireTtlByType.QuestionTypeName].ToString().Trim(); //题目类型名
objvQuestionnaireTtlByTypeEN.CourseId = objRow[convQuestionnaireTtlByType.CourseId] == DBNull.Value ? null : objRow[convQuestionnaireTtlByType.CourseId].ToString().Trim(); //课程Id
objvQuestionnaireTtlByTypeEN.QuestionNum = objRow[convQuestionnaireTtlByType.QuestionNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaireTtlByType.QuestionNum].ToString().Trim()); //题目数
objvQuestionnaireTtlByTypeEN.OrderNum = objRow[convQuestionnaireTtlByType.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaireTtlByType.OrderNum].ToString().Trim()); //序号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQuestionnaireTtlByTypeEN.QuestionTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQuestionnaireTtlByTypeEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvQuestionnaireTtlByTypeEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvQuestionnaireTtlByType(ref clsvQuestionnaireTtlByTypeEN objvQuestionnaireTtlByTypeEN)
{
bool bolResult = vQuestionnaireTtlByTypeDA.GetvQuestionnaireTtlByType(ref objvQuestionnaireTtlByTypeEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strQuestionTypeId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvQuestionnaireTtlByTypeEN GetObjByQuestionTypeId(string strQuestionTypeId)
{
if (strQuestionTypeId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strQuestionTypeId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strQuestionTypeId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strQuestionTypeId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsvQuestionnaireTtlByTypeEN objvQuestionnaireTtlByTypeEN = vQuestionnaireTtlByTypeDA.GetObjByQuestionTypeId(strQuestionTypeId);
return objvQuestionnaireTtlByTypeEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvQuestionnaireTtlByTypeEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvQuestionnaireTtlByTypeEN objvQuestionnaireTtlByTypeEN = vQuestionnaireTtlByTypeDA.GetFirstObj(strWhereCond);
 return objvQuestionnaireTtlByTypeEN;
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
public static clsvQuestionnaireTtlByTypeEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvQuestionnaireTtlByTypeEN objvQuestionnaireTtlByTypeEN = vQuestionnaireTtlByTypeDA.GetObjByDataRow(objRow);
 return objvQuestionnaireTtlByTypeEN;
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
public static clsvQuestionnaireTtlByTypeEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvQuestionnaireTtlByTypeEN objvQuestionnaireTtlByTypeEN = vQuestionnaireTtlByTypeDA.GetObjByDataRow(objRow);
 return objvQuestionnaireTtlByTypeEN;
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
 /// <param name = "strQuestionTypeId">所给的关键字</param>
 /// <param name = "lstvQuestionnaireTtlByTypeObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvQuestionnaireTtlByTypeEN GetObjByQuestionTypeIdFromList(string strQuestionTypeId, List<clsvQuestionnaireTtlByTypeEN> lstvQuestionnaireTtlByTypeObjLst)
{
foreach (clsvQuestionnaireTtlByTypeEN objvQuestionnaireTtlByTypeEN in lstvQuestionnaireTtlByTypeObjLst)
{
if (objvQuestionnaireTtlByTypeEN.QuestionTypeId == strQuestionTypeId)
{
return objvQuestionnaireTtlByTypeEN;
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
 string strQuestionTypeId;
 try
 {
 strQuestionTypeId = new clsvQuestionnaireTtlByTypeDA().GetFirstID(strWhereCond);
 return strQuestionTypeId;
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
 arrList = vQuestionnaireTtlByTypeDA.GetID(strWhereCond);
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
bool bolIsExist = vQuestionnaireTtlByTypeDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strQuestionTypeId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strQuestionTypeId)
{
if (string.IsNullOrEmpty(strQuestionTypeId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strQuestionTypeId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = vQuestionnaireTtlByTypeDA.IsExist(strQuestionTypeId);
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
 bolIsExist = clsvQuestionnaireTtlByTypeDA.IsExistTable();
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
 bolIsExist = vQuestionnaireTtlByTypeDA.IsExistTable(strTabName);
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
 /// <param name = "objvQuestionnaireTtlByTypeENS">源对象</param>
 /// <param name = "objvQuestionnaireTtlByTypeENT">目标对象</param>
 public static void CopyTo(clsvQuestionnaireTtlByTypeEN objvQuestionnaireTtlByTypeENS, clsvQuestionnaireTtlByTypeEN objvQuestionnaireTtlByTypeENT)
{
try
{
objvQuestionnaireTtlByTypeENT.QuestionTypeId = objvQuestionnaireTtlByTypeENS.QuestionTypeId; //题目类型Id
objvQuestionnaireTtlByTypeENT.QuestionTypeName = objvQuestionnaireTtlByTypeENS.QuestionTypeName; //题目类型名
objvQuestionnaireTtlByTypeENT.CourseId = objvQuestionnaireTtlByTypeENS.CourseId; //课程Id
objvQuestionnaireTtlByTypeENT.QuestionNum = objvQuestionnaireTtlByTypeENS.QuestionNum; //题目数
objvQuestionnaireTtlByTypeENT.OrderNum = objvQuestionnaireTtlByTypeENS.OrderNum; //序号
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
 /// <param name = "objvQuestionnaireTtlByTypeEN">源简化对象</param>
 public static void SetUpdFlag(clsvQuestionnaireTtlByTypeEN objvQuestionnaireTtlByTypeEN)
{
try
{
objvQuestionnaireTtlByTypeEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvQuestionnaireTtlByTypeEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convQuestionnaireTtlByType.QuestionTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionnaireTtlByTypeEN.QuestionTypeId = objvQuestionnaireTtlByTypeEN.QuestionTypeId; //题目类型Id
}
if (arrFldSet.Contains(convQuestionnaireTtlByType.QuestionTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionnaireTtlByTypeEN.QuestionTypeName = objvQuestionnaireTtlByTypeEN.QuestionTypeName == "[null]" ? null :  objvQuestionnaireTtlByTypeEN.QuestionTypeName; //题目类型名
}
if (arrFldSet.Contains(convQuestionnaireTtlByType.CourseId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionnaireTtlByTypeEN.CourseId = objvQuestionnaireTtlByTypeEN.CourseId == "[null]" ? null :  objvQuestionnaireTtlByTypeEN.CourseId; //课程Id
}
if (arrFldSet.Contains(convQuestionnaireTtlByType.QuestionNum, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionnaireTtlByTypeEN.QuestionNum = objvQuestionnaireTtlByTypeEN.QuestionNum; //题目数
}
if (arrFldSet.Contains(convQuestionnaireTtlByType.OrderNum, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionnaireTtlByTypeEN.OrderNum = objvQuestionnaireTtlByTypeEN.OrderNum; //序号
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
 /// <param name = "objvQuestionnaireTtlByTypeEN">源简化对象</param>
 public static void AccessFldValueNull(clsvQuestionnaireTtlByTypeEN objvQuestionnaireTtlByTypeEN)
{
try
{
if (objvQuestionnaireTtlByTypeEN.QuestionTypeName == "[null]") objvQuestionnaireTtlByTypeEN.QuestionTypeName = null; //题目类型名
if (objvQuestionnaireTtlByTypeEN.CourseId == "[null]") objvQuestionnaireTtlByTypeEN.CourseId = null; //课程Id
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
public static void CheckProperty4Condition(clsvQuestionnaireTtlByTypeEN objvQuestionnaireTtlByTypeEN)
{
 vQuestionnaireTtlByTypeDA.CheckProperty4Condition(objvQuestionnaireTtlByTypeEN);
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
if (clsQuestionnaireBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsQuestionnaireBL没有刷新缓存机制(clsQuestionnaireBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsQuestionTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsQuestionTypeBL没有刷新缓存机制(clsQuestionTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by QuestionTypeId");
//if (arrvQuestionnaireTtlByTypeObjLstCache == null)
//{
//arrvQuestionnaireTtlByTypeObjLstCache = vQuestionnaireTtlByTypeDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strQuestionTypeId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvQuestionnaireTtlByTypeEN GetObjByQuestionTypeIdCache(string strQuestionTypeId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvQuestionnaireTtlByTypeEN._CurrTabName);
List<clsvQuestionnaireTtlByTypeEN> arrvQuestionnaireTtlByTypeObjLstCache = GetObjLstCache();
IEnumerable <clsvQuestionnaireTtlByTypeEN> arrvQuestionnaireTtlByTypeObjLst_Sel =
arrvQuestionnaireTtlByTypeObjLstCache
.Where(x=> x.QuestionTypeId == strQuestionTypeId 
);
if (arrvQuestionnaireTtlByTypeObjLst_Sel.Count() == 0)
{
   clsvQuestionnaireTtlByTypeEN obj = clsvQuestionnaireTtlByTypeBL.GetObjByQuestionTypeId(strQuestionTypeId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvQuestionnaireTtlByTypeObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvQuestionnaireTtlByTypeEN> GetAllvQuestionnaireTtlByTypeObjLstCache()
{
//获取缓存中的对象列表
List<clsvQuestionnaireTtlByTypeEN> arrvQuestionnaireTtlByTypeObjLstCache = GetObjLstCache(); 
return arrvQuestionnaireTtlByTypeObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvQuestionnaireTtlByTypeEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvQuestionnaireTtlByTypeEN._CurrTabName);
List<clsvQuestionnaireTtlByTypeEN> arrvQuestionnaireTtlByTypeObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvQuestionnaireTtlByTypeObjLstCache;
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
string strKey = string.Format("{0}", clsvQuestionnaireTtlByTypeEN._CurrTabName);
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
public static string Func(string strInFldName, string strOutFldName, string strQuestionTypeId)
{
if (strInFldName != convQuestionnaireTtlByType.QuestionTypeId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convQuestionnaireTtlByType.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convQuestionnaireTtlByType.AttributeName));
throw new Exception(strMsg);
}
var objvQuestionnaireTtlByType = clsvQuestionnaireTtlByTypeBL.GetObjByQuestionTypeIdCache(strQuestionTypeId);
if (objvQuestionnaireTtlByType == null) return "";
return objvQuestionnaireTtlByType[strOutFldName].ToString();
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
int intRecCount = clsvQuestionnaireTtlByTypeDA.GetRecCount(strTabName);
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
int intRecCount = clsvQuestionnaireTtlByTypeDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvQuestionnaireTtlByTypeDA.GetRecCount();
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
int intRecCount = clsvQuestionnaireTtlByTypeDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvQuestionnaireTtlByTypeCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvQuestionnaireTtlByTypeEN objvQuestionnaireTtlByTypeCond)
{
List<clsvQuestionnaireTtlByTypeEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvQuestionnaireTtlByTypeEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convQuestionnaireTtlByType.AttributeName)
{
if (objvQuestionnaireTtlByTypeCond.IsUpdated(strFldName) == false) continue;
if (objvQuestionnaireTtlByTypeCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQuestionnaireTtlByTypeCond[strFldName].ToString());
}
else
{
if (objvQuestionnaireTtlByTypeCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvQuestionnaireTtlByTypeCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQuestionnaireTtlByTypeCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvQuestionnaireTtlByTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvQuestionnaireTtlByTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvQuestionnaireTtlByTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvQuestionnaireTtlByTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvQuestionnaireTtlByTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvQuestionnaireTtlByTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvQuestionnaireTtlByTypeCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvQuestionnaireTtlByTypeCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvQuestionnaireTtlByTypeCond[strFldName]));
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
 List<string> arrList = clsvQuestionnaireTtlByTypeDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vQuestionnaireTtlByTypeDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vQuestionnaireTtlByTypeDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}