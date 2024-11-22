
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvCaseCourseExamRelaDA
 表名:vCaseCourseExamRela(01120391)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:44:37
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
 /// v案例题库关系(vCaseCourseExamRela)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvCaseCourseExamRelaDA : clsCommBase4DA
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
 return clsvCaseCourseExamRelaEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvCaseCourseExamRelaEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvCaseCourseExamRelaEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvCaseCourseExamRelaEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvCaseCourseExamRelaEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvCaseCourseExamRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCaseCourseExamRelaDA.GetSpecSQLObj();
strSQL = "Select * from vCaseCourseExamRela where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vCaseCourseExamRela(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvCaseCourseExamRelaDA: GetDataTable_vCaseCourseExamRela)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCaseCourseExamRelaDA.GetSpecSQLObj();
strSQL = "Select * from vCaseCourseExamRela where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvCaseCourseExamRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCaseCourseExamRelaDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvCaseCourseExamRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCaseCourseExamRelaDA.GetSpecSQLObj();
strSQL = "Select * from vCaseCourseExamRela where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvCaseCourseExamRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCaseCourseExamRelaDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvCaseCourseExamRelaDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCaseCourseExamRelaDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vCaseCourseExamRela where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vCaseCourseExamRela where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvCaseCourseExamRelaDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCaseCourseExamRelaDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vCaseCourseExamRela where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvCaseCourseExamRelaDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCaseCourseExamRelaDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vCaseCourseExamRela.* from vCaseCourseExamRela Left Join {1} on {2} where {3} and vCaseCourseExamRela.IdCaseCourseExamRela not in (Select top {5} vCaseCourseExamRela.IdCaseCourseExamRela from vCaseCourseExamRela Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vCaseCourseExamRela where {1} and IdCaseCourseExamRela not in (Select top {2} IdCaseCourseExamRela from vCaseCourseExamRela where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vCaseCourseExamRela where {1} and IdCaseCourseExamRela not in (Select top {3} IdCaseCourseExamRela from vCaseCourseExamRela where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvCaseCourseExamRelaDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCaseCourseExamRelaDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vCaseCourseExamRela.* from vCaseCourseExamRela Left Join {1} on {2} where {3} and vCaseCourseExamRela.IdCaseCourseExamRela not in (Select top {5} vCaseCourseExamRela.IdCaseCourseExamRela from vCaseCourseExamRela Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vCaseCourseExamRela where {1} and IdCaseCourseExamRela not in (Select top {2} IdCaseCourseExamRela from vCaseCourseExamRela where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vCaseCourseExamRela where {1} and IdCaseCourseExamRela not in (Select top {3} IdCaseCourseExamRela from vCaseCourseExamRela where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvCaseCourseExamRelaEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvCaseCourseExamRelaDA:GetObjLst)", objException.Message));
}
List<clsvCaseCourseExamRelaEN> arrObjLst = new List<clsvCaseCourseExamRelaEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCaseCourseExamRelaDA.GetSpecSQLObj();
strSQL = "Select * from vCaseCourseExamRela where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCaseCourseExamRelaEN objvCaseCourseExamRelaEN = new clsvCaseCourseExamRelaEN();
try
{
objvCaseCourseExamRelaEN.IdCaseCourseExamRela = TransNullToInt(objRow[convCaseCourseExamRela.IdCaseCourseExamRela].ToString().Trim()); //案例题库关系流水号
objvCaseCourseExamRelaEN.FuncModuleId = objRow[convCaseCourseExamRela.FuncModuleId].ToString().Trim(); //功能模块Id
objvCaseCourseExamRelaEN.FuncModuleName = objRow[convCaseCourseExamRela.FuncModuleName].ToString().Trim(); //功能模块名称
objvCaseCourseExamRelaEN.CaseId = objRow[convCaseCourseExamRela.CaseId] == DBNull.Value ? null : objRow[convCaseCourseExamRela.CaseId].ToString().Trim(); //案例Id
objvCaseCourseExamRelaEN.CaseName = objRow[convCaseCourseExamRela.CaseName] == DBNull.Value ? null : objRow[convCaseCourseExamRela.CaseName].ToString().Trim(); //案例名称
objvCaseCourseExamRelaEN.OwnerId = objRow[convCaseCourseExamRela.OwnerId].ToString().Trim(); //拥有者Id
objvCaseCourseExamRelaEN.OwnerName = objRow[convCaseCourseExamRela.OwnerName] == DBNull.Value ? null : objRow[convCaseCourseExamRela.OwnerName].ToString().Trim(); //拥有者姓名
objvCaseCourseExamRelaEN.QuestionID = objRow[convCaseCourseExamRela.QuestionID] == DBNull.Value ? null : objRow[convCaseCourseExamRela.QuestionID].ToString().Trim(); //题目ID
objvCaseCourseExamRelaEN.ExamAnswer = objRow[convCaseCourseExamRela.ExamAnswer] == DBNull.Value ? null : objRow[convCaseCourseExamRela.ExamAnswer].ToString().Trim(); //题目答案
objvCaseCourseExamRelaEN.StartTime = objRow[convCaseCourseExamRela.StartTime] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[convCaseCourseExamRela.StartTime].ToString().Trim()); //开始时间(s)
objvCaseCourseExamRelaEN.ParentNodeID = objRow[convCaseCourseExamRela.ParentNodeID] == DBNull.Value ? null : objRow[convCaseCourseExamRela.ParentNodeID].ToString().Trim(); //父节点编号
objvCaseCourseExamRelaEN.ParentNodeName = objRow[convCaseCourseExamRela.ParentNodeName] == DBNull.Value ? null : objRow[convCaseCourseExamRela.ParentNodeName].ToString().Trim(); //父节点名称
objvCaseCourseExamRelaEN.CourseId = objRow[convCaseCourseExamRela.CourseId] == DBNull.Value ? null : objRow[convCaseCourseExamRela.CourseId].ToString().Trim(); //课程Id
objvCaseCourseExamRelaEN.CourseName = objRow[convCaseCourseExamRela.CourseName] == DBNull.Value ? null : objRow[convCaseCourseExamRela.CourseName].ToString().Trim(); //课程名称
objvCaseCourseExamRelaEN.IdCaseCourseExamRelaType = objRow[convCaseCourseExamRela.IdCaseCourseExamRelaType].ToString().Trim(); //案例题库关系类型流水号
objvCaseCourseExamRelaEN.CaseCourseExamRelaTypeName = objRow[convCaseCourseExamRela.CaseCourseExamRelaTypeName].ToString().Trim(); //案例题库关系类型名称
objvCaseCourseExamRelaEN.BrowseCount = objRow[convCaseCourseExamRela.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCaseCourseExamRela.BrowseCount].ToString().Trim()); //浏览次数
objvCaseCourseExamRelaEN.OrderNum = objRow[convCaseCourseExamRela.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCaseCourseExamRela.OrderNum].ToString().Trim()); //序号
objvCaseCourseExamRelaEN.UpdDate = objRow[convCaseCourseExamRela.UpdDate] == DBNull.Value ? null : objRow[convCaseCourseExamRela.UpdDate].ToString().Trim(); //修改日期
objvCaseCourseExamRelaEN.UpdUserId = objRow[convCaseCourseExamRela.UpdUserId] == DBNull.Value ? null : objRow[convCaseCourseExamRela.UpdUserId].ToString().Trim(); //修改用户Id
objvCaseCourseExamRelaEN.Memo = objRow[convCaseCourseExamRela.Memo] == DBNull.Value ? null : objRow[convCaseCourseExamRela.Memo].ToString().Trim(); //备注
objvCaseCourseExamRelaEN.QuestionContent = objRow[convCaseCourseExamRela.QuestionContent] == DBNull.Value ? null : objRow[convCaseCourseExamRela.QuestionContent].ToString().Trim(); //题目内容
objvCaseCourseExamRelaEN.QuestionName = objRow[convCaseCourseExamRela.QuestionName] == DBNull.Value ? null : objRow[convCaseCourseExamRela.QuestionName].ToString().Trim(); //题目名称
objvCaseCourseExamRelaEN.QuestionNo = objRow[convCaseCourseExamRela.QuestionNo] == DBNull.Value ? null : objRow[convCaseCourseExamRela.QuestionNo].ToString().Trim(); //题目编号
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvCaseCourseExamRelaDA: GetObjLst)", objException.Message));
}
objvCaseCourseExamRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvCaseCourseExamRelaEN);
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
public List<clsvCaseCourseExamRelaEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvCaseCourseExamRelaDA:GetObjLstByTabName)", objException.Message));
}
List<clsvCaseCourseExamRelaEN> arrObjLst = new List<clsvCaseCourseExamRelaEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCaseCourseExamRelaDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCaseCourseExamRelaEN objvCaseCourseExamRelaEN = new clsvCaseCourseExamRelaEN();
try
{
objvCaseCourseExamRelaEN.IdCaseCourseExamRela = TransNullToInt(objRow[convCaseCourseExamRela.IdCaseCourseExamRela].ToString().Trim()); //案例题库关系流水号
objvCaseCourseExamRelaEN.FuncModuleId = objRow[convCaseCourseExamRela.FuncModuleId].ToString().Trim(); //功能模块Id
objvCaseCourseExamRelaEN.FuncModuleName = objRow[convCaseCourseExamRela.FuncModuleName].ToString().Trim(); //功能模块名称
objvCaseCourseExamRelaEN.CaseId = objRow[convCaseCourseExamRela.CaseId] == DBNull.Value ? null : objRow[convCaseCourseExamRela.CaseId].ToString().Trim(); //案例Id
objvCaseCourseExamRelaEN.CaseName = objRow[convCaseCourseExamRela.CaseName] == DBNull.Value ? null : objRow[convCaseCourseExamRela.CaseName].ToString().Trim(); //案例名称
objvCaseCourseExamRelaEN.OwnerId = objRow[convCaseCourseExamRela.OwnerId].ToString().Trim(); //拥有者Id
objvCaseCourseExamRelaEN.OwnerName = objRow[convCaseCourseExamRela.OwnerName] == DBNull.Value ? null : objRow[convCaseCourseExamRela.OwnerName].ToString().Trim(); //拥有者姓名
objvCaseCourseExamRelaEN.QuestionID = objRow[convCaseCourseExamRela.QuestionID] == DBNull.Value ? null : objRow[convCaseCourseExamRela.QuestionID].ToString().Trim(); //题目ID
objvCaseCourseExamRelaEN.ExamAnswer = objRow[convCaseCourseExamRela.ExamAnswer] == DBNull.Value ? null : objRow[convCaseCourseExamRela.ExamAnswer].ToString().Trim(); //题目答案
objvCaseCourseExamRelaEN.StartTime = objRow[convCaseCourseExamRela.StartTime] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[convCaseCourseExamRela.StartTime].ToString().Trim()); //开始时间(s)
objvCaseCourseExamRelaEN.ParentNodeID = objRow[convCaseCourseExamRela.ParentNodeID] == DBNull.Value ? null : objRow[convCaseCourseExamRela.ParentNodeID].ToString().Trim(); //父节点编号
objvCaseCourseExamRelaEN.ParentNodeName = objRow[convCaseCourseExamRela.ParentNodeName] == DBNull.Value ? null : objRow[convCaseCourseExamRela.ParentNodeName].ToString().Trim(); //父节点名称
objvCaseCourseExamRelaEN.CourseId = objRow[convCaseCourseExamRela.CourseId] == DBNull.Value ? null : objRow[convCaseCourseExamRela.CourseId].ToString().Trim(); //课程Id
objvCaseCourseExamRelaEN.CourseName = objRow[convCaseCourseExamRela.CourseName] == DBNull.Value ? null : objRow[convCaseCourseExamRela.CourseName].ToString().Trim(); //课程名称
objvCaseCourseExamRelaEN.IdCaseCourseExamRelaType = objRow[convCaseCourseExamRela.IdCaseCourseExamRelaType].ToString().Trim(); //案例题库关系类型流水号
objvCaseCourseExamRelaEN.CaseCourseExamRelaTypeName = objRow[convCaseCourseExamRela.CaseCourseExamRelaTypeName].ToString().Trim(); //案例题库关系类型名称
objvCaseCourseExamRelaEN.BrowseCount = objRow[convCaseCourseExamRela.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCaseCourseExamRela.BrowseCount].ToString().Trim()); //浏览次数
objvCaseCourseExamRelaEN.OrderNum = objRow[convCaseCourseExamRela.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCaseCourseExamRela.OrderNum].ToString().Trim()); //序号
objvCaseCourseExamRelaEN.UpdDate = objRow[convCaseCourseExamRela.UpdDate] == DBNull.Value ? null : objRow[convCaseCourseExamRela.UpdDate].ToString().Trim(); //修改日期
objvCaseCourseExamRelaEN.UpdUserId = objRow[convCaseCourseExamRela.UpdUserId] == DBNull.Value ? null : objRow[convCaseCourseExamRela.UpdUserId].ToString().Trim(); //修改用户Id
objvCaseCourseExamRelaEN.Memo = objRow[convCaseCourseExamRela.Memo] == DBNull.Value ? null : objRow[convCaseCourseExamRela.Memo].ToString().Trim(); //备注
objvCaseCourseExamRelaEN.QuestionContent = objRow[convCaseCourseExamRela.QuestionContent] == DBNull.Value ? null : objRow[convCaseCourseExamRela.QuestionContent].ToString().Trim(); //题目内容
objvCaseCourseExamRelaEN.QuestionName = objRow[convCaseCourseExamRela.QuestionName] == DBNull.Value ? null : objRow[convCaseCourseExamRela.QuestionName].ToString().Trim(); //题目名称
objvCaseCourseExamRelaEN.QuestionNo = objRow[convCaseCourseExamRela.QuestionNo] == DBNull.Value ? null : objRow[convCaseCourseExamRela.QuestionNo].ToString().Trim(); //题目编号
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvCaseCourseExamRelaDA: GetObjLst)", objException.Message));
}
objvCaseCourseExamRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvCaseCourseExamRelaEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvCaseCourseExamRelaEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvCaseCourseExamRela(ref clsvCaseCourseExamRelaEN objvCaseCourseExamRelaEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCaseCourseExamRelaDA.GetSpecSQLObj();
strSQL = "Select * from vCaseCourseExamRela where IdCaseCourseExamRela = " + ""+ objvCaseCourseExamRelaEN.IdCaseCourseExamRela+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvCaseCourseExamRelaEN.IdCaseCourseExamRela = TransNullToInt(objDT.Rows[0][convCaseCourseExamRela.IdCaseCourseExamRela].ToString().Trim()); //案例题库关系流水号(字段类型:bigint,字段长度:8,是否可空:False)
 objvCaseCourseExamRelaEN.FuncModuleId = objDT.Rows[0][convCaseCourseExamRela.FuncModuleId].ToString().Trim(); //功能模块Id(字段类型:char,字段长度:4,是否可空:True)
 objvCaseCourseExamRelaEN.FuncModuleName = objDT.Rows[0][convCaseCourseExamRela.FuncModuleName].ToString().Trim(); //功能模块名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvCaseCourseExamRelaEN.CaseId = objDT.Rows[0][convCaseCourseExamRela.CaseId].ToString().Trim(); //案例Id(字段类型:char,字段长度:8,是否可空:True)
 objvCaseCourseExamRelaEN.CaseName = objDT.Rows[0][convCaseCourseExamRela.CaseName].ToString().Trim(); //案例名称(字段类型:varchar,字段长度:100,是否可空:True)
 objvCaseCourseExamRelaEN.OwnerId = objDT.Rows[0][convCaseCourseExamRela.OwnerId].ToString().Trim(); //拥有者Id(字段类型:varchar,字段长度:20,是否可空:False)
 objvCaseCourseExamRelaEN.OwnerName = objDT.Rows[0][convCaseCourseExamRela.OwnerName].ToString().Trim(); //拥有者姓名(字段类型:varchar,字段长度:30,是否可空:True)
 objvCaseCourseExamRelaEN.QuestionID = objDT.Rows[0][convCaseCourseExamRela.QuestionID].ToString().Trim(); //题目ID(字段类型:char,字段长度:8,是否可空:True)
 objvCaseCourseExamRelaEN.ExamAnswer = objDT.Rows[0][convCaseCourseExamRela.ExamAnswer].ToString().Trim(); //题目答案(字段类型:varchar,字段长度:8000,是否可空:True)
 objvCaseCourseExamRelaEN.StartTime = TransNullToDouble(objDT.Rows[0][convCaseCourseExamRela.StartTime].ToString().Trim()); //开始时间(s)(字段类型:decimal,字段长度:12,是否可空:False)
 objvCaseCourseExamRelaEN.ParentNodeID = objDT.Rows[0][convCaseCourseExamRela.ParentNodeID].ToString().Trim(); //父节点编号(字段类型:varchar,字段长度:8,是否可空:True)
 objvCaseCourseExamRelaEN.ParentNodeName = objDT.Rows[0][convCaseCourseExamRela.ParentNodeName].ToString().Trim(); //父节点名称(字段类型:varchar,字段长度:50,是否可空:True)
 objvCaseCourseExamRelaEN.CourseId = objDT.Rows[0][convCaseCourseExamRela.CourseId].ToString().Trim(); //课程Id(字段类型:char,字段长度:8,是否可空:True)
 objvCaseCourseExamRelaEN.CourseName = objDT.Rows[0][convCaseCourseExamRela.CourseName].ToString().Trim(); //课程名称(字段类型:varchar,字段长度:100,是否可空:True)
 objvCaseCourseExamRelaEN.IdCaseCourseExamRelaType = objDT.Rows[0][convCaseCourseExamRela.IdCaseCourseExamRelaType].ToString().Trim(); //案例题库关系类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvCaseCourseExamRelaEN.CaseCourseExamRelaTypeName = objDT.Rows[0][convCaseCourseExamRela.CaseCourseExamRelaTypeName].ToString().Trim(); //案例题库关系类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvCaseCourseExamRelaEN.BrowseCount = TransNullToInt(objDT.Rows[0][convCaseCourseExamRela.BrowseCount].ToString().Trim()); //浏览次数(字段类型:int,字段长度:4,是否可空:True)
 objvCaseCourseExamRelaEN.OrderNum = TransNullToInt(objDT.Rows[0][convCaseCourseExamRela.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:True)
 objvCaseCourseExamRelaEN.UpdDate = objDT.Rows[0][convCaseCourseExamRela.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvCaseCourseExamRelaEN.UpdUserId = objDT.Rows[0][convCaseCourseExamRela.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:True)
 objvCaseCourseExamRelaEN.Memo = objDT.Rows[0][convCaseCourseExamRela.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvCaseCourseExamRelaEN.QuestionContent = objDT.Rows[0][convCaseCourseExamRela.QuestionContent].ToString().Trim(); //题目内容(字段类型:varchar,字段长度:4000,是否可空:True)
 objvCaseCourseExamRelaEN.QuestionName = objDT.Rows[0][convCaseCourseExamRela.QuestionName].ToString().Trim(); //题目名称(字段类型:varchar,字段长度:500,是否可空:True)
 objvCaseCourseExamRelaEN.QuestionNo = objDT.Rows[0][convCaseCourseExamRela.QuestionNo].ToString().Trim(); //题目编号(字段类型:varchar,字段长度:10,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvCaseCourseExamRelaDA: GetvCaseCourseExamRela)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngIdCaseCourseExamRela">表关键字</param>
 /// <returns>表对象</returns>
public clsvCaseCourseExamRelaEN GetObjByIdCaseCourseExamRela(long lngIdCaseCourseExamRela)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCaseCourseExamRelaDA.GetSpecSQLObj();
strSQL = "Select * from vCaseCourseExamRela where IdCaseCourseExamRela = " + ""+ lngIdCaseCourseExamRela+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvCaseCourseExamRelaEN objvCaseCourseExamRelaEN = new clsvCaseCourseExamRelaEN();
try
{
 objvCaseCourseExamRelaEN.IdCaseCourseExamRela = Int32.Parse(objRow[convCaseCourseExamRela.IdCaseCourseExamRela].ToString().Trim()); //案例题库关系流水号(字段类型:bigint,字段长度:8,是否可空:False)
 objvCaseCourseExamRelaEN.FuncModuleId = objRow[convCaseCourseExamRela.FuncModuleId].ToString().Trim(); //功能模块Id(字段类型:char,字段长度:4,是否可空:True)
 objvCaseCourseExamRelaEN.FuncModuleName = objRow[convCaseCourseExamRela.FuncModuleName].ToString().Trim(); //功能模块名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvCaseCourseExamRelaEN.CaseId = objRow[convCaseCourseExamRela.CaseId] == DBNull.Value ? null : objRow[convCaseCourseExamRela.CaseId].ToString().Trim(); //案例Id(字段类型:char,字段长度:8,是否可空:True)
 objvCaseCourseExamRelaEN.CaseName = objRow[convCaseCourseExamRela.CaseName] == DBNull.Value ? null : objRow[convCaseCourseExamRela.CaseName].ToString().Trim(); //案例名称(字段类型:varchar,字段长度:100,是否可空:True)
 objvCaseCourseExamRelaEN.OwnerId = objRow[convCaseCourseExamRela.OwnerId].ToString().Trim(); //拥有者Id(字段类型:varchar,字段长度:20,是否可空:False)
 objvCaseCourseExamRelaEN.OwnerName = objRow[convCaseCourseExamRela.OwnerName] == DBNull.Value ? null : objRow[convCaseCourseExamRela.OwnerName].ToString().Trim(); //拥有者姓名(字段类型:varchar,字段长度:30,是否可空:True)
 objvCaseCourseExamRelaEN.QuestionID = objRow[convCaseCourseExamRela.QuestionID] == DBNull.Value ? null : objRow[convCaseCourseExamRela.QuestionID].ToString().Trim(); //题目ID(字段类型:char,字段长度:8,是否可空:True)
 objvCaseCourseExamRelaEN.ExamAnswer = objRow[convCaseCourseExamRela.ExamAnswer] == DBNull.Value ? null : objRow[convCaseCourseExamRela.ExamAnswer].ToString().Trim(); //题目答案(字段类型:varchar,字段长度:8000,是否可空:True)
 objvCaseCourseExamRelaEN.StartTime = objRow[convCaseCourseExamRela.StartTime] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convCaseCourseExamRela.StartTime].ToString().Trim()); //开始时间(s)(字段类型:decimal,字段长度:12,是否可空:False)
 objvCaseCourseExamRelaEN.ParentNodeID = objRow[convCaseCourseExamRela.ParentNodeID] == DBNull.Value ? null : objRow[convCaseCourseExamRela.ParentNodeID].ToString().Trim(); //父节点编号(字段类型:varchar,字段长度:8,是否可空:True)
 objvCaseCourseExamRelaEN.ParentNodeName = objRow[convCaseCourseExamRela.ParentNodeName] == DBNull.Value ? null : objRow[convCaseCourseExamRela.ParentNodeName].ToString().Trim(); //父节点名称(字段类型:varchar,字段长度:50,是否可空:True)
 objvCaseCourseExamRelaEN.CourseId = objRow[convCaseCourseExamRela.CourseId] == DBNull.Value ? null : objRow[convCaseCourseExamRela.CourseId].ToString().Trim(); //课程Id(字段类型:char,字段长度:8,是否可空:True)
 objvCaseCourseExamRelaEN.CourseName = objRow[convCaseCourseExamRela.CourseName] == DBNull.Value ? null : objRow[convCaseCourseExamRela.CourseName].ToString().Trim(); //课程名称(字段类型:varchar,字段长度:100,是否可空:True)
 objvCaseCourseExamRelaEN.IdCaseCourseExamRelaType = objRow[convCaseCourseExamRela.IdCaseCourseExamRelaType].ToString().Trim(); //案例题库关系类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvCaseCourseExamRelaEN.CaseCourseExamRelaTypeName = objRow[convCaseCourseExamRela.CaseCourseExamRelaTypeName].ToString().Trim(); //案例题库关系类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvCaseCourseExamRelaEN.BrowseCount = objRow[convCaseCourseExamRela.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCaseCourseExamRela.BrowseCount].ToString().Trim()); //浏览次数(字段类型:int,字段长度:4,是否可空:True)
 objvCaseCourseExamRelaEN.OrderNum = objRow[convCaseCourseExamRela.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCaseCourseExamRela.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:True)
 objvCaseCourseExamRelaEN.UpdDate = objRow[convCaseCourseExamRela.UpdDate] == DBNull.Value ? null : objRow[convCaseCourseExamRela.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvCaseCourseExamRelaEN.UpdUserId = objRow[convCaseCourseExamRela.UpdUserId] == DBNull.Value ? null : objRow[convCaseCourseExamRela.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:True)
 objvCaseCourseExamRelaEN.Memo = objRow[convCaseCourseExamRela.Memo] == DBNull.Value ? null : objRow[convCaseCourseExamRela.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvCaseCourseExamRelaEN.QuestionContent = objRow[convCaseCourseExamRela.QuestionContent] == DBNull.Value ? null : objRow[convCaseCourseExamRela.QuestionContent].ToString().Trim(); //题目内容(字段类型:varchar,字段长度:4000,是否可空:True)
 objvCaseCourseExamRelaEN.QuestionName = objRow[convCaseCourseExamRela.QuestionName] == DBNull.Value ? null : objRow[convCaseCourseExamRela.QuestionName].ToString().Trim(); //题目名称(字段类型:varchar,字段长度:500,是否可空:True)
 objvCaseCourseExamRelaEN.QuestionNo = objRow[convCaseCourseExamRela.QuestionNo] == DBNull.Value ? null : objRow[convCaseCourseExamRela.QuestionNo].ToString().Trim(); //题目编号(字段类型:varchar,字段长度:10,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvCaseCourseExamRelaDA: GetObjByIdCaseCourseExamRela)", objException.Message));
}
return objvCaseCourseExamRelaEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvCaseCourseExamRelaEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvCaseCourseExamRelaDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCaseCourseExamRelaDA.GetSpecSQLObj();
strSQL = "Select * from vCaseCourseExamRela where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvCaseCourseExamRelaEN objvCaseCourseExamRelaEN = new clsvCaseCourseExamRelaEN()
{
IdCaseCourseExamRela = TransNullToInt(objRow[convCaseCourseExamRela.IdCaseCourseExamRela].ToString().Trim()), //案例题库关系流水号
FuncModuleId = objRow[convCaseCourseExamRela.FuncModuleId].ToString().Trim(), //功能模块Id
FuncModuleName = objRow[convCaseCourseExamRela.FuncModuleName].ToString().Trim(), //功能模块名称
CaseId = objRow[convCaseCourseExamRela.CaseId] == DBNull.Value ? null : objRow[convCaseCourseExamRela.CaseId].ToString().Trim(), //案例Id
CaseName = objRow[convCaseCourseExamRela.CaseName] == DBNull.Value ? null : objRow[convCaseCourseExamRela.CaseName].ToString().Trim(), //案例名称
OwnerId = objRow[convCaseCourseExamRela.OwnerId].ToString().Trim(), //拥有者Id
OwnerName = objRow[convCaseCourseExamRela.OwnerName] == DBNull.Value ? null : objRow[convCaseCourseExamRela.OwnerName].ToString().Trim(), //拥有者姓名
QuestionID = objRow[convCaseCourseExamRela.QuestionID] == DBNull.Value ? null : objRow[convCaseCourseExamRela.QuestionID].ToString().Trim(), //题目ID
ExamAnswer = objRow[convCaseCourseExamRela.ExamAnswer] == DBNull.Value ? null : objRow[convCaseCourseExamRela.ExamAnswer].ToString().Trim(), //题目答案
StartTime = objRow[convCaseCourseExamRela.StartTime] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[convCaseCourseExamRela.StartTime].ToString().Trim()), //开始时间(s)
ParentNodeID = objRow[convCaseCourseExamRela.ParentNodeID] == DBNull.Value ? null : objRow[convCaseCourseExamRela.ParentNodeID].ToString().Trim(), //父节点编号
ParentNodeName = objRow[convCaseCourseExamRela.ParentNodeName] == DBNull.Value ? null : objRow[convCaseCourseExamRela.ParentNodeName].ToString().Trim(), //父节点名称
CourseId = objRow[convCaseCourseExamRela.CourseId] == DBNull.Value ? null : objRow[convCaseCourseExamRela.CourseId].ToString().Trim(), //课程Id
CourseName = objRow[convCaseCourseExamRela.CourseName] == DBNull.Value ? null : objRow[convCaseCourseExamRela.CourseName].ToString().Trim(), //课程名称
IdCaseCourseExamRelaType = objRow[convCaseCourseExamRela.IdCaseCourseExamRelaType].ToString().Trim(), //案例题库关系类型流水号
CaseCourseExamRelaTypeName = objRow[convCaseCourseExamRela.CaseCourseExamRelaTypeName].ToString().Trim(), //案例题库关系类型名称
BrowseCount = objRow[convCaseCourseExamRela.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCaseCourseExamRela.BrowseCount].ToString().Trim()), //浏览次数
OrderNum = objRow[convCaseCourseExamRela.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCaseCourseExamRela.OrderNum].ToString().Trim()), //序号
UpdDate = objRow[convCaseCourseExamRela.UpdDate] == DBNull.Value ? null : objRow[convCaseCourseExamRela.UpdDate].ToString().Trim(), //修改日期
UpdUserId = objRow[convCaseCourseExamRela.UpdUserId] == DBNull.Value ? null : objRow[convCaseCourseExamRela.UpdUserId].ToString().Trim(), //修改用户Id
Memo = objRow[convCaseCourseExamRela.Memo] == DBNull.Value ? null : objRow[convCaseCourseExamRela.Memo].ToString().Trim(), //备注
QuestionContent = objRow[convCaseCourseExamRela.QuestionContent] == DBNull.Value ? null : objRow[convCaseCourseExamRela.QuestionContent].ToString().Trim(), //题目内容
QuestionName = objRow[convCaseCourseExamRela.QuestionName] == DBNull.Value ? null : objRow[convCaseCourseExamRela.QuestionName].ToString().Trim(), //题目名称
QuestionNo = objRow[convCaseCourseExamRela.QuestionNo] == DBNull.Value ? null : objRow[convCaseCourseExamRela.QuestionNo].ToString().Trim() //题目编号
};
objvCaseCourseExamRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvCaseCourseExamRelaEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvCaseCourseExamRelaDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvCaseCourseExamRelaEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvCaseCourseExamRelaEN objvCaseCourseExamRelaEN = new clsvCaseCourseExamRelaEN();
try
{
objvCaseCourseExamRelaEN.IdCaseCourseExamRela = TransNullToInt(objRow[convCaseCourseExamRela.IdCaseCourseExamRela].ToString().Trim()); //案例题库关系流水号
objvCaseCourseExamRelaEN.FuncModuleId = objRow[convCaseCourseExamRela.FuncModuleId].ToString().Trim(); //功能模块Id
objvCaseCourseExamRelaEN.FuncModuleName = objRow[convCaseCourseExamRela.FuncModuleName].ToString().Trim(); //功能模块名称
objvCaseCourseExamRelaEN.CaseId = objRow[convCaseCourseExamRela.CaseId] == DBNull.Value ? null : objRow[convCaseCourseExamRela.CaseId].ToString().Trim(); //案例Id
objvCaseCourseExamRelaEN.CaseName = objRow[convCaseCourseExamRela.CaseName] == DBNull.Value ? null : objRow[convCaseCourseExamRela.CaseName].ToString().Trim(); //案例名称
objvCaseCourseExamRelaEN.OwnerId = objRow[convCaseCourseExamRela.OwnerId].ToString().Trim(); //拥有者Id
objvCaseCourseExamRelaEN.OwnerName = objRow[convCaseCourseExamRela.OwnerName] == DBNull.Value ? null : objRow[convCaseCourseExamRela.OwnerName].ToString().Trim(); //拥有者姓名
objvCaseCourseExamRelaEN.QuestionID = objRow[convCaseCourseExamRela.QuestionID] == DBNull.Value ? null : objRow[convCaseCourseExamRela.QuestionID].ToString().Trim(); //题目ID
objvCaseCourseExamRelaEN.ExamAnswer = objRow[convCaseCourseExamRela.ExamAnswer] == DBNull.Value ? null : objRow[convCaseCourseExamRela.ExamAnswer].ToString().Trim(); //题目答案
objvCaseCourseExamRelaEN.StartTime = objRow[convCaseCourseExamRela.StartTime] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[convCaseCourseExamRela.StartTime].ToString().Trim()); //开始时间(s)
objvCaseCourseExamRelaEN.ParentNodeID = objRow[convCaseCourseExamRela.ParentNodeID] == DBNull.Value ? null : objRow[convCaseCourseExamRela.ParentNodeID].ToString().Trim(); //父节点编号
objvCaseCourseExamRelaEN.ParentNodeName = objRow[convCaseCourseExamRela.ParentNodeName] == DBNull.Value ? null : objRow[convCaseCourseExamRela.ParentNodeName].ToString().Trim(); //父节点名称
objvCaseCourseExamRelaEN.CourseId = objRow[convCaseCourseExamRela.CourseId] == DBNull.Value ? null : objRow[convCaseCourseExamRela.CourseId].ToString().Trim(); //课程Id
objvCaseCourseExamRelaEN.CourseName = objRow[convCaseCourseExamRela.CourseName] == DBNull.Value ? null : objRow[convCaseCourseExamRela.CourseName].ToString().Trim(); //课程名称
objvCaseCourseExamRelaEN.IdCaseCourseExamRelaType = objRow[convCaseCourseExamRela.IdCaseCourseExamRelaType].ToString().Trim(); //案例题库关系类型流水号
objvCaseCourseExamRelaEN.CaseCourseExamRelaTypeName = objRow[convCaseCourseExamRela.CaseCourseExamRelaTypeName].ToString().Trim(); //案例题库关系类型名称
objvCaseCourseExamRelaEN.BrowseCount = objRow[convCaseCourseExamRela.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCaseCourseExamRela.BrowseCount].ToString().Trim()); //浏览次数
objvCaseCourseExamRelaEN.OrderNum = objRow[convCaseCourseExamRela.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCaseCourseExamRela.OrderNum].ToString().Trim()); //序号
objvCaseCourseExamRelaEN.UpdDate = objRow[convCaseCourseExamRela.UpdDate] == DBNull.Value ? null : objRow[convCaseCourseExamRela.UpdDate].ToString().Trim(); //修改日期
objvCaseCourseExamRelaEN.UpdUserId = objRow[convCaseCourseExamRela.UpdUserId] == DBNull.Value ? null : objRow[convCaseCourseExamRela.UpdUserId].ToString().Trim(); //修改用户Id
objvCaseCourseExamRelaEN.Memo = objRow[convCaseCourseExamRela.Memo] == DBNull.Value ? null : objRow[convCaseCourseExamRela.Memo].ToString().Trim(); //备注
objvCaseCourseExamRelaEN.QuestionContent = objRow[convCaseCourseExamRela.QuestionContent] == DBNull.Value ? null : objRow[convCaseCourseExamRela.QuestionContent].ToString().Trim(); //题目内容
objvCaseCourseExamRelaEN.QuestionName = objRow[convCaseCourseExamRela.QuestionName] == DBNull.Value ? null : objRow[convCaseCourseExamRela.QuestionName].ToString().Trim(); //题目名称
objvCaseCourseExamRelaEN.QuestionNo = objRow[convCaseCourseExamRela.QuestionNo] == DBNull.Value ? null : objRow[convCaseCourseExamRela.QuestionNo].ToString().Trim(); //题目编号
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvCaseCourseExamRelaDA: GetObjByDataRowvCaseCourseExamRela)", objException.Message));
}
objvCaseCourseExamRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvCaseCourseExamRelaEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvCaseCourseExamRelaEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvCaseCourseExamRelaEN objvCaseCourseExamRelaEN = new clsvCaseCourseExamRelaEN();
try
{
objvCaseCourseExamRelaEN.IdCaseCourseExamRela = TransNullToInt(objRow[convCaseCourseExamRela.IdCaseCourseExamRela].ToString().Trim()); //案例题库关系流水号
objvCaseCourseExamRelaEN.FuncModuleId = objRow[convCaseCourseExamRela.FuncModuleId].ToString().Trim(); //功能模块Id
objvCaseCourseExamRelaEN.FuncModuleName = objRow[convCaseCourseExamRela.FuncModuleName].ToString().Trim(); //功能模块名称
objvCaseCourseExamRelaEN.CaseId = objRow[convCaseCourseExamRela.CaseId] == DBNull.Value ? null : objRow[convCaseCourseExamRela.CaseId].ToString().Trim(); //案例Id
objvCaseCourseExamRelaEN.CaseName = objRow[convCaseCourseExamRela.CaseName] == DBNull.Value ? null : objRow[convCaseCourseExamRela.CaseName].ToString().Trim(); //案例名称
objvCaseCourseExamRelaEN.OwnerId = objRow[convCaseCourseExamRela.OwnerId].ToString().Trim(); //拥有者Id
objvCaseCourseExamRelaEN.OwnerName = objRow[convCaseCourseExamRela.OwnerName] == DBNull.Value ? null : objRow[convCaseCourseExamRela.OwnerName].ToString().Trim(); //拥有者姓名
objvCaseCourseExamRelaEN.QuestionID = objRow[convCaseCourseExamRela.QuestionID] == DBNull.Value ? null : objRow[convCaseCourseExamRela.QuestionID].ToString().Trim(); //题目ID
objvCaseCourseExamRelaEN.ExamAnswer = objRow[convCaseCourseExamRela.ExamAnswer] == DBNull.Value ? null : objRow[convCaseCourseExamRela.ExamAnswer].ToString().Trim(); //题目答案
objvCaseCourseExamRelaEN.StartTime = objRow[convCaseCourseExamRela.StartTime] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[convCaseCourseExamRela.StartTime].ToString().Trim()); //开始时间(s)
objvCaseCourseExamRelaEN.ParentNodeID = objRow[convCaseCourseExamRela.ParentNodeID] == DBNull.Value ? null : objRow[convCaseCourseExamRela.ParentNodeID].ToString().Trim(); //父节点编号
objvCaseCourseExamRelaEN.ParentNodeName = objRow[convCaseCourseExamRela.ParentNodeName] == DBNull.Value ? null : objRow[convCaseCourseExamRela.ParentNodeName].ToString().Trim(); //父节点名称
objvCaseCourseExamRelaEN.CourseId = objRow[convCaseCourseExamRela.CourseId] == DBNull.Value ? null : objRow[convCaseCourseExamRela.CourseId].ToString().Trim(); //课程Id
objvCaseCourseExamRelaEN.CourseName = objRow[convCaseCourseExamRela.CourseName] == DBNull.Value ? null : objRow[convCaseCourseExamRela.CourseName].ToString().Trim(); //课程名称
objvCaseCourseExamRelaEN.IdCaseCourseExamRelaType = objRow[convCaseCourseExamRela.IdCaseCourseExamRelaType].ToString().Trim(); //案例题库关系类型流水号
objvCaseCourseExamRelaEN.CaseCourseExamRelaTypeName = objRow[convCaseCourseExamRela.CaseCourseExamRelaTypeName].ToString().Trim(); //案例题库关系类型名称
objvCaseCourseExamRelaEN.BrowseCount = objRow[convCaseCourseExamRela.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCaseCourseExamRela.BrowseCount].ToString().Trim()); //浏览次数
objvCaseCourseExamRelaEN.OrderNum = objRow[convCaseCourseExamRela.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCaseCourseExamRela.OrderNum].ToString().Trim()); //序号
objvCaseCourseExamRelaEN.UpdDate = objRow[convCaseCourseExamRela.UpdDate] == DBNull.Value ? null : objRow[convCaseCourseExamRela.UpdDate].ToString().Trim(); //修改日期
objvCaseCourseExamRelaEN.UpdUserId = objRow[convCaseCourseExamRela.UpdUserId] == DBNull.Value ? null : objRow[convCaseCourseExamRela.UpdUserId].ToString().Trim(); //修改用户Id
objvCaseCourseExamRelaEN.Memo = objRow[convCaseCourseExamRela.Memo] == DBNull.Value ? null : objRow[convCaseCourseExamRela.Memo].ToString().Trim(); //备注
objvCaseCourseExamRelaEN.QuestionContent = objRow[convCaseCourseExamRela.QuestionContent] == DBNull.Value ? null : objRow[convCaseCourseExamRela.QuestionContent].ToString().Trim(); //题目内容
objvCaseCourseExamRelaEN.QuestionName = objRow[convCaseCourseExamRela.QuestionName] == DBNull.Value ? null : objRow[convCaseCourseExamRela.QuestionName].ToString().Trim(); //题目名称
objvCaseCourseExamRelaEN.QuestionNo = objRow[convCaseCourseExamRela.QuestionNo] == DBNull.Value ? null : objRow[convCaseCourseExamRela.QuestionNo].ToString().Trim(); //题目编号
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvCaseCourseExamRelaDA: GetObjByDataRow)", objException.Message));
}
objvCaseCourseExamRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvCaseCourseExamRelaEN;
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
objSQL = clsvCaseCourseExamRelaDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvCaseCourseExamRelaEN._CurrTabName, convCaseCourseExamRela.IdCaseCourseExamRela, 8, "");
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
objSQL = clsvCaseCourseExamRelaDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvCaseCourseExamRelaEN._CurrTabName, convCaseCourseExamRela.IdCaseCourseExamRela, 8, strPrefix);
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
 objSQL = clsvCaseCourseExamRelaDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select IdCaseCourseExamRela from vCaseCourseExamRela where " + strCondition;
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
 objSQL = clsvCaseCourseExamRelaDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select IdCaseCourseExamRela from vCaseCourseExamRela where " + strCondition;
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
 objSQL = clsvCaseCourseExamRelaDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vCaseCourseExamRela", "IdCaseCourseExamRela = " + ""+ lngIdCaseCourseExamRela+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvCaseCourseExamRelaDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCaseCourseExamRelaDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vCaseCourseExamRela", strCondition))
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
objSQL = clsvCaseCourseExamRelaDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vCaseCourseExamRela");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvCaseCourseExamRelaENS">源对象</param>
 /// <param name = "objvCaseCourseExamRelaENT">目标对象</param>
