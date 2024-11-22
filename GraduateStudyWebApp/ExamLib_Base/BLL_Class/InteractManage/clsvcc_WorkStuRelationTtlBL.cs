
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvcc_WorkStuRelationTtlBL
 表名:vcc_WorkStuRelationTtl(01120356)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 12:52:42
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:互动管理(InteractManage)
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
public static class  clsvcc_WorkStuRelationTtlBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strIdStudentInfo">表关键字</param>
 /// <returns>表对象</returns>
public static clsvcc_WorkStuRelationTtlEN GetObj(this K_IdStudentInfo_vcc_WorkStuRelationTtl myKey)
{
clsvcc_WorkStuRelationTtlEN objvcc_WorkStuRelationTtlEN = clsvcc_WorkStuRelationTtlBL.vcc_WorkStuRelationTtlDA.GetObjByIdStudentInfo(myKey.Value);
return objvcc_WorkStuRelationTtlEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelationTtlEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkStuRelationTtlEN SetIdStudentInfo(this clsvcc_WorkStuRelationTtlEN objvcc_WorkStuRelationTtlEN, string strIdStudentInfo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdStudentInfo, 8, convcc_WorkStuRelationTtl.IdStudentInfo);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdStudentInfo, 8, convcc_WorkStuRelationTtl.IdStudentInfo);
}
objvcc_WorkStuRelationTtlEN.IdStudentInfo = strIdStudentInfo; //学生流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelationTtlEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelationTtl.IdStudentInfo) == false)
{
objvcc_WorkStuRelationTtlEN.dicFldComparisonOp.Add(convcc_WorkStuRelationTtl.IdStudentInfo, strComparisonOp);
}
else
{
objvcc_WorkStuRelationTtlEN.dicFldComparisonOp[convcc_WorkStuRelationTtl.IdStudentInfo] = strComparisonOp;
}
}
return objvcc_WorkStuRelationTtlEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelationTtlEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkStuRelationTtlEN SetIdCurrEduCls(this clsvcc_WorkStuRelationTtlEN objvcc_WorkStuRelationTtlEN, string strIdCurrEduCls, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdCurrEduCls, convcc_WorkStuRelationTtl.IdCurrEduCls);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdCurrEduCls, 8, convcc_WorkStuRelationTtl.IdCurrEduCls);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdCurrEduCls, 8, convcc_WorkStuRelationTtl.IdCurrEduCls);
}
objvcc_WorkStuRelationTtlEN.IdCurrEduCls = strIdCurrEduCls; //教学班流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelationTtlEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelationTtl.IdCurrEduCls) == false)
{
objvcc_WorkStuRelationTtlEN.dicFldComparisonOp.Add(convcc_WorkStuRelationTtl.IdCurrEduCls, strComparisonOp);
}
else
{
objvcc_WorkStuRelationTtlEN.dicFldComparisonOp[convcc_WorkStuRelationTtl.IdCurrEduCls] = strComparisonOp;
}
}
return objvcc_WorkStuRelationTtlEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelationTtlEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkStuRelationTtlEN SetQuestionTypeId4Course(this clsvcc_WorkStuRelationTtlEN objvcc_WorkStuRelationTtlEN, string strQuestionTypeId4Course, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strQuestionTypeId4Course, convcc_WorkStuRelationTtl.QuestionTypeId4Course);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strQuestionTypeId4Course, 8, convcc_WorkStuRelationTtl.QuestionTypeId4Course);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strQuestionTypeId4Course, 8, convcc_WorkStuRelationTtl.QuestionTypeId4Course);
}
objvcc_WorkStuRelationTtlEN.QuestionTypeId4Course = strQuestionTypeId4Course; //题目类型Id4课程
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelationTtlEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelationTtl.QuestionTypeId4Course) == false)
{
objvcc_WorkStuRelationTtlEN.dicFldComparisonOp.Add(convcc_WorkStuRelationTtl.QuestionTypeId4Course, strComparisonOp);
}
else
{
objvcc_WorkStuRelationTtlEN.dicFldComparisonOp[convcc_WorkStuRelationTtl.QuestionTypeId4Course] = strComparisonOp;
}
}
return objvcc_WorkStuRelationTtlEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelationTtlEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkStuRelationTtlEN SetQuestionTypeId(this clsvcc_WorkStuRelationTtlEN objvcc_WorkStuRelationTtlEN, string strQuestionTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strQuestionTypeId, 2, convcc_WorkStuRelationTtl.QuestionTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strQuestionTypeId, 2, convcc_WorkStuRelationTtl.QuestionTypeId);
}
objvcc_WorkStuRelationTtlEN.QuestionTypeId = strQuestionTypeId; //题目类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelationTtlEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelationTtl.QuestionTypeId) == false)
{
objvcc_WorkStuRelationTtlEN.dicFldComparisonOp.Add(convcc_WorkStuRelationTtl.QuestionTypeId, strComparisonOp);
}
else
{
objvcc_WorkStuRelationTtlEN.dicFldComparisonOp[convcc_WorkStuRelationTtl.QuestionTypeId] = strComparisonOp;
}
}
return objvcc_WorkStuRelationTtlEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelationTtlEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_WorkStuRelationTtlEN SetQuestionCount(this clsvcc_WorkStuRelationTtlEN objvcc_WorkStuRelationTtlEN, int? intQuestionCount, string strComparisonOp="")
	{
objvcc_WorkStuRelationTtlEN.QuestionCount = intQuestionCount; //问题数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelationTtlEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelationTtl.QuestionCount) == false)
{
objvcc_WorkStuRelationTtlEN.dicFldComparisonOp.Add(convcc_WorkStuRelationTtl.QuestionCount, strComparisonOp);
}
else
{
objvcc_WorkStuRelationTtlEN.dicFldComparisonOp[convcc_WorkStuRelationTtl.QuestionCount] = strComparisonOp;
}
}
return objvcc_WorkStuRelationTtlEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelationTtlENS">源对象</param>
 /// <param name = "objvcc_WorkStuRelationTtlENT">目标对象</param>
 public static void CopyTo(this clsvcc_WorkStuRelationTtlEN objvcc_WorkStuRelationTtlENS, clsvcc_WorkStuRelationTtlEN objvcc_WorkStuRelationTtlENT)
{
try
{
objvcc_WorkStuRelationTtlENT.IdStudentInfo = objvcc_WorkStuRelationTtlENS.IdStudentInfo; //学生流水号
objvcc_WorkStuRelationTtlENT.IdCurrEduCls = objvcc_WorkStuRelationTtlENS.IdCurrEduCls; //教学班流水号
objvcc_WorkStuRelationTtlENT.QuestionTypeId4Course = objvcc_WorkStuRelationTtlENS.QuestionTypeId4Course; //题目类型Id4课程
objvcc_WorkStuRelationTtlENT.QuestionTypeId = objvcc_WorkStuRelationTtlENS.QuestionTypeId; //题目类型Id
objvcc_WorkStuRelationTtlENT.QuestionCount = objvcc_WorkStuRelationTtlENS.QuestionCount; //问题数
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
 /// <param name = "objvcc_WorkStuRelationTtlENS">源对象</param>
 /// <returns>目标对象=>clsvcc_WorkStuRelationTtlEN:objvcc_WorkStuRelationTtlENT</returns>
 public static clsvcc_WorkStuRelationTtlEN CopyTo(this clsvcc_WorkStuRelationTtlEN objvcc_WorkStuRelationTtlENS)
{
try
{
 clsvcc_WorkStuRelationTtlEN objvcc_WorkStuRelationTtlENT = new clsvcc_WorkStuRelationTtlEN()
{
IdStudentInfo = objvcc_WorkStuRelationTtlENS.IdStudentInfo, //学生流水号
IdCurrEduCls = objvcc_WorkStuRelationTtlENS.IdCurrEduCls, //教学班流水号
QuestionTypeId4Course = objvcc_WorkStuRelationTtlENS.QuestionTypeId4Course, //题目类型Id4课程
QuestionTypeId = objvcc_WorkStuRelationTtlENS.QuestionTypeId, //题目类型Id
QuestionCount = objvcc_WorkStuRelationTtlENS.QuestionCount, //问题数
};
 return objvcc_WorkStuRelationTtlENT;
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
public static void CheckProperty4Condition(this clsvcc_WorkStuRelationTtlEN objvcc_WorkStuRelationTtlEN)
{
 clsvcc_WorkStuRelationTtlBL.vcc_WorkStuRelationTtlDA.CheckProperty4Condition(objvcc_WorkStuRelationTtlEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvcc_WorkStuRelationTtlEN objvcc_WorkStuRelationTtlCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvcc_WorkStuRelationTtlCond.IsUpdated(convcc_WorkStuRelationTtl.IdStudentInfo) == true)
{
string strComparisonOpIdStudentInfo = objvcc_WorkStuRelationTtlCond.dicFldComparisonOp[convcc_WorkStuRelationTtl.IdStudentInfo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelationTtl.IdStudentInfo, objvcc_WorkStuRelationTtlCond.IdStudentInfo, strComparisonOpIdStudentInfo);
}
if (objvcc_WorkStuRelationTtlCond.IsUpdated(convcc_WorkStuRelationTtl.IdCurrEduCls) == true)
{
string strComparisonOpIdCurrEduCls = objvcc_WorkStuRelationTtlCond.dicFldComparisonOp[convcc_WorkStuRelationTtl.IdCurrEduCls];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelationTtl.IdCurrEduCls, objvcc_WorkStuRelationTtlCond.IdCurrEduCls, strComparisonOpIdCurrEduCls);
}
if (objvcc_WorkStuRelationTtlCond.IsUpdated(convcc_WorkStuRelationTtl.QuestionTypeId4Course) == true)
{
string strComparisonOpQuestionTypeId4Course = objvcc_WorkStuRelationTtlCond.dicFldComparisonOp[convcc_WorkStuRelationTtl.QuestionTypeId4Course];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelationTtl.QuestionTypeId4Course, objvcc_WorkStuRelationTtlCond.QuestionTypeId4Course, strComparisonOpQuestionTypeId4Course);
}
if (objvcc_WorkStuRelationTtlCond.IsUpdated(convcc_WorkStuRelationTtl.QuestionTypeId) == true)
{
string strComparisonOpQuestionTypeId = objvcc_WorkStuRelationTtlCond.dicFldComparisonOp[convcc_WorkStuRelationTtl.QuestionTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelationTtl.QuestionTypeId, objvcc_WorkStuRelationTtlCond.QuestionTypeId, strComparisonOpQuestionTypeId);
}
if (objvcc_WorkStuRelationTtlCond.IsUpdated(convcc_WorkStuRelationTtl.QuestionCount) == true)
{
string strComparisonOpQuestionCount = objvcc_WorkStuRelationTtlCond.dicFldComparisonOp[convcc_WorkStuRelationTtl.QuestionCount];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_WorkStuRelationTtl.QuestionCount, objvcc_WorkStuRelationTtlCond.QuestionCount, strComparisonOpQuestionCount);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vcc_WorkStuRelationTtl
{
public virtual bool UpdRelaTabDate(string strIdStudentInfo, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// vcc_WorkStuRelationTtl(vcc_WorkStuRelationTtl)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvcc_WorkStuRelationTtlBL
{
public static RelatedActions_vcc_WorkStuRelationTtl relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvcc_WorkStuRelationTtlDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvcc_WorkStuRelationTtlDA vcc_WorkStuRelationTtlDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvcc_WorkStuRelationTtlDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvcc_WorkStuRelationTtlBL()
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
if (string.IsNullOrEmpty(clsvcc_WorkStuRelationTtlEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvcc_WorkStuRelationTtlEN._ConnectString);
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
public static DataTable GetDataTable_vcc_WorkStuRelationTtl(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vcc_WorkStuRelationTtlDA.GetDataTable_vcc_WorkStuRelationTtl(strWhereCond);
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
objDT = vcc_WorkStuRelationTtlDA.GetDataTable(strWhereCond);
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
objDT = vcc_WorkStuRelationTtlDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vcc_WorkStuRelationTtlDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vcc_WorkStuRelationTtlDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vcc_WorkStuRelationTtlDA.GetDataTable_Top(objTopPara);
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
objDT = vcc_WorkStuRelationTtlDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vcc_WorkStuRelationTtlDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vcc_WorkStuRelationTtlDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrIdStudentInfoLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvcc_WorkStuRelationTtlEN> GetObjLstByIdStudentInfoLst(List<string> arrIdStudentInfoLst)
{
List<clsvcc_WorkStuRelationTtlEN> arrObjLst = new List<clsvcc_WorkStuRelationTtlEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrIdStudentInfoLst, true);
 string strWhereCond = string.Format("IdStudentInfo in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_WorkStuRelationTtlEN objvcc_WorkStuRelationTtlEN = new clsvcc_WorkStuRelationTtlEN();
try
{
objvcc_WorkStuRelationTtlEN.IdStudentInfo = objRow[convcc_WorkStuRelationTtl.IdStudentInfo].ToString().Trim(); //学生流水号
objvcc_WorkStuRelationTtlEN.IdCurrEduCls = objRow[convcc_WorkStuRelationTtl.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvcc_WorkStuRelationTtlEN.QuestionTypeId4Course = objRow[convcc_WorkStuRelationTtl.QuestionTypeId4Course].ToString().Trim(); //题目类型Id4课程
objvcc_WorkStuRelationTtlEN.QuestionTypeId = objRow[convcc_WorkStuRelationTtl.QuestionTypeId] == DBNull.Value ? null : objRow[convcc_WorkStuRelationTtl.QuestionTypeId].ToString().Trim(); //题目类型Id
objvcc_WorkStuRelationTtlEN.QuestionCount = objRow[convcc_WorkStuRelationTtl.QuestionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_WorkStuRelationTtl.QuestionCount].ToString().Trim()); //问题数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_WorkStuRelationTtlEN.IdStudentInfo, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_WorkStuRelationTtlEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrIdStudentInfoLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvcc_WorkStuRelationTtlEN> GetObjLstByIdStudentInfoLstCache(List<string> arrIdStudentInfoLst)
{
string strKey = string.Format("{0}", clsvcc_WorkStuRelationTtlEN._CurrTabName);
List<clsvcc_WorkStuRelationTtlEN> arrvcc_WorkStuRelationTtlObjLstCache = GetObjLstCache();
IEnumerable <clsvcc_WorkStuRelationTtlEN> arrvcc_WorkStuRelationTtlObjLst_Sel =
arrvcc_WorkStuRelationTtlObjLstCache
.Where(x => arrIdStudentInfoLst.Contains(x.IdStudentInfo));
return arrvcc_WorkStuRelationTtlObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvcc_WorkStuRelationTtlEN> GetObjLst(string strWhereCond)
{
List<clsvcc_WorkStuRelationTtlEN> arrObjLst = new List<clsvcc_WorkStuRelationTtlEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_WorkStuRelationTtlEN objvcc_WorkStuRelationTtlEN = new clsvcc_WorkStuRelationTtlEN();
try
{
objvcc_WorkStuRelationTtlEN.IdStudentInfo = objRow[convcc_WorkStuRelationTtl.IdStudentInfo].ToString().Trim(); //学生流水号
objvcc_WorkStuRelationTtlEN.IdCurrEduCls = objRow[convcc_WorkStuRelationTtl.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvcc_WorkStuRelationTtlEN.QuestionTypeId4Course = objRow[convcc_WorkStuRelationTtl.QuestionTypeId4Course].ToString().Trim(); //题目类型Id4课程
objvcc_WorkStuRelationTtlEN.QuestionTypeId = objRow[convcc_WorkStuRelationTtl.QuestionTypeId] == DBNull.Value ? null : objRow[convcc_WorkStuRelationTtl.QuestionTypeId].ToString().Trim(); //题目类型Id
objvcc_WorkStuRelationTtlEN.QuestionCount = objRow[convcc_WorkStuRelationTtl.QuestionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_WorkStuRelationTtl.QuestionCount].ToString().Trim()); //问题数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_WorkStuRelationTtlEN.IdStudentInfo, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_WorkStuRelationTtlEN);
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
public static List<clsvcc_WorkStuRelationTtlEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvcc_WorkStuRelationTtlEN> arrObjLst = new List<clsvcc_WorkStuRelationTtlEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_WorkStuRelationTtlEN objvcc_WorkStuRelationTtlEN = new clsvcc_WorkStuRelationTtlEN();
try
{
objvcc_WorkStuRelationTtlEN.IdStudentInfo = objRow[convcc_WorkStuRelationTtl.IdStudentInfo].ToString().Trim(); //学生流水号
objvcc_WorkStuRelationTtlEN.IdCurrEduCls = objRow[convcc_WorkStuRelationTtl.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvcc_WorkStuRelationTtlEN.QuestionTypeId4Course = objRow[convcc_WorkStuRelationTtl.QuestionTypeId4Course].ToString().Trim(); //题目类型Id4课程
objvcc_WorkStuRelationTtlEN.QuestionTypeId = objRow[convcc_WorkStuRelationTtl.QuestionTypeId] == DBNull.Value ? null : objRow[convcc_WorkStuRelationTtl.QuestionTypeId].ToString().Trim(); //题目类型Id
objvcc_WorkStuRelationTtlEN.QuestionCount = objRow[convcc_WorkStuRelationTtl.QuestionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_WorkStuRelationTtl.QuestionCount].ToString().Trim()); //问题数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_WorkStuRelationTtlEN.IdStudentInfo, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_WorkStuRelationTtlEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelationTtlCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvcc_WorkStuRelationTtlEN> GetSubObjLstCache(clsvcc_WorkStuRelationTtlEN objvcc_WorkStuRelationTtlCond)
{
List<clsvcc_WorkStuRelationTtlEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvcc_WorkStuRelationTtlEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convcc_WorkStuRelationTtl.AttributeName)
{
if (objvcc_WorkStuRelationTtlCond.IsUpdated(strFldName) == false) continue;
if (objvcc_WorkStuRelationTtlCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvcc_WorkStuRelationTtlCond[strFldName].ToString());
}
else
{
if (objvcc_WorkStuRelationTtlCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvcc_WorkStuRelationTtlCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvcc_WorkStuRelationTtlCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvcc_WorkStuRelationTtlCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvcc_WorkStuRelationTtlCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvcc_WorkStuRelationTtlCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvcc_WorkStuRelationTtlCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvcc_WorkStuRelationTtlCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvcc_WorkStuRelationTtlCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvcc_WorkStuRelationTtlCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvcc_WorkStuRelationTtlCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvcc_WorkStuRelationTtlCond[strFldName]));
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
public static List<clsvcc_WorkStuRelationTtlEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvcc_WorkStuRelationTtlEN> arrObjLst = new List<clsvcc_WorkStuRelationTtlEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_WorkStuRelationTtlEN objvcc_WorkStuRelationTtlEN = new clsvcc_WorkStuRelationTtlEN();
try
{
objvcc_WorkStuRelationTtlEN.IdStudentInfo = objRow[convcc_WorkStuRelationTtl.IdStudentInfo].ToString().Trim(); //学生流水号
objvcc_WorkStuRelationTtlEN.IdCurrEduCls = objRow[convcc_WorkStuRelationTtl.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvcc_WorkStuRelationTtlEN.QuestionTypeId4Course = objRow[convcc_WorkStuRelationTtl.QuestionTypeId4Course].ToString().Trim(); //题目类型Id4课程
objvcc_WorkStuRelationTtlEN.QuestionTypeId = objRow[convcc_WorkStuRelationTtl.QuestionTypeId] == DBNull.Value ? null : objRow[convcc_WorkStuRelationTtl.QuestionTypeId].ToString().Trim(); //题目类型Id
objvcc_WorkStuRelationTtlEN.QuestionCount = objRow[convcc_WorkStuRelationTtl.QuestionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_WorkStuRelationTtl.QuestionCount].ToString().Trim()); //问题数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_WorkStuRelationTtlEN.IdStudentInfo, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_WorkStuRelationTtlEN);
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
public static List<clsvcc_WorkStuRelationTtlEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvcc_WorkStuRelationTtlEN> arrObjLst = new List<clsvcc_WorkStuRelationTtlEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_WorkStuRelationTtlEN objvcc_WorkStuRelationTtlEN = new clsvcc_WorkStuRelationTtlEN();
try
{
objvcc_WorkStuRelationTtlEN.IdStudentInfo = objRow[convcc_WorkStuRelationTtl.IdStudentInfo].ToString().Trim(); //学生流水号
objvcc_WorkStuRelationTtlEN.IdCurrEduCls = objRow[convcc_WorkStuRelationTtl.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvcc_WorkStuRelationTtlEN.QuestionTypeId4Course = objRow[convcc_WorkStuRelationTtl.QuestionTypeId4Course].ToString().Trim(); //题目类型Id4课程
objvcc_WorkStuRelationTtlEN.QuestionTypeId = objRow[convcc_WorkStuRelationTtl.QuestionTypeId] == DBNull.Value ? null : objRow[convcc_WorkStuRelationTtl.QuestionTypeId].ToString().Trim(); //题目类型Id
objvcc_WorkStuRelationTtlEN.QuestionCount = objRow[convcc_WorkStuRelationTtl.QuestionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_WorkStuRelationTtl.QuestionCount].ToString().Trim()); //问题数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_WorkStuRelationTtlEN.IdStudentInfo, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_WorkStuRelationTtlEN);
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
List<clsvcc_WorkStuRelationTtlEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvcc_WorkStuRelationTtlEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvcc_WorkStuRelationTtlEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvcc_WorkStuRelationTtlEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvcc_WorkStuRelationTtlEN> arrObjLst = new List<clsvcc_WorkStuRelationTtlEN>(); 
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
	clsvcc_WorkStuRelationTtlEN objvcc_WorkStuRelationTtlEN = new clsvcc_WorkStuRelationTtlEN();
try
{
objvcc_WorkStuRelationTtlEN.IdStudentInfo = objRow[convcc_WorkStuRelationTtl.IdStudentInfo].ToString().Trim(); //学生流水号
objvcc_WorkStuRelationTtlEN.IdCurrEduCls = objRow[convcc_WorkStuRelationTtl.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvcc_WorkStuRelationTtlEN.QuestionTypeId4Course = objRow[convcc_WorkStuRelationTtl.QuestionTypeId4Course].ToString().Trim(); //题目类型Id4课程
objvcc_WorkStuRelationTtlEN.QuestionTypeId = objRow[convcc_WorkStuRelationTtl.QuestionTypeId] == DBNull.Value ? null : objRow[convcc_WorkStuRelationTtl.QuestionTypeId].ToString().Trim(); //题目类型Id
objvcc_WorkStuRelationTtlEN.QuestionCount = objRow[convcc_WorkStuRelationTtl.QuestionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_WorkStuRelationTtl.QuestionCount].ToString().Trim()); //问题数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_WorkStuRelationTtlEN.IdStudentInfo, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_WorkStuRelationTtlEN);
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
public static List<clsvcc_WorkStuRelationTtlEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvcc_WorkStuRelationTtlEN> arrObjLst = new List<clsvcc_WorkStuRelationTtlEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_WorkStuRelationTtlEN objvcc_WorkStuRelationTtlEN = new clsvcc_WorkStuRelationTtlEN();
try
{
objvcc_WorkStuRelationTtlEN.IdStudentInfo = objRow[convcc_WorkStuRelationTtl.IdStudentInfo].ToString().Trim(); //学生流水号
objvcc_WorkStuRelationTtlEN.IdCurrEduCls = objRow[convcc_WorkStuRelationTtl.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvcc_WorkStuRelationTtlEN.QuestionTypeId4Course = objRow[convcc_WorkStuRelationTtl.QuestionTypeId4Course].ToString().Trim(); //题目类型Id4课程
objvcc_WorkStuRelationTtlEN.QuestionTypeId = objRow[convcc_WorkStuRelationTtl.QuestionTypeId] == DBNull.Value ? null : objRow[convcc_WorkStuRelationTtl.QuestionTypeId].ToString().Trim(); //题目类型Id
objvcc_WorkStuRelationTtlEN.QuestionCount = objRow[convcc_WorkStuRelationTtl.QuestionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_WorkStuRelationTtl.QuestionCount].ToString().Trim()); //问题数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_WorkStuRelationTtlEN.IdStudentInfo, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_WorkStuRelationTtlEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvcc_WorkStuRelationTtlEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvcc_WorkStuRelationTtlEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvcc_WorkStuRelationTtlEN> arrObjLst = new List<clsvcc_WorkStuRelationTtlEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_WorkStuRelationTtlEN objvcc_WorkStuRelationTtlEN = new clsvcc_WorkStuRelationTtlEN();
try
{
objvcc_WorkStuRelationTtlEN.IdStudentInfo = objRow[convcc_WorkStuRelationTtl.IdStudentInfo].ToString().Trim(); //学生流水号
objvcc_WorkStuRelationTtlEN.IdCurrEduCls = objRow[convcc_WorkStuRelationTtl.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvcc_WorkStuRelationTtlEN.QuestionTypeId4Course = objRow[convcc_WorkStuRelationTtl.QuestionTypeId4Course].ToString().Trim(); //题目类型Id4课程
objvcc_WorkStuRelationTtlEN.QuestionTypeId = objRow[convcc_WorkStuRelationTtl.QuestionTypeId] == DBNull.Value ? null : objRow[convcc_WorkStuRelationTtl.QuestionTypeId].ToString().Trim(); //题目类型Id
objvcc_WorkStuRelationTtlEN.QuestionCount = objRow[convcc_WorkStuRelationTtl.QuestionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_WorkStuRelationTtl.QuestionCount].ToString().Trim()); //问题数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_WorkStuRelationTtlEN.IdStudentInfo, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_WorkStuRelationTtlEN);
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
public static List<clsvcc_WorkStuRelationTtlEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvcc_WorkStuRelationTtlEN> arrObjLst = new List<clsvcc_WorkStuRelationTtlEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_WorkStuRelationTtlEN objvcc_WorkStuRelationTtlEN = new clsvcc_WorkStuRelationTtlEN();
try
{
objvcc_WorkStuRelationTtlEN.IdStudentInfo = objRow[convcc_WorkStuRelationTtl.IdStudentInfo].ToString().Trim(); //学生流水号
objvcc_WorkStuRelationTtlEN.IdCurrEduCls = objRow[convcc_WorkStuRelationTtl.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvcc_WorkStuRelationTtlEN.QuestionTypeId4Course = objRow[convcc_WorkStuRelationTtl.QuestionTypeId4Course].ToString().Trim(); //题目类型Id4课程
objvcc_WorkStuRelationTtlEN.QuestionTypeId = objRow[convcc_WorkStuRelationTtl.QuestionTypeId] == DBNull.Value ? null : objRow[convcc_WorkStuRelationTtl.QuestionTypeId].ToString().Trim(); //题目类型Id
objvcc_WorkStuRelationTtlEN.QuestionCount = objRow[convcc_WorkStuRelationTtl.QuestionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_WorkStuRelationTtl.QuestionCount].ToString().Trim()); //问题数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_WorkStuRelationTtlEN.IdStudentInfo, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_WorkStuRelationTtlEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvcc_WorkStuRelationTtlEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvcc_WorkStuRelationTtlEN> arrObjLst = new List<clsvcc_WorkStuRelationTtlEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_WorkStuRelationTtlEN objvcc_WorkStuRelationTtlEN = new clsvcc_WorkStuRelationTtlEN();
try
{
objvcc_WorkStuRelationTtlEN.IdStudentInfo = objRow[convcc_WorkStuRelationTtl.IdStudentInfo].ToString().Trim(); //学生流水号
objvcc_WorkStuRelationTtlEN.IdCurrEduCls = objRow[convcc_WorkStuRelationTtl.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvcc_WorkStuRelationTtlEN.QuestionTypeId4Course = objRow[convcc_WorkStuRelationTtl.QuestionTypeId4Course].ToString().Trim(); //题目类型Id4课程
objvcc_WorkStuRelationTtlEN.QuestionTypeId = objRow[convcc_WorkStuRelationTtl.QuestionTypeId] == DBNull.Value ? null : objRow[convcc_WorkStuRelationTtl.QuestionTypeId].ToString().Trim(); //题目类型Id
objvcc_WorkStuRelationTtlEN.QuestionCount = objRow[convcc_WorkStuRelationTtl.QuestionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_WorkStuRelationTtl.QuestionCount].ToString().Trim()); //问题数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_WorkStuRelationTtlEN.IdStudentInfo, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_WorkStuRelationTtlEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelationTtlEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool Getvcc_WorkStuRelationTtl(ref clsvcc_WorkStuRelationTtlEN objvcc_WorkStuRelationTtlEN)
{
bool bolResult = vcc_WorkStuRelationTtlDA.Getvcc_WorkStuRelationTtl(ref objvcc_WorkStuRelationTtlEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strIdStudentInfo">表关键字</param>
 /// <returns>表对象</returns>
public static clsvcc_WorkStuRelationTtlEN GetObjByIdStudentInfo(string strIdStudentInfo)
{
if (strIdStudentInfo.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strIdStudentInfo]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strIdStudentInfo) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strIdStudentInfo]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsvcc_WorkStuRelationTtlEN objvcc_WorkStuRelationTtlEN = vcc_WorkStuRelationTtlDA.GetObjByIdStudentInfo(strIdStudentInfo);
return objvcc_WorkStuRelationTtlEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvcc_WorkStuRelationTtlEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvcc_WorkStuRelationTtlEN objvcc_WorkStuRelationTtlEN = vcc_WorkStuRelationTtlDA.GetFirstObj(strWhereCond);
 return objvcc_WorkStuRelationTtlEN;
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
public static clsvcc_WorkStuRelationTtlEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvcc_WorkStuRelationTtlEN objvcc_WorkStuRelationTtlEN = vcc_WorkStuRelationTtlDA.GetObjByDataRow(objRow);
 return objvcc_WorkStuRelationTtlEN;
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
public static clsvcc_WorkStuRelationTtlEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvcc_WorkStuRelationTtlEN objvcc_WorkStuRelationTtlEN = vcc_WorkStuRelationTtlDA.GetObjByDataRow(objRow);
 return objvcc_WorkStuRelationTtlEN;
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
 /// <param name = "strIdStudentInfo">所给的关键字</param>
 /// <param name = "lstvcc_WorkStuRelationTtlObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvcc_WorkStuRelationTtlEN GetObjByIdStudentInfoFromList(string strIdStudentInfo, List<clsvcc_WorkStuRelationTtlEN> lstvcc_WorkStuRelationTtlObjLst)
{
foreach (clsvcc_WorkStuRelationTtlEN objvcc_WorkStuRelationTtlEN in lstvcc_WorkStuRelationTtlObjLst)
{
if (objvcc_WorkStuRelationTtlEN.IdStudentInfo == strIdStudentInfo)
{
return objvcc_WorkStuRelationTtlEN;
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
 string strIdStudentInfo;
 try
 {
 strIdStudentInfo = new clsvcc_WorkStuRelationTtlDA().GetFirstID(strWhereCond);
 return strIdStudentInfo;
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
 arrList = vcc_WorkStuRelationTtlDA.GetID(strWhereCond);
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
bool bolIsExist = vcc_WorkStuRelationTtlDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strIdStudentInfo">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strIdStudentInfo)
{
if (string.IsNullOrEmpty(strIdStudentInfo) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strIdStudentInfo]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = vcc_WorkStuRelationTtlDA.IsExist(strIdStudentInfo);
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
 bolIsExist = clsvcc_WorkStuRelationTtlDA.IsExistTable();
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
 bolIsExist = vcc_WorkStuRelationTtlDA.IsExistTable(strTabName);
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
 /// <param name = "objvcc_WorkStuRelationTtlENS">源对象</param>
 /// <param name = "objvcc_WorkStuRelationTtlENT">目标对象</param>
 public static void CopyTo(clsvcc_WorkStuRelationTtlEN objvcc_WorkStuRelationTtlENS, clsvcc_WorkStuRelationTtlEN objvcc_WorkStuRelationTtlENT)
{
try
{
objvcc_WorkStuRelationTtlENT.IdStudentInfo = objvcc_WorkStuRelationTtlENS.IdStudentInfo; //学生流水号
objvcc_WorkStuRelationTtlENT.IdCurrEduCls = objvcc_WorkStuRelationTtlENS.IdCurrEduCls; //教学班流水号
objvcc_WorkStuRelationTtlENT.QuestionTypeId4Course = objvcc_WorkStuRelationTtlENS.QuestionTypeId4Course; //题目类型Id4课程
objvcc_WorkStuRelationTtlENT.QuestionTypeId = objvcc_WorkStuRelationTtlENS.QuestionTypeId; //题目类型Id
objvcc_WorkStuRelationTtlENT.QuestionCount = objvcc_WorkStuRelationTtlENS.QuestionCount; //问题数
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
 /// <param name = "objvcc_WorkStuRelationTtlEN">源简化对象</param>
 public static void SetUpdFlag(clsvcc_WorkStuRelationTtlEN objvcc_WorkStuRelationTtlEN)
{
try
{
objvcc_WorkStuRelationTtlEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvcc_WorkStuRelationTtlEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convcc_WorkStuRelationTtl.IdStudentInfo, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkStuRelationTtlEN.IdStudentInfo = objvcc_WorkStuRelationTtlEN.IdStudentInfo; //学生流水号
}
if (arrFldSet.Contains(convcc_WorkStuRelationTtl.IdCurrEduCls, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkStuRelationTtlEN.IdCurrEduCls = objvcc_WorkStuRelationTtlEN.IdCurrEduCls; //教学班流水号
}
if (arrFldSet.Contains(convcc_WorkStuRelationTtl.QuestionTypeId4Course, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkStuRelationTtlEN.QuestionTypeId4Course = objvcc_WorkStuRelationTtlEN.QuestionTypeId4Course; //题目类型Id4课程
}
if (arrFldSet.Contains(convcc_WorkStuRelationTtl.QuestionTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkStuRelationTtlEN.QuestionTypeId = objvcc_WorkStuRelationTtlEN.QuestionTypeId == "[null]" ? null :  objvcc_WorkStuRelationTtlEN.QuestionTypeId; //题目类型Id
}
if (arrFldSet.Contains(convcc_WorkStuRelationTtl.QuestionCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_WorkStuRelationTtlEN.QuestionCount = objvcc_WorkStuRelationTtlEN.QuestionCount; //问题数
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
 /// <param name = "objvcc_WorkStuRelationTtlEN">源简化对象</param>
 public static void AccessFldValueNull(clsvcc_WorkStuRelationTtlEN objvcc_WorkStuRelationTtlEN)
{
try
{
if (objvcc_WorkStuRelationTtlEN.QuestionTypeId == "[null]") objvcc_WorkStuRelationTtlEN.QuestionTypeId = null; //题目类型Id
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
public static void CheckProperty4Condition(clsvcc_WorkStuRelationTtlEN objvcc_WorkStuRelationTtlEN)
{
 vcc_WorkStuRelationTtlDA.CheckProperty4Condition(objvcc_WorkStuRelationTtlEN);
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
if (clscc_WorkStuRelationBL.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_WorkStuRelationBL没有刷新缓存机制(clscc_WorkStuRelationBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzClgBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzClgBL没有刷新缓存机制(clsXzClgBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzMajorBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzMajorBL没有刷新缓存机制(clsXzMajorBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzUniZoneBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzUniZoneBL没有刷新缓存机制(clsXzUniZoneBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsSexBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsSexBL没有刷新缓存机制(clsSexBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsRsEthnicBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsRsEthnicBL没有刷新缓存机制(clsRsEthnicBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsRsPoliticsBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsRsPoliticsBL没有刷新缓存机制(clsRsPoliticsBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzGradeBaseBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzGradeBaseBL没有刷新缓存机制(clsXzGradeBaseBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsStudentInfoBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsStudentInfoBL没有刷新缓存机制(clsStudentInfoBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsRsStuTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsRsStuTypeBL没有刷新缓存机制(clsRsStuTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsCurrEduClsBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsCurrEduClsBL没有刷新缓存机制(clsCurrEduClsBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_WorkEduClsRelaBL.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_WorkEduClsRelaBL没有刷新缓存机制(clscc_WorkEduClsRelaBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsWorkTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsWorkTypeBL没有刷新缓存机制(clsWorkTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzAdminClsBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzAdminClsBL没有刷新缓存机制(clsXzAdminClsBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzAdminClsTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzAdminClsTypeBL没有刷新缓存机制(clsXzAdminClsTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsQuestionnaireBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsQuestionnaireBL没有刷新缓存机制(clsQuestionnaireBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsAnswerModeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsAnswerModeBL没有刷新缓存机制(clsAnswerModeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsAnswerTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsAnswerTypeBL没有刷新缓存机制(clsAnswerTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsQuestionTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsQuestionTypeBL没有刷新缓存机制(clsQuestionTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_CourseBL.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_CourseBL没有刷新缓存机制(clscc_CourseBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_ExamGradeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_ExamGradeBL没有刷新缓存机制(clscc_ExamGradeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsQuestionType4CourseBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsQuestionType4CourseBL没有刷新缓存机制(clsQuestionType4CourseBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsStudyLevelBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsStudyLevelBL没有刷新缓存机制(clsStudyLevelBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_CourseChapterBL.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_CourseChapterBL没有刷新缓存机制(clscc_CourseChapterBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_CourseTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_CourseTypeBL没有刷新缓存机制(clscc_CourseTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_ExcellentTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_ExcellentTypeBL没有刷新缓存机制(clscc_ExcellentTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_ThemesBL.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_ThemesBL没有刷新缓存机制(clscc_ThemesBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_CourseIsLikeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_CourseIsLikeBL没有刷新缓存机制(clscc_CourseIsLikeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by IdStudentInfo");
//if (arrvcc_WorkStuRelationTtlObjLstCache == null)
//{
//arrvcc_WorkStuRelationTtlObjLstCache = vcc_WorkStuRelationTtlDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strIdStudentInfo">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvcc_WorkStuRelationTtlEN GetObjByIdStudentInfoCache(string strIdStudentInfo)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvcc_WorkStuRelationTtlEN._CurrTabName);
List<clsvcc_WorkStuRelationTtlEN> arrvcc_WorkStuRelationTtlObjLstCache = GetObjLstCache();
IEnumerable <clsvcc_WorkStuRelationTtlEN> arrvcc_WorkStuRelationTtlObjLst_Sel =
arrvcc_WorkStuRelationTtlObjLstCache
.Where(x=> x.IdStudentInfo == strIdStudentInfo 
);
if (arrvcc_WorkStuRelationTtlObjLst_Sel.Count() == 0)
{
   clsvcc_WorkStuRelationTtlEN obj = clsvcc_WorkStuRelationTtlBL.GetObjByIdStudentInfo(strIdStudentInfo);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvcc_WorkStuRelationTtlObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvcc_WorkStuRelationTtlEN> GetAllvcc_WorkStuRelationTtlObjLstCache()
{
//获取缓存中的对象列表
List<clsvcc_WorkStuRelationTtlEN> arrvcc_WorkStuRelationTtlObjLstCache = GetObjLstCache(); 
return arrvcc_WorkStuRelationTtlObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvcc_WorkStuRelationTtlEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvcc_WorkStuRelationTtlEN._CurrTabName);
List<clsvcc_WorkStuRelationTtlEN> arrvcc_WorkStuRelationTtlObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvcc_WorkStuRelationTtlObjLstCache;
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
string strKey = string.Format("{0}", clsvcc_WorkStuRelationTtlEN._CurrTabName);
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
public static string Func(string strInFldName, string strOutFldName, string strIdStudentInfo)
{
if (strInFldName != convcc_WorkStuRelationTtl.IdStudentInfo)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convcc_WorkStuRelationTtl.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convcc_WorkStuRelationTtl.AttributeName));
throw new Exception(strMsg);
}
var objvcc_WorkStuRelationTtl = clsvcc_WorkStuRelationTtlBL.GetObjByIdStudentInfoCache(strIdStudentInfo);
if (objvcc_WorkStuRelationTtl == null) return "";
return objvcc_WorkStuRelationTtl[strOutFldName].ToString();
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
int intRecCount = clsvcc_WorkStuRelationTtlDA.GetRecCount(strTabName);
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
int intRecCount = clsvcc_WorkStuRelationTtlDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvcc_WorkStuRelationTtlDA.GetRecCount();
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
int intRecCount = clsvcc_WorkStuRelationTtlDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelationTtlCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvcc_WorkStuRelationTtlEN objvcc_WorkStuRelationTtlCond)
{
List<clsvcc_WorkStuRelationTtlEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvcc_WorkStuRelationTtlEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convcc_WorkStuRelationTtl.AttributeName)
{
if (objvcc_WorkStuRelationTtlCond.IsUpdated(strFldName) == false) continue;
if (objvcc_WorkStuRelationTtlCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvcc_WorkStuRelationTtlCond[strFldName].ToString());
}
else
{
if (objvcc_WorkStuRelationTtlCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvcc_WorkStuRelationTtlCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvcc_WorkStuRelationTtlCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvcc_WorkStuRelationTtlCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvcc_WorkStuRelationTtlCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvcc_WorkStuRelationTtlCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvcc_WorkStuRelationTtlCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvcc_WorkStuRelationTtlCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvcc_WorkStuRelationTtlCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvcc_WorkStuRelationTtlCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvcc_WorkStuRelationTtlCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvcc_WorkStuRelationTtlCond[strFldName]));
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
 List<string> arrList = clsvcc_WorkStuRelationTtlDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vcc_WorkStuRelationTtlDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vcc_WorkStuRelationTtlDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}