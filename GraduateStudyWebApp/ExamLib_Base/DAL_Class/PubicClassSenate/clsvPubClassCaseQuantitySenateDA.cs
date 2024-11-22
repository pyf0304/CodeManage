
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvPubClassCaseQuantitySenateDA
 表名:vPubClassCaseQuantitySenate(01120414)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:48:44
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
 /// v公开课案例量化评价(vPubClassCaseQuantitySenate)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvPubClassCaseQuantitySenateDA : clsCommBase4DA
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
 return clsvPubClassCaseQuantitySenateEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvPubClassCaseQuantitySenateEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvPubClassCaseQuantitySenateEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvPubClassCaseQuantitySenateEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvPubClassCaseQuantitySenateEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvPubClassCaseQuantitySenateDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPubClassCaseQuantitySenateDA.GetSpecSQLObj();
strSQL = "Select * from vPubClassCaseQuantitySenate where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vPubClassCaseQuantitySenate(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvPubClassCaseQuantitySenateDA: GetDataTable_vPubClassCaseQuantitySenate)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPubClassCaseQuantitySenateDA.GetSpecSQLObj();
strSQL = "Select * from vPubClassCaseQuantitySenate where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvPubClassCaseQuantitySenateDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPubClassCaseQuantitySenateDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvPubClassCaseQuantitySenateDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPubClassCaseQuantitySenateDA.GetSpecSQLObj();
strSQL = "Select * from vPubClassCaseQuantitySenate where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvPubClassCaseQuantitySenateDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPubClassCaseQuantitySenateDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvPubClassCaseQuantitySenateDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPubClassCaseQuantitySenateDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vPubClassCaseQuantitySenate where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vPubClassCaseQuantitySenate where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvPubClassCaseQuantitySenateDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPubClassCaseQuantitySenateDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vPubClassCaseQuantitySenate where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvPubClassCaseQuantitySenateDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPubClassCaseQuantitySenateDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vPubClassCaseQuantitySenate.* from vPubClassCaseQuantitySenate Left Join {1} on {2} where {3} and vPubClassCaseQuantitySenate.IdpubClassCaseQuantitySenate not in (Select top {5} vPubClassCaseQuantitySenate.IdpubClassCaseQuantitySenate from vPubClassCaseQuantitySenate Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vPubClassCaseQuantitySenate where {1} and IdpubClassCaseQuantitySenate not in (Select top {2} IdpubClassCaseQuantitySenate from vPubClassCaseQuantitySenate where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vPubClassCaseQuantitySenate where {1} and IdpubClassCaseQuantitySenate not in (Select top {3} IdpubClassCaseQuantitySenate from vPubClassCaseQuantitySenate where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvPubClassCaseQuantitySenateDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPubClassCaseQuantitySenateDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vPubClassCaseQuantitySenate.* from vPubClassCaseQuantitySenate Left Join {1} on {2} where {3} and vPubClassCaseQuantitySenate.IdpubClassCaseQuantitySenate not in (Select top {5} vPubClassCaseQuantitySenate.IdpubClassCaseQuantitySenate from vPubClassCaseQuantitySenate Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vPubClassCaseQuantitySenate where {1} and IdpubClassCaseQuantitySenate not in (Select top {2} IdpubClassCaseQuantitySenate from vPubClassCaseQuantitySenate where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vPubClassCaseQuantitySenate where {1} and IdpubClassCaseQuantitySenate not in (Select top {3} IdpubClassCaseQuantitySenate from vPubClassCaseQuantitySenate where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvPubClassCaseQuantitySenateEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvPubClassCaseQuantitySenateDA:GetObjLst)", objException.Message));
}
List<clsvPubClassCaseQuantitySenateEN> arrObjLst = new List<clsvPubClassCaseQuantitySenateEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPubClassCaseQuantitySenateDA.GetSpecSQLObj();
strSQL = "Select * from vPubClassCaseQuantitySenate where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPubClassCaseQuantitySenateEN objvPubClassCaseQuantitySenateEN = new clsvPubClassCaseQuantitySenateEN();
try
{
objvPubClassCaseQuantitySenateEN.IdpubClassCaseQuantitySenate = TransNullToInt(objRow[convPubClassCaseQuantitySenate.IdpubClassCaseQuantitySenate].ToString().Trim()); //流水号
objvPubClassCaseQuantitySenateEN.IdPubClassCase = objRow[convPubClassCaseQuantitySenate.IdPubClassCase].ToString().Trim(); //案例流水号
objvPubClassCaseQuantitySenateEN.PubClassCaseID = objRow[convPubClassCaseQuantitySenate.PubClassCaseID] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.PubClassCaseID].ToString().Trim(); //案例ID
objvPubClassCaseQuantitySenateEN.PubClassCaseName = objRow[convPubClassCaseQuantitySenate.PubClassCaseName] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.PubClassCaseName].ToString().Trim(); //案例课题名称
objvPubClassCaseQuantitySenateEN.IdsenateGauge = objRow[convPubClassCaseQuantitySenate.IdsenateGauge].ToString().Trim(); //评价量规流水号
objvPubClassCaseQuantitySenateEN.senateGaugeID = objRow[convPubClassCaseQuantitySenate.senateGaugeID] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.senateGaugeID].ToString().Trim(); //评价量规ID
objvPubClassCaseQuantitySenateEN.senateGaugeName = objRow[convPubClassCaseQuantitySenate.senateGaugeName] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.senateGaugeName].ToString().Trim(); //评价量规名称
objvPubClassCaseQuantitySenateEN.pubClassCaseQuantitySenateScore = TransNullToInt(objRow[convPubClassCaseQuantitySenate.pubClassCaseQuantitySenateScore].ToString().Trim()); //评分
objvPubClassCaseQuantitySenateEN.UserId = objRow[convPubClassCaseQuantitySenate.UserId] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.UserId].ToString().Trim(); //用户ID
objvPubClassCaseQuantitySenateEN.UserName = objRow[convPubClassCaseQuantitySenate.UserName] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.UserName].ToString().Trim(); //用户名
objvPubClassCaseQuantitySenateEN.OptDate = objRow[convPubClassCaseQuantitySenate.OptDate] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.OptDate].ToString().Trim(); //OptDate
objvPubClassCaseQuantitySenateEN.CollegeID = objRow[convPubClassCaseQuantitySenate.CollegeID] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.CollegeID].ToString().Trim(); //学院ID
objvPubClassCaseQuantitySenateEN.CollegeName = objRow[convPubClassCaseQuantitySenate.CollegeName] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.CollegeName].ToString().Trim(); //学院名称
objvPubClassCaseQuantitySenateEN.IdXzCollege = objRow[convPubClassCaseQuantitySenate.IdXzCollege] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.IdXzCollege].ToString().Trim(); //学院流水号
objvPubClassCaseQuantitySenateEN.IsLeaved = TransNullToBool(objRow[convPubClassCaseQuantitySenate.IsLeaved].ToString().Trim()); //IsLeaved
objvPubClassCaseQuantitySenateEN.senateGaugeVersionID = objRow[convPubClassCaseQuantitySenate.senateGaugeVersionID] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvPubClassCaseQuantitySenateEN.senateGaugeVersionName = objRow[convPubClassCaseQuantitySenate.senateGaugeVersionName] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvPubClassCaseQuantitySenateEN.senateGaugeVersionTtlScore = objRow[convPubClassCaseQuantitySenate.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convPubClassCaseQuantitySenate.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvPubClassCaseQuantitySenateEN.StuIdTeacherId = objRow[convPubClassCaseQuantitySenate.StuIdTeacherId] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.StuIdTeacherId].ToString().Trim(); //学工号
objvPubClassCaseQuantitySenateEN.IdPubClassCaseSenateGaugeVersion = objRow[convPubClassCaseQuantitySenate.IdPubClassCaseSenateGaugeVersion] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.IdPubClassCaseSenateGaugeVersion].ToString().Trim(); //公开课量表版本流水号
objvPubClassCaseQuantitySenateEN.senateGaugeMemo = objRow[convPubClassCaseQuantitySenate.senateGaugeMemo] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.senateGaugeMemo].ToString().Trim(); //评价量规指标与说明
objvPubClassCaseQuantitySenateEN.SenateGaugeWeight = objRow[convPubClassCaseQuantitySenate.SenateGaugeWeight] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convPubClassCaseQuantitySenate.SenateGaugeWeight].ToString().Trim()); //评价量规权重
objvPubClassCaseQuantitySenateEN.OrderNum = objRow[convPubClassCaseQuantitySenate.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPubClassCaseQuantitySenate.OrderNum].ToString().Trim()); //序号
objvPubClassCaseQuantitySenateEN.senateGaugeNameWithOrder = objRow[convPubClassCaseQuantitySenate.senateGaugeNameWithOrder] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.senateGaugeNameWithOrder].ToString().Trim(); //senateGaugeNameWithOrder
objvPubClassCaseQuantitySenateEN.PubClassCaseExecutor = objRow[convPubClassCaseQuantitySenate.PubClassCaseExecutor] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.PubClassCaseExecutor].ToString().Trim(); //案例执教者
objvPubClassCaseQuantitySenateEN.PubClassCaseTeachDate = objRow[convPubClassCaseQuantitySenate.PubClassCaseTeachDate] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.PubClassCaseTeachDate].ToString().Trim(); //案例授课日期
objvPubClassCaseQuantitySenateEN.UserNameWithUserId = objRow[convPubClassCaseQuantitySenate.UserNameWithUserId] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.UserNameWithUserId].ToString().Trim(); //UserNameWithUserId
objvPubClassCaseQuantitySenateEN.CollegeNameA = objRow[convPubClassCaseQuantitySenate.CollegeNameA] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.CollegeNameA].ToString().Trim(); //学院名称简写
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvPubClassCaseQuantitySenateDA: GetObjLst)", objException.Message));
}
objvPubClassCaseQuantitySenateEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvPubClassCaseQuantitySenateEN);
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
public List<clsvPubClassCaseQuantitySenateEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvPubClassCaseQuantitySenateDA:GetObjLstByTabName)", objException.Message));
}
List<clsvPubClassCaseQuantitySenateEN> arrObjLst = new List<clsvPubClassCaseQuantitySenateEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPubClassCaseQuantitySenateDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPubClassCaseQuantitySenateEN objvPubClassCaseQuantitySenateEN = new clsvPubClassCaseQuantitySenateEN();
try
{
objvPubClassCaseQuantitySenateEN.IdpubClassCaseQuantitySenate = TransNullToInt(objRow[convPubClassCaseQuantitySenate.IdpubClassCaseQuantitySenate].ToString().Trim()); //流水号
objvPubClassCaseQuantitySenateEN.IdPubClassCase = objRow[convPubClassCaseQuantitySenate.IdPubClassCase].ToString().Trim(); //案例流水号
objvPubClassCaseQuantitySenateEN.PubClassCaseID = objRow[convPubClassCaseQuantitySenate.PubClassCaseID] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.PubClassCaseID].ToString().Trim(); //案例ID
objvPubClassCaseQuantitySenateEN.PubClassCaseName = objRow[convPubClassCaseQuantitySenate.PubClassCaseName] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.PubClassCaseName].ToString().Trim(); //案例课题名称
objvPubClassCaseQuantitySenateEN.IdsenateGauge = objRow[convPubClassCaseQuantitySenate.IdsenateGauge].ToString().Trim(); //评价量规流水号
objvPubClassCaseQuantitySenateEN.senateGaugeID = objRow[convPubClassCaseQuantitySenate.senateGaugeID] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.senateGaugeID].ToString().Trim(); //评价量规ID
objvPubClassCaseQuantitySenateEN.senateGaugeName = objRow[convPubClassCaseQuantitySenate.senateGaugeName] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.senateGaugeName].ToString().Trim(); //评价量规名称
objvPubClassCaseQuantitySenateEN.pubClassCaseQuantitySenateScore = TransNullToInt(objRow[convPubClassCaseQuantitySenate.pubClassCaseQuantitySenateScore].ToString().Trim()); //评分
objvPubClassCaseQuantitySenateEN.UserId = objRow[convPubClassCaseQuantitySenate.UserId] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.UserId].ToString().Trim(); //用户ID
objvPubClassCaseQuantitySenateEN.UserName = objRow[convPubClassCaseQuantitySenate.UserName] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.UserName].ToString().Trim(); //用户名
objvPubClassCaseQuantitySenateEN.OptDate = objRow[convPubClassCaseQuantitySenate.OptDate] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.OptDate].ToString().Trim(); //OptDate
objvPubClassCaseQuantitySenateEN.CollegeID = objRow[convPubClassCaseQuantitySenate.CollegeID] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.CollegeID].ToString().Trim(); //学院ID
objvPubClassCaseQuantitySenateEN.CollegeName = objRow[convPubClassCaseQuantitySenate.CollegeName] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.CollegeName].ToString().Trim(); //学院名称
objvPubClassCaseQuantitySenateEN.IdXzCollege = objRow[convPubClassCaseQuantitySenate.IdXzCollege] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.IdXzCollege].ToString().Trim(); //学院流水号
objvPubClassCaseQuantitySenateEN.IsLeaved = TransNullToBool(objRow[convPubClassCaseQuantitySenate.IsLeaved].ToString().Trim()); //IsLeaved
objvPubClassCaseQuantitySenateEN.senateGaugeVersionID = objRow[convPubClassCaseQuantitySenate.senateGaugeVersionID] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvPubClassCaseQuantitySenateEN.senateGaugeVersionName = objRow[convPubClassCaseQuantitySenate.senateGaugeVersionName] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvPubClassCaseQuantitySenateEN.senateGaugeVersionTtlScore = objRow[convPubClassCaseQuantitySenate.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convPubClassCaseQuantitySenate.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvPubClassCaseQuantitySenateEN.StuIdTeacherId = objRow[convPubClassCaseQuantitySenate.StuIdTeacherId] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.StuIdTeacherId].ToString().Trim(); //学工号
objvPubClassCaseQuantitySenateEN.IdPubClassCaseSenateGaugeVersion = objRow[convPubClassCaseQuantitySenate.IdPubClassCaseSenateGaugeVersion] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.IdPubClassCaseSenateGaugeVersion].ToString().Trim(); //公开课量表版本流水号
objvPubClassCaseQuantitySenateEN.senateGaugeMemo = objRow[convPubClassCaseQuantitySenate.senateGaugeMemo] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.senateGaugeMemo].ToString().Trim(); //评价量规指标与说明
objvPubClassCaseQuantitySenateEN.SenateGaugeWeight = objRow[convPubClassCaseQuantitySenate.SenateGaugeWeight] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convPubClassCaseQuantitySenate.SenateGaugeWeight].ToString().Trim()); //评价量规权重
objvPubClassCaseQuantitySenateEN.OrderNum = objRow[convPubClassCaseQuantitySenate.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPubClassCaseQuantitySenate.OrderNum].ToString().Trim()); //序号
objvPubClassCaseQuantitySenateEN.senateGaugeNameWithOrder = objRow[convPubClassCaseQuantitySenate.senateGaugeNameWithOrder] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.senateGaugeNameWithOrder].ToString().Trim(); //senateGaugeNameWithOrder
objvPubClassCaseQuantitySenateEN.PubClassCaseExecutor = objRow[convPubClassCaseQuantitySenate.PubClassCaseExecutor] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.PubClassCaseExecutor].ToString().Trim(); //案例执教者
objvPubClassCaseQuantitySenateEN.PubClassCaseTeachDate = objRow[convPubClassCaseQuantitySenate.PubClassCaseTeachDate] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.PubClassCaseTeachDate].ToString().Trim(); //案例授课日期
objvPubClassCaseQuantitySenateEN.UserNameWithUserId = objRow[convPubClassCaseQuantitySenate.UserNameWithUserId] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.UserNameWithUserId].ToString().Trim(); //UserNameWithUserId
objvPubClassCaseQuantitySenateEN.CollegeNameA = objRow[convPubClassCaseQuantitySenate.CollegeNameA] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.CollegeNameA].ToString().Trim(); //学院名称简写
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvPubClassCaseQuantitySenateDA: GetObjLst)", objException.Message));
}
objvPubClassCaseQuantitySenateEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvPubClassCaseQuantitySenateEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvPubClassCaseQuantitySenateEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvPubClassCaseQuantitySenate(ref clsvPubClassCaseQuantitySenateEN objvPubClassCaseQuantitySenateEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPubClassCaseQuantitySenateDA.GetSpecSQLObj();
strSQL = "Select * from vPubClassCaseQuantitySenate where IdpubClassCaseQuantitySenate = " + ""+ objvPubClassCaseQuantitySenateEN.IdpubClassCaseQuantitySenate+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvPubClassCaseQuantitySenateEN.IdpubClassCaseQuantitySenate = TransNullToInt(objDT.Rows[0][convPubClassCaseQuantitySenate.IdpubClassCaseQuantitySenate].ToString().Trim()); //流水号(字段类型:bigint,字段长度:8,是否可空:False)
 objvPubClassCaseQuantitySenateEN.IdPubClassCase = objDT.Rows[0][convPubClassCaseQuantitySenate.IdPubClassCase].ToString().Trim(); //案例流水号(字段类型:char,字段长度:8,是否可空:False)
 objvPubClassCaseQuantitySenateEN.PubClassCaseID = objDT.Rows[0][convPubClassCaseQuantitySenate.PubClassCaseID].ToString().Trim(); //案例ID(字段类型:char,字段长度:8,是否可空:False)
 objvPubClassCaseQuantitySenateEN.PubClassCaseName = objDT.Rows[0][convPubClassCaseQuantitySenate.PubClassCaseName].ToString().Trim(); //案例课题名称(字段类型:varchar,字段长度:200,是否可空:False)
 objvPubClassCaseQuantitySenateEN.IdsenateGauge = objDT.Rows[0][convPubClassCaseQuantitySenate.IdsenateGauge].ToString().Trim(); //评价量规流水号(字段类型:char,字段长度:4,是否可空:False)
 objvPubClassCaseQuantitySenateEN.senateGaugeID = objDT.Rows[0][convPubClassCaseQuantitySenate.senateGaugeID].ToString().Trim(); //评价量规ID(字段类型:char,字段长度:4,是否可空:False)
 objvPubClassCaseQuantitySenateEN.senateGaugeName = objDT.Rows[0][convPubClassCaseQuantitySenate.senateGaugeName].ToString().Trim(); //评价量规名称(字段类型:varchar,字段长度:200,是否可空:False)
 objvPubClassCaseQuantitySenateEN.pubClassCaseQuantitySenateScore = TransNullToInt(objDT.Rows[0][convPubClassCaseQuantitySenate.pubClassCaseQuantitySenateScore].ToString().Trim()); //评分(字段类型:int,字段长度:4,是否可空:True)
 objvPubClassCaseQuantitySenateEN.UserId = objDT.Rows[0][convPubClassCaseQuantitySenate.UserId].ToString().Trim(); //用户ID(字段类型:varchar,字段长度:18,是否可空:True)
 objvPubClassCaseQuantitySenateEN.UserName = objDT.Rows[0][convPubClassCaseQuantitySenate.UserName].ToString().Trim(); //用户名(字段类型:varchar,字段长度:30,是否可空:True)
 objvPubClassCaseQuantitySenateEN.OptDate = objDT.Rows[0][convPubClassCaseQuantitySenate.OptDate].ToString().Trim(); //OptDate(字段类型:varchar,字段长度:20,是否可空:True)
 objvPubClassCaseQuantitySenateEN.CollegeID = objDT.Rows[0][convPubClassCaseQuantitySenate.CollegeID].ToString().Trim(); //学院ID(字段类型:varchar,字段长度:4,是否可空:False)
 objvPubClassCaseQuantitySenateEN.CollegeName = objDT.Rows[0][convPubClassCaseQuantitySenate.CollegeName].ToString().Trim(); //学院名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvPubClassCaseQuantitySenateEN.IdXzCollege = objDT.Rows[0][convPubClassCaseQuantitySenate.IdXzCollege].ToString().Trim(); //学院流水号(字段类型:char,字段长度:4,是否可空:True)
 objvPubClassCaseQuantitySenateEN.IsLeaved = TransNullToBool(objDT.Rows[0][convPubClassCaseQuantitySenate.IsLeaved].ToString().Trim()); //IsLeaved(字段类型:bit,字段长度:1,是否可空:True)
 objvPubClassCaseQuantitySenateEN.senateGaugeVersionID = objDT.Rows[0][convPubClassCaseQuantitySenate.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID(字段类型:char,字段长度:4,是否可空:False)
 objvPubClassCaseQuantitySenateEN.senateGaugeVersionName = objDT.Rows[0][convPubClassCaseQuantitySenate.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称(字段类型:varchar,字段长度:200,是否可空:True)
 objvPubClassCaseQuantitySenateEN.senateGaugeVersionTtlScore = TransNullToFloat(objDT.Rows[0][convPubClassCaseQuantitySenate.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分(字段类型:float,字段长度:8,是否可空:False)
 objvPubClassCaseQuantitySenateEN.StuIdTeacherId = objDT.Rows[0][convPubClassCaseQuantitySenate.StuIdTeacherId].ToString().Trim(); //学工号(字段类型:varchar,字段长度:20,是否可空:True)
 objvPubClassCaseQuantitySenateEN.IdPubClassCaseSenateGaugeVersion = objDT.Rows[0][convPubClassCaseQuantitySenate.IdPubClassCaseSenateGaugeVersion].ToString().Trim(); //公开课量表版本流水号(字段类型:char,字段长度:4,是否可空:False)
 objvPubClassCaseQuantitySenateEN.senateGaugeMemo = objDT.Rows[0][convPubClassCaseQuantitySenate.senateGaugeMemo].ToString().Trim(); //评价量规指标与说明(字段类型:varchar,字段长度:1000,是否可空:True)
 objvPubClassCaseQuantitySenateEN.SenateGaugeWeight = TransNullToFloat(objDT.Rows[0][convPubClassCaseQuantitySenate.SenateGaugeWeight].ToString().Trim()); //评价量规权重(字段类型:float,字段长度:8,是否可空:True)
 objvPubClassCaseQuantitySenateEN.OrderNum = TransNullToInt(objDT.Rows[0][convPubClassCaseQuantitySenate.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:True)
 objvPubClassCaseQuantitySenateEN.senateGaugeNameWithOrder = objDT.Rows[0][convPubClassCaseQuantitySenate.senateGaugeNameWithOrder].ToString().Trim(); //senateGaugeNameWithOrder(字段类型:varchar,字段长度:204,是否可空:True)
 objvPubClassCaseQuantitySenateEN.PubClassCaseExecutor = objDT.Rows[0][convPubClassCaseQuantitySenate.PubClassCaseExecutor].ToString().Trim(); //案例执教者(字段类型:varchar,字段长度:50,是否可空:True)
 objvPubClassCaseQuantitySenateEN.PubClassCaseTeachDate = objDT.Rows[0][convPubClassCaseQuantitySenate.PubClassCaseTeachDate].ToString().Trim(); //案例授课日期(字段类型:char,字段长度:8,是否可空:True)
 objvPubClassCaseQuantitySenateEN.UserNameWithUserId = objDT.Rows[0][convPubClassCaseQuantitySenate.UserNameWithUserId].ToString().Trim(); //UserNameWithUserId(字段类型:varchar,字段长度:51,是否可空:False)
 objvPubClassCaseQuantitySenateEN.CollegeNameA = objDT.Rows[0][convPubClassCaseQuantitySenate.CollegeNameA].ToString().Trim(); //学院名称简写(字段类型:varchar,字段长度:12,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvPubClassCaseQuantitySenateDA: GetvPubClassCaseQuantitySenate)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngIdpubClassCaseQuantitySenate">表关键字</param>
 /// <returns>表对象</returns>
public clsvPubClassCaseQuantitySenateEN GetObjByIdpubClassCaseQuantitySenate(long lngIdpubClassCaseQuantitySenate)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPubClassCaseQuantitySenateDA.GetSpecSQLObj();
strSQL = "Select * from vPubClassCaseQuantitySenate where IdpubClassCaseQuantitySenate = " + ""+ lngIdpubClassCaseQuantitySenate+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvPubClassCaseQuantitySenateEN objvPubClassCaseQuantitySenateEN = new clsvPubClassCaseQuantitySenateEN();
try
{
 objvPubClassCaseQuantitySenateEN.IdpubClassCaseQuantitySenate = Int32.Parse(objRow[convPubClassCaseQuantitySenate.IdpubClassCaseQuantitySenate].ToString().Trim()); //流水号(字段类型:bigint,字段长度:8,是否可空:False)
 objvPubClassCaseQuantitySenateEN.IdPubClassCase = objRow[convPubClassCaseQuantitySenate.IdPubClassCase].ToString().Trim(); //案例流水号(字段类型:char,字段长度:8,是否可空:False)
 objvPubClassCaseQuantitySenateEN.PubClassCaseID = objRow[convPubClassCaseQuantitySenate.PubClassCaseID] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.PubClassCaseID].ToString().Trim(); //案例ID(字段类型:char,字段长度:8,是否可空:False)
 objvPubClassCaseQuantitySenateEN.PubClassCaseName = objRow[convPubClassCaseQuantitySenate.PubClassCaseName] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.PubClassCaseName].ToString().Trim(); //案例课题名称(字段类型:varchar,字段长度:200,是否可空:False)
 objvPubClassCaseQuantitySenateEN.IdsenateGauge = objRow[convPubClassCaseQuantitySenate.IdsenateGauge].ToString().Trim(); //评价量规流水号(字段类型:char,字段长度:4,是否可空:False)
 objvPubClassCaseQuantitySenateEN.senateGaugeID = objRow[convPubClassCaseQuantitySenate.senateGaugeID] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.senateGaugeID].ToString().Trim(); //评价量规ID(字段类型:char,字段长度:4,是否可空:False)
 objvPubClassCaseQuantitySenateEN.senateGaugeName = objRow[convPubClassCaseQuantitySenate.senateGaugeName] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.senateGaugeName].ToString().Trim(); //评价量规名称(字段类型:varchar,字段长度:200,是否可空:False)
 objvPubClassCaseQuantitySenateEN.pubClassCaseQuantitySenateScore = Int32.Parse(objRow[convPubClassCaseQuantitySenate.pubClassCaseQuantitySenateScore].ToString().Trim()); //评分(字段类型:int,字段长度:4,是否可空:True)
 objvPubClassCaseQuantitySenateEN.UserId = objRow[convPubClassCaseQuantitySenate.UserId] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.UserId].ToString().Trim(); //用户ID(字段类型:varchar,字段长度:18,是否可空:True)
 objvPubClassCaseQuantitySenateEN.UserName = objRow[convPubClassCaseQuantitySenate.UserName] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.UserName].ToString().Trim(); //用户名(字段类型:varchar,字段长度:30,是否可空:True)
 objvPubClassCaseQuantitySenateEN.OptDate = objRow[convPubClassCaseQuantitySenate.OptDate] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.OptDate].ToString().Trim(); //OptDate(字段类型:varchar,字段长度:20,是否可空:True)
 objvPubClassCaseQuantitySenateEN.CollegeID = objRow[convPubClassCaseQuantitySenate.CollegeID] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.CollegeID].ToString().Trim(); //学院ID(字段类型:varchar,字段长度:4,是否可空:False)
 objvPubClassCaseQuantitySenateEN.CollegeName = objRow[convPubClassCaseQuantitySenate.CollegeName] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.CollegeName].ToString().Trim(); //学院名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvPubClassCaseQuantitySenateEN.IdXzCollege = objRow[convPubClassCaseQuantitySenate.IdXzCollege] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.IdXzCollege].ToString().Trim(); //学院流水号(字段类型:char,字段长度:4,是否可空:True)
 objvPubClassCaseQuantitySenateEN.IsLeaved = clsEntityBase2.TransNullToBool_S(objRow[convPubClassCaseQuantitySenate.IsLeaved].ToString().Trim()); //IsLeaved(字段类型:bit,字段长度:1,是否可空:True)
 objvPubClassCaseQuantitySenateEN.senateGaugeVersionID = objRow[convPubClassCaseQuantitySenate.senateGaugeVersionID] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID(字段类型:char,字段长度:4,是否可空:False)
 objvPubClassCaseQuantitySenateEN.senateGaugeVersionName = objRow[convPubClassCaseQuantitySenate.senateGaugeVersionName] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称(字段类型:varchar,字段长度:200,是否可空:True)
 objvPubClassCaseQuantitySenateEN.senateGaugeVersionTtlScore = objRow[convPubClassCaseQuantitySenate.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convPubClassCaseQuantitySenate.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分(字段类型:float,字段长度:8,是否可空:False)
 objvPubClassCaseQuantitySenateEN.StuIdTeacherId = objRow[convPubClassCaseQuantitySenate.StuIdTeacherId] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.StuIdTeacherId].ToString().Trim(); //学工号(字段类型:varchar,字段长度:20,是否可空:True)
 objvPubClassCaseQuantitySenateEN.IdPubClassCaseSenateGaugeVersion = objRow[convPubClassCaseQuantitySenate.IdPubClassCaseSenateGaugeVersion] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.IdPubClassCaseSenateGaugeVersion].ToString().Trim(); //公开课量表版本流水号(字段类型:char,字段长度:4,是否可空:False)
 objvPubClassCaseQuantitySenateEN.senateGaugeMemo = objRow[convPubClassCaseQuantitySenate.senateGaugeMemo] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.senateGaugeMemo].ToString().Trim(); //评价量规指标与说明(字段类型:varchar,字段长度:1000,是否可空:True)
 objvPubClassCaseQuantitySenateEN.SenateGaugeWeight = objRow[convPubClassCaseQuantitySenate.SenateGaugeWeight] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convPubClassCaseQuantitySenate.SenateGaugeWeight].ToString().Trim()); //评价量规权重(字段类型:float,字段长度:8,是否可空:True)
 objvPubClassCaseQuantitySenateEN.OrderNum = objRow[convPubClassCaseQuantitySenate.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPubClassCaseQuantitySenate.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:True)
 objvPubClassCaseQuantitySenateEN.senateGaugeNameWithOrder = objRow[convPubClassCaseQuantitySenate.senateGaugeNameWithOrder] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.senateGaugeNameWithOrder].ToString().Trim(); //senateGaugeNameWithOrder(字段类型:varchar,字段长度:204,是否可空:True)
 objvPubClassCaseQuantitySenateEN.PubClassCaseExecutor = objRow[convPubClassCaseQuantitySenate.PubClassCaseExecutor] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.PubClassCaseExecutor].ToString().Trim(); //案例执教者(字段类型:varchar,字段长度:50,是否可空:True)
 objvPubClassCaseQuantitySenateEN.PubClassCaseTeachDate = objRow[convPubClassCaseQuantitySenate.PubClassCaseTeachDate] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.PubClassCaseTeachDate].ToString().Trim(); //案例授课日期(字段类型:char,字段长度:8,是否可空:True)
 objvPubClassCaseQuantitySenateEN.UserNameWithUserId = objRow[convPubClassCaseQuantitySenate.UserNameWithUserId] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.UserNameWithUserId].ToString().Trim(); //UserNameWithUserId(字段类型:varchar,字段长度:51,是否可空:False)
 objvPubClassCaseQuantitySenateEN.CollegeNameA = objRow[convPubClassCaseQuantitySenate.CollegeNameA] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.CollegeNameA].ToString().Trim(); //学院名称简写(字段类型:varchar,字段长度:12,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvPubClassCaseQuantitySenateDA: GetObjByIdpubClassCaseQuantitySenate)", objException.Message));
}
return objvPubClassCaseQuantitySenateEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvPubClassCaseQuantitySenateEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvPubClassCaseQuantitySenateDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPubClassCaseQuantitySenateDA.GetSpecSQLObj();
strSQL = "Select * from vPubClassCaseQuantitySenate where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvPubClassCaseQuantitySenateEN objvPubClassCaseQuantitySenateEN = new clsvPubClassCaseQuantitySenateEN()
{
IdpubClassCaseQuantitySenate = TransNullToInt(objRow[convPubClassCaseQuantitySenate.IdpubClassCaseQuantitySenate].ToString().Trim()), //流水号
IdPubClassCase = objRow[convPubClassCaseQuantitySenate.IdPubClassCase].ToString().Trim(), //案例流水号
PubClassCaseID = objRow[convPubClassCaseQuantitySenate.PubClassCaseID] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.PubClassCaseID].ToString().Trim(), //案例ID
PubClassCaseName = objRow[convPubClassCaseQuantitySenate.PubClassCaseName] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.PubClassCaseName].ToString().Trim(), //案例课题名称
IdsenateGauge = objRow[convPubClassCaseQuantitySenate.IdsenateGauge].ToString().Trim(), //评价量规流水号
senateGaugeID = objRow[convPubClassCaseQuantitySenate.senateGaugeID] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.senateGaugeID].ToString().Trim(), //评价量规ID
senateGaugeName = objRow[convPubClassCaseQuantitySenate.senateGaugeName] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.senateGaugeName].ToString().Trim(), //评价量规名称
pubClassCaseQuantitySenateScore = TransNullToInt(objRow[convPubClassCaseQuantitySenate.pubClassCaseQuantitySenateScore].ToString().Trim()), //评分
UserId = objRow[convPubClassCaseQuantitySenate.UserId] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.UserId].ToString().Trim(), //用户ID
UserName = objRow[convPubClassCaseQuantitySenate.UserName] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.UserName].ToString().Trim(), //用户名
OptDate = objRow[convPubClassCaseQuantitySenate.OptDate] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.OptDate].ToString().Trim(), //OptDate
CollegeID = objRow[convPubClassCaseQuantitySenate.CollegeID] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.CollegeID].ToString().Trim(), //学院ID
CollegeName = objRow[convPubClassCaseQuantitySenate.CollegeName] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.CollegeName].ToString().Trim(), //学院名称
IdXzCollege = objRow[convPubClassCaseQuantitySenate.IdXzCollege] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.IdXzCollege].ToString().Trim(), //学院流水号
IsLeaved = TransNullToBool(objRow[convPubClassCaseQuantitySenate.IsLeaved].ToString().Trim()), //IsLeaved
senateGaugeVersionID = objRow[convPubClassCaseQuantitySenate.senateGaugeVersionID] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.senateGaugeVersionID].ToString().Trim(), //评价量表版本ID
senateGaugeVersionName = objRow[convPubClassCaseQuantitySenate.senateGaugeVersionName] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.senateGaugeVersionName].ToString().Trim(), //评价量表版本名称
senateGaugeVersionTtlScore = objRow[convPubClassCaseQuantitySenate.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convPubClassCaseQuantitySenate.senateGaugeVersionTtlScore].ToString().Trim()), //评价量表版本总分
StuIdTeacherId = objRow[convPubClassCaseQuantitySenate.StuIdTeacherId] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.StuIdTeacherId].ToString().Trim(), //学工号
IdPubClassCaseSenateGaugeVersion = objRow[convPubClassCaseQuantitySenate.IdPubClassCaseSenateGaugeVersion] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.IdPubClassCaseSenateGaugeVersion].ToString().Trim(), //公开课量表版本流水号
senateGaugeMemo = objRow[convPubClassCaseQuantitySenate.senateGaugeMemo] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.senateGaugeMemo].ToString().Trim(), //评价量规指标与说明
SenateGaugeWeight = objRow[convPubClassCaseQuantitySenate.SenateGaugeWeight] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convPubClassCaseQuantitySenate.SenateGaugeWeight].ToString().Trim()), //评价量规权重
OrderNum = objRow[convPubClassCaseQuantitySenate.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPubClassCaseQuantitySenate.OrderNum].ToString().Trim()), //序号
senateGaugeNameWithOrder = objRow[convPubClassCaseQuantitySenate.senateGaugeNameWithOrder] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.senateGaugeNameWithOrder].ToString().Trim(), //senateGaugeNameWithOrder
PubClassCaseExecutor = objRow[convPubClassCaseQuantitySenate.PubClassCaseExecutor] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.PubClassCaseExecutor].ToString().Trim(), //案例执教者
PubClassCaseTeachDate = objRow[convPubClassCaseQuantitySenate.PubClassCaseTeachDate] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.PubClassCaseTeachDate].ToString().Trim(), //案例授课日期
UserNameWithUserId = objRow[convPubClassCaseQuantitySenate.UserNameWithUserId] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.UserNameWithUserId].ToString().Trim(), //UserNameWithUserId
CollegeNameA = objRow[convPubClassCaseQuantitySenate.CollegeNameA] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.CollegeNameA].ToString().Trim() //学院名称简写
};
objvPubClassCaseQuantitySenateEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvPubClassCaseQuantitySenateEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvPubClassCaseQuantitySenateDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvPubClassCaseQuantitySenateEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvPubClassCaseQuantitySenateEN objvPubClassCaseQuantitySenateEN = new clsvPubClassCaseQuantitySenateEN();
try
{
objvPubClassCaseQuantitySenateEN.IdpubClassCaseQuantitySenate = TransNullToInt(objRow[convPubClassCaseQuantitySenate.IdpubClassCaseQuantitySenate].ToString().Trim()); //流水号
objvPubClassCaseQuantitySenateEN.IdPubClassCase = objRow[convPubClassCaseQuantitySenate.IdPubClassCase].ToString().Trim(); //案例流水号
objvPubClassCaseQuantitySenateEN.PubClassCaseID = objRow[convPubClassCaseQuantitySenate.PubClassCaseID] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.PubClassCaseID].ToString().Trim(); //案例ID
objvPubClassCaseQuantitySenateEN.PubClassCaseName = objRow[convPubClassCaseQuantitySenate.PubClassCaseName] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.PubClassCaseName].ToString().Trim(); //案例课题名称
objvPubClassCaseQuantitySenateEN.IdsenateGauge = objRow[convPubClassCaseQuantitySenate.IdsenateGauge].ToString().Trim(); //评价量规流水号
objvPubClassCaseQuantitySenateEN.senateGaugeID = objRow[convPubClassCaseQuantitySenate.senateGaugeID] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.senateGaugeID].ToString().Trim(); //评价量规ID
objvPubClassCaseQuantitySenateEN.senateGaugeName = objRow[convPubClassCaseQuantitySenate.senateGaugeName] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.senateGaugeName].ToString().Trim(); //评价量规名称
objvPubClassCaseQuantitySenateEN.pubClassCaseQuantitySenateScore = TransNullToInt(objRow[convPubClassCaseQuantitySenate.pubClassCaseQuantitySenateScore].ToString().Trim()); //评分
objvPubClassCaseQuantitySenateEN.UserId = objRow[convPubClassCaseQuantitySenate.UserId] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.UserId].ToString().Trim(); //用户ID
objvPubClassCaseQuantitySenateEN.UserName = objRow[convPubClassCaseQuantitySenate.UserName] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.UserName].ToString().Trim(); //用户名
objvPubClassCaseQuantitySenateEN.OptDate = objRow[convPubClassCaseQuantitySenate.OptDate] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.OptDate].ToString().Trim(); //OptDate
objvPubClassCaseQuantitySenateEN.CollegeID = objRow[convPubClassCaseQuantitySenate.CollegeID] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.CollegeID].ToString().Trim(); //学院ID
objvPubClassCaseQuantitySenateEN.CollegeName = objRow[convPubClassCaseQuantitySenate.CollegeName] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.CollegeName].ToString().Trim(); //学院名称
objvPubClassCaseQuantitySenateEN.IdXzCollege = objRow[convPubClassCaseQuantitySenate.IdXzCollege] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.IdXzCollege].ToString().Trim(); //学院流水号
objvPubClassCaseQuantitySenateEN.IsLeaved = TransNullToBool(objRow[convPubClassCaseQuantitySenate.IsLeaved].ToString().Trim()); //IsLeaved
objvPubClassCaseQuantitySenateEN.senateGaugeVersionID = objRow[convPubClassCaseQuantitySenate.senateGaugeVersionID] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvPubClassCaseQuantitySenateEN.senateGaugeVersionName = objRow[convPubClassCaseQuantitySenate.senateGaugeVersionName] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvPubClassCaseQuantitySenateEN.senateGaugeVersionTtlScore = objRow[convPubClassCaseQuantitySenate.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convPubClassCaseQuantitySenate.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvPubClassCaseQuantitySenateEN.StuIdTeacherId = objRow[convPubClassCaseQuantitySenate.StuIdTeacherId] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.StuIdTeacherId].ToString().Trim(); //学工号
objvPubClassCaseQuantitySenateEN.IdPubClassCaseSenateGaugeVersion = objRow[convPubClassCaseQuantitySenate.IdPubClassCaseSenateGaugeVersion] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.IdPubClassCaseSenateGaugeVersion].ToString().Trim(); //公开课量表版本流水号
objvPubClassCaseQuantitySenateEN.senateGaugeMemo = objRow[convPubClassCaseQuantitySenate.senateGaugeMemo] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.senateGaugeMemo].ToString().Trim(); //评价量规指标与说明
objvPubClassCaseQuantitySenateEN.SenateGaugeWeight = objRow[convPubClassCaseQuantitySenate.SenateGaugeWeight] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convPubClassCaseQuantitySenate.SenateGaugeWeight].ToString().Trim()); //评价量规权重
objvPubClassCaseQuantitySenateEN.OrderNum = objRow[convPubClassCaseQuantitySenate.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPubClassCaseQuantitySenate.OrderNum].ToString().Trim()); //序号
objvPubClassCaseQuantitySenateEN.senateGaugeNameWithOrder = objRow[convPubClassCaseQuantitySenate.senateGaugeNameWithOrder] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.senateGaugeNameWithOrder].ToString().Trim(); //senateGaugeNameWithOrder
objvPubClassCaseQuantitySenateEN.PubClassCaseExecutor = objRow[convPubClassCaseQuantitySenate.PubClassCaseExecutor] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.PubClassCaseExecutor].ToString().Trim(); //案例执教者
objvPubClassCaseQuantitySenateEN.PubClassCaseTeachDate = objRow[convPubClassCaseQuantitySenate.PubClassCaseTeachDate] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.PubClassCaseTeachDate].ToString().Trim(); //案例授课日期
objvPubClassCaseQuantitySenateEN.UserNameWithUserId = objRow[convPubClassCaseQuantitySenate.UserNameWithUserId] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.UserNameWithUserId].ToString().Trim(); //UserNameWithUserId
objvPubClassCaseQuantitySenateEN.CollegeNameA = objRow[convPubClassCaseQuantitySenate.CollegeNameA] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.CollegeNameA].ToString().Trim(); //学院名称简写
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvPubClassCaseQuantitySenateDA: GetObjByDataRowvPubClassCaseQuantitySenate)", objException.Message));
}
objvPubClassCaseQuantitySenateEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvPubClassCaseQuantitySenateEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvPubClassCaseQuantitySenateEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvPubClassCaseQuantitySenateEN objvPubClassCaseQuantitySenateEN = new clsvPubClassCaseQuantitySenateEN();
try
{
objvPubClassCaseQuantitySenateEN.IdpubClassCaseQuantitySenate = TransNullToInt(objRow[convPubClassCaseQuantitySenate.IdpubClassCaseQuantitySenate].ToString().Trim()); //流水号
objvPubClassCaseQuantitySenateEN.IdPubClassCase = objRow[convPubClassCaseQuantitySenate.IdPubClassCase].ToString().Trim(); //案例流水号
objvPubClassCaseQuantitySenateEN.PubClassCaseID = objRow[convPubClassCaseQuantitySenate.PubClassCaseID] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.PubClassCaseID].ToString().Trim(); //案例ID
objvPubClassCaseQuantitySenateEN.PubClassCaseName = objRow[convPubClassCaseQuantitySenate.PubClassCaseName] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.PubClassCaseName].ToString().Trim(); //案例课题名称
objvPubClassCaseQuantitySenateEN.IdsenateGauge = objRow[convPubClassCaseQuantitySenate.IdsenateGauge].ToString().Trim(); //评价量规流水号
objvPubClassCaseQuantitySenateEN.senateGaugeID = objRow[convPubClassCaseQuantitySenate.senateGaugeID] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.senateGaugeID].ToString().Trim(); //评价量规ID
objvPubClassCaseQuantitySenateEN.senateGaugeName = objRow[convPubClassCaseQuantitySenate.senateGaugeName] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.senateGaugeName].ToString().Trim(); //评价量规名称
objvPubClassCaseQuantitySenateEN.pubClassCaseQuantitySenateScore = TransNullToInt(objRow[convPubClassCaseQuantitySenate.pubClassCaseQuantitySenateScore].ToString().Trim()); //评分
objvPubClassCaseQuantitySenateEN.UserId = objRow[convPubClassCaseQuantitySenate.UserId] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.UserId].ToString().Trim(); //用户ID
objvPubClassCaseQuantitySenateEN.UserName = objRow[convPubClassCaseQuantitySenate.UserName] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.UserName].ToString().Trim(); //用户名
objvPubClassCaseQuantitySenateEN.OptDate = objRow[convPubClassCaseQuantitySenate.OptDate] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.OptDate].ToString().Trim(); //OptDate
objvPubClassCaseQuantitySenateEN.CollegeID = objRow[convPubClassCaseQuantitySenate.CollegeID] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.CollegeID].ToString().Trim(); //学院ID
objvPubClassCaseQuantitySenateEN.CollegeName = objRow[convPubClassCaseQuantitySenate.CollegeName] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.CollegeName].ToString().Trim(); //学院名称
objvPubClassCaseQuantitySenateEN.IdXzCollege = objRow[convPubClassCaseQuantitySenate.IdXzCollege] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.IdXzCollege].ToString().Trim(); //学院流水号
objvPubClassCaseQuantitySenateEN.IsLeaved = TransNullToBool(objRow[convPubClassCaseQuantitySenate.IsLeaved].ToString().Trim()); //IsLeaved
objvPubClassCaseQuantitySenateEN.senateGaugeVersionID = objRow[convPubClassCaseQuantitySenate.senateGaugeVersionID] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvPubClassCaseQuantitySenateEN.senateGaugeVersionName = objRow[convPubClassCaseQuantitySenate.senateGaugeVersionName] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvPubClassCaseQuantitySenateEN.senateGaugeVersionTtlScore = objRow[convPubClassCaseQuantitySenate.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convPubClassCaseQuantitySenate.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvPubClassCaseQuantitySenateEN.StuIdTeacherId = objRow[convPubClassCaseQuantitySenate.StuIdTeacherId] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.StuIdTeacherId].ToString().Trim(); //学工号
objvPubClassCaseQuantitySenateEN.IdPubClassCaseSenateGaugeVersion = objRow[convPubClassCaseQuantitySenate.IdPubClassCaseSenateGaugeVersion] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.IdPubClassCaseSenateGaugeVersion].ToString().Trim(); //公开课量表版本流水号
objvPubClassCaseQuantitySenateEN.senateGaugeMemo = objRow[convPubClassCaseQuantitySenate.senateGaugeMemo] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.senateGaugeMemo].ToString().Trim(); //评价量规指标与说明
objvPubClassCaseQuantitySenateEN.SenateGaugeWeight = objRow[convPubClassCaseQuantitySenate.SenateGaugeWeight] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convPubClassCaseQuantitySenate.SenateGaugeWeight].ToString().Trim()); //评价量规权重
objvPubClassCaseQuantitySenateEN.OrderNum = objRow[convPubClassCaseQuantitySenate.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPubClassCaseQuantitySenate.OrderNum].ToString().Trim()); //序号
objvPubClassCaseQuantitySenateEN.senateGaugeNameWithOrder = objRow[convPubClassCaseQuantitySenate.senateGaugeNameWithOrder] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.senateGaugeNameWithOrder].ToString().Trim(); //senateGaugeNameWithOrder
objvPubClassCaseQuantitySenateEN.PubClassCaseExecutor = objRow[convPubClassCaseQuantitySenate.PubClassCaseExecutor] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.PubClassCaseExecutor].ToString().Trim(); //案例执教者
objvPubClassCaseQuantitySenateEN.PubClassCaseTeachDate = objRow[convPubClassCaseQuantitySenate.PubClassCaseTeachDate] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.PubClassCaseTeachDate].ToString().Trim(); //案例授课日期
objvPubClassCaseQuantitySenateEN.UserNameWithUserId = objRow[convPubClassCaseQuantitySenate.UserNameWithUserId] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.UserNameWithUserId].ToString().Trim(); //UserNameWithUserId
objvPubClassCaseQuantitySenateEN.CollegeNameA = objRow[convPubClassCaseQuantitySenate.CollegeNameA] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.CollegeNameA].ToString().Trim(); //学院名称简写
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvPubClassCaseQuantitySenateDA: GetObjByDataRow)", objException.Message));
}
objvPubClassCaseQuantitySenateEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvPubClassCaseQuantitySenateEN;
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
objSQL = clsvPubClassCaseQuantitySenateDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvPubClassCaseQuantitySenateEN._CurrTabName, convPubClassCaseQuantitySenate.IdpubClassCaseQuantitySenate, 8, "");
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
objSQL = clsvPubClassCaseQuantitySenateDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvPubClassCaseQuantitySenateEN._CurrTabName, convPubClassCaseQuantitySenate.IdpubClassCaseQuantitySenate, 8, strPrefix);
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
 objSQL = clsvPubClassCaseQuantitySenateDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select IdpubClassCaseQuantitySenate from vPubClassCaseQuantitySenate where " + strCondition;
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
 objSQL = clsvPubClassCaseQuantitySenateDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select IdpubClassCaseQuantitySenate from vPubClassCaseQuantitySenate where " + strCondition;
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
 /// <param name = "lngIdpubClassCaseQuantitySenate">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(long lngIdpubClassCaseQuantitySenate)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPubClassCaseQuantitySenateDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vPubClassCaseQuantitySenate", "IdpubClassCaseQuantitySenate = " + ""+ lngIdpubClassCaseQuantitySenate+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvPubClassCaseQuantitySenateDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPubClassCaseQuantitySenateDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vPubClassCaseQuantitySenate", strCondition))
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
objSQL = clsvPubClassCaseQuantitySenateDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vPubClassCaseQuantitySenate");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvPubClassCaseQuantitySenateENS">源对象</param>
 /// <param name = "objvPubClassCaseQuantitySenateENT">目标对象</param>
