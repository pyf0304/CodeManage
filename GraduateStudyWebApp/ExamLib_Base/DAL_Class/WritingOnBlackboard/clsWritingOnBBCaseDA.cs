
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsWritingOnBBCaseDA
 表名:WritingOnBBCase(01120467)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:21:46
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:板书点播(WritingOnBlackboard)
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
 /// 板书教学案例(WritingOnBBCase)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsWritingOnBBCaseDA : clsCommBase4DA
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
 return clsWritingOnBBCaseEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsWritingOnBBCaseEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsWritingOnBBCaseEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsWritingOnBBCaseEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsWritingOnBBCaseEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strIdWritingOnBBCase">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strIdWritingOnBBCase)
{
strIdWritingOnBBCase = strIdWritingOnBBCase.Replace("'", "''");
if (strIdWritingOnBBCase.Length > 8)
{
throw new Exception("(errid:Data000001)在表:WritingOnBBCase中,检查关键字,长度不正确!(clsWritingOnBBCaseDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strIdWritingOnBBCase)  ==  true)
{
throw new Exception("(errid:Data000002)在表:WritingOnBBCase中,关键字不能为空 或 null!(clsWritingOnBBCaseDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strIdWritingOnBBCase);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsWritingOnBBCaseDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsWritingOnBBCaseDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsWritingOnBBCaseDA.GetSpecSQLObj();
strSQL = "Select * from WritingOnBBCase where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_WritingOnBBCase(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsWritingOnBBCaseDA: GetDataTable_WritingOnBBCase)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsWritingOnBBCaseDA.GetSpecSQLObj();
strSQL = "Select * from WritingOnBBCase where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsWritingOnBBCaseDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsWritingOnBBCaseDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsWritingOnBBCaseDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsWritingOnBBCaseDA.GetSpecSQLObj();
strSQL = "Select * from WritingOnBBCase where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsWritingOnBBCaseDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsWritingOnBBCaseDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsWritingOnBBCaseDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsWritingOnBBCaseDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from WritingOnBBCase where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from WritingOnBBCase where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsWritingOnBBCaseDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsWritingOnBBCaseDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from WritingOnBBCase where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsWritingOnBBCaseDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsWritingOnBBCaseDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} WritingOnBBCase.* from WritingOnBBCase Left Join {1} on {2} where {3} and WritingOnBBCase.IdWritingOnBBCase not in (Select top {5} WritingOnBBCase.IdWritingOnBBCase from WritingOnBBCase Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from WritingOnBBCase where {1} and IdWritingOnBBCase not in (Select top {2} IdWritingOnBBCase from WritingOnBBCase where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from WritingOnBBCase where {1} and IdWritingOnBBCase not in (Select top {3} IdWritingOnBBCase from WritingOnBBCase where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsWritingOnBBCaseDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsWritingOnBBCaseDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} WritingOnBBCase.* from WritingOnBBCase Left Join {1} on {2} where {3} and WritingOnBBCase.IdWritingOnBBCase not in (Select top {5} WritingOnBBCase.IdWritingOnBBCase from WritingOnBBCase Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from WritingOnBBCase where {1} and IdWritingOnBBCase not in (Select top {2} IdWritingOnBBCase from WritingOnBBCase where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from WritingOnBBCase where {1} and IdWritingOnBBCase not in (Select top {3} IdWritingOnBBCase from WritingOnBBCase where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsWritingOnBBCaseEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsWritingOnBBCaseDA:GetObjLst)", objException.Message));
}
List<clsWritingOnBBCaseEN> arrObjLst = new List<clsWritingOnBBCaseEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsWritingOnBBCaseDA.GetSpecSQLObj();
strSQL = "Select * from WritingOnBBCase where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsWritingOnBBCaseEN objWritingOnBBCaseEN = new clsWritingOnBBCaseEN();
try
{
objWritingOnBBCaseEN.IdWritingOnBBCase = objRow[conWritingOnBBCase.IdWritingOnBBCase].ToString().Trim(); //板书案例流水号
objWritingOnBBCaseEN.WritingOnBBCaseID = objRow[conWritingOnBBCase.WritingOnBBCaseID].ToString().Trim(); //板书教学案例ID
objWritingOnBBCaseEN.WritingOnBBCaseName = objRow[conWritingOnBBCase.WritingOnBBCaseName].ToString().Trim(); //板书教学案例名称
objWritingOnBBCaseEN.WritingOnBBCaseTheme = objRow[conWritingOnBBCase.WritingOnBBCaseTheme] == DBNull.Value ? null : objRow[conWritingOnBBCase.WritingOnBBCaseTheme].ToString().Trim(); //板书教学案例主题词
objWritingOnBBCaseEN.IdDiscipline = objRow[conWritingOnBBCase.IdDiscipline].ToString().Trim(); //学科流水号
objWritingOnBBCaseEN.WritingOnBBCaseDate = objRow[conWritingOnBBCase.WritingOnBBCaseDate] == DBNull.Value ? null : objRow[conWritingOnBBCase.WritingOnBBCaseDate].ToString().Trim(); //板书教学日期
objWritingOnBBCaseEN.WritingOnBBCaseTime = objRow[conWritingOnBBCase.WritingOnBBCaseTime] == DBNull.Value ? null : objRow[conWritingOnBBCase.WritingOnBBCaseTime].ToString().Trim(); //板书教学时间
objWritingOnBBCaseEN.WritingOnBBCaseDateIn = objRow[conWritingOnBBCase.WritingOnBBCaseDateIn] == DBNull.Value ? null : objRow[conWritingOnBBCase.WritingOnBBCaseDateIn].ToString().Trim(); //案例入库日期
objWritingOnBBCaseEN.WritingOnBBCaseTimeIn = objRow[conWritingOnBBCase.WritingOnBBCaseTimeIn] == DBNull.Value ? null : objRow[conWritingOnBBCase.WritingOnBBCaseTimeIn].ToString().Trim(); //案例入库时间
objWritingOnBBCaseEN.BrowseCount = objRow[conWritingOnBBCase.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conWritingOnBBCase.BrowseCount].ToString().Trim()); //浏览次数
objWritingOnBBCaseEN.IdStudyLevel = objRow[conWritingOnBBCase.IdStudyLevel].ToString().Trim(); //学段流水号
objWritingOnBBCaseEN.IsNeedGeneWord = TransNullToBool(objRow[conWritingOnBBCase.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objWritingOnBBCaseEN.WordCreateDate = objRow[conWritingOnBBCase.WordCreateDate] == DBNull.Value ? null : objRow[conWritingOnBBCase.WordCreateDate].ToString().Trim(); //Word生成日期
objWritingOnBBCaseEN.DocFile = objRow[conWritingOnBBCase.DocFile] == DBNull.Value ? null : objRow[conWritingOnBBCase.DocFile].ToString().Trim(); //生成的Word文件名
objWritingOnBBCaseEN.CaseLevelId = objRow[conWritingOnBBCase.CaseLevelId] == DBNull.Value ? null : objRow[conWritingOnBBCase.CaseLevelId].ToString().Trim(); //课例等级Id
objWritingOnBBCaseEN.IdSenateGaugeVersion = objRow[conWritingOnBBCase.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objWritingOnBBCaseEN.IsVisible = TransNullToBool(objRow[conWritingOnBBCase.IsVisible].ToString().Trim()); //是否显示
objWritingOnBBCaseEN.OwnerId = objRow[conWritingOnBBCase.OwnerId].ToString().Trim(); //拥有者Id
objWritingOnBBCaseEN.IsDualVideo = TransNullToBool(objRow[conWritingOnBBCase.IsDualVideo].ToString().Trim()); //是否双视频
objWritingOnBBCaseEN.IdWritingOnBBCaseType = objRow[conWritingOnBBCase.IdWritingOnBBCaseType] == DBNull.Value ? null : objRow[conWritingOnBBCase.IdWritingOnBBCaseType].ToString().Trim(); //板书案例类型流水号
objWritingOnBBCaseEN.UserTypeId = objRow[conWritingOnBBCase.UserTypeId] == DBNull.Value ? null : objRow[conWritingOnBBCase.UserTypeId].ToString().Trim(); //用户类型Id
objWritingOnBBCaseEN.RecommendedDegreeId = objRow[conWritingOnBBCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objWritingOnBBCaseEN.ftpFileType = objRow[conWritingOnBBCase.ftpFileType] == DBNull.Value ? null : objRow[conWritingOnBBCase.ftpFileType].ToString().Trim(); //ftp文件类型
objWritingOnBBCaseEN.VideoUrl = objRow[conWritingOnBBCase.VideoUrl] == DBNull.Value ? null : objRow[conWritingOnBBCase.VideoUrl].ToString().Trim(); //视频Url
objWritingOnBBCaseEN.VideoPath = objRow[conWritingOnBBCase.VideoPath] == DBNull.Value ? null : objRow[conWritingOnBBCase.VideoPath].ToString().Trim(); //视频目录
objWritingOnBBCaseEN.ResErrMsg = objRow[conWritingOnBBCase.ResErrMsg] == DBNull.Value ? null : objRow[conWritingOnBBCase.ResErrMsg].ToString().Trim(); //资源错误信息
objWritingOnBBCaseEN.UpdUserId = objRow[conWritingOnBBCase.UpdUserId] == DBNull.Value ? null : objRow[conWritingOnBBCase.UpdUserId].ToString().Trim(); //修改用户Id
objWritingOnBBCaseEN.UpdDate = objRow[conWritingOnBBCase.UpdDate] == DBNull.Value ? null : objRow[conWritingOnBBCase.UpdDate].ToString().Trim(); //修改日期
objWritingOnBBCaseEN.Memo = objRow[conWritingOnBBCase.Memo] == DBNull.Value ? null : objRow[conWritingOnBBCase.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsWritingOnBBCaseDA: GetObjLst)", objException.Message));
}
objWritingOnBBCaseEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objWritingOnBBCaseEN);
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
public List<clsWritingOnBBCaseEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsWritingOnBBCaseDA:GetObjLstByTabName)", objException.Message));
}
List<clsWritingOnBBCaseEN> arrObjLst = new List<clsWritingOnBBCaseEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsWritingOnBBCaseDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsWritingOnBBCaseEN objWritingOnBBCaseEN = new clsWritingOnBBCaseEN();
try
{
objWritingOnBBCaseEN.IdWritingOnBBCase = objRow[conWritingOnBBCase.IdWritingOnBBCase].ToString().Trim(); //板书案例流水号
objWritingOnBBCaseEN.WritingOnBBCaseID = objRow[conWritingOnBBCase.WritingOnBBCaseID].ToString().Trim(); //板书教学案例ID
objWritingOnBBCaseEN.WritingOnBBCaseName = objRow[conWritingOnBBCase.WritingOnBBCaseName].ToString().Trim(); //板书教学案例名称
objWritingOnBBCaseEN.WritingOnBBCaseTheme = objRow[conWritingOnBBCase.WritingOnBBCaseTheme] == DBNull.Value ? null : objRow[conWritingOnBBCase.WritingOnBBCaseTheme].ToString().Trim(); //板书教学案例主题词
objWritingOnBBCaseEN.IdDiscipline = objRow[conWritingOnBBCase.IdDiscipline].ToString().Trim(); //学科流水号
objWritingOnBBCaseEN.WritingOnBBCaseDate = objRow[conWritingOnBBCase.WritingOnBBCaseDate] == DBNull.Value ? null : objRow[conWritingOnBBCase.WritingOnBBCaseDate].ToString().Trim(); //板书教学日期
objWritingOnBBCaseEN.WritingOnBBCaseTime = objRow[conWritingOnBBCase.WritingOnBBCaseTime] == DBNull.Value ? null : objRow[conWritingOnBBCase.WritingOnBBCaseTime].ToString().Trim(); //板书教学时间
objWritingOnBBCaseEN.WritingOnBBCaseDateIn = objRow[conWritingOnBBCase.WritingOnBBCaseDateIn] == DBNull.Value ? null : objRow[conWritingOnBBCase.WritingOnBBCaseDateIn].ToString().Trim(); //案例入库日期
objWritingOnBBCaseEN.WritingOnBBCaseTimeIn = objRow[conWritingOnBBCase.WritingOnBBCaseTimeIn] == DBNull.Value ? null : objRow[conWritingOnBBCase.WritingOnBBCaseTimeIn].ToString().Trim(); //案例入库时间
objWritingOnBBCaseEN.BrowseCount = objRow[conWritingOnBBCase.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conWritingOnBBCase.BrowseCount].ToString().Trim()); //浏览次数
objWritingOnBBCaseEN.IdStudyLevel = objRow[conWritingOnBBCase.IdStudyLevel].ToString().Trim(); //学段流水号
objWritingOnBBCaseEN.IsNeedGeneWord = TransNullToBool(objRow[conWritingOnBBCase.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objWritingOnBBCaseEN.WordCreateDate = objRow[conWritingOnBBCase.WordCreateDate] == DBNull.Value ? null : objRow[conWritingOnBBCase.WordCreateDate].ToString().Trim(); //Word生成日期
objWritingOnBBCaseEN.DocFile = objRow[conWritingOnBBCase.DocFile] == DBNull.Value ? null : objRow[conWritingOnBBCase.DocFile].ToString().Trim(); //生成的Word文件名
objWritingOnBBCaseEN.CaseLevelId = objRow[conWritingOnBBCase.CaseLevelId] == DBNull.Value ? null : objRow[conWritingOnBBCase.CaseLevelId].ToString().Trim(); //课例等级Id
objWritingOnBBCaseEN.IdSenateGaugeVersion = objRow[conWritingOnBBCase.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objWritingOnBBCaseEN.IsVisible = TransNullToBool(objRow[conWritingOnBBCase.IsVisible].ToString().Trim()); //是否显示
objWritingOnBBCaseEN.OwnerId = objRow[conWritingOnBBCase.OwnerId].ToString().Trim(); //拥有者Id
objWritingOnBBCaseEN.IsDualVideo = TransNullToBool(objRow[conWritingOnBBCase.IsDualVideo].ToString().Trim()); //是否双视频
objWritingOnBBCaseEN.IdWritingOnBBCaseType = objRow[conWritingOnBBCase.IdWritingOnBBCaseType] == DBNull.Value ? null : objRow[conWritingOnBBCase.IdWritingOnBBCaseType].ToString().Trim(); //板书案例类型流水号
objWritingOnBBCaseEN.UserTypeId = objRow[conWritingOnBBCase.UserTypeId] == DBNull.Value ? null : objRow[conWritingOnBBCase.UserTypeId].ToString().Trim(); //用户类型Id
objWritingOnBBCaseEN.RecommendedDegreeId = objRow[conWritingOnBBCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objWritingOnBBCaseEN.ftpFileType = objRow[conWritingOnBBCase.ftpFileType] == DBNull.Value ? null : objRow[conWritingOnBBCase.ftpFileType].ToString().Trim(); //ftp文件类型
objWritingOnBBCaseEN.VideoUrl = objRow[conWritingOnBBCase.VideoUrl] == DBNull.Value ? null : objRow[conWritingOnBBCase.VideoUrl].ToString().Trim(); //视频Url
objWritingOnBBCaseEN.VideoPath = objRow[conWritingOnBBCase.VideoPath] == DBNull.Value ? null : objRow[conWritingOnBBCase.VideoPath].ToString().Trim(); //视频目录
objWritingOnBBCaseEN.ResErrMsg = objRow[conWritingOnBBCase.ResErrMsg] == DBNull.Value ? null : objRow[conWritingOnBBCase.ResErrMsg].ToString().Trim(); //资源错误信息
objWritingOnBBCaseEN.UpdUserId = objRow[conWritingOnBBCase.UpdUserId] == DBNull.Value ? null : objRow[conWritingOnBBCase.UpdUserId].ToString().Trim(); //修改用户Id
objWritingOnBBCaseEN.UpdDate = objRow[conWritingOnBBCase.UpdDate] == DBNull.Value ? null : objRow[conWritingOnBBCase.UpdDate].ToString().Trim(); //修改日期
objWritingOnBBCaseEN.Memo = objRow[conWritingOnBBCase.Memo] == DBNull.Value ? null : objRow[conWritingOnBBCase.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsWritingOnBBCaseDA: GetObjLst)", objException.Message));
}
objWritingOnBBCaseEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objWritingOnBBCaseEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objWritingOnBBCaseEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetWritingOnBBCase(ref clsWritingOnBBCaseEN objWritingOnBBCaseEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsWritingOnBBCaseDA.GetSpecSQLObj();
strSQL = "Select * from WritingOnBBCase where IdWritingOnBBCase = " + "'"+ objWritingOnBBCaseEN.IdWritingOnBBCase+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objWritingOnBBCaseEN.IdWritingOnBBCase = objDT.Rows[0][conWritingOnBBCase.IdWritingOnBBCase].ToString().Trim(); //板书案例流水号(字段类型:char,字段长度:8,是否可空:False)
 objWritingOnBBCaseEN.WritingOnBBCaseID = objDT.Rows[0][conWritingOnBBCase.WritingOnBBCaseID].ToString().Trim(); //板书教学案例ID(字段类型:char,字段长度:8,是否可空:False)
 objWritingOnBBCaseEN.WritingOnBBCaseName = objDT.Rows[0][conWritingOnBBCase.WritingOnBBCaseName].ToString().Trim(); //板书教学案例名称(字段类型:varchar,字段长度:100,是否可空:False)
 objWritingOnBBCaseEN.WritingOnBBCaseTheme = objDT.Rows[0][conWritingOnBBCase.WritingOnBBCaseTheme].ToString().Trim(); //板书教学案例主题词(字段类型:varchar,字段长度:200,是否可空:True)
 objWritingOnBBCaseEN.IdDiscipline = objDT.Rows[0][conWritingOnBBCase.IdDiscipline].ToString().Trim(); //学科流水号(字段类型:char,字段长度:4,是否可空:False)
 objWritingOnBBCaseEN.WritingOnBBCaseDate = objDT.Rows[0][conWritingOnBBCase.WritingOnBBCaseDate].ToString().Trim(); //板书教学日期(字段类型:char,字段长度:8,是否可空:True)
 objWritingOnBBCaseEN.WritingOnBBCaseTime = objDT.Rows[0][conWritingOnBBCase.WritingOnBBCaseTime].ToString().Trim(); //板书教学时间(字段类型:char,字段长度:6,是否可空:True)
 objWritingOnBBCaseEN.WritingOnBBCaseDateIn = objDT.Rows[0][conWritingOnBBCase.WritingOnBBCaseDateIn].ToString().Trim(); //案例入库日期(字段类型:char,字段长度:8,是否可空:True)
 objWritingOnBBCaseEN.WritingOnBBCaseTimeIn = objDT.Rows[0][conWritingOnBBCase.WritingOnBBCaseTimeIn].ToString().Trim(); //案例入库时间(字段类型:char,字段长度:6,是否可空:True)
 objWritingOnBBCaseEN.BrowseCount = TransNullToInt(objDT.Rows[0][conWritingOnBBCase.BrowseCount].ToString().Trim()); //浏览次数(字段类型:int,字段长度:4,是否可空:True)
 objWritingOnBBCaseEN.IdStudyLevel = objDT.Rows[0][conWritingOnBBCase.IdStudyLevel].ToString().Trim(); //学段流水号(字段类型:char,字段长度:4,是否可空:True)
 objWritingOnBBCaseEN.IsNeedGeneWord = TransNullToBool(objDT.Rows[0][conWritingOnBBCase.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word(字段类型:bit,字段长度:1,是否可空:True)
 objWritingOnBBCaseEN.WordCreateDate = objDT.Rows[0][conWritingOnBBCase.WordCreateDate].ToString().Trim(); //Word生成日期(字段类型:varchar,字段长度:14,是否可空:True)
 objWritingOnBBCaseEN.DocFile = objDT.Rows[0][conWritingOnBBCase.DocFile].ToString().Trim(); //生成的Word文件名(字段类型:varchar,字段长度:200,是否可空:True)
 objWritingOnBBCaseEN.CaseLevelId = objDT.Rows[0][conWritingOnBBCase.CaseLevelId].ToString().Trim(); //课例等级Id(字段类型:char,字段长度:2,是否可空:True)
 objWritingOnBBCaseEN.IdSenateGaugeVersion = objDT.Rows[0][conWritingOnBBCase.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号(字段类型:char,字段长度:4,是否可空:False)
 objWritingOnBBCaseEN.IsVisible = TransNullToBool(objDT.Rows[0][conWritingOnBBCase.IsVisible].ToString().Trim()); //是否显示(字段类型:bit,字段长度:1,是否可空:True)
 objWritingOnBBCaseEN.OwnerId = objDT.Rows[0][conWritingOnBBCase.OwnerId].ToString().Trim(); //拥有者Id(字段类型:varchar,字段长度:20,是否可空:False)
 objWritingOnBBCaseEN.IsDualVideo = TransNullToBool(objDT.Rows[0][conWritingOnBBCase.IsDualVideo].ToString().Trim()); //是否双视频(字段类型:bit,字段长度:1,是否可空:False)
 objWritingOnBBCaseEN.IdWritingOnBBCaseType = objDT.Rows[0][conWritingOnBBCase.IdWritingOnBBCaseType].ToString().Trim(); //板书案例类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objWritingOnBBCaseEN.UserTypeId = objDT.Rows[0][conWritingOnBBCase.UserTypeId].ToString().Trim(); //用户类型Id(字段类型:char,字段长度:2,是否可空:True)
 objWritingOnBBCaseEN.RecommendedDegreeId = objDT.Rows[0][conWritingOnBBCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id(字段类型:char,字段长度:2,是否可空:False)
 objWritingOnBBCaseEN.ftpFileType = objDT.Rows[0][conWritingOnBBCase.ftpFileType].ToString().Trim(); //ftp文件类型(字段类型:varchar,字段长度:30,是否可空:True)
 objWritingOnBBCaseEN.VideoUrl = objDT.Rows[0][conWritingOnBBCase.VideoUrl].ToString().Trim(); //视频Url(字段类型:varchar,字段长度:1000,是否可空:True)
 objWritingOnBBCaseEN.VideoPath = objDT.Rows[0][conWritingOnBBCase.VideoPath].ToString().Trim(); //视频目录(字段类型:varchar,字段长度:1000,是否可空:True)
 objWritingOnBBCaseEN.ResErrMsg = objDT.Rows[0][conWritingOnBBCase.ResErrMsg].ToString().Trim(); //资源错误信息(字段类型:varchar,字段长度:30,是否可空:True)
 objWritingOnBBCaseEN.UpdUserId = objDT.Rows[0][conWritingOnBBCase.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:True)
 objWritingOnBBCaseEN.UpdDate = objDT.Rows[0][conWritingOnBBCase.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objWritingOnBBCaseEN.Memo = objDT.Rows[0][conWritingOnBBCase.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsWritingOnBBCaseDA: GetWritingOnBBCase)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strIdWritingOnBBCase">表关键字</param>
 /// <returns>表对象</returns>
public clsWritingOnBBCaseEN GetObjByIdWritingOnBBCase(string strIdWritingOnBBCase)
{
CheckPrimaryKey(strIdWritingOnBBCase);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsWritingOnBBCaseDA.GetSpecSQLObj();
strSQL = "Select * from WritingOnBBCase where IdWritingOnBBCase = " + "'"+ strIdWritingOnBBCase+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsWritingOnBBCaseEN objWritingOnBBCaseEN = new clsWritingOnBBCaseEN();
try
{
 objWritingOnBBCaseEN.IdWritingOnBBCase = objRow[conWritingOnBBCase.IdWritingOnBBCase].ToString().Trim(); //板书案例流水号(字段类型:char,字段长度:8,是否可空:False)
 objWritingOnBBCaseEN.WritingOnBBCaseID = objRow[conWritingOnBBCase.WritingOnBBCaseID].ToString().Trim(); //板书教学案例ID(字段类型:char,字段长度:8,是否可空:False)
 objWritingOnBBCaseEN.WritingOnBBCaseName = objRow[conWritingOnBBCase.WritingOnBBCaseName].ToString().Trim(); //板书教学案例名称(字段类型:varchar,字段长度:100,是否可空:False)
 objWritingOnBBCaseEN.WritingOnBBCaseTheme = objRow[conWritingOnBBCase.WritingOnBBCaseTheme] == DBNull.Value ? null : objRow[conWritingOnBBCase.WritingOnBBCaseTheme].ToString().Trim(); //板书教学案例主题词(字段类型:varchar,字段长度:200,是否可空:True)
 objWritingOnBBCaseEN.IdDiscipline = objRow[conWritingOnBBCase.IdDiscipline].ToString().Trim(); //学科流水号(字段类型:char,字段长度:4,是否可空:False)
 objWritingOnBBCaseEN.WritingOnBBCaseDate = objRow[conWritingOnBBCase.WritingOnBBCaseDate] == DBNull.Value ? null : objRow[conWritingOnBBCase.WritingOnBBCaseDate].ToString().Trim(); //板书教学日期(字段类型:char,字段长度:8,是否可空:True)
 objWritingOnBBCaseEN.WritingOnBBCaseTime = objRow[conWritingOnBBCase.WritingOnBBCaseTime] == DBNull.Value ? null : objRow[conWritingOnBBCase.WritingOnBBCaseTime].ToString().Trim(); //板书教学时间(字段类型:char,字段长度:6,是否可空:True)
 objWritingOnBBCaseEN.WritingOnBBCaseDateIn = objRow[conWritingOnBBCase.WritingOnBBCaseDateIn] == DBNull.Value ? null : objRow[conWritingOnBBCase.WritingOnBBCaseDateIn].ToString().Trim(); //案例入库日期(字段类型:char,字段长度:8,是否可空:True)
 objWritingOnBBCaseEN.WritingOnBBCaseTimeIn = objRow[conWritingOnBBCase.WritingOnBBCaseTimeIn] == DBNull.Value ? null : objRow[conWritingOnBBCase.WritingOnBBCaseTimeIn].ToString().Trim(); //案例入库时间(字段类型:char,字段长度:6,是否可空:True)
 objWritingOnBBCaseEN.BrowseCount = objRow[conWritingOnBBCase.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conWritingOnBBCase.BrowseCount].ToString().Trim()); //浏览次数(字段类型:int,字段长度:4,是否可空:True)
 objWritingOnBBCaseEN.IdStudyLevel = objRow[conWritingOnBBCase.IdStudyLevel].ToString().Trim(); //学段流水号(字段类型:char,字段长度:4,是否可空:True)
 objWritingOnBBCaseEN.IsNeedGeneWord = clsEntityBase2.TransNullToBool_S(objRow[conWritingOnBBCase.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word(字段类型:bit,字段长度:1,是否可空:True)
 objWritingOnBBCaseEN.WordCreateDate = objRow[conWritingOnBBCase.WordCreateDate] == DBNull.Value ? null : objRow[conWritingOnBBCase.WordCreateDate].ToString().Trim(); //Word生成日期(字段类型:varchar,字段长度:14,是否可空:True)
 objWritingOnBBCaseEN.DocFile = objRow[conWritingOnBBCase.DocFile] == DBNull.Value ? null : objRow[conWritingOnBBCase.DocFile].ToString().Trim(); //生成的Word文件名(字段类型:varchar,字段长度:200,是否可空:True)
 objWritingOnBBCaseEN.CaseLevelId = objRow[conWritingOnBBCase.CaseLevelId] == DBNull.Value ? null : objRow[conWritingOnBBCase.CaseLevelId].ToString().Trim(); //课例等级Id(字段类型:char,字段长度:2,是否可空:True)
 objWritingOnBBCaseEN.IdSenateGaugeVersion = objRow[conWritingOnBBCase.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号(字段类型:char,字段长度:4,是否可空:False)
 objWritingOnBBCaseEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conWritingOnBBCase.IsVisible].ToString().Trim()); //是否显示(字段类型:bit,字段长度:1,是否可空:True)
 objWritingOnBBCaseEN.OwnerId = objRow[conWritingOnBBCase.OwnerId].ToString().Trim(); //拥有者Id(字段类型:varchar,字段长度:20,是否可空:False)
 objWritingOnBBCaseEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[conWritingOnBBCase.IsDualVideo].ToString().Trim()); //是否双视频(字段类型:bit,字段长度:1,是否可空:False)
 objWritingOnBBCaseEN.IdWritingOnBBCaseType = objRow[conWritingOnBBCase.IdWritingOnBBCaseType] == DBNull.Value ? null : objRow[conWritingOnBBCase.IdWritingOnBBCaseType].ToString().Trim(); //板书案例类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objWritingOnBBCaseEN.UserTypeId = objRow[conWritingOnBBCase.UserTypeId] == DBNull.Value ? null : objRow[conWritingOnBBCase.UserTypeId].ToString().Trim(); //用户类型Id(字段类型:char,字段长度:2,是否可空:True)
 objWritingOnBBCaseEN.RecommendedDegreeId = objRow[conWritingOnBBCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id(字段类型:char,字段长度:2,是否可空:False)
 objWritingOnBBCaseEN.ftpFileType = objRow[conWritingOnBBCase.ftpFileType] == DBNull.Value ? null : objRow[conWritingOnBBCase.ftpFileType].ToString().Trim(); //ftp文件类型(字段类型:varchar,字段长度:30,是否可空:True)
 objWritingOnBBCaseEN.VideoUrl = objRow[conWritingOnBBCase.VideoUrl] == DBNull.Value ? null : objRow[conWritingOnBBCase.VideoUrl].ToString().Trim(); //视频Url(字段类型:varchar,字段长度:1000,是否可空:True)
 objWritingOnBBCaseEN.VideoPath = objRow[conWritingOnBBCase.VideoPath] == DBNull.Value ? null : objRow[conWritingOnBBCase.VideoPath].ToString().Trim(); //视频目录(字段类型:varchar,字段长度:1000,是否可空:True)
 objWritingOnBBCaseEN.ResErrMsg = objRow[conWritingOnBBCase.ResErrMsg] == DBNull.Value ? null : objRow[conWritingOnBBCase.ResErrMsg].ToString().Trim(); //资源错误信息(字段类型:varchar,字段长度:30,是否可空:True)
 objWritingOnBBCaseEN.UpdUserId = objRow[conWritingOnBBCase.UpdUserId] == DBNull.Value ? null : objRow[conWritingOnBBCase.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:True)
 objWritingOnBBCaseEN.UpdDate = objRow[conWritingOnBBCase.UpdDate] == DBNull.Value ? null : objRow[conWritingOnBBCase.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objWritingOnBBCaseEN.Memo = objRow[conWritingOnBBCase.Memo] == DBNull.Value ? null : objRow[conWritingOnBBCase.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsWritingOnBBCaseDA: GetObjByIdWritingOnBBCase)", objException.Message));
}
return objWritingOnBBCaseEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsWritingOnBBCaseEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsWritingOnBBCaseDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsWritingOnBBCaseDA.GetSpecSQLObj();
strSQL = "Select * from WritingOnBBCase where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsWritingOnBBCaseEN objWritingOnBBCaseEN = new clsWritingOnBBCaseEN()
{
IdWritingOnBBCase = objRow[conWritingOnBBCase.IdWritingOnBBCase].ToString().Trim(), //板书案例流水号
WritingOnBBCaseID = objRow[conWritingOnBBCase.WritingOnBBCaseID].ToString().Trim(), //板书教学案例ID
WritingOnBBCaseName = objRow[conWritingOnBBCase.WritingOnBBCaseName].ToString().Trim(), //板书教学案例名称
WritingOnBBCaseTheme = objRow[conWritingOnBBCase.WritingOnBBCaseTheme] == DBNull.Value ? null : objRow[conWritingOnBBCase.WritingOnBBCaseTheme].ToString().Trim(), //板书教学案例主题词
IdDiscipline = objRow[conWritingOnBBCase.IdDiscipline].ToString().Trim(), //学科流水号
WritingOnBBCaseDate = objRow[conWritingOnBBCase.WritingOnBBCaseDate] == DBNull.Value ? null : objRow[conWritingOnBBCase.WritingOnBBCaseDate].ToString().Trim(), //板书教学日期
WritingOnBBCaseTime = objRow[conWritingOnBBCase.WritingOnBBCaseTime] == DBNull.Value ? null : objRow[conWritingOnBBCase.WritingOnBBCaseTime].ToString().Trim(), //板书教学时间
WritingOnBBCaseDateIn = objRow[conWritingOnBBCase.WritingOnBBCaseDateIn] == DBNull.Value ? null : objRow[conWritingOnBBCase.WritingOnBBCaseDateIn].ToString().Trim(), //案例入库日期
WritingOnBBCaseTimeIn = objRow[conWritingOnBBCase.WritingOnBBCaseTimeIn] == DBNull.Value ? null : objRow[conWritingOnBBCase.WritingOnBBCaseTimeIn].ToString().Trim(), //案例入库时间
BrowseCount = objRow[conWritingOnBBCase.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conWritingOnBBCase.BrowseCount].ToString().Trim()), //浏览次数
IdStudyLevel = objRow[conWritingOnBBCase.IdStudyLevel].ToString().Trim(), //学段流水号
IsNeedGeneWord = TransNullToBool(objRow[conWritingOnBBCase.IsNeedGeneWord].ToString().Trim()), //是否需要生成Word
WordCreateDate = objRow[conWritingOnBBCase.WordCreateDate] == DBNull.Value ? null : objRow[conWritingOnBBCase.WordCreateDate].ToString().Trim(), //Word生成日期
DocFile = objRow[conWritingOnBBCase.DocFile] == DBNull.Value ? null : objRow[conWritingOnBBCase.DocFile].ToString().Trim(), //生成的Word文件名
CaseLevelId = objRow[conWritingOnBBCase.CaseLevelId] == DBNull.Value ? null : objRow[conWritingOnBBCase.CaseLevelId].ToString().Trim(), //课例等级Id
IdSenateGaugeVersion = objRow[conWritingOnBBCase.IdSenateGaugeVersion].ToString().Trim(), //评价量表版本流水号
IsVisible = TransNullToBool(objRow[conWritingOnBBCase.IsVisible].ToString().Trim()), //是否显示
OwnerId = objRow[conWritingOnBBCase.OwnerId].ToString().Trim(), //拥有者Id
IsDualVideo = TransNullToBool(objRow[conWritingOnBBCase.IsDualVideo].ToString().Trim()), //是否双视频
IdWritingOnBBCaseType = objRow[conWritingOnBBCase.IdWritingOnBBCaseType] == DBNull.Value ? null : objRow[conWritingOnBBCase.IdWritingOnBBCaseType].ToString().Trim(), //板书案例类型流水号
UserTypeId = objRow[conWritingOnBBCase.UserTypeId] == DBNull.Value ? null : objRow[conWritingOnBBCase.UserTypeId].ToString().Trim(), //用户类型Id
RecommendedDegreeId = objRow[conWritingOnBBCase.RecommendedDegreeId].ToString().Trim(), //推荐度Id
ftpFileType = objRow[conWritingOnBBCase.ftpFileType] == DBNull.Value ? null : objRow[conWritingOnBBCase.ftpFileType].ToString().Trim(), //ftp文件类型
VideoUrl = objRow[conWritingOnBBCase.VideoUrl] == DBNull.Value ? null : objRow[conWritingOnBBCase.VideoUrl].ToString().Trim(), //视频Url
VideoPath = objRow[conWritingOnBBCase.VideoPath] == DBNull.Value ? null : objRow[conWritingOnBBCase.VideoPath].ToString().Trim(), //视频目录
ResErrMsg = objRow[conWritingOnBBCase.ResErrMsg] == DBNull.Value ? null : objRow[conWritingOnBBCase.ResErrMsg].ToString().Trim(), //资源错误信息
UpdUserId = objRow[conWritingOnBBCase.UpdUserId] == DBNull.Value ? null : objRow[conWritingOnBBCase.UpdUserId].ToString().Trim(), //修改用户Id
UpdDate = objRow[conWritingOnBBCase.UpdDate] == DBNull.Value ? null : objRow[conWritingOnBBCase.UpdDate].ToString().Trim(), //修改日期
Memo = objRow[conWritingOnBBCase.Memo] == DBNull.Value ? null : objRow[conWritingOnBBCase.Memo].ToString().Trim() //备注
};
objWritingOnBBCaseEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objWritingOnBBCaseEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsWritingOnBBCaseDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsWritingOnBBCaseEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsWritingOnBBCaseEN objWritingOnBBCaseEN = new clsWritingOnBBCaseEN();
try
{
objWritingOnBBCaseEN.IdWritingOnBBCase = objRow[conWritingOnBBCase.IdWritingOnBBCase].ToString().Trim(); //板书案例流水号
objWritingOnBBCaseEN.WritingOnBBCaseID = objRow[conWritingOnBBCase.WritingOnBBCaseID].ToString().Trim(); //板书教学案例ID
objWritingOnBBCaseEN.WritingOnBBCaseName = objRow[conWritingOnBBCase.WritingOnBBCaseName].ToString().Trim(); //板书教学案例名称
objWritingOnBBCaseEN.WritingOnBBCaseTheme = objRow[conWritingOnBBCase.WritingOnBBCaseTheme] == DBNull.Value ? null : objRow[conWritingOnBBCase.WritingOnBBCaseTheme].ToString().Trim(); //板书教学案例主题词
objWritingOnBBCaseEN.IdDiscipline = objRow[conWritingOnBBCase.IdDiscipline].ToString().Trim(); //学科流水号
objWritingOnBBCaseEN.WritingOnBBCaseDate = objRow[conWritingOnBBCase.WritingOnBBCaseDate] == DBNull.Value ? null : objRow[conWritingOnBBCase.WritingOnBBCaseDate].ToString().Trim(); //板书教学日期
objWritingOnBBCaseEN.WritingOnBBCaseTime = objRow[conWritingOnBBCase.WritingOnBBCaseTime] == DBNull.Value ? null : objRow[conWritingOnBBCase.WritingOnBBCaseTime].ToString().Trim(); //板书教学时间
objWritingOnBBCaseEN.WritingOnBBCaseDateIn = objRow[conWritingOnBBCase.WritingOnBBCaseDateIn] == DBNull.Value ? null : objRow[conWritingOnBBCase.WritingOnBBCaseDateIn].ToString().Trim(); //案例入库日期
objWritingOnBBCaseEN.WritingOnBBCaseTimeIn = objRow[conWritingOnBBCase.WritingOnBBCaseTimeIn] == DBNull.Value ? null : objRow[conWritingOnBBCase.WritingOnBBCaseTimeIn].ToString().Trim(); //案例入库时间
objWritingOnBBCaseEN.BrowseCount = objRow[conWritingOnBBCase.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conWritingOnBBCase.BrowseCount].ToString().Trim()); //浏览次数
objWritingOnBBCaseEN.IdStudyLevel = objRow[conWritingOnBBCase.IdStudyLevel].ToString().Trim(); //学段流水号
objWritingOnBBCaseEN.IsNeedGeneWord = TransNullToBool(objRow[conWritingOnBBCase.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objWritingOnBBCaseEN.WordCreateDate = objRow[conWritingOnBBCase.WordCreateDate] == DBNull.Value ? null : objRow[conWritingOnBBCase.WordCreateDate].ToString().Trim(); //Word生成日期
objWritingOnBBCaseEN.DocFile = objRow[conWritingOnBBCase.DocFile] == DBNull.Value ? null : objRow[conWritingOnBBCase.DocFile].ToString().Trim(); //生成的Word文件名
objWritingOnBBCaseEN.CaseLevelId = objRow[conWritingOnBBCase.CaseLevelId] == DBNull.Value ? null : objRow[conWritingOnBBCase.CaseLevelId].ToString().Trim(); //课例等级Id
objWritingOnBBCaseEN.IdSenateGaugeVersion = objRow[conWritingOnBBCase.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objWritingOnBBCaseEN.IsVisible = TransNullToBool(objRow[conWritingOnBBCase.IsVisible].ToString().Trim()); //是否显示
objWritingOnBBCaseEN.OwnerId = objRow[conWritingOnBBCase.OwnerId].ToString().Trim(); //拥有者Id
objWritingOnBBCaseEN.IsDualVideo = TransNullToBool(objRow[conWritingOnBBCase.IsDualVideo].ToString().Trim()); //是否双视频
objWritingOnBBCaseEN.IdWritingOnBBCaseType = objRow[conWritingOnBBCase.IdWritingOnBBCaseType] == DBNull.Value ? null : objRow[conWritingOnBBCase.IdWritingOnBBCaseType].ToString().Trim(); //板书案例类型流水号
objWritingOnBBCaseEN.UserTypeId = objRow[conWritingOnBBCase.UserTypeId] == DBNull.Value ? null : objRow[conWritingOnBBCase.UserTypeId].ToString().Trim(); //用户类型Id
objWritingOnBBCaseEN.RecommendedDegreeId = objRow[conWritingOnBBCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objWritingOnBBCaseEN.ftpFileType = objRow[conWritingOnBBCase.ftpFileType] == DBNull.Value ? null : objRow[conWritingOnBBCase.ftpFileType].ToString().Trim(); //ftp文件类型
objWritingOnBBCaseEN.VideoUrl = objRow[conWritingOnBBCase.VideoUrl] == DBNull.Value ? null : objRow[conWritingOnBBCase.VideoUrl].ToString().Trim(); //视频Url
objWritingOnBBCaseEN.VideoPath = objRow[conWritingOnBBCase.VideoPath] == DBNull.Value ? null : objRow[conWritingOnBBCase.VideoPath].ToString().Trim(); //视频目录
objWritingOnBBCaseEN.ResErrMsg = objRow[conWritingOnBBCase.ResErrMsg] == DBNull.Value ? null : objRow[conWritingOnBBCase.ResErrMsg].ToString().Trim(); //资源错误信息
objWritingOnBBCaseEN.UpdUserId = objRow[conWritingOnBBCase.UpdUserId] == DBNull.Value ? null : objRow[conWritingOnBBCase.UpdUserId].ToString().Trim(); //修改用户Id
objWritingOnBBCaseEN.UpdDate = objRow[conWritingOnBBCase.UpdDate] == DBNull.Value ? null : objRow[conWritingOnBBCase.UpdDate].ToString().Trim(); //修改日期
objWritingOnBBCaseEN.Memo = objRow[conWritingOnBBCase.Memo] == DBNull.Value ? null : objRow[conWritingOnBBCase.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsWritingOnBBCaseDA: GetObjByDataRowWritingOnBBCase)", objException.Message));
}
objWritingOnBBCaseEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objWritingOnBBCaseEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsWritingOnBBCaseEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsWritingOnBBCaseEN objWritingOnBBCaseEN = new clsWritingOnBBCaseEN();
try
{
objWritingOnBBCaseEN.IdWritingOnBBCase = objRow[conWritingOnBBCase.IdWritingOnBBCase].ToString().Trim(); //板书案例流水号
objWritingOnBBCaseEN.WritingOnBBCaseID = objRow[conWritingOnBBCase.WritingOnBBCaseID].ToString().Trim(); //板书教学案例ID
objWritingOnBBCaseEN.WritingOnBBCaseName = objRow[conWritingOnBBCase.WritingOnBBCaseName].ToString().Trim(); //板书教学案例名称
objWritingOnBBCaseEN.WritingOnBBCaseTheme = objRow[conWritingOnBBCase.WritingOnBBCaseTheme] == DBNull.Value ? null : objRow[conWritingOnBBCase.WritingOnBBCaseTheme].ToString().Trim(); //板书教学案例主题词
objWritingOnBBCaseEN.IdDiscipline = objRow[conWritingOnBBCase.IdDiscipline].ToString().Trim(); //学科流水号
objWritingOnBBCaseEN.WritingOnBBCaseDate = objRow[conWritingOnBBCase.WritingOnBBCaseDate] == DBNull.Value ? null : objRow[conWritingOnBBCase.WritingOnBBCaseDate].ToString().Trim(); //板书教学日期
objWritingOnBBCaseEN.WritingOnBBCaseTime = objRow[conWritingOnBBCase.WritingOnBBCaseTime] == DBNull.Value ? null : objRow[conWritingOnBBCase.WritingOnBBCaseTime].ToString().Trim(); //板书教学时间
objWritingOnBBCaseEN.WritingOnBBCaseDateIn = objRow[conWritingOnBBCase.WritingOnBBCaseDateIn] == DBNull.Value ? null : objRow[conWritingOnBBCase.WritingOnBBCaseDateIn].ToString().Trim(); //案例入库日期
objWritingOnBBCaseEN.WritingOnBBCaseTimeIn = objRow[conWritingOnBBCase.WritingOnBBCaseTimeIn] == DBNull.Value ? null : objRow[conWritingOnBBCase.WritingOnBBCaseTimeIn].ToString().Trim(); //案例入库时间
objWritingOnBBCaseEN.BrowseCount = objRow[conWritingOnBBCase.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conWritingOnBBCase.BrowseCount].ToString().Trim()); //浏览次数
objWritingOnBBCaseEN.IdStudyLevel = objRow[conWritingOnBBCase.IdStudyLevel].ToString().Trim(); //学段流水号
objWritingOnBBCaseEN.IsNeedGeneWord = TransNullToBool(objRow[conWritingOnBBCase.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objWritingOnBBCaseEN.WordCreateDate = objRow[conWritingOnBBCase.WordCreateDate] == DBNull.Value ? null : objRow[conWritingOnBBCase.WordCreateDate].ToString().Trim(); //Word生成日期
objWritingOnBBCaseEN.DocFile = objRow[conWritingOnBBCase.DocFile] == DBNull.Value ? null : objRow[conWritingOnBBCase.DocFile].ToString().Trim(); //生成的Word文件名
objWritingOnBBCaseEN.CaseLevelId = objRow[conWritingOnBBCase.CaseLevelId] == DBNull.Value ? null : objRow[conWritingOnBBCase.CaseLevelId].ToString().Trim(); //课例等级Id
objWritingOnBBCaseEN.IdSenateGaugeVersion = objRow[conWritingOnBBCase.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objWritingOnBBCaseEN.IsVisible = TransNullToBool(objRow[conWritingOnBBCase.IsVisible].ToString().Trim()); //是否显示
objWritingOnBBCaseEN.OwnerId = objRow[conWritingOnBBCase.OwnerId].ToString().Trim(); //拥有者Id
objWritingOnBBCaseEN.IsDualVideo = TransNullToBool(objRow[conWritingOnBBCase.IsDualVideo].ToString().Trim()); //是否双视频
objWritingOnBBCaseEN.IdWritingOnBBCaseType = objRow[conWritingOnBBCase.IdWritingOnBBCaseType] == DBNull.Value ? null : objRow[conWritingOnBBCase.IdWritingOnBBCaseType].ToString().Trim(); //板书案例类型流水号
objWritingOnBBCaseEN.UserTypeId = objRow[conWritingOnBBCase.UserTypeId] == DBNull.Value ? null : objRow[conWritingOnBBCase.UserTypeId].ToString().Trim(); //用户类型Id
objWritingOnBBCaseEN.RecommendedDegreeId = objRow[conWritingOnBBCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objWritingOnBBCaseEN.ftpFileType = objRow[conWritingOnBBCase.ftpFileType] == DBNull.Value ? null : objRow[conWritingOnBBCase.ftpFileType].ToString().Trim(); //ftp文件类型
objWritingOnBBCaseEN.VideoUrl = objRow[conWritingOnBBCase.VideoUrl] == DBNull.Value ? null : objRow[conWritingOnBBCase.VideoUrl].ToString().Trim(); //视频Url
objWritingOnBBCaseEN.VideoPath = objRow[conWritingOnBBCase.VideoPath] == DBNull.Value ? null : objRow[conWritingOnBBCase.VideoPath].ToString().Trim(); //视频目录
objWritingOnBBCaseEN.ResErrMsg = objRow[conWritingOnBBCase.ResErrMsg] == DBNull.Value ? null : objRow[conWritingOnBBCase.ResErrMsg].ToString().Trim(); //资源错误信息
objWritingOnBBCaseEN.UpdUserId = objRow[conWritingOnBBCase.UpdUserId] == DBNull.Value ? null : objRow[conWritingOnBBCase.UpdUserId].ToString().Trim(); //修改用户Id
objWritingOnBBCaseEN.UpdDate = objRow[conWritingOnBBCase.UpdDate] == DBNull.Value ? null : objRow[conWritingOnBBCase.UpdDate].ToString().Trim(); //修改日期
objWritingOnBBCaseEN.Memo = objRow[conWritingOnBBCase.Memo] == DBNull.Value ? null : objRow[conWritingOnBBCase.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsWritingOnBBCaseDA: GetObjByDataRow)", objException.Message));
}
objWritingOnBBCaseEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objWritingOnBBCaseEN;
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
objSQL = clsWritingOnBBCaseDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsWritingOnBBCaseEN._CurrTabName, conWritingOnBBCase.IdWritingOnBBCase, 8, "");
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
objSQL = clsWritingOnBBCaseDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsWritingOnBBCaseEN._CurrTabName, conWritingOnBBCase.IdWritingOnBBCase, 8, strPrefix);
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
 objSQL = clsWritingOnBBCaseDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select IdWritingOnBBCase from WritingOnBBCase where " + strCondition;
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
 objSQL = clsWritingOnBBCaseDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select IdWritingOnBBCase from WritingOnBBCase where " + strCondition;
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
 /// <param name = "strIdWritingOnBBCase">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strIdWritingOnBBCase)
{
CheckPrimaryKey(strIdWritingOnBBCase);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsWritingOnBBCaseDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("WritingOnBBCase", "IdWritingOnBBCase = " + "'"+ strIdWritingOnBBCase+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsWritingOnBBCaseDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsWritingOnBBCaseDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("WritingOnBBCase", strCondition))
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
objSQL = clsWritingOnBBCaseDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("WritingOnBBCase");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsWritingOnBBCaseEN objWritingOnBBCaseEN)
 {
 objWritingOnBBCaseEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objWritingOnBBCaseEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objWritingOnBBCaseEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsWritingOnBBCaseDA.GetSpecSQLObj();
strSQL = "Select * from WritingOnBBCase where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "WritingOnBBCase");
objRow = objDS.Tables["WritingOnBBCase"].NewRow();
objRow[conWritingOnBBCase.IdWritingOnBBCase] = objWritingOnBBCaseEN.IdWritingOnBBCase; //板书案例流水号
objRow[conWritingOnBBCase.WritingOnBBCaseID] = objWritingOnBBCaseEN.WritingOnBBCaseID; //板书教学案例ID
objRow[conWritingOnBBCase.WritingOnBBCaseName] = objWritingOnBBCaseEN.WritingOnBBCaseName; //板书教学案例名称
 if (objWritingOnBBCaseEN.WritingOnBBCaseTheme !=  "")
 {
objRow[conWritingOnBBCase.WritingOnBBCaseTheme] = objWritingOnBBCaseEN.WritingOnBBCaseTheme; //板书教学案例主题词
 }
objRow[conWritingOnBBCase.IdDiscipline] = objWritingOnBBCaseEN.IdDiscipline; //学科流水号
 if (objWritingOnBBCaseEN.WritingOnBBCaseDate !=  "")
 {
objRow[conWritingOnBBCase.WritingOnBBCaseDate] = objWritingOnBBCaseEN.WritingOnBBCaseDate; //板书教学日期
 }
 if (objWritingOnBBCaseEN.WritingOnBBCaseTime !=  "")
 {
objRow[conWritingOnBBCase.WritingOnBBCaseTime] = objWritingOnBBCaseEN.WritingOnBBCaseTime; //板书教学时间
 }
 if (objWritingOnBBCaseEN.WritingOnBBCaseDateIn !=  "")
 {
objRow[conWritingOnBBCase.WritingOnBBCaseDateIn] = objWritingOnBBCaseEN.WritingOnBBCaseDateIn; //案例入库日期
 }
 if (objWritingOnBBCaseEN.WritingOnBBCaseTimeIn !=  "")
 {
objRow[conWritingOnBBCase.WritingOnBBCaseTimeIn] = objWritingOnBBCaseEN.WritingOnBBCaseTimeIn; //案例入库时间
 }
objRow[conWritingOnBBCase.BrowseCount] = objWritingOnBBCaseEN.BrowseCount; //浏览次数
objRow[conWritingOnBBCase.IdStudyLevel] = objWritingOnBBCaseEN.IdStudyLevel; //学段流水号
objRow[conWritingOnBBCase.IsNeedGeneWord] = objWritingOnBBCaseEN.IsNeedGeneWord; //是否需要生成Word
 if (objWritingOnBBCaseEN.WordCreateDate !=  "")
 {
objRow[conWritingOnBBCase.WordCreateDate] = objWritingOnBBCaseEN.WordCreateDate; //Word生成日期
 }
 if (objWritingOnBBCaseEN.DocFile !=  "")
 {
objRow[conWritingOnBBCase.DocFile] = objWritingOnBBCaseEN.DocFile; //生成的Word文件名
 }
 if (objWritingOnBBCaseEN.CaseLevelId !=  "")
 {
objRow[conWritingOnBBCase.CaseLevelId] = objWritingOnBBCaseEN.CaseLevelId; //课例等级Id
 }
objRow[conWritingOnBBCase.IdSenateGaugeVersion] = objWritingOnBBCaseEN.IdSenateGaugeVersion; //评价量表版本流水号
objRow[conWritingOnBBCase.IsVisible] = objWritingOnBBCaseEN.IsVisible; //是否显示
objRow[conWritingOnBBCase.OwnerId] = objWritingOnBBCaseEN.OwnerId; //拥有者Id
objRow[conWritingOnBBCase.IsDualVideo] = objWritingOnBBCaseEN.IsDualVideo; //是否双视频
 if (objWritingOnBBCaseEN.IdWritingOnBBCaseType !=  "")
 {
objRow[conWritingOnBBCase.IdWritingOnBBCaseType] = objWritingOnBBCaseEN.IdWritingOnBBCaseType; //板书案例类型流水号
 }
 if (objWritingOnBBCaseEN.UserTypeId !=  "")
 {
objRow[conWritingOnBBCase.UserTypeId] = objWritingOnBBCaseEN.UserTypeId; //用户类型Id
 }
objRow[conWritingOnBBCase.RecommendedDegreeId] = objWritingOnBBCaseEN.RecommendedDegreeId; //推荐度Id
 if (objWritingOnBBCaseEN.ftpFileType !=  "")
 {
objRow[conWritingOnBBCase.ftpFileType] = objWritingOnBBCaseEN.ftpFileType; //ftp文件类型
 }
 if (objWritingOnBBCaseEN.VideoUrl !=  "")
 {
objRow[conWritingOnBBCase.VideoUrl] = objWritingOnBBCaseEN.VideoUrl; //视频Url
 }
 if (objWritingOnBBCaseEN.VideoPath !=  "")
 {
objRow[conWritingOnBBCase.VideoPath] = objWritingOnBBCaseEN.VideoPath; //视频目录
 }
 if (objWritingOnBBCaseEN.ResErrMsg !=  "")
 {
objRow[conWritingOnBBCase.ResErrMsg] = objWritingOnBBCaseEN.ResErrMsg; //资源错误信息
 }
 if (objWritingOnBBCaseEN.UpdUserId !=  "")
 {
objRow[conWritingOnBBCase.UpdUserId] = objWritingOnBBCaseEN.UpdUserId; //修改用户Id
 }
 if (objWritingOnBBCaseEN.UpdDate !=  "")
 {
objRow[conWritingOnBBCase.UpdDate] = objWritingOnBBCaseEN.UpdDate; //修改日期
 }
 if (objWritingOnBBCaseEN.Memo !=  "")
 {
objRow[conWritingOnBBCase.Memo] = objWritingOnBBCaseEN.Memo; //备注
 }
objDS.Tables[clsWritingOnBBCaseEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsWritingOnBBCaseEN._CurrTabName);
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
 /// <param name = "objWritingOnBBCaseEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsWritingOnBBCaseEN objWritingOnBBCaseEN)
{
 objWritingOnBBCaseEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objWritingOnBBCaseEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objWritingOnBBCaseEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objWritingOnBBCaseEN.IdWritingOnBBCase !=  null)
 {
 arrFieldListForInsert.Add(conWritingOnBBCase.IdWritingOnBBCase);
 var strIdWritingOnBBCase = objWritingOnBBCaseEN.IdWritingOnBBCase.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdWritingOnBBCase + "'");
 }
 
 if (objWritingOnBBCaseEN.WritingOnBBCaseID !=  null)
 {
 arrFieldListForInsert.Add(conWritingOnBBCase.WritingOnBBCaseID);
 var strWritingOnBBCaseID = objWritingOnBBCaseEN.WritingOnBBCaseID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strWritingOnBBCaseID + "'");
 }
 
 if (objWritingOnBBCaseEN.WritingOnBBCaseName !=  null)
 {
 arrFieldListForInsert.Add(conWritingOnBBCase.WritingOnBBCaseName);
 var strWritingOnBBCaseName = objWritingOnBBCaseEN.WritingOnBBCaseName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strWritingOnBBCaseName + "'");
 }
 
 if (objWritingOnBBCaseEN.WritingOnBBCaseTheme !=  null)
 {
 arrFieldListForInsert.Add(conWritingOnBBCase.WritingOnBBCaseTheme);
 var strWritingOnBBCaseTheme = objWritingOnBBCaseEN.WritingOnBBCaseTheme.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strWritingOnBBCaseTheme + "'");
 }
 
 if (objWritingOnBBCaseEN.IdDiscipline !=  null)
 {
 arrFieldListForInsert.Add(conWritingOnBBCase.IdDiscipline);
 var strIdDiscipline = objWritingOnBBCaseEN.IdDiscipline.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdDiscipline + "'");
 }
 
 if (objWritingOnBBCaseEN.WritingOnBBCaseDate !=  null)
 {
 arrFieldListForInsert.Add(conWritingOnBBCase.WritingOnBBCaseDate);
 var strWritingOnBBCaseDate = objWritingOnBBCaseEN.WritingOnBBCaseDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strWritingOnBBCaseDate + "'");
 }
 
 if (objWritingOnBBCaseEN.WritingOnBBCaseTime !=  null)
 {
 arrFieldListForInsert.Add(conWritingOnBBCase.WritingOnBBCaseTime);
 var strWritingOnBBCaseTime = objWritingOnBBCaseEN.WritingOnBBCaseTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strWritingOnBBCaseTime + "'");
 }
 
 if (objWritingOnBBCaseEN.WritingOnBBCaseDateIn !=  null)
 {
 arrFieldListForInsert.Add(conWritingOnBBCase.WritingOnBBCaseDateIn);
 var strWritingOnBBCaseDateIn = objWritingOnBBCaseEN.WritingOnBBCaseDateIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strWritingOnBBCaseDateIn + "'");
 }
 
 if (objWritingOnBBCaseEN.WritingOnBBCaseTimeIn !=  null)
 {
 arrFieldListForInsert.Add(conWritingOnBBCase.WritingOnBBCaseTimeIn);
 var strWritingOnBBCaseTimeIn = objWritingOnBBCaseEN.WritingOnBBCaseTimeIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strWritingOnBBCaseTimeIn + "'");
 }
 
 if (objWritingOnBBCaseEN.BrowseCount !=  null)
 {
 arrFieldListForInsert.Add(conWritingOnBBCase.BrowseCount);
 arrValueListForInsert.Add(objWritingOnBBCaseEN.BrowseCount.ToString());
 }
 
 if (objWritingOnBBCaseEN.IdStudyLevel !=  null)
 {
 arrFieldListForInsert.Add(conWritingOnBBCase.IdStudyLevel);
 var strIdStudyLevel = objWritingOnBBCaseEN.IdStudyLevel.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdStudyLevel + "'");
 }
 
 arrFieldListForInsert.Add(conWritingOnBBCase.IsNeedGeneWord);
 arrValueListForInsert.Add("'" + (objWritingOnBBCaseEN.IsNeedGeneWord  ==  false ? "0" : "1") + "'");
 
 if (objWritingOnBBCaseEN.WordCreateDate !=  null)
 {
 arrFieldListForInsert.Add(conWritingOnBBCase.WordCreateDate);
 var strWordCreateDate = objWritingOnBBCaseEN.WordCreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strWordCreateDate + "'");
 }
 
 if (objWritingOnBBCaseEN.DocFile !=  null)
 {
 arrFieldListForInsert.Add(conWritingOnBBCase.DocFile);
 var strDocFile = objWritingOnBBCaseEN.DocFile.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDocFile + "'");
 }
 
 if (objWritingOnBBCaseEN.CaseLevelId !=  null)
 {
 arrFieldListForInsert.Add(conWritingOnBBCase.CaseLevelId);
 var strCaseLevelId = objWritingOnBBCaseEN.CaseLevelId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCaseLevelId + "'");
 }
 
 if (objWritingOnBBCaseEN.IdSenateGaugeVersion !=  null)
 {
 arrFieldListForInsert.Add(conWritingOnBBCase.IdSenateGaugeVersion);
 var strIdSenateGaugeVersion = objWritingOnBBCaseEN.IdSenateGaugeVersion.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdSenateGaugeVersion + "'");
 }
 
 arrFieldListForInsert.Add(conWritingOnBBCase.IsVisible);
 arrValueListForInsert.Add("'" + (objWritingOnBBCaseEN.IsVisible  ==  false ? "0" : "1") + "'");
 
 if (objWritingOnBBCaseEN.OwnerId !=  null)
 {
 arrFieldListForInsert.Add(conWritingOnBBCase.OwnerId);
 var strOwnerId = objWritingOnBBCaseEN.OwnerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strOwnerId + "'");
 }
 
 arrFieldListForInsert.Add(conWritingOnBBCase.IsDualVideo);
 arrValueListForInsert.Add("'" + (objWritingOnBBCaseEN.IsDualVideo  ==  false ? "0" : "1") + "'");
 
 if (objWritingOnBBCaseEN.IdWritingOnBBCaseType !=  null)
 {
 arrFieldListForInsert.Add(conWritingOnBBCase.IdWritingOnBBCaseType);
 var strIdWritingOnBBCaseType = objWritingOnBBCaseEN.IdWritingOnBBCaseType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdWritingOnBBCaseType + "'");
 }
 
 if (objWritingOnBBCaseEN.UserTypeId !=  null)
 {
 arrFieldListForInsert.Add(conWritingOnBBCase.UserTypeId);
 var strUserTypeId = objWritingOnBBCaseEN.UserTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserTypeId + "'");
 }
 
 if (objWritingOnBBCaseEN.RecommendedDegreeId !=  null)
 {
 arrFieldListForInsert.Add(conWritingOnBBCase.RecommendedDegreeId);
 var strRecommendedDegreeId = objWritingOnBBCaseEN.RecommendedDegreeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRecommendedDegreeId + "'");
 }
 
 if (objWritingOnBBCaseEN.ftpFileType !=  null)
 {
 arrFieldListForInsert.Add(conWritingOnBBCase.ftpFileType);
 var strftpFileType = objWritingOnBBCaseEN.ftpFileType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strftpFileType + "'");
 }
 
 if (objWritingOnBBCaseEN.VideoUrl !=  null)
 {
 arrFieldListForInsert.Add(conWritingOnBBCase.VideoUrl);
 var strVideoUrl = objWritingOnBBCaseEN.VideoUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVideoUrl + "'");
 }
 
 if (objWritingOnBBCaseEN.VideoPath !=  null)
 {
 arrFieldListForInsert.Add(conWritingOnBBCase.VideoPath);
 var strVideoPath = objWritingOnBBCaseEN.VideoPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVideoPath + "'");
 }
 
 if (objWritingOnBBCaseEN.ResErrMsg !=  null)
 {
 arrFieldListForInsert.Add(conWritingOnBBCase.ResErrMsg);
 var strResErrMsg = objWritingOnBBCaseEN.ResErrMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strResErrMsg + "'");
 }
 
 if (objWritingOnBBCaseEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(conWritingOnBBCase.UpdUserId);
 var strUpdUserId = objWritingOnBBCaseEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objWritingOnBBCaseEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conWritingOnBBCase.UpdDate);
 var strUpdDate = objWritingOnBBCaseEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objWritingOnBBCaseEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conWritingOnBBCase.Memo);
 var strMemo = objWritingOnBBCaseEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into WritingOnBBCase");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsWritingOnBBCaseDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objWritingOnBBCaseEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsWritingOnBBCaseEN objWritingOnBBCaseEN)
{
 objWritingOnBBCaseEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objWritingOnBBCaseEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objWritingOnBBCaseEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objWritingOnBBCaseEN.IdWritingOnBBCase !=  null)
 {
 arrFieldListForInsert.Add(conWritingOnBBCase.IdWritingOnBBCase);
 var strIdWritingOnBBCase = objWritingOnBBCaseEN.IdWritingOnBBCase.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdWritingOnBBCase + "'");
 }
 
 if (objWritingOnBBCaseEN.WritingOnBBCaseID !=  null)
 {
 arrFieldListForInsert.Add(conWritingOnBBCase.WritingOnBBCaseID);
 var strWritingOnBBCaseID = objWritingOnBBCaseEN.WritingOnBBCaseID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strWritingOnBBCaseID + "'");
 }
 
 if (objWritingOnBBCaseEN.WritingOnBBCaseName !=  null)
 {
 arrFieldListForInsert.Add(conWritingOnBBCase.WritingOnBBCaseName);
 var strWritingOnBBCaseName = objWritingOnBBCaseEN.WritingOnBBCaseName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strWritingOnBBCaseName + "'");
 }
 
 if (objWritingOnBBCaseEN.WritingOnBBCaseTheme !=  null)
 {
 arrFieldListForInsert.Add(conWritingOnBBCase.WritingOnBBCaseTheme);
 var strWritingOnBBCaseTheme = objWritingOnBBCaseEN.WritingOnBBCaseTheme.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strWritingOnBBCaseTheme + "'");
 }
 
 if (objWritingOnBBCaseEN.IdDiscipline !=  null)
 {
 arrFieldListForInsert.Add(conWritingOnBBCase.IdDiscipline);
 var strIdDiscipline = objWritingOnBBCaseEN.IdDiscipline.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdDiscipline + "'");
 }
 
 if (objWritingOnBBCaseEN.WritingOnBBCaseDate !=  null)
 {
 arrFieldListForInsert.Add(conWritingOnBBCase.WritingOnBBCaseDate);
 var strWritingOnBBCaseDate = objWritingOnBBCaseEN.WritingOnBBCaseDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strWritingOnBBCaseDate + "'");
 }
 
 if (objWritingOnBBCaseEN.WritingOnBBCaseTime !=  null)
 {
 arrFieldListForInsert.Add(conWritingOnBBCase.WritingOnBBCaseTime);
 var strWritingOnBBCaseTime = objWritingOnBBCaseEN.WritingOnBBCaseTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strWritingOnBBCaseTime + "'");
 }
 
 if (objWritingOnBBCaseEN.WritingOnBBCaseDateIn !=  null)
 {
 arrFieldListForInsert.Add(conWritingOnBBCase.WritingOnBBCaseDateIn);
 var strWritingOnBBCaseDateIn = objWritingOnBBCaseEN.WritingOnBBCaseDateIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strWritingOnBBCaseDateIn + "'");
 }
 
 if (objWritingOnBBCaseEN.WritingOnBBCaseTimeIn !=  null)
 {
 arrFieldListForInsert.Add(conWritingOnBBCase.WritingOnBBCaseTimeIn);
 var strWritingOnBBCaseTimeIn = objWritingOnBBCaseEN.WritingOnBBCaseTimeIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strWritingOnBBCaseTimeIn + "'");
 }
 
 if (objWritingOnBBCaseEN.BrowseCount !=  null)
 {
 arrFieldListForInsert.Add(conWritingOnBBCase.BrowseCount);
 arrValueListForInsert.Add(objWritingOnBBCaseEN.BrowseCount.ToString());
 }
 
 if (objWritingOnBBCaseEN.IdStudyLevel !=  null)
 {
 arrFieldListForInsert.Add(conWritingOnBBCase.IdStudyLevel);
 var strIdStudyLevel = objWritingOnBBCaseEN.IdStudyLevel.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdStudyLevel + "'");
 }
 
 arrFieldListForInsert.Add(conWritingOnBBCase.IsNeedGeneWord);
 arrValueListForInsert.Add("'" + (objWritingOnBBCaseEN.IsNeedGeneWord  ==  false ? "0" : "1") + "'");
 
 if (objWritingOnBBCaseEN.WordCreateDate !=  null)
 {
 arrFieldListForInsert.Add(conWritingOnBBCase.WordCreateDate);
 var strWordCreateDate = objWritingOnBBCaseEN.WordCreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strWordCreateDate + "'");
 }
 
 if (objWritingOnBBCaseEN.DocFile !=  null)
 {
 arrFieldListForInsert.Add(conWritingOnBBCase.DocFile);
 var strDocFile = objWritingOnBBCaseEN.DocFile.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDocFile + "'");
 }
 
 if (objWritingOnBBCaseEN.CaseLevelId !=  null)
 {
 arrFieldListForInsert.Add(conWritingOnBBCase.CaseLevelId);
 var strCaseLevelId = objWritingOnBBCaseEN.CaseLevelId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCaseLevelId + "'");
 }
 
 if (objWritingOnBBCaseEN.IdSenateGaugeVersion !=  null)
 {
 arrFieldListForInsert.Add(conWritingOnBBCase.IdSenateGaugeVersion);
 var strIdSenateGaugeVersion = objWritingOnBBCaseEN.IdSenateGaugeVersion.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdSenateGaugeVersion + "'");
 }
 
 arrFieldListForInsert.Add(conWritingOnBBCase.IsVisible);
 arrValueListForInsert.Add("'" + (objWritingOnBBCaseEN.IsVisible  ==  false ? "0" : "1") + "'");
 
 if (objWritingOnBBCaseEN.OwnerId !=  null)
 {
 arrFieldListForInsert.Add(conWritingOnBBCase.OwnerId);
 var strOwnerId = objWritingOnBBCaseEN.OwnerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strOwnerId + "'");
 }
 
 arrFieldListForInsert.Add(conWritingOnBBCase.IsDualVideo);
 arrValueListForInsert.Add("'" + (objWritingOnBBCaseEN.IsDualVideo  ==  false ? "0" : "1") + "'");
 
 if (objWritingOnBBCaseEN.IdWritingOnBBCaseType !=  null)
 {
 arrFieldListForInsert.Add(conWritingOnBBCase.IdWritingOnBBCaseType);
 var strIdWritingOnBBCaseType = objWritingOnBBCaseEN.IdWritingOnBBCaseType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdWritingOnBBCaseType + "'");
 }
 
 if (objWritingOnBBCaseEN.UserTypeId !=  null)
 {
 arrFieldListForInsert.Add(conWritingOnBBCase.UserTypeId);
 var strUserTypeId = objWritingOnBBCaseEN.UserTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserTypeId + "'");
 }
 
 if (objWritingOnBBCaseEN.RecommendedDegreeId !=  null)
 {
 arrFieldListForInsert.Add(conWritingOnBBCase.RecommendedDegreeId);
 var strRecommendedDegreeId = objWritingOnBBCaseEN.RecommendedDegreeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRecommendedDegreeId + "'");
 }
 
 if (objWritingOnBBCaseEN.ftpFileType !=  null)
 {
 arrFieldListForInsert.Add(conWritingOnBBCase.ftpFileType);
 var strftpFileType = objWritingOnBBCaseEN.ftpFileType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strftpFileType + "'");
 }
 
 if (objWritingOnBBCaseEN.VideoUrl !=  null)
 {
 arrFieldListForInsert.Add(conWritingOnBBCase.VideoUrl);
 var strVideoUrl = objWritingOnBBCaseEN.VideoUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVideoUrl + "'");
 }
 
 if (objWritingOnBBCaseEN.VideoPath !=  null)
 {
 arrFieldListForInsert.Add(conWritingOnBBCase.VideoPath);
 var strVideoPath = objWritingOnBBCaseEN.VideoPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVideoPath + "'");
 }
 
 if (objWritingOnBBCaseEN.ResErrMsg !=  null)
 {
 arrFieldListForInsert.Add(conWritingOnBBCase.ResErrMsg);
 var strResErrMsg = objWritingOnBBCaseEN.ResErrMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strResErrMsg + "'");
 }
 
 if (objWritingOnBBCaseEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(conWritingOnBBCase.UpdUserId);
 var strUpdUserId = objWritingOnBBCaseEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objWritingOnBBCaseEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conWritingOnBBCase.UpdDate);
 var strUpdDate = objWritingOnBBCaseEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objWritingOnBBCaseEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conWritingOnBBCase.Memo);
 var strMemo = objWritingOnBBCaseEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into WritingOnBBCase");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsWritingOnBBCaseDA.GetSpecSQLObj();
 objSQL.ExecSql(strSQL.ToString());
