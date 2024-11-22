
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvMicroteachCase_Resource_Rel4AllDA
 表名:vMicroteachCase_Resource_Rel4All(01120429)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:47:33
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
 /// vMicroteachCase_Resource_Rel4All(vMicroteachCase_Resource_Rel4All)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvMicroteachCase_Resource_Rel4AllDA : clsCommBase4DA
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
 return clsvMicroteachCase_Resource_Rel4AllEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvMicroteachCase_Resource_Rel4AllEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvMicroteachCase_Resource_Rel4AllEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvMicroteachCase_Resource_Rel4AllEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvMicroteachCase_Resource_Rel4AllEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvMicroteachCase_Resource_Rel4AllDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMicroteachCase_Resource_Rel4AllDA.GetSpecSQLObj();
strSQL = "Select * from vMicroteachCase_Resource_Rel4All where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vMicroteachCase_Resource_Rel4All(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvMicroteachCase_Resource_Rel4AllDA: GetDataTable_vMicroteachCase_Resource_Rel4All)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMicroteachCase_Resource_Rel4AllDA.GetSpecSQLObj();
strSQL = "Select * from vMicroteachCase_Resource_Rel4All where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvMicroteachCase_Resource_Rel4AllDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMicroteachCase_Resource_Rel4AllDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvMicroteachCase_Resource_Rel4AllDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMicroteachCase_Resource_Rel4AllDA.GetSpecSQLObj();
strSQL = "Select * from vMicroteachCase_Resource_Rel4All where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvMicroteachCase_Resource_Rel4AllDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMicroteachCase_Resource_Rel4AllDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvMicroteachCase_Resource_Rel4AllDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMicroteachCase_Resource_Rel4AllDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vMicroteachCase_Resource_Rel4All where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vMicroteachCase_Resource_Rel4All where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvMicroteachCase_Resource_Rel4AllDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMicroteachCase_Resource_Rel4AllDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vMicroteachCase_Resource_Rel4All where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvMicroteachCase_Resource_Rel4AllDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMicroteachCase_Resource_Rel4AllDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vMicroteachCase_Resource_Rel4All.* from vMicroteachCase_Resource_Rel4All Left Join {1} on {2} where {3} and vMicroteachCase_Resource_Rel4All.IdMicroteachCaseResourceRel not in (Select top {5} vMicroteachCase_Resource_Rel4All.IdMicroteachCaseResourceRel from vMicroteachCase_Resource_Rel4All Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vMicroteachCase_Resource_Rel4All where {1} and IdMicroteachCaseResourceRel not in (Select top {2} IdMicroteachCaseResourceRel from vMicroteachCase_Resource_Rel4All where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vMicroteachCase_Resource_Rel4All where {1} and IdMicroteachCaseResourceRel not in (Select top {3} IdMicroteachCaseResourceRel from vMicroteachCase_Resource_Rel4All where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvMicroteachCase_Resource_Rel4AllDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMicroteachCase_Resource_Rel4AllDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vMicroteachCase_Resource_Rel4All.* from vMicroteachCase_Resource_Rel4All Left Join {1} on {2} where {3} and vMicroteachCase_Resource_Rel4All.IdMicroteachCaseResourceRel not in (Select top {5} vMicroteachCase_Resource_Rel4All.IdMicroteachCaseResourceRel from vMicroteachCase_Resource_Rel4All Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vMicroteachCase_Resource_Rel4All where {1} and IdMicroteachCaseResourceRel not in (Select top {2} IdMicroteachCaseResourceRel from vMicroteachCase_Resource_Rel4All where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vMicroteachCase_Resource_Rel4All where {1} and IdMicroteachCaseResourceRel not in (Select top {3} IdMicroteachCaseResourceRel from vMicroteachCase_Resource_Rel4All where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvMicroteachCase_Resource_Rel4AllEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvMicroteachCase_Resource_Rel4AllDA:GetObjLst)", objException.Message));
}
List<clsvMicroteachCase_Resource_Rel4AllEN> arrObjLst = new List<clsvMicroteachCase_Resource_Rel4AllEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMicroteachCase_Resource_Rel4AllDA.GetSpecSQLObj();
strSQL = "Select * from vMicroteachCase_Resource_Rel4All where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvMicroteachCase_Resource_Rel4AllEN objvMicroteachCase_Resource_Rel4AllEN = new clsvMicroteachCase_Resource_Rel4AllEN();
try
{
objvMicroteachCase_Resource_Rel4AllEN.IdMicroteachCaseResourceRel = TransNullToInt(objRow[convMicroteachCase_Resource_Rel4All.IdMicroteachCaseResourceRel].ToString().Trim()); //微格案例资源关系流水号
objvMicroteachCase_Resource_Rel4AllEN.IdMicroteachCase = objRow[convMicroteachCase_Resource_Rel4All.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvMicroteachCase_Resource_Rel4AllEN.MicroteachCaseID = objRow[convMicroteachCase_Resource_Rel4All.MicroteachCaseID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.MicroteachCaseID].ToString().Trim(); //微格教学案例ID
objvMicroteachCase_Resource_Rel4AllEN.MicroteachCaseName = objRow[convMicroteachCase_Resource_Rel4All.MicroteachCaseName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.MicroteachCaseName].ToString().Trim(); //微格教学案例名称
objvMicroteachCase_Resource_Rel4AllEN.MicroteachCaseTheme = objRow[convMicroteachCase_Resource_Rel4All.MicroteachCaseTheme] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.MicroteachCaseTheme].ToString().Trim(); //微格教学案例主题词
objvMicroteachCase_Resource_Rel4AllEN.MicroteachCaseDate = objRow[convMicroteachCase_Resource_Rel4All.MicroteachCaseDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.MicroteachCaseDate].ToString().Trim(); //微格教学日期
objvMicroteachCase_Resource_Rel4AllEN.MicroteachCaseTime = objRow[convMicroteachCase_Resource_Rel4All.MicroteachCaseTime] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.MicroteachCaseTime].ToString().Trim(); //微格教学时间
objvMicroteachCase_Resource_Rel4AllEN.MicroteachCaseDateIn = objRow[convMicroteachCase_Resource_Rel4All.MicroteachCaseDateIn] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.MicroteachCaseDateIn].ToString().Trim(); //案例入库日期
objvMicroteachCase_Resource_Rel4AllEN.IdStudyLevel = objRow[convMicroteachCase_Resource_Rel4All.IdStudyLevel] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvMicroteachCase_Resource_Rel4AllEN.StudyLevelName = objRow[convMicroteachCase_Resource_Rel4All.StudyLevelName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.StudyLevelName].ToString().Trim(); //学段名称
objvMicroteachCase_Resource_Rel4AllEN.IdTeachingPlan = objRow[convMicroteachCase_Resource_Rel4All.IdTeachingPlan] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.IdTeachingPlan].ToString().Trim(); //教案流水号
objvMicroteachCase_Resource_Rel4AllEN.MicroTeachCaseTimeIn = objRow[convMicroteachCase_Resource_Rel4All.MicroTeachCaseTimeIn] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.MicroTeachCaseTimeIn].ToString().Trim(); //案例入库时间
objvMicroteachCase_Resource_Rel4AllEN.IdCaseType = objRow[convMicroteachCase_Resource_Rel4All.IdCaseType] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.IdCaseType].ToString().Trim(); //案例类型流水号
objvMicroteachCase_Resource_Rel4AllEN.IdDiscipline = objRow[convMicroteachCase_Resource_Rel4All.IdDiscipline] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.IdDiscipline].ToString().Trim(); //学科流水号
objvMicroteachCase_Resource_Rel4AllEN.DisciplineID = objRow[convMicroteachCase_Resource_Rel4All.DisciplineID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.DisciplineID].ToString().Trim(); //学科ID
objvMicroteachCase_Resource_Rel4AllEN.DisciplineName = objRow[convMicroteachCase_Resource_Rel4All.DisciplineName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.DisciplineName].ToString().Trim(); //学科名称
objvMicroteachCase_Resource_Rel4AllEN.senateGaugeVersionID = objRow[convMicroteachCase_Resource_Rel4All.senateGaugeVersionID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvMicroteachCase_Resource_Rel4AllEN.senateGaugeVersionName = objRow[convMicroteachCase_Resource_Rel4All.senateGaugeVersionName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvMicroteachCase_Resource_Rel4AllEN.senateGaugeVersionTtlScore = objRow[convMicroteachCase_Resource_Rel4All.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convMicroteachCase_Resource_Rel4All.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvMicroteachCase_Resource_Rel4AllEN.VersionNo = objRow[convMicroteachCase_Resource_Rel4All.VersionNo] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convMicroteachCase_Resource_Rel4All.VersionNo].ToString().Trim()); //版本号
objvMicroteachCase_Resource_Rel4AllEN.IdTeachSkill = objRow[convMicroteachCase_Resource_Rel4All.IdTeachSkill] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvMicroteachCase_Resource_Rel4AllEN.TeachSkillID = objRow[convMicroteachCase_Resource_Rel4All.TeachSkillID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.TeachSkillID].ToString().Trim(); //教学技能ID
objvMicroteachCase_Resource_Rel4AllEN.SkillTypeName = objRow[convMicroteachCase_Resource_Rel4All.SkillTypeName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.SkillTypeName].ToString().Trim(); //技能类型名称
objvMicroteachCase_Resource_Rel4AllEN.TeachSkillName = objRow[convMicroteachCase_Resource_Rel4All.TeachSkillName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.TeachSkillName].ToString().Trim(); //教学技能名称
objvMicroteachCase_Resource_Rel4AllEN.TeachSkillTheory = objRow[convMicroteachCase_Resource_Rel4All.TeachSkillTheory] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvMicroteachCase_Resource_Rel4AllEN.TeachSkillOperMethod = objRow[convMicroteachCase_Resource_Rel4All.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvMicroteachCase_Resource_Rel4AllEN.IdSkillType = objRow[convMicroteachCase_Resource_Rel4All.IdSkillType] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.IdSkillType].ToString().Trim(); //技能类型流水号
objvMicroteachCase_Resource_Rel4AllEN.SkillTypeID = objRow[convMicroteachCase_Resource_Rel4All.SkillTypeID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.SkillTypeID].ToString().Trim(); //技能类型ID
objvMicroteachCase_Resource_Rel4AllEN.CaseLevelId = objRow[convMicroteachCase_Resource_Rel4All.CaseLevelId] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.CaseLevelId].ToString().Trim(); //课例等级Id
objvMicroteachCase_Resource_Rel4AllEN.CaseLevelName = objRow[convMicroteachCase_Resource_Rel4All.CaseLevelName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.CaseLevelName].ToString().Trim(); //案例等级名称
objvMicroteachCase_Resource_Rel4AllEN.microteachCaseText = objRow[convMicroteachCase_Resource_Rel4All.microteachCaseText] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.microteachCaseText].ToString().Trim(); //案例文本内容
objvMicroteachCase_Resource_Rel4AllEN.OwnerId = objRow[convMicroteachCase_Resource_Rel4All.OwnerId] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.OwnerId].ToString().Trim(); //拥有者Id
objvMicroteachCase_Resource_Rel4AllEN.OwnerName = objRow[convMicroteachCase_Resource_Rel4All.OwnerName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.OwnerName].ToString().Trim(); //拥有者姓名
objvMicroteachCase_Resource_Rel4AllEN.CollegeID = objRow[convMicroteachCase_Resource_Rel4All.CollegeID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.CollegeID].ToString().Trim(); //学院ID
objvMicroteachCase_Resource_Rel4AllEN.CollegeName = objRow[convMicroteachCase_Resource_Rel4All.CollegeName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.CollegeName].ToString().Trim(); //学院名称
objvMicroteachCase_Resource_Rel4AllEN.OwnerNameWithId = objRow[convMicroteachCase_Resource_Rel4All.OwnerNameWithId] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvMicroteachCase_Resource_Rel4AllEN.IdXzCollege = objRow[convMicroteachCase_Resource_Rel4All.IdXzCollege] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.IdXzCollege].ToString().Trim(); //学院流水号
objvMicroteachCase_Resource_Rel4AllEN.IsDualVideo = TransNullToBool(objRow[convMicroteachCase_Resource_Rel4All.IsDualVideo].ToString().Trim()); //是否双视频
objvMicroteachCase_Resource_Rel4AllEN.UserKindId = objRow[convMicroteachCase_Resource_Rel4All.UserKindId] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.UserKindId].ToString().Trim(); //用户类别Id
objvMicroteachCase_Resource_Rel4AllEN.UserKindName = objRow[convMicroteachCase_Resource_Rel4All.UserKindName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.UserKindName].ToString().Trim(); //用户类别名
objvMicroteachCase_Resource_Rel4AllEN.UserTypeId = objRow[convMicroteachCase_Resource_Rel4All.UserTypeId] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.UserTypeId].ToString().Trim(); //用户类型Id
objvMicroteachCase_Resource_Rel4AllEN.UserTypeName = objRow[convMicroteachCase_Resource_Rel4All.UserTypeName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.UserTypeName].ToString().Trim(); //用户类型名称
objvMicroteachCase_Resource_Rel4AllEN.RecommendedDegreeId = objRow[convMicroteachCase_Resource_Rel4All.RecommendedDegreeId] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvMicroteachCase_Resource_Rel4AllEN.RecommendedDegreeName = objRow[convMicroteachCase_Resource_Rel4All.RecommendedDegreeName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvMicroteachCase_Resource_Rel4AllEN.BrowseCount4Case = objRow[convMicroteachCase_Resource_Rel4All.BrowseCount4Case] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convMicroteachCase_Resource_Rel4All.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvMicroteachCase_Resource_Rel4AllEN.IdResource = objRow[convMicroteachCase_Resource_Rel4All.IdResource].ToString().Trim(); //资源流水号
objvMicroteachCase_Resource_Rel4AllEN.ResourceID = objRow[convMicroteachCase_Resource_Rel4All.ResourceID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.ResourceID].ToString().Trim(); //资源ID
objvMicroteachCase_Resource_Rel4AllEN.ResourceName = objRow[convMicroteachCase_Resource_Rel4All.ResourceName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.ResourceName].ToString().Trim(); //资源名称
objvMicroteachCase_Resource_Rel4AllEN.IdFtpResource = objRow[convMicroteachCase_Resource_Rel4All.IdFtpResource] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvMicroteachCase_Resource_Rel4AllEN.IdFile = objRow[convMicroteachCase_Resource_Rel4All.IdFile] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.IdFile].ToString().Trim(); //文件流水号
objvMicroteachCase_Resource_Rel4AllEN.FileName = objRow[convMicroteachCase_Resource_Rel4All.FileName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.FileName].ToString().Trim(); //文件名称
objvMicroteachCase_Resource_Rel4AllEN.FileType = objRow[convMicroteachCase_Resource_Rel4All.FileType] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.FileType].ToString().Trim(); //文件类型
objvMicroteachCase_Resource_Rel4AllEN.SaveDate = objRow[convMicroteachCase_Resource_Rel4All.SaveDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.SaveDate].ToString().Trim(); //创建日期
objvMicroteachCase_Resource_Rel4AllEN.FileSize = objRow[convMicroteachCase_Resource_Rel4All.FileSize] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.FileSize].ToString().Trim(); //文件大小
objvMicroteachCase_Resource_Rel4AllEN.SaveTime = objRow[convMicroteachCase_Resource_Rel4All.SaveTime] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.SaveTime].ToString().Trim(); //创建时间
objvMicroteachCase_Resource_Rel4AllEN.FtpResourceID = objRow[convMicroteachCase_Resource_Rel4All.FtpResourceID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.FtpResourceID].ToString().Trim(); //FTP资源ID
objvMicroteachCase_Resource_Rel4AllEN.FileOriginalName = objRow[convMicroteachCase_Resource_Rel4All.FileOriginalName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.FileOriginalName].ToString().Trim(); //文件原名
objvMicroteachCase_Resource_Rel4AllEN.FileDirName = objRow[convMicroteachCase_Resource_Rel4All.FileDirName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.FileDirName].ToString().Trim(); //文件目录名
objvMicroteachCase_Resource_Rel4AllEN.FileRename = objRow[convMicroteachCase_Resource_Rel4All.FileRename] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.FileRename].ToString().Trim(); //文件新名
objvMicroteachCase_Resource_Rel4AllEN.FileUpDate = objRow[convMicroteachCase_Resource_Rel4All.FileUpDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.FileUpDate].ToString().Trim(); //创建日期
objvMicroteachCase_Resource_Rel4AllEN.FileUpTime = objRow[convMicroteachCase_Resource_Rel4All.FileUpTime] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.FileUpTime].ToString().Trim(); //创建时间
objvMicroteachCase_Resource_Rel4AllEN.SaveMode = TransNullToBool(objRow[convMicroteachCase_Resource_Rel4All.SaveMode].ToString().Trim()); //文件存放方式
objvMicroteachCase_Resource_Rel4AllEN.IdResourceType = objRow[convMicroteachCase_Resource_Rel4All.IdResourceType] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.IdResourceType].ToString().Trim(); //资源类型流水号
objvMicroteachCase_Resource_Rel4AllEN.ResourceTypeID = objRow[convMicroteachCase_Resource_Rel4All.ResourceTypeID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.ResourceTypeID].ToString().Trim(); //资源类型ID
objvMicroteachCase_Resource_Rel4AllEN.ResourceTypeName = objRow[convMicroteachCase_Resource_Rel4All.ResourceTypeName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.ResourceTypeName].ToString().Trim(); //资源类型名称
objvMicroteachCase_Resource_Rel4AllEN.ResourceOwner = objRow[convMicroteachCase_Resource_Rel4All.ResourceOwner] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.ResourceOwner].ToString().Trim(); //上传者
objvMicroteachCase_Resource_Rel4AllEN.ftpFileType = objRow[convMicroteachCase_Resource_Rel4All.ftpFileType] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.ftpFileType].ToString().Trim(); //ftp文件类型
objvMicroteachCase_Resource_Rel4AllEN.ftpFileSize = objRow[convMicroteachCase_Resource_Rel4All.ftpFileSize] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.ftpFileSize].ToString().Trim(); //ftp文件大小
objvMicroteachCase_Resource_Rel4AllEN.ftpResourceOwner = objRow[convMicroteachCase_Resource_Rel4All.ftpResourceOwner] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvMicroteachCase_Resource_Rel4AllEN.FileOriginName = objRow[convMicroteachCase_Resource_Rel4All.FileOriginName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.FileOriginName].ToString().Trim(); //原文件名
objvMicroteachCase_Resource_Rel4AllEN.IsExistFile = TransNullToBool(objRow[convMicroteachCase_Resource_Rel4All.IsExistFile].ToString().Trim()); //是否存在文件
objvMicroteachCase_Resource_Rel4AllEN.FileNewName = objRow[convMicroteachCase_Resource_Rel4All.FileNewName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.FileNewName].ToString().Trim(); //新文件名
objvMicroteachCase_Resource_Rel4AllEN.FileOldName = objRow[convMicroteachCase_Resource_Rel4All.FileOldName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.FileOldName].ToString().Trim(); //旧文件名
objvMicroteachCase_Resource_Rel4AllEN.IsMain = TransNullToBool(objRow[convMicroteachCase_Resource_Rel4All.IsMain].ToString().Trim()); //是否主资源
objvMicroteachCase_Resource_Rel4AllEN.IdUsingMode = objRow[convMicroteachCase_Resource_Rel4All.IdUsingMode] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.IdUsingMode].ToString().Trim(); //资源使用模式流水号
objvMicroteachCase_Resource_Rel4AllEN.IsVisible = TransNullToBool(objRow[convMicroteachCase_Resource_Rel4All.IsVisible].ToString().Trim()); //是否显示
objvMicroteachCase_Resource_Rel4AllEN.IndexNO = objRow[convMicroteachCase_Resource_Rel4All.IndexNO] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convMicroteachCase_Resource_Rel4All.IndexNO].ToString().Trim()); //序号
objvMicroteachCase_Resource_Rel4AllEN.BrowseCount = objRow[convMicroteachCase_Resource_Rel4All.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convMicroteachCase_Resource_Rel4All.BrowseCount].ToString().Trim()); //浏览次数
objvMicroteachCase_Resource_Rel4AllEN.UpdDate = objRow[convMicroteachCase_Resource_Rel4All.UpdDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.UpdDate].ToString().Trim(); //修改日期
objvMicroteachCase_Resource_Rel4AllEN.UpdUser = objRow[convMicroteachCase_Resource_Rel4All.UpdUser] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.UpdUser].ToString().Trim(); //修改人
objvMicroteachCase_Resource_Rel4AllEN.Memo = objRow[convMicroteachCase_Resource_Rel4All.Memo] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvMicroteachCase_Resource_Rel4AllDA: GetObjLst)", objException.Message));
}
objvMicroteachCase_Resource_Rel4AllEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvMicroteachCase_Resource_Rel4AllEN);
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
public List<clsvMicroteachCase_Resource_Rel4AllEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvMicroteachCase_Resource_Rel4AllDA:GetObjLstByTabName)", objException.Message));
}
List<clsvMicroteachCase_Resource_Rel4AllEN> arrObjLst = new List<clsvMicroteachCase_Resource_Rel4AllEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMicroteachCase_Resource_Rel4AllDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvMicroteachCase_Resource_Rel4AllEN objvMicroteachCase_Resource_Rel4AllEN = new clsvMicroteachCase_Resource_Rel4AllEN();
try
{
objvMicroteachCase_Resource_Rel4AllEN.IdMicroteachCaseResourceRel = TransNullToInt(objRow[convMicroteachCase_Resource_Rel4All.IdMicroteachCaseResourceRel].ToString().Trim()); //微格案例资源关系流水号
objvMicroteachCase_Resource_Rel4AllEN.IdMicroteachCase = objRow[convMicroteachCase_Resource_Rel4All.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvMicroteachCase_Resource_Rel4AllEN.MicroteachCaseID = objRow[convMicroteachCase_Resource_Rel4All.MicroteachCaseID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.MicroteachCaseID].ToString().Trim(); //微格教学案例ID
objvMicroteachCase_Resource_Rel4AllEN.MicroteachCaseName = objRow[convMicroteachCase_Resource_Rel4All.MicroteachCaseName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.MicroteachCaseName].ToString().Trim(); //微格教学案例名称
objvMicroteachCase_Resource_Rel4AllEN.MicroteachCaseTheme = objRow[convMicroteachCase_Resource_Rel4All.MicroteachCaseTheme] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.MicroteachCaseTheme].ToString().Trim(); //微格教学案例主题词
objvMicroteachCase_Resource_Rel4AllEN.MicroteachCaseDate = objRow[convMicroteachCase_Resource_Rel4All.MicroteachCaseDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.MicroteachCaseDate].ToString().Trim(); //微格教学日期
objvMicroteachCase_Resource_Rel4AllEN.MicroteachCaseTime = objRow[convMicroteachCase_Resource_Rel4All.MicroteachCaseTime] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.MicroteachCaseTime].ToString().Trim(); //微格教学时间
objvMicroteachCase_Resource_Rel4AllEN.MicroteachCaseDateIn = objRow[convMicroteachCase_Resource_Rel4All.MicroteachCaseDateIn] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.MicroteachCaseDateIn].ToString().Trim(); //案例入库日期
objvMicroteachCase_Resource_Rel4AllEN.IdStudyLevel = objRow[convMicroteachCase_Resource_Rel4All.IdStudyLevel] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvMicroteachCase_Resource_Rel4AllEN.StudyLevelName = objRow[convMicroteachCase_Resource_Rel4All.StudyLevelName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.StudyLevelName].ToString().Trim(); //学段名称
objvMicroteachCase_Resource_Rel4AllEN.IdTeachingPlan = objRow[convMicroteachCase_Resource_Rel4All.IdTeachingPlan] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.IdTeachingPlan].ToString().Trim(); //教案流水号
objvMicroteachCase_Resource_Rel4AllEN.MicroTeachCaseTimeIn = objRow[convMicroteachCase_Resource_Rel4All.MicroTeachCaseTimeIn] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.MicroTeachCaseTimeIn].ToString().Trim(); //案例入库时间
objvMicroteachCase_Resource_Rel4AllEN.IdCaseType = objRow[convMicroteachCase_Resource_Rel4All.IdCaseType] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.IdCaseType].ToString().Trim(); //案例类型流水号
objvMicroteachCase_Resource_Rel4AllEN.IdDiscipline = objRow[convMicroteachCase_Resource_Rel4All.IdDiscipline] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.IdDiscipline].ToString().Trim(); //学科流水号
objvMicroteachCase_Resource_Rel4AllEN.DisciplineID = objRow[convMicroteachCase_Resource_Rel4All.DisciplineID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.DisciplineID].ToString().Trim(); //学科ID
objvMicroteachCase_Resource_Rel4AllEN.DisciplineName = objRow[convMicroteachCase_Resource_Rel4All.DisciplineName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.DisciplineName].ToString().Trim(); //学科名称
objvMicroteachCase_Resource_Rel4AllEN.senateGaugeVersionID = objRow[convMicroteachCase_Resource_Rel4All.senateGaugeVersionID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvMicroteachCase_Resource_Rel4AllEN.senateGaugeVersionName = objRow[convMicroteachCase_Resource_Rel4All.senateGaugeVersionName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvMicroteachCase_Resource_Rel4AllEN.senateGaugeVersionTtlScore = objRow[convMicroteachCase_Resource_Rel4All.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convMicroteachCase_Resource_Rel4All.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvMicroteachCase_Resource_Rel4AllEN.VersionNo = objRow[convMicroteachCase_Resource_Rel4All.VersionNo] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convMicroteachCase_Resource_Rel4All.VersionNo].ToString().Trim()); //版本号
objvMicroteachCase_Resource_Rel4AllEN.IdTeachSkill = objRow[convMicroteachCase_Resource_Rel4All.IdTeachSkill] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvMicroteachCase_Resource_Rel4AllEN.TeachSkillID = objRow[convMicroteachCase_Resource_Rel4All.TeachSkillID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.TeachSkillID].ToString().Trim(); //教学技能ID
objvMicroteachCase_Resource_Rel4AllEN.SkillTypeName = objRow[convMicroteachCase_Resource_Rel4All.SkillTypeName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.SkillTypeName].ToString().Trim(); //技能类型名称
objvMicroteachCase_Resource_Rel4AllEN.TeachSkillName = objRow[convMicroteachCase_Resource_Rel4All.TeachSkillName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.TeachSkillName].ToString().Trim(); //教学技能名称
objvMicroteachCase_Resource_Rel4AllEN.TeachSkillTheory = objRow[convMicroteachCase_Resource_Rel4All.TeachSkillTheory] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvMicroteachCase_Resource_Rel4AllEN.TeachSkillOperMethod = objRow[convMicroteachCase_Resource_Rel4All.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvMicroteachCase_Resource_Rel4AllEN.IdSkillType = objRow[convMicroteachCase_Resource_Rel4All.IdSkillType] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.IdSkillType].ToString().Trim(); //技能类型流水号
objvMicroteachCase_Resource_Rel4AllEN.SkillTypeID = objRow[convMicroteachCase_Resource_Rel4All.SkillTypeID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.SkillTypeID].ToString().Trim(); //技能类型ID
objvMicroteachCase_Resource_Rel4AllEN.CaseLevelId = objRow[convMicroteachCase_Resource_Rel4All.CaseLevelId] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.CaseLevelId].ToString().Trim(); //课例等级Id
objvMicroteachCase_Resource_Rel4AllEN.CaseLevelName = objRow[convMicroteachCase_Resource_Rel4All.CaseLevelName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.CaseLevelName].ToString().Trim(); //案例等级名称
objvMicroteachCase_Resource_Rel4AllEN.microteachCaseText = objRow[convMicroteachCase_Resource_Rel4All.microteachCaseText] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.microteachCaseText].ToString().Trim(); //案例文本内容
objvMicroteachCase_Resource_Rel4AllEN.OwnerId = objRow[convMicroteachCase_Resource_Rel4All.OwnerId] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.OwnerId].ToString().Trim(); //拥有者Id
objvMicroteachCase_Resource_Rel4AllEN.OwnerName = objRow[convMicroteachCase_Resource_Rel4All.OwnerName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.OwnerName].ToString().Trim(); //拥有者姓名
objvMicroteachCase_Resource_Rel4AllEN.CollegeID = objRow[convMicroteachCase_Resource_Rel4All.CollegeID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.CollegeID].ToString().Trim(); //学院ID
objvMicroteachCase_Resource_Rel4AllEN.CollegeName = objRow[convMicroteachCase_Resource_Rel4All.CollegeName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.CollegeName].ToString().Trim(); //学院名称
objvMicroteachCase_Resource_Rel4AllEN.OwnerNameWithId = objRow[convMicroteachCase_Resource_Rel4All.OwnerNameWithId] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvMicroteachCase_Resource_Rel4AllEN.IdXzCollege = objRow[convMicroteachCase_Resource_Rel4All.IdXzCollege] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.IdXzCollege].ToString().Trim(); //学院流水号
objvMicroteachCase_Resource_Rel4AllEN.IsDualVideo = TransNullToBool(objRow[convMicroteachCase_Resource_Rel4All.IsDualVideo].ToString().Trim()); //是否双视频
objvMicroteachCase_Resource_Rel4AllEN.UserKindId = objRow[convMicroteachCase_Resource_Rel4All.UserKindId] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.UserKindId].ToString().Trim(); //用户类别Id
objvMicroteachCase_Resource_Rel4AllEN.UserKindName = objRow[convMicroteachCase_Resource_Rel4All.UserKindName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.UserKindName].ToString().Trim(); //用户类别名
objvMicroteachCase_Resource_Rel4AllEN.UserTypeId = objRow[convMicroteachCase_Resource_Rel4All.UserTypeId] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.UserTypeId].ToString().Trim(); //用户类型Id
objvMicroteachCase_Resource_Rel4AllEN.UserTypeName = objRow[convMicroteachCase_Resource_Rel4All.UserTypeName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.UserTypeName].ToString().Trim(); //用户类型名称
objvMicroteachCase_Resource_Rel4AllEN.RecommendedDegreeId = objRow[convMicroteachCase_Resource_Rel4All.RecommendedDegreeId] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvMicroteachCase_Resource_Rel4AllEN.RecommendedDegreeName = objRow[convMicroteachCase_Resource_Rel4All.RecommendedDegreeName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvMicroteachCase_Resource_Rel4AllEN.BrowseCount4Case = objRow[convMicroteachCase_Resource_Rel4All.BrowseCount4Case] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convMicroteachCase_Resource_Rel4All.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvMicroteachCase_Resource_Rel4AllEN.IdResource = objRow[convMicroteachCase_Resource_Rel4All.IdResource].ToString().Trim(); //资源流水号
objvMicroteachCase_Resource_Rel4AllEN.ResourceID = objRow[convMicroteachCase_Resource_Rel4All.ResourceID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.ResourceID].ToString().Trim(); //资源ID
objvMicroteachCase_Resource_Rel4AllEN.ResourceName = objRow[convMicroteachCase_Resource_Rel4All.ResourceName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.ResourceName].ToString().Trim(); //资源名称
objvMicroteachCase_Resource_Rel4AllEN.IdFtpResource = objRow[convMicroteachCase_Resource_Rel4All.IdFtpResource] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvMicroteachCase_Resource_Rel4AllEN.IdFile = objRow[convMicroteachCase_Resource_Rel4All.IdFile] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.IdFile].ToString().Trim(); //文件流水号
objvMicroteachCase_Resource_Rel4AllEN.FileName = objRow[convMicroteachCase_Resource_Rel4All.FileName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.FileName].ToString().Trim(); //文件名称
objvMicroteachCase_Resource_Rel4AllEN.FileType = objRow[convMicroteachCase_Resource_Rel4All.FileType] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.FileType].ToString().Trim(); //文件类型
objvMicroteachCase_Resource_Rel4AllEN.SaveDate = objRow[convMicroteachCase_Resource_Rel4All.SaveDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.SaveDate].ToString().Trim(); //创建日期
objvMicroteachCase_Resource_Rel4AllEN.FileSize = objRow[convMicroteachCase_Resource_Rel4All.FileSize] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.FileSize].ToString().Trim(); //文件大小
objvMicroteachCase_Resource_Rel4AllEN.SaveTime = objRow[convMicroteachCase_Resource_Rel4All.SaveTime] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.SaveTime].ToString().Trim(); //创建时间
objvMicroteachCase_Resource_Rel4AllEN.FtpResourceID = objRow[convMicroteachCase_Resource_Rel4All.FtpResourceID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.FtpResourceID].ToString().Trim(); //FTP资源ID
objvMicroteachCase_Resource_Rel4AllEN.FileOriginalName = objRow[convMicroteachCase_Resource_Rel4All.FileOriginalName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.FileOriginalName].ToString().Trim(); //文件原名
objvMicroteachCase_Resource_Rel4AllEN.FileDirName = objRow[convMicroteachCase_Resource_Rel4All.FileDirName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.FileDirName].ToString().Trim(); //文件目录名
objvMicroteachCase_Resource_Rel4AllEN.FileRename = objRow[convMicroteachCase_Resource_Rel4All.FileRename] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.FileRename].ToString().Trim(); //文件新名
objvMicroteachCase_Resource_Rel4AllEN.FileUpDate = objRow[convMicroteachCase_Resource_Rel4All.FileUpDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.FileUpDate].ToString().Trim(); //创建日期
objvMicroteachCase_Resource_Rel4AllEN.FileUpTime = objRow[convMicroteachCase_Resource_Rel4All.FileUpTime] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.FileUpTime].ToString().Trim(); //创建时间
objvMicroteachCase_Resource_Rel4AllEN.SaveMode = TransNullToBool(objRow[convMicroteachCase_Resource_Rel4All.SaveMode].ToString().Trim()); //文件存放方式
objvMicroteachCase_Resource_Rel4AllEN.IdResourceType = objRow[convMicroteachCase_Resource_Rel4All.IdResourceType] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.IdResourceType].ToString().Trim(); //资源类型流水号
objvMicroteachCase_Resource_Rel4AllEN.ResourceTypeID = objRow[convMicroteachCase_Resource_Rel4All.ResourceTypeID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.ResourceTypeID].ToString().Trim(); //资源类型ID
objvMicroteachCase_Resource_Rel4AllEN.ResourceTypeName = objRow[convMicroteachCase_Resource_Rel4All.ResourceTypeName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.ResourceTypeName].ToString().Trim(); //资源类型名称
objvMicroteachCase_Resource_Rel4AllEN.ResourceOwner = objRow[convMicroteachCase_Resource_Rel4All.ResourceOwner] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.ResourceOwner].ToString().Trim(); //上传者
objvMicroteachCase_Resource_Rel4AllEN.ftpFileType = objRow[convMicroteachCase_Resource_Rel4All.ftpFileType] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.ftpFileType].ToString().Trim(); //ftp文件类型
objvMicroteachCase_Resource_Rel4AllEN.ftpFileSize = objRow[convMicroteachCase_Resource_Rel4All.ftpFileSize] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.ftpFileSize].ToString().Trim(); //ftp文件大小
objvMicroteachCase_Resource_Rel4AllEN.ftpResourceOwner = objRow[convMicroteachCase_Resource_Rel4All.ftpResourceOwner] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvMicroteachCase_Resource_Rel4AllEN.FileOriginName = objRow[convMicroteachCase_Resource_Rel4All.FileOriginName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.FileOriginName].ToString().Trim(); //原文件名
objvMicroteachCase_Resource_Rel4AllEN.IsExistFile = TransNullToBool(objRow[convMicroteachCase_Resource_Rel4All.IsExistFile].ToString().Trim()); //是否存在文件
objvMicroteachCase_Resource_Rel4AllEN.FileNewName = objRow[convMicroteachCase_Resource_Rel4All.FileNewName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.FileNewName].ToString().Trim(); //新文件名
objvMicroteachCase_Resource_Rel4AllEN.FileOldName = objRow[convMicroteachCase_Resource_Rel4All.FileOldName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.FileOldName].ToString().Trim(); //旧文件名
objvMicroteachCase_Resource_Rel4AllEN.IsMain = TransNullToBool(objRow[convMicroteachCase_Resource_Rel4All.IsMain].ToString().Trim()); //是否主资源
objvMicroteachCase_Resource_Rel4AllEN.IdUsingMode = objRow[convMicroteachCase_Resource_Rel4All.IdUsingMode] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.IdUsingMode].ToString().Trim(); //资源使用模式流水号
objvMicroteachCase_Resource_Rel4AllEN.IsVisible = TransNullToBool(objRow[convMicroteachCase_Resource_Rel4All.IsVisible].ToString().Trim()); //是否显示
objvMicroteachCase_Resource_Rel4AllEN.IndexNO = objRow[convMicroteachCase_Resource_Rel4All.IndexNO] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convMicroteachCase_Resource_Rel4All.IndexNO].ToString().Trim()); //序号
objvMicroteachCase_Resource_Rel4AllEN.BrowseCount = objRow[convMicroteachCase_Resource_Rel4All.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convMicroteachCase_Resource_Rel4All.BrowseCount].ToString().Trim()); //浏览次数
objvMicroteachCase_Resource_Rel4AllEN.UpdDate = objRow[convMicroteachCase_Resource_Rel4All.UpdDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.UpdDate].ToString().Trim(); //修改日期
objvMicroteachCase_Resource_Rel4AllEN.UpdUser = objRow[convMicroteachCase_Resource_Rel4All.UpdUser] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.UpdUser].ToString().Trim(); //修改人
objvMicroteachCase_Resource_Rel4AllEN.Memo = objRow[convMicroteachCase_Resource_Rel4All.Memo] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvMicroteachCase_Resource_Rel4AllDA: GetObjLst)", objException.Message));
}
objvMicroteachCase_Resource_Rel4AllEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvMicroteachCase_Resource_Rel4AllEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4AllEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvMicroteachCase_Resource_Rel4All(ref clsvMicroteachCase_Resource_Rel4AllEN objvMicroteachCase_Resource_Rel4AllEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMicroteachCase_Resource_Rel4AllDA.GetSpecSQLObj();
strSQL = "Select * from vMicroteachCase_Resource_Rel4All where IdMicroteachCaseResourceRel = " + ""+ objvMicroteachCase_Resource_Rel4AllEN.IdMicroteachCaseResourceRel+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvMicroteachCase_Resource_Rel4AllEN.IdMicroteachCaseResourceRel = TransNullToInt(objDT.Rows[0][convMicroteachCase_Resource_Rel4All.IdMicroteachCaseResourceRel].ToString().Trim()); //微格案例资源关系流水号(字段类型:bigint,字段长度:8,是否可空:False)
 objvMicroteachCase_Resource_Rel4AllEN.IdMicroteachCase = objDT.Rows[0][convMicroteachCase_Resource_Rel4All.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号(字段类型:char,字段长度:8,是否可空:False)
 objvMicroteachCase_Resource_Rel4AllEN.MicroteachCaseID = objDT.Rows[0][convMicroteachCase_Resource_Rel4All.MicroteachCaseID].ToString().Trim(); //微格教学案例ID(字段类型:char,字段长度:8,是否可空:False)
 objvMicroteachCase_Resource_Rel4AllEN.MicroteachCaseName = objDT.Rows[0][convMicroteachCase_Resource_Rel4All.MicroteachCaseName].ToString().Trim(); //微格教学案例名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvMicroteachCase_Resource_Rel4AllEN.MicroteachCaseTheme = objDT.Rows[0][convMicroteachCase_Resource_Rel4All.MicroteachCaseTheme].ToString().Trim(); //微格教学案例主题词(字段类型:varchar,字段长度:200,是否可空:True)
 objvMicroteachCase_Resource_Rel4AllEN.MicroteachCaseDate = objDT.Rows[0][convMicroteachCase_Resource_Rel4All.MicroteachCaseDate].ToString().Trim(); //微格教学日期(字段类型:char,字段长度:8,是否可空:True)
 objvMicroteachCase_Resource_Rel4AllEN.MicroteachCaseTime = objDT.Rows[0][convMicroteachCase_Resource_Rel4All.MicroteachCaseTime].ToString().Trim(); //微格教学时间(字段类型:char,字段长度:6,是否可空:True)
 objvMicroteachCase_Resource_Rel4AllEN.MicroteachCaseDateIn = objDT.Rows[0][convMicroteachCase_Resource_Rel4All.MicroteachCaseDateIn].ToString().Trim(); //案例入库日期(字段类型:char,字段长度:8,是否可空:True)
 objvMicroteachCase_Resource_Rel4AllEN.IdStudyLevel = objDT.Rows[0][convMicroteachCase_Resource_Rel4All.IdStudyLevel].ToString().Trim(); //id_StudyLevel(字段类型:char,字段长度:4,是否可空:True)
 objvMicroteachCase_Resource_Rel4AllEN.StudyLevelName = objDT.Rows[0][convMicroteachCase_Resource_Rel4All.StudyLevelName].ToString().Trim(); //学段名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvMicroteachCase_Resource_Rel4AllEN.IdTeachingPlan = objDT.Rows[0][convMicroteachCase_Resource_Rel4All.IdTeachingPlan].ToString().Trim(); //教案流水号(字段类型:char,字段长度:8,是否可空:False)
 objvMicroteachCase_Resource_Rel4AllEN.MicroTeachCaseTimeIn = objDT.Rows[0][convMicroteachCase_Resource_Rel4All.MicroTeachCaseTimeIn].ToString().Trim(); //案例入库时间(字段类型:char,字段长度:6,是否可空:True)
 objvMicroteachCase_Resource_Rel4AllEN.IdCaseType = objDT.Rows[0][convMicroteachCase_Resource_Rel4All.IdCaseType].ToString().Trim(); //案例类型流水号(字段类型:char,字段长度:4,是否可空:True)
 objvMicroteachCase_Resource_Rel4AllEN.IdDiscipline = objDT.Rows[0][convMicroteachCase_Resource_Rel4All.IdDiscipline].ToString().Trim(); //学科流水号(字段类型:char,字段长度:4,是否可空:False)
 objvMicroteachCase_Resource_Rel4AllEN.DisciplineID = objDT.Rows[0][convMicroteachCase_Resource_Rel4All.DisciplineID].ToString().Trim(); //学科ID(字段类型:char,字段长度:4,是否可空:False)
 objvMicroteachCase_Resource_Rel4AllEN.DisciplineName = objDT.Rows[0][convMicroteachCase_Resource_Rel4All.DisciplineName].ToString().Trim(); //学科名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvMicroteachCase_Resource_Rel4AllEN.senateGaugeVersionID = objDT.Rows[0][convMicroteachCase_Resource_Rel4All.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID(字段类型:char,字段长度:4,是否可空:False)
 objvMicroteachCase_Resource_Rel4AllEN.senateGaugeVersionName = objDT.Rows[0][convMicroteachCase_Resource_Rel4All.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称(字段类型:varchar,字段长度:200,是否可空:True)
 objvMicroteachCase_Resource_Rel4AllEN.senateGaugeVersionTtlScore = TransNullToFloat(objDT.Rows[0][convMicroteachCase_Resource_Rel4All.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分(字段类型:float,字段长度:8,是否可空:False)
 objvMicroteachCase_Resource_Rel4AllEN.VersionNo = TransNullToInt(objDT.Rows[0][convMicroteachCase_Resource_Rel4All.VersionNo].ToString().Trim()); //版本号(字段类型:int,字段长度:4,是否可空:True)
 objvMicroteachCase_Resource_Rel4AllEN.IdTeachSkill = objDT.Rows[0][convMicroteachCase_Resource_Rel4All.IdTeachSkill].ToString().Trim(); //教学技能流水号(字段类型:char,字段长度:8,是否可空:False)
 objvMicroteachCase_Resource_Rel4AllEN.TeachSkillID = objDT.Rows[0][convMicroteachCase_Resource_Rel4All.TeachSkillID].ToString().Trim(); //教学技能ID(字段类型:char,字段长度:8,是否可空:False)
 objvMicroteachCase_Resource_Rel4AllEN.SkillTypeName = objDT.Rows[0][convMicroteachCase_Resource_Rel4All.SkillTypeName].ToString().Trim(); //技能类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvMicroteachCase_Resource_Rel4AllEN.TeachSkillName = objDT.Rows[0][convMicroteachCase_Resource_Rel4All.TeachSkillName].ToString().Trim(); //教学技能名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvMicroteachCase_Resource_Rel4AllEN.TeachSkillTheory = objDT.Rows[0][convMicroteachCase_Resource_Rel4All.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述(字段类型:varchar,字段长度:8000,是否可空:True)
 objvMicroteachCase_Resource_Rel4AllEN.TeachSkillOperMethod = objDT.Rows[0][convMicroteachCase_Resource_Rel4All.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法(字段类型:varchar,字段长度:2000,是否可空:True)
 objvMicroteachCase_Resource_Rel4AllEN.IdSkillType = objDT.Rows[0][convMicroteachCase_Resource_Rel4All.IdSkillType].ToString().Trim(); //技能类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvMicroteachCase_Resource_Rel4AllEN.SkillTypeID = objDT.Rows[0][convMicroteachCase_Resource_Rel4All.SkillTypeID].ToString().Trim(); //技能类型ID(字段类型:char,字段长度:4,是否可空:False)
 objvMicroteachCase_Resource_Rel4AllEN.CaseLevelId = objDT.Rows[0][convMicroteachCase_Resource_Rel4All.CaseLevelId].ToString().Trim(); //课例等级Id(字段类型:char,字段长度:2,是否可空:True)
 objvMicroteachCase_Resource_Rel4AllEN.CaseLevelName = objDT.Rows[0][convMicroteachCase_Resource_Rel4All.CaseLevelName].ToString().Trim(); //案例等级名称(字段类型:varchar,字段长度:30,是否可空:True)
 objvMicroteachCase_Resource_Rel4AllEN.microteachCaseText = objDT.Rows[0][convMicroteachCase_Resource_Rel4All.microteachCaseText].ToString().Trim(); //案例文本内容(字段类型:varchar,字段长度:8000,是否可空:True)
 objvMicroteachCase_Resource_Rel4AllEN.OwnerId = objDT.Rows[0][convMicroteachCase_Resource_Rel4All.OwnerId].ToString().Trim(); //拥有者Id(字段类型:varchar,字段长度:20,是否可空:False)
 objvMicroteachCase_Resource_Rel4AllEN.OwnerName = objDT.Rows[0][convMicroteachCase_Resource_Rel4All.OwnerName].ToString().Trim(); //拥有者姓名(字段类型:varchar,字段长度:30,是否可空:True)
 objvMicroteachCase_Resource_Rel4AllEN.CollegeID = objDT.Rows[0][convMicroteachCase_Resource_Rel4All.CollegeID].ToString().Trim(); //学院ID(字段类型:varchar,字段长度:4,是否可空:False)
 objvMicroteachCase_Resource_Rel4AllEN.CollegeName = objDT.Rows[0][convMicroteachCase_Resource_Rel4All.CollegeName].ToString().Trim(); //学院名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvMicroteachCase_Resource_Rel4AllEN.OwnerNameWithId = objDT.Rows[0][convMicroteachCase_Resource_Rel4All.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id(字段类型:varchar,字段长度:51,是否可空:True)
 objvMicroteachCase_Resource_Rel4AllEN.IdXzCollege = objDT.Rows[0][convMicroteachCase_Resource_Rel4All.IdXzCollege].ToString().Trim(); //学院流水号(字段类型:char,字段长度:4,是否可空:True)
 objvMicroteachCase_Resource_Rel4AllEN.IsDualVideo = TransNullToBool(objDT.Rows[0][convMicroteachCase_Resource_Rel4All.IsDualVideo].ToString().Trim()); //是否双视频(字段类型:bit,字段长度:1,是否可空:False)
 objvMicroteachCase_Resource_Rel4AllEN.UserKindId = objDT.Rows[0][convMicroteachCase_Resource_Rel4All.UserKindId].ToString().Trim(); //用户类别Id(字段类型:char,字段长度:2,是否可空:False)
 objvMicroteachCase_Resource_Rel4AllEN.UserKindName = objDT.Rows[0][convMicroteachCase_Resource_Rel4All.UserKindName].ToString().Trim(); //用户类别名(字段类型:varchar,字段长度:30,是否可空:False)
 objvMicroteachCase_Resource_Rel4AllEN.UserTypeId = objDT.Rows[0][convMicroteachCase_Resource_Rel4All.UserTypeId].ToString().Trim(); //用户类型Id(字段类型:char,字段长度:2,是否可空:True)
 objvMicroteachCase_Resource_Rel4AllEN.UserTypeName = objDT.Rows[0][convMicroteachCase_Resource_Rel4All.UserTypeName].ToString().Trim(); //用户类型名称(字段类型:varchar,字段长度:20,是否可空:True)
 objvMicroteachCase_Resource_Rel4AllEN.RecommendedDegreeId = objDT.Rows[0][convMicroteachCase_Resource_Rel4All.RecommendedDegreeId].ToString().Trim(); //推荐度Id(字段类型:char,字段长度:2,是否可空:False)
 objvMicroteachCase_Resource_Rel4AllEN.RecommendedDegreeName = objDT.Rows[0][convMicroteachCase_Resource_Rel4All.RecommendedDegreeName].ToString().Trim(); //推荐度名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvMicroteachCase_Resource_Rel4AllEN.BrowseCount4Case = TransNullToInt(objDT.Rows[0][convMicroteachCase_Resource_Rel4All.BrowseCount4Case].ToString().Trim()); //课例浏览次数(字段类型:int,字段长度:4,是否可空:True)
 objvMicroteachCase_Resource_Rel4AllEN.IdResource = objDT.Rows[0][convMicroteachCase_Resource_Rel4All.IdResource].ToString().Trim(); //资源流水号(字段类型:char,字段长度:8,是否可空:False)
 objvMicroteachCase_Resource_Rel4AllEN.ResourceID = objDT.Rows[0][convMicroteachCase_Resource_Rel4All.ResourceID].ToString().Trim(); //资源ID(字段类型:char,字段长度:8,是否可空:False)
 objvMicroteachCase_Resource_Rel4AllEN.ResourceName = objDT.Rows[0][convMicroteachCase_Resource_Rel4All.ResourceName].ToString().Trim(); //资源名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvMicroteachCase_Resource_Rel4AllEN.IdFtpResource = objDT.Rows[0][convMicroteachCase_Resource_Rel4All.IdFtpResource].ToString().Trim(); //FTP资源流水号(字段类型:char,字段长度:8,是否可空:True)
 objvMicroteachCase_Resource_Rel4AllEN.IdFile = objDT.Rows[0][convMicroteachCase_Resource_Rel4All.IdFile].ToString().Trim(); //文件流水号(字段类型:char,字段长度:8,是否可空:True)
 objvMicroteachCase_Resource_Rel4AllEN.FileName = objDT.Rows[0][convMicroteachCase_Resource_Rel4All.FileName].ToString().Trim(); //文件名称(字段类型:varchar,字段长度:500,是否可空:True)
 objvMicroteachCase_Resource_Rel4AllEN.FileType = objDT.Rows[0][convMicroteachCase_Resource_Rel4All.FileType].ToString().Trim(); //文件类型(字段类型:varchar,字段长度:30,是否可空:True)
 objvMicroteachCase_Resource_Rel4AllEN.SaveDate = objDT.Rows[0][convMicroteachCase_Resource_Rel4All.SaveDate].ToString().Trim(); //创建日期(字段类型:char,字段长度:8,是否可空:True)
 objvMicroteachCase_Resource_Rel4AllEN.FileSize = objDT.Rows[0][convMicroteachCase_Resource_Rel4All.FileSize].ToString().Trim(); //文件大小(字段类型:varchar,字段长度:50,是否可空:True)
 objvMicroteachCase_Resource_Rel4AllEN.SaveTime = objDT.Rows[0][convMicroteachCase_Resource_Rel4All.SaveTime].ToString().Trim(); //创建时间(字段类型:char,字段长度:6,是否可空:True)
 objvMicroteachCase_Resource_Rel4AllEN.FtpResourceID = objDT.Rows[0][convMicroteachCase_Resource_Rel4All.FtpResourceID].ToString().Trim(); //FTP资源ID(字段类型:char,字段长度:8,是否可空:False)
 objvMicroteachCase_Resource_Rel4AllEN.FileOriginalName = objDT.Rows[0][convMicroteachCase_Resource_Rel4All.FileOriginalName].ToString().Trim(); //文件原名(字段类型:varchar,字段长度:200,是否可空:True)
 objvMicroteachCase_Resource_Rel4AllEN.FileDirName = objDT.Rows[0][convMicroteachCase_Resource_Rel4All.FileDirName].ToString().Trim(); //文件目录名(字段类型:varchar,字段长度:200,是否可空:True)
 objvMicroteachCase_Resource_Rel4AllEN.FileRename = objDT.Rows[0][convMicroteachCase_Resource_Rel4All.FileRename].ToString().Trim(); //文件新名(字段类型:varchar,字段长度:200,是否可空:True)
 objvMicroteachCase_Resource_Rel4AllEN.FileUpDate = objDT.Rows[0][convMicroteachCase_Resource_Rel4All.FileUpDate].ToString().Trim(); //创建日期(字段类型:char,字段长度:8,是否可空:True)
 objvMicroteachCase_Resource_Rel4AllEN.FileUpTime = objDT.Rows[0][convMicroteachCase_Resource_Rel4All.FileUpTime].ToString().Trim(); //创建时间(字段类型:char,字段长度:6,是否可空:True)
 objvMicroteachCase_Resource_Rel4AllEN.SaveMode = TransNullToBool(objDT.Rows[0][convMicroteachCase_Resource_Rel4All.SaveMode].ToString().Trim()); //文件存放方式(字段类型:bit,字段长度:1,是否可空:True)
 objvMicroteachCase_Resource_Rel4AllEN.IdResourceType = objDT.Rows[0][convMicroteachCase_Resource_Rel4All.IdResourceType].ToString().Trim(); //资源类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvMicroteachCase_Resource_Rel4AllEN.ResourceTypeID = objDT.Rows[0][convMicroteachCase_Resource_Rel4All.ResourceTypeID].ToString().Trim(); //资源类型ID(字段类型:char,字段长度:4,是否可空:False)
 objvMicroteachCase_Resource_Rel4AllEN.ResourceTypeName = objDT.Rows[0][convMicroteachCase_Resource_Rel4All.ResourceTypeName].ToString().Trim(); //资源类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvMicroteachCase_Resource_Rel4AllEN.ResourceOwner = objDT.Rows[0][convMicroteachCase_Resource_Rel4All.ResourceOwner].ToString().Trim(); //上传者(字段类型:varchar,字段长度:50,是否可空:False)
 objvMicroteachCase_Resource_Rel4AllEN.ftpFileType = objDT.Rows[0][convMicroteachCase_Resource_Rel4All.ftpFileType].ToString().Trim(); //ftp文件类型(字段类型:varchar,字段长度:30,是否可空:True)
 objvMicroteachCase_Resource_Rel4AllEN.ftpFileSize = objDT.Rows[0][convMicroteachCase_Resource_Rel4All.ftpFileSize].ToString().Trim(); //ftp文件大小(字段类型:varchar,字段长度:50,是否可空:True)
 objvMicroteachCase_Resource_Rel4AllEN.ftpResourceOwner = objDT.Rows[0][convMicroteachCase_Resource_Rel4All.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者(字段类型:varchar,字段长度:50,是否可空:True)
 objvMicroteachCase_Resource_Rel4AllEN.FileOriginName = objDT.Rows[0][convMicroteachCase_Resource_Rel4All.FileOriginName].ToString().Trim(); //原文件名(字段类型:varchar,字段长度:500,是否可空:True)
 objvMicroteachCase_Resource_Rel4AllEN.IsExistFile = TransNullToBool(objDT.Rows[0][convMicroteachCase_Resource_Rel4All.IsExistFile].ToString().Trim()); //是否存在文件(字段类型:bit,字段长度:1,是否可空:True)
 objvMicroteachCase_Resource_Rel4AllEN.FileNewName = objDT.Rows[0][convMicroteachCase_Resource_Rel4All.FileNewName].ToString().Trim(); //新文件名(字段类型:varchar,字段长度:530,是否可空:True)
 objvMicroteachCase_Resource_Rel4AllEN.FileOldName = objDT.Rows[0][convMicroteachCase_Resource_Rel4All.FileOldName].ToString().Trim(); //旧文件名(字段类型:varchar,字段长度:530,是否可空:True)
 objvMicroteachCase_Resource_Rel4AllEN.IsMain = TransNullToBool(objDT.Rows[0][convMicroteachCase_Resource_Rel4All.IsMain].ToString().Trim()); //是否主资源(字段类型:bit,字段长度:1,是否可空:True)
 objvMicroteachCase_Resource_Rel4AllEN.IdUsingMode = objDT.Rows[0][convMicroteachCase_Resource_Rel4All.IdUsingMode].ToString().Trim(); //资源使用模式流水号(字段类型:char,字段长度:4,是否可空:False)
 objvMicroteachCase_Resource_Rel4AllEN.IsVisible = TransNullToBool(objDT.Rows[0][convMicroteachCase_Resource_Rel4All.IsVisible].ToString().Trim()); //是否显示(字段类型:bit,字段长度:1,是否可空:True)
 objvMicroteachCase_Resource_Rel4AllEN.IndexNO = TransNullToInt(objDT.Rows[0][convMicroteachCase_Resource_Rel4All.IndexNO].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:True)
 objvMicroteachCase_Resource_Rel4AllEN.BrowseCount = TransNullToInt(objDT.Rows[0][convMicroteachCase_Resource_Rel4All.BrowseCount].ToString().Trim()); //浏览次数(字段类型:int,字段长度:4,是否可空:True)
 objvMicroteachCase_Resource_Rel4AllEN.UpdDate = objDT.Rows[0][convMicroteachCase_Resource_Rel4All.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvMicroteachCase_Resource_Rel4AllEN.UpdUser = objDT.Rows[0][convMicroteachCase_Resource_Rel4All.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objvMicroteachCase_Resource_Rel4AllEN.Memo = objDT.Rows[0][convMicroteachCase_Resource_Rel4All.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvMicroteachCase_Resource_Rel4AllDA: GetvMicroteachCase_Resource_Rel4All)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngIdMicroteachCaseResourceRel">表关键字</param>
 /// <returns>表对象</returns>
public clsvMicroteachCase_Resource_Rel4AllEN GetObjByIdMicroteachCaseResourceRel(long lngIdMicroteachCaseResourceRel)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMicroteachCase_Resource_Rel4AllDA.GetSpecSQLObj();
strSQL = "Select * from vMicroteachCase_Resource_Rel4All where IdMicroteachCaseResourceRel = " + ""+ lngIdMicroteachCaseResourceRel+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvMicroteachCase_Resource_Rel4AllEN objvMicroteachCase_Resource_Rel4AllEN = new clsvMicroteachCase_Resource_Rel4AllEN();
try
{
 objvMicroteachCase_Resource_Rel4AllEN.IdMicroteachCaseResourceRel = Int32.Parse(objRow[convMicroteachCase_Resource_Rel4All.IdMicroteachCaseResourceRel].ToString().Trim()); //微格案例资源关系流水号(字段类型:bigint,字段长度:8,是否可空:False)
 objvMicroteachCase_Resource_Rel4AllEN.IdMicroteachCase = objRow[convMicroteachCase_Resource_Rel4All.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号(字段类型:char,字段长度:8,是否可空:False)
 objvMicroteachCase_Resource_Rel4AllEN.MicroteachCaseID = objRow[convMicroteachCase_Resource_Rel4All.MicroteachCaseID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.MicroteachCaseID].ToString().Trim(); //微格教学案例ID(字段类型:char,字段长度:8,是否可空:False)
 objvMicroteachCase_Resource_Rel4AllEN.MicroteachCaseName = objRow[convMicroteachCase_Resource_Rel4All.MicroteachCaseName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.MicroteachCaseName].ToString().Trim(); //微格教学案例名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvMicroteachCase_Resource_Rel4AllEN.MicroteachCaseTheme = objRow[convMicroteachCase_Resource_Rel4All.MicroteachCaseTheme] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.MicroteachCaseTheme].ToString().Trim(); //微格教学案例主题词(字段类型:varchar,字段长度:200,是否可空:True)
 objvMicroteachCase_Resource_Rel4AllEN.MicroteachCaseDate = objRow[convMicroteachCase_Resource_Rel4All.MicroteachCaseDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.MicroteachCaseDate].ToString().Trim(); //微格教学日期(字段类型:char,字段长度:8,是否可空:True)
 objvMicroteachCase_Resource_Rel4AllEN.MicroteachCaseTime = objRow[convMicroteachCase_Resource_Rel4All.MicroteachCaseTime] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.MicroteachCaseTime].ToString().Trim(); //微格教学时间(字段类型:char,字段长度:6,是否可空:True)
 objvMicroteachCase_Resource_Rel4AllEN.MicroteachCaseDateIn = objRow[convMicroteachCase_Resource_Rel4All.MicroteachCaseDateIn] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.MicroteachCaseDateIn].ToString().Trim(); //案例入库日期(字段类型:char,字段长度:8,是否可空:True)
 objvMicroteachCase_Resource_Rel4AllEN.IdStudyLevel = objRow[convMicroteachCase_Resource_Rel4All.IdStudyLevel] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.IdStudyLevel].ToString().Trim(); //id_StudyLevel(字段类型:char,字段长度:4,是否可空:True)
 objvMicroteachCase_Resource_Rel4AllEN.StudyLevelName = objRow[convMicroteachCase_Resource_Rel4All.StudyLevelName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.StudyLevelName].ToString().Trim(); //学段名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvMicroteachCase_Resource_Rel4AllEN.IdTeachingPlan = objRow[convMicroteachCase_Resource_Rel4All.IdTeachingPlan] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.IdTeachingPlan].ToString().Trim(); //教案流水号(字段类型:char,字段长度:8,是否可空:False)
 objvMicroteachCase_Resource_Rel4AllEN.MicroTeachCaseTimeIn = objRow[convMicroteachCase_Resource_Rel4All.MicroTeachCaseTimeIn] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.MicroTeachCaseTimeIn].ToString().Trim(); //案例入库时间(字段类型:char,字段长度:6,是否可空:True)
 objvMicroteachCase_Resource_Rel4AllEN.IdCaseType = objRow[convMicroteachCase_Resource_Rel4All.IdCaseType] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.IdCaseType].ToString().Trim(); //案例类型流水号(字段类型:char,字段长度:4,是否可空:True)
 objvMicroteachCase_Resource_Rel4AllEN.IdDiscipline = objRow[convMicroteachCase_Resource_Rel4All.IdDiscipline] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.IdDiscipline].ToString().Trim(); //学科流水号(字段类型:char,字段长度:4,是否可空:False)
 objvMicroteachCase_Resource_Rel4AllEN.DisciplineID = objRow[convMicroteachCase_Resource_Rel4All.DisciplineID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.DisciplineID].ToString().Trim(); //学科ID(字段类型:char,字段长度:4,是否可空:False)
 objvMicroteachCase_Resource_Rel4AllEN.DisciplineName = objRow[convMicroteachCase_Resource_Rel4All.DisciplineName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.DisciplineName].ToString().Trim(); //学科名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvMicroteachCase_Resource_Rel4AllEN.senateGaugeVersionID = objRow[convMicroteachCase_Resource_Rel4All.senateGaugeVersionID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID(字段类型:char,字段长度:4,是否可空:False)
 objvMicroteachCase_Resource_Rel4AllEN.senateGaugeVersionName = objRow[convMicroteachCase_Resource_Rel4All.senateGaugeVersionName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称(字段类型:varchar,字段长度:200,是否可空:True)
 objvMicroteachCase_Resource_Rel4AllEN.senateGaugeVersionTtlScore = objRow[convMicroteachCase_Resource_Rel4All.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convMicroteachCase_Resource_Rel4All.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分(字段类型:float,字段长度:8,是否可空:False)
 objvMicroteachCase_Resource_Rel4AllEN.VersionNo = objRow[convMicroteachCase_Resource_Rel4All.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachCase_Resource_Rel4All.VersionNo].ToString().Trim()); //版本号(字段类型:int,字段长度:4,是否可空:True)
 objvMicroteachCase_Resource_Rel4AllEN.IdTeachSkill = objRow[convMicroteachCase_Resource_Rel4All.IdTeachSkill] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.IdTeachSkill].ToString().Trim(); //教学技能流水号(字段类型:char,字段长度:8,是否可空:False)
 objvMicroteachCase_Resource_Rel4AllEN.TeachSkillID = objRow[convMicroteachCase_Resource_Rel4All.TeachSkillID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.TeachSkillID].ToString().Trim(); //教学技能ID(字段类型:char,字段长度:8,是否可空:False)
 objvMicroteachCase_Resource_Rel4AllEN.SkillTypeName = objRow[convMicroteachCase_Resource_Rel4All.SkillTypeName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.SkillTypeName].ToString().Trim(); //技能类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvMicroteachCase_Resource_Rel4AllEN.TeachSkillName = objRow[convMicroteachCase_Resource_Rel4All.TeachSkillName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.TeachSkillName].ToString().Trim(); //教学技能名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvMicroteachCase_Resource_Rel4AllEN.TeachSkillTheory = objRow[convMicroteachCase_Resource_Rel4All.TeachSkillTheory] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述(字段类型:varchar,字段长度:8000,是否可空:True)
 objvMicroteachCase_Resource_Rel4AllEN.TeachSkillOperMethod = objRow[convMicroteachCase_Resource_Rel4All.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法(字段类型:varchar,字段长度:2000,是否可空:True)
 objvMicroteachCase_Resource_Rel4AllEN.IdSkillType = objRow[convMicroteachCase_Resource_Rel4All.IdSkillType] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.IdSkillType].ToString().Trim(); //技能类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvMicroteachCase_Resource_Rel4AllEN.SkillTypeID = objRow[convMicroteachCase_Resource_Rel4All.SkillTypeID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.SkillTypeID].ToString().Trim(); //技能类型ID(字段类型:char,字段长度:4,是否可空:False)
 objvMicroteachCase_Resource_Rel4AllEN.CaseLevelId = objRow[convMicroteachCase_Resource_Rel4All.CaseLevelId] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.CaseLevelId].ToString().Trim(); //课例等级Id(字段类型:char,字段长度:2,是否可空:True)
 objvMicroteachCase_Resource_Rel4AllEN.CaseLevelName = objRow[convMicroteachCase_Resource_Rel4All.CaseLevelName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.CaseLevelName].ToString().Trim(); //案例等级名称(字段类型:varchar,字段长度:30,是否可空:True)
 objvMicroteachCase_Resource_Rel4AllEN.microteachCaseText = objRow[convMicroteachCase_Resource_Rel4All.microteachCaseText] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.microteachCaseText].ToString().Trim(); //案例文本内容(字段类型:varchar,字段长度:8000,是否可空:True)
 objvMicroteachCase_Resource_Rel4AllEN.OwnerId = objRow[convMicroteachCase_Resource_Rel4All.OwnerId] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.OwnerId].ToString().Trim(); //拥有者Id(字段类型:varchar,字段长度:20,是否可空:False)
 objvMicroteachCase_Resource_Rel4AllEN.OwnerName = objRow[convMicroteachCase_Resource_Rel4All.OwnerName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.OwnerName].ToString().Trim(); //拥有者姓名(字段类型:varchar,字段长度:30,是否可空:True)
 objvMicroteachCase_Resource_Rel4AllEN.CollegeID = objRow[convMicroteachCase_Resource_Rel4All.CollegeID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.CollegeID].ToString().Trim(); //学院ID(字段类型:varchar,字段长度:4,是否可空:False)
 objvMicroteachCase_Resource_Rel4AllEN.CollegeName = objRow[convMicroteachCase_Resource_Rel4All.CollegeName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.CollegeName].ToString().Trim(); //学院名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvMicroteachCase_Resource_Rel4AllEN.OwnerNameWithId = objRow[convMicroteachCase_Resource_Rel4All.OwnerNameWithId] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id(字段类型:varchar,字段长度:51,是否可空:True)
 objvMicroteachCase_Resource_Rel4AllEN.IdXzCollege = objRow[convMicroteachCase_Resource_Rel4All.IdXzCollege] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.IdXzCollege].ToString().Trim(); //学院流水号(字段类型:char,字段长度:4,是否可空:True)
 objvMicroteachCase_Resource_Rel4AllEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCase_Resource_Rel4All.IsDualVideo].ToString().Trim()); //是否双视频(字段类型:bit,字段长度:1,是否可空:False)
 objvMicroteachCase_Resource_Rel4AllEN.UserKindId = objRow[convMicroteachCase_Resource_Rel4All.UserKindId] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.UserKindId].ToString().Trim(); //用户类别Id(字段类型:char,字段长度:2,是否可空:False)
 objvMicroteachCase_Resource_Rel4AllEN.UserKindName = objRow[convMicroteachCase_Resource_Rel4All.UserKindName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.UserKindName].ToString().Trim(); //用户类别名(字段类型:varchar,字段长度:30,是否可空:False)
 objvMicroteachCase_Resource_Rel4AllEN.UserTypeId = objRow[convMicroteachCase_Resource_Rel4All.UserTypeId] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.UserTypeId].ToString().Trim(); //用户类型Id(字段类型:char,字段长度:2,是否可空:True)
 objvMicroteachCase_Resource_Rel4AllEN.UserTypeName = objRow[convMicroteachCase_Resource_Rel4All.UserTypeName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.UserTypeName].ToString().Trim(); //用户类型名称(字段类型:varchar,字段长度:20,是否可空:True)
 objvMicroteachCase_Resource_Rel4AllEN.RecommendedDegreeId = objRow[convMicroteachCase_Resource_Rel4All.RecommendedDegreeId] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.RecommendedDegreeId].ToString().Trim(); //推荐度Id(字段类型:char,字段长度:2,是否可空:False)
 objvMicroteachCase_Resource_Rel4AllEN.RecommendedDegreeName = objRow[convMicroteachCase_Resource_Rel4All.RecommendedDegreeName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.RecommendedDegreeName].ToString().Trim(); //推荐度名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvMicroteachCase_Resource_Rel4AllEN.BrowseCount4Case = objRow[convMicroteachCase_Resource_Rel4All.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachCase_Resource_Rel4All.BrowseCount4Case].ToString().Trim()); //课例浏览次数(字段类型:int,字段长度:4,是否可空:True)
 objvMicroteachCase_Resource_Rel4AllEN.IdResource = objRow[convMicroteachCase_Resource_Rel4All.IdResource].ToString().Trim(); //资源流水号(字段类型:char,字段长度:8,是否可空:False)
 objvMicroteachCase_Resource_Rel4AllEN.ResourceID = objRow[convMicroteachCase_Resource_Rel4All.ResourceID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.ResourceID].ToString().Trim(); //资源ID(字段类型:char,字段长度:8,是否可空:False)
 objvMicroteachCase_Resource_Rel4AllEN.ResourceName = objRow[convMicroteachCase_Resource_Rel4All.ResourceName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.ResourceName].ToString().Trim(); //资源名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvMicroteachCase_Resource_Rel4AllEN.IdFtpResource = objRow[convMicroteachCase_Resource_Rel4All.IdFtpResource] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.IdFtpResource].ToString().Trim(); //FTP资源流水号(字段类型:char,字段长度:8,是否可空:True)
 objvMicroteachCase_Resource_Rel4AllEN.IdFile = objRow[convMicroteachCase_Resource_Rel4All.IdFile] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.IdFile].ToString().Trim(); //文件流水号(字段类型:char,字段长度:8,是否可空:True)
 objvMicroteachCase_Resource_Rel4AllEN.FileName = objRow[convMicroteachCase_Resource_Rel4All.FileName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.FileName].ToString().Trim(); //文件名称(字段类型:varchar,字段长度:500,是否可空:True)
 objvMicroteachCase_Resource_Rel4AllEN.FileType = objRow[convMicroteachCase_Resource_Rel4All.FileType] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.FileType].ToString().Trim(); //文件类型(字段类型:varchar,字段长度:30,是否可空:True)
 objvMicroteachCase_Resource_Rel4AllEN.SaveDate = objRow[convMicroteachCase_Resource_Rel4All.SaveDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.SaveDate].ToString().Trim(); //创建日期(字段类型:char,字段长度:8,是否可空:True)
 objvMicroteachCase_Resource_Rel4AllEN.FileSize = objRow[convMicroteachCase_Resource_Rel4All.FileSize] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.FileSize].ToString().Trim(); //文件大小(字段类型:varchar,字段长度:50,是否可空:True)
 objvMicroteachCase_Resource_Rel4AllEN.SaveTime = objRow[convMicroteachCase_Resource_Rel4All.SaveTime] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.SaveTime].ToString().Trim(); //创建时间(字段类型:char,字段长度:6,是否可空:True)
 objvMicroteachCase_Resource_Rel4AllEN.FtpResourceID = objRow[convMicroteachCase_Resource_Rel4All.FtpResourceID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.FtpResourceID].ToString().Trim(); //FTP资源ID(字段类型:char,字段长度:8,是否可空:False)
 objvMicroteachCase_Resource_Rel4AllEN.FileOriginalName = objRow[convMicroteachCase_Resource_Rel4All.FileOriginalName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.FileOriginalName].ToString().Trim(); //文件原名(字段类型:varchar,字段长度:200,是否可空:True)
 objvMicroteachCase_Resource_Rel4AllEN.FileDirName = objRow[convMicroteachCase_Resource_Rel4All.FileDirName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.FileDirName].ToString().Trim(); //文件目录名(字段类型:varchar,字段长度:200,是否可空:True)
 objvMicroteachCase_Resource_Rel4AllEN.FileRename = objRow[convMicroteachCase_Resource_Rel4All.FileRename] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.FileRename].ToString().Trim(); //文件新名(字段类型:varchar,字段长度:200,是否可空:True)
 objvMicroteachCase_Resource_Rel4AllEN.FileUpDate = objRow[convMicroteachCase_Resource_Rel4All.FileUpDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.FileUpDate].ToString().Trim(); //创建日期(字段类型:char,字段长度:8,是否可空:True)
 objvMicroteachCase_Resource_Rel4AllEN.FileUpTime = objRow[convMicroteachCase_Resource_Rel4All.FileUpTime] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.FileUpTime].ToString().Trim(); //创建时间(字段类型:char,字段长度:6,是否可空:True)
 objvMicroteachCase_Resource_Rel4AllEN.SaveMode = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCase_Resource_Rel4All.SaveMode].ToString().Trim()); //文件存放方式(字段类型:bit,字段长度:1,是否可空:True)
 objvMicroteachCase_Resource_Rel4AllEN.IdResourceType = objRow[convMicroteachCase_Resource_Rel4All.IdResourceType] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.IdResourceType].ToString().Trim(); //资源类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvMicroteachCase_Resource_Rel4AllEN.ResourceTypeID = objRow[convMicroteachCase_Resource_Rel4All.ResourceTypeID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.ResourceTypeID].ToString().Trim(); //资源类型ID(字段类型:char,字段长度:4,是否可空:False)
 objvMicroteachCase_Resource_Rel4AllEN.ResourceTypeName = objRow[convMicroteachCase_Resource_Rel4All.ResourceTypeName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.ResourceTypeName].ToString().Trim(); //资源类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvMicroteachCase_Resource_Rel4AllEN.ResourceOwner = objRow[convMicroteachCase_Resource_Rel4All.ResourceOwner] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.ResourceOwner].ToString().Trim(); //上传者(字段类型:varchar,字段长度:50,是否可空:False)
 objvMicroteachCase_Resource_Rel4AllEN.ftpFileType = objRow[convMicroteachCase_Resource_Rel4All.ftpFileType] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.ftpFileType].ToString().Trim(); //ftp文件类型(字段类型:varchar,字段长度:30,是否可空:True)
 objvMicroteachCase_Resource_Rel4AllEN.ftpFileSize = objRow[convMicroteachCase_Resource_Rel4All.ftpFileSize] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.ftpFileSize].ToString().Trim(); //ftp文件大小(字段类型:varchar,字段长度:50,是否可空:True)
 objvMicroteachCase_Resource_Rel4AllEN.ftpResourceOwner = objRow[convMicroteachCase_Resource_Rel4All.ftpResourceOwner] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者(字段类型:varchar,字段长度:50,是否可空:True)
 objvMicroteachCase_Resource_Rel4AllEN.FileOriginName = objRow[convMicroteachCase_Resource_Rel4All.FileOriginName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.FileOriginName].ToString().Trim(); //原文件名(字段类型:varchar,字段长度:500,是否可空:True)
 objvMicroteachCase_Resource_Rel4AllEN.IsExistFile = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCase_Resource_Rel4All.IsExistFile].ToString().Trim()); //是否存在文件(字段类型:bit,字段长度:1,是否可空:True)
 objvMicroteachCase_Resource_Rel4AllEN.FileNewName = objRow[convMicroteachCase_Resource_Rel4All.FileNewName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.FileNewName].ToString().Trim(); //新文件名(字段类型:varchar,字段长度:530,是否可空:True)
 objvMicroteachCase_Resource_Rel4AllEN.FileOldName = objRow[convMicroteachCase_Resource_Rel4All.FileOldName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.FileOldName].ToString().Trim(); //旧文件名(字段类型:varchar,字段长度:530,是否可空:True)
 objvMicroteachCase_Resource_Rel4AllEN.IsMain = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCase_Resource_Rel4All.IsMain].ToString().Trim()); //是否主资源(字段类型:bit,字段长度:1,是否可空:True)
 objvMicroteachCase_Resource_Rel4AllEN.IdUsingMode = objRow[convMicroteachCase_Resource_Rel4All.IdUsingMode] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.IdUsingMode].ToString().Trim(); //资源使用模式流水号(字段类型:char,字段长度:4,是否可空:False)
 objvMicroteachCase_Resource_Rel4AllEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCase_Resource_Rel4All.IsVisible].ToString().Trim()); //是否显示(字段类型:bit,字段长度:1,是否可空:True)
 objvMicroteachCase_Resource_Rel4AllEN.IndexNO = objRow[convMicroteachCase_Resource_Rel4All.IndexNO] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachCase_Resource_Rel4All.IndexNO].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:True)
 objvMicroteachCase_Resource_Rel4AllEN.BrowseCount = objRow[convMicroteachCase_Resource_Rel4All.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachCase_Resource_Rel4All.BrowseCount].ToString().Trim()); //浏览次数(字段类型:int,字段长度:4,是否可空:True)
 objvMicroteachCase_Resource_Rel4AllEN.UpdDate = objRow[convMicroteachCase_Resource_Rel4All.UpdDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvMicroteachCase_Resource_Rel4AllEN.UpdUser = objRow[convMicroteachCase_Resource_Rel4All.UpdUser] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objvMicroteachCase_Resource_Rel4AllEN.Memo = objRow[convMicroteachCase_Resource_Rel4All.Memo] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvMicroteachCase_Resource_Rel4AllDA: GetObjByIdMicroteachCaseResourceRel)", objException.Message));
}
return objvMicroteachCase_Resource_Rel4AllEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvMicroteachCase_Resource_Rel4AllEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvMicroteachCase_Resource_Rel4AllDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMicroteachCase_Resource_Rel4AllDA.GetSpecSQLObj();
strSQL = "Select * from vMicroteachCase_Resource_Rel4All where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvMicroteachCase_Resource_Rel4AllEN objvMicroteachCase_Resource_Rel4AllEN = new clsvMicroteachCase_Resource_Rel4AllEN()
{
IdMicroteachCaseResourceRel = TransNullToInt(objRow[convMicroteachCase_Resource_Rel4All.IdMicroteachCaseResourceRel].ToString().Trim()), //微格案例资源关系流水号
IdMicroteachCase = objRow[convMicroteachCase_Resource_Rel4All.IdMicroteachCase].ToString().Trim(), //微格教学案例流水号
MicroteachCaseID = objRow[convMicroteachCase_Resource_Rel4All.MicroteachCaseID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.MicroteachCaseID].ToString().Trim(), //微格教学案例ID
MicroteachCaseName = objRow[convMicroteachCase_Resource_Rel4All.MicroteachCaseName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.MicroteachCaseName].ToString().Trim(), //微格教学案例名称
MicroteachCaseTheme = objRow[convMicroteachCase_Resource_Rel4All.MicroteachCaseTheme] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.MicroteachCaseTheme].ToString().Trim(), //微格教学案例主题词
MicroteachCaseDate = objRow[convMicroteachCase_Resource_Rel4All.MicroteachCaseDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.MicroteachCaseDate].ToString().Trim(), //微格教学日期
MicroteachCaseTime = objRow[convMicroteachCase_Resource_Rel4All.MicroteachCaseTime] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.MicroteachCaseTime].ToString().Trim(), //微格教学时间
MicroteachCaseDateIn = objRow[convMicroteachCase_Resource_Rel4All.MicroteachCaseDateIn] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.MicroteachCaseDateIn].ToString().Trim(), //案例入库日期
IdStudyLevel = objRow[convMicroteachCase_Resource_Rel4All.IdStudyLevel] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.IdStudyLevel].ToString().Trim(), //id_StudyLevel
StudyLevelName = objRow[convMicroteachCase_Resource_Rel4All.StudyLevelName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.StudyLevelName].ToString().Trim(), //学段名称
IdTeachingPlan = objRow[convMicroteachCase_Resource_Rel4All.IdTeachingPlan] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.IdTeachingPlan].ToString().Trim(), //教案流水号
MicroTeachCaseTimeIn = objRow[convMicroteachCase_Resource_Rel4All.MicroTeachCaseTimeIn] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.MicroTeachCaseTimeIn].ToString().Trim(), //案例入库时间
IdCaseType = objRow[convMicroteachCase_Resource_Rel4All.IdCaseType] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.IdCaseType].ToString().Trim(), //案例类型流水号
IdDiscipline = objRow[convMicroteachCase_Resource_Rel4All.IdDiscipline] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.IdDiscipline].ToString().Trim(), //学科流水号
DisciplineID = objRow[convMicroteachCase_Resource_Rel4All.DisciplineID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.DisciplineID].ToString().Trim(), //学科ID
DisciplineName = objRow[convMicroteachCase_Resource_Rel4All.DisciplineName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.DisciplineName].ToString().Trim(), //学科名称
senateGaugeVersionID = objRow[convMicroteachCase_Resource_Rel4All.senateGaugeVersionID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.senateGaugeVersionID].ToString().Trim(), //评价量表版本ID
senateGaugeVersionName = objRow[convMicroteachCase_Resource_Rel4All.senateGaugeVersionName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.senateGaugeVersionName].ToString().Trim(), //评价量表版本名称
senateGaugeVersionTtlScore = objRow[convMicroteachCase_Resource_Rel4All.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convMicroteachCase_Resource_Rel4All.senateGaugeVersionTtlScore].ToString().Trim()), //评价量表版本总分
VersionNo = objRow[convMicroteachCase_Resource_Rel4All.VersionNo] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convMicroteachCase_Resource_Rel4All.VersionNo].ToString().Trim()), //版本号
IdTeachSkill = objRow[convMicroteachCase_Resource_Rel4All.IdTeachSkill] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.IdTeachSkill].ToString().Trim(), //教学技能流水号
TeachSkillID = objRow[convMicroteachCase_Resource_Rel4All.TeachSkillID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.TeachSkillID].ToString().Trim(), //教学技能ID
SkillTypeName = objRow[convMicroteachCase_Resource_Rel4All.SkillTypeName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.SkillTypeName].ToString().Trim(), //技能类型名称
TeachSkillName = objRow[convMicroteachCase_Resource_Rel4All.TeachSkillName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.TeachSkillName].ToString().Trim(), //教学技能名称
TeachSkillTheory = objRow[convMicroteachCase_Resource_Rel4All.TeachSkillTheory] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.TeachSkillTheory].ToString().Trim(), //教学技能理论阐述
TeachSkillOperMethod = objRow[convMicroteachCase_Resource_Rel4All.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.TeachSkillOperMethod].ToString().Trim(), //教学技能实践操作方法
IdSkillType = objRow[convMicroteachCase_Resource_Rel4All.IdSkillType] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.IdSkillType].ToString().Trim(), //技能类型流水号
SkillTypeID = objRow[convMicroteachCase_Resource_Rel4All.SkillTypeID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.SkillTypeID].ToString().Trim(), //技能类型ID
CaseLevelId = objRow[convMicroteachCase_Resource_Rel4All.CaseLevelId] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.CaseLevelId].ToString().Trim(), //课例等级Id
CaseLevelName = objRow[convMicroteachCase_Resource_Rel4All.CaseLevelName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.CaseLevelName].ToString().Trim(), //案例等级名称
microteachCaseText = objRow[convMicroteachCase_Resource_Rel4All.microteachCaseText] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.microteachCaseText].ToString().Trim(), //案例文本内容
OwnerId = objRow[convMicroteachCase_Resource_Rel4All.OwnerId] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.OwnerId].ToString().Trim(), //拥有者Id
OwnerName = objRow[convMicroteachCase_Resource_Rel4All.OwnerName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.OwnerName].ToString().Trim(), //拥有者姓名
CollegeID = objRow[convMicroteachCase_Resource_Rel4All.CollegeID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.CollegeID].ToString().Trim(), //学院ID
CollegeName = objRow[convMicroteachCase_Resource_Rel4All.CollegeName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.CollegeName].ToString().Trim(), //学院名称
OwnerNameWithId = objRow[convMicroteachCase_Resource_Rel4All.OwnerNameWithId] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.OwnerNameWithId].ToString().Trim(), //拥有者名称附Id
IdXzCollege = objRow[convMicroteachCase_Resource_Rel4All.IdXzCollege] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.IdXzCollege].ToString().Trim(), //学院流水号
IsDualVideo = TransNullToBool(objRow[convMicroteachCase_Resource_Rel4All.IsDualVideo].ToString().Trim()), //是否双视频
UserKindId = objRow[convMicroteachCase_Resource_Rel4All.UserKindId] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.UserKindId].ToString().Trim(), //用户类别Id
UserKindName = objRow[convMicroteachCase_Resource_Rel4All.UserKindName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.UserKindName].ToString().Trim(), //用户类别名
UserTypeId = objRow[convMicroteachCase_Resource_Rel4All.UserTypeId] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.UserTypeId].ToString().Trim(), //用户类型Id
UserTypeName = objRow[convMicroteachCase_Resource_Rel4All.UserTypeName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.UserTypeName].ToString().Trim(), //用户类型名称
RecommendedDegreeId = objRow[convMicroteachCase_Resource_Rel4All.RecommendedDegreeId] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.RecommendedDegreeId].ToString().Trim(), //推荐度Id
RecommendedDegreeName = objRow[convMicroteachCase_Resource_Rel4All.RecommendedDegreeName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.RecommendedDegreeName].ToString().Trim(), //推荐度名称
BrowseCount4Case = objRow[convMicroteachCase_Resource_Rel4All.BrowseCount4Case] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convMicroteachCase_Resource_Rel4All.BrowseCount4Case].ToString().Trim()), //课例浏览次数
IdResource = objRow[convMicroteachCase_Resource_Rel4All.IdResource].ToString().Trim(), //资源流水号
ResourceID = objRow[convMicroteachCase_Resource_Rel4All.ResourceID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.ResourceID].ToString().Trim(), //资源ID
ResourceName = objRow[convMicroteachCase_Resource_Rel4All.ResourceName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.ResourceName].ToString().Trim(), //资源名称
IdFtpResource = objRow[convMicroteachCase_Resource_Rel4All.IdFtpResource] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.IdFtpResource].ToString().Trim(), //FTP资源流水号
IdFile = objRow[convMicroteachCase_Resource_Rel4All.IdFile] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.IdFile].ToString().Trim(), //文件流水号
FileName = objRow[convMicroteachCase_Resource_Rel4All.FileName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.FileName].ToString().Trim(), //文件名称
FileType = objRow[convMicroteachCase_Resource_Rel4All.FileType] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.FileType].ToString().Trim(), //文件类型
SaveDate = objRow[convMicroteachCase_Resource_Rel4All.SaveDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.SaveDate].ToString().Trim(), //创建日期
FileSize = objRow[convMicroteachCase_Resource_Rel4All.FileSize] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.FileSize].ToString().Trim(), //文件大小
SaveTime = objRow[convMicroteachCase_Resource_Rel4All.SaveTime] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.SaveTime].ToString().Trim(), //创建时间
FtpResourceID = objRow[convMicroteachCase_Resource_Rel4All.FtpResourceID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.FtpResourceID].ToString().Trim(), //FTP资源ID
FileOriginalName = objRow[convMicroteachCase_Resource_Rel4All.FileOriginalName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.FileOriginalName].ToString().Trim(), //文件原名
FileDirName = objRow[convMicroteachCase_Resource_Rel4All.FileDirName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.FileDirName].ToString().Trim(), //文件目录名
FileRename = objRow[convMicroteachCase_Resource_Rel4All.FileRename] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.FileRename].ToString().Trim(), //文件新名
FileUpDate = objRow[convMicroteachCase_Resource_Rel4All.FileUpDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.FileUpDate].ToString().Trim(), //创建日期
FileUpTime = objRow[convMicroteachCase_Resource_Rel4All.FileUpTime] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.FileUpTime].ToString().Trim(), //创建时间
SaveMode = TransNullToBool(objRow[convMicroteachCase_Resource_Rel4All.SaveMode].ToString().Trim()), //文件存放方式
IdResourceType = objRow[convMicroteachCase_Resource_Rel4All.IdResourceType] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.IdResourceType].ToString().Trim(), //资源类型流水号
ResourceTypeID = objRow[convMicroteachCase_Resource_Rel4All.ResourceTypeID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.ResourceTypeID].ToString().Trim(), //资源类型ID
ResourceTypeName = objRow[convMicroteachCase_Resource_Rel4All.ResourceTypeName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.ResourceTypeName].ToString().Trim(), //资源类型名称
ResourceOwner = objRow[convMicroteachCase_Resource_Rel4All.ResourceOwner] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.ResourceOwner].ToString().Trim(), //上传者
ftpFileType = objRow[convMicroteachCase_Resource_Rel4All.ftpFileType] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.ftpFileType].ToString().Trim(), //ftp文件类型
ftpFileSize = objRow[convMicroteachCase_Resource_Rel4All.ftpFileSize] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.ftpFileSize].ToString().Trim(), //ftp文件大小
ftpResourceOwner = objRow[convMicroteachCase_Resource_Rel4All.ftpResourceOwner] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.ftpResourceOwner].ToString().Trim(), //Ftp资源拥有者
FileOriginName = objRow[convMicroteachCase_Resource_Rel4All.FileOriginName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.FileOriginName].ToString().Trim(), //原文件名
IsExistFile = TransNullToBool(objRow[convMicroteachCase_Resource_Rel4All.IsExistFile].ToString().Trim()), //是否存在文件
FileNewName = objRow[convMicroteachCase_Resource_Rel4All.FileNewName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.FileNewName].ToString().Trim(), //新文件名
FileOldName = objRow[convMicroteachCase_Resource_Rel4All.FileOldName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.FileOldName].ToString().Trim(), //旧文件名
IsMain = TransNullToBool(objRow[convMicroteachCase_Resource_Rel4All.IsMain].ToString().Trim()), //是否主资源
IdUsingMode = objRow[convMicroteachCase_Resource_Rel4All.IdUsingMode] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.IdUsingMode].ToString().Trim(), //资源使用模式流水号
IsVisible = TransNullToBool(objRow[convMicroteachCase_Resource_Rel4All.IsVisible].ToString().Trim()), //是否显示
IndexNO = objRow[convMicroteachCase_Resource_Rel4All.IndexNO] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convMicroteachCase_Resource_Rel4All.IndexNO].ToString().Trim()), //序号
BrowseCount = objRow[convMicroteachCase_Resource_Rel4All.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convMicroteachCase_Resource_Rel4All.BrowseCount].ToString().Trim()), //浏览次数
UpdDate = objRow[convMicroteachCase_Resource_Rel4All.UpdDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[convMicroteachCase_Resource_Rel4All.UpdUser] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.UpdUser].ToString().Trim(), //修改人
Memo = objRow[convMicroteachCase_Resource_Rel4All.Memo] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.Memo].ToString().Trim() //备注
};
objvMicroteachCase_Resource_Rel4AllEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvMicroteachCase_Resource_Rel4AllEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvMicroteachCase_Resource_Rel4AllDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvMicroteachCase_Resource_Rel4AllEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvMicroteachCase_Resource_Rel4AllEN objvMicroteachCase_Resource_Rel4AllEN = new clsvMicroteachCase_Resource_Rel4AllEN();
try
{
objvMicroteachCase_Resource_Rel4AllEN.IdMicroteachCaseResourceRel = TransNullToInt(objRow[convMicroteachCase_Resource_Rel4All.IdMicroteachCaseResourceRel].ToString().Trim()); //微格案例资源关系流水号
objvMicroteachCase_Resource_Rel4AllEN.IdMicroteachCase = objRow[convMicroteachCase_Resource_Rel4All.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvMicroteachCase_Resource_Rel4AllEN.MicroteachCaseID = objRow[convMicroteachCase_Resource_Rel4All.MicroteachCaseID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.MicroteachCaseID].ToString().Trim(); //微格教学案例ID
objvMicroteachCase_Resource_Rel4AllEN.MicroteachCaseName = objRow[convMicroteachCase_Resource_Rel4All.MicroteachCaseName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.MicroteachCaseName].ToString().Trim(); //微格教学案例名称
objvMicroteachCase_Resource_Rel4AllEN.MicroteachCaseTheme = objRow[convMicroteachCase_Resource_Rel4All.MicroteachCaseTheme] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.MicroteachCaseTheme].ToString().Trim(); //微格教学案例主题词
objvMicroteachCase_Resource_Rel4AllEN.MicroteachCaseDate = objRow[convMicroteachCase_Resource_Rel4All.MicroteachCaseDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.MicroteachCaseDate].ToString().Trim(); //微格教学日期
objvMicroteachCase_Resource_Rel4AllEN.MicroteachCaseTime = objRow[convMicroteachCase_Resource_Rel4All.MicroteachCaseTime] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.MicroteachCaseTime].ToString().Trim(); //微格教学时间
objvMicroteachCase_Resource_Rel4AllEN.MicroteachCaseDateIn = objRow[convMicroteachCase_Resource_Rel4All.MicroteachCaseDateIn] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.MicroteachCaseDateIn].ToString().Trim(); //案例入库日期
objvMicroteachCase_Resource_Rel4AllEN.IdStudyLevel = objRow[convMicroteachCase_Resource_Rel4All.IdStudyLevel] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvMicroteachCase_Resource_Rel4AllEN.StudyLevelName = objRow[convMicroteachCase_Resource_Rel4All.StudyLevelName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.StudyLevelName].ToString().Trim(); //学段名称
objvMicroteachCase_Resource_Rel4AllEN.IdTeachingPlan = objRow[convMicroteachCase_Resource_Rel4All.IdTeachingPlan] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.IdTeachingPlan].ToString().Trim(); //教案流水号
objvMicroteachCase_Resource_Rel4AllEN.MicroTeachCaseTimeIn = objRow[convMicroteachCase_Resource_Rel4All.MicroTeachCaseTimeIn] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.MicroTeachCaseTimeIn].ToString().Trim(); //案例入库时间
objvMicroteachCase_Resource_Rel4AllEN.IdCaseType = objRow[convMicroteachCase_Resource_Rel4All.IdCaseType] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.IdCaseType].ToString().Trim(); //案例类型流水号
objvMicroteachCase_Resource_Rel4AllEN.IdDiscipline = objRow[convMicroteachCase_Resource_Rel4All.IdDiscipline] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.IdDiscipline].ToString().Trim(); //学科流水号
objvMicroteachCase_Resource_Rel4AllEN.DisciplineID = objRow[convMicroteachCase_Resource_Rel4All.DisciplineID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.DisciplineID].ToString().Trim(); //学科ID
objvMicroteachCase_Resource_Rel4AllEN.DisciplineName = objRow[convMicroteachCase_Resource_Rel4All.DisciplineName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.DisciplineName].ToString().Trim(); //学科名称
objvMicroteachCase_Resource_Rel4AllEN.senateGaugeVersionID = objRow[convMicroteachCase_Resource_Rel4All.senateGaugeVersionID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvMicroteachCase_Resource_Rel4AllEN.senateGaugeVersionName = objRow[convMicroteachCase_Resource_Rel4All.senateGaugeVersionName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvMicroteachCase_Resource_Rel4AllEN.senateGaugeVersionTtlScore = objRow[convMicroteachCase_Resource_Rel4All.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convMicroteachCase_Resource_Rel4All.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvMicroteachCase_Resource_Rel4AllEN.VersionNo = objRow[convMicroteachCase_Resource_Rel4All.VersionNo] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convMicroteachCase_Resource_Rel4All.VersionNo].ToString().Trim()); //版本号
objvMicroteachCase_Resource_Rel4AllEN.IdTeachSkill = objRow[convMicroteachCase_Resource_Rel4All.IdTeachSkill] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvMicroteachCase_Resource_Rel4AllEN.TeachSkillID = objRow[convMicroteachCase_Resource_Rel4All.TeachSkillID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.TeachSkillID].ToString().Trim(); //教学技能ID
objvMicroteachCase_Resource_Rel4AllEN.SkillTypeName = objRow[convMicroteachCase_Resource_Rel4All.SkillTypeName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.SkillTypeName].ToString().Trim(); //技能类型名称
objvMicroteachCase_Resource_Rel4AllEN.TeachSkillName = objRow[convMicroteachCase_Resource_Rel4All.TeachSkillName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.TeachSkillName].ToString().Trim(); //教学技能名称
objvMicroteachCase_Resource_Rel4AllEN.TeachSkillTheory = objRow[convMicroteachCase_Resource_Rel4All.TeachSkillTheory] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvMicroteachCase_Resource_Rel4AllEN.TeachSkillOperMethod = objRow[convMicroteachCase_Resource_Rel4All.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvMicroteachCase_Resource_Rel4AllEN.IdSkillType = objRow[convMicroteachCase_Resource_Rel4All.IdSkillType] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.IdSkillType].ToString().Trim(); //技能类型流水号
objvMicroteachCase_Resource_Rel4AllEN.SkillTypeID = objRow[convMicroteachCase_Resource_Rel4All.SkillTypeID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.SkillTypeID].ToString().Trim(); //技能类型ID
objvMicroteachCase_Resource_Rel4AllEN.CaseLevelId = objRow[convMicroteachCase_Resource_Rel4All.CaseLevelId] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.CaseLevelId].ToString().Trim(); //课例等级Id
objvMicroteachCase_Resource_Rel4AllEN.CaseLevelName = objRow[convMicroteachCase_Resource_Rel4All.CaseLevelName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.CaseLevelName].ToString().Trim(); //案例等级名称
objvMicroteachCase_Resource_Rel4AllEN.microteachCaseText = objRow[convMicroteachCase_Resource_Rel4All.microteachCaseText] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.microteachCaseText].ToString().Trim(); //案例文本内容
objvMicroteachCase_Resource_Rel4AllEN.OwnerId = objRow[convMicroteachCase_Resource_Rel4All.OwnerId] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.OwnerId].ToString().Trim(); //拥有者Id
objvMicroteachCase_Resource_Rel4AllEN.OwnerName = objRow[convMicroteachCase_Resource_Rel4All.OwnerName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.OwnerName].ToString().Trim(); //拥有者姓名
objvMicroteachCase_Resource_Rel4AllEN.CollegeID = objRow[convMicroteachCase_Resource_Rel4All.CollegeID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.CollegeID].ToString().Trim(); //学院ID
objvMicroteachCase_Resource_Rel4AllEN.CollegeName = objRow[convMicroteachCase_Resource_Rel4All.CollegeName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.CollegeName].ToString().Trim(); //学院名称
objvMicroteachCase_Resource_Rel4AllEN.OwnerNameWithId = objRow[convMicroteachCase_Resource_Rel4All.OwnerNameWithId] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvMicroteachCase_Resource_Rel4AllEN.IdXzCollege = objRow[convMicroteachCase_Resource_Rel4All.IdXzCollege] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.IdXzCollege].ToString().Trim(); //学院流水号
objvMicroteachCase_Resource_Rel4AllEN.IsDualVideo = TransNullToBool(objRow[convMicroteachCase_Resource_Rel4All.IsDualVideo].ToString().Trim()); //是否双视频
objvMicroteachCase_Resource_Rel4AllEN.UserKindId = objRow[convMicroteachCase_Resource_Rel4All.UserKindId] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.UserKindId].ToString().Trim(); //用户类别Id
objvMicroteachCase_Resource_Rel4AllEN.UserKindName = objRow[convMicroteachCase_Resource_Rel4All.UserKindName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.UserKindName].ToString().Trim(); //用户类别名
objvMicroteachCase_Resource_Rel4AllEN.UserTypeId = objRow[convMicroteachCase_Resource_Rel4All.UserTypeId] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.UserTypeId].ToString().Trim(); //用户类型Id
objvMicroteachCase_Resource_Rel4AllEN.UserTypeName = objRow[convMicroteachCase_Resource_Rel4All.UserTypeName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.UserTypeName].ToString().Trim(); //用户类型名称
objvMicroteachCase_Resource_Rel4AllEN.RecommendedDegreeId = objRow[convMicroteachCase_Resource_Rel4All.RecommendedDegreeId] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvMicroteachCase_Resource_Rel4AllEN.RecommendedDegreeName = objRow[convMicroteachCase_Resource_Rel4All.RecommendedDegreeName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvMicroteachCase_Resource_Rel4AllEN.BrowseCount4Case = objRow[convMicroteachCase_Resource_Rel4All.BrowseCount4Case] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convMicroteachCase_Resource_Rel4All.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvMicroteachCase_Resource_Rel4AllEN.IdResource = objRow[convMicroteachCase_Resource_Rel4All.IdResource].ToString().Trim(); //资源流水号
objvMicroteachCase_Resource_Rel4AllEN.ResourceID = objRow[convMicroteachCase_Resource_Rel4All.ResourceID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.ResourceID].ToString().Trim(); //资源ID
objvMicroteachCase_Resource_Rel4AllEN.ResourceName = objRow[convMicroteachCase_Resource_Rel4All.ResourceName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.ResourceName].ToString().Trim(); //资源名称
objvMicroteachCase_Resource_Rel4AllEN.IdFtpResource = objRow[convMicroteachCase_Resource_Rel4All.IdFtpResource] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvMicroteachCase_Resource_Rel4AllEN.IdFile = objRow[convMicroteachCase_Resource_Rel4All.IdFile] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.IdFile].ToString().Trim(); //文件流水号
objvMicroteachCase_Resource_Rel4AllEN.FileName = objRow[convMicroteachCase_Resource_Rel4All.FileName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.FileName].ToString().Trim(); //文件名称
objvMicroteachCase_Resource_Rel4AllEN.FileType = objRow[convMicroteachCase_Resource_Rel4All.FileType] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.FileType].ToString().Trim(); //文件类型
objvMicroteachCase_Resource_Rel4AllEN.SaveDate = objRow[convMicroteachCase_Resource_Rel4All.SaveDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.SaveDate].ToString().Trim(); //创建日期
objvMicroteachCase_Resource_Rel4AllEN.FileSize = objRow[convMicroteachCase_Resource_Rel4All.FileSize] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.FileSize].ToString().Trim(); //文件大小
objvMicroteachCase_Resource_Rel4AllEN.SaveTime = objRow[convMicroteachCase_Resource_Rel4All.SaveTime] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.SaveTime].ToString().Trim(); //创建时间
objvMicroteachCase_Resource_Rel4AllEN.FtpResourceID = objRow[convMicroteachCase_Resource_Rel4All.FtpResourceID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.FtpResourceID].ToString().Trim(); //FTP资源ID
objvMicroteachCase_Resource_Rel4AllEN.FileOriginalName = objRow[convMicroteachCase_Resource_Rel4All.FileOriginalName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.FileOriginalName].ToString().Trim(); //文件原名
objvMicroteachCase_Resource_Rel4AllEN.FileDirName = objRow[convMicroteachCase_Resource_Rel4All.FileDirName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.FileDirName].ToString().Trim(); //文件目录名
objvMicroteachCase_Resource_Rel4AllEN.FileRename = objRow[convMicroteachCase_Resource_Rel4All.FileRename] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.FileRename].ToString().Trim(); //文件新名
objvMicroteachCase_Resource_Rel4AllEN.FileUpDate = objRow[convMicroteachCase_Resource_Rel4All.FileUpDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.FileUpDate].ToString().Trim(); //创建日期
objvMicroteachCase_Resource_Rel4AllEN.FileUpTime = objRow[convMicroteachCase_Resource_Rel4All.FileUpTime] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.FileUpTime].ToString().Trim(); //创建时间
objvMicroteachCase_Resource_Rel4AllEN.SaveMode = TransNullToBool(objRow[convMicroteachCase_Resource_Rel4All.SaveMode].ToString().Trim()); //文件存放方式
objvMicroteachCase_Resource_Rel4AllEN.IdResourceType = objRow[convMicroteachCase_Resource_Rel4All.IdResourceType] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.IdResourceType].ToString().Trim(); //资源类型流水号
objvMicroteachCase_Resource_Rel4AllEN.ResourceTypeID = objRow[convMicroteachCase_Resource_Rel4All.ResourceTypeID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.ResourceTypeID].ToString().Trim(); //资源类型ID
objvMicroteachCase_Resource_Rel4AllEN.ResourceTypeName = objRow[convMicroteachCase_Resource_Rel4All.ResourceTypeName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.ResourceTypeName].ToString().Trim(); //资源类型名称
objvMicroteachCase_Resource_Rel4AllEN.ResourceOwner = objRow[convMicroteachCase_Resource_Rel4All.ResourceOwner] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.ResourceOwner].ToString().Trim(); //上传者
objvMicroteachCase_Resource_Rel4AllEN.ftpFileType = objRow[convMicroteachCase_Resource_Rel4All.ftpFileType] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.ftpFileType].ToString().Trim(); //ftp文件类型
objvMicroteachCase_Resource_Rel4AllEN.ftpFileSize = objRow[convMicroteachCase_Resource_Rel4All.ftpFileSize] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.ftpFileSize].ToString().Trim(); //ftp文件大小
objvMicroteachCase_Resource_Rel4AllEN.ftpResourceOwner = objRow[convMicroteachCase_Resource_Rel4All.ftpResourceOwner] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvMicroteachCase_Resource_Rel4AllEN.FileOriginName = objRow[convMicroteachCase_Resource_Rel4All.FileOriginName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.FileOriginName].ToString().Trim(); //原文件名
objvMicroteachCase_Resource_Rel4AllEN.IsExistFile = TransNullToBool(objRow[convMicroteachCase_Resource_Rel4All.IsExistFile].ToString().Trim()); //是否存在文件
objvMicroteachCase_Resource_Rel4AllEN.FileNewName = objRow[convMicroteachCase_Resource_Rel4All.FileNewName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.FileNewName].ToString().Trim(); //新文件名
objvMicroteachCase_Resource_Rel4AllEN.FileOldName = objRow[convMicroteachCase_Resource_Rel4All.FileOldName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.FileOldName].ToString().Trim(); //旧文件名
objvMicroteachCase_Resource_Rel4AllEN.IsMain = TransNullToBool(objRow[convMicroteachCase_Resource_Rel4All.IsMain].ToString().Trim()); //是否主资源
objvMicroteachCase_Resource_Rel4AllEN.IdUsingMode = objRow[convMicroteachCase_Resource_Rel4All.IdUsingMode] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.IdUsingMode].ToString().Trim(); //资源使用模式流水号
objvMicroteachCase_Resource_Rel4AllEN.IsVisible = TransNullToBool(objRow[convMicroteachCase_Resource_Rel4All.IsVisible].ToString().Trim()); //是否显示
objvMicroteachCase_Resource_Rel4AllEN.IndexNO = objRow[convMicroteachCase_Resource_Rel4All.IndexNO] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convMicroteachCase_Resource_Rel4All.IndexNO].ToString().Trim()); //序号
objvMicroteachCase_Resource_Rel4AllEN.BrowseCount = objRow[convMicroteachCase_Resource_Rel4All.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convMicroteachCase_Resource_Rel4All.BrowseCount].ToString().Trim()); //浏览次数
objvMicroteachCase_Resource_Rel4AllEN.UpdDate = objRow[convMicroteachCase_Resource_Rel4All.UpdDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.UpdDate].ToString().Trim(); //修改日期
objvMicroteachCase_Resource_Rel4AllEN.UpdUser = objRow[convMicroteachCase_Resource_Rel4All.UpdUser] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.UpdUser].ToString().Trim(); //修改人
objvMicroteachCase_Resource_Rel4AllEN.Memo = objRow[convMicroteachCase_Resource_Rel4All.Memo] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvMicroteachCase_Resource_Rel4AllDA: GetObjByDataRowvMicroteachCase_Resource_Rel4All)", objException.Message));
}
objvMicroteachCase_Resource_Rel4AllEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvMicroteachCase_Resource_Rel4AllEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvMicroteachCase_Resource_Rel4AllEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvMicroteachCase_Resource_Rel4AllEN objvMicroteachCase_Resource_Rel4AllEN = new clsvMicroteachCase_Resource_Rel4AllEN();
try
{
objvMicroteachCase_Resource_Rel4AllEN.IdMicroteachCaseResourceRel = TransNullToInt(objRow[convMicroteachCase_Resource_Rel4All.IdMicroteachCaseResourceRel].ToString().Trim()); //微格案例资源关系流水号
objvMicroteachCase_Resource_Rel4AllEN.IdMicroteachCase = objRow[convMicroteachCase_Resource_Rel4All.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvMicroteachCase_Resource_Rel4AllEN.MicroteachCaseID = objRow[convMicroteachCase_Resource_Rel4All.MicroteachCaseID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.MicroteachCaseID].ToString().Trim(); //微格教学案例ID
objvMicroteachCase_Resource_Rel4AllEN.MicroteachCaseName = objRow[convMicroteachCase_Resource_Rel4All.MicroteachCaseName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.MicroteachCaseName].ToString().Trim(); //微格教学案例名称
objvMicroteachCase_Resource_Rel4AllEN.MicroteachCaseTheme = objRow[convMicroteachCase_Resource_Rel4All.MicroteachCaseTheme] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.MicroteachCaseTheme].ToString().Trim(); //微格教学案例主题词
objvMicroteachCase_Resource_Rel4AllEN.MicroteachCaseDate = objRow[convMicroteachCase_Resource_Rel4All.MicroteachCaseDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.MicroteachCaseDate].ToString().Trim(); //微格教学日期
objvMicroteachCase_Resource_Rel4AllEN.MicroteachCaseTime = objRow[convMicroteachCase_Resource_Rel4All.MicroteachCaseTime] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.MicroteachCaseTime].ToString().Trim(); //微格教学时间
objvMicroteachCase_Resource_Rel4AllEN.MicroteachCaseDateIn = objRow[convMicroteachCase_Resource_Rel4All.MicroteachCaseDateIn] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.MicroteachCaseDateIn].ToString().Trim(); //案例入库日期
objvMicroteachCase_Resource_Rel4AllEN.IdStudyLevel = objRow[convMicroteachCase_Resource_Rel4All.IdStudyLevel] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvMicroteachCase_Resource_Rel4AllEN.StudyLevelName = objRow[convMicroteachCase_Resource_Rel4All.StudyLevelName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.StudyLevelName].ToString().Trim(); //学段名称
objvMicroteachCase_Resource_Rel4AllEN.IdTeachingPlan = objRow[convMicroteachCase_Resource_Rel4All.IdTeachingPlan] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.IdTeachingPlan].ToString().Trim(); //教案流水号
objvMicroteachCase_Resource_Rel4AllEN.MicroTeachCaseTimeIn = objRow[convMicroteachCase_Resource_Rel4All.MicroTeachCaseTimeIn] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.MicroTeachCaseTimeIn].ToString().Trim(); //案例入库时间
objvMicroteachCase_Resource_Rel4AllEN.IdCaseType = objRow[convMicroteachCase_Resource_Rel4All.IdCaseType] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.IdCaseType].ToString().Trim(); //案例类型流水号
objvMicroteachCase_Resource_Rel4AllEN.IdDiscipline = objRow[convMicroteachCase_Resource_Rel4All.IdDiscipline] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.IdDiscipline].ToString().Trim(); //学科流水号
objvMicroteachCase_Resource_Rel4AllEN.DisciplineID = objRow[convMicroteachCase_Resource_Rel4All.DisciplineID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.DisciplineID].ToString().Trim(); //学科ID
objvMicroteachCase_Resource_Rel4AllEN.DisciplineName = objRow[convMicroteachCase_Resource_Rel4All.DisciplineName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.DisciplineName].ToString().Trim(); //学科名称
objvMicroteachCase_Resource_Rel4AllEN.senateGaugeVersionID = objRow[convMicroteachCase_Resource_Rel4All.senateGaugeVersionID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvMicroteachCase_Resource_Rel4AllEN.senateGaugeVersionName = objRow[convMicroteachCase_Resource_Rel4All.senateGaugeVersionName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvMicroteachCase_Resource_Rel4AllEN.senateGaugeVersionTtlScore = objRow[convMicroteachCase_Resource_Rel4All.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convMicroteachCase_Resource_Rel4All.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvMicroteachCase_Resource_Rel4AllEN.VersionNo = objRow[convMicroteachCase_Resource_Rel4All.VersionNo] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convMicroteachCase_Resource_Rel4All.VersionNo].ToString().Trim()); //版本号
objvMicroteachCase_Resource_Rel4AllEN.IdTeachSkill = objRow[convMicroteachCase_Resource_Rel4All.IdTeachSkill] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvMicroteachCase_Resource_Rel4AllEN.TeachSkillID = objRow[convMicroteachCase_Resource_Rel4All.TeachSkillID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.TeachSkillID].ToString().Trim(); //教学技能ID
objvMicroteachCase_Resource_Rel4AllEN.SkillTypeName = objRow[convMicroteachCase_Resource_Rel4All.SkillTypeName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.SkillTypeName].ToString().Trim(); //技能类型名称
objvMicroteachCase_Resource_Rel4AllEN.TeachSkillName = objRow[convMicroteachCase_Resource_Rel4All.TeachSkillName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.TeachSkillName].ToString().Trim(); //教学技能名称
objvMicroteachCase_Resource_Rel4AllEN.TeachSkillTheory = objRow[convMicroteachCase_Resource_Rel4All.TeachSkillTheory] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvMicroteachCase_Resource_Rel4AllEN.TeachSkillOperMethod = objRow[convMicroteachCase_Resource_Rel4All.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvMicroteachCase_Resource_Rel4AllEN.IdSkillType = objRow[convMicroteachCase_Resource_Rel4All.IdSkillType] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.IdSkillType].ToString().Trim(); //技能类型流水号
objvMicroteachCase_Resource_Rel4AllEN.SkillTypeID = objRow[convMicroteachCase_Resource_Rel4All.SkillTypeID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.SkillTypeID].ToString().Trim(); //技能类型ID
objvMicroteachCase_Resource_Rel4AllEN.CaseLevelId = objRow[convMicroteachCase_Resource_Rel4All.CaseLevelId] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.CaseLevelId].ToString().Trim(); //课例等级Id
objvMicroteachCase_Resource_Rel4AllEN.CaseLevelName = objRow[convMicroteachCase_Resource_Rel4All.CaseLevelName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.CaseLevelName].ToString().Trim(); //案例等级名称
objvMicroteachCase_Resource_Rel4AllEN.microteachCaseText = objRow[convMicroteachCase_Resource_Rel4All.microteachCaseText] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.microteachCaseText].ToString().Trim(); //案例文本内容
objvMicroteachCase_Resource_Rel4AllEN.OwnerId = objRow[convMicroteachCase_Resource_Rel4All.OwnerId] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.OwnerId].ToString().Trim(); //拥有者Id
objvMicroteachCase_Resource_Rel4AllEN.OwnerName = objRow[convMicroteachCase_Resource_Rel4All.OwnerName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.OwnerName].ToString().Trim(); //拥有者姓名
objvMicroteachCase_Resource_Rel4AllEN.CollegeID = objRow[convMicroteachCase_Resource_Rel4All.CollegeID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.CollegeID].ToString().Trim(); //学院ID
objvMicroteachCase_Resource_Rel4AllEN.CollegeName = objRow[convMicroteachCase_Resource_Rel4All.CollegeName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.CollegeName].ToString().Trim(); //学院名称
objvMicroteachCase_Resource_Rel4AllEN.OwnerNameWithId = objRow[convMicroteachCase_Resource_Rel4All.OwnerNameWithId] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvMicroteachCase_Resource_Rel4AllEN.IdXzCollege = objRow[convMicroteachCase_Resource_Rel4All.IdXzCollege] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.IdXzCollege].ToString().Trim(); //学院流水号
objvMicroteachCase_Resource_Rel4AllEN.IsDualVideo = TransNullToBool(objRow[convMicroteachCase_Resource_Rel4All.IsDualVideo].ToString().Trim()); //是否双视频
objvMicroteachCase_Resource_Rel4AllEN.UserKindId = objRow[convMicroteachCase_Resource_Rel4All.UserKindId] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.UserKindId].ToString().Trim(); //用户类别Id
objvMicroteachCase_Resource_Rel4AllEN.UserKindName = objRow[convMicroteachCase_Resource_Rel4All.UserKindName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.UserKindName].ToString().Trim(); //用户类别名
objvMicroteachCase_Resource_Rel4AllEN.UserTypeId = objRow[convMicroteachCase_Resource_Rel4All.UserTypeId] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.UserTypeId].ToString().Trim(); //用户类型Id
objvMicroteachCase_Resource_Rel4AllEN.UserTypeName = objRow[convMicroteachCase_Resource_Rel4All.UserTypeName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.UserTypeName].ToString().Trim(); //用户类型名称
objvMicroteachCase_Resource_Rel4AllEN.RecommendedDegreeId = objRow[convMicroteachCase_Resource_Rel4All.RecommendedDegreeId] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvMicroteachCase_Resource_Rel4AllEN.RecommendedDegreeName = objRow[convMicroteachCase_Resource_Rel4All.RecommendedDegreeName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvMicroteachCase_Resource_Rel4AllEN.BrowseCount4Case = objRow[convMicroteachCase_Resource_Rel4All.BrowseCount4Case] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convMicroteachCase_Resource_Rel4All.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvMicroteachCase_Resource_Rel4AllEN.IdResource = objRow[convMicroteachCase_Resource_Rel4All.IdResource].ToString().Trim(); //资源流水号
objvMicroteachCase_Resource_Rel4AllEN.ResourceID = objRow[convMicroteachCase_Resource_Rel4All.ResourceID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.ResourceID].ToString().Trim(); //资源ID
objvMicroteachCase_Resource_Rel4AllEN.ResourceName = objRow[convMicroteachCase_Resource_Rel4All.ResourceName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.ResourceName].ToString().Trim(); //资源名称
objvMicroteachCase_Resource_Rel4AllEN.IdFtpResource = objRow[convMicroteachCase_Resource_Rel4All.IdFtpResource] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvMicroteachCase_Resource_Rel4AllEN.IdFile = objRow[convMicroteachCase_Resource_Rel4All.IdFile] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.IdFile].ToString().Trim(); //文件流水号
objvMicroteachCase_Resource_Rel4AllEN.FileName = objRow[convMicroteachCase_Resource_Rel4All.FileName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.FileName].ToString().Trim(); //文件名称
objvMicroteachCase_Resource_Rel4AllEN.FileType = objRow[convMicroteachCase_Resource_Rel4All.FileType] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.FileType].ToString().Trim(); //文件类型
objvMicroteachCase_Resource_Rel4AllEN.SaveDate = objRow[convMicroteachCase_Resource_Rel4All.SaveDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.SaveDate].ToString().Trim(); //创建日期
objvMicroteachCase_Resource_Rel4AllEN.FileSize = objRow[convMicroteachCase_Resource_Rel4All.FileSize] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.FileSize].ToString().Trim(); //文件大小
objvMicroteachCase_Resource_Rel4AllEN.SaveTime = objRow[convMicroteachCase_Resource_Rel4All.SaveTime] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.SaveTime].ToString().Trim(); //创建时间
objvMicroteachCase_Resource_Rel4AllEN.FtpResourceID = objRow[convMicroteachCase_Resource_Rel4All.FtpResourceID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.FtpResourceID].ToString().Trim(); //FTP资源ID
objvMicroteachCase_Resource_Rel4AllEN.FileOriginalName = objRow[convMicroteachCase_Resource_Rel4All.FileOriginalName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.FileOriginalName].ToString().Trim(); //文件原名
objvMicroteachCase_Resource_Rel4AllEN.FileDirName = objRow[convMicroteachCase_Resource_Rel4All.FileDirName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.FileDirName].ToString().Trim(); //文件目录名
objvMicroteachCase_Resource_Rel4AllEN.FileRename = objRow[convMicroteachCase_Resource_Rel4All.FileRename] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.FileRename].ToString().Trim(); //文件新名
objvMicroteachCase_Resource_Rel4AllEN.FileUpDate = objRow[convMicroteachCase_Resource_Rel4All.FileUpDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.FileUpDate].ToString().Trim(); //创建日期
objvMicroteachCase_Resource_Rel4AllEN.FileUpTime = objRow[convMicroteachCase_Resource_Rel4All.FileUpTime] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.FileUpTime].ToString().Trim(); //创建时间
objvMicroteachCase_Resource_Rel4AllEN.SaveMode = TransNullToBool(objRow[convMicroteachCase_Resource_Rel4All.SaveMode].ToString().Trim()); //文件存放方式
objvMicroteachCase_Resource_Rel4AllEN.IdResourceType = objRow[convMicroteachCase_Resource_Rel4All.IdResourceType] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.IdResourceType].ToString().Trim(); //资源类型流水号
objvMicroteachCase_Resource_Rel4AllEN.ResourceTypeID = objRow[convMicroteachCase_Resource_Rel4All.ResourceTypeID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.ResourceTypeID].ToString().Trim(); //资源类型ID
objvMicroteachCase_Resource_Rel4AllEN.ResourceTypeName = objRow[convMicroteachCase_Resource_Rel4All.ResourceTypeName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.ResourceTypeName].ToString().Trim(); //资源类型名称
objvMicroteachCase_Resource_Rel4AllEN.ResourceOwner = objRow[convMicroteachCase_Resource_Rel4All.ResourceOwner] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.ResourceOwner].ToString().Trim(); //上传者
objvMicroteachCase_Resource_Rel4AllEN.ftpFileType = objRow[convMicroteachCase_Resource_Rel4All.ftpFileType] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.ftpFileType].ToString().Trim(); //ftp文件类型
objvMicroteachCase_Resource_Rel4AllEN.ftpFileSize = objRow[convMicroteachCase_Resource_Rel4All.ftpFileSize] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.ftpFileSize].ToString().Trim(); //ftp文件大小
objvMicroteachCase_Resource_Rel4AllEN.ftpResourceOwner = objRow[convMicroteachCase_Resource_Rel4All.ftpResourceOwner] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvMicroteachCase_Resource_Rel4AllEN.FileOriginName = objRow[convMicroteachCase_Resource_Rel4All.FileOriginName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.FileOriginName].ToString().Trim(); //原文件名
objvMicroteachCase_Resource_Rel4AllEN.IsExistFile = TransNullToBool(objRow[convMicroteachCase_Resource_Rel4All.IsExistFile].ToString().Trim()); //是否存在文件
objvMicroteachCase_Resource_Rel4AllEN.FileNewName = objRow[convMicroteachCase_Resource_Rel4All.FileNewName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.FileNewName].ToString().Trim(); //新文件名
objvMicroteachCase_Resource_Rel4AllEN.FileOldName = objRow[convMicroteachCase_Resource_Rel4All.FileOldName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.FileOldName].ToString().Trim(); //旧文件名
objvMicroteachCase_Resource_Rel4AllEN.IsMain = TransNullToBool(objRow[convMicroteachCase_Resource_Rel4All.IsMain].ToString().Trim()); //是否主资源
objvMicroteachCase_Resource_Rel4AllEN.IdUsingMode = objRow[convMicroteachCase_Resource_Rel4All.IdUsingMode] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.IdUsingMode].ToString().Trim(); //资源使用模式流水号
objvMicroteachCase_Resource_Rel4AllEN.IsVisible = TransNullToBool(objRow[convMicroteachCase_Resource_Rel4All.IsVisible].ToString().Trim()); //是否显示
objvMicroteachCase_Resource_Rel4AllEN.IndexNO = objRow[convMicroteachCase_Resource_Rel4All.IndexNO] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convMicroteachCase_Resource_Rel4All.IndexNO].ToString().Trim()); //序号
objvMicroteachCase_Resource_Rel4AllEN.BrowseCount = objRow[convMicroteachCase_Resource_Rel4All.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convMicroteachCase_Resource_Rel4All.BrowseCount].ToString().Trim()); //浏览次数
objvMicroteachCase_Resource_Rel4AllEN.UpdDate = objRow[convMicroteachCase_Resource_Rel4All.UpdDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.UpdDate].ToString().Trim(); //修改日期
objvMicroteachCase_Resource_Rel4AllEN.UpdUser = objRow[convMicroteachCase_Resource_Rel4All.UpdUser] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.UpdUser].ToString().Trim(); //修改人
objvMicroteachCase_Resource_Rel4AllEN.Memo = objRow[convMicroteachCase_Resource_Rel4All.Memo] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4All.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvMicroteachCase_Resource_Rel4AllDA: GetObjByDataRow)", objException.Message));
}
objvMicroteachCase_Resource_Rel4AllEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvMicroteachCase_Resource_Rel4AllEN;
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
objSQL = clsvMicroteachCase_Resource_Rel4AllDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvMicroteachCase_Resource_Rel4AllEN._CurrTabName, convMicroteachCase_Resource_Rel4All.IdMicroteachCaseResourceRel, 8, "");
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
objSQL = clsvMicroteachCase_Resource_Rel4AllDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvMicroteachCase_Resource_Rel4AllEN._CurrTabName, convMicroteachCase_Resource_Rel4All.IdMicroteachCaseResourceRel, 8, strPrefix);
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
 objSQL = clsvMicroteachCase_Resource_Rel4AllDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select IdMicroteachCaseResourceRel from vMicroteachCase_Resource_Rel4All where " + strCondition;
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
 objSQL = clsvMicroteachCase_Resource_Rel4AllDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select IdMicroteachCaseResourceRel from vMicroteachCase_Resource_Rel4All where " + strCondition;
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
 /// <param name = "lngIdMicroteachCaseResourceRel">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(long lngIdMicroteachCaseResourceRel)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMicroteachCase_Resource_Rel4AllDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vMicroteachCase_Resource_Rel4All", "IdMicroteachCaseResourceRel = " + ""+ lngIdMicroteachCaseResourceRel+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvMicroteachCase_Resource_Rel4AllDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMicroteachCase_Resource_Rel4AllDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vMicroteachCase_Resource_Rel4All", strCondition))
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
objSQL = clsvMicroteachCase_Resource_Rel4AllDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vMicroteachCase_Resource_Rel4All");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4AllENS">源对象</param>
 /// <param name = "objvMicroteachCase_Resource_Rel4AllENT">目标对象</param>
