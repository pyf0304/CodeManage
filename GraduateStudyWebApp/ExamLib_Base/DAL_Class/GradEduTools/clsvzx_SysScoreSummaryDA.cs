
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvzx_SysScoreSummaryDA
 表名:vzx_SysScoreSummary(01120838)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 12:14:16
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:研培设置(GradEduTools)
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
 /// vzx_SysScoreSummary(vzx_SysScoreSummary)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvzx_SysScoreSummaryDA : clsCommBase4DA
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
 return clsvzx_SysScoreSummaryEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvzx_SysScoreSummaryEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvzx_SysScoreSummaryEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvzx_SysScoreSummaryEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvzx_SysScoreSummaryEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvzx_SysScoreSummaryDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_SysScoreSummaryDA.GetSpecSQLObj();
strSQL = "Select * from vzx_SysScoreSummary where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vzx_SysScoreSummary(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvzx_SysScoreSummaryDA: GetDataTable_vzx_SysScoreSummary)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_SysScoreSummaryDA.GetSpecSQLObj();
strSQL = "Select * from vzx_SysScoreSummary where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvzx_SysScoreSummaryDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_SysScoreSummaryDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvzx_SysScoreSummaryDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_SysScoreSummaryDA.GetSpecSQLObj();
strSQL = "Select * from vzx_SysScoreSummary where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvzx_SysScoreSummaryDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_SysScoreSummaryDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvzx_SysScoreSummaryDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_SysScoreSummaryDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vzx_SysScoreSummary where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vzx_SysScoreSummary where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvzx_SysScoreSummaryDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_SysScoreSummaryDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vzx_SysScoreSummary where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvzx_SysScoreSummaryDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_SysScoreSummaryDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vzx_SysScoreSummary.* from vzx_SysScoreSummary Left Join {1} on {2} where {3} and vzx_SysScoreSummary.mId not in (Select top {5} vzx_SysScoreSummary.mId from vzx_SysScoreSummary Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vzx_SysScoreSummary where {1} and mId not in (Select top {2} mId from vzx_SysScoreSummary where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vzx_SysScoreSummary where {1} and mId not in (Select top {3} mId from vzx_SysScoreSummary where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvzx_SysScoreSummaryDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_SysScoreSummaryDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vzx_SysScoreSummary.* from vzx_SysScoreSummary Left Join {1} on {2} where {3} and vzx_SysScoreSummary.mId not in (Select top {5} vzx_SysScoreSummary.mId from vzx_SysScoreSummary Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vzx_SysScoreSummary where {1} and mId not in (Select top {2} mId from vzx_SysScoreSummary where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vzx_SysScoreSummary where {1} and mId not in (Select top {3} mId from vzx_SysScoreSummary where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvzx_SysScoreSummaryEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvzx_SysScoreSummaryDA:GetObjLst)", objException.Message));
}
List<clsvzx_SysScoreSummaryEN> arrObjLst = new List<clsvzx_SysScoreSummaryEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_SysScoreSummaryDA.GetSpecSQLObj();
strSQL = "Select * from vzx_SysScoreSummary where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_SysScoreSummaryEN objvzx_SysScoreSummaryEN = new clsvzx_SysScoreSummaryEN();
try
{
objvzx_SysScoreSummaryEN.ScoreTypeName = objRow[convzx_SysScoreSummary.ScoreTypeName] == DBNull.Value ? null : objRow[convzx_SysScoreSummary.ScoreTypeName].ToString().Trim(); //分数类型名称
objvzx_SysScoreSummaryEN.OnlyId = objRow[convzx_SysScoreSummary.OnlyId] == DBNull.Value ? null : objRow[convzx_SysScoreSummary.OnlyId].ToString().Trim(); //OnlyId
objvzx_SysScoreSummaryEN.EduClsName = objRow[convzx_SysScoreSummary.EduClsName] == DBNull.Value ? null : objRow[convzx_SysScoreSummary.EduClsName].ToString().Trim(); //教学班名
objvzx_SysScoreSummaryEN.mId = TransNullToInt(objRow[convzx_SysScoreSummary.mId].ToString().Trim()); //mId
objvzx_SysScoreSummaryEN.UserId = objRow[convzx_SysScoreSummary.UserId].ToString().Trim(); //用户ID
objvzx_SysScoreSummaryEN.SchoolYear = objRow[convzx_SysScoreSummary.SchoolYear] == DBNull.Value ? null : objRow[convzx_SysScoreSummary.SchoolYear].ToString().Trim(); //学年
objvzx_SysScoreSummaryEN.UpdDate = objRow[convzx_SysScoreSummary.UpdDate] == DBNull.Value ? null : objRow[convzx_SysScoreSummary.UpdDate].ToString().Trim(); //修改日期
objvzx_SysScoreSummaryEN.Memo = objRow[convzx_SysScoreSummary.Memo] == DBNull.Value ? null : objRow[convzx_SysScoreSummary.Memo].ToString().Trim(); //备注
objvzx_SysScoreSummaryEN.zxScoreTypeId = objRow[convzx_SysScoreSummary.zxScoreTypeId] == DBNull.Value ? null : objRow[convzx_SysScoreSummary.zxScoreTypeId].ToString().Trim(); //分数类型Id
objvzx_SysScoreSummaryEN.UpdUser = objRow[convzx_SysScoreSummary.UpdUser] == DBNull.Value ? null : objRow[convzx_SysScoreSummary.UpdUser].ToString().Trim(); //修改人
objvzx_SysScoreSummaryEN.Score = objRow[convzx_SysScoreSummary.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convzx_SysScoreSummary.Score].ToString().Trim()); //评分
objvzx_SysScoreSummaryEN.IdCurrEduCls = objRow[convzx_SysScoreSummary.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_SysScoreSummary.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_SysScoreSummaryEN.IsSubmit = TransNullToBool(objRow[convzx_SysScoreSummary.IsSubmit].ToString().Trim()); //是否提交
objvzx_SysScoreSummaryEN.UserName = objRow[convzx_SysScoreSummary.UserName] == DBNull.Value ? null : objRow[convzx_SysScoreSummary.UserName].ToString().Trim(); //用户名
objvzx_SysScoreSummaryEN.IdXzCollege = objRow[convzx_SysScoreSummary.IdXzCollege] == DBNull.Value ? null : objRow[convzx_SysScoreSummary.IdXzCollege].ToString().Trim(); //学院流水号
objvzx_SysScoreSummaryEN.CollegeName = objRow[convzx_SysScoreSummary.CollegeName] == DBNull.Value ? null : objRow[convzx_SysScoreSummary.CollegeName].ToString().Trim(); //学院名称
objvzx_SysScoreSummaryEN.IdXzMajor = objRow[convzx_SysScoreSummary.IdXzMajor] == DBNull.Value ? null : objRow[convzx_SysScoreSummary.IdXzMajor].ToString().Trim(); //专业流水号
objvzx_SysScoreSummaryEN.IdGradeBase = objRow[convzx_SysScoreSummary.IdGradeBase] == DBNull.Value ? null : objRow[convzx_SysScoreSummary.IdGradeBase].ToString().Trim(); //年级流水号
objvzx_SysScoreSummaryEN.GradeBaseName = objRow[convzx_SysScoreSummary.GradeBaseName] == DBNull.Value ? null : objRow[convzx_SysScoreSummary.GradeBaseName].ToString().Trim(); //年级名称
objvzx_SysScoreSummaryEN.MajorName = objRow[convzx_SysScoreSummary.MajorName] == DBNull.Value ? null : objRow[convzx_SysScoreSummary.MajorName].ToString().Trim(); //专业名称
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvzx_SysScoreSummaryDA: GetObjLst)", objException.Message));
}
objvzx_SysScoreSummaryEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvzx_SysScoreSummaryEN);
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
public List<clsvzx_SysScoreSummaryEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvzx_SysScoreSummaryDA:GetObjLstByTabName)", objException.Message));
}
List<clsvzx_SysScoreSummaryEN> arrObjLst = new List<clsvzx_SysScoreSummaryEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_SysScoreSummaryDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_SysScoreSummaryEN objvzx_SysScoreSummaryEN = new clsvzx_SysScoreSummaryEN();
try
{
objvzx_SysScoreSummaryEN.ScoreTypeName = objRow[convzx_SysScoreSummary.ScoreTypeName] == DBNull.Value ? null : objRow[convzx_SysScoreSummary.ScoreTypeName].ToString().Trim(); //分数类型名称
objvzx_SysScoreSummaryEN.OnlyId = objRow[convzx_SysScoreSummary.OnlyId] == DBNull.Value ? null : objRow[convzx_SysScoreSummary.OnlyId].ToString().Trim(); //OnlyId
objvzx_SysScoreSummaryEN.EduClsName = objRow[convzx_SysScoreSummary.EduClsName] == DBNull.Value ? null : objRow[convzx_SysScoreSummary.EduClsName].ToString().Trim(); //教学班名
objvzx_SysScoreSummaryEN.mId = TransNullToInt(objRow[convzx_SysScoreSummary.mId].ToString().Trim()); //mId
objvzx_SysScoreSummaryEN.UserId = objRow[convzx_SysScoreSummary.UserId].ToString().Trim(); //用户ID
objvzx_SysScoreSummaryEN.SchoolYear = objRow[convzx_SysScoreSummary.SchoolYear] == DBNull.Value ? null : objRow[convzx_SysScoreSummary.SchoolYear].ToString().Trim(); //学年
objvzx_SysScoreSummaryEN.UpdDate = objRow[convzx_SysScoreSummary.UpdDate] == DBNull.Value ? null : objRow[convzx_SysScoreSummary.UpdDate].ToString().Trim(); //修改日期
objvzx_SysScoreSummaryEN.Memo = objRow[convzx_SysScoreSummary.Memo] == DBNull.Value ? null : objRow[convzx_SysScoreSummary.Memo].ToString().Trim(); //备注
objvzx_SysScoreSummaryEN.zxScoreTypeId = objRow[convzx_SysScoreSummary.zxScoreTypeId] == DBNull.Value ? null : objRow[convzx_SysScoreSummary.zxScoreTypeId].ToString().Trim(); //分数类型Id
objvzx_SysScoreSummaryEN.UpdUser = objRow[convzx_SysScoreSummary.UpdUser] == DBNull.Value ? null : objRow[convzx_SysScoreSummary.UpdUser].ToString().Trim(); //修改人
objvzx_SysScoreSummaryEN.Score = objRow[convzx_SysScoreSummary.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convzx_SysScoreSummary.Score].ToString().Trim()); //评分
objvzx_SysScoreSummaryEN.IdCurrEduCls = objRow[convzx_SysScoreSummary.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_SysScoreSummary.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_SysScoreSummaryEN.IsSubmit = TransNullToBool(objRow[convzx_SysScoreSummary.IsSubmit].ToString().Trim()); //是否提交
objvzx_SysScoreSummaryEN.UserName = objRow[convzx_SysScoreSummary.UserName] == DBNull.Value ? null : objRow[convzx_SysScoreSummary.UserName].ToString().Trim(); //用户名
objvzx_SysScoreSummaryEN.IdXzCollege = objRow[convzx_SysScoreSummary.IdXzCollege] == DBNull.Value ? null : objRow[convzx_SysScoreSummary.IdXzCollege].ToString().Trim(); //学院流水号
objvzx_SysScoreSummaryEN.CollegeName = objRow[convzx_SysScoreSummary.CollegeName] == DBNull.Value ? null : objRow[convzx_SysScoreSummary.CollegeName].ToString().Trim(); //学院名称
objvzx_SysScoreSummaryEN.IdXzMajor = objRow[convzx_SysScoreSummary.IdXzMajor] == DBNull.Value ? null : objRow[convzx_SysScoreSummary.IdXzMajor].ToString().Trim(); //专业流水号
objvzx_SysScoreSummaryEN.IdGradeBase = objRow[convzx_SysScoreSummary.IdGradeBase] == DBNull.Value ? null : objRow[convzx_SysScoreSummary.IdGradeBase].ToString().Trim(); //年级流水号
objvzx_SysScoreSummaryEN.GradeBaseName = objRow[convzx_SysScoreSummary.GradeBaseName] == DBNull.Value ? null : objRow[convzx_SysScoreSummary.GradeBaseName].ToString().Trim(); //年级名称
objvzx_SysScoreSummaryEN.MajorName = objRow[convzx_SysScoreSummary.MajorName] == DBNull.Value ? null : objRow[convzx_SysScoreSummary.MajorName].ToString().Trim(); //专业名称
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvzx_SysScoreSummaryDA: GetObjLst)", objException.Message));
}
objvzx_SysScoreSummaryEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvzx_SysScoreSummaryEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvzx_SysScoreSummaryEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool Getvzx_SysScoreSummary(ref clsvzx_SysScoreSummaryEN objvzx_SysScoreSummaryEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_SysScoreSummaryDA.GetSpecSQLObj();
strSQL = "Select * from vzx_SysScoreSummary where mId = " + ""+ objvzx_SysScoreSummaryEN.mId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvzx_SysScoreSummaryEN.ScoreTypeName = objDT.Rows[0][convzx_SysScoreSummary.ScoreTypeName].ToString().Trim(); //分数类型名称(字段类型:varchar,字段长度:10,是否可空:False)
 objvzx_SysScoreSummaryEN.OnlyId = objDT.Rows[0][convzx_SysScoreSummary.OnlyId].ToString().Trim(); //OnlyId(字段类型:varchar,字段长度:20,是否可空:True)
 objvzx_SysScoreSummaryEN.EduClsName = objDT.Rows[0][convzx_SysScoreSummary.EduClsName].ToString().Trim(); //教学班名(字段类型:varchar,字段长度:100,是否可空:False)
 objvzx_SysScoreSummaryEN.mId = TransNullToInt(objDT.Rows[0][convzx_SysScoreSummary.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:True)
 objvzx_SysScoreSummaryEN.UserId = objDT.Rows[0][convzx_SysScoreSummary.UserId].ToString().Trim(); //用户ID(字段类型:varchar,字段长度:18,是否可空:True)
 objvzx_SysScoreSummaryEN.SchoolYear = objDT.Rows[0][convzx_SysScoreSummary.SchoolYear].ToString().Trim(); //学年(字段类型:varchar,字段长度:10,是否可空:True)
 objvzx_SysScoreSummaryEN.UpdDate = objDT.Rows[0][convzx_SysScoreSummary.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvzx_SysScoreSummaryEN.Memo = objDT.Rows[0][convzx_SysScoreSummary.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvzx_SysScoreSummaryEN.zxScoreTypeId = objDT.Rows[0][convzx_SysScoreSummary.zxScoreTypeId].ToString().Trim(); //分数类型Id(字段类型:char,字段长度:4,是否可空:False)
 objvzx_SysScoreSummaryEN.UpdUser = objDT.Rows[0][convzx_SysScoreSummary.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objvzx_SysScoreSummaryEN.Score = TransNullToFloat(objDT.Rows[0][convzx_SysScoreSummary.Score].ToString().Trim()); //评分(字段类型:float,字段长度:8,是否可空:True)
 objvzx_SysScoreSummaryEN.IdCurrEduCls = objDT.Rows[0][convzx_SysScoreSummary.IdCurrEduCls].ToString().Trim(); //教学班流水号(字段类型:char,字段长度:8,是否可空:False)
 objvzx_SysScoreSummaryEN.IsSubmit = TransNullToBool(objDT.Rows[0][convzx_SysScoreSummary.IsSubmit].ToString().Trim()); //是否提交(字段类型:bit,字段长度:1,是否可空:True)
 objvzx_SysScoreSummaryEN.UserName = objDT.Rows[0][convzx_SysScoreSummary.UserName].ToString().Trim(); //用户名(字段类型:varchar,字段长度:30,是否可空:True)
 objvzx_SysScoreSummaryEN.IdXzCollege = objDT.Rows[0][convzx_SysScoreSummary.IdXzCollege].ToString().Trim(); //学院流水号(字段类型:char,字段长度:4,是否可空:True)
 objvzx_SysScoreSummaryEN.CollegeName = objDT.Rows[0][convzx_SysScoreSummary.CollegeName].ToString().Trim(); //学院名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvzx_SysScoreSummaryEN.IdXzMajor = objDT.Rows[0][convzx_SysScoreSummary.IdXzMajor].ToString().Trim(); //专业流水号(字段类型:char,字段长度:8,是否可空:False)
 objvzx_SysScoreSummaryEN.IdGradeBase = objDT.Rows[0][convzx_SysScoreSummary.IdGradeBase].ToString().Trim(); //年级流水号(字段类型:char,字段长度:4,是否可空:True)
 objvzx_SysScoreSummaryEN.GradeBaseName = objDT.Rows[0][convzx_SysScoreSummary.GradeBaseName].ToString().Trim(); //年级名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvzx_SysScoreSummaryEN.MajorName = objDT.Rows[0][convzx_SysScoreSummary.MajorName].ToString().Trim(); //专业名称(字段类型:varchar,字段长度:100,是否可空:False)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvzx_SysScoreSummaryDA: Getvzx_SysScoreSummary)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public clsvzx_SysScoreSummaryEN GetObjBymId(long lngmId)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_SysScoreSummaryDA.GetSpecSQLObj();
strSQL = "Select * from vzx_SysScoreSummary where mId = " + ""+ lngmId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvzx_SysScoreSummaryEN objvzx_SysScoreSummaryEN = new clsvzx_SysScoreSummaryEN();
try
{
 objvzx_SysScoreSummaryEN.ScoreTypeName = objRow[convzx_SysScoreSummary.ScoreTypeName] == DBNull.Value ? null : objRow[convzx_SysScoreSummary.ScoreTypeName].ToString().Trim(); //分数类型名称(字段类型:varchar,字段长度:10,是否可空:False)
 objvzx_SysScoreSummaryEN.OnlyId = objRow[convzx_SysScoreSummary.OnlyId] == DBNull.Value ? null : objRow[convzx_SysScoreSummary.OnlyId].ToString().Trim(); //OnlyId(字段类型:varchar,字段长度:20,是否可空:True)
 objvzx_SysScoreSummaryEN.EduClsName = objRow[convzx_SysScoreSummary.EduClsName] == DBNull.Value ? null : objRow[convzx_SysScoreSummary.EduClsName].ToString().Trim(); //教学班名(字段类型:varchar,字段长度:100,是否可空:False)
 objvzx_SysScoreSummaryEN.mId = Int32.Parse(objRow[convzx_SysScoreSummary.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:True)
 objvzx_SysScoreSummaryEN.UserId = objRow[convzx_SysScoreSummary.UserId].ToString().Trim(); //用户ID(字段类型:varchar,字段长度:18,是否可空:True)
 objvzx_SysScoreSummaryEN.SchoolYear = objRow[convzx_SysScoreSummary.SchoolYear] == DBNull.Value ? null : objRow[convzx_SysScoreSummary.SchoolYear].ToString().Trim(); //学年(字段类型:varchar,字段长度:10,是否可空:True)
 objvzx_SysScoreSummaryEN.UpdDate = objRow[convzx_SysScoreSummary.UpdDate] == DBNull.Value ? null : objRow[convzx_SysScoreSummary.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvzx_SysScoreSummaryEN.Memo = objRow[convzx_SysScoreSummary.Memo] == DBNull.Value ? null : objRow[convzx_SysScoreSummary.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvzx_SysScoreSummaryEN.zxScoreTypeId = objRow[convzx_SysScoreSummary.zxScoreTypeId] == DBNull.Value ? null : objRow[convzx_SysScoreSummary.zxScoreTypeId].ToString().Trim(); //分数类型Id(字段类型:char,字段长度:4,是否可空:False)
 objvzx_SysScoreSummaryEN.UpdUser = objRow[convzx_SysScoreSummary.UpdUser] == DBNull.Value ? null : objRow[convzx_SysScoreSummary.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objvzx_SysScoreSummaryEN.Score = objRow[convzx_SysScoreSummary.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_SysScoreSummary.Score].ToString().Trim()); //评分(字段类型:float,字段长度:8,是否可空:True)
 objvzx_SysScoreSummaryEN.IdCurrEduCls = objRow[convzx_SysScoreSummary.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_SysScoreSummary.IdCurrEduCls].ToString().Trim(); //教学班流水号(字段类型:char,字段长度:8,是否可空:False)
 objvzx_SysScoreSummaryEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convzx_SysScoreSummary.IsSubmit].ToString().Trim()); //是否提交(字段类型:bit,字段长度:1,是否可空:True)
 objvzx_SysScoreSummaryEN.UserName = objRow[convzx_SysScoreSummary.UserName] == DBNull.Value ? null : objRow[convzx_SysScoreSummary.UserName].ToString().Trim(); //用户名(字段类型:varchar,字段长度:30,是否可空:True)
 objvzx_SysScoreSummaryEN.IdXzCollege = objRow[convzx_SysScoreSummary.IdXzCollege] == DBNull.Value ? null : objRow[convzx_SysScoreSummary.IdXzCollege].ToString().Trim(); //学院流水号(字段类型:char,字段长度:4,是否可空:True)
 objvzx_SysScoreSummaryEN.CollegeName = objRow[convzx_SysScoreSummary.CollegeName] == DBNull.Value ? null : objRow[convzx_SysScoreSummary.CollegeName].ToString().Trim(); //学院名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvzx_SysScoreSummaryEN.IdXzMajor = objRow[convzx_SysScoreSummary.IdXzMajor] == DBNull.Value ? null : objRow[convzx_SysScoreSummary.IdXzMajor].ToString().Trim(); //专业流水号(字段类型:char,字段长度:8,是否可空:False)
 objvzx_SysScoreSummaryEN.IdGradeBase = objRow[convzx_SysScoreSummary.IdGradeBase] == DBNull.Value ? null : objRow[convzx_SysScoreSummary.IdGradeBase].ToString().Trim(); //年级流水号(字段类型:char,字段长度:4,是否可空:True)
 objvzx_SysScoreSummaryEN.GradeBaseName = objRow[convzx_SysScoreSummary.GradeBaseName] == DBNull.Value ? null : objRow[convzx_SysScoreSummary.GradeBaseName].ToString().Trim(); //年级名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvzx_SysScoreSummaryEN.MajorName = objRow[convzx_SysScoreSummary.MajorName] == DBNull.Value ? null : objRow[convzx_SysScoreSummary.MajorName].ToString().Trim(); //专业名称(字段类型:varchar,字段长度:100,是否可空:False)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvzx_SysScoreSummaryDA: GetObjBymId)", objException.Message));
}
return objvzx_SysScoreSummaryEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvzx_SysScoreSummaryEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvzx_SysScoreSummaryDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_SysScoreSummaryDA.GetSpecSQLObj();
strSQL = "Select * from vzx_SysScoreSummary where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvzx_SysScoreSummaryEN objvzx_SysScoreSummaryEN = new clsvzx_SysScoreSummaryEN()
{
ScoreTypeName = objRow[convzx_SysScoreSummary.ScoreTypeName] == DBNull.Value ? null : objRow[convzx_SysScoreSummary.ScoreTypeName].ToString().Trim(), //分数类型名称
OnlyId = objRow[convzx_SysScoreSummary.OnlyId] == DBNull.Value ? null : objRow[convzx_SysScoreSummary.OnlyId].ToString().Trim(), //OnlyId
EduClsName = objRow[convzx_SysScoreSummary.EduClsName] == DBNull.Value ? null : objRow[convzx_SysScoreSummary.EduClsName].ToString().Trim(), //教学班名
mId = TransNullToInt(objRow[convzx_SysScoreSummary.mId].ToString().Trim()), //mId
UserId = objRow[convzx_SysScoreSummary.UserId].ToString().Trim(), //用户ID
SchoolYear = objRow[convzx_SysScoreSummary.SchoolYear] == DBNull.Value ? null : objRow[convzx_SysScoreSummary.SchoolYear].ToString().Trim(), //学年
UpdDate = objRow[convzx_SysScoreSummary.UpdDate] == DBNull.Value ? null : objRow[convzx_SysScoreSummary.UpdDate].ToString().Trim(), //修改日期
Memo = objRow[convzx_SysScoreSummary.Memo] == DBNull.Value ? null : objRow[convzx_SysScoreSummary.Memo].ToString().Trim(), //备注
zxScoreTypeId = objRow[convzx_SysScoreSummary.zxScoreTypeId] == DBNull.Value ? null : objRow[convzx_SysScoreSummary.zxScoreTypeId].ToString().Trim(), //分数类型Id
UpdUser = objRow[convzx_SysScoreSummary.UpdUser] == DBNull.Value ? null : objRow[convzx_SysScoreSummary.UpdUser].ToString().Trim(), //修改人
Score = objRow[convzx_SysScoreSummary.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convzx_SysScoreSummary.Score].ToString().Trim()), //评分
IdCurrEduCls = objRow[convzx_SysScoreSummary.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_SysScoreSummary.IdCurrEduCls].ToString().Trim(), //教学班流水号
IsSubmit = TransNullToBool(objRow[convzx_SysScoreSummary.IsSubmit].ToString().Trim()), //是否提交
UserName = objRow[convzx_SysScoreSummary.UserName] == DBNull.Value ? null : objRow[convzx_SysScoreSummary.UserName].ToString().Trim(), //用户名
IdXzCollege = objRow[convzx_SysScoreSummary.IdXzCollege] == DBNull.Value ? null : objRow[convzx_SysScoreSummary.IdXzCollege].ToString().Trim(), //学院流水号
CollegeName = objRow[convzx_SysScoreSummary.CollegeName] == DBNull.Value ? null : objRow[convzx_SysScoreSummary.CollegeName].ToString().Trim(), //学院名称
IdXzMajor = objRow[convzx_SysScoreSummary.IdXzMajor] == DBNull.Value ? null : objRow[convzx_SysScoreSummary.IdXzMajor].ToString().Trim(), //专业流水号
IdGradeBase = objRow[convzx_SysScoreSummary.IdGradeBase] == DBNull.Value ? null : objRow[convzx_SysScoreSummary.IdGradeBase].ToString().Trim(), //年级流水号
GradeBaseName = objRow[convzx_SysScoreSummary.GradeBaseName] == DBNull.Value ? null : objRow[convzx_SysScoreSummary.GradeBaseName].ToString().Trim(), //年级名称
MajorName = objRow[convzx_SysScoreSummary.MajorName] == DBNull.Value ? null : objRow[convzx_SysScoreSummary.MajorName].ToString().Trim() //专业名称
};
objvzx_SysScoreSummaryEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvzx_SysScoreSummaryEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvzx_SysScoreSummaryDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvzx_SysScoreSummaryEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvzx_SysScoreSummaryEN objvzx_SysScoreSummaryEN = new clsvzx_SysScoreSummaryEN();
try
{
objvzx_SysScoreSummaryEN.ScoreTypeName = objRow[convzx_SysScoreSummary.ScoreTypeName] == DBNull.Value ? null : objRow[convzx_SysScoreSummary.ScoreTypeName].ToString().Trim(); //分数类型名称
objvzx_SysScoreSummaryEN.OnlyId = objRow[convzx_SysScoreSummary.OnlyId] == DBNull.Value ? null : objRow[convzx_SysScoreSummary.OnlyId].ToString().Trim(); //OnlyId
objvzx_SysScoreSummaryEN.EduClsName = objRow[convzx_SysScoreSummary.EduClsName] == DBNull.Value ? null : objRow[convzx_SysScoreSummary.EduClsName].ToString().Trim(); //教学班名
objvzx_SysScoreSummaryEN.mId = TransNullToInt(objRow[convzx_SysScoreSummary.mId].ToString().Trim()); //mId
objvzx_SysScoreSummaryEN.UserId = objRow[convzx_SysScoreSummary.UserId].ToString().Trim(); //用户ID
objvzx_SysScoreSummaryEN.SchoolYear = objRow[convzx_SysScoreSummary.SchoolYear] == DBNull.Value ? null : objRow[convzx_SysScoreSummary.SchoolYear].ToString().Trim(); //学年
objvzx_SysScoreSummaryEN.UpdDate = objRow[convzx_SysScoreSummary.UpdDate] == DBNull.Value ? null : objRow[convzx_SysScoreSummary.UpdDate].ToString().Trim(); //修改日期
objvzx_SysScoreSummaryEN.Memo = objRow[convzx_SysScoreSummary.Memo] == DBNull.Value ? null : objRow[convzx_SysScoreSummary.Memo].ToString().Trim(); //备注
objvzx_SysScoreSummaryEN.zxScoreTypeId = objRow[convzx_SysScoreSummary.zxScoreTypeId] == DBNull.Value ? null : objRow[convzx_SysScoreSummary.zxScoreTypeId].ToString().Trim(); //分数类型Id
objvzx_SysScoreSummaryEN.UpdUser = objRow[convzx_SysScoreSummary.UpdUser] == DBNull.Value ? null : objRow[convzx_SysScoreSummary.UpdUser].ToString().Trim(); //修改人
objvzx_SysScoreSummaryEN.Score = objRow[convzx_SysScoreSummary.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convzx_SysScoreSummary.Score].ToString().Trim()); //评分
objvzx_SysScoreSummaryEN.IdCurrEduCls = objRow[convzx_SysScoreSummary.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_SysScoreSummary.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_SysScoreSummaryEN.IsSubmit = TransNullToBool(objRow[convzx_SysScoreSummary.IsSubmit].ToString().Trim()); //是否提交
objvzx_SysScoreSummaryEN.UserName = objRow[convzx_SysScoreSummary.UserName] == DBNull.Value ? null : objRow[convzx_SysScoreSummary.UserName].ToString().Trim(); //用户名
objvzx_SysScoreSummaryEN.IdXzCollege = objRow[convzx_SysScoreSummary.IdXzCollege] == DBNull.Value ? null : objRow[convzx_SysScoreSummary.IdXzCollege].ToString().Trim(); //学院流水号
objvzx_SysScoreSummaryEN.CollegeName = objRow[convzx_SysScoreSummary.CollegeName] == DBNull.Value ? null : objRow[convzx_SysScoreSummary.CollegeName].ToString().Trim(); //学院名称
objvzx_SysScoreSummaryEN.IdXzMajor = objRow[convzx_SysScoreSummary.IdXzMajor] == DBNull.Value ? null : objRow[convzx_SysScoreSummary.IdXzMajor].ToString().Trim(); //专业流水号
objvzx_SysScoreSummaryEN.IdGradeBase = objRow[convzx_SysScoreSummary.IdGradeBase] == DBNull.Value ? null : objRow[convzx_SysScoreSummary.IdGradeBase].ToString().Trim(); //年级流水号
objvzx_SysScoreSummaryEN.GradeBaseName = objRow[convzx_SysScoreSummary.GradeBaseName] == DBNull.Value ? null : objRow[convzx_SysScoreSummary.GradeBaseName].ToString().Trim(); //年级名称
objvzx_SysScoreSummaryEN.MajorName = objRow[convzx_SysScoreSummary.MajorName] == DBNull.Value ? null : objRow[convzx_SysScoreSummary.MajorName].ToString().Trim(); //专业名称
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvzx_SysScoreSummaryDA: GetObjByDataRowvzx_SysScoreSummary)", objException.Message));
}
objvzx_SysScoreSummaryEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvzx_SysScoreSummaryEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvzx_SysScoreSummaryEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvzx_SysScoreSummaryEN objvzx_SysScoreSummaryEN = new clsvzx_SysScoreSummaryEN();
try
{
objvzx_SysScoreSummaryEN.ScoreTypeName = objRow[convzx_SysScoreSummary.ScoreTypeName] == DBNull.Value ? null : objRow[convzx_SysScoreSummary.ScoreTypeName].ToString().Trim(); //分数类型名称
objvzx_SysScoreSummaryEN.OnlyId = objRow[convzx_SysScoreSummary.OnlyId] == DBNull.Value ? null : objRow[convzx_SysScoreSummary.OnlyId].ToString().Trim(); //OnlyId
objvzx_SysScoreSummaryEN.EduClsName = objRow[convzx_SysScoreSummary.EduClsName] == DBNull.Value ? null : objRow[convzx_SysScoreSummary.EduClsName].ToString().Trim(); //教学班名
objvzx_SysScoreSummaryEN.mId = TransNullToInt(objRow[convzx_SysScoreSummary.mId].ToString().Trim()); //mId
objvzx_SysScoreSummaryEN.UserId = objRow[convzx_SysScoreSummary.UserId].ToString().Trim(); //用户ID
objvzx_SysScoreSummaryEN.SchoolYear = objRow[convzx_SysScoreSummary.SchoolYear] == DBNull.Value ? null : objRow[convzx_SysScoreSummary.SchoolYear].ToString().Trim(); //学年
objvzx_SysScoreSummaryEN.UpdDate = objRow[convzx_SysScoreSummary.UpdDate] == DBNull.Value ? null : objRow[convzx_SysScoreSummary.UpdDate].ToString().Trim(); //修改日期
objvzx_SysScoreSummaryEN.Memo = objRow[convzx_SysScoreSummary.Memo] == DBNull.Value ? null : objRow[convzx_SysScoreSummary.Memo].ToString().Trim(); //备注
objvzx_SysScoreSummaryEN.zxScoreTypeId = objRow[convzx_SysScoreSummary.zxScoreTypeId] == DBNull.Value ? null : objRow[convzx_SysScoreSummary.zxScoreTypeId].ToString().Trim(); //分数类型Id
objvzx_SysScoreSummaryEN.UpdUser = objRow[convzx_SysScoreSummary.UpdUser] == DBNull.Value ? null : objRow[convzx_SysScoreSummary.UpdUser].ToString().Trim(); //修改人
objvzx_SysScoreSummaryEN.Score = objRow[convzx_SysScoreSummary.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convzx_SysScoreSummary.Score].ToString().Trim()); //评分
objvzx_SysScoreSummaryEN.IdCurrEduCls = objRow[convzx_SysScoreSummary.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_SysScoreSummary.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_SysScoreSummaryEN.IsSubmit = TransNullToBool(objRow[convzx_SysScoreSummary.IsSubmit].ToString().Trim()); //是否提交
objvzx_SysScoreSummaryEN.UserName = objRow[convzx_SysScoreSummary.UserName] == DBNull.Value ? null : objRow[convzx_SysScoreSummary.UserName].ToString().Trim(); //用户名
objvzx_SysScoreSummaryEN.IdXzCollege = objRow[convzx_SysScoreSummary.IdXzCollege] == DBNull.Value ? null : objRow[convzx_SysScoreSummary.IdXzCollege].ToString().Trim(); //学院流水号
objvzx_SysScoreSummaryEN.CollegeName = objRow[convzx_SysScoreSummary.CollegeName] == DBNull.Value ? null : objRow[convzx_SysScoreSummary.CollegeName].ToString().Trim(); //学院名称
objvzx_SysScoreSummaryEN.IdXzMajor = objRow[convzx_SysScoreSummary.IdXzMajor] == DBNull.Value ? null : objRow[convzx_SysScoreSummary.IdXzMajor].ToString().Trim(); //专业流水号
objvzx_SysScoreSummaryEN.IdGradeBase = objRow[convzx_SysScoreSummary.IdGradeBase] == DBNull.Value ? null : objRow[convzx_SysScoreSummary.IdGradeBase].ToString().Trim(); //年级流水号
objvzx_SysScoreSummaryEN.GradeBaseName = objRow[convzx_SysScoreSummary.GradeBaseName] == DBNull.Value ? null : objRow[convzx_SysScoreSummary.GradeBaseName].ToString().Trim(); //年级名称
objvzx_SysScoreSummaryEN.MajorName = objRow[convzx_SysScoreSummary.MajorName] == DBNull.Value ? null : objRow[convzx_SysScoreSummary.MajorName].ToString().Trim(); //专业名称
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvzx_SysScoreSummaryDA: GetObjByDataRow)", objException.Message));
}
objvzx_SysScoreSummaryEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvzx_SysScoreSummaryEN;
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
objSQL = clsvzx_SysScoreSummaryDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvzx_SysScoreSummaryEN._CurrTabName, convzx_SysScoreSummary.mId, 8, "");
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
objSQL = clsvzx_SysScoreSummaryDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvzx_SysScoreSummaryEN._CurrTabName, convzx_SysScoreSummary.mId, 8, strPrefix);
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
 objSQL = clsvzx_SysScoreSummaryDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select mId from vzx_SysScoreSummary where " + strCondition;
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
 objSQL = clsvzx_SysScoreSummaryDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select mId from vzx_SysScoreSummary where " + strCondition;
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
 objSQL = clsvzx_SysScoreSummaryDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vzx_SysScoreSummary", "mId = " + ""+ lngmId+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvzx_SysScoreSummaryDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_SysScoreSummaryDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vzx_SysScoreSummary", strCondition))
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
objSQL = clsvzx_SysScoreSummaryDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vzx_SysScoreSummary");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvzx_SysScoreSummaryENS">源对象</param>
 /// <param name = "objvzx_SysScoreSummaryENT">目标对象</param>
