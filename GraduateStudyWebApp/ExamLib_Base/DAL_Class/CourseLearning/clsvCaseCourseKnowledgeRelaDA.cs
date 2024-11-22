
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvCaseCourseKnowledgeRelaDA
 表名:vCaseCourseKnowledgeRela(01120393)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:44:40
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
 /// v案例知识点关系(vCaseCourseKnowledgeRela)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvCaseCourseKnowledgeRelaDA : clsCommBase4DA
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
 return clsvCaseCourseKnowledgeRelaEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvCaseCourseKnowledgeRelaEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvCaseCourseKnowledgeRelaEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvCaseCourseKnowledgeRelaEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvCaseCourseKnowledgeRelaEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvCaseCourseKnowledgeRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCaseCourseKnowledgeRelaDA.GetSpecSQLObj();
strSQL = "Select * from vCaseCourseKnowledgeRela where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vCaseCourseKnowledgeRela(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvCaseCourseKnowledgeRelaDA: GetDataTable_vCaseCourseKnowledgeRela)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCaseCourseKnowledgeRelaDA.GetSpecSQLObj();
strSQL = "Select * from vCaseCourseKnowledgeRela where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvCaseCourseKnowledgeRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCaseCourseKnowledgeRelaDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvCaseCourseKnowledgeRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCaseCourseKnowledgeRelaDA.GetSpecSQLObj();
strSQL = "Select * from vCaseCourseKnowledgeRela where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvCaseCourseKnowledgeRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCaseCourseKnowledgeRelaDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvCaseCourseKnowledgeRelaDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCaseCourseKnowledgeRelaDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vCaseCourseKnowledgeRela where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vCaseCourseKnowledgeRela where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvCaseCourseKnowledgeRelaDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCaseCourseKnowledgeRelaDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vCaseCourseKnowledgeRela where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvCaseCourseKnowledgeRelaDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCaseCourseKnowledgeRelaDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vCaseCourseKnowledgeRela.* from vCaseCourseKnowledgeRela Left Join {1} on {2} where {3} and vCaseCourseKnowledgeRela.IdCaseCourseKnowledgeRela not in (Select top {5} vCaseCourseKnowledgeRela.IdCaseCourseKnowledgeRela from vCaseCourseKnowledgeRela Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vCaseCourseKnowledgeRela where {1} and IdCaseCourseKnowledgeRela not in (Select top {2} IdCaseCourseKnowledgeRela from vCaseCourseKnowledgeRela where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vCaseCourseKnowledgeRela where {1} and IdCaseCourseKnowledgeRela not in (Select top {3} IdCaseCourseKnowledgeRela from vCaseCourseKnowledgeRela where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvCaseCourseKnowledgeRelaDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCaseCourseKnowledgeRelaDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vCaseCourseKnowledgeRela.* from vCaseCourseKnowledgeRela Left Join {1} on {2} where {3} and vCaseCourseKnowledgeRela.IdCaseCourseKnowledgeRela not in (Select top {5} vCaseCourseKnowledgeRela.IdCaseCourseKnowledgeRela from vCaseCourseKnowledgeRela Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vCaseCourseKnowledgeRela where {1} and IdCaseCourseKnowledgeRela not in (Select top {2} IdCaseCourseKnowledgeRela from vCaseCourseKnowledgeRela where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vCaseCourseKnowledgeRela where {1} and IdCaseCourseKnowledgeRela not in (Select top {3} IdCaseCourseKnowledgeRela from vCaseCourseKnowledgeRela where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvCaseCourseKnowledgeRelaEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvCaseCourseKnowledgeRelaDA:GetObjLst)", objException.Message));
}
List<clsvCaseCourseKnowledgeRelaEN> arrObjLst = new List<clsvCaseCourseKnowledgeRelaEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCaseCourseKnowledgeRelaDA.GetSpecSQLObj();
strSQL = "Select * from vCaseCourseKnowledgeRela where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCaseCourseKnowledgeRelaEN objvCaseCourseKnowledgeRelaEN = new clsvCaseCourseKnowledgeRelaEN();
try
{
objvCaseCourseKnowledgeRelaEN.IdCaseCourseKnowledgeRela = TransNullToInt(objRow[convCaseCourseKnowledgeRela.IdCaseCourseKnowledgeRela].ToString().Trim()); //案例知识点关系流水号
objvCaseCourseKnowledgeRelaEN.FuncModuleId = objRow[convCaseCourseKnowledgeRela.FuncModuleId].ToString().Trim(); //功能模块Id
objvCaseCourseKnowledgeRelaEN.FuncModuleName = objRow[convCaseCourseKnowledgeRela.FuncModuleName].ToString().Trim(); //功能模块名称
objvCaseCourseKnowledgeRelaEN.CaseId = objRow[convCaseCourseKnowledgeRela.CaseId] == DBNull.Value ? null : objRow[convCaseCourseKnowledgeRela.CaseId].ToString().Trim(); //案例Id
objvCaseCourseKnowledgeRelaEN.CaseName = objRow[convCaseCourseKnowledgeRela.CaseName] == DBNull.Value ? null : objRow[convCaseCourseKnowledgeRela.CaseName].ToString().Trim(); //案例名称
objvCaseCourseKnowledgeRelaEN.OwnerId = objRow[convCaseCourseKnowledgeRela.OwnerId].ToString().Trim(); //拥有者Id
objvCaseCourseKnowledgeRelaEN.OwnerName = objRow[convCaseCourseKnowledgeRela.OwnerName] == DBNull.Value ? null : objRow[convCaseCourseKnowledgeRela.OwnerName].ToString().Trim(); //拥有者姓名
objvCaseCourseKnowledgeRelaEN.CourseKnowledgeId = objRow[convCaseCourseKnowledgeRela.CourseKnowledgeId] == DBNull.Value ? null : objRow[convCaseCourseKnowledgeRela.CourseKnowledgeId].ToString().Trim(); //知识点Id
objvCaseCourseKnowledgeRelaEN.KnowledgeName = objRow[convCaseCourseKnowledgeRela.KnowledgeName] == DBNull.Value ? null : objRow[convCaseCourseKnowledgeRela.KnowledgeName].ToString().Trim(); //知识点名称
objvCaseCourseKnowledgeRelaEN.KnowledgeTitle = objRow[convCaseCourseKnowledgeRela.KnowledgeTitle] == DBNull.Value ? null : objRow[convCaseCourseKnowledgeRela.KnowledgeTitle].ToString().Trim(); //知识点标题
objvCaseCourseKnowledgeRelaEN.KnowledgeContent = objRow[convCaseCourseKnowledgeRela.KnowledgeContent] == DBNull.Value ? null : objRow[convCaseCourseKnowledgeRela.KnowledgeContent].ToString().Trim(); //知识点内容
objvCaseCourseKnowledgeRelaEN.RelationsDegree = TransNullToInt(objRow[convCaseCourseKnowledgeRela.RelationsDegree].ToString().Trim()); //关系度
objvCaseCourseKnowledgeRelaEN.CourseId = objRow[convCaseCourseKnowledgeRela.CourseId] == DBNull.Value ? null : objRow[convCaseCourseKnowledgeRela.CourseId].ToString().Trim(); //课程Id
objvCaseCourseKnowledgeRelaEN.CourseName = objRow[convCaseCourseKnowledgeRela.CourseName] == DBNull.Value ? null : objRow[convCaseCourseKnowledgeRela.CourseName].ToString().Trim(); //课程名称
objvCaseCourseKnowledgeRelaEN.CourseChapterId = objRow[convCaseCourseKnowledgeRela.CourseChapterId] == DBNull.Value ? null : objRow[convCaseCourseKnowledgeRela.CourseChapterId].ToString().Trim(); //课程章节ID
objvCaseCourseKnowledgeRelaEN.IdCaseCourseKnowledgeRelaType = objRow[convCaseCourseKnowledgeRela.IdCaseCourseKnowledgeRelaType].ToString().Trim(); //案例知识点关系类型流水号
objvCaseCourseKnowledgeRelaEN.CaseCourseKnowledgeRelaTypeName = objRow[convCaseCourseKnowledgeRela.CaseCourseKnowledgeRelaTypeName].ToString().Trim(); //案例知识点关系类型名称
objvCaseCourseKnowledgeRelaEN.BrowseCount = objRow[convCaseCourseKnowledgeRela.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCaseCourseKnowledgeRela.BrowseCount].ToString().Trim()); //浏览次数
objvCaseCourseKnowledgeRelaEN.OrderNum = objRow[convCaseCourseKnowledgeRela.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCaseCourseKnowledgeRela.OrderNum].ToString().Trim()); //序号
objvCaseCourseKnowledgeRelaEN.UpdDate = objRow[convCaseCourseKnowledgeRela.UpdDate] == DBNull.Value ? null : objRow[convCaseCourseKnowledgeRela.UpdDate].ToString().Trim(); //修改日期
objvCaseCourseKnowledgeRelaEN.UpdUserId = objRow[convCaseCourseKnowledgeRela.UpdUserId] == DBNull.Value ? null : objRow[convCaseCourseKnowledgeRela.UpdUserId].ToString().Trim(); //修改用户Id
objvCaseCourseKnowledgeRelaEN.Memo = objRow[convCaseCourseKnowledgeRela.Memo] == DBNull.Value ? null : objRow[convCaseCourseKnowledgeRela.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvCaseCourseKnowledgeRelaDA: GetObjLst)", objException.Message));
}
objvCaseCourseKnowledgeRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvCaseCourseKnowledgeRelaEN);
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
public List<clsvCaseCourseKnowledgeRelaEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvCaseCourseKnowledgeRelaDA:GetObjLstByTabName)", objException.Message));
}
List<clsvCaseCourseKnowledgeRelaEN> arrObjLst = new List<clsvCaseCourseKnowledgeRelaEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCaseCourseKnowledgeRelaDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCaseCourseKnowledgeRelaEN objvCaseCourseKnowledgeRelaEN = new clsvCaseCourseKnowledgeRelaEN();
try
{
objvCaseCourseKnowledgeRelaEN.IdCaseCourseKnowledgeRela = TransNullToInt(objRow[convCaseCourseKnowledgeRela.IdCaseCourseKnowledgeRela].ToString().Trim()); //案例知识点关系流水号
objvCaseCourseKnowledgeRelaEN.FuncModuleId = objRow[convCaseCourseKnowledgeRela.FuncModuleId].ToString().Trim(); //功能模块Id
objvCaseCourseKnowledgeRelaEN.FuncModuleName = objRow[convCaseCourseKnowledgeRela.FuncModuleName].ToString().Trim(); //功能模块名称
objvCaseCourseKnowledgeRelaEN.CaseId = objRow[convCaseCourseKnowledgeRela.CaseId] == DBNull.Value ? null : objRow[convCaseCourseKnowledgeRela.CaseId].ToString().Trim(); //案例Id
objvCaseCourseKnowledgeRelaEN.CaseName = objRow[convCaseCourseKnowledgeRela.CaseName] == DBNull.Value ? null : objRow[convCaseCourseKnowledgeRela.CaseName].ToString().Trim(); //案例名称
objvCaseCourseKnowledgeRelaEN.OwnerId = objRow[convCaseCourseKnowledgeRela.OwnerId].ToString().Trim(); //拥有者Id
objvCaseCourseKnowledgeRelaEN.OwnerName = objRow[convCaseCourseKnowledgeRela.OwnerName] == DBNull.Value ? null : objRow[convCaseCourseKnowledgeRela.OwnerName].ToString().Trim(); //拥有者姓名
objvCaseCourseKnowledgeRelaEN.CourseKnowledgeId = objRow[convCaseCourseKnowledgeRela.CourseKnowledgeId] == DBNull.Value ? null : objRow[convCaseCourseKnowledgeRela.CourseKnowledgeId].ToString().Trim(); //知识点Id
objvCaseCourseKnowledgeRelaEN.KnowledgeName = objRow[convCaseCourseKnowledgeRela.KnowledgeName] == DBNull.Value ? null : objRow[convCaseCourseKnowledgeRela.KnowledgeName].ToString().Trim(); //知识点名称
objvCaseCourseKnowledgeRelaEN.KnowledgeTitle = objRow[convCaseCourseKnowledgeRela.KnowledgeTitle] == DBNull.Value ? null : objRow[convCaseCourseKnowledgeRela.KnowledgeTitle].ToString().Trim(); //知识点标题
objvCaseCourseKnowledgeRelaEN.KnowledgeContent = objRow[convCaseCourseKnowledgeRela.KnowledgeContent] == DBNull.Value ? null : objRow[convCaseCourseKnowledgeRela.KnowledgeContent].ToString().Trim(); //知识点内容
objvCaseCourseKnowledgeRelaEN.RelationsDegree = TransNullToInt(objRow[convCaseCourseKnowledgeRela.RelationsDegree].ToString().Trim()); //关系度
objvCaseCourseKnowledgeRelaEN.CourseId = objRow[convCaseCourseKnowledgeRela.CourseId] == DBNull.Value ? null : objRow[convCaseCourseKnowledgeRela.CourseId].ToString().Trim(); //课程Id
objvCaseCourseKnowledgeRelaEN.CourseName = objRow[convCaseCourseKnowledgeRela.CourseName] == DBNull.Value ? null : objRow[convCaseCourseKnowledgeRela.CourseName].ToString().Trim(); //课程名称
objvCaseCourseKnowledgeRelaEN.CourseChapterId = objRow[convCaseCourseKnowledgeRela.CourseChapterId] == DBNull.Value ? null : objRow[convCaseCourseKnowledgeRela.CourseChapterId].ToString().Trim(); //课程章节ID
objvCaseCourseKnowledgeRelaEN.IdCaseCourseKnowledgeRelaType = objRow[convCaseCourseKnowledgeRela.IdCaseCourseKnowledgeRelaType].ToString().Trim(); //案例知识点关系类型流水号
objvCaseCourseKnowledgeRelaEN.CaseCourseKnowledgeRelaTypeName = objRow[convCaseCourseKnowledgeRela.CaseCourseKnowledgeRelaTypeName].ToString().Trim(); //案例知识点关系类型名称
objvCaseCourseKnowledgeRelaEN.BrowseCount = objRow[convCaseCourseKnowledgeRela.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCaseCourseKnowledgeRela.BrowseCount].ToString().Trim()); //浏览次数
objvCaseCourseKnowledgeRelaEN.OrderNum = objRow[convCaseCourseKnowledgeRela.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCaseCourseKnowledgeRela.OrderNum].ToString().Trim()); //序号
objvCaseCourseKnowledgeRelaEN.UpdDate = objRow[convCaseCourseKnowledgeRela.UpdDate] == DBNull.Value ? null : objRow[convCaseCourseKnowledgeRela.UpdDate].ToString().Trim(); //修改日期
objvCaseCourseKnowledgeRelaEN.UpdUserId = objRow[convCaseCourseKnowledgeRela.UpdUserId] == DBNull.Value ? null : objRow[convCaseCourseKnowledgeRela.UpdUserId].ToString().Trim(); //修改用户Id
objvCaseCourseKnowledgeRelaEN.Memo = objRow[convCaseCourseKnowledgeRela.Memo] == DBNull.Value ? null : objRow[convCaseCourseKnowledgeRela.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvCaseCourseKnowledgeRelaDA: GetObjLst)", objException.Message));
}
objvCaseCourseKnowledgeRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvCaseCourseKnowledgeRelaEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvCaseCourseKnowledgeRelaEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvCaseCourseKnowledgeRela(ref clsvCaseCourseKnowledgeRelaEN objvCaseCourseKnowledgeRelaEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCaseCourseKnowledgeRelaDA.GetSpecSQLObj();
strSQL = "Select * from vCaseCourseKnowledgeRela where IdCaseCourseKnowledgeRela = " + ""+ objvCaseCourseKnowledgeRelaEN.IdCaseCourseKnowledgeRela+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvCaseCourseKnowledgeRelaEN.IdCaseCourseKnowledgeRela = TransNullToInt(objDT.Rows[0][convCaseCourseKnowledgeRela.IdCaseCourseKnowledgeRela].ToString().Trim()); //案例知识点关系流水号(字段类型:bigint,字段长度:8,是否可空:False)
 objvCaseCourseKnowledgeRelaEN.FuncModuleId = objDT.Rows[0][convCaseCourseKnowledgeRela.FuncModuleId].ToString().Trim(); //功能模块Id(字段类型:char,字段长度:4,是否可空:True)
 objvCaseCourseKnowledgeRelaEN.FuncModuleName = objDT.Rows[0][convCaseCourseKnowledgeRela.FuncModuleName].ToString().Trim(); //功能模块名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvCaseCourseKnowledgeRelaEN.CaseId = objDT.Rows[0][convCaseCourseKnowledgeRela.CaseId].ToString().Trim(); //案例Id(字段类型:char,字段长度:8,是否可空:True)
 objvCaseCourseKnowledgeRelaEN.CaseName = objDT.Rows[0][convCaseCourseKnowledgeRela.CaseName].ToString().Trim(); //案例名称(字段类型:varchar,字段长度:100,是否可空:True)
 objvCaseCourseKnowledgeRelaEN.OwnerId = objDT.Rows[0][convCaseCourseKnowledgeRela.OwnerId].ToString().Trim(); //拥有者Id(字段类型:varchar,字段长度:20,是否可空:False)
 objvCaseCourseKnowledgeRelaEN.OwnerName = objDT.Rows[0][convCaseCourseKnowledgeRela.OwnerName].ToString().Trim(); //拥有者姓名(字段类型:varchar,字段长度:30,是否可空:True)
 objvCaseCourseKnowledgeRelaEN.CourseKnowledgeId = objDT.Rows[0][convCaseCourseKnowledgeRela.CourseKnowledgeId].ToString().Trim(); //知识点Id(字段类型:char,字段长度:8,是否可空:False)
 objvCaseCourseKnowledgeRelaEN.KnowledgeName = objDT.Rows[0][convCaseCourseKnowledgeRela.KnowledgeName].ToString().Trim(); //知识点名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvCaseCourseKnowledgeRelaEN.KnowledgeTitle = objDT.Rows[0][convCaseCourseKnowledgeRela.KnowledgeTitle].ToString().Trim(); //知识点标题(字段类型:varchar,字段长度:100,是否可空:True)
 objvCaseCourseKnowledgeRelaEN.KnowledgeContent = objDT.Rows[0][convCaseCourseKnowledgeRela.KnowledgeContent].ToString().Trim(); //知识点内容(字段类型:text,字段长度:2147483647,是否可空:True)
 objvCaseCourseKnowledgeRelaEN.RelationsDegree = TransNullToInt(objDT.Rows[0][convCaseCourseKnowledgeRela.RelationsDegree].ToString().Trim()); //关系度(字段类型:int,字段长度:4,是否可空:False)
 objvCaseCourseKnowledgeRelaEN.CourseId = objDT.Rows[0][convCaseCourseKnowledgeRela.CourseId].ToString().Trim(); //课程Id(字段类型:char,字段长度:8,是否可空:True)
 objvCaseCourseKnowledgeRelaEN.CourseName = objDT.Rows[0][convCaseCourseKnowledgeRela.CourseName].ToString().Trim(); //课程名称(字段类型:varchar,字段长度:100,是否可空:True)
 objvCaseCourseKnowledgeRelaEN.CourseChapterId = objDT.Rows[0][convCaseCourseKnowledgeRela.CourseChapterId].ToString().Trim(); //课程章节ID(字段类型:char,字段长度:8,是否可空:False)
 objvCaseCourseKnowledgeRelaEN.IdCaseCourseKnowledgeRelaType = objDT.Rows[0][convCaseCourseKnowledgeRela.IdCaseCourseKnowledgeRelaType].ToString().Trim(); //案例知识点关系类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvCaseCourseKnowledgeRelaEN.CaseCourseKnowledgeRelaTypeName = objDT.Rows[0][convCaseCourseKnowledgeRela.CaseCourseKnowledgeRelaTypeName].ToString().Trim(); //案例知识点关系类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvCaseCourseKnowledgeRelaEN.BrowseCount = TransNullToInt(objDT.Rows[0][convCaseCourseKnowledgeRela.BrowseCount].ToString().Trim()); //浏览次数(字段类型:int,字段长度:4,是否可空:True)
 objvCaseCourseKnowledgeRelaEN.OrderNum = TransNullToInt(objDT.Rows[0][convCaseCourseKnowledgeRela.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:True)
 objvCaseCourseKnowledgeRelaEN.UpdDate = objDT.Rows[0][convCaseCourseKnowledgeRela.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvCaseCourseKnowledgeRelaEN.UpdUserId = objDT.Rows[0][convCaseCourseKnowledgeRela.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:True)
 objvCaseCourseKnowledgeRelaEN.Memo = objDT.Rows[0][convCaseCourseKnowledgeRela.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvCaseCourseKnowledgeRelaDA: GetvCaseCourseKnowledgeRela)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngIdCaseCourseKnowledgeRela">表关键字</param>
 /// <returns>表对象</returns>
public clsvCaseCourseKnowledgeRelaEN GetObjByIdCaseCourseKnowledgeRela(long lngIdCaseCourseKnowledgeRela)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCaseCourseKnowledgeRelaDA.GetSpecSQLObj();
strSQL = "Select * from vCaseCourseKnowledgeRela where IdCaseCourseKnowledgeRela = " + ""+ lngIdCaseCourseKnowledgeRela+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvCaseCourseKnowledgeRelaEN objvCaseCourseKnowledgeRelaEN = new clsvCaseCourseKnowledgeRelaEN();
try
{
 objvCaseCourseKnowledgeRelaEN.IdCaseCourseKnowledgeRela = Int32.Parse(objRow[convCaseCourseKnowledgeRela.IdCaseCourseKnowledgeRela].ToString().Trim()); //案例知识点关系流水号(字段类型:bigint,字段长度:8,是否可空:False)
 objvCaseCourseKnowledgeRelaEN.FuncModuleId = objRow[convCaseCourseKnowledgeRela.FuncModuleId].ToString().Trim(); //功能模块Id(字段类型:char,字段长度:4,是否可空:True)
 objvCaseCourseKnowledgeRelaEN.FuncModuleName = objRow[convCaseCourseKnowledgeRela.FuncModuleName].ToString().Trim(); //功能模块名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvCaseCourseKnowledgeRelaEN.CaseId = objRow[convCaseCourseKnowledgeRela.CaseId] == DBNull.Value ? null : objRow[convCaseCourseKnowledgeRela.CaseId].ToString().Trim(); //案例Id(字段类型:char,字段长度:8,是否可空:True)
 objvCaseCourseKnowledgeRelaEN.CaseName = objRow[convCaseCourseKnowledgeRela.CaseName] == DBNull.Value ? null : objRow[convCaseCourseKnowledgeRela.CaseName].ToString().Trim(); //案例名称(字段类型:varchar,字段长度:100,是否可空:True)
 objvCaseCourseKnowledgeRelaEN.OwnerId = objRow[convCaseCourseKnowledgeRela.OwnerId].ToString().Trim(); //拥有者Id(字段类型:varchar,字段长度:20,是否可空:False)
 objvCaseCourseKnowledgeRelaEN.OwnerName = objRow[convCaseCourseKnowledgeRela.OwnerName] == DBNull.Value ? null : objRow[convCaseCourseKnowledgeRela.OwnerName].ToString().Trim(); //拥有者姓名(字段类型:varchar,字段长度:30,是否可空:True)
 objvCaseCourseKnowledgeRelaEN.CourseKnowledgeId = objRow[convCaseCourseKnowledgeRela.CourseKnowledgeId] == DBNull.Value ? null : objRow[convCaseCourseKnowledgeRela.CourseKnowledgeId].ToString().Trim(); //知识点Id(字段类型:char,字段长度:8,是否可空:False)
 objvCaseCourseKnowledgeRelaEN.KnowledgeName = objRow[convCaseCourseKnowledgeRela.KnowledgeName] == DBNull.Value ? null : objRow[convCaseCourseKnowledgeRela.KnowledgeName].ToString().Trim(); //知识点名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvCaseCourseKnowledgeRelaEN.KnowledgeTitle = objRow[convCaseCourseKnowledgeRela.KnowledgeTitle] == DBNull.Value ? null : objRow[convCaseCourseKnowledgeRela.KnowledgeTitle].ToString().Trim(); //知识点标题(字段类型:varchar,字段长度:100,是否可空:True)
 objvCaseCourseKnowledgeRelaEN.KnowledgeContent = objRow[convCaseCourseKnowledgeRela.KnowledgeContent] == DBNull.Value ? null : objRow[convCaseCourseKnowledgeRela.KnowledgeContent].ToString().Trim(); //知识点内容(字段类型:text,字段长度:2147483647,是否可空:True)
 objvCaseCourseKnowledgeRelaEN.RelationsDegree = Int32.Parse(objRow[convCaseCourseKnowledgeRela.RelationsDegree].ToString().Trim()); //关系度(字段类型:int,字段长度:4,是否可空:False)
 objvCaseCourseKnowledgeRelaEN.CourseId = objRow[convCaseCourseKnowledgeRela.CourseId] == DBNull.Value ? null : objRow[convCaseCourseKnowledgeRela.CourseId].ToString().Trim(); //课程Id(字段类型:char,字段长度:8,是否可空:True)
 objvCaseCourseKnowledgeRelaEN.CourseName = objRow[convCaseCourseKnowledgeRela.CourseName] == DBNull.Value ? null : objRow[convCaseCourseKnowledgeRela.CourseName].ToString().Trim(); //课程名称(字段类型:varchar,字段长度:100,是否可空:True)
 objvCaseCourseKnowledgeRelaEN.CourseChapterId = objRow[convCaseCourseKnowledgeRela.CourseChapterId] == DBNull.Value ? null : objRow[convCaseCourseKnowledgeRela.CourseChapterId].ToString().Trim(); //课程章节ID(字段类型:char,字段长度:8,是否可空:False)
 objvCaseCourseKnowledgeRelaEN.IdCaseCourseKnowledgeRelaType = objRow[convCaseCourseKnowledgeRela.IdCaseCourseKnowledgeRelaType].ToString().Trim(); //案例知识点关系类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvCaseCourseKnowledgeRelaEN.CaseCourseKnowledgeRelaTypeName = objRow[convCaseCourseKnowledgeRela.CaseCourseKnowledgeRelaTypeName].ToString().Trim(); //案例知识点关系类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvCaseCourseKnowledgeRelaEN.BrowseCount = objRow[convCaseCourseKnowledgeRela.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCaseCourseKnowledgeRela.BrowseCount].ToString().Trim()); //浏览次数(字段类型:int,字段长度:4,是否可空:True)
 objvCaseCourseKnowledgeRelaEN.OrderNum = objRow[convCaseCourseKnowledgeRela.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCaseCourseKnowledgeRela.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:True)
 objvCaseCourseKnowledgeRelaEN.UpdDate = objRow[convCaseCourseKnowledgeRela.UpdDate] == DBNull.Value ? null : objRow[convCaseCourseKnowledgeRela.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvCaseCourseKnowledgeRelaEN.UpdUserId = objRow[convCaseCourseKnowledgeRela.UpdUserId] == DBNull.Value ? null : objRow[convCaseCourseKnowledgeRela.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:True)
 objvCaseCourseKnowledgeRelaEN.Memo = objRow[convCaseCourseKnowledgeRela.Memo] == DBNull.Value ? null : objRow[convCaseCourseKnowledgeRela.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvCaseCourseKnowledgeRelaDA: GetObjByIdCaseCourseKnowledgeRela)", objException.Message));
}
return objvCaseCourseKnowledgeRelaEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvCaseCourseKnowledgeRelaEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvCaseCourseKnowledgeRelaDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCaseCourseKnowledgeRelaDA.GetSpecSQLObj();
strSQL = "Select * from vCaseCourseKnowledgeRela where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvCaseCourseKnowledgeRelaEN objvCaseCourseKnowledgeRelaEN = new clsvCaseCourseKnowledgeRelaEN()
{
IdCaseCourseKnowledgeRela = TransNullToInt(objRow[convCaseCourseKnowledgeRela.IdCaseCourseKnowledgeRela].ToString().Trim()), //案例知识点关系流水号
FuncModuleId = objRow[convCaseCourseKnowledgeRela.FuncModuleId].ToString().Trim(), //功能模块Id
FuncModuleName = objRow[convCaseCourseKnowledgeRela.FuncModuleName].ToString().Trim(), //功能模块名称
CaseId = objRow[convCaseCourseKnowledgeRela.CaseId] == DBNull.Value ? null : objRow[convCaseCourseKnowledgeRela.CaseId].ToString().Trim(), //案例Id
CaseName = objRow[convCaseCourseKnowledgeRela.CaseName] == DBNull.Value ? null : objRow[convCaseCourseKnowledgeRela.CaseName].ToString().Trim(), //案例名称
OwnerId = objRow[convCaseCourseKnowledgeRela.OwnerId].ToString().Trim(), //拥有者Id
OwnerName = objRow[convCaseCourseKnowledgeRela.OwnerName] == DBNull.Value ? null : objRow[convCaseCourseKnowledgeRela.OwnerName].ToString().Trim(), //拥有者姓名
CourseKnowledgeId = objRow[convCaseCourseKnowledgeRela.CourseKnowledgeId] == DBNull.Value ? null : objRow[convCaseCourseKnowledgeRela.CourseKnowledgeId].ToString().Trim(), //知识点Id
KnowledgeName = objRow[convCaseCourseKnowledgeRela.KnowledgeName] == DBNull.Value ? null : objRow[convCaseCourseKnowledgeRela.KnowledgeName].ToString().Trim(), //知识点名称
KnowledgeTitle = objRow[convCaseCourseKnowledgeRela.KnowledgeTitle] == DBNull.Value ? null : objRow[convCaseCourseKnowledgeRela.KnowledgeTitle].ToString().Trim(), //知识点标题
KnowledgeContent = objRow[convCaseCourseKnowledgeRela.KnowledgeContent] == DBNull.Value ? null : objRow[convCaseCourseKnowledgeRela.KnowledgeContent].ToString().Trim(), //知识点内容
RelationsDegree = TransNullToInt(objRow[convCaseCourseKnowledgeRela.RelationsDegree].ToString().Trim()), //关系度
CourseId = objRow[convCaseCourseKnowledgeRela.CourseId] == DBNull.Value ? null : objRow[convCaseCourseKnowledgeRela.CourseId].ToString().Trim(), //课程Id
CourseName = objRow[convCaseCourseKnowledgeRela.CourseName] == DBNull.Value ? null : objRow[convCaseCourseKnowledgeRela.CourseName].ToString().Trim(), //课程名称
CourseChapterId = objRow[convCaseCourseKnowledgeRela.CourseChapterId] == DBNull.Value ? null : objRow[convCaseCourseKnowledgeRela.CourseChapterId].ToString().Trim(), //课程章节ID
IdCaseCourseKnowledgeRelaType = objRow[convCaseCourseKnowledgeRela.IdCaseCourseKnowledgeRelaType].ToString().Trim(), //案例知识点关系类型流水号
CaseCourseKnowledgeRelaTypeName = objRow[convCaseCourseKnowledgeRela.CaseCourseKnowledgeRelaTypeName].ToString().Trim(), //案例知识点关系类型名称
BrowseCount = objRow[convCaseCourseKnowledgeRela.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCaseCourseKnowledgeRela.BrowseCount].ToString().Trim()), //浏览次数
OrderNum = objRow[convCaseCourseKnowledgeRela.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCaseCourseKnowledgeRela.OrderNum].ToString().Trim()), //序号
UpdDate = objRow[convCaseCourseKnowledgeRela.UpdDate] == DBNull.Value ? null : objRow[convCaseCourseKnowledgeRela.UpdDate].ToString().Trim(), //修改日期
UpdUserId = objRow[convCaseCourseKnowledgeRela.UpdUserId] == DBNull.Value ? null : objRow[convCaseCourseKnowledgeRela.UpdUserId].ToString().Trim(), //修改用户Id
Memo = objRow[convCaseCourseKnowledgeRela.Memo] == DBNull.Value ? null : objRow[convCaseCourseKnowledgeRela.Memo].ToString().Trim() //备注
};
objvCaseCourseKnowledgeRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvCaseCourseKnowledgeRelaEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvCaseCourseKnowledgeRelaDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvCaseCourseKnowledgeRelaEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvCaseCourseKnowledgeRelaEN objvCaseCourseKnowledgeRelaEN = new clsvCaseCourseKnowledgeRelaEN();
try
{
objvCaseCourseKnowledgeRelaEN.IdCaseCourseKnowledgeRela = TransNullToInt(objRow[convCaseCourseKnowledgeRela.IdCaseCourseKnowledgeRela].ToString().Trim()); //案例知识点关系流水号
objvCaseCourseKnowledgeRelaEN.FuncModuleId = objRow[convCaseCourseKnowledgeRela.FuncModuleId].ToString().Trim(); //功能模块Id
objvCaseCourseKnowledgeRelaEN.FuncModuleName = objRow[convCaseCourseKnowledgeRela.FuncModuleName].ToString().Trim(); //功能模块名称
objvCaseCourseKnowledgeRelaEN.CaseId = objRow[convCaseCourseKnowledgeRela.CaseId] == DBNull.Value ? null : objRow[convCaseCourseKnowledgeRela.CaseId].ToString().Trim(); //案例Id
objvCaseCourseKnowledgeRelaEN.CaseName = objRow[convCaseCourseKnowledgeRela.CaseName] == DBNull.Value ? null : objRow[convCaseCourseKnowledgeRela.CaseName].ToString().Trim(); //案例名称
objvCaseCourseKnowledgeRelaEN.OwnerId = objRow[convCaseCourseKnowledgeRela.OwnerId].ToString().Trim(); //拥有者Id
objvCaseCourseKnowledgeRelaEN.OwnerName = objRow[convCaseCourseKnowledgeRela.OwnerName] == DBNull.Value ? null : objRow[convCaseCourseKnowledgeRela.OwnerName].ToString().Trim(); //拥有者姓名
objvCaseCourseKnowledgeRelaEN.CourseKnowledgeId = objRow[convCaseCourseKnowledgeRela.CourseKnowledgeId] == DBNull.Value ? null : objRow[convCaseCourseKnowledgeRela.CourseKnowledgeId].ToString().Trim(); //知识点Id
objvCaseCourseKnowledgeRelaEN.KnowledgeName = objRow[convCaseCourseKnowledgeRela.KnowledgeName] == DBNull.Value ? null : objRow[convCaseCourseKnowledgeRela.KnowledgeName].ToString().Trim(); //知识点名称
objvCaseCourseKnowledgeRelaEN.KnowledgeTitle = objRow[convCaseCourseKnowledgeRela.KnowledgeTitle] == DBNull.Value ? null : objRow[convCaseCourseKnowledgeRela.KnowledgeTitle].ToString().Trim(); //知识点标题
objvCaseCourseKnowledgeRelaEN.KnowledgeContent = objRow[convCaseCourseKnowledgeRela.KnowledgeContent] == DBNull.Value ? null : objRow[convCaseCourseKnowledgeRela.KnowledgeContent].ToString().Trim(); //知识点内容
objvCaseCourseKnowledgeRelaEN.RelationsDegree = TransNullToInt(objRow[convCaseCourseKnowledgeRela.RelationsDegree].ToString().Trim()); //关系度
objvCaseCourseKnowledgeRelaEN.CourseId = objRow[convCaseCourseKnowledgeRela.CourseId] == DBNull.Value ? null : objRow[convCaseCourseKnowledgeRela.CourseId].ToString().Trim(); //课程Id
objvCaseCourseKnowledgeRelaEN.CourseName = objRow[convCaseCourseKnowledgeRela.CourseName] == DBNull.Value ? null : objRow[convCaseCourseKnowledgeRela.CourseName].ToString().Trim(); //课程名称
objvCaseCourseKnowledgeRelaEN.CourseChapterId = objRow[convCaseCourseKnowledgeRela.CourseChapterId] == DBNull.Value ? null : objRow[convCaseCourseKnowledgeRela.CourseChapterId].ToString().Trim(); //课程章节ID
objvCaseCourseKnowledgeRelaEN.IdCaseCourseKnowledgeRelaType = objRow[convCaseCourseKnowledgeRela.IdCaseCourseKnowledgeRelaType].ToString().Trim(); //案例知识点关系类型流水号
objvCaseCourseKnowledgeRelaEN.CaseCourseKnowledgeRelaTypeName = objRow[convCaseCourseKnowledgeRela.CaseCourseKnowledgeRelaTypeName].ToString().Trim(); //案例知识点关系类型名称
objvCaseCourseKnowledgeRelaEN.BrowseCount = objRow[convCaseCourseKnowledgeRela.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCaseCourseKnowledgeRela.BrowseCount].ToString().Trim()); //浏览次数
objvCaseCourseKnowledgeRelaEN.OrderNum = objRow[convCaseCourseKnowledgeRela.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCaseCourseKnowledgeRela.OrderNum].ToString().Trim()); //序号
objvCaseCourseKnowledgeRelaEN.UpdDate = objRow[convCaseCourseKnowledgeRela.UpdDate] == DBNull.Value ? null : objRow[convCaseCourseKnowledgeRela.UpdDate].ToString().Trim(); //修改日期
objvCaseCourseKnowledgeRelaEN.UpdUserId = objRow[convCaseCourseKnowledgeRela.UpdUserId] == DBNull.Value ? null : objRow[convCaseCourseKnowledgeRela.UpdUserId].ToString().Trim(); //修改用户Id
objvCaseCourseKnowledgeRelaEN.Memo = objRow[convCaseCourseKnowledgeRela.Memo] == DBNull.Value ? null : objRow[convCaseCourseKnowledgeRela.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvCaseCourseKnowledgeRelaDA: GetObjByDataRowvCaseCourseKnowledgeRela)", objException.Message));
}
objvCaseCourseKnowledgeRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvCaseCourseKnowledgeRelaEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvCaseCourseKnowledgeRelaEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvCaseCourseKnowledgeRelaEN objvCaseCourseKnowledgeRelaEN = new clsvCaseCourseKnowledgeRelaEN();
try
{
objvCaseCourseKnowledgeRelaEN.IdCaseCourseKnowledgeRela = TransNullToInt(objRow[convCaseCourseKnowledgeRela.IdCaseCourseKnowledgeRela].ToString().Trim()); //案例知识点关系流水号
objvCaseCourseKnowledgeRelaEN.FuncModuleId = objRow[convCaseCourseKnowledgeRela.FuncModuleId].ToString().Trim(); //功能模块Id
objvCaseCourseKnowledgeRelaEN.FuncModuleName = objRow[convCaseCourseKnowledgeRela.FuncModuleName].ToString().Trim(); //功能模块名称
objvCaseCourseKnowledgeRelaEN.CaseId = objRow[convCaseCourseKnowledgeRela.CaseId] == DBNull.Value ? null : objRow[convCaseCourseKnowledgeRela.CaseId].ToString().Trim(); //案例Id
objvCaseCourseKnowledgeRelaEN.CaseName = objRow[convCaseCourseKnowledgeRela.CaseName] == DBNull.Value ? null : objRow[convCaseCourseKnowledgeRela.CaseName].ToString().Trim(); //案例名称
objvCaseCourseKnowledgeRelaEN.OwnerId = objRow[convCaseCourseKnowledgeRela.OwnerId].ToString().Trim(); //拥有者Id
objvCaseCourseKnowledgeRelaEN.OwnerName = objRow[convCaseCourseKnowledgeRela.OwnerName] == DBNull.Value ? null : objRow[convCaseCourseKnowledgeRela.OwnerName].ToString().Trim(); //拥有者姓名
objvCaseCourseKnowledgeRelaEN.CourseKnowledgeId = objRow[convCaseCourseKnowledgeRela.CourseKnowledgeId] == DBNull.Value ? null : objRow[convCaseCourseKnowledgeRela.CourseKnowledgeId].ToString().Trim(); //知识点Id
objvCaseCourseKnowledgeRelaEN.KnowledgeName = objRow[convCaseCourseKnowledgeRela.KnowledgeName] == DBNull.Value ? null : objRow[convCaseCourseKnowledgeRela.KnowledgeName].ToString().Trim(); //知识点名称
objvCaseCourseKnowledgeRelaEN.KnowledgeTitle = objRow[convCaseCourseKnowledgeRela.KnowledgeTitle] == DBNull.Value ? null : objRow[convCaseCourseKnowledgeRela.KnowledgeTitle].ToString().Trim(); //知识点标题
objvCaseCourseKnowledgeRelaEN.KnowledgeContent = objRow[convCaseCourseKnowledgeRela.KnowledgeContent] == DBNull.Value ? null : objRow[convCaseCourseKnowledgeRela.KnowledgeContent].ToString().Trim(); //知识点内容
objvCaseCourseKnowledgeRelaEN.RelationsDegree = TransNullToInt(objRow[convCaseCourseKnowledgeRela.RelationsDegree].ToString().Trim()); //关系度
objvCaseCourseKnowledgeRelaEN.CourseId = objRow[convCaseCourseKnowledgeRela.CourseId] == DBNull.Value ? null : objRow[convCaseCourseKnowledgeRela.CourseId].ToString().Trim(); //课程Id
objvCaseCourseKnowledgeRelaEN.CourseName = objRow[convCaseCourseKnowledgeRela.CourseName] == DBNull.Value ? null : objRow[convCaseCourseKnowledgeRela.CourseName].ToString().Trim(); //课程名称
objvCaseCourseKnowledgeRelaEN.CourseChapterId = objRow[convCaseCourseKnowledgeRela.CourseChapterId] == DBNull.Value ? null : objRow[convCaseCourseKnowledgeRela.CourseChapterId].ToString().Trim(); //课程章节ID
objvCaseCourseKnowledgeRelaEN.IdCaseCourseKnowledgeRelaType = objRow[convCaseCourseKnowledgeRela.IdCaseCourseKnowledgeRelaType].ToString().Trim(); //案例知识点关系类型流水号
objvCaseCourseKnowledgeRelaEN.CaseCourseKnowledgeRelaTypeName = objRow[convCaseCourseKnowledgeRela.CaseCourseKnowledgeRelaTypeName].ToString().Trim(); //案例知识点关系类型名称
objvCaseCourseKnowledgeRelaEN.BrowseCount = objRow[convCaseCourseKnowledgeRela.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCaseCourseKnowledgeRela.BrowseCount].ToString().Trim()); //浏览次数
objvCaseCourseKnowledgeRelaEN.OrderNum = objRow[convCaseCourseKnowledgeRela.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCaseCourseKnowledgeRela.OrderNum].ToString().Trim()); //序号
objvCaseCourseKnowledgeRelaEN.UpdDate = objRow[convCaseCourseKnowledgeRela.UpdDate] == DBNull.Value ? null : objRow[convCaseCourseKnowledgeRela.UpdDate].ToString().Trim(); //修改日期
objvCaseCourseKnowledgeRelaEN.UpdUserId = objRow[convCaseCourseKnowledgeRela.UpdUserId] == DBNull.Value ? null : objRow[convCaseCourseKnowledgeRela.UpdUserId].ToString().Trim(); //修改用户Id
objvCaseCourseKnowledgeRelaEN.Memo = objRow[convCaseCourseKnowledgeRela.Memo] == DBNull.Value ? null : objRow[convCaseCourseKnowledgeRela.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvCaseCourseKnowledgeRelaDA: GetObjByDataRow)", objException.Message));
}
objvCaseCourseKnowledgeRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvCaseCourseKnowledgeRelaEN;
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
objSQL = clsvCaseCourseKnowledgeRelaDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvCaseCourseKnowledgeRelaEN._CurrTabName, convCaseCourseKnowledgeRela.IdCaseCourseKnowledgeRela, 8, "");
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
objSQL = clsvCaseCourseKnowledgeRelaDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvCaseCourseKnowledgeRelaEN._CurrTabName, convCaseCourseKnowledgeRela.IdCaseCourseKnowledgeRela, 8, strPrefix);
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
 objSQL = clsvCaseCourseKnowledgeRelaDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select IdCaseCourseKnowledgeRela from vCaseCourseKnowledgeRela where " + strCondition;
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
 objSQL = clsvCaseCourseKnowledgeRelaDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select IdCaseCourseKnowledgeRela from vCaseCourseKnowledgeRela where " + strCondition;
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
 objSQL = clsvCaseCourseKnowledgeRelaDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vCaseCourseKnowledgeRela", "IdCaseCourseKnowledgeRela = " + ""+ lngIdCaseCourseKnowledgeRela+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvCaseCourseKnowledgeRelaDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCaseCourseKnowledgeRelaDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vCaseCourseKnowledgeRela", strCondition))
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
objSQL = clsvCaseCourseKnowledgeRelaDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vCaseCourseKnowledgeRela");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvCaseCourseKnowledgeRelaENS">源对象</param>
 /// <param name = "objvCaseCourseKnowledgeRelaENT">目标对象</param>
