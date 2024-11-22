
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsPubClassCaseDA
 表名:PubClassCase(01120385)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:21:18
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
 /// 公开课案例(PubClassCase)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsPubClassCaseDA : clsCommBase4DA
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
 return clsPubClassCaseEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsPubClassCaseEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsPubClassCaseEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsPubClassCaseEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsPubClassCaseEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strIdPubClassCase">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strIdPubClassCase)
{
strIdPubClassCase = strIdPubClassCase.Replace("'", "''");
if (strIdPubClassCase.Length > 8)
{
throw new Exception("(errid:Data000001)在表:PubClassCase中,检查关键字,长度不正确!(clsPubClassCaseDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strIdPubClassCase)  ==  true)
{
throw new Exception("(errid:Data000002)在表:PubClassCase中,关键字不能为空 或 null!(clsPubClassCaseDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strIdPubClassCase);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsPubClassCaseDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsPubClassCaseDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPubClassCaseDA.GetSpecSQLObj();
strSQL = "Select * from PubClassCase where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_PubClassCase(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsPubClassCaseDA: GetDataTable_PubClassCase)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPubClassCaseDA.GetSpecSQLObj();
strSQL = "Select * from PubClassCase where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsPubClassCaseDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPubClassCaseDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsPubClassCaseDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPubClassCaseDA.GetSpecSQLObj();
strSQL = "Select * from PubClassCase where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsPubClassCaseDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPubClassCaseDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsPubClassCaseDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPubClassCaseDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from PubClassCase where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from PubClassCase where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsPubClassCaseDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPubClassCaseDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from PubClassCase where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsPubClassCaseDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPubClassCaseDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} PubClassCase.* from PubClassCase Left Join {1} on {2} where {3} and PubClassCase.IdPubClassCase not in (Select top {5} PubClassCase.IdPubClassCase from PubClassCase Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from PubClassCase where {1} and IdPubClassCase not in (Select top {2} IdPubClassCase from PubClassCase where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from PubClassCase where {1} and IdPubClassCase not in (Select top {3} IdPubClassCase from PubClassCase where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsPubClassCaseDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPubClassCaseDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} PubClassCase.* from PubClassCase Left Join {1} on {2} where {3} and PubClassCase.IdPubClassCase not in (Select top {5} PubClassCase.IdPubClassCase from PubClassCase Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from PubClassCase where {1} and IdPubClassCase not in (Select top {2} IdPubClassCase from PubClassCase where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from PubClassCase where {1} and IdPubClassCase not in (Select top {3} IdPubClassCase from PubClassCase where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsPubClassCaseEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsPubClassCaseDA:GetObjLst)", objException.Message));
}
List<clsPubClassCaseEN> arrObjLst = new List<clsPubClassCaseEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPubClassCaseDA.GetSpecSQLObj();
strSQL = "Select * from PubClassCase where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPubClassCaseEN objPubClassCaseEN = new clsPubClassCaseEN();
try
{
objPubClassCaseEN.IdPubClassCase = objRow[conPubClassCase.IdPubClassCase].ToString().Trim(); //案例流水号
objPubClassCaseEN.PubClassCaseID = objRow[conPubClassCase.PubClassCaseID].ToString().Trim(); //案例ID
objPubClassCaseEN.PubClassCaseName = objRow[conPubClassCase.PubClassCaseName].ToString().Trim(); //案例课题名称
objPubClassCaseEN.PubClassCaseExecutor = objRow[conPubClassCase.PubClassCaseExecutor] == DBNull.Value ? null : objRow[conPubClassCase.PubClassCaseExecutor].ToString().Trim(); //案例执教者
objPubClassCaseEN.WorkUnit = objRow[conPubClassCase.WorkUnit] == DBNull.Value ? null : objRow[conPubClassCase.WorkUnit].ToString().Trim(); //工作单位
objPubClassCaseEN.PubClassCaseTheme = objRow[conPubClassCase.PubClassCaseTheme] == DBNull.Value ? null : objRow[conPubClassCase.PubClassCaseTheme].ToString().Trim(); //案例主题词
objPubClassCaseEN.PubClassCaseBG = objRow[conPubClassCase.PubClassCaseBG] == DBNull.Value ? null : objRow[conPubClassCase.PubClassCaseBG].ToString().Trim(); //案例背景资料
objPubClassCaseEN.PubClassCaseTeachDate = objRow[conPubClassCase.PubClassCaseTeachDate] == DBNull.Value ? null : objRow[conPubClassCase.PubClassCaseTeachDate].ToString().Trim(); //案例授课日期
objPubClassCaseEN.PubClassCaseDateIn = objRow[conPubClassCase.PubClassCaseDateIn] == DBNull.Value ? null : objRow[conPubClassCase.PubClassCaseDateIn].ToString().Trim(); //案例入库日期
objPubClassCaseEN.IdDiscipline = objRow[conPubClassCase.IdDiscipline].ToString().Trim(); //学科流水号
objPubClassCaseEN.IdTeachingPlan = objRow[conPubClassCase.IdTeachingPlan] == DBNull.Value ? null : objRow[conPubClassCase.IdTeachingPlan].ToString().Trim(); //教案流水号
objPubClassCaseEN.PubClassCaseTimeIn = objRow[conPubClassCase.PubClassCaseTimeIn] == DBNull.Value ? null : objRow[conPubClassCase.PubClassCaseTimeIn].ToString().Trim(); //案例入库时间
objPubClassCaseEN.IdPubClassCaseSenateGaugeVersion = objRow[conPubClassCase.IdPubClassCaseSenateGaugeVersion].ToString().Trim(); //公开课量表版本流水号
objPubClassCaseEN.BrowseCount = objRow[conPubClassCase.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conPubClassCase.BrowseCount].ToString().Trim()); //浏览次数
objPubClassCaseEN.IdPubCaseType = objRow[conPubClassCase.IdPubCaseType] == DBNull.Value ? null : objRow[conPubClassCase.IdPubCaseType].ToString().Trim(); //公开课案例类型流水号
objPubClassCaseEN.IdStudyLevel = objRow[conPubClassCase.IdStudyLevel] == DBNull.Value ? null : objRow[conPubClassCase.IdStudyLevel].ToString().Trim(); //学段流水号
objPubClassCaseEN.CDID = objRow[conPubClassCase.CDID] == DBNull.Value ? null : objRow[conPubClassCase.CDID].ToString().Trim(); //光盘编号
objPubClassCaseEN.Introduction = objRow[conPubClassCase.Introduction] == DBNull.Value ? null : objRow[conPubClassCase.Introduction].ToString().Trim(); //简要介绍
objPubClassCaseEN.IsVisible = TransNullToBool(objRow[conPubClassCase.IsVisible].ToString().Trim()); //是否显示
objPubClassCaseEN.IsDualVideo = TransNullToBool(objRow[conPubClassCase.IsDualVideo].ToString().Trim()); //是否双视频
objPubClassCaseEN.RecommendedDegreeId = objRow[conPubClassCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objPubClassCaseEN.ftpFileType = objRow[conPubClassCase.ftpFileType] == DBNull.Value ? null : objRow[conPubClassCase.ftpFileType].ToString().Trim(); //ftp文件类型
objPubClassCaseEN.VideoUrl = objRow[conPubClassCase.VideoUrl] == DBNull.Value ? null : objRow[conPubClassCase.VideoUrl].ToString().Trim(); //视频Url
objPubClassCaseEN.VideoPath = objRow[conPubClassCase.VideoPath] == DBNull.Value ? null : objRow[conPubClassCase.VideoPath].ToString().Trim(); //视频目录
objPubClassCaseEN.ResErrMsg = objRow[conPubClassCase.ResErrMsg] == DBNull.Value ? null : objRow[conPubClassCase.ResErrMsg].ToString().Trim(); //资源错误信息
objPubClassCaseEN.UpdDate = objRow[conPubClassCase.UpdDate] == DBNull.Value ? null : objRow[conPubClassCase.UpdDate].ToString().Trim(); //修改日期
objPubClassCaseEN.UpdUserId = objRow[conPubClassCase.UpdUserId] == DBNull.Value ? null : objRow[conPubClassCase.UpdUserId].ToString().Trim(); //修改用户Id
objPubClassCaseEN.Memo = objRow[conPubClassCase.Memo] == DBNull.Value ? null : objRow[conPubClassCase.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsPubClassCaseDA: GetObjLst)", objException.Message));
}
objPubClassCaseEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objPubClassCaseEN);
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
public List<clsPubClassCaseEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsPubClassCaseDA:GetObjLstByTabName)", objException.Message));
}
List<clsPubClassCaseEN> arrObjLst = new List<clsPubClassCaseEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPubClassCaseDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPubClassCaseEN objPubClassCaseEN = new clsPubClassCaseEN();
try
{
objPubClassCaseEN.IdPubClassCase = objRow[conPubClassCase.IdPubClassCase].ToString().Trim(); //案例流水号
objPubClassCaseEN.PubClassCaseID = objRow[conPubClassCase.PubClassCaseID].ToString().Trim(); //案例ID
objPubClassCaseEN.PubClassCaseName = objRow[conPubClassCase.PubClassCaseName].ToString().Trim(); //案例课题名称
objPubClassCaseEN.PubClassCaseExecutor = objRow[conPubClassCase.PubClassCaseExecutor] == DBNull.Value ? null : objRow[conPubClassCase.PubClassCaseExecutor].ToString().Trim(); //案例执教者
objPubClassCaseEN.WorkUnit = objRow[conPubClassCase.WorkUnit] == DBNull.Value ? null : objRow[conPubClassCase.WorkUnit].ToString().Trim(); //工作单位
objPubClassCaseEN.PubClassCaseTheme = objRow[conPubClassCase.PubClassCaseTheme] == DBNull.Value ? null : objRow[conPubClassCase.PubClassCaseTheme].ToString().Trim(); //案例主题词
objPubClassCaseEN.PubClassCaseBG = objRow[conPubClassCase.PubClassCaseBG] == DBNull.Value ? null : objRow[conPubClassCase.PubClassCaseBG].ToString().Trim(); //案例背景资料
objPubClassCaseEN.PubClassCaseTeachDate = objRow[conPubClassCase.PubClassCaseTeachDate] == DBNull.Value ? null : objRow[conPubClassCase.PubClassCaseTeachDate].ToString().Trim(); //案例授课日期
objPubClassCaseEN.PubClassCaseDateIn = objRow[conPubClassCase.PubClassCaseDateIn] == DBNull.Value ? null : objRow[conPubClassCase.PubClassCaseDateIn].ToString().Trim(); //案例入库日期
objPubClassCaseEN.IdDiscipline = objRow[conPubClassCase.IdDiscipline].ToString().Trim(); //学科流水号
objPubClassCaseEN.IdTeachingPlan = objRow[conPubClassCase.IdTeachingPlan] == DBNull.Value ? null : objRow[conPubClassCase.IdTeachingPlan].ToString().Trim(); //教案流水号
objPubClassCaseEN.PubClassCaseTimeIn = objRow[conPubClassCase.PubClassCaseTimeIn] == DBNull.Value ? null : objRow[conPubClassCase.PubClassCaseTimeIn].ToString().Trim(); //案例入库时间
objPubClassCaseEN.IdPubClassCaseSenateGaugeVersion = objRow[conPubClassCase.IdPubClassCaseSenateGaugeVersion].ToString().Trim(); //公开课量表版本流水号
objPubClassCaseEN.BrowseCount = objRow[conPubClassCase.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conPubClassCase.BrowseCount].ToString().Trim()); //浏览次数
objPubClassCaseEN.IdPubCaseType = objRow[conPubClassCase.IdPubCaseType] == DBNull.Value ? null : objRow[conPubClassCase.IdPubCaseType].ToString().Trim(); //公开课案例类型流水号
objPubClassCaseEN.IdStudyLevel = objRow[conPubClassCase.IdStudyLevel] == DBNull.Value ? null : objRow[conPubClassCase.IdStudyLevel].ToString().Trim(); //学段流水号
objPubClassCaseEN.CDID = objRow[conPubClassCase.CDID] == DBNull.Value ? null : objRow[conPubClassCase.CDID].ToString().Trim(); //光盘编号
objPubClassCaseEN.Introduction = objRow[conPubClassCase.Introduction] == DBNull.Value ? null : objRow[conPubClassCase.Introduction].ToString().Trim(); //简要介绍
objPubClassCaseEN.IsVisible = TransNullToBool(objRow[conPubClassCase.IsVisible].ToString().Trim()); //是否显示
objPubClassCaseEN.IsDualVideo = TransNullToBool(objRow[conPubClassCase.IsDualVideo].ToString().Trim()); //是否双视频
objPubClassCaseEN.RecommendedDegreeId = objRow[conPubClassCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objPubClassCaseEN.ftpFileType = objRow[conPubClassCase.ftpFileType] == DBNull.Value ? null : objRow[conPubClassCase.ftpFileType].ToString().Trim(); //ftp文件类型
objPubClassCaseEN.VideoUrl = objRow[conPubClassCase.VideoUrl] == DBNull.Value ? null : objRow[conPubClassCase.VideoUrl].ToString().Trim(); //视频Url
objPubClassCaseEN.VideoPath = objRow[conPubClassCase.VideoPath] == DBNull.Value ? null : objRow[conPubClassCase.VideoPath].ToString().Trim(); //视频目录
objPubClassCaseEN.ResErrMsg = objRow[conPubClassCase.ResErrMsg] == DBNull.Value ? null : objRow[conPubClassCase.ResErrMsg].ToString().Trim(); //资源错误信息
objPubClassCaseEN.UpdDate = objRow[conPubClassCase.UpdDate] == DBNull.Value ? null : objRow[conPubClassCase.UpdDate].ToString().Trim(); //修改日期
objPubClassCaseEN.UpdUserId = objRow[conPubClassCase.UpdUserId] == DBNull.Value ? null : objRow[conPubClassCase.UpdUserId].ToString().Trim(); //修改用户Id
objPubClassCaseEN.Memo = objRow[conPubClassCase.Memo] == DBNull.Value ? null : objRow[conPubClassCase.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsPubClassCaseDA: GetObjLst)", objException.Message));
}
objPubClassCaseEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objPubClassCaseEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objPubClassCaseEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetPubClassCase(ref clsPubClassCaseEN objPubClassCaseEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPubClassCaseDA.GetSpecSQLObj();
strSQL = "Select * from PubClassCase where IdPubClassCase = " + "'"+ objPubClassCaseEN.IdPubClassCase+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objPubClassCaseEN.IdPubClassCase = objDT.Rows[0][conPubClassCase.IdPubClassCase].ToString().Trim(); //案例流水号(字段类型:char,字段长度:8,是否可空:False)
 objPubClassCaseEN.PubClassCaseID = objDT.Rows[0][conPubClassCase.PubClassCaseID].ToString().Trim(); //案例ID(字段类型:char,字段长度:8,是否可空:False)
 objPubClassCaseEN.PubClassCaseName = objDT.Rows[0][conPubClassCase.PubClassCaseName].ToString().Trim(); //案例课题名称(字段类型:varchar,字段长度:200,是否可空:False)
 objPubClassCaseEN.PubClassCaseExecutor = objDT.Rows[0][conPubClassCase.PubClassCaseExecutor].ToString().Trim(); //案例执教者(字段类型:varchar,字段长度:50,是否可空:True)
 objPubClassCaseEN.WorkUnit = objDT.Rows[0][conPubClassCase.WorkUnit].ToString().Trim(); //工作单位(字段类型:varchar,字段长度:100,是否可空:True)
 objPubClassCaseEN.PubClassCaseTheme = objDT.Rows[0][conPubClassCase.PubClassCaseTheme].ToString().Trim(); //案例主题词(字段类型:varchar,字段长度:500,是否可空:True)
 objPubClassCaseEN.PubClassCaseBG = objDT.Rows[0][conPubClassCase.PubClassCaseBG].ToString().Trim(); //案例背景资料(字段类型:text,字段长度:16,是否可空:True)
 objPubClassCaseEN.PubClassCaseTeachDate = objDT.Rows[0][conPubClassCase.PubClassCaseTeachDate].ToString().Trim(); //案例授课日期(字段类型:char,字段长度:8,是否可空:True)
 objPubClassCaseEN.PubClassCaseDateIn = objDT.Rows[0][conPubClassCase.PubClassCaseDateIn].ToString().Trim(); //案例入库日期(字段类型:char,字段长度:8,是否可空:True)
 objPubClassCaseEN.IdDiscipline = objDT.Rows[0][conPubClassCase.IdDiscipline].ToString().Trim(); //学科流水号(字段类型:char,字段长度:4,是否可空:False)
 objPubClassCaseEN.IdTeachingPlan = objDT.Rows[0][conPubClassCase.IdTeachingPlan].ToString().Trim(); //教案流水号(字段类型:char,字段长度:8,是否可空:False)
 objPubClassCaseEN.PubClassCaseTimeIn = objDT.Rows[0][conPubClassCase.PubClassCaseTimeIn].ToString().Trim(); //案例入库时间(字段类型:char,字段长度:6,是否可空:True)
 objPubClassCaseEN.IdPubClassCaseSenateGaugeVersion = objDT.Rows[0][conPubClassCase.IdPubClassCaseSenateGaugeVersion].ToString().Trim(); //公开课量表版本流水号(字段类型:char,字段长度:4,是否可空:False)
 objPubClassCaseEN.BrowseCount = TransNullToInt(objDT.Rows[0][conPubClassCase.BrowseCount].ToString().Trim()); //浏览次数(字段类型:int,字段长度:4,是否可空:True)
 objPubClassCaseEN.IdPubCaseType = objDT.Rows[0][conPubClassCase.IdPubCaseType].ToString().Trim(); //公开课案例类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objPubClassCaseEN.IdStudyLevel = objDT.Rows[0][conPubClassCase.IdStudyLevel].ToString().Trim(); //学段流水号(字段类型:char,字段长度:4,是否可空:True)
 objPubClassCaseEN.CDID = objDT.Rows[0][conPubClassCase.CDID].ToString().Trim(); //光盘编号(字段类型:varchar,字段长度:50,是否可空:True)
 objPubClassCaseEN.Introduction = objDT.Rows[0][conPubClassCase.Introduction].ToString().Trim(); //简要介绍(字段类型:varchar,字段长度:4000,是否可空:True)
 objPubClassCaseEN.IsVisible = TransNullToBool(objDT.Rows[0][conPubClassCase.IsVisible].ToString().Trim()); //是否显示(字段类型:bit,字段长度:1,是否可空:True)
 objPubClassCaseEN.IsDualVideo = TransNullToBool(objDT.Rows[0][conPubClassCase.IsDualVideo].ToString().Trim()); //是否双视频(字段类型:bit,字段长度:1,是否可空:False)
 objPubClassCaseEN.RecommendedDegreeId = objDT.Rows[0][conPubClassCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id(字段类型:char,字段长度:2,是否可空:False)
 objPubClassCaseEN.ftpFileType = objDT.Rows[0][conPubClassCase.ftpFileType].ToString().Trim(); //ftp文件类型(字段类型:varchar,字段长度:30,是否可空:True)
 objPubClassCaseEN.VideoUrl = objDT.Rows[0][conPubClassCase.VideoUrl].ToString().Trim(); //视频Url(字段类型:varchar,字段长度:1000,是否可空:True)
 objPubClassCaseEN.VideoPath = objDT.Rows[0][conPubClassCase.VideoPath].ToString().Trim(); //视频目录(字段类型:varchar,字段长度:1000,是否可空:True)
 objPubClassCaseEN.ResErrMsg = objDT.Rows[0][conPubClassCase.ResErrMsg].ToString().Trim(); //资源错误信息(字段类型:varchar,字段长度:30,是否可空:True)
 objPubClassCaseEN.UpdDate = objDT.Rows[0][conPubClassCase.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objPubClassCaseEN.UpdUserId = objDT.Rows[0][conPubClassCase.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:True)
 objPubClassCaseEN.Memo = objDT.Rows[0][conPubClassCase.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsPubClassCaseDA: GetPubClassCase)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strIdPubClassCase">表关键字</param>
 /// <returns>表对象</returns>
public clsPubClassCaseEN GetObjByIdPubClassCase(string strIdPubClassCase)
{
CheckPrimaryKey(strIdPubClassCase);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPubClassCaseDA.GetSpecSQLObj();
strSQL = "Select * from PubClassCase where IdPubClassCase = " + "'"+ strIdPubClassCase+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsPubClassCaseEN objPubClassCaseEN = new clsPubClassCaseEN();
try
{
 objPubClassCaseEN.IdPubClassCase = objRow[conPubClassCase.IdPubClassCase].ToString().Trim(); //案例流水号(字段类型:char,字段长度:8,是否可空:False)
 objPubClassCaseEN.PubClassCaseID = objRow[conPubClassCase.PubClassCaseID].ToString().Trim(); //案例ID(字段类型:char,字段长度:8,是否可空:False)
 objPubClassCaseEN.PubClassCaseName = objRow[conPubClassCase.PubClassCaseName].ToString().Trim(); //案例课题名称(字段类型:varchar,字段长度:200,是否可空:False)
 objPubClassCaseEN.PubClassCaseExecutor = objRow[conPubClassCase.PubClassCaseExecutor] == DBNull.Value ? null : objRow[conPubClassCase.PubClassCaseExecutor].ToString().Trim(); //案例执教者(字段类型:varchar,字段长度:50,是否可空:True)
 objPubClassCaseEN.WorkUnit = objRow[conPubClassCase.WorkUnit] == DBNull.Value ? null : objRow[conPubClassCase.WorkUnit].ToString().Trim(); //工作单位(字段类型:varchar,字段长度:100,是否可空:True)
 objPubClassCaseEN.PubClassCaseTheme = objRow[conPubClassCase.PubClassCaseTheme] == DBNull.Value ? null : objRow[conPubClassCase.PubClassCaseTheme].ToString().Trim(); //案例主题词(字段类型:varchar,字段长度:500,是否可空:True)
 objPubClassCaseEN.PubClassCaseBG = objRow[conPubClassCase.PubClassCaseBG] == DBNull.Value ? null : objRow[conPubClassCase.PubClassCaseBG].ToString().Trim(); //案例背景资料(字段类型:text,字段长度:16,是否可空:True)
 objPubClassCaseEN.PubClassCaseTeachDate = objRow[conPubClassCase.PubClassCaseTeachDate] == DBNull.Value ? null : objRow[conPubClassCase.PubClassCaseTeachDate].ToString().Trim(); //案例授课日期(字段类型:char,字段长度:8,是否可空:True)
 objPubClassCaseEN.PubClassCaseDateIn = objRow[conPubClassCase.PubClassCaseDateIn] == DBNull.Value ? null : objRow[conPubClassCase.PubClassCaseDateIn].ToString().Trim(); //案例入库日期(字段类型:char,字段长度:8,是否可空:True)
 objPubClassCaseEN.IdDiscipline = objRow[conPubClassCase.IdDiscipline].ToString().Trim(); //学科流水号(字段类型:char,字段长度:4,是否可空:False)
 objPubClassCaseEN.IdTeachingPlan = objRow[conPubClassCase.IdTeachingPlan] == DBNull.Value ? null : objRow[conPubClassCase.IdTeachingPlan].ToString().Trim(); //教案流水号(字段类型:char,字段长度:8,是否可空:False)
 objPubClassCaseEN.PubClassCaseTimeIn = objRow[conPubClassCase.PubClassCaseTimeIn] == DBNull.Value ? null : objRow[conPubClassCase.PubClassCaseTimeIn].ToString().Trim(); //案例入库时间(字段类型:char,字段长度:6,是否可空:True)
 objPubClassCaseEN.IdPubClassCaseSenateGaugeVersion = objRow[conPubClassCase.IdPubClassCaseSenateGaugeVersion].ToString().Trim(); //公开课量表版本流水号(字段类型:char,字段长度:4,是否可空:False)
 objPubClassCaseEN.BrowseCount = objRow[conPubClassCase.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPubClassCase.BrowseCount].ToString().Trim()); //浏览次数(字段类型:int,字段长度:4,是否可空:True)
 objPubClassCaseEN.IdPubCaseType = objRow[conPubClassCase.IdPubCaseType] == DBNull.Value ? null : objRow[conPubClassCase.IdPubCaseType].ToString().Trim(); //公开课案例类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objPubClassCaseEN.IdStudyLevel = objRow[conPubClassCase.IdStudyLevel] == DBNull.Value ? null : objRow[conPubClassCase.IdStudyLevel].ToString().Trim(); //学段流水号(字段类型:char,字段长度:4,是否可空:True)
 objPubClassCaseEN.CDID = objRow[conPubClassCase.CDID] == DBNull.Value ? null : objRow[conPubClassCase.CDID].ToString().Trim(); //光盘编号(字段类型:varchar,字段长度:50,是否可空:True)
 objPubClassCaseEN.Introduction = objRow[conPubClassCase.Introduction] == DBNull.Value ? null : objRow[conPubClassCase.Introduction].ToString().Trim(); //简要介绍(字段类型:varchar,字段长度:4000,是否可空:True)
 objPubClassCaseEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conPubClassCase.IsVisible].ToString().Trim()); //是否显示(字段类型:bit,字段长度:1,是否可空:True)
 objPubClassCaseEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[conPubClassCase.IsDualVideo].ToString().Trim()); //是否双视频(字段类型:bit,字段长度:1,是否可空:False)
 objPubClassCaseEN.RecommendedDegreeId = objRow[conPubClassCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id(字段类型:char,字段长度:2,是否可空:False)
 objPubClassCaseEN.ftpFileType = objRow[conPubClassCase.ftpFileType] == DBNull.Value ? null : objRow[conPubClassCase.ftpFileType].ToString().Trim(); //ftp文件类型(字段类型:varchar,字段长度:30,是否可空:True)
 objPubClassCaseEN.VideoUrl = objRow[conPubClassCase.VideoUrl] == DBNull.Value ? null : objRow[conPubClassCase.VideoUrl].ToString().Trim(); //视频Url(字段类型:varchar,字段长度:1000,是否可空:True)
 objPubClassCaseEN.VideoPath = objRow[conPubClassCase.VideoPath] == DBNull.Value ? null : objRow[conPubClassCase.VideoPath].ToString().Trim(); //视频目录(字段类型:varchar,字段长度:1000,是否可空:True)
 objPubClassCaseEN.ResErrMsg = objRow[conPubClassCase.ResErrMsg] == DBNull.Value ? null : objRow[conPubClassCase.ResErrMsg].ToString().Trim(); //资源错误信息(字段类型:varchar,字段长度:30,是否可空:True)
 objPubClassCaseEN.UpdDate = objRow[conPubClassCase.UpdDate] == DBNull.Value ? null : objRow[conPubClassCase.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objPubClassCaseEN.UpdUserId = objRow[conPubClassCase.UpdUserId] == DBNull.Value ? null : objRow[conPubClassCase.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:True)
 objPubClassCaseEN.Memo = objRow[conPubClassCase.Memo] == DBNull.Value ? null : objRow[conPubClassCase.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsPubClassCaseDA: GetObjByIdPubClassCase)", objException.Message));
}
return objPubClassCaseEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsPubClassCaseEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsPubClassCaseDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPubClassCaseDA.GetSpecSQLObj();
strSQL = "Select * from PubClassCase where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsPubClassCaseEN objPubClassCaseEN = new clsPubClassCaseEN()
{
IdPubClassCase = objRow[conPubClassCase.IdPubClassCase].ToString().Trim(), //案例流水号
PubClassCaseID = objRow[conPubClassCase.PubClassCaseID].ToString().Trim(), //案例ID
PubClassCaseName = objRow[conPubClassCase.PubClassCaseName].ToString().Trim(), //案例课题名称
PubClassCaseExecutor = objRow[conPubClassCase.PubClassCaseExecutor] == DBNull.Value ? null : objRow[conPubClassCase.PubClassCaseExecutor].ToString().Trim(), //案例执教者
WorkUnit = objRow[conPubClassCase.WorkUnit] == DBNull.Value ? null : objRow[conPubClassCase.WorkUnit].ToString().Trim(), //工作单位
PubClassCaseTheme = objRow[conPubClassCase.PubClassCaseTheme] == DBNull.Value ? null : objRow[conPubClassCase.PubClassCaseTheme].ToString().Trim(), //案例主题词
PubClassCaseBG = objRow[conPubClassCase.PubClassCaseBG] == DBNull.Value ? null : objRow[conPubClassCase.PubClassCaseBG].ToString().Trim(), //案例背景资料
PubClassCaseTeachDate = objRow[conPubClassCase.PubClassCaseTeachDate] == DBNull.Value ? null : objRow[conPubClassCase.PubClassCaseTeachDate].ToString().Trim(), //案例授课日期
PubClassCaseDateIn = objRow[conPubClassCase.PubClassCaseDateIn] == DBNull.Value ? null : objRow[conPubClassCase.PubClassCaseDateIn].ToString().Trim(), //案例入库日期
IdDiscipline = objRow[conPubClassCase.IdDiscipline].ToString().Trim(), //学科流水号
IdTeachingPlan = objRow[conPubClassCase.IdTeachingPlan] == DBNull.Value ? null : objRow[conPubClassCase.IdTeachingPlan].ToString().Trim(), //教案流水号
PubClassCaseTimeIn = objRow[conPubClassCase.PubClassCaseTimeIn] == DBNull.Value ? null : objRow[conPubClassCase.PubClassCaseTimeIn].ToString().Trim(), //案例入库时间
IdPubClassCaseSenateGaugeVersion = objRow[conPubClassCase.IdPubClassCaseSenateGaugeVersion].ToString().Trim(), //公开课量表版本流水号
BrowseCount = objRow[conPubClassCase.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conPubClassCase.BrowseCount].ToString().Trim()), //浏览次数
IdPubCaseType = objRow[conPubClassCase.IdPubCaseType] == DBNull.Value ? null : objRow[conPubClassCase.IdPubCaseType].ToString().Trim(), //公开课案例类型流水号
IdStudyLevel = objRow[conPubClassCase.IdStudyLevel] == DBNull.Value ? null : objRow[conPubClassCase.IdStudyLevel].ToString().Trim(), //学段流水号
CDID = objRow[conPubClassCase.CDID] == DBNull.Value ? null : objRow[conPubClassCase.CDID].ToString().Trim(), //光盘编号
Introduction = objRow[conPubClassCase.Introduction] == DBNull.Value ? null : objRow[conPubClassCase.Introduction].ToString().Trim(), //简要介绍
IsVisible = TransNullToBool(objRow[conPubClassCase.IsVisible].ToString().Trim()), //是否显示
IsDualVideo = TransNullToBool(objRow[conPubClassCase.IsDualVideo].ToString().Trim()), //是否双视频
RecommendedDegreeId = objRow[conPubClassCase.RecommendedDegreeId].ToString().Trim(), //推荐度Id
ftpFileType = objRow[conPubClassCase.ftpFileType] == DBNull.Value ? null : objRow[conPubClassCase.ftpFileType].ToString().Trim(), //ftp文件类型
VideoUrl = objRow[conPubClassCase.VideoUrl] == DBNull.Value ? null : objRow[conPubClassCase.VideoUrl].ToString().Trim(), //视频Url
VideoPath = objRow[conPubClassCase.VideoPath] == DBNull.Value ? null : objRow[conPubClassCase.VideoPath].ToString().Trim(), //视频目录
ResErrMsg = objRow[conPubClassCase.ResErrMsg] == DBNull.Value ? null : objRow[conPubClassCase.ResErrMsg].ToString().Trim(), //资源错误信息
UpdDate = objRow[conPubClassCase.UpdDate] == DBNull.Value ? null : objRow[conPubClassCase.UpdDate].ToString().Trim(), //修改日期
UpdUserId = objRow[conPubClassCase.UpdUserId] == DBNull.Value ? null : objRow[conPubClassCase.UpdUserId].ToString().Trim(), //修改用户Id
Memo = objRow[conPubClassCase.Memo] == DBNull.Value ? null : objRow[conPubClassCase.Memo].ToString().Trim() //备注
};
objPubClassCaseEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objPubClassCaseEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsPubClassCaseDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsPubClassCaseEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsPubClassCaseEN objPubClassCaseEN = new clsPubClassCaseEN();
try
{
objPubClassCaseEN.IdPubClassCase = objRow[conPubClassCase.IdPubClassCase].ToString().Trim(); //案例流水号
objPubClassCaseEN.PubClassCaseID = objRow[conPubClassCase.PubClassCaseID].ToString().Trim(); //案例ID
objPubClassCaseEN.PubClassCaseName = objRow[conPubClassCase.PubClassCaseName].ToString().Trim(); //案例课题名称
objPubClassCaseEN.PubClassCaseExecutor = objRow[conPubClassCase.PubClassCaseExecutor] == DBNull.Value ? null : objRow[conPubClassCase.PubClassCaseExecutor].ToString().Trim(); //案例执教者
objPubClassCaseEN.WorkUnit = objRow[conPubClassCase.WorkUnit] == DBNull.Value ? null : objRow[conPubClassCase.WorkUnit].ToString().Trim(); //工作单位
objPubClassCaseEN.PubClassCaseTheme = objRow[conPubClassCase.PubClassCaseTheme] == DBNull.Value ? null : objRow[conPubClassCase.PubClassCaseTheme].ToString().Trim(); //案例主题词
objPubClassCaseEN.PubClassCaseBG = objRow[conPubClassCase.PubClassCaseBG] == DBNull.Value ? null : objRow[conPubClassCase.PubClassCaseBG].ToString().Trim(); //案例背景资料
objPubClassCaseEN.PubClassCaseTeachDate = objRow[conPubClassCase.PubClassCaseTeachDate] == DBNull.Value ? null : objRow[conPubClassCase.PubClassCaseTeachDate].ToString().Trim(); //案例授课日期
objPubClassCaseEN.PubClassCaseDateIn = objRow[conPubClassCase.PubClassCaseDateIn] == DBNull.Value ? null : objRow[conPubClassCase.PubClassCaseDateIn].ToString().Trim(); //案例入库日期
objPubClassCaseEN.IdDiscipline = objRow[conPubClassCase.IdDiscipline].ToString().Trim(); //学科流水号
objPubClassCaseEN.IdTeachingPlan = objRow[conPubClassCase.IdTeachingPlan] == DBNull.Value ? null : objRow[conPubClassCase.IdTeachingPlan].ToString().Trim(); //教案流水号
objPubClassCaseEN.PubClassCaseTimeIn = objRow[conPubClassCase.PubClassCaseTimeIn] == DBNull.Value ? null : objRow[conPubClassCase.PubClassCaseTimeIn].ToString().Trim(); //案例入库时间
objPubClassCaseEN.IdPubClassCaseSenateGaugeVersion = objRow[conPubClassCase.IdPubClassCaseSenateGaugeVersion].ToString().Trim(); //公开课量表版本流水号
objPubClassCaseEN.BrowseCount = objRow[conPubClassCase.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conPubClassCase.BrowseCount].ToString().Trim()); //浏览次数
objPubClassCaseEN.IdPubCaseType = objRow[conPubClassCase.IdPubCaseType] == DBNull.Value ? null : objRow[conPubClassCase.IdPubCaseType].ToString().Trim(); //公开课案例类型流水号
objPubClassCaseEN.IdStudyLevel = objRow[conPubClassCase.IdStudyLevel] == DBNull.Value ? null : objRow[conPubClassCase.IdStudyLevel].ToString().Trim(); //学段流水号
objPubClassCaseEN.CDID = objRow[conPubClassCase.CDID] == DBNull.Value ? null : objRow[conPubClassCase.CDID].ToString().Trim(); //光盘编号
objPubClassCaseEN.Introduction = objRow[conPubClassCase.Introduction] == DBNull.Value ? null : objRow[conPubClassCase.Introduction].ToString().Trim(); //简要介绍
objPubClassCaseEN.IsVisible = TransNullToBool(objRow[conPubClassCase.IsVisible].ToString().Trim()); //是否显示
objPubClassCaseEN.IsDualVideo = TransNullToBool(objRow[conPubClassCase.IsDualVideo].ToString().Trim()); //是否双视频
objPubClassCaseEN.RecommendedDegreeId = objRow[conPubClassCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objPubClassCaseEN.ftpFileType = objRow[conPubClassCase.ftpFileType] == DBNull.Value ? null : objRow[conPubClassCase.ftpFileType].ToString().Trim(); //ftp文件类型
objPubClassCaseEN.VideoUrl = objRow[conPubClassCase.VideoUrl] == DBNull.Value ? null : objRow[conPubClassCase.VideoUrl].ToString().Trim(); //视频Url
objPubClassCaseEN.VideoPath = objRow[conPubClassCase.VideoPath] == DBNull.Value ? null : objRow[conPubClassCase.VideoPath].ToString().Trim(); //视频目录
objPubClassCaseEN.ResErrMsg = objRow[conPubClassCase.ResErrMsg] == DBNull.Value ? null : objRow[conPubClassCase.ResErrMsg].ToString().Trim(); //资源错误信息
objPubClassCaseEN.UpdDate = objRow[conPubClassCase.UpdDate] == DBNull.Value ? null : objRow[conPubClassCase.UpdDate].ToString().Trim(); //修改日期
objPubClassCaseEN.UpdUserId = objRow[conPubClassCase.UpdUserId] == DBNull.Value ? null : objRow[conPubClassCase.UpdUserId].ToString().Trim(); //修改用户Id
objPubClassCaseEN.Memo = objRow[conPubClassCase.Memo] == DBNull.Value ? null : objRow[conPubClassCase.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsPubClassCaseDA: GetObjByDataRowPubClassCase)", objException.Message));
}
objPubClassCaseEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objPubClassCaseEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsPubClassCaseEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsPubClassCaseEN objPubClassCaseEN = new clsPubClassCaseEN();
try
{
objPubClassCaseEN.IdPubClassCase = objRow[conPubClassCase.IdPubClassCase].ToString().Trim(); //案例流水号
objPubClassCaseEN.PubClassCaseID = objRow[conPubClassCase.PubClassCaseID].ToString().Trim(); //案例ID
objPubClassCaseEN.PubClassCaseName = objRow[conPubClassCase.PubClassCaseName].ToString().Trim(); //案例课题名称
objPubClassCaseEN.PubClassCaseExecutor = objRow[conPubClassCase.PubClassCaseExecutor] == DBNull.Value ? null : objRow[conPubClassCase.PubClassCaseExecutor].ToString().Trim(); //案例执教者
objPubClassCaseEN.WorkUnit = objRow[conPubClassCase.WorkUnit] == DBNull.Value ? null : objRow[conPubClassCase.WorkUnit].ToString().Trim(); //工作单位
objPubClassCaseEN.PubClassCaseTheme = objRow[conPubClassCase.PubClassCaseTheme] == DBNull.Value ? null : objRow[conPubClassCase.PubClassCaseTheme].ToString().Trim(); //案例主题词
objPubClassCaseEN.PubClassCaseBG = objRow[conPubClassCase.PubClassCaseBG] == DBNull.Value ? null : objRow[conPubClassCase.PubClassCaseBG].ToString().Trim(); //案例背景资料
objPubClassCaseEN.PubClassCaseTeachDate = objRow[conPubClassCase.PubClassCaseTeachDate] == DBNull.Value ? null : objRow[conPubClassCase.PubClassCaseTeachDate].ToString().Trim(); //案例授课日期
objPubClassCaseEN.PubClassCaseDateIn = objRow[conPubClassCase.PubClassCaseDateIn] == DBNull.Value ? null : objRow[conPubClassCase.PubClassCaseDateIn].ToString().Trim(); //案例入库日期
objPubClassCaseEN.IdDiscipline = objRow[conPubClassCase.IdDiscipline].ToString().Trim(); //学科流水号
objPubClassCaseEN.IdTeachingPlan = objRow[conPubClassCase.IdTeachingPlan] == DBNull.Value ? null : objRow[conPubClassCase.IdTeachingPlan].ToString().Trim(); //教案流水号
objPubClassCaseEN.PubClassCaseTimeIn = objRow[conPubClassCase.PubClassCaseTimeIn] == DBNull.Value ? null : objRow[conPubClassCase.PubClassCaseTimeIn].ToString().Trim(); //案例入库时间
objPubClassCaseEN.IdPubClassCaseSenateGaugeVersion = objRow[conPubClassCase.IdPubClassCaseSenateGaugeVersion].ToString().Trim(); //公开课量表版本流水号
objPubClassCaseEN.BrowseCount = objRow[conPubClassCase.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conPubClassCase.BrowseCount].ToString().Trim()); //浏览次数
objPubClassCaseEN.IdPubCaseType = objRow[conPubClassCase.IdPubCaseType] == DBNull.Value ? null : objRow[conPubClassCase.IdPubCaseType].ToString().Trim(); //公开课案例类型流水号
objPubClassCaseEN.IdStudyLevel = objRow[conPubClassCase.IdStudyLevel] == DBNull.Value ? null : objRow[conPubClassCase.IdStudyLevel].ToString().Trim(); //学段流水号
objPubClassCaseEN.CDID = objRow[conPubClassCase.CDID] == DBNull.Value ? null : objRow[conPubClassCase.CDID].ToString().Trim(); //光盘编号
objPubClassCaseEN.Introduction = objRow[conPubClassCase.Introduction] == DBNull.Value ? null : objRow[conPubClassCase.Introduction].ToString().Trim(); //简要介绍
objPubClassCaseEN.IsVisible = TransNullToBool(objRow[conPubClassCase.IsVisible].ToString().Trim()); //是否显示
objPubClassCaseEN.IsDualVideo = TransNullToBool(objRow[conPubClassCase.IsDualVideo].ToString().Trim()); //是否双视频
objPubClassCaseEN.RecommendedDegreeId = objRow[conPubClassCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objPubClassCaseEN.ftpFileType = objRow[conPubClassCase.ftpFileType] == DBNull.Value ? null : objRow[conPubClassCase.ftpFileType].ToString().Trim(); //ftp文件类型
objPubClassCaseEN.VideoUrl = objRow[conPubClassCase.VideoUrl] == DBNull.Value ? null : objRow[conPubClassCase.VideoUrl].ToString().Trim(); //视频Url
objPubClassCaseEN.VideoPath = objRow[conPubClassCase.VideoPath] == DBNull.Value ? null : objRow[conPubClassCase.VideoPath].ToString().Trim(); //视频目录
objPubClassCaseEN.ResErrMsg = objRow[conPubClassCase.ResErrMsg] == DBNull.Value ? null : objRow[conPubClassCase.ResErrMsg].ToString().Trim(); //资源错误信息
objPubClassCaseEN.UpdDate = objRow[conPubClassCase.UpdDate] == DBNull.Value ? null : objRow[conPubClassCase.UpdDate].ToString().Trim(); //修改日期
objPubClassCaseEN.UpdUserId = objRow[conPubClassCase.UpdUserId] == DBNull.Value ? null : objRow[conPubClassCase.UpdUserId].ToString().Trim(); //修改用户Id
objPubClassCaseEN.Memo = objRow[conPubClassCase.Memo] == DBNull.Value ? null : objRow[conPubClassCase.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsPubClassCaseDA: GetObjByDataRow)", objException.Message));
}
objPubClassCaseEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objPubClassCaseEN;
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
objSQL = clsPubClassCaseDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsPubClassCaseEN._CurrTabName, conPubClassCase.IdPubClassCase, 8, "");
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
objSQL = clsPubClassCaseDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsPubClassCaseEN._CurrTabName, conPubClassCase.IdPubClassCase, 8, strPrefix);
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
 objSQL = clsPubClassCaseDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select IdPubClassCase from PubClassCase where " + strCondition;
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
 objSQL = clsPubClassCaseDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select IdPubClassCase from PubClassCase where " + strCondition;
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
 /// <param name = "strIdPubClassCase">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strIdPubClassCase)
{
CheckPrimaryKey(strIdPubClassCase);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPubClassCaseDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("PubClassCase", "IdPubClassCase = " + "'"+ strIdPubClassCase+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsPubClassCaseDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPubClassCaseDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("PubClassCase", strCondition))
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
objSQL = clsPubClassCaseDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("PubClassCase");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsPubClassCaseEN objPubClassCaseEN)
 {
 objPubClassCaseEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objPubClassCaseEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objPubClassCaseEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPubClassCaseDA.GetSpecSQLObj();
strSQL = "Select * from PubClassCase where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "PubClassCase");
objRow = objDS.Tables["PubClassCase"].NewRow();
objRow[conPubClassCase.IdPubClassCase] = objPubClassCaseEN.IdPubClassCase; //案例流水号
objRow[conPubClassCase.PubClassCaseID] = objPubClassCaseEN.PubClassCaseID; //案例ID
objRow[conPubClassCase.PubClassCaseName] = objPubClassCaseEN.PubClassCaseName; //案例课题名称
 if (objPubClassCaseEN.PubClassCaseExecutor !=  "")
 {
objRow[conPubClassCase.PubClassCaseExecutor] = objPubClassCaseEN.PubClassCaseExecutor; //案例执教者
 }
 if (objPubClassCaseEN.WorkUnit !=  "")
 {
objRow[conPubClassCase.WorkUnit] = objPubClassCaseEN.WorkUnit; //工作单位
 }
 if (objPubClassCaseEN.PubClassCaseTheme !=  "")
 {
objRow[conPubClassCase.PubClassCaseTheme] = objPubClassCaseEN.PubClassCaseTheme; //案例主题词
 }
 if (objPubClassCaseEN.PubClassCaseBG !=  "")
 {
objRow[conPubClassCase.PubClassCaseBG] = objPubClassCaseEN.PubClassCaseBG; //案例背景资料
 }
 if (objPubClassCaseEN.PubClassCaseTeachDate !=  "")
 {
objRow[conPubClassCase.PubClassCaseTeachDate] = objPubClassCaseEN.PubClassCaseTeachDate; //案例授课日期
 }
 if (objPubClassCaseEN.PubClassCaseDateIn !=  "")
 {
objRow[conPubClassCase.PubClassCaseDateIn] = objPubClassCaseEN.PubClassCaseDateIn; //案例入库日期
 }
objRow[conPubClassCase.IdDiscipline] = objPubClassCaseEN.IdDiscipline; //学科流水号
 if (objPubClassCaseEN.IdTeachingPlan !=  "")
 {
objRow[conPubClassCase.IdTeachingPlan] = objPubClassCaseEN.IdTeachingPlan; //教案流水号
 }
 if (objPubClassCaseEN.PubClassCaseTimeIn !=  "")
 {
objRow[conPubClassCase.PubClassCaseTimeIn] = objPubClassCaseEN.PubClassCaseTimeIn; //案例入库时间
 }
objRow[conPubClassCase.IdPubClassCaseSenateGaugeVersion] = objPubClassCaseEN.IdPubClassCaseSenateGaugeVersion; //公开课量表版本流水号
objRow[conPubClassCase.BrowseCount] = objPubClassCaseEN.BrowseCount; //浏览次数
 if (objPubClassCaseEN.IdPubCaseType !=  "")
 {
objRow[conPubClassCase.IdPubCaseType] = objPubClassCaseEN.IdPubCaseType; //公开课案例类型流水号
 }
 if (objPubClassCaseEN.IdStudyLevel !=  "")
 {
objRow[conPubClassCase.IdStudyLevel] = objPubClassCaseEN.IdStudyLevel; //学段流水号
 }
 if (objPubClassCaseEN.CDID !=  "")
 {
objRow[conPubClassCase.CDID] = objPubClassCaseEN.CDID; //光盘编号
 }
 if (objPubClassCaseEN.Introduction !=  "")
 {
objRow[conPubClassCase.Introduction] = objPubClassCaseEN.Introduction; //简要介绍
 }
objRow[conPubClassCase.IsVisible] = objPubClassCaseEN.IsVisible; //是否显示
objRow[conPubClassCase.IsDualVideo] = objPubClassCaseEN.IsDualVideo; //是否双视频
objRow[conPubClassCase.RecommendedDegreeId] = objPubClassCaseEN.RecommendedDegreeId; //推荐度Id
 if (objPubClassCaseEN.ftpFileType !=  "")
 {
objRow[conPubClassCase.ftpFileType] = objPubClassCaseEN.ftpFileType; //ftp文件类型
 }
 if (objPubClassCaseEN.VideoUrl !=  "")
 {
objRow[conPubClassCase.VideoUrl] = objPubClassCaseEN.VideoUrl; //视频Url
 }
 if (objPubClassCaseEN.VideoPath !=  "")
 {
objRow[conPubClassCase.VideoPath] = objPubClassCaseEN.VideoPath; //视频目录
 }
 if (objPubClassCaseEN.ResErrMsg !=  "")
 {
objRow[conPubClassCase.ResErrMsg] = objPubClassCaseEN.ResErrMsg; //资源错误信息
 }
 if (objPubClassCaseEN.UpdDate !=  "")
 {
objRow[conPubClassCase.UpdDate] = objPubClassCaseEN.UpdDate; //修改日期
 }
 if (objPubClassCaseEN.UpdUserId !=  "")
 {
objRow[conPubClassCase.UpdUserId] = objPubClassCaseEN.UpdUserId; //修改用户Id
 }
 if (objPubClassCaseEN.Memo !=  "")
 {
objRow[conPubClassCase.Memo] = objPubClassCaseEN.Memo; //备注
 }
objDS.Tables[clsPubClassCaseEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsPubClassCaseEN._CurrTabName);
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
 /// <param name = "objPubClassCaseEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsPubClassCaseEN objPubClassCaseEN)
{
 objPubClassCaseEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objPubClassCaseEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objPubClassCaseEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objPubClassCaseEN.IdPubClassCase !=  null)
 {
 arrFieldListForInsert.Add(conPubClassCase.IdPubClassCase);
 var strIdPubClassCase = objPubClassCaseEN.IdPubClassCase.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdPubClassCase + "'");
 }
 
 if (objPubClassCaseEN.PubClassCaseID !=  null)
 {
 arrFieldListForInsert.Add(conPubClassCase.PubClassCaseID);
 var strPubClassCaseID = objPubClassCaseEN.PubClassCaseID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPubClassCaseID + "'");
 }
 
 if (objPubClassCaseEN.PubClassCaseName !=  null)
 {
 arrFieldListForInsert.Add(conPubClassCase.PubClassCaseName);
 var strPubClassCaseName = objPubClassCaseEN.PubClassCaseName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPubClassCaseName + "'");
 }
 
 if (objPubClassCaseEN.PubClassCaseExecutor !=  null)
 {
 arrFieldListForInsert.Add(conPubClassCase.PubClassCaseExecutor);
 var strPubClassCaseExecutor = objPubClassCaseEN.PubClassCaseExecutor.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPubClassCaseExecutor + "'");
 }
 
 if (objPubClassCaseEN.WorkUnit !=  null)
 {
 arrFieldListForInsert.Add(conPubClassCase.WorkUnit);
 var strWorkUnit = objPubClassCaseEN.WorkUnit.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strWorkUnit + "'");
 }
 
 if (objPubClassCaseEN.PubClassCaseTheme !=  null)
 {
 arrFieldListForInsert.Add(conPubClassCase.PubClassCaseTheme);
 var strPubClassCaseTheme = objPubClassCaseEN.PubClassCaseTheme.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPubClassCaseTheme + "'");
 }
 
 if (objPubClassCaseEN.PubClassCaseBG !=  null)
 {
 arrFieldListForInsert.Add(conPubClassCase.PubClassCaseBG);
 var strPubClassCaseBG = objPubClassCaseEN.PubClassCaseBG.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPubClassCaseBG + "'");
 }
 
 if (objPubClassCaseEN.PubClassCaseTeachDate !=  null)
 {
 arrFieldListForInsert.Add(conPubClassCase.PubClassCaseTeachDate);
 var strPubClassCaseTeachDate = objPubClassCaseEN.PubClassCaseTeachDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPubClassCaseTeachDate + "'");
 }
 
 if (objPubClassCaseEN.PubClassCaseDateIn !=  null)
 {
 arrFieldListForInsert.Add(conPubClassCase.PubClassCaseDateIn);
 var strPubClassCaseDateIn = objPubClassCaseEN.PubClassCaseDateIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPubClassCaseDateIn + "'");
 }
 
 if (objPubClassCaseEN.IdDiscipline  ==  "")
 {
 objPubClassCaseEN.IdDiscipline = null;
 }
 if (objPubClassCaseEN.IdDiscipline !=  null)
 {
 arrFieldListForInsert.Add(conPubClassCase.IdDiscipline);
 var strIdDiscipline = objPubClassCaseEN.IdDiscipline.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdDiscipline + "'");
 }
 
 if (objPubClassCaseEN.IdTeachingPlan !=  null)
 {
 arrFieldListForInsert.Add(conPubClassCase.IdTeachingPlan);
 var strIdTeachingPlan = objPubClassCaseEN.IdTeachingPlan.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdTeachingPlan + "'");
 }
 
 if (objPubClassCaseEN.PubClassCaseTimeIn !=  null)
 {
 arrFieldListForInsert.Add(conPubClassCase.PubClassCaseTimeIn);
 var strPubClassCaseTimeIn = objPubClassCaseEN.PubClassCaseTimeIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPubClassCaseTimeIn + "'");
 }
 
 if (objPubClassCaseEN.IdPubClassCaseSenateGaugeVersion !=  null)
 {
 arrFieldListForInsert.Add(conPubClassCase.IdPubClassCaseSenateGaugeVersion);
 var strIdPubClassCaseSenateGaugeVersion = objPubClassCaseEN.IdPubClassCaseSenateGaugeVersion.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdPubClassCaseSenateGaugeVersion + "'");
 }
 
 if (objPubClassCaseEN.BrowseCount !=  null)
 {
 arrFieldListForInsert.Add(conPubClassCase.BrowseCount);
 arrValueListForInsert.Add(objPubClassCaseEN.BrowseCount.ToString());
 }
 
 if (objPubClassCaseEN.IdPubCaseType !=  null)
 {
 arrFieldListForInsert.Add(conPubClassCase.IdPubCaseType);
 var strIdPubCaseType = objPubClassCaseEN.IdPubCaseType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdPubCaseType + "'");
 }
 
 if (objPubClassCaseEN.IdStudyLevel !=  null)
 {
 arrFieldListForInsert.Add(conPubClassCase.IdStudyLevel);
 var strIdStudyLevel = objPubClassCaseEN.IdStudyLevel.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdStudyLevel + "'");
 }
 
 if (objPubClassCaseEN.CDID !=  null)
 {
 arrFieldListForInsert.Add(conPubClassCase.CDID);
 var strCDID = objPubClassCaseEN.CDID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCDID + "'");
 }
 
 if (objPubClassCaseEN.Introduction !=  null)
 {
 arrFieldListForInsert.Add(conPubClassCase.Introduction);
 var strIntroduction = objPubClassCaseEN.Introduction.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIntroduction + "'");
 }
 
 arrFieldListForInsert.Add(conPubClassCase.IsVisible);
 arrValueListForInsert.Add("'" + (objPubClassCaseEN.IsVisible  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conPubClassCase.IsDualVideo);
 arrValueListForInsert.Add("'" + (objPubClassCaseEN.IsDualVideo  ==  false ? "0" : "1") + "'");
 
 if (objPubClassCaseEN.RecommendedDegreeId !=  null)
 {
 arrFieldListForInsert.Add(conPubClassCase.RecommendedDegreeId);
 var strRecommendedDegreeId = objPubClassCaseEN.RecommendedDegreeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRecommendedDegreeId + "'");
 }
 
 if (objPubClassCaseEN.ftpFileType !=  null)
 {
 arrFieldListForInsert.Add(conPubClassCase.ftpFileType);
 var strftpFileType = objPubClassCaseEN.ftpFileType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strftpFileType + "'");
 }
 
 if (objPubClassCaseEN.VideoUrl !=  null)
 {
 arrFieldListForInsert.Add(conPubClassCase.VideoUrl);
 var strVideoUrl = objPubClassCaseEN.VideoUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVideoUrl + "'");
 }
 
 if (objPubClassCaseEN.VideoPath !=  null)
 {
 arrFieldListForInsert.Add(conPubClassCase.VideoPath);
 var strVideoPath = objPubClassCaseEN.VideoPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVideoPath + "'");
 }
 
 if (objPubClassCaseEN.ResErrMsg !=  null)
 {
 arrFieldListForInsert.Add(conPubClassCase.ResErrMsg);
 var strResErrMsg = objPubClassCaseEN.ResErrMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strResErrMsg + "'");
 }
 
 if (objPubClassCaseEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conPubClassCase.UpdDate);
 var strUpdDate = objPubClassCaseEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objPubClassCaseEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(conPubClassCase.UpdUserId);
 var strUpdUserId = objPubClassCaseEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objPubClassCaseEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conPubClassCase.Memo);
 var strMemo = objPubClassCaseEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into PubClassCase");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPubClassCaseDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objPubClassCaseEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsPubClassCaseEN objPubClassCaseEN)
{
 objPubClassCaseEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objPubClassCaseEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objPubClassCaseEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objPubClassCaseEN.IdPubClassCase !=  null)
 {
 arrFieldListForInsert.Add(conPubClassCase.IdPubClassCase);
 var strIdPubClassCase = objPubClassCaseEN.IdPubClassCase.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdPubClassCase + "'");
 }
 
 if (objPubClassCaseEN.PubClassCaseID !=  null)
 {
 arrFieldListForInsert.Add(conPubClassCase.PubClassCaseID);
 var strPubClassCaseID = objPubClassCaseEN.PubClassCaseID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPubClassCaseID + "'");
 }
 
 if (objPubClassCaseEN.PubClassCaseName !=  null)
 {
 arrFieldListForInsert.Add(conPubClassCase.PubClassCaseName);
 var strPubClassCaseName = objPubClassCaseEN.PubClassCaseName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPubClassCaseName + "'");
 }
 
 if (objPubClassCaseEN.PubClassCaseExecutor !=  null)
 {
 arrFieldListForInsert.Add(conPubClassCase.PubClassCaseExecutor);
 var strPubClassCaseExecutor = objPubClassCaseEN.PubClassCaseExecutor.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPubClassCaseExecutor + "'");
 }
 
 if (objPubClassCaseEN.WorkUnit !=  null)
 {
 arrFieldListForInsert.Add(conPubClassCase.WorkUnit);
 var strWorkUnit = objPubClassCaseEN.WorkUnit.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strWorkUnit + "'");
 }
 
 if (objPubClassCaseEN.PubClassCaseTheme !=  null)
 {
 arrFieldListForInsert.Add(conPubClassCase.PubClassCaseTheme);
 var strPubClassCaseTheme = objPubClassCaseEN.PubClassCaseTheme.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPubClassCaseTheme + "'");
 }
 
 if (objPubClassCaseEN.PubClassCaseBG !=  null)
 {
 arrFieldListForInsert.Add(conPubClassCase.PubClassCaseBG);
 var strPubClassCaseBG = objPubClassCaseEN.PubClassCaseBG.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPubClassCaseBG + "'");
 }
 
 if (objPubClassCaseEN.PubClassCaseTeachDate !=  null)
 {
 arrFieldListForInsert.Add(conPubClassCase.PubClassCaseTeachDate);
 var strPubClassCaseTeachDate = objPubClassCaseEN.PubClassCaseTeachDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPubClassCaseTeachDate + "'");
 }
 
 if (objPubClassCaseEN.PubClassCaseDateIn !=  null)
 {
 arrFieldListForInsert.Add(conPubClassCase.PubClassCaseDateIn);
 var strPubClassCaseDateIn = objPubClassCaseEN.PubClassCaseDateIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPubClassCaseDateIn + "'");
 }
 
 if (objPubClassCaseEN.IdDiscipline  ==  "")
 {
 objPubClassCaseEN.IdDiscipline = null;
 }
 if (objPubClassCaseEN.IdDiscipline !=  null)
 {
 arrFieldListForInsert.Add(conPubClassCase.IdDiscipline);
 var strIdDiscipline = objPubClassCaseEN.IdDiscipline.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdDiscipline + "'");
 }
 
 if (objPubClassCaseEN.IdTeachingPlan !=  null)
 {
 arrFieldListForInsert.Add(conPubClassCase.IdTeachingPlan);
 var strIdTeachingPlan = objPubClassCaseEN.IdTeachingPlan.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdTeachingPlan + "'");
 }
 
 if (objPubClassCaseEN.PubClassCaseTimeIn !=  null)
 {
 arrFieldListForInsert.Add(conPubClassCase.PubClassCaseTimeIn);
 var strPubClassCaseTimeIn = objPubClassCaseEN.PubClassCaseTimeIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPubClassCaseTimeIn + "'");
 }
 
 if (objPubClassCaseEN.IdPubClassCaseSenateGaugeVersion !=  null)
 {
 arrFieldListForInsert.Add(conPubClassCase.IdPubClassCaseSenateGaugeVersion);
 var strIdPubClassCaseSenateGaugeVersion = objPubClassCaseEN.IdPubClassCaseSenateGaugeVersion.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdPubClassCaseSenateGaugeVersion + "'");
 }
 
 if (objPubClassCaseEN.BrowseCount !=  null)
 {
 arrFieldListForInsert.Add(conPubClassCase.BrowseCount);
 arrValueListForInsert.Add(objPubClassCaseEN.BrowseCount.ToString());
 }
 
 if (objPubClassCaseEN.IdPubCaseType !=  null)
 {
 arrFieldListForInsert.Add(conPubClassCase.IdPubCaseType);
 var strIdPubCaseType = objPubClassCaseEN.IdPubCaseType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdPubCaseType + "'");
 }
 
 if (objPubClassCaseEN.IdStudyLevel !=  null)
 {
 arrFieldListForInsert.Add(conPubClassCase.IdStudyLevel);
 var strIdStudyLevel = objPubClassCaseEN.IdStudyLevel.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdStudyLevel + "'");
 }
 
 if (objPubClassCaseEN.CDID !=  null)
 {
 arrFieldListForInsert.Add(conPubClassCase.CDID);
 var strCDID = objPubClassCaseEN.CDID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCDID + "'");
 }
 
 if (objPubClassCaseEN.Introduction !=  null)
 {
 arrFieldListForInsert.Add(conPubClassCase.Introduction);
 var strIntroduction = objPubClassCaseEN.Introduction.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIntroduction + "'");
 }
 
 arrFieldListForInsert.Add(conPubClassCase.IsVisible);
 arrValueListForInsert.Add("'" + (objPubClassCaseEN.IsVisible  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conPubClassCase.IsDualVideo);
 arrValueListForInsert.Add("'" + (objPubClassCaseEN.IsDualVideo  ==  false ? "0" : "1") + "'");
 
 if (objPubClassCaseEN.RecommendedDegreeId !=  null)
 {
 arrFieldListForInsert.Add(conPubClassCase.RecommendedDegreeId);
 var strRecommendedDegreeId = objPubClassCaseEN.RecommendedDegreeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRecommendedDegreeId + "'");
 }
 
 if (objPubClassCaseEN.ftpFileType !=  null)
 {
 arrFieldListForInsert.Add(conPubClassCase.ftpFileType);
 var strftpFileType = objPubClassCaseEN.ftpFileType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strftpFileType + "'");
 }
 
 if (objPubClassCaseEN.VideoUrl !=  null)
 {
 arrFieldListForInsert.Add(conPubClassCase.VideoUrl);
 var strVideoUrl = objPubClassCaseEN.VideoUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVideoUrl + "'");
 }
 
 if (objPubClassCaseEN.VideoPath !=  null)
 {
 arrFieldListForInsert.Add(conPubClassCase.VideoPath);
 var strVideoPath = objPubClassCaseEN.VideoPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVideoPath + "'");
 }
 
 if (objPubClassCaseEN.ResErrMsg !=  null)
 {
 arrFieldListForInsert.Add(conPubClassCase.ResErrMsg);
 var strResErrMsg = objPubClassCaseEN.ResErrMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strResErrMsg + "'");
 }
 
 if (objPubClassCaseEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conPubClassCase.UpdDate);
 var strUpdDate = objPubClassCaseEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objPubClassCaseEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(conPubClassCase.UpdUserId);
 var strUpdUserId = objPubClassCaseEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objPubClassCaseEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conPubClassCase.Memo);
 var strMemo = objPubClassCaseEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into PubClassCase");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPubClassCaseDA.GetSpecSQLObj();
 objSQL.ExecSql(strSQL.ToString());
