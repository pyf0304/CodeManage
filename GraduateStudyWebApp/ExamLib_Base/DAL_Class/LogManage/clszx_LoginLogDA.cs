
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clszx_LoginLogDA
 表名:zx_LoginLog(01120813)
 * 版本:2023.11.15.1(服务器:WIN-SRV103-116)
 日期:2023/11/15 22:54:12
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:日志管理(LogManage)
 框架-层名:数据处理层(CS)(DALCode)
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
 /// 中学登录日志(zx_LoginLog)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clszx_LoginLogDA : clsCommBase4DA
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
 return clszx_LoginLogEN._CurrTabName;
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
if (string.IsNullOrEmpty(clszx_LoginLogEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clszx_LoginLogEN._ConnectString);
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
 if (string.IsNullOrEmpty(clszx_LoginLogEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clszx_LoginLogEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clszx_LoginLogDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_LoginLogDA.GetSpecSQLObj();
strSQL = "Select * from zx_LoginLog where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_zx_LoginLog(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clszx_LoginLogDA: GetDataTable_zx_LoginLog)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_LoginLogDA.GetSpecSQLObj();
strSQL = "Select * from zx_LoginLog where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clszx_LoginLogDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_LoginLogDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clszx_LoginLogDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_LoginLogDA.GetSpecSQLObj();
strSQL = "Select * from zx_LoginLog where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clszx_LoginLogDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_LoginLogDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clszx_LoginLogDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_LoginLogDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from zx_LoginLog where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from zx_LoginLog where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clszx_LoginLogDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_LoginLogDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from zx_LoginLog where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clszx_LoginLogDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_LoginLogDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} zx_LoginLog.* from zx_LoginLog Left Join {1} on {2} where {3} and zx_LoginLog.LoginLogId not in (Select top {5} zx_LoginLog.LoginLogId from zx_LoginLog Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from zx_LoginLog where {1} and LoginLogId not in (Select top {2} LoginLogId from zx_LoginLog where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from zx_LoginLog where {1} and LoginLogId not in (Select top {3} LoginLogId from zx_LoginLog where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clszx_LoginLogDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_LoginLogDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} zx_LoginLog.* from zx_LoginLog Left Join {1} on {2} where {3} and zx_LoginLog.LoginLogId not in (Select top {5} zx_LoginLog.LoginLogId from zx_LoginLog Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from zx_LoginLog where {1} and LoginLogId not in (Select top {2} LoginLogId from zx_LoginLog where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from zx_LoginLog where {1} and LoginLogId not in (Select top {3} LoginLogId from zx_LoginLog where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clszx_LoginLogEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clszx_LoginLogDA:GetObjLst)", objException.Message));
}
List<clszx_LoginLogEN> arrObjLst = new List<clszx_LoginLogEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_LoginLogDA.GetSpecSQLObj();
strSQL = "Select * from zx_LoginLog where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_LoginLogEN objzx_LoginLogEN = new clszx_LoginLogEN();
try
{
objzx_LoginLogEN.LoginLogId = TransNullToInt(objRow[conzx_LoginLog.LoginLogId].ToString().Trim()); //LoginLogId
objzx_LoginLogEN.LoginLogNumber = objRow[conzx_LoginLog.LoginLogNumber] == DBNull.Value ? null : objRow[conzx_LoginLog.LoginLogNumber].ToString().Trim(); //LoginLogNumber
objzx_LoginLogEN.LoginIP = objRow[conzx_LoginLog.LoginIP] == DBNull.Value ? null : objRow[conzx_LoginLog.LoginIP].ToString().Trim(); //LoginIP
objzx_LoginLogEN.FailReason = objRow[conzx_LoginLog.FailReason] == DBNull.Value ? null : objRow[conzx_LoginLog.FailReason].ToString().Trim(); //FailReason
objzx_LoginLogEN.LoginResult = objRow[conzx_LoginLog.LoginResult] == DBNull.Value ? null : objRow[conzx_LoginLog.LoginResult].ToString().Trim(); //LoginResult
objzx_LoginLogEN.LoginTime = objRow[conzx_LoginLog.LoginTime] == DBNull.Value ? null : objRow[conzx_LoginLog.LoginTime].ToString().Trim(); //LoginTime
objzx_LoginLogEN.LoginUserId = objRow[conzx_LoginLog.LoginUserId] == DBNull.Value ? null : objRow[conzx_LoginLog.LoginUserId].ToString().Trim(); //LoginUserId
objzx_LoginLogEN.Memo = objRow[conzx_LoginLog.Memo] == DBNull.Value ? null : objRow[conzx_LoginLog.Memo].ToString().Trim(); //备注
objzx_LoginLogEN.OnlineTime = objRow[conzx_LoginLog.OnlineTime] == DBNull.Value ? null : objRow[conzx_LoginLog.OnlineTime].ToString().Trim(); //OnlineTime
objzx_LoginLogEN.OutTime = objRow[conzx_LoginLog.OutTime] == DBNull.Value ? null : objRow[conzx_LoginLog.OutTime].ToString().Trim(); //OutTime
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clszx_LoginLogDA: GetObjLst)", objException.Message));
}
objzx_LoginLogEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objzx_LoginLogEN);
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
public List<clszx_LoginLogEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clszx_LoginLogDA:GetObjLstByTabName)", objException.Message));
}
List<clszx_LoginLogEN> arrObjLst = new List<clszx_LoginLogEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_LoginLogDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_LoginLogEN objzx_LoginLogEN = new clszx_LoginLogEN();
try
{
objzx_LoginLogEN.LoginLogId = TransNullToInt(objRow[conzx_LoginLog.LoginLogId].ToString().Trim()); //LoginLogId
objzx_LoginLogEN.LoginLogNumber = objRow[conzx_LoginLog.LoginLogNumber] == DBNull.Value ? null : objRow[conzx_LoginLog.LoginLogNumber].ToString().Trim(); //LoginLogNumber
objzx_LoginLogEN.LoginIP = objRow[conzx_LoginLog.LoginIP] == DBNull.Value ? null : objRow[conzx_LoginLog.LoginIP].ToString().Trim(); //LoginIP
objzx_LoginLogEN.FailReason = objRow[conzx_LoginLog.FailReason] == DBNull.Value ? null : objRow[conzx_LoginLog.FailReason].ToString().Trim(); //FailReason
objzx_LoginLogEN.LoginResult = objRow[conzx_LoginLog.LoginResult] == DBNull.Value ? null : objRow[conzx_LoginLog.LoginResult].ToString().Trim(); //LoginResult
objzx_LoginLogEN.LoginTime = objRow[conzx_LoginLog.LoginTime] == DBNull.Value ? null : objRow[conzx_LoginLog.LoginTime].ToString().Trim(); //LoginTime
objzx_LoginLogEN.LoginUserId = objRow[conzx_LoginLog.LoginUserId] == DBNull.Value ? null : objRow[conzx_LoginLog.LoginUserId].ToString().Trim(); //LoginUserId
objzx_LoginLogEN.Memo = objRow[conzx_LoginLog.Memo] == DBNull.Value ? null : objRow[conzx_LoginLog.Memo].ToString().Trim(); //备注
objzx_LoginLogEN.OnlineTime = objRow[conzx_LoginLog.OnlineTime] == DBNull.Value ? null : objRow[conzx_LoginLog.OnlineTime].ToString().Trim(); //OnlineTime
objzx_LoginLogEN.OutTime = objRow[conzx_LoginLog.OutTime] == DBNull.Value ? null : objRow[conzx_LoginLog.OutTime].ToString().Trim(); //OutTime
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clszx_LoginLogDA: GetObjLst)", objException.Message));
}
objzx_LoginLogEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objzx_LoginLogEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objzx_LoginLogEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool Getzx_LoginLog(ref clszx_LoginLogEN objzx_LoginLogEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_LoginLogDA.GetSpecSQLObj();
strSQL = "Select * from zx_LoginLog where LoginLogId = " + ""+ objzx_LoginLogEN.LoginLogId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objzx_LoginLogEN.LoginLogId = TransNullToInt(objDT.Rows[0][conzx_LoginLog.LoginLogId].ToString().Trim()); //LoginLogId(字段类型:bigint,字段长度:8,是否可空:False)
 objzx_LoginLogEN.LoginLogNumber = objDT.Rows[0][conzx_LoginLog.LoginLogNumber].ToString().Trim(); //LoginLogNumber(字段类型:varchar,字段长度:500,是否可空:True)
 objzx_LoginLogEN.LoginIP = objDT.Rows[0][conzx_LoginLog.LoginIP].ToString().Trim(); //LoginIP(字段类型:varchar,字段长度:200,是否可空:True)
 objzx_LoginLogEN.FailReason = objDT.Rows[0][conzx_LoginLog.FailReason].ToString().Trim(); //FailReason(字段类型:varchar,字段长度:500,是否可空:True)
 objzx_LoginLogEN.LoginResult = objDT.Rows[0][conzx_LoginLog.LoginResult].ToString().Trim(); //LoginResult(字段类型:varchar,字段长度:500,是否可空:True)
 objzx_LoginLogEN.LoginTime = objDT.Rows[0][conzx_LoginLog.LoginTime].ToString().Trim(); //LoginTime(字段类型:varchar,字段长度:20,是否可空:True)
 objzx_LoginLogEN.LoginUserId = objDT.Rows[0][conzx_LoginLog.LoginUserId].ToString().Trim(); //LoginUserId(字段类型:varchar,字段长度:200,是否可空:True)
 objzx_LoginLogEN.Memo = objDT.Rows[0][conzx_LoginLog.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objzx_LoginLogEN.OnlineTime = objDT.Rows[0][conzx_LoginLog.OnlineTime].ToString().Trim(); //OnlineTime(字段类型:varchar,字段长度:200,是否可空:True)
 objzx_LoginLogEN.OutTime = objDT.Rows[0][conzx_LoginLog.OutTime].ToString().Trim(); //OutTime(字段类型:varchar,字段长度:20,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clszx_LoginLogDA: Getzx_LoginLog)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngLoginLogId">表关键字</param>
 /// <returns>表对象</returns>
public clszx_LoginLogEN GetObjByLoginLogId(long lngLoginLogId)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_LoginLogDA.GetSpecSQLObj();
strSQL = "Select * from zx_LoginLog where LoginLogId = " + ""+ lngLoginLogId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clszx_LoginLogEN objzx_LoginLogEN = new clszx_LoginLogEN();
try
{
 objzx_LoginLogEN.LoginLogId = Int32.Parse(objRow[conzx_LoginLog.LoginLogId].ToString().Trim()); //LoginLogId(字段类型:bigint,字段长度:8,是否可空:False)
 objzx_LoginLogEN.LoginLogNumber = objRow[conzx_LoginLog.LoginLogNumber] == DBNull.Value ? null : objRow[conzx_LoginLog.LoginLogNumber].ToString().Trim(); //LoginLogNumber(字段类型:varchar,字段长度:500,是否可空:True)
 objzx_LoginLogEN.LoginIP = objRow[conzx_LoginLog.LoginIP] == DBNull.Value ? null : objRow[conzx_LoginLog.LoginIP].ToString().Trim(); //LoginIP(字段类型:varchar,字段长度:200,是否可空:True)
 objzx_LoginLogEN.FailReason = objRow[conzx_LoginLog.FailReason] == DBNull.Value ? null : objRow[conzx_LoginLog.FailReason].ToString().Trim(); //FailReason(字段类型:varchar,字段长度:500,是否可空:True)
 objzx_LoginLogEN.LoginResult = objRow[conzx_LoginLog.LoginResult] == DBNull.Value ? null : objRow[conzx_LoginLog.LoginResult].ToString().Trim(); //LoginResult(字段类型:varchar,字段长度:500,是否可空:True)
 objzx_LoginLogEN.LoginTime = objRow[conzx_LoginLog.LoginTime] == DBNull.Value ? null : objRow[conzx_LoginLog.LoginTime].ToString().Trim(); //LoginTime(字段类型:varchar,字段长度:20,是否可空:True)
 objzx_LoginLogEN.LoginUserId = objRow[conzx_LoginLog.LoginUserId] == DBNull.Value ? null : objRow[conzx_LoginLog.LoginUserId].ToString().Trim(); //LoginUserId(字段类型:varchar,字段长度:200,是否可空:True)
 objzx_LoginLogEN.Memo = objRow[conzx_LoginLog.Memo] == DBNull.Value ? null : objRow[conzx_LoginLog.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objzx_LoginLogEN.OnlineTime = objRow[conzx_LoginLog.OnlineTime] == DBNull.Value ? null : objRow[conzx_LoginLog.OnlineTime].ToString().Trim(); //OnlineTime(字段类型:varchar,字段长度:200,是否可空:True)
 objzx_LoginLogEN.OutTime = objRow[conzx_LoginLog.OutTime] == DBNull.Value ? null : objRow[conzx_LoginLog.OutTime].ToString().Trim(); //OutTime(字段类型:varchar,字段长度:20,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clszx_LoginLogDA: GetObjByLoginLogId)", objException.Message));
}
return objzx_LoginLogEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clszx_LoginLogEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clszx_LoginLogDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_LoginLogDA.GetSpecSQLObj();
strSQL = "Select * from zx_LoginLog where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clszx_LoginLogEN objzx_LoginLogEN = new clszx_LoginLogEN()
{
LoginLogId = TransNullToInt(objRow[conzx_LoginLog.LoginLogId].ToString().Trim()), //LoginLogId
LoginLogNumber = objRow[conzx_LoginLog.LoginLogNumber] == DBNull.Value ? null : objRow[conzx_LoginLog.LoginLogNumber].ToString().Trim(), //LoginLogNumber
LoginIP = objRow[conzx_LoginLog.LoginIP] == DBNull.Value ? null : objRow[conzx_LoginLog.LoginIP].ToString().Trim(), //LoginIP
FailReason = objRow[conzx_LoginLog.FailReason] == DBNull.Value ? null : objRow[conzx_LoginLog.FailReason].ToString().Trim(), //FailReason
LoginResult = objRow[conzx_LoginLog.LoginResult] == DBNull.Value ? null : objRow[conzx_LoginLog.LoginResult].ToString().Trim(), //LoginResult
LoginTime = objRow[conzx_LoginLog.LoginTime] == DBNull.Value ? null : objRow[conzx_LoginLog.LoginTime].ToString().Trim(), //LoginTime
LoginUserId = objRow[conzx_LoginLog.LoginUserId] == DBNull.Value ? null : objRow[conzx_LoginLog.LoginUserId].ToString().Trim(), //LoginUserId
Memo = objRow[conzx_LoginLog.Memo] == DBNull.Value ? null : objRow[conzx_LoginLog.Memo].ToString().Trim(), //备注
OnlineTime = objRow[conzx_LoginLog.OnlineTime] == DBNull.Value ? null : objRow[conzx_LoginLog.OnlineTime].ToString().Trim(), //OnlineTime
OutTime = objRow[conzx_LoginLog.OutTime] == DBNull.Value ? null : objRow[conzx_LoginLog.OutTime].ToString().Trim() //OutTime
};
objzx_LoginLogEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objzx_LoginLogEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clszx_LoginLogDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clszx_LoginLogEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clszx_LoginLogEN objzx_LoginLogEN = new clszx_LoginLogEN();
try
{
objzx_LoginLogEN.LoginLogId = TransNullToInt(objRow[conzx_LoginLog.LoginLogId].ToString().Trim()); //LoginLogId
objzx_LoginLogEN.LoginLogNumber = objRow[conzx_LoginLog.LoginLogNumber] == DBNull.Value ? null : objRow[conzx_LoginLog.LoginLogNumber].ToString().Trim(); //LoginLogNumber
objzx_LoginLogEN.LoginIP = objRow[conzx_LoginLog.LoginIP] == DBNull.Value ? null : objRow[conzx_LoginLog.LoginIP].ToString().Trim(); //LoginIP
objzx_LoginLogEN.FailReason = objRow[conzx_LoginLog.FailReason] == DBNull.Value ? null : objRow[conzx_LoginLog.FailReason].ToString().Trim(); //FailReason
objzx_LoginLogEN.LoginResult = objRow[conzx_LoginLog.LoginResult] == DBNull.Value ? null : objRow[conzx_LoginLog.LoginResult].ToString().Trim(); //LoginResult
objzx_LoginLogEN.LoginTime = objRow[conzx_LoginLog.LoginTime] == DBNull.Value ? null : objRow[conzx_LoginLog.LoginTime].ToString().Trim(); //LoginTime
objzx_LoginLogEN.LoginUserId = objRow[conzx_LoginLog.LoginUserId] == DBNull.Value ? null : objRow[conzx_LoginLog.LoginUserId].ToString().Trim(); //LoginUserId
objzx_LoginLogEN.Memo = objRow[conzx_LoginLog.Memo] == DBNull.Value ? null : objRow[conzx_LoginLog.Memo].ToString().Trim(); //备注
objzx_LoginLogEN.OnlineTime = objRow[conzx_LoginLog.OnlineTime] == DBNull.Value ? null : objRow[conzx_LoginLog.OnlineTime].ToString().Trim(); //OnlineTime
objzx_LoginLogEN.OutTime = objRow[conzx_LoginLog.OutTime] == DBNull.Value ? null : objRow[conzx_LoginLog.OutTime].ToString().Trim(); //OutTime
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clszx_LoginLogDA: GetObjByDataRowzx_LoginLog)", objException.Message));
}
objzx_LoginLogEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objzx_LoginLogEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clszx_LoginLogEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clszx_LoginLogEN objzx_LoginLogEN = new clszx_LoginLogEN();
try
{
objzx_LoginLogEN.LoginLogId = TransNullToInt(objRow[conzx_LoginLog.LoginLogId].ToString().Trim()); //LoginLogId
objzx_LoginLogEN.LoginLogNumber = objRow[conzx_LoginLog.LoginLogNumber] == DBNull.Value ? null : objRow[conzx_LoginLog.LoginLogNumber].ToString().Trim(); //LoginLogNumber
objzx_LoginLogEN.LoginIP = objRow[conzx_LoginLog.LoginIP] == DBNull.Value ? null : objRow[conzx_LoginLog.LoginIP].ToString().Trim(); //LoginIP
objzx_LoginLogEN.FailReason = objRow[conzx_LoginLog.FailReason] == DBNull.Value ? null : objRow[conzx_LoginLog.FailReason].ToString().Trim(); //FailReason
objzx_LoginLogEN.LoginResult = objRow[conzx_LoginLog.LoginResult] == DBNull.Value ? null : objRow[conzx_LoginLog.LoginResult].ToString().Trim(); //LoginResult
objzx_LoginLogEN.LoginTime = objRow[conzx_LoginLog.LoginTime] == DBNull.Value ? null : objRow[conzx_LoginLog.LoginTime].ToString().Trim(); //LoginTime
objzx_LoginLogEN.LoginUserId = objRow[conzx_LoginLog.LoginUserId] == DBNull.Value ? null : objRow[conzx_LoginLog.LoginUserId].ToString().Trim(); //LoginUserId
objzx_LoginLogEN.Memo = objRow[conzx_LoginLog.Memo] == DBNull.Value ? null : objRow[conzx_LoginLog.Memo].ToString().Trim(); //备注
objzx_LoginLogEN.OnlineTime = objRow[conzx_LoginLog.OnlineTime] == DBNull.Value ? null : objRow[conzx_LoginLog.OnlineTime].ToString().Trim(); //OnlineTime
objzx_LoginLogEN.OutTime = objRow[conzx_LoginLog.OutTime] == DBNull.Value ? null : objRow[conzx_LoginLog.OutTime].ToString().Trim(); //OutTime
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clszx_LoginLogDA: GetObjByDataRow)", objException.Message));
}
objzx_LoginLogEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objzx_LoginLogEN;
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
objSQL = clszx_LoginLogDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clszx_LoginLogEN._CurrTabName, conzx_LoginLog.LoginLogId, 8, "");
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
objSQL = clszx_LoginLogDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clszx_LoginLogEN._CurrTabName, conzx_LoginLog.LoginLogId, 8, strPrefix);
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
 objSQL = clszx_LoginLogDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select LoginLogId from zx_LoginLog where " + strCondition;
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
 objSQL = clszx_LoginLogDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select LoginLogId from zx_LoginLog where " + strCondition;
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
 objSQL = clszx_LoginLogDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("zx_LoginLog", "LoginLogId = " + ""+ lngLoginLogId+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clszx_LoginLogDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_LoginLogDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("zx_LoginLog", strCondition))
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
objSQL = clszx_LoginLogDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("zx_LoginLog");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clszx_LoginLogEN objzx_LoginLogEN)
 {
 if (objzx_LoginLogEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objzx_LoginLogEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_LoginLogDA.GetSpecSQLObj();
strSQL = "Select * from zx_LoginLog where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "zx_LoginLog");
objRow = objDS.Tables["zx_LoginLog"].NewRow();
 if (objzx_LoginLogEN.LoginLogNumber !=  "")
 {
objRow[conzx_LoginLog.LoginLogNumber] = objzx_LoginLogEN.LoginLogNumber; //LoginLogNumber
 }
 if (objzx_LoginLogEN.LoginIP !=  "")
 {
objRow[conzx_LoginLog.LoginIP] = objzx_LoginLogEN.LoginIP; //LoginIP
 }
 if (objzx_LoginLogEN.FailReason !=  "")
 {
objRow[conzx_LoginLog.FailReason] = objzx_LoginLogEN.FailReason; //FailReason
 }
 if (objzx_LoginLogEN.LoginResult !=  "")
 {
objRow[conzx_LoginLog.LoginResult] = objzx_LoginLogEN.LoginResult; //LoginResult
 }
 if (objzx_LoginLogEN.LoginTime !=  "")
 {
objRow[conzx_LoginLog.LoginTime] = objzx_LoginLogEN.LoginTime; //LoginTime
 }
 if (objzx_LoginLogEN.LoginUserId !=  "")
 {
objRow[conzx_LoginLog.LoginUserId] = objzx_LoginLogEN.LoginUserId; //LoginUserId
 }
 if (objzx_LoginLogEN.Memo !=  "")
 {
objRow[conzx_LoginLog.Memo] = objzx_LoginLogEN.Memo; //备注
 }
 if (objzx_LoginLogEN.OnlineTime !=  "")
 {
objRow[conzx_LoginLog.OnlineTime] = objzx_LoginLogEN.OnlineTime; //OnlineTime
 }
 if (objzx_LoginLogEN.OutTime !=  "")
 {
objRow[conzx_LoginLog.OutTime] = objzx_LoginLogEN.OutTime; //OutTime
 }
objDS.Tables[clszx_LoginLogEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clszx_LoginLogEN._CurrTabName);
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
 /// <param name = "objzx_LoginLogEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clszx_LoginLogEN objzx_LoginLogEN)
{
 if (objzx_LoginLogEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objzx_LoginLogEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objzx_LoginLogEN.LoginLogNumber !=  null)
 {
 arrFieldListForInsert.Add(conzx_LoginLog.LoginLogNumber);
 var strLoginLogNumber = objzx_LoginLogEN.LoginLogNumber.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLoginLogNumber + "'");
 }
 
 if (objzx_LoginLogEN.LoginIP !=  null)
 {
 arrFieldListForInsert.Add(conzx_LoginLog.LoginIP);
 var strLoginIP = objzx_LoginLogEN.LoginIP.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLoginIP + "'");
 }
 
 if (objzx_LoginLogEN.FailReason !=  null)
 {
 arrFieldListForInsert.Add(conzx_LoginLog.FailReason);
 var strFailReason = objzx_LoginLogEN.FailReason.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFailReason + "'");
 }
 
 if (objzx_LoginLogEN.LoginResult !=  null)
 {
 arrFieldListForInsert.Add(conzx_LoginLog.LoginResult);
 var strLoginResult = objzx_LoginLogEN.LoginResult.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLoginResult + "'");
 }
 
 if (objzx_LoginLogEN.LoginTime !=  null)
 {
 arrFieldListForInsert.Add(conzx_LoginLog.LoginTime);
 var strLoginTime = objzx_LoginLogEN.LoginTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLoginTime + "'");
 }
 
 if (objzx_LoginLogEN.LoginUserId !=  null)
 {
 arrFieldListForInsert.Add(conzx_LoginLog.LoginUserId);
 var strLoginUserId = objzx_LoginLogEN.LoginUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLoginUserId + "'");
 }
 
 if (objzx_LoginLogEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conzx_LoginLog.Memo);
 var strMemo = objzx_LoginLogEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objzx_LoginLogEN.OnlineTime !=  null)
 {
 arrFieldListForInsert.Add(conzx_LoginLog.OnlineTime);
 var strOnlineTime = objzx_LoginLogEN.OnlineTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strOnlineTime + "'");
 }
 
 if (objzx_LoginLogEN.OutTime !=  null)
 {
 arrFieldListForInsert.Add(conzx_LoginLog.OutTime);
 var strOutTime = objzx_LoginLogEN.OutTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strOutTime + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into zx_LoginLog");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_LoginLogDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objzx_LoginLogEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clszx_LoginLogEN objzx_LoginLogEN)
{
 if (objzx_LoginLogEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objzx_LoginLogEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objzx_LoginLogEN.LoginLogNumber !=  null)
 {
 arrFieldListForInsert.Add(conzx_LoginLog.LoginLogNumber);
 var strLoginLogNumber = objzx_LoginLogEN.LoginLogNumber.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLoginLogNumber + "'");
 }
 
 if (objzx_LoginLogEN.LoginIP !=  null)
 {
 arrFieldListForInsert.Add(conzx_LoginLog.LoginIP);
 var strLoginIP = objzx_LoginLogEN.LoginIP.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLoginIP + "'");
 }
 
 if (objzx_LoginLogEN.FailReason !=  null)
 {
 arrFieldListForInsert.Add(conzx_LoginLog.FailReason);
 var strFailReason = objzx_LoginLogEN.FailReason.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFailReason + "'");
 }
 
 if (objzx_LoginLogEN.LoginResult !=  null)
 {
 arrFieldListForInsert.Add(conzx_LoginLog.LoginResult);
 var strLoginResult = objzx_LoginLogEN.LoginResult.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLoginResult + "'");
 }
 
 if (objzx_LoginLogEN.LoginTime !=  null)
 {
 arrFieldListForInsert.Add(conzx_LoginLog.LoginTime);
 var strLoginTime = objzx_LoginLogEN.LoginTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLoginTime + "'");
 }
 
 if (objzx_LoginLogEN.LoginUserId !=  null)
 {
 arrFieldListForInsert.Add(conzx_LoginLog.LoginUserId);
 var strLoginUserId = objzx_LoginLogEN.LoginUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLoginUserId + "'");
 }
 
 if (objzx_LoginLogEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conzx_LoginLog.Memo);
 var strMemo = objzx_LoginLogEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objzx_LoginLogEN.OnlineTime !=  null)
 {
 arrFieldListForInsert.Add(conzx_LoginLog.OnlineTime);
 var strOnlineTime = objzx_LoginLogEN.OnlineTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strOnlineTime + "'");
 }
 
 if (objzx_LoginLogEN.OutTime !=  null)
 {
 arrFieldListForInsert.Add(conzx_LoginLog.OutTime);
 var strOutTime = objzx_LoginLogEN.OutTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strOutTime + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into zx_LoginLog");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_LoginLogDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString()).Rows[0][0].ToString();
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objzx_LoginLogEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clszx_LoginLogEN objzx_LoginLogEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objzx_LoginLogEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objzx_LoginLogEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objzx_LoginLogEN.LoginLogNumber !=  null)
 {
 arrFieldListForInsert.Add(conzx_LoginLog.LoginLogNumber);
 var strLoginLogNumber = objzx_LoginLogEN.LoginLogNumber.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLoginLogNumber + "'");
 }
 
 if (objzx_LoginLogEN.LoginIP !=  null)
 {
 arrFieldListForInsert.Add(conzx_LoginLog.LoginIP);
 var strLoginIP = objzx_LoginLogEN.LoginIP.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLoginIP + "'");
 }
 
 if (objzx_LoginLogEN.FailReason !=  null)
 {
 arrFieldListForInsert.Add(conzx_LoginLog.FailReason);
 var strFailReason = objzx_LoginLogEN.FailReason.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFailReason + "'");
 }
 
 if (objzx_LoginLogEN.LoginResult !=  null)
 {
 arrFieldListForInsert.Add(conzx_LoginLog.LoginResult);
 var strLoginResult = objzx_LoginLogEN.LoginResult.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLoginResult + "'");
 }
 
 if (objzx_LoginLogEN.LoginTime !=  null)
 {
 arrFieldListForInsert.Add(conzx_LoginLog.LoginTime);
 var strLoginTime = objzx_LoginLogEN.LoginTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLoginTime + "'");
 }
 
 if (objzx_LoginLogEN.LoginUserId !=  null)
 {
 arrFieldListForInsert.Add(conzx_LoginLog.LoginUserId);
 var strLoginUserId = objzx_LoginLogEN.LoginUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLoginUserId + "'");
 }
 
 if (objzx_LoginLogEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conzx_LoginLog.Memo);
 var strMemo = objzx_LoginLogEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objzx_LoginLogEN.OnlineTime !=  null)
 {
 arrFieldListForInsert.Add(conzx_LoginLog.OnlineTime);
 var strOnlineTime = objzx_LoginLogEN.OnlineTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strOnlineTime + "'");
 }
 
 if (objzx_LoginLogEN.OutTime !=  null)
 {
 arrFieldListForInsert.Add(conzx_LoginLog.OutTime);
 var strOutTime = objzx_LoginLogEN.OutTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strOutTime + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into zx_LoginLog");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_LoginLogDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString(), objSqlConnection, objSqlTransaction).Rows[0][0].ToString();
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objzx_LoginLogEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clszx_LoginLogEN objzx_LoginLogEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objzx_LoginLogEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objzx_LoginLogEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objzx_LoginLogEN.LoginLogNumber !=  null)
 {
 arrFieldListForInsert.Add(conzx_LoginLog.LoginLogNumber);
 var strLoginLogNumber = objzx_LoginLogEN.LoginLogNumber.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLoginLogNumber + "'");
 }
 
 if (objzx_LoginLogEN.LoginIP !=  null)
 {
 arrFieldListForInsert.Add(conzx_LoginLog.LoginIP);
 var strLoginIP = objzx_LoginLogEN.LoginIP.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLoginIP + "'");
 }
 
 if (objzx_LoginLogEN.FailReason !=  null)
 {
 arrFieldListForInsert.Add(conzx_LoginLog.FailReason);
 var strFailReason = objzx_LoginLogEN.FailReason.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFailReason + "'");
 }
 
 if (objzx_LoginLogEN.LoginResult !=  null)
 {
 arrFieldListForInsert.Add(conzx_LoginLog.LoginResult);
 var strLoginResult = objzx_LoginLogEN.LoginResult.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLoginResult + "'");
 }
 
 if (objzx_LoginLogEN.LoginTime !=  null)
 {
 arrFieldListForInsert.Add(conzx_LoginLog.LoginTime);
 var strLoginTime = objzx_LoginLogEN.LoginTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLoginTime + "'");
 }
 
 if (objzx_LoginLogEN.LoginUserId !=  null)
 {
 arrFieldListForInsert.Add(conzx_LoginLog.LoginUserId);
 var strLoginUserId = objzx_LoginLogEN.LoginUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLoginUserId + "'");
 }
 
 if (objzx_LoginLogEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conzx_LoginLog.Memo);
 var strMemo = objzx_LoginLogEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objzx_LoginLogEN.OnlineTime !=  null)
 {
 arrFieldListForInsert.Add(conzx_LoginLog.OnlineTime);
 var strOnlineTime = objzx_LoginLogEN.OnlineTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strOnlineTime + "'");
 }
 
 if (objzx_LoginLogEN.OutTime !=  null)
 {
 arrFieldListForInsert.Add(conzx_LoginLog.OutTime);
 var strOutTime = objzx_LoginLogEN.OutTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strOutTime + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into zx_LoginLog");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_LoginLogDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool Addnewzx_LoginLogs(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_LoginLogDA.GetSpecSQLObj();
strSQL = "Select * from zx_LoginLog where LoginLogId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "zx_LoginLog");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
long lngLoginLogId = TransNullToInt(oRow[conzx_LoginLog.LoginLogId].ToString().Trim());
if (IsExist(lngLoginLogId))
{
 string strResult = "关键字变量值为:" + string.Format("LoginLogId = {0}", lngLoginLogId) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clszx_LoginLogEN._CurrTabName ].NewRow();
objRow[conzx_LoginLog.LoginLogNumber] = oRow[conzx_LoginLog.LoginLogNumber].ToString().Trim(); //LoginLogNumber
objRow[conzx_LoginLog.LoginIP] = oRow[conzx_LoginLog.LoginIP].ToString().Trim(); //LoginIP
objRow[conzx_LoginLog.FailReason] = oRow[conzx_LoginLog.FailReason].ToString().Trim(); //FailReason
objRow[conzx_LoginLog.LoginResult] = oRow[conzx_LoginLog.LoginResult].ToString().Trim(); //LoginResult
objRow[conzx_LoginLog.LoginTime] = oRow[conzx_LoginLog.LoginTime].ToString().Trim(); //LoginTime
objRow[conzx_LoginLog.LoginUserId] = oRow[conzx_LoginLog.LoginUserId].ToString().Trim(); //LoginUserId
objRow[conzx_LoginLog.Memo] = oRow[conzx_LoginLog.Memo].ToString().Trim(); //备注
objRow[conzx_LoginLog.OnlineTime] = oRow[conzx_LoginLog.OnlineTime].ToString().Trim(); //OnlineTime
objRow[conzx_LoginLog.OutTime] = oRow[conzx_LoginLog.OutTime].ToString().Trim(); //OutTime
 objDS.Tables[clszx_LoginLogEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clszx_LoginLogEN._CurrTabName);
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
 /// <param name = "objzx_LoginLogEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clszx_LoginLogEN objzx_LoginLogEN)
{
 if (objzx_LoginLogEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objzx_LoginLogEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_LoginLogDA.GetSpecSQLObj();
strSQL = "Select * from zx_LoginLog where LoginLogId = " + ""+ objzx_LoginLogEN.LoginLogId+"";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clszx_LoginLogEN._CurrTabName);
if (objDS.Tables[clszx_LoginLogEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:LoginLogId = " + ""+ objzx_LoginLogEN.LoginLogId+"");
return false;
}
objRow = objDS.Tables[clszx_LoginLogEN._CurrTabName].Rows[0];
 if (objzx_LoginLogEN.IsUpdated(conzx_LoginLog.LoginLogNumber))
 {
objRow[conzx_LoginLog.LoginLogNumber] = objzx_LoginLogEN.LoginLogNumber; //LoginLogNumber
 }
 if (objzx_LoginLogEN.IsUpdated(conzx_LoginLog.LoginIP))
 {
objRow[conzx_LoginLog.LoginIP] = objzx_LoginLogEN.LoginIP; //LoginIP
 }
 if (objzx_LoginLogEN.IsUpdated(conzx_LoginLog.FailReason))
 {
objRow[conzx_LoginLog.FailReason] = objzx_LoginLogEN.FailReason; //FailReason
 }
 if (objzx_LoginLogEN.IsUpdated(conzx_LoginLog.LoginResult))
 {
objRow[conzx_LoginLog.LoginResult] = objzx_LoginLogEN.LoginResult; //LoginResult
 }
 if (objzx_LoginLogEN.IsUpdated(conzx_LoginLog.LoginTime))
 {
objRow[conzx_LoginLog.LoginTime] = objzx_LoginLogEN.LoginTime; //LoginTime
 }
 if (objzx_LoginLogEN.IsUpdated(conzx_LoginLog.LoginUserId))
 {
objRow[conzx_LoginLog.LoginUserId] = objzx_LoginLogEN.LoginUserId; //LoginUserId
 }
 if (objzx_LoginLogEN.IsUpdated(conzx_LoginLog.Memo))
 {
objRow[conzx_LoginLog.Memo] = objzx_LoginLogEN.Memo; //备注
 }
 if (objzx_LoginLogEN.IsUpdated(conzx_LoginLog.OnlineTime))
 {
objRow[conzx_LoginLog.OnlineTime] = objzx_LoginLogEN.OnlineTime; //OnlineTime
 }
 if (objzx_LoginLogEN.IsUpdated(conzx_LoginLog.OutTime))
 {
objRow[conzx_LoginLog.OutTime] = objzx_LoginLogEN.OutTime; //OutTime
 }
try
{
objDA.Update(objDS, clszx_LoginLogEN._CurrTabName);
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
 /// <param name = "objzx_LoginLogEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clszx_LoginLogEN objzx_LoginLogEN)
{
 if (objzx_LoginLogEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objzx_LoginLogEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_LoginLogDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update zx_LoginLog Set ");
 
 if (objzx_LoginLogEN.IsUpdated(conzx_LoginLog.LoginLogNumber))
 {
 if (objzx_LoginLogEN.LoginLogNumber !=  null)
 {
 var strLoginLogNumber = objzx_LoginLogEN.LoginLogNumber.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strLoginLogNumber, conzx_LoginLog.LoginLogNumber); //LoginLogNumber
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_LoginLog.LoginLogNumber); //LoginLogNumber
 }
 }
 
 if (objzx_LoginLogEN.IsUpdated(conzx_LoginLog.LoginIP))
 {
 if (objzx_LoginLogEN.LoginIP !=  null)
 {
 var strLoginIP = objzx_LoginLogEN.LoginIP.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strLoginIP, conzx_LoginLog.LoginIP); //LoginIP
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_LoginLog.LoginIP); //LoginIP
 }
 }
 
 if (objzx_LoginLogEN.IsUpdated(conzx_LoginLog.FailReason))
 {
 if (objzx_LoginLogEN.FailReason !=  null)
 {
 var strFailReason = objzx_LoginLogEN.FailReason.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFailReason, conzx_LoginLog.FailReason); //FailReason
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_LoginLog.FailReason); //FailReason
 }
 }
 
 if (objzx_LoginLogEN.IsUpdated(conzx_LoginLog.LoginResult))
 {
 if (objzx_LoginLogEN.LoginResult !=  null)
 {
 var strLoginResult = objzx_LoginLogEN.LoginResult.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strLoginResult, conzx_LoginLog.LoginResult); //LoginResult
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_LoginLog.LoginResult); //LoginResult
 }
 }
 
 if (objzx_LoginLogEN.IsUpdated(conzx_LoginLog.LoginTime))
 {
 if (objzx_LoginLogEN.LoginTime !=  null)
 {
 var strLoginTime = objzx_LoginLogEN.LoginTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strLoginTime, conzx_LoginLog.LoginTime); //LoginTime
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_LoginLog.LoginTime); //LoginTime
 }
 }
 
 if (objzx_LoginLogEN.IsUpdated(conzx_LoginLog.LoginUserId))
 {
 if (objzx_LoginLogEN.LoginUserId !=  null)
 {
 var strLoginUserId = objzx_LoginLogEN.LoginUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strLoginUserId, conzx_LoginLog.LoginUserId); //LoginUserId
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_LoginLog.LoginUserId); //LoginUserId
 }
 }
 
 if (objzx_LoginLogEN.IsUpdated(conzx_LoginLog.Memo))
 {
 if (objzx_LoginLogEN.Memo !=  null)
 {
 var strMemo = objzx_LoginLogEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conzx_LoginLog.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_LoginLog.Memo); //备注
 }
 }
 
 if (objzx_LoginLogEN.IsUpdated(conzx_LoginLog.OnlineTime))
 {
 if (objzx_LoginLogEN.OnlineTime !=  null)
 {
 var strOnlineTime = objzx_LoginLogEN.OnlineTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strOnlineTime, conzx_LoginLog.OnlineTime); //OnlineTime
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_LoginLog.OnlineTime); //OnlineTime
 }
 }
 
 if (objzx_LoginLogEN.IsUpdated(conzx_LoginLog.OutTime))
 {
 if (objzx_LoginLogEN.OutTime !=  null)
 {
 var strOutTime = objzx_LoginLogEN.OutTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strOutTime, conzx_LoginLog.OutTime); //OutTime
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_LoginLog.OutTime); //OutTime
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where LoginLogId = {0}", objzx_LoginLogEN.LoginLogId); 
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
 /// <param name = "objzx_LoginLogEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clszx_LoginLogEN objzx_LoginLogEN, string strCondition)
{
 if (objzx_LoginLogEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objzx_LoginLogEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_LoginLogDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update zx_LoginLog Set ");
 
 if (objzx_LoginLogEN.IsUpdated(conzx_LoginLog.LoginLogNumber))
 {
 if (objzx_LoginLogEN.LoginLogNumber !=  null)
 {
 var strLoginLogNumber = objzx_LoginLogEN.LoginLogNumber.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" LoginLogNumber = '{0}',", strLoginLogNumber); //LoginLogNumber
 }
 else
 {
 sbSQL.Append(" LoginLogNumber = null,"); //LoginLogNumber
 }
 }
 
 if (objzx_LoginLogEN.IsUpdated(conzx_LoginLog.LoginIP))
 {
 if (objzx_LoginLogEN.LoginIP !=  null)
 {
 var strLoginIP = objzx_LoginLogEN.LoginIP.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" LoginIP = '{0}',", strLoginIP); //LoginIP
 }
 else
 {
 sbSQL.Append(" LoginIP = null,"); //LoginIP
 }
 }
 
 if (objzx_LoginLogEN.IsUpdated(conzx_LoginLog.FailReason))
 {
 if (objzx_LoginLogEN.FailReason !=  null)
 {
 var strFailReason = objzx_LoginLogEN.FailReason.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FailReason = '{0}',", strFailReason); //FailReason
 }
 else
 {
 sbSQL.Append(" FailReason = null,"); //FailReason
 }
 }
 
 if (objzx_LoginLogEN.IsUpdated(conzx_LoginLog.LoginResult))
 {
 if (objzx_LoginLogEN.LoginResult !=  null)
 {
 var strLoginResult = objzx_LoginLogEN.LoginResult.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" LoginResult = '{0}',", strLoginResult); //LoginResult
 }
 else
 {
 sbSQL.Append(" LoginResult = null,"); //LoginResult
 }
 }
 
 if (objzx_LoginLogEN.IsUpdated(conzx_LoginLog.LoginTime))
 {
 if (objzx_LoginLogEN.LoginTime !=  null)
 {
 var strLoginTime = objzx_LoginLogEN.LoginTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" LoginTime = '{0}',", strLoginTime); //LoginTime
 }
 else
 {
 sbSQL.Append(" LoginTime = null,"); //LoginTime
 }
 }
 
 if (objzx_LoginLogEN.IsUpdated(conzx_LoginLog.LoginUserId))
 {
 if (objzx_LoginLogEN.LoginUserId !=  null)
 {
 var strLoginUserId = objzx_LoginLogEN.LoginUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" LoginUserId = '{0}',", strLoginUserId); //LoginUserId
 }
 else
 {
 sbSQL.Append(" LoginUserId = null,"); //LoginUserId
 }
 }
 
 if (objzx_LoginLogEN.IsUpdated(conzx_LoginLog.Memo))
 {
 if (objzx_LoginLogEN.Memo !=  null)
 {
 var strMemo = objzx_LoginLogEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Memo = '{0}',", strMemo); //备注
 }
 else
 {
 sbSQL.Append(" Memo = null,"); //备注
 }
 }
 
 if (objzx_LoginLogEN.IsUpdated(conzx_LoginLog.OnlineTime))
 {
 if (objzx_LoginLogEN.OnlineTime !=  null)
 {
 var strOnlineTime = objzx_LoginLogEN.OnlineTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" OnlineTime = '{0}',", strOnlineTime); //OnlineTime
 }
 else
 {
 sbSQL.Append(" OnlineTime = null,"); //OnlineTime
 }
 }
 
 if (objzx_LoginLogEN.IsUpdated(conzx_LoginLog.OutTime))
 {
 if (objzx_LoginLogEN.OutTime !=  null)
 {
 var strOutTime = objzx_LoginLogEN.OutTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" OutTime = '{0}',", strOutTime); //OutTime
 }
 else
 {
 sbSQL.Append(" OutTime = null,"); //OutTime
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
 /// <param name = "objzx_LoginLogEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clszx_LoginLogEN objzx_LoginLogEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objzx_LoginLogEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objzx_LoginLogEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_LoginLogDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update zx_LoginLog Set ");
 
 if (objzx_LoginLogEN.IsUpdated(conzx_LoginLog.LoginLogNumber))
 {
 if (objzx_LoginLogEN.LoginLogNumber !=  null)
 {
 var strLoginLogNumber = objzx_LoginLogEN.LoginLogNumber.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" LoginLogNumber = '{0}',", strLoginLogNumber); //LoginLogNumber
 }
 else
 {
 sbSQL.Append(" LoginLogNumber = null,"); //LoginLogNumber
 }
 }
 
 if (objzx_LoginLogEN.IsUpdated(conzx_LoginLog.LoginIP))
 {
 if (objzx_LoginLogEN.LoginIP !=  null)
 {
 var strLoginIP = objzx_LoginLogEN.LoginIP.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" LoginIP = '{0}',", strLoginIP); //LoginIP
 }
 else
 {
 sbSQL.Append(" LoginIP = null,"); //LoginIP
 }
 }
 
 if (objzx_LoginLogEN.IsUpdated(conzx_LoginLog.FailReason))
 {
 if (objzx_LoginLogEN.FailReason !=  null)
 {
 var strFailReason = objzx_LoginLogEN.FailReason.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FailReason = '{0}',", strFailReason); //FailReason
 }
 else
 {
 sbSQL.Append(" FailReason = null,"); //FailReason
 }
 }
 
 if (objzx_LoginLogEN.IsUpdated(conzx_LoginLog.LoginResult))
 {
 if (objzx_LoginLogEN.LoginResult !=  null)
 {
 var strLoginResult = objzx_LoginLogEN.LoginResult.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" LoginResult = '{0}',", strLoginResult); //LoginResult
 }
 else
 {
 sbSQL.Append(" LoginResult = null,"); //LoginResult
 }
 }
 
 if (objzx_LoginLogEN.IsUpdated(conzx_LoginLog.LoginTime))
 {
 if (objzx_LoginLogEN.LoginTime !=  null)
 {
 var strLoginTime = objzx_LoginLogEN.LoginTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" LoginTime = '{0}',", strLoginTime); //LoginTime
 }
 else
 {
 sbSQL.Append(" LoginTime = null,"); //LoginTime
 }
 }
 
 if (objzx_LoginLogEN.IsUpdated(conzx_LoginLog.LoginUserId))
 {
 if (objzx_LoginLogEN.LoginUserId !=  null)
 {
 var strLoginUserId = objzx_LoginLogEN.LoginUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" LoginUserId = '{0}',", strLoginUserId); //LoginUserId
 }
 else
 {
 sbSQL.Append(" LoginUserId = null,"); //LoginUserId
 }
 }
 
 if (objzx_LoginLogEN.IsUpdated(conzx_LoginLog.Memo))
 {
 if (objzx_LoginLogEN.Memo !=  null)
 {
 var strMemo = objzx_LoginLogEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Memo = '{0}',", strMemo); //备注
 }
 else
 {
 sbSQL.Append(" Memo = null,"); //备注
 }
 }
 
 if (objzx_LoginLogEN.IsUpdated(conzx_LoginLog.OnlineTime))
 {
 if (objzx_LoginLogEN.OnlineTime !=  null)
 {
 var strOnlineTime = objzx_LoginLogEN.OnlineTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" OnlineTime = '{0}',", strOnlineTime); //OnlineTime
 }
 else
 {
 sbSQL.Append(" OnlineTime = null,"); //OnlineTime
 }
 }
 
 if (objzx_LoginLogEN.IsUpdated(conzx_LoginLog.OutTime))
 {
 if (objzx_LoginLogEN.OutTime !=  null)
 {
 var strOutTime = objzx_LoginLogEN.OutTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" OutTime = '{0}',", strOutTime); //OutTime
 }
 else
 {
 sbSQL.Append(" OutTime = null,"); //OutTime
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
 /// <param name = "objzx_LoginLogEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clszx_LoginLogEN objzx_LoginLogEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objzx_LoginLogEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objzx_LoginLogEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_LoginLogDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update zx_LoginLog Set ");
 
 if (objzx_LoginLogEN.IsUpdated(conzx_LoginLog.LoginLogNumber))
 {
 if (objzx_LoginLogEN.LoginLogNumber !=  null)
 {
 var strLoginLogNumber = objzx_LoginLogEN.LoginLogNumber.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strLoginLogNumber, conzx_LoginLog.LoginLogNumber); //LoginLogNumber
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_LoginLog.LoginLogNumber); //LoginLogNumber
 }
 }
 
 if (objzx_LoginLogEN.IsUpdated(conzx_LoginLog.LoginIP))
 {
 if (objzx_LoginLogEN.LoginIP !=  null)
 {
 var strLoginIP = objzx_LoginLogEN.LoginIP.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strLoginIP, conzx_LoginLog.LoginIP); //LoginIP
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_LoginLog.LoginIP); //LoginIP
 }
 }
 
 if (objzx_LoginLogEN.IsUpdated(conzx_LoginLog.FailReason))
 {
 if (objzx_LoginLogEN.FailReason !=  null)
 {
 var strFailReason = objzx_LoginLogEN.FailReason.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFailReason, conzx_LoginLog.FailReason); //FailReason
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_LoginLog.FailReason); //FailReason
 }
 }
 
 if (objzx_LoginLogEN.IsUpdated(conzx_LoginLog.LoginResult))
 {
 if (objzx_LoginLogEN.LoginResult !=  null)
 {
 var strLoginResult = objzx_LoginLogEN.LoginResult.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strLoginResult, conzx_LoginLog.LoginResult); //LoginResult
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_LoginLog.LoginResult); //LoginResult
 }
 }
 
 if (objzx_LoginLogEN.IsUpdated(conzx_LoginLog.LoginTime))
 {
 if (objzx_LoginLogEN.LoginTime !=  null)
 {
 var strLoginTime = objzx_LoginLogEN.LoginTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strLoginTime, conzx_LoginLog.LoginTime); //LoginTime
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_LoginLog.LoginTime); //LoginTime
 }
 }
 
 if (objzx_LoginLogEN.IsUpdated(conzx_LoginLog.LoginUserId))
 {
 if (objzx_LoginLogEN.LoginUserId !=  null)
 {
 var strLoginUserId = objzx_LoginLogEN.LoginUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strLoginUserId, conzx_LoginLog.LoginUserId); //LoginUserId
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_LoginLog.LoginUserId); //LoginUserId
 }
 }
 
 if (objzx_LoginLogEN.IsUpdated(conzx_LoginLog.Memo))
 {
 if (objzx_LoginLogEN.Memo !=  null)
 {
 var strMemo = objzx_LoginLogEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conzx_LoginLog.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_LoginLog.Memo); //备注
 }
 }
 
 if (objzx_LoginLogEN.IsUpdated(conzx_LoginLog.OnlineTime))
 {
 if (objzx_LoginLogEN.OnlineTime !=  null)
 {
 var strOnlineTime = objzx_LoginLogEN.OnlineTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strOnlineTime, conzx_LoginLog.OnlineTime); //OnlineTime
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_LoginLog.OnlineTime); //OnlineTime
 }
 }
 
 if (objzx_LoginLogEN.IsUpdated(conzx_LoginLog.OutTime))
 {
 if (objzx_LoginLogEN.OutTime !=  null)
 {
 var strOutTime = objzx_LoginLogEN.OutTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strOutTime, conzx_LoginLog.OutTime); //OutTime
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_LoginLog.OutTime); //OutTime
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where LoginLogId = {0}", objzx_LoginLogEN.LoginLogId); 
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
 objSQL = clszx_LoginLogDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 lngLoginLogId,
};
 objSQL.ExecSP("zx_LoginLog_Delete", values);
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
 objSQL = clszx_LoginLogDA.GetSpecSQLObj();
