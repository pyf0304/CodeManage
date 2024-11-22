
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvPubClassCaseSenateDA
 表名:vPubClassCaseSenate(01120410)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:48:47
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
 /// v公开课案例评议(vPubClassCaseSenate)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvPubClassCaseSenateDA : clsCommBase4DA
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
 return clsvPubClassCaseSenateEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvPubClassCaseSenateEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvPubClassCaseSenateEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvPubClassCaseSenateEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvPubClassCaseSenateEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvPubClassCaseSenateDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPubClassCaseSenateDA.GetSpecSQLObj();
strSQL = "Select * from vPubClassCaseSenate where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vPubClassCaseSenate(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvPubClassCaseSenateDA: GetDataTable_vPubClassCaseSenate)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPubClassCaseSenateDA.GetSpecSQLObj();
strSQL = "Select * from vPubClassCaseSenate where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvPubClassCaseSenateDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPubClassCaseSenateDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvPubClassCaseSenateDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPubClassCaseSenateDA.GetSpecSQLObj();
strSQL = "Select * from vPubClassCaseSenate where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvPubClassCaseSenateDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPubClassCaseSenateDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvPubClassCaseSenateDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPubClassCaseSenateDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vPubClassCaseSenate where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vPubClassCaseSenate where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvPubClassCaseSenateDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPubClassCaseSenateDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vPubClassCaseSenate where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvPubClassCaseSenateDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPubClassCaseSenateDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vPubClassCaseSenate.* from vPubClassCaseSenate Left Join {1} on {2} where {3} and vPubClassCaseSenate.IdPubClassCaseSenate not in (Select top {5} vPubClassCaseSenate.IdPubClassCaseSenate from vPubClassCaseSenate Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vPubClassCaseSenate where {1} and IdPubClassCaseSenate not in (Select top {2} IdPubClassCaseSenate from vPubClassCaseSenate where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vPubClassCaseSenate where {1} and IdPubClassCaseSenate not in (Select top {3} IdPubClassCaseSenate from vPubClassCaseSenate where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvPubClassCaseSenateDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPubClassCaseSenateDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vPubClassCaseSenate.* from vPubClassCaseSenate Left Join {1} on {2} where {3} and vPubClassCaseSenate.IdPubClassCaseSenate not in (Select top {5} vPubClassCaseSenate.IdPubClassCaseSenate from vPubClassCaseSenate Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vPubClassCaseSenate where {1} and IdPubClassCaseSenate not in (Select top {2} IdPubClassCaseSenate from vPubClassCaseSenate where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vPubClassCaseSenate where {1} and IdPubClassCaseSenate not in (Select top {3} IdPubClassCaseSenate from vPubClassCaseSenate where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvPubClassCaseSenateEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvPubClassCaseSenateDA:GetObjLst)", objException.Message));
}
List<clsvPubClassCaseSenateEN> arrObjLst = new List<clsvPubClassCaseSenateEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPubClassCaseSenateDA.GetSpecSQLObj();
strSQL = "Select * from vPubClassCaseSenate where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPubClassCaseSenateEN objvPubClassCaseSenateEN = new clsvPubClassCaseSenateEN();
try
{
objvPubClassCaseSenateEN.IdPubClassCaseSenate = TransNullToInt(objRow[convPubClassCaseSenate.IdPubClassCaseSenate].ToString().Trim()); //公开课案例评议流水号
objvPubClassCaseSenateEN.IdPubClassCase = objRow[convPubClassCaseSenate.IdPubClassCase].ToString().Trim(); //案例流水号
objvPubClassCaseSenateEN.PubClassCaseID = objRow[convPubClassCaseSenate.PubClassCaseID].ToString().Trim(); //案例ID
objvPubClassCaseSenateEN.PubClassCaseName = objRow[convPubClassCaseSenate.PubClassCaseName].ToString().Trim(); //案例课题名称
objvPubClassCaseSenateEN.PubClassCaseDateIn = objRow[convPubClassCaseSenate.PubClassCaseDateIn] == DBNull.Value ? null : objRow[convPubClassCaseSenate.PubClassCaseDateIn].ToString().Trim(); //案例入库日期
objvPubClassCaseSenateEN.PubClassCaseTeachDate = objRow[convPubClassCaseSenate.PubClassCaseTeachDate] == DBNull.Value ? null : objRow[convPubClassCaseSenate.PubClassCaseTeachDate].ToString().Trim(); //案例授课日期
objvPubClassCaseSenateEN.PubClassCaseBG = objRow[convPubClassCaseSenate.PubClassCaseBG] == DBNull.Value ? null : objRow[convPubClassCaseSenate.PubClassCaseBG].ToString().Trim(); //案例背景资料
objvPubClassCaseSenateEN.PubClassCaseTheme = objRow[convPubClassCaseSenate.PubClassCaseTheme] == DBNull.Value ? null : objRow[convPubClassCaseSenate.PubClassCaseTheme].ToString().Trim(); //案例主题词
objvPubClassCaseSenateEN.PubClassCaseExecutor = objRow[convPubClassCaseSenate.PubClassCaseExecutor] == DBNull.Value ? null : objRow[convPubClassCaseSenate.PubClassCaseExecutor].ToString().Trim(); //案例执教者
objvPubClassCaseSenateEN.DisciplineID = objRow[convPubClassCaseSenate.DisciplineID] == DBNull.Value ? null : objRow[convPubClassCaseSenate.DisciplineID].ToString().Trim(); //学科ID
objvPubClassCaseSenateEN.DisciplineName = objRow[convPubClassCaseSenate.DisciplineName] == DBNull.Value ? null : objRow[convPubClassCaseSenate.DisciplineName].ToString().Trim(); //学科名称
objvPubClassCaseSenateEN.StudyLevelName = objRow[convPubClassCaseSenate.StudyLevelName] == DBNull.Value ? null : objRow[convPubClassCaseSenate.StudyLevelName].ToString().Trim(); //学段名称
objvPubClassCaseSenateEN.IsElite = TransNullToBool(objRow[convPubClassCaseSenate.IsElite].ToString().Trim()); //精华标志
objvPubClassCaseSenateEN.SubjectName = objRow[convPubClassCaseSenate.SubjectName].ToString().Trim(); //课题名称
objvPubClassCaseSenateEN.ResourceID = objRow[convPubClassCaseSenate.ResourceID].ToString().Trim(); //资源ID
objvPubClassCaseSenateEN.ResourceTypeID = objRow[convPubClassCaseSenate.ResourceTypeID].ToString().Trim(); //资源类型ID
objvPubClassCaseSenateEN.ResourceTypeName = objRow[convPubClassCaseSenate.ResourceTypeName].ToString().Trim(); //资源类型名称
objvPubClassCaseSenateEN.PubCaseTypeID = objRow[convPubClassCaseSenate.PubCaseTypeID].ToString().Trim(); //公开课案例类型ID
objvPubClassCaseSenateEN.PubCaseTypeName = objRow[convPubClassCaseSenate.PubCaseTypeName].ToString().Trim(); //公开课案例类型名称
objvPubClassCaseSenateEN.PubClassCaseSenateClassID = objRow[convPubClassCaseSenate.PubClassCaseSenateClassID] == DBNull.Value ? null : objRow[convPubClassCaseSenate.PubClassCaseSenateClassID].ToString().Trim(); //公开课案例评议类别ID
objvPubClassCaseSenateEN.PubClassCaseSenateClassName = objRow[convPubClassCaseSenate.PubClassCaseSenateClassName] == DBNull.Value ? null : objRow[convPubClassCaseSenate.PubClassCaseSenateClassName].ToString().Trim(); //公开课案例评议类别名称
objvPubClassCaseSenateEN.PubClassCaseSenator = objRow[convPubClassCaseSenate.PubClassCaseSenator] == DBNull.Value ? null : objRow[convPubClassCaseSenate.PubClassCaseSenator].ToString().Trim(); //公开课案例评议者
objvPubClassCaseSenateEN.PubClassCaseSenateTitle = objRow[convPubClassCaseSenate.PubClassCaseSenateTitle] == DBNull.Value ? null : objRow[convPubClassCaseSenate.PubClassCaseSenateTitle].ToString().Trim(); //公开课案例评议标题
objvPubClassCaseSenateEN.PubClassCaseSenateContent = objRow[convPubClassCaseSenate.PubClassCaseSenateContent] == DBNull.Value ? null : objRow[convPubClassCaseSenate.PubClassCaseSenateContent].ToString().Trim(); //公开课案例评议内容
objvPubClassCaseSenateEN.PubClassCaseSenateDate = objRow[convPubClassCaseSenate.PubClassCaseSenateDate] == DBNull.Value ? null : objRow[convPubClassCaseSenate.PubClassCaseSenateDate].ToString().Trim(); //公开课案例评议日期
objvPubClassCaseSenateEN.PubClassCaseSenateTime = objRow[convPubClassCaseSenate.PubClassCaseSenateTime] == DBNull.Value ? null : objRow[convPubClassCaseSenate.PubClassCaseSenateTime].ToString().Trim(); //公开课案例评议时间
objvPubClassCaseSenateEN.SenateReadCount = objRow[convPubClassCaseSenate.SenateReadCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPubClassCaseSenate.SenateReadCount].ToString().Trim()); //评议阅读次数
objvPubClassCaseSenateEN.ResourceOwner = objRow[convPubClassCaseSenate.ResourceOwner].ToString().Trim(); //上传者
objvPubClassCaseSenateEN.ftpResourceOwner = objRow[convPubClassCaseSenate.ftpResourceOwner] == DBNull.Value ? null : objRow[convPubClassCaseSenate.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvPubClassCaseSenateEN.FileNewName = objRow[convPubClassCaseSenate.FileNewName] == DBNull.Value ? null : objRow[convPubClassCaseSenate.FileNewName].ToString().Trim(); //新文件名
objvPubClassCaseSenateEN.FileOldName = objRow[convPubClassCaseSenate.FileOldName] == DBNull.Value ? null : objRow[convPubClassCaseSenate.FileOldName].ToString().Trim(); //旧文件名
objvPubClassCaseSenateEN.FileSize = objRow[convPubClassCaseSenate.FileSize] == DBNull.Value ? null : objRow[convPubClassCaseSenate.FileSize].ToString().Trim(); //文件大小
objvPubClassCaseSenateEN.FileType = objRow[convPubClassCaseSenate.FileType] == DBNull.Value ? null : objRow[convPubClassCaseSenate.FileType].ToString().Trim(); //文件类型
objvPubClassCaseSenateEN.FileName = objRow[convPubClassCaseSenate.FileName] == DBNull.Value ? null : objRow[convPubClassCaseSenate.FileName].ToString().Trim(); //文件名称
objvPubClassCaseSenateEN.SaveTime = objRow[convPubClassCaseSenate.SaveTime] == DBNull.Value ? null : objRow[convPubClassCaseSenate.SaveTime].ToString().Trim(); //创建时间
objvPubClassCaseSenateEN.IsVisual = TransNullToBool(objRow[convPubClassCaseSenate.IsVisual].ToString().Trim()); //隐藏标志
objvPubClassCaseSenateEN.IdTeachingPlan = objRow[convPubClassCaseSenate.IdTeachingPlan].ToString().Trim(); //教案流水号
objvPubClassCaseSenateEN.IdFtpResource = objRow[convPubClassCaseSenate.IdFtpResource] == DBNull.Value ? null : objRow[convPubClassCaseSenate.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvPubClassCaseSenateEN.FileUpDate = objRow[convPubClassCaseSenate.FileUpDate] == DBNull.Value ? null : objRow[convPubClassCaseSenate.FileUpDate].ToString().Trim(); //创建日期
objvPubClassCaseSenateEN.FileDirName = objRow[convPubClassCaseSenate.FileDirName] == DBNull.Value ? null : objRow[convPubClassCaseSenate.FileDirName].ToString().Trim(); //文件目录名
objvPubClassCaseSenateEN.FileOriginalName = objRow[convPubClassCaseSenate.FileOriginalName] == DBNull.Value ? null : objRow[convPubClassCaseSenate.FileOriginalName].ToString().Trim(); //文件原名
objvPubClassCaseSenateEN.FtpResourceID = objRow[convPubClassCaseSenate.FtpResourceID].ToString().Trim(); //FTP资源ID
objvPubClassCaseSenateEN.FileRename = objRow[convPubClassCaseSenate.FileRename] == DBNull.Value ? null : objRow[convPubClassCaseSenate.FileRename].ToString().Trim(); //文件新名
objvPubClassCaseSenateEN.FileUpTime = objRow[convPubClassCaseSenate.FileUpTime] == DBNull.Value ? null : objRow[convPubClassCaseSenate.FileUpTime].ToString().Trim(); //创建时间
objvPubClassCaseSenateEN.SaveMode = TransNullToBool(objRow[convPubClassCaseSenate.SaveMode].ToString().Trim()); //文件存放方式
objvPubClassCaseSenateEN.IdResourceType = objRow[convPubClassCaseSenate.IdResourceType].ToString().Trim(); //资源类型流水号
objvPubClassCaseSenateEN.IdPubCaseType = objRow[convPubClassCaseSenate.IdPubCaseType].ToString().Trim(); //公开课案例类型流水号
objvPubClassCaseSenateEN.ftpFileType = objRow[convPubClassCaseSenate.ftpFileType] == DBNull.Value ? null : objRow[convPubClassCaseSenate.ftpFileType].ToString().Trim(); //ftp文件类型
objvPubClassCaseSenateEN.ftpFileSize = objRow[convPubClassCaseSenate.ftpFileSize] == DBNull.Value ? null : objRow[convPubClassCaseSenate.ftpFileSize].ToString().Trim(); //ftp文件大小
objvPubClassCaseSenateEN.FileOriginName = objRow[convPubClassCaseSenate.FileOriginName] == DBNull.Value ? null : objRow[convPubClassCaseSenate.FileOriginName].ToString().Trim(); //原文件名
objvPubClassCaseSenateEN.IdResource = objRow[convPubClassCaseSenate.IdResource].ToString().Trim(); //资源流水号
objvPubClassCaseSenateEN.IdDiscipline = objRow[convPubClassCaseSenate.IdDiscipline] == DBNull.Value ? null : objRow[convPubClassCaseSenate.IdDiscipline].ToString().Trim(); //学科流水号
objvPubClassCaseSenateEN.IdStudyLevel = objRow[convPubClassCaseSenate.IdStudyLevel] == DBNull.Value ? null : objRow[convPubClassCaseSenate.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvPubClassCaseSenateEN.IdFile = objRow[convPubClassCaseSenate.IdFile] == DBNull.Value ? null : objRow[convPubClassCaseSenate.IdFile].ToString().Trim(); //文件流水号
objvPubClassCaseSenateEN.IsVisible = TransNullToBool(objRow[convPubClassCaseSenate.IsVisible].ToString().Trim()); //是否显示
objvPubClassCaseSenateEN.SaveDate = objRow[convPubClassCaseSenate.SaveDate] == DBNull.Value ? null : objRow[convPubClassCaseSenate.SaveDate].ToString().Trim(); //创建日期
objvPubClassCaseSenateEN.IdPubClassCaseSenateClass = objRow[convPubClassCaseSenate.IdPubClassCaseSenateClass].ToString().Trim(); //公开课案例评议类别流水号
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvPubClassCaseSenateDA: GetObjLst)", objException.Message));
}
objvPubClassCaseSenateEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvPubClassCaseSenateEN);
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
public List<clsvPubClassCaseSenateEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvPubClassCaseSenateDA:GetObjLstByTabName)", objException.Message));
}
List<clsvPubClassCaseSenateEN> arrObjLst = new List<clsvPubClassCaseSenateEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPubClassCaseSenateDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPubClassCaseSenateEN objvPubClassCaseSenateEN = new clsvPubClassCaseSenateEN();
try
{
objvPubClassCaseSenateEN.IdPubClassCaseSenate = TransNullToInt(objRow[convPubClassCaseSenate.IdPubClassCaseSenate].ToString().Trim()); //公开课案例评议流水号
objvPubClassCaseSenateEN.IdPubClassCase = objRow[convPubClassCaseSenate.IdPubClassCase].ToString().Trim(); //案例流水号
objvPubClassCaseSenateEN.PubClassCaseID = objRow[convPubClassCaseSenate.PubClassCaseID].ToString().Trim(); //案例ID
objvPubClassCaseSenateEN.PubClassCaseName = objRow[convPubClassCaseSenate.PubClassCaseName].ToString().Trim(); //案例课题名称
objvPubClassCaseSenateEN.PubClassCaseDateIn = objRow[convPubClassCaseSenate.PubClassCaseDateIn] == DBNull.Value ? null : objRow[convPubClassCaseSenate.PubClassCaseDateIn].ToString().Trim(); //案例入库日期
objvPubClassCaseSenateEN.PubClassCaseTeachDate = objRow[convPubClassCaseSenate.PubClassCaseTeachDate] == DBNull.Value ? null : objRow[convPubClassCaseSenate.PubClassCaseTeachDate].ToString().Trim(); //案例授课日期
objvPubClassCaseSenateEN.PubClassCaseBG = objRow[convPubClassCaseSenate.PubClassCaseBG] == DBNull.Value ? null : objRow[convPubClassCaseSenate.PubClassCaseBG].ToString().Trim(); //案例背景资料
objvPubClassCaseSenateEN.PubClassCaseTheme = objRow[convPubClassCaseSenate.PubClassCaseTheme] == DBNull.Value ? null : objRow[convPubClassCaseSenate.PubClassCaseTheme].ToString().Trim(); //案例主题词
objvPubClassCaseSenateEN.PubClassCaseExecutor = objRow[convPubClassCaseSenate.PubClassCaseExecutor] == DBNull.Value ? null : objRow[convPubClassCaseSenate.PubClassCaseExecutor].ToString().Trim(); //案例执教者
objvPubClassCaseSenateEN.DisciplineID = objRow[convPubClassCaseSenate.DisciplineID] == DBNull.Value ? null : objRow[convPubClassCaseSenate.DisciplineID].ToString().Trim(); //学科ID
objvPubClassCaseSenateEN.DisciplineName = objRow[convPubClassCaseSenate.DisciplineName] == DBNull.Value ? null : objRow[convPubClassCaseSenate.DisciplineName].ToString().Trim(); //学科名称
objvPubClassCaseSenateEN.StudyLevelName = objRow[convPubClassCaseSenate.StudyLevelName] == DBNull.Value ? null : objRow[convPubClassCaseSenate.StudyLevelName].ToString().Trim(); //学段名称
objvPubClassCaseSenateEN.IsElite = TransNullToBool(objRow[convPubClassCaseSenate.IsElite].ToString().Trim()); //精华标志
objvPubClassCaseSenateEN.SubjectName = objRow[convPubClassCaseSenate.SubjectName].ToString().Trim(); //课题名称
objvPubClassCaseSenateEN.ResourceID = objRow[convPubClassCaseSenate.ResourceID].ToString().Trim(); //资源ID
objvPubClassCaseSenateEN.ResourceTypeID = objRow[convPubClassCaseSenate.ResourceTypeID].ToString().Trim(); //资源类型ID
objvPubClassCaseSenateEN.ResourceTypeName = objRow[convPubClassCaseSenate.ResourceTypeName].ToString().Trim(); //资源类型名称
objvPubClassCaseSenateEN.PubCaseTypeID = objRow[convPubClassCaseSenate.PubCaseTypeID].ToString().Trim(); //公开课案例类型ID
objvPubClassCaseSenateEN.PubCaseTypeName = objRow[convPubClassCaseSenate.PubCaseTypeName].ToString().Trim(); //公开课案例类型名称
objvPubClassCaseSenateEN.PubClassCaseSenateClassID = objRow[convPubClassCaseSenate.PubClassCaseSenateClassID] == DBNull.Value ? null : objRow[convPubClassCaseSenate.PubClassCaseSenateClassID].ToString().Trim(); //公开课案例评议类别ID
objvPubClassCaseSenateEN.PubClassCaseSenateClassName = objRow[convPubClassCaseSenate.PubClassCaseSenateClassName] == DBNull.Value ? null : objRow[convPubClassCaseSenate.PubClassCaseSenateClassName].ToString().Trim(); //公开课案例评议类别名称
objvPubClassCaseSenateEN.PubClassCaseSenator = objRow[convPubClassCaseSenate.PubClassCaseSenator] == DBNull.Value ? null : objRow[convPubClassCaseSenate.PubClassCaseSenator].ToString().Trim(); //公开课案例评议者
objvPubClassCaseSenateEN.PubClassCaseSenateTitle = objRow[convPubClassCaseSenate.PubClassCaseSenateTitle] == DBNull.Value ? null : objRow[convPubClassCaseSenate.PubClassCaseSenateTitle].ToString().Trim(); //公开课案例评议标题
objvPubClassCaseSenateEN.PubClassCaseSenateContent = objRow[convPubClassCaseSenate.PubClassCaseSenateContent] == DBNull.Value ? null : objRow[convPubClassCaseSenate.PubClassCaseSenateContent].ToString().Trim(); //公开课案例评议内容
objvPubClassCaseSenateEN.PubClassCaseSenateDate = objRow[convPubClassCaseSenate.PubClassCaseSenateDate] == DBNull.Value ? null : objRow[convPubClassCaseSenate.PubClassCaseSenateDate].ToString().Trim(); //公开课案例评议日期
objvPubClassCaseSenateEN.PubClassCaseSenateTime = objRow[convPubClassCaseSenate.PubClassCaseSenateTime] == DBNull.Value ? null : objRow[convPubClassCaseSenate.PubClassCaseSenateTime].ToString().Trim(); //公开课案例评议时间
objvPubClassCaseSenateEN.SenateReadCount = objRow[convPubClassCaseSenate.SenateReadCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPubClassCaseSenate.SenateReadCount].ToString().Trim()); //评议阅读次数
objvPubClassCaseSenateEN.ResourceOwner = objRow[convPubClassCaseSenate.ResourceOwner].ToString().Trim(); //上传者
objvPubClassCaseSenateEN.ftpResourceOwner = objRow[convPubClassCaseSenate.ftpResourceOwner] == DBNull.Value ? null : objRow[convPubClassCaseSenate.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvPubClassCaseSenateEN.FileNewName = objRow[convPubClassCaseSenate.FileNewName] == DBNull.Value ? null : objRow[convPubClassCaseSenate.FileNewName].ToString().Trim(); //新文件名
objvPubClassCaseSenateEN.FileOldName = objRow[convPubClassCaseSenate.FileOldName] == DBNull.Value ? null : objRow[convPubClassCaseSenate.FileOldName].ToString().Trim(); //旧文件名
objvPubClassCaseSenateEN.FileSize = objRow[convPubClassCaseSenate.FileSize] == DBNull.Value ? null : objRow[convPubClassCaseSenate.FileSize].ToString().Trim(); //文件大小
objvPubClassCaseSenateEN.FileType = objRow[convPubClassCaseSenate.FileType] == DBNull.Value ? null : objRow[convPubClassCaseSenate.FileType].ToString().Trim(); //文件类型
objvPubClassCaseSenateEN.FileName = objRow[convPubClassCaseSenate.FileName] == DBNull.Value ? null : objRow[convPubClassCaseSenate.FileName].ToString().Trim(); //文件名称
objvPubClassCaseSenateEN.SaveTime = objRow[convPubClassCaseSenate.SaveTime] == DBNull.Value ? null : objRow[convPubClassCaseSenate.SaveTime].ToString().Trim(); //创建时间
objvPubClassCaseSenateEN.IsVisual = TransNullToBool(objRow[convPubClassCaseSenate.IsVisual].ToString().Trim()); //隐藏标志
objvPubClassCaseSenateEN.IdTeachingPlan = objRow[convPubClassCaseSenate.IdTeachingPlan].ToString().Trim(); //教案流水号
objvPubClassCaseSenateEN.IdFtpResource = objRow[convPubClassCaseSenate.IdFtpResource] == DBNull.Value ? null : objRow[convPubClassCaseSenate.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvPubClassCaseSenateEN.FileUpDate = objRow[convPubClassCaseSenate.FileUpDate] == DBNull.Value ? null : objRow[convPubClassCaseSenate.FileUpDate].ToString().Trim(); //创建日期
objvPubClassCaseSenateEN.FileDirName = objRow[convPubClassCaseSenate.FileDirName] == DBNull.Value ? null : objRow[convPubClassCaseSenate.FileDirName].ToString().Trim(); //文件目录名
objvPubClassCaseSenateEN.FileOriginalName = objRow[convPubClassCaseSenate.FileOriginalName] == DBNull.Value ? null : objRow[convPubClassCaseSenate.FileOriginalName].ToString().Trim(); //文件原名
objvPubClassCaseSenateEN.FtpResourceID = objRow[convPubClassCaseSenate.FtpResourceID].ToString().Trim(); //FTP资源ID
objvPubClassCaseSenateEN.FileRename = objRow[convPubClassCaseSenate.FileRename] == DBNull.Value ? null : objRow[convPubClassCaseSenate.FileRename].ToString().Trim(); //文件新名
objvPubClassCaseSenateEN.FileUpTime = objRow[convPubClassCaseSenate.FileUpTime] == DBNull.Value ? null : objRow[convPubClassCaseSenate.FileUpTime].ToString().Trim(); //创建时间
objvPubClassCaseSenateEN.SaveMode = TransNullToBool(objRow[convPubClassCaseSenate.SaveMode].ToString().Trim()); //文件存放方式
objvPubClassCaseSenateEN.IdResourceType = objRow[convPubClassCaseSenate.IdResourceType].ToString().Trim(); //资源类型流水号
objvPubClassCaseSenateEN.IdPubCaseType = objRow[convPubClassCaseSenate.IdPubCaseType].ToString().Trim(); //公开课案例类型流水号
objvPubClassCaseSenateEN.ftpFileType = objRow[convPubClassCaseSenate.ftpFileType] == DBNull.Value ? null : objRow[convPubClassCaseSenate.ftpFileType].ToString().Trim(); //ftp文件类型
objvPubClassCaseSenateEN.ftpFileSize = objRow[convPubClassCaseSenate.ftpFileSize] == DBNull.Value ? null : objRow[convPubClassCaseSenate.ftpFileSize].ToString().Trim(); //ftp文件大小
objvPubClassCaseSenateEN.FileOriginName = objRow[convPubClassCaseSenate.FileOriginName] == DBNull.Value ? null : objRow[convPubClassCaseSenate.FileOriginName].ToString().Trim(); //原文件名
objvPubClassCaseSenateEN.IdResource = objRow[convPubClassCaseSenate.IdResource].ToString().Trim(); //资源流水号
objvPubClassCaseSenateEN.IdDiscipline = objRow[convPubClassCaseSenate.IdDiscipline] == DBNull.Value ? null : objRow[convPubClassCaseSenate.IdDiscipline].ToString().Trim(); //学科流水号
objvPubClassCaseSenateEN.IdStudyLevel = objRow[convPubClassCaseSenate.IdStudyLevel] == DBNull.Value ? null : objRow[convPubClassCaseSenate.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvPubClassCaseSenateEN.IdFile = objRow[convPubClassCaseSenate.IdFile] == DBNull.Value ? null : objRow[convPubClassCaseSenate.IdFile].ToString().Trim(); //文件流水号
objvPubClassCaseSenateEN.IsVisible = TransNullToBool(objRow[convPubClassCaseSenate.IsVisible].ToString().Trim()); //是否显示
objvPubClassCaseSenateEN.SaveDate = objRow[convPubClassCaseSenate.SaveDate] == DBNull.Value ? null : objRow[convPubClassCaseSenate.SaveDate].ToString().Trim(); //创建日期
objvPubClassCaseSenateEN.IdPubClassCaseSenateClass = objRow[convPubClassCaseSenate.IdPubClassCaseSenateClass].ToString().Trim(); //公开课案例评议类别流水号
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvPubClassCaseSenateDA: GetObjLst)", objException.Message));
}
objvPubClassCaseSenateEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvPubClassCaseSenateEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvPubClassCaseSenateEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvPubClassCaseSenate(ref clsvPubClassCaseSenateEN objvPubClassCaseSenateEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPubClassCaseSenateDA.GetSpecSQLObj();
strSQL = "Select * from vPubClassCaseSenate where IdPubClassCaseSenate = " + ""+ objvPubClassCaseSenateEN.IdPubClassCaseSenate+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvPubClassCaseSenateEN.IdPubClassCaseSenate = TransNullToInt(objDT.Rows[0][convPubClassCaseSenate.IdPubClassCaseSenate].ToString().Trim()); //公开课案例评议流水号(字段类型:bigint,字段长度:8,是否可空:False)
 objvPubClassCaseSenateEN.IdPubClassCase = objDT.Rows[0][convPubClassCaseSenate.IdPubClassCase].ToString().Trim(); //案例流水号(字段类型:char,字段长度:8,是否可空:False)
 objvPubClassCaseSenateEN.PubClassCaseID = objDT.Rows[0][convPubClassCaseSenate.PubClassCaseID].ToString().Trim(); //案例ID(字段类型:char,字段长度:8,是否可空:False)
 objvPubClassCaseSenateEN.PubClassCaseName = objDT.Rows[0][convPubClassCaseSenate.PubClassCaseName].ToString().Trim(); //案例课题名称(字段类型:varchar,字段长度:200,是否可空:False)
 objvPubClassCaseSenateEN.PubClassCaseDateIn = objDT.Rows[0][convPubClassCaseSenate.PubClassCaseDateIn].ToString().Trim(); //案例入库日期(字段类型:char,字段长度:8,是否可空:True)
 objvPubClassCaseSenateEN.PubClassCaseTeachDate = objDT.Rows[0][convPubClassCaseSenate.PubClassCaseTeachDate].ToString().Trim(); //案例授课日期(字段类型:char,字段长度:8,是否可空:True)
 objvPubClassCaseSenateEN.PubClassCaseBG = objDT.Rows[0][convPubClassCaseSenate.PubClassCaseBG].ToString().Trim(); //案例背景资料(字段类型:text,字段长度:16,是否可空:True)
 objvPubClassCaseSenateEN.PubClassCaseTheme = objDT.Rows[0][convPubClassCaseSenate.PubClassCaseTheme].ToString().Trim(); //案例主题词(字段类型:varchar,字段长度:500,是否可空:True)
 objvPubClassCaseSenateEN.PubClassCaseExecutor = objDT.Rows[0][convPubClassCaseSenate.PubClassCaseExecutor].ToString().Trim(); //案例执教者(字段类型:varchar,字段长度:50,是否可空:True)
 objvPubClassCaseSenateEN.DisciplineID = objDT.Rows[0][convPubClassCaseSenate.DisciplineID].ToString().Trim(); //学科ID(字段类型:char,字段长度:4,是否可空:False)
 objvPubClassCaseSenateEN.DisciplineName = objDT.Rows[0][convPubClassCaseSenate.DisciplineName].ToString().Trim(); //学科名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvPubClassCaseSenateEN.StudyLevelName = objDT.Rows[0][convPubClassCaseSenate.StudyLevelName].ToString().Trim(); //学段名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvPubClassCaseSenateEN.IsElite = TransNullToBool(objDT.Rows[0][convPubClassCaseSenate.IsElite].ToString().Trim()); //精华标志(字段类型:bit,字段长度:1,是否可空:False)
 objvPubClassCaseSenateEN.SubjectName = objDT.Rows[0][convPubClassCaseSenate.SubjectName].ToString().Trim(); //课题名称(字段类型:varchar,字段长度:200,是否可空:False)
 objvPubClassCaseSenateEN.ResourceID = objDT.Rows[0][convPubClassCaseSenate.ResourceID].ToString().Trim(); //资源ID(字段类型:char,字段长度:8,是否可空:False)
 objvPubClassCaseSenateEN.ResourceTypeID = objDT.Rows[0][convPubClassCaseSenate.ResourceTypeID].ToString().Trim(); //资源类型ID(字段类型:char,字段长度:4,是否可空:False)
 objvPubClassCaseSenateEN.ResourceTypeName = objDT.Rows[0][convPubClassCaseSenate.ResourceTypeName].ToString().Trim(); //资源类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvPubClassCaseSenateEN.PubCaseTypeID = objDT.Rows[0][convPubClassCaseSenate.PubCaseTypeID].ToString().Trim(); //公开课案例类型ID(字段类型:char,字段长度:4,是否可空:False)
 objvPubClassCaseSenateEN.PubCaseTypeName = objDT.Rows[0][convPubClassCaseSenate.PubCaseTypeName].ToString().Trim(); //公开课案例类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvPubClassCaseSenateEN.PubClassCaseSenateClassID = objDT.Rows[0][convPubClassCaseSenate.PubClassCaseSenateClassID].ToString().Trim(); //公开课案例评议类别ID(字段类型:varchar,字段长度:4,是否可空:True)
 objvPubClassCaseSenateEN.PubClassCaseSenateClassName = objDT.Rows[0][convPubClassCaseSenate.PubClassCaseSenateClassName].ToString().Trim(); //公开课案例评议类别名称(字段类型:varchar,字段长度:50,是否可空:True)
 objvPubClassCaseSenateEN.PubClassCaseSenator = objDT.Rows[0][convPubClassCaseSenate.PubClassCaseSenator].ToString().Trim(); //公开课案例评议者(字段类型:varchar,字段长度:50,是否可空:True)
 objvPubClassCaseSenateEN.PubClassCaseSenateTitle = objDT.Rows[0][convPubClassCaseSenate.PubClassCaseSenateTitle].ToString().Trim(); //公开课案例评议标题(字段类型:varchar,字段长度:200,是否可空:True)
 objvPubClassCaseSenateEN.PubClassCaseSenateContent = objDT.Rows[0][convPubClassCaseSenate.PubClassCaseSenateContent].ToString().Trim(); //公开课案例评议内容(字段类型:varchar,字段长度:8000,是否可空:True)
 objvPubClassCaseSenateEN.PubClassCaseSenateDate = objDT.Rows[0][convPubClassCaseSenate.PubClassCaseSenateDate].ToString().Trim(); //公开课案例评议日期(字段类型:char,字段长度:8,是否可空:True)
 objvPubClassCaseSenateEN.PubClassCaseSenateTime = objDT.Rows[0][convPubClassCaseSenate.PubClassCaseSenateTime].ToString().Trim(); //公开课案例评议时间(字段类型:char,字段长度:6,是否可空:True)
 objvPubClassCaseSenateEN.SenateReadCount = TransNullToInt(objDT.Rows[0][convPubClassCaseSenate.SenateReadCount].ToString().Trim()); //评议阅读次数(字段类型:int,字段长度:4,是否可空:True)
 objvPubClassCaseSenateEN.ResourceOwner = objDT.Rows[0][convPubClassCaseSenate.ResourceOwner].ToString().Trim(); //上传者(字段类型:varchar,字段长度:50,是否可空:False)
 objvPubClassCaseSenateEN.ftpResourceOwner = objDT.Rows[0][convPubClassCaseSenate.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者(字段类型:varchar,字段长度:50,是否可空:True)
 objvPubClassCaseSenateEN.FileNewName = objDT.Rows[0][convPubClassCaseSenate.FileNewName].ToString().Trim(); //新文件名(字段类型:varchar,字段长度:530,是否可空:True)
 objvPubClassCaseSenateEN.FileOldName = objDT.Rows[0][convPubClassCaseSenate.FileOldName].ToString().Trim(); //旧文件名(字段类型:varchar,字段长度:530,是否可空:True)
 objvPubClassCaseSenateEN.FileSize = objDT.Rows[0][convPubClassCaseSenate.FileSize].ToString().Trim(); //文件大小(字段类型:varchar,字段长度:50,是否可空:True)
 objvPubClassCaseSenateEN.FileType = objDT.Rows[0][convPubClassCaseSenate.FileType].ToString().Trim(); //文件类型(字段类型:varchar,字段长度:30,是否可空:True)
 objvPubClassCaseSenateEN.FileName = objDT.Rows[0][convPubClassCaseSenate.FileName].ToString().Trim(); //文件名称(字段类型:varchar,字段长度:500,是否可空:True)
 objvPubClassCaseSenateEN.SaveTime = objDT.Rows[0][convPubClassCaseSenate.SaveTime].ToString().Trim(); //创建时间(字段类型:char,字段长度:6,是否可空:True)
 objvPubClassCaseSenateEN.IsVisual = TransNullToBool(objDT.Rows[0][convPubClassCaseSenate.IsVisual].ToString().Trim()); //隐藏标志(字段类型:bit,字段长度:1,是否可空:False)
 objvPubClassCaseSenateEN.IdTeachingPlan = objDT.Rows[0][convPubClassCaseSenate.IdTeachingPlan].ToString().Trim(); //教案流水号(字段类型:char,字段长度:8,是否可空:False)
 objvPubClassCaseSenateEN.IdFtpResource = objDT.Rows[0][convPubClassCaseSenate.IdFtpResource].ToString().Trim(); //FTP资源流水号(字段类型:char,字段长度:8,是否可空:True)
 objvPubClassCaseSenateEN.FileUpDate = objDT.Rows[0][convPubClassCaseSenate.FileUpDate].ToString().Trim(); //创建日期(字段类型:char,字段长度:8,是否可空:True)
 objvPubClassCaseSenateEN.FileDirName = objDT.Rows[0][convPubClassCaseSenate.FileDirName].ToString().Trim(); //文件目录名(字段类型:varchar,字段长度:200,是否可空:True)
 objvPubClassCaseSenateEN.FileOriginalName = objDT.Rows[0][convPubClassCaseSenate.FileOriginalName].ToString().Trim(); //文件原名(字段类型:varchar,字段长度:200,是否可空:True)
 objvPubClassCaseSenateEN.FtpResourceID = objDT.Rows[0][convPubClassCaseSenate.FtpResourceID].ToString().Trim(); //FTP资源ID(字段类型:char,字段长度:8,是否可空:False)
 objvPubClassCaseSenateEN.FileRename = objDT.Rows[0][convPubClassCaseSenate.FileRename].ToString().Trim(); //文件新名(字段类型:varchar,字段长度:200,是否可空:True)
 objvPubClassCaseSenateEN.FileUpTime = objDT.Rows[0][convPubClassCaseSenate.FileUpTime].ToString().Trim(); //创建时间(字段类型:char,字段长度:6,是否可空:True)
 objvPubClassCaseSenateEN.SaveMode = TransNullToBool(objDT.Rows[0][convPubClassCaseSenate.SaveMode].ToString().Trim()); //文件存放方式(字段类型:bit,字段长度:1,是否可空:True)
 objvPubClassCaseSenateEN.IdResourceType = objDT.Rows[0][convPubClassCaseSenate.IdResourceType].ToString().Trim(); //资源类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvPubClassCaseSenateEN.IdPubCaseType = objDT.Rows[0][convPubClassCaseSenate.IdPubCaseType].ToString().Trim(); //公开课案例类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvPubClassCaseSenateEN.ftpFileType = objDT.Rows[0][convPubClassCaseSenate.ftpFileType].ToString().Trim(); //ftp文件类型(字段类型:varchar,字段长度:30,是否可空:True)
 objvPubClassCaseSenateEN.ftpFileSize = objDT.Rows[0][convPubClassCaseSenate.ftpFileSize].ToString().Trim(); //ftp文件大小(字段类型:varchar,字段长度:50,是否可空:True)
 objvPubClassCaseSenateEN.FileOriginName = objDT.Rows[0][convPubClassCaseSenate.FileOriginName].ToString().Trim(); //原文件名(字段类型:varchar,字段长度:500,是否可空:True)
 objvPubClassCaseSenateEN.IdResource = objDT.Rows[0][convPubClassCaseSenate.IdResource].ToString().Trim(); //资源流水号(字段类型:char,字段长度:8,是否可空:False)
 objvPubClassCaseSenateEN.IdDiscipline = objDT.Rows[0][convPubClassCaseSenate.IdDiscipline].ToString().Trim(); //学科流水号(字段类型:char,字段长度:4,是否可空:False)
 objvPubClassCaseSenateEN.IdStudyLevel = objDT.Rows[0][convPubClassCaseSenate.IdStudyLevel].ToString().Trim(); //id_StudyLevel(字段类型:char,字段长度:4,是否可空:True)
 objvPubClassCaseSenateEN.IdFile = objDT.Rows[0][convPubClassCaseSenate.IdFile].ToString().Trim(); //文件流水号(字段类型:char,字段长度:8,是否可空:True)
 objvPubClassCaseSenateEN.IsVisible = TransNullToBool(objDT.Rows[0][convPubClassCaseSenate.IsVisible].ToString().Trim()); //是否显示(字段类型:bit,字段长度:1,是否可空:True)
 objvPubClassCaseSenateEN.SaveDate = objDT.Rows[0][convPubClassCaseSenate.SaveDate].ToString().Trim(); //创建日期(字段类型:char,字段长度:8,是否可空:True)
 objvPubClassCaseSenateEN.IdPubClassCaseSenateClass = objDT.Rows[0][convPubClassCaseSenate.IdPubClassCaseSenateClass].ToString().Trim(); //公开课案例评议类别流水号(字段类型:char,字段长度:4,是否可空:False)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvPubClassCaseSenateDA: GetvPubClassCaseSenate)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngIdPubClassCaseSenate">表关键字</param>
 /// <returns>表对象</returns>
public clsvPubClassCaseSenateEN GetObjByIdPubClassCaseSenate(long lngIdPubClassCaseSenate)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPubClassCaseSenateDA.GetSpecSQLObj();
strSQL = "Select * from vPubClassCaseSenate where IdPubClassCaseSenate = " + ""+ lngIdPubClassCaseSenate+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvPubClassCaseSenateEN objvPubClassCaseSenateEN = new clsvPubClassCaseSenateEN();
try
{
 objvPubClassCaseSenateEN.IdPubClassCaseSenate = Int32.Parse(objRow[convPubClassCaseSenate.IdPubClassCaseSenate].ToString().Trim()); //公开课案例评议流水号(字段类型:bigint,字段长度:8,是否可空:False)
 objvPubClassCaseSenateEN.IdPubClassCase = objRow[convPubClassCaseSenate.IdPubClassCase].ToString().Trim(); //案例流水号(字段类型:char,字段长度:8,是否可空:False)
 objvPubClassCaseSenateEN.PubClassCaseID = objRow[convPubClassCaseSenate.PubClassCaseID].ToString().Trim(); //案例ID(字段类型:char,字段长度:8,是否可空:False)
 objvPubClassCaseSenateEN.PubClassCaseName = objRow[convPubClassCaseSenate.PubClassCaseName].ToString().Trim(); //案例课题名称(字段类型:varchar,字段长度:200,是否可空:False)
 objvPubClassCaseSenateEN.PubClassCaseDateIn = objRow[convPubClassCaseSenate.PubClassCaseDateIn] == DBNull.Value ? null : objRow[convPubClassCaseSenate.PubClassCaseDateIn].ToString().Trim(); //案例入库日期(字段类型:char,字段长度:8,是否可空:True)
 objvPubClassCaseSenateEN.PubClassCaseTeachDate = objRow[convPubClassCaseSenate.PubClassCaseTeachDate] == DBNull.Value ? null : objRow[convPubClassCaseSenate.PubClassCaseTeachDate].ToString().Trim(); //案例授课日期(字段类型:char,字段长度:8,是否可空:True)
 objvPubClassCaseSenateEN.PubClassCaseBG = objRow[convPubClassCaseSenate.PubClassCaseBG] == DBNull.Value ? null : objRow[convPubClassCaseSenate.PubClassCaseBG].ToString().Trim(); //案例背景资料(字段类型:text,字段长度:16,是否可空:True)
 objvPubClassCaseSenateEN.PubClassCaseTheme = objRow[convPubClassCaseSenate.PubClassCaseTheme] == DBNull.Value ? null : objRow[convPubClassCaseSenate.PubClassCaseTheme].ToString().Trim(); //案例主题词(字段类型:varchar,字段长度:500,是否可空:True)
 objvPubClassCaseSenateEN.PubClassCaseExecutor = objRow[convPubClassCaseSenate.PubClassCaseExecutor] == DBNull.Value ? null : objRow[convPubClassCaseSenate.PubClassCaseExecutor].ToString().Trim(); //案例执教者(字段类型:varchar,字段长度:50,是否可空:True)
 objvPubClassCaseSenateEN.DisciplineID = objRow[convPubClassCaseSenate.DisciplineID] == DBNull.Value ? null : objRow[convPubClassCaseSenate.DisciplineID].ToString().Trim(); //学科ID(字段类型:char,字段长度:4,是否可空:False)
 objvPubClassCaseSenateEN.DisciplineName = objRow[convPubClassCaseSenate.DisciplineName] == DBNull.Value ? null : objRow[convPubClassCaseSenate.DisciplineName].ToString().Trim(); //学科名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvPubClassCaseSenateEN.StudyLevelName = objRow[convPubClassCaseSenate.StudyLevelName] == DBNull.Value ? null : objRow[convPubClassCaseSenate.StudyLevelName].ToString().Trim(); //学段名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvPubClassCaseSenateEN.IsElite = clsEntityBase2.TransNullToBool_S(objRow[convPubClassCaseSenate.IsElite].ToString().Trim()); //精华标志(字段类型:bit,字段长度:1,是否可空:False)
 objvPubClassCaseSenateEN.SubjectName = objRow[convPubClassCaseSenate.SubjectName].ToString().Trim(); //课题名称(字段类型:varchar,字段长度:200,是否可空:False)
 objvPubClassCaseSenateEN.ResourceID = objRow[convPubClassCaseSenate.ResourceID].ToString().Trim(); //资源ID(字段类型:char,字段长度:8,是否可空:False)
 objvPubClassCaseSenateEN.ResourceTypeID = objRow[convPubClassCaseSenate.ResourceTypeID].ToString().Trim(); //资源类型ID(字段类型:char,字段长度:4,是否可空:False)
 objvPubClassCaseSenateEN.ResourceTypeName = objRow[convPubClassCaseSenate.ResourceTypeName].ToString().Trim(); //资源类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvPubClassCaseSenateEN.PubCaseTypeID = objRow[convPubClassCaseSenate.PubCaseTypeID].ToString().Trim(); //公开课案例类型ID(字段类型:char,字段长度:4,是否可空:False)
 objvPubClassCaseSenateEN.PubCaseTypeName = objRow[convPubClassCaseSenate.PubCaseTypeName].ToString().Trim(); //公开课案例类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvPubClassCaseSenateEN.PubClassCaseSenateClassID = objRow[convPubClassCaseSenate.PubClassCaseSenateClassID] == DBNull.Value ? null : objRow[convPubClassCaseSenate.PubClassCaseSenateClassID].ToString().Trim(); //公开课案例评议类别ID(字段类型:varchar,字段长度:4,是否可空:True)
 objvPubClassCaseSenateEN.PubClassCaseSenateClassName = objRow[convPubClassCaseSenate.PubClassCaseSenateClassName] == DBNull.Value ? null : objRow[convPubClassCaseSenate.PubClassCaseSenateClassName].ToString().Trim(); //公开课案例评议类别名称(字段类型:varchar,字段长度:50,是否可空:True)
 objvPubClassCaseSenateEN.PubClassCaseSenator = objRow[convPubClassCaseSenate.PubClassCaseSenator] == DBNull.Value ? null : objRow[convPubClassCaseSenate.PubClassCaseSenator].ToString().Trim(); //公开课案例评议者(字段类型:varchar,字段长度:50,是否可空:True)
 objvPubClassCaseSenateEN.PubClassCaseSenateTitle = objRow[convPubClassCaseSenate.PubClassCaseSenateTitle] == DBNull.Value ? null : objRow[convPubClassCaseSenate.PubClassCaseSenateTitle].ToString().Trim(); //公开课案例评议标题(字段类型:varchar,字段长度:200,是否可空:True)
 objvPubClassCaseSenateEN.PubClassCaseSenateContent = objRow[convPubClassCaseSenate.PubClassCaseSenateContent] == DBNull.Value ? null : objRow[convPubClassCaseSenate.PubClassCaseSenateContent].ToString().Trim(); //公开课案例评议内容(字段类型:varchar,字段长度:8000,是否可空:True)
 objvPubClassCaseSenateEN.PubClassCaseSenateDate = objRow[convPubClassCaseSenate.PubClassCaseSenateDate] == DBNull.Value ? null : objRow[convPubClassCaseSenate.PubClassCaseSenateDate].ToString().Trim(); //公开课案例评议日期(字段类型:char,字段长度:8,是否可空:True)
 objvPubClassCaseSenateEN.PubClassCaseSenateTime = objRow[convPubClassCaseSenate.PubClassCaseSenateTime] == DBNull.Value ? null : objRow[convPubClassCaseSenate.PubClassCaseSenateTime].ToString().Trim(); //公开课案例评议时间(字段类型:char,字段长度:6,是否可空:True)
 objvPubClassCaseSenateEN.SenateReadCount = objRow[convPubClassCaseSenate.SenateReadCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPubClassCaseSenate.SenateReadCount].ToString().Trim()); //评议阅读次数(字段类型:int,字段长度:4,是否可空:True)
 objvPubClassCaseSenateEN.ResourceOwner = objRow[convPubClassCaseSenate.ResourceOwner].ToString().Trim(); //上传者(字段类型:varchar,字段长度:50,是否可空:False)
 objvPubClassCaseSenateEN.ftpResourceOwner = objRow[convPubClassCaseSenate.ftpResourceOwner] == DBNull.Value ? null : objRow[convPubClassCaseSenate.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者(字段类型:varchar,字段长度:50,是否可空:True)
 objvPubClassCaseSenateEN.FileNewName = objRow[convPubClassCaseSenate.FileNewName] == DBNull.Value ? null : objRow[convPubClassCaseSenate.FileNewName].ToString().Trim(); //新文件名(字段类型:varchar,字段长度:530,是否可空:True)
 objvPubClassCaseSenateEN.FileOldName = objRow[convPubClassCaseSenate.FileOldName] == DBNull.Value ? null : objRow[convPubClassCaseSenate.FileOldName].ToString().Trim(); //旧文件名(字段类型:varchar,字段长度:530,是否可空:True)
 objvPubClassCaseSenateEN.FileSize = objRow[convPubClassCaseSenate.FileSize] == DBNull.Value ? null : objRow[convPubClassCaseSenate.FileSize].ToString().Trim(); //文件大小(字段类型:varchar,字段长度:50,是否可空:True)
 objvPubClassCaseSenateEN.FileType = objRow[convPubClassCaseSenate.FileType] == DBNull.Value ? null : objRow[convPubClassCaseSenate.FileType].ToString().Trim(); //文件类型(字段类型:varchar,字段长度:30,是否可空:True)
 objvPubClassCaseSenateEN.FileName = objRow[convPubClassCaseSenate.FileName] == DBNull.Value ? null : objRow[convPubClassCaseSenate.FileName].ToString().Trim(); //文件名称(字段类型:varchar,字段长度:500,是否可空:True)
 objvPubClassCaseSenateEN.SaveTime = objRow[convPubClassCaseSenate.SaveTime] == DBNull.Value ? null : objRow[convPubClassCaseSenate.SaveTime].ToString().Trim(); //创建时间(字段类型:char,字段长度:6,是否可空:True)
 objvPubClassCaseSenateEN.IsVisual = clsEntityBase2.TransNullToBool_S(objRow[convPubClassCaseSenate.IsVisual].ToString().Trim()); //隐藏标志(字段类型:bit,字段长度:1,是否可空:False)
 objvPubClassCaseSenateEN.IdTeachingPlan = objRow[convPubClassCaseSenate.IdTeachingPlan].ToString().Trim(); //教案流水号(字段类型:char,字段长度:8,是否可空:False)
 objvPubClassCaseSenateEN.IdFtpResource = objRow[convPubClassCaseSenate.IdFtpResource] == DBNull.Value ? null : objRow[convPubClassCaseSenate.IdFtpResource].ToString().Trim(); //FTP资源流水号(字段类型:char,字段长度:8,是否可空:True)
 objvPubClassCaseSenateEN.FileUpDate = objRow[convPubClassCaseSenate.FileUpDate] == DBNull.Value ? null : objRow[convPubClassCaseSenate.FileUpDate].ToString().Trim(); //创建日期(字段类型:char,字段长度:8,是否可空:True)
 objvPubClassCaseSenateEN.FileDirName = objRow[convPubClassCaseSenate.FileDirName] == DBNull.Value ? null : objRow[convPubClassCaseSenate.FileDirName].ToString().Trim(); //文件目录名(字段类型:varchar,字段长度:200,是否可空:True)
 objvPubClassCaseSenateEN.FileOriginalName = objRow[convPubClassCaseSenate.FileOriginalName] == DBNull.Value ? null : objRow[convPubClassCaseSenate.FileOriginalName].ToString().Trim(); //文件原名(字段类型:varchar,字段长度:200,是否可空:True)
 objvPubClassCaseSenateEN.FtpResourceID = objRow[convPubClassCaseSenate.FtpResourceID].ToString().Trim(); //FTP资源ID(字段类型:char,字段长度:8,是否可空:False)
 objvPubClassCaseSenateEN.FileRename = objRow[convPubClassCaseSenate.FileRename] == DBNull.Value ? null : objRow[convPubClassCaseSenate.FileRename].ToString().Trim(); //文件新名(字段类型:varchar,字段长度:200,是否可空:True)
 objvPubClassCaseSenateEN.FileUpTime = objRow[convPubClassCaseSenate.FileUpTime] == DBNull.Value ? null : objRow[convPubClassCaseSenate.FileUpTime].ToString().Trim(); //创建时间(字段类型:char,字段长度:6,是否可空:True)
 objvPubClassCaseSenateEN.SaveMode = clsEntityBase2.TransNullToBool_S(objRow[convPubClassCaseSenate.SaveMode].ToString().Trim()); //文件存放方式(字段类型:bit,字段长度:1,是否可空:True)
 objvPubClassCaseSenateEN.IdResourceType = objRow[convPubClassCaseSenate.IdResourceType].ToString().Trim(); //资源类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvPubClassCaseSenateEN.IdPubCaseType = objRow[convPubClassCaseSenate.IdPubCaseType].ToString().Trim(); //公开课案例类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvPubClassCaseSenateEN.ftpFileType = objRow[convPubClassCaseSenate.ftpFileType] == DBNull.Value ? null : objRow[convPubClassCaseSenate.ftpFileType].ToString().Trim(); //ftp文件类型(字段类型:varchar,字段长度:30,是否可空:True)
 objvPubClassCaseSenateEN.ftpFileSize = objRow[convPubClassCaseSenate.ftpFileSize] == DBNull.Value ? null : objRow[convPubClassCaseSenate.ftpFileSize].ToString().Trim(); //ftp文件大小(字段类型:varchar,字段长度:50,是否可空:True)
 objvPubClassCaseSenateEN.FileOriginName = objRow[convPubClassCaseSenate.FileOriginName] == DBNull.Value ? null : objRow[convPubClassCaseSenate.FileOriginName].ToString().Trim(); //原文件名(字段类型:varchar,字段长度:500,是否可空:True)
 objvPubClassCaseSenateEN.IdResource = objRow[convPubClassCaseSenate.IdResource].ToString().Trim(); //资源流水号(字段类型:char,字段长度:8,是否可空:False)
 objvPubClassCaseSenateEN.IdDiscipline = objRow[convPubClassCaseSenate.IdDiscipline] == DBNull.Value ? null : objRow[convPubClassCaseSenate.IdDiscipline].ToString().Trim(); //学科流水号(字段类型:char,字段长度:4,是否可空:False)
 objvPubClassCaseSenateEN.IdStudyLevel = objRow[convPubClassCaseSenate.IdStudyLevel] == DBNull.Value ? null : objRow[convPubClassCaseSenate.IdStudyLevel].ToString().Trim(); //id_StudyLevel(字段类型:char,字段长度:4,是否可空:True)
 objvPubClassCaseSenateEN.IdFile = objRow[convPubClassCaseSenate.IdFile] == DBNull.Value ? null : objRow[convPubClassCaseSenate.IdFile].ToString().Trim(); //文件流水号(字段类型:char,字段长度:8,是否可空:True)
 objvPubClassCaseSenateEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convPubClassCaseSenate.IsVisible].ToString().Trim()); //是否显示(字段类型:bit,字段长度:1,是否可空:True)
 objvPubClassCaseSenateEN.SaveDate = objRow[convPubClassCaseSenate.SaveDate] == DBNull.Value ? null : objRow[convPubClassCaseSenate.SaveDate].ToString().Trim(); //创建日期(字段类型:char,字段长度:8,是否可空:True)
 objvPubClassCaseSenateEN.IdPubClassCaseSenateClass = objRow[convPubClassCaseSenate.IdPubClassCaseSenateClass].ToString().Trim(); //公开课案例评议类别流水号(字段类型:char,字段长度:4,是否可空:False)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvPubClassCaseSenateDA: GetObjByIdPubClassCaseSenate)", objException.Message));
}
return objvPubClassCaseSenateEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvPubClassCaseSenateEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvPubClassCaseSenateDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPubClassCaseSenateDA.GetSpecSQLObj();
strSQL = "Select * from vPubClassCaseSenate where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvPubClassCaseSenateEN objvPubClassCaseSenateEN = new clsvPubClassCaseSenateEN()
{
IdPubClassCaseSenate = TransNullToInt(objRow[convPubClassCaseSenate.IdPubClassCaseSenate].ToString().Trim()), //公开课案例评议流水号
IdPubClassCase = objRow[convPubClassCaseSenate.IdPubClassCase].ToString().Trim(), //案例流水号
PubClassCaseID = objRow[convPubClassCaseSenate.PubClassCaseID].ToString().Trim(), //案例ID
PubClassCaseName = objRow[convPubClassCaseSenate.PubClassCaseName].ToString().Trim(), //案例课题名称
PubClassCaseDateIn = objRow[convPubClassCaseSenate.PubClassCaseDateIn] == DBNull.Value ? null : objRow[convPubClassCaseSenate.PubClassCaseDateIn].ToString().Trim(), //案例入库日期
PubClassCaseTeachDate = objRow[convPubClassCaseSenate.PubClassCaseTeachDate] == DBNull.Value ? null : objRow[convPubClassCaseSenate.PubClassCaseTeachDate].ToString().Trim(), //案例授课日期
PubClassCaseBG = objRow[convPubClassCaseSenate.PubClassCaseBG] == DBNull.Value ? null : objRow[convPubClassCaseSenate.PubClassCaseBG].ToString().Trim(), //案例背景资料
PubClassCaseTheme = objRow[convPubClassCaseSenate.PubClassCaseTheme] == DBNull.Value ? null : objRow[convPubClassCaseSenate.PubClassCaseTheme].ToString().Trim(), //案例主题词
PubClassCaseExecutor = objRow[convPubClassCaseSenate.PubClassCaseExecutor] == DBNull.Value ? null : objRow[convPubClassCaseSenate.PubClassCaseExecutor].ToString().Trim(), //案例执教者
DisciplineID = objRow[convPubClassCaseSenate.DisciplineID] == DBNull.Value ? null : objRow[convPubClassCaseSenate.DisciplineID].ToString().Trim(), //学科ID
DisciplineName = objRow[convPubClassCaseSenate.DisciplineName] == DBNull.Value ? null : objRow[convPubClassCaseSenate.DisciplineName].ToString().Trim(), //学科名称
StudyLevelName = objRow[convPubClassCaseSenate.StudyLevelName] == DBNull.Value ? null : objRow[convPubClassCaseSenate.StudyLevelName].ToString().Trim(), //学段名称
IsElite = TransNullToBool(objRow[convPubClassCaseSenate.IsElite].ToString().Trim()), //精华标志
SubjectName = objRow[convPubClassCaseSenate.SubjectName].ToString().Trim(), //课题名称
ResourceID = objRow[convPubClassCaseSenate.ResourceID].ToString().Trim(), //资源ID
ResourceTypeID = objRow[convPubClassCaseSenate.ResourceTypeID].ToString().Trim(), //资源类型ID
ResourceTypeName = objRow[convPubClassCaseSenate.ResourceTypeName].ToString().Trim(), //资源类型名称
PubCaseTypeID = objRow[convPubClassCaseSenate.PubCaseTypeID].ToString().Trim(), //公开课案例类型ID
PubCaseTypeName = objRow[convPubClassCaseSenate.PubCaseTypeName].ToString().Trim(), //公开课案例类型名称
PubClassCaseSenateClassID = objRow[convPubClassCaseSenate.PubClassCaseSenateClassID] == DBNull.Value ? null : objRow[convPubClassCaseSenate.PubClassCaseSenateClassID].ToString().Trim(), //公开课案例评议类别ID
PubClassCaseSenateClassName = objRow[convPubClassCaseSenate.PubClassCaseSenateClassName] == DBNull.Value ? null : objRow[convPubClassCaseSenate.PubClassCaseSenateClassName].ToString().Trim(), //公开课案例评议类别名称
PubClassCaseSenator = objRow[convPubClassCaseSenate.PubClassCaseSenator] == DBNull.Value ? null : objRow[convPubClassCaseSenate.PubClassCaseSenator].ToString().Trim(), //公开课案例评议者
PubClassCaseSenateTitle = objRow[convPubClassCaseSenate.PubClassCaseSenateTitle] == DBNull.Value ? null : objRow[convPubClassCaseSenate.PubClassCaseSenateTitle].ToString().Trim(), //公开课案例评议标题
PubClassCaseSenateContent = objRow[convPubClassCaseSenate.PubClassCaseSenateContent] == DBNull.Value ? null : objRow[convPubClassCaseSenate.PubClassCaseSenateContent].ToString().Trim(), //公开课案例评议内容
PubClassCaseSenateDate = objRow[convPubClassCaseSenate.PubClassCaseSenateDate] == DBNull.Value ? null : objRow[convPubClassCaseSenate.PubClassCaseSenateDate].ToString().Trim(), //公开课案例评议日期
PubClassCaseSenateTime = objRow[convPubClassCaseSenate.PubClassCaseSenateTime] == DBNull.Value ? null : objRow[convPubClassCaseSenate.PubClassCaseSenateTime].ToString().Trim(), //公开课案例评议时间
SenateReadCount = objRow[convPubClassCaseSenate.SenateReadCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPubClassCaseSenate.SenateReadCount].ToString().Trim()), //评议阅读次数
ResourceOwner = objRow[convPubClassCaseSenate.ResourceOwner].ToString().Trim(), //上传者
ftpResourceOwner = objRow[convPubClassCaseSenate.ftpResourceOwner] == DBNull.Value ? null : objRow[convPubClassCaseSenate.ftpResourceOwner].ToString().Trim(), //Ftp资源拥有者
FileNewName = objRow[convPubClassCaseSenate.FileNewName] == DBNull.Value ? null : objRow[convPubClassCaseSenate.FileNewName].ToString().Trim(), //新文件名
FileOldName = objRow[convPubClassCaseSenate.FileOldName] == DBNull.Value ? null : objRow[convPubClassCaseSenate.FileOldName].ToString().Trim(), //旧文件名
FileSize = objRow[convPubClassCaseSenate.FileSize] == DBNull.Value ? null : objRow[convPubClassCaseSenate.FileSize].ToString().Trim(), //文件大小
FileType = objRow[convPubClassCaseSenate.FileType] == DBNull.Value ? null : objRow[convPubClassCaseSenate.FileType].ToString().Trim(), //文件类型
FileName = objRow[convPubClassCaseSenate.FileName] == DBNull.Value ? null : objRow[convPubClassCaseSenate.FileName].ToString().Trim(), //文件名称
SaveTime = objRow[convPubClassCaseSenate.SaveTime] == DBNull.Value ? null : objRow[convPubClassCaseSenate.SaveTime].ToString().Trim(), //创建时间
IsVisual = TransNullToBool(objRow[convPubClassCaseSenate.IsVisual].ToString().Trim()), //隐藏标志
IdTeachingPlan = objRow[convPubClassCaseSenate.IdTeachingPlan].ToString().Trim(), //教案流水号
IdFtpResource = objRow[convPubClassCaseSenate.IdFtpResource] == DBNull.Value ? null : objRow[convPubClassCaseSenate.IdFtpResource].ToString().Trim(), //FTP资源流水号
FileUpDate = objRow[convPubClassCaseSenate.FileUpDate] == DBNull.Value ? null : objRow[convPubClassCaseSenate.FileUpDate].ToString().Trim(), //创建日期
FileDirName = objRow[convPubClassCaseSenate.FileDirName] == DBNull.Value ? null : objRow[convPubClassCaseSenate.FileDirName].ToString().Trim(), //文件目录名
FileOriginalName = objRow[convPubClassCaseSenate.FileOriginalName] == DBNull.Value ? null : objRow[convPubClassCaseSenate.FileOriginalName].ToString().Trim(), //文件原名
FtpResourceID = objRow[convPubClassCaseSenate.FtpResourceID].ToString().Trim(), //FTP资源ID
FileRename = objRow[convPubClassCaseSenate.FileRename] == DBNull.Value ? null : objRow[convPubClassCaseSenate.FileRename].ToString().Trim(), //文件新名
FileUpTime = objRow[convPubClassCaseSenate.FileUpTime] == DBNull.Value ? null : objRow[convPubClassCaseSenate.FileUpTime].ToString().Trim(), //创建时间
SaveMode = TransNullToBool(objRow[convPubClassCaseSenate.SaveMode].ToString().Trim()), //文件存放方式
IdResourceType = objRow[convPubClassCaseSenate.IdResourceType].ToString().Trim(), //资源类型流水号
IdPubCaseType = objRow[convPubClassCaseSenate.IdPubCaseType].ToString().Trim(), //公开课案例类型流水号
ftpFileType = objRow[convPubClassCaseSenate.ftpFileType] == DBNull.Value ? null : objRow[convPubClassCaseSenate.ftpFileType].ToString().Trim(), //ftp文件类型
ftpFileSize = objRow[convPubClassCaseSenate.ftpFileSize] == DBNull.Value ? null : objRow[convPubClassCaseSenate.ftpFileSize].ToString().Trim(), //ftp文件大小
FileOriginName = objRow[convPubClassCaseSenate.FileOriginName] == DBNull.Value ? null : objRow[convPubClassCaseSenate.FileOriginName].ToString().Trim(), //原文件名
IdResource = objRow[convPubClassCaseSenate.IdResource].ToString().Trim(), //资源流水号
IdDiscipline = objRow[convPubClassCaseSenate.IdDiscipline] == DBNull.Value ? null : objRow[convPubClassCaseSenate.IdDiscipline].ToString().Trim(), //学科流水号
IdStudyLevel = objRow[convPubClassCaseSenate.IdStudyLevel] == DBNull.Value ? null : objRow[convPubClassCaseSenate.IdStudyLevel].ToString().Trim(), //id_StudyLevel
IdFile = objRow[convPubClassCaseSenate.IdFile] == DBNull.Value ? null : objRow[convPubClassCaseSenate.IdFile].ToString().Trim(), //文件流水号
IsVisible = TransNullToBool(objRow[convPubClassCaseSenate.IsVisible].ToString().Trim()), //是否显示
SaveDate = objRow[convPubClassCaseSenate.SaveDate] == DBNull.Value ? null : objRow[convPubClassCaseSenate.SaveDate].ToString().Trim(), //创建日期
IdPubClassCaseSenateClass = objRow[convPubClassCaseSenate.IdPubClassCaseSenateClass].ToString().Trim() //公开课案例评议类别流水号
};
objvPubClassCaseSenateEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvPubClassCaseSenateEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvPubClassCaseSenateDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvPubClassCaseSenateEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvPubClassCaseSenateEN objvPubClassCaseSenateEN = new clsvPubClassCaseSenateEN();
try
{
objvPubClassCaseSenateEN.IdPubClassCaseSenate = TransNullToInt(objRow[convPubClassCaseSenate.IdPubClassCaseSenate].ToString().Trim()); //公开课案例评议流水号
objvPubClassCaseSenateEN.IdPubClassCase = objRow[convPubClassCaseSenate.IdPubClassCase].ToString().Trim(); //案例流水号
objvPubClassCaseSenateEN.PubClassCaseID = objRow[convPubClassCaseSenate.PubClassCaseID].ToString().Trim(); //案例ID
objvPubClassCaseSenateEN.PubClassCaseName = objRow[convPubClassCaseSenate.PubClassCaseName].ToString().Trim(); //案例课题名称
objvPubClassCaseSenateEN.PubClassCaseDateIn = objRow[convPubClassCaseSenate.PubClassCaseDateIn] == DBNull.Value ? null : objRow[convPubClassCaseSenate.PubClassCaseDateIn].ToString().Trim(); //案例入库日期
objvPubClassCaseSenateEN.PubClassCaseTeachDate = objRow[convPubClassCaseSenate.PubClassCaseTeachDate] == DBNull.Value ? null : objRow[convPubClassCaseSenate.PubClassCaseTeachDate].ToString().Trim(); //案例授课日期
objvPubClassCaseSenateEN.PubClassCaseBG = objRow[convPubClassCaseSenate.PubClassCaseBG] == DBNull.Value ? null : objRow[convPubClassCaseSenate.PubClassCaseBG].ToString().Trim(); //案例背景资料
objvPubClassCaseSenateEN.PubClassCaseTheme = objRow[convPubClassCaseSenate.PubClassCaseTheme] == DBNull.Value ? null : objRow[convPubClassCaseSenate.PubClassCaseTheme].ToString().Trim(); //案例主题词
objvPubClassCaseSenateEN.PubClassCaseExecutor = objRow[convPubClassCaseSenate.PubClassCaseExecutor] == DBNull.Value ? null : objRow[convPubClassCaseSenate.PubClassCaseExecutor].ToString().Trim(); //案例执教者
objvPubClassCaseSenateEN.DisciplineID = objRow[convPubClassCaseSenate.DisciplineID] == DBNull.Value ? null : objRow[convPubClassCaseSenate.DisciplineID].ToString().Trim(); //学科ID
objvPubClassCaseSenateEN.DisciplineName = objRow[convPubClassCaseSenate.DisciplineName] == DBNull.Value ? null : objRow[convPubClassCaseSenate.DisciplineName].ToString().Trim(); //学科名称
objvPubClassCaseSenateEN.StudyLevelName = objRow[convPubClassCaseSenate.StudyLevelName] == DBNull.Value ? null : objRow[convPubClassCaseSenate.StudyLevelName].ToString().Trim(); //学段名称
objvPubClassCaseSenateEN.IsElite = TransNullToBool(objRow[convPubClassCaseSenate.IsElite].ToString().Trim()); //精华标志
objvPubClassCaseSenateEN.SubjectName = objRow[convPubClassCaseSenate.SubjectName].ToString().Trim(); //课题名称
objvPubClassCaseSenateEN.ResourceID = objRow[convPubClassCaseSenate.ResourceID].ToString().Trim(); //资源ID
objvPubClassCaseSenateEN.ResourceTypeID = objRow[convPubClassCaseSenate.ResourceTypeID].ToString().Trim(); //资源类型ID
objvPubClassCaseSenateEN.ResourceTypeName = objRow[convPubClassCaseSenate.ResourceTypeName].ToString().Trim(); //资源类型名称
objvPubClassCaseSenateEN.PubCaseTypeID = objRow[convPubClassCaseSenate.PubCaseTypeID].ToString().Trim(); //公开课案例类型ID
objvPubClassCaseSenateEN.PubCaseTypeName = objRow[convPubClassCaseSenate.PubCaseTypeName].ToString().Trim(); //公开课案例类型名称
objvPubClassCaseSenateEN.PubClassCaseSenateClassID = objRow[convPubClassCaseSenate.PubClassCaseSenateClassID] == DBNull.Value ? null : objRow[convPubClassCaseSenate.PubClassCaseSenateClassID].ToString().Trim(); //公开课案例评议类别ID
objvPubClassCaseSenateEN.PubClassCaseSenateClassName = objRow[convPubClassCaseSenate.PubClassCaseSenateClassName] == DBNull.Value ? null : objRow[convPubClassCaseSenate.PubClassCaseSenateClassName].ToString().Trim(); //公开课案例评议类别名称
objvPubClassCaseSenateEN.PubClassCaseSenator = objRow[convPubClassCaseSenate.PubClassCaseSenator] == DBNull.Value ? null : objRow[convPubClassCaseSenate.PubClassCaseSenator].ToString().Trim(); //公开课案例评议者
objvPubClassCaseSenateEN.PubClassCaseSenateTitle = objRow[convPubClassCaseSenate.PubClassCaseSenateTitle] == DBNull.Value ? null : objRow[convPubClassCaseSenate.PubClassCaseSenateTitle].ToString().Trim(); //公开课案例评议标题
objvPubClassCaseSenateEN.PubClassCaseSenateContent = objRow[convPubClassCaseSenate.PubClassCaseSenateContent] == DBNull.Value ? null : objRow[convPubClassCaseSenate.PubClassCaseSenateContent].ToString().Trim(); //公开课案例评议内容
objvPubClassCaseSenateEN.PubClassCaseSenateDate = objRow[convPubClassCaseSenate.PubClassCaseSenateDate] == DBNull.Value ? null : objRow[convPubClassCaseSenate.PubClassCaseSenateDate].ToString().Trim(); //公开课案例评议日期
objvPubClassCaseSenateEN.PubClassCaseSenateTime = objRow[convPubClassCaseSenate.PubClassCaseSenateTime] == DBNull.Value ? null : objRow[convPubClassCaseSenate.PubClassCaseSenateTime].ToString().Trim(); //公开课案例评议时间
objvPubClassCaseSenateEN.SenateReadCount = objRow[convPubClassCaseSenate.SenateReadCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPubClassCaseSenate.SenateReadCount].ToString().Trim()); //评议阅读次数
objvPubClassCaseSenateEN.ResourceOwner = objRow[convPubClassCaseSenate.ResourceOwner].ToString().Trim(); //上传者
objvPubClassCaseSenateEN.ftpResourceOwner = objRow[convPubClassCaseSenate.ftpResourceOwner] == DBNull.Value ? null : objRow[convPubClassCaseSenate.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvPubClassCaseSenateEN.FileNewName = objRow[convPubClassCaseSenate.FileNewName] == DBNull.Value ? null : objRow[convPubClassCaseSenate.FileNewName].ToString().Trim(); //新文件名
objvPubClassCaseSenateEN.FileOldName = objRow[convPubClassCaseSenate.FileOldName] == DBNull.Value ? null : objRow[convPubClassCaseSenate.FileOldName].ToString().Trim(); //旧文件名
objvPubClassCaseSenateEN.FileSize = objRow[convPubClassCaseSenate.FileSize] == DBNull.Value ? null : objRow[convPubClassCaseSenate.FileSize].ToString().Trim(); //文件大小
objvPubClassCaseSenateEN.FileType = objRow[convPubClassCaseSenate.FileType] == DBNull.Value ? null : objRow[convPubClassCaseSenate.FileType].ToString().Trim(); //文件类型
objvPubClassCaseSenateEN.FileName = objRow[convPubClassCaseSenate.FileName] == DBNull.Value ? null : objRow[convPubClassCaseSenate.FileName].ToString().Trim(); //文件名称
objvPubClassCaseSenateEN.SaveTime = objRow[convPubClassCaseSenate.SaveTime] == DBNull.Value ? null : objRow[convPubClassCaseSenate.SaveTime].ToString().Trim(); //创建时间
objvPubClassCaseSenateEN.IsVisual = TransNullToBool(objRow[convPubClassCaseSenate.IsVisual].ToString().Trim()); //隐藏标志
objvPubClassCaseSenateEN.IdTeachingPlan = objRow[convPubClassCaseSenate.IdTeachingPlan].ToString().Trim(); //教案流水号
objvPubClassCaseSenateEN.IdFtpResource = objRow[convPubClassCaseSenate.IdFtpResource] == DBNull.Value ? null : objRow[convPubClassCaseSenate.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvPubClassCaseSenateEN.FileUpDate = objRow[convPubClassCaseSenate.FileUpDate] == DBNull.Value ? null : objRow[convPubClassCaseSenate.FileUpDate].ToString().Trim(); //创建日期
objvPubClassCaseSenateEN.FileDirName = objRow[convPubClassCaseSenate.FileDirName] == DBNull.Value ? null : objRow[convPubClassCaseSenate.FileDirName].ToString().Trim(); //文件目录名
objvPubClassCaseSenateEN.FileOriginalName = objRow[convPubClassCaseSenate.FileOriginalName] == DBNull.Value ? null : objRow[convPubClassCaseSenate.FileOriginalName].ToString().Trim(); //文件原名
objvPubClassCaseSenateEN.FtpResourceID = objRow[convPubClassCaseSenate.FtpResourceID].ToString().Trim(); //FTP资源ID
objvPubClassCaseSenateEN.FileRename = objRow[convPubClassCaseSenate.FileRename] == DBNull.Value ? null : objRow[convPubClassCaseSenate.FileRename].ToString().Trim(); //文件新名
objvPubClassCaseSenateEN.FileUpTime = objRow[convPubClassCaseSenate.FileUpTime] == DBNull.Value ? null : objRow[convPubClassCaseSenate.FileUpTime].ToString().Trim(); //创建时间
objvPubClassCaseSenateEN.SaveMode = TransNullToBool(objRow[convPubClassCaseSenate.SaveMode].ToString().Trim()); //文件存放方式
objvPubClassCaseSenateEN.IdResourceType = objRow[convPubClassCaseSenate.IdResourceType].ToString().Trim(); //资源类型流水号
objvPubClassCaseSenateEN.IdPubCaseType = objRow[convPubClassCaseSenate.IdPubCaseType].ToString().Trim(); //公开课案例类型流水号
objvPubClassCaseSenateEN.ftpFileType = objRow[convPubClassCaseSenate.ftpFileType] == DBNull.Value ? null : objRow[convPubClassCaseSenate.ftpFileType].ToString().Trim(); //ftp文件类型
objvPubClassCaseSenateEN.ftpFileSize = objRow[convPubClassCaseSenate.ftpFileSize] == DBNull.Value ? null : objRow[convPubClassCaseSenate.ftpFileSize].ToString().Trim(); //ftp文件大小
objvPubClassCaseSenateEN.FileOriginName = objRow[convPubClassCaseSenate.FileOriginName] == DBNull.Value ? null : objRow[convPubClassCaseSenate.FileOriginName].ToString().Trim(); //原文件名
objvPubClassCaseSenateEN.IdResource = objRow[convPubClassCaseSenate.IdResource].ToString().Trim(); //资源流水号
objvPubClassCaseSenateEN.IdDiscipline = objRow[convPubClassCaseSenate.IdDiscipline] == DBNull.Value ? null : objRow[convPubClassCaseSenate.IdDiscipline].ToString().Trim(); //学科流水号
objvPubClassCaseSenateEN.IdStudyLevel = objRow[convPubClassCaseSenate.IdStudyLevel] == DBNull.Value ? null : objRow[convPubClassCaseSenate.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvPubClassCaseSenateEN.IdFile = objRow[convPubClassCaseSenate.IdFile] == DBNull.Value ? null : objRow[convPubClassCaseSenate.IdFile].ToString().Trim(); //文件流水号
objvPubClassCaseSenateEN.IsVisible = TransNullToBool(objRow[convPubClassCaseSenate.IsVisible].ToString().Trim()); //是否显示
objvPubClassCaseSenateEN.SaveDate = objRow[convPubClassCaseSenate.SaveDate] == DBNull.Value ? null : objRow[convPubClassCaseSenate.SaveDate].ToString().Trim(); //创建日期
objvPubClassCaseSenateEN.IdPubClassCaseSenateClass = objRow[convPubClassCaseSenate.IdPubClassCaseSenateClass].ToString().Trim(); //公开课案例评议类别流水号
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvPubClassCaseSenateDA: GetObjByDataRowvPubClassCaseSenate)", objException.Message));
}
objvPubClassCaseSenateEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvPubClassCaseSenateEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvPubClassCaseSenateEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvPubClassCaseSenateEN objvPubClassCaseSenateEN = new clsvPubClassCaseSenateEN();
try
{
objvPubClassCaseSenateEN.IdPubClassCaseSenate = TransNullToInt(objRow[convPubClassCaseSenate.IdPubClassCaseSenate].ToString().Trim()); //公开课案例评议流水号
objvPubClassCaseSenateEN.IdPubClassCase = objRow[convPubClassCaseSenate.IdPubClassCase].ToString().Trim(); //案例流水号
objvPubClassCaseSenateEN.PubClassCaseID = objRow[convPubClassCaseSenate.PubClassCaseID].ToString().Trim(); //案例ID
objvPubClassCaseSenateEN.PubClassCaseName = objRow[convPubClassCaseSenate.PubClassCaseName].ToString().Trim(); //案例课题名称
objvPubClassCaseSenateEN.PubClassCaseDateIn = objRow[convPubClassCaseSenate.PubClassCaseDateIn] == DBNull.Value ? null : objRow[convPubClassCaseSenate.PubClassCaseDateIn].ToString().Trim(); //案例入库日期
objvPubClassCaseSenateEN.PubClassCaseTeachDate = objRow[convPubClassCaseSenate.PubClassCaseTeachDate] == DBNull.Value ? null : objRow[convPubClassCaseSenate.PubClassCaseTeachDate].ToString().Trim(); //案例授课日期
objvPubClassCaseSenateEN.PubClassCaseBG = objRow[convPubClassCaseSenate.PubClassCaseBG] == DBNull.Value ? null : objRow[convPubClassCaseSenate.PubClassCaseBG].ToString().Trim(); //案例背景资料
objvPubClassCaseSenateEN.PubClassCaseTheme = objRow[convPubClassCaseSenate.PubClassCaseTheme] == DBNull.Value ? null : objRow[convPubClassCaseSenate.PubClassCaseTheme].ToString().Trim(); //案例主题词
objvPubClassCaseSenateEN.PubClassCaseExecutor = objRow[convPubClassCaseSenate.PubClassCaseExecutor] == DBNull.Value ? null : objRow[convPubClassCaseSenate.PubClassCaseExecutor].ToString().Trim(); //案例执教者
objvPubClassCaseSenateEN.DisciplineID = objRow[convPubClassCaseSenate.DisciplineID] == DBNull.Value ? null : objRow[convPubClassCaseSenate.DisciplineID].ToString().Trim(); //学科ID
objvPubClassCaseSenateEN.DisciplineName = objRow[convPubClassCaseSenate.DisciplineName] == DBNull.Value ? null : objRow[convPubClassCaseSenate.DisciplineName].ToString().Trim(); //学科名称
objvPubClassCaseSenateEN.StudyLevelName = objRow[convPubClassCaseSenate.StudyLevelName] == DBNull.Value ? null : objRow[convPubClassCaseSenate.StudyLevelName].ToString().Trim(); //学段名称
objvPubClassCaseSenateEN.IsElite = TransNullToBool(objRow[convPubClassCaseSenate.IsElite].ToString().Trim()); //精华标志
objvPubClassCaseSenateEN.SubjectName = objRow[convPubClassCaseSenate.SubjectName].ToString().Trim(); //课题名称
objvPubClassCaseSenateEN.ResourceID = objRow[convPubClassCaseSenate.ResourceID].ToString().Trim(); //资源ID
objvPubClassCaseSenateEN.ResourceTypeID = objRow[convPubClassCaseSenate.ResourceTypeID].ToString().Trim(); //资源类型ID
objvPubClassCaseSenateEN.ResourceTypeName = objRow[convPubClassCaseSenate.ResourceTypeName].ToString().Trim(); //资源类型名称
objvPubClassCaseSenateEN.PubCaseTypeID = objRow[convPubClassCaseSenate.PubCaseTypeID].ToString().Trim(); //公开课案例类型ID
objvPubClassCaseSenateEN.PubCaseTypeName = objRow[convPubClassCaseSenate.PubCaseTypeName].ToString().Trim(); //公开课案例类型名称
objvPubClassCaseSenateEN.PubClassCaseSenateClassID = objRow[convPubClassCaseSenate.PubClassCaseSenateClassID] == DBNull.Value ? null : objRow[convPubClassCaseSenate.PubClassCaseSenateClassID].ToString().Trim(); //公开课案例评议类别ID
objvPubClassCaseSenateEN.PubClassCaseSenateClassName = objRow[convPubClassCaseSenate.PubClassCaseSenateClassName] == DBNull.Value ? null : objRow[convPubClassCaseSenate.PubClassCaseSenateClassName].ToString().Trim(); //公开课案例评议类别名称
objvPubClassCaseSenateEN.PubClassCaseSenator = objRow[convPubClassCaseSenate.PubClassCaseSenator] == DBNull.Value ? null : objRow[convPubClassCaseSenate.PubClassCaseSenator].ToString().Trim(); //公开课案例评议者
objvPubClassCaseSenateEN.PubClassCaseSenateTitle = objRow[convPubClassCaseSenate.PubClassCaseSenateTitle] == DBNull.Value ? null : objRow[convPubClassCaseSenate.PubClassCaseSenateTitle].ToString().Trim(); //公开课案例评议标题
objvPubClassCaseSenateEN.PubClassCaseSenateContent = objRow[convPubClassCaseSenate.PubClassCaseSenateContent] == DBNull.Value ? null : objRow[convPubClassCaseSenate.PubClassCaseSenateContent].ToString().Trim(); //公开课案例评议内容
objvPubClassCaseSenateEN.PubClassCaseSenateDate = objRow[convPubClassCaseSenate.PubClassCaseSenateDate] == DBNull.Value ? null : objRow[convPubClassCaseSenate.PubClassCaseSenateDate].ToString().Trim(); //公开课案例评议日期
objvPubClassCaseSenateEN.PubClassCaseSenateTime = objRow[convPubClassCaseSenate.PubClassCaseSenateTime] == DBNull.Value ? null : objRow[convPubClassCaseSenate.PubClassCaseSenateTime].ToString().Trim(); //公开课案例评议时间
objvPubClassCaseSenateEN.SenateReadCount = objRow[convPubClassCaseSenate.SenateReadCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPubClassCaseSenate.SenateReadCount].ToString().Trim()); //评议阅读次数
objvPubClassCaseSenateEN.ResourceOwner = objRow[convPubClassCaseSenate.ResourceOwner].ToString().Trim(); //上传者
objvPubClassCaseSenateEN.ftpResourceOwner = objRow[convPubClassCaseSenate.ftpResourceOwner] == DBNull.Value ? null : objRow[convPubClassCaseSenate.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvPubClassCaseSenateEN.FileNewName = objRow[convPubClassCaseSenate.FileNewName] == DBNull.Value ? null : objRow[convPubClassCaseSenate.FileNewName].ToString().Trim(); //新文件名
objvPubClassCaseSenateEN.FileOldName = objRow[convPubClassCaseSenate.FileOldName] == DBNull.Value ? null : objRow[convPubClassCaseSenate.FileOldName].ToString().Trim(); //旧文件名
objvPubClassCaseSenateEN.FileSize = objRow[convPubClassCaseSenate.FileSize] == DBNull.Value ? null : objRow[convPubClassCaseSenate.FileSize].ToString().Trim(); //文件大小
objvPubClassCaseSenateEN.FileType = objRow[convPubClassCaseSenate.FileType] == DBNull.Value ? null : objRow[convPubClassCaseSenate.FileType].ToString().Trim(); //文件类型
objvPubClassCaseSenateEN.FileName = objRow[convPubClassCaseSenate.FileName] == DBNull.Value ? null : objRow[convPubClassCaseSenate.FileName].ToString().Trim(); //文件名称
objvPubClassCaseSenateEN.SaveTime = objRow[convPubClassCaseSenate.SaveTime] == DBNull.Value ? null : objRow[convPubClassCaseSenate.SaveTime].ToString().Trim(); //创建时间
objvPubClassCaseSenateEN.IsVisual = TransNullToBool(objRow[convPubClassCaseSenate.IsVisual].ToString().Trim()); //隐藏标志
objvPubClassCaseSenateEN.IdTeachingPlan = objRow[convPubClassCaseSenate.IdTeachingPlan].ToString().Trim(); //教案流水号
objvPubClassCaseSenateEN.IdFtpResource = objRow[convPubClassCaseSenate.IdFtpResource] == DBNull.Value ? null : objRow[convPubClassCaseSenate.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvPubClassCaseSenateEN.FileUpDate = objRow[convPubClassCaseSenate.FileUpDate] == DBNull.Value ? null : objRow[convPubClassCaseSenate.FileUpDate].ToString().Trim(); //创建日期
objvPubClassCaseSenateEN.FileDirName = objRow[convPubClassCaseSenate.FileDirName] == DBNull.Value ? null : objRow[convPubClassCaseSenate.FileDirName].ToString().Trim(); //文件目录名
objvPubClassCaseSenateEN.FileOriginalName = objRow[convPubClassCaseSenate.FileOriginalName] == DBNull.Value ? null : objRow[convPubClassCaseSenate.FileOriginalName].ToString().Trim(); //文件原名
objvPubClassCaseSenateEN.FtpResourceID = objRow[convPubClassCaseSenate.FtpResourceID].ToString().Trim(); //FTP资源ID
objvPubClassCaseSenateEN.FileRename = objRow[convPubClassCaseSenate.FileRename] == DBNull.Value ? null : objRow[convPubClassCaseSenate.FileRename].ToString().Trim(); //文件新名
objvPubClassCaseSenateEN.FileUpTime = objRow[convPubClassCaseSenate.FileUpTime] == DBNull.Value ? null : objRow[convPubClassCaseSenate.FileUpTime].ToString().Trim(); //创建时间
objvPubClassCaseSenateEN.SaveMode = TransNullToBool(objRow[convPubClassCaseSenate.SaveMode].ToString().Trim()); //文件存放方式
objvPubClassCaseSenateEN.IdResourceType = objRow[convPubClassCaseSenate.IdResourceType].ToString().Trim(); //资源类型流水号
objvPubClassCaseSenateEN.IdPubCaseType = objRow[convPubClassCaseSenate.IdPubCaseType].ToString().Trim(); //公开课案例类型流水号
objvPubClassCaseSenateEN.ftpFileType = objRow[convPubClassCaseSenate.ftpFileType] == DBNull.Value ? null : objRow[convPubClassCaseSenate.ftpFileType].ToString().Trim(); //ftp文件类型
objvPubClassCaseSenateEN.ftpFileSize = objRow[convPubClassCaseSenate.ftpFileSize] == DBNull.Value ? null : objRow[convPubClassCaseSenate.ftpFileSize].ToString().Trim(); //ftp文件大小
objvPubClassCaseSenateEN.FileOriginName = objRow[convPubClassCaseSenate.FileOriginName] == DBNull.Value ? null : objRow[convPubClassCaseSenate.FileOriginName].ToString().Trim(); //原文件名
objvPubClassCaseSenateEN.IdResource = objRow[convPubClassCaseSenate.IdResource].ToString().Trim(); //资源流水号
objvPubClassCaseSenateEN.IdDiscipline = objRow[convPubClassCaseSenate.IdDiscipline] == DBNull.Value ? null : objRow[convPubClassCaseSenate.IdDiscipline].ToString().Trim(); //学科流水号
objvPubClassCaseSenateEN.IdStudyLevel = objRow[convPubClassCaseSenate.IdStudyLevel] == DBNull.Value ? null : objRow[convPubClassCaseSenate.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvPubClassCaseSenateEN.IdFile = objRow[convPubClassCaseSenate.IdFile] == DBNull.Value ? null : objRow[convPubClassCaseSenate.IdFile].ToString().Trim(); //文件流水号
objvPubClassCaseSenateEN.IsVisible = TransNullToBool(objRow[convPubClassCaseSenate.IsVisible].ToString().Trim()); //是否显示
objvPubClassCaseSenateEN.SaveDate = objRow[convPubClassCaseSenate.SaveDate] == DBNull.Value ? null : objRow[convPubClassCaseSenate.SaveDate].ToString().Trim(); //创建日期
objvPubClassCaseSenateEN.IdPubClassCaseSenateClass = objRow[convPubClassCaseSenate.IdPubClassCaseSenateClass].ToString().Trim(); //公开课案例评议类别流水号
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvPubClassCaseSenateDA: GetObjByDataRow)", objException.Message));
}
objvPubClassCaseSenateEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvPubClassCaseSenateEN;
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
objSQL = clsvPubClassCaseSenateDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvPubClassCaseSenateEN._CurrTabName, convPubClassCaseSenate.IdPubClassCaseSenate, 8, "");
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
objSQL = clsvPubClassCaseSenateDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvPubClassCaseSenateEN._CurrTabName, convPubClassCaseSenate.IdPubClassCaseSenate, 8, strPrefix);
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
 objSQL = clsvPubClassCaseSenateDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select IdPubClassCaseSenate from vPubClassCaseSenate where " + strCondition;
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
 objSQL = clsvPubClassCaseSenateDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select IdPubClassCaseSenate from vPubClassCaseSenate where " + strCondition;
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
 /// <param name = "lngIdPubClassCaseSenate">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(long lngIdPubClassCaseSenate)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPubClassCaseSenateDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vPubClassCaseSenate", "IdPubClassCaseSenate = " + ""+ lngIdPubClassCaseSenate+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvPubClassCaseSenateDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPubClassCaseSenateDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vPubClassCaseSenate", strCondition))
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
objSQL = clsvPubClassCaseSenateDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vPubClassCaseSenate");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvPubClassCaseSenateENS">源对象</param>
 /// <param name = "objvPubClassCaseSenateENT">目标对象</param>
