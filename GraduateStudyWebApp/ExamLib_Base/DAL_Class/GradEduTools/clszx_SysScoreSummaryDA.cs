
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clszx_SysScoreSummaryDA
 表名:zx_SysScoreSummary(01120798)
 * 版本:2023.11.15.1(服务器:WIN-SRV103-116)
 日期:2023/11/15 23:07:08
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(变量首字母不限定)-WebApi函数集
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
 /// 中学系统分数汇总表(zx_SysScoreSummary)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clszx_SysScoreSummaryDA : clsCommBase4DA
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
 return clszx_SysScoreSummaryEN._CurrTabName;
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
if (string.IsNullOrEmpty(clszx_SysScoreSummaryEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clszx_SysScoreSummaryEN._ConnectString);
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
 if (string.IsNullOrEmpty(clszx_SysScoreSummaryEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clszx_SysScoreSummaryEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clszx_SysScoreSummaryDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_SysScoreSummaryDA.GetSpecSQLObj();
strSQL = "Select * from zx_SysScoreSummary where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_zx_SysScoreSummary(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clszx_SysScoreSummaryDA: GetDataTable_zx_SysScoreSummary)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_SysScoreSummaryDA.GetSpecSQLObj();
strSQL = "Select * from zx_SysScoreSummary where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clszx_SysScoreSummaryDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_SysScoreSummaryDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clszx_SysScoreSummaryDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_SysScoreSummaryDA.GetSpecSQLObj();
strSQL = "Select * from zx_SysScoreSummary where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clszx_SysScoreSummaryDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_SysScoreSummaryDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clszx_SysScoreSummaryDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_SysScoreSummaryDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from zx_SysScoreSummary where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from zx_SysScoreSummary where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clszx_SysScoreSummaryDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_SysScoreSummaryDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from zx_SysScoreSummary where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clszx_SysScoreSummaryDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_SysScoreSummaryDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} zx_SysScoreSummary.* from zx_SysScoreSummary Left Join {1} on {2} where {3} and zx_SysScoreSummary.mId not in (Select top {5} zx_SysScoreSummary.mId from zx_SysScoreSummary Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from zx_SysScoreSummary where {1} and mId not in (Select top {2} mId from zx_SysScoreSummary where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from zx_SysScoreSummary where {1} and mId not in (Select top {3} mId from zx_SysScoreSummary where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clszx_SysScoreSummaryDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_SysScoreSummaryDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} zx_SysScoreSummary.* from zx_SysScoreSummary Left Join {1} on {2} where {3} and zx_SysScoreSummary.mId not in (Select top {5} zx_SysScoreSummary.mId from zx_SysScoreSummary Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from zx_SysScoreSummary where {1} and mId not in (Select top {2} mId from zx_SysScoreSummary where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from zx_SysScoreSummary where {1} and mId not in (Select top {3} mId from zx_SysScoreSummary where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clszx_SysScoreSummaryEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clszx_SysScoreSummaryDA:GetObjLst)", objException.Message));
}
List<clszx_SysScoreSummaryEN> arrObjLst = new List<clszx_SysScoreSummaryEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_SysScoreSummaryDA.GetSpecSQLObj();
strSQL = "Select * from zx_SysScoreSummary where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_SysScoreSummaryEN objzx_SysScoreSummaryEN = new clszx_SysScoreSummaryEN();
try
{
objzx_SysScoreSummaryEN.mId = TransNullToInt(objRow[conzx_SysScoreSummary.mId].ToString().Trim()); //mId
objzx_SysScoreSummaryEN.UserId = objRow[conzx_SysScoreSummary.UserId].ToString().Trim(); //用户ID
objzx_SysScoreSummaryEN.SchoolYear = objRow[conzx_SysScoreSummary.SchoolYear] == DBNull.Value ? null : objRow[conzx_SysScoreSummary.SchoolYear].ToString().Trim(); //学年
objzx_SysScoreSummaryEN.zxScoreTypeId = objRow[conzx_SysScoreSummary.zxScoreTypeId] == DBNull.Value ? null : objRow[conzx_SysScoreSummary.zxScoreTypeId].ToString().Trim(); //分数类型Id
objzx_SysScoreSummaryEN.Score = objRow[conzx_SysScoreSummary.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conzx_SysScoreSummary.Score].ToString().Trim()); //评分
objzx_SysScoreSummaryEN.IdCurrEduCls = objRow[conzx_SysScoreSummary.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_SysScoreSummary.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_SysScoreSummaryEN.IsSubmit = TransNullToBool(objRow[conzx_SysScoreSummary.IsSubmit].ToString().Trim()); //是否提交
objzx_SysScoreSummaryEN.UpdDate = objRow[conzx_SysScoreSummary.UpdDate] == DBNull.Value ? null : objRow[conzx_SysScoreSummary.UpdDate].ToString().Trim(); //修改日期
objzx_SysScoreSummaryEN.UpdUser = objRow[conzx_SysScoreSummary.UpdUser] == DBNull.Value ? null : objRow[conzx_SysScoreSummary.UpdUser].ToString().Trim(); //修改人
objzx_SysScoreSummaryEN.Memo = objRow[conzx_SysScoreSummary.Memo] == DBNull.Value ? null : objRow[conzx_SysScoreSummary.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clszx_SysScoreSummaryDA: GetObjLst)", objException.Message));
}
objzx_SysScoreSummaryEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objzx_SysScoreSummaryEN);
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
public List<clszx_SysScoreSummaryEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clszx_SysScoreSummaryDA:GetObjLstByTabName)", objException.Message));
}
List<clszx_SysScoreSummaryEN> arrObjLst = new List<clszx_SysScoreSummaryEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_SysScoreSummaryDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_SysScoreSummaryEN objzx_SysScoreSummaryEN = new clszx_SysScoreSummaryEN();
try
{
objzx_SysScoreSummaryEN.mId = TransNullToInt(objRow[conzx_SysScoreSummary.mId].ToString().Trim()); //mId
objzx_SysScoreSummaryEN.UserId = objRow[conzx_SysScoreSummary.UserId].ToString().Trim(); //用户ID
objzx_SysScoreSummaryEN.SchoolYear = objRow[conzx_SysScoreSummary.SchoolYear] == DBNull.Value ? null : objRow[conzx_SysScoreSummary.SchoolYear].ToString().Trim(); //学年
objzx_SysScoreSummaryEN.zxScoreTypeId = objRow[conzx_SysScoreSummary.zxScoreTypeId] == DBNull.Value ? null : objRow[conzx_SysScoreSummary.zxScoreTypeId].ToString().Trim(); //分数类型Id
objzx_SysScoreSummaryEN.Score = objRow[conzx_SysScoreSummary.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conzx_SysScoreSummary.Score].ToString().Trim()); //评分
objzx_SysScoreSummaryEN.IdCurrEduCls = objRow[conzx_SysScoreSummary.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_SysScoreSummary.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_SysScoreSummaryEN.IsSubmit = TransNullToBool(objRow[conzx_SysScoreSummary.IsSubmit].ToString().Trim()); //是否提交
objzx_SysScoreSummaryEN.UpdDate = objRow[conzx_SysScoreSummary.UpdDate] == DBNull.Value ? null : objRow[conzx_SysScoreSummary.UpdDate].ToString().Trim(); //修改日期
objzx_SysScoreSummaryEN.UpdUser = objRow[conzx_SysScoreSummary.UpdUser] == DBNull.Value ? null : objRow[conzx_SysScoreSummary.UpdUser].ToString().Trim(); //修改人
objzx_SysScoreSummaryEN.Memo = objRow[conzx_SysScoreSummary.Memo] == DBNull.Value ? null : objRow[conzx_SysScoreSummary.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clszx_SysScoreSummaryDA: GetObjLst)", objException.Message));
}
objzx_SysScoreSummaryEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objzx_SysScoreSummaryEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objzx_SysScoreSummaryEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool Getzx_SysScoreSummary(ref clszx_SysScoreSummaryEN objzx_SysScoreSummaryEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_SysScoreSummaryDA.GetSpecSQLObj();
strSQL = "Select * from zx_SysScoreSummary where mId = " + ""+ objzx_SysScoreSummaryEN.mId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objzx_SysScoreSummaryEN.mId = TransNullToInt(objDT.Rows[0][conzx_SysScoreSummary.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:True)
 objzx_SysScoreSummaryEN.UserId = objDT.Rows[0][conzx_SysScoreSummary.UserId].ToString().Trim(); //用户ID(字段类型:varchar,字段长度:18,是否可空:True)
 objzx_SysScoreSummaryEN.SchoolYear = objDT.Rows[0][conzx_SysScoreSummary.SchoolYear].ToString().Trim(); //学年(字段类型:varchar,字段长度:10,是否可空:True)
 objzx_SysScoreSummaryEN.zxScoreTypeId = objDT.Rows[0][conzx_SysScoreSummary.zxScoreTypeId].ToString().Trim(); //分数类型Id(字段类型:char,字段长度:4,是否可空:False)
 objzx_SysScoreSummaryEN.Score = TransNullToFloat(objDT.Rows[0][conzx_SysScoreSummary.Score].ToString().Trim()); //评分(字段类型:float,字段长度:8,是否可空:True)
 objzx_SysScoreSummaryEN.IdCurrEduCls = objDT.Rows[0][conzx_SysScoreSummary.IdCurrEduCls].ToString().Trim(); //教学班流水号(字段类型:char,字段长度:8,是否可空:False)
 objzx_SysScoreSummaryEN.IsSubmit = TransNullToBool(objDT.Rows[0][conzx_SysScoreSummary.IsSubmit].ToString().Trim()); //是否提交(字段类型:bit,字段长度:1,是否可空:True)
 objzx_SysScoreSummaryEN.UpdDate = objDT.Rows[0][conzx_SysScoreSummary.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objzx_SysScoreSummaryEN.UpdUser = objDT.Rows[0][conzx_SysScoreSummary.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objzx_SysScoreSummaryEN.Memo = objDT.Rows[0][conzx_SysScoreSummary.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clszx_SysScoreSummaryDA: Getzx_SysScoreSummary)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public clszx_SysScoreSummaryEN GetObjBymId(long lngmId)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_SysScoreSummaryDA.GetSpecSQLObj();
strSQL = "Select * from zx_SysScoreSummary where mId = " + ""+ lngmId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clszx_SysScoreSummaryEN objzx_SysScoreSummaryEN = new clszx_SysScoreSummaryEN();
try
{
 objzx_SysScoreSummaryEN.mId = Int32.Parse(objRow[conzx_SysScoreSummary.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:True)
 objzx_SysScoreSummaryEN.UserId = objRow[conzx_SysScoreSummary.UserId].ToString().Trim(); //用户ID(字段类型:varchar,字段长度:18,是否可空:True)
 objzx_SysScoreSummaryEN.SchoolYear = objRow[conzx_SysScoreSummary.SchoolYear] == DBNull.Value ? null : objRow[conzx_SysScoreSummary.SchoolYear].ToString().Trim(); //学年(字段类型:varchar,字段长度:10,是否可空:True)
 objzx_SysScoreSummaryEN.zxScoreTypeId = objRow[conzx_SysScoreSummary.zxScoreTypeId] == DBNull.Value ? null : objRow[conzx_SysScoreSummary.zxScoreTypeId].ToString().Trim(); //分数类型Id(字段类型:char,字段长度:4,是否可空:False)
 objzx_SysScoreSummaryEN.Score = objRow[conzx_SysScoreSummary.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_SysScoreSummary.Score].ToString().Trim()); //评分(字段类型:float,字段长度:8,是否可空:True)
 objzx_SysScoreSummaryEN.IdCurrEduCls = objRow[conzx_SysScoreSummary.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_SysScoreSummary.IdCurrEduCls].ToString().Trim(); //教学班流水号(字段类型:char,字段长度:8,是否可空:False)
 objzx_SysScoreSummaryEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conzx_SysScoreSummary.IsSubmit].ToString().Trim()); //是否提交(字段类型:bit,字段长度:1,是否可空:True)
 objzx_SysScoreSummaryEN.UpdDate = objRow[conzx_SysScoreSummary.UpdDate] == DBNull.Value ? null : objRow[conzx_SysScoreSummary.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objzx_SysScoreSummaryEN.UpdUser = objRow[conzx_SysScoreSummary.UpdUser] == DBNull.Value ? null : objRow[conzx_SysScoreSummary.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objzx_SysScoreSummaryEN.Memo = objRow[conzx_SysScoreSummary.Memo] == DBNull.Value ? null : objRow[conzx_SysScoreSummary.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clszx_SysScoreSummaryDA: GetObjBymId)", objException.Message));
}
return objzx_SysScoreSummaryEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clszx_SysScoreSummaryEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clszx_SysScoreSummaryDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_SysScoreSummaryDA.GetSpecSQLObj();
strSQL = "Select * from zx_SysScoreSummary where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clszx_SysScoreSummaryEN objzx_SysScoreSummaryEN = new clszx_SysScoreSummaryEN()
{
mId = TransNullToInt(objRow[conzx_SysScoreSummary.mId].ToString().Trim()), //mId
UserId = objRow[conzx_SysScoreSummary.UserId].ToString().Trim(), //用户ID
SchoolYear = objRow[conzx_SysScoreSummary.SchoolYear] == DBNull.Value ? null : objRow[conzx_SysScoreSummary.SchoolYear].ToString().Trim(), //学年
zxScoreTypeId = objRow[conzx_SysScoreSummary.zxScoreTypeId] == DBNull.Value ? null : objRow[conzx_SysScoreSummary.zxScoreTypeId].ToString().Trim(), //分数类型Id
Score = objRow[conzx_SysScoreSummary.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conzx_SysScoreSummary.Score].ToString().Trim()), //评分
IdCurrEduCls = objRow[conzx_SysScoreSummary.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_SysScoreSummary.IdCurrEduCls].ToString().Trim(), //教学班流水号
IsSubmit = TransNullToBool(objRow[conzx_SysScoreSummary.IsSubmit].ToString().Trim()), //是否提交
UpdDate = objRow[conzx_SysScoreSummary.UpdDate] == DBNull.Value ? null : objRow[conzx_SysScoreSummary.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[conzx_SysScoreSummary.UpdUser] == DBNull.Value ? null : objRow[conzx_SysScoreSummary.UpdUser].ToString().Trim(), //修改人
Memo = objRow[conzx_SysScoreSummary.Memo] == DBNull.Value ? null : objRow[conzx_SysScoreSummary.Memo].ToString().Trim() //备注
};
objzx_SysScoreSummaryEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objzx_SysScoreSummaryEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clszx_SysScoreSummaryDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clszx_SysScoreSummaryEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clszx_SysScoreSummaryEN objzx_SysScoreSummaryEN = new clszx_SysScoreSummaryEN();
try
{
objzx_SysScoreSummaryEN.mId = TransNullToInt(objRow[conzx_SysScoreSummary.mId].ToString().Trim()); //mId
objzx_SysScoreSummaryEN.UserId = objRow[conzx_SysScoreSummary.UserId].ToString().Trim(); //用户ID
objzx_SysScoreSummaryEN.SchoolYear = objRow[conzx_SysScoreSummary.SchoolYear] == DBNull.Value ? null : objRow[conzx_SysScoreSummary.SchoolYear].ToString().Trim(); //学年
objzx_SysScoreSummaryEN.zxScoreTypeId = objRow[conzx_SysScoreSummary.zxScoreTypeId] == DBNull.Value ? null : objRow[conzx_SysScoreSummary.zxScoreTypeId].ToString().Trim(); //分数类型Id
objzx_SysScoreSummaryEN.Score = objRow[conzx_SysScoreSummary.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conzx_SysScoreSummary.Score].ToString().Trim()); //评分
objzx_SysScoreSummaryEN.IdCurrEduCls = objRow[conzx_SysScoreSummary.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_SysScoreSummary.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_SysScoreSummaryEN.IsSubmit = TransNullToBool(objRow[conzx_SysScoreSummary.IsSubmit].ToString().Trim()); //是否提交
objzx_SysScoreSummaryEN.UpdDate = objRow[conzx_SysScoreSummary.UpdDate] == DBNull.Value ? null : objRow[conzx_SysScoreSummary.UpdDate].ToString().Trim(); //修改日期
objzx_SysScoreSummaryEN.UpdUser = objRow[conzx_SysScoreSummary.UpdUser] == DBNull.Value ? null : objRow[conzx_SysScoreSummary.UpdUser].ToString().Trim(); //修改人
objzx_SysScoreSummaryEN.Memo = objRow[conzx_SysScoreSummary.Memo] == DBNull.Value ? null : objRow[conzx_SysScoreSummary.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clszx_SysScoreSummaryDA: GetObjByDataRowzx_SysScoreSummary)", objException.Message));
}
objzx_SysScoreSummaryEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objzx_SysScoreSummaryEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clszx_SysScoreSummaryEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clszx_SysScoreSummaryEN objzx_SysScoreSummaryEN = new clszx_SysScoreSummaryEN();
try
{
objzx_SysScoreSummaryEN.mId = TransNullToInt(objRow[conzx_SysScoreSummary.mId].ToString().Trim()); //mId
objzx_SysScoreSummaryEN.UserId = objRow[conzx_SysScoreSummary.UserId].ToString().Trim(); //用户ID
objzx_SysScoreSummaryEN.SchoolYear = objRow[conzx_SysScoreSummary.SchoolYear] == DBNull.Value ? null : objRow[conzx_SysScoreSummary.SchoolYear].ToString().Trim(); //学年
objzx_SysScoreSummaryEN.zxScoreTypeId = objRow[conzx_SysScoreSummary.zxScoreTypeId] == DBNull.Value ? null : objRow[conzx_SysScoreSummary.zxScoreTypeId].ToString().Trim(); //分数类型Id
objzx_SysScoreSummaryEN.Score = objRow[conzx_SysScoreSummary.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conzx_SysScoreSummary.Score].ToString().Trim()); //评分
objzx_SysScoreSummaryEN.IdCurrEduCls = objRow[conzx_SysScoreSummary.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_SysScoreSummary.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_SysScoreSummaryEN.IsSubmit = TransNullToBool(objRow[conzx_SysScoreSummary.IsSubmit].ToString().Trim()); //是否提交
objzx_SysScoreSummaryEN.UpdDate = objRow[conzx_SysScoreSummary.UpdDate] == DBNull.Value ? null : objRow[conzx_SysScoreSummary.UpdDate].ToString().Trim(); //修改日期
objzx_SysScoreSummaryEN.UpdUser = objRow[conzx_SysScoreSummary.UpdUser] == DBNull.Value ? null : objRow[conzx_SysScoreSummary.UpdUser].ToString().Trim(); //修改人
objzx_SysScoreSummaryEN.Memo = objRow[conzx_SysScoreSummary.Memo] == DBNull.Value ? null : objRow[conzx_SysScoreSummary.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clszx_SysScoreSummaryDA: GetObjByDataRow)", objException.Message));
}
objzx_SysScoreSummaryEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objzx_SysScoreSummaryEN;
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
objSQL = clszx_SysScoreSummaryDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clszx_SysScoreSummaryEN._CurrTabName, conzx_SysScoreSummary.mId, 8, "");
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
objSQL = clszx_SysScoreSummaryDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clszx_SysScoreSummaryEN._CurrTabName, conzx_SysScoreSummary.mId, 8, strPrefix);
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
 objSQL = clszx_SysScoreSummaryDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select mId from zx_SysScoreSummary where " + strCondition;
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
 objSQL = clszx_SysScoreSummaryDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select mId from zx_SysScoreSummary where " + strCondition;
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
 objSQL = clszx_SysScoreSummaryDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("zx_SysScoreSummary", "mId = " + ""+ lngmId+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clszx_SysScoreSummaryDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_SysScoreSummaryDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("zx_SysScoreSummary", strCondition))
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
objSQL = clszx_SysScoreSummaryDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("zx_SysScoreSummary");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clszx_SysScoreSummaryEN objzx_SysScoreSummaryEN)
 {
 objzx_SysScoreSummaryEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objzx_SysScoreSummaryEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objzx_SysScoreSummaryEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_SysScoreSummaryDA.GetSpecSQLObj();
strSQL = "Select * from zx_SysScoreSummary where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "zx_SysScoreSummary");
objRow = objDS.Tables["zx_SysScoreSummary"].NewRow();
objRow[conzx_SysScoreSummary.UserId] = objzx_SysScoreSummaryEN.UserId; //用户ID
 if (objzx_SysScoreSummaryEN.SchoolYear !=  "")
 {
objRow[conzx_SysScoreSummary.SchoolYear] = objzx_SysScoreSummaryEN.SchoolYear; //学年
 }
 if (objzx_SysScoreSummaryEN.zxScoreTypeId !=  "")
 {
objRow[conzx_SysScoreSummary.zxScoreTypeId] = objzx_SysScoreSummaryEN.zxScoreTypeId; //分数类型Id
 }
objRow[conzx_SysScoreSummary.Score] = objzx_SysScoreSummaryEN.Score; //评分
 if (objzx_SysScoreSummaryEN.IdCurrEduCls !=  "")
 {
objRow[conzx_SysScoreSummary.IdCurrEduCls] = objzx_SysScoreSummaryEN.IdCurrEduCls; //教学班流水号
 }
objRow[conzx_SysScoreSummary.IsSubmit] = objzx_SysScoreSummaryEN.IsSubmit; //是否提交
 if (objzx_SysScoreSummaryEN.UpdDate !=  "")
 {
objRow[conzx_SysScoreSummary.UpdDate] = objzx_SysScoreSummaryEN.UpdDate; //修改日期
 }
 if (objzx_SysScoreSummaryEN.UpdUser !=  "")
 {
objRow[conzx_SysScoreSummary.UpdUser] = objzx_SysScoreSummaryEN.UpdUser; //修改人
 }
 if (objzx_SysScoreSummaryEN.Memo !=  "")
 {
objRow[conzx_SysScoreSummary.Memo] = objzx_SysScoreSummaryEN.Memo; //备注
 }
objDS.Tables[clszx_SysScoreSummaryEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clszx_SysScoreSummaryEN._CurrTabName);
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
 /// <param name = "objzx_SysScoreSummaryEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clszx_SysScoreSummaryEN objzx_SysScoreSummaryEN)
{
 objzx_SysScoreSummaryEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objzx_SysScoreSummaryEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objzx_SysScoreSummaryEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objzx_SysScoreSummaryEN.UserId !=  null)
 {
 arrFieldListForInsert.Add(conzx_SysScoreSummary.UserId);
 var strUserId = objzx_SysScoreSummaryEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserId + "'");
 }
 
 if (objzx_SysScoreSummaryEN.SchoolYear !=  null)
 {
 arrFieldListForInsert.Add(conzx_SysScoreSummary.SchoolYear);
 var strSchoolYear = objzx_SysScoreSummaryEN.SchoolYear.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSchoolYear + "'");
 }
 
 if (objzx_SysScoreSummaryEN.zxScoreTypeId !=  null)
 {
 arrFieldListForInsert.Add(conzx_SysScoreSummary.zxScoreTypeId);
 var strzxScoreTypeId = objzx_SysScoreSummaryEN.zxScoreTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strzxScoreTypeId + "'");
 }
 
 if (objzx_SysScoreSummaryEN.Score !=  null)
 {
 arrFieldListForInsert.Add(conzx_SysScoreSummary.Score);
 arrValueListForInsert.Add(objzx_SysScoreSummaryEN.Score.ToString());
 }
 
 if (objzx_SysScoreSummaryEN.IdCurrEduCls !=  null)
 {
 arrFieldListForInsert.Add(conzx_SysScoreSummary.IdCurrEduCls);
 var strIdCurrEduCls = objzx_SysScoreSummaryEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCurrEduCls + "'");
 }
 
 arrFieldListForInsert.Add(conzx_SysScoreSummary.IsSubmit);
 arrValueListForInsert.Add("'" + (objzx_SysScoreSummaryEN.IsSubmit  ==  false ? "0" : "1") + "'");
 
 if (objzx_SysScoreSummaryEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conzx_SysScoreSummary.UpdDate);
 var strUpdDate = objzx_SysScoreSummaryEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objzx_SysScoreSummaryEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conzx_SysScoreSummary.UpdUser);
 var strUpdUser = objzx_SysScoreSummaryEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objzx_SysScoreSummaryEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conzx_SysScoreSummary.Memo);
 var strMemo = objzx_SysScoreSummaryEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into zx_SysScoreSummary");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_SysScoreSummaryDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objzx_SysScoreSummaryEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clszx_SysScoreSummaryEN objzx_SysScoreSummaryEN)
{
 objzx_SysScoreSummaryEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objzx_SysScoreSummaryEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objzx_SysScoreSummaryEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objzx_SysScoreSummaryEN.UserId !=  null)
 {
 arrFieldListForInsert.Add(conzx_SysScoreSummary.UserId);
 var strUserId = objzx_SysScoreSummaryEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserId + "'");
 }
 
 if (objzx_SysScoreSummaryEN.SchoolYear !=  null)
 {
 arrFieldListForInsert.Add(conzx_SysScoreSummary.SchoolYear);
 var strSchoolYear = objzx_SysScoreSummaryEN.SchoolYear.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSchoolYear + "'");
 }
 
 if (objzx_SysScoreSummaryEN.zxScoreTypeId !=  null)
 {
 arrFieldListForInsert.Add(conzx_SysScoreSummary.zxScoreTypeId);
 var strzxScoreTypeId = objzx_SysScoreSummaryEN.zxScoreTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strzxScoreTypeId + "'");
 }
 
 if (objzx_SysScoreSummaryEN.Score !=  null)
 {
 arrFieldListForInsert.Add(conzx_SysScoreSummary.Score);
 arrValueListForInsert.Add(objzx_SysScoreSummaryEN.Score.ToString());
 }
 
 if (objzx_SysScoreSummaryEN.IdCurrEduCls !=  null)
 {
 arrFieldListForInsert.Add(conzx_SysScoreSummary.IdCurrEduCls);
 var strIdCurrEduCls = objzx_SysScoreSummaryEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCurrEduCls + "'");
 }
 
 arrFieldListForInsert.Add(conzx_SysScoreSummary.IsSubmit);
 arrValueListForInsert.Add("'" + (objzx_SysScoreSummaryEN.IsSubmit  ==  false ? "0" : "1") + "'");
 
 if (objzx_SysScoreSummaryEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conzx_SysScoreSummary.UpdDate);
 var strUpdDate = objzx_SysScoreSummaryEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objzx_SysScoreSummaryEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conzx_SysScoreSummary.UpdUser);
 var strUpdUser = objzx_SysScoreSummaryEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objzx_SysScoreSummaryEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conzx_SysScoreSummary.Memo);
 var strMemo = objzx_SysScoreSummaryEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into zx_SysScoreSummary");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_SysScoreSummaryDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString()).Rows[0][0].ToString();
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objzx_SysScoreSummaryEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clszx_SysScoreSummaryEN objzx_SysScoreSummaryEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objzx_SysScoreSummaryEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objzx_SysScoreSummaryEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objzx_SysScoreSummaryEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objzx_SysScoreSummaryEN.UserId !=  null)
 {
 arrFieldListForInsert.Add(conzx_SysScoreSummary.UserId);
 var strUserId = objzx_SysScoreSummaryEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserId + "'");
 }
 
 if (objzx_SysScoreSummaryEN.SchoolYear !=  null)
 {
 arrFieldListForInsert.Add(conzx_SysScoreSummary.SchoolYear);
 var strSchoolYear = objzx_SysScoreSummaryEN.SchoolYear.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSchoolYear + "'");
 }
 
 if (objzx_SysScoreSummaryEN.zxScoreTypeId !=  null)
 {
 arrFieldListForInsert.Add(conzx_SysScoreSummary.zxScoreTypeId);
 var strzxScoreTypeId = objzx_SysScoreSummaryEN.zxScoreTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strzxScoreTypeId + "'");
 }
 
 if (objzx_SysScoreSummaryEN.Score !=  null)
 {
 arrFieldListForInsert.Add(conzx_SysScoreSummary.Score);
 arrValueListForInsert.Add(objzx_SysScoreSummaryEN.Score.ToString());
 }
 
 if (objzx_SysScoreSummaryEN.IdCurrEduCls !=  null)
 {
 arrFieldListForInsert.Add(conzx_SysScoreSummary.IdCurrEduCls);
 var strIdCurrEduCls = objzx_SysScoreSummaryEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCurrEduCls + "'");
 }
 
 arrFieldListForInsert.Add(conzx_SysScoreSummary.IsSubmit);
 arrValueListForInsert.Add("'" + (objzx_SysScoreSummaryEN.IsSubmit  ==  false ? "0" : "1") + "'");
 
 if (objzx_SysScoreSummaryEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conzx_SysScoreSummary.UpdDate);
 var strUpdDate = objzx_SysScoreSummaryEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objzx_SysScoreSummaryEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conzx_SysScoreSummary.UpdUser);
 var strUpdUser = objzx_SysScoreSummaryEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objzx_SysScoreSummaryEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conzx_SysScoreSummary.Memo);
 var strMemo = objzx_SysScoreSummaryEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into zx_SysScoreSummary");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_SysScoreSummaryDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString(), objSqlConnection, objSqlTransaction).Rows[0][0].ToString();
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objzx_SysScoreSummaryEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clszx_SysScoreSummaryEN objzx_SysScoreSummaryEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objzx_SysScoreSummaryEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objzx_SysScoreSummaryEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objzx_SysScoreSummaryEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objzx_SysScoreSummaryEN.UserId !=  null)
 {
 arrFieldListForInsert.Add(conzx_SysScoreSummary.UserId);
 var strUserId = objzx_SysScoreSummaryEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserId + "'");
 }
 
 if (objzx_SysScoreSummaryEN.SchoolYear !=  null)
 {
 arrFieldListForInsert.Add(conzx_SysScoreSummary.SchoolYear);
 var strSchoolYear = objzx_SysScoreSummaryEN.SchoolYear.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSchoolYear + "'");
 }
 
 if (objzx_SysScoreSummaryEN.zxScoreTypeId !=  null)
 {
 arrFieldListForInsert.Add(conzx_SysScoreSummary.zxScoreTypeId);
 var strzxScoreTypeId = objzx_SysScoreSummaryEN.zxScoreTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strzxScoreTypeId + "'");
 }
 
 if (objzx_SysScoreSummaryEN.Score !=  null)
 {
 arrFieldListForInsert.Add(conzx_SysScoreSummary.Score);
 arrValueListForInsert.Add(objzx_SysScoreSummaryEN.Score.ToString());
 }
 
 if (objzx_SysScoreSummaryEN.IdCurrEduCls !=  null)
 {
 arrFieldListForInsert.Add(conzx_SysScoreSummary.IdCurrEduCls);
 var strIdCurrEduCls = objzx_SysScoreSummaryEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCurrEduCls + "'");
 }
 
 arrFieldListForInsert.Add(conzx_SysScoreSummary.IsSubmit);
 arrValueListForInsert.Add("'" + (objzx_SysScoreSummaryEN.IsSubmit  ==  false ? "0" : "1") + "'");
 
 if (objzx_SysScoreSummaryEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conzx_SysScoreSummary.UpdDate);
 var strUpdDate = objzx_SysScoreSummaryEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objzx_SysScoreSummaryEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conzx_SysScoreSummary.UpdUser);
 var strUpdUser = objzx_SysScoreSummaryEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objzx_SysScoreSummaryEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conzx_SysScoreSummary.Memo);
 var strMemo = objzx_SysScoreSummaryEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into zx_SysScoreSummary");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_SysScoreSummaryDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool Addnewzx_SysScoreSummarys(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_SysScoreSummaryDA.GetSpecSQLObj();
