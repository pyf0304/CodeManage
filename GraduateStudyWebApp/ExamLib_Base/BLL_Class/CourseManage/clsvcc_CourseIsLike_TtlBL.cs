﻿
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvcc_CourseIsLike_TtlBL
 表名:vcc_CourseIsLike_Ttl(01120201)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:44:50
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:课程管理(CourseManage)
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
public static class  clsvcc_CourseIsLike_TtlBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strCourseId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvcc_CourseIsLike_TtlEN GetObj(this K_CourseId_vcc_CourseIsLike_Ttl myKey)
{
clsvcc_CourseIsLike_TtlEN objvcc_CourseIsLike_TtlEN = clsvcc_CourseIsLike_TtlBL.vcc_CourseIsLike_TtlDA.GetObjByCourseId(myKey.Value);
return objvcc_CourseIsLike_TtlEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseIsLike_TtlEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseIsLike_TtlEN SetCourseId(this clsvcc_CourseIsLike_TtlEN objvcc_CourseIsLike_TtlEN, string strCourseId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseId, 8, convcc_CourseIsLike_Ttl.CourseId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCourseId, 8, convcc_CourseIsLike_Ttl.CourseId);
}
objvcc_CourseIsLike_TtlEN.CourseId = strCourseId; //课程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseIsLike_TtlEN.dicFldComparisonOp.ContainsKey(convcc_CourseIsLike_Ttl.CourseId) == false)
{
objvcc_CourseIsLike_TtlEN.dicFldComparisonOp.Add(convcc_CourseIsLike_Ttl.CourseId, strComparisonOp);
}
else
{
objvcc_CourseIsLike_TtlEN.dicFldComparisonOp[convcc_CourseIsLike_Ttl.CourseId] = strComparisonOp;
}
}
return objvcc_CourseIsLike_TtlEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseIsLike_TtlEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseIsLike_TtlEN SetLikeCount(this clsvcc_CourseIsLike_TtlEN objvcc_CourseIsLike_TtlEN, int? intLikeCount, string strComparisonOp="")
	{
objvcc_CourseIsLike_TtlEN.LikeCount = intLikeCount; //LikeCount
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseIsLike_TtlEN.dicFldComparisonOp.ContainsKey(convcc_CourseIsLike_Ttl.LikeCount) == false)
{
objvcc_CourseIsLike_TtlEN.dicFldComparisonOp.Add(convcc_CourseIsLike_Ttl.LikeCount, strComparisonOp);
}
else
{
objvcc_CourseIsLike_TtlEN.dicFldComparisonOp[convcc_CourseIsLike_Ttl.LikeCount] = strComparisonOp;
}
}
return objvcc_CourseIsLike_TtlEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvcc_CourseIsLike_TtlENS">源对象</param>
 /// <param name = "objvcc_CourseIsLike_TtlENT">目标对象</param>
 public static void CopyTo(this clsvcc_CourseIsLike_TtlEN objvcc_CourseIsLike_TtlENS, clsvcc_CourseIsLike_TtlEN objvcc_CourseIsLike_TtlENT)
{
try
{
objvcc_CourseIsLike_TtlENT.CourseId = objvcc_CourseIsLike_TtlENS.CourseId; //课程Id
objvcc_CourseIsLike_TtlENT.LikeCount = objvcc_CourseIsLike_TtlENS.LikeCount; //LikeCount
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
 /// <param name = "objvcc_CourseIsLike_TtlENS">源对象</param>
 /// <returns>目标对象=>clsvcc_CourseIsLike_TtlEN:objvcc_CourseIsLike_TtlENT</returns>
 public static clsvcc_CourseIsLike_TtlEN CopyTo(this clsvcc_CourseIsLike_TtlEN objvcc_CourseIsLike_TtlENS)
{
try
{
 clsvcc_CourseIsLike_TtlEN objvcc_CourseIsLike_TtlENT = new clsvcc_CourseIsLike_TtlEN()
{
CourseId = objvcc_CourseIsLike_TtlENS.CourseId, //课程Id
LikeCount = objvcc_CourseIsLike_TtlENS.LikeCount, //LikeCount
};
 return objvcc_CourseIsLike_TtlENT;
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
public static void CheckProperty4Condition(this clsvcc_CourseIsLike_TtlEN objvcc_CourseIsLike_TtlEN)
{
 clsvcc_CourseIsLike_TtlBL.vcc_CourseIsLike_TtlDA.CheckProperty4Condition(objvcc_CourseIsLike_TtlEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvcc_CourseIsLike_TtlEN objvcc_CourseIsLike_TtlCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvcc_CourseIsLike_TtlCond.IsUpdated(convcc_CourseIsLike_Ttl.CourseId) == true)
{
string strComparisonOpCourseId = objvcc_CourseIsLike_TtlCond.dicFldComparisonOp[convcc_CourseIsLike_Ttl.CourseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseIsLike_Ttl.CourseId, objvcc_CourseIsLike_TtlCond.CourseId, strComparisonOpCourseId);
}
if (objvcc_CourseIsLike_TtlCond.IsUpdated(convcc_CourseIsLike_Ttl.LikeCount) == true)
{
string strComparisonOpLikeCount = objvcc_CourseIsLike_TtlCond.dicFldComparisonOp[convcc_CourseIsLike_Ttl.LikeCount];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_CourseIsLike_Ttl.LikeCount, objvcc_CourseIsLike_TtlCond.LikeCount, strComparisonOpLikeCount);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vcc_CourseIsLike_Ttl
{
public virtual bool UpdRelaTabDate(string strCourseId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// vcc_CourseIsLike_Ttl(vcc_CourseIsLike_Ttl)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvcc_CourseIsLike_TtlBL
{
public static RelatedActions_vcc_CourseIsLike_Ttl relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvcc_CourseIsLike_TtlDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvcc_CourseIsLike_TtlDA vcc_CourseIsLike_TtlDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvcc_CourseIsLike_TtlDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvcc_CourseIsLike_TtlBL()
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
if (string.IsNullOrEmpty(clsvcc_CourseIsLike_TtlEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvcc_CourseIsLike_TtlEN._ConnectString);
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
public static DataTable GetDataTable_vcc_CourseIsLike_Ttl(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vcc_CourseIsLike_TtlDA.GetDataTable_vcc_CourseIsLike_Ttl(strWhereCond);
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
objDT = vcc_CourseIsLike_TtlDA.GetDataTable(strWhereCond);
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
objDT = vcc_CourseIsLike_TtlDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vcc_CourseIsLike_TtlDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vcc_CourseIsLike_TtlDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vcc_CourseIsLike_TtlDA.GetDataTable_Top(objTopPara);
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
objDT = vcc_CourseIsLike_TtlDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vcc_CourseIsLike_TtlDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vcc_CourseIsLike_TtlDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrCourseIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvcc_CourseIsLike_TtlEN> GetObjLstByCourseIdLst(List<string> arrCourseIdLst)
{
List<clsvcc_CourseIsLike_TtlEN> arrObjLst = new List<clsvcc_CourseIsLike_TtlEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrCourseIdLst, true);
 string strWhereCond = string.Format("CourseId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_CourseIsLike_TtlEN objvcc_CourseIsLike_TtlEN = new clsvcc_CourseIsLike_TtlEN();
try
{
objvcc_CourseIsLike_TtlEN.CourseId = objRow[convcc_CourseIsLike_Ttl.CourseId].ToString().Trim(); //课程Id
objvcc_CourseIsLike_TtlEN.LikeCount = objRow[convcc_CourseIsLike_Ttl.LikeCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseIsLike_Ttl.LikeCount].ToString().Trim()); //LikeCount
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_CourseIsLike_TtlEN.CourseId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_CourseIsLike_TtlEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrCourseIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvcc_CourseIsLike_TtlEN> GetObjLstByCourseIdLstCache(List<string> arrCourseIdLst)
{
string strKey = string.Format("{0}", clsvcc_CourseIsLike_TtlEN._CurrTabName);
List<clsvcc_CourseIsLike_TtlEN> arrvcc_CourseIsLike_TtlObjLstCache = GetObjLstCache();
IEnumerable <clsvcc_CourseIsLike_TtlEN> arrvcc_CourseIsLike_TtlObjLst_Sel =
arrvcc_CourseIsLike_TtlObjLstCache
.Where(x => arrCourseIdLst.Contains(x.CourseId));
return arrvcc_CourseIsLike_TtlObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvcc_CourseIsLike_TtlEN> GetObjLst(string strWhereCond)
{
List<clsvcc_CourseIsLike_TtlEN> arrObjLst = new List<clsvcc_CourseIsLike_TtlEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_CourseIsLike_TtlEN objvcc_CourseIsLike_TtlEN = new clsvcc_CourseIsLike_TtlEN();
try
{
objvcc_CourseIsLike_TtlEN.CourseId = objRow[convcc_CourseIsLike_Ttl.CourseId].ToString().Trim(); //课程Id
objvcc_CourseIsLike_TtlEN.LikeCount = objRow[convcc_CourseIsLike_Ttl.LikeCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseIsLike_Ttl.LikeCount].ToString().Trim()); //LikeCount
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_CourseIsLike_TtlEN.CourseId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_CourseIsLike_TtlEN);
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
public static List<clsvcc_CourseIsLike_TtlEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvcc_CourseIsLike_TtlEN> arrObjLst = new List<clsvcc_CourseIsLike_TtlEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_CourseIsLike_TtlEN objvcc_CourseIsLike_TtlEN = new clsvcc_CourseIsLike_TtlEN();
try
{
objvcc_CourseIsLike_TtlEN.CourseId = objRow[convcc_CourseIsLike_Ttl.CourseId].ToString().Trim(); //课程Id
objvcc_CourseIsLike_TtlEN.LikeCount = objRow[convcc_CourseIsLike_Ttl.LikeCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseIsLike_Ttl.LikeCount].ToString().Trim()); //LikeCount
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_CourseIsLike_TtlEN.CourseId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_CourseIsLike_TtlEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvcc_CourseIsLike_TtlCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvcc_CourseIsLike_TtlEN> GetSubObjLstCache(clsvcc_CourseIsLike_TtlEN objvcc_CourseIsLike_TtlCond)
{
List<clsvcc_CourseIsLike_TtlEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvcc_CourseIsLike_TtlEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convcc_CourseIsLike_Ttl.AttributeName)
{
if (objvcc_CourseIsLike_TtlCond.IsUpdated(strFldName) == false) continue;
if (objvcc_CourseIsLike_TtlCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvcc_CourseIsLike_TtlCond[strFldName].ToString());
}
else
{
if (objvcc_CourseIsLike_TtlCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvcc_CourseIsLike_TtlCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvcc_CourseIsLike_TtlCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvcc_CourseIsLike_TtlCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvcc_CourseIsLike_TtlCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvcc_CourseIsLike_TtlCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvcc_CourseIsLike_TtlCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvcc_CourseIsLike_TtlCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvcc_CourseIsLike_TtlCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvcc_CourseIsLike_TtlCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvcc_CourseIsLike_TtlCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvcc_CourseIsLike_TtlCond[strFldName]));
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
public static List<clsvcc_CourseIsLike_TtlEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvcc_CourseIsLike_TtlEN> arrObjLst = new List<clsvcc_CourseIsLike_TtlEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_CourseIsLike_TtlEN objvcc_CourseIsLike_TtlEN = new clsvcc_CourseIsLike_TtlEN();
try
{
objvcc_CourseIsLike_TtlEN.CourseId = objRow[convcc_CourseIsLike_Ttl.CourseId].ToString().Trim(); //课程Id
objvcc_CourseIsLike_TtlEN.LikeCount = objRow[convcc_CourseIsLike_Ttl.LikeCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseIsLike_Ttl.LikeCount].ToString().Trim()); //LikeCount
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_CourseIsLike_TtlEN.CourseId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_CourseIsLike_TtlEN);
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
public static List<clsvcc_CourseIsLike_TtlEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvcc_CourseIsLike_TtlEN> arrObjLst = new List<clsvcc_CourseIsLike_TtlEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_CourseIsLike_TtlEN objvcc_CourseIsLike_TtlEN = new clsvcc_CourseIsLike_TtlEN();
try
{
objvcc_CourseIsLike_TtlEN.CourseId = objRow[convcc_CourseIsLike_Ttl.CourseId].ToString().Trim(); //课程Id
objvcc_CourseIsLike_TtlEN.LikeCount = objRow[convcc_CourseIsLike_Ttl.LikeCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseIsLike_Ttl.LikeCount].ToString().Trim()); //LikeCount
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_CourseIsLike_TtlEN.CourseId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_CourseIsLike_TtlEN);
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
List<clsvcc_CourseIsLike_TtlEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvcc_CourseIsLike_TtlEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvcc_CourseIsLike_TtlEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvcc_CourseIsLike_TtlEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvcc_CourseIsLike_TtlEN> arrObjLst = new List<clsvcc_CourseIsLike_TtlEN>(); 
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
	clsvcc_CourseIsLike_TtlEN objvcc_CourseIsLike_TtlEN = new clsvcc_CourseIsLike_TtlEN();
try
{
objvcc_CourseIsLike_TtlEN.CourseId = objRow[convcc_CourseIsLike_Ttl.CourseId].ToString().Trim(); //课程Id
objvcc_CourseIsLike_TtlEN.LikeCount = objRow[convcc_CourseIsLike_Ttl.LikeCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseIsLike_Ttl.LikeCount].ToString().Trim()); //LikeCount
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_CourseIsLike_TtlEN.CourseId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_CourseIsLike_TtlEN);
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
public static List<clsvcc_CourseIsLike_TtlEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvcc_CourseIsLike_TtlEN> arrObjLst = new List<clsvcc_CourseIsLike_TtlEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_CourseIsLike_TtlEN objvcc_CourseIsLike_TtlEN = new clsvcc_CourseIsLike_TtlEN();
try
{
objvcc_CourseIsLike_TtlEN.CourseId = objRow[convcc_CourseIsLike_Ttl.CourseId].ToString().Trim(); //课程Id
objvcc_CourseIsLike_TtlEN.LikeCount = objRow[convcc_CourseIsLike_Ttl.LikeCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseIsLike_Ttl.LikeCount].ToString().Trim()); //LikeCount
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_CourseIsLike_TtlEN.CourseId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_CourseIsLike_TtlEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvcc_CourseIsLike_TtlEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvcc_CourseIsLike_TtlEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvcc_CourseIsLike_TtlEN> arrObjLst = new List<clsvcc_CourseIsLike_TtlEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_CourseIsLike_TtlEN objvcc_CourseIsLike_TtlEN = new clsvcc_CourseIsLike_TtlEN();
try
{
objvcc_CourseIsLike_TtlEN.CourseId = objRow[convcc_CourseIsLike_Ttl.CourseId].ToString().Trim(); //课程Id
objvcc_CourseIsLike_TtlEN.LikeCount = objRow[convcc_CourseIsLike_Ttl.LikeCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseIsLike_Ttl.LikeCount].ToString().Trim()); //LikeCount
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_CourseIsLike_TtlEN.CourseId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_CourseIsLike_TtlEN);
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
public static List<clsvcc_CourseIsLike_TtlEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvcc_CourseIsLike_TtlEN> arrObjLst = new List<clsvcc_CourseIsLike_TtlEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_CourseIsLike_TtlEN objvcc_CourseIsLike_TtlEN = new clsvcc_CourseIsLike_TtlEN();
try
{
objvcc_CourseIsLike_TtlEN.CourseId = objRow[convcc_CourseIsLike_Ttl.CourseId].ToString().Trim(); //课程Id
objvcc_CourseIsLike_TtlEN.LikeCount = objRow[convcc_CourseIsLike_Ttl.LikeCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseIsLike_Ttl.LikeCount].ToString().Trim()); //LikeCount
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_CourseIsLike_TtlEN.CourseId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_CourseIsLike_TtlEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvcc_CourseIsLike_TtlEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvcc_CourseIsLike_TtlEN> arrObjLst = new List<clsvcc_CourseIsLike_TtlEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_CourseIsLike_TtlEN objvcc_CourseIsLike_TtlEN = new clsvcc_CourseIsLike_TtlEN();
try
{
objvcc_CourseIsLike_TtlEN.CourseId = objRow[convcc_CourseIsLike_Ttl.CourseId].ToString().Trim(); //课程Id
objvcc_CourseIsLike_TtlEN.LikeCount = objRow[convcc_CourseIsLike_Ttl.LikeCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseIsLike_Ttl.LikeCount].ToString().Trim()); //LikeCount
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_CourseIsLike_TtlEN.CourseId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_CourseIsLike_TtlEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvcc_CourseIsLike_TtlEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool Getvcc_CourseIsLike_Ttl(ref clsvcc_CourseIsLike_TtlEN objvcc_CourseIsLike_TtlEN)
{
bool bolResult = vcc_CourseIsLike_TtlDA.Getvcc_CourseIsLike_Ttl(ref objvcc_CourseIsLike_TtlEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strCourseId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvcc_CourseIsLike_TtlEN GetObjByCourseId(string strCourseId)
{
if (strCourseId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strCourseId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strCourseId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strCourseId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsvcc_CourseIsLike_TtlEN objvcc_CourseIsLike_TtlEN = vcc_CourseIsLike_TtlDA.GetObjByCourseId(strCourseId);
return objvcc_CourseIsLike_TtlEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvcc_CourseIsLike_TtlEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvcc_CourseIsLike_TtlEN objvcc_CourseIsLike_TtlEN = vcc_CourseIsLike_TtlDA.GetFirstObj(strWhereCond);
 return objvcc_CourseIsLike_TtlEN;
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
public static clsvcc_CourseIsLike_TtlEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvcc_CourseIsLike_TtlEN objvcc_CourseIsLike_TtlEN = vcc_CourseIsLike_TtlDA.GetObjByDataRow(objRow);
 return objvcc_CourseIsLike_TtlEN;
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
public static clsvcc_CourseIsLike_TtlEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvcc_CourseIsLike_TtlEN objvcc_CourseIsLike_TtlEN = vcc_CourseIsLike_TtlDA.GetObjByDataRow(objRow);
 return objvcc_CourseIsLike_TtlEN;
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
 /// <param name = "strCourseId">所给的关键字</param>
 /// <param name = "lstvcc_CourseIsLike_TtlObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvcc_CourseIsLike_TtlEN GetObjByCourseIdFromList(string strCourseId, List<clsvcc_CourseIsLike_TtlEN> lstvcc_CourseIsLike_TtlObjLst)
{
foreach (clsvcc_CourseIsLike_TtlEN objvcc_CourseIsLike_TtlEN in lstvcc_CourseIsLike_TtlObjLst)
{
if (objvcc_CourseIsLike_TtlEN.CourseId == strCourseId)
{
return objvcc_CourseIsLike_TtlEN;
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
 string strCourseId;
 try
 {
 strCourseId = new clsvcc_CourseIsLike_TtlDA().GetFirstID(strWhereCond);
 return strCourseId;
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
 arrList = vcc_CourseIsLike_TtlDA.GetID(strWhereCond);
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
bool bolIsExist = vcc_CourseIsLike_TtlDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strCourseId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strCourseId)
{
if (string.IsNullOrEmpty(strCourseId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strCourseId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = vcc_CourseIsLike_TtlDA.IsExist(strCourseId);
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
 bolIsExist = clsvcc_CourseIsLike_TtlDA.IsExistTable();
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
 bolIsExist = vcc_CourseIsLike_TtlDA.IsExistTable(strTabName);
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
 /// <param name = "objvcc_CourseIsLike_TtlENS">源对象</param>
 /// <param name = "objvcc_CourseIsLike_TtlENT">目标对象</param>
 public static void CopyTo(clsvcc_CourseIsLike_TtlEN objvcc_CourseIsLike_TtlENS, clsvcc_CourseIsLike_TtlEN objvcc_CourseIsLike_TtlENT)
{
try
{
objvcc_CourseIsLike_TtlENT.CourseId = objvcc_CourseIsLike_TtlENS.CourseId; //课程Id
objvcc_CourseIsLike_TtlENT.LikeCount = objvcc_CourseIsLike_TtlENS.LikeCount; //LikeCount
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
 /// <param name = "objvcc_CourseIsLike_TtlEN">源简化对象</param>
 public static void SetUpdFlag(clsvcc_CourseIsLike_TtlEN objvcc_CourseIsLike_TtlEN)
{
try
{
objvcc_CourseIsLike_TtlEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvcc_CourseIsLike_TtlEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convcc_CourseIsLike_Ttl.CourseId, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseIsLike_TtlEN.CourseId = objvcc_CourseIsLike_TtlEN.CourseId; //课程Id
}
if (arrFldSet.Contains(convcc_CourseIsLike_Ttl.LikeCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseIsLike_TtlEN.LikeCount = objvcc_CourseIsLike_TtlEN.LikeCount; //LikeCount
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
 /// <param name = "objvcc_CourseIsLike_TtlEN">源简化对象</param>
 public static void AccessFldValueNull(clsvcc_CourseIsLike_TtlEN objvcc_CourseIsLike_TtlEN)
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
public static void CheckProperty4Condition(clsvcc_CourseIsLike_TtlEN objvcc_CourseIsLike_TtlEN)
{
 vcc_CourseIsLike_TtlDA.CheckProperty4Condition(objvcc_CourseIsLike_TtlEN);
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
if (clscc_CourseIsLikeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_CourseIsLikeBL没有刷新缓存机制(clscc_CourseIsLikeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by CourseId");
//if (arrvcc_CourseIsLike_TtlObjLstCache == null)
//{
//arrvcc_CourseIsLike_TtlObjLstCache = vcc_CourseIsLike_TtlDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strCourseId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvcc_CourseIsLike_TtlEN GetObjByCourseIdCache(string strCourseId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvcc_CourseIsLike_TtlEN._CurrTabName);
List<clsvcc_CourseIsLike_TtlEN> arrvcc_CourseIsLike_TtlObjLstCache = GetObjLstCache();
IEnumerable <clsvcc_CourseIsLike_TtlEN> arrvcc_CourseIsLike_TtlObjLst_Sel =
arrvcc_CourseIsLike_TtlObjLstCache
.Where(x=> x.CourseId == strCourseId 
);
if (arrvcc_CourseIsLike_TtlObjLst_Sel.Count() == 0)
{
   clsvcc_CourseIsLike_TtlEN obj = clsvcc_CourseIsLike_TtlBL.GetObjByCourseId(strCourseId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvcc_CourseIsLike_TtlObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvcc_CourseIsLike_TtlEN> GetAllvcc_CourseIsLike_TtlObjLstCache()
{
//获取缓存中的对象列表
List<clsvcc_CourseIsLike_TtlEN> arrvcc_CourseIsLike_TtlObjLstCache = GetObjLstCache(); 
return arrvcc_CourseIsLike_TtlObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvcc_CourseIsLike_TtlEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvcc_CourseIsLike_TtlEN._CurrTabName);
List<clsvcc_CourseIsLike_TtlEN> arrvcc_CourseIsLike_TtlObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvcc_CourseIsLike_TtlObjLstCache;
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
string strKey = string.Format("{0}", clsvcc_CourseIsLike_TtlEN._CurrTabName);
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
public static string Func(string strInFldName, string strOutFldName, string strCourseId)
{
if (strInFldName != convcc_CourseIsLike_Ttl.CourseId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convcc_CourseIsLike_Ttl.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convcc_CourseIsLike_Ttl.AttributeName));
throw new Exception(strMsg);
}
var objvcc_CourseIsLike_Ttl = clsvcc_CourseIsLike_TtlBL.GetObjByCourseIdCache(strCourseId);
if (objvcc_CourseIsLike_Ttl == null) return "";
return objvcc_CourseIsLike_Ttl[strOutFldName].ToString();
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
int intRecCount = clsvcc_CourseIsLike_TtlDA.GetRecCount(strTabName);
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
int intRecCount = clsvcc_CourseIsLike_TtlDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvcc_CourseIsLike_TtlDA.GetRecCount();
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
int intRecCount = clsvcc_CourseIsLike_TtlDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvcc_CourseIsLike_TtlCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvcc_CourseIsLike_TtlEN objvcc_CourseIsLike_TtlCond)
{
List<clsvcc_CourseIsLike_TtlEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvcc_CourseIsLike_TtlEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convcc_CourseIsLike_Ttl.AttributeName)
{
if (objvcc_CourseIsLike_TtlCond.IsUpdated(strFldName) == false) continue;
if (objvcc_CourseIsLike_TtlCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvcc_CourseIsLike_TtlCond[strFldName].ToString());
}
else
{
if (objvcc_CourseIsLike_TtlCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvcc_CourseIsLike_TtlCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvcc_CourseIsLike_TtlCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvcc_CourseIsLike_TtlCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvcc_CourseIsLike_TtlCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvcc_CourseIsLike_TtlCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvcc_CourseIsLike_TtlCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvcc_CourseIsLike_TtlCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvcc_CourseIsLike_TtlCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvcc_CourseIsLike_TtlCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvcc_CourseIsLike_TtlCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvcc_CourseIsLike_TtlCond[strFldName]));
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
 List<string> arrList = clsvcc_CourseIsLike_TtlDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vcc_CourseIsLike_TtlDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vcc_CourseIsLike_TtlDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}