public void CopyTo(clsvPubClassCaseQuantitySenateEN objvPubClassCaseQuantitySenateENS, clsvPubClassCaseQuantitySenateEN objvPubClassCaseQuantitySenateENT)
{
objvPubClassCaseQuantitySenateENT.IdpubClassCaseQuantitySenate = objvPubClassCaseQuantitySenateENS.IdpubClassCaseQuantitySenate; //流水号
objvPubClassCaseQuantitySenateENT.IdPubClassCase = objvPubClassCaseQuantitySenateENS.IdPubClassCase; //案例流水号
objvPubClassCaseQuantitySenateENT.PubClassCaseID = objvPubClassCaseQuantitySenateENS.PubClassCaseID; //案例ID
objvPubClassCaseQuantitySenateENT.PubClassCaseName = objvPubClassCaseQuantitySenateENS.PubClassCaseName; //案例课题名称
objvPubClassCaseQuantitySenateENT.IdsenateGauge = objvPubClassCaseQuantitySenateENS.IdsenateGauge; //评价量规流水号
objvPubClassCaseQuantitySenateENT.senateGaugeID = objvPubClassCaseQuantitySenateENS.senateGaugeID; //评价量规ID
objvPubClassCaseQuantitySenateENT.senateGaugeName = objvPubClassCaseQuantitySenateENS.senateGaugeName; //评价量规名称
objvPubClassCaseQuantitySenateENT.pubClassCaseQuantitySenateScore = objvPubClassCaseQuantitySenateENS.pubClassCaseQuantitySenateScore; //评分
objvPubClassCaseQuantitySenateENT.UserId = objvPubClassCaseQuantitySenateENS.UserId; //用户ID
objvPubClassCaseQuantitySenateENT.UserName = objvPubClassCaseQuantitySenateENS.UserName; //用户名
objvPubClassCaseQuantitySenateENT.OptDate = objvPubClassCaseQuantitySenateENS.OptDate; //OptDate
objvPubClassCaseQuantitySenateENT.CollegeID = objvPubClassCaseQuantitySenateENS.CollegeID; //学院ID
objvPubClassCaseQuantitySenateENT.CollegeName = objvPubClassCaseQuantitySenateENS.CollegeName; //学院名称
objvPubClassCaseQuantitySenateENT.IdXzCollege = objvPubClassCaseQuantitySenateENS.IdXzCollege; //学院流水号
objvPubClassCaseQuantitySenateENT.IsLeaved = objvPubClassCaseQuantitySenateENS.IsLeaved; //IsLeaved
objvPubClassCaseQuantitySenateENT.senateGaugeVersionID = objvPubClassCaseQuantitySenateENS.senateGaugeVersionID; //评价量表版本ID
objvPubClassCaseQuantitySenateENT.senateGaugeVersionName = objvPubClassCaseQuantitySenateENS.senateGaugeVersionName; //评价量表版本名称
objvPubClassCaseQuantitySenateENT.senateGaugeVersionTtlScore = objvPubClassCaseQuantitySenateENS.senateGaugeVersionTtlScore; //评价量表版本总分
objvPubClassCaseQuantitySenateENT.StuIdTeacherId = objvPubClassCaseQuantitySenateENS.StuIdTeacherId; //学工号
objvPubClassCaseQuantitySenateENT.IdPubClassCaseSenateGaugeVersion = objvPubClassCaseQuantitySenateENS.IdPubClassCaseSenateGaugeVersion; //公开课量表版本流水号
objvPubClassCaseQuantitySenateENT.senateGaugeMemo = objvPubClassCaseQuantitySenateENS.senateGaugeMemo; //评价量规指标与说明
objvPubClassCaseQuantitySenateENT.SenateGaugeWeight = objvPubClassCaseQuantitySenateENS.SenateGaugeWeight; //评价量规权重
objvPubClassCaseQuantitySenateENT.OrderNum = objvPubClassCaseQuantitySenateENS.OrderNum; //序号
objvPubClassCaseQuantitySenateENT.senateGaugeNameWithOrder = objvPubClassCaseQuantitySenateENS.senateGaugeNameWithOrder; //senateGaugeNameWithOrder
objvPubClassCaseQuantitySenateENT.PubClassCaseExecutor = objvPubClassCaseQuantitySenateENS.PubClassCaseExecutor; //案例执教者
objvPubClassCaseQuantitySenateENT.PubClassCaseTeachDate = objvPubClassCaseQuantitySenateENS.PubClassCaseTeachDate; //案例授课日期
objvPubClassCaseQuantitySenateENT.UserNameWithUserId = objvPubClassCaseQuantitySenateENS.UserNameWithUserId; //UserNameWithUserId
objvPubClassCaseQuantitySenateENT.CollegeNameA = objvPubClassCaseQuantitySenateENS.CollegeNameA; //学院名称简写
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvPubClassCaseQuantitySenateEN objvPubClassCaseQuantitySenateEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvPubClassCaseQuantitySenateEN.IdPubClassCase, 8, convPubClassCaseQuantitySenate.IdPubClassCase);
clsCheckSql.CheckFieldLen(objvPubClassCaseQuantitySenateEN.PubClassCaseID, 8, convPubClassCaseQuantitySenate.PubClassCaseID);
clsCheckSql.CheckFieldLen(objvPubClassCaseQuantitySenateEN.PubClassCaseName, 200, convPubClassCaseQuantitySenate.PubClassCaseName);
clsCheckSql.CheckFieldLen(objvPubClassCaseQuantitySenateEN.IdsenateGauge, 4, convPubClassCaseQuantitySenate.IdsenateGauge);
clsCheckSql.CheckFieldLen(objvPubClassCaseQuantitySenateEN.senateGaugeID, 4, convPubClassCaseQuantitySenate.senateGaugeID);
clsCheckSql.CheckFieldLen(objvPubClassCaseQuantitySenateEN.senateGaugeName, 200, convPubClassCaseQuantitySenate.senateGaugeName);
clsCheckSql.CheckFieldLen(objvPubClassCaseQuantitySenateEN.UserId, 18, convPubClassCaseQuantitySenate.UserId);
clsCheckSql.CheckFieldLen(objvPubClassCaseQuantitySenateEN.UserName, 30, convPubClassCaseQuantitySenate.UserName);
clsCheckSql.CheckFieldLen(objvPubClassCaseQuantitySenateEN.OptDate, 20, convPubClassCaseQuantitySenate.OptDate);
clsCheckSql.CheckFieldLen(objvPubClassCaseQuantitySenateEN.CollegeID, 4, convPubClassCaseQuantitySenate.CollegeID);
clsCheckSql.CheckFieldLen(objvPubClassCaseQuantitySenateEN.CollegeName, 100, convPubClassCaseQuantitySenate.CollegeName);
clsCheckSql.CheckFieldLen(objvPubClassCaseQuantitySenateEN.IdXzCollege, 4, convPubClassCaseQuantitySenate.IdXzCollege);
clsCheckSql.CheckFieldLen(objvPubClassCaseQuantitySenateEN.senateGaugeVersionID, 4, convPubClassCaseQuantitySenate.senateGaugeVersionID);
clsCheckSql.CheckFieldLen(objvPubClassCaseQuantitySenateEN.senateGaugeVersionName, 200, convPubClassCaseQuantitySenate.senateGaugeVersionName);
clsCheckSql.CheckFieldLen(objvPubClassCaseQuantitySenateEN.StuIdTeacherId, 20, convPubClassCaseQuantitySenate.StuIdTeacherId);
clsCheckSql.CheckFieldLen(objvPubClassCaseQuantitySenateEN.IdPubClassCaseSenateGaugeVersion, 4, convPubClassCaseQuantitySenate.IdPubClassCaseSenateGaugeVersion);
clsCheckSql.CheckFieldLen(objvPubClassCaseQuantitySenateEN.senateGaugeMemo, 1000, convPubClassCaseQuantitySenate.senateGaugeMemo);
clsCheckSql.CheckFieldLen(objvPubClassCaseQuantitySenateEN.senateGaugeNameWithOrder, 204, convPubClassCaseQuantitySenate.senateGaugeNameWithOrder);
clsCheckSql.CheckFieldLen(objvPubClassCaseQuantitySenateEN.PubClassCaseExecutor, 50, convPubClassCaseQuantitySenate.PubClassCaseExecutor);
clsCheckSql.CheckFieldLen(objvPubClassCaseQuantitySenateEN.PubClassCaseTeachDate, 8, convPubClassCaseQuantitySenate.PubClassCaseTeachDate);
clsCheckSql.CheckFieldLen(objvPubClassCaseQuantitySenateEN.UserNameWithUserId, 51, convPubClassCaseQuantitySenate.UserNameWithUserId);
clsCheckSql.CheckFieldLen(objvPubClassCaseQuantitySenateEN.CollegeNameA, 12, convPubClassCaseQuantitySenate.CollegeNameA);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvPubClassCaseQuantitySenateEN.IdPubClassCase, convPubClassCaseQuantitySenate.IdPubClassCase);
clsCheckSql.CheckSqlInjection4Field(objvPubClassCaseQuantitySenateEN.PubClassCaseID, convPubClassCaseQuantitySenate.PubClassCaseID);
clsCheckSql.CheckSqlInjection4Field(objvPubClassCaseQuantitySenateEN.PubClassCaseName, convPubClassCaseQuantitySenate.PubClassCaseName);
clsCheckSql.CheckSqlInjection4Field(objvPubClassCaseQuantitySenateEN.IdsenateGauge, convPubClassCaseQuantitySenate.IdsenateGauge);
clsCheckSql.CheckSqlInjection4Field(objvPubClassCaseQuantitySenateEN.senateGaugeID, convPubClassCaseQuantitySenate.senateGaugeID);
clsCheckSql.CheckSqlInjection4Field(objvPubClassCaseQuantitySenateEN.senateGaugeName, convPubClassCaseQuantitySenate.senateGaugeName);
clsCheckSql.CheckSqlInjection4Field(objvPubClassCaseQuantitySenateEN.UserId, convPubClassCaseQuantitySenate.UserId);
clsCheckSql.CheckSqlInjection4Field(objvPubClassCaseQuantitySenateEN.UserName, convPubClassCaseQuantitySenate.UserName);
clsCheckSql.CheckSqlInjection4Field(objvPubClassCaseQuantitySenateEN.OptDate, convPubClassCaseQuantitySenate.OptDate);
clsCheckSql.CheckSqlInjection4Field(objvPubClassCaseQuantitySenateEN.CollegeID, convPubClassCaseQuantitySenate.CollegeID);
clsCheckSql.CheckSqlInjection4Field(objvPubClassCaseQuantitySenateEN.CollegeName, convPubClassCaseQuantitySenate.CollegeName);
clsCheckSql.CheckSqlInjection4Field(objvPubClassCaseQuantitySenateEN.IdXzCollege, convPubClassCaseQuantitySenate.IdXzCollege);
clsCheckSql.CheckSqlInjection4Field(objvPubClassCaseQuantitySenateEN.senateGaugeVersionID, convPubClassCaseQuantitySenate.senateGaugeVersionID);
clsCheckSql.CheckSqlInjection4Field(objvPubClassCaseQuantitySenateEN.senateGaugeVersionName, convPubClassCaseQuantitySenate.senateGaugeVersionName);
clsCheckSql.CheckSqlInjection4Field(objvPubClassCaseQuantitySenateEN.StuIdTeacherId, convPubClassCaseQuantitySenate.StuIdTeacherId);
clsCheckSql.CheckSqlInjection4Field(objvPubClassCaseQuantitySenateEN.IdPubClassCaseSenateGaugeVersion, convPubClassCaseQuantitySenate.IdPubClassCaseSenateGaugeVersion);
clsCheckSql.CheckSqlInjection4Field(objvPubClassCaseQuantitySenateEN.senateGaugeMemo, convPubClassCaseQuantitySenate.senateGaugeMemo);
clsCheckSql.CheckSqlInjection4Field(objvPubClassCaseQuantitySenateEN.senateGaugeNameWithOrder, convPubClassCaseQuantitySenate.senateGaugeNameWithOrder);
clsCheckSql.CheckSqlInjection4Field(objvPubClassCaseQuantitySenateEN.PubClassCaseExecutor, convPubClassCaseQuantitySenate.PubClassCaseExecutor);
clsCheckSql.CheckSqlInjection4Field(objvPubClassCaseQuantitySenateEN.PubClassCaseTeachDate, convPubClassCaseQuantitySenate.PubClassCaseTeachDate);
clsCheckSql.CheckSqlInjection4Field(objvPubClassCaseQuantitySenateEN.UserNameWithUserId, convPubClassCaseQuantitySenate.UserNameWithUserId);
clsCheckSql.CheckSqlInjection4Field(objvPubClassCaseQuantitySenateEN.CollegeNameA, convPubClassCaseQuantitySenate.CollegeNameA);
//检查外键字段长度
 objvPubClassCaseQuantitySenateEN._IsCheckProperty = true;
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
 objSQL = clsvPubClassCaseQuantitySenateDA.GetSpecSQLObj();
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
 objSQL = clsvPubClassCaseQuantitySenateDA.GetSpecSQLObj();
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
 objSQL = clsvPubClassCaseQuantitySenateDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvPubClassCaseQuantitySenateEN._CurrTabName);
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
 objSQL = clsvPubClassCaseQuantitySenateDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvPubClassCaseQuantitySenateEN._CurrTabName, strCondition);
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
 objSQL = clsvPubClassCaseQuantitySenateDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}