return objPubClassCaseEN.IdPubClassCase;
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objPubClassCaseEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsPubClassCaseEN objPubClassCaseEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objPubClassCaseEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objPubClassCaseEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objPubClassCaseEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objPubClassCaseEN.IdPubClassCase !=  null)
 {
 arrFieldListForInsert.Add(conPubClassCase.IdPubClassCase);
 var strIdPubClassCase = objPubClassCaseEN.IdPubClassCase.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdPubClassCase + "'");
 }
 
 if (objPubClassCaseEN.PubClassCaseID !=  null)
 {
 arrFieldListForInsert.Add(conPubClassCase.PubClassCaseID);
 var strPubClassCaseID = objPubClassCaseEN.PubClassCaseID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPubClassCaseID + "'");
 }
 
 if (objPubClassCaseEN.PubClassCaseName !=  null)
 {
 arrFieldListForInsert.Add(conPubClassCase.PubClassCaseName);
 var strPubClassCaseName = objPubClassCaseEN.PubClassCaseName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPubClassCaseName + "'");
 }
 
 if (objPubClassCaseEN.PubClassCaseExecutor !=  null)
 {
 arrFieldListForInsert.Add(conPubClassCase.PubClassCaseExecutor);
 var strPubClassCaseExecutor = objPubClassCaseEN.PubClassCaseExecutor.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPubClassCaseExecutor + "'");
 }
 
 if (objPubClassCaseEN.WorkUnit !=  null)
 {
 arrFieldListForInsert.Add(conPubClassCase.WorkUnit);
 var strWorkUnit = objPubClassCaseEN.WorkUnit.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strWorkUnit + "'");
 }
 
 if (objPubClassCaseEN.PubClassCaseTheme !=  null)
 {
 arrFieldListForInsert.Add(conPubClassCase.PubClassCaseTheme);
 var strPubClassCaseTheme = objPubClassCaseEN.PubClassCaseTheme.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPubClassCaseTheme + "'");
 }
 
 if (objPubClassCaseEN.PubClassCaseBG !=  null)
 {
 arrFieldListForInsert.Add(conPubClassCase.PubClassCaseBG);
 var strPubClassCaseBG = objPubClassCaseEN.PubClassCaseBG.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPubClassCaseBG + "'");
 }
 
 if (objPubClassCaseEN.PubClassCaseTeachDate !=  null)
 {
 arrFieldListForInsert.Add(conPubClassCase.PubClassCaseTeachDate);
 var strPubClassCaseTeachDate = objPubClassCaseEN.PubClassCaseTeachDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPubClassCaseTeachDate + "'");
 }
 
 if (objPubClassCaseEN.PubClassCaseDateIn !=  null)
 {
 arrFieldListForInsert.Add(conPubClassCase.PubClassCaseDateIn);
 var strPubClassCaseDateIn = objPubClassCaseEN.PubClassCaseDateIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPubClassCaseDateIn + "'");
 }
 
 if (objPubClassCaseEN.IdDiscipline  ==  "")
 {
 objPubClassCaseEN.IdDiscipline = null;
 }
 if (objPubClassCaseEN.IdDiscipline !=  null)
 {
 arrFieldListForInsert.Add(conPubClassCase.IdDiscipline);
 var strIdDiscipline = objPubClassCaseEN.IdDiscipline.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdDiscipline + "'");
 }
 
 if (objPubClassCaseEN.IdTeachingPlan !=  null)
 {
 arrFieldListForInsert.Add(conPubClassCase.IdTeachingPlan);
 var strIdTeachingPlan = objPubClassCaseEN.IdTeachingPlan.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdTeachingPlan + "'");
 }
 
 if (objPubClassCaseEN.PubClassCaseTimeIn !=  null)
 {
 arrFieldListForInsert.Add(conPubClassCase.PubClassCaseTimeIn);
 var strPubClassCaseTimeIn = objPubClassCaseEN.PubClassCaseTimeIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPubClassCaseTimeIn + "'");
 }
 
 if (objPubClassCaseEN.IdPubClassCaseSenateGaugeVersion !=  null)
 {
 arrFieldListForInsert.Add(conPubClassCase.IdPubClassCaseSenateGaugeVersion);
 var strIdPubClassCaseSenateGaugeVersion = objPubClassCaseEN.IdPubClassCaseSenateGaugeVersion.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdPubClassCaseSenateGaugeVersion + "'");
 }
 
 if (objPubClassCaseEN.BrowseCount !=  null)
 {
 arrFieldListForInsert.Add(conPubClassCase.BrowseCount);
 arrValueListForInsert.Add(objPubClassCaseEN.BrowseCount.ToString());
 }
 
 if (objPubClassCaseEN.IdPubCaseType !=  null)
 {
 arrFieldListForInsert.Add(conPubClassCase.IdPubCaseType);
 var strIdPubCaseType = objPubClassCaseEN.IdPubCaseType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdPubCaseType + "'");
 }
 
 if (objPubClassCaseEN.IdStudyLevel !=  null)
 {
 arrFieldListForInsert.Add(conPubClassCase.IdStudyLevel);
 var strIdStudyLevel = objPubClassCaseEN.IdStudyLevel.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdStudyLevel + "'");
 }
 
 if (objPubClassCaseEN.CDID !=  null)
 {
 arrFieldListForInsert.Add(conPubClassCase.CDID);
 var strCDID = objPubClassCaseEN.CDID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCDID + "'");
 }
 
 if (objPubClassCaseEN.Introduction !=  null)
 {
 arrFieldListForInsert.Add(conPubClassCase.Introduction);
 var strIntroduction = objPubClassCaseEN.Introduction.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIntroduction + "'");
 }
 
 arrFieldListForInsert.Add(conPubClassCase.IsVisible);
 arrValueListForInsert.Add("'" + (objPubClassCaseEN.IsVisible  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conPubClassCase.IsDualVideo);
 arrValueListForInsert.Add("'" + (objPubClassCaseEN.IsDualVideo  ==  false ? "0" : "1") + "'");
 
 if (objPubClassCaseEN.RecommendedDegreeId !=  null)
 {
 arrFieldListForInsert.Add(conPubClassCase.RecommendedDegreeId);
 var strRecommendedDegreeId = objPubClassCaseEN.RecommendedDegreeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRecommendedDegreeId + "'");
 }
 
 if (objPubClassCaseEN.ftpFileType !=  null)
 {
 arrFieldListForInsert.Add(conPubClassCase.ftpFileType);
 var strftpFileType = objPubClassCaseEN.ftpFileType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strftpFileType + "'");
 }
 
 if (objPubClassCaseEN.VideoUrl !=  null)
 {
 arrFieldListForInsert.Add(conPubClassCase.VideoUrl);
 var strVideoUrl = objPubClassCaseEN.VideoUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVideoUrl + "'");
 }
 
 if (objPubClassCaseEN.VideoPath !=  null)
 {
 arrFieldListForInsert.Add(conPubClassCase.VideoPath);
 var strVideoPath = objPubClassCaseEN.VideoPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVideoPath + "'");
 }
 
 if (objPubClassCaseEN.ResErrMsg !=  null)
 {
 arrFieldListForInsert.Add(conPubClassCase.ResErrMsg);
 var strResErrMsg = objPubClassCaseEN.ResErrMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strResErrMsg + "'");
 }
 
 if (objPubClassCaseEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conPubClassCase.UpdDate);
 var strUpdDate = objPubClassCaseEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objPubClassCaseEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(conPubClassCase.UpdUserId);
 var strUpdUserId = objPubClassCaseEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objPubClassCaseEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conPubClassCase.Memo);
 var strMemo = objPubClassCaseEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into PubClassCase");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPubClassCaseDA.GetSpecSQLObj();
    objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
