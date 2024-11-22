
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsClientVersionDA
 表名:ClientVersion(01120276)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 13:08:22
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:系统参数(SysPara)
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
 /// 客户端版本(ClientVersion)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsClientVersionDA : clsCommBase4DA
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
 return clsClientVersionEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsClientVersionEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsClientVersionEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsClientVersionEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsClientVersionEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strClientVersionId">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strClientVersionId)
{
strClientVersionId = strClientVersionId.Replace("'", "''");
if (strClientVersionId.Length > 8)
{
throw new Exception("(errid:Data000001)在表:ClientVersion中,检查关键字,长度不正确!(clsClientVersionDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strClientVersionId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:ClientVersion中,关键字不能为空 或 null!(clsClientVersionDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strClientVersionId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsClientVersionDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsClientVersionDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsClientVersionDA.GetSpecSQLObj();
strSQL = "Select * from ClientVersion where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_ClientVersion(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsClientVersionDA: GetDataTable_ClientVersion)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsClientVersionDA.GetSpecSQLObj();
strSQL = "Select * from ClientVersion where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsClientVersionDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsClientVersionDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsClientVersionDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsClientVersionDA.GetSpecSQLObj();
strSQL = "Select * from ClientVersion where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsClientVersionDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsClientVersionDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsClientVersionDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsClientVersionDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from ClientVersion where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from ClientVersion where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsClientVersionDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsClientVersionDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from ClientVersion where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsClientVersionDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsClientVersionDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} ClientVersion.* from ClientVersion Left Join {1} on {2} where {3} and ClientVersion.ClientVersionId not in (Select top {5} ClientVersion.ClientVersionId from ClientVersion Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from ClientVersion where {1} and ClientVersionId not in (Select top {2} ClientVersionId from ClientVersion where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from ClientVersion where {1} and ClientVersionId not in (Select top {3} ClientVersionId from ClientVersion where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsClientVersionDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsClientVersionDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} ClientVersion.* from ClientVersion Left Join {1} on {2} where {3} and ClientVersion.ClientVersionId not in (Select top {5} ClientVersion.ClientVersionId from ClientVersion Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from ClientVersion where {1} and ClientVersionId not in (Select top {2} ClientVersionId from ClientVersion where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from ClientVersion where {1} and ClientVersionId not in (Select top {3} ClientVersionId from ClientVersion where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsClientVersionEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsClientVersionDA:GetObjLst)", objException.Message));
}
List<clsClientVersionEN> arrObjLst = new List<clsClientVersionEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsClientVersionDA.GetSpecSQLObj();
strSQL = "Select * from ClientVersion where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsClientVersionEN objClientVersionEN = new clsClientVersionEN();
try
{
objClientVersionEN.ClientVersionId = objRow[conClientVersion.ClientVersionId].ToString().Trim(); //客户端版本Id
objClientVersionEN.ClientVersionTypeId = objRow[conClientVersion.ClientVersionTypeId].ToString().Trim(); //客户端版本类型Id
objClientVersionEN.VersionDescription = objRow[conClientVersion.VersionDescription] == DBNull.Value ? null : objRow[conClientVersion.VersionDescription].ToString().Trim(); //版本说明
objClientVersionEN.VersionNumber = objRow[conClientVersion.VersionNumber].ToString().Trim(); //版本号
objClientVersionEN.VersionState = TransNullToBool(objRow[conClientVersion.VersionState].ToString().Trim()); //版本状态
objClientVersionEN.VersionUrl = objRow[conClientVersion.VersionUrl].ToString().Trim(); //版本文件
objClientVersionEN.VersionCode = objRow[conClientVersion.VersionCode].ToString().Trim(); //VersionCode
objClientVersionEN.PrjId = objRow[conClientVersion.PrjId] == DBNull.Value ? null : objRow[conClientVersion.PrjId].ToString().Trim(); //PrjId
objClientVersionEN.UpdDate = objRow[conClientVersion.UpdDate] == DBNull.Value ? null : objRow[conClientVersion.UpdDate].ToString().Trim(); //修改日期
objClientVersionEN.UpdUser = objRow[conClientVersion.UpdUser] == DBNull.Value ? null : objRow[conClientVersion.UpdUser].ToString().Trim(); //修改人
objClientVersionEN.Memo = objRow[conClientVersion.Memo] == DBNull.Value ? null : objRow[conClientVersion.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsClientVersionDA: GetObjLst)", objException.Message));
}
objClientVersionEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objClientVersionEN);
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
public List<clsClientVersionEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsClientVersionDA:GetObjLstByTabName)", objException.Message));
}
List<clsClientVersionEN> arrObjLst = new List<clsClientVersionEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsClientVersionDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsClientVersionEN objClientVersionEN = new clsClientVersionEN();
try
{
objClientVersionEN.ClientVersionId = objRow[conClientVersion.ClientVersionId].ToString().Trim(); //客户端版本Id
objClientVersionEN.ClientVersionTypeId = objRow[conClientVersion.ClientVersionTypeId].ToString().Trim(); //客户端版本类型Id
objClientVersionEN.VersionDescription = objRow[conClientVersion.VersionDescription] == DBNull.Value ? null : objRow[conClientVersion.VersionDescription].ToString().Trim(); //版本说明
objClientVersionEN.VersionNumber = objRow[conClientVersion.VersionNumber].ToString().Trim(); //版本号
objClientVersionEN.VersionState = TransNullToBool(objRow[conClientVersion.VersionState].ToString().Trim()); //版本状态
objClientVersionEN.VersionUrl = objRow[conClientVersion.VersionUrl].ToString().Trim(); //版本文件
objClientVersionEN.VersionCode = objRow[conClientVersion.VersionCode].ToString().Trim(); //VersionCode
objClientVersionEN.PrjId = objRow[conClientVersion.PrjId] == DBNull.Value ? null : objRow[conClientVersion.PrjId].ToString().Trim(); //PrjId
objClientVersionEN.UpdDate = objRow[conClientVersion.UpdDate] == DBNull.Value ? null : objRow[conClientVersion.UpdDate].ToString().Trim(); //修改日期
objClientVersionEN.UpdUser = objRow[conClientVersion.UpdUser] == DBNull.Value ? null : objRow[conClientVersion.UpdUser].ToString().Trim(); //修改人
objClientVersionEN.Memo = objRow[conClientVersion.Memo] == DBNull.Value ? null : objRow[conClientVersion.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsClientVersionDA: GetObjLst)", objException.Message));
}
objClientVersionEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objClientVersionEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objClientVersionEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetClientVersion(ref clsClientVersionEN objClientVersionEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsClientVersionDA.GetSpecSQLObj();
strSQL = "Select * from ClientVersion where ClientVersionId = " + "'"+ objClientVersionEN.ClientVersionId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objClientVersionEN.ClientVersionId = objDT.Rows[0][conClientVersion.ClientVersionId].ToString().Trim(); //客户端版本Id(字段类型:char,字段长度:8,是否可空:False)
 objClientVersionEN.ClientVersionTypeId = objDT.Rows[0][conClientVersion.ClientVersionTypeId].ToString().Trim(); //客户端版本类型Id(字段类型:char,字段长度:8,是否可空:False)
 objClientVersionEN.VersionDescription = objDT.Rows[0][conClientVersion.VersionDescription].ToString().Trim(); //版本说明(字段类型:varchar,字段长度:1000,是否可空:True)
 objClientVersionEN.VersionNumber = objDT.Rows[0][conClientVersion.VersionNumber].ToString().Trim(); //版本号(字段类型:varchar,字段长度:50,是否可空:False)
 objClientVersionEN.VersionState = TransNullToBool(objDT.Rows[0][conClientVersion.VersionState].ToString().Trim()); //版本状态(字段类型:bit,字段长度:1,是否可空:True)
 objClientVersionEN.VersionUrl = objDT.Rows[0][conClientVersion.VersionUrl].ToString().Trim(); //版本文件(字段类型:varchar,字段长度:500,是否可空:False)
 objClientVersionEN.VersionCode = objDT.Rows[0][conClientVersion.VersionCode].ToString().Trim(); //VersionCode(字段类型:varchar,字段长度:50,是否可空:False)
 objClientVersionEN.PrjId = objDT.Rows[0][conClientVersion.PrjId].ToString().Trim(); //PrjId(字段类型:char,字段长度:4,是否可空:True)
 objClientVersionEN.UpdDate = objDT.Rows[0][conClientVersion.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objClientVersionEN.UpdUser = objDT.Rows[0][conClientVersion.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objClientVersionEN.Memo = objDT.Rows[0][conClientVersion.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsClientVersionDA: GetClientVersion)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strClientVersionId">表关键字</param>
 /// <returns>表对象</returns>
public clsClientVersionEN GetObjByClientVersionId(string strClientVersionId)
{
CheckPrimaryKey(strClientVersionId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsClientVersionDA.GetSpecSQLObj();
strSQL = "Select * from ClientVersion where ClientVersionId = " + "'"+ strClientVersionId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsClientVersionEN objClientVersionEN = new clsClientVersionEN();
try
{
 objClientVersionEN.ClientVersionId = objRow[conClientVersion.ClientVersionId].ToString().Trim(); //客户端版本Id(字段类型:char,字段长度:8,是否可空:False)
 objClientVersionEN.ClientVersionTypeId = objRow[conClientVersion.ClientVersionTypeId].ToString().Trim(); //客户端版本类型Id(字段类型:char,字段长度:8,是否可空:False)
 objClientVersionEN.VersionDescription = objRow[conClientVersion.VersionDescription] == DBNull.Value ? null : objRow[conClientVersion.VersionDescription].ToString().Trim(); //版本说明(字段类型:varchar,字段长度:1000,是否可空:True)
 objClientVersionEN.VersionNumber = objRow[conClientVersion.VersionNumber].ToString().Trim(); //版本号(字段类型:varchar,字段长度:50,是否可空:False)
 objClientVersionEN.VersionState = clsEntityBase2.TransNullToBool_S(objRow[conClientVersion.VersionState].ToString().Trim()); //版本状态(字段类型:bit,字段长度:1,是否可空:True)
 objClientVersionEN.VersionUrl = objRow[conClientVersion.VersionUrl].ToString().Trim(); //版本文件(字段类型:varchar,字段长度:500,是否可空:False)
 objClientVersionEN.VersionCode = objRow[conClientVersion.VersionCode].ToString().Trim(); //VersionCode(字段类型:varchar,字段长度:50,是否可空:False)
 objClientVersionEN.PrjId = objRow[conClientVersion.PrjId] == DBNull.Value ? null : objRow[conClientVersion.PrjId].ToString().Trim(); //PrjId(字段类型:char,字段长度:4,是否可空:True)
 objClientVersionEN.UpdDate = objRow[conClientVersion.UpdDate] == DBNull.Value ? null : objRow[conClientVersion.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objClientVersionEN.UpdUser = objRow[conClientVersion.UpdUser] == DBNull.Value ? null : objRow[conClientVersion.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objClientVersionEN.Memo = objRow[conClientVersion.Memo] == DBNull.Value ? null : objRow[conClientVersion.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsClientVersionDA: GetObjByClientVersionId)", objException.Message));
}
return objClientVersionEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsClientVersionEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsClientVersionDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsClientVersionDA.GetSpecSQLObj();
strSQL = "Select * from ClientVersion where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsClientVersionEN objClientVersionEN = new clsClientVersionEN()
{
ClientVersionId = objRow[conClientVersion.ClientVersionId].ToString().Trim(), //客户端版本Id
ClientVersionTypeId = objRow[conClientVersion.ClientVersionTypeId].ToString().Trim(), //客户端版本类型Id
VersionDescription = objRow[conClientVersion.VersionDescription] == DBNull.Value ? null : objRow[conClientVersion.VersionDescription].ToString().Trim(), //版本说明
VersionNumber = objRow[conClientVersion.VersionNumber].ToString().Trim(), //版本号
VersionState = TransNullToBool(objRow[conClientVersion.VersionState].ToString().Trim()), //版本状态
VersionUrl = objRow[conClientVersion.VersionUrl].ToString().Trim(), //版本文件
VersionCode = objRow[conClientVersion.VersionCode].ToString().Trim(), //VersionCode
PrjId = objRow[conClientVersion.PrjId] == DBNull.Value ? null : objRow[conClientVersion.PrjId].ToString().Trim(), //PrjId
UpdDate = objRow[conClientVersion.UpdDate] == DBNull.Value ? null : objRow[conClientVersion.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[conClientVersion.UpdUser] == DBNull.Value ? null : objRow[conClientVersion.UpdUser].ToString().Trim(), //修改人
Memo = objRow[conClientVersion.Memo] == DBNull.Value ? null : objRow[conClientVersion.Memo].ToString().Trim() //备注
};
objClientVersionEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objClientVersionEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsClientVersionDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsClientVersionEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsClientVersionEN objClientVersionEN = new clsClientVersionEN();
try
{
objClientVersionEN.ClientVersionId = objRow[conClientVersion.ClientVersionId].ToString().Trim(); //客户端版本Id
objClientVersionEN.ClientVersionTypeId = objRow[conClientVersion.ClientVersionTypeId].ToString().Trim(); //客户端版本类型Id
objClientVersionEN.VersionDescription = objRow[conClientVersion.VersionDescription] == DBNull.Value ? null : objRow[conClientVersion.VersionDescription].ToString().Trim(); //版本说明
objClientVersionEN.VersionNumber = objRow[conClientVersion.VersionNumber].ToString().Trim(); //版本号
objClientVersionEN.VersionState = TransNullToBool(objRow[conClientVersion.VersionState].ToString().Trim()); //版本状态
objClientVersionEN.VersionUrl = objRow[conClientVersion.VersionUrl].ToString().Trim(); //版本文件
objClientVersionEN.VersionCode = objRow[conClientVersion.VersionCode].ToString().Trim(); //VersionCode
objClientVersionEN.PrjId = objRow[conClientVersion.PrjId] == DBNull.Value ? null : objRow[conClientVersion.PrjId].ToString().Trim(); //PrjId
objClientVersionEN.UpdDate = objRow[conClientVersion.UpdDate] == DBNull.Value ? null : objRow[conClientVersion.UpdDate].ToString().Trim(); //修改日期
objClientVersionEN.UpdUser = objRow[conClientVersion.UpdUser] == DBNull.Value ? null : objRow[conClientVersion.UpdUser].ToString().Trim(); //修改人
objClientVersionEN.Memo = objRow[conClientVersion.Memo] == DBNull.Value ? null : objRow[conClientVersion.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsClientVersionDA: GetObjByDataRowClientVersion)", objException.Message));
}
objClientVersionEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objClientVersionEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsClientVersionEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsClientVersionEN objClientVersionEN = new clsClientVersionEN();
try
{
objClientVersionEN.ClientVersionId = objRow[conClientVersion.ClientVersionId].ToString().Trim(); //客户端版本Id
objClientVersionEN.ClientVersionTypeId = objRow[conClientVersion.ClientVersionTypeId].ToString().Trim(); //客户端版本类型Id
objClientVersionEN.VersionDescription = objRow[conClientVersion.VersionDescription] == DBNull.Value ? null : objRow[conClientVersion.VersionDescription].ToString().Trim(); //版本说明
objClientVersionEN.VersionNumber = objRow[conClientVersion.VersionNumber].ToString().Trim(); //版本号
objClientVersionEN.VersionState = TransNullToBool(objRow[conClientVersion.VersionState].ToString().Trim()); //版本状态
objClientVersionEN.VersionUrl = objRow[conClientVersion.VersionUrl].ToString().Trim(); //版本文件
objClientVersionEN.VersionCode = objRow[conClientVersion.VersionCode].ToString().Trim(); //VersionCode
objClientVersionEN.PrjId = objRow[conClientVersion.PrjId] == DBNull.Value ? null : objRow[conClientVersion.PrjId].ToString().Trim(); //PrjId
objClientVersionEN.UpdDate = objRow[conClientVersion.UpdDate] == DBNull.Value ? null : objRow[conClientVersion.UpdDate].ToString().Trim(); //修改日期
objClientVersionEN.UpdUser = objRow[conClientVersion.UpdUser] == DBNull.Value ? null : objRow[conClientVersion.UpdUser].ToString().Trim(); //修改人
objClientVersionEN.Memo = objRow[conClientVersion.Memo] == DBNull.Value ? null : objRow[conClientVersion.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsClientVersionDA: GetObjByDataRow)", objException.Message));
}
objClientVersionEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objClientVersionEN;
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
objSQL = clsClientVersionDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsClientVersionEN._CurrTabName, conClientVersion.ClientVersionId, 8, "");
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
objSQL = clsClientVersionDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsClientVersionEN._CurrTabName, conClientVersion.ClientVersionId, 8, strPrefix);
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
 objSQL = clsClientVersionDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select ClientVersionId from ClientVersion where " + strCondition;
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
 objSQL = clsClientVersionDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select ClientVersionId from ClientVersion where " + strCondition;
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
 /// <param name = "strClientVersionId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strClientVersionId)
{
CheckPrimaryKey(strClientVersionId);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsClientVersionDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("ClientVersion", "ClientVersionId = " + "'"+ strClientVersionId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsClientVersionDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsClientVersionDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("ClientVersion", strCondition))
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
objSQL = clsClientVersionDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("ClientVersion");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsClientVersionEN objClientVersionEN)
 {
 objClientVersionEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objClientVersionEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objClientVersionEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsClientVersionDA.GetSpecSQLObj();
strSQL = "Select * from ClientVersion where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "ClientVersion");
objRow = objDS.Tables["ClientVersion"].NewRow();
objRow[conClientVersion.ClientVersionId] = objClientVersionEN.ClientVersionId; //客户端版本Id
objRow[conClientVersion.ClientVersionTypeId] = objClientVersionEN.ClientVersionTypeId; //客户端版本类型Id
 if (objClientVersionEN.VersionDescription !=  "")
 {
objRow[conClientVersion.VersionDescription] = objClientVersionEN.VersionDescription; //版本说明
 }
objRow[conClientVersion.VersionNumber] = objClientVersionEN.VersionNumber; //版本号
objRow[conClientVersion.VersionState] = objClientVersionEN.VersionState; //版本状态
objRow[conClientVersion.VersionUrl] = objClientVersionEN.VersionUrl; //版本文件
objRow[conClientVersion.VersionCode] = objClientVersionEN.VersionCode; //VersionCode
 if (objClientVersionEN.PrjId !=  "")
 {
objRow[conClientVersion.PrjId] = objClientVersionEN.PrjId; //PrjId
 }
 if (objClientVersionEN.UpdDate !=  "")
 {
objRow[conClientVersion.UpdDate] = objClientVersionEN.UpdDate; //修改日期
 }
 if (objClientVersionEN.UpdUser !=  "")
 {
objRow[conClientVersion.UpdUser] = objClientVersionEN.UpdUser; //修改人
 }
 if (objClientVersionEN.Memo !=  "")
 {
objRow[conClientVersion.Memo] = objClientVersionEN.Memo; //备注
 }
objDS.Tables[clsClientVersionEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsClientVersionEN._CurrTabName);
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
 /// <param name = "objClientVersionEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsClientVersionEN objClientVersionEN)
{
 objClientVersionEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objClientVersionEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objClientVersionEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objClientVersionEN.ClientVersionId !=  null)
 {
 arrFieldListForInsert.Add(conClientVersion.ClientVersionId);
 var strClientVersionId = objClientVersionEN.ClientVersionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strClientVersionId + "'");
 }
 
 if (objClientVersionEN.ClientVersionTypeId !=  null)
 {
 arrFieldListForInsert.Add(conClientVersion.ClientVersionTypeId);
 var strClientVersionTypeId = objClientVersionEN.ClientVersionTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strClientVersionTypeId + "'");
 }
 
 if (objClientVersionEN.VersionDescription !=  null)
 {
 arrFieldListForInsert.Add(conClientVersion.VersionDescription);
 var strVersionDescription = objClientVersionEN.VersionDescription.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVersionDescription + "'");
 }
 
 if (objClientVersionEN.VersionNumber !=  null)
 {
 arrFieldListForInsert.Add(conClientVersion.VersionNumber);
 var strVersionNumber = objClientVersionEN.VersionNumber.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVersionNumber + "'");
 }
 
 arrFieldListForInsert.Add(conClientVersion.VersionState);
 arrValueListForInsert.Add("'" + (objClientVersionEN.VersionState  ==  false ? "0" : "1") + "'");
 
 if (objClientVersionEN.VersionUrl !=  null)
 {
 arrFieldListForInsert.Add(conClientVersion.VersionUrl);
 var strVersionUrl = objClientVersionEN.VersionUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVersionUrl + "'");
 }
 
 if (objClientVersionEN.VersionCode !=  null)
 {
 arrFieldListForInsert.Add(conClientVersion.VersionCode);
 var strVersionCode = objClientVersionEN.VersionCode.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVersionCode + "'");
 }
 
 if (objClientVersionEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(conClientVersion.PrjId);
 var strPrjId = objClientVersionEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjId + "'");
 }
 
 if (objClientVersionEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conClientVersion.UpdDate);
 var strUpdDate = objClientVersionEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objClientVersionEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conClientVersion.UpdUser);
 var strUpdUser = objClientVersionEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objClientVersionEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conClientVersion.Memo);
 var strMemo = objClientVersionEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into ClientVersion");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsClientVersionDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objClientVersionEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsClientVersionEN objClientVersionEN)
{
 objClientVersionEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objClientVersionEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objClientVersionEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objClientVersionEN.ClientVersionId !=  null)
 {
 arrFieldListForInsert.Add(conClientVersion.ClientVersionId);
 var strClientVersionId = objClientVersionEN.ClientVersionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strClientVersionId + "'");
 }
 
 if (objClientVersionEN.ClientVersionTypeId !=  null)
 {
 arrFieldListForInsert.Add(conClientVersion.ClientVersionTypeId);
 var strClientVersionTypeId = objClientVersionEN.ClientVersionTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strClientVersionTypeId + "'");
 }
 
 if (objClientVersionEN.VersionDescription !=  null)
 {
 arrFieldListForInsert.Add(conClientVersion.VersionDescription);
 var strVersionDescription = objClientVersionEN.VersionDescription.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVersionDescription + "'");
 }
 
 if (objClientVersionEN.VersionNumber !=  null)
 {
 arrFieldListForInsert.Add(conClientVersion.VersionNumber);
 var strVersionNumber = objClientVersionEN.VersionNumber.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVersionNumber + "'");
 }
 
 arrFieldListForInsert.Add(conClientVersion.VersionState);
 arrValueListForInsert.Add("'" + (objClientVersionEN.VersionState  ==  false ? "0" : "1") + "'");
 
 if (objClientVersionEN.VersionUrl !=  null)
 {
 arrFieldListForInsert.Add(conClientVersion.VersionUrl);
 var strVersionUrl = objClientVersionEN.VersionUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVersionUrl + "'");
 }
 
 if (objClientVersionEN.VersionCode !=  null)
 {
 arrFieldListForInsert.Add(conClientVersion.VersionCode);
 var strVersionCode = objClientVersionEN.VersionCode.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVersionCode + "'");
 }
 
 if (objClientVersionEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(conClientVersion.PrjId);
 var strPrjId = objClientVersionEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjId + "'");
 }
 
 if (objClientVersionEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conClientVersion.UpdDate);
 var strUpdDate = objClientVersionEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objClientVersionEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conClientVersion.UpdUser);
 var strUpdUser = objClientVersionEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objClientVersionEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conClientVersion.Memo);
 var strMemo = objClientVersionEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into ClientVersion");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsClientVersionDA.GetSpecSQLObj();
 objSQL.ExecSql(strSQL.ToString());
