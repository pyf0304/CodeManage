
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvMicroteachCaseSiteSenateDA
 表名:vMicroteachCaseSiteSenate(01120457)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:48:02
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:微格教学评议(MicroTeachSenate)
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
 /// v微格教学现场评议(vMicroteachCaseSiteSenate)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvMicroteachCaseSiteSenateDA : clsCommBase4DA
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
 return clsvMicroteachCaseSiteSenateEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvMicroteachCaseSiteSenateEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvMicroteachCaseSiteSenateEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvMicroteachCaseSiteSenateEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvMicroteachCaseSiteSenateEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvMicroteachCaseSiteSenateDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMicroteachCaseSiteSenateDA.GetSpecSQLObj();
strSQL = "Select * from vMicroteachCaseSiteSenate where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vMicroteachCaseSiteSenate(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvMicroteachCaseSiteSenateDA: GetDataTable_vMicroteachCaseSiteSenate)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMicroteachCaseSiteSenateDA.GetSpecSQLObj();
strSQL = "Select * from vMicroteachCaseSiteSenate where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvMicroteachCaseSiteSenateDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMicroteachCaseSiteSenateDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvMicroteachCaseSiteSenateDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMicroteachCaseSiteSenateDA.GetSpecSQLObj();
strSQL = "Select * from vMicroteachCaseSiteSenate where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvMicroteachCaseSiteSenateDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMicroteachCaseSiteSenateDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvMicroteachCaseSiteSenateDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMicroteachCaseSiteSenateDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vMicroteachCaseSiteSenate where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vMicroteachCaseSiteSenate where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvMicroteachCaseSiteSenateDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMicroteachCaseSiteSenateDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vMicroteachCaseSiteSenate where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvMicroteachCaseSiteSenateDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMicroteachCaseSiteSenateDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vMicroteachCaseSiteSenate.* from vMicroteachCaseSiteSenate Left Join {1} on {2} where {3} and vMicroteachCaseSiteSenate.IdMicroteachCaseSiteSenate not in (Select top {5} vMicroteachCaseSiteSenate.IdMicroteachCaseSiteSenate from vMicroteachCaseSiteSenate Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vMicroteachCaseSiteSenate where {1} and IdMicroteachCaseSiteSenate not in (Select top {2} IdMicroteachCaseSiteSenate from vMicroteachCaseSiteSenate where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vMicroteachCaseSiteSenate where {1} and IdMicroteachCaseSiteSenate not in (Select top {3} IdMicroteachCaseSiteSenate from vMicroteachCaseSiteSenate where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvMicroteachCaseSiteSenateDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMicroteachCaseSiteSenateDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vMicroteachCaseSiteSenate.* from vMicroteachCaseSiteSenate Left Join {1} on {2} where {3} and vMicroteachCaseSiteSenate.IdMicroteachCaseSiteSenate not in (Select top {5} vMicroteachCaseSiteSenate.IdMicroteachCaseSiteSenate from vMicroteachCaseSiteSenate Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vMicroteachCaseSiteSenate where {1} and IdMicroteachCaseSiteSenate not in (Select top {2} IdMicroteachCaseSiteSenate from vMicroteachCaseSiteSenate where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vMicroteachCaseSiteSenate where {1} and IdMicroteachCaseSiteSenate not in (Select top {3} IdMicroteachCaseSiteSenate from vMicroteachCaseSiteSenate where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvMicroteachCaseSiteSenateEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvMicroteachCaseSiteSenateDA:GetObjLst)", objException.Message));
}
List<clsvMicroteachCaseSiteSenateEN> arrObjLst = new List<clsvMicroteachCaseSiteSenateEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMicroteachCaseSiteSenateDA.GetSpecSQLObj();
strSQL = "Select * from vMicroteachCaseSiteSenate where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvMicroteachCaseSiteSenateEN objvMicroteachCaseSiteSenateEN = new clsvMicroteachCaseSiteSenateEN();
try
{
objvMicroteachCaseSiteSenateEN.IdMicroteachCaseSiteSenate = TransNullToInt(objRow[convMicroteachCaseSiteSenate.IdMicroteachCaseSiteSenate].ToString().Trim()); //微格现场评议流水号
objvMicroteachCaseSiteSenateEN.FuncModuleId = objRow[convMicroteachCaseSiteSenate.FuncModuleId].ToString().Trim(); //功能模块Id
objvMicroteachCaseSiteSenateEN.FuncModuleName = objRow[convMicroteachCaseSiteSenate.FuncModuleName] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.FuncModuleName].ToString().Trim(); //功能模块名称
objvMicroteachCaseSiteSenateEN.IdMicroteachCase = objRow[convMicroteachCaseSiteSenate.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvMicroteachCaseSiteSenateEN.MicroteachCaseID = objRow[convMicroteachCaseSiteSenate.MicroteachCaseID].ToString().Trim(); //微格教学案例ID
objvMicroteachCaseSiteSenateEN.MicroteachCaseName = objRow[convMicroteachCaseSiteSenate.MicroteachCaseName].ToString().Trim(); //微格教学案例名称
objvMicroteachCaseSiteSenateEN.MicroteachCaseTheme = objRow[convMicroteachCaseSiteSenate.MicroteachCaseTheme] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.MicroteachCaseTheme].ToString().Trim(); //微格教学案例主题词
objvMicroteachCaseSiteSenateEN.MicroteachCaseDate = objRow[convMicroteachCaseSiteSenate.MicroteachCaseDate] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.MicroteachCaseDate].ToString().Trim(); //微格教学日期
objvMicroteachCaseSiteSenateEN.MicroteachCaseTime = objRow[convMicroteachCaseSiteSenate.MicroteachCaseTime] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.MicroteachCaseTime].ToString().Trim(); //微格教学时间
objvMicroteachCaseSiteSenateEN.MicroteachCaseDateIn = objRow[convMicroteachCaseSiteSenate.MicroteachCaseDateIn] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.MicroteachCaseDateIn].ToString().Trim(); //案例入库日期
objvMicroteachCaseSiteSenateEN.IdStudyLevel = objRow[convMicroteachCaseSiteSenate.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvMicroteachCaseSiteSenateEN.StudyLevelName = objRow[convMicroteachCaseSiteSenate.StudyLevelName].ToString().Trim(); //学段名称
objvMicroteachCaseSiteSenateEN.IdTeachingPlan = objRow[convMicroteachCaseSiteSenate.IdTeachingPlan].ToString().Trim(); //教案流水号
objvMicroteachCaseSiteSenateEN.MicroTeachCaseTimeIn = objRow[convMicroteachCaseSiteSenate.MicroTeachCaseTimeIn] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.MicroTeachCaseTimeIn].ToString().Trim(); //案例入库时间
objvMicroteachCaseSiteSenateEN.IsVisible = TransNullToBool(objRow[convMicroteachCaseSiteSenate.IsVisible].ToString().Trim()); //是否显示
objvMicroteachCaseSiteSenateEN.microteachCaseText = objRow[convMicroteachCaseSiteSenate.microteachCaseText] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.microteachCaseText].ToString().Trim(); //案例文本内容
objvMicroteachCaseSiteSenateEN.OwnerId = objRow[convMicroteachCaseSiteSenate.OwnerId] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.OwnerId].ToString().Trim(); //拥有者Id
objvMicroteachCaseSiteSenateEN.StuName = objRow[convMicroteachCaseSiteSenate.StuName].ToString().Trim(); //姓名
objvMicroteachCaseSiteSenateEN.StuID = objRow[convMicroteachCaseSiteSenate.StuID].ToString().Trim(); //学号
objvMicroteachCaseSiteSenateEN.PoliticsName = objRow[convMicroteachCaseSiteSenate.PoliticsName].ToString().Trim(); //政治面貌
objvMicroteachCaseSiteSenateEN.SexDesc = objRow[convMicroteachCaseSiteSenate.SexDesc] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.SexDesc].ToString().Trim(); //性别名称
objvMicroteachCaseSiteSenateEN.EthnicName = objRow[convMicroteachCaseSiteSenate.EthnicName].ToString().Trim(); //民族名称
objvMicroteachCaseSiteSenateEN.UniZoneDesc = objRow[convMicroteachCaseSiteSenate.UniZoneDesc].ToString().Trim(); //校区名称
objvMicroteachCaseSiteSenateEN.StuTypeDesc = objRow[convMicroteachCaseSiteSenate.StuTypeDesc].ToString().Trim(); //学生类别名称
objvMicroteachCaseSiteSenateEN.IdXzCollege = objRow[convMicroteachCaseSiteSenate.IdXzCollege] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.IdXzCollege].ToString().Trim(); //学院流水号
objvMicroteachCaseSiteSenateEN.CollegeName = objRow[convMicroteachCaseSiteSenate.CollegeName].ToString().Trim(); //学院名称
objvMicroteachCaseSiteSenateEN.IdXzMajor = objRow[convMicroteachCaseSiteSenate.IdXzMajor] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.IdXzMajor].ToString().Trim(); //专业流水号
objvMicroteachCaseSiteSenateEN.MajorName = objRow[convMicroteachCaseSiteSenate.MajorName].ToString().Trim(); //专业名称
objvMicroteachCaseSiteSenateEN.IdGradeBase = objRow[convMicroteachCaseSiteSenate.IdGradeBase].ToString().Trim(); //年级流水号
objvMicroteachCaseSiteSenateEN.GradeBaseName = objRow[convMicroteachCaseSiteSenate.GradeBaseName] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.GradeBaseName].ToString().Trim(); //年级名称
objvMicroteachCaseSiteSenateEN.Birthday = objRow[convMicroteachCaseSiteSenate.Birthday] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.Birthday].ToString().Trim(); //出生日期
objvMicroteachCaseSiteSenateEN.NativePlace = objRow[convMicroteachCaseSiteSenate.NativePlace] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.NativePlace].ToString().Trim(); //籍贯
objvMicroteachCaseSiteSenateEN.Duty = objRow[convMicroteachCaseSiteSenate.Duty] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.Duty].ToString().Trim(); //职位
objvMicroteachCaseSiteSenateEN.IDCardNo = objRow[convMicroteachCaseSiteSenate.IDCardNo] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.IDCardNo].ToString().Trim(); //身份证号
objvMicroteachCaseSiteSenateEN.StuCardNo = objRow[convMicroteachCaseSiteSenate.StuCardNo] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.StuCardNo].ToString().Trim(); //学生证号
objvMicroteachCaseSiteSenateEN.LiveAddress = objRow[convMicroteachCaseSiteSenate.LiveAddress] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.LiveAddress].ToString().Trim(); //居住地址
objvMicroteachCaseSiteSenateEN.HomePhone = objRow[convMicroteachCaseSiteSenate.HomePhone] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.HomePhone].ToString().Trim(); //住宅电话
objvMicroteachCaseSiteSenateEN.EnrollmentDate = objRow[convMicroteachCaseSiteSenate.EnrollmentDate] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.EnrollmentDate].ToString().Trim(); //入校日期
objvMicroteachCaseSiteSenateEN.PostCode = objRow[convMicroteachCaseSiteSenate.PostCode] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.PostCode].ToString().Trim(); //邮编
objvMicroteachCaseSiteSenateEN.BrowseCount4Case = objRow[convMicroteachCaseSiteSenate.BrowseCount4Case] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convMicroteachCaseSiteSenate.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvMicroteachCaseSiteSenateEN.IdMicroteachCaseSiteSenateType = objRow[convMicroteachCaseSiteSenate.IdMicroteachCaseSiteSenateType].ToString().Trim(); //微格现场评价类型流水号
objvMicroteachCaseSiteSenateEN.MicroteachCaseSiteSenateTypeID = objRow[convMicroteachCaseSiteSenate.MicroteachCaseSiteSenateTypeID].ToString().Trim(); //微格现场评价类型ID
objvMicroteachCaseSiteSenateEN.MicroteachCaseSiteSenateTypeName = objRow[convMicroteachCaseSiteSenate.MicroteachCaseSiteSenateTypeName].ToString().Trim(); //微格现场评价类型名称
objvMicroteachCaseSiteSenateEN.IdResource = objRow[convMicroteachCaseSiteSenate.IdResource].ToString().Trim(); //资源流水号
objvMicroteachCaseSiteSenateEN.ResourceID = objRow[convMicroteachCaseSiteSenate.ResourceID].ToString().Trim(); //资源ID
objvMicroteachCaseSiteSenateEN.ResourceName = objRow[convMicroteachCaseSiteSenate.ResourceName] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.ResourceName].ToString().Trim(); //资源名称
objvMicroteachCaseSiteSenateEN.IdFtpResource = objRow[convMicroteachCaseSiteSenate.IdFtpResource] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvMicroteachCaseSiteSenateEN.IdFile = objRow[convMicroteachCaseSiteSenate.IdFile] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.IdFile].ToString().Trim(); //文件流水号
objvMicroteachCaseSiteSenateEN.FileName = objRow[convMicroteachCaseSiteSenate.FileName] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.FileName].ToString().Trim(); //文件名称
objvMicroteachCaseSiteSenateEN.FileType = objRow[convMicroteachCaseSiteSenate.FileType] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.FileType].ToString().Trim(); //文件类型
objvMicroteachCaseSiteSenateEN.SaveDate = objRow[convMicroteachCaseSiteSenate.SaveDate] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.SaveDate].ToString().Trim(); //创建日期
objvMicroteachCaseSiteSenateEN.FileSize = objRow[convMicroteachCaseSiteSenate.FileSize] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.FileSize].ToString().Trim(); //文件大小
objvMicroteachCaseSiteSenateEN.SaveTime = objRow[convMicroteachCaseSiteSenate.SaveTime] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.SaveTime].ToString().Trim(); //创建时间
objvMicroteachCaseSiteSenateEN.FtpResourceID = objRow[convMicroteachCaseSiteSenate.FtpResourceID].ToString().Trim(); //FTP资源ID
objvMicroteachCaseSiteSenateEN.FileOriginalName = objRow[convMicroteachCaseSiteSenate.FileOriginalName] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.FileOriginalName].ToString().Trim(); //文件原名
objvMicroteachCaseSiteSenateEN.FileDirName = objRow[convMicroteachCaseSiteSenate.FileDirName] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.FileDirName].ToString().Trim(); //文件目录名
objvMicroteachCaseSiteSenateEN.FileRename = objRow[convMicroteachCaseSiteSenate.FileRename] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.FileRename].ToString().Trim(); //文件新名
objvMicroteachCaseSiteSenateEN.FileUpDate = objRow[convMicroteachCaseSiteSenate.FileUpDate] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.FileUpDate].ToString().Trim(); //创建日期
objvMicroteachCaseSiteSenateEN.FileUpTime = objRow[convMicroteachCaseSiteSenate.FileUpTime] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.FileUpTime].ToString().Trim(); //创建时间
objvMicroteachCaseSiteSenateEN.SaveMode = TransNullToBool(objRow[convMicroteachCaseSiteSenate.SaveMode].ToString().Trim()); //文件存放方式
objvMicroteachCaseSiteSenateEN.IdResourceType = objRow[convMicroteachCaseSiteSenate.IdResourceType].ToString().Trim(); //资源类型流水号
objvMicroteachCaseSiteSenateEN.ResourceTypeID = objRow[convMicroteachCaseSiteSenate.ResourceTypeID].ToString().Trim(); //资源类型ID
objvMicroteachCaseSiteSenateEN.ResourceTypeName = objRow[convMicroteachCaseSiteSenate.ResourceTypeName].ToString().Trim(); //资源类型名称
objvMicroteachCaseSiteSenateEN.ResourceOwner = objRow[convMicroteachCaseSiteSenate.ResourceOwner].ToString().Trim(); //上传者
objvMicroteachCaseSiteSenateEN.ftpFileType = objRow[convMicroteachCaseSiteSenate.ftpFileType] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.ftpFileType].ToString().Trim(); //ftp文件类型
objvMicroteachCaseSiteSenateEN.ftpFileSize = objRow[convMicroteachCaseSiteSenate.ftpFileSize] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.ftpFileSize].ToString().Trim(); //ftp文件大小
objvMicroteachCaseSiteSenateEN.ftpResourceOwner = objRow[convMicroteachCaseSiteSenate.ftpResourceOwner] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvMicroteachCaseSiteSenateEN.FileOriginName = objRow[convMicroteachCaseSiteSenate.FileOriginName] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.FileOriginName].ToString().Trim(); //原文件名
objvMicroteachCaseSiteSenateEN.IsExistFile = TransNullToBool(objRow[convMicroteachCaseSiteSenate.IsExistFile].ToString().Trim()); //是否存在文件
objvMicroteachCaseSiteSenateEN.FileNewName = objRow[convMicroteachCaseSiteSenate.FileNewName] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.FileNewName].ToString().Trim(); //新文件名
objvMicroteachCaseSiteSenateEN.FileOldName = objRow[convMicroteachCaseSiteSenate.FileOldName] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.FileOldName].ToString().Trim(); //旧文件名
objvMicroteachCaseSiteSenateEN.SiteSenateSenator = objRow[convMicroteachCaseSiteSenate.SiteSenateSenator] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.SiteSenateSenator].ToString().Trim(); //评议者
objvMicroteachCaseSiteSenateEN.SiteSenateTitle = objRow[convMicroteachCaseSiteSenate.SiteSenateTitle].ToString().Trim(); //评议名称
objvMicroteachCaseSiteSenateEN.SiteSenateContent = objRow[convMicroteachCaseSiteSenate.SiteSenateContent] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.SiteSenateContent].ToString().Trim(); //现场评议内容
objvMicroteachCaseSiteSenateEN.SiteSenateData = objRow[convMicroteachCaseSiteSenate.SiteSenateData] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.SiteSenateData].ToString().Trim(); //现场评议日期
objvMicroteachCaseSiteSenateEN.SiteSenateTime = objRow[convMicroteachCaseSiteSenate.SiteSenateTime] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.SiteSenateTime].ToString().Trim(); //现场评议时间
objvMicroteachCaseSiteSenateEN.SiteSenateReadCount = objRow[convMicroteachCaseSiteSenate.SiteSenateReadCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convMicroteachCaseSiteSenate.SiteSenateReadCount].ToString().Trim()); //现场评议阅读次数
objvMicroteachCaseSiteSenateEN.Memo = objRow[convMicroteachCaseSiteSenate.Memo] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvMicroteachCaseSiteSenateDA: GetObjLst)", objException.Message));
}
objvMicroteachCaseSiteSenateEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvMicroteachCaseSiteSenateEN);
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
public List<clsvMicroteachCaseSiteSenateEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvMicroteachCaseSiteSenateDA:GetObjLstByTabName)", objException.Message));
}
List<clsvMicroteachCaseSiteSenateEN> arrObjLst = new List<clsvMicroteachCaseSiteSenateEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMicroteachCaseSiteSenateDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvMicroteachCaseSiteSenateEN objvMicroteachCaseSiteSenateEN = new clsvMicroteachCaseSiteSenateEN();
try
{
objvMicroteachCaseSiteSenateEN.IdMicroteachCaseSiteSenate = TransNullToInt(objRow[convMicroteachCaseSiteSenate.IdMicroteachCaseSiteSenate].ToString().Trim()); //微格现场评议流水号
objvMicroteachCaseSiteSenateEN.FuncModuleId = objRow[convMicroteachCaseSiteSenate.FuncModuleId].ToString().Trim(); //功能模块Id
objvMicroteachCaseSiteSenateEN.FuncModuleName = objRow[convMicroteachCaseSiteSenate.FuncModuleName] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.FuncModuleName].ToString().Trim(); //功能模块名称
objvMicroteachCaseSiteSenateEN.IdMicroteachCase = objRow[convMicroteachCaseSiteSenate.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvMicroteachCaseSiteSenateEN.MicroteachCaseID = objRow[convMicroteachCaseSiteSenate.MicroteachCaseID].ToString().Trim(); //微格教学案例ID
objvMicroteachCaseSiteSenateEN.MicroteachCaseName = objRow[convMicroteachCaseSiteSenate.MicroteachCaseName].ToString().Trim(); //微格教学案例名称
objvMicroteachCaseSiteSenateEN.MicroteachCaseTheme = objRow[convMicroteachCaseSiteSenate.MicroteachCaseTheme] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.MicroteachCaseTheme].ToString().Trim(); //微格教学案例主题词
objvMicroteachCaseSiteSenateEN.MicroteachCaseDate = objRow[convMicroteachCaseSiteSenate.MicroteachCaseDate] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.MicroteachCaseDate].ToString().Trim(); //微格教学日期
objvMicroteachCaseSiteSenateEN.MicroteachCaseTime = objRow[convMicroteachCaseSiteSenate.MicroteachCaseTime] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.MicroteachCaseTime].ToString().Trim(); //微格教学时间
objvMicroteachCaseSiteSenateEN.MicroteachCaseDateIn = objRow[convMicroteachCaseSiteSenate.MicroteachCaseDateIn] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.MicroteachCaseDateIn].ToString().Trim(); //案例入库日期
objvMicroteachCaseSiteSenateEN.IdStudyLevel = objRow[convMicroteachCaseSiteSenate.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvMicroteachCaseSiteSenateEN.StudyLevelName = objRow[convMicroteachCaseSiteSenate.StudyLevelName].ToString().Trim(); //学段名称
objvMicroteachCaseSiteSenateEN.IdTeachingPlan = objRow[convMicroteachCaseSiteSenate.IdTeachingPlan].ToString().Trim(); //教案流水号
objvMicroteachCaseSiteSenateEN.MicroTeachCaseTimeIn = objRow[convMicroteachCaseSiteSenate.MicroTeachCaseTimeIn] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.MicroTeachCaseTimeIn].ToString().Trim(); //案例入库时间
objvMicroteachCaseSiteSenateEN.IsVisible = TransNullToBool(objRow[convMicroteachCaseSiteSenate.IsVisible].ToString().Trim()); //是否显示
objvMicroteachCaseSiteSenateEN.microteachCaseText = objRow[convMicroteachCaseSiteSenate.microteachCaseText] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.microteachCaseText].ToString().Trim(); //案例文本内容
objvMicroteachCaseSiteSenateEN.OwnerId = objRow[convMicroteachCaseSiteSenate.OwnerId] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.OwnerId].ToString().Trim(); //拥有者Id
objvMicroteachCaseSiteSenateEN.StuName = objRow[convMicroteachCaseSiteSenate.StuName].ToString().Trim(); //姓名
objvMicroteachCaseSiteSenateEN.StuID = objRow[convMicroteachCaseSiteSenate.StuID].ToString().Trim(); //学号
objvMicroteachCaseSiteSenateEN.PoliticsName = objRow[convMicroteachCaseSiteSenate.PoliticsName].ToString().Trim(); //政治面貌
objvMicroteachCaseSiteSenateEN.SexDesc = objRow[convMicroteachCaseSiteSenate.SexDesc] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.SexDesc].ToString().Trim(); //性别名称
objvMicroteachCaseSiteSenateEN.EthnicName = objRow[convMicroteachCaseSiteSenate.EthnicName].ToString().Trim(); //民族名称
objvMicroteachCaseSiteSenateEN.UniZoneDesc = objRow[convMicroteachCaseSiteSenate.UniZoneDesc].ToString().Trim(); //校区名称
objvMicroteachCaseSiteSenateEN.StuTypeDesc = objRow[convMicroteachCaseSiteSenate.StuTypeDesc].ToString().Trim(); //学生类别名称
objvMicroteachCaseSiteSenateEN.IdXzCollege = objRow[convMicroteachCaseSiteSenate.IdXzCollege] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.IdXzCollege].ToString().Trim(); //学院流水号
objvMicroteachCaseSiteSenateEN.CollegeName = objRow[convMicroteachCaseSiteSenate.CollegeName].ToString().Trim(); //学院名称
objvMicroteachCaseSiteSenateEN.IdXzMajor = objRow[convMicroteachCaseSiteSenate.IdXzMajor] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.IdXzMajor].ToString().Trim(); //专业流水号
objvMicroteachCaseSiteSenateEN.MajorName = objRow[convMicroteachCaseSiteSenate.MajorName].ToString().Trim(); //专业名称
objvMicroteachCaseSiteSenateEN.IdGradeBase = objRow[convMicroteachCaseSiteSenate.IdGradeBase].ToString().Trim(); //年级流水号
objvMicroteachCaseSiteSenateEN.GradeBaseName = objRow[convMicroteachCaseSiteSenate.GradeBaseName] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.GradeBaseName].ToString().Trim(); //年级名称
objvMicroteachCaseSiteSenateEN.Birthday = objRow[convMicroteachCaseSiteSenate.Birthday] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.Birthday].ToString().Trim(); //出生日期
objvMicroteachCaseSiteSenateEN.NativePlace = objRow[convMicroteachCaseSiteSenate.NativePlace] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.NativePlace].ToString().Trim(); //籍贯
objvMicroteachCaseSiteSenateEN.Duty = objRow[convMicroteachCaseSiteSenate.Duty] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.Duty].ToString().Trim(); //职位
objvMicroteachCaseSiteSenateEN.IDCardNo = objRow[convMicroteachCaseSiteSenate.IDCardNo] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.IDCardNo].ToString().Trim(); //身份证号
objvMicroteachCaseSiteSenateEN.StuCardNo = objRow[convMicroteachCaseSiteSenate.StuCardNo] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.StuCardNo].ToString().Trim(); //学生证号
objvMicroteachCaseSiteSenateEN.LiveAddress = objRow[convMicroteachCaseSiteSenate.LiveAddress] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.LiveAddress].ToString().Trim(); //居住地址
objvMicroteachCaseSiteSenateEN.HomePhone = objRow[convMicroteachCaseSiteSenate.HomePhone] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.HomePhone].ToString().Trim(); //住宅电话
objvMicroteachCaseSiteSenateEN.EnrollmentDate = objRow[convMicroteachCaseSiteSenate.EnrollmentDate] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.EnrollmentDate].ToString().Trim(); //入校日期
objvMicroteachCaseSiteSenateEN.PostCode = objRow[convMicroteachCaseSiteSenate.PostCode] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.PostCode].ToString().Trim(); //邮编
objvMicroteachCaseSiteSenateEN.BrowseCount4Case = objRow[convMicroteachCaseSiteSenate.BrowseCount4Case] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convMicroteachCaseSiteSenate.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvMicroteachCaseSiteSenateEN.IdMicroteachCaseSiteSenateType = objRow[convMicroteachCaseSiteSenate.IdMicroteachCaseSiteSenateType].ToString().Trim(); //微格现场评价类型流水号
objvMicroteachCaseSiteSenateEN.MicroteachCaseSiteSenateTypeID = objRow[convMicroteachCaseSiteSenate.MicroteachCaseSiteSenateTypeID].ToString().Trim(); //微格现场评价类型ID
objvMicroteachCaseSiteSenateEN.MicroteachCaseSiteSenateTypeName = objRow[convMicroteachCaseSiteSenate.MicroteachCaseSiteSenateTypeName].ToString().Trim(); //微格现场评价类型名称
objvMicroteachCaseSiteSenateEN.IdResource = objRow[convMicroteachCaseSiteSenate.IdResource].ToString().Trim(); //资源流水号
objvMicroteachCaseSiteSenateEN.ResourceID = objRow[convMicroteachCaseSiteSenate.ResourceID].ToString().Trim(); //资源ID
objvMicroteachCaseSiteSenateEN.ResourceName = objRow[convMicroteachCaseSiteSenate.ResourceName] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.ResourceName].ToString().Trim(); //资源名称
objvMicroteachCaseSiteSenateEN.IdFtpResource = objRow[convMicroteachCaseSiteSenate.IdFtpResource] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvMicroteachCaseSiteSenateEN.IdFile = objRow[convMicroteachCaseSiteSenate.IdFile] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.IdFile].ToString().Trim(); //文件流水号
objvMicroteachCaseSiteSenateEN.FileName = objRow[convMicroteachCaseSiteSenate.FileName] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.FileName].ToString().Trim(); //文件名称
objvMicroteachCaseSiteSenateEN.FileType = objRow[convMicroteachCaseSiteSenate.FileType] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.FileType].ToString().Trim(); //文件类型
objvMicroteachCaseSiteSenateEN.SaveDate = objRow[convMicroteachCaseSiteSenate.SaveDate] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.SaveDate].ToString().Trim(); //创建日期
objvMicroteachCaseSiteSenateEN.FileSize = objRow[convMicroteachCaseSiteSenate.FileSize] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.FileSize].ToString().Trim(); //文件大小
objvMicroteachCaseSiteSenateEN.SaveTime = objRow[convMicroteachCaseSiteSenate.SaveTime] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.SaveTime].ToString().Trim(); //创建时间
objvMicroteachCaseSiteSenateEN.FtpResourceID = objRow[convMicroteachCaseSiteSenate.FtpResourceID].ToString().Trim(); //FTP资源ID
objvMicroteachCaseSiteSenateEN.FileOriginalName = objRow[convMicroteachCaseSiteSenate.FileOriginalName] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.FileOriginalName].ToString().Trim(); //文件原名
objvMicroteachCaseSiteSenateEN.FileDirName = objRow[convMicroteachCaseSiteSenate.FileDirName] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.FileDirName].ToString().Trim(); //文件目录名
objvMicroteachCaseSiteSenateEN.FileRename = objRow[convMicroteachCaseSiteSenate.FileRename] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.FileRename].ToString().Trim(); //文件新名
objvMicroteachCaseSiteSenateEN.FileUpDate = objRow[convMicroteachCaseSiteSenate.FileUpDate] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.FileUpDate].ToString().Trim(); //创建日期
objvMicroteachCaseSiteSenateEN.FileUpTime = objRow[convMicroteachCaseSiteSenate.FileUpTime] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.FileUpTime].ToString().Trim(); //创建时间
objvMicroteachCaseSiteSenateEN.SaveMode = TransNullToBool(objRow[convMicroteachCaseSiteSenate.SaveMode].ToString().Trim()); //文件存放方式
objvMicroteachCaseSiteSenateEN.IdResourceType = objRow[convMicroteachCaseSiteSenate.IdResourceType].ToString().Trim(); //资源类型流水号
objvMicroteachCaseSiteSenateEN.ResourceTypeID = objRow[convMicroteachCaseSiteSenate.ResourceTypeID].ToString().Trim(); //资源类型ID
objvMicroteachCaseSiteSenateEN.ResourceTypeName = objRow[convMicroteachCaseSiteSenate.ResourceTypeName].ToString().Trim(); //资源类型名称
objvMicroteachCaseSiteSenateEN.ResourceOwner = objRow[convMicroteachCaseSiteSenate.ResourceOwner].ToString().Trim(); //上传者
objvMicroteachCaseSiteSenateEN.ftpFileType = objRow[convMicroteachCaseSiteSenate.ftpFileType] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.ftpFileType].ToString().Trim(); //ftp文件类型
objvMicroteachCaseSiteSenateEN.ftpFileSize = objRow[convMicroteachCaseSiteSenate.ftpFileSize] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.ftpFileSize].ToString().Trim(); //ftp文件大小
objvMicroteachCaseSiteSenateEN.ftpResourceOwner = objRow[convMicroteachCaseSiteSenate.ftpResourceOwner] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvMicroteachCaseSiteSenateEN.FileOriginName = objRow[convMicroteachCaseSiteSenate.FileOriginName] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.FileOriginName].ToString().Trim(); //原文件名
objvMicroteachCaseSiteSenateEN.IsExistFile = TransNullToBool(objRow[convMicroteachCaseSiteSenate.IsExistFile].ToString().Trim()); //是否存在文件
objvMicroteachCaseSiteSenateEN.FileNewName = objRow[convMicroteachCaseSiteSenate.FileNewName] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.FileNewName].ToString().Trim(); //新文件名
objvMicroteachCaseSiteSenateEN.FileOldName = objRow[convMicroteachCaseSiteSenate.FileOldName] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.FileOldName].ToString().Trim(); //旧文件名
objvMicroteachCaseSiteSenateEN.SiteSenateSenator = objRow[convMicroteachCaseSiteSenate.SiteSenateSenator] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.SiteSenateSenator].ToString().Trim(); //评议者
objvMicroteachCaseSiteSenateEN.SiteSenateTitle = objRow[convMicroteachCaseSiteSenate.SiteSenateTitle].ToString().Trim(); //评议名称
objvMicroteachCaseSiteSenateEN.SiteSenateContent = objRow[convMicroteachCaseSiteSenate.SiteSenateContent] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.SiteSenateContent].ToString().Trim(); //现场评议内容
objvMicroteachCaseSiteSenateEN.SiteSenateData = objRow[convMicroteachCaseSiteSenate.SiteSenateData] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.SiteSenateData].ToString().Trim(); //现场评议日期
objvMicroteachCaseSiteSenateEN.SiteSenateTime = objRow[convMicroteachCaseSiteSenate.SiteSenateTime] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.SiteSenateTime].ToString().Trim(); //现场评议时间
objvMicroteachCaseSiteSenateEN.SiteSenateReadCount = objRow[convMicroteachCaseSiteSenate.SiteSenateReadCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convMicroteachCaseSiteSenate.SiteSenateReadCount].ToString().Trim()); //现场评议阅读次数
objvMicroteachCaseSiteSenateEN.Memo = objRow[convMicroteachCaseSiteSenate.Memo] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvMicroteachCaseSiteSenateDA: GetObjLst)", objException.Message));
}
objvMicroteachCaseSiteSenateEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvMicroteachCaseSiteSenateEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvMicroteachCaseSiteSenateEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvMicroteachCaseSiteSenate(ref clsvMicroteachCaseSiteSenateEN objvMicroteachCaseSiteSenateEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMicroteachCaseSiteSenateDA.GetSpecSQLObj();
strSQL = "Select * from vMicroteachCaseSiteSenate where IdMicroteachCaseSiteSenate = " + ""+ objvMicroteachCaseSiteSenateEN.IdMicroteachCaseSiteSenate+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvMicroteachCaseSiteSenateEN.IdMicroteachCaseSiteSenate = TransNullToInt(objDT.Rows[0][convMicroteachCaseSiteSenate.IdMicroteachCaseSiteSenate].ToString().Trim()); //微格现场评议流水号(字段类型:bigint,字段长度:8,是否可空:False)
 objvMicroteachCaseSiteSenateEN.FuncModuleId = objDT.Rows[0][convMicroteachCaseSiteSenate.FuncModuleId].ToString().Trim(); //功能模块Id(字段类型:char,字段长度:4,是否可空:True)
 objvMicroteachCaseSiteSenateEN.FuncModuleName = objDT.Rows[0][convMicroteachCaseSiteSenate.FuncModuleName].ToString().Trim(); //功能模块名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvMicroteachCaseSiteSenateEN.IdMicroteachCase = objDT.Rows[0][convMicroteachCaseSiteSenate.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号(字段类型:char,字段长度:8,是否可空:False)
 objvMicroteachCaseSiteSenateEN.MicroteachCaseID = objDT.Rows[0][convMicroteachCaseSiteSenate.MicroteachCaseID].ToString().Trim(); //微格教学案例ID(字段类型:char,字段长度:8,是否可空:False)
 objvMicroteachCaseSiteSenateEN.MicroteachCaseName = objDT.Rows[0][convMicroteachCaseSiteSenate.MicroteachCaseName].ToString().Trim(); //微格教学案例名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvMicroteachCaseSiteSenateEN.MicroteachCaseTheme = objDT.Rows[0][convMicroteachCaseSiteSenate.MicroteachCaseTheme].ToString().Trim(); //微格教学案例主题词(字段类型:varchar,字段长度:200,是否可空:True)
 objvMicroteachCaseSiteSenateEN.MicroteachCaseDate = objDT.Rows[0][convMicroteachCaseSiteSenate.MicroteachCaseDate].ToString().Trim(); //微格教学日期(字段类型:char,字段长度:8,是否可空:True)
 objvMicroteachCaseSiteSenateEN.MicroteachCaseTime = objDT.Rows[0][convMicroteachCaseSiteSenate.MicroteachCaseTime].ToString().Trim(); //微格教学时间(字段类型:char,字段长度:6,是否可空:True)
 objvMicroteachCaseSiteSenateEN.MicroteachCaseDateIn = objDT.Rows[0][convMicroteachCaseSiteSenate.MicroteachCaseDateIn].ToString().Trim(); //案例入库日期(字段类型:char,字段长度:8,是否可空:True)
 objvMicroteachCaseSiteSenateEN.IdStudyLevel = objDT.Rows[0][convMicroteachCaseSiteSenate.IdStudyLevel].ToString().Trim(); //id_StudyLevel(字段类型:char,字段长度:4,是否可空:True)
 objvMicroteachCaseSiteSenateEN.StudyLevelName = objDT.Rows[0][convMicroteachCaseSiteSenate.StudyLevelName].ToString().Trim(); //学段名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvMicroteachCaseSiteSenateEN.IdTeachingPlan = objDT.Rows[0][convMicroteachCaseSiteSenate.IdTeachingPlan].ToString().Trim(); //教案流水号(字段类型:char,字段长度:8,是否可空:False)
 objvMicroteachCaseSiteSenateEN.MicroTeachCaseTimeIn = objDT.Rows[0][convMicroteachCaseSiteSenate.MicroTeachCaseTimeIn].ToString().Trim(); //案例入库时间(字段类型:char,字段长度:6,是否可空:True)
 objvMicroteachCaseSiteSenateEN.IsVisible = TransNullToBool(objDT.Rows[0][convMicroteachCaseSiteSenate.IsVisible].ToString().Trim()); //是否显示(字段类型:bit,字段长度:1,是否可空:True)
 objvMicroteachCaseSiteSenateEN.microteachCaseText = objDT.Rows[0][convMicroteachCaseSiteSenate.microteachCaseText].ToString().Trim(); //案例文本内容(字段类型:varchar,字段长度:8000,是否可空:True)
 objvMicroteachCaseSiteSenateEN.OwnerId = objDT.Rows[0][convMicroteachCaseSiteSenate.OwnerId].ToString().Trim(); //拥有者Id(字段类型:varchar,字段长度:20,是否可空:False)
 objvMicroteachCaseSiteSenateEN.StuName = objDT.Rows[0][convMicroteachCaseSiteSenate.StuName].ToString().Trim(); //姓名(字段类型:varchar,字段长度:50,是否可空:True)
 objvMicroteachCaseSiteSenateEN.StuID = objDT.Rows[0][convMicroteachCaseSiteSenate.StuID].ToString().Trim(); //学号(字段类型:varchar,字段长度:20,是否可空:True)
 objvMicroteachCaseSiteSenateEN.PoliticsName = objDT.Rows[0][convMicroteachCaseSiteSenate.PoliticsName].ToString().Trim(); //政治面貌(字段类型:varchar,字段长度:30,是否可空:False)
 objvMicroteachCaseSiteSenateEN.SexDesc = objDT.Rows[0][convMicroteachCaseSiteSenate.SexDesc].ToString().Trim(); //性别名称(字段类型:varchar,字段长度:10,是否可空:True)
 objvMicroteachCaseSiteSenateEN.EthnicName = objDT.Rows[0][convMicroteachCaseSiteSenate.EthnicName].ToString().Trim(); //民族名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvMicroteachCaseSiteSenateEN.UniZoneDesc = objDT.Rows[0][convMicroteachCaseSiteSenate.UniZoneDesc].ToString().Trim(); //校区名称(字段类型:varchar,字段长度:20,是否可空:False)
 objvMicroteachCaseSiteSenateEN.StuTypeDesc = objDT.Rows[0][convMicroteachCaseSiteSenate.StuTypeDesc].ToString().Trim(); //学生类别名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvMicroteachCaseSiteSenateEN.IdXzCollege = objDT.Rows[0][convMicroteachCaseSiteSenate.IdXzCollege].ToString().Trim(); //学院流水号(字段类型:char,字段长度:4,是否可空:True)
 objvMicroteachCaseSiteSenateEN.CollegeName = objDT.Rows[0][convMicroteachCaseSiteSenate.CollegeName].ToString().Trim(); //学院名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvMicroteachCaseSiteSenateEN.IdXzMajor = objDT.Rows[0][convMicroteachCaseSiteSenate.IdXzMajor].ToString().Trim(); //专业流水号(字段类型:char,字段长度:8,是否可空:False)
 objvMicroteachCaseSiteSenateEN.MajorName = objDT.Rows[0][convMicroteachCaseSiteSenate.MajorName].ToString().Trim(); //专业名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvMicroteachCaseSiteSenateEN.IdGradeBase = objDT.Rows[0][convMicroteachCaseSiteSenate.IdGradeBase].ToString().Trim(); //年级流水号(字段类型:char,字段长度:4,是否可空:True)
 objvMicroteachCaseSiteSenateEN.GradeBaseName = objDT.Rows[0][convMicroteachCaseSiteSenate.GradeBaseName].ToString().Trim(); //年级名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvMicroteachCaseSiteSenateEN.Birthday = objDT.Rows[0][convMicroteachCaseSiteSenate.Birthday].ToString().Trim(); //出生日期(字段类型:char,字段长度:8,是否可空:True)
 objvMicroteachCaseSiteSenateEN.NativePlace = objDT.Rows[0][convMicroteachCaseSiteSenate.NativePlace].ToString().Trim(); //籍贯(字段类型:varchar,字段长度:200,是否可空:True)
 objvMicroteachCaseSiteSenateEN.Duty = objDT.Rows[0][convMicroteachCaseSiteSenate.Duty].ToString().Trim(); //职位(字段类型:varchar,字段长度:30,是否可空:True)
 objvMicroteachCaseSiteSenateEN.IDCardNo = objDT.Rows[0][convMicroteachCaseSiteSenate.IDCardNo].ToString().Trim(); //身份证号(字段类型:varchar,字段长度:20,是否可空:True)
 objvMicroteachCaseSiteSenateEN.StuCardNo = objDT.Rows[0][convMicroteachCaseSiteSenate.StuCardNo].ToString().Trim(); //学生证号(字段类型:varchar,字段长度:20,是否可空:True)
 objvMicroteachCaseSiteSenateEN.LiveAddress = objDT.Rows[0][convMicroteachCaseSiteSenate.LiveAddress].ToString().Trim(); //居住地址(字段类型:varchar,字段长度:200,是否可空:True)
 objvMicroteachCaseSiteSenateEN.HomePhone = objDT.Rows[0][convMicroteachCaseSiteSenate.HomePhone].ToString().Trim(); //住宅电话(字段类型:varchar,字段长度:20,是否可空:True)
 objvMicroteachCaseSiteSenateEN.EnrollmentDate = objDT.Rows[0][convMicroteachCaseSiteSenate.EnrollmentDate].ToString().Trim(); //入校日期(字段类型:varchar,字段长度:8,是否可空:True)
 objvMicroteachCaseSiteSenateEN.PostCode = objDT.Rows[0][convMicroteachCaseSiteSenate.PostCode].ToString().Trim(); //邮编(字段类型:char,字段长度:6,是否可空:True)
 objvMicroteachCaseSiteSenateEN.BrowseCount4Case = TransNullToInt(objDT.Rows[0][convMicroteachCaseSiteSenate.BrowseCount4Case].ToString().Trim()); //课例浏览次数(字段类型:int,字段长度:4,是否可空:True)
 objvMicroteachCaseSiteSenateEN.IdMicroteachCaseSiteSenateType = objDT.Rows[0][convMicroteachCaseSiteSenate.IdMicroteachCaseSiteSenateType].ToString().Trim(); //微格现场评价类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvMicroteachCaseSiteSenateEN.MicroteachCaseSiteSenateTypeID = objDT.Rows[0][convMicroteachCaseSiteSenate.MicroteachCaseSiteSenateTypeID].ToString().Trim(); //微格现场评价类型ID(字段类型:char,字段长度:4,是否可空:False)
 objvMicroteachCaseSiteSenateEN.MicroteachCaseSiteSenateTypeName = objDT.Rows[0][convMicroteachCaseSiteSenate.MicroteachCaseSiteSenateTypeName].ToString().Trim(); //微格现场评价类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvMicroteachCaseSiteSenateEN.IdResource = objDT.Rows[0][convMicroteachCaseSiteSenate.IdResource].ToString().Trim(); //资源流水号(字段类型:char,字段长度:8,是否可空:False)
 objvMicroteachCaseSiteSenateEN.ResourceID = objDT.Rows[0][convMicroteachCaseSiteSenate.ResourceID].ToString().Trim(); //资源ID(字段类型:char,字段长度:8,是否可空:False)
 objvMicroteachCaseSiteSenateEN.ResourceName = objDT.Rows[0][convMicroteachCaseSiteSenate.ResourceName].ToString().Trim(); //资源名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvMicroteachCaseSiteSenateEN.IdFtpResource = objDT.Rows[0][convMicroteachCaseSiteSenate.IdFtpResource].ToString().Trim(); //FTP资源流水号(字段类型:char,字段长度:8,是否可空:True)
 objvMicroteachCaseSiteSenateEN.IdFile = objDT.Rows[0][convMicroteachCaseSiteSenate.IdFile].ToString().Trim(); //文件流水号(字段类型:char,字段长度:8,是否可空:True)
 objvMicroteachCaseSiteSenateEN.FileName = objDT.Rows[0][convMicroteachCaseSiteSenate.FileName].ToString().Trim(); //文件名称(字段类型:varchar,字段长度:500,是否可空:True)
 objvMicroteachCaseSiteSenateEN.FileType = objDT.Rows[0][convMicroteachCaseSiteSenate.FileType].ToString().Trim(); //文件类型(字段类型:varchar,字段长度:30,是否可空:True)
 objvMicroteachCaseSiteSenateEN.SaveDate = objDT.Rows[0][convMicroteachCaseSiteSenate.SaveDate].ToString().Trim(); //创建日期(字段类型:char,字段长度:8,是否可空:True)
 objvMicroteachCaseSiteSenateEN.FileSize = objDT.Rows[0][convMicroteachCaseSiteSenate.FileSize].ToString().Trim(); //文件大小(字段类型:varchar,字段长度:50,是否可空:True)
 objvMicroteachCaseSiteSenateEN.SaveTime = objDT.Rows[0][convMicroteachCaseSiteSenate.SaveTime].ToString().Trim(); //创建时间(字段类型:char,字段长度:6,是否可空:True)
 objvMicroteachCaseSiteSenateEN.FtpResourceID = objDT.Rows[0][convMicroteachCaseSiteSenate.FtpResourceID].ToString().Trim(); //FTP资源ID(字段类型:char,字段长度:8,是否可空:False)
 objvMicroteachCaseSiteSenateEN.FileOriginalName = objDT.Rows[0][convMicroteachCaseSiteSenate.FileOriginalName].ToString().Trim(); //文件原名(字段类型:varchar,字段长度:200,是否可空:True)
 objvMicroteachCaseSiteSenateEN.FileDirName = objDT.Rows[0][convMicroteachCaseSiteSenate.FileDirName].ToString().Trim(); //文件目录名(字段类型:varchar,字段长度:200,是否可空:True)
 objvMicroteachCaseSiteSenateEN.FileRename = objDT.Rows[0][convMicroteachCaseSiteSenate.FileRename].ToString().Trim(); //文件新名(字段类型:varchar,字段长度:200,是否可空:True)
 objvMicroteachCaseSiteSenateEN.FileUpDate = objDT.Rows[0][convMicroteachCaseSiteSenate.FileUpDate].ToString().Trim(); //创建日期(字段类型:char,字段长度:8,是否可空:True)
 objvMicroteachCaseSiteSenateEN.FileUpTime = objDT.Rows[0][convMicroteachCaseSiteSenate.FileUpTime].ToString().Trim(); //创建时间(字段类型:char,字段长度:6,是否可空:True)
 objvMicroteachCaseSiteSenateEN.SaveMode = TransNullToBool(objDT.Rows[0][convMicroteachCaseSiteSenate.SaveMode].ToString().Trim()); //文件存放方式(字段类型:bit,字段长度:1,是否可空:True)
 objvMicroteachCaseSiteSenateEN.IdResourceType = objDT.Rows[0][convMicroteachCaseSiteSenate.IdResourceType].ToString().Trim(); //资源类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvMicroteachCaseSiteSenateEN.ResourceTypeID = objDT.Rows[0][convMicroteachCaseSiteSenate.ResourceTypeID].ToString().Trim(); //资源类型ID(字段类型:char,字段长度:4,是否可空:False)
 objvMicroteachCaseSiteSenateEN.ResourceTypeName = objDT.Rows[0][convMicroteachCaseSiteSenate.ResourceTypeName].ToString().Trim(); //资源类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvMicroteachCaseSiteSenateEN.ResourceOwner = objDT.Rows[0][convMicroteachCaseSiteSenate.ResourceOwner].ToString().Trim(); //上传者(字段类型:varchar,字段长度:50,是否可空:False)
 objvMicroteachCaseSiteSenateEN.ftpFileType = objDT.Rows[0][convMicroteachCaseSiteSenate.ftpFileType].ToString().Trim(); //ftp文件类型(字段类型:varchar,字段长度:30,是否可空:True)
 objvMicroteachCaseSiteSenateEN.ftpFileSize = objDT.Rows[0][convMicroteachCaseSiteSenate.ftpFileSize].ToString().Trim(); //ftp文件大小(字段类型:varchar,字段长度:50,是否可空:True)
 objvMicroteachCaseSiteSenateEN.ftpResourceOwner = objDT.Rows[0][convMicroteachCaseSiteSenate.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者(字段类型:varchar,字段长度:50,是否可空:True)
 objvMicroteachCaseSiteSenateEN.FileOriginName = objDT.Rows[0][convMicroteachCaseSiteSenate.FileOriginName].ToString().Trim(); //原文件名(字段类型:varchar,字段长度:500,是否可空:True)
 objvMicroteachCaseSiteSenateEN.IsExistFile = TransNullToBool(objDT.Rows[0][convMicroteachCaseSiteSenate.IsExistFile].ToString().Trim()); //是否存在文件(字段类型:bit,字段长度:1,是否可空:True)
 objvMicroteachCaseSiteSenateEN.FileNewName = objDT.Rows[0][convMicroteachCaseSiteSenate.FileNewName].ToString().Trim(); //新文件名(字段类型:varchar,字段长度:530,是否可空:True)
 objvMicroteachCaseSiteSenateEN.FileOldName = objDT.Rows[0][convMicroteachCaseSiteSenate.FileOldName].ToString().Trim(); //旧文件名(字段类型:varchar,字段长度:530,是否可空:True)
 objvMicroteachCaseSiteSenateEN.SiteSenateSenator = objDT.Rows[0][convMicroteachCaseSiteSenate.SiteSenateSenator].ToString().Trim(); //评议者(字段类型:varchar,字段长度:50,是否可空:True)
 objvMicroteachCaseSiteSenateEN.SiteSenateTitle = objDT.Rows[0][convMicroteachCaseSiteSenate.SiteSenateTitle].ToString().Trim(); //评议名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvMicroteachCaseSiteSenateEN.SiteSenateContent = objDT.Rows[0][convMicroteachCaseSiteSenate.SiteSenateContent].ToString().Trim(); //现场评议内容(字段类型:varchar,字段长度:2000,是否可空:True)
 objvMicroteachCaseSiteSenateEN.SiteSenateData = objDT.Rows[0][convMicroteachCaseSiteSenate.SiteSenateData].ToString().Trim(); //现场评议日期(字段类型:char,字段长度:8,是否可空:True)
 objvMicroteachCaseSiteSenateEN.SiteSenateTime = objDT.Rows[0][convMicroteachCaseSiteSenate.SiteSenateTime].ToString().Trim(); //现场评议时间(字段类型:char,字段长度:6,是否可空:True)
 objvMicroteachCaseSiteSenateEN.SiteSenateReadCount = TransNullToInt(objDT.Rows[0][convMicroteachCaseSiteSenate.SiteSenateReadCount].ToString().Trim()); //现场评议阅读次数(字段类型:int,字段长度:4,是否可空:True)
 objvMicroteachCaseSiteSenateEN.Memo = objDT.Rows[0][convMicroteachCaseSiteSenate.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvMicroteachCaseSiteSenateDA: GetvMicroteachCaseSiteSenate)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngIdMicroteachCaseSiteSenate">表关键字</param>
 /// <returns>表对象</returns>
public clsvMicroteachCaseSiteSenateEN GetObjByIdMicroteachCaseSiteSenate(long lngIdMicroteachCaseSiteSenate)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMicroteachCaseSiteSenateDA.GetSpecSQLObj();
strSQL = "Select * from vMicroteachCaseSiteSenate where IdMicroteachCaseSiteSenate = " + ""+ lngIdMicroteachCaseSiteSenate+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvMicroteachCaseSiteSenateEN objvMicroteachCaseSiteSenateEN = new clsvMicroteachCaseSiteSenateEN();
try
{
 objvMicroteachCaseSiteSenateEN.IdMicroteachCaseSiteSenate = Int32.Parse(objRow[convMicroteachCaseSiteSenate.IdMicroteachCaseSiteSenate].ToString().Trim()); //微格现场评议流水号(字段类型:bigint,字段长度:8,是否可空:False)
 objvMicroteachCaseSiteSenateEN.FuncModuleId = objRow[convMicroteachCaseSiteSenate.FuncModuleId].ToString().Trim(); //功能模块Id(字段类型:char,字段长度:4,是否可空:True)
 objvMicroteachCaseSiteSenateEN.FuncModuleName = objRow[convMicroteachCaseSiteSenate.FuncModuleName] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.FuncModuleName].ToString().Trim(); //功能模块名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvMicroteachCaseSiteSenateEN.IdMicroteachCase = objRow[convMicroteachCaseSiteSenate.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号(字段类型:char,字段长度:8,是否可空:False)
 objvMicroteachCaseSiteSenateEN.MicroteachCaseID = objRow[convMicroteachCaseSiteSenate.MicroteachCaseID].ToString().Trim(); //微格教学案例ID(字段类型:char,字段长度:8,是否可空:False)
 objvMicroteachCaseSiteSenateEN.MicroteachCaseName = objRow[convMicroteachCaseSiteSenate.MicroteachCaseName].ToString().Trim(); //微格教学案例名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvMicroteachCaseSiteSenateEN.MicroteachCaseTheme = objRow[convMicroteachCaseSiteSenate.MicroteachCaseTheme] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.MicroteachCaseTheme].ToString().Trim(); //微格教学案例主题词(字段类型:varchar,字段长度:200,是否可空:True)
 objvMicroteachCaseSiteSenateEN.MicroteachCaseDate = objRow[convMicroteachCaseSiteSenate.MicroteachCaseDate] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.MicroteachCaseDate].ToString().Trim(); //微格教学日期(字段类型:char,字段长度:8,是否可空:True)
 objvMicroteachCaseSiteSenateEN.MicroteachCaseTime = objRow[convMicroteachCaseSiteSenate.MicroteachCaseTime] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.MicroteachCaseTime].ToString().Trim(); //微格教学时间(字段类型:char,字段长度:6,是否可空:True)
 objvMicroteachCaseSiteSenateEN.MicroteachCaseDateIn = objRow[convMicroteachCaseSiteSenate.MicroteachCaseDateIn] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.MicroteachCaseDateIn].ToString().Trim(); //案例入库日期(字段类型:char,字段长度:8,是否可空:True)
 objvMicroteachCaseSiteSenateEN.IdStudyLevel = objRow[convMicroteachCaseSiteSenate.IdStudyLevel].ToString().Trim(); //id_StudyLevel(字段类型:char,字段长度:4,是否可空:True)
 objvMicroteachCaseSiteSenateEN.StudyLevelName = objRow[convMicroteachCaseSiteSenate.StudyLevelName].ToString().Trim(); //学段名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvMicroteachCaseSiteSenateEN.IdTeachingPlan = objRow[convMicroteachCaseSiteSenate.IdTeachingPlan].ToString().Trim(); //教案流水号(字段类型:char,字段长度:8,是否可空:False)
 objvMicroteachCaseSiteSenateEN.MicroTeachCaseTimeIn = objRow[convMicroteachCaseSiteSenate.MicroTeachCaseTimeIn] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.MicroTeachCaseTimeIn].ToString().Trim(); //案例入库时间(字段类型:char,字段长度:6,是否可空:True)
 objvMicroteachCaseSiteSenateEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCaseSiteSenate.IsVisible].ToString().Trim()); //是否显示(字段类型:bit,字段长度:1,是否可空:True)
 objvMicroteachCaseSiteSenateEN.microteachCaseText = objRow[convMicroteachCaseSiteSenate.microteachCaseText] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.microteachCaseText].ToString().Trim(); //案例文本内容(字段类型:varchar,字段长度:8000,是否可空:True)
 objvMicroteachCaseSiteSenateEN.OwnerId = objRow[convMicroteachCaseSiteSenate.OwnerId] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.OwnerId].ToString().Trim(); //拥有者Id(字段类型:varchar,字段长度:20,是否可空:False)
 objvMicroteachCaseSiteSenateEN.StuName = objRow[convMicroteachCaseSiteSenate.StuName].ToString().Trim(); //姓名(字段类型:varchar,字段长度:50,是否可空:True)
 objvMicroteachCaseSiteSenateEN.StuID = objRow[convMicroteachCaseSiteSenate.StuID].ToString().Trim(); //学号(字段类型:varchar,字段长度:20,是否可空:True)
 objvMicroteachCaseSiteSenateEN.PoliticsName = objRow[convMicroteachCaseSiteSenate.PoliticsName].ToString().Trim(); //政治面貌(字段类型:varchar,字段长度:30,是否可空:False)
 objvMicroteachCaseSiteSenateEN.SexDesc = objRow[convMicroteachCaseSiteSenate.SexDesc] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.SexDesc].ToString().Trim(); //性别名称(字段类型:varchar,字段长度:10,是否可空:True)
 objvMicroteachCaseSiteSenateEN.EthnicName = objRow[convMicroteachCaseSiteSenate.EthnicName].ToString().Trim(); //民族名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvMicroteachCaseSiteSenateEN.UniZoneDesc = objRow[convMicroteachCaseSiteSenate.UniZoneDesc].ToString().Trim(); //校区名称(字段类型:varchar,字段长度:20,是否可空:False)
 objvMicroteachCaseSiteSenateEN.StuTypeDesc = objRow[convMicroteachCaseSiteSenate.StuTypeDesc].ToString().Trim(); //学生类别名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvMicroteachCaseSiteSenateEN.IdXzCollege = objRow[convMicroteachCaseSiteSenate.IdXzCollege] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.IdXzCollege].ToString().Trim(); //学院流水号(字段类型:char,字段长度:4,是否可空:True)
 objvMicroteachCaseSiteSenateEN.CollegeName = objRow[convMicroteachCaseSiteSenate.CollegeName].ToString().Trim(); //学院名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvMicroteachCaseSiteSenateEN.IdXzMajor = objRow[convMicroteachCaseSiteSenate.IdXzMajor] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.IdXzMajor].ToString().Trim(); //专业流水号(字段类型:char,字段长度:8,是否可空:False)
 objvMicroteachCaseSiteSenateEN.MajorName = objRow[convMicroteachCaseSiteSenate.MajorName].ToString().Trim(); //专业名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvMicroteachCaseSiteSenateEN.IdGradeBase = objRow[convMicroteachCaseSiteSenate.IdGradeBase].ToString().Trim(); //年级流水号(字段类型:char,字段长度:4,是否可空:True)
 objvMicroteachCaseSiteSenateEN.GradeBaseName = objRow[convMicroteachCaseSiteSenate.GradeBaseName] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.GradeBaseName].ToString().Trim(); //年级名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvMicroteachCaseSiteSenateEN.Birthday = objRow[convMicroteachCaseSiteSenate.Birthday] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.Birthday].ToString().Trim(); //出生日期(字段类型:char,字段长度:8,是否可空:True)
 objvMicroteachCaseSiteSenateEN.NativePlace = objRow[convMicroteachCaseSiteSenate.NativePlace] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.NativePlace].ToString().Trim(); //籍贯(字段类型:varchar,字段长度:200,是否可空:True)
 objvMicroteachCaseSiteSenateEN.Duty = objRow[convMicroteachCaseSiteSenate.Duty] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.Duty].ToString().Trim(); //职位(字段类型:varchar,字段长度:30,是否可空:True)
 objvMicroteachCaseSiteSenateEN.IDCardNo = objRow[convMicroteachCaseSiteSenate.IDCardNo] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.IDCardNo].ToString().Trim(); //身份证号(字段类型:varchar,字段长度:20,是否可空:True)
 objvMicroteachCaseSiteSenateEN.StuCardNo = objRow[convMicroteachCaseSiteSenate.StuCardNo] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.StuCardNo].ToString().Trim(); //学生证号(字段类型:varchar,字段长度:20,是否可空:True)
 objvMicroteachCaseSiteSenateEN.LiveAddress = objRow[convMicroteachCaseSiteSenate.LiveAddress] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.LiveAddress].ToString().Trim(); //居住地址(字段类型:varchar,字段长度:200,是否可空:True)
 objvMicroteachCaseSiteSenateEN.HomePhone = objRow[convMicroteachCaseSiteSenate.HomePhone] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.HomePhone].ToString().Trim(); //住宅电话(字段类型:varchar,字段长度:20,是否可空:True)
 objvMicroteachCaseSiteSenateEN.EnrollmentDate = objRow[convMicroteachCaseSiteSenate.EnrollmentDate] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.EnrollmentDate].ToString().Trim(); //入校日期(字段类型:varchar,字段长度:8,是否可空:True)
 objvMicroteachCaseSiteSenateEN.PostCode = objRow[convMicroteachCaseSiteSenate.PostCode] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.PostCode].ToString().Trim(); //邮编(字段类型:char,字段长度:6,是否可空:True)
 objvMicroteachCaseSiteSenateEN.BrowseCount4Case = objRow[convMicroteachCaseSiteSenate.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachCaseSiteSenate.BrowseCount4Case].ToString().Trim()); //课例浏览次数(字段类型:int,字段长度:4,是否可空:True)
 objvMicroteachCaseSiteSenateEN.IdMicroteachCaseSiteSenateType = objRow[convMicroteachCaseSiteSenate.IdMicroteachCaseSiteSenateType].ToString().Trim(); //微格现场评价类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvMicroteachCaseSiteSenateEN.MicroteachCaseSiteSenateTypeID = objRow[convMicroteachCaseSiteSenate.MicroteachCaseSiteSenateTypeID].ToString().Trim(); //微格现场评价类型ID(字段类型:char,字段长度:4,是否可空:False)
 objvMicroteachCaseSiteSenateEN.MicroteachCaseSiteSenateTypeName = objRow[convMicroteachCaseSiteSenate.MicroteachCaseSiteSenateTypeName].ToString().Trim(); //微格现场评价类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvMicroteachCaseSiteSenateEN.IdResource = objRow[convMicroteachCaseSiteSenate.IdResource].ToString().Trim(); //资源流水号(字段类型:char,字段长度:8,是否可空:False)
 objvMicroteachCaseSiteSenateEN.ResourceID = objRow[convMicroteachCaseSiteSenate.ResourceID].ToString().Trim(); //资源ID(字段类型:char,字段长度:8,是否可空:False)
 objvMicroteachCaseSiteSenateEN.ResourceName = objRow[convMicroteachCaseSiteSenate.ResourceName] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.ResourceName].ToString().Trim(); //资源名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvMicroteachCaseSiteSenateEN.IdFtpResource = objRow[convMicroteachCaseSiteSenate.IdFtpResource] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.IdFtpResource].ToString().Trim(); //FTP资源流水号(字段类型:char,字段长度:8,是否可空:True)
 objvMicroteachCaseSiteSenateEN.IdFile = objRow[convMicroteachCaseSiteSenate.IdFile] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.IdFile].ToString().Trim(); //文件流水号(字段类型:char,字段长度:8,是否可空:True)
 objvMicroteachCaseSiteSenateEN.FileName = objRow[convMicroteachCaseSiteSenate.FileName] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.FileName].ToString().Trim(); //文件名称(字段类型:varchar,字段长度:500,是否可空:True)
 objvMicroteachCaseSiteSenateEN.FileType = objRow[convMicroteachCaseSiteSenate.FileType] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.FileType].ToString().Trim(); //文件类型(字段类型:varchar,字段长度:30,是否可空:True)
 objvMicroteachCaseSiteSenateEN.SaveDate = objRow[convMicroteachCaseSiteSenate.SaveDate] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.SaveDate].ToString().Trim(); //创建日期(字段类型:char,字段长度:8,是否可空:True)
 objvMicroteachCaseSiteSenateEN.FileSize = objRow[convMicroteachCaseSiteSenate.FileSize] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.FileSize].ToString().Trim(); //文件大小(字段类型:varchar,字段长度:50,是否可空:True)
 objvMicroteachCaseSiteSenateEN.SaveTime = objRow[convMicroteachCaseSiteSenate.SaveTime] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.SaveTime].ToString().Trim(); //创建时间(字段类型:char,字段长度:6,是否可空:True)
 objvMicroteachCaseSiteSenateEN.FtpResourceID = objRow[convMicroteachCaseSiteSenate.FtpResourceID].ToString().Trim(); //FTP资源ID(字段类型:char,字段长度:8,是否可空:False)
 objvMicroteachCaseSiteSenateEN.FileOriginalName = objRow[convMicroteachCaseSiteSenate.FileOriginalName] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.FileOriginalName].ToString().Trim(); //文件原名(字段类型:varchar,字段长度:200,是否可空:True)
 objvMicroteachCaseSiteSenateEN.FileDirName = objRow[convMicroteachCaseSiteSenate.FileDirName] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.FileDirName].ToString().Trim(); //文件目录名(字段类型:varchar,字段长度:200,是否可空:True)
 objvMicroteachCaseSiteSenateEN.FileRename = objRow[convMicroteachCaseSiteSenate.FileRename] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.FileRename].ToString().Trim(); //文件新名(字段类型:varchar,字段长度:200,是否可空:True)
 objvMicroteachCaseSiteSenateEN.FileUpDate = objRow[convMicroteachCaseSiteSenate.FileUpDate] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.FileUpDate].ToString().Trim(); //创建日期(字段类型:char,字段长度:8,是否可空:True)
 objvMicroteachCaseSiteSenateEN.FileUpTime = objRow[convMicroteachCaseSiteSenate.FileUpTime] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.FileUpTime].ToString().Trim(); //创建时间(字段类型:char,字段长度:6,是否可空:True)
 objvMicroteachCaseSiteSenateEN.SaveMode = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCaseSiteSenate.SaveMode].ToString().Trim()); //文件存放方式(字段类型:bit,字段长度:1,是否可空:True)
 objvMicroteachCaseSiteSenateEN.IdResourceType = objRow[convMicroteachCaseSiteSenate.IdResourceType].ToString().Trim(); //资源类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvMicroteachCaseSiteSenateEN.ResourceTypeID = objRow[convMicroteachCaseSiteSenate.ResourceTypeID].ToString().Trim(); //资源类型ID(字段类型:char,字段长度:4,是否可空:False)
 objvMicroteachCaseSiteSenateEN.ResourceTypeName = objRow[convMicroteachCaseSiteSenate.ResourceTypeName].ToString().Trim(); //资源类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvMicroteachCaseSiteSenateEN.ResourceOwner = objRow[convMicroteachCaseSiteSenate.ResourceOwner].ToString().Trim(); //上传者(字段类型:varchar,字段长度:50,是否可空:False)
 objvMicroteachCaseSiteSenateEN.ftpFileType = objRow[convMicroteachCaseSiteSenate.ftpFileType] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.ftpFileType].ToString().Trim(); //ftp文件类型(字段类型:varchar,字段长度:30,是否可空:True)
 objvMicroteachCaseSiteSenateEN.ftpFileSize = objRow[convMicroteachCaseSiteSenate.ftpFileSize] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.ftpFileSize].ToString().Trim(); //ftp文件大小(字段类型:varchar,字段长度:50,是否可空:True)
 objvMicroteachCaseSiteSenateEN.ftpResourceOwner = objRow[convMicroteachCaseSiteSenate.ftpResourceOwner] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者(字段类型:varchar,字段长度:50,是否可空:True)
 objvMicroteachCaseSiteSenateEN.FileOriginName = objRow[convMicroteachCaseSiteSenate.FileOriginName] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.FileOriginName].ToString().Trim(); //原文件名(字段类型:varchar,字段长度:500,是否可空:True)
 objvMicroteachCaseSiteSenateEN.IsExistFile = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCaseSiteSenate.IsExistFile].ToString().Trim()); //是否存在文件(字段类型:bit,字段长度:1,是否可空:True)
 objvMicroteachCaseSiteSenateEN.FileNewName = objRow[convMicroteachCaseSiteSenate.FileNewName] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.FileNewName].ToString().Trim(); //新文件名(字段类型:varchar,字段长度:530,是否可空:True)
 objvMicroteachCaseSiteSenateEN.FileOldName = objRow[convMicroteachCaseSiteSenate.FileOldName] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.FileOldName].ToString().Trim(); //旧文件名(字段类型:varchar,字段长度:530,是否可空:True)
 objvMicroteachCaseSiteSenateEN.SiteSenateSenator = objRow[convMicroteachCaseSiteSenate.SiteSenateSenator] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.SiteSenateSenator].ToString().Trim(); //评议者(字段类型:varchar,字段长度:50,是否可空:True)
 objvMicroteachCaseSiteSenateEN.SiteSenateTitle = objRow[convMicroteachCaseSiteSenate.SiteSenateTitle].ToString().Trim(); //评议名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvMicroteachCaseSiteSenateEN.SiteSenateContent = objRow[convMicroteachCaseSiteSenate.SiteSenateContent] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.SiteSenateContent].ToString().Trim(); //现场评议内容(字段类型:varchar,字段长度:2000,是否可空:True)
 objvMicroteachCaseSiteSenateEN.SiteSenateData = objRow[convMicroteachCaseSiteSenate.SiteSenateData] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.SiteSenateData].ToString().Trim(); //现场评议日期(字段类型:char,字段长度:8,是否可空:True)
 objvMicroteachCaseSiteSenateEN.SiteSenateTime = objRow[convMicroteachCaseSiteSenate.SiteSenateTime] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.SiteSenateTime].ToString().Trim(); //现场评议时间(字段类型:char,字段长度:6,是否可空:True)
 objvMicroteachCaseSiteSenateEN.SiteSenateReadCount = objRow[convMicroteachCaseSiteSenate.SiteSenateReadCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachCaseSiteSenate.SiteSenateReadCount].ToString().Trim()); //现场评议阅读次数(字段类型:int,字段长度:4,是否可空:True)
 objvMicroteachCaseSiteSenateEN.Memo = objRow[convMicroteachCaseSiteSenate.Memo] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvMicroteachCaseSiteSenateDA: GetObjByIdMicroteachCaseSiteSenate)", objException.Message));
}
return objvMicroteachCaseSiteSenateEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvMicroteachCaseSiteSenateEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvMicroteachCaseSiteSenateDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMicroteachCaseSiteSenateDA.GetSpecSQLObj();
strSQL = "Select * from vMicroteachCaseSiteSenate where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvMicroteachCaseSiteSenateEN objvMicroteachCaseSiteSenateEN = new clsvMicroteachCaseSiteSenateEN()
{
IdMicroteachCaseSiteSenate = TransNullToInt(objRow[convMicroteachCaseSiteSenate.IdMicroteachCaseSiteSenate].ToString().Trim()), //微格现场评议流水号
FuncModuleId = objRow[convMicroteachCaseSiteSenate.FuncModuleId].ToString().Trim(), //功能模块Id
FuncModuleName = objRow[convMicroteachCaseSiteSenate.FuncModuleName] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.FuncModuleName].ToString().Trim(), //功能模块名称
IdMicroteachCase = objRow[convMicroteachCaseSiteSenate.IdMicroteachCase].ToString().Trim(), //微格教学案例流水号
MicroteachCaseID = objRow[convMicroteachCaseSiteSenate.MicroteachCaseID].ToString().Trim(), //微格教学案例ID
MicroteachCaseName = objRow[convMicroteachCaseSiteSenate.MicroteachCaseName].ToString().Trim(), //微格教学案例名称
MicroteachCaseTheme = objRow[convMicroteachCaseSiteSenate.MicroteachCaseTheme] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.MicroteachCaseTheme].ToString().Trim(), //微格教学案例主题词
MicroteachCaseDate = objRow[convMicroteachCaseSiteSenate.MicroteachCaseDate] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.MicroteachCaseDate].ToString().Trim(), //微格教学日期
MicroteachCaseTime = objRow[convMicroteachCaseSiteSenate.MicroteachCaseTime] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.MicroteachCaseTime].ToString().Trim(), //微格教学时间
MicroteachCaseDateIn = objRow[convMicroteachCaseSiteSenate.MicroteachCaseDateIn] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.MicroteachCaseDateIn].ToString().Trim(), //案例入库日期
IdStudyLevel = objRow[convMicroteachCaseSiteSenate.IdStudyLevel].ToString().Trim(), //id_StudyLevel
StudyLevelName = objRow[convMicroteachCaseSiteSenate.StudyLevelName].ToString().Trim(), //学段名称
IdTeachingPlan = objRow[convMicroteachCaseSiteSenate.IdTeachingPlan].ToString().Trim(), //教案流水号
MicroTeachCaseTimeIn = objRow[convMicroteachCaseSiteSenate.MicroTeachCaseTimeIn] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.MicroTeachCaseTimeIn].ToString().Trim(), //案例入库时间
IsVisible = TransNullToBool(objRow[convMicroteachCaseSiteSenate.IsVisible].ToString().Trim()), //是否显示
microteachCaseText = objRow[convMicroteachCaseSiteSenate.microteachCaseText] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.microteachCaseText].ToString().Trim(), //案例文本内容
OwnerId = objRow[convMicroteachCaseSiteSenate.OwnerId] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.OwnerId].ToString().Trim(), //拥有者Id
StuName = objRow[convMicroteachCaseSiteSenate.StuName].ToString().Trim(), //姓名
StuID = objRow[convMicroteachCaseSiteSenate.StuID].ToString().Trim(), //学号
PoliticsName = objRow[convMicroteachCaseSiteSenate.PoliticsName].ToString().Trim(), //政治面貌
SexDesc = objRow[convMicroteachCaseSiteSenate.SexDesc] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.SexDesc].ToString().Trim(), //性别名称
EthnicName = objRow[convMicroteachCaseSiteSenate.EthnicName].ToString().Trim(), //民族名称
UniZoneDesc = objRow[convMicroteachCaseSiteSenate.UniZoneDesc].ToString().Trim(), //校区名称
StuTypeDesc = objRow[convMicroteachCaseSiteSenate.StuTypeDesc].ToString().Trim(), //学生类别名称
IdXzCollege = objRow[convMicroteachCaseSiteSenate.IdXzCollege] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.IdXzCollege].ToString().Trim(), //学院流水号
CollegeName = objRow[convMicroteachCaseSiteSenate.CollegeName].ToString().Trim(), //学院名称
IdXzMajor = objRow[convMicroteachCaseSiteSenate.IdXzMajor] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.IdXzMajor].ToString().Trim(), //专业流水号
MajorName = objRow[convMicroteachCaseSiteSenate.MajorName].ToString().Trim(), //专业名称
IdGradeBase = objRow[convMicroteachCaseSiteSenate.IdGradeBase].ToString().Trim(), //年级流水号
GradeBaseName = objRow[convMicroteachCaseSiteSenate.GradeBaseName] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.GradeBaseName].ToString().Trim(), //年级名称
Birthday = objRow[convMicroteachCaseSiteSenate.Birthday] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.Birthday].ToString().Trim(), //出生日期
NativePlace = objRow[convMicroteachCaseSiteSenate.NativePlace] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.NativePlace].ToString().Trim(), //籍贯
Duty = objRow[convMicroteachCaseSiteSenate.Duty] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.Duty].ToString().Trim(), //职位
IDCardNo = objRow[convMicroteachCaseSiteSenate.IDCardNo] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.IDCardNo].ToString().Trim(), //身份证号
StuCardNo = objRow[convMicroteachCaseSiteSenate.StuCardNo] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.StuCardNo].ToString().Trim(), //学生证号
LiveAddress = objRow[convMicroteachCaseSiteSenate.LiveAddress] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.LiveAddress].ToString().Trim(), //居住地址
HomePhone = objRow[convMicroteachCaseSiteSenate.HomePhone] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.HomePhone].ToString().Trim(), //住宅电话
EnrollmentDate = objRow[convMicroteachCaseSiteSenate.EnrollmentDate] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.EnrollmentDate].ToString().Trim(), //入校日期
PostCode = objRow[convMicroteachCaseSiteSenate.PostCode] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.PostCode].ToString().Trim(), //邮编
BrowseCount4Case = objRow[convMicroteachCaseSiteSenate.BrowseCount4Case] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convMicroteachCaseSiteSenate.BrowseCount4Case].ToString().Trim()), //课例浏览次数
IdMicroteachCaseSiteSenateType = objRow[convMicroteachCaseSiteSenate.IdMicroteachCaseSiteSenateType].ToString().Trim(), //微格现场评价类型流水号
MicroteachCaseSiteSenateTypeID = objRow[convMicroteachCaseSiteSenate.MicroteachCaseSiteSenateTypeID].ToString().Trim(), //微格现场评价类型ID
MicroteachCaseSiteSenateTypeName = objRow[convMicroteachCaseSiteSenate.MicroteachCaseSiteSenateTypeName].ToString().Trim(), //微格现场评价类型名称
IdResource = objRow[convMicroteachCaseSiteSenate.IdResource].ToString().Trim(), //资源流水号
ResourceID = objRow[convMicroteachCaseSiteSenate.ResourceID].ToString().Trim(), //资源ID
ResourceName = objRow[convMicroteachCaseSiteSenate.ResourceName] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.ResourceName].ToString().Trim(), //资源名称
IdFtpResource = objRow[convMicroteachCaseSiteSenate.IdFtpResource] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.IdFtpResource].ToString().Trim(), //FTP资源流水号
IdFile = objRow[convMicroteachCaseSiteSenate.IdFile] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.IdFile].ToString().Trim(), //文件流水号
FileName = objRow[convMicroteachCaseSiteSenate.FileName] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.FileName].ToString().Trim(), //文件名称
FileType = objRow[convMicroteachCaseSiteSenate.FileType] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.FileType].ToString().Trim(), //文件类型
SaveDate = objRow[convMicroteachCaseSiteSenate.SaveDate] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.SaveDate].ToString().Trim(), //创建日期
FileSize = objRow[convMicroteachCaseSiteSenate.FileSize] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.FileSize].ToString().Trim(), //文件大小
SaveTime = objRow[convMicroteachCaseSiteSenate.SaveTime] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.SaveTime].ToString().Trim(), //创建时间
FtpResourceID = objRow[convMicroteachCaseSiteSenate.FtpResourceID].ToString().Trim(), //FTP资源ID
FileOriginalName = objRow[convMicroteachCaseSiteSenate.FileOriginalName] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.FileOriginalName].ToString().Trim(), //文件原名
FileDirName = objRow[convMicroteachCaseSiteSenate.FileDirName] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.FileDirName].ToString().Trim(), //文件目录名
FileRename = objRow[convMicroteachCaseSiteSenate.FileRename] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.FileRename].ToString().Trim(), //文件新名
FileUpDate = objRow[convMicroteachCaseSiteSenate.FileUpDate] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.FileUpDate].ToString().Trim(), //创建日期
FileUpTime = objRow[convMicroteachCaseSiteSenate.FileUpTime] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.FileUpTime].ToString().Trim(), //创建时间
SaveMode = TransNullToBool(objRow[convMicroteachCaseSiteSenate.SaveMode].ToString().Trim()), //文件存放方式
IdResourceType = objRow[convMicroteachCaseSiteSenate.IdResourceType].ToString().Trim(), //资源类型流水号
ResourceTypeID = objRow[convMicroteachCaseSiteSenate.ResourceTypeID].ToString().Trim(), //资源类型ID
ResourceTypeName = objRow[convMicroteachCaseSiteSenate.ResourceTypeName].ToString().Trim(), //资源类型名称
ResourceOwner = objRow[convMicroteachCaseSiteSenate.ResourceOwner].ToString().Trim(), //上传者
ftpFileType = objRow[convMicroteachCaseSiteSenate.ftpFileType] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.ftpFileType].ToString().Trim(), //ftp文件类型
ftpFileSize = objRow[convMicroteachCaseSiteSenate.ftpFileSize] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.ftpFileSize].ToString().Trim(), //ftp文件大小
ftpResourceOwner = objRow[convMicroteachCaseSiteSenate.ftpResourceOwner] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.ftpResourceOwner].ToString().Trim(), //Ftp资源拥有者
FileOriginName = objRow[convMicroteachCaseSiteSenate.FileOriginName] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.FileOriginName].ToString().Trim(), //原文件名
IsExistFile = TransNullToBool(objRow[convMicroteachCaseSiteSenate.IsExistFile].ToString().Trim()), //是否存在文件
FileNewName = objRow[convMicroteachCaseSiteSenate.FileNewName] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.FileNewName].ToString().Trim(), //新文件名
FileOldName = objRow[convMicroteachCaseSiteSenate.FileOldName] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.FileOldName].ToString().Trim(), //旧文件名
SiteSenateSenator = objRow[convMicroteachCaseSiteSenate.SiteSenateSenator] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.SiteSenateSenator].ToString().Trim(), //评议者
SiteSenateTitle = objRow[convMicroteachCaseSiteSenate.SiteSenateTitle].ToString().Trim(), //评议名称
SiteSenateContent = objRow[convMicroteachCaseSiteSenate.SiteSenateContent] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.SiteSenateContent].ToString().Trim(), //现场评议内容
SiteSenateData = objRow[convMicroteachCaseSiteSenate.SiteSenateData] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.SiteSenateData].ToString().Trim(), //现场评议日期
SiteSenateTime = objRow[convMicroteachCaseSiteSenate.SiteSenateTime] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.SiteSenateTime].ToString().Trim(), //现场评议时间
SiteSenateReadCount = objRow[convMicroteachCaseSiteSenate.SiteSenateReadCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convMicroteachCaseSiteSenate.SiteSenateReadCount].ToString().Trim()), //现场评议阅读次数
Memo = objRow[convMicroteachCaseSiteSenate.Memo] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.Memo].ToString().Trim() //备注
};
objvMicroteachCaseSiteSenateEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvMicroteachCaseSiteSenateEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvMicroteachCaseSiteSenateDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvMicroteachCaseSiteSenateEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvMicroteachCaseSiteSenateEN objvMicroteachCaseSiteSenateEN = new clsvMicroteachCaseSiteSenateEN();
try
{
objvMicroteachCaseSiteSenateEN.IdMicroteachCaseSiteSenate = TransNullToInt(objRow[convMicroteachCaseSiteSenate.IdMicroteachCaseSiteSenate].ToString().Trim()); //微格现场评议流水号
objvMicroteachCaseSiteSenateEN.FuncModuleId = objRow[convMicroteachCaseSiteSenate.FuncModuleId].ToString().Trim(); //功能模块Id
objvMicroteachCaseSiteSenateEN.FuncModuleName = objRow[convMicroteachCaseSiteSenate.FuncModuleName] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.FuncModuleName].ToString().Trim(); //功能模块名称
objvMicroteachCaseSiteSenateEN.IdMicroteachCase = objRow[convMicroteachCaseSiteSenate.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvMicroteachCaseSiteSenateEN.MicroteachCaseID = objRow[convMicroteachCaseSiteSenate.MicroteachCaseID].ToString().Trim(); //微格教学案例ID
objvMicroteachCaseSiteSenateEN.MicroteachCaseName = objRow[convMicroteachCaseSiteSenate.MicroteachCaseName].ToString().Trim(); //微格教学案例名称
objvMicroteachCaseSiteSenateEN.MicroteachCaseTheme = objRow[convMicroteachCaseSiteSenate.MicroteachCaseTheme] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.MicroteachCaseTheme].ToString().Trim(); //微格教学案例主题词
objvMicroteachCaseSiteSenateEN.MicroteachCaseDate = objRow[convMicroteachCaseSiteSenate.MicroteachCaseDate] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.MicroteachCaseDate].ToString().Trim(); //微格教学日期
objvMicroteachCaseSiteSenateEN.MicroteachCaseTime = objRow[convMicroteachCaseSiteSenate.MicroteachCaseTime] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.MicroteachCaseTime].ToString().Trim(); //微格教学时间
objvMicroteachCaseSiteSenateEN.MicroteachCaseDateIn = objRow[convMicroteachCaseSiteSenate.MicroteachCaseDateIn] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.MicroteachCaseDateIn].ToString().Trim(); //案例入库日期
objvMicroteachCaseSiteSenateEN.IdStudyLevel = objRow[convMicroteachCaseSiteSenate.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvMicroteachCaseSiteSenateEN.StudyLevelName = objRow[convMicroteachCaseSiteSenate.StudyLevelName].ToString().Trim(); //学段名称
objvMicroteachCaseSiteSenateEN.IdTeachingPlan = objRow[convMicroteachCaseSiteSenate.IdTeachingPlan].ToString().Trim(); //教案流水号
objvMicroteachCaseSiteSenateEN.MicroTeachCaseTimeIn = objRow[convMicroteachCaseSiteSenate.MicroTeachCaseTimeIn] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.MicroTeachCaseTimeIn].ToString().Trim(); //案例入库时间
objvMicroteachCaseSiteSenateEN.IsVisible = TransNullToBool(objRow[convMicroteachCaseSiteSenate.IsVisible].ToString().Trim()); //是否显示
objvMicroteachCaseSiteSenateEN.microteachCaseText = objRow[convMicroteachCaseSiteSenate.microteachCaseText] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.microteachCaseText].ToString().Trim(); //案例文本内容
objvMicroteachCaseSiteSenateEN.OwnerId = objRow[convMicroteachCaseSiteSenate.OwnerId] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.OwnerId].ToString().Trim(); //拥有者Id
objvMicroteachCaseSiteSenateEN.StuName = objRow[convMicroteachCaseSiteSenate.StuName].ToString().Trim(); //姓名
objvMicroteachCaseSiteSenateEN.StuID = objRow[convMicroteachCaseSiteSenate.StuID].ToString().Trim(); //学号
objvMicroteachCaseSiteSenateEN.PoliticsName = objRow[convMicroteachCaseSiteSenate.PoliticsName].ToString().Trim(); //政治面貌
objvMicroteachCaseSiteSenateEN.SexDesc = objRow[convMicroteachCaseSiteSenate.SexDesc] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.SexDesc].ToString().Trim(); //性别名称
objvMicroteachCaseSiteSenateEN.EthnicName = objRow[convMicroteachCaseSiteSenate.EthnicName].ToString().Trim(); //民族名称
objvMicroteachCaseSiteSenateEN.UniZoneDesc = objRow[convMicroteachCaseSiteSenate.UniZoneDesc].ToString().Trim(); //校区名称
objvMicroteachCaseSiteSenateEN.StuTypeDesc = objRow[convMicroteachCaseSiteSenate.StuTypeDesc].ToString().Trim(); //学生类别名称
objvMicroteachCaseSiteSenateEN.IdXzCollege = objRow[convMicroteachCaseSiteSenate.IdXzCollege] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.IdXzCollege].ToString().Trim(); //学院流水号
objvMicroteachCaseSiteSenateEN.CollegeName = objRow[convMicroteachCaseSiteSenate.CollegeName].ToString().Trim(); //学院名称
objvMicroteachCaseSiteSenateEN.IdXzMajor = objRow[convMicroteachCaseSiteSenate.IdXzMajor] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.IdXzMajor].ToString().Trim(); //专业流水号
objvMicroteachCaseSiteSenateEN.MajorName = objRow[convMicroteachCaseSiteSenate.MajorName].ToString().Trim(); //专业名称
objvMicroteachCaseSiteSenateEN.IdGradeBase = objRow[convMicroteachCaseSiteSenate.IdGradeBase].ToString().Trim(); //年级流水号
objvMicroteachCaseSiteSenateEN.GradeBaseName = objRow[convMicroteachCaseSiteSenate.GradeBaseName] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.GradeBaseName].ToString().Trim(); //年级名称
objvMicroteachCaseSiteSenateEN.Birthday = objRow[convMicroteachCaseSiteSenate.Birthday] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.Birthday].ToString().Trim(); //出生日期
objvMicroteachCaseSiteSenateEN.NativePlace = objRow[convMicroteachCaseSiteSenate.NativePlace] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.NativePlace].ToString().Trim(); //籍贯
objvMicroteachCaseSiteSenateEN.Duty = objRow[convMicroteachCaseSiteSenate.Duty] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.Duty].ToString().Trim(); //职位
objvMicroteachCaseSiteSenateEN.IDCardNo = objRow[convMicroteachCaseSiteSenate.IDCardNo] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.IDCardNo].ToString().Trim(); //身份证号
objvMicroteachCaseSiteSenateEN.StuCardNo = objRow[convMicroteachCaseSiteSenate.StuCardNo] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.StuCardNo].ToString().Trim(); //学生证号
objvMicroteachCaseSiteSenateEN.LiveAddress = objRow[convMicroteachCaseSiteSenate.LiveAddress] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.LiveAddress].ToString().Trim(); //居住地址
objvMicroteachCaseSiteSenateEN.HomePhone = objRow[convMicroteachCaseSiteSenate.HomePhone] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.HomePhone].ToString().Trim(); //住宅电话
objvMicroteachCaseSiteSenateEN.EnrollmentDate = objRow[convMicroteachCaseSiteSenate.EnrollmentDate] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.EnrollmentDate].ToString().Trim(); //入校日期
objvMicroteachCaseSiteSenateEN.PostCode = objRow[convMicroteachCaseSiteSenate.PostCode] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.PostCode].ToString().Trim(); //邮编
objvMicroteachCaseSiteSenateEN.BrowseCount4Case = objRow[convMicroteachCaseSiteSenate.BrowseCount4Case] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convMicroteachCaseSiteSenate.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvMicroteachCaseSiteSenateEN.IdMicroteachCaseSiteSenateType = objRow[convMicroteachCaseSiteSenate.IdMicroteachCaseSiteSenateType].ToString().Trim(); //微格现场评价类型流水号
objvMicroteachCaseSiteSenateEN.MicroteachCaseSiteSenateTypeID = objRow[convMicroteachCaseSiteSenate.MicroteachCaseSiteSenateTypeID].ToString().Trim(); //微格现场评价类型ID
objvMicroteachCaseSiteSenateEN.MicroteachCaseSiteSenateTypeName = objRow[convMicroteachCaseSiteSenate.MicroteachCaseSiteSenateTypeName].ToString().Trim(); //微格现场评价类型名称
objvMicroteachCaseSiteSenateEN.IdResource = objRow[convMicroteachCaseSiteSenate.IdResource].ToString().Trim(); //资源流水号
objvMicroteachCaseSiteSenateEN.ResourceID = objRow[convMicroteachCaseSiteSenate.ResourceID].ToString().Trim(); //资源ID
objvMicroteachCaseSiteSenateEN.ResourceName = objRow[convMicroteachCaseSiteSenate.ResourceName] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.ResourceName].ToString().Trim(); //资源名称
objvMicroteachCaseSiteSenateEN.IdFtpResource = objRow[convMicroteachCaseSiteSenate.IdFtpResource] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvMicroteachCaseSiteSenateEN.IdFile = objRow[convMicroteachCaseSiteSenate.IdFile] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.IdFile].ToString().Trim(); //文件流水号
objvMicroteachCaseSiteSenateEN.FileName = objRow[convMicroteachCaseSiteSenate.FileName] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.FileName].ToString().Trim(); //文件名称
objvMicroteachCaseSiteSenateEN.FileType = objRow[convMicroteachCaseSiteSenate.FileType] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.FileType].ToString().Trim(); //文件类型
objvMicroteachCaseSiteSenateEN.SaveDate = objRow[convMicroteachCaseSiteSenate.SaveDate] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.SaveDate].ToString().Trim(); //创建日期
objvMicroteachCaseSiteSenateEN.FileSize = objRow[convMicroteachCaseSiteSenate.FileSize] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.FileSize].ToString().Trim(); //文件大小
objvMicroteachCaseSiteSenateEN.SaveTime = objRow[convMicroteachCaseSiteSenate.SaveTime] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.SaveTime].ToString().Trim(); //创建时间
objvMicroteachCaseSiteSenateEN.FtpResourceID = objRow[convMicroteachCaseSiteSenate.FtpResourceID].ToString().Trim(); //FTP资源ID
objvMicroteachCaseSiteSenateEN.FileOriginalName = objRow[convMicroteachCaseSiteSenate.FileOriginalName] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.FileOriginalName].ToString().Trim(); //文件原名
objvMicroteachCaseSiteSenateEN.FileDirName = objRow[convMicroteachCaseSiteSenate.FileDirName] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.FileDirName].ToString().Trim(); //文件目录名
objvMicroteachCaseSiteSenateEN.FileRename = objRow[convMicroteachCaseSiteSenate.FileRename] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.FileRename].ToString().Trim(); //文件新名
objvMicroteachCaseSiteSenateEN.FileUpDate = objRow[convMicroteachCaseSiteSenate.FileUpDate] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.FileUpDate].ToString().Trim(); //创建日期
objvMicroteachCaseSiteSenateEN.FileUpTime = objRow[convMicroteachCaseSiteSenate.FileUpTime] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.FileUpTime].ToString().Trim(); //创建时间
objvMicroteachCaseSiteSenateEN.SaveMode = TransNullToBool(objRow[convMicroteachCaseSiteSenate.SaveMode].ToString().Trim()); //文件存放方式
objvMicroteachCaseSiteSenateEN.IdResourceType = objRow[convMicroteachCaseSiteSenate.IdResourceType].ToString().Trim(); //资源类型流水号
objvMicroteachCaseSiteSenateEN.ResourceTypeID = objRow[convMicroteachCaseSiteSenate.ResourceTypeID].ToString().Trim(); //资源类型ID
objvMicroteachCaseSiteSenateEN.ResourceTypeName = objRow[convMicroteachCaseSiteSenate.ResourceTypeName].ToString().Trim(); //资源类型名称
objvMicroteachCaseSiteSenateEN.ResourceOwner = objRow[convMicroteachCaseSiteSenate.ResourceOwner].ToString().Trim(); //上传者
objvMicroteachCaseSiteSenateEN.ftpFileType = objRow[convMicroteachCaseSiteSenate.ftpFileType] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.ftpFileType].ToString().Trim(); //ftp文件类型
objvMicroteachCaseSiteSenateEN.ftpFileSize = objRow[convMicroteachCaseSiteSenate.ftpFileSize] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.ftpFileSize].ToString().Trim(); //ftp文件大小
objvMicroteachCaseSiteSenateEN.ftpResourceOwner = objRow[convMicroteachCaseSiteSenate.ftpResourceOwner] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvMicroteachCaseSiteSenateEN.FileOriginName = objRow[convMicroteachCaseSiteSenate.FileOriginName] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.FileOriginName].ToString().Trim(); //原文件名
objvMicroteachCaseSiteSenateEN.IsExistFile = TransNullToBool(objRow[convMicroteachCaseSiteSenate.IsExistFile].ToString().Trim()); //是否存在文件
objvMicroteachCaseSiteSenateEN.FileNewName = objRow[convMicroteachCaseSiteSenate.FileNewName] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.FileNewName].ToString().Trim(); //新文件名
objvMicroteachCaseSiteSenateEN.FileOldName = objRow[convMicroteachCaseSiteSenate.FileOldName] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.FileOldName].ToString().Trim(); //旧文件名
objvMicroteachCaseSiteSenateEN.SiteSenateSenator = objRow[convMicroteachCaseSiteSenate.SiteSenateSenator] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.SiteSenateSenator].ToString().Trim(); //评议者
objvMicroteachCaseSiteSenateEN.SiteSenateTitle = objRow[convMicroteachCaseSiteSenate.SiteSenateTitle].ToString().Trim(); //评议名称
objvMicroteachCaseSiteSenateEN.SiteSenateContent = objRow[convMicroteachCaseSiteSenate.SiteSenateContent] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.SiteSenateContent].ToString().Trim(); //现场评议内容
objvMicroteachCaseSiteSenateEN.SiteSenateData = objRow[convMicroteachCaseSiteSenate.SiteSenateData] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.SiteSenateData].ToString().Trim(); //现场评议日期
objvMicroteachCaseSiteSenateEN.SiteSenateTime = objRow[convMicroteachCaseSiteSenate.SiteSenateTime] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.SiteSenateTime].ToString().Trim(); //现场评议时间
objvMicroteachCaseSiteSenateEN.SiteSenateReadCount = objRow[convMicroteachCaseSiteSenate.SiteSenateReadCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convMicroteachCaseSiteSenate.SiteSenateReadCount].ToString().Trim()); //现场评议阅读次数
objvMicroteachCaseSiteSenateEN.Memo = objRow[convMicroteachCaseSiteSenate.Memo] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvMicroteachCaseSiteSenateDA: GetObjByDataRowvMicroteachCaseSiteSenate)", objException.Message));
}
objvMicroteachCaseSiteSenateEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvMicroteachCaseSiteSenateEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvMicroteachCaseSiteSenateEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvMicroteachCaseSiteSenateEN objvMicroteachCaseSiteSenateEN = new clsvMicroteachCaseSiteSenateEN();
try
{
objvMicroteachCaseSiteSenateEN.IdMicroteachCaseSiteSenate = TransNullToInt(objRow[convMicroteachCaseSiteSenate.IdMicroteachCaseSiteSenate].ToString().Trim()); //微格现场评议流水号
objvMicroteachCaseSiteSenateEN.FuncModuleId = objRow[convMicroteachCaseSiteSenate.FuncModuleId].ToString().Trim(); //功能模块Id
objvMicroteachCaseSiteSenateEN.FuncModuleName = objRow[convMicroteachCaseSiteSenate.FuncModuleName] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.FuncModuleName].ToString().Trim(); //功能模块名称
objvMicroteachCaseSiteSenateEN.IdMicroteachCase = objRow[convMicroteachCaseSiteSenate.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvMicroteachCaseSiteSenateEN.MicroteachCaseID = objRow[convMicroteachCaseSiteSenate.MicroteachCaseID].ToString().Trim(); //微格教学案例ID
objvMicroteachCaseSiteSenateEN.MicroteachCaseName = objRow[convMicroteachCaseSiteSenate.MicroteachCaseName].ToString().Trim(); //微格教学案例名称
objvMicroteachCaseSiteSenateEN.MicroteachCaseTheme = objRow[convMicroteachCaseSiteSenate.MicroteachCaseTheme] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.MicroteachCaseTheme].ToString().Trim(); //微格教学案例主题词
objvMicroteachCaseSiteSenateEN.MicroteachCaseDate = objRow[convMicroteachCaseSiteSenate.MicroteachCaseDate] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.MicroteachCaseDate].ToString().Trim(); //微格教学日期
objvMicroteachCaseSiteSenateEN.MicroteachCaseTime = objRow[convMicroteachCaseSiteSenate.MicroteachCaseTime] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.MicroteachCaseTime].ToString().Trim(); //微格教学时间
objvMicroteachCaseSiteSenateEN.MicroteachCaseDateIn = objRow[convMicroteachCaseSiteSenate.MicroteachCaseDateIn] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.MicroteachCaseDateIn].ToString().Trim(); //案例入库日期
objvMicroteachCaseSiteSenateEN.IdStudyLevel = objRow[convMicroteachCaseSiteSenate.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvMicroteachCaseSiteSenateEN.StudyLevelName = objRow[convMicroteachCaseSiteSenate.StudyLevelName].ToString().Trim(); //学段名称
objvMicroteachCaseSiteSenateEN.IdTeachingPlan = objRow[convMicroteachCaseSiteSenate.IdTeachingPlan].ToString().Trim(); //教案流水号
objvMicroteachCaseSiteSenateEN.MicroTeachCaseTimeIn = objRow[convMicroteachCaseSiteSenate.MicroTeachCaseTimeIn] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.MicroTeachCaseTimeIn].ToString().Trim(); //案例入库时间
objvMicroteachCaseSiteSenateEN.IsVisible = TransNullToBool(objRow[convMicroteachCaseSiteSenate.IsVisible].ToString().Trim()); //是否显示
objvMicroteachCaseSiteSenateEN.microteachCaseText = objRow[convMicroteachCaseSiteSenate.microteachCaseText] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.microteachCaseText].ToString().Trim(); //案例文本内容
objvMicroteachCaseSiteSenateEN.OwnerId = objRow[convMicroteachCaseSiteSenate.OwnerId] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.OwnerId].ToString().Trim(); //拥有者Id
objvMicroteachCaseSiteSenateEN.StuName = objRow[convMicroteachCaseSiteSenate.StuName].ToString().Trim(); //姓名
objvMicroteachCaseSiteSenateEN.StuID = objRow[convMicroteachCaseSiteSenate.StuID].ToString().Trim(); //学号
objvMicroteachCaseSiteSenateEN.PoliticsName = objRow[convMicroteachCaseSiteSenate.PoliticsName].ToString().Trim(); //政治面貌
objvMicroteachCaseSiteSenateEN.SexDesc = objRow[convMicroteachCaseSiteSenate.SexDesc] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.SexDesc].ToString().Trim(); //性别名称
objvMicroteachCaseSiteSenateEN.EthnicName = objRow[convMicroteachCaseSiteSenate.EthnicName].ToString().Trim(); //民族名称
objvMicroteachCaseSiteSenateEN.UniZoneDesc = objRow[convMicroteachCaseSiteSenate.UniZoneDesc].ToString().Trim(); //校区名称
objvMicroteachCaseSiteSenateEN.StuTypeDesc = objRow[convMicroteachCaseSiteSenate.StuTypeDesc].ToString().Trim(); //学生类别名称
objvMicroteachCaseSiteSenateEN.IdXzCollege = objRow[convMicroteachCaseSiteSenate.IdXzCollege] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.IdXzCollege].ToString().Trim(); //学院流水号
objvMicroteachCaseSiteSenateEN.CollegeName = objRow[convMicroteachCaseSiteSenate.CollegeName].ToString().Trim(); //学院名称
objvMicroteachCaseSiteSenateEN.IdXzMajor = objRow[convMicroteachCaseSiteSenate.IdXzMajor] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.IdXzMajor].ToString().Trim(); //专业流水号
objvMicroteachCaseSiteSenateEN.MajorName = objRow[convMicroteachCaseSiteSenate.MajorName].ToString().Trim(); //专业名称
objvMicroteachCaseSiteSenateEN.IdGradeBase = objRow[convMicroteachCaseSiteSenate.IdGradeBase].ToString().Trim(); //年级流水号
objvMicroteachCaseSiteSenateEN.GradeBaseName = objRow[convMicroteachCaseSiteSenate.GradeBaseName] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.GradeBaseName].ToString().Trim(); //年级名称
objvMicroteachCaseSiteSenateEN.Birthday = objRow[convMicroteachCaseSiteSenate.Birthday] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.Birthday].ToString().Trim(); //出生日期
objvMicroteachCaseSiteSenateEN.NativePlace = objRow[convMicroteachCaseSiteSenate.NativePlace] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.NativePlace].ToString().Trim(); //籍贯
objvMicroteachCaseSiteSenateEN.Duty = objRow[convMicroteachCaseSiteSenate.Duty] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.Duty].ToString().Trim(); //职位
objvMicroteachCaseSiteSenateEN.IDCardNo = objRow[convMicroteachCaseSiteSenate.IDCardNo] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.IDCardNo].ToString().Trim(); //身份证号
objvMicroteachCaseSiteSenateEN.StuCardNo = objRow[convMicroteachCaseSiteSenate.StuCardNo] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.StuCardNo].ToString().Trim(); //学生证号
objvMicroteachCaseSiteSenateEN.LiveAddress = objRow[convMicroteachCaseSiteSenate.LiveAddress] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.LiveAddress].ToString().Trim(); //居住地址
objvMicroteachCaseSiteSenateEN.HomePhone = objRow[convMicroteachCaseSiteSenate.HomePhone] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.HomePhone].ToString().Trim(); //住宅电话
objvMicroteachCaseSiteSenateEN.EnrollmentDate = objRow[convMicroteachCaseSiteSenate.EnrollmentDate] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.EnrollmentDate].ToString().Trim(); //入校日期
objvMicroteachCaseSiteSenateEN.PostCode = objRow[convMicroteachCaseSiteSenate.PostCode] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.PostCode].ToString().Trim(); //邮编
objvMicroteachCaseSiteSenateEN.BrowseCount4Case = objRow[convMicroteachCaseSiteSenate.BrowseCount4Case] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convMicroteachCaseSiteSenate.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvMicroteachCaseSiteSenateEN.IdMicroteachCaseSiteSenateType = objRow[convMicroteachCaseSiteSenate.IdMicroteachCaseSiteSenateType].ToString().Trim(); //微格现场评价类型流水号
objvMicroteachCaseSiteSenateEN.MicroteachCaseSiteSenateTypeID = objRow[convMicroteachCaseSiteSenate.MicroteachCaseSiteSenateTypeID].ToString().Trim(); //微格现场评价类型ID
objvMicroteachCaseSiteSenateEN.MicroteachCaseSiteSenateTypeName = objRow[convMicroteachCaseSiteSenate.MicroteachCaseSiteSenateTypeName].ToString().Trim(); //微格现场评价类型名称
objvMicroteachCaseSiteSenateEN.IdResource = objRow[convMicroteachCaseSiteSenate.IdResource].ToString().Trim(); //资源流水号
objvMicroteachCaseSiteSenateEN.ResourceID = objRow[convMicroteachCaseSiteSenate.ResourceID].ToString().Trim(); //资源ID
objvMicroteachCaseSiteSenateEN.ResourceName = objRow[convMicroteachCaseSiteSenate.ResourceName] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.ResourceName].ToString().Trim(); //资源名称
objvMicroteachCaseSiteSenateEN.IdFtpResource = objRow[convMicroteachCaseSiteSenate.IdFtpResource] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvMicroteachCaseSiteSenateEN.IdFile = objRow[convMicroteachCaseSiteSenate.IdFile] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.IdFile].ToString().Trim(); //文件流水号
objvMicroteachCaseSiteSenateEN.FileName = objRow[convMicroteachCaseSiteSenate.FileName] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.FileName].ToString().Trim(); //文件名称
objvMicroteachCaseSiteSenateEN.FileType = objRow[convMicroteachCaseSiteSenate.FileType] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.FileType].ToString().Trim(); //文件类型
objvMicroteachCaseSiteSenateEN.SaveDate = objRow[convMicroteachCaseSiteSenate.SaveDate] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.SaveDate].ToString().Trim(); //创建日期
objvMicroteachCaseSiteSenateEN.FileSize = objRow[convMicroteachCaseSiteSenate.FileSize] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.FileSize].ToString().Trim(); //文件大小
objvMicroteachCaseSiteSenateEN.SaveTime = objRow[convMicroteachCaseSiteSenate.SaveTime] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.SaveTime].ToString().Trim(); //创建时间
objvMicroteachCaseSiteSenateEN.FtpResourceID = objRow[convMicroteachCaseSiteSenate.FtpResourceID].ToString().Trim(); //FTP资源ID
objvMicroteachCaseSiteSenateEN.FileOriginalName = objRow[convMicroteachCaseSiteSenate.FileOriginalName] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.FileOriginalName].ToString().Trim(); //文件原名
objvMicroteachCaseSiteSenateEN.FileDirName = objRow[convMicroteachCaseSiteSenate.FileDirName] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.FileDirName].ToString().Trim(); //文件目录名
objvMicroteachCaseSiteSenateEN.FileRename = objRow[convMicroteachCaseSiteSenate.FileRename] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.FileRename].ToString().Trim(); //文件新名
objvMicroteachCaseSiteSenateEN.FileUpDate = objRow[convMicroteachCaseSiteSenate.FileUpDate] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.FileUpDate].ToString().Trim(); //创建日期
objvMicroteachCaseSiteSenateEN.FileUpTime = objRow[convMicroteachCaseSiteSenate.FileUpTime] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.FileUpTime].ToString().Trim(); //创建时间
objvMicroteachCaseSiteSenateEN.SaveMode = TransNullToBool(objRow[convMicroteachCaseSiteSenate.SaveMode].ToString().Trim()); //文件存放方式
objvMicroteachCaseSiteSenateEN.IdResourceType = objRow[convMicroteachCaseSiteSenate.IdResourceType].ToString().Trim(); //资源类型流水号
objvMicroteachCaseSiteSenateEN.ResourceTypeID = objRow[convMicroteachCaseSiteSenate.ResourceTypeID].ToString().Trim(); //资源类型ID
objvMicroteachCaseSiteSenateEN.ResourceTypeName = objRow[convMicroteachCaseSiteSenate.ResourceTypeName].ToString().Trim(); //资源类型名称
objvMicroteachCaseSiteSenateEN.ResourceOwner = objRow[convMicroteachCaseSiteSenate.ResourceOwner].ToString().Trim(); //上传者
objvMicroteachCaseSiteSenateEN.ftpFileType = objRow[convMicroteachCaseSiteSenate.ftpFileType] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.ftpFileType].ToString().Trim(); //ftp文件类型
objvMicroteachCaseSiteSenateEN.ftpFileSize = objRow[convMicroteachCaseSiteSenate.ftpFileSize] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.ftpFileSize].ToString().Trim(); //ftp文件大小
objvMicroteachCaseSiteSenateEN.ftpResourceOwner = objRow[convMicroteachCaseSiteSenate.ftpResourceOwner] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvMicroteachCaseSiteSenateEN.FileOriginName = objRow[convMicroteachCaseSiteSenate.FileOriginName] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.FileOriginName].ToString().Trim(); //原文件名
objvMicroteachCaseSiteSenateEN.IsExistFile = TransNullToBool(objRow[convMicroteachCaseSiteSenate.IsExistFile].ToString().Trim()); //是否存在文件
objvMicroteachCaseSiteSenateEN.FileNewName = objRow[convMicroteachCaseSiteSenate.FileNewName] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.FileNewName].ToString().Trim(); //新文件名
objvMicroteachCaseSiteSenateEN.FileOldName = objRow[convMicroteachCaseSiteSenate.FileOldName] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.FileOldName].ToString().Trim(); //旧文件名
objvMicroteachCaseSiteSenateEN.SiteSenateSenator = objRow[convMicroteachCaseSiteSenate.SiteSenateSenator] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.SiteSenateSenator].ToString().Trim(); //评议者
objvMicroteachCaseSiteSenateEN.SiteSenateTitle = objRow[convMicroteachCaseSiteSenate.SiteSenateTitle].ToString().Trim(); //评议名称
objvMicroteachCaseSiteSenateEN.SiteSenateContent = objRow[convMicroteachCaseSiteSenate.SiteSenateContent] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.SiteSenateContent].ToString().Trim(); //现场评议内容
objvMicroteachCaseSiteSenateEN.SiteSenateData = objRow[convMicroteachCaseSiteSenate.SiteSenateData] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.SiteSenateData].ToString().Trim(); //现场评议日期
objvMicroteachCaseSiteSenateEN.SiteSenateTime = objRow[convMicroteachCaseSiteSenate.SiteSenateTime] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.SiteSenateTime].ToString().Trim(); //现场评议时间
objvMicroteachCaseSiteSenateEN.SiteSenateReadCount = objRow[convMicroteachCaseSiteSenate.SiteSenateReadCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convMicroteachCaseSiteSenate.SiteSenateReadCount].ToString().Trim()); //现场评议阅读次数
objvMicroteachCaseSiteSenateEN.Memo = objRow[convMicroteachCaseSiteSenate.Memo] == DBNull.Value ? null : objRow[convMicroteachCaseSiteSenate.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvMicroteachCaseSiteSenateDA: GetObjByDataRow)", objException.Message));
}
objvMicroteachCaseSiteSenateEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvMicroteachCaseSiteSenateEN;
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
objSQL = clsvMicroteachCaseSiteSenateDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvMicroteachCaseSiteSenateEN._CurrTabName, convMicroteachCaseSiteSenate.IdMicroteachCaseSiteSenate, 8, "");
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
objSQL = clsvMicroteachCaseSiteSenateDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvMicroteachCaseSiteSenateEN._CurrTabName, convMicroteachCaseSiteSenate.IdMicroteachCaseSiteSenate, 8, strPrefix);
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
 objSQL = clsvMicroteachCaseSiteSenateDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select IdMicroteachCaseSiteSenate from vMicroteachCaseSiteSenate where " + strCondition;
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
 objSQL = clsvMicroteachCaseSiteSenateDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select IdMicroteachCaseSiteSenate from vMicroteachCaseSiteSenate where " + strCondition;
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
 /// <param name = "lngIdMicroteachCaseSiteSenate">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(long lngIdMicroteachCaseSiteSenate)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMicroteachCaseSiteSenateDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vMicroteachCaseSiteSenate", "IdMicroteachCaseSiteSenate = " + ""+ lngIdMicroteachCaseSiteSenate+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvMicroteachCaseSiteSenateDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMicroteachCaseSiteSenateDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vMicroteachCaseSiteSenate", strCondition))
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
objSQL = clsvMicroteachCaseSiteSenateDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vMicroteachCaseSiteSenate");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvMicroteachCaseSiteSenateENS">源对象</param>
 /// <param name = "objvMicroteachCaseSiteSenateENT">目标对象</param>
