
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsLoginLogDA
 表名:LoginLog(01120357)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:09:54
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:日志管理(LogManage)
 框架-层名:数据处理层(CS)(DALCode,0002)
 编程语言:CSharp
 注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
        2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
 == == == == == == == == == == == == 
 **/
using System;
using System.Data; 
using System.Data.SqlClient;
using System.Text; 
using System.Collections; 
using System.Collections.Generic; 
using com.taishsoft.common;
using com.taishsoft.datetime;
using com.taishsoft.comm_db_obj;
using com.taishsoft.commdb;
using ExamLib.Entity;

namespace ExamLib.DAL
{
 /// <summary>
 /// 登录日志(LoginLog)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsLoginLogDA : clsCommBase4DA
{
 /// <summary>
 /// 错误信息
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
protected const string EXCEPTION_MSG = "出错:"; //there was an error in the method. please see the Application Log for details.";
 /// <summary>
 /// 模块名称
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
protected string mstrModuleName;
//以下是属性变量

 /// <summary>
 /// 当前表名
 /// </summary>
 public override string _CurrTabName
 {
 get
 {
 return clsLoginLogEN._CurrTabName;
 }
 }

 /// <summary>
 /// 获取SQL服务器连接对象
 /// (AutoGCLib.DALCode4CSharp:Gen_GetSpecSQLObj)
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
 if (clsSysParaEN.bolIsUseConnectStrName  ==  true)
 {
 objSQL = new clsSpecSQLforSql(clsSysParaEN.strConnectStrName, true);
 return objSQL;
 }
 //2. 如果类所指定的连接串非空,就用该类所指定的连接串
 //3. 否则就用项目系统配置(web.config or app.config)中所指定的默认连接串
if (string.IsNullOrEmpty(clsLoginLogEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsLoginLogEN._ConnectString);
}
return objSQL;
}


 /// <summary>
 /// 获取SQL服务器连接对象
 /// (AutoGCLib.clsGeneCodeBase:Gen_GetSpecSQLObj_Obj)
 /// </summary>
 /// <returns>SQL服务器连接对象</returns>
 public override clsSpecSQLforSql GetSpecSQLObj_Obj() 
{
 clsSpecSQLforSql objSQL;
 //1. 如果系统参数(SysPara)中设置使用连接串名,就用该连接串名所指定的连接串
 if (clsSysParaEN.bolIsUseConnectStrName  ==  true)
 {
 objSQL = new clsSpecSQLforSql(clsSysParaEN.strConnectStrName, true);
 return objSQL;
 }
 //2. 如果类所指定的连接串非空,就用该类所指定的连接串
 //3. 否则就用项目系统配置(web.config or app.config)中所指定的默认连接串
 if (string.IsNullOrEmpty(clsLoginLogEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsLoginLogEN._ConnectString);
 }
 return objSQL;
 }


 #region 获取数据表的DataTable

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsLoginLogDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsLoginLogDA.GetSpecSQLObj();
strSQL = "Select * from LoginLog where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_LoginLog(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsLoginLogDA: GetDataTable_LoginLog)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsLoginLogDA.GetSpecSQLObj();
strSQL = "Select * from LoginLog where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查(给定表名)
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTableByTabName_S)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <param name = "strTabName">表名</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable(string strCondition, string strTabName)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsLoginLogDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsLoginLogDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查(带排除)
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable_Exclude)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <param name = "lstExclude">排除的检查字符串列表</param>
 /// <returns></returns>
public System.Data.DataTable GetDataTable(string strCondition, List<string> lstExclude)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition, lstExclude);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsLoginLogDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsLoginLogDA.GetSpecSQLObj();
strSQL = "Select * from LoginLog where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查(带排除)
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTableByTabName_S_Exclude)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <param name = "strTabName">表名</param>
 /// <param name = "lstExclude">排除的检查字符串列表</param>
 /// <returns></returns>
public System.Data.DataTable GetDataTable(string strCondition, string strTabName, List<string> lstExclude)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition, lstExclude);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsLoginLogDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsLoginLogDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}

 /// <summary>
 /// 根据条件获取顶部记录的数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:Gen_GetDataTable_Top_S)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_Top(stuTopPara objTopPara)
{
 return GetDataTable_Top(objTopPara.topSize, objTopPara.whereCond, objTopPara.orderBy);
}

 /// <summary>
 /// 根据条件获取顶部记录的数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:Gen_GetDataTable_Top_S)
 /// </summary>
 /// <param name = "intTopSize">顶部记录数</param>
 /// <param name = "strCondition">条件串</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_Top(int intTopSize, string strCondition, string strOrderBy)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsLoginLogDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsLoginLogDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from LoginLog where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from LoginLog where {1} order by {2}", intTopSize, strCondition, strOrderBy);
 }
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}

 /// <summary>
 /// 根据条件获取顶部记录的数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查(带排除)
 /// (AutoGCLib.clsGeneCodeBase:Gen_GetDataTable_Top_S_Exclude)
 /// </summary>
 /// <param name = "intTopSize">顶部记录数</param>
 /// <param name = "strCondition">条件串</param>
 /// <param name = "lstExclude">排除的检查字符串列表</param>
 /// <returns></returns>
public System.Data.DataTable GetDataTable_Top(int intTopSize, string strCondition, List<string> lstExclude)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition, lstExclude);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsLoginLogDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsLoginLogDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from LoginLog where {1}", intTopSize, strCondition);
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}

 /// <summary>
 /// 根据条件获取分页记录的数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTableByPager_S)
 /// </summary>
 /// <param name = "intPageIndex">页序号</param>
 /// <param name = "intPageSize">页记录数</param>
 /// <param name = "strCondition">条件串</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTableByPager(int intPageIndex, int intPageSize, string strCondition, string strOrderBy)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsLoginLogDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsLoginLogDA.GetSpecSQLObj();
 int intTop_In = intPageSize * (intPageIndex - 1);//获取连接对象
int intPos_Dot = strOrderBy.IndexOf('|');
if (intPos_Dot > 0)
{
var IsAscOrDesc = "Asc";
if (strOrderBy.IndexOf(" Asc", StringComparison.InvariantCultureIgnoreCase) > 0)
{
strOrderBy = strOrderBy.Replace(" Asc", "");
IsAscOrDesc = "Asc";
}
else if (strOrderBy.IndexOf(" Desc", StringComparison.InvariantCultureIgnoreCase) > 0)
{
strOrderBy = strOrderBy.Replace(" Desc", "");
IsAscOrDesc = "Desc";
}
var arrPart = strOrderBy.Split('|');
if (arrPart.Length != 3)
{
throw new Exception(string.Format("在带有特殊排序分页查询中,strOrderBy:[{0}]应该有竖线(|)分隔的3部分组成,请检查!(in {1})",
strOrderBy, clsStackTrace.GetCurrClassFunction()));
}
string strTabName = arrPart[0];
string strNewOrderBy = arrPart[1];
string strOnCondition = arrPart[2];
strSQL = string.Format("Select Top {0} LoginLog.* from LoginLog Left Join {1} on {2} where {3} and LoginLog.LoginLogId not in (Select top {5} LoginLog.LoginLogId from LoginLog Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from LoginLog where {1} and LoginLogId not in (Select top {2} LoginLogId from LoginLog where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from LoginLog where {1} and LoginLogId not in (Select top {3} LoginLogId from LoginLog where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
 }
 }
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}

 /// <summary>
 /// 根据条件获取分页记录的数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查(带排除)
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTableByPager_S_Exclude)
 /// </summary>
 /// <param name = "intPageIndex">页序号</param>
 /// <param name = "intPageSize">页记录数</param>
 /// <param name = "strCondition">条件串</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <param name = "lstExclude">排除的检查字符串列表</param>
 /// <returns></returns>
public System.Data.DataTable GetDataTableByPager(int intPageIndex, int intPageSize, string strCondition, string strOrderBy, List<string> lstExclude)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition, lstExclude);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsLoginLogDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsLoginLogDA.GetSpecSQLObj();
 int intTop_In = intPageSize * (intPageIndex - 1);//获取连接对象