return objClientVersionEN.ClientVersionId;
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objClientVersionEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsClientVersionEN objClientVersionEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objClientVersionEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objClientVersionEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objClientVersionEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objClientVersionEN.ClientVersionId !=  null)
 {
 arrFieldListForInsert.Add(conClientVersion.ClientVersionId);
 var strClientVersionId = objClientVersionEN.ClientVersionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strClientVersionId + "'");
 }
 
 if (objClientVersionEN.ClientVersionTypeId !=  null)
 {
 arrFieldListForInsert.Add(conClientVersion.ClientVersionTypeId);
 var strClientVersionTypeId = objClientVersionEN.ClientVersionTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strClientVersionTypeId + "'");
 }
 
 if (objClientVersionEN.VersionDescription !=  null)
 {
 arrFieldListForInsert.Add(conClientVersion.VersionDescription);
 var strVersionDescription = objClientVersionEN.VersionDescription.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVersionDescription + "'");
 }
 
 if (objClientVersionEN.VersionNumber !=  null)
 {
 arrFieldListForInsert.Add(conClientVersion.VersionNumber);
 var strVersionNumber = objClientVersionEN.VersionNumber.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVersionNumber + "'");
 }
 
 arrFieldListForInsert.Add(conClientVersion.VersionState);
 arrValueListForInsert.Add("'" + (objClientVersionEN.VersionState  ==  false ? "0" : "1") + "'");
 
 if (objClientVersionEN.VersionUrl !=  null)
 {
 arrFieldListForInsert.Add(conClientVersion.VersionUrl);
 var strVersionUrl = objClientVersionEN.VersionUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVersionUrl + "'");
 }
 
 if (objClientVersionEN.VersionCode !=  null)
 {
 arrFieldListForInsert.Add(conClientVersion.VersionCode);
 var strVersionCode = objClientVersionEN.VersionCode.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVersionCode + "'");
 }
 
 if (objClientVersionEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(conClientVersion.PrjId);
 var strPrjId = objClientVersionEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjId + "'");
 }
 
 if (objClientVersionEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conClientVersion.UpdDate);
 var strUpdDate = objClientVersionEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objClientVersionEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conClientVersion.UpdUser);
 var strUpdUser = objClientVersionEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objClientVersionEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conClientVersion.Memo);
 var strMemo = objClientVersionEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into ClientVersion");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsClientVersionDA.GetSpecSQLObj();
    objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