return objWritingOnBBCaseEN.IdWritingOnBBCase;
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objWritingOnBBCaseEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsWritingOnBBCaseEN objWritingOnBBCaseEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objWritingOnBBCaseEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objWritingOnBBCaseEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objWritingOnBBCaseEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objWritingOnBBCaseEN.IdWritingOnBBCase !=  null)
 {
 arrFieldListForInsert.Add(conWritingOnBBCase.IdWritingOnBBCase);
 var strIdWritingOnBBCase = objWritingOnBBCaseEN.IdWritingOnBBCase.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdWritingOnBBCase + "'");
 }
 
 if (objWritingOnBBCaseEN.WritingOnBBCaseID !=  null)
 {
 arrFieldListForInsert.Add(conWritingOnBBCase.WritingOnBBCaseID);
 var strWritingOnBBCaseID = objWritingOnBBCaseEN.WritingOnBBCaseID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strWritingOnBBCaseID + "'");
 }
 
 if (objWritingOnBBCaseEN.WritingOnBBCaseName !=  null)
 {
 arrFieldListForInsert.Add(conWritingOnBBCase.WritingOnBBCaseName);
 var strWritingOnBBCaseName = objWritingOnBBCaseEN.WritingOnBBCaseName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strWritingOnBBCaseName + "'");
 }
 
 if (objWritingOnBBCaseEN.WritingOnBBCaseTheme !=  null)
 {
 arrFieldListForInsert.Add(conWritingOnBBCase.WritingOnBBCaseTheme);
 var strWritingOnBBCaseTheme = objWritingOnBBCaseEN.WritingOnBBCaseTheme.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strWritingOnBBCaseTheme + "'");
 }
 
 if (objWritingOnBBCaseEN.IdDiscipline !=  null)
 {
 arrFieldListForInsert.Add(conWritingOnBBCase.IdDiscipline);
 var strIdDiscipline = objWritingOnBBCaseEN.IdDiscipline.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdDiscipline + "'");
 }
 
 if (objWritingOnBBCaseEN.WritingOnBBCaseDate !=  null)
 {
 arrFieldListForInsert.Add(conWritingOnBBCase.WritingOnBBCaseDate);
 var strWritingOnBBCaseDate = objWritingOnBBCaseEN.WritingOnBBCaseDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strWritingOnBBCaseDate + "'");
 }
 
 if (objWritingOnBBCaseEN.WritingOnBBCaseTime !=  null)
 {
 arrFieldListForInsert.Add(conWritingOnBBCase.WritingOnBBCaseTime);
 var strWritingOnBBCaseTime = objWritingOnBBCaseEN.WritingOnBBCaseTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strWritingOnBBCaseTime + "'");
 }
 
 if (objWritingOnBBCaseEN.WritingOnBBCaseDateIn !=  null)
 {
 arrFieldListForInsert.Add(conWritingOnBBCase.WritingOnBBCaseDateIn);
 var strWritingOnBBCaseDateIn = objWritingOnBBCaseEN.WritingOnBBCaseDateIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strWritingOnBBCaseDateIn + "'");
 }
 
 if (objWritingOnBBCaseEN.WritingOnBBCaseTimeIn !=  null)
 {
 arrFieldListForInsert.Add(conWritingOnBBCase.WritingOnBBCaseTimeIn);
 var strWritingOnBBCaseTimeIn = objWritingOnBBCaseEN.WritingOnBBCaseTimeIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strWritingOnBBCaseTimeIn + "'");
 }
 
 if (objWritingOnBBCaseEN.BrowseCount !=  null)
 {
 arrFieldListForInsert.Add(conWritingOnBBCase.BrowseCount);
 arrValueListForInsert.Add(objWritingOnBBCaseEN.BrowseCount.ToString());
 }
 
 if (objWritingOnBBCaseEN.IdStudyLevel !=  null)
 {
 arrFieldListForInsert.Add(conWritingOnBBCase.IdStudyLevel);
 var strIdStudyLevel = objWritingOnBBCaseEN.IdStudyLevel.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdStudyLevel + "'");
 }
 
 arrFieldListForInsert.Add(conWritingOnBBCase.IsNeedGeneWord);
 arrValueListForInsert.Add("'" + (objWritingOnBBCaseEN.IsNeedGeneWord  ==  false ? "0" : "1") + "'");
 
 if (objWritingOnBBCaseEN.WordCreateDate !=  null)
 {
 arrFieldListForInsert.Add(conWritingOnBBCase.WordCreateDate);
 var strWordCreateDate = objWritingOnBBCaseEN.WordCreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strWordCreateDate + "'");
 }
 
 if (objWritingOnBBCaseEN.DocFile !=  null)
 {
 arrFieldListForInsert.Add(conWritingOnBBCase.DocFile);
 var strDocFile = objWritingOnBBCaseEN.DocFile.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDocFile + "'");
 }
 
 if (objWritingOnBBCaseEN.CaseLevelId !=  null)
 {
 arrFieldListForInsert.Add(conWritingOnBBCase.CaseLevelId);
 var strCaseLevelId = objWritingOnBBCaseEN.CaseLevelId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCaseLevelId + "'");
 }
 
 if (objWritingOnBBCaseEN.IdSenateGaugeVersion !=  null)
 {
 arrFieldListForInsert.Add(conWritingOnBBCase.IdSenateGaugeVersion);
 var strIdSenateGaugeVersion = objWritingOnBBCaseEN.IdSenateGaugeVersion.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdSenateGaugeVersion + "'");
 }
 
 arrFieldListForInsert.Add(conWritingOnBBCase.IsVisible);
 arrValueListForInsert.Add("'" + (objWritingOnBBCaseEN.IsVisible  ==  false ? "0" : "1") + "'");
 
 if (objWritingOnBBCaseEN.OwnerId !=  null)
 {
 arrFieldListForInsert.Add(conWritingOnBBCase.OwnerId);
 var strOwnerId = objWritingOnBBCaseEN.OwnerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strOwnerId + "'");
 }
 
 arrFieldListForInsert.Add(conWritingOnBBCase.IsDualVideo);
 arrValueListForInsert.Add("'" + (objWritingOnBBCaseEN.IsDualVideo  ==  false ? "0" : "1") + "'");
 
 if (objWritingOnBBCaseEN.IdWritingOnBBCaseType !=  null)
 {
 arrFieldListForInsert.Add(conWritingOnBBCase.IdWritingOnBBCaseType);
 var strIdWritingOnBBCaseType = objWritingOnBBCaseEN.IdWritingOnBBCaseType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdWritingOnBBCaseType + "'");
 }
 
 if (objWritingOnBBCaseEN.UserTypeId !=  null)
 {
 arrFieldListForInsert.Add(conWritingOnBBCase.UserTypeId);
 var strUserTypeId = objWritingOnBBCaseEN.UserTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserTypeId + "'");
 }
 
 if (objWritingOnBBCaseEN.RecommendedDegreeId !=  null)
 {
 arrFieldListForInsert.Add(conWritingOnBBCase.RecommendedDegreeId);
 var strRecommendedDegreeId = objWritingOnBBCaseEN.RecommendedDegreeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRecommendedDegreeId + "'");
 }
 
 if (objWritingOnBBCaseEN.ftpFileType !=  null)
 {
 arrFieldListForInsert.Add(conWritingOnBBCase.ftpFileType);
 var strftpFileType = objWritingOnBBCaseEN.ftpFileType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strftpFileType + "'");
 }
 
 if (objWritingOnBBCaseEN.VideoUrl !=  null)
 {
 arrFieldListForInsert.Add(conWritingOnBBCase.VideoUrl);
 var strVideoUrl = objWritingOnBBCaseEN.VideoUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVideoUrl + "'");
 }
 
 if (objWritingOnBBCaseEN.VideoPath !=  null)
 {
 arrFieldListForInsert.Add(conWritingOnBBCase.VideoPath);
 var strVideoPath = objWritingOnBBCaseEN.VideoPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVideoPath + "'");
 }
 
 if (objWritingOnBBCaseEN.ResErrMsg !=  null)
 {
 arrFieldListForInsert.Add(conWritingOnBBCase.ResErrMsg);
 var strResErrMsg = objWritingOnBBCaseEN.ResErrMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strResErrMsg + "'");
 }
 
 if (objWritingOnBBCaseEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(conWritingOnBBCase.UpdUserId);
 var strUpdUserId = objWritingOnBBCaseEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objWritingOnBBCaseEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conWritingOnBBCase.UpdDate);
 var strUpdDate = objWritingOnBBCaseEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objWritingOnBBCaseEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conWritingOnBBCase.Memo);
 var strMemo = objWritingOnBBCaseEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into WritingOnBBCase");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsWritingOnBBCaseDA.GetSpecSQLObj();
    objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
