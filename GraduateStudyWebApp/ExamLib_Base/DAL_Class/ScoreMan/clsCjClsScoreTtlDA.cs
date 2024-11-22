
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsCjClsScoreTtlDA
 表名:CjClsScoreTtl(01120330)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:21:02
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:成绩管理(ScoreMan)
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
 /// 班级成绩汇总(CjClsScoreTtl)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsCjClsScoreTtlDA : clsCommBase4DA
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
 return clsCjClsScoreTtlEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsCjClsScoreTtlEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsCjClsScoreTtlEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsCjClsScoreTtlEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsCjClsScoreTtlEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsCjClsScoreTtlDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCjClsScoreTtlDA.GetSpecSQLObj();
strSQL = "Select * from CjClsScoreTtl where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_CjClsScoreTtl(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsCjClsScoreTtlDA: GetDataTable_CjClsScoreTtl)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCjClsScoreTtlDA.GetSpecSQLObj();
strSQL = "Select * from CjClsScoreTtl where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsCjClsScoreTtlDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCjClsScoreTtlDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsCjClsScoreTtlDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCjClsScoreTtlDA.GetSpecSQLObj();
strSQL = "Select * from CjClsScoreTtl where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsCjClsScoreTtlDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCjClsScoreTtlDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsCjClsScoreTtlDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCjClsScoreTtlDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from CjClsScoreTtl where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from CjClsScoreTtl where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsCjClsScoreTtlDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCjClsScoreTtlDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from CjClsScoreTtl where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsCjClsScoreTtlDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCjClsScoreTtlDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} CjClsScoreTtl.* from CjClsScoreTtl Left Join {1} on {2} where {3} and CjClsScoreTtl.mId not in (Select top {5} CjClsScoreTtl.mId from CjClsScoreTtl Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from CjClsScoreTtl where {1} and mId not in (Select top {2} mId from CjClsScoreTtl where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from CjClsScoreTtl where {1} and mId not in (Select top {3} mId from CjClsScoreTtl where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsCjClsScoreTtlDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCjClsScoreTtlDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} CjClsScoreTtl.* from CjClsScoreTtl Left Join {1} on {2} where {3} and CjClsScoreTtl.mId not in (Select top {5} CjClsScoreTtl.mId from CjClsScoreTtl Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from CjClsScoreTtl where {1} and mId not in (Select top {2} mId from CjClsScoreTtl where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from CjClsScoreTtl where {1} and mId not in (Select top {3} mId from CjClsScoreTtl where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsCjClsScoreTtlEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsCjClsScoreTtlDA:GetObjLst)", objException.Message));
}
List<clsCjClsScoreTtlEN> arrObjLst = new List<clsCjClsScoreTtlEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCjClsScoreTtlDA.GetSpecSQLObj();
strSQL = "Select * from CjClsScoreTtl where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCjClsScoreTtlEN objCjClsScoreTtlEN = new clsCjClsScoreTtlEN();
try
{
objCjClsScoreTtlEN.mId = TransNullToInt(objRow[conCjClsScoreTtl.mId].ToString().Trim()); //mId
objCjClsScoreTtlEN.ExamBatchId = objRow[conCjClsScoreTtl.ExamBatchId].ToString().Trim(); //考试批次ID
objCjClsScoreTtlEN.IdCourse = objRow[conCjClsScoreTtl.IdCourse].ToString().Trim(); //课程流水号
objCjClsScoreTtlEN.IdEduCls = objRow[conCjClsScoreTtl.IdEduCls].ToString().Trim(); //教学班流水号
objCjClsScoreTtlEN.IdAdminCls = objRow[conCjClsScoreTtl.IdAdminCls] == DBNull.Value ? null : objRow[conCjClsScoreTtl.IdAdminCls].ToString().Trim(); //行政班流水号
objCjClsScoreTtlEN.StuNum = objRow[conCjClsScoreTtl.StuNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conCjClsScoreTtl.StuNum].ToString().Trim()); //学生数
objCjClsScoreTtlEN.AvgScore = objRow[conCjClsScoreTtl.AvgScore] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[conCjClsScoreTtl.AvgScore].ToString().Trim()); //平均分
objCjClsScoreTtlEN.Ranking = objRow[conCjClsScoreTtl.Ranking] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conCjClsScoreTtl.Ranking].ToString().Trim()); //名次
objCjClsScoreTtlEN.Percentile = objRow[conCjClsScoreTtl.Percentile] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[conCjClsScoreTtl.Percentile].ToString().Trim()); //百分位
objCjClsScoreTtlEN.ExcellentRate = objRow[conCjClsScoreTtl.ExcellentRate] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[conCjClsScoreTtl.ExcellentRate].ToString().Trim()); //优秀率
objCjClsScoreTtlEN.ExcellentGoodRate = objRow[conCjClsScoreTtl.ExcellentGoodRate] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[conCjClsScoreTtl.ExcellentGoodRate].ToString().Trim()); //优良率
objCjClsScoreTtlEN.PassingRate = objRow[conCjClsScoreTtl.PassingRate] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[conCjClsScoreTtl.PassingRate].ToString().Trim()); //及格率
objCjClsScoreTtlEN.ExtremeRate = objRow[conCjClsScoreTtl.ExtremeRate] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[conCjClsScoreTtl.ExtremeRate].ToString().Trim()); //极差率
objCjClsScoreTtlEN.StandardDeviation = objRow[conCjClsScoreTtl.StandardDeviation] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[conCjClsScoreTtl.StandardDeviation].ToString().Trim()); //标准差
objCjClsScoreTtlEN.FullScore = objRow[conCjClsScoreTtl.FullScore] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conCjClsScoreTtl.FullScore].ToString().Trim()); //满分
objCjClsScoreTtlEN.SchoolYear = objRow[conCjClsScoreTtl.SchoolYear] == DBNull.Value ? null : objRow[conCjClsScoreTtl.SchoolYear].ToString().Trim(); //学年
objCjClsScoreTtlEN.SchoolTerm = objRow[conCjClsScoreTtl.SchoolTerm] == DBNull.Value ? null : objRow[conCjClsScoreTtl.SchoolTerm].ToString().Trim(); //学期
objCjClsScoreTtlEN.UpdDate = objRow[conCjClsScoreTtl.UpdDate].ToString().Trim(); //修改日期
objCjClsScoreTtlEN.UpdUser = objRow[conCjClsScoreTtl.UpdUser].ToString().Trim(); //修改人
objCjClsScoreTtlEN.Memo = objRow[conCjClsScoreTtl.Memo] == DBNull.Value ? null : objRow[conCjClsScoreTtl.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsCjClsScoreTtlDA: GetObjLst)", objException.Message));
}
objCjClsScoreTtlEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objCjClsScoreTtlEN);
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
public List<clsCjClsScoreTtlEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsCjClsScoreTtlDA:GetObjLstByTabName)", objException.Message));
}
List<clsCjClsScoreTtlEN> arrObjLst = new List<clsCjClsScoreTtlEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCjClsScoreTtlDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCjClsScoreTtlEN objCjClsScoreTtlEN = new clsCjClsScoreTtlEN();
try
{
objCjClsScoreTtlEN.mId = TransNullToInt(objRow[conCjClsScoreTtl.mId].ToString().Trim()); //mId
objCjClsScoreTtlEN.ExamBatchId = objRow[conCjClsScoreTtl.ExamBatchId].ToString().Trim(); //考试批次ID
objCjClsScoreTtlEN.IdCourse = objRow[conCjClsScoreTtl.IdCourse].ToString().Trim(); //课程流水号
objCjClsScoreTtlEN.IdEduCls = objRow[conCjClsScoreTtl.IdEduCls].ToString().Trim(); //教学班流水号
objCjClsScoreTtlEN.IdAdminCls = objRow[conCjClsScoreTtl.IdAdminCls] == DBNull.Value ? null : objRow[conCjClsScoreTtl.IdAdminCls].ToString().Trim(); //行政班流水号
objCjClsScoreTtlEN.StuNum = objRow[conCjClsScoreTtl.StuNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conCjClsScoreTtl.StuNum].ToString().Trim()); //学生数
objCjClsScoreTtlEN.AvgScore = objRow[conCjClsScoreTtl.AvgScore] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[conCjClsScoreTtl.AvgScore].ToString().Trim()); //平均分
objCjClsScoreTtlEN.Ranking = objRow[conCjClsScoreTtl.Ranking] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conCjClsScoreTtl.Ranking].ToString().Trim()); //名次
objCjClsScoreTtlEN.Percentile = objRow[conCjClsScoreTtl.Percentile] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[conCjClsScoreTtl.Percentile].ToString().Trim()); //百分位
objCjClsScoreTtlEN.ExcellentRate = objRow[conCjClsScoreTtl.ExcellentRate] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[conCjClsScoreTtl.ExcellentRate].ToString().Trim()); //优秀率
objCjClsScoreTtlEN.ExcellentGoodRate = objRow[conCjClsScoreTtl.ExcellentGoodRate] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[conCjClsScoreTtl.ExcellentGoodRate].ToString().Trim()); //优良率
objCjClsScoreTtlEN.PassingRate = objRow[conCjClsScoreTtl.PassingRate] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[conCjClsScoreTtl.PassingRate].ToString().Trim()); //及格率
objCjClsScoreTtlEN.ExtremeRate = objRow[conCjClsScoreTtl.ExtremeRate] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[conCjClsScoreTtl.ExtremeRate].ToString().Trim()); //极差率
objCjClsScoreTtlEN.StandardDeviation = objRow[conCjClsScoreTtl.StandardDeviation] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[conCjClsScoreTtl.StandardDeviation].ToString().Trim()); //标准差
objCjClsScoreTtlEN.FullScore = objRow[conCjClsScoreTtl.FullScore] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conCjClsScoreTtl.FullScore].ToString().Trim()); //满分
objCjClsScoreTtlEN.SchoolYear = objRow[conCjClsScoreTtl.SchoolYear] == DBNull.Value ? null : objRow[conCjClsScoreTtl.SchoolYear].ToString().Trim(); //学年
objCjClsScoreTtlEN.SchoolTerm = objRow[conCjClsScoreTtl.SchoolTerm] == DBNull.Value ? null : objRow[conCjClsScoreTtl.SchoolTerm].ToString().Trim(); //学期
objCjClsScoreTtlEN.UpdDate = objRow[conCjClsScoreTtl.UpdDate].ToString().Trim(); //修改日期
objCjClsScoreTtlEN.UpdUser = objRow[conCjClsScoreTtl.UpdUser].ToString().Trim(); //修改人
objCjClsScoreTtlEN.Memo = objRow[conCjClsScoreTtl.Memo] == DBNull.Value ? null : objRow[conCjClsScoreTtl.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsCjClsScoreTtlDA: GetObjLst)", objException.Message));
}
objCjClsScoreTtlEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objCjClsScoreTtlEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objCjClsScoreTtlEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetCjClsScoreTtl(ref clsCjClsScoreTtlEN objCjClsScoreTtlEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCjClsScoreTtlDA.GetSpecSQLObj();
strSQL = "Select * from CjClsScoreTtl where mId = " + ""+ objCjClsScoreTtlEN.mId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objCjClsScoreTtlEN.mId = TransNullToInt(objDT.Rows[0][conCjClsScoreTtl.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:True)
 objCjClsScoreTtlEN.ExamBatchId = objDT.Rows[0][conCjClsScoreTtl.ExamBatchId].ToString().Trim(); //考试批次ID(字段类型:char,字段长度:12,是否可空:False)
 objCjClsScoreTtlEN.IdCourse = objDT.Rows[0][conCjClsScoreTtl.IdCourse].ToString().Trim(); //课程流水号(字段类型:char,字段长度:8,是否可空:True)
 objCjClsScoreTtlEN.IdEduCls = objDT.Rows[0][conCjClsScoreTtl.IdEduCls].ToString().Trim(); //教学班流水号(字段类型:char,字段长度:8,是否可空:True)
 objCjClsScoreTtlEN.IdAdminCls = objDT.Rows[0][conCjClsScoreTtl.IdAdminCls].ToString().Trim(); //行政班流水号(字段类型:char,字段长度:8,是否可空:True)
 objCjClsScoreTtlEN.StuNum = TransNullToInt(objDT.Rows[0][conCjClsScoreTtl.StuNum].ToString().Trim()); //学生数(字段类型:int,字段长度:4,是否可空:True)
 objCjClsScoreTtlEN.AvgScore = TransNullToDouble(objDT.Rows[0][conCjClsScoreTtl.AvgScore].ToString().Trim()); //平均分(字段类型:decimal,字段长度:20,是否可空:True)
 objCjClsScoreTtlEN.Ranking = TransNullToInt(objDT.Rows[0][conCjClsScoreTtl.Ranking].ToString().Trim()); //名次(字段类型:int,字段长度:4,是否可空:True)
 objCjClsScoreTtlEN.Percentile = TransNullToDouble(objDT.Rows[0][conCjClsScoreTtl.Percentile].ToString().Trim()); //百分位(字段类型:decimal,字段长度:8,是否可空:True)
 objCjClsScoreTtlEN.ExcellentRate = TransNullToDouble(objDT.Rows[0][conCjClsScoreTtl.ExcellentRate].ToString().Trim()); //优秀率(字段类型:decimal,字段长度:8,是否可空:True)
 objCjClsScoreTtlEN.ExcellentGoodRate = TransNullToDouble(objDT.Rows[0][conCjClsScoreTtl.ExcellentGoodRate].ToString().Trim()); //优良率(字段类型:decimal,字段长度:8,是否可空:True)
 objCjClsScoreTtlEN.PassingRate = TransNullToDouble(objDT.Rows[0][conCjClsScoreTtl.PassingRate].ToString().Trim()); //及格率(字段类型:decimal,字段长度:8,是否可空:True)
 objCjClsScoreTtlEN.ExtremeRate = TransNullToDouble(objDT.Rows[0][conCjClsScoreTtl.ExtremeRate].ToString().Trim()); //极差率(字段类型:decimal,字段长度:8,是否可空:True)
 objCjClsScoreTtlEN.StandardDeviation = TransNullToDouble(objDT.Rows[0][conCjClsScoreTtl.StandardDeviation].ToString().Trim()); //标准差(字段类型:decimal,字段长度:8,是否可空:True)
 objCjClsScoreTtlEN.FullScore = TransNullToInt(objDT.Rows[0][conCjClsScoreTtl.FullScore].ToString().Trim()); //满分(字段类型:int,字段长度:4,是否可空:True)
 objCjClsScoreTtlEN.SchoolYear = objDT.Rows[0][conCjClsScoreTtl.SchoolYear].ToString().Trim(); //学年(字段类型:varchar,字段长度:10,是否可空:True)
 objCjClsScoreTtlEN.SchoolTerm = objDT.Rows[0][conCjClsScoreTtl.SchoolTerm].ToString().Trim(); //学期(字段类型:char,字段长度:1,是否可空:True)
 objCjClsScoreTtlEN.UpdDate = objDT.Rows[0][conCjClsScoreTtl.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objCjClsScoreTtlEN.UpdUser = objDT.Rows[0][conCjClsScoreTtl.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objCjClsScoreTtlEN.Memo = objDT.Rows[0][conCjClsScoreTtl.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsCjClsScoreTtlDA: GetCjClsScoreTtl)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public clsCjClsScoreTtlEN GetObjBymId(long lngmId)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCjClsScoreTtlDA.GetSpecSQLObj();
strSQL = "Select * from CjClsScoreTtl where mId = " + ""+ lngmId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsCjClsScoreTtlEN objCjClsScoreTtlEN = new clsCjClsScoreTtlEN();
try
{
 objCjClsScoreTtlEN.mId = Int32.Parse(objRow[conCjClsScoreTtl.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:True)
 objCjClsScoreTtlEN.ExamBatchId = objRow[conCjClsScoreTtl.ExamBatchId].ToString().Trim(); //考试批次ID(字段类型:char,字段长度:12,是否可空:False)
 objCjClsScoreTtlEN.IdCourse = objRow[conCjClsScoreTtl.IdCourse].ToString().Trim(); //课程流水号(字段类型:char,字段长度:8,是否可空:True)
 objCjClsScoreTtlEN.IdEduCls = objRow[conCjClsScoreTtl.IdEduCls].ToString().Trim(); //教学班流水号(字段类型:char,字段长度:8,是否可空:True)
 objCjClsScoreTtlEN.IdAdminCls = objRow[conCjClsScoreTtl.IdAdminCls] == DBNull.Value ? null : objRow[conCjClsScoreTtl.IdAdminCls].ToString().Trim(); //行政班流水号(字段类型:char,字段长度:8,是否可空:True)
 objCjClsScoreTtlEN.StuNum = objRow[conCjClsScoreTtl.StuNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCjClsScoreTtl.StuNum].ToString().Trim()); //学生数(字段类型:int,字段长度:4,是否可空:True)
 objCjClsScoreTtlEN.AvgScore = objRow[conCjClsScoreTtl.AvgScore] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conCjClsScoreTtl.AvgScore].ToString().Trim()); //平均分(字段类型:decimal,字段长度:20,是否可空:True)
 objCjClsScoreTtlEN.Ranking = objRow[conCjClsScoreTtl.Ranking] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCjClsScoreTtl.Ranking].ToString().Trim()); //名次(字段类型:int,字段长度:4,是否可空:True)
 objCjClsScoreTtlEN.Percentile = objRow[conCjClsScoreTtl.Percentile] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conCjClsScoreTtl.Percentile].ToString().Trim()); //百分位(字段类型:decimal,字段长度:8,是否可空:True)
 objCjClsScoreTtlEN.ExcellentRate = objRow[conCjClsScoreTtl.ExcellentRate] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conCjClsScoreTtl.ExcellentRate].ToString().Trim()); //优秀率(字段类型:decimal,字段长度:8,是否可空:True)
 objCjClsScoreTtlEN.ExcellentGoodRate = objRow[conCjClsScoreTtl.ExcellentGoodRate] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conCjClsScoreTtl.ExcellentGoodRate].ToString().Trim()); //优良率(字段类型:decimal,字段长度:8,是否可空:True)
 objCjClsScoreTtlEN.PassingRate = objRow[conCjClsScoreTtl.PassingRate] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conCjClsScoreTtl.PassingRate].ToString().Trim()); //及格率(字段类型:decimal,字段长度:8,是否可空:True)
 objCjClsScoreTtlEN.ExtremeRate = objRow[conCjClsScoreTtl.ExtremeRate] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conCjClsScoreTtl.ExtremeRate].ToString().Trim()); //极差率(字段类型:decimal,字段长度:8,是否可空:True)
 objCjClsScoreTtlEN.StandardDeviation = objRow[conCjClsScoreTtl.StandardDeviation] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conCjClsScoreTtl.StandardDeviation].ToString().Trim()); //标准差(字段类型:decimal,字段长度:8,是否可空:True)
 objCjClsScoreTtlEN.FullScore = objRow[conCjClsScoreTtl.FullScore] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCjClsScoreTtl.FullScore].ToString().Trim()); //满分(字段类型:int,字段长度:4,是否可空:True)
 objCjClsScoreTtlEN.SchoolYear = objRow[conCjClsScoreTtl.SchoolYear] == DBNull.Value ? null : objRow[conCjClsScoreTtl.SchoolYear].ToString().Trim(); //学年(字段类型:varchar,字段长度:10,是否可空:True)
 objCjClsScoreTtlEN.SchoolTerm = objRow[conCjClsScoreTtl.SchoolTerm] == DBNull.Value ? null : objRow[conCjClsScoreTtl.SchoolTerm].ToString().Trim(); //学期(字段类型:char,字段长度:1,是否可空:True)
 objCjClsScoreTtlEN.UpdDate = objRow[conCjClsScoreTtl.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objCjClsScoreTtlEN.UpdUser = objRow[conCjClsScoreTtl.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objCjClsScoreTtlEN.Memo = objRow[conCjClsScoreTtl.Memo] == DBNull.Value ? null : objRow[conCjClsScoreTtl.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsCjClsScoreTtlDA: GetObjBymId)", objException.Message));
}
return objCjClsScoreTtlEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsCjClsScoreTtlEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsCjClsScoreTtlDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCjClsScoreTtlDA.GetSpecSQLObj();
strSQL = "Select * from CjClsScoreTtl where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsCjClsScoreTtlEN objCjClsScoreTtlEN = new clsCjClsScoreTtlEN()
{
mId = TransNullToInt(objRow[conCjClsScoreTtl.mId].ToString().Trim()), //mId
ExamBatchId = objRow[conCjClsScoreTtl.ExamBatchId].ToString().Trim(), //考试批次ID
IdCourse = objRow[conCjClsScoreTtl.IdCourse].ToString().Trim(), //课程流水号
IdEduCls = objRow[conCjClsScoreTtl.IdEduCls].ToString().Trim(), //教学班流水号
IdAdminCls = objRow[conCjClsScoreTtl.IdAdminCls] == DBNull.Value ? null : objRow[conCjClsScoreTtl.IdAdminCls].ToString().Trim(), //行政班流水号
StuNum = objRow[conCjClsScoreTtl.StuNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conCjClsScoreTtl.StuNum].ToString().Trim()), //学生数
AvgScore = objRow[conCjClsScoreTtl.AvgScore] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[conCjClsScoreTtl.AvgScore].ToString().Trim()), //平均分
Ranking = objRow[conCjClsScoreTtl.Ranking] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conCjClsScoreTtl.Ranking].ToString().Trim()), //名次
Percentile = objRow[conCjClsScoreTtl.Percentile] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[conCjClsScoreTtl.Percentile].ToString().Trim()), //百分位
ExcellentRate = objRow[conCjClsScoreTtl.ExcellentRate] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[conCjClsScoreTtl.ExcellentRate].ToString().Trim()), //优秀率
ExcellentGoodRate = objRow[conCjClsScoreTtl.ExcellentGoodRate] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[conCjClsScoreTtl.ExcellentGoodRate].ToString().Trim()), //优良率
PassingRate = objRow[conCjClsScoreTtl.PassingRate] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[conCjClsScoreTtl.PassingRate].ToString().Trim()), //及格率
ExtremeRate = objRow[conCjClsScoreTtl.ExtremeRate] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[conCjClsScoreTtl.ExtremeRate].ToString().Trim()), //极差率
StandardDeviation = objRow[conCjClsScoreTtl.StandardDeviation] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[conCjClsScoreTtl.StandardDeviation].ToString().Trim()), //标准差
FullScore = objRow[conCjClsScoreTtl.FullScore] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conCjClsScoreTtl.FullScore].ToString().Trim()), //满分
SchoolYear = objRow[conCjClsScoreTtl.SchoolYear] == DBNull.Value ? null : objRow[conCjClsScoreTtl.SchoolYear].ToString().Trim(), //学年
SchoolTerm = objRow[conCjClsScoreTtl.SchoolTerm] == DBNull.Value ? null : objRow[conCjClsScoreTtl.SchoolTerm].ToString().Trim(), //学期
UpdDate = objRow[conCjClsScoreTtl.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[conCjClsScoreTtl.UpdUser].ToString().Trim(), //修改人
Memo = objRow[conCjClsScoreTtl.Memo] == DBNull.Value ? null : objRow[conCjClsScoreTtl.Memo].ToString().Trim() //备注
};
objCjClsScoreTtlEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objCjClsScoreTtlEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsCjClsScoreTtlDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsCjClsScoreTtlEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsCjClsScoreTtlEN objCjClsScoreTtlEN = new clsCjClsScoreTtlEN();
try
{
objCjClsScoreTtlEN.mId = TransNullToInt(objRow[conCjClsScoreTtl.mId].ToString().Trim()); //mId
objCjClsScoreTtlEN.ExamBatchId = objRow[conCjClsScoreTtl.ExamBatchId].ToString().Trim(); //考试批次ID
objCjClsScoreTtlEN.IdCourse = objRow[conCjClsScoreTtl.IdCourse].ToString().Trim(); //课程流水号
objCjClsScoreTtlEN.IdEduCls = objRow[conCjClsScoreTtl.IdEduCls].ToString().Trim(); //教学班流水号
objCjClsScoreTtlEN.IdAdminCls = objRow[conCjClsScoreTtl.IdAdminCls] == DBNull.Value ? null : objRow[conCjClsScoreTtl.IdAdminCls].ToString().Trim(); //行政班流水号
objCjClsScoreTtlEN.StuNum = objRow[conCjClsScoreTtl.StuNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conCjClsScoreTtl.StuNum].ToString().Trim()); //学生数
objCjClsScoreTtlEN.AvgScore = objRow[conCjClsScoreTtl.AvgScore] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[conCjClsScoreTtl.AvgScore].ToString().Trim()); //平均分
objCjClsScoreTtlEN.Ranking = objRow[conCjClsScoreTtl.Ranking] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conCjClsScoreTtl.Ranking].ToString().Trim()); //名次
objCjClsScoreTtlEN.Percentile = objRow[conCjClsScoreTtl.Percentile] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[conCjClsScoreTtl.Percentile].ToString().Trim()); //百分位
objCjClsScoreTtlEN.ExcellentRate = objRow[conCjClsScoreTtl.ExcellentRate] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[conCjClsScoreTtl.ExcellentRate].ToString().Trim()); //优秀率
objCjClsScoreTtlEN.ExcellentGoodRate = objRow[conCjClsScoreTtl.ExcellentGoodRate] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[conCjClsScoreTtl.ExcellentGoodRate].ToString().Trim()); //优良率
objCjClsScoreTtlEN.PassingRate = objRow[conCjClsScoreTtl.PassingRate] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[conCjClsScoreTtl.PassingRate].ToString().Trim()); //及格率
objCjClsScoreTtlEN.ExtremeRate = objRow[conCjClsScoreTtl.ExtremeRate] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[conCjClsScoreTtl.ExtremeRate].ToString().Trim()); //极差率
objCjClsScoreTtlEN.StandardDeviation = objRow[conCjClsScoreTtl.StandardDeviation] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[conCjClsScoreTtl.StandardDeviation].ToString().Trim()); //标准差
objCjClsScoreTtlEN.FullScore = objRow[conCjClsScoreTtl.FullScore] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conCjClsScoreTtl.FullScore].ToString().Trim()); //满分
objCjClsScoreTtlEN.SchoolYear = objRow[conCjClsScoreTtl.SchoolYear] == DBNull.Value ? null : objRow[conCjClsScoreTtl.SchoolYear].ToString().Trim(); //学年
objCjClsScoreTtlEN.SchoolTerm = objRow[conCjClsScoreTtl.SchoolTerm] == DBNull.Value ? null : objRow[conCjClsScoreTtl.SchoolTerm].ToString().Trim(); //学期
objCjClsScoreTtlEN.UpdDate = objRow[conCjClsScoreTtl.UpdDate].ToString().Trim(); //修改日期
objCjClsScoreTtlEN.UpdUser = objRow[conCjClsScoreTtl.UpdUser].ToString().Trim(); //修改人
objCjClsScoreTtlEN.Memo = objRow[conCjClsScoreTtl.Memo] == DBNull.Value ? null : objRow[conCjClsScoreTtl.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsCjClsScoreTtlDA: GetObjByDataRowCjClsScoreTtl)", objException.Message));
}
objCjClsScoreTtlEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objCjClsScoreTtlEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsCjClsScoreTtlEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsCjClsScoreTtlEN objCjClsScoreTtlEN = new clsCjClsScoreTtlEN();
try
{
objCjClsScoreTtlEN.mId = TransNullToInt(objRow[conCjClsScoreTtl.mId].ToString().Trim()); //mId
objCjClsScoreTtlEN.ExamBatchId = objRow[conCjClsScoreTtl.ExamBatchId].ToString().Trim(); //考试批次ID
objCjClsScoreTtlEN.IdCourse = objRow[conCjClsScoreTtl.IdCourse].ToString().Trim(); //课程流水号
objCjClsScoreTtlEN.IdEduCls = objRow[conCjClsScoreTtl.IdEduCls].ToString().Trim(); //教学班流水号
objCjClsScoreTtlEN.IdAdminCls = objRow[conCjClsScoreTtl.IdAdminCls] == DBNull.Value ? null : objRow[conCjClsScoreTtl.IdAdminCls].ToString().Trim(); //行政班流水号
objCjClsScoreTtlEN.StuNum = objRow[conCjClsScoreTtl.StuNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conCjClsScoreTtl.StuNum].ToString().Trim()); //学生数
objCjClsScoreTtlEN.AvgScore = objRow[conCjClsScoreTtl.AvgScore] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[conCjClsScoreTtl.AvgScore].ToString().Trim()); //平均分
objCjClsScoreTtlEN.Ranking = objRow[conCjClsScoreTtl.Ranking] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conCjClsScoreTtl.Ranking].ToString().Trim()); //名次
objCjClsScoreTtlEN.Percentile = objRow[conCjClsScoreTtl.Percentile] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[conCjClsScoreTtl.Percentile].ToString().Trim()); //百分位
objCjClsScoreTtlEN.ExcellentRate = objRow[conCjClsScoreTtl.ExcellentRate] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[conCjClsScoreTtl.ExcellentRate].ToString().Trim()); //优秀率
objCjClsScoreTtlEN.ExcellentGoodRate = objRow[conCjClsScoreTtl.ExcellentGoodRate] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[conCjClsScoreTtl.ExcellentGoodRate].ToString().Trim()); //优良率
objCjClsScoreTtlEN.PassingRate = objRow[conCjClsScoreTtl.PassingRate] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[conCjClsScoreTtl.PassingRate].ToString().Trim()); //及格率
objCjClsScoreTtlEN.ExtremeRate = objRow[conCjClsScoreTtl.ExtremeRate] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[conCjClsScoreTtl.ExtremeRate].ToString().Trim()); //极差率
objCjClsScoreTtlEN.StandardDeviation = objRow[conCjClsScoreTtl.StandardDeviation] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[conCjClsScoreTtl.StandardDeviation].ToString().Trim()); //标准差
objCjClsScoreTtlEN.FullScore = objRow[conCjClsScoreTtl.FullScore] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conCjClsScoreTtl.FullScore].ToString().Trim()); //满分
objCjClsScoreTtlEN.SchoolYear = objRow[conCjClsScoreTtl.SchoolYear] == DBNull.Value ? null : objRow[conCjClsScoreTtl.SchoolYear].ToString().Trim(); //学年
objCjClsScoreTtlEN.SchoolTerm = objRow[conCjClsScoreTtl.SchoolTerm] == DBNull.Value ? null : objRow[conCjClsScoreTtl.SchoolTerm].ToString().Trim(); //学期
objCjClsScoreTtlEN.UpdDate = objRow[conCjClsScoreTtl.UpdDate].ToString().Trim(); //修改日期
objCjClsScoreTtlEN.UpdUser = objRow[conCjClsScoreTtl.UpdUser].ToString().Trim(); //修改人
objCjClsScoreTtlEN.Memo = objRow[conCjClsScoreTtl.Memo] == DBNull.Value ? null : objRow[conCjClsScoreTtl.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsCjClsScoreTtlDA: GetObjByDataRow)", objException.Message));
}
objCjClsScoreTtlEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objCjClsScoreTtlEN;
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
objSQL = clsCjClsScoreTtlDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsCjClsScoreTtlEN._CurrTabName, conCjClsScoreTtl.mId, 8, "");
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
objSQL = clsCjClsScoreTtlDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsCjClsScoreTtlEN._CurrTabName, conCjClsScoreTtl.mId, 8, strPrefix);
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
 objSQL = clsCjClsScoreTtlDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select mId from CjClsScoreTtl where " + strCondition;
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
 objSQL = clsCjClsScoreTtlDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select mId from CjClsScoreTtl where " + strCondition;
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
 /// <param name = "lngmId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(long lngmId)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCjClsScoreTtlDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("CjClsScoreTtl", "mId = " + ""+ lngmId+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsCjClsScoreTtlDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCjClsScoreTtlDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("CjClsScoreTtl", strCondition))
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
objSQL = clsCjClsScoreTtlDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("CjClsScoreTtl");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsCjClsScoreTtlEN objCjClsScoreTtlEN)
 {
 objCjClsScoreTtlEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCjClsScoreTtlEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objCjClsScoreTtlEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCjClsScoreTtlDA.GetSpecSQLObj();
strSQL = "Select * from CjClsScoreTtl where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "CjClsScoreTtl");
objRow = objDS.Tables["CjClsScoreTtl"].NewRow();
objRow[conCjClsScoreTtl.ExamBatchId] = objCjClsScoreTtlEN.ExamBatchId; //考试批次ID
objRow[conCjClsScoreTtl.IdCourse] = objCjClsScoreTtlEN.IdCourse; //课程流水号
objRow[conCjClsScoreTtl.IdEduCls] = objCjClsScoreTtlEN.IdEduCls; //教学班流水号
 if (objCjClsScoreTtlEN.IdAdminCls !=  "")
 {
objRow[conCjClsScoreTtl.IdAdminCls] = objCjClsScoreTtlEN.IdAdminCls; //行政班流水号
 }
objRow[conCjClsScoreTtl.StuNum] = objCjClsScoreTtlEN.StuNum; //学生数
objRow[conCjClsScoreTtl.AvgScore] = objCjClsScoreTtlEN.AvgScore; //平均分
objRow[conCjClsScoreTtl.Ranking] = objCjClsScoreTtlEN.Ranking; //名次
objRow[conCjClsScoreTtl.Percentile] = objCjClsScoreTtlEN.Percentile; //百分位
objRow[conCjClsScoreTtl.ExcellentRate] = objCjClsScoreTtlEN.ExcellentRate; //优秀率
objRow[conCjClsScoreTtl.ExcellentGoodRate] = objCjClsScoreTtlEN.ExcellentGoodRate; //优良率
objRow[conCjClsScoreTtl.PassingRate] = objCjClsScoreTtlEN.PassingRate; //及格率
objRow[conCjClsScoreTtl.ExtremeRate] = objCjClsScoreTtlEN.ExtremeRate; //极差率
objRow[conCjClsScoreTtl.StandardDeviation] = objCjClsScoreTtlEN.StandardDeviation; //标准差
objRow[conCjClsScoreTtl.FullScore] = objCjClsScoreTtlEN.FullScore; //满分
 if (objCjClsScoreTtlEN.SchoolYear !=  "")
 {
objRow[conCjClsScoreTtl.SchoolYear] = objCjClsScoreTtlEN.SchoolYear; //学年
 }
 if (objCjClsScoreTtlEN.SchoolTerm !=  "")
 {
objRow[conCjClsScoreTtl.SchoolTerm] = objCjClsScoreTtlEN.SchoolTerm; //学期
 }
objRow[conCjClsScoreTtl.UpdDate] = objCjClsScoreTtlEN.UpdDate; //修改日期
objRow[conCjClsScoreTtl.UpdUser] = objCjClsScoreTtlEN.UpdUser; //修改人
 if (objCjClsScoreTtlEN.Memo !=  "")
 {
objRow[conCjClsScoreTtl.Memo] = objCjClsScoreTtlEN.Memo; //备注
 }
objDS.Tables[clsCjClsScoreTtlEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsCjClsScoreTtlEN._CurrTabName);
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
 /// <param name = "objCjClsScoreTtlEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsCjClsScoreTtlEN objCjClsScoreTtlEN)
{
 objCjClsScoreTtlEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCjClsScoreTtlEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objCjClsScoreTtlEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objCjClsScoreTtlEN.ExamBatchId !=  null)
 {
 arrFieldListForInsert.Add(conCjClsScoreTtl.ExamBatchId);
 var strExamBatchId = objCjClsScoreTtlEN.ExamBatchId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strExamBatchId + "'");
 }
 
 if (objCjClsScoreTtlEN.IdCourse !=  null)
 {
 arrFieldListForInsert.Add(conCjClsScoreTtl.IdCourse);
 var strIdCourse = objCjClsScoreTtlEN.IdCourse.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCourse + "'");
 }
 
 if (objCjClsScoreTtlEN.IdEduCls !=  null)
 {
 arrFieldListForInsert.Add(conCjClsScoreTtl.IdEduCls);
 var strIdEduCls = objCjClsScoreTtlEN.IdEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdEduCls + "'");
 }
 
 if (objCjClsScoreTtlEN.IdAdminCls !=  null)
 {
 arrFieldListForInsert.Add(conCjClsScoreTtl.IdAdminCls);
 var strIdAdminCls = objCjClsScoreTtlEN.IdAdminCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdAdminCls + "'");
 }
 
 if (objCjClsScoreTtlEN.StuNum !=  null)
 {
 arrFieldListForInsert.Add(conCjClsScoreTtl.StuNum);
 arrValueListForInsert.Add(objCjClsScoreTtlEN.StuNum.ToString());
 }
 
 if (objCjClsScoreTtlEN.AvgScore !=  null)
 {
 arrFieldListForInsert.Add(conCjClsScoreTtl.AvgScore);
 arrValueListForInsert.Add(objCjClsScoreTtlEN.AvgScore.ToString());
 }
 
 if (objCjClsScoreTtlEN.Ranking !=  null)
 {
 arrFieldListForInsert.Add(conCjClsScoreTtl.Ranking);
 arrValueListForInsert.Add(objCjClsScoreTtlEN.Ranking.ToString());
 }
 
 if (objCjClsScoreTtlEN.Percentile !=  null)
 {
 arrFieldListForInsert.Add(conCjClsScoreTtl.Percentile);
 arrValueListForInsert.Add(objCjClsScoreTtlEN.Percentile.ToString());
 }
 
 if (objCjClsScoreTtlEN.ExcellentRate !=  null)
 {
 arrFieldListForInsert.Add(conCjClsScoreTtl.ExcellentRate);
 arrValueListForInsert.Add(objCjClsScoreTtlEN.ExcellentRate.ToString());
 }
 
 if (objCjClsScoreTtlEN.ExcellentGoodRate !=  null)
 {
 arrFieldListForInsert.Add(conCjClsScoreTtl.ExcellentGoodRate);
 arrValueListForInsert.Add(objCjClsScoreTtlEN.ExcellentGoodRate.ToString());
 }
 
 if (objCjClsScoreTtlEN.PassingRate !=  null)
 {
 arrFieldListForInsert.Add(conCjClsScoreTtl.PassingRate);
 arrValueListForInsert.Add(objCjClsScoreTtlEN.PassingRate.ToString());
 }
 
 if (objCjClsScoreTtlEN.ExtremeRate !=  null)
 {
 arrFieldListForInsert.Add(conCjClsScoreTtl.ExtremeRate);
 arrValueListForInsert.Add(objCjClsScoreTtlEN.ExtremeRate.ToString());
 }
 
 if (objCjClsScoreTtlEN.StandardDeviation !=  null)
 {
 arrFieldListForInsert.Add(conCjClsScoreTtl.StandardDeviation);
 arrValueListForInsert.Add(objCjClsScoreTtlEN.StandardDeviation.ToString());
 }
 
 if (objCjClsScoreTtlEN.FullScore !=  null)
 {
 arrFieldListForInsert.Add(conCjClsScoreTtl.FullScore);
 arrValueListForInsert.Add(objCjClsScoreTtlEN.FullScore.ToString());
 }
 
 if (objCjClsScoreTtlEN.SchoolYear !=  null)
 {
 arrFieldListForInsert.Add(conCjClsScoreTtl.SchoolYear);
 var strSchoolYear = objCjClsScoreTtlEN.SchoolYear.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSchoolYear + "'");
 }
 
 if (objCjClsScoreTtlEN.SchoolTerm !=  null)
 {
 arrFieldListForInsert.Add(conCjClsScoreTtl.SchoolTerm);
 var strSchoolTerm = objCjClsScoreTtlEN.SchoolTerm.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSchoolTerm + "'");
 }
 
 if (objCjClsScoreTtlEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conCjClsScoreTtl.UpdDate);
 var strUpdDate = objCjClsScoreTtlEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objCjClsScoreTtlEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conCjClsScoreTtl.UpdUser);
 var strUpdUser = objCjClsScoreTtlEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objCjClsScoreTtlEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conCjClsScoreTtl.Memo);
 var strMemo = objCjClsScoreTtlEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into CjClsScoreTtl");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCjClsScoreTtlDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objCjClsScoreTtlEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsCjClsScoreTtlEN objCjClsScoreTtlEN)
{
 objCjClsScoreTtlEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCjClsScoreTtlEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objCjClsScoreTtlEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objCjClsScoreTtlEN.ExamBatchId !=  null)
 {
 arrFieldListForInsert.Add(conCjClsScoreTtl.ExamBatchId);
 var strExamBatchId = objCjClsScoreTtlEN.ExamBatchId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strExamBatchId + "'");
 }
 
 if (objCjClsScoreTtlEN.IdCourse !=  null)
 {
 arrFieldListForInsert.Add(conCjClsScoreTtl.IdCourse);
 var strIdCourse = objCjClsScoreTtlEN.IdCourse.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCourse + "'");
 }
 
 if (objCjClsScoreTtlEN.IdEduCls !=  null)
 {
 arrFieldListForInsert.Add(conCjClsScoreTtl.IdEduCls);
 var strIdEduCls = objCjClsScoreTtlEN.IdEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdEduCls + "'");
 }
 
 if (objCjClsScoreTtlEN.IdAdminCls !=  null)
 {
 arrFieldListForInsert.Add(conCjClsScoreTtl.IdAdminCls);
 var strIdAdminCls = objCjClsScoreTtlEN.IdAdminCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdAdminCls + "'");
 }
 
 if (objCjClsScoreTtlEN.StuNum !=  null)
 {
 arrFieldListForInsert.Add(conCjClsScoreTtl.StuNum);
 arrValueListForInsert.Add(objCjClsScoreTtlEN.StuNum.ToString());
 }
 
 if (objCjClsScoreTtlEN.AvgScore !=  null)
 {
 arrFieldListForInsert.Add(conCjClsScoreTtl.AvgScore);
 arrValueListForInsert.Add(objCjClsScoreTtlEN.AvgScore.ToString());
 }
 
 if (objCjClsScoreTtlEN.Ranking !=  null)
 {
 arrFieldListForInsert.Add(conCjClsScoreTtl.Ranking);
 arrValueListForInsert.Add(objCjClsScoreTtlEN.Ranking.ToString());
 }
 
 if (objCjClsScoreTtlEN.Percentile !=  null)
 {
 arrFieldListForInsert.Add(conCjClsScoreTtl.Percentile);
 arrValueListForInsert.Add(objCjClsScoreTtlEN.Percentile.ToString());
 }
 
 if (objCjClsScoreTtlEN.ExcellentRate !=  null)
 {
 arrFieldListForInsert.Add(conCjClsScoreTtl.ExcellentRate);
 arrValueListForInsert.Add(objCjClsScoreTtlEN.ExcellentRate.ToString());
 }
 
 if (objCjClsScoreTtlEN.ExcellentGoodRate !=  null)
 {
 arrFieldListForInsert.Add(conCjClsScoreTtl.ExcellentGoodRate);
 arrValueListForInsert.Add(objCjClsScoreTtlEN.ExcellentGoodRate.ToString());
 }
 
 if (objCjClsScoreTtlEN.PassingRate !=  null)
 {
 arrFieldListForInsert.Add(conCjClsScoreTtl.PassingRate);
 arrValueListForInsert.Add(objCjClsScoreTtlEN.PassingRate.ToString());
 }
 
 if (objCjClsScoreTtlEN.ExtremeRate !=  null)
 {
 arrFieldListForInsert.Add(conCjClsScoreTtl.ExtremeRate);
 arrValueListForInsert.Add(objCjClsScoreTtlEN.ExtremeRate.ToString());
 }
 
 if (objCjClsScoreTtlEN.StandardDeviation !=  null)
 {
 arrFieldListForInsert.Add(conCjClsScoreTtl.StandardDeviation);
 arrValueListForInsert.Add(objCjClsScoreTtlEN.StandardDeviation.ToString());
 }
 
 if (objCjClsScoreTtlEN.FullScore !=  null)
 {
 arrFieldListForInsert.Add(conCjClsScoreTtl.FullScore);
 arrValueListForInsert.Add(objCjClsScoreTtlEN.FullScore.ToString());
 }
 
 if (objCjClsScoreTtlEN.SchoolYear !=  null)
 {
 arrFieldListForInsert.Add(conCjClsScoreTtl.SchoolYear);
 var strSchoolYear = objCjClsScoreTtlEN.SchoolYear.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSchoolYear + "'");
 }
 
 if (objCjClsScoreTtlEN.SchoolTerm !=  null)
 {
 arrFieldListForInsert.Add(conCjClsScoreTtl.SchoolTerm);
 var strSchoolTerm = objCjClsScoreTtlEN.SchoolTerm.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSchoolTerm + "'");
 }
 
 if (objCjClsScoreTtlEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conCjClsScoreTtl.UpdDate);
 var strUpdDate = objCjClsScoreTtlEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objCjClsScoreTtlEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conCjClsScoreTtl.UpdUser);
 var strUpdUser = objCjClsScoreTtlEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objCjClsScoreTtlEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conCjClsScoreTtl.Memo);
 var strMemo = objCjClsScoreTtlEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into CjClsScoreTtl");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCjClsScoreTtlDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString()).Rows[0][0].ToString();
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objCjClsScoreTtlEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsCjClsScoreTtlEN objCjClsScoreTtlEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objCjClsScoreTtlEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCjClsScoreTtlEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objCjClsScoreTtlEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objCjClsScoreTtlEN.ExamBatchId !=  null)
 {
 arrFieldListForInsert.Add(conCjClsScoreTtl.ExamBatchId);
 var strExamBatchId = objCjClsScoreTtlEN.ExamBatchId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strExamBatchId + "'");
 }
 
 if (objCjClsScoreTtlEN.IdCourse !=  null)
 {
 arrFieldListForInsert.Add(conCjClsScoreTtl.IdCourse);
 var strIdCourse = objCjClsScoreTtlEN.IdCourse.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCourse + "'");
 }
 
 if (objCjClsScoreTtlEN.IdEduCls !=  null)
 {
 arrFieldListForInsert.Add(conCjClsScoreTtl.IdEduCls);
 var strIdEduCls = objCjClsScoreTtlEN.IdEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdEduCls + "'");
 }
 
 if (objCjClsScoreTtlEN.IdAdminCls !=  null)
 {
 arrFieldListForInsert.Add(conCjClsScoreTtl.IdAdminCls);
 var strIdAdminCls = objCjClsScoreTtlEN.IdAdminCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdAdminCls + "'");
 }
 
 if (objCjClsScoreTtlEN.StuNum !=  null)
 {
 arrFieldListForInsert.Add(conCjClsScoreTtl.StuNum);
 arrValueListForInsert.Add(objCjClsScoreTtlEN.StuNum.ToString());
 }
 
 if (objCjClsScoreTtlEN.AvgScore !=  null)
 {
 arrFieldListForInsert.Add(conCjClsScoreTtl.AvgScore);
 arrValueListForInsert.Add(objCjClsScoreTtlEN.AvgScore.ToString());
 }
 
 if (objCjClsScoreTtlEN.Ranking !=  null)
 {
 arrFieldListForInsert.Add(conCjClsScoreTtl.Ranking);
 arrValueListForInsert.Add(objCjClsScoreTtlEN.Ranking.ToString());
 }
 
 if (objCjClsScoreTtlEN.Percentile !=  null)
 {
 arrFieldListForInsert.Add(conCjClsScoreTtl.Percentile);
 arrValueListForInsert.Add(objCjClsScoreTtlEN.Percentile.ToString());
 }
 
 if (objCjClsScoreTtlEN.ExcellentRate !=  null)
 {
 arrFieldListForInsert.Add(conCjClsScoreTtl.ExcellentRate);
 arrValueListForInsert.Add(objCjClsScoreTtlEN.ExcellentRate.ToString());
 }
 
 if (objCjClsScoreTtlEN.ExcellentGoodRate !=  null)
 {
 arrFieldListForInsert.Add(conCjClsScoreTtl.ExcellentGoodRate);
 arrValueListForInsert.Add(objCjClsScoreTtlEN.ExcellentGoodRate.ToString());
 }
 
 if (objCjClsScoreTtlEN.PassingRate !=  null)
 {
 arrFieldListForInsert.Add(conCjClsScoreTtl.PassingRate);
 arrValueListForInsert.Add(objCjClsScoreTtlEN.PassingRate.ToString());
 }
 
 if (objCjClsScoreTtlEN.ExtremeRate !=  null)
 {
 arrFieldListForInsert.Add(conCjClsScoreTtl.ExtremeRate);
 arrValueListForInsert.Add(objCjClsScoreTtlEN.ExtremeRate.ToString());
 }
 
 if (objCjClsScoreTtlEN.StandardDeviation !=  null)
 {
 arrFieldListForInsert.Add(conCjClsScoreTtl.StandardDeviation);
 arrValueListForInsert.Add(objCjClsScoreTtlEN.StandardDeviation.ToString());
 }
 
 if (objCjClsScoreTtlEN.FullScore !=  null)
 {
 arrFieldListForInsert.Add(conCjClsScoreTtl.FullScore);
 arrValueListForInsert.Add(objCjClsScoreTtlEN.FullScore.ToString());
 }
 
 if (objCjClsScoreTtlEN.SchoolYear !=  null)
 {
 arrFieldListForInsert.Add(conCjClsScoreTtl.SchoolYear);
 var strSchoolYear = objCjClsScoreTtlEN.SchoolYear.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSchoolYear + "'");
 }
 
 if (objCjClsScoreTtlEN.SchoolTerm !=  null)
 {
 arrFieldListForInsert.Add(conCjClsScoreTtl.SchoolTerm);
 var strSchoolTerm = objCjClsScoreTtlEN.SchoolTerm.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSchoolTerm + "'");
 }
 
 if (objCjClsScoreTtlEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conCjClsScoreTtl.UpdDate);
 var strUpdDate = objCjClsScoreTtlEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objCjClsScoreTtlEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conCjClsScoreTtl.UpdUser);
 var strUpdUser = objCjClsScoreTtlEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objCjClsScoreTtlEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conCjClsScoreTtl.Memo);
 var strMemo = objCjClsScoreTtlEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into CjClsScoreTtl");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCjClsScoreTtlDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString(), objSqlConnection, objSqlTransaction).Rows[0][0].ToString();
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objCjClsScoreTtlEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsCjClsScoreTtlEN objCjClsScoreTtlEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objCjClsScoreTtlEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCjClsScoreTtlEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objCjClsScoreTtlEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objCjClsScoreTtlEN.ExamBatchId !=  null)
 {
 arrFieldListForInsert.Add(conCjClsScoreTtl.ExamBatchId);
 var strExamBatchId = objCjClsScoreTtlEN.ExamBatchId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strExamBatchId + "'");
 }
 
 if (objCjClsScoreTtlEN.IdCourse !=  null)
 {
 arrFieldListForInsert.Add(conCjClsScoreTtl.IdCourse);
 var strIdCourse = objCjClsScoreTtlEN.IdCourse.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCourse + "'");
 }
 
 if (objCjClsScoreTtlEN.IdEduCls !=  null)
 {
 arrFieldListForInsert.Add(conCjClsScoreTtl.IdEduCls);
 var strIdEduCls = objCjClsScoreTtlEN.IdEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdEduCls + "'");
 }
 
 if (objCjClsScoreTtlEN.IdAdminCls !=  null)
 {
 arrFieldListForInsert.Add(conCjClsScoreTtl.IdAdminCls);
 var strIdAdminCls = objCjClsScoreTtlEN.IdAdminCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdAdminCls + "'");
 }
 
 if (objCjClsScoreTtlEN.StuNum !=  null)
 {
 arrFieldListForInsert.Add(conCjClsScoreTtl.StuNum);
 arrValueListForInsert.Add(objCjClsScoreTtlEN.StuNum.ToString());
 }
 
 if (objCjClsScoreTtlEN.AvgScore !=  null)
 {
 arrFieldListForInsert.Add(conCjClsScoreTtl.AvgScore);
 arrValueListForInsert.Add(objCjClsScoreTtlEN.AvgScore.ToString());
 }
 
 if (objCjClsScoreTtlEN.Ranking !=  null)
 {
 arrFieldListForInsert.Add(conCjClsScoreTtl.Ranking);
 arrValueListForInsert.Add(objCjClsScoreTtlEN.Ranking.ToString());
 }
 
 if (objCjClsScoreTtlEN.Percentile !=  null)
 {
 arrFieldListForInsert.Add(conCjClsScoreTtl.Percentile);
 arrValueListForInsert.Add(objCjClsScoreTtlEN.Percentile.ToString());
 }
 
 if (objCjClsScoreTtlEN.ExcellentRate !=  null)
 {
 arrFieldListForInsert.Add(conCjClsScoreTtl.ExcellentRate);
 arrValueListForInsert.Add(objCjClsScoreTtlEN.ExcellentRate.ToString());
 }
 
 if (objCjClsScoreTtlEN.ExcellentGoodRate !=  null)
 {
 arrFieldListForInsert.Add(conCjClsScoreTtl.ExcellentGoodRate);
 arrValueListForInsert.Add(objCjClsScoreTtlEN.ExcellentGoodRate.ToString());
 }
 
 if (objCjClsScoreTtlEN.PassingRate !=  null)
 {
 arrFieldListForInsert.Add(conCjClsScoreTtl.PassingRate);
 arrValueListForInsert.Add(objCjClsScoreTtlEN.PassingRate.ToString());
 }
 
 if (objCjClsScoreTtlEN.ExtremeRate !=  null)
 {
 arrFieldListForInsert.Add(conCjClsScoreTtl.ExtremeRate);
 arrValueListForInsert.Add(objCjClsScoreTtlEN.ExtremeRate.ToString());
 }
 
 if (objCjClsScoreTtlEN.StandardDeviation !=  null)
 {
 arrFieldListForInsert.Add(conCjClsScoreTtl.StandardDeviation);
 arrValueListForInsert.Add(objCjClsScoreTtlEN.StandardDeviation.ToString());
 }
 
 if (objCjClsScoreTtlEN.FullScore !=  null)
 {
 arrFieldListForInsert.Add(conCjClsScoreTtl.FullScore);
 arrValueListForInsert.Add(objCjClsScoreTtlEN.FullScore.ToString());
 }
 
 if (objCjClsScoreTtlEN.SchoolYear !=  null)
 {
 arrFieldListForInsert.Add(conCjClsScoreTtl.SchoolYear);
 var strSchoolYear = objCjClsScoreTtlEN.SchoolYear.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSchoolYear + "'");
 }
 
 if (objCjClsScoreTtlEN.SchoolTerm !=  null)
 {
 arrFieldListForInsert.Add(conCjClsScoreTtl.SchoolTerm);
 var strSchoolTerm = objCjClsScoreTtlEN.SchoolTerm.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSchoolTerm + "'");
 }
 
 if (objCjClsScoreTtlEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conCjClsScoreTtl.UpdDate);
 var strUpdDate = objCjClsScoreTtlEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objCjClsScoreTtlEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conCjClsScoreTtl.UpdUser);
 var strUpdUser = objCjClsScoreTtlEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objCjClsScoreTtlEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conCjClsScoreTtl.Memo);
 var strMemo = objCjClsScoreTtlEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into CjClsScoreTtl");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCjClsScoreTtlDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewCjClsScoreTtls(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCjClsScoreTtlDA.GetSpecSQLObj();