int intPos_Dot = strOrderBy.IndexOf('|');
if (intPos_Dot > 0)
{
var IsAscOrDesc = "Asc";
if (strOrderBy.IndexOf(" Asc", StringComparison.InvariantCultureIgnoreCase) > 0)
{
strOrderBy = strOrderBy.Replace(" Asc", "");
IsAscOrDesc = "Asc";
}
else if (strOrderBy.IndexOf(" Desc", StringComparison.InvariantCultureIgnoreCase) > 0)
{
strOrderBy = strOrderBy.Replace(" Desc", "");
IsAscOrDesc = "Desc";
}
var arrPart = strOrderBy.Split('|');
if (arrPart.Length != 3)
{
throw new Exception(string.Format("在带有特殊排序分页查询中,strOrderBy:[{0}]应该有竖线(|)分隔的3部分组成,请检查!(in {1})",
strOrderBy, clsStackTrace.GetCurrClassFunction()));
}
string strTabName = arrPart[0];
string strNewOrderBy = arrPart[1];
string strOnCondition = arrPart[2];
strSQL = string.Format("Select Top {0} LoginLog.* from LoginLog Left Join {1} on {2} where {3} and LoginLog.LoginLogId not in (Select top {5} LoginLog.LoginLogId from LoginLog Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from LoginLog where {1} and LoginLogId not in (Select top {2} LoginLogId from LoginLog where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from LoginLog where {1} and LoginLogId not in (Select top {3} LoginLogId from LoginLog where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
 }
 }
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}

 #endregion 获取数据表的DataTable

 #region 获取数据表的多个对象列表

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.clsGeneCodeBase:GenGetObjLst)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回对象列表</returns>
public List<clsLoginLogEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsLoginLogDA:GetObjLst)", objException.Message));
}
List<clsLoginLogEN> arrObjLst = new List<clsLoginLogEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsLoginLogDA.GetSpecSQLObj();
strSQL = "Select * from LoginLog where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsLoginLogEN objLoginLogEN = new clsLoginLogEN();
try
{
objLoginLogEN.LoginLogId = TransNullToInt(objRow[conLoginLog.LoginLogId].ToString().Trim()); //LoginLogId
objLoginLogEN.LoginLogNumber = objRow[conLoginLog.LoginLogNumber] == DBNull.Value ? null : objRow[conLoginLog.LoginLogNumber].ToString().Trim(); //LoginLogNumber
objLoginLogEN.LoginIP = objRow[conLoginLog.LoginIP] == DBNull.Value ? null : objRow[conLoginLog.LoginIP].ToString().Trim(); //LoginIP
objLoginLogEN.FailReason = objRow[conLoginLog.FailReason] == DBNull.Value ? null : objRow[conLoginLog.FailReason].ToString().Trim(); //FailReason
objLoginLogEN.LoginResult = objRow[conLoginLog.LoginResult] == DBNull.Value ? null : objRow[conLoginLog.LoginResult].ToString().Trim(); //LoginResult
objLoginLogEN.LoginTime = objRow[conLoginLog.LoginTime] == DBNull.Value ? null : objRow[conLoginLog.LoginTime].ToString().Trim(); //LoginTime
objLoginLogEN.LoginUserId = objRow[conLoginLog.LoginUserId] == DBNull.Value ? null : objRow[conLoginLog.LoginUserId].ToString().Trim(); //LoginUserId
objLoginLogEN.OnlineTime = objRow[conLoginLog.OnlineTime] == DBNull.Value ? null : objRow[conLoginLog.OnlineTime].ToString().Trim(); //OnlineTime
objLoginLogEN.OutTime = objRow[conLoginLog.OutTime] == DBNull.Value ? null : objRow[conLoginLog.OutTime].ToString().Trim(); //OutTime
objLoginLogEN.Memo = objRow[conLoginLog.Memo] == DBNull.Value ? null : objRow[conLoginLog.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsLoginLogDA: GetObjLst)", objException.Message));
}
objLoginLogEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objLoginLogEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.clsGeneCodeBase:GenGetObjLstByTabName)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <param name = "strTabName">表名</param>
 /// <returns>返回对象列表</returns>
