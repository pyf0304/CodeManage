
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvPubClassCaseSenateGaugeVersionDA
 表名:vPubClassCaseSenateGaugeVersion(01120505)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:48:50
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:课例观摩(PubicClassSenate)
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
 /// v公开课评价量规版本(vPubClassCaseSenateGaugeVersion)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvPubClassCaseSenateGaugeVersionDA : clsCommBase4DA
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
 return clsvPubClassCaseSenateGaugeVersionEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvPubClassCaseSenateGaugeVersionEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvPubClassCaseSenateGaugeVersionEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvPubClassCaseSenateGaugeVersionEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvPubClassCaseSenateGaugeVersionEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strIdPubClassCaseSenateGaugeVersion">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strIdPubClassCaseSenateGaugeVersion)
{
strIdPubClassCaseSenateGaugeVersion = strIdPubClassCaseSenateGaugeVersion.Replace("'", "''");
if (strIdPubClassCaseSenateGaugeVersion.Length > 4)
{
throw new Exception("(errid:Data000001)在表:vPubClassCaseSenateGaugeVersion中,检查关键字,长度不正确!(clsvPubClassCaseSenateGaugeVersionDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strIdPubClassCaseSenateGaugeVersion)  ==  true)
{
throw new Exception("(errid:Data000002)在表:vPubClassCaseSenateGaugeVersion中,关键字不能为空 或 null!(clsvPubClassCaseSenateGaugeVersionDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strIdPubClassCaseSenateGaugeVersion);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsvPubClassCaseSenateGaugeVersionDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvPubClassCaseSenateGaugeVersionDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPubClassCaseSenateGaugeVersionDA.GetSpecSQLObj();
strSQL = "Select * from vPubClassCaseSenateGaugeVersion where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vPubClassCaseSenateGaugeVersion(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvPubClassCaseSenateGaugeVersionDA: GetDataTable_vPubClassCaseSenateGaugeVersion)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPubClassCaseSenateGaugeVersionDA.GetSpecSQLObj();
strSQL = "Select * from vPubClassCaseSenateGaugeVersion where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvPubClassCaseSenateGaugeVersionDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPubClassCaseSenateGaugeVersionDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvPubClassCaseSenateGaugeVersionDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPubClassCaseSenateGaugeVersionDA.GetSpecSQLObj();
strSQL = "Select * from vPubClassCaseSenateGaugeVersion where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvPubClassCaseSenateGaugeVersionDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPubClassCaseSenateGaugeVersionDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvPubClassCaseSenateGaugeVersionDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPubClassCaseSenateGaugeVersionDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vPubClassCaseSenateGaugeVersion where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vPubClassCaseSenateGaugeVersion where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvPubClassCaseSenateGaugeVersionDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPubClassCaseSenateGaugeVersionDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vPubClassCaseSenateGaugeVersion where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvPubClassCaseSenateGaugeVersionDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPubClassCaseSenateGaugeVersionDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vPubClassCaseSenateGaugeVersion.* from vPubClassCaseSenateGaugeVersion Left Join {1} on {2} where {3} and vPubClassCaseSenateGaugeVersion.IdPubClassCaseSenateGaugeVersion not in (Select top {5} vPubClassCaseSenateGaugeVersion.IdPubClassCaseSenateGaugeVersion from vPubClassCaseSenateGaugeVersion Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vPubClassCaseSenateGaugeVersion where {1} and IdPubClassCaseSenateGaugeVersion not in (Select top {2} IdPubClassCaseSenateGaugeVersion from vPubClassCaseSenateGaugeVersion where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vPubClassCaseSenateGaugeVersion where {1} and IdPubClassCaseSenateGaugeVersion not in (Select top {3} IdPubClassCaseSenateGaugeVersion from vPubClassCaseSenateGaugeVersion where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvPubClassCaseSenateGaugeVersionDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPubClassCaseSenateGaugeVersionDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vPubClassCaseSenateGaugeVersion.* from vPubClassCaseSenateGaugeVersion Left Join {1} on {2} where {3} and vPubClassCaseSenateGaugeVersion.IdPubClassCaseSenateGaugeVersion not in (Select top {5} vPubClassCaseSenateGaugeVersion.IdPubClassCaseSenateGaugeVersion from vPubClassCaseSenateGaugeVersion Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vPubClassCaseSenateGaugeVersion where {1} and IdPubClassCaseSenateGaugeVersion not in (Select top {2} IdPubClassCaseSenateGaugeVersion from vPubClassCaseSenateGaugeVersion where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vPubClassCaseSenateGaugeVersion where {1} and IdPubClassCaseSenateGaugeVersion not in (Select top {3} IdPubClassCaseSenateGaugeVersion from vPubClassCaseSenateGaugeVersion where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvPubClassCaseSenateGaugeVersionEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvPubClassCaseSenateGaugeVersionDA:GetObjLst)", objException.Message));
}
List<clsvPubClassCaseSenateGaugeVersionEN> arrObjLst = new List<clsvPubClassCaseSenateGaugeVersionEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPubClassCaseSenateGaugeVersionDA.GetSpecSQLObj();
strSQL = "Select * from vPubClassCaseSenateGaugeVersion where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPubClassCaseSenateGaugeVersionEN objvPubClassCaseSenateGaugeVersionEN = new clsvPubClassCaseSenateGaugeVersionEN();
try
{
objvPubClassCaseSenateGaugeVersionEN.IdPubClassCaseSenateGaugeVersion = objRow[convPubClassCaseSenateGaugeVersion.IdPubClassCaseSenateGaugeVersion].ToString().Trim(); //公开课量表版本流水号
objvPubClassCaseSenateGaugeVersionEN.senateGaugeVersionID = objRow[convPubClassCaseSenateGaugeVersion.senateGaugeVersionID] == DBNull.Value ? null : objRow[convPubClassCaseSenateGaugeVersion.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvPubClassCaseSenateGaugeVersionEN.senateGaugeVersionName = objRow[convPubClassCaseSenateGaugeVersion.senateGaugeVersionName] == DBNull.Value ? null : objRow[convPubClassCaseSenateGaugeVersion.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvPubClassCaseSenateGaugeVersionEN.VersionNo = objRow[convPubClassCaseSenateGaugeVersion.VersionNo] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPubClassCaseSenateGaugeVersion.VersionNo].ToString().Trim()); //版本号
objvPubClassCaseSenateGaugeVersionEN.IsUse = TransNullToBool(objRow[convPubClassCaseSenateGaugeVersion.IsUse].ToString().Trim()); //是否使用
objvPubClassCaseSenateGaugeVersionEN.senateGaugeVersionTtlScore = objRow[convPubClassCaseSenateGaugeVersion.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convPubClassCaseSenateGaugeVersion.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvPubClassCaseSenateGaugeVersionEN.senateGaugeVersionMemo = objRow[convPubClassCaseSenateGaugeVersion.senateGaugeVersionMemo] == DBNull.Value ? null : objRow[convPubClassCaseSenateGaugeVersion.senateGaugeVersionMemo].ToString().Trim(); //评价量表版本说明
objvPubClassCaseSenateGaugeVersionEN.SenateGaugeNum = objRow[convPubClassCaseSenateGaugeVersion.SenateGaugeNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPubClassCaseSenateGaugeVersion.SenateGaugeNum].ToString().Trim()); //SenateGaugeNum
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvPubClassCaseSenateGaugeVersionDA: GetObjLst)", objException.Message));
}
objvPubClassCaseSenateGaugeVersionEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvPubClassCaseSenateGaugeVersionEN);
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
public List<clsvPubClassCaseSenateGaugeVersionEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvPubClassCaseSenateGaugeVersionDA:GetObjLstByTabName)", objException.Message));
}
List<clsvPubClassCaseSenateGaugeVersionEN> arrObjLst = new List<clsvPubClassCaseSenateGaugeVersionEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPubClassCaseSenateGaugeVersionDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPubClassCaseSenateGaugeVersionEN objvPubClassCaseSenateGaugeVersionEN = new clsvPubClassCaseSenateGaugeVersionEN();
try
{
objvPubClassCaseSenateGaugeVersionEN.IdPubClassCaseSenateGaugeVersion = objRow[convPubClassCaseSenateGaugeVersion.IdPubClassCaseSenateGaugeVersion].ToString().Trim(); //公开课量表版本流水号
objvPubClassCaseSenateGaugeVersionEN.senateGaugeVersionID = objRow[convPubClassCaseSenateGaugeVersion.senateGaugeVersionID] == DBNull.Value ? null : objRow[convPubClassCaseSenateGaugeVersion.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvPubClassCaseSenateGaugeVersionEN.senateGaugeVersionName = objRow[convPubClassCaseSenateGaugeVersion.senateGaugeVersionName] == DBNull.Value ? null : objRow[convPubClassCaseSenateGaugeVersion.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvPubClassCaseSenateGaugeVersionEN.VersionNo = objRow[convPubClassCaseSenateGaugeVersion.VersionNo] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPubClassCaseSenateGaugeVersion.VersionNo].ToString().Trim()); //版本号
objvPubClassCaseSenateGaugeVersionEN.IsUse = TransNullToBool(objRow[convPubClassCaseSenateGaugeVersion.IsUse].ToString().Trim()); //是否使用
objvPubClassCaseSenateGaugeVersionEN.senateGaugeVersionTtlScore = objRow[convPubClassCaseSenateGaugeVersion.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convPubClassCaseSenateGaugeVersion.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvPubClassCaseSenateGaugeVersionEN.senateGaugeVersionMemo = objRow[convPubClassCaseSenateGaugeVersion.senateGaugeVersionMemo] == DBNull.Value ? null : objRow[convPubClassCaseSenateGaugeVersion.senateGaugeVersionMemo].ToString().Trim(); //评价量表版本说明
objvPubClassCaseSenateGaugeVersionEN.SenateGaugeNum = objRow[convPubClassCaseSenateGaugeVersion.SenateGaugeNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPubClassCaseSenateGaugeVersion.SenateGaugeNum].ToString().Trim()); //SenateGaugeNum
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvPubClassCaseSenateGaugeVersionDA: GetObjLst)", objException.Message));
}
objvPubClassCaseSenateGaugeVersionEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvPubClassCaseSenateGaugeVersionEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvPubClassCaseSenateGaugeVersionEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvPubClassCaseSenateGaugeVersion(ref clsvPubClassCaseSenateGaugeVersionEN objvPubClassCaseSenateGaugeVersionEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPubClassCaseSenateGaugeVersionDA.GetSpecSQLObj();
strSQL = "Select * from vPubClassCaseSenateGaugeVersion where IdPubClassCaseSenateGaugeVersion = " + "'"+ objvPubClassCaseSenateGaugeVersionEN.IdPubClassCaseSenateGaugeVersion+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvPubClassCaseSenateGaugeVersionEN.IdPubClassCaseSenateGaugeVersion = objDT.Rows[0][convPubClassCaseSenateGaugeVersion.IdPubClassCaseSenateGaugeVersion].ToString().Trim(); //公开课量表版本流水号(字段类型:char,字段长度:4,是否可空:False)
 objvPubClassCaseSenateGaugeVersionEN.senateGaugeVersionID = objDT.Rows[0][convPubClassCaseSenateGaugeVersion.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID(字段类型:char,字段长度:4,是否可空:False)
 objvPubClassCaseSenateGaugeVersionEN.senateGaugeVersionName = objDT.Rows[0][convPubClassCaseSenateGaugeVersion.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称(字段类型:varchar,字段长度:200,是否可空:True)
 objvPubClassCaseSenateGaugeVersionEN.VersionNo = TransNullToInt(objDT.Rows[0][convPubClassCaseSenateGaugeVersion.VersionNo].ToString().Trim()); //版本号(字段类型:int,字段长度:4,是否可空:True)
 objvPubClassCaseSenateGaugeVersionEN.IsUse = TransNullToBool(objDT.Rows[0][convPubClassCaseSenateGaugeVersion.IsUse].ToString().Trim()); //是否使用(字段类型:bit,字段长度:1,是否可空:True)
 objvPubClassCaseSenateGaugeVersionEN.senateGaugeVersionTtlScore = TransNullToFloat(objDT.Rows[0][convPubClassCaseSenateGaugeVersion.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分(字段类型:float,字段长度:8,是否可空:False)
 objvPubClassCaseSenateGaugeVersionEN.senateGaugeVersionMemo = objDT.Rows[0][convPubClassCaseSenateGaugeVersion.senateGaugeVersionMemo].ToString().Trim(); //评价量表版本说明(字段类型:varchar,字段长度:1000,是否可空:True)
 objvPubClassCaseSenateGaugeVersionEN.SenateGaugeNum = TransNullToInt(objDT.Rows[0][convPubClassCaseSenateGaugeVersion.SenateGaugeNum].ToString().Trim()); //SenateGaugeNum(字段类型:int,字段长度:4,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvPubClassCaseSenateGaugeVersionDA: GetvPubClassCaseSenateGaugeVersion)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strIdPubClassCaseSenateGaugeVersion">表关键字</param>
 /// <returns>表对象</returns>
public clsvPubClassCaseSenateGaugeVersionEN GetObjByIdPubClassCaseSenateGaugeVersion(string strIdPubClassCaseSenateGaugeVersion)
{
CheckPrimaryKey(strIdPubClassCaseSenateGaugeVersion);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPubClassCaseSenateGaugeVersionDA.GetSpecSQLObj();
strSQL = "Select * from vPubClassCaseSenateGaugeVersion where IdPubClassCaseSenateGaugeVersion = " + "'"+ strIdPubClassCaseSenateGaugeVersion+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvPubClassCaseSenateGaugeVersionEN objvPubClassCaseSenateGaugeVersionEN = new clsvPubClassCaseSenateGaugeVersionEN();
try
{
 objvPubClassCaseSenateGaugeVersionEN.IdPubClassCaseSenateGaugeVersion = objRow[convPubClassCaseSenateGaugeVersion.IdPubClassCaseSenateGaugeVersion].ToString().Trim(); //公开课量表版本流水号(字段类型:char,字段长度:4,是否可空:False)
 objvPubClassCaseSenateGaugeVersionEN.senateGaugeVersionID = objRow[convPubClassCaseSenateGaugeVersion.senateGaugeVersionID] == DBNull.Value ? null : objRow[convPubClassCaseSenateGaugeVersion.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID(字段类型:char,字段长度:4,是否可空:False)
 objvPubClassCaseSenateGaugeVersionEN.senateGaugeVersionName = objRow[convPubClassCaseSenateGaugeVersion.senateGaugeVersionName] == DBNull.Value ? null : objRow[convPubClassCaseSenateGaugeVersion.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称(字段类型:varchar,字段长度:200,是否可空:True)
 objvPubClassCaseSenateGaugeVersionEN.VersionNo = objRow[convPubClassCaseSenateGaugeVersion.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPubClassCaseSenateGaugeVersion.VersionNo].ToString().Trim()); //版本号(字段类型:int,字段长度:4,是否可空:True)
 objvPubClassCaseSenateGaugeVersionEN.IsUse = clsEntityBase2.TransNullToBool_S(objRow[convPubClassCaseSenateGaugeVersion.IsUse].ToString().Trim()); //是否使用(字段类型:bit,字段长度:1,是否可空:True)
 objvPubClassCaseSenateGaugeVersionEN.senateGaugeVersionTtlScore = objRow[convPubClassCaseSenateGaugeVersion.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convPubClassCaseSenateGaugeVersion.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分(字段类型:float,字段长度:8,是否可空:False)
 objvPubClassCaseSenateGaugeVersionEN.senateGaugeVersionMemo = objRow[convPubClassCaseSenateGaugeVersion.senateGaugeVersionMemo] == DBNull.Value ? null : objRow[convPubClassCaseSenateGaugeVersion.senateGaugeVersionMemo].ToString().Trim(); //评价量表版本说明(字段类型:varchar,字段长度:1000,是否可空:True)
 objvPubClassCaseSenateGaugeVersionEN.SenateGaugeNum = objRow[convPubClassCaseSenateGaugeVersion.SenateGaugeNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPubClassCaseSenateGaugeVersion.SenateGaugeNum].ToString().Trim()); //SenateGaugeNum(字段类型:int,字段长度:4,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvPubClassCaseSenateGaugeVersionDA: GetObjByIdPubClassCaseSenateGaugeVersion)", objException.Message));
}
return objvPubClassCaseSenateGaugeVersionEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvPubClassCaseSenateGaugeVersionEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvPubClassCaseSenateGaugeVersionDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPubClassCaseSenateGaugeVersionDA.GetSpecSQLObj();
strSQL = "Select * from vPubClassCaseSenateGaugeVersion where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvPubClassCaseSenateGaugeVersionEN objvPubClassCaseSenateGaugeVersionEN = new clsvPubClassCaseSenateGaugeVersionEN()
{
IdPubClassCaseSenateGaugeVersion = objRow[convPubClassCaseSenateGaugeVersion.IdPubClassCaseSenateGaugeVersion].ToString().Trim(), //公开课量表版本流水号
senateGaugeVersionID = objRow[convPubClassCaseSenateGaugeVersion.senateGaugeVersionID] == DBNull.Value ? null : objRow[convPubClassCaseSenateGaugeVersion.senateGaugeVersionID].ToString().Trim(), //评价量表版本ID
senateGaugeVersionName = objRow[convPubClassCaseSenateGaugeVersion.senateGaugeVersionName] == DBNull.Value ? null : objRow[convPubClassCaseSenateGaugeVersion.senateGaugeVersionName].ToString().Trim(), //评价量表版本名称
VersionNo = objRow[convPubClassCaseSenateGaugeVersion.VersionNo] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPubClassCaseSenateGaugeVersion.VersionNo].ToString().Trim()), //版本号
IsUse = TransNullToBool(objRow[convPubClassCaseSenateGaugeVersion.IsUse].ToString().Trim()), //是否使用
senateGaugeVersionTtlScore = objRow[convPubClassCaseSenateGaugeVersion.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convPubClassCaseSenateGaugeVersion.senateGaugeVersionTtlScore].ToString().Trim()), //评价量表版本总分
senateGaugeVersionMemo = objRow[convPubClassCaseSenateGaugeVersion.senateGaugeVersionMemo] == DBNull.Value ? null : objRow[convPubClassCaseSenateGaugeVersion.senateGaugeVersionMemo].ToString().Trim(), //评价量表版本说明
SenateGaugeNum = objRow[convPubClassCaseSenateGaugeVersion.SenateGaugeNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPubClassCaseSenateGaugeVersion.SenateGaugeNum].ToString().Trim()) //SenateGaugeNum
};
objvPubClassCaseSenateGaugeVersionEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvPubClassCaseSenateGaugeVersionEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvPubClassCaseSenateGaugeVersionDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvPubClassCaseSenateGaugeVersionEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvPubClassCaseSenateGaugeVersionEN objvPubClassCaseSenateGaugeVersionEN = new clsvPubClassCaseSenateGaugeVersionEN();
try
{
objvPubClassCaseSenateGaugeVersionEN.IdPubClassCaseSenateGaugeVersion = objRow[convPubClassCaseSenateGaugeVersion.IdPubClassCaseSenateGaugeVersion].ToString().Trim(); //公开课量表版本流水号
objvPubClassCaseSenateGaugeVersionEN.senateGaugeVersionID = objRow[convPubClassCaseSenateGaugeVersion.senateGaugeVersionID] == DBNull.Value ? null : objRow[convPubClassCaseSenateGaugeVersion.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvPubClassCaseSenateGaugeVersionEN.senateGaugeVersionName = objRow[convPubClassCaseSenateGaugeVersion.senateGaugeVersionName] == DBNull.Value ? null : objRow[convPubClassCaseSenateGaugeVersion.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvPubClassCaseSenateGaugeVersionEN.VersionNo = objRow[convPubClassCaseSenateGaugeVersion.VersionNo] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPubClassCaseSenateGaugeVersion.VersionNo].ToString().Trim()); //版本号
objvPubClassCaseSenateGaugeVersionEN.IsUse = TransNullToBool(objRow[convPubClassCaseSenateGaugeVersion.IsUse].ToString().Trim()); //是否使用
objvPubClassCaseSenateGaugeVersionEN.senateGaugeVersionTtlScore = objRow[convPubClassCaseSenateGaugeVersion.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convPubClassCaseSenateGaugeVersion.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvPubClassCaseSenateGaugeVersionEN.senateGaugeVersionMemo = objRow[convPubClassCaseSenateGaugeVersion.senateGaugeVersionMemo] == DBNull.Value ? null : objRow[convPubClassCaseSenateGaugeVersion.senateGaugeVersionMemo].ToString().Trim(); //评价量表版本说明
objvPubClassCaseSenateGaugeVersionEN.SenateGaugeNum = objRow[convPubClassCaseSenateGaugeVersion.SenateGaugeNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPubClassCaseSenateGaugeVersion.SenateGaugeNum].ToString().Trim()); //SenateGaugeNum
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvPubClassCaseSenateGaugeVersionDA: GetObjByDataRowvPubClassCaseSenateGaugeVersion)", objException.Message));
}
objvPubClassCaseSenateGaugeVersionEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvPubClassCaseSenateGaugeVersionEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvPubClassCaseSenateGaugeVersionEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvPubClassCaseSenateGaugeVersionEN objvPubClassCaseSenateGaugeVersionEN = new clsvPubClassCaseSenateGaugeVersionEN();
try
{
objvPubClassCaseSenateGaugeVersionEN.IdPubClassCaseSenateGaugeVersion = objRow[convPubClassCaseSenateGaugeVersion.IdPubClassCaseSenateGaugeVersion].ToString().Trim(); //公开课量表版本流水号
objvPubClassCaseSenateGaugeVersionEN.senateGaugeVersionID = objRow[convPubClassCaseSenateGaugeVersion.senateGaugeVersionID] == DBNull.Value ? null : objRow[convPubClassCaseSenateGaugeVersion.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvPubClassCaseSenateGaugeVersionEN.senateGaugeVersionName = objRow[convPubClassCaseSenateGaugeVersion.senateGaugeVersionName] == DBNull.Value ? null : objRow[convPubClassCaseSenateGaugeVersion.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvPubClassCaseSenateGaugeVersionEN.VersionNo = objRow[convPubClassCaseSenateGaugeVersion.VersionNo] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPubClassCaseSenateGaugeVersion.VersionNo].ToString().Trim()); //版本号
objvPubClassCaseSenateGaugeVersionEN.IsUse = TransNullToBool(objRow[convPubClassCaseSenateGaugeVersion.IsUse].ToString().Trim()); //是否使用
objvPubClassCaseSenateGaugeVersionEN.senateGaugeVersionTtlScore = objRow[convPubClassCaseSenateGaugeVersion.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convPubClassCaseSenateGaugeVersion.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvPubClassCaseSenateGaugeVersionEN.senateGaugeVersionMemo = objRow[convPubClassCaseSenateGaugeVersion.senateGaugeVersionMemo] == DBNull.Value ? null : objRow[convPubClassCaseSenateGaugeVersion.senateGaugeVersionMemo].ToString().Trim(); //评价量表版本说明
objvPubClassCaseSenateGaugeVersionEN.SenateGaugeNum = objRow[convPubClassCaseSenateGaugeVersion.SenateGaugeNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPubClassCaseSenateGaugeVersion.SenateGaugeNum].ToString().Trim()); //SenateGaugeNum
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvPubClassCaseSenateGaugeVersionDA: GetObjByDataRow)", objException.Message));
}
objvPubClassCaseSenateGaugeVersionEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvPubClassCaseSenateGaugeVersionEN;
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
objSQL = clsvPubClassCaseSenateGaugeVersionDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvPubClassCaseSenateGaugeVersionEN._CurrTabName, convPubClassCaseSenateGaugeVersion.IdPubClassCaseSenateGaugeVersion, 4, "");
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
objSQL = clsvPubClassCaseSenateGaugeVersionDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvPubClassCaseSenateGaugeVersionEN._CurrTabName, convPubClassCaseSenateGaugeVersion.IdPubClassCaseSenateGaugeVersion, 4, strPrefix);
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
 objSQL = clsvPubClassCaseSenateGaugeVersionDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select IdPubClassCaseSenateGaugeVersion from vPubClassCaseSenateGaugeVersion where " + strCondition;
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
 objSQL = clsvPubClassCaseSenateGaugeVersionDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select IdPubClassCaseSenateGaugeVersion from vPubClassCaseSenateGaugeVersion where " + strCondition;
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
 /// <param name = "strIdPubClassCaseSenateGaugeVersion">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strIdPubClassCaseSenateGaugeVersion)
{
CheckPrimaryKey(strIdPubClassCaseSenateGaugeVersion);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPubClassCaseSenateGaugeVersionDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vPubClassCaseSenateGaugeVersion", "IdPubClassCaseSenateGaugeVersion = " + "'"+ strIdPubClassCaseSenateGaugeVersion+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvPubClassCaseSenateGaugeVersionDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPubClassCaseSenateGaugeVersionDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vPubClassCaseSenateGaugeVersion", strCondition))
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
objSQL = clsvPubClassCaseSenateGaugeVersionDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vPubClassCaseSenateGaugeVersion");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvPubClassCaseSenateGaugeVersionENS">源对象</param>
 /// <param name = "objvPubClassCaseSenateGaugeVersionENT">目标对象</param>
public void CopyTo(clsvPubClassCaseSenateGaugeVersionEN objvPubClassCaseSenateGaugeVersionENS, clsvPubClassCaseSenateGaugeVersionEN objvPubClassCaseSenateGaugeVersionENT)
{
objvPubClassCaseSenateGaugeVersionENT.IdPubClassCaseSenateGaugeVersion = objvPubClassCaseSenateGaugeVersionENS.IdPubClassCaseSenateGaugeVersion; //公开课量表版本流水号
objvPubClassCaseSenateGaugeVersionENT.senateGaugeVersionID = objvPubClassCaseSenateGaugeVersionENS.senateGaugeVersionID; //评价量表版本ID
objvPubClassCaseSenateGaugeVersionENT.senateGaugeVersionName = objvPubClassCaseSenateGaugeVersionENS.senateGaugeVersionName; //评价量表版本名称
objvPubClassCaseSenateGaugeVersionENT.VersionNo = objvPubClassCaseSenateGaugeVersionENS.VersionNo; //版本号
objvPubClassCaseSenateGaugeVersionENT.IsUse = objvPubClassCaseSenateGaugeVersionENS.IsUse; //是否使用
objvPubClassCaseSenateGaugeVersionENT.senateGaugeVersionTtlScore = objvPubClassCaseSenateGaugeVersionENS.senateGaugeVersionTtlScore; //评价量表版本总分
objvPubClassCaseSenateGaugeVersionENT.senateGaugeVersionMemo = objvPubClassCaseSenateGaugeVersionENS.senateGaugeVersionMemo; //评价量表版本说明
objvPubClassCaseSenateGaugeVersionENT.SenateGaugeNum = objvPubClassCaseSenateGaugeVersionENS.SenateGaugeNum; //SenateGaugeNum
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvPubClassCaseSenateGaugeVersionEN objvPubClassCaseSenateGaugeVersionEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvPubClassCaseSenateGaugeVersionEN.IdPubClassCaseSenateGaugeVersion, 4, convPubClassCaseSenateGaugeVersion.IdPubClassCaseSenateGaugeVersion);
clsCheckSql.CheckFieldLen(objvPubClassCaseSenateGaugeVersionEN.senateGaugeVersionID, 4, convPubClassCaseSenateGaugeVersion.senateGaugeVersionID);
clsCheckSql.CheckFieldLen(objvPubClassCaseSenateGaugeVersionEN.senateGaugeVersionName, 200, convPubClassCaseSenateGaugeVersion.senateGaugeVersionName);
clsCheckSql.CheckFieldLen(objvPubClassCaseSenateGaugeVersionEN.senateGaugeVersionMemo, 1000, convPubClassCaseSenateGaugeVersion.senateGaugeVersionMemo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvPubClassCaseSenateGaugeVersionEN.IdPubClassCaseSenateGaugeVersion, convPubClassCaseSenateGaugeVersion.IdPubClassCaseSenateGaugeVersion);
clsCheckSql.CheckSqlInjection4Field(objvPubClassCaseSenateGaugeVersionEN.senateGaugeVersionID, convPubClassCaseSenateGaugeVersion.senateGaugeVersionID);
clsCheckSql.CheckSqlInjection4Field(objvPubClassCaseSenateGaugeVersionEN.senateGaugeVersionName, convPubClassCaseSenateGaugeVersion.senateGaugeVersionName);
clsCheckSql.CheckSqlInjection4Field(objvPubClassCaseSenateGaugeVersionEN.senateGaugeVersionMemo, convPubClassCaseSenateGaugeVersion.senateGaugeVersionMemo);
//检查外键字段长度
 objvPubClassCaseSenateGaugeVersionEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 /// <summary>
 /// 获取用于绑定下拉框的DataTable,获取两个字段:1、关键字；2、名称字段
 /// (AutoGCLib.clsGeneCodeBase:Gen_4DAL_GetDataTable4DdlBind)
 /// </summary>
 /// <returns>返回用于绑定下拉框的DataTable</returns>
public System.Data.DataTable GetIdPubClassCaseSenateGaugeVersion()
{
//获取某学院所有专业信息
string strSQL = "select IdPubClassCaseSenateGaugeVersion, senateGaugeVersionName from vPubClassCaseSenateGaugeVersion ";
 clsSpecSQLforSql mySql = clsvPubClassCaseSenateGaugeVersionDA.GetSpecSQLObj();
System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
return objDT;
}

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
 objSQL = clsvPubClassCaseSenateGaugeVersionDA.GetSpecSQLObj();
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
 objSQL = clsvPubClassCaseSenateGaugeVersionDA.GetSpecSQLObj();
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
 objSQL = clsvPubClassCaseSenateGaugeVersionDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvPubClassCaseSenateGaugeVersionEN._CurrTabName);
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
 objSQL = clsvPubClassCaseSenateGaugeVersionDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvPubClassCaseSenateGaugeVersionEN._CurrTabName, strCondition);
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
 objSQL = clsvPubClassCaseSenateGaugeVersionDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}