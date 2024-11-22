
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsCaseCourseKnowledgeRelaDA
 表名:CaseCourseKnowledgeRela(01120392)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:19:01
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:课程学习(CourseLearning)
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
 /// 案例知识点关系(CaseCourseKnowledgeRela)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsCaseCourseKnowledgeRelaDA : clsCommBase4DA
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
 return clsCaseCourseKnowledgeRelaEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsCaseCourseKnowledgeRelaEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsCaseCourseKnowledgeRelaEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsCaseCourseKnowledgeRelaEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsCaseCourseKnowledgeRelaEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsCaseCourseKnowledgeRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCaseCourseKnowledgeRelaDA.GetSpecSQLObj();
strSQL = "Select * from CaseCourseKnowledgeRela where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_CaseCourseKnowledgeRela(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsCaseCourseKnowledgeRelaDA: GetDataTable_CaseCourseKnowledgeRela)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCaseCourseKnowledgeRelaDA.GetSpecSQLObj();
strSQL = "Select * from CaseCourseKnowledgeRela where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsCaseCourseKnowledgeRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCaseCourseKnowledgeRelaDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsCaseCourseKnowledgeRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCaseCourseKnowledgeRelaDA.GetSpecSQLObj();
strSQL = "Select * from CaseCourseKnowledgeRela where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsCaseCourseKnowledgeRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCaseCourseKnowledgeRelaDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsCaseCourseKnowledgeRelaDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCaseCourseKnowledgeRelaDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from CaseCourseKnowledgeRela where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from CaseCourseKnowledgeRela where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsCaseCourseKnowledgeRelaDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCaseCourseKnowledgeRelaDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from CaseCourseKnowledgeRela where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsCaseCourseKnowledgeRelaDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCaseCourseKnowledgeRelaDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} CaseCourseKnowledgeRela.* from CaseCourseKnowledgeRela Left Join {1} on {2} where {3} and CaseCourseKnowledgeRela.IdCaseCourseKnowledgeRela not in (Select top {5} CaseCourseKnowledgeRela.IdCaseCourseKnowledgeRela from CaseCourseKnowledgeRela Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from CaseCourseKnowledgeRela where {1} and IdCaseCourseKnowledgeRela not in (Select top {2} IdCaseCourseKnowledgeRela from CaseCourseKnowledgeRela where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from CaseCourseKnowledgeRela where {1} and IdCaseCourseKnowledgeRela not in (Select top {3} IdCaseCourseKnowledgeRela from CaseCourseKnowledgeRela where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsCaseCourseKnowledgeRelaDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCaseCourseKnowledgeRelaDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} CaseCourseKnowledgeRela.* from CaseCourseKnowledgeRela Left Join {1} on {2} where {3} and CaseCourseKnowledgeRela.IdCaseCourseKnowledgeRela not in (Select top {5} CaseCourseKnowledgeRela.IdCaseCourseKnowledgeRela from CaseCourseKnowledgeRela Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from CaseCourseKnowledgeRela where {1} and IdCaseCourseKnowledgeRela not in (Select top {2} IdCaseCourseKnowledgeRela from CaseCourseKnowledgeRela where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from CaseCourseKnowledgeRela where {1} and IdCaseCourseKnowledgeRela not in (Select top {3} IdCaseCourseKnowledgeRela from CaseCourseKnowledgeRela where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsCaseCourseKnowledgeRelaEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsCaseCourseKnowledgeRelaDA:GetObjLst)", objException.Message));
}
List<clsCaseCourseKnowledgeRelaEN> arrObjLst = new List<clsCaseCourseKnowledgeRelaEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCaseCourseKnowledgeRelaDA.GetSpecSQLObj();
strSQL = "Select * from CaseCourseKnowledgeRela where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCaseCourseKnowledgeRelaEN objCaseCourseKnowledgeRelaEN = new clsCaseCourseKnowledgeRelaEN();
try
{
objCaseCourseKnowledgeRelaEN.IdCaseCourseKnowledgeRela = TransNullToInt(objRow[conCaseCourseKnowledgeRela.IdCaseCourseKnowledgeRela].ToString().Trim()); //案例知识点关系流水号
objCaseCourseKnowledgeRelaEN.FuncModuleId = objRow[conCaseCourseKnowledgeRela.FuncModuleId].ToString().Trim(); //功能模块Id
objCaseCourseKnowledgeRelaEN.CaseId = objRow[conCaseCourseKnowledgeRela.CaseId].ToString().Trim(); //案例Id
objCaseCourseKnowledgeRelaEN.CaseName = objRow[conCaseCourseKnowledgeRela.CaseName].ToString().Trim(); //案例名称
objCaseCourseKnowledgeRelaEN.OwnerId = objRow[conCaseCourseKnowledgeRela.OwnerId] == DBNull.Value ? null : objRow[conCaseCourseKnowledgeRela.OwnerId].ToString().Trim(); //拥有者Id
objCaseCourseKnowledgeRelaEN.CourseKnowledgeId = objRow[conCaseCourseKnowledgeRela.CourseKnowledgeId] == DBNull.Value ? null : objRow[conCaseCourseKnowledgeRela.CourseKnowledgeId].ToString().Trim(); //知识点Id
objCaseCourseKnowledgeRelaEN.IdCaseCourseKnowledgeRelaType = objRow[conCaseCourseKnowledgeRela.IdCaseCourseKnowledgeRelaType].ToString().Trim(); //案例知识点关系类型流水号
objCaseCourseKnowledgeRelaEN.RelationsDegree = TransNullToInt(objRow[conCaseCourseKnowledgeRela.RelationsDegree].ToString().Trim()); //关系度
objCaseCourseKnowledgeRelaEN.BrowseCount = TransNullToInt(objRow[conCaseCourseKnowledgeRela.BrowseCount].ToString().Trim()); //浏览次数
objCaseCourseKnowledgeRelaEN.OrderNum = objRow[conCaseCourseKnowledgeRela.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conCaseCourseKnowledgeRela.OrderNum].ToString().Trim()); //序号
objCaseCourseKnowledgeRelaEN.UpdDate = objRow[conCaseCourseKnowledgeRela.UpdDate] == DBNull.Value ? null : objRow[conCaseCourseKnowledgeRela.UpdDate].ToString().Trim(); //修改日期
objCaseCourseKnowledgeRelaEN.UpdUserId = objRow[conCaseCourseKnowledgeRela.UpdUserId] == DBNull.Value ? null : objRow[conCaseCourseKnowledgeRela.UpdUserId].ToString().Trim(); //修改用户Id
objCaseCourseKnowledgeRelaEN.Memo = objRow[conCaseCourseKnowledgeRela.Memo] == DBNull.Value ? null : objRow[conCaseCourseKnowledgeRela.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsCaseCourseKnowledgeRelaDA: GetObjLst)", objException.Message));
}
objCaseCourseKnowledgeRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objCaseCourseKnowledgeRelaEN);
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
public List<clsCaseCourseKnowledgeRelaEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsCaseCourseKnowledgeRelaDA:GetObjLstByTabName)", objException.Message));
}
List<clsCaseCourseKnowledgeRelaEN> arrObjLst = new List<clsCaseCourseKnowledgeRelaEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCaseCourseKnowledgeRelaDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCaseCourseKnowledgeRelaEN objCaseCourseKnowledgeRelaEN = new clsCaseCourseKnowledgeRelaEN();
try
{
objCaseCourseKnowledgeRelaEN.IdCaseCourseKnowledgeRela = TransNullToInt(objRow[conCaseCourseKnowledgeRela.IdCaseCourseKnowledgeRela].ToString().Trim()); //案例知识点关系流水号
objCaseCourseKnowledgeRelaEN.FuncModuleId = objRow[conCaseCourseKnowledgeRela.FuncModuleId].ToString().Trim(); //功能模块Id
objCaseCourseKnowledgeRelaEN.CaseId = objRow[conCaseCourseKnowledgeRela.CaseId].ToString().Trim(); //案例Id
objCaseCourseKnowledgeRelaEN.CaseName = objRow[conCaseCourseKnowledgeRela.CaseName].ToString().Trim(); //案例名称
objCaseCourseKnowledgeRelaEN.OwnerId = objRow[conCaseCourseKnowledgeRela.OwnerId] == DBNull.Value ? null : objRow[conCaseCourseKnowledgeRela.OwnerId].ToString().Trim(); //拥有者Id
objCaseCourseKnowledgeRelaEN.CourseKnowledgeId = objRow[conCaseCourseKnowledgeRela.CourseKnowledgeId] == DBNull.Value ? null : objRow[conCaseCourseKnowledgeRela.CourseKnowledgeId].ToString().Trim(); //知识点Id
objCaseCourseKnowledgeRelaEN.IdCaseCourseKnowledgeRelaType = objRow[conCaseCourseKnowledgeRela.IdCaseCourseKnowledgeRelaType].ToString().Trim(); //案例知识点关系类型流水号
objCaseCourseKnowledgeRelaEN.RelationsDegree = TransNullToInt(objRow[conCaseCourseKnowledgeRela.RelationsDegree].ToString().Trim()); //关系度
objCaseCourseKnowledgeRelaEN.BrowseCount = TransNullToInt(objRow[conCaseCourseKnowledgeRela.BrowseCount].ToString().Trim()); //浏览次数
objCaseCourseKnowledgeRelaEN.OrderNum = objRow[conCaseCourseKnowledgeRela.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conCaseCourseKnowledgeRela.OrderNum].ToString().Trim()); //序号
objCaseCourseKnowledgeRelaEN.UpdDate = objRow[conCaseCourseKnowledgeRela.UpdDate] == DBNull.Value ? null : objRow[conCaseCourseKnowledgeRela.UpdDate].ToString().Trim(); //修改日期
objCaseCourseKnowledgeRelaEN.UpdUserId = objRow[conCaseCourseKnowledgeRela.UpdUserId] == DBNull.Value ? null : objRow[conCaseCourseKnowledgeRela.UpdUserId].ToString().Trim(); //修改用户Id
objCaseCourseKnowledgeRelaEN.Memo = objRow[conCaseCourseKnowledgeRela.Memo] == DBNull.Value ? null : objRow[conCaseCourseKnowledgeRela.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsCaseCourseKnowledgeRelaDA: GetObjLst)", objException.Message));
}
objCaseCourseKnowledgeRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objCaseCourseKnowledgeRelaEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objCaseCourseKnowledgeRelaEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetCaseCourseKnowledgeRela(ref clsCaseCourseKnowledgeRelaEN objCaseCourseKnowledgeRelaEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCaseCourseKnowledgeRelaDA.GetSpecSQLObj();
strSQL = "Select * from CaseCourseKnowledgeRela where IdCaseCourseKnowledgeRela = " + ""+ objCaseCourseKnowledgeRelaEN.IdCaseCourseKnowledgeRela+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objCaseCourseKnowledgeRelaEN.IdCaseCourseKnowledgeRela = TransNullToInt(objDT.Rows[0][conCaseCourseKnowledgeRela.IdCaseCourseKnowledgeRela].ToString().Trim()); //案例知识点关系流水号(字段类型:bigint,字段长度:8,是否可空:False)
 objCaseCourseKnowledgeRelaEN.FuncModuleId = objDT.Rows[0][conCaseCourseKnowledgeRela.FuncModuleId].ToString().Trim(); //功能模块Id(字段类型:char,字段长度:4,是否可空:True)
 objCaseCourseKnowledgeRelaEN.CaseId = objDT.Rows[0][conCaseCourseKnowledgeRela.CaseId].ToString().Trim(); //案例Id(字段类型:char,字段长度:8,是否可空:True)
 objCaseCourseKnowledgeRelaEN.CaseName = objDT.Rows[0][conCaseCourseKnowledgeRela.CaseName].ToString().Trim(); //案例名称(字段类型:varchar,字段长度:100,是否可空:True)
 objCaseCourseKnowledgeRelaEN.OwnerId = objDT.Rows[0][conCaseCourseKnowledgeRela.OwnerId].ToString().Trim(); //拥有者Id(字段类型:varchar,字段长度:20,是否可空:False)
 objCaseCourseKnowledgeRelaEN.CourseKnowledgeId = objDT.Rows[0][conCaseCourseKnowledgeRela.CourseKnowledgeId].ToString().Trim(); //知识点Id(字段类型:char,字段长度:8,是否可空:False)
 objCaseCourseKnowledgeRelaEN.IdCaseCourseKnowledgeRelaType = objDT.Rows[0][conCaseCourseKnowledgeRela.IdCaseCourseKnowledgeRelaType].ToString().Trim(); //案例知识点关系类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objCaseCourseKnowledgeRelaEN.RelationsDegree = TransNullToInt(objDT.Rows[0][conCaseCourseKnowledgeRela.RelationsDegree].ToString().Trim()); //关系度(字段类型:int,字段长度:4,是否可空:False)
 objCaseCourseKnowledgeRelaEN.BrowseCount = TransNullToInt(objDT.Rows[0][conCaseCourseKnowledgeRela.BrowseCount].ToString().Trim()); //浏览次数(字段类型:int,字段长度:4,是否可空:True)
 objCaseCourseKnowledgeRelaEN.OrderNum = TransNullToInt(objDT.Rows[0][conCaseCourseKnowledgeRela.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:True)
 objCaseCourseKnowledgeRelaEN.UpdDate = objDT.Rows[0][conCaseCourseKnowledgeRela.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objCaseCourseKnowledgeRelaEN.UpdUserId = objDT.Rows[0][conCaseCourseKnowledgeRela.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:True)
 objCaseCourseKnowledgeRelaEN.Memo = objDT.Rows[0][conCaseCourseKnowledgeRela.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsCaseCourseKnowledgeRelaDA: GetCaseCourseKnowledgeRela)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngIdCaseCourseKnowledgeRela">表关键字</param>
 /// <returns>表对象</returns>
public clsCaseCourseKnowledgeRelaEN GetObjByIdCaseCourseKnowledgeRela(long lngIdCaseCourseKnowledgeRela)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCaseCourseKnowledgeRelaDA.GetSpecSQLObj();
strSQL = "Select * from CaseCourseKnowledgeRela where IdCaseCourseKnowledgeRela = " + ""+ lngIdCaseCourseKnowledgeRela+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsCaseCourseKnowledgeRelaEN objCaseCourseKnowledgeRelaEN = new clsCaseCourseKnowledgeRelaEN();
try
{
 objCaseCourseKnowledgeRelaEN.IdCaseCourseKnowledgeRela = Int32.Parse(objRow[conCaseCourseKnowledgeRela.IdCaseCourseKnowledgeRela].ToString().Trim()); //案例知识点关系流水号(字段类型:bigint,字段长度:8,是否可空:False)
 objCaseCourseKnowledgeRelaEN.FuncModuleId = objRow[conCaseCourseKnowledgeRela.FuncModuleId].ToString().Trim(); //功能模块Id(字段类型:char,字段长度:4,是否可空:True)
 objCaseCourseKnowledgeRelaEN.CaseId = objRow[conCaseCourseKnowledgeRela.CaseId].ToString().Trim(); //案例Id(字段类型:char,字段长度:8,是否可空:True)
 objCaseCourseKnowledgeRelaEN.CaseName = objRow[conCaseCourseKnowledgeRela.CaseName].ToString().Trim(); //案例名称(字段类型:varchar,字段长度:100,是否可空:True)
 objCaseCourseKnowledgeRelaEN.OwnerId = objRow[conCaseCourseKnowledgeRela.OwnerId] == DBNull.Value ? null : objRow[conCaseCourseKnowledgeRela.OwnerId].ToString().Trim(); //拥有者Id(字段类型:varchar,字段长度:20,是否可空:False)
 objCaseCourseKnowledgeRelaEN.CourseKnowledgeId = objRow[conCaseCourseKnowledgeRela.CourseKnowledgeId] == DBNull.Value ? null : objRow[conCaseCourseKnowledgeRela.CourseKnowledgeId].ToString().Trim(); //知识点Id(字段类型:char,字段长度:8,是否可空:False)
 objCaseCourseKnowledgeRelaEN.IdCaseCourseKnowledgeRelaType = objRow[conCaseCourseKnowledgeRela.IdCaseCourseKnowledgeRelaType].ToString().Trim(); //案例知识点关系类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objCaseCourseKnowledgeRelaEN.RelationsDegree = Int32.Parse(objRow[conCaseCourseKnowledgeRela.RelationsDegree].ToString().Trim()); //关系度(字段类型:int,字段长度:4,是否可空:False)
 objCaseCourseKnowledgeRelaEN.BrowseCount = Int32.Parse(objRow[conCaseCourseKnowledgeRela.BrowseCount].ToString().Trim()); //浏览次数(字段类型:int,字段长度:4,是否可空:True)
 objCaseCourseKnowledgeRelaEN.OrderNum = objRow[conCaseCourseKnowledgeRela.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCaseCourseKnowledgeRela.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:True)
 objCaseCourseKnowledgeRelaEN.UpdDate = objRow[conCaseCourseKnowledgeRela.UpdDate] == DBNull.Value ? null : objRow[conCaseCourseKnowledgeRela.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objCaseCourseKnowledgeRelaEN.UpdUserId = objRow[conCaseCourseKnowledgeRela.UpdUserId] == DBNull.Value ? null : objRow[conCaseCourseKnowledgeRela.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:True)
 objCaseCourseKnowledgeRelaEN.Memo = objRow[conCaseCourseKnowledgeRela.Memo] == DBNull.Value ? null : objRow[conCaseCourseKnowledgeRela.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsCaseCourseKnowledgeRelaDA: GetObjByIdCaseCourseKnowledgeRela)", objException.Message));
}
return objCaseCourseKnowledgeRelaEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsCaseCourseKnowledgeRelaEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsCaseCourseKnowledgeRelaDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCaseCourseKnowledgeRelaDA.GetSpecSQLObj();
strSQL = "Select * from CaseCourseKnowledgeRela where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsCaseCourseKnowledgeRelaEN objCaseCourseKnowledgeRelaEN = new clsCaseCourseKnowledgeRelaEN()
{
IdCaseCourseKnowledgeRela = TransNullToInt(objRow[conCaseCourseKnowledgeRela.IdCaseCourseKnowledgeRela].ToString().Trim()), //案例知识点关系流水号
FuncModuleId = objRow[conCaseCourseKnowledgeRela.FuncModuleId].ToString().Trim(), //功能模块Id
CaseId = objRow[conCaseCourseKnowledgeRela.CaseId].ToString().Trim(), //案例Id
CaseName = objRow[conCaseCourseKnowledgeRela.CaseName].ToString().Trim(), //案例名称
OwnerId = objRow[conCaseCourseKnowledgeRela.OwnerId] == DBNull.Value ? null : objRow[conCaseCourseKnowledgeRela.OwnerId].ToString().Trim(), //拥有者Id
CourseKnowledgeId = objRow[conCaseCourseKnowledgeRela.CourseKnowledgeId] == DBNull.Value ? null : objRow[conCaseCourseKnowledgeRela.CourseKnowledgeId].ToString().Trim(), //知识点Id
IdCaseCourseKnowledgeRelaType = objRow[conCaseCourseKnowledgeRela.IdCaseCourseKnowledgeRelaType].ToString().Trim(), //案例知识点关系类型流水号
RelationsDegree = TransNullToInt(objRow[conCaseCourseKnowledgeRela.RelationsDegree].ToString().Trim()), //关系度
BrowseCount = TransNullToInt(objRow[conCaseCourseKnowledgeRela.BrowseCount].ToString().Trim()), //浏览次数
OrderNum = objRow[conCaseCourseKnowledgeRela.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conCaseCourseKnowledgeRela.OrderNum].ToString().Trim()), //序号
UpdDate = objRow[conCaseCourseKnowledgeRela.UpdDate] == DBNull.Value ? null : objRow[conCaseCourseKnowledgeRela.UpdDate].ToString().Trim(), //修改日期
UpdUserId = objRow[conCaseCourseKnowledgeRela.UpdUserId] == DBNull.Value ? null : objRow[conCaseCourseKnowledgeRela.UpdUserId].ToString().Trim(), //修改用户Id
Memo = objRow[conCaseCourseKnowledgeRela.Memo] == DBNull.Value ? null : objRow[conCaseCourseKnowledgeRela.Memo].ToString().Trim() //备注
};
objCaseCourseKnowledgeRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objCaseCourseKnowledgeRelaEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsCaseCourseKnowledgeRelaDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsCaseCourseKnowledgeRelaEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsCaseCourseKnowledgeRelaEN objCaseCourseKnowledgeRelaEN = new clsCaseCourseKnowledgeRelaEN();
try
{
objCaseCourseKnowledgeRelaEN.IdCaseCourseKnowledgeRela = TransNullToInt(objRow[conCaseCourseKnowledgeRela.IdCaseCourseKnowledgeRela].ToString().Trim()); //案例知识点关系流水号
objCaseCourseKnowledgeRelaEN.FuncModuleId = objRow[conCaseCourseKnowledgeRela.FuncModuleId].ToString().Trim(); //功能模块Id
objCaseCourseKnowledgeRelaEN.CaseId = objRow[conCaseCourseKnowledgeRela.CaseId].ToString().Trim(); //案例Id
objCaseCourseKnowledgeRelaEN.CaseName = objRow[conCaseCourseKnowledgeRela.CaseName].ToString().Trim(); //案例名称
objCaseCourseKnowledgeRelaEN.OwnerId = objRow[conCaseCourseKnowledgeRela.OwnerId] == DBNull.Value ? null : objRow[conCaseCourseKnowledgeRela.OwnerId].ToString().Trim(); //拥有者Id
objCaseCourseKnowledgeRelaEN.CourseKnowledgeId = objRow[conCaseCourseKnowledgeRela.CourseKnowledgeId] == DBNull.Value ? null : objRow[conCaseCourseKnowledgeRela.CourseKnowledgeId].ToString().Trim(); //知识点Id
objCaseCourseKnowledgeRelaEN.IdCaseCourseKnowledgeRelaType = objRow[conCaseCourseKnowledgeRela.IdCaseCourseKnowledgeRelaType].ToString().Trim(); //案例知识点关系类型流水号
objCaseCourseKnowledgeRelaEN.RelationsDegree = TransNullToInt(objRow[conCaseCourseKnowledgeRela.RelationsDegree].ToString().Trim()); //关系度
objCaseCourseKnowledgeRelaEN.BrowseCount = TransNullToInt(objRow[conCaseCourseKnowledgeRela.BrowseCount].ToString().Trim()); //浏览次数
objCaseCourseKnowledgeRelaEN.OrderNum = objRow[conCaseCourseKnowledgeRela.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conCaseCourseKnowledgeRela.OrderNum].ToString().Trim()); //序号
objCaseCourseKnowledgeRelaEN.UpdDate = objRow[conCaseCourseKnowledgeRela.UpdDate] == DBNull.Value ? null : objRow[conCaseCourseKnowledgeRela.UpdDate].ToString().Trim(); //修改日期
objCaseCourseKnowledgeRelaEN.UpdUserId = objRow[conCaseCourseKnowledgeRela.UpdUserId] == DBNull.Value ? null : objRow[conCaseCourseKnowledgeRela.UpdUserId].ToString().Trim(); //修改用户Id
objCaseCourseKnowledgeRelaEN.Memo = objRow[conCaseCourseKnowledgeRela.Memo] == DBNull.Value ? null : objRow[conCaseCourseKnowledgeRela.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsCaseCourseKnowledgeRelaDA: GetObjByDataRowCaseCourseKnowledgeRela)", objException.Message));
}
objCaseCourseKnowledgeRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objCaseCourseKnowledgeRelaEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsCaseCourseKnowledgeRelaEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsCaseCourseKnowledgeRelaEN objCaseCourseKnowledgeRelaEN = new clsCaseCourseKnowledgeRelaEN();
try
{
objCaseCourseKnowledgeRelaEN.IdCaseCourseKnowledgeRela = TransNullToInt(objRow[conCaseCourseKnowledgeRela.IdCaseCourseKnowledgeRela].ToString().Trim()); //案例知识点关系流水号
objCaseCourseKnowledgeRelaEN.FuncModuleId = objRow[conCaseCourseKnowledgeRela.FuncModuleId].ToString().Trim(); //功能模块Id
objCaseCourseKnowledgeRelaEN.CaseId = objRow[conCaseCourseKnowledgeRela.CaseId].ToString().Trim(); //案例Id
objCaseCourseKnowledgeRelaEN.CaseName = objRow[conCaseCourseKnowledgeRela.CaseName].ToString().Trim(); //案例名称
objCaseCourseKnowledgeRelaEN.OwnerId = objRow[conCaseCourseKnowledgeRela.OwnerId] == DBNull.Value ? null : objRow[conCaseCourseKnowledgeRela.OwnerId].ToString().Trim(); //拥有者Id
objCaseCourseKnowledgeRelaEN.CourseKnowledgeId = objRow[conCaseCourseKnowledgeRela.CourseKnowledgeId] == DBNull.Value ? null : objRow[conCaseCourseKnowledgeRela.CourseKnowledgeId].ToString().Trim(); //知识点Id
objCaseCourseKnowledgeRelaEN.IdCaseCourseKnowledgeRelaType = objRow[conCaseCourseKnowledgeRela.IdCaseCourseKnowledgeRelaType].ToString().Trim(); //案例知识点关系类型流水号
objCaseCourseKnowledgeRelaEN.RelationsDegree = TransNullToInt(objRow[conCaseCourseKnowledgeRela.RelationsDegree].ToString().Trim()); //关系度
objCaseCourseKnowledgeRelaEN.BrowseCount = TransNullToInt(objRow[conCaseCourseKnowledgeRela.BrowseCount].ToString().Trim()); //浏览次数
objCaseCourseKnowledgeRelaEN.OrderNum = objRow[conCaseCourseKnowledgeRela.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conCaseCourseKnowledgeRela.OrderNum].ToString().Trim()); //序号
objCaseCourseKnowledgeRelaEN.UpdDate = objRow[conCaseCourseKnowledgeRela.UpdDate] == DBNull.Value ? null : objRow[conCaseCourseKnowledgeRela.UpdDate].ToString().Trim(); //修改日期
objCaseCourseKnowledgeRelaEN.UpdUserId = objRow[conCaseCourseKnowledgeRela.UpdUserId] == DBNull.Value ? null : objRow[conCaseCourseKnowledgeRela.UpdUserId].ToString().Trim(); //修改用户Id
objCaseCourseKnowledgeRelaEN.Memo = objRow[conCaseCourseKnowledgeRela.Memo] == DBNull.Value ? null : objRow[conCaseCourseKnowledgeRela.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsCaseCourseKnowledgeRelaDA: GetObjByDataRow)", objException.Message));
}
objCaseCourseKnowledgeRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objCaseCourseKnowledgeRelaEN;
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
objSQL = clsCaseCourseKnowledgeRelaDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsCaseCourseKnowledgeRelaEN._CurrTabName, conCaseCourseKnowledgeRela.IdCaseCourseKnowledgeRela, 8, "");
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
objSQL = clsCaseCourseKnowledgeRelaDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsCaseCourseKnowledgeRelaEN._CurrTabName, conCaseCourseKnowledgeRela.IdCaseCourseKnowledgeRela, 8, strPrefix);
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
 objSQL = clsCaseCourseKnowledgeRelaDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select IdCaseCourseKnowledgeRela from CaseCourseKnowledgeRela where " + strCondition;
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
 objSQL = clsCaseCourseKnowledgeRelaDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select IdCaseCourseKnowledgeRela from CaseCourseKnowledgeRela where " + strCondition;
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
 /// <param name = "lngIdCaseCourseKnowledgeRela">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(long lngIdCaseCourseKnowledgeRela)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCaseCourseKnowledgeRelaDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("CaseCourseKnowledgeRela", "IdCaseCourseKnowledgeRela = " + ""+ lngIdCaseCourseKnowledgeRela+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsCaseCourseKnowledgeRelaDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCaseCourseKnowledgeRelaDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("CaseCourseKnowledgeRela", strCondition))
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
objSQL = clsCaseCourseKnowledgeRelaDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("CaseCourseKnowledgeRela");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsCaseCourseKnowledgeRelaEN objCaseCourseKnowledgeRelaEN)
 {
 objCaseCourseKnowledgeRelaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCaseCourseKnowledgeRelaEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objCaseCourseKnowledgeRelaEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCaseCourseKnowledgeRelaDA.GetSpecSQLObj();
strSQL = "Select * from CaseCourseKnowledgeRela where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "CaseCourseKnowledgeRela");
objRow = objDS.Tables["CaseCourseKnowledgeRela"].NewRow();
objRow[conCaseCourseKnowledgeRela.FuncModuleId] = objCaseCourseKnowledgeRelaEN.FuncModuleId; //功能模块Id
objRow[conCaseCourseKnowledgeRela.CaseId] = objCaseCourseKnowledgeRelaEN.CaseId; //案例Id
objRow[conCaseCourseKnowledgeRela.CaseName] = objCaseCourseKnowledgeRelaEN.CaseName; //案例名称
 if (objCaseCourseKnowledgeRelaEN.OwnerId !=  "")
 {
objRow[conCaseCourseKnowledgeRela.OwnerId] = objCaseCourseKnowledgeRelaEN.OwnerId; //拥有者Id
 }
 if (objCaseCourseKnowledgeRelaEN.CourseKnowledgeId !=  "")
 {
objRow[conCaseCourseKnowledgeRela.CourseKnowledgeId] = objCaseCourseKnowledgeRelaEN.CourseKnowledgeId; //知识点Id
 }
objRow[conCaseCourseKnowledgeRela.IdCaseCourseKnowledgeRelaType] = objCaseCourseKnowledgeRelaEN.IdCaseCourseKnowledgeRelaType; //案例知识点关系类型流水号
objRow[conCaseCourseKnowledgeRela.RelationsDegree] = objCaseCourseKnowledgeRelaEN.RelationsDegree; //关系度
objRow[conCaseCourseKnowledgeRela.BrowseCount] = objCaseCourseKnowledgeRelaEN.BrowseCount; //浏览次数
objRow[conCaseCourseKnowledgeRela.OrderNum] = objCaseCourseKnowledgeRelaEN.OrderNum; //序号
 if (objCaseCourseKnowledgeRelaEN.UpdDate !=  "")
 {
objRow[conCaseCourseKnowledgeRela.UpdDate] = objCaseCourseKnowledgeRelaEN.UpdDate; //修改日期
 }
 if (objCaseCourseKnowledgeRelaEN.UpdUserId !=  "")
 {
objRow[conCaseCourseKnowledgeRela.UpdUserId] = objCaseCourseKnowledgeRelaEN.UpdUserId; //修改用户Id
 }
 if (objCaseCourseKnowledgeRelaEN.Memo !=  "")
 {
objRow[conCaseCourseKnowledgeRela.Memo] = objCaseCourseKnowledgeRelaEN.Memo; //备注
 }
objDS.Tables[clsCaseCourseKnowledgeRelaEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsCaseCourseKnowledgeRelaEN._CurrTabName);
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
 /// <param name = "objCaseCourseKnowledgeRelaEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsCaseCourseKnowledgeRelaEN objCaseCourseKnowledgeRelaEN)
{
 objCaseCourseKnowledgeRelaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCaseCourseKnowledgeRelaEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objCaseCourseKnowledgeRelaEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objCaseCourseKnowledgeRelaEN.FuncModuleId !=  null)
 {
 arrFieldListForInsert.Add(conCaseCourseKnowledgeRela.FuncModuleId);
 var strFuncModuleId = objCaseCourseKnowledgeRelaEN.FuncModuleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncModuleId + "'");
 }
 
 if (objCaseCourseKnowledgeRelaEN.CaseId !=  null)
 {
 arrFieldListForInsert.Add(conCaseCourseKnowledgeRela.CaseId);
 var strCaseId = objCaseCourseKnowledgeRelaEN.CaseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCaseId + "'");
 }
 
 if (objCaseCourseKnowledgeRelaEN.CaseName !=  null)
 {
 arrFieldListForInsert.Add(conCaseCourseKnowledgeRela.CaseName);
 var strCaseName = objCaseCourseKnowledgeRelaEN.CaseName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCaseName + "'");
 }
 
 if (objCaseCourseKnowledgeRelaEN.OwnerId !=  null)
 {
 arrFieldListForInsert.Add(conCaseCourseKnowledgeRela.OwnerId);
 var strOwnerId = objCaseCourseKnowledgeRelaEN.OwnerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strOwnerId + "'");
 }
 
 if (objCaseCourseKnowledgeRelaEN.CourseKnowledgeId !=  null)
 {
 arrFieldListForInsert.Add(conCaseCourseKnowledgeRela.CourseKnowledgeId);
 var strCourseKnowledgeId = objCaseCourseKnowledgeRelaEN.CourseKnowledgeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseKnowledgeId + "'");
 }
 
 if (objCaseCourseKnowledgeRelaEN.IdCaseCourseKnowledgeRelaType !=  null)
 {
 arrFieldListForInsert.Add(conCaseCourseKnowledgeRela.IdCaseCourseKnowledgeRelaType);
 var strIdCaseCourseKnowledgeRelaType = objCaseCourseKnowledgeRelaEN.IdCaseCourseKnowledgeRelaType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCaseCourseKnowledgeRelaType + "'");
 }
 
 arrFieldListForInsert.Add(conCaseCourseKnowledgeRela.RelationsDegree);
 arrValueListForInsert.Add(objCaseCourseKnowledgeRelaEN.RelationsDegree.ToString());
 
 arrFieldListForInsert.Add(conCaseCourseKnowledgeRela.BrowseCount);
 arrValueListForInsert.Add(objCaseCourseKnowledgeRelaEN.BrowseCount.ToString());
 
 if (objCaseCourseKnowledgeRelaEN.OrderNum !=  null)
 {
 arrFieldListForInsert.Add(conCaseCourseKnowledgeRela.OrderNum);
 arrValueListForInsert.Add(objCaseCourseKnowledgeRelaEN.OrderNum.ToString());
 }
 
 if (objCaseCourseKnowledgeRelaEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conCaseCourseKnowledgeRela.UpdDate);
 var strUpdDate = objCaseCourseKnowledgeRelaEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objCaseCourseKnowledgeRelaEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(conCaseCourseKnowledgeRela.UpdUserId);
 var strUpdUserId = objCaseCourseKnowledgeRelaEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objCaseCourseKnowledgeRelaEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conCaseCourseKnowledgeRela.Memo);
 var strMemo = objCaseCourseKnowledgeRelaEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into CaseCourseKnowledgeRela");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCaseCourseKnowledgeRelaDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objCaseCourseKnowledgeRelaEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsCaseCourseKnowledgeRelaEN objCaseCourseKnowledgeRelaEN)
{
 objCaseCourseKnowledgeRelaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCaseCourseKnowledgeRelaEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objCaseCourseKnowledgeRelaEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objCaseCourseKnowledgeRelaEN.FuncModuleId !=  null)
 {
 arrFieldListForInsert.Add(conCaseCourseKnowledgeRela.FuncModuleId);
 var strFuncModuleId = objCaseCourseKnowledgeRelaEN.FuncModuleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncModuleId + "'");
 }
 
 if (objCaseCourseKnowledgeRelaEN.CaseId !=  null)
 {
 arrFieldListForInsert.Add(conCaseCourseKnowledgeRela.CaseId);
 var strCaseId = objCaseCourseKnowledgeRelaEN.CaseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCaseId + "'");
 }
 
 if (objCaseCourseKnowledgeRelaEN.CaseName !=  null)
 {
 arrFieldListForInsert.Add(conCaseCourseKnowledgeRela.CaseName);
 var strCaseName = objCaseCourseKnowledgeRelaEN.CaseName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCaseName + "'");
 }
 
 if (objCaseCourseKnowledgeRelaEN.OwnerId !=  null)
 {
 arrFieldListForInsert.Add(conCaseCourseKnowledgeRela.OwnerId);
 var strOwnerId = objCaseCourseKnowledgeRelaEN.OwnerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strOwnerId + "'");
 }
 
 if (objCaseCourseKnowledgeRelaEN.CourseKnowledgeId !=  null)
 {
 arrFieldListForInsert.Add(conCaseCourseKnowledgeRela.CourseKnowledgeId);
 var strCourseKnowledgeId = objCaseCourseKnowledgeRelaEN.CourseKnowledgeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseKnowledgeId + "'");
 }
 
 if (objCaseCourseKnowledgeRelaEN.IdCaseCourseKnowledgeRelaType !=  null)
 {
 arrFieldListForInsert.Add(conCaseCourseKnowledgeRela.IdCaseCourseKnowledgeRelaType);
 var strIdCaseCourseKnowledgeRelaType = objCaseCourseKnowledgeRelaEN.IdCaseCourseKnowledgeRelaType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCaseCourseKnowledgeRelaType + "'");
 }
 
 arrFieldListForInsert.Add(conCaseCourseKnowledgeRela.RelationsDegree);
 arrValueListForInsert.Add(objCaseCourseKnowledgeRelaEN.RelationsDegree.ToString());
 
 arrFieldListForInsert.Add(conCaseCourseKnowledgeRela.BrowseCount);
 arrValueListForInsert.Add(objCaseCourseKnowledgeRelaEN.BrowseCount.ToString());
 
 if (objCaseCourseKnowledgeRelaEN.OrderNum !=  null)
 {
 arrFieldListForInsert.Add(conCaseCourseKnowledgeRela.OrderNum);
 arrValueListForInsert.Add(objCaseCourseKnowledgeRelaEN.OrderNum.ToString());
 }
 
 if (objCaseCourseKnowledgeRelaEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conCaseCourseKnowledgeRela.UpdDate);
 var strUpdDate = objCaseCourseKnowledgeRelaEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objCaseCourseKnowledgeRelaEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(conCaseCourseKnowledgeRela.UpdUserId);
 var strUpdUserId = objCaseCourseKnowledgeRelaEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objCaseCourseKnowledgeRelaEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conCaseCourseKnowledgeRela.Memo);
 var strMemo = objCaseCourseKnowledgeRelaEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into CaseCourseKnowledgeRela");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCaseCourseKnowledgeRelaDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString()).Rows[0][0].ToString();
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objCaseCourseKnowledgeRelaEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsCaseCourseKnowledgeRelaEN objCaseCourseKnowledgeRelaEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objCaseCourseKnowledgeRelaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCaseCourseKnowledgeRelaEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objCaseCourseKnowledgeRelaEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objCaseCourseKnowledgeRelaEN.FuncModuleId !=  null)
 {
 arrFieldListForInsert.Add(conCaseCourseKnowledgeRela.FuncModuleId);
 var strFuncModuleId = objCaseCourseKnowledgeRelaEN.FuncModuleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncModuleId + "'");
 }
 
 if (objCaseCourseKnowledgeRelaEN.CaseId !=  null)
 {
 arrFieldListForInsert.Add(conCaseCourseKnowledgeRela.CaseId);
 var strCaseId = objCaseCourseKnowledgeRelaEN.CaseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCaseId + "'");
 }
 
 if (objCaseCourseKnowledgeRelaEN.CaseName !=  null)
 {
 arrFieldListForInsert.Add(conCaseCourseKnowledgeRela.CaseName);
 var strCaseName = objCaseCourseKnowledgeRelaEN.CaseName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCaseName + "'");
 }
 
 if (objCaseCourseKnowledgeRelaEN.OwnerId !=  null)
 {
 arrFieldListForInsert.Add(conCaseCourseKnowledgeRela.OwnerId);
 var strOwnerId = objCaseCourseKnowledgeRelaEN.OwnerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strOwnerId + "'");
 }
 
 if (objCaseCourseKnowledgeRelaEN.CourseKnowledgeId !=  null)
 {
 arrFieldListForInsert.Add(conCaseCourseKnowledgeRela.CourseKnowledgeId);
 var strCourseKnowledgeId = objCaseCourseKnowledgeRelaEN.CourseKnowledgeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseKnowledgeId + "'");
 }
 
 if (objCaseCourseKnowledgeRelaEN.IdCaseCourseKnowledgeRelaType !=  null)
 {
 arrFieldListForInsert.Add(conCaseCourseKnowledgeRela.IdCaseCourseKnowledgeRelaType);
 var strIdCaseCourseKnowledgeRelaType = objCaseCourseKnowledgeRelaEN.IdCaseCourseKnowledgeRelaType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCaseCourseKnowledgeRelaType + "'");
 }
 
 arrFieldListForInsert.Add(conCaseCourseKnowledgeRela.RelationsDegree);
 arrValueListForInsert.Add(objCaseCourseKnowledgeRelaEN.RelationsDegree.ToString());
 
 arrFieldListForInsert.Add(conCaseCourseKnowledgeRela.BrowseCount);
 arrValueListForInsert.Add(objCaseCourseKnowledgeRelaEN.BrowseCount.ToString());
 
 if (objCaseCourseKnowledgeRelaEN.OrderNum !=  null)
 {
 arrFieldListForInsert.Add(conCaseCourseKnowledgeRela.OrderNum);
 arrValueListForInsert.Add(objCaseCourseKnowledgeRelaEN.OrderNum.ToString());
 }
 
 if (objCaseCourseKnowledgeRelaEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conCaseCourseKnowledgeRela.UpdDate);
 var strUpdDate = objCaseCourseKnowledgeRelaEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objCaseCourseKnowledgeRelaEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(conCaseCourseKnowledgeRela.UpdUserId);
 var strUpdUserId = objCaseCourseKnowledgeRelaEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objCaseCourseKnowledgeRelaEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conCaseCourseKnowledgeRela.Memo);
 var strMemo = objCaseCourseKnowledgeRelaEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into CaseCourseKnowledgeRela");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCaseCourseKnowledgeRelaDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString(), objSqlConnection, objSqlTransaction).Rows[0][0].ToString();
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objCaseCourseKnowledgeRelaEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsCaseCourseKnowledgeRelaEN objCaseCourseKnowledgeRelaEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objCaseCourseKnowledgeRelaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCaseCourseKnowledgeRelaEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objCaseCourseKnowledgeRelaEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objCaseCourseKnowledgeRelaEN.FuncModuleId !=  null)
 {
 arrFieldListForInsert.Add(conCaseCourseKnowledgeRela.FuncModuleId);
 var strFuncModuleId = objCaseCourseKnowledgeRelaEN.FuncModuleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncModuleId + "'");
 }
 
 if (objCaseCourseKnowledgeRelaEN.CaseId !=  null)
 {
 arrFieldListForInsert.Add(conCaseCourseKnowledgeRela.CaseId);
 var strCaseId = objCaseCourseKnowledgeRelaEN.CaseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCaseId + "'");
 }
 
 if (objCaseCourseKnowledgeRelaEN.CaseName !=  null)
 {
 arrFieldListForInsert.Add(conCaseCourseKnowledgeRela.CaseName);
 var strCaseName = objCaseCourseKnowledgeRelaEN.CaseName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCaseName + "'");
 }
 
 if (objCaseCourseKnowledgeRelaEN.OwnerId !=  null)
 {
 arrFieldListForInsert.Add(conCaseCourseKnowledgeRela.OwnerId);
 var strOwnerId = objCaseCourseKnowledgeRelaEN.OwnerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strOwnerId + "'");
 }
 
 if (objCaseCourseKnowledgeRelaEN.CourseKnowledgeId !=  null)
 {
 arrFieldListForInsert.Add(conCaseCourseKnowledgeRela.CourseKnowledgeId);
 var strCourseKnowledgeId = objCaseCourseKnowledgeRelaEN.CourseKnowledgeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseKnowledgeId + "'");
 }
 
 if (objCaseCourseKnowledgeRelaEN.IdCaseCourseKnowledgeRelaType !=  null)
 {
 arrFieldListForInsert.Add(conCaseCourseKnowledgeRela.IdCaseCourseKnowledgeRelaType);
 var strIdCaseCourseKnowledgeRelaType = objCaseCourseKnowledgeRelaEN.IdCaseCourseKnowledgeRelaType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCaseCourseKnowledgeRelaType + "'");
 }
 
 arrFieldListForInsert.Add(conCaseCourseKnowledgeRela.RelationsDegree);
 arrValueListForInsert.Add(objCaseCourseKnowledgeRelaEN.RelationsDegree.ToString());
 
 arrFieldListForInsert.Add(conCaseCourseKnowledgeRela.BrowseCount);
 arrValueListForInsert.Add(objCaseCourseKnowledgeRelaEN.BrowseCount.ToString());
 
 if (objCaseCourseKnowledgeRelaEN.OrderNum !=  null)
 {
 arrFieldListForInsert.Add(conCaseCourseKnowledgeRela.OrderNum);
 arrValueListForInsert.Add(objCaseCourseKnowledgeRelaEN.OrderNum.ToString());
 }
 
 if (objCaseCourseKnowledgeRelaEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conCaseCourseKnowledgeRela.UpdDate);
 var strUpdDate = objCaseCourseKnowledgeRelaEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objCaseCourseKnowledgeRelaEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(conCaseCourseKnowledgeRela.UpdUserId);
 var strUpdUserId = objCaseCourseKnowledgeRelaEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objCaseCourseKnowledgeRelaEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conCaseCourseKnowledgeRela.Memo);
 var strMemo = objCaseCourseKnowledgeRelaEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into CaseCourseKnowledgeRela");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCaseCourseKnowledgeRelaDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewCaseCourseKnowledgeRelas(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCaseCourseKnowledgeRelaDA.GetSpecSQLObj();
