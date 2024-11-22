
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsTeachCaseDA
 表名:TeachCase(01120383)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:20:45
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:技能示范(SkillDemo)
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
 /// 案例(TeachCase)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsTeachCaseDA : clsCommBase4DA
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
 return clsTeachCaseEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsTeachCaseEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsTeachCaseEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsTeachCaseEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsTeachCaseEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strIdTeachCase">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strIdTeachCase)
{
strIdTeachCase = strIdTeachCase.Replace("'", "''");
if (strIdTeachCase.Length > 8)
{
throw new Exception("(errid:Data000001)在表:TeachCase中,检查关键字,长度不正确!(clsTeachCaseDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strIdTeachCase)  ==  true)
{
throw new Exception("(errid:Data000002)在表:TeachCase中,关键字不能为空 或 null!(clsTeachCaseDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strIdTeachCase);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsTeachCaseDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsTeachCaseDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeachCaseDA.GetSpecSQLObj();
strSQL = "Select * from TeachCase where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_TeachCase(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsTeachCaseDA: GetDataTable_TeachCase)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeachCaseDA.GetSpecSQLObj();
strSQL = "Select * from TeachCase where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsTeachCaseDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeachCaseDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsTeachCaseDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeachCaseDA.GetSpecSQLObj();
strSQL = "Select * from TeachCase where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsTeachCaseDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeachCaseDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsTeachCaseDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeachCaseDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from TeachCase where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from TeachCase where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsTeachCaseDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeachCaseDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from TeachCase where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsTeachCaseDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeachCaseDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} TeachCase.* from TeachCase Left Join {1} on {2} where {3} and TeachCase.IdTeachCase not in (Select top {5} TeachCase.IdTeachCase from TeachCase Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from TeachCase where {1} and IdTeachCase not in (Select top {2} IdTeachCase from TeachCase where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from TeachCase where {1} and IdTeachCase not in (Select top {3} IdTeachCase from TeachCase where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsTeachCaseDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeachCaseDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} TeachCase.* from TeachCase Left Join {1} on {2} where {3} and TeachCase.IdTeachCase not in (Select top {5} TeachCase.IdTeachCase from TeachCase Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from TeachCase where {1} and IdTeachCase not in (Select top {2} IdTeachCase from TeachCase where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from TeachCase where {1} and IdTeachCase not in (Select top {3} IdTeachCase from TeachCase where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsTeachCaseEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsTeachCaseDA:GetObjLst)", objException.Message));
}
List<clsTeachCaseEN> arrObjLst = new List<clsTeachCaseEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeachCaseDA.GetSpecSQLObj();
strSQL = "Select * from TeachCase where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsTeachCaseEN objTeachCaseEN = new clsTeachCaseEN();
try
{
objTeachCaseEN.IdTeachCase = objRow[conTeachCase.IdTeachCase].ToString().Trim(); //案例流水号
objTeachCaseEN.TeachCaseID = objRow[conTeachCase.TeachCaseID].ToString().Trim(); //案例ID
objTeachCaseEN.TeachCaseName = objRow[conTeachCase.TeachCaseName].ToString().Trim(); //案例名称
objTeachCaseEN.TeachCaseExecutor = objRow[conTeachCase.TeachCaseExecutor] == DBNull.Value ? null : objRow[conTeachCase.TeachCaseExecutor].ToString().Trim(); //案例执教者
objTeachCaseEN.TeachCaseTheme = objRow[conTeachCase.TeachCaseTheme] == DBNull.Value ? null : objRow[conTeachCase.TeachCaseTheme].ToString().Trim(); //案例主题词
objTeachCaseEN.TeachCaseTeachDate = objRow[conTeachCase.TeachCaseTeachDate] == DBNull.Value ? null : objRow[conTeachCase.TeachCaseTeachDate].ToString().Trim(); //案例授课日期
objTeachCaseEN.TeachCaseBG = objRow[conTeachCase.TeachCaseBG] == DBNull.Value ? null : objRow[conTeachCase.TeachCaseBG].ToString().Trim(); //案例背景资料
objTeachCaseEN.IdTeachSkill = objRow[conTeachCase.IdTeachSkill].ToString().Trim(); //教学技能流水号
objTeachCaseEN.IdDiscipline = objRow[conTeachCase.IdDiscipline].ToString().Trim(); //学科流水号
objTeachCaseEN.IdStudyLevel = objRow[conTeachCase.IdStudyLevel].ToString().Trim(); //学段流水号
objTeachCaseEN.TeachCaseDateIn = objRow[conTeachCase.TeachCaseDateIn] == DBNull.Value ? null : objRow[conTeachCase.TeachCaseDateIn].ToString().Trim(); //案例入库日期
objTeachCaseEN.IdTeachingPlan = objRow[conTeachCase.IdTeachingPlan] == DBNull.Value ? null : objRow[conTeachCase.IdTeachingPlan].ToString().Trim(); //教案流水号
objTeachCaseEN.TeachCaseTimeIn = objRow[conTeachCase.TeachCaseTimeIn] == DBNull.Value ? null : objRow[conTeachCase.TeachCaseTimeIn].ToString().Trim(); //案例入库时间
objTeachCaseEN.WorkUnit = objRow[conTeachCase.WorkUnit] == DBNull.Value ? null : objRow[conTeachCase.WorkUnit].ToString().Trim(); //工作单位
objTeachCaseEN.CDID = objRow[conTeachCase.CDID] == DBNull.Value ? null : objRow[conTeachCase.CDID].ToString().Trim(); //光盘编号
objTeachCaseEN.BrowseCount = objRow[conTeachCase.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conTeachCase.BrowseCount].ToString().Trim()); //浏览次数
objTeachCaseEN.IsVisible = TransNullToBool(objRow[conTeachCase.IsVisible].ToString().Trim()); //是否显示
objTeachCaseEN.IsDualVideo = TransNullToBool(objRow[conTeachCase.IsDualVideo].ToString().Trim()); //是否双视频
objTeachCaseEN.IdXzCollege = objRow[conTeachCase.IdXzCollege] == DBNull.Value ? null : objRow[conTeachCase.IdXzCollege].ToString().Trim(); //学院流水号
objTeachCaseEN.RecommendedDegreeId = objRow[conTeachCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objTeachCaseEN.ftpFileType = objRow[conTeachCase.ftpFileType] == DBNull.Value ? null : objRow[conTeachCase.ftpFileType].ToString().Trim(); //ftp文件类型
objTeachCaseEN.VideoUrl = objRow[conTeachCase.VideoUrl] == DBNull.Value ? null : objRow[conTeachCase.VideoUrl].ToString().Trim(); //视频Url
objTeachCaseEN.VideoPath = objRow[conTeachCase.VideoPath] == DBNull.Value ? null : objRow[conTeachCase.VideoPath].ToString().Trim(); //视频目录
objTeachCaseEN.ResErrMsg = objRow[conTeachCase.ResErrMsg] == DBNull.Value ? null : objRow[conTeachCase.ResErrMsg].ToString().Trim(); //资源错误信息
objTeachCaseEN.UpdDate = objRow[conTeachCase.UpdDate] == DBNull.Value ? null : objRow[conTeachCase.UpdDate].ToString().Trim(); //修改日期
objTeachCaseEN.UpdUserId = objRow[conTeachCase.UpdUserId] == DBNull.Value ? null : objRow[conTeachCase.UpdUserId].ToString().Trim(); //修改用户Id
objTeachCaseEN.Memo = objRow[conTeachCase.Memo] == DBNull.Value ? null : objRow[conTeachCase.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsTeachCaseDA: GetObjLst)", objException.Message));
}
objTeachCaseEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objTeachCaseEN);
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
public List<clsTeachCaseEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsTeachCaseDA:GetObjLstByTabName)", objException.Message));
}
List<clsTeachCaseEN> arrObjLst = new List<clsTeachCaseEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeachCaseDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsTeachCaseEN objTeachCaseEN = new clsTeachCaseEN();
try
{
objTeachCaseEN.IdTeachCase = objRow[conTeachCase.IdTeachCase].ToString().Trim(); //案例流水号
objTeachCaseEN.TeachCaseID = objRow[conTeachCase.TeachCaseID].ToString().Trim(); //案例ID
objTeachCaseEN.TeachCaseName = objRow[conTeachCase.TeachCaseName].ToString().Trim(); //案例名称
objTeachCaseEN.TeachCaseExecutor = objRow[conTeachCase.TeachCaseExecutor] == DBNull.Value ? null : objRow[conTeachCase.TeachCaseExecutor].ToString().Trim(); //案例执教者
objTeachCaseEN.TeachCaseTheme = objRow[conTeachCase.TeachCaseTheme] == DBNull.Value ? null : objRow[conTeachCase.TeachCaseTheme].ToString().Trim(); //案例主题词
objTeachCaseEN.TeachCaseTeachDate = objRow[conTeachCase.TeachCaseTeachDate] == DBNull.Value ? null : objRow[conTeachCase.TeachCaseTeachDate].ToString().Trim(); //案例授课日期
objTeachCaseEN.TeachCaseBG = objRow[conTeachCase.TeachCaseBG] == DBNull.Value ? null : objRow[conTeachCase.TeachCaseBG].ToString().Trim(); //案例背景资料
objTeachCaseEN.IdTeachSkill = objRow[conTeachCase.IdTeachSkill].ToString().Trim(); //教学技能流水号
objTeachCaseEN.IdDiscipline = objRow[conTeachCase.IdDiscipline].ToString().Trim(); //学科流水号
objTeachCaseEN.IdStudyLevel = objRow[conTeachCase.IdStudyLevel].ToString().Trim(); //学段流水号
objTeachCaseEN.TeachCaseDateIn = objRow[conTeachCase.TeachCaseDateIn] == DBNull.Value ? null : objRow[conTeachCase.TeachCaseDateIn].ToString().Trim(); //案例入库日期
objTeachCaseEN.IdTeachingPlan = objRow[conTeachCase.IdTeachingPlan] == DBNull.Value ? null : objRow[conTeachCase.IdTeachingPlan].ToString().Trim(); //教案流水号
objTeachCaseEN.TeachCaseTimeIn = objRow[conTeachCase.TeachCaseTimeIn] == DBNull.Value ? null : objRow[conTeachCase.TeachCaseTimeIn].ToString().Trim(); //案例入库时间
objTeachCaseEN.WorkUnit = objRow[conTeachCase.WorkUnit] == DBNull.Value ? null : objRow[conTeachCase.WorkUnit].ToString().Trim(); //工作单位
objTeachCaseEN.CDID = objRow[conTeachCase.CDID] == DBNull.Value ? null : objRow[conTeachCase.CDID].ToString().Trim(); //光盘编号
objTeachCaseEN.BrowseCount = objRow[conTeachCase.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conTeachCase.BrowseCount].ToString().Trim()); //浏览次数
objTeachCaseEN.IsVisible = TransNullToBool(objRow[conTeachCase.IsVisible].ToString().Trim()); //是否显示
objTeachCaseEN.IsDualVideo = TransNullToBool(objRow[conTeachCase.IsDualVideo].ToString().Trim()); //是否双视频
objTeachCaseEN.IdXzCollege = objRow[conTeachCase.IdXzCollege] == DBNull.Value ? null : objRow[conTeachCase.IdXzCollege].ToString().Trim(); //学院流水号
objTeachCaseEN.RecommendedDegreeId = objRow[conTeachCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objTeachCaseEN.ftpFileType = objRow[conTeachCase.ftpFileType] == DBNull.Value ? null : objRow[conTeachCase.ftpFileType].ToString().Trim(); //ftp文件类型
objTeachCaseEN.VideoUrl = objRow[conTeachCase.VideoUrl] == DBNull.Value ? null : objRow[conTeachCase.VideoUrl].ToString().Trim(); //视频Url
objTeachCaseEN.VideoPath = objRow[conTeachCase.VideoPath] == DBNull.Value ? null : objRow[conTeachCase.VideoPath].ToString().Trim(); //视频目录
objTeachCaseEN.ResErrMsg = objRow[conTeachCase.ResErrMsg] == DBNull.Value ? null : objRow[conTeachCase.ResErrMsg].ToString().Trim(); //资源错误信息
objTeachCaseEN.UpdDate = objRow[conTeachCase.UpdDate] == DBNull.Value ? null : objRow[conTeachCase.UpdDate].ToString().Trim(); //修改日期
objTeachCaseEN.UpdUserId = objRow[conTeachCase.UpdUserId] == DBNull.Value ? null : objRow[conTeachCase.UpdUserId].ToString().Trim(); //修改用户Id
objTeachCaseEN.Memo = objRow[conTeachCase.Memo] == DBNull.Value ? null : objRow[conTeachCase.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsTeachCaseDA: GetObjLst)", objException.Message));
}
objTeachCaseEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objTeachCaseEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objTeachCaseEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetTeachCase(ref clsTeachCaseEN objTeachCaseEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeachCaseDA.GetSpecSQLObj();
strSQL = "Select * from TeachCase where IdTeachCase = " + "'"+ objTeachCaseEN.IdTeachCase+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objTeachCaseEN.IdTeachCase = objDT.Rows[0][conTeachCase.IdTeachCase].ToString().Trim(); //案例流水号(字段类型:char,字段长度:8,是否可空:False)
 objTeachCaseEN.TeachCaseID = objDT.Rows[0][conTeachCase.TeachCaseID].ToString().Trim(); //案例ID(字段类型:char,字段长度:8,是否可空:False)
 objTeachCaseEN.TeachCaseName = objDT.Rows[0][conTeachCase.TeachCaseName].ToString().Trim(); //案例名称(字段类型:varchar,字段长度:200,是否可空:False)
 objTeachCaseEN.TeachCaseExecutor = objDT.Rows[0][conTeachCase.TeachCaseExecutor].ToString().Trim(); //案例执教者(字段类型:varchar,字段长度:50,是否可空:True)
 objTeachCaseEN.TeachCaseTheme = objDT.Rows[0][conTeachCase.TeachCaseTheme].ToString().Trim(); //案例主题词(字段类型:varchar,字段长度:200,是否可空:True)
 objTeachCaseEN.TeachCaseTeachDate = objDT.Rows[0][conTeachCase.TeachCaseTeachDate].ToString().Trim(); //案例授课日期(字段类型:char,字段长度:8,是否可空:True)
 objTeachCaseEN.TeachCaseBG = objDT.Rows[0][conTeachCase.TeachCaseBG].ToString().Trim(); //案例背景资料(字段类型:varchar,字段长度:8000,是否可空:True)
 objTeachCaseEN.IdTeachSkill = objDT.Rows[0][conTeachCase.IdTeachSkill].ToString().Trim(); //教学技能流水号(字段类型:char,字段长度:8,是否可空:False)
 objTeachCaseEN.IdDiscipline = objDT.Rows[0][conTeachCase.IdDiscipline].ToString().Trim(); //学科流水号(字段类型:char,字段长度:4,是否可空:False)
 objTeachCaseEN.IdStudyLevel = objDT.Rows[0][conTeachCase.IdStudyLevel].ToString().Trim(); //学段流水号(字段类型:char,字段长度:4,是否可空:True)
 objTeachCaseEN.TeachCaseDateIn = objDT.Rows[0][conTeachCase.TeachCaseDateIn].ToString().Trim(); //案例入库日期(字段类型:char,字段长度:8,是否可空:True)
 objTeachCaseEN.IdTeachingPlan = objDT.Rows[0][conTeachCase.IdTeachingPlan].ToString().Trim(); //教案流水号(字段类型:char,字段长度:8,是否可空:False)
 objTeachCaseEN.TeachCaseTimeIn = objDT.Rows[0][conTeachCase.TeachCaseTimeIn].ToString().Trim(); //案例入库时间(字段类型:char,字段长度:6,是否可空:True)
 objTeachCaseEN.WorkUnit = objDT.Rows[0][conTeachCase.WorkUnit].ToString().Trim(); //工作单位(字段类型:varchar,字段长度:100,是否可空:True)
 objTeachCaseEN.CDID = objDT.Rows[0][conTeachCase.CDID].ToString().Trim(); //光盘编号(字段类型:varchar,字段长度:50,是否可空:True)
 objTeachCaseEN.BrowseCount = TransNullToInt(objDT.Rows[0][conTeachCase.BrowseCount].ToString().Trim()); //浏览次数(字段类型:int,字段长度:4,是否可空:True)
 objTeachCaseEN.IsVisible = TransNullToBool(objDT.Rows[0][conTeachCase.IsVisible].ToString().Trim()); //是否显示(字段类型:bit,字段长度:1,是否可空:True)
 objTeachCaseEN.IsDualVideo = TransNullToBool(objDT.Rows[0][conTeachCase.IsDualVideo].ToString().Trim()); //是否双视频(字段类型:bit,字段长度:1,是否可空:False)
 objTeachCaseEN.IdXzCollege = objDT.Rows[0][conTeachCase.IdXzCollege].ToString().Trim(); //学院流水号(字段类型:char,字段长度:4,是否可空:True)
 objTeachCaseEN.RecommendedDegreeId = objDT.Rows[0][conTeachCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id(字段类型:char,字段长度:2,是否可空:False)
 objTeachCaseEN.ftpFileType = objDT.Rows[0][conTeachCase.ftpFileType].ToString().Trim(); //ftp文件类型(字段类型:varchar,字段长度:30,是否可空:True)
 objTeachCaseEN.VideoUrl = objDT.Rows[0][conTeachCase.VideoUrl].ToString().Trim(); //视频Url(字段类型:varchar,字段长度:1000,是否可空:True)
 objTeachCaseEN.VideoPath = objDT.Rows[0][conTeachCase.VideoPath].ToString().Trim(); //视频目录(字段类型:varchar,字段长度:1000,是否可空:True)
 objTeachCaseEN.ResErrMsg = objDT.Rows[0][conTeachCase.ResErrMsg].ToString().Trim(); //资源错误信息(字段类型:varchar,字段长度:30,是否可空:True)
 objTeachCaseEN.UpdDate = objDT.Rows[0][conTeachCase.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objTeachCaseEN.UpdUserId = objDT.Rows[0][conTeachCase.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:True)
 objTeachCaseEN.Memo = objDT.Rows[0][conTeachCase.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsTeachCaseDA: GetTeachCase)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strIdTeachCase">表关键字</param>
 /// <returns>表对象</returns>
public clsTeachCaseEN GetObjByIdTeachCase(string strIdTeachCase)
{
CheckPrimaryKey(strIdTeachCase);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeachCaseDA.GetSpecSQLObj();
strSQL = "Select * from TeachCase where IdTeachCase = " + "'"+ strIdTeachCase+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsTeachCaseEN objTeachCaseEN = new clsTeachCaseEN();
try
{
 objTeachCaseEN.IdTeachCase = objRow[conTeachCase.IdTeachCase].ToString().Trim(); //案例流水号(字段类型:char,字段长度:8,是否可空:False)
 objTeachCaseEN.TeachCaseID = objRow[conTeachCase.TeachCaseID].ToString().Trim(); //案例ID(字段类型:char,字段长度:8,是否可空:False)
 objTeachCaseEN.TeachCaseName = objRow[conTeachCase.TeachCaseName].ToString().Trim(); //案例名称(字段类型:varchar,字段长度:200,是否可空:False)
 objTeachCaseEN.TeachCaseExecutor = objRow[conTeachCase.TeachCaseExecutor] == DBNull.Value ? null : objRow[conTeachCase.TeachCaseExecutor].ToString().Trim(); //案例执教者(字段类型:varchar,字段长度:50,是否可空:True)
 objTeachCaseEN.TeachCaseTheme = objRow[conTeachCase.TeachCaseTheme] == DBNull.Value ? null : objRow[conTeachCase.TeachCaseTheme].ToString().Trim(); //案例主题词(字段类型:varchar,字段长度:200,是否可空:True)
 objTeachCaseEN.TeachCaseTeachDate = objRow[conTeachCase.TeachCaseTeachDate] == DBNull.Value ? null : objRow[conTeachCase.TeachCaseTeachDate].ToString().Trim(); //案例授课日期(字段类型:char,字段长度:8,是否可空:True)
 objTeachCaseEN.TeachCaseBG = objRow[conTeachCase.TeachCaseBG] == DBNull.Value ? null : objRow[conTeachCase.TeachCaseBG].ToString().Trim(); //案例背景资料(字段类型:varchar,字段长度:8000,是否可空:True)
 objTeachCaseEN.IdTeachSkill = objRow[conTeachCase.IdTeachSkill].ToString().Trim(); //教学技能流水号(字段类型:char,字段长度:8,是否可空:False)
 objTeachCaseEN.IdDiscipline = objRow[conTeachCase.IdDiscipline].ToString().Trim(); //学科流水号(字段类型:char,字段长度:4,是否可空:False)
 objTeachCaseEN.IdStudyLevel = objRow[conTeachCase.IdStudyLevel].ToString().Trim(); //学段流水号(字段类型:char,字段长度:4,是否可空:True)
 objTeachCaseEN.TeachCaseDateIn = objRow[conTeachCase.TeachCaseDateIn] == DBNull.Value ? null : objRow[conTeachCase.TeachCaseDateIn].ToString().Trim(); //案例入库日期(字段类型:char,字段长度:8,是否可空:True)
 objTeachCaseEN.IdTeachingPlan = objRow[conTeachCase.IdTeachingPlan] == DBNull.Value ? null : objRow[conTeachCase.IdTeachingPlan].ToString().Trim(); //教案流水号(字段类型:char,字段长度:8,是否可空:False)
 objTeachCaseEN.TeachCaseTimeIn = objRow[conTeachCase.TeachCaseTimeIn] == DBNull.Value ? null : objRow[conTeachCase.TeachCaseTimeIn].ToString().Trim(); //案例入库时间(字段类型:char,字段长度:6,是否可空:True)
 objTeachCaseEN.WorkUnit = objRow[conTeachCase.WorkUnit] == DBNull.Value ? null : objRow[conTeachCase.WorkUnit].ToString().Trim(); //工作单位(字段类型:varchar,字段长度:100,是否可空:True)
 objTeachCaseEN.CDID = objRow[conTeachCase.CDID] == DBNull.Value ? null : objRow[conTeachCase.CDID].ToString().Trim(); //光盘编号(字段类型:varchar,字段长度:50,是否可空:True)
 objTeachCaseEN.BrowseCount = objRow[conTeachCase.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conTeachCase.BrowseCount].ToString().Trim()); //浏览次数(字段类型:int,字段长度:4,是否可空:True)
 objTeachCaseEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conTeachCase.IsVisible].ToString().Trim()); //是否显示(字段类型:bit,字段长度:1,是否可空:True)
 objTeachCaseEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[conTeachCase.IsDualVideo].ToString().Trim()); //是否双视频(字段类型:bit,字段长度:1,是否可空:False)
 objTeachCaseEN.IdXzCollege = objRow[conTeachCase.IdXzCollege] == DBNull.Value ? null : objRow[conTeachCase.IdXzCollege].ToString().Trim(); //学院流水号(字段类型:char,字段长度:4,是否可空:True)
 objTeachCaseEN.RecommendedDegreeId = objRow[conTeachCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id(字段类型:char,字段长度:2,是否可空:False)
 objTeachCaseEN.ftpFileType = objRow[conTeachCase.ftpFileType] == DBNull.Value ? null : objRow[conTeachCase.ftpFileType].ToString().Trim(); //ftp文件类型(字段类型:varchar,字段长度:30,是否可空:True)
 objTeachCaseEN.VideoUrl = objRow[conTeachCase.VideoUrl] == DBNull.Value ? null : objRow[conTeachCase.VideoUrl].ToString().Trim(); //视频Url(字段类型:varchar,字段长度:1000,是否可空:True)
 objTeachCaseEN.VideoPath = objRow[conTeachCase.VideoPath] == DBNull.Value ? null : objRow[conTeachCase.VideoPath].ToString().Trim(); //视频目录(字段类型:varchar,字段长度:1000,是否可空:True)
 objTeachCaseEN.ResErrMsg = objRow[conTeachCase.ResErrMsg] == DBNull.Value ? null : objRow[conTeachCase.ResErrMsg].ToString().Trim(); //资源错误信息(字段类型:varchar,字段长度:30,是否可空:True)
 objTeachCaseEN.UpdDate = objRow[conTeachCase.UpdDate] == DBNull.Value ? null : objRow[conTeachCase.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objTeachCaseEN.UpdUserId = objRow[conTeachCase.UpdUserId] == DBNull.Value ? null : objRow[conTeachCase.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:True)
 objTeachCaseEN.Memo = objRow[conTeachCase.Memo] == DBNull.Value ? null : objRow[conTeachCase.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsTeachCaseDA: GetObjByIdTeachCase)", objException.Message));
}
return objTeachCaseEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsTeachCaseEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsTeachCaseDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeachCaseDA.GetSpecSQLObj();
strSQL = "Select * from TeachCase where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsTeachCaseEN objTeachCaseEN = new clsTeachCaseEN()
{
IdTeachCase = objRow[conTeachCase.IdTeachCase].ToString().Trim(), //案例流水号
TeachCaseID = objRow[conTeachCase.TeachCaseID].ToString().Trim(), //案例ID
TeachCaseName = objRow[conTeachCase.TeachCaseName].ToString().Trim(), //案例名称
TeachCaseExecutor = objRow[conTeachCase.TeachCaseExecutor] == DBNull.Value ? null : objRow[conTeachCase.TeachCaseExecutor].ToString().Trim(), //案例执教者
TeachCaseTheme = objRow[conTeachCase.TeachCaseTheme] == DBNull.Value ? null : objRow[conTeachCase.TeachCaseTheme].ToString().Trim(), //案例主题词
TeachCaseTeachDate = objRow[conTeachCase.TeachCaseTeachDate] == DBNull.Value ? null : objRow[conTeachCase.TeachCaseTeachDate].ToString().Trim(), //案例授课日期
TeachCaseBG = objRow[conTeachCase.TeachCaseBG] == DBNull.Value ? null : objRow[conTeachCase.TeachCaseBG].ToString().Trim(), //案例背景资料
IdTeachSkill = objRow[conTeachCase.IdTeachSkill].ToString().Trim(), //教学技能流水号
IdDiscipline = objRow[conTeachCase.IdDiscipline].ToString().Trim(), //学科流水号
IdStudyLevel = objRow[conTeachCase.IdStudyLevel].ToString().Trim(), //学段流水号
TeachCaseDateIn = objRow[conTeachCase.TeachCaseDateIn] == DBNull.Value ? null : objRow[conTeachCase.TeachCaseDateIn].ToString().Trim(), //案例入库日期
IdTeachingPlan = objRow[conTeachCase.IdTeachingPlan] == DBNull.Value ? null : objRow[conTeachCase.IdTeachingPlan].ToString().Trim(), //教案流水号
TeachCaseTimeIn = objRow[conTeachCase.TeachCaseTimeIn] == DBNull.Value ? null : objRow[conTeachCase.TeachCaseTimeIn].ToString().Trim(), //案例入库时间
WorkUnit = objRow[conTeachCase.WorkUnit] == DBNull.Value ? null : objRow[conTeachCase.WorkUnit].ToString().Trim(), //工作单位
CDID = objRow[conTeachCase.CDID] == DBNull.Value ? null : objRow[conTeachCase.CDID].ToString().Trim(), //光盘编号
BrowseCount = objRow[conTeachCase.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conTeachCase.BrowseCount].ToString().Trim()), //浏览次数
IsVisible = TransNullToBool(objRow[conTeachCase.IsVisible].ToString().Trim()), //是否显示
IsDualVideo = TransNullToBool(objRow[conTeachCase.IsDualVideo].ToString().Trim()), //是否双视频
IdXzCollege = objRow[conTeachCase.IdXzCollege] == DBNull.Value ? null : objRow[conTeachCase.IdXzCollege].ToString().Trim(), //学院流水号
RecommendedDegreeId = objRow[conTeachCase.RecommendedDegreeId].ToString().Trim(), //推荐度Id
ftpFileType = objRow[conTeachCase.ftpFileType] == DBNull.Value ? null : objRow[conTeachCase.ftpFileType].ToString().Trim(), //ftp文件类型
VideoUrl = objRow[conTeachCase.VideoUrl] == DBNull.Value ? null : objRow[conTeachCase.VideoUrl].ToString().Trim(), //视频Url
VideoPath = objRow[conTeachCase.VideoPath] == DBNull.Value ? null : objRow[conTeachCase.VideoPath].ToString().Trim(), //视频目录
ResErrMsg = objRow[conTeachCase.ResErrMsg] == DBNull.Value ? null : objRow[conTeachCase.ResErrMsg].ToString().Trim(), //资源错误信息
UpdDate = objRow[conTeachCase.UpdDate] == DBNull.Value ? null : objRow[conTeachCase.UpdDate].ToString().Trim(), //修改日期
UpdUserId = objRow[conTeachCase.UpdUserId] == DBNull.Value ? null : objRow[conTeachCase.UpdUserId].ToString().Trim(), //修改用户Id
Memo = objRow[conTeachCase.Memo] == DBNull.Value ? null : objRow[conTeachCase.Memo].ToString().Trim() //备注
};
objTeachCaseEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objTeachCaseEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsTeachCaseDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsTeachCaseEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsTeachCaseEN objTeachCaseEN = new clsTeachCaseEN();
try
{
objTeachCaseEN.IdTeachCase = objRow[conTeachCase.IdTeachCase].ToString().Trim(); //案例流水号
objTeachCaseEN.TeachCaseID = objRow[conTeachCase.TeachCaseID].ToString().Trim(); //案例ID
objTeachCaseEN.TeachCaseName = objRow[conTeachCase.TeachCaseName].ToString().Trim(); //案例名称
objTeachCaseEN.TeachCaseExecutor = objRow[conTeachCase.TeachCaseExecutor] == DBNull.Value ? null : objRow[conTeachCase.TeachCaseExecutor].ToString().Trim(); //案例执教者
objTeachCaseEN.TeachCaseTheme = objRow[conTeachCase.TeachCaseTheme] == DBNull.Value ? null : objRow[conTeachCase.TeachCaseTheme].ToString().Trim(); //案例主题词
objTeachCaseEN.TeachCaseTeachDate = objRow[conTeachCase.TeachCaseTeachDate] == DBNull.Value ? null : objRow[conTeachCase.TeachCaseTeachDate].ToString().Trim(); //案例授课日期
objTeachCaseEN.TeachCaseBG = objRow[conTeachCase.TeachCaseBG] == DBNull.Value ? null : objRow[conTeachCase.TeachCaseBG].ToString().Trim(); //案例背景资料
objTeachCaseEN.IdTeachSkill = objRow[conTeachCase.IdTeachSkill].ToString().Trim(); //教学技能流水号
objTeachCaseEN.IdDiscipline = objRow[conTeachCase.IdDiscipline].ToString().Trim(); //学科流水号
objTeachCaseEN.IdStudyLevel = objRow[conTeachCase.IdStudyLevel].ToString().Trim(); //学段流水号
objTeachCaseEN.TeachCaseDateIn = objRow[conTeachCase.TeachCaseDateIn] == DBNull.Value ? null : objRow[conTeachCase.TeachCaseDateIn].ToString().Trim(); //案例入库日期
objTeachCaseEN.IdTeachingPlan = objRow[conTeachCase.IdTeachingPlan] == DBNull.Value ? null : objRow[conTeachCase.IdTeachingPlan].ToString().Trim(); //教案流水号
objTeachCaseEN.TeachCaseTimeIn = objRow[conTeachCase.TeachCaseTimeIn] == DBNull.Value ? null : objRow[conTeachCase.TeachCaseTimeIn].ToString().Trim(); //案例入库时间
objTeachCaseEN.WorkUnit = objRow[conTeachCase.WorkUnit] == DBNull.Value ? null : objRow[conTeachCase.WorkUnit].ToString().Trim(); //工作单位
objTeachCaseEN.CDID = objRow[conTeachCase.CDID] == DBNull.Value ? null : objRow[conTeachCase.CDID].ToString().Trim(); //光盘编号
objTeachCaseEN.BrowseCount = objRow[conTeachCase.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conTeachCase.BrowseCount].ToString().Trim()); //浏览次数
objTeachCaseEN.IsVisible = TransNullToBool(objRow[conTeachCase.IsVisible].ToString().Trim()); //是否显示
objTeachCaseEN.IsDualVideo = TransNullToBool(objRow[conTeachCase.IsDualVideo].ToString().Trim()); //是否双视频
objTeachCaseEN.IdXzCollege = objRow[conTeachCase.IdXzCollege] == DBNull.Value ? null : objRow[conTeachCase.IdXzCollege].ToString().Trim(); //学院流水号
objTeachCaseEN.RecommendedDegreeId = objRow[conTeachCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objTeachCaseEN.ftpFileType = objRow[conTeachCase.ftpFileType] == DBNull.Value ? null : objRow[conTeachCase.ftpFileType].ToString().Trim(); //ftp文件类型
objTeachCaseEN.VideoUrl = objRow[conTeachCase.VideoUrl] == DBNull.Value ? null : objRow[conTeachCase.VideoUrl].ToString().Trim(); //视频Url
objTeachCaseEN.VideoPath = objRow[conTeachCase.VideoPath] == DBNull.Value ? null : objRow[conTeachCase.VideoPath].ToString().Trim(); //视频目录
objTeachCaseEN.ResErrMsg = objRow[conTeachCase.ResErrMsg] == DBNull.Value ? null : objRow[conTeachCase.ResErrMsg].ToString().Trim(); //资源错误信息
objTeachCaseEN.UpdDate = objRow[conTeachCase.UpdDate] == DBNull.Value ? null : objRow[conTeachCase.UpdDate].ToString().Trim(); //修改日期
objTeachCaseEN.UpdUserId = objRow[conTeachCase.UpdUserId] == DBNull.Value ? null : objRow[conTeachCase.UpdUserId].ToString().Trim(); //修改用户Id
objTeachCaseEN.Memo = objRow[conTeachCase.Memo] == DBNull.Value ? null : objRow[conTeachCase.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsTeachCaseDA: GetObjByDataRowTeachCase)", objException.Message));
}
objTeachCaseEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objTeachCaseEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsTeachCaseEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsTeachCaseEN objTeachCaseEN = new clsTeachCaseEN();
try
{
objTeachCaseEN.IdTeachCase = objRow[conTeachCase.IdTeachCase].ToString().Trim(); //案例流水号
objTeachCaseEN.TeachCaseID = objRow[conTeachCase.TeachCaseID].ToString().Trim(); //案例ID
objTeachCaseEN.TeachCaseName = objRow[conTeachCase.TeachCaseName].ToString().Trim(); //案例名称
objTeachCaseEN.TeachCaseExecutor = objRow[conTeachCase.TeachCaseExecutor] == DBNull.Value ? null : objRow[conTeachCase.TeachCaseExecutor].ToString().Trim(); //案例执教者
objTeachCaseEN.TeachCaseTheme = objRow[conTeachCase.TeachCaseTheme] == DBNull.Value ? null : objRow[conTeachCase.TeachCaseTheme].ToString().Trim(); //案例主题词
objTeachCaseEN.TeachCaseTeachDate = objRow[conTeachCase.TeachCaseTeachDate] == DBNull.Value ? null : objRow[conTeachCase.TeachCaseTeachDate].ToString().Trim(); //案例授课日期
objTeachCaseEN.TeachCaseBG = objRow[conTeachCase.TeachCaseBG] == DBNull.Value ? null : objRow[conTeachCase.TeachCaseBG].ToString().Trim(); //案例背景资料
objTeachCaseEN.IdTeachSkill = objRow[conTeachCase.IdTeachSkill].ToString().Trim(); //教学技能流水号
objTeachCaseEN.IdDiscipline = objRow[conTeachCase.IdDiscipline].ToString().Trim(); //学科流水号
objTeachCaseEN.IdStudyLevel = objRow[conTeachCase.IdStudyLevel].ToString().Trim(); //学段流水号
objTeachCaseEN.TeachCaseDateIn = objRow[conTeachCase.TeachCaseDateIn] == DBNull.Value ? null : objRow[conTeachCase.TeachCaseDateIn].ToString().Trim(); //案例入库日期
objTeachCaseEN.IdTeachingPlan = objRow[conTeachCase.IdTeachingPlan] == DBNull.Value ? null : objRow[conTeachCase.IdTeachingPlan].ToString().Trim(); //教案流水号
objTeachCaseEN.TeachCaseTimeIn = objRow[conTeachCase.TeachCaseTimeIn] == DBNull.Value ? null : objRow[conTeachCase.TeachCaseTimeIn].ToString().Trim(); //案例入库时间
objTeachCaseEN.WorkUnit = objRow[conTeachCase.WorkUnit] == DBNull.Value ? null : objRow[conTeachCase.WorkUnit].ToString().Trim(); //工作单位
objTeachCaseEN.CDID = objRow[conTeachCase.CDID] == DBNull.Value ? null : objRow[conTeachCase.CDID].ToString().Trim(); //光盘编号
objTeachCaseEN.BrowseCount = objRow[conTeachCase.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conTeachCase.BrowseCount].ToString().Trim()); //浏览次数
objTeachCaseEN.IsVisible = TransNullToBool(objRow[conTeachCase.IsVisible].ToString().Trim()); //是否显示
objTeachCaseEN.IsDualVideo = TransNullToBool(objRow[conTeachCase.IsDualVideo].ToString().Trim()); //是否双视频
objTeachCaseEN.IdXzCollege = objRow[conTeachCase.IdXzCollege] == DBNull.Value ? null : objRow[conTeachCase.IdXzCollege].ToString().Trim(); //学院流水号
objTeachCaseEN.RecommendedDegreeId = objRow[conTeachCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objTeachCaseEN.ftpFileType = objRow[conTeachCase.ftpFileType] == DBNull.Value ? null : objRow[conTeachCase.ftpFileType].ToString().Trim(); //ftp文件类型
objTeachCaseEN.VideoUrl = objRow[conTeachCase.VideoUrl] == DBNull.Value ? null : objRow[conTeachCase.VideoUrl].ToString().Trim(); //视频Url
objTeachCaseEN.VideoPath = objRow[conTeachCase.VideoPath] == DBNull.Value ? null : objRow[conTeachCase.VideoPath].ToString().Trim(); //视频目录
objTeachCaseEN.ResErrMsg = objRow[conTeachCase.ResErrMsg] == DBNull.Value ? null : objRow[conTeachCase.ResErrMsg].ToString().Trim(); //资源错误信息
objTeachCaseEN.UpdDate = objRow[conTeachCase.UpdDate] == DBNull.Value ? null : objRow[conTeachCase.UpdDate].ToString().Trim(); //修改日期
objTeachCaseEN.UpdUserId = objRow[conTeachCase.UpdUserId] == DBNull.Value ? null : objRow[conTeachCase.UpdUserId].ToString().Trim(); //修改用户Id
objTeachCaseEN.Memo = objRow[conTeachCase.Memo] == DBNull.Value ? null : objRow[conTeachCase.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsTeachCaseDA: GetObjByDataRow)", objException.Message));
}
objTeachCaseEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objTeachCaseEN;
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
objSQL = clsTeachCaseDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsTeachCaseEN._CurrTabName, conTeachCase.IdTeachCase, 8, "");
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
objSQL = clsTeachCaseDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsTeachCaseEN._CurrTabName, conTeachCase.IdTeachCase, 8, strPrefix);
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
 objSQL = clsTeachCaseDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select IdTeachCase from TeachCase where " + strCondition;
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
 objSQL = clsTeachCaseDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select IdTeachCase from TeachCase where " + strCondition;
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
 /// <param name = "strIdTeachCase">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strIdTeachCase)
{
CheckPrimaryKey(strIdTeachCase);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeachCaseDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("TeachCase", "IdTeachCase = " + "'"+ strIdTeachCase+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsTeachCaseDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeachCaseDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("TeachCase", strCondition))
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
objSQL = clsTeachCaseDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("TeachCase");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsTeachCaseEN objTeachCaseEN)
 {
 objTeachCaseEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objTeachCaseEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objTeachCaseEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeachCaseDA.GetSpecSQLObj();
strSQL = "Select * from TeachCase where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "TeachCase");
objRow = objDS.Tables["TeachCase"].NewRow();
objRow[conTeachCase.IdTeachCase] = objTeachCaseEN.IdTeachCase; //案例流水号
objRow[conTeachCase.TeachCaseID] = objTeachCaseEN.TeachCaseID; //案例ID
objRow[conTeachCase.TeachCaseName] = objTeachCaseEN.TeachCaseName; //案例名称
 if (objTeachCaseEN.TeachCaseExecutor !=  "")
 {
objRow[conTeachCase.TeachCaseExecutor] = objTeachCaseEN.TeachCaseExecutor; //案例执教者
 }
 if (objTeachCaseEN.TeachCaseTheme !=  "")
 {
objRow[conTeachCase.TeachCaseTheme] = objTeachCaseEN.TeachCaseTheme; //案例主题词
 }
 if (objTeachCaseEN.TeachCaseTeachDate !=  "")
 {
objRow[conTeachCase.TeachCaseTeachDate] = objTeachCaseEN.TeachCaseTeachDate; //案例授课日期
 }
 if (objTeachCaseEN.TeachCaseBG !=  "")
 {
objRow[conTeachCase.TeachCaseBG] = objTeachCaseEN.TeachCaseBG; //案例背景资料
 }
objRow[conTeachCase.IdTeachSkill] = objTeachCaseEN.IdTeachSkill; //教学技能流水号
objRow[conTeachCase.IdDiscipline] = objTeachCaseEN.IdDiscipline; //学科流水号
objRow[conTeachCase.IdStudyLevel] = objTeachCaseEN.IdStudyLevel; //学段流水号
 if (objTeachCaseEN.TeachCaseDateIn !=  "")
 {
objRow[conTeachCase.TeachCaseDateIn] = objTeachCaseEN.TeachCaseDateIn; //案例入库日期
 }
 if (objTeachCaseEN.IdTeachingPlan !=  "")
 {
objRow[conTeachCase.IdTeachingPlan] = objTeachCaseEN.IdTeachingPlan; //教案流水号
 }
 if (objTeachCaseEN.TeachCaseTimeIn !=  "")
 {
objRow[conTeachCase.TeachCaseTimeIn] = objTeachCaseEN.TeachCaseTimeIn; //案例入库时间
 }
 if (objTeachCaseEN.WorkUnit !=  "")
 {
objRow[conTeachCase.WorkUnit] = objTeachCaseEN.WorkUnit; //工作单位
 }
 if (objTeachCaseEN.CDID !=  "")
 {
objRow[conTeachCase.CDID] = objTeachCaseEN.CDID; //光盘编号
 }
objRow[conTeachCase.BrowseCount] = objTeachCaseEN.BrowseCount; //浏览次数
objRow[conTeachCase.IsVisible] = objTeachCaseEN.IsVisible; //是否显示
objRow[conTeachCase.IsDualVideo] = objTeachCaseEN.IsDualVideo; //是否双视频
 if (objTeachCaseEN.IdXzCollege !=  "")
 {
objRow[conTeachCase.IdXzCollege] = objTeachCaseEN.IdXzCollege; //学院流水号
 }
objRow[conTeachCase.RecommendedDegreeId] = objTeachCaseEN.RecommendedDegreeId; //推荐度Id
 if (objTeachCaseEN.ftpFileType !=  "")
 {
objRow[conTeachCase.ftpFileType] = objTeachCaseEN.ftpFileType; //ftp文件类型
 }
 if (objTeachCaseEN.VideoUrl !=  "")
 {
objRow[conTeachCase.VideoUrl] = objTeachCaseEN.VideoUrl; //视频Url
 }
 if (objTeachCaseEN.VideoPath !=  "")
 {
objRow[conTeachCase.VideoPath] = objTeachCaseEN.VideoPath; //视频目录
 }
 if (objTeachCaseEN.ResErrMsg !=  "")
 {
objRow[conTeachCase.ResErrMsg] = objTeachCaseEN.ResErrMsg; //资源错误信息
 }
 if (objTeachCaseEN.UpdDate !=  "")
 {
objRow[conTeachCase.UpdDate] = objTeachCaseEN.UpdDate; //修改日期
 }
 if (objTeachCaseEN.UpdUserId !=  "")
 {
objRow[conTeachCase.UpdUserId] = objTeachCaseEN.UpdUserId; //修改用户Id
 }
 if (objTeachCaseEN.Memo !=  "")
 {
objRow[conTeachCase.Memo] = objTeachCaseEN.Memo; //备注
 }
objDS.Tables[clsTeachCaseEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsTeachCaseEN._CurrTabName);
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
 /// <param name = "objTeachCaseEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsTeachCaseEN objTeachCaseEN)
{
 objTeachCaseEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objTeachCaseEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objTeachCaseEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objTeachCaseEN.IdTeachCase !=  null)
 {
 arrFieldListForInsert.Add(conTeachCase.IdTeachCase);
 var strIdTeachCase = objTeachCaseEN.IdTeachCase.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdTeachCase + "'");
 }
 
 if (objTeachCaseEN.TeachCaseID !=  null)
 {
 arrFieldListForInsert.Add(conTeachCase.TeachCaseID);
 var strTeachCaseID = objTeachCaseEN.TeachCaseID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTeachCaseID + "'");
 }
 
 if (objTeachCaseEN.TeachCaseName !=  null)
 {
 arrFieldListForInsert.Add(conTeachCase.TeachCaseName);
 var strTeachCaseName = objTeachCaseEN.TeachCaseName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTeachCaseName + "'");
 }
 
 if (objTeachCaseEN.TeachCaseExecutor !=  null)
 {
 arrFieldListForInsert.Add(conTeachCase.TeachCaseExecutor);
 var strTeachCaseExecutor = objTeachCaseEN.TeachCaseExecutor.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTeachCaseExecutor + "'");
 }
 
 if (objTeachCaseEN.TeachCaseTheme !=  null)
 {
 arrFieldListForInsert.Add(conTeachCase.TeachCaseTheme);
 var strTeachCaseTheme = objTeachCaseEN.TeachCaseTheme.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTeachCaseTheme + "'");
 }
 
 if (objTeachCaseEN.TeachCaseTeachDate !=  null)
 {
 arrFieldListForInsert.Add(conTeachCase.TeachCaseTeachDate);
 var strTeachCaseTeachDate = objTeachCaseEN.TeachCaseTeachDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTeachCaseTeachDate + "'");
 }
 
 if (objTeachCaseEN.TeachCaseBG !=  null)
 {
 arrFieldListForInsert.Add(conTeachCase.TeachCaseBG);
 var strTeachCaseBG = objTeachCaseEN.TeachCaseBG.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTeachCaseBG + "'");
 }
 
 if (objTeachCaseEN.IdTeachSkill  ==  "")
 {
 objTeachCaseEN.IdTeachSkill = null;
 }
 if (objTeachCaseEN.IdTeachSkill !=  null)
 {
 arrFieldListForInsert.Add(conTeachCase.IdTeachSkill);
 var strIdTeachSkill = objTeachCaseEN.IdTeachSkill.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdTeachSkill + "'");
 }
 
 if (objTeachCaseEN.IdDiscipline  ==  "")
 {
 objTeachCaseEN.IdDiscipline = null;
 }
 if (objTeachCaseEN.IdDiscipline !=  null)
 {
 arrFieldListForInsert.Add(conTeachCase.IdDiscipline);
 var strIdDiscipline = objTeachCaseEN.IdDiscipline.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdDiscipline + "'");
 }
 
 if (objTeachCaseEN.IdStudyLevel  ==  "")
 {
 objTeachCaseEN.IdStudyLevel = null;
 }
 if (objTeachCaseEN.IdStudyLevel !=  null)
 {
 arrFieldListForInsert.Add(conTeachCase.IdStudyLevel);
 var strIdStudyLevel = objTeachCaseEN.IdStudyLevel.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdStudyLevel + "'");
 }
 
 if (objTeachCaseEN.TeachCaseDateIn !=  null)
 {
 arrFieldListForInsert.Add(conTeachCase.TeachCaseDateIn);
 var strTeachCaseDateIn = objTeachCaseEN.TeachCaseDateIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTeachCaseDateIn + "'");
 }
 
 if (objTeachCaseEN.IdTeachingPlan  ==  "")
 {
 objTeachCaseEN.IdTeachingPlan = null;
 }
 if (objTeachCaseEN.IdTeachingPlan !=  null)
 {
 arrFieldListForInsert.Add(conTeachCase.IdTeachingPlan);
 var strIdTeachingPlan = objTeachCaseEN.IdTeachingPlan.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdTeachingPlan + "'");
 }
 
 if (objTeachCaseEN.TeachCaseTimeIn !=  null)
 {
 arrFieldListForInsert.Add(conTeachCase.TeachCaseTimeIn);
 var strTeachCaseTimeIn = objTeachCaseEN.TeachCaseTimeIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTeachCaseTimeIn + "'");
 }
 
 if (objTeachCaseEN.WorkUnit !=  null)
 {
 arrFieldListForInsert.Add(conTeachCase.WorkUnit);
 var strWorkUnit = objTeachCaseEN.WorkUnit.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strWorkUnit + "'");
 }
 
 if (objTeachCaseEN.CDID !=  null)
 {
 arrFieldListForInsert.Add(conTeachCase.CDID);
 var strCDID = objTeachCaseEN.CDID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCDID + "'");
 }
 
 if (objTeachCaseEN.BrowseCount !=  null)
 {
 arrFieldListForInsert.Add(conTeachCase.BrowseCount);
 arrValueListForInsert.Add(objTeachCaseEN.BrowseCount.ToString());
 }
 
 arrFieldListForInsert.Add(conTeachCase.IsVisible);
 arrValueListForInsert.Add("'" + (objTeachCaseEN.IsVisible  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conTeachCase.IsDualVideo);
 arrValueListForInsert.Add("'" + (objTeachCaseEN.IsDualVideo  ==  false ? "0" : "1") + "'");
 
 if (objTeachCaseEN.IdXzCollege !=  null)
 {
 arrFieldListForInsert.Add(conTeachCase.IdXzCollege);
 var strIdXzCollege = objTeachCaseEN.IdXzCollege.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdXzCollege + "'");
 }
 
 if (objTeachCaseEN.RecommendedDegreeId !=  null)
 {
 arrFieldListForInsert.Add(conTeachCase.RecommendedDegreeId);
 var strRecommendedDegreeId = objTeachCaseEN.RecommendedDegreeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRecommendedDegreeId + "'");
 }
 
 if (objTeachCaseEN.ftpFileType !=  null)
 {
 arrFieldListForInsert.Add(conTeachCase.ftpFileType);
 var strftpFileType = objTeachCaseEN.ftpFileType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strftpFileType + "'");
 }
 
 if (objTeachCaseEN.VideoUrl !=  null)
 {
 arrFieldListForInsert.Add(conTeachCase.VideoUrl);
 var strVideoUrl = objTeachCaseEN.VideoUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVideoUrl + "'");
 }
 
 if (objTeachCaseEN.VideoPath !=  null)
 {
 arrFieldListForInsert.Add(conTeachCase.VideoPath);
 var strVideoPath = objTeachCaseEN.VideoPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVideoPath + "'");
 }
 
 if (objTeachCaseEN.ResErrMsg !=  null)
 {
 arrFieldListForInsert.Add(conTeachCase.ResErrMsg);
 var strResErrMsg = objTeachCaseEN.ResErrMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strResErrMsg + "'");
 }
 
 if (objTeachCaseEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conTeachCase.UpdDate);
 var strUpdDate = objTeachCaseEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objTeachCaseEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(conTeachCase.UpdUserId);
 var strUpdUserId = objTeachCaseEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objTeachCaseEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conTeachCase.Memo);
 var strMemo = objTeachCaseEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into TeachCase");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeachCaseDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objTeachCaseEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsTeachCaseEN objTeachCaseEN)
{
 objTeachCaseEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objTeachCaseEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objTeachCaseEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objTeachCaseEN.IdTeachCase !=  null)
 {
 arrFieldListForInsert.Add(conTeachCase.IdTeachCase);
 var strIdTeachCase = objTeachCaseEN.IdTeachCase.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdTeachCase + "'");
 }
 
 if (objTeachCaseEN.TeachCaseID !=  null)
 {
 arrFieldListForInsert.Add(conTeachCase.TeachCaseID);
 var strTeachCaseID = objTeachCaseEN.TeachCaseID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTeachCaseID + "'");
 }
 
 if (objTeachCaseEN.TeachCaseName !=  null)
 {
 arrFieldListForInsert.Add(conTeachCase.TeachCaseName);
 var strTeachCaseName = objTeachCaseEN.TeachCaseName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTeachCaseName + "'");
 }
 
 if (objTeachCaseEN.TeachCaseExecutor !=  null)
 {
 arrFieldListForInsert.Add(conTeachCase.TeachCaseExecutor);
 var strTeachCaseExecutor = objTeachCaseEN.TeachCaseExecutor.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTeachCaseExecutor + "'");
 }
 
 if (objTeachCaseEN.TeachCaseTheme !=  null)
 {
 arrFieldListForInsert.Add(conTeachCase.TeachCaseTheme);
 var strTeachCaseTheme = objTeachCaseEN.TeachCaseTheme.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTeachCaseTheme + "'");
 }
 
 if (objTeachCaseEN.TeachCaseTeachDate !=  null)
 {
 arrFieldListForInsert.Add(conTeachCase.TeachCaseTeachDate);
 var strTeachCaseTeachDate = objTeachCaseEN.TeachCaseTeachDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTeachCaseTeachDate + "'");
 }
 
 if (objTeachCaseEN.TeachCaseBG !=  null)
 {
 arrFieldListForInsert.Add(conTeachCase.TeachCaseBG);
 var strTeachCaseBG = objTeachCaseEN.TeachCaseBG.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTeachCaseBG + "'");
 }
 
 if (objTeachCaseEN.IdTeachSkill  ==  "")
 {
 objTeachCaseEN.IdTeachSkill = null;
 }
 if (objTeachCaseEN.IdTeachSkill !=  null)
 {
 arrFieldListForInsert.Add(conTeachCase.IdTeachSkill);
 var strIdTeachSkill = objTeachCaseEN.IdTeachSkill.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdTeachSkill + "'");
 }
 
 if (objTeachCaseEN.IdDiscipline  ==  "")
 {
 objTeachCaseEN.IdDiscipline = null;
 }
 if (objTeachCaseEN.IdDiscipline !=  null)
 {
 arrFieldListForInsert.Add(conTeachCase.IdDiscipline);
 var strIdDiscipline = objTeachCaseEN.IdDiscipline.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdDiscipline + "'");
 }
 
 if (objTeachCaseEN.IdStudyLevel  ==  "")
 {
 objTeachCaseEN.IdStudyLevel = null;
 }
 if (objTeachCaseEN.IdStudyLevel !=  null)
 {
 arrFieldListForInsert.Add(conTeachCase.IdStudyLevel);
 var strIdStudyLevel = objTeachCaseEN.IdStudyLevel.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdStudyLevel + "'");
 }
 
 if (objTeachCaseEN.TeachCaseDateIn !=  null)
 {
 arrFieldListForInsert.Add(conTeachCase.TeachCaseDateIn);
 var strTeachCaseDateIn = objTeachCaseEN.TeachCaseDateIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTeachCaseDateIn + "'");
 }
 
 if (objTeachCaseEN.IdTeachingPlan  ==  "")
 {
 objTeachCaseEN.IdTeachingPlan = null;
 }
 if (objTeachCaseEN.IdTeachingPlan !=  null)
 {
 arrFieldListForInsert.Add(conTeachCase.IdTeachingPlan);
 var strIdTeachingPlan = objTeachCaseEN.IdTeachingPlan.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdTeachingPlan + "'");
 }
 
 if (objTeachCaseEN.TeachCaseTimeIn !=  null)
 {
 arrFieldListForInsert.Add(conTeachCase.TeachCaseTimeIn);
 var strTeachCaseTimeIn = objTeachCaseEN.TeachCaseTimeIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTeachCaseTimeIn + "'");
 }
 
 if (objTeachCaseEN.WorkUnit !=  null)
 {
 arrFieldListForInsert.Add(conTeachCase.WorkUnit);
 var strWorkUnit = objTeachCaseEN.WorkUnit.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strWorkUnit + "'");
 }
 
 if (objTeachCaseEN.CDID !=  null)
 {
 arrFieldListForInsert.Add(conTeachCase.CDID);
 var strCDID = objTeachCaseEN.CDID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCDID + "'");
 }
 
 if (objTeachCaseEN.BrowseCount !=  null)
 {
 arrFieldListForInsert.Add(conTeachCase.BrowseCount);
 arrValueListForInsert.Add(objTeachCaseEN.BrowseCount.ToString());
 }
 
 arrFieldListForInsert.Add(conTeachCase.IsVisible);
 arrValueListForInsert.Add("'" + (objTeachCaseEN.IsVisible  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conTeachCase.IsDualVideo);
 arrValueListForInsert.Add("'" + (objTeachCaseEN.IsDualVideo  ==  false ? "0" : "1") + "'");
 
 if (objTeachCaseEN.IdXzCollege !=  null)
 {
 arrFieldListForInsert.Add(conTeachCase.IdXzCollege);
 var strIdXzCollege = objTeachCaseEN.IdXzCollege.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdXzCollege + "'");
 }
 
 if (objTeachCaseEN.RecommendedDegreeId !=  null)
 {
 arrFieldListForInsert.Add(conTeachCase.RecommendedDegreeId);
 var strRecommendedDegreeId = objTeachCaseEN.RecommendedDegreeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRecommendedDegreeId + "'");
 }
 
 if (objTeachCaseEN.ftpFileType !=  null)
 {
 arrFieldListForInsert.Add(conTeachCase.ftpFileType);
 var strftpFileType = objTeachCaseEN.ftpFileType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strftpFileType + "'");
 }
 
 if (objTeachCaseEN.VideoUrl !=  null)
 {
 arrFieldListForInsert.Add(conTeachCase.VideoUrl);
 var strVideoUrl = objTeachCaseEN.VideoUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVideoUrl + "'");
 }
 
 if (objTeachCaseEN.VideoPath !=  null)
 {
 arrFieldListForInsert.Add(conTeachCase.VideoPath);
 var strVideoPath = objTeachCaseEN.VideoPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVideoPath + "'");
 }
 
 if (objTeachCaseEN.ResErrMsg !=  null)
 {
 arrFieldListForInsert.Add(conTeachCase.ResErrMsg);
 var strResErrMsg = objTeachCaseEN.ResErrMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strResErrMsg + "'");
 }
 
 if (objTeachCaseEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conTeachCase.UpdDate);
 var strUpdDate = objTeachCaseEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objTeachCaseEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(conTeachCase.UpdUserId);
 var strUpdUserId = objTeachCaseEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objTeachCaseEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conTeachCase.Memo);
 var strMemo = objTeachCaseEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into TeachCase");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeachCaseDA.GetSpecSQLObj();
 objSQL.ExecSql(strSQL.ToString());