public void CopyTo(clsvCaseCourseKnowledgeRelaEN objvCaseCourseKnowledgeRelaENS, clsvCaseCourseKnowledgeRelaEN objvCaseCourseKnowledgeRelaENT)
{
objvCaseCourseKnowledgeRelaENT.IdCaseCourseKnowledgeRela = objvCaseCourseKnowledgeRelaENS.IdCaseCourseKnowledgeRela; //案例知识点关系流水号
objvCaseCourseKnowledgeRelaENT.FuncModuleId = objvCaseCourseKnowledgeRelaENS.FuncModuleId; //功能模块Id
objvCaseCourseKnowledgeRelaENT.FuncModuleName = objvCaseCourseKnowledgeRelaENS.FuncModuleName; //功能模块名称
objvCaseCourseKnowledgeRelaENT.CaseId = objvCaseCourseKnowledgeRelaENS.CaseId; //案例Id
objvCaseCourseKnowledgeRelaENT.CaseName = objvCaseCourseKnowledgeRelaENS.CaseName; //案例名称
objvCaseCourseKnowledgeRelaENT.OwnerId = objvCaseCourseKnowledgeRelaENS.OwnerId; //拥有者Id
objvCaseCourseKnowledgeRelaENT.OwnerName = objvCaseCourseKnowledgeRelaENS.OwnerName; //拥有者姓名
objvCaseCourseKnowledgeRelaENT.CourseKnowledgeId = objvCaseCourseKnowledgeRelaENS.CourseKnowledgeId; //知识点Id
objvCaseCourseKnowledgeRelaENT.KnowledgeName = objvCaseCourseKnowledgeRelaENS.KnowledgeName; //知识点名称
objvCaseCourseKnowledgeRelaENT.KnowledgeTitle = objvCaseCourseKnowledgeRelaENS.KnowledgeTitle; //知识点标题
objvCaseCourseKnowledgeRelaENT.KnowledgeContent = objvCaseCourseKnowledgeRelaENS.KnowledgeContent; //知识点内容
objvCaseCourseKnowledgeRelaENT.RelationsDegree = objvCaseCourseKnowledgeRelaENS.RelationsDegree; //关系度
objvCaseCourseKnowledgeRelaENT.CourseId = objvCaseCourseKnowledgeRelaENS.CourseId; //课程Id
objvCaseCourseKnowledgeRelaENT.CourseName = objvCaseCourseKnowledgeRelaENS.CourseName; //课程名称
objvCaseCourseKnowledgeRelaENT.CourseChapterId = objvCaseCourseKnowledgeRelaENS.CourseChapterId; //课程章节ID
objvCaseCourseKnowledgeRelaENT.IdCaseCourseKnowledgeRelaType = objvCaseCourseKnowledgeRelaENS.IdCaseCourseKnowledgeRelaType; //案例知识点关系类型流水号
objvCaseCourseKnowledgeRelaENT.CaseCourseKnowledgeRelaTypeName = objvCaseCourseKnowledgeRelaENS.CaseCourseKnowledgeRelaTypeName; //案例知识点关系类型名称
objvCaseCourseKnowledgeRelaENT.BrowseCount = objvCaseCourseKnowledgeRelaENS.BrowseCount; //浏览次数
objvCaseCourseKnowledgeRelaENT.OrderNum = objvCaseCourseKnowledgeRelaENS.OrderNum; //序号
objvCaseCourseKnowledgeRelaENT.UpdDate = objvCaseCourseKnowledgeRelaENS.UpdDate; //修改日期
objvCaseCourseKnowledgeRelaENT.UpdUserId = objvCaseCourseKnowledgeRelaENS.UpdUserId; //修改用户Id
objvCaseCourseKnowledgeRelaENT.Memo = objvCaseCourseKnowledgeRelaENS.Memo; //备注
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvCaseCourseKnowledgeRelaEN objvCaseCourseKnowledgeRelaEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvCaseCourseKnowledgeRelaEN.FuncModuleId, 4, convCaseCourseKnowledgeRela.FuncModuleId);
clsCheckSql.CheckFieldLen(objvCaseCourseKnowledgeRelaEN.FuncModuleName, 30, convCaseCourseKnowledgeRela.FuncModuleName);
clsCheckSql.CheckFieldLen(objvCaseCourseKnowledgeRelaEN.CaseId, 8, convCaseCourseKnowledgeRela.CaseId);
clsCheckSql.CheckFieldLen(objvCaseCourseKnowledgeRelaEN.CaseName, 100, convCaseCourseKnowledgeRela.CaseName);
clsCheckSql.CheckFieldLen(objvCaseCourseKnowledgeRelaEN.OwnerId, 20, convCaseCourseKnowledgeRela.OwnerId);
clsCheckSql.CheckFieldLen(objvCaseCourseKnowledgeRelaEN.OwnerName, 30, convCaseCourseKnowledgeRela.OwnerName);
clsCheckSql.CheckFieldLen(objvCaseCourseKnowledgeRelaEN.CourseKnowledgeId, 8, convCaseCourseKnowledgeRela.CourseKnowledgeId);
clsCheckSql.CheckFieldLen(objvCaseCourseKnowledgeRelaEN.KnowledgeName, 100, convCaseCourseKnowledgeRela.KnowledgeName);
clsCheckSql.CheckFieldLen(objvCaseCourseKnowledgeRelaEN.KnowledgeTitle, 100, convCaseCourseKnowledgeRela.KnowledgeTitle);
clsCheckSql.CheckFieldLen(objvCaseCourseKnowledgeRelaEN.CourseId, 8, convCaseCourseKnowledgeRela.CourseId);
clsCheckSql.CheckFieldLen(objvCaseCourseKnowledgeRelaEN.CourseName, 100, convCaseCourseKnowledgeRela.CourseName);
clsCheckSql.CheckFieldLen(objvCaseCourseKnowledgeRelaEN.CourseChapterId, 8, convCaseCourseKnowledgeRela.CourseChapterId);
clsCheckSql.CheckFieldLen(objvCaseCourseKnowledgeRelaEN.IdCaseCourseKnowledgeRelaType, 4, convCaseCourseKnowledgeRela.IdCaseCourseKnowledgeRelaType);
clsCheckSql.CheckFieldLen(objvCaseCourseKnowledgeRelaEN.CaseCourseKnowledgeRelaTypeName, 50, convCaseCourseKnowledgeRela.CaseCourseKnowledgeRelaTypeName);
clsCheckSql.CheckFieldLen(objvCaseCourseKnowledgeRelaEN.UpdDate, 20, convCaseCourseKnowledgeRela.UpdDate);
clsCheckSql.CheckFieldLen(objvCaseCourseKnowledgeRelaEN.UpdUserId, 20, convCaseCourseKnowledgeRela.UpdUserId);
clsCheckSql.CheckFieldLen(objvCaseCourseKnowledgeRelaEN.Memo, 1000, convCaseCourseKnowledgeRela.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvCaseCourseKnowledgeRelaEN.FuncModuleId, convCaseCourseKnowledgeRela.FuncModuleId);
clsCheckSql.CheckSqlInjection4Field(objvCaseCourseKnowledgeRelaEN.FuncModuleName, convCaseCourseKnowledgeRela.FuncModuleName);
clsCheckSql.CheckSqlInjection4Field(objvCaseCourseKnowledgeRelaEN.CaseId, convCaseCourseKnowledgeRela.CaseId);
clsCheckSql.CheckSqlInjection4Field(objvCaseCourseKnowledgeRelaEN.CaseName, convCaseCourseKnowledgeRela.CaseName);
clsCheckSql.CheckSqlInjection4Field(objvCaseCourseKnowledgeRelaEN.OwnerId, convCaseCourseKnowledgeRela.OwnerId);
clsCheckSql.CheckSqlInjection4Field(objvCaseCourseKnowledgeRelaEN.OwnerName, convCaseCourseKnowledgeRela.OwnerName);
clsCheckSql.CheckSqlInjection4Field(objvCaseCourseKnowledgeRelaEN.CourseKnowledgeId, convCaseCourseKnowledgeRela.CourseKnowledgeId);
clsCheckSql.CheckSqlInjection4Field(objvCaseCourseKnowledgeRelaEN.KnowledgeName, convCaseCourseKnowledgeRela.KnowledgeName);
clsCheckSql.CheckSqlInjection4Field(objvCaseCourseKnowledgeRelaEN.KnowledgeTitle, convCaseCourseKnowledgeRela.KnowledgeTitle);
clsCheckSql.CheckSqlInjection4Field(objvCaseCourseKnowledgeRelaEN.CourseId, convCaseCourseKnowledgeRela.CourseId);
clsCheckSql.CheckSqlInjection4Field(objvCaseCourseKnowledgeRelaEN.CourseName, convCaseCourseKnowledgeRela.CourseName);
clsCheckSql.CheckSqlInjection4Field(objvCaseCourseKnowledgeRelaEN.CourseChapterId, convCaseCourseKnowledgeRela.CourseChapterId);
clsCheckSql.CheckSqlInjection4Field(objvCaseCourseKnowledgeRelaEN.IdCaseCourseKnowledgeRelaType, convCaseCourseKnowledgeRela.IdCaseCourseKnowledgeRelaType);
clsCheckSql.CheckSqlInjection4Field(objvCaseCourseKnowledgeRelaEN.CaseCourseKnowledgeRelaTypeName, convCaseCourseKnowledgeRela.CaseCourseKnowledgeRelaTypeName);
clsCheckSql.CheckSqlInjection4Field(objvCaseCourseKnowledgeRelaEN.UpdDate, convCaseCourseKnowledgeRela.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objvCaseCourseKnowledgeRelaEN.UpdUserId, convCaseCourseKnowledgeRela.UpdUserId);
clsCheckSql.CheckSqlInjection4Field(objvCaseCourseKnowledgeRelaEN.Memo, convCaseCourseKnowledgeRela.Memo);
//检查外键字段长度
 objvCaseCourseKnowledgeRelaEN._IsCheckProperty = true;
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
 objSQL = clsvCaseCourseKnowledgeRelaDA.GetSpecSQLObj();
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
 objSQL = clsvCaseCourseKnowledgeRelaDA.GetSpecSQLObj();
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
 objSQL = clsvCaseCourseKnowledgeRelaDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvCaseCourseKnowledgeRelaEN._CurrTabName);
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
 objSQL = clsvCaseCourseKnowledgeRelaDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvCaseCourseKnowledgeRelaEN._CurrTabName, strCondition);
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
 objSQL = clsvCaseCourseKnowledgeRelaDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}