strSQL = "Select * from zx_SysScoreSummary where mId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "zx_SysScoreSummary");
//检查关键字的唯一性
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clszx_SysScoreSummaryEN._CurrTabName ].NewRow();
objRow[conzx_SysScoreSummary.UserId] = oRow[conzx_SysScoreSummary.UserId].ToString().Trim(); //用户ID
objRow[conzx_SysScoreSummary.SchoolYear] = oRow[conzx_SysScoreSummary.SchoolYear].ToString().Trim(); //学年
objRow[conzx_SysScoreSummary.zxScoreTypeId] = oRow[conzx_SysScoreSummary.zxScoreTypeId].ToString().Trim(); //分数类型Id
objRow[conzx_SysScoreSummary.Score] = oRow[conzx_SysScoreSummary.Score].ToString().Trim(); //评分
objRow[conzx_SysScoreSummary.IdCurrEduCls] = oRow[conzx_SysScoreSummary.IdCurrEduCls].ToString().Trim(); //教学班流水号
objRow[conzx_SysScoreSummary.IsSubmit] = oRow[conzx_SysScoreSummary.IsSubmit].ToString().Trim(); //是否提交
objRow[conzx_SysScoreSummary.UpdDate] = oRow[conzx_SysScoreSummary.UpdDate].ToString().Trim(); //修改日期
objRow[conzx_SysScoreSummary.UpdUser] = oRow[conzx_SysScoreSummary.UpdUser].ToString().Trim(); //修改人
objRow[conzx_SysScoreSummary.Memo] = oRow[conzx_SysScoreSummary.Memo].ToString().Trim(); //备注
 objDS.Tables[clszx_SysScoreSummaryEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clszx_SysScoreSummaryEN._CurrTabName);
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
 /// <param name = "objzx_SysScoreSummaryEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clszx_SysScoreSummaryEN objzx_SysScoreSummaryEN)
{
 objzx_SysScoreSummaryEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objzx_SysScoreSummaryEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objzx_SysScoreSummaryEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_SysScoreSummaryDA.GetSpecSQLObj();
strSQL = "Select * from zx_SysScoreSummary where mId = " + ""+ objzx_SysScoreSummaryEN.mId+"";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clszx_SysScoreSummaryEN._CurrTabName);
if (objDS.Tables[clszx_SysScoreSummaryEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:mId = " + ""+ objzx_SysScoreSummaryEN.mId+"");
return false;
}
objRow = objDS.Tables[clszx_SysScoreSummaryEN._CurrTabName].Rows[0];
 if (objzx_SysScoreSummaryEN.IsUpdated(conzx_SysScoreSummary.UserId))
 {
objRow[conzx_SysScoreSummary.UserId] = objzx_SysScoreSummaryEN.UserId; //用户ID
 }
 if (objzx_SysScoreSummaryEN.IsUpdated(conzx_SysScoreSummary.SchoolYear))
 {
objRow[conzx_SysScoreSummary.SchoolYear] = objzx_SysScoreSummaryEN.SchoolYear; //学年
 }
 if (objzx_SysScoreSummaryEN.IsUpdated(conzx_SysScoreSummary.zxScoreTypeId))
 {
objRow[conzx_SysScoreSummary.zxScoreTypeId] = objzx_SysScoreSummaryEN.zxScoreTypeId; //分数类型Id
 }
 if (objzx_SysScoreSummaryEN.IsUpdated(conzx_SysScoreSummary.Score))
 {
objRow[conzx_SysScoreSummary.Score] = objzx_SysScoreSummaryEN.Score; //评分
 }
 if (objzx_SysScoreSummaryEN.IsUpdated(conzx_SysScoreSummary.IdCurrEduCls))
 {
objRow[conzx_SysScoreSummary.IdCurrEduCls] = objzx_SysScoreSummaryEN.IdCurrEduCls; //教学班流水号
 }
 if (objzx_SysScoreSummaryEN.IsUpdated(conzx_SysScoreSummary.IsSubmit))
 {
objRow[conzx_SysScoreSummary.IsSubmit] = objzx_SysScoreSummaryEN.IsSubmit; //是否提交
 }
 if (objzx_SysScoreSummaryEN.IsUpdated(conzx_SysScoreSummary.UpdDate))
 {
objRow[conzx_SysScoreSummary.UpdDate] = objzx_SysScoreSummaryEN.UpdDate; //修改日期
 }
 if (objzx_SysScoreSummaryEN.IsUpdated(conzx_SysScoreSummary.UpdUser))
 {
objRow[conzx_SysScoreSummary.UpdUser] = objzx_SysScoreSummaryEN.UpdUser; //修改人
 }
 if (objzx_SysScoreSummaryEN.IsUpdated(conzx_SysScoreSummary.Memo))
 {
objRow[conzx_SysScoreSummary.Memo] = objzx_SysScoreSummaryEN.Memo; //备注
 }
try
{
objDA.Update(objDS, clszx_SysScoreSummaryEN._CurrTabName);
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
 /// <param name = "objzx_SysScoreSummaryEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clszx_SysScoreSummaryEN objzx_SysScoreSummaryEN)
{
 objzx_SysScoreSummaryEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objzx_SysScoreSummaryEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objzx_SysScoreSummaryEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_SysScoreSummaryDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update zx_SysScoreSummary Set ");
 
 if (objzx_SysScoreSummaryEN.IsUpdated(conzx_SysScoreSummary.UserId))
 {
 if (objzx_SysScoreSummaryEN.UserId !=  null)
 {
 var strUserId = objzx_SysScoreSummaryEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUserId, conzx_SysScoreSummary.UserId); //用户ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SysScoreSummary.UserId); //用户ID
 }
 }
 
 if (objzx_SysScoreSummaryEN.IsUpdated(conzx_SysScoreSummary.SchoolYear))
 {
 if (objzx_SysScoreSummaryEN.SchoolYear !=  null)
 {
 var strSchoolYear = objzx_SysScoreSummaryEN.SchoolYear.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSchoolYear, conzx_SysScoreSummary.SchoolYear); //学年
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SysScoreSummary.SchoolYear); //学年
 }
 }
 
 if (objzx_SysScoreSummaryEN.IsUpdated(conzx_SysScoreSummary.zxScoreTypeId))
 {
 if (objzx_SysScoreSummaryEN.zxScoreTypeId !=  null)
 {
 var strzxScoreTypeId = objzx_SysScoreSummaryEN.zxScoreTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strzxScoreTypeId, conzx_SysScoreSummary.zxScoreTypeId); //分数类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SysScoreSummary.zxScoreTypeId); //分数类型Id
 }
 }
 
 if (objzx_SysScoreSummaryEN.IsUpdated(conzx_SysScoreSummary.Score))
 {
 if (objzx_SysScoreSummaryEN.Score !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_SysScoreSummaryEN.Score, conzx_SysScoreSummary.Score); //评分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SysScoreSummary.Score); //评分
 }
 }
 
 if (objzx_SysScoreSummaryEN.IsUpdated(conzx_SysScoreSummary.IdCurrEduCls))
 {
 if (objzx_SysScoreSummaryEN.IdCurrEduCls !=  null)
 {
 var strIdCurrEduCls = objzx_SysScoreSummaryEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdCurrEduCls, conzx_SysScoreSummary.IdCurrEduCls); //教学班流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SysScoreSummary.IdCurrEduCls); //教学班流水号
 }
 }
 
 if (objzx_SysScoreSummaryEN.IsUpdated(conzx_SysScoreSummary.IsSubmit))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objzx_SysScoreSummaryEN.IsSubmit == true?"1":"0", conzx_SysScoreSummary.IsSubmit); //是否提交
 }
 
 if (objzx_SysScoreSummaryEN.IsUpdated(conzx_SysScoreSummary.UpdDate))
 {
 if (objzx_SysScoreSummaryEN.UpdDate !=  null)
 {
 var strUpdDate = objzx_SysScoreSummaryEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conzx_SysScoreSummary.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SysScoreSummary.UpdDate); //修改日期
 }
 }
 
 if (objzx_SysScoreSummaryEN.IsUpdated(conzx_SysScoreSummary.UpdUser))
 {
 if (objzx_SysScoreSummaryEN.UpdUser !=  null)
 {
 var strUpdUser = objzx_SysScoreSummaryEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conzx_SysScoreSummary.UpdUser); //修改人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SysScoreSummary.UpdUser); //修改人
 }
 }
 
 if (objzx_SysScoreSummaryEN.IsUpdated(conzx_SysScoreSummary.Memo))
 {
 if (objzx_SysScoreSummaryEN.Memo !=  null)
 {
 var strMemo = objzx_SysScoreSummaryEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conzx_SysScoreSummary.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SysScoreSummary.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where mId = {0}", objzx_SysScoreSummaryEN.mId); 
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
 /// <param name = "objzx_SysScoreSummaryEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clszx_SysScoreSummaryEN objzx_SysScoreSummaryEN, string strCondition)
{
 objzx_SysScoreSummaryEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objzx_SysScoreSummaryEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objzx_SysScoreSummaryEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_SysScoreSummaryDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update zx_SysScoreSummary Set ");
 
 if (objzx_SysScoreSummaryEN.IsUpdated(conzx_SysScoreSummary.UserId))
 {
 if (objzx_SysScoreSummaryEN.UserId !=  null)
 {
 var strUserId = objzx_SysScoreSummaryEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UserId = '{0}',", strUserId); //用户ID
 }
 else
 {
 sbSQL.Append(" UserId = null,"); //用户ID
 }
 }
 
 if (objzx_SysScoreSummaryEN.IsUpdated(conzx_SysScoreSummary.SchoolYear))
 {
 if (objzx_SysScoreSummaryEN.SchoolYear !=  null)
 {
 var strSchoolYear = objzx_SysScoreSummaryEN.SchoolYear.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SchoolYear = '{0}',", strSchoolYear); //学年
 }
 else
 {
 sbSQL.Append(" SchoolYear = null,"); //学年
 }
 }
 
 if (objzx_SysScoreSummaryEN.IsUpdated(conzx_SysScoreSummary.zxScoreTypeId))
 {
 if (objzx_SysScoreSummaryEN.zxScoreTypeId !=  null)
 {
 var strzxScoreTypeId = objzx_SysScoreSummaryEN.zxScoreTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" zxScoreTypeId = '{0}',", strzxScoreTypeId); //分数类型Id
 }
 else
 {
 sbSQL.Append(" zxScoreTypeId = null,"); //分数类型Id
 }
 }
 
 if (objzx_SysScoreSummaryEN.IsUpdated(conzx_SysScoreSummary.Score))
 {
 if (objzx_SysScoreSummaryEN.Score !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_SysScoreSummaryEN.Score, conzx_SysScoreSummary.Score); //评分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SysScoreSummary.Score); //评分
 }
 }
 
 if (objzx_SysScoreSummaryEN.IsUpdated(conzx_SysScoreSummary.IdCurrEduCls))
 {
 if (objzx_SysScoreSummaryEN.IdCurrEduCls !=  null)
 {
 var strIdCurrEduCls = objzx_SysScoreSummaryEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdCurrEduCls = '{0}',", strIdCurrEduCls); //教学班流水号
 }
 else
 {
 sbSQL.Append(" IdCurrEduCls = null,"); //教学班流水号
 }
 }
 
 if (objzx_SysScoreSummaryEN.IsUpdated(conzx_SysScoreSummary.IsSubmit))
 {
 sbSQL.AppendFormat(" IsSubmit = '{0}',", objzx_SysScoreSummaryEN.IsSubmit == true?"1":"0"); //是否提交
 }
 
 if (objzx_SysScoreSummaryEN.IsUpdated(conzx_SysScoreSummary.UpdDate))
 {
 if (objzx_SysScoreSummaryEN.UpdDate !=  null)
 {
 var strUpdDate = objzx_SysScoreSummaryEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objzx_SysScoreSummaryEN.IsUpdated(conzx_SysScoreSummary.UpdUser))
 {
 if (objzx_SysScoreSummaryEN.UpdUser !=  null)
 {
 var strUpdUser = objzx_SysScoreSummaryEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改人
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改人
 }
 }
 
 if (objzx_SysScoreSummaryEN.IsUpdated(conzx_SysScoreSummary.Memo))
 {
 if (objzx_SysScoreSummaryEN.Memo !=  null)
 {
 var strMemo = objzx_SysScoreSummaryEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objzx_SysScoreSummaryEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clszx_SysScoreSummaryEN objzx_SysScoreSummaryEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objzx_SysScoreSummaryEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objzx_SysScoreSummaryEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objzx_SysScoreSummaryEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_SysScoreSummaryDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update zx_SysScoreSummary Set ");
 
 if (objzx_SysScoreSummaryEN.IsUpdated(conzx_SysScoreSummary.UserId))
 {
 if (objzx_SysScoreSummaryEN.UserId !=  null)
 {
 var strUserId = objzx_SysScoreSummaryEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UserId = '{0}',", strUserId); //用户ID
 }
 else
 {
 sbSQL.Append(" UserId = null,"); //用户ID
 }
 }
 
 if (objzx_SysScoreSummaryEN.IsUpdated(conzx_SysScoreSummary.SchoolYear))
 {
 if (objzx_SysScoreSummaryEN.SchoolYear !=  null)
 {
 var strSchoolYear = objzx_SysScoreSummaryEN.SchoolYear.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SchoolYear = '{0}',", strSchoolYear); //学年
 }
 else
 {
 sbSQL.Append(" SchoolYear = null,"); //学年
 }
 }
 
 if (objzx_SysScoreSummaryEN.IsUpdated(conzx_SysScoreSummary.zxScoreTypeId))
 {
 if (objzx_SysScoreSummaryEN.zxScoreTypeId !=  null)
 {
 var strzxScoreTypeId = objzx_SysScoreSummaryEN.zxScoreTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" zxScoreTypeId = '{0}',", strzxScoreTypeId); //分数类型Id
 }
 else
 {
 sbSQL.Append(" zxScoreTypeId = null,"); //分数类型Id
 }
 }
 
 if (objzx_SysScoreSummaryEN.IsUpdated(conzx_SysScoreSummary.Score))
 {
 if (objzx_SysScoreSummaryEN.Score !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_SysScoreSummaryEN.Score, conzx_SysScoreSummary.Score); //评分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SysScoreSummary.Score); //评分
 }
 }
 
 if (objzx_SysScoreSummaryEN.IsUpdated(conzx_SysScoreSummary.IdCurrEduCls))
 {
 if (objzx_SysScoreSummaryEN.IdCurrEduCls !=  null)
 {
 var strIdCurrEduCls = objzx_SysScoreSummaryEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdCurrEduCls = '{0}',", strIdCurrEduCls); //教学班流水号
 }
 else
 {
 sbSQL.Append(" IdCurrEduCls = null,"); //教学班流水号
 }
 }
 
 if (objzx_SysScoreSummaryEN.IsUpdated(conzx_SysScoreSummary.IsSubmit))
 {
 sbSQL.AppendFormat(" IsSubmit = '{0}',", objzx_SysScoreSummaryEN.IsSubmit == true?"1":"0"); //是否提交
 }
 
 if (objzx_SysScoreSummaryEN.IsUpdated(conzx_SysScoreSummary.UpdDate))
 {
 if (objzx_SysScoreSummaryEN.UpdDate !=  null)
 {
 var strUpdDate = objzx_SysScoreSummaryEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objzx_SysScoreSummaryEN.IsUpdated(conzx_SysScoreSummary.UpdUser))
 {
 if (objzx_SysScoreSummaryEN.UpdUser !=  null)
 {
 var strUpdUser = objzx_SysScoreSummaryEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改人
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改人
 }
 }
 
 if (objzx_SysScoreSummaryEN.IsUpdated(conzx_SysScoreSummary.Memo))
 {
 if (objzx_SysScoreSummaryEN.Memo !=  null)
 {
 var strMemo = objzx_SysScoreSummaryEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objzx_SysScoreSummaryEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clszx_SysScoreSummaryEN objzx_SysScoreSummaryEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objzx_SysScoreSummaryEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objzx_SysScoreSummaryEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objzx_SysScoreSummaryEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_SysScoreSummaryDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update zx_SysScoreSummary Set ");
 
 if (objzx_SysScoreSummaryEN.IsUpdated(conzx_SysScoreSummary.UserId))
 {
 if (objzx_SysScoreSummaryEN.UserId !=  null)
 {
 var strUserId = objzx_SysScoreSummaryEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUserId, conzx_SysScoreSummary.UserId); //用户ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SysScoreSummary.UserId); //用户ID
 }
 }
 
 if (objzx_SysScoreSummaryEN.IsUpdated(conzx_SysScoreSummary.SchoolYear))
 {
 if (objzx_SysScoreSummaryEN.SchoolYear !=  null)
 {
 var strSchoolYear = objzx_SysScoreSummaryEN.SchoolYear.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSchoolYear, conzx_SysScoreSummary.SchoolYear); //学年
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SysScoreSummary.SchoolYear); //学年
 }
 }
 
 if (objzx_SysScoreSummaryEN.IsUpdated(conzx_SysScoreSummary.zxScoreTypeId))
 {
 if (objzx_SysScoreSummaryEN.zxScoreTypeId !=  null)
 {
 var strzxScoreTypeId = objzx_SysScoreSummaryEN.zxScoreTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strzxScoreTypeId, conzx_SysScoreSummary.zxScoreTypeId); //分数类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SysScoreSummary.zxScoreTypeId); //分数类型Id
 }
 }
 
 if (objzx_SysScoreSummaryEN.IsUpdated(conzx_SysScoreSummary.Score))
 {
 if (objzx_SysScoreSummaryEN.Score !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_SysScoreSummaryEN.Score, conzx_SysScoreSummary.Score); //评分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SysScoreSummary.Score); //评分
 }
 }
 
 if (objzx_SysScoreSummaryEN.IsUpdated(conzx_SysScoreSummary.IdCurrEduCls))
 {
 if (objzx_SysScoreSummaryEN.IdCurrEduCls !=  null)
 {
 var strIdCurrEduCls = objzx_SysScoreSummaryEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdCurrEduCls, conzx_SysScoreSummary.IdCurrEduCls); //教学班流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SysScoreSummary.IdCurrEduCls); //教学班流水号
 }
 }
 
 if (objzx_SysScoreSummaryEN.IsUpdated(conzx_SysScoreSummary.IsSubmit))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objzx_SysScoreSummaryEN.IsSubmit == true?"1":"0", conzx_SysScoreSummary.IsSubmit); //是否提交
 }
 
 if (objzx_SysScoreSummaryEN.IsUpdated(conzx_SysScoreSummary.UpdDate))
 {
 if (objzx_SysScoreSummaryEN.UpdDate !=  null)
 {
 var strUpdDate = objzx_SysScoreSummaryEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conzx_SysScoreSummary.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SysScoreSummary.UpdDate); //修改日期
 }
 }
 
 if (objzx_SysScoreSummaryEN.IsUpdated(conzx_SysScoreSummary.UpdUser))
 {
 if (objzx_SysScoreSummaryEN.UpdUser !=  null)
 {
 var strUpdUser = objzx_SysScoreSummaryEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conzx_SysScoreSummary.UpdUser); //修改人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SysScoreSummary.UpdUser); //修改人
 }
 }
 
 if (objzx_SysScoreSummaryEN.IsUpdated(conzx_SysScoreSummary.Memo))
 {
 if (objzx_SysScoreSummaryEN.Memo !=  null)
 {
 var strMemo = objzx_SysScoreSummaryEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conzx_SysScoreSummary.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_SysScoreSummary.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where mId = {0}", objzx_SysScoreSummaryEN.mId); 
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
 objSQL = clszx_SysScoreSummaryDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 lngmId,
};
 objSQL.ExecSP("zx_SysScoreSummary_Delete", values);
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
 objSQL = clszx_SysScoreSummaryDA.GetSpecSQLObj();
//删除zx_SysScoreSummary本表中与当前对象有关的记录
strSQL = strSQL + "Delete from zx_SysScoreSummary where mId = " + ""+ lngmId+"";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int Delzx_SysScoreSummary(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_SysScoreSummaryDA.GetSpecSQLObj();
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
//删除zx_SysScoreSummary本表中与当前对象有关的记录
strSQL = strSQL + "Delete from zx_SysScoreSummary where mId in (" + strKeyList + ")";
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
 objSQL = clszx_SysScoreSummaryDA.GetSpecSQLObj();
//删除zx_SysScoreSummary本表中与当前对象有关的记录
strSQL = strSQL + "Delete from zx_SysScoreSummary where mId = " + ""+ lngmId+"";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int Delzx_SysScoreSummary(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clszx_SysScoreSummaryDA: Delzx_SysScoreSummary)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_SysScoreSummaryDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from zx_SysScoreSummary where " + strCondition ;
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
public bool Delzx_SysScoreSummaryWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clszx_SysScoreSummaryDA: Delzx_SysScoreSummaryWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_SysScoreSummaryDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from zx_SysScoreSummary where " + strCondition ;
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
 /// <param name = "objzx_SysScoreSummaryENS">源对象</param>
 /// <param name = "objzx_SysScoreSummaryENT">目标对象</param>
public void CopyTo(clszx_SysScoreSummaryEN objzx_SysScoreSummaryENS, clszx_SysScoreSummaryEN objzx_SysScoreSummaryENT)
{
objzx_SysScoreSummaryENT.mId = objzx_SysScoreSummaryENS.mId; //mId
objzx_SysScoreSummaryENT.UserId = objzx_SysScoreSummaryENS.UserId; //用户ID
objzx_SysScoreSummaryENT.SchoolYear = objzx_SysScoreSummaryENS.SchoolYear; //学年
objzx_SysScoreSummaryENT.zxScoreTypeId = objzx_SysScoreSummaryENS.zxScoreTypeId; //分数类型Id
objzx_SysScoreSummaryENT.Score = objzx_SysScoreSummaryENS.Score; //评分
objzx_SysScoreSummaryENT.IdCurrEduCls = objzx_SysScoreSummaryENS.IdCurrEduCls; //教学班流水号
objzx_SysScoreSummaryENT.IsSubmit = objzx_SysScoreSummaryENS.IsSubmit; //是否提交
objzx_SysScoreSummaryENT.UpdDate = objzx_SysScoreSummaryENS.UpdDate; //修改日期
objzx_SysScoreSummaryENT.UpdUser = objzx_SysScoreSummaryENS.UpdUser; //修改人
objzx_SysScoreSummaryENT.Memo = objzx_SysScoreSummaryENS.Memo; //备注
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clszx_SysScoreSummaryEN objzx_SysScoreSummaryEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objzx_SysScoreSummaryEN.UserId, conzx_SysScoreSummary.UserId);
//检查字段长度
clsCheckSql.CheckFieldLen(objzx_SysScoreSummaryEN.UserId, 18, conzx_SysScoreSummary.UserId);
clsCheckSql.CheckFieldLen(objzx_SysScoreSummaryEN.SchoolYear, 10, conzx_SysScoreSummary.SchoolYear);
clsCheckSql.CheckFieldLen(objzx_SysScoreSummaryEN.zxScoreTypeId, 4, conzx_SysScoreSummary.zxScoreTypeId);
clsCheckSql.CheckFieldLen(objzx_SysScoreSummaryEN.IdCurrEduCls, 8, conzx_SysScoreSummary.IdCurrEduCls);
clsCheckSql.CheckFieldLen(objzx_SysScoreSummaryEN.UpdDate, 20, conzx_SysScoreSummary.UpdDate);
clsCheckSql.CheckFieldLen(objzx_SysScoreSummaryEN.UpdUser, 20, conzx_SysScoreSummary.UpdUser);
clsCheckSql.CheckFieldLen(objzx_SysScoreSummaryEN.Memo, 1000, conzx_SysScoreSummary.Memo);
//检查字段外键固定长度
 objzx_SysScoreSummaryEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clszx_SysScoreSummaryEN objzx_SysScoreSummaryEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objzx_SysScoreSummaryEN.UserId, 18, conzx_SysScoreSummary.UserId);
clsCheckSql.CheckFieldLen(objzx_SysScoreSummaryEN.SchoolYear, 10, conzx_SysScoreSummary.SchoolYear);
clsCheckSql.CheckFieldLen(objzx_SysScoreSummaryEN.zxScoreTypeId, 4, conzx_SysScoreSummary.zxScoreTypeId);
clsCheckSql.CheckFieldLen(objzx_SysScoreSummaryEN.IdCurrEduCls, 8, conzx_SysScoreSummary.IdCurrEduCls);
clsCheckSql.CheckFieldLen(objzx_SysScoreSummaryEN.UpdDate, 20, conzx_SysScoreSummary.UpdDate);
clsCheckSql.CheckFieldLen(objzx_SysScoreSummaryEN.UpdUser, 20, conzx_SysScoreSummary.UpdUser);
clsCheckSql.CheckFieldLen(objzx_SysScoreSummaryEN.Memo, 1000, conzx_SysScoreSummary.Memo);
//检查外键字段长度
 objzx_SysScoreSummaryEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clszx_SysScoreSummaryEN objzx_SysScoreSummaryEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objzx_SysScoreSummaryEN.UserId, 18, conzx_SysScoreSummary.UserId);