public List<clsLoginLogEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsLoginLogDA:GetObjLstByTabName)", objException.Message));
}
List<clsLoginLogEN> arrObjLst = new List<clsLoginLogEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsLoginLogDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsLoginLogEN objLoginLogEN = new clsLoginLogEN();
try
{
objLoginLogEN.LoginLogId = TransNullToInt(objRow[conLoginLog.LoginLogId].ToString().Trim()); //LoginLogId
objLoginLogEN.LoginLogNumber = objRow[conLoginLog.LoginLogNumber] == DBNull.Value ? null : objRow[conLoginLog.LoginLogNumber].ToString().Trim(); //LoginLogNumber
objLoginLogEN.LoginIP = objRow[conLoginLog.LoginIP] == DBNull.Value ? null : objRow[conLoginLog.LoginIP].ToString().Trim(); //LoginIP
objLoginLogEN.FailReason = objRow[conLoginLog.FailReason] == DBNull.Value ? null : objRow[conLoginLog.FailReason].ToString().Trim(); //FailReason
objLoginLogEN.LoginResult = objRow[conLoginLog.LoginResult] == DBNull.Value ? null : objRow[conLoginLog.LoginResult].ToString().Trim(); //LoginResult
objLoginLogEN.LoginTime = objRow[conLoginLog.LoginTime] == DBNull.Value ? null : objRow[conLoginLog.LoginTime].ToString().Trim(); //LoginTime
objLoginLogEN.LoginUserId = objRow[conLoginLog.LoginUserId] == DBNull.Value ? null : objRow[conLoginLog.LoginUserId].ToString().Trim(); //LoginUserId
objLoginLogEN.OnlineTime = objRow[conLoginLog.OnlineTime] == DBNull.Value ? null : objRow[conLoginLog.OnlineTime].ToString().Trim(); //OnlineTime
objLoginLogEN.OutTime = objRow[conLoginLog.OutTime] == DBNull.Value ? null : objRow[conLoginLog.OutTime].ToString().Trim(); //OutTime
objLoginLogEN.Memo = objRow[conLoginLog.Memo] == DBNull.Value ? null : objRow[conLoginLog.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsLoginLogDA: GetObjLst)", objException.Message));
}
objLoginLogEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objLoginLogEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objLoginLogEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetLoginLog(ref clsLoginLogEN objLoginLogEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsLoginLogDA.GetSpecSQLObj();
strSQL = "Select * from LoginLog where LoginLogId = " + ""+ objLoginLogEN.LoginLogId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objLoginLogEN.LoginLogId = TransNullToInt(objDT.Rows[0][conLoginLog.LoginLogId].ToString().Trim()); //LoginLogId(字段类型:bigint,字段长度:8,是否可空:False)
 objLoginLogEN.LoginLogNumber = objDT.Rows[0][conLoginLog.LoginLogNumber].ToString().Trim(); //LoginLogNumber(字段类型:varchar,字段长度:500,是否可空:True)
 objLoginLogEN.LoginIP = objDT.Rows[0][conLoginLog.LoginIP].ToString().Trim(); //LoginIP(字段类型:varchar,字段长度:200,是否可空:True)
 objLoginLogEN.FailReason = objDT.Rows[0][conLoginLog.FailReason].ToString().Trim(); //FailReason(字段类型:varchar,字段长度:500,是否可空:True)
 objLoginLogEN.LoginResult = objDT.Rows[0][conLoginLog.LoginResult].ToString().Trim(); //LoginResult(字段类型:varchar,字段长度:500,是否可空:True)
 objLoginLogEN.LoginTime = objDT.Rows[0][conLoginLog.LoginTime].ToString().Trim(); //LoginTime(字段类型:varchar,字段长度:20,是否可空:True)
 objLoginLogEN.LoginUserId = objDT.Rows[0][conLoginLog.LoginUserId].ToString().Trim(); //LoginUserId(字段类型:varchar,字段长度:200,是否可空:True)
 objLoginLogEN.OnlineTime = objDT.Rows[0][conLoginLog.OnlineTime].ToString().Trim(); //OnlineTime(字段类型:varchar,字段长度:200,是否可空:True)
 objLoginLogEN.OutTime = objDT.Rows[0][conLoginLog.OutTime].ToString().Trim(); //OutTime(字段类型:varchar,字段长度:20,是否可空:True)
 objLoginLogEN.Memo = objDT.Rows[0][conLoginLog.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsLoginLogDA: GetLoginLog)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngLoginLogId">表关键字</param>
 /// <returns>表对象</returns>
public clsLoginLogEN GetObjByLoginLogId(long lngLoginLogId)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsLoginLogDA.GetSpecSQLObj();
strSQL = "Select * from LoginLog where LoginLogId = " + ""+ lngLoginLogId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsLoginLogEN objLoginLogEN = new clsLoginLogEN();
try
{
 objLoginLogEN.LoginLogId = Int32.Parse(objRow[conLoginLog.LoginLogId].ToString().Trim()); //LoginLogId(字段类型:bigint,字段长度:8,是否可空:False)
 objLoginLogEN.LoginLogNumber = objRow[conLoginLog.LoginLogNumber] == DBNull.Value ? null : objRow[conLoginLog.LoginLogNumber].ToString().Trim(); //LoginLogNumber(字段类型:varchar,字段长度:500,是否可空:True)
 objLoginLogEN.LoginIP = objRow[conLoginLog.LoginIP] == DBNull.Value ? null : objRow[conLoginLog.LoginIP].ToString().Trim(); //LoginIP(字段类型:varchar,字段长度:200,是否可空:True)
 objLoginLogEN.FailReason = objRow[conLoginLog.FailReason] == DBNull.Value ? null : objRow[conLoginLog.FailReason].ToString().Trim(); //FailReason(字段类型:varchar,字段长度:500,是否可空:True)
 objLoginLogEN.LoginResult = objRow[conLoginLog.LoginResult] == DBNull.Value ? null : objRow[conLoginLog.LoginResult].ToString().Trim(); //LoginResult(字段类型:varchar,字段长度:500,是否可空:True)
 objLoginLogEN.LoginTime = objRow[conLoginLog.LoginTime] == DBNull.Value ? null : objRow[conLoginLog.LoginTime].ToString().Trim(); //LoginTime(字段类型:varchar,字段长度:20,是否可空:True)
 objLoginLogEN.LoginUserId = objRow[conLoginLog.LoginUserId] == DBNull.Value ? null : objRow[conLoginLog.LoginUserId].ToString().Trim(); //LoginUserId(字段类型:varchar,字段长度:200,是否可空:True)
 objLoginLogEN.OnlineTime = objRow[conLoginLog.OnlineTime] == DBNull.Value ? null : objRow[conLoginLog.OnlineTime].ToString().Trim(); //OnlineTime(字段类型:varchar,字段长度:200,是否可空:True)
 objLoginLogEN.OutTime = objRow[conLoginLog.OutTime] == DBNull.Value ? null : objRow[conLoginLog.OutTime].ToString().Trim(); //OutTime(字段类型:varchar,字段长度:20,是否可空:True)
 objLoginLogEN.Memo = objRow[conLoginLog.Memo] == DBNull.Value ? null : objRow[conLoginLog.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsLoginLogDA: GetObjByLoginLogId)", objException.Message));
}
return objLoginLogEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsLoginLogEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsLoginLogDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsLoginLogDA.GetSpecSQLObj();
strSQL = "Select * from LoginLog where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsLoginLogEN objLoginLogEN = new clsLoginLogEN()
{
LoginLogId = TransNullToInt(objRow[conLoginLog.LoginLogId].ToString().Trim()), //LoginLogId
LoginLogNumber = objRow[conLoginLog.LoginLogNumber] == DBNull.Value ? null : objRow[conLoginLog.LoginLogNumber].ToString().Trim(), //LoginLogNumber
LoginIP = objRow[conLoginLog.LoginIP] == DBNull.Value ? null : objRow[conLoginLog.LoginIP].ToString().Trim(), //LoginIP
FailReason = objRow[conLoginLog.FailReason] == DBNull.Value ? null : objRow[conLoginLog.FailReason].ToString().Trim(), //FailReason
LoginResult = objRow[conLoginLog.LoginResult] == DBNull.Value ? null : objRow[conLoginLog.LoginResult].ToString().Trim(), //LoginResult
LoginTime = objRow[conLoginLog.LoginTime] == DBNull.Value ? null : objRow[conLoginLog.LoginTime].ToString().Trim(), //LoginTime
LoginUserId = objRow[conLoginLog.LoginUserId] == DBNull.Value ? null : objRow[conLoginLog.LoginUserId].ToString().Trim(), //LoginUserId
OnlineTime = objRow[conLoginLog.OnlineTime] == DBNull.Value ? null : objRow[conLoginLog.OnlineTime].ToString().Trim(), //OnlineTime
OutTime = objRow[conLoginLog.OutTime] == DBNull.Value ? null : objRow[conLoginLog.OutTime].ToString().Trim(), //OutTime
Memo = objRow[conLoginLog.Memo] == DBNull.Value ? null : objRow[conLoginLog.Memo].ToString().Trim() //备注
};
objLoginLogEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objLoginLogEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsLoginLogDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsLoginLogEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsLoginLogEN objLoginLogEN = new clsLoginLogEN();
try
{
objLoginLogEN.LoginLogId = TransNullToInt(objRow[conLoginLog.LoginLogId].ToString().Trim()); //LoginLogId
objLoginLogEN.LoginLogNumber = objRow[conLoginLog.LoginLogNumber] == DBNull.Value ? null : objRow[conLoginLog.LoginLogNumber].ToString().Trim(); //LoginLogNumber
objLoginLogEN.LoginIP = objRow[conLoginLog.LoginIP] == DBNull.Value ? null : objRow[conLoginLog.LoginIP].ToString().Trim(); //LoginIP
objLoginLogEN.FailReason = objRow[conLoginLog.FailReason] == DBNull.Value ? null : objRow[conLoginLog.FailReason].ToString().Trim(); //FailReason
objLoginLogEN.LoginResult = objRow[conLoginLog.LoginResult] == DBNull.Value ? null : objRow[conLoginLog.LoginResult].ToString().Trim(); //LoginResult
objLoginLogEN.LoginTime = objRow[conLoginLog.LoginTime] == DBNull.Value ? null : objRow[conLoginLog.LoginTime].ToString().Trim(); //LoginTime
objLoginLogEN.LoginUserId = objRow[conLoginLog.LoginUserId] == DBNull.Value ? null : objRow[conLoginLog.LoginUserId].ToString().Trim(); //LoginUserId
objLoginLogEN.OnlineTime = objRow[conLoginLog.OnlineTime] == DBNull.Value ? null : objRow[conLoginLog.OnlineTime].ToString().Trim(); //OnlineTime
objLoginLogEN.OutTime = objRow[conLoginLog.OutTime] == DBNull.Value ? null : objRow[conLoginLog.OutTime].ToString().Trim(); //OutTime
objLoginLogEN.Memo = objRow[conLoginLog.Memo] == DBNull.Value ? null : objRow[conLoginLog.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsLoginLogDA: GetObjByDataRowLoginLog)", objException.Message));
}
objLoginLogEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objLoginLogEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsLoginLogEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsLoginLogEN objLoginLogEN = new clsLoginLogEN();
try
{
objLoginLogEN.LoginLogId = TransNullToInt(objRow[conLoginLog.LoginLogId].ToString().Trim()); //LoginLogId
objLoginLogEN.LoginLogNumber = objRow[conLoginLog.LoginLogNumber] == DBNull.Value ? null : objRow[conLoginLog.LoginLogNumber].ToString().Trim(); //LoginLogNumber
objLoginLogEN.LoginIP = objRow[conLoginLog.LoginIP] == DBNull.Value ? null : objRow[conLoginLog.LoginIP].ToString().Trim(); //LoginIP
objLoginLogEN.FailReason = objRow[conLoginLog.FailReason] == DBNull.Value ? null : objRow[conLoginLog.FailReason].ToString().Trim(); //FailReason
objLoginLogEN.LoginResult = objRow[conLoginLog.LoginResult] == DBNull.Value ? null : objRow[conLoginLog.LoginResult].ToString().Trim(); //LoginResult
objLoginLogEN.LoginTime = objRow[conLoginLog.LoginTime] == DBNull.Value ? null : objRow[conLoginLog.LoginTime].ToString().Trim(); //LoginTime
objLoginLogEN.LoginUserId = objRow[conLoginLog.LoginUserId] == DBNull.Value ? null : objRow[conLoginLog.LoginUserId].ToString().Trim(); //LoginUserId
objLoginLogEN.OnlineTime = objRow[conLoginLog.OnlineTime] == DBNull.Value ? null : objRow[conLoginLog.OnlineTime].ToString().Trim(); //OnlineTime
objLoginLogEN.OutTime = objRow[conLoginLog.OutTime] == DBNull.Value ? null : objRow[conLoginLog.OutTime].ToString().Trim(); //OutTime
objLoginLogEN.Memo = objRow[conLoginLog.Memo] == DBNull.Value ? null : objRow[conLoginLog.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsLoginLogDA: GetObjByDataRow)", objException.Message));
}
objLoginLogEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objLoginLogEN;
}

 #endregion 获取一个实体对象

 #region 获取一个关键字值

 /// <summary>
 /// 获取当前表最大字符型关键字ID
 /// (AutoGCLib.clsGeneCodeBase:GenGetMaxStrID)
 /// </summary>
 /// <returns>返回的最大关键字值ID</returns>
public static string GetMaxStrId()
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsLoginLogDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsLoginLogEN._CurrTabName, conLoginLog.LoginLogId, 8, "");
return strMaxValue;
}

 /// <summary>
 /// 根据前缀获取当前表最大字符型关键字ID
 /// (AutoGCLib.clsGeneCodeBase:GenGetMaxStrIdByPrefix)
 /// </summary>
 /// <returns>返回的最大关键字值ID</returns>
public string GetMaxStrIdByPrefix(string strPrefix)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsLoginLogDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsLoginLogEN._CurrTabName, conLoginLog.LoginLogId, 8, strPrefix);
return strMaxValue;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的关键字值
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstID)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public long GetFirstID(string strCondition) 
{
string strSQL ;
 System.Data.DataTable objDT ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsLoginLogDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select LoginLogId from LoginLog where " + strCondition;
try
{
objDT = objSQL.GetDataTable(strSQL);
}
catch (Exception objException)
{
clsGeneralTab2. LogErrorS(objException, "");
throw new Exception(EXCEPTION_MSG + objException.Message, objException);
}
finally
{
}

if (objDT.Rows.Count  ==  0)
{
return 0;
}
strKeyValue = objDT.Rows[0][0].ToString();
return long.Parse(strKeyValue);
}

 #endregion 获取一个关键字值

 #region 获取多个关键字值列表

 /// <summary>
 /// 获取当前表满足条件的所有记录的关键字值列表
 /// (AutoGCLib.clsGeneCodeBase:GenGetPrimaryKeyID)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回的关键字值列表</returns>