return objClientVersionEN.ClientVersionId;
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objClientVersionEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsClientVersionEN objClientVersionEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objClientVersionEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objClientVersionEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objClientVersionEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objClientVersionEN.ClientVersionId !=  null)
 {
 arrFieldListForInsert.Add(conClientVersion.ClientVersionId);
 var strClientVersionId = objClientVersionEN.ClientVersionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strClientVersionId + "'");
 }
 
 if (objClientVersionEN.ClientVersionTypeId !=  null)
 {
 arrFieldListForInsert.Add(conClientVersion.ClientVersionTypeId);
 var strClientVersionTypeId = objClientVersionEN.ClientVersionTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strClientVersionTypeId + "'");
 }
 
 if (objClientVersionEN.VersionDescription !=  null)
 {
 arrFieldListForInsert.Add(conClientVersion.VersionDescription);
 var strVersionDescription = objClientVersionEN.VersionDescription.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVersionDescription + "'");
 }
 
 if (objClientVersionEN.VersionNumber !=  null)
 {
 arrFieldListForInsert.Add(conClientVersion.VersionNumber);
 var strVersionNumber = objClientVersionEN.VersionNumber.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVersionNumber + "'");
 }
 
 arrFieldListForInsert.Add(conClientVersion.VersionState);
 arrValueListForInsert.Add("'" + (objClientVersionEN.VersionState  ==  false ? "0" : "1") + "'");
 
 if (objClientVersionEN.VersionUrl !=  null)
 {
 arrFieldListForInsert.Add(conClientVersion.VersionUrl);
 var strVersionUrl = objClientVersionEN.VersionUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVersionUrl + "'");
 }
 
 if (objClientVersionEN.VersionCode !=  null)
 {
 arrFieldListForInsert.Add(conClientVersion.VersionCode);
 var strVersionCode = objClientVersionEN.VersionCode.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVersionCode + "'");
 }
 
 if (objClientVersionEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(conClientVersion.PrjId);
 var strPrjId = objClientVersionEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjId + "'");
 }
 
 if (objClientVersionEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conClientVersion.UpdDate);
 var strUpdDate = objClientVersionEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objClientVersionEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conClientVersion.UpdUser);
 var strUpdUser = objClientVersionEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objClientVersionEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conClientVersion.Memo);
 var strMemo = objClientVersionEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into ClientVersion");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsClientVersionDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewClientVersions(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsClientVersionDA.GetSpecSQLObj();
