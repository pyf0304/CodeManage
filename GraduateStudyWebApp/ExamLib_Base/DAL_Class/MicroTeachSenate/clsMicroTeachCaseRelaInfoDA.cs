
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsMicroTeachCaseRelaInfoDA
 表名:MicroTeachCaseRelaInfo(01120318)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:16:53
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
 /// 微格案例相关信息(MicroTeachCaseRelaInfo)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsMicroTeachCaseRelaInfoDA : clsCommBase4DA
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
 return clsMicroTeachCaseRelaInfoEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsMicroTeachCaseRelaInfoEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsMicroTeachCaseRelaInfoEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsMicroTeachCaseRelaInfoEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsMicroTeachCaseRelaInfoEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsMicroTeachCaseRelaInfoDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsMicroTeachCaseRelaInfoDA.GetSpecSQLObj();
strSQL = "Select * from MicroTeachCaseRelaInfo where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_MicroTeachCaseRelaInfo(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsMicroTeachCaseRelaInfoDA: GetDataTable_MicroTeachCaseRelaInfo)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsMicroTeachCaseRelaInfoDA.GetSpecSQLObj();
strSQL = "Select * from MicroTeachCaseRelaInfo where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsMicroTeachCaseRelaInfoDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsMicroTeachCaseRelaInfoDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsMicroTeachCaseRelaInfoDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsMicroTeachCaseRelaInfoDA.GetSpecSQLObj();
strSQL = "Select * from MicroTeachCaseRelaInfo where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsMicroTeachCaseRelaInfoDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsMicroTeachCaseRelaInfoDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsMicroTeachCaseRelaInfoDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsMicroTeachCaseRelaInfoDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from MicroTeachCaseRelaInfo where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from MicroTeachCaseRelaInfo where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsMicroTeachCaseRelaInfoDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsMicroTeachCaseRelaInfoDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from MicroTeachCaseRelaInfo where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsMicroTeachCaseRelaInfoDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsMicroTeachCaseRelaInfoDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} MicroTeachCaseRelaInfo.* from MicroTeachCaseRelaInfo Left Join {1} on {2} where {3} and MicroTeachCaseRelaInfo.IdMicroTeachCaseRelaInfo not in (Select top {5} MicroTeachCaseRelaInfo.IdMicroTeachCaseRelaInfo from MicroTeachCaseRelaInfo Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from MicroTeachCaseRelaInfo where {1} and IdMicroTeachCaseRelaInfo not in (Select top {2} IdMicroTeachCaseRelaInfo from MicroTeachCaseRelaInfo where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from MicroTeachCaseRelaInfo where {1} and IdMicroTeachCaseRelaInfo not in (Select top {3} IdMicroTeachCaseRelaInfo from MicroTeachCaseRelaInfo where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsMicroTeachCaseRelaInfoDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsMicroTeachCaseRelaInfoDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} MicroTeachCaseRelaInfo.* from MicroTeachCaseRelaInfo Left Join {1} on {2} where {3} and MicroTeachCaseRelaInfo.IdMicroTeachCaseRelaInfo not in (Select top {5} MicroTeachCaseRelaInfo.IdMicroTeachCaseRelaInfo from MicroTeachCaseRelaInfo Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from MicroTeachCaseRelaInfo where {1} and IdMicroTeachCaseRelaInfo not in (Select top {2} IdMicroTeachCaseRelaInfo from MicroTeachCaseRelaInfo where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from MicroTeachCaseRelaInfo where {1} and IdMicroTeachCaseRelaInfo not in (Select top {3} IdMicroTeachCaseRelaInfo from MicroTeachCaseRelaInfo where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsMicroTeachCaseRelaInfoEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsMicroTeachCaseRelaInfoDA:GetObjLst)", objException.Message));
}
List<clsMicroTeachCaseRelaInfoEN> arrObjLst = new List<clsMicroTeachCaseRelaInfoEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsMicroTeachCaseRelaInfoDA.GetSpecSQLObj();
strSQL = "Select * from MicroTeachCaseRelaInfo where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsMicroTeachCaseRelaInfoEN objMicroTeachCaseRelaInfoEN = new clsMicroTeachCaseRelaInfoEN();
try
{
objMicroTeachCaseRelaInfoEN.IdMicroTeachCaseRelaInfo = TransNullToInt(objRow[conMicroTeachCaseRelaInfo.IdMicroTeachCaseRelaInfo].ToString().Trim()); //案例相关信息流水号
objMicroTeachCaseRelaInfoEN.FuncModuleId = objRow[conMicroTeachCaseRelaInfo.FuncModuleId].ToString().Trim(); //功能模块Id
objMicroTeachCaseRelaInfoEN.IdMicroteachCase = objRow[conMicroTeachCaseRelaInfo.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objMicroTeachCaseRelaInfoEN.IdResource = objRow[conMicroTeachCaseRelaInfo.IdResource].ToString().Trim(); //资源流水号
objMicroTeachCaseRelaInfoEN.IdMicroTeachCaseRelaInfoType = objRow[conMicroTeachCaseRelaInfo.IdMicroTeachCaseRelaInfoType].ToString().Trim(); //微格案例相关信息类型流水号
objMicroTeachCaseRelaInfoEN.IsVisible = TransNullToBool(objRow[conMicroTeachCaseRelaInfo.IsVisible].ToString().Trim()); //是否显示
objMicroTeachCaseRelaInfoEN.BrowseCount = objRow[conMicroTeachCaseRelaInfo.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conMicroTeachCaseRelaInfo.BrowseCount].ToString().Trim()); //浏览次数
objMicroTeachCaseRelaInfoEN.Flag = objRow[conMicroTeachCaseRelaInfo.Flag] == DBNull.Value ? null : objRow[conMicroTeachCaseRelaInfo.Flag].ToString().Trim(); //标志
objMicroTeachCaseRelaInfoEN.UpdDate = objRow[conMicroTeachCaseRelaInfo.UpdDate] == DBNull.Value ? null : objRow[conMicroTeachCaseRelaInfo.UpdDate].ToString().Trim(); //修改日期
objMicroTeachCaseRelaInfoEN.UpdUser = objRow[conMicroTeachCaseRelaInfo.UpdUser] == DBNull.Value ? null : objRow[conMicroTeachCaseRelaInfo.UpdUser].ToString().Trim(); //修改人
objMicroTeachCaseRelaInfoEN.Memo = objRow[conMicroTeachCaseRelaInfo.Memo] == DBNull.Value ? null : objRow[conMicroTeachCaseRelaInfo.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsMicroTeachCaseRelaInfoDA: GetObjLst)", objException.Message));
}
objMicroTeachCaseRelaInfoEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objMicroTeachCaseRelaInfoEN);
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
public List<clsMicroTeachCaseRelaInfoEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsMicroTeachCaseRelaInfoDA:GetObjLstByTabName)", objException.Message));
}
List<clsMicroTeachCaseRelaInfoEN> arrObjLst = new List<clsMicroTeachCaseRelaInfoEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsMicroTeachCaseRelaInfoDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsMicroTeachCaseRelaInfoEN objMicroTeachCaseRelaInfoEN = new clsMicroTeachCaseRelaInfoEN();
try
{
objMicroTeachCaseRelaInfoEN.IdMicroTeachCaseRelaInfo = TransNullToInt(objRow[conMicroTeachCaseRelaInfo.IdMicroTeachCaseRelaInfo].ToString().Trim()); //案例相关信息流水号
objMicroTeachCaseRelaInfoEN.FuncModuleId = objRow[conMicroTeachCaseRelaInfo.FuncModuleId].ToString().Trim(); //功能模块Id
objMicroTeachCaseRelaInfoEN.IdMicroteachCase = objRow[conMicroTeachCaseRelaInfo.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objMicroTeachCaseRelaInfoEN.IdResource = objRow[conMicroTeachCaseRelaInfo.IdResource].ToString().Trim(); //资源流水号
objMicroTeachCaseRelaInfoEN.IdMicroTeachCaseRelaInfoType = objRow[conMicroTeachCaseRelaInfo.IdMicroTeachCaseRelaInfoType].ToString().Trim(); //微格案例相关信息类型流水号
objMicroTeachCaseRelaInfoEN.IsVisible = TransNullToBool(objRow[conMicroTeachCaseRelaInfo.IsVisible].ToString().Trim()); //是否显示
objMicroTeachCaseRelaInfoEN.BrowseCount = objRow[conMicroTeachCaseRelaInfo.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conMicroTeachCaseRelaInfo.BrowseCount].ToString().Trim()); //浏览次数
objMicroTeachCaseRelaInfoEN.Flag = objRow[conMicroTeachCaseRelaInfo.Flag] == DBNull.Value ? null : objRow[conMicroTeachCaseRelaInfo.Flag].ToString().Trim(); //标志
objMicroTeachCaseRelaInfoEN.UpdDate = objRow[conMicroTeachCaseRelaInfo.UpdDate] == DBNull.Value ? null : objRow[conMicroTeachCaseRelaInfo.UpdDate].ToString().Trim(); //修改日期
objMicroTeachCaseRelaInfoEN.UpdUser = objRow[conMicroTeachCaseRelaInfo.UpdUser] == DBNull.Value ? null : objRow[conMicroTeachCaseRelaInfo.UpdUser].ToString().Trim(); //修改人
objMicroTeachCaseRelaInfoEN.Memo = objRow[conMicroTeachCaseRelaInfo.Memo] == DBNull.Value ? null : objRow[conMicroTeachCaseRelaInfo.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsMicroTeachCaseRelaInfoDA: GetObjLst)", objException.Message));
}
objMicroTeachCaseRelaInfoEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objMicroTeachCaseRelaInfoEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objMicroTeachCaseRelaInfoEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetMicroTeachCaseRelaInfo(ref clsMicroTeachCaseRelaInfoEN objMicroTeachCaseRelaInfoEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsMicroTeachCaseRelaInfoDA.GetSpecSQLObj();
strSQL = "Select * from MicroTeachCaseRelaInfo where IdMicroTeachCaseRelaInfo = " + ""+ objMicroTeachCaseRelaInfoEN.IdMicroTeachCaseRelaInfo+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objMicroTeachCaseRelaInfoEN.IdMicroTeachCaseRelaInfo = TransNullToInt(objDT.Rows[0][conMicroTeachCaseRelaInfo.IdMicroTeachCaseRelaInfo].ToString().Trim()); //案例相关信息流水号(字段类型:bigint,字段长度:8,是否可空:False)
 objMicroTeachCaseRelaInfoEN.FuncModuleId = objDT.Rows[0][conMicroTeachCaseRelaInfo.FuncModuleId].ToString().Trim(); //功能模块Id(字段类型:char,字段长度:4,是否可空:True)
 objMicroTeachCaseRelaInfoEN.IdMicroteachCase = objDT.Rows[0][conMicroTeachCaseRelaInfo.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号(字段类型:char,字段长度:8,是否可空:False)
 objMicroTeachCaseRelaInfoEN.IdResource = objDT.Rows[0][conMicroTeachCaseRelaInfo.IdResource].ToString().Trim(); //资源流水号(字段类型:char,字段长度:8,是否可空:False)
 objMicroTeachCaseRelaInfoEN.IdMicroTeachCaseRelaInfoType = objDT.Rows[0][conMicroTeachCaseRelaInfo.IdMicroTeachCaseRelaInfoType].ToString().Trim(); //微格案例相关信息类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objMicroTeachCaseRelaInfoEN.IsVisible = TransNullToBool(objDT.Rows[0][conMicroTeachCaseRelaInfo.IsVisible].ToString().Trim()); //是否显示(字段类型:bit,字段长度:1,是否可空:True)
 objMicroTeachCaseRelaInfoEN.BrowseCount = TransNullToInt(objDT.Rows[0][conMicroTeachCaseRelaInfo.BrowseCount].ToString().Trim()); //浏览次数(字段类型:int,字段长度:4,是否可空:True)
 objMicroTeachCaseRelaInfoEN.Flag = objDT.Rows[0][conMicroTeachCaseRelaInfo.Flag].ToString().Trim(); //标志(字段类型:varchar,字段长度:50,是否可空:True)
 objMicroTeachCaseRelaInfoEN.UpdDate = objDT.Rows[0][conMicroTeachCaseRelaInfo.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objMicroTeachCaseRelaInfoEN.UpdUser = objDT.Rows[0][conMicroTeachCaseRelaInfo.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objMicroTeachCaseRelaInfoEN.Memo = objDT.Rows[0][conMicroTeachCaseRelaInfo.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsMicroTeachCaseRelaInfoDA: GetMicroTeachCaseRelaInfo)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngIdMicroTeachCaseRelaInfo">表关键字</param>
 /// <returns>表对象</returns>
public clsMicroTeachCaseRelaInfoEN GetObjByIdMicroTeachCaseRelaInfo(long lngIdMicroTeachCaseRelaInfo)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsMicroTeachCaseRelaInfoDA.GetSpecSQLObj();
strSQL = "Select * from MicroTeachCaseRelaInfo where IdMicroTeachCaseRelaInfo = " + ""+ lngIdMicroTeachCaseRelaInfo+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsMicroTeachCaseRelaInfoEN objMicroTeachCaseRelaInfoEN = new clsMicroTeachCaseRelaInfoEN();
try
{
 objMicroTeachCaseRelaInfoEN.IdMicroTeachCaseRelaInfo = Int32.Parse(objRow[conMicroTeachCaseRelaInfo.IdMicroTeachCaseRelaInfo].ToString().Trim()); //案例相关信息流水号(字段类型:bigint,字段长度:8,是否可空:False)
 objMicroTeachCaseRelaInfoEN.FuncModuleId = objRow[conMicroTeachCaseRelaInfo.FuncModuleId].ToString().Trim(); //功能模块Id(字段类型:char,字段长度:4,是否可空:True)
 objMicroTeachCaseRelaInfoEN.IdMicroteachCase = objRow[conMicroTeachCaseRelaInfo.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号(字段类型:char,字段长度:8,是否可空:False)
 objMicroTeachCaseRelaInfoEN.IdResource = objRow[conMicroTeachCaseRelaInfo.IdResource].ToString().Trim(); //资源流水号(字段类型:char,字段长度:8,是否可空:False)
 objMicroTeachCaseRelaInfoEN.IdMicroTeachCaseRelaInfoType = objRow[conMicroTeachCaseRelaInfo.IdMicroTeachCaseRelaInfoType].ToString().Trim(); //微格案例相关信息类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objMicroTeachCaseRelaInfoEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conMicroTeachCaseRelaInfo.IsVisible].ToString().Trim()); //是否显示(字段类型:bit,字段长度:1,是否可空:True)
 objMicroTeachCaseRelaInfoEN.BrowseCount = objRow[conMicroTeachCaseRelaInfo.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conMicroTeachCaseRelaInfo.BrowseCount].ToString().Trim()); //浏览次数(字段类型:int,字段长度:4,是否可空:True)
 objMicroTeachCaseRelaInfoEN.Flag = objRow[conMicroTeachCaseRelaInfo.Flag] == DBNull.Value ? null : objRow[conMicroTeachCaseRelaInfo.Flag].ToString().Trim(); //标志(字段类型:varchar,字段长度:50,是否可空:True)
 objMicroTeachCaseRelaInfoEN.UpdDate = objRow[conMicroTeachCaseRelaInfo.UpdDate] == DBNull.Value ? null : objRow[conMicroTeachCaseRelaInfo.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objMicroTeachCaseRelaInfoEN.UpdUser = objRow[conMicroTeachCaseRelaInfo.UpdUser] == DBNull.Value ? null : objRow[conMicroTeachCaseRelaInfo.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objMicroTeachCaseRelaInfoEN.Memo = objRow[conMicroTeachCaseRelaInfo.Memo] == DBNull.Value ? null : objRow[conMicroTeachCaseRelaInfo.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsMicroTeachCaseRelaInfoDA: GetObjByIdMicroTeachCaseRelaInfo)", objException.Message));
}
return objMicroTeachCaseRelaInfoEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsMicroTeachCaseRelaInfoEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsMicroTeachCaseRelaInfoDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsMicroTeachCaseRelaInfoDA.GetSpecSQLObj();
strSQL = "Select * from MicroTeachCaseRelaInfo where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsMicroTeachCaseRelaInfoEN objMicroTeachCaseRelaInfoEN = new clsMicroTeachCaseRelaInfoEN()
{
IdMicroTeachCaseRelaInfo = TransNullToInt(objRow[conMicroTeachCaseRelaInfo.IdMicroTeachCaseRelaInfo].ToString().Trim()), //案例相关信息流水号
FuncModuleId = objRow[conMicroTeachCaseRelaInfo.FuncModuleId].ToString().Trim(), //功能模块Id
IdMicroteachCase = objRow[conMicroTeachCaseRelaInfo.IdMicroteachCase].ToString().Trim(), //微格教学案例流水号
IdResource = objRow[conMicroTeachCaseRelaInfo.IdResource].ToString().Trim(), //资源流水号
IdMicroTeachCaseRelaInfoType = objRow[conMicroTeachCaseRelaInfo.IdMicroTeachCaseRelaInfoType].ToString().Trim(), //微格案例相关信息类型流水号
IsVisible = TransNullToBool(objRow[conMicroTeachCaseRelaInfo.IsVisible].ToString().Trim()), //是否显示
BrowseCount = objRow[conMicroTeachCaseRelaInfo.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conMicroTeachCaseRelaInfo.BrowseCount].ToString().Trim()), //浏览次数
Flag = objRow[conMicroTeachCaseRelaInfo.Flag] == DBNull.Value ? null : objRow[conMicroTeachCaseRelaInfo.Flag].ToString().Trim(), //标志
UpdDate = objRow[conMicroTeachCaseRelaInfo.UpdDate] == DBNull.Value ? null : objRow[conMicroTeachCaseRelaInfo.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[conMicroTeachCaseRelaInfo.UpdUser] == DBNull.Value ? null : objRow[conMicroTeachCaseRelaInfo.UpdUser].ToString().Trim(), //修改人
Memo = objRow[conMicroTeachCaseRelaInfo.Memo] == DBNull.Value ? null : objRow[conMicroTeachCaseRelaInfo.Memo].ToString().Trim() //备注
};
objMicroTeachCaseRelaInfoEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objMicroTeachCaseRelaInfoEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsMicroTeachCaseRelaInfoDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsMicroTeachCaseRelaInfoEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsMicroTeachCaseRelaInfoEN objMicroTeachCaseRelaInfoEN = new clsMicroTeachCaseRelaInfoEN();
try
{
objMicroTeachCaseRelaInfoEN.IdMicroTeachCaseRelaInfo = TransNullToInt(objRow[conMicroTeachCaseRelaInfo.IdMicroTeachCaseRelaInfo].ToString().Trim()); //案例相关信息流水号
objMicroTeachCaseRelaInfoEN.FuncModuleId = objRow[conMicroTeachCaseRelaInfo.FuncModuleId].ToString().Trim(); //功能模块Id
objMicroTeachCaseRelaInfoEN.IdMicroteachCase = objRow[conMicroTeachCaseRelaInfo.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objMicroTeachCaseRelaInfoEN.IdResource = objRow[conMicroTeachCaseRelaInfo.IdResource].ToString().Trim(); //资源流水号
objMicroTeachCaseRelaInfoEN.IdMicroTeachCaseRelaInfoType = objRow[conMicroTeachCaseRelaInfo.IdMicroTeachCaseRelaInfoType].ToString().Trim(); //微格案例相关信息类型流水号
objMicroTeachCaseRelaInfoEN.IsVisible = TransNullToBool(objRow[conMicroTeachCaseRelaInfo.IsVisible].ToString().Trim()); //是否显示
objMicroTeachCaseRelaInfoEN.BrowseCount = objRow[conMicroTeachCaseRelaInfo.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conMicroTeachCaseRelaInfo.BrowseCount].ToString().Trim()); //浏览次数
objMicroTeachCaseRelaInfoEN.Flag = objRow[conMicroTeachCaseRelaInfo.Flag] == DBNull.Value ? null : objRow[conMicroTeachCaseRelaInfo.Flag].ToString().Trim(); //标志
objMicroTeachCaseRelaInfoEN.UpdDate = objRow[conMicroTeachCaseRelaInfo.UpdDate] == DBNull.Value ? null : objRow[conMicroTeachCaseRelaInfo.UpdDate].ToString().Trim(); //修改日期
objMicroTeachCaseRelaInfoEN.UpdUser = objRow[conMicroTeachCaseRelaInfo.UpdUser] == DBNull.Value ? null : objRow[conMicroTeachCaseRelaInfo.UpdUser].ToString().Trim(); //修改人
objMicroTeachCaseRelaInfoEN.Memo = objRow[conMicroTeachCaseRelaInfo.Memo] == DBNull.Value ? null : objRow[conMicroTeachCaseRelaInfo.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsMicroTeachCaseRelaInfoDA: GetObjByDataRowMicroTeachCaseRelaInfo)", objException.Message));
}
objMicroTeachCaseRelaInfoEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objMicroTeachCaseRelaInfoEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsMicroTeachCaseRelaInfoEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsMicroTeachCaseRelaInfoEN objMicroTeachCaseRelaInfoEN = new clsMicroTeachCaseRelaInfoEN();
try
{
objMicroTeachCaseRelaInfoEN.IdMicroTeachCaseRelaInfo = TransNullToInt(objRow[conMicroTeachCaseRelaInfo.IdMicroTeachCaseRelaInfo].ToString().Trim()); //案例相关信息流水号
objMicroTeachCaseRelaInfoEN.FuncModuleId = objRow[conMicroTeachCaseRelaInfo.FuncModuleId].ToString().Trim(); //功能模块Id
objMicroTeachCaseRelaInfoEN.IdMicroteachCase = objRow[conMicroTeachCaseRelaInfo.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objMicroTeachCaseRelaInfoEN.IdResource = objRow[conMicroTeachCaseRelaInfo.IdResource].ToString().Trim(); //资源流水号
objMicroTeachCaseRelaInfoEN.IdMicroTeachCaseRelaInfoType = objRow[conMicroTeachCaseRelaInfo.IdMicroTeachCaseRelaInfoType].ToString().Trim(); //微格案例相关信息类型流水号
objMicroTeachCaseRelaInfoEN.IsVisible = TransNullToBool(objRow[conMicroTeachCaseRelaInfo.IsVisible].ToString().Trim()); //是否显示
objMicroTeachCaseRelaInfoEN.BrowseCount = objRow[conMicroTeachCaseRelaInfo.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conMicroTeachCaseRelaInfo.BrowseCount].ToString().Trim()); //浏览次数
objMicroTeachCaseRelaInfoEN.Flag = objRow[conMicroTeachCaseRelaInfo.Flag] == DBNull.Value ? null : objRow[conMicroTeachCaseRelaInfo.Flag].ToString().Trim(); //标志
objMicroTeachCaseRelaInfoEN.UpdDate = objRow[conMicroTeachCaseRelaInfo.UpdDate] == DBNull.Value ? null : objRow[conMicroTeachCaseRelaInfo.UpdDate].ToString().Trim(); //修改日期
objMicroTeachCaseRelaInfoEN.UpdUser = objRow[conMicroTeachCaseRelaInfo.UpdUser] == DBNull.Value ? null : objRow[conMicroTeachCaseRelaInfo.UpdUser].ToString().Trim(); //修改人
objMicroTeachCaseRelaInfoEN.Memo = objRow[conMicroTeachCaseRelaInfo.Memo] == DBNull.Value ? null : objRow[conMicroTeachCaseRelaInfo.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsMicroTeachCaseRelaInfoDA: GetObjByDataRow)", objException.Message));
}
objMicroTeachCaseRelaInfoEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objMicroTeachCaseRelaInfoEN;
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
objSQL = clsMicroTeachCaseRelaInfoDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsMicroTeachCaseRelaInfoEN._CurrTabName, conMicroTeachCaseRelaInfo.IdMicroTeachCaseRelaInfo, 8, "");
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
objSQL = clsMicroTeachCaseRelaInfoDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsMicroTeachCaseRelaInfoEN._CurrTabName, conMicroTeachCaseRelaInfo.IdMicroTeachCaseRelaInfo, 8, strPrefix);
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
 objSQL = clsMicroTeachCaseRelaInfoDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select IdMicroTeachCaseRelaInfo from MicroTeachCaseRelaInfo where " + strCondition;
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
 objSQL = clsMicroTeachCaseRelaInfoDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select IdMicroTeachCaseRelaInfo from MicroTeachCaseRelaInfo where " + strCondition;
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
 /// <param name = "lngIdMicroTeachCaseRelaInfo">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(long lngIdMicroTeachCaseRelaInfo)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsMicroTeachCaseRelaInfoDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("MicroTeachCaseRelaInfo", "IdMicroTeachCaseRelaInfo = " + ""+ lngIdMicroTeachCaseRelaInfo+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsMicroTeachCaseRelaInfoDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsMicroTeachCaseRelaInfoDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("MicroTeachCaseRelaInfo", strCondition))
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
objSQL = clsMicroTeachCaseRelaInfoDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("MicroTeachCaseRelaInfo");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsMicroTeachCaseRelaInfoEN objMicroTeachCaseRelaInfoEN)
 {
 objMicroTeachCaseRelaInfoEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objMicroTeachCaseRelaInfoEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objMicroTeachCaseRelaInfoEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsMicroTeachCaseRelaInfoDA.GetSpecSQLObj();
strSQL = "Select * from MicroTeachCaseRelaInfo where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "MicroTeachCaseRelaInfo");
objRow = objDS.Tables["MicroTeachCaseRelaInfo"].NewRow();
objRow[conMicroTeachCaseRelaInfo.FuncModuleId] = objMicroTeachCaseRelaInfoEN.FuncModuleId; //功能模块Id
objRow[conMicroTeachCaseRelaInfo.IdMicroteachCase] = objMicroTeachCaseRelaInfoEN.IdMicroteachCase; //微格教学案例流水号
objRow[conMicroTeachCaseRelaInfo.IdResource] = objMicroTeachCaseRelaInfoEN.IdResource; //资源流水号
objRow[conMicroTeachCaseRelaInfo.IdMicroTeachCaseRelaInfoType] = objMicroTeachCaseRelaInfoEN.IdMicroTeachCaseRelaInfoType; //微格案例相关信息类型流水号
objRow[conMicroTeachCaseRelaInfo.IsVisible] = objMicroTeachCaseRelaInfoEN.IsVisible; //是否显示
objRow[conMicroTeachCaseRelaInfo.BrowseCount] = objMicroTeachCaseRelaInfoEN.BrowseCount; //浏览次数
 if (objMicroTeachCaseRelaInfoEN.Flag !=  "")
 {
objRow[conMicroTeachCaseRelaInfo.Flag] = objMicroTeachCaseRelaInfoEN.Flag; //标志
 }
 if (objMicroTeachCaseRelaInfoEN.UpdDate !=  "")
 {
objRow[conMicroTeachCaseRelaInfo.UpdDate] = objMicroTeachCaseRelaInfoEN.UpdDate; //修改日期
 }
 if (objMicroTeachCaseRelaInfoEN.UpdUser !=  "")
 {
objRow[conMicroTeachCaseRelaInfo.UpdUser] = objMicroTeachCaseRelaInfoEN.UpdUser; //修改人
 }
 if (objMicroTeachCaseRelaInfoEN.Memo !=  "")
 {
objRow[conMicroTeachCaseRelaInfo.Memo] = objMicroTeachCaseRelaInfoEN.Memo; //备注
 }
objDS.Tables[clsMicroTeachCaseRelaInfoEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsMicroTeachCaseRelaInfoEN._CurrTabName);
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
 /// <param name = "objMicroTeachCaseRelaInfoEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsMicroTeachCaseRelaInfoEN objMicroTeachCaseRelaInfoEN)
{
 objMicroTeachCaseRelaInfoEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objMicroTeachCaseRelaInfoEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objMicroTeachCaseRelaInfoEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objMicroTeachCaseRelaInfoEN.FuncModuleId  ==  "")
 {
 objMicroTeachCaseRelaInfoEN.FuncModuleId = null;
 }
 if (objMicroTeachCaseRelaInfoEN.FuncModuleId !=  null)
 {
 arrFieldListForInsert.Add(conMicroTeachCaseRelaInfo.FuncModuleId);
 var strFuncModuleId = objMicroTeachCaseRelaInfoEN.FuncModuleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncModuleId + "'");
 }
 
 if (objMicroTeachCaseRelaInfoEN.IdMicroteachCase  ==  "")
 {
 objMicroTeachCaseRelaInfoEN.IdMicroteachCase = null;
 }
 if (objMicroTeachCaseRelaInfoEN.IdMicroteachCase !=  null)
 {
 arrFieldListForInsert.Add(conMicroTeachCaseRelaInfo.IdMicroteachCase);
 var strIdMicroteachCase = objMicroTeachCaseRelaInfoEN.IdMicroteachCase.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdMicroteachCase + "'");
 }
 
 if (objMicroTeachCaseRelaInfoEN.IdResource  ==  "")
 {
 objMicroTeachCaseRelaInfoEN.IdResource = null;
 }
 if (objMicroTeachCaseRelaInfoEN.IdResource !=  null)
 {
 arrFieldListForInsert.Add(conMicroTeachCaseRelaInfo.IdResource);
 var strIdResource = objMicroTeachCaseRelaInfoEN.IdResource.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdResource + "'");
 }
 
 if (objMicroTeachCaseRelaInfoEN.IdMicroTeachCaseRelaInfoType !=  null)
 {
 arrFieldListForInsert.Add(conMicroTeachCaseRelaInfo.IdMicroTeachCaseRelaInfoType);
 var strIdMicroTeachCaseRelaInfoType = objMicroTeachCaseRelaInfoEN.IdMicroTeachCaseRelaInfoType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdMicroTeachCaseRelaInfoType + "'");
 }
 
 arrFieldListForInsert.Add(conMicroTeachCaseRelaInfo.IsVisible);
 arrValueListForInsert.Add("'" + (objMicroTeachCaseRelaInfoEN.IsVisible  ==  false ? "0" : "1") + "'");
 
 if (objMicroTeachCaseRelaInfoEN.BrowseCount !=  null)
 {
 arrFieldListForInsert.Add(conMicroTeachCaseRelaInfo.BrowseCount);
 arrValueListForInsert.Add(objMicroTeachCaseRelaInfoEN.BrowseCount.ToString());
 }
 
 if (objMicroTeachCaseRelaInfoEN.Flag !=  null)
 {
 arrFieldListForInsert.Add(conMicroTeachCaseRelaInfo.Flag);
 var strFlag = objMicroTeachCaseRelaInfoEN.Flag.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFlag + "'");
 }
 
 if (objMicroTeachCaseRelaInfoEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conMicroTeachCaseRelaInfo.UpdDate);
 var strUpdDate = objMicroTeachCaseRelaInfoEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objMicroTeachCaseRelaInfoEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conMicroTeachCaseRelaInfo.UpdUser);
 var strUpdUser = objMicroTeachCaseRelaInfoEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objMicroTeachCaseRelaInfoEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conMicroTeachCaseRelaInfo.Memo);
 var strMemo = objMicroTeachCaseRelaInfoEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into MicroTeachCaseRelaInfo");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsMicroTeachCaseRelaInfoDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objMicroTeachCaseRelaInfoEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsMicroTeachCaseRelaInfoEN objMicroTeachCaseRelaInfoEN)
{
 objMicroTeachCaseRelaInfoEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objMicroTeachCaseRelaInfoEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objMicroTeachCaseRelaInfoEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objMicroTeachCaseRelaInfoEN.FuncModuleId  ==  "")
 {
 objMicroTeachCaseRelaInfoEN.FuncModuleId = null;
 }
 if (objMicroTeachCaseRelaInfoEN.FuncModuleId !=  null)
 {
 arrFieldListForInsert.Add(conMicroTeachCaseRelaInfo.FuncModuleId);
 var strFuncModuleId = objMicroTeachCaseRelaInfoEN.FuncModuleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncModuleId + "'");
 }
 
 if (objMicroTeachCaseRelaInfoEN.IdMicroteachCase  ==  "")
 {
 objMicroTeachCaseRelaInfoEN.IdMicroteachCase = null;
 }
 if (objMicroTeachCaseRelaInfoEN.IdMicroteachCase !=  null)
 {
 arrFieldListForInsert.Add(conMicroTeachCaseRelaInfo.IdMicroteachCase);
 var strIdMicroteachCase = objMicroTeachCaseRelaInfoEN.IdMicroteachCase.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdMicroteachCase + "'");
 }
 
 if (objMicroTeachCaseRelaInfoEN.IdResource  ==  "")
 {
 objMicroTeachCaseRelaInfoEN.IdResource = null;
 }
 if (objMicroTeachCaseRelaInfoEN.IdResource !=  null)
 {
 arrFieldListForInsert.Add(conMicroTeachCaseRelaInfo.IdResource);
 var strIdResource = objMicroTeachCaseRelaInfoEN.IdResource.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdResource + "'");
 }
 
 if (objMicroTeachCaseRelaInfoEN.IdMicroTeachCaseRelaInfoType !=  null)
 {
 arrFieldListForInsert.Add(conMicroTeachCaseRelaInfo.IdMicroTeachCaseRelaInfoType);
 var strIdMicroTeachCaseRelaInfoType = objMicroTeachCaseRelaInfoEN.IdMicroTeachCaseRelaInfoType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdMicroTeachCaseRelaInfoType + "'");
 }
 
 arrFieldListForInsert.Add(conMicroTeachCaseRelaInfo.IsVisible);
 arrValueListForInsert.Add("'" + (objMicroTeachCaseRelaInfoEN.IsVisible  ==  false ? "0" : "1") + "'");
 
 if (objMicroTeachCaseRelaInfoEN.BrowseCount !=  null)
 {
 arrFieldListForInsert.Add(conMicroTeachCaseRelaInfo.BrowseCount);
 arrValueListForInsert.Add(objMicroTeachCaseRelaInfoEN.BrowseCount.ToString());
 }
 
 if (objMicroTeachCaseRelaInfoEN.Flag !=  null)
 {
 arrFieldListForInsert.Add(conMicroTeachCaseRelaInfo.Flag);
 var strFlag = objMicroTeachCaseRelaInfoEN.Flag.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFlag + "'");
 }
 
 if (objMicroTeachCaseRelaInfoEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conMicroTeachCaseRelaInfo.UpdDate);
 var strUpdDate = objMicroTeachCaseRelaInfoEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objMicroTeachCaseRelaInfoEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conMicroTeachCaseRelaInfo.UpdUser);
 var strUpdUser = objMicroTeachCaseRelaInfoEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objMicroTeachCaseRelaInfoEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conMicroTeachCaseRelaInfo.Memo);
 var strMemo = objMicroTeachCaseRelaInfoEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into MicroTeachCaseRelaInfo");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsMicroTeachCaseRelaInfoDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString()).Rows[0][0].ToString();
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objMicroTeachCaseRelaInfoEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsMicroTeachCaseRelaInfoEN objMicroTeachCaseRelaInfoEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objMicroTeachCaseRelaInfoEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objMicroTeachCaseRelaInfoEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objMicroTeachCaseRelaInfoEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objMicroTeachCaseRelaInfoEN.FuncModuleId  ==  "")
 {
 objMicroTeachCaseRelaInfoEN.FuncModuleId = null;
 }
 if (objMicroTeachCaseRelaInfoEN.FuncModuleId !=  null)
 {
 arrFieldListForInsert.Add(conMicroTeachCaseRelaInfo.FuncModuleId);
 var strFuncModuleId = objMicroTeachCaseRelaInfoEN.FuncModuleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncModuleId + "'");
 }
 
 if (objMicroTeachCaseRelaInfoEN.IdMicroteachCase  ==  "")
 {
 objMicroTeachCaseRelaInfoEN.IdMicroteachCase = null;
 }
 if (objMicroTeachCaseRelaInfoEN.IdMicroteachCase !=  null)
 {
 arrFieldListForInsert.Add(conMicroTeachCaseRelaInfo.IdMicroteachCase);
 var strIdMicroteachCase = objMicroTeachCaseRelaInfoEN.IdMicroteachCase.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdMicroteachCase + "'");
 }
 
 if (objMicroTeachCaseRelaInfoEN.IdResource  ==  "")
 {
 objMicroTeachCaseRelaInfoEN.IdResource = null;
 }
 if (objMicroTeachCaseRelaInfoEN.IdResource !=  null)
 {
 arrFieldListForInsert.Add(conMicroTeachCaseRelaInfo.IdResource);
 var strIdResource = objMicroTeachCaseRelaInfoEN.IdResource.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdResource + "'");
 }
 
 if (objMicroTeachCaseRelaInfoEN.IdMicroTeachCaseRelaInfoType !=  null)
 {
 arrFieldListForInsert.Add(conMicroTeachCaseRelaInfo.IdMicroTeachCaseRelaInfoType);
 var strIdMicroTeachCaseRelaInfoType = objMicroTeachCaseRelaInfoEN.IdMicroTeachCaseRelaInfoType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdMicroTeachCaseRelaInfoType + "'");
 }
 
 arrFieldListForInsert.Add(conMicroTeachCaseRelaInfo.IsVisible);
 arrValueListForInsert.Add("'" + (objMicroTeachCaseRelaInfoEN.IsVisible  ==  false ? "0" : "1") + "'");
 
 if (objMicroTeachCaseRelaInfoEN.BrowseCount !=  null)
 {
 arrFieldListForInsert.Add(conMicroTeachCaseRelaInfo.BrowseCount);
 arrValueListForInsert.Add(objMicroTeachCaseRelaInfoEN.BrowseCount.ToString());
 }
 
 if (objMicroTeachCaseRelaInfoEN.Flag !=  null)
 {
 arrFieldListForInsert.Add(conMicroTeachCaseRelaInfo.Flag);
 var strFlag = objMicroTeachCaseRelaInfoEN.Flag.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFlag + "'");
 }
 
 if (objMicroTeachCaseRelaInfoEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conMicroTeachCaseRelaInfo.UpdDate);
 var strUpdDate = objMicroTeachCaseRelaInfoEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objMicroTeachCaseRelaInfoEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conMicroTeachCaseRelaInfo.UpdUser);
 var strUpdUser = objMicroTeachCaseRelaInfoEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objMicroTeachCaseRelaInfoEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conMicroTeachCaseRelaInfo.Memo);
 var strMemo = objMicroTeachCaseRelaInfoEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into MicroTeachCaseRelaInfo");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsMicroTeachCaseRelaInfoDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString(), objSqlConnection, objSqlTransaction).Rows[0][0].ToString();
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objMicroTeachCaseRelaInfoEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsMicroTeachCaseRelaInfoEN objMicroTeachCaseRelaInfoEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objMicroTeachCaseRelaInfoEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objMicroTeachCaseRelaInfoEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objMicroTeachCaseRelaInfoEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objMicroTeachCaseRelaInfoEN.FuncModuleId  ==  "")
 {
 objMicroTeachCaseRelaInfoEN.FuncModuleId = null;
 }
 if (objMicroTeachCaseRelaInfoEN.FuncModuleId !=  null)
 {
 arrFieldListForInsert.Add(conMicroTeachCaseRelaInfo.FuncModuleId);
 var strFuncModuleId = objMicroTeachCaseRelaInfoEN.FuncModuleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncModuleId + "'");
 }
 
 if (objMicroTeachCaseRelaInfoEN.IdMicroteachCase  ==  "")
 {
 objMicroTeachCaseRelaInfoEN.IdMicroteachCase = null;
 }
 if (objMicroTeachCaseRelaInfoEN.IdMicroteachCase !=  null)
 {
 arrFieldListForInsert.Add(conMicroTeachCaseRelaInfo.IdMicroteachCase);
 var strIdMicroteachCase = objMicroTeachCaseRelaInfoEN.IdMicroteachCase.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdMicroteachCase + "'");
 }
 
 if (objMicroTeachCaseRelaInfoEN.IdResource  ==  "")
 {
 objMicroTeachCaseRelaInfoEN.IdResource = null;
 }
 if (objMicroTeachCaseRelaInfoEN.IdResource !=  null)
 {
 arrFieldListForInsert.Add(conMicroTeachCaseRelaInfo.IdResource);
 var strIdResource = objMicroTeachCaseRelaInfoEN.IdResource.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdResource + "'");
 }
 
 if (objMicroTeachCaseRelaInfoEN.IdMicroTeachCaseRelaInfoType !=  null)
 {
 arrFieldListForInsert.Add(conMicroTeachCaseRelaInfo.IdMicroTeachCaseRelaInfoType);
 var strIdMicroTeachCaseRelaInfoType = objMicroTeachCaseRelaInfoEN.IdMicroTeachCaseRelaInfoType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdMicroTeachCaseRelaInfoType + "'");
 }
 
 arrFieldListForInsert.Add(conMicroTeachCaseRelaInfo.IsVisible);
 arrValueListForInsert.Add("'" + (objMicroTeachCaseRelaInfoEN.IsVisible  ==  false ? "0" : "1") + "'");
 
 if (objMicroTeachCaseRelaInfoEN.BrowseCount !=  null)
 {
 arrFieldListForInsert.Add(conMicroTeachCaseRelaInfo.BrowseCount);
 arrValueListForInsert.Add(objMicroTeachCaseRelaInfoEN.BrowseCount.ToString());
 }
 
 if (objMicroTeachCaseRelaInfoEN.Flag !=  null)
 {
 arrFieldListForInsert.Add(conMicroTeachCaseRelaInfo.Flag);
 var strFlag = objMicroTeachCaseRelaInfoEN.Flag.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFlag + "'");
 }
 
 if (objMicroTeachCaseRelaInfoEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conMicroTeachCaseRelaInfo.UpdDate);
 var strUpdDate = objMicroTeachCaseRelaInfoEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objMicroTeachCaseRelaInfoEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conMicroTeachCaseRelaInfo.UpdUser);
 var strUpdUser = objMicroTeachCaseRelaInfoEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objMicroTeachCaseRelaInfoEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conMicroTeachCaseRelaInfo.Memo);
 var strMemo = objMicroTeachCaseRelaInfoEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into MicroTeachCaseRelaInfo");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsMicroTeachCaseRelaInfoDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewMicroTeachCaseRelaInfos(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsMicroTeachCaseRelaInfoDA.GetSpecSQLObj();
