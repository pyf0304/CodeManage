
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clscc_ExcellenttTeachingTeamDA
 表名:cc_ExcellenttTeachingTeam(01120092)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 13:08:13
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:优秀教学团队管理(ExTeamMan)
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
 /// 优秀教学团队(cc_ExcellenttTeachingTeam)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clscc_ExcellenttTeachingTeamDA : clsCommBase4DA
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
 return clscc_ExcellenttTeachingTeamEN._CurrTabName;
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
if (string.IsNullOrEmpty(clscc_ExcellenttTeachingTeamEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clscc_ExcellenttTeachingTeamEN._ConnectString);
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
 if (string.IsNullOrEmpty(clscc_ExcellenttTeachingTeamEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clscc_ExcellenttTeachingTeamEN._ConnectString);
 }
 return objSQL;
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clscc_ExcellenttTeachingTeamDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_ExcellenttTeachingTeamDA.GetSpecSQLObj();
strSQL = "Select * from cc_ExcellenttTeachingTeam where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_cc_ExcellenttTeachingTeam(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clscc_ExcellenttTeachingTeamDA: GetDataTable_cc_ExcellenttTeachingTeam)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_ExcellenttTeachingTeamDA.GetSpecSQLObj();
strSQL = "Select * from cc_ExcellenttTeachingTeam where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clscc_ExcellenttTeachingTeamDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_ExcellenttTeachingTeamDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clscc_ExcellenttTeachingTeamDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_ExcellenttTeachingTeamDA.GetSpecSQLObj();
strSQL = "Select * from cc_ExcellenttTeachingTeam where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clscc_ExcellenttTeachingTeamDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_ExcellenttTeachingTeamDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clscc_ExcellenttTeachingTeamDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_ExcellenttTeachingTeamDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from cc_ExcellenttTeachingTeam where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from cc_ExcellenttTeachingTeam where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clscc_ExcellenttTeachingTeamDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_ExcellenttTeachingTeamDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from cc_ExcellenttTeachingTeam where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clscc_ExcellenttTeachingTeamDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_ExcellenttTeachingTeamDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} cc_ExcellenttTeachingTeam.* from cc_ExcellenttTeachingTeam Left Join {1} on {2} where {3} and cc_ExcellenttTeachingTeam.ExcellenttTeachingTeamID not in (Select top {5} cc_ExcellenttTeachingTeam.ExcellenttTeachingTeamID from cc_ExcellenttTeachingTeam Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from cc_ExcellenttTeachingTeam where {1} and ExcellenttTeachingTeamID not in (Select top {2} ExcellenttTeachingTeamID from cc_ExcellenttTeachingTeam where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from cc_ExcellenttTeachingTeam where {1} and ExcellenttTeachingTeamID not in (Select top {3} ExcellenttTeachingTeamID from cc_ExcellenttTeachingTeam where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clscc_ExcellenttTeachingTeamDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_ExcellenttTeachingTeamDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} cc_ExcellenttTeachingTeam.* from cc_ExcellenttTeachingTeam Left Join {1} on {2} where {3} and cc_ExcellenttTeachingTeam.ExcellenttTeachingTeamID not in (Select top {5} cc_ExcellenttTeachingTeam.ExcellenttTeachingTeamID from cc_ExcellenttTeachingTeam Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from cc_ExcellenttTeachingTeam where {1} and ExcellenttTeachingTeamID not in (Select top {2} ExcellenttTeachingTeamID from cc_ExcellenttTeachingTeam where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from cc_ExcellenttTeachingTeam where {1} and ExcellenttTeachingTeamID not in (Select top {3} ExcellenttTeachingTeamID from cc_ExcellenttTeachingTeam where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clscc_ExcellenttTeachingTeamEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clscc_ExcellenttTeachingTeamDA:GetObjLst)", objException.Message));
}
List<clscc_ExcellenttTeachingTeamEN> arrObjLst = new List<clscc_ExcellenttTeachingTeamEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_ExcellenttTeachingTeamDA.GetSpecSQLObj();
strSQL = "Select * from cc_ExcellenttTeachingTeam where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscc_ExcellenttTeachingTeamEN objcc_ExcellenttTeachingTeamEN = new clscc_ExcellenttTeachingTeamEN();
try
{
objcc_ExcellenttTeachingTeamEN.ExcellenttTeachingTeamID = TransNullToInt(objRow[concc_ExcellenttTeachingTeam.ExcellenttTeachingTeamID].ToString().Trim()); //优秀教学团队编号
objcc_ExcellenttTeachingTeamEN.ViewCount = TransNullToInt(objRow[concc_ExcellenttTeachingTeam.ViewCount].ToString().Trim()); //浏览量
objcc_ExcellenttTeachingTeamEN.CourseTypeID = objRow[concc_ExcellenttTeachingTeam.CourseTypeID] == DBNull.Value ? null : objRow[concc_ExcellenttTeachingTeam.CourseTypeID].ToString().Trim(); //课程类型ID
objcc_ExcellenttTeachingTeamEN.IdXzCollege = objRow[concc_ExcellenttTeachingTeam.IdXzCollege].ToString().Trim(); //学院流水号
objcc_ExcellenttTeachingTeamEN.TeamName = objRow[concc_ExcellenttTeachingTeam.TeamName].ToString().Trim(); //团队名称
objcc_ExcellenttTeachingTeamEN.TeamLeader = objRow[concc_ExcellenttTeachingTeam.TeamLeader] == DBNull.Value ? null : objRow[concc_ExcellenttTeachingTeam.TeamLeader].ToString().Trim(); //团队带头人
objcc_ExcellenttTeachingTeamEN.Year = objRow[concc_ExcellenttTeachingTeam.Year] == DBNull.Value ? null : objRow[concc_ExcellenttTeachingTeam.Year].ToString().Trim(); //年份
objcc_ExcellenttTeachingTeamEN.RecommendCount = objRow[concc_ExcellenttTeachingTeam.RecommendCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[concc_ExcellenttTeachingTeam.RecommendCount].ToString().Trim()); //推荐次数
objcc_ExcellenttTeachingTeamEN.TeamIntroduction = objRow[concc_ExcellenttTeachingTeam.TeamIntroduction] == DBNull.Value ? null : objRow[concc_ExcellenttTeachingTeam.TeamIntroduction].ToString().Trim(); //团队简介
objcc_ExcellenttTeachingTeamEN.TeamMembers = objRow[concc_ExcellenttTeachingTeam.TeamMembers] == DBNull.Value ? null : objRow[concc_ExcellenttTeachingTeam.TeamMembers].ToString().Trim(); //团队成员
objcc_ExcellenttTeachingTeamEN.Teaching = objRow[concc_ExcellenttTeachingTeam.Teaching] == DBNull.Value ? null : objRow[concc_ExcellenttTeachingTeam.Teaching].ToString().Trim(); //教学工作
objcc_ExcellenttTeachingTeamEN.ResearchWorking = objRow[concc_ExcellenttTeachingTeam.ResearchWorking] == DBNull.Value ? null : objRow[concc_ExcellenttTeachingTeam.ResearchWorking].ToString().Trim(); //科研工作
objcc_ExcellenttTeachingTeamEN.TeamPlanning = objRow[concc_ExcellenttTeachingTeam.TeamPlanning] == DBNull.Value ? null : objRow[concc_ExcellenttTeachingTeam.TeamPlanning].ToString().Trim(); //团队规划
objcc_ExcellenttTeachingTeamEN.TeamCourse = objRow[concc_ExcellenttTeachingTeam.TeamCourse] == DBNull.Value ? null : objRow[concc_ExcellenttTeachingTeam.TeamCourse].ToString().Trim(); //团队课程
objcc_ExcellenttTeachingTeamEN.Memo = objRow[concc_ExcellenttTeachingTeam.Memo] == DBNull.Value ? null : objRow[concc_ExcellenttTeachingTeam.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clscc_ExcellenttTeachingTeamDA: GetObjLst)", objException.Message));
}
objcc_ExcellenttTeachingTeamEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objcc_ExcellenttTeachingTeamEN);
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
public List<clscc_ExcellenttTeachingTeamEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clscc_ExcellenttTeachingTeamDA:GetObjLstByTabName)", objException.Message));
}
List<clscc_ExcellenttTeachingTeamEN> arrObjLst = new List<clscc_ExcellenttTeachingTeamEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_ExcellenttTeachingTeamDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscc_ExcellenttTeachingTeamEN objcc_ExcellenttTeachingTeamEN = new clscc_ExcellenttTeachingTeamEN();
try
{
objcc_ExcellenttTeachingTeamEN.ExcellenttTeachingTeamID = TransNullToInt(objRow[concc_ExcellenttTeachingTeam.ExcellenttTeachingTeamID].ToString().Trim()); //优秀教学团队编号
objcc_ExcellenttTeachingTeamEN.ViewCount = TransNullToInt(objRow[concc_ExcellenttTeachingTeam.ViewCount].ToString().Trim()); //浏览量
objcc_ExcellenttTeachingTeamEN.CourseTypeID = objRow[concc_ExcellenttTeachingTeam.CourseTypeID] == DBNull.Value ? null : objRow[concc_ExcellenttTeachingTeam.CourseTypeID].ToString().Trim(); //课程类型ID
objcc_ExcellenttTeachingTeamEN.IdXzCollege = objRow[concc_ExcellenttTeachingTeam.IdXzCollege].ToString().Trim(); //学院流水号
objcc_ExcellenttTeachingTeamEN.TeamName = objRow[concc_ExcellenttTeachingTeam.TeamName].ToString().Trim(); //团队名称
objcc_ExcellenttTeachingTeamEN.TeamLeader = objRow[concc_ExcellenttTeachingTeam.TeamLeader] == DBNull.Value ? null : objRow[concc_ExcellenttTeachingTeam.TeamLeader].ToString().Trim(); //团队带头人
objcc_ExcellenttTeachingTeamEN.Year = objRow[concc_ExcellenttTeachingTeam.Year] == DBNull.Value ? null : objRow[concc_ExcellenttTeachingTeam.Year].ToString().Trim(); //年份
objcc_ExcellenttTeachingTeamEN.RecommendCount = objRow[concc_ExcellenttTeachingTeam.RecommendCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[concc_ExcellenttTeachingTeam.RecommendCount].ToString().Trim()); //推荐次数
objcc_ExcellenttTeachingTeamEN.TeamIntroduction = objRow[concc_ExcellenttTeachingTeam.TeamIntroduction] == DBNull.Value ? null : objRow[concc_ExcellenttTeachingTeam.TeamIntroduction].ToString().Trim(); //团队简介
objcc_ExcellenttTeachingTeamEN.TeamMembers = objRow[concc_ExcellenttTeachingTeam.TeamMembers] == DBNull.Value ? null : objRow[concc_ExcellenttTeachingTeam.TeamMembers].ToString().Trim(); //团队成员
objcc_ExcellenttTeachingTeamEN.Teaching = objRow[concc_ExcellenttTeachingTeam.Teaching] == DBNull.Value ? null : objRow[concc_ExcellenttTeachingTeam.Teaching].ToString().Trim(); //教学工作
objcc_ExcellenttTeachingTeamEN.ResearchWorking = objRow[concc_ExcellenttTeachingTeam.ResearchWorking] == DBNull.Value ? null : objRow[concc_ExcellenttTeachingTeam.ResearchWorking].ToString().Trim(); //科研工作
objcc_ExcellenttTeachingTeamEN.TeamPlanning = objRow[concc_ExcellenttTeachingTeam.TeamPlanning] == DBNull.Value ? null : objRow[concc_ExcellenttTeachingTeam.TeamPlanning].ToString().Trim(); //团队规划
objcc_ExcellenttTeachingTeamEN.TeamCourse = objRow[concc_ExcellenttTeachingTeam.TeamCourse] == DBNull.Value ? null : objRow[concc_ExcellenttTeachingTeam.TeamCourse].ToString().Trim(); //团队课程
objcc_ExcellenttTeachingTeamEN.Memo = objRow[concc_ExcellenttTeachingTeam.Memo] == DBNull.Value ? null : objRow[concc_ExcellenttTeachingTeam.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clscc_ExcellenttTeachingTeamDA: GetObjLst)", objException.Message));
}
objcc_ExcellenttTeachingTeamEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objcc_ExcellenttTeachingTeamEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objcc_ExcellenttTeachingTeamEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool Getcc_ExcellenttTeachingTeam(ref clscc_ExcellenttTeachingTeamEN objcc_ExcellenttTeachingTeamEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_ExcellenttTeachingTeamDA.GetSpecSQLObj();
strSQL = "Select * from cc_ExcellenttTeachingTeam where ExcellenttTeachingTeamID = " + ""+ objcc_ExcellenttTeachingTeamEN.ExcellenttTeachingTeamID+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objcc_ExcellenttTeachingTeamEN.ExcellenttTeachingTeamID = TransNullToInt(objDT.Rows[0][concc_ExcellenttTeachingTeam.ExcellenttTeachingTeamID].ToString().Trim()); //优秀教学团队编号(字段类型:bigint,字段长度:8,是否可空:True)
 objcc_ExcellenttTeachingTeamEN.ViewCount = TransNullToInt(objDT.Rows[0][concc_ExcellenttTeachingTeam.ViewCount].ToString().Trim()); //浏览量(字段类型:int,字段长度:4,是否可空:True)
 objcc_ExcellenttTeachingTeamEN.CourseTypeID = objDT.Rows[0][concc_ExcellenttTeachingTeam.CourseTypeID].ToString().Trim(); //课程类型ID(字段类型:char,字段长度:4,是否可空:False)
 objcc_ExcellenttTeachingTeamEN.IdXzCollege = objDT.Rows[0][concc_ExcellenttTeachingTeam.IdXzCollege].ToString().Trim(); //学院流水号(字段类型:char,字段长度:4,是否可空:True)
 objcc_ExcellenttTeachingTeamEN.TeamName = objDT.Rows[0][concc_ExcellenttTeachingTeam.TeamName].ToString().Trim(); //团队名称(字段类型:varchar,字段长度:100,是否可空:True)
 objcc_ExcellenttTeachingTeamEN.TeamLeader = objDT.Rows[0][concc_ExcellenttTeachingTeam.TeamLeader].ToString().Trim(); //团队带头人(字段类型:varchar,字段长度:100,是否可空:True)
 objcc_ExcellenttTeachingTeamEN.Year = objDT.Rows[0][concc_ExcellenttTeachingTeam.Year].ToString().Trim(); //年份(字段类型:varchar,字段长度:50,是否可空:True)
 objcc_ExcellenttTeachingTeamEN.RecommendCount = TransNullToInt(objDT.Rows[0][concc_ExcellenttTeachingTeam.RecommendCount].ToString().Trim()); //推荐次数(字段类型:int,字段长度:4,是否可空:True)
 objcc_ExcellenttTeachingTeamEN.TeamIntroduction = objDT.Rows[0][concc_ExcellenttTeachingTeam.TeamIntroduction].ToString().Trim(); //团队简介(字段类型:varchar,字段长度:5000,是否可空:True)
 objcc_ExcellenttTeachingTeamEN.TeamMembers = objDT.Rows[0][concc_ExcellenttTeachingTeam.TeamMembers].ToString().Trim(); //团队成员(字段类型:varchar,字段长度:1000,是否可空:True)
 objcc_ExcellenttTeachingTeamEN.Teaching = objDT.Rows[0][concc_ExcellenttTeachingTeam.Teaching].ToString().Trim(); //教学工作(字段类型:varchar,字段长度:8000,是否可空:True)
 objcc_ExcellenttTeachingTeamEN.ResearchWorking = objDT.Rows[0][concc_ExcellenttTeachingTeam.ResearchWorking].ToString().Trim(); //科研工作(字段类型:varchar,字段长度:8000,是否可空:True)
 objcc_ExcellenttTeachingTeamEN.TeamPlanning = objDT.Rows[0][concc_ExcellenttTeachingTeam.TeamPlanning].ToString().Trim(); //团队规划(字段类型:varchar,字段长度:8000,是否可空:True)
 objcc_ExcellenttTeachingTeamEN.TeamCourse = objDT.Rows[0][concc_ExcellenttTeachingTeam.TeamCourse].ToString().Trim(); //团队课程(字段类型:varchar,字段长度:8000,是否可空:True)
 objcc_ExcellenttTeachingTeamEN.Memo = objDT.Rows[0][concc_ExcellenttTeachingTeam.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clscc_ExcellenttTeachingTeamDA: Getcc_ExcellenttTeachingTeam)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngExcellenttTeachingTeamID">表关键字</param>
 /// <returns>表对象</returns>
public clscc_ExcellenttTeachingTeamEN GetObjByExcellenttTeachingTeamID(long lngExcellenttTeachingTeamID)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_ExcellenttTeachingTeamDA.GetSpecSQLObj();
strSQL = "Select * from cc_ExcellenttTeachingTeam where ExcellenttTeachingTeamID = " + ""+ lngExcellenttTeachingTeamID+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clscc_ExcellenttTeachingTeamEN objcc_ExcellenttTeachingTeamEN = new clscc_ExcellenttTeachingTeamEN();
try
{
 objcc_ExcellenttTeachingTeamEN.ExcellenttTeachingTeamID = Int32.Parse(objRow[concc_ExcellenttTeachingTeam.ExcellenttTeachingTeamID].ToString().Trim()); //优秀教学团队编号(字段类型:bigint,字段长度:8,是否可空:True)
 objcc_ExcellenttTeachingTeamEN.ViewCount = Int32.Parse(objRow[concc_ExcellenttTeachingTeam.ViewCount].ToString().Trim()); //浏览量(字段类型:int,字段长度:4,是否可空:True)
 objcc_ExcellenttTeachingTeamEN.CourseTypeID = objRow[concc_ExcellenttTeachingTeam.CourseTypeID] == DBNull.Value ? null : objRow[concc_ExcellenttTeachingTeam.CourseTypeID].ToString().Trim(); //课程类型ID(字段类型:char,字段长度:4,是否可空:False)
 objcc_ExcellenttTeachingTeamEN.IdXzCollege = objRow[concc_ExcellenttTeachingTeam.IdXzCollege].ToString().Trim(); //学院流水号(字段类型:char,字段长度:4,是否可空:True)
 objcc_ExcellenttTeachingTeamEN.TeamName = objRow[concc_ExcellenttTeachingTeam.TeamName].ToString().Trim(); //团队名称(字段类型:varchar,字段长度:100,是否可空:True)
 objcc_ExcellenttTeachingTeamEN.TeamLeader = objRow[concc_ExcellenttTeachingTeam.TeamLeader] == DBNull.Value ? null : objRow[concc_ExcellenttTeachingTeam.TeamLeader].ToString().Trim(); //团队带头人(字段类型:varchar,字段长度:100,是否可空:True)
 objcc_ExcellenttTeachingTeamEN.Year = objRow[concc_ExcellenttTeachingTeam.Year] == DBNull.Value ? null : objRow[concc_ExcellenttTeachingTeam.Year].ToString().Trim(); //年份(字段类型:varchar,字段长度:50,是否可空:True)
 objcc_ExcellenttTeachingTeamEN.RecommendCount = objRow[concc_ExcellenttTeachingTeam.RecommendCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_ExcellenttTeachingTeam.RecommendCount].ToString().Trim()); //推荐次数(字段类型:int,字段长度:4,是否可空:True)
 objcc_ExcellenttTeachingTeamEN.TeamIntroduction = objRow[concc_ExcellenttTeachingTeam.TeamIntroduction] == DBNull.Value ? null : objRow[concc_ExcellenttTeachingTeam.TeamIntroduction].ToString().Trim(); //团队简介(字段类型:varchar,字段长度:5000,是否可空:True)
 objcc_ExcellenttTeachingTeamEN.TeamMembers = objRow[concc_ExcellenttTeachingTeam.TeamMembers] == DBNull.Value ? null : objRow[concc_ExcellenttTeachingTeam.TeamMembers].ToString().Trim(); //团队成员(字段类型:varchar,字段长度:1000,是否可空:True)
 objcc_ExcellenttTeachingTeamEN.Teaching = objRow[concc_ExcellenttTeachingTeam.Teaching] == DBNull.Value ? null : objRow[concc_ExcellenttTeachingTeam.Teaching].ToString().Trim(); //教学工作(字段类型:varchar,字段长度:8000,是否可空:True)
 objcc_ExcellenttTeachingTeamEN.ResearchWorking = objRow[concc_ExcellenttTeachingTeam.ResearchWorking] == DBNull.Value ? null : objRow[concc_ExcellenttTeachingTeam.ResearchWorking].ToString().Trim(); //科研工作(字段类型:varchar,字段长度:8000,是否可空:True)
 objcc_ExcellenttTeachingTeamEN.TeamPlanning = objRow[concc_ExcellenttTeachingTeam.TeamPlanning] == DBNull.Value ? null : objRow[concc_ExcellenttTeachingTeam.TeamPlanning].ToString().Trim(); //团队规划(字段类型:varchar,字段长度:8000,是否可空:True)
 objcc_ExcellenttTeachingTeamEN.TeamCourse = objRow[concc_ExcellenttTeachingTeam.TeamCourse] == DBNull.Value ? null : objRow[concc_ExcellenttTeachingTeam.TeamCourse].ToString().Trim(); //团队课程(字段类型:varchar,字段长度:8000,是否可空:True)
 objcc_ExcellenttTeachingTeamEN.Memo = objRow[concc_ExcellenttTeachingTeam.Memo] == DBNull.Value ? null : objRow[concc_ExcellenttTeachingTeam.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clscc_ExcellenttTeachingTeamDA: GetObjByExcellenttTeachingTeamID)", objException.Message));
}
return objcc_ExcellenttTeachingTeamEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clscc_ExcellenttTeachingTeamEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clscc_ExcellenttTeachingTeamDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_ExcellenttTeachingTeamDA.GetSpecSQLObj();
strSQL = "Select * from cc_ExcellenttTeachingTeam where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clscc_ExcellenttTeachingTeamEN objcc_ExcellenttTeachingTeamEN = new clscc_ExcellenttTeachingTeamEN()
{
ExcellenttTeachingTeamID = TransNullToInt(objRow[concc_ExcellenttTeachingTeam.ExcellenttTeachingTeamID].ToString().Trim()), //优秀教学团队编号
ViewCount = TransNullToInt(objRow[concc_ExcellenttTeachingTeam.ViewCount].ToString().Trim()), //浏览量
CourseTypeID = objRow[concc_ExcellenttTeachingTeam.CourseTypeID] == DBNull.Value ? null : objRow[concc_ExcellenttTeachingTeam.CourseTypeID].ToString().Trim(), //课程类型ID
IdXzCollege = objRow[concc_ExcellenttTeachingTeam.IdXzCollege].ToString().Trim(), //学院流水号
TeamName = objRow[concc_ExcellenttTeachingTeam.TeamName].ToString().Trim(), //团队名称
TeamLeader = objRow[concc_ExcellenttTeachingTeam.TeamLeader] == DBNull.Value ? null : objRow[concc_ExcellenttTeachingTeam.TeamLeader].ToString().Trim(), //团队带头人
Year = objRow[concc_ExcellenttTeachingTeam.Year] == DBNull.Value ? null : objRow[concc_ExcellenttTeachingTeam.Year].ToString().Trim(), //年份
RecommendCount = objRow[concc_ExcellenttTeachingTeam.RecommendCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[concc_ExcellenttTeachingTeam.RecommendCount].ToString().Trim()), //推荐次数
TeamIntroduction = objRow[concc_ExcellenttTeachingTeam.TeamIntroduction] == DBNull.Value ? null : objRow[concc_ExcellenttTeachingTeam.TeamIntroduction].ToString().Trim(), //团队简介
TeamMembers = objRow[concc_ExcellenttTeachingTeam.TeamMembers] == DBNull.Value ? null : objRow[concc_ExcellenttTeachingTeam.TeamMembers].ToString().Trim(), //团队成员
Teaching = objRow[concc_ExcellenttTeachingTeam.Teaching] == DBNull.Value ? null : objRow[concc_ExcellenttTeachingTeam.Teaching].ToString().Trim(), //教学工作
ResearchWorking = objRow[concc_ExcellenttTeachingTeam.ResearchWorking] == DBNull.Value ? null : objRow[concc_ExcellenttTeachingTeam.ResearchWorking].ToString().Trim(), //科研工作
TeamPlanning = objRow[concc_ExcellenttTeachingTeam.TeamPlanning] == DBNull.Value ? null : objRow[concc_ExcellenttTeachingTeam.TeamPlanning].ToString().Trim(), //团队规划
TeamCourse = objRow[concc_ExcellenttTeachingTeam.TeamCourse] == DBNull.Value ? null : objRow[concc_ExcellenttTeachingTeam.TeamCourse].ToString().Trim(), //团队课程
Memo = objRow[concc_ExcellenttTeachingTeam.Memo] == DBNull.Value ? null : objRow[concc_ExcellenttTeachingTeam.Memo].ToString().Trim() //备注
};
objcc_ExcellenttTeachingTeamEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objcc_ExcellenttTeachingTeamEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clscc_ExcellenttTeachingTeamDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clscc_ExcellenttTeachingTeamEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clscc_ExcellenttTeachingTeamEN objcc_ExcellenttTeachingTeamEN = new clscc_ExcellenttTeachingTeamEN();
try
{
objcc_ExcellenttTeachingTeamEN.ExcellenttTeachingTeamID = TransNullToInt(objRow[concc_ExcellenttTeachingTeam.ExcellenttTeachingTeamID].ToString().Trim()); //优秀教学团队编号
objcc_ExcellenttTeachingTeamEN.ViewCount = TransNullToInt(objRow[concc_ExcellenttTeachingTeam.ViewCount].ToString().Trim()); //浏览量
objcc_ExcellenttTeachingTeamEN.CourseTypeID = objRow[concc_ExcellenttTeachingTeam.CourseTypeID] == DBNull.Value ? null : objRow[concc_ExcellenttTeachingTeam.CourseTypeID].ToString().Trim(); //课程类型ID
objcc_ExcellenttTeachingTeamEN.IdXzCollege = objRow[concc_ExcellenttTeachingTeam.IdXzCollege].ToString().Trim(); //学院流水号
objcc_ExcellenttTeachingTeamEN.TeamName = objRow[concc_ExcellenttTeachingTeam.TeamName].ToString().Trim(); //团队名称
objcc_ExcellenttTeachingTeamEN.TeamLeader = objRow[concc_ExcellenttTeachingTeam.TeamLeader] == DBNull.Value ? null : objRow[concc_ExcellenttTeachingTeam.TeamLeader].ToString().Trim(); //团队带头人
objcc_ExcellenttTeachingTeamEN.Year = objRow[concc_ExcellenttTeachingTeam.Year] == DBNull.Value ? null : objRow[concc_ExcellenttTeachingTeam.Year].ToString().Trim(); //年份
objcc_ExcellenttTeachingTeamEN.RecommendCount = objRow[concc_ExcellenttTeachingTeam.RecommendCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[concc_ExcellenttTeachingTeam.RecommendCount].ToString().Trim()); //推荐次数
objcc_ExcellenttTeachingTeamEN.TeamIntroduction = objRow[concc_ExcellenttTeachingTeam.TeamIntroduction] == DBNull.Value ? null : objRow[concc_ExcellenttTeachingTeam.TeamIntroduction].ToString().Trim(); //团队简介
objcc_ExcellenttTeachingTeamEN.TeamMembers = objRow[concc_ExcellenttTeachingTeam.TeamMembers] == DBNull.Value ? null : objRow[concc_ExcellenttTeachingTeam.TeamMembers].ToString().Trim(); //团队成员
objcc_ExcellenttTeachingTeamEN.Teaching = objRow[concc_ExcellenttTeachingTeam.Teaching] == DBNull.Value ? null : objRow[concc_ExcellenttTeachingTeam.Teaching].ToString().Trim(); //教学工作
objcc_ExcellenttTeachingTeamEN.ResearchWorking = objRow[concc_ExcellenttTeachingTeam.ResearchWorking] == DBNull.Value ? null : objRow[concc_ExcellenttTeachingTeam.ResearchWorking].ToString().Trim(); //科研工作
objcc_ExcellenttTeachingTeamEN.TeamPlanning = objRow[concc_ExcellenttTeachingTeam.TeamPlanning] == DBNull.Value ? null : objRow[concc_ExcellenttTeachingTeam.TeamPlanning].ToString().Trim(); //团队规划
objcc_ExcellenttTeachingTeamEN.TeamCourse = objRow[concc_ExcellenttTeachingTeam.TeamCourse] == DBNull.Value ? null : objRow[concc_ExcellenttTeachingTeam.TeamCourse].ToString().Trim(); //团队课程
objcc_ExcellenttTeachingTeamEN.Memo = objRow[concc_ExcellenttTeachingTeam.Memo] == DBNull.Value ? null : objRow[concc_ExcellenttTeachingTeam.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clscc_ExcellenttTeachingTeamDA: GetObjByDataRowcc_ExcellenttTeachingTeam)", objException.Message));
}
objcc_ExcellenttTeachingTeamEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objcc_ExcellenttTeachingTeamEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clscc_ExcellenttTeachingTeamEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clscc_ExcellenttTeachingTeamEN objcc_ExcellenttTeachingTeamEN = new clscc_ExcellenttTeachingTeamEN();
try
{
objcc_ExcellenttTeachingTeamEN.ExcellenttTeachingTeamID = TransNullToInt(objRow[concc_ExcellenttTeachingTeam.ExcellenttTeachingTeamID].ToString().Trim()); //优秀教学团队编号
objcc_ExcellenttTeachingTeamEN.ViewCount = TransNullToInt(objRow[concc_ExcellenttTeachingTeam.ViewCount].ToString().Trim()); //浏览量
objcc_ExcellenttTeachingTeamEN.CourseTypeID = objRow[concc_ExcellenttTeachingTeam.CourseTypeID] == DBNull.Value ? null : objRow[concc_ExcellenttTeachingTeam.CourseTypeID].ToString().Trim(); //课程类型ID
objcc_ExcellenttTeachingTeamEN.IdXzCollege = objRow[concc_ExcellenttTeachingTeam.IdXzCollege].ToString().Trim(); //学院流水号
objcc_ExcellenttTeachingTeamEN.TeamName = objRow[concc_ExcellenttTeachingTeam.TeamName].ToString().Trim(); //团队名称
objcc_ExcellenttTeachingTeamEN.TeamLeader = objRow[concc_ExcellenttTeachingTeam.TeamLeader] == DBNull.Value ? null : objRow[concc_ExcellenttTeachingTeam.TeamLeader].ToString().Trim(); //团队带头人
objcc_ExcellenttTeachingTeamEN.Year = objRow[concc_ExcellenttTeachingTeam.Year] == DBNull.Value ? null : objRow[concc_ExcellenttTeachingTeam.Year].ToString().Trim(); //年份
objcc_ExcellenttTeachingTeamEN.RecommendCount = objRow[concc_ExcellenttTeachingTeam.RecommendCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[concc_ExcellenttTeachingTeam.RecommendCount].ToString().Trim()); //推荐次数
objcc_ExcellenttTeachingTeamEN.TeamIntroduction = objRow[concc_ExcellenttTeachingTeam.TeamIntroduction] == DBNull.Value ? null : objRow[concc_ExcellenttTeachingTeam.TeamIntroduction].ToString().Trim(); //团队简介
objcc_ExcellenttTeachingTeamEN.TeamMembers = objRow[concc_ExcellenttTeachingTeam.TeamMembers] == DBNull.Value ? null : objRow[concc_ExcellenttTeachingTeam.TeamMembers].ToString().Trim(); //团队成员
objcc_ExcellenttTeachingTeamEN.Teaching = objRow[concc_ExcellenttTeachingTeam.Teaching] == DBNull.Value ? null : objRow[concc_ExcellenttTeachingTeam.Teaching].ToString().Trim(); //教学工作
objcc_ExcellenttTeachingTeamEN.ResearchWorking = objRow[concc_ExcellenttTeachingTeam.ResearchWorking] == DBNull.Value ? null : objRow[concc_ExcellenttTeachingTeam.ResearchWorking].ToString().Trim(); //科研工作
objcc_ExcellenttTeachingTeamEN.TeamPlanning = objRow[concc_ExcellenttTeachingTeam.TeamPlanning] == DBNull.Value ? null : objRow[concc_ExcellenttTeachingTeam.TeamPlanning].ToString().Trim(); //团队规划
objcc_ExcellenttTeachingTeamEN.TeamCourse = objRow[concc_ExcellenttTeachingTeam.TeamCourse] == DBNull.Value ? null : objRow[concc_ExcellenttTeachingTeam.TeamCourse].ToString().Trim(); //团队课程
objcc_ExcellenttTeachingTeamEN.Memo = objRow[concc_ExcellenttTeachingTeam.Memo] == DBNull.Value ? null : objRow[concc_ExcellenttTeachingTeam.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clscc_ExcellenttTeachingTeamDA: GetObjByDataRow)", objException.Message));
}
objcc_ExcellenttTeachingTeamEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objcc_ExcellenttTeachingTeamEN;
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
objSQL = clscc_ExcellenttTeachingTeamDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clscc_ExcellenttTeachingTeamEN._CurrTabName, concc_ExcellenttTeachingTeam.ExcellenttTeachingTeamID, 8, "");
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
objSQL = clscc_ExcellenttTeachingTeamDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clscc_ExcellenttTeachingTeamEN._CurrTabName, concc_ExcellenttTeachingTeam.ExcellenttTeachingTeamID, 8, strPrefix);
return strMaxValue;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的关键字值
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstID)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public long GetFirstID(string strCondition) 
{
string strSQL ;
 System.Data.DataTable objDT ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_ExcellenttTeachingTeamDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select ExcellenttTeachingTeamID from cc_ExcellenttTeachingTeam where " + strCondition;
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
return 0;
}
strKeyValue = objDT.Rows[0][0].ToString();
return long.Parse(strKeyValue);
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
 objSQL = clscc_ExcellenttTeachingTeamDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select ExcellenttTeachingTeamID from cc_ExcellenttTeachingTeam where " + strCondition;
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
 /// <param name = "lngExcellenttTeachingTeamID">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(long lngExcellenttTeachingTeamID)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_ExcellenttTeachingTeamDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("cc_ExcellenttTeachingTeam", "ExcellenttTeachingTeamID = " + ""+ lngExcellenttTeachingTeamID+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clscc_ExcellenttTeachingTeamDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_ExcellenttTeachingTeamDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("cc_ExcellenttTeachingTeam", strCondition))
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
objSQL = clscc_ExcellenttTeachingTeamDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("cc_ExcellenttTeachingTeam");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clscc_ExcellenttTeachingTeamEN objcc_ExcellenttTeachingTeamEN)
 {
 if (objcc_ExcellenttTeachingTeamEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objcc_ExcellenttTeachingTeamEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_ExcellenttTeachingTeamDA.GetSpecSQLObj();
strSQL = "Select * from cc_ExcellenttTeachingTeam where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "cc_ExcellenttTeachingTeam");
objRow = objDS.Tables["cc_ExcellenttTeachingTeam"].NewRow();
objRow[concc_ExcellenttTeachingTeam.ViewCount] = objcc_ExcellenttTeachingTeamEN.ViewCount; //浏览量
 if (objcc_ExcellenttTeachingTeamEN.CourseTypeID !=  "")
 {
objRow[concc_ExcellenttTeachingTeam.CourseTypeID] = objcc_ExcellenttTeachingTeamEN.CourseTypeID; //课程类型ID
 }
objRow[concc_ExcellenttTeachingTeam.IdXzCollege] = objcc_ExcellenttTeachingTeamEN.IdXzCollege; //学院流水号
objRow[concc_ExcellenttTeachingTeam.TeamName] = objcc_ExcellenttTeachingTeamEN.TeamName; //团队名称
 if (objcc_ExcellenttTeachingTeamEN.TeamLeader !=  "")
 {
objRow[concc_ExcellenttTeachingTeam.TeamLeader] = objcc_ExcellenttTeachingTeamEN.TeamLeader; //团队带头人
 }
 if (objcc_ExcellenttTeachingTeamEN.Year !=  "")
 {
objRow[concc_ExcellenttTeachingTeam.Year] = objcc_ExcellenttTeachingTeamEN.Year; //年份
 }
objRow[concc_ExcellenttTeachingTeam.RecommendCount] = objcc_ExcellenttTeachingTeamEN.RecommendCount; //推荐次数
 if (objcc_ExcellenttTeachingTeamEN.TeamIntroduction !=  "")
 {
objRow[concc_ExcellenttTeachingTeam.TeamIntroduction] = objcc_ExcellenttTeachingTeamEN.TeamIntroduction; //团队简介
 }
 if (objcc_ExcellenttTeachingTeamEN.TeamMembers !=  "")
 {
objRow[concc_ExcellenttTeachingTeam.TeamMembers] = objcc_ExcellenttTeachingTeamEN.TeamMembers; //团队成员
 }
 if (objcc_ExcellenttTeachingTeamEN.Teaching !=  "")
 {
objRow[concc_ExcellenttTeachingTeam.Teaching] = objcc_ExcellenttTeachingTeamEN.Teaching; //教学工作
 }
 if (objcc_ExcellenttTeachingTeamEN.ResearchWorking !=  "")
 {
objRow[concc_ExcellenttTeachingTeam.ResearchWorking] = objcc_ExcellenttTeachingTeamEN.ResearchWorking; //科研工作
 }
 if (objcc_ExcellenttTeachingTeamEN.TeamPlanning !=  "")
 {
objRow[concc_ExcellenttTeachingTeam.TeamPlanning] = objcc_ExcellenttTeachingTeamEN.TeamPlanning; //团队规划
 }
 if (objcc_ExcellenttTeachingTeamEN.TeamCourse !=  "")
 {
objRow[concc_ExcellenttTeachingTeam.TeamCourse] = objcc_ExcellenttTeachingTeamEN.TeamCourse; //团队课程
 }
 if (objcc_ExcellenttTeachingTeamEN.Memo !=  "")
 {
objRow[concc_ExcellenttTeachingTeam.Memo] = objcc_ExcellenttTeachingTeamEN.Memo; //备注
 }
objDS.Tables[clscc_ExcellenttTeachingTeamEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clscc_ExcellenttTeachingTeamEN._CurrTabName);
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
 /// <param name = "objcc_ExcellenttTeachingTeamEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clscc_ExcellenttTeachingTeamEN objcc_ExcellenttTeachingTeamEN)
{
 if (objcc_ExcellenttTeachingTeamEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objcc_ExcellenttTeachingTeamEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 arrFieldListForInsert.Add(concc_ExcellenttTeachingTeam.ViewCount);
 arrValueListForInsert.Add(objcc_ExcellenttTeachingTeamEN.ViewCount.ToString());
 
 if (objcc_ExcellenttTeachingTeamEN.CourseTypeID !=  null)
 {
 arrFieldListForInsert.Add(concc_ExcellenttTeachingTeam.CourseTypeID);
 var strCourseTypeID = objcc_ExcellenttTeachingTeamEN.CourseTypeID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseTypeID + "'");
 }
 
 if (objcc_ExcellenttTeachingTeamEN.IdXzCollege !=  null)
 {
 arrFieldListForInsert.Add(concc_ExcellenttTeachingTeam.IdXzCollege);
 var strIdXzCollege = objcc_ExcellenttTeachingTeamEN.IdXzCollege.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdXzCollege + "'");
 }
 
 if (objcc_ExcellenttTeachingTeamEN.TeamName !=  null)
 {
 arrFieldListForInsert.Add(concc_ExcellenttTeachingTeam.TeamName);
 var strTeamName = objcc_ExcellenttTeachingTeamEN.TeamName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTeamName + "'");
 }
 
 if (objcc_ExcellenttTeachingTeamEN.TeamLeader !=  null)
 {
 arrFieldListForInsert.Add(concc_ExcellenttTeachingTeam.TeamLeader);
 var strTeamLeader = objcc_ExcellenttTeachingTeamEN.TeamLeader.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTeamLeader + "'");
 }
 
 if (objcc_ExcellenttTeachingTeamEN.Year !=  null)
 {
 arrFieldListForInsert.Add(concc_ExcellenttTeachingTeam.Year);
 var strYear = objcc_ExcellenttTeachingTeamEN.Year.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strYear + "'");
 }
 
 if (objcc_ExcellenttTeachingTeamEN.RecommendCount !=  null)
 {
 arrFieldListForInsert.Add(concc_ExcellenttTeachingTeam.RecommendCount);
 arrValueListForInsert.Add(objcc_ExcellenttTeachingTeamEN.RecommendCount.ToString());
 }
 
 if (objcc_ExcellenttTeachingTeamEN.TeamIntroduction !=  null)
 {
 arrFieldListForInsert.Add(concc_ExcellenttTeachingTeam.TeamIntroduction);
 var strTeamIntroduction = objcc_ExcellenttTeachingTeamEN.TeamIntroduction.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTeamIntroduction + "'");
 }
 
 if (objcc_ExcellenttTeachingTeamEN.TeamMembers !=  null)
 {
 arrFieldListForInsert.Add(concc_ExcellenttTeachingTeam.TeamMembers);
 var strTeamMembers = objcc_ExcellenttTeachingTeamEN.TeamMembers.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTeamMembers + "'");
 }
 
 if (objcc_ExcellenttTeachingTeamEN.Teaching !=  null)
 {
 arrFieldListForInsert.Add(concc_ExcellenttTeachingTeam.Teaching);
 var strTeaching = objcc_ExcellenttTeachingTeamEN.Teaching.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTeaching + "'");
 }
 
 if (objcc_ExcellenttTeachingTeamEN.ResearchWorking !=  null)
 {
 arrFieldListForInsert.Add(concc_ExcellenttTeachingTeam.ResearchWorking);
 var strResearchWorking = objcc_ExcellenttTeachingTeamEN.ResearchWorking.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strResearchWorking + "'");
 }
 
 if (objcc_ExcellenttTeachingTeamEN.TeamPlanning !=  null)
 {
 arrFieldListForInsert.Add(concc_ExcellenttTeachingTeam.TeamPlanning);
 var strTeamPlanning = objcc_ExcellenttTeachingTeamEN.TeamPlanning.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTeamPlanning + "'");
 }
 
 if (objcc_ExcellenttTeachingTeamEN.TeamCourse !=  null)
 {
 arrFieldListForInsert.Add(concc_ExcellenttTeachingTeam.TeamCourse);
 var strTeamCourse = objcc_ExcellenttTeachingTeamEN.TeamCourse.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTeamCourse + "'");
 }
 
 if (objcc_ExcellenttTeachingTeamEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(concc_ExcellenttTeachingTeam.Memo);
 var strMemo = objcc_ExcellenttTeachingTeamEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into cc_ExcellenttTeachingTeam");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_ExcellenttTeachingTeamDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objcc_ExcellenttTeachingTeamEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clscc_ExcellenttTeachingTeamEN objcc_ExcellenttTeachingTeamEN)
{
 if (objcc_ExcellenttTeachingTeamEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objcc_ExcellenttTeachingTeamEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 arrFieldListForInsert.Add(concc_ExcellenttTeachingTeam.ViewCount);
 arrValueListForInsert.Add(objcc_ExcellenttTeachingTeamEN.ViewCount.ToString());
 
 if (objcc_ExcellenttTeachingTeamEN.CourseTypeID !=  null)
 {
 arrFieldListForInsert.Add(concc_ExcellenttTeachingTeam.CourseTypeID);
 var strCourseTypeID = objcc_ExcellenttTeachingTeamEN.CourseTypeID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseTypeID + "'");
 }
 
 if (objcc_ExcellenttTeachingTeamEN.IdXzCollege !=  null)
 {
 arrFieldListForInsert.Add(concc_ExcellenttTeachingTeam.IdXzCollege);
 var strIdXzCollege = objcc_ExcellenttTeachingTeamEN.IdXzCollege.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdXzCollege + "'");
 }
 
 if (objcc_ExcellenttTeachingTeamEN.TeamName !=  null)
 {
 arrFieldListForInsert.Add(concc_ExcellenttTeachingTeam.TeamName);
 var strTeamName = objcc_ExcellenttTeachingTeamEN.TeamName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTeamName + "'");
 }
 
 if (objcc_ExcellenttTeachingTeamEN.TeamLeader !=  null)
 {
 arrFieldListForInsert.Add(concc_ExcellenttTeachingTeam.TeamLeader);
 var strTeamLeader = objcc_ExcellenttTeachingTeamEN.TeamLeader.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTeamLeader + "'");
 }
 
 if (objcc_ExcellenttTeachingTeamEN.Year !=  null)
 {
 arrFieldListForInsert.Add(concc_ExcellenttTeachingTeam.Year);
 var strYear = objcc_ExcellenttTeachingTeamEN.Year.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strYear + "'");
 }
 
 if (objcc_ExcellenttTeachingTeamEN.RecommendCount !=  null)
 {
 arrFieldListForInsert.Add(concc_ExcellenttTeachingTeam.RecommendCount);
 arrValueListForInsert.Add(objcc_ExcellenttTeachingTeamEN.RecommendCount.ToString());
 }
 
 if (objcc_ExcellenttTeachingTeamEN.TeamIntroduction !=  null)
 {
 arrFieldListForInsert.Add(concc_ExcellenttTeachingTeam.TeamIntroduction);
 var strTeamIntroduction = objcc_ExcellenttTeachingTeamEN.TeamIntroduction.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTeamIntroduction + "'");
 }
 
 if (objcc_ExcellenttTeachingTeamEN.TeamMembers !=  null)
 {
 arrFieldListForInsert.Add(concc_ExcellenttTeachingTeam.TeamMembers);
 var strTeamMembers = objcc_ExcellenttTeachingTeamEN.TeamMembers.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTeamMembers + "'");
 }
 
 if (objcc_ExcellenttTeachingTeamEN.Teaching !=  null)
 {
 arrFieldListForInsert.Add(concc_ExcellenttTeachingTeam.Teaching);
 var strTeaching = objcc_ExcellenttTeachingTeamEN.Teaching.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTeaching + "'");
 }
 
 if (objcc_ExcellenttTeachingTeamEN.ResearchWorking !=  null)
 {
 arrFieldListForInsert.Add(concc_ExcellenttTeachingTeam.ResearchWorking);
 var strResearchWorking = objcc_ExcellenttTeachingTeamEN.ResearchWorking.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strResearchWorking + "'");
 }
 
 if (objcc_ExcellenttTeachingTeamEN.TeamPlanning !=  null)
 {
 arrFieldListForInsert.Add(concc_ExcellenttTeachingTeam.TeamPlanning);
 var strTeamPlanning = objcc_ExcellenttTeachingTeamEN.TeamPlanning.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTeamPlanning + "'");
 }
 
 if (objcc_ExcellenttTeachingTeamEN.TeamCourse !=  null)
 {
 arrFieldListForInsert.Add(concc_ExcellenttTeachingTeam.TeamCourse);
 var strTeamCourse = objcc_ExcellenttTeachingTeamEN.TeamCourse.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTeamCourse + "'");
 }
 
 if (objcc_ExcellenttTeachingTeamEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(concc_ExcellenttTeachingTeam.Memo);
 var strMemo = objcc_ExcellenttTeachingTeamEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into cc_ExcellenttTeachingTeam");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_ExcellenttTeachingTeamDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString()).Rows[0][0].ToString();
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objcc_ExcellenttTeachingTeamEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clscc_ExcellenttTeachingTeamEN objcc_ExcellenttTeachingTeamEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objcc_ExcellenttTeachingTeamEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objcc_ExcellenttTeachingTeamEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 arrFieldListForInsert.Add(concc_ExcellenttTeachingTeam.ViewCount);
 arrValueListForInsert.Add(objcc_ExcellenttTeachingTeamEN.ViewCount.ToString());
 
 if (objcc_ExcellenttTeachingTeamEN.CourseTypeID !=  null)
 {
 arrFieldListForInsert.Add(concc_ExcellenttTeachingTeam.CourseTypeID);
 var strCourseTypeID = objcc_ExcellenttTeachingTeamEN.CourseTypeID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseTypeID + "'");
 }
 
 if (objcc_ExcellenttTeachingTeamEN.IdXzCollege !=  null)
 {
 arrFieldListForInsert.Add(concc_ExcellenttTeachingTeam.IdXzCollege);
 var strIdXzCollege = objcc_ExcellenttTeachingTeamEN.IdXzCollege.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdXzCollege + "'");
 }
 
 if (objcc_ExcellenttTeachingTeamEN.TeamName !=  null)
 {
 arrFieldListForInsert.Add(concc_ExcellenttTeachingTeam.TeamName);
 var strTeamName = objcc_ExcellenttTeachingTeamEN.TeamName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTeamName + "'");
 }
 
 if (objcc_ExcellenttTeachingTeamEN.TeamLeader !=  null)
 {
 arrFieldListForInsert.Add(concc_ExcellenttTeachingTeam.TeamLeader);
 var strTeamLeader = objcc_ExcellenttTeachingTeamEN.TeamLeader.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTeamLeader + "'");
 }
 
 if (objcc_ExcellenttTeachingTeamEN.Year !=  null)
 {
 arrFieldListForInsert.Add(concc_ExcellenttTeachingTeam.Year);
 var strYear = objcc_ExcellenttTeachingTeamEN.Year.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strYear + "'");
 }
 
 if (objcc_ExcellenttTeachingTeamEN.RecommendCount !=  null)
 {
 arrFieldListForInsert.Add(concc_ExcellenttTeachingTeam.RecommendCount);
 arrValueListForInsert.Add(objcc_ExcellenttTeachingTeamEN.RecommendCount.ToString());
 }
 
 if (objcc_ExcellenttTeachingTeamEN.TeamIntroduction !=  null)
 {
 arrFieldListForInsert.Add(concc_ExcellenttTeachingTeam.TeamIntroduction);
 var strTeamIntroduction = objcc_ExcellenttTeachingTeamEN.TeamIntroduction.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTeamIntroduction + "'");
 }
 
 if (objcc_ExcellenttTeachingTeamEN.TeamMembers !=  null)
 {
 arrFieldListForInsert.Add(concc_ExcellenttTeachingTeam.TeamMembers);
 var strTeamMembers = objcc_ExcellenttTeachingTeamEN.TeamMembers.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTeamMembers + "'");
 }
 
 if (objcc_ExcellenttTeachingTeamEN.Teaching !=  null)
 {
 arrFieldListForInsert.Add(concc_ExcellenttTeachingTeam.Teaching);
 var strTeaching = objcc_ExcellenttTeachingTeamEN.Teaching.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTeaching + "'");
 }
 
 if (objcc_ExcellenttTeachingTeamEN.ResearchWorking !=  null)
 {
 arrFieldListForInsert.Add(concc_ExcellenttTeachingTeam.ResearchWorking);
 var strResearchWorking = objcc_ExcellenttTeachingTeamEN.ResearchWorking.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strResearchWorking + "'");
 }
 
 if (objcc_ExcellenttTeachingTeamEN.TeamPlanning !=  null)
 {
 arrFieldListForInsert.Add(concc_ExcellenttTeachingTeam.TeamPlanning);
 var strTeamPlanning = objcc_ExcellenttTeachingTeamEN.TeamPlanning.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTeamPlanning + "'");
 }
 
 if (objcc_ExcellenttTeachingTeamEN.TeamCourse !=  null)
 {
 arrFieldListForInsert.Add(concc_ExcellenttTeachingTeam.TeamCourse);
 var strTeamCourse = objcc_ExcellenttTeachingTeamEN.TeamCourse.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTeamCourse + "'");
 }
 
 if (objcc_ExcellenttTeachingTeamEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(concc_ExcellenttTeachingTeam.Memo);
 var strMemo = objcc_ExcellenttTeachingTeamEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into cc_ExcellenttTeachingTeam");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_ExcellenttTeachingTeamDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString(), objSqlConnection, objSqlTransaction).Rows[0][0].ToString();
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objcc_ExcellenttTeachingTeamEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clscc_ExcellenttTeachingTeamEN objcc_ExcellenttTeachingTeamEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objcc_ExcellenttTeachingTeamEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objcc_ExcellenttTeachingTeamEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 arrFieldListForInsert.Add(concc_ExcellenttTeachingTeam.ViewCount);
 arrValueListForInsert.Add(objcc_ExcellenttTeachingTeamEN.ViewCount.ToString());
 
 if (objcc_ExcellenttTeachingTeamEN.CourseTypeID !=  null)
 {
 arrFieldListForInsert.Add(concc_ExcellenttTeachingTeam.CourseTypeID);
 var strCourseTypeID = objcc_ExcellenttTeachingTeamEN.CourseTypeID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseTypeID + "'");
 }
 
 if (objcc_ExcellenttTeachingTeamEN.IdXzCollege !=  null)
 {
 arrFieldListForInsert.Add(concc_ExcellenttTeachingTeam.IdXzCollege);
 var strIdXzCollege = objcc_ExcellenttTeachingTeamEN.IdXzCollege.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdXzCollege + "'");
 }
 
 if (objcc_ExcellenttTeachingTeamEN.TeamName !=  null)
 {
 arrFieldListForInsert.Add(concc_ExcellenttTeachingTeam.TeamName);
 var strTeamName = objcc_ExcellenttTeachingTeamEN.TeamName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTeamName + "'");
 }
 
 if (objcc_ExcellenttTeachingTeamEN.TeamLeader !=  null)
 {
 arrFieldListForInsert.Add(concc_ExcellenttTeachingTeam.TeamLeader);
 var strTeamLeader = objcc_ExcellenttTeachingTeamEN.TeamLeader.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTeamLeader + "'");
 }
 
 if (objcc_ExcellenttTeachingTeamEN.Year !=  null)
 {
 arrFieldListForInsert.Add(concc_ExcellenttTeachingTeam.Year);
 var strYear = objcc_ExcellenttTeachingTeamEN.Year.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strYear + "'");
 }
 
 if (objcc_ExcellenttTeachingTeamEN.RecommendCount !=  null)
 {
 arrFieldListForInsert.Add(concc_ExcellenttTeachingTeam.RecommendCount);
 arrValueListForInsert.Add(objcc_ExcellenttTeachingTeamEN.RecommendCount.ToString());
 }
 
 if (objcc_ExcellenttTeachingTeamEN.TeamIntroduction !=  null)
 {
 arrFieldListForInsert.Add(concc_ExcellenttTeachingTeam.TeamIntroduction);
 var strTeamIntroduction = objcc_ExcellenttTeachingTeamEN.TeamIntroduction.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTeamIntroduction + "'");
 }
 
 if (objcc_ExcellenttTeachingTeamEN.TeamMembers !=  null)
 {
 arrFieldListForInsert.Add(concc_ExcellenttTeachingTeam.TeamMembers);
 var strTeamMembers = objcc_ExcellenttTeachingTeamEN.TeamMembers.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTeamMembers + "'");
 }
 
 if (objcc_ExcellenttTeachingTeamEN.Teaching !=  null)
 {
 arrFieldListForInsert.Add(concc_ExcellenttTeachingTeam.Teaching);
 var strTeaching = objcc_ExcellenttTeachingTeamEN.Teaching.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTeaching + "'");
 }
 
 if (objcc_ExcellenttTeachingTeamEN.ResearchWorking !=  null)
 {
 arrFieldListForInsert.Add(concc_ExcellenttTeachingTeam.ResearchWorking);
 var strResearchWorking = objcc_ExcellenttTeachingTeamEN.ResearchWorking.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strResearchWorking + "'");
 }
 
 if (objcc_ExcellenttTeachingTeamEN.TeamPlanning !=  null)
 {
 arrFieldListForInsert.Add(concc_ExcellenttTeachingTeam.TeamPlanning);
 var strTeamPlanning = objcc_ExcellenttTeachingTeamEN.TeamPlanning.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTeamPlanning + "'");
 }
 
 if (objcc_ExcellenttTeachingTeamEN.TeamCourse !=  null)
 {
 arrFieldListForInsert.Add(concc_ExcellenttTeachingTeam.TeamCourse);
 var strTeamCourse = objcc_ExcellenttTeachingTeamEN.TeamCourse.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTeamCourse + "'");
 }
 
 if (objcc_ExcellenttTeachingTeamEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(concc_ExcellenttTeachingTeam.Memo);
 var strMemo = objcc_ExcellenttTeachingTeamEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into cc_ExcellenttTeachingTeam");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_ExcellenttTeachingTeamDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool Addnewcc_ExcellenttTeachingTeams(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_ExcellenttTeachingTeamDA.GetSpecSQLObj();
strSQL = "Select * from cc_ExcellenttTeachingTeam where ExcellenttTeachingTeamID = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "cc_ExcellenttTeachingTeam");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
long lngExcellenttTeachingTeamID = TransNullToInt(oRow[concc_ExcellenttTeachingTeam.ExcellenttTeachingTeamID].ToString().Trim());
if (IsExist(lngExcellenttTeachingTeamID))
{
 string strResult = "关键字变量值为:" + string.Format("ExcellenttTeachingTeamID = {0}", lngExcellenttTeachingTeamID) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clscc_ExcellenttTeachingTeamEN._CurrTabName ].NewRow();
objRow[concc_ExcellenttTeachingTeam.ViewCount] = oRow[concc_ExcellenttTeachingTeam.ViewCount].ToString().Trim(); //浏览量
objRow[concc_ExcellenttTeachingTeam.CourseTypeID] = oRow[concc_ExcellenttTeachingTeam.CourseTypeID].ToString().Trim(); //课程类型ID
objRow[concc_ExcellenttTeachingTeam.IdXzCollege] = oRow[concc_ExcellenttTeachingTeam.IdXzCollege].ToString().Trim(); //学院流水号
objRow[concc_ExcellenttTeachingTeam.TeamName] = oRow[concc_ExcellenttTeachingTeam.TeamName].ToString().Trim(); //团队名称
objRow[concc_ExcellenttTeachingTeam.TeamLeader] = oRow[concc_ExcellenttTeachingTeam.TeamLeader].ToString().Trim(); //团队带头人
objRow[concc_ExcellenttTeachingTeam.Year] = oRow[concc_ExcellenttTeachingTeam.Year].ToString().Trim(); //年份
objRow[concc_ExcellenttTeachingTeam.RecommendCount] = oRow[concc_ExcellenttTeachingTeam.RecommendCount].ToString().Trim(); //推荐次数
objRow[concc_ExcellenttTeachingTeam.TeamIntroduction] = oRow[concc_ExcellenttTeachingTeam.TeamIntroduction].ToString().Trim(); //团队简介
objRow[concc_ExcellenttTeachingTeam.TeamMembers] = oRow[concc_ExcellenttTeachingTeam.TeamMembers].ToString().Trim(); //团队成员
objRow[concc_ExcellenttTeachingTeam.Teaching] = oRow[concc_ExcellenttTeachingTeam.Teaching].ToString().Trim(); //教学工作
objRow[concc_ExcellenttTeachingTeam.ResearchWorking] = oRow[concc_ExcellenttTeachingTeam.ResearchWorking].ToString().Trim(); //科研工作
objRow[concc_ExcellenttTeachingTeam.TeamPlanning] = oRow[concc_ExcellenttTeachingTeam.TeamPlanning].ToString().Trim(); //团队规划
objRow[concc_ExcellenttTeachingTeam.TeamCourse] = oRow[concc_ExcellenttTeachingTeam.TeamCourse].ToString().Trim(); //团队课程
objRow[concc_ExcellenttTeachingTeam.Memo] = oRow[concc_ExcellenttTeachingTeam.Memo].ToString().Trim(); //备注
 objDS.Tables[clscc_ExcellenttTeachingTeamEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clscc_ExcellenttTeachingTeamEN._CurrTabName);
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
 /// <param name = "objcc_ExcellenttTeachingTeamEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clscc_ExcellenttTeachingTeamEN objcc_ExcellenttTeachingTeamEN)
{
 if (objcc_ExcellenttTeachingTeamEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objcc_ExcellenttTeachingTeamEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_ExcellenttTeachingTeamDA.GetSpecSQLObj();
strSQL = "Select * from cc_ExcellenttTeachingTeam where ExcellenttTeachingTeamID = " + ""+ objcc_ExcellenttTeachingTeamEN.ExcellenttTeachingTeamID+"";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clscc_ExcellenttTeachingTeamEN._CurrTabName);
if (objDS.Tables[clscc_ExcellenttTeachingTeamEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:ExcellenttTeachingTeamID = " + ""+ objcc_ExcellenttTeachingTeamEN.ExcellenttTeachingTeamID+"");
return false;
}
objRow = objDS.Tables[clscc_ExcellenttTeachingTeamEN._CurrTabName].Rows[0];
 if (objcc_ExcellenttTeachingTeamEN.IsUpdated(concc_ExcellenttTeachingTeam.ViewCount))
 {
objRow[concc_ExcellenttTeachingTeam.ViewCount] = objcc_ExcellenttTeachingTeamEN.ViewCount; //浏览量
 }
 if (objcc_ExcellenttTeachingTeamEN.IsUpdated(concc_ExcellenttTeachingTeam.CourseTypeID))
 {
objRow[concc_ExcellenttTeachingTeam.CourseTypeID] = objcc_ExcellenttTeachingTeamEN.CourseTypeID; //课程类型ID
 }
 if (objcc_ExcellenttTeachingTeamEN.IsUpdated(concc_ExcellenttTeachingTeam.IdXzCollege))
 {
objRow[concc_ExcellenttTeachingTeam.IdXzCollege] = objcc_ExcellenttTeachingTeamEN.IdXzCollege; //学院流水号
 }
 if (objcc_ExcellenttTeachingTeamEN.IsUpdated(concc_ExcellenttTeachingTeam.TeamName))
 {
objRow[concc_ExcellenttTeachingTeam.TeamName] = objcc_ExcellenttTeachingTeamEN.TeamName; //团队名称
 }
 if (objcc_ExcellenttTeachingTeamEN.IsUpdated(concc_ExcellenttTeachingTeam.TeamLeader))
 {
objRow[concc_ExcellenttTeachingTeam.TeamLeader] = objcc_ExcellenttTeachingTeamEN.TeamLeader; //团队带头人
 }
 if (objcc_ExcellenttTeachingTeamEN.IsUpdated(concc_ExcellenttTeachingTeam.Year))
 {
objRow[concc_ExcellenttTeachingTeam.Year] = objcc_ExcellenttTeachingTeamEN.Year; //年份
 }
 if (objcc_ExcellenttTeachingTeamEN.IsUpdated(concc_ExcellenttTeachingTeam.RecommendCount))
 {
objRow[concc_ExcellenttTeachingTeam.RecommendCount] = objcc_ExcellenttTeachingTeamEN.RecommendCount; //推荐次数
 }
 if (objcc_ExcellenttTeachingTeamEN.IsUpdated(concc_ExcellenttTeachingTeam.TeamIntroduction))
 {
objRow[concc_ExcellenttTeachingTeam.TeamIntroduction] = objcc_ExcellenttTeachingTeamEN.TeamIntroduction; //团队简介
 }
 if (objcc_ExcellenttTeachingTeamEN.IsUpdated(concc_ExcellenttTeachingTeam.TeamMembers))
 {
objRow[concc_ExcellenttTeachingTeam.TeamMembers] = objcc_ExcellenttTeachingTeamEN.TeamMembers; //团队成员
 }
 if (objcc_ExcellenttTeachingTeamEN.IsUpdated(concc_ExcellenttTeachingTeam.Teaching))
 {
objRow[concc_ExcellenttTeachingTeam.Teaching] = objcc_ExcellenttTeachingTeamEN.Teaching; //教学工作
 }
 if (objcc_ExcellenttTeachingTeamEN.IsUpdated(concc_ExcellenttTeachingTeam.ResearchWorking))
 {
objRow[concc_ExcellenttTeachingTeam.ResearchWorking] = objcc_ExcellenttTeachingTeamEN.ResearchWorking; //科研工作
 }
 if (objcc_ExcellenttTeachingTeamEN.IsUpdated(concc_ExcellenttTeachingTeam.TeamPlanning))
 {
objRow[concc_ExcellenttTeachingTeam.TeamPlanning] = objcc_ExcellenttTeachingTeamEN.TeamPlanning; //团队规划
 }
 if (objcc_ExcellenttTeachingTeamEN.IsUpdated(concc_ExcellenttTeachingTeam.TeamCourse))
 {
objRow[concc_ExcellenttTeachingTeam.TeamCourse] = objcc_ExcellenttTeachingTeamEN.TeamCourse; //团队课程
 }
 if (objcc_ExcellenttTeachingTeamEN.IsUpdated(concc_ExcellenttTeachingTeam.Memo))
 {
objRow[concc_ExcellenttTeachingTeam.Memo] = objcc_ExcellenttTeachingTeamEN.Memo; //备注
 }
try
{
objDA.Update(objDS, clscc_ExcellenttTeachingTeamEN._CurrTabName);
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
 /// <param name = "objcc_ExcellenttTeachingTeamEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clscc_ExcellenttTeachingTeamEN objcc_ExcellenttTeachingTeamEN)
{
 if (objcc_ExcellenttTeachingTeamEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objcc_ExcellenttTeachingTeamEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_ExcellenttTeachingTeamDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update cc_ExcellenttTeachingTeam Set ");
 
 if (objcc_ExcellenttTeachingTeamEN.IsUpdated(concc_ExcellenttTeachingTeam.ViewCount))
 {
 sbSQL.AppendFormat("{1} = {0},",objcc_ExcellenttTeachingTeamEN.ViewCount, concc_ExcellenttTeachingTeam.ViewCount); //浏览量
 }
 
 if (objcc_ExcellenttTeachingTeamEN.IsUpdated(concc_ExcellenttTeachingTeam.CourseTypeID))
 {
 if (objcc_ExcellenttTeachingTeamEN.CourseTypeID !=  null)
 {
 var strCourseTypeID = objcc_ExcellenttTeachingTeamEN.CourseTypeID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCourseTypeID, concc_ExcellenttTeachingTeam.CourseTypeID); //课程类型ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_ExcellenttTeachingTeam.CourseTypeID); //课程类型ID
 }
 }
 
 if (objcc_ExcellenttTeachingTeamEN.IsUpdated(concc_ExcellenttTeachingTeam.IdXzCollege))
 {
 if (objcc_ExcellenttTeachingTeamEN.IdXzCollege !=  null)
 {
 var strIdXzCollege = objcc_ExcellenttTeachingTeamEN.IdXzCollege.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdXzCollege, concc_ExcellenttTeachingTeam.IdXzCollege); //学院流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_ExcellenttTeachingTeam.IdXzCollege); //学院流水号
 }
 }
 
 if (objcc_ExcellenttTeachingTeamEN.IsUpdated(concc_ExcellenttTeachingTeam.TeamName))
 {
 if (objcc_ExcellenttTeachingTeamEN.TeamName !=  null)
 {
 var strTeamName = objcc_ExcellenttTeachingTeamEN.TeamName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTeamName, concc_ExcellenttTeachingTeam.TeamName); //团队名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_ExcellenttTeachingTeam.TeamName); //团队名称
 }
 }
 
 if (objcc_ExcellenttTeachingTeamEN.IsUpdated(concc_ExcellenttTeachingTeam.TeamLeader))
 {
 if (objcc_ExcellenttTeachingTeamEN.TeamLeader !=  null)
 {
 var strTeamLeader = objcc_ExcellenttTeachingTeamEN.TeamLeader.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTeamLeader, concc_ExcellenttTeachingTeam.TeamLeader); //团队带头人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_ExcellenttTeachingTeam.TeamLeader); //团队带头人
 }
 }
 
 if (objcc_ExcellenttTeachingTeamEN.IsUpdated(concc_ExcellenttTeachingTeam.Year))
 {
 if (objcc_ExcellenttTeachingTeamEN.Year !=  null)
 {
 var strYear = objcc_ExcellenttTeachingTeamEN.Year.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strYear, concc_ExcellenttTeachingTeam.Year); //年份
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_ExcellenttTeachingTeam.Year); //年份
 }
 }
 
 if (objcc_ExcellenttTeachingTeamEN.IsUpdated(concc_ExcellenttTeachingTeam.RecommendCount))
 {
 if (objcc_ExcellenttTeachingTeamEN.RecommendCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objcc_ExcellenttTeachingTeamEN.RecommendCount, concc_ExcellenttTeachingTeam.RecommendCount); //推荐次数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_ExcellenttTeachingTeam.RecommendCount); //推荐次数
 }
 }
 
 if (objcc_ExcellenttTeachingTeamEN.IsUpdated(concc_ExcellenttTeachingTeam.TeamIntroduction))
 {
 if (objcc_ExcellenttTeachingTeamEN.TeamIntroduction !=  null)
 {
 var strTeamIntroduction = objcc_ExcellenttTeachingTeamEN.TeamIntroduction.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTeamIntroduction, concc_ExcellenttTeachingTeam.TeamIntroduction); //团队简介
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_ExcellenttTeachingTeam.TeamIntroduction); //团队简介
 }
 }
 
 if (objcc_ExcellenttTeachingTeamEN.IsUpdated(concc_ExcellenttTeachingTeam.TeamMembers))
 {
 if (objcc_ExcellenttTeachingTeamEN.TeamMembers !=  null)
 {
 var strTeamMembers = objcc_ExcellenttTeachingTeamEN.TeamMembers.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTeamMembers, concc_ExcellenttTeachingTeam.TeamMembers); //团队成员
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_ExcellenttTeachingTeam.TeamMembers); //团队成员
 }
 }
 
 if (objcc_ExcellenttTeachingTeamEN.IsUpdated(concc_ExcellenttTeachingTeam.Teaching))
 {
 if (objcc_ExcellenttTeachingTeamEN.Teaching !=  null)
 {
 var strTeaching = objcc_ExcellenttTeachingTeamEN.Teaching.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTeaching, concc_ExcellenttTeachingTeam.Teaching); //教学工作
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_ExcellenttTeachingTeam.Teaching); //教学工作
 }
 }
 
 if (objcc_ExcellenttTeachingTeamEN.IsUpdated(concc_ExcellenttTeachingTeam.ResearchWorking))
 {
 if (objcc_ExcellenttTeachingTeamEN.ResearchWorking !=  null)
 {
 var strResearchWorking = objcc_ExcellenttTeachingTeamEN.ResearchWorking.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strResearchWorking, concc_ExcellenttTeachingTeam.ResearchWorking); //科研工作
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_ExcellenttTeachingTeam.ResearchWorking); //科研工作
 }
 }
 
 if (objcc_ExcellenttTeachingTeamEN.IsUpdated(concc_ExcellenttTeachingTeam.TeamPlanning))
 {
 if (objcc_ExcellenttTeachingTeamEN.TeamPlanning !=  null)
 {
 var strTeamPlanning = objcc_ExcellenttTeachingTeamEN.TeamPlanning.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTeamPlanning, concc_ExcellenttTeachingTeam.TeamPlanning); //团队规划
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_ExcellenttTeachingTeam.TeamPlanning); //团队规划
 }
 }
 
 if (objcc_ExcellenttTeachingTeamEN.IsUpdated(concc_ExcellenttTeachingTeam.TeamCourse))
 {
 if (objcc_ExcellenttTeachingTeamEN.TeamCourse !=  null)
 {
 var strTeamCourse = objcc_ExcellenttTeachingTeamEN.TeamCourse.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTeamCourse, concc_ExcellenttTeachingTeam.TeamCourse); //团队课程
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_ExcellenttTeachingTeam.TeamCourse); //团队课程
 }
 }
 
 if (objcc_ExcellenttTeachingTeamEN.IsUpdated(concc_ExcellenttTeachingTeam.Memo))
 {
 if (objcc_ExcellenttTeachingTeamEN.Memo !=  null)
 {
 var strMemo = objcc_ExcellenttTeachingTeamEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, concc_ExcellenttTeachingTeam.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_ExcellenttTeachingTeam.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where ExcellenttTeachingTeamID = {0}", objcc_ExcellenttTeachingTeamEN.ExcellenttTeachingTeamID); 
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
 /// <param name = "objcc_ExcellenttTeachingTeamEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clscc_ExcellenttTeachingTeamEN objcc_ExcellenttTeachingTeamEN, string strCondition)
{
 if (objcc_ExcellenttTeachingTeamEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objcc_ExcellenttTeachingTeamEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_ExcellenttTeachingTeamDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update cc_ExcellenttTeachingTeam Set ");
 
 if (objcc_ExcellenttTeachingTeamEN.IsUpdated(concc_ExcellenttTeachingTeam.ViewCount))
 {
 sbSQL.AppendFormat(" ViewCount = {0},", objcc_ExcellenttTeachingTeamEN.ViewCount); //浏览量
 }
 
 if (objcc_ExcellenttTeachingTeamEN.IsUpdated(concc_ExcellenttTeachingTeam.CourseTypeID))
 {
 if (objcc_ExcellenttTeachingTeamEN.CourseTypeID !=  null)
 {
 var strCourseTypeID = objcc_ExcellenttTeachingTeamEN.CourseTypeID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CourseTypeID = '{0}',", strCourseTypeID); //课程类型ID
 }
 else
 {
 sbSQL.Append(" CourseTypeID = null,"); //课程类型ID
 }
 }
 
 if (objcc_ExcellenttTeachingTeamEN.IsUpdated(concc_ExcellenttTeachingTeam.IdXzCollege))
 {
 if (objcc_ExcellenttTeachingTeamEN.IdXzCollege !=  null)
 {
 var strIdXzCollege = objcc_ExcellenttTeachingTeamEN.IdXzCollege.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdXzCollege = '{0}',", strIdXzCollege); //学院流水号
 }
 else
 {
 sbSQL.Append(" IdXzCollege = null,"); //学院流水号
 }
 }
 
 if (objcc_ExcellenttTeachingTeamEN.IsUpdated(concc_ExcellenttTeachingTeam.TeamName))
 {
 if (objcc_ExcellenttTeachingTeamEN.TeamName !=  null)
 {
 var strTeamName = objcc_ExcellenttTeachingTeamEN.TeamName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TeamName = '{0}',", strTeamName); //团队名称
 }
 else
 {
 sbSQL.Append(" TeamName = null,"); //团队名称
 }
 }
 
 if (objcc_ExcellenttTeachingTeamEN.IsUpdated(concc_ExcellenttTeachingTeam.TeamLeader))
 {
 if (objcc_ExcellenttTeachingTeamEN.TeamLeader !=  null)
 {
 var strTeamLeader = objcc_ExcellenttTeachingTeamEN.TeamLeader.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TeamLeader = '{0}',", strTeamLeader); //团队带头人
 }
 else
 {
 sbSQL.Append(" TeamLeader = null,"); //团队带头人
 }
 }
 
 if (objcc_ExcellenttTeachingTeamEN.IsUpdated(concc_ExcellenttTeachingTeam.Year))
 {
 if (objcc_ExcellenttTeachingTeamEN.Year !=  null)
 {
 var strYear = objcc_ExcellenttTeachingTeamEN.Year.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Year = '{0}',", strYear); //年份
 }
 else
 {
 sbSQL.Append(" Year = null,"); //年份
 }
 }
 
 if (objcc_ExcellenttTeachingTeamEN.IsUpdated(concc_ExcellenttTeachingTeam.RecommendCount))
 {
 sbSQL.AppendFormat(" RecommendCount = {0},", objcc_ExcellenttTeachingTeamEN.RecommendCount); //推荐次数
 }
 
 if (objcc_ExcellenttTeachingTeamEN.IsUpdated(concc_ExcellenttTeachingTeam.TeamIntroduction))
 {
 if (objcc_ExcellenttTeachingTeamEN.TeamIntroduction !=  null)
 {
 var strTeamIntroduction = objcc_ExcellenttTeachingTeamEN.TeamIntroduction.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TeamIntroduction = '{0}',", strTeamIntroduction); //团队简介
 }
 else
 {
 sbSQL.Append(" TeamIntroduction = null,"); //团队简介
 }
 }
 
 if (objcc_ExcellenttTeachingTeamEN.IsUpdated(concc_ExcellenttTeachingTeam.TeamMembers))
 {
 if (objcc_ExcellenttTeachingTeamEN.TeamMembers !=  null)
 {
 var strTeamMembers = objcc_ExcellenttTeachingTeamEN.TeamMembers.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TeamMembers = '{0}',", strTeamMembers); //团队成员
 }
 else
 {
 sbSQL.Append(" TeamMembers = null,"); //团队成员
 }
 }
 
 if (objcc_ExcellenttTeachingTeamEN.IsUpdated(concc_ExcellenttTeachingTeam.Teaching))
 {
 if (objcc_ExcellenttTeachingTeamEN.Teaching !=  null)
 {
 var strTeaching = objcc_ExcellenttTeachingTeamEN.Teaching.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Teaching = '{0}',", strTeaching); //教学工作
 }
 else
 {
 sbSQL.Append(" Teaching = null,"); //教学工作
 }
 }
 
 if (objcc_ExcellenttTeachingTeamEN.IsUpdated(concc_ExcellenttTeachingTeam.ResearchWorking))
 {
 if (objcc_ExcellenttTeachingTeamEN.ResearchWorking !=  null)
 {
 var strResearchWorking = objcc_ExcellenttTeachingTeamEN.ResearchWorking.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ResearchWorking = '{0}',", strResearchWorking); //科研工作
 }
 else
 {
 sbSQL.Append(" ResearchWorking = null,"); //科研工作
 }
 }
 
 if (objcc_ExcellenttTeachingTeamEN.IsUpdated(concc_ExcellenttTeachingTeam.TeamPlanning))
 {
 if (objcc_ExcellenttTeachingTeamEN.TeamPlanning !=  null)
 {
 var strTeamPlanning = objcc_ExcellenttTeachingTeamEN.TeamPlanning.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TeamPlanning = '{0}',", strTeamPlanning); //团队规划
 }
 else
 {
 sbSQL.Append(" TeamPlanning = null,"); //团队规划
 }
 }
 
 if (objcc_ExcellenttTeachingTeamEN.IsUpdated(concc_ExcellenttTeachingTeam.TeamCourse))
 {
 if (objcc_ExcellenttTeachingTeamEN.TeamCourse !=  null)
 {
 var strTeamCourse = objcc_ExcellenttTeachingTeamEN.TeamCourse.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TeamCourse = '{0}',", strTeamCourse); //团队课程
 }
 else
 {
 sbSQL.Append(" TeamCourse = null,"); //团队课程
 }
 }
 
 if (objcc_ExcellenttTeachingTeamEN.IsUpdated(concc_ExcellenttTeachingTeam.Memo))
 {
 if (objcc_ExcellenttTeachingTeamEN.Memo !=  null)
 {
 var strMemo = objcc_ExcellenttTeachingTeamEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objcc_ExcellenttTeachingTeamEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clscc_ExcellenttTeachingTeamEN objcc_ExcellenttTeachingTeamEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objcc_ExcellenttTeachingTeamEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objcc_ExcellenttTeachingTeamEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_ExcellenttTeachingTeamDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update cc_ExcellenttTeachingTeam Set ");
 
 if (objcc_ExcellenttTeachingTeamEN.IsUpdated(concc_ExcellenttTeachingTeam.ViewCount))
 {
 sbSQL.AppendFormat(" ViewCount = {0},", objcc_ExcellenttTeachingTeamEN.ViewCount); //浏览量
 }
 
 if (objcc_ExcellenttTeachingTeamEN.IsUpdated(concc_ExcellenttTeachingTeam.CourseTypeID))
 {
 if (objcc_ExcellenttTeachingTeamEN.CourseTypeID !=  null)
 {
 var strCourseTypeID = objcc_ExcellenttTeachingTeamEN.CourseTypeID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CourseTypeID = '{0}',", strCourseTypeID); //课程类型ID
 }
 else
 {
 sbSQL.Append(" CourseTypeID = null,"); //课程类型ID
 }
 }
 
 if (objcc_ExcellenttTeachingTeamEN.IsUpdated(concc_ExcellenttTeachingTeam.IdXzCollege))
 {
 if (objcc_ExcellenttTeachingTeamEN.IdXzCollege !=  null)
 {
 var strIdXzCollege = objcc_ExcellenttTeachingTeamEN.IdXzCollege.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdXzCollege = '{0}',", strIdXzCollege); //学院流水号
 }
 else
 {
 sbSQL.Append(" IdXzCollege = null,"); //学院流水号
 }
 }
 
 if (objcc_ExcellenttTeachingTeamEN.IsUpdated(concc_ExcellenttTeachingTeam.TeamName))
 {
 if (objcc_ExcellenttTeachingTeamEN.TeamName !=  null)
 {
 var strTeamName = objcc_ExcellenttTeachingTeamEN.TeamName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TeamName = '{0}',", strTeamName); //团队名称
 }
 else
 {
 sbSQL.Append(" TeamName = null,"); //团队名称
 }
 }
 
 if (objcc_ExcellenttTeachingTeamEN.IsUpdated(concc_ExcellenttTeachingTeam.TeamLeader))
 {
 if (objcc_ExcellenttTeachingTeamEN.TeamLeader !=  null)
 {
 var strTeamLeader = objcc_ExcellenttTeachingTeamEN.TeamLeader.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TeamLeader = '{0}',", strTeamLeader); //团队带头人
 }
 else
 {
 sbSQL.Append(" TeamLeader = null,"); //团队带头人
 }
 }
 
 if (objcc_ExcellenttTeachingTeamEN.IsUpdated(concc_ExcellenttTeachingTeam.Year))
 {
 if (objcc_ExcellenttTeachingTeamEN.Year !=  null)
 {
 var strYear = objcc_ExcellenttTeachingTeamEN.Year.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Year = '{0}',", strYear); //年份
 }
 else
 {
 sbSQL.Append(" Year = null,"); //年份
 }
 }
 
 if (objcc_ExcellenttTeachingTeamEN.IsUpdated(concc_ExcellenttTeachingTeam.RecommendCount))
 {
 sbSQL.AppendFormat(" RecommendCount = {0},", objcc_ExcellenttTeachingTeamEN.RecommendCount); //推荐次数
 }
 
 if (objcc_ExcellenttTeachingTeamEN.IsUpdated(concc_ExcellenttTeachingTeam.TeamIntroduction))
 {
 if (objcc_ExcellenttTeachingTeamEN.TeamIntroduction !=  null)
 {
 var strTeamIntroduction = objcc_ExcellenttTeachingTeamEN.TeamIntroduction.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TeamIntroduction = '{0}',", strTeamIntroduction); //团队简介
 }
 else
 {
 sbSQL.Append(" TeamIntroduction = null,"); //团队简介
 }
 }
 
 if (objcc_ExcellenttTeachingTeamEN.IsUpdated(concc_ExcellenttTeachingTeam.TeamMembers))
 {
 if (objcc_ExcellenttTeachingTeamEN.TeamMembers !=  null)
 {
 var strTeamMembers = objcc_ExcellenttTeachingTeamEN.TeamMembers.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TeamMembers = '{0}',", strTeamMembers); //团队成员
 }
 else
 {
 sbSQL.Append(" TeamMembers = null,"); //团队成员
 }
 }
 
 if (objcc_ExcellenttTeachingTeamEN.IsUpdated(concc_ExcellenttTeachingTeam.Teaching))
 {
 if (objcc_ExcellenttTeachingTeamEN.Teaching !=  null)
 {
 var strTeaching = objcc_ExcellenttTeachingTeamEN.Teaching.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Teaching = '{0}',", strTeaching); //教学工作
 }
 else
 {
 sbSQL.Append(" Teaching = null,"); //教学工作
 }
 }
 
 if (objcc_ExcellenttTeachingTeamEN.IsUpdated(concc_ExcellenttTeachingTeam.ResearchWorking))
 {
 if (objcc_ExcellenttTeachingTeamEN.ResearchWorking !=  null)
 {
 var strResearchWorking = objcc_ExcellenttTeachingTeamEN.ResearchWorking.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ResearchWorking = '{0}',", strResearchWorking); //科研工作
 }
 else
 {
 sbSQL.Append(" ResearchWorking = null,"); //科研工作
 }
 }
 
 if (objcc_ExcellenttTeachingTeamEN.IsUpdated(concc_ExcellenttTeachingTeam.TeamPlanning))
 {
 if (objcc_ExcellenttTeachingTeamEN.TeamPlanning !=  null)
 {
 var strTeamPlanning = objcc_ExcellenttTeachingTeamEN.TeamPlanning.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TeamPlanning = '{0}',", strTeamPlanning); //团队规划
 }
 else
 {
 sbSQL.Append(" TeamPlanning = null,"); //团队规划
 }
 }
 
 if (objcc_ExcellenttTeachingTeamEN.IsUpdated(concc_ExcellenttTeachingTeam.TeamCourse))
 {
 if (objcc_ExcellenttTeachingTeamEN.TeamCourse !=  null)
 {
 var strTeamCourse = objcc_ExcellenttTeachingTeamEN.TeamCourse.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TeamCourse = '{0}',", strTeamCourse); //团队课程
 }
 else
 {
 sbSQL.Append(" TeamCourse = null,"); //团队课程
 }
 }
 
 if (objcc_ExcellenttTeachingTeamEN.IsUpdated(concc_ExcellenttTeachingTeam.Memo))
 {
 if (objcc_ExcellenttTeachingTeamEN.Memo !=  null)
 {
 var strMemo = objcc_ExcellenttTeachingTeamEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objcc_ExcellenttTeachingTeamEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clscc_ExcellenttTeachingTeamEN objcc_ExcellenttTeachingTeamEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objcc_ExcellenttTeachingTeamEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objcc_ExcellenttTeachingTeamEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_ExcellenttTeachingTeamDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update cc_ExcellenttTeachingTeam Set ");
 
 if (objcc_ExcellenttTeachingTeamEN.IsUpdated(concc_ExcellenttTeachingTeam.ViewCount))
 {
 sbSQL.AppendFormat("{1} = {0},",objcc_ExcellenttTeachingTeamEN.ViewCount, concc_ExcellenttTeachingTeam.ViewCount); //浏览量
 }
 
 if (objcc_ExcellenttTeachingTeamEN.IsUpdated(concc_ExcellenttTeachingTeam.CourseTypeID))
 {
 if (objcc_ExcellenttTeachingTeamEN.CourseTypeID !=  null)
 {
 var strCourseTypeID = objcc_ExcellenttTeachingTeamEN.CourseTypeID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCourseTypeID, concc_ExcellenttTeachingTeam.CourseTypeID); //课程类型ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_ExcellenttTeachingTeam.CourseTypeID); //课程类型ID
 }
 }
 
 if (objcc_ExcellenttTeachingTeamEN.IsUpdated(concc_ExcellenttTeachingTeam.IdXzCollege))
 {
 if (objcc_ExcellenttTeachingTeamEN.IdXzCollege !=  null)
 {
 var strIdXzCollege = objcc_ExcellenttTeachingTeamEN.IdXzCollege.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdXzCollege, concc_ExcellenttTeachingTeam.IdXzCollege); //学院流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_ExcellenttTeachingTeam.IdXzCollege); //学院流水号
 }
 }
 
 if (objcc_ExcellenttTeachingTeamEN.IsUpdated(concc_ExcellenttTeachingTeam.TeamName))
 {
 if (objcc_ExcellenttTeachingTeamEN.TeamName !=  null)
 {
 var strTeamName = objcc_ExcellenttTeachingTeamEN.TeamName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTeamName, concc_ExcellenttTeachingTeam.TeamName); //团队名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_ExcellenttTeachingTeam.TeamName); //团队名称
 }
 }
 
 if (objcc_ExcellenttTeachingTeamEN.IsUpdated(concc_ExcellenttTeachingTeam.TeamLeader))
 {
 if (objcc_ExcellenttTeachingTeamEN.TeamLeader !=  null)
 {
 var strTeamLeader = objcc_ExcellenttTeachingTeamEN.TeamLeader.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTeamLeader, concc_ExcellenttTeachingTeam.TeamLeader); //团队带头人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_ExcellenttTeachingTeam.TeamLeader); //团队带头人
 }
 }
 
 if (objcc_ExcellenttTeachingTeamEN.IsUpdated(concc_ExcellenttTeachingTeam.Year))
 {
 if (objcc_ExcellenttTeachingTeamEN.Year !=  null)
 {
 var strYear = objcc_ExcellenttTeachingTeamEN.Year.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strYear, concc_ExcellenttTeachingTeam.Year); //年份
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_ExcellenttTeachingTeam.Year); //年份
 }
 }
 
 if (objcc_ExcellenttTeachingTeamEN.IsUpdated(concc_ExcellenttTeachingTeam.RecommendCount))
 {
 if (objcc_ExcellenttTeachingTeamEN.RecommendCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objcc_ExcellenttTeachingTeamEN.RecommendCount, concc_ExcellenttTeachingTeam.RecommendCount); //推荐次数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_ExcellenttTeachingTeam.RecommendCount); //推荐次数
 }
 }
 
 if (objcc_ExcellenttTeachingTeamEN.IsUpdated(concc_ExcellenttTeachingTeam.TeamIntroduction))
 {
 if (objcc_ExcellenttTeachingTeamEN.TeamIntroduction !=  null)
 {
 var strTeamIntroduction = objcc_ExcellenttTeachingTeamEN.TeamIntroduction.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTeamIntroduction, concc_ExcellenttTeachingTeam.TeamIntroduction); //团队简介
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_ExcellenttTeachingTeam.TeamIntroduction); //团队简介
 }
 }
 
 if (objcc_ExcellenttTeachingTeamEN.IsUpdated(concc_ExcellenttTeachingTeam.TeamMembers))
 {
 if (objcc_ExcellenttTeachingTeamEN.TeamMembers !=  null)
 {
 var strTeamMembers = objcc_ExcellenttTeachingTeamEN.TeamMembers.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTeamMembers, concc_ExcellenttTeachingTeam.TeamMembers); //团队成员
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_ExcellenttTeachingTeam.TeamMembers); //团队成员
 }
 }
 
 if (objcc_ExcellenttTeachingTeamEN.IsUpdated(concc_ExcellenttTeachingTeam.Teaching))
 {
 if (objcc_ExcellenttTeachingTeamEN.Teaching !=  null)
 {
 var strTeaching = objcc_ExcellenttTeachingTeamEN.Teaching.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTeaching, concc_ExcellenttTeachingTeam.Teaching); //教学工作
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_ExcellenttTeachingTeam.Teaching); //教学工作
 }
 }
 
 if (objcc_ExcellenttTeachingTeamEN.IsUpdated(concc_ExcellenttTeachingTeam.ResearchWorking))
 {
 if (objcc_ExcellenttTeachingTeamEN.ResearchWorking !=  null)
 {
 var strResearchWorking = objcc_ExcellenttTeachingTeamEN.ResearchWorking.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strResearchWorking, concc_ExcellenttTeachingTeam.ResearchWorking); //科研工作
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_ExcellenttTeachingTeam.ResearchWorking); //科研工作
 }
 }
 
 if (objcc_ExcellenttTeachingTeamEN.IsUpdated(concc_ExcellenttTeachingTeam.TeamPlanning))
 {
 if (objcc_ExcellenttTeachingTeamEN.TeamPlanning !=  null)
 {
 var strTeamPlanning = objcc_ExcellenttTeachingTeamEN.TeamPlanning.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTeamPlanning, concc_ExcellenttTeachingTeam.TeamPlanning); //团队规划
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_ExcellenttTeachingTeam.TeamPlanning); //团队规划
 }
 }
 
 if (objcc_ExcellenttTeachingTeamEN.IsUpdated(concc_ExcellenttTeachingTeam.TeamCourse))
 {
 if (objcc_ExcellenttTeachingTeamEN.TeamCourse !=  null)
 {
 var strTeamCourse = objcc_ExcellenttTeachingTeamEN.TeamCourse.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTeamCourse, concc_ExcellenttTeachingTeam.TeamCourse); //团队课程
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_ExcellenttTeachingTeam.TeamCourse); //团队课程
 }
 }
 
 if (objcc_ExcellenttTeachingTeamEN.IsUpdated(concc_ExcellenttTeachingTeam.Memo))
 {
 if (objcc_ExcellenttTeachingTeamEN.Memo !=  null)
 {
 var strMemo = objcc_ExcellenttTeachingTeamEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, concc_ExcellenttTeachingTeam.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_ExcellenttTeachingTeam.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where ExcellenttTeachingTeamID = {0}", objcc_ExcellenttTeachingTeamEN.ExcellenttTeachingTeamID); 
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
 /// <param name = "lngExcellenttTeachingTeamID">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(long lngExcellenttTeachingTeamID) 
{
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_ExcellenttTeachingTeamDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 lngExcellenttTeachingTeamID,
};
 objSQL.ExecSP("cc_ExcellenttTeachingTeam_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "lngExcellenttTeachingTeamID">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(long lngExcellenttTeachingTeamID, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_ExcellenttTeachingTeamDA.GetSpecSQLObj();
//删除cc_ExcellenttTeachingTeam本表中与当前对象有关的记录
strSQL = strSQL + "Delete from cc_ExcellenttTeachingTeam where ExcellenttTeachingTeamID = " + ""+ lngExcellenttTeachingTeamID+"";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int Delcc_ExcellenttTeachingTeam(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_ExcellenttTeachingTeamDA.GetSpecSQLObj();
string strSQL;
string strKeyList;
if (lstKey.Count  == 0) return 0;
strKeyList = "";
for (int i = 0; i<lstKey.Count; i++)
{
if (i == 0) strKeyList = strKeyList + "" + lstKey[i].ToString() + "";
else strKeyList +=  "," + "" + lstKey[i].ToString() + "";
}
strSQL = "";
//删除cc_ExcellenttTeachingTeam本表中与当前对象有关的记录
strSQL = strSQL + "Delete from cc_ExcellenttTeachingTeam where ExcellenttTeachingTeamID in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "lngExcellenttTeachingTeamID">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(long lngExcellenttTeachingTeamID) 
{
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_ExcellenttTeachingTeamDA.GetSpecSQLObj();
//删除cc_ExcellenttTeachingTeam本表中与当前对象有关的记录
strSQL = strSQL + "Delete from cc_ExcellenttTeachingTeam where ExcellenttTeachingTeamID = " + ""+ lngExcellenttTeachingTeamID+"";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int Delcc_ExcellenttTeachingTeam(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clscc_ExcellenttTeachingTeamDA: Delcc_ExcellenttTeachingTeam)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_ExcellenttTeachingTeamDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from cc_ExcellenttTeachingTeam where " + strCondition ;
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
public bool Delcc_ExcellenttTeachingTeamWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clscc_ExcellenttTeachingTeamDA: Delcc_ExcellenttTeachingTeamWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_ExcellenttTeachingTeamDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from cc_ExcellenttTeachingTeam where " + strCondition ;
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
 /// <param name = "objcc_ExcellenttTeachingTeamENS">源对象</param>
 /// <param name = "objcc_ExcellenttTeachingTeamENT">目标对象</param>
public void CopyTo(clscc_ExcellenttTeachingTeamEN objcc_ExcellenttTeachingTeamENS, clscc_ExcellenttTeachingTeamEN objcc_ExcellenttTeachingTeamENT)
{
objcc_ExcellenttTeachingTeamENT.ExcellenttTeachingTeamID = objcc_ExcellenttTeachingTeamENS.ExcellenttTeachingTeamID; //优秀教学团队编号
objcc_ExcellenttTeachingTeamENT.ViewCount = objcc_ExcellenttTeachingTeamENS.ViewCount; //浏览量
objcc_ExcellenttTeachingTeamENT.CourseTypeID = objcc_ExcellenttTeachingTeamENS.CourseTypeID; //课程类型ID
objcc_ExcellenttTeachingTeamENT.IdXzCollege = objcc_ExcellenttTeachingTeamENS.IdXzCollege; //学院流水号
objcc_ExcellenttTeachingTeamENT.TeamName = objcc_ExcellenttTeachingTeamENS.TeamName; //团队名称
objcc_ExcellenttTeachingTeamENT.TeamLeader = objcc_ExcellenttTeachingTeamENS.TeamLeader; //团队带头人
objcc_ExcellenttTeachingTeamENT.Year = objcc_ExcellenttTeachingTeamENS.Year; //年份
objcc_ExcellenttTeachingTeamENT.RecommendCount = objcc_ExcellenttTeachingTeamENS.RecommendCount; //推荐次数
objcc_ExcellenttTeachingTeamENT.TeamIntroduction = objcc_ExcellenttTeachingTeamENS.TeamIntroduction; //团队简介
objcc_ExcellenttTeachingTeamENT.TeamMembers = objcc_ExcellenttTeachingTeamENS.TeamMembers; //团队成员
objcc_ExcellenttTeachingTeamENT.Teaching = objcc_ExcellenttTeachingTeamENS.Teaching; //教学工作
objcc_ExcellenttTeachingTeamENT.ResearchWorking = objcc_ExcellenttTeachingTeamENS.ResearchWorking; //科研工作
objcc_ExcellenttTeachingTeamENT.TeamPlanning = objcc_ExcellenttTeachingTeamENS.TeamPlanning; //团队规划
objcc_ExcellenttTeachingTeamENT.TeamCourse = objcc_ExcellenttTeachingTeamENS.TeamCourse; //团队课程
objcc_ExcellenttTeachingTeamENT.Memo = objcc_ExcellenttTeachingTeamENS.Memo; //备注
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clscc_ExcellenttTeachingTeamEN objcc_ExcellenttTeachingTeamEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objcc_ExcellenttTeachingTeamEN.ViewCount, concc_ExcellenttTeachingTeam.ViewCount);
clsCheckSql.CheckFieldNotNull(objcc_ExcellenttTeachingTeamEN.IdXzCollege, concc_ExcellenttTeachingTeam.IdXzCollege);
clsCheckSql.CheckFieldNotNull(objcc_ExcellenttTeachingTeamEN.TeamName, concc_ExcellenttTeachingTeam.TeamName);
//检查字段长度
clsCheckSql.CheckFieldLen(objcc_ExcellenttTeachingTeamEN.CourseTypeID, 4, concc_ExcellenttTeachingTeam.CourseTypeID);
clsCheckSql.CheckFieldLen(objcc_ExcellenttTeachingTeamEN.IdXzCollege, 4, concc_ExcellenttTeachingTeam.IdXzCollege);
clsCheckSql.CheckFieldLen(objcc_ExcellenttTeachingTeamEN.TeamName, 100, concc_ExcellenttTeachingTeam.TeamName);
clsCheckSql.CheckFieldLen(objcc_ExcellenttTeachingTeamEN.TeamLeader, 100, concc_ExcellenttTeachingTeam.TeamLeader);
clsCheckSql.CheckFieldLen(objcc_ExcellenttTeachingTeamEN.Year, 50, concc_ExcellenttTeachingTeam.Year);
clsCheckSql.CheckFieldLen(objcc_ExcellenttTeachingTeamEN.TeamIntroduction, 5000, concc_ExcellenttTeachingTeam.TeamIntroduction);
clsCheckSql.CheckFieldLen(objcc_ExcellenttTeachingTeamEN.TeamMembers, 1000, concc_ExcellenttTeachingTeam.TeamMembers);
clsCheckSql.CheckFieldLen(objcc_ExcellenttTeachingTeamEN.Teaching, 8000, concc_ExcellenttTeachingTeam.Teaching);
clsCheckSql.CheckFieldLen(objcc_ExcellenttTeachingTeamEN.ResearchWorking, 8000, concc_ExcellenttTeachingTeam.ResearchWorking);
clsCheckSql.CheckFieldLen(objcc_ExcellenttTeachingTeamEN.TeamPlanning, 8000, concc_ExcellenttTeachingTeam.TeamPlanning);
clsCheckSql.CheckFieldLen(objcc_ExcellenttTeachingTeamEN.TeamCourse, 8000, concc_ExcellenttTeachingTeam.TeamCourse);
clsCheckSql.CheckFieldLen(objcc_ExcellenttTeachingTeamEN.Memo, 1000, concc_ExcellenttTeachingTeam.Memo);
//检查字段外键固定长度
 objcc_ExcellenttTeachingTeamEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clscc_ExcellenttTeachingTeamEN objcc_ExcellenttTeachingTeamEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objcc_ExcellenttTeachingTeamEN.CourseTypeID, 4, concc_ExcellenttTeachingTeam.CourseTypeID);
clsCheckSql.CheckFieldLen(objcc_ExcellenttTeachingTeamEN.IdXzCollege, 4, concc_ExcellenttTeachingTeam.IdXzCollege);
clsCheckSql.CheckFieldLen(objcc_ExcellenttTeachingTeamEN.TeamName, 100, concc_ExcellenttTeachingTeam.TeamName);
clsCheckSql.CheckFieldLen(objcc_ExcellenttTeachingTeamEN.TeamLeader, 100, concc_ExcellenttTeachingTeam.TeamLeader);
clsCheckSql.CheckFieldLen(objcc_ExcellenttTeachingTeamEN.Year, 50, concc_ExcellenttTeachingTeam.Year);
clsCheckSql.CheckFieldLen(objcc_ExcellenttTeachingTeamEN.TeamIntroduction, 5000, concc_ExcellenttTeachingTeam.TeamIntroduction);
clsCheckSql.CheckFieldLen(objcc_ExcellenttTeachingTeamEN.TeamMembers, 1000, concc_ExcellenttTeachingTeam.TeamMembers);
clsCheckSql.CheckFieldLen(objcc_ExcellenttTeachingTeamEN.Teaching, 8000, concc_ExcellenttTeachingTeam.Teaching);
clsCheckSql.CheckFieldLen(objcc_ExcellenttTeachingTeamEN.ResearchWorking, 8000, concc_ExcellenttTeachingTeam.ResearchWorking);
clsCheckSql.CheckFieldLen(objcc_ExcellenttTeachingTeamEN.TeamPlanning, 8000, concc_ExcellenttTeachingTeam.TeamPlanning);
clsCheckSql.CheckFieldLen(objcc_ExcellenttTeachingTeamEN.TeamCourse, 8000, concc_ExcellenttTeachingTeam.TeamCourse);
clsCheckSql.CheckFieldLen(objcc_ExcellenttTeachingTeamEN.Memo, 1000, concc_ExcellenttTeachingTeam.Memo);
//检查外键字段长度
 objcc_ExcellenttTeachingTeamEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clscc_ExcellenttTeachingTeamEN objcc_ExcellenttTeachingTeamEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objcc_ExcellenttTeachingTeamEN.CourseTypeID, 4, concc_ExcellenttTeachingTeam.CourseTypeID);
clsCheckSql.CheckFieldLen(objcc_ExcellenttTeachingTeamEN.IdXzCollege, 4, concc_ExcellenttTeachingTeam.IdXzCollege);
clsCheckSql.CheckFieldLen(objcc_ExcellenttTeachingTeamEN.TeamName, 100, concc_ExcellenttTeachingTeam.TeamName);
clsCheckSql.CheckFieldLen(objcc_ExcellenttTeachingTeamEN.TeamLeader, 100, concc_ExcellenttTeachingTeam.TeamLeader);
clsCheckSql.CheckFieldLen(objcc_ExcellenttTeachingTeamEN.Year, 50, concc_ExcellenttTeachingTeam.Year);
clsCheckSql.CheckFieldLen(objcc_ExcellenttTeachingTeamEN.TeamIntroduction, 5000, concc_ExcellenttTeachingTeam.TeamIntroduction);
clsCheckSql.CheckFieldLen(objcc_ExcellenttTeachingTeamEN.TeamMembers, 1000, concc_ExcellenttTeachingTeam.TeamMembers);
clsCheckSql.CheckFieldLen(objcc_ExcellenttTeachingTeamEN.Teaching, 8000, concc_ExcellenttTeachingTeam.Teaching);
clsCheckSql.CheckFieldLen(objcc_ExcellenttTeachingTeamEN.ResearchWorking, 8000, concc_ExcellenttTeachingTeam.ResearchWorking);
clsCheckSql.CheckFieldLen(objcc_ExcellenttTeachingTeamEN.TeamPlanning, 8000, concc_ExcellenttTeachingTeam.TeamPlanning);
clsCheckSql.CheckFieldLen(objcc_ExcellenttTeachingTeamEN.TeamCourse, 8000, concc_ExcellenttTeachingTeam.TeamCourse);
clsCheckSql.CheckFieldLen(objcc_ExcellenttTeachingTeamEN.Memo, 1000, concc_ExcellenttTeachingTeam.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objcc_ExcellenttTeachingTeamEN.CourseTypeID, concc_ExcellenttTeachingTeam.CourseTypeID);
clsCheckSql.CheckSqlInjection4Field(objcc_ExcellenttTeachingTeamEN.IdXzCollege, concc_ExcellenttTeachingTeam.IdXzCollege);
clsCheckSql.CheckSqlInjection4Field(objcc_ExcellenttTeachingTeamEN.TeamName, concc_ExcellenttTeachingTeam.TeamName);
clsCheckSql.CheckSqlInjection4Field(objcc_ExcellenttTeachingTeamEN.TeamLeader, concc_ExcellenttTeachingTeam.TeamLeader);
clsCheckSql.CheckSqlInjection4Field(objcc_ExcellenttTeachingTeamEN.Year, concc_ExcellenttTeachingTeam.Year);
clsCheckSql.CheckSqlInjection4Field(objcc_ExcellenttTeachingTeamEN.TeamIntroduction, concc_ExcellenttTeachingTeam.TeamIntroduction);
clsCheckSql.CheckSqlInjection4Field(objcc_ExcellenttTeachingTeamEN.TeamMembers, concc_ExcellenttTeachingTeam.TeamMembers);
clsCheckSql.CheckSqlInjection4Field(objcc_ExcellenttTeachingTeamEN.Teaching, concc_ExcellenttTeachingTeam.Teaching);
clsCheckSql.CheckSqlInjection4Field(objcc_ExcellenttTeachingTeamEN.ResearchWorking, concc_ExcellenttTeachingTeam.ResearchWorking);
clsCheckSql.CheckSqlInjection4Field(objcc_ExcellenttTeachingTeamEN.TeamPlanning, concc_ExcellenttTeachingTeam.TeamPlanning);
clsCheckSql.CheckSqlInjection4Field(objcc_ExcellenttTeachingTeamEN.TeamCourse, concc_ExcellenttTeachingTeam.TeamCourse);
clsCheckSql.CheckSqlInjection4Field(objcc_ExcellenttTeachingTeamEN.Memo, concc_ExcellenttTeachingTeam.Memo);
//检查外键字段长度
 objcc_ExcellenttTeachingTeamEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--cc_ExcellenttTeachingTeam(优秀教学团队),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objcc_ExcellenttTeachingTeamEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clscc_ExcellenttTeachingTeamEN objcc_ExcellenttTeachingTeamEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and IdXzCollege = '{0}'", objcc_ExcellenttTeachingTeamEN.IdXzCollege);
 if (objcc_ExcellenttTeachingTeamEN.CourseTypeID == null)
{
 sbCondition.AppendFormat(" and CourseTypeID is null");
}
else
{
 sbCondition.AppendFormat(" and CourseTypeID = '{0}'", objcc_ExcellenttTeachingTeamEN.CourseTypeID);
}
return sbCondition.ToString();
}

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
 objSQL = clscc_ExcellenttTeachingTeamDA.GetSpecSQLObj();
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
 objSQL = clscc_ExcellenttTeachingTeamDA.GetSpecSQLObj();
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
 objSQL = clscc_ExcellenttTeachingTeamDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clscc_ExcellenttTeachingTeamEN._CurrTabName);
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
 objSQL = clscc_ExcellenttTeachingTeamDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clscc_ExcellenttTeachingTeamEN._CurrTabName, strCondition);
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
 objSQL = clscc_ExcellenttTeachingTeamDA.GetSpecSQLObj();
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
 objSQL = clscc_ExcellenttTeachingTeamDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}