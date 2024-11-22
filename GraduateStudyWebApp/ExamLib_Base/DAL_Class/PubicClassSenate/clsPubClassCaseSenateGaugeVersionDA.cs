
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsPubClassCaseSenateGaugeVersionDA
 表名:PubClassCaseSenateGaugeVersion(01120504)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:21:23
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:课例观摩(PubicClassSenate)
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
 /// 公开课评价量规版本(PubClassCaseSenateGaugeVersion)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsPubClassCaseSenateGaugeVersionDA : clsCommBase4DA
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
 return clsPubClassCaseSenateGaugeVersionEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsPubClassCaseSenateGaugeVersionEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsPubClassCaseSenateGaugeVersionEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsPubClassCaseSenateGaugeVersionEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsPubClassCaseSenateGaugeVersionEN._ConnectString);
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
throw new Exception("(errid:Data000001)在表:PubClassCaseSenateGaugeVersion中,检查关键字,长度不正确!(clsPubClassCaseSenateGaugeVersionDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strIdPubClassCaseSenateGaugeVersion)  ==  true)
{
throw new Exception("(errid:Data000002)在表:PubClassCaseSenateGaugeVersion中,关键字不能为空 或 null!(clsPubClassCaseSenateGaugeVersionDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strIdPubClassCaseSenateGaugeVersion);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsPubClassCaseSenateGaugeVersionDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsPubClassCaseSenateGaugeVersionDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPubClassCaseSenateGaugeVersionDA.GetSpecSQLObj();
strSQL = "Select * from PubClassCaseSenateGaugeVersion where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_PubClassCaseSenateGaugeVersion(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsPubClassCaseSenateGaugeVersionDA: GetDataTable_PubClassCaseSenateGaugeVersion)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPubClassCaseSenateGaugeVersionDA.GetSpecSQLObj();
strSQL = "Select * from PubClassCaseSenateGaugeVersion where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsPubClassCaseSenateGaugeVersionDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPubClassCaseSenateGaugeVersionDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsPubClassCaseSenateGaugeVersionDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPubClassCaseSenateGaugeVersionDA.GetSpecSQLObj();
strSQL = "Select * from PubClassCaseSenateGaugeVersion where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsPubClassCaseSenateGaugeVersionDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPubClassCaseSenateGaugeVersionDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsPubClassCaseSenateGaugeVersionDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPubClassCaseSenateGaugeVersionDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from PubClassCaseSenateGaugeVersion where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from PubClassCaseSenateGaugeVersion where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsPubClassCaseSenateGaugeVersionDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPubClassCaseSenateGaugeVersionDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from PubClassCaseSenateGaugeVersion where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsPubClassCaseSenateGaugeVersionDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPubClassCaseSenateGaugeVersionDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} PubClassCaseSenateGaugeVersion.* from PubClassCaseSenateGaugeVersion Left Join {1} on {2} where {3} and PubClassCaseSenateGaugeVersion.IdPubClassCaseSenateGaugeVersion not in (Select top {5} PubClassCaseSenateGaugeVersion.IdPubClassCaseSenateGaugeVersion from PubClassCaseSenateGaugeVersion Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from PubClassCaseSenateGaugeVersion where {1} and IdPubClassCaseSenateGaugeVersion not in (Select top {2} IdPubClassCaseSenateGaugeVersion from PubClassCaseSenateGaugeVersion where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from PubClassCaseSenateGaugeVersion where {1} and IdPubClassCaseSenateGaugeVersion not in (Select top {3} IdPubClassCaseSenateGaugeVersion from PubClassCaseSenateGaugeVersion where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsPubClassCaseSenateGaugeVersionDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPubClassCaseSenateGaugeVersionDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} PubClassCaseSenateGaugeVersion.* from PubClassCaseSenateGaugeVersion Left Join {1} on {2} where {3} and PubClassCaseSenateGaugeVersion.IdPubClassCaseSenateGaugeVersion not in (Select top {5} PubClassCaseSenateGaugeVersion.IdPubClassCaseSenateGaugeVersion from PubClassCaseSenateGaugeVersion Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from PubClassCaseSenateGaugeVersion where {1} and IdPubClassCaseSenateGaugeVersion not in (Select top {2} IdPubClassCaseSenateGaugeVersion from PubClassCaseSenateGaugeVersion where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from PubClassCaseSenateGaugeVersion where {1} and IdPubClassCaseSenateGaugeVersion not in (Select top {3} IdPubClassCaseSenateGaugeVersion from PubClassCaseSenateGaugeVersion where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsPubClassCaseSenateGaugeVersionEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsPubClassCaseSenateGaugeVersionDA:GetObjLst)", objException.Message));
}
List<clsPubClassCaseSenateGaugeVersionEN> arrObjLst = new List<clsPubClassCaseSenateGaugeVersionEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPubClassCaseSenateGaugeVersionDA.GetSpecSQLObj();
strSQL = "Select * from PubClassCaseSenateGaugeVersion where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPubClassCaseSenateGaugeVersionEN objPubClassCaseSenateGaugeVersionEN = new clsPubClassCaseSenateGaugeVersionEN();
try
{
objPubClassCaseSenateGaugeVersionEN.IdPubClassCaseSenateGaugeVersion = objRow[conPubClassCaseSenateGaugeVersion.IdPubClassCaseSenateGaugeVersion].ToString().Trim(); //公开课量表版本流水号
objPubClassCaseSenateGaugeVersionEN.senateGaugeVersionID = objRow[conPubClassCaseSenateGaugeVersion.senateGaugeVersionID] == DBNull.Value ? null : objRow[conPubClassCaseSenateGaugeVersion.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objPubClassCaseSenateGaugeVersionEN.senateGaugeVersionName = objRow[conPubClassCaseSenateGaugeVersion.senateGaugeVersionName] == DBNull.Value ? null : objRow[conPubClassCaseSenateGaugeVersion.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objPubClassCaseSenateGaugeVersionEN.senateGaugeVersionTtlScore = objRow[conPubClassCaseSenateGaugeVersion.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conPubClassCaseSenateGaugeVersion.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objPubClassCaseSenateGaugeVersionEN.IsUse = TransNullToBool(objRow[conPubClassCaseSenateGaugeVersion.IsUse].ToString().Trim()); //是否使用
objPubClassCaseSenateGaugeVersionEN.VersionNo = objRow[conPubClassCaseSenateGaugeVersion.VersionNo] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conPubClassCaseSenateGaugeVersion.VersionNo].ToString().Trim()); //版本号
objPubClassCaseSenateGaugeVersionEN.senateGaugeVersionMemo = objRow[conPubClassCaseSenateGaugeVersion.senateGaugeVersionMemo] == DBNull.Value ? null : objRow[conPubClassCaseSenateGaugeVersion.senateGaugeVersionMemo].ToString().Trim(); //评价量表版本说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsPubClassCaseSenateGaugeVersionDA: GetObjLst)", objException.Message));
}
objPubClassCaseSenateGaugeVersionEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objPubClassCaseSenateGaugeVersionEN);
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
public List<clsPubClassCaseSenateGaugeVersionEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsPubClassCaseSenateGaugeVersionDA:GetObjLstByTabName)", objException.Message));
}
List<clsPubClassCaseSenateGaugeVersionEN> arrObjLst = new List<clsPubClassCaseSenateGaugeVersionEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPubClassCaseSenateGaugeVersionDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPubClassCaseSenateGaugeVersionEN objPubClassCaseSenateGaugeVersionEN = new clsPubClassCaseSenateGaugeVersionEN();
try
{
objPubClassCaseSenateGaugeVersionEN.IdPubClassCaseSenateGaugeVersion = objRow[conPubClassCaseSenateGaugeVersion.IdPubClassCaseSenateGaugeVersion].ToString().Trim(); //公开课量表版本流水号
objPubClassCaseSenateGaugeVersionEN.senateGaugeVersionID = objRow[conPubClassCaseSenateGaugeVersion.senateGaugeVersionID] == DBNull.Value ? null : objRow[conPubClassCaseSenateGaugeVersion.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objPubClassCaseSenateGaugeVersionEN.senateGaugeVersionName = objRow[conPubClassCaseSenateGaugeVersion.senateGaugeVersionName] == DBNull.Value ? null : objRow[conPubClassCaseSenateGaugeVersion.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objPubClassCaseSenateGaugeVersionEN.senateGaugeVersionTtlScore = objRow[conPubClassCaseSenateGaugeVersion.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conPubClassCaseSenateGaugeVersion.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objPubClassCaseSenateGaugeVersionEN.IsUse = TransNullToBool(objRow[conPubClassCaseSenateGaugeVersion.IsUse].ToString().Trim()); //是否使用
objPubClassCaseSenateGaugeVersionEN.VersionNo = objRow[conPubClassCaseSenateGaugeVersion.VersionNo] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conPubClassCaseSenateGaugeVersion.VersionNo].ToString().Trim()); //版本号
objPubClassCaseSenateGaugeVersionEN.senateGaugeVersionMemo = objRow[conPubClassCaseSenateGaugeVersion.senateGaugeVersionMemo] == DBNull.Value ? null : objRow[conPubClassCaseSenateGaugeVersion.senateGaugeVersionMemo].ToString().Trim(); //评价量表版本说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsPubClassCaseSenateGaugeVersionDA: GetObjLst)", objException.Message));
}
objPubClassCaseSenateGaugeVersionEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objPubClassCaseSenateGaugeVersionEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objPubClassCaseSenateGaugeVersionEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetPubClassCaseSenateGaugeVersion(ref clsPubClassCaseSenateGaugeVersionEN objPubClassCaseSenateGaugeVersionEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPubClassCaseSenateGaugeVersionDA.GetSpecSQLObj();
strSQL = "Select * from PubClassCaseSenateGaugeVersion where IdPubClassCaseSenateGaugeVersion = " + "'"+ objPubClassCaseSenateGaugeVersionEN.IdPubClassCaseSenateGaugeVersion+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objPubClassCaseSenateGaugeVersionEN.IdPubClassCaseSenateGaugeVersion = objDT.Rows[0][conPubClassCaseSenateGaugeVersion.IdPubClassCaseSenateGaugeVersion].ToString().Trim(); //公开课量表版本流水号(字段类型:char,字段长度:4,是否可空:False)
 objPubClassCaseSenateGaugeVersionEN.senateGaugeVersionID = objDT.Rows[0][conPubClassCaseSenateGaugeVersion.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID(字段类型:char,字段长度:4,是否可空:False)
 objPubClassCaseSenateGaugeVersionEN.senateGaugeVersionName = objDT.Rows[0][conPubClassCaseSenateGaugeVersion.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称(字段类型:varchar,字段长度:200,是否可空:True)
 objPubClassCaseSenateGaugeVersionEN.senateGaugeVersionTtlScore = TransNullToFloat(objDT.Rows[0][conPubClassCaseSenateGaugeVersion.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分(字段类型:float,字段长度:8,是否可空:False)
 objPubClassCaseSenateGaugeVersionEN.IsUse = TransNullToBool(objDT.Rows[0][conPubClassCaseSenateGaugeVersion.IsUse].ToString().Trim()); //是否使用(字段类型:bit,字段长度:1,是否可空:True)
 objPubClassCaseSenateGaugeVersionEN.VersionNo = TransNullToInt(objDT.Rows[0][conPubClassCaseSenateGaugeVersion.VersionNo].ToString().Trim()); //版本号(字段类型:int,字段长度:4,是否可空:True)
 objPubClassCaseSenateGaugeVersionEN.senateGaugeVersionMemo = objDT.Rows[0][conPubClassCaseSenateGaugeVersion.senateGaugeVersionMemo].ToString().Trim(); //评价量表版本说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsPubClassCaseSenateGaugeVersionDA: GetPubClassCaseSenateGaugeVersion)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strIdPubClassCaseSenateGaugeVersion">表关键字</param>
 /// <returns>表对象</returns>
public clsPubClassCaseSenateGaugeVersionEN GetObjByIdPubClassCaseSenateGaugeVersion(string strIdPubClassCaseSenateGaugeVersion)
{
CheckPrimaryKey(strIdPubClassCaseSenateGaugeVersion);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPubClassCaseSenateGaugeVersionDA.GetSpecSQLObj();
strSQL = "Select * from PubClassCaseSenateGaugeVersion where IdPubClassCaseSenateGaugeVersion = " + "'"+ strIdPubClassCaseSenateGaugeVersion+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsPubClassCaseSenateGaugeVersionEN objPubClassCaseSenateGaugeVersionEN = new clsPubClassCaseSenateGaugeVersionEN();
try
{
 objPubClassCaseSenateGaugeVersionEN.IdPubClassCaseSenateGaugeVersion = objRow[conPubClassCaseSenateGaugeVersion.IdPubClassCaseSenateGaugeVersion].ToString().Trim(); //公开课量表版本流水号(字段类型:char,字段长度:4,是否可空:False)
 objPubClassCaseSenateGaugeVersionEN.senateGaugeVersionID = objRow[conPubClassCaseSenateGaugeVersion.senateGaugeVersionID] == DBNull.Value ? null : objRow[conPubClassCaseSenateGaugeVersion.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID(字段类型:char,字段长度:4,是否可空:False)
 objPubClassCaseSenateGaugeVersionEN.senateGaugeVersionName = objRow[conPubClassCaseSenateGaugeVersion.senateGaugeVersionName] == DBNull.Value ? null : objRow[conPubClassCaseSenateGaugeVersion.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称(字段类型:varchar,字段长度:200,是否可空:True)
 objPubClassCaseSenateGaugeVersionEN.senateGaugeVersionTtlScore = objRow[conPubClassCaseSenateGaugeVersion.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conPubClassCaseSenateGaugeVersion.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分(字段类型:float,字段长度:8,是否可空:False)
 objPubClassCaseSenateGaugeVersionEN.IsUse = clsEntityBase2.TransNullToBool_S(objRow[conPubClassCaseSenateGaugeVersion.IsUse].ToString().Trim()); //是否使用(字段类型:bit,字段长度:1,是否可空:True)
 objPubClassCaseSenateGaugeVersionEN.VersionNo = objRow[conPubClassCaseSenateGaugeVersion.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPubClassCaseSenateGaugeVersion.VersionNo].ToString().Trim()); //版本号(字段类型:int,字段长度:4,是否可空:True)
 objPubClassCaseSenateGaugeVersionEN.senateGaugeVersionMemo = objRow[conPubClassCaseSenateGaugeVersion.senateGaugeVersionMemo] == DBNull.Value ? null : objRow[conPubClassCaseSenateGaugeVersion.senateGaugeVersionMemo].ToString().Trim(); //评价量表版本说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsPubClassCaseSenateGaugeVersionDA: GetObjByIdPubClassCaseSenateGaugeVersion)", objException.Message));
}
return objPubClassCaseSenateGaugeVersionEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsPubClassCaseSenateGaugeVersionEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsPubClassCaseSenateGaugeVersionDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPubClassCaseSenateGaugeVersionDA.GetSpecSQLObj();
strSQL = "Select * from PubClassCaseSenateGaugeVersion where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsPubClassCaseSenateGaugeVersionEN objPubClassCaseSenateGaugeVersionEN = new clsPubClassCaseSenateGaugeVersionEN()
{
IdPubClassCaseSenateGaugeVersion = objRow[conPubClassCaseSenateGaugeVersion.IdPubClassCaseSenateGaugeVersion].ToString().Trim(), //公开课量表版本流水号
senateGaugeVersionID = objRow[conPubClassCaseSenateGaugeVersion.senateGaugeVersionID] == DBNull.Value ? null : objRow[conPubClassCaseSenateGaugeVersion.senateGaugeVersionID].ToString().Trim(), //评价量表版本ID
senateGaugeVersionName = objRow[conPubClassCaseSenateGaugeVersion.senateGaugeVersionName] == DBNull.Value ? null : objRow[conPubClassCaseSenateGaugeVersion.senateGaugeVersionName].ToString().Trim(), //评价量表版本名称
senateGaugeVersionTtlScore = objRow[conPubClassCaseSenateGaugeVersion.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conPubClassCaseSenateGaugeVersion.senateGaugeVersionTtlScore].ToString().Trim()), //评价量表版本总分
IsUse = TransNullToBool(objRow[conPubClassCaseSenateGaugeVersion.IsUse].ToString().Trim()), //是否使用
VersionNo = objRow[conPubClassCaseSenateGaugeVersion.VersionNo] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conPubClassCaseSenateGaugeVersion.VersionNo].ToString().Trim()), //版本号
senateGaugeVersionMemo = objRow[conPubClassCaseSenateGaugeVersion.senateGaugeVersionMemo] == DBNull.Value ? null : objRow[conPubClassCaseSenateGaugeVersion.senateGaugeVersionMemo].ToString().Trim() //评价量表版本说明
};
objPubClassCaseSenateGaugeVersionEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objPubClassCaseSenateGaugeVersionEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsPubClassCaseSenateGaugeVersionDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsPubClassCaseSenateGaugeVersionEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsPubClassCaseSenateGaugeVersionEN objPubClassCaseSenateGaugeVersionEN = new clsPubClassCaseSenateGaugeVersionEN();
try
{
objPubClassCaseSenateGaugeVersionEN.IdPubClassCaseSenateGaugeVersion = objRow[conPubClassCaseSenateGaugeVersion.IdPubClassCaseSenateGaugeVersion].ToString().Trim(); //公开课量表版本流水号
objPubClassCaseSenateGaugeVersionEN.senateGaugeVersionID = objRow[conPubClassCaseSenateGaugeVersion.senateGaugeVersionID] == DBNull.Value ? null : objRow[conPubClassCaseSenateGaugeVersion.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objPubClassCaseSenateGaugeVersionEN.senateGaugeVersionName = objRow[conPubClassCaseSenateGaugeVersion.senateGaugeVersionName] == DBNull.Value ? null : objRow[conPubClassCaseSenateGaugeVersion.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objPubClassCaseSenateGaugeVersionEN.senateGaugeVersionTtlScore = objRow[conPubClassCaseSenateGaugeVersion.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conPubClassCaseSenateGaugeVersion.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objPubClassCaseSenateGaugeVersionEN.IsUse = TransNullToBool(objRow[conPubClassCaseSenateGaugeVersion.IsUse].ToString().Trim()); //是否使用
objPubClassCaseSenateGaugeVersionEN.VersionNo = objRow[conPubClassCaseSenateGaugeVersion.VersionNo] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conPubClassCaseSenateGaugeVersion.VersionNo].ToString().Trim()); //版本号
objPubClassCaseSenateGaugeVersionEN.senateGaugeVersionMemo = objRow[conPubClassCaseSenateGaugeVersion.senateGaugeVersionMemo] == DBNull.Value ? null : objRow[conPubClassCaseSenateGaugeVersion.senateGaugeVersionMemo].ToString().Trim(); //评价量表版本说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsPubClassCaseSenateGaugeVersionDA: GetObjByDataRowPubClassCaseSenateGaugeVersion)", objException.Message));
}
objPubClassCaseSenateGaugeVersionEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objPubClassCaseSenateGaugeVersionEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsPubClassCaseSenateGaugeVersionEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsPubClassCaseSenateGaugeVersionEN objPubClassCaseSenateGaugeVersionEN = new clsPubClassCaseSenateGaugeVersionEN();
try
{
objPubClassCaseSenateGaugeVersionEN.IdPubClassCaseSenateGaugeVersion = objRow[conPubClassCaseSenateGaugeVersion.IdPubClassCaseSenateGaugeVersion].ToString().Trim(); //公开课量表版本流水号
objPubClassCaseSenateGaugeVersionEN.senateGaugeVersionID = objRow[conPubClassCaseSenateGaugeVersion.senateGaugeVersionID] == DBNull.Value ? null : objRow[conPubClassCaseSenateGaugeVersion.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objPubClassCaseSenateGaugeVersionEN.senateGaugeVersionName = objRow[conPubClassCaseSenateGaugeVersion.senateGaugeVersionName] == DBNull.Value ? null : objRow[conPubClassCaseSenateGaugeVersion.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objPubClassCaseSenateGaugeVersionEN.senateGaugeVersionTtlScore = objRow[conPubClassCaseSenateGaugeVersion.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conPubClassCaseSenateGaugeVersion.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objPubClassCaseSenateGaugeVersionEN.IsUse = TransNullToBool(objRow[conPubClassCaseSenateGaugeVersion.IsUse].ToString().Trim()); //是否使用
objPubClassCaseSenateGaugeVersionEN.VersionNo = objRow[conPubClassCaseSenateGaugeVersion.VersionNo] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conPubClassCaseSenateGaugeVersion.VersionNo].ToString().Trim()); //版本号
objPubClassCaseSenateGaugeVersionEN.senateGaugeVersionMemo = objRow[conPubClassCaseSenateGaugeVersion.senateGaugeVersionMemo] == DBNull.Value ? null : objRow[conPubClassCaseSenateGaugeVersion.senateGaugeVersionMemo].ToString().Trim(); //评价量表版本说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsPubClassCaseSenateGaugeVersionDA: GetObjByDataRow)", objException.Message));
}
objPubClassCaseSenateGaugeVersionEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objPubClassCaseSenateGaugeVersionEN;
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
objSQL = clsPubClassCaseSenateGaugeVersionDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsPubClassCaseSenateGaugeVersionEN._CurrTabName, conPubClassCaseSenateGaugeVersion.IdPubClassCaseSenateGaugeVersion, 4, "");
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
objSQL = clsPubClassCaseSenateGaugeVersionDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsPubClassCaseSenateGaugeVersionEN._CurrTabName, conPubClassCaseSenateGaugeVersion.IdPubClassCaseSenateGaugeVersion, 4, strPrefix);
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
 objSQL = clsPubClassCaseSenateGaugeVersionDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select IdPubClassCaseSenateGaugeVersion from PubClassCaseSenateGaugeVersion where " + strCondition;
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
 objSQL = clsPubClassCaseSenateGaugeVersionDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select IdPubClassCaseSenateGaugeVersion from PubClassCaseSenateGaugeVersion where " + strCondition;
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
 objSQL = clsPubClassCaseSenateGaugeVersionDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("PubClassCaseSenateGaugeVersion", "IdPubClassCaseSenateGaugeVersion = " + "'"+ strIdPubClassCaseSenateGaugeVersion+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsPubClassCaseSenateGaugeVersionDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPubClassCaseSenateGaugeVersionDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("PubClassCaseSenateGaugeVersion", strCondition))
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
objSQL = clsPubClassCaseSenateGaugeVersionDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("PubClassCaseSenateGaugeVersion");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsPubClassCaseSenateGaugeVersionEN objPubClassCaseSenateGaugeVersionEN)
 {
 if (objPubClassCaseSenateGaugeVersionEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objPubClassCaseSenateGaugeVersionEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPubClassCaseSenateGaugeVersionDA.GetSpecSQLObj();
strSQL = "Select * from PubClassCaseSenateGaugeVersion where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "PubClassCaseSenateGaugeVersion");
objRow = objDS.Tables["PubClassCaseSenateGaugeVersion"].NewRow();
objRow[conPubClassCaseSenateGaugeVersion.IdPubClassCaseSenateGaugeVersion] = objPubClassCaseSenateGaugeVersionEN.IdPubClassCaseSenateGaugeVersion; //公开课量表版本流水号
 if (objPubClassCaseSenateGaugeVersionEN.senateGaugeVersionID !=  "")
 {
objRow[conPubClassCaseSenateGaugeVersion.senateGaugeVersionID] = objPubClassCaseSenateGaugeVersionEN.senateGaugeVersionID; //评价量表版本ID
 }
 if (objPubClassCaseSenateGaugeVersionEN.senateGaugeVersionName !=  "")
 {
objRow[conPubClassCaseSenateGaugeVersion.senateGaugeVersionName] = objPubClassCaseSenateGaugeVersionEN.senateGaugeVersionName; //评价量表版本名称
 }
objRow[conPubClassCaseSenateGaugeVersion.senateGaugeVersionTtlScore] = objPubClassCaseSenateGaugeVersionEN.senateGaugeVersionTtlScore; //评价量表版本总分
objRow[conPubClassCaseSenateGaugeVersion.IsUse] = objPubClassCaseSenateGaugeVersionEN.IsUse; //是否使用
objRow[conPubClassCaseSenateGaugeVersion.VersionNo] = objPubClassCaseSenateGaugeVersionEN.VersionNo; //版本号
 if (objPubClassCaseSenateGaugeVersionEN.senateGaugeVersionMemo !=  "")
 {
objRow[conPubClassCaseSenateGaugeVersion.senateGaugeVersionMemo] = objPubClassCaseSenateGaugeVersionEN.senateGaugeVersionMemo; //评价量表版本说明
 }
objDS.Tables[clsPubClassCaseSenateGaugeVersionEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsPubClassCaseSenateGaugeVersionEN._CurrTabName);
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
 /// <param name = "objPubClassCaseSenateGaugeVersionEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsPubClassCaseSenateGaugeVersionEN objPubClassCaseSenateGaugeVersionEN)
{
 if (objPubClassCaseSenateGaugeVersionEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objPubClassCaseSenateGaugeVersionEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objPubClassCaseSenateGaugeVersionEN.IdPubClassCaseSenateGaugeVersion !=  null)
 {
 arrFieldListForInsert.Add(conPubClassCaseSenateGaugeVersion.IdPubClassCaseSenateGaugeVersion);
 var strIdPubClassCaseSenateGaugeVersion = objPubClassCaseSenateGaugeVersionEN.IdPubClassCaseSenateGaugeVersion.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdPubClassCaseSenateGaugeVersion + "'");
 }
 
 if (objPubClassCaseSenateGaugeVersionEN.senateGaugeVersionID !=  null)
 {
 arrFieldListForInsert.Add(conPubClassCaseSenateGaugeVersion.senateGaugeVersionID);
 var strsenateGaugeVersionID = objPubClassCaseSenateGaugeVersionEN.senateGaugeVersionID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strsenateGaugeVersionID + "'");
 }
 
 if (objPubClassCaseSenateGaugeVersionEN.senateGaugeVersionName !=  null)
 {
 arrFieldListForInsert.Add(conPubClassCaseSenateGaugeVersion.senateGaugeVersionName);
 var strsenateGaugeVersionName = objPubClassCaseSenateGaugeVersionEN.senateGaugeVersionName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strsenateGaugeVersionName + "'");
 }
 
 if (objPubClassCaseSenateGaugeVersionEN.senateGaugeVersionTtlScore !=  null)
 {
 arrFieldListForInsert.Add(conPubClassCaseSenateGaugeVersion.senateGaugeVersionTtlScore);
 arrValueListForInsert.Add(objPubClassCaseSenateGaugeVersionEN.senateGaugeVersionTtlScore.ToString());
 }
 
 arrFieldListForInsert.Add(conPubClassCaseSenateGaugeVersion.IsUse);
 arrValueListForInsert.Add("'" + (objPubClassCaseSenateGaugeVersionEN.IsUse  ==  false ? "0" : "1") + "'");
 
 if (objPubClassCaseSenateGaugeVersionEN.VersionNo !=  null)
 {
 arrFieldListForInsert.Add(conPubClassCaseSenateGaugeVersion.VersionNo);
 arrValueListForInsert.Add(objPubClassCaseSenateGaugeVersionEN.VersionNo.ToString());
 }
 
 if (objPubClassCaseSenateGaugeVersionEN.senateGaugeVersionMemo !=  null)
 {
 arrFieldListForInsert.Add(conPubClassCaseSenateGaugeVersion.senateGaugeVersionMemo);
 var strsenateGaugeVersionMemo = objPubClassCaseSenateGaugeVersionEN.senateGaugeVersionMemo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strsenateGaugeVersionMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into PubClassCaseSenateGaugeVersion");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPubClassCaseSenateGaugeVersionDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objPubClassCaseSenateGaugeVersionEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsPubClassCaseSenateGaugeVersionEN objPubClassCaseSenateGaugeVersionEN)
{
 if (objPubClassCaseSenateGaugeVersionEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objPubClassCaseSenateGaugeVersionEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objPubClassCaseSenateGaugeVersionEN.IdPubClassCaseSenateGaugeVersion !=  null)
 {
 arrFieldListForInsert.Add(conPubClassCaseSenateGaugeVersion.IdPubClassCaseSenateGaugeVersion);
 var strIdPubClassCaseSenateGaugeVersion = objPubClassCaseSenateGaugeVersionEN.IdPubClassCaseSenateGaugeVersion.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdPubClassCaseSenateGaugeVersion + "'");
 }
 
 if (objPubClassCaseSenateGaugeVersionEN.senateGaugeVersionID !=  null)
 {
 arrFieldListForInsert.Add(conPubClassCaseSenateGaugeVersion.senateGaugeVersionID);
 var strsenateGaugeVersionID = objPubClassCaseSenateGaugeVersionEN.senateGaugeVersionID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strsenateGaugeVersionID + "'");
 }
 
 if (objPubClassCaseSenateGaugeVersionEN.senateGaugeVersionName !=  null)
 {
 arrFieldListForInsert.Add(conPubClassCaseSenateGaugeVersion.senateGaugeVersionName);
 var strsenateGaugeVersionName = objPubClassCaseSenateGaugeVersionEN.senateGaugeVersionName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strsenateGaugeVersionName + "'");
 }
 
 if (objPubClassCaseSenateGaugeVersionEN.senateGaugeVersionTtlScore !=  null)
 {
 arrFieldListForInsert.Add(conPubClassCaseSenateGaugeVersion.senateGaugeVersionTtlScore);
 arrValueListForInsert.Add(objPubClassCaseSenateGaugeVersionEN.senateGaugeVersionTtlScore.ToString());
 }
 
 arrFieldListForInsert.Add(conPubClassCaseSenateGaugeVersion.IsUse);
 arrValueListForInsert.Add("'" + (objPubClassCaseSenateGaugeVersionEN.IsUse  ==  false ? "0" : "1") + "'");
 
 if (objPubClassCaseSenateGaugeVersionEN.VersionNo !=  null)
 {
 arrFieldListForInsert.Add(conPubClassCaseSenateGaugeVersion.VersionNo);
 arrValueListForInsert.Add(objPubClassCaseSenateGaugeVersionEN.VersionNo.ToString());
 }
 
 if (objPubClassCaseSenateGaugeVersionEN.senateGaugeVersionMemo !=  null)
 {
 arrFieldListForInsert.Add(conPubClassCaseSenateGaugeVersion.senateGaugeVersionMemo);
 var strsenateGaugeVersionMemo = objPubClassCaseSenateGaugeVersionEN.senateGaugeVersionMemo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strsenateGaugeVersionMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into PubClassCaseSenateGaugeVersion");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPubClassCaseSenateGaugeVersionDA.GetSpecSQLObj();
 objSQL.ExecSql(strSQL.ToString());
return objPubClassCaseSenateGaugeVersionEN.IdPubClassCaseSenateGaugeVersion;
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objPubClassCaseSenateGaugeVersionEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsPubClassCaseSenateGaugeVersionEN objPubClassCaseSenateGaugeVersionEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objPubClassCaseSenateGaugeVersionEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objPubClassCaseSenateGaugeVersionEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objPubClassCaseSenateGaugeVersionEN.IdPubClassCaseSenateGaugeVersion !=  null)
 {
 arrFieldListForInsert.Add(conPubClassCaseSenateGaugeVersion.IdPubClassCaseSenateGaugeVersion);
 var strIdPubClassCaseSenateGaugeVersion = objPubClassCaseSenateGaugeVersionEN.IdPubClassCaseSenateGaugeVersion.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdPubClassCaseSenateGaugeVersion + "'");
 }
 
 if (objPubClassCaseSenateGaugeVersionEN.senateGaugeVersionID !=  null)
 {
 arrFieldListForInsert.Add(conPubClassCaseSenateGaugeVersion.senateGaugeVersionID);
 var strsenateGaugeVersionID = objPubClassCaseSenateGaugeVersionEN.senateGaugeVersionID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strsenateGaugeVersionID + "'");
 }
 
 if (objPubClassCaseSenateGaugeVersionEN.senateGaugeVersionName !=  null)
 {
 arrFieldListForInsert.Add(conPubClassCaseSenateGaugeVersion.senateGaugeVersionName);
 var strsenateGaugeVersionName = objPubClassCaseSenateGaugeVersionEN.senateGaugeVersionName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strsenateGaugeVersionName + "'");
 }
 
 if (objPubClassCaseSenateGaugeVersionEN.senateGaugeVersionTtlScore !=  null)
 {
 arrFieldListForInsert.Add(conPubClassCaseSenateGaugeVersion.senateGaugeVersionTtlScore);
 arrValueListForInsert.Add(objPubClassCaseSenateGaugeVersionEN.senateGaugeVersionTtlScore.ToString());
 }
 
 arrFieldListForInsert.Add(conPubClassCaseSenateGaugeVersion.IsUse);
 arrValueListForInsert.Add("'" + (objPubClassCaseSenateGaugeVersionEN.IsUse  ==  false ? "0" : "1") + "'");
 
 if (objPubClassCaseSenateGaugeVersionEN.VersionNo !=  null)
 {
 arrFieldListForInsert.Add(conPubClassCaseSenateGaugeVersion.VersionNo);
 arrValueListForInsert.Add(objPubClassCaseSenateGaugeVersionEN.VersionNo.ToString());
 }
 
 if (objPubClassCaseSenateGaugeVersionEN.senateGaugeVersionMemo !=  null)
 {
 arrFieldListForInsert.Add(conPubClassCaseSenateGaugeVersion.senateGaugeVersionMemo);
 var strsenateGaugeVersionMemo = objPubClassCaseSenateGaugeVersionEN.senateGaugeVersionMemo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strsenateGaugeVersionMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into PubClassCaseSenateGaugeVersion");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPubClassCaseSenateGaugeVersionDA.GetSpecSQLObj();
    objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
return objPubClassCaseSenateGaugeVersionEN.IdPubClassCaseSenateGaugeVersion;
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objPubClassCaseSenateGaugeVersionEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsPubClassCaseSenateGaugeVersionEN objPubClassCaseSenateGaugeVersionEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objPubClassCaseSenateGaugeVersionEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objPubClassCaseSenateGaugeVersionEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objPubClassCaseSenateGaugeVersionEN.IdPubClassCaseSenateGaugeVersion !=  null)
 {
 arrFieldListForInsert.Add(conPubClassCaseSenateGaugeVersion.IdPubClassCaseSenateGaugeVersion);
 var strIdPubClassCaseSenateGaugeVersion = objPubClassCaseSenateGaugeVersionEN.IdPubClassCaseSenateGaugeVersion.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdPubClassCaseSenateGaugeVersion + "'");
 }
 
 if (objPubClassCaseSenateGaugeVersionEN.senateGaugeVersionID !=  null)
 {
 arrFieldListForInsert.Add(conPubClassCaseSenateGaugeVersion.senateGaugeVersionID);
 var strsenateGaugeVersionID = objPubClassCaseSenateGaugeVersionEN.senateGaugeVersionID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strsenateGaugeVersionID + "'");
 }
 
 if (objPubClassCaseSenateGaugeVersionEN.senateGaugeVersionName !=  null)
 {
 arrFieldListForInsert.Add(conPubClassCaseSenateGaugeVersion.senateGaugeVersionName);
 var strsenateGaugeVersionName = objPubClassCaseSenateGaugeVersionEN.senateGaugeVersionName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strsenateGaugeVersionName + "'");
 }
 
 if (objPubClassCaseSenateGaugeVersionEN.senateGaugeVersionTtlScore !=  null)
 {
 arrFieldListForInsert.Add(conPubClassCaseSenateGaugeVersion.senateGaugeVersionTtlScore);
 arrValueListForInsert.Add(objPubClassCaseSenateGaugeVersionEN.senateGaugeVersionTtlScore.ToString());
 }
 
 arrFieldListForInsert.Add(conPubClassCaseSenateGaugeVersion.IsUse);
 arrValueListForInsert.Add("'" + (objPubClassCaseSenateGaugeVersionEN.IsUse  ==  false ? "0" : "1") + "'");
 
 if (objPubClassCaseSenateGaugeVersionEN.VersionNo !=  null)
 {
 arrFieldListForInsert.Add(conPubClassCaseSenateGaugeVersion.VersionNo);
 arrValueListForInsert.Add(objPubClassCaseSenateGaugeVersionEN.VersionNo.ToString());
 }
 
 if (objPubClassCaseSenateGaugeVersionEN.senateGaugeVersionMemo !=  null)
 {
 arrFieldListForInsert.Add(conPubClassCaseSenateGaugeVersion.senateGaugeVersionMemo);
 var strsenateGaugeVersionMemo = objPubClassCaseSenateGaugeVersionEN.senateGaugeVersionMemo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strsenateGaugeVersionMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into PubClassCaseSenateGaugeVersion");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPubClassCaseSenateGaugeVersionDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewPubClassCaseSenateGaugeVersions(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPubClassCaseSenateGaugeVersionDA.GetSpecSQLObj();
strSQL = "Select * from PubClassCaseSenateGaugeVersion where IdPubClassCaseSenateGaugeVersion = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "PubClassCaseSenateGaugeVersion");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
string strIdPubClassCaseSenateGaugeVersion = oRow[conPubClassCaseSenateGaugeVersion.IdPubClassCaseSenateGaugeVersion].ToString().Trim();
if (IsExist(strIdPubClassCaseSenateGaugeVersion))
{
 string strResult = "关键字变量值为:" + string.Format("IdPubClassCaseSenateGaugeVersion = {0}", strIdPubClassCaseSenateGaugeVersion) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsPubClassCaseSenateGaugeVersionEN._CurrTabName ].NewRow();
objRow[conPubClassCaseSenateGaugeVersion.IdPubClassCaseSenateGaugeVersion] = oRow[conPubClassCaseSenateGaugeVersion.IdPubClassCaseSenateGaugeVersion].ToString().Trim(); //公开课量表版本流水号
objRow[conPubClassCaseSenateGaugeVersion.senateGaugeVersionID] = oRow[conPubClassCaseSenateGaugeVersion.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objRow[conPubClassCaseSenateGaugeVersion.senateGaugeVersionName] = oRow[conPubClassCaseSenateGaugeVersion.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objRow[conPubClassCaseSenateGaugeVersion.senateGaugeVersionTtlScore] = oRow[conPubClassCaseSenateGaugeVersion.senateGaugeVersionTtlScore].ToString().Trim(); //评价量表版本总分
objRow[conPubClassCaseSenateGaugeVersion.IsUse] = oRow[conPubClassCaseSenateGaugeVersion.IsUse].ToString().Trim(); //是否使用
objRow[conPubClassCaseSenateGaugeVersion.VersionNo] = oRow[conPubClassCaseSenateGaugeVersion.VersionNo].ToString().Trim(); //版本号
objRow[conPubClassCaseSenateGaugeVersion.senateGaugeVersionMemo] = oRow[conPubClassCaseSenateGaugeVersion.senateGaugeVersionMemo].ToString().Trim(); //评价量表版本说明
 objDS.Tables[clsPubClassCaseSenateGaugeVersionEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsPubClassCaseSenateGaugeVersionEN._CurrTabName);
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
 /// <param name = "objPubClassCaseSenateGaugeVersionEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsPubClassCaseSenateGaugeVersionEN objPubClassCaseSenateGaugeVersionEN)
{
 if (objPubClassCaseSenateGaugeVersionEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objPubClassCaseSenateGaugeVersionEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPubClassCaseSenateGaugeVersionDA.GetSpecSQLObj();
strSQL = "Select * from PubClassCaseSenateGaugeVersion where IdPubClassCaseSenateGaugeVersion = " + "'"+ objPubClassCaseSenateGaugeVersionEN.IdPubClassCaseSenateGaugeVersion+"'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsPubClassCaseSenateGaugeVersionEN._CurrTabName);
if (objDS.Tables[clsPubClassCaseSenateGaugeVersionEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:IdPubClassCaseSenateGaugeVersion = " + "'"+ objPubClassCaseSenateGaugeVersionEN.IdPubClassCaseSenateGaugeVersion+"'");
return false;
}
objRow = objDS.Tables[clsPubClassCaseSenateGaugeVersionEN._CurrTabName].Rows[0];
 if (objPubClassCaseSenateGaugeVersionEN.IsUpdated(conPubClassCaseSenateGaugeVersion.IdPubClassCaseSenateGaugeVersion))
 {
objRow[conPubClassCaseSenateGaugeVersion.IdPubClassCaseSenateGaugeVersion] = objPubClassCaseSenateGaugeVersionEN.IdPubClassCaseSenateGaugeVersion; //公开课量表版本流水号
 }
 if (objPubClassCaseSenateGaugeVersionEN.IsUpdated(conPubClassCaseSenateGaugeVersion.senateGaugeVersionID))
 {
objRow[conPubClassCaseSenateGaugeVersion.senateGaugeVersionID] = objPubClassCaseSenateGaugeVersionEN.senateGaugeVersionID; //评价量表版本ID
 }
 if (objPubClassCaseSenateGaugeVersionEN.IsUpdated(conPubClassCaseSenateGaugeVersion.senateGaugeVersionName))
 {
objRow[conPubClassCaseSenateGaugeVersion.senateGaugeVersionName] = objPubClassCaseSenateGaugeVersionEN.senateGaugeVersionName; //评价量表版本名称
 }
 if (objPubClassCaseSenateGaugeVersionEN.IsUpdated(conPubClassCaseSenateGaugeVersion.senateGaugeVersionTtlScore))
 {
objRow[conPubClassCaseSenateGaugeVersion.senateGaugeVersionTtlScore] = objPubClassCaseSenateGaugeVersionEN.senateGaugeVersionTtlScore; //评价量表版本总分
 }
 if (objPubClassCaseSenateGaugeVersionEN.IsUpdated(conPubClassCaseSenateGaugeVersion.IsUse))
 {
objRow[conPubClassCaseSenateGaugeVersion.IsUse] = objPubClassCaseSenateGaugeVersionEN.IsUse; //是否使用
 }
 if (objPubClassCaseSenateGaugeVersionEN.IsUpdated(conPubClassCaseSenateGaugeVersion.VersionNo))
 {
objRow[conPubClassCaseSenateGaugeVersion.VersionNo] = objPubClassCaseSenateGaugeVersionEN.VersionNo; //版本号
 }
 if (objPubClassCaseSenateGaugeVersionEN.IsUpdated(conPubClassCaseSenateGaugeVersion.senateGaugeVersionMemo))
 {
objRow[conPubClassCaseSenateGaugeVersion.senateGaugeVersionMemo] = objPubClassCaseSenateGaugeVersionEN.senateGaugeVersionMemo; //评价量表版本说明
 }
try
{
objDA.Update(objDS, clsPubClassCaseSenateGaugeVersionEN._CurrTabName);
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
 /// <param name = "objPubClassCaseSenateGaugeVersionEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsPubClassCaseSenateGaugeVersionEN objPubClassCaseSenateGaugeVersionEN)
{
 if (objPubClassCaseSenateGaugeVersionEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objPubClassCaseSenateGaugeVersionEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPubClassCaseSenateGaugeVersionDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update PubClassCaseSenateGaugeVersion Set ");
 
 if (objPubClassCaseSenateGaugeVersionEN.IsUpdated(conPubClassCaseSenateGaugeVersion.senateGaugeVersionID))
 {
 if (objPubClassCaseSenateGaugeVersionEN.senateGaugeVersionID !=  null)
 {
 var strsenateGaugeVersionID = objPubClassCaseSenateGaugeVersionEN.senateGaugeVersionID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strsenateGaugeVersionID, conPubClassCaseSenateGaugeVersion.senateGaugeVersionID); //评价量表版本ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPubClassCaseSenateGaugeVersion.senateGaugeVersionID); //评价量表版本ID
 }
 }
 
 if (objPubClassCaseSenateGaugeVersionEN.IsUpdated(conPubClassCaseSenateGaugeVersion.senateGaugeVersionName))
 {
 if (objPubClassCaseSenateGaugeVersionEN.senateGaugeVersionName !=  null)
 {
 var strsenateGaugeVersionName = objPubClassCaseSenateGaugeVersionEN.senateGaugeVersionName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strsenateGaugeVersionName, conPubClassCaseSenateGaugeVersion.senateGaugeVersionName); //评价量表版本名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPubClassCaseSenateGaugeVersion.senateGaugeVersionName); //评价量表版本名称
 }
 }
 
 if (objPubClassCaseSenateGaugeVersionEN.IsUpdated(conPubClassCaseSenateGaugeVersion.senateGaugeVersionTtlScore))
 {
 if (objPubClassCaseSenateGaugeVersionEN.senateGaugeVersionTtlScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objPubClassCaseSenateGaugeVersionEN.senateGaugeVersionTtlScore, conPubClassCaseSenateGaugeVersion.senateGaugeVersionTtlScore); //评价量表版本总分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPubClassCaseSenateGaugeVersion.senateGaugeVersionTtlScore); //评价量表版本总分
 }
 }
 
 if (objPubClassCaseSenateGaugeVersionEN.IsUpdated(conPubClassCaseSenateGaugeVersion.IsUse))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objPubClassCaseSenateGaugeVersionEN.IsUse == true?"1":"0", conPubClassCaseSenateGaugeVersion.IsUse); //是否使用
 }
 
 if (objPubClassCaseSenateGaugeVersionEN.IsUpdated(conPubClassCaseSenateGaugeVersion.VersionNo))
 {
 if (objPubClassCaseSenateGaugeVersionEN.VersionNo !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objPubClassCaseSenateGaugeVersionEN.VersionNo, conPubClassCaseSenateGaugeVersion.VersionNo); //版本号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPubClassCaseSenateGaugeVersion.VersionNo); //版本号
 }
 }
 
 if (objPubClassCaseSenateGaugeVersionEN.IsUpdated(conPubClassCaseSenateGaugeVersion.senateGaugeVersionMemo))
 {
 if (objPubClassCaseSenateGaugeVersionEN.senateGaugeVersionMemo !=  null)
 {
 var strsenateGaugeVersionMemo = objPubClassCaseSenateGaugeVersionEN.senateGaugeVersionMemo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strsenateGaugeVersionMemo, conPubClassCaseSenateGaugeVersion.senateGaugeVersionMemo); //评价量表版本说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPubClassCaseSenateGaugeVersion.senateGaugeVersionMemo); //评价量表版本说明
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where IdPubClassCaseSenateGaugeVersion = '{0}'", objPubClassCaseSenateGaugeVersionEN.IdPubClassCaseSenateGaugeVersion); 
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
 /// <param name = "objPubClassCaseSenateGaugeVersionEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsPubClassCaseSenateGaugeVersionEN objPubClassCaseSenateGaugeVersionEN, string strCondition)
{
 if (objPubClassCaseSenateGaugeVersionEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objPubClassCaseSenateGaugeVersionEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPubClassCaseSenateGaugeVersionDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update PubClassCaseSenateGaugeVersion Set ");
 
 if (objPubClassCaseSenateGaugeVersionEN.IsUpdated(conPubClassCaseSenateGaugeVersion.senateGaugeVersionID))
 {
 if (objPubClassCaseSenateGaugeVersionEN.senateGaugeVersionID !=  null)
 {
 var strsenateGaugeVersionID = objPubClassCaseSenateGaugeVersionEN.senateGaugeVersionID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" senateGaugeVersionID = '{0}',", strsenateGaugeVersionID); //评价量表版本ID
 }
 else
 {
 sbSQL.Append(" senateGaugeVersionID = null,"); //评价量表版本ID
 }
 }
 
 if (objPubClassCaseSenateGaugeVersionEN.IsUpdated(conPubClassCaseSenateGaugeVersion.senateGaugeVersionName))
 {
 if (objPubClassCaseSenateGaugeVersionEN.senateGaugeVersionName !=  null)
 {
 var strsenateGaugeVersionName = objPubClassCaseSenateGaugeVersionEN.senateGaugeVersionName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" senateGaugeVersionName = '{0}',", strsenateGaugeVersionName); //评价量表版本名称
 }
 else
 {
 sbSQL.Append(" senateGaugeVersionName = null,"); //评价量表版本名称
 }
 }
 
 if (objPubClassCaseSenateGaugeVersionEN.IsUpdated(conPubClassCaseSenateGaugeVersion.senateGaugeVersionTtlScore))
 {
 if (objPubClassCaseSenateGaugeVersionEN.senateGaugeVersionTtlScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objPubClassCaseSenateGaugeVersionEN.senateGaugeVersionTtlScore, conPubClassCaseSenateGaugeVersion.senateGaugeVersionTtlScore); //评价量表版本总分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPubClassCaseSenateGaugeVersion.senateGaugeVersionTtlScore); //评价量表版本总分
 }
 }
 
 if (objPubClassCaseSenateGaugeVersionEN.IsUpdated(conPubClassCaseSenateGaugeVersion.IsUse))
 {
 sbSQL.AppendFormat(" IsUse = '{0}',", objPubClassCaseSenateGaugeVersionEN.IsUse == true?"1":"0"); //是否使用
 }
 
 if (objPubClassCaseSenateGaugeVersionEN.IsUpdated(conPubClassCaseSenateGaugeVersion.VersionNo))
 {
 if (objPubClassCaseSenateGaugeVersionEN.VersionNo !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objPubClassCaseSenateGaugeVersionEN.VersionNo, conPubClassCaseSenateGaugeVersion.VersionNo); //版本号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPubClassCaseSenateGaugeVersion.VersionNo); //版本号
 }
 }
 
 if (objPubClassCaseSenateGaugeVersionEN.IsUpdated(conPubClassCaseSenateGaugeVersion.senateGaugeVersionMemo))
 {
 if (objPubClassCaseSenateGaugeVersionEN.senateGaugeVersionMemo !=  null)
 {
 var strsenateGaugeVersionMemo = objPubClassCaseSenateGaugeVersionEN.senateGaugeVersionMemo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" senateGaugeVersionMemo = '{0}',", strsenateGaugeVersionMemo); //评价量表版本说明
 }
 else
 {
 sbSQL.Append(" senateGaugeVersionMemo = null,"); //评价量表版本说明
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
 /// <param name = "objPubClassCaseSenateGaugeVersionEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsPubClassCaseSenateGaugeVersionEN objPubClassCaseSenateGaugeVersionEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objPubClassCaseSenateGaugeVersionEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objPubClassCaseSenateGaugeVersionEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPubClassCaseSenateGaugeVersionDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update PubClassCaseSenateGaugeVersion Set ");
 
 if (objPubClassCaseSenateGaugeVersionEN.IsUpdated(conPubClassCaseSenateGaugeVersion.senateGaugeVersionID))
 {
 if (objPubClassCaseSenateGaugeVersionEN.senateGaugeVersionID !=  null)
 {
 var strsenateGaugeVersionID = objPubClassCaseSenateGaugeVersionEN.senateGaugeVersionID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" senateGaugeVersionID = '{0}',", strsenateGaugeVersionID); //评价量表版本ID
 }
 else
 {
 sbSQL.Append(" senateGaugeVersionID = null,"); //评价量表版本ID
 }
 }
 
 if (objPubClassCaseSenateGaugeVersionEN.IsUpdated(conPubClassCaseSenateGaugeVersion.senateGaugeVersionName))
 {
 if (objPubClassCaseSenateGaugeVersionEN.senateGaugeVersionName !=  null)
 {
 var strsenateGaugeVersionName = objPubClassCaseSenateGaugeVersionEN.senateGaugeVersionName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" senateGaugeVersionName = '{0}',", strsenateGaugeVersionName); //评价量表版本名称
 }
 else
 {
 sbSQL.Append(" senateGaugeVersionName = null,"); //评价量表版本名称
 }
 }
 
 if (objPubClassCaseSenateGaugeVersionEN.IsUpdated(conPubClassCaseSenateGaugeVersion.senateGaugeVersionTtlScore))
 {
 if (objPubClassCaseSenateGaugeVersionEN.senateGaugeVersionTtlScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objPubClassCaseSenateGaugeVersionEN.senateGaugeVersionTtlScore, conPubClassCaseSenateGaugeVersion.senateGaugeVersionTtlScore); //评价量表版本总分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPubClassCaseSenateGaugeVersion.senateGaugeVersionTtlScore); //评价量表版本总分
 }
 }
 
 if (objPubClassCaseSenateGaugeVersionEN.IsUpdated(conPubClassCaseSenateGaugeVersion.IsUse))
 {
 sbSQL.AppendFormat(" IsUse = '{0}',", objPubClassCaseSenateGaugeVersionEN.IsUse == true?"1":"0"); //是否使用
 }
 
 if (objPubClassCaseSenateGaugeVersionEN.IsUpdated(conPubClassCaseSenateGaugeVersion.VersionNo))
 {
 if (objPubClassCaseSenateGaugeVersionEN.VersionNo !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objPubClassCaseSenateGaugeVersionEN.VersionNo, conPubClassCaseSenateGaugeVersion.VersionNo); //版本号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPubClassCaseSenateGaugeVersion.VersionNo); //版本号
 }
 }
 
 if (objPubClassCaseSenateGaugeVersionEN.IsUpdated(conPubClassCaseSenateGaugeVersion.senateGaugeVersionMemo))
 {
 if (objPubClassCaseSenateGaugeVersionEN.senateGaugeVersionMemo !=  null)
 {
 var strsenateGaugeVersionMemo = objPubClassCaseSenateGaugeVersionEN.senateGaugeVersionMemo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" senateGaugeVersionMemo = '{0}',", strsenateGaugeVersionMemo); //评价量表版本说明
 }
 else
 {
 sbSQL.Append(" senateGaugeVersionMemo = null,"); //评价量表版本说明
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
 /// <param name = "objPubClassCaseSenateGaugeVersionEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsPubClassCaseSenateGaugeVersionEN objPubClassCaseSenateGaugeVersionEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objPubClassCaseSenateGaugeVersionEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objPubClassCaseSenateGaugeVersionEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPubClassCaseSenateGaugeVersionDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update PubClassCaseSenateGaugeVersion Set ");
 
 if (objPubClassCaseSenateGaugeVersionEN.IsUpdated(conPubClassCaseSenateGaugeVersion.senateGaugeVersionID))
 {
 if (objPubClassCaseSenateGaugeVersionEN.senateGaugeVersionID !=  null)
 {
 var strsenateGaugeVersionID = objPubClassCaseSenateGaugeVersionEN.senateGaugeVersionID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strsenateGaugeVersionID, conPubClassCaseSenateGaugeVersion.senateGaugeVersionID); //评价量表版本ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPubClassCaseSenateGaugeVersion.senateGaugeVersionID); //评价量表版本ID
 }
 }
 
 if (objPubClassCaseSenateGaugeVersionEN.IsUpdated(conPubClassCaseSenateGaugeVersion.senateGaugeVersionName))
 {
 if (objPubClassCaseSenateGaugeVersionEN.senateGaugeVersionName !=  null)
 {
 var strsenateGaugeVersionName = objPubClassCaseSenateGaugeVersionEN.senateGaugeVersionName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strsenateGaugeVersionName, conPubClassCaseSenateGaugeVersion.senateGaugeVersionName); //评价量表版本名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPubClassCaseSenateGaugeVersion.senateGaugeVersionName); //评价量表版本名称
 }
 }
 
 if (objPubClassCaseSenateGaugeVersionEN.IsUpdated(conPubClassCaseSenateGaugeVersion.senateGaugeVersionTtlScore))
 {
 if (objPubClassCaseSenateGaugeVersionEN.senateGaugeVersionTtlScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objPubClassCaseSenateGaugeVersionEN.senateGaugeVersionTtlScore, conPubClassCaseSenateGaugeVersion.senateGaugeVersionTtlScore); //评价量表版本总分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPubClassCaseSenateGaugeVersion.senateGaugeVersionTtlScore); //评价量表版本总分
 }
 }
 
 if (objPubClassCaseSenateGaugeVersionEN.IsUpdated(conPubClassCaseSenateGaugeVersion.IsUse))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objPubClassCaseSenateGaugeVersionEN.IsUse == true?"1":"0", conPubClassCaseSenateGaugeVersion.IsUse); //是否使用
 }
 
 if (objPubClassCaseSenateGaugeVersionEN.IsUpdated(conPubClassCaseSenateGaugeVersion.VersionNo))
 {
 if (objPubClassCaseSenateGaugeVersionEN.VersionNo !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objPubClassCaseSenateGaugeVersionEN.VersionNo, conPubClassCaseSenateGaugeVersion.VersionNo); //版本号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPubClassCaseSenateGaugeVersion.VersionNo); //版本号
 }
 }
 
 if (objPubClassCaseSenateGaugeVersionEN.IsUpdated(conPubClassCaseSenateGaugeVersion.senateGaugeVersionMemo))
 {
 if (objPubClassCaseSenateGaugeVersionEN.senateGaugeVersionMemo !=  null)
 {
 var strsenateGaugeVersionMemo = objPubClassCaseSenateGaugeVersionEN.senateGaugeVersionMemo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strsenateGaugeVersionMemo, conPubClassCaseSenateGaugeVersion.senateGaugeVersionMemo); //评价量表版本说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPubClassCaseSenateGaugeVersion.senateGaugeVersionMemo); //评价量表版本说明
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where IdPubClassCaseSenateGaugeVersion = '{0}'", objPubClassCaseSenateGaugeVersionEN.IdPubClassCaseSenateGaugeVersion); 
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
 /// <param name = "strIdPubClassCaseSenateGaugeVersion">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(string strIdPubClassCaseSenateGaugeVersion) 
{
CheckPrimaryKey(strIdPubClassCaseSenateGaugeVersion);
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPubClassCaseSenateGaugeVersionDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 strIdPubClassCaseSenateGaugeVersion,
};
 objSQL.ExecSP("PubClassCaseSenateGaugeVersion_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "strIdPubClassCaseSenateGaugeVersion">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(string strIdPubClassCaseSenateGaugeVersion, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
CheckPrimaryKey(strIdPubClassCaseSenateGaugeVersion);
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPubClassCaseSenateGaugeVersionDA.GetSpecSQLObj();
//删除PubClassCaseSenateGaugeVersion本表中与当前对象有关的记录
strSQL = strSQL + "Delete from PubClassCaseSenateGaugeVersion where IdPubClassCaseSenateGaugeVersion = " + "'"+ strIdPubClassCaseSenateGaugeVersion+"'";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelPubClassCaseSenateGaugeVersion(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPubClassCaseSenateGaugeVersionDA.GetSpecSQLObj();
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
//删除PubClassCaseSenateGaugeVersion本表中与当前对象有关的记录
strSQL = strSQL + "Delete from PubClassCaseSenateGaugeVersion where IdPubClassCaseSenateGaugeVersion in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "strIdPubClassCaseSenateGaugeVersion">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(string strIdPubClassCaseSenateGaugeVersion) 
{
CheckPrimaryKey(strIdPubClassCaseSenateGaugeVersion);
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPubClassCaseSenateGaugeVersionDA.GetSpecSQLObj();
//删除PubClassCaseSenateGaugeVersion本表中与当前对象有关的记录
strSQL = strSQL + "Delete from PubClassCaseSenateGaugeVersion where IdPubClassCaseSenateGaugeVersion = " + "'"+ strIdPubClassCaseSenateGaugeVersion+"'";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelPubClassCaseSenateGaugeVersion(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsPubClassCaseSenateGaugeVersionDA: DelPubClassCaseSenateGaugeVersion)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPubClassCaseSenateGaugeVersionDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from PubClassCaseSenateGaugeVersion where " + strCondition ;
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
public bool DelPubClassCaseSenateGaugeVersionWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsPubClassCaseSenateGaugeVersionDA: DelPubClassCaseSenateGaugeVersionWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPubClassCaseSenateGaugeVersionDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from PubClassCaseSenateGaugeVersion where " + strCondition ;
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
 /// <param name = "objPubClassCaseSenateGaugeVersionENS">源对象</param>
 /// <param name = "objPubClassCaseSenateGaugeVersionENT">目标对象</param>
public void CopyTo(clsPubClassCaseSenateGaugeVersionEN objPubClassCaseSenateGaugeVersionENS, clsPubClassCaseSenateGaugeVersionEN objPubClassCaseSenateGaugeVersionENT)
{
objPubClassCaseSenateGaugeVersionENT.IdPubClassCaseSenateGaugeVersion = objPubClassCaseSenateGaugeVersionENS.IdPubClassCaseSenateGaugeVersion; //公开课量表版本流水号
objPubClassCaseSenateGaugeVersionENT.senateGaugeVersionID = objPubClassCaseSenateGaugeVersionENS.senateGaugeVersionID; //评价量表版本ID
objPubClassCaseSenateGaugeVersionENT.senateGaugeVersionName = objPubClassCaseSenateGaugeVersionENS.senateGaugeVersionName; //评价量表版本名称
objPubClassCaseSenateGaugeVersionENT.senateGaugeVersionTtlScore = objPubClassCaseSenateGaugeVersionENS.senateGaugeVersionTtlScore; //评价量表版本总分
objPubClassCaseSenateGaugeVersionENT.IsUse = objPubClassCaseSenateGaugeVersionENS.IsUse; //是否使用
objPubClassCaseSenateGaugeVersionENT.VersionNo = objPubClassCaseSenateGaugeVersionENS.VersionNo; //版本号
objPubClassCaseSenateGaugeVersionENT.senateGaugeVersionMemo = objPubClassCaseSenateGaugeVersionENS.senateGaugeVersionMemo; //评价量表版本说明
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsPubClassCaseSenateGaugeVersionEN objPubClassCaseSenateGaugeVersionEN)
{
//检查字段不能为空(NULL)
//检查字段长度
clsCheckSql.CheckFieldLen(objPubClassCaseSenateGaugeVersionEN.IdPubClassCaseSenateGaugeVersion, 4, conPubClassCaseSenateGaugeVersion.IdPubClassCaseSenateGaugeVersion);
clsCheckSql.CheckFieldLen(objPubClassCaseSenateGaugeVersionEN.senateGaugeVersionID, 4, conPubClassCaseSenateGaugeVersion.senateGaugeVersionID);
clsCheckSql.CheckFieldLen(objPubClassCaseSenateGaugeVersionEN.senateGaugeVersionName, 200, conPubClassCaseSenateGaugeVersion.senateGaugeVersionName);
clsCheckSql.CheckFieldLen(objPubClassCaseSenateGaugeVersionEN.senateGaugeVersionMemo, 1000, conPubClassCaseSenateGaugeVersion.senateGaugeVersionMemo);
//检查字段外键固定长度
 objPubClassCaseSenateGaugeVersionEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsPubClassCaseSenateGaugeVersionEN objPubClassCaseSenateGaugeVersionEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objPubClassCaseSenateGaugeVersionEN.senateGaugeVersionID, 4, conPubClassCaseSenateGaugeVersion.senateGaugeVersionID);
clsCheckSql.CheckFieldLen(objPubClassCaseSenateGaugeVersionEN.senateGaugeVersionName, 200, conPubClassCaseSenateGaugeVersion.senateGaugeVersionName);
clsCheckSql.CheckFieldLen(objPubClassCaseSenateGaugeVersionEN.senateGaugeVersionMemo, 1000, conPubClassCaseSenateGaugeVersion.senateGaugeVersionMemo);
//检查外键字段长度
 objPubClassCaseSenateGaugeVersionEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsPubClassCaseSenateGaugeVersionEN objPubClassCaseSenateGaugeVersionEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objPubClassCaseSenateGaugeVersionEN.IdPubClassCaseSenateGaugeVersion, 4, conPubClassCaseSenateGaugeVersion.IdPubClassCaseSenateGaugeVersion);
clsCheckSql.CheckFieldLen(objPubClassCaseSenateGaugeVersionEN.senateGaugeVersionID, 4, conPubClassCaseSenateGaugeVersion.senateGaugeVersionID);
clsCheckSql.CheckFieldLen(objPubClassCaseSenateGaugeVersionEN.senateGaugeVersionName, 200, conPubClassCaseSenateGaugeVersion.senateGaugeVersionName);
clsCheckSql.CheckFieldLen(objPubClassCaseSenateGaugeVersionEN.senateGaugeVersionMemo, 1000, conPubClassCaseSenateGaugeVersion.senateGaugeVersionMemo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objPubClassCaseSenateGaugeVersionEN.IdPubClassCaseSenateGaugeVersion, conPubClassCaseSenateGaugeVersion.IdPubClassCaseSenateGaugeVersion);
clsCheckSql.CheckSqlInjection4Field(objPubClassCaseSenateGaugeVersionEN.senateGaugeVersionID, conPubClassCaseSenateGaugeVersion.senateGaugeVersionID);
clsCheckSql.CheckSqlInjection4Field(objPubClassCaseSenateGaugeVersionEN.senateGaugeVersionName, conPubClassCaseSenateGaugeVersion.senateGaugeVersionName);
clsCheckSql.CheckSqlInjection4Field(objPubClassCaseSenateGaugeVersionEN.senateGaugeVersionMemo, conPubClassCaseSenateGaugeVersion.senateGaugeVersionMemo);
//检查外键字段长度
 objPubClassCaseSenateGaugeVersionEN._IsCheckProperty = true;
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
string strSQL = "select IdPubClassCaseSenateGaugeVersion, senateGaugeVersionName from PubClassCaseSenateGaugeVersion ";
 clsSpecSQLforSql mySql = clsPubClassCaseSenateGaugeVersionDA.GetSpecSQLObj();
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
 objSQL = clsPubClassCaseSenateGaugeVersionDA.GetSpecSQLObj();
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
 objSQL = clsPubClassCaseSenateGaugeVersionDA.GetSpecSQLObj();
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
 objSQL = clsPubClassCaseSenateGaugeVersionDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsPubClassCaseSenateGaugeVersionEN._CurrTabName);
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
 objSQL = clsPubClassCaseSenateGaugeVersionDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsPubClassCaseSenateGaugeVersionEN._CurrTabName, strCondition);
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
 objSQL = clsPubClassCaseSenateGaugeVersionDA.GetSpecSQLObj();
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
 objSQL = clsPubClassCaseSenateGaugeVersionDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}