public void CopyTo(clsvzx_SysScoreSummaryEN objvzx_SysScoreSummaryENS, clsvzx_SysScoreSummaryEN objvzx_SysScoreSummaryENT)
{
objvzx_SysScoreSummaryENT.ScoreTypeName = objvzx_SysScoreSummaryENS.ScoreTypeName; //分数类型名称
objvzx_SysScoreSummaryENT.OnlyId = objvzx_SysScoreSummaryENS.OnlyId; //OnlyId
objvzx_SysScoreSummaryENT.EduClsName = objvzx_SysScoreSummaryENS.EduClsName; //教学班名
objvzx_SysScoreSummaryENT.mId = objvzx_SysScoreSummaryENS.mId; //mId
objvzx_SysScoreSummaryENT.UserId = objvzx_SysScoreSummaryENS.UserId; //用户ID
objvzx_SysScoreSummaryENT.SchoolYear = objvzx_SysScoreSummaryENS.SchoolYear; //学年
objvzx_SysScoreSummaryENT.UpdDate = objvzx_SysScoreSummaryENS.UpdDate; //修改日期
objvzx_SysScoreSummaryENT.Memo = objvzx_SysScoreSummaryENS.Memo; //备注
objvzx_SysScoreSummaryENT.zxScoreTypeId = objvzx_SysScoreSummaryENS.zxScoreTypeId; //分数类型Id
objvzx_SysScoreSummaryENT.UpdUser = objvzx_SysScoreSummaryENS.UpdUser; //修改人
objvzx_SysScoreSummaryENT.Score = objvzx_SysScoreSummaryENS.Score; //评分
objvzx_SysScoreSummaryENT.IdCurrEduCls = objvzx_SysScoreSummaryENS.IdCurrEduCls; //教学班流水号
objvzx_SysScoreSummaryENT.IsSubmit = objvzx_SysScoreSummaryENS.IsSubmit; //是否提交
objvzx_SysScoreSummaryENT.UserName = objvzx_SysScoreSummaryENS.UserName; //用户名
objvzx_SysScoreSummaryENT.IdXzCollege = objvzx_SysScoreSummaryENS.IdXzCollege; //学院流水号
objvzx_SysScoreSummaryENT.CollegeName = objvzx_SysScoreSummaryENS.CollegeName; //学院名称
objvzx_SysScoreSummaryENT.IdXzMajor = objvzx_SysScoreSummaryENS.IdXzMajor; //专业流水号
objvzx_SysScoreSummaryENT.IdGradeBase = objvzx_SysScoreSummaryENS.IdGradeBase; //年级流水号
objvzx_SysScoreSummaryENT.GradeBaseName = objvzx_SysScoreSummaryENS.GradeBaseName; //年级名称
objvzx_SysScoreSummaryENT.MajorName = objvzx_SysScoreSummaryENS.MajorName; //专业名称
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvzx_SysScoreSummaryEN objvzx_SysScoreSummaryEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvzx_SysScoreSummaryEN.ScoreTypeName, 10, convzx_SysScoreSummary.ScoreTypeName);
clsCheckSql.CheckFieldLen(objvzx_SysScoreSummaryEN.OnlyId, 20, convzx_SysScoreSummary.OnlyId);
clsCheckSql.CheckFieldLen(objvzx_SysScoreSummaryEN.EduClsName, 100, convzx_SysScoreSummary.EduClsName);
clsCheckSql.CheckFieldLen(objvzx_SysScoreSummaryEN.UserId, 18, convzx_SysScoreSummary.UserId);
clsCheckSql.CheckFieldLen(objvzx_SysScoreSummaryEN.SchoolYear, 10, convzx_SysScoreSummary.SchoolYear);
clsCheckSql.CheckFieldLen(objvzx_SysScoreSummaryEN.UpdDate, 20, convzx_SysScoreSummary.UpdDate);
clsCheckSql.CheckFieldLen(objvzx_SysScoreSummaryEN.Memo, 1000, convzx_SysScoreSummary.Memo);
clsCheckSql.CheckFieldLen(objvzx_SysScoreSummaryEN.zxScoreTypeId, 4, convzx_SysScoreSummary.zxScoreTypeId);
clsCheckSql.CheckFieldLen(objvzx_SysScoreSummaryEN.UpdUser, 20, convzx_SysScoreSummary.UpdUser);
clsCheckSql.CheckFieldLen(objvzx_SysScoreSummaryEN.IdCurrEduCls, 8, convzx_SysScoreSummary.IdCurrEduCls);
clsCheckSql.CheckFieldLen(objvzx_SysScoreSummaryEN.UserName, 30, convzx_SysScoreSummary.UserName);
clsCheckSql.CheckFieldLen(objvzx_SysScoreSummaryEN.IdXzCollege, 4, convzx_SysScoreSummary.IdXzCollege);
clsCheckSql.CheckFieldLen(objvzx_SysScoreSummaryEN.CollegeName, 100, convzx_SysScoreSummary.CollegeName);
clsCheckSql.CheckFieldLen(objvzx_SysScoreSummaryEN.IdXzMajor, 8, convzx_SysScoreSummary.IdXzMajor);
clsCheckSql.CheckFieldLen(objvzx_SysScoreSummaryEN.IdGradeBase, 4, convzx_SysScoreSummary.IdGradeBase);
clsCheckSql.CheckFieldLen(objvzx_SysScoreSummaryEN.GradeBaseName, 50, convzx_SysScoreSummary.GradeBaseName);
clsCheckSql.CheckFieldLen(objvzx_SysScoreSummaryEN.MajorName, 100, convzx_SysScoreSummary.MajorName);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvzx_SysScoreSummaryEN.ScoreTypeName, convzx_SysScoreSummary.ScoreTypeName);
clsCheckSql.CheckSqlInjection4Field(objvzx_SysScoreSummaryEN.OnlyId, convzx_SysScoreSummary.OnlyId);
clsCheckSql.CheckSqlInjection4Field(objvzx_SysScoreSummaryEN.EduClsName, convzx_SysScoreSummary.EduClsName);
clsCheckSql.CheckSqlInjection4Field(objvzx_SysScoreSummaryEN.UserId, convzx_SysScoreSummary.UserId);
clsCheckSql.CheckSqlInjection4Field(objvzx_SysScoreSummaryEN.SchoolYear, convzx_SysScoreSummary.SchoolYear);
clsCheckSql.CheckSqlInjection4Field(objvzx_SysScoreSummaryEN.UpdDate, convzx_SysScoreSummary.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objvzx_SysScoreSummaryEN.Memo, convzx_SysScoreSummary.Memo);
clsCheckSql.CheckSqlInjection4Field(objvzx_SysScoreSummaryEN.zxScoreTypeId, convzx_SysScoreSummary.zxScoreTypeId);
clsCheckSql.CheckSqlInjection4Field(objvzx_SysScoreSummaryEN.UpdUser, convzx_SysScoreSummary.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objvzx_SysScoreSummaryEN.IdCurrEduCls, convzx_SysScoreSummary.IdCurrEduCls);
clsCheckSql.CheckSqlInjection4Field(objvzx_SysScoreSummaryEN.UserName, convzx_SysScoreSummary.UserName);
clsCheckSql.CheckSqlInjection4Field(objvzx_SysScoreSummaryEN.IdXzCollege, convzx_SysScoreSummary.IdXzCollege);
clsCheckSql.CheckSqlInjection4Field(objvzx_SysScoreSummaryEN.CollegeName, convzx_SysScoreSummary.CollegeName);
clsCheckSql.CheckSqlInjection4Field(objvzx_SysScoreSummaryEN.IdXzMajor, convzx_SysScoreSummary.IdXzMajor);
clsCheckSql.CheckSqlInjection4Field(objvzx_SysScoreSummaryEN.IdGradeBase, convzx_SysScoreSummary.IdGradeBase);
clsCheckSql.CheckSqlInjection4Field(objvzx_SysScoreSummaryEN.GradeBaseName, convzx_SysScoreSummary.GradeBaseName);
clsCheckSql.CheckSqlInjection4Field(objvzx_SysScoreSummaryEN.MajorName, convzx_SysScoreSummary.MajorName);
//检查外键字段长度
 objvzx_SysScoreSummaryEN._IsCheckProperty = true;
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
 objSQL = clsvzx_SysScoreSummaryDA.GetSpecSQLObj();
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
 objSQL = clsvzx_SysScoreSummaryDA.GetSpecSQLObj();
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
 objSQL = clsvzx_SysScoreSummaryDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvzx_SysScoreSummaryEN._CurrTabName);
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
 objSQL = clsvzx_SysScoreSummaryDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvzx_SysScoreSummaryEN._CurrTabName, strCondition);
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
 objSQL = clsvzx_SysScoreSummaryDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}