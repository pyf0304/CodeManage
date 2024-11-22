
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsCaseExerciseRelaDA
 表名:CaseExerciseRela(01120437)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:12:14
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
 /// 案例习题关系(CaseExerciseRela)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsCaseExerciseRelaDA : clsCommBase4DA
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
 return clsCaseExerciseRelaEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsCaseExerciseRelaEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsCaseExerciseRelaEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsCaseExerciseRelaEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsCaseExerciseRelaEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsCaseExerciseRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCaseExerciseRelaDA.GetSpecSQLObj();
strSQL = "Select * from CaseExerciseRela where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_CaseExerciseRela(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsCaseExerciseRelaDA: GetDataTable_CaseExerciseRela)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCaseExerciseRelaDA.GetSpecSQLObj();
strSQL = "Select * from CaseExerciseRela where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsCaseExerciseRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCaseExerciseRelaDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsCaseExerciseRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCaseExerciseRelaDA.GetSpecSQLObj();
strSQL = "Select * from CaseExerciseRela where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsCaseExerciseRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCaseExerciseRelaDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsCaseExerciseRelaDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCaseExerciseRelaDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from CaseExerciseRela where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from CaseExerciseRela where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsCaseExerciseRelaDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCaseExerciseRelaDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from CaseExerciseRela where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsCaseExerciseRelaDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCaseExerciseRelaDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} CaseExerciseRela.* from CaseExerciseRela Left Join {1} on {2} where {3} and CaseExerciseRela.IdCaseExerciseRela not in (Select top {5} CaseExerciseRela.IdCaseExerciseRela from CaseExerciseRela Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from CaseExerciseRela where {1} and IdCaseExerciseRela not in (Select top {2} IdCaseExerciseRela from CaseExerciseRela where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from CaseExerciseRela where {1} and IdCaseExerciseRela not in (Select top {3} IdCaseExerciseRela from CaseExerciseRela where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsCaseExerciseRelaDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCaseExerciseRelaDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} CaseExerciseRela.* from CaseExerciseRela Left Join {1} on {2} where {3} and CaseExerciseRela.IdCaseExerciseRela not in (Select top {5} CaseExerciseRela.IdCaseExerciseRela from CaseExerciseRela Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from CaseExerciseRela where {1} and IdCaseExerciseRela not in (Select top {2} IdCaseExerciseRela from CaseExerciseRela where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from CaseExerciseRela where {1} and IdCaseExerciseRela not in (Select top {3} IdCaseExerciseRela from CaseExerciseRela where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsCaseExerciseRelaEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsCaseExerciseRelaDA:GetObjLst)", objException.Message));
}
List<clsCaseExerciseRelaEN> arrObjLst = new List<clsCaseExerciseRelaEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCaseExerciseRelaDA.GetSpecSQLObj();
strSQL = "Select * from CaseExerciseRela where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCaseExerciseRelaEN objCaseExerciseRelaEN = new clsCaseExerciseRelaEN();
try
{
objCaseExerciseRelaEN.IdCaseExerciseRela = TransNullToInt(objRow[conCaseExerciseRela.IdCaseExerciseRela].ToString().Trim()); //案例习题关系流水号
objCaseExerciseRelaEN.FuncModuleId = objRow[conCaseExerciseRela.FuncModuleId].ToString().Trim(); //功能模块Id
objCaseExerciseRelaEN.CaseId = objRow[conCaseExerciseRela.CaseId].ToString().Trim(); //案例Id
objCaseExerciseRelaEN.CaseName = objRow[conCaseExerciseRela.CaseName].ToString().Trim(); //案例名称
objCaseExerciseRelaEN.OwnerId = objRow[conCaseExerciseRela.OwnerId] == DBNull.Value ? null : objRow[conCaseExerciseRela.OwnerId].ToString().Trim(); //拥有者Id
objCaseExerciseRelaEN.CourseExamPaperId = objRow[conCaseExerciseRela.CourseExamPaperId] == DBNull.Value ? null : objRow[conCaseExerciseRela.CourseExamPaperId].ToString().Trim(); //考卷流水号
objCaseExerciseRelaEN.CourseId = objRow[conCaseExerciseRela.CourseId].ToString().Trim(); //课程Id
objCaseExerciseRelaEN.ExamPaperTypeId = objRow[conCaseExerciseRela.ExamPaperTypeId].ToString().Trim(); //试卷类型Id
objCaseExerciseRelaEN.BrowseCount = TransNullToInt(objRow[conCaseExerciseRela.BrowseCount].ToString().Trim()); //浏览次数
objCaseExerciseRelaEN.UpdDate = objRow[conCaseExerciseRela.UpdDate] == DBNull.Value ? null : objRow[conCaseExerciseRela.UpdDate].ToString().Trim(); //修改日期
objCaseExerciseRelaEN.UpdUserId = objRow[conCaseExerciseRela.UpdUserId] == DBNull.Value ? null : objRow[conCaseExerciseRela.UpdUserId].ToString().Trim(); //修改用户Id
objCaseExerciseRelaEN.Memo = objRow[conCaseExerciseRela.Memo] == DBNull.Value ? null : objRow[conCaseExerciseRela.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsCaseExerciseRelaDA: GetObjLst)", objException.Message));
}
objCaseExerciseRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objCaseExerciseRelaEN);
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
public List<clsCaseExerciseRelaEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsCaseExerciseRelaDA:GetObjLstByTabName)", objException.Message));
}
List<clsCaseExerciseRelaEN> arrObjLst = new List<clsCaseExerciseRelaEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCaseExerciseRelaDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCaseExerciseRelaEN objCaseExerciseRelaEN = new clsCaseExerciseRelaEN();
try
{
objCaseExerciseRelaEN.IdCaseExerciseRela = TransNullToInt(objRow[conCaseExerciseRela.IdCaseExerciseRela].ToString().Trim()); //案例习题关系流水号
objCaseExerciseRelaEN.FuncModuleId = objRow[conCaseExerciseRela.FuncModuleId].ToString().Trim(); //功能模块Id
objCaseExerciseRelaEN.CaseId = objRow[conCaseExerciseRela.CaseId].ToString().Trim(); //案例Id
objCaseExerciseRelaEN.CaseName = objRow[conCaseExerciseRela.CaseName].ToString().Trim(); //案例名称
objCaseExerciseRelaEN.OwnerId = objRow[conCaseExerciseRela.OwnerId] == DBNull.Value ? null : objRow[conCaseExerciseRela.OwnerId].ToString().Trim(); //拥有者Id
objCaseExerciseRelaEN.CourseExamPaperId = objRow[conCaseExerciseRela.CourseExamPaperId] == DBNull.Value ? null : objRow[conCaseExerciseRela.CourseExamPaperId].ToString().Trim(); //考卷流水号
objCaseExerciseRelaEN.CourseId = objRow[conCaseExerciseRela.CourseId].ToString().Trim(); //课程Id
objCaseExerciseRelaEN.ExamPaperTypeId = objRow[conCaseExerciseRela.ExamPaperTypeId].ToString().Trim(); //试卷类型Id
objCaseExerciseRelaEN.BrowseCount = TransNullToInt(objRow[conCaseExerciseRela.BrowseCount].ToString().Trim()); //浏览次数
objCaseExerciseRelaEN.UpdDate = objRow[conCaseExerciseRela.UpdDate] == DBNull.Value ? null : objRow[conCaseExerciseRela.UpdDate].ToString().Trim(); //修改日期
objCaseExerciseRelaEN.UpdUserId = objRow[conCaseExerciseRela.UpdUserId] == DBNull.Value ? null : objRow[conCaseExerciseRela.UpdUserId].ToString().Trim(); //修改用户Id
objCaseExerciseRelaEN.Memo = objRow[conCaseExerciseRela.Memo] == DBNull.Value ? null : objRow[conCaseExerciseRela.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsCaseExerciseRelaDA: GetObjLst)", objException.Message));
}
objCaseExerciseRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objCaseExerciseRelaEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objCaseExerciseRelaEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetCaseExerciseRela(ref clsCaseExerciseRelaEN objCaseExerciseRelaEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCaseExerciseRelaDA.GetSpecSQLObj();
strSQL = "Select * from CaseExerciseRela where IdCaseExerciseRela = " + ""+ objCaseExerciseRelaEN.IdCaseExerciseRela+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objCaseExerciseRelaEN.IdCaseExerciseRela = TransNullToInt(objDT.Rows[0][conCaseExerciseRela.IdCaseExerciseRela].ToString().Trim()); //案例习题关系流水号(字段类型:bigint,字段长度:8,是否可空:False)
 objCaseExerciseRelaEN.FuncModuleId = objDT.Rows[0][conCaseExerciseRela.FuncModuleId].ToString().Trim(); //功能模块Id(字段类型:char,字段长度:4,是否可空:True)
 objCaseExerciseRelaEN.CaseId = objDT.Rows[0][conCaseExerciseRela.CaseId].ToString().Trim(); //案例Id(字段类型:char,字段长度:8,是否可空:True)
 objCaseExerciseRelaEN.CaseName = objDT.Rows[0][conCaseExerciseRela.CaseName].ToString().Trim(); //案例名称(字段类型:varchar,字段长度:100,是否可空:True)
 objCaseExerciseRelaEN.OwnerId = objDT.Rows[0][conCaseExerciseRela.OwnerId].ToString().Trim(); //拥有者Id(字段类型:varchar,字段长度:20,是否可空:False)
 objCaseExerciseRelaEN.CourseExamPaperId = objDT.Rows[0][conCaseExerciseRela.CourseExamPaperId].ToString().Trim(); //考卷流水号(字段类型:char,字段长度:8,是否可空:True)
 objCaseExerciseRelaEN.CourseId = objDT.Rows[0][conCaseExerciseRela.CourseId].ToString().Trim(); //课程Id(字段类型:char,字段长度:8,是否可空:True)
 objCaseExerciseRelaEN.ExamPaperTypeId = objDT.Rows[0][conCaseExerciseRela.ExamPaperTypeId].ToString().Trim(); //试卷类型Id(字段类型:char,字段长度:2,是否可空:False)
 objCaseExerciseRelaEN.BrowseCount = TransNullToInt(objDT.Rows[0][conCaseExerciseRela.BrowseCount].ToString().Trim()); //浏览次数(字段类型:int,字段长度:4,是否可空:True)
 objCaseExerciseRelaEN.UpdDate = objDT.Rows[0][conCaseExerciseRela.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objCaseExerciseRelaEN.UpdUserId = objDT.Rows[0][conCaseExerciseRela.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:True)
 objCaseExerciseRelaEN.Memo = objDT.Rows[0][conCaseExerciseRela.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsCaseExerciseRelaDA: GetCaseExerciseRela)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngIdCaseExerciseRela">表关键字</param>
 /// <returns>表对象</returns>
public clsCaseExerciseRelaEN GetObjByIdCaseExerciseRela(long lngIdCaseExerciseRela)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCaseExerciseRelaDA.GetSpecSQLObj();
strSQL = "Select * from CaseExerciseRela where IdCaseExerciseRela = " + ""+ lngIdCaseExerciseRela+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsCaseExerciseRelaEN objCaseExerciseRelaEN = new clsCaseExerciseRelaEN();
try
{
 objCaseExerciseRelaEN.IdCaseExerciseRela = Int32.Parse(objRow[conCaseExerciseRela.IdCaseExerciseRela].ToString().Trim()); //案例习题关系流水号(字段类型:bigint,字段长度:8,是否可空:False)
 objCaseExerciseRelaEN.FuncModuleId = objRow[conCaseExerciseRela.FuncModuleId].ToString().Trim(); //功能模块Id(字段类型:char,字段长度:4,是否可空:True)
 objCaseExerciseRelaEN.CaseId = objRow[conCaseExerciseRela.CaseId].ToString().Trim(); //案例Id(字段类型:char,字段长度:8,是否可空:True)
 objCaseExerciseRelaEN.CaseName = objRow[conCaseExerciseRela.CaseName].ToString().Trim(); //案例名称(字段类型:varchar,字段长度:100,是否可空:True)
 objCaseExerciseRelaEN.OwnerId = objRow[conCaseExerciseRela.OwnerId] == DBNull.Value ? null : objRow[conCaseExerciseRela.OwnerId].ToString().Trim(); //拥有者Id(字段类型:varchar,字段长度:20,是否可空:False)
 objCaseExerciseRelaEN.CourseExamPaperId = objRow[conCaseExerciseRela.CourseExamPaperId] == DBNull.Value ? null : objRow[conCaseExerciseRela.CourseExamPaperId].ToString().Trim(); //考卷流水号(字段类型:char,字段长度:8,是否可空:True)
 objCaseExerciseRelaEN.CourseId = objRow[conCaseExerciseRela.CourseId].ToString().Trim(); //课程Id(字段类型:char,字段长度:8,是否可空:True)
 objCaseExerciseRelaEN.ExamPaperTypeId = objRow[conCaseExerciseRela.ExamPaperTypeId].ToString().Trim(); //试卷类型Id(字段类型:char,字段长度:2,是否可空:False)
 objCaseExerciseRelaEN.BrowseCount = Int32.Parse(objRow[conCaseExerciseRela.BrowseCount].ToString().Trim()); //浏览次数(字段类型:int,字段长度:4,是否可空:True)
 objCaseExerciseRelaEN.UpdDate = objRow[conCaseExerciseRela.UpdDate] == DBNull.Value ? null : objRow[conCaseExerciseRela.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objCaseExerciseRelaEN.UpdUserId = objRow[conCaseExerciseRela.UpdUserId] == DBNull.Value ? null : objRow[conCaseExerciseRela.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:True)
 objCaseExerciseRelaEN.Memo = objRow[conCaseExerciseRela.Memo] == DBNull.Value ? null : objRow[conCaseExerciseRela.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsCaseExerciseRelaDA: GetObjByIdCaseExerciseRela)", objException.Message));
}
return objCaseExerciseRelaEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsCaseExerciseRelaEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsCaseExerciseRelaDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCaseExerciseRelaDA.GetSpecSQLObj();
strSQL = "Select * from CaseExerciseRela where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsCaseExerciseRelaEN objCaseExerciseRelaEN = new clsCaseExerciseRelaEN()
{
IdCaseExerciseRela = TransNullToInt(objRow[conCaseExerciseRela.IdCaseExerciseRela].ToString().Trim()), //案例习题关系流水号
FuncModuleId = objRow[conCaseExerciseRela.FuncModuleId].ToString().Trim(), //功能模块Id
CaseId = objRow[conCaseExerciseRela.CaseId].ToString().Trim(), //案例Id
CaseName = objRow[conCaseExerciseRela.CaseName].ToString().Trim(), //案例名称
OwnerId = objRow[conCaseExerciseRela.OwnerId] == DBNull.Value ? null : objRow[conCaseExerciseRela.OwnerId].ToString().Trim(), //拥有者Id
CourseExamPaperId = objRow[conCaseExerciseRela.CourseExamPaperId] == DBNull.Value ? null : objRow[conCaseExerciseRela.CourseExamPaperId].ToString().Trim(), //考卷流水号
CourseId = objRow[conCaseExerciseRela.CourseId].ToString().Trim(), //课程Id
ExamPaperTypeId = objRow[conCaseExerciseRela.ExamPaperTypeId].ToString().Trim(), //试卷类型Id
BrowseCount = TransNullToInt(objRow[conCaseExerciseRela.BrowseCount].ToString().Trim()), //浏览次数
UpdDate = objRow[conCaseExerciseRela.UpdDate] == DBNull.Value ? null : objRow[conCaseExerciseRela.UpdDate].ToString().Trim(), //修改日期
UpdUserId = objRow[conCaseExerciseRela.UpdUserId] == DBNull.Value ? null : objRow[conCaseExerciseRela.UpdUserId].ToString().Trim(), //修改用户Id
Memo = objRow[conCaseExerciseRela.Memo] == DBNull.Value ? null : objRow[conCaseExerciseRela.Memo].ToString().Trim() //备注
};
objCaseExerciseRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objCaseExerciseRelaEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsCaseExerciseRelaDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsCaseExerciseRelaEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsCaseExerciseRelaEN objCaseExerciseRelaEN = new clsCaseExerciseRelaEN();
try
{
objCaseExerciseRelaEN.IdCaseExerciseRela = TransNullToInt(objRow[conCaseExerciseRela.IdCaseExerciseRela].ToString().Trim()); //案例习题关系流水号
objCaseExerciseRelaEN.FuncModuleId = objRow[conCaseExerciseRela.FuncModuleId].ToString().Trim(); //功能模块Id
objCaseExerciseRelaEN.CaseId = objRow[conCaseExerciseRela.CaseId].ToString().Trim(); //案例Id
objCaseExerciseRelaEN.CaseName = objRow[conCaseExerciseRela.CaseName].ToString().Trim(); //案例名称
objCaseExerciseRelaEN.OwnerId = objRow[conCaseExerciseRela.OwnerId] == DBNull.Value ? null : objRow[conCaseExerciseRela.OwnerId].ToString().Trim(); //拥有者Id
objCaseExerciseRelaEN.CourseExamPaperId = objRow[conCaseExerciseRela.CourseExamPaperId] == DBNull.Value ? null : objRow[conCaseExerciseRela.CourseExamPaperId].ToString().Trim(); //考卷流水号
objCaseExerciseRelaEN.CourseId = objRow[conCaseExerciseRela.CourseId].ToString().Trim(); //课程Id
objCaseExerciseRelaEN.ExamPaperTypeId = objRow[conCaseExerciseRela.ExamPaperTypeId].ToString().Trim(); //试卷类型Id
objCaseExerciseRelaEN.BrowseCount = TransNullToInt(objRow[conCaseExerciseRela.BrowseCount].ToString().Trim()); //浏览次数
objCaseExerciseRelaEN.UpdDate = objRow[conCaseExerciseRela.UpdDate] == DBNull.Value ? null : objRow[conCaseExerciseRela.UpdDate].ToString().Trim(); //修改日期
objCaseExerciseRelaEN.UpdUserId = objRow[conCaseExerciseRela.UpdUserId] == DBNull.Value ? null : objRow[conCaseExerciseRela.UpdUserId].ToString().Trim(); //修改用户Id
objCaseExerciseRelaEN.Memo = objRow[conCaseExerciseRela.Memo] == DBNull.Value ? null : objRow[conCaseExerciseRela.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsCaseExerciseRelaDA: GetObjByDataRowCaseExerciseRela)", objException.Message));
}
objCaseExerciseRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objCaseExerciseRelaEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsCaseExerciseRelaEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsCaseExerciseRelaEN objCaseExerciseRelaEN = new clsCaseExerciseRelaEN();
try
{
objCaseExerciseRelaEN.IdCaseExerciseRela = TransNullToInt(objRow[conCaseExerciseRela.IdCaseExerciseRela].ToString().Trim()); //案例习题关系流水号
objCaseExerciseRelaEN.FuncModuleId = objRow[conCaseExerciseRela.FuncModuleId].ToString().Trim(); //功能模块Id
objCaseExerciseRelaEN.CaseId = objRow[conCaseExerciseRela.CaseId].ToString().Trim(); //案例Id
objCaseExerciseRelaEN.CaseName = objRow[conCaseExerciseRela.CaseName].ToString().Trim(); //案例名称
objCaseExerciseRelaEN.OwnerId = objRow[conCaseExerciseRela.OwnerId] == DBNull.Value ? null : objRow[conCaseExerciseRela.OwnerId].ToString().Trim(); //拥有者Id
objCaseExerciseRelaEN.CourseExamPaperId = objRow[conCaseExerciseRela.CourseExamPaperId] == DBNull.Value ? null : objRow[conCaseExerciseRela.CourseExamPaperId].ToString().Trim(); //考卷流水号
objCaseExerciseRelaEN.CourseId = objRow[conCaseExerciseRela.CourseId].ToString().Trim(); //课程Id
objCaseExerciseRelaEN.ExamPaperTypeId = objRow[conCaseExerciseRela.ExamPaperTypeId].ToString().Trim(); //试卷类型Id
objCaseExerciseRelaEN.BrowseCount = TransNullToInt(objRow[conCaseExerciseRela.BrowseCount].ToString().Trim()); //浏览次数
objCaseExerciseRelaEN.UpdDate = objRow[conCaseExerciseRela.UpdDate] == DBNull.Value ? null : objRow[conCaseExerciseRela.UpdDate].ToString().Trim(); //修改日期
objCaseExerciseRelaEN.UpdUserId = objRow[conCaseExerciseRela.UpdUserId] == DBNull.Value ? null : objRow[conCaseExerciseRela.UpdUserId].ToString().Trim(); //修改用户Id
objCaseExerciseRelaEN.Memo = objRow[conCaseExerciseRela.Memo] == DBNull.Value ? null : objRow[conCaseExerciseRela.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsCaseExerciseRelaDA: GetObjByDataRow)", objException.Message));
}
objCaseExerciseRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objCaseExerciseRelaEN;
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
objSQL = clsCaseExerciseRelaDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsCaseExerciseRelaEN._CurrTabName, conCaseExerciseRela.IdCaseExerciseRela, 8, "");
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
objSQL = clsCaseExerciseRelaDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsCaseExerciseRelaEN._CurrTabName, conCaseExerciseRela.IdCaseExerciseRela, 8, strPrefix);
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
 objSQL = clsCaseExerciseRelaDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select IdCaseExerciseRela from CaseExerciseRela where " + strCondition;
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
 objSQL = clsCaseExerciseRelaDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select IdCaseExerciseRela from CaseExerciseRela where " + strCondition;
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
 objSQL = clsCaseExerciseRelaDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("CaseExerciseRela", "IdCaseExerciseRela = " + ""+ lngIdCaseExerciseRela+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsCaseExerciseRelaDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCaseExerciseRelaDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("CaseExerciseRela", strCondition))
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
objSQL = clsCaseExerciseRelaDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("CaseExerciseRela");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsCaseExerciseRelaEN objCaseExerciseRelaEN)
 {
 objCaseExerciseRelaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCaseExerciseRelaEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objCaseExerciseRelaEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCaseExerciseRelaDA.GetSpecSQLObj();
strSQL = "Select * from CaseExerciseRela where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "CaseExerciseRela");
objRow = objDS.Tables["CaseExerciseRela"].NewRow();
objRow[conCaseExerciseRela.FuncModuleId] = objCaseExerciseRelaEN.FuncModuleId; //功能模块Id
objRow[conCaseExerciseRela.CaseId] = objCaseExerciseRelaEN.CaseId; //案例Id
objRow[conCaseExerciseRela.CaseName] = objCaseExerciseRelaEN.CaseName; //案例名称
 if (objCaseExerciseRelaEN.OwnerId !=  "")
 {
objRow[conCaseExerciseRela.OwnerId] = objCaseExerciseRelaEN.OwnerId; //拥有者Id
 }
 if (objCaseExerciseRelaEN.CourseExamPaperId !=  "")
 {
objRow[conCaseExerciseRela.CourseExamPaperId] = objCaseExerciseRelaEN.CourseExamPaperId; //考卷流水号
 }
objRow[conCaseExerciseRela.CourseId] = objCaseExerciseRelaEN.CourseId; //课程Id
objRow[conCaseExerciseRela.ExamPaperTypeId] = objCaseExerciseRelaEN.ExamPaperTypeId; //试卷类型Id
objRow[conCaseExerciseRela.BrowseCount] = objCaseExerciseRelaEN.BrowseCount; //浏览次数
 if (objCaseExerciseRelaEN.UpdDate !=  "")
 {
objRow[conCaseExerciseRela.UpdDate] = objCaseExerciseRelaEN.UpdDate; //修改日期
 }
 if (objCaseExerciseRelaEN.UpdUserId !=  "")
 {
objRow[conCaseExerciseRela.UpdUserId] = objCaseExerciseRelaEN.UpdUserId; //修改用户Id
 }
 if (objCaseExerciseRelaEN.Memo !=  "")
 {
objRow[conCaseExerciseRela.Memo] = objCaseExerciseRelaEN.Memo; //备注
 }
objDS.Tables[clsCaseExerciseRelaEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsCaseExerciseRelaEN._CurrTabName);
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
 /// <param name = "objCaseExerciseRelaEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsCaseExerciseRelaEN objCaseExerciseRelaEN)
{
 objCaseExerciseRelaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCaseExerciseRelaEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objCaseExerciseRelaEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objCaseExerciseRelaEN.FuncModuleId !=  null)
 {
 arrFieldListForInsert.Add(conCaseExerciseRela.FuncModuleId);
 var strFuncModuleId = objCaseExerciseRelaEN.FuncModuleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncModuleId + "'");
 }
 
 if (objCaseExerciseRelaEN.CaseId !=  null)
 {
 arrFieldListForInsert.Add(conCaseExerciseRela.CaseId);
 var strCaseId = objCaseExerciseRelaEN.CaseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCaseId + "'");
 }
 
 if (objCaseExerciseRelaEN.CaseName !=  null)
 {
 arrFieldListForInsert.Add(conCaseExerciseRela.CaseName);
 var strCaseName = objCaseExerciseRelaEN.CaseName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCaseName + "'");
 }
 
 if (objCaseExerciseRelaEN.OwnerId !=  null)
 {
 arrFieldListForInsert.Add(conCaseExerciseRela.OwnerId);
 var strOwnerId = objCaseExerciseRelaEN.OwnerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strOwnerId + "'");
 }
 
 if (objCaseExerciseRelaEN.CourseExamPaperId  ==  "")
 {
 objCaseExerciseRelaEN.CourseExamPaperId = null;
 }
 if (objCaseExerciseRelaEN.CourseExamPaperId !=  null)
 {
 arrFieldListForInsert.Add(conCaseExerciseRela.CourseExamPaperId);
 var strCourseExamPaperId = objCaseExerciseRelaEN.CourseExamPaperId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseExamPaperId + "'");
 }
 
 if (objCaseExerciseRelaEN.CourseId  ==  "")
 {
 objCaseExerciseRelaEN.CourseId = null;
 }
 if (objCaseExerciseRelaEN.CourseId !=  null)
 {
 arrFieldListForInsert.Add(conCaseExerciseRela.CourseId);
 var strCourseId = objCaseExerciseRelaEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseId + "'");
 }
 
 if (objCaseExerciseRelaEN.ExamPaperTypeId !=  null)
 {
 arrFieldListForInsert.Add(conCaseExerciseRela.ExamPaperTypeId);
 var strExamPaperTypeId = objCaseExerciseRelaEN.ExamPaperTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strExamPaperTypeId + "'");
 }
 
 arrFieldListForInsert.Add(conCaseExerciseRela.BrowseCount);
 arrValueListForInsert.Add(objCaseExerciseRelaEN.BrowseCount.ToString());
 
 if (objCaseExerciseRelaEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conCaseExerciseRela.UpdDate);
 var strUpdDate = objCaseExerciseRelaEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objCaseExerciseRelaEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(conCaseExerciseRela.UpdUserId);
 var strUpdUserId = objCaseExerciseRelaEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objCaseExerciseRelaEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conCaseExerciseRela.Memo);
 var strMemo = objCaseExerciseRelaEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into CaseExerciseRela");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCaseExerciseRelaDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objCaseExerciseRelaEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsCaseExerciseRelaEN objCaseExerciseRelaEN)
{
 objCaseExerciseRelaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCaseExerciseRelaEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objCaseExerciseRelaEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objCaseExerciseRelaEN.FuncModuleId !=  null)
 {
 arrFieldListForInsert.Add(conCaseExerciseRela.FuncModuleId);
 var strFuncModuleId = objCaseExerciseRelaEN.FuncModuleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncModuleId + "'");
 }
 
 if (objCaseExerciseRelaEN.CaseId !=  null)
 {
 arrFieldListForInsert.Add(conCaseExerciseRela.CaseId);
 var strCaseId = objCaseExerciseRelaEN.CaseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCaseId + "'");
 }
 
 if (objCaseExerciseRelaEN.CaseName !=  null)
 {
 arrFieldListForInsert.Add(conCaseExerciseRela.CaseName);
 var strCaseName = objCaseExerciseRelaEN.CaseName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCaseName + "'");
 }
 
 if (objCaseExerciseRelaEN.OwnerId !=  null)
 {
 arrFieldListForInsert.Add(conCaseExerciseRela.OwnerId);
 var strOwnerId = objCaseExerciseRelaEN.OwnerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strOwnerId + "'");
 }
 
 if (objCaseExerciseRelaEN.CourseExamPaperId  ==  "")
 {
 objCaseExerciseRelaEN.CourseExamPaperId = null;
 }
 if (objCaseExerciseRelaEN.CourseExamPaperId !=  null)
 {
 arrFieldListForInsert.Add(conCaseExerciseRela.CourseExamPaperId);
 var strCourseExamPaperId = objCaseExerciseRelaEN.CourseExamPaperId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseExamPaperId + "'");
 }
 
 if (objCaseExerciseRelaEN.CourseId  ==  "")
 {
 objCaseExerciseRelaEN.CourseId = null;
 }
 if (objCaseExerciseRelaEN.CourseId !=  null)
 {
 arrFieldListForInsert.Add(conCaseExerciseRela.CourseId);
 var strCourseId = objCaseExerciseRelaEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseId + "'");
 }
 
 if (objCaseExerciseRelaEN.ExamPaperTypeId !=  null)
 {
 arrFieldListForInsert.Add(conCaseExerciseRela.ExamPaperTypeId);
 var strExamPaperTypeId = objCaseExerciseRelaEN.ExamPaperTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strExamPaperTypeId + "'");
 }
 
 arrFieldListForInsert.Add(conCaseExerciseRela.BrowseCount);
 arrValueListForInsert.Add(objCaseExerciseRelaEN.BrowseCount.ToString());
 
 if (objCaseExerciseRelaEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conCaseExerciseRela.UpdDate);
 var strUpdDate = objCaseExerciseRelaEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objCaseExerciseRelaEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(conCaseExerciseRela.UpdUserId);
 var strUpdUserId = objCaseExerciseRelaEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objCaseExerciseRelaEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conCaseExerciseRela.Memo);
 var strMemo = objCaseExerciseRelaEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into CaseExerciseRela");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCaseExerciseRelaDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString()).Rows[0][0].ToString();
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objCaseExerciseRelaEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsCaseExerciseRelaEN objCaseExerciseRelaEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objCaseExerciseRelaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCaseExerciseRelaEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objCaseExerciseRelaEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objCaseExerciseRelaEN.FuncModuleId !=  null)
 {
 arrFieldListForInsert.Add(conCaseExerciseRela.FuncModuleId);
 var strFuncModuleId = objCaseExerciseRelaEN.FuncModuleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncModuleId + "'");
 }
 
 if (objCaseExerciseRelaEN.CaseId !=  null)
 {
 arrFieldListForInsert.Add(conCaseExerciseRela.CaseId);
 var strCaseId = objCaseExerciseRelaEN.CaseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCaseId + "'");
 }
 
 if (objCaseExerciseRelaEN.CaseName !=  null)
 {
 arrFieldListForInsert.Add(conCaseExerciseRela.CaseName);
 var strCaseName = objCaseExerciseRelaEN.CaseName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCaseName + "'");
 }
 
 if (objCaseExerciseRelaEN.OwnerId !=  null)
 {
 arrFieldListForInsert.Add(conCaseExerciseRela.OwnerId);
 var strOwnerId = objCaseExerciseRelaEN.OwnerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strOwnerId + "'");
 }
 
 if (objCaseExerciseRelaEN.CourseExamPaperId  ==  "")
 {
 objCaseExerciseRelaEN.CourseExamPaperId = null;
 }
 if (objCaseExerciseRelaEN.CourseExamPaperId !=  null)
 {
 arrFieldListForInsert.Add(conCaseExerciseRela.CourseExamPaperId);
 var strCourseExamPaperId = objCaseExerciseRelaEN.CourseExamPaperId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseExamPaperId + "'");
 }
 
 if (objCaseExerciseRelaEN.CourseId  ==  "")
 {
 objCaseExerciseRelaEN.CourseId = null;
 }
 if (objCaseExerciseRelaEN.CourseId !=  null)
 {
 arrFieldListForInsert.Add(conCaseExerciseRela.CourseId);
 var strCourseId = objCaseExerciseRelaEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseId + "'");
 }
 
 if (objCaseExerciseRelaEN.ExamPaperTypeId !=  null)
 {
 arrFieldListForInsert.Add(conCaseExerciseRela.ExamPaperTypeId);
 var strExamPaperTypeId = objCaseExerciseRelaEN.ExamPaperTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strExamPaperTypeId + "'");
 }
 
 arrFieldListForInsert.Add(conCaseExerciseRela.BrowseCount);
 arrValueListForInsert.Add(objCaseExerciseRelaEN.BrowseCount.ToString());
 
 if (objCaseExerciseRelaEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conCaseExerciseRela.UpdDate);
 var strUpdDate = objCaseExerciseRelaEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objCaseExerciseRelaEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(conCaseExerciseRela.UpdUserId);
 var strUpdUserId = objCaseExerciseRelaEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objCaseExerciseRelaEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conCaseExerciseRela.Memo);
 var strMemo = objCaseExerciseRelaEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into CaseExerciseRela");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCaseExerciseRelaDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString(), objSqlConnection, objSqlTransaction).Rows[0][0].ToString();
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objCaseExerciseRelaEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsCaseExerciseRelaEN objCaseExerciseRelaEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objCaseExerciseRelaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCaseExerciseRelaEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objCaseExerciseRelaEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objCaseExerciseRelaEN.FuncModuleId !=  null)
 {
 arrFieldListForInsert.Add(conCaseExerciseRela.FuncModuleId);
 var strFuncModuleId = objCaseExerciseRelaEN.FuncModuleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncModuleId + "'");
 }
 
 if (objCaseExerciseRelaEN.CaseId !=  null)
 {
 arrFieldListForInsert.Add(conCaseExerciseRela.CaseId);
 var strCaseId = objCaseExerciseRelaEN.CaseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCaseId + "'");
 }
 
 if (objCaseExerciseRelaEN.CaseName !=  null)
 {
 arrFieldListForInsert.Add(conCaseExerciseRela.CaseName);
 var strCaseName = objCaseExerciseRelaEN.CaseName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCaseName + "'");
 }
 
 if (objCaseExerciseRelaEN.OwnerId !=  null)
 {
 arrFieldListForInsert.Add(conCaseExerciseRela.OwnerId);
 var strOwnerId = objCaseExerciseRelaEN.OwnerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strOwnerId + "'");
 }
 
 if (objCaseExerciseRelaEN.CourseExamPaperId  ==  "")
 {
 objCaseExerciseRelaEN.CourseExamPaperId = null;
 }
 if (objCaseExerciseRelaEN.CourseExamPaperId !=  null)
 {
 arrFieldListForInsert.Add(conCaseExerciseRela.CourseExamPaperId);
 var strCourseExamPaperId = objCaseExerciseRelaEN.CourseExamPaperId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseExamPaperId + "'");
 }
 
 if (objCaseExerciseRelaEN.CourseId  ==  "")
 {
 objCaseExerciseRelaEN.CourseId = null;
 }
 if (objCaseExerciseRelaEN.CourseId !=  null)
 {
 arrFieldListForInsert.Add(conCaseExerciseRela.CourseId);
 var strCourseId = objCaseExerciseRelaEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseId + "'");
 }
 
 if (objCaseExerciseRelaEN.ExamPaperTypeId !=  null)
 {
 arrFieldListForInsert.Add(conCaseExerciseRela.ExamPaperTypeId);
 var strExamPaperTypeId = objCaseExerciseRelaEN.ExamPaperTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strExamPaperTypeId + "'");
 }
 
 arrFieldListForInsert.Add(conCaseExerciseRela.BrowseCount);
 arrValueListForInsert.Add(objCaseExerciseRelaEN.BrowseCount.ToString());
 
 if (objCaseExerciseRelaEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conCaseExerciseRela.UpdDate);
 var strUpdDate = objCaseExerciseRelaEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objCaseExerciseRelaEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(conCaseExerciseRela.UpdUserId);
 var strUpdUserId = objCaseExerciseRelaEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objCaseExerciseRelaEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conCaseExerciseRela.Memo);
 var strMemo = objCaseExerciseRelaEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into CaseExerciseRela");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCaseExerciseRelaDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewCaseExerciseRelas(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCaseExerciseRelaDA.GetSpecSQLObj();