public void CopyTo(clsvMicroteachCase_Resource_Rel4AllEN objvMicroteachCase_Resource_Rel4AllENS, clsvMicroteachCase_Resource_Rel4AllEN objvMicroteachCase_Resource_Rel4AllENT)
{
objvMicroteachCase_Resource_Rel4AllENT.IdMicroteachCaseResourceRel = objvMicroteachCase_Resource_Rel4AllENS.IdMicroteachCaseResourceRel; //微格案例资源关系流水号
objvMicroteachCase_Resource_Rel4AllENT.IdMicroteachCase = objvMicroteachCase_Resource_Rel4AllENS.IdMicroteachCase; //微格教学案例流水号
objvMicroteachCase_Resource_Rel4AllENT.MicroteachCaseID = objvMicroteachCase_Resource_Rel4AllENS.MicroteachCaseID; //微格教学案例ID
objvMicroteachCase_Resource_Rel4AllENT.MicroteachCaseName = objvMicroteachCase_Resource_Rel4AllENS.MicroteachCaseName; //微格教学案例名称
objvMicroteachCase_Resource_Rel4AllENT.MicroteachCaseTheme = objvMicroteachCase_Resource_Rel4AllENS.MicroteachCaseTheme; //微格教学案例主题词
objvMicroteachCase_Resource_Rel4AllENT.MicroteachCaseDate = objvMicroteachCase_Resource_Rel4AllENS.MicroteachCaseDate; //微格教学日期
objvMicroteachCase_Resource_Rel4AllENT.MicroteachCaseTime = objvMicroteachCase_Resource_Rel4AllENS.MicroteachCaseTime; //微格教学时间
objvMicroteachCase_Resource_Rel4AllENT.MicroteachCaseDateIn = objvMicroteachCase_Resource_Rel4AllENS.MicroteachCaseDateIn; //案例入库日期
objvMicroteachCase_Resource_Rel4AllENT.IdStudyLevel = objvMicroteachCase_Resource_Rel4AllENS.IdStudyLevel; //id_StudyLevel
objvMicroteachCase_Resource_Rel4AllENT.StudyLevelName = objvMicroteachCase_Resource_Rel4AllENS.StudyLevelName; //学段名称
objvMicroteachCase_Resource_Rel4AllENT.IdTeachingPlan = objvMicroteachCase_Resource_Rel4AllENS.IdTeachingPlan; //教案流水号
objvMicroteachCase_Resource_Rel4AllENT.MicroTeachCaseTimeIn = objvMicroteachCase_Resource_Rel4AllENS.MicroTeachCaseTimeIn; //案例入库时间
objvMicroteachCase_Resource_Rel4AllENT.IdCaseType = objvMicroteachCase_Resource_Rel4AllENS.IdCaseType; //案例类型流水号
objvMicroteachCase_Resource_Rel4AllENT.IdDiscipline = objvMicroteachCase_Resource_Rel4AllENS.IdDiscipline; //学科流水号
objvMicroteachCase_Resource_Rel4AllENT.DisciplineID = objvMicroteachCase_Resource_Rel4AllENS.DisciplineID; //学科ID
objvMicroteachCase_Resource_Rel4AllENT.DisciplineName = objvMicroteachCase_Resource_Rel4AllENS.DisciplineName; //学科名称
objvMicroteachCase_Resource_Rel4AllENT.senateGaugeVersionID = objvMicroteachCase_Resource_Rel4AllENS.senateGaugeVersionID; //评价量表版本ID
objvMicroteachCase_Resource_Rel4AllENT.senateGaugeVersionName = objvMicroteachCase_Resource_Rel4AllENS.senateGaugeVersionName; //评价量表版本名称
objvMicroteachCase_Resource_Rel4AllENT.senateGaugeVersionTtlScore = objvMicroteachCase_Resource_Rel4AllENS.senateGaugeVersionTtlScore; //评价量表版本总分
objvMicroteachCase_Resource_Rel4AllENT.VersionNo = objvMicroteachCase_Resource_Rel4AllENS.VersionNo; //版本号
objvMicroteachCase_Resource_Rel4AllENT.IdTeachSkill = objvMicroteachCase_Resource_Rel4AllENS.IdTeachSkill; //教学技能流水号
objvMicroteachCase_Resource_Rel4AllENT.TeachSkillID = objvMicroteachCase_Resource_Rel4AllENS.TeachSkillID; //教学技能ID
objvMicroteachCase_Resource_Rel4AllENT.SkillTypeName = objvMicroteachCase_Resource_Rel4AllENS.SkillTypeName; //技能类型名称
objvMicroteachCase_Resource_Rel4AllENT.TeachSkillName = objvMicroteachCase_Resource_Rel4AllENS.TeachSkillName; //教学技能名称
objvMicroteachCase_Resource_Rel4AllENT.TeachSkillTheory = objvMicroteachCase_Resource_Rel4AllENS.TeachSkillTheory; //教学技能理论阐述
objvMicroteachCase_Resource_Rel4AllENT.TeachSkillOperMethod = objvMicroteachCase_Resource_Rel4AllENS.TeachSkillOperMethod; //教学技能实践操作方法
objvMicroteachCase_Resource_Rel4AllENT.IdSkillType = objvMicroteachCase_Resource_Rel4AllENS.IdSkillType; //技能类型流水号
objvMicroteachCase_Resource_Rel4AllENT.SkillTypeID = objvMicroteachCase_Resource_Rel4AllENS.SkillTypeID; //技能类型ID
objvMicroteachCase_Resource_Rel4AllENT.CaseLevelId = objvMicroteachCase_Resource_Rel4AllENS.CaseLevelId; //课例等级Id
objvMicroteachCase_Resource_Rel4AllENT.CaseLevelName = objvMicroteachCase_Resource_Rel4AllENS.CaseLevelName; //案例等级名称
objvMicroteachCase_Resource_Rel4AllENT.microteachCaseText = objvMicroteachCase_Resource_Rel4AllENS.microteachCaseText; //案例文本内容
objvMicroteachCase_Resource_Rel4AllENT.OwnerId = objvMicroteachCase_Resource_Rel4AllENS.OwnerId; //拥有者Id
objvMicroteachCase_Resource_Rel4AllENT.OwnerName = objvMicroteachCase_Resource_Rel4AllENS.OwnerName; //拥有者姓名
objvMicroteachCase_Resource_Rel4AllENT.CollegeID = objvMicroteachCase_Resource_Rel4AllENS.CollegeID; //学院ID
objvMicroteachCase_Resource_Rel4AllENT.CollegeName = objvMicroteachCase_Resource_Rel4AllENS.CollegeName; //学院名称
objvMicroteachCase_Resource_Rel4AllENT.OwnerNameWithId = objvMicroteachCase_Resource_Rel4AllENS.OwnerNameWithId; //拥有者名称附Id
objvMicroteachCase_Resource_Rel4AllENT.IdXzCollege = objvMicroteachCase_Resource_Rel4AllENS.IdXzCollege; //学院流水号
objvMicroteachCase_Resource_Rel4AllENT.IsDualVideo = objvMicroteachCase_Resource_Rel4AllENS.IsDualVideo; //是否双视频
objvMicroteachCase_Resource_Rel4AllENT.UserKindId = objvMicroteachCase_Resource_Rel4AllENS.UserKindId; //用户类别Id
objvMicroteachCase_Resource_Rel4AllENT.UserKindName = objvMicroteachCase_Resource_Rel4AllENS.UserKindName; //用户类别名
objvMicroteachCase_Resource_Rel4AllENT.UserTypeId = objvMicroteachCase_Resource_Rel4AllENS.UserTypeId; //用户类型Id
objvMicroteachCase_Resource_Rel4AllENT.UserTypeName = objvMicroteachCase_Resource_Rel4AllENS.UserTypeName; //用户类型名称
objvMicroteachCase_Resource_Rel4AllENT.RecommendedDegreeId = objvMicroteachCase_Resource_Rel4AllENS.RecommendedDegreeId; //推荐度Id
objvMicroteachCase_Resource_Rel4AllENT.RecommendedDegreeName = objvMicroteachCase_Resource_Rel4AllENS.RecommendedDegreeName; //推荐度名称
objvMicroteachCase_Resource_Rel4AllENT.BrowseCount4Case = objvMicroteachCase_Resource_Rel4AllENS.BrowseCount4Case; //课例浏览次数
objvMicroteachCase_Resource_Rel4AllENT.IdResource = objvMicroteachCase_Resource_Rel4AllENS.IdResource; //资源流水号
objvMicroteachCase_Resource_Rel4AllENT.ResourceID = objvMicroteachCase_Resource_Rel4AllENS.ResourceID; //资源ID
objvMicroteachCase_Resource_Rel4AllENT.ResourceName = objvMicroteachCase_Resource_Rel4AllENS.ResourceName; //资源名称
objvMicroteachCase_Resource_Rel4AllENT.IdFtpResource = objvMicroteachCase_Resource_Rel4AllENS.IdFtpResource; //FTP资源流水号
objvMicroteachCase_Resource_Rel4AllENT.IdFile = objvMicroteachCase_Resource_Rel4AllENS.IdFile; //文件流水号
objvMicroteachCase_Resource_Rel4AllENT.FileName = objvMicroteachCase_Resource_Rel4AllENS.FileName; //文件名称
objvMicroteachCase_Resource_Rel4AllENT.FileType = objvMicroteachCase_Resource_Rel4AllENS.FileType; //文件类型
objvMicroteachCase_Resource_Rel4AllENT.SaveDate = objvMicroteachCase_Resource_Rel4AllENS.SaveDate; //创建日期
objvMicroteachCase_Resource_Rel4AllENT.FileSize = objvMicroteachCase_Resource_Rel4AllENS.FileSize; //文件大小
objvMicroteachCase_Resource_Rel4AllENT.SaveTime = objvMicroteachCase_Resource_Rel4AllENS.SaveTime; //创建时间
objvMicroteachCase_Resource_Rel4AllENT.FtpResourceID = objvMicroteachCase_Resource_Rel4AllENS.FtpResourceID; //FTP资源ID
objvMicroteachCase_Resource_Rel4AllENT.FileOriginalName = objvMicroteachCase_Resource_Rel4AllENS.FileOriginalName; //文件原名
objvMicroteachCase_Resource_Rel4AllENT.FileDirName = objvMicroteachCase_Resource_Rel4AllENS.FileDirName; //文件目录名
objvMicroteachCase_Resource_Rel4AllENT.FileRename = objvMicroteachCase_Resource_Rel4AllENS.FileRename; //文件新名
objvMicroteachCase_Resource_Rel4AllENT.FileUpDate = objvMicroteachCase_Resource_Rel4AllENS.FileUpDate; //创建日期
objvMicroteachCase_Resource_Rel4AllENT.FileUpTime = objvMicroteachCase_Resource_Rel4AllENS.FileUpTime; //创建时间
objvMicroteachCase_Resource_Rel4AllENT.SaveMode = objvMicroteachCase_Resource_Rel4AllENS.SaveMode; //文件存放方式
objvMicroteachCase_Resource_Rel4AllENT.IdResourceType = objvMicroteachCase_Resource_Rel4AllENS.IdResourceType; //资源类型流水号
objvMicroteachCase_Resource_Rel4AllENT.ResourceTypeID = objvMicroteachCase_Resource_Rel4AllENS.ResourceTypeID; //资源类型ID
objvMicroteachCase_Resource_Rel4AllENT.ResourceTypeName = objvMicroteachCase_Resource_Rel4AllENS.ResourceTypeName; //资源类型名称
objvMicroteachCase_Resource_Rel4AllENT.ResourceOwner = objvMicroteachCase_Resource_Rel4AllENS.ResourceOwner; //上传者
objvMicroteachCase_Resource_Rel4AllENT.ftpFileType = objvMicroteachCase_Resource_Rel4AllENS.ftpFileType; //ftp文件类型
objvMicroteachCase_Resource_Rel4AllENT.ftpFileSize = objvMicroteachCase_Resource_Rel4AllENS.ftpFileSize; //ftp文件大小
objvMicroteachCase_Resource_Rel4AllENT.ftpResourceOwner = objvMicroteachCase_Resource_Rel4AllENS.ftpResourceOwner; //Ftp资源拥有者
objvMicroteachCase_Resource_Rel4AllENT.FileOriginName = objvMicroteachCase_Resource_Rel4AllENS.FileOriginName; //原文件名
objvMicroteachCase_Resource_Rel4AllENT.IsExistFile = objvMicroteachCase_Resource_Rel4AllENS.IsExistFile; //是否存在文件
objvMicroteachCase_Resource_Rel4AllENT.FileNewName = objvMicroteachCase_Resource_Rel4AllENS.FileNewName; //新文件名
objvMicroteachCase_Resource_Rel4AllENT.FileOldName = objvMicroteachCase_Resource_Rel4AllENS.FileOldName; //旧文件名
objvMicroteachCase_Resource_Rel4AllENT.IsMain = objvMicroteachCase_Resource_Rel4AllENS.IsMain; //是否主资源
objvMicroteachCase_Resource_Rel4AllENT.IdUsingMode = objvMicroteachCase_Resource_Rel4AllENS.IdUsingMode; //资源使用模式流水号
objvMicroteachCase_Resource_Rel4AllENT.IsVisible = objvMicroteachCase_Resource_Rel4AllENS.IsVisible; //是否显示
objvMicroteachCase_Resource_Rel4AllENT.IndexNO = objvMicroteachCase_Resource_Rel4AllENS.IndexNO; //序号
objvMicroteachCase_Resource_Rel4AllENT.BrowseCount = objvMicroteachCase_Resource_Rel4AllENS.BrowseCount; //浏览次数
objvMicroteachCase_Resource_Rel4AllENT.UpdDate = objvMicroteachCase_Resource_Rel4AllENS.UpdDate; //修改日期
objvMicroteachCase_Resource_Rel4AllENT.UpdUser = objvMicroteachCase_Resource_Rel4AllENS.UpdUser; //修改人
objvMicroteachCase_Resource_Rel4AllENT.Memo = objvMicroteachCase_Resource_Rel4AllENS.Memo; //备注
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvMicroteachCase_Resource_Rel4AllEN objvMicroteachCase_Resource_Rel4AllEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvMicroteachCase_Resource_Rel4AllEN.IdMicroteachCase, 8, convMicroteachCase_Resource_Rel4All.IdMicroteachCase);
clsCheckSql.CheckFieldLen(objvMicroteachCase_Resource_Rel4AllEN.MicroteachCaseID, 8, convMicroteachCase_Resource_Rel4All.MicroteachCaseID);
clsCheckSql.CheckFieldLen(objvMicroteachCase_Resource_Rel4AllEN.MicroteachCaseName, 100, convMicroteachCase_Resource_Rel4All.MicroteachCaseName);
clsCheckSql.CheckFieldLen(objvMicroteachCase_Resource_Rel4AllEN.MicroteachCaseTheme, 200, convMicroteachCase_Resource_Rel4All.MicroteachCaseTheme);
clsCheckSql.CheckFieldLen(objvMicroteachCase_Resource_Rel4AllEN.MicroteachCaseDate, 8, convMicroteachCase_Resource_Rel4All.MicroteachCaseDate);
clsCheckSql.CheckFieldLen(objvMicroteachCase_Resource_Rel4AllEN.MicroteachCaseTime, 6, convMicroteachCase_Resource_Rel4All.MicroteachCaseTime);
clsCheckSql.CheckFieldLen(objvMicroteachCase_Resource_Rel4AllEN.MicroteachCaseDateIn, 8, convMicroteachCase_Resource_Rel4All.MicroteachCaseDateIn);
clsCheckSql.CheckFieldLen(objvMicroteachCase_Resource_Rel4AllEN.IdStudyLevel, 4, convMicroteachCase_Resource_Rel4All.IdStudyLevel);
clsCheckSql.CheckFieldLen(objvMicroteachCase_Resource_Rel4AllEN.StudyLevelName, 50, convMicroteachCase_Resource_Rel4All.StudyLevelName);
clsCheckSql.CheckFieldLen(objvMicroteachCase_Resource_Rel4AllEN.IdTeachingPlan, 8, convMicroteachCase_Resource_Rel4All.IdTeachingPlan);
clsCheckSql.CheckFieldLen(objvMicroteachCase_Resource_Rel4AllEN.MicroTeachCaseTimeIn, 6, convMicroteachCase_Resource_Rel4All.MicroTeachCaseTimeIn);
clsCheckSql.CheckFieldLen(objvMicroteachCase_Resource_Rel4AllEN.IdCaseType, 4, convMicroteachCase_Resource_Rel4All.IdCaseType);
clsCheckSql.CheckFieldLen(objvMicroteachCase_Resource_Rel4AllEN.IdDiscipline, 4, convMicroteachCase_Resource_Rel4All.IdDiscipline);
clsCheckSql.CheckFieldLen(objvMicroteachCase_Resource_Rel4AllEN.DisciplineID, 4, convMicroteachCase_Resource_Rel4All.DisciplineID);
clsCheckSql.CheckFieldLen(objvMicroteachCase_Resource_Rel4AllEN.DisciplineName, 50, convMicroteachCase_Resource_Rel4All.DisciplineName);
clsCheckSql.CheckFieldLen(objvMicroteachCase_Resource_Rel4AllEN.senateGaugeVersionID, 4, convMicroteachCase_Resource_Rel4All.senateGaugeVersionID);
clsCheckSql.CheckFieldLen(objvMicroteachCase_Resource_Rel4AllEN.senateGaugeVersionName, 200, convMicroteachCase_Resource_Rel4All.senateGaugeVersionName);
clsCheckSql.CheckFieldLen(objvMicroteachCase_Resource_Rel4AllEN.IdTeachSkill, 8, convMicroteachCase_Resource_Rel4All.IdTeachSkill);
clsCheckSql.CheckFieldLen(objvMicroteachCase_Resource_Rel4AllEN.TeachSkillID, 8, convMicroteachCase_Resource_Rel4All.TeachSkillID);
clsCheckSql.CheckFieldLen(objvMicroteachCase_Resource_Rel4AllEN.SkillTypeName, 50, convMicroteachCase_Resource_Rel4All.SkillTypeName);
clsCheckSql.CheckFieldLen(objvMicroteachCase_Resource_Rel4AllEN.TeachSkillName, 50, convMicroteachCase_Resource_Rel4All.TeachSkillName);
clsCheckSql.CheckFieldLen(objvMicroteachCase_Resource_Rel4AllEN.TeachSkillTheory, 8000, convMicroteachCase_Resource_Rel4All.TeachSkillTheory);
clsCheckSql.CheckFieldLen(objvMicroteachCase_Resource_Rel4AllEN.TeachSkillOperMethod, 2000, convMicroteachCase_Resource_Rel4All.TeachSkillOperMethod);
clsCheckSql.CheckFieldLen(objvMicroteachCase_Resource_Rel4AllEN.IdSkillType, 4, convMicroteachCase_Resource_Rel4All.IdSkillType);
clsCheckSql.CheckFieldLen(objvMicroteachCase_Resource_Rel4AllEN.SkillTypeID, 4, convMicroteachCase_Resource_Rel4All.SkillTypeID);
clsCheckSql.CheckFieldLen(objvMicroteachCase_Resource_Rel4AllEN.CaseLevelId, 2, convMicroteachCase_Resource_Rel4All.CaseLevelId);
clsCheckSql.CheckFieldLen(objvMicroteachCase_Resource_Rel4AllEN.CaseLevelName, 30, convMicroteachCase_Resource_Rel4All.CaseLevelName);
clsCheckSql.CheckFieldLen(objvMicroteachCase_Resource_Rel4AllEN.microteachCaseText, 8000, convMicroteachCase_Resource_Rel4All.microteachCaseText);
clsCheckSql.CheckFieldLen(objvMicroteachCase_Resource_Rel4AllEN.OwnerId, 20, convMicroteachCase_Resource_Rel4All.OwnerId);
clsCheckSql.CheckFieldLen(objvMicroteachCase_Resource_Rel4AllEN.OwnerName, 30, convMicroteachCase_Resource_Rel4All.OwnerName);
clsCheckSql.CheckFieldLen(objvMicroteachCase_Resource_Rel4AllEN.CollegeID, 4, convMicroteachCase_Resource_Rel4All.CollegeID);
clsCheckSql.CheckFieldLen(objvMicroteachCase_Resource_Rel4AllEN.CollegeName, 100, convMicroteachCase_Resource_Rel4All.CollegeName);
clsCheckSql.CheckFieldLen(objvMicroteachCase_Resource_Rel4AllEN.OwnerNameWithId, 51, convMicroteachCase_Resource_Rel4All.OwnerNameWithId);
clsCheckSql.CheckFieldLen(objvMicroteachCase_Resource_Rel4AllEN.IdXzCollege, 4, convMicroteachCase_Resource_Rel4All.IdXzCollege);
clsCheckSql.CheckFieldLen(objvMicroteachCase_Resource_Rel4AllEN.UserKindId, 2, convMicroteachCase_Resource_Rel4All.UserKindId);
clsCheckSql.CheckFieldLen(objvMicroteachCase_Resource_Rel4AllEN.UserKindName, 30, convMicroteachCase_Resource_Rel4All.UserKindName);
clsCheckSql.CheckFieldLen(objvMicroteachCase_Resource_Rel4AllEN.UserTypeId, 2, convMicroteachCase_Resource_Rel4All.UserTypeId);
clsCheckSql.CheckFieldLen(objvMicroteachCase_Resource_Rel4AllEN.UserTypeName, 20, convMicroteachCase_Resource_Rel4All.UserTypeName);
clsCheckSql.CheckFieldLen(objvMicroteachCase_Resource_Rel4AllEN.RecommendedDegreeId, 2, convMicroteachCase_Resource_Rel4All.RecommendedDegreeId);
clsCheckSql.CheckFieldLen(objvMicroteachCase_Resource_Rel4AllEN.RecommendedDegreeName, 30, convMicroteachCase_Resource_Rel4All.RecommendedDegreeName);
clsCheckSql.CheckFieldLen(objvMicroteachCase_Resource_Rel4AllEN.IdResource, 8, convMicroteachCase_Resource_Rel4All.IdResource);
clsCheckSql.CheckFieldLen(objvMicroteachCase_Resource_Rel4AllEN.ResourceID, 8, convMicroteachCase_Resource_Rel4All.ResourceID);
clsCheckSql.CheckFieldLen(objvMicroteachCase_Resource_Rel4AllEN.ResourceName, 100, convMicroteachCase_Resource_Rel4All.ResourceName);
clsCheckSql.CheckFieldLen(objvMicroteachCase_Resource_Rel4AllEN.IdFtpResource, 8, convMicroteachCase_Resource_Rel4All.IdFtpResource);
clsCheckSql.CheckFieldLen(objvMicroteachCase_Resource_Rel4AllEN.IdFile, 8, convMicroteachCase_Resource_Rel4All.IdFile);
clsCheckSql.CheckFieldLen(objvMicroteachCase_Resource_Rel4AllEN.FileName, 500, convMicroteachCase_Resource_Rel4All.FileName);
clsCheckSql.CheckFieldLen(objvMicroteachCase_Resource_Rel4AllEN.FileType, 30, convMicroteachCase_Resource_Rel4All.FileType);
clsCheckSql.CheckFieldLen(objvMicroteachCase_Resource_Rel4AllEN.SaveDate, 8, convMicroteachCase_Resource_Rel4All.SaveDate);
clsCheckSql.CheckFieldLen(objvMicroteachCase_Resource_Rel4AllEN.FileSize, 50, convMicroteachCase_Resource_Rel4All.FileSize);
clsCheckSql.CheckFieldLen(objvMicroteachCase_Resource_Rel4AllEN.SaveTime, 6, convMicroteachCase_Resource_Rel4All.SaveTime);
clsCheckSql.CheckFieldLen(objvMicroteachCase_Resource_Rel4AllEN.FtpResourceID, 8, convMicroteachCase_Resource_Rel4All.FtpResourceID);
clsCheckSql.CheckFieldLen(objvMicroteachCase_Resource_Rel4AllEN.FileOriginalName, 200, convMicroteachCase_Resource_Rel4All.FileOriginalName);
clsCheckSql.CheckFieldLen(objvMicroteachCase_Resource_Rel4AllEN.FileDirName, 200, convMicroteachCase_Resource_Rel4All.FileDirName);
clsCheckSql.CheckFieldLen(objvMicroteachCase_Resource_Rel4AllEN.FileRename, 200, convMicroteachCase_Resource_Rel4All.FileRename);
clsCheckSql.CheckFieldLen(objvMicroteachCase_Resource_Rel4AllEN.FileUpDate, 8, convMicroteachCase_Resource_Rel4All.FileUpDate);
clsCheckSql.CheckFieldLen(objvMicroteachCase_Resource_Rel4AllEN.FileUpTime, 6, convMicroteachCase_Resource_Rel4All.FileUpTime);
clsCheckSql.CheckFieldLen(objvMicroteachCase_Resource_Rel4AllEN.IdResourceType, 4, convMicroteachCase_Resource_Rel4All.IdResourceType);
clsCheckSql.CheckFieldLen(objvMicroteachCase_Resource_Rel4AllEN.ResourceTypeID, 4, convMicroteachCase_Resource_Rel4All.ResourceTypeID);
clsCheckSql.CheckFieldLen(objvMicroteachCase_Resource_Rel4AllEN.ResourceTypeName, 50, convMicroteachCase_Resource_Rel4All.ResourceTypeName);
clsCheckSql.CheckFieldLen(objvMicroteachCase_Resource_Rel4AllEN.ResourceOwner, 50, convMicroteachCase_Resource_Rel4All.ResourceOwner);
clsCheckSql.CheckFieldLen(objvMicroteachCase_Resource_Rel4AllEN.ftpFileType, 30, convMicroteachCase_Resource_Rel4All.ftpFileType);
clsCheckSql.CheckFieldLen(objvMicroteachCase_Resource_Rel4AllEN.ftpFileSize, 50, convMicroteachCase_Resource_Rel4All.ftpFileSize);
clsCheckSql.CheckFieldLen(objvMicroteachCase_Resource_Rel4AllEN.ftpResourceOwner, 50, convMicroteachCase_Resource_Rel4All.ftpResourceOwner);
clsCheckSql.CheckFieldLen(objvMicroteachCase_Resource_Rel4AllEN.FileOriginName, 500, convMicroteachCase_Resource_Rel4All.FileOriginName);
clsCheckSql.CheckFieldLen(objvMicroteachCase_Resource_Rel4AllEN.FileNewName, 530, convMicroteachCase_Resource_Rel4All.FileNewName);
clsCheckSql.CheckFieldLen(objvMicroteachCase_Resource_Rel4AllEN.FileOldName, 530, convMicroteachCase_Resource_Rel4All.FileOldName);
clsCheckSql.CheckFieldLen(objvMicroteachCase_Resource_Rel4AllEN.IdUsingMode, 4, convMicroteachCase_Resource_Rel4All.IdUsingMode);
clsCheckSql.CheckFieldLen(objvMicroteachCase_Resource_Rel4AllEN.UpdDate, 20, convMicroteachCase_Resource_Rel4All.UpdDate);
clsCheckSql.CheckFieldLen(objvMicroteachCase_Resource_Rel4AllEN.UpdUser, 20, convMicroteachCase_Resource_Rel4All.UpdUser);
clsCheckSql.CheckFieldLen(objvMicroteachCase_Resource_Rel4AllEN.Memo, 1000, convMicroteachCase_Resource_Rel4All.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase_Resource_Rel4AllEN.IdMicroteachCase, convMicroteachCase_Resource_Rel4All.IdMicroteachCase);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase_Resource_Rel4AllEN.MicroteachCaseID, convMicroteachCase_Resource_Rel4All.MicroteachCaseID);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase_Resource_Rel4AllEN.MicroteachCaseName, convMicroteachCase_Resource_Rel4All.MicroteachCaseName);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase_Resource_Rel4AllEN.MicroteachCaseTheme, convMicroteachCase_Resource_Rel4All.MicroteachCaseTheme);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase_Resource_Rel4AllEN.MicroteachCaseDate, convMicroteachCase_Resource_Rel4All.MicroteachCaseDate);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase_Resource_Rel4AllEN.MicroteachCaseTime, convMicroteachCase_Resource_Rel4All.MicroteachCaseTime);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase_Resource_Rel4AllEN.MicroteachCaseDateIn, convMicroteachCase_Resource_Rel4All.MicroteachCaseDateIn);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase_Resource_Rel4AllEN.IdStudyLevel, convMicroteachCase_Resource_Rel4All.IdStudyLevel);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase_Resource_Rel4AllEN.StudyLevelName, convMicroteachCase_Resource_Rel4All.StudyLevelName);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase_Resource_Rel4AllEN.IdTeachingPlan, convMicroteachCase_Resource_Rel4All.IdTeachingPlan);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase_Resource_Rel4AllEN.MicroTeachCaseTimeIn, convMicroteachCase_Resource_Rel4All.MicroTeachCaseTimeIn);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase_Resource_Rel4AllEN.IdCaseType, convMicroteachCase_Resource_Rel4All.IdCaseType);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase_Resource_Rel4AllEN.IdDiscipline, convMicroteachCase_Resource_Rel4All.IdDiscipline);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase_Resource_Rel4AllEN.DisciplineID, convMicroteachCase_Resource_Rel4All.DisciplineID);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase_Resource_Rel4AllEN.DisciplineName, convMicroteachCase_Resource_Rel4All.DisciplineName);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase_Resource_Rel4AllEN.senateGaugeVersionID, convMicroteachCase_Resource_Rel4All.senateGaugeVersionID);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase_Resource_Rel4AllEN.senateGaugeVersionName, convMicroteachCase_Resource_Rel4All.senateGaugeVersionName);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase_Resource_Rel4AllEN.IdTeachSkill, convMicroteachCase_Resource_Rel4All.IdTeachSkill);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase_Resource_Rel4AllEN.TeachSkillID, convMicroteachCase_Resource_Rel4All.TeachSkillID);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase_Resource_Rel4AllEN.SkillTypeName, convMicroteachCase_Resource_Rel4All.SkillTypeName);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase_Resource_Rel4AllEN.TeachSkillName, convMicroteachCase_Resource_Rel4All.TeachSkillName);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase_Resource_Rel4AllEN.TeachSkillTheory, convMicroteachCase_Resource_Rel4All.TeachSkillTheory);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase_Resource_Rel4AllEN.TeachSkillOperMethod, convMicroteachCase_Resource_Rel4All.TeachSkillOperMethod);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase_Resource_Rel4AllEN.IdSkillType, convMicroteachCase_Resource_Rel4All.IdSkillType);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase_Resource_Rel4AllEN.SkillTypeID, convMicroteachCase_Resource_Rel4All.SkillTypeID);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase_Resource_Rel4AllEN.CaseLevelId, convMicroteachCase_Resource_Rel4All.CaseLevelId);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase_Resource_Rel4AllEN.CaseLevelName, convMicroteachCase_Resource_Rel4All.CaseLevelName);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase_Resource_Rel4AllEN.microteachCaseText, convMicroteachCase_Resource_Rel4All.microteachCaseText);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase_Resource_Rel4AllEN.OwnerId, convMicroteachCase_Resource_Rel4All.OwnerId);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase_Resource_Rel4AllEN.OwnerName, convMicroteachCase_Resource_Rel4All.OwnerName);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase_Resource_Rel4AllEN.CollegeID, convMicroteachCase_Resource_Rel4All.CollegeID);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase_Resource_Rel4AllEN.CollegeName, convMicroteachCase_Resource_Rel4All.CollegeName);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase_Resource_Rel4AllEN.OwnerNameWithId, convMicroteachCase_Resource_Rel4All.OwnerNameWithId);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase_Resource_Rel4AllEN.IdXzCollege, convMicroteachCase_Resource_Rel4All.IdXzCollege);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase_Resource_Rel4AllEN.UserKindId, convMicroteachCase_Resource_Rel4All.UserKindId);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase_Resource_Rel4AllEN.UserKindName, convMicroteachCase_Resource_Rel4All.UserKindName);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase_Resource_Rel4AllEN.UserTypeId, convMicroteachCase_Resource_Rel4All.UserTypeId);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase_Resource_Rel4AllEN.UserTypeName, convMicroteachCase_Resource_Rel4All.UserTypeName);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase_Resource_Rel4AllEN.RecommendedDegreeId, convMicroteachCase_Resource_Rel4All.RecommendedDegreeId);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase_Resource_Rel4AllEN.RecommendedDegreeName, convMicroteachCase_Resource_Rel4All.RecommendedDegreeName);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase_Resource_Rel4AllEN.IdResource, convMicroteachCase_Resource_Rel4All.IdResource);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase_Resource_Rel4AllEN.ResourceID, convMicroteachCase_Resource_Rel4All.ResourceID);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase_Resource_Rel4AllEN.ResourceName, convMicroteachCase_Resource_Rel4All.ResourceName);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase_Resource_Rel4AllEN.IdFtpResource, convMicroteachCase_Resource_Rel4All.IdFtpResource);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase_Resource_Rel4AllEN.IdFile, convMicroteachCase_Resource_Rel4All.IdFile);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase_Resource_Rel4AllEN.FileName, convMicroteachCase_Resource_Rel4All.FileName);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase_Resource_Rel4AllEN.FileType, convMicroteachCase_Resource_Rel4All.FileType);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase_Resource_Rel4AllEN.SaveDate, convMicroteachCase_Resource_Rel4All.SaveDate);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase_Resource_Rel4AllEN.FileSize, convMicroteachCase_Resource_Rel4All.FileSize);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase_Resource_Rel4AllEN.SaveTime, convMicroteachCase_Resource_Rel4All.SaveTime);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase_Resource_Rel4AllEN.FtpResourceID, convMicroteachCase_Resource_Rel4All.FtpResourceID);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase_Resource_Rel4AllEN.FileOriginalName, convMicroteachCase_Resource_Rel4All.FileOriginalName);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase_Resource_Rel4AllEN.FileDirName, convMicroteachCase_Resource_Rel4All.FileDirName);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase_Resource_Rel4AllEN.FileRename, convMicroteachCase_Resource_Rel4All.FileRename);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase_Resource_Rel4AllEN.FileUpDate, convMicroteachCase_Resource_Rel4All.FileUpDate);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase_Resource_Rel4AllEN.FileUpTime, convMicroteachCase_Resource_Rel4All.FileUpTime);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase_Resource_Rel4AllEN.IdResourceType, convMicroteachCase_Resource_Rel4All.IdResourceType);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase_Resource_Rel4AllEN.ResourceTypeID, convMicroteachCase_Resource_Rel4All.ResourceTypeID);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase_Resource_Rel4AllEN.ResourceTypeName, convMicroteachCase_Resource_Rel4All.ResourceTypeName);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase_Resource_Rel4AllEN.ResourceOwner, convMicroteachCase_Resource_Rel4All.ResourceOwner);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase_Resource_Rel4AllEN.ftpFileType, convMicroteachCase_Resource_Rel4All.ftpFileType);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase_Resource_Rel4AllEN.ftpFileSize, convMicroteachCase_Resource_Rel4All.ftpFileSize);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase_Resource_Rel4AllEN.ftpResourceOwner, convMicroteachCase_Resource_Rel4All.ftpResourceOwner);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase_Resource_Rel4AllEN.FileOriginName, convMicroteachCase_Resource_Rel4All.FileOriginName);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase_Resource_Rel4AllEN.FileNewName, convMicroteachCase_Resource_Rel4All.FileNewName);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase_Resource_Rel4AllEN.FileOldName, convMicroteachCase_Resource_Rel4All.FileOldName);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase_Resource_Rel4AllEN.IdUsingMode, convMicroteachCase_Resource_Rel4All.IdUsingMode);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase_Resource_Rel4AllEN.UpdDate, convMicroteachCase_Resource_Rel4All.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase_Resource_Rel4AllEN.UpdUser, convMicroteachCase_Resource_Rel4All.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase_Resource_Rel4AllEN.Memo, convMicroteachCase_Resource_Rel4All.Memo);
//检查外键字段长度
 objvMicroteachCase_Resource_Rel4AllEN._IsCheckProperty = true;
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
 objSQL = clsvMicroteachCase_Resource_Rel4AllDA.GetSpecSQLObj();
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
 objSQL = clsvMicroteachCase_Resource_Rel4AllDA.GetSpecSQLObj();
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
 objSQL = clsvMicroteachCase_Resource_Rel4AllDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvMicroteachCase_Resource_Rel4AllEN._CurrTabName);
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
 objSQL = clsvMicroteachCase_Resource_Rel4AllDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvMicroteachCase_Resource_Rel4AllEN._CurrTabName, strCondition);
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
 objSQL = clsvMicroteachCase_Resource_Rel4AllDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}