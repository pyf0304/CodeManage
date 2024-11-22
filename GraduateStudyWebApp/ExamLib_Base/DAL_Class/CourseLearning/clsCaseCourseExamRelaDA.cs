
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsCaseCourseExamRelaDA
 表名:CaseCourseExamRela(01120122)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:00:03
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
 /// 案例题库关系(CaseCourseExamRela)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsCaseCourseExamRelaDA : clsCommBase4DA
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
 return clsCaseCourseExamRelaEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsCaseCourseExamRelaEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsCaseCourseExamRelaEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsCaseCourseExamRelaEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsCaseCourseExamRelaEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsCaseCourseExamRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCaseCourseExamRelaDA.GetSpecSQLObj();
strSQL = "Select * from CaseCourseExamRela where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_CaseCourseExamRela(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsCaseCourseExamRelaDA: GetDataTable_CaseCourseExamRela)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCaseCourseExamRelaDA.GetSpecSQLObj();
strSQL = "Select * from CaseCourseExamRela where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsCaseCourseExamRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCaseCourseExamRelaDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsCaseCourseExamRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCaseCourseExamRelaDA.GetSpecSQLObj();
strSQL = "Select * from CaseCourseExamRela where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsCaseCourseExamRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCaseCourseExamRelaDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsCaseCourseExamRelaDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCaseCourseExamRelaDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from CaseCourseExamRela where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from CaseCourseExamRela where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsCaseCourseExamRelaDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCaseCourseExamRelaDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from CaseCourseExamRela where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsCaseCourseExamRelaDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCaseCourseExamRelaDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} CaseCourseExamRela.* from CaseCourseExamRela Left Join {1} on {2} where {3} and CaseCourseExamRela.IdCaseCourseExamRela not in (Select top {5} CaseCourseExamRela.IdCaseCourseExamRela from CaseCourseExamRela Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from CaseCourseExamRela where {1} and IdCaseCourseExamRela not in (Select top {2} IdCaseCourseExamRela from CaseCourseExamRela where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from CaseCourseExamRela where {1} and IdCaseCourseExamRela not in (Select top {3} IdCaseCourseExamRela from CaseCourseExamRela where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsCaseCourseExamRelaDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCaseCourseExamRelaDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} CaseCourseExamRela.* from CaseCourseExamRela Left Join {1} on {2} where {3} and CaseCourseExamRela.IdCaseCourseExamRela not in (Select top {5} CaseCourseExamRela.IdCaseCourseExamRela from CaseCourseExamRela Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from CaseCourseExamRela where {1} and IdCaseCourseExamRela not in (Select top {2} IdCaseCourseExamRela from CaseCourseExamRela where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from CaseCourseExamRela where {1} and IdCaseCourseExamRela not in (Select top {3} IdCaseCourseExamRela from CaseCourseExamRela where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsCaseCourseExamRelaEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsCaseCourseExamRelaDA:GetObjLst)", objException.Message));
}
List<clsCaseCourseExamRelaEN> arrObjLst = new List<clsCaseCourseExamRelaEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCaseCourseExamRelaDA.GetSpecSQLObj();
strSQL = "Select * from CaseCourseExamRela where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCaseCourseExamRelaEN objCaseCourseExamRelaEN = new clsCaseCourseExamRelaEN();
try
{
objCaseCourseExamRelaEN.IdCaseCourseExamRela = TransNullToInt(objRow[conCaseCourseExamRela.IdCaseCourseExamRela].ToString().Trim()); //案例题库关系流水号
objCaseCourseExamRelaEN.FuncModuleId = objRow[conCaseCourseExamRela.FuncModuleId].ToString().Trim(); //功能模块Id
objCaseCourseExamRelaEN.CaseId = objRow[conCaseCourseExamRela.CaseId].ToString().Trim(); //案例Id
objCaseCourseExamRelaEN.CaseName = objRow[conCaseCourseExamRela.CaseName].ToString().Trim(); //案例名称
objCaseCourseExamRelaEN.OwnerId = objRow[conCaseCourseExamRela.OwnerId] == DBNull.Value ? null : objRow[conCaseCourseExamRela.OwnerId].ToString().Trim(); //拥有者Id
objCaseCourseExamRelaEN.QuestionId = objRow[conCaseCourseExamRela.QuestionId] == DBNull.Value ? (long?)null : TransNullToInt(objRow[conCaseCourseExamRela.QuestionId].ToString().Trim()); //题目Id
objCaseCourseExamRelaEN.IdCaseCourseExamRelaType = objRow[conCaseCourseExamRela.IdCaseCourseExamRelaType].ToString().Trim(); //案例题库关系类型流水号
objCaseCourseExamRelaEN.StartTime = objRow[conCaseCourseExamRela.StartTime] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[conCaseCourseExamRela.StartTime].ToString().Trim()); //开始时间(s)
objCaseCourseExamRelaEN.BrowseCount = TransNullToInt(objRow[conCaseCourseExamRela.BrowseCount].ToString().Trim()); //浏览次数
objCaseCourseExamRelaEN.OrderNum = objRow[conCaseCourseExamRela.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conCaseCourseExamRela.OrderNum].ToString().Trim()); //序号
objCaseCourseExamRelaEN.UpdDate = objRow[conCaseCourseExamRela.UpdDate] == DBNull.Value ? null : objRow[conCaseCourseExamRela.UpdDate].ToString().Trim(); //修改日期
objCaseCourseExamRelaEN.UpdUserId = objRow[conCaseCourseExamRela.UpdUserId] == DBNull.Value ? null : objRow[conCaseCourseExamRela.UpdUserId].ToString().Trim(); //修改用户Id
objCaseCourseExamRelaEN.Memo = objRow[conCaseCourseExamRela.Memo] == DBNull.Value ? null : objRow[conCaseCourseExamRela.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsCaseCourseExamRelaDA: GetObjLst)", objException.Message));
}
objCaseCourseExamRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objCaseCourseExamRelaEN);
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
public List<clsCaseCourseExamRelaEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsCaseCourseExamRelaDA:GetObjLstByTabName)", objException.Message));
}
List<clsCaseCourseExamRelaEN> arrObjLst = new List<clsCaseCourseExamRelaEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCaseCourseExamRelaDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCaseCourseExamRelaEN objCaseCourseExamRelaEN = new clsCaseCourseExamRelaEN();
try
{
objCaseCourseExamRelaEN.IdCaseCourseExamRela = TransNullToInt(objRow[conCaseCourseExamRela.IdCaseCourseExamRela].ToString().Trim()); //案例题库关系流水号
objCaseCourseExamRelaEN.FuncModuleId = objRow[conCaseCourseExamRela.FuncModuleId].ToString().Trim(); //功能模块Id
objCaseCourseExamRelaEN.CaseId = objRow[conCaseCourseExamRela.CaseId].ToString().Trim(); //案例Id
objCaseCourseExamRelaEN.CaseName = objRow[conCaseCourseExamRela.CaseName].ToString().Trim(); //案例名称
objCaseCourseExamRelaEN.OwnerId = objRow[conCaseCourseExamRela.OwnerId] == DBNull.Value ? null : objRow[conCaseCourseExamRela.OwnerId].ToString().Trim(); //拥有者Id
objCaseCourseExamRelaEN.QuestionId = objRow[conCaseCourseExamRela.QuestionId] == DBNull.Value ? (long?)null : TransNullToInt(objRow[conCaseCourseExamRela.QuestionId].ToString().Trim()); //题目Id
objCaseCourseExamRelaEN.IdCaseCourseExamRelaType = objRow[conCaseCourseExamRela.IdCaseCourseExamRelaType].ToString().Trim(); //案例题库关系类型流水号
objCaseCourseExamRelaEN.StartTime = objRow[conCaseCourseExamRela.StartTime] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[conCaseCourseExamRela.StartTime].ToString().Trim()); //开始时间(s)
objCaseCourseExamRelaEN.BrowseCount = TransNullToInt(objRow[conCaseCourseExamRela.BrowseCount].ToString().Trim()); //浏览次数
objCaseCourseExamRelaEN.OrderNum = objRow[conCaseCourseExamRela.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conCaseCourseExamRela.OrderNum].ToString().Trim()); //序号
objCaseCourseExamRelaEN.UpdDate = objRow[conCaseCourseExamRela.UpdDate] == DBNull.Value ? null : objRow[conCaseCourseExamRela.UpdDate].ToString().Trim(); //修改日期
objCaseCourseExamRelaEN.UpdUserId = objRow[conCaseCourseExamRela.UpdUserId] == DBNull.Value ? null : objRow[conCaseCourseExamRela.UpdUserId].ToString().Trim(); //修改用户Id
objCaseCourseExamRelaEN.Memo = objRow[conCaseCourseExamRela.Memo] == DBNull.Value ? null : objRow[conCaseCourseExamRela.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsCaseCourseExamRelaDA: GetObjLst)", objException.Message));
}
objCaseCourseExamRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objCaseCourseExamRelaEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objCaseCourseExamRelaEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetCaseCourseExamRela(ref clsCaseCourseExamRelaEN objCaseCourseExamRelaEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCaseCourseExamRelaDA.GetSpecSQLObj();
strSQL = "Select * from CaseCourseExamRela where IdCaseCourseExamRela = " + ""+ objCaseCourseExamRelaEN.IdCaseCourseExamRela+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objCaseCourseExamRelaEN.IdCaseCourseExamRela = TransNullToInt(objDT.Rows[0][conCaseCourseExamRela.IdCaseCourseExamRela].ToString().Trim()); //案例题库关系流水号(字段类型:bigint,字段长度:8,是否可空:False)
 objCaseCourseExamRelaEN.FuncModuleId = objDT.Rows[0][conCaseCourseExamRela.FuncModuleId].ToString().Trim(); //功能模块Id(字段类型:char,字段长度:4,是否可空:True)
 objCaseCourseExamRelaEN.CaseId = objDT.Rows[0][conCaseCourseExamRela.CaseId].ToString().Trim(); //案例Id(字段类型:char,字段长度:8,是否可空:True)
 objCaseCourseExamRelaEN.CaseName = objDT.Rows[0][conCaseCourseExamRela.CaseName].ToString().Trim(); //案例名称(字段类型:varchar,字段长度:100,是否可空:True)
 objCaseCourseExamRelaEN.OwnerId = objDT.Rows[0][conCaseCourseExamRela.OwnerId].ToString().Trim(); //拥有者Id(字段类型:varchar,字段长度:20,是否可空:False)
 objCaseCourseExamRelaEN.QuestionId = TransNullToInt(objDT.Rows[0][conCaseCourseExamRela.QuestionId].ToString().Trim()); //题目Id(字段类型:bigint,字段长度:8,是否可空:True)
 objCaseCourseExamRelaEN.IdCaseCourseExamRelaType = objDT.Rows[0][conCaseCourseExamRela.IdCaseCourseExamRelaType].ToString().Trim(); //案例题库关系类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objCaseCourseExamRelaEN.StartTime = TransNullToDouble(objDT.Rows[0][conCaseCourseExamRela.StartTime].ToString().Trim()); //开始时间(s)(字段类型:decimal,字段长度:12,是否可空:False)
 objCaseCourseExamRelaEN.BrowseCount = TransNullToInt(objDT.Rows[0][conCaseCourseExamRela.BrowseCount].ToString().Trim()); //浏览次数(字段类型:int,字段长度:4,是否可空:True)
 objCaseCourseExamRelaEN.OrderNum = TransNullToInt(objDT.Rows[0][conCaseCourseExamRela.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:True)
 objCaseCourseExamRelaEN.UpdDate = objDT.Rows[0][conCaseCourseExamRela.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objCaseCourseExamRelaEN.UpdUserId = objDT.Rows[0][conCaseCourseExamRela.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:True)
 objCaseCourseExamRelaEN.Memo = objDT.Rows[0][conCaseCourseExamRela.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsCaseCourseExamRelaDA: GetCaseCourseExamRela)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngIdCaseCourseExamRela">表关键字</param>
 /// <returns>表对象</returns>
public clsCaseCourseExamRelaEN GetObjByIdCaseCourseExamRela(long lngIdCaseCourseExamRela)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCaseCourseExamRelaDA.GetSpecSQLObj();
strSQL = "Select * from CaseCourseExamRela where IdCaseCourseExamRela = " + ""+ lngIdCaseCourseExamRela+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsCaseCourseExamRelaEN objCaseCourseExamRelaEN = new clsCaseCourseExamRelaEN();
try
{
 objCaseCourseExamRelaEN.IdCaseCourseExamRela = Int32.Parse(objRow[conCaseCourseExamRela.IdCaseCourseExamRela].ToString().Trim()); //案例题库关系流水号(字段类型:bigint,字段长度:8,是否可空:False)
 objCaseCourseExamRelaEN.FuncModuleId = objRow[conCaseCourseExamRela.FuncModuleId].ToString().Trim(); //功能模块Id(字段类型:char,字段长度:4,是否可空:True)
 objCaseCourseExamRelaEN.CaseId = objRow[conCaseCourseExamRela.CaseId].ToString().Trim(); //案例Id(字段类型:char,字段长度:8,是否可空:True)
 objCaseCourseExamRelaEN.CaseName = objRow[conCaseCourseExamRela.CaseName].ToString().Trim(); //案例名称(字段类型:varchar,字段长度:100,是否可空:True)
 objCaseCourseExamRelaEN.OwnerId = objRow[conCaseCourseExamRela.OwnerId] == DBNull.Value ? null : objRow[conCaseCourseExamRela.OwnerId].ToString().Trim(); //拥有者Id(字段类型:varchar,字段长度:20,是否可空:False)
 objCaseCourseExamRelaEN.QuestionId = objRow[conCaseCourseExamRela.QuestionId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conCaseCourseExamRela.QuestionId].ToString().Trim()); //题目Id(字段类型:bigint,字段长度:8,是否可空:True)
 objCaseCourseExamRelaEN.IdCaseCourseExamRelaType = objRow[conCaseCourseExamRela.IdCaseCourseExamRelaType].ToString().Trim(); //案例题库关系类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objCaseCourseExamRelaEN.StartTime = objRow[conCaseCourseExamRela.StartTime] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conCaseCourseExamRela.StartTime].ToString().Trim()); //开始时间(s)(字段类型:decimal,字段长度:12,是否可空:False)
 objCaseCourseExamRelaEN.BrowseCount = Int32.Parse(objRow[conCaseCourseExamRela.BrowseCount].ToString().Trim()); //浏览次数(字段类型:int,字段长度:4,是否可空:True)
 objCaseCourseExamRelaEN.OrderNum = objRow[conCaseCourseExamRela.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCaseCourseExamRela.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:True)
 objCaseCourseExamRelaEN.UpdDate = objRow[conCaseCourseExamRela.UpdDate] == DBNull.Value ? null : objRow[conCaseCourseExamRela.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objCaseCourseExamRelaEN.UpdUserId = objRow[conCaseCourseExamRela.UpdUserId] == DBNull.Value ? null : objRow[conCaseCourseExamRela.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:True)
 objCaseCourseExamRelaEN.Memo = objRow[conCaseCourseExamRela.Memo] == DBNull.Value ? null : objRow[conCaseCourseExamRela.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsCaseCourseExamRelaDA: GetObjByIdCaseCourseExamRela)", objException.Message));
}
return objCaseCourseExamRelaEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsCaseCourseExamRelaEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsCaseCourseExamRelaDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCaseCourseExamRelaDA.GetSpecSQLObj();
strSQL = "Select * from CaseCourseExamRela where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsCaseCourseExamRelaEN objCaseCourseExamRelaEN = new clsCaseCourseExamRelaEN()
{
IdCaseCourseExamRela = TransNullToInt(objRow[conCaseCourseExamRela.IdCaseCourseExamRela].ToString().Trim()), //案例题库关系流水号
FuncModuleId = objRow[conCaseCourseExamRela.FuncModuleId].ToString().Trim(), //功能模块Id
CaseId = objRow[conCaseCourseExamRela.CaseId].ToString().Trim(), //案例Id
CaseName = objRow[conCaseCourseExamRela.CaseName].ToString().Trim(), //案例名称
OwnerId = objRow[conCaseCourseExamRela.OwnerId] == DBNull.Value ? null : objRow[conCaseCourseExamRela.OwnerId].ToString().Trim(), //拥有者Id
QuestionId = objRow[conCaseCourseExamRela.QuestionId] == DBNull.Value ? (long?)null : TransNullToInt(objRow[conCaseCourseExamRela.QuestionId].ToString().Trim()), //题目Id
IdCaseCourseExamRelaType = objRow[conCaseCourseExamRela.IdCaseCourseExamRelaType].ToString().Trim(), //案例题库关系类型流水号
StartTime = objRow[conCaseCourseExamRela.StartTime] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[conCaseCourseExamRela.StartTime].ToString().Trim()), //开始时间(s)
BrowseCount = TransNullToInt(objRow[conCaseCourseExamRela.BrowseCount].ToString().Trim()), //浏览次数
OrderNum = objRow[conCaseCourseExamRela.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conCaseCourseExamRela.OrderNum].ToString().Trim()), //序号
UpdDate = objRow[conCaseCourseExamRela.UpdDate] == DBNull.Value ? null : objRow[conCaseCourseExamRela.UpdDate].ToString().Trim(), //修改日期
UpdUserId = objRow[conCaseCourseExamRela.UpdUserId] == DBNull.Value ? null : objRow[conCaseCourseExamRela.UpdUserId].ToString().Trim(), //修改用户Id
Memo = objRow[conCaseCourseExamRela.Memo] == DBNull.Value ? null : objRow[conCaseCourseExamRela.Memo].ToString().Trim() //备注
};
objCaseCourseExamRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objCaseCourseExamRelaEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsCaseCourseExamRelaDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsCaseCourseExamRelaEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsCaseCourseExamRelaEN objCaseCourseExamRelaEN = new clsCaseCourseExamRelaEN();
try
{
objCaseCourseExamRelaEN.IdCaseCourseExamRela = TransNullToInt(objRow[conCaseCourseExamRela.IdCaseCourseExamRela].ToString().Trim()); //案例题库关系流水号
objCaseCourseExamRelaEN.FuncModuleId = objRow[conCaseCourseExamRela.FuncModuleId].ToString().Trim(); //功能模块Id
objCaseCourseExamRelaEN.CaseId = objRow[conCaseCourseExamRela.CaseId].ToString().Trim(); //案例Id
objCaseCourseExamRelaEN.CaseName = objRow[conCaseCourseExamRela.CaseName].ToString().Trim(); //案例名称
objCaseCourseExamRelaEN.OwnerId = objRow[conCaseCourseExamRela.OwnerId] == DBNull.Value ? null : objRow[conCaseCourseExamRela.OwnerId].ToString().Trim(); //拥有者Id
objCaseCourseExamRelaEN.QuestionId = objRow[conCaseCourseExamRela.QuestionId] == DBNull.Value ? (long?)null : TransNullToInt(objRow[conCaseCourseExamRela.QuestionId].ToString().Trim()); //题目Id
objCaseCourseExamRelaEN.IdCaseCourseExamRelaType = objRow[conCaseCourseExamRela.IdCaseCourseExamRelaType].ToString().Trim(); //案例题库关系类型流水号
objCaseCourseExamRelaEN.StartTime = objRow[conCaseCourseExamRela.StartTime] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[conCaseCourseExamRela.StartTime].ToString().Trim()); //开始时间(s)
objCaseCourseExamRelaEN.BrowseCount = TransNullToInt(objRow[conCaseCourseExamRela.BrowseCount].ToString().Trim()); //浏览次数
objCaseCourseExamRelaEN.OrderNum = objRow[conCaseCourseExamRela.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conCaseCourseExamRela.OrderNum].ToString().Trim()); //序号
objCaseCourseExamRelaEN.UpdDate = objRow[conCaseCourseExamRela.UpdDate] == DBNull.Value ? null : objRow[conCaseCourseExamRela.UpdDate].ToString().Trim(); //修改日期
objCaseCourseExamRelaEN.UpdUserId = objRow[conCaseCourseExamRela.UpdUserId] == DBNull.Value ? null : objRow[conCaseCourseExamRela.UpdUserId].ToString().Trim(); //修改用户Id
objCaseCourseExamRelaEN.Memo = objRow[conCaseCourseExamRela.Memo] == DBNull.Value ? null : objRow[conCaseCourseExamRela.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsCaseCourseExamRelaDA: GetObjByDataRowCaseCourseExamRela)", objException.Message));
}
objCaseCourseExamRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objCaseCourseExamRelaEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsCaseCourseExamRelaEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsCaseCourseExamRelaEN objCaseCourseExamRelaEN = new clsCaseCourseExamRelaEN();
try
{
objCaseCourseExamRelaEN.IdCaseCourseExamRela = TransNullToInt(objRow[conCaseCourseExamRela.IdCaseCourseExamRela].ToString().Trim()); //案例题库关系流水号
objCaseCourseExamRelaEN.FuncModuleId = objRow[conCaseCourseExamRela.FuncModuleId].ToString().Trim(); //功能模块Id
objCaseCourseExamRelaEN.CaseId = objRow[conCaseCourseExamRela.CaseId].ToString().Trim(); //案例Id
objCaseCourseExamRelaEN.CaseName = objRow[conCaseCourseExamRela.CaseName].ToString().Trim(); //案例名称
objCaseCourseExamRelaEN.OwnerId = objRow[conCaseCourseExamRela.OwnerId] == DBNull.Value ? null : objRow[conCaseCourseExamRela.OwnerId].ToString().Trim(); //拥有者Id
objCaseCourseExamRelaEN.QuestionId = objRow[conCaseCourseExamRela.QuestionId] == DBNull.Value ? (long?)null : TransNullToInt(objRow[conCaseCourseExamRela.QuestionId].ToString().Trim()); //题目Id
objCaseCourseExamRelaEN.IdCaseCourseExamRelaType = objRow[conCaseCourseExamRela.IdCaseCourseExamRelaType].ToString().Trim(); //案例题库关系类型流水号
objCaseCourseExamRelaEN.StartTime = objRow[conCaseCourseExamRela.StartTime] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[conCaseCourseExamRela.StartTime].ToString().Trim()); //开始时间(s)
objCaseCourseExamRelaEN.BrowseCount = TransNullToInt(objRow[conCaseCourseExamRela.BrowseCount].ToString().Trim()); //浏览次数
objCaseCourseExamRelaEN.OrderNum = objRow[conCaseCourseExamRela.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conCaseCourseExamRela.OrderNum].ToString().Trim()); //序号
objCaseCourseExamRelaEN.UpdDate = objRow[conCaseCourseExamRela.UpdDate] == DBNull.Value ? null : objRow[conCaseCourseExamRela.UpdDate].ToString().Trim(); //修改日期
objCaseCourseExamRelaEN.UpdUserId = objRow[conCaseCourseExamRela.UpdUserId] == DBNull.Value ? null : objRow[conCaseCourseExamRela.UpdUserId].ToString().Trim(); //修改用户Id
objCaseCourseExamRelaEN.Memo = objRow[conCaseCourseExamRela.Memo] == DBNull.Value ? null : objRow[conCaseCourseExamRela.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsCaseCourseExamRelaDA: GetObjByDataRow)", objException.Message));
}
objCaseCourseExamRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objCaseCourseExamRelaEN;
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
objSQL = clsCaseCourseExamRelaDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsCaseCourseExamRelaEN._CurrTabName, conCaseCourseExamRela.IdCaseCourseExamRela, 8, "");
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
objSQL = clsCaseCourseExamRelaDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsCaseCourseExamRelaEN._CurrTabName, conCaseCourseExamRela.IdCaseCourseExamRela, 8, strPrefix);
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
 objSQL = clsCaseCourseExamRelaDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select IdCaseCourseExamRela from CaseCourseExamRela where " + strCondition;
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
 objSQL = clsCaseCourseExamRelaDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select IdCaseCourseExamRela from CaseCourseExamRela where " + strCondition;
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
 /// <param name = "lngIdCaseCourseExamRela">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(long lngIdCaseCourseExamRela)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCaseCourseExamRelaDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("CaseCourseExamRela", "IdCaseCourseExamRela = " + ""+ lngIdCaseCourseExamRela+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsCaseCourseExamRelaDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCaseCourseExamRelaDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("CaseCourseExamRela", strCondition))
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
objSQL = clsCaseCourseExamRelaDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("CaseCourseExamRela");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsCaseCourseExamRelaEN objCaseCourseExamRelaEN)
 {
 objCaseCourseExamRelaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCaseCourseExamRelaEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objCaseCourseExamRelaEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCaseCourseExamRelaDA.GetSpecSQLObj();
strSQL = "Select * from CaseCourseExamRela where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "CaseCourseExamRela");
objRow = objDS.Tables["CaseCourseExamRela"].NewRow();
objRow[conCaseCourseExamRela.FuncModuleId] = objCaseCourseExamRelaEN.FuncModuleId; //功能模块Id
objRow[conCaseCourseExamRela.CaseId] = objCaseCourseExamRelaEN.CaseId; //案例Id
objRow[conCaseCourseExamRela.CaseName] = objCaseCourseExamRelaEN.CaseName; //案例名称
 if (objCaseCourseExamRelaEN.OwnerId !=  "")
 {
objRow[conCaseCourseExamRela.OwnerId] = objCaseCourseExamRelaEN.OwnerId; //拥有者Id
 }
objRow[conCaseCourseExamRela.QuestionId] = objCaseCourseExamRelaEN.QuestionId; //题目Id
objRow[conCaseCourseExamRela.IdCaseCourseExamRelaType] = objCaseCourseExamRelaEN.IdCaseCourseExamRelaType; //案例题库关系类型流水号
objRow[conCaseCourseExamRela.StartTime] = objCaseCourseExamRelaEN.StartTime; //开始时间(s)
objRow[conCaseCourseExamRela.BrowseCount] = objCaseCourseExamRelaEN.BrowseCount; //浏览次数
objRow[conCaseCourseExamRela.OrderNum] = objCaseCourseExamRelaEN.OrderNum; //序号
 if (objCaseCourseExamRelaEN.UpdDate !=  "")
 {
objRow[conCaseCourseExamRela.UpdDate] = objCaseCourseExamRelaEN.UpdDate; //修改日期
 }
 if (objCaseCourseExamRelaEN.UpdUserId !=  "")
 {
objRow[conCaseCourseExamRela.UpdUserId] = objCaseCourseExamRelaEN.UpdUserId; //修改用户Id
 }
 if (objCaseCourseExamRelaEN.Memo !=  "")
 {
objRow[conCaseCourseExamRela.Memo] = objCaseCourseExamRelaEN.Memo; //备注
 }
objDS.Tables[clsCaseCourseExamRelaEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsCaseCourseExamRelaEN._CurrTabName);
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
 /// <param name = "objCaseCourseExamRelaEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsCaseCourseExamRelaEN objCaseCourseExamRelaEN)
{
 objCaseCourseExamRelaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCaseCourseExamRelaEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objCaseCourseExamRelaEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objCaseCourseExamRelaEN.FuncModuleId !=  null)
 {
 arrFieldListForInsert.Add(conCaseCourseExamRela.FuncModuleId);
 var strFuncModuleId = objCaseCourseExamRelaEN.FuncModuleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncModuleId + "'");
 }
 
 if (objCaseCourseExamRelaEN.CaseId !=  null)
 {
 arrFieldListForInsert.Add(conCaseCourseExamRela.CaseId);
 var strCaseId = objCaseCourseExamRelaEN.CaseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCaseId + "'");
 }
 
 if (objCaseCourseExamRelaEN.CaseName !=  null)
 {
 arrFieldListForInsert.Add(conCaseCourseExamRela.CaseName);
 var strCaseName = objCaseCourseExamRelaEN.CaseName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCaseName + "'");
 }
 
 if (objCaseCourseExamRelaEN.OwnerId !=  null)
 {
 arrFieldListForInsert.Add(conCaseCourseExamRela.OwnerId);
 var strOwnerId = objCaseCourseExamRelaEN.OwnerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strOwnerId + "'");
 }
 
 if (objCaseCourseExamRelaEN.QuestionId !=  null)
 {
 arrFieldListForInsert.Add(conCaseCourseExamRela.QuestionId);
 arrValueListForInsert.Add(objCaseCourseExamRelaEN.QuestionId.ToString());
 }
 
 if (objCaseCourseExamRelaEN.IdCaseCourseExamRelaType !=  null)
 {
 arrFieldListForInsert.Add(conCaseCourseExamRela.IdCaseCourseExamRelaType);
 var strIdCaseCourseExamRelaType = objCaseCourseExamRelaEN.IdCaseCourseExamRelaType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCaseCourseExamRelaType + "'");
 }
 
 if (objCaseCourseExamRelaEN.StartTime !=  null)
 {
 arrFieldListForInsert.Add(conCaseCourseExamRela.StartTime);
 arrValueListForInsert.Add(objCaseCourseExamRelaEN.StartTime.ToString());
 }
 
 arrFieldListForInsert.Add(conCaseCourseExamRela.BrowseCount);
 arrValueListForInsert.Add(objCaseCourseExamRelaEN.BrowseCount.ToString());
 
 if (objCaseCourseExamRelaEN.OrderNum !=  null)
 {
 arrFieldListForInsert.Add(conCaseCourseExamRela.OrderNum);
 arrValueListForInsert.Add(objCaseCourseExamRelaEN.OrderNum.ToString());
 }
 
 if (objCaseCourseExamRelaEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conCaseCourseExamRela.UpdDate);
 var strUpdDate = objCaseCourseExamRelaEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objCaseCourseExamRelaEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(conCaseCourseExamRela.UpdUserId);
 var strUpdUserId = objCaseCourseExamRelaEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objCaseCourseExamRelaEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conCaseCourseExamRela.Memo);
 var strMemo = objCaseCourseExamRelaEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into CaseCourseExamRela");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCaseCourseExamRelaDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objCaseCourseExamRelaEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsCaseCourseExamRelaEN objCaseCourseExamRelaEN)
{
 objCaseCourseExamRelaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCaseCourseExamRelaEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objCaseCourseExamRelaEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objCaseCourseExamRelaEN.FuncModuleId !=  null)
 {
 arrFieldListForInsert.Add(conCaseCourseExamRela.FuncModuleId);
 var strFuncModuleId = objCaseCourseExamRelaEN.FuncModuleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncModuleId + "'");
 }
 
 if (objCaseCourseExamRelaEN.CaseId !=  null)
 {
 arrFieldListForInsert.Add(conCaseCourseExamRela.CaseId);
 var strCaseId = objCaseCourseExamRelaEN.CaseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCaseId + "'");
 }
 
 if (objCaseCourseExamRelaEN.CaseName !=  null)
 {
 arrFieldListForInsert.Add(conCaseCourseExamRela.CaseName);
 var strCaseName = objCaseCourseExamRelaEN.CaseName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCaseName + "'");
 }
 
 if (objCaseCourseExamRelaEN.OwnerId !=  null)
 {
 arrFieldListForInsert.Add(conCaseCourseExamRela.OwnerId);
 var strOwnerId = objCaseCourseExamRelaEN.OwnerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strOwnerId + "'");
 }
 
 if (objCaseCourseExamRelaEN.QuestionId !=  null)
 {
 arrFieldListForInsert.Add(conCaseCourseExamRela.QuestionId);
 arrValueListForInsert.Add(objCaseCourseExamRelaEN.QuestionId.ToString());
 }
 
 if (objCaseCourseExamRelaEN.IdCaseCourseExamRelaType !=  null)
 {
 arrFieldListForInsert.Add(conCaseCourseExamRela.IdCaseCourseExamRelaType);
 var strIdCaseCourseExamRelaType = objCaseCourseExamRelaEN.IdCaseCourseExamRelaType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCaseCourseExamRelaType + "'");
 }
 
 if (objCaseCourseExamRelaEN.StartTime !=  null)
 {
 arrFieldListForInsert.Add(conCaseCourseExamRela.StartTime);
 arrValueListForInsert.Add(objCaseCourseExamRelaEN.StartTime.ToString());
 }
 
 arrFieldListForInsert.Add(conCaseCourseExamRela.BrowseCount);
 arrValueListForInsert.Add(objCaseCourseExamRelaEN.BrowseCount.ToString());
 
 if (objCaseCourseExamRelaEN.OrderNum !=  null)
 {
 arrFieldListForInsert.Add(conCaseCourseExamRela.OrderNum);
 arrValueListForInsert.Add(objCaseCourseExamRelaEN.OrderNum.ToString());
 }
 
 if (objCaseCourseExamRelaEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conCaseCourseExamRela.UpdDate);
 var strUpdDate = objCaseCourseExamRelaEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objCaseCourseExamRelaEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(conCaseCourseExamRela.UpdUserId);
 var strUpdUserId = objCaseCourseExamRelaEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objCaseCourseExamRelaEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conCaseCourseExamRela.Memo);
 var strMemo = objCaseCourseExamRelaEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into CaseCourseExamRela");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCaseCourseExamRelaDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString()).Rows[0][0].ToString();
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objCaseCourseExamRelaEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsCaseCourseExamRelaEN objCaseCourseExamRelaEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objCaseCourseExamRelaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCaseCourseExamRelaEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objCaseCourseExamRelaEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objCaseCourseExamRelaEN.FuncModuleId !=  null)
 {
 arrFieldListForInsert.Add(conCaseCourseExamRela.FuncModuleId);
 var strFuncModuleId = objCaseCourseExamRelaEN.FuncModuleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncModuleId + "'");
 }
 
 if (objCaseCourseExamRelaEN.CaseId !=  null)
 {
 arrFieldListForInsert.Add(conCaseCourseExamRela.CaseId);
 var strCaseId = objCaseCourseExamRelaEN.CaseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCaseId + "'");
 }
 
 if (objCaseCourseExamRelaEN.CaseName !=  null)
 {
 arrFieldListForInsert.Add(conCaseCourseExamRela.CaseName);
 var strCaseName = objCaseCourseExamRelaEN.CaseName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCaseName + "'");
 }
 
 if (objCaseCourseExamRelaEN.OwnerId !=  null)
 {
 arrFieldListForInsert.Add(conCaseCourseExamRela.OwnerId);
 var strOwnerId = objCaseCourseExamRelaEN.OwnerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strOwnerId + "'");
 }
 
 if (objCaseCourseExamRelaEN.QuestionId !=  null)
 {
 arrFieldListForInsert.Add(conCaseCourseExamRela.QuestionId);
 arrValueListForInsert.Add(objCaseCourseExamRelaEN.QuestionId.ToString());
 }
 
 if (objCaseCourseExamRelaEN.IdCaseCourseExamRelaType !=  null)
 {
 arrFieldListForInsert.Add(conCaseCourseExamRela.IdCaseCourseExamRelaType);
 var strIdCaseCourseExamRelaType = objCaseCourseExamRelaEN.IdCaseCourseExamRelaType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCaseCourseExamRelaType + "'");
 }
 
 if (objCaseCourseExamRelaEN.StartTime !=  null)
 {
 arrFieldListForInsert.Add(conCaseCourseExamRela.StartTime);
 arrValueListForInsert.Add(objCaseCourseExamRelaEN.StartTime.ToString());
 }
 
 arrFieldListForInsert.Add(conCaseCourseExamRela.BrowseCount);
 arrValueListForInsert.Add(objCaseCourseExamRelaEN.BrowseCount.ToString());
 
 if (objCaseCourseExamRelaEN.OrderNum !=  null)
 {
 arrFieldListForInsert.Add(conCaseCourseExamRela.OrderNum);
 arrValueListForInsert.Add(objCaseCourseExamRelaEN.OrderNum.ToString());
 }
 
 if (objCaseCourseExamRelaEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conCaseCourseExamRela.UpdDate);
 var strUpdDate = objCaseCourseExamRelaEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objCaseCourseExamRelaEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(conCaseCourseExamRela.UpdUserId);
 var strUpdUserId = objCaseCourseExamRelaEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objCaseCourseExamRelaEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conCaseCourseExamRela.Memo);
 var strMemo = objCaseCourseExamRelaEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into CaseCourseExamRela");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCaseCourseExamRelaDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString(), objSqlConnection, objSqlTransaction).Rows[0][0].ToString();
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objCaseCourseExamRelaEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsCaseCourseExamRelaEN objCaseCourseExamRelaEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objCaseCourseExamRelaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCaseCourseExamRelaEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objCaseCourseExamRelaEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objCaseCourseExamRelaEN.FuncModuleId !=  null)
 {
 arrFieldListForInsert.Add(conCaseCourseExamRela.FuncModuleId);
 var strFuncModuleId = objCaseCourseExamRelaEN.FuncModuleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncModuleId + "'");
 }
 
 if (objCaseCourseExamRelaEN.CaseId !=  null)
 {
 arrFieldListForInsert.Add(conCaseCourseExamRela.CaseId);
 var strCaseId = objCaseCourseExamRelaEN.CaseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCaseId + "'");
 }
 
 if (objCaseCourseExamRelaEN.CaseName !=  null)
 {
 arrFieldListForInsert.Add(conCaseCourseExamRela.CaseName);
 var strCaseName = objCaseCourseExamRelaEN.CaseName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCaseName + "'");
 }
 
 if (objCaseCourseExamRelaEN.OwnerId !=  null)
 {
 arrFieldListForInsert.Add(conCaseCourseExamRela.OwnerId);
 var strOwnerId = objCaseCourseExamRelaEN.OwnerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strOwnerId + "'");
 }
 
 if (objCaseCourseExamRelaEN.QuestionId !=  null)
 {
 arrFieldListForInsert.Add(conCaseCourseExamRela.QuestionId);
 arrValueListForInsert.Add(objCaseCourseExamRelaEN.QuestionId.ToString());
 }
 
 if (objCaseCourseExamRelaEN.IdCaseCourseExamRelaType !=  null)
 {
 arrFieldListForInsert.Add(conCaseCourseExamRela.IdCaseCourseExamRelaType);
 var strIdCaseCourseExamRelaType = objCaseCourseExamRelaEN.IdCaseCourseExamRelaType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCaseCourseExamRelaType + "'");
 }
 
 if (objCaseCourseExamRelaEN.StartTime !=  null)
 {
 arrFieldListForInsert.Add(conCaseCourseExamRela.StartTime);
 arrValueListForInsert.Add(objCaseCourseExamRelaEN.StartTime.ToString());
 }
 
 arrFieldListForInsert.Add(conCaseCourseExamRela.BrowseCount);
 arrValueListForInsert.Add(objCaseCourseExamRelaEN.BrowseCount.ToString());
 
 if (objCaseCourseExamRelaEN.OrderNum !=  null)
 {
 arrFieldListForInsert.Add(conCaseCourseExamRela.OrderNum);
 arrValueListForInsert.Add(objCaseCourseExamRelaEN.OrderNum.ToString());
 }
 
 if (objCaseCourseExamRelaEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conCaseCourseExamRela.UpdDate);
 var strUpdDate = objCaseCourseExamRelaEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objCaseCourseExamRelaEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(conCaseCourseExamRela.UpdUserId);
 var strUpdUserId = objCaseCourseExamRelaEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objCaseCourseExamRelaEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conCaseCourseExamRela.Memo);
 var strMemo = objCaseCourseExamRelaEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into CaseCourseExamRela");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCaseCourseExamRelaDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewCaseCourseExamRelas(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCaseCourseExamRelaDA.GetSpecSQLObj();