return objPubClassCaseEN.IdPubClassCase;
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objPubClassCaseEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsPubClassCaseEN objPubClassCaseEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objPubClassCaseEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objPubClassCaseEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objPubClassCaseEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objPubClassCaseEN.IdPubClassCase !=  null)
 {
 arrFieldListForInsert.Add(conPubClassCase.IdPubClassCase);
 var strIdPubClassCase = objPubClassCaseEN.IdPubClassCase.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdPubClassCase + "'");
 }
 
 if (objPubClassCaseEN.PubClassCaseID !=  null)
 {
 arrFieldListForInsert.Add(conPubClassCase.PubClassCaseID);
 var strPubClassCaseID = objPubClassCaseEN.PubClassCaseID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPubClassCaseID + "'");
 }
 
 if (objPubClassCaseEN.PubClassCaseName !=  null)
 {
 arrFieldListForInsert.Add(conPubClassCase.PubClassCaseName);
 var strPubClassCaseName = objPubClassCaseEN.PubClassCaseName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPubClassCaseName + "'");
 }
 
 if (objPubClassCaseEN.PubClassCaseExecutor !=  null)
 {
 arrFieldListForInsert.Add(conPubClassCase.PubClassCaseExecutor);
 var strPubClassCaseExecutor = objPubClassCaseEN.PubClassCaseExecutor.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPubClassCaseExecutor + "'");
 }
 
 if (objPubClassCaseEN.WorkUnit !=  null)
 {
 arrFieldListForInsert.Add(conPubClassCase.WorkUnit);
 var strWorkUnit = objPubClassCaseEN.WorkUnit.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strWorkUnit + "'");
 }
 
 if (objPubClassCaseEN.PubClassCaseTheme !=  null)
 {
 arrFieldListForInsert.Add(conPubClassCase.PubClassCaseTheme);
 var strPubClassCaseTheme = objPubClassCaseEN.PubClassCaseTheme.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPubClassCaseTheme + "'");
 }
 
 if (objPubClassCaseEN.PubClassCaseBG !=  null)
 {
 arrFieldListForInsert.Add(conPubClassCase.PubClassCaseBG);
 var strPubClassCaseBG = objPubClassCaseEN.PubClassCaseBG.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPubClassCaseBG + "'");
 }
 
 if (objPubClassCaseEN.PubClassCaseTeachDate !=  null)
 {
 arrFieldListForInsert.Add(conPubClassCase.PubClassCaseTeachDate);
 var strPubClassCaseTeachDate = objPubClassCaseEN.PubClassCaseTeachDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPubClassCaseTeachDate + "'");
 }
 
 if (objPubClassCaseEN.PubClassCaseDateIn !=  null)
 {
 arrFieldListForInsert.Add(conPubClassCase.PubClassCaseDateIn);
 var strPubClassCaseDateIn = objPubClassCaseEN.PubClassCaseDateIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPubClassCaseDateIn + "'");
 }
 
 if (objPubClassCaseEN.IdDiscipline  ==  "")
 {
 objPubClassCaseEN.IdDiscipline = null;
 }
 if (objPubClassCaseEN.IdDiscipline !=  null)
 {
 arrFieldListForInsert.Add(conPubClassCase.IdDiscipline);
 var strIdDiscipline = objPubClassCaseEN.IdDiscipline.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdDiscipline + "'");
 }
 
 if (objPubClassCaseEN.IdTeachingPlan !=  null)
 {
 arrFieldListForInsert.Add(conPubClassCase.IdTeachingPlan);
 var strIdTeachingPlan = objPubClassCaseEN.IdTeachingPlan.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdTeachingPlan + "'");
 }
 
 if (objPubClassCaseEN.PubClassCaseTimeIn !=  null)
 {
 arrFieldListForInsert.Add(conPubClassCase.PubClassCaseTimeIn);
 var strPubClassCaseTimeIn = objPubClassCaseEN.PubClassCaseTimeIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPubClassCaseTimeIn + "'");
 }
 
 if (objPubClassCaseEN.IdPubClassCaseSenateGaugeVersion !=  null)
 {
 arrFieldListForInsert.Add(conPubClassCase.IdPubClassCaseSenateGaugeVersion);
 var strIdPubClassCaseSenateGaugeVersion = objPubClassCaseEN.IdPubClassCaseSenateGaugeVersion.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdPubClassCaseSenateGaugeVersion + "'");
 }
 
 if (objPubClassCaseEN.BrowseCount !=  null)
 {
 arrFieldListForInsert.Add(conPubClassCase.BrowseCount);
 arrValueListForInsert.Add(objPubClassCaseEN.BrowseCount.ToString());
 }
 
 if (objPubClassCaseEN.IdPubCaseType !=  null)
 {
 arrFieldListForInsert.Add(conPubClassCase.IdPubCaseType);
 var strIdPubCaseType = objPubClassCaseEN.IdPubCaseType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdPubCaseType + "'");
 }
 
 if (objPubClassCaseEN.IdStudyLevel !=  null)
 {
 arrFieldListForInsert.Add(conPubClassCase.IdStudyLevel);
 var strIdStudyLevel = objPubClassCaseEN.IdStudyLevel.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdStudyLevel + "'");
 }
 
 if (objPubClassCaseEN.CDID !=  null)
 {
 arrFieldListForInsert.Add(conPubClassCase.CDID);
 var strCDID = objPubClassCaseEN.CDID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCDID + "'");
 }
 
 if (objPubClassCaseEN.Introduction !=  null)
 {
 arrFieldListForInsert.Add(conPubClassCase.Introduction);
 var strIntroduction = objPubClassCaseEN.Introduction.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIntroduction + "'");
 }
 
 arrFieldListForInsert.Add(conPubClassCase.IsVisible);
 arrValueListForInsert.Add("'" + (objPubClassCaseEN.IsVisible  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conPubClassCase.IsDualVideo);
 arrValueListForInsert.Add("'" + (objPubClassCaseEN.IsDualVideo  ==  false ? "0" : "1") + "'");
 
 if (objPubClassCaseEN.RecommendedDegreeId !=  null)
 {
 arrFieldListForInsert.Add(conPubClassCase.RecommendedDegreeId);
 var strRecommendedDegreeId = objPubClassCaseEN.RecommendedDegreeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRecommendedDegreeId + "'");
 }
 
 if (objPubClassCaseEN.ftpFileType !=  null)
 {
 arrFieldListForInsert.Add(conPubClassCase.ftpFileType);
 var strftpFileType = objPubClassCaseEN.ftpFileType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strftpFileType + "'");
 }
 
 if (objPubClassCaseEN.VideoUrl !=  null)
 {
 arrFieldListForInsert.Add(conPubClassCase.VideoUrl);
 var strVideoUrl = objPubClassCaseEN.VideoUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVideoUrl + "'");
 }
 
 if (objPubClassCaseEN.VideoPath !=  null)
 {
 arrFieldListForInsert.Add(conPubClassCase.VideoPath);
 var strVideoPath = objPubClassCaseEN.VideoPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVideoPath + "'");
 }
 
 if (objPubClassCaseEN.ResErrMsg !=  null)
 {
 arrFieldListForInsert.Add(conPubClassCase.ResErrMsg);
 var strResErrMsg = objPubClassCaseEN.ResErrMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strResErrMsg + "'");
 }
 
 if (objPubClassCaseEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conPubClassCase.UpdDate);
 var strUpdDate = objPubClassCaseEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objPubClassCaseEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(conPubClassCase.UpdUserId);
 var strUpdUserId = objPubClassCaseEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objPubClassCaseEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conPubClassCase.Memo);
 var strMemo = objPubClassCaseEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into PubClassCase");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPubClassCaseDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewPubClassCases(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPubClassCaseDA.GetSpecSQLObj();