return objTeachCaseEN.IdTeachCase;
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objTeachCaseEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsTeachCaseEN objTeachCaseEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objTeachCaseEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objTeachCaseEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objTeachCaseEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objTeachCaseEN.IdTeachCase !=  null)
 {
 arrFieldListForInsert.Add(conTeachCase.IdTeachCase);
 var strIdTeachCase = objTeachCaseEN.IdTeachCase.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdTeachCase + "'");
 }
 
 if (objTeachCaseEN.TeachCaseID !=  null)
 {
 arrFieldListForInsert.Add(conTeachCase.TeachCaseID);
 var strTeachCaseID = objTeachCaseEN.TeachCaseID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTeachCaseID + "'");
 }
 
 if (objTeachCaseEN.TeachCaseName !=  null)
 {
 arrFieldListForInsert.Add(conTeachCase.TeachCaseName);
 var strTeachCaseName = objTeachCaseEN.TeachCaseName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTeachCaseName + "'");
 }
 
 if (objTeachCaseEN.TeachCaseExecutor !=  null)
 {
 arrFieldListForInsert.Add(conTeachCase.TeachCaseExecutor);
 var strTeachCaseExecutor = objTeachCaseEN.TeachCaseExecutor.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTeachCaseExecutor + "'");
 }
 
 if (objTeachCaseEN.TeachCaseTheme !=  null)
 {
 arrFieldListForInsert.Add(conTeachCase.TeachCaseTheme);
 var strTeachCaseTheme = objTeachCaseEN.TeachCaseTheme.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTeachCaseTheme + "'");
 }
 
 if (objTeachCaseEN.TeachCaseTeachDate !=  null)
 {
 arrFieldListForInsert.Add(conTeachCase.TeachCaseTeachDate);
 var strTeachCaseTeachDate = objTeachCaseEN.TeachCaseTeachDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTeachCaseTeachDate + "'");
 }
 
 if (objTeachCaseEN.TeachCaseBG !=  null)
 {
 arrFieldListForInsert.Add(conTeachCase.TeachCaseBG);
 var strTeachCaseBG = objTeachCaseEN.TeachCaseBG.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTeachCaseBG + "'");
 }
 
 if (objTeachCaseEN.IdTeachSkill  ==  "")
 {
 objTeachCaseEN.IdTeachSkill = null;
 }
 if (objTeachCaseEN.IdTeachSkill !=  null)
 {
 arrFieldListForInsert.Add(conTeachCase.IdTeachSkill);
 var strIdTeachSkill = objTeachCaseEN.IdTeachSkill.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdTeachSkill + "'");
 }
 
 if (objTeachCaseEN.IdDiscipline  ==  "")
 {
 objTeachCaseEN.IdDiscipline = null;
 }
 if (objTeachCaseEN.IdDiscipline !=  null)
 {
 arrFieldListForInsert.Add(conTeachCase.IdDiscipline);
 var strIdDiscipline = objTeachCaseEN.IdDiscipline.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdDiscipline + "'");
 }
 
 if (objTeachCaseEN.IdStudyLevel  ==  "")
 {
 objTeachCaseEN.IdStudyLevel = null;
 }
 if (objTeachCaseEN.IdStudyLevel !=  null)
 {
 arrFieldListForInsert.Add(conTeachCase.IdStudyLevel);
 var strIdStudyLevel = objTeachCaseEN.IdStudyLevel.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdStudyLevel + "'");
 }
 
 if (objTeachCaseEN.TeachCaseDateIn !=  null)
 {
 arrFieldListForInsert.Add(conTeachCase.TeachCaseDateIn);
 var strTeachCaseDateIn = objTeachCaseEN.TeachCaseDateIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTeachCaseDateIn + "'");
 }
 
 if (objTeachCaseEN.IdTeachingPlan  ==  "")
 {
 objTeachCaseEN.IdTeachingPlan = null;
 }
 if (objTeachCaseEN.IdTeachingPlan !=  null)
 {
 arrFieldListForInsert.Add(conTeachCase.IdTeachingPlan);
 var strIdTeachingPlan = objTeachCaseEN.IdTeachingPlan.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdTeachingPlan + "'");
 }
 
 if (objTeachCaseEN.TeachCaseTimeIn !=  null)
 {
 arrFieldListForInsert.Add(conTeachCase.TeachCaseTimeIn);
 var strTeachCaseTimeIn = objTeachCaseEN.TeachCaseTimeIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTeachCaseTimeIn + "'");
 }
 
 if (objTeachCaseEN.WorkUnit !=  null)
 {
 arrFieldListForInsert.Add(conTeachCase.WorkUnit);
 var strWorkUnit = objTeachCaseEN.WorkUnit.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strWorkUnit + "'");
 }
 
 if (objTeachCaseEN.CDID !=  null)
 {
 arrFieldListForInsert.Add(conTeachCase.CDID);
 var strCDID = objTeachCaseEN.CDID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCDID + "'");
 }
 
 if (objTeachCaseEN.BrowseCount !=  null)
 {
 arrFieldListForInsert.Add(conTeachCase.BrowseCount);
 arrValueListForInsert.Add(objTeachCaseEN.BrowseCount.ToString());
 }
 
 arrFieldListForInsert.Add(conTeachCase.IsVisible);
 arrValueListForInsert.Add("'" + (objTeachCaseEN.IsVisible  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conTeachCase.IsDualVideo);
 arrValueListForInsert.Add("'" + (objTeachCaseEN.IsDualVideo  ==  false ? "0" : "1") + "'");
 
 if (objTeachCaseEN.IdXzCollege !=  null)
 {
 arrFieldListForInsert.Add(conTeachCase.IdXzCollege);
 var strIdXzCollege = objTeachCaseEN.IdXzCollege.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdXzCollege + "'");
 }
 
 if (objTeachCaseEN.RecommendedDegreeId !=  null)
 {
 arrFieldListForInsert.Add(conTeachCase.RecommendedDegreeId);
 var strRecommendedDegreeId = objTeachCaseEN.RecommendedDegreeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRecommendedDegreeId + "'");
 }
 
 if (objTeachCaseEN.ftpFileType !=  null)
 {
 arrFieldListForInsert.Add(conTeachCase.ftpFileType);
 var strftpFileType = objTeachCaseEN.ftpFileType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strftpFileType + "'");
 }
 
 if (objTeachCaseEN.VideoUrl !=  null)
 {
 arrFieldListForInsert.Add(conTeachCase.VideoUrl);
 var strVideoUrl = objTeachCaseEN.VideoUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVideoUrl + "'");
 }
 
 if (objTeachCaseEN.VideoPath !=  null)
 {
 arrFieldListForInsert.Add(conTeachCase.VideoPath);
 var strVideoPath = objTeachCaseEN.VideoPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVideoPath + "'");
 }
 
 if (objTeachCaseEN.ResErrMsg !=  null)
 {
 arrFieldListForInsert.Add(conTeachCase.ResErrMsg);
 var strResErrMsg = objTeachCaseEN.ResErrMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strResErrMsg + "'");
 }
 
 if (objTeachCaseEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conTeachCase.UpdDate);
 var strUpdDate = objTeachCaseEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objTeachCaseEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(conTeachCase.UpdUserId);
 var strUpdUserId = objTeachCaseEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objTeachCaseEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conTeachCase.Memo);
 var strMemo = objTeachCaseEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into TeachCase");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeachCaseDA.GetSpecSQLObj();
    objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