public void CopyTo(clsvMicroteachCaseSiteSenateEN objvMicroteachCaseSiteSenateENS, clsvMicroteachCaseSiteSenateEN objvMicroteachCaseSiteSenateENT)
{
objvMicroteachCaseSiteSenateENT.IdMicroteachCaseSiteSenate = objvMicroteachCaseSiteSenateENS.IdMicroteachCaseSiteSenate; //微格现场评议流水号
objvMicroteachCaseSiteSenateENT.FuncModuleId = objvMicroteachCaseSiteSenateENS.FuncModuleId; //功能模块Id
objvMicroteachCaseSiteSenateENT.FuncModuleName = objvMicroteachCaseSiteSenateENS.FuncModuleName; //功能模块名称
objvMicroteachCaseSiteSenateENT.IdMicroteachCase = objvMicroteachCaseSiteSenateENS.IdMicroteachCase; //微格教学案例流水号
objvMicroteachCaseSiteSenateENT.MicroteachCaseID = objvMicroteachCaseSiteSenateENS.MicroteachCaseID; //微格教学案例ID
objvMicroteachCaseSiteSenateENT.MicroteachCaseName = objvMicroteachCaseSiteSenateENS.MicroteachCaseName; //微格教学案例名称
objvMicroteachCaseSiteSenateENT.MicroteachCaseTheme = objvMicroteachCaseSiteSenateENS.MicroteachCaseTheme; //微格教学案例主题词
objvMicroteachCaseSiteSenateENT.MicroteachCaseDate = objvMicroteachCaseSiteSenateENS.MicroteachCaseDate; //微格教学日期
objvMicroteachCaseSiteSenateENT.MicroteachCaseTime = objvMicroteachCaseSiteSenateENS.MicroteachCaseTime; //微格教学时间
objvMicroteachCaseSiteSenateENT.MicroteachCaseDateIn = objvMicroteachCaseSiteSenateENS.MicroteachCaseDateIn; //案例入库日期
objvMicroteachCaseSiteSenateENT.IdStudyLevel = objvMicroteachCaseSiteSenateENS.IdStudyLevel; //id_StudyLevel
objvMicroteachCaseSiteSenateENT.StudyLevelName = objvMicroteachCaseSiteSenateENS.StudyLevelName; //学段名称
objvMicroteachCaseSiteSenateENT.IdTeachingPlan = objvMicroteachCaseSiteSenateENS.IdTeachingPlan; //教案流水号
objvMicroteachCaseSiteSenateENT.MicroTeachCaseTimeIn = objvMicroteachCaseSiteSenateENS.MicroTeachCaseTimeIn; //案例入库时间
objvMicroteachCaseSiteSenateENT.IsVisible = objvMicroteachCaseSiteSenateENS.IsVisible; //是否显示
objvMicroteachCaseSiteSenateENT.microteachCaseText = objvMicroteachCaseSiteSenateENS.microteachCaseText; //案例文本内容
objvMicroteachCaseSiteSenateENT.OwnerId = objvMicroteachCaseSiteSenateENS.OwnerId; //拥有者Id
objvMicroteachCaseSiteSenateENT.StuName = objvMicroteachCaseSiteSenateENS.StuName; //姓名
objvMicroteachCaseSiteSenateENT.StuID = objvMicroteachCaseSiteSenateENS.StuID; //学号
objvMicroteachCaseSiteSenateENT.PoliticsName = objvMicroteachCaseSiteSenateENS.PoliticsName; //政治面貌
objvMicroteachCaseSiteSenateENT.SexDesc = objvMicroteachCaseSiteSenateENS.SexDesc; //性别名称
objvMicroteachCaseSiteSenateENT.EthnicName = objvMicroteachCaseSiteSenateENS.EthnicName; //民族名称
objvMicroteachCaseSiteSenateENT.UniZoneDesc = objvMicroteachCaseSiteSenateENS.UniZoneDesc; //校区名称
objvMicroteachCaseSiteSenateENT.StuTypeDesc = objvMicroteachCaseSiteSenateENS.StuTypeDesc; //学生类别名称
objvMicroteachCaseSiteSenateENT.IdXzCollege = objvMicroteachCaseSiteSenateENS.IdXzCollege; //学院流水号
objvMicroteachCaseSiteSenateENT.CollegeName = objvMicroteachCaseSiteSenateENS.CollegeName; //学院名称
objvMicroteachCaseSiteSenateENT.IdXzMajor = objvMicroteachCaseSiteSenateENS.IdXzMajor; //专业流水号
objvMicroteachCaseSiteSenateENT.MajorName = objvMicroteachCaseSiteSenateENS.MajorName; //专业名称
objvMicroteachCaseSiteSenateENT.IdGradeBase = objvMicroteachCaseSiteSenateENS.IdGradeBase; //年级流水号
objvMicroteachCaseSiteSenateENT.GradeBaseName = objvMicroteachCaseSiteSenateENS.GradeBaseName; //年级名称
objvMicroteachCaseSiteSenateENT.Birthday = objvMicroteachCaseSiteSenateENS.Birthday; //出生日期
objvMicroteachCaseSiteSenateENT.NativePlace = objvMicroteachCaseSiteSenateENS.NativePlace; //籍贯
objvMicroteachCaseSiteSenateENT.Duty = objvMicroteachCaseSiteSenateENS.Duty; //职位
objvMicroteachCaseSiteSenateENT.IDCardNo = objvMicroteachCaseSiteSenateENS.IDCardNo; //身份证号
objvMicroteachCaseSiteSenateENT.StuCardNo = objvMicroteachCaseSiteSenateENS.StuCardNo; //学生证号
objvMicroteachCaseSiteSenateENT.LiveAddress = objvMicroteachCaseSiteSenateENS.LiveAddress; //居住地址
objvMicroteachCaseSiteSenateENT.HomePhone = objvMicroteachCaseSiteSenateENS.HomePhone; //住宅电话
objvMicroteachCaseSiteSenateENT.EnrollmentDate = objvMicroteachCaseSiteSenateENS.EnrollmentDate; //入校日期
objvMicroteachCaseSiteSenateENT.PostCode = objvMicroteachCaseSiteSenateENS.PostCode; //邮编
objvMicroteachCaseSiteSenateENT.BrowseCount4Case = objvMicroteachCaseSiteSenateENS.BrowseCount4Case; //课例浏览次数
objvMicroteachCaseSiteSenateENT.IdMicroteachCaseSiteSenateType = objvMicroteachCaseSiteSenateENS.IdMicroteachCaseSiteSenateType; //微格现场评价类型流水号
objvMicroteachCaseSiteSenateENT.MicroteachCaseSiteSenateTypeID = objvMicroteachCaseSiteSenateENS.MicroteachCaseSiteSenateTypeID; //微格现场评价类型ID
objvMicroteachCaseSiteSenateENT.MicroteachCaseSiteSenateTypeName = objvMicroteachCaseSiteSenateENS.MicroteachCaseSiteSenateTypeName; //微格现场评价类型名称
objvMicroteachCaseSiteSenateENT.IdResource = objvMicroteachCaseSiteSenateENS.IdResource; //资源流水号
objvMicroteachCaseSiteSenateENT.ResourceID = objvMicroteachCaseSiteSenateENS.ResourceID; //资源ID
objvMicroteachCaseSiteSenateENT.ResourceName = objvMicroteachCaseSiteSenateENS.ResourceName; //资源名称
objvMicroteachCaseSiteSenateENT.IdFtpResource = objvMicroteachCaseSiteSenateENS.IdFtpResource; //FTP资源流水号
objvMicroteachCaseSiteSenateENT.IdFile = objvMicroteachCaseSiteSenateENS.IdFile; //文件流水号
objvMicroteachCaseSiteSenateENT.FileName = objvMicroteachCaseSiteSenateENS.FileName; //文件名称
objvMicroteachCaseSiteSenateENT.FileType = objvMicroteachCaseSiteSenateENS.FileType; //文件类型
objvMicroteachCaseSiteSenateENT.SaveDate = objvMicroteachCaseSiteSenateENS.SaveDate; //创建日期
objvMicroteachCaseSiteSenateENT.FileSize = objvMicroteachCaseSiteSenateENS.FileSize; //文件大小
objvMicroteachCaseSiteSenateENT.SaveTime = objvMicroteachCaseSiteSenateENS.SaveTime; //创建时间
objvMicroteachCaseSiteSenateENT.FtpResourceID = objvMicroteachCaseSiteSenateENS.FtpResourceID; //FTP资源ID
objvMicroteachCaseSiteSenateENT.FileOriginalName = objvMicroteachCaseSiteSenateENS.FileOriginalName; //文件原名
objvMicroteachCaseSiteSenateENT.FileDirName = objvMicroteachCaseSiteSenateENS.FileDirName; //文件目录名
objvMicroteachCaseSiteSenateENT.FileRename = objvMicroteachCaseSiteSenateENS.FileRename; //文件新名
objvMicroteachCaseSiteSenateENT.FileUpDate = objvMicroteachCaseSiteSenateENS.FileUpDate; //创建日期
objvMicroteachCaseSiteSenateENT.FileUpTime = objvMicroteachCaseSiteSenateENS.FileUpTime; //创建时间
objvMicroteachCaseSiteSenateENT.SaveMode = objvMicroteachCaseSiteSenateENS.SaveMode; //文件存放方式
objvMicroteachCaseSiteSenateENT.IdResourceType = objvMicroteachCaseSiteSenateENS.IdResourceType; //资源类型流水号
objvMicroteachCaseSiteSenateENT.ResourceTypeID = objvMicroteachCaseSiteSenateENS.ResourceTypeID; //资源类型ID
objvMicroteachCaseSiteSenateENT.ResourceTypeName = objvMicroteachCaseSiteSenateENS.ResourceTypeName; //资源类型名称
objvMicroteachCaseSiteSenateENT.ResourceOwner = objvMicroteachCaseSiteSenateENS.ResourceOwner; //上传者
objvMicroteachCaseSiteSenateENT.ftpFileType = objvMicroteachCaseSiteSenateENS.ftpFileType; //ftp文件类型
objvMicroteachCaseSiteSenateENT.ftpFileSize = objvMicroteachCaseSiteSenateENS.ftpFileSize; //ftp文件大小
objvMicroteachCaseSiteSenateENT.ftpResourceOwner = objvMicroteachCaseSiteSenateENS.ftpResourceOwner; //Ftp资源拥有者
objvMicroteachCaseSiteSenateENT.FileOriginName = objvMicroteachCaseSiteSenateENS.FileOriginName; //原文件名
objvMicroteachCaseSiteSenateENT.IsExistFile = objvMicroteachCaseSiteSenateENS.IsExistFile; //是否存在文件
objvMicroteachCaseSiteSenateENT.FileNewName = objvMicroteachCaseSiteSenateENS.FileNewName; //新文件名
objvMicroteachCaseSiteSenateENT.FileOldName = objvMicroteachCaseSiteSenateENS.FileOldName; //旧文件名
objvMicroteachCaseSiteSenateENT.SiteSenateSenator = objvMicroteachCaseSiteSenateENS.SiteSenateSenator; //评议者
objvMicroteachCaseSiteSenateENT.SiteSenateTitle = objvMicroteachCaseSiteSenateENS.SiteSenateTitle; //评议名称
objvMicroteachCaseSiteSenateENT.SiteSenateContent = objvMicroteachCaseSiteSenateENS.SiteSenateContent; //现场评议内容
objvMicroteachCaseSiteSenateENT.SiteSenateData = objvMicroteachCaseSiteSenateENS.SiteSenateData; //现场评议日期
objvMicroteachCaseSiteSenateENT.SiteSenateTime = objvMicroteachCaseSiteSenateENS.SiteSenateTime; //现场评议时间
objvMicroteachCaseSiteSenateENT.SiteSenateReadCount = objvMicroteachCaseSiteSenateENS.SiteSenateReadCount; //现场评议阅读次数
objvMicroteachCaseSiteSenateENT.Memo = objvMicroteachCaseSiteSenateENS.Memo; //备注
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvMicroteachCaseSiteSenateEN objvMicroteachCaseSiteSenateEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvMicroteachCaseSiteSenateEN.FuncModuleId, 4, convMicroteachCaseSiteSenate.FuncModuleId);
clsCheckSql.CheckFieldLen(objvMicroteachCaseSiteSenateEN.FuncModuleName, 30, convMicroteachCaseSiteSenate.FuncModuleName);
clsCheckSql.CheckFieldLen(objvMicroteachCaseSiteSenateEN.IdMicroteachCase, 8, convMicroteachCaseSiteSenate.IdMicroteachCase);
clsCheckSql.CheckFieldLen(objvMicroteachCaseSiteSenateEN.MicroteachCaseID, 8, convMicroteachCaseSiteSenate.MicroteachCaseID);
clsCheckSql.CheckFieldLen(objvMicroteachCaseSiteSenateEN.MicroteachCaseName, 100, convMicroteachCaseSiteSenate.MicroteachCaseName);
clsCheckSql.CheckFieldLen(objvMicroteachCaseSiteSenateEN.MicroteachCaseTheme, 200, convMicroteachCaseSiteSenate.MicroteachCaseTheme);
clsCheckSql.CheckFieldLen(objvMicroteachCaseSiteSenateEN.MicroteachCaseDate, 8, convMicroteachCaseSiteSenate.MicroteachCaseDate);
clsCheckSql.CheckFieldLen(objvMicroteachCaseSiteSenateEN.MicroteachCaseTime, 6, convMicroteachCaseSiteSenate.MicroteachCaseTime);
clsCheckSql.CheckFieldLen(objvMicroteachCaseSiteSenateEN.MicroteachCaseDateIn, 8, convMicroteachCaseSiteSenate.MicroteachCaseDateIn);
clsCheckSql.CheckFieldLen(objvMicroteachCaseSiteSenateEN.IdStudyLevel, 4, convMicroteachCaseSiteSenate.IdStudyLevel);
clsCheckSql.CheckFieldLen(objvMicroteachCaseSiteSenateEN.StudyLevelName, 50, convMicroteachCaseSiteSenate.StudyLevelName);
clsCheckSql.CheckFieldLen(objvMicroteachCaseSiteSenateEN.IdTeachingPlan, 8, convMicroteachCaseSiteSenate.IdTeachingPlan);
clsCheckSql.CheckFieldLen(objvMicroteachCaseSiteSenateEN.MicroTeachCaseTimeIn, 6, convMicroteachCaseSiteSenate.MicroTeachCaseTimeIn);
clsCheckSql.CheckFieldLen(objvMicroteachCaseSiteSenateEN.microteachCaseText, 8000, convMicroteachCaseSiteSenate.microteachCaseText);
clsCheckSql.CheckFieldLen(objvMicroteachCaseSiteSenateEN.OwnerId, 20, convMicroteachCaseSiteSenate.OwnerId);
clsCheckSql.CheckFieldLen(objvMicroteachCaseSiteSenateEN.StuName, 50, convMicroteachCaseSiteSenate.StuName);
clsCheckSql.CheckFieldLen(objvMicroteachCaseSiteSenateEN.StuID, 20, convMicroteachCaseSiteSenate.StuID);
clsCheckSql.CheckFieldLen(objvMicroteachCaseSiteSenateEN.PoliticsName, 30, convMicroteachCaseSiteSenate.PoliticsName);
clsCheckSql.CheckFieldLen(objvMicroteachCaseSiteSenateEN.SexDesc, 10, convMicroteachCaseSiteSenate.SexDesc);
clsCheckSql.CheckFieldLen(objvMicroteachCaseSiteSenateEN.EthnicName, 30, convMicroteachCaseSiteSenate.EthnicName);
clsCheckSql.CheckFieldLen(objvMicroteachCaseSiteSenateEN.UniZoneDesc, 20, convMicroteachCaseSiteSenate.UniZoneDesc);
clsCheckSql.CheckFieldLen(objvMicroteachCaseSiteSenateEN.StuTypeDesc, 50, convMicroteachCaseSiteSenate.StuTypeDesc);
clsCheckSql.CheckFieldLen(objvMicroteachCaseSiteSenateEN.IdXzCollege, 4, convMicroteachCaseSiteSenate.IdXzCollege);
clsCheckSql.CheckFieldLen(objvMicroteachCaseSiteSenateEN.CollegeName, 100, convMicroteachCaseSiteSenate.CollegeName);
clsCheckSql.CheckFieldLen(objvMicroteachCaseSiteSenateEN.IdXzMajor, 8, convMicroteachCaseSiteSenate.IdXzMajor);
clsCheckSql.CheckFieldLen(objvMicroteachCaseSiteSenateEN.MajorName, 100, convMicroteachCaseSiteSenate.MajorName);
clsCheckSql.CheckFieldLen(objvMicroteachCaseSiteSenateEN.IdGradeBase, 4, convMicroteachCaseSiteSenate.IdGradeBase);
clsCheckSql.CheckFieldLen(objvMicroteachCaseSiteSenateEN.GradeBaseName, 50, convMicroteachCaseSiteSenate.GradeBaseName);
clsCheckSql.CheckFieldLen(objvMicroteachCaseSiteSenateEN.Birthday, 8, convMicroteachCaseSiteSenate.Birthday);
clsCheckSql.CheckFieldLen(objvMicroteachCaseSiteSenateEN.NativePlace, 200, convMicroteachCaseSiteSenate.NativePlace);
clsCheckSql.CheckFieldLen(objvMicroteachCaseSiteSenateEN.Duty, 30, convMicroteachCaseSiteSenate.Duty);
clsCheckSql.CheckFieldLen(objvMicroteachCaseSiteSenateEN.IDCardNo, 20, convMicroteachCaseSiteSenate.IDCardNo);
clsCheckSql.CheckFieldLen(objvMicroteachCaseSiteSenateEN.StuCardNo, 20, convMicroteachCaseSiteSenate.StuCardNo);
clsCheckSql.CheckFieldLen(objvMicroteachCaseSiteSenateEN.LiveAddress, 200, convMicroteachCaseSiteSenate.LiveAddress);
clsCheckSql.CheckFieldLen(objvMicroteachCaseSiteSenateEN.HomePhone, 20, convMicroteachCaseSiteSenate.HomePhone);
clsCheckSql.CheckFieldLen(objvMicroteachCaseSiteSenateEN.EnrollmentDate, 8, convMicroteachCaseSiteSenate.EnrollmentDate);
clsCheckSql.CheckFieldLen(objvMicroteachCaseSiteSenateEN.PostCode, 6, convMicroteachCaseSiteSenate.PostCode);
clsCheckSql.CheckFieldLen(objvMicroteachCaseSiteSenateEN.IdMicroteachCaseSiteSenateType, 4, convMicroteachCaseSiteSenate.IdMicroteachCaseSiteSenateType);
clsCheckSql.CheckFieldLen(objvMicroteachCaseSiteSenateEN.MicroteachCaseSiteSenateTypeID, 4, convMicroteachCaseSiteSenate.MicroteachCaseSiteSenateTypeID);
clsCheckSql.CheckFieldLen(objvMicroteachCaseSiteSenateEN.MicroteachCaseSiteSenateTypeName, 50, convMicroteachCaseSiteSenate.MicroteachCaseSiteSenateTypeName);
clsCheckSql.CheckFieldLen(objvMicroteachCaseSiteSenateEN.IdResource, 8, convMicroteachCaseSiteSenate.IdResource);
clsCheckSql.CheckFieldLen(objvMicroteachCaseSiteSenateEN.ResourceID, 8, convMicroteachCaseSiteSenate.ResourceID);
clsCheckSql.CheckFieldLen(objvMicroteachCaseSiteSenateEN.ResourceName, 100, convMicroteachCaseSiteSenate.ResourceName);
clsCheckSql.CheckFieldLen(objvMicroteachCaseSiteSenateEN.IdFtpResource, 8, convMicroteachCaseSiteSenate.IdFtpResource);
clsCheckSql.CheckFieldLen(objvMicroteachCaseSiteSenateEN.IdFile, 8, convMicroteachCaseSiteSenate.IdFile);
clsCheckSql.CheckFieldLen(objvMicroteachCaseSiteSenateEN.FileName, 500, convMicroteachCaseSiteSenate.FileName);
clsCheckSql.CheckFieldLen(objvMicroteachCaseSiteSenateEN.FileType, 30, convMicroteachCaseSiteSenate.FileType);
clsCheckSql.CheckFieldLen(objvMicroteachCaseSiteSenateEN.SaveDate, 8, convMicroteachCaseSiteSenate.SaveDate);
clsCheckSql.CheckFieldLen(objvMicroteachCaseSiteSenateEN.FileSize, 50, convMicroteachCaseSiteSenate.FileSize);
clsCheckSql.CheckFieldLen(objvMicroteachCaseSiteSenateEN.SaveTime, 6, convMicroteachCaseSiteSenate.SaveTime);
clsCheckSql.CheckFieldLen(objvMicroteachCaseSiteSenateEN.FtpResourceID, 8, convMicroteachCaseSiteSenate.FtpResourceID);
clsCheckSql.CheckFieldLen(objvMicroteachCaseSiteSenateEN.FileOriginalName, 200, convMicroteachCaseSiteSenate.FileOriginalName);
clsCheckSql.CheckFieldLen(objvMicroteachCaseSiteSenateEN.FileDirName, 200, convMicroteachCaseSiteSenate.FileDirName);
clsCheckSql.CheckFieldLen(objvMicroteachCaseSiteSenateEN.FileRename, 200, convMicroteachCaseSiteSenate.FileRename);
clsCheckSql.CheckFieldLen(objvMicroteachCaseSiteSenateEN.FileUpDate, 8, convMicroteachCaseSiteSenate.FileUpDate);
clsCheckSql.CheckFieldLen(objvMicroteachCaseSiteSenateEN.FileUpTime, 6, convMicroteachCaseSiteSenate.FileUpTime);
clsCheckSql.CheckFieldLen(objvMicroteachCaseSiteSenateEN.IdResourceType, 4, convMicroteachCaseSiteSenate.IdResourceType);
clsCheckSql.CheckFieldLen(objvMicroteachCaseSiteSenateEN.ResourceTypeID, 4, convMicroteachCaseSiteSenate.ResourceTypeID);
clsCheckSql.CheckFieldLen(objvMicroteachCaseSiteSenateEN.ResourceTypeName, 50, convMicroteachCaseSiteSenate.ResourceTypeName);
clsCheckSql.CheckFieldLen(objvMicroteachCaseSiteSenateEN.ResourceOwner, 50, convMicroteachCaseSiteSenate.ResourceOwner);
clsCheckSql.CheckFieldLen(objvMicroteachCaseSiteSenateEN.ftpFileType, 30, convMicroteachCaseSiteSenate.ftpFileType);
clsCheckSql.CheckFieldLen(objvMicroteachCaseSiteSenateEN.ftpFileSize, 50, convMicroteachCaseSiteSenate.ftpFileSize);
clsCheckSql.CheckFieldLen(objvMicroteachCaseSiteSenateEN.ftpResourceOwner, 50, convMicroteachCaseSiteSenate.ftpResourceOwner);
clsCheckSql.CheckFieldLen(objvMicroteachCaseSiteSenateEN.FileOriginName, 500, convMicroteachCaseSiteSenate.FileOriginName);
clsCheckSql.CheckFieldLen(objvMicroteachCaseSiteSenateEN.FileNewName, 530, convMicroteachCaseSiteSenate.FileNewName);
clsCheckSql.CheckFieldLen(objvMicroteachCaseSiteSenateEN.FileOldName, 530, convMicroteachCaseSiteSenate.FileOldName);
clsCheckSql.CheckFieldLen(objvMicroteachCaseSiteSenateEN.SiteSenateSenator, 50, convMicroteachCaseSiteSenate.SiteSenateSenator);
clsCheckSql.CheckFieldLen(objvMicroteachCaseSiteSenateEN.SiteSenateTitle, 50, convMicroteachCaseSiteSenate.SiteSenateTitle);
clsCheckSql.CheckFieldLen(objvMicroteachCaseSiteSenateEN.SiteSenateContent, 2000, convMicroteachCaseSiteSenate.SiteSenateContent);
clsCheckSql.CheckFieldLen(objvMicroteachCaseSiteSenateEN.SiteSenateData, 8, convMicroteachCaseSiteSenate.SiteSenateData);
clsCheckSql.CheckFieldLen(objvMicroteachCaseSiteSenateEN.SiteSenateTime, 6, convMicroteachCaseSiteSenate.SiteSenateTime);
clsCheckSql.CheckFieldLen(objvMicroteachCaseSiteSenateEN.Memo, 1000, convMicroteachCaseSiteSenate.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCaseSiteSenateEN.FuncModuleId, convMicroteachCaseSiteSenate.FuncModuleId);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCaseSiteSenateEN.FuncModuleName, convMicroteachCaseSiteSenate.FuncModuleName);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCaseSiteSenateEN.IdMicroteachCase, convMicroteachCaseSiteSenate.IdMicroteachCase);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCaseSiteSenateEN.MicroteachCaseID, convMicroteachCaseSiteSenate.MicroteachCaseID);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCaseSiteSenateEN.MicroteachCaseName, convMicroteachCaseSiteSenate.MicroteachCaseName);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCaseSiteSenateEN.MicroteachCaseTheme, convMicroteachCaseSiteSenate.MicroteachCaseTheme);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCaseSiteSenateEN.MicroteachCaseDate, convMicroteachCaseSiteSenate.MicroteachCaseDate);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCaseSiteSenateEN.MicroteachCaseTime, convMicroteachCaseSiteSenate.MicroteachCaseTime);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCaseSiteSenateEN.MicroteachCaseDateIn, convMicroteachCaseSiteSenate.MicroteachCaseDateIn);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCaseSiteSenateEN.IdStudyLevel, convMicroteachCaseSiteSenate.IdStudyLevel);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCaseSiteSenateEN.StudyLevelName, convMicroteachCaseSiteSenate.StudyLevelName);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCaseSiteSenateEN.IdTeachingPlan, convMicroteachCaseSiteSenate.IdTeachingPlan);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCaseSiteSenateEN.MicroTeachCaseTimeIn, convMicroteachCaseSiteSenate.MicroTeachCaseTimeIn);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCaseSiteSenateEN.microteachCaseText, convMicroteachCaseSiteSenate.microteachCaseText);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCaseSiteSenateEN.OwnerId, convMicroteachCaseSiteSenate.OwnerId);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCaseSiteSenateEN.StuName, convMicroteachCaseSiteSenate.StuName);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCaseSiteSenateEN.StuID, convMicroteachCaseSiteSenate.StuID);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCaseSiteSenateEN.PoliticsName, convMicroteachCaseSiteSenate.PoliticsName);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCaseSiteSenateEN.SexDesc, convMicroteachCaseSiteSenate.SexDesc);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCaseSiteSenateEN.EthnicName, convMicroteachCaseSiteSenate.EthnicName);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCaseSiteSenateEN.UniZoneDesc, convMicroteachCaseSiteSenate.UniZoneDesc);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCaseSiteSenateEN.StuTypeDesc, convMicroteachCaseSiteSenate.StuTypeDesc);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCaseSiteSenateEN.IdXzCollege, convMicroteachCaseSiteSenate.IdXzCollege);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCaseSiteSenateEN.CollegeName, convMicroteachCaseSiteSenate.CollegeName);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCaseSiteSenateEN.IdXzMajor, convMicroteachCaseSiteSenate.IdXzMajor);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCaseSiteSenateEN.MajorName, convMicroteachCaseSiteSenate.MajorName);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCaseSiteSenateEN.IdGradeBase, convMicroteachCaseSiteSenate.IdGradeBase);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCaseSiteSenateEN.GradeBaseName, convMicroteachCaseSiteSenate.GradeBaseName);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCaseSiteSenateEN.Birthday, convMicroteachCaseSiteSenate.Birthday);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCaseSiteSenateEN.NativePlace, convMicroteachCaseSiteSenate.NativePlace);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCaseSiteSenateEN.Duty, convMicroteachCaseSiteSenate.Duty);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCaseSiteSenateEN.IDCardNo, convMicroteachCaseSiteSenate.IDCardNo);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCaseSiteSenateEN.StuCardNo, convMicroteachCaseSiteSenate.StuCardNo);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCaseSiteSenateEN.LiveAddress, convMicroteachCaseSiteSenate.LiveAddress);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCaseSiteSenateEN.HomePhone, convMicroteachCaseSiteSenate.HomePhone);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCaseSiteSenateEN.EnrollmentDate, convMicroteachCaseSiteSenate.EnrollmentDate);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCaseSiteSenateEN.PostCode, convMicroteachCaseSiteSenate.PostCode);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCaseSiteSenateEN.IdMicroteachCaseSiteSenateType, convMicroteachCaseSiteSenate.IdMicroteachCaseSiteSenateType);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCaseSiteSenateEN.MicroteachCaseSiteSenateTypeID, convMicroteachCaseSiteSenate.MicroteachCaseSiteSenateTypeID);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCaseSiteSenateEN.MicroteachCaseSiteSenateTypeName, convMicroteachCaseSiteSenate.MicroteachCaseSiteSenateTypeName);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCaseSiteSenateEN.IdResource, convMicroteachCaseSiteSenate.IdResource);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCaseSiteSenateEN.ResourceID, convMicroteachCaseSiteSenate.ResourceID);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCaseSiteSenateEN.ResourceName, convMicroteachCaseSiteSenate.ResourceName);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCaseSiteSenateEN.IdFtpResource, convMicroteachCaseSiteSenate.IdFtpResource);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCaseSiteSenateEN.IdFile, convMicroteachCaseSiteSenate.IdFile);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCaseSiteSenateEN.FileName, convMicroteachCaseSiteSenate.FileName);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCaseSiteSenateEN.FileType, convMicroteachCaseSiteSenate.FileType);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCaseSiteSenateEN.SaveDate, convMicroteachCaseSiteSenate.SaveDate);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCaseSiteSenateEN.FileSize, convMicroteachCaseSiteSenate.FileSize);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCaseSiteSenateEN.SaveTime, convMicroteachCaseSiteSenate.SaveTime);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCaseSiteSenateEN.FtpResourceID, convMicroteachCaseSiteSenate.FtpResourceID);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCaseSiteSenateEN.FileOriginalName, convMicroteachCaseSiteSenate.FileOriginalName);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCaseSiteSenateEN.FileDirName, convMicroteachCaseSiteSenate.FileDirName);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCaseSiteSenateEN.FileRename, convMicroteachCaseSiteSenate.FileRename);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCaseSiteSenateEN.FileUpDate, convMicroteachCaseSiteSenate.FileUpDate);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCaseSiteSenateEN.FileUpTime, convMicroteachCaseSiteSenate.FileUpTime);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCaseSiteSenateEN.IdResourceType, convMicroteachCaseSiteSenate.IdResourceType);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCaseSiteSenateEN.ResourceTypeID, convMicroteachCaseSiteSenate.ResourceTypeID);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCaseSiteSenateEN.ResourceTypeName, convMicroteachCaseSiteSenate.ResourceTypeName);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCaseSiteSenateEN.ResourceOwner, convMicroteachCaseSiteSenate.ResourceOwner);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCaseSiteSenateEN.ftpFileType, convMicroteachCaseSiteSenate.ftpFileType);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCaseSiteSenateEN.ftpFileSize, convMicroteachCaseSiteSenate.ftpFileSize);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCaseSiteSenateEN.ftpResourceOwner, convMicroteachCaseSiteSenate.ftpResourceOwner);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCaseSiteSenateEN.FileOriginName, convMicroteachCaseSiteSenate.FileOriginName);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCaseSiteSenateEN.FileNewName, convMicroteachCaseSiteSenate.FileNewName);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCaseSiteSenateEN.FileOldName, convMicroteachCaseSiteSenate.FileOldName);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCaseSiteSenateEN.SiteSenateSenator, convMicroteachCaseSiteSenate.SiteSenateSenator);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCaseSiteSenateEN.SiteSenateTitle, convMicroteachCaseSiteSenate.SiteSenateTitle);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCaseSiteSenateEN.SiteSenateContent, convMicroteachCaseSiteSenate.SiteSenateContent);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCaseSiteSenateEN.SiteSenateData, convMicroteachCaseSiteSenate.SiteSenateData);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCaseSiteSenateEN.SiteSenateTime, convMicroteachCaseSiteSenate.SiteSenateTime);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCaseSiteSenateEN.Memo, convMicroteachCaseSiteSenate.Memo);
//检查外键字段长度
 objvMicroteachCaseSiteSenateEN._IsCheckProperty = true;
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
 objSQL = clsvMicroteachCaseSiteSenateDA.GetSpecSQLObj();
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
 objSQL = clsvMicroteachCaseSiteSenateDA.GetSpecSQLObj();
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
 objSQL = clsvMicroteachCaseSiteSenateDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvMicroteachCaseSiteSenateEN._CurrTabName);
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
 objSQL = clsvMicroteachCaseSiteSenateDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvMicroteachCaseSiteSenateEN._CurrTabName, strCondition);
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
 objSQL = clsvMicroteachCaseSiteSenateDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}