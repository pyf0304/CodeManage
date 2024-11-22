
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsMandarinCaseDA
 表名:MandarinCase(01120466)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:09:33
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:普通话点播(Mandarin)
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
 /// 普通话教学案例(MandarinCase)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsMandarinCaseDA : clsCommBase4DA
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
 return clsMandarinCaseEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsMandarinCaseEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsMandarinCaseEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsMandarinCaseEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsMandarinCaseEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strIdMandarinCase">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strIdMandarinCase)
{
strIdMandarinCase = strIdMandarinCase.Replace("'", "''");
if (strIdMandarinCase.Length > 8)
{
throw new Exception("(errid:Data000001)在表:MandarinCase中,检查关键字,长度不正确!(clsMandarinCaseDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strIdMandarinCase)  ==  true)
{
throw new Exception("(errid:Data000002)在表:MandarinCase中,关键字不能为空 或 null!(clsMandarinCaseDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strIdMandarinCase);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsMandarinCaseDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsMandarinCaseDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsMandarinCaseDA.GetSpecSQLObj();
strSQL = "Select * from MandarinCase where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_MandarinCase(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsMandarinCaseDA: GetDataTable_MandarinCase)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsMandarinCaseDA.GetSpecSQLObj();
strSQL = "Select * from MandarinCase where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsMandarinCaseDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsMandarinCaseDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsMandarinCaseDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsMandarinCaseDA.GetSpecSQLObj();
strSQL = "Select * from MandarinCase where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsMandarinCaseDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsMandarinCaseDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsMandarinCaseDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsMandarinCaseDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from MandarinCase where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from MandarinCase where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsMandarinCaseDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsMandarinCaseDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from MandarinCase where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsMandarinCaseDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsMandarinCaseDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} MandarinCase.* from MandarinCase Left Join {1} on {2} where {3} and MandarinCase.IdMandarinCase not in (Select top {5} MandarinCase.IdMandarinCase from MandarinCase Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from MandarinCase where {1} and IdMandarinCase not in (Select top {2} IdMandarinCase from MandarinCase where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from MandarinCase where {1} and IdMandarinCase not in (Select top {3} IdMandarinCase from MandarinCase where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsMandarinCaseDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsMandarinCaseDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} MandarinCase.* from MandarinCase Left Join {1} on {2} where {3} and MandarinCase.IdMandarinCase not in (Select top {5} MandarinCase.IdMandarinCase from MandarinCase Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from MandarinCase where {1} and IdMandarinCase not in (Select top {2} IdMandarinCase from MandarinCase where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from MandarinCase where {1} and IdMandarinCase not in (Select top {3} IdMandarinCase from MandarinCase where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsMandarinCaseEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsMandarinCaseDA:GetObjLst)", objException.Message));
}
List<clsMandarinCaseEN> arrObjLst = new List<clsMandarinCaseEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsMandarinCaseDA.GetSpecSQLObj();
strSQL = "Select * from MandarinCase where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsMandarinCaseEN objMandarinCaseEN = new clsMandarinCaseEN();
try
{
objMandarinCaseEN.IdMandarinCase = objRow[conMandarinCase.IdMandarinCase].ToString().Trim(); //普通话案例流水号
objMandarinCaseEN.MandarinCaseID = objRow[conMandarinCase.MandarinCaseID].ToString().Trim(); //普通话教学案例ID
objMandarinCaseEN.MandarinCaseName = objRow[conMandarinCase.MandarinCaseName].ToString().Trim(); //普通话教学案例名称
objMandarinCaseEN.IdDiscipline = objRow[conMandarinCase.IdDiscipline].ToString().Trim(); //学科流水号
objMandarinCaseEN.IdStudyLevel = objRow[conMandarinCase.IdStudyLevel].ToString().Trim(); //学段流水号
objMandarinCaseEN.MandarinCaseTheme = objRow[conMandarinCase.MandarinCaseTheme] == DBNull.Value ? null : objRow[conMandarinCase.MandarinCaseTheme].ToString().Trim(); //普通话教学案例主题词
objMandarinCaseEN.MandarinCaseDate = objRow[conMandarinCase.MandarinCaseDate] == DBNull.Value ? null : objRow[conMandarinCase.MandarinCaseDate].ToString().Trim(); //普通话教学日期
objMandarinCaseEN.MandarinCaseTime = objRow[conMandarinCase.MandarinCaseTime] == DBNull.Value ? null : objRow[conMandarinCase.MandarinCaseTime].ToString().Trim(); //普通话教学时间
objMandarinCaseEN.MandarinCaseDateIn = objRow[conMandarinCase.MandarinCaseDateIn] == DBNull.Value ? null : objRow[conMandarinCase.MandarinCaseDateIn].ToString().Trim(); //案例入库日期
objMandarinCaseEN.MandarinCaseTimeIn = objRow[conMandarinCase.MandarinCaseTimeIn] == DBNull.Value ? null : objRow[conMandarinCase.MandarinCaseTimeIn].ToString().Trim(); //案例入库时间
objMandarinCaseEN.IdTeachingPlan = objRow[conMandarinCase.IdTeachingPlan].ToString().Trim(); //教案流水号
objMandarinCaseEN.IdSenateGaugeVersion = objRow[conMandarinCase.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objMandarinCaseEN.CaseLevelId = objRow[conMandarinCase.CaseLevelId] == DBNull.Value ? null : objRow[conMandarinCase.CaseLevelId].ToString().Trim(); //课例等级Id
objMandarinCaseEN.IsNeedGeneWord = TransNullToBool(objRow[conMandarinCase.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objMandarinCaseEN.DocFile = objRow[conMandarinCase.DocFile] == DBNull.Value ? null : objRow[conMandarinCase.DocFile].ToString().Trim(); //生成的Word文件名
objMandarinCaseEN.WordCreateDate = objRow[conMandarinCase.WordCreateDate] == DBNull.Value ? null : objRow[conMandarinCase.WordCreateDate].ToString().Trim(); //Word生成日期
objMandarinCaseEN.BrowseCount = objRow[conMandarinCase.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conMandarinCase.BrowseCount].ToString().Trim()); //浏览次数
objMandarinCaseEN.IsVisible = TransNullToBool(objRow[conMandarinCase.IsVisible].ToString().Trim()); //是否显示
objMandarinCaseEN.OwnerId = objRow[conMandarinCase.OwnerId].ToString().Trim(); //拥有者Id
objMandarinCaseEN.IsDualVideo = TransNullToBool(objRow[conMandarinCase.IsDualVideo].ToString().Trim()); //是否双视频
objMandarinCaseEN.IdMandarinCaseType = objRow[conMandarinCase.IdMandarinCaseType] == DBNull.Value ? null : objRow[conMandarinCase.IdMandarinCaseType].ToString().Trim(); //普通话案例类型流水号
objMandarinCaseEN.UserTypeId = objRow[conMandarinCase.UserTypeId] == DBNull.Value ? null : objRow[conMandarinCase.UserTypeId].ToString().Trim(); //用户类型Id
objMandarinCaseEN.RecommendedDegreeId = objRow[conMandarinCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objMandarinCaseEN.ftpFileType = objRow[conMandarinCase.ftpFileType] == DBNull.Value ? null : objRow[conMandarinCase.ftpFileType].ToString().Trim(); //ftp文件类型
objMandarinCaseEN.VideoUrl = objRow[conMandarinCase.VideoUrl] == DBNull.Value ? null : objRow[conMandarinCase.VideoUrl].ToString().Trim(); //视频Url
objMandarinCaseEN.VideoPath = objRow[conMandarinCase.VideoPath] == DBNull.Value ? null : objRow[conMandarinCase.VideoPath].ToString().Trim(); //视频目录
objMandarinCaseEN.ResErrMsg = objRow[conMandarinCase.ResErrMsg] == DBNull.Value ? null : objRow[conMandarinCase.ResErrMsg].ToString().Trim(); //资源错误信息
objMandarinCaseEN.UpdDate = objRow[conMandarinCase.UpdDate] == DBNull.Value ? null : objRow[conMandarinCase.UpdDate].ToString().Trim(); //修改日期
objMandarinCaseEN.UpdUserId = objRow[conMandarinCase.UpdUserId] == DBNull.Value ? null : objRow[conMandarinCase.UpdUserId].ToString().Trim(); //修改用户Id
objMandarinCaseEN.Memo = objRow[conMandarinCase.Memo] == DBNull.Value ? null : objRow[conMandarinCase.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsMandarinCaseDA: GetObjLst)", objException.Message));
}
objMandarinCaseEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objMandarinCaseEN);
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
public List<clsMandarinCaseEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsMandarinCaseDA:GetObjLstByTabName)", objException.Message));
}
List<clsMandarinCaseEN> arrObjLst = new List<clsMandarinCaseEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsMandarinCaseDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsMandarinCaseEN objMandarinCaseEN = new clsMandarinCaseEN();
try
{
objMandarinCaseEN.IdMandarinCase = objRow[conMandarinCase.IdMandarinCase].ToString().Trim(); //普通话案例流水号
objMandarinCaseEN.MandarinCaseID = objRow[conMandarinCase.MandarinCaseID].ToString().Trim(); //普通话教学案例ID
objMandarinCaseEN.MandarinCaseName = objRow[conMandarinCase.MandarinCaseName].ToString().Trim(); //普通话教学案例名称
objMandarinCaseEN.IdDiscipline = objRow[conMandarinCase.IdDiscipline].ToString().Trim(); //学科流水号
objMandarinCaseEN.IdStudyLevel = objRow[conMandarinCase.IdStudyLevel].ToString().Trim(); //学段流水号
objMandarinCaseEN.MandarinCaseTheme = objRow[conMandarinCase.MandarinCaseTheme] == DBNull.Value ? null : objRow[conMandarinCase.MandarinCaseTheme].ToString().Trim(); //普通话教学案例主题词
objMandarinCaseEN.MandarinCaseDate = objRow[conMandarinCase.MandarinCaseDate] == DBNull.Value ? null : objRow[conMandarinCase.MandarinCaseDate].ToString().Trim(); //普通话教学日期
objMandarinCaseEN.MandarinCaseTime = objRow[conMandarinCase.MandarinCaseTime] == DBNull.Value ? null : objRow[conMandarinCase.MandarinCaseTime].ToString().Trim(); //普通话教学时间
objMandarinCaseEN.MandarinCaseDateIn = objRow[conMandarinCase.MandarinCaseDateIn] == DBNull.Value ? null : objRow[conMandarinCase.MandarinCaseDateIn].ToString().Trim(); //案例入库日期
objMandarinCaseEN.MandarinCaseTimeIn = objRow[conMandarinCase.MandarinCaseTimeIn] == DBNull.Value ? null : objRow[conMandarinCase.MandarinCaseTimeIn].ToString().Trim(); //案例入库时间
objMandarinCaseEN.IdTeachingPlan = objRow[conMandarinCase.IdTeachingPlan].ToString().Trim(); //教案流水号
objMandarinCaseEN.IdSenateGaugeVersion = objRow[conMandarinCase.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objMandarinCaseEN.CaseLevelId = objRow[conMandarinCase.CaseLevelId] == DBNull.Value ? null : objRow[conMandarinCase.CaseLevelId].ToString().Trim(); //课例等级Id
objMandarinCaseEN.IsNeedGeneWord = TransNullToBool(objRow[conMandarinCase.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objMandarinCaseEN.DocFile = objRow[conMandarinCase.DocFile] == DBNull.Value ? null : objRow[conMandarinCase.DocFile].ToString().Trim(); //生成的Word文件名
objMandarinCaseEN.WordCreateDate = objRow[conMandarinCase.WordCreateDate] == DBNull.Value ? null : objRow[conMandarinCase.WordCreateDate].ToString().Trim(); //Word生成日期
objMandarinCaseEN.BrowseCount = objRow[conMandarinCase.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conMandarinCase.BrowseCount].ToString().Trim()); //浏览次数
objMandarinCaseEN.IsVisible = TransNullToBool(objRow[conMandarinCase.IsVisible].ToString().Trim()); //是否显示
objMandarinCaseEN.OwnerId = objRow[conMandarinCase.OwnerId].ToString().Trim(); //拥有者Id
objMandarinCaseEN.IsDualVideo = TransNullToBool(objRow[conMandarinCase.IsDualVideo].ToString().Trim()); //是否双视频
objMandarinCaseEN.IdMandarinCaseType = objRow[conMandarinCase.IdMandarinCaseType] == DBNull.Value ? null : objRow[conMandarinCase.IdMandarinCaseType].ToString().Trim(); //普通话案例类型流水号
objMandarinCaseEN.UserTypeId = objRow[conMandarinCase.UserTypeId] == DBNull.Value ? null : objRow[conMandarinCase.UserTypeId].ToString().Trim(); //用户类型Id
objMandarinCaseEN.RecommendedDegreeId = objRow[conMandarinCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objMandarinCaseEN.ftpFileType = objRow[conMandarinCase.ftpFileType] == DBNull.Value ? null : objRow[conMandarinCase.ftpFileType].ToString().Trim(); //ftp文件类型
objMandarinCaseEN.VideoUrl = objRow[conMandarinCase.VideoUrl] == DBNull.Value ? null : objRow[conMandarinCase.VideoUrl].ToString().Trim(); //视频Url
objMandarinCaseEN.VideoPath = objRow[conMandarinCase.VideoPath] == DBNull.Value ? null : objRow[conMandarinCase.VideoPath].ToString().Trim(); //视频目录
objMandarinCaseEN.ResErrMsg = objRow[conMandarinCase.ResErrMsg] == DBNull.Value ? null : objRow[conMandarinCase.ResErrMsg].ToString().Trim(); //资源错误信息
objMandarinCaseEN.UpdDate = objRow[conMandarinCase.UpdDate] == DBNull.Value ? null : objRow[conMandarinCase.UpdDate].ToString().Trim(); //修改日期
objMandarinCaseEN.UpdUserId = objRow[conMandarinCase.UpdUserId] == DBNull.Value ? null : objRow[conMandarinCase.UpdUserId].ToString().Trim(); //修改用户Id
objMandarinCaseEN.Memo = objRow[conMandarinCase.Memo] == DBNull.Value ? null : objRow[conMandarinCase.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsMandarinCaseDA: GetObjLst)", objException.Message));
}
objMandarinCaseEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objMandarinCaseEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objMandarinCaseEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetMandarinCase(ref clsMandarinCaseEN objMandarinCaseEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsMandarinCaseDA.GetSpecSQLObj();
strSQL = "Select * from MandarinCase where IdMandarinCase = " + "'"+ objMandarinCaseEN.IdMandarinCase+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objMandarinCaseEN.IdMandarinCase = objDT.Rows[0][conMandarinCase.IdMandarinCase].ToString().Trim(); //普通话案例流水号(字段类型:char,字段长度:8,是否可空:False)
 objMandarinCaseEN.MandarinCaseID = objDT.Rows[0][conMandarinCase.MandarinCaseID].ToString().Trim(); //普通话教学案例ID(字段类型:char,字段长度:8,是否可空:False)
 objMandarinCaseEN.MandarinCaseName = objDT.Rows[0][conMandarinCase.MandarinCaseName].ToString().Trim(); //普通话教学案例名称(字段类型:varchar,字段长度:100,是否可空:False)
 objMandarinCaseEN.IdDiscipline = objDT.Rows[0][conMandarinCase.IdDiscipline].ToString().Trim(); //学科流水号(字段类型:char,字段长度:4,是否可空:False)
 objMandarinCaseEN.IdStudyLevel = objDT.Rows[0][conMandarinCase.IdStudyLevel].ToString().Trim(); //学段流水号(字段类型:char,字段长度:4,是否可空:True)
 objMandarinCaseEN.MandarinCaseTheme = objDT.Rows[0][conMandarinCase.MandarinCaseTheme].ToString().Trim(); //普通话教学案例主题词(字段类型:varchar,字段长度:200,是否可空:True)
 objMandarinCaseEN.MandarinCaseDate = objDT.Rows[0][conMandarinCase.MandarinCaseDate].ToString().Trim(); //普通话教学日期(字段类型:char,字段长度:8,是否可空:True)
 objMandarinCaseEN.MandarinCaseTime = objDT.Rows[0][conMandarinCase.MandarinCaseTime].ToString().Trim(); //普通话教学时间(字段类型:char,字段长度:6,是否可空:True)
 objMandarinCaseEN.MandarinCaseDateIn = objDT.Rows[0][conMandarinCase.MandarinCaseDateIn].ToString().Trim(); //案例入库日期(字段类型:char,字段长度:8,是否可空:True)
 objMandarinCaseEN.MandarinCaseTimeIn = objDT.Rows[0][conMandarinCase.MandarinCaseTimeIn].ToString().Trim(); //案例入库时间(字段类型:char,字段长度:6,是否可空:True)
 objMandarinCaseEN.IdTeachingPlan = objDT.Rows[0][conMandarinCase.IdTeachingPlan].ToString().Trim(); //教案流水号(字段类型:char,字段长度:8,是否可空:False)
 objMandarinCaseEN.IdSenateGaugeVersion = objDT.Rows[0][conMandarinCase.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号(字段类型:char,字段长度:4,是否可空:False)
 objMandarinCaseEN.CaseLevelId = objDT.Rows[0][conMandarinCase.CaseLevelId].ToString().Trim(); //课例等级Id(字段类型:char,字段长度:2,是否可空:True)
 objMandarinCaseEN.IsNeedGeneWord = TransNullToBool(objDT.Rows[0][conMandarinCase.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word(字段类型:bit,字段长度:1,是否可空:True)
 objMandarinCaseEN.DocFile = objDT.Rows[0][conMandarinCase.DocFile].ToString().Trim(); //生成的Word文件名(字段类型:varchar,字段长度:200,是否可空:True)
 objMandarinCaseEN.WordCreateDate = objDT.Rows[0][conMandarinCase.WordCreateDate].ToString().Trim(); //Word生成日期(字段类型:varchar,字段长度:14,是否可空:True)
 objMandarinCaseEN.BrowseCount = TransNullToInt(objDT.Rows[0][conMandarinCase.BrowseCount].ToString().Trim()); //浏览次数(字段类型:int,字段长度:4,是否可空:True)
 objMandarinCaseEN.IsVisible = TransNullToBool(objDT.Rows[0][conMandarinCase.IsVisible].ToString().Trim()); //是否显示(字段类型:bit,字段长度:1,是否可空:True)
 objMandarinCaseEN.OwnerId = objDT.Rows[0][conMandarinCase.OwnerId].ToString().Trim(); //拥有者Id(字段类型:varchar,字段长度:20,是否可空:False)
 objMandarinCaseEN.IsDualVideo = TransNullToBool(objDT.Rows[0][conMandarinCase.IsDualVideo].ToString().Trim()); //是否双视频(字段类型:bit,字段长度:1,是否可空:False)
 objMandarinCaseEN.IdMandarinCaseType = objDT.Rows[0][conMandarinCase.IdMandarinCaseType].ToString().Trim(); //普通话案例类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objMandarinCaseEN.UserTypeId = objDT.Rows[0][conMandarinCase.UserTypeId].ToString().Trim(); //用户类型Id(字段类型:char,字段长度:2,是否可空:True)
 objMandarinCaseEN.RecommendedDegreeId = objDT.Rows[0][conMandarinCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id(字段类型:char,字段长度:2,是否可空:False)
 objMandarinCaseEN.ftpFileType = objDT.Rows[0][conMandarinCase.ftpFileType].ToString().Trim(); //ftp文件类型(字段类型:varchar,字段长度:30,是否可空:True)
 objMandarinCaseEN.VideoUrl = objDT.Rows[0][conMandarinCase.VideoUrl].ToString().Trim(); //视频Url(字段类型:varchar,字段长度:1000,是否可空:True)
 objMandarinCaseEN.VideoPath = objDT.Rows[0][conMandarinCase.VideoPath].ToString().Trim(); //视频目录(字段类型:varchar,字段长度:1000,是否可空:True)
 objMandarinCaseEN.ResErrMsg = objDT.Rows[0][conMandarinCase.ResErrMsg].ToString().Trim(); //资源错误信息(字段类型:varchar,字段长度:30,是否可空:True)
 objMandarinCaseEN.UpdDate = objDT.Rows[0][conMandarinCase.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objMandarinCaseEN.UpdUserId = objDT.Rows[0][conMandarinCase.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:True)
 objMandarinCaseEN.Memo = objDT.Rows[0][conMandarinCase.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsMandarinCaseDA: GetMandarinCase)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strIdMandarinCase">表关键字</param>
 /// <returns>表对象</returns>
public clsMandarinCaseEN GetObjByIdMandarinCase(string strIdMandarinCase)
{
CheckPrimaryKey(strIdMandarinCase);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsMandarinCaseDA.GetSpecSQLObj();
strSQL = "Select * from MandarinCase where IdMandarinCase = " + "'"+ strIdMandarinCase+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsMandarinCaseEN objMandarinCaseEN = new clsMandarinCaseEN();
try
{
 objMandarinCaseEN.IdMandarinCase = objRow[conMandarinCase.IdMandarinCase].ToString().Trim(); //普通话案例流水号(字段类型:char,字段长度:8,是否可空:False)
 objMandarinCaseEN.MandarinCaseID = objRow[conMandarinCase.MandarinCaseID].ToString().Trim(); //普通话教学案例ID(字段类型:char,字段长度:8,是否可空:False)
 objMandarinCaseEN.MandarinCaseName = objRow[conMandarinCase.MandarinCaseName].ToString().Trim(); //普通话教学案例名称(字段类型:varchar,字段长度:100,是否可空:False)
 objMandarinCaseEN.IdDiscipline = objRow[conMandarinCase.IdDiscipline].ToString().Trim(); //学科流水号(字段类型:char,字段长度:4,是否可空:False)
 objMandarinCaseEN.IdStudyLevel = objRow[conMandarinCase.IdStudyLevel].ToString().Trim(); //学段流水号(字段类型:char,字段长度:4,是否可空:True)
 objMandarinCaseEN.MandarinCaseTheme = objRow[conMandarinCase.MandarinCaseTheme] == DBNull.Value ? null : objRow[conMandarinCase.MandarinCaseTheme].ToString().Trim(); //普通话教学案例主题词(字段类型:varchar,字段长度:200,是否可空:True)
 objMandarinCaseEN.MandarinCaseDate = objRow[conMandarinCase.MandarinCaseDate] == DBNull.Value ? null : objRow[conMandarinCase.MandarinCaseDate].ToString().Trim(); //普通话教学日期(字段类型:char,字段长度:8,是否可空:True)
 objMandarinCaseEN.MandarinCaseTime = objRow[conMandarinCase.MandarinCaseTime] == DBNull.Value ? null : objRow[conMandarinCase.MandarinCaseTime].ToString().Trim(); //普通话教学时间(字段类型:char,字段长度:6,是否可空:True)
 objMandarinCaseEN.MandarinCaseDateIn = objRow[conMandarinCase.MandarinCaseDateIn] == DBNull.Value ? null : objRow[conMandarinCase.MandarinCaseDateIn].ToString().Trim(); //案例入库日期(字段类型:char,字段长度:8,是否可空:True)
 objMandarinCaseEN.MandarinCaseTimeIn = objRow[conMandarinCase.MandarinCaseTimeIn] == DBNull.Value ? null : objRow[conMandarinCase.MandarinCaseTimeIn].ToString().Trim(); //案例入库时间(字段类型:char,字段长度:6,是否可空:True)
 objMandarinCaseEN.IdTeachingPlan = objRow[conMandarinCase.IdTeachingPlan].ToString().Trim(); //教案流水号(字段类型:char,字段长度:8,是否可空:False)
 objMandarinCaseEN.IdSenateGaugeVersion = objRow[conMandarinCase.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号(字段类型:char,字段长度:4,是否可空:False)
 objMandarinCaseEN.CaseLevelId = objRow[conMandarinCase.CaseLevelId] == DBNull.Value ? null : objRow[conMandarinCase.CaseLevelId].ToString().Trim(); //课例等级Id(字段类型:char,字段长度:2,是否可空:True)
 objMandarinCaseEN.IsNeedGeneWord = clsEntityBase2.TransNullToBool_S(objRow[conMandarinCase.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word(字段类型:bit,字段长度:1,是否可空:True)
 objMandarinCaseEN.DocFile = objRow[conMandarinCase.DocFile] == DBNull.Value ? null : objRow[conMandarinCase.DocFile].ToString().Trim(); //生成的Word文件名(字段类型:varchar,字段长度:200,是否可空:True)
 objMandarinCaseEN.WordCreateDate = objRow[conMandarinCase.WordCreateDate] == DBNull.Value ? null : objRow[conMandarinCase.WordCreateDate].ToString().Trim(); //Word生成日期(字段类型:varchar,字段长度:14,是否可空:True)
 objMandarinCaseEN.BrowseCount = objRow[conMandarinCase.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conMandarinCase.BrowseCount].ToString().Trim()); //浏览次数(字段类型:int,字段长度:4,是否可空:True)
 objMandarinCaseEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conMandarinCase.IsVisible].ToString().Trim()); //是否显示(字段类型:bit,字段长度:1,是否可空:True)
 objMandarinCaseEN.OwnerId = objRow[conMandarinCase.OwnerId].ToString().Trim(); //拥有者Id(字段类型:varchar,字段长度:20,是否可空:False)
 objMandarinCaseEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[conMandarinCase.IsDualVideo].ToString().Trim()); //是否双视频(字段类型:bit,字段长度:1,是否可空:False)
 objMandarinCaseEN.IdMandarinCaseType = objRow[conMandarinCase.IdMandarinCaseType] == DBNull.Value ? null : objRow[conMandarinCase.IdMandarinCaseType].ToString().Trim(); //普通话案例类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objMandarinCaseEN.UserTypeId = objRow[conMandarinCase.UserTypeId] == DBNull.Value ? null : objRow[conMandarinCase.UserTypeId].ToString().Trim(); //用户类型Id(字段类型:char,字段长度:2,是否可空:True)
 objMandarinCaseEN.RecommendedDegreeId = objRow[conMandarinCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id(字段类型:char,字段长度:2,是否可空:False)
 objMandarinCaseEN.ftpFileType = objRow[conMandarinCase.ftpFileType] == DBNull.Value ? null : objRow[conMandarinCase.ftpFileType].ToString().Trim(); //ftp文件类型(字段类型:varchar,字段长度:30,是否可空:True)
 objMandarinCaseEN.VideoUrl = objRow[conMandarinCase.VideoUrl] == DBNull.Value ? null : objRow[conMandarinCase.VideoUrl].ToString().Trim(); //视频Url(字段类型:varchar,字段长度:1000,是否可空:True)
 objMandarinCaseEN.VideoPath = objRow[conMandarinCase.VideoPath] == DBNull.Value ? null : objRow[conMandarinCase.VideoPath].ToString().Trim(); //视频目录(字段类型:varchar,字段长度:1000,是否可空:True)
 objMandarinCaseEN.ResErrMsg = objRow[conMandarinCase.ResErrMsg] == DBNull.Value ? null : objRow[conMandarinCase.ResErrMsg].ToString().Trim(); //资源错误信息(字段类型:varchar,字段长度:30,是否可空:True)
 objMandarinCaseEN.UpdDate = objRow[conMandarinCase.UpdDate] == DBNull.Value ? null : objRow[conMandarinCase.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objMandarinCaseEN.UpdUserId = objRow[conMandarinCase.UpdUserId] == DBNull.Value ? null : objRow[conMandarinCase.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:True)
 objMandarinCaseEN.Memo = objRow[conMandarinCase.Memo] == DBNull.Value ? null : objRow[conMandarinCase.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsMandarinCaseDA: GetObjByIdMandarinCase)", objException.Message));
}
return objMandarinCaseEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsMandarinCaseEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsMandarinCaseDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsMandarinCaseDA.GetSpecSQLObj();
strSQL = "Select * from MandarinCase where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsMandarinCaseEN objMandarinCaseEN = new clsMandarinCaseEN()
{
IdMandarinCase = objRow[conMandarinCase.IdMandarinCase].ToString().Trim(), //普通话案例流水号
MandarinCaseID = objRow[conMandarinCase.MandarinCaseID].ToString().Trim(), //普通话教学案例ID
MandarinCaseName = objRow[conMandarinCase.MandarinCaseName].ToString().Trim(), //普通话教学案例名称
IdDiscipline = objRow[conMandarinCase.IdDiscipline].ToString().Trim(), //学科流水号
IdStudyLevel = objRow[conMandarinCase.IdStudyLevel].ToString().Trim(), //学段流水号
MandarinCaseTheme = objRow[conMandarinCase.MandarinCaseTheme] == DBNull.Value ? null : objRow[conMandarinCase.MandarinCaseTheme].ToString().Trim(), //普通话教学案例主题词
MandarinCaseDate = objRow[conMandarinCase.MandarinCaseDate] == DBNull.Value ? null : objRow[conMandarinCase.MandarinCaseDate].ToString().Trim(), //普通话教学日期
MandarinCaseTime = objRow[conMandarinCase.MandarinCaseTime] == DBNull.Value ? null : objRow[conMandarinCase.MandarinCaseTime].ToString().Trim(), //普通话教学时间
MandarinCaseDateIn = objRow[conMandarinCase.MandarinCaseDateIn] == DBNull.Value ? null : objRow[conMandarinCase.MandarinCaseDateIn].ToString().Trim(), //案例入库日期
MandarinCaseTimeIn = objRow[conMandarinCase.MandarinCaseTimeIn] == DBNull.Value ? null : objRow[conMandarinCase.MandarinCaseTimeIn].ToString().Trim(), //案例入库时间
IdTeachingPlan = objRow[conMandarinCase.IdTeachingPlan].ToString().Trim(), //教案流水号
IdSenateGaugeVersion = objRow[conMandarinCase.IdSenateGaugeVersion].ToString().Trim(), //评价量表版本流水号
CaseLevelId = objRow[conMandarinCase.CaseLevelId] == DBNull.Value ? null : objRow[conMandarinCase.CaseLevelId].ToString().Trim(), //课例等级Id
IsNeedGeneWord = TransNullToBool(objRow[conMandarinCase.IsNeedGeneWord].ToString().Trim()), //是否需要生成Word
DocFile = objRow[conMandarinCase.DocFile] == DBNull.Value ? null : objRow[conMandarinCase.DocFile].ToString().Trim(), //生成的Word文件名
WordCreateDate = objRow[conMandarinCase.WordCreateDate] == DBNull.Value ? null : objRow[conMandarinCase.WordCreateDate].ToString().Trim(), //Word生成日期
BrowseCount = objRow[conMandarinCase.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conMandarinCase.BrowseCount].ToString().Trim()), //浏览次数
IsVisible = TransNullToBool(objRow[conMandarinCase.IsVisible].ToString().Trim()), //是否显示
OwnerId = objRow[conMandarinCase.OwnerId].ToString().Trim(), //拥有者Id
IsDualVideo = TransNullToBool(objRow[conMandarinCase.IsDualVideo].ToString().Trim()), //是否双视频
IdMandarinCaseType = objRow[conMandarinCase.IdMandarinCaseType] == DBNull.Value ? null : objRow[conMandarinCase.IdMandarinCaseType].ToString().Trim(), //普通话案例类型流水号
UserTypeId = objRow[conMandarinCase.UserTypeId] == DBNull.Value ? null : objRow[conMandarinCase.UserTypeId].ToString().Trim(), //用户类型Id
RecommendedDegreeId = objRow[conMandarinCase.RecommendedDegreeId].ToString().Trim(), //推荐度Id
ftpFileType = objRow[conMandarinCase.ftpFileType] == DBNull.Value ? null : objRow[conMandarinCase.ftpFileType].ToString().Trim(), //ftp文件类型
VideoUrl = objRow[conMandarinCase.VideoUrl] == DBNull.Value ? null : objRow[conMandarinCase.VideoUrl].ToString().Trim(), //视频Url
VideoPath = objRow[conMandarinCase.VideoPath] == DBNull.Value ? null : objRow[conMandarinCase.VideoPath].ToString().Trim(), //视频目录
ResErrMsg = objRow[conMandarinCase.ResErrMsg] == DBNull.Value ? null : objRow[conMandarinCase.ResErrMsg].ToString().Trim(), //资源错误信息
UpdDate = objRow[conMandarinCase.UpdDate] == DBNull.Value ? null : objRow[conMandarinCase.UpdDate].ToString().Trim(), //修改日期
UpdUserId = objRow[conMandarinCase.UpdUserId] == DBNull.Value ? null : objRow[conMandarinCase.UpdUserId].ToString().Trim(), //修改用户Id
Memo = objRow[conMandarinCase.Memo] == DBNull.Value ? null : objRow[conMandarinCase.Memo].ToString().Trim() //备注
};
objMandarinCaseEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objMandarinCaseEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsMandarinCaseDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsMandarinCaseEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsMandarinCaseEN objMandarinCaseEN = new clsMandarinCaseEN();
try
{
objMandarinCaseEN.IdMandarinCase = objRow[conMandarinCase.IdMandarinCase].ToString().Trim(); //普通话案例流水号
objMandarinCaseEN.MandarinCaseID = objRow[conMandarinCase.MandarinCaseID].ToString().Trim(); //普通话教学案例ID
objMandarinCaseEN.MandarinCaseName = objRow[conMandarinCase.MandarinCaseName].ToString().Trim(); //普通话教学案例名称
objMandarinCaseEN.IdDiscipline = objRow[conMandarinCase.IdDiscipline].ToString().Trim(); //学科流水号
objMandarinCaseEN.IdStudyLevel = objRow[conMandarinCase.IdStudyLevel].ToString().Trim(); //学段流水号
objMandarinCaseEN.MandarinCaseTheme = objRow[conMandarinCase.MandarinCaseTheme] == DBNull.Value ? null : objRow[conMandarinCase.MandarinCaseTheme].ToString().Trim(); //普通话教学案例主题词
objMandarinCaseEN.MandarinCaseDate = objRow[conMandarinCase.MandarinCaseDate] == DBNull.Value ? null : objRow[conMandarinCase.MandarinCaseDate].ToString().Trim(); //普通话教学日期
objMandarinCaseEN.MandarinCaseTime = objRow[conMandarinCase.MandarinCaseTime] == DBNull.Value ? null : objRow[conMandarinCase.MandarinCaseTime].ToString().Trim(); //普通话教学时间
objMandarinCaseEN.MandarinCaseDateIn = objRow[conMandarinCase.MandarinCaseDateIn] == DBNull.Value ? null : objRow[conMandarinCase.MandarinCaseDateIn].ToString().Trim(); //案例入库日期
objMandarinCaseEN.MandarinCaseTimeIn = objRow[conMandarinCase.MandarinCaseTimeIn] == DBNull.Value ? null : objRow[conMandarinCase.MandarinCaseTimeIn].ToString().Trim(); //案例入库时间
objMandarinCaseEN.IdTeachingPlan = objRow[conMandarinCase.IdTeachingPlan].ToString().Trim(); //教案流水号
objMandarinCaseEN.IdSenateGaugeVersion = objRow[conMandarinCase.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objMandarinCaseEN.CaseLevelId = objRow[conMandarinCase.CaseLevelId] == DBNull.Value ? null : objRow[conMandarinCase.CaseLevelId].ToString().Trim(); //课例等级Id
objMandarinCaseEN.IsNeedGeneWord = TransNullToBool(objRow[conMandarinCase.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objMandarinCaseEN.DocFile = objRow[conMandarinCase.DocFile] == DBNull.Value ? null : objRow[conMandarinCase.DocFile].ToString().Trim(); //生成的Word文件名
objMandarinCaseEN.WordCreateDate = objRow[conMandarinCase.WordCreateDate] == DBNull.Value ? null : objRow[conMandarinCase.WordCreateDate].ToString().Trim(); //Word生成日期
objMandarinCaseEN.BrowseCount = objRow[conMandarinCase.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conMandarinCase.BrowseCount].ToString().Trim()); //浏览次数
objMandarinCaseEN.IsVisible = TransNullToBool(objRow[conMandarinCase.IsVisible].ToString().Trim()); //是否显示
objMandarinCaseEN.OwnerId = objRow[conMandarinCase.OwnerId].ToString().Trim(); //拥有者Id
objMandarinCaseEN.IsDualVideo = TransNullToBool(objRow[conMandarinCase.IsDualVideo].ToString().Trim()); //是否双视频
objMandarinCaseEN.IdMandarinCaseType = objRow[conMandarinCase.IdMandarinCaseType] == DBNull.Value ? null : objRow[conMandarinCase.IdMandarinCaseType].ToString().Trim(); //普通话案例类型流水号
objMandarinCaseEN.UserTypeId = objRow[conMandarinCase.UserTypeId] == DBNull.Value ? null : objRow[conMandarinCase.UserTypeId].ToString().Trim(); //用户类型Id
objMandarinCaseEN.RecommendedDegreeId = objRow[conMandarinCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objMandarinCaseEN.ftpFileType = objRow[conMandarinCase.ftpFileType] == DBNull.Value ? null : objRow[conMandarinCase.ftpFileType].ToString().Trim(); //ftp文件类型
objMandarinCaseEN.VideoUrl = objRow[conMandarinCase.VideoUrl] == DBNull.Value ? null : objRow[conMandarinCase.VideoUrl].ToString().Trim(); //视频Url
objMandarinCaseEN.VideoPath = objRow[conMandarinCase.VideoPath] == DBNull.Value ? null : objRow[conMandarinCase.VideoPath].ToString().Trim(); //视频目录
objMandarinCaseEN.ResErrMsg = objRow[conMandarinCase.ResErrMsg] == DBNull.Value ? null : objRow[conMandarinCase.ResErrMsg].ToString().Trim(); //资源错误信息
objMandarinCaseEN.UpdDate = objRow[conMandarinCase.UpdDate] == DBNull.Value ? null : objRow[conMandarinCase.UpdDate].ToString().Trim(); //修改日期
objMandarinCaseEN.UpdUserId = objRow[conMandarinCase.UpdUserId] == DBNull.Value ? null : objRow[conMandarinCase.UpdUserId].ToString().Trim(); //修改用户Id
objMandarinCaseEN.Memo = objRow[conMandarinCase.Memo] == DBNull.Value ? null : objRow[conMandarinCase.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsMandarinCaseDA: GetObjByDataRowMandarinCase)", objException.Message));
}
objMandarinCaseEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objMandarinCaseEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsMandarinCaseEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsMandarinCaseEN objMandarinCaseEN = new clsMandarinCaseEN();
try
{
objMandarinCaseEN.IdMandarinCase = objRow[conMandarinCase.IdMandarinCase].ToString().Trim(); //普通话案例流水号
objMandarinCaseEN.MandarinCaseID = objRow[conMandarinCase.MandarinCaseID].ToString().Trim(); //普通话教学案例ID
objMandarinCaseEN.MandarinCaseName = objRow[conMandarinCase.MandarinCaseName].ToString().Trim(); //普通话教学案例名称
objMandarinCaseEN.IdDiscipline = objRow[conMandarinCase.IdDiscipline].ToString().Trim(); //学科流水号
objMandarinCaseEN.IdStudyLevel = objRow[conMandarinCase.IdStudyLevel].ToString().Trim(); //学段流水号
objMandarinCaseEN.MandarinCaseTheme = objRow[conMandarinCase.MandarinCaseTheme] == DBNull.Value ? null : objRow[conMandarinCase.MandarinCaseTheme].ToString().Trim(); //普通话教学案例主题词
objMandarinCaseEN.MandarinCaseDate = objRow[conMandarinCase.MandarinCaseDate] == DBNull.Value ? null : objRow[conMandarinCase.MandarinCaseDate].ToString().Trim(); //普通话教学日期
objMandarinCaseEN.MandarinCaseTime = objRow[conMandarinCase.MandarinCaseTime] == DBNull.Value ? null : objRow[conMandarinCase.MandarinCaseTime].ToString().Trim(); //普通话教学时间
objMandarinCaseEN.MandarinCaseDateIn = objRow[conMandarinCase.MandarinCaseDateIn] == DBNull.Value ? null : objRow[conMandarinCase.MandarinCaseDateIn].ToString().Trim(); //案例入库日期
objMandarinCaseEN.MandarinCaseTimeIn = objRow[conMandarinCase.MandarinCaseTimeIn] == DBNull.Value ? null : objRow[conMandarinCase.MandarinCaseTimeIn].ToString().Trim(); //案例入库时间
objMandarinCaseEN.IdTeachingPlan = objRow[conMandarinCase.IdTeachingPlan].ToString().Trim(); //教案流水号
objMandarinCaseEN.IdSenateGaugeVersion = objRow[conMandarinCase.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objMandarinCaseEN.CaseLevelId = objRow[conMandarinCase.CaseLevelId] == DBNull.Value ? null : objRow[conMandarinCase.CaseLevelId].ToString().Trim(); //课例等级Id
objMandarinCaseEN.IsNeedGeneWord = TransNullToBool(objRow[conMandarinCase.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objMandarinCaseEN.DocFile = objRow[conMandarinCase.DocFile] == DBNull.Value ? null : objRow[conMandarinCase.DocFile].ToString().Trim(); //生成的Word文件名
objMandarinCaseEN.WordCreateDate = objRow[conMandarinCase.WordCreateDate] == DBNull.Value ? null : objRow[conMandarinCase.WordCreateDate].ToString().Trim(); //Word生成日期
objMandarinCaseEN.BrowseCount = objRow[conMandarinCase.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conMandarinCase.BrowseCount].ToString().Trim()); //浏览次数
objMandarinCaseEN.IsVisible = TransNullToBool(objRow[conMandarinCase.IsVisible].ToString().Trim()); //是否显示
objMandarinCaseEN.OwnerId = objRow[conMandarinCase.OwnerId].ToString().Trim(); //拥有者Id
objMandarinCaseEN.IsDualVideo = TransNullToBool(objRow[conMandarinCase.IsDualVideo].ToString().Trim()); //是否双视频
objMandarinCaseEN.IdMandarinCaseType = objRow[conMandarinCase.IdMandarinCaseType] == DBNull.Value ? null : objRow[conMandarinCase.IdMandarinCaseType].ToString().Trim(); //普通话案例类型流水号
objMandarinCaseEN.UserTypeId = objRow[conMandarinCase.UserTypeId] == DBNull.Value ? null : objRow[conMandarinCase.UserTypeId].ToString().Trim(); //用户类型Id
objMandarinCaseEN.RecommendedDegreeId = objRow[conMandarinCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objMandarinCaseEN.ftpFileType = objRow[conMandarinCase.ftpFileType] == DBNull.Value ? null : objRow[conMandarinCase.ftpFileType].ToString().Trim(); //ftp文件类型
objMandarinCaseEN.VideoUrl = objRow[conMandarinCase.VideoUrl] == DBNull.Value ? null : objRow[conMandarinCase.VideoUrl].ToString().Trim(); //视频Url
objMandarinCaseEN.VideoPath = objRow[conMandarinCase.VideoPath] == DBNull.Value ? null : objRow[conMandarinCase.VideoPath].ToString().Trim(); //视频目录
objMandarinCaseEN.ResErrMsg = objRow[conMandarinCase.ResErrMsg] == DBNull.Value ? null : objRow[conMandarinCase.ResErrMsg].ToString().Trim(); //资源错误信息
objMandarinCaseEN.UpdDate = objRow[conMandarinCase.UpdDate] == DBNull.Value ? null : objRow[conMandarinCase.UpdDate].ToString().Trim(); //修改日期
objMandarinCaseEN.UpdUserId = objRow[conMandarinCase.UpdUserId] == DBNull.Value ? null : objRow[conMandarinCase.UpdUserId].ToString().Trim(); //修改用户Id
objMandarinCaseEN.Memo = objRow[conMandarinCase.Memo] == DBNull.Value ? null : objRow[conMandarinCase.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsMandarinCaseDA: GetObjByDataRow)", objException.Message));
}
objMandarinCaseEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objMandarinCaseEN;
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
objSQL = clsMandarinCaseDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsMandarinCaseEN._CurrTabName, conMandarinCase.IdMandarinCase, 8, "");
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
objSQL = clsMandarinCaseDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsMandarinCaseEN._CurrTabName, conMandarinCase.IdMandarinCase, 8, strPrefix);
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
 objSQL = clsMandarinCaseDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select IdMandarinCase from MandarinCase where " + strCondition;
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
 objSQL = clsMandarinCaseDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select IdMandarinCase from MandarinCase where " + strCondition;
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
 /// <param name = "strIdMandarinCase">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strIdMandarinCase)
{
CheckPrimaryKey(strIdMandarinCase);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsMandarinCaseDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("MandarinCase", "IdMandarinCase = " + "'"+ strIdMandarinCase+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsMandarinCaseDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsMandarinCaseDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("MandarinCase", strCondition))
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
objSQL = clsMandarinCaseDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("MandarinCase");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsMandarinCaseEN objMandarinCaseEN)
 {
 objMandarinCaseEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objMandarinCaseEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objMandarinCaseEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsMandarinCaseDA.GetSpecSQLObj();
strSQL = "Select * from MandarinCase where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "MandarinCase");
objRow = objDS.Tables["MandarinCase"].NewRow();
objRow[conMandarinCase.IdMandarinCase] = objMandarinCaseEN.IdMandarinCase; //普通话案例流水号
objRow[conMandarinCase.MandarinCaseID] = objMandarinCaseEN.MandarinCaseID; //普通话教学案例ID
objRow[conMandarinCase.MandarinCaseName] = objMandarinCaseEN.MandarinCaseName; //普通话教学案例名称
objRow[conMandarinCase.IdDiscipline] = objMandarinCaseEN.IdDiscipline; //学科流水号
objRow[conMandarinCase.IdStudyLevel] = objMandarinCaseEN.IdStudyLevel; //学段流水号
 if (objMandarinCaseEN.MandarinCaseTheme !=  "")
 {
objRow[conMandarinCase.MandarinCaseTheme] = objMandarinCaseEN.MandarinCaseTheme; //普通话教学案例主题词
 }
 if (objMandarinCaseEN.MandarinCaseDate !=  "")
 {
objRow[conMandarinCase.MandarinCaseDate] = objMandarinCaseEN.MandarinCaseDate; //普通话教学日期
 }
 if (objMandarinCaseEN.MandarinCaseTime !=  "")
 {
objRow[conMandarinCase.MandarinCaseTime] = objMandarinCaseEN.MandarinCaseTime; //普通话教学时间
 }
 if (objMandarinCaseEN.MandarinCaseDateIn !=  "")
 {
objRow[conMandarinCase.MandarinCaseDateIn] = objMandarinCaseEN.MandarinCaseDateIn; //案例入库日期
 }
 if (objMandarinCaseEN.MandarinCaseTimeIn !=  "")
 {
objRow[conMandarinCase.MandarinCaseTimeIn] = objMandarinCaseEN.MandarinCaseTimeIn; //案例入库时间
 }
objRow[conMandarinCase.IdTeachingPlan] = objMandarinCaseEN.IdTeachingPlan; //教案流水号
objRow[conMandarinCase.IdSenateGaugeVersion] = objMandarinCaseEN.IdSenateGaugeVersion; //评价量表版本流水号
 if (objMandarinCaseEN.CaseLevelId !=  "")
 {
objRow[conMandarinCase.CaseLevelId] = objMandarinCaseEN.CaseLevelId; //课例等级Id
 }
objRow[conMandarinCase.IsNeedGeneWord] = objMandarinCaseEN.IsNeedGeneWord; //是否需要生成Word
 if (objMandarinCaseEN.DocFile !=  "")
 {
objRow[conMandarinCase.DocFile] = objMandarinCaseEN.DocFile; //生成的Word文件名
 }
 if (objMandarinCaseEN.WordCreateDate !=  "")
 {
objRow[conMandarinCase.WordCreateDate] = objMandarinCaseEN.WordCreateDate; //Word生成日期
 }
objRow[conMandarinCase.BrowseCount] = objMandarinCaseEN.BrowseCount; //浏览次数
objRow[conMandarinCase.IsVisible] = objMandarinCaseEN.IsVisible; //是否显示
objRow[conMandarinCase.OwnerId] = objMandarinCaseEN.OwnerId; //拥有者Id
objRow[conMandarinCase.IsDualVideo] = objMandarinCaseEN.IsDualVideo; //是否双视频
 if (objMandarinCaseEN.IdMandarinCaseType !=  "")
 {
objRow[conMandarinCase.IdMandarinCaseType] = objMandarinCaseEN.IdMandarinCaseType; //普通话案例类型流水号
 }
 if (objMandarinCaseEN.UserTypeId !=  "")
 {
objRow[conMandarinCase.UserTypeId] = objMandarinCaseEN.UserTypeId; //用户类型Id
 }
objRow[conMandarinCase.RecommendedDegreeId] = objMandarinCaseEN.RecommendedDegreeId; //推荐度Id
 if (objMandarinCaseEN.ftpFileType !=  "")
 {
objRow[conMandarinCase.ftpFileType] = objMandarinCaseEN.ftpFileType; //ftp文件类型
 }
 if (objMandarinCaseEN.VideoUrl !=  "")
 {
objRow[conMandarinCase.VideoUrl] = objMandarinCaseEN.VideoUrl; //视频Url
 }
 if (objMandarinCaseEN.VideoPath !=  "")
 {
objRow[conMandarinCase.VideoPath] = objMandarinCaseEN.VideoPath; //视频目录
 }
 if (objMandarinCaseEN.ResErrMsg !=  "")
 {
objRow[conMandarinCase.ResErrMsg] = objMandarinCaseEN.ResErrMsg; //资源错误信息
 }
 if (objMandarinCaseEN.UpdDate !=  "")
 {
objRow[conMandarinCase.UpdDate] = objMandarinCaseEN.UpdDate; //修改日期
 }
 if (objMandarinCaseEN.UpdUserId !=  "")
 {
objRow[conMandarinCase.UpdUserId] = objMandarinCaseEN.UpdUserId; //修改用户Id
 }
 if (objMandarinCaseEN.Memo !=  "")
 {
objRow[conMandarinCase.Memo] = objMandarinCaseEN.Memo; //备注
 }
objDS.Tables[clsMandarinCaseEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsMandarinCaseEN._CurrTabName);
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
 /// <param name = "objMandarinCaseEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsMandarinCaseEN objMandarinCaseEN)
{
 objMandarinCaseEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objMandarinCaseEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objMandarinCaseEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objMandarinCaseEN.IdMandarinCase !=  null)
 {
 arrFieldListForInsert.Add(conMandarinCase.IdMandarinCase);
 var strIdMandarinCase = objMandarinCaseEN.IdMandarinCase.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdMandarinCase + "'");
 }
 
 if (objMandarinCaseEN.MandarinCaseID !=  null)
 {
 arrFieldListForInsert.Add(conMandarinCase.MandarinCaseID);
 var strMandarinCaseID = objMandarinCaseEN.MandarinCaseID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMandarinCaseID + "'");
 }
 
 if (objMandarinCaseEN.MandarinCaseName !=  null)
 {
 arrFieldListForInsert.Add(conMandarinCase.MandarinCaseName);
 var strMandarinCaseName = objMandarinCaseEN.MandarinCaseName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMandarinCaseName + "'");
 }
 
 if (objMandarinCaseEN.IdDiscipline !=  null)
 {
 arrFieldListForInsert.Add(conMandarinCase.IdDiscipline);
 var strIdDiscipline = objMandarinCaseEN.IdDiscipline.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdDiscipline + "'");
 }
 
 if (objMandarinCaseEN.IdStudyLevel !=  null)
 {
 arrFieldListForInsert.Add(conMandarinCase.IdStudyLevel);
 var strIdStudyLevel = objMandarinCaseEN.IdStudyLevel.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdStudyLevel + "'");
 }
 
 if (objMandarinCaseEN.MandarinCaseTheme !=  null)
 {
 arrFieldListForInsert.Add(conMandarinCase.MandarinCaseTheme);
 var strMandarinCaseTheme = objMandarinCaseEN.MandarinCaseTheme.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMandarinCaseTheme + "'");
 }
 
 if (objMandarinCaseEN.MandarinCaseDate !=  null)
 {
 arrFieldListForInsert.Add(conMandarinCase.MandarinCaseDate);
 var strMandarinCaseDate = objMandarinCaseEN.MandarinCaseDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMandarinCaseDate + "'");
 }
 
 if (objMandarinCaseEN.MandarinCaseTime !=  null)
 {
 arrFieldListForInsert.Add(conMandarinCase.MandarinCaseTime);
 var strMandarinCaseTime = objMandarinCaseEN.MandarinCaseTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMandarinCaseTime + "'");
 }
 
 if (objMandarinCaseEN.MandarinCaseDateIn !=  null)
 {
 arrFieldListForInsert.Add(conMandarinCase.MandarinCaseDateIn);
 var strMandarinCaseDateIn = objMandarinCaseEN.MandarinCaseDateIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMandarinCaseDateIn + "'");
 }
 
 if (objMandarinCaseEN.MandarinCaseTimeIn !=  null)
 {
 arrFieldListForInsert.Add(conMandarinCase.MandarinCaseTimeIn);
 var strMandarinCaseTimeIn = objMandarinCaseEN.MandarinCaseTimeIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMandarinCaseTimeIn + "'");
 }
 
 if (objMandarinCaseEN.IdTeachingPlan !=  null)
 {
 arrFieldListForInsert.Add(conMandarinCase.IdTeachingPlan);
 var strIdTeachingPlan = objMandarinCaseEN.IdTeachingPlan.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdTeachingPlan + "'");
 }
 
 if (objMandarinCaseEN.IdSenateGaugeVersion !=  null)
 {
 arrFieldListForInsert.Add(conMandarinCase.IdSenateGaugeVersion);
 var strIdSenateGaugeVersion = objMandarinCaseEN.IdSenateGaugeVersion.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdSenateGaugeVersion + "'");
 }
 
 if (objMandarinCaseEN.CaseLevelId !=  null)
 {
 arrFieldListForInsert.Add(conMandarinCase.CaseLevelId);
 var strCaseLevelId = objMandarinCaseEN.CaseLevelId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCaseLevelId + "'");
 }
 
 arrFieldListForInsert.Add(conMandarinCase.IsNeedGeneWord);
 arrValueListForInsert.Add("'" + (objMandarinCaseEN.IsNeedGeneWord  ==  false ? "0" : "1") + "'");
 
 if (objMandarinCaseEN.DocFile !=  null)
 {
 arrFieldListForInsert.Add(conMandarinCase.DocFile);
 var strDocFile = objMandarinCaseEN.DocFile.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDocFile + "'");
 }
 
 if (objMandarinCaseEN.WordCreateDate !=  null)
 {
 arrFieldListForInsert.Add(conMandarinCase.WordCreateDate);
 var strWordCreateDate = objMandarinCaseEN.WordCreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strWordCreateDate + "'");
 }
 
 if (objMandarinCaseEN.BrowseCount !=  null)
 {
 arrFieldListForInsert.Add(conMandarinCase.BrowseCount);
 arrValueListForInsert.Add(objMandarinCaseEN.BrowseCount.ToString());
 }
 
 arrFieldListForInsert.Add(conMandarinCase.IsVisible);
 arrValueListForInsert.Add("'" + (objMandarinCaseEN.IsVisible  ==  false ? "0" : "1") + "'");
 
 if (objMandarinCaseEN.OwnerId !=  null)
 {
 arrFieldListForInsert.Add(conMandarinCase.OwnerId);
 var strOwnerId = objMandarinCaseEN.OwnerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strOwnerId + "'");
 }
 
 arrFieldListForInsert.Add(conMandarinCase.IsDualVideo);
 arrValueListForInsert.Add("'" + (objMandarinCaseEN.IsDualVideo  ==  false ? "0" : "1") + "'");
 
 if (objMandarinCaseEN.IdMandarinCaseType !=  null)
 {
 arrFieldListForInsert.Add(conMandarinCase.IdMandarinCaseType);
 var strIdMandarinCaseType = objMandarinCaseEN.IdMandarinCaseType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdMandarinCaseType + "'");
 }
 
 if (objMandarinCaseEN.UserTypeId !=  null)
 {
 arrFieldListForInsert.Add(conMandarinCase.UserTypeId);
 var strUserTypeId = objMandarinCaseEN.UserTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserTypeId + "'");
 }
 
 if (objMandarinCaseEN.RecommendedDegreeId !=  null)
 {
 arrFieldListForInsert.Add(conMandarinCase.RecommendedDegreeId);
 var strRecommendedDegreeId = objMandarinCaseEN.RecommendedDegreeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRecommendedDegreeId + "'");
 }
 
 if (objMandarinCaseEN.ftpFileType !=  null)
 {
 arrFieldListForInsert.Add(conMandarinCase.ftpFileType);
 var strftpFileType = objMandarinCaseEN.ftpFileType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strftpFileType + "'");
 }
 
 if (objMandarinCaseEN.VideoUrl !=  null)
 {
 arrFieldListForInsert.Add(conMandarinCase.VideoUrl);
 var strVideoUrl = objMandarinCaseEN.VideoUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVideoUrl + "'");
 }
 
 if (objMandarinCaseEN.VideoPath !=  null)
 {
 arrFieldListForInsert.Add(conMandarinCase.VideoPath);
 var strVideoPath = objMandarinCaseEN.VideoPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVideoPath + "'");
 }
 
 if (objMandarinCaseEN.ResErrMsg !=  null)
 {
 arrFieldListForInsert.Add(conMandarinCase.ResErrMsg);
 var strResErrMsg = objMandarinCaseEN.ResErrMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strResErrMsg + "'");
 }
 
 if (objMandarinCaseEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conMandarinCase.UpdDate);
 var strUpdDate = objMandarinCaseEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objMandarinCaseEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(conMandarinCase.UpdUserId);
 var strUpdUserId = objMandarinCaseEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objMandarinCaseEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conMandarinCase.Memo);
 var strMemo = objMandarinCaseEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into MandarinCase");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsMandarinCaseDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objMandarinCaseEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsMandarinCaseEN objMandarinCaseEN)
{
 objMandarinCaseEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objMandarinCaseEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objMandarinCaseEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objMandarinCaseEN.IdMandarinCase !=  null)
 {
 arrFieldListForInsert.Add(conMandarinCase.IdMandarinCase);
 var strIdMandarinCase = objMandarinCaseEN.IdMandarinCase.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdMandarinCase + "'");
 }
 
 if (objMandarinCaseEN.MandarinCaseID !=  null)
 {
 arrFieldListForInsert.Add(conMandarinCase.MandarinCaseID);
 var strMandarinCaseID = objMandarinCaseEN.MandarinCaseID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMandarinCaseID + "'");
 }
 
 if (objMandarinCaseEN.MandarinCaseName !=  null)
 {
 arrFieldListForInsert.Add(conMandarinCase.MandarinCaseName);
 var strMandarinCaseName = objMandarinCaseEN.MandarinCaseName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMandarinCaseName + "'");
 }
 
 if (objMandarinCaseEN.IdDiscipline !=  null)
 {
 arrFieldListForInsert.Add(conMandarinCase.IdDiscipline);
 var strIdDiscipline = objMandarinCaseEN.IdDiscipline.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdDiscipline + "'");
 }
 
 if (objMandarinCaseEN.IdStudyLevel !=  null)
 {
 arrFieldListForInsert.Add(conMandarinCase.IdStudyLevel);
 var strIdStudyLevel = objMandarinCaseEN.IdStudyLevel.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdStudyLevel + "'");
 }
 
 if (objMandarinCaseEN.MandarinCaseTheme !=  null)
 {
 arrFieldListForInsert.Add(conMandarinCase.MandarinCaseTheme);
 var strMandarinCaseTheme = objMandarinCaseEN.MandarinCaseTheme.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMandarinCaseTheme + "'");
 }
 
 if (objMandarinCaseEN.MandarinCaseDate !=  null)
 {
 arrFieldListForInsert.Add(conMandarinCase.MandarinCaseDate);
 var strMandarinCaseDate = objMandarinCaseEN.MandarinCaseDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMandarinCaseDate + "'");
 }
 
 if (objMandarinCaseEN.MandarinCaseTime !=  null)
 {
 arrFieldListForInsert.Add(conMandarinCase.MandarinCaseTime);
 var strMandarinCaseTime = objMandarinCaseEN.MandarinCaseTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMandarinCaseTime + "'");
 }
 
 if (objMandarinCaseEN.MandarinCaseDateIn !=  null)
 {
 arrFieldListForInsert.Add(conMandarinCase.MandarinCaseDateIn);
 var strMandarinCaseDateIn = objMandarinCaseEN.MandarinCaseDateIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMandarinCaseDateIn + "'");
 }
 
 if (objMandarinCaseEN.MandarinCaseTimeIn !=  null)
 {
 arrFieldListForInsert.Add(conMandarinCase.MandarinCaseTimeIn);
 var strMandarinCaseTimeIn = objMandarinCaseEN.MandarinCaseTimeIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMandarinCaseTimeIn + "'");
 }
 
 if (objMandarinCaseEN.IdTeachingPlan !=  null)
 {
 arrFieldListForInsert.Add(conMandarinCase.IdTeachingPlan);
 var strIdTeachingPlan = objMandarinCaseEN.IdTeachingPlan.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdTeachingPlan + "'");
 }
 
 if (objMandarinCaseEN.IdSenateGaugeVersion !=  null)
 {
 arrFieldListForInsert.Add(conMandarinCase.IdSenateGaugeVersion);
 var strIdSenateGaugeVersion = objMandarinCaseEN.IdSenateGaugeVersion.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdSenateGaugeVersion + "'");
 }
 
 if (objMandarinCaseEN.CaseLevelId !=  null)
 {
 arrFieldListForInsert.Add(conMandarinCase.CaseLevelId);
 var strCaseLevelId = objMandarinCaseEN.CaseLevelId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCaseLevelId + "'");
 }
 
 arrFieldListForInsert.Add(conMandarinCase.IsNeedGeneWord);
 arrValueListForInsert.Add("'" + (objMandarinCaseEN.IsNeedGeneWord  ==  false ? "0" : "1") + "'");
 
 if (objMandarinCaseEN.DocFile !=  null)
 {
 arrFieldListForInsert.Add(conMandarinCase.DocFile);
 var strDocFile = objMandarinCaseEN.DocFile.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDocFile + "'");
 }
 
 if (objMandarinCaseEN.WordCreateDate !=  null)
 {
 arrFieldListForInsert.Add(conMandarinCase.WordCreateDate);
 var strWordCreateDate = objMandarinCaseEN.WordCreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strWordCreateDate + "'");
 }
 
 if (objMandarinCaseEN.BrowseCount !=  null)
 {
 arrFieldListForInsert.Add(conMandarinCase.BrowseCount);
 arrValueListForInsert.Add(objMandarinCaseEN.BrowseCount.ToString());
 }
 
 arrFieldListForInsert.Add(conMandarinCase.IsVisible);
 arrValueListForInsert.Add("'" + (objMandarinCaseEN.IsVisible  ==  false ? "0" : "1") + "'");
 
 if (objMandarinCaseEN.OwnerId !=  null)
 {
 arrFieldListForInsert.Add(conMandarinCase.OwnerId);
 var strOwnerId = objMandarinCaseEN.OwnerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strOwnerId + "'");
 }
 
 arrFieldListForInsert.Add(conMandarinCase.IsDualVideo);
 arrValueListForInsert.Add("'" + (objMandarinCaseEN.IsDualVideo  ==  false ? "0" : "1") + "'");
 
 if (objMandarinCaseEN.IdMandarinCaseType !=  null)
 {
 arrFieldListForInsert.Add(conMandarinCase.IdMandarinCaseType);
 var strIdMandarinCaseType = objMandarinCaseEN.IdMandarinCaseType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdMandarinCaseType + "'");
 }
 
 if (objMandarinCaseEN.UserTypeId !=  null)
 {
 arrFieldListForInsert.Add(conMandarinCase.UserTypeId);
 var strUserTypeId = objMandarinCaseEN.UserTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserTypeId + "'");
 }
 
 if (objMandarinCaseEN.RecommendedDegreeId !=  null)
 {
 arrFieldListForInsert.Add(conMandarinCase.RecommendedDegreeId);
 var strRecommendedDegreeId = objMandarinCaseEN.RecommendedDegreeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRecommendedDegreeId + "'");
 }
 
 if (objMandarinCaseEN.ftpFileType !=  null)
 {
 arrFieldListForInsert.Add(conMandarinCase.ftpFileType);
 var strftpFileType = objMandarinCaseEN.ftpFileType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strftpFileType + "'");
 }
 
 if (objMandarinCaseEN.VideoUrl !=  null)
 {
 arrFieldListForInsert.Add(conMandarinCase.VideoUrl);
 var strVideoUrl = objMandarinCaseEN.VideoUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVideoUrl + "'");
 }
 
 if (objMandarinCaseEN.VideoPath !=  null)
 {
 arrFieldListForInsert.Add(conMandarinCase.VideoPath);
 var strVideoPath = objMandarinCaseEN.VideoPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVideoPath + "'");
 }
 
 if (objMandarinCaseEN.ResErrMsg !=  null)
 {
 arrFieldListForInsert.Add(conMandarinCase.ResErrMsg);
 var strResErrMsg = objMandarinCaseEN.ResErrMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strResErrMsg + "'");
 }
 
 if (objMandarinCaseEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conMandarinCase.UpdDate);
 var strUpdDate = objMandarinCaseEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objMandarinCaseEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(conMandarinCase.UpdUserId);
 var strUpdUserId = objMandarinCaseEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objMandarinCaseEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conMandarinCase.Memo);
 var strMemo = objMandarinCaseEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into MandarinCase");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsMandarinCaseDA.GetSpecSQLObj();
 objSQL.ExecSql(strSQL.ToString());