public List<string> GetID(string strCondition) 
{
string strSQL ;
 System.Data.DataTable objDT ;
List<string> arrList = new List<string>();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsLoginLogDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select LoginLogId from LoginLog where " + strCondition;
try
{
objDT = objSQL.GetDataTable(strSQL);
}
catch (Exception objException)
{
clsGeneralTab2. LogErrorS(objException, "");
throw new Exception(EXCEPTION_MSG + objException.Message, objException);
}
finally
{
}

if (objDT.Rows.Count  ==  0)
{
return null;
}
for (iRow = 0; iRow<=  objDT.Rows.Count - 1;iRow++)
{
strKeyValue = "";
for (iCol = 0; iCol<=  objDT.Columns.Count - 1;iCol++)
{
if (iCol  ==  0)
{
strKeyValue +=  objDT.Rows[iRow][iCol].ToString();
}
else
{
strKeyValue +=  "//" + objDT.Rows[iRow][iCol].ToString();
}
}
arrList.Add(strKeyValue);
}
return arrList;
}

 #endregion 获取多个关键字值列表

 #region 判断记录是否存在

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.clsGeneCodeBase:GenIsExist_S)
 /// </summary>
 /// <param name = "lngLoginLogId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(long lngLoginLogId)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsLoginLogDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("LoginLog", "LoginLogId = " + ""+ lngLoginLogId+""))
{
return true;
}
else
{
return false;
}
}

 /// <summary>
 /// 功能:判断是否存在某一条件的记录
 /// (AutoGCLib.clsGeneCodeBase:GenIsExistCondRec_S)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>如果存在就返回TRUE,否则返回FALSE</returns>
public bool IsExistCondRec(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsLoginLogDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsLoginLogDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("LoginLog", strCondition))
{
return true;
}
else
{
return false;
}
}

 /// <summary>
 /// 检查是否存在当前表
 /// (AutoGCLib.clsGeneCodeBase:GenIsExistTable)
 /// </summary>
 /// <returns>存在就返回True,否则返回False</returns>
public static bool IsExistTable()
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsLoginLogDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("LoginLog");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsLoginLogEN objLoginLogEN)
 {
 if (objLoginLogEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objLoginLogEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsLoginLogDA.GetSpecSQLObj();
strSQL = "Select * from LoginLog where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "LoginLog");
objRow = objDS.Tables["LoginLog"].NewRow();
 if (objLoginLogEN.LoginLogNumber !=  "")
 {
objRow[conLoginLog.LoginLogNumber] = objLoginLogEN.LoginLogNumber; //LoginLogNumber
 }
 if (objLoginLogEN.LoginIP !=  "")
 {
objRow[conLoginLog.LoginIP] = objLoginLogEN.LoginIP; //LoginIP
 }
 if (objLoginLogEN.FailReason !=  "")
 {
objRow[conLoginLog.FailReason] = objLoginLogEN.FailReason; //FailReason
 }
 if (objLoginLogEN.LoginResult !=  "")
 {
objRow[conLoginLog.LoginResult] = objLoginLogEN.LoginResult; //LoginResult
 }
 if (objLoginLogEN.LoginTime !=  "")
 {
objRow[conLoginLog.LoginTime] = objLoginLogEN.LoginTime; //LoginTime
 }
 if (objLoginLogEN.LoginUserId !=  "")
 {
objRow[conLoginLog.LoginUserId] = objLoginLogEN.LoginUserId; //LoginUserId
 }
 if (objLoginLogEN.OnlineTime !=  "")
 {
objRow[conLoginLog.OnlineTime] = objLoginLogEN.OnlineTime; //OnlineTime
 }
 if (objLoginLogEN.OutTime !=  "")
 {
objRow[conLoginLog.OutTime] = objLoginLogEN.OutTime; //OutTime
 }
 if (objLoginLogEN.Memo !=  "")
 {
objRow[conLoginLog.Memo] = objLoginLogEN.Memo; //备注
 }
objDS.Tables[clsLoginLogEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsLoginLogEN._CurrTabName);
}
catch (Exception objException)
{
clsGeneralTab2. LogErrorS(objException, "");
throw new Exception(EXCEPTION_MSG + objException.Message, objException);
}
finally
{
}
return true;
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2)
 /// </summary>
 /// <param name = "objLoginLogEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsLoginLogEN objLoginLogEN)
{
 if (objLoginLogEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objLoginLogEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objLoginLogEN.LoginLogNumber !=  null)
 {
 arrFieldListForInsert.Add(conLoginLog.LoginLogNumber);
 var strLoginLogNumber = objLoginLogEN.LoginLogNumber.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLoginLogNumber + "'");
 }
 
 if (objLoginLogEN.LoginIP !=  null)
 {
 arrFieldListForInsert.Add(conLoginLog.LoginIP);
 var strLoginIP = objLoginLogEN.LoginIP.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLoginIP + "'");
 }
 
 if (objLoginLogEN.FailReason !=  null)
 {
 arrFieldListForInsert.Add(conLoginLog.FailReason);
 var strFailReason = objLoginLogEN.FailReason.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFailReason + "'");
 }
 
 if (objLoginLogEN.LoginResult !=  null)
 {
 arrFieldListForInsert.Add(conLoginLog.LoginResult);
 var strLoginResult = objLoginLogEN.LoginResult.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLoginResult + "'");
 }
 
 if (objLoginLogEN.LoginTime !=  null)
 {
 arrFieldListForInsert.Add(conLoginLog.LoginTime);
 var strLoginTime = objLoginLogEN.LoginTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLoginTime + "'");
 }
 
 if (objLoginLogEN.LoginUserId !=  null)
 {
 arrFieldListForInsert.Add(conLoginLog.LoginUserId);
 var strLoginUserId = objLoginLogEN.LoginUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLoginUserId + "'");
 }
 
 if (objLoginLogEN.OnlineTime !=  null)
 {
 arrFieldListForInsert.Add(conLoginLog.OnlineTime);
 var strOnlineTime = objLoginLogEN.OnlineTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strOnlineTime + "'");
 }
 
 if (objLoginLogEN.OutTime !=  null)
 {
 arrFieldListForInsert.Add(conLoginLog.OutTime);
 var strOutTime = objLoginLogEN.OutTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strOutTime + "'");
 }
 
 if (objLoginLogEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conLoginLog.Memo);
 var strMemo = objLoginLogEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into LoginLog");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsLoginLogDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objLoginLogEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsLoginLogEN objLoginLogEN)
{
 if (objLoginLogEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objLoginLogEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objLoginLogEN.LoginLogNumber !=  null)
 {
 arrFieldListForInsert.Add(conLoginLog.LoginLogNumber);
 var strLoginLogNumber = objLoginLogEN.LoginLogNumber.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLoginLogNumber + "'");
 }
 
 if (objLoginLogEN.LoginIP !=  null)
 {
 arrFieldListForInsert.Add(conLoginLog.LoginIP);
 var strLoginIP = objLoginLogEN.LoginIP.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLoginIP + "'");
 }
 
 if (objLoginLogEN.FailReason !=  null)
 {
 arrFieldListForInsert.Add(conLoginLog.FailReason);
 var strFailReason = objLoginLogEN.FailReason.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFailReason + "'");
 }
 
 if (objLoginLogEN.LoginResult !=  null)
 {
 arrFieldListForInsert.Add(conLoginLog.LoginResult);
 var strLoginResult = objLoginLogEN.LoginResult.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLoginResult + "'");
 }
 
 if (objLoginLogEN.LoginTime !=  null)
 {
 arrFieldListForInsert.Add(conLoginLog.LoginTime);
 var strLoginTime = objLoginLogEN.LoginTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLoginTime + "'");
 }
 
 if (objLoginLogEN.LoginUserId !=  null)
 {
 arrFieldListForInsert.Add(conLoginLog.LoginUserId);
 var strLoginUserId = objLoginLogEN.LoginUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLoginUserId + "'");
 }
 
 if (objLoginLogEN.OnlineTime !=  null)
 {
 arrFieldListForInsert.Add(conLoginLog.OnlineTime);
 var strOnlineTime = objLoginLogEN.OnlineTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strOnlineTime + "'");
 }
 
 if (objLoginLogEN.OutTime !=  null)
 {
 arrFieldListForInsert.Add(conLoginLog.OutTime);
 var strOutTime = objLoginLogEN.OutTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strOutTime + "'");
 }
 
 if (objLoginLogEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conLoginLog.Memo);
 var strMemo = objLoginLogEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into LoginLog");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsLoginLogDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString()).Rows[0][0].ToString();
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objLoginLogEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsLoginLogEN objLoginLogEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objLoginLogEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objLoginLogEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objLoginLogEN.LoginLogNumber !=  null)
 {
 arrFieldListForInsert.Add(conLoginLog.LoginLogNumber);
 var strLoginLogNumber = objLoginLogEN.LoginLogNumber.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLoginLogNumber + "'");
 }
 
 if (objLoginLogEN.LoginIP !=  null)
 {
 arrFieldListForInsert.Add(conLoginLog.LoginIP);
 var strLoginIP = objLoginLogEN.LoginIP.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLoginIP + "'");
 }
 
 if (objLoginLogEN.FailReason !=  null)
 {
 arrFieldListForInsert.Add(conLoginLog.FailReason);
 var strFailReason = objLoginLogEN.FailReason.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFailReason + "'");
 }
 
 if (objLoginLogEN.LoginResult !=  null)
 {
 arrFieldListForInsert.Add(conLoginLog.LoginResult);
 var strLoginResult = objLoginLogEN.LoginResult.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLoginResult + "'");
 }
 
 if (objLoginLogEN.LoginTime !=  null)
 {
 arrFieldListForInsert.Add(conLoginLog.LoginTime);
 var strLoginTime = objLoginLogEN.LoginTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLoginTime + "'");
 }
 
 if (objLoginLogEN.LoginUserId !=  null)
 {
 arrFieldListForInsert.Add(conLoginLog.LoginUserId);
 var strLoginUserId = objLoginLogEN.LoginUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLoginUserId + "'");
 }
 
 if (objLoginLogEN.OnlineTime !=  null)
 {
 arrFieldListForInsert.Add(conLoginLog.OnlineTime);
 var strOnlineTime = objLoginLogEN.OnlineTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strOnlineTime + "'");
 }
 
 if (objLoginLogEN.OutTime !=  null)
 {
 arrFieldListForInsert.Add(conLoginLog.OutTime);
 var strOutTime = objLoginLogEN.OutTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strOutTime + "'");
 }
 
 if (objLoginLogEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conLoginLog.Memo);
 var strMemo = objLoginLogEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into LoginLog");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsLoginLogDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString(), objSqlConnection, objSqlTransaction).Rows[0][0].ToString();
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objLoginLogEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsLoginLogEN objLoginLogEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objLoginLogEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objLoginLogEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objLoginLogEN.LoginLogNumber !=  null)
 {
 arrFieldListForInsert.Add(conLoginLog.LoginLogNumber);
 var strLoginLogNumber = objLoginLogEN.LoginLogNumber.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLoginLogNumber + "'");
 }
 
 if (objLoginLogEN.LoginIP !=  null)
 {
 arrFieldListForInsert.Add(conLoginLog.LoginIP);
 var strLoginIP = objLoginLogEN.LoginIP.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLoginIP + "'");
 }
 
 if (objLoginLogEN.FailReason !=  null)
 {
 arrFieldListForInsert.Add(conLoginLog.FailReason);
 var strFailReason = objLoginLogEN.FailReason.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFailReason + "'");
 }
 
 if (objLoginLogEN.LoginResult !=  null)
 {
 arrFieldListForInsert.Add(conLoginLog.LoginResult);
 var strLoginResult = objLoginLogEN.LoginResult.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLoginResult + "'");
 }
 
 if (objLoginLogEN.LoginTime !=  null)
 {
 arrFieldListForInsert.Add(conLoginLog.LoginTime);
 var strLoginTime = objLoginLogEN.LoginTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLoginTime + "'");
 }
 
 if (objLoginLogEN.LoginUserId !=  null)
 {
 arrFieldListForInsert.Add(conLoginLog.LoginUserId);
 var strLoginUserId = objLoginLogEN.LoginUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLoginUserId + "'");
 }
 
 if (objLoginLogEN.OnlineTime !=  null)
 {
 arrFieldListForInsert.Add(conLoginLog.OnlineTime);
 var strOnlineTime = objLoginLogEN.OnlineTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strOnlineTime + "'");
 }
 
 if (objLoginLogEN.OutTime !=  null)
 {
 arrFieldListForInsert.Add(conLoginLog.OutTime);
 var strOutTime = objLoginLogEN.OutTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strOutTime + "'");
 }
 
 if (objLoginLogEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conLoginLog.Memo);
 var strMemo = objLoginLogEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into LoginLog");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsLoginLogDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewLoginLogs(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsLoginLogDA.GetSpecSQLObj();