return objWritingOnBBCaseEN.IdWritingOnBBCase;
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objWritingOnBBCaseEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsWritingOnBBCaseEN objWritingOnBBCaseEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objWritingOnBBCaseEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objWritingOnBBCaseEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objWritingOnBBCaseEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objWritingOnBBCaseEN.IdWritingOnBBCase !=  null)
 {
 arrFieldListForInsert.Add(conWritingOnBBCase.IdWritingOnBBCase);
 var strIdWritingOnBBCase = objWritingOnBBCaseEN.IdWritingOnBBCase.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdWritingOnBBCase + "'");
 }
 
 if (objWritingOnBBCaseEN.WritingOnBBCaseID !=  null)
 {
 arrFieldListForInsert.Add(conWritingOnBBCase.WritingOnBBCaseID);
 var strWritingOnBBCaseID = objWritingOnBBCaseEN.WritingOnBBCaseID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strWritingOnBBCaseID + "'");
 }
 
 if (objWritingOnBBCaseEN.WritingOnBBCaseName !=  null)
 {
 arrFieldListForInsert.Add(conWritingOnBBCase.WritingOnBBCaseName);
 var strWritingOnBBCaseName = objWritingOnBBCaseEN.WritingOnBBCaseName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strWritingOnBBCaseName + "'");
 }
 
 if (objWritingOnBBCaseEN.WritingOnBBCaseTheme !=  null)
 {
 arrFieldListForInsert.Add(conWritingOnBBCase.WritingOnBBCaseTheme);
 var strWritingOnBBCaseTheme = objWritingOnBBCaseEN.WritingOnBBCaseTheme.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strWritingOnBBCaseTheme + "'");
 }
 
 if (objWritingOnBBCaseEN.IdDiscipline !=  null)
 {
 arrFieldListForInsert.Add(conWritingOnBBCase.IdDiscipline);
 var strIdDiscipline = objWritingOnBBCaseEN.IdDiscipline.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdDiscipline + "'");
 }
 
 if (objWritingOnBBCaseEN.WritingOnBBCaseDate !=  null)
 {
 arrFieldListForInsert.Add(conWritingOnBBCase.WritingOnBBCaseDate);
 var strWritingOnBBCaseDate = objWritingOnBBCaseEN.WritingOnBBCaseDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strWritingOnBBCaseDate + "'");
 }
 
 if (objWritingOnBBCaseEN.WritingOnBBCaseTime !=  null)
 {
 arrFieldListForInsert.Add(conWritingOnBBCase.WritingOnBBCaseTime);
 var strWritingOnBBCaseTime = objWritingOnBBCaseEN.WritingOnBBCaseTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strWritingOnBBCaseTime + "'");
 }
 
 if (objWritingOnBBCaseEN.WritingOnBBCaseDateIn !=  null)
 {
 arrFieldListForInsert.Add(conWritingOnBBCase.WritingOnBBCaseDateIn);
 var strWritingOnBBCaseDateIn = objWritingOnBBCaseEN.WritingOnBBCaseDateIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strWritingOnBBCaseDateIn + "'");
 }
 
 if (objWritingOnBBCaseEN.WritingOnBBCaseTimeIn !=  null)
 {
 arrFieldListForInsert.Add(conWritingOnBBCase.WritingOnBBCaseTimeIn);
 var strWritingOnBBCaseTimeIn = objWritingOnBBCaseEN.WritingOnBBCaseTimeIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strWritingOnBBCaseTimeIn + "'");
 }
 
 if (objWritingOnBBCaseEN.BrowseCount !=  null)
 {
 arrFieldListForInsert.Add(conWritingOnBBCase.BrowseCount);
 arrValueListForInsert.Add(objWritingOnBBCaseEN.BrowseCount.ToString());
 }
 
 if (objWritingOnBBCaseEN.IdStudyLevel !=  null)
 {
 arrFieldListForInsert.Add(conWritingOnBBCase.IdStudyLevel);
 var strIdStudyLevel = objWritingOnBBCaseEN.IdStudyLevel.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdStudyLevel + "'");
 }
 
 arrFieldListForInsert.Add(conWritingOnBBCase.IsNeedGeneWord);
 arrValueListForInsert.Add("'" + (objWritingOnBBCaseEN.IsNeedGeneWord  ==  false ? "0" : "1") + "'");
 
 if (objWritingOnBBCaseEN.WordCreateDate !=  null)
 {
 arrFieldListForInsert.Add(conWritingOnBBCase.WordCreateDate);
 var strWordCreateDate = objWritingOnBBCaseEN.WordCreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strWordCreateDate + "'");
 }
 
 if (objWritingOnBBCaseEN.DocFile !=  null)
 {
 arrFieldListForInsert.Add(conWritingOnBBCase.DocFile);
 var strDocFile = objWritingOnBBCaseEN.DocFile.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDocFile + "'");
 }
 
 if (objWritingOnBBCaseEN.CaseLevelId !=  null)
 {
 arrFieldListForInsert.Add(conWritingOnBBCase.CaseLevelId);
 var strCaseLevelId = objWritingOnBBCaseEN.CaseLevelId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCaseLevelId + "'");
 }
 
 if (objWritingOnBBCaseEN.IdSenateGaugeVersion !=  null)
 {
 arrFieldListForInsert.Add(conWritingOnBBCase.IdSenateGaugeVersion);
 var strIdSenateGaugeVersion = objWritingOnBBCaseEN.IdSenateGaugeVersion.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdSenateGaugeVersion + "'");
 }
 
 arrFieldListForInsert.Add(conWritingOnBBCase.IsVisible);
 arrValueListForInsert.Add("'" + (objWritingOnBBCaseEN.IsVisible  ==  false ? "0" : "1") + "'");
 
 if (objWritingOnBBCaseEN.OwnerId !=  null)
 {
 arrFieldListForInsert.Add(conWritingOnBBCase.OwnerId);
 var strOwnerId = objWritingOnBBCaseEN.OwnerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strOwnerId + "'");
 }
 
 arrFieldListForInsert.Add(conWritingOnBBCase.IsDualVideo);
 arrValueListForInsert.Add("'" + (objWritingOnBBCaseEN.IsDualVideo  ==  false ? "0" : "1") + "'");
 
 if (objWritingOnBBCaseEN.IdWritingOnBBCaseType !=  null)
 {
 arrFieldListForInsert.Add(conWritingOnBBCase.IdWritingOnBBCaseType);
 var strIdWritingOnBBCaseType = objWritingOnBBCaseEN.IdWritingOnBBCaseType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdWritingOnBBCaseType + "'");
 }
 
 if (objWritingOnBBCaseEN.UserTypeId !=  null)
 {
 arrFieldListForInsert.Add(conWritingOnBBCase.UserTypeId);
 var strUserTypeId = objWritingOnBBCaseEN.UserTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserTypeId + "'");
 }
 
 if (objWritingOnBBCaseEN.RecommendedDegreeId !=  null)
 {
 arrFieldListForInsert.Add(conWritingOnBBCase.RecommendedDegreeId);
 var strRecommendedDegreeId = objWritingOnBBCaseEN.RecommendedDegreeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRecommendedDegreeId + "'");
 }
 
 if (objWritingOnBBCaseEN.ftpFileType !=  null)
 {
 arrFieldListForInsert.Add(conWritingOnBBCase.ftpFileType);
 var strftpFileType = objWritingOnBBCaseEN.ftpFileType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strftpFileType + "'");
 }
 
 if (objWritingOnBBCaseEN.VideoUrl !=  null)
 {
 arrFieldListForInsert.Add(conWritingOnBBCase.VideoUrl);
 var strVideoUrl = objWritingOnBBCaseEN.VideoUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVideoUrl + "'");
 }
 
 if (objWritingOnBBCaseEN.VideoPath !=  null)
 {
 arrFieldListForInsert.Add(conWritingOnBBCase.VideoPath);
 var strVideoPath = objWritingOnBBCaseEN.VideoPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVideoPath + "'");
 }
 
 if (objWritingOnBBCaseEN.ResErrMsg !=  null)
 {
 arrFieldListForInsert.Add(conWritingOnBBCase.ResErrMsg);
 var strResErrMsg = objWritingOnBBCaseEN.ResErrMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strResErrMsg + "'");
 }
 
 if (objWritingOnBBCaseEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(conWritingOnBBCase.UpdUserId);
 var strUpdUserId = objWritingOnBBCaseEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objWritingOnBBCaseEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conWritingOnBBCase.UpdDate);
 var strUpdDate = objWritingOnBBCaseEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objWritingOnBBCaseEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conWritingOnBBCase.Memo);
 var strMemo = objWritingOnBBCaseEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into WritingOnBBCase");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsWritingOnBBCaseDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewWritingOnBBCases(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsWritingOnBBCaseDA.GetSpecSQLObj();