//删除zx_LoginLog本表中与当前对象有关的记录
strSQL = strSQL + "Delete from zx_LoginLog where LoginLogId = " + ""+ lngLoginLogId+"";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int Delzx_LoginLog(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_LoginLogDA.GetSpecSQLObj();
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
//删除zx_LoginLog本表中与当前对象有关的记录
strSQL = strSQL + "Delete from zx_LoginLog where LoginLogId in (" + strKeyList + ")";
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
 objSQL = clszx_LoginLogDA.GetSpecSQLObj();
//删除zx_LoginLog本表中与当前对象有关的记录
strSQL = strSQL + "Delete from zx_LoginLog where LoginLogId = " + ""+ lngLoginLogId+"";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int Delzx_LoginLog(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clszx_LoginLogDA: Delzx_LoginLog)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_LoginLogDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from zx_LoginLog where " + strCondition ;
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
public bool Delzx_LoginLogWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clszx_LoginLogDA: Delzx_LoginLogWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_LoginLogDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from zx_LoginLog where " + strCondition ;
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
 /// <param name = "objzx_LoginLogENS">源对象</param>
 /// <param name = "objzx_LoginLogENT">目标对象</param>
public void CopyTo(clszx_LoginLogEN objzx_LoginLogENS, clszx_LoginLogEN objzx_LoginLogENT)
{
objzx_LoginLogENT.LoginLogId = objzx_LoginLogENS.LoginLogId; //LoginLogId
objzx_LoginLogENT.LoginLogNumber = objzx_LoginLogENS.LoginLogNumber; //LoginLogNumber
objzx_LoginLogENT.LoginIP = objzx_LoginLogENS.LoginIP; //LoginIP
objzx_LoginLogENT.FailReason = objzx_LoginLogENS.FailReason; //FailReason
objzx_LoginLogENT.LoginResult = objzx_LoginLogENS.LoginResult; //LoginResult
objzx_LoginLogENT.LoginTime = objzx_LoginLogENS.LoginTime; //LoginTime
objzx_LoginLogENT.LoginUserId = objzx_LoginLogENS.LoginUserId; //LoginUserId
objzx_LoginLogENT.Memo = objzx_LoginLogENS.Memo; //备注
objzx_LoginLogENT.OnlineTime = objzx_LoginLogENS.OnlineTime; //OnlineTime
objzx_LoginLogENT.OutTime = objzx_LoginLogENS.OutTime; //OutTime
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clszx_LoginLogEN objzx_LoginLogEN)
{
//检查字段不能为空(NULL)
//检查字段长度
clsCheckSql.CheckFieldLen(objzx_LoginLogEN.LoginLogNumber, 500, conzx_LoginLog.LoginLogNumber);
clsCheckSql.CheckFieldLen(objzx_LoginLogEN.LoginIP, 200, conzx_LoginLog.LoginIP);
clsCheckSql.CheckFieldLen(objzx_LoginLogEN.FailReason, 500, conzx_LoginLog.FailReason);
clsCheckSql.CheckFieldLen(objzx_LoginLogEN.LoginResult, 500, conzx_LoginLog.LoginResult);
clsCheckSql.CheckFieldLen(objzx_LoginLogEN.LoginTime, 20, conzx_LoginLog.LoginTime);
clsCheckSql.CheckFieldLen(objzx_LoginLogEN.LoginUserId, 200, conzx_LoginLog.LoginUserId);
clsCheckSql.CheckFieldLen(objzx_LoginLogEN.Memo, 1000, conzx_LoginLog.Memo);
clsCheckSql.CheckFieldLen(objzx_LoginLogEN.OnlineTime, 200, conzx_LoginLog.OnlineTime);
clsCheckSql.CheckFieldLen(objzx_LoginLogEN.OutTime, 20, conzx_LoginLog.OutTime);
//检查字段外键固定长度
 objzx_LoginLogEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clszx_LoginLogEN objzx_LoginLogEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objzx_LoginLogEN.LoginLogNumber, 500, conzx_LoginLog.LoginLogNumber);
clsCheckSql.CheckFieldLen(objzx_LoginLogEN.LoginIP, 200, conzx_LoginLog.LoginIP);
clsCheckSql.CheckFieldLen(objzx_LoginLogEN.FailReason, 500, conzx_LoginLog.FailReason);
clsCheckSql.CheckFieldLen(objzx_LoginLogEN.LoginResult, 500, conzx_LoginLog.LoginResult);
clsCheckSql.CheckFieldLen(objzx_LoginLogEN.LoginTime, 20, conzx_LoginLog.LoginTime);
clsCheckSql.CheckFieldLen(objzx_LoginLogEN.LoginUserId, 200, conzx_LoginLog.LoginUserId);
clsCheckSql.CheckFieldLen(objzx_LoginLogEN.Memo, 1000, conzx_LoginLog.Memo);
clsCheckSql.CheckFieldLen(objzx_LoginLogEN.OnlineTime, 200, conzx_LoginLog.OnlineTime);
clsCheckSql.CheckFieldLen(objzx_LoginLogEN.OutTime, 20, conzx_LoginLog.OutTime);
//检查外键字段长度
 objzx_LoginLogEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clszx_LoginLogEN objzx_LoginLogEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objzx_LoginLogEN.LoginLogNumber, 500, conzx_LoginLog.LoginLogNumber);
