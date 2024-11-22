
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvPubClassCase_Resource_RelDA
 表名:vPubClassCase_Resource_Rel(01120407)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:48:39
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
 /// v案例与资源关系(vPubClassCase_Resource_Rel)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvPubClassCase_Resource_RelDA : clsCommBase4DA
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
 return clsvPubClassCase_Resource_RelEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvPubClassCase_Resource_RelEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvPubClassCase_Resource_RelEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvPubClassCase_Resource_RelEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvPubClassCase_Resource_RelEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvPubClassCase_Resource_RelDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPubClassCase_Resource_RelDA.GetSpecSQLObj();
strSQL = "Select * from vPubClassCase_Resource_Rel where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vPubClassCase_Resource_Rel(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvPubClassCase_Resource_RelDA: GetDataTable_vPubClassCase_Resource_Rel)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPubClassCase_Resource_RelDA.GetSpecSQLObj();
strSQL = "Select * from vPubClassCase_Resource_Rel where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvPubClassCase_Resource_RelDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPubClassCase_Resource_RelDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvPubClassCase_Resource_RelDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPubClassCase_Resource_RelDA.GetSpecSQLObj();
strSQL = "Select * from vPubClassCase_Resource_Rel where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvPubClassCase_Resource_RelDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPubClassCase_Resource_RelDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvPubClassCase_Resource_RelDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPubClassCase_Resource_RelDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vPubClassCase_Resource_Rel where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vPubClassCase_Resource_Rel where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvPubClassCase_Resource_RelDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPubClassCase_Resource_RelDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vPubClassCase_Resource_Rel where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvPubClassCase_Resource_RelDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPubClassCase_Resource_RelDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vPubClassCase_Resource_Rel.* from vPubClassCase_Resource_Rel Left Join {1} on {2} where {3} and vPubClassCase_Resource_Rel.IdPubClassCaseResourceRel not in (Select top {5} vPubClassCase_Resource_Rel.IdPubClassCaseResourceRel from vPubClassCase_Resource_Rel Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vPubClassCase_Resource_Rel where {1} and IdPubClassCaseResourceRel not in (Select top {2} IdPubClassCaseResourceRel from vPubClassCase_Resource_Rel where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vPubClassCase_Resource_Rel where {1} and IdPubClassCaseResourceRel not in (Select top {3} IdPubClassCaseResourceRel from vPubClassCase_Resource_Rel where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvPubClassCase_Resource_RelDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPubClassCase_Resource_RelDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vPubClassCase_Resource_Rel.* from vPubClassCase_Resource_Rel Left Join {1} on {2} where {3} and vPubClassCase_Resource_Rel.IdPubClassCaseResourceRel not in (Select top {5} vPubClassCase_Resource_Rel.IdPubClassCaseResourceRel from vPubClassCase_Resource_Rel Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vPubClassCase_Resource_Rel where {1} and IdPubClassCaseResourceRel not in (Select top {2} IdPubClassCaseResourceRel from vPubClassCase_Resource_Rel where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vPubClassCase_Resource_Rel where {1} and IdPubClassCaseResourceRel not in (Select top {3} IdPubClassCaseResourceRel from vPubClassCase_Resource_Rel where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvPubClassCase_Resource_RelEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvPubClassCase_Resource_RelDA:GetObjLst)", objException.Message));
}
List<clsvPubClassCase_Resource_RelEN> arrObjLst = new List<clsvPubClassCase_Resource_RelEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPubClassCase_Resource_RelDA.GetSpecSQLObj();
strSQL = "Select * from vPubClassCase_Resource_Rel where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPubClassCase_Resource_RelEN objvPubClassCase_Resource_RelEN = new clsvPubClassCase_Resource_RelEN();
try
{
objvPubClassCase_Resource_RelEN.IdPubClassCaseResourceRel = TransNullToInt(objRow[convPubClassCase_Resource_Rel.IdPubClassCaseResourceRel].ToString().Trim()); //案例与资源关系表流水号
objvPubClassCase_Resource_RelEN.IdPubClassCase = objRow[convPubClassCase_Resource_Rel.IdPubClassCase].ToString().Trim(); //案例流水号
objvPubClassCase_Resource_RelEN.PubClassCaseID = objRow[convPubClassCase_Resource_Rel.PubClassCaseID].ToString().Trim(); //案例ID
objvPubClassCase_Resource_RelEN.PubClassCaseName = objRow[convPubClassCase_Resource_Rel.PubClassCaseName].ToString().Trim(); //案例课题名称
objvPubClassCase_Resource_RelEN.PubClassCaseExecutor = objRow[convPubClassCase_Resource_Rel.PubClassCaseExecutor] == DBNull.Value ? null : objRow[convPubClassCase_Resource_Rel.PubClassCaseExecutor].ToString().Trim(); //案例执教者
objvPubClassCase_Resource_RelEN.DisciplineName = objRow[convPubClassCase_Resource_Rel.DisciplineName].ToString().Trim(); //学科名称
objvPubClassCase_Resource_RelEN.PubCaseTypeName = objRow[convPubClassCase_Resource_Rel.PubCaseTypeName].ToString().Trim(); //公开课案例类型名称
objvPubClassCase_Resource_RelEN.StudyLevelName = objRow[convPubClassCase_Resource_Rel.StudyLevelName].ToString().Trim(); //学段名称
objvPubClassCase_Resource_RelEN.Introduction = objRow[convPubClassCase_Resource_Rel.Introduction] == DBNull.Value ? null : objRow[convPubClassCase_Resource_Rel.Introduction].ToString().Trim(); //简要介绍
objvPubClassCase_Resource_RelEN.IsDualVideo = TransNullToBool(objRow[convPubClassCase_Resource_Rel.IsDualVideo].ToString().Trim()); //是否双视频
objvPubClassCase_Resource_RelEN.RecommendedDegreeId = objRow[convPubClassCase_Resource_Rel.RecommendedDegreeId] == DBNull.Value ? null : objRow[convPubClassCase_Resource_Rel.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvPubClassCase_Resource_RelEN.RecommendedDegreeName = objRow[convPubClassCase_Resource_Rel.RecommendedDegreeName] == DBNull.Value ? null : objRow[convPubClassCase_Resource_Rel.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvPubClassCase_Resource_RelEN.BrowseCount4Case = objRow[convPubClassCase_Resource_Rel.BrowseCount4Case] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPubClassCase_Resource_Rel.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvPubClassCase_Resource_RelEN.IdResource = objRow[convPubClassCase_Resource_Rel.IdResource].ToString().Trim(); //资源流水号
objvPubClassCase_Resource_RelEN.ResourceID = objRow[convPubClassCase_Resource_Rel.ResourceID].ToString().Trim(); //资源ID
objvPubClassCase_Resource_RelEN.ResourceName = objRow[convPubClassCase_Resource_Rel.ResourceName] == DBNull.Value ? null : objRow[convPubClassCase_Resource_Rel.ResourceName].ToString().Trim(); //资源名称
objvPubClassCase_Resource_RelEN.IsExistFile = TransNullToBool(objRow[convPubClassCase_Resource_Rel.IsExistFile].ToString().Trim()); //是否存在文件
objvPubClassCase_Resource_RelEN.FileNewName = objRow[convPubClassCase_Resource_Rel.FileNewName] == DBNull.Value ? null : objRow[convPubClassCase_Resource_Rel.FileNewName].ToString().Trim(); //新文件名
objvPubClassCase_Resource_RelEN.FileOldName = objRow[convPubClassCase_Resource_Rel.FileOldName] == DBNull.Value ? null : objRow[convPubClassCase_Resource_Rel.FileOldName].ToString().Trim(); //旧文件名
objvPubClassCase_Resource_RelEN.IsMain = TransNullToBool(objRow[convPubClassCase_Resource_Rel.IsMain].ToString().Trim()); //是否主资源
objvPubClassCase_Resource_RelEN.IndexNO = objRow[convPubClassCase_Resource_Rel.IndexNO] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPubClassCase_Resource_Rel.IndexNO].ToString().Trim()); //序号
objvPubClassCase_Resource_RelEN.Memo = objRow[convPubClassCase_Resource_Rel.Memo] == DBNull.Value ? null : objRow[convPubClassCase_Resource_Rel.Memo].ToString().Trim(); //备注
objvPubClassCase_Resource_RelEN.IsVisible = TransNullToBool(objRow[convPubClassCase_Resource_Rel.IsVisible].ToString().Trim()); //是否显示
objvPubClassCase_Resource_RelEN.BrowseCount = objRow[convPubClassCase_Resource_Rel.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPubClassCase_Resource_Rel.BrowseCount].ToString().Trim()); //浏览次数
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvPubClassCase_Resource_RelDA: GetObjLst)", objException.Message));
}
objvPubClassCase_Resource_RelEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvPubClassCase_Resource_RelEN);
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
public List<clsvPubClassCase_Resource_RelEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvPubClassCase_Resource_RelDA:GetObjLstByTabName)", objException.Message));
}
List<clsvPubClassCase_Resource_RelEN> arrObjLst = new List<clsvPubClassCase_Resource_RelEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPubClassCase_Resource_RelDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPubClassCase_Resource_RelEN objvPubClassCase_Resource_RelEN = new clsvPubClassCase_Resource_RelEN();
try
{
objvPubClassCase_Resource_RelEN.IdPubClassCaseResourceRel = TransNullToInt(objRow[convPubClassCase_Resource_Rel.IdPubClassCaseResourceRel].ToString().Trim()); //案例与资源关系表流水号
objvPubClassCase_Resource_RelEN.IdPubClassCase = objRow[convPubClassCase_Resource_Rel.IdPubClassCase].ToString().Trim(); //案例流水号
objvPubClassCase_Resource_RelEN.PubClassCaseID = objRow[convPubClassCase_Resource_Rel.PubClassCaseID].ToString().Trim(); //案例ID
objvPubClassCase_Resource_RelEN.PubClassCaseName = objRow[convPubClassCase_Resource_Rel.PubClassCaseName].ToString().Trim(); //案例课题名称
objvPubClassCase_Resource_RelEN.PubClassCaseExecutor = objRow[convPubClassCase_Resource_Rel.PubClassCaseExecutor] == DBNull.Value ? null : objRow[convPubClassCase_Resource_Rel.PubClassCaseExecutor].ToString().Trim(); //案例执教者
objvPubClassCase_Resource_RelEN.DisciplineName = objRow[convPubClassCase_Resource_Rel.DisciplineName].ToString().Trim(); //学科名称
objvPubClassCase_Resource_RelEN.PubCaseTypeName = objRow[convPubClassCase_Resource_Rel.PubCaseTypeName].ToString().Trim(); //公开课案例类型名称
objvPubClassCase_Resource_RelEN.StudyLevelName = objRow[convPubClassCase_Resource_Rel.StudyLevelName].ToString().Trim(); //学段名称
objvPubClassCase_Resource_RelEN.Introduction = objRow[convPubClassCase_Resource_Rel.Introduction] == DBNull.Value ? null : objRow[convPubClassCase_Resource_Rel.Introduction].ToString().Trim(); //简要介绍
objvPubClassCase_Resource_RelEN.IsDualVideo = TransNullToBool(objRow[convPubClassCase_Resource_Rel.IsDualVideo].ToString().Trim()); //是否双视频
objvPubClassCase_Resource_RelEN.RecommendedDegreeId = objRow[convPubClassCase_Resource_Rel.RecommendedDegreeId] == DBNull.Value ? null : objRow[convPubClassCase_Resource_Rel.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvPubClassCase_Resource_RelEN.RecommendedDegreeName = objRow[convPubClassCase_Resource_Rel.RecommendedDegreeName] == DBNull.Value ? null : objRow[convPubClassCase_Resource_Rel.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvPubClassCase_Resource_RelEN.BrowseCount4Case = objRow[convPubClassCase_Resource_Rel.BrowseCount4Case] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPubClassCase_Resource_Rel.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvPubClassCase_Resource_RelEN.IdResource = objRow[convPubClassCase_Resource_Rel.IdResource].ToString().Trim(); //资源流水号
objvPubClassCase_Resource_RelEN.ResourceID = objRow[convPubClassCase_Resource_Rel.ResourceID].ToString().Trim(); //资源ID
objvPubClassCase_Resource_RelEN.ResourceName = objRow[convPubClassCase_Resource_Rel.ResourceName] == DBNull.Value ? null : objRow[convPubClassCase_Resource_Rel.ResourceName].ToString().Trim(); //资源名称
objvPubClassCase_Resource_RelEN.IsExistFile = TransNullToBool(objRow[convPubClassCase_Resource_Rel.IsExistFile].ToString().Trim()); //是否存在文件
objvPubClassCase_Resource_RelEN.FileNewName = objRow[convPubClassCase_Resource_Rel.FileNewName] == DBNull.Value ? null : objRow[convPubClassCase_Resource_Rel.FileNewName].ToString().Trim(); //新文件名
objvPubClassCase_Resource_RelEN.FileOldName = objRow[convPubClassCase_Resource_Rel.FileOldName] == DBNull.Value ? null : objRow[convPubClassCase_Resource_Rel.FileOldName].ToString().Trim(); //旧文件名
objvPubClassCase_Resource_RelEN.IsMain = TransNullToBool(objRow[convPubClassCase_Resource_Rel.IsMain].ToString().Trim()); //是否主资源
objvPubClassCase_Resource_RelEN.IndexNO = objRow[convPubClassCase_Resource_Rel.IndexNO] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPubClassCase_Resource_Rel.IndexNO].ToString().Trim()); //序号
objvPubClassCase_Resource_RelEN.Memo = objRow[convPubClassCase_Resource_Rel.Memo] == DBNull.Value ? null : objRow[convPubClassCase_Resource_Rel.Memo].ToString().Trim(); //备注
objvPubClassCase_Resource_RelEN.IsVisible = TransNullToBool(objRow[convPubClassCase_Resource_Rel.IsVisible].ToString().Trim()); //是否显示
objvPubClassCase_Resource_RelEN.BrowseCount = objRow[convPubClassCase_Resource_Rel.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPubClassCase_Resource_Rel.BrowseCount].ToString().Trim()); //浏览次数
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvPubClassCase_Resource_RelDA: GetObjLst)", objException.Message));
}
objvPubClassCase_Resource_RelEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvPubClassCase_Resource_RelEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvPubClassCase_Resource_RelEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvPubClassCase_Resource_Rel(ref clsvPubClassCase_Resource_RelEN objvPubClassCase_Resource_RelEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPubClassCase_Resource_RelDA.GetSpecSQLObj();
strSQL = "Select * from vPubClassCase_Resource_Rel where IdPubClassCaseResourceRel = " + ""+ objvPubClassCase_Resource_RelEN.IdPubClassCaseResourceRel+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvPubClassCase_Resource_RelEN.IdPubClassCaseResourceRel = TransNullToInt(objDT.Rows[0][convPubClassCase_Resource_Rel.IdPubClassCaseResourceRel].ToString().Trim()); //案例与资源关系表流水号(字段类型:bigint,字段长度:8,是否可空:False)
 objvPubClassCase_Resource_RelEN.IdPubClassCase = objDT.Rows[0][convPubClassCase_Resource_Rel.IdPubClassCase].ToString().Trim(); //案例流水号(字段类型:char,字段长度:8,是否可空:False)
 objvPubClassCase_Resource_RelEN.PubClassCaseID = objDT.Rows[0][convPubClassCase_Resource_Rel.PubClassCaseID].ToString().Trim(); //案例ID(字段类型:char,字段长度:8,是否可空:False)
 objvPubClassCase_Resource_RelEN.PubClassCaseName = objDT.Rows[0][convPubClassCase_Resource_Rel.PubClassCaseName].ToString().Trim(); //案例课题名称(字段类型:varchar,字段长度:200,是否可空:False)
 objvPubClassCase_Resource_RelEN.PubClassCaseExecutor = objDT.Rows[0][convPubClassCase_Resource_Rel.PubClassCaseExecutor].ToString().Trim(); //案例执教者(字段类型:varchar,字段长度:50,是否可空:True)
 objvPubClassCase_Resource_RelEN.DisciplineName = objDT.Rows[0][convPubClassCase_Resource_Rel.DisciplineName].ToString().Trim(); //学科名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvPubClassCase_Resource_RelEN.PubCaseTypeName = objDT.Rows[0][convPubClassCase_Resource_Rel.PubCaseTypeName].ToString().Trim(); //公开课案例类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvPubClassCase_Resource_RelEN.StudyLevelName = objDT.Rows[0][convPubClassCase_Resource_Rel.StudyLevelName].ToString().Trim(); //学段名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvPubClassCase_Resource_RelEN.Introduction = objDT.Rows[0][convPubClassCase_Resource_Rel.Introduction].ToString().Trim(); //简要介绍(字段类型:varchar,字段长度:4000,是否可空:True)
 objvPubClassCase_Resource_RelEN.IsDualVideo = TransNullToBool(objDT.Rows[0][convPubClassCase_Resource_Rel.IsDualVideo].ToString().Trim()); //是否双视频(字段类型:bit,字段长度:1,是否可空:False)
 objvPubClassCase_Resource_RelEN.RecommendedDegreeId = objDT.Rows[0][convPubClassCase_Resource_Rel.RecommendedDegreeId].ToString().Trim(); //推荐度Id(字段类型:char,字段长度:2,是否可空:False)
 objvPubClassCase_Resource_RelEN.RecommendedDegreeName = objDT.Rows[0][convPubClassCase_Resource_Rel.RecommendedDegreeName].ToString().Trim(); //推荐度名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvPubClassCase_Resource_RelEN.BrowseCount4Case = TransNullToInt(objDT.Rows[0][convPubClassCase_Resource_Rel.BrowseCount4Case].ToString().Trim()); //课例浏览次数(字段类型:int,字段长度:4,是否可空:True)
 objvPubClassCase_Resource_RelEN.IdResource = objDT.Rows[0][convPubClassCase_Resource_Rel.IdResource].ToString().Trim(); //资源流水号(字段类型:char,字段长度:8,是否可空:False)
 objvPubClassCase_Resource_RelEN.ResourceID = objDT.Rows[0][convPubClassCase_Resource_Rel.ResourceID].ToString().Trim(); //资源ID(字段类型:char,字段长度:8,是否可空:False)
 objvPubClassCase_Resource_RelEN.ResourceName = objDT.Rows[0][convPubClassCase_Resource_Rel.ResourceName].ToString().Trim(); //资源名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvPubClassCase_Resource_RelEN.IsExistFile = TransNullToBool(objDT.Rows[0][convPubClassCase_Resource_Rel.IsExistFile].ToString().Trim()); //是否存在文件(字段类型:bit,字段长度:1,是否可空:True)
 objvPubClassCase_Resource_RelEN.FileNewName = objDT.Rows[0][convPubClassCase_Resource_Rel.FileNewName].ToString().Trim(); //新文件名(字段类型:varchar,字段长度:530,是否可空:True)
 objvPubClassCase_Resource_RelEN.FileOldName = objDT.Rows[0][convPubClassCase_Resource_Rel.FileOldName].ToString().Trim(); //旧文件名(字段类型:varchar,字段长度:530,是否可空:True)
 objvPubClassCase_Resource_RelEN.IsMain = TransNullToBool(objDT.Rows[0][convPubClassCase_Resource_Rel.IsMain].ToString().Trim()); //是否主资源(字段类型:bit,字段长度:1,是否可空:True)
 objvPubClassCase_Resource_RelEN.IndexNO = TransNullToInt(objDT.Rows[0][convPubClassCase_Resource_Rel.IndexNO].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:True)
 objvPubClassCase_Resource_RelEN.Memo = objDT.Rows[0][convPubClassCase_Resource_Rel.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvPubClassCase_Resource_RelEN.IsVisible = TransNullToBool(objDT.Rows[0][convPubClassCase_Resource_Rel.IsVisible].ToString().Trim()); //是否显示(字段类型:bit,字段长度:1,是否可空:True)
 objvPubClassCase_Resource_RelEN.BrowseCount = TransNullToInt(objDT.Rows[0][convPubClassCase_Resource_Rel.BrowseCount].ToString().Trim()); //浏览次数(字段类型:int,字段长度:4,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvPubClassCase_Resource_RelDA: GetvPubClassCase_Resource_Rel)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngIdPubClassCaseResourceRel">表关键字</param>
 /// <returns>表对象</returns>
public clsvPubClassCase_Resource_RelEN GetObjByIdPubClassCaseResourceRel(long lngIdPubClassCaseResourceRel)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPubClassCase_Resource_RelDA.GetSpecSQLObj();
strSQL = "Select * from vPubClassCase_Resource_Rel where IdPubClassCaseResourceRel = " + ""+ lngIdPubClassCaseResourceRel+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvPubClassCase_Resource_RelEN objvPubClassCase_Resource_RelEN = new clsvPubClassCase_Resource_RelEN();
try
{
 objvPubClassCase_Resource_RelEN.IdPubClassCaseResourceRel = Int32.Parse(objRow[convPubClassCase_Resource_Rel.IdPubClassCaseResourceRel].ToString().Trim()); //案例与资源关系表流水号(字段类型:bigint,字段长度:8,是否可空:False)
 objvPubClassCase_Resource_RelEN.IdPubClassCase = objRow[convPubClassCase_Resource_Rel.IdPubClassCase].ToString().Trim(); //案例流水号(字段类型:char,字段长度:8,是否可空:False)
 objvPubClassCase_Resource_RelEN.PubClassCaseID = objRow[convPubClassCase_Resource_Rel.PubClassCaseID].ToString().Trim(); //案例ID(字段类型:char,字段长度:8,是否可空:False)
 objvPubClassCase_Resource_RelEN.PubClassCaseName = objRow[convPubClassCase_Resource_Rel.PubClassCaseName].ToString().Trim(); //案例课题名称(字段类型:varchar,字段长度:200,是否可空:False)
 objvPubClassCase_Resource_RelEN.PubClassCaseExecutor = objRow[convPubClassCase_Resource_Rel.PubClassCaseExecutor] == DBNull.Value ? null : objRow[convPubClassCase_Resource_Rel.PubClassCaseExecutor].ToString().Trim(); //案例执教者(字段类型:varchar,字段长度:50,是否可空:True)
 objvPubClassCase_Resource_RelEN.DisciplineName = objRow[convPubClassCase_Resource_Rel.DisciplineName].ToString().Trim(); //学科名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvPubClassCase_Resource_RelEN.PubCaseTypeName = objRow[convPubClassCase_Resource_Rel.PubCaseTypeName].ToString().Trim(); //公开课案例类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvPubClassCase_Resource_RelEN.StudyLevelName = objRow[convPubClassCase_Resource_Rel.StudyLevelName].ToString().Trim(); //学段名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvPubClassCase_Resource_RelEN.Introduction = objRow[convPubClassCase_Resource_Rel.Introduction] == DBNull.Value ? null : objRow[convPubClassCase_Resource_Rel.Introduction].ToString().Trim(); //简要介绍(字段类型:varchar,字段长度:4000,是否可空:True)
 objvPubClassCase_Resource_RelEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convPubClassCase_Resource_Rel.IsDualVideo].ToString().Trim()); //是否双视频(字段类型:bit,字段长度:1,是否可空:False)
 objvPubClassCase_Resource_RelEN.RecommendedDegreeId = objRow[convPubClassCase_Resource_Rel.RecommendedDegreeId] == DBNull.Value ? null : objRow[convPubClassCase_Resource_Rel.RecommendedDegreeId].ToString().Trim(); //推荐度Id(字段类型:char,字段长度:2,是否可空:False)
 objvPubClassCase_Resource_RelEN.RecommendedDegreeName = objRow[convPubClassCase_Resource_Rel.RecommendedDegreeName] == DBNull.Value ? null : objRow[convPubClassCase_Resource_Rel.RecommendedDegreeName].ToString().Trim(); //推荐度名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvPubClassCase_Resource_RelEN.BrowseCount4Case = objRow[convPubClassCase_Resource_Rel.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPubClassCase_Resource_Rel.BrowseCount4Case].ToString().Trim()); //课例浏览次数(字段类型:int,字段长度:4,是否可空:True)
 objvPubClassCase_Resource_RelEN.IdResource = objRow[convPubClassCase_Resource_Rel.IdResource].ToString().Trim(); //资源流水号(字段类型:char,字段长度:8,是否可空:False)
 objvPubClassCase_Resource_RelEN.ResourceID = objRow[convPubClassCase_Resource_Rel.ResourceID].ToString().Trim(); //资源ID(字段类型:char,字段长度:8,是否可空:False)
 objvPubClassCase_Resource_RelEN.ResourceName = objRow[convPubClassCase_Resource_Rel.ResourceName] == DBNull.Value ? null : objRow[convPubClassCase_Resource_Rel.ResourceName].ToString().Trim(); //资源名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvPubClassCase_Resource_RelEN.IsExistFile = clsEntityBase2.TransNullToBool_S(objRow[convPubClassCase_Resource_Rel.IsExistFile].ToString().Trim()); //是否存在文件(字段类型:bit,字段长度:1,是否可空:True)
 objvPubClassCase_Resource_RelEN.FileNewName = objRow[convPubClassCase_Resource_Rel.FileNewName] == DBNull.Value ? null : objRow[convPubClassCase_Resource_Rel.FileNewName].ToString().Trim(); //新文件名(字段类型:varchar,字段长度:530,是否可空:True)
 objvPubClassCase_Resource_RelEN.FileOldName = objRow[convPubClassCase_Resource_Rel.FileOldName] == DBNull.Value ? null : objRow[convPubClassCase_Resource_Rel.FileOldName].ToString().Trim(); //旧文件名(字段类型:varchar,字段长度:530,是否可空:True)
 objvPubClassCase_Resource_RelEN.IsMain = clsEntityBase2.TransNullToBool_S(objRow[convPubClassCase_Resource_Rel.IsMain].ToString().Trim()); //是否主资源(字段类型:bit,字段长度:1,是否可空:True)
 objvPubClassCase_Resource_RelEN.IndexNO = objRow[convPubClassCase_Resource_Rel.IndexNO] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPubClassCase_Resource_Rel.IndexNO].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:True)
 objvPubClassCase_Resource_RelEN.Memo = objRow[convPubClassCase_Resource_Rel.Memo] == DBNull.Value ? null : objRow[convPubClassCase_Resource_Rel.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvPubClassCase_Resource_RelEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convPubClassCase_Resource_Rel.IsVisible].ToString().Trim()); //是否显示(字段类型:bit,字段长度:1,是否可空:True)
 objvPubClassCase_Resource_RelEN.BrowseCount = objRow[convPubClassCase_Resource_Rel.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPubClassCase_Resource_Rel.BrowseCount].ToString().Trim()); //浏览次数(字段类型:int,字段长度:4,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvPubClassCase_Resource_RelDA: GetObjByIdPubClassCaseResourceRel)", objException.Message));
}
return objvPubClassCase_Resource_RelEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvPubClassCase_Resource_RelEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvPubClassCase_Resource_RelDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPubClassCase_Resource_RelDA.GetSpecSQLObj();
strSQL = "Select * from vPubClassCase_Resource_Rel where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvPubClassCase_Resource_RelEN objvPubClassCase_Resource_RelEN = new clsvPubClassCase_Resource_RelEN()
{
IdPubClassCaseResourceRel = TransNullToInt(objRow[convPubClassCase_Resource_Rel.IdPubClassCaseResourceRel].ToString().Trim()), //案例与资源关系表流水号
IdPubClassCase = objRow[convPubClassCase_Resource_Rel.IdPubClassCase].ToString().Trim(), //案例流水号
PubClassCaseID = objRow[convPubClassCase_Resource_Rel.PubClassCaseID].ToString().Trim(), //案例ID
PubClassCaseName = objRow[convPubClassCase_Resource_Rel.PubClassCaseName].ToString().Trim(), //案例课题名称
PubClassCaseExecutor = objRow[convPubClassCase_Resource_Rel.PubClassCaseExecutor] == DBNull.Value ? null : objRow[convPubClassCase_Resource_Rel.PubClassCaseExecutor].ToString().Trim(), //案例执教者
DisciplineName = objRow[convPubClassCase_Resource_Rel.DisciplineName].ToString().Trim(), //学科名称
PubCaseTypeName = objRow[convPubClassCase_Resource_Rel.PubCaseTypeName].ToString().Trim(), //公开课案例类型名称
StudyLevelName = objRow[convPubClassCase_Resource_Rel.StudyLevelName].ToString().Trim(), //学段名称
Introduction = objRow[convPubClassCase_Resource_Rel.Introduction] == DBNull.Value ? null : objRow[convPubClassCase_Resource_Rel.Introduction].ToString().Trim(), //简要介绍
IsDualVideo = TransNullToBool(objRow[convPubClassCase_Resource_Rel.IsDualVideo].ToString().Trim()), //是否双视频
RecommendedDegreeId = objRow[convPubClassCase_Resource_Rel.RecommendedDegreeId] == DBNull.Value ? null : objRow[convPubClassCase_Resource_Rel.RecommendedDegreeId].ToString().Trim(), //推荐度Id
RecommendedDegreeName = objRow[convPubClassCase_Resource_Rel.RecommendedDegreeName] == DBNull.Value ? null : objRow[convPubClassCase_Resource_Rel.RecommendedDegreeName].ToString().Trim(), //推荐度名称
BrowseCount4Case = objRow[convPubClassCase_Resource_Rel.BrowseCount4Case] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPubClassCase_Resource_Rel.BrowseCount4Case].ToString().Trim()), //课例浏览次数
IdResource = objRow[convPubClassCase_Resource_Rel.IdResource].ToString().Trim(), //资源流水号
ResourceID = objRow[convPubClassCase_Resource_Rel.ResourceID].ToString().Trim(), //资源ID
ResourceName = objRow[convPubClassCase_Resource_Rel.ResourceName] == DBNull.Value ? null : objRow[convPubClassCase_Resource_Rel.ResourceName].ToString().Trim(), //资源名称
IsExistFile = TransNullToBool(objRow[convPubClassCase_Resource_Rel.IsExistFile].ToString().Trim()), //是否存在文件
FileNewName = objRow[convPubClassCase_Resource_Rel.FileNewName] == DBNull.Value ? null : objRow[convPubClassCase_Resource_Rel.FileNewName].ToString().Trim(), //新文件名
FileOldName = objRow[convPubClassCase_Resource_Rel.FileOldName] == DBNull.Value ? null : objRow[convPubClassCase_Resource_Rel.FileOldName].ToString().Trim(), //旧文件名
IsMain = TransNullToBool(objRow[convPubClassCase_Resource_Rel.IsMain].ToString().Trim()), //是否主资源
IndexNO = objRow[convPubClassCase_Resource_Rel.IndexNO] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPubClassCase_Resource_Rel.IndexNO].ToString().Trim()), //序号
Memo = objRow[convPubClassCase_Resource_Rel.Memo] == DBNull.Value ? null : objRow[convPubClassCase_Resource_Rel.Memo].ToString().Trim(), //备注
IsVisible = TransNullToBool(objRow[convPubClassCase_Resource_Rel.IsVisible].ToString().Trim()), //是否显示
BrowseCount = objRow[convPubClassCase_Resource_Rel.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPubClassCase_Resource_Rel.BrowseCount].ToString().Trim()) //浏览次数
};
objvPubClassCase_Resource_RelEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvPubClassCase_Resource_RelEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvPubClassCase_Resource_RelDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvPubClassCase_Resource_RelEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvPubClassCase_Resource_RelEN objvPubClassCase_Resource_RelEN = new clsvPubClassCase_Resource_RelEN();
try
{
objvPubClassCase_Resource_RelEN.IdPubClassCaseResourceRel = TransNullToInt(objRow[convPubClassCase_Resource_Rel.IdPubClassCaseResourceRel].ToString().Trim()); //案例与资源关系表流水号
objvPubClassCase_Resource_RelEN.IdPubClassCase = objRow[convPubClassCase_Resource_Rel.IdPubClassCase].ToString().Trim(); //案例流水号
objvPubClassCase_Resource_RelEN.PubClassCaseID = objRow[convPubClassCase_Resource_Rel.PubClassCaseID].ToString().Trim(); //案例ID
objvPubClassCase_Resource_RelEN.PubClassCaseName = objRow[convPubClassCase_Resource_Rel.PubClassCaseName].ToString().Trim(); //案例课题名称
objvPubClassCase_Resource_RelEN.PubClassCaseExecutor = objRow[convPubClassCase_Resource_Rel.PubClassCaseExecutor] == DBNull.Value ? null : objRow[convPubClassCase_Resource_Rel.PubClassCaseExecutor].ToString().Trim(); //案例执教者
objvPubClassCase_Resource_RelEN.DisciplineName = objRow[convPubClassCase_Resource_Rel.DisciplineName].ToString().Trim(); //学科名称
objvPubClassCase_Resource_RelEN.PubCaseTypeName = objRow[convPubClassCase_Resource_Rel.PubCaseTypeName].ToString().Trim(); //公开课案例类型名称
objvPubClassCase_Resource_RelEN.StudyLevelName = objRow[convPubClassCase_Resource_Rel.StudyLevelName].ToString().Trim(); //学段名称
objvPubClassCase_Resource_RelEN.Introduction = objRow[convPubClassCase_Resource_Rel.Introduction] == DBNull.Value ? null : objRow[convPubClassCase_Resource_Rel.Introduction].ToString().Trim(); //简要介绍
objvPubClassCase_Resource_RelEN.IsDualVideo = TransNullToBool(objRow[convPubClassCase_Resource_Rel.IsDualVideo].ToString().Trim()); //是否双视频
objvPubClassCase_Resource_RelEN.RecommendedDegreeId = objRow[convPubClassCase_Resource_Rel.RecommendedDegreeId] == DBNull.Value ? null : objRow[convPubClassCase_Resource_Rel.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvPubClassCase_Resource_RelEN.RecommendedDegreeName = objRow[convPubClassCase_Resource_Rel.RecommendedDegreeName] == DBNull.Value ? null : objRow[convPubClassCase_Resource_Rel.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvPubClassCase_Resource_RelEN.BrowseCount4Case = objRow[convPubClassCase_Resource_Rel.BrowseCount4Case] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPubClassCase_Resource_Rel.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvPubClassCase_Resource_RelEN.IdResource = objRow[convPubClassCase_Resource_Rel.IdResource].ToString().Trim(); //资源流水号
objvPubClassCase_Resource_RelEN.ResourceID = objRow[convPubClassCase_Resource_Rel.ResourceID].ToString().Trim(); //资源ID
objvPubClassCase_Resource_RelEN.ResourceName = objRow[convPubClassCase_Resource_Rel.ResourceName] == DBNull.Value ? null : objRow[convPubClassCase_Resource_Rel.ResourceName].ToString().Trim(); //资源名称
objvPubClassCase_Resource_RelEN.IsExistFile = TransNullToBool(objRow[convPubClassCase_Resource_Rel.IsExistFile].ToString().Trim()); //是否存在文件
objvPubClassCase_Resource_RelEN.FileNewName = objRow[convPubClassCase_Resource_Rel.FileNewName] == DBNull.Value ? null : objRow[convPubClassCase_Resource_Rel.FileNewName].ToString().Trim(); //新文件名
objvPubClassCase_Resource_RelEN.FileOldName = objRow[convPubClassCase_Resource_Rel.FileOldName] == DBNull.Value ? null : objRow[convPubClassCase_Resource_Rel.FileOldName].ToString().Trim(); //旧文件名
objvPubClassCase_Resource_RelEN.IsMain = TransNullToBool(objRow[convPubClassCase_Resource_Rel.IsMain].ToString().Trim()); //是否主资源
objvPubClassCase_Resource_RelEN.IndexNO = objRow[convPubClassCase_Resource_Rel.IndexNO] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPubClassCase_Resource_Rel.IndexNO].ToString().Trim()); //序号
objvPubClassCase_Resource_RelEN.Memo = objRow[convPubClassCase_Resource_Rel.Memo] == DBNull.Value ? null : objRow[convPubClassCase_Resource_Rel.Memo].ToString().Trim(); //备注
objvPubClassCase_Resource_RelEN.IsVisible = TransNullToBool(objRow[convPubClassCase_Resource_Rel.IsVisible].ToString().Trim()); //是否显示
objvPubClassCase_Resource_RelEN.BrowseCount = objRow[convPubClassCase_Resource_Rel.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPubClassCase_Resource_Rel.BrowseCount].ToString().Trim()); //浏览次数
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvPubClassCase_Resource_RelDA: GetObjByDataRowvPubClassCase_Resource_Rel)", objException.Message));
}
objvPubClassCase_Resource_RelEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvPubClassCase_Resource_RelEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvPubClassCase_Resource_RelEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvPubClassCase_Resource_RelEN objvPubClassCase_Resource_RelEN = new clsvPubClassCase_Resource_RelEN();
try
{
objvPubClassCase_Resource_RelEN.IdPubClassCaseResourceRel = TransNullToInt(objRow[convPubClassCase_Resource_Rel.IdPubClassCaseResourceRel].ToString().Trim()); //案例与资源关系表流水号
objvPubClassCase_Resource_RelEN.IdPubClassCase = objRow[convPubClassCase_Resource_Rel.IdPubClassCase].ToString().Trim(); //案例流水号
objvPubClassCase_Resource_RelEN.PubClassCaseID = objRow[convPubClassCase_Resource_Rel.PubClassCaseID].ToString().Trim(); //案例ID
objvPubClassCase_Resource_RelEN.PubClassCaseName = objRow[convPubClassCase_Resource_Rel.PubClassCaseName].ToString().Trim(); //案例课题名称
objvPubClassCase_Resource_RelEN.PubClassCaseExecutor = objRow[convPubClassCase_Resource_Rel.PubClassCaseExecutor] == DBNull.Value ? null : objRow[convPubClassCase_Resource_Rel.PubClassCaseExecutor].ToString().Trim(); //案例执教者
objvPubClassCase_Resource_RelEN.DisciplineName = objRow[convPubClassCase_Resource_Rel.DisciplineName].ToString().Trim(); //学科名称
objvPubClassCase_Resource_RelEN.PubCaseTypeName = objRow[convPubClassCase_Resource_Rel.PubCaseTypeName].ToString().Trim(); //公开课案例类型名称
objvPubClassCase_Resource_RelEN.StudyLevelName = objRow[convPubClassCase_Resource_Rel.StudyLevelName].ToString().Trim(); //学段名称
objvPubClassCase_Resource_RelEN.Introduction = objRow[convPubClassCase_Resource_Rel.Introduction] == DBNull.Value ? null : objRow[convPubClassCase_Resource_Rel.Introduction].ToString().Trim(); //简要介绍
objvPubClassCase_Resource_RelEN.IsDualVideo = TransNullToBool(objRow[convPubClassCase_Resource_Rel.IsDualVideo].ToString().Trim()); //是否双视频
objvPubClassCase_Resource_RelEN.RecommendedDegreeId = objRow[convPubClassCase_Resource_Rel.RecommendedDegreeId] == DBNull.Value ? null : objRow[convPubClassCase_Resource_Rel.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvPubClassCase_Resource_RelEN.RecommendedDegreeName = objRow[convPubClassCase_Resource_Rel.RecommendedDegreeName] == DBNull.Value ? null : objRow[convPubClassCase_Resource_Rel.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvPubClassCase_Resource_RelEN.BrowseCount4Case = objRow[convPubClassCase_Resource_Rel.BrowseCount4Case] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPubClassCase_Resource_Rel.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvPubClassCase_Resource_RelEN.IdResource = objRow[convPubClassCase_Resource_Rel.IdResource].ToString().Trim(); //资源流水号
objvPubClassCase_Resource_RelEN.ResourceID = objRow[convPubClassCase_Resource_Rel.ResourceID].ToString().Trim(); //资源ID
objvPubClassCase_Resource_RelEN.ResourceName = objRow[convPubClassCase_Resource_Rel.ResourceName] == DBNull.Value ? null : objRow[convPubClassCase_Resource_Rel.ResourceName].ToString().Trim(); //资源名称
objvPubClassCase_Resource_RelEN.IsExistFile = TransNullToBool(objRow[convPubClassCase_Resource_Rel.IsExistFile].ToString().Trim()); //是否存在文件
objvPubClassCase_Resource_RelEN.FileNewName = objRow[convPubClassCase_Resource_Rel.FileNewName] == DBNull.Value ? null : objRow[convPubClassCase_Resource_Rel.FileNewName].ToString().Trim(); //新文件名
objvPubClassCase_Resource_RelEN.FileOldName = objRow[convPubClassCase_Resource_Rel.FileOldName] == DBNull.Value ? null : objRow[convPubClassCase_Resource_Rel.FileOldName].ToString().Trim(); //旧文件名
objvPubClassCase_Resource_RelEN.IsMain = TransNullToBool(objRow[convPubClassCase_Resource_Rel.IsMain].ToString().Trim()); //是否主资源
objvPubClassCase_Resource_RelEN.IndexNO = objRow[convPubClassCase_Resource_Rel.IndexNO] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPubClassCase_Resource_Rel.IndexNO].ToString().Trim()); //序号
objvPubClassCase_Resource_RelEN.Memo = objRow[convPubClassCase_Resource_Rel.Memo] == DBNull.Value ? null : objRow[convPubClassCase_Resource_Rel.Memo].ToString().Trim(); //备注
objvPubClassCase_Resource_RelEN.IsVisible = TransNullToBool(objRow[convPubClassCase_Resource_Rel.IsVisible].ToString().Trim()); //是否显示
objvPubClassCase_Resource_RelEN.BrowseCount = objRow[convPubClassCase_Resource_Rel.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPubClassCase_Resource_Rel.BrowseCount].ToString().Trim()); //浏览次数
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvPubClassCase_Resource_RelDA: GetObjByDataRow)", objException.Message));
}
objvPubClassCase_Resource_RelEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvPubClassCase_Resource_RelEN;
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
objSQL = clsvPubClassCase_Resource_RelDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvPubClassCase_Resource_RelEN._CurrTabName, convPubClassCase_Resource_Rel.IdPubClassCaseResourceRel, 8, "");
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
objSQL = clsvPubClassCase_Resource_RelDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvPubClassCase_Resource_RelEN._CurrTabName, convPubClassCase_Resource_Rel.IdPubClassCaseResourceRel, 8, strPrefix);
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
 objSQL = clsvPubClassCase_Resource_RelDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select IdPubClassCaseResourceRel from vPubClassCase_Resource_Rel where " + strCondition;
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
 objSQL = clsvPubClassCase_Resource_RelDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select IdPubClassCaseResourceRel from vPubClassCase_Resource_Rel where " + strCondition;
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
 /// <param name = "lngIdPubClassCaseResourceRel">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(long lngIdPubClassCaseResourceRel)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPubClassCase_Resource_RelDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vPubClassCase_Resource_Rel", "IdPubClassCaseResourceRel = " + ""+ lngIdPubClassCaseResourceRel+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvPubClassCase_Resource_RelDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPubClassCase_Resource_RelDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vPubClassCase_Resource_Rel", strCondition))
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
objSQL = clsvPubClassCase_Resource_RelDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vPubClassCase_Resource_Rel");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvPubClassCase_Resource_RelENS">源对象</param>
 /// <param name = "objvPubClassCase_Resource_RelENT">目标对象</param>