public void CopyTo(clsvCaseCourseExamRelaEN objvCaseCourseExamRelaENS, clsvCaseCourseExamRelaEN objvCaseCourseExamRelaENT)
{
objvCaseCourseExamRelaENT.IdCaseCourseExamRela = objvCaseCourseExamRelaENS.IdCaseCourseExamRela; //案例题库关系流水号
objvCaseCourseExamRelaENT.FuncModuleId = objvCaseCourseExamRelaENS.FuncModuleId; //功能模块Id
objvCaseCourseExamRelaENT.FuncModuleName = objvCaseCourseExamRelaENS.FuncModuleName; //功能模块名称
objvCaseCourseExamRelaENT.CaseId = objvCaseCourseExamRelaENS.CaseId; //案例Id
objvCaseCourseExamRelaENT.CaseName = objvCaseCourseExamRelaENS.CaseName; //案例名称
objvCaseCourseExamRelaENT.OwnerId = objvCaseCourseExamRelaENS.OwnerId; //拥有者Id
objvCaseCourseExamRelaENT.OwnerName = objvCaseCourseExamRelaENS.OwnerName; //拥有者姓名
objvCaseCourseExamRelaENT.QuestionID = objvCaseCourseExamRelaENS.QuestionID; //题目ID
objvCaseCourseExamRelaENT.ExamAnswer = objvCaseCourseExamRelaENS.ExamAnswer; //题目答案
objvCaseCourseExamRelaENT.StartTime = objvCaseCourseExamRelaENS.StartTime; //开始时间(s)
objvCaseCourseExamRelaENT.ParentNodeID = objvCaseCourseExamRelaENS.ParentNodeID; //父节点编号
objvCaseCourseExamRelaENT.ParentNodeName = objvCaseCourseExamRelaENS.ParentNodeName; //父节点名称
objvCaseCourseExamRelaENT.CourseId = objvCaseCourseExamRelaENS.CourseId; //课程Id
objvCaseCourseExamRelaENT.CourseName = objvCaseCourseExamRelaENS.CourseName; //课程名称
objvCaseCourseExamRelaENT.IdCaseCourseExamRelaType = objvCaseCourseExamRelaENS.IdCaseCourseExamRelaType; //案例题库关系类型流水号
objvCaseCourseExamRelaENT.CaseCourseExamRelaTypeName = objvCaseCourseExamRelaENS.CaseCourseExamRelaTypeName; //案例题库关系类型名称
objvCaseCourseExamRelaENT.BrowseCount = objvCaseCourseExamRelaENS.BrowseCount; //浏览次数
objvCaseCourseExamRelaENT.OrderNum = objvCaseCourseExamRelaENS.OrderNum; //序号
objvCaseCourseExamRelaENT.UpdDate = objvCaseCourseExamRelaENS.UpdDate; //修改日期
objvCaseCourseExamRelaENT.UpdUserId = objvCaseCourseExamRelaENS.UpdUserId; //修改用户Id
objvCaseCourseExamRelaENT.Memo = objvCaseCourseExamRelaENS.Memo; //备注
objvCaseCourseExamRelaENT.QuestionContent = objvCaseCourseExamRelaENS.QuestionContent; //题目内容
objvCaseCourseExamRelaENT.QuestionName = objvCaseCourseExamRelaENS.QuestionName; //题目名称
objvCaseCourseExamRelaENT.QuestionNo = objvCaseCourseExamRelaENS.QuestionNo; //题目编号
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvCaseCourseExamRelaEN objvCaseCourseExamRelaEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvCaseCourseExamRelaEN.FuncModuleId, 4, convCaseCourseExamRela.FuncModuleId);
clsCheckSql.CheckFieldLen(objvCaseCourseExamRelaEN.FuncModuleName, 30, convCaseCourseExamRela.FuncModuleName);
clsCheckSql.CheckFieldLen(objvCaseCourseExamRelaEN.CaseId, 8, convCaseCourseExamRela.CaseId);
clsCheckSql.CheckFieldLen(objvCaseCourseExamRelaEN.CaseName, 100, convCaseCourseExamRela.CaseName);
clsCheckSql.CheckFieldLen(objvCaseCourseExamRelaEN.OwnerId, 20, convCaseCourseExamRela.OwnerId);
clsCheckSql.CheckFieldLen(objvCaseCourseExamRelaEN.OwnerName, 30, convCaseCourseExamRela.OwnerName);
clsCheckSql.CheckFieldLen(objvCaseCourseExamRelaEN.QuestionID, 8, convCaseCourseExamRela.QuestionID);
clsCheckSql.CheckFieldLen(objvCaseCourseExamRelaEN.ExamAnswer, 8000, convCaseCourseExamRela.ExamAnswer);
clsCheckSql.CheckFieldLen(objvCaseCourseExamRelaEN.ParentNodeID, 8, convCaseCourseExamRela.ParentNodeID);
clsCheckSql.CheckFieldLen(objvCaseCourseExamRelaEN.ParentNodeName, 50, convCaseCourseExamRela.ParentNodeName);
clsCheckSql.CheckFieldLen(objvCaseCourseExamRelaEN.CourseId, 8, convCaseCourseExamRela.CourseId);
clsCheckSql.CheckFieldLen(objvCaseCourseExamRelaEN.CourseName, 100, convCaseCourseExamRela.CourseName);
clsCheckSql.CheckFieldLen(objvCaseCourseExamRelaEN.IdCaseCourseExamRelaType, 4, convCaseCourseExamRela.IdCaseCourseExamRelaType);
clsCheckSql.CheckFieldLen(objvCaseCourseExamRelaEN.CaseCourseExamRelaTypeName, 50, convCaseCourseExamRela.CaseCourseExamRelaTypeName);
clsCheckSql.CheckFieldLen(objvCaseCourseExamRelaEN.UpdDate, 20, convCaseCourseExamRela.UpdDate);
clsCheckSql.CheckFieldLen(objvCaseCourseExamRelaEN.UpdUserId, 20, convCaseCourseExamRela.UpdUserId);
clsCheckSql.CheckFieldLen(objvCaseCourseExamRelaEN.Memo, 1000, convCaseCourseExamRela.Memo);
clsCheckSql.CheckFieldLen(objvCaseCourseExamRelaEN.QuestionContent, 4000, convCaseCourseExamRela.QuestionContent);
clsCheckSql.CheckFieldLen(objvCaseCourseExamRelaEN.QuestionName, 500, convCaseCourseExamRela.QuestionName);
clsCheckSql.CheckFieldLen(objvCaseCourseExamRelaEN.QuestionNo, 10, convCaseCourseExamRela.QuestionNo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvCaseCourseExamRelaEN.FuncModuleId, convCaseCourseExamRela.FuncModuleId);
clsCheckSql.CheckSqlInjection4Field(objvCaseCourseExamRelaEN.FuncModuleName, convCaseCourseExamRela.FuncModuleName);
clsCheckSql.CheckSqlInjection4Field(objvCaseCourseExamRelaEN.CaseId, convCaseCourseExamRela.CaseId);
clsCheckSql.CheckSqlInjection4Field(objvCaseCourseExamRelaEN.CaseName, convCaseCourseExamRela.CaseName);
clsCheckSql.CheckSqlInjection4Field(objvCaseCourseExamRelaEN.OwnerId, convCaseCourseExamRela.OwnerId);
clsCheckSql.CheckSqlInjection4Field(objvCaseCourseExamRelaEN.OwnerName, convCaseCourseExamRela.OwnerName);
clsCheckSql.CheckSqlInjection4Field(objvCaseCourseExamRelaEN.QuestionID, convCaseCourseExamRela.QuestionID);
clsCheckSql.CheckSqlInjection4Field(objvCaseCourseExamRelaEN.ExamAnswer, convCaseCourseExamRela.ExamAnswer);
clsCheckSql.CheckSqlInjection4Field(objvCaseCourseExamRelaEN.ParentNodeID, convCaseCourseExamRela.ParentNodeID);
clsCheckSql.CheckSqlInjection4Field(objvCaseCourseExamRelaEN.ParentNodeName, convCaseCourseExamRela.ParentNodeName);
clsCheckSql.CheckSqlInjection4Field(objvCaseCourseExamRelaEN.CourseId, convCaseCourseExamRela.CourseId);
clsCheckSql.CheckSqlInjection4Field(objvCaseCourseExamRelaEN.CourseName, convCaseCourseExamRela.CourseName);
clsCheckSql.CheckSqlInjection4Field(objvCaseCourseExamRelaEN.IdCaseCourseExamRelaType, convCaseCourseExamRela.IdCaseCourseExamRelaType);
clsCheckSql.CheckSqlInjection4Field(objvCaseCourseExamRelaEN.CaseCourseExamRelaTypeName, convCaseCourseExamRela.CaseCourseExamRelaTypeName);
clsCheckSql.CheckSqlInjection4Field(objvCaseCourseExamRelaEN.UpdDate, convCaseCourseExamRela.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objvCaseCourseExamRelaEN.UpdUserId, convCaseCourseExamRela.UpdUserId);
clsCheckSql.CheckSqlInjection4Field(objvCaseCourseExamRelaEN.Memo, convCaseCourseExamRela.Memo);
clsCheckSql.CheckSqlInjection4Field(objvCaseCourseExamRelaEN.QuestionContent, convCaseCourseExamRela.QuestionContent);
clsCheckSql.CheckSqlInjection4Field(objvCaseCourseExamRelaEN.QuestionName, convCaseCourseExamRela.QuestionName);
clsCheckSql.CheckSqlInjection4Field(objvCaseCourseExamRelaEN.QuestionNo, convCaseCourseExamRela.QuestionNo);
//检查外键字段长度
 objvCaseCourseExamRelaEN._IsCheckProperty = true;
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
 objSQL = clsvCaseCourseExamRelaDA.GetSpecSQLObj();
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
 objSQL = clsvCaseCourseExamRelaDA.GetSpecSQLObj();
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
 objSQL = clsvCaseCourseExamRelaDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvCaseCourseExamRelaEN._CurrTabName);
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
 objSQL = clsvCaseCourseExamRelaDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvCaseCourseExamRelaEN._CurrTabName, strCondition);
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
 objSQL = clsvCaseCourseExamRelaDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}