return objMandarinCaseEN.IdMandarinCase;
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objMandarinCaseEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsMandarinCaseEN objMandarinCaseEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objMandarinCaseEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objMandarinCaseEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objMandarinCaseEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objMandarinCaseEN.IdMandarinCase !=  null)
 {
 arrFieldListForInsert.Add(conMandarinCase.IdMandarinCase);
 var strIdMandarinCase = objMandarinCaseEN.IdMandarinCase.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdMandarinCase + "'");
 }
 
 if (objMandarinCaseEN.MandarinCaseID !=  null)
 {
 arrFieldListForInsert.Add(conMandarinCase.MandarinCaseID);
 var strMandarinCaseID = objMandarinCaseEN.MandarinCaseID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMandarinCaseID + "'");
 }
 
 if (objMandarinCaseEN.MandarinCaseName !=  null)
 {
 arrFieldListForInsert.Add(conMandarinCase.MandarinCaseName);
 var strMandarinCaseName = objMandarinCaseEN.MandarinCaseName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMandarinCaseName + "'");
 }
 
 if (objMandarinCaseEN.IdDiscipline !=  null)
 {
 arrFieldListForInsert.Add(conMandarinCase.IdDiscipline);
 var strIdDiscipline = objMandarinCaseEN.IdDiscipline.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdDiscipline + "'");
 }
 
 if (objMandarinCaseEN.IdStudyLevel !=  null)
 {
 arrFieldListForInsert.Add(conMandarinCase.IdStudyLevel);
 var strIdStudyLevel = objMandarinCaseEN.IdStudyLevel.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdStudyLevel + "'");
 }
 
 if (objMandarinCaseEN.MandarinCaseTheme !=  null)
 {
 arrFieldListForInsert.Add(conMandarinCase.MandarinCaseTheme);
 var strMandarinCaseTheme = objMandarinCaseEN.MandarinCaseTheme.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMandarinCaseTheme + "'");
 }
 
 if (objMandarinCaseEN.MandarinCaseDate !=  null)
 {
 arrFieldListForInsert.Add(conMandarinCase.MandarinCaseDate);
 var strMandarinCaseDate = objMandarinCaseEN.MandarinCaseDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMandarinCaseDate + "'");
 }
 
 if (objMandarinCaseEN.MandarinCaseTime !=  null)
 {
 arrFieldListForInsert.Add(conMandarinCase.MandarinCaseTime);
 var strMandarinCaseTime = objMandarinCaseEN.MandarinCaseTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMandarinCaseTime + "'");
 }
 
 if (objMandarinCaseEN.MandarinCaseDateIn !=  null)
 {
 arrFieldListForInsert.Add(conMandarinCase.MandarinCaseDateIn);
 var strMandarinCaseDateIn = objMandarinCaseEN.MandarinCaseDateIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMandarinCaseDateIn + "'");
 }
 
 if (objMandarinCaseEN.MandarinCaseTimeIn !=  null)
 {
 arrFieldListForInsert.Add(conMandarinCase.MandarinCaseTimeIn);
 var strMandarinCaseTimeIn = objMandarinCaseEN.MandarinCaseTimeIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMandarinCaseTimeIn + "'");
 }
 
 if (objMandarinCaseEN.IdTeachingPlan !=  null)
 {
 arrFieldListForInsert.Add(conMandarinCase.IdTeachingPlan);
 var strIdTeachingPlan = objMandarinCaseEN.IdTeachingPlan.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdTeachingPlan + "'");
 }
 
 if (objMandarinCaseEN.IdSenateGaugeVersion !=  null)
 {
 arrFieldListForInsert.Add(conMandarinCase.IdSenateGaugeVersion);
 var strIdSenateGaugeVersion = objMandarinCaseEN.IdSenateGaugeVersion.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdSenateGaugeVersion + "'");
 }
 
 if (objMandarinCaseEN.CaseLevelId !=  null)
 {
 arrFieldListForInsert.Add(conMandarinCase.CaseLevelId);
 var strCaseLevelId = objMandarinCaseEN.CaseLevelId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCaseLevelId + "'");
 }
 
 arrFieldListForInsert.Add(conMandarinCase.IsNeedGeneWord);
 arrValueListForInsert.Add("'" + (objMandarinCaseEN.IsNeedGeneWord  ==  false ? "0" : "1") + "'");
 
 if (objMandarinCaseEN.DocFile !=  null)
 {
 arrFieldListForInsert.Add(conMandarinCase.DocFile);
 var strDocFile = objMandarinCaseEN.DocFile.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDocFile + "'");
 }
 
 if (objMandarinCaseEN.WordCreateDate !=  null)
 {
 arrFieldListForInsert.Add(conMandarinCase.WordCreateDate);
 var strWordCreateDate = objMandarinCaseEN.WordCreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strWordCreateDate + "'");
 }
 
 if (objMandarinCaseEN.BrowseCount !=  null)
 {
 arrFieldListForInsert.Add(conMandarinCase.BrowseCount);
 arrValueListForInsert.Add(objMandarinCaseEN.BrowseCount.ToString());
 }
 
 arrFieldListForInsert.Add(conMandarinCase.IsVisible);
 arrValueListForInsert.Add("'" + (objMandarinCaseEN.IsVisible  ==  false ? "0" : "1") + "'");
 
 if (objMandarinCaseEN.OwnerId !=  null)
 {
 arrFieldListForInsert.Add(conMandarinCase.OwnerId);
 var strOwnerId = objMandarinCaseEN.OwnerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strOwnerId + "'");
 }
 
 arrFieldListForInsert.Add(conMandarinCase.IsDualVideo);
 arrValueListForInsert.Add("'" + (objMandarinCaseEN.IsDualVideo  ==  false ? "0" : "1") + "'");
 
 if (objMandarinCaseEN.IdMandarinCaseType !=  null)
 {
 arrFieldListForInsert.Add(conMandarinCase.IdMandarinCaseType);
 var strIdMandarinCaseType = objMandarinCaseEN.IdMandarinCaseType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdMandarinCaseType + "'");
 }
 
 if (objMandarinCaseEN.UserTypeId !=  null)
 {
 arrFieldListForInsert.Add(conMandarinCase.UserTypeId);
 var strUserTypeId = objMandarinCaseEN.UserTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserTypeId + "'");
 }
 
 if (objMandarinCaseEN.RecommendedDegreeId !=  null)
 {
 arrFieldListForInsert.Add(conMandarinCase.RecommendedDegreeId);
 var strRecommendedDegreeId = objMandarinCaseEN.RecommendedDegreeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRecommendedDegreeId + "'");
 }
 
 if (objMandarinCaseEN.ftpFileType !=  null)
 {
 arrFieldListForInsert.Add(conMandarinCase.ftpFileType);
 var strftpFileType = objMandarinCaseEN.ftpFileType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strftpFileType + "'");
 }
 
 if (objMandarinCaseEN.VideoUrl !=  null)
 {
 arrFieldListForInsert.Add(conMandarinCase.VideoUrl);
 var strVideoUrl = objMandarinCaseEN.VideoUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVideoUrl + "'");
 }
 
 if (objMandarinCaseEN.VideoPath !=  null)
 {
 arrFieldListForInsert.Add(conMandarinCase.VideoPath);
 var strVideoPath = objMandarinCaseEN.VideoPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVideoPath + "'");
 }
 
 if (objMandarinCaseEN.ResErrMsg !=  null)
 {
 arrFieldListForInsert.Add(conMandarinCase.ResErrMsg);
 var strResErrMsg = objMandarinCaseEN.ResErrMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strResErrMsg + "'");
 }
 
 if (objMandarinCaseEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conMandarinCase.UpdDate);
 var strUpdDate = objMandarinCaseEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objMandarinCaseEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(conMandarinCase.UpdUserId);
 var strUpdUserId = objMandarinCaseEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objMandarinCaseEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conMandarinCase.Memo);
 var strMemo = objMandarinCaseEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into MandarinCase");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsMandarinCaseDA.GetSpecSQLObj();
    objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