public void CopyTo(clsvPubClassCaseSenateEN objvPubClassCaseSenateENS, clsvPubClassCaseSenateEN objvPubClassCaseSenateENT)
{
objvPubClassCaseSenateENT.IdPubClassCaseSenate = objvPubClassCaseSenateENS.IdPubClassCaseSenate; //公开课案例评议流水号
objvPubClassCaseSenateENT.IdPubClassCase = objvPubClassCaseSenateENS.IdPubClassCase; //案例流水号
objvPubClassCaseSenateENT.PubClassCaseID = objvPubClassCaseSenateENS.PubClassCaseID; //案例ID
objvPubClassCaseSenateENT.PubClassCaseName = objvPubClassCaseSenateENS.PubClassCaseName; //案例课题名称
objvPubClassCaseSenateENT.PubClassCaseDateIn = objvPubClassCaseSenateENS.PubClassCaseDateIn; //案例入库日期
objvPubClassCaseSenateENT.PubClassCaseTeachDate = objvPubClassCaseSenateENS.PubClassCaseTeachDate; //案例授课日期
objvPubClassCaseSenateENT.PubClassCaseBG = objvPubClassCaseSenateENS.PubClassCaseBG; //案例背景资料
objvPubClassCaseSenateENT.PubClassCaseTheme = objvPubClassCaseSenateENS.PubClassCaseTheme; //案例主题词
objvPubClassCaseSenateENT.PubClassCaseExecutor = objvPubClassCaseSenateENS.PubClassCaseExecutor; //案例执教者
objvPubClassCaseSenateENT.DisciplineID = objvPubClassCaseSenateENS.DisciplineID; //学科ID
objvPubClassCaseSenateENT.DisciplineName = objvPubClassCaseSenateENS.DisciplineName; //学科名称
objvPubClassCaseSenateENT.StudyLevelName = objvPubClassCaseSenateENS.StudyLevelName; //学段名称
objvPubClassCaseSenateENT.IsElite = objvPubClassCaseSenateENS.IsElite; //精华标志
objvPubClassCaseSenateENT.SubjectName = objvPubClassCaseSenateENS.SubjectName; //课题名称
objvPubClassCaseSenateENT.ResourceID = objvPubClassCaseSenateENS.ResourceID; //资源ID
objvPubClassCaseSenateENT.ResourceTypeID = objvPubClassCaseSenateENS.ResourceTypeID; //资源类型ID
objvPubClassCaseSenateENT.ResourceTypeName = objvPubClassCaseSenateENS.ResourceTypeName; //资源类型名称
objvPubClassCaseSenateENT.PubCaseTypeID = objvPubClassCaseSenateENS.PubCaseTypeID; //公开课案例类型ID
objvPubClassCaseSenateENT.PubCaseTypeName = objvPubClassCaseSenateENS.PubCaseTypeName; //公开课案例类型名称
objvPubClassCaseSenateENT.PubClassCaseSenateClassID = objvPubClassCaseSenateENS.PubClassCaseSenateClassID; //公开课案例评议类别ID
objvPubClassCaseSenateENT.PubClassCaseSenateClassName = objvPubClassCaseSenateENS.PubClassCaseSenateClassName; //公开课案例评议类别名称
objvPubClassCaseSenateENT.PubClassCaseSenator = objvPubClassCaseSenateENS.PubClassCaseSenator; //公开课案例评议者
objvPubClassCaseSenateENT.PubClassCaseSenateTitle = objvPubClassCaseSenateENS.PubClassCaseSenateTitle; //公开课案例评议标题
objvPubClassCaseSenateENT.PubClassCaseSenateContent = objvPubClassCaseSenateENS.PubClassCaseSenateContent; //公开课案例评议内容
objvPubClassCaseSenateENT.PubClassCaseSenateDate = objvPubClassCaseSenateENS.PubClassCaseSenateDate; //公开课案例评议日期
objvPubClassCaseSenateENT.PubClassCaseSenateTime = objvPubClassCaseSenateENS.PubClassCaseSenateTime; //公开课案例评议时间
objvPubClassCaseSenateENT.SenateReadCount = objvPubClassCaseSenateENS.SenateReadCount; //评议阅读次数
objvPubClassCaseSenateENT.ResourceOwner = objvPubClassCaseSenateENS.ResourceOwner; //上传者
objvPubClassCaseSenateENT.ftpResourceOwner = objvPubClassCaseSenateENS.ftpResourceOwner; //Ftp资源拥有者
objvPubClassCaseSenateENT.FileNewName = objvPubClassCaseSenateENS.FileNewName; //新文件名
objvPubClassCaseSenateENT.FileOldName = objvPubClassCaseSenateENS.FileOldName; //旧文件名
objvPubClassCaseSenateENT.FileSize = objvPubClassCaseSenateENS.FileSize; //文件大小
objvPubClassCaseSenateENT.FileType = objvPubClassCaseSenateENS.FileType; //文件类型
objvPubClassCaseSenateENT.FileName = objvPubClassCaseSenateENS.FileName; //文件名称
objvPubClassCaseSenateENT.SaveTime = objvPubClassCaseSenateENS.SaveTime; //创建时间
objvPubClassCaseSenateENT.IsVisual = objvPubClassCaseSenateENS.IsVisual; //隐藏标志
objvPubClassCaseSenateENT.IdTeachingPlan = objvPubClassCaseSenateENS.IdTeachingPlan; //教案流水号
objvPubClassCaseSenateENT.IdFtpResource = objvPubClassCaseSenateENS.IdFtpResource; //FTP资源流水号
objvPubClassCaseSenateENT.FileUpDate = objvPubClassCaseSenateENS.FileUpDate; //创建日期
objvPubClassCaseSenateENT.FileDirName = objvPubClassCaseSenateENS.FileDirName; //文件目录名
objvPubClassCaseSenateENT.FileOriginalName = objvPubClassCaseSenateENS.FileOriginalName; //文件原名
objvPubClassCaseSenateENT.FtpResourceID = objvPubClassCaseSenateENS.FtpResourceID; //FTP资源ID
objvPubClassCaseSenateENT.FileRename = objvPubClassCaseSenateENS.FileRename; //文件新名
objvPubClassCaseSenateENT.FileUpTime = objvPubClassCaseSenateENS.FileUpTime; //创建时间
objvPubClassCaseSenateENT.SaveMode = objvPubClassCaseSenateENS.SaveMode; //文件存放方式
objvPubClassCaseSenateENT.IdResourceType = objvPubClassCaseSenateENS.IdResourceType; //资源类型流水号
objvPubClassCaseSenateENT.IdPubCaseType = objvPubClassCaseSenateENS.IdPubCaseType; //公开课案例类型流水号
objvPubClassCaseSenateENT.ftpFileType = objvPubClassCaseSenateENS.ftpFileType; //ftp文件类型
objvPubClassCaseSenateENT.ftpFileSize = objvPubClassCaseSenateENS.ftpFileSize; //ftp文件大小
objvPubClassCaseSenateENT.FileOriginName = objvPubClassCaseSenateENS.FileOriginName; //原文件名
objvPubClassCaseSenateENT.IdResource = objvPubClassCaseSenateENS.IdResource; //资源流水号
objvPubClassCaseSenateENT.IdDiscipline = objvPubClassCaseSenateENS.IdDiscipline; //学科流水号
objvPubClassCaseSenateENT.IdStudyLevel = objvPubClassCaseSenateENS.IdStudyLevel; //id_StudyLevel
objvPubClassCaseSenateENT.IdFile = objvPubClassCaseSenateENS.IdFile; //文件流水号
objvPubClassCaseSenateENT.IsVisible = objvPubClassCaseSenateENS.IsVisible; //是否显示
objvPubClassCaseSenateENT.SaveDate = objvPubClassCaseSenateENS.SaveDate; //创建日期
objvPubClassCaseSenateENT.IdPubClassCaseSenateClass = objvPubClassCaseSenateENS.IdPubClassCaseSenateClass; //公开课案例评议类别流水号
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvPubClassCaseSenateEN objvPubClassCaseSenateEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvPubClassCaseSenateEN.IdPubClassCase, 8, convPubClassCaseSenate.IdPubClassCase);
clsCheckSql.CheckFieldLen(objvPubClassCaseSenateEN.PubClassCaseID, 8, convPubClassCaseSenate.PubClassCaseID);
clsCheckSql.CheckFieldLen(objvPubClassCaseSenateEN.PubClassCaseName, 200, convPubClassCaseSenate.PubClassCaseName);
clsCheckSql.CheckFieldLen(objvPubClassCaseSenateEN.PubClassCaseDateIn, 8, convPubClassCaseSenate.PubClassCaseDateIn);
clsCheckSql.CheckFieldLen(objvPubClassCaseSenateEN.PubClassCaseTeachDate, 8, convPubClassCaseSenate.PubClassCaseTeachDate);
clsCheckSql.CheckFieldLen(objvPubClassCaseSenateEN.PubClassCaseTheme, 500, convPubClassCaseSenate.PubClassCaseTheme);
clsCheckSql.CheckFieldLen(objvPubClassCaseSenateEN.PubClassCaseExecutor, 50, convPubClassCaseSenate.PubClassCaseExecutor);
clsCheckSql.CheckFieldLen(objvPubClassCaseSenateEN.DisciplineID, 4, convPubClassCaseSenate.DisciplineID);
clsCheckSql.CheckFieldLen(objvPubClassCaseSenateEN.DisciplineName, 50, convPubClassCaseSenate.DisciplineName);
clsCheckSql.CheckFieldLen(objvPubClassCaseSenateEN.StudyLevelName, 50, convPubClassCaseSenate.StudyLevelName);
clsCheckSql.CheckFieldLen(objvPubClassCaseSenateEN.SubjectName, 200, convPubClassCaseSenate.SubjectName);
clsCheckSql.CheckFieldLen(objvPubClassCaseSenateEN.ResourceID, 8, convPubClassCaseSenate.ResourceID);
clsCheckSql.CheckFieldLen(objvPubClassCaseSenateEN.ResourceTypeID, 4, convPubClassCaseSenate.ResourceTypeID);
clsCheckSql.CheckFieldLen(objvPubClassCaseSenateEN.ResourceTypeName, 50, convPubClassCaseSenate.ResourceTypeName);
clsCheckSql.CheckFieldLen(objvPubClassCaseSenateEN.PubCaseTypeID, 4, convPubClassCaseSenate.PubCaseTypeID);
clsCheckSql.CheckFieldLen(objvPubClassCaseSenateEN.PubCaseTypeName, 50, convPubClassCaseSenate.PubCaseTypeName);
clsCheckSql.CheckFieldLen(objvPubClassCaseSenateEN.PubClassCaseSenateClassID, 4, convPubClassCaseSenate.PubClassCaseSenateClassID);
clsCheckSql.CheckFieldLen(objvPubClassCaseSenateEN.PubClassCaseSenateClassName, 50, convPubClassCaseSenate.PubClassCaseSenateClassName);
clsCheckSql.CheckFieldLen(objvPubClassCaseSenateEN.PubClassCaseSenator, 50, convPubClassCaseSenate.PubClassCaseSenator);
clsCheckSql.CheckFieldLen(objvPubClassCaseSenateEN.PubClassCaseSenateTitle, 200, convPubClassCaseSenate.PubClassCaseSenateTitle);
clsCheckSql.CheckFieldLen(objvPubClassCaseSenateEN.PubClassCaseSenateContent, 8000, convPubClassCaseSenate.PubClassCaseSenateContent);
clsCheckSql.CheckFieldLen(objvPubClassCaseSenateEN.PubClassCaseSenateDate, 8, convPubClassCaseSenate.PubClassCaseSenateDate);
clsCheckSql.CheckFieldLen(objvPubClassCaseSenateEN.PubClassCaseSenateTime, 6, convPubClassCaseSenate.PubClassCaseSenateTime);
clsCheckSql.CheckFieldLen(objvPubClassCaseSenateEN.ResourceOwner, 50, convPubClassCaseSenate.ResourceOwner);
clsCheckSql.CheckFieldLen(objvPubClassCaseSenateEN.ftpResourceOwner, 50, convPubClassCaseSenate.ftpResourceOwner);
clsCheckSql.CheckFieldLen(objvPubClassCaseSenateEN.FileNewName, 530, convPubClassCaseSenate.FileNewName);
clsCheckSql.CheckFieldLen(objvPubClassCaseSenateEN.FileOldName, 530, convPubClassCaseSenate.FileOldName);
clsCheckSql.CheckFieldLen(objvPubClassCaseSenateEN.FileSize, 50, convPubClassCaseSenate.FileSize);
clsCheckSql.CheckFieldLen(objvPubClassCaseSenateEN.FileType, 30, convPubClassCaseSenate.FileType);
clsCheckSql.CheckFieldLen(objvPubClassCaseSenateEN.FileName, 500, convPubClassCaseSenate.FileName);
clsCheckSql.CheckFieldLen(objvPubClassCaseSenateEN.SaveTime, 6, convPubClassCaseSenate.SaveTime);
clsCheckSql.CheckFieldLen(objvPubClassCaseSenateEN.IdTeachingPlan, 8, convPubClassCaseSenate.IdTeachingPlan);
clsCheckSql.CheckFieldLen(objvPubClassCaseSenateEN.IdFtpResource, 8, convPubClassCaseSenate.IdFtpResource);
clsCheckSql.CheckFieldLen(objvPubClassCaseSenateEN.FileUpDate, 8, convPubClassCaseSenate.FileUpDate);
clsCheckSql.CheckFieldLen(objvPubClassCaseSenateEN.FileDirName, 200, convPubClassCaseSenate.FileDirName);
clsCheckSql.CheckFieldLen(objvPubClassCaseSenateEN.FileOriginalName, 200, convPubClassCaseSenate.FileOriginalName);
clsCheckSql.CheckFieldLen(objvPubClassCaseSenateEN.FtpResourceID, 8, convPubClassCaseSenate.FtpResourceID);
clsCheckSql.CheckFieldLen(objvPubClassCaseSenateEN.FileRename, 200, convPubClassCaseSenate.FileRename);
clsCheckSql.CheckFieldLen(objvPubClassCaseSenateEN.FileUpTime, 6, convPubClassCaseSenate.FileUpTime);
clsCheckSql.CheckFieldLen(objvPubClassCaseSenateEN.IdResourceType, 4, convPubClassCaseSenate.IdResourceType);
clsCheckSql.CheckFieldLen(objvPubClassCaseSenateEN.IdPubCaseType, 4, convPubClassCaseSenate.IdPubCaseType);
clsCheckSql.CheckFieldLen(objvPubClassCaseSenateEN.ftpFileType, 30, convPubClassCaseSenate.ftpFileType);
clsCheckSql.CheckFieldLen(objvPubClassCaseSenateEN.ftpFileSize, 50, convPubClassCaseSenate.ftpFileSize);
clsCheckSql.CheckFieldLen(objvPubClassCaseSenateEN.FileOriginName, 500, convPubClassCaseSenate.FileOriginName);
clsCheckSql.CheckFieldLen(objvPubClassCaseSenateEN.IdResource, 8, convPubClassCaseSenate.IdResource);
clsCheckSql.CheckFieldLen(objvPubClassCaseSenateEN.IdDiscipline, 4, convPubClassCaseSenate.IdDiscipline);
clsCheckSql.CheckFieldLen(objvPubClassCaseSenateEN.IdStudyLevel, 4, convPubClassCaseSenate.IdStudyLevel);
clsCheckSql.CheckFieldLen(objvPubClassCaseSenateEN.IdFile, 8, convPubClassCaseSenate.IdFile);
clsCheckSql.CheckFieldLen(objvPubClassCaseSenateEN.SaveDate, 8, convPubClassCaseSenate.SaveDate);
clsCheckSql.CheckFieldLen(objvPubClassCaseSenateEN.IdPubClassCaseSenateClass, 4, convPubClassCaseSenate.IdPubClassCaseSenateClass);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvPubClassCaseSenateEN.IdPubClassCase, convPubClassCaseSenate.IdPubClassCase);
clsCheckSql.CheckSqlInjection4Field(objvPubClassCaseSenateEN.PubClassCaseID, convPubClassCaseSenate.PubClassCaseID);
clsCheckSql.CheckSqlInjection4Field(objvPubClassCaseSenateEN.PubClassCaseName, convPubClassCaseSenate.PubClassCaseName);
clsCheckSql.CheckSqlInjection4Field(objvPubClassCaseSenateEN.PubClassCaseDateIn, convPubClassCaseSenate.PubClassCaseDateIn);
clsCheckSql.CheckSqlInjection4Field(objvPubClassCaseSenateEN.PubClassCaseTeachDate, convPubClassCaseSenate.PubClassCaseTeachDate);
clsCheckSql.CheckSqlInjection4Field(objvPubClassCaseSenateEN.PubClassCaseTheme, convPubClassCaseSenate.PubClassCaseTheme);
clsCheckSql.CheckSqlInjection4Field(objvPubClassCaseSenateEN.PubClassCaseExecutor, convPubClassCaseSenate.PubClassCaseExecutor);
clsCheckSql.CheckSqlInjection4Field(objvPubClassCaseSenateEN.DisciplineID, convPubClassCaseSenate.DisciplineID);
clsCheckSql.CheckSqlInjection4Field(objvPubClassCaseSenateEN.DisciplineName, convPubClassCaseSenate.DisciplineName);
clsCheckSql.CheckSqlInjection4Field(objvPubClassCaseSenateEN.StudyLevelName, convPubClassCaseSenate.StudyLevelName);
clsCheckSql.CheckSqlInjection4Field(objvPubClassCaseSenateEN.SubjectName, convPubClassCaseSenate.SubjectName);
clsCheckSql.CheckSqlInjection4Field(objvPubClassCaseSenateEN.ResourceID, convPubClassCaseSenate.ResourceID);
clsCheckSql.CheckSqlInjection4Field(objvPubClassCaseSenateEN.ResourceTypeID, convPubClassCaseSenate.ResourceTypeID);
clsCheckSql.CheckSqlInjection4Field(objvPubClassCaseSenateEN.ResourceTypeName, convPubClassCaseSenate.ResourceTypeName);
clsCheckSql.CheckSqlInjection4Field(objvPubClassCaseSenateEN.PubCaseTypeID, convPubClassCaseSenate.PubCaseTypeID);
clsCheckSql.CheckSqlInjection4Field(objvPubClassCaseSenateEN.PubCaseTypeName, convPubClassCaseSenate.PubCaseTypeName);
clsCheckSql.CheckSqlInjection4Field(objvPubClassCaseSenateEN.PubClassCaseSenateClassID, convPubClassCaseSenate.PubClassCaseSenateClassID);
clsCheckSql.CheckSqlInjection4Field(objvPubClassCaseSenateEN.PubClassCaseSenateClassName, convPubClassCaseSenate.PubClassCaseSenateClassName);
clsCheckSql.CheckSqlInjection4Field(objvPubClassCaseSenateEN.PubClassCaseSenator, convPubClassCaseSenate.PubClassCaseSenator);
clsCheckSql.CheckSqlInjection4Field(objvPubClassCaseSenateEN.PubClassCaseSenateTitle, convPubClassCaseSenate.PubClassCaseSenateTitle);
clsCheckSql.CheckSqlInjection4Field(objvPubClassCaseSenateEN.PubClassCaseSenateContent, convPubClassCaseSenate.PubClassCaseSenateContent);
clsCheckSql.CheckSqlInjection4Field(objvPubClassCaseSenateEN.PubClassCaseSenateDate, convPubClassCaseSenate.PubClassCaseSenateDate);
clsCheckSql.CheckSqlInjection4Field(objvPubClassCaseSenateEN.PubClassCaseSenateTime, convPubClassCaseSenate.PubClassCaseSenateTime);
clsCheckSql.CheckSqlInjection4Field(objvPubClassCaseSenateEN.ResourceOwner, convPubClassCaseSenate.ResourceOwner);
clsCheckSql.CheckSqlInjection4Field(objvPubClassCaseSenateEN.ftpResourceOwner, convPubClassCaseSenate.ftpResourceOwner);
clsCheckSql.CheckSqlInjection4Field(objvPubClassCaseSenateEN.FileNewName, convPubClassCaseSenate.FileNewName);
clsCheckSql.CheckSqlInjection4Field(objvPubClassCaseSenateEN.FileOldName, convPubClassCaseSenate.FileOldName);
clsCheckSql.CheckSqlInjection4Field(objvPubClassCaseSenateEN.FileSize, convPubClassCaseSenate.FileSize);
clsCheckSql.CheckSqlInjection4Field(objvPubClassCaseSenateEN.FileType, convPubClassCaseSenate.FileType);
clsCheckSql.CheckSqlInjection4Field(objvPubClassCaseSenateEN.FileName, convPubClassCaseSenate.FileName);
clsCheckSql.CheckSqlInjection4Field(objvPubClassCaseSenateEN.SaveTime, convPubClassCaseSenate.SaveTime);
clsCheckSql.CheckSqlInjection4Field(objvPubClassCaseSenateEN.IdTeachingPlan, convPubClassCaseSenate.IdTeachingPlan);
clsCheckSql.CheckSqlInjection4Field(objvPubClassCaseSenateEN.IdFtpResource, convPubClassCaseSenate.IdFtpResource);
clsCheckSql.CheckSqlInjection4Field(objvPubClassCaseSenateEN.FileUpDate, convPubClassCaseSenate.FileUpDate);
clsCheckSql.CheckSqlInjection4Field(objvPubClassCaseSenateEN.FileDirName, convPubClassCaseSenate.FileDirName);
clsCheckSql.CheckSqlInjection4Field(objvPubClassCaseSenateEN.FileOriginalName, convPubClassCaseSenate.FileOriginalName);
clsCheckSql.CheckSqlInjection4Field(objvPubClassCaseSenateEN.FtpResourceID, convPubClassCaseSenate.FtpResourceID);
clsCheckSql.CheckSqlInjection4Field(objvPubClassCaseSenateEN.FileRename, convPubClassCaseSenate.FileRename);
clsCheckSql.CheckSqlInjection4Field(objvPubClassCaseSenateEN.FileUpTime, convPubClassCaseSenate.FileUpTime);
clsCheckSql.CheckSqlInjection4Field(objvPubClassCaseSenateEN.IdResourceType, convPubClassCaseSenate.IdResourceType);
clsCheckSql.CheckSqlInjection4Field(objvPubClassCaseSenateEN.IdPubCaseType, convPubClassCaseSenate.IdPubCaseType);
clsCheckSql.CheckSqlInjection4Field(objvPubClassCaseSenateEN.ftpFileType, convPubClassCaseSenate.ftpFileType);
clsCheckSql.CheckSqlInjection4Field(objvPubClassCaseSenateEN.ftpFileSize, convPubClassCaseSenate.ftpFileSize);
clsCheckSql.CheckSqlInjection4Field(objvPubClassCaseSenateEN.FileOriginName, convPubClassCaseSenate.FileOriginName);
clsCheckSql.CheckSqlInjection4Field(objvPubClassCaseSenateEN.IdResource, convPubClassCaseSenate.IdResource);
clsCheckSql.CheckSqlInjection4Field(objvPubClassCaseSenateEN.IdDiscipline, convPubClassCaseSenate.IdDiscipline);
clsCheckSql.CheckSqlInjection4Field(objvPubClassCaseSenateEN.IdStudyLevel, convPubClassCaseSenate.IdStudyLevel);
clsCheckSql.CheckSqlInjection4Field(objvPubClassCaseSenateEN.IdFile, convPubClassCaseSenate.IdFile);
clsCheckSql.CheckSqlInjection4Field(objvPubClassCaseSenateEN.SaveDate, convPubClassCaseSenate.SaveDate);
clsCheckSql.CheckSqlInjection4Field(objvPubClassCaseSenateEN.IdPubClassCaseSenateClass, convPubClassCaseSenate.IdPubClassCaseSenateClass);
//检查外键字段长度
 objvPubClassCaseSenateEN._IsCheckProperty = true;
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
 objSQL = clsvPubClassCaseSenateDA.GetSpecSQLObj();
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
 objSQL = clsvPubClassCaseSenateDA.GetSpecSQLObj();
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
 objSQL = clsvPubClassCaseSenateDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvPubClassCaseSenateEN._CurrTabName);
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
 objSQL = clsvPubClassCaseSenateDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvPubClassCaseSenateEN._CurrTabName, strCondition);
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
 objSQL = clsvPubClassCaseSenateDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}