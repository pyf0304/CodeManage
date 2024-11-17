
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvClassRoomBL
 表名:vClassRoom(01160057)
 * 版本:2023.03.10.1(服务器:WIN-SRV103-116)
 日期:2023/03/11 03:04:21
 生成者:pyf
 生成服务器IP:
 工程名称:简单工程样例(0116)
 CM工程:简单样例后端(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433SimplePrj
 PrjDataBaseId:0111
 模块中文名:基本信息(BaseInfo)
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
using SimplePrj.Entity;
using System.Data; 
using System.Data.SqlClient; 
using SimplePrj.DAL;

namespace SimplePrj.BusinessLogic
{
public static class clsvClassRoomBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strClassRoomId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvClassRoomEN GetObj(this K_ClassRoomId_vClassRoom myKey)
{
clsvClassRoomEN objvClassRoomEN = clsvClassRoomBL.vClassRoomDA.GetObjByClassRoomId(myKey.Value);
return objvClassRoomEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClassRoomEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClassRoomEN SetClassRoomId(this clsvClassRoomEN objvClassRoomEN, string strClassRoomId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strClassRoomId, 4, convClassRoom.ClassRoomId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strClassRoomId, 4, convClassRoom.ClassRoomId);
}
objvClassRoomEN.ClassRoomId = strClassRoomId; //教室Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClassRoomEN.dicFldComparisonOp.ContainsKey(convClassRoom.ClassRoomId) == false)
{
objvClassRoomEN.dicFldComparisonOp.Add(convClassRoom.ClassRoomId, strComparisonOp);
}
else
{
objvClassRoomEN.dicFldComparisonOp[convClassRoom.ClassRoomId] = strComparisonOp;
}
}
return objvClassRoomEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClassRoomEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClassRoomEN SetClassRoomName(this clsvClassRoomEN objvClassRoomEN, string strClassRoomName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strClassRoomName, convClassRoom.ClassRoomName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strClassRoomName, 30, convClassRoom.ClassRoomName);
}
objvClassRoomEN.ClassRoomName = strClassRoomName; //教室名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClassRoomEN.dicFldComparisonOp.ContainsKey(convClassRoom.ClassRoomName) == false)
{
objvClassRoomEN.dicFldComparisonOp.Add(convClassRoom.ClassRoomName, strComparisonOp);
}
else
{
objvClassRoomEN.dicFldComparisonOp[convClassRoom.ClassRoomName] = strComparisonOp;
}
}
return objvClassRoomEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClassRoomEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClassRoomEN SetOrderNum(this clsvClassRoomEN objvClassRoomEN, int intOrderNum, string strComparisonOp="")
	{
objvClassRoomEN.OrderNum = intOrderNum; //排序
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClassRoomEN.dicFldComparisonOp.ContainsKey(convClassRoom.OrderNum) == false)
{
objvClassRoomEN.dicFldComparisonOp.Add(convClassRoom.OrderNum, strComparisonOp);
}
else
{
objvClassRoomEN.dicFldComparisonOp[convClassRoom.OrderNum] = strComparisonOp;
}
}
return objvClassRoomEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClassRoomEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClassRoomEN SetMemo(this clsvClassRoomEN objvClassRoomEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convClassRoom.Memo);
}
objvClassRoomEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClassRoomEN.dicFldComparisonOp.ContainsKey(convClassRoom.Memo) == false)
{
objvClassRoomEN.dicFldComparisonOp.Add(convClassRoom.Memo, strComparisonOp);
}
else
{
objvClassRoomEN.dicFldComparisonOp[convClassRoom.Memo] = strComparisonOp;
}
}
return objvClassRoomEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvClassRoomENS">源对象</param>
 /// <param name = "objvClassRoomENT">目标对象</param>
 public static void CopyTo(this clsvClassRoomEN objvClassRoomENS, clsvClassRoomEN objvClassRoomENT)
{
try
{
objvClassRoomENT.ClassRoomId = objvClassRoomENS.ClassRoomId; //教室Id
objvClassRoomENT.ClassRoomName = objvClassRoomENS.ClassRoomName; //教室名
objvClassRoomENT.OrderNum = objvClassRoomENS.OrderNum; //排序
objvClassRoomENT.Memo = objvClassRoomENS.Memo; //备注
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
 /// <param name = "objvClassRoomENS">源对象</param>
 /// <returns>目标对象=>clsvClassRoomEN:objvClassRoomENT</returns>
 public static clsvClassRoomEN CopyTo(this clsvClassRoomEN objvClassRoomENS)
{
try
{
 clsvClassRoomEN objvClassRoomENT = new clsvClassRoomEN()
{
ClassRoomId = objvClassRoomENS.ClassRoomId, //教室Id
ClassRoomName = objvClassRoomENS.ClassRoomName, //教室名
OrderNum = objvClassRoomENS.OrderNum, //排序
Memo = objvClassRoomENS.Memo, //备注
};
 return objvClassRoomENT;
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
public static void CheckProperty4Condition(this clsvClassRoomEN objvClassRoomEN)
{
 clsvClassRoomBL.vClassRoomDA.CheckProperty4Condition(objvClassRoomEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvClassRoomEN objvClassRoom_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvClassRoom_Cond.IsUpdated(convClassRoom.ClassRoomId) == true)
{
string strComparisonOp_ClassRoomId = objvClassRoom_Cond.dicFldComparisonOp[convClassRoom.ClassRoomId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClassRoom.ClassRoomId, objvClassRoom_Cond.ClassRoomId, strComparisonOp_ClassRoomId);
}
if (objvClassRoom_Cond.IsUpdated(convClassRoom.ClassRoomName) == true)
{
string strComparisonOp_ClassRoomName = objvClassRoom_Cond.dicFldComparisonOp[convClassRoom.ClassRoomName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClassRoom.ClassRoomName, objvClassRoom_Cond.ClassRoomName, strComparisonOp_ClassRoomName);
}
if (objvClassRoom_Cond.IsUpdated(convClassRoom.OrderNum) == true)
{
string strComparisonOp_OrderNum = objvClassRoom_Cond.dicFldComparisonOp[convClassRoom.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", convClassRoom.OrderNum, objvClassRoom_Cond.OrderNum, strComparisonOp_OrderNum);
}
if (objvClassRoom_Cond.IsUpdated(convClassRoom.Memo) == true)
{
string strComparisonOp_Memo = objvClassRoom_Cond.dicFldComparisonOp[convClassRoom.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClassRoom.Memo, objvClassRoom_Cond.Memo, strComparisonOp_Memo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时，对相关表执行相应的操作，此处定义一个类，在外面可以扩展该类的相关函数，达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vClassRoom
{
public virtual bool UpdRelaTabDate(string strClassRoomId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// vClassRoom(vClassRoom)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvClassRoomBL
{
public static RelatedActions_vClassRoom relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvClassRoomDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式，使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvClassRoomDA vClassRoomDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvClassRoomDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvClassRoomBL()
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
throw new Exception("请初始化用于记录日志的clsSysParaEN.objLog对象！");
}
if (clsSysParaEN.objErrorLog == null)
{
throw new Exception("请初始化用于记录错误日志的clsSysParaEN.objErrorLog对象！");
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
if (string.IsNullOrEmpty(clsvClassRoomEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvClassRoomEN._ConnectString);
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
public static DataTable GetDataTable_vClassRoom(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vClassRoomDA.GetDataTable_vClassRoom(strWhereCond);
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
objDT = vClassRoomDA.GetDataTable(strWhereCond);
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
objDT = vClassRoomDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vClassRoomDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vClassRoomDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vClassRoomDA.GetDataTable_Top(objTopPara);
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
objDT = vClassRoomDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vClassRoomDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vClassRoomDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrClassRoomIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvClassRoomEN> GetObjLstByClassRoomIdLst(List<string> arrClassRoomIdLst)
{
List<clsvClassRoomEN> arrObjLst = new List<clsvClassRoomEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrClassRoomIdLst, true);
 string strWhereCond = string.Format("ClassRoomId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvClassRoomEN objvClassRoomEN = new clsvClassRoomEN();
try
{
objvClassRoomEN.ClassRoomId = objRow[convClassRoom.ClassRoomId].ToString().Trim(); //教室Id
objvClassRoomEN.ClassRoomName = objRow[convClassRoom.ClassRoomName].ToString().Trim(); //教室名
objvClassRoomEN.OrderNum = clsEntityBase2.TransNullToInt_S(objRow[convClassRoom.OrderNum] == DBNull.Value ? null : objRow[convClassRoom.OrderNum].ToString().Trim()); //排序
objvClassRoomEN.Memo = objRow[convClassRoom.Memo] == DBNull.Value ? null : objRow[convClassRoom.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvClassRoomEN.ClassRoomId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvClassRoomEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLst_Cache)
 /// </summary>
 /// <param name = "arrClassRoomIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvClassRoomEN> GetObjLstByClassRoomIdLst_Cache(List<string> arrClassRoomIdLst)
{
string strKey = string.Format("{0}", clsvClassRoomEN._CurrTabName_S);
List<clsvClassRoomEN> arrvClassRoomObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvClassRoomEN> arrvClassRoomObjLst_Sel =
arrvClassRoomObjLst_Cache
.Where(x => arrClassRoomIdLst.Contains(x.ClassRoomId));
return arrvClassRoomObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvClassRoomEN> GetObjLst(string strWhereCond)
{
List<clsvClassRoomEN> arrObjLst = new List<clsvClassRoomEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvClassRoomEN objvClassRoomEN = new clsvClassRoomEN();
try
{
objvClassRoomEN.ClassRoomId = objRow[convClassRoom.ClassRoomId].ToString().Trim(); //教室Id
objvClassRoomEN.ClassRoomName = objRow[convClassRoom.ClassRoomName].ToString().Trim(); //教室名
objvClassRoomEN.OrderNum = clsEntityBase2.TransNullToInt_S(objRow[convClassRoom.OrderNum] == DBNull.Value ? null : objRow[convClassRoom.OrderNum].ToString().Trim()); //排序
objvClassRoomEN.Memo = objRow[convClassRoom.Memo] == DBNull.Value ? null : objRow[convClassRoom.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvClassRoomEN.ClassRoomId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvClassRoomEN);
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
public static List<clsvClassRoomEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvClassRoomEN> arrObjLst = new List<clsvClassRoomEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvClassRoomEN objvClassRoomEN = new clsvClassRoomEN();
try
{
objvClassRoomEN.ClassRoomId = objRow[convClassRoom.ClassRoomId].ToString().Trim(); //教室Id
objvClassRoomEN.ClassRoomName = objRow[convClassRoom.ClassRoomName].ToString().Trim(); //教室名
objvClassRoomEN.OrderNum = clsEntityBase2.TransNullToInt_S(objRow[convClassRoom.OrderNum] == DBNull.Value ? null : objRow[convClassRoom.OrderNum].ToString().Trim()); //排序
objvClassRoomEN.Memo = objRow[convClassRoom.Memo] == DBNull.Value ? null : objRow[convClassRoom.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvClassRoomEN.ClassRoomId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvClassRoomEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLst_Cache)
 /// </summary>
 /// <param name = "objvClassRoom_Cond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvClassRoomEN> GetSubObjLst_Cache(clsvClassRoomEN objvClassRoom_Cond)
{
List<clsvClassRoomEN> arrObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvClassRoomEN> arrObjLst_Sel = arrObjLst_Cache;
foreach (string strFldName in convClassRoom.AttributeName)
{
if (objvClassRoom_Cond.IsUpdated(strFldName) == false) continue;
if (objvClassRoom_Cond.dicFldComparisonOp == null)
{
arrObjLst_Sel = arrObjLst_Sel.Where(x => x[strFldName].ToString() == objvClassRoom_Cond[strFldName].ToString());
}
else
{
if (objvClassRoom_Cond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvClassRoom_Cond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLst_Sel = arrObjLst_Sel.Where(x => x[strFldName].ToString() == objvClassRoom_Cond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLst_Sel = arrObjLst_Sel.Where(x => x[strFldName].ToString().Contains(objvClassRoom_Cond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLst_Sel = arrObjLst_Sel.Where(x => x[strFldName].ToString().Length > int.Parse(objvClassRoom_Cond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLst_Sel = arrObjLst_Sel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvClassRoom_Cond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLst_Sel = arrObjLst_Sel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvClassRoom_Cond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLst_Sel = arrObjLst_Sel.Where(x => x[strFldName].ToString().Length < int.Parse(objvClassRoom_Cond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLst_Sel = arrObjLst_Sel.Where(x => x[strFldName].ToString().Length == int.Parse(objvClassRoom_Cond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvClassRoom_Cond[strFldName].ToString().Split(",".ToCharArray());
arrObjLst_Sel = arrObjLst_Sel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLst_Sel = arrObjLst_Sel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvClassRoom_Cond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLst_Sel = arrObjLst_Sel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvClassRoom_Cond[strFldName]));
}
}
}
return arrObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByTabName)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvClassRoomEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvClassRoomEN> arrObjLst = new List<clsvClassRoomEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvClassRoomEN objvClassRoomEN = new clsvClassRoomEN();
try
{
objvClassRoomEN.ClassRoomId = objRow[convClassRoom.ClassRoomId].ToString().Trim(); //教室Id
objvClassRoomEN.ClassRoomName = objRow[convClassRoom.ClassRoomName].ToString().Trim(); //教室名
objvClassRoomEN.OrderNum = clsEntityBase2.TransNullToInt_S(objRow[convClassRoom.OrderNum] == DBNull.Value ? null : objRow[convClassRoom.OrderNum].ToString().Trim()); //排序
objvClassRoomEN.Memo = objRow[convClassRoom.Memo] == DBNull.Value ? null : objRow[convClassRoom.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvClassRoomEN.ClassRoomId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvClassRoomEN);
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
public static List<clsvClassRoomEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvClassRoomEN> arrObjLst = new List<clsvClassRoomEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvClassRoomEN objvClassRoomEN = new clsvClassRoomEN();
try
{
objvClassRoomEN.ClassRoomId = objRow[convClassRoom.ClassRoomId].ToString().Trim(); //教室Id
objvClassRoomEN.ClassRoomName = objRow[convClassRoom.ClassRoomName].ToString().Trim(); //教室名
objvClassRoomEN.OrderNum = clsEntityBase2.TransNullToInt_S(objRow[convClassRoom.OrderNum] == DBNull.Value ? null : objRow[convClassRoom.OrderNum].ToString().Trim()); //排序
objvClassRoomEN.Memo = objRow[convClassRoom.Memo] == DBNull.Value ? null : objRow[convClassRoom.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvClassRoomEN.ClassRoomId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvClassRoomEN);
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
List<clsvClassRoomEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvClassRoomEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvClassRoomEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvClassRoomEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvClassRoomEN> arrObjLst = new List<clsvClassRoomEN>(); 
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
	clsvClassRoomEN objvClassRoomEN = new clsvClassRoomEN();
try
{
objvClassRoomEN.ClassRoomId = objRow[convClassRoom.ClassRoomId].ToString().Trim(); //教室Id
objvClassRoomEN.ClassRoomName = objRow[convClassRoom.ClassRoomName].ToString().Trim(); //教室名
objvClassRoomEN.OrderNum = clsEntityBase2.TransNullToInt_S(objRow[convClassRoom.OrderNum] == DBNull.Value ? null : objRow[convClassRoom.OrderNum].ToString().Trim()); //排序
objvClassRoomEN.Memo = objRow[convClassRoom.Memo] == DBNull.Value ? null : objRow[convClassRoom.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvClassRoomEN.ClassRoomId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvClassRoomEN);
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
public static List<clsvClassRoomEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvClassRoomEN> arrObjLst = new List<clsvClassRoomEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvClassRoomEN objvClassRoomEN = new clsvClassRoomEN();
try
{
objvClassRoomEN.ClassRoomId = objRow[convClassRoom.ClassRoomId].ToString().Trim(); //教室Id
objvClassRoomEN.ClassRoomName = objRow[convClassRoom.ClassRoomName].ToString().Trim(); //教室名
objvClassRoomEN.OrderNum = clsEntityBase2.TransNullToInt_S(objRow[convClassRoom.OrderNum] == DBNull.Value ? null : objRow[convClassRoom.OrderNum].ToString().Trim()); //排序
objvClassRoomEN.Memo = objRow[convClassRoom.Memo] == DBNull.Value ? null : objRow[convClassRoom.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvClassRoomEN.ClassRoomId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvClassRoomEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvClassRoomEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvClassRoomEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvClassRoomEN> arrObjLst = new List<clsvClassRoomEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvClassRoomEN objvClassRoomEN = new clsvClassRoomEN();
try
{
objvClassRoomEN.ClassRoomId = objRow[convClassRoom.ClassRoomId].ToString().Trim(); //教室Id
objvClassRoomEN.ClassRoomName = objRow[convClassRoom.ClassRoomName].ToString().Trim(); //教室名
objvClassRoomEN.OrderNum = clsEntityBase2.TransNullToInt_S(objRow[convClassRoom.OrderNum] == DBNull.Value ? null : objRow[convClassRoom.OrderNum].ToString().Trim()); //排序
objvClassRoomEN.Memo = objRow[convClassRoom.Memo] == DBNull.Value ? null : objRow[convClassRoom.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvClassRoomEN.ClassRoomId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvClassRoomEN);
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
public static List<clsvClassRoomEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvClassRoomEN> arrObjLst = new List<clsvClassRoomEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvClassRoomEN objvClassRoomEN = new clsvClassRoomEN();
try
{
objvClassRoomEN.ClassRoomId = objRow[convClassRoom.ClassRoomId].ToString().Trim(); //教室Id
objvClassRoomEN.ClassRoomName = objRow[convClassRoom.ClassRoomName].ToString().Trim(); //教室名
objvClassRoomEN.OrderNum = clsEntityBase2.TransNullToInt_S(objRow[convClassRoom.OrderNum] == DBNull.Value ? null : objRow[convClassRoom.OrderNum].ToString().Trim()); //排序
objvClassRoomEN.Memo = objRow[convClassRoom.Memo] == DBNull.Value ? null : objRow[convClassRoom.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvClassRoomEN.ClassRoomId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvClassRoomEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvClassRoomEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvClassRoomEN> arrObjLst = new List<clsvClassRoomEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvClassRoomEN objvClassRoomEN = new clsvClassRoomEN();
try
{
objvClassRoomEN.ClassRoomId = objRow[convClassRoom.ClassRoomId].ToString().Trim(); //教室Id
objvClassRoomEN.ClassRoomName = objRow[convClassRoom.ClassRoomName].ToString().Trim(); //教室名
objvClassRoomEN.OrderNum = clsEntityBase2.TransNullToInt_S(objRow[convClassRoom.OrderNum] == DBNull.Value ? null : objRow[convClassRoom.OrderNum].ToString().Trim()); //排序
objvClassRoomEN.Memo = objRow[convClassRoom.Memo] == DBNull.Value ? null : objRow[convClassRoom.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvClassRoomEN.ClassRoomId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvClassRoomEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvClassRoomEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvClassRoom(ref clsvClassRoomEN objvClassRoomEN)
{
bool bolResult = vClassRoomDA.GetvClassRoom(ref objvClassRoomEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strClassRoomId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvClassRoomEN GetObjByClassRoomId(string strClassRoomId)
{
if (strClassRoomId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strClassRoomId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strClassRoomId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strClassRoomId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsvClassRoomEN objvClassRoomEN = vClassRoomDA.GetObjByClassRoomId(strClassRoomId);
return objvClassRoomEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvClassRoomEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvClassRoomEN objvClassRoomEN = vClassRoomDA.GetFirstObj(strWhereCond);
 return objvClassRoomEN;
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
public static clsvClassRoomEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvClassRoomEN objvClassRoomEN = vClassRoomDA.GetObjByDataRow(objRow);
 return objvClassRoomEN;
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
public static clsvClassRoomEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvClassRoomEN objvClassRoomEN = vClassRoomDA.GetObjByDataRow(objRow);
 return objvClassRoomEN;
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
 /// <param name = "strClassRoomId">所给的关键字</param>
 /// <param name = "lstvClassRoomObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvClassRoomEN GetObjByClassRoomIdFromList(string strClassRoomId, List<clsvClassRoomEN> lstvClassRoomObjLst)
{
foreach (clsvClassRoomEN objvClassRoomEN in lstvClassRoomObjLst)
{
if (objvClassRoomEN.ClassRoomId == strClassRoomId)
{
return objvClassRoomEN;
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
 string strClassRoomId;
 try
 {
 strClassRoomId = new clsvClassRoomDA().GetFirstID(strWhereCond);
 return strClassRoomId;
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
 arrList = vClassRoomDA.GetID(strWhereCond);
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
bool bolIsExist = vClassRoomDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strClassRoomId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strClassRoomId)
{
if (string.IsNullOrEmpty(strClassRoomId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strClassRoomId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = vClassRoomDA.IsExist(strClassRoomId);
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
 bolIsExist = clsvClassRoomDA.IsExistTable();
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
 bolIsExist = vClassRoomDA.IsExistTable(strTabName);
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
 /// <param name = "objvClassRoomENS">源对象</param>
 /// <param name = "objvClassRoomENT">目标对象</param>
 public static void CopyTo(clsvClassRoomEN objvClassRoomENS, clsvClassRoomEN objvClassRoomENT)
{
try
{
objvClassRoomENT.ClassRoomId = objvClassRoomENS.ClassRoomId; //教室Id
objvClassRoomENT.ClassRoomName = objvClassRoomENS.ClassRoomName; //教室名
objvClassRoomENT.OrderNum = objvClassRoomENS.OrderNum; //排序
objvClassRoomENT.Memo = objvClassRoomENS.Memo; //备注
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
 /// <param name = "objvClassRoomEN">源简化对象</param>
 public static void SetUpdFlag(clsvClassRoomEN objvClassRoomEN)
{
try
{
objvClassRoomEN.ClearUpdateState();
   string strsf_UpdFldSetStr = objvClassRoomEN.sf_UpdFldSetStr;
    string[] sstrFldSet = strsf_UpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convClassRoom.ClassRoomId, new clsStrCompareIgnoreCase())  ==  true)
{
objvClassRoomEN.ClassRoomId = objvClassRoomEN.ClassRoomId; //教室Id
}
if (arrFldSet.Contains(convClassRoom.ClassRoomName, new clsStrCompareIgnoreCase())  ==  true)
{
objvClassRoomEN.ClassRoomName = objvClassRoomEN.ClassRoomName; //教室名
}
if (arrFldSet.Contains(convClassRoom.OrderNum, new clsStrCompareIgnoreCase())  ==  true)
{
objvClassRoomEN.OrderNum = objvClassRoomEN.OrderNum; //排序
}
if (arrFldSet.Contains(convClassRoom.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvClassRoomEN.Memo = objvClassRoomEN.Memo == "[null]" ? null :  objvClassRoomEN.Memo; //备注
}
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000064)设置表的修改标志出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 处理从Web端传来的[null]的字段值，在WebApi端设置成null
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_AccessFldValueNull)
 /// </summary>
 /// <param name = "objvClassRoomEN">源简化对象</param>
 public static void AccessFldValueNull(clsvClassRoomEN objvClassRoomEN)
{
try
{
if (objvClassRoomEN.Memo == "[null]") objvClassRoomEN.Memo = null; //备注
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000170)处理从Web端传来的[null]的字段值出错,{1}.({0})",
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
public static void CheckProperty4Condition(clsvClassRoomEN objvClassRoomEN)
{
 vClassRoomDA.CheckProperty4Condition(objvClassRoomEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Win的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_ComboBoxBindFunction)
 /// </summary>
 /// <param name = "objComboBox">需要绑定当前表的下拉框</param>
public static void BindCbo_ClassRoomId(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", convClassRoom.ClassRoomId); 
List<clsvClassRoomEN> arrObjLst = clsvClassRoomBL.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsvClassRoomEN objvClassRoomEN = new clsvClassRoomEN()
{
ClassRoomId = "0",
ClassRoomName = "选[vClassRoom]..."
};
arrObjLst.Insert(0, objvClassRoomEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = convClassRoom.ClassRoomId;
objComboBox.DisplayMember = convClassRoom.ClassRoomName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_DdlBindFunction)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_ClassRoomId(System.Web.UI.WebControls.DropDownList objDDL )
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[vClassRoom]...","0");
string strCondition = string.Format("1 =1 Order By {0}", convClassRoom.ClassRoomId); 
IEnumerable<clsvClassRoomEN> arrObjLst = clsvClassRoomBL.GetObjLst(strCondition);
objDDL.DataValueField = convClassRoom.ClassRoomId;
objDDL.DataTextField = convClassRoom.ClassRoomName;
objDDL.DataSource = arrObjLst;
objDDL.DataBind();
objDDL.Items.Insert(0, li);
objDDL.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框-使用Cache
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DdlBindFunction_Cache)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_ClassRoomId_Cache(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[vClassRoom]...","0");
List<clsvClassRoomEN> arrvClassRoomObjLst = GetAllvClassRoomObjLst_Cache(); 
objDDL.DataValueField = convClassRoom.ClassRoomId;
objDDL.DataTextField = convClassRoom.ClassRoomName;
objDDL.DataSource = arrvClassRoomObjLst;
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
if (clsClassRoomBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsClassRoomBL没有刷新缓存机制(clsClassRoomBL.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by ClassRoomId");
//if (arrvClassRoomObjLst_Cache == null)
//{
//arrvClassRoomObjLst_Cache = vClassRoomDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey_Cache)
 /// </summary>
 /// <param name = "strClassRoomId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvClassRoomEN GetObjByClassRoomId_Cache(string strClassRoomId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvClassRoomEN._CurrTabName_S);
List<clsvClassRoomEN> arrvClassRoomObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvClassRoomEN> arrvClassRoomObjLst_Sel =
arrvClassRoomObjLst_Cache
.Where(x=> x.ClassRoomId == strClassRoomId 
);
if (arrvClassRoomObjLst_Sel.Count() == 0)
{
   clsvClassRoomEN obj = clsvClassRoomBL.GetObjByClassRoomId(strClassRoomId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvClassRoomObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKey_Cache)
 /// </summary>
 /// <param name = "strClassRoomId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetClassRoomNameByClassRoomId_Cache(string strClassRoomId)
{
if (string.IsNullOrEmpty(strClassRoomId) == true) return "";
//获取缓存中的对象列表
clsvClassRoomEN objvClassRoom = GetObjByClassRoomId_Cache(strClassRoomId);
if (objvClassRoom == null) return "";
return objvClassRoom.ClassRoomName;
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKey_Cache)
 /// </summary>
 /// <param name = "strClassRoomId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByClassRoomId_Cache(string strClassRoomId)
{
if (string.IsNullOrEmpty(strClassRoomId) == true) return "";
//获取缓存中的对象列表
clsvClassRoomEN objvClassRoom = GetObjByClassRoomId_Cache(strClassRoomId);
if (objvClassRoom == null) return "";
return objvClassRoom.ClassRoomName;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLst_Cache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvClassRoomEN> GetAllvClassRoomObjLst_Cache()
{
//获取缓存中的对象列表
List<clsvClassRoomEN> arrvClassRoomObjLst_Cache = GetObjLst_Cache(); 
return arrvClassRoomObjLst_Cache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst_Cache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvClassRoomEN> GetObjLst_Cache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvClassRoomEN._CurrTabName_S);
List<clsvClassRoomEN> arrvClassRoomObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvClassRoomObjLst_Cache;
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
string strKey = string.Format("{0}", clsvClassRoomEN._CurrTabName_S);
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
 /// 映射函数。根据表映射把输入字段值，映射成输出字段值
 /// 作者:pyf
 /// 日期:2023-03-11
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_func)
 /// </summary>
 /// <param name = "strInFldName">输入字段名</param>
 /// <param name = "strOutFldName">输出字段名</param>
 /// <param name = "strInValue">输入字段值</param>
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, string strClassRoomId)
{
if (strInFldName != convClassRoom.ClassRoomId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convClassRoom.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convClassRoom.AttributeName));
throw new Exception(strMsg);
}
var objvClassRoom = clsvClassRoomBL.GetObjByClassRoomId_Cache(strClassRoomId);
if (objvClassRoom == null) return "";
return objvClassRoom[strOutFldName].ToString();
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
int intRecCount = clsvClassRoomDA.GetRecCount(strTabName);
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
int intRecCount = clsvClassRoomDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvClassRoomDA.GetRecCount();
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
int intRecCount = clsvClassRoomDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObj_Cache)
 /// </summary>
 /// <param name = "objvClassRoom_Cond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCond_Cache(clsvClassRoomEN objvClassRoom_Cond)
{
List<clsvClassRoomEN> arrObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvClassRoomEN> arrObjLst_Sel = arrObjLst_Cache;
foreach (string strFldName in convClassRoom.AttributeName)
{
if (objvClassRoom_Cond.IsUpdated(strFldName) == false) continue;
if (objvClassRoom_Cond.dicFldComparisonOp == null)
{
arrObjLst_Sel = arrObjLst_Sel.Where(x => x[strFldName].ToString() == objvClassRoom_Cond[strFldName].ToString());
}
else
{
if (objvClassRoom_Cond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvClassRoom_Cond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLst_Sel = arrObjLst_Sel.Where(x => x[strFldName].ToString() == objvClassRoom_Cond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLst_Sel = arrObjLst_Sel.Where(x => x[strFldName].ToString().Contains(objvClassRoom_Cond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLst_Sel = arrObjLst_Sel.Where(x => x[strFldName].ToString().Length > int.Parse(objvClassRoom_Cond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLst_Sel = arrObjLst_Sel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvClassRoom_Cond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLst_Sel = arrObjLst_Sel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvClassRoom_Cond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLst_Sel = arrObjLst_Sel.Where(x => x[strFldName].ToString().Length < int.Parse(objvClassRoom_Cond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLst_Sel = arrObjLst_Sel.Where(x => x[strFldName].ToString().Length == int.Parse(objvClassRoom_Cond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvClassRoom_Cond[strFldName].ToString().Split(",".ToCharArray());
arrObjLst_Sel = arrObjLst_Sel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLst_Sel = arrObjLst_Sel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvClassRoom_Cond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLst_Sel = arrObjLst_Sel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvClassRoom_Cond[strFldName]));
}
}
}
return arrObjLst_Sel.Count();
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
 List<string> arrList = clsvClassRoomDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vClassRoomDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vClassRoomDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}