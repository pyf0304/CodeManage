
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvCaseExerciseRelaDA
 表名:vCaseExerciseRela(01120436)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 12:58:33
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:课程学习(CourseLearning)
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
 /// v案例习题关系(vCaseExerciseRela)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvCaseExerciseRelaDA : clsCommBase4DA
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
 return clsvCaseExerciseRelaEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvCaseExerciseRelaEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvCaseExerciseRelaEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvCaseExerciseRelaEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvCaseExerciseRelaEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvCaseExerciseRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCaseExerciseRelaDA.GetSpecSQLObj();
strSQL = "Select * from vCaseExerciseRela where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vCaseExerciseRela(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvCaseExerciseRelaDA: GetDataTable_vCaseExerciseRela)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCaseExerciseRelaDA.GetSpecSQLObj();
strSQL = "Select * from vCaseExerciseRela where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvCaseExerciseRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCaseExerciseRelaDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvCaseExerciseRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCaseExerciseRelaDA.GetSpecSQLObj();
strSQL = "Select * from vCaseExerciseRela where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvCaseExerciseRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCaseExerciseRelaDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvCaseExerciseRelaDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCaseExerciseRelaDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vCaseExerciseRela where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vCaseExerciseRela where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvCaseExerciseRelaDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCaseExerciseRelaDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vCaseExerciseRela where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvCaseExerciseRelaDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCaseExerciseRelaDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vCaseExerciseRela.* from vCaseExerciseRela Left Join {1} on {2} where {3} and vCaseExerciseRela.IdCaseExerciseRela not in (Select top {5} vCaseExerciseRela.IdCaseExerciseRela from vCaseExerciseRela Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vCaseExerciseRela where {1} and IdCaseExerciseRela not in (Select top {2} IdCaseExerciseRela from vCaseExerciseRela where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vCaseExerciseRela where {1} and IdCaseExerciseRela not in (Select top {3} IdCaseExerciseRela from vCaseExerciseRela where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvCaseExerciseRelaDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCaseExerciseRelaDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vCaseExerciseRela.* from vCaseExerciseRela Left Join {1} on {2} where {3} and vCaseExerciseRela.IdCaseExerciseRela not in (Select top {5} vCaseExerciseRela.IdCaseExerciseRela from vCaseExerciseRela Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vCaseExerciseRela where {1} and IdCaseExerciseRela not in (Select top {2} IdCaseExerciseRela from vCaseExerciseRela where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vCaseExerciseRela where {1} and IdCaseExerciseRela not in (Select top {3} IdCaseExerciseRela from vCaseExerciseRela where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvCaseExerciseRelaEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvCaseExerciseRelaDA:GetObjLst)", objException.Message));
}
List<clsvCaseExerciseRelaEN> arrObjLst = new List<clsvCaseExerciseRelaEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCaseExerciseRelaDA.GetSpecSQLObj();
strSQL = "Select * from vCaseExerciseRela where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCaseExerciseRelaEN objvCaseExerciseRelaEN = new clsvCaseExerciseRelaEN();
try
{
objvCaseExerciseRelaEN.IdCaseExerciseRela = TransNullToInt(objRow[convCaseExerciseRela.IdCaseExerciseRela].ToString().Trim()); //案例习题关系流水号
objvCaseExerciseRelaEN.FuncModuleId = objRow[convCaseExerciseRela.FuncModuleId].ToString().Trim(); //功能模块Id
objvCaseExerciseRelaEN.FuncModuleName = objRow[convCaseExerciseRela.FuncModuleName].ToString().Trim(); //功能模块名称
objvCaseExerciseRelaEN.CaseId = objRow[convCaseExerciseRela.CaseId] == DBNull.Value ? null : objRow[convCaseExerciseRela.CaseId].ToString().Trim(); //案例Id
objvCaseExerciseRelaEN.CaseName = objRow[convCaseExerciseRela.CaseName] == DBNull.Value ? null : objRow[convCaseExerciseRela.CaseName].ToString().Trim(); //案例名称
objvCaseExerciseRelaEN.OwnerId = objRow[convCaseExerciseRela.OwnerId].ToString().Trim(); //拥有者Id
objvCaseExerciseRelaEN.OwnerName = objRow[convCaseExerciseRela.OwnerName] == DBNull.Value ? null : objRow[convCaseExerciseRela.OwnerName].ToString().Trim(); //拥有者姓名
objvCaseExerciseRelaEN.CourseExamPaperId = objRow[convCaseExerciseRela.CourseExamPaperId] == DBNull.Value ? null : objRow[convCaseExerciseRela.CourseExamPaperId].ToString().Trim(); //考卷流水号
objvCaseExerciseRelaEN.ExamPaperName = objRow[convCaseExerciseRela.ExamPaperName] == DBNull.Value ? null : objRow[convCaseExerciseRela.ExamPaperName].ToString().Trim(); //考卷名称
objvCaseExerciseRelaEN.CourseId = objRow[convCaseExerciseRela.CourseId].ToString().Trim(); //课程Id
objvCaseExerciseRelaEN.CourseName = objRow[convCaseExerciseRela.CourseName] == DBNull.Value ? null : objRow[convCaseExerciseRela.CourseName].ToString().Trim(); //课程名称
objvCaseExerciseRelaEN.ExamPaperTypeId = objRow[convCaseExerciseRela.ExamPaperTypeId].ToString().Trim(); //试卷类型Id
objvCaseExerciseRelaEN.ExamPaperTypeName = objRow[convCaseExerciseRela.ExamPaperTypeName] == DBNull.Value ? null : objRow[convCaseExerciseRela.ExamPaperTypeName].ToString().Trim(); //试卷类型名称
objvCaseExerciseRelaEN.BrowseCount = objRow[convCaseExerciseRela.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCaseExerciseRela.BrowseCount].ToString().Trim()); //浏览次数
objvCaseExerciseRelaEN.UpdDate = objRow[convCaseExerciseRela.UpdDate] == DBNull.Value ? null : objRow[convCaseExerciseRela.UpdDate].ToString().Trim(); //修改日期
objvCaseExerciseRelaEN.UpdUserId = objRow[convCaseExerciseRela.UpdUserId] == DBNull.Value ? null : objRow[convCaseExerciseRela.UpdUserId].ToString().Trim(); //修改用户Id
objvCaseExerciseRelaEN.Memo = objRow[convCaseExerciseRela.Memo] == DBNull.Value ? null : objRow[convCaseExerciseRela.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvCaseExerciseRelaDA: GetObjLst)", objException.Message));
}
objvCaseExerciseRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvCaseExerciseRelaEN);
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
public List<clsvCaseExerciseRelaEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvCaseExerciseRelaDA:GetObjLstByTabName)", objException.Message));
}
List<clsvCaseExerciseRelaEN> arrObjLst = new List<clsvCaseExerciseRelaEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCaseExerciseRelaDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCaseExerciseRelaEN objvCaseExerciseRelaEN = new clsvCaseExerciseRelaEN();
try
{
objvCaseExerciseRelaEN.IdCaseExerciseRela = TransNullToInt(objRow[convCaseExerciseRela.IdCaseExerciseRela].ToString().Trim()); //案例习题关系流水号
objvCaseExerciseRelaEN.FuncModuleId = objRow[convCaseExerciseRela.FuncModuleId].ToString().Trim(); //功能模块Id
objvCaseExerciseRelaEN.FuncModuleName = objRow[convCaseExerciseRela.FuncModuleName].ToString().Trim(); //功能模块名称
objvCaseExerciseRelaEN.CaseId = objRow[convCaseExerciseRela.CaseId] == DBNull.Value ? null : objRow[convCaseExerciseRela.CaseId].ToString().Trim(); //案例Id
objvCaseExerciseRelaEN.CaseName = objRow[convCaseExerciseRela.CaseName] == DBNull.Value ? null : objRow[convCaseExerciseRela.CaseName].ToString().Trim(); //案例名称
objvCaseExerciseRelaEN.OwnerId = objRow[convCaseExerciseRela.OwnerId].ToString().Trim(); //拥有者Id
objvCaseExerciseRelaEN.OwnerName = objRow[convCaseExerciseRela.OwnerName] == DBNull.Value ? null : objRow[convCaseExerciseRela.OwnerName].ToString().Trim(); //拥有者姓名
objvCaseExerciseRelaEN.CourseExamPaperId = objRow[convCaseExerciseRela.CourseExamPaperId] == DBNull.Value ? null : objRow[convCaseExerciseRela.CourseExamPaperId].ToString().Trim(); //考卷流水号
objvCaseExerciseRelaEN.ExamPaperName = objRow[convCaseExerciseRela.ExamPaperName] == DBNull.Value ? null : objRow[convCaseExerciseRela.ExamPaperName].ToString().Trim(); //考卷名称
objvCaseExerciseRelaEN.CourseId = objRow[convCaseExerciseRela.CourseId].ToString().Trim(); //课程Id
objvCaseExerciseRelaEN.CourseName = objRow[convCaseExerciseRela.CourseName] == DBNull.Value ? null : objRow[convCaseExerciseRela.CourseName].ToString().Trim(); //课程名称
objvCaseExerciseRelaEN.ExamPaperTypeId = objRow[convCaseExerciseRela.ExamPaperTypeId].ToString().Trim(); //试卷类型Id
objvCaseExerciseRelaEN.ExamPaperTypeName = objRow[convCaseExerciseRela.ExamPaperTypeName] == DBNull.Value ? null : objRow[convCaseExerciseRela.ExamPaperTypeName].ToString().Trim(); //试卷类型名称
objvCaseExerciseRelaEN.BrowseCount = objRow[convCaseExerciseRela.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCaseExerciseRela.BrowseCount].ToString().Trim()); //浏览次数
objvCaseExerciseRelaEN.UpdDate = objRow[convCaseExerciseRela.UpdDate] == DBNull.Value ? null : objRow[convCaseExerciseRela.UpdDate].ToString().Trim(); //修改日期
objvCaseExerciseRelaEN.UpdUserId = objRow[convCaseExerciseRela.UpdUserId] == DBNull.Value ? null : objRow[convCaseExerciseRela.UpdUserId].ToString().Trim(); //修改用户Id
objvCaseExerciseRelaEN.Memo = objRow[convCaseExerciseRela.Memo] == DBNull.Value ? null : objRow[convCaseExerciseRela.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvCaseExerciseRelaDA: GetObjLst)", objException.Message));
}
objvCaseExerciseRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvCaseExerciseRelaEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvCaseExerciseRelaEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvCaseExerciseRela(ref clsvCaseExerciseRelaEN objvCaseExerciseRelaEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCaseExerciseRelaDA.GetSpecSQLObj();
strSQL = "Select * from vCaseExerciseRela where IdCaseExerciseRela = " + ""+ objvCaseExerciseRelaEN.IdCaseExerciseRela+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvCaseExerciseRelaEN.IdCaseExerciseRela = TransNullToInt(objDT.Rows[0][convCaseExerciseRela.IdCaseExerciseRela].ToString().Trim()); //案例习题关系流水号(字段类型:bigint,字段长度:8,是否可空:False)
 objvCaseExerciseRelaEN.FuncModuleId = objDT.Rows[0][convCaseExerciseRela.FuncModuleId].ToString().Trim(); //功能模块Id(字段类型:char,字段长度:4,是否可空:True)
 objvCaseExerciseRelaEN.FuncModuleName = objDT.Rows[0][convCaseExerciseRela.FuncModuleName].ToString().Trim(); //功能模块名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvCaseExerciseRelaEN.CaseId = objDT.Rows[0][convCaseExerciseRela.CaseId].ToString().Trim(); //案例Id(字段类型:char,字段长度:8,是否可空:True)
 objvCaseExerciseRelaEN.CaseName = objDT.Rows[0][convCaseExerciseRela.CaseName].ToString().Trim(); //案例名称(字段类型:varchar,字段长度:100,是否可空:True)
 objvCaseExerciseRelaEN.OwnerId = objDT.Rows[0][convCaseExerciseRela.OwnerId].ToString().Trim(); //拥有者Id(字段类型:varchar,字段长度:20,是否可空:False)
 objvCaseExerciseRelaEN.OwnerName = objDT.Rows[0][convCaseExerciseRela.OwnerName].ToString().Trim(); //拥有者姓名(字段类型:varchar,字段长度:30,是否可空:True)
 objvCaseExerciseRelaEN.CourseExamPaperId = objDT.Rows[0][convCaseExerciseRela.CourseExamPaperId].ToString().Trim(); //考卷流水号(字段类型:char,字段长度:8,是否可空:True)
 objvCaseExerciseRelaEN.ExamPaperName = objDT.Rows[0][convCaseExerciseRela.ExamPaperName].ToString().Trim(); //考卷名称(字段类型:varchar,字段长度:500,是否可空:True)
 objvCaseExerciseRelaEN.CourseId = objDT.Rows[0][convCaseExerciseRela.CourseId].ToString().Trim(); //课程Id(字段类型:char,字段长度:8,是否可空:True)
 objvCaseExerciseRelaEN.CourseName = objDT.Rows[0][convCaseExerciseRela.CourseName].ToString().Trim(); //课程名称(字段类型:varchar,字段长度:100,是否可空:True)
 objvCaseExerciseRelaEN.ExamPaperTypeId = objDT.Rows[0][convCaseExerciseRela.ExamPaperTypeId].ToString().Trim(); //试卷类型Id(字段类型:char,字段长度:2,是否可空:False)
 objvCaseExerciseRelaEN.ExamPaperTypeName = objDT.Rows[0][convCaseExerciseRela.ExamPaperTypeName].ToString().Trim(); //试卷类型名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvCaseExerciseRelaEN.BrowseCount = TransNullToInt(objDT.Rows[0][convCaseExerciseRela.BrowseCount].ToString().Trim()); //浏览次数(字段类型:int,字段长度:4,是否可空:True)
 objvCaseExerciseRelaEN.UpdDate = objDT.Rows[0][convCaseExerciseRela.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvCaseExerciseRelaEN.UpdUserId = objDT.Rows[0][convCaseExerciseRela.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:True)
 objvCaseExerciseRelaEN.Memo = objDT.Rows[0][convCaseExerciseRela.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvCaseExerciseRelaDA: GetvCaseExerciseRela)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngIdCaseExerciseRela">表关键字</param>
 /// <returns>表对象</returns>
public clsvCaseExerciseRelaEN GetObjByIdCaseExerciseRela(long lngIdCaseExerciseRela)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCaseExerciseRelaDA.GetSpecSQLObj();
strSQL = "Select * from vCaseExerciseRela where IdCaseExerciseRela = " + ""+ lngIdCaseExerciseRela+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvCaseExerciseRelaEN objvCaseExerciseRelaEN = new clsvCaseExerciseRelaEN();
try
{
 objvCaseExerciseRelaEN.IdCaseExerciseRela = Int32.Parse(objRow[convCaseExerciseRela.IdCaseExerciseRela].ToString().Trim()); //案例习题关系流水号(字段类型:bigint,字段长度:8,是否可空:False)
 objvCaseExerciseRelaEN.FuncModuleId = objRow[convCaseExerciseRela.FuncModuleId].ToString().Trim(); //功能模块Id(字段类型:char,字段长度:4,是否可空:True)
 objvCaseExerciseRelaEN.FuncModuleName = objRow[convCaseExerciseRela.FuncModuleName].ToString().Trim(); //功能模块名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvCaseExerciseRelaEN.CaseId = objRow[convCaseExerciseRela.CaseId] == DBNull.Value ? null : objRow[convCaseExerciseRela.CaseId].ToString().Trim(); //案例Id(字段类型:char,字段长度:8,是否可空:True)
 objvCaseExerciseRelaEN.CaseName = objRow[convCaseExerciseRela.CaseName] == DBNull.Value ? null : objRow[convCaseExerciseRela.CaseName].ToString().Trim(); //案例名称(字段类型:varchar,字段长度:100,是否可空:True)
 objvCaseExerciseRelaEN.OwnerId = objRow[convCaseExerciseRela.OwnerId].ToString().Trim(); //拥有者Id(字段类型:varchar,字段长度:20,是否可空:False)
 objvCaseExerciseRelaEN.OwnerName = objRow[convCaseExerciseRela.OwnerName] == DBNull.Value ? null : objRow[convCaseExerciseRela.OwnerName].ToString().Trim(); //拥有者姓名(字段类型:varchar,字段长度:30,是否可空:True)
 objvCaseExerciseRelaEN.CourseExamPaperId = objRow[convCaseExerciseRela.CourseExamPaperId] == DBNull.Value ? null : objRow[convCaseExerciseRela.CourseExamPaperId].ToString().Trim(); //考卷流水号(字段类型:char,字段长度:8,是否可空:True)
 objvCaseExerciseRelaEN.ExamPaperName = objRow[convCaseExerciseRela.ExamPaperName] == DBNull.Value ? null : objRow[convCaseExerciseRela.ExamPaperName].ToString().Trim(); //考卷名称(字段类型:varchar,字段长度:500,是否可空:True)
 objvCaseExerciseRelaEN.CourseId = objRow[convCaseExerciseRela.CourseId].ToString().Trim(); //课程Id(字段类型:char,字段长度:8,是否可空:True)
 objvCaseExerciseRelaEN.CourseName = objRow[convCaseExerciseRela.CourseName] == DBNull.Value ? null : objRow[convCaseExerciseRela.CourseName].ToString().Trim(); //课程名称(字段类型:varchar,字段长度:100,是否可空:True)
 objvCaseExerciseRelaEN.ExamPaperTypeId = objRow[convCaseExerciseRela.ExamPaperTypeId].ToString().Trim(); //试卷类型Id(字段类型:char,字段长度:2,是否可空:False)
 objvCaseExerciseRelaEN.ExamPaperTypeName = objRow[convCaseExerciseRela.ExamPaperTypeName] == DBNull.Value ? null : objRow[convCaseExerciseRela.ExamPaperTypeName].ToString().Trim(); //试卷类型名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvCaseExerciseRelaEN.BrowseCount = objRow[convCaseExerciseRela.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCaseExerciseRela.BrowseCount].ToString().Trim()); //浏览次数(字段类型:int,字段长度:4,是否可空:True)
 objvCaseExerciseRelaEN.UpdDate = objRow[convCaseExerciseRela.UpdDate] == DBNull.Value ? null : objRow[convCaseExerciseRela.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvCaseExerciseRelaEN.UpdUserId = objRow[convCaseExerciseRela.UpdUserId] == DBNull.Value ? null : objRow[convCaseExerciseRela.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:True)
 objvCaseExerciseRelaEN.Memo = objRow[convCaseExerciseRela.Memo] == DBNull.Value ? null : objRow[convCaseExerciseRela.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvCaseExerciseRelaDA: GetObjByIdCaseExerciseRela)", objException.Message));
}
return objvCaseExerciseRelaEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvCaseExerciseRelaEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvCaseExerciseRelaDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCaseExerciseRelaDA.GetSpecSQLObj();
strSQL = "Select * from vCaseExerciseRela where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvCaseExerciseRelaEN objvCaseExerciseRelaEN = new clsvCaseExerciseRelaEN()
{
IdCaseExerciseRela = TransNullToInt(objRow[convCaseExerciseRela.IdCaseExerciseRela].ToString().Trim()), //案例习题关系流水号
FuncModuleId = objRow[convCaseExerciseRela.FuncModuleId].ToString().Trim(), //功能模块Id
FuncModuleName = objRow[convCaseExerciseRela.FuncModuleName].ToString().Trim(), //功能模块名称
CaseId = objRow[convCaseExerciseRela.CaseId] == DBNull.Value ? null : objRow[convCaseExerciseRela.CaseId].ToString().Trim(), //案例Id
CaseName = objRow[convCaseExerciseRela.CaseName] == DBNull.Value ? null : objRow[convCaseExerciseRela.CaseName].ToString().Trim(), //案例名称
OwnerId = objRow[convCaseExerciseRela.OwnerId].ToString().Trim(), //拥有者Id
OwnerName = objRow[convCaseExerciseRela.OwnerName] == DBNull.Value ? null : objRow[convCaseExerciseRela.OwnerName].ToString().Trim(), //拥有者姓名
CourseExamPaperId = objRow[convCaseExerciseRela.CourseExamPaperId] == DBNull.Value ? null : objRow[convCaseExerciseRela.CourseExamPaperId].ToString().Trim(), //考卷流水号
ExamPaperName = objRow[convCaseExerciseRela.ExamPaperName] == DBNull.Value ? null : objRow[convCaseExerciseRela.ExamPaperName].ToString().Trim(), //考卷名称
CourseId = objRow[convCaseExerciseRela.CourseId].ToString().Trim(), //课程Id
CourseName = objRow[convCaseExerciseRela.CourseName] == DBNull.Value ? null : objRow[convCaseExerciseRela.CourseName].ToString().Trim(), //课程名称
ExamPaperTypeId = objRow[convCaseExerciseRela.ExamPaperTypeId].ToString().Trim(), //试卷类型Id
ExamPaperTypeName = objRow[convCaseExerciseRela.ExamPaperTypeName] == DBNull.Value ? null : objRow[convCaseExerciseRela.ExamPaperTypeName].ToString().Trim(), //试卷类型名称
BrowseCount = objRow[convCaseExerciseRela.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCaseExerciseRela.BrowseCount].ToString().Trim()), //浏览次数
UpdDate = objRow[convCaseExerciseRela.UpdDate] == DBNull.Value ? null : objRow[convCaseExerciseRela.UpdDate].ToString().Trim(), //修改日期
UpdUserId = objRow[convCaseExerciseRela.UpdUserId] == DBNull.Value ? null : objRow[convCaseExerciseRela.UpdUserId].ToString().Trim(), //修改用户Id
Memo = objRow[convCaseExerciseRela.Memo] == DBNull.Value ? null : objRow[convCaseExerciseRela.Memo].ToString().Trim() //备注
};
objvCaseExerciseRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvCaseExerciseRelaEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvCaseExerciseRelaDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvCaseExerciseRelaEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvCaseExerciseRelaEN objvCaseExerciseRelaEN = new clsvCaseExerciseRelaEN();
try
{
objvCaseExerciseRelaEN.IdCaseExerciseRela = TransNullToInt(objRow[convCaseExerciseRela.IdCaseExerciseRela].ToString().Trim()); //案例习题关系流水号
objvCaseExerciseRelaEN.FuncModuleId = objRow[convCaseExerciseRela.FuncModuleId].ToString().Trim(); //功能模块Id
objvCaseExerciseRelaEN.FuncModuleName = objRow[convCaseExerciseRela.FuncModuleName].ToString().Trim(); //功能模块名称
objvCaseExerciseRelaEN.CaseId = objRow[convCaseExerciseRela.CaseId] == DBNull.Value ? null : objRow[convCaseExerciseRela.CaseId].ToString().Trim(); //案例Id
objvCaseExerciseRelaEN.CaseName = objRow[convCaseExerciseRela.CaseName] == DBNull.Value ? null : objRow[convCaseExerciseRela.CaseName].ToString().Trim(); //案例名称
objvCaseExerciseRelaEN.OwnerId = objRow[convCaseExerciseRela.OwnerId].ToString().Trim(); //拥有者Id
objvCaseExerciseRelaEN.OwnerName = objRow[convCaseExerciseRela.OwnerName] == DBNull.Value ? null : objRow[convCaseExerciseRela.OwnerName].ToString().Trim(); //拥有者姓名
objvCaseExerciseRelaEN.CourseExamPaperId = objRow[convCaseExerciseRela.CourseExamPaperId] == DBNull.Value ? null : objRow[convCaseExerciseRela.CourseExamPaperId].ToString().Trim(); //考卷流水号
objvCaseExerciseRelaEN.ExamPaperName = objRow[convCaseExerciseRela.ExamPaperName] == DBNull.Value ? null : objRow[convCaseExerciseRela.ExamPaperName].ToString().Trim(); //考卷名称
objvCaseExerciseRelaEN.CourseId = objRow[convCaseExerciseRela.CourseId].ToString().Trim(); //课程Id
objvCaseExerciseRelaEN.CourseName = objRow[convCaseExerciseRela.CourseName] == DBNull.Value ? null : objRow[convCaseExerciseRela.CourseName].ToString().Trim(); //课程名称
objvCaseExerciseRelaEN.ExamPaperTypeId = objRow[convCaseExerciseRela.ExamPaperTypeId].ToString().Trim(); //试卷类型Id
objvCaseExerciseRelaEN.ExamPaperTypeName = objRow[convCaseExerciseRela.ExamPaperTypeName] == DBNull.Value ? null : objRow[convCaseExerciseRela.ExamPaperTypeName].ToString().Trim(); //试卷类型名称
objvCaseExerciseRelaEN.BrowseCount = objRow[convCaseExerciseRela.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCaseExerciseRela.BrowseCount].ToString().Trim()); //浏览次数
objvCaseExerciseRelaEN.UpdDate = objRow[convCaseExerciseRela.UpdDate] == DBNull.Value ? null : objRow[convCaseExerciseRela.UpdDate].ToString().Trim(); //修改日期
objvCaseExerciseRelaEN.UpdUserId = objRow[convCaseExerciseRela.UpdUserId] == DBNull.Value ? null : objRow[convCaseExerciseRela.UpdUserId].ToString().Trim(); //修改用户Id
objvCaseExerciseRelaEN.Memo = objRow[convCaseExerciseRela.Memo] == DBNull.Value ? null : objRow[convCaseExerciseRela.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvCaseExerciseRelaDA: GetObjByDataRowvCaseExerciseRela)", objException.Message));
}
objvCaseExerciseRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvCaseExerciseRelaEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvCaseExerciseRelaEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvCaseExerciseRelaEN objvCaseExerciseRelaEN = new clsvCaseExerciseRelaEN();
try
{
objvCaseExerciseRelaEN.IdCaseExerciseRela = TransNullToInt(objRow[convCaseExerciseRela.IdCaseExerciseRela].ToString().Trim()); //案例习题关系流水号
objvCaseExerciseRelaEN.FuncModuleId = objRow[convCaseExerciseRela.FuncModuleId].ToString().Trim(); //功能模块Id
objvCaseExerciseRelaEN.FuncModuleName = objRow[convCaseExerciseRela.FuncModuleName].ToString().Trim(); //功能模块名称
objvCaseExerciseRelaEN.CaseId = objRow[convCaseExerciseRela.CaseId] == DBNull.Value ? null : objRow[convCaseExerciseRela.CaseId].ToString().Trim(); //案例Id
objvCaseExerciseRelaEN.CaseName = objRow[convCaseExerciseRela.CaseName] == DBNull.Value ? null : objRow[convCaseExerciseRela.CaseName].ToString().Trim(); //案例名称
objvCaseExerciseRelaEN.OwnerId = objRow[convCaseExerciseRela.OwnerId].ToString().Trim(); //拥有者Id
objvCaseExerciseRelaEN.OwnerName = objRow[convCaseExerciseRela.OwnerName] == DBNull.Value ? null : objRow[convCaseExerciseRela.OwnerName].ToString().Trim(); //拥有者姓名
objvCaseExerciseRelaEN.CourseExamPaperId = objRow[convCaseExerciseRela.CourseExamPaperId] == DBNull.Value ? null : objRow[convCaseExerciseRela.CourseExamPaperId].ToString().Trim(); //考卷流水号
objvCaseExerciseRelaEN.ExamPaperName = objRow[convCaseExerciseRela.ExamPaperName] == DBNull.Value ? null : objRow[convCaseExerciseRela.ExamPaperName].ToString().Trim(); //考卷名称
objvCaseExerciseRelaEN.CourseId = objRow[convCaseExerciseRela.CourseId].ToString().Trim(); //课程Id
objvCaseExerciseRelaEN.CourseName = objRow[convCaseExerciseRela.CourseName] == DBNull.Value ? null : objRow[convCaseExerciseRela.CourseName].ToString().Trim(); //课程名称
objvCaseExerciseRelaEN.ExamPaperTypeId = objRow[convCaseExerciseRela.ExamPaperTypeId].ToString().Trim(); //试卷类型Id
objvCaseExerciseRelaEN.ExamPaperTypeName = objRow[convCaseExerciseRela.ExamPaperTypeName] == DBNull.Value ? null : objRow[convCaseExerciseRela.ExamPaperTypeName].ToString().Trim(); //试卷类型名称
objvCaseExerciseRelaEN.BrowseCount = objRow[convCaseExerciseRela.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCaseExerciseRela.BrowseCount].ToString().Trim()); //浏览次数
objvCaseExerciseRelaEN.UpdDate = objRow[convCaseExerciseRela.UpdDate] == DBNull.Value ? null : objRow[convCaseExerciseRela.UpdDate].ToString().Trim(); //修改日期
objvCaseExerciseRelaEN.UpdUserId = objRow[convCaseExerciseRela.UpdUserId] == DBNull.Value ? null : objRow[convCaseExerciseRela.UpdUserId].ToString().Trim(); //修改用户Id
objvCaseExerciseRelaEN.Memo = objRow[convCaseExerciseRela.Memo] == DBNull.Value ? null : objRow[convCaseExerciseRela.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvCaseExerciseRelaDA: GetObjByDataRow)", objException.Message));
}
objvCaseExerciseRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvCaseExerciseRelaEN;
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
objSQL = clsvCaseExerciseRelaDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvCaseExerciseRelaEN._CurrTabName, convCaseExerciseRela.IdCaseExerciseRela, 8, "");
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
objSQL = clsvCaseExerciseRelaDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvCaseExerciseRelaEN._CurrTabName, convCaseExerciseRela.IdCaseExerciseRela, 8, strPrefix);
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
 objSQL = clsvCaseExerciseRelaDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select IdCaseExerciseRela from vCaseExerciseRela where " + strCondition;
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
 objSQL = clsvCaseExerciseRelaDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select IdCaseExerciseRela from vCaseExerciseRela where " + strCondition;
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
 /// <param name = "lngIdCaseExerciseRela">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(long lngIdCaseExerciseRela)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCaseExerciseRelaDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vCaseExerciseRela", "IdCaseExerciseRela = " + ""+ lngIdCaseExerciseRela+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvCaseExerciseRelaDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCaseExerciseRelaDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vCaseExerciseRela", strCondition))
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
objSQL = clsvCaseExerciseRelaDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vCaseExerciseRela");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvCaseExerciseRelaENS">源对象</param>
 /// <param name = "objvCaseExerciseRelaENT">目标对象</param>