return objMandarinCaseEN.IdMandarinCase;
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objMandarinCaseEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsMandarinCaseEN objMandarinCaseEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objMandarinCaseEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objMandarinCaseEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objMandarinCaseEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objMandarinCaseEN.IdMandarinCase !=  null)
 {
 arrFieldListForInsert.Add(conMandarinCase.IdMandarinCase);
 var strIdMandarinCase = objMandarinCaseEN.IdMandarinCase.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdMandarinCase + "'");
 }
 
 if (objMandarinCaseEN.MandarinCaseID !=  null)
 {
 arrFieldListForInsert.Add(conMandarinCase.MandarinCaseID);
 var strMandarinCaseID = objMandarinCaseEN.MandarinCaseID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMandarinCaseID + "'");
 }
 
 if (objMandarinCaseEN.MandarinCaseName !=  null)
 {
 arrFieldListForInsert.Add(conMandarinCase.MandarinCaseName);
 var strMandarinCaseName = objMandarinCaseEN.MandarinCaseName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMandarinCaseName + "'");
 }
 
 if (objMandarinCaseEN.IdDiscipline !=  null)
 {
 arrFieldListForInsert.Add(conMandarinCase.IdDiscipline);
 var strIdDiscipline = objMandarinCaseEN.IdDiscipline.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdDiscipline + "'");
 }
 
 if (objMandarinCaseEN.IdStudyLevel !=  null)
 {
 arrFieldListForInsert.Add(conMandarinCase.IdStudyLevel);
 var strIdStudyLevel = objMandarinCaseEN.IdStudyLevel.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdStudyLevel + "'");
 }
 
 if (objMandarinCaseEN.MandarinCaseTheme !=  null)
 {
 arrFieldListForInsert.Add(conMandarinCase.MandarinCaseTheme);
 var strMandarinCaseTheme = objMandarinCaseEN.MandarinCaseTheme.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMandarinCaseTheme + "'");
 }
 
 if (objMandarinCaseEN.MandarinCaseDate !=  null)
 {
 arrFieldListForInsert.Add(conMandarinCase.MandarinCaseDate);
 var strMandarinCaseDate = objMandarinCaseEN.MandarinCaseDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMandarinCaseDate + "'");
 }
 
 if (objMandarinCaseEN.MandarinCaseTime !=  null)
 {
 arrFieldListForInsert.Add(conMandarinCase.MandarinCaseTime);
 var strMandarinCaseTime = objMandarinCaseEN.MandarinCaseTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMandarinCaseTime + "'");
 }
 
 if (objMandarinCaseEN.MandarinCaseDateIn !=  null)
 {
 arrFieldListForInsert.Add(conMandarinCase.MandarinCaseDateIn);
 var strMandarinCaseDateIn = objMandarinCaseEN.MandarinCaseDateIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMandarinCaseDateIn + "'");
 }
 
 if (objMandarinCaseEN.MandarinCaseTimeIn !=  null)
 {
 arrFieldListForInsert.Add(conMandarinCase.MandarinCaseTimeIn);
 var strMandarinCaseTimeIn = objMandarinCaseEN.MandarinCaseTimeIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMandarinCaseTimeIn + "'");
 }
 
 if (objMandarinCaseEN.IdTeachingPlan !=  null)
 {
 arrFieldListForInsert.Add(conMandarinCase.IdTeachingPlan);
 var strIdTeachingPlan = objMandarinCaseEN.IdTeachingPlan.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdTeachingPlan + "'");
 }
 
 if (objMandarinCaseEN.IdSenateGaugeVersion !=  null)
 {
 arrFieldListForInsert.Add(conMandarinCase.IdSenateGaugeVersion);
 var strIdSenateGaugeVersion = objMandarinCaseEN.IdSenateGaugeVersion.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdSenateGaugeVersion + "'");
 }
 
 if (objMandarinCaseEN.CaseLevelId !=  null)
 {
 arrFieldListForInsert.Add(conMandarinCase.CaseLevelId);
 var strCaseLevelId = objMandarinCaseEN.CaseLevelId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCaseLevelId + "'");
 }
 
 arrFieldListForInsert.Add(conMandarinCase.IsNeedGeneWord);
 arrValueListForInsert.Add("'" + (objMandarinCaseEN.IsNeedGeneWord  ==  false ? "0" : "1") + "'");
 
 if (objMandarinCaseEN.DocFile !=  null)
 {
 arrFieldListForInsert.Add(conMandarinCase.DocFile);
 var strDocFile = objMandarinCaseEN.DocFile.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDocFile + "'");
 }
 
 if (objMandarinCaseEN.WordCreateDate !=  null)
 {
 arrFieldListForInsert.Add(conMandarinCase.WordCreateDate);
 var strWordCreateDate = objMandarinCaseEN.WordCreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strWordCreateDate + "'");
 }
 
 if (objMandarinCaseEN.BrowseCount !=  null)
 {
 arrFieldListForInsert.Add(conMandarinCase.BrowseCount);
 arrValueListForInsert.Add(objMandarinCaseEN.BrowseCount.ToString());
 }
 
 arrFieldListForInsert.Add(conMandarinCase.IsVisible);
 arrValueListForInsert.Add("'" + (objMandarinCaseEN.IsVisible  ==  false ? "0" : "1") + "'");
 
 if (objMandarinCaseEN.OwnerId !=  null)
 {
 arrFieldListForInsert.Add(conMandarinCase.OwnerId);
 var strOwnerId = objMandarinCaseEN.OwnerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strOwnerId + "'");
 }
 
 arrFieldListForInsert.Add(conMandarinCase.IsDualVideo);
 arrValueListForInsert.Add("'" + (objMandarinCaseEN.IsDualVideo  ==  false ? "0" : "1") + "'");
 
 if (objMandarinCaseEN.IdMandarinCaseType !=  null)
 {
 arrFieldListForInsert.Add(conMandarinCase.IdMandarinCaseType);
 var strIdMandarinCaseType = objMandarinCaseEN.IdMandarinCaseType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdMandarinCaseType + "'");
 }
 
 if (objMandarinCaseEN.UserTypeId !=  null)
 {
 arrFieldListForInsert.Add(conMandarinCase.UserTypeId);
 var strUserTypeId = objMandarinCaseEN.UserTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserTypeId + "'");
 }
 
 if (objMandarinCaseEN.RecommendedDegreeId !=  null)
 {
 arrFieldListForInsert.Add(conMandarinCase.RecommendedDegreeId);
 var strRecommendedDegreeId = objMandarinCaseEN.RecommendedDegreeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRecommendedDegreeId + "'");
 }
 
 if (objMandarinCaseEN.ftpFileType !=  null)
 {
 arrFieldListForInsert.Add(conMandarinCase.ftpFileType);
 var strftpFileType = objMandarinCaseEN.ftpFileType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strftpFileType + "'");
 }
 
 if (objMandarinCaseEN.VideoUrl !=  null)
 {
 arrFieldListForInsert.Add(conMandarinCase.VideoUrl);
 var strVideoUrl = objMandarinCaseEN.VideoUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVideoUrl + "'");
 }
 
 if (objMandarinCaseEN.VideoPath !=  null)
 {
 arrFieldListForInsert.Add(conMandarinCase.VideoPath);
 var strVideoPath = objMandarinCaseEN.VideoPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVideoPath + "'");
 }
 
 if (objMandarinCaseEN.ResErrMsg !=  null)
 {
 arrFieldListForInsert.Add(conMandarinCase.ResErrMsg);
 var strResErrMsg = objMandarinCaseEN.ResErrMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strResErrMsg + "'");
 }
 
 if (objMandarinCaseEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conMandarinCase.UpdDate);
 var strUpdDate = objMandarinCaseEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objMandarinCaseEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(conMandarinCase.UpdUserId);
 var strUpdUserId = objMandarinCaseEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objMandarinCaseEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conMandarinCase.Memo);
 var strMemo = objMandarinCaseEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into MandarinCase");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsMandarinCaseDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewMandarinCases(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsMandarinCaseDA.GetSpecSQLObj();
