
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvzx_TotalDataStatisticsDA
 表名:vzx_TotalDataStatistics(01120841)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 12:14:27
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
 /// vzx_TotalDataStatistics(vzx_TotalDataStatistics)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvzx_TotalDataStatisticsDA : clsCommBase4DA
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
 return clsvzx_TotalDataStatisticsEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvzx_TotalDataStatisticsEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvzx_TotalDataStatisticsEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvzx_TotalDataStatisticsEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvzx_TotalDataStatisticsEN._ConnectString);
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
throw new Exception("(errid:Data000001)在表:vzx_TotalDataStatistics中,检查关键字,长度不正确!(clsvzx_TotalDataStatisticsDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strTotalDataId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:vzx_TotalDataStatistics中,关键字不能为空 或 null!(clsvzx_TotalDataStatisticsDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strTotalDataId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsvzx_TotalDataStatisticsDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvzx_TotalDataStatisticsDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_TotalDataStatisticsDA.GetSpecSQLObj();
strSQL = "Select * from vzx_TotalDataStatistics where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vzx_TotalDataStatistics(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvzx_TotalDataStatisticsDA: GetDataTable_vzx_TotalDataStatistics)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_TotalDataStatisticsDA.GetSpecSQLObj();
strSQL = "Select * from vzx_TotalDataStatistics where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvzx_TotalDataStatisticsDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_TotalDataStatisticsDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvzx_TotalDataStatisticsDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_TotalDataStatisticsDA.GetSpecSQLObj();
strSQL = "Select * from vzx_TotalDataStatistics where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvzx_TotalDataStatisticsDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_TotalDataStatisticsDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvzx_TotalDataStatisticsDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_TotalDataStatisticsDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vzx_TotalDataStatistics where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vzx_TotalDataStatistics where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvzx_TotalDataStatisticsDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_TotalDataStatisticsDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vzx_TotalDataStatistics where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvzx_TotalDataStatisticsDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_TotalDataStatisticsDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vzx_TotalDataStatistics.* from vzx_TotalDataStatistics Left Join {1} on {2} where {3} and vzx_TotalDataStatistics.TotalDataId not in (Select top {5} vzx_TotalDataStatistics.TotalDataId from vzx_TotalDataStatistics Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vzx_TotalDataStatistics where {1} and TotalDataId not in (Select top {2} TotalDataId from vzx_TotalDataStatistics where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vzx_TotalDataStatistics where {1} and TotalDataId not in (Select top {3} TotalDataId from vzx_TotalDataStatistics where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvzx_TotalDataStatisticsDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_TotalDataStatisticsDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vzx_TotalDataStatistics.* from vzx_TotalDataStatistics Left Join {1} on {2} where {3} and vzx_TotalDataStatistics.TotalDataId not in (Select top {5} vzx_TotalDataStatistics.TotalDataId from vzx_TotalDataStatistics Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vzx_TotalDataStatistics where {1} and TotalDataId not in (Select top {2} TotalDataId from vzx_TotalDataStatistics where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vzx_TotalDataStatistics where {1} and TotalDataId not in (Select top {3} TotalDataId from vzx_TotalDataStatistics where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvzx_TotalDataStatisticsEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvzx_TotalDataStatisticsDA:GetObjLst)", objException.Message));
}
List<clsvzx_TotalDataStatisticsEN> arrObjLst = new List<clsvzx_TotalDataStatisticsEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_TotalDataStatisticsDA.GetSpecSQLObj();
strSQL = "Select * from vzx_TotalDataStatistics where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_TotalDataStatisticsEN objvzx_TotalDataStatisticsEN = new clsvzx_TotalDataStatisticsEN();
try
{
objvzx_TotalDataStatisticsEN.EduClsName = objRow[convzx_TotalDataStatistics.EduClsName] == DBNull.Value ? null : objRow[convzx_TotalDataStatistics.EduClsName].ToString().Trim(); //教学班名
objvzx_TotalDataStatisticsEN.TotalDataId = objRow[convzx_TotalDataStatistics.TotalDataId].ToString().Trim(); //TotalDataId
objvzx_TotalDataStatisticsEN.IdCurrEduCls = objRow[convzx_TotalDataStatistics.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_TotalDataStatisticsEN.zxTotalDataTypeId = objRow[convzx_TotalDataStatistics.zxTotalDataTypeId].ToString().Trim(); //总数据类型Id
objvzx_TotalDataStatisticsEN.TableKey = objRow[convzx_TotalDataStatistics.TableKey] == DBNull.Value ? null : objRow[convzx_TotalDataStatistics.TableKey].ToString().Trim(); //表主键
objvzx_TotalDataStatisticsEN.DataUser = objRow[convzx_TotalDataStatistics.DataUser] == DBNull.Value ? null : objRow[convzx_TotalDataStatistics.DataUser].ToString().Trim(); //数据用户
objvzx_TotalDataStatisticsEN.DataAddDate = objRow[convzx_TotalDataStatistics.DataAddDate] == DBNull.Value ? null : objRow[convzx_TotalDataStatistics.DataAddDate].ToString().Trim(); //数据添加日期
objvzx_TotalDataStatisticsEN.Month = objRow[convzx_TotalDataStatistics.Month] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_TotalDataStatistics.Month].ToString().Trim()); //月
objvzx_TotalDataStatisticsEN.Week = objRow[convzx_TotalDataStatistics.Week] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_TotalDataStatistics.Week].ToString().Trim()); //周
objvzx_TotalDataStatisticsEN.UpdDate = objRow[convzx_TotalDataStatistics.UpdDate] == DBNull.Value ? null : objRow[convzx_TotalDataStatistics.UpdDate].ToString().Trim(); //修改日期
objvzx_TotalDataStatisticsEN.UpdUser = objRow[convzx_TotalDataStatistics.UpdUser] == DBNull.Value ? null : objRow[convzx_TotalDataStatistics.UpdUser].ToString().Trim(); //修改人
objvzx_TotalDataStatisticsEN.Memo = objRow[convzx_TotalDataStatistics.Memo] == DBNull.Value ? null : objRow[convzx_TotalDataStatistics.Memo].ToString().Trim(); //备注
objvzx_TotalDataStatisticsEN.Score = objRow[convzx_TotalDataStatistics.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convzx_TotalDataStatistics.Score].ToString().Trim()); //评分
objvzx_TotalDataStatisticsEN.TeaScore = objRow[convzx_TotalDataStatistics.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convzx_TotalDataStatistics.TeaScore].ToString().Trim()); //教师评分
objvzx_TotalDataStatisticsEN.WeekTimeRange = objRow[convzx_TotalDataStatistics.WeekTimeRange] == DBNull.Value ? null : objRow[convzx_TotalDataStatistics.WeekTimeRange].ToString().Trim(); //WeekTimeRange
objvzx_TotalDataStatisticsEN.StuScore = objRow[convzx_TotalDataStatistics.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convzx_TotalDataStatistics.StuScore].ToString().Trim()); //学生平均分
objvzx_TotalDataStatisticsEN.OnlyId = objRow[convzx_TotalDataStatistics.OnlyId] == DBNull.Value ? null : objRow[convzx_TotalDataStatistics.OnlyId].ToString().Trim(); //OnlyId
objvzx_TotalDataStatisticsEN.DataTableId = objRow[convzx_TotalDataStatistics.DataTableId] == DBNull.Value ? null : objRow[convzx_TotalDataStatistics.DataTableId].ToString().Trim(); //数据表Id
objvzx_TotalDataStatisticsEN.DataTable = objRow[convzx_TotalDataStatistics.DataTable] == DBNull.Value ? null : objRow[convzx_TotalDataStatistics.DataTable].ToString().Trim(); //数据表
objvzx_TotalDataStatisticsEN.TotalDataTypeName = objRow[convzx_TotalDataStatistics.TotalDataTypeName] == DBNull.Value ? null : objRow[convzx_TotalDataStatistics.TotalDataTypeName].ToString().Trim(); //总数据类型名称
objvzx_TotalDataStatisticsEN.SchoolTerm = objRow[convzx_TotalDataStatistics.SchoolTerm] == DBNull.Value ? null : objRow[convzx_TotalDataStatistics.SchoolTerm].ToString().Trim(); //学期
objvzx_TotalDataStatisticsEN.SchoolYear = objRow[convzx_TotalDataStatistics.SchoolYear] == DBNull.Value ? null : objRow[convzx_TotalDataStatistics.SchoolYear].ToString().Trim(); //学年
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvzx_TotalDataStatisticsDA: GetObjLst)", objException.Message));
}
objvzx_TotalDataStatisticsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvzx_TotalDataStatisticsEN);
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
public List<clsvzx_TotalDataStatisticsEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvzx_TotalDataStatisticsDA:GetObjLstByTabName)", objException.Message));
}
List<clsvzx_TotalDataStatisticsEN> arrObjLst = new List<clsvzx_TotalDataStatisticsEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_TotalDataStatisticsDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_TotalDataStatisticsEN objvzx_TotalDataStatisticsEN = new clsvzx_TotalDataStatisticsEN();
try
{
objvzx_TotalDataStatisticsEN.EduClsName = objRow[convzx_TotalDataStatistics.EduClsName] == DBNull.Value ? null : objRow[convzx_TotalDataStatistics.EduClsName].ToString().Trim(); //教学班名
objvzx_TotalDataStatisticsEN.TotalDataId = objRow[convzx_TotalDataStatistics.TotalDataId].ToString().Trim(); //TotalDataId
objvzx_TotalDataStatisticsEN.IdCurrEduCls = objRow[convzx_TotalDataStatistics.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_TotalDataStatisticsEN.zxTotalDataTypeId = objRow[convzx_TotalDataStatistics.zxTotalDataTypeId].ToString().Trim(); //总数据类型Id
objvzx_TotalDataStatisticsEN.TableKey = objRow[convzx_TotalDataStatistics.TableKey] == DBNull.Value ? null : objRow[convzx_TotalDataStatistics.TableKey].ToString().Trim(); //表主键
objvzx_TotalDataStatisticsEN.DataUser = objRow[convzx_TotalDataStatistics.DataUser] == DBNull.Value ? null : objRow[convzx_TotalDataStatistics.DataUser].ToString().Trim(); //数据用户
objvzx_TotalDataStatisticsEN.DataAddDate = objRow[convzx_TotalDataStatistics.DataAddDate] == DBNull.Value ? null : objRow[convzx_TotalDataStatistics.DataAddDate].ToString().Trim(); //数据添加日期
objvzx_TotalDataStatisticsEN.Month = objRow[convzx_TotalDataStatistics.Month] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_TotalDataStatistics.Month].ToString().Trim()); //月
objvzx_TotalDataStatisticsEN.Week = objRow[convzx_TotalDataStatistics.Week] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_TotalDataStatistics.Week].ToString().Trim()); //周
objvzx_TotalDataStatisticsEN.UpdDate = objRow[convzx_TotalDataStatistics.UpdDate] == DBNull.Value ? null : objRow[convzx_TotalDataStatistics.UpdDate].ToString().Trim(); //修改日期
objvzx_TotalDataStatisticsEN.UpdUser = objRow[convzx_TotalDataStatistics.UpdUser] == DBNull.Value ? null : objRow[convzx_TotalDataStatistics.UpdUser].ToString().Trim(); //修改人
objvzx_TotalDataStatisticsEN.Memo = objRow[convzx_TotalDataStatistics.Memo] == DBNull.Value ? null : objRow[convzx_TotalDataStatistics.Memo].ToString().Trim(); //备注
objvzx_TotalDataStatisticsEN.Score = objRow[convzx_TotalDataStatistics.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convzx_TotalDataStatistics.Score].ToString().Trim()); //评分
objvzx_TotalDataStatisticsEN.TeaScore = objRow[convzx_TotalDataStatistics.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convzx_TotalDataStatistics.TeaScore].ToString().Trim()); //教师评分
objvzx_TotalDataStatisticsEN.WeekTimeRange = objRow[convzx_TotalDataStatistics.WeekTimeRange] == DBNull.Value ? null : objRow[convzx_TotalDataStatistics.WeekTimeRange].ToString().Trim(); //WeekTimeRange
objvzx_TotalDataStatisticsEN.StuScore = objRow[convzx_TotalDataStatistics.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convzx_TotalDataStatistics.StuScore].ToString().Trim()); //学生平均分
objvzx_TotalDataStatisticsEN.OnlyId = objRow[convzx_TotalDataStatistics.OnlyId] == DBNull.Value ? null : objRow[convzx_TotalDataStatistics.OnlyId].ToString().Trim(); //OnlyId
objvzx_TotalDataStatisticsEN.DataTableId = objRow[convzx_TotalDataStatistics.DataTableId] == DBNull.Value ? null : objRow[convzx_TotalDataStatistics.DataTableId].ToString().Trim(); //数据表Id
objvzx_TotalDataStatisticsEN.DataTable = objRow[convzx_TotalDataStatistics.DataTable] == DBNull.Value ? null : objRow[convzx_TotalDataStatistics.DataTable].ToString().Trim(); //数据表
objvzx_TotalDataStatisticsEN.TotalDataTypeName = objRow[convzx_TotalDataStatistics.TotalDataTypeName] == DBNull.Value ? null : objRow[convzx_TotalDataStatistics.TotalDataTypeName].ToString().Trim(); //总数据类型名称
objvzx_TotalDataStatisticsEN.SchoolTerm = objRow[convzx_TotalDataStatistics.SchoolTerm] == DBNull.Value ? null : objRow[convzx_TotalDataStatistics.SchoolTerm].ToString().Trim(); //学期
objvzx_TotalDataStatisticsEN.SchoolYear = objRow[convzx_TotalDataStatistics.SchoolYear] == DBNull.Value ? null : objRow[convzx_TotalDataStatistics.SchoolYear].ToString().Trim(); //学年
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvzx_TotalDataStatisticsDA: GetObjLst)", objException.Message));
}
objvzx_TotalDataStatisticsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvzx_TotalDataStatisticsEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvzx_TotalDataStatisticsEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool Getvzx_TotalDataStatistics(ref clsvzx_TotalDataStatisticsEN objvzx_TotalDataStatisticsEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_TotalDataStatisticsDA.GetSpecSQLObj();
strSQL = "Select * from vzx_TotalDataStatistics where TotalDataId = " + "'"+ objvzx_TotalDataStatisticsEN.TotalDataId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvzx_TotalDataStatisticsEN.EduClsName = objDT.Rows[0][convzx_TotalDataStatistics.EduClsName].ToString().Trim(); //教学班名(字段类型:varchar,字段长度:100,是否可空:False)
 objvzx_TotalDataStatisticsEN.TotalDataId = objDT.Rows[0][convzx_TotalDataStatistics.TotalDataId].ToString().Trim(); //TotalDataId(字段类型:char,字段长度:12,是否可空:False)
 objvzx_TotalDataStatisticsEN.IdCurrEduCls = objDT.Rows[0][convzx_TotalDataStatistics.IdCurrEduCls].ToString().Trim(); //教学班流水号(字段类型:char,字段长度:8,是否可空:False)
 objvzx_TotalDataStatisticsEN.zxTotalDataTypeId = objDT.Rows[0][convzx_TotalDataStatistics.zxTotalDataTypeId].ToString().Trim(); //总数据类型Id(字段类型:char,字段长度:2,是否可空:False)
 objvzx_TotalDataStatisticsEN.TableKey = objDT.Rows[0][convzx_TotalDataStatistics.TableKey].ToString().Trim(); //表主键(字段类型:varchar,字段长度:20,是否可空:True)
 objvzx_TotalDataStatisticsEN.DataUser = objDT.Rows[0][convzx_TotalDataStatistics.DataUser].ToString().Trim(); //数据用户(字段类型:varchar,字段长度:20,是否可空:True)
 objvzx_TotalDataStatisticsEN.DataAddDate = objDT.Rows[0][convzx_TotalDataStatistics.DataAddDate].ToString().Trim(); //数据添加日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvzx_TotalDataStatisticsEN.Month = TransNullToInt(objDT.Rows[0][convzx_TotalDataStatistics.Month].ToString().Trim()); //月(字段类型:int,字段长度:4,是否可空:True)
 objvzx_TotalDataStatisticsEN.Week = TransNullToInt(objDT.Rows[0][convzx_TotalDataStatistics.Week].ToString().Trim()); //周(字段类型:int,字段长度:4,是否可空:True)
 objvzx_TotalDataStatisticsEN.UpdDate = objDT.Rows[0][convzx_TotalDataStatistics.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvzx_TotalDataStatisticsEN.UpdUser = objDT.Rows[0][convzx_TotalDataStatistics.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objvzx_TotalDataStatisticsEN.Memo = objDT.Rows[0][convzx_TotalDataStatistics.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvzx_TotalDataStatisticsEN.Score = TransNullToFloat(objDT.Rows[0][convzx_TotalDataStatistics.Score].ToString().Trim()); //评分(字段类型:float,字段长度:8,是否可空:True)
 objvzx_TotalDataStatisticsEN.TeaScore = TransNullToFloat(objDT.Rows[0][convzx_TotalDataStatistics.TeaScore].ToString().Trim()); //教师评分(字段类型:float,字段长度:8,是否可空:True)
 objvzx_TotalDataStatisticsEN.WeekTimeRange = objDT.Rows[0][convzx_TotalDataStatistics.WeekTimeRange].ToString().Trim(); //WeekTimeRange(字段类型:varchar,字段长度:100,是否可空:True)
 objvzx_TotalDataStatisticsEN.StuScore = TransNullToFloat(objDT.Rows[0][convzx_TotalDataStatistics.StuScore].ToString().Trim()); //学生平均分(字段类型:float,字段长度:8,是否可空:True)
 objvzx_TotalDataStatisticsEN.OnlyId = objDT.Rows[0][convzx_TotalDataStatistics.OnlyId].ToString().Trim(); //OnlyId(字段类型:varchar,字段长度:20,是否可空:True)
 objvzx_TotalDataStatisticsEN.DataTableId = objDT.Rows[0][convzx_TotalDataStatistics.DataTableId].ToString().Trim(); //数据表Id(字段类型:varchar,字段长度:50,是否可空:True)
 objvzx_TotalDataStatisticsEN.DataTable = objDT.Rows[0][convzx_TotalDataStatistics.DataTable].ToString().Trim(); //数据表(字段类型:varchar,字段长度:100,是否可空:True)
 objvzx_TotalDataStatisticsEN.TotalDataTypeName = objDT.Rows[0][convzx_TotalDataStatistics.TotalDataTypeName].ToString().Trim(); //总数据类型名称(字段类型:varchar,字段长度:500,是否可空:True)
 objvzx_TotalDataStatisticsEN.SchoolTerm = objDT.Rows[0][convzx_TotalDataStatistics.SchoolTerm].ToString().Trim(); //学期(字段类型:char,字段长度:1,是否可空:True)
 objvzx_TotalDataStatisticsEN.SchoolYear = objDT.Rows[0][convzx_TotalDataStatistics.SchoolYear].ToString().Trim(); //学年(字段类型:varchar,字段长度:10,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvzx_TotalDataStatisticsDA: Getvzx_TotalDataStatistics)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strTotalDataId">表关键字</param>
 /// <returns>表对象</returns>
public clsvzx_TotalDataStatisticsEN GetObjByTotalDataId(string strTotalDataId)
{
CheckPrimaryKey(strTotalDataId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_TotalDataStatisticsDA.GetSpecSQLObj();
strSQL = "Select * from vzx_TotalDataStatistics where TotalDataId = " + "'"+ strTotalDataId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvzx_TotalDataStatisticsEN objvzx_TotalDataStatisticsEN = new clsvzx_TotalDataStatisticsEN();
try
{
 objvzx_TotalDataStatisticsEN.EduClsName = objRow[convzx_TotalDataStatistics.EduClsName] == DBNull.Value ? null : objRow[convzx_TotalDataStatistics.EduClsName].ToString().Trim(); //教学班名(字段类型:varchar,字段长度:100,是否可空:False)
 objvzx_TotalDataStatisticsEN.TotalDataId = objRow[convzx_TotalDataStatistics.TotalDataId].ToString().Trim(); //TotalDataId(字段类型:char,字段长度:12,是否可空:False)
 objvzx_TotalDataStatisticsEN.IdCurrEduCls = objRow[convzx_TotalDataStatistics.IdCurrEduCls].ToString().Trim(); //教学班流水号(字段类型:char,字段长度:8,是否可空:False)
 objvzx_TotalDataStatisticsEN.zxTotalDataTypeId = objRow[convzx_TotalDataStatistics.zxTotalDataTypeId].ToString().Trim(); //总数据类型Id(字段类型:char,字段长度:2,是否可空:False)
 objvzx_TotalDataStatisticsEN.TableKey = objRow[convzx_TotalDataStatistics.TableKey] == DBNull.Value ? null : objRow[convzx_TotalDataStatistics.TableKey].ToString().Trim(); //表主键(字段类型:varchar,字段长度:20,是否可空:True)
 objvzx_TotalDataStatisticsEN.DataUser = objRow[convzx_TotalDataStatistics.DataUser] == DBNull.Value ? null : objRow[convzx_TotalDataStatistics.DataUser].ToString().Trim(); //数据用户(字段类型:varchar,字段长度:20,是否可空:True)
 objvzx_TotalDataStatisticsEN.DataAddDate = objRow[convzx_TotalDataStatistics.DataAddDate] == DBNull.Value ? null : objRow[convzx_TotalDataStatistics.DataAddDate].ToString().Trim(); //数据添加日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvzx_TotalDataStatisticsEN.Month = objRow[convzx_TotalDataStatistics.Month] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_TotalDataStatistics.Month].ToString().Trim()); //月(字段类型:int,字段长度:4,是否可空:True)
 objvzx_TotalDataStatisticsEN.Week = objRow[convzx_TotalDataStatistics.Week] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_TotalDataStatistics.Week].ToString().Trim()); //周(字段类型:int,字段长度:4,是否可空:True)
 objvzx_TotalDataStatisticsEN.UpdDate = objRow[convzx_TotalDataStatistics.UpdDate] == DBNull.Value ? null : objRow[convzx_TotalDataStatistics.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvzx_TotalDataStatisticsEN.UpdUser = objRow[convzx_TotalDataStatistics.UpdUser] == DBNull.Value ? null : objRow[convzx_TotalDataStatistics.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objvzx_TotalDataStatisticsEN.Memo = objRow[convzx_TotalDataStatistics.Memo] == DBNull.Value ? null : objRow[convzx_TotalDataStatistics.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvzx_TotalDataStatisticsEN.Score = objRow[convzx_TotalDataStatistics.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_TotalDataStatistics.Score].ToString().Trim()); //评分(字段类型:float,字段长度:8,是否可空:True)
 objvzx_TotalDataStatisticsEN.TeaScore = objRow[convzx_TotalDataStatistics.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_TotalDataStatistics.TeaScore].ToString().Trim()); //教师评分(字段类型:float,字段长度:8,是否可空:True)
 objvzx_TotalDataStatisticsEN.WeekTimeRange = objRow[convzx_TotalDataStatistics.WeekTimeRange] == DBNull.Value ? null : objRow[convzx_TotalDataStatistics.WeekTimeRange].ToString().Trim(); //WeekTimeRange(字段类型:varchar,字段长度:100,是否可空:True)
 objvzx_TotalDataStatisticsEN.StuScore = objRow[convzx_TotalDataStatistics.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_TotalDataStatistics.StuScore].ToString().Trim()); //学生平均分(字段类型:float,字段长度:8,是否可空:True)
 objvzx_TotalDataStatisticsEN.OnlyId = objRow[convzx_TotalDataStatistics.OnlyId] == DBNull.Value ? null : objRow[convzx_TotalDataStatistics.OnlyId].ToString().Trim(); //OnlyId(字段类型:varchar,字段长度:20,是否可空:True)
 objvzx_TotalDataStatisticsEN.DataTableId = objRow[convzx_TotalDataStatistics.DataTableId] == DBNull.Value ? null : objRow[convzx_TotalDataStatistics.DataTableId].ToString().Trim(); //数据表Id(字段类型:varchar,字段长度:50,是否可空:True)
 objvzx_TotalDataStatisticsEN.DataTable = objRow[convzx_TotalDataStatistics.DataTable] == DBNull.Value ? null : objRow[convzx_TotalDataStatistics.DataTable].ToString().Trim(); //数据表(字段类型:varchar,字段长度:100,是否可空:True)
 objvzx_TotalDataStatisticsEN.TotalDataTypeName = objRow[convzx_TotalDataStatistics.TotalDataTypeName] == DBNull.Value ? null : objRow[convzx_TotalDataStatistics.TotalDataTypeName].ToString().Trim(); //总数据类型名称(字段类型:varchar,字段长度:500,是否可空:True)
 objvzx_TotalDataStatisticsEN.SchoolTerm = objRow[convzx_TotalDataStatistics.SchoolTerm] == DBNull.Value ? null : objRow[convzx_TotalDataStatistics.SchoolTerm].ToString().Trim(); //学期(字段类型:char,字段长度:1,是否可空:True)
 objvzx_TotalDataStatisticsEN.SchoolYear = objRow[convzx_TotalDataStatistics.SchoolYear] == DBNull.Value ? null : objRow[convzx_TotalDataStatistics.SchoolYear].ToString().Trim(); //学年(字段类型:varchar,字段长度:10,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvzx_TotalDataStatisticsDA: GetObjByTotalDataId)", objException.Message));
}
return objvzx_TotalDataStatisticsEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvzx_TotalDataStatisticsEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvzx_TotalDataStatisticsDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_TotalDataStatisticsDA.GetSpecSQLObj();
strSQL = "Select * from vzx_TotalDataStatistics where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvzx_TotalDataStatisticsEN objvzx_TotalDataStatisticsEN = new clsvzx_TotalDataStatisticsEN()
{
EduClsName = objRow[convzx_TotalDataStatistics.EduClsName] == DBNull.Value ? null : objRow[convzx_TotalDataStatistics.EduClsName].ToString().Trim(), //教学班名
TotalDataId = objRow[convzx_TotalDataStatistics.TotalDataId].ToString().Trim(), //TotalDataId
IdCurrEduCls = objRow[convzx_TotalDataStatistics.IdCurrEduCls].ToString().Trim(), //教学班流水号
zxTotalDataTypeId = objRow[convzx_TotalDataStatistics.zxTotalDataTypeId].ToString().Trim(), //总数据类型Id
TableKey = objRow[convzx_TotalDataStatistics.TableKey] == DBNull.Value ? null : objRow[convzx_TotalDataStatistics.TableKey].ToString().Trim(), //表主键
DataUser = objRow[convzx_TotalDataStatistics.DataUser] == DBNull.Value ? null : objRow[convzx_TotalDataStatistics.DataUser].ToString().Trim(), //数据用户
DataAddDate = objRow[convzx_TotalDataStatistics.DataAddDate] == DBNull.Value ? null : objRow[convzx_TotalDataStatistics.DataAddDate].ToString().Trim(), //数据添加日期
Month = objRow[convzx_TotalDataStatistics.Month] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_TotalDataStatistics.Month].ToString().Trim()), //月
Week = objRow[convzx_TotalDataStatistics.Week] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_TotalDataStatistics.Week].ToString().Trim()), //周
UpdDate = objRow[convzx_TotalDataStatistics.UpdDate] == DBNull.Value ? null : objRow[convzx_TotalDataStatistics.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[convzx_TotalDataStatistics.UpdUser] == DBNull.Value ? null : objRow[convzx_TotalDataStatistics.UpdUser].ToString().Trim(), //修改人
Memo = objRow[convzx_TotalDataStatistics.Memo] == DBNull.Value ? null : objRow[convzx_TotalDataStatistics.Memo].ToString().Trim(), //备注
Score = objRow[convzx_TotalDataStatistics.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convzx_TotalDataStatistics.Score].ToString().Trim()), //评分
TeaScore = objRow[convzx_TotalDataStatistics.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convzx_TotalDataStatistics.TeaScore].ToString().Trim()), //教师评分
WeekTimeRange = objRow[convzx_TotalDataStatistics.WeekTimeRange] == DBNull.Value ? null : objRow[convzx_TotalDataStatistics.WeekTimeRange].ToString().Trim(), //WeekTimeRange
StuScore = objRow[convzx_TotalDataStatistics.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convzx_TotalDataStatistics.StuScore].ToString().Trim()), //学生平均分
OnlyId = objRow[convzx_TotalDataStatistics.OnlyId] == DBNull.Value ? null : objRow[convzx_TotalDataStatistics.OnlyId].ToString().Trim(), //OnlyId
DataTableId = objRow[convzx_TotalDataStatistics.DataTableId] == DBNull.Value ? null : objRow[convzx_TotalDataStatistics.DataTableId].ToString().Trim(), //数据表Id
DataTable = objRow[convzx_TotalDataStatistics.DataTable] == DBNull.Value ? null : objRow[convzx_TotalDataStatistics.DataTable].ToString().Trim(), //数据表
TotalDataTypeName = objRow[convzx_TotalDataStatistics.TotalDataTypeName] == DBNull.Value ? null : objRow[convzx_TotalDataStatistics.TotalDataTypeName].ToString().Trim(), //总数据类型名称
SchoolTerm = objRow[convzx_TotalDataStatistics.SchoolTerm] == DBNull.Value ? null : objRow[convzx_TotalDataStatistics.SchoolTerm].ToString().Trim(), //学期
SchoolYear = objRow[convzx_TotalDataStatistics.SchoolYear] == DBNull.Value ? null : objRow[convzx_TotalDataStatistics.SchoolYear].ToString().Trim() //学年
};
objvzx_TotalDataStatisticsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvzx_TotalDataStatisticsEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvzx_TotalDataStatisticsDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvzx_TotalDataStatisticsEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvzx_TotalDataStatisticsEN objvzx_TotalDataStatisticsEN = new clsvzx_TotalDataStatisticsEN();
try
{
objvzx_TotalDataStatisticsEN.EduClsName = objRow[convzx_TotalDataStatistics.EduClsName] == DBNull.Value ? null : objRow[convzx_TotalDataStatistics.EduClsName].ToString().Trim(); //教学班名
objvzx_TotalDataStatisticsEN.TotalDataId = objRow[convzx_TotalDataStatistics.TotalDataId].ToString().Trim(); //TotalDataId
objvzx_TotalDataStatisticsEN.IdCurrEduCls = objRow[convzx_TotalDataStatistics.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_TotalDataStatisticsEN.zxTotalDataTypeId = objRow[convzx_TotalDataStatistics.zxTotalDataTypeId].ToString().Trim(); //总数据类型Id
objvzx_TotalDataStatisticsEN.TableKey = objRow[convzx_TotalDataStatistics.TableKey] == DBNull.Value ? null : objRow[convzx_TotalDataStatistics.TableKey].ToString().Trim(); //表主键
objvzx_TotalDataStatisticsEN.DataUser = objRow[convzx_TotalDataStatistics.DataUser] == DBNull.Value ? null : objRow[convzx_TotalDataStatistics.DataUser].ToString().Trim(); //数据用户
objvzx_TotalDataStatisticsEN.DataAddDate = objRow[convzx_TotalDataStatistics.DataAddDate] == DBNull.Value ? null : objRow[convzx_TotalDataStatistics.DataAddDate].ToString().Trim(); //数据添加日期
objvzx_TotalDataStatisticsEN.Month = objRow[convzx_TotalDataStatistics.Month] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_TotalDataStatistics.Month].ToString().Trim()); //月
objvzx_TotalDataStatisticsEN.Week = objRow[convzx_TotalDataStatistics.Week] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_TotalDataStatistics.Week].ToString().Trim()); //周
objvzx_TotalDataStatisticsEN.UpdDate = objRow[convzx_TotalDataStatistics.UpdDate] == DBNull.Value ? null : objRow[convzx_TotalDataStatistics.UpdDate].ToString().Trim(); //修改日期
objvzx_TotalDataStatisticsEN.UpdUser = objRow[convzx_TotalDataStatistics.UpdUser] == DBNull.Value ? null : objRow[convzx_TotalDataStatistics.UpdUser].ToString().Trim(); //修改人
objvzx_TotalDataStatisticsEN.Memo = objRow[convzx_TotalDataStatistics.Memo] == DBNull.Value ? null : objRow[convzx_TotalDataStatistics.Memo].ToString().Trim(); //备注
objvzx_TotalDataStatisticsEN.Score = objRow[convzx_TotalDataStatistics.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convzx_TotalDataStatistics.Score].ToString().Trim()); //评分
objvzx_TotalDataStatisticsEN.TeaScore = objRow[convzx_TotalDataStatistics.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convzx_TotalDataStatistics.TeaScore].ToString().Trim()); //教师评分
objvzx_TotalDataStatisticsEN.WeekTimeRange = objRow[convzx_TotalDataStatistics.WeekTimeRange] == DBNull.Value ? null : objRow[convzx_TotalDataStatistics.WeekTimeRange].ToString().Trim(); //WeekTimeRange
objvzx_TotalDataStatisticsEN.StuScore = objRow[convzx_TotalDataStatistics.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convzx_TotalDataStatistics.StuScore].ToString().Trim()); //学生平均分
objvzx_TotalDataStatisticsEN.OnlyId = objRow[convzx_TotalDataStatistics.OnlyId] == DBNull.Value ? null : objRow[convzx_TotalDataStatistics.OnlyId].ToString().Trim(); //OnlyId
objvzx_TotalDataStatisticsEN.DataTableId = objRow[convzx_TotalDataStatistics.DataTableId] == DBNull.Value ? null : objRow[convzx_TotalDataStatistics.DataTableId].ToString().Trim(); //数据表Id
objvzx_TotalDataStatisticsEN.DataTable = objRow[convzx_TotalDataStatistics.DataTable] == DBNull.Value ? null : objRow[convzx_TotalDataStatistics.DataTable].ToString().Trim(); //数据表
objvzx_TotalDataStatisticsEN.TotalDataTypeName = objRow[convzx_TotalDataStatistics.TotalDataTypeName] == DBNull.Value ? null : objRow[convzx_TotalDataStatistics.TotalDataTypeName].ToString().Trim(); //总数据类型名称
objvzx_TotalDataStatisticsEN.SchoolTerm = objRow[convzx_TotalDataStatistics.SchoolTerm] == DBNull.Value ? null : objRow[convzx_TotalDataStatistics.SchoolTerm].ToString().Trim(); //学期
objvzx_TotalDataStatisticsEN.SchoolYear = objRow[convzx_TotalDataStatistics.SchoolYear] == DBNull.Value ? null : objRow[convzx_TotalDataStatistics.SchoolYear].ToString().Trim(); //学年
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvzx_TotalDataStatisticsDA: GetObjByDataRowvzx_TotalDataStatistics)", objException.Message));
}
objvzx_TotalDataStatisticsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvzx_TotalDataStatisticsEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvzx_TotalDataStatisticsEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvzx_TotalDataStatisticsEN objvzx_TotalDataStatisticsEN = new clsvzx_TotalDataStatisticsEN();
try
{
objvzx_TotalDataStatisticsEN.EduClsName = objRow[convzx_TotalDataStatistics.EduClsName] == DBNull.Value ? null : objRow[convzx_TotalDataStatistics.EduClsName].ToString().Trim(); //教学班名
objvzx_TotalDataStatisticsEN.TotalDataId = objRow[convzx_TotalDataStatistics.TotalDataId].ToString().Trim(); //TotalDataId
objvzx_TotalDataStatisticsEN.IdCurrEduCls = objRow[convzx_TotalDataStatistics.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_TotalDataStatisticsEN.zxTotalDataTypeId = objRow[convzx_TotalDataStatistics.zxTotalDataTypeId].ToString().Trim(); //总数据类型Id
objvzx_TotalDataStatisticsEN.TableKey = objRow[convzx_TotalDataStatistics.TableKey] == DBNull.Value ? null : objRow[convzx_TotalDataStatistics.TableKey].ToString().Trim(); //表主键
objvzx_TotalDataStatisticsEN.DataUser = objRow[convzx_TotalDataStatistics.DataUser] == DBNull.Value ? null : objRow[convzx_TotalDataStatistics.DataUser].ToString().Trim(); //数据用户
objvzx_TotalDataStatisticsEN.DataAddDate = objRow[convzx_TotalDataStatistics.DataAddDate] == DBNull.Value ? null : objRow[convzx_TotalDataStatistics.DataAddDate].ToString().Trim(); //数据添加日期
objvzx_TotalDataStatisticsEN.Month = objRow[convzx_TotalDataStatistics.Month] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_TotalDataStatistics.Month].ToString().Trim()); //月
objvzx_TotalDataStatisticsEN.Week = objRow[convzx_TotalDataStatistics.Week] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_TotalDataStatistics.Week].ToString().Trim()); //周
objvzx_TotalDataStatisticsEN.UpdDate = objRow[convzx_TotalDataStatistics.UpdDate] == DBNull.Value ? null : objRow[convzx_TotalDataStatistics.UpdDate].ToString().Trim(); //修改日期
objvzx_TotalDataStatisticsEN.UpdUser = objRow[convzx_TotalDataStatistics.UpdUser] == DBNull.Value ? null : objRow[convzx_TotalDataStatistics.UpdUser].ToString().Trim(); //修改人
objvzx_TotalDataStatisticsEN.Memo = objRow[convzx_TotalDataStatistics.Memo] == DBNull.Value ? null : objRow[convzx_TotalDataStatistics.Memo].ToString().Trim(); //备注
objvzx_TotalDataStatisticsEN.Score = objRow[convzx_TotalDataStatistics.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convzx_TotalDataStatistics.Score].ToString().Trim()); //评分
objvzx_TotalDataStatisticsEN.TeaScore = objRow[convzx_TotalDataStatistics.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convzx_TotalDataStatistics.TeaScore].ToString().Trim()); //教师评分
objvzx_TotalDataStatisticsEN.WeekTimeRange = objRow[convzx_TotalDataStatistics.WeekTimeRange] == DBNull.Value ? null : objRow[convzx_TotalDataStatistics.WeekTimeRange].ToString().Trim(); //WeekTimeRange
objvzx_TotalDataStatisticsEN.StuScore = objRow[convzx_TotalDataStatistics.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convzx_TotalDataStatistics.StuScore].ToString().Trim()); //学生平均分
objvzx_TotalDataStatisticsEN.OnlyId = objRow[convzx_TotalDataStatistics.OnlyId] == DBNull.Value ? null : objRow[convzx_TotalDataStatistics.OnlyId].ToString().Trim(); //OnlyId
objvzx_TotalDataStatisticsEN.DataTableId = objRow[convzx_TotalDataStatistics.DataTableId] == DBNull.Value ? null : objRow[convzx_TotalDataStatistics.DataTableId].ToString().Trim(); //数据表Id
objvzx_TotalDataStatisticsEN.DataTable = objRow[convzx_TotalDataStatistics.DataTable] == DBNull.Value ? null : objRow[convzx_TotalDataStatistics.DataTable].ToString().Trim(); //数据表
objvzx_TotalDataStatisticsEN.TotalDataTypeName = objRow[convzx_TotalDataStatistics.TotalDataTypeName] == DBNull.Value ? null : objRow[convzx_TotalDataStatistics.TotalDataTypeName].ToString().Trim(); //总数据类型名称
objvzx_TotalDataStatisticsEN.SchoolTerm = objRow[convzx_TotalDataStatistics.SchoolTerm] == DBNull.Value ? null : objRow[convzx_TotalDataStatistics.SchoolTerm].ToString().Trim(); //学期
objvzx_TotalDataStatisticsEN.SchoolYear = objRow[convzx_TotalDataStatistics.SchoolYear] == DBNull.Value ? null : objRow[convzx_TotalDataStatistics.SchoolYear].ToString().Trim(); //学年
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvzx_TotalDataStatisticsDA: GetObjByDataRow)", objException.Message));
}
objvzx_TotalDataStatisticsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvzx_TotalDataStatisticsEN;
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
objSQL = clsvzx_TotalDataStatisticsDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvzx_TotalDataStatisticsEN._CurrTabName, convzx_TotalDataStatistics.TotalDataId, 12, "");
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
objSQL = clsvzx_TotalDataStatisticsDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvzx_TotalDataStatisticsEN._CurrTabName, convzx_TotalDataStatistics.TotalDataId, 12, strPrefix);
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
 objSQL = clsvzx_TotalDataStatisticsDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select TotalDataId from vzx_TotalDataStatistics where " + strCondition;
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
 objSQL = clsvzx_TotalDataStatisticsDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select TotalDataId from vzx_TotalDataStatistics where " + strCondition;
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
 objSQL = clsvzx_TotalDataStatisticsDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vzx_TotalDataStatistics", "TotalDataId = " + "'"+ strTotalDataId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvzx_TotalDataStatisticsDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_TotalDataStatisticsDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vzx_TotalDataStatistics", strCondition))
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
objSQL = clsvzx_TotalDataStatisticsDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vzx_TotalDataStatistics");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvzx_TotalDataStatisticsENS">源对象</param>
 /// <param name = "objvzx_TotalDataStatisticsENT">目标对象</param>
