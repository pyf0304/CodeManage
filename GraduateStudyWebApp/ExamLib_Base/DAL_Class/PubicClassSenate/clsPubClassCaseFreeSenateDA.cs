
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsPubClassCaseFreeSenateDA
 表名:PubClassCaseFreeSenate(01120413)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:17:43
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
 /// 公开课案例自由评议(PubClassCaseFreeSenate)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsPubClassCaseFreeSenateDA : clsCommBase4DA
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
 return clsPubClassCaseFreeSenateEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsPubClassCaseFreeSenateEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsPubClassCaseFreeSenateEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsPubClassCaseFreeSenateEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsPubClassCaseFreeSenateEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsPubClassCaseFreeSenateDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPubClassCaseFreeSenateDA.GetSpecSQLObj();
strSQL = "Select * from PubClassCaseFreeSenate where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_PubClassCaseFreeSenate(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsPubClassCaseFreeSenateDA: GetDataTable_PubClassCaseFreeSenate)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPubClassCaseFreeSenateDA.GetSpecSQLObj();
strSQL = "Select * from PubClassCaseFreeSenate where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsPubClassCaseFreeSenateDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPubClassCaseFreeSenateDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsPubClassCaseFreeSenateDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPubClassCaseFreeSenateDA.GetSpecSQLObj();
strSQL = "Select * from PubClassCaseFreeSenate where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsPubClassCaseFreeSenateDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPubClassCaseFreeSenateDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsPubClassCaseFreeSenateDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPubClassCaseFreeSenateDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from PubClassCaseFreeSenate where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from PubClassCaseFreeSenate where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsPubClassCaseFreeSenateDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPubClassCaseFreeSenateDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from PubClassCaseFreeSenate where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsPubClassCaseFreeSenateDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPubClassCaseFreeSenateDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} PubClassCaseFreeSenate.* from PubClassCaseFreeSenate Left Join {1} on {2} where {3} and PubClassCaseFreeSenate.IdPubClassCaseFreeSenate not in (Select top {5} PubClassCaseFreeSenate.IdPubClassCaseFreeSenate from PubClassCaseFreeSenate Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from PubClassCaseFreeSenate where {1} and IdPubClassCaseFreeSenate not in (Select top {2} IdPubClassCaseFreeSenate from PubClassCaseFreeSenate where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from PubClassCaseFreeSenate where {1} and IdPubClassCaseFreeSenate not in (Select top {3} IdPubClassCaseFreeSenate from PubClassCaseFreeSenate where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsPubClassCaseFreeSenateDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPubClassCaseFreeSenateDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} PubClassCaseFreeSenate.* from PubClassCaseFreeSenate Left Join {1} on {2} where {3} and PubClassCaseFreeSenate.IdPubClassCaseFreeSenate not in (Select top {5} PubClassCaseFreeSenate.IdPubClassCaseFreeSenate from PubClassCaseFreeSenate Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from PubClassCaseFreeSenate where {1} and IdPubClassCaseFreeSenate not in (Select top {2} IdPubClassCaseFreeSenate from PubClassCaseFreeSenate where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from PubClassCaseFreeSenate where {1} and IdPubClassCaseFreeSenate not in (Select top {3} IdPubClassCaseFreeSenate from PubClassCaseFreeSenate where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsPubClassCaseFreeSenateEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsPubClassCaseFreeSenateDA:GetObjLst)", objException.Message));
}
List<clsPubClassCaseFreeSenateEN> arrObjLst = new List<clsPubClassCaseFreeSenateEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPubClassCaseFreeSenateDA.GetSpecSQLObj();
strSQL = "Select * from PubClassCaseFreeSenate where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPubClassCaseFreeSenateEN objPubClassCaseFreeSenateEN = new clsPubClassCaseFreeSenateEN();
try
{
objPubClassCaseFreeSenateEN.IdPubClassCaseFreeSenate = TransNullToInt(objRow[conPubClassCaseFreeSenate.IdPubClassCaseFreeSenate].ToString().Trim()); //公开课案例自由评议流水号
objPubClassCaseFreeSenateEN.IdPubClassCase = objRow[conPubClassCaseFreeSenate.IdPubClassCase].ToString().Trim(); //案例流水号
objPubClassCaseFreeSenateEN.UserId = objRow[conPubClassCaseFreeSenate.UserId].ToString().Trim(); //用户ID
objPubClassCaseFreeSenateEN.AppraiseTheme = objRow[conPubClassCaseFreeSenate.AppraiseTheme] == DBNull.Value ? null : objRow[conPubClassCaseFreeSenate.AppraiseTheme].ToString().Trim(); //评议主题
objPubClassCaseFreeSenateEN.PubClassCaseFreeSenateTitle = objRow[conPubClassCaseFreeSenate.PubClassCaseFreeSenateTitle] == DBNull.Value ? null : objRow[conPubClassCaseFreeSenate.PubClassCaseFreeSenateTitle].ToString().Trim(); //公开课案例自由评议标题
objPubClassCaseFreeSenateEN.PubClassCaseFreeSenateConten = objRow[conPubClassCaseFreeSenate.PubClassCaseFreeSenateConten] == DBNull.Value ? null : objRow[conPubClassCaseFreeSenate.PubClassCaseFreeSenateConten].ToString().Trim(); //公开课案例自由评议内容
objPubClassCaseFreeSenateEN.PubClassCaseFreeSenateDate = objRow[conPubClassCaseFreeSenate.PubClassCaseFreeSenateDate] == DBNull.Value ? null : objRow[conPubClassCaseFreeSenate.PubClassCaseFreeSenateDate].ToString().Trim(); //公开课案例自由评议日期
objPubClassCaseFreeSenateEN.PubClassCaseFreeSenateTime = objRow[conPubClassCaseFreeSenate.PubClassCaseFreeSenateTime] == DBNull.Value ? null : objRow[conPubClassCaseFreeSenate.PubClassCaseFreeSenateTime].ToString().Trim(); //公开课案例自由评议时间
objPubClassCaseFreeSenateEN.VideoStopTime = objRow[conPubClassCaseFreeSenate.VideoStopTime] == DBNull.Value ? null : objRow[conPubClassCaseFreeSenate.VideoStopTime].ToString().Trim(); //公开课案例视频暂停时间
objPubClassCaseFreeSenateEN.VideoStopImage = (byte[])objRow[conPubClassCaseFreeSenate.VideoStopImage]; //公开课案例视频暂停截图
objPubClassCaseFreeSenateEN.BrowseCount = objRow[conPubClassCaseFreeSenate.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conPubClassCaseFreeSenate.BrowseCount].ToString().Trim()); //浏览次数
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsPubClassCaseFreeSenateDA: GetObjLst)", objException.Message));
}
objPubClassCaseFreeSenateEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objPubClassCaseFreeSenateEN);
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
public List<clsPubClassCaseFreeSenateEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsPubClassCaseFreeSenateDA:GetObjLstByTabName)", objException.Message));
}
List<clsPubClassCaseFreeSenateEN> arrObjLst = new List<clsPubClassCaseFreeSenateEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPubClassCaseFreeSenateDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPubClassCaseFreeSenateEN objPubClassCaseFreeSenateEN = new clsPubClassCaseFreeSenateEN();
try
{
objPubClassCaseFreeSenateEN.IdPubClassCaseFreeSenate = TransNullToInt(objRow[conPubClassCaseFreeSenate.IdPubClassCaseFreeSenate].ToString().Trim()); //公开课案例自由评议流水号
objPubClassCaseFreeSenateEN.IdPubClassCase = objRow[conPubClassCaseFreeSenate.IdPubClassCase].ToString().Trim(); //案例流水号
objPubClassCaseFreeSenateEN.UserId = objRow[conPubClassCaseFreeSenate.UserId].ToString().Trim(); //用户ID
objPubClassCaseFreeSenateEN.AppraiseTheme = objRow[conPubClassCaseFreeSenate.AppraiseTheme] == DBNull.Value ? null : objRow[conPubClassCaseFreeSenate.AppraiseTheme].ToString().Trim(); //评议主题
objPubClassCaseFreeSenateEN.PubClassCaseFreeSenateTitle = objRow[conPubClassCaseFreeSenate.PubClassCaseFreeSenateTitle] == DBNull.Value ? null : objRow[conPubClassCaseFreeSenate.PubClassCaseFreeSenateTitle].ToString().Trim(); //公开课案例自由评议标题
objPubClassCaseFreeSenateEN.PubClassCaseFreeSenateConten = objRow[conPubClassCaseFreeSenate.PubClassCaseFreeSenateConten] == DBNull.Value ? null : objRow[conPubClassCaseFreeSenate.PubClassCaseFreeSenateConten].ToString().Trim(); //公开课案例自由评议内容
objPubClassCaseFreeSenateEN.PubClassCaseFreeSenateDate = objRow[conPubClassCaseFreeSenate.PubClassCaseFreeSenateDate] == DBNull.Value ? null : objRow[conPubClassCaseFreeSenate.PubClassCaseFreeSenateDate].ToString().Trim(); //公开课案例自由评议日期
objPubClassCaseFreeSenateEN.PubClassCaseFreeSenateTime = objRow[conPubClassCaseFreeSenate.PubClassCaseFreeSenateTime] == DBNull.Value ? null : objRow[conPubClassCaseFreeSenate.PubClassCaseFreeSenateTime].ToString().Trim(); //公开课案例自由评议时间
objPubClassCaseFreeSenateEN.VideoStopTime = objRow[conPubClassCaseFreeSenate.VideoStopTime] == DBNull.Value ? null : objRow[conPubClassCaseFreeSenate.VideoStopTime].ToString().Trim(); //公开课案例视频暂停时间
objPubClassCaseFreeSenateEN.VideoStopImage = (byte[])objRow[conPubClassCaseFreeSenate.VideoStopImage]; //公开课案例视频暂停截图
objPubClassCaseFreeSenateEN.BrowseCount = objRow[conPubClassCaseFreeSenate.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conPubClassCaseFreeSenate.BrowseCount].ToString().Trim()); //浏览次数
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsPubClassCaseFreeSenateDA: GetObjLst)", objException.Message));
}
objPubClassCaseFreeSenateEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objPubClassCaseFreeSenateEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objPubClassCaseFreeSenateEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetPubClassCaseFreeSenate(ref clsPubClassCaseFreeSenateEN objPubClassCaseFreeSenateEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPubClassCaseFreeSenateDA.GetSpecSQLObj();
strSQL = "Select * from PubClassCaseFreeSenate where IdPubClassCaseFreeSenate = " + ""+ objPubClassCaseFreeSenateEN.IdPubClassCaseFreeSenate+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objPubClassCaseFreeSenateEN.IdPubClassCaseFreeSenate = TransNullToInt(objDT.Rows[0][conPubClassCaseFreeSenate.IdPubClassCaseFreeSenate].ToString().Trim()); //公开课案例自由评议流水号(字段类型:bigint,字段长度:8,是否可空:False)
 objPubClassCaseFreeSenateEN.IdPubClassCase = objDT.Rows[0][conPubClassCaseFreeSenate.IdPubClassCase].ToString().Trim(); //案例流水号(字段类型:char,字段长度:8,是否可空:False)
 objPubClassCaseFreeSenateEN.UserId = objDT.Rows[0][conPubClassCaseFreeSenate.UserId].ToString().Trim(); //用户ID(字段类型:varchar,字段长度:18,是否可空:True)
 objPubClassCaseFreeSenateEN.AppraiseTheme = objDT.Rows[0][conPubClassCaseFreeSenate.AppraiseTheme].ToString().Trim(); //评议主题(字段类型:varchar,字段长度:200,是否可空:True)
 objPubClassCaseFreeSenateEN.PubClassCaseFreeSenateTitle = objDT.Rows[0][conPubClassCaseFreeSenate.PubClassCaseFreeSenateTitle].ToString().Trim(); //公开课案例自由评议标题(字段类型:varchar,字段长度:200,是否可空:True)
 objPubClassCaseFreeSenateEN.PubClassCaseFreeSenateConten = objDT.Rows[0][conPubClassCaseFreeSenate.PubClassCaseFreeSenateConten].ToString().Trim(); //公开课案例自由评议内容(字段类型:varchar,字段长度:2000,是否可空:True)
 objPubClassCaseFreeSenateEN.PubClassCaseFreeSenateDate = objDT.Rows[0][conPubClassCaseFreeSenate.PubClassCaseFreeSenateDate].ToString().Trim(); //公开课案例自由评议日期(字段类型:char,字段长度:8,是否可空:True)
 objPubClassCaseFreeSenateEN.PubClassCaseFreeSenateTime = objDT.Rows[0][conPubClassCaseFreeSenate.PubClassCaseFreeSenateTime].ToString().Trim(); //公开课案例自由评议时间(字段类型:char,字段长度:6,是否可空:True)
 objPubClassCaseFreeSenateEN.VideoStopTime = objDT.Rows[0][conPubClassCaseFreeSenate.VideoStopTime].ToString().Trim(); //公开课案例视频暂停时间(字段类型:varchar,字段长度:48,是否可空:True)
 objPubClassCaseFreeSenateEN.VideoStopImage = (byte[])objDT.Rows[0][conPubClassCaseFreeSenate.VideoStopImage]; //公开课案例视频暂停截图(字段类型:image,字段长度:16,是否可空:True)
 objPubClassCaseFreeSenateEN.BrowseCount = TransNullToInt(objDT.Rows[0][conPubClassCaseFreeSenate.BrowseCount].ToString().Trim()); //浏览次数(字段类型:int,字段长度:4,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsPubClassCaseFreeSenateDA: GetPubClassCaseFreeSenate)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngIdPubClassCaseFreeSenate">表关键字</param>
 /// <returns>表对象</returns>
public clsPubClassCaseFreeSenateEN GetObjByIdPubClassCaseFreeSenate(long lngIdPubClassCaseFreeSenate)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPubClassCaseFreeSenateDA.GetSpecSQLObj();
strSQL = "Select * from PubClassCaseFreeSenate where IdPubClassCaseFreeSenate = " + ""+ lngIdPubClassCaseFreeSenate+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsPubClassCaseFreeSenateEN objPubClassCaseFreeSenateEN = new clsPubClassCaseFreeSenateEN();
try
{
 objPubClassCaseFreeSenateEN.IdPubClassCaseFreeSenate = Int32.Parse(objRow[conPubClassCaseFreeSenate.IdPubClassCaseFreeSenate].ToString().Trim()); //公开课案例自由评议流水号(字段类型:bigint,字段长度:8,是否可空:False)
 objPubClassCaseFreeSenateEN.IdPubClassCase = objRow[conPubClassCaseFreeSenate.IdPubClassCase].ToString().Trim(); //案例流水号(字段类型:char,字段长度:8,是否可空:False)
 objPubClassCaseFreeSenateEN.UserId = objRow[conPubClassCaseFreeSenate.UserId].ToString().Trim(); //用户ID(字段类型:varchar,字段长度:18,是否可空:True)
 objPubClassCaseFreeSenateEN.AppraiseTheme = objRow[conPubClassCaseFreeSenate.AppraiseTheme] == DBNull.Value ? null : objRow[conPubClassCaseFreeSenate.AppraiseTheme].ToString().Trim(); //评议主题(字段类型:varchar,字段长度:200,是否可空:True)
 objPubClassCaseFreeSenateEN.PubClassCaseFreeSenateTitle = objRow[conPubClassCaseFreeSenate.PubClassCaseFreeSenateTitle] == DBNull.Value ? null : objRow[conPubClassCaseFreeSenate.PubClassCaseFreeSenateTitle].ToString().Trim(); //公开课案例自由评议标题(字段类型:varchar,字段长度:200,是否可空:True)
 objPubClassCaseFreeSenateEN.PubClassCaseFreeSenateConten = objRow[conPubClassCaseFreeSenate.PubClassCaseFreeSenateConten] == DBNull.Value ? null : objRow[conPubClassCaseFreeSenate.PubClassCaseFreeSenateConten].ToString().Trim(); //公开课案例自由评议内容(字段类型:varchar,字段长度:2000,是否可空:True)
 objPubClassCaseFreeSenateEN.PubClassCaseFreeSenateDate = objRow[conPubClassCaseFreeSenate.PubClassCaseFreeSenateDate] == DBNull.Value ? null : objRow[conPubClassCaseFreeSenate.PubClassCaseFreeSenateDate].ToString().Trim(); //公开课案例自由评议日期(字段类型:char,字段长度:8,是否可空:True)
 objPubClassCaseFreeSenateEN.PubClassCaseFreeSenateTime = objRow[conPubClassCaseFreeSenate.PubClassCaseFreeSenateTime] == DBNull.Value ? null : objRow[conPubClassCaseFreeSenate.PubClassCaseFreeSenateTime].ToString().Trim(); //公开课案例自由评议时间(字段类型:char,字段长度:6,是否可空:True)
 objPubClassCaseFreeSenateEN.VideoStopTime = objRow[conPubClassCaseFreeSenate.VideoStopTime] == DBNull.Value ? null : objRow[conPubClassCaseFreeSenate.VideoStopTime].ToString().Trim(); //公开课案例视频暂停时间(字段类型:varchar,字段长度:48,是否可空:True)
 objPubClassCaseFreeSenateEN.VideoStopImage = (byte[])objRow[conPubClassCaseFreeSenate.VideoStopImage]; //公开课案例视频暂停截图(字段类型:image,字段长度:16,是否可空:True)
 objPubClassCaseFreeSenateEN.BrowseCount = objRow[conPubClassCaseFreeSenate.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPubClassCaseFreeSenate.BrowseCount].ToString().Trim()); //浏览次数(字段类型:int,字段长度:4,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsPubClassCaseFreeSenateDA: GetObjByIdPubClassCaseFreeSenate)", objException.Message));
}
return objPubClassCaseFreeSenateEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsPubClassCaseFreeSenateEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsPubClassCaseFreeSenateDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPubClassCaseFreeSenateDA.GetSpecSQLObj();
strSQL = "Select * from PubClassCaseFreeSenate where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsPubClassCaseFreeSenateEN objPubClassCaseFreeSenateEN = new clsPubClassCaseFreeSenateEN()
{
IdPubClassCaseFreeSenate = TransNullToInt(objRow[conPubClassCaseFreeSenate.IdPubClassCaseFreeSenate].ToString().Trim()), //公开课案例自由评议流水号
IdPubClassCase = objRow[conPubClassCaseFreeSenate.IdPubClassCase].ToString().Trim(), //案例流水号
UserId = objRow[conPubClassCaseFreeSenate.UserId].ToString().Trim(), //用户ID
AppraiseTheme = objRow[conPubClassCaseFreeSenate.AppraiseTheme] == DBNull.Value ? null : objRow[conPubClassCaseFreeSenate.AppraiseTheme].ToString().Trim(), //评议主题
PubClassCaseFreeSenateTitle = objRow[conPubClassCaseFreeSenate.PubClassCaseFreeSenateTitle] == DBNull.Value ? null : objRow[conPubClassCaseFreeSenate.PubClassCaseFreeSenateTitle].ToString().Trim(), //公开课案例自由评议标题
PubClassCaseFreeSenateConten = objRow[conPubClassCaseFreeSenate.PubClassCaseFreeSenateConten] == DBNull.Value ? null : objRow[conPubClassCaseFreeSenate.PubClassCaseFreeSenateConten].ToString().Trim(), //公开课案例自由评议内容
PubClassCaseFreeSenateDate = objRow[conPubClassCaseFreeSenate.PubClassCaseFreeSenateDate] == DBNull.Value ? null : objRow[conPubClassCaseFreeSenate.PubClassCaseFreeSenateDate].ToString().Trim(), //公开课案例自由评议日期
PubClassCaseFreeSenateTime = objRow[conPubClassCaseFreeSenate.PubClassCaseFreeSenateTime] == DBNull.Value ? null : objRow[conPubClassCaseFreeSenate.PubClassCaseFreeSenateTime].ToString().Trim(), //公开课案例自由评议时间
VideoStopTime = objRow[conPubClassCaseFreeSenate.VideoStopTime] == DBNull.Value ? null : objRow[conPubClassCaseFreeSenate.VideoStopTime].ToString().Trim(), //公开课案例视频暂停时间
VideoStopImage = (byte[])objRow[conPubClassCaseFreeSenate.VideoStopImage], //公开课案例视频暂停截图
BrowseCount = objRow[conPubClassCaseFreeSenate.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conPubClassCaseFreeSenate.BrowseCount].ToString().Trim()) //浏览次数
};
objPubClassCaseFreeSenateEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objPubClassCaseFreeSenateEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsPubClassCaseFreeSenateDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsPubClassCaseFreeSenateEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsPubClassCaseFreeSenateEN objPubClassCaseFreeSenateEN = new clsPubClassCaseFreeSenateEN();
try
{
objPubClassCaseFreeSenateEN.IdPubClassCaseFreeSenate = TransNullToInt(objRow[conPubClassCaseFreeSenate.IdPubClassCaseFreeSenate].ToString().Trim()); //公开课案例自由评议流水号
objPubClassCaseFreeSenateEN.IdPubClassCase = objRow[conPubClassCaseFreeSenate.IdPubClassCase].ToString().Trim(); //案例流水号
objPubClassCaseFreeSenateEN.UserId = objRow[conPubClassCaseFreeSenate.UserId].ToString().Trim(); //用户ID
objPubClassCaseFreeSenateEN.AppraiseTheme = objRow[conPubClassCaseFreeSenate.AppraiseTheme] == DBNull.Value ? null : objRow[conPubClassCaseFreeSenate.AppraiseTheme].ToString().Trim(); //评议主题
objPubClassCaseFreeSenateEN.PubClassCaseFreeSenateTitle = objRow[conPubClassCaseFreeSenate.PubClassCaseFreeSenateTitle] == DBNull.Value ? null : objRow[conPubClassCaseFreeSenate.PubClassCaseFreeSenateTitle].ToString().Trim(); //公开课案例自由评议标题
objPubClassCaseFreeSenateEN.PubClassCaseFreeSenateConten = objRow[conPubClassCaseFreeSenate.PubClassCaseFreeSenateConten] == DBNull.Value ? null : objRow[conPubClassCaseFreeSenate.PubClassCaseFreeSenateConten].ToString().Trim(); //公开课案例自由评议内容
objPubClassCaseFreeSenateEN.PubClassCaseFreeSenateDate = objRow[conPubClassCaseFreeSenate.PubClassCaseFreeSenateDate] == DBNull.Value ? null : objRow[conPubClassCaseFreeSenate.PubClassCaseFreeSenateDate].ToString().Trim(); //公开课案例自由评议日期
objPubClassCaseFreeSenateEN.PubClassCaseFreeSenateTime = objRow[conPubClassCaseFreeSenate.PubClassCaseFreeSenateTime] == DBNull.Value ? null : objRow[conPubClassCaseFreeSenate.PubClassCaseFreeSenateTime].ToString().Trim(); //公开课案例自由评议时间
objPubClassCaseFreeSenateEN.VideoStopTime = objRow[conPubClassCaseFreeSenate.VideoStopTime] == DBNull.Value ? null : objRow[conPubClassCaseFreeSenate.VideoStopTime].ToString().Trim(); //公开课案例视频暂停时间
objPubClassCaseFreeSenateEN.VideoStopImage = objRow[conPubClassCaseFreeSenate.VideoStopImage] as byte[]; //公开课案例视频暂停截图
objPubClassCaseFreeSenateEN.BrowseCount = objRow[conPubClassCaseFreeSenate.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conPubClassCaseFreeSenate.BrowseCount].ToString().Trim()); //浏览次数
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsPubClassCaseFreeSenateDA: GetObjByDataRowPubClassCaseFreeSenate)", objException.Message));
}
objPubClassCaseFreeSenateEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objPubClassCaseFreeSenateEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsPubClassCaseFreeSenateEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsPubClassCaseFreeSenateEN objPubClassCaseFreeSenateEN = new clsPubClassCaseFreeSenateEN();
try
{
objPubClassCaseFreeSenateEN.IdPubClassCaseFreeSenate = TransNullToInt(objRow[conPubClassCaseFreeSenate.IdPubClassCaseFreeSenate].ToString().Trim()); //公开课案例自由评议流水号
objPubClassCaseFreeSenateEN.IdPubClassCase = objRow[conPubClassCaseFreeSenate.IdPubClassCase].ToString().Trim(); //案例流水号
objPubClassCaseFreeSenateEN.UserId = objRow[conPubClassCaseFreeSenate.UserId].ToString().Trim(); //用户ID
objPubClassCaseFreeSenateEN.AppraiseTheme = objRow[conPubClassCaseFreeSenate.AppraiseTheme] == DBNull.Value ? null : objRow[conPubClassCaseFreeSenate.AppraiseTheme].ToString().Trim(); //评议主题
objPubClassCaseFreeSenateEN.PubClassCaseFreeSenateTitle = objRow[conPubClassCaseFreeSenate.PubClassCaseFreeSenateTitle] == DBNull.Value ? null : objRow[conPubClassCaseFreeSenate.PubClassCaseFreeSenateTitle].ToString().Trim(); //公开课案例自由评议标题
objPubClassCaseFreeSenateEN.PubClassCaseFreeSenateConten = objRow[conPubClassCaseFreeSenate.PubClassCaseFreeSenateConten] == DBNull.Value ? null : objRow[conPubClassCaseFreeSenate.PubClassCaseFreeSenateConten].ToString().Trim(); //公开课案例自由评议内容
objPubClassCaseFreeSenateEN.PubClassCaseFreeSenateDate = objRow[conPubClassCaseFreeSenate.PubClassCaseFreeSenateDate] == DBNull.Value ? null : objRow[conPubClassCaseFreeSenate.PubClassCaseFreeSenateDate].ToString().Trim(); //公开课案例自由评议日期
objPubClassCaseFreeSenateEN.PubClassCaseFreeSenateTime = objRow[conPubClassCaseFreeSenate.PubClassCaseFreeSenateTime] == DBNull.Value ? null : objRow[conPubClassCaseFreeSenate.PubClassCaseFreeSenateTime].ToString().Trim(); //公开课案例自由评议时间
objPubClassCaseFreeSenateEN.VideoStopTime = objRow[conPubClassCaseFreeSenate.VideoStopTime] == DBNull.Value ? null : objRow[conPubClassCaseFreeSenate.VideoStopTime].ToString().Trim(); //公开课案例视频暂停时间
objPubClassCaseFreeSenateEN.VideoStopImage = objRow[conPubClassCaseFreeSenate.VideoStopImage] as byte[]; //公开课案例视频暂停截图
objPubClassCaseFreeSenateEN.BrowseCount = objRow[conPubClassCaseFreeSenate.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conPubClassCaseFreeSenate.BrowseCount].ToString().Trim()); //浏览次数
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsPubClassCaseFreeSenateDA: GetObjByDataRow)", objException.Message));
}
objPubClassCaseFreeSenateEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objPubClassCaseFreeSenateEN;
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
objSQL = clsPubClassCaseFreeSenateDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsPubClassCaseFreeSenateEN._CurrTabName, conPubClassCaseFreeSenate.IdPubClassCaseFreeSenate, 8, "");
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
objSQL = clsPubClassCaseFreeSenateDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsPubClassCaseFreeSenateEN._CurrTabName, conPubClassCaseFreeSenate.IdPubClassCaseFreeSenate, 8, strPrefix);
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
 objSQL = clsPubClassCaseFreeSenateDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select IdPubClassCaseFreeSenate from PubClassCaseFreeSenate where " + strCondition;
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
 objSQL = clsPubClassCaseFreeSenateDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select IdPubClassCaseFreeSenate from PubClassCaseFreeSenate where " + strCondition;
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
 objSQL = clsPubClassCaseFreeSenateDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("PubClassCaseFreeSenate", "IdPubClassCaseFreeSenate = " + ""+ lngIdPubClassCaseFreeSenate+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsPubClassCaseFreeSenateDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPubClassCaseFreeSenateDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("PubClassCaseFreeSenate", strCondition))
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
objSQL = clsPubClassCaseFreeSenateDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("PubClassCaseFreeSenate");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsPubClassCaseFreeSenateEN objPubClassCaseFreeSenateEN)
 {
 if (objPubClassCaseFreeSenateEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objPubClassCaseFreeSenateEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPubClassCaseFreeSenateDA.GetSpecSQLObj();
strSQL = "Select * from PubClassCaseFreeSenate where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "PubClassCaseFreeSenate");
objRow = objDS.Tables["PubClassCaseFreeSenate"].NewRow();
objRow[conPubClassCaseFreeSenate.IdPubClassCase] = objPubClassCaseFreeSenateEN.IdPubClassCase; //案例流水号
objRow[conPubClassCaseFreeSenate.UserId] = objPubClassCaseFreeSenateEN.UserId; //用户ID
 if (objPubClassCaseFreeSenateEN.AppraiseTheme !=  "")
 {
objRow[conPubClassCaseFreeSenate.AppraiseTheme] = objPubClassCaseFreeSenateEN.AppraiseTheme; //评议主题
 }
 if (objPubClassCaseFreeSenateEN.PubClassCaseFreeSenateTitle !=  "")
 {
objRow[conPubClassCaseFreeSenate.PubClassCaseFreeSenateTitle] = objPubClassCaseFreeSenateEN.PubClassCaseFreeSenateTitle; //公开课案例自由评议标题
 }
 if (objPubClassCaseFreeSenateEN.PubClassCaseFreeSenateConten !=  "")
 {
objRow[conPubClassCaseFreeSenate.PubClassCaseFreeSenateConten] = objPubClassCaseFreeSenateEN.PubClassCaseFreeSenateConten; //公开课案例自由评议内容
 }
 if (objPubClassCaseFreeSenateEN.PubClassCaseFreeSenateDate !=  "")
 {
objRow[conPubClassCaseFreeSenate.PubClassCaseFreeSenateDate] = objPubClassCaseFreeSenateEN.PubClassCaseFreeSenateDate; //公开课案例自由评议日期
 }
 if (objPubClassCaseFreeSenateEN.PubClassCaseFreeSenateTime !=  "")
 {
objRow[conPubClassCaseFreeSenate.PubClassCaseFreeSenateTime] = objPubClassCaseFreeSenateEN.PubClassCaseFreeSenateTime; //公开课案例自由评议时间
 }
 if (objPubClassCaseFreeSenateEN.VideoStopTime !=  "")
 {
objRow[conPubClassCaseFreeSenate.VideoStopTime] = objPubClassCaseFreeSenateEN.VideoStopTime; //公开课案例视频暂停时间
 }
objRow[conPubClassCaseFreeSenate.VideoStopImage] = objPubClassCaseFreeSenateEN.VideoStopImage; //公开课案例视频暂停截图
objRow[conPubClassCaseFreeSenate.BrowseCount] = objPubClassCaseFreeSenateEN.BrowseCount; //浏览次数
objDS.Tables[clsPubClassCaseFreeSenateEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsPubClassCaseFreeSenateEN._CurrTabName);
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
 /// <param name = "objPubClassCaseFreeSenateEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsPubClassCaseFreeSenateEN objPubClassCaseFreeSenateEN)
{
 if (objPubClassCaseFreeSenateEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objPubClassCaseFreeSenateEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objPubClassCaseFreeSenateEN.IdPubClassCase  ==  "")
 {
 objPubClassCaseFreeSenateEN.IdPubClassCase = null;
 }
 if (objPubClassCaseFreeSenateEN.IdPubClassCase !=  null)
 {
 arrFieldListForInsert.Add(conPubClassCaseFreeSenate.IdPubClassCase);
 var strIdPubClassCase = objPubClassCaseFreeSenateEN.IdPubClassCase.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdPubClassCase + "'");
 }
 
 if (objPubClassCaseFreeSenateEN.UserId !=  null)
 {
 arrFieldListForInsert.Add(conPubClassCaseFreeSenate.UserId);
 var strUserId = objPubClassCaseFreeSenateEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserId + "'");
 }
 
 if (objPubClassCaseFreeSenateEN.AppraiseTheme !=  null)
 {
 arrFieldListForInsert.Add(conPubClassCaseFreeSenate.AppraiseTheme);
 var strAppraiseTheme = objPubClassCaseFreeSenateEN.AppraiseTheme.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAppraiseTheme + "'");
 }
 
 if (objPubClassCaseFreeSenateEN.PubClassCaseFreeSenateTitle !=  null)
 {
 arrFieldListForInsert.Add(conPubClassCaseFreeSenate.PubClassCaseFreeSenateTitle);
 var strPubClassCaseFreeSenateTitle = objPubClassCaseFreeSenateEN.PubClassCaseFreeSenateTitle.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPubClassCaseFreeSenateTitle + "'");
 }
 
 if (objPubClassCaseFreeSenateEN.PubClassCaseFreeSenateConten !=  null)
 {
 arrFieldListForInsert.Add(conPubClassCaseFreeSenate.PubClassCaseFreeSenateConten);
 var strPubClassCaseFreeSenateConten = objPubClassCaseFreeSenateEN.PubClassCaseFreeSenateConten.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPubClassCaseFreeSenateConten + "'");
 }
 
 if (objPubClassCaseFreeSenateEN.PubClassCaseFreeSenateDate !=  null)
 {
 arrFieldListForInsert.Add(conPubClassCaseFreeSenate.PubClassCaseFreeSenateDate);
 var strPubClassCaseFreeSenateDate = objPubClassCaseFreeSenateEN.PubClassCaseFreeSenateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPubClassCaseFreeSenateDate + "'");
 }
 
 if (objPubClassCaseFreeSenateEN.PubClassCaseFreeSenateTime !=  null)
 {
 arrFieldListForInsert.Add(conPubClassCaseFreeSenate.PubClassCaseFreeSenateTime);
 var strPubClassCaseFreeSenateTime = objPubClassCaseFreeSenateEN.PubClassCaseFreeSenateTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPubClassCaseFreeSenateTime + "'");
 }
 
 if (objPubClassCaseFreeSenateEN.VideoStopTime !=  null)
 {
 arrFieldListForInsert.Add(conPubClassCaseFreeSenate.VideoStopTime);
 var strVideoStopTime = objPubClassCaseFreeSenateEN.VideoStopTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVideoStopTime + "'");
 }
 
 
 if (objPubClassCaseFreeSenateEN.BrowseCount !=  null)
 {
 arrFieldListForInsert.Add(conPubClassCaseFreeSenate.BrowseCount);
 arrValueListForInsert.Add(objPubClassCaseFreeSenateEN.BrowseCount.ToString());
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into PubClassCaseFreeSenate");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPubClassCaseFreeSenateDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objPubClassCaseFreeSenateEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsPubClassCaseFreeSenateEN objPubClassCaseFreeSenateEN)
{
 if (objPubClassCaseFreeSenateEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objPubClassCaseFreeSenateEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objPubClassCaseFreeSenateEN.IdPubClassCase  ==  "")
 {
 objPubClassCaseFreeSenateEN.IdPubClassCase = null;
 }
 if (objPubClassCaseFreeSenateEN.IdPubClassCase !=  null)
 {
 arrFieldListForInsert.Add(conPubClassCaseFreeSenate.IdPubClassCase);
 var strIdPubClassCase = objPubClassCaseFreeSenateEN.IdPubClassCase.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdPubClassCase + "'");
 }
 
 if (objPubClassCaseFreeSenateEN.UserId !=  null)
 {
 arrFieldListForInsert.Add(conPubClassCaseFreeSenate.UserId);
 var strUserId = objPubClassCaseFreeSenateEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserId + "'");
 }
 
 if (objPubClassCaseFreeSenateEN.AppraiseTheme !=  null)
 {
 arrFieldListForInsert.Add(conPubClassCaseFreeSenate.AppraiseTheme);
 var strAppraiseTheme = objPubClassCaseFreeSenateEN.AppraiseTheme.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAppraiseTheme + "'");
 }
 
 if (objPubClassCaseFreeSenateEN.PubClassCaseFreeSenateTitle !=  null)
 {
 arrFieldListForInsert.Add(conPubClassCaseFreeSenate.PubClassCaseFreeSenateTitle);
 var strPubClassCaseFreeSenateTitle = objPubClassCaseFreeSenateEN.PubClassCaseFreeSenateTitle.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPubClassCaseFreeSenateTitle + "'");
 }
 
 if (objPubClassCaseFreeSenateEN.PubClassCaseFreeSenateConten !=  null)
 {
 arrFieldListForInsert.Add(conPubClassCaseFreeSenate.PubClassCaseFreeSenateConten);
 var strPubClassCaseFreeSenateConten = objPubClassCaseFreeSenateEN.PubClassCaseFreeSenateConten.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPubClassCaseFreeSenateConten + "'");
 }
 
 if (objPubClassCaseFreeSenateEN.PubClassCaseFreeSenateDate !=  null)
 {
 arrFieldListForInsert.Add(conPubClassCaseFreeSenate.PubClassCaseFreeSenateDate);
 var strPubClassCaseFreeSenateDate = objPubClassCaseFreeSenateEN.PubClassCaseFreeSenateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPubClassCaseFreeSenateDate + "'");
 }
 
 if (objPubClassCaseFreeSenateEN.PubClassCaseFreeSenateTime !=  null)
 {
 arrFieldListForInsert.Add(conPubClassCaseFreeSenate.PubClassCaseFreeSenateTime);
 var strPubClassCaseFreeSenateTime = objPubClassCaseFreeSenateEN.PubClassCaseFreeSenateTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPubClassCaseFreeSenateTime + "'");
 }
 
 if (objPubClassCaseFreeSenateEN.VideoStopTime !=  null)
 {
 arrFieldListForInsert.Add(conPubClassCaseFreeSenate.VideoStopTime);
 var strVideoStopTime = objPubClassCaseFreeSenateEN.VideoStopTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVideoStopTime + "'");
 }
 
 
 if (objPubClassCaseFreeSenateEN.BrowseCount !=  null)
 {
 arrFieldListForInsert.Add(conPubClassCaseFreeSenate.BrowseCount);
 arrValueListForInsert.Add(objPubClassCaseFreeSenateEN.BrowseCount.ToString());
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into PubClassCaseFreeSenate");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPubClassCaseFreeSenateDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString()).Rows[0][0].ToString();
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objPubClassCaseFreeSenateEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsPubClassCaseFreeSenateEN objPubClassCaseFreeSenateEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objPubClassCaseFreeSenateEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objPubClassCaseFreeSenateEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objPubClassCaseFreeSenateEN.IdPubClassCase  ==  "")
 {
 objPubClassCaseFreeSenateEN.IdPubClassCase = null;
 }
 if (objPubClassCaseFreeSenateEN.IdPubClassCase !=  null)
 {
 arrFieldListForInsert.Add(conPubClassCaseFreeSenate.IdPubClassCase);
 var strIdPubClassCase = objPubClassCaseFreeSenateEN.IdPubClassCase.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdPubClassCase + "'");
 }
 
 if (objPubClassCaseFreeSenateEN.UserId !=  null)
 {
 arrFieldListForInsert.Add(conPubClassCaseFreeSenate.UserId);
 var strUserId = objPubClassCaseFreeSenateEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserId + "'");
 }
 
 if (objPubClassCaseFreeSenateEN.AppraiseTheme !=  null)
 {
 arrFieldListForInsert.Add(conPubClassCaseFreeSenate.AppraiseTheme);
 var strAppraiseTheme = objPubClassCaseFreeSenateEN.AppraiseTheme.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAppraiseTheme + "'");
 }
 
 if (objPubClassCaseFreeSenateEN.PubClassCaseFreeSenateTitle !=  null)
 {
 arrFieldListForInsert.Add(conPubClassCaseFreeSenate.PubClassCaseFreeSenateTitle);
 var strPubClassCaseFreeSenateTitle = objPubClassCaseFreeSenateEN.PubClassCaseFreeSenateTitle.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPubClassCaseFreeSenateTitle + "'");
 }
 
 if (objPubClassCaseFreeSenateEN.PubClassCaseFreeSenateConten !=  null)
 {
 arrFieldListForInsert.Add(conPubClassCaseFreeSenate.PubClassCaseFreeSenateConten);
 var strPubClassCaseFreeSenateConten = objPubClassCaseFreeSenateEN.PubClassCaseFreeSenateConten.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPubClassCaseFreeSenateConten + "'");
 }
 
 if (objPubClassCaseFreeSenateEN.PubClassCaseFreeSenateDate !=  null)
 {
 arrFieldListForInsert.Add(conPubClassCaseFreeSenate.PubClassCaseFreeSenateDate);
 var strPubClassCaseFreeSenateDate = objPubClassCaseFreeSenateEN.PubClassCaseFreeSenateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPubClassCaseFreeSenateDate + "'");
 }
 
 if (objPubClassCaseFreeSenateEN.PubClassCaseFreeSenateTime !=  null)
 {
 arrFieldListForInsert.Add(conPubClassCaseFreeSenate.PubClassCaseFreeSenateTime);
 var strPubClassCaseFreeSenateTime = objPubClassCaseFreeSenateEN.PubClassCaseFreeSenateTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPubClassCaseFreeSenateTime + "'");
 }
 
 if (objPubClassCaseFreeSenateEN.VideoStopTime !=  null)
 {
 arrFieldListForInsert.Add(conPubClassCaseFreeSenate.VideoStopTime);
 var strVideoStopTime = objPubClassCaseFreeSenateEN.VideoStopTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVideoStopTime + "'");
 }
 
 
 if (objPubClassCaseFreeSenateEN.BrowseCount !=  null)
 {
 arrFieldListForInsert.Add(conPubClassCaseFreeSenate.BrowseCount);
 arrValueListForInsert.Add(objPubClassCaseFreeSenateEN.BrowseCount.ToString());
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into PubClassCaseFreeSenate");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPubClassCaseFreeSenateDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString(), objSqlConnection, objSqlTransaction).Rows[0][0].ToString();
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objPubClassCaseFreeSenateEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsPubClassCaseFreeSenateEN objPubClassCaseFreeSenateEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objPubClassCaseFreeSenateEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objPubClassCaseFreeSenateEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objPubClassCaseFreeSenateEN.IdPubClassCase  ==  "")
 {
 objPubClassCaseFreeSenateEN.IdPubClassCase = null;
 }
 if (objPubClassCaseFreeSenateEN.IdPubClassCase !=  null)
 {
 arrFieldListForInsert.Add(conPubClassCaseFreeSenate.IdPubClassCase);
 var strIdPubClassCase = objPubClassCaseFreeSenateEN.IdPubClassCase.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdPubClassCase + "'");
 }
 
 if (objPubClassCaseFreeSenateEN.UserId !=  null)
 {
 arrFieldListForInsert.Add(conPubClassCaseFreeSenate.UserId);
 var strUserId = objPubClassCaseFreeSenateEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserId + "'");
 }
 
 if (objPubClassCaseFreeSenateEN.AppraiseTheme !=  null)
 {
 arrFieldListForInsert.Add(conPubClassCaseFreeSenate.AppraiseTheme);
 var strAppraiseTheme = objPubClassCaseFreeSenateEN.AppraiseTheme.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAppraiseTheme + "'");
 }
 
 if (objPubClassCaseFreeSenateEN.PubClassCaseFreeSenateTitle !=  null)
 {
 arrFieldListForInsert.Add(conPubClassCaseFreeSenate.PubClassCaseFreeSenateTitle);
 var strPubClassCaseFreeSenateTitle = objPubClassCaseFreeSenateEN.PubClassCaseFreeSenateTitle.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPubClassCaseFreeSenateTitle + "'");
 }
 
 if (objPubClassCaseFreeSenateEN.PubClassCaseFreeSenateConten !=  null)
 {
 arrFieldListForInsert.Add(conPubClassCaseFreeSenate.PubClassCaseFreeSenateConten);
 var strPubClassCaseFreeSenateConten = objPubClassCaseFreeSenateEN.PubClassCaseFreeSenateConten.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPubClassCaseFreeSenateConten + "'");
 }
 
 if (objPubClassCaseFreeSenateEN.PubClassCaseFreeSenateDate !=  null)
 {
 arrFieldListForInsert.Add(conPubClassCaseFreeSenate.PubClassCaseFreeSenateDate);
 var strPubClassCaseFreeSenateDate = objPubClassCaseFreeSenateEN.PubClassCaseFreeSenateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPubClassCaseFreeSenateDate + "'");
 }
 
 if (objPubClassCaseFreeSenateEN.PubClassCaseFreeSenateTime !=  null)
 {
 arrFieldListForInsert.Add(conPubClassCaseFreeSenate.PubClassCaseFreeSenateTime);
 var strPubClassCaseFreeSenateTime = objPubClassCaseFreeSenateEN.PubClassCaseFreeSenateTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPubClassCaseFreeSenateTime + "'");
 }
 
 if (objPubClassCaseFreeSenateEN.VideoStopTime !=  null)
 {
 arrFieldListForInsert.Add(conPubClassCaseFreeSenate.VideoStopTime);
 var strVideoStopTime = objPubClassCaseFreeSenateEN.VideoStopTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVideoStopTime + "'");
 }
 
 
 if (objPubClassCaseFreeSenateEN.BrowseCount !=  null)
 {
 arrFieldListForInsert.Add(conPubClassCaseFreeSenate.BrowseCount);
 arrValueListForInsert.Add(objPubClassCaseFreeSenateEN.BrowseCount.ToString());
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into PubClassCaseFreeSenate");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPubClassCaseFreeSenateDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewPubClassCaseFreeSenates(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPubClassCaseFreeSenateDA.GetSpecSQLObj();
strSQL = "Select * from PubClassCaseFreeSenate where IdPubClassCaseFreeSenate = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "PubClassCaseFreeSenate");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
long lngIdPubClassCaseFreeSenate = TransNullToInt(oRow[conPubClassCaseFreeSenate.IdPubClassCaseFreeSenate].ToString().Trim());
if (IsExist(lngIdPubClassCaseFreeSenate))
{
 string strResult = "关键字变量值为:" + string.Format("IdPubClassCaseFreeSenate = {0}", lngIdPubClassCaseFreeSenate) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsPubClassCaseFreeSenateEN._CurrTabName ].NewRow();
objRow[conPubClassCaseFreeSenate.IdPubClassCase] = oRow[conPubClassCaseFreeSenate.IdPubClassCase].ToString().Trim(); //案例流水号
objRow[conPubClassCaseFreeSenate.UserId] = oRow[conPubClassCaseFreeSenate.UserId].ToString().Trim(); //用户ID
objRow[conPubClassCaseFreeSenate.AppraiseTheme] = oRow[conPubClassCaseFreeSenate.AppraiseTheme].ToString().Trim(); //评议主题
objRow[conPubClassCaseFreeSenate.PubClassCaseFreeSenateTitle] = oRow[conPubClassCaseFreeSenate.PubClassCaseFreeSenateTitle].ToString().Trim(); //公开课案例自由评议标题
objRow[conPubClassCaseFreeSenate.PubClassCaseFreeSenateConten] = oRow[conPubClassCaseFreeSenate.PubClassCaseFreeSenateConten].ToString().Trim(); //公开课案例自由评议内容
objRow[conPubClassCaseFreeSenate.PubClassCaseFreeSenateDate] = oRow[conPubClassCaseFreeSenate.PubClassCaseFreeSenateDate].ToString().Trim(); //公开课案例自由评议日期
objRow[conPubClassCaseFreeSenate.PubClassCaseFreeSenateTime] = oRow[conPubClassCaseFreeSenate.PubClassCaseFreeSenateTime].ToString().Trim(); //公开课案例自由评议时间
objRow[conPubClassCaseFreeSenate.VideoStopTime] = oRow[conPubClassCaseFreeSenate.VideoStopTime].ToString().Trim(); //公开课案例视频暂停时间
objRow[conPubClassCaseFreeSenate.VideoStopImage] = oRow[conPubClassCaseFreeSenate.VideoStopImage].ToString().Trim(); //公开课案例视频暂停截图
objRow[conPubClassCaseFreeSenate.BrowseCount] = oRow[conPubClassCaseFreeSenate.BrowseCount].ToString().Trim(); //浏览次数
 objDS.Tables[clsPubClassCaseFreeSenateEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsPubClassCaseFreeSenateEN._CurrTabName);
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
 /// <param name = "objPubClassCaseFreeSenateEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsPubClassCaseFreeSenateEN objPubClassCaseFreeSenateEN)
{
 if (objPubClassCaseFreeSenateEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objPubClassCaseFreeSenateEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPubClassCaseFreeSenateDA.GetSpecSQLObj();
strSQL = "Select * from PubClassCaseFreeSenate where IdPubClassCaseFreeSenate = " + ""+ objPubClassCaseFreeSenateEN.IdPubClassCaseFreeSenate+"";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsPubClassCaseFreeSenateEN._CurrTabName);
if (objDS.Tables[clsPubClassCaseFreeSenateEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:IdPubClassCaseFreeSenate = " + ""+ objPubClassCaseFreeSenateEN.IdPubClassCaseFreeSenate+"");
return false;
}
objRow = objDS.Tables[clsPubClassCaseFreeSenateEN._CurrTabName].Rows[0];
 if (objPubClassCaseFreeSenateEN.IsUpdated(conPubClassCaseFreeSenate.IdPubClassCase))
 {
objRow[conPubClassCaseFreeSenate.IdPubClassCase] = objPubClassCaseFreeSenateEN.IdPubClassCase; //案例流水号
 }
 if (objPubClassCaseFreeSenateEN.IsUpdated(conPubClassCaseFreeSenate.UserId))
 {
objRow[conPubClassCaseFreeSenate.UserId] = objPubClassCaseFreeSenateEN.UserId; //用户ID
 }
 if (objPubClassCaseFreeSenateEN.IsUpdated(conPubClassCaseFreeSenate.AppraiseTheme))
 {
objRow[conPubClassCaseFreeSenate.AppraiseTheme] = objPubClassCaseFreeSenateEN.AppraiseTheme; //评议主题
 }
 if (objPubClassCaseFreeSenateEN.IsUpdated(conPubClassCaseFreeSenate.PubClassCaseFreeSenateTitle))
 {
objRow[conPubClassCaseFreeSenate.PubClassCaseFreeSenateTitle] = objPubClassCaseFreeSenateEN.PubClassCaseFreeSenateTitle; //公开课案例自由评议标题
 }
 if (objPubClassCaseFreeSenateEN.IsUpdated(conPubClassCaseFreeSenate.PubClassCaseFreeSenateConten))
 {
objRow[conPubClassCaseFreeSenate.PubClassCaseFreeSenateConten] = objPubClassCaseFreeSenateEN.PubClassCaseFreeSenateConten; //公开课案例自由评议内容
 }
 if (objPubClassCaseFreeSenateEN.IsUpdated(conPubClassCaseFreeSenate.PubClassCaseFreeSenateDate))
 {
objRow[conPubClassCaseFreeSenate.PubClassCaseFreeSenateDate] = objPubClassCaseFreeSenateEN.PubClassCaseFreeSenateDate; //公开课案例自由评议日期
 }
 if (objPubClassCaseFreeSenateEN.IsUpdated(conPubClassCaseFreeSenate.PubClassCaseFreeSenateTime))
 {
objRow[conPubClassCaseFreeSenate.PubClassCaseFreeSenateTime] = objPubClassCaseFreeSenateEN.PubClassCaseFreeSenateTime; //公开课案例自由评议时间
 }
 if (objPubClassCaseFreeSenateEN.IsUpdated(conPubClassCaseFreeSenate.VideoStopTime))
 {
objRow[conPubClassCaseFreeSenate.VideoStopTime] = objPubClassCaseFreeSenateEN.VideoStopTime; //公开课案例视频暂停时间
 }
 if (objPubClassCaseFreeSenateEN.IsUpdated(conPubClassCaseFreeSenate.VideoStopImage))
 {
objRow[conPubClassCaseFreeSenate.VideoStopImage] = objPubClassCaseFreeSenateEN.VideoStopImage; //公开课案例视频暂停截图
 }
 if (objPubClassCaseFreeSenateEN.IsUpdated(conPubClassCaseFreeSenate.BrowseCount))
 {
objRow[conPubClassCaseFreeSenate.BrowseCount] = objPubClassCaseFreeSenateEN.BrowseCount; //浏览次数
 }
try
{
objDA.Update(objDS, clsPubClassCaseFreeSenateEN._CurrTabName);
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
 /// <param name = "objPubClassCaseFreeSenateEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsPubClassCaseFreeSenateEN objPubClassCaseFreeSenateEN)
{
 if (objPubClassCaseFreeSenateEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objPubClassCaseFreeSenateEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPubClassCaseFreeSenateDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update PubClassCaseFreeSenate Set ");
 
 if (objPubClassCaseFreeSenateEN.IsUpdated(conPubClassCaseFreeSenate.IdPubClassCase))
 {
 if (objPubClassCaseFreeSenateEN.IdPubClassCase  ==  "")
 {
 objPubClassCaseFreeSenateEN.IdPubClassCase = null;
 }
 if (objPubClassCaseFreeSenateEN.IdPubClassCase !=  null)
 {
 var strIdPubClassCase = objPubClassCaseFreeSenateEN.IdPubClassCase.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdPubClassCase, conPubClassCaseFreeSenate.IdPubClassCase); //案例流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPubClassCaseFreeSenate.IdPubClassCase); //案例流水号
 }
 }
 
 if (objPubClassCaseFreeSenateEN.IsUpdated(conPubClassCaseFreeSenate.UserId))
 {
 if (objPubClassCaseFreeSenateEN.UserId !=  null)
 {
 var strUserId = objPubClassCaseFreeSenateEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUserId, conPubClassCaseFreeSenate.UserId); //用户ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPubClassCaseFreeSenate.UserId); //用户ID
 }
 }
 
 if (objPubClassCaseFreeSenateEN.IsUpdated(conPubClassCaseFreeSenate.AppraiseTheme))
 {
 if (objPubClassCaseFreeSenateEN.AppraiseTheme !=  null)
 {
 var strAppraiseTheme = objPubClassCaseFreeSenateEN.AppraiseTheme.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strAppraiseTheme, conPubClassCaseFreeSenate.AppraiseTheme); //评议主题
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPubClassCaseFreeSenate.AppraiseTheme); //评议主题
 }
 }
 
 if (objPubClassCaseFreeSenateEN.IsUpdated(conPubClassCaseFreeSenate.PubClassCaseFreeSenateTitle))
 {
 if (objPubClassCaseFreeSenateEN.PubClassCaseFreeSenateTitle !=  null)
 {
 var strPubClassCaseFreeSenateTitle = objPubClassCaseFreeSenateEN.PubClassCaseFreeSenateTitle.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPubClassCaseFreeSenateTitle, conPubClassCaseFreeSenate.PubClassCaseFreeSenateTitle); //公开课案例自由评议标题
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPubClassCaseFreeSenate.PubClassCaseFreeSenateTitle); //公开课案例自由评议标题
 }
 }
 
 if (objPubClassCaseFreeSenateEN.IsUpdated(conPubClassCaseFreeSenate.PubClassCaseFreeSenateConten))
 {
 if (objPubClassCaseFreeSenateEN.PubClassCaseFreeSenateConten !=  null)
 {
 var strPubClassCaseFreeSenateConten = objPubClassCaseFreeSenateEN.PubClassCaseFreeSenateConten.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPubClassCaseFreeSenateConten, conPubClassCaseFreeSenate.PubClassCaseFreeSenateConten); //公开课案例自由评议内容
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPubClassCaseFreeSenate.PubClassCaseFreeSenateConten); //公开课案例自由评议内容
 }
 }
 
 if (objPubClassCaseFreeSenateEN.IsUpdated(conPubClassCaseFreeSenate.PubClassCaseFreeSenateDate))
 {
 if (objPubClassCaseFreeSenateEN.PubClassCaseFreeSenateDate !=  null)
 {
 var strPubClassCaseFreeSenateDate = objPubClassCaseFreeSenateEN.PubClassCaseFreeSenateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPubClassCaseFreeSenateDate, conPubClassCaseFreeSenate.PubClassCaseFreeSenateDate); //公开课案例自由评议日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPubClassCaseFreeSenate.PubClassCaseFreeSenateDate); //公开课案例自由评议日期
 }
 }
 
 if (objPubClassCaseFreeSenateEN.IsUpdated(conPubClassCaseFreeSenate.PubClassCaseFreeSenateTime))
 {
 if (objPubClassCaseFreeSenateEN.PubClassCaseFreeSenateTime !=  null)
 {
 var strPubClassCaseFreeSenateTime = objPubClassCaseFreeSenateEN.PubClassCaseFreeSenateTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPubClassCaseFreeSenateTime, conPubClassCaseFreeSenate.PubClassCaseFreeSenateTime); //公开课案例自由评议时间
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPubClassCaseFreeSenate.PubClassCaseFreeSenateTime); //公开课案例自由评议时间
 }
 }
 
 if (objPubClassCaseFreeSenateEN.IsUpdated(conPubClassCaseFreeSenate.VideoStopTime))
 {
 if (objPubClassCaseFreeSenateEN.VideoStopTime !=  null)
 {
 var strVideoStopTime = objPubClassCaseFreeSenateEN.VideoStopTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strVideoStopTime, conPubClassCaseFreeSenate.VideoStopTime); //公开课案例视频暂停时间
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPubClassCaseFreeSenate.VideoStopTime); //公开课案例视频暂停时间
 }
 }
 
 if (objPubClassCaseFreeSenateEN.IsUpdated(conPubClassCaseFreeSenate.VideoStopImage))
 {
 sbSQL.AppendFormat("{1} = '{0}',", objPubClassCaseFreeSenateEN.VideoStopImage, conPubClassCaseFreeSenate.VideoStopImage); //公开课案例视频暂停截图
 }
 
 if (objPubClassCaseFreeSenateEN.IsUpdated(conPubClassCaseFreeSenate.BrowseCount))
 {
 if (objPubClassCaseFreeSenateEN.BrowseCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objPubClassCaseFreeSenateEN.BrowseCount, conPubClassCaseFreeSenate.BrowseCount); //浏览次数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPubClassCaseFreeSenate.BrowseCount); //浏览次数
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where IdPubClassCaseFreeSenate = {0}", objPubClassCaseFreeSenateEN.IdPubClassCaseFreeSenate); 
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
 /// <param name = "objPubClassCaseFreeSenateEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsPubClassCaseFreeSenateEN objPubClassCaseFreeSenateEN, string strCondition)
{
 if (objPubClassCaseFreeSenateEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objPubClassCaseFreeSenateEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPubClassCaseFreeSenateDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update PubClassCaseFreeSenate Set ");
 
 if (objPubClassCaseFreeSenateEN.IsUpdated(conPubClassCaseFreeSenate.IdPubClassCase))
 {
 if (objPubClassCaseFreeSenateEN.IdPubClassCase  ==  "")
 {
 objPubClassCaseFreeSenateEN.IdPubClassCase = null;
 }
 if (objPubClassCaseFreeSenateEN.IdPubClassCase !=  null)
 {
 var strIdPubClassCase = objPubClassCaseFreeSenateEN.IdPubClassCase.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdPubClassCase = '{0}',", strIdPubClassCase); //案例流水号
 }
 else
 {
 sbSQL.Append(" IdPubClassCase = null,"); //案例流水号
 }
 }
 
 if (objPubClassCaseFreeSenateEN.IsUpdated(conPubClassCaseFreeSenate.UserId))
 {
 if (objPubClassCaseFreeSenateEN.UserId !=  null)
 {
 var strUserId = objPubClassCaseFreeSenateEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UserId = '{0}',", strUserId); //用户ID
 }
 else
 {
 sbSQL.Append(" UserId = null,"); //用户ID
 }
 }
 
 if (objPubClassCaseFreeSenateEN.IsUpdated(conPubClassCaseFreeSenate.AppraiseTheme))
 {
 if (objPubClassCaseFreeSenateEN.AppraiseTheme !=  null)
 {
 var strAppraiseTheme = objPubClassCaseFreeSenateEN.AppraiseTheme.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" AppraiseTheme = '{0}',", strAppraiseTheme); //评议主题
 }
 else
 {
 sbSQL.Append(" AppraiseTheme = null,"); //评议主题
 }
 }
 
 if (objPubClassCaseFreeSenateEN.IsUpdated(conPubClassCaseFreeSenate.PubClassCaseFreeSenateTitle))
 {
 if (objPubClassCaseFreeSenateEN.PubClassCaseFreeSenateTitle !=  null)
 {
 var strPubClassCaseFreeSenateTitle = objPubClassCaseFreeSenateEN.PubClassCaseFreeSenateTitle.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PubClassCaseFreeSenateTitle = '{0}',", strPubClassCaseFreeSenateTitle); //公开课案例自由评议标题
 }
 else
 {
 sbSQL.Append(" PubClassCaseFreeSenateTitle = null,"); //公开课案例自由评议标题
 }
 }
 
 if (objPubClassCaseFreeSenateEN.IsUpdated(conPubClassCaseFreeSenate.PubClassCaseFreeSenateConten))
 {
 if (objPubClassCaseFreeSenateEN.PubClassCaseFreeSenateConten !=  null)
 {
 var strPubClassCaseFreeSenateConten = objPubClassCaseFreeSenateEN.PubClassCaseFreeSenateConten.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PubClassCaseFreeSenateConten = '{0}',", strPubClassCaseFreeSenateConten); //公开课案例自由评议内容
 }
 else
 {
 sbSQL.Append(" PubClassCaseFreeSenateConten = null,"); //公开课案例自由评议内容
 }
 }
 
 if (objPubClassCaseFreeSenateEN.IsUpdated(conPubClassCaseFreeSenate.PubClassCaseFreeSenateDate))
 {
 if (objPubClassCaseFreeSenateEN.PubClassCaseFreeSenateDate !=  null)
 {
 var strPubClassCaseFreeSenateDate = objPubClassCaseFreeSenateEN.PubClassCaseFreeSenateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PubClassCaseFreeSenateDate = '{0}',", strPubClassCaseFreeSenateDate); //公开课案例自由评议日期
 }
 else
 {
 sbSQL.Append(" PubClassCaseFreeSenateDate = null,"); //公开课案例自由评议日期
 }
 }
 
 if (objPubClassCaseFreeSenateEN.IsUpdated(conPubClassCaseFreeSenate.PubClassCaseFreeSenateTime))
 {
 if (objPubClassCaseFreeSenateEN.PubClassCaseFreeSenateTime !=  null)
 {
 var strPubClassCaseFreeSenateTime = objPubClassCaseFreeSenateEN.PubClassCaseFreeSenateTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PubClassCaseFreeSenateTime = '{0}',", strPubClassCaseFreeSenateTime); //公开课案例自由评议时间
 }
 else
 {
 sbSQL.Append(" PubClassCaseFreeSenateTime = null,"); //公开课案例自由评议时间
 }
 }
 
 if (objPubClassCaseFreeSenateEN.IsUpdated(conPubClassCaseFreeSenate.VideoStopTime))
 {
 if (objPubClassCaseFreeSenateEN.VideoStopTime !=  null)
 {
 var strVideoStopTime = objPubClassCaseFreeSenateEN.VideoStopTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" VideoStopTime = '{0}',", strVideoStopTime); //公开课案例视频暂停时间
 }
 else
 {
 sbSQL.Append(" VideoStopTime = null,"); //公开课案例视频暂停时间
 }
 }
 
 if (objPubClassCaseFreeSenateEN.IsUpdated(conPubClassCaseFreeSenate.VideoStopImage))
 {
 sbSQL.AppendFormat(" VideoStopImage = '{0}',", objPubClassCaseFreeSenateEN.VideoStopImage); //公开课案例视频暂停截图
 }
 
 if (objPubClassCaseFreeSenateEN.IsUpdated(conPubClassCaseFreeSenate.BrowseCount))
 {
 sbSQL.AppendFormat(" BrowseCount = {0},", objPubClassCaseFreeSenateEN.BrowseCount); //浏览次数
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
 /// <param name = "objPubClassCaseFreeSenateEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsPubClassCaseFreeSenateEN objPubClassCaseFreeSenateEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objPubClassCaseFreeSenateEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objPubClassCaseFreeSenateEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPubClassCaseFreeSenateDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update PubClassCaseFreeSenate Set ");
 
 if (objPubClassCaseFreeSenateEN.IsUpdated(conPubClassCaseFreeSenate.IdPubClassCase))
 {
 if (objPubClassCaseFreeSenateEN.IdPubClassCase  ==  "")
 {
 objPubClassCaseFreeSenateEN.IdPubClassCase = null;
 }
 if (objPubClassCaseFreeSenateEN.IdPubClassCase !=  null)
 {
 var strIdPubClassCase = objPubClassCaseFreeSenateEN.IdPubClassCase.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdPubClassCase = '{0}',", strIdPubClassCase); //案例流水号
 }
 else
 {
 sbSQL.Append(" IdPubClassCase = null,"); //案例流水号
 }
 }
 
 if (objPubClassCaseFreeSenateEN.IsUpdated(conPubClassCaseFreeSenate.UserId))
 {
 if (objPubClassCaseFreeSenateEN.UserId !=  null)
 {
 var strUserId = objPubClassCaseFreeSenateEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UserId = '{0}',", strUserId); //用户ID
 }
 else
 {
 sbSQL.Append(" UserId = null,"); //用户ID
 }
 }
 
 if (objPubClassCaseFreeSenateEN.IsUpdated(conPubClassCaseFreeSenate.AppraiseTheme))
 {
 if (objPubClassCaseFreeSenateEN.AppraiseTheme !=  null)
 {
 var strAppraiseTheme = objPubClassCaseFreeSenateEN.AppraiseTheme.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" AppraiseTheme = '{0}',", strAppraiseTheme); //评议主题
 }
 else
 {
 sbSQL.Append(" AppraiseTheme = null,"); //评议主题
 }
 }
 
 if (objPubClassCaseFreeSenateEN.IsUpdated(conPubClassCaseFreeSenate.PubClassCaseFreeSenateTitle))
 {
 if (objPubClassCaseFreeSenateEN.PubClassCaseFreeSenateTitle !=  null)
 {
 var strPubClassCaseFreeSenateTitle = objPubClassCaseFreeSenateEN.PubClassCaseFreeSenateTitle.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PubClassCaseFreeSenateTitle = '{0}',", strPubClassCaseFreeSenateTitle); //公开课案例自由评议标题
 }
 else
 {
 sbSQL.Append(" PubClassCaseFreeSenateTitle = null,"); //公开课案例自由评议标题
 }
 }
 
 if (objPubClassCaseFreeSenateEN.IsUpdated(conPubClassCaseFreeSenate.PubClassCaseFreeSenateConten))
 {
 if (objPubClassCaseFreeSenateEN.PubClassCaseFreeSenateConten !=  null)
 {
 var strPubClassCaseFreeSenateConten = objPubClassCaseFreeSenateEN.PubClassCaseFreeSenateConten.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PubClassCaseFreeSenateConten = '{0}',", strPubClassCaseFreeSenateConten); //公开课案例自由评议内容
 }
 else
 {
 sbSQL.Append(" PubClassCaseFreeSenateConten = null,"); //公开课案例自由评议内容
 }
 }
 
 if (objPubClassCaseFreeSenateEN.IsUpdated(conPubClassCaseFreeSenate.PubClassCaseFreeSenateDate))
 {
 if (objPubClassCaseFreeSenateEN.PubClassCaseFreeSenateDate !=  null)
 {
 var strPubClassCaseFreeSenateDate = objPubClassCaseFreeSenateEN.PubClassCaseFreeSenateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PubClassCaseFreeSenateDate = '{0}',", strPubClassCaseFreeSenateDate); //公开课案例自由评议日期
 }
 else
 {
 sbSQL.Append(" PubClassCaseFreeSenateDate = null,"); //公开课案例自由评议日期
 }
 }
 
 if (objPubClassCaseFreeSenateEN.IsUpdated(conPubClassCaseFreeSenate.PubClassCaseFreeSenateTime))
 {
 if (objPubClassCaseFreeSenateEN.PubClassCaseFreeSenateTime !=  null)
 {
 var strPubClassCaseFreeSenateTime = objPubClassCaseFreeSenateEN.PubClassCaseFreeSenateTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PubClassCaseFreeSenateTime = '{0}',", strPubClassCaseFreeSenateTime); //公开课案例自由评议时间
 }
 else
 {
 sbSQL.Append(" PubClassCaseFreeSenateTime = null,"); //公开课案例自由评议时间
 }
 }
 
 if (objPubClassCaseFreeSenateEN.IsUpdated(conPubClassCaseFreeSenate.VideoStopTime))
 {
 if (objPubClassCaseFreeSenateEN.VideoStopTime !=  null)
 {
 var strVideoStopTime = objPubClassCaseFreeSenateEN.VideoStopTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" VideoStopTime = '{0}',", strVideoStopTime); //公开课案例视频暂停时间
 }
 else
 {
 sbSQL.Append(" VideoStopTime = null,"); //公开课案例视频暂停时间
 }
 }
 
 if (objPubClassCaseFreeSenateEN.IsUpdated(conPubClassCaseFreeSenate.VideoStopImage))
 {
 sbSQL.AppendFormat(" VideoStopImage = '{0}',", objPubClassCaseFreeSenateEN.VideoStopImage); //公开课案例视频暂停截图
 }
 
 if (objPubClassCaseFreeSenateEN.IsUpdated(conPubClassCaseFreeSenate.BrowseCount))
 {
 sbSQL.AppendFormat(" BrowseCount = {0},", objPubClassCaseFreeSenateEN.BrowseCount); //浏览次数
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
 /// <param name = "objPubClassCaseFreeSenateEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsPubClassCaseFreeSenateEN objPubClassCaseFreeSenateEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objPubClassCaseFreeSenateEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objPubClassCaseFreeSenateEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPubClassCaseFreeSenateDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update PubClassCaseFreeSenate Set ");
 
 if (objPubClassCaseFreeSenateEN.IsUpdated(conPubClassCaseFreeSenate.IdPubClassCase))
 {
 if (objPubClassCaseFreeSenateEN.IdPubClassCase  ==  "")
 {
 objPubClassCaseFreeSenateEN.IdPubClassCase = null;
 }
 if (objPubClassCaseFreeSenateEN.IdPubClassCase !=  null)
 {
 var strIdPubClassCase = objPubClassCaseFreeSenateEN.IdPubClassCase.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdPubClassCase, conPubClassCaseFreeSenate.IdPubClassCase); //案例流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPubClassCaseFreeSenate.IdPubClassCase); //案例流水号
 }
 }
 
 if (objPubClassCaseFreeSenateEN.IsUpdated(conPubClassCaseFreeSenate.UserId))
 {
 if (objPubClassCaseFreeSenateEN.UserId !=  null)
 {
 var strUserId = objPubClassCaseFreeSenateEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUserId, conPubClassCaseFreeSenate.UserId); //用户ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPubClassCaseFreeSenate.UserId); //用户ID
 }
 }
 
 if (objPubClassCaseFreeSenateEN.IsUpdated(conPubClassCaseFreeSenate.AppraiseTheme))
 {
 if (objPubClassCaseFreeSenateEN.AppraiseTheme !=  null)
 {
 var strAppraiseTheme = objPubClassCaseFreeSenateEN.AppraiseTheme.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strAppraiseTheme, conPubClassCaseFreeSenate.AppraiseTheme); //评议主题
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPubClassCaseFreeSenate.AppraiseTheme); //评议主题
 }
 }
 
 if (objPubClassCaseFreeSenateEN.IsUpdated(conPubClassCaseFreeSenate.PubClassCaseFreeSenateTitle))
 {
 if (objPubClassCaseFreeSenateEN.PubClassCaseFreeSenateTitle !=  null)
 {
 var strPubClassCaseFreeSenateTitle = objPubClassCaseFreeSenateEN.PubClassCaseFreeSenateTitle.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPubClassCaseFreeSenateTitle, conPubClassCaseFreeSenate.PubClassCaseFreeSenateTitle); //公开课案例自由评议标题
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPubClassCaseFreeSenate.PubClassCaseFreeSenateTitle); //公开课案例自由评议标题
 }
 }
 
 if (objPubClassCaseFreeSenateEN.IsUpdated(conPubClassCaseFreeSenate.PubClassCaseFreeSenateConten))
 {
 if (objPubClassCaseFreeSenateEN.PubClassCaseFreeSenateConten !=  null)
 {
 var strPubClassCaseFreeSenateConten = objPubClassCaseFreeSenateEN.PubClassCaseFreeSenateConten.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPubClassCaseFreeSenateConten, conPubClassCaseFreeSenate.PubClassCaseFreeSenateConten); //公开课案例自由评议内容
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPubClassCaseFreeSenate.PubClassCaseFreeSenateConten); //公开课案例自由评议内容
 }
 }
 
 if (objPubClassCaseFreeSenateEN.IsUpdated(conPubClassCaseFreeSenate.PubClassCaseFreeSenateDate))
 {
 if (objPubClassCaseFreeSenateEN.PubClassCaseFreeSenateDate !=  null)
 {
 var strPubClassCaseFreeSenateDate = objPubClassCaseFreeSenateEN.PubClassCaseFreeSenateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPubClassCaseFreeSenateDate, conPubClassCaseFreeSenate.PubClassCaseFreeSenateDate); //公开课案例自由评议日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPubClassCaseFreeSenate.PubClassCaseFreeSenateDate); //公开课案例自由评议日期
 }
 }
 
 if (objPubClassCaseFreeSenateEN.IsUpdated(conPubClassCaseFreeSenate.PubClassCaseFreeSenateTime))
 {
 if (objPubClassCaseFreeSenateEN.PubClassCaseFreeSenateTime !=  null)
 {
 var strPubClassCaseFreeSenateTime = objPubClassCaseFreeSenateEN.PubClassCaseFreeSenateTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPubClassCaseFreeSenateTime, conPubClassCaseFreeSenate.PubClassCaseFreeSenateTime); //公开课案例自由评议时间
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPubClassCaseFreeSenate.PubClassCaseFreeSenateTime); //公开课案例自由评议时间
 }
 }
 
 if (objPubClassCaseFreeSenateEN.IsUpdated(conPubClassCaseFreeSenate.VideoStopTime))
 {
 if (objPubClassCaseFreeSenateEN.VideoStopTime !=  null)
 {
 var strVideoStopTime = objPubClassCaseFreeSenateEN.VideoStopTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strVideoStopTime, conPubClassCaseFreeSenate.VideoStopTime); //公开课案例视频暂停时间
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPubClassCaseFreeSenate.VideoStopTime); //公开课案例视频暂停时间
 }
 }
 
 if (objPubClassCaseFreeSenateEN.IsUpdated(conPubClassCaseFreeSenate.VideoStopImage))
 {
 sbSQL.AppendFormat("{1} = '{0}',", objPubClassCaseFreeSenateEN.VideoStopImage, conPubClassCaseFreeSenate.VideoStopImage); //公开课案例视频暂停截图
 }
 
 if (objPubClassCaseFreeSenateEN.IsUpdated(conPubClassCaseFreeSenate.BrowseCount))
 {
 if (objPubClassCaseFreeSenateEN.BrowseCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objPubClassCaseFreeSenateEN.BrowseCount, conPubClassCaseFreeSenate.BrowseCount); //浏览次数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPubClassCaseFreeSenate.BrowseCount); //浏览次数
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where IdPubClassCaseFreeSenate = {0}", objPubClassCaseFreeSenateEN.IdPubClassCaseFreeSenate); 
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
 /// <param name = "lngIdPubClassCaseFreeSenate">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(long lngIdPubClassCaseFreeSenate) 
{
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPubClassCaseFreeSenateDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 lngIdPubClassCaseFreeSenate,
};
 objSQL.ExecSP("PubClassCaseFreeSenate_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "lngIdPubClassCaseFreeSenate">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(long lngIdPubClassCaseFreeSenate, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPubClassCaseFreeSenateDA.GetSpecSQLObj();
//删除PubClassCaseFreeSenate本表中与当前对象有关的记录
strSQL = strSQL + "Delete from PubClassCaseFreeSenate where IdPubClassCaseFreeSenate = " + ""+ lngIdPubClassCaseFreeSenate+"";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelPubClassCaseFreeSenate(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPubClassCaseFreeSenateDA.GetSpecSQLObj();
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
//删除PubClassCaseFreeSenate本表中与当前对象有关的记录
strSQL = strSQL + "Delete from PubClassCaseFreeSenate where IdPubClassCaseFreeSenate in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "lngIdPubClassCaseFreeSenate">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(long lngIdPubClassCaseFreeSenate) 
{
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPubClassCaseFreeSenateDA.GetSpecSQLObj();
//删除PubClassCaseFreeSenate本表中与当前对象有关的记录
strSQL = strSQL + "Delete from PubClassCaseFreeSenate where IdPubClassCaseFreeSenate = " + ""+ lngIdPubClassCaseFreeSenate+"";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelPubClassCaseFreeSenate(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsPubClassCaseFreeSenateDA: DelPubClassCaseFreeSenate)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPubClassCaseFreeSenateDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from PubClassCaseFreeSenate where " + strCondition ;
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
public bool DelPubClassCaseFreeSenateWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsPubClassCaseFreeSenateDA: DelPubClassCaseFreeSenateWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPubClassCaseFreeSenateDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from PubClassCaseFreeSenate where " + strCondition ;
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
 /// <param name = "objPubClassCaseFreeSenateENS">源对象</param>
 /// <param name = "objPubClassCaseFreeSenateENT">目标对象</param>
public void CopyTo(clsPubClassCaseFreeSenateEN objPubClassCaseFreeSenateENS, clsPubClassCaseFreeSenateEN objPubClassCaseFreeSenateENT)
{
objPubClassCaseFreeSenateENT.IdPubClassCaseFreeSenate = objPubClassCaseFreeSenateENS.IdPubClassCaseFreeSenate; //公开课案例自由评议流水号
objPubClassCaseFreeSenateENT.IdPubClassCase = objPubClassCaseFreeSenateENS.IdPubClassCase; //案例流水号
objPubClassCaseFreeSenateENT.UserId = objPubClassCaseFreeSenateENS.UserId; //用户ID
objPubClassCaseFreeSenateENT.AppraiseTheme = objPubClassCaseFreeSenateENS.AppraiseTheme; //评议主题
objPubClassCaseFreeSenateENT.PubClassCaseFreeSenateTitle = objPubClassCaseFreeSenateENS.PubClassCaseFreeSenateTitle; //公开课案例自由评议标题
objPubClassCaseFreeSenateENT.PubClassCaseFreeSenateConten = objPubClassCaseFreeSenateENS.PubClassCaseFreeSenateConten; //公开课案例自由评议内容
objPubClassCaseFreeSenateENT.PubClassCaseFreeSenateDate = objPubClassCaseFreeSenateENS.PubClassCaseFreeSenateDate; //公开课案例自由评议日期
objPubClassCaseFreeSenateENT.PubClassCaseFreeSenateTime = objPubClassCaseFreeSenateENS.PubClassCaseFreeSenateTime; //公开课案例自由评议时间
objPubClassCaseFreeSenateENT.VideoStopTime = objPubClassCaseFreeSenateENS.VideoStopTime; //公开课案例视频暂停时间
objPubClassCaseFreeSenateENT.VideoStopImage = objPubClassCaseFreeSenateENS.VideoStopImage; //公开课案例视频暂停截图
objPubClassCaseFreeSenateENT.BrowseCount = objPubClassCaseFreeSenateENS.BrowseCount; //浏览次数
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsPubClassCaseFreeSenateEN objPubClassCaseFreeSenateEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objPubClassCaseFreeSenateEN.IdPubClassCase, conPubClassCaseFreeSenate.IdPubClassCase);
clsCheckSql.CheckFieldNotNull(objPubClassCaseFreeSenateEN.UserId, conPubClassCaseFreeSenate.UserId);
//检查字段长度
clsCheckSql.CheckFieldLen(objPubClassCaseFreeSenateEN.IdPubClassCase, 8, conPubClassCaseFreeSenate.IdPubClassCase);
clsCheckSql.CheckFieldLen(objPubClassCaseFreeSenateEN.UserId, 18, conPubClassCaseFreeSenate.UserId);
clsCheckSql.CheckFieldLen(objPubClassCaseFreeSenateEN.AppraiseTheme, 200, conPubClassCaseFreeSenate.AppraiseTheme);
clsCheckSql.CheckFieldLen(objPubClassCaseFreeSenateEN.PubClassCaseFreeSenateTitle, 200, conPubClassCaseFreeSenate.PubClassCaseFreeSenateTitle);
clsCheckSql.CheckFieldLen(objPubClassCaseFreeSenateEN.PubClassCaseFreeSenateConten, 2000, conPubClassCaseFreeSenate.PubClassCaseFreeSenateConten);
clsCheckSql.CheckFieldLen(objPubClassCaseFreeSenateEN.PubClassCaseFreeSenateDate, 8, conPubClassCaseFreeSenate.PubClassCaseFreeSenateDate);
clsCheckSql.CheckFieldLen(objPubClassCaseFreeSenateEN.PubClassCaseFreeSenateTime, 6, conPubClassCaseFreeSenate.PubClassCaseFreeSenateTime);
clsCheckSql.CheckFieldLen(objPubClassCaseFreeSenateEN.VideoStopTime, 48, conPubClassCaseFreeSenate.VideoStopTime);
//检查字段外键固定长度
clsCheckSql.CheckFieldForeignKey(objPubClassCaseFreeSenateEN.IdPubClassCase, 8, conPubClassCaseFreeSenate.IdPubClassCase);
 objPubClassCaseFreeSenateEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsPubClassCaseFreeSenateEN objPubClassCaseFreeSenateEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objPubClassCaseFreeSenateEN.IdPubClassCase, 8, conPubClassCaseFreeSenate.IdPubClassCase);
clsCheckSql.CheckFieldLen(objPubClassCaseFreeSenateEN.UserId, 18, conPubClassCaseFreeSenate.UserId);
clsCheckSql.CheckFieldLen(objPubClassCaseFreeSenateEN.AppraiseTheme, 200, conPubClassCaseFreeSenate.AppraiseTheme);
clsCheckSql.CheckFieldLen(objPubClassCaseFreeSenateEN.PubClassCaseFreeSenateTitle, 200, conPubClassCaseFreeSenate.PubClassCaseFreeSenateTitle);
clsCheckSql.CheckFieldLen(objPubClassCaseFreeSenateEN.PubClassCaseFreeSenateConten, 2000, conPubClassCaseFreeSenate.PubClassCaseFreeSenateConten);
clsCheckSql.CheckFieldLen(objPubClassCaseFreeSenateEN.PubClassCaseFreeSenateDate, 8, conPubClassCaseFreeSenate.PubClassCaseFreeSenateDate);
clsCheckSql.CheckFieldLen(objPubClassCaseFreeSenateEN.PubClassCaseFreeSenateTime, 6, conPubClassCaseFreeSenate.PubClassCaseFreeSenateTime);
clsCheckSql.CheckFieldLen(objPubClassCaseFreeSenateEN.VideoStopTime, 48, conPubClassCaseFreeSenate.VideoStopTime);
//检查外键字段长度
clsCheckSql.CheckFieldForeignKey(objPubClassCaseFreeSenateEN.IdPubClassCase, 8, conPubClassCaseFreeSenate.IdPubClassCase);
 objPubClassCaseFreeSenateEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsPubClassCaseFreeSenateEN objPubClassCaseFreeSenateEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objPubClassCaseFreeSenateEN.IdPubClassCase, 8, conPubClassCaseFreeSenate.IdPubClassCase);
clsCheckSql.CheckFieldLen(objPubClassCaseFreeSenateEN.UserId, 18, conPubClassCaseFreeSenate.UserId);
clsCheckSql.CheckFieldLen(objPubClassCaseFreeSenateEN.AppraiseTheme, 200, conPubClassCaseFreeSenate.AppraiseTheme);
clsCheckSql.CheckFieldLen(objPubClassCaseFreeSenateEN.PubClassCaseFreeSenateTitle, 200, conPubClassCaseFreeSenate.PubClassCaseFreeSenateTitle);
clsCheckSql.CheckFieldLen(objPubClassCaseFreeSenateEN.PubClassCaseFreeSenateConten, 2000, conPubClassCaseFreeSenate.PubClassCaseFreeSenateConten);
clsCheckSql.CheckFieldLen(objPubClassCaseFreeSenateEN.PubClassCaseFreeSenateDate, 8, conPubClassCaseFreeSenate.PubClassCaseFreeSenateDate);
clsCheckSql.CheckFieldLen(objPubClassCaseFreeSenateEN.PubClassCaseFreeSenateTime, 6, conPubClassCaseFreeSenate.PubClassCaseFreeSenateTime);
clsCheckSql.CheckFieldLen(objPubClassCaseFreeSenateEN.VideoStopTime, 48, conPubClassCaseFreeSenate.VideoStopTime);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objPubClassCaseFreeSenateEN.IdPubClassCase, conPubClassCaseFreeSenate.IdPubClassCase);
clsCheckSql.CheckSqlInjection4Field(objPubClassCaseFreeSenateEN.UserId, conPubClassCaseFreeSenate.UserId);
clsCheckSql.CheckSqlInjection4Field(objPubClassCaseFreeSenateEN.AppraiseTheme, conPubClassCaseFreeSenate.AppraiseTheme);
clsCheckSql.CheckSqlInjection4Field(objPubClassCaseFreeSenateEN.PubClassCaseFreeSenateTitle, conPubClassCaseFreeSenate.PubClassCaseFreeSenateTitle);
clsCheckSql.CheckSqlInjection4Field(objPubClassCaseFreeSenateEN.PubClassCaseFreeSenateConten, conPubClassCaseFreeSenate.PubClassCaseFreeSenateConten);
clsCheckSql.CheckSqlInjection4Field(objPubClassCaseFreeSenateEN.PubClassCaseFreeSenateDate, conPubClassCaseFreeSenate.PubClassCaseFreeSenateDate);
clsCheckSql.CheckSqlInjection4Field(objPubClassCaseFreeSenateEN.PubClassCaseFreeSenateTime, conPubClassCaseFreeSenate.PubClassCaseFreeSenateTime);
clsCheckSql.CheckSqlInjection4Field(objPubClassCaseFreeSenateEN.VideoStopTime, conPubClassCaseFreeSenate.VideoStopTime);
//检查外键字段长度
clsCheckSql.CheckFieldForeignKey(objPubClassCaseFreeSenateEN.IdPubClassCase, 8, conPubClassCaseFreeSenate.IdPubClassCase);
 objPubClassCaseFreeSenateEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--PubClassCaseFreeSenate(公开课案例自由评议),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objPubClassCaseFreeSenateEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clsPubClassCaseFreeSenateEN objPubClassCaseFreeSenateEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and IdPubClassCase = '{0}'", objPubClassCaseFreeSenateEN.IdPubClassCase);
 sbCondition.AppendFormat(" and UserId = '{0}'", objPubClassCaseFreeSenateEN.UserId);
 if (objPubClassCaseFreeSenateEN.AppraiseTheme == null)
{
 sbCondition.AppendFormat(" and AppraiseTheme is null");
}
else
{
 sbCondition.AppendFormat(" and AppraiseTheme = '{0}'", objPubClassCaseFreeSenateEN.AppraiseTheme);
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
 objSQL = clsPubClassCaseFreeSenateDA.GetSpecSQLObj();
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
 objSQL = clsPubClassCaseFreeSenateDA.GetSpecSQLObj();
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
 objSQL = clsPubClassCaseFreeSenateDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsPubClassCaseFreeSenateEN._CurrTabName);
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
 objSQL = clsPubClassCaseFreeSenateDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsPubClassCaseFreeSenateEN._CurrTabName, strCondition);
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
 objSQL = clsPubClassCaseFreeSenateDA.GetSpecSQLObj();
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
 objSQL = clsPubClassCaseFreeSenateDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}