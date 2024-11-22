
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvWritingOnBBCaseDA
 表名:vWritingOnBBCase(01120468)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:51:08
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:板书点播(WritingOnBlackboard)
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
 /// v板书教学案例(vWritingOnBBCase)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvWritingOnBBCaseDA : clsCommBase4DA
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
 return clsvWritingOnBBCaseEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvWritingOnBBCaseEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvWritingOnBBCaseEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvWritingOnBBCaseEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvWritingOnBBCaseEN._ConnectString);
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
throw new Exception("(errid:Data000001)在表:vWritingOnBBCase中,检查关键字,长度不正确!(clsvWritingOnBBCaseDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strIdWritingOnBBCase)  ==  true)
{
throw new Exception("(errid:Data000002)在表:vWritingOnBBCase中,关键字不能为空 或 null!(clsvWritingOnBBCaseDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strIdWritingOnBBCase);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsvWritingOnBBCaseDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvWritingOnBBCaseDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvWritingOnBBCaseDA.GetSpecSQLObj();
strSQL = "Select * from vWritingOnBBCase where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vWritingOnBBCase(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvWritingOnBBCaseDA: GetDataTable_vWritingOnBBCase)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvWritingOnBBCaseDA.GetSpecSQLObj();
strSQL = "Select * from vWritingOnBBCase where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvWritingOnBBCaseDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvWritingOnBBCaseDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvWritingOnBBCaseDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvWritingOnBBCaseDA.GetSpecSQLObj();
strSQL = "Select * from vWritingOnBBCase where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvWritingOnBBCaseDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvWritingOnBBCaseDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvWritingOnBBCaseDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvWritingOnBBCaseDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vWritingOnBBCase where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vWritingOnBBCase where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvWritingOnBBCaseDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvWritingOnBBCaseDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vWritingOnBBCase where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvWritingOnBBCaseDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvWritingOnBBCaseDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vWritingOnBBCase.* from vWritingOnBBCase Left Join {1} on {2} where {3} and vWritingOnBBCase.IdWritingOnBBCase not in (Select top {5} vWritingOnBBCase.IdWritingOnBBCase from vWritingOnBBCase Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vWritingOnBBCase where {1} and IdWritingOnBBCase not in (Select top {2} IdWritingOnBBCase from vWritingOnBBCase where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vWritingOnBBCase where {1} and IdWritingOnBBCase not in (Select top {3} IdWritingOnBBCase from vWritingOnBBCase where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvWritingOnBBCaseDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvWritingOnBBCaseDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vWritingOnBBCase.* from vWritingOnBBCase Left Join {1} on {2} where {3} and vWritingOnBBCase.IdWritingOnBBCase not in (Select top {5} vWritingOnBBCase.IdWritingOnBBCase from vWritingOnBBCase Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vWritingOnBBCase where {1} and IdWritingOnBBCase not in (Select top {2} IdWritingOnBBCase from vWritingOnBBCase where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vWritingOnBBCase where {1} and IdWritingOnBBCase not in (Select top {3} IdWritingOnBBCase from vWritingOnBBCase where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvWritingOnBBCaseEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvWritingOnBBCaseDA:GetObjLst)", objException.Message));
}
List<clsvWritingOnBBCaseEN> arrObjLst = new List<clsvWritingOnBBCaseEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvWritingOnBBCaseDA.GetSpecSQLObj();
strSQL = "Select * from vWritingOnBBCase where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvWritingOnBBCaseEN objvWritingOnBBCaseEN = new clsvWritingOnBBCaseEN();
try
{
objvWritingOnBBCaseEN.IdWritingOnBBCase = objRow[convWritingOnBBCase.IdWritingOnBBCase].ToString().Trim(); //板书案例流水号
objvWritingOnBBCaseEN.WritingOnBBCaseID = objRow[convWritingOnBBCase.WritingOnBBCaseID].ToString().Trim(); //板书教学案例ID
objvWritingOnBBCaseEN.WritingOnBBCaseName = objRow[convWritingOnBBCase.WritingOnBBCaseName].ToString().Trim(); //板书教学案例名称
objvWritingOnBBCaseEN.WritingOnBBCaseTheme = objRow[convWritingOnBBCase.WritingOnBBCaseTheme] == DBNull.Value ? null : objRow[convWritingOnBBCase.WritingOnBBCaseTheme].ToString().Trim(); //板书教学案例主题词
objvWritingOnBBCaseEN.IdDiscipline = objRow[convWritingOnBBCase.IdDiscipline].ToString().Trim(); //学科流水号
objvWritingOnBBCaseEN.DisciplineID = objRow[convWritingOnBBCase.DisciplineID].ToString().Trim(); //学科ID
objvWritingOnBBCaseEN.DisciplineName = objRow[convWritingOnBBCase.DisciplineName].ToString().Trim(); //学科名称
objvWritingOnBBCaseEN.WritingOnBBCaseDate = objRow[convWritingOnBBCase.WritingOnBBCaseDate] == DBNull.Value ? null : objRow[convWritingOnBBCase.WritingOnBBCaseDate].ToString().Trim(); //板书教学日期
objvWritingOnBBCaseEN.WritingOnBBCaseTime = objRow[convWritingOnBBCase.WritingOnBBCaseTime] == DBNull.Value ? null : objRow[convWritingOnBBCase.WritingOnBBCaseTime].ToString().Trim(); //板书教学时间
objvWritingOnBBCaseEN.WritingOnBBCaseDateIn = objRow[convWritingOnBBCase.WritingOnBBCaseDateIn] == DBNull.Value ? null : objRow[convWritingOnBBCase.WritingOnBBCaseDateIn].ToString().Trim(); //案例入库日期
objvWritingOnBBCaseEN.WritingOnBBCaseTimeIn = objRow[convWritingOnBBCase.WritingOnBBCaseTimeIn] == DBNull.Value ? null : objRow[convWritingOnBBCase.WritingOnBBCaseTimeIn].ToString().Trim(); //案例入库时间
objvWritingOnBBCaseEN.IdStudyLevel = objRow[convWritingOnBBCase.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvWritingOnBBCaseEN.StudyLevelName = objRow[convWritingOnBBCase.StudyLevelName].ToString().Trim(); //学段名称
objvWritingOnBBCaseEN.IsNeedGeneWord = TransNullToBool(objRow[convWritingOnBBCase.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objvWritingOnBBCaseEN.WordCreateDate = objRow[convWritingOnBBCase.WordCreateDate] == DBNull.Value ? null : objRow[convWritingOnBBCase.WordCreateDate].ToString().Trim(); //Word生成日期
objvWritingOnBBCaseEN.DocFile = objRow[convWritingOnBBCase.DocFile] == DBNull.Value ? null : objRow[convWritingOnBBCase.DocFile].ToString().Trim(); //生成的Word文件名
objvWritingOnBBCaseEN.CaseLevelId = objRow[convWritingOnBBCase.CaseLevelId] == DBNull.Value ? null : objRow[convWritingOnBBCase.CaseLevelId].ToString().Trim(); //课例等级Id
objvWritingOnBBCaseEN.IdSenateGaugeVersion = objRow[convWritingOnBBCase.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvWritingOnBBCaseEN.senateGaugeVersionID = objRow[convWritingOnBBCase.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvWritingOnBBCaseEN.senateGaugeVersionName = objRow[convWritingOnBBCase.senateGaugeVersionName] == DBNull.Value ? null : objRow[convWritingOnBBCase.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvWritingOnBBCaseEN.senateGaugeVersionTtlScore = TransNullToFloat(objRow[convWritingOnBBCase.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvWritingOnBBCaseEN.VersionNo = objRow[convWritingOnBBCase.VersionNo] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convWritingOnBBCase.VersionNo].ToString().Trim()); //版本号
objvWritingOnBBCaseEN.IsVisible = TransNullToBool(objRow[convWritingOnBBCase.IsVisible].ToString().Trim()); //是否显示
objvWritingOnBBCaseEN.OwnerId = objRow[convWritingOnBBCase.OwnerId].ToString().Trim(); //拥有者Id
objvWritingOnBBCaseEN.StuName = objRow[convWritingOnBBCase.StuName] == DBNull.Value ? null : objRow[convWritingOnBBCase.StuName].ToString().Trim(); //姓名
objvWritingOnBBCaseEN.StuID = objRow[convWritingOnBBCase.StuID] == DBNull.Value ? null : objRow[convWritingOnBBCase.StuID].ToString().Trim(); //学号
objvWritingOnBBCaseEN.CollegeID = objRow[convWritingOnBBCase.CollegeID] == DBNull.Value ? null : objRow[convWritingOnBBCase.CollegeID].ToString().Trim(); //学院ID
objvWritingOnBBCaseEN.CollegeName = objRow[convWritingOnBBCase.CollegeName].ToString().Trim(); //学院名称
objvWritingOnBBCaseEN.CollegeNameA = objRow[convWritingOnBBCase.CollegeNameA] == DBNull.Value ? null : objRow[convWritingOnBBCase.CollegeNameA].ToString().Trim(); //学院名称简写
objvWritingOnBBCaseEN.IdXzCollege = objRow[convWritingOnBBCase.IdXzCollege] == DBNull.Value ? null : objRow[convWritingOnBBCase.IdXzCollege].ToString().Trim(); //学院流水号
objvWritingOnBBCaseEN.IdXzMajor = objRow[convWritingOnBBCase.IdXzMajor] == DBNull.Value ? null : objRow[convWritingOnBBCase.IdXzMajor].ToString().Trim(); //专业流水号
objvWritingOnBBCaseEN.MajorName = objRow[convWritingOnBBCase.MajorName] == DBNull.Value ? null : objRow[convWritingOnBBCase.MajorName].ToString().Trim(); //专业名称
objvWritingOnBBCaseEN.IdGradeBase = objRow[convWritingOnBBCase.IdGradeBase] == DBNull.Value ? null : objRow[convWritingOnBBCase.IdGradeBase].ToString().Trim(); //年级流水号
objvWritingOnBBCaseEN.GradeBaseName = objRow[convWritingOnBBCase.GradeBaseName] == DBNull.Value ? null : objRow[convWritingOnBBCase.GradeBaseName].ToString().Trim(); //年级名称
objvWritingOnBBCaseEN.IdAdminCls = objRow[convWritingOnBBCase.IdAdminCls] == DBNull.Value ? null : objRow[convWritingOnBBCase.IdAdminCls].ToString().Trim(); //行政班流水号
objvWritingOnBBCaseEN.IsDualVideo = TransNullToBool(objRow[convWritingOnBBCase.IsDualVideo].ToString().Trim()); //是否双视频
objvWritingOnBBCaseEN.IdWritingOnBBCaseType = objRow[convWritingOnBBCase.IdWritingOnBBCaseType].ToString().Trim(); //板书案例类型流水号
objvWritingOnBBCaseEN.WritingOnBBCaseTypeName = objRow[convWritingOnBBCase.WritingOnBBCaseTypeName] == DBNull.Value ? null : objRow[convWritingOnBBCase.WritingOnBBCaseTypeName].ToString().Trim(); //板书案例类型名称
objvWritingOnBBCaseEN.UserTypeId = objRow[convWritingOnBBCase.UserTypeId] == DBNull.Value ? null : objRow[convWritingOnBBCase.UserTypeId].ToString().Trim(); //用户类型Id
objvWritingOnBBCaseEN.UserTypeName = objRow[convWritingOnBBCase.UserTypeName] == DBNull.Value ? null : objRow[convWritingOnBBCase.UserTypeName].ToString().Trim(); //用户类型名称
objvWritingOnBBCaseEN.RecommendedDegreeId = objRow[convWritingOnBBCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvWritingOnBBCaseEN.RecommendedDegreeName = objRow[convWritingOnBBCase.RecommendedDegreeName] == DBNull.Value ? null : objRow[convWritingOnBBCase.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvWritingOnBBCaseEN.ftpFileType = objRow[convWritingOnBBCase.ftpFileType] == DBNull.Value ? null : objRow[convWritingOnBBCase.ftpFileType].ToString().Trim(); //ftp文件类型
objvWritingOnBBCaseEN.VideoUrl = objRow[convWritingOnBBCase.VideoUrl] == DBNull.Value ? null : objRow[convWritingOnBBCase.VideoUrl].ToString().Trim(); //视频Url
objvWritingOnBBCaseEN.VideoPath = objRow[convWritingOnBBCase.VideoPath] == DBNull.Value ? null : objRow[convWritingOnBBCase.VideoPath].ToString().Trim(); //视频目录
objvWritingOnBBCaseEN.ResErrMsg = objRow[convWritingOnBBCase.ResErrMsg] == DBNull.Value ? null : objRow[convWritingOnBBCase.ResErrMsg].ToString().Trim(); //资源错误信息
objvWritingOnBBCaseEN.UpdUserId = objRow[convWritingOnBBCase.UpdUserId] == DBNull.Value ? null : objRow[convWritingOnBBCase.UpdUserId].ToString().Trim(); //修改用户Id
objvWritingOnBBCaseEN.UpdDate = objRow[convWritingOnBBCase.UpdDate] == DBNull.Value ? null : objRow[convWritingOnBBCase.UpdDate].ToString().Trim(); //修改日期
objvWritingOnBBCaseEN.Memo = objRow[convWritingOnBBCase.Memo] == DBNull.Value ? null : objRow[convWritingOnBBCase.Memo].ToString().Trim(); //备注
objvWritingOnBBCaseEN.OwnerNameWithId = objRow[convWritingOnBBCase.OwnerNameWithId] == DBNull.Value ? null : objRow[convWritingOnBBCase.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvWritingOnBBCaseEN.OwnerName = objRow[convWritingOnBBCase.OwnerName] == DBNull.Value ? null : objRow[convWritingOnBBCase.OwnerName].ToString().Trim(); //拥有者姓名
objvWritingOnBBCaseEN.BrowseCount4Case = objRow[convWritingOnBBCase.BrowseCount4Case] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convWritingOnBBCase.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvWritingOnBBCaseEN.IsHaveVideo = objRow[convWritingOnBBCase.IsHaveVideo] == DBNull.Value ? null : objRow[convWritingOnBBCase.IsHaveVideo].ToString().Trim(); //IsHaveVideo
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvWritingOnBBCaseDA: GetObjLst)", objException.Message));
}
objvWritingOnBBCaseEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvWritingOnBBCaseEN);
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
public List<clsvWritingOnBBCaseEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvWritingOnBBCaseDA:GetObjLstByTabName)", objException.Message));
}
List<clsvWritingOnBBCaseEN> arrObjLst = new List<clsvWritingOnBBCaseEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvWritingOnBBCaseDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvWritingOnBBCaseEN objvWritingOnBBCaseEN = new clsvWritingOnBBCaseEN();
try
{
objvWritingOnBBCaseEN.IdWritingOnBBCase = objRow[convWritingOnBBCase.IdWritingOnBBCase].ToString().Trim(); //板书案例流水号
objvWritingOnBBCaseEN.WritingOnBBCaseID = objRow[convWritingOnBBCase.WritingOnBBCaseID].ToString().Trim(); //板书教学案例ID
objvWritingOnBBCaseEN.WritingOnBBCaseName = objRow[convWritingOnBBCase.WritingOnBBCaseName].ToString().Trim(); //板书教学案例名称
objvWritingOnBBCaseEN.WritingOnBBCaseTheme = objRow[convWritingOnBBCase.WritingOnBBCaseTheme] == DBNull.Value ? null : objRow[convWritingOnBBCase.WritingOnBBCaseTheme].ToString().Trim(); //板书教学案例主题词
objvWritingOnBBCaseEN.IdDiscipline = objRow[convWritingOnBBCase.IdDiscipline].ToString().Trim(); //学科流水号
objvWritingOnBBCaseEN.DisciplineID = objRow[convWritingOnBBCase.DisciplineID].ToString().Trim(); //学科ID
objvWritingOnBBCaseEN.DisciplineName = objRow[convWritingOnBBCase.DisciplineName].ToString().Trim(); //学科名称
objvWritingOnBBCaseEN.WritingOnBBCaseDate = objRow[convWritingOnBBCase.WritingOnBBCaseDate] == DBNull.Value ? null : objRow[convWritingOnBBCase.WritingOnBBCaseDate].ToString().Trim(); //板书教学日期
objvWritingOnBBCaseEN.WritingOnBBCaseTime = objRow[convWritingOnBBCase.WritingOnBBCaseTime] == DBNull.Value ? null : objRow[convWritingOnBBCase.WritingOnBBCaseTime].ToString().Trim(); //板书教学时间
objvWritingOnBBCaseEN.WritingOnBBCaseDateIn = objRow[convWritingOnBBCase.WritingOnBBCaseDateIn] == DBNull.Value ? null : objRow[convWritingOnBBCase.WritingOnBBCaseDateIn].ToString().Trim(); //案例入库日期
objvWritingOnBBCaseEN.WritingOnBBCaseTimeIn = objRow[convWritingOnBBCase.WritingOnBBCaseTimeIn] == DBNull.Value ? null : objRow[convWritingOnBBCase.WritingOnBBCaseTimeIn].ToString().Trim(); //案例入库时间
objvWritingOnBBCaseEN.IdStudyLevel = objRow[convWritingOnBBCase.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvWritingOnBBCaseEN.StudyLevelName = objRow[convWritingOnBBCase.StudyLevelName].ToString().Trim(); //学段名称
objvWritingOnBBCaseEN.IsNeedGeneWord = TransNullToBool(objRow[convWritingOnBBCase.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objvWritingOnBBCaseEN.WordCreateDate = objRow[convWritingOnBBCase.WordCreateDate] == DBNull.Value ? null : objRow[convWritingOnBBCase.WordCreateDate].ToString().Trim(); //Word生成日期
objvWritingOnBBCaseEN.DocFile = objRow[convWritingOnBBCase.DocFile] == DBNull.Value ? null : objRow[convWritingOnBBCase.DocFile].ToString().Trim(); //生成的Word文件名
objvWritingOnBBCaseEN.CaseLevelId = objRow[convWritingOnBBCase.CaseLevelId] == DBNull.Value ? null : objRow[convWritingOnBBCase.CaseLevelId].ToString().Trim(); //课例等级Id
objvWritingOnBBCaseEN.IdSenateGaugeVersion = objRow[convWritingOnBBCase.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvWritingOnBBCaseEN.senateGaugeVersionID = objRow[convWritingOnBBCase.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvWritingOnBBCaseEN.senateGaugeVersionName = objRow[convWritingOnBBCase.senateGaugeVersionName] == DBNull.Value ? null : objRow[convWritingOnBBCase.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvWritingOnBBCaseEN.senateGaugeVersionTtlScore = TransNullToFloat(objRow[convWritingOnBBCase.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvWritingOnBBCaseEN.VersionNo = objRow[convWritingOnBBCase.VersionNo] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convWritingOnBBCase.VersionNo].ToString().Trim()); //版本号
objvWritingOnBBCaseEN.IsVisible = TransNullToBool(objRow[convWritingOnBBCase.IsVisible].ToString().Trim()); //是否显示
objvWritingOnBBCaseEN.OwnerId = objRow[convWritingOnBBCase.OwnerId].ToString().Trim(); //拥有者Id
objvWritingOnBBCaseEN.StuName = objRow[convWritingOnBBCase.StuName] == DBNull.Value ? null : objRow[convWritingOnBBCase.StuName].ToString().Trim(); //姓名
objvWritingOnBBCaseEN.StuID = objRow[convWritingOnBBCase.StuID] == DBNull.Value ? null : objRow[convWritingOnBBCase.StuID].ToString().Trim(); //学号
objvWritingOnBBCaseEN.CollegeID = objRow[convWritingOnBBCase.CollegeID] == DBNull.Value ? null : objRow[convWritingOnBBCase.CollegeID].ToString().Trim(); //学院ID
objvWritingOnBBCaseEN.CollegeName = objRow[convWritingOnBBCase.CollegeName].ToString().Trim(); //学院名称
objvWritingOnBBCaseEN.CollegeNameA = objRow[convWritingOnBBCase.CollegeNameA] == DBNull.Value ? null : objRow[convWritingOnBBCase.CollegeNameA].ToString().Trim(); //学院名称简写
objvWritingOnBBCaseEN.IdXzCollege = objRow[convWritingOnBBCase.IdXzCollege] == DBNull.Value ? null : objRow[convWritingOnBBCase.IdXzCollege].ToString().Trim(); //学院流水号
objvWritingOnBBCaseEN.IdXzMajor = objRow[convWritingOnBBCase.IdXzMajor] == DBNull.Value ? null : objRow[convWritingOnBBCase.IdXzMajor].ToString().Trim(); //专业流水号
objvWritingOnBBCaseEN.MajorName = objRow[convWritingOnBBCase.MajorName] == DBNull.Value ? null : objRow[convWritingOnBBCase.MajorName].ToString().Trim(); //专业名称
objvWritingOnBBCaseEN.IdGradeBase = objRow[convWritingOnBBCase.IdGradeBase] == DBNull.Value ? null : objRow[convWritingOnBBCase.IdGradeBase].ToString().Trim(); //年级流水号
objvWritingOnBBCaseEN.GradeBaseName = objRow[convWritingOnBBCase.GradeBaseName] == DBNull.Value ? null : objRow[convWritingOnBBCase.GradeBaseName].ToString().Trim(); //年级名称
objvWritingOnBBCaseEN.IdAdminCls = objRow[convWritingOnBBCase.IdAdminCls] == DBNull.Value ? null : objRow[convWritingOnBBCase.IdAdminCls].ToString().Trim(); //行政班流水号
objvWritingOnBBCaseEN.IsDualVideo = TransNullToBool(objRow[convWritingOnBBCase.IsDualVideo].ToString().Trim()); //是否双视频
objvWritingOnBBCaseEN.IdWritingOnBBCaseType = objRow[convWritingOnBBCase.IdWritingOnBBCaseType].ToString().Trim(); //板书案例类型流水号
objvWritingOnBBCaseEN.WritingOnBBCaseTypeName = objRow[convWritingOnBBCase.WritingOnBBCaseTypeName] == DBNull.Value ? null : objRow[convWritingOnBBCase.WritingOnBBCaseTypeName].ToString().Trim(); //板书案例类型名称
objvWritingOnBBCaseEN.UserTypeId = objRow[convWritingOnBBCase.UserTypeId] == DBNull.Value ? null : objRow[convWritingOnBBCase.UserTypeId].ToString().Trim(); //用户类型Id
objvWritingOnBBCaseEN.UserTypeName = objRow[convWritingOnBBCase.UserTypeName] == DBNull.Value ? null : objRow[convWritingOnBBCase.UserTypeName].ToString().Trim(); //用户类型名称
objvWritingOnBBCaseEN.RecommendedDegreeId = objRow[convWritingOnBBCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvWritingOnBBCaseEN.RecommendedDegreeName = objRow[convWritingOnBBCase.RecommendedDegreeName] == DBNull.Value ? null : objRow[convWritingOnBBCase.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvWritingOnBBCaseEN.ftpFileType = objRow[convWritingOnBBCase.ftpFileType] == DBNull.Value ? null : objRow[convWritingOnBBCase.ftpFileType].ToString().Trim(); //ftp文件类型
objvWritingOnBBCaseEN.VideoUrl = objRow[convWritingOnBBCase.VideoUrl] == DBNull.Value ? null : objRow[convWritingOnBBCase.VideoUrl].ToString().Trim(); //视频Url
objvWritingOnBBCaseEN.VideoPath = objRow[convWritingOnBBCase.VideoPath] == DBNull.Value ? null : objRow[convWritingOnBBCase.VideoPath].ToString().Trim(); //视频目录
objvWritingOnBBCaseEN.ResErrMsg = objRow[convWritingOnBBCase.ResErrMsg] == DBNull.Value ? null : objRow[convWritingOnBBCase.ResErrMsg].ToString().Trim(); //资源错误信息
objvWritingOnBBCaseEN.UpdUserId = objRow[convWritingOnBBCase.UpdUserId] == DBNull.Value ? null : objRow[convWritingOnBBCase.UpdUserId].ToString().Trim(); //修改用户Id
objvWritingOnBBCaseEN.UpdDate = objRow[convWritingOnBBCase.UpdDate] == DBNull.Value ? null : objRow[convWritingOnBBCase.UpdDate].ToString().Trim(); //修改日期
objvWritingOnBBCaseEN.Memo = objRow[convWritingOnBBCase.Memo] == DBNull.Value ? null : objRow[convWritingOnBBCase.Memo].ToString().Trim(); //备注
objvWritingOnBBCaseEN.OwnerNameWithId = objRow[convWritingOnBBCase.OwnerNameWithId] == DBNull.Value ? null : objRow[convWritingOnBBCase.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvWritingOnBBCaseEN.OwnerName = objRow[convWritingOnBBCase.OwnerName] == DBNull.Value ? null : objRow[convWritingOnBBCase.OwnerName].ToString().Trim(); //拥有者姓名
objvWritingOnBBCaseEN.BrowseCount4Case = objRow[convWritingOnBBCase.BrowseCount4Case] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convWritingOnBBCase.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvWritingOnBBCaseEN.IsHaveVideo = objRow[convWritingOnBBCase.IsHaveVideo] == DBNull.Value ? null : objRow[convWritingOnBBCase.IsHaveVideo].ToString().Trim(); //IsHaveVideo
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvWritingOnBBCaseDA: GetObjLst)", objException.Message));
}
objvWritingOnBBCaseEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvWritingOnBBCaseEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvWritingOnBBCaseEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvWritingOnBBCase(ref clsvWritingOnBBCaseEN objvWritingOnBBCaseEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvWritingOnBBCaseDA.GetSpecSQLObj();
strSQL = "Select * from vWritingOnBBCase where IdWritingOnBBCase = " + "'"+ objvWritingOnBBCaseEN.IdWritingOnBBCase+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvWritingOnBBCaseEN.IdWritingOnBBCase = objDT.Rows[0][convWritingOnBBCase.IdWritingOnBBCase].ToString().Trim(); //板书案例流水号(字段类型:char,字段长度:8,是否可空:False)
 objvWritingOnBBCaseEN.WritingOnBBCaseID = objDT.Rows[0][convWritingOnBBCase.WritingOnBBCaseID].ToString().Trim(); //板书教学案例ID(字段类型:char,字段长度:8,是否可空:False)
 objvWritingOnBBCaseEN.WritingOnBBCaseName = objDT.Rows[0][convWritingOnBBCase.WritingOnBBCaseName].ToString().Trim(); //板书教学案例名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvWritingOnBBCaseEN.WritingOnBBCaseTheme = objDT.Rows[0][convWritingOnBBCase.WritingOnBBCaseTheme].ToString().Trim(); //板书教学案例主题词(字段类型:varchar,字段长度:200,是否可空:True)
 objvWritingOnBBCaseEN.IdDiscipline = objDT.Rows[0][convWritingOnBBCase.IdDiscipline].ToString().Trim(); //学科流水号(字段类型:char,字段长度:4,是否可空:False)
 objvWritingOnBBCaseEN.DisciplineID = objDT.Rows[0][convWritingOnBBCase.DisciplineID].ToString().Trim(); //学科ID(字段类型:char,字段长度:4,是否可空:False)
 objvWritingOnBBCaseEN.DisciplineName = objDT.Rows[0][convWritingOnBBCase.DisciplineName].ToString().Trim(); //学科名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvWritingOnBBCaseEN.WritingOnBBCaseDate = objDT.Rows[0][convWritingOnBBCase.WritingOnBBCaseDate].ToString().Trim(); //板书教学日期(字段类型:char,字段长度:8,是否可空:True)
 objvWritingOnBBCaseEN.WritingOnBBCaseTime = objDT.Rows[0][convWritingOnBBCase.WritingOnBBCaseTime].ToString().Trim(); //板书教学时间(字段类型:char,字段长度:6,是否可空:True)
 objvWritingOnBBCaseEN.WritingOnBBCaseDateIn = objDT.Rows[0][convWritingOnBBCase.WritingOnBBCaseDateIn].ToString().Trim(); //案例入库日期(字段类型:char,字段长度:8,是否可空:True)
 objvWritingOnBBCaseEN.WritingOnBBCaseTimeIn = objDT.Rows[0][convWritingOnBBCase.WritingOnBBCaseTimeIn].ToString().Trim(); //案例入库时间(字段类型:char,字段长度:6,是否可空:True)
 objvWritingOnBBCaseEN.IdStudyLevel = objDT.Rows[0][convWritingOnBBCase.IdStudyLevel].ToString().Trim(); //id_StudyLevel(字段类型:char,字段长度:4,是否可空:True)
 objvWritingOnBBCaseEN.StudyLevelName = objDT.Rows[0][convWritingOnBBCase.StudyLevelName].ToString().Trim(); //学段名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvWritingOnBBCaseEN.IsNeedGeneWord = TransNullToBool(objDT.Rows[0][convWritingOnBBCase.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word(字段类型:bit,字段长度:1,是否可空:True)
 objvWritingOnBBCaseEN.WordCreateDate = objDT.Rows[0][convWritingOnBBCase.WordCreateDate].ToString().Trim(); //Word生成日期(字段类型:varchar,字段长度:14,是否可空:True)
 objvWritingOnBBCaseEN.DocFile = objDT.Rows[0][convWritingOnBBCase.DocFile].ToString().Trim(); //生成的Word文件名(字段类型:varchar,字段长度:200,是否可空:True)
 objvWritingOnBBCaseEN.CaseLevelId = objDT.Rows[0][convWritingOnBBCase.CaseLevelId].ToString().Trim(); //课例等级Id(字段类型:char,字段长度:2,是否可空:True)
 objvWritingOnBBCaseEN.IdSenateGaugeVersion = objDT.Rows[0][convWritingOnBBCase.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号(字段类型:char,字段长度:4,是否可空:False)
 objvWritingOnBBCaseEN.senateGaugeVersionID = objDT.Rows[0][convWritingOnBBCase.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID(字段类型:char,字段长度:4,是否可空:False)
 objvWritingOnBBCaseEN.senateGaugeVersionName = objDT.Rows[0][convWritingOnBBCase.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称(字段类型:varchar,字段长度:200,是否可空:True)
 objvWritingOnBBCaseEN.senateGaugeVersionTtlScore = TransNullToFloat(objDT.Rows[0][convWritingOnBBCase.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分(字段类型:float,字段长度:8,是否可空:False)
 objvWritingOnBBCaseEN.VersionNo = TransNullToInt(objDT.Rows[0][convWritingOnBBCase.VersionNo].ToString().Trim()); //版本号(字段类型:int,字段长度:4,是否可空:True)
 objvWritingOnBBCaseEN.IsVisible = TransNullToBool(objDT.Rows[0][convWritingOnBBCase.IsVisible].ToString().Trim()); //是否显示(字段类型:bit,字段长度:1,是否可空:True)
 objvWritingOnBBCaseEN.OwnerId = objDT.Rows[0][convWritingOnBBCase.OwnerId].ToString().Trim(); //拥有者Id(字段类型:varchar,字段长度:20,是否可空:False)
 objvWritingOnBBCaseEN.StuName = objDT.Rows[0][convWritingOnBBCase.StuName].ToString().Trim(); //姓名(字段类型:varchar,字段长度:50,是否可空:True)
 objvWritingOnBBCaseEN.StuID = objDT.Rows[0][convWritingOnBBCase.StuID].ToString().Trim(); //学号(字段类型:varchar,字段长度:20,是否可空:True)
 objvWritingOnBBCaseEN.CollegeID = objDT.Rows[0][convWritingOnBBCase.CollegeID].ToString().Trim(); //学院ID(字段类型:varchar,字段长度:4,是否可空:False)
 objvWritingOnBBCaseEN.CollegeName = objDT.Rows[0][convWritingOnBBCase.CollegeName].ToString().Trim(); //学院名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvWritingOnBBCaseEN.CollegeNameA = objDT.Rows[0][convWritingOnBBCase.CollegeNameA].ToString().Trim(); //学院名称简写(字段类型:varchar,字段长度:12,是否可空:True)
 objvWritingOnBBCaseEN.IdXzCollege = objDT.Rows[0][convWritingOnBBCase.IdXzCollege].ToString().Trim(); //学院流水号(字段类型:char,字段长度:4,是否可空:True)
 objvWritingOnBBCaseEN.IdXzMajor = objDT.Rows[0][convWritingOnBBCase.IdXzMajor].ToString().Trim(); //专业流水号(字段类型:char,字段长度:8,是否可空:False)
 objvWritingOnBBCaseEN.MajorName = objDT.Rows[0][convWritingOnBBCase.MajorName].ToString().Trim(); //专业名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvWritingOnBBCaseEN.IdGradeBase = objDT.Rows[0][convWritingOnBBCase.IdGradeBase].ToString().Trim(); //年级流水号(字段类型:char,字段长度:4,是否可空:True)
 objvWritingOnBBCaseEN.GradeBaseName = objDT.Rows[0][convWritingOnBBCase.GradeBaseName].ToString().Trim(); //年级名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvWritingOnBBCaseEN.IdAdminCls = objDT.Rows[0][convWritingOnBBCase.IdAdminCls].ToString().Trim(); //行政班流水号(字段类型:char,字段长度:8,是否可空:True)
 objvWritingOnBBCaseEN.IsDualVideo = TransNullToBool(objDT.Rows[0][convWritingOnBBCase.IsDualVideo].ToString().Trim()); //是否双视频(字段类型:bit,字段长度:1,是否可空:False)
 objvWritingOnBBCaseEN.IdWritingOnBBCaseType = objDT.Rows[0][convWritingOnBBCase.IdWritingOnBBCaseType].ToString().Trim(); //板书案例类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvWritingOnBBCaseEN.WritingOnBBCaseTypeName = objDT.Rows[0][convWritingOnBBCase.WritingOnBBCaseTypeName].ToString().Trim(); //板书案例类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvWritingOnBBCaseEN.UserTypeId = objDT.Rows[0][convWritingOnBBCase.UserTypeId].ToString().Trim(); //用户类型Id(字段类型:char,字段长度:2,是否可空:True)
 objvWritingOnBBCaseEN.UserTypeName = objDT.Rows[0][convWritingOnBBCase.UserTypeName].ToString().Trim(); //用户类型名称(字段类型:varchar,字段长度:20,是否可空:True)
 objvWritingOnBBCaseEN.RecommendedDegreeId = objDT.Rows[0][convWritingOnBBCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id(字段类型:char,字段长度:2,是否可空:False)
 objvWritingOnBBCaseEN.RecommendedDegreeName = objDT.Rows[0][convWritingOnBBCase.RecommendedDegreeName].ToString().Trim(); //推荐度名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvWritingOnBBCaseEN.ftpFileType = objDT.Rows[0][convWritingOnBBCase.ftpFileType].ToString().Trim(); //ftp文件类型(字段类型:varchar,字段长度:30,是否可空:True)
 objvWritingOnBBCaseEN.VideoUrl = objDT.Rows[0][convWritingOnBBCase.VideoUrl].ToString().Trim(); //视频Url(字段类型:varchar,字段长度:1000,是否可空:True)
 objvWritingOnBBCaseEN.VideoPath = objDT.Rows[0][convWritingOnBBCase.VideoPath].ToString().Trim(); //视频目录(字段类型:varchar,字段长度:1000,是否可空:True)
 objvWritingOnBBCaseEN.ResErrMsg = objDT.Rows[0][convWritingOnBBCase.ResErrMsg].ToString().Trim(); //资源错误信息(字段类型:varchar,字段长度:30,是否可空:True)
 objvWritingOnBBCaseEN.UpdUserId = objDT.Rows[0][convWritingOnBBCase.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:True)
 objvWritingOnBBCaseEN.UpdDate = objDT.Rows[0][convWritingOnBBCase.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvWritingOnBBCaseEN.Memo = objDT.Rows[0][convWritingOnBBCase.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvWritingOnBBCaseEN.OwnerNameWithId = objDT.Rows[0][convWritingOnBBCase.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id(字段类型:varchar,字段长度:51,是否可空:True)
 objvWritingOnBBCaseEN.OwnerName = objDT.Rows[0][convWritingOnBBCase.OwnerName].ToString().Trim(); //拥有者姓名(字段类型:varchar,字段长度:30,是否可空:True)
 objvWritingOnBBCaseEN.BrowseCount4Case = TransNullToInt(objDT.Rows[0][convWritingOnBBCase.BrowseCount4Case].ToString().Trim()); //课例浏览次数(字段类型:int,字段长度:4,是否可空:True)
 objvWritingOnBBCaseEN.IsHaveVideo = objDT.Rows[0][convWritingOnBBCase.IsHaveVideo].ToString().Trim(); //IsHaveVideo(字段类型:varchar,字段长度:6,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvWritingOnBBCaseDA: GetvWritingOnBBCase)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strIdWritingOnBBCase">表关键字</param>
 /// <returns>表对象</returns>
public clsvWritingOnBBCaseEN GetObjByIdWritingOnBBCase(string strIdWritingOnBBCase)
{
CheckPrimaryKey(strIdWritingOnBBCase);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvWritingOnBBCaseDA.GetSpecSQLObj();
strSQL = "Select * from vWritingOnBBCase where IdWritingOnBBCase = " + "'"+ strIdWritingOnBBCase+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvWritingOnBBCaseEN objvWritingOnBBCaseEN = new clsvWritingOnBBCaseEN();
try
{
 objvWritingOnBBCaseEN.IdWritingOnBBCase = objRow[convWritingOnBBCase.IdWritingOnBBCase].ToString().Trim(); //板书案例流水号(字段类型:char,字段长度:8,是否可空:False)
 objvWritingOnBBCaseEN.WritingOnBBCaseID = objRow[convWritingOnBBCase.WritingOnBBCaseID].ToString().Trim(); //板书教学案例ID(字段类型:char,字段长度:8,是否可空:False)
 objvWritingOnBBCaseEN.WritingOnBBCaseName = objRow[convWritingOnBBCase.WritingOnBBCaseName].ToString().Trim(); //板书教学案例名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvWritingOnBBCaseEN.WritingOnBBCaseTheme = objRow[convWritingOnBBCase.WritingOnBBCaseTheme] == DBNull.Value ? null : objRow[convWritingOnBBCase.WritingOnBBCaseTheme].ToString().Trim(); //板书教学案例主题词(字段类型:varchar,字段长度:200,是否可空:True)
 objvWritingOnBBCaseEN.IdDiscipline = objRow[convWritingOnBBCase.IdDiscipline].ToString().Trim(); //学科流水号(字段类型:char,字段长度:4,是否可空:False)
 objvWritingOnBBCaseEN.DisciplineID = objRow[convWritingOnBBCase.DisciplineID].ToString().Trim(); //学科ID(字段类型:char,字段长度:4,是否可空:False)
 objvWritingOnBBCaseEN.DisciplineName = objRow[convWritingOnBBCase.DisciplineName].ToString().Trim(); //学科名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvWritingOnBBCaseEN.WritingOnBBCaseDate = objRow[convWritingOnBBCase.WritingOnBBCaseDate] == DBNull.Value ? null : objRow[convWritingOnBBCase.WritingOnBBCaseDate].ToString().Trim(); //板书教学日期(字段类型:char,字段长度:8,是否可空:True)
 objvWritingOnBBCaseEN.WritingOnBBCaseTime = objRow[convWritingOnBBCase.WritingOnBBCaseTime] == DBNull.Value ? null : objRow[convWritingOnBBCase.WritingOnBBCaseTime].ToString().Trim(); //板书教学时间(字段类型:char,字段长度:6,是否可空:True)
 objvWritingOnBBCaseEN.WritingOnBBCaseDateIn = objRow[convWritingOnBBCase.WritingOnBBCaseDateIn] == DBNull.Value ? null : objRow[convWritingOnBBCase.WritingOnBBCaseDateIn].ToString().Trim(); //案例入库日期(字段类型:char,字段长度:8,是否可空:True)
 objvWritingOnBBCaseEN.WritingOnBBCaseTimeIn = objRow[convWritingOnBBCase.WritingOnBBCaseTimeIn] == DBNull.Value ? null : objRow[convWritingOnBBCase.WritingOnBBCaseTimeIn].ToString().Trim(); //案例入库时间(字段类型:char,字段长度:6,是否可空:True)
 objvWritingOnBBCaseEN.IdStudyLevel = objRow[convWritingOnBBCase.IdStudyLevel].ToString().Trim(); //id_StudyLevel(字段类型:char,字段长度:4,是否可空:True)
 objvWritingOnBBCaseEN.StudyLevelName = objRow[convWritingOnBBCase.StudyLevelName].ToString().Trim(); //学段名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvWritingOnBBCaseEN.IsNeedGeneWord = clsEntityBase2.TransNullToBool_S(objRow[convWritingOnBBCase.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word(字段类型:bit,字段长度:1,是否可空:True)
 objvWritingOnBBCaseEN.WordCreateDate = objRow[convWritingOnBBCase.WordCreateDate] == DBNull.Value ? null : objRow[convWritingOnBBCase.WordCreateDate].ToString().Trim(); //Word生成日期(字段类型:varchar,字段长度:14,是否可空:True)
 objvWritingOnBBCaseEN.DocFile = objRow[convWritingOnBBCase.DocFile] == DBNull.Value ? null : objRow[convWritingOnBBCase.DocFile].ToString().Trim(); //生成的Word文件名(字段类型:varchar,字段长度:200,是否可空:True)
 objvWritingOnBBCaseEN.CaseLevelId = objRow[convWritingOnBBCase.CaseLevelId] == DBNull.Value ? null : objRow[convWritingOnBBCase.CaseLevelId].ToString().Trim(); //课例等级Id(字段类型:char,字段长度:2,是否可空:True)
 objvWritingOnBBCaseEN.IdSenateGaugeVersion = objRow[convWritingOnBBCase.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号(字段类型:char,字段长度:4,是否可空:False)
 objvWritingOnBBCaseEN.senateGaugeVersionID = objRow[convWritingOnBBCase.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID(字段类型:char,字段长度:4,是否可空:False)
 objvWritingOnBBCaseEN.senateGaugeVersionName = objRow[convWritingOnBBCase.senateGaugeVersionName] == DBNull.Value ? null : objRow[convWritingOnBBCase.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称(字段类型:varchar,字段长度:200,是否可空:True)
 objvWritingOnBBCaseEN.senateGaugeVersionTtlScore = Single.Parse(objRow[convWritingOnBBCase.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分(字段类型:float,字段长度:8,是否可空:False)
 objvWritingOnBBCaseEN.VersionNo = objRow[convWritingOnBBCase.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convWritingOnBBCase.VersionNo].ToString().Trim()); //版本号(字段类型:int,字段长度:4,是否可空:True)
 objvWritingOnBBCaseEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convWritingOnBBCase.IsVisible].ToString().Trim()); //是否显示(字段类型:bit,字段长度:1,是否可空:True)
 objvWritingOnBBCaseEN.OwnerId = objRow[convWritingOnBBCase.OwnerId].ToString().Trim(); //拥有者Id(字段类型:varchar,字段长度:20,是否可空:False)
 objvWritingOnBBCaseEN.StuName = objRow[convWritingOnBBCase.StuName] == DBNull.Value ? null : objRow[convWritingOnBBCase.StuName].ToString().Trim(); //姓名(字段类型:varchar,字段长度:50,是否可空:True)
 objvWritingOnBBCaseEN.StuID = objRow[convWritingOnBBCase.StuID] == DBNull.Value ? null : objRow[convWritingOnBBCase.StuID].ToString().Trim(); //学号(字段类型:varchar,字段长度:20,是否可空:True)
 objvWritingOnBBCaseEN.CollegeID = objRow[convWritingOnBBCase.CollegeID] == DBNull.Value ? null : objRow[convWritingOnBBCase.CollegeID].ToString().Trim(); //学院ID(字段类型:varchar,字段长度:4,是否可空:False)
 objvWritingOnBBCaseEN.CollegeName = objRow[convWritingOnBBCase.CollegeName].ToString().Trim(); //学院名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvWritingOnBBCaseEN.CollegeNameA = objRow[convWritingOnBBCase.CollegeNameA] == DBNull.Value ? null : objRow[convWritingOnBBCase.CollegeNameA].ToString().Trim(); //学院名称简写(字段类型:varchar,字段长度:12,是否可空:True)
 objvWritingOnBBCaseEN.IdXzCollege = objRow[convWritingOnBBCase.IdXzCollege] == DBNull.Value ? null : objRow[convWritingOnBBCase.IdXzCollege].ToString().Trim(); //学院流水号(字段类型:char,字段长度:4,是否可空:True)
 objvWritingOnBBCaseEN.IdXzMajor = objRow[convWritingOnBBCase.IdXzMajor] == DBNull.Value ? null : objRow[convWritingOnBBCase.IdXzMajor].ToString().Trim(); //专业流水号(字段类型:char,字段长度:8,是否可空:False)
 objvWritingOnBBCaseEN.MajorName = objRow[convWritingOnBBCase.MajorName] == DBNull.Value ? null : objRow[convWritingOnBBCase.MajorName].ToString().Trim(); //专业名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvWritingOnBBCaseEN.IdGradeBase = objRow[convWritingOnBBCase.IdGradeBase] == DBNull.Value ? null : objRow[convWritingOnBBCase.IdGradeBase].ToString().Trim(); //年级流水号(字段类型:char,字段长度:4,是否可空:True)
 objvWritingOnBBCaseEN.GradeBaseName = objRow[convWritingOnBBCase.GradeBaseName] == DBNull.Value ? null : objRow[convWritingOnBBCase.GradeBaseName].ToString().Trim(); //年级名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvWritingOnBBCaseEN.IdAdminCls = objRow[convWritingOnBBCase.IdAdminCls] == DBNull.Value ? null : objRow[convWritingOnBBCase.IdAdminCls].ToString().Trim(); //行政班流水号(字段类型:char,字段长度:8,是否可空:True)
 objvWritingOnBBCaseEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convWritingOnBBCase.IsDualVideo].ToString().Trim()); //是否双视频(字段类型:bit,字段长度:1,是否可空:False)
 objvWritingOnBBCaseEN.IdWritingOnBBCaseType = objRow[convWritingOnBBCase.IdWritingOnBBCaseType].ToString().Trim(); //板书案例类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvWritingOnBBCaseEN.WritingOnBBCaseTypeName = objRow[convWritingOnBBCase.WritingOnBBCaseTypeName] == DBNull.Value ? null : objRow[convWritingOnBBCase.WritingOnBBCaseTypeName].ToString().Trim(); //板书案例类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvWritingOnBBCaseEN.UserTypeId = objRow[convWritingOnBBCase.UserTypeId] == DBNull.Value ? null : objRow[convWritingOnBBCase.UserTypeId].ToString().Trim(); //用户类型Id(字段类型:char,字段长度:2,是否可空:True)
 objvWritingOnBBCaseEN.UserTypeName = objRow[convWritingOnBBCase.UserTypeName] == DBNull.Value ? null : objRow[convWritingOnBBCase.UserTypeName].ToString().Trim(); //用户类型名称(字段类型:varchar,字段长度:20,是否可空:True)
 objvWritingOnBBCaseEN.RecommendedDegreeId = objRow[convWritingOnBBCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id(字段类型:char,字段长度:2,是否可空:False)
 objvWritingOnBBCaseEN.RecommendedDegreeName = objRow[convWritingOnBBCase.RecommendedDegreeName] == DBNull.Value ? null : objRow[convWritingOnBBCase.RecommendedDegreeName].ToString().Trim(); //推荐度名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvWritingOnBBCaseEN.ftpFileType = objRow[convWritingOnBBCase.ftpFileType] == DBNull.Value ? null : objRow[convWritingOnBBCase.ftpFileType].ToString().Trim(); //ftp文件类型(字段类型:varchar,字段长度:30,是否可空:True)
 objvWritingOnBBCaseEN.VideoUrl = objRow[convWritingOnBBCase.VideoUrl] == DBNull.Value ? null : objRow[convWritingOnBBCase.VideoUrl].ToString().Trim(); //视频Url(字段类型:varchar,字段长度:1000,是否可空:True)
 objvWritingOnBBCaseEN.VideoPath = objRow[convWritingOnBBCase.VideoPath] == DBNull.Value ? null : objRow[convWritingOnBBCase.VideoPath].ToString().Trim(); //视频目录(字段类型:varchar,字段长度:1000,是否可空:True)
 objvWritingOnBBCaseEN.ResErrMsg = objRow[convWritingOnBBCase.ResErrMsg] == DBNull.Value ? null : objRow[convWritingOnBBCase.ResErrMsg].ToString().Trim(); //资源错误信息(字段类型:varchar,字段长度:30,是否可空:True)
 objvWritingOnBBCaseEN.UpdUserId = objRow[convWritingOnBBCase.UpdUserId] == DBNull.Value ? null : objRow[convWritingOnBBCase.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:True)
 objvWritingOnBBCaseEN.UpdDate = objRow[convWritingOnBBCase.UpdDate] == DBNull.Value ? null : objRow[convWritingOnBBCase.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvWritingOnBBCaseEN.Memo = objRow[convWritingOnBBCase.Memo] == DBNull.Value ? null : objRow[convWritingOnBBCase.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvWritingOnBBCaseEN.OwnerNameWithId = objRow[convWritingOnBBCase.OwnerNameWithId] == DBNull.Value ? null : objRow[convWritingOnBBCase.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id(字段类型:varchar,字段长度:51,是否可空:True)
 objvWritingOnBBCaseEN.OwnerName = objRow[convWritingOnBBCase.OwnerName] == DBNull.Value ? null : objRow[convWritingOnBBCase.OwnerName].ToString().Trim(); //拥有者姓名(字段类型:varchar,字段长度:30,是否可空:True)
 objvWritingOnBBCaseEN.BrowseCount4Case = objRow[convWritingOnBBCase.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convWritingOnBBCase.BrowseCount4Case].ToString().Trim()); //课例浏览次数(字段类型:int,字段长度:4,是否可空:True)
 objvWritingOnBBCaseEN.IsHaveVideo = objRow[convWritingOnBBCase.IsHaveVideo] == DBNull.Value ? null : objRow[convWritingOnBBCase.IsHaveVideo].ToString().Trim(); //IsHaveVideo(字段类型:varchar,字段长度:6,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvWritingOnBBCaseDA: GetObjByIdWritingOnBBCase)", objException.Message));
}
return objvWritingOnBBCaseEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvWritingOnBBCaseEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvWritingOnBBCaseDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvWritingOnBBCaseDA.GetSpecSQLObj();
strSQL = "Select * from vWritingOnBBCase where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvWritingOnBBCaseEN objvWritingOnBBCaseEN = new clsvWritingOnBBCaseEN()
{
IdWritingOnBBCase = objRow[convWritingOnBBCase.IdWritingOnBBCase].ToString().Trim(), //板书案例流水号
WritingOnBBCaseID = objRow[convWritingOnBBCase.WritingOnBBCaseID].ToString().Trim(), //板书教学案例ID
WritingOnBBCaseName = objRow[convWritingOnBBCase.WritingOnBBCaseName].ToString().Trim(), //板书教学案例名称
WritingOnBBCaseTheme = objRow[convWritingOnBBCase.WritingOnBBCaseTheme] == DBNull.Value ? null : objRow[convWritingOnBBCase.WritingOnBBCaseTheme].ToString().Trim(), //板书教学案例主题词
IdDiscipline = objRow[convWritingOnBBCase.IdDiscipline].ToString().Trim(), //学科流水号
DisciplineID = objRow[convWritingOnBBCase.DisciplineID].ToString().Trim(), //学科ID
DisciplineName = objRow[convWritingOnBBCase.DisciplineName].ToString().Trim(), //学科名称
WritingOnBBCaseDate = objRow[convWritingOnBBCase.WritingOnBBCaseDate] == DBNull.Value ? null : objRow[convWritingOnBBCase.WritingOnBBCaseDate].ToString().Trim(), //板书教学日期
WritingOnBBCaseTime = objRow[convWritingOnBBCase.WritingOnBBCaseTime] == DBNull.Value ? null : objRow[convWritingOnBBCase.WritingOnBBCaseTime].ToString().Trim(), //板书教学时间
WritingOnBBCaseDateIn = objRow[convWritingOnBBCase.WritingOnBBCaseDateIn] == DBNull.Value ? null : objRow[convWritingOnBBCase.WritingOnBBCaseDateIn].ToString().Trim(), //案例入库日期
WritingOnBBCaseTimeIn = objRow[convWritingOnBBCase.WritingOnBBCaseTimeIn] == DBNull.Value ? null : objRow[convWritingOnBBCase.WritingOnBBCaseTimeIn].ToString().Trim(), //案例入库时间
IdStudyLevel = objRow[convWritingOnBBCase.IdStudyLevel].ToString().Trim(), //id_StudyLevel
StudyLevelName = objRow[convWritingOnBBCase.StudyLevelName].ToString().Trim(), //学段名称
IsNeedGeneWord = TransNullToBool(objRow[convWritingOnBBCase.IsNeedGeneWord].ToString().Trim()), //是否需要生成Word
WordCreateDate = objRow[convWritingOnBBCase.WordCreateDate] == DBNull.Value ? null : objRow[convWritingOnBBCase.WordCreateDate].ToString().Trim(), //Word生成日期
DocFile = objRow[convWritingOnBBCase.DocFile] == DBNull.Value ? null : objRow[convWritingOnBBCase.DocFile].ToString().Trim(), //生成的Word文件名
CaseLevelId = objRow[convWritingOnBBCase.CaseLevelId] == DBNull.Value ? null : objRow[convWritingOnBBCase.CaseLevelId].ToString().Trim(), //课例等级Id
IdSenateGaugeVersion = objRow[convWritingOnBBCase.IdSenateGaugeVersion].ToString().Trim(), //评价量表版本流水号
senateGaugeVersionID = objRow[convWritingOnBBCase.senateGaugeVersionID].ToString().Trim(), //评价量表版本ID
senateGaugeVersionName = objRow[convWritingOnBBCase.senateGaugeVersionName] == DBNull.Value ? null : objRow[convWritingOnBBCase.senateGaugeVersionName].ToString().Trim(), //评价量表版本名称
senateGaugeVersionTtlScore = TransNullToFloat(objRow[convWritingOnBBCase.senateGaugeVersionTtlScore].ToString().Trim()), //评价量表版本总分
VersionNo = objRow[convWritingOnBBCase.VersionNo] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convWritingOnBBCase.VersionNo].ToString().Trim()), //版本号
IsVisible = TransNullToBool(objRow[convWritingOnBBCase.IsVisible].ToString().Trim()), //是否显示
OwnerId = objRow[convWritingOnBBCase.OwnerId].ToString().Trim(), //拥有者Id
StuName = objRow[convWritingOnBBCase.StuName] == DBNull.Value ? null : objRow[convWritingOnBBCase.StuName].ToString().Trim(), //姓名
StuID = objRow[convWritingOnBBCase.StuID] == DBNull.Value ? null : objRow[convWritingOnBBCase.StuID].ToString().Trim(), //学号
CollegeID = objRow[convWritingOnBBCase.CollegeID] == DBNull.Value ? null : objRow[convWritingOnBBCase.CollegeID].ToString().Trim(), //学院ID
CollegeName = objRow[convWritingOnBBCase.CollegeName].ToString().Trim(), //学院名称
CollegeNameA = objRow[convWritingOnBBCase.CollegeNameA] == DBNull.Value ? null : objRow[convWritingOnBBCase.CollegeNameA].ToString().Trim(), //学院名称简写
IdXzCollege = objRow[convWritingOnBBCase.IdXzCollege] == DBNull.Value ? null : objRow[convWritingOnBBCase.IdXzCollege].ToString().Trim(), //学院流水号
IdXzMajor = objRow[convWritingOnBBCase.IdXzMajor] == DBNull.Value ? null : objRow[convWritingOnBBCase.IdXzMajor].ToString().Trim(), //专业流水号
MajorName = objRow[convWritingOnBBCase.MajorName] == DBNull.Value ? null : objRow[convWritingOnBBCase.MajorName].ToString().Trim(), //专业名称
IdGradeBase = objRow[convWritingOnBBCase.IdGradeBase] == DBNull.Value ? null : objRow[convWritingOnBBCase.IdGradeBase].ToString().Trim(), //年级流水号
GradeBaseName = objRow[convWritingOnBBCase.GradeBaseName] == DBNull.Value ? null : objRow[convWritingOnBBCase.GradeBaseName].ToString().Trim(), //年级名称
IdAdminCls = objRow[convWritingOnBBCase.IdAdminCls] == DBNull.Value ? null : objRow[convWritingOnBBCase.IdAdminCls].ToString().Trim(), //行政班流水号
IsDualVideo = TransNullToBool(objRow[convWritingOnBBCase.IsDualVideo].ToString().Trim()), //是否双视频
IdWritingOnBBCaseType = objRow[convWritingOnBBCase.IdWritingOnBBCaseType].ToString().Trim(), //板书案例类型流水号
WritingOnBBCaseTypeName = objRow[convWritingOnBBCase.WritingOnBBCaseTypeName] == DBNull.Value ? null : objRow[convWritingOnBBCase.WritingOnBBCaseTypeName].ToString().Trim(), //板书案例类型名称
UserTypeId = objRow[convWritingOnBBCase.UserTypeId] == DBNull.Value ? null : objRow[convWritingOnBBCase.UserTypeId].ToString().Trim(), //用户类型Id
UserTypeName = objRow[convWritingOnBBCase.UserTypeName] == DBNull.Value ? null : objRow[convWritingOnBBCase.UserTypeName].ToString().Trim(), //用户类型名称
RecommendedDegreeId = objRow[convWritingOnBBCase.RecommendedDegreeId].ToString().Trim(), //推荐度Id
RecommendedDegreeName = objRow[convWritingOnBBCase.RecommendedDegreeName] == DBNull.Value ? null : objRow[convWritingOnBBCase.RecommendedDegreeName].ToString().Trim(), //推荐度名称
ftpFileType = objRow[convWritingOnBBCase.ftpFileType] == DBNull.Value ? null : objRow[convWritingOnBBCase.ftpFileType].ToString().Trim(), //ftp文件类型
VideoUrl = objRow[convWritingOnBBCase.VideoUrl] == DBNull.Value ? null : objRow[convWritingOnBBCase.VideoUrl].ToString().Trim(), //视频Url
VideoPath = objRow[convWritingOnBBCase.VideoPath] == DBNull.Value ? null : objRow[convWritingOnBBCase.VideoPath].ToString().Trim(), //视频目录
ResErrMsg = objRow[convWritingOnBBCase.ResErrMsg] == DBNull.Value ? null : objRow[convWritingOnBBCase.ResErrMsg].ToString().Trim(), //资源错误信息
UpdUserId = objRow[convWritingOnBBCase.UpdUserId] == DBNull.Value ? null : objRow[convWritingOnBBCase.UpdUserId].ToString().Trim(), //修改用户Id
UpdDate = objRow[convWritingOnBBCase.UpdDate] == DBNull.Value ? null : objRow[convWritingOnBBCase.UpdDate].ToString().Trim(), //修改日期
Memo = objRow[convWritingOnBBCase.Memo] == DBNull.Value ? null : objRow[convWritingOnBBCase.Memo].ToString().Trim(), //备注
OwnerNameWithId = objRow[convWritingOnBBCase.OwnerNameWithId] == DBNull.Value ? null : objRow[convWritingOnBBCase.OwnerNameWithId].ToString().Trim(), //拥有者名称附Id
OwnerName = objRow[convWritingOnBBCase.OwnerName] == DBNull.Value ? null : objRow[convWritingOnBBCase.OwnerName].ToString().Trim(), //拥有者姓名
BrowseCount4Case = objRow[convWritingOnBBCase.BrowseCount4Case] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convWritingOnBBCase.BrowseCount4Case].ToString().Trim()), //课例浏览次数
IsHaveVideo = objRow[convWritingOnBBCase.IsHaveVideo] == DBNull.Value ? null : objRow[convWritingOnBBCase.IsHaveVideo].ToString().Trim() //IsHaveVideo
};
objvWritingOnBBCaseEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvWritingOnBBCaseEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvWritingOnBBCaseDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvWritingOnBBCaseEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvWritingOnBBCaseEN objvWritingOnBBCaseEN = new clsvWritingOnBBCaseEN();
try
{
objvWritingOnBBCaseEN.IdWritingOnBBCase = objRow[convWritingOnBBCase.IdWritingOnBBCase].ToString().Trim(); //板书案例流水号
objvWritingOnBBCaseEN.WritingOnBBCaseID = objRow[convWritingOnBBCase.WritingOnBBCaseID].ToString().Trim(); //板书教学案例ID
objvWritingOnBBCaseEN.WritingOnBBCaseName = objRow[convWritingOnBBCase.WritingOnBBCaseName].ToString().Trim(); //板书教学案例名称
objvWritingOnBBCaseEN.WritingOnBBCaseTheme = objRow[convWritingOnBBCase.WritingOnBBCaseTheme] == DBNull.Value ? null : objRow[convWritingOnBBCase.WritingOnBBCaseTheme].ToString().Trim(); //板书教学案例主题词
objvWritingOnBBCaseEN.IdDiscipline = objRow[convWritingOnBBCase.IdDiscipline].ToString().Trim(); //学科流水号
objvWritingOnBBCaseEN.DisciplineID = objRow[convWritingOnBBCase.DisciplineID].ToString().Trim(); //学科ID
objvWritingOnBBCaseEN.DisciplineName = objRow[convWritingOnBBCase.DisciplineName].ToString().Trim(); //学科名称
objvWritingOnBBCaseEN.WritingOnBBCaseDate = objRow[convWritingOnBBCase.WritingOnBBCaseDate] == DBNull.Value ? null : objRow[convWritingOnBBCase.WritingOnBBCaseDate].ToString().Trim(); //板书教学日期
objvWritingOnBBCaseEN.WritingOnBBCaseTime = objRow[convWritingOnBBCase.WritingOnBBCaseTime] == DBNull.Value ? null : objRow[convWritingOnBBCase.WritingOnBBCaseTime].ToString().Trim(); //板书教学时间
objvWritingOnBBCaseEN.WritingOnBBCaseDateIn = objRow[convWritingOnBBCase.WritingOnBBCaseDateIn] == DBNull.Value ? null : objRow[convWritingOnBBCase.WritingOnBBCaseDateIn].ToString().Trim(); //案例入库日期
objvWritingOnBBCaseEN.WritingOnBBCaseTimeIn = objRow[convWritingOnBBCase.WritingOnBBCaseTimeIn] == DBNull.Value ? null : objRow[convWritingOnBBCase.WritingOnBBCaseTimeIn].ToString().Trim(); //案例入库时间
objvWritingOnBBCaseEN.IdStudyLevel = objRow[convWritingOnBBCase.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvWritingOnBBCaseEN.StudyLevelName = objRow[convWritingOnBBCase.StudyLevelName].ToString().Trim(); //学段名称
objvWritingOnBBCaseEN.IsNeedGeneWord = TransNullToBool(objRow[convWritingOnBBCase.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objvWritingOnBBCaseEN.WordCreateDate = objRow[convWritingOnBBCase.WordCreateDate] == DBNull.Value ? null : objRow[convWritingOnBBCase.WordCreateDate].ToString().Trim(); //Word生成日期
objvWritingOnBBCaseEN.DocFile = objRow[convWritingOnBBCase.DocFile] == DBNull.Value ? null : objRow[convWritingOnBBCase.DocFile].ToString().Trim(); //生成的Word文件名
objvWritingOnBBCaseEN.CaseLevelId = objRow[convWritingOnBBCase.CaseLevelId] == DBNull.Value ? null : objRow[convWritingOnBBCase.CaseLevelId].ToString().Trim(); //课例等级Id
objvWritingOnBBCaseEN.IdSenateGaugeVersion = objRow[convWritingOnBBCase.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvWritingOnBBCaseEN.senateGaugeVersionID = objRow[convWritingOnBBCase.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvWritingOnBBCaseEN.senateGaugeVersionName = objRow[convWritingOnBBCase.senateGaugeVersionName] == DBNull.Value ? null : objRow[convWritingOnBBCase.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvWritingOnBBCaseEN.senateGaugeVersionTtlScore = TransNullToFloat(objRow[convWritingOnBBCase.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvWritingOnBBCaseEN.VersionNo = objRow[convWritingOnBBCase.VersionNo] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convWritingOnBBCase.VersionNo].ToString().Trim()); //版本号
objvWritingOnBBCaseEN.IsVisible = TransNullToBool(objRow[convWritingOnBBCase.IsVisible].ToString().Trim()); //是否显示
objvWritingOnBBCaseEN.OwnerId = objRow[convWritingOnBBCase.OwnerId].ToString().Trim(); //拥有者Id
objvWritingOnBBCaseEN.StuName = objRow[convWritingOnBBCase.StuName] == DBNull.Value ? null : objRow[convWritingOnBBCase.StuName].ToString().Trim(); //姓名
objvWritingOnBBCaseEN.StuID = objRow[convWritingOnBBCase.StuID] == DBNull.Value ? null : objRow[convWritingOnBBCase.StuID].ToString().Trim(); //学号
objvWritingOnBBCaseEN.CollegeID = objRow[convWritingOnBBCase.CollegeID] == DBNull.Value ? null : objRow[convWritingOnBBCase.CollegeID].ToString().Trim(); //学院ID
objvWritingOnBBCaseEN.CollegeName = objRow[convWritingOnBBCase.CollegeName].ToString().Trim(); //学院名称
objvWritingOnBBCaseEN.CollegeNameA = objRow[convWritingOnBBCase.CollegeNameA] == DBNull.Value ? null : objRow[convWritingOnBBCase.CollegeNameA].ToString().Trim(); //学院名称简写
objvWritingOnBBCaseEN.IdXzCollege = objRow[convWritingOnBBCase.IdXzCollege] == DBNull.Value ? null : objRow[convWritingOnBBCase.IdXzCollege].ToString().Trim(); //学院流水号
objvWritingOnBBCaseEN.IdXzMajor = objRow[convWritingOnBBCase.IdXzMajor] == DBNull.Value ? null : objRow[convWritingOnBBCase.IdXzMajor].ToString().Trim(); //专业流水号
objvWritingOnBBCaseEN.MajorName = objRow[convWritingOnBBCase.MajorName] == DBNull.Value ? null : objRow[convWritingOnBBCase.MajorName].ToString().Trim(); //专业名称
objvWritingOnBBCaseEN.IdGradeBase = objRow[convWritingOnBBCase.IdGradeBase] == DBNull.Value ? null : objRow[convWritingOnBBCase.IdGradeBase].ToString().Trim(); //年级流水号
objvWritingOnBBCaseEN.GradeBaseName = objRow[convWritingOnBBCase.GradeBaseName] == DBNull.Value ? null : objRow[convWritingOnBBCase.GradeBaseName].ToString().Trim(); //年级名称
objvWritingOnBBCaseEN.IdAdminCls = objRow[convWritingOnBBCase.IdAdminCls] == DBNull.Value ? null : objRow[convWritingOnBBCase.IdAdminCls].ToString().Trim(); //行政班流水号
objvWritingOnBBCaseEN.IsDualVideo = TransNullToBool(objRow[convWritingOnBBCase.IsDualVideo].ToString().Trim()); //是否双视频
objvWritingOnBBCaseEN.IdWritingOnBBCaseType = objRow[convWritingOnBBCase.IdWritingOnBBCaseType].ToString().Trim(); //板书案例类型流水号
objvWritingOnBBCaseEN.WritingOnBBCaseTypeName = objRow[convWritingOnBBCase.WritingOnBBCaseTypeName] == DBNull.Value ? null : objRow[convWritingOnBBCase.WritingOnBBCaseTypeName].ToString().Trim(); //板书案例类型名称
objvWritingOnBBCaseEN.UserTypeId = objRow[convWritingOnBBCase.UserTypeId] == DBNull.Value ? null : objRow[convWritingOnBBCase.UserTypeId].ToString().Trim(); //用户类型Id
objvWritingOnBBCaseEN.UserTypeName = objRow[convWritingOnBBCase.UserTypeName] == DBNull.Value ? null : objRow[convWritingOnBBCase.UserTypeName].ToString().Trim(); //用户类型名称
objvWritingOnBBCaseEN.RecommendedDegreeId = objRow[convWritingOnBBCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvWritingOnBBCaseEN.RecommendedDegreeName = objRow[convWritingOnBBCase.RecommendedDegreeName] == DBNull.Value ? null : objRow[convWritingOnBBCase.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvWritingOnBBCaseEN.ftpFileType = objRow[convWritingOnBBCase.ftpFileType] == DBNull.Value ? null : objRow[convWritingOnBBCase.ftpFileType].ToString().Trim(); //ftp文件类型
objvWritingOnBBCaseEN.VideoUrl = objRow[convWritingOnBBCase.VideoUrl] == DBNull.Value ? null : objRow[convWritingOnBBCase.VideoUrl].ToString().Trim(); //视频Url
objvWritingOnBBCaseEN.VideoPath = objRow[convWritingOnBBCase.VideoPath] == DBNull.Value ? null : objRow[convWritingOnBBCase.VideoPath].ToString().Trim(); //视频目录
objvWritingOnBBCaseEN.ResErrMsg = objRow[convWritingOnBBCase.ResErrMsg] == DBNull.Value ? null : objRow[convWritingOnBBCase.ResErrMsg].ToString().Trim(); //资源错误信息
objvWritingOnBBCaseEN.UpdUserId = objRow[convWritingOnBBCase.UpdUserId] == DBNull.Value ? null : objRow[convWritingOnBBCase.UpdUserId].ToString().Trim(); //修改用户Id
objvWritingOnBBCaseEN.UpdDate = objRow[convWritingOnBBCase.UpdDate] == DBNull.Value ? null : objRow[convWritingOnBBCase.UpdDate].ToString().Trim(); //修改日期
objvWritingOnBBCaseEN.Memo = objRow[convWritingOnBBCase.Memo] == DBNull.Value ? null : objRow[convWritingOnBBCase.Memo].ToString().Trim(); //备注
objvWritingOnBBCaseEN.OwnerNameWithId = objRow[convWritingOnBBCase.OwnerNameWithId] == DBNull.Value ? null : objRow[convWritingOnBBCase.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvWritingOnBBCaseEN.OwnerName = objRow[convWritingOnBBCase.OwnerName] == DBNull.Value ? null : objRow[convWritingOnBBCase.OwnerName].ToString().Trim(); //拥有者姓名
objvWritingOnBBCaseEN.BrowseCount4Case = objRow[convWritingOnBBCase.BrowseCount4Case] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convWritingOnBBCase.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvWritingOnBBCaseEN.IsHaveVideo = objRow[convWritingOnBBCase.IsHaveVideo] == DBNull.Value ? null : objRow[convWritingOnBBCase.IsHaveVideo].ToString().Trim(); //IsHaveVideo
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvWritingOnBBCaseDA: GetObjByDataRowvWritingOnBBCase)", objException.Message));
}
objvWritingOnBBCaseEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvWritingOnBBCaseEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvWritingOnBBCaseEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvWritingOnBBCaseEN objvWritingOnBBCaseEN = new clsvWritingOnBBCaseEN();
try
{
objvWritingOnBBCaseEN.IdWritingOnBBCase = objRow[convWritingOnBBCase.IdWritingOnBBCase].ToString().Trim(); //板书案例流水号
objvWritingOnBBCaseEN.WritingOnBBCaseID = objRow[convWritingOnBBCase.WritingOnBBCaseID].ToString().Trim(); //板书教学案例ID
objvWritingOnBBCaseEN.WritingOnBBCaseName = objRow[convWritingOnBBCase.WritingOnBBCaseName].ToString().Trim(); //板书教学案例名称
objvWritingOnBBCaseEN.WritingOnBBCaseTheme = objRow[convWritingOnBBCase.WritingOnBBCaseTheme] == DBNull.Value ? null : objRow[convWritingOnBBCase.WritingOnBBCaseTheme].ToString().Trim(); //板书教学案例主题词
objvWritingOnBBCaseEN.IdDiscipline = objRow[convWritingOnBBCase.IdDiscipline].ToString().Trim(); //学科流水号
objvWritingOnBBCaseEN.DisciplineID = objRow[convWritingOnBBCase.DisciplineID].ToString().Trim(); //学科ID
objvWritingOnBBCaseEN.DisciplineName = objRow[convWritingOnBBCase.DisciplineName].ToString().Trim(); //学科名称
objvWritingOnBBCaseEN.WritingOnBBCaseDate = objRow[convWritingOnBBCase.WritingOnBBCaseDate] == DBNull.Value ? null : objRow[convWritingOnBBCase.WritingOnBBCaseDate].ToString().Trim(); //板书教学日期
objvWritingOnBBCaseEN.WritingOnBBCaseTime = objRow[convWritingOnBBCase.WritingOnBBCaseTime] == DBNull.Value ? null : objRow[convWritingOnBBCase.WritingOnBBCaseTime].ToString().Trim(); //板书教学时间
objvWritingOnBBCaseEN.WritingOnBBCaseDateIn = objRow[convWritingOnBBCase.WritingOnBBCaseDateIn] == DBNull.Value ? null : objRow[convWritingOnBBCase.WritingOnBBCaseDateIn].ToString().Trim(); //案例入库日期
objvWritingOnBBCaseEN.WritingOnBBCaseTimeIn = objRow[convWritingOnBBCase.WritingOnBBCaseTimeIn] == DBNull.Value ? null : objRow[convWritingOnBBCase.WritingOnBBCaseTimeIn].ToString().Trim(); //案例入库时间
objvWritingOnBBCaseEN.IdStudyLevel = objRow[convWritingOnBBCase.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvWritingOnBBCaseEN.StudyLevelName = objRow[convWritingOnBBCase.StudyLevelName].ToString().Trim(); //学段名称
objvWritingOnBBCaseEN.IsNeedGeneWord = TransNullToBool(objRow[convWritingOnBBCase.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objvWritingOnBBCaseEN.WordCreateDate = objRow[convWritingOnBBCase.WordCreateDate] == DBNull.Value ? null : objRow[convWritingOnBBCase.WordCreateDate].ToString().Trim(); //Word生成日期
objvWritingOnBBCaseEN.DocFile = objRow[convWritingOnBBCase.DocFile] == DBNull.Value ? null : objRow[convWritingOnBBCase.DocFile].ToString().Trim(); //生成的Word文件名
objvWritingOnBBCaseEN.CaseLevelId = objRow[convWritingOnBBCase.CaseLevelId] == DBNull.Value ? null : objRow[convWritingOnBBCase.CaseLevelId].ToString().Trim(); //课例等级Id
objvWritingOnBBCaseEN.IdSenateGaugeVersion = objRow[convWritingOnBBCase.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvWritingOnBBCaseEN.senateGaugeVersionID = objRow[convWritingOnBBCase.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvWritingOnBBCaseEN.senateGaugeVersionName = objRow[convWritingOnBBCase.senateGaugeVersionName] == DBNull.Value ? null : objRow[convWritingOnBBCase.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvWritingOnBBCaseEN.senateGaugeVersionTtlScore = TransNullToFloat(objRow[convWritingOnBBCase.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvWritingOnBBCaseEN.VersionNo = objRow[convWritingOnBBCase.VersionNo] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convWritingOnBBCase.VersionNo].ToString().Trim()); //版本号
objvWritingOnBBCaseEN.IsVisible = TransNullToBool(objRow[convWritingOnBBCase.IsVisible].ToString().Trim()); //是否显示
objvWritingOnBBCaseEN.OwnerId = objRow[convWritingOnBBCase.OwnerId].ToString().Trim(); //拥有者Id
objvWritingOnBBCaseEN.StuName = objRow[convWritingOnBBCase.StuName] == DBNull.Value ? null : objRow[convWritingOnBBCase.StuName].ToString().Trim(); //姓名
objvWritingOnBBCaseEN.StuID = objRow[convWritingOnBBCase.StuID] == DBNull.Value ? null : objRow[convWritingOnBBCase.StuID].ToString().Trim(); //学号
objvWritingOnBBCaseEN.CollegeID = objRow[convWritingOnBBCase.CollegeID] == DBNull.Value ? null : objRow[convWritingOnBBCase.CollegeID].ToString().Trim(); //学院ID
objvWritingOnBBCaseEN.CollegeName = objRow[convWritingOnBBCase.CollegeName].ToString().Trim(); //学院名称
objvWritingOnBBCaseEN.CollegeNameA = objRow[convWritingOnBBCase.CollegeNameA] == DBNull.Value ? null : objRow[convWritingOnBBCase.CollegeNameA].ToString().Trim(); //学院名称简写
objvWritingOnBBCaseEN.IdXzCollege = objRow[convWritingOnBBCase.IdXzCollege] == DBNull.Value ? null : objRow[convWritingOnBBCase.IdXzCollege].ToString().Trim(); //学院流水号
objvWritingOnBBCaseEN.IdXzMajor = objRow[convWritingOnBBCase.IdXzMajor] == DBNull.Value ? null : objRow[convWritingOnBBCase.IdXzMajor].ToString().Trim(); //专业流水号
objvWritingOnBBCaseEN.MajorName = objRow[convWritingOnBBCase.MajorName] == DBNull.Value ? null : objRow[convWritingOnBBCase.MajorName].ToString().Trim(); //专业名称
objvWritingOnBBCaseEN.IdGradeBase = objRow[convWritingOnBBCase.IdGradeBase] == DBNull.Value ? null : objRow[convWritingOnBBCase.IdGradeBase].ToString().Trim(); //年级流水号
objvWritingOnBBCaseEN.GradeBaseName = objRow[convWritingOnBBCase.GradeBaseName] == DBNull.Value ? null : objRow[convWritingOnBBCase.GradeBaseName].ToString().Trim(); //年级名称
objvWritingOnBBCaseEN.IdAdminCls = objRow[convWritingOnBBCase.IdAdminCls] == DBNull.Value ? null : objRow[convWritingOnBBCase.IdAdminCls].ToString().Trim(); //行政班流水号
objvWritingOnBBCaseEN.IsDualVideo = TransNullToBool(objRow[convWritingOnBBCase.IsDualVideo].ToString().Trim()); //是否双视频
objvWritingOnBBCaseEN.IdWritingOnBBCaseType = objRow[convWritingOnBBCase.IdWritingOnBBCaseType].ToString().Trim(); //板书案例类型流水号
objvWritingOnBBCaseEN.WritingOnBBCaseTypeName = objRow[convWritingOnBBCase.WritingOnBBCaseTypeName] == DBNull.Value ? null : objRow[convWritingOnBBCase.WritingOnBBCaseTypeName].ToString().Trim(); //板书案例类型名称
objvWritingOnBBCaseEN.UserTypeId = objRow[convWritingOnBBCase.UserTypeId] == DBNull.Value ? null : objRow[convWritingOnBBCase.UserTypeId].ToString().Trim(); //用户类型Id
objvWritingOnBBCaseEN.UserTypeName = objRow[convWritingOnBBCase.UserTypeName] == DBNull.Value ? null : objRow[convWritingOnBBCase.UserTypeName].ToString().Trim(); //用户类型名称
objvWritingOnBBCaseEN.RecommendedDegreeId = objRow[convWritingOnBBCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvWritingOnBBCaseEN.RecommendedDegreeName = objRow[convWritingOnBBCase.RecommendedDegreeName] == DBNull.Value ? null : objRow[convWritingOnBBCase.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvWritingOnBBCaseEN.ftpFileType = objRow[convWritingOnBBCase.ftpFileType] == DBNull.Value ? null : objRow[convWritingOnBBCase.ftpFileType].ToString().Trim(); //ftp文件类型
objvWritingOnBBCaseEN.VideoUrl = objRow[convWritingOnBBCase.VideoUrl] == DBNull.Value ? null : objRow[convWritingOnBBCase.VideoUrl].ToString().Trim(); //视频Url
objvWritingOnBBCaseEN.VideoPath = objRow[convWritingOnBBCase.VideoPath] == DBNull.Value ? null : objRow[convWritingOnBBCase.VideoPath].ToString().Trim(); //视频目录
objvWritingOnBBCaseEN.ResErrMsg = objRow[convWritingOnBBCase.ResErrMsg] == DBNull.Value ? null : objRow[convWritingOnBBCase.ResErrMsg].ToString().Trim(); //资源错误信息
objvWritingOnBBCaseEN.UpdUserId = objRow[convWritingOnBBCase.UpdUserId] == DBNull.Value ? null : objRow[convWritingOnBBCase.UpdUserId].ToString().Trim(); //修改用户Id
objvWritingOnBBCaseEN.UpdDate = objRow[convWritingOnBBCase.UpdDate] == DBNull.Value ? null : objRow[convWritingOnBBCase.UpdDate].ToString().Trim(); //修改日期
objvWritingOnBBCaseEN.Memo = objRow[convWritingOnBBCase.Memo] == DBNull.Value ? null : objRow[convWritingOnBBCase.Memo].ToString().Trim(); //备注
objvWritingOnBBCaseEN.OwnerNameWithId = objRow[convWritingOnBBCase.OwnerNameWithId] == DBNull.Value ? null : objRow[convWritingOnBBCase.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvWritingOnBBCaseEN.OwnerName = objRow[convWritingOnBBCase.OwnerName] == DBNull.Value ? null : objRow[convWritingOnBBCase.OwnerName].ToString().Trim(); //拥有者姓名
objvWritingOnBBCaseEN.BrowseCount4Case = objRow[convWritingOnBBCase.BrowseCount4Case] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convWritingOnBBCase.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvWritingOnBBCaseEN.IsHaveVideo = objRow[convWritingOnBBCase.IsHaveVideo] == DBNull.Value ? null : objRow[convWritingOnBBCase.IsHaveVideo].ToString().Trim(); //IsHaveVideo
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvWritingOnBBCaseDA: GetObjByDataRow)", objException.Message));
}
objvWritingOnBBCaseEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvWritingOnBBCaseEN;
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
objSQL = clsvWritingOnBBCaseDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvWritingOnBBCaseEN._CurrTabName, convWritingOnBBCase.IdWritingOnBBCase, 8, "");
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
objSQL = clsvWritingOnBBCaseDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvWritingOnBBCaseEN._CurrTabName, convWritingOnBBCase.IdWritingOnBBCase, 8, strPrefix);
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
 objSQL = clsvWritingOnBBCaseDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select IdWritingOnBBCase from vWritingOnBBCase where " + strCondition;
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
 objSQL = clsvWritingOnBBCaseDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select IdWritingOnBBCase from vWritingOnBBCase where " + strCondition;
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
 objSQL = clsvWritingOnBBCaseDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vWritingOnBBCase", "IdWritingOnBBCase = " + "'"+ strIdWritingOnBBCase+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvWritingOnBBCaseDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvWritingOnBBCaseDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vWritingOnBBCase", strCondition))
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
objSQL = clsvWritingOnBBCaseDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vWritingOnBBCase");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvWritingOnBBCaseENS">源对象</param>
 /// <param name = "objvWritingOnBBCaseENT">目标对象</param>
public void CopyTo(clsvWritingOnBBCaseEN objvWritingOnBBCaseENS, clsvWritingOnBBCaseEN objvWritingOnBBCaseENT)
{
objvWritingOnBBCaseENT.IdWritingOnBBCase = objvWritingOnBBCaseENS.IdWritingOnBBCase; //板书案例流水号
objvWritingOnBBCaseENT.WritingOnBBCaseID = objvWritingOnBBCaseENS.WritingOnBBCaseID; //板书教学案例ID
objvWritingOnBBCaseENT.WritingOnBBCaseName = objvWritingOnBBCaseENS.WritingOnBBCaseName; //板书教学案例名称
objvWritingOnBBCaseENT.WritingOnBBCaseTheme = objvWritingOnBBCaseENS.WritingOnBBCaseTheme; //板书教学案例主题词
objvWritingOnBBCaseENT.IdDiscipline = objvWritingOnBBCaseENS.IdDiscipline; //学科流水号
objvWritingOnBBCaseENT.DisciplineID = objvWritingOnBBCaseENS.DisciplineID; //学科ID
objvWritingOnBBCaseENT.DisciplineName = objvWritingOnBBCaseENS.DisciplineName; //学科名称
objvWritingOnBBCaseENT.WritingOnBBCaseDate = objvWritingOnBBCaseENS.WritingOnBBCaseDate; //板书教学日期
objvWritingOnBBCaseENT.WritingOnBBCaseTime = objvWritingOnBBCaseENS.WritingOnBBCaseTime; //板书教学时间
objvWritingOnBBCaseENT.WritingOnBBCaseDateIn = objvWritingOnBBCaseENS.WritingOnBBCaseDateIn; //案例入库日期
objvWritingOnBBCaseENT.WritingOnBBCaseTimeIn = objvWritingOnBBCaseENS.WritingOnBBCaseTimeIn; //案例入库时间
objvWritingOnBBCaseENT.IdStudyLevel = objvWritingOnBBCaseENS.IdStudyLevel; //id_StudyLevel
objvWritingOnBBCaseENT.StudyLevelName = objvWritingOnBBCaseENS.StudyLevelName; //学段名称
objvWritingOnBBCaseENT.IsNeedGeneWord = objvWritingOnBBCaseENS.IsNeedGeneWord; //是否需要生成Word
objvWritingOnBBCaseENT.WordCreateDate = objvWritingOnBBCaseENS.WordCreateDate; //Word生成日期
objvWritingOnBBCaseENT.DocFile = objvWritingOnBBCaseENS.DocFile; //生成的Word文件名
objvWritingOnBBCaseENT.CaseLevelId = objvWritingOnBBCaseENS.CaseLevelId; //课例等级Id
objvWritingOnBBCaseENT.IdSenateGaugeVersion = objvWritingOnBBCaseENS.IdSenateGaugeVersion; //评价量表版本流水号
objvWritingOnBBCaseENT.senateGaugeVersionID = objvWritingOnBBCaseENS.senateGaugeVersionID; //评价量表版本ID
objvWritingOnBBCaseENT.senateGaugeVersionName = objvWritingOnBBCaseENS.senateGaugeVersionName; //评价量表版本名称
objvWritingOnBBCaseENT.senateGaugeVersionTtlScore = objvWritingOnBBCaseENS.senateGaugeVersionTtlScore; //评价量表版本总分
objvWritingOnBBCaseENT.VersionNo = objvWritingOnBBCaseENS.VersionNo; //版本号
objvWritingOnBBCaseENT.IsVisible = objvWritingOnBBCaseENS.IsVisible; //是否显示
objvWritingOnBBCaseENT.OwnerId = objvWritingOnBBCaseENS.OwnerId; //拥有者Id
objvWritingOnBBCaseENT.StuName = objvWritingOnBBCaseENS.StuName; //姓名
objvWritingOnBBCaseENT.StuID = objvWritingOnBBCaseENS.StuID; //学号
objvWritingOnBBCaseENT.CollegeID = objvWritingOnBBCaseENS.CollegeID; //学院ID
objvWritingOnBBCaseENT.CollegeName = objvWritingOnBBCaseENS.CollegeName; //学院名称
objvWritingOnBBCaseENT.CollegeNameA = objvWritingOnBBCaseENS.CollegeNameA; //学院名称简写
objvWritingOnBBCaseENT.IdXzCollege = objvWritingOnBBCaseENS.IdXzCollege; //学院流水号
objvWritingOnBBCaseENT.IdXzMajor = objvWritingOnBBCaseENS.IdXzMajor; //专业流水号
objvWritingOnBBCaseENT.MajorName = objvWritingOnBBCaseENS.MajorName; //专业名称
objvWritingOnBBCaseENT.IdGradeBase = objvWritingOnBBCaseENS.IdGradeBase; //年级流水号
objvWritingOnBBCaseENT.GradeBaseName = objvWritingOnBBCaseENS.GradeBaseName; //年级名称
objvWritingOnBBCaseENT.IdAdminCls = objvWritingOnBBCaseENS.IdAdminCls; //行政班流水号
objvWritingOnBBCaseENT.IsDualVideo = objvWritingOnBBCaseENS.IsDualVideo; //是否双视频
objvWritingOnBBCaseENT.IdWritingOnBBCaseType = objvWritingOnBBCaseENS.IdWritingOnBBCaseType; //板书案例类型流水号
objvWritingOnBBCaseENT.WritingOnBBCaseTypeName = objvWritingOnBBCaseENS.WritingOnBBCaseTypeName; //板书案例类型名称
objvWritingOnBBCaseENT.UserTypeId = objvWritingOnBBCaseENS.UserTypeId; //用户类型Id
objvWritingOnBBCaseENT.UserTypeName = objvWritingOnBBCaseENS.UserTypeName; //用户类型名称
objvWritingOnBBCaseENT.RecommendedDegreeId = objvWritingOnBBCaseENS.RecommendedDegreeId; //推荐度Id
objvWritingOnBBCaseENT.RecommendedDegreeName = objvWritingOnBBCaseENS.RecommendedDegreeName; //推荐度名称
objvWritingOnBBCaseENT.ftpFileType = objvWritingOnBBCaseENS.ftpFileType; //ftp文件类型
objvWritingOnBBCaseENT.VideoUrl = objvWritingOnBBCaseENS.VideoUrl; //视频Url
objvWritingOnBBCaseENT.VideoPath = objvWritingOnBBCaseENS.VideoPath; //视频目录
objvWritingOnBBCaseENT.ResErrMsg = objvWritingOnBBCaseENS.ResErrMsg; //资源错误信息
objvWritingOnBBCaseENT.UpdUserId = objvWritingOnBBCaseENS.UpdUserId; //修改用户Id
objvWritingOnBBCaseENT.UpdDate = objvWritingOnBBCaseENS.UpdDate; //修改日期
objvWritingOnBBCaseENT.Memo = objvWritingOnBBCaseENS.Memo; //备注
objvWritingOnBBCaseENT.OwnerNameWithId = objvWritingOnBBCaseENS.OwnerNameWithId; //拥有者名称附Id
objvWritingOnBBCaseENT.OwnerName = objvWritingOnBBCaseENS.OwnerName; //拥有者姓名
objvWritingOnBBCaseENT.BrowseCount4Case = objvWritingOnBBCaseENS.BrowseCount4Case; //课例浏览次数
objvWritingOnBBCaseENT.IsHaveVideo = objvWritingOnBBCaseENS.IsHaveVideo; //IsHaveVideo
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvWritingOnBBCaseEN objvWritingOnBBCaseEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvWritingOnBBCaseEN.IdWritingOnBBCase, 8, convWritingOnBBCase.IdWritingOnBBCase);
clsCheckSql.CheckFieldLen(objvWritingOnBBCaseEN.WritingOnBBCaseID, 8, convWritingOnBBCase.WritingOnBBCaseID);
clsCheckSql.CheckFieldLen(objvWritingOnBBCaseEN.WritingOnBBCaseName, 100, convWritingOnBBCase.WritingOnBBCaseName);
clsCheckSql.CheckFieldLen(objvWritingOnBBCaseEN.WritingOnBBCaseTheme, 200, convWritingOnBBCase.WritingOnBBCaseTheme);
clsCheckSql.CheckFieldLen(objvWritingOnBBCaseEN.IdDiscipline, 4, convWritingOnBBCase.IdDiscipline);
clsCheckSql.CheckFieldLen(objvWritingOnBBCaseEN.DisciplineID, 4, convWritingOnBBCase.DisciplineID);
clsCheckSql.CheckFieldLen(objvWritingOnBBCaseEN.DisciplineName, 50, convWritingOnBBCase.DisciplineName);
clsCheckSql.CheckFieldLen(objvWritingOnBBCaseEN.WritingOnBBCaseDate, 8, convWritingOnBBCase.WritingOnBBCaseDate);
clsCheckSql.CheckFieldLen(objvWritingOnBBCaseEN.WritingOnBBCaseTime, 6, convWritingOnBBCase.WritingOnBBCaseTime);
clsCheckSql.CheckFieldLen(objvWritingOnBBCaseEN.WritingOnBBCaseDateIn, 8, convWritingOnBBCase.WritingOnBBCaseDateIn);
clsCheckSql.CheckFieldLen(objvWritingOnBBCaseEN.WritingOnBBCaseTimeIn, 6, convWritingOnBBCase.WritingOnBBCaseTimeIn);
clsCheckSql.CheckFieldLen(objvWritingOnBBCaseEN.IdStudyLevel, 4, convWritingOnBBCase.IdStudyLevel);
clsCheckSql.CheckFieldLen(objvWritingOnBBCaseEN.StudyLevelName, 50, convWritingOnBBCase.StudyLevelName);
clsCheckSql.CheckFieldLen(objvWritingOnBBCaseEN.WordCreateDate, 14, convWritingOnBBCase.WordCreateDate);
clsCheckSql.CheckFieldLen(objvWritingOnBBCaseEN.DocFile, 200, convWritingOnBBCase.DocFile);
clsCheckSql.CheckFieldLen(objvWritingOnBBCaseEN.CaseLevelId, 2, convWritingOnBBCase.CaseLevelId);
clsCheckSql.CheckFieldLen(objvWritingOnBBCaseEN.IdSenateGaugeVersion, 4, convWritingOnBBCase.IdSenateGaugeVersion);
clsCheckSql.CheckFieldLen(objvWritingOnBBCaseEN.senateGaugeVersionID, 4, convWritingOnBBCase.senateGaugeVersionID);
clsCheckSql.CheckFieldLen(objvWritingOnBBCaseEN.senateGaugeVersionName, 200, convWritingOnBBCase.senateGaugeVersionName);
clsCheckSql.CheckFieldLen(objvWritingOnBBCaseEN.OwnerId, 20, convWritingOnBBCase.OwnerId);
clsCheckSql.CheckFieldLen(objvWritingOnBBCaseEN.StuName, 50, convWritingOnBBCase.StuName);
clsCheckSql.CheckFieldLen(objvWritingOnBBCaseEN.StuID, 20, convWritingOnBBCase.StuID);
clsCheckSql.CheckFieldLen(objvWritingOnBBCaseEN.CollegeID, 4, convWritingOnBBCase.CollegeID);
clsCheckSql.CheckFieldLen(objvWritingOnBBCaseEN.CollegeName, 100, convWritingOnBBCase.CollegeName);
clsCheckSql.CheckFieldLen(objvWritingOnBBCaseEN.CollegeNameA, 12, convWritingOnBBCase.CollegeNameA);
clsCheckSql.CheckFieldLen(objvWritingOnBBCaseEN.IdXzCollege, 4, convWritingOnBBCase.IdXzCollege);
clsCheckSql.CheckFieldLen(objvWritingOnBBCaseEN.IdXzMajor, 8, convWritingOnBBCase.IdXzMajor);
clsCheckSql.CheckFieldLen(objvWritingOnBBCaseEN.MajorName, 100, convWritingOnBBCase.MajorName);
clsCheckSql.CheckFieldLen(objvWritingOnBBCaseEN.IdGradeBase, 4, convWritingOnBBCase.IdGradeBase);
clsCheckSql.CheckFieldLen(objvWritingOnBBCaseEN.GradeBaseName, 50, convWritingOnBBCase.GradeBaseName);
clsCheckSql.CheckFieldLen(objvWritingOnBBCaseEN.IdAdminCls, 8, convWritingOnBBCase.IdAdminCls);
clsCheckSql.CheckFieldLen(objvWritingOnBBCaseEN.IdWritingOnBBCaseType, 4, convWritingOnBBCase.IdWritingOnBBCaseType);
clsCheckSql.CheckFieldLen(objvWritingOnBBCaseEN.WritingOnBBCaseTypeName, 50, convWritingOnBBCase.WritingOnBBCaseTypeName);
clsCheckSql.CheckFieldLen(objvWritingOnBBCaseEN.UserTypeId, 2, convWritingOnBBCase.UserTypeId);
clsCheckSql.CheckFieldLen(objvWritingOnBBCaseEN.UserTypeName, 20, convWritingOnBBCase.UserTypeName);
clsCheckSql.CheckFieldLen(objvWritingOnBBCaseEN.RecommendedDegreeId, 2, convWritingOnBBCase.RecommendedDegreeId);
clsCheckSql.CheckFieldLen(objvWritingOnBBCaseEN.RecommendedDegreeName, 30, convWritingOnBBCase.RecommendedDegreeName);
clsCheckSql.CheckFieldLen(objvWritingOnBBCaseEN.ftpFileType, 30, convWritingOnBBCase.ftpFileType);
clsCheckSql.CheckFieldLen(objvWritingOnBBCaseEN.VideoUrl, 1000, convWritingOnBBCase.VideoUrl);
clsCheckSql.CheckFieldLen(objvWritingOnBBCaseEN.VideoPath, 1000, convWritingOnBBCase.VideoPath);
clsCheckSql.CheckFieldLen(objvWritingOnBBCaseEN.ResErrMsg, 30, convWritingOnBBCase.ResErrMsg);
clsCheckSql.CheckFieldLen(objvWritingOnBBCaseEN.UpdUserId, 20, convWritingOnBBCase.UpdUserId);
clsCheckSql.CheckFieldLen(objvWritingOnBBCaseEN.UpdDate, 20, convWritingOnBBCase.UpdDate);
clsCheckSql.CheckFieldLen(objvWritingOnBBCaseEN.Memo, 1000, convWritingOnBBCase.Memo);
clsCheckSql.CheckFieldLen(objvWritingOnBBCaseEN.OwnerNameWithId, 51, convWritingOnBBCase.OwnerNameWithId);
clsCheckSql.CheckFieldLen(objvWritingOnBBCaseEN.OwnerName, 30, convWritingOnBBCase.OwnerName);
clsCheckSql.CheckFieldLen(objvWritingOnBBCaseEN.IsHaveVideo, 6, convWritingOnBBCase.IsHaveVideo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvWritingOnBBCaseEN.IdWritingOnBBCase, convWritingOnBBCase.IdWritingOnBBCase);
clsCheckSql.CheckSqlInjection4Field(objvWritingOnBBCaseEN.WritingOnBBCaseID, convWritingOnBBCase.WritingOnBBCaseID);
clsCheckSql.CheckSqlInjection4Field(objvWritingOnBBCaseEN.WritingOnBBCaseName, convWritingOnBBCase.WritingOnBBCaseName);
clsCheckSql.CheckSqlInjection4Field(objvWritingOnBBCaseEN.WritingOnBBCaseTheme, convWritingOnBBCase.WritingOnBBCaseTheme);
clsCheckSql.CheckSqlInjection4Field(objvWritingOnBBCaseEN.IdDiscipline, convWritingOnBBCase.IdDiscipline);
clsCheckSql.CheckSqlInjection4Field(objvWritingOnBBCaseEN.DisciplineID, convWritingOnBBCase.DisciplineID);
clsCheckSql.CheckSqlInjection4Field(objvWritingOnBBCaseEN.DisciplineName, convWritingOnBBCase.DisciplineName);
clsCheckSql.CheckSqlInjection4Field(objvWritingOnBBCaseEN.WritingOnBBCaseDate, convWritingOnBBCase.WritingOnBBCaseDate);
clsCheckSql.CheckSqlInjection4Field(objvWritingOnBBCaseEN.WritingOnBBCaseTime, convWritingOnBBCase.WritingOnBBCaseTime);
clsCheckSql.CheckSqlInjection4Field(objvWritingOnBBCaseEN.WritingOnBBCaseDateIn, convWritingOnBBCase.WritingOnBBCaseDateIn);
clsCheckSql.CheckSqlInjection4Field(objvWritingOnBBCaseEN.WritingOnBBCaseTimeIn, convWritingOnBBCase.WritingOnBBCaseTimeIn);
clsCheckSql.CheckSqlInjection4Field(objvWritingOnBBCaseEN.IdStudyLevel, convWritingOnBBCase.IdStudyLevel);
clsCheckSql.CheckSqlInjection4Field(objvWritingOnBBCaseEN.StudyLevelName, convWritingOnBBCase.StudyLevelName);
clsCheckSql.CheckSqlInjection4Field(objvWritingOnBBCaseEN.WordCreateDate, convWritingOnBBCase.WordCreateDate);
clsCheckSql.CheckSqlInjection4Field(objvWritingOnBBCaseEN.DocFile, convWritingOnBBCase.DocFile);
clsCheckSql.CheckSqlInjection4Field(objvWritingOnBBCaseEN.CaseLevelId, convWritingOnBBCase.CaseLevelId);
clsCheckSql.CheckSqlInjection4Field(objvWritingOnBBCaseEN.IdSenateGaugeVersion, convWritingOnBBCase.IdSenateGaugeVersion);
clsCheckSql.CheckSqlInjection4Field(objvWritingOnBBCaseEN.senateGaugeVersionID, convWritingOnBBCase.senateGaugeVersionID);
clsCheckSql.CheckSqlInjection4Field(objvWritingOnBBCaseEN.senateGaugeVersionName, convWritingOnBBCase.senateGaugeVersionName);
clsCheckSql.CheckSqlInjection4Field(objvWritingOnBBCaseEN.OwnerId, convWritingOnBBCase.OwnerId);
clsCheckSql.CheckSqlInjection4Field(objvWritingOnBBCaseEN.StuName, convWritingOnBBCase.StuName);
clsCheckSql.CheckSqlInjection4Field(objvWritingOnBBCaseEN.StuID, convWritingOnBBCase.StuID);
clsCheckSql.CheckSqlInjection4Field(objvWritingOnBBCaseEN.CollegeID, convWritingOnBBCase.CollegeID);
clsCheckSql.CheckSqlInjection4Field(objvWritingOnBBCaseEN.CollegeName, convWritingOnBBCase.CollegeName);
clsCheckSql.CheckSqlInjection4Field(objvWritingOnBBCaseEN.CollegeNameA, convWritingOnBBCase.CollegeNameA);
clsCheckSql.CheckSqlInjection4Field(objvWritingOnBBCaseEN.IdXzCollege, convWritingOnBBCase.IdXzCollege);
clsCheckSql.CheckSqlInjection4Field(objvWritingOnBBCaseEN.IdXzMajor, convWritingOnBBCase.IdXzMajor);
clsCheckSql.CheckSqlInjection4Field(objvWritingOnBBCaseEN.MajorName, convWritingOnBBCase.MajorName);
clsCheckSql.CheckSqlInjection4Field(objvWritingOnBBCaseEN.IdGradeBase, convWritingOnBBCase.IdGradeBase);
clsCheckSql.CheckSqlInjection4Field(objvWritingOnBBCaseEN.GradeBaseName, convWritingOnBBCase.GradeBaseName);
clsCheckSql.CheckSqlInjection4Field(objvWritingOnBBCaseEN.IdAdminCls, convWritingOnBBCase.IdAdminCls);
clsCheckSql.CheckSqlInjection4Field(objvWritingOnBBCaseEN.IdWritingOnBBCaseType, convWritingOnBBCase.IdWritingOnBBCaseType);
clsCheckSql.CheckSqlInjection4Field(objvWritingOnBBCaseEN.WritingOnBBCaseTypeName, convWritingOnBBCase.WritingOnBBCaseTypeName);
clsCheckSql.CheckSqlInjection4Field(objvWritingOnBBCaseEN.UserTypeId, convWritingOnBBCase.UserTypeId);
clsCheckSql.CheckSqlInjection4Field(objvWritingOnBBCaseEN.UserTypeName, convWritingOnBBCase.UserTypeName);
clsCheckSql.CheckSqlInjection4Field(objvWritingOnBBCaseEN.RecommendedDegreeId, convWritingOnBBCase.RecommendedDegreeId);
clsCheckSql.CheckSqlInjection4Field(objvWritingOnBBCaseEN.RecommendedDegreeName, convWritingOnBBCase.RecommendedDegreeName);
clsCheckSql.CheckSqlInjection4Field(objvWritingOnBBCaseEN.ftpFileType, convWritingOnBBCase.ftpFileType);
clsCheckSql.CheckSqlInjection4Field(objvWritingOnBBCaseEN.VideoUrl, convWritingOnBBCase.VideoUrl);
clsCheckSql.CheckSqlInjection4Field(objvWritingOnBBCaseEN.VideoPath, convWritingOnBBCase.VideoPath);
clsCheckSql.CheckSqlInjection4Field(objvWritingOnBBCaseEN.ResErrMsg, convWritingOnBBCase.ResErrMsg);
clsCheckSql.CheckSqlInjection4Field(objvWritingOnBBCaseEN.UpdUserId, convWritingOnBBCase.UpdUserId);
clsCheckSql.CheckSqlInjection4Field(objvWritingOnBBCaseEN.UpdDate, convWritingOnBBCase.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objvWritingOnBBCaseEN.Memo, convWritingOnBBCase.Memo);
clsCheckSql.CheckSqlInjection4Field(objvWritingOnBBCaseEN.OwnerNameWithId, convWritingOnBBCase.OwnerNameWithId);
clsCheckSql.CheckSqlInjection4Field(objvWritingOnBBCaseEN.OwnerName, convWritingOnBBCase.OwnerName);
clsCheckSql.CheckSqlInjection4Field(objvWritingOnBBCaseEN.IsHaveVideo, convWritingOnBBCase.IsHaveVideo);
//检查外键字段长度
 objvWritingOnBBCaseEN._IsCheckProperty = true;
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
 objSQL = clsvWritingOnBBCaseDA.GetSpecSQLObj();
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
 objSQL = clsvWritingOnBBCaseDA.GetSpecSQLObj();
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
 objSQL = clsvWritingOnBBCaseDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvWritingOnBBCaseEN._CurrTabName);
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
 objSQL = clsvWritingOnBBCaseDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvWritingOnBBCaseEN._CurrTabName, strCondition);
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
 objSQL = clsvWritingOnBBCaseDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}