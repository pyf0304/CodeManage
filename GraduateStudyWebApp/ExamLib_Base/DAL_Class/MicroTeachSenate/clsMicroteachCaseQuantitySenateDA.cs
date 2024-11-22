
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsMicroteachCaseQuantitySenateDA
 表名:MicroteachCaseQuantitySenate(01120443)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:16:48
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
 /// 微格教学教师量化评价(MicroteachCaseQuantitySenate)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsMicroteachCaseQuantitySenateDA : clsCommBase4DA
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
 return clsMicroteachCaseQuantitySenateEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsMicroteachCaseQuantitySenateEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsMicroteachCaseQuantitySenateEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsMicroteachCaseQuantitySenateEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsMicroteachCaseQuantitySenateEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsMicroteachCaseQuantitySenateDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsMicroteachCaseQuantitySenateDA.GetSpecSQLObj();
strSQL = "Select * from MicroteachCaseQuantitySenate where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_MicroteachCaseQuantitySenate(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsMicroteachCaseQuantitySenateDA: GetDataTable_MicroteachCaseQuantitySenate)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsMicroteachCaseQuantitySenateDA.GetSpecSQLObj();
strSQL = "Select * from MicroteachCaseQuantitySenate where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsMicroteachCaseQuantitySenateDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsMicroteachCaseQuantitySenateDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsMicroteachCaseQuantitySenateDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsMicroteachCaseQuantitySenateDA.GetSpecSQLObj();
strSQL = "Select * from MicroteachCaseQuantitySenate where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsMicroteachCaseQuantitySenateDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsMicroteachCaseQuantitySenateDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsMicroteachCaseQuantitySenateDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsMicroteachCaseQuantitySenateDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from MicroteachCaseQuantitySenate where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from MicroteachCaseQuantitySenate where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsMicroteachCaseQuantitySenateDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsMicroteachCaseQuantitySenateDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from MicroteachCaseQuantitySenate where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsMicroteachCaseQuantitySenateDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsMicroteachCaseQuantitySenateDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} MicroteachCaseQuantitySenate.* from MicroteachCaseQuantitySenate Left Join {1} on {2} where {3} and MicroteachCaseQuantitySenate.IdmicroteachCaseQuantitySenate not in (Select top {5} MicroteachCaseQuantitySenate.IdmicroteachCaseQuantitySenate from MicroteachCaseQuantitySenate Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from MicroteachCaseQuantitySenate where {1} and IdmicroteachCaseQuantitySenate not in (Select top {2} IdmicroteachCaseQuantitySenate from MicroteachCaseQuantitySenate where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from MicroteachCaseQuantitySenate where {1} and IdmicroteachCaseQuantitySenate not in (Select top {3} IdmicroteachCaseQuantitySenate from MicroteachCaseQuantitySenate where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsMicroteachCaseQuantitySenateDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsMicroteachCaseQuantitySenateDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} MicroteachCaseQuantitySenate.* from MicroteachCaseQuantitySenate Left Join {1} on {2} where {3} and MicroteachCaseQuantitySenate.IdmicroteachCaseQuantitySenate not in (Select top {5} MicroteachCaseQuantitySenate.IdmicroteachCaseQuantitySenate from MicroteachCaseQuantitySenate Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from MicroteachCaseQuantitySenate where {1} and IdmicroteachCaseQuantitySenate not in (Select top {2} IdmicroteachCaseQuantitySenate from MicroteachCaseQuantitySenate where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from MicroteachCaseQuantitySenate where {1} and IdmicroteachCaseQuantitySenate not in (Select top {3} IdmicroteachCaseQuantitySenate from MicroteachCaseQuantitySenate where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsMicroteachCaseQuantitySenateEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsMicroteachCaseQuantitySenateDA:GetObjLst)", objException.Message));
}
List<clsMicroteachCaseQuantitySenateEN> arrObjLst = new List<clsMicroteachCaseQuantitySenateEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsMicroteachCaseQuantitySenateDA.GetSpecSQLObj();
strSQL = "Select * from MicroteachCaseQuantitySenate where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsMicroteachCaseQuantitySenateEN objMicroteachCaseQuantitySenateEN = new clsMicroteachCaseQuantitySenateEN();
try
{
objMicroteachCaseQuantitySenateEN.IdmicroteachCaseQuantitySenate = TransNullToInt(objRow[conMicroteachCaseQuantitySenate.IdmicroteachCaseQuantitySenate].ToString().Trim()); //微格量化评价流水号
objMicroteachCaseQuantitySenateEN.FuncModuleId = objRow[conMicroteachCaseQuantitySenate.FuncModuleId].ToString().Trim(); //功能模块Id
objMicroteachCaseQuantitySenateEN.IdMicroteachCase = objRow[conMicroteachCaseQuantitySenate.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objMicroteachCaseQuantitySenateEN.IdAppraiseType = objRow[conMicroteachCaseQuantitySenate.IdAppraiseType].ToString().Trim(); //评议类型流水号
objMicroteachCaseQuantitySenateEN.SenateTheme = objRow[conMicroteachCaseQuantitySenate.SenateTheme] == DBNull.Value ? null : objRow[conMicroteachCaseQuantitySenate.SenateTheme].ToString().Trim(); //量化评价主题
objMicroteachCaseQuantitySenateEN.SenateContent = objRow[conMicroteachCaseQuantitySenate.SenateContent] == DBNull.Value ? null : objRow[conMicroteachCaseQuantitySenate.SenateContent].ToString().Trim(); //评价内容
objMicroteachCaseQuantitySenateEN.SenateTotalScore = TransNullToFloat(objRow[conMicroteachCaseQuantitySenate.SenateTotalScore].ToString().Trim()); //评价分数
objMicroteachCaseQuantitySenateEN.SenateDate = objRow[conMicroteachCaseQuantitySenate.SenateDate] == DBNull.Value ? null : objRow[conMicroteachCaseQuantitySenate.SenateDate].ToString().Trim(); //评价日期
objMicroteachCaseQuantitySenateEN.SenateTime = objRow[conMicroteachCaseQuantitySenate.SenateTime] == DBNull.Value ? null : objRow[conMicroteachCaseQuantitySenate.SenateTime].ToString().Trim(); //评价时间
objMicroteachCaseQuantitySenateEN.SenateIp = objRow[conMicroteachCaseQuantitySenate.SenateIp].ToString().Trim(); //评议Ip
objMicroteachCaseQuantitySenateEN.BrowseCount = objRow[conMicroteachCaseQuantitySenate.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conMicroteachCaseQuantitySenate.BrowseCount].ToString().Trim()); //浏览次数
objMicroteachCaseQuantitySenateEN.IdSenateGaugeVersion = objRow[conMicroteachCaseQuantitySenate.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objMicroteachCaseQuantitySenateEN.UserId = objRow[conMicroteachCaseQuantitySenate.UserId].ToString().Trim(); //用户ID
objMicroteachCaseQuantitySenateEN.UserName = objRow[conMicroteachCaseQuantitySenate.UserName].ToString().Trim(); //用户名
objMicroteachCaseQuantitySenateEN.UserKindId = objRow[conMicroteachCaseQuantitySenate.UserKindId].ToString().Trim(); //用户类别Id
objMicroteachCaseQuantitySenateEN.UserTypeId = objRow[conMicroteachCaseQuantitySenate.UserTypeId] == DBNull.Value ? null : objRow[conMicroteachCaseQuantitySenate.UserTypeId].ToString().Trim(); //用户类型Id
objMicroteachCaseQuantitySenateEN.UpdUser = objRow[conMicroteachCaseQuantitySenate.UpdUser] == DBNull.Value ? null : objRow[conMicroteachCaseQuantitySenate.UpdUser].ToString().Trim(); //修改人
objMicroteachCaseQuantitySenateEN.Memo = objRow[conMicroteachCaseQuantitySenate.Memo] == DBNull.Value ? null : objRow[conMicroteachCaseQuantitySenate.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsMicroteachCaseQuantitySenateDA: GetObjLst)", objException.Message));
}
objMicroteachCaseQuantitySenateEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objMicroteachCaseQuantitySenateEN);
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
public List<clsMicroteachCaseQuantitySenateEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsMicroteachCaseQuantitySenateDA:GetObjLstByTabName)", objException.Message));
}
List<clsMicroteachCaseQuantitySenateEN> arrObjLst = new List<clsMicroteachCaseQuantitySenateEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsMicroteachCaseQuantitySenateDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsMicroteachCaseQuantitySenateEN objMicroteachCaseQuantitySenateEN = new clsMicroteachCaseQuantitySenateEN();
try
{
objMicroteachCaseQuantitySenateEN.IdmicroteachCaseQuantitySenate = TransNullToInt(objRow[conMicroteachCaseQuantitySenate.IdmicroteachCaseQuantitySenate].ToString().Trim()); //微格量化评价流水号
objMicroteachCaseQuantitySenateEN.FuncModuleId = objRow[conMicroteachCaseQuantitySenate.FuncModuleId].ToString().Trim(); //功能模块Id
objMicroteachCaseQuantitySenateEN.IdMicroteachCase = objRow[conMicroteachCaseQuantitySenate.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objMicroteachCaseQuantitySenateEN.IdAppraiseType = objRow[conMicroteachCaseQuantitySenate.IdAppraiseType].ToString().Trim(); //评议类型流水号
objMicroteachCaseQuantitySenateEN.SenateTheme = objRow[conMicroteachCaseQuantitySenate.SenateTheme] == DBNull.Value ? null : objRow[conMicroteachCaseQuantitySenate.SenateTheme].ToString().Trim(); //量化评价主题
objMicroteachCaseQuantitySenateEN.SenateContent = objRow[conMicroteachCaseQuantitySenate.SenateContent] == DBNull.Value ? null : objRow[conMicroteachCaseQuantitySenate.SenateContent].ToString().Trim(); //评价内容
objMicroteachCaseQuantitySenateEN.SenateTotalScore = TransNullToFloat(objRow[conMicroteachCaseQuantitySenate.SenateTotalScore].ToString().Trim()); //评价分数
objMicroteachCaseQuantitySenateEN.SenateDate = objRow[conMicroteachCaseQuantitySenate.SenateDate] == DBNull.Value ? null : objRow[conMicroteachCaseQuantitySenate.SenateDate].ToString().Trim(); //评价日期
objMicroteachCaseQuantitySenateEN.SenateTime = objRow[conMicroteachCaseQuantitySenate.SenateTime] == DBNull.Value ? null : objRow[conMicroteachCaseQuantitySenate.SenateTime].ToString().Trim(); //评价时间
objMicroteachCaseQuantitySenateEN.SenateIp = objRow[conMicroteachCaseQuantitySenate.SenateIp].ToString().Trim(); //评议Ip
objMicroteachCaseQuantitySenateEN.BrowseCount = objRow[conMicroteachCaseQuantitySenate.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conMicroteachCaseQuantitySenate.BrowseCount].ToString().Trim()); //浏览次数
objMicroteachCaseQuantitySenateEN.IdSenateGaugeVersion = objRow[conMicroteachCaseQuantitySenate.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objMicroteachCaseQuantitySenateEN.UserId = objRow[conMicroteachCaseQuantitySenate.UserId].ToString().Trim(); //用户ID
objMicroteachCaseQuantitySenateEN.UserName = objRow[conMicroteachCaseQuantitySenate.UserName].ToString().Trim(); //用户名
objMicroteachCaseQuantitySenateEN.UserKindId = objRow[conMicroteachCaseQuantitySenate.UserKindId].ToString().Trim(); //用户类别Id
objMicroteachCaseQuantitySenateEN.UserTypeId = objRow[conMicroteachCaseQuantitySenate.UserTypeId] == DBNull.Value ? null : objRow[conMicroteachCaseQuantitySenate.UserTypeId].ToString().Trim(); //用户类型Id
objMicroteachCaseQuantitySenateEN.UpdUser = objRow[conMicroteachCaseQuantitySenate.UpdUser] == DBNull.Value ? null : objRow[conMicroteachCaseQuantitySenate.UpdUser].ToString().Trim(); //修改人
objMicroteachCaseQuantitySenateEN.Memo = objRow[conMicroteachCaseQuantitySenate.Memo] == DBNull.Value ? null : objRow[conMicroteachCaseQuantitySenate.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsMicroteachCaseQuantitySenateDA: GetObjLst)", objException.Message));
}
objMicroteachCaseQuantitySenateEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objMicroteachCaseQuantitySenateEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objMicroteachCaseQuantitySenateEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetMicroteachCaseQuantitySenate(ref clsMicroteachCaseQuantitySenateEN objMicroteachCaseQuantitySenateEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsMicroteachCaseQuantitySenateDA.GetSpecSQLObj();
strSQL = "Select * from MicroteachCaseQuantitySenate where IdmicroteachCaseQuantitySenate = " + ""+ objMicroteachCaseQuantitySenateEN.IdmicroteachCaseQuantitySenate+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objMicroteachCaseQuantitySenateEN.IdmicroteachCaseQuantitySenate = TransNullToInt(objDT.Rows[0][conMicroteachCaseQuantitySenate.IdmicroteachCaseQuantitySenate].ToString().Trim()); //微格量化评价流水号(字段类型:bigint,字段长度:8,是否可空:False)
 objMicroteachCaseQuantitySenateEN.FuncModuleId = objDT.Rows[0][conMicroteachCaseQuantitySenate.FuncModuleId].ToString().Trim(); //功能模块Id(字段类型:char,字段长度:4,是否可空:True)
 objMicroteachCaseQuantitySenateEN.IdMicroteachCase = objDT.Rows[0][conMicroteachCaseQuantitySenate.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号(字段类型:char,字段长度:8,是否可空:False)
 objMicroteachCaseQuantitySenateEN.IdAppraiseType = objDT.Rows[0][conMicroteachCaseQuantitySenate.IdAppraiseType].ToString().Trim(); //评议类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objMicroteachCaseQuantitySenateEN.SenateTheme = objDT.Rows[0][conMicroteachCaseQuantitySenate.SenateTheme].ToString().Trim(); //量化评价主题(字段类型:varchar,字段长度:200,是否可空:True)
 objMicroteachCaseQuantitySenateEN.SenateContent = objDT.Rows[0][conMicroteachCaseQuantitySenate.SenateContent].ToString().Trim(); //评价内容(字段类型:varchar,字段长度:2000,是否可空:True)
 objMicroteachCaseQuantitySenateEN.SenateTotalScore = TransNullToFloat(objDT.Rows[0][conMicroteachCaseQuantitySenate.SenateTotalScore].ToString().Trim()); //评价分数(字段类型:float,字段长度:8,是否可空:False)
 objMicroteachCaseQuantitySenateEN.SenateDate = objDT.Rows[0][conMicroteachCaseQuantitySenate.SenateDate].ToString().Trim(); //评价日期(字段类型:char,字段长度:8,是否可空:True)
 objMicroteachCaseQuantitySenateEN.SenateTime = objDT.Rows[0][conMicroteachCaseQuantitySenate.SenateTime].ToString().Trim(); //评价时间(字段类型:char,字段长度:6,是否可空:True)
 objMicroteachCaseQuantitySenateEN.SenateIp = objDT.Rows[0][conMicroteachCaseQuantitySenate.SenateIp].ToString().Trim(); //评议Ip(字段类型:varchar,字段长度:50,是否可空:True)
 objMicroteachCaseQuantitySenateEN.BrowseCount = TransNullToInt(objDT.Rows[0][conMicroteachCaseQuantitySenate.BrowseCount].ToString().Trim()); //浏览次数(字段类型:int,字段长度:4,是否可空:True)
 objMicroteachCaseQuantitySenateEN.IdSenateGaugeVersion = objDT.Rows[0][conMicroteachCaseQuantitySenate.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号(字段类型:char,字段长度:4,是否可空:False)
 objMicroteachCaseQuantitySenateEN.UserId = objDT.Rows[0][conMicroteachCaseQuantitySenate.UserId].ToString().Trim(); //用户ID(字段类型:varchar,字段长度:18,是否可空:True)
 objMicroteachCaseQuantitySenateEN.UserName = objDT.Rows[0][conMicroteachCaseQuantitySenate.UserName].ToString().Trim(); //用户名(字段类型:varchar,字段长度:30,是否可空:True)
 objMicroteachCaseQuantitySenateEN.UserKindId = objDT.Rows[0][conMicroteachCaseQuantitySenate.UserKindId].ToString().Trim(); //用户类别Id(字段类型:char,字段长度:2,是否可空:False)
 objMicroteachCaseQuantitySenateEN.UserTypeId = objDT.Rows[0][conMicroteachCaseQuantitySenate.UserTypeId].ToString().Trim(); //用户类型Id(字段类型:char,字段长度:2,是否可空:True)
 objMicroteachCaseQuantitySenateEN.UpdUser = objDT.Rows[0][conMicroteachCaseQuantitySenate.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objMicroteachCaseQuantitySenateEN.Memo = objDT.Rows[0][conMicroteachCaseQuantitySenate.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsMicroteachCaseQuantitySenateDA: GetMicroteachCaseQuantitySenate)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngIdmicroteachCaseQuantitySenate">表关键字</param>
 /// <returns>表对象</returns>
public clsMicroteachCaseQuantitySenateEN GetObjByIdmicroteachCaseQuantitySenate(long lngIdmicroteachCaseQuantitySenate)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsMicroteachCaseQuantitySenateDA.GetSpecSQLObj();
strSQL = "Select * from MicroteachCaseQuantitySenate where IdmicroteachCaseQuantitySenate = " + ""+ lngIdmicroteachCaseQuantitySenate+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsMicroteachCaseQuantitySenateEN objMicroteachCaseQuantitySenateEN = new clsMicroteachCaseQuantitySenateEN();
try
{
 objMicroteachCaseQuantitySenateEN.IdmicroteachCaseQuantitySenate = Int32.Parse(objRow[conMicroteachCaseQuantitySenate.IdmicroteachCaseQuantitySenate].ToString().Trim()); //微格量化评价流水号(字段类型:bigint,字段长度:8,是否可空:False)
 objMicroteachCaseQuantitySenateEN.FuncModuleId = objRow[conMicroteachCaseQuantitySenate.FuncModuleId].ToString().Trim(); //功能模块Id(字段类型:char,字段长度:4,是否可空:True)
 objMicroteachCaseQuantitySenateEN.IdMicroteachCase = objRow[conMicroteachCaseQuantitySenate.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号(字段类型:char,字段长度:8,是否可空:False)
 objMicroteachCaseQuantitySenateEN.IdAppraiseType = objRow[conMicroteachCaseQuantitySenate.IdAppraiseType].ToString().Trim(); //评议类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objMicroteachCaseQuantitySenateEN.SenateTheme = objRow[conMicroteachCaseQuantitySenate.SenateTheme] == DBNull.Value ? null : objRow[conMicroteachCaseQuantitySenate.SenateTheme].ToString().Trim(); //量化评价主题(字段类型:varchar,字段长度:200,是否可空:True)
 objMicroteachCaseQuantitySenateEN.SenateContent = objRow[conMicroteachCaseQuantitySenate.SenateContent] == DBNull.Value ? null : objRow[conMicroteachCaseQuantitySenate.SenateContent].ToString().Trim(); //评价内容(字段类型:varchar,字段长度:2000,是否可空:True)
 objMicroteachCaseQuantitySenateEN.SenateTotalScore = Single.Parse(objRow[conMicroteachCaseQuantitySenate.SenateTotalScore].ToString().Trim()); //评价分数(字段类型:float,字段长度:8,是否可空:False)
 objMicroteachCaseQuantitySenateEN.SenateDate = objRow[conMicroteachCaseQuantitySenate.SenateDate] == DBNull.Value ? null : objRow[conMicroteachCaseQuantitySenate.SenateDate].ToString().Trim(); //评价日期(字段类型:char,字段长度:8,是否可空:True)
 objMicroteachCaseQuantitySenateEN.SenateTime = objRow[conMicroteachCaseQuantitySenate.SenateTime] == DBNull.Value ? null : objRow[conMicroteachCaseQuantitySenate.SenateTime].ToString().Trim(); //评价时间(字段类型:char,字段长度:6,是否可空:True)
 objMicroteachCaseQuantitySenateEN.SenateIp = objRow[conMicroteachCaseQuantitySenate.SenateIp].ToString().Trim(); //评议Ip(字段类型:varchar,字段长度:50,是否可空:True)
 objMicroteachCaseQuantitySenateEN.BrowseCount = objRow[conMicroteachCaseQuantitySenate.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conMicroteachCaseQuantitySenate.BrowseCount].ToString().Trim()); //浏览次数(字段类型:int,字段长度:4,是否可空:True)
 objMicroteachCaseQuantitySenateEN.IdSenateGaugeVersion = objRow[conMicroteachCaseQuantitySenate.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号(字段类型:char,字段长度:4,是否可空:False)
 objMicroteachCaseQuantitySenateEN.UserId = objRow[conMicroteachCaseQuantitySenate.UserId].ToString().Trim(); //用户ID(字段类型:varchar,字段长度:18,是否可空:True)
 objMicroteachCaseQuantitySenateEN.UserName = objRow[conMicroteachCaseQuantitySenate.UserName].ToString().Trim(); //用户名(字段类型:varchar,字段长度:30,是否可空:True)
 objMicroteachCaseQuantitySenateEN.UserKindId = objRow[conMicroteachCaseQuantitySenate.UserKindId].ToString().Trim(); //用户类别Id(字段类型:char,字段长度:2,是否可空:False)
 objMicroteachCaseQuantitySenateEN.UserTypeId = objRow[conMicroteachCaseQuantitySenate.UserTypeId] == DBNull.Value ? null : objRow[conMicroteachCaseQuantitySenate.UserTypeId].ToString().Trim(); //用户类型Id(字段类型:char,字段长度:2,是否可空:True)
 objMicroteachCaseQuantitySenateEN.UpdUser = objRow[conMicroteachCaseQuantitySenate.UpdUser] == DBNull.Value ? null : objRow[conMicroteachCaseQuantitySenate.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objMicroteachCaseQuantitySenateEN.Memo = objRow[conMicroteachCaseQuantitySenate.Memo] == DBNull.Value ? null : objRow[conMicroteachCaseQuantitySenate.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsMicroteachCaseQuantitySenateDA: GetObjByIdmicroteachCaseQuantitySenate)", objException.Message));
}
return objMicroteachCaseQuantitySenateEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsMicroteachCaseQuantitySenateEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsMicroteachCaseQuantitySenateDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsMicroteachCaseQuantitySenateDA.GetSpecSQLObj();
strSQL = "Select * from MicroteachCaseQuantitySenate where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsMicroteachCaseQuantitySenateEN objMicroteachCaseQuantitySenateEN = new clsMicroteachCaseQuantitySenateEN()
{
IdmicroteachCaseQuantitySenate = TransNullToInt(objRow[conMicroteachCaseQuantitySenate.IdmicroteachCaseQuantitySenate].ToString().Trim()), //微格量化评价流水号
FuncModuleId = objRow[conMicroteachCaseQuantitySenate.FuncModuleId].ToString().Trim(), //功能模块Id
IdMicroteachCase = objRow[conMicroteachCaseQuantitySenate.IdMicroteachCase].ToString().Trim(), //微格教学案例流水号
IdAppraiseType = objRow[conMicroteachCaseQuantitySenate.IdAppraiseType].ToString().Trim(), //评议类型流水号
SenateTheme = objRow[conMicroteachCaseQuantitySenate.SenateTheme] == DBNull.Value ? null : objRow[conMicroteachCaseQuantitySenate.SenateTheme].ToString().Trim(), //量化评价主题
SenateContent = objRow[conMicroteachCaseQuantitySenate.SenateContent] == DBNull.Value ? null : objRow[conMicroteachCaseQuantitySenate.SenateContent].ToString().Trim(), //评价内容
SenateTotalScore = TransNullToFloat(objRow[conMicroteachCaseQuantitySenate.SenateTotalScore].ToString().Trim()), //评价分数
SenateDate = objRow[conMicroteachCaseQuantitySenate.SenateDate] == DBNull.Value ? null : objRow[conMicroteachCaseQuantitySenate.SenateDate].ToString().Trim(), //评价日期
SenateTime = objRow[conMicroteachCaseQuantitySenate.SenateTime] == DBNull.Value ? null : objRow[conMicroteachCaseQuantitySenate.SenateTime].ToString().Trim(), //评价时间
SenateIp = objRow[conMicroteachCaseQuantitySenate.SenateIp].ToString().Trim(), //评议Ip
BrowseCount = objRow[conMicroteachCaseQuantitySenate.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conMicroteachCaseQuantitySenate.BrowseCount].ToString().Trim()), //浏览次数
IdSenateGaugeVersion = objRow[conMicroteachCaseQuantitySenate.IdSenateGaugeVersion].ToString().Trim(), //评价量表版本流水号
UserId = objRow[conMicroteachCaseQuantitySenate.UserId].ToString().Trim(), //用户ID
UserName = objRow[conMicroteachCaseQuantitySenate.UserName].ToString().Trim(), //用户名
UserKindId = objRow[conMicroteachCaseQuantitySenate.UserKindId].ToString().Trim(), //用户类别Id
UserTypeId = objRow[conMicroteachCaseQuantitySenate.UserTypeId] == DBNull.Value ? null : objRow[conMicroteachCaseQuantitySenate.UserTypeId].ToString().Trim(), //用户类型Id
UpdUser = objRow[conMicroteachCaseQuantitySenate.UpdUser] == DBNull.Value ? null : objRow[conMicroteachCaseQuantitySenate.UpdUser].ToString().Trim(), //修改人
Memo = objRow[conMicroteachCaseQuantitySenate.Memo] == DBNull.Value ? null : objRow[conMicroteachCaseQuantitySenate.Memo].ToString().Trim() //备注
};
objMicroteachCaseQuantitySenateEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objMicroteachCaseQuantitySenateEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsMicroteachCaseQuantitySenateDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsMicroteachCaseQuantitySenateEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsMicroteachCaseQuantitySenateEN objMicroteachCaseQuantitySenateEN = new clsMicroteachCaseQuantitySenateEN();
try
{
objMicroteachCaseQuantitySenateEN.IdmicroteachCaseQuantitySenate = TransNullToInt(objRow[conMicroteachCaseQuantitySenate.IdmicroteachCaseQuantitySenate].ToString().Trim()); //微格量化评价流水号
objMicroteachCaseQuantitySenateEN.FuncModuleId = objRow[conMicroteachCaseQuantitySenate.FuncModuleId].ToString().Trim(); //功能模块Id
objMicroteachCaseQuantitySenateEN.IdMicroteachCase = objRow[conMicroteachCaseQuantitySenate.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objMicroteachCaseQuantitySenateEN.IdAppraiseType = objRow[conMicroteachCaseQuantitySenate.IdAppraiseType].ToString().Trim(); //评议类型流水号
objMicroteachCaseQuantitySenateEN.SenateTheme = objRow[conMicroteachCaseQuantitySenate.SenateTheme] == DBNull.Value ? null : objRow[conMicroteachCaseQuantitySenate.SenateTheme].ToString().Trim(); //量化评价主题
objMicroteachCaseQuantitySenateEN.SenateContent = objRow[conMicroteachCaseQuantitySenate.SenateContent] == DBNull.Value ? null : objRow[conMicroteachCaseQuantitySenate.SenateContent].ToString().Trim(); //评价内容
objMicroteachCaseQuantitySenateEN.SenateTotalScore = TransNullToFloat(objRow[conMicroteachCaseQuantitySenate.SenateTotalScore].ToString().Trim()); //评价分数
objMicroteachCaseQuantitySenateEN.SenateDate = objRow[conMicroteachCaseQuantitySenate.SenateDate] == DBNull.Value ? null : objRow[conMicroteachCaseQuantitySenate.SenateDate].ToString().Trim(); //评价日期
objMicroteachCaseQuantitySenateEN.SenateTime = objRow[conMicroteachCaseQuantitySenate.SenateTime] == DBNull.Value ? null : objRow[conMicroteachCaseQuantitySenate.SenateTime].ToString().Trim(); //评价时间
objMicroteachCaseQuantitySenateEN.SenateIp = objRow[conMicroteachCaseQuantitySenate.SenateIp].ToString().Trim(); //评议Ip
objMicroteachCaseQuantitySenateEN.BrowseCount = objRow[conMicroteachCaseQuantitySenate.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conMicroteachCaseQuantitySenate.BrowseCount].ToString().Trim()); //浏览次数
objMicroteachCaseQuantitySenateEN.IdSenateGaugeVersion = objRow[conMicroteachCaseQuantitySenate.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objMicroteachCaseQuantitySenateEN.UserId = objRow[conMicroteachCaseQuantitySenate.UserId].ToString().Trim(); //用户ID
objMicroteachCaseQuantitySenateEN.UserName = objRow[conMicroteachCaseQuantitySenate.UserName].ToString().Trim(); //用户名
objMicroteachCaseQuantitySenateEN.UserKindId = objRow[conMicroteachCaseQuantitySenate.UserKindId].ToString().Trim(); //用户类别Id
objMicroteachCaseQuantitySenateEN.UserTypeId = objRow[conMicroteachCaseQuantitySenate.UserTypeId] == DBNull.Value ? null : objRow[conMicroteachCaseQuantitySenate.UserTypeId].ToString().Trim(); //用户类型Id
objMicroteachCaseQuantitySenateEN.UpdUser = objRow[conMicroteachCaseQuantitySenate.UpdUser] == DBNull.Value ? null : objRow[conMicroteachCaseQuantitySenate.UpdUser].ToString().Trim(); //修改人
objMicroteachCaseQuantitySenateEN.Memo = objRow[conMicroteachCaseQuantitySenate.Memo] == DBNull.Value ? null : objRow[conMicroteachCaseQuantitySenate.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsMicroteachCaseQuantitySenateDA: GetObjByDataRowMicroteachCaseQuantitySenate)", objException.Message));
}
objMicroteachCaseQuantitySenateEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objMicroteachCaseQuantitySenateEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsMicroteachCaseQuantitySenateEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsMicroteachCaseQuantitySenateEN objMicroteachCaseQuantitySenateEN = new clsMicroteachCaseQuantitySenateEN();
try
{
objMicroteachCaseQuantitySenateEN.IdmicroteachCaseQuantitySenate = TransNullToInt(objRow[conMicroteachCaseQuantitySenate.IdmicroteachCaseQuantitySenate].ToString().Trim()); //微格量化评价流水号
objMicroteachCaseQuantitySenateEN.FuncModuleId = objRow[conMicroteachCaseQuantitySenate.FuncModuleId].ToString().Trim(); //功能模块Id
objMicroteachCaseQuantitySenateEN.IdMicroteachCase = objRow[conMicroteachCaseQuantitySenate.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objMicroteachCaseQuantitySenateEN.IdAppraiseType = objRow[conMicroteachCaseQuantitySenate.IdAppraiseType].ToString().Trim(); //评议类型流水号
objMicroteachCaseQuantitySenateEN.SenateTheme = objRow[conMicroteachCaseQuantitySenate.SenateTheme] == DBNull.Value ? null : objRow[conMicroteachCaseQuantitySenate.SenateTheme].ToString().Trim(); //量化评价主题
objMicroteachCaseQuantitySenateEN.SenateContent = objRow[conMicroteachCaseQuantitySenate.SenateContent] == DBNull.Value ? null : objRow[conMicroteachCaseQuantitySenate.SenateContent].ToString().Trim(); //评价内容
objMicroteachCaseQuantitySenateEN.SenateTotalScore = TransNullToFloat(objRow[conMicroteachCaseQuantitySenate.SenateTotalScore].ToString().Trim()); //评价分数
objMicroteachCaseQuantitySenateEN.SenateDate = objRow[conMicroteachCaseQuantitySenate.SenateDate] == DBNull.Value ? null : objRow[conMicroteachCaseQuantitySenate.SenateDate].ToString().Trim(); //评价日期
objMicroteachCaseQuantitySenateEN.SenateTime = objRow[conMicroteachCaseQuantitySenate.SenateTime] == DBNull.Value ? null : objRow[conMicroteachCaseQuantitySenate.SenateTime].ToString().Trim(); //评价时间
objMicroteachCaseQuantitySenateEN.SenateIp = objRow[conMicroteachCaseQuantitySenate.SenateIp].ToString().Trim(); //评议Ip
objMicroteachCaseQuantitySenateEN.BrowseCount = objRow[conMicroteachCaseQuantitySenate.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conMicroteachCaseQuantitySenate.BrowseCount].ToString().Trim()); //浏览次数
objMicroteachCaseQuantitySenateEN.IdSenateGaugeVersion = objRow[conMicroteachCaseQuantitySenate.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objMicroteachCaseQuantitySenateEN.UserId = objRow[conMicroteachCaseQuantitySenate.UserId].ToString().Trim(); //用户ID
objMicroteachCaseQuantitySenateEN.UserName = objRow[conMicroteachCaseQuantitySenate.UserName].ToString().Trim(); //用户名
objMicroteachCaseQuantitySenateEN.UserKindId = objRow[conMicroteachCaseQuantitySenate.UserKindId].ToString().Trim(); //用户类别Id
objMicroteachCaseQuantitySenateEN.UserTypeId = objRow[conMicroteachCaseQuantitySenate.UserTypeId] == DBNull.Value ? null : objRow[conMicroteachCaseQuantitySenate.UserTypeId].ToString().Trim(); //用户类型Id
objMicroteachCaseQuantitySenateEN.UpdUser = objRow[conMicroteachCaseQuantitySenate.UpdUser] == DBNull.Value ? null : objRow[conMicroteachCaseQuantitySenate.UpdUser].ToString().Trim(); //修改人
objMicroteachCaseQuantitySenateEN.Memo = objRow[conMicroteachCaseQuantitySenate.Memo] == DBNull.Value ? null : objRow[conMicroteachCaseQuantitySenate.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsMicroteachCaseQuantitySenateDA: GetObjByDataRow)", objException.Message));
}
objMicroteachCaseQuantitySenateEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objMicroteachCaseQuantitySenateEN;
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
objSQL = clsMicroteachCaseQuantitySenateDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsMicroteachCaseQuantitySenateEN._CurrTabName, conMicroteachCaseQuantitySenate.IdmicroteachCaseQuantitySenate, 8, "");
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
objSQL = clsMicroteachCaseQuantitySenateDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsMicroteachCaseQuantitySenateEN._CurrTabName, conMicroteachCaseQuantitySenate.IdmicroteachCaseQuantitySenate, 8, strPrefix);
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
 objSQL = clsMicroteachCaseQuantitySenateDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select IdmicroteachCaseQuantitySenate from MicroteachCaseQuantitySenate where " + strCondition;
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
 objSQL = clsMicroteachCaseQuantitySenateDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select IdmicroteachCaseQuantitySenate from MicroteachCaseQuantitySenate where " + strCondition;
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
 /// <param name = "lngIdmicroteachCaseQuantitySenate">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(long lngIdmicroteachCaseQuantitySenate)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsMicroteachCaseQuantitySenateDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("MicroteachCaseQuantitySenate", "IdmicroteachCaseQuantitySenate = " + ""+ lngIdmicroteachCaseQuantitySenate+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsMicroteachCaseQuantitySenateDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsMicroteachCaseQuantitySenateDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("MicroteachCaseQuantitySenate", strCondition))
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
objSQL = clsMicroteachCaseQuantitySenateDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("MicroteachCaseQuantitySenate");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsMicroteachCaseQuantitySenateEN objMicroteachCaseQuantitySenateEN)
 {
 if (objMicroteachCaseQuantitySenateEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objMicroteachCaseQuantitySenateEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsMicroteachCaseQuantitySenateDA.GetSpecSQLObj();
strSQL = "Select * from MicroteachCaseQuantitySenate where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "MicroteachCaseQuantitySenate");
objRow = objDS.Tables["MicroteachCaseQuantitySenate"].NewRow();
objRow[conMicroteachCaseQuantitySenate.FuncModuleId] = objMicroteachCaseQuantitySenateEN.FuncModuleId; //功能模块Id
objRow[conMicroteachCaseQuantitySenate.IdMicroteachCase] = objMicroteachCaseQuantitySenateEN.IdMicroteachCase; //微格教学案例流水号
objRow[conMicroteachCaseQuantitySenate.IdAppraiseType] = objMicroteachCaseQuantitySenateEN.IdAppraiseType; //评议类型流水号
 if (objMicroteachCaseQuantitySenateEN.SenateTheme !=  "")
 {
objRow[conMicroteachCaseQuantitySenate.SenateTheme] = objMicroteachCaseQuantitySenateEN.SenateTheme; //量化评价主题
 }
 if (objMicroteachCaseQuantitySenateEN.SenateContent !=  "")
 {
objRow[conMicroteachCaseQuantitySenate.SenateContent] = objMicroteachCaseQuantitySenateEN.SenateContent; //评价内容
 }
objRow[conMicroteachCaseQuantitySenate.SenateTotalScore] = objMicroteachCaseQuantitySenateEN.SenateTotalScore; //评价分数
 if (objMicroteachCaseQuantitySenateEN.SenateDate !=  "")
 {
objRow[conMicroteachCaseQuantitySenate.SenateDate] = objMicroteachCaseQuantitySenateEN.SenateDate; //评价日期
 }
 if (objMicroteachCaseQuantitySenateEN.SenateTime !=  "")
 {
objRow[conMicroteachCaseQuantitySenate.SenateTime] = objMicroteachCaseQuantitySenateEN.SenateTime; //评价时间
 }
objRow[conMicroteachCaseQuantitySenate.SenateIp] = objMicroteachCaseQuantitySenateEN.SenateIp; //评议Ip
objRow[conMicroteachCaseQuantitySenate.BrowseCount] = objMicroteachCaseQuantitySenateEN.BrowseCount; //浏览次数
objRow[conMicroteachCaseQuantitySenate.IdSenateGaugeVersion] = objMicroteachCaseQuantitySenateEN.IdSenateGaugeVersion; //评价量表版本流水号
objRow[conMicroteachCaseQuantitySenate.UserId] = objMicroteachCaseQuantitySenateEN.UserId; //用户ID
objRow[conMicroteachCaseQuantitySenate.UserName] = objMicroteachCaseQuantitySenateEN.UserName; //用户名
objRow[conMicroteachCaseQuantitySenate.UserKindId] = objMicroteachCaseQuantitySenateEN.UserKindId; //用户类别Id
 if (objMicroteachCaseQuantitySenateEN.UserTypeId !=  "")
 {
objRow[conMicroteachCaseQuantitySenate.UserTypeId] = objMicroteachCaseQuantitySenateEN.UserTypeId; //用户类型Id
 }
 if (objMicroteachCaseQuantitySenateEN.UpdUser !=  "")
 {
objRow[conMicroteachCaseQuantitySenate.UpdUser] = objMicroteachCaseQuantitySenateEN.UpdUser; //修改人
 }
 if (objMicroteachCaseQuantitySenateEN.Memo !=  "")
 {
objRow[conMicroteachCaseQuantitySenate.Memo] = objMicroteachCaseQuantitySenateEN.Memo; //备注
 }
objDS.Tables[clsMicroteachCaseQuantitySenateEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsMicroteachCaseQuantitySenateEN._CurrTabName);
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
 /// <param name = "objMicroteachCaseQuantitySenateEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsMicroteachCaseQuantitySenateEN objMicroteachCaseQuantitySenateEN)
{
 if (objMicroteachCaseQuantitySenateEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objMicroteachCaseQuantitySenateEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objMicroteachCaseQuantitySenateEN.FuncModuleId  ==  "")
 {
 objMicroteachCaseQuantitySenateEN.FuncModuleId = null;
 }
 if (objMicroteachCaseQuantitySenateEN.FuncModuleId !=  null)
 {
 arrFieldListForInsert.Add(conMicroteachCaseQuantitySenate.FuncModuleId);
 var strFuncModuleId = objMicroteachCaseQuantitySenateEN.FuncModuleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncModuleId + "'");
 }
 
 if (objMicroteachCaseQuantitySenateEN.IdMicroteachCase  ==  "")
 {
 objMicroteachCaseQuantitySenateEN.IdMicroteachCase = null;
 }
 if (objMicroteachCaseQuantitySenateEN.IdMicroteachCase !=  null)
 {
 arrFieldListForInsert.Add(conMicroteachCaseQuantitySenate.IdMicroteachCase);
 var strIdMicroteachCase = objMicroteachCaseQuantitySenateEN.IdMicroteachCase.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdMicroteachCase + "'");
 }
 
 if (objMicroteachCaseQuantitySenateEN.IdAppraiseType !=  null)
 {
 arrFieldListForInsert.Add(conMicroteachCaseQuantitySenate.IdAppraiseType);
 var strIdAppraiseType = objMicroteachCaseQuantitySenateEN.IdAppraiseType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdAppraiseType + "'");
 }
 
 if (objMicroteachCaseQuantitySenateEN.SenateTheme !=  null)
 {
 arrFieldListForInsert.Add(conMicroteachCaseQuantitySenate.SenateTheme);
 var strSenateTheme = objMicroteachCaseQuantitySenateEN.SenateTheme.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSenateTheme + "'");
 }
 
 if (objMicroteachCaseQuantitySenateEN.SenateContent !=  null)
 {
 arrFieldListForInsert.Add(conMicroteachCaseQuantitySenate.SenateContent);
 var strSenateContent = objMicroteachCaseQuantitySenateEN.SenateContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSenateContent + "'");
 }
 
 arrFieldListForInsert.Add(conMicroteachCaseQuantitySenate.SenateTotalScore);
 arrValueListForInsert.Add(objMicroteachCaseQuantitySenateEN.SenateTotalScore.ToString());
 
 if (objMicroteachCaseQuantitySenateEN.SenateDate !=  null)
 {
 arrFieldListForInsert.Add(conMicroteachCaseQuantitySenate.SenateDate);
 var strSenateDate = objMicroteachCaseQuantitySenateEN.SenateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSenateDate + "'");
 }
 
 if (objMicroteachCaseQuantitySenateEN.SenateTime !=  null)
 {
 arrFieldListForInsert.Add(conMicroteachCaseQuantitySenate.SenateTime);
 var strSenateTime = objMicroteachCaseQuantitySenateEN.SenateTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSenateTime + "'");
 }
 
 if (objMicroteachCaseQuantitySenateEN.SenateIp !=  null)
 {
 arrFieldListForInsert.Add(conMicroteachCaseQuantitySenate.SenateIp);
 var strSenateIp = objMicroteachCaseQuantitySenateEN.SenateIp.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSenateIp + "'");
 }
 
 if (objMicroteachCaseQuantitySenateEN.BrowseCount !=  null)
 {
 arrFieldListForInsert.Add(conMicroteachCaseQuantitySenate.BrowseCount);
 arrValueListForInsert.Add(objMicroteachCaseQuantitySenateEN.BrowseCount.ToString());
 }
 
 if (objMicroteachCaseQuantitySenateEN.IdSenateGaugeVersion !=  null)
 {
 arrFieldListForInsert.Add(conMicroteachCaseQuantitySenate.IdSenateGaugeVersion);
 var strIdSenateGaugeVersion = objMicroteachCaseQuantitySenateEN.IdSenateGaugeVersion.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdSenateGaugeVersion + "'");
 }
 
 if (objMicroteachCaseQuantitySenateEN.UserId !=  null)
 {
 arrFieldListForInsert.Add(conMicroteachCaseQuantitySenate.UserId);
 var strUserId = objMicroteachCaseQuantitySenateEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserId + "'");
 }
 
 if (objMicroteachCaseQuantitySenateEN.UserName !=  null)
 {
 arrFieldListForInsert.Add(conMicroteachCaseQuantitySenate.UserName);
 var strUserName = objMicroteachCaseQuantitySenateEN.UserName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserName + "'");
 }
 
 if (objMicroteachCaseQuantitySenateEN.UserKindId !=  null)
 {
 arrFieldListForInsert.Add(conMicroteachCaseQuantitySenate.UserKindId);
 var strUserKindId = objMicroteachCaseQuantitySenateEN.UserKindId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserKindId + "'");
 }
 
 if (objMicroteachCaseQuantitySenateEN.UserTypeId !=  null)
 {
 arrFieldListForInsert.Add(conMicroteachCaseQuantitySenate.UserTypeId);
 var strUserTypeId = objMicroteachCaseQuantitySenateEN.UserTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserTypeId + "'");
 }
 
 if (objMicroteachCaseQuantitySenateEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conMicroteachCaseQuantitySenate.UpdUser);
 var strUpdUser = objMicroteachCaseQuantitySenateEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objMicroteachCaseQuantitySenateEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conMicroteachCaseQuantitySenate.Memo);
 var strMemo = objMicroteachCaseQuantitySenateEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into MicroteachCaseQuantitySenate");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsMicroteachCaseQuantitySenateDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objMicroteachCaseQuantitySenateEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsMicroteachCaseQuantitySenateEN objMicroteachCaseQuantitySenateEN)
{
 if (objMicroteachCaseQuantitySenateEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objMicroteachCaseQuantitySenateEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objMicroteachCaseQuantitySenateEN.FuncModuleId  ==  "")
 {
 objMicroteachCaseQuantitySenateEN.FuncModuleId = null;
 }
 if (objMicroteachCaseQuantitySenateEN.FuncModuleId !=  null)
 {
 arrFieldListForInsert.Add(conMicroteachCaseQuantitySenate.FuncModuleId);
 var strFuncModuleId = objMicroteachCaseQuantitySenateEN.FuncModuleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncModuleId + "'");
 }
 
 if (objMicroteachCaseQuantitySenateEN.IdMicroteachCase  ==  "")
 {
 objMicroteachCaseQuantitySenateEN.IdMicroteachCase = null;
 }
 if (objMicroteachCaseQuantitySenateEN.IdMicroteachCase !=  null)
 {
 arrFieldListForInsert.Add(conMicroteachCaseQuantitySenate.IdMicroteachCase);
 var strIdMicroteachCase = objMicroteachCaseQuantitySenateEN.IdMicroteachCase.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdMicroteachCase + "'");
 }
 
 if (objMicroteachCaseQuantitySenateEN.IdAppraiseType !=  null)
 {
 arrFieldListForInsert.Add(conMicroteachCaseQuantitySenate.IdAppraiseType);
 var strIdAppraiseType = objMicroteachCaseQuantitySenateEN.IdAppraiseType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdAppraiseType + "'");
 }
 
 if (objMicroteachCaseQuantitySenateEN.SenateTheme !=  null)
 {
 arrFieldListForInsert.Add(conMicroteachCaseQuantitySenate.SenateTheme);
 var strSenateTheme = objMicroteachCaseQuantitySenateEN.SenateTheme.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSenateTheme + "'");
 }
 
 if (objMicroteachCaseQuantitySenateEN.SenateContent !=  null)
 {
 arrFieldListForInsert.Add(conMicroteachCaseQuantitySenate.SenateContent);
 var strSenateContent = objMicroteachCaseQuantitySenateEN.SenateContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSenateContent + "'");
 }
 
 arrFieldListForInsert.Add(conMicroteachCaseQuantitySenate.SenateTotalScore);
 arrValueListForInsert.Add(objMicroteachCaseQuantitySenateEN.SenateTotalScore.ToString());
 
 if (objMicroteachCaseQuantitySenateEN.SenateDate !=  null)
 {
 arrFieldListForInsert.Add(conMicroteachCaseQuantitySenate.SenateDate);
 var strSenateDate = objMicroteachCaseQuantitySenateEN.SenateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSenateDate + "'");
 }
 
 if (objMicroteachCaseQuantitySenateEN.SenateTime !=  null)
 {
 arrFieldListForInsert.Add(conMicroteachCaseQuantitySenate.SenateTime);
 var strSenateTime = objMicroteachCaseQuantitySenateEN.SenateTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSenateTime + "'");
 }
 
 if (objMicroteachCaseQuantitySenateEN.SenateIp !=  null)
 {
 arrFieldListForInsert.Add(conMicroteachCaseQuantitySenate.SenateIp);
 var strSenateIp = objMicroteachCaseQuantitySenateEN.SenateIp.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSenateIp + "'");
 }
 
 if (objMicroteachCaseQuantitySenateEN.BrowseCount !=  null)
 {
 arrFieldListForInsert.Add(conMicroteachCaseQuantitySenate.BrowseCount);
 arrValueListForInsert.Add(objMicroteachCaseQuantitySenateEN.BrowseCount.ToString());
 }
 
 if (objMicroteachCaseQuantitySenateEN.IdSenateGaugeVersion !=  null)
 {
 arrFieldListForInsert.Add(conMicroteachCaseQuantitySenate.IdSenateGaugeVersion);
 var strIdSenateGaugeVersion = objMicroteachCaseQuantitySenateEN.IdSenateGaugeVersion.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdSenateGaugeVersion + "'");
 }
 
 if (objMicroteachCaseQuantitySenateEN.UserId !=  null)
 {
 arrFieldListForInsert.Add(conMicroteachCaseQuantitySenate.UserId);
 var strUserId = objMicroteachCaseQuantitySenateEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserId + "'");
 }
 
 if (objMicroteachCaseQuantitySenateEN.UserName !=  null)
 {
 arrFieldListForInsert.Add(conMicroteachCaseQuantitySenate.UserName);
 var strUserName = objMicroteachCaseQuantitySenateEN.UserName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserName + "'");
 }
 
 if (objMicroteachCaseQuantitySenateEN.UserKindId !=  null)
 {
 arrFieldListForInsert.Add(conMicroteachCaseQuantitySenate.UserKindId);
 var strUserKindId = objMicroteachCaseQuantitySenateEN.UserKindId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserKindId + "'");
 }
 
 if (objMicroteachCaseQuantitySenateEN.UserTypeId !=  null)
 {
 arrFieldListForInsert.Add(conMicroteachCaseQuantitySenate.UserTypeId);
 var strUserTypeId = objMicroteachCaseQuantitySenateEN.UserTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserTypeId + "'");
 }
 
 if (objMicroteachCaseQuantitySenateEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conMicroteachCaseQuantitySenate.UpdUser);
 var strUpdUser = objMicroteachCaseQuantitySenateEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objMicroteachCaseQuantitySenateEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conMicroteachCaseQuantitySenate.Memo);
 var strMemo = objMicroteachCaseQuantitySenateEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into MicroteachCaseQuantitySenate");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsMicroteachCaseQuantitySenateDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString()).Rows[0][0].ToString();
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objMicroteachCaseQuantitySenateEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsMicroteachCaseQuantitySenateEN objMicroteachCaseQuantitySenateEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objMicroteachCaseQuantitySenateEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objMicroteachCaseQuantitySenateEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objMicroteachCaseQuantitySenateEN.FuncModuleId  ==  "")
 {
 objMicroteachCaseQuantitySenateEN.FuncModuleId = null;
 }
 if (objMicroteachCaseQuantitySenateEN.FuncModuleId !=  null)
 {
 arrFieldListForInsert.Add(conMicroteachCaseQuantitySenate.FuncModuleId);
 var strFuncModuleId = objMicroteachCaseQuantitySenateEN.FuncModuleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncModuleId + "'");
 }
 
 if (objMicroteachCaseQuantitySenateEN.IdMicroteachCase  ==  "")
 {
 objMicroteachCaseQuantitySenateEN.IdMicroteachCase = null;
 }
 if (objMicroteachCaseQuantitySenateEN.IdMicroteachCase !=  null)
 {
 arrFieldListForInsert.Add(conMicroteachCaseQuantitySenate.IdMicroteachCase);
 var strIdMicroteachCase = objMicroteachCaseQuantitySenateEN.IdMicroteachCase.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdMicroteachCase + "'");
 }
 
 if (objMicroteachCaseQuantitySenateEN.IdAppraiseType !=  null)
 {
 arrFieldListForInsert.Add(conMicroteachCaseQuantitySenate.IdAppraiseType);
 var strIdAppraiseType = objMicroteachCaseQuantitySenateEN.IdAppraiseType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdAppraiseType + "'");
 }
 
 if (objMicroteachCaseQuantitySenateEN.SenateTheme !=  null)
 {
 arrFieldListForInsert.Add(conMicroteachCaseQuantitySenate.SenateTheme);
 var strSenateTheme = objMicroteachCaseQuantitySenateEN.SenateTheme.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSenateTheme + "'");
 }
 
 if (objMicroteachCaseQuantitySenateEN.SenateContent !=  null)
 {
 arrFieldListForInsert.Add(conMicroteachCaseQuantitySenate.SenateContent);
 var strSenateContent = objMicroteachCaseQuantitySenateEN.SenateContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSenateContent + "'");
 }
 
 arrFieldListForInsert.Add(conMicroteachCaseQuantitySenate.SenateTotalScore);
 arrValueListForInsert.Add(objMicroteachCaseQuantitySenateEN.SenateTotalScore.ToString());
 
 if (objMicroteachCaseQuantitySenateEN.SenateDate !=  null)
 {
 arrFieldListForInsert.Add(conMicroteachCaseQuantitySenate.SenateDate);
 var strSenateDate = objMicroteachCaseQuantitySenateEN.SenateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSenateDate + "'");
 }
 
 if (objMicroteachCaseQuantitySenateEN.SenateTime !=  null)
 {
 arrFieldListForInsert.Add(conMicroteachCaseQuantitySenate.SenateTime);
 var strSenateTime = objMicroteachCaseQuantitySenateEN.SenateTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSenateTime + "'");
 }
 
 if (objMicroteachCaseQuantitySenateEN.SenateIp !=  null)
 {
 arrFieldListForInsert.Add(conMicroteachCaseQuantitySenate.SenateIp);
 var strSenateIp = objMicroteachCaseQuantitySenateEN.SenateIp.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSenateIp + "'");
 }
 
 if (objMicroteachCaseQuantitySenateEN.BrowseCount !=  null)
 {
 arrFieldListForInsert.Add(conMicroteachCaseQuantitySenate.BrowseCount);
 arrValueListForInsert.Add(objMicroteachCaseQuantitySenateEN.BrowseCount.ToString());
 }
 
 if (objMicroteachCaseQuantitySenateEN.IdSenateGaugeVersion !=  null)
 {
 arrFieldListForInsert.Add(conMicroteachCaseQuantitySenate.IdSenateGaugeVersion);
 var strIdSenateGaugeVersion = objMicroteachCaseQuantitySenateEN.IdSenateGaugeVersion.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdSenateGaugeVersion + "'");
 }
 
 if (objMicroteachCaseQuantitySenateEN.UserId !=  null)
 {
 arrFieldListForInsert.Add(conMicroteachCaseQuantitySenate.UserId);
 var strUserId = objMicroteachCaseQuantitySenateEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserId + "'");
 }
 
 if (objMicroteachCaseQuantitySenateEN.UserName !=  null)
 {
 arrFieldListForInsert.Add(conMicroteachCaseQuantitySenate.UserName);
 var strUserName = objMicroteachCaseQuantitySenateEN.UserName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserName + "'");
 }
 
 if (objMicroteachCaseQuantitySenateEN.UserKindId !=  null)
 {
 arrFieldListForInsert.Add(conMicroteachCaseQuantitySenate.UserKindId);
 var strUserKindId = objMicroteachCaseQuantitySenateEN.UserKindId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserKindId + "'");
 }
 
 if (objMicroteachCaseQuantitySenateEN.UserTypeId !=  null)
 {
 arrFieldListForInsert.Add(conMicroteachCaseQuantitySenate.UserTypeId);
 var strUserTypeId = objMicroteachCaseQuantitySenateEN.UserTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserTypeId + "'");
 }
 
 if (objMicroteachCaseQuantitySenateEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conMicroteachCaseQuantitySenate.UpdUser);
 var strUpdUser = objMicroteachCaseQuantitySenateEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objMicroteachCaseQuantitySenateEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conMicroteachCaseQuantitySenate.Memo);
 var strMemo = objMicroteachCaseQuantitySenateEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into MicroteachCaseQuantitySenate");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsMicroteachCaseQuantitySenateDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString(), objSqlConnection, objSqlTransaction).Rows[0][0].ToString();
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objMicroteachCaseQuantitySenateEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsMicroteachCaseQuantitySenateEN objMicroteachCaseQuantitySenateEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objMicroteachCaseQuantitySenateEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objMicroteachCaseQuantitySenateEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objMicroteachCaseQuantitySenateEN.FuncModuleId  ==  "")
 {
 objMicroteachCaseQuantitySenateEN.FuncModuleId = null;
 }
 if (objMicroteachCaseQuantitySenateEN.FuncModuleId !=  null)
 {
 arrFieldListForInsert.Add(conMicroteachCaseQuantitySenate.FuncModuleId);
 var strFuncModuleId = objMicroteachCaseQuantitySenateEN.FuncModuleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncModuleId + "'");
 }
 
 if (objMicroteachCaseQuantitySenateEN.IdMicroteachCase  ==  "")
 {
 objMicroteachCaseQuantitySenateEN.IdMicroteachCase = null;
 }
 if (objMicroteachCaseQuantitySenateEN.IdMicroteachCase !=  null)
 {
 arrFieldListForInsert.Add(conMicroteachCaseQuantitySenate.IdMicroteachCase);
 var strIdMicroteachCase = objMicroteachCaseQuantitySenateEN.IdMicroteachCase.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdMicroteachCase + "'");
 }
 
 if (objMicroteachCaseQuantitySenateEN.IdAppraiseType !=  null)
 {
 arrFieldListForInsert.Add(conMicroteachCaseQuantitySenate.IdAppraiseType);
 var strIdAppraiseType = objMicroteachCaseQuantitySenateEN.IdAppraiseType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdAppraiseType + "'");
 }
 
 if (objMicroteachCaseQuantitySenateEN.SenateTheme !=  null)
 {
 arrFieldListForInsert.Add(conMicroteachCaseQuantitySenate.SenateTheme);
 var strSenateTheme = objMicroteachCaseQuantitySenateEN.SenateTheme.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSenateTheme + "'");
 }
 
 if (objMicroteachCaseQuantitySenateEN.SenateContent !=  null)
 {
 arrFieldListForInsert.Add(conMicroteachCaseQuantitySenate.SenateContent);
 var strSenateContent = objMicroteachCaseQuantitySenateEN.SenateContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSenateContent + "'");
 }
 
 arrFieldListForInsert.Add(conMicroteachCaseQuantitySenate.SenateTotalScore);
 arrValueListForInsert.Add(objMicroteachCaseQuantitySenateEN.SenateTotalScore.ToString());
 
 if (objMicroteachCaseQuantitySenateEN.SenateDate !=  null)
 {
 arrFieldListForInsert.Add(conMicroteachCaseQuantitySenate.SenateDate);
 var strSenateDate = objMicroteachCaseQuantitySenateEN.SenateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSenateDate + "'");
 }
 
 if (objMicroteachCaseQuantitySenateEN.SenateTime !=  null)
 {
 arrFieldListForInsert.Add(conMicroteachCaseQuantitySenate.SenateTime);
 var strSenateTime = objMicroteachCaseQuantitySenateEN.SenateTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSenateTime + "'");
 }
 
 if (objMicroteachCaseQuantitySenateEN.SenateIp !=  null)
 {
 arrFieldListForInsert.Add(conMicroteachCaseQuantitySenate.SenateIp);
 var strSenateIp = objMicroteachCaseQuantitySenateEN.SenateIp.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSenateIp + "'");
 }
 
 if (objMicroteachCaseQuantitySenateEN.BrowseCount !=  null)
 {
 arrFieldListForInsert.Add(conMicroteachCaseQuantitySenate.BrowseCount);
 arrValueListForInsert.Add(objMicroteachCaseQuantitySenateEN.BrowseCount.ToString());
 }
 
 if (objMicroteachCaseQuantitySenateEN.IdSenateGaugeVersion !=  null)
 {
 arrFieldListForInsert.Add(conMicroteachCaseQuantitySenate.IdSenateGaugeVersion);
 var strIdSenateGaugeVersion = objMicroteachCaseQuantitySenateEN.IdSenateGaugeVersion.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdSenateGaugeVersion + "'");
 }
 
 if (objMicroteachCaseQuantitySenateEN.UserId !=  null)
 {
 arrFieldListForInsert.Add(conMicroteachCaseQuantitySenate.UserId);
 var strUserId = objMicroteachCaseQuantitySenateEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserId + "'");
 }
 
 if (objMicroteachCaseQuantitySenateEN.UserName !=  null)
 {
 arrFieldListForInsert.Add(conMicroteachCaseQuantitySenate.UserName);
 var strUserName = objMicroteachCaseQuantitySenateEN.UserName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserName + "'");
 }
 
 if (objMicroteachCaseQuantitySenateEN.UserKindId !=  null)
 {
 arrFieldListForInsert.Add(conMicroteachCaseQuantitySenate.UserKindId);
 var strUserKindId = objMicroteachCaseQuantitySenateEN.UserKindId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserKindId + "'");
 }
 
 if (objMicroteachCaseQuantitySenateEN.UserTypeId !=  null)
 {
 arrFieldListForInsert.Add(conMicroteachCaseQuantitySenate.UserTypeId);
 var strUserTypeId = objMicroteachCaseQuantitySenateEN.UserTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserTypeId + "'");
 }
 
 if (objMicroteachCaseQuantitySenateEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conMicroteachCaseQuantitySenate.UpdUser);
 var strUpdUser = objMicroteachCaseQuantitySenateEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objMicroteachCaseQuantitySenateEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conMicroteachCaseQuantitySenate.Memo);
 var strMemo = objMicroteachCaseQuantitySenateEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into MicroteachCaseQuantitySenate");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsMicroteachCaseQuantitySenateDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewMicroteachCaseQuantitySenates(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsMicroteachCaseQuantitySenateDA.GetSpecSQLObj();
