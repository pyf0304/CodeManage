
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsPubClassCaseSenateDA
 表名:PubClassCaseSenate(01120411)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:17:49
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
 /// 公开课案例评议(PubClassCaseSenate)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsPubClassCaseSenateDA : clsCommBase4DA
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
 return clsPubClassCaseSenateEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsPubClassCaseSenateEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsPubClassCaseSenateEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsPubClassCaseSenateEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsPubClassCaseSenateEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsPubClassCaseSenateDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPubClassCaseSenateDA.GetSpecSQLObj();
strSQL = "Select * from PubClassCaseSenate where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_PubClassCaseSenate(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsPubClassCaseSenateDA: GetDataTable_PubClassCaseSenate)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPubClassCaseSenateDA.GetSpecSQLObj();
strSQL = "Select * from PubClassCaseSenate where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsPubClassCaseSenateDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPubClassCaseSenateDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsPubClassCaseSenateDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPubClassCaseSenateDA.GetSpecSQLObj();
strSQL = "Select * from PubClassCaseSenate where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsPubClassCaseSenateDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPubClassCaseSenateDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsPubClassCaseSenateDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPubClassCaseSenateDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from PubClassCaseSenate where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from PubClassCaseSenate where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsPubClassCaseSenateDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPubClassCaseSenateDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from PubClassCaseSenate where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsPubClassCaseSenateDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPubClassCaseSenateDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} PubClassCaseSenate.* from PubClassCaseSenate Left Join {1} on {2} where {3} and PubClassCaseSenate.IdPubClassCaseSenate not in (Select top {5} PubClassCaseSenate.IdPubClassCaseSenate from PubClassCaseSenate Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from PubClassCaseSenate where {1} and IdPubClassCaseSenate not in (Select top {2} IdPubClassCaseSenate from PubClassCaseSenate where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from PubClassCaseSenate where {1} and IdPubClassCaseSenate not in (Select top {3} IdPubClassCaseSenate from PubClassCaseSenate where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsPubClassCaseSenateDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPubClassCaseSenateDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} PubClassCaseSenate.* from PubClassCaseSenate Left Join {1} on {2} where {3} and PubClassCaseSenate.IdPubClassCaseSenate not in (Select top {5} PubClassCaseSenate.IdPubClassCaseSenate from PubClassCaseSenate Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from PubClassCaseSenate where {1} and IdPubClassCaseSenate not in (Select top {2} IdPubClassCaseSenate from PubClassCaseSenate where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from PubClassCaseSenate where {1} and IdPubClassCaseSenate not in (Select top {3} IdPubClassCaseSenate from PubClassCaseSenate where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsPubClassCaseSenateEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsPubClassCaseSenateDA:GetObjLst)", objException.Message));
}
List<clsPubClassCaseSenateEN> arrObjLst = new List<clsPubClassCaseSenateEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPubClassCaseSenateDA.GetSpecSQLObj();
strSQL = "Select * from PubClassCaseSenate where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPubClassCaseSenateEN objPubClassCaseSenateEN = new clsPubClassCaseSenateEN();
try
{
objPubClassCaseSenateEN.IdPubClassCaseSenate = TransNullToInt(objRow[conPubClassCaseSenate.IdPubClassCaseSenate].ToString().Trim()); //公开课案例评议流水号
objPubClassCaseSenateEN.IdPubClassCase = objRow[conPubClassCaseSenate.IdPubClassCase].ToString().Trim(); //案例流水号
objPubClassCaseSenateEN.IdPubClassCaseSenateClass = objRow[conPubClassCaseSenate.IdPubClassCaseSenateClass].ToString().Trim(); //公开课案例评议类别流水号
objPubClassCaseSenateEN.PubClassCaseSenator = objRow[conPubClassCaseSenate.PubClassCaseSenator] == DBNull.Value ? null : objRow[conPubClassCaseSenate.PubClassCaseSenator].ToString().Trim(); //公开课案例评议者
objPubClassCaseSenateEN.PubClassCaseSenateTitle = objRow[conPubClassCaseSenate.PubClassCaseSenateTitle] == DBNull.Value ? null : objRow[conPubClassCaseSenate.PubClassCaseSenateTitle].ToString().Trim(); //公开课案例评议标题
objPubClassCaseSenateEN.PubClassCaseSenateContent = objRow[conPubClassCaseSenate.PubClassCaseSenateContent] == DBNull.Value ? null : objRow[conPubClassCaseSenate.PubClassCaseSenateContent].ToString().Trim(); //公开课案例评议内容
objPubClassCaseSenateEN.PubClassCaseSenateDate = objRow[conPubClassCaseSenate.PubClassCaseSenateDate] == DBNull.Value ? null : objRow[conPubClassCaseSenate.PubClassCaseSenateDate].ToString().Trim(); //公开课案例评议日期
objPubClassCaseSenateEN.PubClassCaseSenateTime = objRow[conPubClassCaseSenate.PubClassCaseSenateTime] == DBNull.Value ? null : objRow[conPubClassCaseSenate.PubClassCaseSenateTime].ToString().Trim(); //公开课案例评议时间
objPubClassCaseSenateEN.SenateReadCount = objRow[conPubClassCaseSenate.SenateReadCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conPubClassCaseSenate.SenateReadCount].ToString().Trim()); //评议阅读次数
objPubClassCaseSenateEN.IsVisual = TransNullToBool(objRow[conPubClassCaseSenate.IsVisual].ToString().Trim()); //隐藏标志
objPubClassCaseSenateEN.IsElite = TransNullToBool(objRow[conPubClassCaseSenate.IsElite].ToString().Trim()); //精华标志
objPubClassCaseSenateEN.IdResource = objRow[conPubClassCaseSenate.IdResource].ToString().Trim(); //资源流水号
objPubClassCaseSenateEN.IdMediaType = objRow[conPubClassCaseSenate.IdMediaType] == DBNull.Value ? null : objRow[conPubClassCaseSenate.IdMediaType].ToString().Trim(); //媒体格式流水号
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsPubClassCaseSenateDA: GetObjLst)", objException.Message));
}
objPubClassCaseSenateEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objPubClassCaseSenateEN);
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
public List<clsPubClassCaseSenateEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsPubClassCaseSenateDA:GetObjLstByTabName)", objException.Message));
}
List<clsPubClassCaseSenateEN> arrObjLst = new List<clsPubClassCaseSenateEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPubClassCaseSenateDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPubClassCaseSenateEN objPubClassCaseSenateEN = new clsPubClassCaseSenateEN();
try
{
objPubClassCaseSenateEN.IdPubClassCaseSenate = TransNullToInt(objRow[conPubClassCaseSenate.IdPubClassCaseSenate].ToString().Trim()); //公开课案例评议流水号
objPubClassCaseSenateEN.IdPubClassCase = objRow[conPubClassCaseSenate.IdPubClassCase].ToString().Trim(); //案例流水号
objPubClassCaseSenateEN.IdPubClassCaseSenateClass = objRow[conPubClassCaseSenate.IdPubClassCaseSenateClass].ToString().Trim(); //公开课案例评议类别流水号
objPubClassCaseSenateEN.PubClassCaseSenator = objRow[conPubClassCaseSenate.PubClassCaseSenator] == DBNull.Value ? null : objRow[conPubClassCaseSenate.PubClassCaseSenator].ToString().Trim(); //公开课案例评议者
objPubClassCaseSenateEN.PubClassCaseSenateTitle = objRow[conPubClassCaseSenate.PubClassCaseSenateTitle] == DBNull.Value ? null : objRow[conPubClassCaseSenate.PubClassCaseSenateTitle].ToString().Trim(); //公开课案例评议标题
objPubClassCaseSenateEN.PubClassCaseSenateContent = objRow[conPubClassCaseSenate.PubClassCaseSenateContent] == DBNull.Value ? null : objRow[conPubClassCaseSenate.PubClassCaseSenateContent].ToString().Trim(); //公开课案例评议内容
objPubClassCaseSenateEN.PubClassCaseSenateDate = objRow[conPubClassCaseSenate.PubClassCaseSenateDate] == DBNull.Value ? null : objRow[conPubClassCaseSenate.PubClassCaseSenateDate].ToString().Trim(); //公开课案例评议日期
objPubClassCaseSenateEN.PubClassCaseSenateTime = objRow[conPubClassCaseSenate.PubClassCaseSenateTime] == DBNull.Value ? null : objRow[conPubClassCaseSenate.PubClassCaseSenateTime].ToString().Trim(); //公开课案例评议时间
objPubClassCaseSenateEN.SenateReadCount = objRow[conPubClassCaseSenate.SenateReadCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conPubClassCaseSenate.SenateReadCount].ToString().Trim()); //评议阅读次数
objPubClassCaseSenateEN.IsVisual = TransNullToBool(objRow[conPubClassCaseSenate.IsVisual].ToString().Trim()); //隐藏标志
objPubClassCaseSenateEN.IsElite = TransNullToBool(objRow[conPubClassCaseSenate.IsElite].ToString().Trim()); //精华标志
objPubClassCaseSenateEN.IdResource = objRow[conPubClassCaseSenate.IdResource].ToString().Trim(); //资源流水号
objPubClassCaseSenateEN.IdMediaType = objRow[conPubClassCaseSenate.IdMediaType] == DBNull.Value ? null : objRow[conPubClassCaseSenate.IdMediaType].ToString().Trim(); //媒体格式流水号
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsPubClassCaseSenateDA: GetObjLst)", objException.Message));
}
objPubClassCaseSenateEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objPubClassCaseSenateEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objPubClassCaseSenateEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetPubClassCaseSenate(ref clsPubClassCaseSenateEN objPubClassCaseSenateEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPubClassCaseSenateDA.GetSpecSQLObj();
strSQL = "Select * from PubClassCaseSenate where IdPubClassCaseSenate = " + ""+ objPubClassCaseSenateEN.IdPubClassCaseSenate+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objPubClassCaseSenateEN.IdPubClassCaseSenate = TransNullToInt(objDT.Rows[0][conPubClassCaseSenate.IdPubClassCaseSenate].ToString().Trim()); //公开课案例评议流水号(字段类型:bigint,字段长度:8,是否可空:False)
 objPubClassCaseSenateEN.IdPubClassCase = objDT.Rows[0][conPubClassCaseSenate.IdPubClassCase].ToString().Trim(); //案例流水号(字段类型:char,字段长度:8,是否可空:False)
 objPubClassCaseSenateEN.IdPubClassCaseSenateClass = objDT.Rows[0][conPubClassCaseSenate.IdPubClassCaseSenateClass].ToString().Trim(); //公开课案例评议类别流水号(字段类型:char,字段长度:4,是否可空:False)
 objPubClassCaseSenateEN.PubClassCaseSenator = objDT.Rows[0][conPubClassCaseSenate.PubClassCaseSenator].ToString().Trim(); //公开课案例评议者(字段类型:varchar,字段长度:50,是否可空:True)
 objPubClassCaseSenateEN.PubClassCaseSenateTitle = objDT.Rows[0][conPubClassCaseSenate.PubClassCaseSenateTitle].ToString().Trim(); //公开课案例评议标题(字段类型:varchar,字段长度:200,是否可空:True)
 objPubClassCaseSenateEN.PubClassCaseSenateContent = objDT.Rows[0][conPubClassCaseSenate.PubClassCaseSenateContent].ToString().Trim(); //公开课案例评议内容(字段类型:varchar,字段长度:8000,是否可空:True)
 objPubClassCaseSenateEN.PubClassCaseSenateDate = objDT.Rows[0][conPubClassCaseSenate.PubClassCaseSenateDate].ToString().Trim(); //公开课案例评议日期(字段类型:char,字段长度:8,是否可空:True)
 objPubClassCaseSenateEN.PubClassCaseSenateTime = objDT.Rows[0][conPubClassCaseSenate.PubClassCaseSenateTime].ToString().Trim(); //公开课案例评议时间(字段类型:char,字段长度:6,是否可空:True)
 objPubClassCaseSenateEN.SenateReadCount = TransNullToInt(objDT.Rows[0][conPubClassCaseSenate.SenateReadCount].ToString().Trim()); //评议阅读次数(字段类型:int,字段长度:4,是否可空:True)
 objPubClassCaseSenateEN.IsVisual = TransNullToBool(objDT.Rows[0][conPubClassCaseSenate.IsVisual].ToString().Trim()); //隐藏标志(字段类型:bit,字段长度:1,是否可空:False)
 objPubClassCaseSenateEN.IsElite = TransNullToBool(objDT.Rows[0][conPubClassCaseSenate.IsElite].ToString().Trim()); //精华标志(字段类型:bit,字段长度:1,是否可空:False)
 objPubClassCaseSenateEN.IdResource = objDT.Rows[0][conPubClassCaseSenate.IdResource].ToString().Trim(); //资源流水号(字段类型:char,字段长度:8,是否可空:False)
 objPubClassCaseSenateEN.IdMediaType = objDT.Rows[0][conPubClassCaseSenate.IdMediaType].ToString().Trim(); //媒体格式流水号(字段类型:char,字段长度:4,是否可空:False)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsPubClassCaseSenateDA: GetPubClassCaseSenate)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngIdPubClassCaseSenate">表关键字</param>
 /// <returns>表对象</returns>
public clsPubClassCaseSenateEN GetObjByIdPubClassCaseSenate(long lngIdPubClassCaseSenate)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPubClassCaseSenateDA.GetSpecSQLObj();
strSQL = "Select * from PubClassCaseSenate where IdPubClassCaseSenate = " + ""+ lngIdPubClassCaseSenate+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsPubClassCaseSenateEN objPubClassCaseSenateEN = new clsPubClassCaseSenateEN();
try
{
 objPubClassCaseSenateEN.IdPubClassCaseSenate = Int32.Parse(objRow[conPubClassCaseSenate.IdPubClassCaseSenate].ToString().Trim()); //公开课案例评议流水号(字段类型:bigint,字段长度:8,是否可空:False)
 objPubClassCaseSenateEN.IdPubClassCase = objRow[conPubClassCaseSenate.IdPubClassCase].ToString().Trim(); //案例流水号(字段类型:char,字段长度:8,是否可空:False)
 objPubClassCaseSenateEN.IdPubClassCaseSenateClass = objRow[conPubClassCaseSenate.IdPubClassCaseSenateClass].ToString().Trim(); //公开课案例评议类别流水号(字段类型:char,字段长度:4,是否可空:False)
 objPubClassCaseSenateEN.PubClassCaseSenator = objRow[conPubClassCaseSenate.PubClassCaseSenator] == DBNull.Value ? null : objRow[conPubClassCaseSenate.PubClassCaseSenator].ToString().Trim(); //公开课案例评议者(字段类型:varchar,字段长度:50,是否可空:True)
 objPubClassCaseSenateEN.PubClassCaseSenateTitle = objRow[conPubClassCaseSenate.PubClassCaseSenateTitle] == DBNull.Value ? null : objRow[conPubClassCaseSenate.PubClassCaseSenateTitle].ToString().Trim(); //公开课案例评议标题(字段类型:varchar,字段长度:200,是否可空:True)
 objPubClassCaseSenateEN.PubClassCaseSenateContent = objRow[conPubClassCaseSenate.PubClassCaseSenateContent] == DBNull.Value ? null : objRow[conPubClassCaseSenate.PubClassCaseSenateContent].ToString().Trim(); //公开课案例评议内容(字段类型:varchar,字段长度:8000,是否可空:True)
 objPubClassCaseSenateEN.PubClassCaseSenateDate = objRow[conPubClassCaseSenate.PubClassCaseSenateDate] == DBNull.Value ? null : objRow[conPubClassCaseSenate.PubClassCaseSenateDate].ToString().Trim(); //公开课案例评议日期(字段类型:char,字段长度:8,是否可空:True)
 objPubClassCaseSenateEN.PubClassCaseSenateTime = objRow[conPubClassCaseSenate.PubClassCaseSenateTime] == DBNull.Value ? null : objRow[conPubClassCaseSenate.PubClassCaseSenateTime].ToString().Trim(); //公开课案例评议时间(字段类型:char,字段长度:6,是否可空:True)
 objPubClassCaseSenateEN.SenateReadCount = objRow[conPubClassCaseSenate.SenateReadCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPubClassCaseSenate.SenateReadCount].ToString().Trim()); //评议阅读次数(字段类型:int,字段长度:4,是否可空:True)
 objPubClassCaseSenateEN.IsVisual = clsEntityBase2.TransNullToBool_S(objRow[conPubClassCaseSenate.IsVisual].ToString().Trim()); //隐藏标志(字段类型:bit,字段长度:1,是否可空:False)
 objPubClassCaseSenateEN.IsElite = clsEntityBase2.TransNullToBool_S(objRow[conPubClassCaseSenate.IsElite].ToString().Trim()); //精华标志(字段类型:bit,字段长度:1,是否可空:False)
 objPubClassCaseSenateEN.IdResource = objRow[conPubClassCaseSenate.IdResource].ToString().Trim(); //资源流水号(字段类型:char,字段长度:8,是否可空:False)
 objPubClassCaseSenateEN.IdMediaType = objRow[conPubClassCaseSenate.IdMediaType] == DBNull.Value ? null : objRow[conPubClassCaseSenate.IdMediaType].ToString().Trim(); //媒体格式流水号(字段类型:char,字段长度:4,是否可空:False)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsPubClassCaseSenateDA: GetObjByIdPubClassCaseSenate)", objException.Message));
}
return objPubClassCaseSenateEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsPubClassCaseSenateEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsPubClassCaseSenateDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPubClassCaseSenateDA.GetSpecSQLObj();
strSQL = "Select * from PubClassCaseSenate where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsPubClassCaseSenateEN objPubClassCaseSenateEN = new clsPubClassCaseSenateEN()
{
IdPubClassCaseSenate = TransNullToInt(objRow[conPubClassCaseSenate.IdPubClassCaseSenate].ToString().Trim()), //公开课案例评议流水号
IdPubClassCase = objRow[conPubClassCaseSenate.IdPubClassCase].ToString().Trim(), //案例流水号
IdPubClassCaseSenateClass = objRow[conPubClassCaseSenate.IdPubClassCaseSenateClass].ToString().Trim(), //公开课案例评议类别流水号
PubClassCaseSenator = objRow[conPubClassCaseSenate.PubClassCaseSenator] == DBNull.Value ? null : objRow[conPubClassCaseSenate.PubClassCaseSenator].ToString().Trim(), //公开课案例评议者
PubClassCaseSenateTitle = objRow[conPubClassCaseSenate.PubClassCaseSenateTitle] == DBNull.Value ? null : objRow[conPubClassCaseSenate.PubClassCaseSenateTitle].ToString().Trim(), //公开课案例评议标题
PubClassCaseSenateContent = objRow[conPubClassCaseSenate.PubClassCaseSenateContent] == DBNull.Value ? null : objRow[conPubClassCaseSenate.PubClassCaseSenateContent].ToString().Trim(), //公开课案例评议内容
PubClassCaseSenateDate = objRow[conPubClassCaseSenate.PubClassCaseSenateDate] == DBNull.Value ? null : objRow[conPubClassCaseSenate.PubClassCaseSenateDate].ToString().Trim(), //公开课案例评议日期
PubClassCaseSenateTime = objRow[conPubClassCaseSenate.PubClassCaseSenateTime] == DBNull.Value ? null : objRow[conPubClassCaseSenate.PubClassCaseSenateTime].ToString().Trim(), //公开课案例评议时间
SenateReadCount = objRow[conPubClassCaseSenate.SenateReadCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conPubClassCaseSenate.SenateReadCount].ToString().Trim()), //评议阅读次数
IsVisual = TransNullToBool(objRow[conPubClassCaseSenate.IsVisual].ToString().Trim()), //隐藏标志
IsElite = TransNullToBool(objRow[conPubClassCaseSenate.IsElite].ToString().Trim()), //精华标志
IdResource = objRow[conPubClassCaseSenate.IdResource].ToString().Trim(), //资源流水号
IdMediaType = objRow[conPubClassCaseSenate.IdMediaType] == DBNull.Value ? null : objRow[conPubClassCaseSenate.IdMediaType].ToString().Trim() //媒体格式流水号
};
objPubClassCaseSenateEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objPubClassCaseSenateEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsPubClassCaseSenateDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsPubClassCaseSenateEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsPubClassCaseSenateEN objPubClassCaseSenateEN = new clsPubClassCaseSenateEN();
try
{
objPubClassCaseSenateEN.IdPubClassCaseSenate = TransNullToInt(objRow[conPubClassCaseSenate.IdPubClassCaseSenate].ToString().Trim()); //公开课案例评议流水号
objPubClassCaseSenateEN.IdPubClassCase = objRow[conPubClassCaseSenate.IdPubClassCase].ToString().Trim(); //案例流水号
objPubClassCaseSenateEN.IdPubClassCaseSenateClass = objRow[conPubClassCaseSenate.IdPubClassCaseSenateClass].ToString().Trim(); //公开课案例评议类别流水号
objPubClassCaseSenateEN.PubClassCaseSenator = objRow[conPubClassCaseSenate.PubClassCaseSenator] == DBNull.Value ? null : objRow[conPubClassCaseSenate.PubClassCaseSenator].ToString().Trim(); //公开课案例评议者
objPubClassCaseSenateEN.PubClassCaseSenateTitle = objRow[conPubClassCaseSenate.PubClassCaseSenateTitle] == DBNull.Value ? null : objRow[conPubClassCaseSenate.PubClassCaseSenateTitle].ToString().Trim(); //公开课案例评议标题
objPubClassCaseSenateEN.PubClassCaseSenateContent = objRow[conPubClassCaseSenate.PubClassCaseSenateContent] == DBNull.Value ? null : objRow[conPubClassCaseSenate.PubClassCaseSenateContent].ToString().Trim(); //公开课案例评议内容
objPubClassCaseSenateEN.PubClassCaseSenateDate = objRow[conPubClassCaseSenate.PubClassCaseSenateDate] == DBNull.Value ? null : objRow[conPubClassCaseSenate.PubClassCaseSenateDate].ToString().Trim(); //公开课案例评议日期
objPubClassCaseSenateEN.PubClassCaseSenateTime = objRow[conPubClassCaseSenate.PubClassCaseSenateTime] == DBNull.Value ? null : objRow[conPubClassCaseSenate.PubClassCaseSenateTime].ToString().Trim(); //公开课案例评议时间
objPubClassCaseSenateEN.SenateReadCount = objRow[conPubClassCaseSenate.SenateReadCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conPubClassCaseSenate.SenateReadCount].ToString().Trim()); //评议阅读次数
objPubClassCaseSenateEN.IsVisual = TransNullToBool(objRow[conPubClassCaseSenate.IsVisual].ToString().Trim()); //隐藏标志
objPubClassCaseSenateEN.IsElite = TransNullToBool(objRow[conPubClassCaseSenate.IsElite].ToString().Trim()); //精华标志
objPubClassCaseSenateEN.IdResource = objRow[conPubClassCaseSenate.IdResource].ToString().Trim(); //资源流水号
objPubClassCaseSenateEN.IdMediaType = objRow[conPubClassCaseSenate.IdMediaType] == DBNull.Value ? null : objRow[conPubClassCaseSenate.IdMediaType].ToString().Trim(); //媒体格式流水号
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsPubClassCaseSenateDA: GetObjByDataRowPubClassCaseSenate)", objException.Message));
}
objPubClassCaseSenateEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objPubClassCaseSenateEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsPubClassCaseSenateEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsPubClassCaseSenateEN objPubClassCaseSenateEN = new clsPubClassCaseSenateEN();
try
{
objPubClassCaseSenateEN.IdPubClassCaseSenate = TransNullToInt(objRow[conPubClassCaseSenate.IdPubClassCaseSenate].ToString().Trim()); //公开课案例评议流水号
objPubClassCaseSenateEN.IdPubClassCase = objRow[conPubClassCaseSenate.IdPubClassCase].ToString().Trim(); //案例流水号
objPubClassCaseSenateEN.IdPubClassCaseSenateClass = objRow[conPubClassCaseSenate.IdPubClassCaseSenateClass].ToString().Trim(); //公开课案例评议类别流水号
objPubClassCaseSenateEN.PubClassCaseSenator = objRow[conPubClassCaseSenate.PubClassCaseSenator] == DBNull.Value ? null : objRow[conPubClassCaseSenate.PubClassCaseSenator].ToString().Trim(); //公开课案例评议者
objPubClassCaseSenateEN.PubClassCaseSenateTitle = objRow[conPubClassCaseSenate.PubClassCaseSenateTitle] == DBNull.Value ? null : objRow[conPubClassCaseSenate.PubClassCaseSenateTitle].ToString().Trim(); //公开课案例评议标题
objPubClassCaseSenateEN.PubClassCaseSenateContent = objRow[conPubClassCaseSenate.PubClassCaseSenateContent] == DBNull.Value ? null : objRow[conPubClassCaseSenate.PubClassCaseSenateContent].ToString().Trim(); //公开课案例评议内容
objPubClassCaseSenateEN.PubClassCaseSenateDate = objRow[conPubClassCaseSenate.PubClassCaseSenateDate] == DBNull.Value ? null : objRow[conPubClassCaseSenate.PubClassCaseSenateDate].ToString().Trim(); //公开课案例评议日期
objPubClassCaseSenateEN.PubClassCaseSenateTime = objRow[conPubClassCaseSenate.PubClassCaseSenateTime] == DBNull.Value ? null : objRow[conPubClassCaseSenate.PubClassCaseSenateTime].ToString().Trim(); //公开课案例评议时间
objPubClassCaseSenateEN.SenateReadCount = objRow[conPubClassCaseSenate.SenateReadCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conPubClassCaseSenate.SenateReadCount].ToString().Trim()); //评议阅读次数
objPubClassCaseSenateEN.IsVisual = TransNullToBool(objRow[conPubClassCaseSenate.IsVisual].ToString().Trim()); //隐藏标志
objPubClassCaseSenateEN.IsElite = TransNullToBool(objRow[conPubClassCaseSenate.IsElite].ToString().Trim()); //精华标志
objPubClassCaseSenateEN.IdResource = objRow[conPubClassCaseSenate.IdResource].ToString().Trim(); //资源流水号
objPubClassCaseSenateEN.IdMediaType = objRow[conPubClassCaseSenate.IdMediaType] == DBNull.Value ? null : objRow[conPubClassCaseSenate.IdMediaType].ToString().Trim(); //媒体格式流水号
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsPubClassCaseSenateDA: GetObjByDataRow)", objException.Message));
}
objPubClassCaseSenateEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objPubClassCaseSenateEN;
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
objSQL = clsPubClassCaseSenateDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsPubClassCaseSenateEN._CurrTabName, conPubClassCaseSenate.IdPubClassCaseSenate, 8, "");
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
objSQL = clsPubClassCaseSenateDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsPubClassCaseSenateEN._CurrTabName, conPubClassCaseSenate.IdPubClassCaseSenate, 8, strPrefix);
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
 objSQL = clsPubClassCaseSenateDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select IdPubClassCaseSenate from PubClassCaseSenate where " + strCondition;
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
 objSQL = clsPubClassCaseSenateDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select IdPubClassCaseSenate from PubClassCaseSenate where " + strCondition;
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
 objSQL = clsPubClassCaseSenateDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("PubClassCaseSenate", "IdPubClassCaseSenate = " + ""+ lngIdPubClassCaseSenate+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsPubClassCaseSenateDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPubClassCaseSenateDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("PubClassCaseSenate", strCondition))
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
objSQL = clsPubClassCaseSenateDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("PubClassCaseSenate");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsPubClassCaseSenateEN objPubClassCaseSenateEN)
 {
 if (objPubClassCaseSenateEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objPubClassCaseSenateEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPubClassCaseSenateDA.GetSpecSQLObj();
strSQL = "Select * from PubClassCaseSenate where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "PubClassCaseSenate");
objRow = objDS.Tables["PubClassCaseSenate"].NewRow();
objRow[conPubClassCaseSenate.IdPubClassCase] = objPubClassCaseSenateEN.IdPubClassCase; //案例流水号
objRow[conPubClassCaseSenate.IdPubClassCaseSenateClass] = objPubClassCaseSenateEN.IdPubClassCaseSenateClass; //公开课案例评议类别流水号
 if (objPubClassCaseSenateEN.PubClassCaseSenator !=  "")
 {
objRow[conPubClassCaseSenate.PubClassCaseSenator] = objPubClassCaseSenateEN.PubClassCaseSenator; //公开课案例评议者
 }
 if (objPubClassCaseSenateEN.PubClassCaseSenateTitle !=  "")
 {
objRow[conPubClassCaseSenate.PubClassCaseSenateTitle] = objPubClassCaseSenateEN.PubClassCaseSenateTitle; //公开课案例评议标题
 }
 if (objPubClassCaseSenateEN.PubClassCaseSenateContent !=  "")
 {
objRow[conPubClassCaseSenate.PubClassCaseSenateContent] = objPubClassCaseSenateEN.PubClassCaseSenateContent; //公开课案例评议内容
 }
 if (objPubClassCaseSenateEN.PubClassCaseSenateDate !=  "")
 {
objRow[conPubClassCaseSenate.PubClassCaseSenateDate] = objPubClassCaseSenateEN.PubClassCaseSenateDate; //公开课案例评议日期
 }
 if (objPubClassCaseSenateEN.PubClassCaseSenateTime !=  "")
 {
objRow[conPubClassCaseSenate.PubClassCaseSenateTime] = objPubClassCaseSenateEN.PubClassCaseSenateTime; //公开课案例评议时间
 }
objRow[conPubClassCaseSenate.SenateReadCount] = objPubClassCaseSenateEN.SenateReadCount; //评议阅读次数
objRow[conPubClassCaseSenate.IsVisual] = objPubClassCaseSenateEN.IsVisual; //隐藏标志
objRow[conPubClassCaseSenate.IsElite] = objPubClassCaseSenateEN.IsElite; //精华标志
objRow[conPubClassCaseSenate.IdResource] = objPubClassCaseSenateEN.IdResource; //资源流水号
 if (objPubClassCaseSenateEN.IdMediaType !=  "")
 {
objRow[conPubClassCaseSenate.IdMediaType] = objPubClassCaseSenateEN.IdMediaType; //媒体格式流水号
 }
objDS.Tables[clsPubClassCaseSenateEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsPubClassCaseSenateEN._CurrTabName);
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
 /// <param name = "objPubClassCaseSenateEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsPubClassCaseSenateEN objPubClassCaseSenateEN)
{
 if (objPubClassCaseSenateEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objPubClassCaseSenateEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objPubClassCaseSenateEN.IdPubClassCase  ==  "")
 {
 objPubClassCaseSenateEN.IdPubClassCase = null;
 }
 if (objPubClassCaseSenateEN.IdPubClassCase !=  null)
 {
 arrFieldListForInsert.Add(conPubClassCaseSenate.IdPubClassCase);
 var strIdPubClassCase = objPubClassCaseSenateEN.IdPubClassCase.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdPubClassCase + "'");
 }
 
 if (objPubClassCaseSenateEN.IdPubClassCaseSenateClass  ==  "")
 {
 objPubClassCaseSenateEN.IdPubClassCaseSenateClass = null;
 }
 if (objPubClassCaseSenateEN.IdPubClassCaseSenateClass !=  null)
 {
 arrFieldListForInsert.Add(conPubClassCaseSenate.IdPubClassCaseSenateClass);
 var strIdPubClassCaseSenateClass = objPubClassCaseSenateEN.IdPubClassCaseSenateClass.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdPubClassCaseSenateClass + "'");
 }
 
 if (objPubClassCaseSenateEN.PubClassCaseSenator !=  null)
 {
 arrFieldListForInsert.Add(conPubClassCaseSenate.PubClassCaseSenator);
 var strPubClassCaseSenator = objPubClassCaseSenateEN.PubClassCaseSenator.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPubClassCaseSenator + "'");
 }
 
 if (objPubClassCaseSenateEN.PubClassCaseSenateTitle !=  null)
 {
 arrFieldListForInsert.Add(conPubClassCaseSenate.PubClassCaseSenateTitle);
 var strPubClassCaseSenateTitle = objPubClassCaseSenateEN.PubClassCaseSenateTitle.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPubClassCaseSenateTitle + "'");
 }
 
 if (objPubClassCaseSenateEN.PubClassCaseSenateContent !=  null)
 {
 arrFieldListForInsert.Add(conPubClassCaseSenate.PubClassCaseSenateContent);
 var strPubClassCaseSenateContent = objPubClassCaseSenateEN.PubClassCaseSenateContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPubClassCaseSenateContent + "'");
 }
 
 if (objPubClassCaseSenateEN.PubClassCaseSenateDate !=  null)
 {
 arrFieldListForInsert.Add(conPubClassCaseSenate.PubClassCaseSenateDate);
 var strPubClassCaseSenateDate = objPubClassCaseSenateEN.PubClassCaseSenateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPubClassCaseSenateDate + "'");
 }
 
 if (objPubClassCaseSenateEN.PubClassCaseSenateTime !=  null)
 {
 arrFieldListForInsert.Add(conPubClassCaseSenate.PubClassCaseSenateTime);
 var strPubClassCaseSenateTime = objPubClassCaseSenateEN.PubClassCaseSenateTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPubClassCaseSenateTime + "'");
 }
 
 if (objPubClassCaseSenateEN.SenateReadCount !=  null)
 {
 arrFieldListForInsert.Add(conPubClassCaseSenate.SenateReadCount);
 arrValueListForInsert.Add(objPubClassCaseSenateEN.SenateReadCount.ToString());
 }
 
 arrFieldListForInsert.Add(conPubClassCaseSenate.IsVisual);
 arrValueListForInsert.Add("'" + (objPubClassCaseSenateEN.IsVisual  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conPubClassCaseSenate.IsElite);
 arrValueListForInsert.Add("'" + (objPubClassCaseSenateEN.IsElite  ==  false ? "0" : "1") + "'");
 
 if (objPubClassCaseSenateEN.IdResource  ==  "")
 {
 objPubClassCaseSenateEN.IdResource = null;
 }
 if (objPubClassCaseSenateEN.IdResource !=  null)
 {
 arrFieldListForInsert.Add(conPubClassCaseSenate.IdResource);
 var strIdResource = objPubClassCaseSenateEN.IdResource.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdResource + "'");
 }
 
 if (objPubClassCaseSenateEN.IdMediaType  ==  "")
 {
 objPubClassCaseSenateEN.IdMediaType = null;
 }
 if (objPubClassCaseSenateEN.IdMediaType !=  null)
 {
 arrFieldListForInsert.Add(conPubClassCaseSenate.IdMediaType);
 var strIdMediaType = objPubClassCaseSenateEN.IdMediaType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdMediaType + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into PubClassCaseSenate");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPubClassCaseSenateDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objPubClassCaseSenateEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsPubClassCaseSenateEN objPubClassCaseSenateEN)
{
 if (objPubClassCaseSenateEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objPubClassCaseSenateEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objPubClassCaseSenateEN.IdPubClassCase  ==  "")
 {
 objPubClassCaseSenateEN.IdPubClassCase = null;
 }
 if (objPubClassCaseSenateEN.IdPubClassCase !=  null)
 {
 arrFieldListForInsert.Add(conPubClassCaseSenate.IdPubClassCase);
 var strIdPubClassCase = objPubClassCaseSenateEN.IdPubClassCase.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdPubClassCase + "'");
 }
 
 if (objPubClassCaseSenateEN.IdPubClassCaseSenateClass  ==  "")
 {
 objPubClassCaseSenateEN.IdPubClassCaseSenateClass = null;
 }
 if (objPubClassCaseSenateEN.IdPubClassCaseSenateClass !=  null)
 {
 arrFieldListForInsert.Add(conPubClassCaseSenate.IdPubClassCaseSenateClass);
 var strIdPubClassCaseSenateClass = objPubClassCaseSenateEN.IdPubClassCaseSenateClass.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdPubClassCaseSenateClass + "'");
 }
 
 if (objPubClassCaseSenateEN.PubClassCaseSenator !=  null)
 {
 arrFieldListForInsert.Add(conPubClassCaseSenate.PubClassCaseSenator);
 var strPubClassCaseSenator = objPubClassCaseSenateEN.PubClassCaseSenator.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPubClassCaseSenator + "'");
 }
 
 if (objPubClassCaseSenateEN.PubClassCaseSenateTitle !=  null)
 {
 arrFieldListForInsert.Add(conPubClassCaseSenate.PubClassCaseSenateTitle);
 var strPubClassCaseSenateTitle = objPubClassCaseSenateEN.PubClassCaseSenateTitle.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPubClassCaseSenateTitle + "'");
 }
 
 if (objPubClassCaseSenateEN.PubClassCaseSenateContent !=  null)
 {
 arrFieldListForInsert.Add(conPubClassCaseSenate.PubClassCaseSenateContent);
 var strPubClassCaseSenateContent = objPubClassCaseSenateEN.PubClassCaseSenateContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPubClassCaseSenateContent + "'");
 }
 
 if (objPubClassCaseSenateEN.PubClassCaseSenateDate !=  null)
 {
 arrFieldListForInsert.Add(conPubClassCaseSenate.PubClassCaseSenateDate);
 var strPubClassCaseSenateDate = objPubClassCaseSenateEN.PubClassCaseSenateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPubClassCaseSenateDate + "'");
 }
 
 if (objPubClassCaseSenateEN.PubClassCaseSenateTime !=  null)
 {
 arrFieldListForInsert.Add(conPubClassCaseSenate.PubClassCaseSenateTime);
 var strPubClassCaseSenateTime = objPubClassCaseSenateEN.PubClassCaseSenateTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPubClassCaseSenateTime + "'");
 }
 
 if (objPubClassCaseSenateEN.SenateReadCount !=  null)
 {
 arrFieldListForInsert.Add(conPubClassCaseSenate.SenateReadCount);
 arrValueListForInsert.Add(objPubClassCaseSenateEN.SenateReadCount.ToString());
 }
 
 arrFieldListForInsert.Add(conPubClassCaseSenate.IsVisual);
 arrValueListForInsert.Add("'" + (objPubClassCaseSenateEN.IsVisual  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conPubClassCaseSenate.IsElite);
 arrValueListForInsert.Add("'" + (objPubClassCaseSenateEN.IsElite  ==  false ? "0" : "1") + "'");
 
 if (objPubClassCaseSenateEN.IdResource  ==  "")
 {
 objPubClassCaseSenateEN.IdResource = null;
 }
 if (objPubClassCaseSenateEN.IdResource !=  null)
 {
 arrFieldListForInsert.Add(conPubClassCaseSenate.IdResource);
 var strIdResource = objPubClassCaseSenateEN.IdResource.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdResource + "'");
 }
 
 if (objPubClassCaseSenateEN.IdMediaType  ==  "")
 {
 objPubClassCaseSenateEN.IdMediaType = null;
 }
 if (objPubClassCaseSenateEN.IdMediaType !=  null)
 {
 arrFieldListForInsert.Add(conPubClassCaseSenate.IdMediaType);
 var strIdMediaType = objPubClassCaseSenateEN.IdMediaType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdMediaType + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into PubClassCaseSenate");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPubClassCaseSenateDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString()).Rows[0][0].ToString();
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objPubClassCaseSenateEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsPubClassCaseSenateEN objPubClassCaseSenateEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objPubClassCaseSenateEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objPubClassCaseSenateEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objPubClassCaseSenateEN.IdPubClassCase  ==  "")
 {
 objPubClassCaseSenateEN.IdPubClassCase = null;
 }
 if (objPubClassCaseSenateEN.IdPubClassCase !=  null)
 {
 arrFieldListForInsert.Add(conPubClassCaseSenate.IdPubClassCase);
 var strIdPubClassCase = objPubClassCaseSenateEN.IdPubClassCase.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdPubClassCase + "'");
 }
 
 if (objPubClassCaseSenateEN.IdPubClassCaseSenateClass  ==  "")
 {
 objPubClassCaseSenateEN.IdPubClassCaseSenateClass = null;
 }
 if (objPubClassCaseSenateEN.IdPubClassCaseSenateClass !=  null)
 {
 arrFieldListForInsert.Add(conPubClassCaseSenate.IdPubClassCaseSenateClass);
 var strIdPubClassCaseSenateClass = objPubClassCaseSenateEN.IdPubClassCaseSenateClass.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdPubClassCaseSenateClass + "'");
 }
 
 if (objPubClassCaseSenateEN.PubClassCaseSenator !=  null)
 {
 arrFieldListForInsert.Add(conPubClassCaseSenate.PubClassCaseSenator);
 var strPubClassCaseSenator = objPubClassCaseSenateEN.PubClassCaseSenator.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPubClassCaseSenator + "'");
 }
 
 if (objPubClassCaseSenateEN.PubClassCaseSenateTitle !=  null)
 {
 arrFieldListForInsert.Add(conPubClassCaseSenate.PubClassCaseSenateTitle);
 var strPubClassCaseSenateTitle = objPubClassCaseSenateEN.PubClassCaseSenateTitle.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPubClassCaseSenateTitle + "'");
 }
 
 if (objPubClassCaseSenateEN.PubClassCaseSenateContent !=  null)
 {
 arrFieldListForInsert.Add(conPubClassCaseSenate.PubClassCaseSenateContent);
 var strPubClassCaseSenateContent = objPubClassCaseSenateEN.PubClassCaseSenateContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPubClassCaseSenateContent + "'");
 }
 
 if (objPubClassCaseSenateEN.PubClassCaseSenateDate !=  null)
 {
 arrFieldListForInsert.Add(conPubClassCaseSenate.PubClassCaseSenateDate);
 var strPubClassCaseSenateDate = objPubClassCaseSenateEN.PubClassCaseSenateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPubClassCaseSenateDate + "'");
 }
 
 if (objPubClassCaseSenateEN.PubClassCaseSenateTime !=  null)
 {
 arrFieldListForInsert.Add(conPubClassCaseSenate.PubClassCaseSenateTime);
 var strPubClassCaseSenateTime = objPubClassCaseSenateEN.PubClassCaseSenateTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPubClassCaseSenateTime + "'");
 }
 
 if (objPubClassCaseSenateEN.SenateReadCount !=  null)
 {
 arrFieldListForInsert.Add(conPubClassCaseSenate.SenateReadCount);
 arrValueListForInsert.Add(objPubClassCaseSenateEN.SenateReadCount.ToString());
 }
 
 arrFieldListForInsert.Add(conPubClassCaseSenate.IsVisual);
 arrValueListForInsert.Add("'" + (objPubClassCaseSenateEN.IsVisual  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conPubClassCaseSenate.IsElite);
 arrValueListForInsert.Add("'" + (objPubClassCaseSenateEN.IsElite  ==  false ? "0" : "1") + "'");
 
 if (objPubClassCaseSenateEN.IdResource  ==  "")
 {
 objPubClassCaseSenateEN.IdResource = null;
 }
 if (objPubClassCaseSenateEN.IdResource !=  null)
 {
 arrFieldListForInsert.Add(conPubClassCaseSenate.IdResource);
 var strIdResource = objPubClassCaseSenateEN.IdResource.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdResource + "'");
 }
 
 if (objPubClassCaseSenateEN.IdMediaType  ==  "")
 {
 objPubClassCaseSenateEN.IdMediaType = null;
 }
 if (objPubClassCaseSenateEN.IdMediaType !=  null)
 {
 arrFieldListForInsert.Add(conPubClassCaseSenate.IdMediaType);
 var strIdMediaType = objPubClassCaseSenateEN.IdMediaType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdMediaType + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into PubClassCaseSenate");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPubClassCaseSenateDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString(), objSqlConnection, objSqlTransaction).Rows[0][0].ToString();
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objPubClassCaseSenateEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsPubClassCaseSenateEN objPubClassCaseSenateEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objPubClassCaseSenateEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objPubClassCaseSenateEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objPubClassCaseSenateEN.IdPubClassCase  ==  "")
 {
 objPubClassCaseSenateEN.IdPubClassCase = null;
 }
 if (objPubClassCaseSenateEN.IdPubClassCase !=  null)
 {
 arrFieldListForInsert.Add(conPubClassCaseSenate.IdPubClassCase);
 var strIdPubClassCase = objPubClassCaseSenateEN.IdPubClassCase.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdPubClassCase + "'");
 }
 
 if (objPubClassCaseSenateEN.IdPubClassCaseSenateClass  ==  "")
 {
 objPubClassCaseSenateEN.IdPubClassCaseSenateClass = null;
 }
 if (objPubClassCaseSenateEN.IdPubClassCaseSenateClass !=  null)
 {
 arrFieldListForInsert.Add(conPubClassCaseSenate.IdPubClassCaseSenateClass);
 var strIdPubClassCaseSenateClass = objPubClassCaseSenateEN.IdPubClassCaseSenateClass.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdPubClassCaseSenateClass + "'");
 }
 
 if (objPubClassCaseSenateEN.PubClassCaseSenator !=  null)
 {
 arrFieldListForInsert.Add(conPubClassCaseSenate.PubClassCaseSenator);
 var strPubClassCaseSenator = objPubClassCaseSenateEN.PubClassCaseSenator.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPubClassCaseSenator + "'");
 }
 
 if (objPubClassCaseSenateEN.PubClassCaseSenateTitle !=  null)
 {
 arrFieldListForInsert.Add(conPubClassCaseSenate.PubClassCaseSenateTitle);
 var strPubClassCaseSenateTitle = objPubClassCaseSenateEN.PubClassCaseSenateTitle.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPubClassCaseSenateTitle + "'");
 }
 
 if (objPubClassCaseSenateEN.PubClassCaseSenateContent !=  null)
 {
 arrFieldListForInsert.Add(conPubClassCaseSenate.PubClassCaseSenateContent);
 var strPubClassCaseSenateContent = objPubClassCaseSenateEN.PubClassCaseSenateContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPubClassCaseSenateContent + "'");
 }
 
 if (objPubClassCaseSenateEN.PubClassCaseSenateDate !=  null)
 {
 arrFieldListForInsert.Add(conPubClassCaseSenate.PubClassCaseSenateDate);
 var strPubClassCaseSenateDate = objPubClassCaseSenateEN.PubClassCaseSenateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPubClassCaseSenateDate + "'");
 }
 
 if (objPubClassCaseSenateEN.PubClassCaseSenateTime !=  null)
 {
 arrFieldListForInsert.Add(conPubClassCaseSenate.PubClassCaseSenateTime);
 var strPubClassCaseSenateTime = objPubClassCaseSenateEN.PubClassCaseSenateTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPubClassCaseSenateTime + "'");
 }
 
 if (objPubClassCaseSenateEN.SenateReadCount !=  null)
 {
 arrFieldListForInsert.Add(conPubClassCaseSenate.SenateReadCount);
 arrValueListForInsert.Add(objPubClassCaseSenateEN.SenateReadCount.ToString());
 }
 
 arrFieldListForInsert.Add(conPubClassCaseSenate.IsVisual);
 arrValueListForInsert.Add("'" + (objPubClassCaseSenateEN.IsVisual  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conPubClassCaseSenate.IsElite);
 arrValueListForInsert.Add("'" + (objPubClassCaseSenateEN.IsElite  ==  false ? "0" : "1") + "'");
 
 if (objPubClassCaseSenateEN.IdResource  ==  "")
 {
 objPubClassCaseSenateEN.IdResource = null;
 }
 if (objPubClassCaseSenateEN.IdResource !=  null)
 {
 arrFieldListForInsert.Add(conPubClassCaseSenate.IdResource);
 var strIdResource = objPubClassCaseSenateEN.IdResource.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdResource + "'");
 }
 
 if (objPubClassCaseSenateEN.IdMediaType  ==  "")
 {
 objPubClassCaseSenateEN.IdMediaType = null;
 }
 if (objPubClassCaseSenateEN.IdMediaType !=  null)
 {
 arrFieldListForInsert.Add(conPubClassCaseSenate.IdMediaType);
 var strIdMediaType = objPubClassCaseSenateEN.IdMediaType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdMediaType + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into PubClassCaseSenate");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPubClassCaseSenateDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewPubClassCaseSenates(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPubClassCaseSenateDA.GetSpecSQLObj();
strSQL = "Select * from PubClassCaseSenate where IdPubClassCaseSenate = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "PubClassCaseSenate");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
long lngIdPubClassCaseSenate = TransNullToInt(oRow[conPubClassCaseSenate.IdPubClassCaseSenate].ToString().Trim());
if (IsExist(lngIdPubClassCaseSenate))
{
 string strResult = "关键字变量值为:" + string.Format("IdPubClassCaseSenate = {0}", lngIdPubClassCaseSenate) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsPubClassCaseSenateEN._CurrTabName ].NewRow();
objRow[conPubClassCaseSenate.IdPubClassCase] = oRow[conPubClassCaseSenate.IdPubClassCase].ToString().Trim(); //案例流水号
objRow[conPubClassCaseSenate.IdPubClassCaseSenateClass] = oRow[conPubClassCaseSenate.IdPubClassCaseSenateClass].ToString().Trim(); //公开课案例评议类别流水号
objRow[conPubClassCaseSenate.PubClassCaseSenator] = oRow[conPubClassCaseSenate.PubClassCaseSenator].ToString().Trim(); //公开课案例评议者
objRow[conPubClassCaseSenate.PubClassCaseSenateTitle] = oRow[conPubClassCaseSenate.PubClassCaseSenateTitle].ToString().Trim(); //公开课案例评议标题
objRow[conPubClassCaseSenate.PubClassCaseSenateContent] = oRow[conPubClassCaseSenate.PubClassCaseSenateContent].ToString().Trim(); //公开课案例评议内容
objRow[conPubClassCaseSenate.PubClassCaseSenateDate] = oRow[conPubClassCaseSenate.PubClassCaseSenateDate].ToString().Trim(); //公开课案例评议日期
objRow[conPubClassCaseSenate.PubClassCaseSenateTime] = oRow[conPubClassCaseSenate.PubClassCaseSenateTime].ToString().Trim(); //公开课案例评议时间
objRow[conPubClassCaseSenate.SenateReadCount] = oRow[conPubClassCaseSenate.SenateReadCount].ToString().Trim(); //评议阅读次数
objRow[conPubClassCaseSenate.IsVisual] = oRow[conPubClassCaseSenate.IsVisual].ToString().Trim(); //隐藏标志
objRow[conPubClassCaseSenate.IsElite] = oRow[conPubClassCaseSenate.IsElite].ToString().Trim(); //精华标志
objRow[conPubClassCaseSenate.IdResource] = oRow[conPubClassCaseSenate.IdResource].ToString().Trim(); //资源流水号
objRow[conPubClassCaseSenate.IdMediaType] = oRow[conPubClassCaseSenate.IdMediaType].ToString().Trim(); //媒体格式流水号
 objDS.Tables[clsPubClassCaseSenateEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsPubClassCaseSenateEN._CurrTabName);
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
 /// <param name = "objPubClassCaseSenateEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsPubClassCaseSenateEN objPubClassCaseSenateEN)
{
 if (objPubClassCaseSenateEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objPubClassCaseSenateEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPubClassCaseSenateDA.GetSpecSQLObj();
strSQL = "Select * from PubClassCaseSenate where IdPubClassCaseSenate = " + ""+ objPubClassCaseSenateEN.IdPubClassCaseSenate+"";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsPubClassCaseSenateEN._CurrTabName);
if (objDS.Tables[clsPubClassCaseSenateEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:IdPubClassCaseSenate = " + ""+ objPubClassCaseSenateEN.IdPubClassCaseSenate+"");
return false;
}
objRow = objDS.Tables[clsPubClassCaseSenateEN._CurrTabName].Rows[0];
 if (objPubClassCaseSenateEN.IsUpdated(conPubClassCaseSenate.IdPubClassCase))
 {
objRow[conPubClassCaseSenate.IdPubClassCase] = objPubClassCaseSenateEN.IdPubClassCase; //案例流水号
 }
 if (objPubClassCaseSenateEN.IsUpdated(conPubClassCaseSenate.IdPubClassCaseSenateClass))
 {
objRow[conPubClassCaseSenate.IdPubClassCaseSenateClass] = objPubClassCaseSenateEN.IdPubClassCaseSenateClass; //公开课案例评议类别流水号
 }
 if (objPubClassCaseSenateEN.IsUpdated(conPubClassCaseSenate.PubClassCaseSenator))
 {
objRow[conPubClassCaseSenate.PubClassCaseSenator] = objPubClassCaseSenateEN.PubClassCaseSenator; //公开课案例评议者
 }
 if (objPubClassCaseSenateEN.IsUpdated(conPubClassCaseSenate.PubClassCaseSenateTitle))
 {
objRow[conPubClassCaseSenate.PubClassCaseSenateTitle] = objPubClassCaseSenateEN.PubClassCaseSenateTitle; //公开课案例评议标题
 }
 if (objPubClassCaseSenateEN.IsUpdated(conPubClassCaseSenate.PubClassCaseSenateContent))
 {
objRow[conPubClassCaseSenate.PubClassCaseSenateContent] = objPubClassCaseSenateEN.PubClassCaseSenateContent; //公开课案例评议内容
 }
 if (objPubClassCaseSenateEN.IsUpdated(conPubClassCaseSenate.PubClassCaseSenateDate))
 {
objRow[conPubClassCaseSenate.PubClassCaseSenateDate] = objPubClassCaseSenateEN.PubClassCaseSenateDate; //公开课案例评议日期
 }
 if (objPubClassCaseSenateEN.IsUpdated(conPubClassCaseSenate.PubClassCaseSenateTime))
 {
objRow[conPubClassCaseSenate.PubClassCaseSenateTime] = objPubClassCaseSenateEN.PubClassCaseSenateTime; //公开课案例评议时间
 }
 if (objPubClassCaseSenateEN.IsUpdated(conPubClassCaseSenate.SenateReadCount))
 {
objRow[conPubClassCaseSenate.SenateReadCount] = objPubClassCaseSenateEN.SenateReadCount; //评议阅读次数
 }
 if (objPubClassCaseSenateEN.IsUpdated(conPubClassCaseSenate.IsVisual))
 {
objRow[conPubClassCaseSenate.IsVisual] = objPubClassCaseSenateEN.IsVisual; //隐藏标志
 }
 if (objPubClassCaseSenateEN.IsUpdated(conPubClassCaseSenate.IsElite))
 {
objRow[conPubClassCaseSenate.IsElite] = objPubClassCaseSenateEN.IsElite; //精华标志
 }
 if (objPubClassCaseSenateEN.IsUpdated(conPubClassCaseSenate.IdResource))
 {
objRow[conPubClassCaseSenate.IdResource] = objPubClassCaseSenateEN.IdResource; //资源流水号
 }
 if (objPubClassCaseSenateEN.IsUpdated(conPubClassCaseSenate.IdMediaType))
 {
objRow[conPubClassCaseSenate.IdMediaType] = objPubClassCaseSenateEN.IdMediaType; //媒体格式流水号
 }
try
{
objDA.Update(objDS, clsPubClassCaseSenateEN._CurrTabName);
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
 /// <param name = "objPubClassCaseSenateEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsPubClassCaseSenateEN objPubClassCaseSenateEN)
{
 if (objPubClassCaseSenateEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objPubClassCaseSenateEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPubClassCaseSenateDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update PubClassCaseSenate Set ");
 
 if (objPubClassCaseSenateEN.IsUpdated(conPubClassCaseSenate.IdPubClassCase))
 {
 if (objPubClassCaseSenateEN.IdPubClassCase  ==  "")
 {
 objPubClassCaseSenateEN.IdPubClassCase = null;
 }
 if (objPubClassCaseSenateEN.IdPubClassCase !=  null)
 {
 var strIdPubClassCase = objPubClassCaseSenateEN.IdPubClassCase.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdPubClassCase, conPubClassCaseSenate.IdPubClassCase); //案例流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPubClassCaseSenate.IdPubClassCase); //案例流水号
 }
 }
 
 if (objPubClassCaseSenateEN.IsUpdated(conPubClassCaseSenate.IdPubClassCaseSenateClass))
 {
 if (objPubClassCaseSenateEN.IdPubClassCaseSenateClass  ==  "")
 {
 objPubClassCaseSenateEN.IdPubClassCaseSenateClass = null;
 }
 if (objPubClassCaseSenateEN.IdPubClassCaseSenateClass !=  null)
 {
 var strIdPubClassCaseSenateClass = objPubClassCaseSenateEN.IdPubClassCaseSenateClass.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdPubClassCaseSenateClass, conPubClassCaseSenate.IdPubClassCaseSenateClass); //公开课案例评议类别流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPubClassCaseSenate.IdPubClassCaseSenateClass); //公开课案例评议类别流水号
 }
 }
 
 if (objPubClassCaseSenateEN.IsUpdated(conPubClassCaseSenate.PubClassCaseSenator))
 {
 if (objPubClassCaseSenateEN.PubClassCaseSenator !=  null)
 {
 var strPubClassCaseSenator = objPubClassCaseSenateEN.PubClassCaseSenator.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPubClassCaseSenator, conPubClassCaseSenate.PubClassCaseSenator); //公开课案例评议者
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPubClassCaseSenate.PubClassCaseSenator); //公开课案例评议者
 }
 }
 
 if (objPubClassCaseSenateEN.IsUpdated(conPubClassCaseSenate.PubClassCaseSenateTitle))
 {
 if (objPubClassCaseSenateEN.PubClassCaseSenateTitle !=  null)
 {
 var strPubClassCaseSenateTitle = objPubClassCaseSenateEN.PubClassCaseSenateTitle.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPubClassCaseSenateTitle, conPubClassCaseSenate.PubClassCaseSenateTitle); //公开课案例评议标题
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPubClassCaseSenate.PubClassCaseSenateTitle); //公开课案例评议标题
 }
 }
 
 if (objPubClassCaseSenateEN.IsUpdated(conPubClassCaseSenate.PubClassCaseSenateContent))
 {
 if (objPubClassCaseSenateEN.PubClassCaseSenateContent !=  null)
 {
 var strPubClassCaseSenateContent = objPubClassCaseSenateEN.PubClassCaseSenateContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPubClassCaseSenateContent, conPubClassCaseSenate.PubClassCaseSenateContent); //公开课案例评议内容
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPubClassCaseSenate.PubClassCaseSenateContent); //公开课案例评议内容
 }
 }
 
 if (objPubClassCaseSenateEN.IsUpdated(conPubClassCaseSenate.PubClassCaseSenateDate))
 {
 if (objPubClassCaseSenateEN.PubClassCaseSenateDate !=  null)
 {
 var strPubClassCaseSenateDate = objPubClassCaseSenateEN.PubClassCaseSenateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPubClassCaseSenateDate, conPubClassCaseSenate.PubClassCaseSenateDate); //公开课案例评议日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPubClassCaseSenate.PubClassCaseSenateDate); //公开课案例评议日期
 }
 }
 
 if (objPubClassCaseSenateEN.IsUpdated(conPubClassCaseSenate.PubClassCaseSenateTime))
 {
 if (objPubClassCaseSenateEN.PubClassCaseSenateTime !=  null)
 {
 var strPubClassCaseSenateTime = objPubClassCaseSenateEN.PubClassCaseSenateTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPubClassCaseSenateTime, conPubClassCaseSenate.PubClassCaseSenateTime); //公开课案例评议时间
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPubClassCaseSenate.PubClassCaseSenateTime); //公开课案例评议时间
 }
 }
 
 if (objPubClassCaseSenateEN.IsUpdated(conPubClassCaseSenate.SenateReadCount))
 {
 if (objPubClassCaseSenateEN.SenateReadCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objPubClassCaseSenateEN.SenateReadCount, conPubClassCaseSenate.SenateReadCount); //评议阅读次数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPubClassCaseSenate.SenateReadCount); //评议阅读次数
 }
 }
 
 if (objPubClassCaseSenateEN.IsUpdated(conPubClassCaseSenate.IsVisual))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objPubClassCaseSenateEN.IsVisual == true?"1":"0", conPubClassCaseSenate.IsVisual); //隐藏标志
 }
 
 if (objPubClassCaseSenateEN.IsUpdated(conPubClassCaseSenate.IsElite))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objPubClassCaseSenateEN.IsElite == true?"1":"0", conPubClassCaseSenate.IsElite); //精华标志
 }
 
 if (objPubClassCaseSenateEN.IsUpdated(conPubClassCaseSenate.IdResource))
 {
 if (objPubClassCaseSenateEN.IdResource  ==  "")
 {
 objPubClassCaseSenateEN.IdResource = null;
 }
 if (objPubClassCaseSenateEN.IdResource !=  null)
 {
 var strIdResource = objPubClassCaseSenateEN.IdResource.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdResource, conPubClassCaseSenate.IdResource); //资源流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPubClassCaseSenate.IdResource); //资源流水号
 }
 }
 
 if (objPubClassCaseSenateEN.IsUpdated(conPubClassCaseSenate.IdMediaType))
 {
 if (objPubClassCaseSenateEN.IdMediaType  ==  "")
 {
 objPubClassCaseSenateEN.IdMediaType = null;
 }
 if (objPubClassCaseSenateEN.IdMediaType !=  null)
 {
 var strIdMediaType = objPubClassCaseSenateEN.IdMediaType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdMediaType, conPubClassCaseSenate.IdMediaType); //媒体格式流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPubClassCaseSenate.IdMediaType); //媒体格式流水号
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where IdPubClassCaseSenate = {0}", objPubClassCaseSenateEN.IdPubClassCaseSenate); 
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
 /// <param name = "objPubClassCaseSenateEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsPubClassCaseSenateEN objPubClassCaseSenateEN, string strCondition)
{
 if (objPubClassCaseSenateEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objPubClassCaseSenateEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPubClassCaseSenateDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update PubClassCaseSenate Set ");
 
 if (objPubClassCaseSenateEN.IsUpdated(conPubClassCaseSenate.IdPubClassCase))
 {
 if (objPubClassCaseSenateEN.IdPubClassCase  ==  "")
 {
 objPubClassCaseSenateEN.IdPubClassCase = null;
 }
 if (objPubClassCaseSenateEN.IdPubClassCase !=  null)
 {
 var strIdPubClassCase = objPubClassCaseSenateEN.IdPubClassCase.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdPubClassCase = '{0}',", strIdPubClassCase); //案例流水号
 }
 else
 {
 sbSQL.Append(" IdPubClassCase = null,"); //案例流水号
 }
 }
 
 if (objPubClassCaseSenateEN.IsUpdated(conPubClassCaseSenate.IdPubClassCaseSenateClass))
 {
 if (objPubClassCaseSenateEN.IdPubClassCaseSenateClass  ==  "")
 {
 objPubClassCaseSenateEN.IdPubClassCaseSenateClass = null;
 }
 if (objPubClassCaseSenateEN.IdPubClassCaseSenateClass !=  null)
 {
 var strIdPubClassCaseSenateClass = objPubClassCaseSenateEN.IdPubClassCaseSenateClass.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdPubClassCaseSenateClass = '{0}',", strIdPubClassCaseSenateClass); //公开课案例评议类别流水号
 }
 else
 {
 sbSQL.Append(" IdPubClassCaseSenateClass = null,"); //公开课案例评议类别流水号
 }
 }
 
 if (objPubClassCaseSenateEN.IsUpdated(conPubClassCaseSenate.PubClassCaseSenator))
 {
 if (objPubClassCaseSenateEN.PubClassCaseSenator !=  null)
 {
 var strPubClassCaseSenator = objPubClassCaseSenateEN.PubClassCaseSenator.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PubClassCaseSenator = '{0}',", strPubClassCaseSenator); //公开课案例评议者
 }
 else
 {
 sbSQL.Append(" PubClassCaseSenator = null,"); //公开课案例评议者
 }
 }
 
 if (objPubClassCaseSenateEN.IsUpdated(conPubClassCaseSenate.PubClassCaseSenateTitle))
 {
 if (objPubClassCaseSenateEN.PubClassCaseSenateTitle !=  null)
 {
 var strPubClassCaseSenateTitle = objPubClassCaseSenateEN.PubClassCaseSenateTitle.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PubClassCaseSenateTitle = '{0}',", strPubClassCaseSenateTitle); //公开课案例评议标题
 }
 else
 {
 sbSQL.Append(" PubClassCaseSenateTitle = null,"); //公开课案例评议标题
 }
 }
 
 if (objPubClassCaseSenateEN.IsUpdated(conPubClassCaseSenate.PubClassCaseSenateContent))
 {
 if (objPubClassCaseSenateEN.PubClassCaseSenateContent !=  null)
 {
 var strPubClassCaseSenateContent = objPubClassCaseSenateEN.PubClassCaseSenateContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PubClassCaseSenateContent = '{0}',", strPubClassCaseSenateContent); //公开课案例评议内容
 }
 else
 {
 sbSQL.Append(" PubClassCaseSenateContent = null,"); //公开课案例评议内容
 }
 }
 
 if (objPubClassCaseSenateEN.IsUpdated(conPubClassCaseSenate.PubClassCaseSenateDate))
 {
 if (objPubClassCaseSenateEN.PubClassCaseSenateDate !=  null)
 {
 var strPubClassCaseSenateDate = objPubClassCaseSenateEN.PubClassCaseSenateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PubClassCaseSenateDate = '{0}',", strPubClassCaseSenateDate); //公开课案例评议日期
 }
 else
 {
 sbSQL.Append(" PubClassCaseSenateDate = null,"); //公开课案例评议日期
 }
 }
 
 if (objPubClassCaseSenateEN.IsUpdated(conPubClassCaseSenate.PubClassCaseSenateTime))
 {
 if (objPubClassCaseSenateEN.PubClassCaseSenateTime !=  null)
 {
 var strPubClassCaseSenateTime = objPubClassCaseSenateEN.PubClassCaseSenateTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PubClassCaseSenateTime = '{0}',", strPubClassCaseSenateTime); //公开课案例评议时间
 }
 else
 {
 sbSQL.Append(" PubClassCaseSenateTime = null,"); //公开课案例评议时间
 }
 }
 
 if (objPubClassCaseSenateEN.IsUpdated(conPubClassCaseSenate.SenateReadCount))
 {
 sbSQL.AppendFormat(" SenateReadCount = {0},", objPubClassCaseSenateEN.SenateReadCount); //评议阅读次数
 }
 
 if (objPubClassCaseSenateEN.IsUpdated(conPubClassCaseSenate.IsVisual))
 {
 sbSQL.AppendFormat(" IsVisual = '{0}',", objPubClassCaseSenateEN.IsVisual == true?"1":"0"); //隐藏标志
 }
 
 if (objPubClassCaseSenateEN.IsUpdated(conPubClassCaseSenate.IsElite))
 {
 sbSQL.AppendFormat(" IsElite = '{0}',", objPubClassCaseSenateEN.IsElite == true?"1":"0"); //精华标志
 }
 
 if (objPubClassCaseSenateEN.IsUpdated(conPubClassCaseSenate.IdResource))
 {
 if (objPubClassCaseSenateEN.IdResource  ==  "")
 {
 objPubClassCaseSenateEN.IdResource = null;
 }
 if (objPubClassCaseSenateEN.IdResource !=  null)
 {
 var strIdResource = objPubClassCaseSenateEN.IdResource.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdResource = '{0}',", strIdResource); //资源流水号
 }
 else
 {
 sbSQL.Append(" IdResource = null,"); //资源流水号
 }
 }
 
 if (objPubClassCaseSenateEN.IsUpdated(conPubClassCaseSenate.IdMediaType))
 {
 if (objPubClassCaseSenateEN.IdMediaType  ==  "")
 {
 objPubClassCaseSenateEN.IdMediaType = null;
 }
 if (objPubClassCaseSenateEN.IdMediaType !=  null)
 {
 var strIdMediaType = objPubClassCaseSenateEN.IdMediaType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdMediaType = '{0}',", strIdMediaType); //媒体格式流水号
 }
 else
 {
 sbSQL.Append(" IdMediaType = null,"); //媒体格式流水号
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
 /// <param name = "objPubClassCaseSenateEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsPubClassCaseSenateEN objPubClassCaseSenateEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objPubClassCaseSenateEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objPubClassCaseSenateEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPubClassCaseSenateDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update PubClassCaseSenate Set ");
 
 if (objPubClassCaseSenateEN.IsUpdated(conPubClassCaseSenate.IdPubClassCase))
 {
 if (objPubClassCaseSenateEN.IdPubClassCase  ==  "")
 {
 objPubClassCaseSenateEN.IdPubClassCase = null;
 }
 if (objPubClassCaseSenateEN.IdPubClassCase !=  null)
 {
 var strIdPubClassCase = objPubClassCaseSenateEN.IdPubClassCase.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdPubClassCase = '{0}',", strIdPubClassCase); //案例流水号
 }
 else
 {
 sbSQL.Append(" IdPubClassCase = null,"); //案例流水号
 }
 }
 
 if (objPubClassCaseSenateEN.IsUpdated(conPubClassCaseSenate.IdPubClassCaseSenateClass))
 {
 if (objPubClassCaseSenateEN.IdPubClassCaseSenateClass  ==  "")
 {
 objPubClassCaseSenateEN.IdPubClassCaseSenateClass = null;
 }
 if (objPubClassCaseSenateEN.IdPubClassCaseSenateClass !=  null)
 {
 var strIdPubClassCaseSenateClass = objPubClassCaseSenateEN.IdPubClassCaseSenateClass.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdPubClassCaseSenateClass = '{0}',", strIdPubClassCaseSenateClass); //公开课案例评议类别流水号
 }
 else
 {
 sbSQL.Append(" IdPubClassCaseSenateClass = null,"); //公开课案例评议类别流水号
 }
 }
 
 if (objPubClassCaseSenateEN.IsUpdated(conPubClassCaseSenate.PubClassCaseSenator))
 {
 if (objPubClassCaseSenateEN.PubClassCaseSenator !=  null)
 {
 var strPubClassCaseSenator = objPubClassCaseSenateEN.PubClassCaseSenator.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PubClassCaseSenator = '{0}',", strPubClassCaseSenator); //公开课案例评议者
 }
 else
 {
 sbSQL.Append(" PubClassCaseSenator = null,"); //公开课案例评议者
 }
 }
 
 if (objPubClassCaseSenateEN.IsUpdated(conPubClassCaseSenate.PubClassCaseSenateTitle))
 {
 if (objPubClassCaseSenateEN.PubClassCaseSenateTitle !=  null)
 {
 var strPubClassCaseSenateTitle = objPubClassCaseSenateEN.PubClassCaseSenateTitle.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PubClassCaseSenateTitle = '{0}',", strPubClassCaseSenateTitle); //公开课案例评议标题
 }
 else
 {
 sbSQL.Append(" PubClassCaseSenateTitle = null,"); //公开课案例评议标题
 }
 }
 
 if (objPubClassCaseSenateEN.IsUpdated(conPubClassCaseSenate.PubClassCaseSenateContent))
 {
 if (objPubClassCaseSenateEN.PubClassCaseSenateContent !=  null)
 {
 var strPubClassCaseSenateContent = objPubClassCaseSenateEN.PubClassCaseSenateContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PubClassCaseSenateContent = '{0}',", strPubClassCaseSenateContent); //公开课案例评议内容
 }
 else
 {
 sbSQL.Append(" PubClassCaseSenateContent = null,"); //公开课案例评议内容
 }
 }
 
 if (objPubClassCaseSenateEN.IsUpdated(conPubClassCaseSenate.PubClassCaseSenateDate))
 {
 if (objPubClassCaseSenateEN.PubClassCaseSenateDate !=  null)
 {
 var strPubClassCaseSenateDate = objPubClassCaseSenateEN.PubClassCaseSenateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PubClassCaseSenateDate = '{0}',", strPubClassCaseSenateDate); //公开课案例评议日期
 }
 else
 {
 sbSQL.Append(" PubClassCaseSenateDate = null,"); //公开课案例评议日期
 }
 }
 
 if (objPubClassCaseSenateEN.IsUpdated(conPubClassCaseSenate.PubClassCaseSenateTime))
 {
 if (objPubClassCaseSenateEN.PubClassCaseSenateTime !=  null)
 {
 var strPubClassCaseSenateTime = objPubClassCaseSenateEN.PubClassCaseSenateTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PubClassCaseSenateTime = '{0}',", strPubClassCaseSenateTime); //公开课案例评议时间
 }
 else
 {
 sbSQL.Append(" PubClassCaseSenateTime = null,"); //公开课案例评议时间
 }
 }
 
 if (objPubClassCaseSenateEN.IsUpdated(conPubClassCaseSenate.SenateReadCount))
 {
 sbSQL.AppendFormat(" SenateReadCount = {0},", objPubClassCaseSenateEN.SenateReadCount); //评议阅读次数
 }
 
 if (objPubClassCaseSenateEN.IsUpdated(conPubClassCaseSenate.IsVisual))
 {
 sbSQL.AppendFormat(" IsVisual = '{0}',", objPubClassCaseSenateEN.IsVisual == true?"1":"0"); //隐藏标志
 }
 
 if (objPubClassCaseSenateEN.IsUpdated(conPubClassCaseSenate.IsElite))
 {
 sbSQL.AppendFormat(" IsElite = '{0}',", objPubClassCaseSenateEN.IsElite == true?"1":"0"); //精华标志
 }
 
 if (objPubClassCaseSenateEN.IsUpdated(conPubClassCaseSenate.IdResource))
 {
 if (objPubClassCaseSenateEN.IdResource  ==  "")
 {
 objPubClassCaseSenateEN.IdResource = null;
 }
 if (objPubClassCaseSenateEN.IdResource !=  null)
 {
 var strIdResource = objPubClassCaseSenateEN.IdResource.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdResource = '{0}',", strIdResource); //资源流水号
 }
 else
 {
 sbSQL.Append(" IdResource = null,"); //资源流水号
 }
 }
 
 if (objPubClassCaseSenateEN.IsUpdated(conPubClassCaseSenate.IdMediaType))
 {
 if (objPubClassCaseSenateEN.IdMediaType  ==  "")
 {
 objPubClassCaseSenateEN.IdMediaType = null;
 }
 if (objPubClassCaseSenateEN.IdMediaType !=  null)
 {
 var strIdMediaType = objPubClassCaseSenateEN.IdMediaType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdMediaType = '{0}',", strIdMediaType); //媒体格式流水号
 }
 else
 {
 sbSQL.Append(" IdMediaType = null,"); //媒体格式流水号
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
 /// <param name = "objPubClassCaseSenateEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsPubClassCaseSenateEN objPubClassCaseSenateEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objPubClassCaseSenateEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objPubClassCaseSenateEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPubClassCaseSenateDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update PubClassCaseSenate Set ");
 
 if (objPubClassCaseSenateEN.IsUpdated(conPubClassCaseSenate.IdPubClassCase))
 {
 if (objPubClassCaseSenateEN.IdPubClassCase  ==  "")
 {
 objPubClassCaseSenateEN.IdPubClassCase = null;
 }
 if (objPubClassCaseSenateEN.IdPubClassCase !=  null)
 {
 var strIdPubClassCase = objPubClassCaseSenateEN.IdPubClassCase.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdPubClassCase, conPubClassCaseSenate.IdPubClassCase); //案例流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPubClassCaseSenate.IdPubClassCase); //案例流水号
 }
 }
 
 if (objPubClassCaseSenateEN.IsUpdated(conPubClassCaseSenate.IdPubClassCaseSenateClass))
 {
 if (objPubClassCaseSenateEN.IdPubClassCaseSenateClass  ==  "")
 {
 objPubClassCaseSenateEN.IdPubClassCaseSenateClass = null;
 }
 if (objPubClassCaseSenateEN.IdPubClassCaseSenateClass !=  null)
 {
 var strIdPubClassCaseSenateClass = objPubClassCaseSenateEN.IdPubClassCaseSenateClass.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdPubClassCaseSenateClass, conPubClassCaseSenate.IdPubClassCaseSenateClass); //公开课案例评议类别流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPubClassCaseSenate.IdPubClassCaseSenateClass); //公开课案例评议类别流水号
 }
 }
 
 if (objPubClassCaseSenateEN.IsUpdated(conPubClassCaseSenate.PubClassCaseSenator))
 {
 if (objPubClassCaseSenateEN.PubClassCaseSenator !=  null)
 {
 var strPubClassCaseSenator = objPubClassCaseSenateEN.PubClassCaseSenator.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPubClassCaseSenator, conPubClassCaseSenate.PubClassCaseSenator); //公开课案例评议者
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPubClassCaseSenate.PubClassCaseSenator); //公开课案例评议者
 }
 }
 
 if (objPubClassCaseSenateEN.IsUpdated(conPubClassCaseSenate.PubClassCaseSenateTitle))
 {
 if (objPubClassCaseSenateEN.PubClassCaseSenateTitle !=  null)
 {
 var strPubClassCaseSenateTitle = objPubClassCaseSenateEN.PubClassCaseSenateTitle.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPubClassCaseSenateTitle, conPubClassCaseSenate.PubClassCaseSenateTitle); //公开课案例评议标题
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPubClassCaseSenate.PubClassCaseSenateTitle); //公开课案例评议标题
 }
 }
 
 if (objPubClassCaseSenateEN.IsUpdated(conPubClassCaseSenate.PubClassCaseSenateContent))
 {
 if (objPubClassCaseSenateEN.PubClassCaseSenateContent !=  null)
 {
 var strPubClassCaseSenateContent = objPubClassCaseSenateEN.PubClassCaseSenateContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPubClassCaseSenateContent, conPubClassCaseSenate.PubClassCaseSenateContent); //公开课案例评议内容
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPubClassCaseSenate.PubClassCaseSenateContent); //公开课案例评议内容
 }
 }
 
 if (objPubClassCaseSenateEN.IsUpdated(conPubClassCaseSenate.PubClassCaseSenateDate))
 {
 if (objPubClassCaseSenateEN.PubClassCaseSenateDate !=  null)
 {
 var strPubClassCaseSenateDate = objPubClassCaseSenateEN.PubClassCaseSenateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPubClassCaseSenateDate, conPubClassCaseSenate.PubClassCaseSenateDate); //公开课案例评议日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPubClassCaseSenate.PubClassCaseSenateDate); //公开课案例评议日期
 }
 }
 
 if (objPubClassCaseSenateEN.IsUpdated(conPubClassCaseSenate.PubClassCaseSenateTime))
 {
 if (objPubClassCaseSenateEN.PubClassCaseSenateTime !=  null)
 {
 var strPubClassCaseSenateTime = objPubClassCaseSenateEN.PubClassCaseSenateTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPubClassCaseSenateTime, conPubClassCaseSenate.PubClassCaseSenateTime); //公开课案例评议时间
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPubClassCaseSenate.PubClassCaseSenateTime); //公开课案例评议时间
 }
 }
 
 if (objPubClassCaseSenateEN.IsUpdated(conPubClassCaseSenate.SenateReadCount))
 {
 if (objPubClassCaseSenateEN.SenateReadCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objPubClassCaseSenateEN.SenateReadCount, conPubClassCaseSenate.SenateReadCount); //评议阅读次数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPubClassCaseSenate.SenateReadCount); //评议阅读次数
 }
 }
 
 if (objPubClassCaseSenateEN.IsUpdated(conPubClassCaseSenate.IsVisual))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objPubClassCaseSenateEN.IsVisual == true?"1":"0", conPubClassCaseSenate.IsVisual); //隐藏标志
 }
 
 if (objPubClassCaseSenateEN.IsUpdated(conPubClassCaseSenate.IsElite))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objPubClassCaseSenateEN.IsElite == true?"1":"0", conPubClassCaseSenate.IsElite); //精华标志
 }
 
 if (objPubClassCaseSenateEN.IsUpdated(conPubClassCaseSenate.IdResource))
 {
 if (objPubClassCaseSenateEN.IdResource  ==  "")
 {
 objPubClassCaseSenateEN.IdResource = null;
 }
 if (objPubClassCaseSenateEN.IdResource !=  null)
 {
 var strIdResource = objPubClassCaseSenateEN.IdResource.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdResource, conPubClassCaseSenate.IdResource); //资源流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPubClassCaseSenate.IdResource); //资源流水号
 }
 }
 
 if (objPubClassCaseSenateEN.IsUpdated(conPubClassCaseSenate.IdMediaType))
 {
 if (objPubClassCaseSenateEN.IdMediaType  ==  "")
 {
 objPubClassCaseSenateEN.IdMediaType = null;
 }
 if (objPubClassCaseSenateEN.IdMediaType !=  null)
 {
 var strIdMediaType = objPubClassCaseSenateEN.IdMediaType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdMediaType, conPubClassCaseSenate.IdMediaType); //媒体格式流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPubClassCaseSenate.IdMediaType); //媒体格式流水号
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where IdPubClassCaseSenate = {0}", objPubClassCaseSenateEN.IdPubClassCaseSenate); 
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
 /// <param name = "lngIdPubClassCaseSenate">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(long lngIdPubClassCaseSenate) 
{
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPubClassCaseSenateDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 lngIdPubClassCaseSenate,
};
 objSQL.ExecSP("PubClassCaseSenate_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "lngIdPubClassCaseSenate">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(long lngIdPubClassCaseSenate, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPubClassCaseSenateDA.GetSpecSQLObj();
//删除PubClassCaseSenate本表中与当前对象有关的记录
strSQL = strSQL + "Delete from PubClassCaseSenate where IdPubClassCaseSenate = " + ""+ lngIdPubClassCaseSenate+"";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelPubClassCaseSenate(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPubClassCaseSenateDA.GetSpecSQLObj();
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
//删除PubClassCaseSenate本表中与当前对象有关的记录
strSQL = strSQL + "Delete from PubClassCaseSenate where IdPubClassCaseSenate in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "lngIdPubClassCaseSenate">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(long lngIdPubClassCaseSenate) 
{
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPubClassCaseSenateDA.GetSpecSQLObj();
//删除PubClassCaseSenate本表中与当前对象有关的记录
strSQL = strSQL + "Delete from PubClassCaseSenate where IdPubClassCaseSenate = " + ""+ lngIdPubClassCaseSenate+"";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelPubClassCaseSenate(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsPubClassCaseSenateDA: DelPubClassCaseSenate)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPubClassCaseSenateDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from PubClassCaseSenate where " + strCondition ;
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
public bool DelPubClassCaseSenateWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsPubClassCaseSenateDA: DelPubClassCaseSenateWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPubClassCaseSenateDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from PubClassCaseSenate where " + strCondition ;
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
 /// <param name = "objPubClassCaseSenateENS">源对象</param>
 /// <param name = "objPubClassCaseSenateENT">目标对象</param>
public void CopyTo(clsPubClassCaseSenateEN objPubClassCaseSenateENS, clsPubClassCaseSenateEN objPubClassCaseSenateENT)
{
objPubClassCaseSenateENT.IdPubClassCaseSenate = objPubClassCaseSenateENS.IdPubClassCaseSenate; //公开课案例评议流水号
objPubClassCaseSenateENT.IdPubClassCase = objPubClassCaseSenateENS.IdPubClassCase; //案例流水号
objPubClassCaseSenateENT.IdPubClassCaseSenateClass = objPubClassCaseSenateENS.IdPubClassCaseSenateClass; //公开课案例评议类别流水号
objPubClassCaseSenateENT.PubClassCaseSenator = objPubClassCaseSenateENS.PubClassCaseSenator; //公开课案例评议者
objPubClassCaseSenateENT.PubClassCaseSenateTitle = objPubClassCaseSenateENS.PubClassCaseSenateTitle; //公开课案例评议标题
objPubClassCaseSenateENT.PubClassCaseSenateContent = objPubClassCaseSenateENS.PubClassCaseSenateContent; //公开课案例评议内容
objPubClassCaseSenateENT.PubClassCaseSenateDate = objPubClassCaseSenateENS.PubClassCaseSenateDate; //公开课案例评议日期
objPubClassCaseSenateENT.PubClassCaseSenateTime = objPubClassCaseSenateENS.PubClassCaseSenateTime; //公开课案例评议时间
objPubClassCaseSenateENT.SenateReadCount = objPubClassCaseSenateENS.SenateReadCount; //评议阅读次数
objPubClassCaseSenateENT.IsVisual = objPubClassCaseSenateENS.IsVisual; //隐藏标志
objPubClassCaseSenateENT.IsElite = objPubClassCaseSenateENS.IsElite; //精华标志
objPubClassCaseSenateENT.IdResource = objPubClassCaseSenateENS.IdResource; //资源流水号
objPubClassCaseSenateENT.IdMediaType = objPubClassCaseSenateENS.IdMediaType; //媒体格式流水号
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsPubClassCaseSenateEN objPubClassCaseSenateEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objPubClassCaseSenateEN.IdPubClassCase, conPubClassCaseSenate.IdPubClassCase);
clsCheckSql.CheckFieldNotNull(objPubClassCaseSenateEN.IdPubClassCaseSenateClass, conPubClassCaseSenate.IdPubClassCaseSenateClass);
clsCheckSql.CheckFieldNotNull(objPubClassCaseSenateEN.IsVisual, conPubClassCaseSenate.IsVisual);
clsCheckSql.CheckFieldNotNull(objPubClassCaseSenateEN.IsElite, conPubClassCaseSenate.IsElite);
clsCheckSql.CheckFieldNotNull(objPubClassCaseSenateEN.IdResource, conPubClassCaseSenate.IdResource);
//检查字段长度
clsCheckSql.CheckFieldLen(objPubClassCaseSenateEN.IdPubClassCase, 8, conPubClassCaseSenate.IdPubClassCase);
clsCheckSql.CheckFieldLen(objPubClassCaseSenateEN.IdPubClassCaseSenateClass, 4, conPubClassCaseSenate.IdPubClassCaseSenateClass);
clsCheckSql.CheckFieldLen(objPubClassCaseSenateEN.PubClassCaseSenator, 50, conPubClassCaseSenate.PubClassCaseSenator);
clsCheckSql.CheckFieldLen(objPubClassCaseSenateEN.PubClassCaseSenateTitle, 200, conPubClassCaseSenate.PubClassCaseSenateTitle);
clsCheckSql.CheckFieldLen(objPubClassCaseSenateEN.PubClassCaseSenateContent, 8000, conPubClassCaseSenate.PubClassCaseSenateContent);
clsCheckSql.CheckFieldLen(objPubClassCaseSenateEN.PubClassCaseSenateDate, 8, conPubClassCaseSenate.PubClassCaseSenateDate);
clsCheckSql.CheckFieldLen(objPubClassCaseSenateEN.PubClassCaseSenateTime, 6, conPubClassCaseSenate.PubClassCaseSenateTime);
clsCheckSql.CheckFieldLen(objPubClassCaseSenateEN.IdResource, 8, conPubClassCaseSenate.IdResource);
clsCheckSql.CheckFieldLen(objPubClassCaseSenateEN.IdMediaType, 4, conPubClassCaseSenate.IdMediaType);
//检查字段外键固定长度
clsCheckSql.CheckFieldForeignKey(objPubClassCaseSenateEN.IdPubClassCase, 8, conPubClassCaseSenate.IdPubClassCase);
clsCheckSql.CheckFieldForeignKey(objPubClassCaseSenateEN.IdPubClassCaseSenateClass, 4, conPubClassCaseSenate.IdPubClassCaseSenateClass);
clsCheckSql.CheckFieldForeignKey(objPubClassCaseSenateEN.IdResource, 8, conPubClassCaseSenate.IdResource);
clsCheckSql.CheckFieldForeignKey(objPubClassCaseSenateEN.IdMediaType, 4, conPubClassCaseSenate.IdMediaType);
 objPubClassCaseSenateEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsPubClassCaseSenateEN objPubClassCaseSenateEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objPubClassCaseSenateEN.IdPubClassCase, 8, conPubClassCaseSenate.IdPubClassCase);
clsCheckSql.CheckFieldLen(objPubClassCaseSenateEN.IdPubClassCaseSenateClass, 4, conPubClassCaseSenate.IdPubClassCaseSenateClass);
clsCheckSql.CheckFieldLen(objPubClassCaseSenateEN.PubClassCaseSenator, 50, conPubClassCaseSenate.PubClassCaseSenator);
clsCheckSql.CheckFieldLen(objPubClassCaseSenateEN.PubClassCaseSenateTitle, 200, conPubClassCaseSenate.PubClassCaseSenateTitle);
clsCheckSql.CheckFieldLen(objPubClassCaseSenateEN.PubClassCaseSenateContent, 8000, conPubClassCaseSenate.PubClassCaseSenateContent);
clsCheckSql.CheckFieldLen(objPubClassCaseSenateEN.PubClassCaseSenateDate, 8, conPubClassCaseSenate.PubClassCaseSenateDate);
clsCheckSql.CheckFieldLen(objPubClassCaseSenateEN.PubClassCaseSenateTime, 6, conPubClassCaseSenate.PubClassCaseSenateTime);
clsCheckSql.CheckFieldLen(objPubClassCaseSenateEN.IdResource, 8, conPubClassCaseSenate.IdResource);
clsCheckSql.CheckFieldLen(objPubClassCaseSenateEN.IdMediaType, 4, conPubClassCaseSenate.IdMediaType);
//检查外键字段长度
clsCheckSql.CheckFieldForeignKey(objPubClassCaseSenateEN.IdPubClassCase, 8, conPubClassCaseSenate.IdPubClassCase);
clsCheckSql.CheckFieldForeignKey(objPubClassCaseSenateEN.IdPubClassCaseSenateClass, 4, conPubClassCaseSenate.IdPubClassCaseSenateClass);
clsCheckSql.CheckFieldForeignKey(objPubClassCaseSenateEN.IdResource, 8, conPubClassCaseSenate.IdResource);
clsCheckSql.CheckFieldForeignKey(objPubClassCaseSenateEN.IdMediaType, 4, conPubClassCaseSenate.IdMediaType);
 objPubClassCaseSenateEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsPubClassCaseSenateEN objPubClassCaseSenateEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objPubClassCaseSenateEN.IdPubClassCase, 8, conPubClassCaseSenate.IdPubClassCase);
clsCheckSql.CheckFieldLen(objPubClassCaseSenateEN.IdPubClassCaseSenateClass, 4, conPubClassCaseSenate.IdPubClassCaseSenateClass);
clsCheckSql.CheckFieldLen(objPubClassCaseSenateEN.PubClassCaseSenator, 50, conPubClassCaseSenate.PubClassCaseSenator);
clsCheckSql.CheckFieldLen(objPubClassCaseSenateEN.PubClassCaseSenateTitle, 200, conPubClassCaseSenate.PubClassCaseSenateTitle);
clsCheckSql.CheckFieldLen(objPubClassCaseSenateEN.PubClassCaseSenateContent, 8000, conPubClassCaseSenate.PubClassCaseSenateContent);
clsCheckSql.CheckFieldLen(objPubClassCaseSenateEN.PubClassCaseSenateDate, 8, conPubClassCaseSenate.PubClassCaseSenateDate);
clsCheckSql.CheckFieldLen(objPubClassCaseSenateEN.PubClassCaseSenateTime, 6, conPubClassCaseSenate.PubClassCaseSenateTime);
clsCheckSql.CheckFieldLen(objPubClassCaseSenateEN.IdResource, 8, conPubClassCaseSenate.IdResource);
clsCheckSql.CheckFieldLen(objPubClassCaseSenateEN.IdMediaType, 4, conPubClassCaseSenate.IdMediaType);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objPubClassCaseSenateEN.IdPubClassCase, conPubClassCaseSenate.IdPubClassCase);
clsCheckSql.CheckSqlInjection4Field(objPubClassCaseSenateEN.IdPubClassCaseSenateClass, conPubClassCaseSenate.IdPubClassCaseSenateClass);
clsCheckSql.CheckSqlInjection4Field(objPubClassCaseSenateEN.PubClassCaseSenator, conPubClassCaseSenate.PubClassCaseSenator);
clsCheckSql.CheckSqlInjection4Field(objPubClassCaseSenateEN.PubClassCaseSenateTitle, conPubClassCaseSenate.PubClassCaseSenateTitle);
clsCheckSql.CheckSqlInjection4Field(objPubClassCaseSenateEN.PubClassCaseSenateContent, conPubClassCaseSenate.PubClassCaseSenateContent);
clsCheckSql.CheckSqlInjection4Field(objPubClassCaseSenateEN.PubClassCaseSenateDate, conPubClassCaseSenate.PubClassCaseSenateDate);
clsCheckSql.CheckSqlInjection4Field(objPubClassCaseSenateEN.PubClassCaseSenateTime, conPubClassCaseSenate.PubClassCaseSenateTime);
clsCheckSql.CheckSqlInjection4Field(objPubClassCaseSenateEN.IdResource, conPubClassCaseSenate.IdResource);
clsCheckSql.CheckSqlInjection4Field(objPubClassCaseSenateEN.IdMediaType, conPubClassCaseSenate.IdMediaType);
//检查外键字段长度
clsCheckSql.CheckFieldForeignKey(objPubClassCaseSenateEN.IdPubClassCase, 8, conPubClassCaseSenate.IdPubClassCase);
clsCheckSql.CheckFieldForeignKey(objPubClassCaseSenateEN.IdPubClassCaseSenateClass, 4, conPubClassCaseSenate.IdPubClassCaseSenateClass);
clsCheckSql.CheckFieldForeignKey(objPubClassCaseSenateEN.IdResource, 8, conPubClassCaseSenate.IdResource);
clsCheckSql.CheckFieldForeignKey(objPubClassCaseSenateEN.IdMediaType, 4, conPubClassCaseSenate.IdMediaType);
 objPubClassCaseSenateEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--PubClassCaseSenate(公开课案例评议),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objPubClassCaseSenateEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clsPubClassCaseSenateEN objPubClassCaseSenateEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and IdPubClassCase = '{0}'", objPubClassCaseSenateEN.IdPubClassCase);
 if (objPubClassCaseSenateEN.PubClassCaseSenator == null)
{
 sbCondition.AppendFormat(" and PubClassCaseSenator is null");
}
else
{
 sbCondition.AppendFormat(" and PubClassCaseSenator = '{0}'", objPubClassCaseSenateEN.PubClassCaseSenator);
}
 sbCondition.AppendFormat(" and IdResource = '{0}'", objPubClassCaseSenateEN.IdResource);
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
 objSQL = clsPubClassCaseSenateDA.GetSpecSQLObj();
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
 objSQL = clsPubClassCaseSenateDA.GetSpecSQLObj();
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
 objSQL = clsPubClassCaseSenateDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsPubClassCaseSenateEN._CurrTabName);
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
 objSQL = clsPubClassCaseSenateDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsPubClassCaseSenateEN._CurrTabName, strCondition);
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
 objSQL = clsPubClassCaseSenateDA.GetSpecSQLObj();
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
 objSQL = clsPubClassCaseSenateDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}