strSQL = "Select * from WritingOnBBCase where IdWritingOnBBCase = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "WritingOnBBCase");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
string strIdWritingOnBBCase = oRow[conWritingOnBBCase.IdWritingOnBBCase].ToString().Trim();
if (IsExist(strIdWritingOnBBCase))
{
 string strResult = "关键字变量值为:" + string.Format("IdWritingOnBBCase = {0}", strIdWritingOnBBCase) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsWritingOnBBCaseEN._CurrTabName ].NewRow();
objRow[conWritingOnBBCase.IdWritingOnBBCase] = oRow[conWritingOnBBCase.IdWritingOnBBCase].ToString().Trim(); //板书案例流水号
objRow[conWritingOnBBCase.WritingOnBBCaseID] = oRow[conWritingOnBBCase.WritingOnBBCaseID].ToString().Trim(); //板书教学案例ID
objRow[conWritingOnBBCase.WritingOnBBCaseName] = oRow[conWritingOnBBCase.WritingOnBBCaseName].ToString().Trim(); //板书教学案例名称
objRow[conWritingOnBBCase.WritingOnBBCaseTheme] = oRow[conWritingOnBBCase.WritingOnBBCaseTheme].ToString().Trim(); //板书教学案例主题词
objRow[conWritingOnBBCase.IdDiscipline] = oRow[conWritingOnBBCase.IdDiscipline].ToString().Trim(); //学科流水号
objRow[conWritingOnBBCase.WritingOnBBCaseDate] = oRow[conWritingOnBBCase.WritingOnBBCaseDate].ToString().Trim(); //板书教学日期
objRow[conWritingOnBBCase.WritingOnBBCaseTime] = oRow[conWritingOnBBCase.WritingOnBBCaseTime].ToString().Trim(); //板书教学时间
objRow[conWritingOnBBCase.WritingOnBBCaseDateIn] = oRow[conWritingOnBBCase.WritingOnBBCaseDateIn].ToString().Trim(); //案例入库日期
objRow[conWritingOnBBCase.WritingOnBBCaseTimeIn] = oRow[conWritingOnBBCase.WritingOnBBCaseTimeIn].ToString().Trim(); //案例入库时间
objRow[conWritingOnBBCase.BrowseCount] = oRow[conWritingOnBBCase.BrowseCount].ToString().Trim(); //浏览次数
objRow[conWritingOnBBCase.IdStudyLevel] = oRow[conWritingOnBBCase.IdStudyLevel].ToString().Trim(); //学段流水号
objRow[conWritingOnBBCase.IsNeedGeneWord] = oRow[conWritingOnBBCase.IsNeedGeneWord].ToString().Trim(); //是否需要生成Word
objRow[conWritingOnBBCase.WordCreateDate] = oRow[conWritingOnBBCase.WordCreateDate].ToString().Trim(); //Word生成日期
objRow[conWritingOnBBCase.DocFile] = oRow[conWritingOnBBCase.DocFile].ToString().Trim(); //生成的Word文件名
objRow[conWritingOnBBCase.CaseLevelId] = oRow[conWritingOnBBCase.CaseLevelId].ToString().Trim(); //课例等级Id
objRow[conWritingOnBBCase.IdSenateGaugeVersion] = oRow[conWritingOnBBCase.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objRow[conWritingOnBBCase.IsVisible] = oRow[conWritingOnBBCase.IsVisible].ToString().Trim(); //是否显示
objRow[conWritingOnBBCase.OwnerId] = oRow[conWritingOnBBCase.OwnerId].ToString().Trim(); //拥有者Id
objRow[conWritingOnBBCase.IsDualVideo] = oRow[conWritingOnBBCase.IsDualVideo].ToString().Trim(); //是否双视频
objRow[conWritingOnBBCase.IdWritingOnBBCaseType] = oRow[conWritingOnBBCase.IdWritingOnBBCaseType].ToString().Trim(); //板书案例类型流水号
objRow[conWritingOnBBCase.UserTypeId] = oRow[conWritingOnBBCase.UserTypeId].ToString().Trim(); //用户类型Id
objRow[conWritingOnBBCase.RecommendedDegreeId] = oRow[conWritingOnBBCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objRow[conWritingOnBBCase.ftpFileType] = oRow[conWritingOnBBCase.ftpFileType].ToString().Trim(); //ftp文件类型
objRow[conWritingOnBBCase.VideoUrl] = oRow[conWritingOnBBCase.VideoUrl].ToString().Trim(); //视频Url
objRow[conWritingOnBBCase.VideoPath] = oRow[conWritingOnBBCase.VideoPath].ToString().Trim(); //视频目录
objRow[conWritingOnBBCase.ResErrMsg] = oRow[conWritingOnBBCase.ResErrMsg].ToString().Trim(); //资源错误信息
objRow[conWritingOnBBCase.UpdUserId] = oRow[conWritingOnBBCase.UpdUserId].ToString().Trim(); //修改用户Id
objRow[conWritingOnBBCase.UpdDate] = oRow[conWritingOnBBCase.UpdDate].ToString().Trim(); //修改日期
objRow[conWritingOnBBCase.Memo] = oRow[conWritingOnBBCase.Memo].ToString().Trim(); //备注
 objDS.Tables[clsWritingOnBBCaseEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsWritingOnBBCaseEN._CurrTabName);
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
 /// <param name = "objWritingOnBBCaseEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsWritingOnBBCaseEN objWritingOnBBCaseEN)
{
 objWritingOnBBCaseEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objWritingOnBBCaseEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objWritingOnBBCaseEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsWritingOnBBCaseDA.GetSpecSQLObj();
strSQL = "Select * from WritingOnBBCase where IdWritingOnBBCase = " + "'"+ objWritingOnBBCaseEN.IdWritingOnBBCase+"'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsWritingOnBBCaseEN._CurrTabName);
if (objDS.Tables[clsWritingOnBBCaseEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:IdWritingOnBBCase = " + "'"+ objWritingOnBBCaseEN.IdWritingOnBBCase+"'");
return false;
}
objRow = objDS.Tables[clsWritingOnBBCaseEN._CurrTabName].Rows[0];
 if (objWritingOnBBCaseEN.IsUpdated(conWritingOnBBCase.IdWritingOnBBCase))
 {
objRow[conWritingOnBBCase.IdWritingOnBBCase] = objWritingOnBBCaseEN.IdWritingOnBBCase; //板书案例流水号
 }
 if (objWritingOnBBCaseEN.IsUpdated(conWritingOnBBCase.WritingOnBBCaseID))
 {
objRow[conWritingOnBBCase.WritingOnBBCaseID] = objWritingOnBBCaseEN.WritingOnBBCaseID; //板书教学案例ID
 }
 if (objWritingOnBBCaseEN.IsUpdated(conWritingOnBBCase.WritingOnBBCaseName))
 {
objRow[conWritingOnBBCase.WritingOnBBCaseName] = objWritingOnBBCaseEN.WritingOnBBCaseName; //板书教学案例名称
 }
 if (objWritingOnBBCaseEN.IsUpdated(conWritingOnBBCase.WritingOnBBCaseTheme))
 {
objRow[conWritingOnBBCase.WritingOnBBCaseTheme] = objWritingOnBBCaseEN.WritingOnBBCaseTheme; //板书教学案例主题词
 }
 if (objWritingOnBBCaseEN.IsUpdated(conWritingOnBBCase.IdDiscipline))
 {
objRow[conWritingOnBBCase.IdDiscipline] = objWritingOnBBCaseEN.IdDiscipline; //学科流水号
 }
 if (objWritingOnBBCaseEN.IsUpdated(conWritingOnBBCase.WritingOnBBCaseDate))
 {
objRow[conWritingOnBBCase.WritingOnBBCaseDate] = objWritingOnBBCaseEN.WritingOnBBCaseDate; //板书教学日期
 }
 if (objWritingOnBBCaseEN.IsUpdated(conWritingOnBBCase.WritingOnBBCaseTime))
 {
objRow[conWritingOnBBCase.WritingOnBBCaseTime] = objWritingOnBBCaseEN.WritingOnBBCaseTime; //板书教学时间
 }
 if (objWritingOnBBCaseEN.IsUpdated(conWritingOnBBCase.WritingOnBBCaseDateIn))
 {
objRow[conWritingOnBBCase.WritingOnBBCaseDateIn] = objWritingOnBBCaseEN.WritingOnBBCaseDateIn; //案例入库日期
 }
 if (objWritingOnBBCaseEN.IsUpdated(conWritingOnBBCase.WritingOnBBCaseTimeIn))
 {
objRow[conWritingOnBBCase.WritingOnBBCaseTimeIn] = objWritingOnBBCaseEN.WritingOnBBCaseTimeIn; //案例入库时间
 }
 if (objWritingOnBBCaseEN.IsUpdated(conWritingOnBBCase.BrowseCount))
 {
objRow[conWritingOnBBCase.BrowseCount] = objWritingOnBBCaseEN.BrowseCount; //浏览次数
 }
 if (objWritingOnBBCaseEN.IsUpdated(conWritingOnBBCase.IdStudyLevel))
 {
objRow[conWritingOnBBCase.IdStudyLevel] = objWritingOnBBCaseEN.IdStudyLevel; //学段流水号
 }
 if (objWritingOnBBCaseEN.IsUpdated(conWritingOnBBCase.IsNeedGeneWord))
 {
objRow[conWritingOnBBCase.IsNeedGeneWord] = objWritingOnBBCaseEN.IsNeedGeneWord; //是否需要生成Word
 }
 if (objWritingOnBBCaseEN.IsUpdated(conWritingOnBBCase.WordCreateDate))
 {
objRow[conWritingOnBBCase.WordCreateDate] = objWritingOnBBCaseEN.WordCreateDate; //Word生成日期
 }
 if (objWritingOnBBCaseEN.IsUpdated(conWritingOnBBCase.DocFile))
 {
objRow[conWritingOnBBCase.DocFile] = objWritingOnBBCaseEN.DocFile; //生成的Word文件名
 }
 if (objWritingOnBBCaseEN.IsUpdated(conWritingOnBBCase.CaseLevelId))
 {
objRow[conWritingOnBBCase.CaseLevelId] = objWritingOnBBCaseEN.CaseLevelId; //课例等级Id
 }
 if (objWritingOnBBCaseEN.IsUpdated(conWritingOnBBCase.IdSenateGaugeVersion))
 {
objRow[conWritingOnBBCase.IdSenateGaugeVersion] = objWritingOnBBCaseEN.IdSenateGaugeVersion; //评价量表版本流水号
 }
 if (objWritingOnBBCaseEN.IsUpdated(conWritingOnBBCase.IsVisible))
 {
objRow[conWritingOnBBCase.IsVisible] = objWritingOnBBCaseEN.IsVisible; //是否显示
 }
 if (objWritingOnBBCaseEN.IsUpdated(conWritingOnBBCase.OwnerId))
 {
objRow[conWritingOnBBCase.OwnerId] = objWritingOnBBCaseEN.OwnerId; //拥有者Id
 }
 if (objWritingOnBBCaseEN.IsUpdated(conWritingOnBBCase.IsDualVideo))
 {
objRow[conWritingOnBBCase.IsDualVideo] = objWritingOnBBCaseEN.IsDualVideo; //是否双视频
 }
 if (objWritingOnBBCaseEN.IsUpdated(conWritingOnBBCase.IdWritingOnBBCaseType))
 {
objRow[conWritingOnBBCase.IdWritingOnBBCaseType] = objWritingOnBBCaseEN.IdWritingOnBBCaseType; //板书案例类型流水号
 }
 if (objWritingOnBBCaseEN.IsUpdated(conWritingOnBBCase.UserTypeId))
 {
objRow[conWritingOnBBCase.UserTypeId] = objWritingOnBBCaseEN.UserTypeId; //用户类型Id
 }
 if (objWritingOnBBCaseEN.IsUpdated(conWritingOnBBCase.RecommendedDegreeId))
 {
objRow[conWritingOnBBCase.RecommendedDegreeId] = objWritingOnBBCaseEN.RecommendedDegreeId; //推荐度Id
 }
 if (objWritingOnBBCaseEN.IsUpdated(conWritingOnBBCase.ftpFileType))
 {
objRow[conWritingOnBBCase.ftpFileType] = objWritingOnBBCaseEN.ftpFileType; //ftp文件类型
 }
 if (objWritingOnBBCaseEN.IsUpdated(conWritingOnBBCase.VideoUrl))
 {
objRow[conWritingOnBBCase.VideoUrl] = objWritingOnBBCaseEN.VideoUrl; //视频Url
 }
 if (objWritingOnBBCaseEN.IsUpdated(conWritingOnBBCase.VideoPath))
 {
objRow[conWritingOnBBCase.VideoPath] = objWritingOnBBCaseEN.VideoPath; //视频目录
 }
 if (objWritingOnBBCaseEN.IsUpdated(conWritingOnBBCase.ResErrMsg))
 {
objRow[conWritingOnBBCase.ResErrMsg] = objWritingOnBBCaseEN.ResErrMsg; //资源错误信息
 }
 if (objWritingOnBBCaseEN.IsUpdated(conWritingOnBBCase.UpdUserId))
 {
objRow[conWritingOnBBCase.UpdUserId] = objWritingOnBBCaseEN.UpdUserId; //修改用户Id
 }
 if (objWritingOnBBCaseEN.IsUpdated(conWritingOnBBCase.UpdDate))
 {
objRow[conWritingOnBBCase.UpdDate] = objWritingOnBBCaseEN.UpdDate; //修改日期
 }
 if (objWritingOnBBCaseEN.IsUpdated(conWritingOnBBCase.Memo))
 {
objRow[conWritingOnBBCase.Memo] = objWritingOnBBCaseEN.Memo; //备注
 }
try
{
objDA.Update(objDS, clsWritingOnBBCaseEN._CurrTabName);
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
 /// <param name = "objWritingOnBBCaseEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsWritingOnBBCaseEN objWritingOnBBCaseEN)
{
 objWritingOnBBCaseEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objWritingOnBBCaseEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objWritingOnBBCaseEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsWritingOnBBCaseDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update WritingOnBBCase Set ");
 
 if (objWritingOnBBCaseEN.IsUpdated(conWritingOnBBCase.WritingOnBBCaseID))
 {
 if (objWritingOnBBCaseEN.WritingOnBBCaseID !=  null)
 {
 var strWritingOnBBCaseID = objWritingOnBBCaseEN.WritingOnBBCaseID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strWritingOnBBCaseID, conWritingOnBBCase.WritingOnBBCaseID); //板书教学案例ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conWritingOnBBCase.WritingOnBBCaseID); //板书教学案例ID
 }
 }
 
 if (objWritingOnBBCaseEN.IsUpdated(conWritingOnBBCase.WritingOnBBCaseName))
 {
 if (objWritingOnBBCaseEN.WritingOnBBCaseName !=  null)
 {
 var strWritingOnBBCaseName = objWritingOnBBCaseEN.WritingOnBBCaseName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strWritingOnBBCaseName, conWritingOnBBCase.WritingOnBBCaseName); //板书教学案例名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conWritingOnBBCase.WritingOnBBCaseName); //板书教学案例名称
 }
 }
 
 if (objWritingOnBBCaseEN.IsUpdated(conWritingOnBBCase.WritingOnBBCaseTheme))
 {
 if (objWritingOnBBCaseEN.WritingOnBBCaseTheme !=  null)
 {
 var strWritingOnBBCaseTheme = objWritingOnBBCaseEN.WritingOnBBCaseTheme.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strWritingOnBBCaseTheme, conWritingOnBBCase.WritingOnBBCaseTheme); //板书教学案例主题词
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conWritingOnBBCase.WritingOnBBCaseTheme); //板书教学案例主题词
 }
 }
 
 if (objWritingOnBBCaseEN.IsUpdated(conWritingOnBBCase.IdDiscipline))
 {
 if (objWritingOnBBCaseEN.IdDiscipline !=  null)
 {
 var strIdDiscipline = objWritingOnBBCaseEN.IdDiscipline.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdDiscipline, conWritingOnBBCase.IdDiscipline); //学科流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conWritingOnBBCase.IdDiscipline); //学科流水号
 }
 }
 
 if (objWritingOnBBCaseEN.IsUpdated(conWritingOnBBCase.WritingOnBBCaseDate))
 {
 if (objWritingOnBBCaseEN.WritingOnBBCaseDate !=  null)
 {
 var strWritingOnBBCaseDate = objWritingOnBBCaseEN.WritingOnBBCaseDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strWritingOnBBCaseDate, conWritingOnBBCase.WritingOnBBCaseDate); //板书教学日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conWritingOnBBCase.WritingOnBBCaseDate); //板书教学日期
 }
 }
 
 if (objWritingOnBBCaseEN.IsUpdated(conWritingOnBBCase.WritingOnBBCaseTime))
 {
 if (objWritingOnBBCaseEN.WritingOnBBCaseTime !=  null)
 {
 var strWritingOnBBCaseTime = objWritingOnBBCaseEN.WritingOnBBCaseTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strWritingOnBBCaseTime, conWritingOnBBCase.WritingOnBBCaseTime); //板书教学时间
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conWritingOnBBCase.WritingOnBBCaseTime); //板书教学时间
 }
 }
 
 if (objWritingOnBBCaseEN.IsUpdated(conWritingOnBBCase.WritingOnBBCaseDateIn))
 {
 if (objWritingOnBBCaseEN.WritingOnBBCaseDateIn !=  null)
 {
 var strWritingOnBBCaseDateIn = objWritingOnBBCaseEN.WritingOnBBCaseDateIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strWritingOnBBCaseDateIn, conWritingOnBBCase.WritingOnBBCaseDateIn); //案例入库日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conWritingOnBBCase.WritingOnBBCaseDateIn); //案例入库日期
 }
 }
 
 if (objWritingOnBBCaseEN.IsUpdated(conWritingOnBBCase.WritingOnBBCaseTimeIn))
 {
 if (objWritingOnBBCaseEN.WritingOnBBCaseTimeIn !=  null)
 {
 var strWritingOnBBCaseTimeIn = objWritingOnBBCaseEN.WritingOnBBCaseTimeIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strWritingOnBBCaseTimeIn, conWritingOnBBCase.WritingOnBBCaseTimeIn); //案例入库时间
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conWritingOnBBCase.WritingOnBBCaseTimeIn); //案例入库时间
 }
 }
 
 if (objWritingOnBBCaseEN.IsUpdated(conWritingOnBBCase.BrowseCount))
 {
 if (objWritingOnBBCaseEN.BrowseCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objWritingOnBBCaseEN.BrowseCount, conWritingOnBBCase.BrowseCount); //浏览次数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conWritingOnBBCase.BrowseCount); //浏览次数
 }
 }
 
 if (objWritingOnBBCaseEN.IsUpdated(conWritingOnBBCase.IdStudyLevel))
 {
 if (objWritingOnBBCaseEN.IdStudyLevel !=  null)
 {
 var strIdStudyLevel = objWritingOnBBCaseEN.IdStudyLevel.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdStudyLevel, conWritingOnBBCase.IdStudyLevel); //学段流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conWritingOnBBCase.IdStudyLevel); //学段流水号
 }
 }
 
 if (objWritingOnBBCaseEN.IsUpdated(conWritingOnBBCase.IsNeedGeneWord))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objWritingOnBBCaseEN.IsNeedGeneWord == true?"1":"0", conWritingOnBBCase.IsNeedGeneWord); //是否需要生成Word
 }
 
 if (objWritingOnBBCaseEN.IsUpdated(conWritingOnBBCase.WordCreateDate))
 {
 if (objWritingOnBBCaseEN.WordCreateDate !=  null)
 {
 var strWordCreateDate = objWritingOnBBCaseEN.WordCreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strWordCreateDate, conWritingOnBBCase.WordCreateDate); //Word生成日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conWritingOnBBCase.WordCreateDate); //Word生成日期
 }
 }
 
 if (objWritingOnBBCaseEN.IsUpdated(conWritingOnBBCase.DocFile))
 {
 if (objWritingOnBBCaseEN.DocFile !=  null)
 {
 var strDocFile = objWritingOnBBCaseEN.DocFile.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strDocFile, conWritingOnBBCase.DocFile); //生成的Word文件名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conWritingOnBBCase.DocFile); //生成的Word文件名
 }
 }
 
 if (objWritingOnBBCaseEN.IsUpdated(conWritingOnBBCase.CaseLevelId))
 {
 if (objWritingOnBBCaseEN.CaseLevelId !=  null)
 {
 var strCaseLevelId = objWritingOnBBCaseEN.CaseLevelId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCaseLevelId, conWritingOnBBCase.CaseLevelId); //课例等级Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conWritingOnBBCase.CaseLevelId); //课例等级Id
 }
 }
 
 if (objWritingOnBBCaseEN.IsUpdated(conWritingOnBBCase.IdSenateGaugeVersion))
 {
 if (objWritingOnBBCaseEN.IdSenateGaugeVersion !=  null)
 {
 var strIdSenateGaugeVersion = objWritingOnBBCaseEN.IdSenateGaugeVersion.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdSenateGaugeVersion, conWritingOnBBCase.IdSenateGaugeVersion); //评价量表版本流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conWritingOnBBCase.IdSenateGaugeVersion); //评价量表版本流水号
 }
 }
 
 if (objWritingOnBBCaseEN.IsUpdated(conWritingOnBBCase.IsVisible))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objWritingOnBBCaseEN.IsVisible == true?"1":"0", conWritingOnBBCase.IsVisible); //是否显示
 }
 
 if (objWritingOnBBCaseEN.IsUpdated(conWritingOnBBCase.OwnerId))
 {
 if (objWritingOnBBCaseEN.OwnerId !=  null)
 {
 var strOwnerId = objWritingOnBBCaseEN.OwnerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strOwnerId, conWritingOnBBCase.OwnerId); //拥有者Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conWritingOnBBCase.OwnerId); //拥有者Id
 }
 }
 
 if (objWritingOnBBCaseEN.IsUpdated(conWritingOnBBCase.IsDualVideo))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objWritingOnBBCaseEN.IsDualVideo == true?"1":"0", conWritingOnBBCase.IsDualVideo); //是否双视频
 }
 
 if (objWritingOnBBCaseEN.IsUpdated(conWritingOnBBCase.IdWritingOnBBCaseType))
 {
 if (objWritingOnBBCaseEN.IdWritingOnBBCaseType !=  null)
 {
 var strIdWritingOnBBCaseType = objWritingOnBBCaseEN.IdWritingOnBBCaseType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdWritingOnBBCaseType, conWritingOnBBCase.IdWritingOnBBCaseType); //板书案例类型流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conWritingOnBBCase.IdWritingOnBBCaseType); //板书案例类型流水号
 }
 }
 
 if (objWritingOnBBCaseEN.IsUpdated(conWritingOnBBCase.UserTypeId))
 {
 if (objWritingOnBBCaseEN.UserTypeId !=  null)
 {
 var strUserTypeId = objWritingOnBBCaseEN.UserTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUserTypeId, conWritingOnBBCase.UserTypeId); //用户类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conWritingOnBBCase.UserTypeId); //用户类型Id
 }
 }
 
 if (objWritingOnBBCaseEN.IsUpdated(conWritingOnBBCase.RecommendedDegreeId))
 {
 if (objWritingOnBBCaseEN.RecommendedDegreeId !=  null)
 {
 var strRecommendedDegreeId = objWritingOnBBCaseEN.RecommendedDegreeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strRecommendedDegreeId, conWritingOnBBCase.RecommendedDegreeId); //推荐度Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conWritingOnBBCase.RecommendedDegreeId); //推荐度Id
 }
 }
 
 if (objWritingOnBBCaseEN.IsUpdated(conWritingOnBBCase.ftpFileType))
 {
 if (objWritingOnBBCaseEN.ftpFileType !=  null)
 {
 var strftpFileType = objWritingOnBBCaseEN.ftpFileType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strftpFileType, conWritingOnBBCase.ftpFileType); //ftp文件类型
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conWritingOnBBCase.ftpFileType); //ftp文件类型
 }
 }
 
 if (objWritingOnBBCaseEN.IsUpdated(conWritingOnBBCase.VideoUrl))
 {
 if (objWritingOnBBCaseEN.VideoUrl !=  null)
 {
 var strVideoUrl = objWritingOnBBCaseEN.VideoUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strVideoUrl, conWritingOnBBCase.VideoUrl); //视频Url
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conWritingOnBBCase.VideoUrl); //视频Url
 }
 }
 
 if (objWritingOnBBCaseEN.IsUpdated(conWritingOnBBCase.VideoPath))
 {
 if (objWritingOnBBCaseEN.VideoPath !=  null)
 {
 var strVideoPath = objWritingOnBBCaseEN.VideoPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strVideoPath, conWritingOnBBCase.VideoPath); //视频目录
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conWritingOnBBCase.VideoPath); //视频目录
 }
 }
 
 if (objWritingOnBBCaseEN.IsUpdated(conWritingOnBBCase.ResErrMsg))
 {
 if (objWritingOnBBCaseEN.ResErrMsg !=  null)
 {
 var strResErrMsg = objWritingOnBBCaseEN.ResErrMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strResErrMsg, conWritingOnBBCase.ResErrMsg); //资源错误信息
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conWritingOnBBCase.ResErrMsg); //资源错误信息
 }
 }
 
 if (objWritingOnBBCaseEN.IsUpdated(conWritingOnBBCase.UpdUserId))
 {
 if (objWritingOnBBCaseEN.UpdUserId !=  null)
 {
 var strUpdUserId = objWritingOnBBCaseEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUserId, conWritingOnBBCase.UpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conWritingOnBBCase.UpdUserId); //修改用户Id
 }
 }
 
 if (objWritingOnBBCaseEN.IsUpdated(conWritingOnBBCase.UpdDate))
 {
 if (objWritingOnBBCaseEN.UpdDate !=  null)
 {
 var strUpdDate = objWritingOnBBCaseEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conWritingOnBBCase.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conWritingOnBBCase.UpdDate); //修改日期
 }
 }
 
 if (objWritingOnBBCaseEN.IsUpdated(conWritingOnBBCase.Memo))
 {
 if (objWritingOnBBCaseEN.Memo !=  null)
 {
 var strMemo = objWritingOnBBCaseEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conWritingOnBBCase.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conWritingOnBBCase.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where IdWritingOnBBCase = '{0}'", objWritingOnBBCaseEN.IdWritingOnBBCase); 
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
 /// <param name = "objWritingOnBBCaseEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsWritingOnBBCaseEN objWritingOnBBCaseEN, string strCondition)
{
 objWritingOnBBCaseEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objWritingOnBBCaseEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objWritingOnBBCaseEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsWritingOnBBCaseDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update WritingOnBBCase Set ");
 
 if (objWritingOnBBCaseEN.IsUpdated(conWritingOnBBCase.WritingOnBBCaseID))
 {
 if (objWritingOnBBCaseEN.WritingOnBBCaseID !=  null)
 {
 var strWritingOnBBCaseID = objWritingOnBBCaseEN.WritingOnBBCaseID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" WritingOnBBCaseID = '{0}',", strWritingOnBBCaseID); //板书教学案例ID
 }
 else
 {
 sbSQL.Append(" WritingOnBBCaseID = null,"); //板书教学案例ID
 }
 }
 
 if (objWritingOnBBCaseEN.IsUpdated(conWritingOnBBCase.WritingOnBBCaseName))
 {
 if (objWritingOnBBCaseEN.WritingOnBBCaseName !=  null)
 {
 var strWritingOnBBCaseName = objWritingOnBBCaseEN.WritingOnBBCaseName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" WritingOnBBCaseName = '{0}',", strWritingOnBBCaseName); //板书教学案例名称
 }
 else
 {
 sbSQL.Append(" WritingOnBBCaseName = null,"); //板书教学案例名称
 }
 }
 
 if (objWritingOnBBCaseEN.IsUpdated(conWritingOnBBCase.WritingOnBBCaseTheme))
 {
 if (objWritingOnBBCaseEN.WritingOnBBCaseTheme !=  null)
 {
 var strWritingOnBBCaseTheme = objWritingOnBBCaseEN.WritingOnBBCaseTheme.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" WritingOnBBCaseTheme = '{0}',", strWritingOnBBCaseTheme); //板书教学案例主题词
 }
 else
 {
 sbSQL.Append(" WritingOnBBCaseTheme = null,"); //板书教学案例主题词
 }
 }
 
 if (objWritingOnBBCaseEN.IsUpdated(conWritingOnBBCase.IdDiscipline))
 {
 if (objWritingOnBBCaseEN.IdDiscipline !=  null)
 {
 var strIdDiscipline = objWritingOnBBCaseEN.IdDiscipline.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdDiscipline = '{0}',", strIdDiscipline); //学科流水号
 }
 else
 {
 sbSQL.Append(" IdDiscipline = null,"); //学科流水号
 }
 }
 
 if (objWritingOnBBCaseEN.IsUpdated(conWritingOnBBCase.WritingOnBBCaseDate))
 {
 if (objWritingOnBBCaseEN.WritingOnBBCaseDate !=  null)
 {
 var strWritingOnBBCaseDate = objWritingOnBBCaseEN.WritingOnBBCaseDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" WritingOnBBCaseDate = '{0}',", strWritingOnBBCaseDate); //板书教学日期
 }
 else
 {
 sbSQL.Append(" WritingOnBBCaseDate = null,"); //板书教学日期
 }
 }
 
 if (objWritingOnBBCaseEN.IsUpdated(conWritingOnBBCase.WritingOnBBCaseTime))
 {
 if (objWritingOnBBCaseEN.WritingOnBBCaseTime !=  null)
 {
 var strWritingOnBBCaseTime = objWritingOnBBCaseEN.WritingOnBBCaseTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" WritingOnBBCaseTime = '{0}',", strWritingOnBBCaseTime); //板书教学时间
 }
 else
 {
 sbSQL.Append(" WritingOnBBCaseTime = null,"); //板书教学时间
 }
 }
 
 if (objWritingOnBBCaseEN.IsUpdated(conWritingOnBBCase.WritingOnBBCaseDateIn))
 {
 if (objWritingOnBBCaseEN.WritingOnBBCaseDateIn !=  null)
 {
 var strWritingOnBBCaseDateIn = objWritingOnBBCaseEN.WritingOnBBCaseDateIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" WritingOnBBCaseDateIn = '{0}',", strWritingOnBBCaseDateIn); //案例入库日期
 }
 else
 {
 sbSQL.Append(" WritingOnBBCaseDateIn = null,"); //案例入库日期
 }
 }
 
 if (objWritingOnBBCaseEN.IsUpdated(conWritingOnBBCase.WritingOnBBCaseTimeIn))
 {
 if (objWritingOnBBCaseEN.WritingOnBBCaseTimeIn !=  null)
 {
 var strWritingOnBBCaseTimeIn = objWritingOnBBCaseEN.WritingOnBBCaseTimeIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" WritingOnBBCaseTimeIn = '{0}',", strWritingOnBBCaseTimeIn); //案例入库时间
 }
 else
 {
 sbSQL.Append(" WritingOnBBCaseTimeIn = null,"); //案例入库时间
 }
 }
 
 if (objWritingOnBBCaseEN.IsUpdated(conWritingOnBBCase.BrowseCount))
 {
 if (objWritingOnBBCaseEN.BrowseCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objWritingOnBBCaseEN.BrowseCount, conWritingOnBBCase.BrowseCount); //浏览次数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conWritingOnBBCase.BrowseCount); //浏览次数
 }
 }
 
 if (objWritingOnBBCaseEN.IsUpdated(conWritingOnBBCase.IdStudyLevel))
 {
 if (objWritingOnBBCaseEN.IdStudyLevel !=  null)
 {
 var strIdStudyLevel = objWritingOnBBCaseEN.IdStudyLevel.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdStudyLevel = '{0}',", strIdStudyLevel); //学段流水号
 }
 else
 {
 sbSQL.Append(" IdStudyLevel = null,"); //学段流水号
 }
 }
 
 if (objWritingOnBBCaseEN.IsUpdated(conWritingOnBBCase.IsNeedGeneWord))
 {
 sbSQL.AppendFormat(" IsNeedGeneWord = '{0}',", objWritingOnBBCaseEN.IsNeedGeneWord == true?"1":"0"); //是否需要生成Word
 }
 
 if (objWritingOnBBCaseEN.IsUpdated(conWritingOnBBCase.WordCreateDate))
 {
 if (objWritingOnBBCaseEN.WordCreateDate !=  null)
 {
 var strWordCreateDate = objWritingOnBBCaseEN.WordCreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" WordCreateDate = '{0}',", strWordCreateDate); //Word生成日期
 }
 else
 {
 sbSQL.Append(" WordCreateDate = null,"); //Word生成日期
 }
 }
 
 if (objWritingOnBBCaseEN.IsUpdated(conWritingOnBBCase.DocFile))
 {
 if (objWritingOnBBCaseEN.DocFile !=  null)
 {
 var strDocFile = objWritingOnBBCaseEN.DocFile.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DocFile = '{0}',", strDocFile); //生成的Word文件名
 }
 else
 {
 sbSQL.Append(" DocFile = null,"); //生成的Word文件名
 }
 }
 
 if (objWritingOnBBCaseEN.IsUpdated(conWritingOnBBCase.CaseLevelId))
 {
 if (objWritingOnBBCaseEN.CaseLevelId !=  null)
 {
 var strCaseLevelId = objWritingOnBBCaseEN.CaseLevelId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CaseLevelId = '{0}',", strCaseLevelId); //课例等级Id
 }
 else
 {
 sbSQL.Append(" CaseLevelId = null,"); //课例等级Id
 }
 }
 
 if (objWritingOnBBCaseEN.IsUpdated(conWritingOnBBCase.IdSenateGaugeVersion))
 {
 if (objWritingOnBBCaseEN.IdSenateGaugeVersion !=  null)
 {
 var strIdSenateGaugeVersion = objWritingOnBBCaseEN.IdSenateGaugeVersion.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdSenateGaugeVersion = '{0}',", strIdSenateGaugeVersion); //评价量表版本流水号
 }
 else
 {
 sbSQL.Append(" IdSenateGaugeVersion = null,"); //评价量表版本流水号
 }
 }
 
 if (objWritingOnBBCaseEN.IsUpdated(conWritingOnBBCase.IsVisible))
 {
 sbSQL.AppendFormat(" IsVisible = '{0}',", objWritingOnBBCaseEN.IsVisible == true?"1":"0"); //是否显示
 }
 
 if (objWritingOnBBCaseEN.IsUpdated(conWritingOnBBCase.OwnerId))
 {
 if (objWritingOnBBCaseEN.OwnerId !=  null)
 {
 var strOwnerId = objWritingOnBBCaseEN.OwnerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" OwnerId = '{0}',", strOwnerId); //拥有者Id
 }
 else
 {
 sbSQL.Append(" OwnerId = null,"); //拥有者Id
 }
 }
 
 if (objWritingOnBBCaseEN.IsUpdated(conWritingOnBBCase.IsDualVideo))
 {
 sbSQL.AppendFormat(" IsDualVideo = '{0}',", objWritingOnBBCaseEN.IsDualVideo == true?"1":"0"); //是否双视频
 }
 
 if (objWritingOnBBCaseEN.IsUpdated(conWritingOnBBCase.IdWritingOnBBCaseType))
 {
 if (objWritingOnBBCaseEN.IdWritingOnBBCaseType !=  null)
 {
 var strIdWritingOnBBCaseType = objWritingOnBBCaseEN.IdWritingOnBBCaseType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdWritingOnBBCaseType = '{0}',", strIdWritingOnBBCaseType); //板书案例类型流水号
 }
 else
 {
 sbSQL.Append(" IdWritingOnBBCaseType = null,"); //板书案例类型流水号
 }
 }
 
 if (objWritingOnBBCaseEN.IsUpdated(conWritingOnBBCase.UserTypeId))
 {
 if (objWritingOnBBCaseEN.UserTypeId !=  null)
 {
 var strUserTypeId = objWritingOnBBCaseEN.UserTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UserTypeId = '{0}',", strUserTypeId); //用户类型Id
 }
 else
 {
 sbSQL.Append(" UserTypeId = null,"); //用户类型Id
 }
 }
 
 if (objWritingOnBBCaseEN.IsUpdated(conWritingOnBBCase.RecommendedDegreeId))
 {
 if (objWritingOnBBCaseEN.RecommendedDegreeId !=  null)
 {
 var strRecommendedDegreeId = objWritingOnBBCaseEN.RecommendedDegreeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" RecommendedDegreeId = '{0}',", strRecommendedDegreeId); //推荐度Id
 }
 else
 {
 sbSQL.Append(" RecommendedDegreeId = null,"); //推荐度Id
 }
 }
 
 if (objWritingOnBBCaseEN.IsUpdated(conWritingOnBBCase.ftpFileType))
 {
 if (objWritingOnBBCaseEN.ftpFileType !=  null)
 {
 var strftpFileType = objWritingOnBBCaseEN.ftpFileType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ftpFileType = '{0}',", strftpFileType); //ftp文件类型
 }
 else
 {
 sbSQL.Append(" ftpFileType = null,"); //ftp文件类型
 }
 }
 
 if (objWritingOnBBCaseEN.IsUpdated(conWritingOnBBCase.VideoUrl))
 {
 if (objWritingOnBBCaseEN.VideoUrl !=  null)
 {
 var strVideoUrl = objWritingOnBBCaseEN.VideoUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" VideoUrl = '{0}',", strVideoUrl); //视频Url
 }
 else
 {
 sbSQL.Append(" VideoUrl = null,"); //视频Url
 }
 }
 
 if (objWritingOnBBCaseEN.IsUpdated(conWritingOnBBCase.VideoPath))
 {
 if (objWritingOnBBCaseEN.VideoPath !=  null)
 {
 var strVideoPath = objWritingOnBBCaseEN.VideoPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" VideoPath = '{0}',", strVideoPath); //视频目录
 }
 else
 {
 sbSQL.Append(" VideoPath = null,"); //视频目录
 }
 }
 
 if (objWritingOnBBCaseEN.IsUpdated(conWritingOnBBCase.ResErrMsg))
 {
 if (objWritingOnBBCaseEN.ResErrMsg !=  null)
 {
 var strResErrMsg = objWritingOnBBCaseEN.ResErrMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ResErrMsg = '{0}',", strResErrMsg); //资源错误信息
 }
 else
 {
 sbSQL.Append(" ResErrMsg = null,"); //资源错误信息
 }
 }
 
 if (objWritingOnBBCaseEN.IsUpdated(conWritingOnBBCase.UpdUserId))
 {
 if (objWritingOnBBCaseEN.UpdUserId !=  null)
 {
 var strUpdUserId = objWritingOnBBCaseEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUserId = '{0}',", strUpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.Append(" UpdUserId = null,"); //修改用户Id
 }
 }
 
 if (objWritingOnBBCaseEN.IsUpdated(conWritingOnBBCase.UpdDate))
 {
 if (objWritingOnBBCaseEN.UpdDate !=  null)
 {
 var strUpdDate = objWritingOnBBCaseEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objWritingOnBBCaseEN.IsUpdated(conWritingOnBBCase.Memo))
 {
 if (objWritingOnBBCaseEN.Memo !=  null)
 {
 var strMemo = objWritingOnBBCaseEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objWritingOnBBCaseEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsWritingOnBBCaseEN objWritingOnBBCaseEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objWritingOnBBCaseEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objWritingOnBBCaseEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objWritingOnBBCaseEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsWritingOnBBCaseDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update WritingOnBBCase Set ");
 
 if (objWritingOnBBCaseEN.IsUpdated(conWritingOnBBCase.WritingOnBBCaseID))
 {
 if (objWritingOnBBCaseEN.WritingOnBBCaseID !=  null)
 {
 var strWritingOnBBCaseID = objWritingOnBBCaseEN.WritingOnBBCaseID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" WritingOnBBCaseID = '{0}',", strWritingOnBBCaseID); //板书教学案例ID
 }
 else
 {
 sbSQL.Append(" WritingOnBBCaseID = null,"); //板书教学案例ID
 }
 }
 
 if (objWritingOnBBCaseEN.IsUpdated(conWritingOnBBCase.WritingOnBBCaseName))
 {
 if (objWritingOnBBCaseEN.WritingOnBBCaseName !=  null)
 {
 var strWritingOnBBCaseName = objWritingOnBBCaseEN.WritingOnBBCaseName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" WritingOnBBCaseName = '{0}',", strWritingOnBBCaseName); //板书教学案例名称
 }
 else
 {
 sbSQL.Append(" WritingOnBBCaseName = null,"); //板书教学案例名称
 }
 }
 
 if (objWritingOnBBCaseEN.IsUpdated(conWritingOnBBCase.WritingOnBBCaseTheme))
 {
 if (objWritingOnBBCaseEN.WritingOnBBCaseTheme !=  null)
 {
 var strWritingOnBBCaseTheme = objWritingOnBBCaseEN.WritingOnBBCaseTheme.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" WritingOnBBCaseTheme = '{0}',", strWritingOnBBCaseTheme); //板书教学案例主题词
 }
 else
 {
 sbSQL.Append(" WritingOnBBCaseTheme = null,"); //板书教学案例主题词
 }
 }
 
 if (objWritingOnBBCaseEN.IsUpdated(conWritingOnBBCase.IdDiscipline))
 {
 if (objWritingOnBBCaseEN.IdDiscipline !=  null)
 {
 var strIdDiscipline = objWritingOnBBCaseEN.IdDiscipline.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdDiscipline = '{0}',", strIdDiscipline); //学科流水号
 }
 else
 {
 sbSQL.Append(" IdDiscipline = null,"); //学科流水号
 }
 }
 
 if (objWritingOnBBCaseEN.IsUpdated(conWritingOnBBCase.WritingOnBBCaseDate))
 {
 if (objWritingOnBBCaseEN.WritingOnBBCaseDate !=  null)
 {
 var strWritingOnBBCaseDate = objWritingOnBBCaseEN.WritingOnBBCaseDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" WritingOnBBCaseDate = '{0}',", strWritingOnBBCaseDate); //板书教学日期
 }
 else
 {
 sbSQL.Append(" WritingOnBBCaseDate = null,"); //板书教学日期
 }
 }
 
 if (objWritingOnBBCaseEN.IsUpdated(conWritingOnBBCase.WritingOnBBCaseTime))
 {
 if (objWritingOnBBCaseEN.WritingOnBBCaseTime !=  null)
 {
 var strWritingOnBBCaseTime = objWritingOnBBCaseEN.WritingOnBBCaseTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" WritingOnBBCaseTime = '{0}',", strWritingOnBBCaseTime); //板书教学时间
 }
 else
 {
 sbSQL.Append(" WritingOnBBCaseTime = null,"); //板书教学时间
 }
 }
 
 if (objWritingOnBBCaseEN.IsUpdated(conWritingOnBBCase.WritingOnBBCaseDateIn))
 {
 if (objWritingOnBBCaseEN.WritingOnBBCaseDateIn !=  null)
 {
 var strWritingOnBBCaseDateIn = objWritingOnBBCaseEN.WritingOnBBCaseDateIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" WritingOnBBCaseDateIn = '{0}',", strWritingOnBBCaseDateIn); //案例入库日期
 }
 else
 {
 sbSQL.Append(" WritingOnBBCaseDateIn = null,"); //案例入库日期
 }
 }
 
 if (objWritingOnBBCaseEN.IsUpdated(conWritingOnBBCase.WritingOnBBCaseTimeIn))
 {
 if (objWritingOnBBCaseEN.WritingOnBBCaseTimeIn !=  null)
 {
 var strWritingOnBBCaseTimeIn = objWritingOnBBCaseEN.WritingOnBBCaseTimeIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" WritingOnBBCaseTimeIn = '{0}',", strWritingOnBBCaseTimeIn); //案例入库时间
 }
 else
 {
 sbSQL.Append(" WritingOnBBCaseTimeIn = null,"); //案例入库时间
 }
 }
 
 if (objWritingOnBBCaseEN.IsUpdated(conWritingOnBBCase.BrowseCount))
 {
 if (objWritingOnBBCaseEN.BrowseCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objWritingOnBBCaseEN.BrowseCount, conWritingOnBBCase.BrowseCount); //浏览次数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conWritingOnBBCase.BrowseCount); //浏览次数
 }
 }
 
 if (objWritingOnBBCaseEN.IsUpdated(conWritingOnBBCase.IdStudyLevel))
 {
 if (objWritingOnBBCaseEN.IdStudyLevel !=  null)
 {
 var strIdStudyLevel = objWritingOnBBCaseEN.IdStudyLevel.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdStudyLevel = '{0}',", strIdStudyLevel); //学段流水号
 }
 else
 {
 sbSQL.Append(" IdStudyLevel = null,"); //学段流水号
 }
 }
 
 if (objWritingOnBBCaseEN.IsUpdated(conWritingOnBBCase.IsNeedGeneWord))
 {
 sbSQL.AppendFormat(" IsNeedGeneWord = '{0}',", objWritingOnBBCaseEN.IsNeedGeneWord == true?"1":"0"); //是否需要生成Word
 }
 
 if (objWritingOnBBCaseEN.IsUpdated(conWritingOnBBCase.WordCreateDate))
 {
 if (objWritingOnBBCaseEN.WordCreateDate !=  null)
 {
 var strWordCreateDate = objWritingOnBBCaseEN.WordCreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" WordCreateDate = '{0}',", strWordCreateDate); //Word生成日期
 }
 else
 {
 sbSQL.Append(" WordCreateDate = null,"); //Word生成日期
 }
 }
 
 if (objWritingOnBBCaseEN.IsUpdated(conWritingOnBBCase.DocFile))
 {
 if (objWritingOnBBCaseEN.DocFile !=  null)
 {
 var strDocFile = objWritingOnBBCaseEN.DocFile.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DocFile = '{0}',", strDocFile); //生成的Word文件名
 }
 else
 {
 sbSQL.Append(" DocFile = null,"); //生成的Word文件名
 }
 }
 
 if (objWritingOnBBCaseEN.IsUpdated(conWritingOnBBCase.CaseLevelId))
 {
 if (objWritingOnBBCaseEN.CaseLevelId !=  null)
 {
 var strCaseLevelId = objWritingOnBBCaseEN.CaseLevelId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CaseLevelId = '{0}',", strCaseLevelId); //课例等级Id
 }
 else
 {
 sbSQL.Append(" CaseLevelId = null,"); //课例等级Id
 }
 }
 
 if (objWritingOnBBCaseEN.IsUpdated(conWritingOnBBCase.IdSenateGaugeVersion))
 {
 if (objWritingOnBBCaseEN.IdSenateGaugeVersion !=  null)
 {
 var strIdSenateGaugeVersion = objWritingOnBBCaseEN.IdSenateGaugeVersion.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdSenateGaugeVersion = '{0}',", strIdSenateGaugeVersion); //评价量表版本流水号
 }
 else
 {
 sbSQL.Append(" IdSenateGaugeVersion = null,"); //评价量表版本流水号
 }
 }
 
 if (objWritingOnBBCaseEN.IsUpdated(conWritingOnBBCase.IsVisible))
 {
 sbSQL.AppendFormat(" IsVisible = '{0}',", objWritingOnBBCaseEN.IsVisible == true?"1":"0"); //是否显示
 }
 
 if (objWritingOnBBCaseEN.IsUpdated(conWritingOnBBCase.OwnerId))
 {
 if (objWritingOnBBCaseEN.OwnerId !=  null)
 {
 var strOwnerId = objWritingOnBBCaseEN.OwnerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" OwnerId = '{0}',", strOwnerId); //拥有者Id
 }
 else
 {
 sbSQL.Append(" OwnerId = null,"); //拥有者Id
 }
 }
 
 if (objWritingOnBBCaseEN.IsUpdated(conWritingOnBBCase.IsDualVideo))
 {
 sbSQL.AppendFormat(" IsDualVideo = '{0}',", objWritingOnBBCaseEN.IsDualVideo == true?"1":"0"); //是否双视频
 }
 
 if (objWritingOnBBCaseEN.IsUpdated(conWritingOnBBCase.IdWritingOnBBCaseType))
 {
 if (objWritingOnBBCaseEN.IdWritingOnBBCaseType !=  null)
 {
 var strIdWritingOnBBCaseType = objWritingOnBBCaseEN.IdWritingOnBBCaseType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdWritingOnBBCaseType = '{0}',", strIdWritingOnBBCaseType); //板书案例类型流水号
 }
 else
 {
 sbSQL.Append(" IdWritingOnBBCaseType = null,"); //板书案例类型流水号
 }
 }
 
 if (objWritingOnBBCaseEN.IsUpdated(conWritingOnBBCase.UserTypeId))
 {
 if (objWritingOnBBCaseEN.UserTypeId !=  null)
 {
 var strUserTypeId = objWritingOnBBCaseEN.UserTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UserTypeId = '{0}',", strUserTypeId); //用户类型Id
 }
 else
 {
 sbSQL.Append(" UserTypeId = null,"); //用户类型Id
 }
 }
 
 if (objWritingOnBBCaseEN.IsUpdated(conWritingOnBBCase.RecommendedDegreeId))
 {
 if (objWritingOnBBCaseEN.RecommendedDegreeId !=  null)
 {
 var strRecommendedDegreeId = objWritingOnBBCaseEN.RecommendedDegreeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" RecommendedDegreeId = '{0}',", strRecommendedDegreeId); //推荐度Id
 }
 else
 {
 sbSQL.Append(" RecommendedDegreeId = null,"); //推荐度Id
 }
 }
 
 if (objWritingOnBBCaseEN.IsUpdated(conWritingOnBBCase.ftpFileType))
 {
 if (objWritingOnBBCaseEN.ftpFileType !=  null)
 {
 var strftpFileType = objWritingOnBBCaseEN.ftpFileType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ftpFileType = '{0}',", strftpFileType); //ftp文件类型
 }
 else
 {
 sbSQL.Append(" ftpFileType = null,"); //ftp文件类型
 }
 }
 
 if (objWritingOnBBCaseEN.IsUpdated(conWritingOnBBCase.VideoUrl))
 {
 if (objWritingOnBBCaseEN.VideoUrl !=  null)
 {
 var strVideoUrl = objWritingOnBBCaseEN.VideoUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" VideoUrl = '{0}',", strVideoUrl); //视频Url
 }
 else
 {
 sbSQL.Append(" VideoUrl = null,"); //视频Url
 }
 }
 
 if (objWritingOnBBCaseEN.IsUpdated(conWritingOnBBCase.VideoPath))
 {
 if (objWritingOnBBCaseEN.VideoPath !=  null)
 {
 var strVideoPath = objWritingOnBBCaseEN.VideoPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" VideoPath = '{0}',", strVideoPath); //视频目录
 }
 else
 {
 sbSQL.Append(" VideoPath = null,"); //视频目录
 }
 }
 
 if (objWritingOnBBCaseEN.IsUpdated(conWritingOnBBCase.ResErrMsg))
 {
 if (objWritingOnBBCaseEN.ResErrMsg !=  null)
 {
 var strResErrMsg = objWritingOnBBCaseEN.ResErrMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ResErrMsg = '{0}',", strResErrMsg); //资源错误信息
 }
 else
 {
 sbSQL.Append(" ResErrMsg = null,"); //资源错误信息
 }
 }
 
 if (objWritingOnBBCaseEN.IsUpdated(conWritingOnBBCase.UpdUserId))
 {
 if (objWritingOnBBCaseEN.UpdUserId !=  null)
 {
 var strUpdUserId = objWritingOnBBCaseEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUserId = '{0}',", strUpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.Append(" UpdUserId = null,"); //修改用户Id
 }
 }
 
 if (objWritingOnBBCaseEN.IsUpdated(conWritingOnBBCase.UpdDate))
 {
 if (objWritingOnBBCaseEN.UpdDate !=  null)
 {
 var strUpdDate = objWritingOnBBCaseEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objWritingOnBBCaseEN.IsUpdated(conWritingOnBBCase.Memo))
 {
 if (objWritingOnBBCaseEN.Memo !=  null)
 {
 var strMemo = objWritingOnBBCaseEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objWritingOnBBCaseEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsWritingOnBBCaseEN objWritingOnBBCaseEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objWritingOnBBCaseEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objWritingOnBBCaseEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objWritingOnBBCaseEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsWritingOnBBCaseDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update WritingOnBBCase Set ");
 
 if (objWritingOnBBCaseEN.IsUpdated(conWritingOnBBCase.WritingOnBBCaseID))
 {
 if (objWritingOnBBCaseEN.WritingOnBBCaseID !=  null)
 {
 var strWritingOnBBCaseID = objWritingOnBBCaseEN.WritingOnBBCaseID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strWritingOnBBCaseID, conWritingOnBBCase.WritingOnBBCaseID); //板书教学案例ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conWritingOnBBCase.WritingOnBBCaseID); //板书教学案例ID
 }
 }
 
 if (objWritingOnBBCaseEN.IsUpdated(conWritingOnBBCase.WritingOnBBCaseName))
 {
 if (objWritingOnBBCaseEN.WritingOnBBCaseName !=  null)
 {
 var strWritingOnBBCaseName = objWritingOnBBCaseEN.WritingOnBBCaseName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strWritingOnBBCaseName, conWritingOnBBCase.WritingOnBBCaseName); //板书教学案例名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conWritingOnBBCase.WritingOnBBCaseName); //板书教学案例名称
 }
 }
 
 if (objWritingOnBBCaseEN.IsUpdated(conWritingOnBBCase.WritingOnBBCaseTheme))
 {
 if (objWritingOnBBCaseEN.WritingOnBBCaseTheme !=  null)
 {
 var strWritingOnBBCaseTheme = objWritingOnBBCaseEN.WritingOnBBCaseTheme.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strWritingOnBBCaseTheme, conWritingOnBBCase.WritingOnBBCaseTheme); //板书教学案例主题词
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conWritingOnBBCase.WritingOnBBCaseTheme); //板书教学案例主题词
 }
 }
 
 if (objWritingOnBBCaseEN.IsUpdated(conWritingOnBBCase.IdDiscipline))
 {
 if (objWritingOnBBCaseEN.IdDiscipline !=  null)
 {
 var strIdDiscipline = objWritingOnBBCaseEN.IdDiscipline.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdDiscipline, conWritingOnBBCase.IdDiscipline); //学科流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conWritingOnBBCase.IdDiscipline); //学科流水号
 }
 }
 
 if (objWritingOnBBCaseEN.IsUpdated(conWritingOnBBCase.WritingOnBBCaseDate))
 {
 if (objWritingOnBBCaseEN.WritingOnBBCaseDate !=  null)
 {
 var strWritingOnBBCaseDate = objWritingOnBBCaseEN.WritingOnBBCaseDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strWritingOnBBCaseDate, conWritingOnBBCase.WritingOnBBCaseDate); //板书教学日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conWritingOnBBCase.WritingOnBBCaseDate); //板书教学日期
 }
 }
 
 if (objWritingOnBBCaseEN.IsUpdated(conWritingOnBBCase.WritingOnBBCaseTime))
 {
 if (objWritingOnBBCaseEN.WritingOnBBCaseTime !=  null)
 {
 var strWritingOnBBCaseTime = objWritingOnBBCaseEN.WritingOnBBCaseTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strWritingOnBBCaseTime, conWritingOnBBCase.WritingOnBBCaseTime); //板书教学时间
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conWritingOnBBCase.WritingOnBBCaseTime); //板书教学时间
 }
 }
 
 if (objWritingOnBBCaseEN.IsUpdated(conWritingOnBBCase.WritingOnBBCaseDateIn))
 {
 if (objWritingOnBBCaseEN.WritingOnBBCaseDateIn !=  null)
 {
 var strWritingOnBBCaseDateIn = objWritingOnBBCaseEN.WritingOnBBCaseDateIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strWritingOnBBCaseDateIn, conWritingOnBBCase.WritingOnBBCaseDateIn); //案例入库日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conWritingOnBBCase.WritingOnBBCaseDateIn); //案例入库日期
 }
 }
 
 if (objWritingOnBBCaseEN.IsUpdated(conWritingOnBBCase.WritingOnBBCaseTimeIn))
 {
 if (objWritingOnBBCaseEN.WritingOnBBCaseTimeIn !=  null)
 {
 var strWritingOnBBCaseTimeIn = objWritingOnBBCaseEN.WritingOnBBCaseTimeIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strWritingOnBBCaseTimeIn, conWritingOnBBCase.WritingOnBBCaseTimeIn); //案例入库时间
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conWritingOnBBCase.WritingOnBBCaseTimeIn); //案例入库时间
 }
 }
 
 if (objWritingOnBBCaseEN.IsUpdated(conWritingOnBBCase.BrowseCount))
 {
 if (objWritingOnBBCaseEN.BrowseCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objWritingOnBBCaseEN.BrowseCount, conWritingOnBBCase.BrowseCount); //浏览次数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conWritingOnBBCase.BrowseCount); //浏览次数
 }
 }
 
 if (objWritingOnBBCaseEN.IsUpdated(conWritingOnBBCase.IdStudyLevel))
 {
 if (objWritingOnBBCaseEN.IdStudyLevel !=  null)
 {
 var strIdStudyLevel = objWritingOnBBCaseEN.IdStudyLevel.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdStudyLevel, conWritingOnBBCase.IdStudyLevel); //学段流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conWritingOnBBCase.IdStudyLevel); //学段流水号
 }
 }
 
 if (objWritingOnBBCaseEN.IsUpdated(conWritingOnBBCase.IsNeedGeneWord))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objWritingOnBBCaseEN.IsNeedGeneWord == true?"1":"0", conWritingOnBBCase.IsNeedGeneWord); //是否需要生成Word
 }
 
 if (objWritingOnBBCaseEN.IsUpdated(conWritingOnBBCase.WordCreateDate))
 {
 if (objWritingOnBBCaseEN.WordCreateDate !=  null)
 {
 var strWordCreateDate = objWritingOnBBCaseEN.WordCreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strWordCreateDate, conWritingOnBBCase.WordCreateDate); //Word生成日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conWritingOnBBCase.WordCreateDate); //Word生成日期
 }
 }
 
 if (objWritingOnBBCaseEN.IsUpdated(conWritingOnBBCase.DocFile))
 {
 if (objWritingOnBBCaseEN.DocFile !=  null)
 {
 var strDocFile = objWritingOnBBCaseEN.DocFile.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strDocFile, conWritingOnBBCase.DocFile); //生成的Word文件名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conWritingOnBBCase.DocFile); //生成的Word文件名
 }
 }
 
 if (objWritingOnBBCaseEN.IsUpdated(conWritingOnBBCase.CaseLevelId))
 {
 if (objWritingOnBBCaseEN.CaseLevelId !=  null)
 {
 var strCaseLevelId = objWritingOnBBCaseEN.CaseLevelId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCaseLevelId, conWritingOnBBCase.CaseLevelId); //课例等级Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conWritingOnBBCase.CaseLevelId); //课例等级Id
 }
 }
 
 if (objWritingOnBBCaseEN.IsUpdated(conWritingOnBBCase.IdSenateGaugeVersion))
 {
 if (objWritingOnBBCaseEN.IdSenateGaugeVersion !=  null)
 {
 var strIdSenateGaugeVersion = objWritingOnBBCaseEN.IdSenateGaugeVersion.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdSenateGaugeVersion, conWritingOnBBCase.IdSenateGaugeVersion); //评价量表版本流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conWritingOnBBCase.IdSenateGaugeVersion); //评价量表版本流水号
 }
 }
 
 if (objWritingOnBBCaseEN.IsUpdated(conWritingOnBBCase.IsVisible))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objWritingOnBBCaseEN.IsVisible == true?"1":"0", conWritingOnBBCase.IsVisible); //是否显示
 }
 
 if (objWritingOnBBCaseEN.IsUpdated(conWritingOnBBCase.OwnerId))
 {
 if (objWritingOnBBCaseEN.OwnerId !=  null)
 {
 var strOwnerId = objWritingOnBBCaseEN.OwnerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strOwnerId, conWritingOnBBCase.OwnerId); //拥有者Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conWritingOnBBCase.OwnerId); //拥有者Id
 }
 }
 
 if (objWritingOnBBCaseEN.IsUpdated(conWritingOnBBCase.IsDualVideo))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objWritingOnBBCaseEN.IsDualVideo == true?"1":"0", conWritingOnBBCase.IsDualVideo); //是否双视频
 }
 
 if (objWritingOnBBCaseEN.IsUpdated(conWritingOnBBCase.IdWritingOnBBCaseType))
 {
 if (objWritingOnBBCaseEN.IdWritingOnBBCaseType !=  null)
 {
 var strIdWritingOnBBCaseType = objWritingOnBBCaseEN.IdWritingOnBBCaseType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdWritingOnBBCaseType, conWritingOnBBCase.IdWritingOnBBCaseType); //板书案例类型流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conWritingOnBBCase.IdWritingOnBBCaseType); //板书案例类型流水号
 }
 }
 
 if (objWritingOnBBCaseEN.IsUpdated(conWritingOnBBCase.UserTypeId))
 {
 if (objWritingOnBBCaseEN.UserTypeId !=  null)
 {
 var strUserTypeId = objWritingOnBBCaseEN.UserTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUserTypeId, conWritingOnBBCase.UserTypeId); //用户类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conWritingOnBBCase.UserTypeId); //用户类型Id
 }
 }
 
 if (objWritingOnBBCaseEN.IsUpdated(conWritingOnBBCase.RecommendedDegreeId))
 {
 if (objWritingOnBBCaseEN.RecommendedDegreeId !=  null)
 {
 var strRecommendedDegreeId = objWritingOnBBCaseEN.RecommendedDegreeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strRecommendedDegreeId, conWritingOnBBCase.RecommendedDegreeId); //推荐度Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conWritingOnBBCase.RecommendedDegreeId); //推荐度Id
 }
 }
 
 if (objWritingOnBBCaseEN.IsUpdated(conWritingOnBBCase.ftpFileType))
 {
 if (objWritingOnBBCaseEN.ftpFileType !=  null)
 {
 var strftpFileType = objWritingOnBBCaseEN.ftpFileType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strftpFileType, conWritingOnBBCase.ftpFileType); //ftp文件类型
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conWritingOnBBCase.ftpFileType); //ftp文件类型
 }
 }
 
 if (objWritingOnBBCaseEN.IsUpdated(conWritingOnBBCase.VideoUrl))
 {
 if (objWritingOnBBCaseEN.VideoUrl !=  null)
 {
 var strVideoUrl = objWritingOnBBCaseEN.VideoUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strVideoUrl, conWritingOnBBCase.VideoUrl); //视频Url
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conWritingOnBBCase.VideoUrl); //视频Url
 }
 }
 
 if (objWritingOnBBCaseEN.IsUpdated(conWritingOnBBCase.VideoPath))
 {
 if (objWritingOnBBCaseEN.VideoPath !=  null)
 {
 var strVideoPath = objWritingOnBBCaseEN.VideoPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strVideoPath, conWritingOnBBCase.VideoPath); //视频目录
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conWritingOnBBCase.VideoPath); //视频目录
 }
 }
 
 if (objWritingOnBBCaseEN.IsUpdated(conWritingOnBBCase.ResErrMsg))
 {
 if (objWritingOnBBCaseEN.ResErrMsg !=  null)
 {
 var strResErrMsg = objWritingOnBBCaseEN.ResErrMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strResErrMsg, conWritingOnBBCase.ResErrMsg); //资源错误信息
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conWritingOnBBCase.ResErrMsg); //资源错误信息
 }
 }
 
 if (objWritingOnBBCaseEN.IsUpdated(conWritingOnBBCase.UpdUserId))
 {
 if (objWritingOnBBCaseEN.UpdUserId !=  null)
 {
 var strUpdUserId = objWritingOnBBCaseEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUserId, conWritingOnBBCase.UpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conWritingOnBBCase.UpdUserId); //修改用户Id
 }
 }
 
 if (objWritingOnBBCaseEN.IsUpdated(conWritingOnBBCase.UpdDate))
 {
 if (objWritingOnBBCaseEN.UpdDate !=  null)
 {
 var strUpdDate = objWritingOnBBCaseEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conWritingOnBBCase.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conWritingOnBBCase.UpdDate); //修改日期
 }
 }
 
 if (objWritingOnBBCaseEN.IsUpdated(conWritingOnBBCase.Memo))
 {
 if (objWritingOnBBCaseEN.Memo !=  null)
 {
 var strMemo = objWritingOnBBCaseEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conWritingOnBBCase.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conWritingOnBBCase.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where IdWritingOnBBCase = '{0}'", objWritingOnBBCaseEN.IdWritingOnBBCase); 
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
 /// <param name = "strIdWritingOnBBCase">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(string strIdWritingOnBBCase) 
{
CheckPrimaryKey(strIdWritingOnBBCase);
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsWritingOnBBCaseDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 strIdWritingOnBBCase,
};
 objSQL.ExecSP("WritingOnBBCase_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "strIdWritingOnBBCase">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(string strIdWritingOnBBCase, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
CheckPrimaryKey(strIdWritingOnBBCase);
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsWritingOnBBCaseDA.GetSpecSQLObj();
//删除WritingOnBBCase本表中与当前对象有关的记录
strSQL = strSQL + "Delete from WritingOnBBCase where IdWritingOnBBCase = " + "'"+ strIdWritingOnBBCase+"'";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelWritingOnBBCase(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsWritingOnBBCaseDA.GetSpecSQLObj();
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
//删除WritingOnBBCase本表中与当前对象有关的记录
strSQL = strSQL + "Delete from WritingOnBBCase where IdWritingOnBBCase in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "strIdWritingOnBBCase">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(string strIdWritingOnBBCase) 
{
CheckPrimaryKey(strIdWritingOnBBCase);
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsWritingOnBBCaseDA.GetSpecSQLObj();
//删除WritingOnBBCase本表中与当前对象有关的记录
strSQL = strSQL + "Delete from WritingOnBBCase where IdWritingOnBBCase = " + "'"+ strIdWritingOnBBCase+"'";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelWritingOnBBCase(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsWritingOnBBCaseDA: DelWritingOnBBCase)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsWritingOnBBCaseDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from WritingOnBBCase where " + strCondition ;
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
public bool DelWritingOnBBCaseWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsWritingOnBBCaseDA: DelWritingOnBBCaseWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsWritingOnBBCaseDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from WritingOnBBCase where " + strCondition ;
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
 /// <param name = "objWritingOnBBCaseENS">源对象</param>
 /// <param name = "objWritingOnBBCaseENT">目标对象</param>
public void CopyTo(clsWritingOnBBCaseEN objWritingOnBBCaseENS, clsWritingOnBBCaseEN objWritingOnBBCaseENT)
{
objWritingOnBBCaseENT.IdWritingOnBBCase = objWritingOnBBCaseENS.IdWritingOnBBCase; //板书案例流水号
objWritingOnBBCaseENT.WritingOnBBCaseID = objWritingOnBBCaseENS.WritingOnBBCaseID; //板书教学案例ID
objWritingOnBBCaseENT.WritingOnBBCaseName = objWritingOnBBCaseENS.WritingOnBBCaseName; //板书教学案例名称
objWritingOnBBCaseENT.WritingOnBBCaseTheme = objWritingOnBBCaseENS.WritingOnBBCaseTheme; //板书教学案例主题词
objWritingOnBBCaseENT.IdDiscipline = objWritingOnBBCaseENS.IdDiscipline; //学科流水号
objWritingOnBBCaseENT.WritingOnBBCaseDate = objWritingOnBBCaseENS.WritingOnBBCaseDate; //板书教学日期
objWritingOnBBCaseENT.WritingOnBBCaseTime = objWritingOnBBCaseENS.WritingOnBBCaseTime; //板书教学时间
objWritingOnBBCaseENT.WritingOnBBCaseDateIn = objWritingOnBBCaseENS.WritingOnBBCaseDateIn; //案例入库日期
objWritingOnBBCaseENT.WritingOnBBCaseTimeIn = objWritingOnBBCaseENS.WritingOnBBCaseTimeIn; //案例入库时间
objWritingOnBBCaseENT.BrowseCount = objWritingOnBBCaseENS.BrowseCount; //浏览次数
objWritingOnBBCaseENT.IdStudyLevel = objWritingOnBBCaseENS.IdStudyLevel; //学段流水号
objWritingOnBBCaseENT.IsNeedGeneWord = objWritingOnBBCaseENS.IsNeedGeneWord; //是否需要生成Word
objWritingOnBBCaseENT.WordCreateDate = objWritingOnBBCaseENS.WordCreateDate; //Word生成日期
objWritingOnBBCaseENT.DocFile = objWritingOnBBCaseENS.DocFile; //生成的Word文件名
objWritingOnBBCaseENT.CaseLevelId = objWritingOnBBCaseENS.CaseLevelId; //课例等级Id
objWritingOnBBCaseENT.IdSenateGaugeVersion = objWritingOnBBCaseENS.IdSenateGaugeVersion; //评价量表版本流水号
objWritingOnBBCaseENT.IsVisible = objWritingOnBBCaseENS.IsVisible; //是否显示
objWritingOnBBCaseENT.OwnerId = objWritingOnBBCaseENS.OwnerId; //拥有者Id
objWritingOnBBCaseENT.IsDualVideo = objWritingOnBBCaseENS.IsDualVideo; //是否双视频
objWritingOnBBCaseENT.IdWritingOnBBCaseType = objWritingOnBBCaseENS.IdWritingOnBBCaseType; //板书案例类型流水号
objWritingOnBBCaseENT.UserTypeId = objWritingOnBBCaseENS.UserTypeId; //用户类型Id
objWritingOnBBCaseENT.RecommendedDegreeId = objWritingOnBBCaseENS.RecommendedDegreeId; //推荐度Id
objWritingOnBBCaseENT.ftpFileType = objWritingOnBBCaseENS.ftpFileType; //ftp文件类型
objWritingOnBBCaseENT.VideoUrl = objWritingOnBBCaseENS.VideoUrl; //视频Url
objWritingOnBBCaseENT.VideoPath = objWritingOnBBCaseENS.VideoPath; //视频目录
objWritingOnBBCaseENT.ResErrMsg = objWritingOnBBCaseENS.ResErrMsg; //资源错误信息
objWritingOnBBCaseENT.UpdUserId = objWritingOnBBCaseENS.UpdUserId; //修改用户Id
objWritingOnBBCaseENT.UpdDate = objWritingOnBBCaseENS.UpdDate; //修改日期
objWritingOnBBCaseENT.Memo = objWritingOnBBCaseENS.Memo; //备注
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsWritingOnBBCaseEN objWritingOnBBCaseEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objWritingOnBBCaseEN.WritingOnBBCaseID, conWritingOnBBCase.WritingOnBBCaseID);
clsCheckSql.CheckFieldNotNull(objWritingOnBBCaseEN.WritingOnBBCaseName, conWritingOnBBCase.WritingOnBBCaseName);
clsCheckSql.CheckFieldNotNull(objWritingOnBBCaseEN.IdDiscipline, conWritingOnBBCase.IdDiscipline);
clsCheckSql.CheckFieldNotNull(objWritingOnBBCaseEN.IdStudyLevel, conWritingOnBBCase.IdStudyLevel);
clsCheckSql.CheckFieldNotNull(objWritingOnBBCaseEN.IdSenateGaugeVersion, conWritingOnBBCase.IdSenateGaugeVersion);
clsCheckSql.CheckFieldNotNull(objWritingOnBBCaseEN.OwnerId, conWritingOnBBCase.OwnerId);
clsCheckSql.CheckFieldNotNull(objWritingOnBBCaseEN.IsDualVideo, conWritingOnBBCase.IsDualVideo);
clsCheckSql.CheckFieldNotNull(objWritingOnBBCaseEN.RecommendedDegreeId, conWritingOnBBCase.RecommendedDegreeId);
//检查字段长度
clsCheckSql.CheckFieldLen(objWritingOnBBCaseEN.IdWritingOnBBCase, 8, conWritingOnBBCase.IdWritingOnBBCase);
clsCheckSql.CheckFieldLen(objWritingOnBBCaseEN.WritingOnBBCaseID, 8, conWritingOnBBCase.WritingOnBBCaseID);
clsCheckSql.CheckFieldLen(objWritingOnBBCaseEN.WritingOnBBCaseName, 100, conWritingOnBBCase.WritingOnBBCaseName);
clsCheckSql.CheckFieldLen(objWritingOnBBCaseEN.WritingOnBBCaseTheme, 200, conWritingOnBBCase.WritingOnBBCaseTheme);
clsCheckSql.CheckFieldLen(objWritingOnBBCaseEN.IdDiscipline, 4, conWritingOnBBCase.IdDiscipline);
clsCheckSql.CheckFieldLen(objWritingOnBBCaseEN.WritingOnBBCaseDate, 8, conWritingOnBBCase.WritingOnBBCaseDate);
clsCheckSql.CheckFieldLen(objWritingOnBBCaseEN.WritingOnBBCaseTime, 6, conWritingOnBBCase.WritingOnBBCaseTime);
clsCheckSql.CheckFieldLen(objWritingOnBBCaseEN.WritingOnBBCaseDateIn, 8, conWritingOnBBCase.WritingOnBBCaseDateIn);
clsCheckSql.CheckFieldLen(objWritingOnBBCaseEN.WritingOnBBCaseTimeIn, 6, conWritingOnBBCase.WritingOnBBCaseTimeIn);
clsCheckSql.CheckFieldLen(objWritingOnBBCaseEN.IdStudyLevel, 4, conWritingOnBBCase.IdStudyLevel);
clsCheckSql.CheckFieldLen(objWritingOnBBCaseEN.WordCreateDate, 14, conWritingOnBBCase.WordCreateDate);
clsCheckSql.CheckFieldLen(objWritingOnBBCaseEN.DocFile, 200, conWritingOnBBCase.DocFile);
clsCheckSql.CheckFieldLen(objWritingOnBBCaseEN.CaseLevelId, 2, conWritingOnBBCase.CaseLevelId);
clsCheckSql.CheckFieldLen(objWritingOnBBCaseEN.IdSenateGaugeVersion, 4, conWritingOnBBCase.IdSenateGaugeVersion);
clsCheckSql.CheckFieldLen(objWritingOnBBCaseEN.OwnerId, 20, conWritingOnBBCase.OwnerId);
clsCheckSql.CheckFieldLen(objWritingOnBBCaseEN.IdWritingOnBBCaseType, 4, conWritingOnBBCase.IdWritingOnBBCaseType);
clsCheckSql.CheckFieldLen(objWritingOnBBCaseEN.UserTypeId, 2, conWritingOnBBCase.UserTypeId);
clsCheckSql.CheckFieldLen(objWritingOnBBCaseEN.RecommendedDegreeId, 2, conWritingOnBBCase.RecommendedDegreeId);
clsCheckSql.CheckFieldLen(objWritingOnBBCaseEN.ftpFileType, 30, conWritingOnBBCase.ftpFileType);
clsCheckSql.CheckFieldLen(objWritingOnBBCaseEN.VideoUrl, 1000, conWritingOnBBCase.VideoUrl);
clsCheckSql.CheckFieldLen(objWritingOnBBCaseEN.VideoPath, 1000, conWritingOnBBCase.VideoPath);
clsCheckSql.CheckFieldLen(objWritingOnBBCaseEN.ResErrMsg, 30, conWritingOnBBCase.ResErrMsg);
clsCheckSql.CheckFieldLen(objWritingOnBBCaseEN.UpdUserId, 20, conWritingOnBBCase.UpdUserId);
clsCheckSql.CheckFieldLen(objWritingOnBBCaseEN.UpdDate, 20, conWritingOnBBCase.UpdDate);
clsCheckSql.CheckFieldLen(objWritingOnBBCaseEN.Memo, 1000, conWritingOnBBCase.Memo);
//检查字段外键固定长度
 objWritingOnBBCaseEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsWritingOnBBCaseEN objWritingOnBBCaseEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objWritingOnBBCaseEN.WritingOnBBCaseID, 8, conWritingOnBBCase.WritingOnBBCaseID);
clsCheckSql.CheckFieldLen(objWritingOnBBCaseEN.WritingOnBBCaseName, 100, conWritingOnBBCase.WritingOnBBCaseName);
clsCheckSql.CheckFieldLen(objWritingOnBBCaseEN.WritingOnBBCaseTheme, 200, conWritingOnBBCase.WritingOnBBCaseTheme);
clsCheckSql.CheckFieldLen(objWritingOnBBCaseEN.IdDiscipline, 4, conWritingOnBBCase.IdDiscipline);
clsCheckSql.CheckFieldLen(objWritingOnBBCaseEN.WritingOnBBCaseDate, 8, conWritingOnBBCase.WritingOnBBCaseDate);
clsCheckSql.CheckFieldLen(objWritingOnBBCaseEN.WritingOnBBCaseTime, 6, conWritingOnBBCase.WritingOnBBCaseTime);
clsCheckSql.CheckFieldLen(objWritingOnBBCaseEN.WritingOnBBCaseDateIn, 8, conWritingOnBBCase.WritingOnBBCaseDateIn);
clsCheckSql.CheckFieldLen(objWritingOnBBCaseEN.WritingOnBBCaseTimeIn, 6, conWritingOnBBCase.WritingOnBBCaseTimeIn);
clsCheckSql.CheckFieldLen(objWritingOnBBCaseEN.IdStudyLevel, 4, conWritingOnBBCase.IdStudyLevel);
clsCheckSql.CheckFieldLen(objWritingOnBBCaseEN.WordCreateDate, 14, conWritingOnBBCase.WordCreateDate);
clsCheckSql.CheckFieldLen(objWritingOnBBCaseEN.DocFile, 200, conWritingOnBBCase.DocFile);
clsCheckSql.CheckFieldLen(objWritingOnBBCaseEN.CaseLevelId, 2, conWritingOnBBCase.CaseLevelId);
clsCheckSql.CheckFieldLen(objWritingOnBBCaseEN.IdSenateGaugeVersion, 4, conWritingOnBBCase.IdSenateGaugeVersion);
clsCheckSql.CheckFieldLen(objWritingOnBBCaseEN.OwnerId, 20, conWritingOnBBCase.OwnerId);
clsCheckSql.CheckFieldLen(objWritingOnBBCaseEN.IdWritingOnBBCaseType, 4, conWritingOnBBCase.IdWritingOnBBCaseType);
clsCheckSql.CheckFieldLen(objWritingOnBBCaseEN.UserTypeId, 2, conWritingOnBBCase.UserTypeId);
clsCheckSql.CheckFieldLen(objWritingOnBBCaseEN.RecommendedDegreeId, 2, conWritingOnBBCase.RecommendedDegreeId);
clsCheckSql.CheckFieldLen(objWritingOnBBCaseEN.ftpFileType, 30, conWritingOnBBCase.ftpFileType);
clsCheckSql.CheckFieldLen(objWritingOnBBCaseEN.VideoUrl, 1000, conWritingOnBBCase.VideoUrl);
clsCheckSql.CheckFieldLen(objWritingOnBBCaseEN.VideoPath, 1000, conWritingOnBBCase.VideoPath);
clsCheckSql.CheckFieldLen(objWritingOnBBCaseEN.ResErrMsg, 30, conWritingOnBBCase.ResErrMsg);
clsCheckSql.CheckFieldLen(objWritingOnBBCaseEN.UpdUserId, 20, conWritingOnBBCase.UpdUserId);
clsCheckSql.CheckFieldLen(objWritingOnBBCaseEN.UpdDate, 20, conWritingOnBBCase.UpdDate);
clsCheckSql.CheckFieldLen(objWritingOnBBCaseEN.Memo, 1000, conWritingOnBBCase.Memo);
//检查外键字段长度
 objWritingOnBBCaseEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsWritingOnBBCaseEN objWritingOnBBCaseEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objWritingOnBBCaseEN.IdWritingOnBBCase, 8, conWritingOnBBCase.IdWritingOnBBCase);
clsCheckSql.CheckFieldLen(objWritingOnBBCaseEN.WritingOnBBCaseID, 8, conWritingOnBBCase.WritingOnBBCaseID);
clsCheckSql.CheckFieldLen(objWritingOnBBCaseEN.WritingOnBBCaseName, 100, conWritingOnBBCase.WritingOnBBCaseName);
clsCheckSql.CheckFieldLen(objWritingOnBBCaseEN.WritingOnBBCaseTheme, 200, conWritingOnBBCase.WritingOnBBCaseTheme);
clsCheckSql.CheckFieldLen(objWritingOnBBCaseEN.IdDiscipline, 4, conWritingOnBBCase.IdDiscipline);
clsCheckSql.CheckFieldLen(objWritingOnBBCaseEN.WritingOnBBCaseDate, 8, conWritingOnBBCase.WritingOnBBCaseDate);
clsCheckSql.CheckFieldLen(objWritingOnBBCaseEN.WritingOnBBCaseTime, 6, conWritingOnBBCase.WritingOnBBCaseTime);
clsCheckSql.CheckFieldLen(objWritingOnBBCaseEN.WritingOnBBCaseDateIn, 8, conWritingOnBBCase.WritingOnBBCaseDateIn);
clsCheckSql.CheckFieldLen(objWritingOnBBCaseEN.WritingOnBBCaseTimeIn, 6, conWritingOnBBCase.WritingOnBBCaseTimeIn);
clsCheckSql.CheckFieldLen(objWritingOnBBCaseEN.IdStudyLevel, 4, conWritingOnBBCase.IdStudyLevel);
clsCheckSql.CheckFieldLen(objWritingOnBBCaseEN.WordCreateDate, 14, conWritingOnBBCase.WordCreateDate);
clsCheckSql.CheckFieldLen(objWritingOnBBCaseEN.DocFile, 200, conWritingOnBBCase.DocFile);
clsCheckSql.CheckFieldLen(objWritingOnBBCaseEN.CaseLevelId, 2, conWritingOnBBCase.CaseLevelId);
clsCheckSql.CheckFieldLen(objWritingOnBBCaseEN.IdSenateGaugeVersion, 4, conWritingOnBBCase.IdSenateGaugeVersion);
clsCheckSql.CheckFieldLen(objWritingOnBBCaseEN.OwnerId, 20, conWritingOnBBCase.OwnerId);
clsCheckSql.CheckFieldLen(objWritingOnBBCaseEN.IdWritingOnBBCaseType, 4, conWritingOnBBCase.IdWritingOnBBCaseType);
clsCheckSql.CheckFieldLen(objWritingOnBBCaseEN.UserTypeId, 2, conWritingOnBBCase.UserTypeId);
clsCheckSql.CheckFieldLen(objWritingOnBBCaseEN.RecommendedDegreeId, 2, conWritingOnBBCase.RecommendedDegreeId);
clsCheckSql.CheckFieldLen(objWritingOnBBCaseEN.ftpFileType, 30, conWritingOnBBCase.ftpFileType);
clsCheckSql.CheckFieldLen(objWritingOnBBCaseEN.VideoUrl, 1000, conWritingOnBBCase.VideoUrl);
clsCheckSql.CheckFieldLen(objWritingOnBBCaseEN.VideoPath, 1000, conWritingOnBBCase.VideoPath);
clsCheckSql.CheckFieldLen(objWritingOnBBCaseEN.ResErrMsg, 30, conWritingOnBBCase.ResErrMsg);
clsCheckSql.CheckFieldLen(objWritingOnBBCaseEN.UpdUserId, 20, conWritingOnBBCase.UpdUserId);
clsCheckSql.CheckFieldLen(objWritingOnBBCaseEN.UpdDate, 20, conWritingOnBBCase.UpdDate);
clsCheckSql.CheckFieldLen(objWritingOnBBCaseEN.Memo, 1000, conWritingOnBBCase.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objWritingOnBBCaseEN.IdWritingOnBBCase, conWritingOnBBCase.IdWritingOnBBCase);
clsCheckSql.CheckSqlInjection4Field(objWritingOnBBCaseEN.WritingOnBBCaseID, conWritingOnBBCase.WritingOnBBCaseID);
clsCheckSql.CheckSqlInjection4Field(objWritingOnBBCaseEN.WritingOnBBCaseName, conWritingOnBBCase.WritingOnBBCaseName);
clsCheckSql.CheckSqlInjection4Field(objWritingOnBBCaseEN.WritingOnBBCaseTheme, conWritingOnBBCase.WritingOnBBCaseTheme);
clsCheckSql.CheckSqlInjection4Field(objWritingOnBBCaseEN.IdDiscipline, conWritingOnBBCase.IdDiscipline);
clsCheckSql.CheckSqlInjection4Field(objWritingOnBBCaseEN.WritingOnBBCaseDate, conWritingOnBBCase.WritingOnBBCaseDate);
clsCheckSql.CheckSqlInjection4Field(objWritingOnBBCaseEN.WritingOnBBCaseTime, conWritingOnBBCase.WritingOnBBCaseTime);
clsCheckSql.CheckSqlInjection4Field(objWritingOnBBCaseEN.WritingOnBBCaseDateIn, conWritingOnBBCase.WritingOnBBCaseDateIn);
clsCheckSql.CheckSqlInjection4Field(objWritingOnBBCaseEN.WritingOnBBCaseTimeIn, conWritingOnBBCase.WritingOnBBCaseTimeIn);
clsCheckSql.CheckSqlInjection4Field(objWritingOnBBCaseEN.IdStudyLevel, conWritingOnBBCase.IdStudyLevel);
clsCheckSql.CheckSqlInjection4Field(objWritingOnBBCaseEN.WordCreateDate, conWritingOnBBCase.WordCreateDate);
clsCheckSql.CheckSqlInjection4Field(objWritingOnBBCaseEN.DocFile, conWritingOnBBCase.DocFile);
clsCheckSql.CheckSqlInjection4Field(objWritingOnBBCaseEN.CaseLevelId, conWritingOnBBCase.CaseLevelId);
clsCheckSql.CheckSqlInjection4Field(objWritingOnBBCaseEN.IdSenateGaugeVersion, conWritingOnBBCase.IdSenateGaugeVersion);
clsCheckSql.CheckSqlInjection4Field(objWritingOnBBCaseEN.OwnerId, conWritingOnBBCase.OwnerId);
clsCheckSql.CheckSqlInjection4Field(objWritingOnBBCaseEN.IdWritingOnBBCaseType, conWritingOnBBCase.IdWritingOnBBCaseType);
clsCheckSql.CheckSqlInjection4Field(objWritingOnBBCaseEN.UserTypeId, conWritingOnBBCase.UserTypeId);
clsCheckSql.CheckSqlInjection4Field(objWritingOnBBCaseEN.RecommendedDegreeId, conWritingOnBBCase.RecommendedDegreeId);
clsCheckSql.CheckSqlInjection4Field(objWritingOnBBCaseEN.ftpFileType, conWritingOnBBCase.ftpFileType);
clsCheckSql.CheckSqlInjection4Field(objWritingOnBBCaseEN.VideoUrl, conWritingOnBBCase.VideoUrl);
clsCheckSql.CheckSqlInjection4Field(objWritingOnBBCaseEN.VideoPath, conWritingOnBBCase.VideoPath);
clsCheckSql.CheckSqlInjection4Field(objWritingOnBBCaseEN.ResErrMsg, conWritingOnBBCase.ResErrMsg);
clsCheckSql.CheckSqlInjection4Field(objWritingOnBBCaseEN.UpdUserId, conWritingOnBBCase.UpdUserId);
clsCheckSql.CheckSqlInjection4Field(objWritingOnBBCaseEN.UpdDate, conWritingOnBBCase.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objWritingOnBBCaseEN.Memo, conWritingOnBBCase.Memo);
//检查外键字段长度
 objWritingOnBBCaseEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 /// <summary>
 /// 获取用于绑定下拉框的DataTable,获取两个字段:1、关键字；2、名称字段
 /// (AutoGCLib.clsGeneCodeBase:Gen_4DAL_GetDataTable4DdlBind)
 /// </summary>
 /// <returns>返回用于绑定下拉框的DataTable</returns>
public System.Data.DataTable GetIdWritingOnBBCase()
{
//获取某学院所有专业信息
string strSQL = "select IdWritingOnBBCase, WritingOnBBCaseName from WritingOnBBCase ";
 clsSpecSQLforSql mySql = clsWritingOnBBCaseDA.GetSpecSQLObj();
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
 objSQL = clsWritingOnBBCaseDA.GetSpecSQLObj();
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
 objSQL = clsWritingOnBBCaseDA.GetSpecSQLObj();
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
 objSQL = clsWritingOnBBCaseDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsWritingOnBBCaseEN._CurrTabName);
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
 objSQL = clsWritingOnBBCaseDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsWritingOnBBCaseEN._CurrTabName, strCondition);
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
 objSQL = clsWritingOnBBCaseDA.GetSpecSQLObj();
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
 objSQL = clsWritingOnBBCaseDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}