return objTeachCaseEN.IdTeachCase;
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objTeachCaseEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsTeachCaseEN objTeachCaseEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objTeachCaseEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objTeachCaseEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objTeachCaseEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objTeachCaseEN.IdTeachCase !=  null)
 {
 arrFieldListForInsert.Add(conTeachCase.IdTeachCase);
 var strIdTeachCase = objTeachCaseEN.IdTeachCase.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdTeachCase + "'");
 }
 
 if (objTeachCaseEN.TeachCaseID !=  null)
 {
 arrFieldListForInsert.Add(conTeachCase.TeachCaseID);
 var strTeachCaseID = objTeachCaseEN.TeachCaseID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTeachCaseID + "'");
 }
 
 if (objTeachCaseEN.TeachCaseName !=  null)
 {
 arrFieldListForInsert.Add(conTeachCase.TeachCaseName);
 var strTeachCaseName = objTeachCaseEN.TeachCaseName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTeachCaseName + "'");
 }
 
 if (objTeachCaseEN.TeachCaseExecutor !=  null)
 {
 arrFieldListForInsert.Add(conTeachCase.TeachCaseExecutor);
 var strTeachCaseExecutor = objTeachCaseEN.TeachCaseExecutor.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTeachCaseExecutor + "'");
 }
 
 if (objTeachCaseEN.TeachCaseTheme !=  null)
 {
 arrFieldListForInsert.Add(conTeachCase.TeachCaseTheme);
 var strTeachCaseTheme = objTeachCaseEN.TeachCaseTheme.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTeachCaseTheme + "'");
 }
 
 if (objTeachCaseEN.TeachCaseTeachDate !=  null)
 {
 arrFieldListForInsert.Add(conTeachCase.TeachCaseTeachDate);
 var strTeachCaseTeachDate = objTeachCaseEN.TeachCaseTeachDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTeachCaseTeachDate + "'");
 }
 
 if (objTeachCaseEN.TeachCaseBG !=  null)
 {
 arrFieldListForInsert.Add(conTeachCase.TeachCaseBG);
 var strTeachCaseBG = objTeachCaseEN.TeachCaseBG.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTeachCaseBG + "'");
 }
 
 if (objTeachCaseEN.IdTeachSkill  ==  "")
 {
 objTeachCaseEN.IdTeachSkill = null;
 }
 if (objTeachCaseEN.IdTeachSkill !=  null)
 {
 arrFieldListForInsert.Add(conTeachCase.IdTeachSkill);
 var strIdTeachSkill = objTeachCaseEN.IdTeachSkill.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdTeachSkill + "'");
 }
 
 if (objTeachCaseEN.IdDiscipline  ==  "")
 {
 objTeachCaseEN.IdDiscipline = null;
 }
 if (objTeachCaseEN.IdDiscipline !=  null)
 {
 arrFieldListForInsert.Add(conTeachCase.IdDiscipline);
 var strIdDiscipline = objTeachCaseEN.IdDiscipline.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdDiscipline + "'");
 }
 
 if (objTeachCaseEN.IdStudyLevel  ==  "")
 {
 objTeachCaseEN.IdStudyLevel = null;
 }
 if (objTeachCaseEN.IdStudyLevel !=  null)
 {
 arrFieldListForInsert.Add(conTeachCase.IdStudyLevel);
 var strIdStudyLevel = objTeachCaseEN.IdStudyLevel.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdStudyLevel + "'");
 }
 
 if (objTeachCaseEN.TeachCaseDateIn !=  null)
 {
 arrFieldListForInsert.Add(conTeachCase.TeachCaseDateIn);
 var strTeachCaseDateIn = objTeachCaseEN.TeachCaseDateIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTeachCaseDateIn + "'");
 }
 
 if (objTeachCaseEN.IdTeachingPlan  ==  "")
 {
 objTeachCaseEN.IdTeachingPlan = null;
 }
 if (objTeachCaseEN.IdTeachingPlan !=  null)
 {
 arrFieldListForInsert.Add(conTeachCase.IdTeachingPlan);
 var strIdTeachingPlan = objTeachCaseEN.IdTeachingPlan.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdTeachingPlan + "'");
 }
 
 if (objTeachCaseEN.TeachCaseTimeIn !=  null)
 {
 arrFieldListForInsert.Add(conTeachCase.TeachCaseTimeIn);
 var strTeachCaseTimeIn = objTeachCaseEN.TeachCaseTimeIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTeachCaseTimeIn + "'");
 }
 
 if (objTeachCaseEN.WorkUnit !=  null)
 {
 arrFieldListForInsert.Add(conTeachCase.WorkUnit);
 var strWorkUnit = objTeachCaseEN.WorkUnit.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strWorkUnit + "'");
 }
 
 if (objTeachCaseEN.CDID !=  null)
 {
 arrFieldListForInsert.Add(conTeachCase.CDID);
 var strCDID = objTeachCaseEN.CDID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCDID + "'");
 }
 
 if (objTeachCaseEN.BrowseCount !=  null)
 {
 arrFieldListForInsert.Add(conTeachCase.BrowseCount);
 arrValueListForInsert.Add(objTeachCaseEN.BrowseCount.ToString());
 }
 
 arrFieldListForInsert.Add(conTeachCase.IsVisible);
 arrValueListForInsert.Add("'" + (objTeachCaseEN.IsVisible  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conTeachCase.IsDualVideo);
 arrValueListForInsert.Add("'" + (objTeachCaseEN.IsDualVideo  ==  false ? "0" : "1") + "'");
 
 if (objTeachCaseEN.IdXzCollege !=  null)
 {
 arrFieldListForInsert.Add(conTeachCase.IdXzCollege);
 var strIdXzCollege = objTeachCaseEN.IdXzCollege.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdXzCollege + "'");
 }
 
 if (objTeachCaseEN.RecommendedDegreeId !=  null)
 {
 arrFieldListForInsert.Add(conTeachCase.RecommendedDegreeId);
 var strRecommendedDegreeId = objTeachCaseEN.RecommendedDegreeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRecommendedDegreeId + "'");
 }
 
 if (objTeachCaseEN.ftpFileType !=  null)
 {
 arrFieldListForInsert.Add(conTeachCase.ftpFileType);
 var strftpFileType = objTeachCaseEN.ftpFileType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strftpFileType + "'");
 }
 
 if (objTeachCaseEN.VideoUrl !=  null)
 {
 arrFieldListForInsert.Add(conTeachCase.VideoUrl);
 var strVideoUrl = objTeachCaseEN.VideoUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVideoUrl + "'");
 }
 
 if (objTeachCaseEN.VideoPath !=  null)
 {
 arrFieldListForInsert.Add(conTeachCase.VideoPath);
 var strVideoPath = objTeachCaseEN.VideoPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVideoPath + "'");
 }
 
 if (objTeachCaseEN.ResErrMsg !=  null)
 {
 arrFieldListForInsert.Add(conTeachCase.ResErrMsg);
 var strResErrMsg = objTeachCaseEN.ResErrMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strResErrMsg + "'");
 }
 
 if (objTeachCaseEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conTeachCase.UpdDate);
 var strUpdDate = objTeachCaseEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objTeachCaseEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(conTeachCase.UpdUserId);
 var strUpdUserId = objTeachCaseEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objTeachCaseEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conTeachCase.Memo);
 var strMemo = objTeachCaseEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into TeachCase");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeachCaseDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewTeachCases(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeachCaseDA.GetSpecSQLObj();