strSQL = "Select * from PubClassCase where IdPubClassCase = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "PubClassCase");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
string strIdPubClassCase = oRow[conPubClassCase.IdPubClassCase].ToString().Trim();
if (IsExist(strIdPubClassCase))
{
 string strResult = "关键字变量值为:" + string.Format("IdPubClassCase = {0}", strIdPubClassCase) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsPubClassCaseEN._CurrTabName ].NewRow();
objRow[conPubClassCase.IdPubClassCase] = oRow[conPubClassCase.IdPubClassCase].ToString().Trim(); //案例流水号
objRow[conPubClassCase.PubClassCaseID] = oRow[conPubClassCase.PubClassCaseID].ToString().Trim(); //案例ID
objRow[conPubClassCase.PubClassCaseName] = oRow[conPubClassCase.PubClassCaseName].ToString().Trim(); //案例课题名称
objRow[conPubClassCase.PubClassCaseExecutor] = oRow[conPubClassCase.PubClassCaseExecutor].ToString().Trim(); //案例执教者
objRow[conPubClassCase.WorkUnit] = oRow[conPubClassCase.WorkUnit].ToString().Trim(); //工作单位
objRow[conPubClassCase.PubClassCaseTheme] = oRow[conPubClassCase.PubClassCaseTheme].ToString().Trim(); //案例主题词
objRow[conPubClassCase.PubClassCaseBG] = oRow[conPubClassCase.PubClassCaseBG].ToString().Trim(); //案例背景资料
objRow[conPubClassCase.PubClassCaseTeachDate] = oRow[conPubClassCase.PubClassCaseTeachDate].ToString().Trim(); //案例授课日期
objRow[conPubClassCase.PubClassCaseDateIn] = oRow[conPubClassCase.PubClassCaseDateIn].ToString().Trim(); //案例入库日期
objRow[conPubClassCase.IdDiscipline] = oRow[conPubClassCase.IdDiscipline].ToString().Trim(); //学科流水号
objRow[conPubClassCase.IdTeachingPlan] = oRow[conPubClassCase.IdTeachingPlan].ToString().Trim(); //教案流水号
objRow[conPubClassCase.PubClassCaseTimeIn] = oRow[conPubClassCase.PubClassCaseTimeIn].ToString().Trim(); //案例入库时间
objRow[conPubClassCase.IdPubClassCaseSenateGaugeVersion] = oRow[conPubClassCase.IdPubClassCaseSenateGaugeVersion].ToString().Trim(); //公开课量表版本流水号
objRow[conPubClassCase.BrowseCount] = oRow[conPubClassCase.BrowseCount].ToString().Trim(); //浏览次数
objRow[conPubClassCase.IdPubCaseType] = oRow[conPubClassCase.IdPubCaseType].ToString().Trim(); //公开课案例类型流水号
objRow[conPubClassCase.IdStudyLevel] = oRow[conPubClassCase.IdStudyLevel].ToString().Trim(); //学段流水号
objRow[conPubClassCase.CDID] = oRow[conPubClassCase.CDID].ToString().Trim(); //光盘编号
objRow[conPubClassCase.Introduction] = oRow[conPubClassCase.Introduction].ToString().Trim(); //简要介绍
objRow[conPubClassCase.IsVisible] = oRow[conPubClassCase.IsVisible].ToString().Trim(); //是否显示
objRow[conPubClassCase.IsDualVideo] = oRow[conPubClassCase.IsDualVideo].ToString().Trim(); //是否双视频
objRow[conPubClassCase.RecommendedDegreeId] = oRow[conPubClassCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objRow[conPubClassCase.ftpFileType] = oRow[conPubClassCase.ftpFileType].ToString().Trim(); //ftp文件类型
objRow[conPubClassCase.VideoUrl] = oRow[conPubClassCase.VideoUrl].ToString().Trim(); //视频Url
objRow[conPubClassCase.VideoPath] = oRow[conPubClassCase.VideoPath].ToString().Trim(); //视频目录
objRow[conPubClassCase.ResErrMsg] = oRow[conPubClassCase.ResErrMsg].ToString().Trim(); //资源错误信息
objRow[conPubClassCase.UpdDate] = oRow[conPubClassCase.UpdDate].ToString().Trim(); //修改日期
objRow[conPubClassCase.UpdUserId] = oRow[conPubClassCase.UpdUserId].ToString().Trim(); //修改用户Id
objRow[conPubClassCase.Memo] = oRow[conPubClassCase.Memo].ToString().Trim(); //备注
 objDS.Tables[clsPubClassCaseEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsPubClassCaseEN._CurrTabName);
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
 /// <param name = "objPubClassCaseEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsPubClassCaseEN objPubClassCaseEN)
{
 objPubClassCaseEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objPubClassCaseEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objPubClassCaseEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPubClassCaseDA.GetSpecSQLObj();
strSQL = "Select * from PubClassCase where IdPubClassCase = " + "'"+ objPubClassCaseEN.IdPubClassCase+"'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsPubClassCaseEN._CurrTabName);
if (objDS.Tables[clsPubClassCaseEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:IdPubClassCase = " + "'"+ objPubClassCaseEN.IdPubClassCase+"'");
return false;
}
objRow = objDS.Tables[clsPubClassCaseEN._CurrTabName].Rows[0];
 if (objPubClassCaseEN.IsUpdated(conPubClassCase.IdPubClassCase))
 {
objRow[conPubClassCase.IdPubClassCase] = objPubClassCaseEN.IdPubClassCase; //案例流水号
 }
 if (objPubClassCaseEN.IsUpdated(conPubClassCase.PubClassCaseID))
 {
objRow[conPubClassCase.PubClassCaseID] = objPubClassCaseEN.PubClassCaseID; //案例ID
 }
 if (objPubClassCaseEN.IsUpdated(conPubClassCase.PubClassCaseName))
 {
objRow[conPubClassCase.PubClassCaseName] = objPubClassCaseEN.PubClassCaseName; //案例课题名称
 }
 if (objPubClassCaseEN.IsUpdated(conPubClassCase.PubClassCaseExecutor))
 {
objRow[conPubClassCase.PubClassCaseExecutor] = objPubClassCaseEN.PubClassCaseExecutor; //案例执教者
 }
 if (objPubClassCaseEN.IsUpdated(conPubClassCase.WorkUnit))
 {
objRow[conPubClassCase.WorkUnit] = objPubClassCaseEN.WorkUnit; //工作单位
 }
 if (objPubClassCaseEN.IsUpdated(conPubClassCase.PubClassCaseTheme))
 {
objRow[conPubClassCase.PubClassCaseTheme] = objPubClassCaseEN.PubClassCaseTheme; //案例主题词
 }
 if (objPubClassCaseEN.IsUpdated(conPubClassCase.PubClassCaseBG))
 {
objRow[conPubClassCase.PubClassCaseBG] = objPubClassCaseEN.PubClassCaseBG; //案例背景资料
 }
 if (objPubClassCaseEN.IsUpdated(conPubClassCase.PubClassCaseTeachDate))
 {
objRow[conPubClassCase.PubClassCaseTeachDate] = objPubClassCaseEN.PubClassCaseTeachDate; //案例授课日期
 }
 if (objPubClassCaseEN.IsUpdated(conPubClassCase.PubClassCaseDateIn))
 {
objRow[conPubClassCase.PubClassCaseDateIn] = objPubClassCaseEN.PubClassCaseDateIn; //案例入库日期
 }
 if (objPubClassCaseEN.IsUpdated(conPubClassCase.IdDiscipline))
 {
objRow[conPubClassCase.IdDiscipline] = objPubClassCaseEN.IdDiscipline; //学科流水号
 }
 if (objPubClassCaseEN.IsUpdated(conPubClassCase.IdTeachingPlan))
 {
objRow[conPubClassCase.IdTeachingPlan] = objPubClassCaseEN.IdTeachingPlan; //教案流水号
 }
 if (objPubClassCaseEN.IsUpdated(conPubClassCase.PubClassCaseTimeIn))
 {
objRow[conPubClassCase.PubClassCaseTimeIn] = objPubClassCaseEN.PubClassCaseTimeIn; //案例入库时间
 }
 if (objPubClassCaseEN.IsUpdated(conPubClassCase.IdPubClassCaseSenateGaugeVersion))
 {
objRow[conPubClassCase.IdPubClassCaseSenateGaugeVersion] = objPubClassCaseEN.IdPubClassCaseSenateGaugeVersion; //公开课量表版本流水号
 }
 if (objPubClassCaseEN.IsUpdated(conPubClassCase.BrowseCount))
 {
objRow[conPubClassCase.BrowseCount] = objPubClassCaseEN.BrowseCount; //浏览次数
 }
 if (objPubClassCaseEN.IsUpdated(conPubClassCase.IdPubCaseType))
 {
objRow[conPubClassCase.IdPubCaseType] = objPubClassCaseEN.IdPubCaseType; //公开课案例类型流水号
 }
 if (objPubClassCaseEN.IsUpdated(conPubClassCase.IdStudyLevel))
 {
objRow[conPubClassCase.IdStudyLevel] = objPubClassCaseEN.IdStudyLevel; //学段流水号
 }
 if (objPubClassCaseEN.IsUpdated(conPubClassCase.CDID))
 {
objRow[conPubClassCase.CDID] = objPubClassCaseEN.CDID; //光盘编号
 }
 if (objPubClassCaseEN.IsUpdated(conPubClassCase.Introduction))
 {
objRow[conPubClassCase.Introduction] = objPubClassCaseEN.Introduction; //简要介绍
 }
 if (objPubClassCaseEN.IsUpdated(conPubClassCase.IsVisible))
 {
objRow[conPubClassCase.IsVisible] = objPubClassCaseEN.IsVisible; //是否显示
 }
 if (objPubClassCaseEN.IsUpdated(conPubClassCase.IsDualVideo))
 {
objRow[conPubClassCase.IsDualVideo] = objPubClassCaseEN.IsDualVideo; //是否双视频
 }
 if (objPubClassCaseEN.IsUpdated(conPubClassCase.RecommendedDegreeId))
 {
objRow[conPubClassCase.RecommendedDegreeId] = objPubClassCaseEN.RecommendedDegreeId; //推荐度Id
 }
 if (objPubClassCaseEN.IsUpdated(conPubClassCase.ftpFileType))
 {
objRow[conPubClassCase.ftpFileType] = objPubClassCaseEN.ftpFileType; //ftp文件类型
 }
 if (objPubClassCaseEN.IsUpdated(conPubClassCase.VideoUrl))
 {
objRow[conPubClassCase.VideoUrl] = objPubClassCaseEN.VideoUrl; //视频Url
 }
 if (objPubClassCaseEN.IsUpdated(conPubClassCase.VideoPath))
 {
objRow[conPubClassCase.VideoPath] = objPubClassCaseEN.VideoPath; //视频目录
 }
 if (objPubClassCaseEN.IsUpdated(conPubClassCase.ResErrMsg))
 {
objRow[conPubClassCase.ResErrMsg] = objPubClassCaseEN.ResErrMsg; //资源错误信息
 }
 if (objPubClassCaseEN.IsUpdated(conPubClassCase.UpdDate))
 {
objRow[conPubClassCase.UpdDate] = objPubClassCaseEN.UpdDate; //修改日期
 }
 if (objPubClassCaseEN.IsUpdated(conPubClassCase.UpdUserId))
 {
objRow[conPubClassCase.UpdUserId] = objPubClassCaseEN.UpdUserId; //修改用户Id
 }
 if (objPubClassCaseEN.IsUpdated(conPubClassCase.Memo))
 {
objRow[conPubClassCase.Memo] = objPubClassCaseEN.Memo; //备注
 }
try
{
objDA.Update(objDS, clsPubClassCaseEN._CurrTabName);
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
 /// <param name = "objPubClassCaseEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsPubClassCaseEN objPubClassCaseEN)
{
 objPubClassCaseEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objPubClassCaseEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objPubClassCaseEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPubClassCaseDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update PubClassCase Set ");
 
 if (objPubClassCaseEN.IsUpdated(conPubClassCase.PubClassCaseID))
 {
 if (objPubClassCaseEN.PubClassCaseID !=  null)
 {
 var strPubClassCaseID = objPubClassCaseEN.PubClassCaseID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPubClassCaseID, conPubClassCase.PubClassCaseID); //案例ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPubClassCase.PubClassCaseID); //案例ID
 }
 }
 
 if (objPubClassCaseEN.IsUpdated(conPubClassCase.PubClassCaseName))
 {
 if (objPubClassCaseEN.PubClassCaseName !=  null)
 {
 var strPubClassCaseName = objPubClassCaseEN.PubClassCaseName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPubClassCaseName, conPubClassCase.PubClassCaseName); //案例课题名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPubClassCase.PubClassCaseName); //案例课题名称
 }
 }
 
 if (objPubClassCaseEN.IsUpdated(conPubClassCase.PubClassCaseExecutor))
 {
 if (objPubClassCaseEN.PubClassCaseExecutor !=  null)
 {
 var strPubClassCaseExecutor = objPubClassCaseEN.PubClassCaseExecutor.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPubClassCaseExecutor, conPubClassCase.PubClassCaseExecutor); //案例执教者
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPubClassCase.PubClassCaseExecutor); //案例执教者
 }
 }
 
 if (objPubClassCaseEN.IsUpdated(conPubClassCase.WorkUnit))
 {
 if (objPubClassCaseEN.WorkUnit !=  null)
 {
 var strWorkUnit = objPubClassCaseEN.WorkUnit.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strWorkUnit, conPubClassCase.WorkUnit); //工作单位
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPubClassCase.WorkUnit); //工作单位
 }
 }
 
 if (objPubClassCaseEN.IsUpdated(conPubClassCase.PubClassCaseTheme))
 {
 if (objPubClassCaseEN.PubClassCaseTheme !=  null)
 {
 var strPubClassCaseTheme = objPubClassCaseEN.PubClassCaseTheme.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPubClassCaseTheme, conPubClassCase.PubClassCaseTheme); //案例主题词
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPubClassCase.PubClassCaseTheme); //案例主题词
 }
 }
 
 if (objPubClassCaseEN.IsUpdated(conPubClassCase.PubClassCaseBG))
 {
 if (objPubClassCaseEN.PubClassCaseBG !=  null)
 {
 var strPubClassCaseBG = objPubClassCaseEN.PubClassCaseBG.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPubClassCaseBG, conPubClassCase.PubClassCaseBG); //案例背景资料
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPubClassCase.PubClassCaseBG); //案例背景资料
 }
 }
 
 if (objPubClassCaseEN.IsUpdated(conPubClassCase.PubClassCaseTeachDate))
 {
 if (objPubClassCaseEN.PubClassCaseTeachDate !=  null)
 {
 var strPubClassCaseTeachDate = objPubClassCaseEN.PubClassCaseTeachDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPubClassCaseTeachDate, conPubClassCase.PubClassCaseTeachDate); //案例授课日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPubClassCase.PubClassCaseTeachDate); //案例授课日期
 }
 }
 
 if (objPubClassCaseEN.IsUpdated(conPubClassCase.PubClassCaseDateIn))
 {
 if (objPubClassCaseEN.PubClassCaseDateIn !=  null)
 {
 var strPubClassCaseDateIn = objPubClassCaseEN.PubClassCaseDateIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPubClassCaseDateIn, conPubClassCase.PubClassCaseDateIn); //案例入库日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPubClassCase.PubClassCaseDateIn); //案例入库日期
 }
 }
 
 if (objPubClassCaseEN.IsUpdated(conPubClassCase.IdDiscipline))
 {
 if (objPubClassCaseEN.IdDiscipline  ==  "")
 {
 objPubClassCaseEN.IdDiscipline = null;
 }
 if (objPubClassCaseEN.IdDiscipline !=  null)
 {
 var strIdDiscipline = objPubClassCaseEN.IdDiscipline.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdDiscipline, conPubClassCase.IdDiscipline); //学科流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPubClassCase.IdDiscipline); //学科流水号
 }
 }
 
 if (objPubClassCaseEN.IsUpdated(conPubClassCase.IdTeachingPlan))
 {
 if (objPubClassCaseEN.IdTeachingPlan !=  null)
 {
 var strIdTeachingPlan = objPubClassCaseEN.IdTeachingPlan.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdTeachingPlan, conPubClassCase.IdTeachingPlan); //教案流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPubClassCase.IdTeachingPlan); //教案流水号
 }
 }
 
 if (objPubClassCaseEN.IsUpdated(conPubClassCase.PubClassCaseTimeIn))
 {
 if (objPubClassCaseEN.PubClassCaseTimeIn !=  null)
 {
 var strPubClassCaseTimeIn = objPubClassCaseEN.PubClassCaseTimeIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPubClassCaseTimeIn, conPubClassCase.PubClassCaseTimeIn); //案例入库时间
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPubClassCase.PubClassCaseTimeIn); //案例入库时间
 }
 }
 
 if (objPubClassCaseEN.IsUpdated(conPubClassCase.IdPubClassCaseSenateGaugeVersion))
 {
 if (objPubClassCaseEN.IdPubClassCaseSenateGaugeVersion !=  null)
 {
 var strIdPubClassCaseSenateGaugeVersion = objPubClassCaseEN.IdPubClassCaseSenateGaugeVersion.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdPubClassCaseSenateGaugeVersion, conPubClassCase.IdPubClassCaseSenateGaugeVersion); //公开课量表版本流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPubClassCase.IdPubClassCaseSenateGaugeVersion); //公开课量表版本流水号
 }
 }
 
 if (objPubClassCaseEN.IsUpdated(conPubClassCase.BrowseCount))
 {
 if (objPubClassCaseEN.BrowseCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objPubClassCaseEN.BrowseCount, conPubClassCase.BrowseCount); //浏览次数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPubClassCase.BrowseCount); //浏览次数
 }
 }
 
 if (objPubClassCaseEN.IsUpdated(conPubClassCase.IdPubCaseType))
 {
 if (objPubClassCaseEN.IdPubCaseType !=  null)
 {
 var strIdPubCaseType = objPubClassCaseEN.IdPubCaseType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdPubCaseType, conPubClassCase.IdPubCaseType); //公开课案例类型流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPubClassCase.IdPubCaseType); //公开课案例类型流水号
 }
 }
 
 if (objPubClassCaseEN.IsUpdated(conPubClassCase.IdStudyLevel))
 {
 if (objPubClassCaseEN.IdStudyLevel !=  null)
 {
 var strIdStudyLevel = objPubClassCaseEN.IdStudyLevel.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdStudyLevel, conPubClassCase.IdStudyLevel); //学段流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPubClassCase.IdStudyLevel); //学段流水号
 }
 }
 
 if (objPubClassCaseEN.IsUpdated(conPubClassCase.CDID))
 {
 if (objPubClassCaseEN.CDID !=  null)
 {
 var strCDID = objPubClassCaseEN.CDID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCDID, conPubClassCase.CDID); //光盘编号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPubClassCase.CDID); //光盘编号
 }
 }
 
 if (objPubClassCaseEN.IsUpdated(conPubClassCase.Introduction))
 {
 if (objPubClassCaseEN.Introduction !=  null)
 {
 var strIntroduction = objPubClassCaseEN.Introduction.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIntroduction, conPubClassCase.Introduction); //简要介绍
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPubClassCase.Introduction); //简要介绍
 }
 }
 
 if (objPubClassCaseEN.IsUpdated(conPubClassCase.IsVisible))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objPubClassCaseEN.IsVisible == true?"1":"0", conPubClassCase.IsVisible); //是否显示
 }
 
 if (objPubClassCaseEN.IsUpdated(conPubClassCase.IsDualVideo))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objPubClassCaseEN.IsDualVideo == true?"1":"0", conPubClassCase.IsDualVideo); //是否双视频
 }
 
 if (objPubClassCaseEN.IsUpdated(conPubClassCase.RecommendedDegreeId))
 {
 if (objPubClassCaseEN.RecommendedDegreeId !=  null)
 {
 var strRecommendedDegreeId = objPubClassCaseEN.RecommendedDegreeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strRecommendedDegreeId, conPubClassCase.RecommendedDegreeId); //推荐度Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPubClassCase.RecommendedDegreeId); //推荐度Id
 }
 }
 
 if (objPubClassCaseEN.IsUpdated(conPubClassCase.ftpFileType))
 {
 if (objPubClassCaseEN.ftpFileType !=  null)
 {
 var strftpFileType = objPubClassCaseEN.ftpFileType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strftpFileType, conPubClassCase.ftpFileType); //ftp文件类型
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPubClassCase.ftpFileType); //ftp文件类型
 }
 }
 
 if (objPubClassCaseEN.IsUpdated(conPubClassCase.VideoUrl))
 {
 if (objPubClassCaseEN.VideoUrl !=  null)
 {
 var strVideoUrl = objPubClassCaseEN.VideoUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strVideoUrl, conPubClassCase.VideoUrl); //视频Url
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPubClassCase.VideoUrl); //视频Url
 }
 }
 
 if (objPubClassCaseEN.IsUpdated(conPubClassCase.VideoPath))
 {
 if (objPubClassCaseEN.VideoPath !=  null)
 {
 var strVideoPath = objPubClassCaseEN.VideoPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strVideoPath, conPubClassCase.VideoPath); //视频目录
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPubClassCase.VideoPath); //视频目录
 }
 }
 
 if (objPubClassCaseEN.IsUpdated(conPubClassCase.ResErrMsg))
 {
 if (objPubClassCaseEN.ResErrMsg !=  null)
 {
 var strResErrMsg = objPubClassCaseEN.ResErrMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strResErrMsg, conPubClassCase.ResErrMsg); //资源错误信息
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPubClassCase.ResErrMsg); //资源错误信息
 }
 }
 
 if (objPubClassCaseEN.IsUpdated(conPubClassCase.UpdDate))
 {
 if (objPubClassCaseEN.UpdDate !=  null)
 {
 var strUpdDate = objPubClassCaseEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conPubClassCase.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPubClassCase.UpdDate); //修改日期
 }
 }
 
 if (objPubClassCaseEN.IsUpdated(conPubClassCase.UpdUserId))
 {
 if (objPubClassCaseEN.UpdUserId !=  null)
 {
 var strUpdUserId = objPubClassCaseEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUserId, conPubClassCase.UpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPubClassCase.UpdUserId); //修改用户Id
 }
 }
 
 if (objPubClassCaseEN.IsUpdated(conPubClassCase.Memo))
 {
 if (objPubClassCaseEN.Memo !=  null)
 {
 var strMemo = objPubClassCaseEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conPubClassCase.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPubClassCase.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where IdPubClassCase = '{0}'", objPubClassCaseEN.IdPubClassCase); 
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
 /// <param name = "objPubClassCaseEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsPubClassCaseEN objPubClassCaseEN, string strCondition)
{
 objPubClassCaseEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objPubClassCaseEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objPubClassCaseEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPubClassCaseDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update PubClassCase Set ");
 
 if (objPubClassCaseEN.IsUpdated(conPubClassCase.PubClassCaseID))
 {
 if (objPubClassCaseEN.PubClassCaseID !=  null)
 {
 var strPubClassCaseID = objPubClassCaseEN.PubClassCaseID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PubClassCaseID = '{0}',", strPubClassCaseID); //案例ID
 }
 else
 {
 sbSQL.Append(" PubClassCaseID = null,"); //案例ID
 }
 }
 
 if (objPubClassCaseEN.IsUpdated(conPubClassCase.PubClassCaseName))
 {
 if (objPubClassCaseEN.PubClassCaseName !=  null)
 {
 var strPubClassCaseName = objPubClassCaseEN.PubClassCaseName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PubClassCaseName = '{0}',", strPubClassCaseName); //案例课题名称
 }
 else
 {
 sbSQL.Append(" PubClassCaseName = null,"); //案例课题名称
 }
 }
 
 if (objPubClassCaseEN.IsUpdated(conPubClassCase.PubClassCaseExecutor))
 {
 if (objPubClassCaseEN.PubClassCaseExecutor !=  null)
 {
 var strPubClassCaseExecutor = objPubClassCaseEN.PubClassCaseExecutor.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PubClassCaseExecutor = '{0}',", strPubClassCaseExecutor); //案例执教者
 }
 else
 {
 sbSQL.Append(" PubClassCaseExecutor = null,"); //案例执教者
 }
 }
 
 if (objPubClassCaseEN.IsUpdated(conPubClassCase.WorkUnit))
 {
 if (objPubClassCaseEN.WorkUnit !=  null)
 {
 var strWorkUnit = objPubClassCaseEN.WorkUnit.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" WorkUnit = '{0}',", strWorkUnit); //工作单位
 }
 else
 {
 sbSQL.Append(" WorkUnit = null,"); //工作单位
 }
 }
 
 if (objPubClassCaseEN.IsUpdated(conPubClassCase.PubClassCaseTheme))
 {
 if (objPubClassCaseEN.PubClassCaseTheme !=  null)
 {
 var strPubClassCaseTheme = objPubClassCaseEN.PubClassCaseTheme.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PubClassCaseTheme = '{0}',", strPubClassCaseTheme); //案例主题词
 }
 else
 {
 sbSQL.Append(" PubClassCaseTheme = null,"); //案例主题词
 }
 }
 
 if (objPubClassCaseEN.IsUpdated(conPubClassCase.PubClassCaseBG))
 {
 if (objPubClassCaseEN.PubClassCaseBG !=  null)
 {
 var strPubClassCaseBG = objPubClassCaseEN.PubClassCaseBG.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PubClassCaseBG = '{0}',", strPubClassCaseBG); //案例背景资料
 }
 else
 {
 sbSQL.Append(" PubClassCaseBG = null,"); //案例背景资料
 }
 }
 
 if (objPubClassCaseEN.IsUpdated(conPubClassCase.PubClassCaseTeachDate))
 {
 if (objPubClassCaseEN.PubClassCaseTeachDate !=  null)
 {
 var strPubClassCaseTeachDate = objPubClassCaseEN.PubClassCaseTeachDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PubClassCaseTeachDate = '{0}',", strPubClassCaseTeachDate); //案例授课日期
 }
 else
 {
 sbSQL.Append(" PubClassCaseTeachDate = null,"); //案例授课日期
 }
 }
 
 if (objPubClassCaseEN.IsUpdated(conPubClassCase.PubClassCaseDateIn))
 {
 if (objPubClassCaseEN.PubClassCaseDateIn !=  null)
 {
 var strPubClassCaseDateIn = objPubClassCaseEN.PubClassCaseDateIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PubClassCaseDateIn = '{0}',", strPubClassCaseDateIn); //案例入库日期
 }
 else
 {
 sbSQL.Append(" PubClassCaseDateIn = null,"); //案例入库日期
 }
 }
 
 if (objPubClassCaseEN.IsUpdated(conPubClassCase.IdDiscipline))
 {
 if (objPubClassCaseEN.IdDiscipline  ==  "")
 {
 objPubClassCaseEN.IdDiscipline = null;
 }
 if (objPubClassCaseEN.IdDiscipline !=  null)
 {
 var strIdDiscipline = objPubClassCaseEN.IdDiscipline.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdDiscipline = '{0}',", strIdDiscipline); //学科流水号
 }
 else
 {
 sbSQL.Append(" IdDiscipline = null,"); //学科流水号
 }
 }
 
 if (objPubClassCaseEN.IsUpdated(conPubClassCase.IdTeachingPlan))
 {
 if (objPubClassCaseEN.IdTeachingPlan !=  null)
 {
 var strIdTeachingPlan = objPubClassCaseEN.IdTeachingPlan.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdTeachingPlan = '{0}',", strIdTeachingPlan); //教案流水号
 }
 else
 {
 sbSQL.Append(" IdTeachingPlan = null,"); //教案流水号
 }
 }
 
 if (objPubClassCaseEN.IsUpdated(conPubClassCase.PubClassCaseTimeIn))
 {
 if (objPubClassCaseEN.PubClassCaseTimeIn !=  null)
 {
 var strPubClassCaseTimeIn = objPubClassCaseEN.PubClassCaseTimeIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PubClassCaseTimeIn = '{0}',", strPubClassCaseTimeIn); //案例入库时间
 }
 else
 {
 sbSQL.Append(" PubClassCaseTimeIn = null,"); //案例入库时间
 }
 }
 
 if (objPubClassCaseEN.IsUpdated(conPubClassCase.IdPubClassCaseSenateGaugeVersion))
 {
 if (objPubClassCaseEN.IdPubClassCaseSenateGaugeVersion !=  null)
 {
 var strIdPubClassCaseSenateGaugeVersion = objPubClassCaseEN.IdPubClassCaseSenateGaugeVersion.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdPubClassCaseSenateGaugeVersion = '{0}',", strIdPubClassCaseSenateGaugeVersion); //公开课量表版本流水号
 }
 else
 {
 sbSQL.Append(" IdPubClassCaseSenateGaugeVersion = null,"); //公开课量表版本流水号
 }
 }
 
 if (objPubClassCaseEN.IsUpdated(conPubClassCase.BrowseCount))
 {
 if (objPubClassCaseEN.BrowseCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objPubClassCaseEN.BrowseCount, conPubClassCase.BrowseCount); //浏览次数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPubClassCase.BrowseCount); //浏览次数
 }
 }
 
 if (objPubClassCaseEN.IsUpdated(conPubClassCase.IdPubCaseType))
 {
 if (objPubClassCaseEN.IdPubCaseType !=  null)
 {
 var strIdPubCaseType = objPubClassCaseEN.IdPubCaseType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdPubCaseType = '{0}',", strIdPubCaseType); //公开课案例类型流水号
 }
 else
 {
 sbSQL.Append(" IdPubCaseType = null,"); //公开课案例类型流水号
 }
 }
 
 if (objPubClassCaseEN.IsUpdated(conPubClassCase.IdStudyLevel))
 {
 if (objPubClassCaseEN.IdStudyLevel !=  null)
 {
 var strIdStudyLevel = objPubClassCaseEN.IdStudyLevel.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdStudyLevel = '{0}',", strIdStudyLevel); //学段流水号
 }
 else
 {
 sbSQL.Append(" IdStudyLevel = null,"); //学段流水号
 }
 }
 
 if (objPubClassCaseEN.IsUpdated(conPubClassCase.CDID))
 {
 if (objPubClassCaseEN.CDID !=  null)
 {
 var strCDID = objPubClassCaseEN.CDID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CDID = '{0}',", strCDID); //光盘编号
 }
 else
 {
 sbSQL.Append(" CDID = null,"); //光盘编号
 }
 }
 
 if (objPubClassCaseEN.IsUpdated(conPubClassCase.Introduction))
 {
 if (objPubClassCaseEN.Introduction !=  null)
 {
 var strIntroduction = objPubClassCaseEN.Introduction.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Introduction = '{0}',", strIntroduction); //简要介绍
 }
 else
 {
 sbSQL.Append(" Introduction = null,"); //简要介绍
 }
 }
 
 if (objPubClassCaseEN.IsUpdated(conPubClassCase.IsVisible))
 {
 sbSQL.AppendFormat(" IsVisible = '{0}',", objPubClassCaseEN.IsVisible == true?"1":"0"); //是否显示
 }
 
 if (objPubClassCaseEN.IsUpdated(conPubClassCase.IsDualVideo))
 {
 sbSQL.AppendFormat(" IsDualVideo = '{0}',", objPubClassCaseEN.IsDualVideo == true?"1":"0"); //是否双视频
 }
 
 if (objPubClassCaseEN.IsUpdated(conPubClassCase.RecommendedDegreeId))
 {
 if (objPubClassCaseEN.RecommendedDegreeId !=  null)
 {
 var strRecommendedDegreeId = objPubClassCaseEN.RecommendedDegreeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" RecommendedDegreeId = '{0}',", strRecommendedDegreeId); //推荐度Id
 }
 else
 {
 sbSQL.Append(" RecommendedDegreeId = null,"); //推荐度Id
 }
 }
 
 if (objPubClassCaseEN.IsUpdated(conPubClassCase.ftpFileType))
 {
 if (objPubClassCaseEN.ftpFileType !=  null)
 {
 var strftpFileType = objPubClassCaseEN.ftpFileType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ftpFileType = '{0}',", strftpFileType); //ftp文件类型
 }
 else
 {
 sbSQL.Append(" ftpFileType = null,"); //ftp文件类型
 }
 }
 
 if (objPubClassCaseEN.IsUpdated(conPubClassCase.VideoUrl))
 {
 if (objPubClassCaseEN.VideoUrl !=  null)
 {
 var strVideoUrl = objPubClassCaseEN.VideoUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" VideoUrl = '{0}',", strVideoUrl); //视频Url
 }
 else
 {
 sbSQL.Append(" VideoUrl = null,"); //视频Url
 }
 }
 
 if (objPubClassCaseEN.IsUpdated(conPubClassCase.VideoPath))
 {
 if (objPubClassCaseEN.VideoPath !=  null)
 {
 var strVideoPath = objPubClassCaseEN.VideoPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" VideoPath = '{0}',", strVideoPath); //视频目录
 }
 else
 {
 sbSQL.Append(" VideoPath = null,"); //视频目录
 }
 }
 
 if (objPubClassCaseEN.IsUpdated(conPubClassCase.ResErrMsg))
 {
 if (objPubClassCaseEN.ResErrMsg !=  null)
 {
 var strResErrMsg = objPubClassCaseEN.ResErrMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ResErrMsg = '{0}',", strResErrMsg); //资源错误信息
 }
 else
 {
 sbSQL.Append(" ResErrMsg = null,"); //资源错误信息
 }
 }
 
 if (objPubClassCaseEN.IsUpdated(conPubClassCase.UpdDate))
 {
 if (objPubClassCaseEN.UpdDate !=  null)
 {
 var strUpdDate = objPubClassCaseEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objPubClassCaseEN.IsUpdated(conPubClassCase.UpdUserId))
 {
 if (objPubClassCaseEN.UpdUserId !=  null)
 {
 var strUpdUserId = objPubClassCaseEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUserId = '{0}',", strUpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.Append(" UpdUserId = null,"); //修改用户Id
 }
 }
 
 if (objPubClassCaseEN.IsUpdated(conPubClassCase.Memo))
 {
 if (objPubClassCaseEN.Memo !=  null)
 {
 var strMemo = objPubClassCaseEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objPubClassCaseEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsPubClassCaseEN objPubClassCaseEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objPubClassCaseEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objPubClassCaseEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objPubClassCaseEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPubClassCaseDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update PubClassCase Set ");
 
 if (objPubClassCaseEN.IsUpdated(conPubClassCase.PubClassCaseID))
 {
 if (objPubClassCaseEN.PubClassCaseID !=  null)
 {
 var strPubClassCaseID = objPubClassCaseEN.PubClassCaseID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PubClassCaseID = '{0}',", strPubClassCaseID); //案例ID
 }
 else
 {
 sbSQL.Append(" PubClassCaseID = null,"); //案例ID
 }
 }
 
 if (objPubClassCaseEN.IsUpdated(conPubClassCase.PubClassCaseName))
 {
 if (objPubClassCaseEN.PubClassCaseName !=  null)
 {
 var strPubClassCaseName = objPubClassCaseEN.PubClassCaseName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PubClassCaseName = '{0}',", strPubClassCaseName); //案例课题名称
 }
 else
 {
 sbSQL.Append(" PubClassCaseName = null,"); //案例课题名称
 }
 }
 
 if (objPubClassCaseEN.IsUpdated(conPubClassCase.PubClassCaseExecutor))
 {
 if (objPubClassCaseEN.PubClassCaseExecutor !=  null)
 {
 var strPubClassCaseExecutor = objPubClassCaseEN.PubClassCaseExecutor.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PubClassCaseExecutor = '{0}',", strPubClassCaseExecutor); //案例执教者
 }
 else
 {
 sbSQL.Append(" PubClassCaseExecutor = null,"); //案例执教者
 }
 }
 
 if (objPubClassCaseEN.IsUpdated(conPubClassCase.WorkUnit))
 {
 if (objPubClassCaseEN.WorkUnit !=  null)
 {
 var strWorkUnit = objPubClassCaseEN.WorkUnit.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" WorkUnit = '{0}',", strWorkUnit); //工作单位
 }
 else
 {
 sbSQL.Append(" WorkUnit = null,"); //工作单位
 }
 }
 
 if (objPubClassCaseEN.IsUpdated(conPubClassCase.PubClassCaseTheme))
 {
 if (objPubClassCaseEN.PubClassCaseTheme !=  null)
 {
 var strPubClassCaseTheme = objPubClassCaseEN.PubClassCaseTheme.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PubClassCaseTheme = '{0}',", strPubClassCaseTheme); //案例主题词
 }
 else
 {
 sbSQL.Append(" PubClassCaseTheme = null,"); //案例主题词
 }
 }
 
 if (objPubClassCaseEN.IsUpdated(conPubClassCase.PubClassCaseBG))
 {
 if (objPubClassCaseEN.PubClassCaseBG !=  null)
 {
 var strPubClassCaseBG = objPubClassCaseEN.PubClassCaseBG.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PubClassCaseBG = '{0}',", strPubClassCaseBG); //案例背景资料
 }
 else
 {
 sbSQL.Append(" PubClassCaseBG = null,"); //案例背景资料
 }
 }
 
 if (objPubClassCaseEN.IsUpdated(conPubClassCase.PubClassCaseTeachDate))
 {
 if (objPubClassCaseEN.PubClassCaseTeachDate !=  null)
 {
 var strPubClassCaseTeachDate = objPubClassCaseEN.PubClassCaseTeachDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PubClassCaseTeachDate = '{0}',", strPubClassCaseTeachDate); //案例授课日期
 }
 else
 {
 sbSQL.Append(" PubClassCaseTeachDate = null,"); //案例授课日期
 }
 }
 
 if (objPubClassCaseEN.IsUpdated(conPubClassCase.PubClassCaseDateIn))
 {
 if (objPubClassCaseEN.PubClassCaseDateIn !=  null)
 {
 var strPubClassCaseDateIn = objPubClassCaseEN.PubClassCaseDateIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PubClassCaseDateIn = '{0}',", strPubClassCaseDateIn); //案例入库日期
 }
 else
 {
 sbSQL.Append(" PubClassCaseDateIn = null,"); //案例入库日期
 }
 }
 
 if (objPubClassCaseEN.IsUpdated(conPubClassCase.IdDiscipline))
 {
 if (objPubClassCaseEN.IdDiscipline  ==  "")
 {
 objPubClassCaseEN.IdDiscipline = null;
 }
 if (objPubClassCaseEN.IdDiscipline !=  null)
 {
 var strIdDiscipline = objPubClassCaseEN.IdDiscipline.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdDiscipline = '{0}',", strIdDiscipline); //学科流水号
 }
 else
 {
 sbSQL.Append(" IdDiscipline = null,"); //学科流水号
 }
 }
 
 if (objPubClassCaseEN.IsUpdated(conPubClassCase.IdTeachingPlan))
 {
 if (objPubClassCaseEN.IdTeachingPlan !=  null)
 {
 var strIdTeachingPlan = objPubClassCaseEN.IdTeachingPlan.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdTeachingPlan = '{0}',", strIdTeachingPlan); //教案流水号
 }
 else
 {
 sbSQL.Append(" IdTeachingPlan = null,"); //教案流水号
 }
 }
 
 if (objPubClassCaseEN.IsUpdated(conPubClassCase.PubClassCaseTimeIn))
 {
 if (objPubClassCaseEN.PubClassCaseTimeIn !=  null)
 {
 var strPubClassCaseTimeIn = objPubClassCaseEN.PubClassCaseTimeIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PubClassCaseTimeIn = '{0}',", strPubClassCaseTimeIn); //案例入库时间
 }
 else
 {
 sbSQL.Append(" PubClassCaseTimeIn = null,"); //案例入库时间
 }
 }
 
 if (objPubClassCaseEN.IsUpdated(conPubClassCase.IdPubClassCaseSenateGaugeVersion))
 {
 if (objPubClassCaseEN.IdPubClassCaseSenateGaugeVersion !=  null)
 {
 var strIdPubClassCaseSenateGaugeVersion = objPubClassCaseEN.IdPubClassCaseSenateGaugeVersion.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdPubClassCaseSenateGaugeVersion = '{0}',", strIdPubClassCaseSenateGaugeVersion); //公开课量表版本流水号
 }
 else
 {
 sbSQL.Append(" IdPubClassCaseSenateGaugeVersion = null,"); //公开课量表版本流水号
 }
 }
 
 if (objPubClassCaseEN.IsUpdated(conPubClassCase.BrowseCount))
 {
 if (objPubClassCaseEN.BrowseCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objPubClassCaseEN.BrowseCount, conPubClassCase.BrowseCount); //浏览次数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPubClassCase.BrowseCount); //浏览次数
 }
 }
 
 if (objPubClassCaseEN.IsUpdated(conPubClassCase.IdPubCaseType))
 {
 if (objPubClassCaseEN.IdPubCaseType !=  null)
 {
 var strIdPubCaseType = objPubClassCaseEN.IdPubCaseType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdPubCaseType = '{0}',", strIdPubCaseType); //公开课案例类型流水号
 }
 else
 {
 sbSQL.Append(" IdPubCaseType = null,"); //公开课案例类型流水号
 }
 }
 
 if (objPubClassCaseEN.IsUpdated(conPubClassCase.IdStudyLevel))
 {
 if (objPubClassCaseEN.IdStudyLevel !=  null)
 {
 var strIdStudyLevel = objPubClassCaseEN.IdStudyLevel.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdStudyLevel = '{0}',", strIdStudyLevel); //学段流水号
 }
 else
 {
 sbSQL.Append(" IdStudyLevel = null,"); //学段流水号
 }
 }
 
 if (objPubClassCaseEN.IsUpdated(conPubClassCase.CDID))
 {
 if (objPubClassCaseEN.CDID !=  null)
 {
 var strCDID = objPubClassCaseEN.CDID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CDID = '{0}',", strCDID); //光盘编号
 }
 else
 {
 sbSQL.Append(" CDID = null,"); //光盘编号
 }
 }
 
 if (objPubClassCaseEN.IsUpdated(conPubClassCase.Introduction))
 {
 if (objPubClassCaseEN.Introduction !=  null)
 {
 var strIntroduction = objPubClassCaseEN.Introduction.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Introduction = '{0}',", strIntroduction); //简要介绍
 }
 else
 {
 sbSQL.Append(" Introduction = null,"); //简要介绍
 }
 }
 
 if (objPubClassCaseEN.IsUpdated(conPubClassCase.IsVisible))
 {
 sbSQL.AppendFormat(" IsVisible = '{0}',", objPubClassCaseEN.IsVisible == true?"1":"0"); //是否显示
 }
 
 if (objPubClassCaseEN.IsUpdated(conPubClassCase.IsDualVideo))
 {
 sbSQL.AppendFormat(" IsDualVideo = '{0}',", objPubClassCaseEN.IsDualVideo == true?"1":"0"); //是否双视频
 }
 
 if (objPubClassCaseEN.IsUpdated(conPubClassCase.RecommendedDegreeId))
 {
 if (objPubClassCaseEN.RecommendedDegreeId !=  null)
 {
 var strRecommendedDegreeId = objPubClassCaseEN.RecommendedDegreeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" RecommendedDegreeId = '{0}',", strRecommendedDegreeId); //推荐度Id
 }
 else
 {
 sbSQL.Append(" RecommendedDegreeId = null,"); //推荐度Id
 }
 }
 
 if (objPubClassCaseEN.IsUpdated(conPubClassCase.ftpFileType))
 {
 if (objPubClassCaseEN.ftpFileType !=  null)
 {
 var strftpFileType = objPubClassCaseEN.ftpFileType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ftpFileType = '{0}',", strftpFileType); //ftp文件类型
 }
 else
 {
 sbSQL.Append(" ftpFileType = null,"); //ftp文件类型
 }
 }
 
 if (objPubClassCaseEN.IsUpdated(conPubClassCase.VideoUrl))
 {
 if (objPubClassCaseEN.VideoUrl !=  null)
 {
 var strVideoUrl = objPubClassCaseEN.VideoUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" VideoUrl = '{0}',", strVideoUrl); //视频Url
 }
 else
 {
 sbSQL.Append(" VideoUrl = null,"); //视频Url
 }
 }
 
 if (objPubClassCaseEN.IsUpdated(conPubClassCase.VideoPath))
 {
 if (objPubClassCaseEN.VideoPath !=  null)
 {
 var strVideoPath = objPubClassCaseEN.VideoPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" VideoPath = '{0}',", strVideoPath); //视频目录
 }
 else
 {
 sbSQL.Append(" VideoPath = null,"); //视频目录
 }
 }
 
 if (objPubClassCaseEN.IsUpdated(conPubClassCase.ResErrMsg))
 {
 if (objPubClassCaseEN.ResErrMsg !=  null)
 {
 var strResErrMsg = objPubClassCaseEN.ResErrMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ResErrMsg = '{0}',", strResErrMsg); //资源错误信息
 }
 else
 {
 sbSQL.Append(" ResErrMsg = null,"); //资源错误信息
 }
 }
 
 if (objPubClassCaseEN.IsUpdated(conPubClassCase.UpdDate))
 {
 if (objPubClassCaseEN.UpdDate !=  null)
 {
 var strUpdDate = objPubClassCaseEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objPubClassCaseEN.IsUpdated(conPubClassCase.UpdUserId))
 {
 if (objPubClassCaseEN.UpdUserId !=  null)
 {
 var strUpdUserId = objPubClassCaseEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUserId = '{0}',", strUpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.Append(" UpdUserId = null,"); //修改用户Id
 }
 }
 
 if (objPubClassCaseEN.IsUpdated(conPubClassCase.Memo))
 {
 if (objPubClassCaseEN.Memo !=  null)
 {
 var strMemo = objPubClassCaseEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objPubClassCaseEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsPubClassCaseEN objPubClassCaseEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objPubClassCaseEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objPubClassCaseEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objPubClassCaseEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPubClassCaseDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update PubClassCase Set ");
 
 if (objPubClassCaseEN.IsUpdated(conPubClassCase.PubClassCaseID))
 {
 if (objPubClassCaseEN.PubClassCaseID !=  null)
 {
 var strPubClassCaseID = objPubClassCaseEN.PubClassCaseID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPubClassCaseID, conPubClassCase.PubClassCaseID); //案例ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPubClassCase.PubClassCaseID); //案例ID
 }
 }
 
 if (objPubClassCaseEN.IsUpdated(conPubClassCase.PubClassCaseName))
 {
 if (objPubClassCaseEN.PubClassCaseName !=  null)
 {
 var strPubClassCaseName = objPubClassCaseEN.PubClassCaseName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPubClassCaseName, conPubClassCase.PubClassCaseName); //案例课题名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPubClassCase.PubClassCaseName); //案例课题名称
 }
 }
 
 if (objPubClassCaseEN.IsUpdated(conPubClassCase.PubClassCaseExecutor))
 {
 if (objPubClassCaseEN.PubClassCaseExecutor !=  null)
 {
 var strPubClassCaseExecutor = objPubClassCaseEN.PubClassCaseExecutor.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPubClassCaseExecutor, conPubClassCase.PubClassCaseExecutor); //案例执教者
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPubClassCase.PubClassCaseExecutor); //案例执教者
 }
 }
 
 if (objPubClassCaseEN.IsUpdated(conPubClassCase.WorkUnit))
 {
 if (objPubClassCaseEN.WorkUnit !=  null)
 {
 var strWorkUnit = objPubClassCaseEN.WorkUnit.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strWorkUnit, conPubClassCase.WorkUnit); //工作单位
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPubClassCase.WorkUnit); //工作单位
 }
 }
 
 if (objPubClassCaseEN.IsUpdated(conPubClassCase.PubClassCaseTheme))
 {
 if (objPubClassCaseEN.PubClassCaseTheme !=  null)
 {
 var strPubClassCaseTheme = objPubClassCaseEN.PubClassCaseTheme.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPubClassCaseTheme, conPubClassCase.PubClassCaseTheme); //案例主题词
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPubClassCase.PubClassCaseTheme); //案例主题词
 }
 }
 
 if (objPubClassCaseEN.IsUpdated(conPubClassCase.PubClassCaseBG))
 {
 if (objPubClassCaseEN.PubClassCaseBG !=  null)
 {
 var strPubClassCaseBG = objPubClassCaseEN.PubClassCaseBG.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPubClassCaseBG, conPubClassCase.PubClassCaseBG); //案例背景资料
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPubClassCase.PubClassCaseBG); //案例背景资料
 }
 }
 
 if (objPubClassCaseEN.IsUpdated(conPubClassCase.PubClassCaseTeachDate))
 {
 if (objPubClassCaseEN.PubClassCaseTeachDate !=  null)
 {
 var strPubClassCaseTeachDate = objPubClassCaseEN.PubClassCaseTeachDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPubClassCaseTeachDate, conPubClassCase.PubClassCaseTeachDate); //案例授课日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPubClassCase.PubClassCaseTeachDate); //案例授课日期
 }
 }
 
 if (objPubClassCaseEN.IsUpdated(conPubClassCase.PubClassCaseDateIn))
 {
 if (objPubClassCaseEN.PubClassCaseDateIn !=  null)
 {
 var strPubClassCaseDateIn = objPubClassCaseEN.PubClassCaseDateIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPubClassCaseDateIn, conPubClassCase.PubClassCaseDateIn); //案例入库日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPubClassCase.PubClassCaseDateIn); //案例入库日期
 }
 }
 
 if (objPubClassCaseEN.IsUpdated(conPubClassCase.IdDiscipline))
 {
 if (objPubClassCaseEN.IdDiscipline  ==  "")
 {
 objPubClassCaseEN.IdDiscipline = null;
 }
 if (objPubClassCaseEN.IdDiscipline !=  null)
 {
 var strIdDiscipline = objPubClassCaseEN.IdDiscipline.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdDiscipline, conPubClassCase.IdDiscipline); //学科流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPubClassCase.IdDiscipline); //学科流水号
 }
 }
 
 if (objPubClassCaseEN.IsUpdated(conPubClassCase.IdTeachingPlan))
 {
 if (objPubClassCaseEN.IdTeachingPlan !=  null)
 {
 var strIdTeachingPlan = objPubClassCaseEN.IdTeachingPlan.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdTeachingPlan, conPubClassCase.IdTeachingPlan); //教案流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPubClassCase.IdTeachingPlan); //教案流水号
 }
 }
 
 if (objPubClassCaseEN.IsUpdated(conPubClassCase.PubClassCaseTimeIn))
 {
 if (objPubClassCaseEN.PubClassCaseTimeIn !=  null)
 {
 var strPubClassCaseTimeIn = objPubClassCaseEN.PubClassCaseTimeIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPubClassCaseTimeIn, conPubClassCase.PubClassCaseTimeIn); //案例入库时间
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPubClassCase.PubClassCaseTimeIn); //案例入库时间
 }
 }
 
 if (objPubClassCaseEN.IsUpdated(conPubClassCase.IdPubClassCaseSenateGaugeVersion))
 {
 if (objPubClassCaseEN.IdPubClassCaseSenateGaugeVersion !=  null)
 {
 var strIdPubClassCaseSenateGaugeVersion = objPubClassCaseEN.IdPubClassCaseSenateGaugeVersion.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdPubClassCaseSenateGaugeVersion, conPubClassCase.IdPubClassCaseSenateGaugeVersion); //公开课量表版本流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPubClassCase.IdPubClassCaseSenateGaugeVersion); //公开课量表版本流水号
 }
 }
 
 if (objPubClassCaseEN.IsUpdated(conPubClassCase.BrowseCount))
 {
 if (objPubClassCaseEN.BrowseCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objPubClassCaseEN.BrowseCount, conPubClassCase.BrowseCount); //浏览次数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPubClassCase.BrowseCount); //浏览次数
 }
 }
 
 if (objPubClassCaseEN.IsUpdated(conPubClassCase.IdPubCaseType))
 {
 if (objPubClassCaseEN.IdPubCaseType !=  null)
 {
 var strIdPubCaseType = objPubClassCaseEN.IdPubCaseType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdPubCaseType, conPubClassCase.IdPubCaseType); //公开课案例类型流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPubClassCase.IdPubCaseType); //公开课案例类型流水号
 }
 }
 
 if (objPubClassCaseEN.IsUpdated(conPubClassCase.IdStudyLevel))
 {
 if (objPubClassCaseEN.IdStudyLevel !=  null)
 {
 var strIdStudyLevel = objPubClassCaseEN.IdStudyLevel.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdStudyLevel, conPubClassCase.IdStudyLevel); //学段流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPubClassCase.IdStudyLevel); //学段流水号
 }
 }
 
 if (objPubClassCaseEN.IsUpdated(conPubClassCase.CDID))
 {
 if (objPubClassCaseEN.CDID !=  null)
 {
 var strCDID = objPubClassCaseEN.CDID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCDID, conPubClassCase.CDID); //光盘编号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPubClassCase.CDID); //光盘编号
 }
 }
 
 if (objPubClassCaseEN.IsUpdated(conPubClassCase.Introduction))
 {
 if (objPubClassCaseEN.Introduction !=  null)
 {
 var strIntroduction = objPubClassCaseEN.Introduction.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIntroduction, conPubClassCase.Introduction); //简要介绍
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPubClassCase.Introduction); //简要介绍
 }
 }
 
 if (objPubClassCaseEN.IsUpdated(conPubClassCase.IsVisible))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objPubClassCaseEN.IsVisible == true?"1":"0", conPubClassCase.IsVisible); //是否显示
 }
 
 if (objPubClassCaseEN.IsUpdated(conPubClassCase.IsDualVideo))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objPubClassCaseEN.IsDualVideo == true?"1":"0", conPubClassCase.IsDualVideo); //是否双视频
 }
 
 if (objPubClassCaseEN.IsUpdated(conPubClassCase.RecommendedDegreeId))
 {
 if (objPubClassCaseEN.RecommendedDegreeId !=  null)
 {
 var strRecommendedDegreeId = objPubClassCaseEN.RecommendedDegreeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strRecommendedDegreeId, conPubClassCase.RecommendedDegreeId); //推荐度Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPubClassCase.RecommendedDegreeId); //推荐度Id
 }
 }
 
 if (objPubClassCaseEN.IsUpdated(conPubClassCase.ftpFileType))
 {
 if (objPubClassCaseEN.ftpFileType !=  null)
 {
 var strftpFileType = objPubClassCaseEN.ftpFileType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strftpFileType, conPubClassCase.ftpFileType); //ftp文件类型
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPubClassCase.ftpFileType); //ftp文件类型
 }
 }
 
 if (objPubClassCaseEN.IsUpdated(conPubClassCase.VideoUrl))
 {
 if (objPubClassCaseEN.VideoUrl !=  null)
 {
 var strVideoUrl = objPubClassCaseEN.VideoUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strVideoUrl, conPubClassCase.VideoUrl); //视频Url
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPubClassCase.VideoUrl); //视频Url
 }
 }
 
 if (objPubClassCaseEN.IsUpdated(conPubClassCase.VideoPath))
 {
 if (objPubClassCaseEN.VideoPath !=  null)
 {
 var strVideoPath = objPubClassCaseEN.VideoPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strVideoPath, conPubClassCase.VideoPath); //视频目录
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPubClassCase.VideoPath); //视频目录
 }
 }
 
 if (objPubClassCaseEN.IsUpdated(conPubClassCase.ResErrMsg))
 {
 if (objPubClassCaseEN.ResErrMsg !=  null)
 {
 var strResErrMsg = objPubClassCaseEN.ResErrMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strResErrMsg, conPubClassCase.ResErrMsg); //资源错误信息
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPubClassCase.ResErrMsg); //资源错误信息
 }
 }
 
 if (objPubClassCaseEN.IsUpdated(conPubClassCase.UpdDate))
 {
 if (objPubClassCaseEN.UpdDate !=  null)
 {
 var strUpdDate = objPubClassCaseEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conPubClassCase.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPubClassCase.UpdDate); //修改日期
 }
 }
 
 if (objPubClassCaseEN.IsUpdated(conPubClassCase.UpdUserId))
 {
 if (objPubClassCaseEN.UpdUserId !=  null)
 {
 var strUpdUserId = objPubClassCaseEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUserId, conPubClassCase.UpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPubClassCase.UpdUserId); //修改用户Id
 }
 }
 
 if (objPubClassCaseEN.IsUpdated(conPubClassCase.Memo))
 {
 if (objPubClassCaseEN.Memo !=  null)
 {
 var strMemo = objPubClassCaseEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conPubClassCase.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPubClassCase.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where IdPubClassCase = '{0}'", objPubClassCaseEN.IdPubClassCase); 
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
 /// <param name = "strIdPubClassCase">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(string strIdPubClassCase) 
{
CheckPrimaryKey(strIdPubClassCase);
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPubClassCaseDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 strIdPubClassCase,
};
 objSQL.ExecSP("PubClassCase_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "strIdPubClassCase">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(string strIdPubClassCase, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
CheckPrimaryKey(strIdPubClassCase);
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPubClassCaseDA.GetSpecSQLObj();
//删除PubClassCase本表中与当前对象有关的记录
strSQL = strSQL + "Delete from PubClassCase where IdPubClassCase = " + "'"+ strIdPubClassCase+"'";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelPubClassCase(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPubClassCaseDA.GetSpecSQLObj();
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
//删除PubClassCase本表中与当前对象有关的记录
strSQL = strSQL + "Delete from PubClassCase where IdPubClassCase in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "strIdPubClassCase">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(string strIdPubClassCase) 
{
CheckPrimaryKey(strIdPubClassCase);
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPubClassCaseDA.GetSpecSQLObj();
//删除PubClassCase本表中与当前对象有关的记录
strSQL = strSQL + "Delete from PubClassCase where IdPubClassCase = " + "'"+ strIdPubClassCase+"'";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelPubClassCase(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsPubClassCaseDA: DelPubClassCase)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPubClassCaseDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from PubClassCase where " + strCondition ;
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
public bool DelPubClassCaseWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsPubClassCaseDA: DelPubClassCaseWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPubClassCaseDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from PubClassCase where " + strCondition ;
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
 /// <param name = "objPubClassCaseENS">源对象</param>
 /// <param name = "objPubClassCaseENT">目标对象</param>
public void CopyTo(clsPubClassCaseEN objPubClassCaseENS, clsPubClassCaseEN objPubClassCaseENT)
{
objPubClassCaseENT.IdPubClassCase = objPubClassCaseENS.IdPubClassCase; //案例流水号
objPubClassCaseENT.PubClassCaseID = objPubClassCaseENS.PubClassCaseID; //案例ID
objPubClassCaseENT.PubClassCaseName = objPubClassCaseENS.PubClassCaseName; //案例课题名称
objPubClassCaseENT.PubClassCaseExecutor = objPubClassCaseENS.PubClassCaseExecutor; //案例执教者
objPubClassCaseENT.WorkUnit = objPubClassCaseENS.WorkUnit; //工作单位
objPubClassCaseENT.PubClassCaseTheme = objPubClassCaseENS.PubClassCaseTheme; //案例主题词
objPubClassCaseENT.PubClassCaseBG = objPubClassCaseENS.PubClassCaseBG; //案例背景资料
objPubClassCaseENT.PubClassCaseTeachDate = objPubClassCaseENS.PubClassCaseTeachDate; //案例授课日期
objPubClassCaseENT.PubClassCaseDateIn = objPubClassCaseENS.PubClassCaseDateIn; //案例入库日期
objPubClassCaseENT.IdDiscipline = objPubClassCaseENS.IdDiscipline; //学科流水号
objPubClassCaseENT.IdTeachingPlan = objPubClassCaseENS.IdTeachingPlan; //教案流水号
objPubClassCaseENT.PubClassCaseTimeIn = objPubClassCaseENS.PubClassCaseTimeIn; //案例入库时间
objPubClassCaseENT.IdPubClassCaseSenateGaugeVersion = objPubClassCaseENS.IdPubClassCaseSenateGaugeVersion; //公开课量表版本流水号
objPubClassCaseENT.BrowseCount = objPubClassCaseENS.BrowseCount; //浏览次数
objPubClassCaseENT.IdPubCaseType = objPubClassCaseENS.IdPubCaseType; //公开课案例类型流水号
objPubClassCaseENT.IdStudyLevel = objPubClassCaseENS.IdStudyLevel; //学段流水号
objPubClassCaseENT.CDID = objPubClassCaseENS.CDID; //光盘编号
objPubClassCaseENT.Introduction = objPubClassCaseENS.Introduction; //简要介绍
objPubClassCaseENT.IsVisible = objPubClassCaseENS.IsVisible; //是否显示
objPubClassCaseENT.IsDualVideo = objPubClassCaseENS.IsDualVideo; //是否双视频
objPubClassCaseENT.RecommendedDegreeId = objPubClassCaseENS.RecommendedDegreeId; //推荐度Id
objPubClassCaseENT.ftpFileType = objPubClassCaseENS.ftpFileType; //ftp文件类型
objPubClassCaseENT.VideoUrl = objPubClassCaseENS.VideoUrl; //视频Url
objPubClassCaseENT.VideoPath = objPubClassCaseENS.VideoPath; //视频目录
objPubClassCaseENT.ResErrMsg = objPubClassCaseENS.ResErrMsg; //资源错误信息
objPubClassCaseENT.UpdDate = objPubClassCaseENS.UpdDate; //修改日期
objPubClassCaseENT.UpdUserId = objPubClassCaseENS.UpdUserId; //修改用户Id
objPubClassCaseENT.Memo = objPubClassCaseENS.Memo; //备注
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsPubClassCaseEN objPubClassCaseEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objPubClassCaseEN.PubClassCaseID, conPubClassCase.PubClassCaseID);
clsCheckSql.CheckFieldNotNull(objPubClassCaseEN.PubClassCaseName, conPubClassCase.PubClassCaseName);
clsCheckSql.CheckFieldNotNull(objPubClassCaseEN.IdDiscipline, conPubClassCase.IdDiscipline);
clsCheckSql.CheckFieldNotNull(objPubClassCaseEN.IdPubClassCaseSenateGaugeVersion, conPubClassCase.IdPubClassCaseSenateGaugeVersion);
clsCheckSql.CheckFieldNotNull(objPubClassCaseEN.RecommendedDegreeId, conPubClassCase.RecommendedDegreeId);
//检查字段长度
clsCheckSql.CheckFieldLen(objPubClassCaseEN.IdPubClassCase, 8, conPubClassCase.IdPubClassCase);
clsCheckSql.CheckFieldLen(objPubClassCaseEN.PubClassCaseID, 8, conPubClassCase.PubClassCaseID);
clsCheckSql.CheckFieldLen(objPubClassCaseEN.PubClassCaseName, 200, conPubClassCase.PubClassCaseName);
clsCheckSql.CheckFieldLen(objPubClassCaseEN.PubClassCaseExecutor, 50, conPubClassCase.PubClassCaseExecutor);
clsCheckSql.CheckFieldLen(objPubClassCaseEN.WorkUnit, 100, conPubClassCase.WorkUnit);
clsCheckSql.CheckFieldLen(objPubClassCaseEN.PubClassCaseTheme, 500, conPubClassCase.PubClassCaseTheme);
clsCheckSql.CheckFieldLen(objPubClassCaseEN.PubClassCaseTeachDate, 8, conPubClassCase.PubClassCaseTeachDate);
clsCheckSql.CheckFieldLen(objPubClassCaseEN.PubClassCaseDateIn, 8, conPubClassCase.PubClassCaseDateIn);
clsCheckSql.CheckFieldLen(objPubClassCaseEN.IdDiscipline, 4, conPubClassCase.IdDiscipline);
clsCheckSql.CheckFieldLen(objPubClassCaseEN.IdTeachingPlan, 8, conPubClassCase.IdTeachingPlan);
clsCheckSql.CheckFieldLen(objPubClassCaseEN.PubClassCaseTimeIn, 6, conPubClassCase.PubClassCaseTimeIn);
clsCheckSql.CheckFieldLen(objPubClassCaseEN.IdPubClassCaseSenateGaugeVersion, 4, conPubClassCase.IdPubClassCaseSenateGaugeVersion);
clsCheckSql.CheckFieldLen(objPubClassCaseEN.IdPubCaseType, 4, conPubClassCase.IdPubCaseType);
clsCheckSql.CheckFieldLen(objPubClassCaseEN.IdStudyLevel, 4, conPubClassCase.IdStudyLevel);
clsCheckSql.CheckFieldLen(objPubClassCaseEN.CDID, 50, conPubClassCase.CDID);
clsCheckSql.CheckFieldLen(objPubClassCaseEN.Introduction, 4000, conPubClassCase.Introduction);
clsCheckSql.CheckFieldLen(objPubClassCaseEN.RecommendedDegreeId, 2, conPubClassCase.RecommendedDegreeId);
clsCheckSql.CheckFieldLen(objPubClassCaseEN.ftpFileType, 30, conPubClassCase.ftpFileType);
clsCheckSql.CheckFieldLen(objPubClassCaseEN.VideoUrl, 1000, conPubClassCase.VideoUrl);
clsCheckSql.CheckFieldLen(objPubClassCaseEN.VideoPath, 1000, conPubClassCase.VideoPath);
clsCheckSql.CheckFieldLen(objPubClassCaseEN.ResErrMsg, 30, conPubClassCase.ResErrMsg);
clsCheckSql.CheckFieldLen(objPubClassCaseEN.UpdDate, 20, conPubClassCase.UpdDate);
clsCheckSql.CheckFieldLen(objPubClassCaseEN.UpdUserId, 20, conPubClassCase.UpdUserId);
clsCheckSql.CheckFieldLen(objPubClassCaseEN.Memo, 1000, conPubClassCase.Memo);
//检查字段外键固定长度
clsCheckSql.CheckFieldForeignKey(objPubClassCaseEN.IdDiscipline, 4, conPubClassCase.IdDiscipline);
 objPubClassCaseEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsPubClassCaseEN objPubClassCaseEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objPubClassCaseEN.PubClassCaseID, 8, conPubClassCase.PubClassCaseID);
clsCheckSql.CheckFieldLen(objPubClassCaseEN.PubClassCaseName, 200, conPubClassCase.PubClassCaseName);
clsCheckSql.CheckFieldLen(objPubClassCaseEN.PubClassCaseExecutor, 50, conPubClassCase.PubClassCaseExecutor);
clsCheckSql.CheckFieldLen(objPubClassCaseEN.WorkUnit, 100, conPubClassCase.WorkUnit);
clsCheckSql.CheckFieldLen(objPubClassCaseEN.PubClassCaseTheme, 500, conPubClassCase.PubClassCaseTheme);
clsCheckSql.CheckFieldLen(objPubClassCaseEN.PubClassCaseTeachDate, 8, conPubClassCase.PubClassCaseTeachDate);
clsCheckSql.CheckFieldLen(objPubClassCaseEN.PubClassCaseDateIn, 8, conPubClassCase.PubClassCaseDateIn);
clsCheckSql.CheckFieldLen(objPubClassCaseEN.IdDiscipline, 4, conPubClassCase.IdDiscipline);
clsCheckSql.CheckFieldLen(objPubClassCaseEN.IdTeachingPlan, 8, conPubClassCase.IdTeachingPlan);
clsCheckSql.CheckFieldLen(objPubClassCaseEN.PubClassCaseTimeIn, 6, conPubClassCase.PubClassCaseTimeIn);
clsCheckSql.CheckFieldLen(objPubClassCaseEN.IdPubClassCaseSenateGaugeVersion, 4, conPubClassCase.IdPubClassCaseSenateGaugeVersion);
clsCheckSql.CheckFieldLen(objPubClassCaseEN.IdPubCaseType, 4, conPubClassCase.IdPubCaseType);
clsCheckSql.CheckFieldLen(objPubClassCaseEN.IdStudyLevel, 4, conPubClassCase.IdStudyLevel);
clsCheckSql.CheckFieldLen(objPubClassCaseEN.CDID, 50, conPubClassCase.CDID);
clsCheckSql.CheckFieldLen(objPubClassCaseEN.Introduction, 4000, conPubClassCase.Introduction);
clsCheckSql.CheckFieldLen(objPubClassCaseEN.RecommendedDegreeId, 2, conPubClassCase.RecommendedDegreeId);
clsCheckSql.CheckFieldLen(objPubClassCaseEN.ftpFileType, 30, conPubClassCase.ftpFileType);
clsCheckSql.CheckFieldLen(objPubClassCaseEN.VideoUrl, 1000, conPubClassCase.VideoUrl);
clsCheckSql.CheckFieldLen(objPubClassCaseEN.VideoPath, 1000, conPubClassCase.VideoPath);
clsCheckSql.CheckFieldLen(objPubClassCaseEN.ResErrMsg, 30, conPubClassCase.ResErrMsg);
clsCheckSql.CheckFieldLen(objPubClassCaseEN.UpdDate, 20, conPubClassCase.UpdDate);
clsCheckSql.CheckFieldLen(objPubClassCaseEN.UpdUserId, 20, conPubClassCase.UpdUserId);
clsCheckSql.CheckFieldLen(objPubClassCaseEN.Memo, 1000, conPubClassCase.Memo);
//检查外键字段长度
clsCheckSql.CheckFieldForeignKey(objPubClassCaseEN.IdDiscipline, 4, conPubClassCase.IdDiscipline);
 objPubClassCaseEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsPubClassCaseEN objPubClassCaseEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objPubClassCaseEN.IdPubClassCase, 8, conPubClassCase.IdPubClassCase);
clsCheckSql.CheckFieldLen(objPubClassCaseEN.PubClassCaseID, 8, conPubClassCase.PubClassCaseID);
clsCheckSql.CheckFieldLen(objPubClassCaseEN.PubClassCaseName, 200, conPubClassCase.PubClassCaseName);
clsCheckSql.CheckFieldLen(objPubClassCaseEN.PubClassCaseExecutor, 50, conPubClassCase.PubClassCaseExecutor);
clsCheckSql.CheckFieldLen(objPubClassCaseEN.WorkUnit, 100, conPubClassCase.WorkUnit);
clsCheckSql.CheckFieldLen(objPubClassCaseEN.PubClassCaseTheme, 500, conPubClassCase.PubClassCaseTheme);
clsCheckSql.CheckFieldLen(objPubClassCaseEN.PubClassCaseTeachDate, 8, conPubClassCase.PubClassCaseTeachDate);
clsCheckSql.CheckFieldLen(objPubClassCaseEN.PubClassCaseDateIn, 8, conPubClassCase.PubClassCaseDateIn);
clsCheckSql.CheckFieldLen(objPubClassCaseEN.IdDiscipline, 4, conPubClassCase.IdDiscipline);
clsCheckSql.CheckFieldLen(objPubClassCaseEN.IdTeachingPlan, 8, conPubClassCase.IdTeachingPlan);
clsCheckSql.CheckFieldLen(objPubClassCaseEN.PubClassCaseTimeIn, 6, conPubClassCase.PubClassCaseTimeIn);
clsCheckSql.CheckFieldLen(objPubClassCaseEN.IdPubClassCaseSenateGaugeVersion, 4, conPubClassCase.IdPubClassCaseSenateGaugeVersion);
clsCheckSql.CheckFieldLen(objPubClassCaseEN.IdPubCaseType, 4, conPubClassCase.IdPubCaseType);
clsCheckSql.CheckFieldLen(objPubClassCaseEN.IdStudyLevel, 4, conPubClassCase.IdStudyLevel);
clsCheckSql.CheckFieldLen(objPubClassCaseEN.CDID, 50, conPubClassCase.CDID);
clsCheckSql.CheckFieldLen(objPubClassCaseEN.Introduction, 4000, conPubClassCase.Introduction);
clsCheckSql.CheckFieldLen(objPubClassCaseEN.RecommendedDegreeId, 2, conPubClassCase.RecommendedDegreeId);
clsCheckSql.CheckFieldLen(objPubClassCaseEN.ftpFileType, 30, conPubClassCase.ftpFileType);
clsCheckSql.CheckFieldLen(objPubClassCaseEN.VideoUrl, 1000, conPubClassCase.VideoUrl);
clsCheckSql.CheckFieldLen(objPubClassCaseEN.VideoPath, 1000, conPubClassCase.VideoPath);
clsCheckSql.CheckFieldLen(objPubClassCaseEN.ResErrMsg, 30, conPubClassCase.ResErrMsg);
clsCheckSql.CheckFieldLen(objPubClassCaseEN.UpdDate, 20, conPubClassCase.UpdDate);
clsCheckSql.CheckFieldLen(objPubClassCaseEN.UpdUserId, 20, conPubClassCase.UpdUserId);
clsCheckSql.CheckFieldLen(objPubClassCaseEN.Memo, 1000, conPubClassCase.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objPubClassCaseEN.IdPubClassCase, conPubClassCase.IdPubClassCase);
clsCheckSql.CheckSqlInjection4Field(objPubClassCaseEN.PubClassCaseID, conPubClassCase.PubClassCaseID);
clsCheckSql.CheckSqlInjection4Field(objPubClassCaseEN.PubClassCaseName, conPubClassCase.PubClassCaseName);
clsCheckSql.CheckSqlInjection4Field(objPubClassCaseEN.PubClassCaseExecutor, conPubClassCase.PubClassCaseExecutor);
clsCheckSql.CheckSqlInjection4Field(objPubClassCaseEN.WorkUnit, conPubClassCase.WorkUnit);
clsCheckSql.CheckSqlInjection4Field(objPubClassCaseEN.PubClassCaseTheme, conPubClassCase.PubClassCaseTheme);
clsCheckSql.CheckSqlInjection4Field(objPubClassCaseEN.PubClassCaseTeachDate, conPubClassCase.PubClassCaseTeachDate);
clsCheckSql.CheckSqlInjection4Field(objPubClassCaseEN.PubClassCaseDateIn, conPubClassCase.PubClassCaseDateIn);
clsCheckSql.CheckSqlInjection4Field(objPubClassCaseEN.IdDiscipline, conPubClassCase.IdDiscipline);
clsCheckSql.CheckSqlInjection4Field(objPubClassCaseEN.IdTeachingPlan, conPubClassCase.IdTeachingPlan);
clsCheckSql.CheckSqlInjection4Field(objPubClassCaseEN.PubClassCaseTimeIn, conPubClassCase.PubClassCaseTimeIn);
clsCheckSql.CheckSqlInjection4Field(objPubClassCaseEN.IdPubClassCaseSenateGaugeVersion, conPubClassCase.IdPubClassCaseSenateGaugeVersion);
clsCheckSql.CheckSqlInjection4Field(objPubClassCaseEN.IdPubCaseType, conPubClassCase.IdPubCaseType);
clsCheckSql.CheckSqlInjection4Field(objPubClassCaseEN.IdStudyLevel, conPubClassCase.IdStudyLevel);
clsCheckSql.CheckSqlInjection4Field(objPubClassCaseEN.CDID, conPubClassCase.CDID);
clsCheckSql.CheckSqlInjection4Field(objPubClassCaseEN.Introduction, conPubClassCase.Introduction);
clsCheckSql.CheckSqlInjection4Field(objPubClassCaseEN.RecommendedDegreeId, conPubClassCase.RecommendedDegreeId);
clsCheckSql.CheckSqlInjection4Field(objPubClassCaseEN.ftpFileType, conPubClassCase.ftpFileType);
clsCheckSql.CheckSqlInjection4Field(objPubClassCaseEN.VideoUrl, conPubClassCase.VideoUrl);
clsCheckSql.CheckSqlInjection4Field(objPubClassCaseEN.VideoPath, conPubClassCase.VideoPath);
clsCheckSql.CheckSqlInjection4Field(objPubClassCaseEN.ResErrMsg, conPubClassCase.ResErrMsg);
clsCheckSql.CheckSqlInjection4Field(objPubClassCaseEN.UpdDate, conPubClassCase.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objPubClassCaseEN.UpdUserId, conPubClassCase.UpdUserId);
clsCheckSql.CheckSqlInjection4Field(objPubClassCaseEN.Memo, conPubClassCase.Memo);
//检查外键字段长度
clsCheckSql.CheckFieldForeignKey(objPubClassCaseEN.IdDiscipline, 4, conPubClassCase.IdDiscipline);
 objPubClassCaseEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 /// <summary>
 /// 获取用于绑定下拉框的DataTable,获取两个字段:1、关键字；2、名称字段
 /// (AutoGCLib.clsGeneCodeBase:Gen_4DAL_GetDataTable4DdlBind)
 /// </summary>
 /// <returns>返回用于绑定下拉框的DataTable</returns>
public System.Data.DataTable GetIdPubClassCase()
{
//获取某学院所有专业信息
string strSQL = "select IdPubClassCase, PubClassCaseName from PubClassCase ";
 clsSpecSQLforSql mySql = clsPubClassCaseDA.GetSpecSQLObj();
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
 objSQL = clsPubClassCaseDA.GetSpecSQLObj();
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
 objSQL = clsPubClassCaseDA.GetSpecSQLObj();
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
 objSQL = clsPubClassCaseDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsPubClassCaseEN._CurrTabName);
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
 objSQL = clsPubClassCaseDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsPubClassCaseEN._CurrTabName, strCondition);
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
 objSQL = clsPubClassCaseDA.GetSpecSQLObj();
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
 objSQL = clsPubClassCaseDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}