
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvPubClassCaseFreeSenateDA
 表名:vPubClassCaseFreeSenate(01120412)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:48:41
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:课例观摩(PubicClassSenate)
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
 /// v公开课案例自由评议(vPubClassCaseFreeSenate)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvPubClassCaseFreeSenateDA : clsCommBase4DA
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
 return clsvPubClassCaseFreeSenateEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvPubClassCaseFreeSenateEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvPubClassCaseFreeSenateEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvPubClassCaseFreeSenateEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvPubClassCaseFreeSenateEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvPubClassCaseFreeSenateDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPubClassCaseFreeSenateDA.GetSpecSQLObj();
strSQL = "Select * from vPubClassCaseFreeSenate where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vPubClassCaseFreeSenate(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvPubClassCaseFreeSenateDA: GetDataTable_vPubClassCaseFreeSenate)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPubClassCaseFreeSenateDA.GetSpecSQLObj();
strSQL = "Select * from vPubClassCaseFreeSenate where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvPubClassCaseFreeSenateDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPubClassCaseFreeSenateDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvPubClassCaseFreeSenateDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPubClassCaseFreeSenateDA.GetSpecSQLObj();
strSQL = "Select * from vPubClassCaseFreeSenate where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvPubClassCaseFreeSenateDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPubClassCaseFreeSenateDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvPubClassCaseFreeSenateDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPubClassCaseFreeSenateDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vPubClassCaseFreeSenate where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vPubClassCaseFreeSenate where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvPubClassCaseFreeSenateDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPubClassCaseFreeSenateDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vPubClassCaseFreeSenate where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvPubClassCaseFreeSenateDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPubClassCaseFreeSenateDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vPubClassCaseFreeSenate.* from vPubClassCaseFreeSenate Left Join {1} on {2} where {3} and vPubClassCaseFreeSenate.IdPubClassCaseFreeSenate not in (Select top {5} vPubClassCaseFreeSenate.IdPubClassCaseFreeSenate from vPubClassCaseFreeSenate Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vPubClassCaseFreeSenate where {1} and IdPubClassCaseFreeSenate not in (Select top {2} IdPubClassCaseFreeSenate from vPubClassCaseFreeSenate where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vPubClassCaseFreeSenate where {1} and IdPubClassCaseFreeSenate not in (Select top {3} IdPubClassCaseFreeSenate from vPubClassCaseFreeSenate where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvPubClassCaseFreeSenateDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPubClassCaseFreeSenateDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vPubClassCaseFreeSenate.* from vPubClassCaseFreeSenate Left Join {1} on {2} where {3} and vPubClassCaseFreeSenate.IdPubClassCaseFreeSenate not in (Select top {5} vPubClassCaseFreeSenate.IdPubClassCaseFreeSenate from vPubClassCaseFreeSenate Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vPubClassCaseFreeSenate where {1} and IdPubClassCaseFreeSenate not in (Select top {2} IdPubClassCaseFreeSenate from vPubClassCaseFreeSenate where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vPubClassCaseFreeSenate where {1} and IdPubClassCaseFreeSenate not in (Select top {3} IdPubClassCaseFreeSenate from vPubClassCaseFreeSenate where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvPubClassCaseFreeSenateEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvPubClassCaseFreeSenateDA:GetObjLst)", objException.Message));
}
List<clsvPubClassCaseFreeSenateEN> arrObjLst = new List<clsvPubClassCaseFreeSenateEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPubClassCaseFreeSenateDA.GetSpecSQLObj();
strSQL = "Select * from vPubClassCaseFreeSenate where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPubClassCaseFreeSenateEN objvPubClassCaseFreeSenateEN = new clsvPubClassCaseFreeSenateEN();
try
{
objvPubClassCaseFreeSenateEN.IdPubClassCaseFreeSenate = TransNullToInt(objRow[convPubClassCaseFreeSenate.IdPubClassCaseFreeSenate].ToString().Trim()); //公开课案例自由评议流水号
objvPubClassCaseFreeSenateEN.IdPubClassCase = objRow[convPubClassCaseFreeSenate.IdPubClassCase].ToString().Trim(); //案例流水号
objvPubClassCaseFreeSenateEN.PubClassCaseID = objRow[convPubClassCaseFreeSenate.PubClassCaseID].ToString().Trim(); //案例ID
objvPubClassCaseFreeSenateEN.PubClassCaseName = objRow[convPubClassCaseFreeSenate.PubClassCaseName].ToString().Trim(); //案例课题名称
objvPubClassCaseFreeSenateEN.PubClassCaseExecutor = objRow[convPubClassCaseFreeSenate.PubClassCaseExecutor] == DBNull.Value ? null : objRow[convPubClassCaseFreeSenate.PubClassCaseExecutor].ToString().Trim(); //案例执教者
objvPubClassCaseFreeSenateEN.PubClassCaseTheme = objRow[convPubClassCaseFreeSenate.PubClassCaseTheme] == DBNull.Value ? null : objRow[convPubClassCaseFreeSenate.PubClassCaseTheme].ToString().Trim(); //案例主题词
objvPubClassCaseFreeSenateEN.UserId = objRow[convPubClassCaseFreeSenate.UserId].ToString().Trim(); //用户ID
objvPubClassCaseFreeSenateEN.UserName = objRow[convPubClassCaseFreeSenate.UserName] == DBNull.Value ? null : objRow[convPubClassCaseFreeSenate.UserName].ToString().Trim(); //用户名
objvPubClassCaseFreeSenateEN.AppraiseTheme = objRow[convPubClassCaseFreeSenate.AppraiseTheme] == DBNull.Value ? null : objRow[convPubClassCaseFreeSenate.AppraiseTheme].ToString().Trim(); //评议主题
objvPubClassCaseFreeSenateEN.PubClassCaseFreeSenateTitle = objRow[convPubClassCaseFreeSenate.PubClassCaseFreeSenateTitle] == DBNull.Value ? null : objRow[convPubClassCaseFreeSenate.PubClassCaseFreeSenateTitle].ToString().Trim(); //公开课案例自由评议标题
objvPubClassCaseFreeSenateEN.PubClassCaseFreeSenateConten = objRow[convPubClassCaseFreeSenate.PubClassCaseFreeSenateConten] == DBNull.Value ? null : objRow[convPubClassCaseFreeSenate.PubClassCaseFreeSenateConten].ToString().Trim(); //公开课案例自由评议内容
objvPubClassCaseFreeSenateEN.PubClassCaseFreeSenateDate = objRow[convPubClassCaseFreeSenate.PubClassCaseFreeSenateDate] == DBNull.Value ? null : objRow[convPubClassCaseFreeSenate.PubClassCaseFreeSenateDate].ToString().Trim(); //公开课案例自由评议日期
objvPubClassCaseFreeSenateEN.PubClassCaseFreeSenateTime = objRow[convPubClassCaseFreeSenate.PubClassCaseFreeSenateTime] == DBNull.Value ? null : objRow[convPubClassCaseFreeSenate.PubClassCaseFreeSenateTime].ToString().Trim(); //公开课案例自由评议时间
objvPubClassCaseFreeSenateEN.BrowseCount = objRow[convPubClassCaseFreeSenate.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPubClassCaseFreeSenate.BrowseCount].ToString().Trim()); //浏览次数
objvPubClassCaseFreeSenateEN.VideoStopTime = objRow[convPubClassCaseFreeSenate.VideoStopTime] == DBNull.Value ? null : objRow[convPubClassCaseFreeSenate.VideoStopTime].ToString().Trim(); //公开课案例视频暂停时间
objvPubClassCaseFreeSenateEN.IsVisible = TransNullToBool(objRow[convPubClassCaseFreeSenate.IsVisible].ToString().Trim()); //是否显示
objvPubClassCaseFreeSenateEN.IdDiscipline = objRow[convPubClassCaseFreeSenate.IdDiscipline].ToString().Trim(); //学科流水号
objvPubClassCaseFreeSenateEN.DisciplineID = objRow[convPubClassCaseFreeSenate.DisciplineID].ToString().Trim(); //学科ID
objvPubClassCaseFreeSenateEN.DisciplineName = objRow[convPubClassCaseFreeSenate.DisciplineName].ToString().Trim(); //学科名称
objvPubClassCaseFreeSenateEN.IdStudyLevel = objRow[convPubClassCaseFreeSenate.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvPubClassCaseFreeSenateEN.StudyLevelName = objRow[convPubClassCaseFreeSenate.StudyLevelName].ToString().Trim(); //学段名称
objvPubClassCaseFreeSenateEN.PubClassCaseTeachDate = objRow[convPubClassCaseFreeSenate.PubClassCaseTeachDate] == DBNull.Value ? null : objRow[convPubClassCaseFreeSenate.PubClassCaseTeachDate].ToString().Trim(); //案例授课日期
objvPubClassCaseFreeSenateEN.PubClassCaseDateIn = objRow[convPubClassCaseFreeSenate.PubClassCaseDateIn] == DBNull.Value ? null : objRow[convPubClassCaseFreeSenate.PubClassCaseDateIn].ToString().Trim(); //案例入库日期
objvPubClassCaseFreeSenateEN.IdTeachingPlan = objRow[convPubClassCaseFreeSenate.IdTeachingPlan].ToString().Trim(); //教案流水号
objvPubClassCaseFreeSenateEN.SubjectName = objRow[convPubClassCaseFreeSenate.SubjectName].ToString().Trim(); //课题名称
objvPubClassCaseFreeSenateEN.IdPubCaseType = objRow[convPubClassCaseFreeSenate.IdPubCaseType].ToString().Trim(); //公开课案例类型流水号
objvPubClassCaseFreeSenateEN.PubCaseTypeID = objRow[convPubClassCaseFreeSenate.PubCaseTypeID].ToString().Trim(); //公开课案例类型ID
objvPubClassCaseFreeSenateEN.PubCaseTypeName = objRow[convPubClassCaseFreeSenate.PubCaseTypeName].ToString().Trim(); //公开课案例类型名称
objvPubClassCaseFreeSenateEN.CollegeID = objRow[convPubClassCaseFreeSenate.CollegeID] == DBNull.Value ? null : objRow[convPubClassCaseFreeSenate.CollegeID].ToString().Trim(); //学院ID
objvPubClassCaseFreeSenateEN.CollegeName = objRow[convPubClassCaseFreeSenate.CollegeName] == DBNull.Value ? null : objRow[convPubClassCaseFreeSenate.CollegeName].ToString().Trim(); //学院名称
objvPubClassCaseFreeSenateEN.IdXzCollege = objRow[convPubClassCaseFreeSenate.IdXzCollege] == DBNull.Value ? null : objRow[convPubClassCaseFreeSenate.IdXzCollege].ToString().Trim(); //学院流水号
objvPubClassCaseFreeSenateEN.IsLeaved = TransNullToBool(objRow[convPubClassCaseFreeSenate.IsLeaved].ToString().Trim()); //IsLeaved
objvPubClassCaseFreeSenateEN.StuIdTeacherId = objRow[convPubClassCaseFreeSenate.StuIdTeacherId] == DBNull.Value ? null : objRow[convPubClassCaseFreeSenate.StuIdTeacherId].ToString().Trim(); //学工号
objvPubClassCaseFreeSenateEN.BrowseCount4Case = objRow[convPubClassCaseFreeSenate.BrowseCount4Case] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPubClassCaseFreeSenate.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvPubClassCaseFreeSenateEN.CollegeNameA = objRow[convPubClassCaseFreeSenate.CollegeNameA] == DBNull.Value ? null : objRow[convPubClassCaseFreeSenate.CollegeNameA].ToString().Trim(); //学院名称简写
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvPubClassCaseFreeSenateDA: GetObjLst)", objException.Message));
}
objvPubClassCaseFreeSenateEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvPubClassCaseFreeSenateEN);
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
public List<clsvPubClassCaseFreeSenateEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvPubClassCaseFreeSenateDA:GetObjLstByTabName)", objException.Message));
}
List<clsvPubClassCaseFreeSenateEN> arrObjLst = new List<clsvPubClassCaseFreeSenateEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPubClassCaseFreeSenateDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPubClassCaseFreeSenateEN objvPubClassCaseFreeSenateEN = new clsvPubClassCaseFreeSenateEN();
try
{
objvPubClassCaseFreeSenateEN.IdPubClassCaseFreeSenate = TransNullToInt(objRow[convPubClassCaseFreeSenate.IdPubClassCaseFreeSenate].ToString().Trim()); //公开课案例自由评议流水号
objvPubClassCaseFreeSenateEN.IdPubClassCase = objRow[convPubClassCaseFreeSenate.IdPubClassCase].ToString().Trim(); //案例流水号
objvPubClassCaseFreeSenateEN.PubClassCaseID = objRow[convPubClassCaseFreeSenate.PubClassCaseID].ToString().Trim(); //案例ID
objvPubClassCaseFreeSenateEN.PubClassCaseName = objRow[convPubClassCaseFreeSenate.PubClassCaseName].ToString().Trim(); //案例课题名称
objvPubClassCaseFreeSenateEN.PubClassCaseExecutor = objRow[convPubClassCaseFreeSenate.PubClassCaseExecutor] == DBNull.Value ? null : objRow[convPubClassCaseFreeSenate.PubClassCaseExecutor].ToString().Trim(); //案例执教者
objvPubClassCaseFreeSenateEN.PubClassCaseTheme = objRow[convPubClassCaseFreeSenate.PubClassCaseTheme] == DBNull.Value ? null : objRow[convPubClassCaseFreeSenate.PubClassCaseTheme].ToString().Trim(); //案例主题词
objvPubClassCaseFreeSenateEN.UserId = objRow[convPubClassCaseFreeSenate.UserId].ToString().Trim(); //用户ID
objvPubClassCaseFreeSenateEN.UserName = objRow[convPubClassCaseFreeSenate.UserName] == DBNull.Value ? null : objRow[convPubClassCaseFreeSenate.UserName].ToString().Trim(); //用户名
objvPubClassCaseFreeSenateEN.AppraiseTheme = objRow[convPubClassCaseFreeSenate.AppraiseTheme] == DBNull.Value ? null : objRow[convPubClassCaseFreeSenate.AppraiseTheme].ToString().Trim(); //评议主题
objvPubClassCaseFreeSenateEN.PubClassCaseFreeSenateTitle = objRow[convPubClassCaseFreeSenate.PubClassCaseFreeSenateTitle] == DBNull.Value ? null : objRow[convPubClassCaseFreeSenate.PubClassCaseFreeSenateTitle].ToString().Trim(); //公开课案例自由评议标题
objvPubClassCaseFreeSenateEN.PubClassCaseFreeSenateConten = objRow[convPubClassCaseFreeSenate.PubClassCaseFreeSenateConten] == DBNull.Value ? null : objRow[convPubClassCaseFreeSenate.PubClassCaseFreeSenateConten].ToString().Trim(); //公开课案例自由评议内容
objvPubClassCaseFreeSenateEN.PubClassCaseFreeSenateDate = objRow[convPubClassCaseFreeSenate.PubClassCaseFreeSenateDate] == DBNull.Value ? null : objRow[convPubClassCaseFreeSenate.PubClassCaseFreeSenateDate].ToString().Trim(); //公开课案例自由评议日期
objvPubClassCaseFreeSenateEN.PubClassCaseFreeSenateTime = objRow[convPubClassCaseFreeSenate.PubClassCaseFreeSenateTime] == DBNull.Value ? null : objRow[convPubClassCaseFreeSenate.PubClassCaseFreeSenateTime].ToString().Trim(); //公开课案例自由评议时间
objvPubClassCaseFreeSenateEN.BrowseCount = objRow[convPubClassCaseFreeSenate.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPubClassCaseFreeSenate.BrowseCount].ToString().Trim()); //浏览次数
objvPubClassCaseFreeSenateEN.VideoStopTime = objRow[convPubClassCaseFreeSenate.VideoStopTime] == DBNull.Value ? null : objRow[convPubClassCaseFreeSenate.VideoStopTime].ToString().Trim(); //公开课案例视频暂停时间
objvPubClassCaseFreeSenateEN.IsVisible = TransNullToBool(objRow[convPubClassCaseFreeSenate.IsVisible].ToString().Trim()); //是否显示
objvPubClassCaseFreeSenateEN.IdDiscipline = objRow[convPubClassCaseFreeSenate.IdDiscipline].ToString().Trim(); //学科流水号
objvPubClassCaseFreeSenateEN.DisciplineID = objRow[convPubClassCaseFreeSenate.DisciplineID].ToString().Trim(); //学科ID
objvPubClassCaseFreeSenateEN.DisciplineName = objRow[convPubClassCaseFreeSenate.DisciplineName].ToString().Trim(); //学科名称
objvPubClassCaseFreeSenateEN.IdStudyLevel = objRow[convPubClassCaseFreeSenate.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvPubClassCaseFreeSenateEN.StudyLevelName = objRow[convPubClassCaseFreeSenate.StudyLevelName].ToString().Trim(); //学段名称
objvPubClassCaseFreeSenateEN.PubClassCaseTeachDate = objRow[convPubClassCaseFreeSenate.PubClassCaseTeachDate] == DBNull.Value ? null : objRow[convPubClassCaseFreeSenate.PubClassCaseTeachDate].ToString().Trim(); //案例授课日期
objvPubClassCaseFreeSenateEN.PubClassCaseDateIn = objRow[convPubClassCaseFreeSenate.PubClassCaseDateIn] == DBNull.Value ? null : objRow[convPubClassCaseFreeSenate.PubClassCaseDateIn].ToString().Trim(); //案例入库日期
objvPubClassCaseFreeSenateEN.IdTeachingPlan = objRow[convPubClassCaseFreeSenate.IdTeachingPlan].ToString().Trim(); //教案流水号
objvPubClassCaseFreeSenateEN.SubjectName = objRow[convPubClassCaseFreeSenate.SubjectName].ToString().Trim(); //课题名称
objvPubClassCaseFreeSenateEN.IdPubCaseType = objRow[convPubClassCaseFreeSenate.IdPubCaseType].ToString().Trim(); //公开课案例类型流水号
objvPubClassCaseFreeSenateEN.PubCaseTypeID = objRow[convPubClassCaseFreeSenate.PubCaseTypeID].ToString().Trim(); //公开课案例类型ID
objvPubClassCaseFreeSenateEN.PubCaseTypeName = objRow[convPubClassCaseFreeSenate.PubCaseTypeName].ToString().Trim(); //公开课案例类型名称
objvPubClassCaseFreeSenateEN.CollegeID = objRow[convPubClassCaseFreeSenate.CollegeID] == DBNull.Value ? null : objRow[convPubClassCaseFreeSenate.CollegeID].ToString().Trim(); //学院ID
objvPubClassCaseFreeSenateEN.CollegeName = objRow[convPubClassCaseFreeSenate.CollegeName] == DBNull.Value ? null : objRow[convPubClassCaseFreeSenate.CollegeName].ToString().Trim(); //学院名称
objvPubClassCaseFreeSenateEN.IdXzCollege = objRow[convPubClassCaseFreeSenate.IdXzCollege] == DBNull.Value ? null : objRow[convPubClassCaseFreeSenate.IdXzCollege].ToString().Trim(); //学院流水号
objvPubClassCaseFreeSenateEN.IsLeaved = TransNullToBool(objRow[convPubClassCaseFreeSenate.IsLeaved].ToString().Trim()); //IsLeaved
objvPubClassCaseFreeSenateEN.StuIdTeacherId = objRow[convPubClassCaseFreeSenate.StuIdTeacherId] == DBNull.Value ? null : objRow[convPubClassCaseFreeSenate.StuIdTeacherId].ToString().Trim(); //学工号
objvPubClassCaseFreeSenateEN.BrowseCount4Case = objRow[convPubClassCaseFreeSenate.BrowseCount4Case] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPubClassCaseFreeSenate.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvPubClassCaseFreeSenateEN.CollegeNameA = objRow[convPubClassCaseFreeSenate.CollegeNameA] == DBNull.Value ? null : objRow[convPubClassCaseFreeSenate.CollegeNameA].ToString().Trim(); //学院名称简写
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvPubClassCaseFreeSenateDA: GetObjLst)", objException.Message));
}
objvPubClassCaseFreeSenateEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvPubClassCaseFreeSenateEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvPubClassCaseFreeSenateEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvPubClassCaseFreeSenate(ref clsvPubClassCaseFreeSenateEN objvPubClassCaseFreeSenateEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPubClassCaseFreeSenateDA.GetSpecSQLObj();
strSQL = "Select * from vPubClassCaseFreeSenate where IdPubClassCaseFreeSenate = " + ""+ objvPubClassCaseFreeSenateEN.IdPubClassCaseFreeSenate+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvPubClassCaseFreeSenateEN.IdPubClassCaseFreeSenate = TransNullToInt(objDT.Rows[0][convPubClassCaseFreeSenate.IdPubClassCaseFreeSenate].ToString().Trim()); //公开课案例自由评议流水号(字段类型:bigint,字段长度:8,是否可空:False)
 objvPubClassCaseFreeSenateEN.IdPubClassCase = objDT.Rows[0][convPubClassCaseFreeSenate.IdPubClassCase].ToString().Trim(); //案例流水号(字段类型:char,字段长度:8,是否可空:False)
 objvPubClassCaseFreeSenateEN.PubClassCaseID = objDT.Rows[0][convPubClassCaseFreeSenate.PubClassCaseID].ToString().Trim(); //案例ID(字段类型:char,字段长度:8,是否可空:False)
 objvPubClassCaseFreeSenateEN.PubClassCaseName = objDT.Rows[0][convPubClassCaseFreeSenate.PubClassCaseName].ToString().Trim(); //案例课题名称(字段类型:varchar,字段长度:200,是否可空:False)
 objvPubClassCaseFreeSenateEN.PubClassCaseExecutor = objDT.Rows[0][convPubClassCaseFreeSenate.PubClassCaseExecutor].ToString().Trim(); //案例执教者(字段类型:varchar,字段长度:50,是否可空:True)
 objvPubClassCaseFreeSenateEN.PubClassCaseTheme = objDT.Rows[0][convPubClassCaseFreeSenate.PubClassCaseTheme].ToString().Trim(); //案例主题词(字段类型:varchar,字段长度:500,是否可空:True)
 objvPubClassCaseFreeSenateEN.UserId = objDT.Rows[0][convPubClassCaseFreeSenate.UserId].ToString().Trim(); //用户ID(字段类型:varchar,字段长度:18,是否可空:True)
 objvPubClassCaseFreeSenateEN.UserName = objDT.Rows[0][convPubClassCaseFreeSenate.UserName].ToString().Trim(); //用户名(字段类型:varchar,字段长度:30,是否可空:True)
 objvPubClassCaseFreeSenateEN.AppraiseTheme = objDT.Rows[0][convPubClassCaseFreeSenate.AppraiseTheme].ToString().Trim(); //评议主题(字段类型:varchar,字段长度:200,是否可空:True)
 objvPubClassCaseFreeSenateEN.PubClassCaseFreeSenateTitle = objDT.Rows[0][convPubClassCaseFreeSenate.PubClassCaseFreeSenateTitle].ToString().Trim(); //公开课案例自由评议标题(字段类型:varchar,字段长度:200,是否可空:True)
 objvPubClassCaseFreeSenateEN.PubClassCaseFreeSenateConten = objDT.Rows[0][convPubClassCaseFreeSenate.PubClassCaseFreeSenateConten].ToString().Trim(); //公开课案例自由评议内容(字段类型:varchar,字段长度:2000,是否可空:True)
 objvPubClassCaseFreeSenateEN.PubClassCaseFreeSenateDate = objDT.Rows[0][convPubClassCaseFreeSenate.PubClassCaseFreeSenateDate].ToString().Trim(); //公开课案例自由评议日期(字段类型:char,字段长度:8,是否可空:True)
 objvPubClassCaseFreeSenateEN.PubClassCaseFreeSenateTime = objDT.Rows[0][convPubClassCaseFreeSenate.PubClassCaseFreeSenateTime].ToString().Trim(); //公开课案例自由评议时间(字段类型:char,字段长度:6,是否可空:True)
 objvPubClassCaseFreeSenateEN.BrowseCount = TransNullToInt(objDT.Rows[0][convPubClassCaseFreeSenate.BrowseCount].ToString().Trim()); //浏览次数(字段类型:int,字段长度:4,是否可空:True)
 objvPubClassCaseFreeSenateEN.VideoStopTime = objDT.Rows[0][convPubClassCaseFreeSenate.VideoStopTime].ToString().Trim(); //公开课案例视频暂停时间(字段类型:varchar,字段长度:48,是否可空:True)
 objvPubClassCaseFreeSenateEN.IsVisible = TransNullToBool(objDT.Rows[0][convPubClassCaseFreeSenate.IsVisible].ToString().Trim()); //是否显示(字段类型:bit,字段长度:1,是否可空:True)
 objvPubClassCaseFreeSenateEN.IdDiscipline = objDT.Rows[0][convPubClassCaseFreeSenate.IdDiscipline].ToString().Trim(); //学科流水号(字段类型:char,字段长度:4,是否可空:False)
 objvPubClassCaseFreeSenateEN.DisciplineID = objDT.Rows[0][convPubClassCaseFreeSenate.DisciplineID].ToString().Trim(); //学科ID(字段类型:char,字段长度:4,是否可空:False)
 objvPubClassCaseFreeSenateEN.DisciplineName = objDT.Rows[0][convPubClassCaseFreeSenate.DisciplineName].ToString().Trim(); //学科名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvPubClassCaseFreeSenateEN.IdStudyLevel = objDT.Rows[0][convPubClassCaseFreeSenate.IdStudyLevel].ToString().Trim(); //id_StudyLevel(字段类型:char,字段长度:4,是否可空:True)
 objvPubClassCaseFreeSenateEN.StudyLevelName = objDT.Rows[0][convPubClassCaseFreeSenate.StudyLevelName].ToString().Trim(); //学段名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvPubClassCaseFreeSenateEN.PubClassCaseTeachDate = objDT.Rows[0][convPubClassCaseFreeSenate.PubClassCaseTeachDate].ToString().Trim(); //案例授课日期(字段类型:char,字段长度:8,是否可空:True)
 objvPubClassCaseFreeSenateEN.PubClassCaseDateIn = objDT.Rows[0][convPubClassCaseFreeSenate.PubClassCaseDateIn].ToString().Trim(); //案例入库日期(字段类型:char,字段长度:8,是否可空:True)
 objvPubClassCaseFreeSenateEN.IdTeachingPlan = objDT.Rows[0][convPubClassCaseFreeSenate.IdTeachingPlan].ToString().Trim(); //教案流水号(字段类型:char,字段长度:8,是否可空:False)
 objvPubClassCaseFreeSenateEN.SubjectName = objDT.Rows[0][convPubClassCaseFreeSenate.SubjectName].ToString().Trim(); //课题名称(字段类型:varchar,字段长度:200,是否可空:False)
 objvPubClassCaseFreeSenateEN.IdPubCaseType = objDT.Rows[0][convPubClassCaseFreeSenate.IdPubCaseType].ToString().Trim(); //公开课案例类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvPubClassCaseFreeSenateEN.PubCaseTypeID = objDT.Rows[0][convPubClassCaseFreeSenate.PubCaseTypeID].ToString().Trim(); //公开课案例类型ID(字段类型:char,字段长度:4,是否可空:False)
 objvPubClassCaseFreeSenateEN.PubCaseTypeName = objDT.Rows[0][convPubClassCaseFreeSenate.PubCaseTypeName].ToString().Trim(); //公开课案例类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvPubClassCaseFreeSenateEN.CollegeID = objDT.Rows[0][convPubClassCaseFreeSenate.CollegeID].ToString().Trim(); //学院ID(字段类型:varchar,字段长度:4,是否可空:False)
 objvPubClassCaseFreeSenateEN.CollegeName = objDT.Rows[0][convPubClassCaseFreeSenate.CollegeName].ToString().Trim(); //学院名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvPubClassCaseFreeSenateEN.IdXzCollege = objDT.Rows[0][convPubClassCaseFreeSenate.IdXzCollege].ToString().Trim(); //学院流水号(字段类型:char,字段长度:4,是否可空:True)
 objvPubClassCaseFreeSenateEN.IsLeaved = TransNullToBool(objDT.Rows[0][convPubClassCaseFreeSenate.IsLeaved].ToString().Trim()); //IsLeaved(字段类型:bit,字段长度:1,是否可空:True)
 objvPubClassCaseFreeSenateEN.StuIdTeacherId = objDT.Rows[0][convPubClassCaseFreeSenate.StuIdTeacherId].ToString().Trim(); //学工号(字段类型:varchar,字段长度:20,是否可空:True)
 objvPubClassCaseFreeSenateEN.BrowseCount4Case = TransNullToInt(objDT.Rows[0][convPubClassCaseFreeSenate.BrowseCount4Case].ToString().Trim()); //课例浏览次数(字段类型:int,字段长度:4,是否可空:True)
 objvPubClassCaseFreeSenateEN.CollegeNameA = objDT.Rows[0][convPubClassCaseFreeSenate.CollegeNameA].ToString().Trim(); //学院名称简写(字段类型:varchar,字段长度:12,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvPubClassCaseFreeSenateDA: GetvPubClassCaseFreeSenate)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngIdPubClassCaseFreeSenate">表关键字</param>
 /// <returns>表对象</returns>
public clsvPubClassCaseFreeSenateEN GetObjByIdPubClassCaseFreeSenate(long lngIdPubClassCaseFreeSenate)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPubClassCaseFreeSenateDA.GetSpecSQLObj();
strSQL = "Select * from vPubClassCaseFreeSenate where IdPubClassCaseFreeSenate = " + ""+ lngIdPubClassCaseFreeSenate+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvPubClassCaseFreeSenateEN objvPubClassCaseFreeSenateEN = new clsvPubClassCaseFreeSenateEN();
try
{
 objvPubClassCaseFreeSenateEN.IdPubClassCaseFreeSenate = Int32.Parse(objRow[convPubClassCaseFreeSenate.IdPubClassCaseFreeSenate].ToString().Trim()); //公开课案例自由评议流水号(字段类型:bigint,字段长度:8,是否可空:False)
 objvPubClassCaseFreeSenateEN.IdPubClassCase = objRow[convPubClassCaseFreeSenate.IdPubClassCase].ToString().Trim(); //案例流水号(字段类型:char,字段长度:8,是否可空:False)
 objvPubClassCaseFreeSenateEN.PubClassCaseID = objRow[convPubClassCaseFreeSenate.PubClassCaseID].ToString().Trim(); //案例ID(字段类型:char,字段长度:8,是否可空:False)
 objvPubClassCaseFreeSenateEN.PubClassCaseName = objRow[convPubClassCaseFreeSenate.PubClassCaseName].ToString().Trim(); //案例课题名称(字段类型:varchar,字段长度:200,是否可空:False)
 objvPubClassCaseFreeSenateEN.PubClassCaseExecutor = objRow[convPubClassCaseFreeSenate.PubClassCaseExecutor] == DBNull.Value ? null : objRow[convPubClassCaseFreeSenate.PubClassCaseExecutor].ToString().Trim(); //案例执教者(字段类型:varchar,字段长度:50,是否可空:True)
 objvPubClassCaseFreeSenateEN.PubClassCaseTheme = objRow[convPubClassCaseFreeSenate.PubClassCaseTheme] == DBNull.Value ? null : objRow[convPubClassCaseFreeSenate.PubClassCaseTheme].ToString().Trim(); //案例主题词(字段类型:varchar,字段长度:500,是否可空:True)
 objvPubClassCaseFreeSenateEN.UserId = objRow[convPubClassCaseFreeSenate.UserId].ToString().Trim(); //用户ID(字段类型:varchar,字段长度:18,是否可空:True)
 objvPubClassCaseFreeSenateEN.UserName = objRow[convPubClassCaseFreeSenate.UserName] == DBNull.Value ? null : objRow[convPubClassCaseFreeSenate.UserName].ToString().Trim(); //用户名(字段类型:varchar,字段长度:30,是否可空:True)
 objvPubClassCaseFreeSenateEN.AppraiseTheme = objRow[convPubClassCaseFreeSenate.AppraiseTheme] == DBNull.Value ? null : objRow[convPubClassCaseFreeSenate.AppraiseTheme].ToString().Trim(); //评议主题(字段类型:varchar,字段长度:200,是否可空:True)
 objvPubClassCaseFreeSenateEN.PubClassCaseFreeSenateTitle = objRow[convPubClassCaseFreeSenate.PubClassCaseFreeSenateTitle] == DBNull.Value ? null : objRow[convPubClassCaseFreeSenate.PubClassCaseFreeSenateTitle].ToString().Trim(); //公开课案例自由评议标题(字段类型:varchar,字段长度:200,是否可空:True)
 objvPubClassCaseFreeSenateEN.PubClassCaseFreeSenateConten = objRow[convPubClassCaseFreeSenate.PubClassCaseFreeSenateConten] == DBNull.Value ? null : objRow[convPubClassCaseFreeSenate.PubClassCaseFreeSenateConten].ToString().Trim(); //公开课案例自由评议内容(字段类型:varchar,字段长度:2000,是否可空:True)
 objvPubClassCaseFreeSenateEN.PubClassCaseFreeSenateDate = objRow[convPubClassCaseFreeSenate.PubClassCaseFreeSenateDate] == DBNull.Value ? null : objRow[convPubClassCaseFreeSenate.PubClassCaseFreeSenateDate].ToString().Trim(); //公开课案例自由评议日期(字段类型:char,字段长度:8,是否可空:True)
 objvPubClassCaseFreeSenateEN.PubClassCaseFreeSenateTime = objRow[convPubClassCaseFreeSenate.PubClassCaseFreeSenateTime] == DBNull.Value ? null : objRow[convPubClassCaseFreeSenate.PubClassCaseFreeSenateTime].ToString().Trim(); //公开课案例自由评议时间(字段类型:char,字段长度:6,是否可空:True)
 objvPubClassCaseFreeSenateEN.BrowseCount = objRow[convPubClassCaseFreeSenate.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPubClassCaseFreeSenate.BrowseCount].ToString().Trim()); //浏览次数(字段类型:int,字段长度:4,是否可空:True)
 objvPubClassCaseFreeSenateEN.VideoStopTime = objRow[convPubClassCaseFreeSenate.VideoStopTime] == DBNull.Value ? null : objRow[convPubClassCaseFreeSenate.VideoStopTime].ToString().Trim(); //公开课案例视频暂停时间(字段类型:varchar,字段长度:48,是否可空:True)
 objvPubClassCaseFreeSenateEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convPubClassCaseFreeSenate.IsVisible].ToString().Trim()); //是否显示(字段类型:bit,字段长度:1,是否可空:True)
 objvPubClassCaseFreeSenateEN.IdDiscipline = objRow[convPubClassCaseFreeSenate.IdDiscipline].ToString().Trim(); //学科流水号(字段类型:char,字段长度:4,是否可空:False)
 objvPubClassCaseFreeSenateEN.DisciplineID = objRow[convPubClassCaseFreeSenate.DisciplineID].ToString().Trim(); //学科ID(字段类型:char,字段长度:4,是否可空:False)
 objvPubClassCaseFreeSenateEN.DisciplineName = objRow[convPubClassCaseFreeSenate.DisciplineName].ToString().Trim(); //学科名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvPubClassCaseFreeSenateEN.IdStudyLevel = objRow[convPubClassCaseFreeSenate.IdStudyLevel].ToString().Trim(); //id_StudyLevel(字段类型:char,字段长度:4,是否可空:True)
 objvPubClassCaseFreeSenateEN.StudyLevelName = objRow[convPubClassCaseFreeSenate.StudyLevelName].ToString().Trim(); //学段名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvPubClassCaseFreeSenateEN.PubClassCaseTeachDate = objRow[convPubClassCaseFreeSenate.PubClassCaseTeachDate] == DBNull.Value ? null : objRow[convPubClassCaseFreeSenate.PubClassCaseTeachDate].ToString().Trim(); //案例授课日期(字段类型:char,字段长度:8,是否可空:True)
 objvPubClassCaseFreeSenateEN.PubClassCaseDateIn = objRow[convPubClassCaseFreeSenate.PubClassCaseDateIn] == DBNull.Value ? null : objRow[convPubClassCaseFreeSenate.PubClassCaseDateIn].ToString().Trim(); //案例入库日期(字段类型:char,字段长度:8,是否可空:True)
 objvPubClassCaseFreeSenateEN.IdTeachingPlan = objRow[convPubClassCaseFreeSenate.IdTeachingPlan].ToString().Trim(); //教案流水号(字段类型:char,字段长度:8,是否可空:False)
 objvPubClassCaseFreeSenateEN.SubjectName = objRow[convPubClassCaseFreeSenate.SubjectName].ToString().Trim(); //课题名称(字段类型:varchar,字段长度:200,是否可空:False)
 objvPubClassCaseFreeSenateEN.IdPubCaseType = objRow[convPubClassCaseFreeSenate.IdPubCaseType].ToString().Trim(); //公开课案例类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvPubClassCaseFreeSenateEN.PubCaseTypeID = objRow[convPubClassCaseFreeSenate.PubCaseTypeID].ToString().Trim(); //公开课案例类型ID(字段类型:char,字段长度:4,是否可空:False)
 objvPubClassCaseFreeSenateEN.PubCaseTypeName = objRow[convPubClassCaseFreeSenate.PubCaseTypeName].ToString().Trim(); //公开课案例类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvPubClassCaseFreeSenateEN.CollegeID = objRow[convPubClassCaseFreeSenate.CollegeID] == DBNull.Value ? null : objRow[convPubClassCaseFreeSenate.CollegeID].ToString().Trim(); //学院ID(字段类型:varchar,字段长度:4,是否可空:False)
 objvPubClassCaseFreeSenateEN.CollegeName = objRow[convPubClassCaseFreeSenate.CollegeName] == DBNull.Value ? null : objRow[convPubClassCaseFreeSenate.CollegeName].ToString().Trim(); //学院名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvPubClassCaseFreeSenateEN.IdXzCollege = objRow[convPubClassCaseFreeSenate.IdXzCollege] == DBNull.Value ? null : objRow[convPubClassCaseFreeSenate.IdXzCollege].ToString().Trim(); //学院流水号(字段类型:char,字段长度:4,是否可空:True)
 objvPubClassCaseFreeSenateEN.IsLeaved = clsEntityBase2.TransNullToBool_S(objRow[convPubClassCaseFreeSenate.IsLeaved].ToString().Trim()); //IsLeaved(字段类型:bit,字段长度:1,是否可空:True)
 objvPubClassCaseFreeSenateEN.StuIdTeacherId = objRow[convPubClassCaseFreeSenate.StuIdTeacherId] == DBNull.Value ? null : objRow[convPubClassCaseFreeSenate.StuIdTeacherId].ToString().Trim(); //学工号(字段类型:varchar,字段长度:20,是否可空:True)
 objvPubClassCaseFreeSenateEN.BrowseCount4Case = objRow[convPubClassCaseFreeSenate.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPubClassCaseFreeSenate.BrowseCount4Case].ToString().Trim()); //课例浏览次数(字段类型:int,字段长度:4,是否可空:True)
 objvPubClassCaseFreeSenateEN.CollegeNameA = objRow[convPubClassCaseFreeSenate.CollegeNameA] == DBNull.Value ? null : objRow[convPubClassCaseFreeSenate.CollegeNameA].ToString().Trim(); //学院名称简写(字段类型:varchar,字段长度:12,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvPubClassCaseFreeSenateDA: GetObjByIdPubClassCaseFreeSenate)", objException.Message));
}
return objvPubClassCaseFreeSenateEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvPubClassCaseFreeSenateEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvPubClassCaseFreeSenateDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPubClassCaseFreeSenateDA.GetSpecSQLObj();
strSQL = "Select * from vPubClassCaseFreeSenate where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvPubClassCaseFreeSenateEN objvPubClassCaseFreeSenateEN = new clsvPubClassCaseFreeSenateEN()
{
IdPubClassCaseFreeSenate = TransNullToInt(objRow[convPubClassCaseFreeSenate.IdPubClassCaseFreeSenate].ToString().Trim()), //公开课案例自由评议流水号
IdPubClassCase = objRow[convPubClassCaseFreeSenate.IdPubClassCase].ToString().Trim(), //案例流水号
PubClassCaseID = objRow[convPubClassCaseFreeSenate.PubClassCaseID].ToString().Trim(), //案例ID
PubClassCaseName = objRow[convPubClassCaseFreeSenate.PubClassCaseName].ToString().Trim(), //案例课题名称
PubClassCaseExecutor = objRow[convPubClassCaseFreeSenate.PubClassCaseExecutor] == DBNull.Value ? null : objRow[convPubClassCaseFreeSenate.PubClassCaseExecutor].ToString().Trim(), //案例执教者
PubClassCaseTheme = objRow[convPubClassCaseFreeSenate.PubClassCaseTheme] == DBNull.Value ? null : objRow[convPubClassCaseFreeSenate.PubClassCaseTheme].ToString().Trim(), //案例主题词
UserId = objRow[convPubClassCaseFreeSenate.UserId].ToString().Trim(), //用户ID
UserName = objRow[convPubClassCaseFreeSenate.UserName] == DBNull.Value ? null : objRow[convPubClassCaseFreeSenate.UserName].ToString().Trim(), //用户名
AppraiseTheme = objRow[convPubClassCaseFreeSenate.AppraiseTheme] == DBNull.Value ? null : objRow[convPubClassCaseFreeSenate.AppraiseTheme].ToString().Trim(), //评议主题
PubClassCaseFreeSenateTitle = objRow[convPubClassCaseFreeSenate.PubClassCaseFreeSenateTitle] == DBNull.Value ? null : objRow[convPubClassCaseFreeSenate.PubClassCaseFreeSenateTitle].ToString().Trim(), //公开课案例自由评议标题
PubClassCaseFreeSenateConten = objRow[convPubClassCaseFreeSenate.PubClassCaseFreeSenateConten] == DBNull.Value ? null : objRow[convPubClassCaseFreeSenate.PubClassCaseFreeSenateConten].ToString().Trim(), //公开课案例自由评议内容
PubClassCaseFreeSenateDate = objRow[convPubClassCaseFreeSenate.PubClassCaseFreeSenateDate] == DBNull.Value ? null : objRow[convPubClassCaseFreeSenate.PubClassCaseFreeSenateDate].ToString().Trim(), //公开课案例自由评议日期
PubClassCaseFreeSenateTime = objRow[convPubClassCaseFreeSenate.PubClassCaseFreeSenateTime] == DBNull.Value ? null : objRow[convPubClassCaseFreeSenate.PubClassCaseFreeSenateTime].ToString().Trim(), //公开课案例自由评议时间
BrowseCount = objRow[convPubClassCaseFreeSenate.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPubClassCaseFreeSenate.BrowseCount].ToString().Trim()), //浏览次数
VideoStopTime = objRow[convPubClassCaseFreeSenate.VideoStopTime] == DBNull.Value ? null : objRow[convPubClassCaseFreeSenate.VideoStopTime].ToString().Trim(), //公开课案例视频暂停时间
IsVisible = TransNullToBool(objRow[convPubClassCaseFreeSenate.IsVisible].ToString().Trim()), //是否显示
IdDiscipline = objRow[convPubClassCaseFreeSenate.IdDiscipline].ToString().Trim(), //学科流水号
DisciplineID = objRow[convPubClassCaseFreeSenate.DisciplineID].ToString().Trim(), //学科ID
DisciplineName = objRow[convPubClassCaseFreeSenate.DisciplineName].ToString().Trim(), //学科名称
IdStudyLevel = objRow[convPubClassCaseFreeSenate.IdStudyLevel].ToString().Trim(), //id_StudyLevel
StudyLevelName = objRow[convPubClassCaseFreeSenate.StudyLevelName].ToString().Trim(), //学段名称
PubClassCaseTeachDate = objRow[convPubClassCaseFreeSenate.PubClassCaseTeachDate] == DBNull.Value ? null : objRow[convPubClassCaseFreeSenate.PubClassCaseTeachDate].ToString().Trim(), //案例授课日期
PubClassCaseDateIn = objRow[convPubClassCaseFreeSenate.PubClassCaseDateIn] == DBNull.Value ? null : objRow[convPubClassCaseFreeSenate.PubClassCaseDateIn].ToString().Trim(), //案例入库日期
IdTeachingPlan = objRow[convPubClassCaseFreeSenate.IdTeachingPlan].ToString().Trim(), //教案流水号
SubjectName = objRow[convPubClassCaseFreeSenate.SubjectName].ToString().Trim(), //课题名称
IdPubCaseType = objRow[convPubClassCaseFreeSenate.IdPubCaseType].ToString().Trim(), //公开课案例类型流水号
PubCaseTypeID = objRow[convPubClassCaseFreeSenate.PubCaseTypeID].ToString().Trim(), //公开课案例类型ID
PubCaseTypeName = objRow[convPubClassCaseFreeSenate.PubCaseTypeName].ToString().Trim(), //公开课案例类型名称
CollegeID = objRow[convPubClassCaseFreeSenate.CollegeID] == DBNull.Value ? null : objRow[convPubClassCaseFreeSenate.CollegeID].ToString().Trim(), //学院ID
CollegeName = objRow[convPubClassCaseFreeSenate.CollegeName] == DBNull.Value ? null : objRow[convPubClassCaseFreeSenate.CollegeName].ToString().Trim(), //学院名称
IdXzCollege = objRow[convPubClassCaseFreeSenate.IdXzCollege] == DBNull.Value ? null : objRow[convPubClassCaseFreeSenate.IdXzCollege].ToString().Trim(), //学院流水号
IsLeaved = TransNullToBool(objRow[convPubClassCaseFreeSenate.IsLeaved].ToString().Trim()), //IsLeaved
StuIdTeacherId = objRow[convPubClassCaseFreeSenate.StuIdTeacherId] == DBNull.Value ? null : objRow[convPubClassCaseFreeSenate.StuIdTeacherId].ToString().Trim(), //学工号
BrowseCount4Case = objRow[convPubClassCaseFreeSenate.BrowseCount4Case] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPubClassCaseFreeSenate.BrowseCount4Case].ToString().Trim()), //课例浏览次数
CollegeNameA = objRow[convPubClassCaseFreeSenate.CollegeNameA] == DBNull.Value ? null : objRow[convPubClassCaseFreeSenate.CollegeNameA].ToString().Trim() //学院名称简写
};
objvPubClassCaseFreeSenateEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvPubClassCaseFreeSenateEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvPubClassCaseFreeSenateDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvPubClassCaseFreeSenateEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvPubClassCaseFreeSenateEN objvPubClassCaseFreeSenateEN = new clsvPubClassCaseFreeSenateEN();
try
{
objvPubClassCaseFreeSenateEN.IdPubClassCaseFreeSenate = TransNullToInt(objRow[convPubClassCaseFreeSenate.IdPubClassCaseFreeSenate].ToString().Trim()); //公开课案例自由评议流水号
objvPubClassCaseFreeSenateEN.IdPubClassCase = objRow[convPubClassCaseFreeSenate.IdPubClassCase].ToString().Trim(); //案例流水号
objvPubClassCaseFreeSenateEN.PubClassCaseID = objRow[convPubClassCaseFreeSenate.PubClassCaseID].ToString().Trim(); //案例ID
objvPubClassCaseFreeSenateEN.PubClassCaseName = objRow[convPubClassCaseFreeSenate.PubClassCaseName].ToString().Trim(); //案例课题名称
objvPubClassCaseFreeSenateEN.PubClassCaseExecutor = objRow[convPubClassCaseFreeSenate.PubClassCaseExecutor] == DBNull.Value ? null : objRow[convPubClassCaseFreeSenate.PubClassCaseExecutor].ToString().Trim(); //案例执教者
objvPubClassCaseFreeSenateEN.PubClassCaseTheme = objRow[convPubClassCaseFreeSenate.PubClassCaseTheme] == DBNull.Value ? null : objRow[convPubClassCaseFreeSenate.PubClassCaseTheme].ToString().Trim(); //案例主题词
objvPubClassCaseFreeSenateEN.UserId = objRow[convPubClassCaseFreeSenate.UserId].ToString().Trim(); //用户ID
objvPubClassCaseFreeSenateEN.UserName = objRow[convPubClassCaseFreeSenate.UserName] == DBNull.Value ? null : objRow[convPubClassCaseFreeSenate.UserName].ToString().Trim(); //用户名
objvPubClassCaseFreeSenateEN.AppraiseTheme = objRow[convPubClassCaseFreeSenate.AppraiseTheme] == DBNull.Value ? null : objRow[convPubClassCaseFreeSenate.AppraiseTheme].ToString().Trim(); //评议主题
objvPubClassCaseFreeSenateEN.PubClassCaseFreeSenateTitle = objRow[convPubClassCaseFreeSenate.PubClassCaseFreeSenateTitle] == DBNull.Value ? null : objRow[convPubClassCaseFreeSenate.PubClassCaseFreeSenateTitle].ToString().Trim(); //公开课案例自由评议标题
objvPubClassCaseFreeSenateEN.PubClassCaseFreeSenateConten = objRow[convPubClassCaseFreeSenate.PubClassCaseFreeSenateConten] == DBNull.Value ? null : objRow[convPubClassCaseFreeSenate.PubClassCaseFreeSenateConten].ToString().Trim(); //公开课案例自由评议内容
objvPubClassCaseFreeSenateEN.PubClassCaseFreeSenateDate = objRow[convPubClassCaseFreeSenate.PubClassCaseFreeSenateDate] == DBNull.Value ? null : objRow[convPubClassCaseFreeSenate.PubClassCaseFreeSenateDate].ToString().Trim(); //公开课案例自由评议日期
objvPubClassCaseFreeSenateEN.PubClassCaseFreeSenateTime = objRow[convPubClassCaseFreeSenate.PubClassCaseFreeSenateTime] == DBNull.Value ? null : objRow[convPubClassCaseFreeSenate.PubClassCaseFreeSenateTime].ToString().Trim(); //公开课案例自由评议时间
objvPubClassCaseFreeSenateEN.BrowseCount = objRow[convPubClassCaseFreeSenate.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPubClassCaseFreeSenate.BrowseCount].ToString().Trim()); //浏览次数
objvPubClassCaseFreeSenateEN.VideoStopTime = objRow[convPubClassCaseFreeSenate.VideoStopTime] == DBNull.Value ? null : objRow[convPubClassCaseFreeSenate.VideoStopTime].ToString().Trim(); //公开课案例视频暂停时间
objvPubClassCaseFreeSenateEN.IsVisible = TransNullToBool(objRow[convPubClassCaseFreeSenate.IsVisible].ToString().Trim()); //是否显示
objvPubClassCaseFreeSenateEN.IdDiscipline = objRow[convPubClassCaseFreeSenate.IdDiscipline].ToString().Trim(); //学科流水号
objvPubClassCaseFreeSenateEN.DisciplineID = objRow[convPubClassCaseFreeSenate.DisciplineID].ToString().Trim(); //学科ID
objvPubClassCaseFreeSenateEN.DisciplineName = objRow[convPubClassCaseFreeSenate.DisciplineName].ToString().Trim(); //学科名称
objvPubClassCaseFreeSenateEN.IdStudyLevel = objRow[convPubClassCaseFreeSenate.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvPubClassCaseFreeSenateEN.StudyLevelName = objRow[convPubClassCaseFreeSenate.StudyLevelName].ToString().Trim(); //学段名称
objvPubClassCaseFreeSenateEN.PubClassCaseTeachDate = objRow[convPubClassCaseFreeSenate.PubClassCaseTeachDate] == DBNull.Value ? null : objRow[convPubClassCaseFreeSenate.PubClassCaseTeachDate].ToString().Trim(); //案例授课日期
objvPubClassCaseFreeSenateEN.PubClassCaseDateIn = objRow[convPubClassCaseFreeSenate.PubClassCaseDateIn] == DBNull.Value ? null : objRow[convPubClassCaseFreeSenate.PubClassCaseDateIn].ToString().Trim(); //案例入库日期
objvPubClassCaseFreeSenateEN.IdTeachingPlan = objRow[convPubClassCaseFreeSenate.IdTeachingPlan].ToString().Trim(); //教案流水号
objvPubClassCaseFreeSenateEN.SubjectName = objRow[convPubClassCaseFreeSenate.SubjectName].ToString().Trim(); //课题名称
objvPubClassCaseFreeSenateEN.IdPubCaseType = objRow[convPubClassCaseFreeSenate.IdPubCaseType].ToString().Trim(); //公开课案例类型流水号
objvPubClassCaseFreeSenateEN.PubCaseTypeID = objRow[convPubClassCaseFreeSenate.PubCaseTypeID].ToString().Trim(); //公开课案例类型ID
objvPubClassCaseFreeSenateEN.PubCaseTypeName = objRow[convPubClassCaseFreeSenate.PubCaseTypeName].ToString().Trim(); //公开课案例类型名称
objvPubClassCaseFreeSenateEN.CollegeID = objRow[convPubClassCaseFreeSenate.CollegeID] == DBNull.Value ? null : objRow[convPubClassCaseFreeSenate.CollegeID].ToString().Trim(); //学院ID
objvPubClassCaseFreeSenateEN.CollegeName = objRow[convPubClassCaseFreeSenate.CollegeName] == DBNull.Value ? null : objRow[convPubClassCaseFreeSenate.CollegeName].ToString().Trim(); //学院名称
objvPubClassCaseFreeSenateEN.IdXzCollege = objRow[convPubClassCaseFreeSenate.IdXzCollege] == DBNull.Value ? null : objRow[convPubClassCaseFreeSenate.IdXzCollege].ToString().Trim(); //学院流水号
objvPubClassCaseFreeSenateEN.IsLeaved = TransNullToBool(objRow[convPubClassCaseFreeSenate.IsLeaved].ToString().Trim()); //IsLeaved
objvPubClassCaseFreeSenateEN.StuIdTeacherId = objRow[convPubClassCaseFreeSenate.StuIdTeacherId] == DBNull.Value ? null : objRow[convPubClassCaseFreeSenate.StuIdTeacherId].ToString().Trim(); //学工号
objvPubClassCaseFreeSenateEN.BrowseCount4Case = objRow[convPubClassCaseFreeSenate.BrowseCount4Case] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPubClassCaseFreeSenate.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvPubClassCaseFreeSenateEN.CollegeNameA = objRow[convPubClassCaseFreeSenate.CollegeNameA] == DBNull.Value ? null : objRow[convPubClassCaseFreeSenate.CollegeNameA].ToString().Trim(); //学院名称简写
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvPubClassCaseFreeSenateDA: GetObjByDataRowvPubClassCaseFreeSenate)", objException.Message));
}
objvPubClassCaseFreeSenateEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvPubClassCaseFreeSenateEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvPubClassCaseFreeSenateEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvPubClassCaseFreeSenateEN objvPubClassCaseFreeSenateEN = new clsvPubClassCaseFreeSenateEN();
try
{
objvPubClassCaseFreeSenateEN.IdPubClassCaseFreeSenate = TransNullToInt(objRow[convPubClassCaseFreeSenate.IdPubClassCaseFreeSenate].ToString().Trim()); //公开课案例自由评议流水号
objvPubClassCaseFreeSenateEN.IdPubClassCase = objRow[convPubClassCaseFreeSenate.IdPubClassCase].ToString().Trim(); //案例流水号
objvPubClassCaseFreeSenateEN.PubClassCaseID = objRow[convPubClassCaseFreeSenate.PubClassCaseID].ToString().Trim(); //案例ID
objvPubClassCaseFreeSenateEN.PubClassCaseName = objRow[convPubClassCaseFreeSenate.PubClassCaseName].ToString().Trim(); //案例课题名称
objvPubClassCaseFreeSenateEN.PubClassCaseExecutor = objRow[convPubClassCaseFreeSenate.PubClassCaseExecutor] == DBNull.Value ? null : objRow[convPubClassCaseFreeSenate.PubClassCaseExecutor].ToString().Trim(); //案例执教者
objvPubClassCaseFreeSenateEN.PubClassCaseTheme = objRow[convPubClassCaseFreeSenate.PubClassCaseTheme] == DBNull.Value ? null : objRow[convPubClassCaseFreeSenate.PubClassCaseTheme].ToString().Trim(); //案例主题词
objvPubClassCaseFreeSenateEN.UserId = objRow[convPubClassCaseFreeSenate.UserId].ToString().Trim(); //用户ID
objvPubClassCaseFreeSenateEN.UserName = objRow[convPubClassCaseFreeSenate.UserName] == DBNull.Value ? null : objRow[convPubClassCaseFreeSenate.UserName].ToString().Trim(); //用户名
objvPubClassCaseFreeSenateEN.AppraiseTheme = objRow[convPubClassCaseFreeSenate.AppraiseTheme] == DBNull.Value ? null : objRow[convPubClassCaseFreeSenate.AppraiseTheme].ToString().Trim(); //评议主题
objvPubClassCaseFreeSenateEN.PubClassCaseFreeSenateTitle = objRow[convPubClassCaseFreeSenate.PubClassCaseFreeSenateTitle] == DBNull.Value ? null : objRow[convPubClassCaseFreeSenate.PubClassCaseFreeSenateTitle].ToString().Trim(); //公开课案例自由评议标题
objvPubClassCaseFreeSenateEN.PubClassCaseFreeSenateConten = objRow[convPubClassCaseFreeSenate.PubClassCaseFreeSenateConten] == DBNull.Value ? null : objRow[convPubClassCaseFreeSenate.PubClassCaseFreeSenateConten].ToString().Trim(); //公开课案例自由评议内容
objvPubClassCaseFreeSenateEN.PubClassCaseFreeSenateDate = objRow[convPubClassCaseFreeSenate.PubClassCaseFreeSenateDate] == DBNull.Value ? null : objRow[convPubClassCaseFreeSenate.PubClassCaseFreeSenateDate].ToString().Trim(); //公开课案例自由评议日期
objvPubClassCaseFreeSenateEN.PubClassCaseFreeSenateTime = objRow[convPubClassCaseFreeSenate.PubClassCaseFreeSenateTime] == DBNull.Value ? null : objRow[convPubClassCaseFreeSenate.PubClassCaseFreeSenateTime].ToString().Trim(); //公开课案例自由评议时间
objvPubClassCaseFreeSenateEN.BrowseCount = objRow[convPubClassCaseFreeSenate.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPubClassCaseFreeSenate.BrowseCount].ToString().Trim()); //浏览次数
objvPubClassCaseFreeSenateEN.VideoStopTime = objRow[convPubClassCaseFreeSenate.VideoStopTime] == DBNull.Value ? null : objRow[convPubClassCaseFreeSenate.VideoStopTime].ToString().Trim(); //公开课案例视频暂停时间
objvPubClassCaseFreeSenateEN.IsVisible = TransNullToBool(objRow[convPubClassCaseFreeSenate.IsVisible].ToString().Trim()); //是否显示
objvPubClassCaseFreeSenateEN.IdDiscipline = objRow[convPubClassCaseFreeSenate.IdDiscipline].ToString().Trim(); //学科流水号
objvPubClassCaseFreeSenateEN.DisciplineID = objRow[convPubClassCaseFreeSenate.DisciplineID].ToString().Trim(); //学科ID
objvPubClassCaseFreeSenateEN.DisciplineName = objRow[convPubClassCaseFreeSenate.DisciplineName].ToString().Trim(); //学科名称
objvPubClassCaseFreeSenateEN.IdStudyLevel = objRow[convPubClassCaseFreeSenate.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvPubClassCaseFreeSenateEN.StudyLevelName = objRow[convPubClassCaseFreeSenate.StudyLevelName].ToString().Trim(); //学段名称
objvPubClassCaseFreeSenateEN.PubClassCaseTeachDate = objRow[convPubClassCaseFreeSenate.PubClassCaseTeachDate] == DBNull.Value ? null : objRow[convPubClassCaseFreeSenate.PubClassCaseTeachDate].ToString().Trim(); //案例授课日期
objvPubClassCaseFreeSenateEN.PubClassCaseDateIn = objRow[convPubClassCaseFreeSenate.PubClassCaseDateIn] == DBNull.Value ? null : objRow[convPubClassCaseFreeSenate.PubClassCaseDateIn].ToString().Trim(); //案例入库日期
objvPubClassCaseFreeSenateEN.IdTeachingPlan = objRow[convPubClassCaseFreeSenate.IdTeachingPlan].ToString().Trim(); //教案流水号
objvPubClassCaseFreeSenateEN.SubjectName = objRow[convPubClassCaseFreeSenate.SubjectName].ToString().Trim(); //课题名称
objvPubClassCaseFreeSenateEN.IdPubCaseType = objRow[convPubClassCaseFreeSenate.IdPubCaseType].ToString().Trim(); //公开课案例类型流水号
objvPubClassCaseFreeSenateEN.PubCaseTypeID = objRow[convPubClassCaseFreeSenate.PubCaseTypeID].ToString().Trim(); //公开课案例类型ID
objvPubClassCaseFreeSenateEN.PubCaseTypeName = objRow[convPubClassCaseFreeSenate.PubCaseTypeName].ToString().Trim(); //公开课案例类型名称
objvPubClassCaseFreeSenateEN.CollegeID = objRow[convPubClassCaseFreeSenate.CollegeID] == DBNull.Value ? null : objRow[convPubClassCaseFreeSenate.CollegeID].ToString().Trim(); //学院ID
objvPubClassCaseFreeSenateEN.CollegeName = objRow[convPubClassCaseFreeSenate.CollegeName] == DBNull.Value ? null : objRow[convPubClassCaseFreeSenate.CollegeName].ToString().Trim(); //学院名称
objvPubClassCaseFreeSenateEN.IdXzCollege = objRow[convPubClassCaseFreeSenate.IdXzCollege] == DBNull.Value ? null : objRow[convPubClassCaseFreeSenate.IdXzCollege].ToString().Trim(); //学院流水号
objvPubClassCaseFreeSenateEN.IsLeaved = TransNullToBool(objRow[convPubClassCaseFreeSenate.IsLeaved].ToString().Trim()); //IsLeaved
objvPubClassCaseFreeSenateEN.StuIdTeacherId = objRow[convPubClassCaseFreeSenate.StuIdTeacherId] == DBNull.Value ? null : objRow[convPubClassCaseFreeSenate.StuIdTeacherId].ToString().Trim(); //学工号
objvPubClassCaseFreeSenateEN.BrowseCount4Case = objRow[convPubClassCaseFreeSenate.BrowseCount4Case] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPubClassCaseFreeSenate.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvPubClassCaseFreeSenateEN.CollegeNameA = objRow[convPubClassCaseFreeSenate.CollegeNameA] == DBNull.Value ? null : objRow[convPubClassCaseFreeSenate.CollegeNameA].ToString().Trim(); //学院名称简写
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvPubClassCaseFreeSenateDA: GetObjByDataRow)", objException.Message));
}
objvPubClassCaseFreeSenateEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvPubClassCaseFreeSenateEN;
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
objSQL = clsvPubClassCaseFreeSenateDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvPubClassCaseFreeSenateEN._CurrTabName, convPubClassCaseFreeSenate.IdPubClassCaseFreeSenate, 8, "");
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
objSQL = clsvPubClassCaseFreeSenateDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvPubClassCaseFreeSenateEN._CurrTabName, convPubClassCaseFreeSenate.IdPubClassCaseFreeSenate, 8, strPrefix);
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
 objSQL = clsvPubClassCaseFreeSenateDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select IdPubClassCaseFreeSenate from vPubClassCaseFreeSenate where " + strCondition;
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
 objSQL = clsvPubClassCaseFreeSenateDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select IdPubClassCaseFreeSenate from vPubClassCaseFreeSenate where " + strCondition;
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
 /// <param name = "lngIdPubClassCaseFreeSenate">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(long lngIdPubClassCaseFreeSenate)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPubClassCaseFreeSenateDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vPubClassCaseFreeSenate", "IdPubClassCaseFreeSenate = " + ""+ lngIdPubClassCaseFreeSenate+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvPubClassCaseFreeSenateDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPubClassCaseFreeSenateDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vPubClassCaseFreeSenate", strCondition))
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
objSQL = clsvPubClassCaseFreeSenateDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vPubClassCaseFreeSenate");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvPubClassCaseFreeSenateENS">源对象</param>
 /// <param name = "objvPubClassCaseFreeSenateENT">目标对象</param>
