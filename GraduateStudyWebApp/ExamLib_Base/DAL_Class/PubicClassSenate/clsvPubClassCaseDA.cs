
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvPubClassCaseDA
 表名:vPubClassCase(01120386)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:48:37
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
 /// v公开课案例(vPubClassCase)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvPubClassCaseDA : clsCommBase4DA
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
 return clsvPubClassCaseEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvPubClassCaseEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvPubClassCaseEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvPubClassCaseEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvPubClassCaseEN._ConnectString);
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
throw new Exception("(errid:Data000001)在表:vPubClassCase中,检查关键字,长度不正确!(clsvPubClassCaseDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strIdPubClassCase)  ==  true)
{
throw new Exception("(errid:Data000002)在表:vPubClassCase中,关键字不能为空 或 null!(clsvPubClassCaseDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strIdPubClassCase);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsvPubClassCaseDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvPubClassCaseDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPubClassCaseDA.GetSpecSQLObj();
strSQL = "Select * from vPubClassCase where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vPubClassCase(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvPubClassCaseDA: GetDataTable_vPubClassCase)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPubClassCaseDA.GetSpecSQLObj();
strSQL = "Select * from vPubClassCase where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvPubClassCaseDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPubClassCaseDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvPubClassCaseDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPubClassCaseDA.GetSpecSQLObj();
strSQL = "Select * from vPubClassCase where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvPubClassCaseDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPubClassCaseDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvPubClassCaseDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPubClassCaseDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vPubClassCase where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vPubClassCase where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvPubClassCaseDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPubClassCaseDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vPubClassCase where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvPubClassCaseDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPubClassCaseDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vPubClassCase.* from vPubClassCase Left Join {1} on {2} where {3} and vPubClassCase.IdPubClassCase not in (Select top {5} vPubClassCase.IdPubClassCase from vPubClassCase Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vPubClassCase where {1} and IdPubClassCase not in (Select top {2} IdPubClassCase from vPubClassCase where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vPubClassCase where {1} and IdPubClassCase not in (Select top {3} IdPubClassCase from vPubClassCase where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvPubClassCaseDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPubClassCaseDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vPubClassCase.* from vPubClassCase Left Join {1} on {2} where {3} and vPubClassCase.IdPubClassCase not in (Select top {5} vPubClassCase.IdPubClassCase from vPubClassCase Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vPubClassCase where {1} and IdPubClassCase not in (Select top {2} IdPubClassCase from vPubClassCase where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vPubClassCase where {1} and IdPubClassCase not in (Select top {3} IdPubClassCase from vPubClassCase where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvPubClassCaseEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvPubClassCaseDA:GetObjLst)", objException.Message));
}
List<clsvPubClassCaseEN> arrObjLst = new List<clsvPubClassCaseEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPubClassCaseDA.GetSpecSQLObj();
strSQL = "Select * from vPubClassCase where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPubClassCaseEN objvPubClassCaseEN = new clsvPubClassCaseEN();
try
{
objvPubClassCaseEN.IdPubClassCase = objRow[convPubClassCase.IdPubClassCase].ToString().Trim(); //案例流水号
objvPubClassCaseEN.PubClassCaseID = objRow[convPubClassCase.PubClassCaseID].ToString().Trim(); //案例ID
objvPubClassCaseEN.PubClassCaseName = objRow[convPubClassCase.PubClassCaseName].ToString().Trim(); //案例课题名称
objvPubClassCaseEN.PubClassCaseExecutor = objRow[convPubClassCase.PubClassCaseExecutor] == DBNull.Value ? null : objRow[convPubClassCase.PubClassCaseExecutor].ToString().Trim(); //案例执教者
objvPubClassCaseEN.WorkUnit = objRow[convPubClassCase.WorkUnit] == DBNull.Value ? null : objRow[convPubClassCase.WorkUnit].ToString().Trim(); //工作单位
objvPubClassCaseEN.PubClassCaseTheme = objRow[convPubClassCase.PubClassCaseTheme] == DBNull.Value ? null : objRow[convPubClassCase.PubClassCaseTheme].ToString().Trim(); //案例主题词
objvPubClassCaseEN.PubClassCaseBG = objRow[convPubClassCase.PubClassCaseBG] == DBNull.Value ? null : objRow[convPubClassCase.PubClassCaseBG].ToString().Trim(); //案例背景资料
objvPubClassCaseEN.PubClassCaseTeachDate = objRow[convPubClassCase.PubClassCaseTeachDate] == DBNull.Value ? null : objRow[convPubClassCase.PubClassCaseTeachDate].ToString().Trim(); //案例授课日期
objvPubClassCaseEN.PubClassCaseDateIn = objRow[convPubClassCase.PubClassCaseDateIn] == DBNull.Value ? null : objRow[convPubClassCase.PubClassCaseDateIn].ToString().Trim(); //案例入库日期
objvPubClassCaseEN.IdDiscipline = objRow[convPubClassCase.IdDiscipline].ToString().Trim(); //学科流水号
objvPubClassCaseEN.DisciplineID = objRow[convPubClassCase.DisciplineID] == DBNull.Value ? null : objRow[convPubClassCase.DisciplineID].ToString().Trim(); //学科ID
objvPubClassCaseEN.DisciplineName = objRow[convPubClassCase.DisciplineName] == DBNull.Value ? null : objRow[convPubClassCase.DisciplineName].ToString().Trim(); //学科名称
objvPubClassCaseEN.IdTeachingPlan = objRow[convPubClassCase.IdTeachingPlan] == DBNull.Value ? null : objRow[convPubClassCase.IdTeachingPlan].ToString().Trim(); //教案流水号
objvPubClassCaseEN.SubjectName = objRow[convPubClassCase.SubjectName] == DBNull.Value ? null : objRow[convPubClassCase.SubjectName].ToString().Trim(); //课题名称
objvPubClassCaseEN.TeachingPlanAuthor = objRow[convPubClassCase.TeachingPlanAuthor] == DBNull.Value ? null : objRow[convPubClassCase.TeachingPlanAuthor].ToString().Trim(); //教案撰写人
objvPubClassCaseEN.TeachingObject = objRow[convPubClassCase.TeachingObject] == DBNull.Value ? null : objRow[convPubClassCase.TeachingObject].ToString().Trim(); //教学目标
objvPubClassCaseEN.TeachingEmphases = objRow[convPubClassCase.TeachingEmphases] == DBNull.Value ? null : objRow[convPubClassCase.TeachingEmphases].ToString().Trim(); //教学重点
objvPubClassCaseEN.TeachingDifficulty = objRow[convPubClassCase.TeachingDifficulty] == DBNull.Value ? null : objRow[convPubClassCase.TeachingDifficulty].ToString().Trim(); //教学难点
objvPubClassCaseEN.TeachingTool = objRow[convPubClassCase.TeachingTool] == DBNull.Value ? null : objRow[convPubClassCase.TeachingTool].ToString().Trim(); //教学用具
objvPubClassCaseEN.TeachingProcess = objRow[convPubClassCase.TeachingProcess] == DBNull.Value ? null : objRow[convPubClassCase.TeachingProcess].ToString().Trim(); //教学过程
objvPubClassCaseEN.TeachingPlanType = objRow[convPubClassCase.TeachingPlanType] == DBNull.Value ? null : objRow[convPubClassCase.TeachingPlanType].ToString().Trim(); //教案类型
objvPubClassCaseEN.SimplePlanContent = objRow[convPubClassCase.SimplePlanContent] == DBNull.Value ? null : objRow[convPubClassCase.SimplePlanContent].ToString().Trim(); //简案内容
objvPubClassCaseEN.PubClassCaseTimeIn = objRow[convPubClassCase.PubClassCaseTimeIn] == DBNull.Value ? null : objRow[convPubClassCase.PubClassCaseTimeIn].ToString().Trim(); //案例入库时间
objvPubClassCaseEN.IdPubClassCaseSenateGaugeVersion = objRow[convPubClassCase.IdPubClassCaseSenateGaugeVersion].ToString().Trim(); //公开课量表版本流水号
objvPubClassCaseEN.senateGaugeVersionID = objRow[convPubClassCase.senateGaugeVersionID] == DBNull.Value ? null : objRow[convPubClassCase.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvPubClassCaseEN.senateGaugeVersionName = objRow[convPubClassCase.senateGaugeVersionName] == DBNull.Value ? null : objRow[convPubClassCase.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvPubClassCaseEN.senateGaugeVersionTtlScore = objRow[convPubClassCase.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convPubClassCase.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvPubClassCaseEN.IdPubCaseType = objRow[convPubClassCase.IdPubCaseType] == DBNull.Value ? null : objRow[convPubClassCase.IdPubCaseType].ToString().Trim(); //公开课案例类型流水号
objvPubClassCaseEN.PubCaseTypeID = objRow[convPubClassCase.PubCaseTypeID] == DBNull.Value ? null : objRow[convPubClassCase.PubCaseTypeID].ToString().Trim(); //公开课案例类型ID
objvPubClassCaseEN.PubCaseTypeName = objRow[convPubClassCase.PubCaseTypeName] == DBNull.Value ? null : objRow[convPubClassCase.PubCaseTypeName].ToString().Trim(); //公开课案例类型名称
objvPubClassCaseEN.IdStudyLevel = objRow[convPubClassCase.IdStudyLevel] == DBNull.Value ? null : objRow[convPubClassCase.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvPubClassCaseEN.StudyLevelName = objRow[convPubClassCase.StudyLevelName] == DBNull.Value ? null : objRow[convPubClassCase.StudyLevelName].ToString().Trim(); //学段名称
objvPubClassCaseEN.CDID = objRow[convPubClassCase.CDID] == DBNull.Value ? null : objRow[convPubClassCase.CDID].ToString().Trim(); //光盘编号
objvPubClassCaseEN.Introduction = objRow[convPubClassCase.Introduction] == DBNull.Value ? null : objRow[convPubClassCase.Introduction].ToString().Trim(); //简要介绍
objvPubClassCaseEN.IsVisible = TransNullToBool(objRow[convPubClassCase.IsVisible].ToString().Trim()); //是否显示
objvPubClassCaseEN.IsDualVideo = TransNullToBool(objRow[convPubClassCase.IsDualVideo].ToString().Trim()); //是否双视频
objvPubClassCaseEN.RecommendedDegreeId = objRow[convPubClassCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvPubClassCaseEN.RecommendedDegreeName = objRow[convPubClassCase.RecommendedDegreeName] == DBNull.Value ? null : objRow[convPubClassCase.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvPubClassCaseEN.ftpFileType = objRow[convPubClassCase.ftpFileType] == DBNull.Value ? null : objRow[convPubClassCase.ftpFileType].ToString().Trim(); //ftp文件类型
objvPubClassCaseEN.VideoUrl = objRow[convPubClassCase.VideoUrl] == DBNull.Value ? null : objRow[convPubClassCase.VideoUrl].ToString().Trim(); //视频Url
objvPubClassCaseEN.VideoPath = objRow[convPubClassCase.VideoPath] == DBNull.Value ? null : objRow[convPubClassCase.VideoPath].ToString().Trim(); //视频目录
objvPubClassCaseEN.ResErrMsg = objRow[convPubClassCase.ResErrMsg] == DBNull.Value ? null : objRow[convPubClassCase.ResErrMsg].ToString().Trim(); //资源错误信息
objvPubClassCaseEN.Memo = objRow[convPubClassCase.Memo] == DBNull.Value ? null : objRow[convPubClassCase.Memo].ToString().Trim(); //备注
objvPubClassCaseEN.BrowseCount4Case = objRow[convPubClassCase.BrowseCount4Case] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPubClassCase.BrowseCount4Case].ToString().Trim()); //课例浏览次数
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvPubClassCaseDA: GetObjLst)", objException.Message));
}
objvPubClassCaseEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvPubClassCaseEN);
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
public List<clsvPubClassCaseEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvPubClassCaseDA:GetObjLstByTabName)", objException.Message));
}
List<clsvPubClassCaseEN> arrObjLst = new List<clsvPubClassCaseEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPubClassCaseDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPubClassCaseEN objvPubClassCaseEN = new clsvPubClassCaseEN();
try
{
objvPubClassCaseEN.IdPubClassCase = objRow[convPubClassCase.IdPubClassCase].ToString().Trim(); //案例流水号
objvPubClassCaseEN.PubClassCaseID = objRow[convPubClassCase.PubClassCaseID].ToString().Trim(); //案例ID
objvPubClassCaseEN.PubClassCaseName = objRow[convPubClassCase.PubClassCaseName].ToString().Trim(); //案例课题名称
objvPubClassCaseEN.PubClassCaseExecutor = objRow[convPubClassCase.PubClassCaseExecutor] == DBNull.Value ? null : objRow[convPubClassCase.PubClassCaseExecutor].ToString().Trim(); //案例执教者
objvPubClassCaseEN.WorkUnit = objRow[convPubClassCase.WorkUnit] == DBNull.Value ? null : objRow[convPubClassCase.WorkUnit].ToString().Trim(); //工作单位
objvPubClassCaseEN.PubClassCaseTheme = objRow[convPubClassCase.PubClassCaseTheme] == DBNull.Value ? null : objRow[convPubClassCase.PubClassCaseTheme].ToString().Trim(); //案例主题词
objvPubClassCaseEN.PubClassCaseBG = objRow[convPubClassCase.PubClassCaseBG] == DBNull.Value ? null : objRow[convPubClassCase.PubClassCaseBG].ToString().Trim(); //案例背景资料
objvPubClassCaseEN.PubClassCaseTeachDate = objRow[convPubClassCase.PubClassCaseTeachDate] == DBNull.Value ? null : objRow[convPubClassCase.PubClassCaseTeachDate].ToString().Trim(); //案例授课日期
objvPubClassCaseEN.PubClassCaseDateIn = objRow[convPubClassCase.PubClassCaseDateIn] == DBNull.Value ? null : objRow[convPubClassCase.PubClassCaseDateIn].ToString().Trim(); //案例入库日期
objvPubClassCaseEN.IdDiscipline = objRow[convPubClassCase.IdDiscipline].ToString().Trim(); //学科流水号
objvPubClassCaseEN.DisciplineID = objRow[convPubClassCase.DisciplineID] == DBNull.Value ? null : objRow[convPubClassCase.DisciplineID].ToString().Trim(); //学科ID
objvPubClassCaseEN.DisciplineName = objRow[convPubClassCase.DisciplineName] == DBNull.Value ? null : objRow[convPubClassCase.DisciplineName].ToString().Trim(); //学科名称
objvPubClassCaseEN.IdTeachingPlan = objRow[convPubClassCase.IdTeachingPlan] == DBNull.Value ? null : objRow[convPubClassCase.IdTeachingPlan].ToString().Trim(); //教案流水号
objvPubClassCaseEN.SubjectName = objRow[convPubClassCase.SubjectName] == DBNull.Value ? null : objRow[convPubClassCase.SubjectName].ToString().Trim(); //课题名称
objvPubClassCaseEN.TeachingPlanAuthor = objRow[convPubClassCase.TeachingPlanAuthor] == DBNull.Value ? null : objRow[convPubClassCase.TeachingPlanAuthor].ToString().Trim(); //教案撰写人
objvPubClassCaseEN.TeachingObject = objRow[convPubClassCase.TeachingObject] == DBNull.Value ? null : objRow[convPubClassCase.TeachingObject].ToString().Trim(); //教学目标
objvPubClassCaseEN.TeachingEmphases = objRow[convPubClassCase.TeachingEmphases] == DBNull.Value ? null : objRow[convPubClassCase.TeachingEmphases].ToString().Trim(); //教学重点
objvPubClassCaseEN.TeachingDifficulty = objRow[convPubClassCase.TeachingDifficulty] == DBNull.Value ? null : objRow[convPubClassCase.TeachingDifficulty].ToString().Trim(); //教学难点
objvPubClassCaseEN.TeachingTool = objRow[convPubClassCase.TeachingTool] == DBNull.Value ? null : objRow[convPubClassCase.TeachingTool].ToString().Trim(); //教学用具
objvPubClassCaseEN.TeachingProcess = objRow[convPubClassCase.TeachingProcess] == DBNull.Value ? null : objRow[convPubClassCase.TeachingProcess].ToString().Trim(); //教学过程
objvPubClassCaseEN.TeachingPlanType = objRow[convPubClassCase.TeachingPlanType] == DBNull.Value ? null : objRow[convPubClassCase.TeachingPlanType].ToString().Trim(); //教案类型
objvPubClassCaseEN.SimplePlanContent = objRow[convPubClassCase.SimplePlanContent] == DBNull.Value ? null : objRow[convPubClassCase.SimplePlanContent].ToString().Trim(); //简案内容
objvPubClassCaseEN.PubClassCaseTimeIn = objRow[convPubClassCase.PubClassCaseTimeIn] == DBNull.Value ? null : objRow[convPubClassCase.PubClassCaseTimeIn].ToString().Trim(); //案例入库时间
objvPubClassCaseEN.IdPubClassCaseSenateGaugeVersion = objRow[convPubClassCase.IdPubClassCaseSenateGaugeVersion].ToString().Trim(); //公开课量表版本流水号
objvPubClassCaseEN.senateGaugeVersionID = objRow[convPubClassCase.senateGaugeVersionID] == DBNull.Value ? null : objRow[convPubClassCase.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvPubClassCaseEN.senateGaugeVersionName = objRow[convPubClassCase.senateGaugeVersionName] == DBNull.Value ? null : objRow[convPubClassCase.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvPubClassCaseEN.senateGaugeVersionTtlScore = objRow[convPubClassCase.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convPubClassCase.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvPubClassCaseEN.IdPubCaseType = objRow[convPubClassCase.IdPubCaseType] == DBNull.Value ? null : objRow[convPubClassCase.IdPubCaseType].ToString().Trim(); //公开课案例类型流水号
objvPubClassCaseEN.PubCaseTypeID = objRow[convPubClassCase.PubCaseTypeID] == DBNull.Value ? null : objRow[convPubClassCase.PubCaseTypeID].ToString().Trim(); //公开课案例类型ID
objvPubClassCaseEN.PubCaseTypeName = objRow[convPubClassCase.PubCaseTypeName] == DBNull.Value ? null : objRow[convPubClassCase.PubCaseTypeName].ToString().Trim(); //公开课案例类型名称
objvPubClassCaseEN.IdStudyLevel = objRow[convPubClassCase.IdStudyLevel] == DBNull.Value ? null : objRow[convPubClassCase.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvPubClassCaseEN.StudyLevelName = objRow[convPubClassCase.StudyLevelName] == DBNull.Value ? null : objRow[convPubClassCase.StudyLevelName].ToString().Trim(); //学段名称
objvPubClassCaseEN.CDID = objRow[convPubClassCase.CDID] == DBNull.Value ? null : objRow[convPubClassCase.CDID].ToString().Trim(); //光盘编号
objvPubClassCaseEN.Introduction = objRow[convPubClassCase.Introduction] == DBNull.Value ? null : objRow[convPubClassCase.Introduction].ToString().Trim(); //简要介绍
objvPubClassCaseEN.IsVisible = TransNullToBool(objRow[convPubClassCase.IsVisible].ToString().Trim()); //是否显示
objvPubClassCaseEN.IsDualVideo = TransNullToBool(objRow[convPubClassCase.IsDualVideo].ToString().Trim()); //是否双视频
objvPubClassCaseEN.RecommendedDegreeId = objRow[convPubClassCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvPubClassCaseEN.RecommendedDegreeName = objRow[convPubClassCase.RecommendedDegreeName] == DBNull.Value ? null : objRow[convPubClassCase.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvPubClassCaseEN.ftpFileType = objRow[convPubClassCase.ftpFileType] == DBNull.Value ? null : objRow[convPubClassCase.ftpFileType].ToString().Trim(); //ftp文件类型
objvPubClassCaseEN.VideoUrl = objRow[convPubClassCase.VideoUrl] == DBNull.Value ? null : objRow[convPubClassCase.VideoUrl].ToString().Trim(); //视频Url
objvPubClassCaseEN.VideoPath = objRow[convPubClassCase.VideoPath] == DBNull.Value ? null : objRow[convPubClassCase.VideoPath].ToString().Trim(); //视频目录
objvPubClassCaseEN.ResErrMsg = objRow[convPubClassCase.ResErrMsg] == DBNull.Value ? null : objRow[convPubClassCase.ResErrMsg].ToString().Trim(); //资源错误信息
objvPubClassCaseEN.Memo = objRow[convPubClassCase.Memo] == DBNull.Value ? null : objRow[convPubClassCase.Memo].ToString().Trim(); //备注
objvPubClassCaseEN.BrowseCount4Case = objRow[convPubClassCase.BrowseCount4Case] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPubClassCase.BrowseCount4Case].ToString().Trim()); //课例浏览次数
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvPubClassCaseDA: GetObjLst)", objException.Message));
}
objvPubClassCaseEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvPubClassCaseEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvPubClassCaseEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvPubClassCase(ref clsvPubClassCaseEN objvPubClassCaseEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPubClassCaseDA.GetSpecSQLObj();
strSQL = "Select * from vPubClassCase where IdPubClassCase = " + "'"+ objvPubClassCaseEN.IdPubClassCase+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvPubClassCaseEN.IdPubClassCase = objDT.Rows[0][convPubClassCase.IdPubClassCase].ToString().Trim(); //案例流水号(字段类型:char,字段长度:8,是否可空:False)
 objvPubClassCaseEN.PubClassCaseID = objDT.Rows[0][convPubClassCase.PubClassCaseID].ToString().Trim(); //案例ID(字段类型:char,字段长度:8,是否可空:False)
 objvPubClassCaseEN.PubClassCaseName = objDT.Rows[0][convPubClassCase.PubClassCaseName].ToString().Trim(); //案例课题名称(字段类型:varchar,字段长度:200,是否可空:False)
 objvPubClassCaseEN.PubClassCaseExecutor = objDT.Rows[0][convPubClassCase.PubClassCaseExecutor].ToString().Trim(); //案例执教者(字段类型:varchar,字段长度:50,是否可空:True)
 objvPubClassCaseEN.WorkUnit = objDT.Rows[0][convPubClassCase.WorkUnit].ToString().Trim(); //工作单位(字段类型:varchar,字段长度:100,是否可空:True)
 objvPubClassCaseEN.PubClassCaseTheme = objDT.Rows[0][convPubClassCase.PubClassCaseTheme].ToString().Trim(); //案例主题词(字段类型:varchar,字段长度:500,是否可空:True)
 objvPubClassCaseEN.PubClassCaseBG = objDT.Rows[0][convPubClassCase.PubClassCaseBG].ToString().Trim(); //案例背景资料(字段类型:text,字段长度:16,是否可空:True)
 objvPubClassCaseEN.PubClassCaseTeachDate = objDT.Rows[0][convPubClassCase.PubClassCaseTeachDate].ToString().Trim(); //案例授课日期(字段类型:char,字段长度:8,是否可空:True)
 objvPubClassCaseEN.PubClassCaseDateIn = objDT.Rows[0][convPubClassCase.PubClassCaseDateIn].ToString().Trim(); //案例入库日期(字段类型:char,字段长度:8,是否可空:True)
 objvPubClassCaseEN.IdDiscipline = objDT.Rows[0][convPubClassCase.IdDiscipline].ToString().Trim(); //学科流水号(字段类型:char,字段长度:4,是否可空:False)
 objvPubClassCaseEN.DisciplineID = objDT.Rows[0][convPubClassCase.DisciplineID].ToString().Trim(); //学科ID(字段类型:char,字段长度:4,是否可空:False)
 objvPubClassCaseEN.DisciplineName = objDT.Rows[0][convPubClassCase.DisciplineName].ToString().Trim(); //学科名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvPubClassCaseEN.IdTeachingPlan = objDT.Rows[0][convPubClassCase.IdTeachingPlan].ToString().Trim(); //教案流水号(字段类型:char,字段长度:8,是否可空:False)
 objvPubClassCaseEN.SubjectName = objDT.Rows[0][convPubClassCase.SubjectName].ToString().Trim(); //课题名称(字段类型:varchar,字段长度:200,是否可空:False)
 objvPubClassCaseEN.TeachingPlanAuthor = objDT.Rows[0][convPubClassCase.TeachingPlanAuthor].ToString().Trim(); //教案撰写人(字段类型:varchar,字段长度:50,是否可空:True)
 objvPubClassCaseEN.TeachingObject = objDT.Rows[0][convPubClassCase.TeachingObject].ToString().Trim(); //教学目标(字段类型:varchar,字段长度:5000,是否可空:True)
 objvPubClassCaseEN.TeachingEmphases = objDT.Rows[0][convPubClassCase.TeachingEmphases].ToString().Trim(); //教学重点(字段类型:varchar,字段长度:5000,是否可空:True)
 objvPubClassCaseEN.TeachingDifficulty = objDT.Rows[0][convPubClassCase.TeachingDifficulty].ToString().Trim(); //教学难点(字段类型:varchar,字段长度:5000,是否可空:True)
 objvPubClassCaseEN.TeachingTool = objDT.Rows[0][convPubClassCase.TeachingTool].ToString().Trim(); //教学用具(字段类型:varchar,字段长度:5000,是否可空:True)
 objvPubClassCaseEN.TeachingProcess = objDT.Rows[0][convPubClassCase.TeachingProcess].ToString().Trim(); //教学过程(字段类型:varchar,字段长度:8000,是否可空:True)
 objvPubClassCaseEN.TeachingPlanType = objDT.Rows[0][convPubClassCase.TeachingPlanType].ToString().Trim(); //教案类型(字段类型:char,字段长度:1,是否可空:True)
 objvPubClassCaseEN.SimplePlanContent = objDT.Rows[0][convPubClassCase.SimplePlanContent].ToString().Trim(); //简案内容(字段类型:text,字段长度:2147483647,是否可空:True)
 objvPubClassCaseEN.PubClassCaseTimeIn = objDT.Rows[0][convPubClassCase.PubClassCaseTimeIn].ToString().Trim(); //案例入库时间(字段类型:char,字段长度:6,是否可空:True)
 objvPubClassCaseEN.IdPubClassCaseSenateGaugeVersion = objDT.Rows[0][convPubClassCase.IdPubClassCaseSenateGaugeVersion].ToString().Trim(); //公开课量表版本流水号(字段类型:char,字段长度:4,是否可空:False)
 objvPubClassCaseEN.senateGaugeVersionID = objDT.Rows[0][convPubClassCase.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID(字段类型:char,字段长度:4,是否可空:False)
 objvPubClassCaseEN.senateGaugeVersionName = objDT.Rows[0][convPubClassCase.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称(字段类型:varchar,字段长度:200,是否可空:True)
 objvPubClassCaseEN.senateGaugeVersionTtlScore = TransNullToFloat(objDT.Rows[0][convPubClassCase.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分(字段类型:float,字段长度:8,是否可空:False)
 objvPubClassCaseEN.IdPubCaseType = objDT.Rows[0][convPubClassCase.IdPubCaseType].ToString().Trim(); //公开课案例类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvPubClassCaseEN.PubCaseTypeID = objDT.Rows[0][convPubClassCase.PubCaseTypeID].ToString().Trim(); //公开课案例类型ID(字段类型:char,字段长度:4,是否可空:False)
 objvPubClassCaseEN.PubCaseTypeName = objDT.Rows[0][convPubClassCase.PubCaseTypeName].ToString().Trim(); //公开课案例类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvPubClassCaseEN.IdStudyLevel = objDT.Rows[0][convPubClassCase.IdStudyLevel].ToString().Trim(); //id_StudyLevel(字段类型:char,字段长度:4,是否可空:True)
 objvPubClassCaseEN.StudyLevelName = objDT.Rows[0][convPubClassCase.StudyLevelName].ToString().Trim(); //学段名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvPubClassCaseEN.CDID = objDT.Rows[0][convPubClassCase.CDID].ToString().Trim(); //光盘编号(字段类型:varchar,字段长度:50,是否可空:True)
 objvPubClassCaseEN.Introduction = objDT.Rows[0][convPubClassCase.Introduction].ToString().Trim(); //简要介绍(字段类型:varchar,字段长度:4000,是否可空:True)
 objvPubClassCaseEN.IsVisible = TransNullToBool(objDT.Rows[0][convPubClassCase.IsVisible].ToString().Trim()); //是否显示(字段类型:bit,字段长度:1,是否可空:True)
 objvPubClassCaseEN.IsDualVideo = TransNullToBool(objDT.Rows[0][convPubClassCase.IsDualVideo].ToString().Trim()); //是否双视频(字段类型:bit,字段长度:1,是否可空:False)
 objvPubClassCaseEN.RecommendedDegreeId = objDT.Rows[0][convPubClassCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id(字段类型:char,字段长度:2,是否可空:False)
 objvPubClassCaseEN.RecommendedDegreeName = objDT.Rows[0][convPubClassCase.RecommendedDegreeName].ToString().Trim(); //推荐度名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvPubClassCaseEN.ftpFileType = objDT.Rows[0][convPubClassCase.ftpFileType].ToString().Trim(); //ftp文件类型(字段类型:varchar,字段长度:30,是否可空:True)
 objvPubClassCaseEN.VideoUrl = objDT.Rows[0][convPubClassCase.VideoUrl].ToString().Trim(); //视频Url(字段类型:varchar,字段长度:1000,是否可空:True)
 objvPubClassCaseEN.VideoPath = objDT.Rows[0][convPubClassCase.VideoPath].ToString().Trim(); //视频目录(字段类型:varchar,字段长度:1000,是否可空:True)
 objvPubClassCaseEN.ResErrMsg = objDT.Rows[0][convPubClassCase.ResErrMsg].ToString().Trim(); //资源错误信息(字段类型:varchar,字段长度:30,是否可空:True)
 objvPubClassCaseEN.Memo = objDT.Rows[0][convPubClassCase.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvPubClassCaseEN.BrowseCount4Case = TransNullToInt(objDT.Rows[0][convPubClassCase.BrowseCount4Case].ToString().Trim()); //课例浏览次数(字段类型:int,字段长度:4,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvPubClassCaseDA: GetvPubClassCase)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strIdPubClassCase">表关键字</param>
 /// <returns>表对象</returns>
public clsvPubClassCaseEN GetObjByIdPubClassCase(string strIdPubClassCase)
{
CheckPrimaryKey(strIdPubClassCase);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPubClassCaseDA.GetSpecSQLObj();
strSQL = "Select * from vPubClassCase where IdPubClassCase = " + "'"+ strIdPubClassCase+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvPubClassCaseEN objvPubClassCaseEN = new clsvPubClassCaseEN();
try
{
 objvPubClassCaseEN.IdPubClassCase = objRow[convPubClassCase.IdPubClassCase].ToString().Trim(); //案例流水号(字段类型:char,字段长度:8,是否可空:False)
 objvPubClassCaseEN.PubClassCaseID = objRow[convPubClassCase.PubClassCaseID].ToString().Trim(); //案例ID(字段类型:char,字段长度:8,是否可空:False)
 objvPubClassCaseEN.PubClassCaseName = objRow[convPubClassCase.PubClassCaseName].ToString().Trim(); //案例课题名称(字段类型:varchar,字段长度:200,是否可空:False)
 objvPubClassCaseEN.PubClassCaseExecutor = objRow[convPubClassCase.PubClassCaseExecutor] == DBNull.Value ? null : objRow[convPubClassCase.PubClassCaseExecutor].ToString().Trim(); //案例执教者(字段类型:varchar,字段长度:50,是否可空:True)
 objvPubClassCaseEN.WorkUnit = objRow[convPubClassCase.WorkUnit] == DBNull.Value ? null : objRow[convPubClassCase.WorkUnit].ToString().Trim(); //工作单位(字段类型:varchar,字段长度:100,是否可空:True)
 objvPubClassCaseEN.PubClassCaseTheme = objRow[convPubClassCase.PubClassCaseTheme] == DBNull.Value ? null : objRow[convPubClassCase.PubClassCaseTheme].ToString().Trim(); //案例主题词(字段类型:varchar,字段长度:500,是否可空:True)
 objvPubClassCaseEN.PubClassCaseBG = objRow[convPubClassCase.PubClassCaseBG] == DBNull.Value ? null : objRow[convPubClassCase.PubClassCaseBG].ToString().Trim(); //案例背景资料(字段类型:text,字段长度:16,是否可空:True)
 objvPubClassCaseEN.PubClassCaseTeachDate = objRow[convPubClassCase.PubClassCaseTeachDate] == DBNull.Value ? null : objRow[convPubClassCase.PubClassCaseTeachDate].ToString().Trim(); //案例授课日期(字段类型:char,字段长度:8,是否可空:True)
 objvPubClassCaseEN.PubClassCaseDateIn = objRow[convPubClassCase.PubClassCaseDateIn] == DBNull.Value ? null : objRow[convPubClassCase.PubClassCaseDateIn].ToString().Trim(); //案例入库日期(字段类型:char,字段长度:8,是否可空:True)
 objvPubClassCaseEN.IdDiscipline = objRow[convPubClassCase.IdDiscipline].ToString().Trim(); //学科流水号(字段类型:char,字段长度:4,是否可空:False)
 objvPubClassCaseEN.DisciplineID = objRow[convPubClassCase.DisciplineID] == DBNull.Value ? null : objRow[convPubClassCase.DisciplineID].ToString().Trim(); //学科ID(字段类型:char,字段长度:4,是否可空:False)
 objvPubClassCaseEN.DisciplineName = objRow[convPubClassCase.DisciplineName] == DBNull.Value ? null : objRow[convPubClassCase.DisciplineName].ToString().Trim(); //学科名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvPubClassCaseEN.IdTeachingPlan = objRow[convPubClassCase.IdTeachingPlan] == DBNull.Value ? null : objRow[convPubClassCase.IdTeachingPlan].ToString().Trim(); //教案流水号(字段类型:char,字段长度:8,是否可空:False)
 objvPubClassCaseEN.SubjectName = objRow[convPubClassCase.SubjectName] == DBNull.Value ? null : objRow[convPubClassCase.SubjectName].ToString().Trim(); //课题名称(字段类型:varchar,字段长度:200,是否可空:False)
 objvPubClassCaseEN.TeachingPlanAuthor = objRow[convPubClassCase.TeachingPlanAuthor] == DBNull.Value ? null : objRow[convPubClassCase.TeachingPlanAuthor].ToString().Trim(); //教案撰写人(字段类型:varchar,字段长度:50,是否可空:True)
 objvPubClassCaseEN.TeachingObject = objRow[convPubClassCase.TeachingObject] == DBNull.Value ? null : objRow[convPubClassCase.TeachingObject].ToString().Trim(); //教学目标(字段类型:varchar,字段长度:5000,是否可空:True)
 objvPubClassCaseEN.TeachingEmphases = objRow[convPubClassCase.TeachingEmphases] == DBNull.Value ? null : objRow[convPubClassCase.TeachingEmphases].ToString().Trim(); //教学重点(字段类型:varchar,字段长度:5000,是否可空:True)
 objvPubClassCaseEN.TeachingDifficulty = objRow[convPubClassCase.TeachingDifficulty] == DBNull.Value ? null : objRow[convPubClassCase.TeachingDifficulty].ToString().Trim(); //教学难点(字段类型:varchar,字段长度:5000,是否可空:True)
 objvPubClassCaseEN.TeachingTool = objRow[convPubClassCase.TeachingTool] == DBNull.Value ? null : objRow[convPubClassCase.TeachingTool].ToString().Trim(); //教学用具(字段类型:varchar,字段长度:5000,是否可空:True)
 objvPubClassCaseEN.TeachingProcess = objRow[convPubClassCase.TeachingProcess] == DBNull.Value ? null : objRow[convPubClassCase.TeachingProcess].ToString().Trim(); //教学过程(字段类型:varchar,字段长度:8000,是否可空:True)
 objvPubClassCaseEN.TeachingPlanType = objRow[convPubClassCase.TeachingPlanType] == DBNull.Value ? null : objRow[convPubClassCase.TeachingPlanType].ToString().Trim(); //教案类型(字段类型:char,字段长度:1,是否可空:True)
 objvPubClassCaseEN.SimplePlanContent = objRow[convPubClassCase.SimplePlanContent] == DBNull.Value ? null : objRow[convPubClassCase.SimplePlanContent].ToString().Trim(); //简案内容(字段类型:text,字段长度:2147483647,是否可空:True)
 objvPubClassCaseEN.PubClassCaseTimeIn = objRow[convPubClassCase.PubClassCaseTimeIn] == DBNull.Value ? null : objRow[convPubClassCase.PubClassCaseTimeIn].ToString().Trim(); //案例入库时间(字段类型:char,字段长度:6,是否可空:True)
 objvPubClassCaseEN.IdPubClassCaseSenateGaugeVersion = objRow[convPubClassCase.IdPubClassCaseSenateGaugeVersion].ToString().Trim(); //公开课量表版本流水号(字段类型:char,字段长度:4,是否可空:False)
 objvPubClassCaseEN.senateGaugeVersionID = objRow[convPubClassCase.senateGaugeVersionID] == DBNull.Value ? null : objRow[convPubClassCase.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID(字段类型:char,字段长度:4,是否可空:False)
 objvPubClassCaseEN.senateGaugeVersionName = objRow[convPubClassCase.senateGaugeVersionName] == DBNull.Value ? null : objRow[convPubClassCase.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称(字段类型:varchar,字段长度:200,是否可空:True)
 objvPubClassCaseEN.senateGaugeVersionTtlScore = objRow[convPubClassCase.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convPubClassCase.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分(字段类型:float,字段长度:8,是否可空:False)
 objvPubClassCaseEN.IdPubCaseType = objRow[convPubClassCase.IdPubCaseType] == DBNull.Value ? null : objRow[convPubClassCase.IdPubCaseType].ToString().Trim(); //公开课案例类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvPubClassCaseEN.PubCaseTypeID = objRow[convPubClassCase.PubCaseTypeID] == DBNull.Value ? null : objRow[convPubClassCase.PubCaseTypeID].ToString().Trim(); //公开课案例类型ID(字段类型:char,字段长度:4,是否可空:False)
 objvPubClassCaseEN.PubCaseTypeName = objRow[convPubClassCase.PubCaseTypeName] == DBNull.Value ? null : objRow[convPubClassCase.PubCaseTypeName].ToString().Trim(); //公开课案例类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvPubClassCaseEN.IdStudyLevel = objRow[convPubClassCase.IdStudyLevel] == DBNull.Value ? null : objRow[convPubClassCase.IdStudyLevel].ToString().Trim(); //id_StudyLevel(字段类型:char,字段长度:4,是否可空:True)
 objvPubClassCaseEN.StudyLevelName = objRow[convPubClassCase.StudyLevelName] == DBNull.Value ? null : objRow[convPubClassCase.StudyLevelName].ToString().Trim(); //学段名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvPubClassCaseEN.CDID = objRow[convPubClassCase.CDID] == DBNull.Value ? null : objRow[convPubClassCase.CDID].ToString().Trim(); //光盘编号(字段类型:varchar,字段长度:50,是否可空:True)
 objvPubClassCaseEN.Introduction = objRow[convPubClassCase.Introduction] == DBNull.Value ? null : objRow[convPubClassCase.Introduction].ToString().Trim(); //简要介绍(字段类型:varchar,字段长度:4000,是否可空:True)
 objvPubClassCaseEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convPubClassCase.IsVisible].ToString().Trim()); //是否显示(字段类型:bit,字段长度:1,是否可空:True)
 objvPubClassCaseEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convPubClassCase.IsDualVideo].ToString().Trim()); //是否双视频(字段类型:bit,字段长度:1,是否可空:False)
 objvPubClassCaseEN.RecommendedDegreeId = objRow[convPubClassCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id(字段类型:char,字段长度:2,是否可空:False)
 objvPubClassCaseEN.RecommendedDegreeName = objRow[convPubClassCase.RecommendedDegreeName] == DBNull.Value ? null : objRow[convPubClassCase.RecommendedDegreeName].ToString().Trim(); //推荐度名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvPubClassCaseEN.ftpFileType = objRow[convPubClassCase.ftpFileType] == DBNull.Value ? null : objRow[convPubClassCase.ftpFileType].ToString().Trim(); //ftp文件类型(字段类型:varchar,字段长度:30,是否可空:True)
 objvPubClassCaseEN.VideoUrl = objRow[convPubClassCase.VideoUrl] == DBNull.Value ? null : objRow[convPubClassCase.VideoUrl].ToString().Trim(); //视频Url(字段类型:varchar,字段长度:1000,是否可空:True)
 objvPubClassCaseEN.VideoPath = objRow[convPubClassCase.VideoPath] == DBNull.Value ? null : objRow[convPubClassCase.VideoPath].ToString().Trim(); //视频目录(字段类型:varchar,字段长度:1000,是否可空:True)
 objvPubClassCaseEN.ResErrMsg = objRow[convPubClassCase.ResErrMsg] == DBNull.Value ? null : objRow[convPubClassCase.ResErrMsg].ToString().Trim(); //资源错误信息(字段类型:varchar,字段长度:30,是否可空:True)
 objvPubClassCaseEN.Memo = objRow[convPubClassCase.Memo] == DBNull.Value ? null : objRow[convPubClassCase.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvPubClassCaseEN.BrowseCount4Case = objRow[convPubClassCase.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPubClassCase.BrowseCount4Case].ToString().Trim()); //课例浏览次数(字段类型:int,字段长度:4,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvPubClassCaseDA: GetObjByIdPubClassCase)", objException.Message));
}
return objvPubClassCaseEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvPubClassCaseEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvPubClassCaseDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPubClassCaseDA.GetSpecSQLObj();
strSQL = "Select * from vPubClassCase where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvPubClassCaseEN objvPubClassCaseEN = new clsvPubClassCaseEN()
{
IdPubClassCase = objRow[convPubClassCase.IdPubClassCase].ToString().Trim(), //案例流水号
PubClassCaseID = objRow[convPubClassCase.PubClassCaseID].ToString().Trim(), //案例ID
PubClassCaseName = objRow[convPubClassCase.PubClassCaseName].ToString().Trim(), //案例课题名称
PubClassCaseExecutor = objRow[convPubClassCase.PubClassCaseExecutor] == DBNull.Value ? null : objRow[convPubClassCase.PubClassCaseExecutor].ToString().Trim(), //案例执教者
WorkUnit = objRow[convPubClassCase.WorkUnit] == DBNull.Value ? null : objRow[convPubClassCase.WorkUnit].ToString().Trim(), //工作单位
PubClassCaseTheme = objRow[convPubClassCase.PubClassCaseTheme] == DBNull.Value ? null : objRow[convPubClassCase.PubClassCaseTheme].ToString().Trim(), //案例主题词
PubClassCaseBG = objRow[convPubClassCase.PubClassCaseBG] == DBNull.Value ? null : objRow[convPubClassCase.PubClassCaseBG].ToString().Trim(), //案例背景资料
PubClassCaseTeachDate = objRow[convPubClassCase.PubClassCaseTeachDate] == DBNull.Value ? null : objRow[convPubClassCase.PubClassCaseTeachDate].ToString().Trim(), //案例授课日期
PubClassCaseDateIn = objRow[convPubClassCase.PubClassCaseDateIn] == DBNull.Value ? null : objRow[convPubClassCase.PubClassCaseDateIn].ToString().Trim(), //案例入库日期
IdDiscipline = objRow[convPubClassCase.IdDiscipline].ToString().Trim(), //学科流水号
DisciplineID = objRow[convPubClassCase.DisciplineID] == DBNull.Value ? null : objRow[convPubClassCase.DisciplineID].ToString().Trim(), //学科ID
DisciplineName = objRow[convPubClassCase.DisciplineName] == DBNull.Value ? null : objRow[convPubClassCase.DisciplineName].ToString().Trim(), //学科名称
IdTeachingPlan = objRow[convPubClassCase.IdTeachingPlan] == DBNull.Value ? null : objRow[convPubClassCase.IdTeachingPlan].ToString().Trim(), //教案流水号
SubjectName = objRow[convPubClassCase.SubjectName] == DBNull.Value ? null : objRow[convPubClassCase.SubjectName].ToString().Trim(), //课题名称
TeachingPlanAuthor = objRow[convPubClassCase.TeachingPlanAuthor] == DBNull.Value ? null : objRow[convPubClassCase.TeachingPlanAuthor].ToString().Trim(), //教案撰写人
TeachingObject = objRow[convPubClassCase.TeachingObject] == DBNull.Value ? null : objRow[convPubClassCase.TeachingObject].ToString().Trim(), //教学目标
TeachingEmphases = objRow[convPubClassCase.TeachingEmphases] == DBNull.Value ? null : objRow[convPubClassCase.TeachingEmphases].ToString().Trim(), //教学重点
TeachingDifficulty = objRow[convPubClassCase.TeachingDifficulty] == DBNull.Value ? null : objRow[convPubClassCase.TeachingDifficulty].ToString().Trim(), //教学难点
TeachingTool = objRow[convPubClassCase.TeachingTool] == DBNull.Value ? null : objRow[convPubClassCase.TeachingTool].ToString().Trim(), //教学用具
TeachingProcess = objRow[convPubClassCase.TeachingProcess] == DBNull.Value ? null : objRow[convPubClassCase.TeachingProcess].ToString().Trim(), //教学过程
TeachingPlanType = objRow[convPubClassCase.TeachingPlanType] == DBNull.Value ? null : objRow[convPubClassCase.TeachingPlanType].ToString().Trim(), //教案类型
SimplePlanContent = objRow[convPubClassCase.SimplePlanContent] == DBNull.Value ? null : objRow[convPubClassCase.SimplePlanContent].ToString().Trim(), //简案内容
PubClassCaseTimeIn = objRow[convPubClassCase.PubClassCaseTimeIn] == DBNull.Value ? null : objRow[convPubClassCase.PubClassCaseTimeIn].ToString().Trim(), //案例入库时间
IdPubClassCaseSenateGaugeVersion = objRow[convPubClassCase.IdPubClassCaseSenateGaugeVersion].ToString().Trim(), //公开课量表版本流水号
senateGaugeVersionID = objRow[convPubClassCase.senateGaugeVersionID] == DBNull.Value ? null : objRow[convPubClassCase.senateGaugeVersionID].ToString().Trim(), //评价量表版本ID
senateGaugeVersionName = objRow[convPubClassCase.senateGaugeVersionName] == DBNull.Value ? null : objRow[convPubClassCase.senateGaugeVersionName].ToString().Trim(), //评价量表版本名称
senateGaugeVersionTtlScore = objRow[convPubClassCase.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convPubClassCase.senateGaugeVersionTtlScore].ToString().Trim()), //评价量表版本总分
IdPubCaseType = objRow[convPubClassCase.IdPubCaseType] == DBNull.Value ? null : objRow[convPubClassCase.IdPubCaseType].ToString().Trim(), //公开课案例类型流水号
PubCaseTypeID = objRow[convPubClassCase.PubCaseTypeID] == DBNull.Value ? null : objRow[convPubClassCase.PubCaseTypeID].ToString().Trim(), //公开课案例类型ID
PubCaseTypeName = objRow[convPubClassCase.PubCaseTypeName] == DBNull.Value ? null : objRow[convPubClassCase.PubCaseTypeName].ToString().Trim(), //公开课案例类型名称
IdStudyLevel = objRow[convPubClassCase.IdStudyLevel] == DBNull.Value ? null : objRow[convPubClassCase.IdStudyLevel].ToString().Trim(), //id_StudyLevel
StudyLevelName = objRow[convPubClassCase.StudyLevelName] == DBNull.Value ? null : objRow[convPubClassCase.StudyLevelName].ToString().Trim(), //学段名称
CDID = objRow[convPubClassCase.CDID] == DBNull.Value ? null : objRow[convPubClassCase.CDID].ToString().Trim(), //光盘编号
Introduction = objRow[convPubClassCase.Introduction] == DBNull.Value ? null : objRow[convPubClassCase.Introduction].ToString().Trim(), //简要介绍
IsVisible = TransNullToBool(objRow[convPubClassCase.IsVisible].ToString().Trim()), //是否显示
IsDualVideo = TransNullToBool(objRow[convPubClassCase.IsDualVideo].ToString().Trim()), //是否双视频
RecommendedDegreeId = objRow[convPubClassCase.RecommendedDegreeId].ToString().Trim(), //推荐度Id
RecommendedDegreeName = objRow[convPubClassCase.RecommendedDegreeName] == DBNull.Value ? null : objRow[convPubClassCase.RecommendedDegreeName].ToString().Trim(), //推荐度名称
ftpFileType = objRow[convPubClassCase.ftpFileType] == DBNull.Value ? null : objRow[convPubClassCase.ftpFileType].ToString().Trim(), //ftp文件类型
VideoUrl = objRow[convPubClassCase.VideoUrl] == DBNull.Value ? null : objRow[convPubClassCase.VideoUrl].ToString().Trim(), //视频Url
VideoPath = objRow[convPubClassCase.VideoPath] == DBNull.Value ? null : objRow[convPubClassCase.VideoPath].ToString().Trim(), //视频目录
ResErrMsg = objRow[convPubClassCase.ResErrMsg] == DBNull.Value ? null : objRow[convPubClassCase.ResErrMsg].ToString().Trim(), //资源错误信息
Memo = objRow[convPubClassCase.Memo] == DBNull.Value ? null : objRow[convPubClassCase.Memo].ToString().Trim(), //备注
BrowseCount4Case = objRow[convPubClassCase.BrowseCount4Case] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPubClassCase.BrowseCount4Case].ToString().Trim()) //课例浏览次数
};
objvPubClassCaseEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvPubClassCaseEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvPubClassCaseDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvPubClassCaseEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvPubClassCaseEN objvPubClassCaseEN = new clsvPubClassCaseEN();
try
{
objvPubClassCaseEN.IdPubClassCase = objRow[convPubClassCase.IdPubClassCase].ToString().Trim(); //案例流水号
objvPubClassCaseEN.PubClassCaseID = objRow[convPubClassCase.PubClassCaseID].ToString().Trim(); //案例ID
objvPubClassCaseEN.PubClassCaseName = objRow[convPubClassCase.PubClassCaseName].ToString().Trim(); //案例课题名称
objvPubClassCaseEN.PubClassCaseExecutor = objRow[convPubClassCase.PubClassCaseExecutor] == DBNull.Value ? null : objRow[convPubClassCase.PubClassCaseExecutor].ToString().Trim(); //案例执教者
objvPubClassCaseEN.WorkUnit = objRow[convPubClassCase.WorkUnit] == DBNull.Value ? null : objRow[convPubClassCase.WorkUnit].ToString().Trim(); //工作单位
objvPubClassCaseEN.PubClassCaseTheme = objRow[convPubClassCase.PubClassCaseTheme] == DBNull.Value ? null : objRow[convPubClassCase.PubClassCaseTheme].ToString().Trim(); //案例主题词
objvPubClassCaseEN.PubClassCaseBG = objRow[convPubClassCase.PubClassCaseBG] == DBNull.Value ? null : objRow[convPubClassCase.PubClassCaseBG].ToString().Trim(); //案例背景资料
objvPubClassCaseEN.PubClassCaseTeachDate = objRow[convPubClassCase.PubClassCaseTeachDate] == DBNull.Value ? null : objRow[convPubClassCase.PubClassCaseTeachDate].ToString().Trim(); //案例授课日期
objvPubClassCaseEN.PubClassCaseDateIn = objRow[convPubClassCase.PubClassCaseDateIn] == DBNull.Value ? null : objRow[convPubClassCase.PubClassCaseDateIn].ToString().Trim(); //案例入库日期
objvPubClassCaseEN.IdDiscipline = objRow[convPubClassCase.IdDiscipline].ToString().Trim(); //学科流水号
objvPubClassCaseEN.DisciplineID = objRow[convPubClassCase.DisciplineID] == DBNull.Value ? null : objRow[convPubClassCase.DisciplineID].ToString().Trim(); //学科ID
objvPubClassCaseEN.DisciplineName = objRow[convPubClassCase.DisciplineName] == DBNull.Value ? null : objRow[convPubClassCase.DisciplineName].ToString().Trim(); //学科名称
objvPubClassCaseEN.IdTeachingPlan = objRow[convPubClassCase.IdTeachingPlan] == DBNull.Value ? null : objRow[convPubClassCase.IdTeachingPlan].ToString().Trim(); //教案流水号
objvPubClassCaseEN.SubjectName = objRow[convPubClassCase.SubjectName] == DBNull.Value ? null : objRow[convPubClassCase.SubjectName].ToString().Trim(); //课题名称
objvPubClassCaseEN.TeachingPlanAuthor = objRow[convPubClassCase.TeachingPlanAuthor] == DBNull.Value ? null : objRow[convPubClassCase.TeachingPlanAuthor].ToString().Trim(); //教案撰写人
objvPubClassCaseEN.TeachingObject = objRow[convPubClassCase.TeachingObject] == DBNull.Value ? null : objRow[convPubClassCase.TeachingObject].ToString().Trim(); //教学目标
objvPubClassCaseEN.TeachingEmphases = objRow[convPubClassCase.TeachingEmphases] == DBNull.Value ? null : objRow[convPubClassCase.TeachingEmphases].ToString().Trim(); //教学重点
objvPubClassCaseEN.TeachingDifficulty = objRow[convPubClassCase.TeachingDifficulty] == DBNull.Value ? null : objRow[convPubClassCase.TeachingDifficulty].ToString().Trim(); //教学难点
objvPubClassCaseEN.TeachingTool = objRow[convPubClassCase.TeachingTool] == DBNull.Value ? null : objRow[convPubClassCase.TeachingTool].ToString().Trim(); //教学用具
objvPubClassCaseEN.TeachingProcess = objRow[convPubClassCase.TeachingProcess] == DBNull.Value ? null : objRow[convPubClassCase.TeachingProcess].ToString().Trim(); //教学过程
objvPubClassCaseEN.TeachingPlanType = objRow[convPubClassCase.TeachingPlanType] == DBNull.Value ? null : objRow[convPubClassCase.TeachingPlanType].ToString().Trim(); //教案类型
objvPubClassCaseEN.SimplePlanContent = objRow[convPubClassCase.SimplePlanContent] == DBNull.Value ? null : objRow[convPubClassCase.SimplePlanContent].ToString().Trim(); //简案内容
objvPubClassCaseEN.PubClassCaseTimeIn = objRow[convPubClassCase.PubClassCaseTimeIn] == DBNull.Value ? null : objRow[convPubClassCase.PubClassCaseTimeIn].ToString().Trim(); //案例入库时间
objvPubClassCaseEN.IdPubClassCaseSenateGaugeVersion = objRow[convPubClassCase.IdPubClassCaseSenateGaugeVersion].ToString().Trim(); //公开课量表版本流水号
objvPubClassCaseEN.senateGaugeVersionID = objRow[convPubClassCase.senateGaugeVersionID] == DBNull.Value ? null : objRow[convPubClassCase.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvPubClassCaseEN.senateGaugeVersionName = objRow[convPubClassCase.senateGaugeVersionName] == DBNull.Value ? null : objRow[convPubClassCase.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvPubClassCaseEN.senateGaugeVersionTtlScore = objRow[convPubClassCase.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convPubClassCase.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvPubClassCaseEN.IdPubCaseType = objRow[convPubClassCase.IdPubCaseType] == DBNull.Value ? null : objRow[convPubClassCase.IdPubCaseType].ToString().Trim(); //公开课案例类型流水号
objvPubClassCaseEN.PubCaseTypeID = objRow[convPubClassCase.PubCaseTypeID] == DBNull.Value ? null : objRow[convPubClassCase.PubCaseTypeID].ToString().Trim(); //公开课案例类型ID
objvPubClassCaseEN.PubCaseTypeName = objRow[convPubClassCase.PubCaseTypeName] == DBNull.Value ? null : objRow[convPubClassCase.PubCaseTypeName].ToString().Trim(); //公开课案例类型名称
objvPubClassCaseEN.IdStudyLevel = objRow[convPubClassCase.IdStudyLevel] == DBNull.Value ? null : objRow[convPubClassCase.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvPubClassCaseEN.StudyLevelName = objRow[convPubClassCase.StudyLevelName] == DBNull.Value ? null : objRow[convPubClassCase.StudyLevelName].ToString().Trim(); //学段名称
objvPubClassCaseEN.CDID = objRow[convPubClassCase.CDID] == DBNull.Value ? null : objRow[convPubClassCase.CDID].ToString().Trim(); //光盘编号
objvPubClassCaseEN.Introduction = objRow[convPubClassCase.Introduction] == DBNull.Value ? null : objRow[convPubClassCase.Introduction].ToString().Trim(); //简要介绍
objvPubClassCaseEN.IsVisible = TransNullToBool(objRow[convPubClassCase.IsVisible].ToString().Trim()); //是否显示
objvPubClassCaseEN.IsDualVideo = TransNullToBool(objRow[convPubClassCase.IsDualVideo].ToString().Trim()); //是否双视频
objvPubClassCaseEN.RecommendedDegreeId = objRow[convPubClassCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvPubClassCaseEN.RecommendedDegreeName = objRow[convPubClassCase.RecommendedDegreeName] == DBNull.Value ? null : objRow[convPubClassCase.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvPubClassCaseEN.ftpFileType = objRow[convPubClassCase.ftpFileType] == DBNull.Value ? null : objRow[convPubClassCase.ftpFileType].ToString().Trim(); //ftp文件类型
objvPubClassCaseEN.VideoUrl = objRow[convPubClassCase.VideoUrl] == DBNull.Value ? null : objRow[convPubClassCase.VideoUrl].ToString().Trim(); //视频Url
objvPubClassCaseEN.VideoPath = objRow[convPubClassCase.VideoPath] == DBNull.Value ? null : objRow[convPubClassCase.VideoPath].ToString().Trim(); //视频目录
objvPubClassCaseEN.ResErrMsg = objRow[convPubClassCase.ResErrMsg] == DBNull.Value ? null : objRow[convPubClassCase.ResErrMsg].ToString().Trim(); //资源错误信息
objvPubClassCaseEN.Memo = objRow[convPubClassCase.Memo] == DBNull.Value ? null : objRow[convPubClassCase.Memo].ToString().Trim(); //备注
objvPubClassCaseEN.BrowseCount4Case = objRow[convPubClassCase.BrowseCount4Case] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPubClassCase.BrowseCount4Case].ToString().Trim()); //课例浏览次数
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvPubClassCaseDA: GetObjByDataRowvPubClassCase)", objException.Message));
}
objvPubClassCaseEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvPubClassCaseEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvPubClassCaseEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvPubClassCaseEN objvPubClassCaseEN = new clsvPubClassCaseEN();
try
{
objvPubClassCaseEN.IdPubClassCase = objRow[convPubClassCase.IdPubClassCase].ToString().Trim(); //案例流水号
objvPubClassCaseEN.PubClassCaseID = objRow[convPubClassCase.PubClassCaseID].ToString().Trim(); //案例ID
objvPubClassCaseEN.PubClassCaseName = objRow[convPubClassCase.PubClassCaseName].ToString().Trim(); //案例课题名称
objvPubClassCaseEN.PubClassCaseExecutor = objRow[convPubClassCase.PubClassCaseExecutor] == DBNull.Value ? null : objRow[convPubClassCase.PubClassCaseExecutor].ToString().Trim(); //案例执教者
objvPubClassCaseEN.WorkUnit = objRow[convPubClassCase.WorkUnit] == DBNull.Value ? null : objRow[convPubClassCase.WorkUnit].ToString().Trim(); //工作单位
objvPubClassCaseEN.PubClassCaseTheme = objRow[convPubClassCase.PubClassCaseTheme] == DBNull.Value ? null : objRow[convPubClassCase.PubClassCaseTheme].ToString().Trim(); //案例主题词
objvPubClassCaseEN.PubClassCaseBG = objRow[convPubClassCase.PubClassCaseBG] == DBNull.Value ? null : objRow[convPubClassCase.PubClassCaseBG].ToString().Trim(); //案例背景资料
objvPubClassCaseEN.PubClassCaseTeachDate = objRow[convPubClassCase.PubClassCaseTeachDate] == DBNull.Value ? null : objRow[convPubClassCase.PubClassCaseTeachDate].ToString().Trim(); //案例授课日期
objvPubClassCaseEN.PubClassCaseDateIn = objRow[convPubClassCase.PubClassCaseDateIn] == DBNull.Value ? null : objRow[convPubClassCase.PubClassCaseDateIn].ToString().Trim(); //案例入库日期
objvPubClassCaseEN.IdDiscipline = objRow[convPubClassCase.IdDiscipline].ToString().Trim(); //学科流水号
objvPubClassCaseEN.DisciplineID = objRow[convPubClassCase.DisciplineID] == DBNull.Value ? null : objRow[convPubClassCase.DisciplineID].ToString().Trim(); //学科ID
objvPubClassCaseEN.DisciplineName = objRow[convPubClassCase.DisciplineName] == DBNull.Value ? null : objRow[convPubClassCase.DisciplineName].ToString().Trim(); //学科名称
objvPubClassCaseEN.IdTeachingPlan = objRow[convPubClassCase.IdTeachingPlan] == DBNull.Value ? null : objRow[convPubClassCase.IdTeachingPlan].ToString().Trim(); //教案流水号
objvPubClassCaseEN.SubjectName = objRow[convPubClassCase.SubjectName] == DBNull.Value ? null : objRow[convPubClassCase.SubjectName].ToString().Trim(); //课题名称
objvPubClassCaseEN.TeachingPlanAuthor = objRow[convPubClassCase.TeachingPlanAuthor] == DBNull.Value ? null : objRow[convPubClassCase.TeachingPlanAuthor].ToString().Trim(); //教案撰写人
objvPubClassCaseEN.TeachingObject = objRow[convPubClassCase.TeachingObject] == DBNull.Value ? null : objRow[convPubClassCase.TeachingObject].ToString().Trim(); //教学目标
objvPubClassCaseEN.TeachingEmphases = objRow[convPubClassCase.TeachingEmphases] == DBNull.Value ? null : objRow[convPubClassCase.TeachingEmphases].ToString().Trim(); //教学重点
objvPubClassCaseEN.TeachingDifficulty = objRow[convPubClassCase.TeachingDifficulty] == DBNull.Value ? null : objRow[convPubClassCase.TeachingDifficulty].ToString().Trim(); //教学难点
objvPubClassCaseEN.TeachingTool = objRow[convPubClassCase.TeachingTool] == DBNull.Value ? null : objRow[convPubClassCase.TeachingTool].ToString().Trim(); //教学用具
objvPubClassCaseEN.TeachingProcess = objRow[convPubClassCase.TeachingProcess] == DBNull.Value ? null : objRow[convPubClassCase.TeachingProcess].ToString().Trim(); //教学过程
objvPubClassCaseEN.TeachingPlanType = objRow[convPubClassCase.TeachingPlanType] == DBNull.Value ? null : objRow[convPubClassCase.TeachingPlanType].ToString().Trim(); //教案类型
objvPubClassCaseEN.SimplePlanContent = objRow[convPubClassCase.SimplePlanContent] == DBNull.Value ? null : objRow[convPubClassCase.SimplePlanContent].ToString().Trim(); //简案内容
objvPubClassCaseEN.PubClassCaseTimeIn = objRow[convPubClassCase.PubClassCaseTimeIn] == DBNull.Value ? null : objRow[convPubClassCase.PubClassCaseTimeIn].ToString().Trim(); //案例入库时间
objvPubClassCaseEN.IdPubClassCaseSenateGaugeVersion = objRow[convPubClassCase.IdPubClassCaseSenateGaugeVersion].ToString().Trim(); //公开课量表版本流水号
objvPubClassCaseEN.senateGaugeVersionID = objRow[convPubClassCase.senateGaugeVersionID] == DBNull.Value ? null : objRow[convPubClassCase.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvPubClassCaseEN.senateGaugeVersionName = objRow[convPubClassCase.senateGaugeVersionName] == DBNull.Value ? null : objRow[convPubClassCase.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvPubClassCaseEN.senateGaugeVersionTtlScore = objRow[convPubClassCase.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convPubClassCase.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvPubClassCaseEN.IdPubCaseType = objRow[convPubClassCase.IdPubCaseType] == DBNull.Value ? null : objRow[convPubClassCase.IdPubCaseType].ToString().Trim(); //公开课案例类型流水号
objvPubClassCaseEN.PubCaseTypeID = objRow[convPubClassCase.PubCaseTypeID] == DBNull.Value ? null : objRow[convPubClassCase.PubCaseTypeID].ToString().Trim(); //公开课案例类型ID
objvPubClassCaseEN.PubCaseTypeName = objRow[convPubClassCase.PubCaseTypeName] == DBNull.Value ? null : objRow[convPubClassCase.PubCaseTypeName].ToString().Trim(); //公开课案例类型名称
objvPubClassCaseEN.IdStudyLevel = objRow[convPubClassCase.IdStudyLevel] == DBNull.Value ? null : objRow[convPubClassCase.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvPubClassCaseEN.StudyLevelName = objRow[convPubClassCase.StudyLevelName] == DBNull.Value ? null : objRow[convPubClassCase.StudyLevelName].ToString().Trim(); //学段名称
objvPubClassCaseEN.CDID = objRow[convPubClassCase.CDID] == DBNull.Value ? null : objRow[convPubClassCase.CDID].ToString().Trim(); //光盘编号
objvPubClassCaseEN.Introduction = objRow[convPubClassCase.Introduction] == DBNull.Value ? null : objRow[convPubClassCase.Introduction].ToString().Trim(); //简要介绍
objvPubClassCaseEN.IsVisible = TransNullToBool(objRow[convPubClassCase.IsVisible].ToString().Trim()); //是否显示
objvPubClassCaseEN.IsDualVideo = TransNullToBool(objRow[convPubClassCase.IsDualVideo].ToString().Trim()); //是否双视频
objvPubClassCaseEN.RecommendedDegreeId = objRow[convPubClassCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvPubClassCaseEN.RecommendedDegreeName = objRow[convPubClassCase.RecommendedDegreeName] == DBNull.Value ? null : objRow[convPubClassCase.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvPubClassCaseEN.ftpFileType = objRow[convPubClassCase.ftpFileType] == DBNull.Value ? null : objRow[convPubClassCase.ftpFileType].ToString().Trim(); //ftp文件类型
objvPubClassCaseEN.VideoUrl = objRow[convPubClassCase.VideoUrl] == DBNull.Value ? null : objRow[convPubClassCase.VideoUrl].ToString().Trim(); //视频Url
objvPubClassCaseEN.VideoPath = objRow[convPubClassCase.VideoPath] == DBNull.Value ? null : objRow[convPubClassCase.VideoPath].ToString().Trim(); //视频目录
objvPubClassCaseEN.ResErrMsg = objRow[convPubClassCase.ResErrMsg] == DBNull.Value ? null : objRow[convPubClassCase.ResErrMsg].ToString().Trim(); //资源错误信息
objvPubClassCaseEN.Memo = objRow[convPubClassCase.Memo] == DBNull.Value ? null : objRow[convPubClassCase.Memo].ToString().Trim(); //备注
objvPubClassCaseEN.BrowseCount4Case = objRow[convPubClassCase.BrowseCount4Case] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPubClassCase.BrowseCount4Case].ToString().Trim()); //课例浏览次数
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvPubClassCaseDA: GetObjByDataRow)", objException.Message));
}
objvPubClassCaseEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvPubClassCaseEN;
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
objSQL = clsvPubClassCaseDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvPubClassCaseEN._CurrTabName, convPubClassCase.IdPubClassCase, 8, "");
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
objSQL = clsvPubClassCaseDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvPubClassCaseEN._CurrTabName, convPubClassCase.IdPubClassCase, 8, strPrefix);
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
 objSQL = clsvPubClassCaseDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select IdPubClassCase from vPubClassCase where " + strCondition;
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
 objSQL = clsvPubClassCaseDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select IdPubClassCase from vPubClassCase where " + strCondition;
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
 objSQL = clsvPubClassCaseDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vPubClassCase", "IdPubClassCase = " + "'"+ strIdPubClassCase+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvPubClassCaseDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPubClassCaseDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vPubClassCase", strCondition))
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
objSQL = clsvPubClassCaseDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vPubClassCase");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvPubClassCaseENS">源对象</param>
 /// <param name = "objvPubClassCaseENT">目标对象</param>
public void CopyTo(clsvPubClassCaseEN objvPubClassCaseENS, clsvPubClassCaseEN objvPubClassCaseENT)
{
objvPubClassCaseENT.IdPubClassCase = objvPubClassCaseENS.IdPubClassCase; //案例流水号
objvPubClassCaseENT.PubClassCaseID = objvPubClassCaseENS.PubClassCaseID; //案例ID
objvPubClassCaseENT.PubClassCaseName = objvPubClassCaseENS.PubClassCaseName; //案例课题名称
objvPubClassCaseENT.PubClassCaseExecutor = objvPubClassCaseENS.PubClassCaseExecutor; //案例执教者
objvPubClassCaseENT.WorkUnit = objvPubClassCaseENS.WorkUnit; //工作单位
objvPubClassCaseENT.PubClassCaseTheme = objvPubClassCaseENS.PubClassCaseTheme; //案例主题词
objvPubClassCaseENT.PubClassCaseBG = objvPubClassCaseENS.PubClassCaseBG; //案例背景资料
objvPubClassCaseENT.PubClassCaseTeachDate = objvPubClassCaseENS.PubClassCaseTeachDate; //案例授课日期
objvPubClassCaseENT.PubClassCaseDateIn = objvPubClassCaseENS.PubClassCaseDateIn; //案例入库日期
objvPubClassCaseENT.IdDiscipline = objvPubClassCaseENS.IdDiscipline; //学科流水号
objvPubClassCaseENT.DisciplineID = objvPubClassCaseENS.DisciplineID; //学科ID
objvPubClassCaseENT.DisciplineName = objvPubClassCaseENS.DisciplineName; //学科名称
objvPubClassCaseENT.IdTeachingPlan = objvPubClassCaseENS.IdTeachingPlan; //教案流水号
objvPubClassCaseENT.SubjectName = objvPubClassCaseENS.SubjectName; //课题名称
objvPubClassCaseENT.TeachingPlanAuthor = objvPubClassCaseENS.TeachingPlanAuthor; //教案撰写人
objvPubClassCaseENT.TeachingObject = objvPubClassCaseENS.TeachingObject; //教学目标
objvPubClassCaseENT.TeachingEmphases = objvPubClassCaseENS.TeachingEmphases; //教学重点
objvPubClassCaseENT.TeachingDifficulty = objvPubClassCaseENS.TeachingDifficulty; //教学难点
objvPubClassCaseENT.TeachingTool = objvPubClassCaseENS.TeachingTool; //教学用具
objvPubClassCaseENT.TeachingProcess = objvPubClassCaseENS.TeachingProcess; //教学过程
objvPubClassCaseENT.TeachingPlanType = objvPubClassCaseENS.TeachingPlanType; //教案类型
objvPubClassCaseENT.SimplePlanContent = objvPubClassCaseENS.SimplePlanContent; //简案内容
objvPubClassCaseENT.PubClassCaseTimeIn = objvPubClassCaseENS.PubClassCaseTimeIn; //案例入库时间
objvPubClassCaseENT.IdPubClassCaseSenateGaugeVersion = objvPubClassCaseENS.IdPubClassCaseSenateGaugeVersion; //公开课量表版本流水号
objvPubClassCaseENT.senateGaugeVersionID = objvPubClassCaseENS.senateGaugeVersionID; //评价量表版本ID
objvPubClassCaseENT.senateGaugeVersionName = objvPubClassCaseENS.senateGaugeVersionName; //评价量表版本名称
objvPubClassCaseENT.senateGaugeVersionTtlScore = objvPubClassCaseENS.senateGaugeVersionTtlScore; //评价量表版本总分
objvPubClassCaseENT.IdPubCaseType = objvPubClassCaseENS.IdPubCaseType; //公开课案例类型流水号
objvPubClassCaseENT.PubCaseTypeID = objvPubClassCaseENS.PubCaseTypeID; //公开课案例类型ID
objvPubClassCaseENT.PubCaseTypeName = objvPubClassCaseENS.PubCaseTypeName; //公开课案例类型名称
objvPubClassCaseENT.IdStudyLevel = objvPubClassCaseENS.IdStudyLevel; //id_StudyLevel
objvPubClassCaseENT.StudyLevelName = objvPubClassCaseENS.StudyLevelName; //学段名称
objvPubClassCaseENT.CDID = objvPubClassCaseENS.CDID; //光盘编号
objvPubClassCaseENT.Introduction = objvPubClassCaseENS.Introduction; //简要介绍
objvPubClassCaseENT.IsVisible = objvPubClassCaseENS.IsVisible; //是否显示
objvPubClassCaseENT.IsDualVideo = objvPubClassCaseENS.IsDualVideo; //是否双视频
objvPubClassCaseENT.RecommendedDegreeId = objvPubClassCaseENS.RecommendedDegreeId; //推荐度Id
objvPubClassCaseENT.RecommendedDegreeName = objvPubClassCaseENS.RecommendedDegreeName; //推荐度名称
objvPubClassCaseENT.ftpFileType = objvPubClassCaseENS.ftpFileType; //ftp文件类型
objvPubClassCaseENT.VideoUrl = objvPubClassCaseENS.VideoUrl; //视频Url
objvPubClassCaseENT.VideoPath = objvPubClassCaseENS.VideoPath; //视频目录
objvPubClassCaseENT.ResErrMsg = objvPubClassCaseENS.ResErrMsg; //资源错误信息
objvPubClassCaseENT.Memo = objvPubClassCaseENS.Memo; //备注
objvPubClassCaseENT.BrowseCount4Case = objvPubClassCaseENS.BrowseCount4Case; //课例浏览次数
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvPubClassCaseEN objvPubClassCaseEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvPubClassCaseEN.IdPubClassCase, 8, convPubClassCase.IdPubClassCase);
clsCheckSql.CheckFieldLen(objvPubClassCaseEN.PubClassCaseID, 8, convPubClassCase.PubClassCaseID);
clsCheckSql.CheckFieldLen(objvPubClassCaseEN.PubClassCaseName, 200, convPubClassCase.PubClassCaseName);
clsCheckSql.CheckFieldLen(objvPubClassCaseEN.PubClassCaseExecutor, 50, convPubClassCase.PubClassCaseExecutor);
clsCheckSql.CheckFieldLen(objvPubClassCaseEN.WorkUnit, 100, convPubClassCase.WorkUnit);
clsCheckSql.CheckFieldLen(objvPubClassCaseEN.PubClassCaseTheme, 500, convPubClassCase.PubClassCaseTheme);
clsCheckSql.CheckFieldLen(objvPubClassCaseEN.PubClassCaseTeachDate, 8, convPubClassCase.PubClassCaseTeachDate);
clsCheckSql.CheckFieldLen(objvPubClassCaseEN.PubClassCaseDateIn, 8, convPubClassCase.PubClassCaseDateIn);
clsCheckSql.CheckFieldLen(objvPubClassCaseEN.IdDiscipline, 4, convPubClassCase.IdDiscipline);
clsCheckSql.CheckFieldLen(objvPubClassCaseEN.DisciplineID, 4, convPubClassCase.DisciplineID);
clsCheckSql.CheckFieldLen(objvPubClassCaseEN.DisciplineName, 50, convPubClassCase.DisciplineName);
clsCheckSql.CheckFieldLen(objvPubClassCaseEN.IdTeachingPlan, 8, convPubClassCase.IdTeachingPlan);
clsCheckSql.CheckFieldLen(objvPubClassCaseEN.SubjectName, 200, convPubClassCase.SubjectName);
clsCheckSql.CheckFieldLen(objvPubClassCaseEN.TeachingPlanAuthor, 50, convPubClassCase.TeachingPlanAuthor);
clsCheckSql.CheckFieldLen(objvPubClassCaseEN.TeachingObject, 5000, convPubClassCase.TeachingObject);
clsCheckSql.CheckFieldLen(objvPubClassCaseEN.TeachingEmphases, 5000, convPubClassCase.TeachingEmphases);
clsCheckSql.CheckFieldLen(objvPubClassCaseEN.TeachingDifficulty, 5000, convPubClassCase.TeachingDifficulty);
clsCheckSql.CheckFieldLen(objvPubClassCaseEN.TeachingTool, 5000, convPubClassCase.TeachingTool);
clsCheckSql.CheckFieldLen(objvPubClassCaseEN.TeachingProcess, 8000, convPubClassCase.TeachingProcess);
clsCheckSql.CheckFieldLen(objvPubClassCaseEN.TeachingPlanType, 1, convPubClassCase.TeachingPlanType);
clsCheckSql.CheckFieldLen(objvPubClassCaseEN.PubClassCaseTimeIn, 6, convPubClassCase.PubClassCaseTimeIn);
clsCheckSql.CheckFieldLen(objvPubClassCaseEN.IdPubClassCaseSenateGaugeVersion, 4, convPubClassCase.IdPubClassCaseSenateGaugeVersion);
clsCheckSql.CheckFieldLen(objvPubClassCaseEN.senateGaugeVersionID, 4, convPubClassCase.senateGaugeVersionID);
clsCheckSql.CheckFieldLen(objvPubClassCaseEN.senateGaugeVersionName, 200, convPubClassCase.senateGaugeVersionName);
clsCheckSql.CheckFieldLen(objvPubClassCaseEN.IdPubCaseType, 4, convPubClassCase.IdPubCaseType);
clsCheckSql.CheckFieldLen(objvPubClassCaseEN.PubCaseTypeID, 4, convPubClassCase.PubCaseTypeID);
clsCheckSql.CheckFieldLen(objvPubClassCaseEN.PubCaseTypeName, 50, convPubClassCase.PubCaseTypeName);
clsCheckSql.CheckFieldLen(objvPubClassCaseEN.IdStudyLevel, 4, convPubClassCase.IdStudyLevel);
clsCheckSql.CheckFieldLen(objvPubClassCaseEN.StudyLevelName, 50, convPubClassCase.StudyLevelName);
clsCheckSql.CheckFieldLen(objvPubClassCaseEN.CDID, 50, convPubClassCase.CDID);
clsCheckSql.CheckFieldLen(objvPubClassCaseEN.Introduction, 4000, convPubClassCase.Introduction);
clsCheckSql.CheckFieldLen(objvPubClassCaseEN.RecommendedDegreeId, 2, convPubClassCase.RecommendedDegreeId);
clsCheckSql.CheckFieldLen(objvPubClassCaseEN.RecommendedDegreeName, 30, convPubClassCase.RecommendedDegreeName);
clsCheckSql.CheckFieldLen(objvPubClassCaseEN.ftpFileType, 30, convPubClassCase.ftpFileType);
clsCheckSql.CheckFieldLen(objvPubClassCaseEN.VideoUrl, 1000, convPubClassCase.VideoUrl);
clsCheckSql.CheckFieldLen(objvPubClassCaseEN.VideoPath, 1000, convPubClassCase.VideoPath);
clsCheckSql.CheckFieldLen(objvPubClassCaseEN.ResErrMsg, 30, convPubClassCase.ResErrMsg);
clsCheckSql.CheckFieldLen(objvPubClassCaseEN.Memo, 1000, convPubClassCase.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvPubClassCaseEN.IdPubClassCase, convPubClassCase.IdPubClassCase);
clsCheckSql.CheckSqlInjection4Field(objvPubClassCaseEN.PubClassCaseID, convPubClassCase.PubClassCaseID);
clsCheckSql.CheckSqlInjection4Field(objvPubClassCaseEN.PubClassCaseName, convPubClassCase.PubClassCaseName);
clsCheckSql.CheckSqlInjection4Field(objvPubClassCaseEN.PubClassCaseExecutor, convPubClassCase.PubClassCaseExecutor);
clsCheckSql.CheckSqlInjection4Field(objvPubClassCaseEN.WorkUnit, convPubClassCase.WorkUnit);
clsCheckSql.CheckSqlInjection4Field(objvPubClassCaseEN.PubClassCaseTheme, convPubClassCase.PubClassCaseTheme);
clsCheckSql.CheckSqlInjection4Field(objvPubClassCaseEN.PubClassCaseTeachDate, convPubClassCase.PubClassCaseTeachDate);
clsCheckSql.CheckSqlInjection4Field(objvPubClassCaseEN.PubClassCaseDateIn, convPubClassCase.PubClassCaseDateIn);
clsCheckSql.CheckSqlInjection4Field(objvPubClassCaseEN.IdDiscipline, convPubClassCase.IdDiscipline);
clsCheckSql.CheckSqlInjection4Field(objvPubClassCaseEN.DisciplineID, convPubClassCase.DisciplineID);
clsCheckSql.CheckSqlInjection4Field(objvPubClassCaseEN.DisciplineName, convPubClassCase.DisciplineName);
clsCheckSql.CheckSqlInjection4Field(objvPubClassCaseEN.IdTeachingPlan, convPubClassCase.IdTeachingPlan);
clsCheckSql.CheckSqlInjection4Field(objvPubClassCaseEN.SubjectName, convPubClassCase.SubjectName);
clsCheckSql.CheckSqlInjection4Field(objvPubClassCaseEN.TeachingPlanAuthor, convPubClassCase.TeachingPlanAuthor);
clsCheckSql.CheckSqlInjection4Field(objvPubClassCaseEN.TeachingObject, convPubClassCase.TeachingObject);
clsCheckSql.CheckSqlInjection4Field(objvPubClassCaseEN.TeachingEmphases, convPubClassCase.TeachingEmphases);
clsCheckSql.CheckSqlInjection4Field(objvPubClassCaseEN.TeachingDifficulty, convPubClassCase.TeachingDifficulty);
clsCheckSql.CheckSqlInjection4Field(objvPubClassCaseEN.TeachingTool, convPubClassCase.TeachingTool);
clsCheckSql.CheckSqlInjection4Field(objvPubClassCaseEN.TeachingProcess, convPubClassCase.TeachingProcess);
clsCheckSql.CheckSqlInjection4Field(objvPubClassCaseEN.TeachingPlanType, convPubClassCase.TeachingPlanType);
clsCheckSql.CheckSqlInjection4Field(objvPubClassCaseEN.PubClassCaseTimeIn, convPubClassCase.PubClassCaseTimeIn);
clsCheckSql.CheckSqlInjection4Field(objvPubClassCaseEN.IdPubClassCaseSenateGaugeVersion, convPubClassCase.IdPubClassCaseSenateGaugeVersion);
clsCheckSql.CheckSqlInjection4Field(objvPubClassCaseEN.senateGaugeVersionID, convPubClassCase.senateGaugeVersionID);
clsCheckSql.CheckSqlInjection4Field(objvPubClassCaseEN.senateGaugeVersionName, convPubClassCase.senateGaugeVersionName);
clsCheckSql.CheckSqlInjection4Field(objvPubClassCaseEN.IdPubCaseType, convPubClassCase.IdPubCaseType);
clsCheckSql.CheckSqlInjection4Field(objvPubClassCaseEN.PubCaseTypeID, convPubClassCase.PubCaseTypeID);
clsCheckSql.CheckSqlInjection4Field(objvPubClassCaseEN.PubCaseTypeName, convPubClassCase.PubCaseTypeName);
clsCheckSql.CheckSqlInjection4Field(objvPubClassCaseEN.IdStudyLevel, convPubClassCase.IdStudyLevel);
clsCheckSql.CheckSqlInjection4Field(objvPubClassCaseEN.StudyLevelName, convPubClassCase.StudyLevelName);
clsCheckSql.CheckSqlInjection4Field(objvPubClassCaseEN.CDID, convPubClassCase.CDID);
clsCheckSql.CheckSqlInjection4Field(objvPubClassCaseEN.Introduction, convPubClassCase.Introduction);
clsCheckSql.CheckSqlInjection4Field(objvPubClassCaseEN.RecommendedDegreeId, convPubClassCase.RecommendedDegreeId);
clsCheckSql.CheckSqlInjection4Field(objvPubClassCaseEN.RecommendedDegreeName, convPubClassCase.RecommendedDegreeName);
clsCheckSql.CheckSqlInjection4Field(objvPubClassCaseEN.ftpFileType, convPubClassCase.ftpFileType);
clsCheckSql.CheckSqlInjection4Field(objvPubClassCaseEN.VideoUrl, convPubClassCase.VideoUrl);
clsCheckSql.CheckSqlInjection4Field(objvPubClassCaseEN.VideoPath, convPubClassCase.VideoPath);
clsCheckSql.CheckSqlInjection4Field(objvPubClassCaseEN.ResErrMsg, convPubClassCase.ResErrMsg);
clsCheckSql.CheckSqlInjection4Field(objvPubClassCaseEN.Memo, convPubClassCase.Memo);
//检查外键字段长度
 objvPubClassCaseEN._IsCheckProperty = true;
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
 objSQL = clsvPubClassCaseDA.GetSpecSQLObj();
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
 objSQL = clsvPubClassCaseDA.GetSpecSQLObj();
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
 objSQL = clsvPubClassCaseDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvPubClassCaseEN._CurrTabName);
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
 objSQL = clsvPubClassCaseDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvPubClassCaseEN._CurrTabName, strCondition);
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
 objSQL = clsvPubClassCaseDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}