
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsMicroteachAppraiseDA
 表名:MicroteachAppraise(01120264)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:16:36
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
 /// 微格案例定性评议(MicroteachAppraise)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsMicroteachAppraiseDA : clsCommBase4DA
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
 return clsMicroteachAppraiseEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsMicroteachAppraiseEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsMicroteachAppraiseEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsMicroteachAppraiseEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsMicroteachAppraiseEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsMicroteachAppraiseDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsMicroteachAppraiseDA.GetSpecSQLObj();
strSQL = "Select * from MicroteachAppraise where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_MicroteachAppraise(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsMicroteachAppraiseDA: GetDataTable_MicroteachAppraise)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsMicroteachAppraiseDA.GetSpecSQLObj();
strSQL = "Select * from MicroteachAppraise where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsMicroteachAppraiseDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsMicroteachAppraiseDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsMicroteachAppraiseDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsMicroteachAppraiseDA.GetSpecSQLObj();
strSQL = "Select * from MicroteachAppraise where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsMicroteachAppraiseDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsMicroteachAppraiseDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsMicroteachAppraiseDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsMicroteachAppraiseDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from MicroteachAppraise where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from MicroteachAppraise where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsMicroteachAppraiseDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsMicroteachAppraiseDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from MicroteachAppraise where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsMicroteachAppraiseDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsMicroteachAppraiseDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} MicroteachAppraise.* from MicroteachAppraise Left Join {1} on {2} where {3} and MicroteachAppraise.IdMicroteachAppraise not in (Select top {5} MicroteachAppraise.IdMicroteachAppraise from MicroteachAppraise Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from MicroteachAppraise where {1} and IdMicroteachAppraise not in (Select top {2} IdMicroteachAppraise from MicroteachAppraise where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from MicroteachAppraise where {1} and IdMicroteachAppraise not in (Select top {3} IdMicroteachAppraise from MicroteachAppraise where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsMicroteachAppraiseDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsMicroteachAppraiseDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} MicroteachAppraise.* from MicroteachAppraise Left Join {1} on {2} where {3} and MicroteachAppraise.IdMicroteachAppraise not in (Select top {5} MicroteachAppraise.IdMicroteachAppraise from MicroteachAppraise Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from MicroteachAppraise where {1} and IdMicroteachAppraise not in (Select top {2} IdMicroteachAppraise from MicroteachAppraise where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from MicroteachAppraise where {1} and IdMicroteachAppraise not in (Select top {3} IdMicroteachAppraise from MicroteachAppraise where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsMicroteachAppraiseEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsMicroteachAppraiseDA:GetObjLst)", objException.Message));
}
List<clsMicroteachAppraiseEN> arrObjLst = new List<clsMicroteachAppraiseEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsMicroteachAppraiseDA.GetSpecSQLObj();
strSQL = "Select * from MicroteachAppraise where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsMicroteachAppraiseEN objMicroteachAppraiseEN = new clsMicroteachAppraiseEN();
try
{
objMicroteachAppraiseEN.IdMicroteachAppraise = TransNullToInt(objRow[conMicroteachAppraise.IdMicroteachAppraise].ToString().Trim()); //评议流水号
objMicroteachAppraiseEN.FuncModuleId = objRow[conMicroteachAppraise.FuncModuleId].ToString().Trim(); //功能模块Id
objMicroteachAppraiseEN.IdMicroteachCase = objRow[conMicroteachAppraise.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objMicroteachAppraiseEN.IdAppraiseType = objRow[conMicroteachAppraise.IdAppraiseType].ToString().Trim(); //评议类型流水号
objMicroteachAppraiseEN.AppraiseTheme = objRow[conMicroteachAppraise.AppraiseTheme] == DBNull.Value ? null : objRow[conMicroteachAppraise.AppraiseTheme].ToString().Trim(); //评议主题
objMicroteachAppraiseEN.AppraiseContent = objRow[conMicroteachAppraise.AppraiseContent] == DBNull.Value ? null : objRow[conMicroteachAppraise.AppraiseContent].ToString().Trim(); //评议内容
objMicroteachAppraiseEN.AppraiseDate = objRow[conMicroteachAppraise.AppraiseDate] == DBNull.Value ? null : objRow[conMicroteachAppraise.AppraiseDate].ToString().Trim(); //评议日期
objMicroteachAppraiseEN.AppraiseTime = objRow[conMicroteachAppraise.AppraiseTime] == DBNull.Value ? null : objRow[conMicroteachAppraise.AppraiseTime].ToString().Trim(); //评议时间
objMicroteachAppraiseEN.IsVisual = TransNullToBool(objRow[conMicroteachAppraise.IsVisual].ToString().Trim()); //隐藏标志
objMicroteachAppraiseEN.IsElite = TransNullToBool(objRow[conMicroteachAppraise.IsElite].ToString().Trim()); //精华标志
objMicroteachAppraiseEN.ExcellentOne = objRow[conMicroteachAppraise.ExcellentOne] == DBNull.Value ? null : objRow[conMicroteachAppraise.ExcellentOne].ToString().Trim(); //优点1
objMicroteachAppraiseEN.ExcellentTwo = objRow[conMicroteachAppraise.ExcellentTwo] == DBNull.Value ? null : objRow[conMicroteachAppraise.ExcellentTwo].ToString().Trim(); //优点2
objMicroteachAppraiseEN.SuggestOne = objRow[conMicroteachAppraise.SuggestOne] == DBNull.Value ? null : objRow[conMicroteachAppraise.SuggestOne].ToString().Trim(); //建议1
objMicroteachAppraiseEN.SuggestTwo = objRow[conMicroteachAppraise.SuggestTwo] == DBNull.Value ? null : objRow[conMicroteachAppraise.SuggestTwo].ToString().Trim(); //建议2
objMicroteachAppraiseEN.MicroteachAppriseScore = objRow[conMicroteachAppraise.MicroteachAppriseScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conMicroteachAppraise.MicroteachAppriseScore].ToString().Trim()); //打分
objMicroteachAppraiseEN.VideoStopTime = objRow[conMicroteachAppraise.VideoStopTime] == DBNull.Value ? null : objRow[conMicroteachAppraise.VideoStopTime].ToString().Trim(); //公开课案例视频暂停时间
objMicroteachAppraiseEN.BrowseCount = objRow[conMicroteachAppraise.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conMicroteachAppraise.BrowseCount].ToString().Trim()); //浏览次数
objMicroteachAppraiseEN.UserId = objRow[conMicroteachAppraise.UserId].ToString().Trim(); //用户ID
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsMicroteachAppraiseDA: GetObjLst)", objException.Message));
}
objMicroteachAppraiseEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objMicroteachAppraiseEN);
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
public List<clsMicroteachAppraiseEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsMicroteachAppraiseDA:GetObjLstByTabName)", objException.Message));
}
List<clsMicroteachAppraiseEN> arrObjLst = new List<clsMicroteachAppraiseEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsMicroteachAppraiseDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsMicroteachAppraiseEN objMicroteachAppraiseEN = new clsMicroteachAppraiseEN();
try
{
objMicroteachAppraiseEN.IdMicroteachAppraise = TransNullToInt(objRow[conMicroteachAppraise.IdMicroteachAppraise].ToString().Trim()); //评议流水号
objMicroteachAppraiseEN.FuncModuleId = objRow[conMicroteachAppraise.FuncModuleId].ToString().Trim(); //功能模块Id
objMicroteachAppraiseEN.IdMicroteachCase = objRow[conMicroteachAppraise.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objMicroteachAppraiseEN.IdAppraiseType = objRow[conMicroteachAppraise.IdAppraiseType].ToString().Trim(); //评议类型流水号
objMicroteachAppraiseEN.AppraiseTheme = objRow[conMicroteachAppraise.AppraiseTheme] == DBNull.Value ? null : objRow[conMicroteachAppraise.AppraiseTheme].ToString().Trim(); //评议主题
objMicroteachAppraiseEN.AppraiseContent = objRow[conMicroteachAppraise.AppraiseContent] == DBNull.Value ? null : objRow[conMicroteachAppraise.AppraiseContent].ToString().Trim(); //评议内容
objMicroteachAppraiseEN.AppraiseDate = objRow[conMicroteachAppraise.AppraiseDate] == DBNull.Value ? null : objRow[conMicroteachAppraise.AppraiseDate].ToString().Trim(); //评议日期
objMicroteachAppraiseEN.AppraiseTime = objRow[conMicroteachAppraise.AppraiseTime] == DBNull.Value ? null : objRow[conMicroteachAppraise.AppraiseTime].ToString().Trim(); //评议时间
objMicroteachAppraiseEN.IsVisual = TransNullToBool(objRow[conMicroteachAppraise.IsVisual].ToString().Trim()); //隐藏标志
objMicroteachAppraiseEN.IsElite = TransNullToBool(objRow[conMicroteachAppraise.IsElite].ToString().Trim()); //精华标志
objMicroteachAppraiseEN.ExcellentOne = objRow[conMicroteachAppraise.ExcellentOne] == DBNull.Value ? null : objRow[conMicroteachAppraise.ExcellentOne].ToString().Trim(); //优点1
objMicroteachAppraiseEN.ExcellentTwo = objRow[conMicroteachAppraise.ExcellentTwo] == DBNull.Value ? null : objRow[conMicroteachAppraise.ExcellentTwo].ToString().Trim(); //优点2
objMicroteachAppraiseEN.SuggestOne = objRow[conMicroteachAppraise.SuggestOne] == DBNull.Value ? null : objRow[conMicroteachAppraise.SuggestOne].ToString().Trim(); //建议1
objMicroteachAppraiseEN.SuggestTwo = objRow[conMicroteachAppraise.SuggestTwo] == DBNull.Value ? null : objRow[conMicroteachAppraise.SuggestTwo].ToString().Trim(); //建议2
objMicroteachAppraiseEN.MicroteachAppriseScore = objRow[conMicroteachAppraise.MicroteachAppriseScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conMicroteachAppraise.MicroteachAppriseScore].ToString().Trim()); //打分
objMicroteachAppraiseEN.VideoStopTime = objRow[conMicroteachAppraise.VideoStopTime] == DBNull.Value ? null : objRow[conMicroteachAppraise.VideoStopTime].ToString().Trim(); //公开课案例视频暂停时间
objMicroteachAppraiseEN.BrowseCount = objRow[conMicroteachAppraise.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conMicroteachAppraise.BrowseCount].ToString().Trim()); //浏览次数
objMicroteachAppraiseEN.UserId = objRow[conMicroteachAppraise.UserId].ToString().Trim(); //用户ID
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsMicroteachAppraiseDA: GetObjLst)", objException.Message));
}
objMicroteachAppraiseEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objMicroteachAppraiseEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objMicroteachAppraiseEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetMicroteachAppraise(ref clsMicroteachAppraiseEN objMicroteachAppraiseEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsMicroteachAppraiseDA.GetSpecSQLObj();
strSQL = "Select * from MicroteachAppraise where IdMicroteachAppraise = " + ""+ objMicroteachAppraiseEN.IdMicroteachAppraise+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objMicroteachAppraiseEN.IdMicroteachAppraise = TransNullToInt(objDT.Rows[0][conMicroteachAppraise.IdMicroteachAppraise].ToString().Trim()); //评议流水号(字段类型:bigint,字段长度:8,是否可空:False)
 objMicroteachAppraiseEN.FuncModuleId = objDT.Rows[0][conMicroteachAppraise.FuncModuleId].ToString().Trim(); //功能模块Id(字段类型:char,字段长度:4,是否可空:True)
 objMicroteachAppraiseEN.IdMicroteachCase = objDT.Rows[0][conMicroteachAppraise.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号(字段类型:char,字段长度:8,是否可空:False)
 objMicroteachAppraiseEN.IdAppraiseType = objDT.Rows[0][conMicroteachAppraise.IdAppraiseType].ToString().Trim(); //评议类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objMicroteachAppraiseEN.AppraiseTheme = objDT.Rows[0][conMicroteachAppraise.AppraiseTheme].ToString().Trim(); //评议主题(字段类型:varchar,字段长度:200,是否可空:True)
 objMicroteachAppraiseEN.AppraiseContent = objDT.Rows[0][conMicroteachAppraise.AppraiseContent].ToString().Trim(); //评议内容(字段类型:varchar,字段长度:2000,是否可空:True)
 objMicroteachAppraiseEN.AppraiseDate = objDT.Rows[0][conMicroteachAppraise.AppraiseDate].ToString().Trim(); //评议日期(字段类型:char,字段长度:8,是否可空:True)
 objMicroteachAppraiseEN.AppraiseTime = objDT.Rows[0][conMicroteachAppraise.AppraiseTime].ToString().Trim(); //评议时间(字段类型:char,字段长度:6,是否可空:True)
 objMicroteachAppraiseEN.IsVisual = TransNullToBool(objDT.Rows[0][conMicroteachAppraise.IsVisual].ToString().Trim()); //隐藏标志(字段类型:bit,字段长度:1,是否可空:False)
 objMicroteachAppraiseEN.IsElite = TransNullToBool(objDT.Rows[0][conMicroteachAppraise.IsElite].ToString().Trim()); //精华标志(字段类型:bit,字段长度:1,是否可空:False)
 objMicroteachAppraiseEN.ExcellentOne = objDT.Rows[0][conMicroteachAppraise.ExcellentOne].ToString().Trim(); //优点1(字段类型:varchar,字段长度:1000,是否可空:True)
 objMicroteachAppraiseEN.ExcellentTwo = objDT.Rows[0][conMicroteachAppraise.ExcellentTwo].ToString().Trim(); //优点2(字段类型:varchar,字段长度:1000,是否可空:True)
 objMicroteachAppraiseEN.SuggestOne = objDT.Rows[0][conMicroteachAppraise.SuggestOne].ToString().Trim(); //建议1(字段类型:varchar,字段长度:1000,是否可空:True)
 objMicroteachAppraiseEN.SuggestTwo = objDT.Rows[0][conMicroteachAppraise.SuggestTwo].ToString().Trim(); //建议2(字段类型:varchar,字段长度:1000,是否可空:True)
 objMicroteachAppraiseEN.MicroteachAppriseScore = TransNullToFloat(objDT.Rows[0][conMicroteachAppraise.MicroteachAppriseScore].ToString().Trim()); //打分(字段类型:float,字段长度:8,是否可空:True)
 objMicroteachAppraiseEN.VideoStopTime = objDT.Rows[0][conMicroteachAppraise.VideoStopTime].ToString().Trim(); //公开课案例视频暂停时间(字段类型:varchar,字段长度:48,是否可空:True)
 objMicroteachAppraiseEN.BrowseCount = TransNullToInt(objDT.Rows[0][conMicroteachAppraise.BrowseCount].ToString().Trim()); //浏览次数(字段类型:int,字段长度:4,是否可空:True)
 objMicroteachAppraiseEN.UserId = objDT.Rows[0][conMicroteachAppraise.UserId].ToString().Trim(); //用户ID(字段类型:varchar,字段长度:18,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsMicroteachAppraiseDA: GetMicroteachAppraise)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngIdMicroteachAppraise">表关键字</param>
 /// <returns>表对象</returns>
public clsMicroteachAppraiseEN GetObjByIdMicroteachAppraise(long lngIdMicroteachAppraise)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsMicroteachAppraiseDA.GetSpecSQLObj();
strSQL = "Select * from MicroteachAppraise where IdMicroteachAppraise = " + ""+ lngIdMicroteachAppraise+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsMicroteachAppraiseEN objMicroteachAppraiseEN = new clsMicroteachAppraiseEN();
try
{
 objMicroteachAppraiseEN.IdMicroteachAppraise = Int32.Parse(objRow[conMicroteachAppraise.IdMicroteachAppraise].ToString().Trim()); //评议流水号(字段类型:bigint,字段长度:8,是否可空:False)
 objMicroteachAppraiseEN.FuncModuleId = objRow[conMicroteachAppraise.FuncModuleId].ToString().Trim(); //功能模块Id(字段类型:char,字段长度:4,是否可空:True)
 objMicroteachAppraiseEN.IdMicroteachCase = objRow[conMicroteachAppraise.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号(字段类型:char,字段长度:8,是否可空:False)
 objMicroteachAppraiseEN.IdAppraiseType = objRow[conMicroteachAppraise.IdAppraiseType].ToString().Trim(); //评议类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objMicroteachAppraiseEN.AppraiseTheme = objRow[conMicroteachAppraise.AppraiseTheme] == DBNull.Value ? null : objRow[conMicroteachAppraise.AppraiseTheme].ToString().Trim(); //评议主题(字段类型:varchar,字段长度:200,是否可空:True)
 objMicroteachAppraiseEN.AppraiseContent = objRow[conMicroteachAppraise.AppraiseContent] == DBNull.Value ? null : objRow[conMicroteachAppraise.AppraiseContent].ToString().Trim(); //评议内容(字段类型:varchar,字段长度:2000,是否可空:True)
 objMicroteachAppraiseEN.AppraiseDate = objRow[conMicroteachAppraise.AppraiseDate] == DBNull.Value ? null : objRow[conMicroteachAppraise.AppraiseDate].ToString().Trim(); //评议日期(字段类型:char,字段长度:8,是否可空:True)
 objMicroteachAppraiseEN.AppraiseTime = objRow[conMicroteachAppraise.AppraiseTime] == DBNull.Value ? null : objRow[conMicroteachAppraise.AppraiseTime].ToString().Trim(); //评议时间(字段类型:char,字段长度:6,是否可空:True)
 objMicroteachAppraiseEN.IsVisual = clsEntityBase2.TransNullToBool_S(objRow[conMicroteachAppraise.IsVisual].ToString().Trim()); //隐藏标志(字段类型:bit,字段长度:1,是否可空:False)
 objMicroteachAppraiseEN.IsElite = clsEntityBase2.TransNullToBool_S(objRow[conMicroteachAppraise.IsElite].ToString().Trim()); //精华标志(字段类型:bit,字段长度:1,是否可空:False)
 objMicroteachAppraiseEN.ExcellentOne = objRow[conMicroteachAppraise.ExcellentOne] == DBNull.Value ? null : objRow[conMicroteachAppraise.ExcellentOne].ToString().Trim(); //优点1(字段类型:varchar,字段长度:1000,是否可空:True)
 objMicroteachAppraiseEN.ExcellentTwo = objRow[conMicroteachAppraise.ExcellentTwo] == DBNull.Value ? null : objRow[conMicroteachAppraise.ExcellentTwo].ToString().Trim(); //优点2(字段类型:varchar,字段长度:1000,是否可空:True)
 objMicroteachAppraiseEN.SuggestOne = objRow[conMicroteachAppraise.SuggestOne] == DBNull.Value ? null : objRow[conMicroteachAppraise.SuggestOne].ToString().Trim(); //建议1(字段类型:varchar,字段长度:1000,是否可空:True)
 objMicroteachAppraiseEN.SuggestTwo = objRow[conMicroteachAppraise.SuggestTwo] == DBNull.Value ? null : objRow[conMicroteachAppraise.SuggestTwo].ToString().Trim(); //建议2(字段类型:varchar,字段长度:1000,是否可空:True)
 objMicroteachAppraiseEN.MicroteachAppriseScore = objRow[conMicroteachAppraise.MicroteachAppriseScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conMicroteachAppraise.MicroteachAppriseScore].ToString().Trim()); //打分(字段类型:float,字段长度:8,是否可空:True)
 objMicroteachAppraiseEN.VideoStopTime = objRow[conMicroteachAppraise.VideoStopTime] == DBNull.Value ? null : objRow[conMicroteachAppraise.VideoStopTime].ToString().Trim(); //公开课案例视频暂停时间(字段类型:varchar,字段长度:48,是否可空:True)
 objMicroteachAppraiseEN.BrowseCount = objRow[conMicroteachAppraise.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conMicroteachAppraise.BrowseCount].ToString().Trim()); //浏览次数(字段类型:int,字段长度:4,是否可空:True)
 objMicroteachAppraiseEN.UserId = objRow[conMicroteachAppraise.UserId].ToString().Trim(); //用户ID(字段类型:varchar,字段长度:18,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsMicroteachAppraiseDA: GetObjByIdMicroteachAppraise)", objException.Message));
}
return objMicroteachAppraiseEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsMicroteachAppraiseEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsMicroteachAppraiseDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsMicroteachAppraiseDA.GetSpecSQLObj();
strSQL = "Select * from MicroteachAppraise where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsMicroteachAppraiseEN objMicroteachAppraiseEN = new clsMicroteachAppraiseEN()
{
IdMicroteachAppraise = TransNullToInt(objRow[conMicroteachAppraise.IdMicroteachAppraise].ToString().Trim()), //评议流水号
FuncModuleId = objRow[conMicroteachAppraise.FuncModuleId].ToString().Trim(), //功能模块Id
IdMicroteachCase = objRow[conMicroteachAppraise.IdMicroteachCase].ToString().Trim(), //微格教学案例流水号
IdAppraiseType = objRow[conMicroteachAppraise.IdAppraiseType].ToString().Trim(), //评议类型流水号
AppraiseTheme = objRow[conMicroteachAppraise.AppraiseTheme] == DBNull.Value ? null : objRow[conMicroteachAppraise.AppraiseTheme].ToString().Trim(), //评议主题
AppraiseContent = objRow[conMicroteachAppraise.AppraiseContent] == DBNull.Value ? null : objRow[conMicroteachAppraise.AppraiseContent].ToString().Trim(), //评议内容
AppraiseDate = objRow[conMicroteachAppraise.AppraiseDate] == DBNull.Value ? null : objRow[conMicroteachAppraise.AppraiseDate].ToString().Trim(), //评议日期
AppraiseTime = objRow[conMicroteachAppraise.AppraiseTime] == DBNull.Value ? null : objRow[conMicroteachAppraise.AppraiseTime].ToString().Trim(), //评议时间
IsVisual = TransNullToBool(objRow[conMicroteachAppraise.IsVisual].ToString().Trim()), //隐藏标志
IsElite = TransNullToBool(objRow[conMicroteachAppraise.IsElite].ToString().Trim()), //精华标志
ExcellentOne = objRow[conMicroteachAppraise.ExcellentOne] == DBNull.Value ? null : objRow[conMicroteachAppraise.ExcellentOne].ToString().Trim(), //优点1
ExcellentTwo = objRow[conMicroteachAppraise.ExcellentTwo] == DBNull.Value ? null : objRow[conMicroteachAppraise.ExcellentTwo].ToString().Trim(), //优点2
SuggestOne = objRow[conMicroteachAppraise.SuggestOne] == DBNull.Value ? null : objRow[conMicroteachAppraise.SuggestOne].ToString().Trim(), //建议1
SuggestTwo = objRow[conMicroteachAppraise.SuggestTwo] == DBNull.Value ? null : objRow[conMicroteachAppraise.SuggestTwo].ToString().Trim(), //建议2
MicroteachAppriseScore = objRow[conMicroteachAppraise.MicroteachAppriseScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conMicroteachAppraise.MicroteachAppriseScore].ToString().Trim()), //打分
VideoStopTime = objRow[conMicroteachAppraise.VideoStopTime] == DBNull.Value ? null : objRow[conMicroteachAppraise.VideoStopTime].ToString().Trim(), //公开课案例视频暂停时间
BrowseCount = objRow[conMicroteachAppraise.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conMicroteachAppraise.BrowseCount].ToString().Trim()), //浏览次数
UserId = objRow[conMicroteachAppraise.UserId].ToString().Trim() //用户ID
};
objMicroteachAppraiseEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objMicroteachAppraiseEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsMicroteachAppraiseDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsMicroteachAppraiseEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsMicroteachAppraiseEN objMicroteachAppraiseEN = new clsMicroteachAppraiseEN();
try
{
objMicroteachAppraiseEN.IdMicroteachAppraise = TransNullToInt(objRow[conMicroteachAppraise.IdMicroteachAppraise].ToString().Trim()); //评议流水号
objMicroteachAppraiseEN.FuncModuleId = objRow[conMicroteachAppraise.FuncModuleId].ToString().Trim(); //功能模块Id
objMicroteachAppraiseEN.IdMicroteachCase = objRow[conMicroteachAppraise.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objMicroteachAppraiseEN.IdAppraiseType = objRow[conMicroteachAppraise.IdAppraiseType].ToString().Trim(); //评议类型流水号
objMicroteachAppraiseEN.AppraiseTheme = objRow[conMicroteachAppraise.AppraiseTheme] == DBNull.Value ? null : objRow[conMicroteachAppraise.AppraiseTheme].ToString().Trim(); //评议主题
objMicroteachAppraiseEN.AppraiseContent = objRow[conMicroteachAppraise.AppraiseContent] == DBNull.Value ? null : objRow[conMicroteachAppraise.AppraiseContent].ToString().Trim(); //评议内容
objMicroteachAppraiseEN.AppraiseDate = objRow[conMicroteachAppraise.AppraiseDate] == DBNull.Value ? null : objRow[conMicroteachAppraise.AppraiseDate].ToString().Trim(); //评议日期
objMicroteachAppraiseEN.AppraiseTime = objRow[conMicroteachAppraise.AppraiseTime] == DBNull.Value ? null : objRow[conMicroteachAppraise.AppraiseTime].ToString().Trim(); //评议时间
objMicroteachAppraiseEN.IsVisual = TransNullToBool(objRow[conMicroteachAppraise.IsVisual].ToString().Trim()); //隐藏标志
objMicroteachAppraiseEN.IsElite = TransNullToBool(objRow[conMicroteachAppraise.IsElite].ToString().Trim()); //精华标志
objMicroteachAppraiseEN.ExcellentOne = objRow[conMicroteachAppraise.ExcellentOne] == DBNull.Value ? null : objRow[conMicroteachAppraise.ExcellentOne].ToString().Trim(); //优点1
objMicroteachAppraiseEN.ExcellentTwo = objRow[conMicroteachAppraise.ExcellentTwo] == DBNull.Value ? null : objRow[conMicroteachAppraise.ExcellentTwo].ToString().Trim(); //优点2
objMicroteachAppraiseEN.SuggestOne = objRow[conMicroteachAppraise.SuggestOne] == DBNull.Value ? null : objRow[conMicroteachAppraise.SuggestOne].ToString().Trim(); //建议1
objMicroteachAppraiseEN.SuggestTwo = objRow[conMicroteachAppraise.SuggestTwo] == DBNull.Value ? null : objRow[conMicroteachAppraise.SuggestTwo].ToString().Trim(); //建议2
objMicroteachAppraiseEN.MicroteachAppriseScore = objRow[conMicroteachAppraise.MicroteachAppriseScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conMicroteachAppraise.MicroteachAppriseScore].ToString().Trim()); //打分
objMicroteachAppraiseEN.VideoStopTime = objRow[conMicroteachAppraise.VideoStopTime] == DBNull.Value ? null : objRow[conMicroteachAppraise.VideoStopTime].ToString().Trim(); //公开课案例视频暂停时间
objMicroteachAppraiseEN.BrowseCount = objRow[conMicroteachAppraise.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conMicroteachAppraise.BrowseCount].ToString().Trim()); //浏览次数
objMicroteachAppraiseEN.UserId = objRow[conMicroteachAppraise.UserId].ToString().Trim(); //用户ID
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsMicroteachAppraiseDA: GetObjByDataRowMicroteachAppraise)", objException.Message));
}
objMicroteachAppraiseEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objMicroteachAppraiseEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsMicroteachAppraiseEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsMicroteachAppraiseEN objMicroteachAppraiseEN = new clsMicroteachAppraiseEN();
try
{
objMicroteachAppraiseEN.IdMicroteachAppraise = TransNullToInt(objRow[conMicroteachAppraise.IdMicroteachAppraise].ToString().Trim()); //评议流水号
objMicroteachAppraiseEN.FuncModuleId = objRow[conMicroteachAppraise.FuncModuleId].ToString().Trim(); //功能模块Id
objMicroteachAppraiseEN.IdMicroteachCase = objRow[conMicroteachAppraise.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objMicroteachAppraiseEN.IdAppraiseType = objRow[conMicroteachAppraise.IdAppraiseType].ToString().Trim(); //评议类型流水号
objMicroteachAppraiseEN.AppraiseTheme = objRow[conMicroteachAppraise.AppraiseTheme] == DBNull.Value ? null : objRow[conMicroteachAppraise.AppraiseTheme].ToString().Trim(); //评议主题
objMicroteachAppraiseEN.AppraiseContent = objRow[conMicroteachAppraise.AppraiseContent] == DBNull.Value ? null : objRow[conMicroteachAppraise.AppraiseContent].ToString().Trim(); //评议内容
objMicroteachAppraiseEN.AppraiseDate = objRow[conMicroteachAppraise.AppraiseDate] == DBNull.Value ? null : objRow[conMicroteachAppraise.AppraiseDate].ToString().Trim(); //评议日期
objMicroteachAppraiseEN.AppraiseTime = objRow[conMicroteachAppraise.AppraiseTime] == DBNull.Value ? null : objRow[conMicroteachAppraise.AppraiseTime].ToString().Trim(); //评议时间
objMicroteachAppraiseEN.IsVisual = TransNullToBool(objRow[conMicroteachAppraise.IsVisual].ToString().Trim()); //隐藏标志
objMicroteachAppraiseEN.IsElite = TransNullToBool(objRow[conMicroteachAppraise.IsElite].ToString().Trim()); //精华标志
objMicroteachAppraiseEN.ExcellentOne = objRow[conMicroteachAppraise.ExcellentOne] == DBNull.Value ? null : objRow[conMicroteachAppraise.ExcellentOne].ToString().Trim(); //优点1
objMicroteachAppraiseEN.ExcellentTwo = objRow[conMicroteachAppraise.ExcellentTwo] == DBNull.Value ? null : objRow[conMicroteachAppraise.ExcellentTwo].ToString().Trim(); //优点2
objMicroteachAppraiseEN.SuggestOne = objRow[conMicroteachAppraise.SuggestOne] == DBNull.Value ? null : objRow[conMicroteachAppraise.SuggestOne].ToString().Trim(); //建议1
objMicroteachAppraiseEN.SuggestTwo = objRow[conMicroteachAppraise.SuggestTwo] == DBNull.Value ? null : objRow[conMicroteachAppraise.SuggestTwo].ToString().Trim(); //建议2
objMicroteachAppraiseEN.MicroteachAppriseScore = objRow[conMicroteachAppraise.MicroteachAppriseScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conMicroteachAppraise.MicroteachAppriseScore].ToString().Trim()); //打分
objMicroteachAppraiseEN.VideoStopTime = objRow[conMicroteachAppraise.VideoStopTime] == DBNull.Value ? null : objRow[conMicroteachAppraise.VideoStopTime].ToString().Trim(); //公开课案例视频暂停时间
objMicroteachAppraiseEN.BrowseCount = objRow[conMicroteachAppraise.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conMicroteachAppraise.BrowseCount].ToString().Trim()); //浏览次数
objMicroteachAppraiseEN.UserId = objRow[conMicroteachAppraise.UserId].ToString().Trim(); //用户ID
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsMicroteachAppraiseDA: GetObjByDataRow)", objException.Message));
}
objMicroteachAppraiseEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objMicroteachAppraiseEN;
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
objSQL = clsMicroteachAppraiseDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsMicroteachAppraiseEN._CurrTabName, conMicroteachAppraise.IdMicroteachAppraise, 8, "");
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
objSQL = clsMicroteachAppraiseDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsMicroteachAppraiseEN._CurrTabName, conMicroteachAppraise.IdMicroteachAppraise, 8, strPrefix);
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
 objSQL = clsMicroteachAppraiseDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select IdMicroteachAppraise from MicroteachAppraise where " + strCondition;
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
 objSQL = clsMicroteachAppraiseDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select IdMicroteachAppraise from MicroteachAppraise where " + strCondition;
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
 /// <param name = "lngIdMicroteachAppraise">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(long lngIdMicroteachAppraise)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsMicroteachAppraiseDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("MicroteachAppraise", "IdMicroteachAppraise = " + ""+ lngIdMicroteachAppraise+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsMicroteachAppraiseDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsMicroteachAppraiseDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("MicroteachAppraise", strCondition))
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
objSQL = clsMicroteachAppraiseDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("MicroteachAppraise");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsMicroteachAppraiseEN objMicroteachAppraiseEN)
 {
 if (objMicroteachAppraiseEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objMicroteachAppraiseEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsMicroteachAppraiseDA.GetSpecSQLObj();
strSQL = "Select * from MicroteachAppraise where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "MicroteachAppraise");
objRow = objDS.Tables["MicroteachAppraise"].NewRow();
objRow[conMicroteachAppraise.FuncModuleId] = objMicroteachAppraiseEN.FuncModuleId; //功能模块Id
objRow[conMicroteachAppraise.IdMicroteachCase] = objMicroteachAppraiseEN.IdMicroteachCase; //微格教学案例流水号
objRow[conMicroteachAppraise.IdAppraiseType] = objMicroteachAppraiseEN.IdAppraiseType; //评议类型流水号
 if (objMicroteachAppraiseEN.AppraiseTheme !=  "")
 {
objRow[conMicroteachAppraise.AppraiseTheme] = objMicroteachAppraiseEN.AppraiseTheme; //评议主题
 }
 if (objMicroteachAppraiseEN.AppraiseContent !=  "")
 {
objRow[conMicroteachAppraise.AppraiseContent] = objMicroteachAppraiseEN.AppraiseContent; //评议内容
 }
 if (objMicroteachAppraiseEN.AppraiseDate !=  "")
 {
objRow[conMicroteachAppraise.AppraiseDate] = objMicroteachAppraiseEN.AppraiseDate; //评议日期
 }
 if (objMicroteachAppraiseEN.AppraiseTime !=  "")
 {
objRow[conMicroteachAppraise.AppraiseTime] = objMicroteachAppraiseEN.AppraiseTime; //评议时间
 }
objRow[conMicroteachAppraise.IsVisual] = objMicroteachAppraiseEN.IsVisual; //隐藏标志
objRow[conMicroteachAppraise.IsElite] = objMicroteachAppraiseEN.IsElite; //精华标志
 if (objMicroteachAppraiseEN.ExcellentOne !=  "")
 {
objRow[conMicroteachAppraise.ExcellentOne] = objMicroteachAppraiseEN.ExcellentOne; //优点1
 }
 if (objMicroteachAppraiseEN.ExcellentTwo !=  "")
 {
objRow[conMicroteachAppraise.ExcellentTwo] = objMicroteachAppraiseEN.ExcellentTwo; //优点2
 }
 if (objMicroteachAppraiseEN.SuggestOne !=  "")
 {
objRow[conMicroteachAppraise.SuggestOne] = objMicroteachAppraiseEN.SuggestOne; //建议1
 }
 if (objMicroteachAppraiseEN.SuggestTwo !=  "")
 {
objRow[conMicroteachAppraise.SuggestTwo] = objMicroteachAppraiseEN.SuggestTwo; //建议2
 }
objRow[conMicroteachAppraise.MicroteachAppriseScore] = objMicroteachAppraiseEN.MicroteachAppriseScore; //打分
 if (objMicroteachAppraiseEN.VideoStopTime !=  "")
 {
objRow[conMicroteachAppraise.VideoStopTime] = objMicroteachAppraiseEN.VideoStopTime; //公开课案例视频暂停时间
 }
objRow[conMicroteachAppraise.BrowseCount] = objMicroteachAppraiseEN.BrowseCount; //浏览次数
objRow[conMicroteachAppraise.UserId] = objMicroteachAppraiseEN.UserId; //用户ID
objDS.Tables[clsMicroteachAppraiseEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsMicroteachAppraiseEN._CurrTabName);
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
 /// <param name = "objMicroteachAppraiseEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsMicroteachAppraiseEN objMicroteachAppraiseEN)
{
 if (objMicroteachAppraiseEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objMicroteachAppraiseEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objMicroteachAppraiseEN.FuncModuleId  ==  "")
 {
 objMicroteachAppraiseEN.FuncModuleId = null;
 }
 if (objMicroteachAppraiseEN.FuncModuleId !=  null)
 {
 arrFieldListForInsert.Add(conMicroteachAppraise.FuncModuleId);
 var strFuncModuleId = objMicroteachAppraiseEN.FuncModuleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncModuleId + "'");
 }
 
 if (objMicroteachAppraiseEN.IdMicroteachCase  ==  "")
 {
 objMicroteachAppraiseEN.IdMicroteachCase = null;
 }
 if (objMicroteachAppraiseEN.IdMicroteachCase !=  null)
 {
 arrFieldListForInsert.Add(conMicroteachAppraise.IdMicroteachCase);
 var strIdMicroteachCase = objMicroteachAppraiseEN.IdMicroteachCase.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdMicroteachCase + "'");
 }
 
 if (objMicroteachAppraiseEN.IdAppraiseType !=  null)
 {
 arrFieldListForInsert.Add(conMicroteachAppraise.IdAppraiseType);
 var strIdAppraiseType = objMicroteachAppraiseEN.IdAppraiseType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdAppraiseType + "'");
 }
 
 if (objMicroteachAppraiseEN.AppraiseTheme !=  null)
 {
 arrFieldListForInsert.Add(conMicroteachAppraise.AppraiseTheme);
 var strAppraiseTheme = objMicroteachAppraiseEN.AppraiseTheme.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAppraiseTheme + "'");
 }
 
 if (objMicroteachAppraiseEN.AppraiseContent !=  null)
 {
 arrFieldListForInsert.Add(conMicroteachAppraise.AppraiseContent);
 var strAppraiseContent = objMicroteachAppraiseEN.AppraiseContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAppraiseContent + "'");
 }
 
 if (objMicroteachAppraiseEN.AppraiseDate !=  null)
 {
 arrFieldListForInsert.Add(conMicroteachAppraise.AppraiseDate);
 var strAppraiseDate = objMicroteachAppraiseEN.AppraiseDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAppraiseDate + "'");
 }
 
 if (objMicroteachAppraiseEN.AppraiseTime !=  null)
 {
 arrFieldListForInsert.Add(conMicroteachAppraise.AppraiseTime);
 var strAppraiseTime = objMicroteachAppraiseEN.AppraiseTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAppraiseTime + "'");
 }
 
 arrFieldListForInsert.Add(conMicroteachAppraise.IsVisual);
 arrValueListForInsert.Add("'" + (objMicroteachAppraiseEN.IsVisual  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conMicroteachAppraise.IsElite);
 arrValueListForInsert.Add("'" + (objMicroteachAppraiseEN.IsElite  ==  false ? "0" : "1") + "'");
 
 if (objMicroteachAppraiseEN.ExcellentOne !=  null)
 {
 arrFieldListForInsert.Add(conMicroteachAppraise.ExcellentOne);
 var strExcellentOne = objMicroteachAppraiseEN.ExcellentOne.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strExcellentOne + "'");
 }
 
 if (objMicroteachAppraiseEN.ExcellentTwo !=  null)
 {
 arrFieldListForInsert.Add(conMicroteachAppraise.ExcellentTwo);
 var strExcellentTwo = objMicroteachAppraiseEN.ExcellentTwo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strExcellentTwo + "'");
 }
 
 if (objMicroteachAppraiseEN.SuggestOne !=  null)
 {
 arrFieldListForInsert.Add(conMicroteachAppraise.SuggestOne);
 var strSuggestOne = objMicroteachAppraiseEN.SuggestOne.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSuggestOne + "'");
 }
 
 if (objMicroteachAppraiseEN.SuggestTwo !=  null)
 {
 arrFieldListForInsert.Add(conMicroteachAppraise.SuggestTwo);
 var strSuggestTwo = objMicroteachAppraiseEN.SuggestTwo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSuggestTwo + "'");
 }
 
 if (objMicroteachAppraiseEN.MicroteachAppriseScore !=  null)
 {
 arrFieldListForInsert.Add(conMicroteachAppraise.MicroteachAppriseScore);
 arrValueListForInsert.Add(objMicroteachAppraiseEN.MicroteachAppriseScore.ToString());
 }
 
 if (objMicroteachAppraiseEN.VideoStopTime !=  null)
 {
 arrFieldListForInsert.Add(conMicroteachAppraise.VideoStopTime);
 var strVideoStopTime = objMicroteachAppraiseEN.VideoStopTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVideoStopTime + "'");
 }
 
 if (objMicroteachAppraiseEN.BrowseCount !=  null)
 {
 arrFieldListForInsert.Add(conMicroteachAppraise.BrowseCount);
 arrValueListForInsert.Add(objMicroteachAppraiseEN.BrowseCount.ToString());
 }
 
 if (objMicroteachAppraiseEN.UserId !=  null)
 {
 arrFieldListForInsert.Add(conMicroteachAppraise.UserId);
 var strUserId = objMicroteachAppraiseEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserId + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into MicroteachAppraise");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsMicroteachAppraiseDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objMicroteachAppraiseEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsMicroteachAppraiseEN objMicroteachAppraiseEN)
{
 if (objMicroteachAppraiseEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objMicroteachAppraiseEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objMicroteachAppraiseEN.FuncModuleId  ==  "")
 {
 objMicroteachAppraiseEN.FuncModuleId = null;
 }
 if (objMicroteachAppraiseEN.FuncModuleId !=  null)
 {
 arrFieldListForInsert.Add(conMicroteachAppraise.FuncModuleId);
 var strFuncModuleId = objMicroteachAppraiseEN.FuncModuleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncModuleId + "'");
 }
 
 if (objMicroteachAppraiseEN.IdMicroteachCase  ==  "")
 {
 objMicroteachAppraiseEN.IdMicroteachCase = null;
 }
 if (objMicroteachAppraiseEN.IdMicroteachCase !=  null)
 {
 arrFieldListForInsert.Add(conMicroteachAppraise.IdMicroteachCase);
 var strIdMicroteachCase = objMicroteachAppraiseEN.IdMicroteachCase.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdMicroteachCase + "'");
 }
 
 if (objMicroteachAppraiseEN.IdAppraiseType !=  null)
 {
 arrFieldListForInsert.Add(conMicroteachAppraise.IdAppraiseType);
 var strIdAppraiseType = objMicroteachAppraiseEN.IdAppraiseType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdAppraiseType + "'");
 }
 
 if (objMicroteachAppraiseEN.AppraiseTheme !=  null)
 {
 arrFieldListForInsert.Add(conMicroteachAppraise.AppraiseTheme);
 var strAppraiseTheme = objMicroteachAppraiseEN.AppraiseTheme.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAppraiseTheme + "'");
 }
 
 if (objMicroteachAppraiseEN.AppraiseContent !=  null)
 {
 arrFieldListForInsert.Add(conMicroteachAppraise.AppraiseContent);
 var strAppraiseContent = objMicroteachAppraiseEN.AppraiseContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAppraiseContent + "'");
 }
 
 if (objMicroteachAppraiseEN.AppraiseDate !=  null)
 {
 arrFieldListForInsert.Add(conMicroteachAppraise.AppraiseDate);
 var strAppraiseDate = objMicroteachAppraiseEN.AppraiseDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAppraiseDate + "'");
 }
 
 if (objMicroteachAppraiseEN.AppraiseTime !=  null)
 {
 arrFieldListForInsert.Add(conMicroteachAppraise.AppraiseTime);
 var strAppraiseTime = objMicroteachAppraiseEN.AppraiseTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAppraiseTime + "'");
 }
 
 arrFieldListForInsert.Add(conMicroteachAppraise.IsVisual);
 arrValueListForInsert.Add("'" + (objMicroteachAppraiseEN.IsVisual  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conMicroteachAppraise.IsElite);
 arrValueListForInsert.Add("'" + (objMicroteachAppraiseEN.IsElite  ==  false ? "0" : "1") + "'");
 
 if (objMicroteachAppraiseEN.ExcellentOne !=  null)
 {
 arrFieldListForInsert.Add(conMicroteachAppraise.ExcellentOne);
 var strExcellentOne = objMicroteachAppraiseEN.ExcellentOne.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strExcellentOne + "'");
 }
 
 if (objMicroteachAppraiseEN.ExcellentTwo !=  null)
 {
 arrFieldListForInsert.Add(conMicroteachAppraise.ExcellentTwo);
 var strExcellentTwo = objMicroteachAppraiseEN.ExcellentTwo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strExcellentTwo + "'");
 }
 
 if (objMicroteachAppraiseEN.SuggestOne !=  null)
 {
 arrFieldListForInsert.Add(conMicroteachAppraise.SuggestOne);
 var strSuggestOne = objMicroteachAppraiseEN.SuggestOne.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSuggestOne + "'");
 }
 
 if (objMicroteachAppraiseEN.SuggestTwo !=  null)
 {
 arrFieldListForInsert.Add(conMicroteachAppraise.SuggestTwo);
 var strSuggestTwo = objMicroteachAppraiseEN.SuggestTwo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSuggestTwo + "'");
 }
 
 if (objMicroteachAppraiseEN.MicroteachAppriseScore !=  null)
 {
 arrFieldListForInsert.Add(conMicroteachAppraise.MicroteachAppriseScore);
 arrValueListForInsert.Add(objMicroteachAppraiseEN.MicroteachAppriseScore.ToString());
 }
 
 if (objMicroteachAppraiseEN.VideoStopTime !=  null)
 {
 arrFieldListForInsert.Add(conMicroteachAppraise.VideoStopTime);
 var strVideoStopTime = objMicroteachAppraiseEN.VideoStopTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVideoStopTime + "'");
 }
 
 if (objMicroteachAppraiseEN.BrowseCount !=  null)
 {
 arrFieldListForInsert.Add(conMicroteachAppraise.BrowseCount);
 arrValueListForInsert.Add(objMicroteachAppraiseEN.BrowseCount.ToString());
 }
 
 if (objMicroteachAppraiseEN.UserId !=  null)
 {
 arrFieldListForInsert.Add(conMicroteachAppraise.UserId);
 var strUserId = objMicroteachAppraiseEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserId + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into MicroteachAppraise");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsMicroteachAppraiseDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString()).Rows[0][0].ToString();
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objMicroteachAppraiseEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsMicroteachAppraiseEN objMicroteachAppraiseEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objMicroteachAppraiseEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objMicroteachAppraiseEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objMicroteachAppraiseEN.FuncModuleId  ==  "")
 {
 objMicroteachAppraiseEN.FuncModuleId = null;
 }
 if (objMicroteachAppraiseEN.FuncModuleId !=  null)
 {
 arrFieldListForInsert.Add(conMicroteachAppraise.FuncModuleId);
 var strFuncModuleId = objMicroteachAppraiseEN.FuncModuleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncModuleId + "'");
 }
 
 if (objMicroteachAppraiseEN.IdMicroteachCase  ==  "")
 {
 objMicroteachAppraiseEN.IdMicroteachCase = null;
 }
 if (objMicroteachAppraiseEN.IdMicroteachCase !=  null)
 {
 arrFieldListForInsert.Add(conMicroteachAppraise.IdMicroteachCase);
 var strIdMicroteachCase = objMicroteachAppraiseEN.IdMicroteachCase.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdMicroteachCase + "'");
 }
 
 if (objMicroteachAppraiseEN.IdAppraiseType !=  null)
 {
 arrFieldListForInsert.Add(conMicroteachAppraise.IdAppraiseType);
 var strIdAppraiseType = objMicroteachAppraiseEN.IdAppraiseType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdAppraiseType + "'");
 }
 
 if (objMicroteachAppraiseEN.AppraiseTheme !=  null)
 {
 arrFieldListForInsert.Add(conMicroteachAppraise.AppraiseTheme);
 var strAppraiseTheme = objMicroteachAppraiseEN.AppraiseTheme.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAppraiseTheme + "'");
 }
 
 if (objMicroteachAppraiseEN.AppraiseContent !=  null)
 {
 arrFieldListForInsert.Add(conMicroteachAppraise.AppraiseContent);
 var strAppraiseContent = objMicroteachAppraiseEN.AppraiseContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAppraiseContent + "'");
 }
 
 if (objMicroteachAppraiseEN.AppraiseDate !=  null)
 {
 arrFieldListForInsert.Add(conMicroteachAppraise.AppraiseDate);
 var strAppraiseDate = objMicroteachAppraiseEN.AppraiseDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAppraiseDate + "'");
 }
 
 if (objMicroteachAppraiseEN.AppraiseTime !=  null)
 {
 arrFieldListForInsert.Add(conMicroteachAppraise.AppraiseTime);
 var strAppraiseTime = objMicroteachAppraiseEN.AppraiseTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAppraiseTime + "'");
 }
 
 arrFieldListForInsert.Add(conMicroteachAppraise.IsVisual);
 arrValueListForInsert.Add("'" + (objMicroteachAppraiseEN.IsVisual  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conMicroteachAppraise.IsElite);
 arrValueListForInsert.Add("'" + (objMicroteachAppraiseEN.IsElite  ==  false ? "0" : "1") + "'");
 
 if (objMicroteachAppraiseEN.ExcellentOne !=  null)
 {
 arrFieldListForInsert.Add(conMicroteachAppraise.ExcellentOne);
 var strExcellentOne = objMicroteachAppraiseEN.ExcellentOne.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strExcellentOne + "'");
 }
 
 if (objMicroteachAppraiseEN.ExcellentTwo !=  null)
 {
 arrFieldListForInsert.Add(conMicroteachAppraise.ExcellentTwo);
 var strExcellentTwo = objMicroteachAppraiseEN.ExcellentTwo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strExcellentTwo + "'");
 }
 
 if (objMicroteachAppraiseEN.SuggestOne !=  null)
 {
 arrFieldListForInsert.Add(conMicroteachAppraise.SuggestOne);
 var strSuggestOne = objMicroteachAppraiseEN.SuggestOne.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSuggestOne + "'");
 }
 
 if (objMicroteachAppraiseEN.SuggestTwo !=  null)
 {
 arrFieldListForInsert.Add(conMicroteachAppraise.SuggestTwo);
 var strSuggestTwo = objMicroteachAppraiseEN.SuggestTwo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSuggestTwo + "'");
 }
 
 if (objMicroteachAppraiseEN.MicroteachAppriseScore !=  null)
 {
 arrFieldListForInsert.Add(conMicroteachAppraise.MicroteachAppriseScore);
 arrValueListForInsert.Add(objMicroteachAppraiseEN.MicroteachAppriseScore.ToString());
 }
 
 if (objMicroteachAppraiseEN.VideoStopTime !=  null)
 {
 arrFieldListForInsert.Add(conMicroteachAppraise.VideoStopTime);
 var strVideoStopTime = objMicroteachAppraiseEN.VideoStopTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVideoStopTime + "'");
 }
 
 if (objMicroteachAppraiseEN.BrowseCount !=  null)
 {
 arrFieldListForInsert.Add(conMicroteachAppraise.BrowseCount);
 arrValueListForInsert.Add(objMicroteachAppraiseEN.BrowseCount.ToString());
 }
 
 if (objMicroteachAppraiseEN.UserId !=  null)
 {
 arrFieldListForInsert.Add(conMicroteachAppraise.UserId);
 var strUserId = objMicroteachAppraiseEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserId + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into MicroteachAppraise");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsMicroteachAppraiseDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString(), objSqlConnection, objSqlTransaction).Rows[0][0].ToString();
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objMicroteachAppraiseEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsMicroteachAppraiseEN objMicroteachAppraiseEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objMicroteachAppraiseEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objMicroteachAppraiseEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objMicroteachAppraiseEN.FuncModuleId  ==  "")
 {
 objMicroteachAppraiseEN.FuncModuleId = null;
 }
 if (objMicroteachAppraiseEN.FuncModuleId !=  null)
 {
 arrFieldListForInsert.Add(conMicroteachAppraise.FuncModuleId);
 var strFuncModuleId = objMicroteachAppraiseEN.FuncModuleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncModuleId + "'");
 }
 
 if (objMicroteachAppraiseEN.IdMicroteachCase  ==  "")
 {
 objMicroteachAppraiseEN.IdMicroteachCase = null;
 }
 if (objMicroteachAppraiseEN.IdMicroteachCase !=  null)
 {
 arrFieldListForInsert.Add(conMicroteachAppraise.IdMicroteachCase);
 var strIdMicroteachCase = objMicroteachAppraiseEN.IdMicroteachCase.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdMicroteachCase + "'");
 }
 
 if (objMicroteachAppraiseEN.IdAppraiseType !=  null)
 {
 arrFieldListForInsert.Add(conMicroteachAppraise.IdAppraiseType);
 var strIdAppraiseType = objMicroteachAppraiseEN.IdAppraiseType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdAppraiseType + "'");
 }
 
 if (objMicroteachAppraiseEN.AppraiseTheme !=  null)
 {
 arrFieldListForInsert.Add(conMicroteachAppraise.AppraiseTheme);
 var strAppraiseTheme = objMicroteachAppraiseEN.AppraiseTheme.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAppraiseTheme + "'");
 }
 
 if (objMicroteachAppraiseEN.AppraiseContent !=  null)
 {
 arrFieldListForInsert.Add(conMicroteachAppraise.AppraiseContent);
 var strAppraiseContent = objMicroteachAppraiseEN.AppraiseContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAppraiseContent + "'");
 }
 
 if (objMicroteachAppraiseEN.AppraiseDate !=  null)
 {
 arrFieldListForInsert.Add(conMicroteachAppraise.AppraiseDate);
 var strAppraiseDate = objMicroteachAppraiseEN.AppraiseDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAppraiseDate + "'");
 }
 
 if (objMicroteachAppraiseEN.AppraiseTime !=  null)
 {
 arrFieldListForInsert.Add(conMicroteachAppraise.AppraiseTime);
 var strAppraiseTime = objMicroteachAppraiseEN.AppraiseTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAppraiseTime + "'");
 }
 
 arrFieldListForInsert.Add(conMicroteachAppraise.IsVisual);
 arrValueListForInsert.Add("'" + (objMicroteachAppraiseEN.IsVisual  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conMicroteachAppraise.IsElite);
 arrValueListForInsert.Add("'" + (objMicroteachAppraiseEN.IsElite  ==  false ? "0" : "1") + "'");
 
 if (objMicroteachAppraiseEN.ExcellentOne !=  null)
 {
 arrFieldListForInsert.Add(conMicroteachAppraise.ExcellentOne);
 var strExcellentOne = objMicroteachAppraiseEN.ExcellentOne.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strExcellentOne + "'");
 }
 
 if (objMicroteachAppraiseEN.ExcellentTwo !=  null)
 {
 arrFieldListForInsert.Add(conMicroteachAppraise.ExcellentTwo);
 var strExcellentTwo = objMicroteachAppraiseEN.ExcellentTwo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strExcellentTwo + "'");
 }
 
 if (objMicroteachAppraiseEN.SuggestOne !=  null)
 {
 arrFieldListForInsert.Add(conMicroteachAppraise.SuggestOne);
 var strSuggestOne = objMicroteachAppraiseEN.SuggestOne.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSuggestOne + "'");
 }
 
 if (objMicroteachAppraiseEN.SuggestTwo !=  null)
 {
 arrFieldListForInsert.Add(conMicroteachAppraise.SuggestTwo);
 var strSuggestTwo = objMicroteachAppraiseEN.SuggestTwo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSuggestTwo + "'");
 }
 
 if (objMicroteachAppraiseEN.MicroteachAppriseScore !=  null)
 {
 arrFieldListForInsert.Add(conMicroteachAppraise.MicroteachAppriseScore);
 arrValueListForInsert.Add(objMicroteachAppraiseEN.MicroteachAppriseScore.ToString());
 }
 
 if (objMicroteachAppraiseEN.VideoStopTime !=  null)
 {
 arrFieldListForInsert.Add(conMicroteachAppraise.VideoStopTime);
 var strVideoStopTime = objMicroteachAppraiseEN.VideoStopTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVideoStopTime + "'");
 }
 
 if (objMicroteachAppraiseEN.BrowseCount !=  null)
 {
 arrFieldListForInsert.Add(conMicroteachAppraise.BrowseCount);
 arrValueListForInsert.Add(objMicroteachAppraiseEN.BrowseCount.ToString());
 }
 
 if (objMicroteachAppraiseEN.UserId !=  null)
 {
 arrFieldListForInsert.Add(conMicroteachAppraise.UserId);
 var strUserId = objMicroteachAppraiseEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserId + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into MicroteachAppraise");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsMicroteachAppraiseDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewMicroteachAppraises(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsMicroteachAppraiseDA.GetSpecSQLObj();
strSQL = "Select * from MicroteachAppraise where IdMicroteachAppraise = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "MicroteachAppraise");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
long lngIdMicroteachAppraise = TransNullToInt(oRow[conMicroteachAppraise.IdMicroteachAppraise].ToString().Trim());
if (IsExist(lngIdMicroteachAppraise))
{
 string strResult = "关键字变量值为:" + string.Format("IdMicroteachAppraise = {0}", lngIdMicroteachAppraise) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsMicroteachAppraiseEN._CurrTabName ].NewRow();
objRow[conMicroteachAppraise.FuncModuleId] = oRow[conMicroteachAppraise.FuncModuleId].ToString().Trim(); //功能模块Id
objRow[conMicroteachAppraise.IdMicroteachCase] = oRow[conMicroteachAppraise.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objRow[conMicroteachAppraise.IdAppraiseType] = oRow[conMicroteachAppraise.IdAppraiseType].ToString().Trim(); //评议类型流水号
objRow[conMicroteachAppraise.AppraiseTheme] = oRow[conMicroteachAppraise.AppraiseTheme].ToString().Trim(); //评议主题
objRow[conMicroteachAppraise.AppraiseContent] = oRow[conMicroteachAppraise.AppraiseContent].ToString().Trim(); //评议内容
objRow[conMicroteachAppraise.AppraiseDate] = oRow[conMicroteachAppraise.AppraiseDate].ToString().Trim(); //评议日期
objRow[conMicroteachAppraise.AppraiseTime] = oRow[conMicroteachAppraise.AppraiseTime].ToString().Trim(); //评议时间
objRow[conMicroteachAppraise.IsVisual] = oRow[conMicroteachAppraise.IsVisual].ToString().Trim(); //隐藏标志
objRow[conMicroteachAppraise.IsElite] = oRow[conMicroteachAppraise.IsElite].ToString().Trim(); //精华标志
objRow[conMicroteachAppraise.ExcellentOne] = oRow[conMicroteachAppraise.ExcellentOne].ToString().Trim(); //优点1
objRow[conMicroteachAppraise.ExcellentTwo] = oRow[conMicroteachAppraise.ExcellentTwo].ToString().Trim(); //优点2
objRow[conMicroteachAppraise.SuggestOne] = oRow[conMicroteachAppraise.SuggestOne].ToString().Trim(); //建议1
objRow[conMicroteachAppraise.SuggestTwo] = oRow[conMicroteachAppraise.SuggestTwo].ToString().Trim(); //建议2
objRow[conMicroteachAppraise.MicroteachAppriseScore] = oRow[conMicroteachAppraise.MicroteachAppriseScore].ToString().Trim(); //打分
objRow[conMicroteachAppraise.VideoStopTime] = oRow[conMicroteachAppraise.VideoStopTime].ToString().Trim(); //公开课案例视频暂停时间
objRow[conMicroteachAppraise.BrowseCount] = oRow[conMicroteachAppraise.BrowseCount].ToString().Trim(); //浏览次数
objRow[conMicroteachAppraise.UserId] = oRow[conMicroteachAppraise.UserId].ToString().Trim(); //用户ID
 objDS.Tables[clsMicroteachAppraiseEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsMicroteachAppraiseEN._CurrTabName);
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
 /// <param name = "objMicroteachAppraiseEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsMicroteachAppraiseEN objMicroteachAppraiseEN)
{
 if (objMicroteachAppraiseEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objMicroteachAppraiseEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsMicroteachAppraiseDA.GetSpecSQLObj();
strSQL = "Select * from MicroteachAppraise where IdMicroteachAppraise = " + ""+ objMicroteachAppraiseEN.IdMicroteachAppraise+"";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsMicroteachAppraiseEN._CurrTabName);
if (objDS.Tables[clsMicroteachAppraiseEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:IdMicroteachAppraise = " + ""+ objMicroteachAppraiseEN.IdMicroteachAppraise+"");
return false;
}
objRow = objDS.Tables[clsMicroteachAppraiseEN._CurrTabName].Rows[0];
 if (objMicroteachAppraiseEN.IsUpdated(conMicroteachAppraise.FuncModuleId))
 {
objRow[conMicroteachAppraise.FuncModuleId] = objMicroteachAppraiseEN.FuncModuleId; //功能模块Id
 }
 if (objMicroteachAppraiseEN.IsUpdated(conMicroteachAppraise.IdMicroteachCase))
 {
objRow[conMicroteachAppraise.IdMicroteachCase] = objMicroteachAppraiseEN.IdMicroteachCase; //微格教学案例流水号
 }
 if (objMicroteachAppraiseEN.IsUpdated(conMicroteachAppraise.IdAppraiseType))
 {
objRow[conMicroteachAppraise.IdAppraiseType] = objMicroteachAppraiseEN.IdAppraiseType; //评议类型流水号
 }
 if (objMicroteachAppraiseEN.IsUpdated(conMicroteachAppraise.AppraiseTheme))
 {
objRow[conMicroteachAppraise.AppraiseTheme] = objMicroteachAppraiseEN.AppraiseTheme; //评议主题
 }
 if (objMicroteachAppraiseEN.IsUpdated(conMicroteachAppraise.AppraiseContent))
 {
objRow[conMicroteachAppraise.AppraiseContent] = objMicroteachAppraiseEN.AppraiseContent; //评议内容
 }
 if (objMicroteachAppraiseEN.IsUpdated(conMicroteachAppraise.AppraiseDate))
 {
objRow[conMicroteachAppraise.AppraiseDate] = objMicroteachAppraiseEN.AppraiseDate; //评议日期
 }
 if (objMicroteachAppraiseEN.IsUpdated(conMicroteachAppraise.AppraiseTime))
 {
objRow[conMicroteachAppraise.AppraiseTime] = objMicroteachAppraiseEN.AppraiseTime; //评议时间
 }
 if (objMicroteachAppraiseEN.IsUpdated(conMicroteachAppraise.IsVisual))
 {
objRow[conMicroteachAppraise.IsVisual] = objMicroteachAppraiseEN.IsVisual; //隐藏标志
 }
 if (objMicroteachAppraiseEN.IsUpdated(conMicroteachAppraise.IsElite))
 {
objRow[conMicroteachAppraise.IsElite] = objMicroteachAppraiseEN.IsElite; //精华标志
 }
 if (objMicroteachAppraiseEN.IsUpdated(conMicroteachAppraise.ExcellentOne))
 {
objRow[conMicroteachAppraise.ExcellentOne] = objMicroteachAppraiseEN.ExcellentOne; //优点1
 }
 if (objMicroteachAppraiseEN.IsUpdated(conMicroteachAppraise.ExcellentTwo))
 {
objRow[conMicroteachAppraise.ExcellentTwo] = objMicroteachAppraiseEN.ExcellentTwo; //优点2
 }
 if (objMicroteachAppraiseEN.IsUpdated(conMicroteachAppraise.SuggestOne))
 {
objRow[conMicroteachAppraise.SuggestOne] = objMicroteachAppraiseEN.SuggestOne; //建议1
 }
 if (objMicroteachAppraiseEN.IsUpdated(conMicroteachAppraise.SuggestTwo))
 {
objRow[conMicroteachAppraise.SuggestTwo] = objMicroteachAppraiseEN.SuggestTwo; //建议2
 }
 if (objMicroteachAppraiseEN.IsUpdated(conMicroteachAppraise.MicroteachAppriseScore))
 {
objRow[conMicroteachAppraise.MicroteachAppriseScore] = objMicroteachAppraiseEN.MicroteachAppriseScore; //打分
 }
 if (objMicroteachAppraiseEN.IsUpdated(conMicroteachAppraise.VideoStopTime))
 {
objRow[conMicroteachAppraise.VideoStopTime] = objMicroteachAppraiseEN.VideoStopTime; //公开课案例视频暂停时间
 }
 if (objMicroteachAppraiseEN.IsUpdated(conMicroteachAppraise.BrowseCount))
 {
objRow[conMicroteachAppraise.BrowseCount] = objMicroteachAppraiseEN.BrowseCount; //浏览次数
 }
 if (objMicroteachAppraiseEN.IsUpdated(conMicroteachAppraise.UserId))
 {
objRow[conMicroteachAppraise.UserId] = objMicroteachAppraiseEN.UserId; //用户ID
 }
try
{
objDA.Update(objDS, clsMicroteachAppraiseEN._CurrTabName);
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
 /// <param name = "objMicroteachAppraiseEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsMicroteachAppraiseEN objMicroteachAppraiseEN)
{
 if (objMicroteachAppraiseEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objMicroteachAppraiseEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsMicroteachAppraiseDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update MicroteachAppraise Set ");
 
 if (objMicroteachAppraiseEN.IsUpdated(conMicroteachAppraise.FuncModuleId))
 {
 if (objMicroteachAppraiseEN.FuncModuleId  ==  "")
 {
 objMicroteachAppraiseEN.FuncModuleId = null;
 }
 if (objMicroteachAppraiseEN.FuncModuleId !=  null)
 {
 var strFuncModuleId = objMicroteachAppraiseEN.FuncModuleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFuncModuleId, conMicroteachAppraise.FuncModuleId); //功能模块Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conMicroteachAppraise.FuncModuleId); //功能模块Id
 }
 }
 
 if (objMicroteachAppraiseEN.IsUpdated(conMicroteachAppraise.IdMicroteachCase))
 {
 if (objMicroteachAppraiseEN.IdMicroteachCase  ==  "")
 {
 objMicroteachAppraiseEN.IdMicroteachCase = null;
 }
 if (objMicroteachAppraiseEN.IdMicroteachCase !=  null)
 {
 var strIdMicroteachCase = objMicroteachAppraiseEN.IdMicroteachCase.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdMicroteachCase, conMicroteachAppraise.IdMicroteachCase); //微格教学案例流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conMicroteachAppraise.IdMicroteachCase); //微格教学案例流水号
 }
 }
 
 if (objMicroteachAppraiseEN.IsUpdated(conMicroteachAppraise.IdAppraiseType))
 {
 if (objMicroteachAppraiseEN.IdAppraiseType !=  null)
 {
 var strIdAppraiseType = objMicroteachAppraiseEN.IdAppraiseType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdAppraiseType, conMicroteachAppraise.IdAppraiseType); //评议类型流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conMicroteachAppraise.IdAppraiseType); //评议类型流水号
 }
 }
 
 if (objMicroteachAppraiseEN.IsUpdated(conMicroteachAppraise.AppraiseTheme))
 {
 if (objMicroteachAppraiseEN.AppraiseTheme !=  null)
 {
 var strAppraiseTheme = objMicroteachAppraiseEN.AppraiseTheme.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strAppraiseTheme, conMicroteachAppraise.AppraiseTheme); //评议主题
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conMicroteachAppraise.AppraiseTheme); //评议主题
 }
 }
 
 if (objMicroteachAppraiseEN.IsUpdated(conMicroteachAppraise.AppraiseContent))
 {
 if (objMicroteachAppraiseEN.AppraiseContent !=  null)
 {
 var strAppraiseContent = objMicroteachAppraiseEN.AppraiseContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strAppraiseContent, conMicroteachAppraise.AppraiseContent); //评议内容
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conMicroteachAppraise.AppraiseContent); //评议内容
 }
 }
 
 if (objMicroteachAppraiseEN.IsUpdated(conMicroteachAppraise.AppraiseDate))
 {
 if (objMicroteachAppraiseEN.AppraiseDate !=  null)
 {
 var strAppraiseDate = objMicroteachAppraiseEN.AppraiseDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strAppraiseDate, conMicroteachAppraise.AppraiseDate); //评议日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conMicroteachAppraise.AppraiseDate); //评议日期
 }
 }
 
 if (objMicroteachAppraiseEN.IsUpdated(conMicroteachAppraise.AppraiseTime))
 {
 if (objMicroteachAppraiseEN.AppraiseTime !=  null)
 {
 var strAppraiseTime = objMicroteachAppraiseEN.AppraiseTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strAppraiseTime, conMicroteachAppraise.AppraiseTime); //评议时间
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conMicroteachAppraise.AppraiseTime); //评议时间
 }
 }
 
 if (objMicroteachAppraiseEN.IsUpdated(conMicroteachAppraise.IsVisual))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objMicroteachAppraiseEN.IsVisual == true?"1":"0", conMicroteachAppraise.IsVisual); //隐藏标志
 }
 
 if (objMicroteachAppraiseEN.IsUpdated(conMicroteachAppraise.IsElite))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objMicroteachAppraiseEN.IsElite == true?"1":"0", conMicroteachAppraise.IsElite); //精华标志
 }
 
 if (objMicroteachAppraiseEN.IsUpdated(conMicroteachAppraise.ExcellentOne))
 {
 if (objMicroteachAppraiseEN.ExcellentOne !=  null)
 {
 var strExcellentOne = objMicroteachAppraiseEN.ExcellentOne.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strExcellentOne, conMicroteachAppraise.ExcellentOne); //优点1
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conMicroteachAppraise.ExcellentOne); //优点1
 }
 }
 
 if (objMicroteachAppraiseEN.IsUpdated(conMicroteachAppraise.ExcellentTwo))
 {
 if (objMicroteachAppraiseEN.ExcellentTwo !=  null)
 {
 var strExcellentTwo = objMicroteachAppraiseEN.ExcellentTwo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strExcellentTwo, conMicroteachAppraise.ExcellentTwo); //优点2
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conMicroteachAppraise.ExcellentTwo); //优点2
 }
 }
 
 if (objMicroteachAppraiseEN.IsUpdated(conMicroteachAppraise.SuggestOne))
 {
 if (objMicroteachAppraiseEN.SuggestOne !=  null)
 {
 var strSuggestOne = objMicroteachAppraiseEN.SuggestOne.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSuggestOne, conMicroteachAppraise.SuggestOne); //建议1
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conMicroteachAppraise.SuggestOne); //建议1
 }
 }
 
 if (objMicroteachAppraiseEN.IsUpdated(conMicroteachAppraise.SuggestTwo))
 {
 if (objMicroteachAppraiseEN.SuggestTwo !=  null)
 {
 var strSuggestTwo = objMicroteachAppraiseEN.SuggestTwo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSuggestTwo, conMicroteachAppraise.SuggestTwo); //建议2
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conMicroteachAppraise.SuggestTwo); //建议2
 }
 }
 
 if (objMicroteachAppraiseEN.IsUpdated(conMicroteachAppraise.MicroteachAppriseScore))
 {
 if (objMicroteachAppraiseEN.MicroteachAppriseScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objMicroteachAppraiseEN.MicroteachAppriseScore, conMicroteachAppraise.MicroteachAppriseScore); //打分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conMicroteachAppraise.MicroteachAppriseScore); //打分
 }
 }
 
 if (objMicroteachAppraiseEN.IsUpdated(conMicroteachAppraise.VideoStopTime))
 {
 if (objMicroteachAppraiseEN.VideoStopTime !=  null)
 {
 var strVideoStopTime = objMicroteachAppraiseEN.VideoStopTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strVideoStopTime, conMicroteachAppraise.VideoStopTime); //公开课案例视频暂停时间
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conMicroteachAppraise.VideoStopTime); //公开课案例视频暂停时间
 }
 }
 
 if (objMicroteachAppraiseEN.IsUpdated(conMicroteachAppraise.BrowseCount))
 {
 if (objMicroteachAppraiseEN.BrowseCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objMicroteachAppraiseEN.BrowseCount, conMicroteachAppraise.BrowseCount); //浏览次数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conMicroteachAppraise.BrowseCount); //浏览次数
 }
 }
 
 if (objMicroteachAppraiseEN.IsUpdated(conMicroteachAppraise.UserId))
 {
 if (objMicroteachAppraiseEN.UserId !=  null)
 {
 var strUserId = objMicroteachAppraiseEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUserId, conMicroteachAppraise.UserId); //用户ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conMicroteachAppraise.UserId); //用户ID
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where IdMicroteachAppraise = {0}", objMicroteachAppraiseEN.IdMicroteachAppraise); 
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
 /// <param name = "objMicroteachAppraiseEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsMicroteachAppraiseEN objMicroteachAppraiseEN, string strCondition)
{
 if (objMicroteachAppraiseEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objMicroteachAppraiseEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsMicroteachAppraiseDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update MicroteachAppraise Set ");
 
 if (objMicroteachAppraiseEN.IsUpdated(conMicroteachAppraise.FuncModuleId))
 {
 if (objMicroteachAppraiseEN.FuncModuleId  ==  "")
 {
 objMicroteachAppraiseEN.FuncModuleId = null;
 }
 if (objMicroteachAppraiseEN.FuncModuleId !=  null)
 {
 var strFuncModuleId = objMicroteachAppraiseEN.FuncModuleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FuncModuleId = '{0}',", strFuncModuleId); //功能模块Id
 }
 else
 {
 sbSQL.Append(" FuncModuleId = null,"); //功能模块Id
 }
 }
 
 if (objMicroteachAppraiseEN.IsUpdated(conMicroteachAppraise.IdMicroteachCase))
 {
 if (objMicroteachAppraiseEN.IdMicroteachCase  ==  "")
 {
 objMicroteachAppraiseEN.IdMicroteachCase = null;
 }
 if (objMicroteachAppraiseEN.IdMicroteachCase !=  null)
 {
 var strIdMicroteachCase = objMicroteachAppraiseEN.IdMicroteachCase.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdMicroteachCase = '{0}',", strIdMicroteachCase); //微格教学案例流水号
 }
 else
 {
 sbSQL.Append(" IdMicroteachCase = null,"); //微格教学案例流水号
 }
 }
 
 if (objMicroteachAppraiseEN.IsUpdated(conMicroteachAppraise.IdAppraiseType))
 {
 if (objMicroteachAppraiseEN.IdAppraiseType !=  null)
 {
 var strIdAppraiseType = objMicroteachAppraiseEN.IdAppraiseType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdAppraiseType = '{0}',", strIdAppraiseType); //评议类型流水号
 }
 else
 {
 sbSQL.Append(" IdAppraiseType = null,"); //评议类型流水号
 }
 }
 
 if (objMicroteachAppraiseEN.IsUpdated(conMicroteachAppraise.AppraiseTheme))
 {
 if (objMicroteachAppraiseEN.AppraiseTheme !=  null)
 {
 var strAppraiseTheme = objMicroteachAppraiseEN.AppraiseTheme.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" AppraiseTheme = '{0}',", strAppraiseTheme); //评议主题
 }
 else
 {
 sbSQL.Append(" AppraiseTheme = null,"); //评议主题
 }
 }
 
 if (objMicroteachAppraiseEN.IsUpdated(conMicroteachAppraise.AppraiseContent))
 {
 if (objMicroteachAppraiseEN.AppraiseContent !=  null)
 {
 var strAppraiseContent = objMicroteachAppraiseEN.AppraiseContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" AppraiseContent = '{0}',", strAppraiseContent); //评议内容
 }
 else
 {
 sbSQL.Append(" AppraiseContent = null,"); //评议内容
 }
 }
 
 if (objMicroteachAppraiseEN.IsUpdated(conMicroteachAppraise.AppraiseDate))
 {
 if (objMicroteachAppraiseEN.AppraiseDate !=  null)
 {
 var strAppraiseDate = objMicroteachAppraiseEN.AppraiseDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" AppraiseDate = '{0}',", strAppraiseDate); //评议日期
 }
 else
 {
 sbSQL.Append(" AppraiseDate = null,"); //评议日期
 }
 }
 
 if (objMicroteachAppraiseEN.IsUpdated(conMicroteachAppraise.AppraiseTime))
 {
 if (objMicroteachAppraiseEN.AppraiseTime !=  null)
 {
 var strAppraiseTime = objMicroteachAppraiseEN.AppraiseTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" AppraiseTime = '{0}',", strAppraiseTime); //评议时间
 }
 else
 {
 sbSQL.Append(" AppraiseTime = null,"); //评议时间
 }
 }
 
 if (objMicroteachAppraiseEN.IsUpdated(conMicroteachAppraise.IsVisual))
 {
 sbSQL.AppendFormat(" IsVisual = '{0}',", objMicroteachAppraiseEN.IsVisual == true?"1":"0"); //隐藏标志
 }
 
 if (objMicroteachAppraiseEN.IsUpdated(conMicroteachAppraise.IsElite))
 {
 sbSQL.AppendFormat(" IsElite = '{0}',", objMicroteachAppraiseEN.IsElite == true?"1":"0"); //精华标志
 }
 
 if (objMicroteachAppraiseEN.IsUpdated(conMicroteachAppraise.ExcellentOne))
 {
 if (objMicroteachAppraiseEN.ExcellentOne !=  null)
 {
 var strExcellentOne = objMicroteachAppraiseEN.ExcellentOne.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ExcellentOne = '{0}',", strExcellentOne); //优点1
 }
 else
 {
 sbSQL.Append(" ExcellentOne = null,"); //优点1
 }
 }
 
 if (objMicroteachAppraiseEN.IsUpdated(conMicroteachAppraise.ExcellentTwo))
 {
 if (objMicroteachAppraiseEN.ExcellentTwo !=  null)
 {
 var strExcellentTwo = objMicroteachAppraiseEN.ExcellentTwo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ExcellentTwo = '{0}',", strExcellentTwo); //优点2
 }
 else
 {
 sbSQL.Append(" ExcellentTwo = null,"); //优点2
 }
 }
 
 if (objMicroteachAppraiseEN.IsUpdated(conMicroteachAppraise.SuggestOne))
 {
 if (objMicroteachAppraiseEN.SuggestOne !=  null)
 {
 var strSuggestOne = objMicroteachAppraiseEN.SuggestOne.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SuggestOne = '{0}',", strSuggestOne); //建议1
 }
 else
 {
 sbSQL.Append(" SuggestOne = null,"); //建议1
 }
 }
 
 if (objMicroteachAppraiseEN.IsUpdated(conMicroteachAppraise.SuggestTwo))
 {
 if (objMicroteachAppraiseEN.SuggestTwo !=  null)
 {
 var strSuggestTwo = objMicroteachAppraiseEN.SuggestTwo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SuggestTwo = '{0}',", strSuggestTwo); //建议2
 }
 else
 {
 sbSQL.Append(" SuggestTwo = null,"); //建议2
 }
 }
 
 if (objMicroteachAppraiseEN.IsUpdated(conMicroteachAppraise.MicroteachAppriseScore))
 {
 sbSQL.AppendFormat(" MicroteachAppriseScore = {0},", objMicroteachAppraiseEN.MicroteachAppriseScore); //打分
 }
 
 if (objMicroteachAppraiseEN.IsUpdated(conMicroteachAppraise.VideoStopTime))
 {
 if (objMicroteachAppraiseEN.VideoStopTime !=  null)
 {
 var strVideoStopTime = objMicroteachAppraiseEN.VideoStopTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" VideoStopTime = '{0}',", strVideoStopTime); //公开课案例视频暂停时间
 }
 else
 {
 sbSQL.Append(" VideoStopTime = null,"); //公开课案例视频暂停时间
 }
 }
 
 if (objMicroteachAppraiseEN.IsUpdated(conMicroteachAppraise.BrowseCount))
 {
 sbSQL.AppendFormat(" BrowseCount = {0},", objMicroteachAppraiseEN.BrowseCount); //浏览次数
 }
 
 if (objMicroteachAppraiseEN.IsUpdated(conMicroteachAppraise.UserId))
 {
 if (objMicroteachAppraiseEN.UserId !=  null)
 {
 var strUserId = objMicroteachAppraiseEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UserId = '{0}',", strUserId); //用户ID
 }
 else
 {
 sbSQL.Append(" UserId = null,"); //用户ID
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
 /// <param name = "objMicroteachAppraiseEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsMicroteachAppraiseEN objMicroteachAppraiseEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objMicroteachAppraiseEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objMicroteachAppraiseEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsMicroteachAppraiseDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update MicroteachAppraise Set ");
 
 if (objMicroteachAppraiseEN.IsUpdated(conMicroteachAppraise.FuncModuleId))
 {
 if (objMicroteachAppraiseEN.FuncModuleId  ==  "")
 {
 objMicroteachAppraiseEN.FuncModuleId = null;
 }
 if (objMicroteachAppraiseEN.FuncModuleId !=  null)
 {
 var strFuncModuleId = objMicroteachAppraiseEN.FuncModuleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FuncModuleId = '{0}',", strFuncModuleId); //功能模块Id
 }
 else
 {
 sbSQL.Append(" FuncModuleId = null,"); //功能模块Id
 }
 }
 
 if (objMicroteachAppraiseEN.IsUpdated(conMicroteachAppraise.IdMicroteachCase))
 {
 if (objMicroteachAppraiseEN.IdMicroteachCase  ==  "")
 {
 objMicroteachAppraiseEN.IdMicroteachCase = null;
 }
 if (objMicroteachAppraiseEN.IdMicroteachCase !=  null)
 {
 var strIdMicroteachCase = objMicroteachAppraiseEN.IdMicroteachCase.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdMicroteachCase = '{0}',", strIdMicroteachCase); //微格教学案例流水号
 }
 else
 {
 sbSQL.Append(" IdMicroteachCase = null,"); //微格教学案例流水号
 }
 }
 
 if (objMicroteachAppraiseEN.IsUpdated(conMicroteachAppraise.IdAppraiseType))
 {
 if (objMicroteachAppraiseEN.IdAppraiseType !=  null)
 {
 var strIdAppraiseType = objMicroteachAppraiseEN.IdAppraiseType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdAppraiseType = '{0}',", strIdAppraiseType); //评议类型流水号
 }
 else
 {
 sbSQL.Append(" IdAppraiseType = null,"); //评议类型流水号
 }
 }
 
 if (objMicroteachAppraiseEN.IsUpdated(conMicroteachAppraise.AppraiseTheme))
 {
 if (objMicroteachAppraiseEN.AppraiseTheme !=  null)
 {
 var strAppraiseTheme = objMicroteachAppraiseEN.AppraiseTheme.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" AppraiseTheme = '{0}',", strAppraiseTheme); //评议主题
 }
 else
 {
 sbSQL.Append(" AppraiseTheme = null,"); //评议主题
 }
 }
 
 if (objMicroteachAppraiseEN.IsUpdated(conMicroteachAppraise.AppraiseContent))
 {
 if (objMicroteachAppraiseEN.AppraiseContent !=  null)
 {
 var strAppraiseContent = objMicroteachAppraiseEN.AppraiseContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" AppraiseContent = '{0}',", strAppraiseContent); //评议内容
 }
 else
 {
 sbSQL.Append(" AppraiseContent = null,"); //评议内容
 }
 }
 
 if (objMicroteachAppraiseEN.IsUpdated(conMicroteachAppraise.AppraiseDate))
 {
 if (objMicroteachAppraiseEN.AppraiseDate !=  null)
 {
 var strAppraiseDate = objMicroteachAppraiseEN.AppraiseDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" AppraiseDate = '{0}',", strAppraiseDate); //评议日期
 }
 else
 {
 sbSQL.Append(" AppraiseDate = null,"); //评议日期
 }
 }
 
 if (objMicroteachAppraiseEN.IsUpdated(conMicroteachAppraise.AppraiseTime))
 {
 if (objMicroteachAppraiseEN.AppraiseTime !=  null)
 {
 var strAppraiseTime = objMicroteachAppraiseEN.AppraiseTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" AppraiseTime = '{0}',", strAppraiseTime); //评议时间
 }
 else
 {
 sbSQL.Append(" AppraiseTime = null,"); //评议时间
 }
 }
 
 if (objMicroteachAppraiseEN.IsUpdated(conMicroteachAppraise.IsVisual))
 {
 sbSQL.AppendFormat(" IsVisual = '{0}',", objMicroteachAppraiseEN.IsVisual == true?"1":"0"); //隐藏标志
 }
 
 if (objMicroteachAppraiseEN.IsUpdated(conMicroteachAppraise.IsElite))
 {
 sbSQL.AppendFormat(" IsElite = '{0}',", objMicroteachAppraiseEN.IsElite == true?"1":"0"); //精华标志
 }
 
 if (objMicroteachAppraiseEN.IsUpdated(conMicroteachAppraise.ExcellentOne))
 {
 if (objMicroteachAppraiseEN.ExcellentOne !=  null)
 {
 var strExcellentOne = objMicroteachAppraiseEN.ExcellentOne.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ExcellentOne = '{0}',", strExcellentOne); //优点1
 }
 else
 {
 sbSQL.Append(" ExcellentOne = null,"); //优点1
 }
 }
 
 if (objMicroteachAppraiseEN.IsUpdated(conMicroteachAppraise.ExcellentTwo))
 {
 if (objMicroteachAppraiseEN.ExcellentTwo !=  null)
 {
 var strExcellentTwo = objMicroteachAppraiseEN.ExcellentTwo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ExcellentTwo = '{0}',", strExcellentTwo); //优点2
 }
 else
 {
 sbSQL.Append(" ExcellentTwo = null,"); //优点2
 }
 }
 
 if (objMicroteachAppraiseEN.IsUpdated(conMicroteachAppraise.SuggestOne))
 {
 if (objMicroteachAppraiseEN.SuggestOne !=  null)
 {
 var strSuggestOne = objMicroteachAppraiseEN.SuggestOne.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SuggestOne = '{0}',", strSuggestOne); //建议1
 }
 else
 {
 sbSQL.Append(" SuggestOne = null,"); //建议1
 }
 }
 
 if (objMicroteachAppraiseEN.IsUpdated(conMicroteachAppraise.SuggestTwo))
 {
 if (objMicroteachAppraiseEN.SuggestTwo !=  null)
 {
 var strSuggestTwo = objMicroteachAppraiseEN.SuggestTwo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SuggestTwo = '{0}',", strSuggestTwo); //建议2
 }
 else
 {
 sbSQL.Append(" SuggestTwo = null,"); //建议2
 }
 }
 
 if (objMicroteachAppraiseEN.IsUpdated(conMicroteachAppraise.MicroteachAppriseScore))
 {
 sbSQL.AppendFormat(" MicroteachAppriseScore = {0},", objMicroteachAppraiseEN.MicroteachAppriseScore); //打分
 }
 
 if (objMicroteachAppraiseEN.IsUpdated(conMicroteachAppraise.VideoStopTime))
 {
 if (objMicroteachAppraiseEN.VideoStopTime !=  null)
 {
 var strVideoStopTime = objMicroteachAppraiseEN.VideoStopTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" VideoStopTime = '{0}',", strVideoStopTime); //公开课案例视频暂停时间
 }
 else
 {
 sbSQL.Append(" VideoStopTime = null,"); //公开课案例视频暂停时间
 }
 }
 
 if (objMicroteachAppraiseEN.IsUpdated(conMicroteachAppraise.BrowseCount))
 {
 sbSQL.AppendFormat(" BrowseCount = {0},", objMicroteachAppraiseEN.BrowseCount); //浏览次数
 }
 
 if (objMicroteachAppraiseEN.IsUpdated(conMicroteachAppraise.UserId))
 {
 if (objMicroteachAppraiseEN.UserId !=  null)
 {
 var strUserId = objMicroteachAppraiseEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UserId = '{0}',", strUserId); //用户ID
 }
 else
 {
 sbSQL.Append(" UserId = null,"); //用户ID
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
 /// <param name = "objMicroteachAppraiseEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsMicroteachAppraiseEN objMicroteachAppraiseEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objMicroteachAppraiseEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objMicroteachAppraiseEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsMicroteachAppraiseDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update MicroteachAppraise Set ");
 
 if (objMicroteachAppraiseEN.IsUpdated(conMicroteachAppraise.FuncModuleId))
 {
 if (objMicroteachAppraiseEN.FuncModuleId  ==  "")
 {
 objMicroteachAppraiseEN.FuncModuleId = null;
 }
 if (objMicroteachAppraiseEN.FuncModuleId !=  null)
 {
 var strFuncModuleId = objMicroteachAppraiseEN.FuncModuleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFuncModuleId, conMicroteachAppraise.FuncModuleId); //功能模块Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conMicroteachAppraise.FuncModuleId); //功能模块Id
 }
 }
 
 if (objMicroteachAppraiseEN.IsUpdated(conMicroteachAppraise.IdMicroteachCase))
 {
 if (objMicroteachAppraiseEN.IdMicroteachCase  ==  "")
 {
 objMicroteachAppraiseEN.IdMicroteachCase = null;
 }
 if (objMicroteachAppraiseEN.IdMicroteachCase !=  null)
 {
 var strIdMicroteachCase = objMicroteachAppraiseEN.IdMicroteachCase.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdMicroteachCase, conMicroteachAppraise.IdMicroteachCase); //微格教学案例流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conMicroteachAppraise.IdMicroteachCase); //微格教学案例流水号
 }
 }
 
 if (objMicroteachAppraiseEN.IsUpdated(conMicroteachAppraise.IdAppraiseType))
 {
 if (objMicroteachAppraiseEN.IdAppraiseType !=  null)
 {
 var strIdAppraiseType = objMicroteachAppraiseEN.IdAppraiseType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdAppraiseType, conMicroteachAppraise.IdAppraiseType); //评议类型流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conMicroteachAppraise.IdAppraiseType); //评议类型流水号
 }
 }
 
 if (objMicroteachAppraiseEN.IsUpdated(conMicroteachAppraise.AppraiseTheme))
 {
 if (objMicroteachAppraiseEN.AppraiseTheme !=  null)
 {
 var strAppraiseTheme = objMicroteachAppraiseEN.AppraiseTheme.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strAppraiseTheme, conMicroteachAppraise.AppraiseTheme); //评议主题
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conMicroteachAppraise.AppraiseTheme); //评议主题
 }
 }
 
 if (objMicroteachAppraiseEN.IsUpdated(conMicroteachAppraise.AppraiseContent))
 {
 if (objMicroteachAppraiseEN.AppraiseContent !=  null)
 {
 var strAppraiseContent = objMicroteachAppraiseEN.AppraiseContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strAppraiseContent, conMicroteachAppraise.AppraiseContent); //评议内容
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conMicroteachAppraise.AppraiseContent); //评议内容
 }
 }
 
 if (objMicroteachAppraiseEN.IsUpdated(conMicroteachAppraise.AppraiseDate))
 {
 if (objMicroteachAppraiseEN.AppraiseDate !=  null)
 {
 var strAppraiseDate = objMicroteachAppraiseEN.AppraiseDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strAppraiseDate, conMicroteachAppraise.AppraiseDate); //评议日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conMicroteachAppraise.AppraiseDate); //评议日期
 }
 }
 
 if (objMicroteachAppraiseEN.IsUpdated(conMicroteachAppraise.AppraiseTime))
 {
 if (objMicroteachAppraiseEN.AppraiseTime !=  null)
 {
 var strAppraiseTime = objMicroteachAppraiseEN.AppraiseTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strAppraiseTime, conMicroteachAppraise.AppraiseTime); //评议时间
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conMicroteachAppraise.AppraiseTime); //评议时间
 }
 }
 
 if (objMicroteachAppraiseEN.IsUpdated(conMicroteachAppraise.IsVisual))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objMicroteachAppraiseEN.IsVisual == true?"1":"0", conMicroteachAppraise.IsVisual); //隐藏标志
 }
 
 if (objMicroteachAppraiseEN.IsUpdated(conMicroteachAppraise.IsElite))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objMicroteachAppraiseEN.IsElite == true?"1":"0", conMicroteachAppraise.IsElite); //精华标志
 }
 
 if (objMicroteachAppraiseEN.IsUpdated(conMicroteachAppraise.ExcellentOne))
 {
 if (objMicroteachAppraiseEN.ExcellentOne !=  null)
 {
 var strExcellentOne = objMicroteachAppraiseEN.ExcellentOne.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strExcellentOne, conMicroteachAppraise.ExcellentOne); //优点1
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conMicroteachAppraise.ExcellentOne); //优点1
 }
 }
 
 if (objMicroteachAppraiseEN.IsUpdated(conMicroteachAppraise.ExcellentTwo))
 {
 if (objMicroteachAppraiseEN.ExcellentTwo !=  null)
 {
 var strExcellentTwo = objMicroteachAppraiseEN.ExcellentTwo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strExcellentTwo, conMicroteachAppraise.ExcellentTwo); //优点2
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conMicroteachAppraise.ExcellentTwo); //优点2
 }
 }
 
 if (objMicroteachAppraiseEN.IsUpdated(conMicroteachAppraise.SuggestOne))
 {
 if (objMicroteachAppraiseEN.SuggestOne !=  null)
 {
 var strSuggestOne = objMicroteachAppraiseEN.SuggestOne.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSuggestOne, conMicroteachAppraise.SuggestOne); //建议1
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conMicroteachAppraise.SuggestOne); //建议1
 }
 }
 
 if (objMicroteachAppraiseEN.IsUpdated(conMicroteachAppraise.SuggestTwo))
 {
 if (objMicroteachAppraiseEN.SuggestTwo !=  null)
 {
 var strSuggestTwo = objMicroteachAppraiseEN.SuggestTwo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSuggestTwo, conMicroteachAppraise.SuggestTwo); //建议2
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conMicroteachAppraise.SuggestTwo); //建议2
 }
 }
 
 if (objMicroteachAppraiseEN.IsUpdated(conMicroteachAppraise.MicroteachAppriseScore))
 {
 if (objMicroteachAppraiseEN.MicroteachAppriseScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objMicroteachAppraiseEN.MicroteachAppriseScore, conMicroteachAppraise.MicroteachAppriseScore); //打分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conMicroteachAppraise.MicroteachAppriseScore); //打分
 }
 }
 
 if (objMicroteachAppraiseEN.IsUpdated(conMicroteachAppraise.VideoStopTime))
 {
 if (objMicroteachAppraiseEN.VideoStopTime !=  null)
 {
 var strVideoStopTime = objMicroteachAppraiseEN.VideoStopTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strVideoStopTime, conMicroteachAppraise.VideoStopTime); //公开课案例视频暂停时间
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conMicroteachAppraise.VideoStopTime); //公开课案例视频暂停时间
 }
 }
 
 if (objMicroteachAppraiseEN.IsUpdated(conMicroteachAppraise.BrowseCount))
 {
 if (objMicroteachAppraiseEN.BrowseCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objMicroteachAppraiseEN.BrowseCount, conMicroteachAppraise.BrowseCount); //浏览次数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conMicroteachAppraise.BrowseCount); //浏览次数
 }
 }
 
 if (objMicroteachAppraiseEN.IsUpdated(conMicroteachAppraise.UserId))
 {
 if (objMicroteachAppraiseEN.UserId !=  null)
 {
 var strUserId = objMicroteachAppraiseEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUserId, conMicroteachAppraise.UserId); //用户ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conMicroteachAppraise.UserId); //用户ID
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where IdMicroteachAppraise = {0}", objMicroteachAppraiseEN.IdMicroteachAppraise); 
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
 /// <param name = "lngIdMicroteachAppraise">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(long lngIdMicroteachAppraise) 
{
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsMicroteachAppraiseDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 lngIdMicroteachAppraise,
};
 objSQL.ExecSP("MicroteachAppraise_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "lngIdMicroteachAppraise">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(long lngIdMicroteachAppraise, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsMicroteachAppraiseDA.GetSpecSQLObj();
//删除MicroteachAppraise本表中与当前对象有关的记录
strSQL = strSQL + "Delete from MicroteachAppraise where IdMicroteachAppraise = " + ""+ lngIdMicroteachAppraise+"";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelMicroteachAppraise(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsMicroteachAppraiseDA.GetSpecSQLObj();
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
//删除MicroteachAppraise本表中与当前对象有关的记录
strSQL = strSQL + "Delete from MicroteachAppraise where IdMicroteachAppraise in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "lngIdMicroteachAppraise">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(long lngIdMicroteachAppraise) 
{
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsMicroteachAppraiseDA.GetSpecSQLObj();
//删除MicroteachAppraise本表中与当前对象有关的记录
strSQL = strSQL + "Delete from MicroteachAppraise where IdMicroteachAppraise = " + ""+ lngIdMicroteachAppraise+"";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelMicroteachAppraise(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsMicroteachAppraiseDA: DelMicroteachAppraise)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsMicroteachAppraiseDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from MicroteachAppraise where " + strCondition ;
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
public bool DelMicroteachAppraiseWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsMicroteachAppraiseDA: DelMicroteachAppraiseWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsMicroteachAppraiseDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from MicroteachAppraise where " + strCondition ;
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
 /// <param name = "objMicroteachAppraiseENS">源对象</param>
 /// <param name = "objMicroteachAppraiseENT">目标对象</param>
public void CopyTo(clsMicroteachAppraiseEN objMicroteachAppraiseENS, clsMicroteachAppraiseEN objMicroteachAppraiseENT)
{
objMicroteachAppraiseENT.IdMicroteachAppraise = objMicroteachAppraiseENS.IdMicroteachAppraise; //评议流水号
objMicroteachAppraiseENT.FuncModuleId = objMicroteachAppraiseENS.FuncModuleId; //功能模块Id
objMicroteachAppraiseENT.IdMicroteachCase = objMicroteachAppraiseENS.IdMicroteachCase; //微格教学案例流水号
objMicroteachAppraiseENT.IdAppraiseType = objMicroteachAppraiseENS.IdAppraiseType; //评议类型流水号
objMicroteachAppraiseENT.AppraiseTheme = objMicroteachAppraiseENS.AppraiseTheme; //评议主题
objMicroteachAppraiseENT.AppraiseContent = objMicroteachAppraiseENS.AppraiseContent; //评议内容
objMicroteachAppraiseENT.AppraiseDate = objMicroteachAppraiseENS.AppraiseDate; //评议日期
objMicroteachAppraiseENT.AppraiseTime = objMicroteachAppraiseENS.AppraiseTime; //评议时间
objMicroteachAppraiseENT.IsVisual = objMicroteachAppraiseENS.IsVisual; //隐藏标志
objMicroteachAppraiseENT.IsElite = objMicroteachAppraiseENS.IsElite; //精华标志
objMicroteachAppraiseENT.ExcellentOne = objMicroteachAppraiseENS.ExcellentOne; //优点1
objMicroteachAppraiseENT.ExcellentTwo = objMicroteachAppraiseENS.ExcellentTwo; //优点2
objMicroteachAppraiseENT.SuggestOne = objMicroteachAppraiseENS.SuggestOne; //建议1
objMicroteachAppraiseENT.SuggestTwo = objMicroteachAppraiseENS.SuggestTwo; //建议2
objMicroteachAppraiseENT.MicroteachAppriseScore = objMicroteachAppraiseENS.MicroteachAppriseScore; //打分
objMicroteachAppraiseENT.VideoStopTime = objMicroteachAppraiseENS.VideoStopTime; //公开课案例视频暂停时间
objMicroteachAppraiseENT.BrowseCount = objMicroteachAppraiseENS.BrowseCount; //浏览次数
objMicroteachAppraiseENT.UserId = objMicroteachAppraiseENS.UserId; //用户ID
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsMicroteachAppraiseEN objMicroteachAppraiseEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objMicroteachAppraiseEN.FuncModuleId, conMicroteachAppraise.FuncModuleId);
clsCheckSql.CheckFieldNotNull(objMicroteachAppraiseEN.IdMicroteachCase, conMicroteachAppraise.IdMicroteachCase);
clsCheckSql.CheckFieldNotNull(objMicroteachAppraiseEN.IdAppraiseType, conMicroteachAppraise.IdAppraiseType);
clsCheckSql.CheckFieldNotNull(objMicroteachAppraiseEN.UserId, conMicroteachAppraise.UserId);
//检查字段长度
clsCheckSql.CheckFieldLen(objMicroteachAppraiseEN.FuncModuleId, 4, conMicroteachAppraise.FuncModuleId);
clsCheckSql.CheckFieldLen(objMicroteachAppraiseEN.IdMicroteachCase, 8, conMicroteachAppraise.IdMicroteachCase);
clsCheckSql.CheckFieldLen(objMicroteachAppraiseEN.IdAppraiseType, 4, conMicroteachAppraise.IdAppraiseType);
clsCheckSql.CheckFieldLen(objMicroteachAppraiseEN.AppraiseTheme, 200, conMicroteachAppraise.AppraiseTheme);
clsCheckSql.CheckFieldLen(objMicroteachAppraiseEN.AppraiseContent, 2000, conMicroteachAppraise.AppraiseContent);
clsCheckSql.CheckFieldLen(objMicroteachAppraiseEN.AppraiseDate, 8, conMicroteachAppraise.AppraiseDate);
clsCheckSql.CheckFieldLen(objMicroteachAppraiseEN.AppraiseTime, 6, conMicroteachAppraise.AppraiseTime);
clsCheckSql.CheckFieldLen(objMicroteachAppraiseEN.ExcellentOne, 1000, conMicroteachAppraise.ExcellentOne);
clsCheckSql.CheckFieldLen(objMicroteachAppraiseEN.ExcellentTwo, 1000, conMicroteachAppraise.ExcellentTwo);
clsCheckSql.CheckFieldLen(objMicroteachAppraiseEN.SuggestOne, 1000, conMicroteachAppraise.SuggestOne);
clsCheckSql.CheckFieldLen(objMicroteachAppraiseEN.SuggestTwo, 1000, conMicroteachAppraise.SuggestTwo);
clsCheckSql.CheckFieldLen(objMicroteachAppraiseEN.VideoStopTime, 48, conMicroteachAppraise.VideoStopTime);
clsCheckSql.CheckFieldLen(objMicroteachAppraiseEN.UserId, 18, conMicroteachAppraise.UserId);
//检查字段外键固定长度
clsCheckSql.CheckFieldForeignKey(objMicroteachAppraiseEN.FuncModuleId, 4, conMicroteachAppraise.FuncModuleId);
clsCheckSql.CheckFieldForeignKey(objMicroteachAppraiseEN.IdMicroteachCase, 8, conMicroteachAppraise.IdMicroteachCase);
 objMicroteachAppraiseEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsMicroteachAppraiseEN objMicroteachAppraiseEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objMicroteachAppraiseEN.FuncModuleId, 4, conMicroteachAppraise.FuncModuleId);
clsCheckSql.CheckFieldLen(objMicroteachAppraiseEN.IdMicroteachCase, 8, conMicroteachAppraise.IdMicroteachCase);
clsCheckSql.CheckFieldLen(objMicroteachAppraiseEN.IdAppraiseType, 4, conMicroteachAppraise.IdAppraiseType);
clsCheckSql.CheckFieldLen(objMicroteachAppraiseEN.AppraiseTheme, 200, conMicroteachAppraise.AppraiseTheme);
clsCheckSql.CheckFieldLen(objMicroteachAppraiseEN.AppraiseContent, 2000, conMicroteachAppraise.AppraiseContent);
clsCheckSql.CheckFieldLen(objMicroteachAppraiseEN.AppraiseDate, 8, conMicroteachAppraise.AppraiseDate);
clsCheckSql.CheckFieldLen(objMicroteachAppraiseEN.AppraiseTime, 6, conMicroteachAppraise.AppraiseTime);
clsCheckSql.CheckFieldLen(objMicroteachAppraiseEN.ExcellentOne, 1000, conMicroteachAppraise.ExcellentOne);
clsCheckSql.CheckFieldLen(objMicroteachAppraiseEN.ExcellentTwo, 1000, conMicroteachAppraise.ExcellentTwo);
clsCheckSql.CheckFieldLen(objMicroteachAppraiseEN.SuggestOne, 1000, conMicroteachAppraise.SuggestOne);
clsCheckSql.CheckFieldLen(objMicroteachAppraiseEN.SuggestTwo, 1000, conMicroteachAppraise.SuggestTwo);
clsCheckSql.CheckFieldLen(objMicroteachAppraiseEN.VideoStopTime, 48, conMicroteachAppraise.VideoStopTime);
clsCheckSql.CheckFieldLen(objMicroteachAppraiseEN.UserId, 18, conMicroteachAppraise.UserId);
//检查外键字段长度
clsCheckSql.CheckFieldForeignKey(objMicroteachAppraiseEN.FuncModuleId, 4, conMicroteachAppraise.FuncModuleId);
clsCheckSql.CheckFieldForeignKey(objMicroteachAppraiseEN.IdMicroteachCase, 8, conMicroteachAppraise.IdMicroteachCase);
 objMicroteachAppraiseEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsMicroteachAppraiseEN objMicroteachAppraiseEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objMicroteachAppraiseEN.FuncModuleId, 4, conMicroteachAppraise.FuncModuleId);
clsCheckSql.CheckFieldLen(objMicroteachAppraiseEN.IdMicroteachCase, 8, conMicroteachAppraise.IdMicroteachCase);
clsCheckSql.CheckFieldLen(objMicroteachAppraiseEN.IdAppraiseType, 4, conMicroteachAppraise.IdAppraiseType);
clsCheckSql.CheckFieldLen(objMicroteachAppraiseEN.AppraiseTheme, 200, conMicroteachAppraise.AppraiseTheme);
clsCheckSql.CheckFieldLen(objMicroteachAppraiseEN.AppraiseContent, 2000, conMicroteachAppraise.AppraiseContent);
clsCheckSql.CheckFieldLen(objMicroteachAppraiseEN.AppraiseDate, 8, conMicroteachAppraise.AppraiseDate);
clsCheckSql.CheckFieldLen(objMicroteachAppraiseEN.AppraiseTime, 6, conMicroteachAppraise.AppraiseTime);
clsCheckSql.CheckFieldLen(objMicroteachAppraiseEN.ExcellentOne, 1000, conMicroteachAppraise.ExcellentOne);
clsCheckSql.CheckFieldLen(objMicroteachAppraiseEN.ExcellentTwo, 1000, conMicroteachAppraise.ExcellentTwo);
clsCheckSql.CheckFieldLen(objMicroteachAppraiseEN.SuggestOne, 1000, conMicroteachAppraise.SuggestOne);
clsCheckSql.CheckFieldLen(objMicroteachAppraiseEN.SuggestTwo, 1000, conMicroteachAppraise.SuggestTwo);
clsCheckSql.CheckFieldLen(objMicroteachAppraiseEN.VideoStopTime, 48, conMicroteachAppraise.VideoStopTime);
clsCheckSql.CheckFieldLen(objMicroteachAppraiseEN.UserId, 18, conMicroteachAppraise.UserId);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objMicroteachAppraiseEN.FuncModuleId, conMicroteachAppraise.FuncModuleId);
clsCheckSql.CheckSqlInjection4Field(objMicroteachAppraiseEN.IdMicroteachCase, conMicroteachAppraise.IdMicroteachCase);
clsCheckSql.CheckSqlInjection4Field(objMicroteachAppraiseEN.IdAppraiseType, conMicroteachAppraise.IdAppraiseType);
clsCheckSql.CheckSqlInjection4Field(objMicroteachAppraiseEN.AppraiseTheme, conMicroteachAppraise.AppraiseTheme);
clsCheckSql.CheckSqlInjection4Field(objMicroteachAppraiseEN.AppraiseContent, conMicroteachAppraise.AppraiseContent);
clsCheckSql.CheckSqlInjection4Field(objMicroteachAppraiseEN.AppraiseDate, conMicroteachAppraise.AppraiseDate);
clsCheckSql.CheckSqlInjection4Field(objMicroteachAppraiseEN.AppraiseTime, conMicroteachAppraise.AppraiseTime);
clsCheckSql.CheckSqlInjection4Field(objMicroteachAppraiseEN.ExcellentOne, conMicroteachAppraise.ExcellentOne);
clsCheckSql.CheckSqlInjection4Field(objMicroteachAppraiseEN.ExcellentTwo, conMicroteachAppraise.ExcellentTwo);
clsCheckSql.CheckSqlInjection4Field(objMicroteachAppraiseEN.SuggestOne, conMicroteachAppraise.SuggestOne);
clsCheckSql.CheckSqlInjection4Field(objMicroteachAppraiseEN.SuggestTwo, conMicroteachAppraise.SuggestTwo);
clsCheckSql.CheckSqlInjection4Field(objMicroteachAppraiseEN.VideoStopTime, conMicroteachAppraise.VideoStopTime);
clsCheckSql.CheckSqlInjection4Field(objMicroteachAppraiseEN.UserId, conMicroteachAppraise.UserId);
//检查外键字段长度
clsCheckSql.CheckFieldForeignKey(objMicroteachAppraiseEN.FuncModuleId, 4, conMicroteachAppraise.FuncModuleId);
clsCheckSql.CheckFieldForeignKey(objMicroteachAppraiseEN.IdMicroteachCase, 8, conMicroteachAppraise.IdMicroteachCase);
 objMicroteachAppraiseEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--MicroteachAppraise(微格案例定性评议),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objMicroteachAppraiseEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clsMicroteachAppraiseEN objMicroteachAppraiseEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and IdMicroteachCase = '{0}'", objMicroteachAppraiseEN.IdMicroteachCase);
 sbCondition.AppendFormat(" and UserId = '{0}'", objMicroteachAppraiseEN.UserId);
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
 objSQL = clsMicroteachAppraiseDA.GetSpecSQLObj();
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
 objSQL = clsMicroteachAppraiseDA.GetSpecSQLObj();
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
 objSQL = clsMicroteachAppraiseDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsMicroteachAppraiseEN._CurrTabName);
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
 objSQL = clsMicroteachAppraiseDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsMicroteachAppraiseEN._CurrTabName, strCondition);
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
 objSQL = clsMicroteachAppraiseDA.GetSpecSQLObj();
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
 objSQL = clsMicroteachAppraiseDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}