public void CopyTo(clsvPubClassCaseFreeSenateEN objvPubClassCaseFreeSenateENS, clsvPubClassCaseFreeSenateEN objvPubClassCaseFreeSenateENT)
{
objvPubClassCaseFreeSenateENT.IdPubClassCaseFreeSenate = objvPubClassCaseFreeSenateENS.IdPubClassCaseFreeSenate; //公开课案例自由评议流水号
objvPubClassCaseFreeSenateENT.IdPubClassCase = objvPubClassCaseFreeSenateENS.IdPubClassCase; //案例流水号
objvPubClassCaseFreeSenateENT.PubClassCaseID = objvPubClassCaseFreeSenateENS.PubClassCaseID; //案例ID
objvPubClassCaseFreeSenateENT.PubClassCaseName = objvPubClassCaseFreeSenateENS.PubClassCaseName; //案例课题名称
objvPubClassCaseFreeSenateENT.PubClassCaseExecutor = objvPubClassCaseFreeSenateENS.PubClassCaseExecutor; //案例执教者
objvPubClassCaseFreeSenateENT.PubClassCaseTheme = objvPubClassCaseFreeSenateENS.PubClassCaseTheme; //案例主题词
objvPubClassCaseFreeSenateENT.UserId = objvPubClassCaseFreeSenateENS.UserId; //用户ID
objvPubClassCaseFreeSenateENT.UserName = objvPubClassCaseFreeSenateENS.UserName; //用户名
objvPubClassCaseFreeSenateENT.AppraiseTheme = objvPubClassCaseFreeSenateENS.AppraiseTheme; //评议主题
objvPubClassCaseFreeSenateENT.PubClassCaseFreeSenateTitle = objvPubClassCaseFreeSenateENS.PubClassCaseFreeSenateTitle; //公开课案例自由评议标题
objvPubClassCaseFreeSenateENT.PubClassCaseFreeSenateConten = objvPubClassCaseFreeSenateENS.PubClassCaseFreeSenateConten; //公开课案例自由评议内容
objvPubClassCaseFreeSenateENT.PubClassCaseFreeSenateDate = objvPubClassCaseFreeSenateENS.PubClassCaseFreeSenateDate; //公开课案例自由评议日期
objvPubClassCaseFreeSenateENT.PubClassCaseFreeSenateTime = objvPubClassCaseFreeSenateENS.PubClassCaseFreeSenateTime; //公开课案例自由评议时间
objvPubClassCaseFreeSenateENT.BrowseCount = objvPubClassCaseFreeSenateENS.BrowseCount; //浏览次数
objvPubClassCaseFreeSenateENT.VideoStopTime = objvPubClassCaseFreeSenateENS.VideoStopTime; //公开课案例视频暂停时间
objvPubClassCaseFreeSenateENT.IsVisible = objvPubClassCaseFreeSenateENS.IsVisible; //是否显示
objvPubClassCaseFreeSenateENT.IdDiscipline = objvPubClassCaseFreeSenateENS.IdDiscipline; //学科流水号
objvPubClassCaseFreeSenateENT.DisciplineID = objvPubClassCaseFreeSenateENS.DisciplineID; //学科ID
objvPubClassCaseFreeSenateENT.DisciplineName = objvPubClassCaseFreeSenateENS.DisciplineName; //学科名称
objvPubClassCaseFreeSenateENT.IdStudyLevel = objvPubClassCaseFreeSenateENS.IdStudyLevel; //id_StudyLevel
objvPubClassCaseFreeSenateENT.StudyLevelName = objvPubClassCaseFreeSenateENS.StudyLevelName; //学段名称
objvPubClassCaseFreeSenateENT.PubClassCaseTeachDate = objvPubClassCaseFreeSenateENS.PubClassCaseTeachDate; //案例授课日期
objvPubClassCaseFreeSenateENT.PubClassCaseDateIn = objvPubClassCaseFreeSenateENS.PubClassCaseDateIn; //案例入库日期
objvPubClassCaseFreeSenateENT.IdTeachingPlan = objvPubClassCaseFreeSenateENS.IdTeachingPlan; //教案流水号
objvPubClassCaseFreeSenateENT.SubjectName = objvPubClassCaseFreeSenateENS.SubjectName; //课题名称
objvPubClassCaseFreeSenateENT.IdPubCaseType = objvPubClassCaseFreeSenateENS.IdPubCaseType; //公开课案例类型流水号
objvPubClassCaseFreeSenateENT.PubCaseTypeID = objvPubClassCaseFreeSenateENS.PubCaseTypeID; //公开课案例类型ID
objvPubClassCaseFreeSenateENT.PubCaseTypeName = objvPubClassCaseFreeSenateENS.PubCaseTypeName; //公开课案例类型名称
objvPubClassCaseFreeSenateENT.CollegeID = objvPubClassCaseFreeSenateENS.CollegeID; //学院ID
objvPubClassCaseFreeSenateENT.CollegeName = objvPubClassCaseFreeSenateENS.CollegeName; //学院名称
objvPubClassCaseFreeSenateENT.IdXzCollege = objvPubClassCaseFreeSenateENS.IdXzCollege; //学院流水号
objvPubClassCaseFreeSenateENT.IsLeaved = objvPubClassCaseFreeSenateENS.IsLeaved; //IsLeaved
objvPubClassCaseFreeSenateENT.StuIdTeacherId = objvPubClassCaseFreeSenateENS.StuIdTeacherId; //学工号
objvPubClassCaseFreeSenateENT.BrowseCount4Case = objvPubClassCaseFreeSenateENS.BrowseCount4Case; //课例浏览次数
objvPubClassCaseFreeSenateENT.CollegeNameA = objvPubClassCaseFreeSenateENS.CollegeNameA; //学院名称简写
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvPubClassCaseFreeSenateEN objvPubClassCaseFreeSenateEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvPubClassCaseFreeSenateEN.IdPubClassCase, 8, convPubClassCaseFreeSenate.IdPubClassCase);
clsCheckSql.CheckFieldLen(objvPubClassCaseFreeSenateEN.PubClassCaseID, 8, convPubClassCaseFreeSenate.PubClassCaseID);
clsCheckSql.CheckFieldLen(objvPubClassCaseFreeSenateEN.PubClassCaseName, 200, convPubClassCaseFreeSenate.PubClassCaseName);
clsCheckSql.CheckFieldLen(objvPubClassCaseFreeSenateEN.PubClassCaseExecutor, 50, convPubClassCaseFreeSenate.PubClassCaseExecutor);
clsCheckSql.CheckFieldLen(objvPubClassCaseFreeSenateEN.PubClassCaseTheme, 500, convPubClassCaseFreeSenate.PubClassCaseTheme);
clsCheckSql.CheckFieldLen(objvPubClassCaseFreeSenateEN.UserId, 18, convPubClassCaseFreeSenate.UserId);
clsCheckSql.CheckFieldLen(objvPubClassCaseFreeSenateEN.UserName, 30, convPubClassCaseFreeSenate.UserName);
clsCheckSql.CheckFieldLen(objvPubClassCaseFreeSenateEN.AppraiseTheme, 200, convPubClassCaseFreeSenate.AppraiseTheme);
clsCheckSql.CheckFieldLen(objvPubClassCaseFreeSenateEN.PubClassCaseFreeSenateTitle, 200, convPubClassCaseFreeSenate.PubClassCaseFreeSenateTitle);
clsCheckSql.CheckFieldLen(objvPubClassCaseFreeSenateEN.PubClassCaseFreeSenateConten, 2000, convPubClassCaseFreeSenate.PubClassCaseFreeSenateConten);
clsCheckSql.CheckFieldLen(objvPubClassCaseFreeSenateEN.PubClassCaseFreeSenateDate, 8, convPubClassCaseFreeSenate.PubClassCaseFreeSenateDate);
clsCheckSql.CheckFieldLen(objvPubClassCaseFreeSenateEN.PubClassCaseFreeSenateTime, 6, convPubClassCaseFreeSenate.PubClassCaseFreeSenateTime);
clsCheckSql.CheckFieldLen(objvPubClassCaseFreeSenateEN.VideoStopTime, 48, convPubClassCaseFreeSenate.VideoStopTime);
clsCheckSql.CheckFieldLen(objvPubClassCaseFreeSenateEN.IdDiscipline, 4, convPubClassCaseFreeSenate.IdDiscipline);
clsCheckSql.CheckFieldLen(objvPubClassCaseFreeSenateEN.DisciplineID, 4, convPubClassCaseFreeSenate.DisciplineID);
clsCheckSql.CheckFieldLen(objvPubClassCaseFreeSenateEN.DisciplineName, 50, convPubClassCaseFreeSenate.DisciplineName);
clsCheckSql.CheckFieldLen(objvPubClassCaseFreeSenateEN.IdStudyLevel, 4, convPubClassCaseFreeSenate.IdStudyLevel);
clsCheckSql.CheckFieldLen(objvPubClassCaseFreeSenateEN.StudyLevelName, 50, convPubClassCaseFreeSenate.StudyLevelName);
clsCheckSql.CheckFieldLen(objvPubClassCaseFreeSenateEN.PubClassCaseTeachDate, 8, convPubClassCaseFreeSenate.PubClassCaseTeachDate);
clsCheckSql.CheckFieldLen(objvPubClassCaseFreeSenateEN.PubClassCaseDateIn, 8, convPubClassCaseFreeSenate.PubClassCaseDateIn);
clsCheckSql.CheckFieldLen(objvPubClassCaseFreeSenateEN.IdTeachingPlan, 8, convPubClassCaseFreeSenate.IdTeachingPlan);
clsCheckSql.CheckFieldLen(objvPubClassCaseFreeSenateEN.SubjectName, 200, convPubClassCaseFreeSenate.SubjectName);
clsCheckSql.CheckFieldLen(objvPubClassCaseFreeSenateEN.IdPubCaseType, 4, convPubClassCaseFreeSenate.IdPubCaseType);
clsCheckSql.CheckFieldLen(objvPubClassCaseFreeSenateEN.PubCaseTypeID, 4, convPubClassCaseFreeSenate.PubCaseTypeID);
clsCheckSql.CheckFieldLen(objvPubClassCaseFreeSenateEN.PubCaseTypeName, 50, convPubClassCaseFreeSenate.PubCaseTypeName);
clsCheckSql.CheckFieldLen(objvPubClassCaseFreeSenateEN.CollegeID, 4, convPubClassCaseFreeSenate.CollegeID);
clsCheckSql.CheckFieldLen(objvPubClassCaseFreeSenateEN.CollegeName, 100, convPubClassCaseFreeSenate.CollegeName);
clsCheckSql.CheckFieldLen(objvPubClassCaseFreeSenateEN.IdXzCollege, 4, convPubClassCaseFreeSenate.IdXzCollege);
clsCheckSql.CheckFieldLen(objvPubClassCaseFreeSenateEN.StuIdTeacherId, 20, convPubClassCaseFreeSenate.StuIdTeacherId);
clsCheckSql.CheckFieldLen(objvPubClassCaseFreeSenateEN.CollegeNameA, 12, convPubClassCaseFreeSenate.CollegeNameA);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvPubClassCaseFreeSenateEN.IdPubClassCase, convPubClassCaseFreeSenate.IdPubClassCase);
clsCheckSql.CheckSqlInjection4Field(objvPubClassCaseFreeSenateEN.PubClassCaseID, convPubClassCaseFreeSenate.PubClassCaseID);
clsCheckSql.CheckSqlInjection4Field(objvPubClassCaseFreeSenateEN.PubClassCaseName, convPubClassCaseFreeSenate.PubClassCaseName);
clsCheckSql.CheckSqlInjection4Field(objvPubClassCaseFreeSenateEN.PubClassCaseExecutor, convPubClassCaseFreeSenate.PubClassCaseExecutor);
clsCheckSql.CheckSqlInjection4Field(objvPubClassCaseFreeSenateEN.PubClassCaseTheme, convPubClassCaseFreeSenate.PubClassCaseTheme);
clsCheckSql.CheckSqlInjection4Field(objvPubClassCaseFreeSenateEN.UserId, convPubClassCaseFreeSenate.UserId);
clsCheckSql.CheckSqlInjection4Field(objvPubClassCaseFreeSenateEN.UserName, convPubClassCaseFreeSenate.UserName);
clsCheckSql.CheckSqlInjection4Field(objvPubClassCaseFreeSenateEN.AppraiseTheme, convPubClassCaseFreeSenate.AppraiseTheme);
clsCheckSql.CheckSqlInjection4Field(objvPubClassCaseFreeSenateEN.PubClassCaseFreeSenateTitle, convPubClassCaseFreeSenate.PubClassCaseFreeSenateTitle);
clsCheckSql.CheckSqlInjection4Field(objvPubClassCaseFreeSenateEN.PubClassCaseFreeSenateConten, convPubClassCaseFreeSenate.PubClassCaseFreeSenateConten);
clsCheckSql.CheckSqlInjection4Field(objvPubClassCaseFreeSenateEN.PubClassCaseFreeSenateDate, convPubClassCaseFreeSenate.PubClassCaseFreeSenateDate);
clsCheckSql.CheckSqlInjection4Field(objvPubClassCaseFreeSenateEN.PubClassCaseFreeSenateTime, convPubClassCaseFreeSenate.PubClassCaseFreeSenateTime);
clsCheckSql.CheckSqlInjection4Field(objvPubClassCaseFreeSenateEN.VideoStopTime, convPubClassCaseFreeSenate.VideoStopTime);
clsCheckSql.CheckSqlInjection4Field(objvPubClassCaseFreeSenateEN.IdDiscipline, convPubClassCaseFreeSenate.IdDiscipline);
clsCheckSql.CheckSqlInjection4Field(objvPubClassCaseFreeSenateEN.DisciplineID, convPubClassCaseFreeSenate.DisciplineID);
clsCheckSql.CheckSqlInjection4Field(objvPubClassCaseFreeSenateEN.DisciplineName, convPubClassCaseFreeSenate.DisciplineName);
clsCheckSql.CheckSqlInjection4Field(objvPubClassCaseFreeSenateEN.IdStudyLevel, convPubClassCaseFreeSenate.IdStudyLevel);
clsCheckSql.CheckSqlInjection4Field(objvPubClassCaseFreeSenateEN.StudyLevelName, convPubClassCaseFreeSenate.StudyLevelName);
clsCheckSql.CheckSqlInjection4Field(objvPubClassCaseFreeSenateEN.PubClassCaseTeachDate, convPubClassCaseFreeSenate.PubClassCaseTeachDate);
clsCheckSql.CheckSqlInjection4Field(objvPubClassCaseFreeSenateEN.PubClassCaseDateIn, convPubClassCaseFreeSenate.PubClassCaseDateIn);
clsCheckSql.CheckSqlInjection4Field(objvPubClassCaseFreeSenateEN.IdTeachingPlan, convPubClassCaseFreeSenate.IdTeachingPlan);
clsCheckSql.CheckSqlInjection4Field(objvPubClassCaseFreeSenateEN.SubjectName, convPubClassCaseFreeSenate.SubjectName);
clsCheckSql.CheckSqlInjection4Field(objvPubClassCaseFreeSenateEN.IdPubCaseType, convPubClassCaseFreeSenate.IdPubCaseType);
clsCheckSql.CheckSqlInjection4Field(objvPubClassCaseFreeSenateEN.PubCaseTypeID, convPubClassCaseFreeSenate.PubCaseTypeID);
clsCheckSql.CheckSqlInjection4Field(objvPubClassCaseFreeSenateEN.PubCaseTypeName, convPubClassCaseFreeSenate.PubCaseTypeName);
clsCheckSql.CheckSqlInjection4Field(objvPubClassCaseFreeSenateEN.CollegeID, convPubClassCaseFreeSenate.CollegeID);
clsCheckSql.CheckSqlInjection4Field(objvPubClassCaseFreeSenateEN.CollegeName, convPubClassCaseFreeSenate.CollegeName);
clsCheckSql.CheckSqlInjection4Field(objvPubClassCaseFreeSenateEN.IdXzCollege, convPubClassCaseFreeSenate.IdXzCollege);
clsCheckSql.CheckSqlInjection4Field(objvPubClassCaseFreeSenateEN.StuIdTeacherId, convPubClassCaseFreeSenate.StuIdTeacherId);
clsCheckSql.CheckSqlInjection4Field(objvPubClassCaseFreeSenateEN.CollegeNameA, convPubClassCaseFreeSenate.CollegeNameA);
//检查外键字段长度
 objvPubClassCaseFreeSenateEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 #endregion 绑定下拉框

 #region 检查唯一性

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
 objSQL = clsvPubClassCaseFreeSenateDA.GetSpecSQLObj();
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
 objSQL = clsvPubClassCaseFreeSenateDA.GetSpecSQLObj();
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
 objSQL = clsvPubClassCaseFreeSenateDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvPubClassCaseFreeSenateEN._CurrTabName);
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
 objSQL = clsvPubClassCaseFreeSenateDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvPubClassCaseFreeSenateEN._CurrTabName, strCondition);
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
 objSQL = clsvPubClassCaseFreeSenateDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}