strSQL = "Select * from LoginLog where LoginLogId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "LoginLog");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
long lngLoginLogId = TransNullToInt(oRow[conLoginLog.LoginLogId].ToString().Trim());
if (IsExist(lngLoginLogId))
{
 string strResult = "关键字变量值为:" + string.Format("LoginLogId = {0}", lngLoginLogId) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsLoginLogEN._CurrTabName ].NewRow();
objRow[conLoginLog.LoginLogNumber] = oRow[conLoginLog.LoginLogNumber].ToString().Trim(); //LoginLogNumber
objRow[conLoginLog.LoginIP] = oRow[conLoginLog.LoginIP].ToString().Trim(); //LoginIP
objRow[conLoginLog.FailReason] = oRow[conLoginLog.FailReason].ToString().Trim(); //FailReason
objRow[conLoginLog.LoginResult] = oRow[conLoginLog.LoginResult].ToString().Trim(); //LoginResult
objRow[conLoginLog.LoginTime] = oRow[conLoginLog.LoginTime].ToString().Trim(); //LoginTime
objRow[conLoginLog.LoginUserId] = oRow[conLoginLog.LoginUserId].ToString().Trim(); //LoginUserId
objRow[conLoginLog.OnlineTime] = oRow[conLoginLog.OnlineTime].ToString().Trim(); //OnlineTime
objRow[conLoginLog.OutTime] = oRow[conLoginLog.OutTime].ToString().Trim(); //OutTime
objRow[conLoginLog.Memo] = oRow[conLoginLog.Memo].ToString().Trim(); //备注
 objDS.Tables[clsLoginLogEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsLoginLogEN._CurrTabName);
}
catch(Exception objException) 
{
clsGeneralTab2. LogErrorS(objException, "");
throw new Exception(EXCEPTION_MSG + objException.Message, objException);
}
finally
{
objSQL.SQLConnect.Close();
}
return true;
}

 #endregion 添加记录

 #region 修改记录

 /// <summary>
 /// 功能:通过ADO修改记录
 /// (AutoGCLib.DALCode4CSharp:GenUpdate)
 /// </summary>
 /// <param name = "objLoginLogEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsLoginLogEN objLoginLogEN)
{
 if (objLoginLogEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objLoginLogEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsLoginLogDA.GetSpecSQLObj();
strSQL = "Select * from LoginLog where LoginLogId = " + ""+ objLoginLogEN.LoginLogId+"";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsLoginLogEN._CurrTabName);
if (objDS.Tables[clsLoginLogEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:LoginLogId = " + ""+ objLoginLogEN.LoginLogId+"");
return false;
}
objRow = objDS.Tables[clsLoginLogEN._CurrTabName].Rows[0];
 if (objLoginLogEN.IsUpdated(conLoginLog.LoginLogNumber))
 {
objRow[conLoginLog.LoginLogNumber] = objLoginLogEN.LoginLogNumber; //LoginLogNumber
 }
 if (objLoginLogEN.IsUpdated(conLoginLog.LoginIP))
 {
objRow[conLoginLog.LoginIP] = objLoginLogEN.LoginIP; //LoginIP
 }
 if (objLoginLogEN.IsUpdated(conLoginLog.FailReason))
 {
objRow[conLoginLog.FailReason] = objLoginLogEN.FailReason; //FailReason
 }
 if (objLoginLogEN.IsUpdated(conLoginLog.LoginResult))
 {
objRow[conLoginLog.LoginResult] = objLoginLogEN.LoginResult; //LoginResult
 }
 if (objLoginLogEN.IsUpdated(conLoginLog.LoginTime))
 {
objRow[conLoginLog.LoginTime] = objLoginLogEN.LoginTime; //LoginTime
 }
 if (objLoginLogEN.IsUpdated(conLoginLog.LoginUserId))
 {
objRow[conLoginLog.LoginUserId] = objLoginLogEN.LoginUserId; //LoginUserId
 }
 if (objLoginLogEN.IsUpdated(conLoginLog.OnlineTime))
 {
objRow[conLoginLog.OnlineTime] = objLoginLogEN.OnlineTime; //OnlineTime
 }
 if (objLoginLogEN.IsUpdated(conLoginLog.OutTime))
 {
objRow[conLoginLog.OutTime] = objLoginLogEN.OutTime; //OutTime
 }
 if (objLoginLogEN.IsUpdated(conLoginLog.Memo))
 {
objRow[conLoginLog.Memo] = objLoginLogEN.Memo; //备注
 }
try
{
objDA.Update(objDS, clsLoginLogEN._CurrTabName);
}
catch (Exception objException)
{
clsGeneralTab2. LogErrorS(objException, "");
throw new Exception(EXCEPTION_MSG + objException.Message, objException);
}
finally
{
}
return true;
}


 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.DALCode4CSharp:GenUpdateBySql2)
 /// </summary>
 /// <param name = "objLoginLogEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsLoginLogEN objLoginLogEN)
{
 if (objLoginLogEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objLoginLogEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsLoginLogDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update LoginLog Set ");
 
 if (objLoginLogEN.IsUpdated(conLoginLog.LoginLogNumber))
 {
 if (objLoginLogEN.LoginLogNumber !=  null)
 {
 var strLoginLogNumber = objLoginLogEN.LoginLogNumber.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strLoginLogNumber, conLoginLog.LoginLogNumber); //LoginLogNumber
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conLoginLog.LoginLogNumber); //LoginLogNumber
 }
 }
 
 if (objLoginLogEN.IsUpdated(conLoginLog.LoginIP))
 {
 if (objLoginLogEN.LoginIP !=  null)
 {
 var strLoginIP = objLoginLogEN.LoginIP.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strLoginIP, conLoginLog.LoginIP); //LoginIP
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conLoginLog.LoginIP); //LoginIP
 }
 }
 
 if (objLoginLogEN.IsUpdated(conLoginLog.FailReason))
 {
 if (objLoginLogEN.FailReason !=  null)
 {
 var strFailReason = objLoginLogEN.FailReason.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFailReason, conLoginLog.FailReason); //FailReason
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conLoginLog.FailReason); //FailReason
 }
 }
 
 if (objLoginLogEN.IsUpdated(conLoginLog.LoginResult))
 {
 if (objLoginLogEN.LoginResult !=  null)
 {
 var strLoginResult = objLoginLogEN.LoginResult.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strLoginResult, conLoginLog.LoginResult); //LoginResult
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conLoginLog.LoginResult); //LoginResult
 }
 }
 
 if (objLoginLogEN.IsUpdated(conLoginLog.LoginTime))
 {
 if (objLoginLogEN.LoginTime !=  null)
 {
 var strLoginTime = objLoginLogEN.LoginTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strLoginTime, conLoginLog.LoginTime); //LoginTime
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conLoginLog.LoginTime); //LoginTime
 }
 }
 
 if (objLoginLogEN.IsUpdated(conLoginLog.LoginUserId))
 {
 if (objLoginLogEN.LoginUserId !=  null)
 {
 var strLoginUserId = objLoginLogEN.LoginUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strLoginUserId, conLoginLog.LoginUserId); //LoginUserId
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conLoginLog.LoginUserId); //LoginUserId
 }
 }
 
 if (objLoginLogEN.IsUpdated(conLoginLog.OnlineTime))
 {
 if (objLoginLogEN.OnlineTime !=  null)
 {
 var strOnlineTime = objLoginLogEN.OnlineTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strOnlineTime, conLoginLog.OnlineTime); //OnlineTime
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conLoginLog.OnlineTime); //OnlineTime
 }
 }
 
 if (objLoginLogEN.IsUpdated(conLoginLog.OutTime))
 {
 if (objLoginLogEN.OutTime !=  null)
 {
 var strOutTime = objLoginLogEN.OutTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strOutTime, conLoginLog.OutTime); //OutTime
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conLoginLog.OutTime); //OutTime
 }
 }
 
 if (objLoginLogEN.IsUpdated(conLoginLog.Memo))
 {
 if (objLoginLogEN.Memo !=  null)
 {
 var strMemo = objLoginLogEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conLoginLog.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conLoginLog.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where LoginLogId = {0}", objLoginLogEN.LoginLogId); 
 clsCheckSql.CheckSqlInjection4Update(sbSQL.ToString());
 return objSQL.ExecSql(sbSQL.ToString());
}
catch (Exception objException)
{
string strMsg = string.Format("发生错误:[{0}].SQL:[{1}].({2})",
     objException.Message, sbSQL.ToString(), clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
throw new Exception(strMsg);
}
finally
{
}
}


 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是非优化方式,根据条件修改记录
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.DALCode4CSharp:GenUpdateBySqlWithCondition)
 /// </summary>
 /// <param name = "objLoginLogEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsLoginLogEN objLoginLogEN, string strCondition)
{
 if (objLoginLogEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objLoginLogEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsLoginLogDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update LoginLog Set ");
 
 if (objLoginLogEN.IsUpdated(conLoginLog.LoginLogNumber))
 {
 if (objLoginLogEN.LoginLogNumber !=  null)
 {
 var strLoginLogNumber = objLoginLogEN.LoginLogNumber.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" LoginLogNumber = '{0}',", strLoginLogNumber); //LoginLogNumber
 }
 else
 {
 sbSQL.Append(" LoginLogNumber = null,"); //LoginLogNumber
 }
 }
 
 if (objLoginLogEN.IsUpdated(conLoginLog.LoginIP))
 {
 if (objLoginLogEN.LoginIP !=  null)
 {
 var strLoginIP = objLoginLogEN.LoginIP.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" LoginIP = '{0}',", strLoginIP); //LoginIP
 }
 else
 {
 sbSQL.Append(" LoginIP = null,"); //LoginIP
 }
 }
 
 if (objLoginLogEN.IsUpdated(conLoginLog.FailReason))
 {
 if (objLoginLogEN.FailReason !=  null)
 {
 var strFailReason = objLoginLogEN.FailReason.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FailReason = '{0}',", strFailReason); //FailReason
 }
 else
 {
 sbSQL.Append(" FailReason = null,"); //FailReason
 }
 }
 
 if (objLoginLogEN.IsUpdated(conLoginLog.LoginResult))
 {
 if (objLoginLogEN.LoginResult !=  null)
 {
 var strLoginResult = objLoginLogEN.LoginResult.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" LoginResult = '{0}',", strLoginResult); //LoginResult
 }
 else
 {
 sbSQL.Append(" LoginResult = null,"); //LoginResult
 }
 }
 
 if (objLoginLogEN.IsUpdated(conLoginLog.LoginTime))
 {
 if (objLoginLogEN.LoginTime !=  null)
 {
 var strLoginTime = objLoginLogEN.LoginTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" LoginTime = '{0}',", strLoginTime); //LoginTime
 }
 else
 {
 sbSQL.Append(" LoginTime = null,"); //LoginTime
 }
 }
 
 if (objLoginLogEN.IsUpdated(conLoginLog.LoginUserId))
 {
 if (objLoginLogEN.LoginUserId !=  null)
 {
 var strLoginUserId = objLoginLogEN.LoginUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" LoginUserId = '{0}',", strLoginUserId); //LoginUserId
 }
 else
 {
 sbSQL.Append(" LoginUserId = null,"); //LoginUserId
 }
 }
 
 if (objLoginLogEN.IsUpdated(conLoginLog.OnlineTime))
 {
 if (objLoginLogEN.OnlineTime !=  null)
 {
 var strOnlineTime = objLoginLogEN.OnlineTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" OnlineTime = '{0}',", strOnlineTime); //OnlineTime
 }
 else
 {
 sbSQL.Append(" OnlineTime = null,"); //OnlineTime
 }
 }
 
 if (objLoginLogEN.IsUpdated(conLoginLog.OutTime))
 {
 if (objLoginLogEN.OutTime !=  null)
 {
 var strOutTime = objLoginLogEN.OutTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" OutTime = '{0}',", strOutTime); //OutTime
 }
 else
 {
 sbSQL.Append(" OutTime = null,"); //OutTime
 }
 }
 
 if (objLoginLogEN.IsUpdated(conLoginLog.Memo))
 {
 if (objLoginLogEN.Memo !=  null)
 {
 var strMemo = objLoginLogEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Memo = '{0}',", strMemo); //备注
 }
 else
 {
 sbSQL.Append(" Memo = null,"); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where {0}", strCondition); 
try
{
 clsCheckSql.CheckSqlInjection4Update(sbSQL.ToString());
 return objSQL.ExecSql(sbSQL.ToString());
}
catch (Exception objException)
{
clsGeneralTab2. LogErrorS(objException, "");
throw new Exception(EXCEPTION_MSG + objException.Message, objException);
}
finally
{
}
}


 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式,根据条件修改记录.(带事务处理)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.DALCode4CSharp:GenUpdateBySqlWithConditionTransaction)
 /// </summary>
 /// <param name = "objLoginLogEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsLoginLogEN objLoginLogEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objLoginLogEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objLoginLogEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsLoginLogDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update LoginLog Set ");
 
 if (objLoginLogEN.IsUpdated(conLoginLog.LoginLogNumber))
 {
 if (objLoginLogEN.LoginLogNumber !=  null)
 {
 var strLoginLogNumber = objLoginLogEN.LoginLogNumber.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" LoginLogNumber = '{0}',", strLoginLogNumber); //LoginLogNumber
 }
 else
 {
 sbSQL.Append(" LoginLogNumber = null,"); //LoginLogNumber
 }
 }
 
 if (objLoginLogEN.IsUpdated(conLoginLog.LoginIP))
 {
 if (objLoginLogEN.LoginIP !=  null)
 {
 var strLoginIP = objLoginLogEN.LoginIP.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" LoginIP = '{0}',", strLoginIP); //LoginIP
 }
 else
 {
 sbSQL.Append(" LoginIP = null,"); //LoginIP
 }
 }
 
 if (objLoginLogEN.IsUpdated(conLoginLog.FailReason))
 {
 if (objLoginLogEN.FailReason !=  null)
 {
 var strFailReason = objLoginLogEN.FailReason.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FailReason = '{0}',", strFailReason); //FailReason
 }
 else
 {
 sbSQL.Append(" FailReason = null,"); //FailReason
 }
 }
 
 if (objLoginLogEN.IsUpdated(conLoginLog.LoginResult))
 {
 if (objLoginLogEN.LoginResult !=  null)
 {
 var strLoginResult = objLoginLogEN.LoginResult.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" LoginResult = '{0}',", strLoginResult); //LoginResult
 }
 else
 {
 sbSQL.Append(" LoginResult = null,"); //LoginResult
 }
 }
 
 if (objLoginLogEN.IsUpdated(conLoginLog.LoginTime))
 {
 if (objLoginLogEN.LoginTime !=  null)
 {
 var strLoginTime = objLoginLogEN.LoginTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" LoginTime = '{0}',", strLoginTime); //LoginTime
 }
 else
 {
 sbSQL.Append(" LoginTime = null,"); //LoginTime
 }
 }
 
 if (objLoginLogEN.IsUpdated(conLoginLog.LoginUserId))
 {
 if (objLoginLogEN.LoginUserId !=  null)
 {
 var strLoginUserId = objLoginLogEN.LoginUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" LoginUserId = '{0}',", strLoginUserId); //LoginUserId
 }
 else
 {
 sbSQL.Append(" LoginUserId = null,"); //LoginUserId
 }
 }
 
 if (objLoginLogEN.IsUpdated(conLoginLog.OnlineTime))
 {
 if (objLoginLogEN.OnlineTime !=  null)
 {
 var strOnlineTime = objLoginLogEN.OnlineTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" OnlineTime = '{0}',", strOnlineTime); //OnlineTime
 }
 else
 {
 sbSQL.Append(" OnlineTime = null,"); //OnlineTime
 }
 }
 
 if (objLoginLogEN.IsUpdated(conLoginLog.OutTime))
 {
 if (objLoginLogEN.OutTime !=  null)
 {
 var strOutTime = objLoginLogEN.OutTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" OutTime = '{0}',", strOutTime); //OutTime
 }
 else
 {
 sbSQL.Append(" OutTime = null,"); //OutTime
 }
 }
 
 if (objLoginLogEN.IsUpdated(conLoginLog.Memo))
 {
 if (objLoginLogEN.Memo !=  null)
 {
 var strMemo = objLoginLogEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Memo = '{0}',", strMemo); //备注
 }
 else
 {
 sbSQL.Append(" Memo = null,"); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where {0}", strCondition); 
try
{
 clsCheckSql.CheckSqlInjection4Update(sbSQL.ToString());
 return objSQL.ExecSql(sbSQL.ToString(), objSqlConnection, objSqlTransaction);
}
catch (Exception objException)
{
clsGeneralTab2. LogErrorS(objException, "");
throw new Exception(EXCEPTION_MSG + objException.Message, objException);
}
finally
{
}
}


 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式.(带事务处理)
 /// /// 优点:1、能够处理字段中的单撇问题；
 /// /// 2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库;
 /// /// 3、支持事务处理.
 /// (AutoGCLib.DALCode4CSharp:GenUpdateBySqlWithTransaction2)
 /// </summary>
 /// <param name = "objLoginLogEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsLoginLogEN objLoginLogEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objLoginLogEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objLoginLogEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsLoginLogDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update LoginLog Set ");
 
 if (objLoginLogEN.IsUpdated(conLoginLog.LoginLogNumber))
 {
 if (objLoginLogEN.LoginLogNumber !=  null)
 {
 var strLoginLogNumber = objLoginLogEN.LoginLogNumber.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strLoginLogNumber, conLoginLog.LoginLogNumber); //LoginLogNumber
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conLoginLog.LoginLogNumber); //LoginLogNumber
 }
 }
 
 if (objLoginLogEN.IsUpdated(conLoginLog.LoginIP))
 {
 if (objLoginLogEN.LoginIP !=  null)
 {
 var strLoginIP = objLoginLogEN.LoginIP.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strLoginIP, conLoginLog.LoginIP); //LoginIP
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conLoginLog.LoginIP); //LoginIP
 }
 }
 
 if (objLoginLogEN.IsUpdated(conLoginLog.FailReason))
 {
 if (objLoginLogEN.FailReason !=  null)
 {
 var strFailReason = objLoginLogEN.FailReason.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFailReason, conLoginLog.FailReason); //FailReason
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conLoginLog.FailReason); //FailReason
 }
 }
 
 if (objLoginLogEN.IsUpdated(conLoginLog.LoginResult))
 {
 if (objLoginLogEN.LoginResult !=  null)
 {
 var strLoginResult = objLoginLogEN.LoginResult.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strLoginResult, conLoginLog.LoginResult); //LoginResult
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conLoginLog.LoginResult); //LoginResult
 }
 }
 
 if (objLoginLogEN.IsUpdated(conLoginLog.LoginTime))
 {
 if (objLoginLogEN.LoginTime !=  null)
 {
 var strLoginTime = objLoginLogEN.LoginTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strLoginTime, conLoginLog.LoginTime); //LoginTime
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conLoginLog.LoginTime); //LoginTime
 }
 }
 
 if (objLoginLogEN.IsUpdated(conLoginLog.LoginUserId))
 {
 if (objLoginLogEN.LoginUserId !=  null)
 {
 var strLoginUserId = objLoginLogEN.LoginUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strLoginUserId, conLoginLog.LoginUserId); //LoginUserId
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conLoginLog.LoginUserId); //LoginUserId
 }
 }
 
 if (objLoginLogEN.IsUpdated(conLoginLog.OnlineTime))
 {
 if (objLoginLogEN.OnlineTime !=  null)
 {
 var strOnlineTime = objLoginLogEN.OnlineTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strOnlineTime, conLoginLog.OnlineTime); //OnlineTime
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conLoginLog.OnlineTime); //OnlineTime
 }
 }
 
 if (objLoginLogEN.IsUpdated(conLoginLog.OutTime))
 {
 if (objLoginLogEN.OutTime !=  null)
 {
 var strOutTime = objLoginLogEN.OutTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strOutTime, conLoginLog.OutTime); //OutTime
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conLoginLog.OutTime); //OutTime
 }
 }
 
 if (objLoginLogEN.IsUpdated(conLoginLog.Memo))
 {
 if (objLoginLogEN.Memo !=  null)
 {
 var strMemo = objLoginLogEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conLoginLog.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conLoginLog.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where LoginLogId = {0}", objLoginLogEN.LoginLogId); 
try
{
 clsCheckSql.CheckSqlInjection4Update(sbSQL.ToString());
 return objSQL.ExecSql(sbSQL.ToString(), objSqlConnection, objSqlTransaction);
}
catch (Exception objException)
{
clsGeneralTab2. LogErrorS(objException, "");
throw new Exception(EXCEPTION_MSG + objException.Message, objException);
}
finally
{
}
}


 #endregion 修改记录

 #region 删除记录

 /// <summary>
 /// 功能:删除关键字所指定的记录,通过存储过程(SP)来删除。
 /// (AutoGCLib.DALCode4CSharp:GenDelRecordBySP)
 /// </summary>
 /// <param name = "lngLoginLogId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(long lngLoginLogId) 
{
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsLoginLogDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 lngLoginLogId,
};
 objSQL.ExecSP("LoginLog_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "lngLoginLogId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(long lngLoginLogId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsLoginLogDA.GetSpecSQLObj();
//删除LoginLog本表中与当前对象有关的记录
strSQL = strSQL + "Delete from LoginLog where LoginLogId = " + ""+ lngLoginLogId+"";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelLoginLog(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsLoginLogDA.GetSpecSQLObj();
string strSQL;
string strKeyList;
if (lstKey.Count  == 0) return 0;
strKeyList = "";
for (int i = 0; i<lstKey.Count; i++)
{
if (i == 0) strKeyList = strKeyList + "" + lstKey[i].ToString() + "";
else strKeyList +=  "," + "" + lstKey[i].ToString() + "";
}
strSQL = "";
//删除LoginLog本表中与当前对象有关的记录
strSQL = strSQL + "Delete from LoginLog where LoginLogId in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "lngLoginLogId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(long lngLoginLogId) 
{
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsLoginLogDA.GetSpecSQLObj();
//删除LoginLog本表中与当前对象有关的记录
strSQL = strSQL + "Delete from LoginLog where LoginLogId = " + ""+ lngLoginLogId+"";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelLoginLog(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsLoginLogDA: DelLoginLog)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsLoginLogDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from LoginLog where " + strCondition ;
}
int intRecoCount = objSQL.ExecSql2(strSQL);
return intRecoCount;
}



 /// <summary>
 /// 功能:删除满足条件的多条记录,同时处理事务
 /// (AutoGCLib.clsGeneCodeBase:GenDelCondRecWithTransaction)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回是否删除成功。</returns>
public bool DelLoginLogWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsLoginLogDA: DelLoginLogWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsLoginLogDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from LoginLog where " + strCondition ;
}
 bool bolResult = objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
return bolResult;
}


 #endregion 删除记录

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objLoginLogENS">源对象</param>
 /// <param name = "objLoginLogENT">目标对象</param>
public void CopyTo(clsLoginLogEN objLoginLogENS, clsLoginLogEN objLoginLogENT)
{
objLoginLogENT.LoginLogId = objLoginLogENS.LoginLogId; //LoginLogId
objLoginLogENT.LoginLogNumber = objLoginLogENS.LoginLogNumber; //LoginLogNumber
objLoginLogENT.LoginIP = objLoginLogENS.LoginIP; //LoginIP
objLoginLogENT.FailReason = objLoginLogENS.FailReason; //FailReason
objLoginLogENT.LoginResult = objLoginLogENS.LoginResult; //LoginResult
objLoginLogENT.LoginTime = objLoginLogENS.LoginTime; //LoginTime
objLoginLogENT.LoginUserId = objLoginLogENS.LoginUserId; //LoginUserId
objLoginLogENT.OnlineTime = objLoginLogENS.OnlineTime; //OnlineTime
objLoginLogENT.OutTime = objLoginLogENS.OutTime; //OutTime
objLoginLogENT.Memo = objLoginLogENS.Memo; //备注
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsLoginLogEN objLoginLogEN)
{
//检查字段不能为空(NULL)
//检查字段长度
clsCheckSql.CheckFieldLen(objLoginLogEN.LoginLogNumber, 500, conLoginLog.LoginLogNumber);
clsCheckSql.CheckFieldLen(objLoginLogEN.LoginIP, 200, conLoginLog.LoginIP);
clsCheckSql.CheckFieldLen(objLoginLogEN.FailReason, 500, conLoginLog.FailReason);
clsCheckSql.CheckFieldLen(objLoginLogEN.LoginResult, 500, conLoginLog.LoginResult);
clsCheckSql.CheckFieldLen(objLoginLogEN.LoginTime, 20, conLoginLog.LoginTime);
clsCheckSql.CheckFieldLen(objLoginLogEN.LoginUserId, 200, conLoginLog.LoginUserId);
clsCheckSql.CheckFieldLen(objLoginLogEN.OnlineTime, 200, conLoginLog.OnlineTime);
clsCheckSql.CheckFieldLen(objLoginLogEN.OutTime, 20, conLoginLog.OutTime);
clsCheckSql.CheckFieldLen(objLoginLogEN.Memo, 1000, conLoginLog.Memo);
//检查字段外键固定长度
 objLoginLogEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsLoginLogEN objLoginLogEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objLoginLogEN.LoginLogNumber, 500, conLoginLog.LoginLogNumber);
clsCheckSql.CheckFieldLen(objLoginLogEN.LoginIP, 200, conLoginLog.LoginIP);
clsCheckSql.CheckFieldLen(objLoginLogEN.FailReason, 500, conLoginLog.FailReason);
clsCheckSql.CheckFieldLen(objLoginLogEN.LoginResult, 500, conLoginLog.LoginResult);
clsCheckSql.CheckFieldLen(objLoginLogEN.LoginTime, 20, conLoginLog.LoginTime);
clsCheckSql.CheckFieldLen(objLoginLogEN.LoginUserId, 200, conLoginLog.LoginUserId);
clsCheckSql.CheckFieldLen(objLoginLogEN.OnlineTime, 200, conLoginLog.OnlineTime);
clsCheckSql.CheckFieldLen(objLoginLogEN.OutTime, 20, conLoginLog.OutTime);
clsCheckSql.CheckFieldLen(objLoginLogEN.Memo, 1000, conLoginLog.Memo);
//检查外键字段长度
 objLoginLogEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsLoginLogEN objLoginLogEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objLoginLogEN.LoginLogNumber, 500, conLoginLog.LoginLogNumber);