strSQL = "Select * from MicroTeachCaseRelaInfo where IdMicroTeachCaseRelaInfo = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "MicroTeachCaseRelaInfo");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
long lngIdMicroTeachCaseRelaInfo = TransNullToInt(oRow[conMicroTeachCaseRelaInfo.IdMicroTeachCaseRelaInfo].ToString().Trim());
if (IsExist(lngIdMicroTeachCaseRelaInfo))
{
 string strResult = "关键字变量值为:" + string.Format("IdMicroTeachCaseRelaInfo = {0}", lngIdMicroTeachCaseRelaInfo) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsMicroTeachCaseRelaInfoEN._CurrTabName ].NewRow();
objRow[conMicroTeachCaseRelaInfo.FuncModuleId] = oRow[conMicroTeachCaseRelaInfo.FuncModuleId].ToString().Trim(); //功能模块Id
objRow[conMicroTeachCaseRelaInfo.IdMicroteachCase] = oRow[conMicroTeachCaseRelaInfo.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objRow[conMicroTeachCaseRelaInfo.IdResource] = oRow[conMicroTeachCaseRelaInfo.IdResource].ToString().Trim(); //资源流水号
objRow[conMicroTeachCaseRelaInfo.IdMicroTeachCaseRelaInfoType] = oRow[conMicroTeachCaseRelaInfo.IdMicroTeachCaseRelaInfoType].ToString().Trim(); //微格案例相关信息类型流水号
objRow[conMicroTeachCaseRelaInfo.IsVisible] = oRow[conMicroTeachCaseRelaInfo.IsVisible].ToString().Trim(); //是否显示
objRow[conMicroTeachCaseRelaInfo.BrowseCount] = oRow[conMicroTeachCaseRelaInfo.BrowseCount].ToString().Trim(); //浏览次数
objRow[conMicroTeachCaseRelaInfo.Flag] = oRow[conMicroTeachCaseRelaInfo.Flag].ToString().Trim(); //标志
objRow[conMicroTeachCaseRelaInfo.UpdDate] = oRow[conMicroTeachCaseRelaInfo.UpdDate].ToString().Trim(); //修改日期
objRow[conMicroTeachCaseRelaInfo.UpdUser] = oRow[conMicroTeachCaseRelaInfo.UpdUser].ToString().Trim(); //修改人
objRow[conMicroTeachCaseRelaInfo.Memo] = oRow[conMicroTeachCaseRelaInfo.Memo].ToString().Trim(); //备注
 objDS.Tables[clsMicroTeachCaseRelaInfoEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsMicroTeachCaseRelaInfoEN._CurrTabName);
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
 /// <param name = "objMicroTeachCaseRelaInfoEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsMicroTeachCaseRelaInfoEN objMicroTeachCaseRelaInfoEN)
{
 objMicroTeachCaseRelaInfoEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objMicroTeachCaseRelaInfoEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objMicroTeachCaseRelaInfoEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsMicroTeachCaseRelaInfoDA.GetSpecSQLObj();
strSQL = "Select * from MicroTeachCaseRelaInfo where IdMicroTeachCaseRelaInfo = " + ""+ objMicroTeachCaseRelaInfoEN.IdMicroTeachCaseRelaInfo+"";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsMicroTeachCaseRelaInfoEN._CurrTabName);
if (objDS.Tables[clsMicroTeachCaseRelaInfoEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:IdMicroTeachCaseRelaInfo = " + ""+ objMicroTeachCaseRelaInfoEN.IdMicroTeachCaseRelaInfo+"");
return false;
}
objRow = objDS.Tables[clsMicroTeachCaseRelaInfoEN._CurrTabName].Rows[0];
 if (objMicroTeachCaseRelaInfoEN.IsUpdated(conMicroTeachCaseRelaInfo.FuncModuleId))
 {
objRow[conMicroTeachCaseRelaInfo.FuncModuleId] = objMicroTeachCaseRelaInfoEN.FuncModuleId; //功能模块Id
 }
 if (objMicroTeachCaseRelaInfoEN.IsUpdated(conMicroTeachCaseRelaInfo.IdMicroteachCase))
 {
objRow[conMicroTeachCaseRelaInfo.IdMicroteachCase] = objMicroTeachCaseRelaInfoEN.IdMicroteachCase; //微格教学案例流水号
 }
 if (objMicroTeachCaseRelaInfoEN.IsUpdated(conMicroTeachCaseRelaInfo.IdResource))
 {
objRow[conMicroTeachCaseRelaInfo.IdResource] = objMicroTeachCaseRelaInfoEN.IdResource; //资源流水号
 }
 if (objMicroTeachCaseRelaInfoEN.IsUpdated(conMicroTeachCaseRelaInfo.IdMicroTeachCaseRelaInfoType))
 {
objRow[conMicroTeachCaseRelaInfo.IdMicroTeachCaseRelaInfoType] = objMicroTeachCaseRelaInfoEN.IdMicroTeachCaseRelaInfoType; //微格案例相关信息类型流水号
 }
 if (objMicroTeachCaseRelaInfoEN.IsUpdated(conMicroTeachCaseRelaInfo.IsVisible))
 {
objRow[conMicroTeachCaseRelaInfo.IsVisible] = objMicroTeachCaseRelaInfoEN.IsVisible; //是否显示
 }
 if (objMicroTeachCaseRelaInfoEN.IsUpdated(conMicroTeachCaseRelaInfo.BrowseCount))
 {
objRow[conMicroTeachCaseRelaInfo.BrowseCount] = objMicroTeachCaseRelaInfoEN.BrowseCount; //浏览次数
 }
 if (objMicroTeachCaseRelaInfoEN.IsUpdated(conMicroTeachCaseRelaInfo.Flag))
 {
objRow[conMicroTeachCaseRelaInfo.Flag] = objMicroTeachCaseRelaInfoEN.Flag; //标志
 }
 if (objMicroTeachCaseRelaInfoEN.IsUpdated(conMicroTeachCaseRelaInfo.UpdDate))
 {
objRow[conMicroTeachCaseRelaInfo.UpdDate] = objMicroTeachCaseRelaInfoEN.UpdDate; //修改日期
 }
 if (objMicroTeachCaseRelaInfoEN.IsUpdated(conMicroTeachCaseRelaInfo.UpdUser))
 {
objRow[conMicroTeachCaseRelaInfo.UpdUser] = objMicroTeachCaseRelaInfoEN.UpdUser; //修改人
 }
 if (objMicroTeachCaseRelaInfoEN.IsUpdated(conMicroTeachCaseRelaInfo.Memo))
 {
objRow[conMicroTeachCaseRelaInfo.Memo] = objMicroTeachCaseRelaInfoEN.Memo; //备注
 }
try
{
objDA.Update(objDS, clsMicroTeachCaseRelaInfoEN._CurrTabName);
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
 /// <param name = "objMicroTeachCaseRelaInfoEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsMicroTeachCaseRelaInfoEN objMicroTeachCaseRelaInfoEN)
{
 objMicroTeachCaseRelaInfoEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objMicroTeachCaseRelaInfoEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objMicroTeachCaseRelaInfoEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsMicroTeachCaseRelaInfoDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update MicroTeachCaseRelaInfo Set ");
 
 if (objMicroTeachCaseRelaInfoEN.IsUpdated(conMicroTeachCaseRelaInfo.FuncModuleId))
 {
 if (objMicroTeachCaseRelaInfoEN.FuncModuleId  ==  "")
 {
 objMicroTeachCaseRelaInfoEN.FuncModuleId = null;
 }
 if (objMicroTeachCaseRelaInfoEN.FuncModuleId !=  null)
 {
 var strFuncModuleId = objMicroTeachCaseRelaInfoEN.FuncModuleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFuncModuleId, conMicroTeachCaseRelaInfo.FuncModuleId); //功能模块Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conMicroTeachCaseRelaInfo.FuncModuleId); //功能模块Id
 }
 }
 
 if (objMicroTeachCaseRelaInfoEN.IsUpdated(conMicroTeachCaseRelaInfo.IdMicroteachCase))
 {
 if (objMicroTeachCaseRelaInfoEN.IdMicroteachCase  ==  "")
 {
 objMicroTeachCaseRelaInfoEN.IdMicroteachCase = null;
 }
 if (objMicroTeachCaseRelaInfoEN.IdMicroteachCase !=  null)
 {
 var strIdMicroteachCase = objMicroTeachCaseRelaInfoEN.IdMicroteachCase.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdMicroteachCase, conMicroTeachCaseRelaInfo.IdMicroteachCase); //微格教学案例流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conMicroTeachCaseRelaInfo.IdMicroteachCase); //微格教学案例流水号
 }
 }
 
 if (objMicroTeachCaseRelaInfoEN.IsUpdated(conMicroTeachCaseRelaInfo.IdResource))
 {
 if (objMicroTeachCaseRelaInfoEN.IdResource  ==  "")
 {
 objMicroTeachCaseRelaInfoEN.IdResource = null;
 }
 if (objMicroTeachCaseRelaInfoEN.IdResource !=  null)
 {
 var strIdResource = objMicroTeachCaseRelaInfoEN.IdResource.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdResource, conMicroTeachCaseRelaInfo.IdResource); //资源流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conMicroTeachCaseRelaInfo.IdResource); //资源流水号
 }
 }
 
 if (objMicroTeachCaseRelaInfoEN.IsUpdated(conMicroTeachCaseRelaInfo.IdMicroTeachCaseRelaInfoType))
 {
 if (objMicroTeachCaseRelaInfoEN.IdMicroTeachCaseRelaInfoType !=  null)
 {
 var strIdMicroTeachCaseRelaInfoType = objMicroTeachCaseRelaInfoEN.IdMicroTeachCaseRelaInfoType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdMicroTeachCaseRelaInfoType, conMicroTeachCaseRelaInfo.IdMicroTeachCaseRelaInfoType); //微格案例相关信息类型流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conMicroTeachCaseRelaInfo.IdMicroTeachCaseRelaInfoType); //微格案例相关信息类型流水号
 }
 }
 
 if (objMicroTeachCaseRelaInfoEN.IsUpdated(conMicroTeachCaseRelaInfo.IsVisible))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objMicroTeachCaseRelaInfoEN.IsVisible == true?"1":"0", conMicroTeachCaseRelaInfo.IsVisible); //是否显示
 }
 
 if (objMicroTeachCaseRelaInfoEN.IsUpdated(conMicroTeachCaseRelaInfo.BrowseCount))
 {
 if (objMicroTeachCaseRelaInfoEN.BrowseCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objMicroTeachCaseRelaInfoEN.BrowseCount, conMicroTeachCaseRelaInfo.BrowseCount); //浏览次数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conMicroTeachCaseRelaInfo.BrowseCount); //浏览次数
 }
 }
 
 if (objMicroTeachCaseRelaInfoEN.IsUpdated(conMicroTeachCaseRelaInfo.Flag))
 {
 if (objMicroTeachCaseRelaInfoEN.Flag !=  null)
 {
 var strFlag = objMicroTeachCaseRelaInfoEN.Flag.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFlag, conMicroTeachCaseRelaInfo.Flag); //标志
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conMicroTeachCaseRelaInfo.Flag); //标志
 }
 }
 
 if (objMicroTeachCaseRelaInfoEN.IsUpdated(conMicroTeachCaseRelaInfo.UpdDate))
 {
 if (objMicroTeachCaseRelaInfoEN.UpdDate !=  null)
 {
 var strUpdDate = objMicroTeachCaseRelaInfoEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conMicroTeachCaseRelaInfo.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conMicroTeachCaseRelaInfo.UpdDate); //修改日期
 }
 }
 
 if (objMicroTeachCaseRelaInfoEN.IsUpdated(conMicroTeachCaseRelaInfo.UpdUser))
 {
 if (objMicroTeachCaseRelaInfoEN.UpdUser !=  null)
 {
 var strUpdUser = objMicroTeachCaseRelaInfoEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conMicroTeachCaseRelaInfo.UpdUser); //修改人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conMicroTeachCaseRelaInfo.UpdUser); //修改人
 }
 }
 
 if (objMicroTeachCaseRelaInfoEN.IsUpdated(conMicroTeachCaseRelaInfo.Memo))
 {
 if (objMicroTeachCaseRelaInfoEN.Memo !=  null)
 {
 var strMemo = objMicroTeachCaseRelaInfoEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conMicroTeachCaseRelaInfo.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conMicroTeachCaseRelaInfo.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where IdMicroTeachCaseRelaInfo = {0}", objMicroTeachCaseRelaInfoEN.IdMicroTeachCaseRelaInfo); 
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
 /// <param name = "objMicroTeachCaseRelaInfoEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsMicroTeachCaseRelaInfoEN objMicroTeachCaseRelaInfoEN, string strCondition)
{
 objMicroTeachCaseRelaInfoEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objMicroTeachCaseRelaInfoEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objMicroTeachCaseRelaInfoEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsMicroTeachCaseRelaInfoDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update MicroTeachCaseRelaInfo Set ");
 
 if (objMicroTeachCaseRelaInfoEN.IsUpdated(conMicroTeachCaseRelaInfo.FuncModuleId))
 {
 if (objMicroTeachCaseRelaInfoEN.FuncModuleId  ==  "")
 {
 objMicroTeachCaseRelaInfoEN.FuncModuleId = null;
 }
 if (objMicroTeachCaseRelaInfoEN.FuncModuleId !=  null)
 {
 var strFuncModuleId = objMicroTeachCaseRelaInfoEN.FuncModuleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FuncModuleId = '{0}',", strFuncModuleId); //功能模块Id
 }
 else
 {
 sbSQL.Append(" FuncModuleId = null,"); //功能模块Id
 }
 }
 
 if (objMicroTeachCaseRelaInfoEN.IsUpdated(conMicroTeachCaseRelaInfo.IdMicroteachCase))
 {
 if (objMicroTeachCaseRelaInfoEN.IdMicroteachCase  ==  "")
 {
 objMicroTeachCaseRelaInfoEN.IdMicroteachCase = null;
 }
 if (objMicroTeachCaseRelaInfoEN.IdMicroteachCase !=  null)
 {
 var strIdMicroteachCase = objMicroTeachCaseRelaInfoEN.IdMicroteachCase.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdMicroteachCase = '{0}',", strIdMicroteachCase); //微格教学案例流水号
 }
 else
 {
 sbSQL.Append(" IdMicroteachCase = null,"); //微格教学案例流水号
 }
 }
 
 if (objMicroTeachCaseRelaInfoEN.IsUpdated(conMicroTeachCaseRelaInfo.IdResource))
 {
 if (objMicroTeachCaseRelaInfoEN.IdResource  ==  "")
 {
 objMicroTeachCaseRelaInfoEN.IdResource = null;
 }
 if (objMicroTeachCaseRelaInfoEN.IdResource !=  null)
 {
 var strIdResource = objMicroTeachCaseRelaInfoEN.IdResource.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdResource = '{0}',", strIdResource); //资源流水号
 }
 else
 {
 sbSQL.Append(" IdResource = null,"); //资源流水号
 }
 }
 
 if (objMicroTeachCaseRelaInfoEN.IsUpdated(conMicroTeachCaseRelaInfo.IdMicroTeachCaseRelaInfoType))
 {
 if (objMicroTeachCaseRelaInfoEN.IdMicroTeachCaseRelaInfoType !=  null)
 {
 var strIdMicroTeachCaseRelaInfoType = objMicroTeachCaseRelaInfoEN.IdMicroTeachCaseRelaInfoType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdMicroTeachCaseRelaInfoType = '{0}',", strIdMicroTeachCaseRelaInfoType); //微格案例相关信息类型流水号
 }
 else
 {
 sbSQL.Append(" IdMicroTeachCaseRelaInfoType = null,"); //微格案例相关信息类型流水号
 }
 }
 
 if (objMicroTeachCaseRelaInfoEN.IsUpdated(conMicroTeachCaseRelaInfo.IsVisible))
 {
 sbSQL.AppendFormat(" IsVisible = '{0}',", objMicroTeachCaseRelaInfoEN.IsVisible == true?"1":"0"); //是否显示
 }
 
 if (objMicroTeachCaseRelaInfoEN.IsUpdated(conMicroTeachCaseRelaInfo.BrowseCount))
 {
 sbSQL.AppendFormat(" BrowseCount = {0},", objMicroTeachCaseRelaInfoEN.BrowseCount); //浏览次数
 }
 
 if (objMicroTeachCaseRelaInfoEN.IsUpdated(conMicroTeachCaseRelaInfo.Flag))
 {
 if (objMicroTeachCaseRelaInfoEN.Flag !=  null)
 {
 var strFlag = objMicroTeachCaseRelaInfoEN.Flag.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Flag = '{0}',", strFlag); //标志
 }
 else
 {
 sbSQL.Append(" Flag = null,"); //标志
 }
 }
 
 if (objMicroTeachCaseRelaInfoEN.IsUpdated(conMicroTeachCaseRelaInfo.UpdDate))
 {
 if (objMicroTeachCaseRelaInfoEN.UpdDate !=  null)
 {
 var strUpdDate = objMicroTeachCaseRelaInfoEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objMicroTeachCaseRelaInfoEN.IsUpdated(conMicroTeachCaseRelaInfo.UpdUser))
 {
 if (objMicroTeachCaseRelaInfoEN.UpdUser !=  null)
 {
 var strUpdUser = objMicroTeachCaseRelaInfoEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改人
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改人
 }
 }
 
 if (objMicroTeachCaseRelaInfoEN.IsUpdated(conMicroTeachCaseRelaInfo.Memo))
 {
 if (objMicroTeachCaseRelaInfoEN.Memo !=  null)
 {
 var strMemo = objMicroTeachCaseRelaInfoEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objMicroTeachCaseRelaInfoEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsMicroTeachCaseRelaInfoEN objMicroTeachCaseRelaInfoEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objMicroTeachCaseRelaInfoEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objMicroTeachCaseRelaInfoEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objMicroTeachCaseRelaInfoEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsMicroTeachCaseRelaInfoDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update MicroTeachCaseRelaInfo Set ");
 
 if (objMicroTeachCaseRelaInfoEN.IsUpdated(conMicroTeachCaseRelaInfo.FuncModuleId))
 {
 if (objMicroTeachCaseRelaInfoEN.FuncModuleId  ==  "")
 {
 objMicroTeachCaseRelaInfoEN.FuncModuleId = null;
 }
 if (objMicroTeachCaseRelaInfoEN.FuncModuleId !=  null)
 {
 var strFuncModuleId = objMicroTeachCaseRelaInfoEN.FuncModuleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FuncModuleId = '{0}',", strFuncModuleId); //功能模块Id
 }
 else
 {
 sbSQL.Append(" FuncModuleId = null,"); //功能模块Id
 }
 }
 
 if (objMicroTeachCaseRelaInfoEN.IsUpdated(conMicroTeachCaseRelaInfo.IdMicroteachCase))
 {
 if (objMicroTeachCaseRelaInfoEN.IdMicroteachCase  ==  "")
 {
 objMicroTeachCaseRelaInfoEN.IdMicroteachCase = null;
 }
 if (objMicroTeachCaseRelaInfoEN.IdMicroteachCase !=  null)
 {
 var strIdMicroteachCase = objMicroTeachCaseRelaInfoEN.IdMicroteachCase.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdMicroteachCase = '{0}',", strIdMicroteachCase); //微格教学案例流水号
 }
 else
 {
 sbSQL.Append(" IdMicroteachCase = null,"); //微格教学案例流水号
 }
 }
 
 if (objMicroTeachCaseRelaInfoEN.IsUpdated(conMicroTeachCaseRelaInfo.IdResource))
 {
 if (objMicroTeachCaseRelaInfoEN.IdResource  ==  "")
 {
 objMicroTeachCaseRelaInfoEN.IdResource = null;
 }
 if (objMicroTeachCaseRelaInfoEN.IdResource !=  null)
 {
 var strIdResource = objMicroTeachCaseRelaInfoEN.IdResource.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdResource = '{0}',", strIdResource); //资源流水号
 }
 else
 {
 sbSQL.Append(" IdResource = null,"); //资源流水号
 }
 }
 
 if (objMicroTeachCaseRelaInfoEN.IsUpdated(conMicroTeachCaseRelaInfo.IdMicroTeachCaseRelaInfoType))
 {
 if (objMicroTeachCaseRelaInfoEN.IdMicroTeachCaseRelaInfoType !=  null)
 {
 var strIdMicroTeachCaseRelaInfoType = objMicroTeachCaseRelaInfoEN.IdMicroTeachCaseRelaInfoType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdMicroTeachCaseRelaInfoType = '{0}',", strIdMicroTeachCaseRelaInfoType); //微格案例相关信息类型流水号
 }
 else
 {
 sbSQL.Append(" IdMicroTeachCaseRelaInfoType = null,"); //微格案例相关信息类型流水号
 }
 }
 
 if (objMicroTeachCaseRelaInfoEN.IsUpdated(conMicroTeachCaseRelaInfo.IsVisible))
 {
 sbSQL.AppendFormat(" IsVisible = '{0}',", objMicroTeachCaseRelaInfoEN.IsVisible == true?"1":"0"); //是否显示
 }
 
 if (objMicroTeachCaseRelaInfoEN.IsUpdated(conMicroTeachCaseRelaInfo.BrowseCount))
 {
 sbSQL.AppendFormat(" BrowseCount = {0},", objMicroTeachCaseRelaInfoEN.BrowseCount); //浏览次数
 }
 
 if (objMicroTeachCaseRelaInfoEN.IsUpdated(conMicroTeachCaseRelaInfo.Flag))
 {
 if (objMicroTeachCaseRelaInfoEN.Flag !=  null)
 {
 var strFlag = objMicroTeachCaseRelaInfoEN.Flag.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Flag = '{0}',", strFlag); //标志
 }
 else
 {
 sbSQL.Append(" Flag = null,"); //标志
 }
 }
 
 if (objMicroTeachCaseRelaInfoEN.IsUpdated(conMicroTeachCaseRelaInfo.UpdDate))
 {
 if (objMicroTeachCaseRelaInfoEN.UpdDate !=  null)
 {
 var strUpdDate = objMicroTeachCaseRelaInfoEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objMicroTeachCaseRelaInfoEN.IsUpdated(conMicroTeachCaseRelaInfo.UpdUser))
 {
 if (objMicroTeachCaseRelaInfoEN.UpdUser !=  null)
 {
 var strUpdUser = objMicroTeachCaseRelaInfoEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改人
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改人
 }
 }
 
 if (objMicroTeachCaseRelaInfoEN.IsUpdated(conMicroTeachCaseRelaInfo.Memo))
 {
 if (objMicroTeachCaseRelaInfoEN.Memo !=  null)
 {
 var strMemo = objMicroTeachCaseRelaInfoEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objMicroTeachCaseRelaInfoEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsMicroTeachCaseRelaInfoEN objMicroTeachCaseRelaInfoEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objMicroTeachCaseRelaInfoEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objMicroTeachCaseRelaInfoEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objMicroTeachCaseRelaInfoEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsMicroTeachCaseRelaInfoDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update MicroTeachCaseRelaInfo Set ");
 
 if (objMicroTeachCaseRelaInfoEN.IsUpdated(conMicroTeachCaseRelaInfo.FuncModuleId))
 {
 if (objMicroTeachCaseRelaInfoEN.FuncModuleId  ==  "")
 {
 objMicroTeachCaseRelaInfoEN.FuncModuleId = null;
 }
 if (objMicroTeachCaseRelaInfoEN.FuncModuleId !=  null)
 {
 var strFuncModuleId = objMicroTeachCaseRelaInfoEN.FuncModuleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFuncModuleId, conMicroTeachCaseRelaInfo.FuncModuleId); //功能模块Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conMicroTeachCaseRelaInfo.FuncModuleId); //功能模块Id
 }
 }
 
 if (objMicroTeachCaseRelaInfoEN.IsUpdated(conMicroTeachCaseRelaInfo.IdMicroteachCase))
 {
 if (objMicroTeachCaseRelaInfoEN.IdMicroteachCase  ==  "")
 {
 objMicroTeachCaseRelaInfoEN.IdMicroteachCase = null;
 }
 if (objMicroTeachCaseRelaInfoEN.IdMicroteachCase !=  null)
 {
 var strIdMicroteachCase = objMicroTeachCaseRelaInfoEN.IdMicroteachCase.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdMicroteachCase, conMicroTeachCaseRelaInfo.IdMicroteachCase); //微格教学案例流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conMicroTeachCaseRelaInfo.IdMicroteachCase); //微格教学案例流水号
 }
 }
 
 if (objMicroTeachCaseRelaInfoEN.IsUpdated(conMicroTeachCaseRelaInfo.IdResource))
 {
 if (objMicroTeachCaseRelaInfoEN.IdResource  ==  "")
 {
 objMicroTeachCaseRelaInfoEN.IdResource = null;
 }
 if (objMicroTeachCaseRelaInfoEN.IdResource !=  null)
 {
 var strIdResource = objMicroTeachCaseRelaInfoEN.IdResource.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdResource, conMicroTeachCaseRelaInfo.IdResource); //资源流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conMicroTeachCaseRelaInfo.IdResource); //资源流水号
 }
 }
 
 if (objMicroTeachCaseRelaInfoEN.IsUpdated(conMicroTeachCaseRelaInfo.IdMicroTeachCaseRelaInfoType))
 {
 if (objMicroTeachCaseRelaInfoEN.IdMicroTeachCaseRelaInfoType !=  null)
 {
 var strIdMicroTeachCaseRelaInfoType = objMicroTeachCaseRelaInfoEN.IdMicroTeachCaseRelaInfoType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdMicroTeachCaseRelaInfoType, conMicroTeachCaseRelaInfo.IdMicroTeachCaseRelaInfoType); //微格案例相关信息类型流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conMicroTeachCaseRelaInfo.IdMicroTeachCaseRelaInfoType); //微格案例相关信息类型流水号
 }
 }
 
 if (objMicroTeachCaseRelaInfoEN.IsUpdated(conMicroTeachCaseRelaInfo.IsVisible))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objMicroTeachCaseRelaInfoEN.IsVisible == true?"1":"0", conMicroTeachCaseRelaInfo.IsVisible); //是否显示
 }
 
 if (objMicroTeachCaseRelaInfoEN.IsUpdated(conMicroTeachCaseRelaInfo.BrowseCount))
 {
 if (objMicroTeachCaseRelaInfoEN.BrowseCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objMicroTeachCaseRelaInfoEN.BrowseCount, conMicroTeachCaseRelaInfo.BrowseCount); //浏览次数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conMicroTeachCaseRelaInfo.BrowseCount); //浏览次数
 }
 }
 
 if (objMicroTeachCaseRelaInfoEN.IsUpdated(conMicroTeachCaseRelaInfo.Flag))
 {
 if (objMicroTeachCaseRelaInfoEN.Flag !=  null)
 {
 var strFlag = objMicroTeachCaseRelaInfoEN.Flag.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFlag, conMicroTeachCaseRelaInfo.Flag); //标志
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conMicroTeachCaseRelaInfo.Flag); //标志
 }
 }
 
 if (objMicroTeachCaseRelaInfoEN.IsUpdated(conMicroTeachCaseRelaInfo.UpdDate))
 {
 if (objMicroTeachCaseRelaInfoEN.UpdDate !=  null)
 {
 var strUpdDate = objMicroTeachCaseRelaInfoEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conMicroTeachCaseRelaInfo.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conMicroTeachCaseRelaInfo.UpdDate); //修改日期
 }
 }
 
 if (objMicroTeachCaseRelaInfoEN.IsUpdated(conMicroTeachCaseRelaInfo.UpdUser))
 {
 if (objMicroTeachCaseRelaInfoEN.UpdUser !=  null)
 {
 var strUpdUser = objMicroTeachCaseRelaInfoEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conMicroTeachCaseRelaInfo.UpdUser); //修改人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conMicroTeachCaseRelaInfo.UpdUser); //修改人
 }
 }
 
 if (objMicroTeachCaseRelaInfoEN.IsUpdated(conMicroTeachCaseRelaInfo.Memo))
 {
 if (objMicroTeachCaseRelaInfoEN.Memo !=  null)
 {
 var strMemo = objMicroTeachCaseRelaInfoEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conMicroTeachCaseRelaInfo.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conMicroTeachCaseRelaInfo.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where IdMicroTeachCaseRelaInfo = {0}", objMicroTeachCaseRelaInfoEN.IdMicroTeachCaseRelaInfo); 
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
 /// <param name = "lngIdMicroTeachCaseRelaInfo">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(long lngIdMicroTeachCaseRelaInfo) 
{
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsMicroTeachCaseRelaInfoDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 lngIdMicroTeachCaseRelaInfo,
};
 objSQL.ExecSP("MicroTeachCaseRelaInfo_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "lngIdMicroTeachCaseRelaInfo">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(long lngIdMicroTeachCaseRelaInfo, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsMicroTeachCaseRelaInfoDA.GetSpecSQLObj();
//删除MicroTeachCaseRelaInfo本表中与当前对象有关的记录
strSQL = strSQL + "Delete from MicroTeachCaseRelaInfo where IdMicroTeachCaseRelaInfo = " + ""+ lngIdMicroTeachCaseRelaInfo+"";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelMicroTeachCaseRelaInfo(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsMicroTeachCaseRelaInfoDA.GetSpecSQLObj();
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
//删除MicroTeachCaseRelaInfo本表中与当前对象有关的记录
strSQL = strSQL + "Delete from MicroTeachCaseRelaInfo where IdMicroTeachCaseRelaInfo in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "lngIdMicroTeachCaseRelaInfo">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(long lngIdMicroTeachCaseRelaInfo) 
{
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsMicroTeachCaseRelaInfoDA.GetSpecSQLObj();
//删除MicroTeachCaseRelaInfo本表中与当前对象有关的记录
strSQL = strSQL + "Delete from MicroTeachCaseRelaInfo where IdMicroTeachCaseRelaInfo = " + ""+ lngIdMicroTeachCaseRelaInfo+"";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelMicroTeachCaseRelaInfo(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsMicroTeachCaseRelaInfoDA: DelMicroTeachCaseRelaInfo)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsMicroTeachCaseRelaInfoDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from MicroTeachCaseRelaInfo where " + strCondition ;
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
public bool DelMicroTeachCaseRelaInfoWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsMicroTeachCaseRelaInfoDA: DelMicroTeachCaseRelaInfoWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsMicroTeachCaseRelaInfoDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from MicroTeachCaseRelaInfo where " + strCondition ;
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
 /// <param name = "objMicroTeachCaseRelaInfoENS">源对象</param>
 /// <param name = "objMicroTeachCaseRelaInfoENT">目标对象</param>
public void CopyTo(clsMicroTeachCaseRelaInfoEN objMicroTeachCaseRelaInfoENS, clsMicroTeachCaseRelaInfoEN objMicroTeachCaseRelaInfoENT)
{
objMicroTeachCaseRelaInfoENT.IdMicroTeachCaseRelaInfo = objMicroTeachCaseRelaInfoENS.IdMicroTeachCaseRelaInfo; //案例相关信息流水号
objMicroTeachCaseRelaInfoENT.FuncModuleId = objMicroTeachCaseRelaInfoENS.FuncModuleId; //功能模块Id
objMicroTeachCaseRelaInfoENT.IdMicroteachCase = objMicroTeachCaseRelaInfoENS.IdMicroteachCase; //微格教学案例流水号
objMicroTeachCaseRelaInfoENT.IdResource = objMicroTeachCaseRelaInfoENS.IdResource; //资源流水号
objMicroTeachCaseRelaInfoENT.IdMicroTeachCaseRelaInfoType = objMicroTeachCaseRelaInfoENS.IdMicroTeachCaseRelaInfoType; //微格案例相关信息类型流水号
objMicroTeachCaseRelaInfoENT.IsVisible = objMicroTeachCaseRelaInfoENS.IsVisible; //是否显示
objMicroTeachCaseRelaInfoENT.BrowseCount = objMicroTeachCaseRelaInfoENS.BrowseCount; //浏览次数
objMicroTeachCaseRelaInfoENT.Flag = objMicroTeachCaseRelaInfoENS.Flag; //标志
objMicroTeachCaseRelaInfoENT.UpdDate = objMicroTeachCaseRelaInfoENS.UpdDate; //修改日期
objMicroTeachCaseRelaInfoENT.UpdUser = objMicroTeachCaseRelaInfoENS.UpdUser; //修改人
objMicroTeachCaseRelaInfoENT.Memo = objMicroTeachCaseRelaInfoENS.Memo; //备注
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsMicroTeachCaseRelaInfoEN objMicroTeachCaseRelaInfoEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objMicroTeachCaseRelaInfoEN.FuncModuleId, conMicroTeachCaseRelaInfo.FuncModuleId);
clsCheckSql.CheckFieldNotNull(objMicroTeachCaseRelaInfoEN.IdMicroteachCase, conMicroTeachCaseRelaInfo.IdMicroteachCase);
clsCheckSql.CheckFieldNotNull(objMicroTeachCaseRelaInfoEN.IdResource, conMicroTeachCaseRelaInfo.IdResource);
clsCheckSql.CheckFieldNotNull(objMicroTeachCaseRelaInfoEN.IdMicroTeachCaseRelaInfoType, conMicroTeachCaseRelaInfo.IdMicroTeachCaseRelaInfoType);
//检查字段长度
clsCheckSql.CheckFieldLen(objMicroTeachCaseRelaInfoEN.FuncModuleId, 4, conMicroTeachCaseRelaInfo.FuncModuleId);
clsCheckSql.CheckFieldLen(objMicroTeachCaseRelaInfoEN.IdMicroteachCase, 8, conMicroTeachCaseRelaInfo.IdMicroteachCase);
clsCheckSql.CheckFieldLen(objMicroTeachCaseRelaInfoEN.IdResource, 8, conMicroTeachCaseRelaInfo.IdResource);
clsCheckSql.CheckFieldLen(objMicroTeachCaseRelaInfoEN.IdMicroTeachCaseRelaInfoType, 4, conMicroTeachCaseRelaInfo.IdMicroTeachCaseRelaInfoType);
clsCheckSql.CheckFieldLen(objMicroTeachCaseRelaInfoEN.Flag, 50, conMicroTeachCaseRelaInfo.Flag);
clsCheckSql.CheckFieldLen(objMicroTeachCaseRelaInfoEN.UpdDate, 20, conMicroTeachCaseRelaInfo.UpdDate);
clsCheckSql.CheckFieldLen(objMicroTeachCaseRelaInfoEN.UpdUser, 20, conMicroTeachCaseRelaInfo.UpdUser);
clsCheckSql.CheckFieldLen(objMicroTeachCaseRelaInfoEN.Memo, 1000, conMicroTeachCaseRelaInfo.Memo);
//检查字段外键固定长度
clsCheckSql.CheckFieldForeignKey(objMicroTeachCaseRelaInfoEN.FuncModuleId, 4, conMicroTeachCaseRelaInfo.FuncModuleId);
clsCheckSql.CheckFieldForeignKey(objMicroTeachCaseRelaInfoEN.IdMicroteachCase, 8, conMicroTeachCaseRelaInfo.IdMicroteachCase);
clsCheckSql.CheckFieldForeignKey(objMicroTeachCaseRelaInfoEN.IdResource, 8, conMicroTeachCaseRelaInfo.IdResource);
 objMicroTeachCaseRelaInfoEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsMicroTeachCaseRelaInfoEN objMicroTeachCaseRelaInfoEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objMicroTeachCaseRelaInfoEN.FuncModuleId, 4, conMicroTeachCaseRelaInfo.FuncModuleId);
clsCheckSql.CheckFieldLen(objMicroTeachCaseRelaInfoEN.IdMicroteachCase, 8, conMicroTeachCaseRelaInfo.IdMicroteachCase);
clsCheckSql.CheckFieldLen(objMicroTeachCaseRelaInfoEN.IdResource, 8, conMicroTeachCaseRelaInfo.IdResource);
clsCheckSql.CheckFieldLen(objMicroTeachCaseRelaInfoEN.IdMicroTeachCaseRelaInfoType, 4, conMicroTeachCaseRelaInfo.IdMicroTeachCaseRelaInfoType);
clsCheckSql.CheckFieldLen(objMicroTeachCaseRelaInfoEN.Flag, 50, conMicroTeachCaseRelaInfo.Flag);
clsCheckSql.CheckFieldLen(objMicroTeachCaseRelaInfoEN.UpdDate, 20, conMicroTeachCaseRelaInfo.UpdDate);
clsCheckSql.CheckFieldLen(objMicroTeachCaseRelaInfoEN.UpdUser, 20, conMicroTeachCaseRelaInfo.UpdUser);
clsCheckSql.CheckFieldLen(objMicroTeachCaseRelaInfoEN.Memo, 1000, conMicroTeachCaseRelaInfo.Memo);
//检查外键字段长度
clsCheckSql.CheckFieldForeignKey(objMicroTeachCaseRelaInfoEN.FuncModuleId, 4, conMicroTeachCaseRelaInfo.FuncModuleId);
clsCheckSql.CheckFieldForeignKey(objMicroTeachCaseRelaInfoEN.IdMicroteachCase, 8, conMicroTeachCaseRelaInfo.IdMicroteachCase);
clsCheckSql.CheckFieldForeignKey(objMicroTeachCaseRelaInfoEN.IdResource, 8, conMicroTeachCaseRelaInfo.IdResource);
 objMicroTeachCaseRelaInfoEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsMicroTeachCaseRelaInfoEN objMicroTeachCaseRelaInfoEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objMicroTeachCaseRelaInfoEN.FuncModuleId, 4, conMicroTeachCaseRelaInfo.FuncModuleId);
clsCheckSql.CheckFieldLen(objMicroTeachCaseRelaInfoEN.IdMicroteachCase, 8, conMicroTeachCaseRelaInfo.IdMicroteachCase);
clsCheckSql.CheckFieldLen(objMicroTeachCaseRelaInfoEN.IdResource, 8, conMicroTeachCaseRelaInfo.IdResource);
clsCheckSql.CheckFieldLen(objMicroTeachCaseRelaInfoEN.IdMicroTeachCaseRelaInfoType, 4, conMicroTeachCaseRelaInfo.IdMicroTeachCaseRelaInfoType);
clsCheckSql.CheckFieldLen(objMicroTeachCaseRelaInfoEN.Flag, 50, conMicroTeachCaseRelaInfo.Flag);
clsCheckSql.CheckFieldLen(objMicroTeachCaseRelaInfoEN.UpdDate, 20, conMicroTeachCaseRelaInfo.UpdDate);
clsCheckSql.CheckFieldLen(objMicroTeachCaseRelaInfoEN.UpdUser, 20, conMicroTeachCaseRelaInfo.UpdUser);
clsCheckSql.CheckFieldLen(objMicroTeachCaseRelaInfoEN.Memo, 1000, conMicroTeachCaseRelaInfo.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objMicroTeachCaseRelaInfoEN.FuncModuleId, conMicroTeachCaseRelaInfo.FuncModuleId);
clsCheckSql.CheckSqlInjection4Field(objMicroTeachCaseRelaInfoEN.IdMicroteachCase, conMicroTeachCaseRelaInfo.IdMicroteachCase);
clsCheckSql.CheckSqlInjection4Field(objMicroTeachCaseRelaInfoEN.IdResource, conMicroTeachCaseRelaInfo.IdResource);
clsCheckSql.CheckSqlInjection4Field(objMicroTeachCaseRelaInfoEN.IdMicroTeachCaseRelaInfoType, conMicroTeachCaseRelaInfo.IdMicroTeachCaseRelaInfoType);
clsCheckSql.CheckSqlInjection4Field(objMicroTeachCaseRelaInfoEN.Flag, conMicroTeachCaseRelaInfo.Flag);
clsCheckSql.CheckSqlInjection4Field(objMicroTeachCaseRelaInfoEN.UpdDate, conMicroTeachCaseRelaInfo.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objMicroTeachCaseRelaInfoEN.UpdUser, conMicroTeachCaseRelaInfo.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objMicroTeachCaseRelaInfoEN.Memo, conMicroTeachCaseRelaInfo.Memo);
//检查外键字段长度
clsCheckSql.CheckFieldForeignKey(objMicroTeachCaseRelaInfoEN.FuncModuleId, 4, conMicroTeachCaseRelaInfo.FuncModuleId);
clsCheckSql.CheckFieldForeignKey(objMicroTeachCaseRelaInfoEN.IdMicroteachCase, 8, conMicroTeachCaseRelaInfo.IdMicroteachCase);
clsCheckSql.CheckFieldForeignKey(objMicroTeachCaseRelaInfoEN.IdResource, 8, conMicroTeachCaseRelaInfo.IdResource);
 objMicroTeachCaseRelaInfoEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--MicroTeachCaseRelaInfo(微格案例相关信息),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objMicroTeachCaseRelaInfoEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clsMicroTeachCaseRelaInfoEN objMicroTeachCaseRelaInfoEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and IdMicroteachCase = '{0}'", objMicroTeachCaseRelaInfoEN.IdMicroteachCase);
 sbCondition.AppendFormat(" and IdMicroTeachCaseRelaInfoType = '{0}'", objMicroTeachCaseRelaInfoEN.IdMicroTeachCaseRelaInfoType);
 sbCondition.AppendFormat(" and IdResource = '{0}'", objMicroTeachCaseRelaInfoEN.IdResource);
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
 objSQL = clsMicroTeachCaseRelaInfoDA.GetSpecSQLObj();
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
 objSQL = clsMicroTeachCaseRelaInfoDA.GetSpecSQLObj();
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
 objSQL = clsMicroTeachCaseRelaInfoDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsMicroTeachCaseRelaInfoEN._CurrTabName);
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
 objSQL = clsMicroTeachCaseRelaInfoDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsMicroTeachCaseRelaInfoEN._CurrTabName, strCondition);
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
 objSQL = clsMicroTeachCaseRelaInfoDA.GetSpecSQLObj();
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
 objSQL = clsMicroTeachCaseRelaInfoDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}