strSQL = "Select * from TeachCase where IdTeachCase = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "TeachCase");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
string strIdTeachCase = oRow[conTeachCase.IdTeachCase].ToString().Trim();
if (IsExist(strIdTeachCase))
{
 string strResult = "关键字变量值为:" + string.Format("IdTeachCase = {0}", strIdTeachCase) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsTeachCaseEN._CurrTabName ].NewRow();
objRow[conTeachCase.IdTeachCase] = oRow[conTeachCase.IdTeachCase].ToString().Trim(); //案例流水号
objRow[conTeachCase.TeachCaseID] = oRow[conTeachCase.TeachCaseID].ToString().Trim(); //案例ID
objRow[conTeachCase.TeachCaseName] = oRow[conTeachCase.TeachCaseName].ToString().Trim(); //案例名称
objRow[conTeachCase.TeachCaseExecutor] = oRow[conTeachCase.TeachCaseExecutor].ToString().Trim(); //案例执教者
objRow[conTeachCase.TeachCaseTheme] = oRow[conTeachCase.TeachCaseTheme].ToString().Trim(); //案例主题词
objRow[conTeachCase.TeachCaseTeachDate] = oRow[conTeachCase.TeachCaseTeachDate].ToString().Trim(); //案例授课日期
objRow[conTeachCase.TeachCaseBG] = oRow[conTeachCase.TeachCaseBG].ToString().Trim(); //案例背景资料
objRow[conTeachCase.IdTeachSkill] = oRow[conTeachCase.IdTeachSkill].ToString().Trim(); //教学技能流水号
objRow[conTeachCase.IdDiscipline] = oRow[conTeachCase.IdDiscipline].ToString().Trim(); //学科流水号
objRow[conTeachCase.IdStudyLevel] = oRow[conTeachCase.IdStudyLevel].ToString().Trim(); //学段流水号
objRow[conTeachCase.TeachCaseDateIn] = oRow[conTeachCase.TeachCaseDateIn].ToString().Trim(); //案例入库日期
objRow[conTeachCase.IdTeachingPlan] = oRow[conTeachCase.IdTeachingPlan].ToString().Trim(); //教案流水号
objRow[conTeachCase.TeachCaseTimeIn] = oRow[conTeachCase.TeachCaseTimeIn].ToString().Trim(); //案例入库时间
objRow[conTeachCase.WorkUnit] = oRow[conTeachCase.WorkUnit].ToString().Trim(); //工作单位
objRow[conTeachCase.CDID] = oRow[conTeachCase.CDID].ToString().Trim(); //光盘编号
objRow[conTeachCase.BrowseCount] = oRow[conTeachCase.BrowseCount].ToString().Trim(); //浏览次数
objRow[conTeachCase.IsVisible] = oRow[conTeachCase.IsVisible].ToString().Trim(); //是否显示
objRow[conTeachCase.IsDualVideo] = oRow[conTeachCase.IsDualVideo].ToString().Trim(); //是否双视频
objRow[conTeachCase.IdXzCollege] = oRow[conTeachCase.IdXzCollege].ToString().Trim(); //学院流水号
objRow[conTeachCase.RecommendedDegreeId] = oRow[conTeachCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objRow[conTeachCase.ftpFileType] = oRow[conTeachCase.ftpFileType].ToString().Trim(); //ftp文件类型
objRow[conTeachCase.VideoUrl] = oRow[conTeachCase.VideoUrl].ToString().Trim(); //视频Url
objRow[conTeachCase.VideoPath] = oRow[conTeachCase.VideoPath].ToString().Trim(); //视频目录
objRow[conTeachCase.ResErrMsg] = oRow[conTeachCase.ResErrMsg].ToString().Trim(); //资源错误信息
objRow[conTeachCase.UpdDate] = oRow[conTeachCase.UpdDate].ToString().Trim(); //修改日期
objRow[conTeachCase.UpdUserId] = oRow[conTeachCase.UpdUserId].ToString().Trim(); //修改用户Id
objRow[conTeachCase.Memo] = oRow[conTeachCase.Memo].ToString().Trim(); //备注
 objDS.Tables[clsTeachCaseEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsTeachCaseEN._CurrTabName);
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
 /// <param name = "objTeachCaseEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsTeachCaseEN objTeachCaseEN)
{
 objTeachCaseEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objTeachCaseEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objTeachCaseEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeachCaseDA.GetSpecSQLObj();
strSQL = "Select * from TeachCase where IdTeachCase = " + "'"+ objTeachCaseEN.IdTeachCase+"'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsTeachCaseEN._CurrTabName);
if (objDS.Tables[clsTeachCaseEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:IdTeachCase = " + "'"+ objTeachCaseEN.IdTeachCase+"'");
return false;
}
objRow = objDS.Tables[clsTeachCaseEN._CurrTabName].Rows[0];
 if (objTeachCaseEN.IsUpdated(conTeachCase.IdTeachCase))
 {
objRow[conTeachCase.IdTeachCase] = objTeachCaseEN.IdTeachCase; //案例流水号
 }
 if (objTeachCaseEN.IsUpdated(conTeachCase.TeachCaseID))
 {
objRow[conTeachCase.TeachCaseID] = objTeachCaseEN.TeachCaseID; //案例ID
 }
 if (objTeachCaseEN.IsUpdated(conTeachCase.TeachCaseName))
 {
objRow[conTeachCase.TeachCaseName] = objTeachCaseEN.TeachCaseName; //案例名称
 }
 if (objTeachCaseEN.IsUpdated(conTeachCase.TeachCaseExecutor))
 {
objRow[conTeachCase.TeachCaseExecutor] = objTeachCaseEN.TeachCaseExecutor; //案例执教者
 }
 if (objTeachCaseEN.IsUpdated(conTeachCase.TeachCaseTheme))
 {
objRow[conTeachCase.TeachCaseTheme] = objTeachCaseEN.TeachCaseTheme; //案例主题词
 }
 if (objTeachCaseEN.IsUpdated(conTeachCase.TeachCaseTeachDate))
 {
objRow[conTeachCase.TeachCaseTeachDate] = objTeachCaseEN.TeachCaseTeachDate; //案例授课日期
 }
 if (objTeachCaseEN.IsUpdated(conTeachCase.TeachCaseBG))
 {
objRow[conTeachCase.TeachCaseBG] = objTeachCaseEN.TeachCaseBG; //案例背景资料
 }
 if (objTeachCaseEN.IsUpdated(conTeachCase.IdTeachSkill))
 {
objRow[conTeachCase.IdTeachSkill] = objTeachCaseEN.IdTeachSkill; //教学技能流水号
 }
 if (objTeachCaseEN.IsUpdated(conTeachCase.IdDiscipline))
 {
objRow[conTeachCase.IdDiscipline] = objTeachCaseEN.IdDiscipline; //学科流水号
 }
 if (objTeachCaseEN.IsUpdated(conTeachCase.IdStudyLevel))
 {
objRow[conTeachCase.IdStudyLevel] = objTeachCaseEN.IdStudyLevel; //学段流水号
 }
 if (objTeachCaseEN.IsUpdated(conTeachCase.TeachCaseDateIn))
 {
objRow[conTeachCase.TeachCaseDateIn] = objTeachCaseEN.TeachCaseDateIn; //案例入库日期
 }
 if (objTeachCaseEN.IsUpdated(conTeachCase.IdTeachingPlan))
 {
objRow[conTeachCase.IdTeachingPlan] = objTeachCaseEN.IdTeachingPlan; //教案流水号
 }
 if (objTeachCaseEN.IsUpdated(conTeachCase.TeachCaseTimeIn))
 {
objRow[conTeachCase.TeachCaseTimeIn] = objTeachCaseEN.TeachCaseTimeIn; //案例入库时间
 }
 if (objTeachCaseEN.IsUpdated(conTeachCase.WorkUnit))
 {
objRow[conTeachCase.WorkUnit] = objTeachCaseEN.WorkUnit; //工作单位
 }
 if (objTeachCaseEN.IsUpdated(conTeachCase.CDID))
 {
objRow[conTeachCase.CDID] = objTeachCaseEN.CDID; //光盘编号
 }
 if (objTeachCaseEN.IsUpdated(conTeachCase.BrowseCount))
 {
objRow[conTeachCase.BrowseCount] = objTeachCaseEN.BrowseCount; //浏览次数
 }
 if (objTeachCaseEN.IsUpdated(conTeachCase.IsVisible))
 {
objRow[conTeachCase.IsVisible] = objTeachCaseEN.IsVisible; //是否显示
 }
 if (objTeachCaseEN.IsUpdated(conTeachCase.IsDualVideo))
 {
objRow[conTeachCase.IsDualVideo] = objTeachCaseEN.IsDualVideo; //是否双视频
 }
 if (objTeachCaseEN.IsUpdated(conTeachCase.IdXzCollege))
 {
objRow[conTeachCase.IdXzCollege] = objTeachCaseEN.IdXzCollege; //学院流水号
 }
 if (objTeachCaseEN.IsUpdated(conTeachCase.RecommendedDegreeId))
 {
objRow[conTeachCase.RecommendedDegreeId] = objTeachCaseEN.RecommendedDegreeId; //推荐度Id
 }
 if (objTeachCaseEN.IsUpdated(conTeachCase.ftpFileType))
 {
objRow[conTeachCase.ftpFileType] = objTeachCaseEN.ftpFileType; //ftp文件类型
 }
 if (objTeachCaseEN.IsUpdated(conTeachCase.VideoUrl))
 {
objRow[conTeachCase.VideoUrl] = objTeachCaseEN.VideoUrl; //视频Url
 }
 if (objTeachCaseEN.IsUpdated(conTeachCase.VideoPath))
 {
objRow[conTeachCase.VideoPath] = objTeachCaseEN.VideoPath; //视频目录
 }
 if (objTeachCaseEN.IsUpdated(conTeachCase.ResErrMsg))
 {
objRow[conTeachCase.ResErrMsg] = objTeachCaseEN.ResErrMsg; //资源错误信息
 }
 if (objTeachCaseEN.IsUpdated(conTeachCase.UpdDate))
 {
objRow[conTeachCase.UpdDate] = objTeachCaseEN.UpdDate; //修改日期
 }
 if (objTeachCaseEN.IsUpdated(conTeachCase.UpdUserId))
 {
objRow[conTeachCase.UpdUserId] = objTeachCaseEN.UpdUserId; //修改用户Id
 }
 if (objTeachCaseEN.IsUpdated(conTeachCase.Memo))
 {
objRow[conTeachCase.Memo] = objTeachCaseEN.Memo; //备注
 }
try
{
objDA.Update(objDS, clsTeachCaseEN._CurrTabName);
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
 /// <param name = "objTeachCaseEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsTeachCaseEN objTeachCaseEN)
{
 objTeachCaseEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objTeachCaseEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objTeachCaseEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeachCaseDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update TeachCase Set ");
 
 if (objTeachCaseEN.IsUpdated(conTeachCase.TeachCaseID))
 {
 if (objTeachCaseEN.TeachCaseID !=  null)
 {
 var strTeachCaseID = objTeachCaseEN.TeachCaseID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTeachCaseID, conTeachCase.TeachCaseID); //案例ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeachCase.TeachCaseID); //案例ID
 }
 }
 
 if (objTeachCaseEN.IsUpdated(conTeachCase.TeachCaseName))
 {
 if (objTeachCaseEN.TeachCaseName !=  null)
 {
 var strTeachCaseName = objTeachCaseEN.TeachCaseName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTeachCaseName, conTeachCase.TeachCaseName); //案例名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeachCase.TeachCaseName); //案例名称
 }
 }
 
 if (objTeachCaseEN.IsUpdated(conTeachCase.TeachCaseExecutor))
 {
 if (objTeachCaseEN.TeachCaseExecutor !=  null)
 {
 var strTeachCaseExecutor = objTeachCaseEN.TeachCaseExecutor.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTeachCaseExecutor, conTeachCase.TeachCaseExecutor); //案例执教者
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeachCase.TeachCaseExecutor); //案例执教者
 }
 }
 
 if (objTeachCaseEN.IsUpdated(conTeachCase.TeachCaseTheme))
 {
 if (objTeachCaseEN.TeachCaseTheme !=  null)
 {
 var strTeachCaseTheme = objTeachCaseEN.TeachCaseTheme.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTeachCaseTheme, conTeachCase.TeachCaseTheme); //案例主题词
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeachCase.TeachCaseTheme); //案例主题词
 }
 }
 
 if (objTeachCaseEN.IsUpdated(conTeachCase.TeachCaseTeachDate))
 {
 if (objTeachCaseEN.TeachCaseTeachDate !=  null)
 {
 var strTeachCaseTeachDate = objTeachCaseEN.TeachCaseTeachDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTeachCaseTeachDate, conTeachCase.TeachCaseTeachDate); //案例授课日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeachCase.TeachCaseTeachDate); //案例授课日期
 }
 }
 
 if (objTeachCaseEN.IsUpdated(conTeachCase.TeachCaseBG))
 {
 if (objTeachCaseEN.TeachCaseBG !=  null)
 {
 var strTeachCaseBG = objTeachCaseEN.TeachCaseBG.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTeachCaseBG, conTeachCase.TeachCaseBG); //案例背景资料
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeachCase.TeachCaseBG); //案例背景资料
 }
 }
 
 if (objTeachCaseEN.IsUpdated(conTeachCase.IdTeachSkill))
 {
 if (objTeachCaseEN.IdTeachSkill  ==  "")
 {
 objTeachCaseEN.IdTeachSkill = null;
 }
 if (objTeachCaseEN.IdTeachSkill !=  null)
 {
 var strIdTeachSkill = objTeachCaseEN.IdTeachSkill.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdTeachSkill, conTeachCase.IdTeachSkill); //教学技能流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeachCase.IdTeachSkill); //教学技能流水号
 }
 }
 
 if (objTeachCaseEN.IsUpdated(conTeachCase.IdDiscipline))
 {
 if (objTeachCaseEN.IdDiscipline  ==  "")
 {
 objTeachCaseEN.IdDiscipline = null;
 }
 if (objTeachCaseEN.IdDiscipline !=  null)
 {
 var strIdDiscipline = objTeachCaseEN.IdDiscipline.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdDiscipline, conTeachCase.IdDiscipline); //学科流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeachCase.IdDiscipline); //学科流水号
 }
 }
 
 if (objTeachCaseEN.IsUpdated(conTeachCase.IdStudyLevel))
 {
 if (objTeachCaseEN.IdStudyLevel  ==  "")
 {
 objTeachCaseEN.IdStudyLevel = null;
 }
 if (objTeachCaseEN.IdStudyLevel !=  null)
 {
 var strIdStudyLevel = objTeachCaseEN.IdStudyLevel.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdStudyLevel, conTeachCase.IdStudyLevel); //学段流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeachCase.IdStudyLevel); //学段流水号
 }
 }
 
 if (objTeachCaseEN.IsUpdated(conTeachCase.TeachCaseDateIn))
 {
 if (objTeachCaseEN.TeachCaseDateIn !=  null)
 {
 var strTeachCaseDateIn = objTeachCaseEN.TeachCaseDateIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTeachCaseDateIn, conTeachCase.TeachCaseDateIn); //案例入库日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeachCase.TeachCaseDateIn); //案例入库日期
 }
 }
 
 if (objTeachCaseEN.IsUpdated(conTeachCase.IdTeachingPlan))
 {
 if (objTeachCaseEN.IdTeachingPlan  ==  "")
 {
 objTeachCaseEN.IdTeachingPlan = null;
 }
 if (objTeachCaseEN.IdTeachingPlan !=  null)
 {
 var strIdTeachingPlan = objTeachCaseEN.IdTeachingPlan.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdTeachingPlan, conTeachCase.IdTeachingPlan); //教案流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeachCase.IdTeachingPlan); //教案流水号
 }
 }
 
 if (objTeachCaseEN.IsUpdated(conTeachCase.TeachCaseTimeIn))
 {
 if (objTeachCaseEN.TeachCaseTimeIn !=  null)
 {
 var strTeachCaseTimeIn = objTeachCaseEN.TeachCaseTimeIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTeachCaseTimeIn, conTeachCase.TeachCaseTimeIn); //案例入库时间
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeachCase.TeachCaseTimeIn); //案例入库时间
 }
 }
 
 if (objTeachCaseEN.IsUpdated(conTeachCase.WorkUnit))
 {
 if (objTeachCaseEN.WorkUnit !=  null)
 {
 var strWorkUnit = objTeachCaseEN.WorkUnit.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strWorkUnit, conTeachCase.WorkUnit); //工作单位
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeachCase.WorkUnit); //工作单位
 }
 }
 
 if (objTeachCaseEN.IsUpdated(conTeachCase.CDID))
 {
 if (objTeachCaseEN.CDID !=  null)
 {
 var strCDID = objTeachCaseEN.CDID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCDID, conTeachCase.CDID); //光盘编号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeachCase.CDID); //光盘编号
 }
 }
 
 if (objTeachCaseEN.IsUpdated(conTeachCase.BrowseCount))
 {
 if (objTeachCaseEN.BrowseCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objTeachCaseEN.BrowseCount, conTeachCase.BrowseCount); //浏览次数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeachCase.BrowseCount); //浏览次数
 }
 }
 
 if (objTeachCaseEN.IsUpdated(conTeachCase.IsVisible))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objTeachCaseEN.IsVisible == true?"1":"0", conTeachCase.IsVisible); //是否显示
 }
 
 if (objTeachCaseEN.IsUpdated(conTeachCase.IsDualVideo))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objTeachCaseEN.IsDualVideo == true?"1":"0", conTeachCase.IsDualVideo); //是否双视频
 }
 
 if (objTeachCaseEN.IsUpdated(conTeachCase.IdXzCollege))
 {
 if (objTeachCaseEN.IdXzCollege !=  null)
 {
 var strIdXzCollege = objTeachCaseEN.IdXzCollege.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdXzCollege, conTeachCase.IdXzCollege); //学院流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeachCase.IdXzCollege); //学院流水号
 }
 }
 
 if (objTeachCaseEN.IsUpdated(conTeachCase.RecommendedDegreeId))
 {
 if (objTeachCaseEN.RecommendedDegreeId !=  null)
 {
 var strRecommendedDegreeId = objTeachCaseEN.RecommendedDegreeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strRecommendedDegreeId, conTeachCase.RecommendedDegreeId); //推荐度Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeachCase.RecommendedDegreeId); //推荐度Id
 }
 }
 
 if (objTeachCaseEN.IsUpdated(conTeachCase.ftpFileType))
 {
 if (objTeachCaseEN.ftpFileType !=  null)
 {
 var strftpFileType = objTeachCaseEN.ftpFileType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strftpFileType, conTeachCase.ftpFileType); //ftp文件类型
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeachCase.ftpFileType); //ftp文件类型
 }
 }
 
 if (objTeachCaseEN.IsUpdated(conTeachCase.VideoUrl))
 {
 if (objTeachCaseEN.VideoUrl !=  null)
 {
 var strVideoUrl = objTeachCaseEN.VideoUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strVideoUrl, conTeachCase.VideoUrl); //视频Url
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeachCase.VideoUrl); //视频Url
 }
 }
 
 if (objTeachCaseEN.IsUpdated(conTeachCase.VideoPath))
 {
 if (objTeachCaseEN.VideoPath !=  null)
 {
 var strVideoPath = objTeachCaseEN.VideoPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strVideoPath, conTeachCase.VideoPath); //视频目录
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeachCase.VideoPath); //视频目录
 }
 }
 
 if (objTeachCaseEN.IsUpdated(conTeachCase.ResErrMsg))
 {
 if (objTeachCaseEN.ResErrMsg !=  null)
 {
 var strResErrMsg = objTeachCaseEN.ResErrMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strResErrMsg, conTeachCase.ResErrMsg); //资源错误信息
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeachCase.ResErrMsg); //资源错误信息
 }
 }
 
 if (objTeachCaseEN.IsUpdated(conTeachCase.UpdDate))
 {
 if (objTeachCaseEN.UpdDate !=  null)
 {
 var strUpdDate = objTeachCaseEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conTeachCase.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeachCase.UpdDate); //修改日期
 }
 }
 
 if (objTeachCaseEN.IsUpdated(conTeachCase.UpdUserId))
 {
 if (objTeachCaseEN.UpdUserId !=  null)
 {
 var strUpdUserId = objTeachCaseEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUserId, conTeachCase.UpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeachCase.UpdUserId); //修改用户Id
 }
 }
 
 if (objTeachCaseEN.IsUpdated(conTeachCase.Memo))
 {
 if (objTeachCaseEN.Memo !=  null)
 {
 var strMemo = objTeachCaseEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conTeachCase.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeachCase.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where IdTeachCase = '{0}'", objTeachCaseEN.IdTeachCase); 
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
 /// <param name = "objTeachCaseEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsTeachCaseEN objTeachCaseEN, string strCondition)
{
 objTeachCaseEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objTeachCaseEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objTeachCaseEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeachCaseDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update TeachCase Set ");
 
 if (objTeachCaseEN.IsUpdated(conTeachCase.TeachCaseID))
 {
 if (objTeachCaseEN.TeachCaseID !=  null)
 {
 var strTeachCaseID = objTeachCaseEN.TeachCaseID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TeachCaseID = '{0}',", strTeachCaseID); //案例ID
 }
 else
 {
 sbSQL.Append(" TeachCaseID = null,"); //案例ID
 }
 }
 
 if (objTeachCaseEN.IsUpdated(conTeachCase.TeachCaseName))
 {
 if (objTeachCaseEN.TeachCaseName !=  null)
 {
 var strTeachCaseName = objTeachCaseEN.TeachCaseName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TeachCaseName = '{0}',", strTeachCaseName); //案例名称
 }
 else
 {
 sbSQL.Append(" TeachCaseName = null,"); //案例名称
 }
 }
 
 if (objTeachCaseEN.IsUpdated(conTeachCase.TeachCaseExecutor))
 {
 if (objTeachCaseEN.TeachCaseExecutor !=  null)
 {
 var strTeachCaseExecutor = objTeachCaseEN.TeachCaseExecutor.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TeachCaseExecutor = '{0}',", strTeachCaseExecutor); //案例执教者
 }
 else
 {
 sbSQL.Append(" TeachCaseExecutor = null,"); //案例执教者
 }
 }
 
 if (objTeachCaseEN.IsUpdated(conTeachCase.TeachCaseTheme))
 {
 if (objTeachCaseEN.TeachCaseTheme !=  null)
 {
 var strTeachCaseTheme = objTeachCaseEN.TeachCaseTheme.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TeachCaseTheme = '{0}',", strTeachCaseTheme); //案例主题词
 }
 else
 {
 sbSQL.Append(" TeachCaseTheme = null,"); //案例主题词
 }
 }
 
 if (objTeachCaseEN.IsUpdated(conTeachCase.TeachCaseTeachDate))
 {
 if (objTeachCaseEN.TeachCaseTeachDate !=  null)
 {
 var strTeachCaseTeachDate = objTeachCaseEN.TeachCaseTeachDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TeachCaseTeachDate = '{0}',", strTeachCaseTeachDate); //案例授课日期
 }
 else
 {
 sbSQL.Append(" TeachCaseTeachDate = null,"); //案例授课日期
 }
 }
 
 if (objTeachCaseEN.IsUpdated(conTeachCase.TeachCaseBG))
 {
 if (objTeachCaseEN.TeachCaseBG !=  null)
 {
 var strTeachCaseBG = objTeachCaseEN.TeachCaseBG.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TeachCaseBG = '{0}',", strTeachCaseBG); //案例背景资料
 }
 else
 {
 sbSQL.Append(" TeachCaseBG = null,"); //案例背景资料
 }
 }
 
 if (objTeachCaseEN.IsUpdated(conTeachCase.IdTeachSkill))
 {
 if (objTeachCaseEN.IdTeachSkill  ==  "")
 {
 objTeachCaseEN.IdTeachSkill = null;
 }
 if (objTeachCaseEN.IdTeachSkill !=  null)
 {
 var strIdTeachSkill = objTeachCaseEN.IdTeachSkill.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdTeachSkill = '{0}',", strIdTeachSkill); //教学技能流水号
 }
 else
 {
 sbSQL.Append(" IdTeachSkill = null,"); //教学技能流水号
 }
 }
 
 if (objTeachCaseEN.IsUpdated(conTeachCase.IdDiscipline))
 {
 if (objTeachCaseEN.IdDiscipline  ==  "")
 {
 objTeachCaseEN.IdDiscipline = null;
 }
 if (objTeachCaseEN.IdDiscipline !=  null)
 {
 var strIdDiscipline = objTeachCaseEN.IdDiscipline.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdDiscipline = '{0}',", strIdDiscipline); //学科流水号
 }
 else
 {
 sbSQL.Append(" IdDiscipline = null,"); //学科流水号
 }
 }
 
 if (objTeachCaseEN.IsUpdated(conTeachCase.IdStudyLevel))
 {
 if (objTeachCaseEN.IdStudyLevel  ==  "")
 {
 objTeachCaseEN.IdStudyLevel = null;
 }
 if (objTeachCaseEN.IdStudyLevel !=  null)
 {
 var strIdStudyLevel = objTeachCaseEN.IdStudyLevel.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdStudyLevel = '{0}',", strIdStudyLevel); //学段流水号
 }
 else
 {
 sbSQL.Append(" IdStudyLevel = null,"); //学段流水号
 }
 }
 
 if (objTeachCaseEN.IsUpdated(conTeachCase.TeachCaseDateIn))
 {
 if (objTeachCaseEN.TeachCaseDateIn !=  null)
 {
 var strTeachCaseDateIn = objTeachCaseEN.TeachCaseDateIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TeachCaseDateIn = '{0}',", strTeachCaseDateIn); //案例入库日期
 }
 else
 {
 sbSQL.Append(" TeachCaseDateIn = null,"); //案例入库日期
 }
 }
 
 if (objTeachCaseEN.IsUpdated(conTeachCase.IdTeachingPlan))
 {
 if (objTeachCaseEN.IdTeachingPlan  ==  "")
 {
 objTeachCaseEN.IdTeachingPlan = null;
 }
 if (objTeachCaseEN.IdTeachingPlan !=  null)
 {
 var strIdTeachingPlan = objTeachCaseEN.IdTeachingPlan.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdTeachingPlan = '{0}',", strIdTeachingPlan); //教案流水号
 }
 else
 {
 sbSQL.Append(" IdTeachingPlan = null,"); //教案流水号
 }
 }
 
 if (objTeachCaseEN.IsUpdated(conTeachCase.TeachCaseTimeIn))
 {
 if (objTeachCaseEN.TeachCaseTimeIn !=  null)
 {
 var strTeachCaseTimeIn = objTeachCaseEN.TeachCaseTimeIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TeachCaseTimeIn = '{0}',", strTeachCaseTimeIn); //案例入库时间
 }
 else
 {
 sbSQL.Append(" TeachCaseTimeIn = null,"); //案例入库时间
 }
 }
 
 if (objTeachCaseEN.IsUpdated(conTeachCase.WorkUnit))
 {
 if (objTeachCaseEN.WorkUnit !=  null)
 {
 var strWorkUnit = objTeachCaseEN.WorkUnit.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" WorkUnit = '{0}',", strWorkUnit); //工作单位
 }
 else
 {
 sbSQL.Append(" WorkUnit = null,"); //工作单位
 }
 }
 
 if (objTeachCaseEN.IsUpdated(conTeachCase.CDID))
 {
 if (objTeachCaseEN.CDID !=  null)
 {
 var strCDID = objTeachCaseEN.CDID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CDID = '{0}',", strCDID); //光盘编号
 }
 else
 {
 sbSQL.Append(" CDID = null,"); //光盘编号
 }
 }
 
 if (objTeachCaseEN.IsUpdated(conTeachCase.BrowseCount))
 {
 if (objTeachCaseEN.BrowseCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objTeachCaseEN.BrowseCount, conTeachCase.BrowseCount); //浏览次数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeachCase.BrowseCount); //浏览次数
 }
 }
 
 if (objTeachCaseEN.IsUpdated(conTeachCase.IsVisible))
 {
 sbSQL.AppendFormat(" IsVisible = '{0}',", objTeachCaseEN.IsVisible == true?"1":"0"); //是否显示
 }
 
 if (objTeachCaseEN.IsUpdated(conTeachCase.IsDualVideo))
 {
 sbSQL.AppendFormat(" IsDualVideo = '{0}',", objTeachCaseEN.IsDualVideo == true?"1":"0"); //是否双视频
 }
 
 if (objTeachCaseEN.IsUpdated(conTeachCase.IdXzCollege))
 {
 if (objTeachCaseEN.IdXzCollege !=  null)
 {
 var strIdXzCollege = objTeachCaseEN.IdXzCollege.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdXzCollege = '{0}',", strIdXzCollege); //学院流水号
 }
 else
 {
 sbSQL.Append(" IdXzCollege = null,"); //学院流水号
 }
 }
 
 if (objTeachCaseEN.IsUpdated(conTeachCase.RecommendedDegreeId))
 {
 if (objTeachCaseEN.RecommendedDegreeId !=  null)
 {
 var strRecommendedDegreeId = objTeachCaseEN.RecommendedDegreeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" RecommendedDegreeId = '{0}',", strRecommendedDegreeId); //推荐度Id
 }
 else
 {
 sbSQL.Append(" RecommendedDegreeId = null,"); //推荐度Id
 }
 }
 
 if (objTeachCaseEN.IsUpdated(conTeachCase.ftpFileType))
 {
 if (objTeachCaseEN.ftpFileType !=  null)
 {
 var strftpFileType = objTeachCaseEN.ftpFileType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ftpFileType = '{0}',", strftpFileType); //ftp文件类型
 }
 else
 {
 sbSQL.Append(" ftpFileType = null,"); //ftp文件类型
 }
 }
 
 if (objTeachCaseEN.IsUpdated(conTeachCase.VideoUrl))
 {
 if (objTeachCaseEN.VideoUrl !=  null)
 {
 var strVideoUrl = objTeachCaseEN.VideoUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" VideoUrl = '{0}',", strVideoUrl); //视频Url
 }
 else
 {
 sbSQL.Append(" VideoUrl = null,"); //视频Url
 }
 }
 
 if (objTeachCaseEN.IsUpdated(conTeachCase.VideoPath))
 {
 if (objTeachCaseEN.VideoPath !=  null)
 {
 var strVideoPath = objTeachCaseEN.VideoPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" VideoPath = '{0}',", strVideoPath); //视频目录
 }
 else
 {
 sbSQL.Append(" VideoPath = null,"); //视频目录
 }
 }
 
 if (objTeachCaseEN.IsUpdated(conTeachCase.ResErrMsg))
 {
 if (objTeachCaseEN.ResErrMsg !=  null)
 {
 var strResErrMsg = objTeachCaseEN.ResErrMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ResErrMsg = '{0}',", strResErrMsg); //资源错误信息
 }
 else
 {
 sbSQL.Append(" ResErrMsg = null,"); //资源错误信息
 }
 }
 
 if (objTeachCaseEN.IsUpdated(conTeachCase.UpdDate))
 {
 if (objTeachCaseEN.UpdDate !=  null)
 {
 var strUpdDate = objTeachCaseEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objTeachCaseEN.IsUpdated(conTeachCase.UpdUserId))
 {
 if (objTeachCaseEN.UpdUserId !=  null)
 {
 var strUpdUserId = objTeachCaseEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUserId = '{0}',", strUpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.Append(" UpdUserId = null,"); //修改用户Id
 }
 }
 
 if (objTeachCaseEN.IsUpdated(conTeachCase.Memo))
 {
 if (objTeachCaseEN.Memo !=  null)
 {
 var strMemo = objTeachCaseEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objTeachCaseEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsTeachCaseEN objTeachCaseEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objTeachCaseEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objTeachCaseEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objTeachCaseEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeachCaseDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update TeachCase Set ");
 
 if (objTeachCaseEN.IsUpdated(conTeachCase.TeachCaseID))
 {
 if (objTeachCaseEN.TeachCaseID !=  null)
 {
 var strTeachCaseID = objTeachCaseEN.TeachCaseID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TeachCaseID = '{0}',", strTeachCaseID); //案例ID
 }
 else
 {
 sbSQL.Append(" TeachCaseID = null,"); //案例ID
 }
 }
 
 if (objTeachCaseEN.IsUpdated(conTeachCase.TeachCaseName))
 {
 if (objTeachCaseEN.TeachCaseName !=  null)
 {
 var strTeachCaseName = objTeachCaseEN.TeachCaseName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TeachCaseName = '{0}',", strTeachCaseName); //案例名称
 }
 else
 {
 sbSQL.Append(" TeachCaseName = null,"); //案例名称
 }
 }
 
 if (objTeachCaseEN.IsUpdated(conTeachCase.TeachCaseExecutor))
 {
 if (objTeachCaseEN.TeachCaseExecutor !=  null)
 {
 var strTeachCaseExecutor = objTeachCaseEN.TeachCaseExecutor.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TeachCaseExecutor = '{0}',", strTeachCaseExecutor); //案例执教者
 }
 else
 {
 sbSQL.Append(" TeachCaseExecutor = null,"); //案例执教者
 }
 }
 
 if (objTeachCaseEN.IsUpdated(conTeachCase.TeachCaseTheme))
 {
 if (objTeachCaseEN.TeachCaseTheme !=  null)
 {
 var strTeachCaseTheme = objTeachCaseEN.TeachCaseTheme.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TeachCaseTheme = '{0}',", strTeachCaseTheme); //案例主题词
 }
 else
 {
 sbSQL.Append(" TeachCaseTheme = null,"); //案例主题词
 }
 }
 
 if (objTeachCaseEN.IsUpdated(conTeachCase.TeachCaseTeachDate))
 {
 if (objTeachCaseEN.TeachCaseTeachDate !=  null)
 {
 var strTeachCaseTeachDate = objTeachCaseEN.TeachCaseTeachDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TeachCaseTeachDate = '{0}',", strTeachCaseTeachDate); //案例授课日期
 }
 else
 {
 sbSQL.Append(" TeachCaseTeachDate = null,"); //案例授课日期
 }
 }
 
 if (objTeachCaseEN.IsUpdated(conTeachCase.TeachCaseBG))
 {
 if (objTeachCaseEN.TeachCaseBG !=  null)
 {
 var strTeachCaseBG = objTeachCaseEN.TeachCaseBG.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TeachCaseBG = '{0}',", strTeachCaseBG); //案例背景资料
 }
 else
 {
 sbSQL.Append(" TeachCaseBG = null,"); //案例背景资料
 }
 }
 
 if (objTeachCaseEN.IsUpdated(conTeachCase.IdTeachSkill))
 {
 if (objTeachCaseEN.IdTeachSkill  ==  "")
 {
 objTeachCaseEN.IdTeachSkill = null;
 }
 if (objTeachCaseEN.IdTeachSkill !=  null)
 {
 var strIdTeachSkill = objTeachCaseEN.IdTeachSkill.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdTeachSkill = '{0}',", strIdTeachSkill); //教学技能流水号
 }
 else
 {
 sbSQL.Append(" IdTeachSkill = null,"); //教学技能流水号
 }
 }
 
 if (objTeachCaseEN.IsUpdated(conTeachCase.IdDiscipline))
 {
 if (objTeachCaseEN.IdDiscipline  ==  "")
 {
 objTeachCaseEN.IdDiscipline = null;
 }
 if (objTeachCaseEN.IdDiscipline !=  null)
 {
 var strIdDiscipline = objTeachCaseEN.IdDiscipline.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdDiscipline = '{0}',", strIdDiscipline); //学科流水号
 }
 else
 {
 sbSQL.Append(" IdDiscipline = null,"); //学科流水号
 }
 }
 
 if (objTeachCaseEN.IsUpdated(conTeachCase.IdStudyLevel))
 {
 if (objTeachCaseEN.IdStudyLevel  ==  "")
 {
 objTeachCaseEN.IdStudyLevel = null;
 }
 if (objTeachCaseEN.IdStudyLevel !=  null)
 {
 var strIdStudyLevel = objTeachCaseEN.IdStudyLevel.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdStudyLevel = '{0}',", strIdStudyLevel); //学段流水号
 }
 else
 {
 sbSQL.Append(" IdStudyLevel = null,"); //学段流水号
 }
 }
 
 if (objTeachCaseEN.IsUpdated(conTeachCase.TeachCaseDateIn))
 {
 if (objTeachCaseEN.TeachCaseDateIn !=  null)
 {
 var strTeachCaseDateIn = objTeachCaseEN.TeachCaseDateIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TeachCaseDateIn = '{0}',", strTeachCaseDateIn); //案例入库日期
 }
 else
 {
 sbSQL.Append(" TeachCaseDateIn = null,"); //案例入库日期
 }
 }
 
 if (objTeachCaseEN.IsUpdated(conTeachCase.IdTeachingPlan))
 {
 if (objTeachCaseEN.IdTeachingPlan  ==  "")
 {
 objTeachCaseEN.IdTeachingPlan = null;
 }
 if (objTeachCaseEN.IdTeachingPlan !=  null)
 {
 var strIdTeachingPlan = objTeachCaseEN.IdTeachingPlan.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdTeachingPlan = '{0}',", strIdTeachingPlan); //教案流水号
 }
 else
 {
 sbSQL.Append(" IdTeachingPlan = null,"); //教案流水号
 }
 }
 
 if (objTeachCaseEN.IsUpdated(conTeachCase.TeachCaseTimeIn))
 {
 if (objTeachCaseEN.TeachCaseTimeIn !=  null)
 {
 var strTeachCaseTimeIn = objTeachCaseEN.TeachCaseTimeIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TeachCaseTimeIn = '{0}',", strTeachCaseTimeIn); //案例入库时间
 }
 else
 {
 sbSQL.Append(" TeachCaseTimeIn = null,"); //案例入库时间
 }
 }
 
 if (objTeachCaseEN.IsUpdated(conTeachCase.WorkUnit))
 {
 if (objTeachCaseEN.WorkUnit !=  null)
 {
 var strWorkUnit = objTeachCaseEN.WorkUnit.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" WorkUnit = '{0}',", strWorkUnit); //工作单位
 }
 else
 {
 sbSQL.Append(" WorkUnit = null,"); //工作单位
 }
 }
 
 if (objTeachCaseEN.IsUpdated(conTeachCase.CDID))
 {
 if (objTeachCaseEN.CDID !=  null)
 {
 var strCDID = objTeachCaseEN.CDID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CDID = '{0}',", strCDID); //光盘编号
 }
 else
 {
 sbSQL.Append(" CDID = null,"); //光盘编号
 }
 }
 
 if (objTeachCaseEN.IsUpdated(conTeachCase.BrowseCount))
 {
 if (objTeachCaseEN.BrowseCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objTeachCaseEN.BrowseCount, conTeachCase.BrowseCount); //浏览次数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeachCase.BrowseCount); //浏览次数
 }
 }
 
 if (objTeachCaseEN.IsUpdated(conTeachCase.IsVisible))
 {
 sbSQL.AppendFormat(" IsVisible = '{0}',", objTeachCaseEN.IsVisible == true?"1":"0"); //是否显示
 }
 
 if (objTeachCaseEN.IsUpdated(conTeachCase.IsDualVideo))
 {
 sbSQL.AppendFormat(" IsDualVideo = '{0}',", objTeachCaseEN.IsDualVideo == true?"1":"0"); //是否双视频
 }
 
 if (objTeachCaseEN.IsUpdated(conTeachCase.IdXzCollege))
 {
 if (objTeachCaseEN.IdXzCollege !=  null)
 {
 var strIdXzCollege = objTeachCaseEN.IdXzCollege.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdXzCollege = '{0}',", strIdXzCollege); //学院流水号
 }
 else
 {
 sbSQL.Append(" IdXzCollege = null,"); //学院流水号
 }
 }
 
 if (objTeachCaseEN.IsUpdated(conTeachCase.RecommendedDegreeId))
 {
 if (objTeachCaseEN.RecommendedDegreeId !=  null)
 {
 var strRecommendedDegreeId = objTeachCaseEN.RecommendedDegreeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" RecommendedDegreeId = '{0}',", strRecommendedDegreeId); //推荐度Id
 }
 else
 {
 sbSQL.Append(" RecommendedDegreeId = null,"); //推荐度Id
 }
 }
 
 if (objTeachCaseEN.IsUpdated(conTeachCase.ftpFileType))
 {
 if (objTeachCaseEN.ftpFileType !=  null)
 {
 var strftpFileType = objTeachCaseEN.ftpFileType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ftpFileType = '{0}',", strftpFileType); //ftp文件类型
 }
 else
 {
 sbSQL.Append(" ftpFileType = null,"); //ftp文件类型
 }
 }
 
 if (objTeachCaseEN.IsUpdated(conTeachCase.VideoUrl))
 {
 if (objTeachCaseEN.VideoUrl !=  null)
 {
 var strVideoUrl = objTeachCaseEN.VideoUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" VideoUrl = '{0}',", strVideoUrl); //视频Url
 }
 else
 {
 sbSQL.Append(" VideoUrl = null,"); //视频Url
 }
 }
 
 if (objTeachCaseEN.IsUpdated(conTeachCase.VideoPath))
 {
 if (objTeachCaseEN.VideoPath !=  null)
 {
 var strVideoPath = objTeachCaseEN.VideoPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" VideoPath = '{0}',", strVideoPath); //视频目录
 }
 else
 {
 sbSQL.Append(" VideoPath = null,"); //视频目录
 }
 }
 
 if (objTeachCaseEN.IsUpdated(conTeachCase.ResErrMsg))
 {
 if (objTeachCaseEN.ResErrMsg !=  null)
 {
 var strResErrMsg = objTeachCaseEN.ResErrMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ResErrMsg = '{0}',", strResErrMsg); //资源错误信息
 }
 else
 {
 sbSQL.Append(" ResErrMsg = null,"); //资源错误信息
 }
 }
 
 if (objTeachCaseEN.IsUpdated(conTeachCase.UpdDate))
 {
 if (objTeachCaseEN.UpdDate !=  null)
 {
 var strUpdDate = objTeachCaseEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objTeachCaseEN.IsUpdated(conTeachCase.UpdUserId))
 {
 if (objTeachCaseEN.UpdUserId !=  null)
 {
 var strUpdUserId = objTeachCaseEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUserId = '{0}',", strUpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.Append(" UpdUserId = null,"); //修改用户Id
 }
 }
 
 if (objTeachCaseEN.IsUpdated(conTeachCase.Memo))
 {
 if (objTeachCaseEN.Memo !=  null)
 {
 var strMemo = objTeachCaseEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objTeachCaseEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsTeachCaseEN objTeachCaseEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objTeachCaseEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objTeachCaseEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objTeachCaseEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeachCaseDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update TeachCase Set ");
 
 if (objTeachCaseEN.IsUpdated(conTeachCase.TeachCaseID))
 {
 if (objTeachCaseEN.TeachCaseID !=  null)
 {
 var strTeachCaseID = objTeachCaseEN.TeachCaseID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTeachCaseID, conTeachCase.TeachCaseID); //案例ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeachCase.TeachCaseID); //案例ID
 }
 }
 
 if (objTeachCaseEN.IsUpdated(conTeachCase.TeachCaseName))
 {
 if (objTeachCaseEN.TeachCaseName !=  null)
 {
 var strTeachCaseName = objTeachCaseEN.TeachCaseName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTeachCaseName, conTeachCase.TeachCaseName); //案例名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeachCase.TeachCaseName); //案例名称
 }
 }
 
 if (objTeachCaseEN.IsUpdated(conTeachCase.TeachCaseExecutor))
 {
 if (objTeachCaseEN.TeachCaseExecutor !=  null)
 {
 var strTeachCaseExecutor = objTeachCaseEN.TeachCaseExecutor.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTeachCaseExecutor, conTeachCase.TeachCaseExecutor); //案例执教者
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeachCase.TeachCaseExecutor); //案例执教者
 }
 }
 
 if (objTeachCaseEN.IsUpdated(conTeachCase.TeachCaseTheme))
 {
 if (objTeachCaseEN.TeachCaseTheme !=  null)
 {
 var strTeachCaseTheme = objTeachCaseEN.TeachCaseTheme.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTeachCaseTheme, conTeachCase.TeachCaseTheme); //案例主题词
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeachCase.TeachCaseTheme); //案例主题词
 }
 }
 
 if (objTeachCaseEN.IsUpdated(conTeachCase.TeachCaseTeachDate))
 {
 if (objTeachCaseEN.TeachCaseTeachDate !=  null)
 {
 var strTeachCaseTeachDate = objTeachCaseEN.TeachCaseTeachDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTeachCaseTeachDate, conTeachCase.TeachCaseTeachDate); //案例授课日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeachCase.TeachCaseTeachDate); //案例授课日期
 }
 }
 
 if (objTeachCaseEN.IsUpdated(conTeachCase.TeachCaseBG))
 {
 if (objTeachCaseEN.TeachCaseBG !=  null)
 {
 var strTeachCaseBG = objTeachCaseEN.TeachCaseBG.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTeachCaseBG, conTeachCase.TeachCaseBG); //案例背景资料
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeachCase.TeachCaseBG); //案例背景资料
 }
 }
 
 if (objTeachCaseEN.IsUpdated(conTeachCase.IdTeachSkill))
 {
 if (objTeachCaseEN.IdTeachSkill  ==  "")
 {
 objTeachCaseEN.IdTeachSkill = null;
 }
 if (objTeachCaseEN.IdTeachSkill !=  null)
 {
 var strIdTeachSkill = objTeachCaseEN.IdTeachSkill.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdTeachSkill, conTeachCase.IdTeachSkill); //教学技能流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeachCase.IdTeachSkill); //教学技能流水号
 }
 }
 
 if (objTeachCaseEN.IsUpdated(conTeachCase.IdDiscipline))
 {
 if (objTeachCaseEN.IdDiscipline  ==  "")
 {
 objTeachCaseEN.IdDiscipline = null;
 }
 if (objTeachCaseEN.IdDiscipline !=  null)
 {
 var strIdDiscipline = objTeachCaseEN.IdDiscipline.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdDiscipline, conTeachCase.IdDiscipline); //学科流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeachCase.IdDiscipline); //学科流水号
 }
 }
 
 if (objTeachCaseEN.IsUpdated(conTeachCase.IdStudyLevel))
 {
 if (objTeachCaseEN.IdStudyLevel  ==  "")
 {
 objTeachCaseEN.IdStudyLevel = null;
 }
 if (objTeachCaseEN.IdStudyLevel !=  null)
 {
 var strIdStudyLevel = objTeachCaseEN.IdStudyLevel.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdStudyLevel, conTeachCase.IdStudyLevel); //学段流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeachCase.IdStudyLevel); //学段流水号
 }
 }
 
 if (objTeachCaseEN.IsUpdated(conTeachCase.TeachCaseDateIn))
 {
 if (objTeachCaseEN.TeachCaseDateIn !=  null)
 {
 var strTeachCaseDateIn = objTeachCaseEN.TeachCaseDateIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTeachCaseDateIn, conTeachCase.TeachCaseDateIn); //案例入库日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeachCase.TeachCaseDateIn); //案例入库日期
 }
 }
 
 if (objTeachCaseEN.IsUpdated(conTeachCase.IdTeachingPlan))
 {
 if (objTeachCaseEN.IdTeachingPlan  ==  "")
 {
 objTeachCaseEN.IdTeachingPlan = null;
 }
 if (objTeachCaseEN.IdTeachingPlan !=  null)
 {
 var strIdTeachingPlan = objTeachCaseEN.IdTeachingPlan.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdTeachingPlan, conTeachCase.IdTeachingPlan); //教案流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeachCase.IdTeachingPlan); //教案流水号
 }
 }
 
 if (objTeachCaseEN.IsUpdated(conTeachCase.TeachCaseTimeIn))
 {
 if (objTeachCaseEN.TeachCaseTimeIn !=  null)
 {
 var strTeachCaseTimeIn = objTeachCaseEN.TeachCaseTimeIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTeachCaseTimeIn, conTeachCase.TeachCaseTimeIn); //案例入库时间
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeachCase.TeachCaseTimeIn); //案例入库时间
 }
 }
 
 if (objTeachCaseEN.IsUpdated(conTeachCase.WorkUnit))
 {
 if (objTeachCaseEN.WorkUnit !=  null)
 {
 var strWorkUnit = objTeachCaseEN.WorkUnit.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strWorkUnit, conTeachCase.WorkUnit); //工作单位
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeachCase.WorkUnit); //工作单位
 }
 }
 
 if (objTeachCaseEN.IsUpdated(conTeachCase.CDID))
 {
 if (objTeachCaseEN.CDID !=  null)
 {
 var strCDID = objTeachCaseEN.CDID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCDID, conTeachCase.CDID); //光盘编号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeachCase.CDID); //光盘编号
 }
 }
 
 if (objTeachCaseEN.IsUpdated(conTeachCase.BrowseCount))
 {
 if (objTeachCaseEN.BrowseCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objTeachCaseEN.BrowseCount, conTeachCase.BrowseCount); //浏览次数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeachCase.BrowseCount); //浏览次数
 }
 }
 
 if (objTeachCaseEN.IsUpdated(conTeachCase.IsVisible))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objTeachCaseEN.IsVisible == true?"1":"0", conTeachCase.IsVisible); //是否显示
 }
 
 if (objTeachCaseEN.IsUpdated(conTeachCase.IsDualVideo))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objTeachCaseEN.IsDualVideo == true?"1":"0", conTeachCase.IsDualVideo); //是否双视频
 }
 
 if (objTeachCaseEN.IsUpdated(conTeachCase.IdXzCollege))
 {
 if (objTeachCaseEN.IdXzCollege !=  null)
 {
 var strIdXzCollege = objTeachCaseEN.IdXzCollege.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdXzCollege, conTeachCase.IdXzCollege); //学院流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeachCase.IdXzCollege); //学院流水号
 }
 }
 
 if (objTeachCaseEN.IsUpdated(conTeachCase.RecommendedDegreeId))
 {
 if (objTeachCaseEN.RecommendedDegreeId !=  null)
 {
 var strRecommendedDegreeId = objTeachCaseEN.RecommendedDegreeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strRecommendedDegreeId, conTeachCase.RecommendedDegreeId); //推荐度Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeachCase.RecommendedDegreeId); //推荐度Id
 }
 }
 
 if (objTeachCaseEN.IsUpdated(conTeachCase.ftpFileType))
 {
 if (objTeachCaseEN.ftpFileType !=  null)
 {
 var strftpFileType = objTeachCaseEN.ftpFileType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strftpFileType, conTeachCase.ftpFileType); //ftp文件类型
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeachCase.ftpFileType); //ftp文件类型
 }
 }
 
 if (objTeachCaseEN.IsUpdated(conTeachCase.VideoUrl))
 {
 if (objTeachCaseEN.VideoUrl !=  null)
 {
 var strVideoUrl = objTeachCaseEN.VideoUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strVideoUrl, conTeachCase.VideoUrl); //视频Url
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeachCase.VideoUrl); //视频Url
 }
 }
 
 if (objTeachCaseEN.IsUpdated(conTeachCase.VideoPath))
 {
 if (objTeachCaseEN.VideoPath !=  null)
 {
 var strVideoPath = objTeachCaseEN.VideoPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strVideoPath, conTeachCase.VideoPath); //视频目录
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeachCase.VideoPath); //视频目录
 }
 }
 
 if (objTeachCaseEN.IsUpdated(conTeachCase.ResErrMsg))
 {
 if (objTeachCaseEN.ResErrMsg !=  null)
 {
 var strResErrMsg = objTeachCaseEN.ResErrMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strResErrMsg, conTeachCase.ResErrMsg); //资源错误信息
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeachCase.ResErrMsg); //资源错误信息
 }
 }
 
 if (objTeachCaseEN.IsUpdated(conTeachCase.UpdDate))
 {
 if (objTeachCaseEN.UpdDate !=  null)
 {
 var strUpdDate = objTeachCaseEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conTeachCase.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeachCase.UpdDate); //修改日期
 }
 }
 
 if (objTeachCaseEN.IsUpdated(conTeachCase.UpdUserId))
 {
 if (objTeachCaseEN.UpdUserId !=  null)
 {
 var strUpdUserId = objTeachCaseEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUserId, conTeachCase.UpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeachCase.UpdUserId); //修改用户Id
 }
 }
 
 if (objTeachCaseEN.IsUpdated(conTeachCase.Memo))
 {
 if (objTeachCaseEN.Memo !=  null)
 {
 var strMemo = objTeachCaseEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conTeachCase.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeachCase.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where IdTeachCase = '{0}'", objTeachCaseEN.IdTeachCase); 
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
 /// <param name = "strIdTeachCase">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(string strIdTeachCase) 
{
CheckPrimaryKey(strIdTeachCase);
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeachCaseDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 strIdTeachCase,
};
 objSQL.ExecSP("TeachCase_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "strIdTeachCase">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(string strIdTeachCase, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
CheckPrimaryKey(strIdTeachCase);
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeachCaseDA.GetSpecSQLObj();
//删除TeachCase本表中与当前对象有关的记录
strSQL = strSQL + "Delete from TeachCase where IdTeachCase = " + "'"+ strIdTeachCase+"'";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelTeachCase(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeachCaseDA.GetSpecSQLObj();
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
//删除TeachCase本表中与当前对象有关的记录
strSQL = strSQL + "Delete from TeachCase where IdTeachCase in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "strIdTeachCase">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(string strIdTeachCase) 
{
CheckPrimaryKey(strIdTeachCase);
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeachCaseDA.GetSpecSQLObj();
//删除TeachCase本表中与当前对象有关的记录
strSQL = strSQL + "Delete from TeachCase where IdTeachCase = " + "'"+ strIdTeachCase+"'";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelTeachCase(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsTeachCaseDA: DelTeachCase)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeachCaseDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from TeachCase where " + strCondition ;
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
public bool DelTeachCaseWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsTeachCaseDA: DelTeachCaseWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeachCaseDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from TeachCase where " + strCondition ;
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
 /// <param name = "objTeachCaseENS">源对象</param>
 /// <param name = "objTeachCaseENT">目标对象</param>
public void CopyTo(clsTeachCaseEN objTeachCaseENS, clsTeachCaseEN objTeachCaseENT)
{
objTeachCaseENT.IdTeachCase = objTeachCaseENS.IdTeachCase; //案例流水号
objTeachCaseENT.TeachCaseID = objTeachCaseENS.TeachCaseID; //案例ID
objTeachCaseENT.TeachCaseName = objTeachCaseENS.TeachCaseName; //案例名称
objTeachCaseENT.TeachCaseExecutor = objTeachCaseENS.TeachCaseExecutor; //案例执教者
objTeachCaseENT.TeachCaseTheme = objTeachCaseENS.TeachCaseTheme; //案例主题词
objTeachCaseENT.TeachCaseTeachDate = objTeachCaseENS.TeachCaseTeachDate; //案例授课日期
objTeachCaseENT.TeachCaseBG = objTeachCaseENS.TeachCaseBG; //案例背景资料
objTeachCaseENT.IdTeachSkill = objTeachCaseENS.IdTeachSkill; //教学技能流水号
objTeachCaseENT.IdDiscipline = objTeachCaseENS.IdDiscipline; //学科流水号
objTeachCaseENT.IdStudyLevel = objTeachCaseENS.IdStudyLevel; //学段流水号
objTeachCaseENT.TeachCaseDateIn = objTeachCaseENS.TeachCaseDateIn; //案例入库日期
objTeachCaseENT.IdTeachingPlan = objTeachCaseENS.IdTeachingPlan; //教案流水号
objTeachCaseENT.TeachCaseTimeIn = objTeachCaseENS.TeachCaseTimeIn; //案例入库时间
objTeachCaseENT.WorkUnit = objTeachCaseENS.WorkUnit; //工作单位
objTeachCaseENT.CDID = objTeachCaseENS.CDID; //光盘编号
objTeachCaseENT.BrowseCount = objTeachCaseENS.BrowseCount; //浏览次数
objTeachCaseENT.IsVisible = objTeachCaseENS.IsVisible; //是否显示
objTeachCaseENT.IsDualVideo = objTeachCaseENS.IsDualVideo; //是否双视频
objTeachCaseENT.IdXzCollege = objTeachCaseENS.IdXzCollege; //学院流水号
objTeachCaseENT.RecommendedDegreeId = objTeachCaseENS.RecommendedDegreeId; //推荐度Id
objTeachCaseENT.ftpFileType = objTeachCaseENS.ftpFileType; //ftp文件类型
objTeachCaseENT.VideoUrl = objTeachCaseENS.VideoUrl; //视频Url
objTeachCaseENT.VideoPath = objTeachCaseENS.VideoPath; //视频目录
objTeachCaseENT.ResErrMsg = objTeachCaseENS.ResErrMsg; //资源错误信息
objTeachCaseENT.UpdDate = objTeachCaseENS.UpdDate; //修改日期
objTeachCaseENT.UpdUserId = objTeachCaseENS.UpdUserId; //修改用户Id
objTeachCaseENT.Memo = objTeachCaseENS.Memo; //备注
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsTeachCaseEN objTeachCaseEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objTeachCaseEN.TeachCaseID, conTeachCase.TeachCaseID);
clsCheckSql.CheckFieldNotNull(objTeachCaseEN.TeachCaseName, conTeachCase.TeachCaseName);
clsCheckSql.CheckFieldNotNull(objTeachCaseEN.IdTeachSkill, conTeachCase.IdTeachSkill);
clsCheckSql.CheckFieldNotNull(objTeachCaseEN.IdDiscipline, conTeachCase.IdDiscipline);
clsCheckSql.CheckFieldNotNull(objTeachCaseEN.IdStudyLevel, conTeachCase.IdStudyLevel);
clsCheckSql.CheckFieldNotNull(objTeachCaseEN.RecommendedDegreeId, conTeachCase.RecommendedDegreeId);
//检查字段长度
clsCheckSql.CheckFieldLen(objTeachCaseEN.IdTeachCase, 8, conTeachCase.IdTeachCase);
clsCheckSql.CheckFieldLen(objTeachCaseEN.TeachCaseID, 8, conTeachCase.TeachCaseID);
clsCheckSql.CheckFieldLen(objTeachCaseEN.TeachCaseName, 200, conTeachCase.TeachCaseName);
clsCheckSql.CheckFieldLen(objTeachCaseEN.TeachCaseExecutor, 50, conTeachCase.TeachCaseExecutor);
clsCheckSql.CheckFieldLen(objTeachCaseEN.TeachCaseTheme, 200, conTeachCase.TeachCaseTheme);
clsCheckSql.CheckFieldLen(objTeachCaseEN.TeachCaseTeachDate, 8, conTeachCase.TeachCaseTeachDate);
clsCheckSql.CheckFieldLen(objTeachCaseEN.TeachCaseBG, 8000, conTeachCase.TeachCaseBG);
clsCheckSql.CheckFieldLen(objTeachCaseEN.IdTeachSkill, 8, conTeachCase.IdTeachSkill);
clsCheckSql.CheckFieldLen(objTeachCaseEN.IdDiscipline, 4, conTeachCase.IdDiscipline);
clsCheckSql.CheckFieldLen(objTeachCaseEN.IdStudyLevel, 4, conTeachCase.IdStudyLevel);
clsCheckSql.CheckFieldLen(objTeachCaseEN.TeachCaseDateIn, 8, conTeachCase.TeachCaseDateIn);
clsCheckSql.CheckFieldLen(objTeachCaseEN.IdTeachingPlan, 8, conTeachCase.IdTeachingPlan);
clsCheckSql.CheckFieldLen(objTeachCaseEN.TeachCaseTimeIn, 6, conTeachCase.TeachCaseTimeIn);
clsCheckSql.CheckFieldLen(objTeachCaseEN.WorkUnit, 100, conTeachCase.WorkUnit);
clsCheckSql.CheckFieldLen(objTeachCaseEN.CDID, 50, conTeachCase.CDID);
clsCheckSql.CheckFieldLen(objTeachCaseEN.IdXzCollege, 4, conTeachCase.IdXzCollege);
clsCheckSql.CheckFieldLen(objTeachCaseEN.RecommendedDegreeId, 2, conTeachCase.RecommendedDegreeId);
clsCheckSql.CheckFieldLen(objTeachCaseEN.ftpFileType, 30, conTeachCase.ftpFileType);
clsCheckSql.CheckFieldLen(objTeachCaseEN.VideoUrl, 1000, conTeachCase.VideoUrl);
clsCheckSql.CheckFieldLen(objTeachCaseEN.VideoPath, 1000, conTeachCase.VideoPath);
clsCheckSql.CheckFieldLen(objTeachCaseEN.ResErrMsg, 30, conTeachCase.ResErrMsg);
clsCheckSql.CheckFieldLen(objTeachCaseEN.UpdDate, 20, conTeachCase.UpdDate);
clsCheckSql.CheckFieldLen(objTeachCaseEN.UpdUserId, 20, conTeachCase.UpdUserId);
clsCheckSql.CheckFieldLen(objTeachCaseEN.Memo, 1000, conTeachCase.Memo);
//检查字段外键固定长度
clsCheckSql.CheckFieldForeignKey(objTeachCaseEN.IdTeachSkill, 8, conTeachCase.IdTeachSkill);
clsCheckSql.CheckFieldForeignKey(objTeachCaseEN.IdDiscipline, 4, conTeachCase.IdDiscipline);
clsCheckSql.CheckFieldForeignKey(objTeachCaseEN.IdStudyLevel, 4, conTeachCase.IdStudyLevel);
clsCheckSql.CheckFieldForeignKey(objTeachCaseEN.IdTeachingPlan, 8, conTeachCase.IdTeachingPlan);
 objTeachCaseEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsTeachCaseEN objTeachCaseEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objTeachCaseEN.TeachCaseID, 8, conTeachCase.TeachCaseID);
clsCheckSql.CheckFieldLen(objTeachCaseEN.TeachCaseName, 200, conTeachCase.TeachCaseName);
clsCheckSql.CheckFieldLen(objTeachCaseEN.TeachCaseExecutor, 50, conTeachCase.TeachCaseExecutor);
clsCheckSql.CheckFieldLen(objTeachCaseEN.TeachCaseTheme, 200, conTeachCase.TeachCaseTheme);
clsCheckSql.CheckFieldLen(objTeachCaseEN.TeachCaseTeachDate, 8, conTeachCase.TeachCaseTeachDate);
clsCheckSql.CheckFieldLen(objTeachCaseEN.TeachCaseBG, 8000, conTeachCase.TeachCaseBG);
clsCheckSql.CheckFieldLen(objTeachCaseEN.IdTeachSkill, 8, conTeachCase.IdTeachSkill);
clsCheckSql.CheckFieldLen(objTeachCaseEN.IdDiscipline, 4, conTeachCase.IdDiscipline);
clsCheckSql.CheckFieldLen(objTeachCaseEN.IdStudyLevel, 4, conTeachCase.IdStudyLevel);
clsCheckSql.CheckFieldLen(objTeachCaseEN.TeachCaseDateIn, 8, conTeachCase.TeachCaseDateIn);
clsCheckSql.CheckFieldLen(objTeachCaseEN.IdTeachingPlan, 8, conTeachCase.IdTeachingPlan);
clsCheckSql.CheckFieldLen(objTeachCaseEN.TeachCaseTimeIn, 6, conTeachCase.TeachCaseTimeIn);
clsCheckSql.CheckFieldLen(objTeachCaseEN.WorkUnit, 100, conTeachCase.WorkUnit);
clsCheckSql.CheckFieldLen(objTeachCaseEN.CDID, 50, conTeachCase.CDID);
clsCheckSql.CheckFieldLen(objTeachCaseEN.IdXzCollege, 4, conTeachCase.IdXzCollege);
clsCheckSql.CheckFieldLen(objTeachCaseEN.RecommendedDegreeId, 2, conTeachCase.RecommendedDegreeId);
clsCheckSql.CheckFieldLen(objTeachCaseEN.ftpFileType, 30, conTeachCase.ftpFileType);
clsCheckSql.CheckFieldLen(objTeachCaseEN.VideoUrl, 1000, conTeachCase.VideoUrl);
clsCheckSql.CheckFieldLen(objTeachCaseEN.VideoPath, 1000, conTeachCase.VideoPath);
clsCheckSql.CheckFieldLen(objTeachCaseEN.ResErrMsg, 30, conTeachCase.ResErrMsg);
clsCheckSql.CheckFieldLen(objTeachCaseEN.UpdDate, 20, conTeachCase.UpdDate);
clsCheckSql.CheckFieldLen(objTeachCaseEN.UpdUserId, 20, conTeachCase.UpdUserId);
clsCheckSql.CheckFieldLen(objTeachCaseEN.Memo, 1000, conTeachCase.Memo);
//检查外键字段长度
clsCheckSql.CheckFieldForeignKey(objTeachCaseEN.IdTeachSkill, 8, conTeachCase.IdTeachSkill);
clsCheckSql.CheckFieldForeignKey(objTeachCaseEN.IdDiscipline, 4, conTeachCase.IdDiscipline);
clsCheckSql.CheckFieldForeignKey(objTeachCaseEN.IdStudyLevel, 4, conTeachCase.IdStudyLevel);
clsCheckSql.CheckFieldForeignKey(objTeachCaseEN.IdTeachingPlan, 8, conTeachCase.IdTeachingPlan);
 objTeachCaseEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsTeachCaseEN objTeachCaseEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objTeachCaseEN.IdTeachCase, 8, conTeachCase.IdTeachCase);
clsCheckSql.CheckFieldLen(objTeachCaseEN.TeachCaseID, 8, conTeachCase.TeachCaseID);
clsCheckSql.CheckFieldLen(objTeachCaseEN.TeachCaseName, 200, conTeachCase.TeachCaseName);
clsCheckSql.CheckFieldLen(objTeachCaseEN.TeachCaseExecutor, 50, conTeachCase.TeachCaseExecutor);
clsCheckSql.CheckFieldLen(objTeachCaseEN.TeachCaseTheme, 200, conTeachCase.TeachCaseTheme);
clsCheckSql.CheckFieldLen(objTeachCaseEN.TeachCaseTeachDate, 8, conTeachCase.TeachCaseTeachDate);
clsCheckSql.CheckFieldLen(objTeachCaseEN.TeachCaseBG, 8000, conTeachCase.TeachCaseBG);
clsCheckSql.CheckFieldLen(objTeachCaseEN.IdTeachSkill, 8, conTeachCase.IdTeachSkill);
clsCheckSql.CheckFieldLen(objTeachCaseEN.IdDiscipline, 4, conTeachCase.IdDiscipline);
clsCheckSql.CheckFieldLen(objTeachCaseEN.IdStudyLevel, 4, conTeachCase.IdStudyLevel);
clsCheckSql.CheckFieldLen(objTeachCaseEN.TeachCaseDateIn, 8, conTeachCase.TeachCaseDateIn);
clsCheckSql.CheckFieldLen(objTeachCaseEN.IdTeachingPlan, 8, conTeachCase.IdTeachingPlan);
clsCheckSql.CheckFieldLen(objTeachCaseEN.TeachCaseTimeIn, 6, conTeachCase.TeachCaseTimeIn);
clsCheckSql.CheckFieldLen(objTeachCaseEN.WorkUnit, 100, conTeachCase.WorkUnit);
clsCheckSql.CheckFieldLen(objTeachCaseEN.CDID, 50, conTeachCase.CDID);
clsCheckSql.CheckFieldLen(objTeachCaseEN.IdXzCollege, 4, conTeachCase.IdXzCollege);
clsCheckSql.CheckFieldLen(objTeachCaseEN.RecommendedDegreeId, 2, conTeachCase.RecommendedDegreeId);
clsCheckSql.CheckFieldLen(objTeachCaseEN.ftpFileType, 30, conTeachCase.ftpFileType);
clsCheckSql.CheckFieldLen(objTeachCaseEN.VideoUrl, 1000, conTeachCase.VideoUrl);
clsCheckSql.CheckFieldLen(objTeachCaseEN.VideoPath, 1000, conTeachCase.VideoPath);
clsCheckSql.CheckFieldLen(objTeachCaseEN.ResErrMsg, 30, conTeachCase.ResErrMsg);
clsCheckSql.CheckFieldLen(objTeachCaseEN.UpdDate, 20, conTeachCase.UpdDate);
clsCheckSql.CheckFieldLen(objTeachCaseEN.UpdUserId, 20, conTeachCase.UpdUserId);
clsCheckSql.CheckFieldLen(objTeachCaseEN.Memo, 1000, conTeachCase.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objTeachCaseEN.IdTeachCase, conTeachCase.IdTeachCase);
clsCheckSql.CheckSqlInjection4Field(objTeachCaseEN.TeachCaseID, conTeachCase.TeachCaseID);
clsCheckSql.CheckSqlInjection4Field(objTeachCaseEN.TeachCaseName, conTeachCase.TeachCaseName);
clsCheckSql.CheckSqlInjection4Field(objTeachCaseEN.TeachCaseExecutor, conTeachCase.TeachCaseExecutor);
clsCheckSql.CheckSqlInjection4Field(objTeachCaseEN.TeachCaseTheme, conTeachCase.TeachCaseTheme);
clsCheckSql.CheckSqlInjection4Field(objTeachCaseEN.TeachCaseTeachDate, conTeachCase.TeachCaseTeachDate);
clsCheckSql.CheckSqlInjection4Field(objTeachCaseEN.TeachCaseBG, conTeachCase.TeachCaseBG);
clsCheckSql.CheckSqlInjection4Field(objTeachCaseEN.IdTeachSkill, conTeachCase.IdTeachSkill);
clsCheckSql.CheckSqlInjection4Field(objTeachCaseEN.IdDiscipline, conTeachCase.IdDiscipline);
clsCheckSql.CheckSqlInjection4Field(objTeachCaseEN.IdStudyLevel, conTeachCase.IdStudyLevel);
clsCheckSql.CheckSqlInjection4Field(objTeachCaseEN.TeachCaseDateIn, conTeachCase.TeachCaseDateIn);
clsCheckSql.CheckSqlInjection4Field(objTeachCaseEN.IdTeachingPlan, conTeachCase.IdTeachingPlan);
clsCheckSql.CheckSqlInjection4Field(objTeachCaseEN.TeachCaseTimeIn, conTeachCase.TeachCaseTimeIn);
clsCheckSql.CheckSqlInjection4Field(objTeachCaseEN.WorkUnit, conTeachCase.WorkUnit);
clsCheckSql.CheckSqlInjection4Field(objTeachCaseEN.CDID, conTeachCase.CDID);
clsCheckSql.CheckSqlInjection4Field(objTeachCaseEN.IdXzCollege, conTeachCase.IdXzCollege);
clsCheckSql.CheckSqlInjection4Field(objTeachCaseEN.RecommendedDegreeId, conTeachCase.RecommendedDegreeId);
clsCheckSql.CheckSqlInjection4Field(objTeachCaseEN.ftpFileType, conTeachCase.ftpFileType);
clsCheckSql.CheckSqlInjection4Field(objTeachCaseEN.VideoUrl, conTeachCase.VideoUrl);
clsCheckSql.CheckSqlInjection4Field(objTeachCaseEN.VideoPath, conTeachCase.VideoPath);
clsCheckSql.CheckSqlInjection4Field(objTeachCaseEN.ResErrMsg, conTeachCase.ResErrMsg);
clsCheckSql.CheckSqlInjection4Field(objTeachCaseEN.UpdDate, conTeachCase.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objTeachCaseEN.UpdUserId, conTeachCase.UpdUserId);
clsCheckSql.CheckSqlInjection4Field(objTeachCaseEN.Memo, conTeachCase.Memo);
//检查外键字段长度
clsCheckSql.CheckFieldForeignKey(objTeachCaseEN.IdTeachSkill, 8, conTeachCase.IdTeachSkill);
clsCheckSql.CheckFieldForeignKey(objTeachCaseEN.IdDiscipline, 4, conTeachCase.IdDiscipline);
clsCheckSql.CheckFieldForeignKey(objTeachCaseEN.IdStudyLevel, 4, conTeachCase.IdStudyLevel);
clsCheckSql.CheckFieldForeignKey(objTeachCaseEN.IdTeachingPlan, 8, conTeachCase.IdTeachingPlan);
 objTeachCaseEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 /// <summary>
 /// 获取用于绑定下拉框的DataTable,获取两个字段:1、关键字；2、名称字段
 /// (AutoGCLib.clsGeneCodeBase:Gen_4DAL_GetDataTable4DdlBind)
 /// </summary>
 /// <returns>返回用于绑定下拉框的DataTable</returns>
public System.Data.DataTable GetIdTeachCase()
{
//获取某学院所有专业信息
string strSQL = "select IdTeachCase, TeachCaseName from TeachCase ";
 clsSpecSQLforSql mySql = clsTeachCaseDA.GetSpecSQLObj();
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
 objSQL = clsTeachCaseDA.GetSpecSQLObj();
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
 objSQL = clsTeachCaseDA.GetSpecSQLObj();
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
 objSQL = clsTeachCaseDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsTeachCaseEN._CurrTabName);
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
 objSQL = clsTeachCaseDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsTeachCaseEN._CurrTabName, strCondition);
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
 objSQL = clsTeachCaseDA.GetSpecSQLObj();
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
 objSQL = clsTeachCaseDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}