clsCheckSql.CheckFieldLen(objLoginLogEN.LoginIP, 200, conLoginLog.LoginIP);
clsCheckSql.CheckFieldLen(objLoginLogEN.FailReason, 500, conLoginLog.FailReason);
clsCheckSql.CheckFieldLen(objLoginLogEN.LoginResult, 500, conLoginLog.LoginResult);
clsCheckSql.CheckFieldLen(objLoginLogEN.LoginTime, 20, conLoginLog.LoginTime);
clsCheckSql.CheckFieldLen(objLoginLogEN.LoginUserId, 200, conLoginLog.LoginUserId);
clsCheckSql.CheckFieldLen(objLoginLogEN.OnlineTime, 200, conLoginLog.OnlineTime);
clsCheckSql.CheckFieldLen(objLoginLogEN.OutTime, 20, conLoginLog.OutTime);
clsCheckSql.CheckFieldLen(objLoginLogEN.Memo, 1000, conLoginLog.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objLoginLogEN.LoginLogNumber, conLoginLog.LoginLogNumber);
clsCheckSql.CheckSqlInjection4Field(objLoginLogEN.LoginIP, conLoginLog.LoginIP);
clsCheckSql.CheckSqlInjection4Field(objLoginLogEN.FailReason, conLoginLog.FailReason);
clsCheckSql.CheckSqlInjection4Field(objLoginLogEN.LoginResult, conLoginLog.LoginResult);
clsCheckSql.CheckSqlInjection4Field(objLoginLogEN.LoginTime, conLoginLog.LoginTime);
clsCheckSql.CheckSqlInjection4Field(objLoginLogEN.LoginUserId, conLoginLog.LoginUserId);
clsCheckSql.CheckSqlInjection4Field(objLoginLogEN.OnlineTime, conLoginLog.OnlineTime);
clsCheckSql.CheckSqlInjection4Field(objLoginLogEN.OutTime, conLoginLog.OutTime);
clsCheckSql.CheckSqlInjection4Field(objLoginLogEN.Memo, conLoginLog.Memo);
//检查外键字段长度
 objLoginLogEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--LoginLog(登录日志),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objLoginLogEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clsLoginLogEN objLoginLogEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 if (objLoginLogEN.LoginUserId == null)
{
 sbCondition.AppendFormat(" and LoginUserId is null");
}
else
{
 sbCondition.AppendFormat(" and LoginUserId = '{0}'", objLoginLogEN.LoginUserId);
}
 if (objLoginLogEN.LoginIP == null)
{
 sbCondition.AppendFormat(" and LoginIP is null");
}
else
{
 sbCondition.AppendFormat(" and LoginIP = '{0}'", objLoginLogEN.LoginIP);
}
 if (objLoginLogEN.LoginTime == null)
{
 sbCondition.AppendFormat(" and LoginTime is null");
}
else
{
 sbCondition.AppendFormat(" and LoginTime = '{0}'", objLoginLogEN.LoginTime);
}
return sbCondition.ToString();
}

 #endregion 检查唯一性

 #region 表操作常用函数

 /// <summary>
 /// 功能:获取当前表的记录数, 该表与当前类不相关。
 /// (AutoGCLib.DALCode4CSharp:GenGetRecCount_S)
 /// </summary>
 /// <param name = "strTabName">所给定的表名</param>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount(string strTabName)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsLoginLogDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(strTabName);