clsCheckSql.CheckFieldLen(objzx_LoginLogEN.LoginIP, 200, conzx_LoginLog.LoginIP);
clsCheckSql.CheckFieldLen(objzx_LoginLogEN.FailReason, 500, conzx_LoginLog.FailReason);
clsCheckSql.CheckFieldLen(objzx_LoginLogEN.LoginResult, 500, conzx_LoginLog.LoginResult);
clsCheckSql.CheckFieldLen(objzx_LoginLogEN.LoginTime, 20, conzx_LoginLog.LoginTime);
clsCheckSql.CheckFieldLen(objzx_LoginLogEN.LoginUserId, 200, conzx_LoginLog.LoginUserId);
clsCheckSql.CheckFieldLen(objzx_LoginLogEN.Memo, 1000, conzx_LoginLog.Memo);
clsCheckSql.CheckFieldLen(objzx_LoginLogEN.OnlineTime, 200, conzx_LoginLog.OnlineTime);
clsCheckSql.CheckFieldLen(objzx_LoginLogEN.OutTime, 20, conzx_LoginLog.OutTime);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objzx_LoginLogEN.LoginLogNumber, conzx_LoginLog.LoginLogNumber);
clsCheckSql.CheckSqlInjection4Field(objzx_LoginLogEN.LoginIP, conzx_LoginLog.LoginIP);
clsCheckSql.CheckSqlInjection4Field(objzx_LoginLogEN.FailReason, conzx_LoginLog.FailReason);
clsCheckSql.CheckSqlInjection4Field(objzx_LoginLogEN.LoginResult, conzx_LoginLog.LoginResult);
clsCheckSql.CheckSqlInjection4Field(objzx_LoginLogEN.LoginTime, conzx_LoginLog.LoginTime);
clsCheckSql.CheckSqlInjection4Field(objzx_LoginLogEN.LoginUserId, conzx_LoginLog.LoginUserId);
clsCheckSql.CheckSqlInjection4Field(objzx_LoginLogEN.Memo, conzx_LoginLog.Memo);
clsCheckSql.CheckSqlInjection4Field(objzx_LoginLogEN.OnlineTime, conzx_LoginLog.OnlineTime);
clsCheckSql.CheckSqlInjection4Field(objzx_LoginLogEN.OutTime, conzx_LoginLog.OutTime);
//检查外键字段长度
 objzx_LoginLogEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--zx_LoginLog(中学登录日志),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objzx_LoginLogEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clszx_LoginLogEN objzx_LoginLogEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and LoginLogId = '{0}'", objzx_LoginLogEN.LoginLogId);
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
 objSQL = clszx_LoginLogDA.GetSpecSQLObj();
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
 objSQL = clszx_LoginLogDA.GetSpecSQLObj();
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
 objSQL = clszx_LoginLogDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clszx_LoginLogEN._CurrTabName);
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
 objSQL = clszx_LoginLogDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clszx_LoginLogEN._CurrTabName, strCondition);
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
 objSQL = clszx_LoginLogDA.GetSpecSQLObj();
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
 objSQL = clszx_LoginLogDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}