strSQL = "Select * from MicroteachCaseQuantitySenate where IdmicroteachCaseQuantitySenate = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "MicroteachCaseQuantitySenate");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
long lngIdmicroteachCaseQuantitySenate = TransNullToInt(oRow[conMicroteachCaseQuantitySenate.IdmicroteachCaseQuantitySenate].ToString().Trim());
if (IsExist(lngIdmicroteachCaseQuantitySenate))
{
 string strResult = "关键字变量值为:" + string.Format("IdmicroteachCaseQuantitySenate = {0}", lngIdmicroteachCaseQuantitySenate) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsMicroteachCaseQuantitySenateEN._CurrTabName ].NewRow();
objRow[conMicroteachCaseQuantitySenate.FuncModuleId] = oRow[conMicroteachCaseQuantitySenate.FuncModuleId].ToString().Trim(); //功能模块Id
objRow[conMicroteachCaseQuantitySenate.IdMicroteachCase] = oRow[conMicroteachCaseQuantitySenate.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objRow[conMicroteachCaseQuantitySenate.IdAppraiseType] = oRow[conMicroteachCaseQuantitySenate.IdAppraiseType].ToString().Trim(); //评议类型流水号
objRow[conMicroteachCaseQuantitySenate.SenateTheme] = oRow[conMicroteachCaseQuantitySenate.SenateTheme].ToString().Trim(); //量化评价主题
objRow[conMicroteachCaseQuantitySenate.SenateContent] = oRow[conMicroteachCaseQuantitySenate.SenateContent].ToString().Trim(); //评价内容
objRow[conMicroteachCaseQuantitySenate.SenateTotalScore] = oRow[conMicroteachCaseQuantitySenate.SenateTotalScore].ToString().Trim(); //评价分数
objRow[conMicroteachCaseQuantitySenate.SenateDate] = oRow[conMicroteachCaseQuantitySenate.SenateDate].ToString().Trim(); //评价日期
objRow[conMicroteachCaseQuantitySenate.SenateTime] = oRow[conMicroteachCaseQuantitySenate.SenateTime].ToString().Trim(); //评价时间
objRow[conMicroteachCaseQuantitySenate.SenateIp] = oRow[conMicroteachCaseQuantitySenate.SenateIp].ToString().Trim(); //评议Ip
objRow[conMicroteachCaseQuantitySenate.BrowseCount] = oRow[conMicroteachCaseQuantitySenate.BrowseCount].ToString().Trim(); //浏览次数
objRow[conMicroteachCaseQuantitySenate.IdSenateGaugeVersion] = oRow[conMicroteachCaseQuantitySenate.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objRow[conMicroteachCaseQuantitySenate.UserId] = oRow[conMicroteachCaseQuantitySenate.UserId].ToString().Trim(); //用户ID
objRow[conMicroteachCaseQuantitySenate.UserName] = oRow[conMicroteachCaseQuantitySenate.UserName].ToString().Trim(); //用户名
objRow[conMicroteachCaseQuantitySenate.UserKindId] = oRow[conMicroteachCaseQuantitySenate.UserKindId].ToString().Trim(); //用户类别Id
objRow[conMicroteachCaseQuantitySenate.UserTypeId] = oRow[conMicroteachCaseQuantitySenate.UserTypeId].ToString().Trim(); //用户类型Id
objRow[conMicroteachCaseQuantitySenate.UpdUser] = oRow[conMicroteachCaseQuantitySenate.UpdUser].ToString().Trim(); //修改人
objRow[conMicroteachCaseQuantitySenate.Memo] = oRow[conMicroteachCaseQuantitySenate.Memo].ToString().Trim(); //备注
 objDS.Tables[clsMicroteachCaseQuantitySenateEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsMicroteachCaseQuantitySenateEN._CurrTabName);
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
 /// <param name = "objMicroteachCaseQuantitySenateEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsMicroteachCaseQuantitySenateEN objMicroteachCaseQuantitySenateEN)
{
 if (objMicroteachCaseQuantitySenateEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objMicroteachCaseQuantitySenateEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsMicroteachCaseQuantitySenateDA.GetSpecSQLObj();
strSQL = "Select * from MicroteachCaseQuantitySenate where IdmicroteachCaseQuantitySenate = " + ""+ objMicroteachCaseQuantitySenateEN.IdmicroteachCaseQuantitySenate+"";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsMicroteachCaseQuantitySenateEN._CurrTabName);
if (objDS.Tables[clsMicroteachCaseQuantitySenateEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:IdmicroteachCaseQuantitySenate = " + ""+ objMicroteachCaseQuantitySenateEN.IdmicroteachCaseQuantitySenate+"");
return false;
}
objRow = objDS.Tables[clsMicroteachCaseQuantitySenateEN._CurrTabName].Rows[0];
 if (objMicroteachCaseQuantitySenateEN.IsUpdated(conMicroteachCaseQuantitySenate.FuncModuleId))
 {
objRow[conMicroteachCaseQuantitySenate.FuncModuleId] = objMicroteachCaseQuantitySenateEN.FuncModuleId; //功能模块Id
 }
 if (objMicroteachCaseQuantitySenateEN.IsUpdated(conMicroteachCaseQuantitySenate.IdMicroteachCase))
 {
objRow[conMicroteachCaseQuantitySenate.IdMicroteachCase] = objMicroteachCaseQuantitySenateEN.IdMicroteachCase; //微格教学案例流水号
 }
 if (objMicroteachCaseQuantitySenateEN.IsUpdated(conMicroteachCaseQuantitySenate.IdAppraiseType))
 {
objRow[conMicroteachCaseQuantitySenate.IdAppraiseType] = objMicroteachCaseQuantitySenateEN.IdAppraiseType; //评议类型流水号
 }
 if (objMicroteachCaseQuantitySenateEN.IsUpdated(conMicroteachCaseQuantitySenate.SenateTheme))
 {
objRow[conMicroteachCaseQuantitySenate.SenateTheme] = objMicroteachCaseQuantitySenateEN.SenateTheme; //量化评价主题
 }
 if (objMicroteachCaseQuantitySenateEN.IsUpdated(conMicroteachCaseQuantitySenate.SenateContent))
 {
objRow[conMicroteachCaseQuantitySenate.SenateContent] = objMicroteachCaseQuantitySenateEN.SenateContent; //评价内容
 }
 if (objMicroteachCaseQuantitySenateEN.IsUpdated(conMicroteachCaseQuantitySenate.SenateTotalScore))
 {
objRow[conMicroteachCaseQuantitySenate.SenateTotalScore] = objMicroteachCaseQuantitySenateEN.SenateTotalScore; //评价分数
 }
 if (objMicroteachCaseQuantitySenateEN.IsUpdated(conMicroteachCaseQuantitySenate.SenateDate))
 {
objRow[conMicroteachCaseQuantitySenate.SenateDate] = objMicroteachCaseQuantitySenateEN.SenateDate; //评价日期
 }
 if (objMicroteachCaseQuantitySenateEN.IsUpdated(conMicroteachCaseQuantitySenate.SenateTime))
 {
objRow[conMicroteachCaseQuantitySenate.SenateTime] = objMicroteachCaseQuantitySenateEN.SenateTime; //评价时间
 }
 if (objMicroteachCaseQuantitySenateEN.IsUpdated(conMicroteachCaseQuantitySenate.SenateIp))
 {
objRow[conMicroteachCaseQuantitySenate.SenateIp] = objMicroteachCaseQuantitySenateEN.SenateIp; //评议Ip
 }
 if (objMicroteachCaseQuantitySenateEN.IsUpdated(conMicroteachCaseQuantitySenate.BrowseCount))
 {
objRow[conMicroteachCaseQuantitySenate.BrowseCount] = objMicroteachCaseQuantitySenateEN.BrowseCount; //浏览次数
 }
 if (objMicroteachCaseQuantitySenateEN.IsUpdated(conMicroteachCaseQuantitySenate.IdSenateGaugeVersion))
 {
objRow[conMicroteachCaseQuantitySenate.IdSenateGaugeVersion] = objMicroteachCaseQuantitySenateEN.IdSenateGaugeVersion; //评价量表版本流水号
 }
 if (objMicroteachCaseQuantitySenateEN.IsUpdated(conMicroteachCaseQuantitySenate.UserId))
 {
objRow[conMicroteachCaseQuantitySenate.UserId] = objMicroteachCaseQuantitySenateEN.UserId; //用户ID
 }
 if (objMicroteachCaseQuantitySenateEN.IsUpdated(conMicroteachCaseQuantitySenate.UserName))
 {
objRow[conMicroteachCaseQuantitySenate.UserName] = objMicroteachCaseQuantitySenateEN.UserName; //用户名
 }
 if (objMicroteachCaseQuantitySenateEN.IsUpdated(conMicroteachCaseQuantitySenate.UserKindId))
 {
objRow[conMicroteachCaseQuantitySenate.UserKindId] = objMicroteachCaseQuantitySenateEN.UserKindId; //用户类别Id
 }
 if (objMicroteachCaseQuantitySenateEN.IsUpdated(conMicroteachCaseQuantitySenate.UserTypeId))
 {
objRow[conMicroteachCaseQuantitySenate.UserTypeId] = objMicroteachCaseQuantitySenateEN.UserTypeId; //用户类型Id
 }
 if (objMicroteachCaseQuantitySenateEN.IsUpdated(conMicroteachCaseQuantitySenate.UpdUser))
 {
objRow[conMicroteachCaseQuantitySenate.UpdUser] = objMicroteachCaseQuantitySenateEN.UpdUser; //修改人
 }
 if (objMicroteachCaseQuantitySenateEN.IsUpdated(conMicroteachCaseQuantitySenate.Memo))
 {
objRow[conMicroteachCaseQuantitySenate.Memo] = objMicroteachCaseQuantitySenateEN.Memo; //备注
 }
try
{
objDA.Update(objDS, clsMicroteachCaseQuantitySenateEN._CurrTabName);
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
 /// <param name = "objMicroteachCaseQuantitySenateEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsMicroteachCaseQuantitySenateEN objMicroteachCaseQuantitySenateEN)
{
 if (objMicroteachCaseQuantitySenateEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objMicroteachCaseQuantitySenateEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsMicroteachCaseQuantitySenateDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update MicroteachCaseQuantitySenate Set ");
 
 if (objMicroteachCaseQuantitySenateEN.IsUpdated(conMicroteachCaseQuantitySenate.FuncModuleId))
 {
 if (objMicroteachCaseQuantitySenateEN.FuncModuleId  ==  "")
 {
 objMicroteachCaseQuantitySenateEN.FuncModuleId = null;
 }
 if (objMicroteachCaseQuantitySenateEN.FuncModuleId !=  null)
 {
 var strFuncModuleId = objMicroteachCaseQuantitySenateEN.FuncModuleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFuncModuleId, conMicroteachCaseQuantitySenate.FuncModuleId); //功能模块Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conMicroteachCaseQuantitySenate.FuncModuleId); //功能模块Id
 }
 }
 
 if (objMicroteachCaseQuantitySenateEN.IsUpdated(conMicroteachCaseQuantitySenate.IdMicroteachCase))
 {
 if (objMicroteachCaseQuantitySenateEN.IdMicroteachCase  ==  "")
 {
 objMicroteachCaseQuantitySenateEN.IdMicroteachCase = null;
 }
 if (objMicroteachCaseQuantitySenateEN.IdMicroteachCase !=  null)
 {
 var strIdMicroteachCase = objMicroteachCaseQuantitySenateEN.IdMicroteachCase.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdMicroteachCase, conMicroteachCaseQuantitySenate.IdMicroteachCase); //微格教学案例流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conMicroteachCaseQuantitySenate.IdMicroteachCase); //微格教学案例流水号
 }
 }
 
 if (objMicroteachCaseQuantitySenateEN.IsUpdated(conMicroteachCaseQuantitySenate.IdAppraiseType))
 {
 if (objMicroteachCaseQuantitySenateEN.IdAppraiseType !=  null)
 {
 var strIdAppraiseType = objMicroteachCaseQuantitySenateEN.IdAppraiseType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdAppraiseType, conMicroteachCaseQuantitySenate.IdAppraiseType); //评议类型流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conMicroteachCaseQuantitySenate.IdAppraiseType); //评议类型流水号
 }
 }
 
 if (objMicroteachCaseQuantitySenateEN.IsUpdated(conMicroteachCaseQuantitySenate.SenateTheme))
 {
 if (objMicroteachCaseQuantitySenateEN.SenateTheme !=  null)
 {
 var strSenateTheme = objMicroteachCaseQuantitySenateEN.SenateTheme.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSenateTheme, conMicroteachCaseQuantitySenate.SenateTheme); //量化评价主题
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conMicroteachCaseQuantitySenate.SenateTheme); //量化评价主题
 }
 }
 
 if (objMicroteachCaseQuantitySenateEN.IsUpdated(conMicroteachCaseQuantitySenate.SenateContent))
 {
 if (objMicroteachCaseQuantitySenateEN.SenateContent !=  null)
 {
 var strSenateContent = objMicroteachCaseQuantitySenateEN.SenateContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSenateContent, conMicroteachCaseQuantitySenate.SenateContent); //评价内容
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conMicroteachCaseQuantitySenate.SenateContent); //评价内容
 }
 }
 
 if (objMicroteachCaseQuantitySenateEN.IsUpdated(conMicroteachCaseQuantitySenate.SenateTotalScore))
 {
 sbSQL.AppendFormat("{1} = {0},",objMicroteachCaseQuantitySenateEN.SenateTotalScore, conMicroteachCaseQuantitySenate.SenateTotalScore); //评价分数
 }
 
 if (objMicroteachCaseQuantitySenateEN.IsUpdated(conMicroteachCaseQuantitySenate.SenateDate))
 {
 if (objMicroteachCaseQuantitySenateEN.SenateDate !=  null)
 {
 var strSenateDate = objMicroteachCaseQuantitySenateEN.SenateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSenateDate, conMicroteachCaseQuantitySenate.SenateDate); //评价日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conMicroteachCaseQuantitySenate.SenateDate); //评价日期
 }
 }
 
 if (objMicroteachCaseQuantitySenateEN.IsUpdated(conMicroteachCaseQuantitySenate.SenateTime))
 {
 if (objMicroteachCaseQuantitySenateEN.SenateTime !=  null)
 {
 var strSenateTime = objMicroteachCaseQuantitySenateEN.SenateTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSenateTime, conMicroteachCaseQuantitySenate.SenateTime); //评价时间
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conMicroteachCaseQuantitySenate.SenateTime); //评价时间
 }
 }
 
 if (objMicroteachCaseQuantitySenateEN.IsUpdated(conMicroteachCaseQuantitySenate.SenateIp))
 {
 if (objMicroteachCaseQuantitySenateEN.SenateIp !=  null)
 {
 var strSenateIp = objMicroteachCaseQuantitySenateEN.SenateIp.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSenateIp, conMicroteachCaseQuantitySenate.SenateIp); //评议Ip
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conMicroteachCaseQuantitySenate.SenateIp); //评议Ip
 }
 }
 
 if (objMicroteachCaseQuantitySenateEN.IsUpdated(conMicroteachCaseQuantitySenate.BrowseCount))
 {
 if (objMicroteachCaseQuantitySenateEN.BrowseCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objMicroteachCaseQuantitySenateEN.BrowseCount, conMicroteachCaseQuantitySenate.BrowseCount); //浏览次数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conMicroteachCaseQuantitySenate.BrowseCount); //浏览次数
 }
 }
 
 if (objMicroteachCaseQuantitySenateEN.IsUpdated(conMicroteachCaseQuantitySenate.IdSenateGaugeVersion))
 {
 if (objMicroteachCaseQuantitySenateEN.IdSenateGaugeVersion !=  null)
 {
 var strIdSenateGaugeVersion = objMicroteachCaseQuantitySenateEN.IdSenateGaugeVersion.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdSenateGaugeVersion, conMicroteachCaseQuantitySenate.IdSenateGaugeVersion); //评价量表版本流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conMicroteachCaseQuantitySenate.IdSenateGaugeVersion); //评价量表版本流水号
 }
 }
 
 if (objMicroteachCaseQuantitySenateEN.IsUpdated(conMicroteachCaseQuantitySenate.UserId))
 {
 if (objMicroteachCaseQuantitySenateEN.UserId !=  null)
 {
 var strUserId = objMicroteachCaseQuantitySenateEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUserId, conMicroteachCaseQuantitySenate.UserId); //用户ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conMicroteachCaseQuantitySenate.UserId); //用户ID
 }
 }
 
 if (objMicroteachCaseQuantitySenateEN.IsUpdated(conMicroteachCaseQuantitySenate.UserName))
 {
 if (objMicroteachCaseQuantitySenateEN.UserName !=  null)
 {
 var strUserName = objMicroteachCaseQuantitySenateEN.UserName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUserName, conMicroteachCaseQuantitySenate.UserName); //用户名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conMicroteachCaseQuantitySenate.UserName); //用户名
 }
 }
 
 if (objMicroteachCaseQuantitySenateEN.IsUpdated(conMicroteachCaseQuantitySenate.UserKindId))
 {
 if (objMicroteachCaseQuantitySenateEN.UserKindId !=  null)
 {
 var strUserKindId = objMicroteachCaseQuantitySenateEN.UserKindId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUserKindId, conMicroteachCaseQuantitySenate.UserKindId); //用户类别Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conMicroteachCaseQuantitySenate.UserKindId); //用户类别Id
 }
 }
 
 if (objMicroteachCaseQuantitySenateEN.IsUpdated(conMicroteachCaseQuantitySenate.UserTypeId))
 {
 if (objMicroteachCaseQuantitySenateEN.UserTypeId !=  null)
 {
 var strUserTypeId = objMicroteachCaseQuantitySenateEN.UserTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUserTypeId, conMicroteachCaseQuantitySenate.UserTypeId); //用户类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conMicroteachCaseQuantitySenate.UserTypeId); //用户类型Id
 }
 }
 
 if (objMicroteachCaseQuantitySenateEN.IsUpdated(conMicroteachCaseQuantitySenate.UpdUser))
 {
 if (objMicroteachCaseQuantitySenateEN.UpdUser !=  null)
 {
 var strUpdUser = objMicroteachCaseQuantitySenateEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conMicroteachCaseQuantitySenate.UpdUser); //修改人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conMicroteachCaseQuantitySenate.UpdUser); //修改人
 }
 }
 
 if (objMicroteachCaseQuantitySenateEN.IsUpdated(conMicroteachCaseQuantitySenate.Memo))
 {
 if (objMicroteachCaseQuantitySenateEN.Memo !=  null)
 {
 var strMemo = objMicroteachCaseQuantitySenateEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conMicroteachCaseQuantitySenate.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conMicroteachCaseQuantitySenate.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where IdmicroteachCaseQuantitySenate = {0}", objMicroteachCaseQuantitySenateEN.IdmicroteachCaseQuantitySenate); 
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
 /// <param name = "objMicroteachCaseQuantitySenateEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsMicroteachCaseQuantitySenateEN objMicroteachCaseQuantitySenateEN, string strCondition)
{
 if (objMicroteachCaseQuantitySenateEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objMicroteachCaseQuantitySenateEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsMicroteachCaseQuantitySenateDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update MicroteachCaseQuantitySenate Set ");
 
 if (objMicroteachCaseQuantitySenateEN.IsUpdated(conMicroteachCaseQuantitySenate.FuncModuleId))
 {
 if (objMicroteachCaseQuantitySenateEN.FuncModuleId  ==  "")
 {
 objMicroteachCaseQuantitySenateEN.FuncModuleId = null;
 }
 if (objMicroteachCaseQuantitySenateEN.FuncModuleId !=  null)
 {
 var strFuncModuleId = objMicroteachCaseQuantitySenateEN.FuncModuleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FuncModuleId = '{0}',", strFuncModuleId); //功能模块Id
 }
 else
 {
 sbSQL.Append(" FuncModuleId = null,"); //功能模块Id
 }
 }
 
 if (objMicroteachCaseQuantitySenateEN.IsUpdated(conMicroteachCaseQuantitySenate.IdMicroteachCase))
 {
 if (objMicroteachCaseQuantitySenateEN.IdMicroteachCase  ==  "")
 {
 objMicroteachCaseQuantitySenateEN.IdMicroteachCase = null;
 }
 if (objMicroteachCaseQuantitySenateEN.IdMicroteachCase !=  null)
 {
 var strIdMicroteachCase = objMicroteachCaseQuantitySenateEN.IdMicroteachCase.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdMicroteachCase = '{0}',", strIdMicroteachCase); //微格教学案例流水号
 }
 else
 {
 sbSQL.Append(" IdMicroteachCase = null,"); //微格教学案例流水号
 }
 }
 
 if (objMicroteachCaseQuantitySenateEN.IsUpdated(conMicroteachCaseQuantitySenate.IdAppraiseType))
 {
 if (objMicroteachCaseQuantitySenateEN.IdAppraiseType !=  null)
 {
 var strIdAppraiseType = objMicroteachCaseQuantitySenateEN.IdAppraiseType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdAppraiseType = '{0}',", strIdAppraiseType); //评议类型流水号
 }
 else
 {
 sbSQL.Append(" IdAppraiseType = null,"); //评议类型流水号
 }
 }
 
 if (objMicroteachCaseQuantitySenateEN.IsUpdated(conMicroteachCaseQuantitySenate.SenateTheme))
 {
 if (objMicroteachCaseQuantitySenateEN.SenateTheme !=  null)
 {
 var strSenateTheme = objMicroteachCaseQuantitySenateEN.SenateTheme.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SenateTheme = '{0}',", strSenateTheme); //量化评价主题
 }
 else
 {
 sbSQL.Append(" SenateTheme = null,"); //量化评价主题
 }
 }
 
 if (objMicroteachCaseQuantitySenateEN.IsUpdated(conMicroteachCaseQuantitySenate.SenateContent))
 {
 if (objMicroteachCaseQuantitySenateEN.SenateContent !=  null)
 {
 var strSenateContent = objMicroteachCaseQuantitySenateEN.SenateContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SenateContent = '{0}',", strSenateContent); //评价内容
 }
 else
 {
 sbSQL.Append(" SenateContent = null,"); //评价内容
 }
 }
 
 if (objMicroteachCaseQuantitySenateEN.IsUpdated(conMicroteachCaseQuantitySenate.SenateTotalScore))
 {
 sbSQL.AppendFormat(" SenateTotalScore = {0},", objMicroteachCaseQuantitySenateEN.SenateTotalScore); //评价分数
 }
 
 if (objMicroteachCaseQuantitySenateEN.IsUpdated(conMicroteachCaseQuantitySenate.SenateDate))
 {
 if (objMicroteachCaseQuantitySenateEN.SenateDate !=  null)
 {
 var strSenateDate = objMicroteachCaseQuantitySenateEN.SenateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SenateDate = '{0}',", strSenateDate); //评价日期
 }
 else
 {
 sbSQL.Append(" SenateDate = null,"); //评价日期
 }
 }
 
 if (objMicroteachCaseQuantitySenateEN.IsUpdated(conMicroteachCaseQuantitySenate.SenateTime))
 {
 if (objMicroteachCaseQuantitySenateEN.SenateTime !=  null)
 {
 var strSenateTime = objMicroteachCaseQuantitySenateEN.SenateTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SenateTime = '{0}',", strSenateTime); //评价时间
 }
 else
 {
 sbSQL.Append(" SenateTime = null,"); //评价时间
 }
 }
 
 if (objMicroteachCaseQuantitySenateEN.IsUpdated(conMicroteachCaseQuantitySenate.SenateIp))
 {
 if (objMicroteachCaseQuantitySenateEN.SenateIp !=  null)
 {
 var strSenateIp = objMicroteachCaseQuantitySenateEN.SenateIp.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SenateIp = '{0}',", strSenateIp); //评议Ip
 }
 else
 {
 sbSQL.Append(" SenateIp = null,"); //评议Ip
 }
 }
 
 if (objMicroteachCaseQuantitySenateEN.IsUpdated(conMicroteachCaseQuantitySenate.BrowseCount))
 {
 sbSQL.AppendFormat(" BrowseCount = {0},", objMicroteachCaseQuantitySenateEN.BrowseCount); //浏览次数
 }
 
 if (objMicroteachCaseQuantitySenateEN.IsUpdated(conMicroteachCaseQuantitySenate.IdSenateGaugeVersion))
 {
 if (objMicroteachCaseQuantitySenateEN.IdSenateGaugeVersion !=  null)
 {
 var strIdSenateGaugeVersion = objMicroteachCaseQuantitySenateEN.IdSenateGaugeVersion.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdSenateGaugeVersion = '{0}',", strIdSenateGaugeVersion); //评价量表版本流水号
 }
 else
 {
 sbSQL.Append(" IdSenateGaugeVersion = null,"); //评价量表版本流水号
 }
 }
 
 if (objMicroteachCaseQuantitySenateEN.IsUpdated(conMicroteachCaseQuantitySenate.UserId))
 {
 if (objMicroteachCaseQuantitySenateEN.UserId !=  null)
 {
 var strUserId = objMicroteachCaseQuantitySenateEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UserId = '{0}',", strUserId); //用户ID
 }
 else
 {
 sbSQL.Append(" UserId = null,"); //用户ID
 }
 }
 
 if (objMicroteachCaseQuantitySenateEN.IsUpdated(conMicroteachCaseQuantitySenate.UserName))
 {
 if (objMicroteachCaseQuantitySenateEN.UserName !=  null)
 {
 var strUserName = objMicroteachCaseQuantitySenateEN.UserName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UserName = '{0}',", strUserName); //用户名
 }
 else
 {
 sbSQL.Append(" UserName = null,"); //用户名
 }
 }
 
 if (objMicroteachCaseQuantitySenateEN.IsUpdated(conMicroteachCaseQuantitySenate.UserKindId))
 {
 if (objMicroteachCaseQuantitySenateEN.UserKindId !=  null)
 {
 var strUserKindId = objMicroteachCaseQuantitySenateEN.UserKindId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UserKindId = '{0}',", strUserKindId); //用户类别Id
 }
 else
 {
 sbSQL.Append(" UserKindId = null,"); //用户类别Id
 }
 }
 
 if (objMicroteachCaseQuantitySenateEN.IsUpdated(conMicroteachCaseQuantitySenate.UserTypeId))
 {
 if (objMicroteachCaseQuantitySenateEN.UserTypeId !=  null)
 {
 var strUserTypeId = objMicroteachCaseQuantitySenateEN.UserTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UserTypeId = '{0}',", strUserTypeId); //用户类型Id
 }
 else
 {
 sbSQL.Append(" UserTypeId = null,"); //用户类型Id
 }
 }
 
 if (objMicroteachCaseQuantitySenateEN.IsUpdated(conMicroteachCaseQuantitySenate.UpdUser))
 {
 if (objMicroteachCaseQuantitySenateEN.UpdUser !=  null)
 {
 var strUpdUser = objMicroteachCaseQuantitySenateEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改人
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改人
 }
 }
 
 if (objMicroteachCaseQuantitySenateEN.IsUpdated(conMicroteachCaseQuantitySenate.Memo))
 {
 if (objMicroteachCaseQuantitySenateEN.Memo !=  null)
 {
 var strMemo = objMicroteachCaseQuantitySenateEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objMicroteachCaseQuantitySenateEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsMicroteachCaseQuantitySenateEN objMicroteachCaseQuantitySenateEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objMicroteachCaseQuantitySenateEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objMicroteachCaseQuantitySenateEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsMicroteachCaseQuantitySenateDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update MicroteachCaseQuantitySenate Set ");
 
 if (objMicroteachCaseQuantitySenateEN.IsUpdated(conMicroteachCaseQuantitySenate.FuncModuleId))
 {
 if (objMicroteachCaseQuantitySenateEN.FuncModuleId  ==  "")
 {
 objMicroteachCaseQuantitySenateEN.FuncModuleId = null;
 }
 if (objMicroteachCaseQuantitySenateEN.FuncModuleId !=  null)
 {
 var strFuncModuleId = objMicroteachCaseQuantitySenateEN.FuncModuleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FuncModuleId = '{0}',", strFuncModuleId); //功能模块Id
 }
 else
 {
 sbSQL.Append(" FuncModuleId = null,"); //功能模块Id
 }
 }
 
 if (objMicroteachCaseQuantitySenateEN.IsUpdated(conMicroteachCaseQuantitySenate.IdMicroteachCase))
 {
 if (objMicroteachCaseQuantitySenateEN.IdMicroteachCase  ==  "")
 {
 objMicroteachCaseQuantitySenateEN.IdMicroteachCase = null;
 }
 if (objMicroteachCaseQuantitySenateEN.IdMicroteachCase !=  null)
 {
 var strIdMicroteachCase = objMicroteachCaseQuantitySenateEN.IdMicroteachCase.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdMicroteachCase = '{0}',", strIdMicroteachCase); //微格教学案例流水号
 }
 else
 {
 sbSQL.Append(" IdMicroteachCase = null,"); //微格教学案例流水号
 }
 }
 
 if (objMicroteachCaseQuantitySenateEN.IsUpdated(conMicroteachCaseQuantitySenate.IdAppraiseType))
 {
 if (objMicroteachCaseQuantitySenateEN.IdAppraiseType !=  null)
 {
 var strIdAppraiseType = objMicroteachCaseQuantitySenateEN.IdAppraiseType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdAppraiseType = '{0}',", strIdAppraiseType); //评议类型流水号
 }
 else
 {
 sbSQL.Append(" IdAppraiseType = null,"); //评议类型流水号
 }
 }
 
 if (objMicroteachCaseQuantitySenateEN.IsUpdated(conMicroteachCaseQuantitySenate.SenateTheme))
 {
 if (objMicroteachCaseQuantitySenateEN.SenateTheme !=  null)
 {
 var strSenateTheme = objMicroteachCaseQuantitySenateEN.SenateTheme.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SenateTheme = '{0}',", strSenateTheme); //量化评价主题
 }
 else
 {
 sbSQL.Append(" SenateTheme = null,"); //量化评价主题
 }
 }
 
 if (objMicroteachCaseQuantitySenateEN.IsUpdated(conMicroteachCaseQuantitySenate.SenateContent))
 {
 if (objMicroteachCaseQuantitySenateEN.SenateContent !=  null)
 {
 var strSenateContent = objMicroteachCaseQuantitySenateEN.SenateContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SenateContent = '{0}',", strSenateContent); //评价内容
 }
 else
 {
 sbSQL.Append(" SenateContent = null,"); //评价内容
 }
 }
 
 if (objMicroteachCaseQuantitySenateEN.IsUpdated(conMicroteachCaseQuantitySenate.SenateTotalScore))
 {
 sbSQL.AppendFormat(" SenateTotalScore = {0},", objMicroteachCaseQuantitySenateEN.SenateTotalScore); //评价分数
 }
 
 if (objMicroteachCaseQuantitySenateEN.IsUpdated(conMicroteachCaseQuantitySenate.SenateDate))
 {
 if (objMicroteachCaseQuantitySenateEN.SenateDate !=  null)
 {
 var strSenateDate = objMicroteachCaseQuantitySenateEN.SenateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SenateDate = '{0}',", strSenateDate); //评价日期
 }
 else
 {
 sbSQL.Append(" SenateDate = null,"); //评价日期
 }
 }
 
 if (objMicroteachCaseQuantitySenateEN.IsUpdated(conMicroteachCaseQuantitySenate.SenateTime))
 {
 if (objMicroteachCaseQuantitySenateEN.SenateTime !=  null)
 {
 var strSenateTime = objMicroteachCaseQuantitySenateEN.SenateTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SenateTime = '{0}',", strSenateTime); //评价时间
 }
 else
 {
 sbSQL.Append(" SenateTime = null,"); //评价时间
 }
 }
 
 if (objMicroteachCaseQuantitySenateEN.IsUpdated(conMicroteachCaseQuantitySenate.SenateIp))
 {
 if (objMicroteachCaseQuantitySenateEN.SenateIp !=  null)
 {
 var strSenateIp = objMicroteachCaseQuantitySenateEN.SenateIp.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SenateIp = '{0}',", strSenateIp); //评议Ip
 }
 else
 {
 sbSQL.Append(" SenateIp = null,"); //评议Ip
 }
 }
 
 if (objMicroteachCaseQuantitySenateEN.IsUpdated(conMicroteachCaseQuantitySenate.BrowseCount))
 {
 sbSQL.AppendFormat(" BrowseCount = {0},", objMicroteachCaseQuantitySenateEN.BrowseCount); //浏览次数
 }
 
 if (objMicroteachCaseQuantitySenateEN.IsUpdated(conMicroteachCaseQuantitySenate.IdSenateGaugeVersion))
 {
 if (objMicroteachCaseQuantitySenateEN.IdSenateGaugeVersion !=  null)
 {
 var strIdSenateGaugeVersion = objMicroteachCaseQuantitySenateEN.IdSenateGaugeVersion.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdSenateGaugeVersion = '{0}',", strIdSenateGaugeVersion); //评价量表版本流水号
 }
 else
 {
 sbSQL.Append(" IdSenateGaugeVersion = null,"); //评价量表版本流水号
 }
 }
 
 if (objMicroteachCaseQuantitySenateEN.IsUpdated(conMicroteachCaseQuantitySenate.UserId))
 {
 if (objMicroteachCaseQuantitySenateEN.UserId !=  null)
 {
 var strUserId = objMicroteachCaseQuantitySenateEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UserId = '{0}',", strUserId); //用户ID
 }
 else
 {
 sbSQL.Append(" UserId = null,"); //用户ID
 }
 }
 
 if (objMicroteachCaseQuantitySenateEN.IsUpdated(conMicroteachCaseQuantitySenate.UserName))
 {
 if (objMicroteachCaseQuantitySenateEN.UserName !=  null)
 {
 var strUserName = objMicroteachCaseQuantitySenateEN.UserName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UserName = '{0}',", strUserName); //用户名
 }
 else
 {
 sbSQL.Append(" UserName = null,"); //用户名
 }
 }
 
 if (objMicroteachCaseQuantitySenateEN.IsUpdated(conMicroteachCaseQuantitySenate.UserKindId))
 {
 if (objMicroteachCaseQuantitySenateEN.UserKindId !=  null)
 {
 var strUserKindId = objMicroteachCaseQuantitySenateEN.UserKindId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UserKindId = '{0}',", strUserKindId); //用户类别Id
 }
 else
 {
 sbSQL.Append(" UserKindId = null,"); //用户类别Id
 }
 }
 
 if (objMicroteachCaseQuantitySenateEN.IsUpdated(conMicroteachCaseQuantitySenate.UserTypeId))
 {
 if (objMicroteachCaseQuantitySenateEN.UserTypeId !=  null)
 {
 var strUserTypeId = objMicroteachCaseQuantitySenateEN.UserTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UserTypeId = '{0}',", strUserTypeId); //用户类型Id
 }
 else
 {
 sbSQL.Append(" UserTypeId = null,"); //用户类型Id
 }
 }
 
 if (objMicroteachCaseQuantitySenateEN.IsUpdated(conMicroteachCaseQuantitySenate.UpdUser))
 {
 if (objMicroteachCaseQuantitySenateEN.UpdUser !=  null)
 {
 var strUpdUser = objMicroteachCaseQuantitySenateEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改人
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改人
 }
 }
 
 if (objMicroteachCaseQuantitySenateEN.IsUpdated(conMicroteachCaseQuantitySenate.Memo))
 {
 if (objMicroteachCaseQuantitySenateEN.Memo !=  null)
 {
 var strMemo = objMicroteachCaseQuantitySenateEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objMicroteachCaseQuantitySenateEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsMicroteachCaseQuantitySenateEN objMicroteachCaseQuantitySenateEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objMicroteachCaseQuantitySenateEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objMicroteachCaseQuantitySenateEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsMicroteachCaseQuantitySenateDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update MicroteachCaseQuantitySenate Set ");
 
 if (objMicroteachCaseQuantitySenateEN.IsUpdated(conMicroteachCaseQuantitySenate.FuncModuleId))
 {
 if (objMicroteachCaseQuantitySenateEN.FuncModuleId  ==  "")
 {
 objMicroteachCaseQuantitySenateEN.FuncModuleId = null;
 }
 if (objMicroteachCaseQuantitySenateEN.FuncModuleId !=  null)
 {
 var strFuncModuleId = objMicroteachCaseQuantitySenateEN.FuncModuleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFuncModuleId, conMicroteachCaseQuantitySenate.FuncModuleId); //功能模块Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conMicroteachCaseQuantitySenate.FuncModuleId); //功能模块Id
 }
 }
 
 if (objMicroteachCaseQuantitySenateEN.IsUpdated(conMicroteachCaseQuantitySenate.IdMicroteachCase))
 {
 if (objMicroteachCaseQuantitySenateEN.IdMicroteachCase  ==  "")
 {
 objMicroteachCaseQuantitySenateEN.IdMicroteachCase = null;
 }
 if (objMicroteachCaseQuantitySenateEN.IdMicroteachCase !=  null)
 {
 var strIdMicroteachCase = objMicroteachCaseQuantitySenateEN.IdMicroteachCase.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdMicroteachCase, conMicroteachCaseQuantitySenate.IdMicroteachCase); //微格教学案例流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conMicroteachCaseQuantitySenate.IdMicroteachCase); //微格教学案例流水号
 }
 }
 
 if (objMicroteachCaseQuantitySenateEN.IsUpdated(conMicroteachCaseQuantitySenate.IdAppraiseType))
 {
 if (objMicroteachCaseQuantitySenateEN.IdAppraiseType !=  null)
 {
 var strIdAppraiseType = objMicroteachCaseQuantitySenateEN.IdAppraiseType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdAppraiseType, conMicroteachCaseQuantitySenate.IdAppraiseType); //评议类型流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conMicroteachCaseQuantitySenate.IdAppraiseType); //评议类型流水号
 }
 }
 
 if (objMicroteachCaseQuantitySenateEN.IsUpdated(conMicroteachCaseQuantitySenate.SenateTheme))
 {
 if (objMicroteachCaseQuantitySenateEN.SenateTheme !=  null)
 {
 var strSenateTheme = objMicroteachCaseQuantitySenateEN.SenateTheme.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSenateTheme, conMicroteachCaseQuantitySenate.SenateTheme); //量化评价主题
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conMicroteachCaseQuantitySenate.SenateTheme); //量化评价主题
 }
 }
 
 if (objMicroteachCaseQuantitySenateEN.IsUpdated(conMicroteachCaseQuantitySenate.SenateContent))
 {
 if (objMicroteachCaseQuantitySenateEN.SenateContent !=  null)
 {
 var strSenateContent = objMicroteachCaseQuantitySenateEN.SenateContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSenateContent, conMicroteachCaseQuantitySenate.SenateContent); //评价内容
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conMicroteachCaseQuantitySenate.SenateContent); //评价内容
 }
 }
 
 if (objMicroteachCaseQuantitySenateEN.IsUpdated(conMicroteachCaseQuantitySenate.SenateTotalScore))
 {
 sbSQL.AppendFormat("{1} = {0},",objMicroteachCaseQuantitySenateEN.SenateTotalScore, conMicroteachCaseQuantitySenate.SenateTotalScore); //评价分数
 }
 
 if (objMicroteachCaseQuantitySenateEN.IsUpdated(conMicroteachCaseQuantitySenate.SenateDate))
 {
 if (objMicroteachCaseQuantitySenateEN.SenateDate !=  null)
 {
 var strSenateDate = objMicroteachCaseQuantitySenateEN.SenateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSenateDate, conMicroteachCaseQuantitySenate.SenateDate); //评价日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conMicroteachCaseQuantitySenate.SenateDate); //评价日期
 }
 }
 
 if (objMicroteachCaseQuantitySenateEN.IsUpdated(conMicroteachCaseQuantitySenate.SenateTime))
 {
 if (objMicroteachCaseQuantitySenateEN.SenateTime !=  null)
 {
 var strSenateTime = objMicroteachCaseQuantitySenateEN.SenateTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSenateTime, conMicroteachCaseQuantitySenate.SenateTime); //评价时间
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conMicroteachCaseQuantitySenate.SenateTime); //评价时间
 }
 }
 
 if (objMicroteachCaseQuantitySenateEN.IsUpdated(conMicroteachCaseQuantitySenate.SenateIp))
 {
 if (objMicroteachCaseQuantitySenateEN.SenateIp !=  null)
 {
 var strSenateIp = objMicroteachCaseQuantitySenateEN.SenateIp.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSenateIp, conMicroteachCaseQuantitySenate.SenateIp); //评议Ip
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conMicroteachCaseQuantitySenate.SenateIp); //评议Ip
 }
 }
 
 if (objMicroteachCaseQuantitySenateEN.IsUpdated(conMicroteachCaseQuantitySenate.BrowseCount))
 {
 if (objMicroteachCaseQuantitySenateEN.BrowseCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objMicroteachCaseQuantitySenateEN.BrowseCount, conMicroteachCaseQuantitySenate.BrowseCount); //浏览次数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conMicroteachCaseQuantitySenate.BrowseCount); //浏览次数
 }
 }
 
 if (objMicroteachCaseQuantitySenateEN.IsUpdated(conMicroteachCaseQuantitySenate.IdSenateGaugeVersion))
 {
 if (objMicroteachCaseQuantitySenateEN.IdSenateGaugeVersion !=  null)
 {
 var strIdSenateGaugeVersion = objMicroteachCaseQuantitySenateEN.IdSenateGaugeVersion.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdSenateGaugeVersion, conMicroteachCaseQuantitySenate.IdSenateGaugeVersion); //评价量表版本流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conMicroteachCaseQuantitySenate.IdSenateGaugeVersion); //评价量表版本流水号
 }
 }
 
 if (objMicroteachCaseQuantitySenateEN.IsUpdated(conMicroteachCaseQuantitySenate.UserId))
 {
 if (objMicroteachCaseQuantitySenateEN.UserId !=  null)
 {
 var strUserId = objMicroteachCaseQuantitySenateEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUserId, conMicroteachCaseQuantitySenate.UserId); //用户ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conMicroteachCaseQuantitySenate.UserId); //用户ID
 }
 }
 
 if (objMicroteachCaseQuantitySenateEN.IsUpdated(conMicroteachCaseQuantitySenate.UserName))
 {
 if (objMicroteachCaseQuantitySenateEN.UserName !=  null)
 {
 var strUserName = objMicroteachCaseQuantitySenateEN.UserName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUserName, conMicroteachCaseQuantitySenate.UserName); //用户名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conMicroteachCaseQuantitySenate.UserName); //用户名
 }
 }
 
 if (objMicroteachCaseQuantitySenateEN.IsUpdated(conMicroteachCaseQuantitySenate.UserKindId))
 {
 if (objMicroteachCaseQuantitySenateEN.UserKindId !=  null)
 {
 var strUserKindId = objMicroteachCaseQuantitySenateEN.UserKindId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUserKindId, conMicroteachCaseQuantitySenate.UserKindId); //用户类别Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conMicroteachCaseQuantitySenate.UserKindId); //用户类别Id
 }
 }
 
 if (objMicroteachCaseQuantitySenateEN.IsUpdated(conMicroteachCaseQuantitySenate.UserTypeId))
 {
 if (objMicroteachCaseQuantitySenateEN.UserTypeId !=  null)
 {
 var strUserTypeId = objMicroteachCaseQuantitySenateEN.UserTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUserTypeId, conMicroteachCaseQuantitySenate.UserTypeId); //用户类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conMicroteachCaseQuantitySenate.UserTypeId); //用户类型Id
 }
 }
 
 if (objMicroteachCaseQuantitySenateEN.IsUpdated(conMicroteachCaseQuantitySenate.UpdUser))
 {
 if (objMicroteachCaseQuantitySenateEN.UpdUser !=  null)
 {
 var strUpdUser = objMicroteachCaseQuantitySenateEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conMicroteachCaseQuantitySenate.UpdUser); //修改人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conMicroteachCaseQuantitySenate.UpdUser); //修改人
 }
 }
 
 if (objMicroteachCaseQuantitySenateEN.IsUpdated(conMicroteachCaseQuantitySenate.Memo))
 {
 if (objMicroteachCaseQuantitySenateEN.Memo !=  null)
 {
 var strMemo = objMicroteachCaseQuantitySenateEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conMicroteachCaseQuantitySenate.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conMicroteachCaseQuantitySenate.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where IdmicroteachCaseQuantitySenate = {0}", objMicroteachCaseQuantitySenateEN.IdmicroteachCaseQuantitySenate); 
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
 /// <param name = "lngIdmicroteachCaseQuantitySenate">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(long lngIdmicroteachCaseQuantitySenate) 
{
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsMicroteachCaseQuantitySenateDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 lngIdmicroteachCaseQuantitySenate,
};
 objSQL.ExecSP("MicroteachCaseQuantitySenate_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "lngIdmicroteachCaseQuantitySenate">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(long lngIdmicroteachCaseQuantitySenate, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsMicroteachCaseQuantitySenateDA.GetSpecSQLObj();
//删除MicroteachCaseQuantitySenate本表中与当前对象有关的记录
strSQL = strSQL + "Delete from MicroteachCaseQuantitySenate where IdmicroteachCaseQuantitySenate = " + ""+ lngIdmicroteachCaseQuantitySenate+"";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelMicroteachCaseQuantitySenate(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsMicroteachCaseQuantitySenateDA.GetSpecSQLObj();
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
//删除MicroteachCaseQuantitySenate本表中与当前对象有关的记录
strSQL = strSQL + "Delete from MicroteachCaseQuantitySenate where IdmicroteachCaseQuantitySenate in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "lngIdmicroteachCaseQuantitySenate">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(long lngIdmicroteachCaseQuantitySenate) 
{
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsMicroteachCaseQuantitySenateDA.GetSpecSQLObj();
//删除MicroteachCaseQuantitySenate本表中与当前对象有关的记录
strSQL = strSQL + "Delete from MicroteachCaseQuantitySenate where IdmicroteachCaseQuantitySenate = " + ""+ lngIdmicroteachCaseQuantitySenate+"";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelMicroteachCaseQuantitySenate(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsMicroteachCaseQuantitySenateDA: DelMicroteachCaseQuantitySenate)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsMicroteachCaseQuantitySenateDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from MicroteachCaseQuantitySenate where " + strCondition ;
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
public bool DelMicroteachCaseQuantitySenateWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsMicroteachCaseQuantitySenateDA: DelMicroteachCaseQuantitySenateWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsMicroteachCaseQuantitySenateDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from MicroteachCaseQuantitySenate where " + strCondition ;
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
 /// <param name = "objMicroteachCaseQuantitySenateENS">源对象</param>
 /// <param name = "objMicroteachCaseQuantitySenateENT">目标对象</param>
public void CopyTo(clsMicroteachCaseQuantitySenateEN objMicroteachCaseQuantitySenateENS, clsMicroteachCaseQuantitySenateEN objMicroteachCaseQuantitySenateENT)
{
objMicroteachCaseQuantitySenateENT.IdmicroteachCaseQuantitySenate = objMicroteachCaseQuantitySenateENS.IdmicroteachCaseQuantitySenate; //微格量化评价流水号
objMicroteachCaseQuantitySenateENT.FuncModuleId = objMicroteachCaseQuantitySenateENS.FuncModuleId; //功能模块Id
objMicroteachCaseQuantitySenateENT.IdMicroteachCase = objMicroteachCaseQuantitySenateENS.IdMicroteachCase; //微格教学案例流水号
objMicroteachCaseQuantitySenateENT.IdAppraiseType = objMicroteachCaseQuantitySenateENS.IdAppraiseType; //评议类型流水号
objMicroteachCaseQuantitySenateENT.SenateTheme = objMicroteachCaseQuantitySenateENS.SenateTheme; //量化评价主题
objMicroteachCaseQuantitySenateENT.SenateContent = objMicroteachCaseQuantitySenateENS.SenateContent; //评价内容
objMicroteachCaseQuantitySenateENT.SenateTotalScore = objMicroteachCaseQuantitySenateENS.SenateTotalScore; //评价分数
objMicroteachCaseQuantitySenateENT.SenateDate = objMicroteachCaseQuantitySenateENS.SenateDate; //评价日期
objMicroteachCaseQuantitySenateENT.SenateTime = objMicroteachCaseQuantitySenateENS.SenateTime; //评价时间
objMicroteachCaseQuantitySenateENT.SenateIp = objMicroteachCaseQuantitySenateENS.SenateIp; //评议Ip
objMicroteachCaseQuantitySenateENT.BrowseCount = objMicroteachCaseQuantitySenateENS.BrowseCount; //浏览次数
objMicroteachCaseQuantitySenateENT.IdSenateGaugeVersion = objMicroteachCaseQuantitySenateENS.IdSenateGaugeVersion; //评价量表版本流水号
objMicroteachCaseQuantitySenateENT.UserId = objMicroteachCaseQuantitySenateENS.UserId; //用户ID
objMicroteachCaseQuantitySenateENT.UserName = objMicroteachCaseQuantitySenateENS.UserName; //用户名
objMicroteachCaseQuantitySenateENT.UserKindId = objMicroteachCaseQuantitySenateENS.UserKindId; //用户类别Id
objMicroteachCaseQuantitySenateENT.UserTypeId = objMicroteachCaseQuantitySenateENS.UserTypeId; //用户类型Id
objMicroteachCaseQuantitySenateENT.UpdUser = objMicroteachCaseQuantitySenateENS.UpdUser; //修改人
objMicroteachCaseQuantitySenateENT.Memo = objMicroteachCaseQuantitySenateENS.Memo; //备注
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsMicroteachCaseQuantitySenateEN objMicroteachCaseQuantitySenateEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objMicroteachCaseQuantitySenateEN.FuncModuleId, conMicroteachCaseQuantitySenate.FuncModuleId);
clsCheckSql.CheckFieldNotNull(objMicroteachCaseQuantitySenateEN.IdMicroteachCase, conMicroteachCaseQuantitySenate.IdMicroteachCase);
clsCheckSql.CheckFieldNotNull(objMicroteachCaseQuantitySenateEN.IdAppraiseType, conMicroteachCaseQuantitySenate.IdAppraiseType);
clsCheckSql.CheckFieldNotNull(objMicroteachCaseQuantitySenateEN.SenateTotalScore, conMicroteachCaseQuantitySenate.SenateTotalScore);
clsCheckSql.CheckFieldNotNull(objMicroteachCaseQuantitySenateEN.SenateIp, conMicroteachCaseQuantitySenate.SenateIp);
clsCheckSql.CheckFieldNotNull(objMicroteachCaseQuantitySenateEN.IdSenateGaugeVersion, conMicroteachCaseQuantitySenate.IdSenateGaugeVersion);
clsCheckSql.CheckFieldNotNull(objMicroteachCaseQuantitySenateEN.UserId, conMicroteachCaseQuantitySenate.UserId);
clsCheckSql.CheckFieldNotNull(objMicroteachCaseQuantitySenateEN.UserName, conMicroteachCaseQuantitySenate.UserName);
clsCheckSql.CheckFieldNotNull(objMicroteachCaseQuantitySenateEN.UserKindId, conMicroteachCaseQuantitySenate.UserKindId);
//检查字段长度
clsCheckSql.CheckFieldLen(objMicroteachCaseQuantitySenateEN.FuncModuleId, 4, conMicroteachCaseQuantitySenate.FuncModuleId);
clsCheckSql.CheckFieldLen(objMicroteachCaseQuantitySenateEN.IdMicroteachCase, 8, conMicroteachCaseQuantitySenate.IdMicroteachCase);
clsCheckSql.CheckFieldLen(objMicroteachCaseQuantitySenateEN.IdAppraiseType, 4, conMicroteachCaseQuantitySenate.IdAppraiseType);
clsCheckSql.CheckFieldLen(objMicroteachCaseQuantitySenateEN.SenateTheme, 200, conMicroteachCaseQuantitySenate.SenateTheme);
clsCheckSql.CheckFieldLen(objMicroteachCaseQuantitySenateEN.SenateContent, 2000, conMicroteachCaseQuantitySenate.SenateContent);
clsCheckSql.CheckFieldLen(objMicroteachCaseQuantitySenateEN.SenateDate, 8, conMicroteachCaseQuantitySenate.SenateDate);
clsCheckSql.CheckFieldLen(objMicroteachCaseQuantitySenateEN.SenateTime, 6, conMicroteachCaseQuantitySenate.SenateTime);
clsCheckSql.CheckFieldLen(objMicroteachCaseQuantitySenateEN.SenateIp, 50, conMicroteachCaseQuantitySenate.SenateIp);
clsCheckSql.CheckFieldLen(objMicroteachCaseQuantitySenateEN.IdSenateGaugeVersion, 4, conMicroteachCaseQuantitySenate.IdSenateGaugeVersion);
clsCheckSql.CheckFieldLen(objMicroteachCaseQuantitySenateEN.UserId, 18, conMicroteachCaseQuantitySenate.UserId);
clsCheckSql.CheckFieldLen(objMicroteachCaseQuantitySenateEN.UserName, 30, conMicroteachCaseQuantitySenate.UserName);
clsCheckSql.CheckFieldLen(objMicroteachCaseQuantitySenateEN.UserKindId, 2, conMicroteachCaseQuantitySenate.UserKindId);
clsCheckSql.CheckFieldLen(objMicroteachCaseQuantitySenateEN.UserTypeId, 2, conMicroteachCaseQuantitySenate.UserTypeId);
clsCheckSql.CheckFieldLen(objMicroteachCaseQuantitySenateEN.UpdUser, 20, conMicroteachCaseQuantitySenate.UpdUser);
clsCheckSql.CheckFieldLen(objMicroteachCaseQuantitySenateEN.Memo, 1000, conMicroteachCaseQuantitySenate.Memo);
//检查字段外键固定长度
clsCheckSql.CheckFieldForeignKey(objMicroteachCaseQuantitySenateEN.FuncModuleId, 4, conMicroteachCaseQuantitySenate.FuncModuleId);
clsCheckSql.CheckFieldForeignKey(objMicroteachCaseQuantitySenateEN.IdMicroteachCase, 8, conMicroteachCaseQuantitySenate.IdMicroteachCase);
 objMicroteachCaseQuantitySenateEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsMicroteachCaseQuantitySenateEN objMicroteachCaseQuantitySenateEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objMicroteachCaseQuantitySenateEN.FuncModuleId, 4, conMicroteachCaseQuantitySenate.FuncModuleId);
clsCheckSql.CheckFieldLen(objMicroteachCaseQuantitySenateEN.IdMicroteachCase, 8, conMicroteachCaseQuantitySenate.IdMicroteachCase);
clsCheckSql.CheckFieldLen(objMicroteachCaseQuantitySenateEN.IdAppraiseType, 4, conMicroteachCaseQuantitySenate.IdAppraiseType);
clsCheckSql.CheckFieldLen(objMicroteachCaseQuantitySenateEN.SenateTheme, 200, conMicroteachCaseQuantitySenate.SenateTheme);
clsCheckSql.CheckFieldLen(objMicroteachCaseQuantitySenateEN.SenateContent, 2000, conMicroteachCaseQuantitySenate.SenateContent);
clsCheckSql.CheckFieldLen(objMicroteachCaseQuantitySenateEN.SenateDate, 8, conMicroteachCaseQuantitySenate.SenateDate);
clsCheckSql.CheckFieldLen(objMicroteachCaseQuantitySenateEN.SenateTime, 6, conMicroteachCaseQuantitySenate.SenateTime);
clsCheckSql.CheckFieldLen(objMicroteachCaseQuantitySenateEN.SenateIp, 50, conMicroteachCaseQuantitySenate.SenateIp);
clsCheckSql.CheckFieldLen(objMicroteachCaseQuantitySenateEN.IdSenateGaugeVersion, 4, conMicroteachCaseQuantitySenate.IdSenateGaugeVersion);
clsCheckSql.CheckFieldLen(objMicroteachCaseQuantitySenateEN.UserId, 18, conMicroteachCaseQuantitySenate.UserId);
clsCheckSql.CheckFieldLen(objMicroteachCaseQuantitySenateEN.UserName, 30, conMicroteachCaseQuantitySenate.UserName);
clsCheckSql.CheckFieldLen(objMicroteachCaseQuantitySenateEN.UserKindId, 2, conMicroteachCaseQuantitySenate.UserKindId);
clsCheckSql.CheckFieldLen(objMicroteachCaseQuantitySenateEN.UserTypeId, 2, conMicroteachCaseQuantitySenate.UserTypeId);
clsCheckSql.CheckFieldLen(objMicroteachCaseQuantitySenateEN.UpdUser, 20, conMicroteachCaseQuantitySenate.UpdUser);
clsCheckSql.CheckFieldLen(objMicroteachCaseQuantitySenateEN.Memo, 1000, conMicroteachCaseQuantitySenate.Memo);
//检查外键字段长度
clsCheckSql.CheckFieldForeignKey(objMicroteachCaseQuantitySenateEN.FuncModuleId, 4, conMicroteachCaseQuantitySenate.FuncModuleId);
clsCheckSql.CheckFieldForeignKey(objMicroteachCaseQuantitySenateEN.IdMicroteachCase, 8, conMicroteachCaseQuantitySenate.IdMicroteachCase);
 objMicroteachCaseQuantitySenateEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsMicroteachCaseQuantitySenateEN objMicroteachCaseQuantitySenateEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objMicroteachCaseQuantitySenateEN.FuncModuleId, 4, conMicroteachCaseQuantitySenate.FuncModuleId);
clsCheckSql.CheckFieldLen(objMicroteachCaseQuantitySenateEN.IdMicroteachCase, 8, conMicroteachCaseQuantitySenate.IdMicroteachCase);
clsCheckSql.CheckFieldLen(objMicroteachCaseQuantitySenateEN.IdAppraiseType, 4, conMicroteachCaseQuantitySenate.IdAppraiseType);
clsCheckSql.CheckFieldLen(objMicroteachCaseQuantitySenateEN.SenateTheme, 200, conMicroteachCaseQuantitySenate.SenateTheme);
clsCheckSql.CheckFieldLen(objMicroteachCaseQuantitySenateEN.SenateContent, 2000, conMicroteachCaseQuantitySenate.SenateContent);
clsCheckSql.CheckFieldLen(objMicroteachCaseQuantitySenateEN.SenateDate, 8, conMicroteachCaseQuantitySenate.SenateDate);
clsCheckSql.CheckFieldLen(objMicroteachCaseQuantitySenateEN.SenateTime, 6, conMicroteachCaseQuantitySenate.SenateTime);
clsCheckSql.CheckFieldLen(objMicroteachCaseQuantitySenateEN.SenateIp, 50, conMicroteachCaseQuantitySenate.SenateIp);
clsCheckSql.CheckFieldLen(objMicroteachCaseQuantitySenateEN.IdSenateGaugeVersion, 4, conMicroteachCaseQuantitySenate.IdSenateGaugeVersion);
clsCheckSql.CheckFieldLen(objMicroteachCaseQuantitySenateEN.UserId, 18, conMicroteachCaseQuantitySenate.UserId);
clsCheckSql.CheckFieldLen(objMicroteachCaseQuantitySenateEN.UserName, 30, conMicroteachCaseQuantitySenate.UserName);
clsCheckSql.CheckFieldLen(objMicroteachCaseQuantitySenateEN.UserKindId, 2, conMicroteachCaseQuantitySenate.UserKindId);
clsCheckSql.CheckFieldLen(objMicroteachCaseQuantitySenateEN.UserTypeId, 2, conMicroteachCaseQuantitySenate.UserTypeId);
clsCheckSql.CheckFieldLen(objMicroteachCaseQuantitySenateEN.UpdUser, 20, conMicroteachCaseQuantitySenate.UpdUser);
clsCheckSql.CheckFieldLen(objMicroteachCaseQuantitySenateEN.Memo, 1000, conMicroteachCaseQuantitySenate.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objMicroteachCaseQuantitySenateEN.FuncModuleId, conMicroteachCaseQuantitySenate.FuncModuleId);
clsCheckSql.CheckSqlInjection4Field(objMicroteachCaseQuantitySenateEN.IdMicroteachCase, conMicroteachCaseQuantitySenate.IdMicroteachCase);
clsCheckSql.CheckSqlInjection4Field(objMicroteachCaseQuantitySenateEN.IdAppraiseType, conMicroteachCaseQuantitySenate.IdAppraiseType);
clsCheckSql.CheckSqlInjection4Field(objMicroteachCaseQuantitySenateEN.SenateTheme, conMicroteachCaseQuantitySenate.SenateTheme);
clsCheckSql.CheckSqlInjection4Field(objMicroteachCaseQuantitySenateEN.SenateContent, conMicroteachCaseQuantitySenate.SenateContent);
clsCheckSql.CheckSqlInjection4Field(objMicroteachCaseQuantitySenateEN.SenateDate, conMicroteachCaseQuantitySenate.SenateDate);
clsCheckSql.CheckSqlInjection4Field(objMicroteachCaseQuantitySenateEN.SenateTime, conMicroteachCaseQuantitySenate.SenateTime);
clsCheckSql.CheckSqlInjection4Field(objMicroteachCaseQuantitySenateEN.SenateIp, conMicroteachCaseQuantitySenate.SenateIp);
clsCheckSql.CheckSqlInjection4Field(objMicroteachCaseQuantitySenateEN.IdSenateGaugeVersion, conMicroteachCaseQuantitySenate.IdSenateGaugeVersion);
clsCheckSql.CheckSqlInjection4Field(objMicroteachCaseQuantitySenateEN.UserId, conMicroteachCaseQuantitySenate.UserId);
clsCheckSql.CheckSqlInjection4Field(objMicroteachCaseQuantitySenateEN.UserName, conMicroteachCaseQuantitySenate.UserName);
clsCheckSql.CheckSqlInjection4Field(objMicroteachCaseQuantitySenateEN.UserKindId, conMicroteachCaseQuantitySenate.UserKindId);
clsCheckSql.CheckSqlInjection4Field(objMicroteachCaseQuantitySenateEN.UserTypeId, conMicroteachCaseQuantitySenate.UserTypeId);
clsCheckSql.CheckSqlInjection4Field(objMicroteachCaseQuantitySenateEN.UpdUser, conMicroteachCaseQuantitySenate.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objMicroteachCaseQuantitySenateEN.Memo, conMicroteachCaseQuantitySenate.Memo);
//检查外键字段长度
clsCheckSql.CheckFieldForeignKey(objMicroteachCaseQuantitySenateEN.FuncModuleId, 4, conMicroteachCaseQuantitySenate.FuncModuleId);
clsCheckSql.CheckFieldForeignKey(objMicroteachCaseQuantitySenateEN.IdMicroteachCase, 8, conMicroteachCaseQuantitySenate.IdMicroteachCase);
 objMicroteachCaseQuantitySenateEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--MicroteachCaseQuantitySenate(微格教学教师量化评价),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objMicroteachCaseQuantitySenateEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clsMicroteachCaseQuantitySenateEN objMicroteachCaseQuantitySenateEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and FuncModuleId = '{0}'", objMicroteachCaseQuantitySenateEN.FuncModuleId);
 sbCondition.AppendFormat(" and IdMicroteachCase = '{0}'", objMicroteachCaseQuantitySenateEN.IdMicroteachCase);
 sbCondition.AppendFormat(" and IdAppraiseType = '{0}'", objMicroteachCaseQuantitySenateEN.IdAppraiseType);
 sbCondition.AppendFormat(" and UserId = '{0}'", objMicroteachCaseQuantitySenateEN.UserId);
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
 objSQL = clsMicroteachCaseQuantitySenateDA.GetSpecSQLObj();
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
 objSQL = clsMicroteachCaseQuantitySenateDA.GetSpecSQLObj();
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
 objSQL = clsMicroteachCaseQuantitySenateDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsMicroteachCaseQuantitySenateEN._CurrTabName);
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
 objSQL = clsMicroteachCaseQuantitySenateDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsMicroteachCaseQuantitySenateEN._CurrTabName, strCondition);
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
 objSQL = clsMicroteachCaseQuantitySenateDA.GetSpecSQLObj();
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
 objSQL = clsMicroteachCaseQuantitySenateDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}