public void CopyTo(clsvPubClassCase_Resource_RelEN objvPubClassCase_Resource_RelENS, clsvPubClassCase_Resource_RelEN objvPubClassCase_Resource_RelENT)
{
objvPubClassCase_Resource_RelENT.IdPubClassCaseResourceRel = objvPubClassCase_Resource_RelENS.IdPubClassCaseResourceRel; //案例与资源关系表流水号
objvPubClassCase_Resource_RelENT.IdPubClassCase = objvPubClassCase_Resource_RelENS.IdPubClassCase; //案例流水号
objvPubClassCase_Resource_RelENT.PubClassCaseID = objvPubClassCase_Resource_RelENS.PubClassCaseID; //案例ID
objvPubClassCase_Resource_RelENT.PubClassCaseName = objvPubClassCase_Resource_RelENS.PubClassCaseName; //案例课题名称
objvPubClassCase_Resource_RelENT.PubClassCaseExecutor = objvPubClassCase_Resource_RelENS.PubClassCaseExecutor; //案例执教者
objvPubClassCase_Resource_RelENT.DisciplineName = objvPubClassCase_Resource_RelENS.DisciplineName; //学科名称
objvPubClassCase_Resource_RelENT.PubCaseTypeName = objvPubClassCase_Resource_RelENS.PubCaseTypeName; //公开课案例类型名称
objvPubClassCase_Resource_RelENT.StudyLevelName = objvPubClassCase_Resource_RelENS.StudyLevelName; //学段名称
objvPubClassCase_Resource_RelENT.Introduction = objvPubClassCase_Resource_RelENS.Introduction; //简要介绍
objvPubClassCase_Resource_RelENT.IsDualVideo = objvPubClassCase_Resource_RelENS.IsDualVideo; //是否双视频
objvPubClassCase_Resource_RelENT.RecommendedDegreeId = objvPubClassCase_Resource_RelENS.RecommendedDegreeId; //推荐度Id
objvPubClassCase_Resource_RelENT.RecommendedDegreeName = objvPubClassCase_Resource_RelENS.RecommendedDegreeName; //推荐度名称
objvPubClassCase_Resource_RelENT.BrowseCount4Case = objvPubClassCase_Resource_RelENS.BrowseCount4Case; //课例浏览次数
objvPubClassCase_Resource_RelENT.IdResource = objvPubClassCase_Resource_RelENS.IdResource; //资源流水号
objvPubClassCase_Resource_RelENT.ResourceID = objvPubClassCase_Resource_RelENS.ResourceID; //资源ID
objvPubClassCase_Resource_RelENT.ResourceName = objvPubClassCase_Resource_RelENS.ResourceName; //资源名称
objvPubClassCase_Resource_RelENT.IsExistFile = objvPubClassCase_Resource_RelENS.IsExistFile; //是否存在文件
objvPubClassCase_Resource_RelENT.FileNewName = objvPubClassCase_Resource_RelENS.FileNewName; //新文件名
objvPubClassCase_Resource_RelENT.FileOldName = objvPubClassCase_Resource_RelENS.FileOldName; //旧文件名
objvPubClassCase_Resource_RelENT.IsMain = objvPubClassCase_Resource_RelENS.IsMain; //是否主资源
objvPubClassCase_Resource_RelENT.IndexNO = objvPubClassCase_Resource_RelENS.IndexNO; //序号
objvPubClassCase_Resource_RelENT.Memo = objvPubClassCase_Resource_RelENS.Memo; //备注
objvPubClassCase_Resource_RelENT.IsVisible = objvPubClassCase_Resource_RelENS.IsVisible; //是否显示
objvPubClassCase_Resource_RelENT.BrowseCount = objvPubClassCase_Resource_RelENS.BrowseCount; //浏览次数
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvPubClassCase_Resource_RelEN objvPubClassCase_Resource_RelEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvPubClassCase_Resource_RelEN.IdPubClassCase, 8, convPubClassCase_Resource_Rel.IdPubClassCase);
clsCheckSql.CheckFieldLen(objvPubClassCase_Resource_RelEN.PubClassCaseID, 8, convPubClassCase_Resource_Rel.PubClassCaseID);
clsCheckSql.CheckFieldLen(objvPubClassCase_Resource_RelEN.PubClassCaseName, 200, convPubClassCase_Resource_Rel.PubClassCaseName);
clsCheckSql.CheckFieldLen(objvPubClassCase_Resource_RelEN.PubClassCaseExecutor, 50, convPubClassCase_Resource_Rel.PubClassCaseExecutor);
clsCheckSql.CheckFieldLen(objvPubClassCase_Resource_RelEN.DisciplineName, 50, convPubClassCase_Resource_Rel.DisciplineName);
clsCheckSql.CheckFieldLen(objvPubClassCase_Resource_RelEN.PubCaseTypeName, 50, convPubClassCase_Resource_Rel.PubCaseTypeName);
clsCheckSql.CheckFieldLen(objvPubClassCase_Resource_RelEN.StudyLevelName, 50, convPubClassCase_Resource_Rel.StudyLevelName);
clsCheckSql.CheckFieldLen(objvPubClassCase_Resource_RelEN.Introduction, 4000, convPubClassCase_Resource_Rel.Introduction);
clsCheckSql.CheckFieldLen(objvPubClassCase_Resource_RelEN.RecommendedDegreeId, 2, convPubClassCase_Resource_Rel.RecommendedDegreeId);
clsCheckSql.CheckFieldLen(objvPubClassCase_Resource_RelEN.RecommendedDegreeName, 30, convPubClassCase_Resource_Rel.RecommendedDegreeName);
clsCheckSql.CheckFieldLen(objvPubClassCase_Resource_RelEN.IdResource, 8, convPubClassCase_Resource_Rel.IdResource);
clsCheckSql.CheckFieldLen(objvPubClassCase_Resource_RelEN.ResourceID, 8, convPubClassCase_Resource_Rel.ResourceID);
clsCheckSql.CheckFieldLen(objvPubClassCase_Resource_RelEN.ResourceName, 100, convPubClassCase_Resource_Rel.ResourceName);
clsCheckSql.CheckFieldLen(objvPubClassCase_Resource_RelEN.FileNewName, 530, convPubClassCase_Resource_Rel.FileNewName);
clsCheckSql.CheckFieldLen(objvPubClassCase_Resource_RelEN.FileOldName, 530, convPubClassCase_Resource_Rel.FileOldName);
clsCheckSql.CheckFieldLen(objvPubClassCase_Resource_RelEN.Memo, 1000, convPubClassCase_Resource_Rel.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvPubClassCase_Resource_RelEN.IdPubClassCase, convPubClassCase_Resource_Rel.IdPubClassCase);
clsCheckSql.CheckSqlInjection4Field(objvPubClassCase_Resource_RelEN.PubClassCaseID, convPubClassCase_Resource_Rel.PubClassCaseID);
clsCheckSql.CheckSqlInjection4Field(objvPubClassCase_Resource_RelEN.PubClassCaseName, convPubClassCase_Resource_Rel.PubClassCaseName);
clsCheckSql.CheckSqlInjection4Field(objvPubClassCase_Resource_RelEN.PubClassCaseExecutor, convPubClassCase_Resource_Rel.PubClassCaseExecutor);
clsCheckSql.CheckSqlInjection4Field(objvPubClassCase_Resource_RelEN.DisciplineName, convPubClassCase_Resource_Rel.DisciplineName);
clsCheckSql.CheckSqlInjection4Field(objvPubClassCase_Resource_RelEN.PubCaseTypeName, convPubClassCase_Resource_Rel.PubCaseTypeName);
clsCheckSql.CheckSqlInjection4Field(objvPubClassCase_Resource_RelEN.StudyLevelName, convPubClassCase_Resource_Rel.StudyLevelName);
clsCheckSql.CheckSqlInjection4Field(objvPubClassCase_Resource_RelEN.Introduction, convPubClassCase_Resource_Rel.Introduction);
clsCheckSql.CheckSqlInjection4Field(objvPubClassCase_Resource_RelEN.RecommendedDegreeId, convPubClassCase_Resource_Rel.RecommendedDegreeId);
clsCheckSql.CheckSqlInjection4Field(objvPubClassCase_Resource_RelEN.RecommendedDegreeName, convPubClassCase_Resource_Rel.RecommendedDegreeName);
clsCheckSql.CheckSqlInjection4Field(objvPubClassCase_Resource_RelEN.IdResource, convPubClassCase_Resource_Rel.IdResource);
clsCheckSql.CheckSqlInjection4Field(objvPubClassCase_Resource_RelEN.ResourceID, convPubClassCase_Resource_Rel.ResourceID);
clsCheckSql.CheckSqlInjection4Field(objvPubClassCase_Resource_RelEN.ResourceName, convPubClassCase_Resource_Rel.ResourceName);
clsCheckSql.CheckSqlInjection4Field(objvPubClassCase_Resource_RelEN.FileNewName, convPubClassCase_Resource_Rel.FileNewName);
clsCheckSql.CheckSqlInjection4Field(objvPubClassCase_Resource_RelEN.FileOldName, convPubClassCase_Resource_Rel.FileOldName);
clsCheckSql.CheckSqlInjection4Field(objvPubClassCase_Resource_RelEN.Memo, convPubClassCase_Resource_Rel.Memo);
//检查外键字段长度
 objvPubClassCase_Resource_RelEN._IsCheckProperty = true;
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
 objSQL = clsvPubClassCase_Resource_RelDA.GetSpecSQLObj();
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
 objSQL = clsvPubClassCase_Resource_RelDA.GetSpecSQLObj();
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
 objSQL = clsvPubClassCase_Resource_RelDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvPubClassCase_Resource_RelEN._CurrTabName);
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
 objSQL = clsvPubClassCase_Resource_RelDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvPubClassCase_Resource_RelEN._CurrTabName, strCondition);
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
 objSQL = clsvPubClassCase_Resource_RelDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}