public void CopyTo(clsvCaseExerciseRelaEN objvCaseExerciseRelaENS, clsvCaseExerciseRelaEN objvCaseExerciseRelaENT)
{
objvCaseExerciseRelaENT.IdCaseExerciseRela = objvCaseExerciseRelaENS.IdCaseExerciseRela; //案例习题关系流水号
objvCaseExerciseRelaENT.FuncModuleId = objvCaseExerciseRelaENS.FuncModuleId; //功能模块Id
objvCaseExerciseRelaENT.FuncModuleName = objvCaseExerciseRelaENS.FuncModuleName; //功能模块名称
objvCaseExerciseRelaENT.CaseId = objvCaseExerciseRelaENS.CaseId; //案例Id
objvCaseExerciseRelaENT.CaseName = objvCaseExerciseRelaENS.CaseName; //案例名称
objvCaseExerciseRelaENT.OwnerId = objvCaseExerciseRelaENS.OwnerId; //拥有者Id
objvCaseExerciseRelaENT.OwnerName = objvCaseExerciseRelaENS.OwnerName; //拥有者姓名
objvCaseExerciseRelaENT.CourseExamPaperId = objvCaseExerciseRelaENS.CourseExamPaperId; //考卷流水号
objvCaseExerciseRelaENT.ExamPaperName = objvCaseExerciseRelaENS.ExamPaperName; //考卷名称
objvCaseExerciseRelaENT.CourseId = objvCaseExerciseRelaENS.CourseId; //课程Id
objvCaseExerciseRelaENT.CourseName = objvCaseExerciseRelaENS.CourseName; //课程名称
objvCaseExerciseRelaENT.ExamPaperTypeId = objvCaseExerciseRelaENS.ExamPaperTypeId; //试卷类型Id
objvCaseExerciseRelaENT.ExamPaperTypeName = objvCaseExerciseRelaENS.ExamPaperTypeName; //试卷类型名称
objvCaseExerciseRelaENT.BrowseCount = objvCaseExerciseRelaENS.BrowseCount; //浏览次数
objvCaseExerciseRelaENT.UpdDate = objvCaseExerciseRelaENS.UpdDate; //修改日期
objvCaseExerciseRelaENT.UpdUserId = objvCaseExerciseRelaENS.UpdUserId; //修改用户Id
objvCaseExerciseRelaENT.Memo = objvCaseExerciseRelaENS.Memo; //备注
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvCaseExerciseRelaEN objvCaseExerciseRelaEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvCaseExerciseRelaEN.FuncModuleId, 4, convCaseExerciseRela.FuncModuleId);
clsCheckSql.CheckFieldLen(objvCaseExerciseRelaEN.FuncModuleName, 30, convCaseExerciseRela.FuncModuleName);
clsCheckSql.CheckFieldLen(objvCaseExerciseRelaEN.CaseId, 8, convCaseExerciseRela.CaseId);
clsCheckSql.CheckFieldLen(objvCaseExerciseRelaEN.CaseName, 100, convCaseExerciseRela.CaseName);
clsCheckSql.CheckFieldLen(objvCaseExerciseRelaEN.OwnerId, 20, convCaseExerciseRela.OwnerId);
clsCheckSql.CheckFieldLen(objvCaseExerciseRelaEN.OwnerName, 30, convCaseExerciseRela.OwnerName);
clsCheckSql.CheckFieldLen(objvCaseExerciseRelaEN.CourseExamPaperId, 8, convCaseExerciseRela.CourseExamPaperId);
clsCheckSql.CheckFieldLen(objvCaseExerciseRelaEN.ExamPaperName, 500, convCaseExerciseRela.ExamPaperName);
clsCheckSql.CheckFieldLen(objvCaseExerciseRelaEN.CourseId, 8, convCaseExerciseRela.CourseId);
clsCheckSql.CheckFieldLen(objvCaseExerciseRelaEN.CourseName, 100, convCaseExerciseRela.CourseName);
clsCheckSql.CheckFieldLen(objvCaseExerciseRelaEN.ExamPaperTypeId, 2, convCaseExerciseRela.ExamPaperTypeId);
clsCheckSql.CheckFieldLen(objvCaseExerciseRelaEN.ExamPaperTypeName, 30, convCaseExerciseRela.ExamPaperTypeName);
clsCheckSql.CheckFieldLen(objvCaseExerciseRelaEN.UpdDate, 20, convCaseExerciseRela.UpdDate);
clsCheckSql.CheckFieldLen(objvCaseExerciseRelaEN.UpdUserId, 20, convCaseExerciseRela.UpdUserId);
clsCheckSql.CheckFieldLen(objvCaseExerciseRelaEN.Memo, 1000, convCaseExerciseRela.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvCaseExerciseRelaEN.FuncModuleId, convCaseExerciseRela.FuncModuleId);
clsCheckSql.CheckSqlInjection4Field(objvCaseExerciseRelaEN.FuncModuleName, convCaseExerciseRela.FuncModuleName);
clsCheckSql.CheckSqlInjection4Field(objvCaseExerciseRelaEN.CaseId, convCaseExerciseRela.CaseId);
clsCheckSql.CheckSqlInjection4Field(objvCaseExerciseRelaEN.CaseName, convCaseExerciseRela.CaseName);
clsCheckSql.CheckSqlInjection4Field(objvCaseExerciseRelaEN.OwnerId, convCaseExerciseRela.OwnerId);
clsCheckSql.CheckSqlInjection4Field(objvCaseExerciseRelaEN.OwnerName, convCaseExerciseRela.OwnerName);
clsCheckSql.CheckSqlInjection4Field(objvCaseExerciseRelaEN.CourseExamPaperId, convCaseExerciseRela.CourseExamPaperId);
clsCheckSql.CheckSqlInjection4Field(objvCaseExerciseRelaEN.ExamPaperName, convCaseExerciseRela.ExamPaperName);
clsCheckSql.CheckSqlInjection4Field(objvCaseExerciseRelaEN.CourseId, convCaseExerciseRela.CourseId);
clsCheckSql.CheckSqlInjection4Field(objvCaseExerciseRelaEN.CourseName, convCaseExerciseRela.CourseName);
clsCheckSql.CheckSqlInjection4Field(objvCaseExerciseRelaEN.ExamPaperTypeId, convCaseExerciseRela.ExamPaperTypeId);
clsCheckSql.CheckSqlInjection4Field(objvCaseExerciseRelaEN.ExamPaperTypeName, convCaseExerciseRela.ExamPaperTypeName);
clsCheckSql.CheckSqlInjection4Field(objvCaseExerciseRelaEN.UpdDate, convCaseExerciseRela.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objvCaseExerciseRelaEN.UpdUserId, convCaseExerciseRela.UpdUserId);
clsCheckSql.CheckSqlInjection4Field(objvCaseExerciseRelaEN.Memo, convCaseExerciseRela.Memo);
//检查外键字段长度
 objvCaseExerciseRelaEN._IsCheckProperty = true;
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
 objSQL = clsvCaseExerciseRelaDA.GetSpecSQLObj();
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
 objSQL = clsvCaseExerciseRelaDA.GetSpecSQLObj();
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
 objSQL = clsvCaseExerciseRelaDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvCaseExerciseRelaEN._CurrTabName);
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
 objSQL = clsvCaseExerciseRelaDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvCaseExerciseRelaEN._CurrTabName, strCondition);
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
 objSQL = clsvCaseExerciseRelaDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}