strSQL = "Select * from CjClsScoreTtl where mId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "CjClsScoreTtl");
//检查关键字的唯一性
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsCjClsScoreTtlEN._CurrTabName ].NewRow();
objRow[conCjClsScoreTtl.ExamBatchId] = oRow[conCjClsScoreTtl.ExamBatchId].ToString().Trim(); //考试批次ID
objRow[conCjClsScoreTtl.IdCourse] = oRow[conCjClsScoreTtl.IdCourse].ToString().Trim(); //课程流水号
objRow[conCjClsScoreTtl.IdEduCls] = oRow[conCjClsScoreTtl.IdEduCls].ToString().Trim(); //教学班流水号
objRow[conCjClsScoreTtl.IdAdminCls] = oRow[conCjClsScoreTtl.IdAdminCls].ToString().Trim(); //行政班流水号
objRow[conCjClsScoreTtl.StuNum] = oRow[conCjClsScoreTtl.StuNum].ToString().Trim(); //学生数
objRow[conCjClsScoreTtl.AvgScore] = oRow[conCjClsScoreTtl.AvgScore].ToString().Trim(); //平均分
objRow[conCjClsScoreTtl.Ranking] = oRow[conCjClsScoreTtl.Ranking].ToString().Trim(); //名次
objRow[conCjClsScoreTtl.Percentile] = oRow[conCjClsScoreTtl.Percentile].ToString().Trim(); //百分位
objRow[conCjClsScoreTtl.ExcellentRate] = oRow[conCjClsScoreTtl.ExcellentRate].ToString().Trim(); //优秀率
objRow[conCjClsScoreTtl.ExcellentGoodRate] = oRow[conCjClsScoreTtl.ExcellentGoodRate].ToString().Trim(); //优良率
objRow[conCjClsScoreTtl.PassingRate] = oRow[conCjClsScoreTtl.PassingRate].ToString().Trim(); //及格率
objRow[conCjClsScoreTtl.ExtremeRate] = oRow[conCjClsScoreTtl.ExtremeRate].ToString().Trim(); //极差率
objRow[conCjClsScoreTtl.StandardDeviation] = oRow[conCjClsScoreTtl.StandardDeviation].ToString().Trim(); //标准差
objRow[conCjClsScoreTtl.FullScore] = oRow[conCjClsScoreTtl.FullScore].ToString().Trim(); //满分
objRow[conCjClsScoreTtl.SchoolYear] = oRow[conCjClsScoreTtl.SchoolYear].ToString().Trim(); //学年
objRow[conCjClsScoreTtl.SchoolTerm] = oRow[conCjClsScoreTtl.SchoolTerm].ToString().Trim(); //学期
objRow[conCjClsScoreTtl.UpdDate] = oRow[conCjClsScoreTtl.UpdDate].ToString().Trim(); //修改日期
objRow[conCjClsScoreTtl.UpdUser] = oRow[conCjClsScoreTtl.UpdUser].ToString().Trim(); //修改人
objRow[conCjClsScoreTtl.Memo] = oRow[conCjClsScoreTtl.Memo].ToString().Trim(); //备注
 objDS.Tables[clsCjClsScoreTtlEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsCjClsScoreTtlEN._CurrTabName);
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
 /// <param name = "objCjClsScoreTtlEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsCjClsScoreTtlEN objCjClsScoreTtlEN)
{
 objCjClsScoreTtlEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCjClsScoreTtlEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objCjClsScoreTtlEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCjClsScoreTtlDA.GetSpecSQLObj();
strSQL = "Select * from CjClsScoreTtl where mId = " + ""+ objCjClsScoreTtlEN.mId+"";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsCjClsScoreTtlEN._CurrTabName);
if (objDS.Tables[clsCjClsScoreTtlEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:mId = " + ""+ objCjClsScoreTtlEN.mId+"");
return false;
}
objRow = objDS.Tables[clsCjClsScoreTtlEN._CurrTabName].Rows[0];
 if (objCjClsScoreTtlEN.IsUpdated(conCjClsScoreTtl.ExamBatchId))
 {
objRow[conCjClsScoreTtl.ExamBatchId] = objCjClsScoreTtlEN.ExamBatchId; //考试批次ID
 }
 if (objCjClsScoreTtlEN.IsUpdated(conCjClsScoreTtl.IdCourse))
 {
objRow[conCjClsScoreTtl.IdCourse] = objCjClsScoreTtlEN.IdCourse; //课程流水号
 }
 if (objCjClsScoreTtlEN.IsUpdated(conCjClsScoreTtl.IdEduCls))
 {
objRow[conCjClsScoreTtl.IdEduCls] = objCjClsScoreTtlEN.IdEduCls; //教学班流水号
 }
 if (objCjClsScoreTtlEN.IsUpdated(conCjClsScoreTtl.IdAdminCls))
 {
objRow[conCjClsScoreTtl.IdAdminCls] = objCjClsScoreTtlEN.IdAdminCls; //行政班流水号
 }
 if (objCjClsScoreTtlEN.IsUpdated(conCjClsScoreTtl.StuNum))
 {
objRow[conCjClsScoreTtl.StuNum] = objCjClsScoreTtlEN.StuNum; //学生数
 }
 if (objCjClsScoreTtlEN.IsUpdated(conCjClsScoreTtl.AvgScore))
 {
objRow[conCjClsScoreTtl.AvgScore] = objCjClsScoreTtlEN.AvgScore; //平均分
 }
 if (objCjClsScoreTtlEN.IsUpdated(conCjClsScoreTtl.Ranking))
 {
objRow[conCjClsScoreTtl.Ranking] = objCjClsScoreTtlEN.Ranking; //名次
 }
 if (objCjClsScoreTtlEN.IsUpdated(conCjClsScoreTtl.Percentile))
 {
objRow[conCjClsScoreTtl.Percentile] = objCjClsScoreTtlEN.Percentile; //百分位
 }
 if (objCjClsScoreTtlEN.IsUpdated(conCjClsScoreTtl.ExcellentRate))
 {
objRow[conCjClsScoreTtl.ExcellentRate] = objCjClsScoreTtlEN.ExcellentRate; //优秀率
 }
 if (objCjClsScoreTtlEN.IsUpdated(conCjClsScoreTtl.ExcellentGoodRate))
 {
objRow[conCjClsScoreTtl.ExcellentGoodRate] = objCjClsScoreTtlEN.ExcellentGoodRate; //优良率
 }
 if (objCjClsScoreTtlEN.IsUpdated(conCjClsScoreTtl.PassingRate))
 {
objRow[conCjClsScoreTtl.PassingRate] = objCjClsScoreTtlEN.PassingRate; //及格率
 }
 if (objCjClsScoreTtlEN.IsUpdated(conCjClsScoreTtl.ExtremeRate))
 {
objRow[conCjClsScoreTtl.ExtremeRate] = objCjClsScoreTtlEN.ExtremeRate; //极差率
 }
 if (objCjClsScoreTtlEN.IsUpdated(conCjClsScoreTtl.StandardDeviation))
 {
objRow[conCjClsScoreTtl.StandardDeviation] = objCjClsScoreTtlEN.StandardDeviation; //标准差
 }
 if (objCjClsScoreTtlEN.IsUpdated(conCjClsScoreTtl.FullScore))
 {
objRow[conCjClsScoreTtl.FullScore] = objCjClsScoreTtlEN.FullScore; //满分
 }
 if (objCjClsScoreTtlEN.IsUpdated(conCjClsScoreTtl.SchoolYear))
 {
objRow[conCjClsScoreTtl.SchoolYear] = objCjClsScoreTtlEN.SchoolYear; //学年
 }
 if (objCjClsScoreTtlEN.IsUpdated(conCjClsScoreTtl.SchoolTerm))
 {
objRow[conCjClsScoreTtl.SchoolTerm] = objCjClsScoreTtlEN.SchoolTerm; //学期
 }
 if (objCjClsScoreTtlEN.IsUpdated(conCjClsScoreTtl.UpdDate))
 {
objRow[conCjClsScoreTtl.UpdDate] = objCjClsScoreTtlEN.UpdDate; //修改日期
 }
 if (objCjClsScoreTtlEN.IsUpdated(conCjClsScoreTtl.UpdUser))
 {
objRow[conCjClsScoreTtl.UpdUser] = objCjClsScoreTtlEN.UpdUser; //修改人
 }
 if (objCjClsScoreTtlEN.IsUpdated(conCjClsScoreTtl.Memo))
 {
objRow[conCjClsScoreTtl.Memo] = objCjClsScoreTtlEN.Memo; //备注
 }
try
{
objDA.Update(objDS, clsCjClsScoreTtlEN._CurrTabName);
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
 /// <param name = "objCjClsScoreTtlEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsCjClsScoreTtlEN objCjClsScoreTtlEN)
{
 objCjClsScoreTtlEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCjClsScoreTtlEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objCjClsScoreTtlEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCjClsScoreTtlDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update CjClsScoreTtl Set ");
 
 if (objCjClsScoreTtlEN.IsUpdated(conCjClsScoreTtl.ExamBatchId))
 {
 if (objCjClsScoreTtlEN.ExamBatchId !=  null)
 {
 var strExamBatchId = objCjClsScoreTtlEN.ExamBatchId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strExamBatchId, conCjClsScoreTtl.ExamBatchId); //考试批次ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCjClsScoreTtl.ExamBatchId); //考试批次ID
 }
 }
 
 if (objCjClsScoreTtlEN.IsUpdated(conCjClsScoreTtl.IdCourse))
 {
 if (objCjClsScoreTtlEN.IdCourse !=  null)
 {
 var strIdCourse = objCjClsScoreTtlEN.IdCourse.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdCourse, conCjClsScoreTtl.IdCourse); //课程流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCjClsScoreTtl.IdCourse); //课程流水号
 }
 }
 
 if (objCjClsScoreTtlEN.IsUpdated(conCjClsScoreTtl.IdEduCls))
 {
 if (objCjClsScoreTtlEN.IdEduCls !=  null)
 {
 var strIdEduCls = objCjClsScoreTtlEN.IdEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdEduCls, conCjClsScoreTtl.IdEduCls); //教学班流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCjClsScoreTtl.IdEduCls); //教学班流水号
 }
 }
 
 if (objCjClsScoreTtlEN.IsUpdated(conCjClsScoreTtl.IdAdminCls))
 {
 if (objCjClsScoreTtlEN.IdAdminCls !=  null)
 {
 var strIdAdminCls = objCjClsScoreTtlEN.IdAdminCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdAdminCls, conCjClsScoreTtl.IdAdminCls); //行政班流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCjClsScoreTtl.IdAdminCls); //行政班流水号
 }
 }
 
 if (objCjClsScoreTtlEN.IsUpdated(conCjClsScoreTtl.StuNum))
 {
 if (objCjClsScoreTtlEN.StuNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCjClsScoreTtlEN.StuNum, conCjClsScoreTtl.StuNum); //学生数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCjClsScoreTtl.StuNum); //学生数
 }
 }
 
 if (objCjClsScoreTtlEN.IsUpdated(conCjClsScoreTtl.AvgScore))
 {
 if (objCjClsScoreTtlEN.AvgScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCjClsScoreTtlEN.AvgScore, conCjClsScoreTtl.AvgScore); //平均分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCjClsScoreTtl.AvgScore); //平均分
 }
 }
 
 if (objCjClsScoreTtlEN.IsUpdated(conCjClsScoreTtl.Ranking))
 {
 if (objCjClsScoreTtlEN.Ranking !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCjClsScoreTtlEN.Ranking, conCjClsScoreTtl.Ranking); //名次
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCjClsScoreTtl.Ranking); //名次
 }
 }
 
 if (objCjClsScoreTtlEN.IsUpdated(conCjClsScoreTtl.Percentile))
 {
 if (objCjClsScoreTtlEN.Percentile !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCjClsScoreTtlEN.Percentile, conCjClsScoreTtl.Percentile); //百分位
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCjClsScoreTtl.Percentile); //百分位
 }
 }
 
 if (objCjClsScoreTtlEN.IsUpdated(conCjClsScoreTtl.ExcellentRate))
 {
 if (objCjClsScoreTtlEN.ExcellentRate !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCjClsScoreTtlEN.ExcellentRate, conCjClsScoreTtl.ExcellentRate); //优秀率
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCjClsScoreTtl.ExcellentRate); //优秀率
 }
 }
 
 if (objCjClsScoreTtlEN.IsUpdated(conCjClsScoreTtl.ExcellentGoodRate))
 {
 if (objCjClsScoreTtlEN.ExcellentGoodRate !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCjClsScoreTtlEN.ExcellentGoodRate, conCjClsScoreTtl.ExcellentGoodRate); //优良率
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCjClsScoreTtl.ExcellentGoodRate); //优良率
 }
 }
 
 if (objCjClsScoreTtlEN.IsUpdated(conCjClsScoreTtl.PassingRate))
 {
 if (objCjClsScoreTtlEN.PassingRate !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCjClsScoreTtlEN.PassingRate, conCjClsScoreTtl.PassingRate); //及格率
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCjClsScoreTtl.PassingRate); //及格率
 }
 }
 
 if (objCjClsScoreTtlEN.IsUpdated(conCjClsScoreTtl.ExtremeRate))
 {
 if (objCjClsScoreTtlEN.ExtremeRate !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCjClsScoreTtlEN.ExtremeRate, conCjClsScoreTtl.ExtremeRate); //极差率
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCjClsScoreTtl.ExtremeRate); //极差率
 }
 }
 
 if (objCjClsScoreTtlEN.IsUpdated(conCjClsScoreTtl.StandardDeviation))
 {
 if (objCjClsScoreTtlEN.StandardDeviation !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCjClsScoreTtlEN.StandardDeviation, conCjClsScoreTtl.StandardDeviation); //标准差
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCjClsScoreTtl.StandardDeviation); //标准差
 }
 }
 
 if (objCjClsScoreTtlEN.IsUpdated(conCjClsScoreTtl.FullScore))
 {
 if (objCjClsScoreTtlEN.FullScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCjClsScoreTtlEN.FullScore, conCjClsScoreTtl.FullScore); //满分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCjClsScoreTtl.FullScore); //满分
 }
 }
 
 if (objCjClsScoreTtlEN.IsUpdated(conCjClsScoreTtl.SchoolYear))
 {
 if (objCjClsScoreTtlEN.SchoolYear !=  null)
 {
 var strSchoolYear = objCjClsScoreTtlEN.SchoolYear.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSchoolYear, conCjClsScoreTtl.SchoolYear); //学年
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCjClsScoreTtl.SchoolYear); //学年
 }
 }
 
 if (objCjClsScoreTtlEN.IsUpdated(conCjClsScoreTtl.SchoolTerm))
 {
 if (objCjClsScoreTtlEN.SchoolTerm !=  null)
 {
 var strSchoolTerm = objCjClsScoreTtlEN.SchoolTerm.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSchoolTerm, conCjClsScoreTtl.SchoolTerm); //学期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCjClsScoreTtl.SchoolTerm); //学期
 }
 }
 
 if (objCjClsScoreTtlEN.IsUpdated(conCjClsScoreTtl.UpdDate))
 {
 if (objCjClsScoreTtlEN.UpdDate !=  null)
 {
 var strUpdDate = objCjClsScoreTtlEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conCjClsScoreTtl.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCjClsScoreTtl.UpdDate); //修改日期
 }
 }
 
 if (objCjClsScoreTtlEN.IsUpdated(conCjClsScoreTtl.UpdUser))
 {
 if (objCjClsScoreTtlEN.UpdUser !=  null)
 {
 var strUpdUser = objCjClsScoreTtlEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conCjClsScoreTtl.UpdUser); //修改人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCjClsScoreTtl.UpdUser); //修改人
 }
 }
 
 if (objCjClsScoreTtlEN.IsUpdated(conCjClsScoreTtl.Memo))
 {
 if (objCjClsScoreTtlEN.Memo !=  null)
 {
 var strMemo = objCjClsScoreTtlEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conCjClsScoreTtl.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCjClsScoreTtl.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where mId = {0}", objCjClsScoreTtlEN.mId); 
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
 /// <param name = "objCjClsScoreTtlEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsCjClsScoreTtlEN objCjClsScoreTtlEN, string strCondition)
{
 objCjClsScoreTtlEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCjClsScoreTtlEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objCjClsScoreTtlEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCjClsScoreTtlDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update CjClsScoreTtl Set ");
 
 if (objCjClsScoreTtlEN.IsUpdated(conCjClsScoreTtl.ExamBatchId))
 {
 if (objCjClsScoreTtlEN.ExamBatchId !=  null)
 {
 var strExamBatchId = objCjClsScoreTtlEN.ExamBatchId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ExamBatchId = '{0}',", strExamBatchId); //考试批次ID
 }
 else
 {
 sbSQL.Append(" ExamBatchId = null,"); //考试批次ID
 }
 }
 
 if (objCjClsScoreTtlEN.IsUpdated(conCjClsScoreTtl.IdCourse))
 {
 if (objCjClsScoreTtlEN.IdCourse !=  null)
 {
 var strIdCourse = objCjClsScoreTtlEN.IdCourse.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdCourse = '{0}',", strIdCourse); //课程流水号
 }
 else
 {
 sbSQL.Append(" IdCourse = null,"); //课程流水号
 }
 }
 
 if (objCjClsScoreTtlEN.IsUpdated(conCjClsScoreTtl.IdEduCls))
 {
 if (objCjClsScoreTtlEN.IdEduCls !=  null)
 {
 var strIdEduCls = objCjClsScoreTtlEN.IdEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdEduCls = '{0}',", strIdEduCls); //教学班流水号
 }
 else
 {
 sbSQL.Append(" IdEduCls = null,"); //教学班流水号
 }
 }
 
 if (objCjClsScoreTtlEN.IsUpdated(conCjClsScoreTtl.IdAdminCls))
 {
 if (objCjClsScoreTtlEN.IdAdminCls !=  null)
 {
 var strIdAdminCls = objCjClsScoreTtlEN.IdAdminCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdAdminCls = '{0}',", strIdAdminCls); //行政班流水号
 }
 else
 {
 sbSQL.Append(" IdAdminCls = null,"); //行政班流水号
 }
 }
 
 if (objCjClsScoreTtlEN.IsUpdated(conCjClsScoreTtl.StuNum))
 {
 if (objCjClsScoreTtlEN.StuNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCjClsScoreTtlEN.StuNum, conCjClsScoreTtl.StuNum); //学生数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCjClsScoreTtl.StuNum); //学生数
 }
 }
 
 if (objCjClsScoreTtlEN.IsUpdated(conCjClsScoreTtl.AvgScore))
 {
 if (objCjClsScoreTtlEN.AvgScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCjClsScoreTtlEN.AvgScore, conCjClsScoreTtl.AvgScore); //平均分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCjClsScoreTtl.AvgScore); //平均分
 }
 }
 
 if (objCjClsScoreTtlEN.IsUpdated(conCjClsScoreTtl.Ranking))
 {
 if (objCjClsScoreTtlEN.Ranking !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCjClsScoreTtlEN.Ranking, conCjClsScoreTtl.Ranking); //名次
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCjClsScoreTtl.Ranking); //名次
 }
 }
 
 if (objCjClsScoreTtlEN.IsUpdated(conCjClsScoreTtl.Percentile))
 {
 if (objCjClsScoreTtlEN.Percentile !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCjClsScoreTtlEN.Percentile, conCjClsScoreTtl.Percentile); //百分位
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCjClsScoreTtl.Percentile); //百分位
 }
 }
 
 if (objCjClsScoreTtlEN.IsUpdated(conCjClsScoreTtl.ExcellentRate))
 {
 if (objCjClsScoreTtlEN.ExcellentRate !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCjClsScoreTtlEN.ExcellentRate, conCjClsScoreTtl.ExcellentRate); //优秀率
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCjClsScoreTtl.ExcellentRate); //优秀率
 }
 }
 
 if (objCjClsScoreTtlEN.IsUpdated(conCjClsScoreTtl.ExcellentGoodRate))
 {
 if (objCjClsScoreTtlEN.ExcellentGoodRate !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCjClsScoreTtlEN.ExcellentGoodRate, conCjClsScoreTtl.ExcellentGoodRate); //优良率
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCjClsScoreTtl.ExcellentGoodRate); //优良率
 }
 }
 
 if (objCjClsScoreTtlEN.IsUpdated(conCjClsScoreTtl.PassingRate))
 {
 if (objCjClsScoreTtlEN.PassingRate !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCjClsScoreTtlEN.PassingRate, conCjClsScoreTtl.PassingRate); //及格率
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCjClsScoreTtl.PassingRate); //及格率
 }
 }
 
 if (objCjClsScoreTtlEN.IsUpdated(conCjClsScoreTtl.ExtremeRate))
 {
 if (objCjClsScoreTtlEN.ExtremeRate !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCjClsScoreTtlEN.ExtremeRate, conCjClsScoreTtl.ExtremeRate); //极差率
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCjClsScoreTtl.ExtremeRate); //极差率
 }
 }
 
 if (objCjClsScoreTtlEN.IsUpdated(conCjClsScoreTtl.StandardDeviation))
 {
 if (objCjClsScoreTtlEN.StandardDeviation !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCjClsScoreTtlEN.StandardDeviation, conCjClsScoreTtl.StandardDeviation); //标准差
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCjClsScoreTtl.StandardDeviation); //标准差
 }
 }
 
 if (objCjClsScoreTtlEN.IsUpdated(conCjClsScoreTtl.FullScore))
 {
 if (objCjClsScoreTtlEN.FullScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCjClsScoreTtlEN.FullScore, conCjClsScoreTtl.FullScore); //满分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCjClsScoreTtl.FullScore); //满分
 }
 }
 
 if (objCjClsScoreTtlEN.IsUpdated(conCjClsScoreTtl.SchoolYear))
 {
 if (objCjClsScoreTtlEN.SchoolYear !=  null)
 {
 var strSchoolYear = objCjClsScoreTtlEN.SchoolYear.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SchoolYear = '{0}',", strSchoolYear); //学年
 }
 else
 {
 sbSQL.Append(" SchoolYear = null,"); //学年
 }
 }
 
 if (objCjClsScoreTtlEN.IsUpdated(conCjClsScoreTtl.SchoolTerm))
 {
 if (objCjClsScoreTtlEN.SchoolTerm !=  null)
 {
 var strSchoolTerm = objCjClsScoreTtlEN.SchoolTerm.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SchoolTerm = '{0}',", strSchoolTerm); //学期
 }
 else
 {
 sbSQL.Append(" SchoolTerm = null,"); //学期
 }
 }
 
 if (objCjClsScoreTtlEN.IsUpdated(conCjClsScoreTtl.UpdDate))
 {
 if (objCjClsScoreTtlEN.UpdDate !=  null)
 {
 var strUpdDate = objCjClsScoreTtlEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objCjClsScoreTtlEN.IsUpdated(conCjClsScoreTtl.UpdUser))
 {
 if (objCjClsScoreTtlEN.UpdUser !=  null)
 {
 var strUpdUser = objCjClsScoreTtlEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改人
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改人
 }
 }
 
 if (objCjClsScoreTtlEN.IsUpdated(conCjClsScoreTtl.Memo))
 {
 if (objCjClsScoreTtlEN.Memo !=  null)
 {
 var strMemo = objCjClsScoreTtlEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objCjClsScoreTtlEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsCjClsScoreTtlEN objCjClsScoreTtlEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objCjClsScoreTtlEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCjClsScoreTtlEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objCjClsScoreTtlEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCjClsScoreTtlDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update CjClsScoreTtl Set ");
 
 if (objCjClsScoreTtlEN.IsUpdated(conCjClsScoreTtl.ExamBatchId))
 {
 if (objCjClsScoreTtlEN.ExamBatchId !=  null)
 {
 var strExamBatchId = objCjClsScoreTtlEN.ExamBatchId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ExamBatchId = '{0}',", strExamBatchId); //考试批次ID
 }
 else
 {
 sbSQL.Append(" ExamBatchId = null,"); //考试批次ID
 }
 }
 
 if (objCjClsScoreTtlEN.IsUpdated(conCjClsScoreTtl.IdCourse))
 {
 if (objCjClsScoreTtlEN.IdCourse !=  null)
 {
 var strIdCourse = objCjClsScoreTtlEN.IdCourse.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdCourse = '{0}',", strIdCourse); //课程流水号
 }
 else
 {
 sbSQL.Append(" IdCourse = null,"); //课程流水号
 }
 }
 
 if (objCjClsScoreTtlEN.IsUpdated(conCjClsScoreTtl.IdEduCls))
 {
 if (objCjClsScoreTtlEN.IdEduCls !=  null)
 {
 var strIdEduCls = objCjClsScoreTtlEN.IdEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdEduCls = '{0}',", strIdEduCls); //教学班流水号
 }
 else
 {
 sbSQL.Append(" IdEduCls = null,"); //教学班流水号
 }
 }
 
 if (objCjClsScoreTtlEN.IsUpdated(conCjClsScoreTtl.IdAdminCls))
 {
 if (objCjClsScoreTtlEN.IdAdminCls !=  null)
 {
 var strIdAdminCls = objCjClsScoreTtlEN.IdAdminCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdAdminCls = '{0}',", strIdAdminCls); //行政班流水号
 }
 else
 {
 sbSQL.Append(" IdAdminCls = null,"); //行政班流水号
 }
 }
 
 if (objCjClsScoreTtlEN.IsUpdated(conCjClsScoreTtl.StuNum))
 {
 if (objCjClsScoreTtlEN.StuNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCjClsScoreTtlEN.StuNum, conCjClsScoreTtl.StuNum); //学生数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCjClsScoreTtl.StuNum); //学生数
 }
 }
 
 if (objCjClsScoreTtlEN.IsUpdated(conCjClsScoreTtl.AvgScore))
 {
 if (objCjClsScoreTtlEN.AvgScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCjClsScoreTtlEN.AvgScore, conCjClsScoreTtl.AvgScore); //平均分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCjClsScoreTtl.AvgScore); //平均分
 }
 }
 
 if (objCjClsScoreTtlEN.IsUpdated(conCjClsScoreTtl.Ranking))
 {
 if (objCjClsScoreTtlEN.Ranking !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCjClsScoreTtlEN.Ranking, conCjClsScoreTtl.Ranking); //名次
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCjClsScoreTtl.Ranking); //名次
 }
 }
 
 if (objCjClsScoreTtlEN.IsUpdated(conCjClsScoreTtl.Percentile))
 {
 if (objCjClsScoreTtlEN.Percentile !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCjClsScoreTtlEN.Percentile, conCjClsScoreTtl.Percentile); //百分位
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCjClsScoreTtl.Percentile); //百分位
 }
 }
 
 if (objCjClsScoreTtlEN.IsUpdated(conCjClsScoreTtl.ExcellentRate))
 {
 if (objCjClsScoreTtlEN.ExcellentRate !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCjClsScoreTtlEN.ExcellentRate, conCjClsScoreTtl.ExcellentRate); //优秀率
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCjClsScoreTtl.ExcellentRate); //优秀率
 }
 }
 
 if (objCjClsScoreTtlEN.IsUpdated(conCjClsScoreTtl.ExcellentGoodRate))
 {
 if (objCjClsScoreTtlEN.ExcellentGoodRate !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCjClsScoreTtlEN.ExcellentGoodRate, conCjClsScoreTtl.ExcellentGoodRate); //优良率
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCjClsScoreTtl.ExcellentGoodRate); //优良率
 }
 }
 
 if (objCjClsScoreTtlEN.IsUpdated(conCjClsScoreTtl.PassingRate))
 {
 if (objCjClsScoreTtlEN.PassingRate !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCjClsScoreTtlEN.PassingRate, conCjClsScoreTtl.PassingRate); //及格率
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCjClsScoreTtl.PassingRate); //及格率
 }
 }
 
 if (objCjClsScoreTtlEN.IsUpdated(conCjClsScoreTtl.ExtremeRate))
 {
 if (objCjClsScoreTtlEN.ExtremeRate !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCjClsScoreTtlEN.ExtremeRate, conCjClsScoreTtl.ExtremeRate); //极差率
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCjClsScoreTtl.ExtremeRate); //极差率
 }
 }
 
 if (objCjClsScoreTtlEN.IsUpdated(conCjClsScoreTtl.StandardDeviation))
 {
 if (objCjClsScoreTtlEN.StandardDeviation !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCjClsScoreTtlEN.StandardDeviation, conCjClsScoreTtl.StandardDeviation); //标准差
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCjClsScoreTtl.StandardDeviation); //标准差
 }
 }
 
 if (objCjClsScoreTtlEN.IsUpdated(conCjClsScoreTtl.FullScore))
 {
 if (objCjClsScoreTtlEN.FullScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCjClsScoreTtlEN.FullScore, conCjClsScoreTtl.FullScore); //满分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCjClsScoreTtl.FullScore); //满分
 }
 }
 
 if (objCjClsScoreTtlEN.IsUpdated(conCjClsScoreTtl.SchoolYear))
 {
 if (objCjClsScoreTtlEN.SchoolYear !=  null)
 {
 var strSchoolYear = objCjClsScoreTtlEN.SchoolYear.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SchoolYear = '{0}',", strSchoolYear); //学年
 }
 else
 {
 sbSQL.Append(" SchoolYear = null,"); //学年
 }
 }
 
 if (objCjClsScoreTtlEN.IsUpdated(conCjClsScoreTtl.SchoolTerm))
 {
 if (objCjClsScoreTtlEN.SchoolTerm !=  null)
 {
 var strSchoolTerm = objCjClsScoreTtlEN.SchoolTerm.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SchoolTerm = '{0}',", strSchoolTerm); //学期
 }
 else
 {
 sbSQL.Append(" SchoolTerm = null,"); //学期
 }
 }
 
 if (objCjClsScoreTtlEN.IsUpdated(conCjClsScoreTtl.UpdDate))
 {
 if (objCjClsScoreTtlEN.UpdDate !=  null)
 {
 var strUpdDate = objCjClsScoreTtlEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objCjClsScoreTtlEN.IsUpdated(conCjClsScoreTtl.UpdUser))
 {
 if (objCjClsScoreTtlEN.UpdUser !=  null)
 {
 var strUpdUser = objCjClsScoreTtlEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改人
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改人
 }
 }
 
 if (objCjClsScoreTtlEN.IsUpdated(conCjClsScoreTtl.Memo))
 {
 if (objCjClsScoreTtlEN.Memo !=  null)
 {
 var strMemo = objCjClsScoreTtlEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objCjClsScoreTtlEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsCjClsScoreTtlEN objCjClsScoreTtlEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objCjClsScoreTtlEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCjClsScoreTtlEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objCjClsScoreTtlEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCjClsScoreTtlDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update CjClsScoreTtl Set ");
 
 if (objCjClsScoreTtlEN.IsUpdated(conCjClsScoreTtl.ExamBatchId))
 {
 if (objCjClsScoreTtlEN.ExamBatchId !=  null)
 {
 var strExamBatchId = objCjClsScoreTtlEN.ExamBatchId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strExamBatchId, conCjClsScoreTtl.ExamBatchId); //考试批次ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCjClsScoreTtl.ExamBatchId); //考试批次ID
 }
 }
 
 if (objCjClsScoreTtlEN.IsUpdated(conCjClsScoreTtl.IdCourse))
 {
 if (objCjClsScoreTtlEN.IdCourse !=  null)
 {
 var strIdCourse = objCjClsScoreTtlEN.IdCourse.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdCourse, conCjClsScoreTtl.IdCourse); //课程流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCjClsScoreTtl.IdCourse); //课程流水号
 }
 }
 
 if (objCjClsScoreTtlEN.IsUpdated(conCjClsScoreTtl.IdEduCls))
 {
 if (objCjClsScoreTtlEN.IdEduCls !=  null)
 {
 var strIdEduCls = objCjClsScoreTtlEN.IdEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdEduCls, conCjClsScoreTtl.IdEduCls); //教学班流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCjClsScoreTtl.IdEduCls); //教学班流水号
 }
 }
 
 if (objCjClsScoreTtlEN.IsUpdated(conCjClsScoreTtl.IdAdminCls))
 {
 if (objCjClsScoreTtlEN.IdAdminCls !=  null)
 {
 var strIdAdminCls = objCjClsScoreTtlEN.IdAdminCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdAdminCls, conCjClsScoreTtl.IdAdminCls); //行政班流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCjClsScoreTtl.IdAdminCls); //行政班流水号
 }
 }
 
 if (objCjClsScoreTtlEN.IsUpdated(conCjClsScoreTtl.StuNum))
 {
 if (objCjClsScoreTtlEN.StuNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCjClsScoreTtlEN.StuNum, conCjClsScoreTtl.StuNum); //学生数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCjClsScoreTtl.StuNum); //学生数
 }
 }
 
 if (objCjClsScoreTtlEN.IsUpdated(conCjClsScoreTtl.AvgScore))
 {
 if (objCjClsScoreTtlEN.AvgScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCjClsScoreTtlEN.AvgScore, conCjClsScoreTtl.AvgScore); //平均分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCjClsScoreTtl.AvgScore); //平均分
 }
 }
 
 if (objCjClsScoreTtlEN.IsUpdated(conCjClsScoreTtl.Ranking))
 {
 if (objCjClsScoreTtlEN.Ranking !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCjClsScoreTtlEN.Ranking, conCjClsScoreTtl.Ranking); //名次
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCjClsScoreTtl.Ranking); //名次
 }
 }
 
 if (objCjClsScoreTtlEN.IsUpdated(conCjClsScoreTtl.Percentile))
 {
 if (objCjClsScoreTtlEN.Percentile !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCjClsScoreTtlEN.Percentile, conCjClsScoreTtl.Percentile); //百分位
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCjClsScoreTtl.Percentile); //百分位
 }
 }
 
 if (objCjClsScoreTtlEN.IsUpdated(conCjClsScoreTtl.ExcellentRate))
 {
 if (objCjClsScoreTtlEN.ExcellentRate !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCjClsScoreTtlEN.ExcellentRate, conCjClsScoreTtl.ExcellentRate); //优秀率
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCjClsScoreTtl.ExcellentRate); //优秀率
 }
 }
 
 if (objCjClsScoreTtlEN.IsUpdated(conCjClsScoreTtl.ExcellentGoodRate))
 {
 if (objCjClsScoreTtlEN.ExcellentGoodRate !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCjClsScoreTtlEN.ExcellentGoodRate, conCjClsScoreTtl.ExcellentGoodRate); //优良率
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCjClsScoreTtl.ExcellentGoodRate); //优良率
 }
 }
 
 if (objCjClsScoreTtlEN.IsUpdated(conCjClsScoreTtl.PassingRate))
 {
 if (objCjClsScoreTtlEN.PassingRate !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCjClsScoreTtlEN.PassingRate, conCjClsScoreTtl.PassingRate); //及格率
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCjClsScoreTtl.PassingRate); //及格率
 }
 }
 
 if (objCjClsScoreTtlEN.IsUpdated(conCjClsScoreTtl.ExtremeRate))
 {
 if (objCjClsScoreTtlEN.ExtremeRate !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCjClsScoreTtlEN.ExtremeRate, conCjClsScoreTtl.ExtremeRate); //极差率
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCjClsScoreTtl.ExtremeRate); //极差率
 }
 }
 
 if (objCjClsScoreTtlEN.IsUpdated(conCjClsScoreTtl.StandardDeviation))
 {
 if (objCjClsScoreTtlEN.StandardDeviation !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCjClsScoreTtlEN.StandardDeviation, conCjClsScoreTtl.StandardDeviation); //标准差
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCjClsScoreTtl.StandardDeviation); //标准差
 }
 }
 
 if (objCjClsScoreTtlEN.IsUpdated(conCjClsScoreTtl.FullScore))
 {
 if (objCjClsScoreTtlEN.FullScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCjClsScoreTtlEN.FullScore, conCjClsScoreTtl.FullScore); //满分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCjClsScoreTtl.FullScore); //满分
 }
 }
 
 if (objCjClsScoreTtlEN.IsUpdated(conCjClsScoreTtl.SchoolYear))
 {
 if (objCjClsScoreTtlEN.SchoolYear !=  null)
 {
 var strSchoolYear = objCjClsScoreTtlEN.SchoolYear.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSchoolYear, conCjClsScoreTtl.SchoolYear); //学年
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCjClsScoreTtl.SchoolYear); //学年
 }
 }
 
 if (objCjClsScoreTtlEN.IsUpdated(conCjClsScoreTtl.SchoolTerm))
 {
 if (objCjClsScoreTtlEN.SchoolTerm !=  null)
 {
 var strSchoolTerm = objCjClsScoreTtlEN.SchoolTerm.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSchoolTerm, conCjClsScoreTtl.SchoolTerm); //学期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCjClsScoreTtl.SchoolTerm); //学期
 }
 }
 
 if (objCjClsScoreTtlEN.IsUpdated(conCjClsScoreTtl.UpdDate))
 {
 if (objCjClsScoreTtlEN.UpdDate !=  null)
 {
 var strUpdDate = objCjClsScoreTtlEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conCjClsScoreTtl.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCjClsScoreTtl.UpdDate); //修改日期
 }
 }
 
 if (objCjClsScoreTtlEN.IsUpdated(conCjClsScoreTtl.UpdUser))
 {
 if (objCjClsScoreTtlEN.UpdUser !=  null)
 {
 var strUpdUser = objCjClsScoreTtlEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conCjClsScoreTtl.UpdUser); //修改人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCjClsScoreTtl.UpdUser); //修改人
 }
 }
 
 if (objCjClsScoreTtlEN.IsUpdated(conCjClsScoreTtl.Memo))
 {
 if (objCjClsScoreTtlEN.Memo !=  null)
 {
 var strMemo = objCjClsScoreTtlEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conCjClsScoreTtl.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCjClsScoreTtl.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where mId = {0}", objCjClsScoreTtlEN.mId); 
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
 /// <param name = "lngmId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(long lngmId) 
{
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCjClsScoreTtlDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 lngmId,
};
 objSQL.ExecSP("CjClsScoreTtl_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "lngmId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(long lngmId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCjClsScoreTtlDA.GetSpecSQLObj();
//删除CjClsScoreTtl本表中与当前对象有关的记录
strSQL = strSQL + "Delete from CjClsScoreTtl where mId = " + ""+ lngmId+"";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelCjClsScoreTtl(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCjClsScoreTtlDA.GetSpecSQLObj();
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
//删除CjClsScoreTtl本表中与当前对象有关的记录
strSQL = strSQL + "Delete from CjClsScoreTtl where mId in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "lngmId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(long lngmId) 
{
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCjClsScoreTtlDA.GetSpecSQLObj();
//删除CjClsScoreTtl本表中与当前对象有关的记录
strSQL = strSQL + "Delete from CjClsScoreTtl where mId = " + ""+ lngmId+"";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelCjClsScoreTtl(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsCjClsScoreTtlDA: DelCjClsScoreTtl)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCjClsScoreTtlDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from CjClsScoreTtl where " + strCondition ;
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
public bool DelCjClsScoreTtlWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsCjClsScoreTtlDA: DelCjClsScoreTtlWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCjClsScoreTtlDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from CjClsScoreTtl where " + strCondition ;
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
 /// <param name = "objCjClsScoreTtlENS">源对象</param>
 /// <param name = "objCjClsScoreTtlENT">目标对象</param>
public void CopyTo(clsCjClsScoreTtlEN objCjClsScoreTtlENS, clsCjClsScoreTtlEN objCjClsScoreTtlENT)
{
objCjClsScoreTtlENT.mId = objCjClsScoreTtlENS.mId; //mId
objCjClsScoreTtlENT.ExamBatchId = objCjClsScoreTtlENS.ExamBatchId; //考试批次ID
objCjClsScoreTtlENT.IdCourse = objCjClsScoreTtlENS.IdCourse; //课程流水号
objCjClsScoreTtlENT.IdEduCls = objCjClsScoreTtlENS.IdEduCls; //教学班流水号
objCjClsScoreTtlENT.IdAdminCls = objCjClsScoreTtlENS.IdAdminCls; //行政班流水号
objCjClsScoreTtlENT.StuNum = objCjClsScoreTtlENS.StuNum; //学生数
objCjClsScoreTtlENT.AvgScore = objCjClsScoreTtlENS.AvgScore; //平均分
objCjClsScoreTtlENT.Ranking = objCjClsScoreTtlENS.Ranking; //名次
objCjClsScoreTtlENT.Percentile = objCjClsScoreTtlENS.Percentile; //百分位
objCjClsScoreTtlENT.ExcellentRate = objCjClsScoreTtlENS.ExcellentRate; //优秀率
objCjClsScoreTtlENT.ExcellentGoodRate = objCjClsScoreTtlENS.ExcellentGoodRate; //优良率
objCjClsScoreTtlENT.PassingRate = objCjClsScoreTtlENS.PassingRate; //及格率
objCjClsScoreTtlENT.ExtremeRate = objCjClsScoreTtlENS.ExtremeRate; //极差率
objCjClsScoreTtlENT.StandardDeviation = objCjClsScoreTtlENS.StandardDeviation; //标准差
objCjClsScoreTtlENT.FullScore = objCjClsScoreTtlENS.FullScore; //满分
objCjClsScoreTtlENT.SchoolYear = objCjClsScoreTtlENS.SchoolYear; //学年
objCjClsScoreTtlENT.SchoolTerm = objCjClsScoreTtlENS.SchoolTerm; //学期
objCjClsScoreTtlENT.UpdDate = objCjClsScoreTtlENS.UpdDate; //修改日期
objCjClsScoreTtlENT.UpdUser = objCjClsScoreTtlENS.UpdUser; //修改人
objCjClsScoreTtlENT.Memo = objCjClsScoreTtlENS.Memo; //备注
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsCjClsScoreTtlEN objCjClsScoreTtlEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objCjClsScoreTtlEN.ExamBatchId, conCjClsScoreTtl.ExamBatchId);
clsCheckSql.CheckFieldNotNull(objCjClsScoreTtlEN.IdCourse, conCjClsScoreTtl.IdCourse);
clsCheckSql.CheckFieldNotNull(objCjClsScoreTtlEN.IdEduCls, conCjClsScoreTtl.IdEduCls);
clsCheckSql.CheckFieldNotNull(objCjClsScoreTtlEN.UpdDate, conCjClsScoreTtl.UpdDate);
clsCheckSql.CheckFieldNotNull(objCjClsScoreTtlEN.UpdUser, conCjClsScoreTtl.UpdUser);
//检查字段长度
clsCheckSql.CheckFieldLen(objCjClsScoreTtlEN.ExamBatchId, 12, conCjClsScoreTtl.ExamBatchId);
clsCheckSql.CheckFieldLen(objCjClsScoreTtlEN.IdCourse, 8, conCjClsScoreTtl.IdCourse);
clsCheckSql.CheckFieldLen(objCjClsScoreTtlEN.IdEduCls, 8, conCjClsScoreTtl.IdEduCls);
clsCheckSql.CheckFieldLen(objCjClsScoreTtlEN.IdAdminCls, 8, conCjClsScoreTtl.IdAdminCls);
clsCheckSql.CheckFieldLen(objCjClsScoreTtlEN.SchoolYear, 10, conCjClsScoreTtl.SchoolYear);
clsCheckSql.CheckFieldLen(objCjClsScoreTtlEN.SchoolTerm, 1, conCjClsScoreTtl.SchoolTerm);
clsCheckSql.CheckFieldLen(objCjClsScoreTtlEN.UpdDate, 20, conCjClsScoreTtl.UpdDate);
clsCheckSql.CheckFieldLen(objCjClsScoreTtlEN.UpdUser, 20, conCjClsScoreTtl.UpdUser);
clsCheckSql.CheckFieldLen(objCjClsScoreTtlEN.Memo, 1000, conCjClsScoreTtl.Memo);
//检查字段外键固定长度
 objCjClsScoreTtlEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsCjClsScoreTtlEN objCjClsScoreTtlEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objCjClsScoreTtlEN.ExamBatchId, 12, conCjClsScoreTtl.ExamBatchId);
clsCheckSql.CheckFieldLen(objCjClsScoreTtlEN.IdCourse, 8, conCjClsScoreTtl.IdCourse);
clsCheckSql.CheckFieldLen(objCjClsScoreTtlEN.IdEduCls, 8, conCjClsScoreTtl.IdEduCls);
clsCheckSql.CheckFieldLen(objCjClsScoreTtlEN.IdAdminCls, 8, conCjClsScoreTtl.IdAdminCls);
clsCheckSql.CheckFieldLen(objCjClsScoreTtlEN.SchoolYear, 10, conCjClsScoreTtl.SchoolYear);
clsCheckSql.CheckFieldLen(objCjClsScoreTtlEN.SchoolTerm, 1, conCjClsScoreTtl.SchoolTerm);
clsCheckSql.CheckFieldLen(objCjClsScoreTtlEN.UpdDate, 20, conCjClsScoreTtl.UpdDate);
clsCheckSql.CheckFieldLen(objCjClsScoreTtlEN.UpdUser, 20, conCjClsScoreTtl.UpdUser);
clsCheckSql.CheckFieldLen(objCjClsScoreTtlEN.Memo, 1000, conCjClsScoreTtl.Memo);
//检查外键字段长度
 objCjClsScoreTtlEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsCjClsScoreTtlEN objCjClsScoreTtlEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objCjClsScoreTtlEN.ExamBatchId, 12, conCjClsScoreTtl.ExamBatchId);
clsCheckSql.CheckFieldLen(objCjClsScoreTtlEN.IdCourse, 8, conCjClsScoreTtl.IdCourse);
clsCheckSql.CheckFieldLen(objCjClsScoreTtlEN.IdEduCls, 8, conCjClsScoreTtl.IdEduCls);
clsCheckSql.CheckFieldLen(objCjClsScoreTtlEN.IdAdminCls, 8, conCjClsScoreTtl.IdAdminCls);
clsCheckSql.CheckFieldLen(objCjClsScoreTtlEN.SchoolYear, 10, conCjClsScoreTtl.SchoolYear);
clsCheckSql.CheckFieldLen(objCjClsScoreTtlEN.SchoolTerm, 1, conCjClsScoreTtl.SchoolTerm);
clsCheckSql.CheckFieldLen(objCjClsScoreTtlEN.UpdDate, 20, conCjClsScoreTtl.UpdDate);
clsCheckSql.CheckFieldLen(objCjClsScoreTtlEN.UpdUser, 20, conCjClsScoreTtl.UpdUser);
clsCheckSql.CheckFieldLen(objCjClsScoreTtlEN.Memo, 1000, conCjClsScoreTtl.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objCjClsScoreTtlEN.ExamBatchId, conCjClsScoreTtl.ExamBatchId);
clsCheckSql.CheckSqlInjection4Field(objCjClsScoreTtlEN.IdCourse, conCjClsScoreTtl.IdCourse);
clsCheckSql.CheckSqlInjection4Field(objCjClsScoreTtlEN.IdEduCls, conCjClsScoreTtl.IdEduCls);
clsCheckSql.CheckSqlInjection4Field(objCjClsScoreTtlEN.IdAdminCls, conCjClsScoreTtl.IdAdminCls);
clsCheckSql.CheckSqlInjection4Field(objCjClsScoreTtlEN.SchoolYear, conCjClsScoreTtl.SchoolYear);
clsCheckSql.CheckSqlInjection4Field(objCjClsScoreTtlEN.SchoolTerm, conCjClsScoreTtl.SchoolTerm);
clsCheckSql.CheckSqlInjection4Field(objCjClsScoreTtlEN.UpdDate, conCjClsScoreTtl.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objCjClsScoreTtlEN.UpdUser, conCjClsScoreTtl.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objCjClsScoreTtlEN.Memo, conCjClsScoreTtl.Memo);
//检查外键字段长度
 objCjClsScoreTtlEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--CjClsScoreTtl(班级成绩汇总),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objCjClsScoreTtlEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clsCjClsScoreTtlEN objCjClsScoreTtlEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and IdEduCls = '{0}'", objCjClsScoreTtlEN.IdEduCls);
 sbCondition.AppendFormat(" and ExamBatchId = '{0}'", objCjClsScoreTtlEN.ExamBatchId);
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
 objSQL = clsCjClsScoreTtlDA.GetSpecSQLObj();
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
 objSQL = clsCjClsScoreTtlDA.GetSpecSQLObj();
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
 objSQL = clsCjClsScoreTtlDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsCjClsScoreTtlEN._CurrTabName);
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
 objSQL = clsCjClsScoreTtlDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsCjClsScoreTtlEN._CurrTabName, strCondition);
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
 objSQL = clsCjClsScoreTtlDA.GetSpecSQLObj();
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
 objSQL = clsCjClsScoreTtlDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}