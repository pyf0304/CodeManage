
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsCurrEduClsStuDA
 表名:CurrEduClsStu(01120125)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 05:59:37
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:日常运行(DailyRunning)
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
 /// 教学班与学生关系(CurrEduClsStu)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsCurrEduClsStuDA : clsCommBase4DA
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
 return clsCurrEduClsStuEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsCurrEduClsStuEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsCurrEduClsStuEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsCurrEduClsStuEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsCurrEduClsStuEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsCurrEduClsStuDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCurrEduClsStuDA.GetSpecSQLObj();
strSQL = "Select * from CurrEduClsStu where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_CurrEduClsStu(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsCurrEduClsStuDA: GetDataTable_CurrEduClsStu)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCurrEduClsStuDA.GetSpecSQLObj();
strSQL = "Select * from CurrEduClsStu where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsCurrEduClsStuDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCurrEduClsStuDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsCurrEduClsStuDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCurrEduClsStuDA.GetSpecSQLObj();
strSQL = "Select * from CurrEduClsStu where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsCurrEduClsStuDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCurrEduClsStuDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsCurrEduClsStuDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCurrEduClsStuDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from CurrEduClsStu where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from CurrEduClsStu where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsCurrEduClsStuDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCurrEduClsStuDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from CurrEduClsStu where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsCurrEduClsStuDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCurrEduClsStuDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} CurrEduClsStu.* from CurrEduClsStu Left Join {1} on {2} where {3} and CurrEduClsStu.IdEduClsStu not in (Select top {5} CurrEduClsStu.IdEduClsStu from CurrEduClsStu Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from CurrEduClsStu where {1} and IdEduClsStu not in (Select top {2} IdEduClsStu from CurrEduClsStu where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from CurrEduClsStu where {1} and IdEduClsStu not in (Select top {3} IdEduClsStu from CurrEduClsStu where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsCurrEduClsStuDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCurrEduClsStuDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} CurrEduClsStu.* from CurrEduClsStu Left Join {1} on {2} where {3} and CurrEduClsStu.IdEduClsStu not in (Select top {5} CurrEduClsStu.IdEduClsStu from CurrEduClsStu Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from CurrEduClsStu where {1} and IdEduClsStu not in (Select top {2} IdEduClsStu from CurrEduClsStu where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from CurrEduClsStu where {1} and IdEduClsStu not in (Select top {3} IdEduClsStu from CurrEduClsStu where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsCurrEduClsStuEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsCurrEduClsStuDA:GetObjLst)", objException.Message));
}
List<clsCurrEduClsStuEN> arrObjLst = new List<clsCurrEduClsStuEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCurrEduClsStuDA.GetSpecSQLObj();
strSQL = "Select * from CurrEduClsStu where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCurrEduClsStuEN objCurrEduClsStuEN = new clsCurrEduClsStuEN();
try
{
objCurrEduClsStuEN.IdEduClsStu = TransNullToInt(objRow[conCurrEduClsStu.IdEduClsStu].ToString().Trim()); //教学班学生流水号
objCurrEduClsStuEN.IdCurrEduCls = objRow[conCurrEduClsStu.IdCurrEduCls] == DBNull.Value ? null : objRow[conCurrEduClsStu.IdCurrEduCls].ToString().Trim(); //教学班流水号
objCurrEduClsStuEN.IdStu = objRow[conCurrEduClsStu.IdStu] == DBNull.Value ? null : objRow[conCurrEduClsStu.IdStu].ToString().Trim(); //学生流水号
objCurrEduClsStuEN.EduClsStuStateId = objRow[conCurrEduClsStu.EduClsStuStateId] == DBNull.Value ? null : objRow[conCurrEduClsStu.EduClsStuStateId].ToString().Trim(); //教学班学生状态编号
objCurrEduClsStuEN.GetScoreTimes = objRow[conCurrEduClsStu.GetScoreTimes] == DBNull.Value ? (short?)null : TransNullToShort(objRow[conCurrEduClsStu.GetScoreTimes].ToString().Trim()); //获得成绩次数
objCurrEduClsStuEN.Score = objRow[conCurrEduClsStu.Score] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[conCurrEduClsStu.Score].ToString().Trim()); //得分
objCurrEduClsStuEN.TotalScores = objRow[conCurrEduClsStu.TotalScores] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[conCurrEduClsStu.TotalScores].ToString().Trim()); //总分值
objCurrEduClsStuEN.Ranking = objRow[conCurrEduClsStu.Ranking] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conCurrEduClsStu.Ranking].ToString().Trim()); //名次
objCurrEduClsStuEN.Percentile = objRow[conCurrEduClsStu.Percentile] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[conCurrEduClsStu.Percentile].ToString().Trim()); //百分位
objCurrEduClsStuEN.Ranking2 = objRow[conCurrEduClsStu.Ranking2] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conCurrEduClsStu.Ranking2].ToString().Trim()); //Ranking2
objCurrEduClsStuEN.Percentile2 = objRow[conCurrEduClsStu.Percentile2] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[conCurrEduClsStu.Percentile2].ToString().Trim()); //Percentile2
objCurrEduClsStuEN.Ranking3 = objRow[conCurrEduClsStu.Ranking3] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conCurrEduClsStu.Ranking3].ToString().Trim()); //Ranking3
objCurrEduClsStuEN.Percentile3 = objRow[conCurrEduClsStu.Percentile3] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[conCurrEduClsStu.Percentile3].ToString().Trim()); //Percentile3
objCurrEduClsStuEN.Confirmed = TransNullToBool(objRow[conCurrEduClsStu.Confirmed].ToString().Trim()); //是否确认
objCurrEduClsStuEN.SchoolTerm = objRow[conCurrEduClsStu.SchoolTerm] == DBNull.Value ? null : objRow[conCurrEduClsStu.SchoolTerm].ToString().Trim(); //学期
objCurrEduClsStuEN.SchoolYear = objRow[conCurrEduClsStu.SchoolYear] == DBNull.Value ? null : objRow[conCurrEduClsStu.SchoolYear].ToString().Trim(); //学年
objCurrEduClsStuEN.ExportDate = objRow[conCurrEduClsStu.ExportDate] == DBNull.Value ? null : objRow[conCurrEduClsStu.ExportDate].ToString().Trim(); //导出日期
objCurrEduClsStuEN.SignInDate = objRow[conCurrEduClsStu.SignInDate] == DBNull.Value ? null : objRow[conCurrEduClsStu.SignInDate].ToString().Trim(); //签入时间
objCurrEduClsStuEN.SignInStateID = objRow[conCurrEduClsStu.SignInStateID] == DBNull.Value ? null : objRow[conCurrEduClsStu.SignInStateID].ToString().Trim(); //签入状态表流水号
objCurrEduClsStuEN.SignInUser = objRow[conCurrEduClsStu.SignInUser] == DBNull.Value ? null : objRow[conCurrEduClsStu.SignInUser].ToString().Trim(); //签入人
objCurrEduClsStuEN.IsOpByTeacher = TransNullToBool(objRow[conCurrEduClsStu.IsOpByTeacher].ToString().Trim()); //是否教师操作
objCurrEduClsStuEN.IsSynScore = TransNullToBool(objRow[conCurrEduClsStu.IsSynScore].ToString().Trim()); //是否同步成绩
objCurrEduClsStuEN.LastVisitedDate = objRow[conCurrEduClsStu.LastVisitedDate] == DBNull.Value ? null : objRow[conCurrEduClsStu.LastVisitedDate].ToString().Trim(); //最后访问时间
objCurrEduClsStuEN.ModifyDate = objRow[conCurrEduClsStu.ModifyDate] == DBNull.Value ? null : objRow[conCurrEduClsStu.ModifyDate].ToString().Trim(); //修改日期
objCurrEduClsStuEN.ModifyUserId = objRow[conCurrEduClsStu.ModifyUserId] == DBNull.Value ? null : objRow[conCurrEduClsStu.ModifyUserId].ToString().Trim(); //修改人
objCurrEduClsStuEN.Memo = objRow[conCurrEduClsStu.Memo] == DBNull.Value ? null : objRow[conCurrEduClsStu.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsCurrEduClsStuDA: GetObjLst)", objException.Message));
}
objCurrEduClsStuEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objCurrEduClsStuEN);
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
public List<clsCurrEduClsStuEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsCurrEduClsStuDA:GetObjLstByTabName)", objException.Message));
}
List<clsCurrEduClsStuEN> arrObjLst = new List<clsCurrEduClsStuEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCurrEduClsStuDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCurrEduClsStuEN objCurrEduClsStuEN = new clsCurrEduClsStuEN();
try
{
objCurrEduClsStuEN.IdEduClsStu = TransNullToInt(objRow[conCurrEduClsStu.IdEduClsStu].ToString().Trim()); //教学班学生流水号
objCurrEduClsStuEN.IdCurrEduCls = objRow[conCurrEduClsStu.IdCurrEduCls] == DBNull.Value ? null : objRow[conCurrEduClsStu.IdCurrEduCls].ToString().Trim(); //教学班流水号
objCurrEduClsStuEN.IdStu = objRow[conCurrEduClsStu.IdStu] == DBNull.Value ? null : objRow[conCurrEduClsStu.IdStu].ToString().Trim(); //学生流水号
objCurrEduClsStuEN.EduClsStuStateId = objRow[conCurrEduClsStu.EduClsStuStateId] == DBNull.Value ? null : objRow[conCurrEduClsStu.EduClsStuStateId].ToString().Trim(); //教学班学生状态编号
objCurrEduClsStuEN.GetScoreTimes = objRow[conCurrEduClsStu.GetScoreTimes] == DBNull.Value ? (short?)null : TransNullToShort(objRow[conCurrEduClsStu.GetScoreTimes].ToString().Trim()); //获得成绩次数
objCurrEduClsStuEN.Score = objRow[conCurrEduClsStu.Score] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[conCurrEduClsStu.Score].ToString().Trim()); //得分
objCurrEduClsStuEN.TotalScores = objRow[conCurrEduClsStu.TotalScores] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[conCurrEduClsStu.TotalScores].ToString().Trim()); //总分值
objCurrEduClsStuEN.Ranking = objRow[conCurrEduClsStu.Ranking] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conCurrEduClsStu.Ranking].ToString().Trim()); //名次
objCurrEduClsStuEN.Percentile = objRow[conCurrEduClsStu.Percentile] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[conCurrEduClsStu.Percentile].ToString().Trim()); //百分位
objCurrEduClsStuEN.Ranking2 = objRow[conCurrEduClsStu.Ranking2] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conCurrEduClsStu.Ranking2].ToString().Trim()); //Ranking2
objCurrEduClsStuEN.Percentile2 = objRow[conCurrEduClsStu.Percentile2] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[conCurrEduClsStu.Percentile2].ToString().Trim()); //Percentile2
objCurrEduClsStuEN.Ranking3 = objRow[conCurrEduClsStu.Ranking3] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conCurrEduClsStu.Ranking3].ToString().Trim()); //Ranking3
objCurrEduClsStuEN.Percentile3 = objRow[conCurrEduClsStu.Percentile3] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[conCurrEduClsStu.Percentile3].ToString().Trim()); //Percentile3
objCurrEduClsStuEN.Confirmed = TransNullToBool(objRow[conCurrEduClsStu.Confirmed].ToString().Trim()); //是否确认
objCurrEduClsStuEN.SchoolTerm = objRow[conCurrEduClsStu.SchoolTerm] == DBNull.Value ? null : objRow[conCurrEduClsStu.SchoolTerm].ToString().Trim(); //学期
objCurrEduClsStuEN.SchoolYear = objRow[conCurrEduClsStu.SchoolYear] == DBNull.Value ? null : objRow[conCurrEduClsStu.SchoolYear].ToString().Trim(); //学年
objCurrEduClsStuEN.ExportDate = objRow[conCurrEduClsStu.ExportDate] == DBNull.Value ? null : objRow[conCurrEduClsStu.ExportDate].ToString().Trim(); //导出日期
objCurrEduClsStuEN.SignInDate = objRow[conCurrEduClsStu.SignInDate] == DBNull.Value ? null : objRow[conCurrEduClsStu.SignInDate].ToString().Trim(); //签入时间
objCurrEduClsStuEN.SignInStateID = objRow[conCurrEduClsStu.SignInStateID] == DBNull.Value ? null : objRow[conCurrEduClsStu.SignInStateID].ToString().Trim(); //签入状态表流水号
objCurrEduClsStuEN.SignInUser = objRow[conCurrEduClsStu.SignInUser] == DBNull.Value ? null : objRow[conCurrEduClsStu.SignInUser].ToString().Trim(); //签入人
objCurrEduClsStuEN.IsOpByTeacher = TransNullToBool(objRow[conCurrEduClsStu.IsOpByTeacher].ToString().Trim()); //是否教师操作
objCurrEduClsStuEN.IsSynScore = TransNullToBool(objRow[conCurrEduClsStu.IsSynScore].ToString().Trim()); //是否同步成绩
objCurrEduClsStuEN.LastVisitedDate = objRow[conCurrEduClsStu.LastVisitedDate] == DBNull.Value ? null : objRow[conCurrEduClsStu.LastVisitedDate].ToString().Trim(); //最后访问时间
objCurrEduClsStuEN.ModifyDate = objRow[conCurrEduClsStu.ModifyDate] == DBNull.Value ? null : objRow[conCurrEduClsStu.ModifyDate].ToString().Trim(); //修改日期
objCurrEduClsStuEN.ModifyUserId = objRow[conCurrEduClsStu.ModifyUserId] == DBNull.Value ? null : objRow[conCurrEduClsStu.ModifyUserId].ToString().Trim(); //修改人
objCurrEduClsStuEN.Memo = objRow[conCurrEduClsStu.Memo] == DBNull.Value ? null : objRow[conCurrEduClsStu.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsCurrEduClsStuDA: GetObjLst)", objException.Message));
}
objCurrEduClsStuEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objCurrEduClsStuEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objCurrEduClsStuEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetCurrEduClsStu(ref clsCurrEduClsStuEN objCurrEduClsStuEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCurrEduClsStuDA.GetSpecSQLObj();
strSQL = "Select * from CurrEduClsStu where IdEduClsStu = " + ""+ objCurrEduClsStuEN.IdEduClsStu+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objCurrEduClsStuEN.IdEduClsStu = TransNullToInt(objDT.Rows[0][conCurrEduClsStu.IdEduClsStu].ToString().Trim()); //教学班学生流水号(字段类型:bigint,字段长度:8,是否可空:False)
 objCurrEduClsStuEN.IdCurrEduCls = objDT.Rows[0][conCurrEduClsStu.IdCurrEduCls].ToString().Trim(); //教学班流水号(字段类型:char,字段长度:8,是否可空:False)
 objCurrEduClsStuEN.IdStu = objDT.Rows[0][conCurrEduClsStu.IdStu].ToString().Trim(); //学生流水号(字段类型:char,字段长度:8,是否可空:True)
 objCurrEduClsStuEN.EduClsStuStateId = objDT.Rows[0][conCurrEduClsStu.EduClsStuStateId].ToString().Trim(); //教学班学生状态编号(字段类型:char,字段长度:2,是否可空:True)
 objCurrEduClsStuEN.GetScoreTimes = TransNullToShort(objDT.Rows[0][conCurrEduClsStu.GetScoreTimes].ToString().Trim()); //获得成绩次数(字段类型:tinyint,字段长度:1,是否可空:True)
 objCurrEduClsStuEN.Score = TransNullToDouble(objDT.Rows[0][conCurrEduClsStu.Score].ToString().Trim()); //得分(字段类型:decimal,字段长度:6,是否可空:True)
 objCurrEduClsStuEN.TotalScores = TransNullToDouble(objDT.Rows[0][conCurrEduClsStu.TotalScores].ToString().Trim()); //总分值(字段类型:decimal,字段长度:10,是否可空:True)
 objCurrEduClsStuEN.Ranking = TransNullToInt(objDT.Rows[0][conCurrEduClsStu.Ranking].ToString().Trim()); //名次(字段类型:int,字段长度:4,是否可空:True)
 objCurrEduClsStuEN.Percentile = TransNullToDouble(objDT.Rows[0][conCurrEduClsStu.Percentile].ToString().Trim()); //百分位(字段类型:decimal,字段长度:8,是否可空:True)
 objCurrEduClsStuEN.Ranking2 = TransNullToInt(objDT.Rows[0][conCurrEduClsStu.Ranking2].ToString().Trim()); //Ranking2(字段类型:int,字段长度:4,是否可空:True)
 objCurrEduClsStuEN.Percentile2 = TransNullToDouble(objDT.Rows[0][conCurrEduClsStu.Percentile2].ToString().Trim()); //Percentile2(字段类型:decimal,字段长度:10,是否可空:True)
 objCurrEduClsStuEN.Ranking3 = TransNullToInt(objDT.Rows[0][conCurrEduClsStu.Ranking3].ToString().Trim()); //Ranking3(字段类型:int,字段长度:4,是否可空:True)
 objCurrEduClsStuEN.Percentile3 = TransNullToDouble(objDT.Rows[0][conCurrEduClsStu.Percentile3].ToString().Trim()); //Percentile3(字段类型:decimal,字段长度:10,是否可空:True)
 objCurrEduClsStuEN.Confirmed = TransNullToBool(objDT.Rows[0][conCurrEduClsStu.Confirmed].ToString().Trim()); //是否确认(字段类型:bit,字段长度:1,是否可空:False)
 objCurrEduClsStuEN.SchoolTerm = objDT.Rows[0][conCurrEduClsStu.SchoolTerm].ToString().Trim(); //学期(字段类型:char,字段长度:1,是否可空:True)
 objCurrEduClsStuEN.SchoolYear = objDT.Rows[0][conCurrEduClsStu.SchoolYear].ToString().Trim(); //学年(字段类型:varchar,字段长度:10,是否可空:True)
 objCurrEduClsStuEN.ExportDate = objDT.Rows[0][conCurrEduClsStu.ExportDate].ToString().Trim(); //导出日期(字段类型:varchar,字段长度:8,是否可空:True)
 objCurrEduClsStuEN.SignInDate = objDT.Rows[0][conCurrEduClsStu.SignInDate].ToString().Trim(); //签入时间(字段类型:varchar,字段长度:20,是否可空:True)
 objCurrEduClsStuEN.SignInStateID = objDT.Rows[0][conCurrEduClsStu.SignInStateID].ToString().Trim(); //签入状态表流水号(字段类型:char,字段长度:2,是否可空:True)
 objCurrEduClsStuEN.SignInUser = objDT.Rows[0][conCurrEduClsStu.SignInUser].ToString().Trim(); //签入人(字段类型:varchar,字段长度:18,是否可空:True)
 objCurrEduClsStuEN.IsOpByTeacher = TransNullToBool(objDT.Rows[0][conCurrEduClsStu.IsOpByTeacher].ToString().Trim()); //是否教师操作(字段类型:bit,字段长度:1,是否可空:True)
 objCurrEduClsStuEN.IsSynScore = TransNullToBool(objDT.Rows[0][conCurrEduClsStu.IsSynScore].ToString().Trim()); //是否同步成绩(字段类型:bit,字段长度:1,是否可空:True)
 objCurrEduClsStuEN.LastVisitedDate = objDT.Rows[0][conCurrEduClsStu.LastVisitedDate].ToString().Trim(); //最后访问时间(字段类型:varchar,字段长度:14,是否可空:True)
 objCurrEduClsStuEN.ModifyDate = objDT.Rows[0][conCurrEduClsStu.ModifyDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objCurrEduClsStuEN.ModifyUserId = objDT.Rows[0][conCurrEduClsStu.ModifyUserId].ToString().Trim(); //修改人(字段类型:varchar,字段长度:18,是否可空:True)
 objCurrEduClsStuEN.Memo = objDT.Rows[0][conCurrEduClsStu.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsCurrEduClsStuDA: GetCurrEduClsStu)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngIdEduClsStu">表关键字</param>
 /// <returns>表对象</returns>
public clsCurrEduClsStuEN GetObjByIdEduClsStu(long lngIdEduClsStu)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCurrEduClsStuDA.GetSpecSQLObj();
strSQL = "Select * from CurrEduClsStu where IdEduClsStu = " + ""+ lngIdEduClsStu+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsCurrEduClsStuEN objCurrEduClsStuEN = new clsCurrEduClsStuEN();
try
{
 objCurrEduClsStuEN.IdEduClsStu = Int32.Parse(objRow[conCurrEduClsStu.IdEduClsStu].ToString().Trim()); //教学班学生流水号(字段类型:bigint,字段长度:8,是否可空:False)
 objCurrEduClsStuEN.IdCurrEduCls = objRow[conCurrEduClsStu.IdCurrEduCls] == DBNull.Value ? null : objRow[conCurrEduClsStu.IdCurrEduCls].ToString().Trim(); //教学班流水号(字段类型:char,字段长度:8,是否可空:False)
 objCurrEduClsStuEN.IdStu = objRow[conCurrEduClsStu.IdStu] == DBNull.Value ? null : objRow[conCurrEduClsStu.IdStu].ToString().Trim(); //学生流水号(字段类型:char,字段长度:8,是否可空:True)
 objCurrEduClsStuEN.EduClsStuStateId = objRow[conCurrEduClsStu.EduClsStuStateId] == DBNull.Value ? null : objRow[conCurrEduClsStu.EduClsStuStateId].ToString().Trim(); //教学班学生状态编号(字段类型:char,字段长度:2,是否可空:True)
 objCurrEduClsStuEN.GetScoreTimes = objRow[conCurrEduClsStu.GetScoreTimes] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[conCurrEduClsStu.GetScoreTimes].ToString().Trim()); //获得成绩次数(字段类型:tinyint,字段长度:1,是否可空:True)
 objCurrEduClsStuEN.Score = objRow[conCurrEduClsStu.Score] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conCurrEduClsStu.Score].ToString().Trim()); //得分(字段类型:decimal,字段长度:6,是否可空:True)
 objCurrEduClsStuEN.TotalScores = objRow[conCurrEduClsStu.TotalScores] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conCurrEduClsStu.TotalScores].ToString().Trim()); //总分值(字段类型:decimal,字段长度:10,是否可空:True)
 objCurrEduClsStuEN.Ranking = objRow[conCurrEduClsStu.Ranking] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCurrEduClsStu.Ranking].ToString().Trim()); //名次(字段类型:int,字段长度:4,是否可空:True)
 objCurrEduClsStuEN.Percentile = objRow[conCurrEduClsStu.Percentile] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conCurrEduClsStu.Percentile].ToString().Trim()); //百分位(字段类型:decimal,字段长度:8,是否可空:True)
 objCurrEduClsStuEN.Ranking2 = objRow[conCurrEduClsStu.Ranking2] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCurrEduClsStu.Ranking2].ToString().Trim()); //Ranking2(字段类型:int,字段长度:4,是否可空:True)
 objCurrEduClsStuEN.Percentile2 = objRow[conCurrEduClsStu.Percentile2] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conCurrEduClsStu.Percentile2].ToString().Trim()); //Percentile2(字段类型:decimal,字段长度:10,是否可空:True)
 objCurrEduClsStuEN.Ranking3 = objRow[conCurrEduClsStu.Ranking3] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCurrEduClsStu.Ranking3].ToString().Trim()); //Ranking3(字段类型:int,字段长度:4,是否可空:True)
 objCurrEduClsStuEN.Percentile3 = objRow[conCurrEduClsStu.Percentile3] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conCurrEduClsStu.Percentile3].ToString().Trim()); //Percentile3(字段类型:decimal,字段长度:10,是否可空:True)
 objCurrEduClsStuEN.Confirmed = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduClsStu.Confirmed].ToString().Trim()); //是否确认(字段类型:bit,字段长度:1,是否可空:False)
 objCurrEduClsStuEN.SchoolTerm = objRow[conCurrEduClsStu.SchoolTerm] == DBNull.Value ? null : objRow[conCurrEduClsStu.SchoolTerm].ToString().Trim(); //学期(字段类型:char,字段长度:1,是否可空:True)
 objCurrEduClsStuEN.SchoolYear = objRow[conCurrEduClsStu.SchoolYear] == DBNull.Value ? null : objRow[conCurrEduClsStu.SchoolYear].ToString().Trim(); //学年(字段类型:varchar,字段长度:10,是否可空:True)
 objCurrEduClsStuEN.ExportDate = objRow[conCurrEduClsStu.ExportDate] == DBNull.Value ? null : objRow[conCurrEduClsStu.ExportDate].ToString().Trim(); //导出日期(字段类型:varchar,字段长度:8,是否可空:True)
 objCurrEduClsStuEN.SignInDate = objRow[conCurrEduClsStu.SignInDate] == DBNull.Value ? null : objRow[conCurrEduClsStu.SignInDate].ToString().Trim(); //签入时间(字段类型:varchar,字段长度:20,是否可空:True)
 objCurrEduClsStuEN.SignInStateID = objRow[conCurrEduClsStu.SignInStateID] == DBNull.Value ? null : objRow[conCurrEduClsStu.SignInStateID].ToString().Trim(); //签入状态表流水号(字段类型:char,字段长度:2,是否可空:True)
 objCurrEduClsStuEN.SignInUser = objRow[conCurrEduClsStu.SignInUser] == DBNull.Value ? null : objRow[conCurrEduClsStu.SignInUser].ToString().Trim(); //签入人(字段类型:varchar,字段长度:18,是否可空:True)
 objCurrEduClsStuEN.IsOpByTeacher = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduClsStu.IsOpByTeacher].ToString().Trim()); //是否教师操作(字段类型:bit,字段长度:1,是否可空:True)
 objCurrEduClsStuEN.IsSynScore = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduClsStu.IsSynScore].ToString().Trim()); //是否同步成绩(字段类型:bit,字段长度:1,是否可空:True)
 objCurrEduClsStuEN.LastVisitedDate = objRow[conCurrEduClsStu.LastVisitedDate] == DBNull.Value ? null : objRow[conCurrEduClsStu.LastVisitedDate].ToString().Trim(); //最后访问时间(字段类型:varchar,字段长度:14,是否可空:True)
 objCurrEduClsStuEN.ModifyDate = objRow[conCurrEduClsStu.ModifyDate] == DBNull.Value ? null : objRow[conCurrEduClsStu.ModifyDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objCurrEduClsStuEN.ModifyUserId = objRow[conCurrEduClsStu.ModifyUserId] == DBNull.Value ? null : objRow[conCurrEduClsStu.ModifyUserId].ToString().Trim(); //修改人(字段类型:varchar,字段长度:18,是否可空:True)
 objCurrEduClsStuEN.Memo = objRow[conCurrEduClsStu.Memo] == DBNull.Value ? null : objRow[conCurrEduClsStu.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsCurrEduClsStuDA: GetObjByIdEduClsStu)", objException.Message));
}
return objCurrEduClsStuEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsCurrEduClsStuEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsCurrEduClsStuDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCurrEduClsStuDA.GetSpecSQLObj();
strSQL = "Select * from CurrEduClsStu where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsCurrEduClsStuEN objCurrEduClsStuEN = new clsCurrEduClsStuEN()
{
IdEduClsStu = TransNullToInt(objRow[conCurrEduClsStu.IdEduClsStu].ToString().Trim()), //教学班学生流水号
IdCurrEduCls = objRow[conCurrEduClsStu.IdCurrEduCls] == DBNull.Value ? null : objRow[conCurrEduClsStu.IdCurrEduCls].ToString().Trim(), //教学班流水号
IdStu = objRow[conCurrEduClsStu.IdStu] == DBNull.Value ? null : objRow[conCurrEduClsStu.IdStu].ToString().Trim(), //学生流水号
EduClsStuStateId = objRow[conCurrEduClsStu.EduClsStuStateId] == DBNull.Value ? null : objRow[conCurrEduClsStu.EduClsStuStateId].ToString().Trim(), //教学班学生状态编号
GetScoreTimes = objRow[conCurrEduClsStu.GetScoreTimes] == DBNull.Value ? (short?)null : TransNullToShort(objRow[conCurrEduClsStu.GetScoreTimes].ToString().Trim()), //获得成绩次数
Score = objRow[conCurrEduClsStu.Score] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[conCurrEduClsStu.Score].ToString().Trim()), //得分
TotalScores = objRow[conCurrEduClsStu.TotalScores] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[conCurrEduClsStu.TotalScores].ToString().Trim()), //总分值
Ranking = objRow[conCurrEduClsStu.Ranking] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conCurrEduClsStu.Ranking].ToString().Trim()), //名次
Percentile = objRow[conCurrEduClsStu.Percentile] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[conCurrEduClsStu.Percentile].ToString().Trim()), //百分位
Ranking2 = objRow[conCurrEduClsStu.Ranking2] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conCurrEduClsStu.Ranking2].ToString().Trim()), //Ranking2
Percentile2 = objRow[conCurrEduClsStu.Percentile2] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[conCurrEduClsStu.Percentile2].ToString().Trim()), //Percentile2
Ranking3 = objRow[conCurrEduClsStu.Ranking3] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conCurrEduClsStu.Ranking3].ToString().Trim()), //Ranking3
Percentile3 = objRow[conCurrEduClsStu.Percentile3] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[conCurrEduClsStu.Percentile3].ToString().Trim()), //Percentile3
Confirmed = TransNullToBool(objRow[conCurrEduClsStu.Confirmed].ToString().Trim()), //是否确认
SchoolTerm = objRow[conCurrEduClsStu.SchoolTerm] == DBNull.Value ? null : objRow[conCurrEduClsStu.SchoolTerm].ToString().Trim(), //学期
SchoolYear = objRow[conCurrEduClsStu.SchoolYear] == DBNull.Value ? null : objRow[conCurrEduClsStu.SchoolYear].ToString().Trim(), //学年
ExportDate = objRow[conCurrEduClsStu.ExportDate] == DBNull.Value ? null : objRow[conCurrEduClsStu.ExportDate].ToString().Trim(), //导出日期
SignInDate = objRow[conCurrEduClsStu.SignInDate] == DBNull.Value ? null : objRow[conCurrEduClsStu.SignInDate].ToString().Trim(), //签入时间
SignInStateID = objRow[conCurrEduClsStu.SignInStateID] == DBNull.Value ? null : objRow[conCurrEduClsStu.SignInStateID].ToString().Trim(), //签入状态表流水号
SignInUser = objRow[conCurrEduClsStu.SignInUser] == DBNull.Value ? null : objRow[conCurrEduClsStu.SignInUser].ToString().Trim(), //签入人
IsOpByTeacher = TransNullToBool(objRow[conCurrEduClsStu.IsOpByTeacher].ToString().Trim()), //是否教师操作
IsSynScore = TransNullToBool(objRow[conCurrEduClsStu.IsSynScore].ToString().Trim()), //是否同步成绩
LastVisitedDate = objRow[conCurrEduClsStu.LastVisitedDate] == DBNull.Value ? null : objRow[conCurrEduClsStu.LastVisitedDate].ToString().Trim(), //最后访问时间
ModifyDate = objRow[conCurrEduClsStu.ModifyDate] == DBNull.Value ? null : objRow[conCurrEduClsStu.ModifyDate].ToString().Trim(), //修改日期
ModifyUserId = objRow[conCurrEduClsStu.ModifyUserId] == DBNull.Value ? null : objRow[conCurrEduClsStu.ModifyUserId].ToString().Trim(), //修改人
Memo = objRow[conCurrEduClsStu.Memo] == DBNull.Value ? null : objRow[conCurrEduClsStu.Memo].ToString().Trim() //备注
};
objCurrEduClsStuEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objCurrEduClsStuEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsCurrEduClsStuDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsCurrEduClsStuEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsCurrEduClsStuEN objCurrEduClsStuEN = new clsCurrEduClsStuEN();
try
{
objCurrEduClsStuEN.IdEduClsStu = TransNullToInt(objRow[conCurrEduClsStu.IdEduClsStu].ToString().Trim()); //教学班学生流水号
objCurrEduClsStuEN.IdCurrEduCls = objRow[conCurrEduClsStu.IdCurrEduCls] == DBNull.Value ? null : objRow[conCurrEduClsStu.IdCurrEduCls].ToString().Trim(); //教学班流水号
objCurrEduClsStuEN.IdStu = objRow[conCurrEduClsStu.IdStu] == DBNull.Value ? null : objRow[conCurrEduClsStu.IdStu].ToString().Trim(); //学生流水号
objCurrEduClsStuEN.EduClsStuStateId = objRow[conCurrEduClsStu.EduClsStuStateId] == DBNull.Value ? null : objRow[conCurrEduClsStu.EduClsStuStateId].ToString().Trim(); //教学班学生状态编号
objCurrEduClsStuEN.GetScoreTimes = objRow[conCurrEduClsStu.GetScoreTimes] == DBNull.Value ? (short?)null : TransNullToShort(objRow[conCurrEduClsStu.GetScoreTimes].ToString().Trim()); //获得成绩次数
objCurrEduClsStuEN.Score = objRow[conCurrEduClsStu.Score] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[conCurrEduClsStu.Score].ToString().Trim()); //得分
objCurrEduClsStuEN.TotalScores = objRow[conCurrEduClsStu.TotalScores] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[conCurrEduClsStu.TotalScores].ToString().Trim()); //总分值
objCurrEduClsStuEN.Ranking = objRow[conCurrEduClsStu.Ranking] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conCurrEduClsStu.Ranking].ToString().Trim()); //名次
objCurrEduClsStuEN.Percentile = objRow[conCurrEduClsStu.Percentile] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[conCurrEduClsStu.Percentile].ToString().Trim()); //百分位
objCurrEduClsStuEN.Ranking2 = objRow[conCurrEduClsStu.Ranking2] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conCurrEduClsStu.Ranking2].ToString().Trim()); //Ranking2
objCurrEduClsStuEN.Percentile2 = objRow[conCurrEduClsStu.Percentile2] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[conCurrEduClsStu.Percentile2].ToString().Trim()); //Percentile2
objCurrEduClsStuEN.Ranking3 = objRow[conCurrEduClsStu.Ranking3] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conCurrEduClsStu.Ranking3].ToString().Trim()); //Ranking3
objCurrEduClsStuEN.Percentile3 = objRow[conCurrEduClsStu.Percentile3] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[conCurrEduClsStu.Percentile3].ToString().Trim()); //Percentile3
objCurrEduClsStuEN.Confirmed = TransNullToBool(objRow[conCurrEduClsStu.Confirmed].ToString().Trim()); //是否确认
objCurrEduClsStuEN.SchoolTerm = objRow[conCurrEduClsStu.SchoolTerm] == DBNull.Value ? null : objRow[conCurrEduClsStu.SchoolTerm].ToString().Trim(); //学期
objCurrEduClsStuEN.SchoolYear = objRow[conCurrEduClsStu.SchoolYear] == DBNull.Value ? null : objRow[conCurrEduClsStu.SchoolYear].ToString().Trim(); //学年
objCurrEduClsStuEN.ExportDate = objRow[conCurrEduClsStu.ExportDate] == DBNull.Value ? null : objRow[conCurrEduClsStu.ExportDate].ToString().Trim(); //导出日期
objCurrEduClsStuEN.SignInDate = objRow[conCurrEduClsStu.SignInDate] == DBNull.Value ? null : objRow[conCurrEduClsStu.SignInDate].ToString().Trim(); //签入时间
objCurrEduClsStuEN.SignInStateID = objRow[conCurrEduClsStu.SignInStateID] == DBNull.Value ? null : objRow[conCurrEduClsStu.SignInStateID].ToString().Trim(); //签入状态表流水号
objCurrEduClsStuEN.SignInUser = objRow[conCurrEduClsStu.SignInUser] == DBNull.Value ? null : objRow[conCurrEduClsStu.SignInUser].ToString().Trim(); //签入人
objCurrEduClsStuEN.IsOpByTeacher = TransNullToBool(objRow[conCurrEduClsStu.IsOpByTeacher].ToString().Trim()); //是否教师操作
objCurrEduClsStuEN.IsSynScore = TransNullToBool(objRow[conCurrEduClsStu.IsSynScore].ToString().Trim()); //是否同步成绩
objCurrEduClsStuEN.LastVisitedDate = objRow[conCurrEduClsStu.LastVisitedDate] == DBNull.Value ? null : objRow[conCurrEduClsStu.LastVisitedDate].ToString().Trim(); //最后访问时间
objCurrEduClsStuEN.ModifyDate = objRow[conCurrEduClsStu.ModifyDate] == DBNull.Value ? null : objRow[conCurrEduClsStu.ModifyDate].ToString().Trim(); //修改日期
objCurrEduClsStuEN.ModifyUserId = objRow[conCurrEduClsStu.ModifyUserId] == DBNull.Value ? null : objRow[conCurrEduClsStu.ModifyUserId].ToString().Trim(); //修改人
objCurrEduClsStuEN.Memo = objRow[conCurrEduClsStu.Memo] == DBNull.Value ? null : objRow[conCurrEduClsStu.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsCurrEduClsStuDA: GetObjByDataRowCurrEduClsStu)", objException.Message));
}
objCurrEduClsStuEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objCurrEduClsStuEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsCurrEduClsStuEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsCurrEduClsStuEN objCurrEduClsStuEN = new clsCurrEduClsStuEN();
try
{
objCurrEduClsStuEN.IdEduClsStu = TransNullToInt(objRow[conCurrEduClsStu.IdEduClsStu].ToString().Trim()); //教学班学生流水号
objCurrEduClsStuEN.IdCurrEduCls = objRow[conCurrEduClsStu.IdCurrEduCls] == DBNull.Value ? null : objRow[conCurrEduClsStu.IdCurrEduCls].ToString().Trim(); //教学班流水号
objCurrEduClsStuEN.IdStu = objRow[conCurrEduClsStu.IdStu] == DBNull.Value ? null : objRow[conCurrEduClsStu.IdStu].ToString().Trim(); //学生流水号
objCurrEduClsStuEN.EduClsStuStateId = objRow[conCurrEduClsStu.EduClsStuStateId] == DBNull.Value ? null : objRow[conCurrEduClsStu.EduClsStuStateId].ToString().Trim(); //教学班学生状态编号
objCurrEduClsStuEN.GetScoreTimes = objRow[conCurrEduClsStu.GetScoreTimes] == DBNull.Value ? (short?)null : TransNullToShort(objRow[conCurrEduClsStu.GetScoreTimes].ToString().Trim()); //获得成绩次数
objCurrEduClsStuEN.Score = objRow[conCurrEduClsStu.Score] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[conCurrEduClsStu.Score].ToString().Trim()); //得分
objCurrEduClsStuEN.TotalScores = objRow[conCurrEduClsStu.TotalScores] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[conCurrEduClsStu.TotalScores].ToString().Trim()); //总分值
objCurrEduClsStuEN.Ranking = objRow[conCurrEduClsStu.Ranking] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conCurrEduClsStu.Ranking].ToString().Trim()); //名次
objCurrEduClsStuEN.Percentile = objRow[conCurrEduClsStu.Percentile] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[conCurrEduClsStu.Percentile].ToString().Trim()); //百分位
objCurrEduClsStuEN.Ranking2 = objRow[conCurrEduClsStu.Ranking2] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conCurrEduClsStu.Ranking2].ToString().Trim()); //Ranking2
objCurrEduClsStuEN.Percentile2 = objRow[conCurrEduClsStu.Percentile2] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[conCurrEduClsStu.Percentile2].ToString().Trim()); //Percentile2
objCurrEduClsStuEN.Ranking3 = objRow[conCurrEduClsStu.Ranking3] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conCurrEduClsStu.Ranking3].ToString().Trim()); //Ranking3
objCurrEduClsStuEN.Percentile3 = objRow[conCurrEduClsStu.Percentile3] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[conCurrEduClsStu.Percentile3].ToString().Trim()); //Percentile3
objCurrEduClsStuEN.Confirmed = TransNullToBool(objRow[conCurrEduClsStu.Confirmed].ToString().Trim()); //是否确认
objCurrEduClsStuEN.SchoolTerm = objRow[conCurrEduClsStu.SchoolTerm] == DBNull.Value ? null : objRow[conCurrEduClsStu.SchoolTerm].ToString().Trim(); //学期
objCurrEduClsStuEN.SchoolYear = objRow[conCurrEduClsStu.SchoolYear] == DBNull.Value ? null : objRow[conCurrEduClsStu.SchoolYear].ToString().Trim(); //学年
objCurrEduClsStuEN.ExportDate = objRow[conCurrEduClsStu.ExportDate] == DBNull.Value ? null : objRow[conCurrEduClsStu.ExportDate].ToString().Trim(); //导出日期
objCurrEduClsStuEN.SignInDate = objRow[conCurrEduClsStu.SignInDate] == DBNull.Value ? null : objRow[conCurrEduClsStu.SignInDate].ToString().Trim(); //签入时间
objCurrEduClsStuEN.SignInStateID = objRow[conCurrEduClsStu.SignInStateID] == DBNull.Value ? null : objRow[conCurrEduClsStu.SignInStateID].ToString().Trim(); //签入状态表流水号
objCurrEduClsStuEN.SignInUser = objRow[conCurrEduClsStu.SignInUser] == DBNull.Value ? null : objRow[conCurrEduClsStu.SignInUser].ToString().Trim(); //签入人
objCurrEduClsStuEN.IsOpByTeacher = TransNullToBool(objRow[conCurrEduClsStu.IsOpByTeacher].ToString().Trim()); //是否教师操作
objCurrEduClsStuEN.IsSynScore = TransNullToBool(objRow[conCurrEduClsStu.IsSynScore].ToString().Trim()); //是否同步成绩
objCurrEduClsStuEN.LastVisitedDate = objRow[conCurrEduClsStu.LastVisitedDate] == DBNull.Value ? null : objRow[conCurrEduClsStu.LastVisitedDate].ToString().Trim(); //最后访问时间
objCurrEduClsStuEN.ModifyDate = objRow[conCurrEduClsStu.ModifyDate] == DBNull.Value ? null : objRow[conCurrEduClsStu.ModifyDate].ToString().Trim(); //修改日期
objCurrEduClsStuEN.ModifyUserId = objRow[conCurrEduClsStu.ModifyUserId] == DBNull.Value ? null : objRow[conCurrEduClsStu.ModifyUserId].ToString().Trim(); //修改人
objCurrEduClsStuEN.Memo = objRow[conCurrEduClsStu.Memo] == DBNull.Value ? null : objRow[conCurrEduClsStu.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsCurrEduClsStuDA: GetObjByDataRow)", objException.Message));
}
objCurrEduClsStuEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objCurrEduClsStuEN;
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
objSQL = clsCurrEduClsStuDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsCurrEduClsStuEN._CurrTabName, conCurrEduClsStu.IdEduClsStu, 8, "");
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
objSQL = clsCurrEduClsStuDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsCurrEduClsStuEN._CurrTabName, conCurrEduClsStu.IdEduClsStu, 8, strPrefix);
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
 objSQL = clsCurrEduClsStuDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select IdEduClsStu from CurrEduClsStu where " + strCondition;
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
 objSQL = clsCurrEduClsStuDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select IdEduClsStu from CurrEduClsStu where " + strCondition;
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
 /// <param name = "lngIdEduClsStu">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(long lngIdEduClsStu)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCurrEduClsStuDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("CurrEduClsStu", "IdEduClsStu = " + ""+ lngIdEduClsStu+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsCurrEduClsStuDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCurrEduClsStuDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("CurrEduClsStu", strCondition))
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
objSQL = clsCurrEduClsStuDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("CurrEduClsStu");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsCurrEduClsStuEN objCurrEduClsStuEN)
 {
 if (objCurrEduClsStuEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objCurrEduClsStuEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCurrEduClsStuDA.GetSpecSQLObj();
strSQL = "Select * from CurrEduClsStu where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "CurrEduClsStu");
objRow = objDS.Tables["CurrEduClsStu"].NewRow();
 if (objCurrEduClsStuEN.IdCurrEduCls !=  "")
 {
objRow[conCurrEduClsStu.IdCurrEduCls] = objCurrEduClsStuEN.IdCurrEduCls; //教学班流水号
 }
 if (objCurrEduClsStuEN.IdStu !=  "")
 {
objRow[conCurrEduClsStu.IdStu] = objCurrEduClsStuEN.IdStu; //学生流水号
 }
 if (objCurrEduClsStuEN.EduClsStuStateId !=  "")
 {
objRow[conCurrEduClsStu.EduClsStuStateId] = objCurrEduClsStuEN.EduClsStuStateId; //教学班学生状态编号
 }
objRow[conCurrEduClsStu.GetScoreTimes] = objCurrEduClsStuEN.GetScoreTimes; //获得成绩次数
objRow[conCurrEduClsStu.Score] = objCurrEduClsStuEN.Score; //得分
objRow[conCurrEduClsStu.TotalScores] = objCurrEduClsStuEN.TotalScores; //总分值
objRow[conCurrEduClsStu.Ranking] = objCurrEduClsStuEN.Ranking; //名次
objRow[conCurrEduClsStu.Percentile] = objCurrEduClsStuEN.Percentile; //百分位
objRow[conCurrEduClsStu.Ranking2] = objCurrEduClsStuEN.Ranking2; //Ranking2
objRow[conCurrEduClsStu.Percentile2] = objCurrEduClsStuEN.Percentile2; //Percentile2
objRow[conCurrEduClsStu.Ranking3] = objCurrEduClsStuEN.Ranking3; //Ranking3
objRow[conCurrEduClsStu.Percentile3] = objCurrEduClsStuEN.Percentile3; //Percentile3
objRow[conCurrEduClsStu.Confirmed] = objCurrEduClsStuEN.Confirmed; //是否确认
 if (objCurrEduClsStuEN.SchoolTerm !=  "")
 {
objRow[conCurrEduClsStu.SchoolTerm] = objCurrEduClsStuEN.SchoolTerm; //学期
 }
 if (objCurrEduClsStuEN.SchoolYear !=  "")
 {
objRow[conCurrEduClsStu.SchoolYear] = objCurrEduClsStuEN.SchoolYear; //学年
 }
 if (objCurrEduClsStuEN.ExportDate !=  "")
 {
objRow[conCurrEduClsStu.ExportDate] = objCurrEduClsStuEN.ExportDate; //导出日期
 }
 if (objCurrEduClsStuEN.SignInDate !=  "")
 {
objRow[conCurrEduClsStu.SignInDate] = objCurrEduClsStuEN.SignInDate; //签入时间
 }
 if (objCurrEduClsStuEN.SignInStateID !=  "")
 {
objRow[conCurrEduClsStu.SignInStateID] = objCurrEduClsStuEN.SignInStateID; //签入状态表流水号
 }
 if (objCurrEduClsStuEN.SignInUser !=  "")
 {
objRow[conCurrEduClsStu.SignInUser] = objCurrEduClsStuEN.SignInUser; //签入人
 }
objRow[conCurrEduClsStu.IsOpByTeacher] = objCurrEduClsStuEN.IsOpByTeacher; //是否教师操作
objRow[conCurrEduClsStu.IsSynScore] = objCurrEduClsStuEN.IsSynScore; //是否同步成绩
 if (objCurrEduClsStuEN.LastVisitedDate !=  "")
 {
objRow[conCurrEduClsStu.LastVisitedDate] = objCurrEduClsStuEN.LastVisitedDate; //最后访问时间
 }
 if (objCurrEduClsStuEN.ModifyDate !=  "")
 {
objRow[conCurrEduClsStu.ModifyDate] = objCurrEduClsStuEN.ModifyDate; //修改日期
 }
 if (objCurrEduClsStuEN.ModifyUserId !=  "")
 {
objRow[conCurrEduClsStu.ModifyUserId] = objCurrEduClsStuEN.ModifyUserId; //修改人
 }
 if (objCurrEduClsStuEN.Memo !=  "")
 {
objRow[conCurrEduClsStu.Memo] = objCurrEduClsStuEN.Memo; //备注
 }
objDS.Tables[clsCurrEduClsStuEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsCurrEduClsStuEN._CurrTabName);
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
 /// <param name = "objCurrEduClsStuEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsCurrEduClsStuEN objCurrEduClsStuEN)
{
 if (objCurrEduClsStuEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objCurrEduClsStuEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objCurrEduClsStuEN.IdCurrEduCls  ==  "")
 {
 objCurrEduClsStuEN.IdCurrEduCls = null;
 }
 if (objCurrEduClsStuEN.IdCurrEduCls !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduClsStu.IdCurrEduCls);
 var strIdCurrEduCls = objCurrEduClsStuEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCurrEduCls + "'");
 }
 
 if (objCurrEduClsStuEN.IdStu  ==  "")
 {
 objCurrEduClsStuEN.IdStu = null;
 }
 if (objCurrEduClsStuEN.IdStu !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduClsStu.IdStu);
 var strIdStu = objCurrEduClsStuEN.IdStu.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdStu + "'");
 }
 
 if (objCurrEduClsStuEN.EduClsStuStateId !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduClsStu.EduClsStuStateId);
 var strEduClsStuStateId = objCurrEduClsStuEN.EduClsStuStateId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strEduClsStuStateId + "'");
 }
 
 if (objCurrEduClsStuEN.GetScoreTimes !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduClsStu.GetScoreTimes);
 arrValueListForInsert.Add(objCurrEduClsStuEN.GetScoreTimes.ToString());
 }
 
 if (objCurrEduClsStuEN.Score !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduClsStu.Score);
 arrValueListForInsert.Add(objCurrEduClsStuEN.Score.ToString());
 }
 
 if (objCurrEduClsStuEN.TotalScores !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduClsStu.TotalScores);
 arrValueListForInsert.Add(objCurrEduClsStuEN.TotalScores.ToString());
 }
 
 if (objCurrEduClsStuEN.Ranking !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduClsStu.Ranking);
 arrValueListForInsert.Add(objCurrEduClsStuEN.Ranking.ToString());
 }
 
 if (objCurrEduClsStuEN.Percentile !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduClsStu.Percentile);
 arrValueListForInsert.Add(objCurrEduClsStuEN.Percentile.ToString());
 }
 
 if (objCurrEduClsStuEN.Ranking2 !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduClsStu.Ranking2);
 arrValueListForInsert.Add(objCurrEduClsStuEN.Ranking2.ToString());
 }
 
 if (objCurrEduClsStuEN.Percentile2 !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduClsStu.Percentile2);
 arrValueListForInsert.Add(objCurrEduClsStuEN.Percentile2.ToString());
 }
 
 if (objCurrEduClsStuEN.Ranking3 !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduClsStu.Ranking3);
 arrValueListForInsert.Add(objCurrEduClsStuEN.Ranking3.ToString());
 }
 
 if (objCurrEduClsStuEN.Percentile3 !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduClsStu.Percentile3);
 arrValueListForInsert.Add(objCurrEduClsStuEN.Percentile3.ToString());
 }
 
 arrFieldListForInsert.Add(conCurrEduClsStu.Confirmed);
 arrValueListForInsert.Add("'" + (objCurrEduClsStuEN.Confirmed  ==  false ? "0" : "1") + "'");
 
 if (objCurrEduClsStuEN.SchoolTerm !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduClsStu.SchoolTerm);
 var strSchoolTerm = objCurrEduClsStuEN.SchoolTerm.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSchoolTerm + "'");
 }
 
 if (objCurrEduClsStuEN.SchoolYear !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduClsStu.SchoolYear);
 var strSchoolYear = objCurrEduClsStuEN.SchoolYear.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSchoolYear + "'");
 }
 
 if (objCurrEduClsStuEN.ExportDate !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduClsStu.ExportDate);
 var strExportDate = objCurrEduClsStuEN.ExportDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strExportDate + "'");
 }
 
 if (objCurrEduClsStuEN.SignInDate !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduClsStu.SignInDate);
 var strSignInDate = objCurrEduClsStuEN.SignInDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSignInDate + "'");
 }
 
 if (objCurrEduClsStuEN.SignInStateID !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduClsStu.SignInStateID);
 var strSignInStateID = objCurrEduClsStuEN.SignInStateID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSignInStateID + "'");
 }
 
 if (objCurrEduClsStuEN.SignInUser !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduClsStu.SignInUser);
 var strSignInUser = objCurrEduClsStuEN.SignInUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSignInUser + "'");
 }
 
 arrFieldListForInsert.Add(conCurrEduClsStu.IsOpByTeacher);
 arrValueListForInsert.Add("'" + (objCurrEduClsStuEN.IsOpByTeacher  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conCurrEduClsStu.IsSynScore);
 arrValueListForInsert.Add("'" + (objCurrEduClsStuEN.IsSynScore  ==  false ? "0" : "1") + "'");
 
 if (objCurrEduClsStuEN.LastVisitedDate !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduClsStu.LastVisitedDate);
 var strLastVisitedDate = objCurrEduClsStuEN.LastVisitedDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLastVisitedDate + "'");
 }
 
 if (objCurrEduClsStuEN.ModifyDate !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduClsStu.ModifyDate);
 var strModifyDate = objCurrEduClsStuEN.ModifyDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strModifyDate + "'");
 }
 
 if (objCurrEduClsStuEN.ModifyUserId !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduClsStu.ModifyUserId);
 var strModifyUserId = objCurrEduClsStuEN.ModifyUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strModifyUserId + "'");
 }
 
 if (objCurrEduClsStuEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduClsStu.Memo);
 var strMemo = objCurrEduClsStuEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into CurrEduClsStu");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCurrEduClsStuDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objCurrEduClsStuEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsCurrEduClsStuEN objCurrEduClsStuEN)
{
 if (objCurrEduClsStuEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objCurrEduClsStuEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objCurrEduClsStuEN.IdCurrEduCls  ==  "")
 {
 objCurrEduClsStuEN.IdCurrEduCls = null;
 }
 if (objCurrEduClsStuEN.IdCurrEduCls !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduClsStu.IdCurrEduCls);
 var strIdCurrEduCls = objCurrEduClsStuEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCurrEduCls + "'");
 }
 
 if (objCurrEduClsStuEN.IdStu  ==  "")
 {
 objCurrEduClsStuEN.IdStu = null;
 }
 if (objCurrEduClsStuEN.IdStu !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduClsStu.IdStu);
 var strIdStu = objCurrEduClsStuEN.IdStu.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdStu + "'");
 }
 
 if (objCurrEduClsStuEN.EduClsStuStateId !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduClsStu.EduClsStuStateId);
 var strEduClsStuStateId = objCurrEduClsStuEN.EduClsStuStateId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strEduClsStuStateId + "'");
 }
 
 if (objCurrEduClsStuEN.GetScoreTimes !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduClsStu.GetScoreTimes);
 arrValueListForInsert.Add(objCurrEduClsStuEN.GetScoreTimes.ToString());
 }
 
 if (objCurrEduClsStuEN.Score !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduClsStu.Score);
 arrValueListForInsert.Add(objCurrEduClsStuEN.Score.ToString());
 }
 
 if (objCurrEduClsStuEN.TotalScores !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduClsStu.TotalScores);
 arrValueListForInsert.Add(objCurrEduClsStuEN.TotalScores.ToString());
 }
 
 if (objCurrEduClsStuEN.Ranking !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduClsStu.Ranking);
 arrValueListForInsert.Add(objCurrEduClsStuEN.Ranking.ToString());
 }
 
 if (objCurrEduClsStuEN.Percentile !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduClsStu.Percentile);
 arrValueListForInsert.Add(objCurrEduClsStuEN.Percentile.ToString());
 }
 
 if (objCurrEduClsStuEN.Ranking2 !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduClsStu.Ranking2);
 arrValueListForInsert.Add(objCurrEduClsStuEN.Ranking2.ToString());
 }
 
 if (objCurrEduClsStuEN.Percentile2 !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduClsStu.Percentile2);
 arrValueListForInsert.Add(objCurrEduClsStuEN.Percentile2.ToString());
 }
 
 if (objCurrEduClsStuEN.Ranking3 !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduClsStu.Ranking3);
 arrValueListForInsert.Add(objCurrEduClsStuEN.Ranking3.ToString());
 }
 
 if (objCurrEduClsStuEN.Percentile3 !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduClsStu.Percentile3);
 arrValueListForInsert.Add(objCurrEduClsStuEN.Percentile3.ToString());
 }
 
 arrFieldListForInsert.Add(conCurrEduClsStu.Confirmed);
 arrValueListForInsert.Add("'" + (objCurrEduClsStuEN.Confirmed  ==  false ? "0" : "1") + "'");
 
 if (objCurrEduClsStuEN.SchoolTerm !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduClsStu.SchoolTerm);
 var strSchoolTerm = objCurrEduClsStuEN.SchoolTerm.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSchoolTerm + "'");
 }
 
 if (objCurrEduClsStuEN.SchoolYear !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduClsStu.SchoolYear);
 var strSchoolYear = objCurrEduClsStuEN.SchoolYear.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSchoolYear + "'");
 }
 
 if (objCurrEduClsStuEN.ExportDate !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduClsStu.ExportDate);
 var strExportDate = objCurrEduClsStuEN.ExportDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strExportDate + "'");
 }
 
 if (objCurrEduClsStuEN.SignInDate !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduClsStu.SignInDate);
 var strSignInDate = objCurrEduClsStuEN.SignInDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSignInDate + "'");
 }
 
 if (objCurrEduClsStuEN.SignInStateID !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduClsStu.SignInStateID);
 var strSignInStateID = objCurrEduClsStuEN.SignInStateID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSignInStateID + "'");
 }
 
 if (objCurrEduClsStuEN.SignInUser !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduClsStu.SignInUser);
 var strSignInUser = objCurrEduClsStuEN.SignInUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSignInUser + "'");
 }
 
 arrFieldListForInsert.Add(conCurrEduClsStu.IsOpByTeacher);
 arrValueListForInsert.Add("'" + (objCurrEduClsStuEN.IsOpByTeacher  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conCurrEduClsStu.IsSynScore);
 arrValueListForInsert.Add("'" + (objCurrEduClsStuEN.IsSynScore  ==  false ? "0" : "1") + "'");
 
 if (objCurrEduClsStuEN.LastVisitedDate !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduClsStu.LastVisitedDate);
 var strLastVisitedDate = objCurrEduClsStuEN.LastVisitedDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLastVisitedDate + "'");
 }
 
 if (objCurrEduClsStuEN.ModifyDate !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduClsStu.ModifyDate);
 var strModifyDate = objCurrEduClsStuEN.ModifyDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strModifyDate + "'");
 }
 
 if (objCurrEduClsStuEN.ModifyUserId !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduClsStu.ModifyUserId);
 var strModifyUserId = objCurrEduClsStuEN.ModifyUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strModifyUserId + "'");
 }
 
 if (objCurrEduClsStuEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduClsStu.Memo);
 var strMemo = objCurrEduClsStuEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into CurrEduClsStu");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCurrEduClsStuDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString()).Rows[0][0].ToString();
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objCurrEduClsStuEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsCurrEduClsStuEN objCurrEduClsStuEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objCurrEduClsStuEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objCurrEduClsStuEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objCurrEduClsStuEN.IdCurrEduCls  ==  "")
 {
 objCurrEduClsStuEN.IdCurrEduCls = null;
 }
 if (objCurrEduClsStuEN.IdCurrEduCls !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduClsStu.IdCurrEduCls);
 var strIdCurrEduCls = objCurrEduClsStuEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCurrEduCls + "'");
 }
 
 if (objCurrEduClsStuEN.IdStu  ==  "")
 {
 objCurrEduClsStuEN.IdStu = null;
 }
 if (objCurrEduClsStuEN.IdStu !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduClsStu.IdStu);
 var strIdStu = objCurrEduClsStuEN.IdStu.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdStu + "'");
 }
 
 if (objCurrEduClsStuEN.EduClsStuStateId !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduClsStu.EduClsStuStateId);
 var strEduClsStuStateId = objCurrEduClsStuEN.EduClsStuStateId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strEduClsStuStateId + "'");
 }
 
 if (objCurrEduClsStuEN.GetScoreTimes !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduClsStu.GetScoreTimes);
 arrValueListForInsert.Add(objCurrEduClsStuEN.GetScoreTimes.ToString());
 }
 
 if (objCurrEduClsStuEN.Score !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduClsStu.Score);
 arrValueListForInsert.Add(objCurrEduClsStuEN.Score.ToString());
 }
 
 if (objCurrEduClsStuEN.TotalScores !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduClsStu.TotalScores);
 arrValueListForInsert.Add(objCurrEduClsStuEN.TotalScores.ToString());
 }
 
 if (objCurrEduClsStuEN.Ranking !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduClsStu.Ranking);
 arrValueListForInsert.Add(objCurrEduClsStuEN.Ranking.ToString());
 }
 
 if (objCurrEduClsStuEN.Percentile !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduClsStu.Percentile);
 arrValueListForInsert.Add(objCurrEduClsStuEN.Percentile.ToString());
 }
 
 if (objCurrEduClsStuEN.Ranking2 !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduClsStu.Ranking2);
 arrValueListForInsert.Add(objCurrEduClsStuEN.Ranking2.ToString());
 }
 
 if (objCurrEduClsStuEN.Percentile2 !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduClsStu.Percentile2);
 arrValueListForInsert.Add(objCurrEduClsStuEN.Percentile2.ToString());
 }
 
 if (objCurrEduClsStuEN.Ranking3 !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduClsStu.Ranking3);
 arrValueListForInsert.Add(objCurrEduClsStuEN.Ranking3.ToString());
 }
 
 if (objCurrEduClsStuEN.Percentile3 !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduClsStu.Percentile3);
 arrValueListForInsert.Add(objCurrEduClsStuEN.Percentile3.ToString());
 }
 
 arrFieldListForInsert.Add(conCurrEduClsStu.Confirmed);
 arrValueListForInsert.Add("'" + (objCurrEduClsStuEN.Confirmed  ==  false ? "0" : "1") + "'");
 
 if (objCurrEduClsStuEN.SchoolTerm !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduClsStu.SchoolTerm);
 var strSchoolTerm = objCurrEduClsStuEN.SchoolTerm.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSchoolTerm + "'");
 }
 
 if (objCurrEduClsStuEN.SchoolYear !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduClsStu.SchoolYear);
 var strSchoolYear = objCurrEduClsStuEN.SchoolYear.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSchoolYear + "'");
 }
 
 if (objCurrEduClsStuEN.ExportDate !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduClsStu.ExportDate);
 var strExportDate = objCurrEduClsStuEN.ExportDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strExportDate + "'");
 }
 
 if (objCurrEduClsStuEN.SignInDate !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduClsStu.SignInDate);
 var strSignInDate = objCurrEduClsStuEN.SignInDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSignInDate + "'");
 }
 
 if (objCurrEduClsStuEN.SignInStateID !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduClsStu.SignInStateID);
 var strSignInStateID = objCurrEduClsStuEN.SignInStateID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSignInStateID + "'");
 }
 
 if (objCurrEduClsStuEN.SignInUser !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduClsStu.SignInUser);
 var strSignInUser = objCurrEduClsStuEN.SignInUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSignInUser + "'");
 }
 
 arrFieldListForInsert.Add(conCurrEduClsStu.IsOpByTeacher);
 arrValueListForInsert.Add("'" + (objCurrEduClsStuEN.IsOpByTeacher  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conCurrEduClsStu.IsSynScore);
 arrValueListForInsert.Add("'" + (objCurrEduClsStuEN.IsSynScore  ==  false ? "0" : "1") + "'");
 
 if (objCurrEduClsStuEN.LastVisitedDate !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduClsStu.LastVisitedDate);
 var strLastVisitedDate = objCurrEduClsStuEN.LastVisitedDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLastVisitedDate + "'");
 }
 
 if (objCurrEduClsStuEN.ModifyDate !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduClsStu.ModifyDate);
 var strModifyDate = objCurrEduClsStuEN.ModifyDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strModifyDate + "'");
 }
 
 if (objCurrEduClsStuEN.ModifyUserId !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduClsStu.ModifyUserId);
 var strModifyUserId = objCurrEduClsStuEN.ModifyUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strModifyUserId + "'");
 }
 
 if (objCurrEduClsStuEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduClsStu.Memo);
 var strMemo = objCurrEduClsStuEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into CurrEduClsStu");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCurrEduClsStuDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString(), objSqlConnection, objSqlTransaction).Rows[0][0].ToString();
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objCurrEduClsStuEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsCurrEduClsStuEN objCurrEduClsStuEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objCurrEduClsStuEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objCurrEduClsStuEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objCurrEduClsStuEN.IdCurrEduCls  ==  "")
 {
 objCurrEduClsStuEN.IdCurrEduCls = null;
 }
 if (objCurrEduClsStuEN.IdCurrEduCls !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduClsStu.IdCurrEduCls);
 var strIdCurrEduCls = objCurrEduClsStuEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCurrEduCls + "'");
 }
 
 if (objCurrEduClsStuEN.IdStu  ==  "")
 {
 objCurrEduClsStuEN.IdStu = null;
 }
 if (objCurrEduClsStuEN.IdStu !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduClsStu.IdStu);
 var strIdStu = objCurrEduClsStuEN.IdStu.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdStu + "'");
 }
 
 if (objCurrEduClsStuEN.EduClsStuStateId !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduClsStu.EduClsStuStateId);
 var strEduClsStuStateId = objCurrEduClsStuEN.EduClsStuStateId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strEduClsStuStateId + "'");
 }
 
 if (objCurrEduClsStuEN.GetScoreTimes !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduClsStu.GetScoreTimes);
 arrValueListForInsert.Add(objCurrEduClsStuEN.GetScoreTimes.ToString());
 }
 
 if (objCurrEduClsStuEN.Score !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduClsStu.Score);
 arrValueListForInsert.Add(objCurrEduClsStuEN.Score.ToString());
 }
 
 if (objCurrEduClsStuEN.TotalScores !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduClsStu.TotalScores);
 arrValueListForInsert.Add(objCurrEduClsStuEN.TotalScores.ToString());
 }
 
 if (objCurrEduClsStuEN.Ranking !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduClsStu.Ranking);
 arrValueListForInsert.Add(objCurrEduClsStuEN.Ranking.ToString());
 }
 
 if (objCurrEduClsStuEN.Percentile !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduClsStu.Percentile);
 arrValueListForInsert.Add(objCurrEduClsStuEN.Percentile.ToString());
 }
 
 if (objCurrEduClsStuEN.Ranking2 !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduClsStu.Ranking2);
 arrValueListForInsert.Add(objCurrEduClsStuEN.Ranking2.ToString());
 }
 
 if (objCurrEduClsStuEN.Percentile2 !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduClsStu.Percentile2);
 arrValueListForInsert.Add(objCurrEduClsStuEN.Percentile2.ToString());
 }
 
 if (objCurrEduClsStuEN.Ranking3 !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduClsStu.Ranking3);
 arrValueListForInsert.Add(objCurrEduClsStuEN.Ranking3.ToString());
 }
 
 if (objCurrEduClsStuEN.Percentile3 !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduClsStu.Percentile3);
 arrValueListForInsert.Add(objCurrEduClsStuEN.Percentile3.ToString());
 }
 
 arrFieldListForInsert.Add(conCurrEduClsStu.Confirmed);
 arrValueListForInsert.Add("'" + (objCurrEduClsStuEN.Confirmed  ==  false ? "0" : "1") + "'");
 
 if (objCurrEduClsStuEN.SchoolTerm !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduClsStu.SchoolTerm);
 var strSchoolTerm = objCurrEduClsStuEN.SchoolTerm.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSchoolTerm + "'");
 }
 
 if (objCurrEduClsStuEN.SchoolYear !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduClsStu.SchoolYear);
 var strSchoolYear = objCurrEduClsStuEN.SchoolYear.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSchoolYear + "'");
 }
 
 if (objCurrEduClsStuEN.ExportDate !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduClsStu.ExportDate);
 var strExportDate = objCurrEduClsStuEN.ExportDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strExportDate + "'");
 }
 
 if (objCurrEduClsStuEN.SignInDate !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduClsStu.SignInDate);
 var strSignInDate = objCurrEduClsStuEN.SignInDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSignInDate + "'");
 }
 
 if (objCurrEduClsStuEN.SignInStateID !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduClsStu.SignInStateID);
 var strSignInStateID = objCurrEduClsStuEN.SignInStateID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSignInStateID + "'");
 }
 
 if (objCurrEduClsStuEN.SignInUser !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduClsStu.SignInUser);
 var strSignInUser = objCurrEduClsStuEN.SignInUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSignInUser + "'");
 }
 
 arrFieldListForInsert.Add(conCurrEduClsStu.IsOpByTeacher);
 arrValueListForInsert.Add("'" + (objCurrEduClsStuEN.IsOpByTeacher  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conCurrEduClsStu.IsSynScore);
 arrValueListForInsert.Add("'" + (objCurrEduClsStuEN.IsSynScore  ==  false ? "0" : "1") + "'");
 
 if (objCurrEduClsStuEN.LastVisitedDate !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduClsStu.LastVisitedDate);
 var strLastVisitedDate = objCurrEduClsStuEN.LastVisitedDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLastVisitedDate + "'");
 }
 
 if (objCurrEduClsStuEN.ModifyDate !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduClsStu.ModifyDate);
 var strModifyDate = objCurrEduClsStuEN.ModifyDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strModifyDate + "'");
 }
 
 if (objCurrEduClsStuEN.ModifyUserId !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduClsStu.ModifyUserId);
 var strModifyUserId = objCurrEduClsStuEN.ModifyUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strModifyUserId + "'");
 }
 
 if (objCurrEduClsStuEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduClsStu.Memo);
 var strMemo = objCurrEduClsStuEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into CurrEduClsStu");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCurrEduClsStuDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewCurrEduClsStus(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCurrEduClsStuDA.GetSpecSQLObj();