strSQL = "Select * from ClientVersion where ClientVersionId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "ClientVersion");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
string strClientVersionId = oRow[conClientVersion.ClientVersionId].ToString().Trim();
if (IsExist(strClientVersionId))
{
 string strResult = "关键字变量值为:" + string.Format("ClientVersionId = {0}", strClientVersionId) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsClientVersionEN._CurrTabName ].NewRow();
objRow[conClientVersion.ClientVersionId] = oRow[conClientVersion.ClientVersionId].ToString().Trim(); //客户端版本Id
objRow[conClientVersion.ClientVersionTypeId] = oRow[conClientVersion.ClientVersionTypeId].ToString().Trim(); //客户端版本类型Id
objRow[conClientVersion.VersionDescription] = oRow[conClientVersion.VersionDescription].ToString().Trim(); //版本说明
objRow[conClientVersion.VersionNumber] = oRow[conClientVersion.VersionNumber].ToString().Trim(); //版本号
objRow[conClientVersion.VersionState] = oRow[conClientVersion.VersionState].ToString().Trim(); //版本状态
objRow[conClientVersion.VersionUrl] = oRow[conClientVersion.VersionUrl].ToString().Trim(); //版本文件
objRow[conClientVersion.VersionCode] = oRow[conClientVersion.VersionCode].ToString().Trim(); //VersionCode
objRow[conClientVersion.PrjId] = oRow[conClientVersion.PrjId].ToString().Trim(); //PrjId
objRow[conClientVersion.UpdDate] = oRow[conClientVersion.UpdDate].ToString().Trim(); //修改日期
objRow[conClientVersion.UpdUser] = oRow[conClientVersion.UpdUser].ToString().Trim(); //修改人
objRow[conClientVersion.Memo] = oRow[conClientVersion.Memo].ToString().Trim(); //备注
 objDS.Tables[clsClientVersionEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsClientVersionEN._CurrTabName);
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
 /// <param name = "objClientVersionEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsClientVersionEN objClientVersionEN)
{
 objClientVersionEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objClientVersionEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objClientVersionEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsClientVersionDA.GetSpecSQLObj();
strSQL = "Select * from ClientVersion where ClientVersionId = " + "'"+ objClientVersionEN.ClientVersionId+"'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsClientVersionEN._CurrTabName);
if (objDS.Tables[clsClientVersionEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:ClientVersionId = " + "'"+ objClientVersionEN.ClientVersionId+"'");
return false;
}
objRow = objDS.Tables[clsClientVersionEN._CurrTabName].Rows[0];
 if (objClientVersionEN.IsUpdated(conClientVersion.ClientVersionId))
 {
objRow[conClientVersion.ClientVersionId] = objClientVersionEN.ClientVersionId; //客户端版本Id
 }
 if (objClientVersionEN.IsUpdated(conClientVersion.ClientVersionTypeId))
 {
objRow[conClientVersion.ClientVersionTypeId] = objClientVersionEN.ClientVersionTypeId; //客户端版本类型Id
 }
 if (objClientVersionEN.IsUpdated(conClientVersion.VersionDescription))
 {
objRow[conClientVersion.VersionDescription] = objClientVersionEN.VersionDescription; //版本说明
 }
 if (objClientVersionEN.IsUpdated(conClientVersion.VersionNumber))
 {
objRow[conClientVersion.VersionNumber] = objClientVersionEN.VersionNumber; //版本号
 }
 if (objClientVersionEN.IsUpdated(conClientVersion.VersionState))
 {
objRow[conClientVersion.VersionState] = objClientVersionEN.VersionState; //版本状态
 }
 if (objClientVersionEN.IsUpdated(conClientVersion.VersionUrl))
 {
objRow[conClientVersion.VersionUrl] = objClientVersionEN.VersionUrl; //版本文件
 }
 if (objClientVersionEN.IsUpdated(conClientVersion.VersionCode))
 {
objRow[conClientVersion.VersionCode] = objClientVersionEN.VersionCode; //VersionCode
 }
 if (objClientVersionEN.IsUpdated(conClientVersion.PrjId))
 {
objRow[conClientVersion.PrjId] = objClientVersionEN.PrjId; //PrjId
 }
 if (objClientVersionEN.IsUpdated(conClientVersion.UpdDate))
 {
objRow[conClientVersion.UpdDate] = objClientVersionEN.UpdDate; //修改日期
 }
 if (objClientVersionEN.IsUpdated(conClientVersion.UpdUser))
 {
objRow[conClientVersion.UpdUser] = objClientVersionEN.UpdUser; //修改人
 }
 if (objClientVersionEN.IsUpdated(conClientVersion.Memo))
 {
objRow[conClientVersion.Memo] = objClientVersionEN.Memo; //备注
 }
try
{
objDA.Update(objDS, clsClientVersionEN._CurrTabName);
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
 /// <param name = "objClientVersionEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsClientVersionEN objClientVersionEN)
{
 objClientVersionEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objClientVersionEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objClientVersionEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsClientVersionDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update ClientVersion Set ");
 
 if (objClientVersionEN.IsUpdated(conClientVersion.ClientVersionTypeId))
 {
 if (objClientVersionEN.ClientVersionTypeId !=  null)
 {
 var strClientVersionTypeId = objClientVersionEN.ClientVersionTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strClientVersionTypeId, conClientVersion.ClientVersionTypeId); //客户端版本类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conClientVersion.ClientVersionTypeId); //客户端版本类型Id
 }
 }
 
 if (objClientVersionEN.IsUpdated(conClientVersion.VersionDescription))
 {
 if (objClientVersionEN.VersionDescription !=  null)
 {
 var strVersionDescription = objClientVersionEN.VersionDescription.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strVersionDescription, conClientVersion.VersionDescription); //版本说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conClientVersion.VersionDescription); //版本说明
 }
 }
 
 if (objClientVersionEN.IsUpdated(conClientVersion.VersionNumber))
 {
 if (objClientVersionEN.VersionNumber !=  null)
 {
 var strVersionNumber = objClientVersionEN.VersionNumber.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strVersionNumber, conClientVersion.VersionNumber); //版本号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conClientVersion.VersionNumber); //版本号
 }
 }
 
 if (objClientVersionEN.IsUpdated(conClientVersion.VersionState))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objClientVersionEN.VersionState == true?"1":"0", conClientVersion.VersionState); //版本状态
 }
 
 if (objClientVersionEN.IsUpdated(conClientVersion.VersionUrl))
 {
 if (objClientVersionEN.VersionUrl !=  null)
 {
 var strVersionUrl = objClientVersionEN.VersionUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strVersionUrl, conClientVersion.VersionUrl); //版本文件
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conClientVersion.VersionUrl); //版本文件
 }
 }
 
 if (objClientVersionEN.IsUpdated(conClientVersion.VersionCode))
 {
 if (objClientVersionEN.VersionCode !=  null)
 {
 var strVersionCode = objClientVersionEN.VersionCode.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strVersionCode, conClientVersion.VersionCode); //VersionCode
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conClientVersion.VersionCode); //VersionCode
 }
 }
 
 if (objClientVersionEN.IsUpdated(conClientVersion.PrjId))
 {
 if (objClientVersionEN.PrjId !=  null)
 {
 var strPrjId = objClientVersionEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPrjId, conClientVersion.PrjId); //PrjId
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conClientVersion.PrjId); //PrjId
 }
 }
 
 if (objClientVersionEN.IsUpdated(conClientVersion.UpdDate))
 {
 if (objClientVersionEN.UpdDate !=  null)
 {
 var strUpdDate = objClientVersionEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conClientVersion.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conClientVersion.UpdDate); //修改日期
 }
 }
 
 if (objClientVersionEN.IsUpdated(conClientVersion.UpdUser))
 {
 if (objClientVersionEN.UpdUser !=  null)
 {
 var strUpdUser = objClientVersionEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conClientVersion.UpdUser); //修改人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conClientVersion.UpdUser); //修改人
 }
 }
 
 if (objClientVersionEN.IsUpdated(conClientVersion.Memo))
 {
 if (objClientVersionEN.Memo !=  null)
 {
 var strMemo = objClientVersionEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conClientVersion.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conClientVersion.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where ClientVersionId = '{0}'", objClientVersionEN.ClientVersionId); 
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
 /// <param name = "objClientVersionEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsClientVersionEN objClientVersionEN, string strCondition)
{
 objClientVersionEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objClientVersionEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objClientVersionEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsClientVersionDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update ClientVersion Set ");
 
 if (objClientVersionEN.IsUpdated(conClientVersion.ClientVersionTypeId))
 {
 if (objClientVersionEN.ClientVersionTypeId !=  null)
 {
 var strClientVersionTypeId = objClientVersionEN.ClientVersionTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ClientVersionTypeId = '{0}',", strClientVersionTypeId); //客户端版本类型Id
 }
 else
 {
 sbSQL.Append(" ClientVersionTypeId = null,"); //客户端版本类型Id
 }
 }
 
 if (objClientVersionEN.IsUpdated(conClientVersion.VersionDescription))
 {
 if (objClientVersionEN.VersionDescription !=  null)
 {
 var strVersionDescription = objClientVersionEN.VersionDescription.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" VersionDescription = '{0}',", strVersionDescription); //版本说明
 }
 else
 {
 sbSQL.Append(" VersionDescription = null,"); //版本说明
 }
 }
 
 if (objClientVersionEN.IsUpdated(conClientVersion.VersionNumber))
 {
 if (objClientVersionEN.VersionNumber !=  null)
 {
 var strVersionNumber = objClientVersionEN.VersionNumber.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" VersionNumber = '{0}',", strVersionNumber); //版本号
 }
 else
 {
 sbSQL.Append(" VersionNumber = null,"); //版本号
 }
 }
 
 if (objClientVersionEN.IsUpdated(conClientVersion.VersionState))
 {
 sbSQL.AppendFormat(" VersionState = '{0}',", objClientVersionEN.VersionState == true?"1":"0"); //版本状态
 }
 
 if (objClientVersionEN.IsUpdated(conClientVersion.VersionUrl))
 {
 if (objClientVersionEN.VersionUrl !=  null)
 {
 var strVersionUrl = objClientVersionEN.VersionUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" VersionUrl = '{0}',", strVersionUrl); //版本文件
 }
 else
 {
 sbSQL.Append(" VersionUrl = null,"); //版本文件
 }
 }
 
 if (objClientVersionEN.IsUpdated(conClientVersion.VersionCode))
 {
 if (objClientVersionEN.VersionCode !=  null)
 {
 var strVersionCode = objClientVersionEN.VersionCode.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" VersionCode = '{0}',", strVersionCode); //VersionCode
 }
 else
 {
 sbSQL.Append(" VersionCode = null,"); //VersionCode
 }
 }
 
 if (objClientVersionEN.IsUpdated(conClientVersion.PrjId))
 {
 if (objClientVersionEN.PrjId !=  null)
 {
 var strPrjId = objClientVersionEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PrjId = '{0}',", strPrjId); //PrjId
 }
 else
 {
 sbSQL.Append(" PrjId = null,"); //PrjId
 }
 }
 
 if (objClientVersionEN.IsUpdated(conClientVersion.UpdDate))
 {
 if (objClientVersionEN.UpdDate !=  null)
 {
 var strUpdDate = objClientVersionEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objClientVersionEN.IsUpdated(conClientVersion.UpdUser))
 {
 if (objClientVersionEN.UpdUser !=  null)
 {
 var strUpdUser = objClientVersionEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改人
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改人
 }
 }
 
 if (objClientVersionEN.IsUpdated(conClientVersion.Memo))
 {
 if (objClientVersionEN.Memo !=  null)
 {
 var strMemo = objClientVersionEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objClientVersionEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsClientVersionEN objClientVersionEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objClientVersionEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objClientVersionEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objClientVersionEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsClientVersionDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update ClientVersion Set ");
 
 if (objClientVersionEN.IsUpdated(conClientVersion.ClientVersionTypeId))
 {
 if (objClientVersionEN.ClientVersionTypeId !=  null)
 {
 var strClientVersionTypeId = objClientVersionEN.ClientVersionTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ClientVersionTypeId = '{0}',", strClientVersionTypeId); //客户端版本类型Id
 }
 else
 {
 sbSQL.Append(" ClientVersionTypeId = null,"); //客户端版本类型Id
 }
 }
 
 if (objClientVersionEN.IsUpdated(conClientVersion.VersionDescription))
 {
 if (objClientVersionEN.VersionDescription !=  null)
 {
 var strVersionDescription = objClientVersionEN.VersionDescription.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" VersionDescription = '{0}',", strVersionDescription); //版本说明
 }
 else
 {
 sbSQL.Append(" VersionDescription = null,"); //版本说明
 }
 }
 
 if (objClientVersionEN.IsUpdated(conClientVersion.VersionNumber))
 {
 if (objClientVersionEN.VersionNumber !=  null)
 {
 var strVersionNumber = objClientVersionEN.VersionNumber.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" VersionNumber = '{0}',", strVersionNumber); //版本号
 }
 else
 {
 sbSQL.Append(" VersionNumber = null,"); //版本号
 }
 }
 
 if (objClientVersionEN.IsUpdated(conClientVersion.VersionState))
 {
 sbSQL.AppendFormat(" VersionState = '{0}',", objClientVersionEN.VersionState == true?"1":"0"); //版本状态
 }
 
 if (objClientVersionEN.IsUpdated(conClientVersion.VersionUrl))
 {
 if (objClientVersionEN.VersionUrl !=  null)
 {
 var strVersionUrl = objClientVersionEN.VersionUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" VersionUrl = '{0}',", strVersionUrl); //版本文件
 }
 else
 {
 sbSQL.Append(" VersionUrl = null,"); //版本文件
 }
 }
 
 if (objClientVersionEN.IsUpdated(conClientVersion.VersionCode))
 {
 if (objClientVersionEN.VersionCode !=  null)
 {
 var strVersionCode = objClientVersionEN.VersionCode.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" VersionCode = '{0}',", strVersionCode); //VersionCode
 }
 else
 {
 sbSQL.Append(" VersionCode = null,"); //VersionCode
 }
 }
 
 if (objClientVersionEN.IsUpdated(conClientVersion.PrjId))
 {
 if (objClientVersionEN.PrjId !=  null)
 {
 var strPrjId = objClientVersionEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PrjId = '{0}',", strPrjId); //PrjId
 }
 else
 {
 sbSQL.Append(" PrjId = null,"); //PrjId
 }
 }
 
 if (objClientVersionEN.IsUpdated(conClientVersion.UpdDate))
 {
 if (objClientVersionEN.UpdDate !=  null)
 {
 var strUpdDate = objClientVersionEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objClientVersionEN.IsUpdated(conClientVersion.UpdUser))
 {
 if (objClientVersionEN.UpdUser !=  null)
 {
 var strUpdUser = objClientVersionEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改人
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改人
 }
 }
 
 if (objClientVersionEN.IsUpdated(conClientVersion.Memo))
 {
 if (objClientVersionEN.Memo !=  null)
 {
 var strMemo = objClientVersionEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objClientVersionEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsClientVersionEN objClientVersionEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objClientVersionEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objClientVersionEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objClientVersionEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsClientVersionDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update ClientVersion Set ");
 
 if (objClientVersionEN.IsUpdated(conClientVersion.ClientVersionTypeId))
 {
 if (objClientVersionEN.ClientVersionTypeId !=  null)
 {
 var strClientVersionTypeId = objClientVersionEN.ClientVersionTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strClientVersionTypeId, conClientVersion.ClientVersionTypeId); //客户端版本类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conClientVersion.ClientVersionTypeId); //客户端版本类型Id
 }
 }
 
 if (objClientVersionEN.IsUpdated(conClientVersion.VersionDescription))
 {
 if (objClientVersionEN.VersionDescription !=  null)
 {
 var strVersionDescription = objClientVersionEN.VersionDescription.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strVersionDescription, conClientVersion.VersionDescription); //版本说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conClientVersion.VersionDescription); //版本说明
 }
 }
 
 if (objClientVersionEN.IsUpdated(conClientVersion.VersionNumber))
 {
 if (objClientVersionEN.VersionNumber !=  null)
 {
 var strVersionNumber = objClientVersionEN.VersionNumber.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strVersionNumber, conClientVersion.VersionNumber); //版本号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conClientVersion.VersionNumber); //版本号
 }
 }
 
 if (objClientVersionEN.IsUpdated(conClientVersion.VersionState))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objClientVersionEN.VersionState == true?"1":"0", conClientVersion.VersionState); //版本状态
 }
 
 if (objClientVersionEN.IsUpdated(conClientVersion.VersionUrl))
 {
 if (objClientVersionEN.VersionUrl !=  null)
 {
 var strVersionUrl = objClientVersionEN.VersionUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strVersionUrl, conClientVersion.VersionUrl); //版本文件
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conClientVersion.VersionUrl); //版本文件
 }
 }
 
 if (objClientVersionEN.IsUpdated(conClientVersion.VersionCode))
 {
 if (objClientVersionEN.VersionCode !=  null)
 {
 var strVersionCode = objClientVersionEN.VersionCode.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strVersionCode, conClientVersion.VersionCode); //VersionCode
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conClientVersion.VersionCode); //VersionCode
 }
 }
 
 if (objClientVersionEN.IsUpdated(conClientVersion.PrjId))
 {
 if (objClientVersionEN.PrjId !=  null)
 {
 var strPrjId = objClientVersionEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPrjId, conClientVersion.PrjId); //PrjId
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conClientVersion.PrjId); //PrjId
 }
 }
 
 if (objClientVersionEN.IsUpdated(conClientVersion.UpdDate))
 {
 if (objClientVersionEN.UpdDate !=  null)
 {
 var strUpdDate = objClientVersionEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conClientVersion.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conClientVersion.UpdDate); //修改日期
 }
 }
 
 if (objClientVersionEN.IsUpdated(conClientVersion.UpdUser))
 {
 if (objClientVersionEN.UpdUser !=  null)
 {
 var strUpdUser = objClientVersionEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conClientVersion.UpdUser); //修改人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conClientVersion.UpdUser); //修改人
 }
 }
 
 if (objClientVersionEN.IsUpdated(conClientVersion.Memo))
 {
 if (objClientVersionEN.Memo !=  null)
 {
 var strMemo = objClientVersionEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conClientVersion.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conClientVersion.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where ClientVersionId = '{0}'", objClientVersionEN.ClientVersionId); 
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
 /// <param name = "strClientVersionId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(string strClientVersionId) 
{
CheckPrimaryKey(strClientVersionId);
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsClientVersionDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 strClientVersionId,
};
 objSQL.ExecSP("ClientVersion_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "strClientVersionId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(string strClientVersionId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
CheckPrimaryKey(strClientVersionId);
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsClientVersionDA.GetSpecSQLObj();
//删除ClientVersion本表中与当前对象有关的记录
strSQL = strSQL + "Delete from ClientVersion where ClientVersionId = " + "'"+ strClientVersionId+"'";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelClientVersion(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsClientVersionDA.GetSpecSQLObj();
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
//删除ClientVersion本表中与当前对象有关的记录
strSQL = strSQL + "Delete from ClientVersion where ClientVersionId in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "strClientVersionId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(string strClientVersionId) 
{
CheckPrimaryKey(strClientVersionId);
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsClientVersionDA.GetSpecSQLObj();
//删除ClientVersion本表中与当前对象有关的记录
strSQL = strSQL + "Delete from ClientVersion where ClientVersionId = " + "'"+ strClientVersionId+"'";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelClientVersion(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsClientVersionDA: DelClientVersion)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsClientVersionDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from ClientVersion where " + strCondition ;
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
public bool DelClientVersionWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsClientVersionDA: DelClientVersionWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsClientVersionDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from ClientVersion where " + strCondition ;
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
 /// <param name = "objClientVersionENS">源对象</param>
 /// <param name = "objClientVersionENT">目标对象</param>
public void CopyTo(clsClientVersionEN objClientVersionENS, clsClientVersionEN objClientVersionENT)
{
objClientVersionENT.ClientVersionId = objClientVersionENS.ClientVersionId; //客户端版本Id
objClientVersionENT.ClientVersionTypeId = objClientVersionENS.ClientVersionTypeId; //客户端版本类型Id
objClientVersionENT.VersionDescription = objClientVersionENS.VersionDescription; //版本说明
objClientVersionENT.VersionNumber = objClientVersionENS.VersionNumber; //版本号
objClientVersionENT.VersionState = objClientVersionENS.VersionState; //版本状态
objClientVersionENT.VersionUrl = objClientVersionENS.VersionUrl; //版本文件
objClientVersionENT.VersionCode = objClientVersionENS.VersionCode; //VersionCode
objClientVersionENT.PrjId = objClientVersionENS.PrjId; //PrjId
objClientVersionENT.UpdDate = objClientVersionENS.UpdDate; //修改日期
objClientVersionENT.UpdUser = objClientVersionENS.UpdUser; //修改人
objClientVersionENT.Memo = objClientVersionENS.Memo; //备注
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsClientVersionEN objClientVersionEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objClientVersionEN.ClientVersionTypeId, conClientVersion.ClientVersionTypeId);
clsCheckSql.CheckFieldNotNull(objClientVersionEN.VersionNumber, conClientVersion.VersionNumber);
clsCheckSql.CheckFieldNotNull(objClientVersionEN.VersionUrl, conClientVersion.VersionUrl);
clsCheckSql.CheckFieldNotNull(objClientVersionEN.VersionCode, conClientVersion.VersionCode);
//检查字段长度
clsCheckSql.CheckFieldLen(objClientVersionEN.ClientVersionId, 8, conClientVersion.ClientVersionId);
clsCheckSql.CheckFieldLen(objClientVersionEN.ClientVersionTypeId, 8, conClientVersion.ClientVersionTypeId);
clsCheckSql.CheckFieldLen(objClientVersionEN.VersionDescription, 1000, conClientVersion.VersionDescription);
clsCheckSql.CheckFieldLen(objClientVersionEN.VersionNumber, 50, conClientVersion.VersionNumber);
clsCheckSql.CheckFieldLen(objClientVersionEN.VersionUrl, 500, conClientVersion.VersionUrl);
clsCheckSql.CheckFieldLen(objClientVersionEN.VersionCode, 50, conClientVersion.VersionCode);
clsCheckSql.CheckFieldLen(objClientVersionEN.PrjId, 4, conClientVersion.PrjId);
clsCheckSql.CheckFieldLen(objClientVersionEN.UpdDate, 20, conClientVersion.UpdDate);
clsCheckSql.CheckFieldLen(objClientVersionEN.UpdUser, 20, conClientVersion.UpdUser);
clsCheckSql.CheckFieldLen(objClientVersionEN.Memo, 1000, conClientVersion.Memo);
//检查字段外键固定长度
 objClientVersionEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsClientVersionEN objClientVersionEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objClientVersionEN.ClientVersionTypeId, 8, conClientVersion.ClientVersionTypeId);
clsCheckSql.CheckFieldLen(objClientVersionEN.VersionDescription, 1000, conClientVersion.VersionDescription);
clsCheckSql.CheckFieldLen(objClientVersionEN.VersionNumber, 50, conClientVersion.VersionNumber);
clsCheckSql.CheckFieldLen(objClientVersionEN.VersionUrl, 500, conClientVersion.VersionUrl);
clsCheckSql.CheckFieldLen(objClientVersionEN.VersionCode, 50, conClientVersion.VersionCode);
clsCheckSql.CheckFieldLen(objClientVersionEN.PrjId, 4, conClientVersion.PrjId);
clsCheckSql.CheckFieldLen(objClientVersionEN.UpdDate, 20, conClientVersion.UpdDate);
clsCheckSql.CheckFieldLen(objClientVersionEN.UpdUser, 20, conClientVersion.UpdUser);
clsCheckSql.CheckFieldLen(objClientVersionEN.Memo, 1000, conClientVersion.Memo);
//检查外键字段长度
 objClientVersionEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsClientVersionEN objClientVersionEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objClientVersionEN.ClientVersionId, 8, conClientVersion.ClientVersionId);
clsCheckSql.CheckFieldLen(objClientVersionEN.ClientVersionTypeId, 8, conClientVersion.ClientVersionTypeId);
clsCheckSql.CheckFieldLen(objClientVersionEN.VersionDescription, 1000, conClientVersion.VersionDescription);
clsCheckSql.CheckFieldLen(objClientVersionEN.VersionNumber, 50, conClientVersion.VersionNumber);
clsCheckSql.CheckFieldLen(objClientVersionEN.VersionUrl, 500, conClientVersion.VersionUrl);
clsCheckSql.CheckFieldLen(objClientVersionEN.VersionCode, 50, conClientVersion.VersionCode);
clsCheckSql.CheckFieldLen(objClientVersionEN.PrjId, 4, conClientVersion.PrjId);
clsCheckSql.CheckFieldLen(objClientVersionEN.UpdDate, 20, conClientVersion.UpdDate);
clsCheckSql.CheckFieldLen(objClientVersionEN.UpdUser, 20, conClientVersion.UpdUser);
clsCheckSql.CheckFieldLen(objClientVersionEN.Memo, 1000, conClientVersion.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objClientVersionEN.ClientVersionId, conClientVersion.ClientVersionId);
clsCheckSql.CheckSqlInjection4Field(objClientVersionEN.ClientVersionTypeId, conClientVersion.ClientVersionTypeId);
clsCheckSql.CheckSqlInjection4Field(objClientVersionEN.VersionDescription, conClientVersion.VersionDescription);
clsCheckSql.CheckSqlInjection4Field(objClientVersionEN.VersionNumber, conClientVersion.VersionNumber);
clsCheckSql.CheckSqlInjection4Field(objClientVersionEN.VersionUrl, conClientVersion.VersionUrl);
clsCheckSql.CheckSqlInjection4Field(objClientVersionEN.VersionCode, conClientVersion.VersionCode);
clsCheckSql.CheckSqlInjection4Field(objClientVersionEN.PrjId, conClientVersion.PrjId);
clsCheckSql.CheckSqlInjection4Field(objClientVersionEN.UpdDate, conClientVersion.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objClientVersionEN.UpdUser, conClientVersion.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objClientVersionEN.Memo, conClientVersion.Memo);
//检查外键字段长度
 objClientVersionEN._IsCheckProperty = true;
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
 objSQL = clsClientVersionDA.GetSpecSQLObj();
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
 objSQL = clsClientVersionDA.GetSpecSQLObj();
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
 objSQL = clsClientVersionDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsClientVersionEN._CurrTabName);
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
 objSQL = clsClientVersionDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsClientVersionEN._CurrTabName, strCondition);
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
 objSQL = clsClientVersionDA.GetSpecSQLObj();
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
 objSQL = clsClientVersionDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}