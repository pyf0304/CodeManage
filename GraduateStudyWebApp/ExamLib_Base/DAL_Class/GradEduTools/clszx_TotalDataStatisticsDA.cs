
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clszx_TotalDataStatisticsDA
 表名:zx_TotalDataStatistics(01120791)
 * 版本:2023.11.15.1(服务器:WIN-SRV103-116)
 日期:2023/11/15 22:55:59
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
 /// 中学总数据统计(zx_TotalDataStatistics)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clszx_TotalDataStatisticsDA : clsCommBase4DA
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
 return clszx_TotalDataStatisticsEN._CurrTabName;
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
if (string.IsNullOrEmpty(clszx_TotalDataStatisticsEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clszx_TotalDataStatisticsEN._ConnectString);
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
 if (string.IsNullOrEmpty(clszx_TotalDataStatisticsEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clszx_TotalDataStatisticsEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strTotalDataId">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strTotalDataId)
{
strTotalDataId = strTotalDataId.Replace("'", "''");
if (strTotalDataId.Length > 12)
{
throw new Exception("(errid:Data000001)在表:zx_TotalDataStatistics中,检查关键字,长度不正确!(clszx_TotalDataStatisticsDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strTotalDataId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:zx_TotalDataStatistics中,关键字不能为空 或 null!(clszx_TotalDataStatisticsDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strTotalDataId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clszx_TotalDataStatisticsDA:CheckPrimaryKey)", objException.Message));
}
return true;
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clszx_TotalDataStatisticsDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_TotalDataStatisticsDA.GetSpecSQLObj();
strSQL = "Select * from zx_TotalDataStatistics where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_zx_TotalDataStatistics(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clszx_TotalDataStatisticsDA: GetDataTable_zx_TotalDataStatistics)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_TotalDataStatisticsDA.GetSpecSQLObj();
strSQL = "Select * from zx_TotalDataStatistics where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clszx_TotalDataStatisticsDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_TotalDataStatisticsDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clszx_TotalDataStatisticsDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_TotalDataStatisticsDA.GetSpecSQLObj();
strSQL = "Select * from zx_TotalDataStatistics where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clszx_TotalDataStatisticsDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_TotalDataStatisticsDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clszx_TotalDataStatisticsDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_TotalDataStatisticsDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from zx_TotalDataStatistics where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from zx_TotalDataStatistics where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clszx_TotalDataStatisticsDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_TotalDataStatisticsDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from zx_TotalDataStatistics where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clszx_TotalDataStatisticsDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_TotalDataStatisticsDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} zx_TotalDataStatistics.* from zx_TotalDataStatistics Left Join {1} on {2} where {3} and zx_TotalDataStatistics.TotalDataId not in (Select top {5} zx_TotalDataStatistics.TotalDataId from zx_TotalDataStatistics Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from zx_TotalDataStatistics where {1} and TotalDataId not in (Select top {2} TotalDataId from zx_TotalDataStatistics where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from zx_TotalDataStatistics where {1} and TotalDataId not in (Select top {3} TotalDataId from zx_TotalDataStatistics where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clszx_TotalDataStatisticsDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_TotalDataStatisticsDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} zx_TotalDataStatistics.* from zx_TotalDataStatistics Left Join {1} on {2} where {3} and zx_TotalDataStatistics.TotalDataId not in (Select top {5} zx_TotalDataStatistics.TotalDataId from zx_TotalDataStatistics Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from zx_TotalDataStatistics where {1} and TotalDataId not in (Select top {2} TotalDataId from zx_TotalDataStatistics where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from zx_TotalDataStatistics where {1} and TotalDataId not in (Select top {3} TotalDataId from zx_TotalDataStatistics where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clszx_TotalDataStatisticsEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clszx_TotalDataStatisticsDA:GetObjLst)", objException.Message));
}
List<clszx_TotalDataStatisticsEN> arrObjLst = new List<clszx_TotalDataStatisticsEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_TotalDataStatisticsDA.GetSpecSQLObj();
strSQL = "Select * from zx_TotalDataStatistics where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_TotalDataStatisticsEN objzx_TotalDataStatisticsEN = new clszx_TotalDataStatisticsEN();
try
{
objzx_TotalDataStatisticsEN.TotalDataId = objRow[conzx_TotalDataStatistics.TotalDataId].ToString().Trim(); //TotalDataId
objzx_TotalDataStatisticsEN.IdCurrEduCls = objRow[conzx_TotalDataStatistics.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_TotalDataStatisticsEN.zxTotalDataTypeId = objRow[conzx_TotalDataStatistics.zxTotalDataTypeId].ToString().Trim(); //总数据类型Id
objzx_TotalDataStatisticsEN.TableKey = objRow[conzx_TotalDataStatistics.TableKey] == DBNull.Value ? null : objRow[conzx_TotalDataStatistics.TableKey].ToString().Trim(); //表主键
objzx_TotalDataStatisticsEN.DataUser = objRow[conzx_TotalDataStatistics.DataUser] == DBNull.Value ? null : objRow[conzx_TotalDataStatistics.DataUser].ToString().Trim(); //数据用户
objzx_TotalDataStatisticsEN.DataAddDate = objRow[conzx_TotalDataStatistics.DataAddDate] == DBNull.Value ? null : objRow[conzx_TotalDataStatistics.DataAddDate].ToString().Trim(); //数据添加日期
objzx_TotalDataStatisticsEN.Month = objRow[conzx_TotalDataStatistics.Month] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_TotalDataStatistics.Month].ToString().Trim()); //月
objzx_TotalDataStatisticsEN.Week = objRow[conzx_TotalDataStatistics.Week] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_TotalDataStatistics.Week].ToString().Trim()); //周
objzx_TotalDataStatisticsEN.UpdDate = objRow[conzx_TotalDataStatistics.UpdDate] == DBNull.Value ? null : objRow[conzx_TotalDataStatistics.UpdDate].ToString().Trim(); //修改日期
objzx_TotalDataStatisticsEN.UpdUser = objRow[conzx_TotalDataStatistics.UpdUser] == DBNull.Value ? null : objRow[conzx_TotalDataStatistics.UpdUser].ToString().Trim(); //修改人
objzx_TotalDataStatisticsEN.Memo = objRow[conzx_TotalDataStatistics.Memo] == DBNull.Value ? null : objRow[conzx_TotalDataStatistics.Memo].ToString().Trim(); //备注
objzx_TotalDataStatisticsEN.Score = objRow[conzx_TotalDataStatistics.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conzx_TotalDataStatistics.Score].ToString().Trim()); //评分
objzx_TotalDataStatisticsEN.TeaScore = objRow[conzx_TotalDataStatistics.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conzx_TotalDataStatistics.TeaScore].ToString().Trim()); //教师评分
objzx_TotalDataStatisticsEN.WeekTimeRange = objRow[conzx_TotalDataStatistics.WeekTimeRange] == DBNull.Value ? null : objRow[conzx_TotalDataStatistics.WeekTimeRange].ToString().Trim(); //WeekTimeRange
objzx_TotalDataStatisticsEN.StuScore = objRow[conzx_TotalDataStatistics.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conzx_TotalDataStatistics.StuScore].ToString().Trim()); //学生平均分
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clszx_TotalDataStatisticsDA: GetObjLst)", objException.Message));
}
objzx_TotalDataStatisticsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objzx_TotalDataStatisticsEN);
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
public List<clszx_TotalDataStatisticsEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clszx_TotalDataStatisticsDA:GetObjLstByTabName)", objException.Message));
}
List<clszx_TotalDataStatisticsEN> arrObjLst = new List<clszx_TotalDataStatisticsEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_TotalDataStatisticsDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_TotalDataStatisticsEN objzx_TotalDataStatisticsEN = new clszx_TotalDataStatisticsEN();
try
{
objzx_TotalDataStatisticsEN.TotalDataId = objRow[conzx_TotalDataStatistics.TotalDataId].ToString().Trim(); //TotalDataId
objzx_TotalDataStatisticsEN.IdCurrEduCls = objRow[conzx_TotalDataStatistics.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_TotalDataStatisticsEN.zxTotalDataTypeId = objRow[conzx_TotalDataStatistics.zxTotalDataTypeId].ToString().Trim(); //总数据类型Id
objzx_TotalDataStatisticsEN.TableKey = objRow[conzx_TotalDataStatistics.TableKey] == DBNull.Value ? null : objRow[conzx_TotalDataStatistics.TableKey].ToString().Trim(); //表主键
objzx_TotalDataStatisticsEN.DataUser = objRow[conzx_TotalDataStatistics.DataUser] == DBNull.Value ? null : objRow[conzx_TotalDataStatistics.DataUser].ToString().Trim(); //数据用户
objzx_TotalDataStatisticsEN.DataAddDate = objRow[conzx_TotalDataStatistics.DataAddDate] == DBNull.Value ? null : objRow[conzx_TotalDataStatistics.DataAddDate].ToString().Trim(); //数据添加日期
objzx_TotalDataStatisticsEN.Month = objRow[conzx_TotalDataStatistics.Month] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_TotalDataStatistics.Month].ToString().Trim()); //月
objzx_TotalDataStatisticsEN.Week = objRow[conzx_TotalDataStatistics.Week] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_TotalDataStatistics.Week].ToString().Trim()); //周
objzx_TotalDataStatisticsEN.UpdDate = objRow[conzx_TotalDataStatistics.UpdDate] == DBNull.Value ? null : objRow[conzx_TotalDataStatistics.UpdDate].ToString().Trim(); //修改日期
objzx_TotalDataStatisticsEN.UpdUser = objRow[conzx_TotalDataStatistics.UpdUser] == DBNull.Value ? null : objRow[conzx_TotalDataStatistics.UpdUser].ToString().Trim(); //修改人
objzx_TotalDataStatisticsEN.Memo = objRow[conzx_TotalDataStatistics.Memo] == DBNull.Value ? null : objRow[conzx_TotalDataStatistics.Memo].ToString().Trim(); //备注
objzx_TotalDataStatisticsEN.Score = objRow[conzx_TotalDataStatistics.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conzx_TotalDataStatistics.Score].ToString().Trim()); //评分
objzx_TotalDataStatisticsEN.TeaScore = objRow[conzx_TotalDataStatistics.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conzx_TotalDataStatistics.TeaScore].ToString().Trim()); //教师评分
objzx_TotalDataStatisticsEN.WeekTimeRange = objRow[conzx_TotalDataStatistics.WeekTimeRange] == DBNull.Value ? null : objRow[conzx_TotalDataStatistics.WeekTimeRange].ToString().Trim(); //WeekTimeRange
objzx_TotalDataStatisticsEN.StuScore = objRow[conzx_TotalDataStatistics.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conzx_TotalDataStatistics.StuScore].ToString().Trim()); //学生平均分
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clszx_TotalDataStatisticsDA: GetObjLst)", objException.Message));
}
objzx_TotalDataStatisticsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objzx_TotalDataStatisticsEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objzx_TotalDataStatisticsEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool Getzx_TotalDataStatistics(ref clszx_TotalDataStatisticsEN objzx_TotalDataStatisticsEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_TotalDataStatisticsDA.GetSpecSQLObj();
strSQL = "Select * from zx_TotalDataStatistics where TotalDataId = " + "'"+ objzx_TotalDataStatisticsEN.TotalDataId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objzx_TotalDataStatisticsEN.TotalDataId = objDT.Rows[0][conzx_TotalDataStatistics.TotalDataId].ToString().Trim(); //TotalDataId(字段类型:char,字段长度:12,是否可空:False)
 objzx_TotalDataStatisticsEN.IdCurrEduCls = objDT.Rows[0][conzx_TotalDataStatistics.IdCurrEduCls].ToString().Trim(); //教学班流水号(字段类型:char,字段长度:8,是否可空:False)
 objzx_TotalDataStatisticsEN.zxTotalDataTypeId = objDT.Rows[0][conzx_TotalDataStatistics.zxTotalDataTypeId].ToString().Trim(); //总数据类型Id(字段类型:char,字段长度:2,是否可空:False)
 objzx_TotalDataStatisticsEN.TableKey = objDT.Rows[0][conzx_TotalDataStatistics.TableKey].ToString().Trim(); //表主键(字段类型:varchar,字段长度:20,是否可空:True)
 objzx_TotalDataStatisticsEN.DataUser = objDT.Rows[0][conzx_TotalDataStatistics.DataUser].ToString().Trim(); //数据用户(字段类型:varchar,字段长度:20,是否可空:True)
 objzx_TotalDataStatisticsEN.DataAddDate = objDT.Rows[0][conzx_TotalDataStatistics.DataAddDate].ToString().Trim(); //数据添加日期(字段类型:varchar,字段长度:20,是否可空:True)
 objzx_TotalDataStatisticsEN.Month = TransNullToInt(objDT.Rows[0][conzx_TotalDataStatistics.Month].ToString().Trim()); //月(字段类型:int,字段长度:4,是否可空:True)
 objzx_TotalDataStatisticsEN.Week = TransNullToInt(objDT.Rows[0][conzx_TotalDataStatistics.Week].ToString().Trim()); //周(字段类型:int,字段长度:4,是否可空:True)
 objzx_TotalDataStatisticsEN.UpdDate = objDT.Rows[0][conzx_TotalDataStatistics.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objzx_TotalDataStatisticsEN.UpdUser = objDT.Rows[0][conzx_TotalDataStatistics.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objzx_TotalDataStatisticsEN.Memo = objDT.Rows[0][conzx_TotalDataStatistics.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objzx_TotalDataStatisticsEN.Score = TransNullToFloat(objDT.Rows[0][conzx_TotalDataStatistics.Score].ToString().Trim()); //评分(字段类型:float,字段长度:8,是否可空:True)
 objzx_TotalDataStatisticsEN.TeaScore = TransNullToFloat(objDT.Rows[0][conzx_TotalDataStatistics.TeaScore].ToString().Trim()); //教师评分(字段类型:float,字段长度:8,是否可空:True)
 objzx_TotalDataStatisticsEN.WeekTimeRange = objDT.Rows[0][conzx_TotalDataStatistics.WeekTimeRange].ToString().Trim(); //WeekTimeRange(字段类型:varchar,字段长度:100,是否可空:True)
 objzx_TotalDataStatisticsEN.StuScore = TransNullToFloat(objDT.Rows[0][conzx_TotalDataStatistics.StuScore].ToString().Trim()); //学生平均分(字段类型:float,字段长度:8,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clszx_TotalDataStatisticsDA: Getzx_TotalDataStatistics)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strTotalDataId">表关键字</param>
 /// <returns>表对象</returns>
public clszx_TotalDataStatisticsEN GetObjByTotalDataId(string strTotalDataId)
{
CheckPrimaryKey(strTotalDataId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_TotalDataStatisticsDA.GetSpecSQLObj();
strSQL = "Select * from zx_TotalDataStatistics where TotalDataId = " + "'"+ strTotalDataId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clszx_TotalDataStatisticsEN objzx_TotalDataStatisticsEN = new clszx_TotalDataStatisticsEN();
try
{
 objzx_TotalDataStatisticsEN.TotalDataId = objRow[conzx_TotalDataStatistics.TotalDataId].ToString().Trim(); //TotalDataId(字段类型:char,字段长度:12,是否可空:False)
 objzx_TotalDataStatisticsEN.IdCurrEduCls = objRow[conzx_TotalDataStatistics.IdCurrEduCls].ToString().Trim(); //教学班流水号(字段类型:char,字段长度:8,是否可空:False)
 objzx_TotalDataStatisticsEN.zxTotalDataTypeId = objRow[conzx_TotalDataStatistics.zxTotalDataTypeId].ToString().Trim(); //总数据类型Id(字段类型:char,字段长度:2,是否可空:False)
 objzx_TotalDataStatisticsEN.TableKey = objRow[conzx_TotalDataStatistics.TableKey] == DBNull.Value ? null : objRow[conzx_TotalDataStatistics.TableKey].ToString().Trim(); //表主键(字段类型:varchar,字段长度:20,是否可空:True)
 objzx_TotalDataStatisticsEN.DataUser = objRow[conzx_TotalDataStatistics.DataUser] == DBNull.Value ? null : objRow[conzx_TotalDataStatistics.DataUser].ToString().Trim(); //数据用户(字段类型:varchar,字段长度:20,是否可空:True)
 objzx_TotalDataStatisticsEN.DataAddDate = objRow[conzx_TotalDataStatistics.DataAddDate] == DBNull.Value ? null : objRow[conzx_TotalDataStatistics.DataAddDate].ToString().Trim(); //数据添加日期(字段类型:varchar,字段长度:20,是否可空:True)
 objzx_TotalDataStatisticsEN.Month = objRow[conzx_TotalDataStatistics.Month] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_TotalDataStatistics.Month].ToString().Trim()); //月(字段类型:int,字段长度:4,是否可空:True)
 objzx_TotalDataStatisticsEN.Week = objRow[conzx_TotalDataStatistics.Week] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_TotalDataStatistics.Week].ToString().Trim()); //周(字段类型:int,字段长度:4,是否可空:True)
 objzx_TotalDataStatisticsEN.UpdDate = objRow[conzx_TotalDataStatistics.UpdDate] == DBNull.Value ? null : objRow[conzx_TotalDataStatistics.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objzx_TotalDataStatisticsEN.UpdUser = objRow[conzx_TotalDataStatistics.UpdUser] == DBNull.Value ? null : objRow[conzx_TotalDataStatistics.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objzx_TotalDataStatisticsEN.Memo = objRow[conzx_TotalDataStatistics.Memo] == DBNull.Value ? null : objRow[conzx_TotalDataStatistics.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objzx_TotalDataStatisticsEN.Score = objRow[conzx_TotalDataStatistics.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_TotalDataStatistics.Score].ToString().Trim()); //评分(字段类型:float,字段长度:8,是否可空:True)
 objzx_TotalDataStatisticsEN.TeaScore = objRow[conzx_TotalDataStatistics.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_TotalDataStatistics.TeaScore].ToString().Trim()); //教师评分(字段类型:float,字段长度:8,是否可空:True)
 objzx_TotalDataStatisticsEN.WeekTimeRange = objRow[conzx_TotalDataStatistics.WeekTimeRange] == DBNull.Value ? null : objRow[conzx_TotalDataStatistics.WeekTimeRange].ToString().Trim(); //WeekTimeRange(字段类型:varchar,字段长度:100,是否可空:True)
 objzx_TotalDataStatisticsEN.StuScore = objRow[conzx_TotalDataStatistics.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_TotalDataStatistics.StuScore].ToString().Trim()); //学生平均分(字段类型:float,字段长度:8,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clszx_TotalDataStatisticsDA: GetObjByTotalDataId)", objException.Message));
}
return objzx_TotalDataStatisticsEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clszx_TotalDataStatisticsEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clszx_TotalDataStatisticsDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_TotalDataStatisticsDA.GetSpecSQLObj();
strSQL = "Select * from zx_TotalDataStatistics where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clszx_TotalDataStatisticsEN objzx_TotalDataStatisticsEN = new clszx_TotalDataStatisticsEN()
{
TotalDataId = objRow[conzx_TotalDataStatistics.TotalDataId].ToString().Trim(), //TotalDataId
IdCurrEduCls = objRow[conzx_TotalDataStatistics.IdCurrEduCls].ToString().Trim(), //教学班流水号
zxTotalDataTypeId = objRow[conzx_TotalDataStatistics.zxTotalDataTypeId].ToString().Trim(), //总数据类型Id
TableKey = objRow[conzx_TotalDataStatistics.TableKey] == DBNull.Value ? null : objRow[conzx_TotalDataStatistics.TableKey].ToString().Trim(), //表主键
DataUser = objRow[conzx_TotalDataStatistics.DataUser] == DBNull.Value ? null : objRow[conzx_TotalDataStatistics.DataUser].ToString().Trim(), //数据用户
DataAddDate = objRow[conzx_TotalDataStatistics.DataAddDate] == DBNull.Value ? null : objRow[conzx_TotalDataStatistics.DataAddDate].ToString().Trim(), //数据添加日期
Month = objRow[conzx_TotalDataStatistics.Month] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_TotalDataStatistics.Month].ToString().Trim()), //月
Week = objRow[conzx_TotalDataStatistics.Week] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_TotalDataStatistics.Week].ToString().Trim()), //周
UpdDate = objRow[conzx_TotalDataStatistics.UpdDate] == DBNull.Value ? null : objRow[conzx_TotalDataStatistics.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[conzx_TotalDataStatistics.UpdUser] == DBNull.Value ? null : objRow[conzx_TotalDataStatistics.UpdUser].ToString().Trim(), //修改人
Memo = objRow[conzx_TotalDataStatistics.Memo] == DBNull.Value ? null : objRow[conzx_TotalDataStatistics.Memo].ToString().Trim(), //备注
Score = objRow[conzx_TotalDataStatistics.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conzx_TotalDataStatistics.Score].ToString().Trim()), //评分
TeaScore = objRow[conzx_TotalDataStatistics.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conzx_TotalDataStatistics.TeaScore].ToString().Trim()), //教师评分
WeekTimeRange = objRow[conzx_TotalDataStatistics.WeekTimeRange] == DBNull.Value ? null : objRow[conzx_TotalDataStatistics.WeekTimeRange].ToString().Trim(), //WeekTimeRange
StuScore = objRow[conzx_TotalDataStatistics.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conzx_TotalDataStatistics.StuScore].ToString().Trim()) //学生平均分
};
objzx_TotalDataStatisticsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objzx_TotalDataStatisticsEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clszx_TotalDataStatisticsDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clszx_TotalDataStatisticsEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clszx_TotalDataStatisticsEN objzx_TotalDataStatisticsEN = new clszx_TotalDataStatisticsEN();
try
{
objzx_TotalDataStatisticsEN.TotalDataId = objRow[conzx_TotalDataStatistics.TotalDataId].ToString().Trim(); //TotalDataId
objzx_TotalDataStatisticsEN.IdCurrEduCls = objRow[conzx_TotalDataStatistics.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_TotalDataStatisticsEN.zxTotalDataTypeId = objRow[conzx_TotalDataStatistics.zxTotalDataTypeId].ToString().Trim(); //总数据类型Id
objzx_TotalDataStatisticsEN.TableKey = objRow[conzx_TotalDataStatistics.TableKey] == DBNull.Value ? null : objRow[conzx_TotalDataStatistics.TableKey].ToString().Trim(); //表主键
objzx_TotalDataStatisticsEN.DataUser = objRow[conzx_TotalDataStatistics.DataUser] == DBNull.Value ? null : objRow[conzx_TotalDataStatistics.DataUser].ToString().Trim(); //数据用户
objzx_TotalDataStatisticsEN.DataAddDate = objRow[conzx_TotalDataStatistics.DataAddDate] == DBNull.Value ? null : objRow[conzx_TotalDataStatistics.DataAddDate].ToString().Trim(); //数据添加日期
objzx_TotalDataStatisticsEN.Month = objRow[conzx_TotalDataStatistics.Month] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_TotalDataStatistics.Month].ToString().Trim()); //月
objzx_TotalDataStatisticsEN.Week = objRow[conzx_TotalDataStatistics.Week] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_TotalDataStatistics.Week].ToString().Trim()); //周
objzx_TotalDataStatisticsEN.UpdDate = objRow[conzx_TotalDataStatistics.UpdDate] == DBNull.Value ? null : objRow[conzx_TotalDataStatistics.UpdDate].ToString().Trim(); //修改日期
objzx_TotalDataStatisticsEN.UpdUser = objRow[conzx_TotalDataStatistics.UpdUser] == DBNull.Value ? null : objRow[conzx_TotalDataStatistics.UpdUser].ToString().Trim(); //修改人
objzx_TotalDataStatisticsEN.Memo = objRow[conzx_TotalDataStatistics.Memo] == DBNull.Value ? null : objRow[conzx_TotalDataStatistics.Memo].ToString().Trim(); //备注
objzx_TotalDataStatisticsEN.Score = objRow[conzx_TotalDataStatistics.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conzx_TotalDataStatistics.Score].ToString().Trim()); //评分
objzx_TotalDataStatisticsEN.TeaScore = objRow[conzx_TotalDataStatistics.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conzx_TotalDataStatistics.TeaScore].ToString().Trim()); //教师评分
objzx_TotalDataStatisticsEN.WeekTimeRange = objRow[conzx_TotalDataStatistics.WeekTimeRange] == DBNull.Value ? null : objRow[conzx_TotalDataStatistics.WeekTimeRange].ToString().Trim(); //WeekTimeRange
objzx_TotalDataStatisticsEN.StuScore = objRow[conzx_TotalDataStatistics.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conzx_TotalDataStatistics.StuScore].ToString().Trim()); //学生平均分
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clszx_TotalDataStatisticsDA: GetObjByDataRowzx_TotalDataStatistics)", objException.Message));
}
objzx_TotalDataStatisticsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objzx_TotalDataStatisticsEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clszx_TotalDataStatisticsEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clszx_TotalDataStatisticsEN objzx_TotalDataStatisticsEN = new clszx_TotalDataStatisticsEN();
try
{
objzx_TotalDataStatisticsEN.TotalDataId = objRow[conzx_TotalDataStatistics.TotalDataId].ToString().Trim(); //TotalDataId
objzx_TotalDataStatisticsEN.IdCurrEduCls = objRow[conzx_TotalDataStatistics.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_TotalDataStatisticsEN.zxTotalDataTypeId = objRow[conzx_TotalDataStatistics.zxTotalDataTypeId].ToString().Trim(); //总数据类型Id
objzx_TotalDataStatisticsEN.TableKey = objRow[conzx_TotalDataStatistics.TableKey] == DBNull.Value ? null : objRow[conzx_TotalDataStatistics.TableKey].ToString().Trim(); //表主键
objzx_TotalDataStatisticsEN.DataUser = objRow[conzx_TotalDataStatistics.DataUser] == DBNull.Value ? null : objRow[conzx_TotalDataStatistics.DataUser].ToString().Trim(); //数据用户
objzx_TotalDataStatisticsEN.DataAddDate = objRow[conzx_TotalDataStatistics.DataAddDate] == DBNull.Value ? null : objRow[conzx_TotalDataStatistics.DataAddDate].ToString().Trim(); //数据添加日期
objzx_TotalDataStatisticsEN.Month = objRow[conzx_TotalDataStatistics.Month] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_TotalDataStatistics.Month].ToString().Trim()); //月
objzx_TotalDataStatisticsEN.Week = objRow[conzx_TotalDataStatistics.Week] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_TotalDataStatistics.Week].ToString().Trim()); //周
objzx_TotalDataStatisticsEN.UpdDate = objRow[conzx_TotalDataStatistics.UpdDate] == DBNull.Value ? null : objRow[conzx_TotalDataStatistics.UpdDate].ToString().Trim(); //修改日期
objzx_TotalDataStatisticsEN.UpdUser = objRow[conzx_TotalDataStatistics.UpdUser] == DBNull.Value ? null : objRow[conzx_TotalDataStatistics.UpdUser].ToString().Trim(); //修改人
objzx_TotalDataStatisticsEN.Memo = objRow[conzx_TotalDataStatistics.Memo] == DBNull.Value ? null : objRow[conzx_TotalDataStatistics.Memo].ToString().Trim(); //备注
objzx_TotalDataStatisticsEN.Score = objRow[conzx_TotalDataStatistics.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conzx_TotalDataStatistics.Score].ToString().Trim()); //评分
objzx_TotalDataStatisticsEN.TeaScore = objRow[conzx_TotalDataStatistics.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conzx_TotalDataStatistics.TeaScore].ToString().Trim()); //教师评分
objzx_TotalDataStatisticsEN.WeekTimeRange = objRow[conzx_TotalDataStatistics.WeekTimeRange] == DBNull.Value ? null : objRow[conzx_TotalDataStatistics.WeekTimeRange].ToString().Trim(); //WeekTimeRange
objzx_TotalDataStatisticsEN.StuScore = objRow[conzx_TotalDataStatistics.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conzx_TotalDataStatistics.StuScore].ToString().Trim()); //学生平均分
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clszx_TotalDataStatisticsDA: GetObjByDataRow)", objException.Message));
}
objzx_TotalDataStatisticsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objzx_TotalDataStatisticsEN;
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
objSQL = clszx_TotalDataStatisticsDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clszx_TotalDataStatisticsEN._CurrTabName, conzx_TotalDataStatistics.TotalDataId, 12, "");
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
objSQL = clszx_TotalDataStatisticsDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clszx_TotalDataStatisticsEN._CurrTabName, conzx_TotalDataStatistics.TotalDataId, 12, strPrefix);
return strMaxValue;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的关键字值
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstID)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public string GetFirstID(string strCondition) 
{
string strSQL ;
 System.Data.DataTable objDT ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_TotalDataStatisticsDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select TotalDataId from zx_TotalDataStatistics where " + strCondition;
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
return "";
}
strKeyValue = objDT.Rows[0][0].ToString();
return strKeyValue;
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
 objSQL = clszx_TotalDataStatisticsDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select TotalDataId from zx_TotalDataStatistics where " + strCondition;
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
 /// <param name = "strTotalDataId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strTotalDataId)
{
CheckPrimaryKey(strTotalDataId);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_TotalDataStatisticsDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("zx_TotalDataStatistics", "TotalDataId = " + "'"+ strTotalDataId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clszx_TotalDataStatisticsDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_TotalDataStatisticsDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("zx_TotalDataStatistics", strCondition))
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
objSQL = clszx_TotalDataStatisticsDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("zx_TotalDataStatistics");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clszx_TotalDataStatisticsEN objzx_TotalDataStatisticsEN)
 {
 if (objzx_TotalDataStatisticsEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objzx_TotalDataStatisticsEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_TotalDataStatisticsDA.GetSpecSQLObj();
strSQL = "Select * from zx_TotalDataStatistics where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "zx_TotalDataStatistics");
objRow = objDS.Tables["zx_TotalDataStatistics"].NewRow();
objRow[conzx_TotalDataStatistics.TotalDataId] = objzx_TotalDataStatisticsEN.TotalDataId; //TotalDataId
objRow[conzx_TotalDataStatistics.IdCurrEduCls] = objzx_TotalDataStatisticsEN.IdCurrEduCls; //教学班流水号
objRow[conzx_TotalDataStatistics.zxTotalDataTypeId] = objzx_TotalDataStatisticsEN.zxTotalDataTypeId; //总数据类型Id
 if (objzx_TotalDataStatisticsEN.TableKey !=  "")
 {
objRow[conzx_TotalDataStatistics.TableKey] = objzx_TotalDataStatisticsEN.TableKey; //表主键
 }
 if (objzx_TotalDataStatisticsEN.DataUser !=  "")
 {
objRow[conzx_TotalDataStatistics.DataUser] = objzx_TotalDataStatisticsEN.DataUser; //数据用户
 }
 if (objzx_TotalDataStatisticsEN.DataAddDate !=  "")
 {
objRow[conzx_TotalDataStatistics.DataAddDate] = objzx_TotalDataStatisticsEN.DataAddDate; //数据添加日期
 }
objRow[conzx_TotalDataStatistics.Month] = objzx_TotalDataStatisticsEN.Month; //月
objRow[conzx_TotalDataStatistics.Week] = objzx_TotalDataStatisticsEN.Week; //周
 if (objzx_TotalDataStatisticsEN.UpdDate !=  "")
 {
objRow[conzx_TotalDataStatistics.UpdDate] = objzx_TotalDataStatisticsEN.UpdDate; //修改日期
 }
 if (objzx_TotalDataStatisticsEN.UpdUser !=  "")
 {
objRow[conzx_TotalDataStatistics.UpdUser] = objzx_TotalDataStatisticsEN.UpdUser; //修改人
 }
 if (objzx_TotalDataStatisticsEN.Memo !=  "")
 {
objRow[conzx_TotalDataStatistics.Memo] = objzx_TotalDataStatisticsEN.Memo; //备注
 }
objRow[conzx_TotalDataStatistics.Score] = objzx_TotalDataStatisticsEN.Score; //评分
objRow[conzx_TotalDataStatistics.TeaScore] = objzx_TotalDataStatisticsEN.TeaScore; //教师评分
 if (objzx_TotalDataStatisticsEN.WeekTimeRange !=  "")
 {
objRow[conzx_TotalDataStatistics.WeekTimeRange] = objzx_TotalDataStatisticsEN.WeekTimeRange; //WeekTimeRange
 }
objRow[conzx_TotalDataStatistics.StuScore] = objzx_TotalDataStatisticsEN.StuScore; //学生平均分
objDS.Tables[clszx_TotalDataStatisticsEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clszx_TotalDataStatisticsEN._CurrTabName);
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
 /// <param name = "objzx_TotalDataStatisticsEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clszx_TotalDataStatisticsEN objzx_TotalDataStatisticsEN)
{
 if (objzx_TotalDataStatisticsEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objzx_TotalDataStatisticsEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objzx_TotalDataStatisticsEN.TotalDataId !=  null)
 {
 arrFieldListForInsert.Add(conzx_TotalDataStatistics.TotalDataId);
 var strTotalDataId = objzx_TotalDataStatisticsEN.TotalDataId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTotalDataId + "'");
 }
 
 if (objzx_TotalDataStatisticsEN.IdCurrEduCls !=  null)
 {
 arrFieldListForInsert.Add(conzx_TotalDataStatistics.IdCurrEduCls);
 var strIdCurrEduCls = objzx_TotalDataStatisticsEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCurrEduCls + "'");
 }
 
 if (objzx_TotalDataStatisticsEN.zxTotalDataTypeId !=  null)
 {
 arrFieldListForInsert.Add(conzx_TotalDataStatistics.zxTotalDataTypeId);
 var strzxTotalDataTypeId = objzx_TotalDataStatisticsEN.zxTotalDataTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strzxTotalDataTypeId + "'");
 }
 
 if (objzx_TotalDataStatisticsEN.TableKey !=  null)
 {
 arrFieldListForInsert.Add(conzx_TotalDataStatistics.TableKey);
 var strTableKey = objzx_TotalDataStatisticsEN.TableKey.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTableKey + "'");
 }
 
 if (objzx_TotalDataStatisticsEN.DataUser !=  null)
 {
 arrFieldListForInsert.Add(conzx_TotalDataStatistics.DataUser);
 var strDataUser = objzx_TotalDataStatisticsEN.DataUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDataUser + "'");
 }
 
 if (objzx_TotalDataStatisticsEN.DataAddDate !=  null)
 {
 arrFieldListForInsert.Add(conzx_TotalDataStatistics.DataAddDate);
 var strDataAddDate = objzx_TotalDataStatisticsEN.DataAddDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDataAddDate + "'");
 }
 
 if (objzx_TotalDataStatisticsEN.Month !=  null)
 {
 arrFieldListForInsert.Add(conzx_TotalDataStatistics.Month);
 arrValueListForInsert.Add(objzx_TotalDataStatisticsEN.Month.ToString());
 }
 
 if (objzx_TotalDataStatisticsEN.Week !=  null)
 {
 arrFieldListForInsert.Add(conzx_TotalDataStatistics.Week);
 arrValueListForInsert.Add(objzx_TotalDataStatisticsEN.Week.ToString());
 }
 
 if (objzx_TotalDataStatisticsEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conzx_TotalDataStatistics.UpdDate);
 var strUpdDate = objzx_TotalDataStatisticsEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objzx_TotalDataStatisticsEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conzx_TotalDataStatistics.UpdUser);
 var strUpdUser = objzx_TotalDataStatisticsEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objzx_TotalDataStatisticsEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conzx_TotalDataStatistics.Memo);
 var strMemo = objzx_TotalDataStatisticsEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objzx_TotalDataStatisticsEN.Score !=  null)
 {
 arrFieldListForInsert.Add(conzx_TotalDataStatistics.Score);
 arrValueListForInsert.Add(objzx_TotalDataStatisticsEN.Score.ToString());
 }
 
 if (objzx_TotalDataStatisticsEN.TeaScore !=  null)
 {
 arrFieldListForInsert.Add(conzx_TotalDataStatistics.TeaScore);
 arrValueListForInsert.Add(objzx_TotalDataStatisticsEN.TeaScore.ToString());
 }
 
 if (objzx_TotalDataStatisticsEN.WeekTimeRange !=  null)
 {
 arrFieldListForInsert.Add(conzx_TotalDataStatistics.WeekTimeRange);
 var strWeekTimeRange = objzx_TotalDataStatisticsEN.WeekTimeRange.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strWeekTimeRange + "'");
 }
 
 if (objzx_TotalDataStatisticsEN.StuScore !=  null)
 {
 arrFieldListForInsert.Add(conzx_TotalDataStatistics.StuScore);
 arrValueListForInsert.Add(objzx_TotalDataStatisticsEN.StuScore.ToString());
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into zx_TotalDataStatistics");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_TotalDataStatisticsDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objzx_TotalDataStatisticsEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clszx_TotalDataStatisticsEN objzx_TotalDataStatisticsEN)
{
 if (objzx_TotalDataStatisticsEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objzx_TotalDataStatisticsEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objzx_TotalDataStatisticsEN.TotalDataId !=  null)
 {
 arrFieldListForInsert.Add(conzx_TotalDataStatistics.TotalDataId);
 var strTotalDataId = objzx_TotalDataStatisticsEN.TotalDataId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTotalDataId + "'");
 }
 
 if (objzx_TotalDataStatisticsEN.IdCurrEduCls !=  null)
 {
 arrFieldListForInsert.Add(conzx_TotalDataStatistics.IdCurrEduCls);
 var strIdCurrEduCls = objzx_TotalDataStatisticsEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCurrEduCls + "'");
 }
 
 if (objzx_TotalDataStatisticsEN.zxTotalDataTypeId !=  null)
 {
 arrFieldListForInsert.Add(conzx_TotalDataStatistics.zxTotalDataTypeId);
 var strzxTotalDataTypeId = objzx_TotalDataStatisticsEN.zxTotalDataTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strzxTotalDataTypeId + "'");
 }
 
 if (objzx_TotalDataStatisticsEN.TableKey !=  null)
 {
 arrFieldListForInsert.Add(conzx_TotalDataStatistics.TableKey);
 var strTableKey = objzx_TotalDataStatisticsEN.TableKey.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTableKey + "'");
 }
 
 if (objzx_TotalDataStatisticsEN.DataUser !=  null)
 {
 arrFieldListForInsert.Add(conzx_TotalDataStatistics.DataUser);
 var strDataUser = objzx_TotalDataStatisticsEN.DataUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDataUser + "'");
 }
 
 if (objzx_TotalDataStatisticsEN.DataAddDate !=  null)
 {
 arrFieldListForInsert.Add(conzx_TotalDataStatistics.DataAddDate);
 var strDataAddDate = objzx_TotalDataStatisticsEN.DataAddDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDataAddDate + "'");
 }
 
 if (objzx_TotalDataStatisticsEN.Month !=  null)
 {
 arrFieldListForInsert.Add(conzx_TotalDataStatistics.Month);
 arrValueListForInsert.Add(objzx_TotalDataStatisticsEN.Month.ToString());
 }
 
 if (objzx_TotalDataStatisticsEN.Week !=  null)
 {
 arrFieldListForInsert.Add(conzx_TotalDataStatistics.Week);
 arrValueListForInsert.Add(objzx_TotalDataStatisticsEN.Week.ToString());
 }
 
 if (objzx_TotalDataStatisticsEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conzx_TotalDataStatistics.UpdDate);
 var strUpdDate = objzx_TotalDataStatisticsEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objzx_TotalDataStatisticsEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conzx_TotalDataStatistics.UpdUser);
 var strUpdUser = objzx_TotalDataStatisticsEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objzx_TotalDataStatisticsEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conzx_TotalDataStatistics.Memo);
 var strMemo = objzx_TotalDataStatisticsEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objzx_TotalDataStatisticsEN.Score !=  null)
 {
 arrFieldListForInsert.Add(conzx_TotalDataStatistics.Score);
 arrValueListForInsert.Add(objzx_TotalDataStatisticsEN.Score.ToString());
 }
 
 if (objzx_TotalDataStatisticsEN.TeaScore !=  null)
 {
 arrFieldListForInsert.Add(conzx_TotalDataStatistics.TeaScore);
 arrValueListForInsert.Add(objzx_TotalDataStatisticsEN.TeaScore.ToString());
 }
 
 if (objzx_TotalDataStatisticsEN.WeekTimeRange !=  null)
 {
 arrFieldListForInsert.Add(conzx_TotalDataStatistics.WeekTimeRange);
 var strWeekTimeRange = objzx_TotalDataStatisticsEN.WeekTimeRange.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strWeekTimeRange + "'");
 }
 
 if (objzx_TotalDataStatisticsEN.StuScore !=  null)
 {
 arrFieldListForInsert.Add(conzx_TotalDataStatistics.StuScore);
 arrValueListForInsert.Add(objzx_TotalDataStatisticsEN.StuScore.ToString());
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into zx_TotalDataStatistics");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_TotalDataStatisticsDA.GetSpecSQLObj();
 objSQL.ExecSql(strSQL.ToString());
return objzx_TotalDataStatisticsEN.TotalDataId;
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objzx_TotalDataStatisticsEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clszx_TotalDataStatisticsEN objzx_TotalDataStatisticsEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objzx_TotalDataStatisticsEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objzx_TotalDataStatisticsEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objzx_TotalDataStatisticsEN.TotalDataId !=  null)
 {
 arrFieldListForInsert.Add(conzx_TotalDataStatistics.TotalDataId);
 var strTotalDataId = objzx_TotalDataStatisticsEN.TotalDataId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTotalDataId + "'");
 }
 
 if (objzx_TotalDataStatisticsEN.IdCurrEduCls !=  null)
 {
 arrFieldListForInsert.Add(conzx_TotalDataStatistics.IdCurrEduCls);
 var strIdCurrEduCls = objzx_TotalDataStatisticsEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCurrEduCls + "'");
 }
 
 if (objzx_TotalDataStatisticsEN.zxTotalDataTypeId !=  null)
 {
 arrFieldListForInsert.Add(conzx_TotalDataStatistics.zxTotalDataTypeId);
 var strzxTotalDataTypeId = objzx_TotalDataStatisticsEN.zxTotalDataTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strzxTotalDataTypeId + "'");
 }
 
 if (objzx_TotalDataStatisticsEN.TableKey !=  null)
 {
 arrFieldListForInsert.Add(conzx_TotalDataStatistics.TableKey);
 var strTableKey = objzx_TotalDataStatisticsEN.TableKey.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTableKey + "'");
 }
 
 if (objzx_TotalDataStatisticsEN.DataUser !=  null)
 {
 arrFieldListForInsert.Add(conzx_TotalDataStatistics.DataUser);
 var strDataUser = objzx_TotalDataStatisticsEN.DataUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDataUser + "'");
 }
 
 if (objzx_TotalDataStatisticsEN.DataAddDate !=  null)
 {
 arrFieldListForInsert.Add(conzx_TotalDataStatistics.DataAddDate);
 var strDataAddDate = objzx_TotalDataStatisticsEN.DataAddDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDataAddDate + "'");
 }
 
 if (objzx_TotalDataStatisticsEN.Month !=  null)
 {
 arrFieldListForInsert.Add(conzx_TotalDataStatistics.Month);
 arrValueListForInsert.Add(objzx_TotalDataStatisticsEN.Month.ToString());
 }
 
 if (objzx_TotalDataStatisticsEN.Week !=  null)
 {
 arrFieldListForInsert.Add(conzx_TotalDataStatistics.Week);
 arrValueListForInsert.Add(objzx_TotalDataStatisticsEN.Week.ToString());
 }
 
 if (objzx_TotalDataStatisticsEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conzx_TotalDataStatistics.UpdDate);
 var strUpdDate = objzx_TotalDataStatisticsEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objzx_TotalDataStatisticsEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conzx_TotalDataStatistics.UpdUser);
 var strUpdUser = objzx_TotalDataStatisticsEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objzx_TotalDataStatisticsEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conzx_TotalDataStatistics.Memo);
 var strMemo = objzx_TotalDataStatisticsEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objzx_TotalDataStatisticsEN.Score !=  null)
 {
 arrFieldListForInsert.Add(conzx_TotalDataStatistics.Score);
 arrValueListForInsert.Add(objzx_TotalDataStatisticsEN.Score.ToString());
 }
 
 if (objzx_TotalDataStatisticsEN.TeaScore !=  null)
 {
 arrFieldListForInsert.Add(conzx_TotalDataStatistics.TeaScore);
 arrValueListForInsert.Add(objzx_TotalDataStatisticsEN.TeaScore.ToString());
 }
 
 if (objzx_TotalDataStatisticsEN.WeekTimeRange !=  null)
 {
 arrFieldListForInsert.Add(conzx_TotalDataStatistics.WeekTimeRange);
 var strWeekTimeRange = objzx_TotalDataStatisticsEN.WeekTimeRange.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strWeekTimeRange + "'");
 }
 
 if (objzx_TotalDataStatisticsEN.StuScore !=  null)
 {
 arrFieldListForInsert.Add(conzx_TotalDataStatistics.StuScore);
 arrValueListForInsert.Add(objzx_TotalDataStatisticsEN.StuScore.ToString());
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into zx_TotalDataStatistics");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_TotalDataStatisticsDA.GetSpecSQLObj();
    objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
return objzx_TotalDataStatisticsEN.TotalDataId;
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objzx_TotalDataStatisticsEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clszx_TotalDataStatisticsEN objzx_TotalDataStatisticsEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objzx_TotalDataStatisticsEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objzx_TotalDataStatisticsEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objzx_TotalDataStatisticsEN.TotalDataId !=  null)
 {
 arrFieldListForInsert.Add(conzx_TotalDataStatistics.TotalDataId);
 var strTotalDataId = objzx_TotalDataStatisticsEN.TotalDataId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTotalDataId + "'");
 }
 
 if (objzx_TotalDataStatisticsEN.IdCurrEduCls !=  null)
 {
 arrFieldListForInsert.Add(conzx_TotalDataStatistics.IdCurrEduCls);
 var strIdCurrEduCls = objzx_TotalDataStatisticsEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCurrEduCls + "'");
 }
 
 if (objzx_TotalDataStatisticsEN.zxTotalDataTypeId !=  null)
 {
 arrFieldListForInsert.Add(conzx_TotalDataStatistics.zxTotalDataTypeId);
 var strzxTotalDataTypeId = objzx_TotalDataStatisticsEN.zxTotalDataTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strzxTotalDataTypeId + "'");
 }
 
 if (objzx_TotalDataStatisticsEN.TableKey !=  null)
 {
 arrFieldListForInsert.Add(conzx_TotalDataStatistics.TableKey);
 var strTableKey = objzx_TotalDataStatisticsEN.TableKey.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTableKey + "'");
 }
 
 if (objzx_TotalDataStatisticsEN.DataUser !=  null)
 {
 arrFieldListForInsert.Add(conzx_TotalDataStatistics.DataUser);
 var strDataUser = objzx_TotalDataStatisticsEN.DataUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDataUser + "'");
 }
 
 if (objzx_TotalDataStatisticsEN.DataAddDate !=  null)
 {
 arrFieldListForInsert.Add(conzx_TotalDataStatistics.DataAddDate);
 var strDataAddDate = objzx_TotalDataStatisticsEN.DataAddDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDataAddDate + "'");
 }
 
 if (objzx_TotalDataStatisticsEN.Month !=  null)
 {
 arrFieldListForInsert.Add(conzx_TotalDataStatistics.Month);
 arrValueListForInsert.Add(objzx_TotalDataStatisticsEN.Month.ToString());
 }
 
 if (objzx_TotalDataStatisticsEN.Week !=  null)
 {
 arrFieldListForInsert.Add(conzx_TotalDataStatistics.Week);
 arrValueListForInsert.Add(objzx_TotalDataStatisticsEN.Week.ToString());
 }
 
 if (objzx_TotalDataStatisticsEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conzx_TotalDataStatistics.UpdDate);
 var strUpdDate = objzx_TotalDataStatisticsEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objzx_TotalDataStatisticsEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conzx_TotalDataStatistics.UpdUser);
 var strUpdUser = objzx_TotalDataStatisticsEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objzx_TotalDataStatisticsEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conzx_TotalDataStatistics.Memo);
 var strMemo = objzx_TotalDataStatisticsEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objzx_TotalDataStatisticsEN.Score !=  null)
 {
 arrFieldListForInsert.Add(conzx_TotalDataStatistics.Score);
 arrValueListForInsert.Add(objzx_TotalDataStatisticsEN.Score.ToString());
 }
 
 if (objzx_TotalDataStatisticsEN.TeaScore !=  null)
 {
 arrFieldListForInsert.Add(conzx_TotalDataStatistics.TeaScore);
 arrValueListForInsert.Add(objzx_TotalDataStatisticsEN.TeaScore.ToString());
 }
 
 if (objzx_TotalDataStatisticsEN.WeekTimeRange !=  null)
 {
 arrFieldListForInsert.Add(conzx_TotalDataStatistics.WeekTimeRange);
 var strWeekTimeRange = objzx_TotalDataStatisticsEN.WeekTimeRange.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strWeekTimeRange + "'");
 }
 
 if (objzx_TotalDataStatisticsEN.StuScore !=  null)
 {
 arrFieldListForInsert.Add(conzx_TotalDataStatistics.StuScore);
 arrValueListForInsert.Add(objzx_TotalDataStatisticsEN.StuScore.ToString());
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into zx_TotalDataStatistics");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_TotalDataStatisticsDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool Addnewzx_TotalDataStatisticss(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_TotalDataStatisticsDA.GetSpecSQLObj();
strSQL = "Select * from zx_TotalDataStatistics where TotalDataId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "zx_TotalDataStatistics");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
string strTotalDataId = oRow[conzx_TotalDataStatistics.TotalDataId].ToString().Trim();
if (IsExist(strTotalDataId))
{
 string strResult = "关键字变量值为:" + string.Format("TotalDataId = {0}", strTotalDataId) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clszx_TotalDataStatisticsEN._CurrTabName ].NewRow();
objRow[conzx_TotalDataStatistics.TotalDataId] = oRow[conzx_TotalDataStatistics.TotalDataId].ToString().Trim(); //TotalDataId
objRow[conzx_TotalDataStatistics.IdCurrEduCls] = oRow[conzx_TotalDataStatistics.IdCurrEduCls].ToString().Trim(); //教学班流水号
objRow[conzx_TotalDataStatistics.zxTotalDataTypeId] = oRow[conzx_TotalDataStatistics.zxTotalDataTypeId].ToString().Trim(); //总数据类型Id
objRow[conzx_TotalDataStatistics.TableKey] = oRow[conzx_TotalDataStatistics.TableKey].ToString().Trim(); //表主键
objRow[conzx_TotalDataStatistics.DataUser] = oRow[conzx_TotalDataStatistics.DataUser].ToString().Trim(); //数据用户
objRow[conzx_TotalDataStatistics.DataAddDate] = oRow[conzx_TotalDataStatistics.DataAddDate].ToString().Trim(); //数据添加日期
objRow[conzx_TotalDataStatistics.Month] = oRow[conzx_TotalDataStatistics.Month].ToString().Trim(); //月
objRow[conzx_TotalDataStatistics.Week] = oRow[conzx_TotalDataStatistics.Week].ToString().Trim(); //周
objRow[conzx_TotalDataStatistics.UpdDate] = oRow[conzx_TotalDataStatistics.UpdDate].ToString().Trim(); //修改日期
objRow[conzx_TotalDataStatistics.UpdUser] = oRow[conzx_TotalDataStatistics.UpdUser].ToString().Trim(); //修改人
objRow[conzx_TotalDataStatistics.Memo] = oRow[conzx_TotalDataStatistics.Memo].ToString().Trim(); //备注
objRow[conzx_TotalDataStatistics.Score] = oRow[conzx_TotalDataStatistics.Score].ToString().Trim(); //评分
objRow[conzx_TotalDataStatistics.TeaScore] = oRow[conzx_TotalDataStatistics.TeaScore].ToString().Trim(); //教师评分
objRow[conzx_TotalDataStatistics.WeekTimeRange] = oRow[conzx_TotalDataStatistics.WeekTimeRange].ToString().Trim(); //WeekTimeRange
objRow[conzx_TotalDataStatistics.StuScore] = oRow[conzx_TotalDataStatistics.StuScore].ToString().Trim(); //学生平均分
 objDS.Tables[clszx_TotalDataStatisticsEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clszx_TotalDataStatisticsEN._CurrTabName);
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
 /// <param name = "objzx_TotalDataStatisticsEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clszx_TotalDataStatisticsEN objzx_TotalDataStatisticsEN)
{
 if (objzx_TotalDataStatisticsEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objzx_TotalDataStatisticsEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_TotalDataStatisticsDA.GetSpecSQLObj();
strSQL = "Select * from zx_TotalDataStatistics where TotalDataId = " + "'"+ objzx_TotalDataStatisticsEN.TotalDataId+"'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clszx_TotalDataStatisticsEN._CurrTabName);
if (objDS.Tables[clszx_TotalDataStatisticsEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:TotalDataId = " + "'"+ objzx_TotalDataStatisticsEN.TotalDataId+"'");
return false;
}
objRow = objDS.Tables[clszx_TotalDataStatisticsEN._CurrTabName].Rows[0];
 if (objzx_TotalDataStatisticsEN.IsUpdated(conzx_TotalDataStatistics.TotalDataId))
 {
objRow[conzx_TotalDataStatistics.TotalDataId] = objzx_TotalDataStatisticsEN.TotalDataId; //TotalDataId
 }
 if (objzx_TotalDataStatisticsEN.IsUpdated(conzx_TotalDataStatistics.IdCurrEduCls))
 {
objRow[conzx_TotalDataStatistics.IdCurrEduCls] = objzx_TotalDataStatisticsEN.IdCurrEduCls; //教学班流水号
 }
 if (objzx_TotalDataStatisticsEN.IsUpdated(conzx_TotalDataStatistics.zxTotalDataTypeId))
 {
objRow[conzx_TotalDataStatistics.zxTotalDataTypeId] = objzx_TotalDataStatisticsEN.zxTotalDataTypeId; //总数据类型Id
 }
 if (objzx_TotalDataStatisticsEN.IsUpdated(conzx_TotalDataStatistics.TableKey))
 {
objRow[conzx_TotalDataStatistics.TableKey] = objzx_TotalDataStatisticsEN.TableKey; //表主键
 }
 if (objzx_TotalDataStatisticsEN.IsUpdated(conzx_TotalDataStatistics.DataUser))
 {
objRow[conzx_TotalDataStatistics.DataUser] = objzx_TotalDataStatisticsEN.DataUser; //数据用户
 }
 if (objzx_TotalDataStatisticsEN.IsUpdated(conzx_TotalDataStatistics.DataAddDate))
 {
objRow[conzx_TotalDataStatistics.DataAddDate] = objzx_TotalDataStatisticsEN.DataAddDate; //数据添加日期
 }
 if (objzx_TotalDataStatisticsEN.IsUpdated(conzx_TotalDataStatistics.Month))
 {
objRow[conzx_TotalDataStatistics.Month] = objzx_TotalDataStatisticsEN.Month; //月
 }
 if (objzx_TotalDataStatisticsEN.IsUpdated(conzx_TotalDataStatistics.Week))
 {
objRow[conzx_TotalDataStatistics.Week] = objzx_TotalDataStatisticsEN.Week; //周
 }
 if (objzx_TotalDataStatisticsEN.IsUpdated(conzx_TotalDataStatistics.UpdDate))
 {
objRow[conzx_TotalDataStatistics.UpdDate] = objzx_TotalDataStatisticsEN.UpdDate; //修改日期
 }
 if (objzx_TotalDataStatisticsEN.IsUpdated(conzx_TotalDataStatistics.UpdUser))
 {
objRow[conzx_TotalDataStatistics.UpdUser] = objzx_TotalDataStatisticsEN.UpdUser; //修改人
 }
 if (objzx_TotalDataStatisticsEN.IsUpdated(conzx_TotalDataStatistics.Memo))
 {
objRow[conzx_TotalDataStatistics.Memo] = objzx_TotalDataStatisticsEN.Memo; //备注
 }
 if (objzx_TotalDataStatisticsEN.IsUpdated(conzx_TotalDataStatistics.Score))
 {
objRow[conzx_TotalDataStatistics.Score] = objzx_TotalDataStatisticsEN.Score; //评分
 }
 if (objzx_TotalDataStatisticsEN.IsUpdated(conzx_TotalDataStatistics.TeaScore))
 {
objRow[conzx_TotalDataStatistics.TeaScore] = objzx_TotalDataStatisticsEN.TeaScore; //教师评分
 }
 if (objzx_TotalDataStatisticsEN.IsUpdated(conzx_TotalDataStatistics.WeekTimeRange))
 {
objRow[conzx_TotalDataStatistics.WeekTimeRange] = objzx_TotalDataStatisticsEN.WeekTimeRange; //WeekTimeRange
 }
 if (objzx_TotalDataStatisticsEN.IsUpdated(conzx_TotalDataStatistics.StuScore))
 {
objRow[conzx_TotalDataStatistics.StuScore] = objzx_TotalDataStatisticsEN.StuScore; //学生平均分
 }
try
{
objDA.Update(objDS, clszx_TotalDataStatisticsEN._CurrTabName);
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
 /// <param name = "objzx_TotalDataStatisticsEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clszx_TotalDataStatisticsEN objzx_TotalDataStatisticsEN)
{
 if (objzx_TotalDataStatisticsEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objzx_TotalDataStatisticsEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_TotalDataStatisticsDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update zx_TotalDataStatistics Set ");
 
 if (objzx_TotalDataStatisticsEN.IsUpdated(conzx_TotalDataStatistics.IdCurrEduCls))
 {
 if (objzx_TotalDataStatisticsEN.IdCurrEduCls !=  null)
 {
 var strIdCurrEduCls = objzx_TotalDataStatisticsEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdCurrEduCls, conzx_TotalDataStatistics.IdCurrEduCls); //教学班流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_TotalDataStatistics.IdCurrEduCls); //教学班流水号
 }
 }
 
 if (objzx_TotalDataStatisticsEN.IsUpdated(conzx_TotalDataStatistics.zxTotalDataTypeId))
 {
 if (objzx_TotalDataStatisticsEN.zxTotalDataTypeId !=  null)
 {
 var strzxTotalDataTypeId = objzx_TotalDataStatisticsEN.zxTotalDataTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strzxTotalDataTypeId, conzx_TotalDataStatistics.zxTotalDataTypeId); //总数据类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_TotalDataStatistics.zxTotalDataTypeId); //总数据类型Id
 }
 }
 
 if (objzx_TotalDataStatisticsEN.IsUpdated(conzx_TotalDataStatistics.TableKey))
 {
 if (objzx_TotalDataStatisticsEN.TableKey !=  null)
 {
 var strTableKey = objzx_TotalDataStatisticsEN.TableKey.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTableKey, conzx_TotalDataStatistics.TableKey); //表主键
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_TotalDataStatistics.TableKey); //表主键
 }
 }
 
 if (objzx_TotalDataStatisticsEN.IsUpdated(conzx_TotalDataStatistics.DataUser))
 {
 if (objzx_TotalDataStatisticsEN.DataUser !=  null)
 {
 var strDataUser = objzx_TotalDataStatisticsEN.DataUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strDataUser, conzx_TotalDataStatistics.DataUser); //数据用户
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_TotalDataStatistics.DataUser); //数据用户
 }
 }
 
 if (objzx_TotalDataStatisticsEN.IsUpdated(conzx_TotalDataStatistics.DataAddDate))
 {
 if (objzx_TotalDataStatisticsEN.DataAddDate !=  null)
 {
 var strDataAddDate = objzx_TotalDataStatisticsEN.DataAddDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strDataAddDate, conzx_TotalDataStatistics.DataAddDate); //数据添加日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_TotalDataStatistics.DataAddDate); //数据添加日期
 }
 }
 
 if (objzx_TotalDataStatisticsEN.IsUpdated(conzx_TotalDataStatistics.Month))
 {
 if (objzx_TotalDataStatisticsEN.Month !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_TotalDataStatisticsEN.Month, conzx_TotalDataStatistics.Month); //月
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_TotalDataStatistics.Month); //月
 }
 }
 
 if (objzx_TotalDataStatisticsEN.IsUpdated(conzx_TotalDataStatistics.Week))
 {
 if (objzx_TotalDataStatisticsEN.Week !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_TotalDataStatisticsEN.Week, conzx_TotalDataStatistics.Week); //周
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_TotalDataStatistics.Week); //周
 }
 }
 
 if (objzx_TotalDataStatisticsEN.IsUpdated(conzx_TotalDataStatistics.UpdDate))
 {
 if (objzx_TotalDataStatisticsEN.UpdDate !=  null)
 {
 var strUpdDate = objzx_TotalDataStatisticsEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conzx_TotalDataStatistics.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_TotalDataStatistics.UpdDate); //修改日期
 }
 }
 
 if (objzx_TotalDataStatisticsEN.IsUpdated(conzx_TotalDataStatistics.UpdUser))
 {
 if (objzx_TotalDataStatisticsEN.UpdUser !=  null)
 {
 var strUpdUser = objzx_TotalDataStatisticsEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conzx_TotalDataStatistics.UpdUser); //修改人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_TotalDataStatistics.UpdUser); //修改人
 }
 }
 
 if (objzx_TotalDataStatisticsEN.IsUpdated(conzx_TotalDataStatistics.Memo))
 {
 if (objzx_TotalDataStatisticsEN.Memo !=  null)
 {
 var strMemo = objzx_TotalDataStatisticsEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conzx_TotalDataStatistics.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_TotalDataStatistics.Memo); //备注
 }
 }
 
 if (objzx_TotalDataStatisticsEN.IsUpdated(conzx_TotalDataStatistics.Score))
 {
 if (objzx_TotalDataStatisticsEN.Score !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_TotalDataStatisticsEN.Score, conzx_TotalDataStatistics.Score); //评分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_TotalDataStatistics.Score); //评分
 }
 }
 
 if (objzx_TotalDataStatisticsEN.IsUpdated(conzx_TotalDataStatistics.TeaScore))
 {
 if (objzx_TotalDataStatisticsEN.TeaScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_TotalDataStatisticsEN.TeaScore, conzx_TotalDataStatistics.TeaScore); //教师评分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_TotalDataStatistics.TeaScore); //教师评分
 }
 }
 
 if (objzx_TotalDataStatisticsEN.IsUpdated(conzx_TotalDataStatistics.WeekTimeRange))
 {
 if (objzx_TotalDataStatisticsEN.WeekTimeRange !=  null)
 {
 var strWeekTimeRange = objzx_TotalDataStatisticsEN.WeekTimeRange.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strWeekTimeRange, conzx_TotalDataStatistics.WeekTimeRange); //WeekTimeRange
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_TotalDataStatistics.WeekTimeRange); //WeekTimeRange
 }
 }
 
 if (objzx_TotalDataStatisticsEN.IsUpdated(conzx_TotalDataStatistics.StuScore))
 {
 if (objzx_TotalDataStatisticsEN.StuScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_TotalDataStatisticsEN.StuScore, conzx_TotalDataStatistics.StuScore); //学生平均分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_TotalDataStatistics.StuScore); //学生平均分
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where TotalDataId = '{0}'", objzx_TotalDataStatisticsEN.TotalDataId); 
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
 /// <param name = "objzx_TotalDataStatisticsEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clszx_TotalDataStatisticsEN objzx_TotalDataStatisticsEN, string strCondition)
{
 if (objzx_TotalDataStatisticsEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objzx_TotalDataStatisticsEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_TotalDataStatisticsDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update zx_TotalDataStatistics Set ");
 
 if (objzx_TotalDataStatisticsEN.IsUpdated(conzx_TotalDataStatistics.IdCurrEduCls))
 {
 if (objzx_TotalDataStatisticsEN.IdCurrEduCls !=  null)
 {
 var strIdCurrEduCls = objzx_TotalDataStatisticsEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdCurrEduCls = '{0}',", strIdCurrEduCls); //教学班流水号
 }
 else
 {
 sbSQL.Append(" IdCurrEduCls = null,"); //教学班流水号
 }
 }
 
 if (objzx_TotalDataStatisticsEN.IsUpdated(conzx_TotalDataStatistics.zxTotalDataTypeId))
 {
 if (objzx_TotalDataStatisticsEN.zxTotalDataTypeId !=  null)
 {
 var strzxTotalDataTypeId = objzx_TotalDataStatisticsEN.zxTotalDataTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" zxTotalDataTypeId = '{0}',", strzxTotalDataTypeId); //总数据类型Id
 }
 else
 {
 sbSQL.Append(" zxTotalDataTypeId = null,"); //总数据类型Id
 }
 }
 
 if (objzx_TotalDataStatisticsEN.IsUpdated(conzx_TotalDataStatistics.TableKey))
 {
 if (objzx_TotalDataStatisticsEN.TableKey !=  null)
 {
 var strTableKey = objzx_TotalDataStatisticsEN.TableKey.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TableKey = '{0}',", strTableKey); //表主键
 }
 else
 {
 sbSQL.Append(" TableKey = null,"); //表主键
 }
 }
 
 if (objzx_TotalDataStatisticsEN.IsUpdated(conzx_TotalDataStatistics.DataUser))
 {
 if (objzx_TotalDataStatisticsEN.DataUser !=  null)
 {
 var strDataUser = objzx_TotalDataStatisticsEN.DataUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DataUser = '{0}',", strDataUser); //数据用户
 }
 else
 {
 sbSQL.Append(" DataUser = null,"); //数据用户
 }
 }
 
 if (objzx_TotalDataStatisticsEN.IsUpdated(conzx_TotalDataStatistics.DataAddDate))
 {
 if (objzx_TotalDataStatisticsEN.DataAddDate !=  null)
 {
 var strDataAddDate = objzx_TotalDataStatisticsEN.DataAddDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DataAddDate = '{0}',", strDataAddDate); //数据添加日期
 }
 else
 {
 sbSQL.Append(" DataAddDate = null,"); //数据添加日期
 }
 }
 
 if (objzx_TotalDataStatisticsEN.IsUpdated(conzx_TotalDataStatistics.Month))
 {
 if (objzx_TotalDataStatisticsEN.Month !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_TotalDataStatisticsEN.Month, conzx_TotalDataStatistics.Month); //月
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_TotalDataStatistics.Month); //月
 }
 }
 
 if (objzx_TotalDataStatisticsEN.IsUpdated(conzx_TotalDataStatistics.Week))
 {
 if (objzx_TotalDataStatisticsEN.Week !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_TotalDataStatisticsEN.Week, conzx_TotalDataStatistics.Week); //周
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_TotalDataStatistics.Week); //周
 }
 }
 
 if (objzx_TotalDataStatisticsEN.IsUpdated(conzx_TotalDataStatistics.UpdDate))
 {
 if (objzx_TotalDataStatisticsEN.UpdDate !=  null)
 {
 var strUpdDate = objzx_TotalDataStatisticsEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objzx_TotalDataStatisticsEN.IsUpdated(conzx_TotalDataStatistics.UpdUser))
 {
 if (objzx_TotalDataStatisticsEN.UpdUser !=  null)
 {
 var strUpdUser = objzx_TotalDataStatisticsEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改人
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改人
 }
 }
 
 if (objzx_TotalDataStatisticsEN.IsUpdated(conzx_TotalDataStatistics.Memo))
 {
 if (objzx_TotalDataStatisticsEN.Memo !=  null)
 {
 var strMemo = objzx_TotalDataStatisticsEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Memo = '{0}',", strMemo); //备注
 }
 else
 {
 sbSQL.Append(" Memo = null,"); //备注
 }
 }
 
 if (objzx_TotalDataStatisticsEN.IsUpdated(conzx_TotalDataStatistics.Score))
 {
 if (objzx_TotalDataStatisticsEN.Score !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_TotalDataStatisticsEN.Score, conzx_TotalDataStatistics.Score); //评分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_TotalDataStatistics.Score); //评分
 }
 }
 
 if (objzx_TotalDataStatisticsEN.IsUpdated(conzx_TotalDataStatistics.TeaScore))
 {
 if (objzx_TotalDataStatisticsEN.TeaScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_TotalDataStatisticsEN.TeaScore, conzx_TotalDataStatistics.TeaScore); //教师评分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_TotalDataStatistics.TeaScore); //教师评分
 }
 }
 
 if (objzx_TotalDataStatisticsEN.IsUpdated(conzx_TotalDataStatistics.WeekTimeRange))
 {
 if (objzx_TotalDataStatisticsEN.WeekTimeRange !=  null)
 {
 var strWeekTimeRange = objzx_TotalDataStatisticsEN.WeekTimeRange.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" WeekTimeRange = '{0}',", strWeekTimeRange); //WeekTimeRange
 }
 else
 {
 sbSQL.Append(" WeekTimeRange = null,"); //WeekTimeRange
 }
 }
 
 if (objzx_TotalDataStatisticsEN.IsUpdated(conzx_TotalDataStatistics.StuScore))
 {
 if (objzx_TotalDataStatisticsEN.StuScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_TotalDataStatisticsEN.StuScore, conzx_TotalDataStatistics.StuScore); //学生平均分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_TotalDataStatistics.StuScore); //学生平均分
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
 /// <param name = "objzx_TotalDataStatisticsEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clszx_TotalDataStatisticsEN objzx_TotalDataStatisticsEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objzx_TotalDataStatisticsEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objzx_TotalDataStatisticsEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_TotalDataStatisticsDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update zx_TotalDataStatistics Set ");
 
 if (objzx_TotalDataStatisticsEN.IsUpdated(conzx_TotalDataStatistics.IdCurrEduCls))
 {
 if (objzx_TotalDataStatisticsEN.IdCurrEduCls !=  null)
 {
 var strIdCurrEduCls = objzx_TotalDataStatisticsEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdCurrEduCls = '{0}',", strIdCurrEduCls); //教学班流水号
 }
 else
 {
 sbSQL.Append(" IdCurrEduCls = null,"); //教学班流水号
 }
 }
 
 if (objzx_TotalDataStatisticsEN.IsUpdated(conzx_TotalDataStatistics.zxTotalDataTypeId))
 {
 if (objzx_TotalDataStatisticsEN.zxTotalDataTypeId !=  null)
 {
 var strzxTotalDataTypeId = objzx_TotalDataStatisticsEN.zxTotalDataTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" zxTotalDataTypeId = '{0}',", strzxTotalDataTypeId); //总数据类型Id
 }
 else
 {
 sbSQL.Append(" zxTotalDataTypeId = null,"); //总数据类型Id
 }
 }
 
 if (objzx_TotalDataStatisticsEN.IsUpdated(conzx_TotalDataStatistics.TableKey))
 {
 if (objzx_TotalDataStatisticsEN.TableKey !=  null)
 {
 var strTableKey = objzx_TotalDataStatisticsEN.TableKey.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TableKey = '{0}',", strTableKey); //表主键
 }
 else
 {
 sbSQL.Append(" TableKey = null,"); //表主键
 }
 }
 
 if (objzx_TotalDataStatisticsEN.IsUpdated(conzx_TotalDataStatistics.DataUser))
 {
 if (objzx_TotalDataStatisticsEN.DataUser !=  null)
 {
 var strDataUser = objzx_TotalDataStatisticsEN.DataUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DataUser = '{0}',", strDataUser); //数据用户
 }
 else
 {
 sbSQL.Append(" DataUser = null,"); //数据用户
 }
 }
 
 if (objzx_TotalDataStatisticsEN.IsUpdated(conzx_TotalDataStatistics.DataAddDate))
 {
 if (objzx_TotalDataStatisticsEN.DataAddDate !=  null)
 {
 var strDataAddDate = objzx_TotalDataStatisticsEN.DataAddDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DataAddDate = '{0}',", strDataAddDate); //数据添加日期
 }
 else
 {
 sbSQL.Append(" DataAddDate = null,"); //数据添加日期
 }
 }
 
 if (objzx_TotalDataStatisticsEN.IsUpdated(conzx_TotalDataStatistics.Month))
 {
 if (objzx_TotalDataStatisticsEN.Month !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_TotalDataStatisticsEN.Month, conzx_TotalDataStatistics.Month); //月
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_TotalDataStatistics.Month); //月
 }
 }
 
 if (objzx_TotalDataStatisticsEN.IsUpdated(conzx_TotalDataStatistics.Week))
 {
 if (objzx_TotalDataStatisticsEN.Week !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_TotalDataStatisticsEN.Week, conzx_TotalDataStatistics.Week); //周
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_TotalDataStatistics.Week); //周
 }
 }
 
 if (objzx_TotalDataStatisticsEN.IsUpdated(conzx_TotalDataStatistics.UpdDate))
 {
 if (objzx_TotalDataStatisticsEN.UpdDate !=  null)
 {
 var strUpdDate = objzx_TotalDataStatisticsEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objzx_TotalDataStatisticsEN.IsUpdated(conzx_TotalDataStatistics.UpdUser))
 {
 if (objzx_TotalDataStatisticsEN.UpdUser !=  null)
 {
 var strUpdUser = objzx_TotalDataStatisticsEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改人
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改人
 }
 }
 
 if (objzx_TotalDataStatisticsEN.IsUpdated(conzx_TotalDataStatistics.Memo))
 {
 if (objzx_TotalDataStatisticsEN.Memo !=  null)
 {
 var strMemo = objzx_TotalDataStatisticsEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Memo = '{0}',", strMemo); //备注
 }
 else
 {
 sbSQL.Append(" Memo = null,"); //备注
 }
 }
 
 if (objzx_TotalDataStatisticsEN.IsUpdated(conzx_TotalDataStatistics.Score))
 {
 if (objzx_TotalDataStatisticsEN.Score !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_TotalDataStatisticsEN.Score, conzx_TotalDataStatistics.Score); //评分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_TotalDataStatistics.Score); //评分
 }
 }
 
 if (objzx_TotalDataStatisticsEN.IsUpdated(conzx_TotalDataStatistics.TeaScore))
 {
 if (objzx_TotalDataStatisticsEN.TeaScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_TotalDataStatisticsEN.TeaScore, conzx_TotalDataStatistics.TeaScore); //教师评分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_TotalDataStatistics.TeaScore); //教师评分
 }
 }
 
 if (objzx_TotalDataStatisticsEN.IsUpdated(conzx_TotalDataStatistics.WeekTimeRange))
 {
 if (objzx_TotalDataStatisticsEN.WeekTimeRange !=  null)
 {
 var strWeekTimeRange = objzx_TotalDataStatisticsEN.WeekTimeRange.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" WeekTimeRange = '{0}',", strWeekTimeRange); //WeekTimeRange
 }
 else
 {
 sbSQL.Append(" WeekTimeRange = null,"); //WeekTimeRange
 }
 }
 
 if (objzx_TotalDataStatisticsEN.IsUpdated(conzx_TotalDataStatistics.StuScore))
 {
 if (objzx_TotalDataStatisticsEN.StuScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_TotalDataStatisticsEN.StuScore, conzx_TotalDataStatistics.StuScore); //学生平均分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_TotalDataStatistics.StuScore); //学生平均分
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
 /// <param name = "objzx_TotalDataStatisticsEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clszx_TotalDataStatisticsEN objzx_TotalDataStatisticsEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objzx_TotalDataStatisticsEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objzx_TotalDataStatisticsEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_TotalDataStatisticsDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update zx_TotalDataStatistics Set ");
 
 if (objzx_TotalDataStatisticsEN.IsUpdated(conzx_TotalDataStatistics.IdCurrEduCls))
 {
 if (objzx_TotalDataStatisticsEN.IdCurrEduCls !=  null)
 {
 var strIdCurrEduCls = objzx_TotalDataStatisticsEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdCurrEduCls, conzx_TotalDataStatistics.IdCurrEduCls); //教学班流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_TotalDataStatistics.IdCurrEduCls); //教学班流水号
 }
 }
 
 if (objzx_TotalDataStatisticsEN.IsUpdated(conzx_TotalDataStatistics.zxTotalDataTypeId))
 {
 if (objzx_TotalDataStatisticsEN.zxTotalDataTypeId !=  null)
 {
 var strzxTotalDataTypeId = objzx_TotalDataStatisticsEN.zxTotalDataTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strzxTotalDataTypeId, conzx_TotalDataStatistics.zxTotalDataTypeId); //总数据类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_TotalDataStatistics.zxTotalDataTypeId); //总数据类型Id
 }
 }
 
 if (objzx_TotalDataStatisticsEN.IsUpdated(conzx_TotalDataStatistics.TableKey))
 {
 if (objzx_TotalDataStatisticsEN.TableKey !=  null)
 {
 var strTableKey = objzx_TotalDataStatisticsEN.TableKey.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTableKey, conzx_TotalDataStatistics.TableKey); //表主键
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_TotalDataStatistics.TableKey); //表主键
 }
 }
 
 if (objzx_TotalDataStatisticsEN.IsUpdated(conzx_TotalDataStatistics.DataUser))
 {
 if (objzx_TotalDataStatisticsEN.DataUser !=  null)
 {
 var strDataUser = objzx_TotalDataStatisticsEN.DataUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strDataUser, conzx_TotalDataStatistics.DataUser); //数据用户
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_TotalDataStatistics.DataUser); //数据用户
 }
 }
 
 if (objzx_TotalDataStatisticsEN.IsUpdated(conzx_TotalDataStatistics.DataAddDate))
 {
 if (objzx_TotalDataStatisticsEN.DataAddDate !=  null)
 {
 var strDataAddDate = objzx_TotalDataStatisticsEN.DataAddDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strDataAddDate, conzx_TotalDataStatistics.DataAddDate); //数据添加日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_TotalDataStatistics.DataAddDate); //数据添加日期
 }
 }
 
 if (objzx_TotalDataStatisticsEN.IsUpdated(conzx_TotalDataStatistics.Month))
 {
 if (objzx_TotalDataStatisticsEN.Month !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_TotalDataStatisticsEN.Month, conzx_TotalDataStatistics.Month); //月
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_TotalDataStatistics.Month); //月
 }
 }
 
 if (objzx_TotalDataStatisticsEN.IsUpdated(conzx_TotalDataStatistics.Week))
 {
 if (objzx_TotalDataStatisticsEN.Week !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_TotalDataStatisticsEN.Week, conzx_TotalDataStatistics.Week); //周
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_TotalDataStatistics.Week); //周
 }
 }
 
 if (objzx_TotalDataStatisticsEN.IsUpdated(conzx_TotalDataStatistics.UpdDate))
 {
 if (objzx_TotalDataStatisticsEN.UpdDate !=  null)
 {
 var strUpdDate = objzx_TotalDataStatisticsEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conzx_TotalDataStatistics.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_TotalDataStatistics.UpdDate); //修改日期
 }
 }
 
 if (objzx_TotalDataStatisticsEN.IsUpdated(conzx_TotalDataStatistics.UpdUser))
 {
 if (objzx_TotalDataStatisticsEN.UpdUser !=  null)
 {
 var strUpdUser = objzx_TotalDataStatisticsEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conzx_TotalDataStatistics.UpdUser); //修改人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_TotalDataStatistics.UpdUser); //修改人
 }
 }
 
 if (objzx_TotalDataStatisticsEN.IsUpdated(conzx_TotalDataStatistics.Memo))
 {
 if (objzx_TotalDataStatisticsEN.Memo !=  null)
 {
 var strMemo = objzx_TotalDataStatisticsEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conzx_TotalDataStatistics.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_TotalDataStatistics.Memo); //备注
 }
 }
 
 if (objzx_TotalDataStatisticsEN.IsUpdated(conzx_TotalDataStatistics.Score))
 {
 if (objzx_TotalDataStatisticsEN.Score !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_TotalDataStatisticsEN.Score, conzx_TotalDataStatistics.Score); //评分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_TotalDataStatistics.Score); //评分
 }
 }
 
 if (objzx_TotalDataStatisticsEN.IsUpdated(conzx_TotalDataStatistics.TeaScore))
 {
 if (objzx_TotalDataStatisticsEN.TeaScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_TotalDataStatisticsEN.TeaScore, conzx_TotalDataStatistics.TeaScore); //教师评分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_TotalDataStatistics.TeaScore); //教师评分
 }
 }
 
 if (objzx_TotalDataStatisticsEN.IsUpdated(conzx_TotalDataStatistics.WeekTimeRange))
 {
 if (objzx_TotalDataStatisticsEN.WeekTimeRange !=  null)
 {
 var strWeekTimeRange = objzx_TotalDataStatisticsEN.WeekTimeRange.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strWeekTimeRange, conzx_TotalDataStatistics.WeekTimeRange); //WeekTimeRange
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_TotalDataStatistics.WeekTimeRange); //WeekTimeRange
 }
 }
 
 if (objzx_TotalDataStatisticsEN.IsUpdated(conzx_TotalDataStatistics.StuScore))
 {
 if (objzx_TotalDataStatisticsEN.StuScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_TotalDataStatisticsEN.StuScore, conzx_TotalDataStatistics.StuScore); //学生平均分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_TotalDataStatistics.StuScore); //学生平均分
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where TotalDataId = '{0}'", objzx_TotalDataStatisticsEN.TotalDataId); 
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
 /// <param name = "strTotalDataId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(string strTotalDataId) 
{
CheckPrimaryKey(strTotalDataId);
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_TotalDataStatisticsDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 strTotalDataId,
};
 objSQL.ExecSP("zx_TotalDataStatistics_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "strTotalDataId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(string strTotalDataId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
CheckPrimaryKey(strTotalDataId);
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_TotalDataStatisticsDA.GetSpecSQLObj();
//删除zx_TotalDataStatistics本表中与当前对象有关的记录
strSQL = strSQL + "Delete from zx_TotalDataStatistics where TotalDataId = " + "'"+ strTotalDataId+"'";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int Delzx_TotalDataStatistics(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_TotalDataStatisticsDA.GetSpecSQLObj();
string strSQL;
string strKeyList;
if (lstKey.Count  == 0) return 0;
strKeyList = "";
for (int i = 0; i<lstKey.Count; i++)
{
if (i == 0) strKeyList = strKeyList + "'" + lstKey[i].ToString() + "'";
else strKeyList +=  "," + "'" + lstKey[i].ToString() + "'";
}
strSQL = "";
//删除zx_TotalDataStatistics本表中与当前对象有关的记录
strSQL = strSQL + "Delete from zx_TotalDataStatistics where TotalDataId in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "strTotalDataId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(string strTotalDataId) 
{
CheckPrimaryKey(strTotalDataId);
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_TotalDataStatisticsDA.GetSpecSQLObj();
//删除zx_TotalDataStatistics本表中与当前对象有关的记录
strSQL = strSQL + "Delete from zx_TotalDataStatistics where TotalDataId = " + "'"+ strTotalDataId+"'";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int Delzx_TotalDataStatistics(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clszx_TotalDataStatisticsDA: Delzx_TotalDataStatistics)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_TotalDataStatisticsDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from zx_TotalDataStatistics where " + strCondition ;
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
public bool Delzx_TotalDataStatisticsWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clszx_TotalDataStatisticsDA: Delzx_TotalDataStatisticsWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_TotalDataStatisticsDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from zx_TotalDataStatistics where " + strCondition ;
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
 /// <param name = "objzx_TotalDataStatisticsENS">源对象</param>
 /// <param name = "objzx_TotalDataStatisticsENT">目标对象</param>
public void CopyTo(clszx_TotalDataStatisticsEN objzx_TotalDataStatisticsENS, clszx_TotalDataStatisticsEN objzx_TotalDataStatisticsENT)
{
objzx_TotalDataStatisticsENT.TotalDataId = objzx_TotalDataStatisticsENS.TotalDataId; //TotalDataId
objzx_TotalDataStatisticsENT.IdCurrEduCls = objzx_TotalDataStatisticsENS.IdCurrEduCls; //教学班流水号
objzx_TotalDataStatisticsENT.zxTotalDataTypeId = objzx_TotalDataStatisticsENS.zxTotalDataTypeId; //总数据类型Id
objzx_TotalDataStatisticsENT.TableKey = objzx_TotalDataStatisticsENS.TableKey; //表主键
objzx_TotalDataStatisticsENT.DataUser = objzx_TotalDataStatisticsENS.DataUser; //数据用户
objzx_TotalDataStatisticsENT.DataAddDate = objzx_TotalDataStatisticsENS.DataAddDate; //数据添加日期
objzx_TotalDataStatisticsENT.Month = objzx_TotalDataStatisticsENS.Month; //月
objzx_TotalDataStatisticsENT.Week = objzx_TotalDataStatisticsENS.Week; //周
objzx_TotalDataStatisticsENT.UpdDate = objzx_TotalDataStatisticsENS.UpdDate; //修改日期
objzx_TotalDataStatisticsENT.UpdUser = objzx_TotalDataStatisticsENS.UpdUser; //修改人
objzx_TotalDataStatisticsENT.Memo = objzx_TotalDataStatisticsENS.Memo; //备注
objzx_TotalDataStatisticsENT.Score = objzx_TotalDataStatisticsENS.Score; //评分
objzx_TotalDataStatisticsENT.TeaScore = objzx_TotalDataStatisticsENS.TeaScore; //教师评分
objzx_TotalDataStatisticsENT.WeekTimeRange = objzx_TotalDataStatisticsENS.WeekTimeRange; //WeekTimeRange
objzx_TotalDataStatisticsENT.StuScore = objzx_TotalDataStatisticsENS.StuScore; //学生平均分
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clszx_TotalDataStatisticsEN objzx_TotalDataStatisticsEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objzx_TotalDataStatisticsEN.IdCurrEduCls, conzx_TotalDataStatistics.IdCurrEduCls);
clsCheckSql.CheckFieldNotNull(objzx_TotalDataStatisticsEN.zxTotalDataTypeId, conzx_TotalDataStatistics.zxTotalDataTypeId);
//检查字段长度
clsCheckSql.CheckFieldLen(objzx_TotalDataStatisticsEN.TotalDataId, 12, conzx_TotalDataStatistics.TotalDataId);
clsCheckSql.CheckFieldLen(objzx_TotalDataStatisticsEN.IdCurrEduCls, 8, conzx_TotalDataStatistics.IdCurrEduCls);
clsCheckSql.CheckFieldLen(objzx_TotalDataStatisticsEN.zxTotalDataTypeId, 2, conzx_TotalDataStatistics.zxTotalDataTypeId);
clsCheckSql.CheckFieldLen(objzx_TotalDataStatisticsEN.TableKey, 20, conzx_TotalDataStatistics.TableKey);
clsCheckSql.CheckFieldLen(objzx_TotalDataStatisticsEN.DataUser, 20, conzx_TotalDataStatistics.DataUser);
clsCheckSql.CheckFieldLen(objzx_TotalDataStatisticsEN.DataAddDate, 20, conzx_TotalDataStatistics.DataAddDate);
clsCheckSql.CheckFieldLen(objzx_TotalDataStatisticsEN.UpdDate, 20, conzx_TotalDataStatistics.UpdDate);
clsCheckSql.CheckFieldLen(objzx_TotalDataStatisticsEN.UpdUser, 20, conzx_TotalDataStatistics.UpdUser);
clsCheckSql.CheckFieldLen(objzx_TotalDataStatisticsEN.Memo, 1000, conzx_TotalDataStatistics.Memo);
clsCheckSql.CheckFieldLen(objzx_TotalDataStatisticsEN.WeekTimeRange, 100, conzx_TotalDataStatistics.WeekTimeRange);
//检查字段外键固定长度
 objzx_TotalDataStatisticsEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clszx_TotalDataStatisticsEN objzx_TotalDataStatisticsEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objzx_TotalDataStatisticsEN.IdCurrEduCls, 8, conzx_TotalDataStatistics.IdCurrEduCls);
clsCheckSql.CheckFieldLen(objzx_TotalDataStatisticsEN.zxTotalDataTypeId, 2, conzx_TotalDataStatistics.zxTotalDataTypeId);
clsCheckSql.CheckFieldLen(objzx_TotalDataStatisticsEN.TableKey, 20, conzx_TotalDataStatistics.TableKey);
clsCheckSql.CheckFieldLen(objzx_TotalDataStatisticsEN.DataUser, 20, conzx_TotalDataStatistics.DataUser);
clsCheckSql.CheckFieldLen(objzx_TotalDataStatisticsEN.DataAddDate, 20, conzx_TotalDataStatistics.DataAddDate);
clsCheckSql.CheckFieldLen(objzx_TotalDataStatisticsEN.UpdDate, 20, conzx_TotalDataStatistics.UpdDate);
clsCheckSql.CheckFieldLen(objzx_TotalDataStatisticsEN.UpdUser, 20, conzx_TotalDataStatistics.UpdUser);
clsCheckSql.CheckFieldLen(objzx_TotalDataStatisticsEN.Memo, 1000, conzx_TotalDataStatistics.Memo);
clsCheckSql.CheckFieldLen(objzx_TotalDataStatisticsEN.WeekTimeRange, 100, conzx_TotalDataStatistics.WeekTimeRange);
//检查外键字段长度
 objzx_TotalDataStatisticsEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clszx_TotalDataStatisticsEN objzx_TotalDataStatisticsEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objzx_TotalDataStatisticsEN.TotalDataId, 12, conzx_TotalDataStatistics.TotalDataId);
clsCheckSql.CheckFieldLen(objzx_TotalDataStatisticsEN.IdCurrEduCls, 8, conzx_TotalDataStatistics.IdCurrEduCls);
clsCheckSql.CheckFieldLen(objzx_TotalDataStatisticsEN.zxTotalDataTypeId, 2, conzx_TotalDataStatistics.zxTotalDataTypeId);
clsCheckSql.CheckFieldLen(objzx_TotalDataStatisticsEN.TableKey, 20, conzx_TotalDataStatistics.TableKey);
clsCheckSql.CheckFieldLen(objzx_TotalDataStatisticsEN.DataUser, 20, conzx_TotalDataStatistics.DataUser);
clsCheckSql.CheckFieldLen(objzx_TotalDataStatisticsEN.DataAddDate, 20, conzx_TotalDataStatistics.DataAddDate);
clsCheckSql.CheckFieldLen(objzx_TotalDataStatisticsEN.UpdDate, 20, conzx_TotalDataStatistics.UpdDate);
clsCheckSql.CheckFieldLen(objzx_TotalDataStatisticsEN.UpdUser, 20, conzx_TotalDataStatistics.UpdUser);
clsCheckSql.CheckFieldLen(objzx_TotalDataStatisticsEN.Memo, 1000, conzx_TotalDataStatistics.Memo);
clsCheckSql.CheckFieldLen(objzx_TotalDataStatisticsEN.WeekTimeRange, 100, conzx_TotalDataStatistics.WeekTimeRange);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objzx_TotalDataStatisticsEN.TotalDataId, conzx_TotalDataStatistics.TotalDataId);
clsCheckSql.CheckSqlInjection4Field(objzx_TotalDataStatisticsEN.IdCurrEduCls, conzx_TotalDataStatistics.IdCurrEduCls);
clsCheckSql.CheckSqlInjection4Field(objzx_TotalDataStatisticsEN.zxTotalDataTypeId, conzx_TotalDataStatistics.zxTotalDataTypeId);
clsCheckSql.CheckSqlInjection4Field(objzx_TotalDataStatisticsEN.TableKey, conzx_TotalDataStatistics.TableKey);
clsCheckSql.CheckSqlInjection4Field(objzx_TotalDataStatisticsEN.DataUser, conzx_TotalDataStatistics.DataUser);
clsCheckSql.CheckSqlInjection4Field(objzx_TotalDataStatisticsEN.DataAddDate, conzx_TotalDataStatistics.DataAddDate);
clsCheckSql.CheckSqlInjection4Field(objzx_TotalDataStatisticsEN.UpdDate, conzx_TotalDataStatistics.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objzx_TotalDataStatisticsEN.UpdUser, conzx_TotalDataStatistics.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objzx_TotalDataStatisticsEN.Memo, conzx_TotalDataStatistics.Memo);
clsCheckSql.CheckSqlInjection4Field(objzx_TotalDataStatisticsEN.WeekTimeRange, conzx_TotalDataStatistics.WeekTimeRange);
//检查外键字段长度
 objzx_TotalDataStatisticsEN._IsCheckProperty = true;
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
 objSQL = clszx_TotalDataStatisticsDA.GetSpecSQLObj();
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
 objSQL = clszx_TotalDataStatisticsDA.GetSpecSQLObj();
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
 objSQL = clszx_TotalDataStatisticsDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clszx_TotalDataStatisticsEN._CurrTabName);
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
 objSQL = clszx_TotalDataStatisticsDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clszx_TotalDataStatisticsEN._CurrTabName, strCondition);
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
 objSQL = clszx_TotalDataStatisticsDA.GetSpecSQLObj();
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
 objSQL = clszx_TotalDataStatisticsDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}