strSQL = "Select * from CurrEduClsStu where IdEduClsStu = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "CurrEduClsStu");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
long lngIdEduClsStu = TransNullToInt(oRow[conCurrEduClsStu.IdEduClsStu].ToString().Trim());
if (IsExist(lngIdEduClsStu))
{
 string strResult = "关键字变量值为:" + string.Format("IdEduClsStu = {0}", lngIdEduClsStu) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsCurrEduClsStuEN._CurrTabName ].NewRow();
objRow[conCurrEduClsStu.IdCurrEduCls] = oRow[conCurrEduClsStu.IdCurrEduCls].ToString().Trim(); //教学班流水号
objRow[conCurrEduClsStu.IdStu] = oRow[conCurrEduClsStu.IdStu].ToString().Trim(); //学生流水号
objRow[conCurrEduClsStu.EduClsStuStateId] = oRow[conCurrEduClsStu.EduClsStuStateId].ToString().Trim(); //教学班学生状态编号
objRow[conCurrEduClsStu.GetScoreTimes] = oRow[conCurrEduClsStu.GetScoreTimes].ToString().Trim(); //获得成绩次数
objRow[conCurrEduClsStu.Score] = oRow[conCurrEduClsStu.Score].ToString().Trim(); //得分
objRow[conCurrEduClsStu.TotalScores] = oRow[conCurrEduClsStu.TotalScores].ToString().Trim(); //总分值
objRow[conCurrEduClsStu.Ranking] = oRow[conCurrEduClsStu.Ranking].ToString().Trim(); //名次
objRow[conCurrEduClsStu.Percentile] = oRow[conCurrEduClsStu.Percentile].ToString().Trim(); //百分位
objRow[conCurrEduClsStu.Ranking2] = oRow[conCurrEduClsStu.Ranking2].ToString().Trim(); //Ranking2
objRow[conCurrEduClsStu.Percentile2] = oRow[conCurrEduClsStu.Percentile2].ToString().Trim(); //Percentile2
objRow[conCurrEduClsStu.Ranking3] = oRow[conCurrEduClsStu.Ranking3].ToString().Trim(); //Ranking3
objRow[conCurrEduClsStu.Percentile3] = oRow[conCurrEduClsStu.Percentile3].ToString().Trim(); //Percentile3
objRow[conCurrEduClsStu.Confirmed] = oRow[conCurrEduClsStu.Confirmed].ToString().Trim(); //是否确认
objRow[conCurrEduClsStu.SchoolTerm] = oRow[conCurrEduClsStu.SchoolTerm].ToString().Trim(); //学期
objRow[conCurrEduClsStu.SchoolYear] = oRow[conCurrEduClsStu.SchoolYear].ToString().Trim(); //学年
objRow[conCurrEduClsStu.ExportDate] = oRow[conCurrEduClsStu.ExportDate].ToString().Trim(); //导出日期
objRow[conCurrEduClsStu.SignInDate] = oRow[conCurrEduClsStu.SignInDate].ToString().Trim(); //签入时间
objRow[conCurrEduClsStu.SignInStateID] = oRow[conCurrEduClsStu.SignInStateID].ToString().Trim(); //签入状态表流水号
objRow[conCurrEduClsStu.SignInUser] = oRow[conCurrEduClsStu.SignInUser].ToString().Trim(); //签入人
objRow[conCurrEduClsStu.IsOpByTeacher] = oRow[conCurrEduClsStu.IsOpByTeacher].ToString().Trim(); //是否教师操作
objRow[conCurrEduClsStu.IsSynScore] = oRow[conCurrEduClsStu.IsSynScore].ToString().Trim(); //是否同步成绩
objRow[conCurrEduClsStu.LastVisitedDate] = oRow[conCurrEduClsStu.LastVisitedDate].ToString().Trim(); //最后访问时间
objRow[conCurrEduClsStu.ModifyDate] = oRow[conCurrEduClsStu.ModifyDate].ToString().Trim(); //修改日期
objRow[conCurrEduClsStu.ModifyUserId] = oRow[conCurrEduClsStu.ModifyUserId].ToString().Trim(); //修改人
objRow[conCurrEduClsStu.Memo] = oRow[conCurrEduClsStu.Memo].ToString().Trim(); //备注
 objDS.Tables[clsCurrEduClsStuEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsCurrEduClsStuEN._CurrTabName);
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
 /// <param name = "objCurrEduClsStuEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsCurrEduClsStuEN objCurrEduClsStuEN)
{
 if (objCurrEduClsStuEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objCurrEduClsStuEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCurrEduClsStuDA.GetSpecSQLObj();
strSQL = "Select * from CurrEduClsStu where IdEduClsStu = " + ""+ objCurrEduClsStuEN.IdEduClsStu+"";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsCurrEduClsStuEN._CurrTabName);
if (objDS.Tables[clsCurrEduClsStuEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:IdEduClsStu = " + ""+ objCurrEduClsStuEN.IdEduClsStu+"");
return false;
}
objRow = objDS.Tables[clsCurrEduClsStuEN._CurrTabName].Rows[0];
 if (objCurrEduClsStuEN.IsUpdated(conCurrEduClsStu.IdCurrEduCls))
 {
objRow[conCurrEduClsStu.IdCurrEduCls] = objCurrEduClsStuEN.IdCurrEduCls; //教学班流水号
 }
 if (objCurrEduClsStuEN.IsUpdated(conCurrEduClsStu.IdStu))
 {
objRow[conCurrEduClsStu.IdStu] = objCurrEduClsStuEN.IdStu; //学生流水号
 }
 if (objCurrEduClsStuEN.IsUpdated(conCurrEduClsStu.EduClsStuStateId))
 {
objRow[conCurrEduClsStu.EduClsStuStateId] = objCurrEduClsStuEN.EduClsStuStateId; //教学班学生状态编号
 }
 if (objCurrEduClsStuEN.IsUpdated(conCurrEduClsStu.GetScoreTimes))
 {
objRow[conCurrEduClsStu.GetScoreTimes] = objCurrEduClsStuEN.GetScoreTimes; //获得成绩次数
 }
 if (objCurrEduClsStuEN.IsUpdated(conCurrEduClsStu.Score))
 {
objRow[conCurrEduClsStu.Score] = objCurrEduClsStuEN.Score; //得分
 }
 if (objCurrEduClsStuEN.IsUpdated(conCurrEduClsStu.TotalScores))
 {
objRow[conCurrEduClsStu.TotalScores] = objCurrEduClsStuEN.TotalScores; //总分值
 }
 if (objCurrEduClsStuEN.IsUpdated(conCurrEduClsStu.Ranking))
 {
objRow[conCurrEduClsStu.Ranking] = objCurrEduClsStuEN.Ranking; //名次
 }
 if (objCurrEduClsStuEN.IsUpdated(conCurrEduClsStu.Percentile))
 {
objRow[conCurrEduClsStu.Percentile] = objCurrEduClsStuEN.Percentile; //百分位
 }
 if (objCurrEduClsStuEN.IsUpdated(conCurrEduClsStu.Ranking2))
 {
objRow[conCurrEduClsStu.Ranking2] = objCurrEduClsStuEN.Ranking2; //Ranking2
 }
 if (objCurrEduClsStuEN.IsUpdated(conCurrEduClsStu.Percentile2))
 {
objRow[conCurrEduClsStu.Percentile2] = objCurrEduClsStuEN.Percentile2; //Percentile2
 }
 if (objCurrEduClsStuEN.IsUpdated(conCurrEduClsStu.Ranking3))
 {
objRow[conCurrEduClsStu.Ranking3] = objCurrEduClsStuEN.Ranking3; //Ranking3
 }
 if (objCurrEduClsStuEN.IsUpdated(conCurrEduClsStu.Percentile3))
 {
objRow[conCurrEduClsStu.Percentile3] = objCurrEduClsStuEN.Percentile3; //Percentile3
 }
 if (objCurrEduClsStuEN.IsUpdated(conCurrEduClsStu.Confirmed))
 {
objRow[conCurrEduClsStu.Confirmed] = objCurrEduClsStuEN.Confirmed; //是否确认
 }
 if (objCurrEduClsStuEN.IsUpdated(conCurrEduClsStu.SchoolTerm))
 {
objRow[conCurrEduClsStu.SchoolTerm] = objCurrEduClsStuEN.SchoolTerm; //学期
 }
 if (objCurrEduClsStuEN.IsUpdated(conCurrEduClsStu.SchoolYear))
 {
objRow[conCurrEduClsStu.SchoolYear] = objCurrEduClsStuEN.SchoolYear; //学年
 }
 if (objCurrEduClsStuEN.IsUpdated(conCurrEduClsStu.ExportDate))
 {
objRow[conCurrEduClsStu.ExportDate] = objCurrEduClsStuEN.ExportDate; //导出日期
 }
 if (objCurrEduClsStuEN.IsUpdated(conCurrEduClsStu.SignInDate))
 {
objRow[conCurrEduClsStu.SignInDate] = objCurrEduClsStuEN.SignInDate; //签入时间
 }
 if (objCurrEduClsStuEN.IsUpdated(conCurrEduClsStu.SignInStateID))
 {
objRow[conCurrEduClsStu.SignInStateID] = objCurrEduClsStuEN.SignInStateID; //签入状态表流水号
 }
 if (objCurrEduClsStuEN.IsUpdated(conCurrEduClsStu.SignInUser))
 {
objRow[conCurrEduClsStu.SignInUser] = objCurrEduClsStuEN.SignInUser; //签入人
 }
 if (objCurrEduClsStuEN.IsUpdated(conCurrEduClsStu.IsOpByTeacher))
 {
objRow[conCurrEduClsStu.IsOpByTeacher] = objCurrEduClsStuEN.IsOpByTeacher; //是否教师操作
 }
 if (objCurrEduClsStuEN.IsUpdated(conCurrEduClsStu.IsSynScore))
 {
objRow[conCurrEduClsStu.IsSynScore] = objCurrEduClsStuEN.IsSynScore; //是否同步成绩
 }
 if (objCurrEduClsStuEN.IsUpdated(conCurrEduClsStu.LastVisitedDate))
 {
objRow[conCurrEduClsStu.LastVisitedDate] = objCurrEduClsStuEN.LastVisitedDate; //最后访问时间
 }
 if (objCurrEduClsStuEN.IsUpdated(conCurrEduClsStu.ModifyDate))
 {
objRow[conCurrEduClsStu.ModifyDate] = objCurrEduClsStuEN.ModifyDate; //修改日期
 }
 if (objCurrEduClsStuEN.IsUpdated(conCurrEduClsStu.ModifyUserId))
 {
objRow[conCurrEduClsStu.ModifyUserId] = objCurrEduClsStuEN.ModifyUserId; //修改人
 }
 if (objCurrEduClsStuEN.IsUpdated(conCurrEduClsStu.Memo))
 {
objRow[conCurrEduClsStu.Memo] = objCurrEduClsStuEN.Memo; //备注
 }
try
{
objDA.Update(objDS, clsCurrEduClsStuEN._CurrTabName);
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
 /// <param name = "objCurrEduClsStuEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsCurrEduClsStuEN objCurrEduClsStuEN)
{
 if (objCurrEduClsStuEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objCurrEduClsStuEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCurrEduClsStuDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update CurrEduClsStu Set ");
 
 if (objCurrEduClsStuEN.IsUpdated(conCurrEduClsStu.IdCurrEduCls))
 {
 if (objCurrEduClsStuEN.IdCurrEduCls  ==  "")
 {
 objCurrEduClsStuEN.IdCurrEduCls = null;
 }
 if (objCurrEduClsStuEN.IdCurrEduCls !=  null)
 {
 var strIdCurrEduCls = objCurrEduClsStuEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdCurrEduCls, conCurrEduClsStu.IdCurrEduCls); //教学班流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduClsStu.IdCurrEduCls); //教学班流水号
 }
 }
 
 if (objCurrEduClsStuEN.IsUpdated(conCurrEduClsStu.IdStu))
 {
 if (objCurrEduClsStuEN.IdStu  ==  "")
 {
 objCurrEduClsStuEN.IdStu = null;
 }
 if (objCurrEduClsStuEN.IdStu !=  null)
 {
 var strIdStu = objCurrEduClsStuEN.IdStu.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdStu, conCurrEduClsStu.IdStu); //学生流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduClsStu.IdStu); //学生流水号
 }
 }
 
 if (objCurrEduClsStuEN.IsUpdated(conCurrEduClsStu.EduClsStuStateId))
 {
 if (objCurrEduClsStuEN.EduClsStuStateId !=  null)
 {
 var strEduClsStuStateId = objCurrEduClsStuEN.EduClsStuStateId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strEduClsStuStateId, conCurrEduClsStu.EduClsStuStateId); //教学班学生状态编号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduClsStu.EduClsStuStateId); //教学班学生状态编号
 }
 }
 
 if (objCurrEduClsStuEN.IsUpdated(conCurrEduClsStu.GetScoreTimes))
 {
 if (objCurrEduClsStuEN.GetScoreTimes !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCurrEduClsStuEN.GetScoreTimes, conCurrEduClsStu.GetScoreTimes); //获得成绩次数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduClsStu.GetScoreTimes); //获得成绩次数
 }
 }
 
 if (objCurrEduClsStuEN.IsUpdated(conCurrEduClsStu.Score))
 {
 if (objCurrEduClsStuEN.Score !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCurrEduClsStuEN.Score, conCurrEduClsStu.Score); //得分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduClsStu.Score); //得分
 }
 }
 
 if (objCurrEduClsStuEN.IsUpdated(conCurrEduClsStu.TotalScores))
 {
 if (objCurrEduClsStuEN.TotalScores !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCurrEduClsStuEN.TotalScores, conCurrEduClsStu.TotalScores); //总分值
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduClsStu.TotalScores); //总分值
 }
 }
 
 if (objCurrEduClsStuEN.IsUpdated(conCurrEduClsStu.Ranking))
 {
 if (objCurrEduClsStuEN.Ranking !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCurrEduClsStuEN.Ranking, conCurrEduClsStu.Ranking); //名次
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduClsStu.Ranking); //名次
 }
 }
 
 if (objCurrEduClsStuEN.IsUpdated(conCurrEduClsStu.Percentile))
 {
 if (objCurrEduClsStuEN.Percentile !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCurrEduClsStuEN.Percentile, conCurrEduClsStu.Percentile); //百分位
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduClsStu.Percentile); //百分位
 }
 }
 
 if (objCurrEduClsStuEN.IsUpdated(conCurrEduClsStu.Ranking2))
 {
 if (objCurrEduClsStuEN.Ranking2 !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCurrEduClsStuEN.Ranking2, conCurrEduClsStu.Ranking2); //Ranking2
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduClsStu.Ranking2); //Ranking2
 }
 }
 
 if (objCurrEduClsStuEN.IsUpdated(conCurrEduClsStu.Percentile2))
 {
 if (objCurrEduClsStuEN.Percentile2 !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCurrEduClsStuEN.Percentile2, conCurrEduClsStu.Percentile2); //Percentile2
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduClsStu.Percentile2); //Percentile2
 }
 }
 
 if (objCurrEduClsStuEN.IsUpdated(conCurrEduClsStu.Ranking3))
 {
 if (objCurrEduClsStuEN.Ranking3 !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCurrEduClsStuEN.Ranking3, conCurrEduClsStu.Ranking3); //Ranking3
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduClsStu.Ranking3); //Ranking3
 }
 }
 
 if (objCurrEduClsStuEN.IsUpdated(conCurrEduClsStu.Percentile3))
 {
 if (objCurrEduClsStuEN.Percentile3 !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCurrEduClsStuEN.Percentile3, conCurrEduClsStu.Percentile3); //Percentile3
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduClsStu.Percentile3); //Percentile3
 }
 }
 
 if (objCurrEduClsStuEN.IsUpdated(conCurrEduClsStu.Confirmed))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objCurrEduClsStuEN.Confirmed == true?"1":"0", conCurrEduClsStu.Confirmed); //是否确认
 }
 
 if (objCurrEduClsStuEN.IsUpdated(conCurrEduClsStu.SchoolTerm))
 {
 if (objCurrEduClsStuEN.SchoolTerm !=  null)
 {
 var strSchoolTerm = objCurrEduClsStuEN.SchoolTerm.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSchoolTerm, conCurrEduClsStu.SchoolTerm); //学期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduClsStu.SchoolTerm); //学期
 }
 }
 
 if (objCurrEduClsStuEN.IsUpdated(conCurrEduClsStu.SchoolYear))
 {
 if (objCurrEduClsStuEN.SchoolYear !=  null)
 {
 var strSchoolYear = objCurrEduClsStuEN.SchoolYear.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSchoolYear, conCurrEduClsStu.SchoolYear); //学年
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduClsStu.SchoolYear); //学年
 }
 }
 
 if (objCurrEduClsStuEN.IsUpdated(conCurrEduClsStu.ExportDate))
 {
 if (objCurrEduClsStuEN.ExportDate !=  null)
 {
 var strExportDate = objCurrEduClsStuEN.ExportDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strExportDate, conCurrEduClsStu.ExportDate); //导出日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduClsStu.ExportDate); //导出日期
 }
 }
 
 if (objCurrEduClsStuEN.IsUpdated(conCurrEduClsStu.SignInDate))
 {
 if (objCurrEduClsStuEN.SignInDate !=  null)
 {
 var strSignInDate = objCurrEduClsStuEN.SignInDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSignInDate, conCurrEduClsStu.SignInDate); //签入时间
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduClsStu.SignInDate); //签入时间
 }
 }
 
 if (objCurrEduClsStuEN.IsUpdated(conCurrEduClsStu.SignInStateID))
 {
 if (objCurrEduClsStuEN.SignInStateID !=  null)
 {
 var strSignInStateID = objCurrEduClsStuEN.SignInStateID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSignInStateID, conCurrEduClsStu.SignInStateID); //签入状态表流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduClsStu.SignInStateID); //签入状态表流水号
 }
 }
 
 if (objCurrEduClsStuEN.IsUpdated(conCurrEduClsStu.SignInUser))
 {
 if (objCurrEduClsStuEN.SignInUser !=  null)
 {
 var strSignInUser = objCurrEduClsStuEN.SignInUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSignInUser, conCurrEduClsStu.SignInUser); //签入人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduClsStu.SignInUser); //签入人
 }
 }
 
 if (objCurrEduClsStuEN.IsUpdated(conCurrEduClsStu.IsOpByTeacher))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objCurrEduClsStuEN.IsOpByTeacher == true?"1":"0", conCurrEduClsStu.IsOpByTeacher); //是否教师操作
 }
 
 if (objCurrEduClsStuEN.IsUpdated(conCurrEduClsStu.IsSynScore))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objCurrEduClsStuEN.IsSynScore == true?"1":"0", conCurrEduClsStu.IsSynScore); //是否同步成绩
 }
 
 if (objCurrEduClsStuEN.IsUpdated(conCurrEduClsStu.LastVisitedDate))
 {
 if (objCurrEduClsStuEN.LastVisitedDate !=  null)
 {
 var strLastVisitedDate = objCurrEduClsStuEN.LastVisitedDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strLastVisitedDate, conCurrEduClsStu.LastVisitedDate); //最后访问时间
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduClsStu.LastVisitedDate); //最后访问时间
 }
 }
 
 if (objCurrEduClsStuEN.IsUpdated(conCurrEduClsStu.ModifyDate))
 {
 if (objCurrEduClsStuEN.ModifyDate !=  null)
 {
 var strModifyDate = objCurrEduClsStuEN.ModifyDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strModifyDate, conCurrEduClsStu.ModifyDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduClsStu.ModifyDate); //修改日期
 }
 }
 
 if (objCurrEduClsStuEN.IsUpdated(conCurrEduClsStu.ModifyUserId))
 {
 if (objCurrEduClsStuEN.ModifyUserId !=  null)
 {
 var strModifyUserId = objCurrEduClsStuEN.ModifyUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strModifyUserId, conCurrEduClsStu.ModifyUserId); //修改人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduClsStu.ModifyUserId); //修改人
 }
 }
 
 if (objCurrEduClsStuEN.IsUpdated(conCurrEduClsStu.Memo))
 {
 if (objCurrEduClsStuEN.Memo !=  null)
 {
 var strMemo = objCurrEduClsStuEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conCurrEduClsStu.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduClsStu.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where IdEduClsStu = {0}", objCurrEduClsStuEN.IdEduClsStu); 
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
 /// <param name = "objCurrEduClsStuEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsCurrEduClsStuEN objCurrEduClsStuEN, string strCondition)
{
 if (objCurrEduClsStuEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objCurrEduClsStuEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCurrEduClsStuDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update CurrEduClsStu Set ");
 
 if (objCurrEduClsStuEN.IsUpdated(conCurrEduClsStu.IdCurrEduCls))
 {
 if (objCurrEduClsStuEN.IdCurrEduCls  ==  "")
 {
 objCurrEduClsStuEN.IdCurrEduCls = null;
 }
 if (objCurrEduClsStuEN.IdCurrEduCls !=  null)
 {
 var strIdCurrEduCls = objCurrEduClsStuEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdCurrEduCls = '{0}',", strIdCurrEduCls); //教学班流水号
 }
 else
 {
 sbSQL.Append(" IdCurrEduCls = null,"); //教学班流水号
 }
 }
 
 if (objCurrEduClsStuEN.IsUpdated(conCurrEduClsStu.IdStu))
 {
 if (objCurrEduClsStuEN.IdStu  ==  "")
 {
 objCurrEduClsStuEN.IdStu = null;
 }
 if (objCurrEduClsStuEN.IdStu !=  null)
 {
 var strIdStu = objCurrEduClsStuEN.IdStu.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdStu = '{0}',", strIdStu); //学生流水号
 }
 else
 {
 sbSQL.Append(" IdStu = null,"); //学生流水号
 }
 }
 
 if (objCurrEduClsStuEN.IsUpdated(conCurrEduClsStu.EduClsStuStateId))
 {
 if (objCurrEduClsStuEN.EduClsStuStateId !=  null)
 {
 var strEduClsStuStateId = objCurrEduClsStuEN.EduClsStuStateId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" EduClsStuStateId = '{0}',", strEduClsStuStateId); //教学班学生状态编号
 }
 else
 {
 sbSQL.Append(" EduClsStuStateId = null,"); //教学班学生状态编号
 }
 }
 
 if (objCurrEduClsStuEN.IsUpdated(conCurrEduClsStu.GetScoreTimes))
 {
 if (objCurrEduClsStuEN.GetScoreTimes !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCurrEduClsStuEN.GetScoreTimes, conCurrEduClsStu.GetScoreTimes); //获得成绩次数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduClsStu.GetScoreTimes); //获得成绩次数
 }
 }
 
 if (objCurrEduClsStuEN.IsUpdated(conCurrEduClsStu.Score))
 {
 if (objCurrEduClsStuEN.Score !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCurrEduClsStuEN.Score, conCurrEduClsStu.Score); //得分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduClsStu.Score); //得分
 }
 }
 
 if (objCurrEduClsStuEN.IsUpdated(conCurrEduClsStu.TotalScores))
 {
 if (objCurrEduClsStuEN.TotalScores !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCurrEduClsStuEN.TotalScores, conCurrEduClsStu.TotalScores); //总分值
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduClsStu.TotalScores); //总分值
 }
 }
 
 if (objCurrEduClsStuEN.IsUpdated(conCurrEduClsStu.Ranking))
 {
 if (objCurrEduClsStuEN.Ranking !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCurrEduClsStuEN.Ranking, conCurrEduClsStu.Ranking); //名次
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduClsStu.Ranking); //名次
 }
 }
 
 if (objCurrEduClsStuEN.IsUpdated(conCurrEduClsStu.Percentile))
 {
 if (objCurrEduClsStuEN.Percentile !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCurrEduClsStuEN.Percentile, conCurrEduClsStu.Percentile); //百分位
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduClsStu.Percentile); //百分位
 }
 }
 
 if (objCurrEduClsStuEN.IsUpdated(conCurrEduClsStu.Ranking2))
 {
 if (objCurrEduClsStuEN.Ranking2 !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCurrEduClsStuEN.Ranking2, conCurrEduClsStu.Ranking2); //Ranking2
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduClsStu.Ranking2); //Ranking2
 }
 }
 
 if (objCurrEduClsStuEN.IsUpdated(conCurrEduClsStu.Percentile2))
 {
 if (objCurrEduClsStuEN.Percentile2 !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCurrEduClsStuEN.Percentile2, conCurrEduClsStu.Percentile2); //Percentile2
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduClsStu.Percentile2); //Percentile2
 }
 }
 
 if (objCurrEduClsStuEN.IsUpdated(conCurrEduClsStu.Ranking3))
 {
 if (objCurrEduClsStuEN.Ranking3 !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCurrEduClsStuEN.Ranking3, conCurrEduClsStu.Ranking3); //Ranking3
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduClsStu.Ranking3); //Ranking3
 }
 }
 
 if (objCurrEduClsStuEN.IsUpdated(conCurrEduClsStu.Percentile3))
 {
 if (objCurrEduClsStuEN.Percentile3 !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCurrEduClsStuEN.Percentile3, conCurrEduClsStu.Percentile3); //Percentile3
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduClsStu.Percentile3); //Percentile3
 }
 }
 
 if (objCurrEduClsStuEN.IsUpdated(conCurrEduClsStu.Confirmed))
 {
 sbSQL.AppendFormat(" Confirmed = '{0}',", objCurrEduClsStuEN.Confirmed == true?"1":"0"); //是否确认
 }
 
 if (objCurrEduClsStuEN.IsUpdated(conCurrEduClsStu.SchoolTerm))
 {
 if (objCurrEduClsStuEN.SchoolTerm !=  null)
 {
 var strSchoolTerm = objCurrEduClsStuEN.SchoolTerm.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SchoolTerm = '{0}',", strSchoolTerm); //学期
 }
 else
 {
 sbSQL.Append(" SchoolTerm = null,"); //学期
 }
 }
 
 if (objCurrEduClsStuEN.IsUpdated(conCurrEduClsStu.SchoolYear))
 {
 if (objCurrEduClsStuEN.SchoolYear !=  null)
 {
 var strSchoolYear = objCurrEduClsStuEN.SchoolYear.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SchoolYear = '{0}',", strSchoolYear); //学年
 }
 else
 {
 sbSQL.Append(" SchoolYear = null,"); //学年
 }
 }
 
 if (objCurrEduClsStuEN.IsUpdated(conCurrEduClsStu.ExportDate))
 {
 if (objCurrEduClsStuEN.ExportDate !=  null)
 {
 var strExportDate = objCurrEduClsStuEN.ExportDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ExportDate = '{0}',", strExportDate); //导出日期
 }
 else
 {
 sbSQL.Append(" ExportDate = null,"); //导出日期
 }
 }
 
 if (objCurrEduClsStuEN.IsUpdated(conCurrEduClsStu.SignInDate))
 {
 if (objCurrEduClsStuEN.SignInDate !=  null)
 {
 var strSignInDate = objCurrEduClsStuEN.SignInDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SignInDate = '{0}',", strSignInDate); //签入时间
 }
 else
 {
 sbSQL.Append(" SignInDate = null,"); //签入时间
 }
 }
 
 if (objCurrEduClsStuEN.IsUpdated(conCurrEduClsStu.SignInStateID))
 {
 if (objCurrEduClsStuEN.SignInStateID !=  null)
 {
 var strSignInStateID = objCurrEduClsStuEN.SignInStateID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SignInStateID = '{0}',", strSignInStateID); //签入状态表流水号
 }
 else
 {
 sbSQL.Append(" SignInStateID = null,"); //签入状态表流水号
 }
 }
 
 if (objCurrEduClsStuEN.IsUpdated(conCurrEduClsStu.SignInUser))
 {
 if (objCurrEduClsStuEN.SignInUser !=  null)
 {
 var strSignInUser = objCurrEduClsStuEN.SignInUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SignInUser = '{0}',", strSignInUser); //签入人
 }
 else
 {
 sbSQL.Append(" SignInUser = null,"); //签入人
 }
 }
 
 if (objCurrEduClsStuEN.IsUpdated(conCurrEduClsStu.IsOpByTeacher))
 {
 sbSQL.AppendFormat(" IsOpByTeacher = '{0}',", objCurrEduClsStuEN.IsOpByTeacher == true?"1":"0"); //是否教师操作
 }
 
 if (objCurrEduClsStuEN.IsUpdated(conCurrEduClsStu.IsSynScore))
 {
 sbSQL.AppendFormat(" IsSynScore = '{0}',", objCurrEduClsStuEN.IsSynScore == true?"1":"0"); //是否同步成绩
 }
 
 if (objCurrEduClsStuEN.IsUpdated(conCurrEduClsStu.LastVisitedDate))
 {
 if (objCurrEduClsStuEN.LastVisitedDate !=  null)
 {
 var strLastVisitedDate = objCurrEduClsStuEN.LastVisitedDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" LastVisitedDate = '{0}',", strLastVisitedDate); //最后访问时间
 }
 else
 {
 sbSQL.Append(" LastVisitedDate = null,"); //最后访问时间
 }
 }
 
 if (objCurrEduClsStuEN.IsUpdated(conCurrEduClsStu.ModifyDate))
 {
 if (objCurrEduClsStuEN.ModifyDate !=  null)
 {
 var strModifyDate = objCurrEduClsStuEN.ModifyDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ModifyDate = '{0}',", strModifyDate); //修改日期
 }
 else
 {
 sbSQL.Append(" ModifyDate = null,"); //修改日期
 }
 }
 
 if (objCurrEduClsStuEN.IsUpdated(conCurrEduClsStu.ModifyUserId))
 {
 if (objCurrEduClsStuEN.ModifyUserId !=  null)
 {
 var strModifyUserId = objCurrEduClsStuEN.ModifyUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ModifyUserId = '{0}',", strModifyUserId); //修改人
 }
 else
 {
 sbSQL.Append(" ModifyUserId = null,"); //修改人
 }
 }
 
 if (objCurrEduClsStuEN.IsUpdated(conCurrEduClsStu.Memo))
 {
 if (objCurrEduClsStuEN.Memo !=  null)
 {
 var strMemo = objCurrEduClsStuEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objCurrEduClsStuEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsCurrEduClsStuEN objCurrEduClsStuEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objCurrEduClsStuEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objCurrEduClsStuEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCurrEduClsStuDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update CurrEduClsStu Set ");
 
 if (objCurrEduClsStuEN.IsUpdated(conCurrEduClsStu.IdCurrEduCls))
 {
 if (objCurrEduClsStuEN.IdCurrEduCls  ==  "")
 {
 objCurrEduClsStuEN.IdCurrEduCls = null;
 }
 if (objCurrEduClsStuEN.IdCurrEduCls !=  null)
 {
 var strIdCurrEduCls = objCurrEduClsStuEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdCurrEduCls = '{0}',", strIdCurrEduCls); //教学班流水号
 }
 else
 {
 sbSQL.Append(" IdCurrEduCls = null,"); //教学班流水号
 }
 }
 
 if (objCurrEduClsStuEN.IsUpdated(conCurrEduClsStu.IdStu))
 {
 if (objCurrEduClsStuEN.IdStu  ==  "")
 {
 objCurrEduClsStuEN.IdStu = null;
 }
 if (objCurrEduClsStuEN.IdStu !=  null)
 {
 var strIdStu = objCurrEduClsStuEN.IdStu.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdStu = '{0}',", strIdStu); //学生流水号
 }
 else
 {
 sbSQL.Append(" IdStu = null,"); //学生流水号
 }
 }
 
 if (objCurrEduClsStuEN.IsUpdated(conCurrEduClsStu.EduClsStuStateId))
 {
 if (objCurrEduClsStuEN.EduClsStuStateId !=  null)
 {
 var strEduClsStuStateId = objCurrEduClsStuEN.EduClsStuStateId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" EduClsStuStateId = '{0}',", strEduClsStuStateId); //教学班学生状态编号
 }
 else
 {
 sbSQL.Append(" EduClsStuStateId = null,"); //教学班学生状态编号
 }
 }
 
 if (objCurrEduClsStuEN.IsUpdated(conCurrEduClsStu.GetScoreTimes))
 {
 if (objCurrEduClsStuEN.GetScoreTimes !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCurrEduClsStuEN.GetScoreTimes, conCurrEduClsStu.GetScoreTimes); //获得成绩次数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduClsStu.GetScoreTimes); //获得成绩次数
 }
 }
 
 if (objCurrEduClsStuEN.IsUpdated(conCurrEduClsStu.Score))
 {
 if (objCurrEduClsStuEN.Score !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCurrEduClsStuEN.Score, conCurrEduClsStu.Score); //得分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduClsStu.Score); //得分
 }
 }
 
 if (objCurrEduClsStuEN.IsUpdated(conCurrEduClsStu.TotalScores))
 {
 if (objCurrEduClsStuEN.TotalScores !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCurrEduClsStuEN.TotalScores, conCurrEduClsStu.TotalScores); //总分值
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduClsStu.TotalScores); //总分值
 }
 }
 
 if (objCurrEduClsStuEN.IsUpdated(conCurrEduClsStu.Ranking))
 {
 if (objCurrEduClsStuEN.Ranking !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCurrEduClsStuEN.Ranking, conCurrEduClsStu.Ranking); //名次
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduClsStu.Ranking); //名次
 }
 }
 
 if (objCurrEduClsStuEN.IsUpdated(conCurrEduClsStu.Percentile))
 {
 if (objCurrEduClsStuEN.Percentile !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCurrEduClsStuEN.Percentile, conCurrEduClsStu.Percentile); //百分位
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduClsStu.Percentile); //百分位
 }
 }
 
 if (objCurrEduClsStuEN.IsUpdated(conCurrEduClsStu.Ranking2))
 {
 if (objCurrEduClsStuEN.Ranking2 !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCurrEduClsStuEN.Ranking2, conCurrEduClsStu.Ranking2); //Ranking2
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduClsStu.Ranking2); //Ranking2
 }
 }
 
 if (objCurrEduClsStuEN.IsUpdated(conCurrEduClsStu.Percentile2))
 {
 if (objCurrEduClsStuEN.Percentile2 !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCurrEduClsStuEN.Percentile2, conCurrEduClsStu.Percentile2); //Percentile2
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduClsStu.Percentile2); //Percentile2
 }
 }
 
 if (objCurrEduClsStuEN.IsUpdated(conCurrEduClsStu.Ranking3))
 {
 if (objCurrEduClsStuEN.Ranking3 !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCurrEduClsStuEN.Ranking3, conCurrEduClsStu.Ranking3); //Ranking3
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduClsStu.Ranking3); //Ranking3
 }
 }
 
 if (objCurrEduClsStuEN.IsUpdated(conCurrEduClsStu.Percentile3))
 {
 if (objCurrEduClsStuEN.Percentile3 !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCurrEduClsStuEN.Percentile3, conCurrEduClsStu.Percentile3); //Percentile3
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduClsStu.Percentile3); //Percentile3
 }
 }
 
 if (objCurrEduClsStuEN.IsUpdated(conCurrEduClsStu.Confirmed))
 {
 sbSQL.AppendFormat(" Confirmed = '{0}',", objCurrEduClsStuEN.Confirmed == true?"1":"0"); //是否确认
 }
 
 if (objCurrEduClsStuEN.IsUpdated(conCurrEduClsStu.SchoolTerm))
 {
 if (objCurrEduClsStuEN.SchoolTerm !=  null)
 {
 var strSchoolTerm = objCurrEduClsStuEN.SchoolTerm.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SchoolTerm = '{0}',", strSchoolTerm); //学期
 }
 else
 {
 sbSQL.Append(" SchoolTerm = null,"); //学期
 }
 }
 
 if (objCurrEduClsStuEN.IsUpdated(conCurrEduClsStu.SchoolYear))
 {
 if (objCurrEduClsStuEN.SchoolYear !=  null)
 {
 var strSchoolYear = objCurrEduClsStuEN.SchoolYear.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SchoolYear = '{0}',", strSchoolYear); //学年
 }
 else
 {
 sbSQL.Append(" SchoolYear = null,"); //学年
 }
 }
 
 if (objCurrEduClsStuEN.IsUpdated(conCurrEduClsStu.ExportDate))
 {
 if (objCurrEduClsStuEN.ExportDate !=  null)
 {
 var strExportDate = objCurrEduClsStuEN.ExportDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ExportDate = '{0}',", strExportDate); //导出日期
 }
 else
 {
 sbSQL.Append(" ExportDate = null,"); //导出日期
 }
 }
 
 if (objCurrEduClsStuEN.IsUpdated(conCurrEduClsStu.SignInDate))
 {
 if (objCurrEduClsStuEN.SignInDate !=  null)
 {
 var strSignInDate = objCurrEduClsStuEN.SignInDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SignInDate = '{0}',", strSignInDate); //签入时间
 }
 else
 {
 sbSQL.Append(" SignInDate = null,"); //签入时间
 }
 }
 
 if (objCurrEduClsStuEN.IsUpdated(conCurrEduClsStu.SignInStateID))
 {
 if (objCurrEduClsStuEN.SignInStateID !=  null)
 {
 var strSignInStateID = objCurrEduClsStuEN.SignInStateID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SignInStateID = '{0}',", strSignInStateID); //签入状态表流水号
 }
 else
 {
 sbSQL.Append(" SignInStateID = null,"); //签入状态表流水号
 }
 }
 
 if (objCurrEduClsStuEN.IsUpdated(conCurrEduClsStu.SignInUser))
 {
 if (objCurrEduClsStuEN.SignInUser !=  null)
 {
 var strSignInUser = objCurrEduClsStuEN.SignInUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SignInUser = '{0}',", strSignInUser); //签入人
 }
 else
 {
 sbSQL.Append(" SignInUser = null,"); //签入人
 }
 }
 
 if (objCurrEduClsStuEN.IsUpdated(conCurrEduClsStu.IsOpByTeacher))
 {
 sbSQL.AppendFormat(" IsOpByTeacher = '{0}',", objCurrEduClsStuEN.IsOpByTeacher == true?"1":"0"); //是否教师操作
 }
 
 if (objCurrEduClsStuEN.IsUpdated(conCurrEduClsStu.IsSynScore))
 {
 sbSQL.AppendFormat(" IsSynScore = '{0}',", objCurrEduClsStuEN.IsSynScore == true?"1":"0"); //是否同步成绩
 }
 
 if (objCurrEduClsStuEN.IsUpdated(conCurrEduClsStu.LastVisitedDate))
 {
 if (objCurrEduClsStuEN.LastVisitedDate !=  null)
 {
 var strLastVisitedDate = objCurrEduClsStuEN.LastVisitedDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" LastVisitedDate = '{0}',", strLastVisitedDate); //最后访问时间
 }
 else
 {
 sbSQL.Append(" LastVisitedDate = null,"); //最后访问时间
 }
 }
 
 if (objCurrEduClsStuEN.IsUpdated(conCurrEduClsStu.ModifyDate))
 {
 if (objCurrEduClsStuEN.ModifyDate !=  null)
 {
 var strModifyDate = objCurrEduClsStuEN.ModifyDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ModifyDate = '{0}',", strModifyDate); //修改日期
 }
 else
 {
 sbSQL.Append(" ModifyDate = null,"); //修改日期
 }
 }
 
 if (objCurrEduClsStuEN.IsUpdated(conCurrEduClsStu.ModifyUserId))
 {
 if (objCurrEduClsStuEN.ModifyUserId !=  null)
 {
 var strModifyUserId = objCurrEduClsStuEN.ModifyUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ModifyUserId = '{0}',", strModifyUserId); //修改人
 }
 else
 {
 sbSQL.Append(" ModifyUserId = null,"); //修改人
 }
 }
 
 if (objCurrEduClsStuEN.IsUpdated(conCurrEduClsStu.Memo))
 {
 if (objCurrEduClsStuEN.Memo !=  null)
 {
 var strMemo = objCurrEduClsStuEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objCurrEduClsStuEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsCurrEduClsStuEN objCurrEduClsStuEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objCurrEduClsStuEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objCurrEduClsStuEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCurrEduClsStuDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update CurrEduClsStu Set ");
 
 if (objCurrEduClsStuEN.IsUpdated(conCurrEduClsStu.IdCurrEduCls))
 {
 if (objCurrEduClsStuEN.IdCurrEduCls  ==  "")
 {
 objCurrEduClsStuEN.IdCurrEduCls = null;
 }
 if (objCurrEduClsStuEN.IdCurrEduCls !=  null)
 {
 var strIdCurrEduCls = objCurrEduClsStuEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdCurrEduCls, conCurrEduClsStu.IdCurrEduCls); //教学班流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduClsStu.IdCurrEduCls); //教学班流水号
 }
 }
 
 if (objCurrEduClsStuEN.IsUpdated(conCurrEduClsStu.IdStu))
 {
 if (objCurrEduClsStuEN.IdStu  ==  "")
 {
 objCurrEduClsStuEN.IdStu = null;
 }
 if (objCurrEduClsStuEN.IdStu !=  null)
 {
 var strIdStu = objCurrEduClsStuEN.IdStu.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdStu, conCurrEduClsStu.IdStu); //学生流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduClsStu.IdStu); //学生流水号
 }
 }
 
 if (objCurrEduClsStuEN.IsUpdated(conCurrEduClsStu.EduClsStuStateId))
 {
 if (objCurrEduClsStuEN.EduClsStuStateId !=  null)
 {
 var strEduClsStuStateId = objCurrEduClsStuEN.EduClsStuStateId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strEduClsStuStateId, conCurrEduClsStu.EduClsStuStateId); //教学班学生状态编号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduClsStu.EduClsStuStateId); //教学班学生状态编号
 }
 }
 
 if (objCurrEduClsStuEN.IsUpdated(conCurrEduClsStu.GetScoreTimes))
 {
 if (objCurrEduClsStuEN.GetScoreTimes !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCurrEduClsStuEN.GetScoreTimes, conCurrEduClsStu.GetScoreTimes); //获得成绩次数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduClsStu.GetScoreTimes); //获得成绩次数
 }
 }
 
 if (objCurrEduClsStuEN.IsUpdated(conCurrEduClsStu.Score))
 {
 if (objCurrEduClsStuEN.Score !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCurrEduClsStuEN.Score, conCurrEduClsStu.Score); //得分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduClsStu.Score); //得分
 }
 }
 
 if (objCurrEduClsStuEN.IsUpdated(conCurrEduClsStu.TotalScores))
 {
 if (objCurrEduClsStuEN.TotalScores !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCurrEduClsStuEN.TotalScores, conCurrEduClsStu.TotalScores); //总分值
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduClsStu.TotalScores); //总分值
 }
 }
 
 if (objCurrEduClsStuEN.IsUpdated(conCurrEduClsStu.Ranking))
 {
 if (objCurrEduClsStuEN.Ranking !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCurrEduClsStuEN.Ranking, conCurrEduClsStu.Ranking); //名次
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduClsStu.Ranking); //名次
 }
 }
 
 if (objCurrEduClsStuEN.IsUpdated(conCurrEduClsStu.Percentile))
 {
 if (objCurrEduClsStuEN.Percentile !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCurrEduClsStuEN.Percentile, conCurrEduClsStu.Percentile); //百分位
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduClsStu.Percentile); //百分位
 }
 }
 
 if (objCurrEduClsStuEN.IsUpdated(conCurrEduClsStu.Ranking2))
 {
 if (objCurrEduClsStuEN.Ranking2 !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCurrEduClsStuEN.Ranking2, conCurrEduClsStu.Ranking2); //Ranking2
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduClsStu.Ranking2); //Ranking2
 }
 }
 
 if (objCurrEduClsStuEN.IsUpdated(conCurrEduClsStu.Percentile2))
 {
 if (objCurrEduClsStuEN.Percentile2 !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCurrEduClsStuEN.Percentile2, conCurrEduClsStu.Percentile2); //Percentile2
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduClsStu.Percentile2); //Percentile2
 }
 }
 
 if (objCurrEduClsStuEN.IsUpdated(conCurrEduClsStu.Ranking3))
 {
 if (objCurrEduClsStuEN.Ranking3 !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCurrEduClsStuEN.Ranking3, conCurrEduClsStu.Ranking3); //Ranking3
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduClsStu.Ranking3); //Ranking3
 }
 }
 
 if (objCurrEduClsStuEN.IsUpdated(conCurrEduClsStu.Percentile3))
 {
 if (objCurrEduClsStuEN.Percentile3 !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCurrEduClsStuEN.Percentile3, conCurrEduClsStu.Percentile3); //Percentile3
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduClsStu.Percentile3); //Percentile3
 }
 }
 
 if (objCurrEduClsStuEN.IsUpdated(conCurrEduClsStu.Confirmed))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objCurrEduClsStuEN.Confirmed == true?"1":"0", conCurrEduClsStu.Confirmed); //是否确认
 }
 
 if (objCurrEduClsStuEN.IsUpdated(conCurrEduClsStu.SchoolTerm))
 {
 if (objCurrEduClsStuEN.SchoolTerm !=  null)
 {
 var strSchoolTerm = objCurrEduClsStuEN.SchoolTerm.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSchoolTerm, conCurrEduClsStu.SchoolTerm); //学期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduClsStu.SchoolTerm); //学期
 }
 }
 
 if (objCurrEduClsStuEN.IsUpdated(conCurrEduClsStu.SchoolYear))
 {
 if (objCurrEduClsStuEN.SchoolYear !=  null)
 {
 var strSchoolYear = objCurrEduClsStuEN.SchoolYear.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSchoolYear, conCurrEduClsStu.SchoolYear); //学年
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduClsStu.SchoolYear); //学年
 }
 }
 
 if (objCurrEduClsStuEN.IsUpdated(conCurrEduClsStu.ExportDate))
 {
 if (objCurrEduClsStuEN.ExportDate !=  null)
 {
 var strExportDate = objCurrEduClsStuEN.ExportDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strExportDate, conCurrEduClsStu.ExportDate); //导出日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduClsStu.ExportDate); //导出日期
 }
 }
 
 if (objCurrEduClsStuEN.IsUpdated(conCurrEduClsStu.SignInDate))
 {
 if (objCurrEduClsStuEN.SignInDate !=  null)
 {
 var strSignInDate = objCurrEduClsStuEN.SignInDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSignInDate, conCurrEduClsStu.SignInDate); //签入时间
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduClsStu.SignInDate); //签入时间
 }
 }
 
 if (objCurrEduClsStuEN.IsUpdated(conCurrEduClsStu.SignInStateID))
 {
 if (objCurrEduClsStuEN.SignInStateID !=  null)
 {
 var strSignInStateID = objCurrEduClsStuEN.SignInStateID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSignInStateID, conCurrEduClsStu.SignInStateID); //签入状态表流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduClsStu.SignInStateID); //签入状态表流水号
 }
 }
 
 if (objCurrEduClsStuEN.IsUpdated(conCurrEduClsStu.SignInUser))
 {
 if (objCurrEduClsStuEN.SignInUser !=  null)
 {
 var strSignInUser = objCurrEduClsStuEN.SignInUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSignInUser, conCurrEduClsStu.SignInUser); //签入人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduClsStu.SignInUser); //签入人
 }
 }
 
 if (objCurrEduClsStuEN.IsUpdated(conCurrEduClsStu.IsOpByTeacher))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objCurrEduClsStuEN.IsOpByTeacher == true?"1":"0", conCurrEduClsStu.IsOpByTeacher); //是否教师操作
 }
 
 if (objCurrEduClsStuEN.IsUpdated(conCurrEduClsStu.IsSynScore))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objCurrEduClsStuEN.IsSynScore == true?"1":"0", conCurrEduClsStu.IsSynScore); //是否同步成绩
 }
 
 if (objCurrEduClsStuEN.IsUpdated(conCurrEduClsStu.LastVisitedDate))
 {
 if (objCurrEduClsStuEN.LastVisitedDate !=  null)
 {
 var strLastVisitedDate = objCurrEduClsStuEN.LastVisitedDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strLastVisitedDate, conCurrEduClsStu.LastVisitedDate); //最后访问时间
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduClsStu.LastVisitedDate); //最后访问时间
 }
 }
 
 if (objCurrEduClsStuEN.IsUpdated(conCurrEduClsStu.ModifyDate))
 {
 if (objCurrEduClsStuEN.ModifyDate !=  null)
 {
 var strModifyDate = objCurrEduClsStuEN.ModifyDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strModifyDate, conCurrEduClsStu.ModifyDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduClsStu.ModifyDate); //修改日期
 }
 }
 
 if (objCurrEduClsStuEN.IsUpdated(conCurrEduClsStu.ModifyUserId))
 {
 if (objCurrEduClsStuEN.ModifyUserId !=  null)
 {
 var strModifyUserId = objCurrEduClsStuEN.ModifyUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strModifyUserId, conCurrEduClsStu.ModifyUserId); //修改人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduClsStu.ModifyUserId); //修改人
 }
 }
 
 if (objCurrEduClsStuEN.IsUpdated(conCurrEduClsStu.Memo))
 {
 if (objCurrEduClsStuEN.Memo !=  null)
 {
 var strMemo = objCurrEduClsStuEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conCurrEduClsStu.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduClsStu.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where IdEduClsStu = {0}", objCurrEduClsStuEN.IdEduClsStu); 
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
 /// <param name = "lngIdEduClsStu">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(long lngIdEduClsStu) 
{
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCurrEduClsStuDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 lngIdEduClsStu,
};
 objSQL.ExecSP("CurrEduClsStu_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "lngIdEduClsStu">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(long lngIdEduClsStu, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCurrEduClsStuDA.GetSpecSQLObj();
//删除CurrEduClsStu本表中与当前对象有关的记录
strSQL = strSQL + "Delete from CurrEduClsStu where IdEduClsStu = " + ""+ lngIdEduClsStu+"";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelCurrEduClsStu(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCurrEduClsStuDA.GetSpecSQLObj();
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
//删除CurrEduClsStu本表中与当前对象有关的记录
strSQL = strSQL + "Delete from CurrEduClsStu where IdEduClsStu in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "lngIdEduClsStu">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(long lngIdEduClsStu) 
{
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCurrEduClsStuDA.GetSpecSQLObj();
//删除CurrEduClsStu本表中与当前对象有关的记录
strSQL = strSQL + "Delete from CurrEduClsStu where IdEduClsStu = " + ""+ lngIdEduClsStu+"";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelCurrEduClsStu(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsCurrEduClsStuDA: DelCurrEduClsStu)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCurrEduClsStuDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from CurrEduClsStu where " + strCondition ;
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
public bool DelCurrEduClsStuWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsCurrEduClsStuDA: DelCurrEduClsStuWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCurrEduClsStuDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from CurrEduClsStu where " + strCondition ;
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
 /// <param name = "objCurrEduClsStuENS">源对象</param>
 /// <param name = "objCurrEduClsStuENT">目标对象</param>
public void CopyTo(clsCurrEduClsStuEN objCurrEduClsStuENS, clsCurrEduClsStuEN objCurrEduClsStuENT)
{
objCurrEduClsStuENT.IdEduClsStu = objCurrEduClsStuENS.IdEduClsStu; //教学班学生流水号
objCurrEduClsStuENT.IdCurrEduCls = objCurrEduClsStuENS.IdCurrEduCls; //教学班流水号
objCurrEduClsStuENT.IdStu = objCurrEduClsStuENS.IdStu; //学生流水号
objCurrEduClsStuENT.EduClsStuStateId = objCurrEduClsStuENS.EduClsStuStateId; //教学班学生状态编号
objCurrEduClsStuENT.GetScoreTimes = objCurrEduClsStuENS.GetScoreTimes; //获得成绩次数
objCurrEduClsStuENT.Score = objCurrEduClsStuENS.Score; //得分
objCurrEduClsStuENT.TotalScores = objCurrEduClsStuENS.TotalScores; //总分值
objCurrEduClsStuENT.Ranking = objCurrEduClsStuENS.Ranking; //名次
objCurrEduClsStuENT.Percentile = objCurrEduClsStuENS.Percentile; //百分位
objCurrEduClsStuENT.Ranking2 = objCurrEduClsStuENS.Ranking2; //Ranking2
objCurrEduClsStuENT.Percentile2 = objCurrEduClsStuENS.Percentile2; //Percentile2
objCurrEduClsStuENT.Ranking3 = objCurrEduClsStuENS.Ranking3; //Ranking3
objCurrEduClsStuENT.Percentile3 = objCurrEduClsStuENS.Percentile3; //Percentile3
objCurrEduClsStuENT.Confirmed = objCurrEduClsStuENS.Confirmed; //是否确认
objCurrEduClsStuENT.SchoolTerm = objCurrEduClsStuENS.SchoolTerm; //学期
objCurrEduClsStuENT.SchoolYear = objCurrEduClsStuENS.SchoolYear; //学年
objCurrEduClsStuENT.ExportDate = objCurrEduClsStuENS.ExportDate; //导出日期
objCurrEduClsStuENT.SignInDate = objCurrEduClsStuENS.SignInDate; //签入时间
objCurrEduClsStuENT.SignInStateID = objCurrEduClsStuENS.SignInStateID; //签入状态表流水号
objCurrEduClsStuENT.SignInUser = objCurrEduClsStuENS.SignInUser; //签入人
objCurrEduClsStuENT.IsOpByTeacher = objCurrEduClsStuENS.IsOpByTeacher; //是否教师操作
objCurrEduClsStuENT.IsSynScore = objCurrEduClsStuENS.IsSynScore; //是否同步成绩
objCurrEduClsStuENT.LastVisitedDate = objCurrEduClsStuENS.LastVisitedDate; //最后访问时间
objCurrEduClsStuENT.ModifyDate = objCurrEduClsStuENS.ModifyDate; //修改日期
objCurrEduClsStuENT.ModifyUserId = objCurrEduClsStuENS.ModifyUserId; //修改人
objCurrEduClsStuENT.Memo = objCurrEduClsStuENS.Memo; //备注
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsCurrEduClsStuEN objCurrEduClsStuEN)
{
//检查字段不能为空(NULL)
//检查字段长度
clsCheckSql.CheckFieldLen(objCurrEduClsStuEN.IdCurrEduCls, 8, conCurrEduClsStu.IdCurrEduCls);
clsCheckSql.CheckFieldLen(objCurrEduClsStuEN.IdStu, 8, conCurrEduClsStu.IdStu);
clsCheckSql.CheckFieldLen(objCurrEduClsStuEN.EduClsStuStateId, 2, conCurrEduClsStu.EduClsStuStateId);
clsCheckSql.CheckFieldLen(objCurrEduClsStuEN.SchoolTerm, 1, conCurrEduClsStu.SchoolTerm);
clsCheckSql.CheckFieldLen(objCurrEduClsStuEN.SchoolYear, 10, conCurrEduClsStu.SchoolYear);
clsCheckSql.CheckFieldLen(objCurrEduClsStuEN.ExportDate, 8, conCurrEduClsStu.ExportDate);
clsCheckSql.CheckFieldLen(objCurrEduClsStuEN.SignInDate, 20, conCurrEduClsStu.SignInDate);
clsCheckSql.CheckFieldLen(objCurrEduClsStuEN.SignInStateID, 2, conCurrEduClsStu.SignInStateID);
clsCheckSql.CheckFieldLen(objCurrEduClsStuEN.SignInUser, 18, conCurrEduClsStu.SignInUser);
clsCheckSql.CheckFieldLen(objCurrEduClsStuEN.LastVisitedDate, 14, conCurrEduClsStu.LastVisitedDate);
clsCheckSql.CheckFieldLen(objCurrEduClsStuEN.ModifyDate, 20, conCurrEduClsStu.ModifyDate);
clsCheckSql.CheckFieldLen(objCurrEduClsStuEN.ModifyUserId, 18, conCurrEduClsStu.ModifyUserId);
clsCheckSql.CheckFieldLen(objCurrEduClsStuEN.Memo, 1000, conCurrEduClsStu.Memo);
//检查字段外键固定长度
clsCheckSql.CheckFieldForeignKey(objCurrEduClsStuEN.IdCurrEduCls, 8, conCurrEduClsStu.IdCurrEduCls);
clsCheckSql.CheckFieldForeignKey(objCurrEduClsStuEN.IdStu, 8, conCurrEduClsStu.IdStu);
 objCurrEduClsStuEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsCurrEduClsStuEN objCurrEduClsStuEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objCurrEduClsStuEN.IdCurrEduCls, 8, conCurrEduClsStu.IdCurrEduCls);
clsCheckSql.CheckFieldLen(objCurrEduClsStuEN.IdStu, 8, conCurrEduClsStu.IdStu);
clsCheckSql.CheckFieldLen(objCurrEduClsStuEN.EduClsStuStateId, 2, conCurrEduClsStu.EduClsStuStateId);
clsCheckSql.CheckFieldLen(objCurrEduClsStuEN.SchoolTerm, 1, conCurrEduClsStu.SchoolTerm);
clsCheckSql.CheckFieldLen(objCurrEduClsStuEN.SchoolYear, 10, conCurrEduClsStu.SchoolYear);
clsCheckSql.CheckFieldLen(objCurrEduClsStuEN.ExportDate, 8, conCurrEduClsStu.ExportDate);
clsCheckSql.CheckFieldLen(objCurrEduClsStuEN.SignInDate, 20, conCurrEduClsStu.SignInDate);
clsCheckSql.CheckFieldLen(objCurrEduClsStuEN.SignInStateID, 2, conCurrEduClsStu.SignInStateID);
clsCheckSql.CheckFieldLen(objCurrEduClsStuEN.SignInUser, 18, conCurrEduClsStu.SignInUser);
clsCheckSql.CheckFieldLen(objCurrEduClsStuEN.LastVisitedDate, 14, conCurrEduClsStu.LastVisitedDate);
clsCheckSql.CheckFieldLen(objCurrEduClsStuEN.ModifyDate, 20, conCurrEduClsStu.ModifyDate);
clsCheckSql.CheckFieldLen(objCurrEduClsStuEN.ModifyUserId, 18, conCurrEduClsStu.ModifyUserId);
clsCheckSql.CheckFieldLen(objCurrEduClsStuEN.Memo, 1000, conCurrEduClsStu.Memo);
//检查外键字段长度
clsCheckSql.CheckFieldForeignKey(objCurrEduClsStuEN.IdCurrEduCls, 8, conCurrEduClsStu.IdCurrEduCls);
clsCheckSql.CheckFieldForeignKey(objCurrEduClsStuEN.IdStu, 8, conCurrEduClsStu.IdStu);
 objCurrEduClsStuEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsCurrEduClsStuEN objCurrEduClsStuEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objCurrEduClsStuEN.IdCurrEduCls, 8, conCurrEduClsStu.IdCurrEduCls);
clsCheckSql.CheckFieldLen(objCurrEduClsStuEN.IdStu, 8, conCurrEduClsStu.IdStu);
clsCheckSql.CheckFieldLen(objCurrEduClsStuEN.EduClsStuStateId, 2, conCurrEduClsStu.EduClsStuStateId);
clsCheckSql.CheckFieldLen(objCurrEduClsStuEN.SchoolTerm, 1, conCurrEduClsStu.SchoolTerm);
clsCheckSql.CheckFieldLen(objCurrEduClsStuEN.SchoolYear, 10, conCurrEduClsStu.SchoolYear);
clsCheckSql.CheckFieldLen(objCurrEduClsStuEN.ExportDate, 8, conCurrEduClsStu.ExportDate);
clsCheckSql.CheckFieldLen(objCurrEduClsStuEN.SignInDate, 20, conCurrEduClsStu.SignInDate);
clsCheckSql.CheckFieldLen(objCurrEduClsStuEN.SignInStateID, 2, conCurrEduClsStu.SignInStateID);
clsCheckSql.CheckFieldLen(objCurrEduClsStuEN.SignInUser, 18, conCurrEduClsStu.SignInUser);
clsCheckSql.CheckFieldLen(objCurrEduClsStuEN.LastVisitedDate, 14, conCurrEduClsStu.LastVisitedDate);
clsCheckSql.CheckFieldLen(objCurrEduClsStuEN.ModifyDate, 20, conCurrEduClsStu.ModifyDate);
clsCheckSql.CheckFieldLen(objCurrEduClsStuEN.ModifyUserId, 18, conCurrEduClsStu.ModifyUserId);
clsCheckSql.CheckFieldLen(objCurrEduClsStuEN.Memo, 1000, conCurrEduClsStu.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objCurrEduClsStuEN.IdCurrEduCls, conCurrEduClsStu.IdCurrEduCls);
clsCheckSql.CheckSqlInjection4Field(objCurrEduClsStuEN.IdStu, conCurrEduClsStu.IdStu);
clsCheckSql.CheckSqlInjection4Field(objCurrEduClsStuEN.EduClsStuStateId, conCurrEduClsStu.EduClsStuStateId);
clsCheckSql.CheckSqlInjection4Field(objCurrEduClsStuEN.SchoolTerm, conCurrEduClsStu.SchoolTerm);
clsCheckSql.CheckSqlInjection4Field(objCurrEduClsStuEN.SchoolYear, conCurrEduClsStu.SchoolYear);
clsCheckSql.CheckSqlInjection4Field(objCurrEduClsStuEN.ExportDate, conCurrEduClsStu.ExportDate);
clsCheckSql.CheckSqlInjection4Field(objCurrEduClsStuEN.SignInDate, conCurrEduClsStu.SignInDate);
clsCheckSql.CheckSqlInjection4Field(objCurrEduClsStuEN.SignInStateID, conCurrEduClsStu.SignInStateID);
clsCheckSql.CheckSqlInjection4Field(objCurrEduClsStuEN.SignInUser, conCurrEduClsStu.SignInUser);
clsCheckSql.CheckSqlInjection4Field(objCurrEduClsStuEN.LastVisitedDate, conCurrEduClsStu.LastVisitedDate);
clsCheckSql.CheckSqlInjection4Field(objCurrEduClsStuEN.ModifyDate, conCurrEduClsStu.ModifyDate);
clsCheckSql.CheckSqlInjection4Field(objCurrEduClsStuEN.ModifyUserId, conCurrEduClsStu.ModifyUserId);
clsCheckSql.CheckSqlInjection4Field(objCurrEduClsStuEN.Memo, conCurrEduClsStu.Memo);
//检查外键字段长度
clsCheckSql.CheckFieldForeignKey(objCurrEduClsStuEN.IdCurrEduCls, 8, conCurrEduClsStu.IdCurrEduCls);
clsCheckSql.CheckFieldForeignKey(objCurrEduClsStuEN.IdStu, 8, conCurrEduClsStu.IdStu);
 objCurrEduClsStuEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--CurrEduClsStu(教学班与学生关系),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objCurrEduClsStuEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clsCurrEduClsStuEN objCurrEduClsStuEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 if (objCurrEduClsStuEN.IdCurrEduCls == null)
{
 sbCondition.AppendFormat(" and IdCurrEduCls is null");
}
else
{
 sbCondition.AppendFormat(" and IdCurrEduCls = '{0}'", objCurrEduClsStuEN.IdCurrEduCls);
}
 if (objCurrEduClsStuEN.IdStu == null)
{
 sbCondition.AppendFormat(" and IdStu is null");
}
else
{
 sbCondition.AppendFormat(" and IdStu = '{0}'", objCurrEduClsStuEN.IdStu);
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
 objSQL = clsCurrEduClsStuDA.GetSpecSQLObj();
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
 objSQL = clsCurrEduClsStuDA.GetSpecSQLObj();
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
 objSQL = clsCurrEduClsStuDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsCurrEduClsStuEN._CurrTabName);
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
 objSQL = clsCurrEduClsStuDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsCurrEduClsStuEN._CurrTabName, strCondition);
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
 objSQL = clsCurrEduClsStuDA.GetSpecSQLObj();
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
 objSQL = clsCurrEduClsStuDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}