strSQL = "Select * from CaseCourseExamRela where IdCaseCourseExamRela = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "CaseCourseExamRela");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
long lngIdCaseCourseExamRela = TransNullToInt(oRow[conCaseCourseExamRela.IdCaseCourseExamRela].ToString().Trim());
if (IsExist(lngIdCaseCourseExamRela))
{
 string strResult = "关键字变量值为:" + string.Format("IdCaseCourseExamRela = {0}", lngIdCaseCourseExamRela) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsCaseCourseExamRelaEN._CurrTabName ].NewRow();
objRow[conCaseCourseExamRela.FuncModuleId] = oRow[conCaseCourseExamRela.FuncModuleId].ToString().Trim(); //功能模块Id
objRow[conCaseCourseExamRela.CaseId] = oRow[conCaseCourseExamRela.CaseId].ToString().Trim(); //案例Id
objRow[conCaseCourseExamRela.CaseName] = oRow[conCaseCourseExamRela.CaseName].ToString().Trim(); //案例名称
objRow[conCaseCourseExamRela.OwnerId] = oRow[conCaseCourseExamRela.OwnerId].ToString().Trim(); //拥有者Id
objRow[conCaseCourseExamRela.QuestionId] = oRow[conCaseCourseExamRela.QuestionId].ToString().Trim(); //题目Id
objRow[conCaseCourseExamRela.IdCaseCourseExamRelaType] = oRow[conCaseCourseExamRela.IdCaseCourseExamRelaType].ToString().Trim(); //案例题库关系类型流水号
objRow[conCaseCourseExamRela.StartTime] = oRow[conCaseCourseExamRela.StartTime].ToString().Trim(); //开始时间(s)
objRow[conCaseCourseExamRela.BrowseCount] = oRow[conCaseCourseExamRela.BrowseCount].ToString().Trim(); //浏览次数
objRow[conCaseCourseExamRela.OrderNum] = oRow[conCaseCourseExamRela.OrderNum].ToString().Trim(); //序号
objRow[conCaseCourseExamRela.UpdDate] = oRow[conCaseCourseExamRela.UpdDate].ToString().Trim(); //修改日期
objRow[conCaseCourseExamRela.UpdUserId] = oRow[conCaseCourseExamRela.UpdUserId].ToString().Trim(); //修改用户Id
objRow[conCaseCourseExamRela.Memo] = oRow[conCaseCourseExamRela.Memo].ToString().Trim(); //备注
 objDS.Tables[clsCaseCourseExamRelaEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsCaseCourseExamRelaEN._CurrTabName);
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
 /// <param name = "objCaseCourseExamRelaEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsCaseCourseExamRelaEN objCaseCourseExamRelaEN)
{
 objCaseCourseExamRelaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCaseCourseExamRelaEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objCaseCourseExamRelaEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCaseCourseExamRelaDA.GetSpecSQLObj();
strSQL = "Select * from CaseCourseExamRela where IdCaseCourseExamRela = " + ""+ objCaseCourseExamRelaEN.IdCaseCourseExamRela+"";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsCaseCourseExamRelaEN._CurrTabName);
if (objDS.Tables[clsCaseCourseExamRelaEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:IdCaseCourseExamRela = " + ""+ objCaseCourseExamRelaEN.IdCaseCourseExamRela+"");
return false;
}
objRow = objDS.Tables[clsCaseCourseExamRelaEN._CurrTabName].Rows[0];
 if (objCaseCourseExamRelaEN.IsUpdated(conCaseCourseExamRela.FuncModuleId))
 {
objRow[conCaseCourseExamRela.FuncModuleId] = objCaseCourseExamRelaEN.FuncModuleId; //功能模块Id
 }
 if (objCaseCourseExamRelaEN.IsUpdated(conCaseCourseExamRela.CaseId))
 {
objRow[conCaseCourseExamRela.CaseId] = objCaseCourseExamRelaEN.CaseId; //案例Id
 }
 if (objCaseCourseExamRelaEN.IsUpdated(conCaseCourseExamRela.CaseName))
 {
objRow[conCaseCourseExamRela.CaseName] = objCaseCourseExamRelaEN.CaseName; //案例名称
 }
 if (objCaseCourseExamRelaEN.IsUpdated(conCaseCourseExamRela.OwnerId))
 {
objRow[conCaseCourseExamRela.OwnerId] = objCaseCourseExamRelaEN.OwnerId; //拥有者Id
 }
 if (objCaseCourseExamRelaEN.IsUpdated(conCaseCourseExamRela.QuestionId))
 {
objRow[conCaseCourseExamRela.QuestionId] = objCaseCourseExamRelaEN.QuestionId; //题目Id
 }
 if (objCaseCourseExamRelaEN.IsUpdated(conCaseCourseExamRela.IdCaseCourseExamRelaType))
 {
objRow[conCaseCourseExamRela.IdCaseCourseExamRelaType] = objCaseCourseExamRelaEN.IdCaseCourseExamRelaType; //案例题库关系类型流水号
 }
 if (objCaseCourseExamRelaEN.IsUpdated(conCaseCourseExamRela.StartTime))
 {
objRow[conCaseCourseExamRela.StartTime] = objCaseCourseExamRelaEN.StartTime; //开始时间(s)
 }
 if (objCaseCourseExamRelaEN.IsUpdated(conCaseCourseExamRela.BrowseCount))
 {
objRow[conCaseCourseExamRela.BrowseCount] = objCaseCourseExamRelaEN.BrowseCount; //浏览次数
 }
 if (objCaseCourseExamRelaEN.IsUpdated(conCaseCourseExamRela.OrderNum))
 {
objRow[conCaseCourseExamRela.OrderNum] = objCaseCourseExamRelaEN.OrderNum; //序号
 }
 if (objCaseCourseExamRelaEN.IsUpdated(conCaseCourseExamRela.UpdDate))
 {
objRow[conCaseCourseExamRela.UpdDate] = objCaseCourseExamRelaEN.UpdDate; //修改日期
 }
 if (objCaseCourseExamRelaEN.IsUpdated(conCaseCourseExamRela.UpdUserId))
 {
objRow[conCaseCourseExamRela.UpdUserId] = objCaseCourseExamRelaEN.UpdUserId; //修改用户Id
 }
 if (objCaseCourseExamRelaEN.IsUpdated(conCaseCourseExamRela.Memo))
 {
objRow[conCaseCourseExamRela.Memo] = objCaseCourseExamRelaEN.Memo; //备注
 }
try
{
objDA.Update(objDS, clsCaseCourseExamRelaEN._CurrTabName);
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
 /// <param name = "objCaseCourseExamRelaEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsCaseCourseExamRelaEN objCaseCourseExamRelaEN)
{
 objCaseCourseExamRelaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCaseCourseExamRelaEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objCaseCourseExamRelaEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCaseCourseExamRelaDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update CaseCourseExamRela Set ");
 
 if (objCaseCourseExamRelaEN.IsUpdated(conCaseCourseExamRela.FuncModuleId))
 {
 if (objCaseCourseExamRelaEN.FuncModuleId !=  null)
 {
 var strFuncModuleId = objCaseCourseExamRelaEN.FuncModuleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFuncModuleId, conCaseCourseExamRela.FuncModuleId); //功能模块Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCaseCourseExamRela.FuncModuleId); //功能模块Id
 }
 }
 
 if (objCaseCourseExamRelaEN.IsUpdated(conCaseCourseExamRela.CaseId))
 {
 if (objCaseCourseExamRelaEN.CaseId !=  null)
 {
 var strCaseId = objCaseCourseExamRelaEN.CaseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCaseId, conCaseCourseExamRela.CaseId); //案例Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCaseCourseExamRela.CaseId); //案例Id
 }
 }
 
 if (objCaseCourseExamRelaEN.IsUpdated(conCaseCourseExamRela.CaseName))
 {
 if (objCaseCourseExamRelaEN.CaseName !=  null)
 {
 var strCaseName = objCaseCourseExamRelaEN.CaseName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCaseName, conCaseCourseExamRela.CaseName); //案例名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCaseCourseExamRela.CaseName); //案例名称
 }
 }
 
 if (objCaseCourseExamRelaEN.IsUpdated(conCaseCourseExamRela.OwnerId))
 {
 if (objCaseCourseExamRelaEN.OwnerId !=  null)
 {
 var strOwnerId = objCaseCourseExamRelaEN.OwnerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strOwnerId, conCaseCourseExamRela.OwnerId); //拥有者Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCaseCourseExamRela.OwnerId); //拥有者Id
 }
 }
 
 if (objCaseCourseExamRelaEN.IsUpdated(conCaseCourseExamRela.QuestionId))
 {
 if (objCaseCourseExamRelaEN.QuestionId !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCaseCourseExamRelaEN.QuestionId, conCaseCourseExamRela.QuestionId); //题目Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCaseCourseExamRela.QuestionId); //题目Id
 }
 }
 
 if (objCaseCourseExamRelaEN.IsUpdated(conCaseCourseExamRela.IdCaseCourseExamRelaType))
 {
 if (objCaseCourseExamRelaEN.IdCaseCourseExamRelaType !=  null)
 {
 var strIdCaseCourseExamRelaType = objCaseCourseExamRelaEN.IdCaseCourseExamRelaType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdCaseCourseExamRelaType, conCaseCourseExamRela.IdCaseCourseExamRelaType); //案例题库关系类型流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCaseCourseExamRela.IdCaseCourseExamRelaType); //案例题库关系类型流水号
 }
 }
 
 if (objCaseCourseExamRelaEN.IsUpdated(conCaseCourseExamRela.StartTime))
 {
 if (objCaseCourseExamRelaEN.StartTime !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCaseCourseExamRelaEN.StartTime, conCaseCourseExamRela.StartTime); //开始时间(s)
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCaseCourseExamRela.StartTime); //开始时间(s)
 }
 }
 
 if (objCaseCourseExamRelaEN.IsUpdated(conCaseCourseExamRela.BrowseCount))
 {
 sbSQL.AppendFormat("{1} = {0},",objCaseCourseExamRelaEN.BrowseCount, conCaseCourseExamRela.BrowseCount); //浏览次数
 }
 
 if (objCaseCourseExamRelaEN.IsUpdated(conCaseCourseExamRela.OrderNum))
 {
 if (objCaseCourseExamRelaEN.OrderNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCaseCourseExamRelaEN.OrderNum, conCaseCourseExamRela.OrderNum); //序号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCaseCourseExamRela.OrderNum); //序号
 }
 }
 
 if (objCaseCourseExamRelaEN.IsUpdated(conCaseCourseExamRela.UpdDate))
 {
 if (objCaseCourseExamRelaEN.UpdDate !=  null)
 {
 var strUpdDate = objCaseCourseExamRelaEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conCaseCourseExamRela.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCaseCourseExamRela.UpdDate); //修改日期
 }
 }
 
 if (objCaseCourseExamRelaEN.IsUpdated(conCaseCourseExamRela.UpdUserId))
 {
 if (objCaseCourseExamRelaEN.UpdUserId !=  null)
 {
 var strUpdUserId = objCaseCourseExamRelaEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUserId, conCaseCourseExamRela.UpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCaseCourseExamRela.UpdUserId); //修改用户Id
 }
 }
 
 if (objCaseCourseExamRelaEN.IsUpdated(conCaseCourseExamRela.Memo))
 {
 if (objCaseCourseExamRelaEN.Memo !=  null)
 {
 var strMemo = objCaseCourseExamRelaEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conCaseCourseExamRela.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCaseCourseExamRela.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where IdCaseCourseExamRela = {0}", objCaseCourseExamRelaEN.IdCaseCourseExamRela); 
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
 /// <param name = "objCaseCourseExamRelaEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsCaseCourseExamRelaEN objCaseCourseExamRelaEN, string strCondition)
{
 objCaseCourseExamRelaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCaseCourseExamRelaEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objCaseCourseExamRelaEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCaseCourseExamRelaDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update CaseCourseExamRela Set ");
 
 if (objCaseCourseExamRelaEN.IsUpdated(conCaseCourseExamRela.FuncModuleId))
 {
 if (objCaseCourseExamRelaEN.FuncModuleId !=  null)
 {
 var strFuncModuleId = objCaseCourseExamRelaEN.FuncModuleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FuncModuleId = '{0}',", strFuncModuleId); //功能模块Id
 }
 else
 {
 sbSQL.Append(" FuncModuleId = null,"); //功能模块Id
 }
 }
 
 if (objCaseCourseExamRelaEN.IsUpdated(conCaseCourseExamRela.CaseId))
 {
 if (objCaseCourseExamRelaEN.CaseId !=  null)
 {
 var strCaseId = objCaseCourseExamRelaEN.CaseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CaseId = '{0}',", strCaseId); //案例Id
 }
 else
 {
 sbSQL.Append(" CaseId = null,"); //案例Id
 }
 }
 
 if (objCaseCourseExamRelaEN.IsUpdated(conCaseCourseExamRela.CaseName))
 {
 if (objCaseCourseExamRelaEN.CaseName !=  null)
 {
 var strCaseName = objCaseCourseExamRelaEN.CaseName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CaseName = '{0}',", strCaseName); //案例名称
 }
 else
 {
 sbSQL.Append(" CaseName = null,"); //案例名称
 }
 }
 
 if (objCaseCourseExamRelaEN.IsUpdated(conCaseCourseExamRela.OwnerId))
 {
 if (objCaseCourseExamRelaEN.OwnerId !=  null)
 {
 var strOwnerId = objCaseCourseExamRelaEN.OwnerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" OwnerId = '{0}',", strOwnerId); //拥有者Id
 }
 else
 {
 sbSQL.Append(" OwnerId = null,"); //拥有者Id
 }
 }
 
 if (objCaseCourseExamRelaEN.IsUpdated(conCaseCourseExamRela.QuestionId))
 {
 if (objCaseCourseExamRelaEN.QuestionId !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCaseCourseExamRelaEN.QuestionId, conCaseCourseExamRela.QuestionId); //题目Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCaseCourseExamRela.QuestionId); //题目Id
 }
 }
 
 if (objCaseCourseExamRelaEN.IsUpdated(conCaseCourseExamRela.IdCaseCourseExamRelaType))
 {
 if (objCaseCourseExamRelaEN.IdCaseCourseExamRelaType !=  null)
 {
 var strIdCaseCourseExamRelaType = objCaseCourseExamRelaEN.IdCaseCourseExamRelaType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdCaseCourseExamRelaType = '{0}',", strIdCaseCourseExamRelaType); //案例题库关系类型流水号
 }
 else
 {
 sbSQL.Append(" IdCaseCourseExamRelaType = null,"); //案例题库关系类型流水号
 }
 }
 
 if (objCaseCourseExamRelaEN.IsUpdated(conCaseCourseExamRela.StartTime))
 {
 if (objCaseCourseExamRelaEN.StartTime !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCaseCourseExamRelaEN.StartTime, conCaseCourseExamRela.StartTime); //开始时间(s)
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCaseCourseExamRela.StartTime); //开始时间(s)
 }
 }
 
 if (objCaseCourseExamRelaEN.IsUpdated(conCaseCourseExamRela.BrowseCount))
 {
 sbSQL.AppendFormat(" BrowseCount = {0},", objCaseCourseExamRelaEN.BrowseCount); //浏览次数
 }
 
 if (objCaseCourseExamRelaEN.IsUpdated(conCaseCourseExamRela.OrderNum))
 {
 if (objCaseCourseExamRelaEN.OrderNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCaseCourseExamRelaEN.OrderNum, conCaseCourseExamRela.OrderNum); //序号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCaseCourseExamRela.OrderNum); //序号
 }
 }
 
 if (objCaseCourseExamRelaEN.IsUpdated(conCaseCourseExamRela.UpdDate))
 {
 if (objCaseCourseExamRelaEN.UpdDate !=  null)
 {
 var strUpdDate = objCaseCourseExamRelaEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objCaseCourseExamRelaEN.IsUpdated(conCaseCourseExamRela.UpdUserId))
 {
 if (objCaseCourseExamRelaEN.UpdUserId !=  null)
 {
 var strUpdUserId = objCaseCourseExamRelaEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUserId = '{0}',", strUpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.Append(" UpdUserId = null,"); //修改用户Id
 }
 }
 
 if (objCaseCourseExamRelaEN.IsUpdated(conCaseCourseExamRela.Memo))
 {
 if (objCaseCourseExamRelaEN.Memo !=  null)
 {
 var strMemo = objCaseCourseExamRelaEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objCaseCourseExamRelaEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsCaseCourseExamRelaEN objCaseCourseExamRelaEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objCaseCourseExamRelaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCaseCourseExamRelaEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objCaseCourseExamRelaEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCaseCourseExamRelaDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update CaseCourseExamRela Set ");
 
 if (objCaseCourseExamRelaEN.IsUpdated(conCaseCourseExamRela.FuncModuleId))
 {
 if (objCaseCourseExamRelaEN.FuncModuleId !=  null)
 {
 var strFuncModuleId = objCaseCourseExamRelaEN.FuncModuleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FuncModuleId = '{0}',", strFuncModuleId); //功能模块Id
 }
 else
 {
 sbSQL.Append(" FuncModuleId = null,"); //功能模块Id
 }
 }
 
 if (objCaseCourseExamRelaEN.IsUpdated(conCaseCourseExamRela.CaseId))
 {
 if (objCaseCourseExamRelaEN.CaseId !=  null)
 {
 var strCaseId = objCaseCourseExamRelaEN.CaseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CaseId = '{0}',", strCaseId); //案例Id
 }
 else
 {
 sbSQL.Append(" CaseId = null,"); //案例Id
 }
 }
 
 if (objCaseCourseExamRelaEN.IsUpdated(conCaseCourseExamRela.CaseName))
 {
 if (objCaseCourseExamRelaEN.CaseName !=  null)
 {
 var strCaseName = objCaseCourseExamRelaEN.CaseName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CaseName = '{0}',", strCaseName); //案例名称
 }
 else
 {
 sbSQL.Append(" CaseName = null,"); //案例名称
 }
 }
 
 if (objCaseCourseExamRelaEN.IsUpdated(conCaseCourseExamRela.OwnerId))
 {
 if (objCaseCourseExamRelaEN.OwnerId !=  null)
 {
 var strOwnerId = objCaseCourseExamRelaEN.OwnerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" OwnerId = '{0}',", strOwnerId); //拥有者Id
 }
 else
 {
 sbSQL.Append(" OwnerId = null,"); //拥有者Id
 }
 }
 
 if (objCaseCourseExamRelaEN.IsUpdated(conCaseCourseExamRela.QuestionId))
 {
 if (objCaseCourseExamRelaEN.QuestionId !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCaseCourseExamRelaEN.QuestionId, conCaseCourseExamRela.QuestionId); //题目Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCaseCourseExamRela.QuestionId); //题目Id
 }
 }
 
 if (objCaseCourseExamRelaEN.IsUpdated(conCaseCourseExamRela.IdCaseCourseExamRelaType))
 {
 if (objCaseCourseExamRelaEN.IdCaseCourseExamRelaType !=  null)
 {
 var strIdCaseCourseExamRelaType = objCaseCourseExamRelaEN.IdCaseCourseExamRelaType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdCaseCourseExamRelaType = '{0}',", strIdCaseCourseExamRelaType); //案例题库关系类型流水号
 }
 else
 {
 sbSQL.Append(" IdCaseCourseExamRelaType = null,"); //案例题库关系类型流水号
 }
 }
 
 if (objCaseCourseExamRelaEN.IsUpdated(conCaseCourseExamRela.StartTime))
 {
 if (objCaseCourseExamRelaEN.StartTime !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCaseCourseExamRelaEN.StartTime, conCaseCourseExamRela.StartTime); //开始时间(s)
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCaseCourseExamRela.StartTime); //开始时间(s)
 }
 }
 
 if (objCaseCourseExamRelaEN.IsUpdated(conCaseCourseExamRela.BrowseCount))
 {
 sbSQL.AppendFormat(" BrowseCount = {0},", objCaseCourseExamRelaEN.BrowseCount); //浏览次数
 }
 
 if (objCaseCourseExamRelaEN.IsUpdated(conCaseCourseExamRela.OrderNum))
 {
 if (objCaseCourseExamRelaEN.OrderNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCaseCourseExamRelaEN.OrderNum, conCaseCourseExamRela.OrderNum); //序号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCaseCourseExamRela.OrderNum); //序号
 }
 }
 
 if (objCaseCourseExamRelaEN.IsUpdated(conCaseCourseExamRela.UpdDate))
 {
 if (objCaseCourseExamRelaEN.UpdDate !=  null)
 {
 var strUpdDate = objCaseCourseExamRelaEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objCaseCourseExamRelaEN.IsUpdated(conCaseCourseExamRela.UpdUserId))
 {
 if (objCaseCourseExamRelaEN.UpdUserId !=  null)
 {
 var strUpdUserId = objCaseCourseExamRelaEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUserId = '{0}',", strUpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.Append(" UpdUserId = null,"); //修改用户Id
 }
 }
 
 if (objCaseCourseExamRelaEN.IsUpdated(conCaseCourseExamRela.Memo))
 {
 if (objCaseCourseExamRelaEN.Memo !=  null)
 {
 var strMemo = objCaseCourseExamRelaEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objCaseCourseExamRelaEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsCaseCourseExamRelaEN objCaseCourseExamRelaEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objCaseCourseExamRelaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCaseCourseExamRelaEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objCaseCourseExamRelaEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCaseCourseExamRelaDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update CaseCourseExamRela Set ");
 
 if (objCaseCourseExamRelaEN.IsUpdated(conCaseCourseExamRela.FuncModuleId))
 {
 if (objCaseCourseExamRelaEN.FuncModuleId !=  null)
 {
 var strFuncModuleId = objCaseCourseExamRelaEN.FuncModuleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFuncModuleId, conCaseCourseExamRela.FuncModuleId); //功能模块Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCaseCourseExamRela.FuncModuleId); //功能模块Id
 }
 }
 
 if (objCaseCourseExamRelaEN.IsUpdated(conCaseCourseExamRela.CaseId))
 {
 if (objCaseCourseExamRelaEN.CaseId !=  null)
 {
 var strCaseId = objCaseCourseExamRelaEN.CaseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCaseId, conCaseCourseExamRela.CaseId); //案例Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCaseCourseExamRela.CaseId); //案例Id
 }
 }
 
 if (objCaseCourseExamRelaEN.IsUpdated(conCaseCourseExamRela.CaseName))
 {
 if (objCaseCourseExamRelaEN.CaseName !=  null)
 {
 var strCaseName = objCaseCourseExamRelaEN.CaseName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCaseName, conCaseCourseExamRela.CaseName); //案例名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCaseCourseExamRela.CaseName); //案例名称
 }
 }
 
 if (objCaseCourseExamRelaEN.IsUpdated(conCaseCourseExamRela.OwnerId))
 {
 if (objCaseCourseExamRelaEN.OwnerId !=  null)
 {
 var strOwnerId = objCaseCourseExamRelaEN.OwnerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strOwnerId, conCaseCourseExamRela.OwnerId); //拥有者Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCaseCourseExamRela.OwnerId); //拥有者Id
 }
 }
 
 if (objCaseCourseExamRelaEN.IsUpdated(conCaseCourseExamRela.QuestionId))
 {
 if (objCaseCourseExamRelaEN.QuestionId !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCaseCourseExamRelaEN.QuestionId, conCaseCourseExamRela.QuestionId); //题目Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCaseCourseExamRela.QuestionId); //题目Id
 }
 }
 
 if (objCaseCourseExamRelaEN.IsUpdated(conCaseCourseExamRela.IdCaseCourseExamRelaType))
 {
 if (objCaseCourseExamRelaEN.IdCaseCourseExamRelaType !=  null)
 {
 var strIdCaseCourseExamRelaType = objCaseCourseExamRelaEN.IdCaseCourseExamRelaType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdCaseCourseExamRelaType, conCaseCourseExamRela.IdCaseCourseExamRelaType); //案例题库关系类型流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCaseCourseExamRela.IdCaseCourseExamRelaType); //案例题库关系类型流水号
 }
 }
 
 if (objCaseCourseExamRelaEN.IsUpdated(conCaseCourseExamRela.StartTime))
 {
 if (objCaseCourseExamRelaEN.StartTime !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCaseCourseExamRelaEN.StartTime, conCaseCourseExamRela.StartTime); //开始时间(s)
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCaseCourseExamRela.StartTime); //开始时间(s)
 }
 }
 
 if (objCaseCourseExamRelaEN.IsUpdated(conCaseCourseExamRela.BrowseCount))
 {
 sbSQL.AppendFormat("{1} = {0},",objCaseCourseExamRelaEN.BrowseCount, conCaseCourseExamRela.BrowseCount); //浏览次数
 }
 
 if (objCaseCourseExamRelaEN.IsUpdated(conCaseCourseExamRela.OrderNum))
 {
 if (objCaseCourseExamRelaEN.OrderNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCaseCourseExamRelaEN.OrderNum, conCaseCourseExamRela.OrderNum); //序号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCaseCourseExamRela.OrderNum); //序号
 }
 }
 
 if (objCaseCourseExamRelaEN.IsUpdated(conCaseCourseExamRela.UpdDate))
 {
 if (objCaseCourseExamRelaEN.UpdDate !=  null)
 {
 var strUpdDate = objCaseCourseExamRelaEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conCaseCourseExamRela.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCaseCourseExamRela.UpdDate); //修改日期
 }
 }
 
 if (objCaseCourseExamRelaEN.IsUpdated(conCaseCourseExamRela.UpdUserId))
 {
 if (objCaseCourseExamRelaEN.UpdUserId !=  null)
 {
 var strUpdUserId = objCaseCourseExamRelaEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUserId, conCaseCourseExamRela.UpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCaseCourseExamRela.UpdUserId); //修改用户Id
 }
 }
 
 if (objCaseCourseExamRelaEN.IsUpdated(conCaseCourseExamRela.Memo))
 {
 if (objCaseCourseExamRelaEN.Memo !=  null)
 {
 var strMemo = objCaseCourseExamRelaEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conCaseCourseExamRela.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCaseCourseExamRela.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where IdCaseCourseExamRela = {0}", objCaseCourseExamRelaEN.IdCaseCourseExamRela); 
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
 /// <param name = "lngIdCaseCourseExamRela">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(long lngIdCaseCourseExamRela) 
{
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCaseCourseExamRelaDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 lngIdCaseCourseExamRela,
};
 objSQL.ExecSP("CaseCourseExamRela_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "lngIdCaseCourseExamRela">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(long lngIdCaseCourseExamRela, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCaseCourseExamRelaDA.GetSpecSQLObj();
//删除CaseCourseExamRela本表中与当前对象有关的记录
strSQL = strSQL + "Delete from CaseCourseExamRela where IdCaseCourseExamRela = " + ""+ lngIdCaseCourseExamRela+"";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelCaseCourseExamRela(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCaseCourseExamRelaDA.GetSpecSQLObj();
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
//删除CaseCourseExamRela本表中与当前对象有关的记录
strSQL = strSQL + "Delete from CaseCourseExamRela where IdCaseCourseExamRela in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "lngIdCaseCourseExamRela">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(long lngIdCaseCourseExamRela) 
{
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCaseCourseExamRelaDA.GetSpecSQLObj();
//删除CaseCourseExamRela本表中与当前对象有关的记录
strSQL = strSQL + "Delete from CaseCourseExamRela where IdCaseCourseExamRela = " + ""+ lngIdCaseCourseExamRela+"";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelCaseCourseExamRela(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsCaseCourseExamRelaDA: DelCaseCourseExamRela)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCaseCourseExamRelaDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from CaseCourseExamRela where " + strCondition ;
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
public bool DelCaseCourseExamRelaWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsCaseCourseExamRelaDA: DelCaseCourseExamRelaWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCaseCourseExamRelaDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from CaseCourseExamRela where " + strCondition ;
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
 /// <param name = "objCaseCourseExamRelaENS">源对象</param>
 /// <param name = "objCaseCourseExamRelaENT">目标对象</param>
public void CopyTo(clsCaseCourseExamRelaEN objCaseCourseExamRelaENS, clsCaseCourseExamRelaEN objCaseCourseExamRelaENT)
{
objCaseCourseExamRelaENT.IdCaseCourseExamRela = objCaseCourseExamRelaENS.IdCaseCourseExamRela; //案例题库关系流水号
objCaseCourseExamRelaENT.FuncModuleId = objCaseCourseExamRelaENS.FuncModuleId; //功能模块Id
objCaseCourseExamRelaENT.CaseId = objCaseCourseExamRelaENS.CaseId; //案例Id
objCaseCourseExamRelaENT.CaseName = objCaseCourseExamRelaENS.CaseName; //案例名称
objCaseCourseExamRelaENT.OwnerId = objCaseCourseExamRelaENS.OwnerId; //拥有者Id
objCaseCourseExamRelaENT.QuestionId = objCaseCourseExamRelaENS.QuestionId; //题目Id
objCaseCourseExamRelaENT.IdCaseCourseExamRelaType = objCaseCourseExamRelaENS.IdCaseCourseExamRelaType; //案例题库关系类型流水号
objCaseCourseExamRelaENT.StartTime = objCaseCourseExamRelaENS.StartTime; //开始时间(s)
objCaseCourseExamRelaENT.BrowseCount = objCaseCourseExamRelaENS.BrowseCount; //浏览次数
objCaseCourseExamRelaENT.OrderNum = objCaseCourseExamRelaENS.OrderNum; //序号
objCaseCourseExamRelaENT.UpdDate = objCaseCourseExamRelaENS.UpdDate; //修改日期
objCaseCourseExamRelaENT.UpdUserId = objCaseCourseExamRelaENS.UpdUserId; //修改用户Id
objCaseCourseExamRelaENT.Memo = objCaseCourseExamRelaENS.Memo; //备注
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsCaseCourseExamRelaEN objCaseCourseExamRelaEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objCaseCourseExamRelaEN.FuncModuleId, conCaseCourseExamRela.FuncModuleId);
clsCheckSql.CheckFieldNotNull(objCaseCourseExamRelaEN.CaseId, conCaseCourseExamRela.CaseId);
clsCheckSql.CheckFieldNotNull(objCaseCourseExamRelaEN.CaseName, conCaseCourseExamRela.CaseName);
clsCheckSql.CheckFieldNotNull(objCaseCourseExamRelaEN.IdCaseCourseExamRelaType, conCaseCourseExamRela.IdCaseCourseExamRelaType);
clsCheckSql.CheckFieldNotNull(objCaseCourseExamRelaEN.BrowseCount, conCaseCourseExamRela.BrowseCount);
//检查字段长度
clsCheckSql.CheckFieldLen(objCaseCourseExamRelaEN.FuncModuleId, 4, conCaseCourseExamRela.FuncModuleId);
clsCheckSql.CheckFieldLen(objCaseCourseExamRelaEN.CaseId, 8, conCaseCourseExamRela.CaseId);
clsCheckSql.CheckFieldLen(objCaseCourseExamRelaEN.CaseName, 100, conCaseCourseExamRela.CaseName);
clsCheckSql.CheckFieldLen(objCaseCourseExamRelaEN.OwnerId, 20, conCaseCourseExamRela.OwnerId);
clsCheckSql.CheckFieldLen(objCaseCourseExamRelaEN.IdCaseCourseExamRelaType, 4, conCaseCourseExamRela.IdCaseCourseExamRelaType);
clsCheckSql.CheckFieldLen(objCaseCourseExamRelaEN.UpdDate, 20, conCaseCourseExamRela.UpdDate);
clsCheckSql.CheckFieldLen(objCaseCourseExamRelaEN.UpdUserId, 20, conCaseCourseExamRela.UpdUserId);
clsCheckSql.CheckFieldLen(objCaseCourseExamRelaEN.Memo, 1000, conCaseCourseExamRela.Memo);
//检查字段外键固定长度
 objCaseCourseExamRelaEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsCaseCourseExamRelaEN objCaseCourseExamRelaEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objCaseCourseExamRelaEN.FuncModuleId, 4, conCaseCourseExamRela.FuncModuleId);
clsCheckSql.CheckFieldLen(objCaseCourseExamRelaEN.CaseId, 8, conCaseCourseExamRela.CaseId);
clsCheckSql.CheckFieldLen(objCaseCourseExamRelaEN.CaseName, 100, conCaseCourseExamRela.CaseName);
clsCheckSql.CheckFieldLen(objCaseCourseExamRelaEN.OwnerId, 20, conCaseCourseExamRela.OwnerId);
clsCheckSql.CheckFieldLen(objCaseCourseExamRelaEN.IdCaseCourseExamRelaType, 4, conCaseCourseExamRela.IdCaseCourseExamRelaType);
clsCheckSql.CheckFieldLen(objCaseCourseExamRelaEN.UpdDate, 20, conCaseCourseExamRela.UpdDate);
clsCheckSql.CheckFieldLen(objCaseCourseExamRelaEN.UpdUserId, 20, conCaseCourseExamRela.UpdUserId);
clsCheckSql.CheckFieldLen(objCaseCourseExamRelaEN.Memo, 1000, conCaseCourseExamRela.Memo);
//检查外键字段长度
 objCaseCourseExamRelaEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsCaseCourseExamRelaEN objCaseCourseExamRelaEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objCaseCourseExamRelaEN.FuncModuleId, 4, conCaseCourseExamRela.FuncModuleId);
clsCheckSql.CheckFieldLen(objCaseCourseExamRelaEN.CaseId, 8, conCaseCourseExamRela.CaseId);
clsCheckSql.CheckFieldLen(objCaseCourseExamRelaEN.CaseName, 100, conCaseCourseExamRela.CaseName);
clsCheckSql.CheckFieldLen(objCaseCourseExamRelaEN.OwnerId, 20, conCaseCourseExamRela.OwnerId);
clsCheckSql.CheckFieldLen(objCaseCourseExamRelaEN.IdCaseCourseExamRelaType, 4, conCaseCourseExamRela.IdCaseCourseExamRelaType);
clsCheckSql.CheckFieldLen(objCaseCourseExamRelaEN.UpdDate, 20, conCaseCourseExamRela.UpdDate);
clsCheckSql.CheckFieldLen(objCaseCourseExamRelaEN.UpdUserId, 20, conCaseCourseExamRela.UpdUserId);
clsCheckSql.CheckFieldLen(objCaseCourseExamRelaEN.Memo, 1000, conCaseCourseExamRela.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objCaseCourseExamRelaEN.FuncModuleId, conCaseCourseExamRela.FuncModuleId);
clsCheckSql.CheckSqlInjection4Field(objCaseCourseExamRelaEN.CaseId, conCaseCourseExamRela.CaseId);
clsCheckSql.CheckSqlInjection4Field(objCaseCourseExamRelaEN.CaseName, conCaseCourseExamRela.CaseName);
clsCheckSql.CheckSqlInjection4Field(objCaseCourseExamRelaEN.OwnerId, conCaseCourseExamRela.OwnerId);
clsCheckSql.CheckSqlInjection4Field(objCaseCourseExamRelaEN.IdCaseCourseExamRelaType, conCaseCourseExamRela.IdCaseCourseExamRelaType);
clsCheckSql.CheckSqlInjection4Field(objCaseCourseExamRelaEN.UpdDate, conCaseCourseExamRela.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objCaseCourseExamRelaEN.UpdUserId, conCaseCourseExamRela.UpdUserId);
clsCheckSql.CheckSqlInjection4Field(objCaseCourseExamRelaEN.Memo, conCaseCourseExamRela.Memo);
//检查外键字段长度
 objCaseCourseExamRelaEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--CaseCourseExamRela(案例题库关系),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objCaseCourseExamRelaEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clsCaseCourseExamRelaEN objCaseCourseExamRelaEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and CaseId = '{0}'", objCaseCourseExamRelaEN.CaseId);
 if (objCaseCourseExamRelaEN.QuestionId == null)
{
 sbCondition.AppendFormat(" and QuestionId is null");
}
else
{
 sbCondition.AppendFormat(" and QuestionId = '{0}'", objCaseCourseExamRelaEN.QuestionId);
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
 objSQL = clsCaseCourseExamRelaDA.GetSpecSQLObj();
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
 objSQL = clsCaseCourseExamRelaDA.GetSpecSQLObj();
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
 objSQL = clsCaseCourseExamRelaDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsCaseCourseExamRelaEN._CurrTabName);
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
 objSQL = clsCaseCourseExamRelaDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsCaseCourseExamRelaEN._CurrTabName, strCondition);
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
 objSQL = clsCaseCourseExamRelaDA.GetSpecSQLObj();
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
 objSQL = clsCaseCourseExamRelaDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}