strSQL = "Select * from CaseExerciseRela where IdCaseExerciseRela = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "CaseExerciseRela");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
long lngIdCaseExerciseRela = TransNullToInt(oRow[conCaseExerciseRela.IdCaseExerciseRela].ToString().Trim());
if (IsExist(lngIdCaseExerciseRela))
{
 string strResult = "关键字变量值为:" + string.Format("IdCaseExerciseRela = {0}", lngIdCaseExerciseRela) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsCaseExerciseRelaEN._CurrTabName ].NewRow();
objRow[conCaseExerciseRela.FuncModuleId] = oRow[conCaseExerciseRela.FuncModuleId].ToString().Trim(); //功能模块Id
objRow[conCaseExerciseRela.CaseId] = oRow[conCaseExerciseRela.CaseId].ToString().Trim(); //案例Id
objRow[conCaseExerciseRela.CaseName] = oRow[conCaseExerciseRela.CaseName].ToString().Trim(); //案例名称
objRow[conCaseExerciseRela.OwnerId] = oRow[conCaseExerciseRela.OwnerId].ToString().Trim(); //拥有者Id
objRow[conCaseExerciseRela.CourseExamPaperId] = oRow[conCaseExerciseRela.CourseExamPaperId].ToString().Trim(); //考卷流水号
objRow[conCaseExerciseRela.CourseId] = oRow[conCaseExerciseRela.CourseId].ToString().Trim(); //课程Id
objRow[conCaseExerciseRela.ExamPaperTypeId] = oRow[conCaseExerciseRela.ExamPaperTypeId].ToString().Trim(); //试卷类型Id
objRow[conCaseExerciseRela.BrowseCount] = oRow[conCaseExerciseRela.BrowseCount].ToString().Trim(); //浏览次数
objRow[conCaseExerciseRela.UpdDate] = oRow[conCaseExerciseRela.UpdDate].ToString().Trim(); //修改日期
objRow[conCaseExerciseRela.UpdUserId] = oRow[conCaseExerciseRela.UpdUserId].ToString().Trim(); //修改用户Id
objRow[conCaseExerciseRela.Memo] = oRow[conCaseExerciseRela.Memo].ToString().Trim(); //备注
 objDS.Tables[clsCaseExerciseRelaEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsCaseExerciseRelaEN._CurrTabName);
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
 /// <param name = "objCaseExerciseRelaEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsCaseExerciseRelaEN objCaseExerciseRelaEN)
{
 objCaseExerciseRelaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCaseExerciseRelaEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objCaseExerciseRelaEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCaseExerciseRelaDA.GetSpecSQLObj();
strSQL = "Select * from CaseExerciseRela where IdCaseExerciseRela = " + ""+ objCaseExerciseRelaEN.IdCaseExerciseRela+"";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsCaseExerciseRelaEN._CurrTabName);
if (objDS.Tables[clsCaseExerciseRelaEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:IdCaseExerciseRela = " + ""+ objCaseExerciseRelaEN.IdCaseExerciseRela+"");
return false;
}
objRow = objDS.Tables[clsCaseExerciseRelaEN._CurrTabName].Rows[0];
 if (objCaseExerciseRelaEN.IsUpdated(conCaseExerciseRela.FuncModuleId))
 {
objRow[conCaseExerciseRela.FuncModuleId] = objCaseExerciseRelaEN.FuncModuleId; //功能模块Id
 }
 if (objCaseExerciseRelaEN.IsUpdated(conCaseExerciseRela.CaseId))
 {
objRow[conCaseExerciseRela.CaseId] = objCaseExerciseRelaEN.CaseId; //案例Id
 }
 if (objCaseExerciseRelaEN.IsUpdated(conCaseExerciseRela.CaseName))
 {
objRow[conCaseExerciseRela.CaseName] = objCaseExerciseRelaEN.CaseName; //案例名称
 }
 if (objCaseExerciseRelaEN.IsUpdated(conCaseExerciseRela.OwnerId))
 {
objRow[conCaseExerciseRela.OwnerId] = objCaseExerciseRelaEN.OwnerId; //拥有者Id
 }
 if (objCaseExerciseRelaEN.IsUpdated(conCaseExerciseRela.CourseExamPaperId))
 {
objRow[conCaseExerciseRela.CourseExamPaperId] = objCaseExerciseRelaEN.CourseExamPaperId; //考卷流水号
 }
 if (objCaseExerciseRelaEN.IsUpdated(conCaseExerciseRela.CourseId))
 {
objRow[conCaseExerciseRela.CourseId] = objCaseExerciseRelaEN.CourseId; //课程Id
 }
 if (objCaseExerciseRelaEN.IsUpdated(conCaseExerciseRela.ExamPaperTypeId))
 {
objRow[conCaseExerciseRela.ExamPaperTypeId] = objCaseExerciseRelaEN.ExamPaperTypeId; //试卷类型Id
 }
 if (objCaseExerciseRelaEN.IsUpdated(conCaseExerciseRela.BrowseCount))
 {
objRow[conCaseExerciseRela.BrowseCount] = objCaseExerciseRelaEN.BrowseCount; //浏览次数
 }
 if (objCaseExerciseRelaEN.IsUpdated(conCaseExerciseRela.UpdDate))
 {
objRow[conCaseExerciseRela.UpdDate] = objCaseExerciseRelaEN.UpdDate; //修改日期
 }
 if (objCaseExerciseRelaEN.IsUpdated(conCaseExerciseRela.UpdUserId))
 {
objRow[conCaseExerciseRela.UpdUserId] = objCaseExerciseRelaEN.UpdUserId; //修改用户Id
 }
 if (objCaseExerciseRelaEN.IsUpdated(conCaseExerciseRela.Memo))
 {
objRow[conCaseExerciseRela.Memo] = objCaseExerciseRelaEN.Memo; //备注
 }
try
{
objDA.Update(objDS, clsCaseExerciseRelaEN._CurrTabName);
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
 /// <param name = "objCaseExerciseRelaEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsCaseExerciseRelaEN objCaseExerciseRelaEN)
{
 objCaseExerciseRelaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCaseExerciseRelaEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objCaseExerciseRelaEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCaseExerciseRelaDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update CaseExerciseRela Set ");
 
 if (objCaseExerciseRelaEN.IsUpdated(conCaseExerciseRela.FuncModuleId))
 {
 if (objCaseExerciseRelaEN.FuncModuleId !=  null)
 {
 var strFuncModuleId = objCaseExerciseRelaEN.FuncModuleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFuncModuleId, conCaseExerciseRela.FuncModuleId); //功能模块Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCaseExerciseRela.FuncModuleId); //功能模块Id
 }
 }
 
 if (objCaseExerciseRelaEN.IsUpdated(conCaseExerciseRela.CaseId))
 {
 if (objCaseExerciseRelaEN.CaseId !=  null)
 {
 var strCaseId = objCaseExerciseRelaEN.CaseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCaseId, conCaseExerciseRela.CaseId); //案例Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCaseExerciseRela.CaseId); //案例Id
 }
 }
 
 if (objCaseExerciseRelaEN.IsUpdated(conCaseExerciseRela.CaseName))
 {
 if (objCaseExerciseRelaEN.CaseName !=  null)
 {
 var strCaseName = objCaseExerciseRelaEN.CaseName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCaseName, conCaseExerciseRela.CaseName); //案例名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCaseExerciseRela.CaseName); //案例名称
 }
 }
 
 if (objCaseExerciseRelaEN.IsUpdated(conCaseExerciseRela.OwnerId))
 {
 if (objCaseExerciseRelaEN.OwnerId !=  null)
 {
 var strOwnerId = objCaseExerciseRelaEN.OwnerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strOwnerId, conCaseExerciseRela.OwnerId); //拥有者Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCaseExerciseRela.OwnerId); //拥有者Id
 }
 }
 
 if (objCaseExerciseRelaEN.IsUpdated(conCaseExerciseRela.CourseExamPaperId))
 {
 if (objCaseExerciseRelaEN.CourseExamPaperId  ==  "")
 {
 objCaseExerciseRelaEN.CourseExamPaperId = null;
 }
 if (objCaseExerciseRelaEN.CourseExamPaperId !=  null)
 {
 var strCourseExamPaperId = objCaseExerciseRelaEN.CourseExamPaperId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCourseExamPaperId, conCaseExerciseRela.CourseExamPaperId); //考卷流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCaseExerciseRela.CourseExamPaperId); //考卷流水号
 }
 }
 
 if (objCaseExerciseRelaEN.IsUpdated(conCaseExerciseRela.CourseId))
 {
 if (objCaseExerciseRelaEN.CourseId  ==  "")
 {
 objCaseExerciseRelaEN.CourseId = null;
 }
 if (objCaseExerciseRelaEN.CourseId !=  null)
 {
 var strCourseId = objCaseExerciseRelaEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCourseId, conCaseExerciseRela.CourseId); //课程Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCaseExerciseRela.CourseId); //课程Id
 }
 }
 
 if (objCaseExerciseRelaEN.IsUpdated(conCaseExerciseRela.ExamPaperTypeId))
 {
 if (objCaseExerciseRelaEN.ExamPaperTypeId !=  null)
 {
 var strExamPaperTypeId = objCaseExerciseRelaEN.ExamPaperTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strExamPaperTypeId, conCaseExerciseRela.ExamPaperTypeId); //试卷类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCaseExerciseRela.ExamPaperTypeId); //试卷类型Id
 }
 }
 
 if (objCaseExerciseRelaEN.IsUpdated(conCaseExerciseRela.BrowseCount))
 {
 sbSQL.AppendFormat("{1} = {0},",objCaseExerciseRelaEN.BrowseCount, conCaseExerciseRela.BrowseCount); //浏览次数
 }
 
 if (objCaseExerciseRelaEN.IsUpdated(conCaseExerciseRela.UpdDate))
 {
 if (objCaseExerciseRelaEN.UpdDate !=  null)
 {
 var strUpdDate = objCaseExerciseRelaEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conCaseExerciseRela.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCaseExerciseRela.UpdDate); //修改日期
 }
 }
 
 if (objCaseExerciseRelaEN.IsUpdated(conCaseExerciseRela.UpdUserId))
 {
 if (objCaseExerciseRelaEN.UpdUserId !=  null)
 {
 var strUpdUserId = objCaseExerciseRelaEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUserId, conCaseExerciseRela.UpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCaseExerciseRela.UpdUserId); //修改用户Id
 }
 }
 
 if (objCaseExerciseRelaEN.IsUpdated(conCaseExerciseRela.Memo))
 {
 if (objCaseExerciseRelaEN.Memo !=  null)
 {
 var strMemo = objCaseExerciseRelaEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conCaseExerciseRela.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCaseExerciseRela.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where IdCaseExerciseRela = {0}", objCaseExerciseRelaEN.IdCaseExerciseRela); 
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
 /// <param name = "objCaseExerciseRelaEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsCaseExerciseRelaEN objCaseExerciseRelaEN, string strCondition)
{
 objCaseExerciseRelaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCaseExerciseRelaEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objCaseExerciseRelaEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCaseExerciseRelaDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update CaseExerciseRela Set ");
 
 if (objCaseExerciseRelaEN.IsUpdated(conCaseExerciseRela.FuncModuleId))
 {
 if (objCaseExerciseRelaEN.FuncModuleId !=  null)
 {
 var strFuncModuleId = objCaseExerciseRelaEN.FuncModuleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FuncModuleId = '{0}',", strFuncModuleId); //功能模块Id
 }
 else
 {
 sbSQL.Append(" FuncModuleId = null,"); //功能模块Id
 }
 }
 
 if (objCaseExerciseRelaEN.IsUpdated(conCaseExerciseRela.CaseId))
 {
 if (objCaseExerciseRelaEN.CaseId !=  null)
 {
 var strCaseId = objCaseExerciseRelaEN.CaseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CaseId = '{0}',", strCaseId); //案例Id
 }
 else
 {
 sbSQL.Append(" CaseId = null,"); //案例Id
 }
 }
 
 if (objCaseExerciseRelaEN.IsUpdated(conCaseExerciseRela.CaseName))
 {
 if (objCaseExerciseRelaEN.CaseName !=  null)
 {
 var strCaseName = objCaseExerciseRelaEN.CaseName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CaseName = '{0}',", strCaseName); //案例名称
 }
 else
 {
 sbSQL.Append(" CaseName = null,"); //案例名称
 }
 }
 
 if (objCaseExerciseRelaEN.IsUpdated(conCaseExerciseRela.OwnerId))
 {
 if (objCaseExerciseRelaEN.OwnerId !=  null)
 {
 var strOwnerId = objCaseExerciseRelaEN.OwnerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" OwnerId = '{0}',", strOwnerId); //拥有者Id
 }
 else
 {
 sbSQL.Append(" OwnerId = null,"); //拥有者Id
 }
 }
 
 if (objCaseExerciseRelaEN.IsUpdated(conCaseExerciseRela.CourseExamPaperId))
 {
 if (objCaseExerciseRelaEN.CourseExamPaperId  ==  "")
 {
 objCaseExerciseRelaEN.CourseExamPaperId = null;
 }
 if (objCaseExerciseRelaEN.CourseExamPaperId !=  null)
 {
 var strCourseExamPaperId = objCaseExerciseRelaEN.CourseExamPaperId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CourseExamPaperId = '{0}',", strCourseExamPaperId); //考卷流水号
 }
 else
 {
 sbSQL.Append(" CourseExamPaperId = null,"); //考卷流水号
 }
 }
 
 if (objCaseExerciseRelaEN.IsUpdated(conCaseExerciseRela.CourseId))
 {
 if (objCaseExerciseRelaEN.CourseId  ==  "")
 {
 objCaseExerciseRelaEN.CourseId = null;
 }
 if (objCaseExerciseRelaEN.CourseId !=  null)
 {
 var strCourseId = objCaseExerciseRelaEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CourseId = '{0}',", strCourseId); //课程Id
 }
 else
 {
 sbSQL.Append(" CourseId = null,"); //课程Id
 }
 }
 
 if (objCaseExerciseRelaEN.IsUpdated(conCaseExerciseRela.ExamPaperTypeId))
 {
 if (objCaseExerciseRelaEN.ExamPaperTypeId !=  null)
 {
 var strExamPaperTypeId = objCaseExerciseRelaEN.ExamPaperTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ExamPaperTypeId = '{0}',", strExamPaperTypeId); //试卷类型Id
 }
 else
 {
 sbSQL.Append(" ExamPaperTypeId = null,"); //试卷类型Id
 }
 }
 
 if (objCaseExerciseRelaEN.IsUpdated(conCaseExerciseRela.BrowseCount))
 {
 sbSQL.AppendFormat(" BrowseCount = {0},", objCaseExerciseRelaEN.BrowseCount); //浏览次数
 }
 
 if (objCaseExerciseRelaEN.IsUpdated(conCaseExerciseRela.UpdDate))
 {
 if (objCaseExerciseRelaEN.UpdDate !=  null)
 {
 var strUpdDate = objCaseExerciseRelaEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objCaseExerciseRelaEN.IsUpdated(conCaseExerciseRela.UpdUserId))
 {
 if (objCaseExerciseRelaEN.UpdUserId !=  null)
 {
 var strUpdUserId = objCaseExerciseRelaEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUserId = '{0}',", strUpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.Append(" UpdUserId = null,"); //修改用户Id
 }
 }
 
 if (objCaseExerciseRelaEN.IsUpdated(conCaseExerciseRela.Memo))
 {
 if (objCaseExerciseRelaEN.Memo !=  null)
 {
 var strMemo = objCaseExerciseRelaEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objCaseExerciseRelaEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsCaseExerciseRelaEN objCaseExerciseRelaEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objCaseExerciseRelaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCaseExerciseRelaEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objCaseExerciseRelaEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCaseExerciseRelaDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update CaseExerciseRela Set ");
 
 if (objCaseExerciseRelaEN.IsUpdated(conCaseExerciseRela.FuncModuleId))
 {
 if (objCaseExerciseRelaEN.FuncModuleId !=  null)
 {
 var strFuncModuleId = objCaseExerciseRelaEN.FuncModuleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FuncModuleId = '{0}',", strFuncModuleId); //功能模块Id
 }
 else
 {
 sbSQL.Append(" FuncModuleId = null,"); //功能模块Id
 }
 }
 
 if (objCaseExerciseRelaEN.IsUpdated(conCaseExerciseRela.CaseId))
 {
 if (objCaseExerciseRelaEN.CaseId !=  null)
 {
 var strCaseId = objCaseExerciseRelaEN.CaseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CaseId = '{0}',", strCaseId); //案例Id
 }
 else
 {
 sbSQL.Append(" CaseId = null,"); //案例Id
 }
 }
 
 if (objCaseExerciseRelaEN.IsUpdated(conCaseExerciseRela.CaseName))
 {
 if (objCaseExerciseRelaEN.CaseName !=  null)
 {
 var strCaseName = objCaseExerciseRelaEN.CaseName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CaseName = '{0}',", strCaseName); //案例名称
 }
 else
 {
 sbSQL.Append(" CaseName = null,"); //案例名称
 }
 }
 
 if (objCaseExerciseRelaEN.IsUpdated(conCaseExerciseRela.OwnerId))
 {
 if (objCaseExerciseRelaEN.OwnerId !=  null)
 {
 var strOwnerId = objCaseExerciseRelaEN.OwnerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" OwnerId = '{0}',", strOwnerId); //拥有者Id
 }
 else
 {
 sbSQL.Append(" OwnerId = null,"); //拥有者Id
 }
 }
 
 if (objCaseExerciseRelaEN.IsUpdated(conCaseExerciseRela.CourseExamPaperId))
 {
 if (objCaseExerciseRelaEN.CourseExamPaperId  ==  "")
 {
 objCaseExerciseRelaEN.CourseExamPaperId = null;
 }
 if (objCaseExerciseRelaEN.CourseExamPaperId !=  null)
 {
 var strCourseExamPaperId = objCaseExerciseRelaEN.CourseExamPaperId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CourseExamPaperId = '{0}',", strCourseExamPaperId); //考卷流水号
 }
 else
 {
 sbSQL.Append(" CourseExamPaperId = null,"); //考卷流水号
 }
 }
 
 if (objCaseExerciseRelaEN.IsUpdated(conCaseExerciseRela.CourseId))
 {
 if (objCaseExerciseRelaEN.CourseId  ==  "")
 {
 objCaseExerciseRelaEN.CourseId = null;
 }
 if (objCaseExerciseRelaEN.CourseId !=  null)
 {
 var strCourseId = objCaseExerciseRelaEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CourseId = '{0}',", strCourseId); //课程Id
 }
 else
 {
 sbSQL.Append(" CourseId = null,"); //课程Id
 }
 }
 
 if (objCaseExerciseRelaEN.IsUpdated(conCaseExerciseRela.ExamPaperTypeId))
 {
 if (objCaseExerciseRelaEN.ExamPaperTypeId !=  null)
 {
 var strExamPaperTypeId = objCaseExerciseRelaEN.ExamPaperTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ExamPaperTypeId = '{0}',", strExamPaperTypeId); //试卷类型Id
 }
 else
 {
 sbSQL.Append(" ExamPaperTypeId = null,"); //试卷类型Id
 }
 }
 
 if (objCaseExerciseRelaEN.IsUpdated(conCaseExerciseRela.BrowseCount))
 {
 sbSQL.AppendFormat(" BrowseCount = {0},", objCaseExerciseRelaEN.BrowseCount); //浏览次数
 }
 
 if (objCaseExerciseRelaEN.IsUpdated(conCaseExerciseRela.UpdDate))
 {
 if (objCaseExerciseRelaEN.UpdDate !=  null)
 {
 var strUpdDate = objCaseExerciseRelaEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objCaseExerciseRelaEN.IsUpdated(conCaseExerciseRela.UpdUserId))
 {
 if (objCaseExerciseRelaEN.UpdUserId !=  null)
 {
 var strUpdUserId = objCaseExerciseRelaEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUserId = '{0}',", strUpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.Append(" UpdUserId = null,"); //修改用户Id
 }
 }
 
 if (objCaseExerciseRelaEN.IsUpdated(conCaseExerciseRela.Memo))
 {
 if (objCaseExerciseRelaEN.Memo !=  null)
 {
 var strMemo = objCaseExerciseRelaEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objCaseExerciseRelaEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsCaseExerciseRelaEN objCaseExerciseRelaEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objCaseExerciseRelaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCaseExerciseRelaEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objCaseExerciseRelaEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCaseExerciseRelaDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update CaseExerciseRela Set ");
 
 if (objCaseExerciseRelaEN.IsUpdated(conCaseExerciseRela.FuncModuleId))
 {
 if (objCaseExerciseRelaEN.FuncModuleId !=  null)
 {
 var strFuncModuleId = objCaseExerciseRelaEN.FuncModuleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFuncModuleId, conCaseExerciseRela.FuncModuleId); //功能模块Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCaseExerciseRela.FuncModuleId); //功能模块Id
 }
 }
 
 if (objCaseExerciseRelaEN.IsUpdated(conCaseExerciseRela.CaseId))
 {
 if (objCaseExerciseRelaEN.CaseId !=  null)
 {
 var strCaseId = objCaseExerciseRelaEN.CaseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCaseId, conCaseExerciseRela.CaseId); //案例Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCaseExerciseRela.CaseId); //案例Id
 }
 }
 
 if (objCaseExerciseRelaEN.IsUpdated(conCaseExerciseRela.CaseName))
 {
 if (objCaseExerciseRelaEN.CaseName !=  null)
 {
 var strCaseName = objCaseExerciseRelaEN.CaseName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCaseName, conCaseExerciseRela.CaseName); //案例名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCaseExerciseRela.CaseName); //案例名称
 }
 }
 
 if (objCaseExerciseRelaEN.IsUpdated(conCaseExerciseRela.OwnerId))
 {
 if (objCaseExerciseRelaEN.OwnerId !=  null)
 {
 var strOwnerId = objCaseExerciseRelaEN.OwnerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strOwnerId, conCaseExerciseRela.OwnerId); //拥有者Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCaseExerciseRela.OwnerId); //拥有者Id
 }
 }
 
 if (objCaseExerciseRelaEN.IsUpdated(conCaseExerciseRela.CourseExamPaperId))
 {
 if (objCaseExerciseRelaEN.CourseExamPaperId  ==  "")
 {
 objCaseExerciseRelaEN.CourseExamPaperId = null;
 }
 if (objCaseExerciseRelaEN.CourseExamPaperId !=  null)
 {
 var strCourseExamPaperId = objCaseExerciseRelaEN.CourseExamPaperId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCourseExamPaperId, conCaseExerciseRela.CourseExamPaperId); //考卷流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCaseExerciseRela.CourseExamPaperId); //考卷流水号
 }
 }
 
 if (objCaseExerciseRelaEN.IsUpdated(conCaseExerciseRela.CourseId))
 {
 if (objCaseExerciseRelaEN.CourseId  ==  "")
 {
 objCaseExerciseRelaEN.CourseId = null;
 }
 if (objCaseExerciseRelaEN.CourseId !=  null)
 {
 var strCourseId = objCaseExerciseRelaEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCourseId, conCaseExerciseRela.CourseId); //课程Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCaseExerciseRela.CourseId); //课程Id
 }
 }
 
 if (objCaseExerciseRelaEN.IsUpdated(conCaseExerciseRela.ExamPaperTypeId))
 {
 if (objCaseExerciseRelaEN.ExamPaperTypeId !=  null)
 {
 var strExamPaperTypeId = objCaseExerciseRelaEN.ExamPaperTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strExamPaperTypeId, conCaseExerciseRela.ExamPaperTypeId); //试卷类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCaseExerciseRela.ExamPaperTypeId); //试卷类型Id
 }
 }
 
 if (objCaseExerciseRelaEN.IsUpdated(conCaseExerciseRela.BrowseCount))
 {
 sbSQL.AppendFormat("{1} = {0},",objCaseExerciseRelaEN.BrowseCount, conCaseExerciseRela.BrowseCount); //浏览次数
 }
 
 if (objCaseExerciseRelaEN.IsUpdated(conCaseExerciseRela.UpdDate))
 {
 if (objCaseExerciseRelaEN.UpdDate !=  null)
 {
 var strUpdDate = objCaseExerciseRelaEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conCaseExerciseRela.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCaseExerciseRela.UpdDate); //修改日期
 }
 }
 
 if (objCaseExerciseRelaEN.IsUpdated(conCaseExerciseRela.UpdUserId))
 {
 if (objCaseExerciseRelaEN.UpdUserId !=  null)
 {
 var strUpdUserId = objCaseExerciseRelaEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUserId, conCaseExerciseRela.UpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCaseExerciseRela.UpdUserId); //修改用户Id
 }
 }
 
 if (objCaseExerciseRelaEN.IsUpdated(conCaseExerciseRela.Memo))
 {
 if (objCaseExerciseRelaEN.Memo !=  null)
 {
 var strMemo = objCaseExerciseRelaEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conCaseExerciseRela.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCaseExerciseRela.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where IdCaseExerciseRela = {0}", objCaseExerciseRelaEN.IdCaseExerciseRela); 
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
 /// <param name = "lngIdCaseExerciseRela">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(long lngIdCaseExerciseRela) 
{
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCaseExerciseRelaDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 lngIdCaseExerciseRela,
};
 objSQL.ExecSP("CaseExerciseRela_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "lngIdCaseExerciseRela">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(long lngIdCaseExerciseRela, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCaseExerciseRelaDA.GetSpecSQLObj();
//删除CaseExerciseRela本表中与当前对象有关的记录
strSQL = strSQL + "Delete from CaseExerciseRela where IdCaseExerciseRela = " + ""+ lngIdCaseExerciseRela+"";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelCaseExerciseRela(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCaseExerciseRelaDA.GetSpecSQLObj();
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
//删除CaseExerciseRela本表中与当前对象有关的记录
strSQL = strSQL + "Delete from CaseExerciseRela where IdCaseExerciseRela in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "lngIdCaseExerciseRela">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(long lngIdCaseExerciseRela) 
{
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCaseExerciseRelaDA.GetSpecSQLObj();
//删除CaseExerciseRela本表中与当前对象有关的记录
strSQL = strSQL + "Delete from CaseExerciseRela where IdCaseExerciseRela = " + ""+ lngIdCaseExerciseRela+"";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelCaseExerciseRela(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsCaseExerciseRelaDA: DelCaseExerciseRela)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCaseExerciseRelaDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from CaseExerciseRela where " + strCondition ;
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
public bool DelCaseExerciseRelaWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsCaseExerciseRelaDA: DelCaseExerciseRelaWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCaseExerciseRelaDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from CaseExerciseRela where " + strCondition ;
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
 /// <param name = "objCaseExerciseRelaENS">源对象</param>
 /// <param name = "objCaseExerciseRelaENT">目标对象</param>
public void CopyTo(clsCaseExerciseRelaEN objCaseExerciseRelaENS, clsCaseExerciseRelaEN objCaseExerciseRelaENT)
{
objCaseExerciseRelaENT.IdCaseExerciseRela = objCaseExerciseRelaENS.IdCaseExerciseRela; //案例习题关系流水号
objCaseExerciseRelaENT.FuncModuleId = objCaseExerciseRelaENS.FuncModuleId; //功能模块Id
objCaseExerciseRelaENT.CaseId = objCaseExerciseRelaENS.CaseId; //案例Id
objCaseExerciseRelaENT.CaseName = objCaseExerciseRelaENS.CaseName; //案例名称
objCaseExerciseRelaENT.OwnerId = objCaseExerciseRelaENS.OwnerId; //拥有者Id
objCaseExerciseRelaENT.CourseExamPaperId = objCaseExerciseRelaENS.CourseExamPaperId; //考卷流水号
objCaseExerciseRelaENT.CourseId = objCaseExerciseRelaENS.CourseId; //课程Id
objCaseExerciseRelaENT.ExamPaperTypeId = objCaseExerciseRelaENS.ExamPaperTypeId; //试卷类型Id
objCaseExerciseRelaENT.BrowseCount = objCaseExerciseRelaENS.BrowseCount; //浏览次数
objCaseExerciseRelaENT.UpdDate = objCaseExerciseRelaENS.UpdDate; //修改日期
objCaseExerciseRelaENT.UpdUserId = objCaseExerciseRelaENS.UpdUserId; //修改用户Id
objCaseExerciseRelaENT.Memo = objCaseExerciseRelaENS.Memo; //备注
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsCaseExerciseRelaEN objCaseExerciseRelaEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objCaseExerciseRelaEN.FuncModuleId, conCaseExerciseRela.FuncModuleId);
clsCheckSql.CheckFieldNotNull(objCaseExerciseRelaEN.CaseId, conCaseExerciseRela.CaseId);
clsCheckSql.CheckFieldNotNull(objCaseExerciseRelaEN.CaseName, conCaseExerciseRela.CaseName);
clsCheckSql.CheckFieldNotNull(objCaseExerciseRelaEN.CourseId, conCaseExerciseRela.CourseId);
clsCheckSql.CheckFieldNotNull(objCaseExerciseRelaEN.ExamPaperTypeId, conCaseExerciseRela.ExamPaperTypeId);
clsCheckSql.CheckFieldNotNull(objCaseExerciseRelaEN.BrowseCount, conCaseExerciseRela.BrowseCount);
//检查字段长度
clsCheckSql.CheckFieldLen(objCaseExerciseRelaEN.FuncModuleId, 4, conCaseExerciseRela.FuncModuleId);
clsCheckSql.CheckFieldLen(objCaseExerciseRelaEN.CaseId, 8, conCaseExerciseRela.CaseId);
clsCheckSql.CheckFieldLen(objCaseExerciseRelaEN.CaseName, 100, conCaseExerciseRela.CaseName);
clsCheckSql.CheckFieldLen(objCaseExerciseRelaEN.OwnerId, 20, conCaseExerciseRela.OwnerId);
clsCheckSql.CheckFieldLen(objCaseExerciseRelaEN.CourseExamPaperId, 8, conCaseExerciseRela.CourseExamPaperId);
clsCheckSql.CheckFieldLen(objCaseExerciseRelaEN.CourseId, 8, conCaseExerciseRela.CourseId);
clsCheckSql.CheckFieldLen(objCaseExerciseRelaEN.ExamPaperTypeId, 2, conCaseExerciseRela.ExamPaperTypeId);
clsCheckSql.CheckFieldLen(objCaseExerciseRelaEN.UpdDate, 20, conCaseExerciseRela.UpdDate);
clsCheckSql.CheckFieldLen(objCaseExerciseRelaEN.UpdUserId, 20, conCaseExerciseRela.UpdUserId);
clsCheckSql.CheckFieldLen(objCaseExerciseRelaEN.Memo, 1000, conCaseExerciseRela.Memo);
//检查字段外键固定长度
clsCheckSql.CheckFieldForeignKey(objCaseExerciseRelaEN.CourseExamPaperId, 8, conCaseExerciseRela.CourseExamPaperId);
clsCheckSql.CheckFieldForeignKey(objCaseExerciseRelaEN.CourseId, 8, conCaseExerciseRela.CourseId);
 objCaseExerciseRelaEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsCaseExerciseRelaEN objCaseExerciseRelaEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objCaseExerciseRelaEN.FuncModuleId, 4, conCaseExerciseRela.FuncModuleId);
clsCheckSql.CheckFieldLen(objCaseExerciseRelaEN.CaseId, 8, conCaseExerciseRela.CaseId);
clsCheckSql.CheckFieldLen(objCaseExerciseRelaEN.CaseName, 100, conCaseExerciseRela.CaseName);
clsCheckSql.CheckFieldLen(objCaseExerciseRelaEN.OwnerId, 20, conCaseExerciseRela.OwnerId);
clsCheckSql.CheckFieldLen(objCaseExerciseRelaEN.CourseExamPaperId, 8, conCaseExerciseRela.CourseExamPaperId);
clsCheckSql.CheckFieldLen(objCaseExerciseRelaEN.CourseId, 8, conCaseExerciseRela.CourseId);
clsCheckSql.CheckFieldLen(objCaseExerciseRelaEN.ExamPaperTypeId, 2, conCaseExerciseRela.ExamPaperTypeId);
clsCheckSql.CheckFieldLen(objCaseExerciseRelaEN.UpdDate, 20, conCaseExerciseRela.UpdDate);
clsCheckSql.CheckFieldLen(objCaseExerciseRelaEN.UpdUserId, 20, conCaseExerciseRela.UpdUserId);
clsCheckSql.CheckFieldLen(objCaseExerciseRelaEN.Memo, 1000, conCaseExerciseRela.Memo);
//检查外键字段长度
clsCheckSql.CheckFieldForeignKey(objCaseExerciseRelaEN.CourseExamPaperId, 8, conCaseExerciseRela.CourseExamPaperId);
clsCheckSql.CheckFieldForeignKey(objCaseExerciseRelaEN.CourseId, 8, conCaseExerciseRela.CourseId);
 objCaseExerciseRelaEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsCaseExerciseRelaEN objCaseExerciseRelaEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objCaseExerciseRelaEN.FuncModuleId, 4, conCaseExerciseRela.FuncModuleId);
clsCheckSql.CheckFieldLen(objCaseExerciseRelaEN.CaseId, 8, conCaseExerciseRela.CaseId);
clsCheckSql.CheckFieldLen(objCaseExerciseRelaEN.CaseName, 100, conCaseExerciseRela.CaseName);
clsCheckSql.CheckFieldLen(objCaseExerciseRelaEN.OwnerId, 20, conCaseExerciseRela.OwnerId);
clsCheckSql.CheckFieldLen(objCaseExerciseRelaEN.CourseExamPaperId, 8, conCaseExerciseRela.CourseExamPaperId);
clsCheckSql.CheckFieldLen(objCaseExerciseRelaEN.CourseId, 8, conCaseExerciseRela.CourseId);
clsCheckSql.CheckFieldLen(objCaseExerciseRelaEN.ExamPaperTypeId, 2, conCaseExerciseRela.ExamPaperTypeId);
clsCheckSql.CheckFieldLen(objCaseExerciseRelaEN.UpdDate, 20, conCaseExerciseRela.UpdDate);
clsCheckSql.CheckFieldLen(objCaseExerciseRelaEN.UpdUserId, 20, conCaseExerciseRela.UpdUserId);
clsCheckSql.CheckFieldLen(objCaseExerciseRelaEN.Memo, 1000, conCaseExerciseRela.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objCaseExerciseRelaEN.FuncModuleId, conCaseExerciseRela.FuncModuleId);
clsCheckSql.CheckSqlInjection4Field(objCaseExerciseRelaEN.CaseId, conCaseExerciseRela.CaseId);
clsCheckSql.CheckSqlInjection4Field(objCaseExerciseRelaEN.CaseName, conCaseExerciseRela.CaseName);
clsCheckSql.CheckSqlInjection4Field(objCaseExerciseRelaEN.OwnerId, conCaseExerciseRela.OwnerId);
clsCheckSql.CheckSqlInjection4Field(objCaseExerciseRelaEN.CourseExamPaperId, conCaseExerciseRela.CourseExamPaperId);
clsCheckSql.CheckSqlInjection4Field(objCaseExerciseRelaEN.CourseId, conCaseExerciseRela.CourseId);
clsCheckSql.CheckSqlInjection4Field(objCaseExerciseRelaEN.ExamPaperTypeId, conCaseExerciseRela.ExamPaperTypeId);
clsCheckSql.CheckSqlInjection4Field(objCaseExerciseRelaEN.UpdDate, conCaseExerciseRela.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objCaseExerciseRelaEN.UpdUserId, conCaseExerciseRela.UpdUserId);
clsCheckSql.CheckSqlInjection4Field(objCaseExerciseRelaEN.Memo, conCaseExerciseRela.Memo);
//检查外键字段长度
clsCheckSql.CheckFieldForeignKey(objCaseExerciseRelaEN.CourseExamPaperId, 8, conCaseExerciseRela.CourseExamPaperId);
clsCheckSql.CheckFieldForeignKey(objCaseExerciseRelaEN.CourseId, 8, conCaseExerciseRela.CourseId);
 objCaseExerciseRelaEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--CaseExerciseRela(案例习题关系),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objCaseExerciseRelaEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clsCaseExerciseRelaEN objCaseExerciseRelaEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and CaseId = '{0}'", objCaseExerciseRelaEN.CaseId);
 if (objCaseExerciseRelaEN.CourseExamPaperId == null)
{
 sbCondition.AppendFormat(" and CourseExamPaperId is null");
}
else
{
 sbCondition.AppendFormat(" and CourseExamPaperId = '{0}'", objCaseExerciseRelaEN.CourseExamPaperId);
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
 objSQL = clsCaseExerciseRelaDA.GetSpecSQLObj();
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
 objSQL = clsCaseExerciseRelaDA.GetSpecSQLObj();
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
 objSQL = clsCaseExerciseRelaDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsCaseExerciseRelaEN._CurrTabName);
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
 objSQL = clsCaseExerciseRelaDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsCaseExerciseRelaEN._CurrTabName, strCondition);
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
 objSQL = clsCaseExerciseRelaDA.GetSpecSQLObj();
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
 objSQL = clsCaseExerciseRelaDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}