public void CopyTo(clsvzx_TotalDataStatisticsEN objvzx_TotalDataStatisticsENS, clsvzx_TotalDataStatisticsEN objvzx_TotalDataStatisticsENT)
{
objvzx_TotalDataStatisticsENT.EduClsName = objvzx_TotalDataStatisticsENS.EduClsName; //教学班名
objvzx_TotalDataStatisticsENT.TotalDataId = objvzx_TotalDataStatisticsENS.TotalDataId; //TotalDataId
objvzx_TotalDataStatisticsENT.IdCurrEduCls = objvzx_TotalDataStatisticsENS.IdCurrEduCls; //教学班流水号
objvzx_TotalDataStatisticsENT.zxTotalDataTypeId = objvzx_TotalDataStatisticsENS.zxTotalDataTypeId; //总数据类型Id
objvzx_TotalDataStatisticsENT.TableKey = objvzx_TotalDataStatisticsENS.TableKey; //表主键
objvzx_TotalDataStatisticsENT.DataUser = objvzx_TotalDataStatisticsENS.DataUser; //数据用户
objvzx_TotalDataStatisticsENT.DataAddDate = objvzx_TotalDataStatisticsENS.DataAddDate; //数据添加日期
objvzx_TotalDataStatisticsENT.Month = objvzx_TotalDataStatisticsENS.Month; //月
objvzx_TotalDataStatisticsENT.Week = objvzx_TotalDataStatisticsENS.Week; //周
objvzx_TotalDataStatisticsENT.UpdDate = objvzx_TotalDataStatisticsENS.UpdDate; //修改日期
objvzx_TotalDataStatisticsENT.UpdUser = objvzx_TotalDataStatisticsENS.UpdUser; //修改人
objvzx_TotalDataStatisticsENT.Memo = objvzx_TotalDataStatisticsENS.Memo; //备注
objvzx_TotalDataStatisticsENT.Score = objvzx_TotalDataStatisticsENS.Score; //评分
objvzx_TotalDataStatisticsENT.TeaScore = objvzx_TotalDataStatisticsENS.TeaScore; //教师评分
objvzx_TotalDataStatisticsENT.WeekTimeRange = objvzx_TotalDataStatisticsENS.WeekTimeRange; //WeekTimeRange
objvzx_TotalDataStatisticsENT.StuScore = objvzx_TotalDataStatisticsENS.StuScore; //学生平均分
objvzx_TotalDataStatisticsENT.OnlyId = objvzx_TotalDataStatisticsENS.OnlyId; //OnlyId
objvzx_TotalDataStatisticsENT.DataTableId = objvzx_TotalDataStatisticsENS.DataTableId; //数据表Id
objvzx_TotalDataStatisticsENT.DataTable = objvzx_TotalDataStatisticsENS.DataTable; //数据表
objvzx_TotalDataStatisticsENT.TotalDataTypeName = objvzx_TotalDataStatisticsENS.TotalDataTypeName; //总数据类型名称
objvzx_TotalDataStatisticsENT.SchoolTerm = objvzx_TotalDataStatisticsENS.SchoolTerm; //学期
objvzx_TotalDataStatisticsENT.SchoolYear = objvzx_TotalDataStatisticsENS.SchoolYear; //学年
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvzx_TotalDataStatisticsEN objvzx_TotalDataStatisticsEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvzx_TotalDataStatisticsEN.EduClsName, 100, convzx_TotalDataStatistics.EduClsName);
clsCheckSql.CheckFieldLen(objvzx_TotalDataStatisticsEN.TotalDataId, 12, convzx_TotalDataStatistics.TotalDataId);
clsCheckSql.CheckFieldLen(objvzx_TotalDataStatisticsEN.IdCurrEduCls, 8, convzx_TotalDataStatistics.IdCurrEduCls);
clsCheckSql.CheckFieldLen(objvzx_TotalDataStatisticsEN.zxTotalDataTypeId, 2, convzx_TotalDataStatistics.zxTotalDataTypeId);
clsCheckSql.CheckFieldLen(objvzx_TotalDataStatisticsEN.TableKey, 20, convzx_TotalDataStatistics.TableKey);
clsCheckSql.CheckFieldLen(objvzx_TotalDataStatisticsEN.DataUser, 20, convzx_TotalDataStatistics.DataUser);
clsCheckSql.CheckFieldLen(objvzx_TotalDataStatisticsEN.DataAddDate, 20, convzx_TotalDataStatistics.DataAddDate);
clsCheckSql.CheckFieldLen(objvzx_TotalDataStatisticsEN.UpdDate, 20, convzx_TotalDataStatistics.UpdDate);
clsCheckSql.CheckFieldLen(objvzx_TotalDataStatisticsEN.UpdUser, 20, convzx_TotalDataStatistics.UpdUser);
clsCheckSql.CheckFieldLen(objvzx_TotalDataStatisticsEN.Memo, 1000, convzx_TotalDataStatistics.Memo);
clsCheckSql.CheckFieldLen(objvzx_TotalDataStatisticsEN.WeekTimeRange, 100, convzx_TotalDataStatistics.WeekTimeRange);
clsCheckSql.CheckFieldLen(objvzx_TotalDataStatisticsEN.OnlyId, 20, convzx_TotalDataStatistics.OnlyId);
clsCheckSql.CheckFieldLen(objvzx_TotalDataStatisticsEN.DataTableId, 50, convzx_TotalDataStatistics.DataTableId);
clsCheckSql.CheckFieldLen(objvzx_TotalDataStatisticsEN.DataTable, 100, convzx_TotalDataStatistics.DataTable);
clsCheckSql.CheckFieldLen(objvzx_TotalDataStatisticsEN.TotalDataTypeName, 500, convzx_TotalDataStatistics.TotalDataTypeName);
clsCheckSql.CheckFieldLen(objvzx_TotalDataStatisticsEN.SchoolTerm, 1, convzx_TotalDataStatistics.SchoolTerm);
clsCheckSql.CheckFieldLen(objvzx_TotalDataStatisticsEN.SchoolYear, 10, convzx_TotalDataStatistics.SchoolYear);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvzx_TotalDataStatisticsEN.EduClsName, convzx_TotalDataStatistics.EduClsName);
clsCheckSql.CheckSqlInjection4Field(objvzx_TotalDataStatisticsEN.TotalDataId, convzx_TotalDataStatistics.TotalDataId);
clsCheckSql.CheckSqlInjection4Field(objvzx_TotalDataStatisticsEN.IdCurrEduCls, convzx_TotalDataStatistics.IdCurrEduCls);
clsCheckSql.CheckSqlInjection4Field(objvzx_TotalDataStatisticsEN.zxTotalDataTypeId, convzx_TotalDataStatistics.zxTotalDataTypeId);
clsCheckSql.CheckSqlInjection4Field(objvzx_TotalDataStatisticsEN.TableKey, convzx_TotalDataStatistics.TableKey);
clsCheckSql.CheckSqlInjection4Field(objvzx_TotalDataStatisticsEN.DataUser, convzx_TotalDataStatistics.DataUser);
clsCheckSql.CheckSqlInjection4Field(objvzx_TotalDataStatisticsEN.DataAddDate, convzx_TotalDataStatistics.DataAddDate);
clsCheckSql.CheckSqlInjection4Field(objvzx_TotalDataStatisticsEN.UpdDate, convzx_TotalDataStatistics.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objvzx_TotalDataStatisticsEN.UpdUser, convzx_TotalDataStatistics.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objvzx_TotalDataStatisticsEN.Memo, convzx_TotalDataStatistics.Memo);
clsCheckSql.CheckSqlInjection4Field(objvzx_TotalDataStatisticsEN.WeekTimeRange, convzx_TotalDataStatistics.WeekTimeRange);
clsCheckSql.CheckSqlInjection4Field(objvzx_TotalDataStatisticsEN.OnlyId, convzx_TotalDataStatistics.OnlyId);
clsCheckSql.CheckSqlInjection4Field(objvzx_TotalDataStatisticsEN.DataTableId, convzx_TotalDataStatistics.DataTableId);
clsCheckSql.CheckSqlInjection4Field(objvzx_TotalDataStatisticsEN.DataTable, convzx_TotalDataStatistics.DataTable);
clsCheckSql.CheckSqlInjection4Field(objvzx_TotalDataStatisticsEN.TotalDataTypeName, convzx_TotalDataStatistics.TotalDataTypeName);
clsCheckSql.CheckSqlInjection4Field(objvzx_TotalDataStatisticsEN.SchoolTerm, convzx_TotalDataStatistics.SchoolTerm);
clsCheckSql.CheckSqlInjection4Field(objvzx_TotalDataStatisticsEN.SchoolYear, convzx_TotalDataStatistics.SchoolYear);
//检查外键字段长度
 objvzx_TotalDataStatisticsEN._IsCheckProperty = true;
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
 objSQL = clsvzx_TotalDataStatisticsDA.GetSpecSQLObj();
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
 objSQL = clsvzx_TotalDataStatisticsDA.GetSpecSQLObj();
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
 objSQL = clsvzx_TotalDataStatisticsDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvzx_TotalDataStatisticsEN._CurrTabName);
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
 objSQL = clsvzx_TotalDataStatisticsDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvzx_TotalDataStatisticsEN._CurrTabName, strCondition);
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
 objSQL = clsvzx_TotalDataStatisticsDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}