strSQL = "Select * from CaseCourseKnowledgeRela where IdCaseCourseKnowledgeRela = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "CaseCourseKnowledgeRela");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
long lngIdCaseCourseKnowledgeRela = TransNullToInt(oRow[conCaseCourseKnowledgeRela.IdCaseCourseKnowledgeRela].ToString().Trim());
if (IsExist(lngIdCaseCourseKnowledgeRela))
{
 string strResult = "关键字变量值为:" + string.Format("IdCaseCourseKnowledgeRela = {0}", lngIdCaseCourseKnowledgeRela) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsCaseCourseKnowledgeRelaEN._CurrTabName ].NewRow();
objRow[conCaseCourseKnowledgeRela.FuncModuleId] = oRow[conCaseCourseKnowledgeRela.FuncModuleId].ToString().Trim(); //功能模块Id
objRow[conCaseCourseKnowledgeRela.CaseId] = oRow[conCaseCourseKnowledgeRela.CaseId].ToString().Trim(); //案例Id
objRow[conCaseCourseKnowledgeRela.CaseName] = oRow[conCaseCourseKnowledgeRela.CaseName].ToString().Trim(); //案例名称
objRow[conCaseCourseKnowledgeRela.OwnerId] = oRow[conCaseCourseKnowledgeRela.OwnerId].ToString().Trim(); //拥有者Id
objRow[conCaseCourseKnowledgeRela.CourseKnowledgeId] = oRow[conCaseCourseKnowledgeRela.CourseKnowledgeId].ToString().Trim(); //知识点Id
objRow[conCaseCourseKnowledgeRela.IdCaseCourseKnowledgeRelaType] = oRow[conCaseCourseKnowledgeRela.IdCaseCourseKnowledgeRelaType].ToString().Trim(); //案例知识点关系类型流水号
objRow[conCaseCourseKnowledgeRela.RelationsDegree] = oRow[conCaseCourseKnowledgeRela.RelationsDegree].ToString().Trim(); //关系度
objRow[conCaseCourseKnowledgeRela.BrowseCount] = oRow[conCaseCourseKnowledgeRela.BrowseCount].ToString().Trim(); //浏览次数
objRow[conCaseCourseKnowledgeRela.OrderNum] = oRow[conCaseCourseKnowledgeRela.OrderNum].ToString().Trim(); //序号
objRow[conCaseCourseKnowledgeRela.UpdDate] = oRow[conCaseCourseKnowledgeRela.UpdDate].ToString().Trim(); //修改日期
objRow[conCaseCourseKnowledgeRela.UpdUserId] = oRow[conCaseCourseKnowledgeRela.UpdUserId].ToString().Trim(); //修改用户Id
objRow[conCaseCourseKnowledgeRela.Memo] = oRow[conCaseCourseKnowledgeRela.Memo].ToString().Trim(); //备注
 objDS.Tables[clsCaseCourseKnowledgeRelaEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsCaseCourseKnowledgeRelaEN._CurrTabName);
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
 /// <param name = "objCaseCourseKnowledgeRelaEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsCaseCourseKnowledgeRelaEN objCaseCourseKnowledgeRelaEN)
{
 objCaseCourseKnowledgeRelaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCaseCourseKnowledgeRelaEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objCaseCourseKnowledgeRelaEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCaseCourseKnowledgeRelaDA.GetSpecSQLObj();
strSQL = "Select * from CaseCourseKnowledgeRela where IdCaseCourseKnowledgeRela = " + ""+ objCaseCourseKnowledgeRelaEN.IdCaseCourseKnowledgeRela+"";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsCaseCourseKnowledgeRelaEN._CurrTabName);
if (objDS.Tables[clsCaseCourseKnowledgeRelaEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:IdCaseCourseKnowledgeRela = " + ""+ objCaseCourseKnowledgeRelaEN.IdCaseCourseKnowledgeRela+"");
return false;
}
objRow = objDS.Tables[clsCaseCourseKnowledgeRelaEN._CurrTabName].Rows[0];
 if (objCaseCourseKnowledgeRelaEN.IsUpdated(conCaseCourseKnowledgeRela.FuncModuleId))
 {
objRow[conCaseCourseKnowledgeRela.FuncModuleId] = objCaseCourseKnowledgeRelaEN.FuncModuleId; //功能模块Id
 }
 if (objCaseCourseKnowledgeRelaEN.IsUpdated(conCaseCourseKnowledgeRela.CaseId))
 {
objRow[conCaseCourseKnowledgeRela.CaseId] = objCaseCourseKnowledgeRelaEN.CaseId; //案例Id
 }
 if (objCaseCourseKnowledgeRelaEN.IsUpdated(conCaseCourseKnowledgeRela.CaseName))
 {
objRow[conCaseCourseKnowledgeRela.CaseName] = objCaseCourseKnowledgeRelaEN.CaseName; //案例名称
 }
 if (objCaseCourseKnowledgeRelaEN.IsUpdated(conCaseCourseKnowledgeRela.OwnerId))
 {
objRow[conCaseCourseKnowledgeRela.OwnerId] = objCaseCourseKnowledgeRelaEN.OwnerId; //拥有者Id
 }
 if (objCaseCourseKnowledgeRelaEN.IsUpdated(conCaseCourseKnowledgeRela.CourseKnowledgeId))
 {
objRow[conCaseCourseKnowledgeRela.CourseKnowledgeId] = objCaseCourseKnowledgeRelaEN.CourseKnowledgeId; //知识点Id
 }
 if (objCaseCourseKnowledgeRelaEN.IsUpdated(conCaseCourseKnowledgeRela.IdCaseCourseKnowledgeRelaType))
 {
objRow[conCaseCourseKnowledgeRela.IdCaseCourseKnowledgeRelaType] = objCaseCourseKnowledgeRelaEN.IdCaseCourseKnowledgeRelaType; //案例知识点关系类型流水号
 }
 if (objCaseCourseKnowledgeRelaEN.IsUpdated(conCaseCourseKnowledgeRela.RelationsDegree))
 {
objRow[conCaseCourseKnowledgeRela.RelationsDegree] = objCaseCourseKnowledgeRelaEN.RelationsDegree; //关系度
 }
 if (objCaseCourseKnowledgeRelaEN.IsUpdated(conCaseCourseKnowledgeRela.BrowseCount))
 {
objRow[conCaseCourseKnowledgeRela.BrowseCount] = objCaseCourseKnowledgeRelaEN.BrowseCount; //浏览次数
 }
 if (objCaseCourseKnowledgeRelaEN.IsUpdated(conCaseCourseKnowledgeRela.OrderNum))
 {
objRow[conCaseCourseKnowledgeRela.OrderNum] = objCaseCourseKnowledgeRelaEN.OrderNum; //序号
 }
 if (objCaseCourseKnowledgeRelaEN.IsUpdated(conCaseCourseKnowledgeRela.UpdDate))
 {
objRow[conCaseCourseKnowledgeRela.UpdDate] = objCaseCourseKnowledgeRelaEN.UpdDate; //修改日期
 }
 if (objCaseCourseKnowledgeRelaEN.IsUpdated(conCaseCourseKnowledgeRela.UpdUserId))
 {
objRow[conCaseCourseKnowledgeRela.UpdUserId] = objCaseCourseKnowledgeRelaEN.UpdUserId; //修改用户Id
 }
 if (objCaseCourseKnowledgeRelaEN.IsUpdated(conCaseCourseKnowledgeRela.Memo))
 {
objRow[conCaseCourseKnowledgeRela.Memo] = objCaseCourseKnowledgeRelaEN.Memo; //备注
 }
try
{
objDA.Update(objDS, clsCaseCourseKnowledgeRelaEN._CurrTabName);
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
 /// <param name = "objCaseCourseKnowledgeRelaEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsCaseCourseKnowledgeRelaEN objCaseCourseKnowledgeRelaEN)
{
 objCaseCourseKnowledgeRelaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCaseCourseKnowledgeRelaEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objCaseCourseKnowledgeRelaEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCaseCourseKnowledgeRelaDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update CaseCourseKnowledgeRela Set ");
 
 if (objCaseCourseKnowledgeRelaEN.IsUpdated(conCaseCourseKnowledgeRela.FuncModuleId))
 {
 if (objCaseCourseKnowledgeRelaEN.FuncModuleId !=  null)
 {
 var strFuncModuleId = objCaseCourseKnowledgeRelaEN.FuncModuleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFuncModuleId, conCaseCourseKnowledgeRela.FuncModuleId); //功能模块Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCaseCourseKnowledgeRela.FuncModuleId); //功能模块Id
 }
 }
 
 if (objCaseCourseKnowledgeRelaEN.IsUpdated(conCaseCourseKnowledgeRela.CaseId))
 {
 if (objCaseCourseKnowledgeRelaEN.CaseId !=  null)
 {
 var strCaseId = objCaseCourseKnowledgeRelaEN.CaseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCaseId, conCaseCourseKnowledgeRela.CaseId); //案例Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCaseCourseKnowledgeRela.CaseId); //案例Id
 }
 }
 
 if (objCaseCourseKnowledgeRelaEN.IsUpdated(conCaseCourseKnowledgeRela.CaseName))
 {
 if (objCaseCourseKnowledgeRelaEN.CaseName !=  null)
 {
 var strCaseName = objCaseCourseKnowledgeRelaEN.CaseName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCaseName, conCaseCourseKnowledgeRela.CaseName); //案例名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCaseCourseKnowledgeRela.CaseName); //案例名称
 }
 }
 
 if (objCaseCourseKnowledgeRelaEN.IsUpdated(conCaseCourseKnowledgeRela.OwnerId))
 {
 if (objCaseCourseKnowledgeRelaEN.OwnerId !=  null)
 {
 var strOwnerId = objCaseCourseKnowledgeRelaEN.OwnerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strOwnerId, conCaseCourseKnowledgeRela.OwnerId); //拥有者Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCaseCourseKnowledgeRela.OwnerId); //拥有者Id
 }
 }
 
 if (objCaseCourseKnowledgeRelaEN.IsUpdated(conCaseCourseKnowledgeRela.CourseKnowledgeId))
 {
 if (objCaseCourseKnowledgeRelaEN.CourseKnowledgeId !=  null)
 {
 var strCourseKnowledgeId = objCaseCourseKnowledgeRelaEN.CourseKnowledgeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCourseKnowledgeId, conCaseCourseKnowledgeRela.CourseKnowledgeId); //知识点Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCaseCourseKnowledgeRela.CourseKnowledgeId); //知识点Id
 }
 }
 
 if (objCaseCourseKnowledgeRelaEN.IsUpdated(conCaseCourseKnowledgeRela.IdCaseCourseKnowledgeRelaType))
 {
 if (objCaseCourseKnowledgeRelaEN.IdCaseCourseKnowledgeRelaType !=  null)
 {
 var strIdCaseCourseKnowledgeRelaType = objCaseCourseKnowledgeRelaEN.IdCaseCourseKnowledgeRelaType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdCaseCourseKnowledgeRelaType, conCaseCourseKnowledgeRela.IdCaseCourseKnowledgeRelaType); //案例知识点关系类型流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCaseCourseKnowledgeRela.IdCaseCourseKnowledgeRelaType); //案例知识点关系类型流水号
 }
 }
 
 if (objCaseCourseKnowledgeRelaEN.IsUpdated(conCaseCourseKnowledgeRela.RelationsDegree))
 {
 sbSQL.AppendFormat("{1} = {0},",objCaseCourseKnowledgeRelaEN.RelationsDegree, conCaseCourseKnowledgeRela.RelationsDegree); //关系度
 }
 
 if (objCaseCourseKnowledgeRelaEN.IsUpdated(conCaseCourseKnowledgeRela.BrowseCount))
 {
 sbSQL.AppendFormat("{1} = {0},",objCaseCourseKnowledgeRelaEN.BrowseCount, conCaseCourseKnowledgeRela.BrowseCount); //浏览次数
 }
 
 if (objCaseCourseKnowledgeRelaEN.IsUpdated(conCaseCourseKnowledgeRela.OrderNum))
 {
 if (objCaseCourseKnowledgeRelaEN.OrderNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCaseCourseKnowledgeRelaEN.OrderNum, conCaseCourseKnowledgeRela.OrderNum); //序号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCaseCourseKnowledgeRela.OrderNum); //序号
 }
 }
 
 if (objCaseCourseKnowledgeRelaEN.IsUpdated(conCaseCourseKnowledgeRela.UpdDate))
 {
 if (objCaseCourseKnowledgeRelaEN.UpdDate !=  null)
 {
 var strUpdDate = objCaseCourseKnowledgeRelaEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conCaseCourseKnowledgeRela.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCaseCourseKnowledgeRela.UpdDate); //修改日期
 }
 }
 
 if (objCaseCourseKnowledgeRelaEN.IsUpdated(conCaseCourseKnowledgeRela.UpdUserId))
 {
 if (objCaseCourseKnowledgeRelaEN.UpdUserId !=  null)
 {
 var strUpdUserId = objCaseCourseKnowledgeRelaEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUserId, conCaseCourseKnowledgeRela.UpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCaseCourseKnowledgeRela.UpdUserId); //修改用户Id
 }
 }
 
 if (objCaseCourseKnowledgeRelaEN.IsUpdated(conCaseCourseKnowledgeRela.Memo))
 {
 if (objCaseCourseKnowledgeRelaEN.Memo !=  null)
 {
 var strMemo = objCaseCourseKnowledgeRelaEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conCaseCourseKnowledgeRela.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCaseCourseKnowledgeRela.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where IdCaseCourseKnowledgeRela = {0}", objCaseCourseKnowledgeRelaEN.IdCaseCourseKnowledgeRela); 
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
 /// <param name = "objCaseCourseKnowledgeRelaEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsCaseCourseKnowledgeRelaEN objCaseCourseKnowledgeRelaEN, string strCondition)
{
 objCaseCourseKnowledgeRelaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCaseCourseKnowledgeRelaEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objCaseCourseKnowledgeRelaEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCaseCourseKnowledgeRelaDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update CaseCourseKnowledgeRela Set ");
 
 if (objCaseCourseKnowledgeRelaEN.IsUpdated(conCaseCourseKnowledgeRela.FuncModuleId))
 {
 if (objCaseCourseKnowledgeRelaEN.FuncModuleId !=  null)
 {
 var strFuncModuleId = objCaseCourseKnowledgeRelaEN.FuncModuleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FuncModuleId = '{0}',", strFuncModuleId); //功能模块Id
 }
 else
 {
 sbSQL.Append(" FuncModuleId = null,"); //功能模块Id
 }
 }
 
 if (objCaseCourseKnowledgeRelaEN.IsUpdated(conCaseCourseKnowledgeRela.CaseId))
 {
 if (objCaseCourseKnowledgeRelaEN.CaseId !=  null)
 {
 var strCaseId = objCaseCourseKnowledgeRelaEN.CaseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CaseId = '{0}',", strCaseId); //案例Id
 }
 else
 {
 sbSQL.Append(" CaseId = null,"); //案例Id
 }
 }
 
 if (objCaseCourseKnowledgeRelaEN.IsUpdated(conCaseCourseKnowledgeRela.CaseName))
 {
 if (objCaseCourseKnowledgeRelaEN.CaseName !=  null)
 {
 var strCaseName = objCaseCourseKnowledgeRelaEN.CaseName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CaseName = '{0}',", strCaseName); //案例名称
 }
 else
 {
 sbSQL.Append(" CaseName = null,"); //案例名称
 }
 }
 
 if (objCaseCourseKnowledgeRelaEN.IsUpdated(conCaseCourseKnowledgeRela.OwnerId))
 {
 if (objCaseCourseKnowledgeRelaEN.OwnerId !=  null)
 {
 var strOwnerId = objCaseCourseKnowledgeRelaEN.OwnerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" OwnerId = '{0}',", strOwnerId); //拥有者Id
 }
 else
 {
 sbSQL.Append(" OwnerId = null,"); //拥有者Id
 }
 }
 
 if (objCaseCourseKnowledgeRelaEN.IsUpdated(conCaseCourseKnowledgeRela.CourseKnowledgeId))
 {
 if (objCaseCourseKnowledgeRelaEN.CourseKnowledgeId !=  null)
 {
 var strCourseKnowledgeId = objCaseCourseKnowledgeRelaEN.CourseKnowledgeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CourseKnowledgeId = '{0}',", strCourseKnowledgeId); //知识点Id
 }
 else
 {
 sbSQL.Append(" CourseKnowledgeId = null,"); //知识点Id
 }
 }
 
 if (objCaseCourseKnowledgeRelaEN.IsUpdated(conCaseCourseKnowledgeRela.IdCaseCourseKnowledgeRelaType))
 {
 if (objCaseCourseKnowledgeRelaEN.IdCaseCourseKnowledgeRelaType !=  null)
 {
 var strIdCaseCourseKnowledgeRelaType = objCaseCourseKnowledgeRelaEN.IdCaseCourseKnowledgeRelaType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdCaseCourseKnowledgeRelaType = '{0}',", strIdCaseCourseKnowledgeRelaType); //案例知识点关系类型流水号
 }
 else
 {
 sbSQL.Append(" IdCaseCourseKnowledgeRelaType = null,"); //案例知识点关系类型流水号
 }
 }
 
 if (objCaseCourseKnowledgeRelaEN.IsUpdated(conCaseCourseKnowledgeRela.RelationsDegree))
 {
 sbSQL.AppendFormat(" RelationsDegree = {0},", objCaseCourseKnowledgeRelaEN.RelationsDegree); //关系度
 }
 
 if (objCaseCourseKnowledgeRelaEN.IsUpdated(conCaseCourseKnowledgeRela.BrowseCount))
 {
 sbSQL.AppendFormat(" BrowseCount = {0},", objCaseCourseKnowledgeRelaEN.BrowseCount); //浏览次数
 }
 
 if (objCaseCourseKnowledgeRelaEN.IsUpdated(conCaseCourseKnowledgeRela.OrderNum))
 {
 if (objCaseCourseKnowledgeRelaEN.OrderNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCaseCourseKnowledgeRelaEN.OrderNum, conCaseCourseKnowledgeRela.OrderNum); //序号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCaseCourseKnowledgeRela.OrderNum); //序号
 }
 }
 
 if (objCaseCourseKnowledgeRelaEN.IsUpdated(conCaseCourseKnowledgeRela.UpdDate))
 {
 if (objCaseCourseKnowledgeRelaEN.UpdDate !=  null)
 {
 var strUpdDate = objCaseCourseKnowledgeRelaEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objCaseCourseKnowledgeRelaEN.IsUpdated(conCaseCourseKnowledgeRela.UpdUserId))
 {
 if (objCaseCourseKnowledgeRelaEN.UpdUserId !=  null)
 {
 var strUpdUserId = objCaseCourseKnowledgeRelaEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUserId = '{0}',", strUpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.Append(" UpdUserId = null,"); //修改用户Id
 }
 }
 
 if (objCaseCourseKnowledgeRelaEN.IsUpdated(conCaseCourseKnowledgeRela.Memo))
 {
 if (objCaseCourseKnowledgeRelaEN.Memo !=  null)
 {
 var strMemo = objCaseCourseKnowledgeRelaEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objCaseCourseKnowledgeRelaEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsCaseCourseKnowledgeRelaEN objCaseCourseKnowledgeRelaEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objCaseCourseKnowledgeRelaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCaseCourseKnowledgeRelaEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objCaseCourseKnowledgeRelaEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCaseCourseKnowledgeRelaDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update CaseCourseKnowledgeRela Set ");
 
 if (objCaseCourseKnowledgeRelaEN.IsUpdated(conCaseCourseKnowledgeRela.FuncModuleId))
 {
 if (objCaseCourseKnowledgeRelaEN.FuncModuleId !=  null)
 {
 var strFuncModuleId = objCaseCourseKnowledgeRelaEN.FuncModuleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FuncModuleId = '{0}',", strFuncModuleId); //功能模块Id
 }
 else
 {
 sbSQL.Append(" FuncModuleId = null,"); //功能模块Id
 }
 }
 
 if (objCaseCourseKnowledgeRelaEN.IsUpdated(conCaseCourseKnowledgeRela.CaseId))
 {
 if (objCaseCourseKnowledgeRelaEN.CaseId !=  null)
 {
 var strCaseId = objCaseCourseKnowledgeRelaEN.CaseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CaseId = '{0}',", strCaseId); //案例Id
 }
 else
 {
 sbSQL.Append(" CaseId = null,"); //案例Id
 }
 }
 
 if (objCaseCourseKnowledgeRelaEN.IsUpdated(conCaseCourseKnowledgeRela.CaseName))
 {
 if (objCaseCourseKnowledgeRelaEN.CaseName !=  null)
 {
 var strCaseName = objCaseCourseKnowledgeRelaEN.CaseName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CaseName = '{0}',", strCaseName); //案例名称
 }
 else
 {
 sbSQL.Append(" CaseName = null,"); //案例名称
 }
 }
 
 if (objCaseCourseKnowledgeRelaEN.IsUpdated(conCaseCourseKnowledgeRela.OwnerId))
 {
 if (objCaseCourseKnowledgeRelaEN.OwnerId !=  null)
 {
 var strOwnerId = objCaseCourseKnowledgeRelaEN.OwnerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" OwnerId = '{0}',", strOwnerId); //拥有者Id
 }
 else
 {
 sbSQL.Append(" OwnerId = null,"); //拥有者Id
 }
 }
 
 if (objCaseCourseKnowledgeRelaEN.IsUpdated(conCaseCourseKnowledgeRela.CourseKnowledgeId))
 {
 if (objCaseCourseKnowledgeRelaEN.CourseKnowledgeId !=  null)
 {
 var strCourseKnowledgeId = objCaseCourseKnowledgeRelaEN.CourseKnowledgeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CourseKnowledgeId = '{0}',", strCourseKnowledgeId); //知识点Id
 }
 else
 {
 sbSQL.Append(" CourseKnowledgeId = null,"); //知识点Id
 }
 }
 
 if (objCaseCourseKnowledgeRelaEN.IsUpdated(conCaseCourseKnowledgeRela.IdCaseCourseKnowledgeRelaType))
 {
 if (objCaseCourseKnowledgeRelaEN.IdCaseCourseKnowledgeRelaType !=  null)
 {
 var strIdCaseCourseKnowledgeRelaType = objCaseCourseKnowledgeRelaEN.IdCaseCourseKnowledgeRelaType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdCaseCourseKnowledgeRelaType = '{0}',", strIdCaseCourseKnowledgeRelaType); //案例知识点关系类型流水号
 }
 else
 {
 sbSQL.Append(" IdCaseCourseKnowledgeRelaType = null,"); //案例知识点关系类型流水号
 }
 }
 
 if (objCaseCourseKnowledgeRelaEN.IsUpdated(conCaseCourseKnowledgeRela.RelationsDegree))
 {
 sbSQL.AppendFormat(" RelationsDegree = {0},", objCaseCourseKnowledgeRelaEN.RelationsDegree); //关系度
 }
 
 if (objCaseCourseKnowledgeRelaEN.IsUpdated(conCaseCourseKnowledgeRela.BrowseCount))
 {
 sbSQL.AppendFormat(" BrowseCount = {0},", objCaseCourseKnowledgeRelaEN.BrowseCount); //浏览次数
 }
 
 if (objCaseCourseKnowledgeRelaEN.IsUpdated(conCaseCourseKnowledgeRela.OrderNum))
 {
 if (objCaseCourseKnowledgeRelaEN.OrderNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCaseCourseKnowledgeRelaEN.OrderNum, conCaseCourseKnowledgeRela.OrderNum); //序号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCaseCourseKnowledgeRela.OrderNum); //序号
 }
 }
 
 if (objCaseCourseKnowledgeRelaEN.IsUpdated(conCaseCourseKnowledgeRela.UpdDate))
 {
 if (objCaseCourseKnowledgeRelaEN.UpdDate !=  null)
 {
 var strUpdDate = objCaseCourseKnowledgeRelaEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objCaseCourseKnowledgeRelaEN.IsUpdated(conCaseCourseKnowledgeRela.UpdUserId))
 {
 if (objCaseCourseKnowledgeRelaEN.UpdUserId !=  null)
 {
 var strUpdUserId = objCaseCourseKnowledgeRelaEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUserId = '{0}',", strUpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.Append(" UpdUserId = null,"); //修改用户Id
 }
 }
 
 if (objCaseCourseKnowledgeRelaEN.IsUpdated(conCaseCourseKnowledgeRela.Memo))
 {
 if (objCaseCourseKnowledgeRelaEN.Memo !=  null)
 {
 var strMemo = objCaseCourseKnowledgeRelaEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objCaseCourseKnowledgeRelaEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsCaseCourseKnowledgeRelaEN objCaseCourseKnowledgeRelaEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objCaseCourseKnowledgeRelaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCaseCourseKnowledgeRelaEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objCaseCourseKnowledgeRelaEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCaseCourseKnowledgeRelaDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update CaseCourseKnowledgeRela Set ");
 
 if (objCaseCourseKnowledgeRelaEN.IsUpdated(conCaseCourseKnowledgeRela.FuncModuleId))
 {
 if (objCaseCourseKnowledgeRelaEN.FuncModuleId !=  null)
 {
 var strFuncModuleId = objCaseCourseKnowledgeRelaEN.FuncModuleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFuncModuleId, conCaseCourseKnowledgeRela.FuncModuleId); //功能模块Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCaseCourseKnowledgeRela.FuncModuleId); //功能模块Id
 }
 }
 
 if (objCaseCourseKnowledgeRelaEN.IsUpdated(conCaseCourseKnowledgeRela.CaseId))
 {
 if (objCaseCourseKnowledgeRelaEN.CaseId !=  null)
 {
 var strCaseId = objCaseCourseKnowledgeRelaEN.CaseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCaseId, conCaseCourseKnowledgeRela.CaseId); //案例Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCaseCourseKnowledgeRela.CaseId); //案例Id
 }
 }
 
 if (objCaseCourseKnowledgeRelaEN.IsUpdated(conCaseCourseKnowledgeRela.CaseName))
 {
 if (objCaseCourseKnowledgeRelaEN.CaseName !=  null)
 {
 var strCaseName = objCaseCourseKnowledgeRelaEN.CaseName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCaseName, conCaseCourseKnowledgeRela.CaseName); //案例名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCaseCourseKnowledgeRela.CaseName); //案例名称
 }
 }
 
 if (objCaseCourseKnowledgeRelaEN.IsUpdated(conCaseCourseKnowledgeRela.OwnerId))
 {
 if (objCaseCourseKnowledgeRelaEN.OwnerId !=  null)
 {
 var strOwnerId = objCaseCourseKnowledgeRelaEN.OwnerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strOwnerId, conCaseCourseKnowledgeRela.OwnerId); //拥有者Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCaseCourseKnowledgeRela.OwnerId); //拥有者Id
 }
 }
 
 if (objCaseCourseKnowledgeRelaEN.IsUpdated(conCaseCourseKnowledgeRela.CourseKnowledgeId))
 {
 if (objCaseCourseKnowledgeRelaEN.CourseKnowledgeId !=  null)
 {
 var strCourseKnowledgeId = objCaseCourseKnowledgeRelaEN.CourseKnowledgeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCourseKnowledgeId, conCaseCourseKnowledgeRela.CourseKnowledgeId); //知识点Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCaseCourseKnowledgeRela.CourseKnowledgeId); //知识点Id
 }
 }
 
 if (objCaseCourseKnowledgeRelaEN.IsUpdated(conCaseCourseKnowledgeRela.IdCaseCourseKnowledgeRelaType))
 {
 if (objCaseCourseKnowledgeRelaEN.IdCaseCourseKnowledgeRelaType !=  null)
 {
 var strIdCaseCourseKnowledgeRelaType = objCaseCourseKnowledgeRelaEN.IdCaseCourseKnowledgeRelaType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdCaseCourseKnowledgeRelaType, conCaseCourseKnowledgeRela.IdCaseCourseKnowledgeRelaType); //案例知识点关系类型流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCaseCourseKnowledgeRela.IdCaseCourseKnowledgeRelaType); //案例知识点关系类型流水号
 }
 }
 
 if (objCaseCourseKnowledgeRelaEN.IsUpdated(conCaseCourseKnowledgeRela.RelationsDegree))
 {
 sbSQL.AppendFormat("{1} = {0},",objCaseCourseKnowledgeRelaEN.RelationsDegree, conCaseCourseKnowledgeRela.RelationsDegree); //关系度
 }
 
 if (objCaseCourseKnowledgeRelaEN.IsUpdated(conCaseCourseKnowledgeRela.BrowseCount))
 {
 sbSQL.AppendFormat("{1} = {0},",objCaseCourseKnowledgeRelaEN.BrowseCount, conCaseCourseKnowledgeRela.BrowseCount); //浏览次数
 }
 
 if (objCaseCourseKnowledgeRelaEN.IsUpdated(conCaseCourseKnowledgeRela.OrderNum))
 {
 if (objCaseCourseKnowledgeRelaEN.OrderNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCaseCourseKnowledgeRelaEN.OrderNum, conCaseCourseKnowledgeRela.OrderNum); //序号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCaseCourseKnowledgeRela.OrderNum); //序号
 }
 }
 
 if (objCaseCourseKnowledgeRelaEN.IsUpdated(conCaseCourseKnowledgeRela.UpdDate))
 {
 if (objCaseCourseKnowledgeRelaEN.UpdDate !=  null)
 {
 var strUpdDate = objCaseCourseKnowledgeRelaEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conCaseCourseKnowledgeRela.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCaseCourseKnowledgeRela.UpdDate); //修改日期
 }
 }
 
 if (objCaseCourseKnowledgeRelaEN.IsUpdated(conCaseCourseKnowledgeRela.UpdUserId))
 {
 if (objCaseCourseKnowledgeRelaEN.UpdUserId !=  null)
 {
 var strUpdUserId = objCaseCourseKnowledgeRelaEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUserId, conCaseCourseKnowledgeRela.UpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCaseCourseKnowledgeRela.UpdUserId); //修改用户Id
 }
 }
 
 if (objCaseCourseKnowledgeRelaEN.IsUpdated(conCaseCourseKnowledgeRela.Memo))
 {
 if (objCaseCourseKnowledgeRelaEN.Memo !=  null)
 {
 var strMemo = objCaseCourseKnowledgeRelaEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conCaseCourseKnowledgeRela.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCaseCourseKnowledgeRela.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where IdCaseCourseKnowledgeRela = {0}", objCaseCourseKnowledgeRelaEN.IdCaseCourseKnowledgeRela); 
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
 /// <param name = "lngIdCaseCourseKnowledgeRela">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(long lngIdCaseCourseKnowledgeRela) 
{
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCaseCourseKnowledgeRelaDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 lngIdCaseCourseKnowledgeRela,
};
 objSQL.ExecSP("CaseCourseKnowledgeRela_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "lngIdCaseCourseKnowledgeRela">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(long lngIdCaseCourseKnowledgeRela, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCaseCourseKnowledgeRelaDA.GetSpecSQLObj();
//删除CaseCourseKnowledgeRela本表中与当前对象有关的记录
strSQL = strSQL + "Delete from CaseCourseKnowledgeRela where IdCaseCourseKnowledgeRela = " + ""+ lngIdCaseCourseKnowledgeRela+"";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelCaseCourseKnowledgeRela(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCaseCourseKnowledgeRelaDA.GetSpecSQLObj();
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
//删除CaseCourseKnowledgeRela本表中与当前对象有关的记录
strSQL = strSQL + "Delete from CaseCourseKnowledgeRela where IdCaseCourseKnowledgeRela in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "lngIdCaseCourseKnowledgeRela">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(long lngIdCaseCourseKnowledgeRela) 
{
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCaseCourseKnowledgeRelaDA.GetSpecSQLObj();
//删除CaseCourseKnowledgeRela本表中与当前对象有关的记录
strSQL = strSQL + "Delete from CaseCourseKnowledgeRela where IdCaseCourseKnowledgeRela = " + ""+ lngIdCaseCourseKnowledgeRela+"";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelCaseCourseKnowledgeRela(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsCaseCourseKnowledgeRelaDA: DelCaseCourseKnowledgeRela)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCaseCourseKnowledgeRelaDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from CaseCourseKnowledgeRela where " + strCondition ;
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
public bool DelCaseCourseKnowledgeRelaWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsCaseCourseKnowledgeRelaDA: DelCaseCourseKnowledgeRelaWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCaseCourseKnowledgeRelaDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from CaseCourseKnowledgeRela where " + strCondition ;
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
 /// <param name = "objCaseCourseKnowledgeRelaENS">源对象</param>
 /// <param name = "objCaseCourseKnowledgeRelaENT">目标对象</param>
public void CopyTo(clsCaseCourseKnowledgeRelaEN objCaseCourseKnowledgeRelaENS, clsCaseCourseKnowledgeRelaEN objCaseCourseKnowledgeRelaENT)
{
objCaseCourseKnowledgeRelaENT.IdCaseCourseKnowledgeRela = objCaseCourseKnowledgeRelaENS.IdCaseCourseKnowledgeRela; //案例知识点关系流水号
objCaseCourseKnowledgeRelaENT.FuncModuleId = objCaseCourseKnowledgeRelaENS.FuncModuleId; //功能模块Id
objCaseCourseKnowledgeRelaENT.CaseId = objCaseCourseKnowledgeRelaENS.CaseId; //案例Id
objCaseCourseKnowledgeRelaENT.CaseName = objCaseCourseKnowledgeRelaENS.CaseName; //案例名称
objCaseCourseKnowledgeRelaENT.OwnerId = objCaseCourseKnowledgeRelaENS.OwnerId; //拥有者Id
objCaseCourseKnowledgeRelaENT.CourseKnowledgeId = objCaseCourseKnowledgeRelaENS.CourseKnowledgeId; //知识点Id
objCaseCourseKnowledgeRelaENT.IdCaseCourseKnowledgeRelaType = objCaseCourseKnowledgeRelaENS.IdCaseCourseKnowledgeRelaType; //案例知识点关系类型流水号
objCaseCourseKnowledgeRelaENT.RelationsDegree = objCaseCourseKnowledgeRelaENS.RelationsDegree; //关系度
objCaseCourseKnowledgeRelaENT.BrowseCount = objCaseCourseKnowledgeRelaENS.BrowseCount; //浏览次数
objCaseCourseKnowledgeRelaENT.OrderNum = objCaseCourseKnowledgeRelaENS.OrderNum; //序号
objCaseCourseKnowledgeRelaENT.UpdDate = objCaseCourseKnowledgeRelaENS.UpdDate; //修改日期
objCaseCourseKnowledgeRelaENT.UpdUserId = objCaseCourseKnowledgeRelaENS.UpdUserId; //修改用户Id
objCaseCourseKnowledgeRelaENT.Memo = objCaseCourseKnowledgeRelaENS.Memo; //备注
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsCaseCourseKnowledgeRelaEN objCaseCourseKnowledgeRelaEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objCaseCourseKnowledgeRelaEN.FuncModuleId, conCaseCourseKnowledgeRela.FuncModuleId);
clsCheckSql.CheckFieldNotNull(objCaseCourseKnowledgeRelaEN.CaseId, conCaseCourseKnowledgeRela.CaseId);
clsCheckSql.CheckFieldNotNull(objCaseCourseKnowledgeRelaEN.CaseName, conCaseCourseKnowledgeRela.CaseName);
clsCheckSql.CheckFieldNotNull(objCaseCourseKnowledgeRelaEN.IdCaseCourseKnowledgeRelaType, conCaseCourseKnowledgeRela.IdCaseCourseKnowledgeRelaType);
clsCheckSql.CheckFieldNotNull(objCaseCourseKnowledgeRelaEN.RelationsDegree, conCaseCourseKnowledgeRela.RelationsDegree);
clsCheckSql.CheckFieldNotNull(objCaseCourseKnowledgeRelaEN.BrowseCount, conCaseCourseKnowledgeRela.BrowseCount);
//检查字段长度
clsCheckSql.CheckFieldLen(objCaseCourseKnowledgeRelaEN.FuncModuleId, 4, conCaseCourseKnowledgeRela.FuncModuleId);
clsCheckSql.CheckFieldLen(objCaseCourseKnowledgeRelaEN.CaseId, 8, conCaseCourseKnowledgeRela.CaseId);
clsCheckSql.CheckFieldLen(objCaseCourseKnowledgeRelaEN.CaseName, 100, conCaseCourseKnowledgeRela.CaseName);
clsCheckSql.CheckFieldLen(objCaseCourseKnowledgeRelaEN.OwnerId, 20, conCaseCourseKnowledgeRela.OwnerId);
clsCheckSql.CheckFieldLen(objCaseCourseKnowledgeRelaEN.CourseKnowledgeId, 8, conCaseCourseKnowledgeRela.CourseKnowledgeId);
clsCheckSql.CheckFieldLen(objCaseCourseKnowledgeRelaEN.IdCaseCourseKnowledgeRelaType, 4, conCaseCourseKnowledgeRela.IdCaseCourseKnowledgeRelaType);
clsCheckSql.CheckFieldLen(objCaseCourseKnowledgeRelaEN.UpdDate, 20, conCaseCourseKnowledgeRela.UpdDate);
clsCheckSql.CheckFieldLen(objCaseCourseKnowledgeRelaEN.UpdUserId, 20, conCaseCourseKnowledgeRela.UpdUserId);
clsCheckSql.CheckFieldLen(objCaseCourseKnowledgeRelaEN.Memo, 1000, conCaseCourseKnowledgeRela.Memo);
//检查字段外键固定长度
 objCaseCourseKnowledgeRelaEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsCaseCourseKnowledgeRelaEN objCaseCourseKnowledgeRelaEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objCaseCourseKnowledgeRelaEN.FuncModuleId, 4, conCaseCourseKnowledgeRela.FuncModuleId);
clsCheckSql.CheckFieldLen(objCaseCourseKnowledgeRelaEN.CaseId, 8, conCaseCourseKnowledgeRela.CaseId);
clsCheckSql.CheckFieldLen(objCaseCourseKnowledgeRelaEN.CaseName, 100, conCaseCourseKnowledgeRela.CaseName);
clsCheckSql.CheckFieldLen(objCaseCourseKnowledgeRelaEN.OwnerId, 20, conCaseCourseKnowledgeRela.OwnerId);
clsCheckSql.CheckFieldLen(objCaseCourseKnowledgeRelaEN.CourseKnowledgeId, 8, conCaseCourseKnowledgeRela.CourseKnowledgeId);
clsCheckSql.CheckFieldLen(objCaseCourseKnowledgeRelaEN.IdCaseCourseKnowledgeRelaType, 4, conCaseCourseKnowledgeRela.IdCaseCourseKnowledgeRelaType);
clsCheckSql.CheckFieldLen(objCaseCourseKnowledgeRelaEN.UpdDate, 20, conCaseCourseKnowledgeRela.UpdDate);
clsCheckSql.CheckFieldLen(objCaseCourseKnowledgeRelaEN.UpdUserId, 20, conCaseCourseKnowledgeRela.UpdUserId);
clsCheckSql.CheckFieldLen(objCaseCourseKnowledgeRelaEN.Memo, 1000, conCaseCourseKnowledgeRela.Memo);
//检查外键字段长度
 objCaseCourseKnowledgeRelaEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsCaseCourseKnowledgeRelaEN objCaseCourseKnowledgeRelaEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objCaseCourseKnowledgeRelaEN.FuncModuleId, 4, conCaseCourseKnowledgeRela.FuncModuleId);
clsCheckSql.CheckFieldLen(objCaseCourseKnowledgeRelaEN.CaseId, 8, conCaseCourseKnowledgeRela.CaseId);
clsCheckSql.CheckFieldLen(objCaseCourseKnowledgeRelaEN.CaseName, 100, conCaseCourseKnowledgeRela.CaseName);
clsCheckSql.CheckFieldLen(objCaseCourseKnowledgeRelaEN.OwnerId, 20, conCaseCourseKnowledgeRela.OwnerId);
clsCheckSql.CheckFieldLen(objCaseCourseKnowledgeRelaEN.CourseKnowledgeId, 8, conCaseCourseKnowledgeRela.CourseKnowledgeId);
clsCheckSql.CheckFieldLen(objCaseCourseKnowledgeRelaEN.IdCaseCourseKnowledgeRelaType, 4, conCaseCourseKnowledgeRela.IdCaseCourseKnowledgeRelaType);
clsCheckSql.CheckFieldLen(objCaseCourseKnowledgeRelaEN.UpdDate, 20, conCaseCourseKnowledgeRela.UpdDate);
clsCheckSql.CheckFieldLen(objCaseCourseKnowledgeRelaEN.UpdUserId, 20, conCaseCourseKnowledgeRela.UpdUserId);
clsCheckSql.CheckFieldLen(objCaseCourseKnowledgeRelaEN.Memo, 1000, conCaseCourseKnowledgeRela.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objCaseCourseKnowledgeRelaEN.FuncModuleId, conCaseCourseKnowledgeRela.FuncModuleId);
clsCheckSql.CheckSqlInjection4Field(objCaseCourseKnowledgeRelaEN.CaseId, conCaseCourseKnowledgeRela.CaseId);
clsCheckSql.CheckSqlInjection4Field(objCaseCourseKnowledgeRelaEN.CaseName, conCaseCourseKnowledgeRela.CaseName);
clsCheckSql.CheckSqlInjection4Field(objCaseCourseKnowledgeRelaEN.OwnerId, conCaseCourseKnowledgeRela.OwnerId);
clsCheckSql.CheckSqlInjection4Field(objCaseCourseKnowledgeRelaEN.CourseKnowledgeId, conCaseCourseKnowledgeRela.CourseKnowledgeId);
clsCheckSql.CheckSqlInjection4Field(objCaseCourseKnowledgeRelaEN.IdCaseCourseKnowledgeRelaType, conCaseCourseKnowledgeRela.IdCaseCourseKnowledgeRelaType);
clsCheckSql.CheckSqlInjection4Field(objCaseCourseKnowledgeRelaEN.UpdDate, conCaseCourseKnowledgeRela.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objCaseCourseKnowledgeRelaEN.UpdUserId, conCaseCourseKnowledgeRela.UpdUserId);
clsCheckSql.CheckSqlInjection4Field(objCaseCourseKnowledgeRelaEN.Memo, conCaseCourseKnowledgeRela.Memo);
//检查外键字段长度
 objCaseCourseKnowledgeRelaEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--CaseCourseKnowledgeRela(案例知识点关系),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objCaseCourseKnowledgeRelaEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clsCaseCourseKnowledgeRelaEN objCaseCourseKnowledgeRelaEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and CaseId = '{0}'", objCaseCourseKnowledgeRelaEN.CaseId);
 if (objCaseCourseKnowledgeRelaEN.CourseKnowledgeId == null)
{
 sbCondition.AppendFormat(" and CourseKnowledgeId is null");
}
else
{
 sbCondition.AppendFormat(" and CourseKnowledgeId = '{0}'", objCaseCourseKnowledgeRelaEN.CourseKnowledgeId);
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
 objSQL = clsCaseCourseKnowledgeRelaDA.GetSpecSQLObj();
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
 objSQL = clsCaseCourseKnowledgeRelaDA.GetSpecSQLObj();
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
 objSQL = clsCaseCourseKnowledgeRelaDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsCaseCourseKnowledgeRelaEN._CurrTabName);
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
 objSQL = clsCaseCourseKnowledgeRelaDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsCaseCourseKnowledgeRelaEN._CurrTabName, strCondition);
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
 objSQL = clsCaseCourseKnowledgeRelaDA.GetSpecSQLObj();
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
 objSQL = clsCaseCourseKnowledgeRelaDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}