clsCheckSql.CheckFieldLen(objzx_SysScoreSummaryEN.SchoolYear, 10, conzx_SysScoreSummary.SchoolYear);
clsCheckSql.CheckFieldLen(objzx_SysScoreSummaryEN.zxScoreTypeId, 4, conzx_SysScoreSummary.zxScoreTypeId);
clsCheckSql.CheckFieldLen(objzx_SysScoreSummaryEN.IdCurrEduCls, 8, conzx_SysScoreSummary.IdCurrEduCls);
clsCheckSql.CheckFieldLen(objzx_SysScoreSummaryEN.UpdDate, 20, conzx_SysScoreSummary.UpdDate);
clsCheckSql.CheckFieldLen(objzx_SysScoreSummaryEN.UpdUser, 20, conzx_SysScoreSummary.UpdUser);
clsCheckSql.CheckFieldLen(objzx_SysScoreSummaryEN.Memo, 1000, conzx_SysScoreSummary.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objzx_SysScoreSummaryEN.UserId, conzx_SysScoreSummary.UserId);
clsCheckSql.CheckSqlInjection4Field(objzx_SysScoreSummaryEN.SchoolYear, conzx_SysScoreSummary.SchoolYear);
clsCheckSql.CheckSqlInjection4Field(objzx_SysScoreSummaryEN.zxScoreTypeId, conzx_SysScoreSummary.zxScoreTypeId);
clsCheckSql.CheckSqlInjection4Field(objzx_SysScoreSummaryEN.IdCurrEduCls, conzx_SysScoreSummary.IdCurrEduCls);
clsCheckSql.CheckSqlInjection4Field(objzx_SysScoreSummaryEN.UpdDate, conzx_SysScoreSummary.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objzx_SysScoreSummaryEN.UpdUser, conzx_SysScoreSummary.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objzx_SysScoreSummaryEN.Memo, conzx_SysScoreSummary.Memo);
//检查外键字段长度
 objzx_SysScoreSummaryEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--zx_SysScoreSummary(中学系统分数汇总表),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objzx_SysScoreSummaryEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clszx_SysScoreSummaryEN objzx_SysScoreSummaryEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and UserId = '{0}'", objzx_SysScoreSummaryEN.UserId);
 if (objzx_SysScoreSummaryEN.IdCurrEduCls == null)
{
 sbCondition.AppendFormat(" and IdCurrEduCls is null");
}
else
{
 sbCondition.AppendFormat(" and IdCurrEduCls = '{0}'", objzx_SysScoreSummaryEN.IdCurrEduCls);
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
 objSQL = clszx_SysScoreSummaryDA.GetSpecSQLObj();
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
 objSQL = clszx_SysScoreSummaryDA.GetSpecSQLObj();
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
 objSQL = clszx_SysScoreSummaryDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clszx_SysScoreSummaryEN._CurrTabName);
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
 objSQL = clszx_SysScoreSummaryDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clszx_SysScoreSummaryEN._CurrTabName, strCondition);
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
 objSQL = clszx_SysScoreSummaryDA.GetSpecSQLObj();
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
 objSQL = clszx_SysScoreSummaryDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}