return intRecCount;
}


 /// <summary>
 /// 功能:获取给定表中满足条件的记录数, 该表与当前类不相关。
 /// (AutoGCLib.DALCode4CSharp:GenGetRecCountByCond_S)
 /// </summary>
 /// <param name = "strTabName">所给定的表名</param>
 /// <param name = "strCondition">所给定的记录条件</param>
 /// <returns>记录数,为整型</returns>
public static int GetRecCountByCond(string strTabName, string strCondition)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsLoginLogDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(strTabName, strCondition);
return intRecCount;
}



 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.DALCode4CSharp:GenGetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
 public static int GetRecCount()
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsLoginLogDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsLoginLogEN._CurrTabName);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表中满足条件的记录数, 该表与当前类相关。
 /// (AutoGCLib.DALCode4CSharp:GenGetRecCountByCond)
 /// </summary>
 /// <param name = "strCondition">所给定的记录条件</param>
 /// <returns>记录数,为整型</returns>
 public static int GetRecCountByCond(string strCondition)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsLoginLogDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsLoginLogEN._CurrTabName, strCondition);
return intRecCount;
}

 /// <summary>
 /// 功能:获取给定表中的符合条件的某字段的值,以列表返回
 /// (AutoGCLib.DALCode4CSharp:GenGetFldValue_S)
 /// </summary>
 /// <param name = "strTabName">表名</param>
 /// <param name = "strFldName">字段名</param>
 /// <param name = "strCondition">条件串</param>
 /// <returns>获取的字段值列表</returns>
public static List<string> GetFldValue(string strTabName, string strFldName, string strCondition) 
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsLoginLogDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 /// <summary>
 /// 功能:设置给定表中的符合条件的某字段的值
 /// (AutoGCLib.DALCode4CSharp:GenfunSetFldValue_S)
 /// </summary>
 /// <param name = "strTabName">表名</param>
 /// <param name = "strFldName">字段名</param>
 /// <param name = "varValue">值</param>
 /// <param name = "strCondition">条件串</param>
 /// <returns>影响的记录数</returns>
public static int SetFldValue<T>(string strTabName, string strFldName, T varValue, string strCondition) 
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsLoginLogDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}