strSQL = "Select * from MandarinCase where IdMandarinCase = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "MandarinCase");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
string strIdMandarinCase = oRow[conMandarinCase.IdMandarinCase].ToString().Trim();
if (IsExist(strIdMandarinCase))
{
 string strResult = "关键字变量值为:" + string.Format("IdMandarinCase = {0}", strIdMandarinCase) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsMandarinCaseEN._CurrTabName ].NewRow();
objRow[conMandarinCase.IdMandarinCase] = oRow[conMandarinCase.IdMandarinCase].ToString().Trim(); //普通话案例流水号
objRow[conMandarinCase.MandarinCaseID] = oRow[conMandarinCase.MandarinCaseID].ToString().Trim(); //普通话教学案例ID
objRow[conMandarinCase.MandarinCaseName] = oRow[conMandarinCase.MandarinCaseName].ToString().Trim(); //普通话教学案例名称
objRow[conMandarinCase.IdDiscipline] = oRow[conMandarinCase.IdDiscipline].ToString().Trim(); //学科流水号
objRow[conMandarinCase.IdStudyLevel] = oRow[conMandarinCase.IdStudyLevel].ToString().Trim(); //学段流水号
objRow[conMandarinCase.MandarinCaseTheme] = oRow[conMandarinCase.MandarinCaseTheme].ToString().Trim(); //普通话教学案例主题词
objRow[conMandarinCase.MandarinCaseDate] = oRow[conMandarinCase.MandarinCaseDate].ToString().Trim(); //普通话教学日期
objRow[conMandarinCase.MandarinCaseTime] = oRow[conMandarinCase.MandarinCaseTime].ToString().Trim(); //普通话教学时间
objRow[conMandarinCase.MandarinCaseDateIn] = oRow[conMandarinCase.MandarinCaseDateIn].ToString().Trim(); //案例入库日期
objRow[conMandarinCase.MandarinCaseTimeIn] = oRow[conMandarinCase.MandarinCaseTimeIn].ToString().Trim(); //案例入库时间
objRow[conMandarinCase.IdTeachingPlan] = oRow[conMandarinCase.IdTeachingPlan].ToString().Trim(); //教案流水号
objRow[conMandarinCase.IdSenateGaugeVersion] = oRow[conMandarinCase.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objRow[conMandarinCase.CaseLevelId] = oRow[conMandarinCase.CaseLevelId].ToString().Trim(); //课例等级Id
objRow[conMandarinCase.IsNeedGeneWord] = oRow[conMandarinCase.IsNeedGeneWord].ToString().Trim(); //是否需要生成Word
objRow[conMandarinCase.DocFile] = oRow[conMandarinCase.DocFile].ToString().Trim(); //生成的Word文件名
objRow[conMandarinCase.WordCreateDate] = oRow[conMandarinCase.WordCreateDate].ToString().Trim(); //Word生成日期
objRow[conMandarinCase.BrowseCount] = oRow[conMandarinCase.BrowseCount].ToString().Trim(); //浏览次数
objRow[conMandarinCase.IsVisible] = oRow[conMandarinCase.IsVisible].ToString().Trim(); //是否显示
objRow[conMandarinCase.OwnerId] = oRow[conMandarinCase.OwnerId].ToString().Trim(); //拥有者Id
objRow[conMandarinCase.IsDualVideo] = oRow[conMandarinCase.IsDualVideo].ToString().Trim(); //是否双视频
objRow[conMandarinCase.IdMandarinCaseType] = oRow[conMandarinCase.IdMandarinCaseType].ToString().Trim(); //普通话案例类型流水号
objRow[conMandarinCase.UserTypeId] = oRow[conMandarinCase.UserTypeId].ToString().Trim(); //用户类型Id
objRow[conMandarinCase.RecommendedDegreeId] = oRow[conMandarinCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objRow[conMandarinCase.ftpFileType] = oRow[conMandarinCase.ftpFileType].ToString().Trim(); //ftp文件类型
objRow[conMandarinCase.VideoUrl] = oRow[conMandarinCase.VideoUrl].ToString().Trim(); //视频Url
objRow[conMandarinCase.VideoPath] = oRow[conMandarinCase.VideoPath].ToString().Trim(); //视频目录
objRow[conMandarinCase.ResErrMsg] = oRow[conMandarinCase.ResErrMsg].ToString().Trim(); //资源错误信息
objRow[conMandarinCase.UpdDate] = oRow[conMandarinCase.UpdDate].ToString().Trim(); //修改日期
objRow[conMandarinCase.UpdUserId] = oRow[conMandarinCase.UpdUserId].ToString().Trim(); //修改用户Id
objRow[conMandarinCase.Memo] = oRow[conMandarinCase.Memo].ToString().Trim(); //备注
 objDS.Tables[clsMandarinCaseEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsMandarinCaseEN._CurrTabName);
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
 /// <param name = "objMandarinCaseEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsMandarinCaseEN objMandarinCaseEN)
{
 objMandarinCaseEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objMandarinCaseEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objMandarinCaseEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsMandarinCaseDA.GetSpecSQLObj();
strSQL = "Select * from MandarinCase where IdMandarinCase = " + "'"+ objMandarinCaseEN.IdMandarinCase+"'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsMandarinCaseEN._CurrTabName);
if (objDS.Tables[clsMandarinCaseEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:IdMandarinCase = " + "'"+ objMandarinCaseEN.IdMandarinCase+"'");
return false;
}
objRow = objDS.Tables[clsMandarinCaseEN._CurrTabName].Rows[0];
 if (objMandarinCaseEN.IsUpdated(conMandarinCase.IdMandarinCase))
 {
objRow[conMandarinCase.IdMandarinCase] = objMandarinCaseEN.IdMandarinCase; //普通话案例流水号
 }
 if (objMandarinCaseEN.IsUpdated(conMandarinCase.MandarinCaseID))
 {
objRow[conMandarinCase.MandarinCaseID] = objMandarinCaseEN.MandarinCaseID; //普通话教学案例ID
 }
 if (objMandarinCaseEN.IsUpdated(conMandarinCase.MandarinCaseName))
 {
objRow[conMandarinCase.MandarinCaseName] = objMandarinCaseEN.MandarinCaseName; //普通话教学案例名称
 }
 if (objMandarinCaseEN.IsUpdated(conMandarinCase.IdDiscipline))
 {
objRow[conMandarinCase.IdDiscipline] = objMandarinCaseEN.IdDiscipline; //学科流水号
 }
 if (objMandarinCaseEN.IsUpdated(conMandarinCase.IdStudyLevel))
 {
objRow[conMandarinCase.IdStudyLevel] = objMandarinCaseEN.IdStudyLevel; //学段流水号
 }
 if (objMandarinCaseEN.IsUpdated(conMandarinCase.MandarinCaseTheme))
 {
objRow[conMandarinCase.MandarinCaseTheme] = objMandarinCaseEN.MandarinCaseTheme; //普通话教学案例主题词
 }
 if (objMandarinCaseEN.IsUpdated(conMandarinCase.MandarinCaseDate))
 {
objRow[conMandarinCase.MandarinCaseDate] = objMandarinCaseEN.MandarinCaseDate; //普通话教学日期
 }
 if (objMandarinCaseEN.IsUpdated(conMandarinCase.MandarinCaseTime))
 {
objRow[conMandarinCase.MandarinCaseTime] = objMandarinCaseEN.MandarinCaseTime; //普通话教学时间
 }
 if (objMandarinCaseEN.IsUpdated(conMandarinCase.MandarinCaseDateIn))
 {
objRow[conMandarinCase.MandarinCaseDateIn] = objMandarinCaseEN.MandarinCaseDateIn; //案例入库日期
 }
 if (objMandarinCaseEN.IsUpdated(conMandarinCase.MandarinCaseTimeIn))
 {
objRow[conMandarinCase.MandarinCaseTimeIn] = objMandarinCaseEN.MandarinCaseTimeIn; //案例入库时间
 }
 if (objMandarinCaseEN.IsUpdated(conMandarinCase.IdTeachingPlan))
 {
objRow[conMandarinCase.IdTeachingPlan] = objMandarinCaseEN.IdTeachingPlan; //教案流水号
 }
 if (objMandarinCaseEN.IsUpdated(conMandarinCase.IdSenateGaugeVersion))
 {
objRow[conMandarinCase.IdSenateGaugeVersion] = objMandarinCaseEN.IdSenateGaugeVersion; //评价量表版本流水号
 }
 if (objMandarinCaseEN.IsUpdated(conMandarinCase.CaseLevelId))
 {
objRow[conMandarinCase.CaseLevelId] = objMandarinCaseEN.CaseLevelId; //课例等级Id
 }
 if (objMandarinCaseEN.IsUpdated(conMandarinCase.IsNeedGeneWord))
 {
objRow[conMandarinCase.IsNeedGeneWord] = objMandarinCaseEN.IsNeedGeneWord; //是否需要生成Word
 }
 if (objMandarinCaseEN.IsUpdated(conMandarinCase.DocFile))
 {
objRow[conMandarinCase.DocFile] = objMandarinCaseEN.DocFile; //生成的Word文件名
 }
 if (objMandarinCaseEN.IsUpdated(conMandarinCase.WordCreateDate))
 {
objRow[conMandarinCase.WordCreateDate] = objMandarinCaseEN.WordCreateDate; //Word生成日期
 }
 if (objMandarinCaseEN.IsUpdated(conMandarinCase.BrowseCount))
 {
objRow[conMandarinCase.BrowseCount] = objMandarinCaseEN.BrowseCount; //浏览次数
 }
 if (objMandarinCaseEN.IsUpdated(conMandarinCase.IsVisible))
 {
objRow[conMandarinCase.IsVisible] = objMandarinCaseEN.IsVisible; //是否显示
 }
 if (objMandarinCaseEN.IsUpdated(conMandarinCase.OwnerId))
 {
objRow[conMandarinCase.OwnerId] = objMandarinCaseEN.OwnerId; //拥有者Id
 }
 if (objMandarinCaseEN.IsUpdated(conMandarinCase.IsDualVideo))
 {
objRow[conMandarinCase.IsDualVideo] = objMandarinCaseEN.IsDualVideo; //是否双视频
 }
 if (objMandarinCaseEN.IsUpdated(conMandarinCase.IdMandarinCaseType))
 {
objRow[conMandarinCase.IdMandarinCaseType] = objMandarinCaseEN.IdMandarinCaseType; //普通话案例类型流水号
 }
 if (objMandarinCaseEN.IsUpdated(conMandarinCase.UserTypeId))
 {
objRow[conMandarinCase.UserTypeId] = objMandarinCaseEN.UserTypeId; //用户类型Id
 }
 if (objMandarinCaseEN.IsUpdated(conMandarinCase.RecommendedDegreeId))
 {
objRow[conMandarinCase.RecommendedDegreeId] = objMandarinCaseEN.RecommendedDegreeId; //推荐度Id
 }
 if (objMandarinCaseEN.IsUpdated(conMandarinCase.ftpFileType))
 {
objRow[conMandarinCase.ftpFileType] = objMandarinCaseEN.ftpFileType; //ftp文件类型
 }
 if (objMandarinCaseEN.IsUpdated(conMandarinCase.VideoUrl))
 {
objRow[conMandarinCase.VideoUrl] = objMandarinCaseEN.VideoUrl; //视频Url
 }
 if (objMandarinCaseEN.IsUpdated(conMandarinCase.VideoPath))
 {
objRow[conMandarinCase.VideoPath] = objMandarinCaseEN.VideoPath; //视频目录
 }
 if (objMandarinCaseEN.IsUpdated(conMandarinCase.ResErrMsg))
 {
objRow[conMandarinCase.ResErrMsg] = objMandarinCaseEN.ResErrMsg; //资源错误信息
 }
 if (objMandarinCaseEN.IsUpdated(conMandarinCase.UpdDate))
 {
objRow[conMandarinCase.UpdDate] = objMandarinCaseEN.UpdDate; //修改日期
 }
 if (objMandarinCaseEN.IsUpdated(conMandarinCase.UpdUserId))
 {
objRow[conMandarinCase.UpdUserId] = objMandarinCaseEN.UpdUserId; //修改用户Id
 }
 if (objMandarinCaseEN.IsUpdated(conMandarinCase.Memo))
 {
objRow[conMandarinCase.Memo] = objMandarinCaseEN.Memo; //备注
 }
try
{
objDA.Update(objDS, clsMandarinCaseEN._CurrTabName);
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
 /// <param name = "objMandarinCaseEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsMandarinCaseEN objMandarinCaseEN)
{
 objMandarinCaseEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objMandarinCaseEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objMandarinCaseEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsMandarinCaseDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update MandarinCase Set ");
 
 if (objMandarinCaseEN.IsUpdated(conMandarinCase.MandarinCaseID))
 {
 if (objMandarinCaseEN.MandarinCaseID !=  null)
 {
 var strMandarinCaseID = objMandarinCaseEN.MandarinCaseID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMandarinCaseID, conMandarinCase.MandarinCaseID); //普通话教学案例ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conMandarinCase.MandarinCaseID); //普通话教学案例ID
 }
 }
 
 if (objMandarinCaseEN.IsUpdated(conMandarinCase.MandarinCaseName))
 {
 if (objMandarinCaseEN.MandarinCaseName !=  null)
 {
 var strMandarinCaseName = objMandarinCaseEN.MandarinCaseName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMandarinCaseName, conMandarinCase.MandarinCaseName); //普通话教学案例名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conMandarinCase.MandarinCaseName); //普通话教学案例名称
 }
 }
 
 if (objMandarinCaseEN.IsUpdated(conMandarinCase.IdDiscipline))
 {
 if (objMandarinCaseEN.IdDiscipline !=  null)
 {
 var strIdDiscipline = objMandarinCaseEN.IdDiscipline.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdDiscipline, conMandarinCase.IdDiscipline); //学科流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conMandarinCase.IdDiscipline); //学科流水号
 }
 }
 
 if (objMandarinCaseEN.IsUpdated(conMandarinCase.IdStudyLevel))
 {
 if (objMandarinCaseEN.IdStudyLevel !=  null)
 {
 var strIdStudyLevel = objMandarinCaseEN.IdStudyLevel.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdStudyLevel, conMandarinCase.IdStudyLevel); //学段流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conMandarinCase.IdStudyLevel); //学段流水号
 }
 }
 
 if (objMandarinCaseEN.IsUpdated(conMandarinCase.MandarinCaseTheme))
 {
 if (objMandarinCaseEN.MandarinCaseTheme !=  null)
 {
 var strMandarinCaseTheme = objMandarinCaseEN.MandarinCaseTheme.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMandarinCaseTheme, conMandarinCase.MandarinCaseTheme); //普通话教学案例主题词
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conMandarinCase.MandarinCaseTheme); //普通话教学案例主题词
 }
 }
 
 if (objMandarinCaseEN.IsUpdated(conMandarinCase.MandarinCaseDate))
 {
 if (objMandarinCaseEN.MandarinCaseDate !=  null)
 {
 var strMandarinCaseDate = objMandarinCaseEN.MandarinCaseDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMandarinCaseDate, conMandarinCase.MandarinCaseDate); //普通话教学日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conMandarinCase.MandarinCaseDate); //普通话教学日期
 }
 }
 
 if (objMandarinCaseEN.IsUpdated(conMandarinCase.MandarinCaseTime))
 {
 if (objMandarinCaseEN.MandarinCaseTime !=  null)
 {
 var strMandarinCaseTime = objMandarinCaseEN.MandarinCaseTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMandarinCaseTime, conMandarinCase.MandarinCaseTime); //普通话教学时间
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conMandarinCase.MandarinCaseTime); //普通话教学时间
 }
 }
 
 if (objMandarinCaseEN.IsUpdated(conMandarinCase.MandarinCaseDateIn))
 {
 if (objMandarinCaseEN.MandarinCaseDateIn !=  null)
 {
 var strMandarinCaseDateIn = objMandarinCaseEN.MandarinCaseDateIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMandarinCaseDateIn, conMandarinCase.MandarinCaseDateIn); //案例入库日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conMandarinCase.MandarinCaseDateIn); //案例入库日期
 }
 }
 
 if (objMandarinCaseEN.IsUpdated(conMandarinCase.MandarinCaseTimeIn))
 {
 if (objMandarinCaseEN.MandarinCaseTimeIn !=  null)
 {
 var strMandarinCaseTimeIn = objMandarinCaseEN.MandarinCaseTimeIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMandarinCaseTimeIn, conMandarinCase.MandarinCaseTimeIn); //案例入库时间
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conMandarinCase.MandarinCaseTimeIn); //案例入库时间
 }
 }
 
 if (objMandarinCaseEN.IsUpdated(conMandarinCase.IdTeachingPlan))
 {
 if (objMandarinCaseEN.IdTeachingPlan !=  null)
 {
 var strIdTeachingPlan = objMandarinCaseEN.IdTeachingPlan.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdTeachingPlan, conMandarinCase.IdTeachingPlan); //教案流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conMandarinCase.IdTeachingPlan); //教案流水号
 }
 }
 
 if (objMandarinCaseEN.IsUpdated(conMandarinCase.IdSenateGaugeVersion))
 {
 if (objMandarinCaseEN.IdSenateGaugeVersion !=  null)
 {
 var strIdSenateGaugeVersion = objMandarinCaseEN.IdSenateGaugeVersion.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdSenateGaugeVersion, conMandarinCase.IdSenateGaugeVersion); //评价量表版本流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conMandarinCase.IdSenateGaugeVersion); //评价量表版本流水号
 }
 }
 
 if (objMandarinCaseEN.IsUpdated(conMandarinCase.CaseLevelId))
 {
 if (objMandarinCaseEN.CaseLevelId !=  null)
 {
 var strCaseLevelId = objMandarinCaseEN.CaseLevelId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCaseLevelId, conMandarinCase.CaseLevelId); //课例等级Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conMandarinCase.CaseLevelId); //课例等级Id
 }
 }
 
 if (objMandarinCaseEN.IsUpdated(conMandarinCase.IsNeedGeneWord))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objMandarinCaseEN.IsNeedGeneWord == true?"1":"0", conMandarinCase.IsNeedGeneWord); //是否需要生成Word
 }
 
 if (objMandarinCaseEN.IsUpdated(conMandarinCase.DocFile))
 {
 if (objMandarinCaseEN.DocFile !=  null)
 {
 var strDocFile = objMandarinCaseEN.DocFile.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strDocFile, conMandarinCase.DocFile); //生成的Word文件名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conMandarinCase.DocFile); //生成的Word文件名
 }
 }
 
 if (objMandarinCaseEN.IsUpdated(conMandarinCase.WordCreateDate))
 {
 if (objMandarinCaseEN.WordCreateDate !=  null)
 {
 var strWordCreateDate = objMandarinCaseEN.WordCreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strWordCreateDate, conMandarinCase.WordCreateDate); //Word生成日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conMandarinCase.WordCreateDate); //Word生成日期
 }
 }
 
 if (objMandarinCaseEN.IsUpdated(conMandarinCase.BrowseCount))
 {
 if (objMandarinCaseEN.BrowseCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objMandarinCaseEN.BrowseCount, conMandarinCase.BrowseCount); //浏览次数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conMandarinCase.BrowseCount); //浏览次数
 }
 }
 
 if (objMandarinCaseEN.IsUpdated(conMandarinCase.IsVisible))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objMandarinCaseEN.IsVisible == true?"1":"0", conMandarinCase.IsVisible); //是否显示
 }
 
 if (objMandarinCaseEN.IsUpdated(conMandarinCase.OwnerId))
 {
 if (objMandarinCaseEN.OwnerId !=  null)
 {
 var strOwnerId = objMandarinCaseEN.OwnerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strOwnerId, conMandarinCase.OwnerId); //拥有者Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conMandarinCase.OwnerId); //拥有者Id
 }
 }
 
 if (objMandarinCaseEN.IsUpdated(conMandarinCase.IsDualVideo))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objMandarinCaseEN.IsDualVideo == true?"1":"0", conMandarinCase.IsDualVideo); //是否双视频
 }
 
 if (objMandarinCaseEN.IsUpdated(conMandarinCase.IdMandarinCaseType))
 {
 if (objMandarinCaseEN.IdMandarinCaseType !=  null)
 {
 var strIdMandarinCaseType = objMandarinCaseEN.IdMandarinCaseType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdMandarinCaseType, conMandarinCase.IdMandarinCaseType); //普通话案例类型流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conMandarinCase.IdMandarinCaseType); //普通话案例类型流水号
 }
 }
 
 if (objMandarinCaseEN.IsUpdated(conMandarinCase.UserTypeId))
 {
 if (objMandarinCaseEN.UserTypeId !=  null)
 {
 var strUserTypeId = objMandarinCaseEN.UserTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUserTypeId, conMandarinCase.UserTypeId); //用户类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conMandarinCase.UserTypeId); //用户类型Id
 }
 }
 
 if (objMandarinCaseEN.IsUpdated(conMandarinCase.RecommendedDegreeId))
 {
 if (objMandarinCaseEN.RecommendedDegreeId !=  null)
 {
 var strRecommendedDegreeId = objMandarinCaseEN.RecommendedDegreeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strRecommendedDegreeId, conMandarinCase.RecommendedDegreeId); //推荐度Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conMandarinCase.RecommendedDegreeId); //推荐度Id
 }
 }
 
 if (objMandarinCaseEN.IsUpdated(conMandarinCase.ftpFileType))
 {
 if (objMandarinCaseEN.ftpFileType !=  null)
 {
 var strftpFileType = objMandarinCaseEN.ftpFileType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strftpFileType, conMandarinCase.ftpFileType); //ftp文件类型
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conMandarinCase.ftpFileType); //ftp文件类型
 }
 }
 
 if (objMandarinCaseEN.IsUpdated(conMandarinCase.VideoUrl))
 {
 if (objMandarinCaseEN.VideoUrl !=  null)
 {
 var strVideoUrl = objMandarinCaseEN.VideoUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strVideoUrl, conMandarinCase.VideoUrl); //视频Url
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conMandarinCase.VideoUrl); //视频Url
 }
 }
 
 if (objMandarinCaseEN.IsUpdated(conMandarinCase.VideoPath))
 {
 if (objMandarinCaseEN.VideoPath !=  null)
 {
 var strVideoPath = objMandarinCaseEN.VideoPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strVideoPath, conMandarinCase.VideoPath); //视频目录
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conMandarinCase.VideoPath); //视频目录
 }
 }
 
 if (objMandarinCaseEN.IsUpdated(conMandarinCase.ResErrMsg))
 {
 if (objMandarinCaseEN.ResErrMsg !=  null)
 {
 var strResErrMsg = objMandarinCaseEN.ResErrMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strResErrMsg, conMandarinCase.ResErrMsg); //资源错误信息
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conMandarinCase.ResErrMsg); //资源错误信息
 }
 }
 
 if (objMandarinCaseEN.IsUpdated(conMandarinCase.UpdDate))
 {
 if (objMandarinCaseEN.UpdDate !=  null)
 {
 var strUpdDate = objMandarinCaseEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conMandarinCase.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conMandarinCase.UpdDate); //修改日期
 }
 }
 
 if (objMandarinCaseEN.IsUpdated(conMandarinCase.UpdUserId))
 {
 if (objMandarinCaseEN.UpdUserId !=  null)
 {
 var strUpdUserId = objMandarinCaseEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUserId, conMandarinCase.UpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conMandarinCase.UpdUserId); //修改用户Id
 }
 }
 
 if (objMandarinCaseEN.IsUpdated(conMandarinCase.Memo))
 {
 if (objMandarinCaseEN.Memo !=  null)
 {
 var strMemo = objMandarinCaseEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conMandarinCase.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conMandarinCase.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where IdMandarinCase = '{0}'", objMandarinCaseEN.IdMandarinCase); 
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
 /// <param name = "objMandarinCaseEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsMandarinCaseEN objMandarinCaseEN, string strCondition)
{
 objMandarinCaseEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objMandarinCaseEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objMandarinCaseEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsMandarinCaseDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update MandarinCase Set ");
 
 if (objMandarinCaseEN.IsUpdated(conMandarinCase.MandarinCaseID))
 {
 if (objMandarinCaseEN.MandarinCaseID !=  null)
 {
 var strMandarinCaseID = objMandarinCaseEN.MandarinCaseID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" MandarinCaseID = '{0}',", strMandarinCaseID); //普通话教学案例ID
 }
 else
 {
 sbSQL.Append(" MandarinCaseID = null,"); //普通话教学案例ID
 }
 }
 
 if (objMandarinCaseEN.IsUpdated(conMandarinCase.MandarinCaseName))
 {
 if (objMandarinCaseEN.MandarinCaseName !=  null)
 {
 var strMandarinCaseName = objMandarinCaseEN.MandarinCaseName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" MandarinCaseName = '{0}',", strMandarinCaseName); //普通话教学案例名称
 }
 else
 {
 sbSQL.Append(" MandarinCaseName = null,"); //普通话教学案例名称
 }
 }
 
 if (objMandarinCaseEN.IsUpdated(conMandarinCase.IdDiscipline))
 {
 if (objMandarinCaseEN.IdDiscipline !=  null)
 {
 var strIdDiscipline = objMandarinCaseEN.IdDiscipline.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdDiscipline = '{0}',", strIdDiscipline); //学科流水号
 }
 else
 {
 sbSQL.Append(" IdDiscipline = null,"); //学科流水号
 }
 }
 
 if (objMandarinCaseEN.IsUpdated(conMandarinCase.IdStudyLevel))
 {
 if (objMandarinCaseEN.IdStudyLevel !=  null)
 {
 var strIdStudyLevel = objMandarinCaseEN.IdStudyLevel.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdStudyLevel = '{0}',", strIdStudyLevel); //学段流水号
 }
 else
 {
 sbSQL.Append(" IdStudyLevel = null,"); //学段流水号
 }
 }
 
 if (objMandarinCaseEN.IsUpdated(conMandarinCase.MandarinCaseTheme))
 {
 if (objMandarinCaseEN.MandarinCaseTheme !=  null)
 {
 var strMandarinCaseTheme = objMandarinCaseEN.MandarinCaseTheme.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" MandarinCaseTheme = '{0}',", strMandarinCaseTheme); //普通话教学案例主题词
 }
 else
 {
 sbSQL.Append(" MandarinCaseTheme = null,"); //普通话教学案例主题词
 }
 }
 
 if (objMandarinCaseEN.IsUpdated(conMandarinCase.MandarinCaseDate))
 {
 if (objMandarinCaseEN.MandarinCaseDate !=  null)
 {
 var strMandarinCaseDate = objMandarinCaseEN.MandarinCaseDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" MandarinCaseDate = '{0}',", strMandarinCaseDate); //普通话教学日期
 }
 else
 {
 sbSQL.Append(" MandarinCaseDate = null,"); //普通话教学日期
 }
 }
 
 if (objMandarinCaseEN.IsUpdated(conMandarinCase.MandarinCaseTime))
 {
 if (objMandarinCaseEN.MandarinCaseTime !=  null)
 {
 var strMandarinCaseTime = objMandarinCaseEN.MandarinCaseTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" MandarinCaseTime = '{0}',", strMandarinCaseTime); //普通话教学时间
 }
 else
 {
 sbSQL.Append(" MandarinCaseTime = null,"); //普通话教学时间
 }
 }
 
 if (objMandarinCaseEN.IsUpdated(conMandarinCase.MandarinCaseDateIn))
 {
 if (objMandarinCaseEN.MandarinCaseDateIn !=  null)
 {
 var strMandarinCaseDateIn = objMandarinCaseEN.MandarinCaseDateIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" MandarinCaseDateIn = '{0}',", strMandarinCaseDateIn); //案例入库日期
 }
 else
 {
 sbSQL.Append(" MandarinCaseDateIn = null,"); //案例入库日期
 }
 }
 
 if (objMandarinCaseEN.IsUpdated(conMandarinCase.MandarinCaseTimeIn))
 {
 if (objMandarinCaseEN.MandarinCaseTimeIn !=  null)
 {
 var strMandarinCaseTimeIn = objMandarinCaseEN.MandarinCaseTimeIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" MandarinCaseTimeIn = '{0}',", strMandarinCaseTimeIn); //案例入库时间
 }
 else
 {
 sbSQL.Append(" MandarinCaseTimeIn = null,"); //案例入库时间
 }
 }
 
 if (objMandarinCaseEN.IsUpdated(conMandarinCase.IdTeachingPlan))
 {
 if (objMandarinCaseEN.IdTeachingPlan !=  null)
 {
 var strIdTeachingPlan = objMandarinCaseEN.IdTeachingPlan.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdTeachingPlan = '{0}',", strIdTeachingPlan); //教案流水号
 }
 else
 {
 sbSQL.Append(" IdTeachingPlan = null,"); //教案流水号
 }
 }
 
 if (objMandarinCaseEN.IsUpdated(conMandarinCase.IdSenateGaugeVersion))
 {
 if (objMandarinCaseEN.IdSenateGaugeVersion !=  null)
 {
 var strIdSenateGaugeVersion = objMandarinCaseEN.IdSenateGaugeVersion.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdSenateGaugeVersion = '{0}',", strIdSenateGaugeVersion); //评价量表版本流水号
 }
 else
 {
 sbSQL.Append(" IdSenateGaugeVersion = null,"); //评价量表版本流水号
 }
 }
 
 if (objMandarinCaseEN.IsUpdated(conMandarinCase.CaseLevelId))
 {
 if (objMandarinCaseEN.CaseLevelId !=  null)
 {
 var strCaseLevelId = objMandarinCaseEN.CaseLevelId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CaseLevelId = '{0}',", strCaseLevelId); //课例等级Id
 }
 else
 {
 sbSQL.Append(" CaseLevelId = null,"); //课例等级Id
 }
 }
 
 if (objMandarinCaseEN.IsUpdated(conMandarinCase.IsNeedGeneWord))
 {
 sbSQL.AppendFormat(" IsNeedGeneWord = '{0}',", objMandarinCaseEN.IsNeedGeneWord == true?"1":"0"); //是否需要生成Word
 }
 
 if (objMandarinCaseEN.IsUpdated(conMandarinCase.DocFile))
 {
 if (objMandarinCaseEN.DocFile !=  null)
 {
 var strDocFile = objMandarinCaseEN.DocFile.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DocFile = '{0}',", strDocFile); //生成的Word文件名
 }
 else
 {
 sbSQL.Append(" DocFile = null,"); //生成的Word文件名
 }
 }
 
 if (objMandarinCaseEN.IsUpdated(conMandarinCase.WordCreateDate))
 {
 if (objMandarinCaseEN.WordCreateDate !=  null)
 {
 var strWordCreateDate = objMandarinCaseEN.WordCreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" WordCreateDate = '{0}',", strWordCreateDate); //Word生成日期
 }
 else
 {
 sbSQL.Append(" WordCreateDate = null,"); //Word生成日期
 }
 }
 
 if (objMandarinCaseEN.IsUpdated(conMandarinCase.BrowseCount))
 {
 if (objMandarinCaseEN.BrowseCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objMandarinCaseEN.BrowseCount, conMandarinCase.BrowseCount); //浏览次数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conMandarinCase.BrowseCount); //浏览次数
 }
 }
 
 if (objMandarinCaseEN.IsUpdated(conMandarinCase.IsVisible))
 {
 sbSQL.AppendFormat(" IsVisible = '{0}',", objMandarinCaseEN.IsVisible == true?"1":"0"); //是否显示
 }
 
 if (objMandarinCaseEN.IsUpdated(conMandarinCase.OwnerId))
 {
 if (objMandarinCaseEN.OwnerId !=  null)
 {
 var strOwnerId = objMandarinCaseEN.OwnerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" OwnerId = '{0}',", strOwnerId); //拥有者Id
 }
 else
 {
 sbSQL.Append(" OwnerId = null,"); //拥有者Id
 }
 }
 
 if (objMandarinCaseEN.IsUpdated(conMandarinCase.IsDualVideo))
 {
 sbSQL.AppendFormat(" IsDualVideo = '{0}',", objMandarinCaseEN.IsDualVideo == true?"1":"0"); //是否双视频
 }
 
 if (objMandarinCaseEN.IsUpdated(conMandarinCase.IdMandarinCaseType))
 {
 if (objMandarinCaseEN.IdMandarinCaseType !=  null)
 {
 var strIdMandarinCaseType = objMandarinCaseEN.IdMandarinCaseType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdMandarinCaseType = '{0}',", strIdMandarinCaseType); //普通话案例类型流水号
 }
 else
 {
 sbSQL.Append(" IdMandarinCaseType = null,"); //普通话案例类型流水号
 }
 }
 
 if (objMandarinCaseEN.IsUpdated(conMandarinCase.UserTypeId))
 {
 if (objMandarinCaseEN.UserTypeId !=  null)
 {
 var strUserTypeId = objMandarinCaseEN.UserTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UserTypeId = '{0}',", strUserTypeId); //用户类型Id
 }
 else
 {
 sbSQL.Append(" UserTypeId = null,"); //用户类型Id
 }
 }
 
 if (objMandarinCaseEN.IsUpdated(conMandarinCase.RecommendedDegreeId))
 {
 if (objMandarinCaseEN.RecommendedDegreeId !=  null)
 {
 var strRecommendedDegreeId = objMandarinCaseEN.RecommendedDegreeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" RecommendedDegreeId = '{0}',", strRecommendedDegreeId); //推荐度Id
 }
 else
 {
 sbSQL.Append(" RecommendedDegreeId = null,"); //推荐度Id
 }
 }
 
 if (objMandarinCaseEN.IsUpdated(conMandarinCase.ftpFileType))
 {
 if (objMandarinCaseEN.ftpFileType !=  null)
 {
 var strftpFileType = objMandarinCaseEN.ftpFileType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ftpFileType = '{0}',", strftpFileType); //ftp文件类型
 }
 else
 {
 sbSQL.Append(" ftpFileType = null,"); //ftp文件类型
 }
 }
 
 if (objMandarinCaseEN.IsUpdated(conMandarinCase.VideoUrl))
 {
 if (objMandarinCaseEN.VideoUrl !=  null)
 {
 var strVideoUrl = objMandarinCaseEN.VideoUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" VideoUrl = '{0}',", strVideoUrl); //视频Url
 }
 else
 {
 sbSQL.Append(" VideoUrl = null,"); //视频Url
 }
 }
 
 if (objMandarinCaseEN.IsUpdated(conMandarinCase.VideoPath))
 {
 if (objMandarinCaseEN.VideoPath !=  null)
 {
 var strVideoPath = objMandarinCaseEN.VideoPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" VideoPath = '{0}',", strVideoPath); //视频目录
 }
 else
 {
 sbSQL.Append(" VideoPath = null,"); //视频目录
 }
 }
 
 if (objMandarinCaseEN.IsUpdated(conMandarinCase.ResErrMsg))
 {
 if (objMandarinCaseEN.ResErrMsg !=  null)
 {
 var strResErrMsg = objMandarinCaseEN.ResErrMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ResErrMsg = '{0}',", strResErrMsg); //资源错误信息
 }
 else
 {
 sbSQL.Append(" ResErrMsg = null,"); //资源错误信息
 }
 }
 
 if (objMandarinCaseEN.IsUpdated(conMandarinCase.UpdDate))
 {
 if (objMandarinCaseEN.UpdDate !=  null)
 {
 var strUpdDate = objMandarinCaseEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objMandarinCaseEN.IsUpdated(conMandarinCase.UpdUserId))
 {
 if (objMandarinCaseEN.UpdUserId !=  null)
 {
 var strUpdUserId = objMandarinCaseEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUserId = '{0}',", strUpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.Append(" UpdUserId = null,"); //修改用户Id
 }
 }
 
 if (objMandarinCaseEN.IsUpdated(conMandarinCase.Memo))
 {
 if (objMandarinCaseEN.Memo !=  null)
 {
 var strMemo = objMandarinCaseEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objMandarinCaseEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsMandarinCaseEN objMandarinCaseEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objMandarinCaseEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objMandarinCaseEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objMandarinCaseEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsMandarinCaseDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update MandarinCase Set ");
 
 if (objMandarinCaseEN.IsUpdated(conMandarinCase.MandarinCaseID))
 {
 if (objMandarinCaseEN.MandarinCaseID !=  null)
 {
 var strMandarinCaseID = objMandarinCaseEN.MandarinCaseID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" MandarinCaseID = '{0}',", strMandarinCaseID); //普通话教学案例ID
 }
 else
 {
 sbSQL.Append(" MandarinCaseID = null,"); //普通话教学案例ID
 }
 }
 
 if (objMandarinCaseEN.IsUpdated(conMandarinCase.MandarinCaseName))
 {
 if (objMandarinCaseEN.MandarinCaseName !=  null)
 {
 var strMandarinCaseName = objMandarinCaseEN.MandarinCaseName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" MandarinCaseName = '{0}',", strMandarinCaseName); //普通话教学案例名称
 }
 else
 {
 sbSQL.Append(" MandarinCaseName = null,"); //普通话教学案例名称
 }
 }
 
 if (objMandarinCaseEN.IsUpdated(conMandarinCase.IdDiscipline))
 {
 if (objMandarinCaseEN.IdDiscipline !=  null)
 {
 var strIdDiscipline = objMandarinCaseEN.IdDiscipline.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdDiscipline = '{0}',", strIdDiscipline); //学科流水号
 }
 else
 {
 sbSQL.Append(" IdDiscipline = null,"); //学科流水号
 }
 }
 
 if (objMandarinCaseEN.IsUpdated(conMandarinCase.IdStudyLevel))
 {
 if (objMandarinCaseEN.IdStudyLevel !=  null)
 {
 var strIdStudyLevel = objMandarinCaseEN.IdStudyLevel.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdStudyLevel = '{0}',", strIdStudyLevel); //学段流水号
 }
 else
 {
 sbSQL.Append(" IdStudyLevel = null,"); //学段流水号
 }
 }
 
 if (objMandarinCaseEN.IsUpdated(conMandarinCase.MandarinCaseTheme))
 {
 if (objMandarinCaseEN.MandarinCaseTheme !=  null)
 {
 var strMandarinCaseTheme = objMandarinCaseEN.MandarinCaseTheme.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" MandarinCaseTheme = '{0}',", strMandarinCaseTheme); //普通话教学案例主题词
 }
 else
 {
 sbSQL.Append(" MandarinCaseTheme = null,"); //普通话教学案例主题词
 }
 }
 
 if (objMandarinCaseEN.IsUpdated(conMandarinCase.MandarinCaseDate))
 {
 if (objMandarinCaseEN.MandarinCaseDate !=  null)
 {
 var strMandarinCaseDate = objMandarinCaseEN.MandarinCaseDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" MandarinCaseDate = '{0}',", strMandarinCaseDate); //普通话教学日期
 }
 else
 {
 sbSQL.Append(" MandarinCaseDate = null,"); //普通话教学日期
 }
 }
 
 if (objMandarinCaseEN.IsUpdated(conMandarinCase.MandarinCaseTime))
 {
 if (objMandarinCaseEN.MandarinCaseTime !=  null)
 {
 var strMandarinCaseTime = objMandarinCaseEN.MandarinCaseTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" MandarinCaseTime = '{0}',", strMandarinCaseTime); //普通话教学时间
 }
 else
 {
 sbSQL.Append(" MandarinCaseTime = null,"); //普通话教学时间
 }
 }
 
 if (objMandarinCaseEN.IsUpdated(conMandarinCase.MandarinCaseDateIn))
 {
 if (objMandarinCaseEN.MandarinCaseDateIn !=  null)
 {
 var strMandarinCaseDateIn = objMandarinCaseEN.MandarinCaseDateIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" MandarinCaseDateIn = '{0}',", strMandarinCaseDateIn); //案例入库日期
 }
 else
 {
 sbSQL.Append(" MandarinCaseDateIn = null,"); //案例入库日期
 }
 }
 
 if (objMandarinCaseEN.IsUpdated(conMandarinCase.MandarinCaseTimeIn))
 {
 if (objMandarinCaseEN.MandarinCaseTimeIn !=  null)
 {
 var strMandarinCaseTimeIn = objMandarinCaseEN.MandarinCaseTimeIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" MandarinCaseTimeIn = '{0}',", strMandarinCaseTimeIn); //案例入库时间
 }
 else
 {
 sbSQL.Append(" MandarinCaseTimeIn = null,"); //案例入库时间
 }
 }
 
 if (objMandarinCaseEN.IsUpdated(conMandarinCase.IdTeachingPlan))
 {
 if (objMandarinCaseEN.IdTeachingPlan !=  null)
 {
 var strIdTeachingPlan = objMandarinCaseEN.IdTeachingPlan.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdTeachingPlan = '{0}',", strIdTeachingPlan); //教案流水号
 }
 else
 {
 sbSQL.Append(" IdTeachingPlan = null,"); //教案流水号
 }
 }
 
 if (objMandarinCaseEN.IsUpdated(conMandarinCase.IdSenateGaugeVersion))
 {
 if (objMandarinCaseEN.IdSenateGaugeVersion !=  null)
 {
 var strIdSenateGaugeVersion = objMandarinCaseEN.IdSenateGaugeVersion.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdSenateGaugeVersion = '{0}',", strIdSenateGaugeVersion); //评价量表版本流水号
 }
 else
 {
 sbSQL.Append(" IdSenateGaugeVersion = null,"); //评价量表版本流水号
 }
 }
 
 if (objMandarinCaseEN.IsUpdated(conMandarinCase.CaseLevelId))
 {
 if (objMandarinCaseEN.CaseLevelId !=  null)
 {
 var strCaseLevelId = objMandarinCaseEN.CaseLevelId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CaseLevelId = '{0}',", strCaseLevelId); //课例等级Id
 }
 else
 {
 sbSQL.Append(" CaseLevelId = null,"); //课例等级Id
 }
 }
 
 if (objMandarinCaseEN.IsUpdated(conMandarinCase.IsNeedGeneWord))
 {
 sbSQL.AppendFormat(" IsNeedGeneWord = '{0}',", objMandarinCaseEN.IsNeedGeneWord == true?"1":"0"); //是否需要生成Word
 }
 
 if (objMandarinCaseEN.IsUpdated(conMandarinCase.DocFile))
 {
 if (objMandarinCaseEN.DocFile !=  null)
 {
 var strDocFile = objMandarinCaseEN.DocFile.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DocFile = '{0}',", strDocFile); //生成的Word文件名
 }
 else
 {
 sbSQL.Append(" DocFile = null,"); //生成的Word文件名
 }
 }
 
 if (objMandarinCaseEN.IsUpdated(conMandarinCase.WordCreateDate))
 {
 if (objMandarinCaseEN.WordCreateDate !=  null)
 {
 var strWordCreateDate = objMandarinCaseEN.WordCreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" WordCreateDate = '{0}',", strWordCreateDate); //Word生成日期
 }
 else
 {
 sbSQL.Append(" WordCreateDate = null,"); //Word生成日期
 }
 }
 
 if (objMandarinCaseEN.IsUpdated(conMandarinCase.BrowseCount))
 {
 if (objMandarinCaseEN.BrowseCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objMandarinCaseEN.BrowseCount, conMandarinCase.BrowseCount); //浏览次数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conMandarinCase.BrowseCount); //浏览次数
 }
 }
 
 if (objMandarinCaseEN.IsUpdated(conMandarinCase.IsVisible))
 {
 sbSQL.AppendFormat(" IsVisible = '{0}',", objMandarinCaseEN.IsVisible == true?"1":"0"); //是否显示
 }
 
 if (objMandarinCaseEN.IsUpdated(conMandarinCase.OwnerId))
 {
 if (objMandarinCaseEN.OwnerId !=  null)
 {
 var strOwnerId = objMandarinCaseEN.OwnerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" OwnerId = '{0}',", strOwnerId); //拥有者Id
 }
 else
 {
 sbSQL.Append(" OwnerId = null,"); //拥有者Id
 }
 }
 
 if (objMandarinCaseEN.IsUpdated(conMandarinCase.IsDualVideo))
 {
 sbSQL.AppendFormat(" IsDualVideo = '{0}',", objMandarinCaseEN.IsDualVideo == true?"1":"0"); //是否双视频
 }
 
 if (objMandarinCaseEN.IsUpdated(conMandarinCase.IdMandarinCaseType))
 {
 if (objMandarinCaseEN.IdMandarinCaseType !=  null)
 {
 var strIdMandarinCaseType = objMandarinCaseEN.IdMandarinCaseType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdMandarinCaseType = '{0}',", strIdMandarinCaseType); //普通话案例类型流水号
 }
 else
 {
 sbSQL.Append(" IdMandarinCaseType = null,"); //普通话案例类型流水号
 }
 }
 
 if (objMandarinCaseEN.IsUpdated(conMandarinCase.UserTypeId))
 {
 if (objMandarinCaseEN.UserTypeId !=  null)
 {
 var strUserTypeId = objMandarinCaseEN.UserTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UserTypeId = '{0}',", strUserTypeId); //用户类型Id
 }
 else
 {
 sbSQL.Append(" UserTypeId = null,"); //用户类型Id
 }
 }
 
 if (objMandarinCaseEN.IsUpdated(conMandarinCase.RecommendedDegreeId))
 {
 if (objMandarinCaseEN.RecommendedDegreeId !=  null)
 {
 var strRecommendedDegreeId = objMandarinCaseEN.RecommendedDegreeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" RecommendedDegreeId = '{0}',", strRecommendedDegreeId); //推荐度Id
 }
 else
 {
 sbSQL.Append(" RecommendedDegreeId = null,"); //推荐度Id
 }
 }
 
 if (objMandarinCaseEN.IsUpdated(conMandarinCase.ftpFileType))
 {
 if (objMandarinCaseEN.ftpFileType !=  null)
 {
 var strftpFileType = objMandarinCaseEN.ftpFileType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ftpFileType = '{0}',", strftpFileType); //ftp文件类型
 }
 else
 {
 sbSQL.Append(" ftpFileType = null,"); //ftp文件类型
 }
 }
 
 if (objMandarinCaseEN.IsUpdated(conMandarinCase.VideoUrl))
 {
 if (objMandarinCaseEN.VideoUrl !=  null)
 {
 var strVideoUrl = objMandarinCaseEN.VideoUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" VideoUrl = '{0}',", strVideoUrl); //视频Url
 }
 else
 {
 sbSQL.Append(" VideoUrl = null,"); //视频Url
 }
 }
 
 if (objMandarinCaseEN.IsUpdated(conMandarinCase.VideoPath))
 {
 if (objMandarinCaseEN.VideoPath !=  null)
 {
 var strVideoPath = objMandarinCaseEN.VideoPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" VideoPath = '{0}',", strVideoPath); //视频目录
 }
 else
 {
 sbSQL.Append(" VideoPath = null,"); //视频目录
 }
 }
 
 if (objMandarinCaseEN.IsUpdated(conMandarinCase.ResErrMsg))
 {
 if (objMandarinCaseEN.ResErrMsg !=  null)
 {
 var strResErrMsg = objMandarinCaseEN.ResErrMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ResErrMsg = '{0}',", strResErrMsg); //资源错误信息
 }
 else
 {
 sbSQL.Append(" ResErrMsg = null,"); //资源错误信息
 }
 }
 
 if (objMandarinCaseEN.IsUpdated(conMandarinCase.UpdDate))
 {
 if (objMandarinCaseEN.UpdDate !=  null)
 {
 var strUpdDate = objMandarinCaseEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objMandarinCaseEN.IsUpdated(conMandarinCase.UpdUserId))
 {
 if (objMandarinCaseEN.UpdUserId !=  null)
 {
 var strUpdUserId = objMandarinCaseEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUserId = '{0}',", strUpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.Append(" UpdUserId = null,"); //修改用户Id
 }
 }
 
 if (objMandarinCaseEN.IsUpdated(conMandarinCase.Memo))
 {
 if (objMandarinCaseEN.Memo !=  null)
 {
 var strMemo = objMandarinCaseEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objMandarinCaseEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsMandarinCaseEN objMandarinCaseEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objMandarinCaseEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objMandarinCaseEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objMandarinCaseEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsMandarinCaseDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update MandarinCase Set ");
 
 if (objMandarinCaseEN.IsUpdated(conMandarinCase.MandarinCaseID))
 {
 if (objMandarinCaseEN.MandarinCaseID !=  null)
 {
 var strMandarinCaseID = objMandarinCaseEN.MandarinCaseID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMandarinCaseID, conMandarinCase.MandarinCaseID); //普通话教学案例ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conMandarinCase.MandarinCaseID); //普通话教学案例ID
 }
 }
 
 if (objMandarinCaseEN.IsUpdated(conMandarinCase.MandarinCaseName))
 {
 if (objMandarinCaseEN.MandarinCaseName !=  null)
 {
 var strMandarinCaseName = objMandarinCaseEN.MandarinCaseName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMandarinCaseName, conMandarinCase.MandarinCaseName); //普通话教学案例名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conMandarinCase.MandarinCaseName); //普通话教学案例名称
 }
 }
 
 if (objMandarinCaseEN.IsUpdated(conMandarinCase.IdDiscipline))
 {
 if (objMandarinCaseEN.IdDiscipline !=  null)
 {
 var strIdDiscipline = objMandarinCaseEN.IdDiscipline.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdDiscipline, conMandarinCase.IdDiscipline); //学科流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conMandarinCase.IdDiscipline); //学科流水号
 }
 }
 
 if (objMandarinCaseEN.IsUpdated(conMandarinCase.IdStudyLevel))
 {
 if (objMandarinCaseEN.IdStudyLevel !=  null)
 {
 var strIdStudyLevel = objMandarinCaseEN.IdStudyLevel.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdStudyLevel, conMandarinCase.IdStudyLevel); //学段流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conMandarinCase.IdStudyLevel); //学段流水号
 }
 }
 
 if (objMandarinCaseEN.IsUpdated(conMandarinCase.MandarinCaseTheme))
 {
 if (objMandarinCaseEN.MandarinCaseTheme !=  null)
 {
 var strMandarinCaseTheme = objMandarinCaseEN.MandarinCaseTheme.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMandarinCaseTheme, conMandarinCase.MandarinCaseTheme); //普通话教学案例主题词
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conMandarinCase.MandarinCaseTheme); //普通话教学案例主题词
 }
 }
 
 if (objMandarinCaseEN.IsUpdated(conMandarinCase.MandarinCaseDate))
 {
 if (objMandarinCaseEN.MandarinCaseDate !=  null)
 {
 var strMandarinCaseDate = objMandarinCaseEN.MandarinCaseDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMandarinCaseDate, conMandarinCase.MandarinCaseDate); //普通话教学日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conMandarinCase.MandarinCaseDate); //普通话教学日期
 }
 }
 
 if (objMandarinCaseEN.IsUpdated(conMandarinCase.MandarinCaseTime))
 {
 if (objMandarinCaseEN.MandarinCaseTime !=  null)
 {
 var strMandarinCaseTime = objMandarinCaseEN.MandarinCaseTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMandarinCaseTime, conMandarinCase.MandarinCaseTime); //普通话教学时间
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conMandarinCase.MandarinCaseTime); //普通话教学时间
 }
 }
 
 if (objMandarinCaseEN.IsUpdated(conMandarinCase.MandarinCaseDateIn))
 {
 if (objMandarinCaseEN.MandarinCaseDateIn !=  null)
 {
 var strMandarinCaseDateIn = objMandarinCaseEN.MandarinCaseDateIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMandarinCaseDateIn, conMandarinCase.MandarinCaseDateIn); //案例入库日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conMandarinCase.MandarinCaseDateIn); //案例入库日期
 }
 }
 
 if (objMandarinCaseEN.IsUpdated(conMandarinCase.MandarinCaseTimeIn))
 {
 if (objMandarinCaseEN.MandarinCaseTimeIn !=  null)
 {
 var strMandarinCaseTimeIn = objMandarinCaseEN.MandarinCaseTimeIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMandarinCaseTimeIn, conMandarinCase.MandarinCaseTimeIn); //案例入库时间
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conMandarinCase.MandarinCaseTimeIn); //案例入库时间
 }
 }
 
 if (objMandarinCaseEN.IsUpdated(conMandarinCase.IdTeachingPlan))
 {
 if (objMandarinCaseEN.IdTeachingPlan !=  null)
 {
 var strIdTeachingPlan = objMandarinCaseEN.IdTeachingPlan.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdTeachingPlan, conMandarinCase.IdTeachingPlan); //教案流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conMandarinCase.IdTeachingPlan); //教案流水号
 }
 }
 
 if (objMandarinCaseEN.IsUpdated(conMandarinCase.IdSenateGaugeVersion))
 {
 if (objMandarinCaseEN.IdSenateGaugeVersion !=  null)
 {
 var strIdSenateGaugeVersion = objMandarinCaseEN.IdSenateGaugeVersion.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdSenateGaugeVersion, conMandarinCase.IdSenateGaugeVersion); //评价量表版本流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conMandarinCase.IdSenateGaugeVersion); //评价量表版本流水号
 }
 }
 
 if (objMandarinCaseEN.IsUpdated(conMandarinCase.CaseLevelId))
 {
 if (objMandarinCaseEN.CaseLevelId !=  null)
 {
 var strCaseLevelId = objMandarinCaseEN.CaseLevelId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCaseLevelId, conMandarinCase.CaseLevelId); //课例等级Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conMandarinCase.CaseLevelId); //课例等级Id
 }
 }
 
 if (objMandarinCaseEN.IsUpdated(conMandarinCase.IsNeedGeneWord))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objMandarinCaseEN.IsNeedGeneWord == true?"1":"0", conMandarinCase.IsNeedGeneWord); //是否需要生成Word
 }
 
 if (objMandarinCaseEN.IsUpdated(conMandarinCase.DocFile))
 {
 if (objMandarinCaseEN.DocFile !=  null)
 {
 var strDocFile = objMandarinCaseEN.DocFile.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strDocFile, conMandarinCase.DocFile); //生成的Word文件名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conMandarinCase.DocFile); //生成的Word文件名
 }
 }
 
 if (objMandarinCaseEN.IsUpdated(conMandarinCase.WordCreateDate))
 {
 if (objMandarinCaseEN.WordCreateDate !=  null)
 {
 var strWordCreateDate = objMandarinCaseEN.WordCreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strWordCreateDate, conMandarinCase.WordCreateDate); //Word生成日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conMandarinCase.WordCreateDate); //Word生成日期
 }
 }
 
 if (objMandarinCaseEN.IsUpdated(conMandarinCase.BrowseCount))
 {
 if (objMandarinCaseEN.BrowseCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objMandarinCaseEN.BrowseCount, conMandarinCase.BrowseCount); //浏览次数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conMandarinCase.BrowseCount); //浏览次数
 }
 }
 
 if (objMandarinCaseEN.IsUpdated(conMandarinCase.IsVisible))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objMandarinCaseEN.IsVisible == true?"1":"0", conMandarinCase.IsVisible); //是否显示
 }
 
 if (objMandarinCaseEN.IsUpdated(conMandarinCase.OwnerId))
 {
 if (objMandarinCaseEN.OwnerId !=  null)
 {
 var strOwnerId = objMandarinCaseEN.OwnerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strOwnerId, conMandarinCase.OwnerId); //拥有者Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conMandarinCase.OwnerId); //拥有者Id
 }
 }
 
 if (objMandarinCaseEN.IsUpdated(conMandarinCase.IsDualVideo))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objMandarinCaseEN.IsDualVideo == true?"1":"0", conMandarinCase.IsDualVideo); //是否双视频
 }
 
 if (objMandarinCaseEN.IsUpdated(conMandarinCase.IdMandarinCaseType))
 {
 if (objMandarinCaseEN.IdMandarinCaseType !=  null)
 {
 var strIdMandarinCaseType = objMandarinCaseEN.IdMandarinCaseType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdMandarinCaseType, conMandarinCase.IdMandarinCaseType); //普通话案例类型流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conMandarinCase.IdMandarinCaseType); //普通话案例类型流水号
 }
 }
 
 if (objMandarinCaseEN.IsUpdated(conMandarinCase.UserTypeId))
 {
 if (objMandarinCaseEN.UserTypeId !=  null)
 {
 var strUserTypeId = objMandarinCaseEN.UserTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUserTypeId, conMandarinCase.UserTypeId); //用户类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conMandarinCase.UserTypeId); //用户类型Id
 }
 }
 
 if (objMandarinCaseEN.IsUpdated(conMandarinCase.RecommendedDegreeId))
 {
 if (objMandarinCaseEN.RecommendedDegreeId !=  null)
 {
 var strRecommendedDegreeId = objMandarinCaseEN.RecommendedDegreeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strRecommendedDegreeId, conMandarinCase.RecommendedDegreeId); //推荐度Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conMandarinCase.RecommendedDegreeId); //推荐度Id
 }
 }
 
 if (objMandarinCaseEN.IsUpdated(conMandarinCase.ftpFileType))
 {
 if (objMandarinCaseEN.ftpFileType !=  null)
 {
 var strftpFileType = objMandarinCaseEN.ftpFileType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strftpFileType, conMandarinCase.ftpFileType); //ftp文件类型
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conMandarinCase.ftpFileType); //ftp文件类型
 }
 }
 
 if (objMandarinCaseEN.IsUpdated(conMandarinCase.VideoUrl))
 {
 if (objMandarinCaseEN.VideoUrl !=  null)
 {
 var strVideoUrl = objMandarinCaseEN.VideoUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strVideoUrl, conMandarinCase.VideoUrl); //视频Url
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conMandarinCase.VideoUrl); //视频Url
 }
 }
 
 if (objMandarinCaseEN.IsUpdated(conMandarinCase.VideoPath))
 {
 if (objMandarinCaseEN.VideoPath !=  null)
 {
 var strVideoPath = objMandarinCaseEN.VideoPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strVideoPath, conMandarinCase.VideoPath); //视频目录
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conMandarinCase.VideoPath); //视频目录
 }
 }
 
 if (objMandarinCaseEN.IsUpdated(conMandarinCase.ResErrMsg))
 {
 if (objMandarinCaseEN.ResErrMsg !=  null)
 {
 var strResErrMsg = objMandarinCaseEN.ResErrMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strResErrMsg, conMandarinCase.ResErrMsg); //资源错误信息
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conMandarinCase.ResErrMsg); //资源错误信息
 }
 }
 
 if (objMandarinCaseEN.IsUpdated(conMandarinCase.UpdDate))
 {
 if (objMandarinCaseEN.UpdDate !=  null)
 {
 var strUpdDate = objMandarinCaseEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conMandarinCase.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conMandarinCase.UpdDate); //修改日期
 }
 }
 
 if (objMandarinCaseEN.IsUpdated(conMandarinCase.UpdUserId))
 {
 if (objMandarinCaseEN.UpdUserId !=  null)
 {
 var strUpdUserId = objMandarinCaseEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUserId, conMandarinCase.UpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conMandarinCase.UpdUserId); //修改用户Id
 }
 }
 
 if (objMandarinCaseEN.IsUpdated(conMandarinCase.Memo))
 {
 if (objMandarinCaseEN.Memo !=  null)
 {
 var strMemo = objMandarinCaseEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conMandarinCase.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conMandarinCase.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where IdMandarinCase = '{0}'", objMandarinCaseEN.IdMandarinCase); 
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
 /// <param name = "strIdMandarinCase">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(string strIdMandarinCase) 
{
CheckPrimaryKey(strIdMandarinCase);
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsMandarinCaseDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 strIdMandarinCase,
};
 objSQL.ExecSP("MandarinCase_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "strIdMandarinCase">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(string strIdMandarinCase, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
CheckPrimaryKey(strIdMandarinCase);
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsMandarinCaseDA.GetSpecSQLObj();
//删除MandarinCase本表中与当前对象有关的记录
strSQL = strSQL + "Delete from MandarinCase where IdMandarinCase = " + "'"+ strIdMandarinCase+"'";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelMandarinCase(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsMandarinCaseDA.GetSpecSQLObj();
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
//删除MandarinCase本表中与当前对象有关的记录
strSQL = strSQL + "Delete from MandarinCase where IdMandarinCase in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "strIdMandarinCase">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(string strIdMandarinCase) 
{
CheckPrimaryKey(strIdMandarinCase);
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsMandarinCaseDA.GetSpecSQLObj();
//删除MandarinCase本表中与当前对象有关的记录
strSQL = strSQL + "Delete from MandarinCase where IdMandarinCase = " + "'"+ strIdMandarinCase+"'";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelMandarinCase(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsMandarinCaseDA: DelMandarinCase)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsMandarinCaseDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from MandarinCase where " + strCondition ;
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
public bool DelMandarinCaseWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsMandarinCaseDA: DelMandarinCaseWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsMandarinCaseDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from MandarinCase where " + strCondition ;
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
 /// <param name = "objMandarinCaseENS">源对象</param>
 /// <param name = "objMandarinCaseENT">目标对象</param>
public void CopyTo(clsMandarinCaseEN objMandarinCaseENS, clsMandarinCaseEN objMandarinCaseENT)
{
objMandarinCaseENT.IdMandarinCase = objMandarinCaseENS.IdMandarinCase; //普通话案例流水号
objMandarinCaseENT.MandarinCaseID = objMandarinCaseENS.MandarinCaseID; //普通话教学案例ID
objMandarinCaseENT.MandarinCaseName = objMandarinCaseENS.MandarinCaseName; //普通话教学案例名称
objMandarinCaseENT.IdDiscipline = objMandarinCaseENS.IdDiscipline; //学科流水号
objMandarinCaseENT.IdStudyLevel = objMandarinCaseENS.IdStudyLevel; //学段流水号
objMandarinCaseENT.MandarinCaseTheme = objMandarinCaseENS.MandarinCaseTheme; //普通话教学案例主题词
objMandarinCaseENT.MandarinCaseDate = objMandarinCaseENS.MandarinCaseDate; //普通话教学日期
objMandarinCaseENT.MandarinCaseTime = objMandarinCaseENS.MandarinCaseTime; //普通话教学时间
objMandarinCaseENT.MandarinCaseDateIn = objMandarinCaseENS.MandarinCaseDateIn; //案例入库日期
objMandarinCaseENT.MandarinCaseTimeIn = objMandarinCaseENS.MandarinCaseTimeIn; //案例入库时间
objMandarinCaseENT.IdTeachingPlan = objMandarinCaseENS.IdTeachingPlan; //教案流水号
objMandarinCaseENT.IdSenateGaugeVersion = objMandarinCaseENS.IdSenateGaugeVersion; //评价量表版本流水号
objMandarinCaseENT.CaseLevelId = objMandarinCaseENS.CaseLevelId; //课例等级Id
objMandarinCaseENT.IsNeedGeneWord = objMandarinCaseENS.IsNeedGeneWord; //是否需要生成Word
objMandarinCaseENT.DocFile = objMandarinCaseENS.DocFile; //生成的Word文件名
objMandarinCaseENT.WordCreateDate = objMandarinCaseENS.WordCreateDate; //Word生成日期
objMandarinCaseENT.BrowseCount = objMandarinCaseENS.BrowseCount; //浏览次数
objMandarinCaseENT.IsVisible = objMandarinCaseENS.IsVisible; //是否显示
objMandarinCaseENT.OwnerId = objMandarinCaseENS.OwnerId; //拥有者Id
objMandarinCaseENT.IsDualVideo = objMandarinCaseENS.IsDualVideo; //是否双视频
objMandarinCaseENT.IdMandarinCaseType = objMandarinCaseENS.IdMandarinCaseType; //普通话案例类型流水号
objMandarinCaseENT.UserTypeId = objMandarinCaseENS.UserTypeId; //用户类型Id
objMandarinCaseENT.RecommendedDegreeId = objMandarinCaseENS.RecommendedDegreeId; //推荐度Id
objMandarinCaseENT.ftpFileType = objMandarinCaseENS.ftpFileType; //ftp文件类型
objMandarinCaseENT.VideoUrl = objMandarinCaseENS.VideoUrl; //视频Url
objMandarinCaseENT.VideoPath = objMandarinCaseENS.VideoPath; //视频目录
objMandarinCaseENT.ResErrMsg = objMandarinCaseENS.ResErrMsg; //资源错误信息
objMandarinCaseENT.UpdDate = objMandarinCaseENS.UpdDate; //修改日期
objMandarinCaseENT.UpdUserId = objMandarinCaseENS.UpdUserId; //修改用户Id
objMandarinCaseENT.Memo = objMandarinCaseENS.Memo; //备注
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsMandarinCaseEN objMandarinCaseEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objMandarinCaseEN.MandarinCaseID, conMandarinCase.MandarinCaseID);
clsCheckSql.CheckFieldNotNull(objMandarinCaseEN.MandarinCaseName, conMandarinCase.MandarinCaseName);
clsCheckSql.CheckFieldNotNull(objMandarinCaseEN.IdDiscipline, conMandarinCase.IdDiscipline);
clsCheckSql.CheckFieldNotNull(objMandarinCaseEN.IdStudyLevel, conMandarinCase.IdStudyLevel);
clsCheckSql.CheckFieldNotNull(objMandarinCaseEN.IdTeachingPlan, conMandarinCase.IdTeachingPlan);
clsCheckSql.CheckFieldNotNull(objMandarinCaseEN.IdSenateGaugeVersion, conMandarinCase.IdSenateGaugeVersion);
clsCheckSql.CheckFieldNotNull(objMandarinCaseEN.OwnerId, conMandarinCase.OwnerId);
clsCheckSql.CheckFieldNotNull(objMandarinCaseEN.IsDualVideo, conMandarinCase.IsDualVideo);
clsCheckSql.CheckFieldNotNull(objMandarinCaseEN.RecommendedDegreeId, conMandarinCase.RecommendedDegreeId);
//检查字段长度
clsCheckSql.CheckFieldLen(objMandarinCaseEN.IdMandarinCase, 8, conMandarinCase.IdMandarinCase);
clsCheckSql.CheckFieldLen(objMandarinCaseEN.MandarinCaseID, 8, conMandarinCase.MandarinCaseID);
clsCheckSql.CheckFieldLen(objMandarinCaseEN.MandarinCaseName, 100, conMandarinCase.MandarinCaseName);
clsCheckSql.CheckFieldLen(objMandarinCaseEN.IdDiscipline, 4, conMandarinCase.IdDiscipline);
clsCheckSql.CheckFieldLen(objMandarinCaseEN.IdStudyLevel, 4, conMandarinCase.IdStudyLevel);
clsCheckSql.CheckFieldLen(objMandarinCaseEN.MandarinCaseTheme, 200, conMandarinCase.MandarinCaseTheme);
clsCheckSql.CheckFieldLen(objMandarinCaseEN.MandarinCaseDate, 8, conMandarinCase.MandarinCaseDate);
clsCheckSql.CheckFieldLen(objMandarinCaseEN.MandarinCaseTime, 6, conMandarinCase.MandarinCaseTime);
clsCheckSql.CheckFieldLen(objMandarinCaseEN.MandarinCaseDateIn, 8, conMandarinCase.MandarinCaseDateIn);
clsCheckSql.CheckFieldLen(objMandarinCaseEN.MandarinCaseTimeIn, 6, conMandarinCase.MandarinCaseTimeIn);
clsCheckSql.CheckFieldLen(objMandarinCaseEN.IdTeachingPlan, 8, conMandarinCase.IdTeachingPlan);
clsCheckSql.CheckFieldLen(objMandarinCaseEN.IdSenateGaugeVersion, 4, conMandarinCase.IdSenateGaugeVersion);
clsCheckSql.CheckFieldLen(objMandarinCaseEN.CaseLevelId, 2, conMandarinCase.CaseLevelId);
clsCheckSql.CheckFieldLen(objMandarinCaseEN.DocFile, 200, conMandarinCase.DocFile);
clsCheckSql.CheckFieldLen(objMandarinCaseEN.WordCreateDate, 14, conMandarinCase.WordCreateDate);
clsCheckSql.CheckFieldLen(objMandarinCaseEN.OwnerId, 20, conMandarinCase.OwnerId);
clsCheckSql.CheckFieldLen(objMandarinCaseEN.IdMandarinCaseType, 4, conMandarinCase.IdMandarinCaseType);
clsCheckSql.CheckFieldLen(objMandarinCaseEN.UserTypeId, 2, conMandarinCase.UserTypeId);
clsCheckSql.CheckFieldLen(objMandarinCaseEN.RecommendedDegreeId, 2, conMandarinCase.RecommendedDegreeId);
clsCheckSql.CheckFieldLen(objMandarinCaseEN.ftpFileType, 30, conMandarinCase.ftpFileType);
clsCheckSql.CheckFieldLen(objMandarinCaseEN.VideoUrl, 1000, conMandarinCase.VideoUrl);
clsCheckSql.CheckFieldLen(objMandarinCaseEN.VideoPath, 1000, conMandarinCase.VideoPath);
clsCheckSql.CheckFieldLen(objMandarinCaseEN.ResErrMsg, 30, conMandarinCase.ResErrMsg);
clsCheckSql.CheckFieldLen(objMandarinCaseEN.UpdDate, 20, conMandarinCase.UpdDate);
clsCheckSql.CheckFieldLen(objMandarinCaseEN.UpdUserId, 20, conMandarinCase.UpdUserId);
clsCheckSql.CheckFieldLen(objMandarinCaseEN.Memo, 1000, conMandarinCase.Memo);
//检查字段外键固定长度
 objMandarinCaseEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsMandarinCaseEN objMandarinCaseEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objMandarinCaseEN.MandarinCaseID, 8, conMandarinCase.MandarinCaseID);
clsCheckSql.CheckFieldLen(objMandarinCaseEN.MandarinCaseName, 100, conMandarinCase.MandarinCaseName);
clsCheckSql.CheckFieldLen(objMandarinCaseEN.IdDiscipline, 4, conMandarinCase.IdDiscipline);
clsCheckSql.CheckFieldLen(objMandarinCaseEN.IdStudyLevel, 4, conMandarinCase.IdStudyLevel);
clsCheckSql.CheckFieldLen(objMandarinCaseEN.MandarinCaseTheme, 200, conMandarinCase.MandarinCaseTheme);
clsCheckSql.CheckFieldLen(objMandarinCaseEN.MandarinCaseDate, 8, conMandarinCase.MandarinCaseDate);
clsCheckSql.CheckFieldLen(objMandarinCaseEN.MandarinCaseTime, 6, conMandarinCase.MandarinCaseTime);
clsCheckSql.CheckFieldLen(objMandarinCaseEN.MandarinCaseDateIn, 8, conMandarinCase.MandarinCaseDateIn);
clsCheckSql.CheckFieldLen(objMandarinCaseEN.MandarinCaseTimeIn, 6, conMandarinCase.MandarinCaseTimeIn);
clsCheckSql.CheckFieldLen(objMandarinCaseEN.IdTeachingPlan, 8, conMandarinCase.IdTeachingPlan);
clsCheckSql.CheckFieldLen(objMandarinCaseEN.IdSenateGaugeVersion, 4, conMandarinCase.IdSenateGaugeVersion);
clsCheckSql.CheckFieldLen(objMandarinCaseEN.CaseLevelId, 2, conMandarinCase.CaseLevelId);
clsCheckSql.CheckFieldLen(objMandarinCaseEN.DocFile, 200, conMandarinCase.DocFile);
clsCheckSql.CheckFieldLen(objMandarinCaseEN.WordCreateDate, 14, conMandarinCase.WordCreateDate);
clsCheckSql.CheckFieldLen(objMandarinCaseEN.OwnerId, 20, conMandarinCase.OwnerId);
clsCheckSql.CheckFieldLen(objMandarinCaseEN.IdMandarinCaseType, 4, conMandarinCase.IdMandarinCaseType);
clsCheckSql.CheckFieldLen(objMandarinCaseEN.UserTypeId, 2, conMandarinCase.UserTypeId);
clsCheckSql.CheckFieldLen(objMandarinCaseEN.RecommendedDegreeId, 2, conMandarinCase.RecommendedDegreeId);
clsCheckSql.CheckFieldLen(objMandarinCaseEN.ftpFileType, 30, conMandarinCase.ftpFileType);
clsCheckSql.CheckFieldLen(objMandarinCaseEN.VideoUrl, 1000, conMandarinCase.VideoUrl);
clsCheckSql.CheckFieldLen(objMandarinCaseEN.VideoPath, 1000, conMandarinCase.VideoPath);
clsCheckSql.CheckFieldLen(objMandarinCaseEN.ResErrMsg, 30, conMandarinCase.ResErrMsg);
clsCheckSql.CheckFieldLen(objMandarinCaseEN.UpdDate, 20, conMandarinCase.UpdDate);
clsCheckSql.CheckFieldLen(objMandarinCaseEN.UpdUserId, 20, conMandarinCase.UpdUserId);
clsCheckSql.CheckFieldLen(objMandarinCaseEN.Memo, 1000, conMandarinCase.Memo);
//检查外键字段长度
 objMandarinCaseEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsMandarinCaseEN objMandarinCaseEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objMandarinCaseEN.IdMandarinCase, 8, conMandarinCase.IdMandarinCase);
clsCheckSql.CheckFieldLen(objMandarinCaseEN.MandarinCaseID, 8, conMandarinCase.MandarinCaseID);
clsCheckSql.CheckFieldLen(objMandarinCaseEN.MandarinCaseName, 100, conMandarinCase.MandarinCaseName);
clsCheckSql.CheckFieldLen(objMandarinCaseEN.IdDiscipline, 4, conMandarinCase.IdDiscipline);
clsCheckSql.CheckFieldLen(objMandarinCaseEN.IdStudyLevel, 4, conMandarinCase.IdStudyLevel);
clsCheckSql.CheckFieldLen(objMandarinCaseEN.MandarinCaseTheme, 200, conMandarinCase.MandarinCaseTheme);
clsCheckSql.CheckFieldLen(objMandarinCaseEN.MandarinCaseDate, 8, conMandarinCase.MandarinCaseDate);
clsCheckSql.CheckFieldLen(objMandarinCaseEN.MandarinCaseTime, 6, conMandarinCase.MandarinCaseTime);
clsCheckSql.CheckFieldLen(objMandarinCaseEN.MandarinCaseDateIn, 8, conMandarinCase.MandarinCaseDateIn);
clsCheckSql.CheckFieldLen(objMandarinCaseEN.MandarinCaseTimeIn, 6, conMandarinCase.MandarinCaseTimeIn);
clsCheckSql.CheckFieldLen(objMandarinCaseEN.IdTeachingPlan, 8, conMandarinCase.IdTeachingPlan);
clsCheckSql.CheckFieldLen(objMandarinCaseEN.IdSenateGaugeVersion, 4, conMandarinCase.IdSenateGaugeVersion);
clsCheckSql.CheckFieldLen(objMandarinCaseEN.CaseLevelId, 2, conMandarinCase.CaseLevelId);
clsCheckSql.CheckFieldLen(objMandarinCaseEN.DocFile, 200, conMandarinCase.DocFile);
clsCheckSql.CheckFieldLen(objMandarinCaseEN.WordCreateDate, 14, conMandarinCase.WordCreateDate);
clsCheckSql.CheckFieldLen(objMandarinCaseEN.OwnerId, 20, conMandarinCase.OwnerId);
clsCheckSql.CheckFieldLen(objMandarinCaseEN.IdMandarinCaseType, 4, conMandarinCase.IdMandarinCaseType);
clsCheckSql.CheckFieldLen(objMandarinCaseEN.UserTypeId, 2, conMandarinCase.UserTypeId);
clsCheckSql.CheckFieldLen(objMandarinCaseEN.RecommendedDegreeId, 2, conMandarinCase.RecommendedDegreeId);
clsCheckSql.CheckFieldLen(objMandarinCaseEN.ftpFileType, 30, conMandarinCase.ftpFileType);
clsCheckSql.CheckFieldLen(objMandarinCaseEN.VideoUrl, 1000, conMandarinCase.VideoUrl);
clsCheckSql.CheckFieldLen(objMandarinCaseEN.VideoPath, 1000, conMandarinCase.VideoPath);
clsCheckSql.CheckFieldLen(objMandarinCaseEN.ResErrMsg, 30, conMandarinCase.ResErrMsg);
clsCheckSql.CheckFieldLen(objMandarinCaseEN.UpdDate, 20, conMandarinCase.UpdDate);
clsCheckSql.CheckFieldLen(objMandarinCaseEN.UpdUserId, 20, conMandarinCase.UpdUserId);
clsCheckSql.CheckFieldLen(objMandarinCaseEN.Memo, 1000, conMandarinCase.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objMandarinCaseEN.IdMandarinCase, conMandarinCase.IdMandarinCase);
clsCheckSql.CheckSqlInjection4Field(objMandarinCaseEN.MandarinCaseID, conMandarinCase.MandarinCaseID);
clsCheckSql.CheckSqlInjection4Field(objMandarinCaseEN.MandarinCaseName, conMandarinCase.MandarinCaseName);
clsCheckSql.CheckSqlInjection4Field(objMandarinCaseEN.IdDiscipline, conMandarinCase.IdDiscipline);
clsCheckSql.CheckSqlInjection4Field(objMandarinCaseEN.IdStudyLevel, conMandarinCase.IdStudyLevel);
clsCheckSql.CheckSqlInjection4Field(objMandarinCaseEN.MandarinCaseTheme, conMandarinCase.MandarinCaseTheme);
clsCheckSql.CheckSqlInjection4Field(objMandarinCaseEN.MandarinCaseDate, conMandarinCase.MandarinCaseDate);
clsCheckSql.CheckSqlInjection4Field(objMandarinCaseEN.MandarinCaseTime, conMandarinCase.MandarinCaseTime);
clsCheckSql.CheckSqlInjection4Field(objMandarinCaseEN.MandarinCaseDateIn, conMandarinCase.MandarinCaseDateIn);
clsCheckSql.CheckSqlInjection4Field(objMandarinCaseEN.MandarinCaseTimeIn, conMandarinCase.MandarinCaseTimeIn);
clsCheckSql.CheckSqlInjection4Field(objMandarinCaseEN.IdTeachingPlan, conMandarinCase.IdTeachingPlan);
clsCheckSql.CheckSqlInjection4Field(objMandarinCaseEN.IdSenateGaugeVersion, conMandarinCase.IdSenateGaugeVersion);
clsCheckSql.CheckSqlInjection4Field(objMandarinCaseEN.CaseLevelId, conMandarinCase.CaseLevelId);
clsCheckSql.CheckSqlInjection4Field(objMandarinCaseEN.DocFile, conMandarinCase.DocFile);
clsCheckSql.CheckSqlInjection4Field(objMandarinCaseEN.WordCreateDate, conMandarinCase.WordCreateDate);
clsCheckSql.CheckSqlInjection4Field(objMandarinCaseEN.OwnerId, conMandarinCase.OwnerId);
clsCheckSql.CheckSqlInjection4Field(objMandarinCaseEN.IdMandarinCaseType, conMandarinCase.IdMandarinCaseType);
clsCheckSql.CheckSqlInjection4Field(objMandarinCaseEN.UserTypeId, conMandarinCase.UserTypeId);
clsCheckSql.CheckSqlInjection4Field(objMandarinCaseEN.RecommendedDegreeId, conMandarinCase.RecommendedDegreeId);
clsCheckSql.CheckSqlInjection4Field(objMandarinCaseEN.ftpFileType, conMandarinCase.ftpFileType);
clsCheckSql.CheckSqlInjection4Field(objMandarinCaseEN.VideoUrl, conMandarinCase.VideoUrl);
clsCheckSql.CheckSqlInjection4Field(objMandarinCaseEN.VideoPath, conMandarinCase.VideoPath);
clsCheckSql.CheckSqlInjection4Field(objMandarinCaseEN.ResErrMsg, conMandarinCase.ResErrMsg);
clsCheckSql.CheckSqlInjection4Field(objMandarinCaseEN.UpdDate, conMandarinCase.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objMandarinCaseEN.UpdUserId, conMandarinCase.UpdUserId);
clsCheckSql.CheckSqlInjection4Field(objMandarinCaseEN.Memo, conMandarinCase.Memo);
//检查外键字段长度
 objMandarinCaseEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 /// <summary>
 /// 获取用于绑定下拉框的DataTable,获取两个字段:1、关键字；2、名称字段
 /// (AutoGCLib.clsGeneCodeBase:Gen_4DAL_GetDataTable4DdlBind)
 /// </summary>
 /// <returns>返回用于绑定下拉框的DataTable</returns>
public System.Data.DataTable GetIdMandarinCase()
{
//获取某学院所有专业信息
string strSQL = "select IdMandarinCase, MandarinCaseName from MandarinCase ";
 clsSpecSQLforSql mySql = clsMandarinCaseDA.GetSpecSQLObj();
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
 objSQL = clsMandarinCaseDA.GetSpecSQLObj();
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
 objSQL = clsMandarinCaseDA.GetSpecSQLObj();
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
 objSQL = clsMandarinCaseDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsMandarinCaseEN._CurrTabName);
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
 objSQL = clsMandarinCaseDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsMandarinCaseEN._CurrTabName, strCondition);
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
 objSQL = clsMandarinCaseDA.GetSpecSQLObj();
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
 objSQL = clsMandarinCaseDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}