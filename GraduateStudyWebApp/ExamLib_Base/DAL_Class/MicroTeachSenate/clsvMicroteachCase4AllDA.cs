
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvMicroteachCase4AllDA
 表名:vMicroteachCase4All(01120327)
 * 版本:2024.02.19.1(服务器:WIN-SRV103-116)
 日期:2024/02/27 16:25:52
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(变量首字母不限定)-WebApi函数集
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
 /// v微格教学案例_All(vMicroteachCase4All)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvMicroteachCase4AllDA : clsCommBase4DA
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
 return clsvMicroteachCase4AllEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvMicroteachCase4AllEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvMicroteachCase4AllEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvMicroteachCase4AllEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvMicroteachCase4AllEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strIdMicroteachCase">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strIdMicroteachCase)
{
strIdMicroteachCase = strIdMicroteachCase.Replace("'", "''");
if (strIdMicroteachCase.Length > 8)
{
throw new Exception("(errid:Data000001)在表:vMicroteachCase4All中,检查关键字,长度不正确!(clsvMicroteachCase4AllDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strIdMicroteachCase)  ==  true)
{
throw new Exception("(errid:Data000002)在表:vMicroteachCase4All中,关键字不能为空 或 null!(clsvMicroteachCase4AllDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strIdMicroteachCase);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsvMicroteachCase4AllDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvMicroteachCase4AllDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMicroteachCase4AllDA.GetSpecSQLObj();
strSQL = "Select * from vMicroteachCase4All where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vMicroteachCase4All(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvMicroteachCase4AllDA: GetDataTable_vMicroteachCase4All)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMicroteachCase4AllDA.GetSpecSQLObj();
strSQL = "Select * from vMicroteachCase4All where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvMicroteachCase4AllDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMicroteachCase4AllDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvMicroteachCase4AllDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMicroteachCase4AllDA.GetSpecSQLObj();
strSQL = "Select * from vMicroteachCase4All where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvMicroteachCase4AllDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMicroteachCase4AllDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvMicroteachCase4AllDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMicroteachCase4AllDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vMicroteachCase4All where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vMicroteachCase4All where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvMicroteachCase4AllDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMicroteachCase4AllDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vMicroteachCase4All where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvMicroteachCase4AllDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMicroteachCase4AllDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vMicroteachCase4All.* from vMicroteachCase4All Left Join {1} on {2} where {3} and vMicroteachCase4All.IdMicroteachCase not in (Select top {5} vMicroteachCase4All.IdMicroteachCase from vMicroteachCase4All Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vMicroteachCase4All where {1} and IdMicroteachCase not in (Select top {2} IdMicroteachCase from vMicroteachCase4All where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vMicroteachCase4All where {1} and IdMicroteachCase not in (Select top {3} IdMicroteachCase from vMicroteachCase4All where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvMicroteachCase4AllDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMicroteachCase4AllDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vMicroteachCase4All.* from vMicroteachCase4All Left Join {1} on {2} where {3} and vMicroteachCase4All.IdMicroteachCase not in (Select top {5} vMicroteachCase4All.IdMicroteachCase from vMicroteachCase4All Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vMicroteachCase4All where {1} and IdMicroteachCase not in (Select top {2} IdMicroteachCase from vMicroteachCase4All where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vMicroteachCase4All where {1} and IdMicroteachCase not in (Select top {3} IdMicroteachCase from vMicroteachCase4All where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvMicroteachCase4AllEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvMicroteachCase4AllDA:GetObjLst)", objException.Message));
}
List<clsvMicroteachCase4AllEN> arrObjLst = new List<clsvMicroteachCase4AllEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMicroteachCase4AllDA.GetSpecSQLObj();
strSQL = "Select * from vMicroteachCase4All where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvMicroteachCase4AllEN objvMicroteachCase4AllEN = new clsvMicroteachCase4AllEN();
try
{
objvMicroteachCase4AllEN.IdMicroteachCase = objRow[convMicroteachCase4All.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvMicroteachCase4AllEN.MicroteachCaseTypeName = objRow[convMicroteachCase4All.MicroteachCaseTypeName] == DBNull.Value ? null : objRow[convMicroteachCase4All.MicroteachCaseTypeName].ToString().Trim(); //微格案例类型名称
objvMicroteachCase4AllEN.MicroteachCaseID = objRow[convMicroteachCase4All.MicroteachCaseID].ToString().Trim(); //微格教学案例ID
objvMicroteachCase4AllEN.MicroteachCaseName = objRow[convMicroteachCase4All.MicroteachCaseName].ToString().Trim(); //微格教学案例名称
objvMicroteachCase4AllEN.MicroteachCaseTheme = objRow[convMicroteachCase4All.MicroteachCaseTheme] == DBNull.Value ? null : objRow[convMicroteachCase4All.MicroteachCaseTheme].ToString().Trim(); //微格教学案例主题词
objvMicroteachCase4AllEN.MicroteachCaseDate = objRow[convMicroteachCase4All.MicroteachCaseDate] == DBNull.Value ? null : objRow[convMicroteachCase4All.MicroteachCaseDate].ToString().Trim(); //微格教学日期
objvMicroteachCase4AllEN.MicroteachCaseTime = objRow[convMicroteachCase4All.MicroteachCaseTime] == DBNull.Value ? null : objRow[convMicroteachCase4All.MicroteachCaseTime].ToString().Trim(); //微格教学时间
objvMicroteachCase4AllEN.MicroteachCaseDateIn = objRow[convMicroteachCase4All.MicroteachCaseDateIn] == DBNull.Value ? null : objRow[convMicroteachCase4All.MicroteachCaseDateIn].ToString().Trim(); //案例入库日期
objvMicroteachCase4AllEN.IdStudyLevel = objRow[convMicroteachCase4All.IdStudyLevel] == DBNull.Value ? null : objRow[convMicroteachCase4All.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvMicroteachCase4AllEN.StudyLevelName = objRow[convMicroteachCase4All.StudyLevelName] == DBNull.Value ? null : objRow[convMicroteachCase4All.StudyLevelName].ToString().Trim(); //学段名称
objvMicroteachCase4AllEN.IdTeachingPlan = objRow[convMicroteachCase4All.IdTeachingPlan] == DBNull.Value ? null : objRow[convMicroteachCase4All.IdTeachingPlan].ToString().Trim(); //教案流水号
objvMicroteachCase4AllEN.MicroTeachCaseTimeIn = objRow[convMicroteachCase4All.MicroTeachCaseTimeIn] == DBNull.Value ? null : objRow[convMicroteachCase4All.MicroTeachCaseTimeIn].ToString().Trim(); //案例入库时间
objvMicroteachCase4AllEN.IdMicroteachCaseType = objRow[convMicroteachCase4All.IdMicroteachCaseType].ToString().Trim(); //微格案例类型流水号
objvMicroteachCase4AllEN.IdCaseType = objRow[convMicroteachCase4All.IdCaseType].ToString().Trim(); //案例类型流水号
objvMicroteachCase4AllEN.IdDiscipline = objRow[convMicroteachCase4All.IdDiscipline].ToString().Trim(); //学科流水号
objvMicroteachCase4AllEN.DisciplineID = objRow[convMicroteachCase4All.DisciplineID] == DBNull.Value ? null : objRow[convMicroteachCase4All.DisciplineID].ToString().Trim(); //学科ID
objvMicroteachCase4AllEN.DisciplineName = objRow[convMicroteachCase4All.DisciplineName] == DBNull.Value ? null : objRow[convMicroteachCase4All.DisciplineName].ToString().Trim(); //学科名称
objvMicroteachCase4AllEN.IdSenateGaugeVersion = objRow[convMicroteachCase4All.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[convMicroteachCase4All.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvMicroteachCase4AllEN.senateGaugeVersionID = objRow[convMicroteachCase4All.senateGaugeVersionID] == DBNull.Value ? null : objRow[convMicroteachCase4All.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvMicroteachCase4AllEN.senateGaugeVersionName = objRow[convMicroteachCase4All.senateGaugeVersionName] == DBNull.Value ? null : objRow[convMicroteachCase4All.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvMicroteachCase4AllEN.senateGaugeVersionTtlScore = objRow[convMicroteachCase4All.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convMicroteachCase4All.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvMicroteachCase4AllEN.VersionNo = objRow[convMicroteachCase4All.VersionNo] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convMicroteachCase4All.VersionNo].ToString().Trim()); //版本号
objvMicroteachCase4AllEN.IdTeachSkill = objRow[convMicroteachCase4All.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvMicroteachCase4AllEN.TeachSkillID = objRow[convMicroteachCase4All.TeachSkillID] == DBNull.Value ? null : objRow[convMicroteachCase4All.TeachSkillID].ToString().Trim(); //教学技能ID
objvMicroteachCase4AllEN.SkillTypeName = objRow[convMicroteachCase4All.SkillTypeName] == DBNull.Value ? null : objRow[convMicroteachCase4All.SkillTypeName].ToString().Trim(); //技能类型名称
objvMicroteachCase4AllEN.TeachSkillName = objRow[convMicroteachCase4All.TeachSkillName] == DBNull.Value ? null : objRow[convMicroteachCase4All.TeachSkillName].ToString().Trim(); //教学技能名称
objvMicroteachCase4AllEN.TeachSkillTheory = objRow[convMicroteachCase4All.TeachSkillTheory] == DBNull.Value ? null : objRow[convMicroteachCase4All.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvMicroteachCase4AllEN.TeachSkillOperMethod = objRow[convMicroteachCase4All.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convMicroteachCase4All.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvMicroteachCase4AllEN.IdSkillType = objRow[convMicroteachCase4All.IdSkillType] == DBNull.Value ? null : objRow[convMicroteachCase4All.IdSkillType].ToString().Trim(); //技能类型流水号
objvMicroteachCase4AllEN.SkillTypeID = objRow[convMicroteachCase4All.SkillTypeID] == DBNull.Value ? null : objRow[convMicroteachCase4All.SkillTypeID].ToString().Trim(); //技能类型ID
objvMicroteachCase4AllEN.CaseLevelId = objRow[convMicroteachCase4All.CaseLevelId] == DBNull.Value ? null : objRow[convMicroteachCase4All.CaseLevelId].ToString().Trim(); //课例等级Id
objvMicroteachCase4AllEN.CaseLevelName = objRow[convMicroteachCase4All.CaseLevelName] == DBNull.Value ? null : objRow[convMicroteachCase4All.CaseLevelName].ToString().Trim(); //案例等级名称
objvMicroteachCase4AllEN.DocFile = objRow[convMicroteachCase4All.DocFile] == DBNull.Value ? null : objRow[convMicroteachCase4All.DocFile].ToString().Trim(); //生成的Word文件名
objvMicroteachCase4AllEN.IsNeedGeneWord = TransNullToBool(objRow[convMicroteachCase4All.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objvMicroteachCase4AllEN.WordCreateDate = objRow[convMicroteachCase4All.WordCreateDate] == DBNull.Value ? null : objRow[convMicroteachCase4All.WordCreateDate].ToString().Trim(); //Word生成日期
objvMicroteachCase4AllEN.IsVisible = TransNullToBool(objRow[convMicroteachCase4All.IsVisible].ToString().Trim()); //是否显示
objvMicroteachCase4AllEN.microteachCaseText = objRow[convMicroteachCase4All.microteachCaseText] == DBNull.Value ? null : objRow[convMicroteachCase4All.microteachCaseText].ToString().Trim(); //案例文本内容
objvMicroteachCase4AllEN.OwnerId = objRow[convMicroteachCase4All.OwnerId].ToString().Trim(); //拥有者Id
objvMicroteachCase4AllEN.OwnerName = objRow[convMicroteachCase4All.OwnerName] == DBNull.Value ? null : objRow[convMicroteachCase4All.OwnerName].ToString().Trim(); //拥有者姓名
objvMicroteachCase4AllEN.CollegeId = objRow[convMicroteachCase4All.CollegeId] == DBNull.Value ? null : objRow[convMicroteachCase4All.CollegeId].ToString().Trim(); //学院ID
objvMicroteachCase4AllEN.CollegeName = objRow[convMicroteachCase4All.CollegeName] == DBNull.Value ? null : objRow[convMicroteachCase4All.CollegeName].ToString().Trim(); //学院名称
objvMicroteachCase4AllEN.OwnerNameWithId = objRow[convMicroteachCase4All.OwnerNameWithId] == DBNull.Value ? null : objRow[convMicroteachCase4All.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvMicroteachCase4AllEN.IdXzCollege = objRow[convMicroteachCase4All.IdXzCollege] == DBNull.Value ? null : objRow[convMicroteachCase4All.IdXzCollege].ToString().Trim(); //学院流水号
objvMicroteachCase4AllEN.IsDualVideo = TransNullToBool(objRow[convMicroteachCase4All.IsDualVideo].ToString().Trim()); //是否双视频
objvMicroteachCase4AllEN.UserKindId = objRow[convMicroteachCase4All.UserKindId].ToString().Trim(); //用户类别Id
objvMicroteachCase4AllEN.UserKindName = objRow[convMicroteachCase4All.UserKindName] == DBNull.Value ? null : objRow[convMicroteachCase4All.UserKindName].ToString().Trim(); //用户类别名
objvMicroteachCase4AllEN.UserTypeId = objRow[convMicroteachCase4All.UserTypeId] == DBNull.Value ? null : objRow[convMicroteachCase4All.UserTypeId].ToString().Trim(); //用户类型Id
objvMicroteachCase4AllEN.UserTypeName = objRow[convMicroteachCase4All.UserTypeName] == DBNull.Value ? null : objRow[convMicroteachCase4All.UserTypeName].ToString().Trim(); //用户类型名称
objvMicroteachCase4AllEN.RecommendedDegreeId = objRow[convMicroteachCase4All.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvMicroteachCase4AllEN.RecommendedDegreeName = objRow[convMicroteachCase4All.RecommendedDegreeName] == DBNull.Value ? null : objRow[convMicroteachCase4All.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvMicroteachCase4AllEN.Memo = objRow[convMicroteachCase4All.Memo] == DBNull.Value ? null : objRow[convMicroteachCase4All.Memo].ToString().Trim(); //备注
objvMicroteachCase4AllEN.BrowseCount4Case = objRow[convMicroteachCase4All.BrowseCount4Case] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convMicroteachCase4All.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvMicroteachCase4AllEN.IsHaveVideo = objRow[convMicroteachCase4All.IsHaveVideo].ToString().Trim(); //IsHaveVideo
objvMicroteachCase4AllEN.CollegeNameA = objRow[convMicroteachCase4All.CollegeNameA] == DBNull.Value ? null : objRow[convMicroteachCase4All.CollegeNameA].ToString().Trim(); //学院名称简写
objvMicroteachCase4AllEN.ftpFileType = objRow[convMicroteachCase4All.ftpFileType] == DBNull.Value ? null : objRow[convMicroteachCase4All.ftpFileType].ToString().Trim(); //ftp文件类型
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvMicroteachCase4AllDA: GetObjLst)", objException.Message));
}
objvMicroteachCase4AllEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvMicroteachCase4AllEN);
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
public List<clsvMicroteachCase4AllEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvMicroteachCase4AllDA:GetObjLstByTabName)", objException.Message));
}
List<clsvMicroteachCase4AllEN> arrObjLst = new List<clsvMicroteachCase4AllEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMicroteachCase4AllDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvMicroteachCase4AllEN objvMicroteachCase4AllEN = new clsvMicroteachCase4AllEN();
try
{
objvMicroteachCase4AllEN.IdMicroteachCase = objRow[convMicroteachCase4All.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvMicroteachCase4AllEN.MicroteachCaseTypeName = objRow[convMicroteachCase4All.MicroteachCaseTypeName] == DBNull.Value ? null : objRow[convMicroteachCase4All.MicroteachCaseTypeName].ToString().Trim(); //微格案例类型名称
objvMicroteachCase4AllEN.MicroteachCaseID = objRow[convMicroteachCase4All.MicroteachCaseID].ToString().Trim(); //微格教学案例ID
objvMicroteachCase4AllEN.MicroteachCaseName = objRow[convMicroteachCase4All.MicroteachCaseName].ToString().Trim(); //微格教学案例名称
objvMicroteachCase4AllEN.MicroteachCaseTheme = objRow[convMicroteachCase4All.MicroteachCaseTheme] == DBNull.Value ? null : objRow[convMicroteachCase4All.MicroteachCaseTheme].ToString().Trim(); //微格教学案例主题词
objvMicroteachCase4AllEN.MicroteachCaseDate = objRow[convMicroteachCase4All.MicroteachCaseDate] == DBNull.Value ? null : objRow[convMicroteachCase4All.MicroteachCaseDate].ToString().Trim(); //微格教学日期
objvMicroteachCase4AllEN.MicroteachCaseTime = objRow[convMicroteachCase4All.MicroteachCaseTime] == DBNull.Value ? null : objRow[convMicroteachCase4All.MicroteachCaseTime].ToString().Trim(); //微格教学时间
objvMicroteachCase4AllEN.MicroteachCaseDateIn = objRow[convMicroteachCase4All.MicroteachCaseDateIn] == DBNull.Value ? null : objRow[convMicroteachCase4All.MicroteachCaseDateIn].ToString().Trim(); //案例入库日期
objvMicroteachCase4AllEN.IdStudyLevel = objRow[convMicroteachCase4All.IdStudyLevel] == DBNull.Value ? null : objRow[convMicroteachCase4All.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvMicroteachCase4AllEN.StudyLevelName = objRow[convMicroteachCase4All.StudyLevelName] == DBNull.Value ? null : objRow[convMicroteachCase4All.StudyLevelName].ToString().Trim(); //学段名称
objvMicroteachCase4AllEN.IdTeachingPlan = objRow[convMicroteachCase4All.IdTeachingPlan] == DBNull.Value ? null : objRow[convMicroteachCase4All.IdTeachingPlan].ToString().Trim(); //教案流水号
objvMicroteachCase4AllEN.MicroTeachCaseTimeIn = objRow[convMicroteachCase4All.MicroTeachCaseTimeIn] == DBNull.Value ? null : objRow[convMicroteachCase4All.MicroTeachCaseTimeIn].ToString().Trim(); //案例入库时间
objvMicroteachCase4AllEN.IdMicroteachCaseType = objRow[convMicroteachCase4All.IdMicroteachCaseType].ToString().Trim(); //微格案例类型流水号
objvMicroteachCase4AllEN.IdCaseType = objRow[convMicroteachCase4All.IdCaseType].ToString().Trim(); //案例类型流水号
objvMicroteachCase4AllEN.IdDiscipline = objRow[convMicroteachCase4All.IdDiscipline].ToString().Trim(); //学科流水号
objvMicroteachCase4AllEN.DisciplineID = objRow[convMicroteachCase4All.DisciplineID] == DBNull.Value ? null : objRow[convMicroteachCase4All.DisciplineID].ToString().Trim(); //学科ID
objvMicroteachCase4AllEN.DisciplineName = objRow[convMicroteachCase4All.DisciplineName] == DBNull.Value ? null : objRow[convMicroteachCase4All.DisciplineName].ToString().Trim(); //学科名称
objvMicroteachCase4AllEN.IdSenateGaugeVersion = objRow[convMicroteachCase4All.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[convMicroteachCase4All.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvMicroteachCase4AllEN.senateGaugeVersionID = objRow[convMicroteachCase4All.senateGaugeVersionID] == DBNull.Value ? null : objRow[convMicroteachCase4All.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvMicroteachCase4AllEN.senateGaugeVersionName = objRow[convMicroteachCase4All.senateGaugeVersionName] == DBNull.Value ? null : objRow[convMicroteachCase4All.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvMicroteachCase4AllEN.senateGaugeVersionTtlScore = objRow[convMicroteachCase4All.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convMicroteachCase4All.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvMicroteachCase4AllEN.VersionNo = objRow[convMicroteachCase4All.VersionNo] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convMicroteachCase4All.VersionNo].ToString().Trim()); //版本号
objvMicroteachCase4AllEN.IdTeachSkill = objRow[convMicroteachCase4All.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvMicroteachCase4AllEN.TeachSkillID = objRow[convMicroteachCase4All.TeachSkillID] == DBNull.Value ? null : objRow[convMicroteachCase4All.TeachSkillID].ToString().Trim(); //教学技能ID
objvMicroteachCase4AllEN.SkillTypeName = objRow[convMicroteachCase4All.SkillTypeName] == DBNull.Value ? null : objRow[convMicroteachCase4All.SkillTypeName].ToString().Trim(); //技能类型名称
objvMicroteachCase4AllEN.TeachSkillName = objRow[convMicroteachCase4All.TeachSkillName] == DBNull.Value ? null : objRow[convMicroteachCase4All.TeachSkillName].ToString().Trim(); //教学技能名称
objvMicroteachCase4AllEN.TeachSkillTheory = objRow[convMicroteachCase4All.TeachSkillTheory] == DBNull.Value ? null : objRow[convMicroteachCase4All.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvMicroteachCase4AllEN.TeachSkillOperMethod = objRow[convMicroteachCase4All.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convMicroteachCase4All.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvMicroteachCase4AllEN.IdSkillType = objRow[convMicroteachCase4All.IdSkillType] == DBNull.Value ? null : objRow[convMicroteachCase4All.IdSkillType].ToString().Trim(); //技能类型流水号
objvMicroteachCase4AllEN.SkillTypeID = objRow[convMicroteachCase4All.SkillTypeID] == DBNull.Value ? null : objRow[convMicroteachCase4All.SkillTypeID].ToString().Trim(); //技能类型ID
objvMicroteachCase4AllEN.CaseLevelId = objRow[convMicroteachCase4All.CaseLevelId] == DBNull.Value ? null : objRow[convMicroteachCase4All.CaseLevelId].ToString().Trim(); //课例等级Id
objvMicroteachCase4AllEN.CaseLevelName = objRow[convMicroteachCase4All.CaseLevelName] == DBNull.Value ? null : objRow[convMicroteachCase4All.CaseLevelName].ToString().Trim(); //案例等级名称
objvMicroteachCase4AllEN.DocFile = objRow[convMicroteachCase4All.DocFile] == DBNull.Value ? null : objRow[convMicroteachCase4All.DocFile].ToString().Trim(); //生成的Word文件名
objvMicroteachCase4AllEN.IsNeedGeneWord = TransNullToBool(objRow[convMicroteachCase4All.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objvMicroteachCase4AllEN.WordCreateDate = objRow[convMicroteachCase4All.WordCreateDate] == DBNull.Value ? null : objRow[convMicroteachCase4All.WordCreateDate].ToString().Trim(); //Word生成日期
objvMicroteachCase4AllEN.IsVisible = TransNullToBool(objRow[convMicroteachCase4All.IsVisible].ToString().Trim()); //是否显示
objvMicroteachCase4AllEN.microteachCaseText = objRow[convMicroteachCase4All.microteachCaseText] == DBNull.Value ? null : objRow[convMicroteachCase4All.microteachCaseText].ToString().Trim(); //案例文本内容
objvMicroteachCase4AllEN.OwnerId = objRow[convMicroteachCase4All.OwnerId].ToString().Trim(); //拥有者Id
objvMicroteachCase4AllEN.OwnerName = objRow[convMicroteachCase4All.OwnerName] == DBNull.Value ? null : objRow[convMicroteachCase4All.OwnerName].ToString().Trim(); //拥有者姓名
objvMicroteachCase4AllEN.CollegeId = objRow[convMicroteachCase4All.CollegeId] == DBNull.Value ? null : objRow[convMicroteachCase4All.CollegeId].ToString().Trim(); //学院ID
objvMicroteachCase4AllEN.CollegeName = objRow[convMicroteachCase4All.CollegeName] == DBNull.Value ? null : objRow[convMicroteachCase4All.CollegeName].ToString().Trim(); //学院名称
objvMicroteachCase4AllEN.OwnerNameWithId = objRow[convMicroteachCase4All.OwnerNameWithId] == DBNull.Value ? null : objRow[convMicroteachCase4All.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvMicroteachCase4AllEN.IdXzCollege = objRow[convMicroteachCase4All.IdXzCollege] == DBNull.Value ? null : objRow[convMicroteachCase4All.IdXzCollege].ToString().Trim(); //学院流水号
objvMicroteachCase4AllEN.IsDualVideo = TransNullToBool(objRow[convMicroteachCase4All.IsDualVideo].ToString().Trim()); //是否双视频
objvMicroteachCase4AllEN.UserKindId = objRow[convMicroteachCase4All.UserKindId].ToString().Trim(); //用户类别Id
objvMicroteachCase4AllEN.UserKindName = objRow[convMicroteachCase4All.UserKindName] == DBNull.Value ? null : objRow[convMicroteachCase4All.UserKindName].ToString().Trim(); //用户类别名
objvMicroteachCase4AllEN.UserTypeId = objRow[convMicroteachCase4All.UserTypeId] == DBNull.Value ? null : objRow[convMicroteachCase4All.UserTypeId].ToString().Trim(); //用户类型Id
objvMicroteachCase4AllEN.UserTypeName = objRow[convMicroteachCase4All.UserTypeName] == DBNull.Value ? null : objRow[convMicroteachCase4All.UserTypeName].ToString().Trim(); //用户类型名称
objvMicroteachCase4AllEN.RecommendedDegreeId = objRow[convMicroteachCase4All.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvMicroteachCase4AllEN.RecommendedDegreeName = objRow[convMicroteachCase4All.RecommendedDegreeName] == DBNull.Value ? null : objRow[convMicroteachCase4All.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvMicroteachCase4AllEN.Memo = objRow[convMicroteachCase4All.Memo] == DBNull.Value ? null : objRow[convMicroteachCase4All.Memo].ToString().Trim(); //备注
objvMicroteachCase4AllEN.BrowseCount4Case = objRow[convMicroteachCase4All.BrowseCount4Case] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convMicroteachCase4All.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvMicroteachCase4AllEN.IsHaveVideo = objRow[convMicroteachCase4All.IsHaveVideo].ToString().Trim(); //IsHaveVideo
objvMicroteachCase4AllEN.CollegeNameA = objRow[convMicroteachCase4All.CollegeNameA] == DBNull.Value ? null : objRow[convMicroteachCase4All.CollegeNameA].ToString().Trim(); //学院名称简写
objvMicroteachCase4AllEN.ftpFileType = objRow[convMicroteachCase4All.ftpFileType] == DBNull.Value ? null : objRow[convMicroteachCase4All.ftpFileType].ToString().Trim(); //ftp文件类型
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvMicroteachCase4AllDA: GetObjLst)", objException.Message));
}
objvMicroteachCase4AllEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvMicroteachCase4AllEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvMicroteachCase4AllEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvMicroteachCase4All(ref clsvMicroteachCase4AllEN objvMicroteachCase4AllEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMicroteachCase4AllDA.GetSpecSQLObj();
strSQL = "Select * from vMicroteachCase4All where IdMicroteachCase = " + "'"+ objvMicroteachCase4AllEN.IdMicroteachCase+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvMicroteachCase4AllEN.IdMicroteachCase = objDT.Rows[0][convMicroteachCase4All.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号(字段类型:char,字段长度:8,是否可空:False)
 objvMicroteachCase4AllEN.MicroteachCaseTypeName = objDT.Rows[0][convMicroteachCase4All.MicroteachCaseTypeName].ToString().Trim(); //微格案例类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvMicroteachCase4AllEN.MicroteachCaseID = objDT.Rows[0][convMicroteachCase4All.MicroteachCaseID].ToString().Trim(); //微格教学案例ID(字段类型:char,字段长度:8,是否可空:False)
 objvMicroteachCase4AllEN.MicroteachCaseName = objDT.Rows[0][convMicroteachCase4All.MicroteachCaseName].ToString().Trim(); //微格教学案例名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvMicroteachCase4AllEN.MicroteachCaseTheme = objDT.Rows[0][convMicroteachCase4All.MicroteachCaseTheme].ToString().Trim(); //微格教学案例主题词(字段类型:varchar,字段长度:200,是否可空:True)
 objvMicroteachCase4AllEN.MicroteachCaseDate = objDT.Rows[0][convMicroteachCase4All.MicroteachCaseDate].ToString().Trim(); //微格教学日期(字段类型:char,字段长度:8,是否可空:True)
 objvMicroteachCase4AllEN.MicroteachCaseTime = objDT.Rows[0][convMicroteachCase4All.MicroteachCaseTime].ToString().Trim(); //微格教学时间(字段类型:char,字段长度:6,是否可空:True)
 objvMicroteachCase4AllEN.MicroteachCaseDateIn = objDT.Rows[0][convMicroteachCase4All.MicroteachCaseDateIn].ToString().Trim(); //案例入库日期(字段类型:char,字段长度:8,是否可空:True)
 objvMicroteachCase4AllEN.IdStudyLevel = objDT.Rows[0][convMicroteachCase4All.IdStudyLevel].ToString().Trim(); //id_StudyLevel(字段类型:char,字段长度:4,是否可空:True)
 objvMicroteachCase4AllEN.StudyLevelName = objDT.Rows[0][convMicroteachCase4All.StudyLevelName].ToString().Trim(); //学段名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvMicroteachCase4AllEN.IdTeachingPlan = objDT.Rows[0][convMicroteachCase4All.IdTeachingPlan].ToString().Trim(); //教案流水号(字段类型:char,字段长度:8,是否可空:False)
 objvMicroteachCase4AllEN.MicroTeachCaseTimeIn = objDT.Rows[0][convMicroteachCase4All.MicroTeachCaseTimeIn].ToString().Trim(); //案例入库时间(字段类型:char,字段长度:6,是否可空:True)
 objvMicroteachCase4AllEN.IdMicroteachCaseType = objDT.Rows[0][convMicroteachCase4All.IdMicroteachCaseType].ToString().Trim(); //微格案例类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvMicroteachCase4AllEN.IdCaseType = objDT.Rows[0][convMicroteachCase4All.IdCaseType].ToString().Trim(); //案例类型流水号(字段类型:char,字段长度:4,是否可空:True)
 objvMicroteachCase4AllEN.IdDiscipline = objDT.Rows[0][convMicroteachCase4All.IdDiscipline].ToString().Trim(); //学科流水号(字段类型:char,字段长度:4,是否可空:False)
 objvMicroteachCase4AllEN.DisciplineID = objDT.Rows[0][convMicroteachCase4All.DisciplineID].ToString().Trim(); //学科ID(字段类型:char,字段长度:4,是否可空:False)
 objvMicroteachCase4AllEN.DisciplineName = objDT.Rows[0][convMicroteachCase4All.DisciplineName].ToString().Trim(); //学科名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvMicroteachCase4AllEN.IdSenateGaugeVersion = objDT.Rows[0][convMicroteachCase4All.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号(字段类型:char,字段长度:4,是否可空:False)
 objvMicroteachCase4AllEN.senateGaugeVersionID = objDT.Rows[0][convMicroteachCase4All.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID(字段类型:char,字段长度:4,是否可空:False)
 objvMicroteachCase4AllEN.senateGaugeVersionName = objDT.Rows[0][convMicroteachCase4All.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称(字段类型:varchar,字段长度:200,是否可空:True)
 objvMicroteachCase4AllEN.senateGaugeVersionTtlScore = TransNullToFloat(objDT.Rows[0][convMicroteachCase4All.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分(字段类型:float,字段长度:8,是否可空:False)
 objvMicroteachCase4AllEN.VersionNo = TransNullToInt(objDT.Rows[0][convMicroteachCase4All.VersionNo].ToString().Trim()); //版本号(字段类型:int,字段长度:4,是否可空:True)
 objvMicroteachCase4AllEN.IdTeachSkill = objDT.Rows[0][convMicroteachCase4All.IdTeachSkill].ToString().Trim(); //教学技能流水号(字段类型:char,字段长度:8,是否可空:False)
 objvMicroteachCase4AllEN.TeachSkillID = objDT.Rows[0][convMicroteachCase4All.TeachSkillID].ToString().Trim(); //教学技能ID(字段类型:char,字段长度:8,是否可空:False)
 objvMicroteachCase4AllEN.SkillTypeName = objDT.Rows[0][convMicroteachCase4All.SkillTypeName].ToString().Trim(); //技能类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvMicroteachCase4AllEN.TeachSkillName = objDT.Rows[0][convMicroteachCase4All.TeachSkillName].ToString().Trim(); //教学技能名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvMicroteachCase4AllEN.TeachSkillTheory = objDT.Rows[0][convMicroteachCase4All.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述(字段类型:varchar,字段长度:8000,是否可空:True)
 objvMicroteachCase4AllEN.TeachSkillOperMethod = objDT.Rows[0][convMicroteachCase4All.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法(字段类型:varchar,字段长度:2000,是否可空:True)
 objvMicroteachCase4AllEN.IdSkillType = objDT.Rows[0][convMicroteachCase4All.IdSkillType].ToString().Trim(); //技能类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvMicroteachCase4AllEN.SkillTypeID = objDT.Rows[0][convMicroteachCase4All.SkillTypeID].ToString().Trim(); //技能类型ID(字段类型:char,字段长度:4,是否可空:False)
 objvMicroteachCase4AllEN.CaseLevelId = objDT.Rows[0][convMicroteachCase4All.CaseLevelId].ToString().Trim(); //课例等级Id(字段类型:char,字段长度:2,是否可空:True)
 objvMicroteachCase4AllEN.CaseLevelName = objDT.Rows[0][convMicroteachCase4All.CaseLevelName].ToString().Trim(); //案例等级名称(字段类型:varchar,字段长度:30,是否可空:True)
 objvMicroteachCase4AllEN.DocFile = objDT.Rows[0][convMicroteachCase4All.DocFile].ToString().Trim(); //生成的Word文件名(字段类型:varchar,字段长度:200,是否可空:True)
 objvMicroteachCase4AllEN.IsNeedGeneWord = TransNullToBool(objDT.Rows[0][convMicroteachCase4All.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word(字段类型:bit,字段长度:1,是否可空:True)
 objvMicroteachCase4AllEN.WordCreateDate = objDT.Rows[0][convMicroteachCase4All.WordCreateDate].ToString().Trim(); //Word生成日期(字段类型:varchar,字段长度:14,是否可空:True)
 objvMicroteachCase4AllEN.IsVisible = TransNullToBool(objDT.Rows[0][convMicroteachCase4All.IsVisible].ToString().Trim()); //是否显示(字段类型:bit,字段长度:1,是否可空:True)
 objvMicroteachCase4AllEN.microteachCaseText = objDT.Rows[0][convMicroteachCase4All.microteachCaseText].ToString().Trim(); //案例文本内容(字段类型:varchar,字段长度:8000,是否可空:True)
 objvMicroteachCase4AllEN.OwnerId = objDT.Rows[0][convMicroteachCase4All.OwnerId].ToString().Trim(); //拥有者Id(字段类型:varchar,字段长度:20,是否可空:False)
 objvMicroteachCase4AllEN.OwnerName = objDT.Rows[0][convMicroteachCase4All.OwnerName].ToString().Trim(); //拥有者姓名(字段类型:varchar,字段长度:30,是否可空:True)
 objvMicroteachCase4AllEN.CollegeId = objDT.Rows[0][convMicroteachCase4All.CollegeId].ToString().Trim(); //学院ID(字段类型:varchar,字段长度:4,是否可空:False)
 objvMicroteachCase4AllEN.CollegeName = objDT.Rows[0][convMicroteachCase4All.CollegeName].ToString().Trim(); //学院名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvMicroteachCase4AllEN.OwnerNameWithId = objDT.Rows[0][convMicroteachCase4All.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id(字段类型:varchar,字段长度:51,是否可空:True)
 objvMicroteachCase4AllEN.IdXzCollege = objDT.Rows[0][convMicroteachCase4All.IdXzCollege].ToString().Trim(); //学院流水号(字段类型:char,字段长度:4,是否可空:True)
 objvMicroteachCase4AllEN.IsDualVideo = TransNullToBool(objDT.Rows[0][convMicroteachCase4All.IsDualVideo].ToString().Trim()); //是否双视频(字段类型:bit,字段长度:1,是否可空:False)
 objvMicroteachCase4AllEN.UserKindId = objDT.Rows[0][convMicroteachCase4All.UserKindId].ToString().Trim(); //用户类别Id(字段类型:char,字段长度:2,是否可空:False)
 objvMicroteachCase4AllEN.UserKindName = objDT.Rows[0][convMicroteachCase4All.UserKindName].ToString().Trim(); //用户类别名(字段类型:varchar,字段长度:30,是否可空:False)
 objvMicroteachCase4AllEN.UserTypeId = objDT.Rows[0][convMicroteachCase4All.UserTypeId].ToString().Trim(); //用户类型Id(字段类型:char,字段长度:2,是否可空:True)
 objvMicroteachCase4AllEN.UserTypeName = objDT.Rows[0][convMicroteachCase4All.UserTypeName].ToString().Trim(); //用户类型名称(字段类型:varchar,字段长度:20,是否可空:True)
 objvMicroteachCase4AllEN.RecommendedDegreeId = objDT.Rows[0][convMicroteachCase4All.RecommendedDegreeId].ToString().Trim(); //推荐度Id(字段类型:char,字段长度:2,是否可空:False)
 objvMicroteachCase4AllEN.RecommendedDegreeName = objDT.Rows[0][convMicroteachCase4All.RecommendedDegreeName].ToString().Trim(); //推荐度名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvMicroteachCase4AllEN.Memo = objDT.Rows[0][convMicroteachCase4All.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvMicroteachCase4AllEN.BrowseCount4Case = TransNullToInt(objDT.Rows[0][convMicroteachCase4All.BrowseCount4Case].ToString().Trim()); //课例浏览次数(字段类型:int,字段长度:4,是否可空:True)
 objvMicroteachCase4AllEN.IsHaveVideo = objDT.Rows[0][convMicroteachCase4All.IsHaveVideo].ToString().Trim(); //IsHaveVideo(字段类型:varchar,字段长度:6,是否可空:True)
 objvMicroteachCase4AllEN.CollegeNameA = objDT.Rows[0][convMicroteachCase4All.CollegeNameA].ToString().Trim(); //学院名称简写(字段类型:varchar,字段长度:12,是否可空:True)
 objvMicroteachCase4AllEN.ftpFileType = objDT.Rows[0][convMicroteachCase4All.ftpFileType].ToString().Trim(); //ftp文件类型(字段类型:varchar,字段长度:30,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvMicroteachCase4AllDA: GetvMicroteachCase4All)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strIdMicroteachCase">表关键字</param>
 /// <returns>表对象</returns>
public clsvMicroteachCase4AllEN GetObjByIdMicroteachCase(string strIdMicroteachCase)
{
CheckPrimaryKey(strIdMicroteachCase);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMicroteachCase4AllDA.GetSpecSQLObj();
strSQL = "Select * from vMicroteachCase4All where IdMicroteachCase = " + "'"+ strIdMicroteachCase+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvMicroteachCase4AllEN objvMicroteachCase4AllEN = new clsvMicroteachCase4AllEN();
try
{
 objvMicroteachCase4AllEN.IdMicroteachCase = objRow[convMicroteachCase4All.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号(字段类型:char,字段长度:8,是否可空:False)
 objvMicroteachCase4AllEN.MicroteachCaseTypeName = objRow[convMicroteachCase4All.MicroteachCaseTypeName] == DBNull.Value ? null : objRow[convMicroteachCase4All.MicroteachCaseTypeName].ToString().Trim(); //微格案例类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvMicroteachCase4AllEN.MicroteachCaseID = objRow[convMicroteachCase4All.MicroteachCaseID].ToString().Trim(); //微格教学案例ID(字段类型:char,字段长度:8,是否可空:False)
 objvMicroteachCase4AllEN.MicroteachCaseName = objRow[convMicroteachCase4All.MicroteachCaseName].ToString().Trim(); //微格教学案例名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvMicroteachCase4AllEN.MicroteachCaseTheme = objRow[convMicroteachCase4All.MicroteachCaseTheme] == DBNull.Value ? null : objRow[convMicroteachCase4All.MicroteachCaseTheme].ToString().Trim(); //微格教学案例主题词(字段类型:varchar,字段长度:200,是否可空:True)
 objvMicroteachCase4AllEN.MicroteachCaseDate = objRow[convMicroteachCase4All.MicroteachCaseDate] == DBNull.Value ? null : objRow[convMicroteachCase4All.MicroteachCaseDate].ToString().Trim(); //微格教学日期(字段类型:char,字段长度:8,是否可空:True)
 objvMicroteachCase4AllEN.MicroteachCaseTime = objRow[convMicroteachCase4All.MicroteachCaseTime] == DBNull.Value ? null : objRow[convMicroteachCase4All.MicroteachCaseTime].ToString().Trim(); //微格教学时间(字段类型:char,字段长度:6,是否可空:True)
 objvMicroteachCase4AllEN.MicroteachCaseDateIn = objRow[convMicroteachCase4All.MicroteachCaseDateIn] == DBNull.Value ? null : objRow[convMicroteachCase4All.MicroteachCaseDateIn].ToString().Trim(); //案例入库日期(字段类型:char,字段长度:8,是否可空:True)
 objvMicroteachCase4AllEN.IdStudyLevel = objRow[convMicroteachCase4All.IdStudyLevel] == DBNull.Value ? null : objRow[convMicroteachCase4All.IdStudyLevel].ToString().Trim(); //id_StudyLevel(字段类型:char,字段长度:4,是否可空:True)
 objvMicroteachCase4AllEN.StudyLevelName = objRow[convMicroteachCase4All.StudyLevelName] == DBNull.Value ? null : objRow[convMicroteachCase4All.StudyLevelName].ToString().Trim(); //学段名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvMicroteachCase4AllEN.IdTeachingPlan = objRow[convMicroteachCase4All.IdTeachingPlan] == DBNull.Value ? null : objRow[convMicroteachCase4All.IdTeachingPlan].ToString().Trim(); //教案流水号(字段类型:char,字段长度:8,是否可空:False)
 objvMicroteachCase4AllEN.MicroTeachCaseTimeIn = objRow[convMicroteachCase4All.MicroTeachCaseTimeIn] == DBNull.Value ? null : objRow[convMicroteachCase4All.MicroTeachCaseTimeIn].ToString().Trim(); //案例入库时间(字段类型:char,字段长度:6,是否可空:True)
 objvMicroteachCase4AllEN.IdMicroteachCaseType = objRow[convMicroteachCase4All.IdMicroteachCaseType].ToString().Trim(); //微格案例类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvMicroteachCase4AllEN.IdCaseType = objRow[convMicroteachCase4All.IdCaseType].ToString().Trim(); //案例类型流水号(字段类型:char,字段长度:4,是否可空:True)
 objvMicroteachCase4AllEN.IdDiscipline = objRow[convMicroteachCase4All.IdDiscipline].ToString().Trim(); //学科流水号(字段类型:char,字段长度:4,是否可空:False)
 objvMicroteachCase4AllEN.DisciplineID = objRow[convMicroteachCase4All.DisciplineID] == DBNull.Value ? null : objRow[convMicroteachCase4All.DisciplineID].ToString().Trim(); //学科ID(字段类型:char,字段长度:4,是否可空:False)
 objvMicroteachCase4AllEN.DisciplineName = objRow[convMicroteachCase4All.DisciplineName] == DBNull.Value ? null : objRow[convMicroteachCase4All.DisciplineName].ToString().Trim(); //学科名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvMicroteachCase4AllEN.IdSenateGaugeVersion = objRow[convMicroteachCase4All.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[convMicroteachCase4All.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号(字段类型:char,字段长度:4,是否可空:False)
 objvMicroteachCase4AllEN.senateGaugeVersionID = objRow[convMicroteachCase4All.senateGaugeVersionID] == DBNull.Value ? null : objRow[convMicroteachCase4All.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID(字段类型:char,字段长度:4,是否可空:False)
 objvMicroteachCase4AllEN.senateGaugeVersionName = objRow[convMicroteachCase4All.senateGaugeVersionName] == DBNull.Value ? null : objRow[convMicroteachCase4All.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称(字段类型:varchar,字段长度:200,是否可空:True)
 objvMicroteachCase4AllEN.senateGaugeVersionTtlScore = objRow[convMicroteachCase4All.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convMicroteachCase4All.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分(字段类型:float,字段长度:8,是否可空:False)
 objvMicroteachCase4AllEN.VersionNo = objRow[convMicroteachCase4All.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachCase4All.VersionNo].ToString().Trim()); //版本号(字段类型:int,字段长度:4,是否可空:True)
 objvMicroteachCase4AllEN.IdTeachSkill = objRow[convMicroteachCase4All.IdTeachSkill].ToString().Trim(); //教学技能流水号(字段类型:char,字段长度:8,是否可空:False)
 objvMicroteachCase4AllEN.TeachSkillID = objRow[convMicroteachCase4All.TeachSkillID] == DBNull.Value ? null : objRow[convMicroteachCase4All.TeachSkillID].ToString().Trim(); //教学技能ID(字段类型:char,字段长度:8,是否可空:False)
 objvMicroteachCase4AllEN.SkillTypeName = objRow[convMicroteachCase4All.SkillTypeName] == DBNull.Value ? null : objRow[convMicroteachCase4All.SkillTypeName].ToString().Trim(); //技能类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvMicroteachCase4AllEN.TeachSkillName = objRow[convMicroteachCase4All.TeachSkillName] == DBNull.Value ? null : objRow[convMicroteachCase4All.TeachSkillName].ToString().Trim(); //教学技能名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvMicroteachCase4AllEN.TeachSkillTheory = objRow[convMicroteachCase4All.TeachSkillTheory] == DBNull.Value ? null : objRow[convMicroteachCase4All.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述(字段类型:varchar,字段长度:8000,是否可空:True)
 objvMicroteachCase4AllEN.TeachSkillOperMethod = objRow[convMicroteachCase4All.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convMicroteachCase4All.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法(字段类型:varchar,字段长度:2000,是否可空:True)
 objvMicroteachCase4AllEN.IdSkillType = objRow[convMicroteachCase4All.IdSkillType] == DBNull.Value ? null : objRow[convMicroteachCase4All.IdSkillType].ToString().Trim(); //技能类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvMicroteachCase4AllEN.SkillTypeID = objRow[convMicroteachCase4All.SkillTypeID] == DBNull.Value ? null : objRow[convMicroteachCase4All.SkillTypeID].ToString().Trim(); //技能类型ID(字段类型:char,字段长度:4,是否可空:False)
 objvMicroteachCase4AllEN.CaseLevelId = objRow[convMicroteachCase4All.CaseLevelId] == DBNull.Value ? null : objRow[convMicroteachCase4All.CaseLevelId].ToString().Trim(); //课例等级Id(字段类型:char,字段长度:2,是否可空:True)
 objvMicroteachCase4AllEN.CaseLevelName = objRow[convMicroteachCase4All.CaseLevelName] == DBNull.Value ? null : objRow[convMicroteachCase4All.CaseLevelName].ToString().Trim(); //案例等级名称(字段类型:varchar,字段长度:30,是否可空:True)
 objvMicroteachCase4AllEN.DocFile = objRow[convMicroteachCase4All.DocFile] == DBNull.Value ? null : objRow[convMicroteachCase4All.DocFile].ToString().Trim(); //生成的Word文件名(字段类型:varchar,字段长度:200,是否可空:True)
 objvMicroteachCase4AllEN.IsNeedGeneWord = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCase4All.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word(字段类型:bit,字段长度:1,是否可空:True)
 objvMicroteachCase4AllEN.WordCreateDate = objRow[convMicroteachCase4All.WordCreateDate] == DBNull.Value ? null : objRow[convMicroteachCase4All.WordCreateDate].ToString().Trim(); //Word生成日期(字段类型:varchar,字段长度:14,是否可空:True)
 objvMicroteachCase4AllEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCase4All.IsVisible].ToString().Trim()); //是否显示(字段类型:bit,字段长度:1,是否可空:True)
 objvMicroteachCase4AllEN.microteachCaseText = objRow[convMicroteachCase4All.microteachCaseText] == DBNull.Value ? null : objRow[convMicroteachCase4All.microteachCaseText].ToString().Trim(); //案例文本内容(字段类型:varchar,字段长度:8000,是否可空:True)
 objvMicroteachCase4AllEN.OwnerId = objRow[convMicroteachCase4All.OwnerId].ToString().Trim(); //拥有者Id(字段类型:varchar,字段长度:20,是否可空:False)
 objvMicroteachCase4AllEN.OwnerName = objRow[convMicroteachCase4All.OwnerName] == DBNull.Value ? null : objRow[convMicroteachCase4All.OwnerName].ToString().Trim(); //拥有者姓名(字段类型:varchar,字段长度:30,是否可空:True)
 objvMicroteachCase4AllEN.CollegeId = objRow[convMicroteachCase4All.CollegeId] == DBNull.Value ? null : objRow[convMicroteachCase4All.CollegeId].ToString().Trim(); //学院ID(字段类型:varchar,字段长度:4,是否可空:False)
 objvMicroteachCase4AllEN.CollegeName = objRow[convMicroteachCase4All.CollegeName] == DBNull.Value ? null : objRow[convMicroteachCase4All.CollegeName].ToString().Trim(); //学院名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvMicroteachCase4AllEN.OwnerNameWithId = objRow[convMicroteachCase4All.OwnerNameWithId] == DBNull.Value ? null : objRow[convMicroteachCase4All.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id(字段类型:varchar,字段长度:51,是否可空:True)
 objvMicroteachCase4AllEN.IdXzCollege = objRow[convMicroteachCase4All.IdXzCollege] == DBNull.Value ? null : objRow[convMicroteachCase4All.IdXzCollege].ToString().Trim(); //学院流水号(字段类型:char,字段长度:4,是否可空:True)
 objvMicroteachCase4AllEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCase4All.IsDualVideo].ToString().Trim()); //是否双视频(字段类型:bit,字段长度:1,是否可空:False)
 objvMicroteachCase4AllEN.UserKindId = objRow[convMicroteachCase4All.UserKindId].ToString().Trim(); //用户类别Id(字段类型:char,字段长度:2,是否可空:False)
 objvMicroteachCase4AllEN.UserKindName = objRow[convMicroteachCase4All.UserKindName] == DBNull.Value ? null : objRow[convMicroteachCase4All.UserKindName].ToString().Trim(); //用户类别名(字段类型:varchar,字段长度:30,是否可空:False)
 objvMicroteachCase4AllEN.UserTypeId = objRow[convMicroteachCase4All.UserTypeId] == DBNull.Value ? null : objRow[convMicroteachCase4All.UserTypeId].ToString().Trim(); //用户类型Id(字段类型:char,字段长度:2,是否可空:True)
 objvMicroteachCase4AllEN.UserTypeName = objRow[convMicroteachCase4All.UserTypeName] == DBNull.Value ? null : objRow[convMicroteachCase4All.UserTypeName].ToString().Trim(); //用户类型名称(字段类型:varchar,字段长度:20,是否可空:True)
 objvMicroteachCase4AllEN.RecommendedDegreeId = objRow[convMicroteachCase4All.RecommendedDegreeId].ToString().Trim(); //推荐度Id(字段类型:char,字段长度:2,是否可空:False)
 objvMicroteachCase4AllEN.RecommendedDegreeName = objRow[convMicroteachCase4All.RecommendedDegreeName] == DBNull.Value ? null : objRow[convMicroteachCase4All.RecommendedDegreeName].ToString().Trim(); //推荐度名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvMicroteachCase4AllEN.Memo = objRow[convMicroteachCase4All.Memo] == DBNull.Value ? null : objRow[convMicroteachCase4All.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvMicroteachCase4AllEN.BrowseCount4Case = objRow[convMicroteachCase4All.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachCase4All.BrowseCount4Case].ToString().Trim()); //课例浏览次数(字段类型:int,字段长度:4,是否可空:True)
 objvMicroteachCase4AllEN.IsHaveVideo = objRow[convMicroteachCase4All.IsHaveVideo].ToString().Trim(); //IsHaveVideo(字段类型:varchar,字段长度:6,是否可空:True)
 objvMicroteachCase4AllEN.CollegeNameA = objRow[convMicroteachCase4All.CollegeNameA] == DBNull.Value ? null : objRow[convMicroteachCase4All.CollegeNameA].ToString().Trim(); //学院名称简写(字段类型:varchar,字段长度:12,是否可空:True)
 objvMicroteachCase4AllEN.ftpFileType = objRow[convMicroteachCase4All.ftpFileType] == DBNull.Value ? null : objRow[convMicroteachCase4All.ftpFileType].ToString().Trim(); //ftp文件类型(字段类型:varchar,字段长度:30,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvMicroteachCase4AllDA: GetObjByIdMicroteachCase)", objException.Message));
}
return objvMicroteachCase4AllEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvMicroteachCase4AllEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvMicroteachCase4AllDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMicroteachCase4AllDA.GetSpecSQLObj();
strSQL = "Select * from vMicroteachCase4All where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvMicroteachCase4AllEN objvMicroteachCase4AllEN = new clsvMicroteachCase4AllEN()
{
IdMicroteachCase = objRow[convMicroteachCase4All.IdMicroteachCase].ToString().Trim(), //微格教学案例流水号
MicroteachCaseTypeName = objRow[convMicroteachCase4All.MicroteachCaseTypeName] == DBNull.Value ? null : objRow[convMicroteachCase4All.MicroteachCaseTypeName].ToString().Trim(), //微格案例类型名称
MicroteachCaseID = objRow[convMicroteachCase4All.MicroteachCaseID].ToString().Trim(), //微格教学案例ID
MicroteachCaseName = objRow[convMicroteachCase4All.MicroteachCaseName].ToString().Trim(), //微格教学案例名称
MicroteachCaseTheme = objRow[convMicroteachCase4All.MicroteachCaseTheme] == DBNull.Value ? null : objRow[convMicroteachCase4All.MicroteachCaseTheme].ToString().Trim(), //微格教学案例主题词
MicroteachCaseDate = objRow[convMicroteachCase4All.MicroteachCaseDate] == DBNull.Value ? null : objRow[convMicroteachCase4All.MicroteachCaseDate].ToString().Trim(), //微格教学日期
MicroteachCaseTime = objRow[convMicroteachCase4All.MicroteachCaseTime] == DBNull.Value ? null : objRow[convMicroteachCase4All.MicroteachCaseTime].ToString().Trim(), //微格教学时间
MicroteachCaseDateIn = objRow[convMicroteachCase4All.MicroteachCaseDateIn] == DBNull.Value ? null : objRow[convMicroteachCase4All.MicroteachCaseDateIn].ToString().Trim(), //案例入库日期
IdStudyLevel = objRow[convMicroteachCase4All.IdStudyLevel] == DBNull.Value ? null : objRow[convMicroteachCase4All.IdStudyLevel].ToString().Trim(), //id_StudyLevel
StudyLevelName = objRow[convMicroteachCase4All.StudyLevelName] == DBNull.Value ? null : objRow[convMicroteachCase4All.StudyLevelName].ToString().Trim(), //学段名称
IdTeachingPlan = objRow[convMicroteachCase4All.IdTeachingPlan] == DBNull.Value ? null : objRow[convMicroteachCase4All.IdTeachingPlan].ToString().Trim(), //教案流水号
MicroTeachCaseTimeIn = objRow[convMicroteachCase4All.MicroTeachCaseTimeIn] == DBNull.Value ? null : objRow[convMicroteachCase4All.MicroTeachCaseTimeIn].ToString().Trim(), //案例入库时间
IdMicroteachCaseType = objRow[convMicroteachCase4All.IdMicroteachCaseType].ToString().Trim(), //微格案例类型流水号
IdCaseType = objRow[convMicroteachCase4All.IdCaseType].ToString().Trim(), //案例类型流水号
IdDiscipline = objRow[convMicroteachCase4All.IdDiscipline].ToString().Trim(), //学科流水号
DisciplineID = objRow[convMicroteachCase4All.DisciplineID] == DBNull.Value ? null : objRow[convMicroteachCase4All.DisciplineID].ToString().Trim(), //学科ID
DisciplineName = objRow[convMicroteachCase4All.DisciplineName] == DBNull.Value ? null : objRow[convMicroteachCase4All.DisciplineName].ToString().Trim(), //学科名称
IdSenateGaugeVersion = objRow[convMicroteachCase4All.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[convMicroteachCase4All.IdSenateGaugeVersion].ToString().Trim(), //评价量表版本流水号
senateGaugeVersionID = objRow[convMicroteachCase4All.senateGaugeVersionID] == DBNull.Value ? null : objRow[convMicroteachCase4All.senateGaugeVersionID].ToString().Trim(), //评价量表版本ID
senateGaugeVersionName = objRow[convMicroteachCase4All.senateGaugeVersionName] == DBNull.Value ? null : objRow[convMicroteachCase4All.senateGaugeVersionName].ToString().Trim(), //评价量表版本名称
senateGaugeVersionTtlScore = objRow[convMicroteachCase4All.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convMicroteachCase4All.senateGaugeVersionTtlScore].ToString().Trim()), //评价量表版本总分
VersionNo = objRow[convMicroteachCase4All.VersionNo] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convMicroteachCase4All.VersionNo].ToString().Trim()), //版本号
IdTeachSkill = objRow[convMicroteachCase4All.IdTeachSkill].ToString().Trim(), //教学技能流水号
TeachSkillID = objRow[convMicroteachCase4All.TeachSkillID] == DBNull.Value ? null : objRow[convMicroteachCase4All.TeachSkillID].ToString().Trim(), //教学技能ID
SkillTypeName = objRow[convMicroteachCase4All.SkillTypeName] == DBNull.Value ? null : objRow[convMicroteachCase4All.SkillTypeName].ToString().Trim(), //技能类型名称
TeachSkillName = objRow[convMicroteachCase4All.TeachSkillName] == DBNull.Value ? null : objRow[convMicroteachCase4All.TeachSkillName].ToString().Trim(), //教学技能名称
TeachSkillTheory = objRow[convMicroteachCase4All.TeachSkillTheory] == DBNull.Value ? null : objRow[convMicroteachCase4All.TeachSkillTheory].ToString().Trim(), //教学技能理论阐述
TeachSkillOperMethod = objRow[convMicroteachCase4All.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convMicroteachCase4All.TeachSkillOperMethod].ToString().Trim(), //教学技能实践操作方法
IdSkillType = objRow[convMicroteachCase4All.IdSkillType] == DBNull.Value ? null : objRow[convMicroteachCase4All.IdSkillType].ToString().Trim(), //技能类型流水号
SkillTypeID = objRow[convMicroteachCase4All.SkillTypeID] == DBNull.Value ? null : objRow[convMicroteachCase4All.SkillTypeID].ToString().Trim(), //技能类型ID
CaseLevelId = objRow[convMicroteachCase4All.CaseLevelId] == DBNull.Value ? null : objRow[convMicroteachCase4All.CaseLevelId].ToString().Trim(), //课例等级Id
CaseLevelName = objRow[convMicroteachCase4All.CaseLevelName] == DBNull.Value ? null : objRow[convMicroteachCase4All.CaseLevelName].ToString().Trim(), //案例等级名称
DocFile = objRow[convMicroteachCase4All.DocFile] == DBNull.Value ? null : objRow[convMicroteachCase4All.DocFile].ToString().Trim(), //生成的Word文件名
IsNeedGeneWord = TransNullToBool(objRow[convMicroteachCase4All.IsNeedGeneWord].ToString().Trim()), //是否需要生成Word
WordCreateDate = objRow[convMicroteachCase4All.WordCreateDate] == DBNull.Value ? null : objRow[convMicroteachCase4All.WordCreateDate].ToString().Trim(), //Word生成日期
IsVisible = TransNullToBool(objRow[convMicroteachCase4All.IsVisible].ToString().Trim()), //是否显示
microteachCaseText = objRow[convMicroteachCase4All.microteachCaseText] == DBNull.Value ? null : objRow[convMicroteachCase4All.microteachCaseText].ToString().Trim(), //案例文本内容
OwnerId = objRow[convMicroteachCase4All.OwnerId].ToString().Trim(), //拥有者Id
OwnerName = objRow[convMicroteachCase4All.OwnerName] == DBNull.Value ? null : objRow[convMicroteachCase4All.OwnerName].ToString().Trim(), //拥有者姓名
CollegeId = objRow[convMicroteachCase4All.CollegeId] == DBNull.Value ? null : objRow[convMicroteachCase4All.CollegeId].ToString().Trim(), //学院ID
CollegeName = objRow[convMicroteachCase4All.CollegeName] == DBNull.Value ? null : objRow[convMicroteachCase4All.CollegeName].ToString().Trim(), //学院名称
OwnerNameWithId = objRow[convMicroteachCase4All.OwnerNameWithId] == DBNull.Value ? null : objRow[convMicroteachCase4All.OwnerNameWithId].ToString().Trim(), //拥有者名称附Id
IdXzCollege = objRow[convMicroteachCase4All.IdXzCollege] == DBNull.Value ? null : objRow[convMicroteachCase4All.IdXzCollege].ToString().Trim(), //学院流水号
IsDualVideo = TransNullToBool(objRow[convMicroteachCase4All.IsDualVideo].ToString().Trim()), //是否双视频
UserKindId = objRow[convMicroteachCase4All.UserKindId].ToString().Trim(), //用户类别Id
UserKindName = objRow[convMicroteachCase4All.UserKindName] == DBNull.Value ? null : objRow[convMicroteachCase4All.UserKindName].ToString().Trim(), //用户类别名
UserTypeId = objRow[convMicroteachCase4All.UserTypeId] == DBNull.Value ? null : objRow[convMicroteachCase4All.UserTypeId].ToString().Trim(), //用户类型Id
UserTypeName = objRow[convMicroteachCase4All.UserTypeName] == DBNull.Value ? null : objRow[convMicroteachCase4All.UserTypeName].ToString().Trim(), //用户类型名称
RecommendedDegreeId = objRow[convMicroteachCase4All.RecommendedDegreeId].ToString().Trim(), //推荐度Id
RecommendedDegreeName = objRow[convMicroteachCase4All.RecommendedDegreeName] == DBNull.Value ? null : objRow[convMicroteachCase4All.RecommendedDegreeName].ToString().Trim(), //推荐度名称
Memo = objRow[convMicroteachCase4All.Memo] == DBNull.Value ? null : objRow[convMicroteachCase4All.Memo].ToString().Trim(), //备注
BrowseCount4Case = objRow[convMicroteachCase4All.BrowseCount4Case] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convMicroteachCase4All.BrowseCount4Case].ToString().Trim()), //课例浏览次数
IsHaveVideo = objRow[convMicroteachCase4All.IsHaveVideo].ToString().Trim(), //IsHaveVideo
CollegeNameA = objRow[convMicroteachCase4All.CollegeNameA] == DBNull.Value ? null : objRow[convMicroteachCase4All.CollegeNameA].ToString().Trim(), //学院名称简写
ftpFileType = objRow[convMicroteachCase4All.ftpFileType] == DBNull.Value ? null : objRow[convMicroteachCase4All.ftpFileType].ToString().Trim() //ftp文件类型
};
objvMicroteachCase4AllEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvMicroteachCase4AllEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvMicroteachCase4AllDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvMicroteachCase4AllEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvMicroteachCase4AllEN objvMicroteachCase4AllEN = new clsvMicroteachCase4AllEN();
try
{
objvMicroteachCase4AllEN.IdMicroteachCase = objRow[convMicroteachCase4All.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvMicroteachCase4AllEN.MicroteachCaseTypeName = objRow[convMicroteachCase4All.MicroteachCaseTypeName] == DBNull.Value ? null : objRow[convMicroteachCase4All.MicroteachCaseTypeName].ToString().Trim(); //微格案例类型名称
objvMicroteachCase4AllEN.MicroteachCaseID = objRow[convMicroteachCase4All.MicroteachCaseID].ToString().Trim(); //微格教学案例ID
objvMicroteachCase4AllEN.MicroteachCaseName = objRow[convMicroteachCase4All.MicroteachCaseName].ToString().Trim(); //微格教学案例名称
objvMicroteachCase4AllEN.MicroteachCaseTheme = objRow[convMicroteachCase4All.MicroteachCaseTheme] == DBNull.Value ? null : objRow[convMicroteachCase4All.MicroteachCaseTheme].ToString().Trim(); //微格教学案例主题词
objvMicroteachCase4AllEN.MicroteachCaseDate = objRow[convMicroteachCase4All.MicroteachCaseDate] == DBNull.Value ? null : objRow[convMicroteachCase4All.MicroteachCaseDate].ToString().Trim(); //微格教学日期
objvMicroteachCase4AllEN.MicroteachCaseTime = objRow[convMicroteachCase4All.MicroteachCaseTime] == DBNull.Value ? null : objRow[convMicroteachCase4All.MicroteachCaseTime].ToString().Trim(); //微格教学时间
objvMicroteachCase4AllEN.MicroteachCaseDateIn = objRow[convMicroteachCase4All.MicroteachCaseDateIn] == DBNull.Value ? null : objRow[convMicroteachCase4All.MicroteachCaseDateIn].ToString().Trim(); //案例入库日期
objvMicroteachCase4AllEN.IdStudyLevel = objRow[convMicroteachCase4All.IdStudyLevel] == DBNull.Value ? null : objRow[convMicroteachCase4All.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvMicroteachCase4AllEN.StudyLevelName = objRow[convMicroteachCase4All.StudyLevelName] == DBNull.Value ? null : objRow[convMicroteachCase4All.StudyLevelName].ToString().Trim(); //学段名称
objvMicroteachCase4AllEN.IdTeachingPlan = objRow[convMicroteachCase4All.IdTeachingPlan] == DBNull.Value ? null : objRow[convMicroteachCase4All.IdTeachingPlan].ToString().Trim(); //教案流水号
objvMicroteachCase4AllEN.MicroTeachCaseTimeIn = objRow[convMicroteachCase4All.MicroTeachCaseTimeIn] == DBNull.Value ? null : objRow[convMicroteachCase4All.MicroTeachCaseTimeIn].ToString().Trim(); //案例入库时间
objvMicroteachCase4AllEN.IdMicroteachCaseType = objRow[convMicroteachCase4All.IdMicroteachCaseType].ToString().Trim(); //微格案例类型流水号
objvMicroteachCase4AllEN.IdCaseType = objRow[convMicroteachCase4All.IdCaseType].ToString().Trim(); //案例类型流水号
objvMicroteachCase4AllEN.IdDiscipline = objRow[convMicroteachCase4All.IdDiscipline].ToString().Trim(); //学科流水号
objvMicroteachCase4AllEN.DisciplineID = objRow[convMicroteachCase4All.DisciplineID] == DBNull.Value ? null : objRow[convMicroteachCase4All.DisciplineID].ToString().Trim(); //学科ID
objvMicroteachCase4AllEN.DisciplineName = objRow[convMicroteachCase4All.DisciplineName] == DBNull.Value ? null : objRow[convMicroteachCase4All.DisciplineName].ToString().Trim(); //学科名称
objvMicroteachCase4AllEN.IdSenateGaugeVersion = objRow[convMicroteachCase4All.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[convMicroteachCase4All.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvMicroteachCase4AllEN.senateGaugeVersionID = objRow[convMicroteachCase4All.senateGaugeVersionID] == DBNull.Value ? null : objRow[convMicroteachCase4All.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvMicroteachCase4AllEN.senateGaugeVersionName = objRow[convMicroteachCase4All.senateGaugeVersionName] == DBNull.Value ? null : objRow[convMicroteachCase4All.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvMicroteachCase4AllEN.senateGaugeVersionTtlScore = objRow[convMicroteachCase4All.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convMicroteachCase4All.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvMicroteachCase4AllEN.VersionNo = objRow[convMicroteachCase4All.VersionNo] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convMicroteachCase4All.VersionNo].ToString().Trim()); //版本号
objvMicroteachCase4AllEN.IdTeachSkill = objRow[convMicroteachCase4All.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvMicroteachCase4AllEN.TeachSkillID = objRow[convMicroteachCase4All.TeachSkillID] == DBNull.Value ? null : objRow[convMicroteachCase4All.TeachSkillID].ToString().Trim(); //教学技能ID
objvMicroteachCase4AllEN.SkillTypeName = objRow[convMicroteachCase4All.SkillTypeName] == DBNull.Value ? null : objRow[convMicroteachCase4All.SkillTypeName].ToString().Trim(); //技能类型名称
objvMicroteachCase4AllEN.TeachSkillName = objRow[convMicroteachCase4All.TeachSkillName] == DBNull.Value ? null : objRow[convMicroteachCase4All.TeachSkillName].ToString().Trim(); //教学技能名称
objvMicroteachCase4AllEN.TeachSkillTheory = objRow[convMicroteachCase4All.TeachSkillTheory] == DBNull.Value ? null : objRow[convMicroteachCase4All.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvMicroteachCase4AllEN.TeachSkillOperMethod = objRow[convMicroteachCase4All.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convMicroteachCase4All.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvMicroteachCase4AllEN.IdSkillType = objRow[convMicroteachCase4All.IdSkillType] == DBNull.Value ? null : objRow[convMicroteachCase4All.IdSkillType].ToString().Trim(); //技能类型流水号
objvMicroteachCase4AllEN.SkillTypeID = objRow[convMicroteachCase4All.SkillTypeID] == DBNull.Value ? null : objRow[convMicroteachCase4All.SkillTypeID].ToString().Trim(); //技能类型ID
objvMicroteachCase4AllEN.CaseLevelId = objRow[convMicroteachCase4All.CaseLevelId] == DBNull.Value ? null : objRow[convMicroteachCase4All.CaseLevelId].ToString().Trim(); //课例等级Id
objvMicroteachCase4AllEN.CaseLevelName = objRow[convMicroteachCase4All.CaseLevelName] == DBNull.Value ? null : objRow[convMicroteachCase4All.CaseLevelName].ToString().Trim(); //案例等级名称
objvMicroteachCase4AllEN.DocFile = objRow[convMicroteachCase4All.DocFile] == DBNull.Value ? null : objRow[convMicroteachCase4All.DocFile].ToString().Trim(); //生成的Word文件名
objvMicroteachCase4AllEN.IsNeedGeneWord = TransNullToBool(objRow[convMicroteachCase4All.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objvMicroteachCase4AllEN.WordCreateDate = objRow[convMicroteachCase4All.WordCreateDate] == DBNull.Value ? null : objRow[convMicroteachCase4All.WordCreateDate].ToString().Trim(); //Word生成日期
objvMicroteachCase4AllEN.IsVisible = TransNullToBool(objRow[convMicroteachCase4All.IsVisible].ToString().Trim()); //是否显示
objvMicroteachCase4AllEN.microteachCaseText = objRow[convMicroteachCase4All.microteachCaseText] == DBNull.Value ? null : objRow[convMicroteachCase4All.microteachCaseText].ToString().Trim(); //案例文本内容
objvMicroteachCase4AllEN.OwnerId = objRow[convMicroteachCase4All.OwnerId].ToString().Trim(); //拥有者Id
objvMicroteachCase4AllEN.OwnerName = objRow[convMicroteachCase4All.OwnerName] == DBNull.Value ? null : objRow[convMicroteachCase4All.OwnerName].ToString().Trim(); //拥有者姓名
objvMicroteachCase4AllEN.CollegeId = objRow[convMicroteachCase4All.CollegeId] == DBNull.Value ? null : objRow[convMicroteachCase4All.CollegeId].ToString().Trim(); //学院ID
objvMicroteachCase4AllEN.CollegeName = objRow[convMicroteachCase4All.CollegeName] == DBNull.Value ? null : objRow[convMicroteachCase4All.CollegeName].ToString().Trim(); //学院名称
objvMicroteachCase4AllEN.OwnerNameWithId = objRow[convMicroteachCase4All.OwnerNameWithId] == DBNull.Value ? null : objRow[convMicroteachCase4All.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvMicroteachCase4AllEN.IdXzCollege = objRow[convMicroteachCase4All.IdXzCollege] == DBNull.Value ? null : objRow[convMicroteachCase4All.IdXzCollege].ToString().Trim(); //学院流水号
objvMicroteachCase4AllEN.IsDualVideo = TransNullToBool(objRow[convMicroteachCase4All.IsDualVideo].ToString().Trim()); //是否双视频
objvMicroteachCase4AllEN.UserKindId = objRow[convMicroteachCase4All.UserKindId].ToString().Trim(); //用户类别Id
objvMicroteachCase4AllEN.UserKindName = objRow[convMicroteachCase4All.UserKindName] == DBNull.Value ? null : objRow[convMicroteachCase4All.UserKindName].ToString().Trim(); //用户类别名
objvMicroteachCase4AllEN.UserTypeId = objRow[convMicroteachCase4All.UserTypeId] == DBNull.Value ? null : objRow[convMicroteachCase4All.UserTypeId].ToString().Trim(); //用户类型Id
objvMicroteachCase4AllEN.UserTypeName = objRow[convMicroteachCase4All.UserTypeName] == DBNull.Value ? null : objRow[convMicroteachCase4All.UserTypeName].ToString().Trim(); //用户类型名称
objvMicroteachCase4AllEN.RecommendedDegreeId = objRow[convMicroteachCase4All.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvMicroteachCase4AllEN.RecommendedDegreeName = objRow[convMicroteachCase4All.RecommendedDegreeName] == DBNull.Value ? null : objRow[convMicroteachCase4All.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvMicroteachCase4AllEN.Memo = objRow[convMicroteachCase4All.Memo] == DBNull.Value ? null : objRow[convMicroteachCase4All.Memo].ToString().Trim(); //备注
objvMicroteachCase4AllEN.BrowseCount4Case = objRow[convMicroteachCase4All.BrowseCount4Case] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convMicroteachCase4All.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvMicroteachCase4AllEN.IsHaveVideo = objRow[convMicroteachCase4All.IsHaveVideo].ToString().Trim(); //IsHaveVideo
objvMicroteachCase4AllEN.CollegeNameA = objRow[convMicroteachCase4All.CollegeNameA] == DBNull.Value ? null : objRow[convMicroteachCase4All.CollegeNameA].ToString().Trim(); //学院名称简写
objvMicroteachCase4AllEN.ftpFileType = objRow[convMicroteachCase4All.ftpFileType] == DBNull.Value ? null : objRow[convMicroteachCase4All.ftpFileType].ToString().Trim(); //ftp文件类型
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvMicroteachCase4AllDA: GetObjByDataRowvMicroteachCase4All)", objException.Message));
}
objvMicroteachCase4AllEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvMicroteachCase4AllEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvMicroteachCase4AllEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvMicroteachCase4AllEN objvMicroteachCase4AllEN = new clsvMicroteachCase4AllEN();
try
{
objvMicroteachCase4AllEN.IdMicroteachCase = objRow[convMicroteachCase4All.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvMicroteachCase4AllEN.MicroteachCaseTypeName = objRow[convMicroteachCase4All.MicroteachCaseTypeName] == DBNull.Value ? null : objRow[convMicroteachCase4All.MicroteachCaseTypeName].ToString().Trim(); //微格案例类型名称
objvMicroteachCase4AllEN.MicroteachCaseID = objRow[convMicroteachCase4All.MicroteachCaseID].ToString().Trim(); //微格教学案例ID
objvMicroteachCase4AllEN.MicroteachCaseName = objRow[convMicroteachCase4All.MicroteachCaseName].ToString().Trim(); //微格教学案例名称
objvMicroteachCase4AllEN.MicroteachCaseTheme = objRow[convMicroteachCase4All.MicroteachCaseTheme] == DBNull.Value ? null : objRow[convMicroteachCase4All.MicroteachCaseTheme].ToString().Trim(); //微格教学案例主题词
objvMicroteachCase4AllEN.MicroteachCaseDate = objRow[convMicroteachCase4All.MicroteachCaseDate] == DBNull.Value ? null : objRow[convMicroteachCase4All.MicroteachCaseDate].ToString().Trim(); //微格教学日期
objvMicroteachCase4AllEN.MicroteachCaseTime = objRow[convMicroteachCase4All.MicroteachCaseTime] == DBNull.Value ? null : objRow[convMicroteachCase4All.MicroteachCaseTime].ToString().Trim(); //微格教学时间
objvMicroteachCase4AllEN.MicroteachCaseDateIn = objRow[convMicroteachCase4All.MicroteachCaseDateIn] == DBNull.Value ? null : objRow[convMicroteachCase4All.MicroteachCaseDateIn].ToString().Trim(); //案例入库日期
objvMicroteachCase4AllEN.IdStudyLevel = objRow[convMicroteachCase4All.IdStudyLevel] == DBNull.Value ? null : objRow[convMicroteachCase4All.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvMicroteachCase4AllEN.StudyLevelName = objRow[convMicroteachCase4All.StudyLevelName] == DBNull.Value ? null : objRow[convMicroteachCase4All.StudyLevelName].ToString().Trim(); //学段名称
objvMicroteachCase4AllEN.IdTeachingPlan = objRow[convMicroteachCase4All.IdTeachingPlan] == DBNull.Value ? null : objRow[convMicroteachCase4All.IdTeachingPlan].ToString().Trim(); //教案流水号
objvMicroteachCase4AllEN.MicroTeachCaseTimeIn = objRow[convMicroteachCase4All.MicroTeachCaseTimeIn] == DBNull.Value ? null : objRow[convMicroteachCase4All.MicroTeachCaseTimeIn].ToString().Trim(); //案例入库时间
objvMicroteachCase4AllEN.IdMicroteachCaseType = objRow[convMicroteachCase4All.IdMicroteachCaseType].ToString().Trim(); //微格案例类型流水号
objvMicroteachCase4AllEN.IdCaseType = objRow[convMicroteachCase4All.IdCaseType].ToString().Trim(); //案例类型流水号
objvMicroteachCase4AllEN.IdDiscipline = objRow[convMicroteachCase4All.IdDiscipline].ToString().Trim(); //学科流水号
objvMicroteachCase4AllEN.DisciplineID = objRow[convMicroteachCase4All.DisciplineID] == DBNull.Value ? null : objRow[convMicroteachCase4All.DisciplineID].ToString().Trim(); //学科ID
objvMicroteachCase4AllEN.DisciplineName = objRow[convMicroteachCase4All.DisciplineName] == DBNull.Value ? null : objRow[convMicroteachCase4All.DisciplineName].ToString().Trim(); //学科名称
objvMicroteachCase4AllEN.IdSenateGaugeVersion = objRow[convMicroteachCase4All.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[convMicroteachCase4All.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvMicroteachCase4AllEN.senateGaugeVersionID = objRow[convMicroteachCase4All.senateGaugeVersionID] == DBNull.Value ? null : objRow[convMicroteachCase4All.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvMicroteachCase4AllEN.senateGaugeVersionName = objRow[convMicroteachCase4All.senateGaugeVersionName] == DBNull.Value ? null : objRow[convMicroteachCase4All.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvMicroteachCase4AllEN.senateGaugeVersionTtlScore = objRow[convMicroteachCase4All.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convMicroteachCase4All.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvMicroteachCase4AllEN.VersionNo = objRow[convMicroteachCase4All.VersionNo] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convMicroteachCase4All.VersionNo].ToString().Trim()); //版本号
objvMicroteachCase4AllEN.IdTeachSkill = objRow[convMicroteachCase4All.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvMicroteachCase4AllEN.TeachSkillID = objRow[convMicroteachCase4All.TeachSkillID] == DBNull.Value ? null : objRow[convMicroteachCase4All.TeachSkillID].ToString().Trim(); //教学技能ID
objvMicroteachCase4AllEN.SkillTypeName = objRow[convMicroteachCase4All.SkillTypeName] == DBNull.Value ? null : objRow[convMicroteachCase4All.SkillTypeName].ToString().Trim(); //技能类型名称
objvMicroteachCase4AllEN.TeachSkillName = objRow[convMicroteachCase4All.TeachSkillName] == DBNull.Value ? null : objRow[convMicroteachCase4All.TeachSkillName].ToString().Trim(); //教学技能名称
objvMicroteachCase4AllEN.TeachSkillTheory = objRow[convMicroteachCase4All.TeachSkillTheory] == DBNull.Value ? null : objRow[convMicroteachCase4All.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvMicroteachCase4AllEN.TeachSkillOperMethod = objRow[convMicroteachCase4All.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convMicroteachCase4All.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvMicroteachCase4AllEN.IdSkillType = objRow[convMicroteachCase4All.IdSkillType] == DBNull.Value ? null : objRow[convMicroteachCase4All.IdSkillType].ToString().Trim(); //技能类型流水号
objvMicroteachCase4AllEN.SkillTypeID = objRow[convMicroteachCase4All.SkillTypeID] == DBNull.Value ? null : objRow[convMicroteachCase4All.SkillTypeID].ToString().Trim(); //技能类型ID
objvMicroteachCase4AllEN.CaseLevelId = objRow[convMicroteachCase4All.CaseLevelId] == DBNull.Value ? null : objRow[convMicroteachCase4All.CaseLevelId].ToString().Trim(); //课例等级Id
objvMicroteachCase4AllEN.CaseLevelName = objRow[convMicroteachCase4All.CaseLevelName] == DBNull.Value ? null : objRow[convMicroteachCase4All.CaseLevelName].ToString().Trim(); //案例等级名称
objvMicroteachCase4AllEN.DocFile = objRow[convMicroteachCase4All.DocFile] == DBNull.Value ? null : objRow[convMicroteachCase4All.DocFile].ToString().Trim(); //生成的Word文件名
objvMicroteachCase4AllEN.IsNeedGeneWord = TransNullToBool(objRow[convMicroteachCase4All.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objvMicroteachCase4AllEN.WordCreateDate = objRow[convMicroteachCase4All.WordCreateDate] == DBNull.Value ? null : objRow[convMicroteachCase4All.WordCreateDate].ToString().Trim(); //Word生成日期
objvMicroteachCase4AllEN.IsVisible = TransNullToBool(objRow[convMicroteachCase4All.IsVisible].ToString().Trim()); //是否显示
objvMicroteachCase4AllEN.microteachCaseText = objRow[convMicroteachCase4All.microteachCaseText] == DBNull.Value ? null : objRow[convMicroteachCase4All.microteachCaseText].ToString().Trim(); //案例文本内容
objvMicroteachCase4AllEN.OwnerId = objRow[convMicroteachCase4All.OwnerId].ToString().Trim(); //拥有者Id
objvMicroteachCase4AllEN.OwnerName = objRow[convMicroteachCase4All.OwnerName] == DBNull.Value ? null : objRow[convMicroteachCase4All.OwnerName].ToString().Trim(); //拥有者姓名
objvMicroteachCase4AllEN.CollegeId = objRow[convMicroteachCase4All.CollegeId] == DBNull.Value ? null : objRow[convMicroteachCase4All.CollegeId].ToString().Trim(); //学院ID
objvMicroteachCase4AllEN.CollegeName = objRow[convMicroteachCase4All.CollegeName] == DBNull.Value ? null : objRow[convMicroteachCase4All.CollegeName].ToString().Trim(); //学院名称
objvMicroteachCase4AllEN.OwnerNameWithId = objRow[convMicroteachCase4All.OwnerNameWithId] == DBNull.Value ? null : objRow[convMicroteachCase4All.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvMicroteachCase4AllEN.IdXzCollege = objRow[convMicroteachCase4All.IdXzCollege] == DBNull.Value ? null : objRow[convMicroteachCase4All.IdXzCollege].ToString().Trim(); //学院流水号
objvMicroteachCase4AllEN.IsDualVideo = TransNullToBool(objRow[convMicroteachCase4All.IsDualVideo].ToString().Trim()); //是否双视频
objvMicroteachCase4AllEN.UserKindId = objRow[convMicroteachCase4All.UserKindId].ToString().Trim(); //用户类别Id
objvMicroteachCase4AllEN.UserKindName = objRow[convMicroteachCase4All.UserKindName] == DBNull.Value ? null : objRow[convMicroteachCase4All.UserKindName].ToString().Trim(); //用户类别名
objvMicroteachCase4AllEN.UserTypeId = objRow[convMicroteachCase4All.UserTypeId] == DBNull.Value ? null : objRow[convMicroteachCase4All.UserTypeId].ToString().Trim(); //用户类型Id
objvMicroteachCase4AllEN.UserTypeName = objRow[convMicroteachCase4All.UserTypeName] == DBNull.Value ? null : objRow[convMicroteachCase4All.UserTypeName].ToString().Trim(); //用户类型名称
objvMicroteachCase4AllEN.RecommendedDegreeId = objRow[convMicroteachCase4All.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvMicroteachCase4AllEN.RecommendedDegreeName = objRow[convMicroteachCase4All.RecommendedDegreeName] == DBNull.Value ? null : objRow[convMicroteachCase4All.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvMicroteachCase4AllEN.Memo = objRow[convMicroteachCase4All.Memo] == DBNull.Value ? null : objRow[convMicroteachCase4All.Memo].ToString().Trim(); //备注
objvMicroteachCase4AllEN.BrowseCount4Case = objRow[convMicroteachCase4All.BrowseCount4Case] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convMicroteachCase4All.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvMicroteachCase4AllEN.IsHaveVideo = objRow[convMicroteachCase4All.IsHaveVideo].ToString().Trim(); //IsHaveVideo
objvMicroteachCase4AllEN.CollegeNameA = objRow[convMicroteachCase4All.CollegeNameA] == DBNull.Value ? null : objRow[convMicroteachCase4All.CollegeNameA].ToString().Trim(); //学院名称简写
objvMicroteachCase4AllEN.ftpFileType = objRow[convMicroteachCase4All.ftpFileType] == DBNull.Value ? null : objRow[convMicroteachCase4All.ftpFileType].ToString().Trim(); //ftp文件类型
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvMicroteachCase4AllDA: GetObjByDataRow)", objException.Message));
}
objvMicroteachCase4AllEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvMicroteachCase4AllEN;
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
objSQL = clsvMicroteachCase4AllDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvMicroteachCase4AllEN._CurrTabName, convMicroteachCase4All.IdMicroteachCase, 8, "");
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
objSQL = clsvMicroteachCase4AllDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvMicroteachCase4AllEN._CurrTabName, convMicroteachCase4All.IdMicroteachCase, 8, strPrefix);
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
 objSQL = clsvMicroteachCase4AllDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select IdMicroteachCase from vMicroteachCase4All where " + strCondition;
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
 objSQL = clsvMicroteachCase4AllDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select IdMicroteachCase from vMicroteachCase4All where " + strCondition;
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
 /// <param name = "strIdMicroteachCase">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strIdMicroteachCase)
{
CheckPrimaryKey(strIdMicroteachCase);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMicroteachCase4AllDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vMicroteachCase4All", "IdMicroteachCase = " + "'"+ strIdMicroteachCase+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvMicroteachCase4AllDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMicroteachCase4AllDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vMicroteachCase4All", strCondition))
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
objSQL = clsvMicroteachCase4AllDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vMicroteachCase4All");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvMicroteachCase4AllENS">源对象</param>
 /// <param name = "objvMicroteachCase4AllENT">目标对象</param>
public void CopyTo(clsvMicroteachCase4AllEN objvMicroteachCase4AllENS, clsvMicroteachCase4AllEN objvMicroteachCase4AllENT)
{
objvMicroteachCase4AllENT.IdMicroteachCase = objvMicroteachCase4AllENS.IdMicroteachCase; //微格教学案例流水号
objvMicroteachCase4AllENT.MicroteachCaseTypeName = objvMicroteachCase4AllENS.MicroteachCaseTypeName; //微格案例类型名称
objvMicroteachCase4AllENT.MicroteachCaseID = objvMicroteachCase4AllENS.MicroteachCaseID; //微格教学案例ID
objvMicroteachCase4AllENT.MicroteachCaseName = objvMicroteachCase4AllENS.MicroteachCaseName; //微格教学案例名称
objvMicroteachCase4AllENT.MicroteachCaseTheme = objvMicroteachCase4AllENS.MicroteachCaseTheme; //微格教学案例主题词
objvMicroteachCase4AllENT.MicroteachCaseDate = objvMicroteachCase4AllENS.MicroteachCaseDate; //微格教学日期
objvMicroteachCase4AllENT.MicroteachCaseTime = objvMicroteachCase4AllENS.MicroteachCaseTime; //微格教学时间
objvMicroteachCase4AllENT.MicroteachCaseDateIn = objvMicroteachCase4AllENS.MicroteachCaseDateIn; //案例入库日期
objvMicroteachCase4AllENT.IdStudyLevel = objvMicroteachCase4AllENS.IdStudyLevel; //id_StudyLevel
objvMicroteachCase4AllENT.StudyLevelName = objvMicroteachCase4AllENS.StudyLevelName; //学段名称
objvMicroteachCase4AllENT.IdTeachingPlan = objvMicroteachCase4AllENS.IdTeachingPlan; //教案流水号
objvMicroteachCase4AllENT.MicroTeachCaseTimeIn = objvMicroteachCase4AllENS.MicroTeachCaseTimeIn; //案例入库时间
objvMicroteachCase4AllENT.IdMicroteachCaseType = objvMicroteachCase4AllENS.IdMicroteachCaseType; //微格案例类型流水号
objvMicroteachCase4AllENT.IdCaseType = objvMicroteachCase4AllENS.IdCaseType; //案例类型流水号
objvMicroteachCase4AllENT.IdDiscipline = objvMicroteachCase4AllENS.IdDiscipline; //学科流水号
objvMicroteachCase4AllENT.DisciplineID = objvMicroteachCase4AllENS.DisciplineID; //学科ID
objvMicroteachCase4AllENT.DisciplineName = objvMicroteachCase4AllENS.DisciplineName; //学科名称
objvMicroteachCase4AllENT.IdSenateGaugeVersion = objvMicroteachCase4AllENS.IdSenateGaugeVersion; //评价量表版本流水号
objvMicroteachCase4AllENT.senateGaugeVersionID = objvMicroteachCase4AllENS.senateGaugeVersionID; //评价量表版本ID
objvMicroteachCase4AllENT.senateGaugeVersionName = objvMicroteachCase4AllENS.senateGaugeVersionName; //评价量表版本名称
objvMicroteachCase4AllENT.senateGaugeVersionTtlScore = objvMicroteachCase4AllENS.senateGaugeVersionTtlScore; //评价量表版本总分
objvMicroteachCase4AllENT.VersionNo = objvMicroteachCase4AllENS.VersionNo; //版本号
objvMicroteachCase4AllENT.IdTeachSkill = objvMicroteachCase4AllENS.IdTeachSkill; //教学技能流水号
objvMicroteachCase4AllENT.TeachSkillID = objvMicroteachCase4AllENS.TeachSkillID; //教学技能ID
objvMicroteachCase4AllENT.SkillTypeName = objvMicroteachCase4AllENS.SkillTypeName; //技能类型名称
objvMicroteachCase4AllENT.TeachSkillName = objvMicroteachCase4AllENS.TeachSkillName; //教学技能名称
objvMicroteachCase4AllENT.TeachSkillTheory = objvMicroteachCase4AllENS.TeachSkillTheory; //教学技能理论阐述
objvMicroteachCase4AllENT.TeachSkillOperMethod = objvMicroteachCase4AllENS.TeachSkillOperMethod; //教学技能实践操作方法
objvMicroteachCase4AllENT.IdSkillType = objvMicroteachCase4AllENS.IdSkillType; //技能类型流水号
objvMicroteachCase4AllENT.SkillTypeID = objvMicroteachCase4AllENS.SkillTypeID; //技能类型ID
objvMicroteachCase4AllENT.CaseLevelId = objvMicroteachCase4AllENS.CaseLevelId; //课例等级Id
objvMicroteachCase4AllENT.CaseLevelName = objvMicroteachCase4AllENS.CaseLevelName; //案例等级名称
objvMicroteachCase4AllENT.DocFile = objvMicroteachCase4AllENS.DocFile; //生成的Word文件名
objvMicroteachCase4AllENT.IsNeedGeneWord = objvMicroteachCase4AllENS.IsNeedGeneWord; //是否需要生成Word
objvMicroteachCase4AllENT.WordCreateDate = objvMicroteachCase4AllENS.WordCreateDate; //Word生成日期
objvMicroteachCase4AllENT.IsVisible = objvMicroteachCase4AllENS.IsVisible; //是否显示
objvMicroteachCase4AllENT.microteachCaseText = objvMicroteachCase4AllENS.microteachCaseText; //案例文本内容
objvMicroteachCase4AllENT.OwnerId = objvMicroteachCase4AllENS.OwnerId; //拥有者Id
objvMicroteachCase4AllENT.OwnerName = objvMicroteachCase4AllENS.OwnerName; //拥有者姓名
objvMicroteachCase4AllENT.CollegeId = objvMicroteachCase4AllENS.CollegeId; //学院ID
objvMicroteachCase4AllENT.CollegeName = objvMicroteachCase4AllENS.CollegeName; //学院名称
objvMicroteachCase4AllENT.OwnerNameWithId = objvMicroteachCase4AllENS.OwnerNameWithId; //拥有者名称附Id
objvMicroteachCase4AllENT.IdXzCollege = objvMicroteachCase4AllENS.IdXzCollege; //学院流水号
objvMicroteachCase4AllENT.IsDualVideo = objvMicroteachCase4AllENS.IsDualVideo; //是否双视频
objvMicroteachCase4AllENT.UserKindId = objvMicroteachCase4AllENS.UserKindId; //用户类别Id
objvMicroteachCase4AllENT.UserKindName = objvMicroteachCase4AllENS.UserKindName; //用户类别名
objvMicroteachCase4AllENT.UserTypeId = objvMicroteachCase4AllENS.UserTypeId; //用户类型Id
objvMicroteachCase4AllENT.UserTypeName = objvMicroteachCase4AllENS.UserTypeName; //用户类型名称
objvMicroteachCase4AllENT.RecommendedDegreeId = objvMicroteachCase4AllENS.RecommendedDegreeId; //推荐度Id
objvMicroteachCase4AllENT.RecommendedDegreeName = objvMicroteachCase4AllENS.RecommendedDegreeName; //推荐度名称
objvMicroteachCase4AllENT.Memo = objvMicroteachCase4AllENS.Memo; //备注
objvMicroteachCase4AllENT.BrowseCount4Case = objvMicroteachCase4AllENS.BrowseCount4Case; //课例浏览次数
objvMicroteachCase4AllENT.IsHaveVideo = objvMicroteachCase4AllENS.IsHaveVideo; //IsHaveVideo
objvMicroteachCase4AllENT.CollegeNameA = objvMicroteachCase4AllENS.CollegeNameA; //学院名称简写
objvMicroteachCase4AllENT.ftpFileType = objvMicroteachCase4AllENS.ftpFileType; //ftp文件类型
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvMicroteachCase4AllEN objvMicroteachCase4AllEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvMicroteachCase4AllEN.IdMicroteachCase, 8, convMicroteachCase4All.IdMicroteachCase);
clsCheckSql.CheckFieldLen(objvMicroteachCase4AllEN.MicroteachCaseTypeName, 50, convMicroteachCase4All.MicroteachCaseTypeName);
clsCheckSql.CheckFieldLen(objvMicroteachCase4AllEN.MicroteachCaseID, 8, convMicroteachCase4All.MicroteachCaseID);
clsCheckSql.CheckFieldLen(objvMicroteachCase4AllEN.MicroteachCaseName, 100, convMicroteachCase4All.MicroteachCaseName);
clsCheckSql.CheckFieldLen(objvMicroteachCase4AllEN.MicroteachCaseTheme, 200, convMicroteachCase4All.MicroteachCaseTheme);
clsCheckSql.CheckFieldLen(objvMicroteachCase4AllEN.MicroteachCaseDate, 8, convMicroteachCase4All.MicroteachCaseDate);
clsCheckSql.CheckFieldLen(objvMicroteachCase4AllEN.MicroteachCaseTime, 6, convMicroteachCase4All.MicroteachCaseTime);
clsCheckSql.CheckFieldLen(objvMicroteachCase4AllEN.MicroteachCaseDateIn, 8, convMicroteachCase4All.MicroteachCaseDateIn);
clsCheckSql.CheckFieldLen(objvMicroteachCase4AllEN.IdStudyLevel, 4, convMicroteachCase4All.IdStudyLevel);
clsCheckSql.CheckFieldLen(objvMicroteachCase4AllEN.StudyLevelName, 50, convMicroteachCase4All.StudyLevelName);
clsCheckSql.CheckFieldLen(objvMicroteachCase4AllEN.IdTeachingPlan, 8, convMicroteachCase4All.IdTeachingPlan);
clsCheckSql.CheckFieldLen(objvMicroteachCase4AllEN.MicroTeachCaseTimeIn, 6, convMicroteachCase4All.MicroTeachCaseTimeIn);
clsCheckSql.CheckFieldLen(objvMicroteachCase4AllEN.IdMicroteachCaseType, 4, convMicroteachCase4All.IdMicroteachCaseType);
clsCheckSql.CheckFieldLen(objvMicroteachCase4AllEN.IdCaseType, 4, convMicroteachCase4All.IdCaseType);
clsCheckSql.CheckFieldLen(objvMicroteachCase4AllEN.IdDiscipline, 4, convMicroteachCase4All.IdDiscipline);
clsCheckSql.CheckFieldLen(objvMicroteachCase4AllEN.DisciplineID, 4, convMicroteachCase4All.DisciplineID);
clsCheckSql.CheckFieldLen(objvMicroteachCase4AllEN.DisciplineName, 50, convMicroteachCase4All.DisciplineName);
clsCheckSql.CheckFieldLen(objvMicroteachCase4AllEN.IdSenateGaugeVersion, 4, convMicroteachCase4All.IdSenateGaugeVersion);
clsCheckSql.CheckFieldLen(objvMicroteachCase4AllEN.senateGaugeVersionID, 4, convMicroteachCase4All.senateGaugeVersionID);
clsCheckSql.CheckFieldLen(objvMicroteachCase4AllEN.senateGaugeVersionName, 200, convMicroteachCase4All.senateGaugeVersionName);
clsCheckSql.CheckFieldLen(objvMicroteachCase4AllEN.IdTeachSkill, 8, convMicroteachCase4All.IdTeachSkill);
clsCheckSql.CheckFieldLen(objvMicroteachCase4AllEN.TeachSkillID, 8, convMicroteachCase4All.TeachSkillID);
clsCheckSql.CheckFieldLen(objvMicroteachCase4AllEN.SkillTypeName, 50, convMicroteachCase4All.SkillTypeName);
clsCheckSql.CheckFieldLen(objvMicroteachCase4AllEN.TeachSkillName, 50, convMicroteachCase4All.TeachSkillName);
clsCheckSql.CheckFieldLen(objvMicroteachCase4AllEN.TeachSkillTheory, 8000, convMicroteachCase4All.TeachSkillTheory);
clsCheckSql.CheckFieldLen(objvMicroteachCase4AllEN.TeachSkillOperMethod, 2000, convMicroteachCase4All.TeachSkillOperMethod);
clsCheckSql.CheckFieldLen(objvMicroteachCase4AllEN.IdSkillType, 4, convMicroteachCase4All.IdSkillType);
clsCheckSql.CheckFieldLen(objvMicroteachCase4AllEN.SkillTypeID, 4, convMicroteachCase4All.SkillTypeID);
clsCheckSql.CheckFieldLen(objvMicroteachCase4AllEN.CaseLevelId, 2, convMicroteachCase4All.CaseLevelId);
clsCheckSql.CheckFieldLen(objvMicroteachCase4AllEN.CaseLevelName, 30, convMicroteachCase4All.CaseLevelName);
clsCheckSql.CheckFieldLen(objvMicroteachCase4AllEN.DocFile, 200, convMicroteachCase4All.DocFile);
clsCheckSql.CheckFieldLen(objvMicroteachCase4AllEN.WordCreateDate, 14, convMicroteachCase4All.WordCreateDate);
clsCheckSql.CheckFieldLen(objvMicroteachCase4AllEN.microteachCaseText, 8000, convMicroteachCase4All.microteachCaseText);
clsCheckSql.CheckFieldLen(objvMicroteachCase4AllEN.OwnerId, 20, convMicroteachCase4All.OwnerId);
clsCheckSql.CheckFieldLen(objvMicroteachCase4AllEN.OwnerName, 30, convMicroteachCase4All.OwnerName);
clsCheckSql.CheckFieldLen(objvMicroteachCase4AllEN.CollegeId, 4, convMicroteachCase4All.CollegeId);
clsCheckSql.CheckFieldLen(objvMicroteachCase4AllEN.CollegeName, 100, convMicroteachCase4All.CollegeName);
clsCheckSql.CheckFieldLen(objvMicroteachCase4AllEN.OwnerNameWithId, 51, convMicroteachCase4All.OwnerNameWithId);
clsCheckSql.CheckFieldLen(objvMicroteachCase4AllEN.IdXzCollege, 4, convMicroteachCase4All.IdXzCollege);
clsCheckSql.CheckFieldLen(objvMicroteachCase4AllEN.UserKindId, 2, convMicroteachCase4All.UserKindId);
clsCheckSql.CheckFieldLen(objvMicroteachCase4AllEN.UserKindName, 30, convMicroteachCase4All.UserKindName);
clsCheckSql.CheckFieldLen(objvMicroteachCase4AllEN.UserTypeId, 2, convMicroteachCase4All.UserTypeId);
clsCheckSql.CheckFieldLen(objvMicroteachCase4AllEN.UserTypeName, 20, convMicroteachCase4All.UserTypeName);
clsCheckSql.CheckFieldLen(objvMicroteachCase4AllEN.RecommendedDegreeId, 2, convMicroteachCase4All.RecommendedDegreeId);
clsCheckSql.CheckFieldLen(objvMicroteachCase4AllEN.RecommendedDegreeName, 30, convMicroteachCase4All.RecommendedDegreeName);
clsCheckSql.CheckFieldLen(objvMicroteachCase4AllEN.Memo, 1000, convMicroteachCase4All.Memo);
clsCheckSql.CheckFieldLen(objvMicroteachCase4AllEN.IsHaveVideo, 6, convMicroteachCase4All.IsHaveVideo);
clsCheckSql.CheckFieldLen(objvMicroteachCase4AllEN.CollegeNameA, 12, convMicroteachCase4All.CollegeNameA);
clsCheckSql.CheckFieldLen(objvMicroteachCase4AllEN.ftpFileType, 30, convMicroteachCase4All.ftpFileType);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase4AllEN.IdMicroteachCase, convMicroteachCase4All.IdMicroteachCase);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase4AllEN.MicroteachCaseTypeName, convMicroteachCase4All.MicroteachCaseTypeName);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase4AllEN.MicroteachCaseID, convMicroteachCase4All.MicroteachCaseID);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase4AllEN.MicroteachCaseName, convMicroteachCase4All.MicroteachCaseName);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase4AllEN.MicroteachCaseTheme, convMicroteachCase4All.MicroteachCaseTheme);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase4AllEN.MicroteachCaseDate, convMicroteachCase4All.MicroteachCaseDate);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase4AllEN.MicroteachCaseTime, convMicroteachCase4All.MicroteachCaseTime);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase4AllEN.MicroteachCaseDateIn, convMicroteachCase4All.MicroteachCaseDateIn);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase4AllEN.IdStudyLevel, convMicroteachCase4All.IdStudyLevel);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase4AllEN.StudyLevelName, convMicroteachCase4All.StudyLevelName);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase4AllEN.IdTeachingPlan, convMicroteachCase4All.IdTeachingPlan);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase4AllEN.MicroTeachCaseTimeIn, convMicroteachCase4All.MicroTeachCaseTimeIn);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase4AllEN.IdMicroteachCaseType, convMicroteachCase4All.IdMicroteachCaseType);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase4AllEN.IdCaseType, convMicroteachCase4All.IdCaseType);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase4AllEN.IdDiscipline, convMicroteachCase4All.IdDiscipline);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase4AllEN.DisciplineID, convMicroteachCase4All.DisciplineID);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase4AllEN.DisciplineName, convMicroteachCase4All.DisciplineName);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase4AllEN.IdSenateGaugeVersion, convMicroteachCase4All.IdSenateGaugeVersion);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase4AllEN.senateGaugeVersionID, convMicroteachCase4All.senateGaugeVersionID);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase4AllEN.senateGaugeVersionName, convMicroteachCase4All.senateGaugeVersionName);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase4AllEN.IdTeachSkill, convMicroteachCase4All.IdTeachSkill);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase4AllEN.TeachSkillID, convMicroteachCase4All.TeachSkillID);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase4AllEN.SkillTypeName, convMicroteachCase4All.SkillTypeName);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase4AllEN.TeachSkillName, convMicroteachCase4All.TeachSkillName);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase4AllEN.TeachSkillTheory, convMicroteachCase4All.TeachSkillTheory);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase4AllEN.TeachSkillOperMethod, convMicroteachCase4All.TeachSkillOperMethod);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase4AllEN.IdSkillType, convMicroteachCase4All.IdSkillType);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase4AllEN.SkillTypeID, convMicroteachCase4All.SkillTypeID);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase4AllEN.CaseLevelId, convMicroteachCase4All.CaseLevelId);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase4AllEN.CaseLevelName, convMicroteachCase4All.CaseLevelName);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase4AllEN.DocFile, convMicroteachCase4All.DocFile);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase4AllEN.WordCreateDate, convMicroteachCase4All.WordCreateDate);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase4AllEN.microteachCaseText, convMicroteachCase4All.microteachCaseText);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase4AllEN.OwnerId, convMicroteachCase4All.OwnerId);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase4AllEN.OwnerName, convMicroteachCase4All.OwnerName);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase4AllEN.CollegeId, convMicroteachCase4All.CollegeId);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase4AllEN.CollegeName, convMicroteachCase4All.CollegeName);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase4AllEN.OwnerNameWithId, convMicroteachCase4All.OwnerNameWithId);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase4AllEN.IdXzCollege, convMicroteachCase4All.IdXzCollege);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase4AllEN.UserKindId, convMicroteachCase4All.UserKindId);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase4AllEN.UserKindName, convMicroteachCase4All.UserKindName);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase4AllEN.UserTypeId, convMicroteachCase4All.UserTypeId);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase4AllEN.UserTypeName, convMicroteachCase4All.UserTypeName);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase4AllEN.RecommendedDegreeId, convMicroteachCase4All.RecommendedDegreeId);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase4AllEN.RecommendedDegreeName, convMicroteachCase4All.RecommendedDegreeName);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase4AllEN.Memo, convMicroteachCase4All.Memo);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase4AllEN.IsHaveVideo, convMicroteachCase4All.IsHaveVideo);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase4AllEN.CollegeNameA, convMicroteachCase4All.CollegeNameA);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase4AllEN.ftpFileType, convMicroteachCase4All.ftpFileType);
//检查外键字段长度
 objvMicroteachCase4AllEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 /// <summary>
 /// 获取用于绑定下拉框的DataTable,获取两个字段:1、关键字；2、名称字段
 /// (AutoGCLib.clsGeneCodeBase:Gen_4DAL_GetDataTable4DdlBind)
 /// </summary>
 /// <returns>返回用于绑定下拉框的DataTable</returns>
public System.Data.DataTable GetIdMicroteachCase()
{
//获取某学院所有专业信息
string strSQL = "select IdMicroteachCase, MicroteachCaseName from vMicroteachCase4All ";
 clsSpecSQLforSql mySql = clsvMicroteachCase4AllDA.GetSpecSQLObj();
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
 objSQL = clsvMicroteachCase4AllDA.GetSpecSQLObj();
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
 objSQL = clsvMicroteachCase4AllDA.GetSpecSQLObj();
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
 objSQL = clsvMicroteachCase4AllDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvMicroteachCase4AllEN._CurrTabName);
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
 objSQL = clsvMicroteachCase4AllDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvMicroteachCase4AllEN._CurrTabName, strCondition);
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
 objSQL = clsvMicroteachCase4AllDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}