
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvWritingOnBBCase_Resource_RelDA
 表名:vWritingOnBBCase_Resource_Rel(01120423)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:51:10
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:板书点播(WritingOnBlackboard)
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
 /// vWritingOnBBCase_Resource_Rel(vWritingOnBBCase_Resource_Rel)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvWritingOnBBCase_Resource_RelDA : clsCommBase4DA
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
 return clsvWritingOnBBCase_Resource_RelEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvWritingOnBBCase_Resource_RelEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvWritingOnBBCase_Resource_RelEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvWritingOnBBCase_Resource_RelEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvWritingOnBBCase_Resource_RelEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvWritingOnBBCase_Resource_RelDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvWritingOnBBCase_Resource_RelDA.GetSpecSQLObj();
strSQL = "Select * from vWritingOnBBCase_Resource_Rel where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vWritingOnBBCase_Resource_Rel(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvWritingOnBBCase_Resource_RelDA: GetDataTable_vWritingOnBBCase_Resource_Rel)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvWritingOnBBCase_Resource_RelDA.GetSpecSQLObj();
strSQL = "Select * from vWritingOnBBCase_Resource_Rel where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvWritingOnBBCase_Resource_RelDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvWritingOnBBCase_Resource_RelDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvWritingOnBBCase_Resource_RelDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvWritingOnBBCase_Resource_RelDA.GetSpecSQLObj();
strSQL = "Select * from vWritingOnBBCase_Resource_Rel where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvWritingOnBBCase_Resource_RelDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvWritingOnBBCase_Resource_RelDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvWritingOnBBCase_Resource_RelDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvWritingOnBBCase_Resource_RelDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vWritingOnBBCase_Resource_Rel where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vWritingOnBBCase_Resource_Rel where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvWritingOnBBCase_Resource_RelDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvWritingOnBBCase_Resource_RelDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vWritingOnBBCase_Resource_Rel where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvWritingOnBBCase_Resource_RelDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvWritingOnBBCase_Resource_RelDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vWritingOnBBCase_Resource_Rel.* from vWritingOnBBCase_Resource_Rel Left Join {1} on {2} where {3} and vWritingOnBBCase_Resource_Rel.IdMicroteachCaseResourceRel not in (Select top {5} vWritingOnBBCase_Resource_Rel.IdMicroteachCaseResourceRel from vWritingOnBBCase_Resource_Rel Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vWritingOnBBCase_Resource_Rel where {1} and IdMicroteachCaseResourceRel not in (Select top {2} IdMicroteachCaseResourceRel from vWritingOnBBCase_Resource_Rel where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vWritingOnBBCase_Resource_Rel where {1} and IdMicroteachCaseResourceRel not in (Select top {3} IdMicroteachCaseResourceRel from vWritingOnBBCase_Resource_Rel where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvWritingOnBBCase_Resource_RelDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvWritingOnBBCase_Resource_RelDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vWritingOnBBCase_Resource_Rel.* from vWritingOnBBCase_Resource_Rel Left Join {1} on {2} where {3} and vWritingOnBBCase_Resource_Rel.IdMicroteachCaseResourceRel not in (Select top {5} vWritingOnBBCase_Resource_Rel.IdMicroteachCaseResourceRel from vWritingOnBBCase_Resource_Rel Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vWritingOnBBCase_Resource_Rel where {1} and IdMicroteachCaseResourceRel not in (Select top {2} IdMicroteachCaseResourceRel from vWritingOnBBCase_Resource_Rel where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vWritingOnBBCase_Resource_Rel where {1} and IdMicroteachCaseResourceRel not in (Select top {3} IdMicroteachCaseResourceRel from vWritingOnBBCase_Resource_Rel where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvWritingOnBBCase_Resource_RelEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvWritingOnBBCase_Resource_RelDA:GetObjLst)", objException.Message));
}
List<clsvWritingOnBBCase_Resource_RelEN> arrObjLst = new List<clsvWritingOnBBCase_Resource_RelEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvWritingOnBBCase_Resource_RelDA.GetSpecSQLObj();
strSQL = "Select * from vWritingOnBBCase_Resource_Rel where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvWritingOnBBCase_Resource_RelEN objvWritingOnBBCase_Resource_RelEN = new clsvWritingOnBBCase_Resource_RelEN();
try
{
objvWritingOnBBCase_Resource_RelEN.IdMicroteachCaseResourceRel = TransNullToInt(objRow[convWritingOnBBCase_Resource_Rel.IdMicroteachCaseResourceRel].ToString().Trim()); //微格案例资源关系流水号
objvWritingOnBBCase_Resource_RelEN.FuncModuleId = objRow[convWritingOnBBCase_Resource_Rel.FuncModuleId].ToString().Trim(); //功能模块Id
objvWritingOnBBCase_Resource_RelEN.FuncModuleName = objRow[convWritingOnBBCase_Resource_Rel.FuncModuleName] == DBNull.Value ? null : objRow[convWritingOnBBCase_Resource_Rel.FuncModuleName].ToString().Trim(); //功能模块名称
objvWritingOnBBCase_Resource_RelEN.IdMicroteachCase = objRow[convWritingOnBBCase_Resource_Rel.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvWritingOnBBCase_Resource_RelEN.IdWritingOnBBCase = objRow[convWritingOnBBCase_Resource_Rel.IdWritingOnBBCase].ToString().Trim(); //板书案例流水号
objvWritingOnBBCase_Resource_RelEN.WritingOnBBCaseID = objRow[convWritingOnBBCase_Resource_Rel.WritingOnBBCaseID].ToString().Trim(); //板书教学案例ID
objvWritingOnBBCase_Resource_RelEN.WritingOnBBCaseName = objRow[convWritingOnBBCase_Resource_Rel.WritingOnBBCaseName].ToString().Trim(); //板书教学案例名称
objvWritingOnBBCase_Resource_RelEN.WritingOnBBCaseTheme = objRow[convWritingOnBBCase_Resource_Rel.WritingOnBBCaseTheme] == DBNull.Value ? null : objRow[convWritingOnBBCase_Resource_Rel.WritingOnBBCaseTheme].ToString().Trim(); //板书教学案例主题词
objvWritingOnBBCase_Resource_RelEN.IdDiscipline = objRow[convWritingOnBBCase_Resource_Rel.IdDiscipline].ToString().Trim(); //学科流水号
objvWritingOnBBCase_Resource_RelEN.DisciplineID = objRow[convWritingOnBBCase_Resource_Rel.DisciplineID].ToString().Trim(); //学科ID
objvWritingOnBBCase_Resource_RelEN.DisciplineName = objRow[convWritingOnBBCase_Resource_Rel.DisciplineName].ToString().Trim(); //学科名称
objvWritingOnBBCase_Resource_RelEN.WritingOnBBCaseDate = objRow[convWritingOnBBCase_Resource_Rel.WritingOnBBCaseDate] == DBNull.Value ? null : objRow[convWritingOnBBCase_Resource_Rel.WritingOnBBCaseDate].ToString().Trim(); //板书教学日期
objvWritingOnBBCase_Resource_RelEN.WritingOnBBCaseTime = objRow[convWritingOnBBCase_Resource_Rel.WritingOnBBCaseTime] == DBNull.Value ? null : objRow[convWritingOnBBCase_Resource_Rel.WritingOnBBCaseTime].ToString().Trim(); //板书教学时间
objvWritingOnBBCase_Resource_RelEN.WritingOnBBCaseDateIn = objRow[convWritingOnBBCase_Resource_Rel.WritingOnBBCaseDateIn] == DBNull.Value ? null : objRow[convWritingOnBBCase_Resource_Rel.WritingOnBBCaseDateIn].ToString().Trim(); //案例入库日期
objvWritingOnBBCase_Resource_RelEN.WritingOnBBCaseTimeIn = objRow[convWritingOnBBCase_Resource_Rel.WritingOnBBCaseTimeIn] == DBNull.Value ? null : objRow[convWritingOnBBCase_Resource_Rel.WritingOnBBCaseTimeIn].ToString().Trim(); //案例入库时间
objvWritingOnBBCase_Resource_RelEN.IdStudyLevel = objRow[convWritingOnBBCase_Resource_Rel.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvWritingOnBBCase_Resource_RelEN.StudyLevelName = objRow[convWritingOnBBCase_Resource_Rel.StudyLevelName].ToString().Trim(); //学段名称
objvWritingOnBBCase_Resource_RelEN.CaseLevelId = objRow[convWritingOnBBCase_Resource_Rel.CaseLevelId] == DBNull.Value ? null : objRow[convWritingOnBBCase_Resource_Rel.CaseLevelId].ToString().Trim(); //课例等级Id
objvWritingOnBBCase_Resource_RelEN.senateGaugeVersionID = objRow[convWritingOnBBCase_Resource_Rel.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvWritingOnBBCase_Resource_RelEN.senateGaugeVersionName = objRow[convWritingOnBBCase_Resource_Rel.senateGaugeVersionName] == DBNull.Value ? null : objRow[convWritingOnBBCase_Resource_Rel.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvWritingOnBBCase_Resource_RelEN.senateGaugeVersionTtlScore = TransNullToFloat(objRow[convWritingOnBBCase_Resource_Rel.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvWritingOnBBCase_Resource_RelEN.VersionNo = objRow[convWritingOnBBCase_Resource_Rel.VersionNo] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convWritingOnBBCase_Resource_Rel.VersionNo].ToString().Trim()); //版本号
objvWritingOnBBCase_Resource_RelEN.OwnerId = objRow[convWritingOnBBCase_Resource_Rel.OwnerId] == DBNull.Value ? null : objRow[convWritingOnBBCase_Resource_Rel.OwnerId].ToString().Trim(); //拥有者Id
objvWritingOnBBCase_Resource_RelEN.StuName = objRow[convWritingOnBBCase_Resource_Rel.StuName].ToString().Trim(); //姓名
objvWritingOnBBCase_Resource_RelEN.StuID = objRow[convWritingOnBBCase_Resource_Rel.StuID].ToString().Trim(); //学号
objvWritingOnBBCase_Resource_RelEN.CollegeName = objRow[convWritingOnBBCase_Resource_Rel.CollegeName].ToString().Trim(); //学院名称
objvWritingOnBBCase_Resource_RelEN.IdXzCollege = objRow[convWritingOnBBCase_Resource_Rel.IdXzCollege] == DBNull.Value ? null : objRow[convWritingOnBBCase_Resource_Rel.IdXzCollege].ToString().Trim(); //学院流水号
objvWritingOnBBCase_Resource_RelEN.IdXzMajor = objRow[convWritingOnBBCase_Resource_Rel.IdXzMajor] == DBNull.Value ? null : objRow[convWritingOnBBCase_Resource_Rel.IdXzMajor].ToString().Trim(); //专业流水号
objvWritingOnBBCase_Resource_RelEN.IdGradeBase = objRow[convWritingOnBBCase_Resource_Rel.IdGradeBase] == DBNull.Value ? null : objRow[convWritingOnBBCase_Resource_Rel.IdGradeBase].ToString().Trim(); //年级流水号
objvWritingOnBBCase_Resource_RelEN.IdAdminCls = objRow[convWritingOnBBCase_Resource_Rel.IdAdminCls] == DBNull.Value ? null : objRow[convWritingOnBBCase_Resource_Rel.IdAdminCls].ToString().Trim(); //行政班流水号
objvWritingOnBBCase_Resource_RelEN.CollegeNameA = objRow[convWritingOnBBCase_Resource_Rel.CollegeNameA] == DBNull.Value ? null : objRow[convWritingOnBBCase_Resource_Rel.CollegeNameA].ToString().Trim(); //学院名称简写
objvWritingOnBBCase_Resource_RelEN.IsDualVideo = TransNullToBool(objRow[convWritingOnBBCase_Resource_Rel.IsDualVideo].ToString().Trim()); //是否双视频
objvWritingOnBBCase_Resource_RelEN.RecommendedDegreeId = objRow[convWritingOnBBCase_Resource_Rel.RecommendedDegreeId] == DBNull.Value ? null : objRow[convWritingOnBBCase_Resource_Rel.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvWritingOnBBCase_Resource_RelEN.RecommendedDegreeName = objRow[convWritingOnBBCase_Resource_Rel.RecommendedDegreeName] == DBNull.Value ? null : objRow[convWritingOnBBCase_Resource_Rel.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvWritingOnBBCase_Resource_RelEN.BrowseCount4Case = objRow[convWritingOnBBCase_Resource_Rel.BrowseCount4Case] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convWritingOnBBCase_Resource_Rel.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvWritingOnBBCase_Resource_RelEN.IdResource = objRow[convWritingOnBBCase_Resource_Rel.IdResource].ToString().Trim(); //资源流水号
objvWritingOnBBCase_Resource_RelEN.ResourceID = objRow[convWritingOnBBCase_Resource_Rel.ResourceID].ToString().Trim(); //资源ID
objvWritingOnBBCase_Resource_RelEN.IdFtpResource = objRow[convWritingOnBBCase_Resource_Rel.IdFtpResource] == DBNull.Value ? null : objRow[convWritingOnBBCase_Resource_Rel.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvWritingOnBBCase_Resource_RelEN.IdFile = objRow[convWritingOnBBCase_Resource_Rel.IdFile] == DBNull.Value ? null : objRow[convWritingOnBBCase_Resource_Rel.IdFile].ToString().Trim(); //文件流水号
objvWritingOnBBCase_Resource_RelEN.FileName = objRow[convWritingOnBBCase_Resource_Rel.FileName] == DBNull.Value ? null : objRow[convWritingOnBBCase_Resource_Rel.FileName].ToString().Trim(); //文件名称
objvWritingOnBBCase_Resource_RelEN.FileType = objRow[convWritingOnBBCase_Resource_Rel.FileType] == DBNull.Value ? null : objRow[convWritingOnBBCase_Resource_Rel.FileType].ToString().Trim(); //文件类型
objvWritingOnBBCase_Resource_RelEN.SaveDate = objRow[convWritingOnBBCase_Resource_Rel.SaveDate] == DBNull.Value ? null : objRow[convWritingOnBBCase_Resource_Rel.SaveDate].ToString().Trim(); //创建日期
objvWritingOnBBCase_Resource_RelEN.FileSize = objRow[convWritingOnBBCase_Resource_Rel.FileSize] == DBNull.Value ? null : objRow[convWritingOnBBCase_Resource_Rel.FileSize].ToString().Trim(); //文件大小
objvWritingOnBBCase_Resource_RelEN.SaveTime = objRow[convWritingOnBBCase_Resource_Rel.SaveTime] == DBNull.Value ? null : objRow[convWritingOnBBCase_Resource_Rel.SaveTime].ToString().Trim(); //创建时间
objvWritingOnBBCase_Resource_RelEN.FtpResourceID = objRow[convWritingOnBBCase_Resource_Rel.FtpResourceID].ToString().Trim(); //FTP资源ID
objvWritingOnBBCase_Resource_RelEN.FileOriginalName = objRow[convWritingOnBBCase_Resource_Rel.FileOriginalName] == DBNull.Value ? null : objRow[convWritingOnBBCase_Resource_Rel.FileOriginalName].ToString().Trim(); //文件原名
objvWritingOnBBCase_Resource_RelEN.FileDirName = objRow[convWritingOnBBCase_Resource_Rel.FileDirName] == DBNull.Value ? null : objRow[convWritingOnBBCase_Resource_Rel.FileDirName].ToString().Trim(); //文件目录名
objvWritingOnBBCase_Resource_RelEN.FileRename = objRow[convWritingOnBBCase_Resource_Rel.FileRename] == DBNull.Value ? null : objRow[convWritingOnBBCase_Resource_Rel.FileRename].ToString().Trim(); //文件新名
objvWritingOnBBCase_Resource_RelEN.FileUpDate = objRow[convWritingOnBBCase_Resource_Rel.FileUpDate] == DBNull.Value ? null : objRow[convWritingOnBBCase_Resource_Rel.FileUpDate].ToString().Trim(); //创建日期
objvWritingOnBBCase_Resource_RelEN.FileUpTime = objRow[convWritingOnBBCase_Resource_Rel.FileUpTime] == DBNull.Value ? null : objRow[convWritingOnBBCase_Resource_Rel.FileUpTime].ToString().Trim(); //创建时间
objvWritingOnBBCase_Resource_RelEN.SaveMode = TransNullToBool(objRow[convWritingOnBBCase_Resource_Rel.SaveMode].ToString().Trim()); //文件存放方式
objvWritingOnBBCase_Resource_RelEN.IdResourceType = objRow[convWritingOnBBCase_Resource_Rel.IdResourceType].ToString().Trim(); //资源类型流水号
objvWritingOnBBCase_Resource_RelEN.ResourceTypeID = objRow[convWritingOnBBCase_Resource_Rel.ResourceTypeID].ToString().Trim(); //资源类型ID
objvWritingOnBBCase_Resource_RelEN.ResourceTypeName = objRow[convWritingOnBBCase_Resource_Rel.ResourceTypeName].ToString().Trim(); //资源类型名称
objvWritingOnBBCase_Resource_RelEN.ResourceOwner = objRow[convWritingOnBBCase_Resource_Rel.ResourceOwner].ToString().Trim(); //上传者
objvWritingOnBBCase_Resource_RelEN.ftpFileType = objRow[convWritingOnBBCase_Resource_Rel.ftpFileType] == DBNull.Value ? null : objRow[convWritingOnBBCase_Resource_Rel.ftpFileType].ToString().Trim(); //ftp文件类型
objvWritingOnBBCase_Resource_RelEN.ftpFileSize = objRow[convWritingOnBBCase_Resource_Rel.ftpFileSize] == DBNull.Value ? null : objRow[convWritingOnBBCase_Resource_Rel.ftpFileSize].ToString().Trim(); //ftp文件大小
objvWritingOnBBCase_Resource_RelEN.ftpResourceOwner = objRow[convWritingOnBBCase_Resource_Rel.ftpResourceOwner] == DBNull.Value ? null : objRow[convWritingOnBBCase_Resource_Rel.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvWritingOnBBCase_Resource_RelEN.FileOriginName = objRow[convWritingOnBBCase_Resource_Rel.FileOriginName] == DBNull.Value ? null : objRow[convWritingOnBBCase_Resource_Rel.FileOriginName].ToString().Trim(); //原文件名
objvWritingOnBBCase_Resource_RelEN.IsExistFile = TransNullToBool(objRow[convWritingOnBBCase_Resource_Rel.IsExistFile].ToString().Trim()); //是否存在文件
objvWritingOnBBCase_Resource_RelEN.FileNewName = objRow[convWritingOnBBCase_Resource_Rel.FileNewName] == DBNull.Value ? null : objRow[convWritingOnBBCase_Resource_Rel.FileNewName].ToString().Trim(); //新文件名
objvWritingOnBBCase_Resource_RelEN.FileOldName = objRow[convWritingOnBBCase_Resource_Rel.FileOldName] == DBNull.Value ? null : objRow[convWritingOnBBCase_Resource_Rel.FileOldName].ToString().Trim(); //旧文件名
objvWritingOnBBCase_Resource_RelEN.IsMain = TransNullToBool(objRow[convWritingOnBBCase_Resource_Rel.IsMain].ToString().Trim()); //是否主资源
objvWritingOnBBCase_Resource_RelEN.IdUsingMode = objRow[convWritingOnBBCase_Resource_Rel.IdUsingMode].ToString().Trim(); //资源使用模式流水号
objvWritingOnBBCase_Resource_RelEN.IsVisible = TransNullToBool(objRow[convWritingOnBBCase_Resource_Rel.IsVisible].ToString().Trim()); //是否显示
objvWritingOnBBCase_Resource_RelEN.IndexNO = objRow[convWritingOnBBCase_Resource_Rel.IndexNO] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convWritingOnBBCase_Resource_Rel.IndexNO].ToString().Trim()); //序号
objvWritingOnBBCase_Resource_RelEN.BrowseCount = objRow[convWritingOnBBCase_Resource_Rel.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convWritingOnBBCase_Resource_Rel.BrowseCount].ToString().Trim()); //浏览次数
objvWritingOnBBCase_Resource_RelEN.UpdDate = objRow[convWritingOnBBCase_Resource_Rel.UpdDate] == DBNull.Value ? null : objRow[convWritingOnBBCase_Resource_Rel.UpdDate].ToString().Trim(); //修改日期
objvWritingOnBBCase_Resource_RelEN.UpdUser = objRow[convWritingOnBBCase_Resource_Rel.UpdUser] == DBNull.Value ? null : objRow[convWritingOnBBCase_Resource_Rel.UpdUser].ToString().Trim(); //修改人
objvWritingOnBBCase_Resource_RelEN.Memo = objRow[convWritingOnBBCase_Resource_Rel.Memo] == DBNull.Value ? null : objRow[convWritingOnBBCase_Resource_Rel.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvWritingOnBBCase_Resource_RelDA: GetObjLst)", objException.Message));
}
objvWritingOnBBCase_Resource_RelEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvWritingOnBBCase_Resource_RelEN);
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
public List<clsvWritingOnBBCase_Resource_RelEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvWritingOnBBCase_Resource_RelDA:GetObjLstByTabName)", objException.Message));
}
List<clsvWritingOnBBCase_Resource_RelEN> arrObjLst = new List<clsvWritingOnBBCase_Resource_RelEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvWritingOnBBCase_Resource_RelDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvWritingOnBBCase_Resource_RelEN objvWritingOnBBCase_Resource_RelEN = new clsvWritingOnBBCase_Resource_RelEN();
try
{
objvWritingOnBBCase_Resource_RelEN.IdMicroteachCaseResourceRel = TransNullToInt(objRow[convWritingOnBBCase_Resource_Rel.IdMicroteachCaseResourceRel].ToString().Trim()); //微格案例资源关系流水号
objvWritingOnBBCase_Resource_RelEN.FuncModuleId = objRow[convWritingOnBBCase_Resource_Rel.FuncModuleId].ToString().Trim(); //功能模块Id
objvWritingOnBBCase_Resource_RelEN.FuncModuleName = objRow[convWritingOnBBCase_Resource_Rel.FuncModuleName] == DBNull.Value ? null : objRow[convWritingOnBBCase_Resource_Rel.FuncModuleName].ToString().Trim(); //功能模块名称
objvWritingOnBBCase_Resource_RelEN.IdMicroteachCase = objRow[convWritingOnBBCase_Resource_Rel.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvWritingOnBBCase_Resource_RelEN.IdWritingOnBBCase = objRow[convWritingOnBBCase_Resource_Rel.IdWritingOnBBCase].ToString().Trim(); //板书案例流水号
objvWritingOnBBCase_Resource_RelEN.WritingOnBBCaseID = objRow[convWritingOnBBCase_Resource_Rel.WritingOnBBCaseID].ToString().Trim(); //板书教学案例ID
objvWritingOnBBCase_Resource_RelEN.WritingOnBBCaseName = objRow[convWritingOnBBCase_Resource_Rel.WritingOnBBCaseName].ToString().Trim(); //板书教学案例名称
objvWritingOnBBCase_Resource_RelEN.WritingOnBBCaseTheme = objRow[convWritingOnBBCase_Resource_Rel.WritingOnBBCaseTheme] == DBNull.Value ? null : objRow[convWritingOnBBCase_Resource_Rel.WritingOnBBCaseTheme].ToString().Trim(); //板书教学案例主题词
objvWritingOnBBCase_Resource_RelEN.IdDiscipline = objRow[convWritingOnBBCase_Resource_Rel.IdDiscipline].ToString().Trim(); //学科流水号
objvWritingOnBBCase_Resource_RelEN.DisciplineID = objRow[convWritingOnBBCase_Resource_Rel.DisciplineID].ToString().Trim(); //学科ID
objvWritingOnBBCase_Resource_RelEN.DisciplineName = objRow[convWritingOnBBCase_Resource_Rel.DisciplineName].ToString().Trim(); //学科名称
objvWritingOnBBCase_Resource_RelEN.WritingOnBBCaseDate = objRow[convWritingOnBBCase_Resource_Rel.WritingOnBBCaseDate] == DBNull.Value ? null : objRow[convWritingOnBBCase_Resource_Rel.WritingOnBBCaseDate].ToString().Trim(); //板书教学日期
objvWritingOnBBCase_Resource_RelEN.WritingOnBBCaseTime = objRow[convWritingOnBBCase_Resource_Rel.WritingOnBBCaseTime] == DBNull.Value ? null : objRow[convWritingOnBBCase_Resource_Rel.WritingOnBBCaseTime].ToString().Trim(); //板书教学时间
objvWritingOnBBCase_Resource_RelEN.WritingOnBBCaseDateIn = objRow[convWritingOnBBCase_Resource_Rel.WritingOnBBCaseDateIn] == DBNull.Value ? null : objRow[convWritingOnBBCase_Resource_Rel.WritingOnBBCaseDateIn].ToString().Trim(); //案例入库日期
objvWritingOnBBCase_Resource_RelEN.WritingOnBBCaseTimeIn = objRow[convWritingOnBBCase_Resource_Rel.WritingOnBBCaseTimeIn] == DBNull.Value ? null : objRow[convWritingOnBBCase_Resource_Rel.WritingOnBBCaseTimeIn].ToString().Trim(); //案例入库时间
objvWritingOnBBCase_Resource_RelEN.IdStudyLevel = objRow[convWritingOnBBCase_Resource_Rel.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvWritingOnBBCase_Resource_RelEN.StudyLevelName = objRow[convWritingOnBBCase_Resource_Rel.StudyLevelName].ToString().Trim(); //学段名称
objvWritingOnBBCase_Resource_RelEN.CaseLevelId = objRow[convWritingOnBBCase_Resource_Rel.CaseLevelId] == DBNull.Value ? null : objRow[convWritingOnBBCase_Resource_Rel.CaseLevelId].ToString().Trim(); //课例等级Id
objvWritingOnBBCase_Resource_RelEN.senateGaugeVersionID = objRow[convWritingOnBBCase_Resource_Rel.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvWritingOnBBCase_Resource_RelEN.senateGaugeVersionName = objRow[convWritingOnBBCase_Resource_Rel.senateGaugeVersionName] == DBNull.Value ? null : objRow[convWritingOnBBCase_Resource_Rel.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvWritingOnBBCase_Resource_RelEN.senateGaugeVersionTtlScore = TransNullToFloat(objRow[convWritingOnBBCase_Resource_Rel.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvWritingOnBBCase_Resource_RelEN.VersionNo = objRow[convWritingOnBBCase_Resource_Rel.VersionNo] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convWritingOnBBCase_Resource_Rel.VersionNo].ToString().Trim()); //版本号
objvWritingOnBBCase_Resource_RelEN.OwnerId = objRow[convWritingOnBBCase_Resource_Rel.OwnerId] == DBNull.Value ? null : objRow[convWritingOnBBCase_Resource_Rel.OwnerId].ToString().Trim(); //拥有者Id
objvWritingOnBBCase_Resource_RelEN.StuName = objRow[convWritingOnBBCase_Resource_Rel.StuName].ToString().Trim(); //姓名
objvWritingOnBBCase_Resource_RelEN.StuID = objRow[convWritingOnBBCase_Resource_Rel.StuID].ToString().Trim(); //学号
objvWritingOnBBCase_Resource_RelEN.CollegeName = objRow[convWritingOnBBCase_Resource_Rel.CollegeName].ToString().Trim(); //学院名称
objvWritingOnBBCase_Resource_RelEN.IdXzCollege = objRow[convWritingOnBBCase_Resource_Rel.IdXzCollege] == DBNull.Value ? null : objRow[convWritingOnBBCase_Resource_Rel.IdXzCollege].ToString().Trim(); //学院流水号
objvWritingOnBBCase_Resource_RelEN.IdXzMajor = objRow[convWritingOnBBCase_Resource_Rel.IdXzMajor] == DBNull.Value ? null : objRow[convWritingOnBBCase_Resource_Rel.IdXzMajor].ToString().Trim(); //专业流水号
objvWritingOnBBCase_Resource_RelEN.IdGradeBase = objRow[convWritingOnBBCase_Resource_Rel.IdGradeBase] == DBNull.Value ? null : objRow[convWritingOnBBCase_Resource_Rel.IdGradeBase].ToString().Trim(); //年级流水号
objvWritingOnBBCase_Resource_RelEN.IdAdminCls = objRow[convWritingOnBBCase_Resource_Rel.IdAdminCls] == DBNull.Value ? null : objRow[convWritingOnBBCase_Resource_Rel.IdAdminCls].ToString().Trim(); //行政班流水号
objvWritingOnBBCase_Resource_RelEN.CollegeNameA = objRow[convWritingOnBBCase_Resource_Rel.CollegeNameA] == DBNull.Value ? null : objRow[convWritingOnBBCase_Resource_Rel.CollegeNameA].ToString().Trim(); //学院名称简写
objvWritingOnBBCase_Resource_RelEN.IsDualVideo = TransNullToBool(objRow[convWritingOnBBCase_Resource_Rel.IsDualVideo].ToString().Trim()); //是否双视频
objvWritingOnBBCase_Resource_RelEN.RecommendedDegreeId = objRow[convWritingOnBBCase_Resource_Rel.RecommendedDegreeId] == DBNull.Value ? null : objRow[convWritingOnBBCase_Resource_Rel.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvWritingOnBBCase_Resource_RelEN.RecommendedDegreeName = objRow[convWritingOnBBCase_Resource_Rel.RecommendedDegreeName] == DBNull.Value ? null : objRow[convWritingOnBBCase_Resource_Rel.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvWritingOnBBCase_Resource_RelEN.BrowseCount4Case = objRow[convWritingOnBBCase_Resource_Rel.BrowseCount4Case] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convWritingOnBBCase_Resource_Rel.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvWritingOnBBCase_Resource_RelEN.IdResource = objRow[convWritingOnBBCase_Resource_Rel.IdResource].ToString().Trim(); //资源流水号
objvWritingOnBBCase_Resource_RelEN.ResourceID = objRow[convWritingOnBBCase_Resource_Rel.ResourceID].ToString().Trim(); //资源ID
objvWritingOnBBCase_Resource_RelEN.IdFtpResource = objRow[convWritingOnBBCase_Resource_Rel.IdFtpResource] == DBNull.Value ? null : objRow[convWritingOnBBCase_Resource_Rel.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvWritingOnBBCase_Resource_RelEN.IdFile = objRow[convWritingOnBBCase_Resource_Rel.IdFile] == DBNull.Value ? null : objRow[convWritingOnBBCase_Resource_Rel.IdFile].ToString().Trim(); //文件流水号
objvWritingOnBBCase_Resource_RelEN.FileName = objRow[convWritingOnBBCase_Resource_Rel.FileName] == DBNull.Value ? null : objRow[convWritingOnBBCase_Resource_Rel.FileName].ToString().Trim(); //文件名称
objvWritingOnBBCase_Resource_RelEN.FileType = objRow[convWritingOnBBCase_Resource_Rel.FileType] == DBNull.Value ? null : objRow[convWritingOnBBCase_Resource_Rel.FileType].ToString().Trim(); //文件类型
objvWritingOnBBCase_Resource_RelEN.SaveDate = objRow[convWritingOnBBCase_Resource_Rel.SaveDate] == DBNull.Value ? null : objRow[convWritingOnBBCase_Resource_Rel.SaveDate].ToString().Trim(); //创建日期
objvWritingOnBBCase_Resource_RelEN.FileSize = objRow[convWritingOnBBCase_Resource_Rel.FileSize] == DBNull.Value ? null : objRow[convWritingOnBBCase_Resource_Rel.FileSize].ToString().Trim(); //文件大小
objvWritingOnBBCase_Resource_RelEN.SaveTime = objRow[convWritingOnBBCase_Resource_Rel.SaveTime] == DBNull.Value ? null : objRow[convWritingOnBBCase_Resource_Rel.SaveTime].ToString().Trim(); //创建时间
objvWritingOnBBCase_Resource_RelEN.FtpResourceID = objRow[convWritingOnBBCase_Resource_Rel.FtpResourceID].ToString().Trim(); //FTP资源ID
objvWritingOnBBCase_Resource_RelEN.FileOriginalName = objRow[convWritingOnBBCase_Resource_Rel.FileOriginalName] == DBNull.Value ? null : objRow[convWritingOnBBCase_Resource_Rel.FileOriginalName].ToString().Trim(); //文件原名
objvWritingOnBBCase_Resource_RelEN.FileDirName = objRow[convWritingOnBBCase_Resource_Rel.FileDirName] == DBNull.Value ? null : objRow[convWritingOnBBCase_Resource_Rel.FileDirName].ToString().Trim(); //文件目录名
objvWritingOnBBCase_Resource_RelEN.FileRename = objRow[convWritingOnBBCase_Resource_Rel.FileRename] == DBNull.Value ? null : objRow[convWritingOnBBCase_Resource_Rel.FileRename].ToString().Trim(); //文件新名
objvWritingOnBBCase_Resource_RelEN.FileUpDate = objRow[convWritingOnBBCase_Resource_Rel.FileUpDate] == DBNull.Value ? null : objRow[convWritingOnBBCase_Resource_Rel.FileUpDate].ToString().Trim(); //创建日期
objvWritingOnBBCase_Resource_RelEN.FileUpTime = objRow[convWritingOnBBCase_Resource_Rel.FileUpTime] == DBNull.Value ? null : objRow[convWritingOnBBCase_Resource_Rel.FileUpTime].ToString().Trim(); //创建时间
objvWritingOnBBCase_Resource_RelEN.SaveMode = TransNullToBool(objRow[convWritingOnBBCase_Resource_Rel.SaveMode].ToString().Trim()); //文件存放方式
objvWritingOnBBCase_Resource_RelEN.IdResourceType = objRow[convWritingOnBBCase_Resource_Rel.IdResourceType].ToString().Trim(); //资源类型流水号
objvWritingOnBBCase_Resource_RelEN.ResourceTypeID = objRow[convWritingOnBBCase_Resource_Rel.ResourceTypeID].ToString().Trim(); //资源类型ID
objvWritingOnBBCase_Resource_RelEN.ResourceTypeName = objRow[convWritingOnBBCase_Resource_Rel.ResourceTypeName].ToString().Trim(); //资源类型名称
objvWritingOnBBCase_Resource_RelEN.ResourceOwner = objRow[convWritingOnBBCase_Resource_Rel.ResourceOwner].ToString().Trim(); //上传者
objvWritingOnBBCase_Resource_RelEN.ftpFileType = objRow[convWritingOnBBCase_Resource_Rel.ftpFileType] == DBNull.Value ? null : objRow[convWritingOnBBCase_Resource_Rel.ftpFileType].ToString().Trim(); //ftp文件类型
objvWritingOnBBCase_Resource_RelEN.ftpFileSize = objRow[convWritingOnBBCase_Resource_Rel.ftpFileSize] == DBNull.Value ? null : objRow[convWritingOnBBCase_Resource_Rel.ftpFileSize].ToString().Trim(); //ftp文件大小
objvWritingOnBBCase_Resource_RelEN.ftpResourceOwner = objRow[convWritingOnBBCase_Resource_Rel.ftpResourceOwner] == DBNull.Value ? null : objRow[convWritingOnBBCase_Resource_Rel.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvWritingOnBBCase_Resource_RelEN.FileOriginName = objRow[convWritingOnBBCase_Resource_Rel.FileOriginName] == DBNull.Value ? null : objRow[convWritingOnBBCase_Resource_Rel.FileOriginName].ToString().Trim(); //原文件名
objvWritingOnBBCase_Resource_RelEN.IsExistFile = TransNullToBool(objRow[convWritingOnBBCase_Resource_Rel.IsExistFile].ToString().Trim()); //是否存在文件
objvWritingOnBBCase_Resource_RelEN.FileNewName = objRow[convWritingOnBBCase_Resource_Rel.FileNewName] == DBNull.Value ? null : objRow[convWritingOnBBCase_Resource_Rel.FileNewName].ToString().Trim(); //新文件名
objvWritingOnBBCase_Resource_RelEN.FileOldName = objRow[convWritingOnBBCase_Resource_Rel.FileOldName] == DBNull.Value ? null : objRow[convWritingOnBBCase_Resource_Rel.FileOldName].ToString().Trim(); //旧文件名
objvWritingOnBBCase_Resource_RelEN.IsMain = TransNullToBool(objRow[convWritingOnBBCase_Resource_Rel.IsMain].ToString().Trim()); //是否主资源
objvWritingOnBBCase_Resource_RelEN.IdUsingMode = objRow[convWritingOnBBCase_Resource_Rel.IdUsingMode].ToString().Trim(); //资源使用模式流水号
objvWritingOnBBCase_Resource_RelEN.IsVisible = TransNullToBool(objRow[convWritingOnBBCase_Resource_Rel.IsVisible].ToString().Trim()); //是否显示
objvWritingOnBBCase_Resource_RelEN.IndexNO = objRow[convWritingOnBBCase_Resource_Rel.IndexNO] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convWritingOnBBCase_Resource_Rel.IndexNO].ToString().Trim()); //序号
objvWritingOnBBCase_Resource_RelEN.BrowseCount = objRow[convWritingOnBBCase_Resource_Rel.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convWritingOnBBCase_Resource_Rel.BrowseCount].ToString().Trim()); //浏览次数
objvWritingOnBBCase_Resource_RelEN.UpdDate = objRow[convWritingOnBBCase_Resource_Rel.UpdDate] == DBNull.Value ? null : objRow[convWritingOnBBCase_Resource_Rel.UpdDate].ToString().Trim(); //修改日期
objvWritingOnBBCase_Resource_RelEN.UpdUser = objRow[convWritingOnBBCase_Resource_Rel.UpdUser] == DBNull.Value ? null : objRow[convWritingOnBBCase_Resource_Rel.UpdUser].ToString().Trim(); //修改人
objvWritingOnBBCase_Resource_RelEN.Memo = objRow[convWritingOnBBCase_Resource_Rel.Memo] == DBNull.Value ? null : objRow[convWritingOnBBCase_Resource_Rel.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvWritingOnBBCase_Resource_RelDA: GetObjLst)", objException.Message));
}
objvWritingOnBBCase_Resource_RelEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvWritingOnBBCase_Resource_RelEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvWritingOnBBCase_Resource_RelEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvWritingOnBBCase_Resource_Rel(ref clsvWritingOnBBCase_Resource_RelEN objvWritingOnBBCase_Resource_RelEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvWritingOnBBCase_Resource_RelDA.GetSpecSQLObj();
strSQL = "Select * from vWritingOnBBCase_Resource_Rel where IdMicroteachCaseResourceRel = " + ""+ objvWritingOnBBCase_Resource_RelEN.IdMicroteachCaseResourceRel+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvWritingOnBBCase_Resource_RelEN.IdMicroteachCaseResourceRel = TransNullToInt(objDT.Rows[0][convWritingOnBBCase_Resource_Rel.IdMicroteachCaseResourceRel].ToString().Trim()); //微格案例资源关系流水号(字段类型:bigint,字段长度:8,是否可空:False)
 objvWritingOnBBCase_Resource_RelEN.FuncModuleId = objDT.Rows[0][convWritingOnBBCase_Resource_Rel.FuncModuleId].ToString().Trim(); //功能模块Id(字段类型:char,字段长度:4,是否可空:True)
 objvWritingOnBBCase_Resource_RelEN.FuncModuleName = objDT.Rows[0][convWritingOnBBCase_Resource_Rel.FuncModuleName].ToString().Trim(); //功能模块名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvWritingOnBBCase_Resource_RelEN.IdMicroteachCase = objDT.Rows[0][convWritingOnBBCase_Resource_Rel.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号(字段类型:char,字段长度:8,是否可空:False)
 objvWritingOnBBCase_Resource_RelEN.IdWritingOnBBCase = objDT.Rows[0][convWritingOnBBCase_Resource_Rel.IdWritingOnBBCase].ToString().Trim(); //板书案例流水号(字段类型:char,字段长度:8,是否可空:False)
 objvWritingOnBBCase_Resource_RelEN.WritingOnBBCaseID = objDT.Rows[0][convWritingOnBBCase_Resource_Rel.WritingOnBBCaseID].ToString().Trim(); //板书教学案例ID(字段类型:char,字段长度:8,是否可空:False)
 objvWritingOnBBCase_Resource_RelEN.WritingOnBBCaseName = objDT.Rows[0][convWritingOnBBCase_Resource_Rel.WritingOnBBCaseName].ToString().Trim(); //板书教学案例名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvWritingOnBBCase_Resource_RelEN.WritingOnBBCaseTheme = objDT.Rows[0][convWritingOnBBCase_Resource_Rel.WritingOnBBCaseTheme].ToString().Trim(); //板书教学案例主题词(字段类型:varchar,字段长度:200,是否可空:True)
 objvWritingOnBBCase_Resource_RelEN.IdDiscipline = objDT.Rows[0][convWritingOnBBCase_Resource_Rel.IdDiscipline].ToString().Trim(); //学科流水号(字段类型:char,字段长度:4,是否可空:False)
 objvWritingOnBBCase_Resource_RelEN.DisciplineID = objDT.Rows[0][convWritingOnBBCase_Resource_Rel.DisciplineID].ToString().Trim(); //学科ID(字段类型:char,字段长度:4,是否可空:False)
 objvWritingOnBBCase_Resource_RelEN.DisciplineName = objDT.Rows[0][convWritingOnBBCase_Resource_Rel.DisciplineName].ToString().Trim(); //学科名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvWritingOnBBCase_Resource_RelEN.WritingOnBBCaseDate = objDT.Rows[0][convWritingOnBBCase_Resource_Rel.WritingOnBBCaseDate].ToString().Trim(); //板书教学日期(字段类型:char,字段长度:8,是否可空:True)
 objvWritingOnBBCase_Resource_RelEN.WritingOnBBCaseTime = objDT.Rows[0][convWritingOnBBCase_Resource_Rel.WritingOnBBCaseTime].ToString().Trim(); //板书教学时间(字段类型:char,字段长度:6,是否可空:True)
 objvWritingOnBBCase_Resource_RelEN.WritingOnBBCaseDateIn = objDT.Rows[0][convWritingOnBBCase_Resource_Rel.WritingOnBBCaseDateIn].ToString().Trim(); //案例入库日期(字段类型:char,字段长度:8,是否可空:True)
 objvWritingOnBBCase_Resource_RelEN.WritingOnBBCaseTimeIn = objDT.Rows[0][convWritingOnBBCase_Resource_Rel.WritingOnBBCaseTimeIn].ToString().Trim(); //案例入库时间(字段类型:char,字段长度:6,是否可空:True)
 objvWritingOnBBCase_Resource_RelEN.IdStudyLevel = objDT.Rows[0][convWritingOnBBCase_Resource_Rel.IdStudyLevel].ToString().Trim(); //id_StudyLevel(字段类型:char,字段长度:4,是否可空:True)
 objvWritingOnBBCase_Resource_RelEN.StudyLevelName = objDT.Rows[0][convWritingOnBBCase_Resource_Rel.StudyLevelName].ToString().Trim(); //学段名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvWritingOnBBCase_Resource_RelEN.CaseLevelId = objDT.Rows[0][convWritingOnBBCase_Resource_Rel.CaseLevelId].ToString().Trim(); //课例等级Id(字段类型:char,字段长度:2,是否可空:True)
 objvWritingOnBBCase_Resource_RelEN.senateGaugeVersionID = objDT.Rows[0][convWritingOnBBCase_Resource_Rel.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID(字段类型:char,字段长度:4,是否可空:False)
 objvWritingOnBBCase_Resource_RelEN.senateGaugeVersionName = objDT.Rows[0][convWritingOnBBCase_Resource_Rel.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称(字段类型:varchar,字段长度:200,是否可空:True)
 objvWritingOnBBCase_Resource_RelEN.senateGaugeVersionTtlScore = TransNullToFloat(objDT.Rows[0][convWritingOnBBCase_Resource_Rel.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分(字段类型:float,字段长度:8,是否可空:False)
 objvWritingOnBBCase_Resource_RelEN.VersionNo = TransNullToInt(objDT.Rows[0][convWritingOnBBCase_Resource_Rel.VersionNo].ToString().Trim()); //版本号(字段类型:int,字段长度:4,是否可空:True)
 objvWritingOnBBCase_Resource_RelEN.OwnerId = objDT.Rows[0][convWritingOnBBCase_Resource_Rel.OwnerId].ToString().Trim(); //拥有者Id(字段类型:varchar,字段长度:20,是否可空:False)
 objvWritingOnBBCase_Resource_RelEN.StuName = objDT.Rows[0][convWritingOnBBCase_Resource_Rel.StuName].ToString().Trim(); //姓名(字段类型:varchar,字段长度:50,是否可空:True)
 objvWritingOnBBCase_Resource_RelEN.StuID = objDT.Rows[0][convWritingOnBBCase_Resource_Rel.StuID].ToString().Trim(); //学号(字段类型:varchar,字段长度:20,是否可空:True)
 objvWritingOnBBCase_Resource_RelEN.CollegeName = objDT.Rows[0][convWritingOnBBCase_Resource_Rel.CollegeName].ToString().Trim(); //学院名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvWritingOnBBCase_Resource_RelEN.IdXzCollege = objDT.Rows[0][convWritingOnBBCase_Resource_Rel.IdXzCollege].ToString().Trim(); //学院流水号(字段类型:char,字段长度:4,是否可空:True)
 objvWritingOnBBCase_Resource_RelEN.IdXzMajor = objDT.Rows[0][convWritingOnBBCase_Resource_Rel.IdXzMajor].ToString().Trim(); //专业流水号(字段类型:char,字段长度:8,是否可空:False)
 objvWritingOnBBCase_Resource_RelEN.IdGradeBase = objDT.Rows[0][convWritingOnBBCase_Resource_Rel.IdGradeBase].ToString().Trim(); //年级流水号(字段类型:char,字段长度:4,是否可空:True)
 objvWritingOnBBCase_Resource_RelEN.IdAdminCls = objDT.Rows[0][convWritingOnBBCase_Resource_Rel.IdAdminCls].ToString().Trim(); //行政班流水号(字段类型:char,字段长度:8,是否可空:True)
 objvWritingOnBBCase_Resource_RelEN.CollegeNameA = objDT.Rows[0][convWritingOnBBCase_Resource_Rel.CollegeNameA].ToString().Trim(); //学院名称简写(字段类型:varchar,字段长度:12,是否可空:True)
 objvWritingOnBBCase_Resource_RelEN.IsDualVideo = TransNullToBool(objDT.Rows[0][convWritingOnBBCase_Resource_Rel.IsDualVideo].ToString().Trim()); //是否双视频(字段类型:bit,字段长度:1,是否可空:False)
 objvWritingOnBBCase_Resource_RelEN.RecommendedDegreeId = objDT.Rows[0][convWritingOnBBCase_Resource_Rel.RecommendedDegreeId].ToString().Trim(); //推荐度Id(字段类型:char,字段长度:2,是否可空:False)
 objvWritingOnBBCase_Resource_RelEN.RecommendedDegreeName = objDT.Rows[0][convWritingOnBBCase_Resource_Rel.RecommendedDegreeName].ToString().Trim(); //推荐度名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvWritingOnBBCase_Resource_RelEN.BrowseCount4Case = TransNullToInt(objDT.Rows[0][convWritingOnBBCase_Resource_Rel.BrowseCount4Case].ToString().Trim()); //课例浏览次数(字段类型:int,字段长度:4,是否可空:True)
 objvWritingOnBBCase_Resource_RelEN.IdResource = objDT.Rows[0][convWritingOnBBCase_Resource_Rel.IdResource].ToString().Trim(); //资源流水号(字段类型:char,字段长度:8,是否可空:False)
 objvWritingOnBBCase_Resource_RelEN.ResourceID = objDT.Rows[0][convWritingOnBBCase_Resource_Rel.ResourceID].ToString().Trim(); //资源ID(字段类型:char,字段长度:8,是否可空:False)
 objvWritingOnBBCase_Resource_RelEN.IdFtpResource = objDT.Rows[0][convWritingOnBBCase_Resource_Rel.IdFtpResource].ToString().Trim(); //FTP资源流水号(字段类型:char,字段长度:8,是否可空:True)
 objvWritingOnBBCase_Resource_RelEN.IdFile = objDT.Rows[0][convWritingOnBBCase_Resource_Rel.IdFile].ToString().Trim(); //文件流水号(字段类型:char,字段长度:8,是否可空:True)
 objvWritingOnBBCase_Resource_RelEN.FileName = objDT.Rows[0][convWritingOnBBCase_Resource_Rel.FileName].ToString().Trim(); //文件名称(字段类型:varchar,字段长度:500,是否可空:True)
 objvWritingOnBBCase_Resource_RelEN.FileType = objDT.Rows[0][convWritingOnBBCase_Resource_Rel.FileType].ToString().Trim(); //文件类型(字段类型:varchar,字段长度:30,是否可空:True)
 objvWritingOnBBCase_Resource_RelEN.SaveDate = objDT.Rows[0][convWritingOnBBCase_Resource_Rel.SaveDate].ToString().Trim(); //创建日期(字段类型:char,字段长度:8,是否可空:True)
 objvWritingOnBBCase_Resource_RelEN.FileSize = objDT.Rows[0][convWritingOnBBCase_Resource_Rel.FileSize].ToString().Trim(); //文件大小(字段类型:varchar,字段长度:50,是否可空:True)
 objvWritingOnBBCase_Resource_RelEN.SaveTime = objDT.Rows[0][convWritingOnBBCase_Resource_Rel.SaveTime].ToString().Trim(); //创建时间(字段类型:char,字段长度:6,是否可空:True)
 objvWritingOnBBCase_Resource_RelEN.FtpResourceID = objDT.Rows[0][convWritingOnBBCase_Resource_Rel.FtpResourceID].ToString().Trim(); //FTP资源ID(字段类型:char,字段长度:8,是否可空:False)
 objvWritingOnBBCase_Resource_RelEN.FileOriginalName = objDT.Rows[0][convWritingOnBBCase_Resource_Rel.FileOriginalName].ToString().Trim(); //文件原名(字段类型:varchar,字段长度:200,是否可空:True)
 objvWritingOnBBCase_Resource_RelEN.FileDirName = objDT.Rows[0][convWritingOnBBCase_Resource_Rel.FileDirName].ToString().Trim(); //文件目录名(字段类型:varchar,字段长度:200,是否可空:True)
 objvWritingOnBBCase_Resource_RelEN.FileRename = objDT.Rows[0][convWritingOnBBCase_Resource_Rel.FileRename].ToString().Trim(); //文件新名(字段类型:varchar,字段长度:200,是否可空:True)
 objvWritingOnBBCase_Resource_RelEN.FileUpDate = objDT.Rows[0][convWritingOnBBCase_Resource_Rel.FileUpDate].ToString().Trim(); //创建日期(字段类型:char,字段长度:8,是否可空:True)
 objvWritingOnBBCase_Resource_RelEN.FileUpTime = objDT.Rows[0][convWritingOnBBCase_Resource_Rel.FileUpTime].ToString().Trim(); //创建时间(字段类型:char,字段长度:6,是否可空:True)
 objvWritingOnBBCase_Resource_RelEN.SaveMode = TransNullToBool(objDT.Rows[0][convWritingOnBBCase_Resource_Rel.SaveMode].ToString().Trim()); //文件存放方式(字段类型:bit,字段长度:1,是否可空:True)
 objvWritingOnBBCase_Resource_RelEN.IdResourceType = objDT.Rows[0][convWritingOnBBCase_Resource_Rel.IdResourceType].ToString().Trim(); //资源类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvWritingOnBBCase_Resource_RelEN.ResourceTypeID = objDT.Rows[0][convWritingOnBBCase_Resource_Rel.ResourceTypeID].ToString().Trim(); //资源类型ID(字段类型:char,字段长度:4,是否可空:False)
 objvWritingOnBBCase_Resource_RelEN.ResourceTypeName = objDT.Rows[0][convWritingOnBBCase_Resource_Rel.ResourceTypeName].ToString().Trim(); //资源类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvWritingOnBBCase_Resource_RelEN.ResourceOwner = objDT.Rows[0][convWritingOnBBCase_Resource_Rel.ResourceOwner].ToString().Trim(); //上传者(字段类型:varchar,字段长度:50,是否可空:False)
 objvWritingOnBBCase_Resource_RelEN.ftpFileType = objDT.Rows[0][convWritingOnBBCase_Resource_Rel.ftpFileType].ToString().Trim(); //ftp文件类型(字段类型:varchar,字段长度:30,是否可空:True)
 objvWritingOnBBCase_Resource_RelEN.ftpFileSize = objDT.Rows[0][convWritingOnBBCase_Resource_Rel.ftpFileSize].ToString().Trim(); //ftp文件大小(字段类型:varchar,字段长度:50,是否可空:True)
 objvWritingOnBBCase_Resource_RelEN.ftpResourceOwner = objDT.Rows[0][convWritingOnBBCase_Resource_Rel.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者(字段类型:varchar,字段长度:50,是否可空:True)
 objvWritingOnBBCase_Resource_RelEN.FileOriginName = objDT.Rows[0][convWritingOnBBCase_Resource_Rel.FileOriginName].ToString().Trim(); //原文件名(字段类型:varchar,字段长度:500,是否可空:True)
 objvWritingOnBBCase_Resource_RelEN.IsExistFile = TransNullToBool(objDT.Rows[0][convWritingOnBBCase_Resource_Rel.IsExistFile].ToString().Trim()); //是否存在文件(字段类型:bit,字段长度:1,是否可空:True)
 objvWritingOnBBCase_Resource_RelEN.FileNewName = objDT.Rows[0][convWritingOnBBCase_Resource_Rel.FileNewName].ToString().Trim(); //新文件名(字段类型:varchar,字段长度:530,是否可空:True)
 objvWritingOnBBCase_Resource_RelEN.FileOldName = objDT.Rows[0][convWritingOnBBCase_Resource_Rel.FileOldName].ToString().Trim(); //旧文件名(字段类型:varchar,字段长度:530,是否可空:True)
 objvWritingOnBBCase_Resource_RelEN.IsMain = TransNullToBool(objDT.Rows[0][convWritingOnBBCase_Resource_Rel.IsMain].ToString().Trim()); //是否主资源(字段类型:bit,字段长度:1,是否可空:True)
 objvWritingOnBBCase_Resource_RelEN.IdUsingMode = objDT.Rows[0][convWritingOnBBCase_Resource_Rel.IdUsingMode].ToString().Trim(); //资源使用模式流水号(字段类型:char,字段长度:4,是否可空:False)
 objvWritingOnBBCase_Resource_RelEN.IsVisible = TransNullToBool(objDT.Rows[0][convWritingOnBBCase_Resource_Rel.IsVisible].ToString().Trim()); //是否显示(字段类型:bit,字段长度:1,是否可空:True)
 objvWritingOnBBCase_Resource_RelEN.IndexNO = TransNullToInt(objDT.Rows[0][convWritingOnBBCase_Resource_Rel.IndexNO].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:True)
 objvWritingOnBBCase_Resource_RelEN.BrowseCount = TransNullToInt(objDT.Rows[0][convWritingOnBBCase_Resource_Rel.BrowseCount].ToString().Trim()); //浏览次数(字段类型:int,字段长度:4,是否可空:True)
 objvWritingOnBBCase_Resource_RelEN.UpdDate = objDT.Rows[0][convWritingOnBBCase_Resource_Rel.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvWritingOnBBCase_Resource_RelEN.UpdUser = objDT.Rows[0][convWritingOnBBCase_Resource_Rel.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objvWritingOnBBCase_Resource_RelEN.Memo = objDT.Rows[0][convWritingOnBBCase_Resource_Rel.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvWritingOnBBCase_Resource_RelDA: GetvWritingOnBBCase_Resource_Rel)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngIdMicroteachCaseResourceRel">表关键字</param>
 /// <returns>表对象</returns>
public clsvWritingOnBBCase_Resource_RelEN GetObjByIdMicroteachCaseResourceRel(long lngIdMicroteachCaseResourceRel)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvWritingOnBBCase_Resource_RelDA.GetSpecSQLObj();
strSQL = "Select * from vWritingOnBBCase_Resource_Rel where IdMicroteachCaseResourceRel = " + ""+ lngIdMicroteachCaseResourceRel+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvWritingOnBBCase_Resource_RelEN objvWritingOnBBCase_Resource_RelEN = new clsvWritingOnBBCase_Resource_RelEN();
try
{
 objvWritingOnBBCase_Resource_RelEN.IdMicroteachCaseResourceRel = Int32.Parse(objRow[convWritingOnBBCase_Resource_Rel.IdMicroteachCaseResourceRel].ToString().Trim()); //微格案例资源关系流水号(字段类型:bigint,字段长度:8,是否可空:False)
 objvWritingOnBBCase_Resource_RelEN.FuncModuleId = objRow[convWritingOnBBCase_Resource_Rel.FuncModuleId].ToString().Trim(); //功能模块Id(字段类型:char,字段长度:4,是否可空:True)
 objvWritingOnBBCase_Resource_RelEN.FuncModuleName = objRow[convWritingOnBBCase_Resource_Rel.FuncModuleName] == DBNull.Value ? null : objRow[convWritingOnBBCase_Resource_Rel.FuncModuleName].ToString().Trim(); //功能模块名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvWritingOnBBCase_Resource_RelEN.IdMicroteachCase = objRow[convWritingOnBBCase_Resource_Rel.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号(字段类型:char,字段长度:8,是否可空:False)
 objvWritingOnBBCase_Resource_RelEN.IdWritingOnBBCase = objRow[convWritingOnBBCase_Resource_Rel.IdWritingOnBBCase].ToString().Trim(); //板书案例流水号(字段类型:char,字段长度:8,是否可空:False)
 objvWritingOnBBCase_Resource_RelEN.WritingOnBBCaseID = objRow[convWritingOnBBCase_Resource_Rel.WritingOnBBCaseID].ToString().Trim(); //板书教学案例ID(字段类型:char,字段长度:8,是否可空:False)
 objvWritingOnBBCase_Resource_RelEN.WritingOnBBCaseName = objRow[convWritingOnBBCase_Resource_Rel.WritingOnBBCaseName].ToString().Trim(); //板书教学案例名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvWritingOnBBCase_Resource_RelEN.WritingOnBBCaseTheme = objRow[convWritingOnBBCase_Resource_Rel.WritingOnBBCaseTheme] == DBNull.Value ? null : objRow[convWritingOnBBCase_Resource_Rel.WritingOnBBCaseTheme].ToString().Trim(); //板书教学案例主题词(字段类型:varchar,字段长度:200,是否可空:True)
 objvWritingOnBBCase_Resource_RelEN.IdDiscipline = objRow[convWritingOnBBCase_Resource_Rel.IdDiscipline].ToString().Trim(); //学科流水号(字段类型:char,字段长度:4,是否可空:False)
 objvWritingOnBBCase_Resource_RelEN.DisciplineID = objRow[convWritingOnBBCase_Resource_Rel.DisciplineID].ToString().Trim(); //学科ID(字段类型:char,字段长度:4,是否可空:False)
 objvWritingOnBBCase_Resource_RelEN.DisciplineName = objRow[convWritingOnBBCase_Resource_Rel.DisciplineName].ToString().Trim(); //学科名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvWritingOnBBCase_Resource_RelEN.WritingOnBBCaseDate = objRow[convWritingOnBBCase_Resource_Rel.WritingOnBBCaseDate] == DBNull.Value ? null : objRow[convWritingOnBBCase_Resource_Rel.WritingOnBBCaseDate].ToString().Trim(); //板书教学日期(字段类型:char,字段长度:8,是否可空:True)
 objvWritingOnBBCase_Resource_RelEN.WritingOnBBCaseTime = objRow[convWritingOnBBCase_Resource_Rel.WritingOnBBCaseTime] == DBNull.Value ? null : objRow[convWritingOnBBCase_Resource_Rel.WritingOnBBCaseTime].ToString().Trim(); //板书教学时间(字段类型:char,字段长度:6,是否可空:True)
 objvWritingOnBBCase_Resource_RelEN.WritingOnBBCaseDateIn = objRow[convWritingOnBBCase_Resource_Rel.WritingOnBBCaseDateIn] == DBNull.Value ? null : objRow[convWritingOnBBCase_Resource_Rel.WritingOnBBCaseDateIn].ToString().Trim(); //案例入库日期(字段类型:char,字段长度:8,是否可空:True)
 objvWritingOnBBCase_Resource_RelEN.WritingOnBBCaseTimeIn = objRow[convWritingOnBBCase_Resource_Rel.WritingOnBBCaseTimeIn] == DBNull.Value ? null : objRow[convWritingOnBBCase_Resource_Rel.WritingOnBBCaseTimeIn].ToString().Trim(); //案例入库时间(字段类型:char,字段长度:6,是否可空:True)
 objvWritingOnBBCase_Resource_RelEN.IdStudyLevel = objRow[convWritingOnBBCase_Resource_Rel.IdStudyLevel].ToString().Trim(); //id_StudyLevel(字段类型:char,字段长度:4,是否可空:True)
 objvWritingOnBBCase_Resource_RelEN.StudyLevelName = objRow[convWritingOnBBCase_Resource_Rel.StudyLevelName].ToString().Trim(); //学段名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvWritingOnBBCase_Resource_RelEN.CaseLevelId = objRow[convWritingOnBBCase_Resource_Rel.CaseLevelId] == DBNull.Value ? null : objRow[convWritingOnBBCase_Resource_Rel.CaseLevelId].ToString().Trim(); //课例等级Id(字段类型:char,字段长度:2,是否可空:True)
 objvWritingOnBBCase_Resource_RelEN.senateGaugeVersionID = objRow[convWritingOnBBCase_Resource_Rel.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID(字段类型:char,字段长度:4,是否可空:False)
 objvWritingOnBBCase_Resource_RelEN.senateGaugeVersionName = objRow[convWritingOnBBCase_Resource_Rel.senateGaugeVersionName] == DBNull.Value ? null : objRow[convWritingOnBBCase_Resource_Rel.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称(字段类型:varchar,字段长度:200,是否可空:True)
 objvWritingOnBBCase_Resource_RelEN.senateGaugeVersionTtlScore = Single.Parse(objRow[convWritingOnBBCase_Resource_Rel.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分(字段类型:float,字段长度:8,是否可空:False)
 objvWritingOnBBCase_Resource_RelEN.VersionNo = objRow[convWritingOnBBCase_Resource_Rel.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convWritingOnBBCase_Resource_Rel.VersionNo].ToString().Trim()); //版本号(字段类型:int,字段长度:4,是否可空:True)
 objvWritingOnBBCase_Resource_RelEN.OwnerId = objRow[convWritingOnBBCase_Resource_Rel.OwnerId] == DBNull.Value ? null : objRow[convWritingOnBBCase_Resource_Rel.OwnerId].ToString().Trim(); //拥有者Id(字段类型:varchar,字段长度:20,是否可空:False)
 objvWritingOnBBCase_Resource_RelEN.StuName = objRow[convWritingOnBBCase_Resource_Rel.StuName].ToString().Trim(); //姓名(字段类型:varchar,字段长度:50,是否可空:True)
 objvWritingOnBBCase_Resource_RelEN.StuID = objRow[convWritingOnBBCase_Resource_Rel.StuID].ToString().Trim(); //学号(字段类型:varchar,字段长度:20,是否可空:True)
 objvWritingOnBBCase_Resource_RelEN.CollegeName = objRow[convWritingOnBBCase_Resource_Rel.CollegeName].ToString().Trim(); //学院名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvWritingOnBBCase_Resource_RelEN.IdXzCollege = objRow[convWritingOnBBCase_Resource_Rel.IdXzCollege] == DBNull.Value ? null : objRow[convWritingOnBBCase_Resource_Rel.IdXzCollege].ToString().Trim(); //学院流水号(字段类型:char,字段长度:4,是否可空:True)
 objvWritingOnBBCase_Resource_RelEN.IdXzMajor = objRow[convWritingOnBBCase_Resource_Rel.IdXzMajor] == DBNull.Value ? null : objRow[convWritingOnBBCase_Resource_Rel.IdXzMajor].ToString().Trim(); //专业流水号(字段类型:char,字段长度:8,是否可空:False)
 objvWritingOnBBCase_Resource_RelEN.IdGradeBase = objRow[convWritingOnBBCase_Resource_Rel.IdGradeBase] == DBNull.Value ? null : objRow[convWritingOnBBCase_Resource_Rel.IdGradeBase].ToString().Trim(); //年级流水号(字段类型:char,字段长度:4,是否可空:True)
 objvWritingOnBBCase_Resource_RelEN.IdAdminCls = objRow[convWritingOnBBCase_Resource_Rel.IdAdminCls] == DBNull.Value ? null : objRow[convWritingOnBBCase_Resource_Rel.IdAdminCls].ToString().Trim(); //行政班流水号(字段类型:char,字段长度:8,是否可空:True)
 objvWritingOnBBCase_Resource_RelEN.CollegeNameA = objRow[convWritingOnBBCase_Resource_Rel.CollegeNameA] == DBNull.Value ? null : objRow[convWritingOnBBCase_Resource_Rel.CollegeNameA].ToString().Trim(); //学院名称简写(字段类型:varchar,字段长度:12,是否可空:True)
 objvWritingOnBBCase_Resource_RelEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convWritingOnBBCase_Resource_Rel.IsDualVideo].ToString().Trim()); //是否双视频(字段类型:bit,字段长度:1,是否可空:False)
 objvWritingOnBBCase_Resource_RelEN.RecommendedDegreeId = objRow[convWritingOnBBCase_Resource_Rel.RecommendedDegreeId] == DBNull.Value ? null : objRow[convWritingOnBBCase_Resource_Rel.RecommendedDegreeId].ToString().Trim(); //推荐度Id(字段类型:char,字段长度:2,是否可空:False)
 objvWritingOnBBCase_Resource_RelEN.RecommendedDegreeName = objRow[convWritingOnBBCase_Resource_Rel.RecommendedDegreeName] == DBNull.Value ? null : objRow[convWritingOnBBCase_Resource_Rel.RecommendedDegreeName].ToString().Trim(); //推荐度名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvWritingOnBBCase_Resource_RelEN.BrowseCount4Case = objRow[convWritingOnBBCase_Resource_Rel.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convWritingOnBBCase_Resource_Rel.BrowseCount4Case].ToString().Trim()); //课例浏览次数(字段类型:int,字段长度:4,是否可空:True)
 objvWritingOnBBCase_Resource_RelEN.IdResource = objRow[convWritingOnBBCase_Resource_Rel.IdResource].ToString().Trim(); //资源流水号(字段类型:char,字段长度:8,是否可空:False)
 objvWritingOnBBCase_Resource_RelEN.ResourceID = objRow[convWritingOnBBCase_Resource_Rel.ResourceID].ToString().Trim(); //资源ID(字段类型:char,字段长度:8,是否可空:False)
 objvWritingOnBBCase_Resource_RelEN.IdFtpResource = objRow[convWritingOnBBCase_Resource_Rel.IdFtpResource] == DBNull.Value ? null : objRow[convWritingOnBBCase_Resource_Rel.IdFtpResource].ToString().Trim(); //FTP资源流水号(字段类型:char,字段长度:8,是否可空:True)
 objvWritingOnBBCase_Resource_RelEN.IdFile = objRow[convWritingOnBBCase_Resource_Rel.IdFile] == DBNull.Value ? null : objRow[convWritingOnBBCase_Resource_Rel.IdFile].ToString().Trim(); //文件流水号(字段类型:char,字段长度:8,是否可空:True)
 objvWritingOnBBCase_Resource_RelEN.FileName = objRow[convWritingOnBBCase_Resource_Rel.FileName] == DBNull.Value ? null : objRow[convWritingOnBBCase_Resource_Rel.FileName].ToString().Trim(); //文件名称(字段类型:varchar,字段长度:500,是否可空:True)
 objvWritingOnBBCase_Resource_RelEN.FileType = objRow[convWritingOnBBCase_Resource_Rel.FileType] == DBNull.Value ? null : objRow[convWritingOnBBCase_Resource_Rel.FileType].ToString().Trim(); //文件类型(字段类型:varchar,字段长度:30,是否可空:True)
 objvWritingOnBBCase_Resource_RelEN.SaveDate = objRow[convWritingOnBBCase_Resource_Rel.SaveDate] == DBNull.Value ? null : objRow[convWritingOnBBCase_Resource_Rel.SaveDate].ToString().Trim(); //创建日期(字段类型:char,字段长度:8,是否可空:True)
 objvWritingOnBBCase_Resource_RelEN.FileSize = objRow[convWritingOnBBCase_Resource_Rel.FileSize] == DBNull.Value ? null : objRow[convWritingOnBBCase_Resource_Rel.FileSize].ToString().Trim(); //文件大小(字段类型:varchar,字段长度:50,是否可空:True)
 objvWritingOnBBCase_Resource_RelEN.SaveTime = objRow[convWritingOnBBCase_Resource_Rel.SaveTime] == DBNull.Value ? null : objRow[convWritingOnBBCase_Resource_Rel.SaveTime].ToString().Trim(); //创建时间(字段类型:char,字段长度:6,是否可空:True)
 objvWritingOnBBCase_Resource_RelEN.FtpResourceID = objRow[convWritingOnBBCase_Resource_Rel.FtpResourceID].ToString().Trim(); //FTP资源ID(字段类型:char,字段长度:8,是否可空:False)
 objvWritingOnBBCase_Resource_RelEN.FileOriginalName = objRow[convWritingOnBBCase_Resource_Rel.FileOriginalName] == DBNull.Value ? null : objRow[convWritingOnBBCase_Resource_Rel.FileOriginalName].ToString().Trim(); //文件原名(字段类型:varchar,字段长度:200,是否可空:True)
 objvWritingOnBBCase_Resource_RelEN.FileDirName = objRow[convWritingOnBBCase_Resource_Rel.FileDirName] == DBNull.Value ? null : objRow[convWritingOnBBCase_Resource_Rel.FileDirName].ToString().Trim(); //文件目录名(字段类型:varchar,字段长度:200,是否可空:True)
 objvWritingOnBBCase_Resource_RelEN.FileRename = objRow[convWritingOnBBCase_Resource_Rel.FileRename] == DBNull.Value ? null : objRow[convWritingOnBBCase_Resource_Rel.FileRename].ToString().Trim(); //文件新名(字段类型:varchar,字段长度:200,是否可空:True)
 objvWritingOnBBCase_Resource_RelEN.FileUpDate = objRow[convWritingOnBBCase_Resource_Rel.FileUpDate] == DBNull.Value ? null : objRow[convWritingOnBBCase_Resource_Rel.FileUpDate].ToString().Trim(); //创建日期(字段类型:char,字段长度:8,是否可空:True)
 objvWritingOnBBCase_Resource_RelEN.FileUpTime = objRow[convWritingOnBBCase_Resource_Rel.FileUpTime] == DBNull.Value ? null : objRow[convWritingOnBBCase_Resource_Rel.FileUpTime].ToString().Trim(); //创建时间(字段类型:char,字段长度:6,是否可空:True)
 objvWritingOnBBCase_Resource_RelEN.SaveMode = clsEntityBase2.TransNullToBool_S(objRow[convWritingOnBBCase_Resource_Rel.SaveMode].ToString().Trim()); //文件存放方式(字段类型:bit,字段长度:1,是否可空:True)
 objvWritingOnBBCase_Resource_RelEN.IdResourceType = objRow[convWritingOnBBCase_Resource_Rel.IdResourceType].ToString().Trim(); //资源类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvWritingOnBBCase_Resource_RelEN.ResourceTypeID = objRow[convWritingOnBBCase_Resource_Rel.ResourceTypeID].ToString().Trim(); //资源类型ID(字段类型:char,字段长度:4,是否可空:False)
 objvWritingOnBBCase_Resource_RelEN.ResourceTypeName = objRow[convWritingOnBBCase_Resource_Rel.ResourceTypeName].ToString().Trim(); //资源类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvWritingOnBBCase_Resource_RelEN.ResourceOwner = objRow[convWritingOnBBCase_Resource_Rel.ResourceOwner].ToString().Trim(); //上传者(字段类型:varchar,字段长度:50,是否可空:False)
 objvWritingOnBBCase_Resource_RelEN.ftpFileType = objRow[convWritingOnBBCase_Resource_Rel.ftpFileType] == DBNull.Value ? null : objRow[convWritingOnBBCase_Resource_Rel.ftpFileType].ToString().Trim(); //ftp文件类型(字段类型:varchar,字段长度:30,是否可空:True)
 objvWritingOnBBCase_Resource_RelEN.ftpFileSize = objRow[convWritingOnBBCase_Resource_Rel.ftpFileSize] == DBNull.Value ? null : objRow[convWritingOnBBCase_Resource_Rel.ftpFileSize].ToString().Trim(); //ftp文件大小(字段类型:varchar,字段长度:50,是否可空:True)
 objvWritingOnBBCase_Resource_RelEN.ftpResourceOwner = objRow[convWritingOnBBCase_Resource_Rel.ftpResourceOwner] == DBNull.Value ? null : objRow[convWritingOnBBCase_Resource_Rel.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者(字段类型:varchar,字段长度:50,是否可空:True)
 objvWritingOnBBCase_Resource_RelEN.FileOriginName = objRow[convWritingOnBBCase_Resource_Rel.FileOriginName] == DBNull.Value ? null : objRow[convWritingOnBBCase_Resource_Rel.FileOriginName].ToString().Trim(); //原文件名(字段类型:varchar,字段长度:500,是否可空:True)
 objvWritingOnBBCase_Resource_RelEN.IsExistFile = clsEntityBase2.TransNullToBool_S(objRow[convWritingOnBBCase_Resource_Rel.IsExistFile].ToString().Trim()); //是否存在文件(字段类型:bit,字段长度:1,是否可空:True)
 objvWritingOnBBCase_Resource_RelEN.FileNewName = objRow[convWritingOnBBCase_Resource_Rel.FileNewName] == DBNull.Value ? null : objRow[convWritingOnBBCase_Resource_Rel.FileNewName].ToString().Trim(); //新文件名(字段类型:varchar,字段长度:530,是否可空:True)
 objvWritingOnBBCase_Resource_RelEN.FileOldName = objRow[convWritingOnBBCase_Resource_Rel.FileOldName] == DBNull.Value ? null : objRow[convWritingOnBBCase_Resource_Rel.FileOldName].ToString().Trim(); //旧文件名(字段类型:varchar,字段长度:530,是否可空:True)
 objvWritingOnBBCase_Resource_RelEN.IsMain = clsEntityBase2.TransNullToBool_S(objRow[convWritingOnBBCase_Resource_Rel.IsMain].ToString().Trim()); //是否主资源(字段类型:bit,字段长度:1,是否可空:True)
 objvWritingOnBBCase_Resource_RelEN.IdUsingMode = objRow[convWritingOnBBCase_Resource_Rel.IdUsingMode].ToString().Trim(); //资源使用模式流水号(字段类型:char,字段长度:4,是否可空:False)
 objvWritingOnBBCase_Resource_RelEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convWritingOnBBCase_Resource_Rel.IsVisible].ToString().Trim()); //是否显示(字段类型:bit,字段长度:1,是否可空:True)
 objvWritingOnBBCase_Resource_RelEN.IndexNO = objRow[convWritingOnBBCase_Resource_Rel.IndexNO] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convWritingOnBBCase_Resource_Rel.IndexNO].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:True)
 objvWritingOnBBCase_Resource_RelEN.BrowseCount = objRow[convWritingOnBBCase_Resource_Rel.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convWritingOnBBCase_Resource_Rel.BrowseCount].ToString().Trim()); //浏览次数(字段类型:int,字段长度:4,是否可空:True)
 objvWritingOnBBCase_Resource_RelEN.UpdDate = objRow[convWritingOnBBCase_Resource_Rel.UpdDate] == DBNull.Value ? null : objRow[convWritingOnBBCase_Resource_Rel.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvWritingOnBBCase_Resource_RelEN.UpdUser = objRow[convWritingOnBBCase_Resource_Rel.UpdUser] == DBNull.Value ? null : objRow[convWritingOnBBCase_Resource_Rel.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objvWritingOnBBCase_Resource_RelEN.Memo = objRow[convWritingOnBBCase_Resource_Rel.Memo] == DBNull.Value ? null : objRow[convWritingOnBBCase_Resource_Rel.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvWritingOnBBCase_Resource_RelDA: GetObjByIdMicroteachCaseResourceRel)", objException.Message));
}
return objvWritingOnBBCase_Resource_RelEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvWritingOnBBCase_Resource_RelEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvWritingOnBBCase_Resource_RelDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvWritingOnBBCase_Resource_RelDA.GetSpecSQLObj();
strSQL = "Select * from vWritingOnBBCase_Resource_Rel where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvWritingOnBBCase_Resource_RelEN objvWritingOnBBCase_Resource_RelEN = new clsvWritingOnBBCase_Resource_RelEN()
{
IdMicroteachCaseResourceRel = TransNullToInt(objRow[convWritingOnBBCase_Resource_Rel.IdMicroteachCaseResourceRel].ToString().Trim()), //微格案例资源关系流水号
FuncModuleId = objRow[convWritingOnBBCase_Resource_Rel.FuncModuleId].ToString().Trim(), //功能模块Id
FuncModuleName = objRow[convWritingOnBBCase_Resource_Rel.FuncModuleName] == DBNull.Value ? null : objRow[convWritingOnBBCase_Resource_Rel.FuncModuleName].ToString().Trim(), //功能模块名称
IdMicroteachCase = objRow[convWritingOnBBCase_Resource_Rel.IdMicroteachCase].ToString().Trim(), //微格教学案例流水号
IdWritingOnBBCase = objRow[convWritingOnBBCase_Resource_Rel.IdWritingOnBBCase].ToString().Trim(), //板书案例流水号
WritingOnBBCaseID = objRow[convWritingOnBBCase_Resource_Rel.WritingOnBBCaseID].ToString().Trim(), //板书教学案例ID
WritingOnBBCaseName = objRow[convWritingOnBBCase_Resource_Rel.WritingOnBBCaseName].ToString().Trim(), //板书教学案例名称
WritingOnBBCaseTheme = objRow[convWritingOnBBCase_Resource_Rel.WritingOnBBCaseTheme] == DBNull.Value ? null : objRow[convWritingOnBBCase_Resource_Rel.WritingOnBBCaseTheme].ToString().Trim(), //板书教学案例主题词
IdDiscipline = objRow[convWritingOnBBCase_Resource_Rel.IdDiscipline].ToString().Trim(), //学科流水号
DisciplineID = objRow[convWritingOnBBCase_Resource_Rel.DisciplineID].ToString().Trim(), //学科ID
DisciplineName = objRow[convWritingOnBBCase_Resource_Rel.DisciplineName].ToString().Trim(), //学科名称
WritingOnBBCaseDate = objRow[convWritingOnBBCase_Resource_Rel.WritingOnBBCaseDate] == DBNull.Value ? null : objRow[convWritingOnBBCase_Resource_Rel.WritingOnBBCaseDate].ToString().Trim(), //板书教学日期
WritingOnBBCaseTime = objRow[convWritingOnBBCase_Resource_Rel.WritingOnBBCaseTime] == DBNull.Value ? null : objRow[convWritingOnBBCase_Resource_Rel.WritingOnBBCaseTime].ToString().Trim(), //板书教学时间
WritingOnBBCaseDateIn = objRow[convWritingOnBBCase_Resource_Rel.WritingOnBBCaseDateIn] == DBNull.Value ? null : objRow[convWritingOnBBCase_Resource_Rel.WritingOnBBCaseDateIn].ToString().Trim(), //案例入库日期
WritingOnBBCaseTimeIn = objRow[convWritingOnBBCase_Resource_Rel.WritingOnBBCaseTimeIn] == DBNull.Value ? null : objRow[convWritingOnBBCase_Resource_Rel.WritingOnBBCaseTimeIn].ToString().Trim(), //案例入库时间
IdStudyLevel = objRow[convWritingOnBBCase_Resource_Rel.IdStudyLevel].ToString().Trim(), //id_StudyLevel
StudyLevelName = objRow[convWritingOnBBCase_Resource_Rel.StudyLevelName].ToString().Trim(), //学段名称
CaseLevelId = objRow[convWritingOnBBCase_Resource_Rel.CaseLevelId] == DBNull.Value ? null : objRow[convWritingOnBBCase_Resource_Rel.CaseLevelId].ToString().Trim(), //课例等级Id
senateGaugeVersionID = objRow[convWritingOnBBCase_Resource_Rel.senateGaugeVersionID].ToString().Trim(), //评价量表版本ID
senateGaugeVersionName = objRow[convWritingOnBBCase_Resource_Rel.senateGaugeVersionName] == DBNull.Value ? null : objRow[convWritingOnBBCase_Resource_Rel.senateGaugeVersionName].ToString().Trim(), //评价量表版本名称
senateGaugeVersionTtlScore = TransNullToFloat(objRow[convWritingOnBBCase_Resource_Rel.senateGaugeVersionTtlScore].ToString().Trim()), //评价量表版本总分
VersionNo = objRow[convWritingOnBBCase_Resource_Rel.VersionNo] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convWritingOnBBCase_Resource_Rel.VersionNo].ToString().Trim()), //版本号
OwnerId = objRow[convWritingOnBBCase_Resource_Rel.OwnerId] == DBNull.Value ? null : objRow[convWritingOnBBCase_Resource_Rel.OwnerId].ToString().Trim(), //拥有者Id
StuName = objRow[convWritingOnBBCase_Resource_Rel.StuName].ToString().Trim(), //姓名
StuID = objRow[convWritingOnBBCase_Resource_Rel.StuID].ToString().Trim(), //学号
CollegeName = objRow[convWritingOnBBCase_Resource_Rel.CollegeName].ToString().Trim(), //学院名称
IdXzCollege = objRow[convWritingOnBBCase_Resource_Rel.IdXzCollege] == DBNull.Value ? null : objRow[convWritingOnBBCase_Resource_Rel.IdXzCollege].ToString().Trim(), //学院流水号
IdXzMajor = objRow[convWritingOnBBCase_Resource_Rel.IdXzMajor] == DBNull.Value ? null : objRow[convWritingOnBBCase_Resource_Rel.IdXzMajor].ToString().Trim(), //专业流水号
IdGradeBase = objRow[convWritingOnBBCase_Resource_Rel.IdGradeBase] == DBNull.Value ? null : objRow[convWritingOnBBCase_Resource_Rel.IdGradeBase].ToString().Trim(), //年级流水号
IdAdminCls = objRow[convWritingOnBBCase_Resource_Rel.IdAdminCls] == DBNull.Value ? null : objRow[convWritingOnBBCase_Resource_Rel.IdAdminCls].ToString().Trim(), //行政班流水号
CollegeNameA = objRow[convWritingOnBBCase_Resource_Rel.CollegeNameA] == DBNull.Value ? null : objRow[convWritingOnBBCase_Resource_Rel.CollegeNameA].ToString().Trim(), //学院名称简写
IsDualVideo = TransNullToBool(objRow[convWritingOnBBCase_Resource_Rel.IsDualVideo].ToString().Trim()), //是否双视频
RecommendedDegreeId = objRow[convWritingOnBBCase_Resource_Rel.RecommendedDegreeId] == DBNull.Value ? null : objRow[convWritingOnBBCase_Resource_Rel.RecommendedDegreeId].ToString().Trim(), //推荐度Id
RecommendedDegreeName = objRow[convWritingOnBBCase_Resource_Rel.RecommendedDegreeName] == DBNull.Value ? null : objRow[convWritingOnBBCase_Resource_Rel.RecommendedDegreeName].ToString().Trim(), //推荐度名称
BrowseCount4Case = objRow[convWritingOnBBCase_Resource_Rel.BrowseCount4Case] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convWritingOnBBCase_Resource_Rel.BrowseCount4Case].ToString().Trim()), //课例浏览次数
IdResource = objRow[convWritingOnBBCase_Resource_Rel.IdResource].ToString().Trim(), //资源流水号
ResourceID = objRow[convWritingOnBBCase_Resource_Rel.ResourceID].ToString().Trim(), //资源ID
IdFtpResource = objRow[convWritingOnBBCase_Resource_Rel.IdFtpResource] == DBNull.Value ? null : objRow[convWritingOnBBCase_Resource_Rel.IdFtpResource].ToString().Trim(), //FTP资源流水号
IdFile = objRow[convWritingOnBBCase_Resource_Rel.IdFile] == DBNull.Value ? null : objRow[convWritingOnBBCase_Resource_Rel.IdFile].ToString().Trim(), //文件流水号
FileName = objRow[convWritingOnBBCase_Resource_Rel.FileName] == DBNull.Value ? null : objRow[convWritingOnBBCase_Resource_Rel.FileName].ToString().Trim(), //文件名称
FileType = objRow[convWritingOnBBCase_Resource_Rel.FileType] == DBNull.Value ? null : objRow[convWritingOnBBCase_Resource_Rel.FileType].ToString().Trim(), //文件类型
SaveDate = objRow[convWritingOnBBCase_Resource_Rel.SaveDate] == DBNull.Value ? null : objRow[convWritingOnBBCase_Resource_Rel.SaveDate].ToString().Trim(), //创建日期
FileSize = objRow[convWritingOnBBCase_Resource_Rel.FileSize] == DBNull.Value ? null : objRow[convWritingOnBBCase_Resource_Rel.FileSize].ToString().Trim(), //文件大小
SaveTime = objRow[convWritingOnBBCase_Resource_Rel.SaveTime] == DBNull.Value ? null : objRow[convWritingOnBBCase_Resource_Rel.SaveTime].ToString().Trim(), //创建时间
FtpResourceID = objRow[convWritingOnBBCase_Resource_Rel.FtpResourceID].ToString().Trim(), //FTP资源ID
FileOriginalName = objRow[convWritingOnBBCase_Resource_Rel.FileOriginalName] == DBNull.Value ? null : objRow[convWritingOnBBCase_Resource_Rel.FileOriginalName].ToString().Trim(), //文件原名
FileDirName = objRow[convWritingOnBBCase_Resource_Rel.FileDirName] == DBNull.Value ? null : objRow[convWritingOnBBCase_Resource_Rel.FileDirName].ToString().Trim(), //文件目录名
FileRename = objRow[convWritingOnBBCase_Resource_Rel.FileRename] == DBNull.Value ? null : objRow[convWritingOnBBCase_Resource_Rel.FileRename].ToString().Trim(), //文件新名
FileUpDate = objRow[convWritingOnBBCase_Resource_Rel.FileUpDate] == DBNull.Value ? null : objRow[convWritingOnBBCase_Resource_Rel.FileUpDate].ToString().Trim(), //创建日期
FileUpTime = objRow[convWritingOnBBCase_Resource_Rel.FileUpTime] == DBNull.Value ? null : objRow[convWritingOnBBCase_Resource_Rel.FileUpTime].ToString().Trim(), //创建时间
SaveMode = TransNullToBool(objRow[convWritingOnBBCase_Resource_Rel.SaveMode].ToString().Trim()), //文件存放方式
IdResourceType = objRow[convWritingOnBBCase_Resource_Rel.IdResourceType].ToString().Trim(), //资源类型流水号
ResourceTypeID = objRow[convWritingOnBBCase_Resource_Rel.ResourceTypeID].ToString().Trim(), //资源类型ID
ResourceTypeName = objRow[convWritingOnBBCase_Resource_Rel.ResourceTypeName].ToString().Trim(), //资源类型名称
ResourceOwner = objRow[convWritingOnBBCase_Resource_Rel.ResourceOwner].ToString().Trim(), //上传者
ftpFileType = objRow[convWritingOnBBCase_Resource_Rel.ftpFileType] == DBNull.Value ? null : objRow[convWritingOnBBCase_Resource_Rel.ftpFileType].ToString().Trim(), //ftp文件类型
ftpFileSize = objRow[convWritingOnBBCase_Resource_Rel.ftpFileSize] == DBNull.Value ? null : objRow[convWritingOnBBCase_Resource_Rel.ftpFileSize].ToString().Trim(), //ftp文件大小
ftpResourceOwner = objRow[convWritingOnBBCase_Resource_Rel.ftpResourceOwner] == DBNull.Value ? null : objRow[convWritingOnBBCase_Resource_Rel.ftpResourceOwner].ToString().Trim(), //Ftp资源拥有者
FileOriginName = objRow[convWritingOnBBCase_Resource_Rel.FileOriginName] == DBNull.Value ? null : objRow[convWritingOnBBCase_Resource_Rel.FileOriginName].ToString().Trim(), //原文件名
IsExistFile = TransNullToBool(objRow[convWritingOnBBCase_Resource_Rel.IsExistFile].ToString().Trim()), //是否存在文件
FileNewName = objRow[convWritingOnBBCase_Resource_Rel.FileNewName] == DBNull.Value ? null : objRow[convWritingOnBBCase_Resource_Rel.FileNewName].ToString().Trim(), //新文件名
FileOldName = objRow[convWritingOnBBCase_Resource_Rel.FileOldName] == DBNull.Value ? null : objRow[convWritingOnBBCase_Resource_Rel.FileOldName].ToString().Trim(), //旧文件名
IsMain = TransNullToBool(objRow[convWritingOnBBCase_Resource_Rel.IsMain].ToString().Trim()), //是否主资源
IdUsingMode = objRow[convWritingOnBBCase_Resource_Rel.IdUsingMode].ToString().Trim(), //资源使用模式流水号
IsVisible = TransNullToBool(objRow[convWritingOnBBCase_Resource_Rel.IsVisible].ToString().Trim()), //是否显示
IndexNO = objRow[convWritingOnBBCase_Resource_Rel.IndexNO] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convWritingOnBBCase_Resource_Rel.IndexNO].ToString().Trim()), //序号
BrowseCount = objRow[convWritingOnBBCase_Resource_Rel.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convWritingOnBBCase_Resource_Rel.BrowseCount].ToString().Trim()), //浏览次数
UpdDate = objRow[convWritingOnBBCase_Resource_Rel.UpdDate] == DBNull.Value ? null : objRow[convWritingOnBBCase_Resource_Rel.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[convWritingOnBBCase_Resource_Rel.UpdUser] == DBNull.Value ? null : objRow[convWritingOnBBCase_Resource_Rel.UpdUser].ToString().Trim(), //修改人
Memo = objRow[convWritingOnBBCase_Resource_Rel.Memo] == DBNull.Value ? null : objRow[convWritingOnBBCase_Resource_Rel.Memo].ToString().Trim() //备注
};
objvWritingOnBBCase_Resource_RelEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvWritingOnBBCase_Resource_RelEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvWritingOnBBCase_Resource_RelDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvWritingOnBBCase_Resource_RelEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvWritingOnBBCase_Resource_RelEN objvWritingOnBBCase_Resource_RelEN = new clsvWritingOnBBCase_Resource_RelEN();
try
{
objvWritingOnBBCase_Resource_RelEN.IdMicroteachCaseResourceRel = TransNullToInt(objRow[convWritingOnBBCase_Resource_Rel.IdMicroteachCaseResourceRel].ToString().Trim()); //微格案例资源关系流水号
objvWritingOnBBCase_Resource_RelEN.FuncModuleId = objRow[convWritingOnBBCase_Resource_Rel.FuncModuleId].ToString().Trim(); //功能模块Id
objvWritingOnBBCase_Resource_RelEN.FuncModuleName = objRow[convWritingOnBBCase_Resource_Rel.FuncModuleName] == DBNull.Value ? null : objRow[convWritingOnBBCase_Resource_Rel.FuncModuleName].ToString().Trim(); //功能模块名称
objvWritingOnBBCase_Resource_RelEN.IdMicroteachCase = objRow[convWritingOnBBCase_Resource_Rel.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvWritingOnBBCase_Resource_RelEN.IdWritingOnBBCase = objRow[convWritingOnBBCase_Resource_Rel.IdWritingOnBBCase].ToString().Trim(); //板书案例流水号
objvWritingOnBBCase_Resource_RelEN.WritingOnBBCaseID = objRow[convWritingOnBBCase_Resource_Rel.WritingOnBBCaseID].ToString().Trim(); //板书教学案例ID
objvWritingOnBBCase_Resource_RelEN.WritingOnBBCaseName = objRow[convWritingOnBBCase_Resource_Rel.WritingOnBBCaseName].ToString().Trim(); //板书教学案例名称
objvWritingOnBBCase_Resource_RelEN.WritingOnBBCaseTheme = objRow[convWritingOnBBCase_Resource_Rel.WritingOnBBCaseTheme] == DBNull.Value ? null : objRow[convWritingOnBBCase_Resource_Rel.WritingOnBBCaseTheme].ToString().Trim(); //板书教学案例主题词
objvWritingOnBBCase_Resource_RelEN.IdDiscipline = objRow[convWritingOnBBCase_Resource_Rel.IdDiscipline].ToString().Trim(); //学科流水号
objvWritingOnBBCase_Resource_RelEN.DisciplineID = objRow[convWritingOnBBCase_Resource_Rel.DisciplineID].ToString().Trim(); //学科ID
objvWritingOnBBCase_Resource_RelEN.DisciplineName = objRow[convWritingOnBBCase_Resource_Rel.DisciplineName].ToString().Trim(); //学科名称
objvWritingOnBBCase_Resource_RelEN.WritingOnBBCaseDate = objRow[convWritingOnBBCase_Resource_Rel.WritingOnBBCaseDate] == DBNull.Value ? null : objRow[convWritingOnBBCase_Resource_Rel.WritingOnBBCaseDate].ToString().Trim(); //板书教学日期
objvWritingOnBBCase_Resource_RelEN.WritingOnBBCaseTime = objRow[convWritingOnBBCase_Resource_Rel.WritingOnBBCaseTime] == DBNull.Value ? null : objRow[convWritingOnBBCase_Resource_Rel.WritingOnBBCaseTime].ToString().Trim(); //板书教学时间
objvWritingOnBBCase_Resource_RelEN.WritingOnBBCaseDateIn = objRow[convWritingOnBBCase_Resource_Rel.WritingOnBBCaseDateIn] == DBNull.Value ? null : objRow[convWritingOnBBCase_Resource_Rel.WritingOnBBCaseDateIn].ToString().Trim(); //案例入库日期
objvWritingOnBBCase_Resource_RelEN.WritingOnBBCaseTimeIn = objRow[convWritingOnBBCase_Resource_Rel.WritingOnBBCaseTimeIn] == DBNull.Value ? null : objRow[convWritingOnBBCase_Resource_Rel.WritingOnBBCaseTimeIn].ToString().Trim(); //案例入库时间
objvWritingOnBBCase_Resource_RelEN.IdStudyLevel = objRow[convWritingOnBBCase_Resource_Rel.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvWritingOnBBCase_Resource_RelEN.StudyLevelName = objRow[convWritingOnBBCase_Resource_Rel.StudyLevelName].ToString().Trim(); //学段名称
objvWritingOnBBCase_Resource_RelEN.CaseLevelId = objRow[convWritingOnBBCase_Resource_Rel.CaseLevelId] == DBNull.Value ? null : objRow[convWritingOnBBCase_Resource_Rel.CaseLevelId].ToString().Trim(); //课例等级Id
objvWritingOnBBCase_Resource_RelEN.senateGaugeVersionID = objRow[convWritingOnBBCase_Resource_Rel.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvWritingOnBBCase_Resource_RelEN.senateGaugeVersionName = objRow[convWritingOnBBCase_Resource_Rel.senateGaugeVersionName] == DBNull.Value ? null : objRow[convWritingOnBBCase_Resource_Rel.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvWritingOnBBCase_Resource_RelEN.senateGaugeVersionTtlScore = TransNullToFloat(objRow[convWritingOnBBCase_Resource_Rel.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvWritingOnBBCase_Resource_RelEN.VersionNo = objRow[convWritingOnBBCase_Resource_Rel.VersionNo] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convWritingOnBBCase_Resource_Rel.VersionNo].ToString().Trim()); //版本号
objvWritingOnBBCase_Resource_RelEN.OwnerId = objRow[convWritingOnBBCase_Resource_Rel.OwnerId] == DBNull.Value ? null : objRow[convWritingOnBBCase_Resource_Rel.OwnerId].ToString().Trim(); //拥有者Id
objvWritingOnBBCase_Resource_RelEN.StuName = objRow[convWritingOnBBCase_Resource_Rel.StuName].ToString().Trim(); //姓名
objvWritingOnBBCase_Resource_RelEN.StuID = objRow[convWritingOnBBCase_Resource_Rel.StuID].ToString().Trim(); //学号
objvWritingOnBBCase_Resource_RelEN.CollegeName = objRow[convWritingOnBBCase_Resource_Rel.CollegeName].ToString().Trim(); //学院名称
objvWritingOnBBCase_Resource_RelEN.IdXzCollege = objRow[convWritingOnBBCase_Resource_Rel.IdXzCollege] == DBNull.Value ? null : objRow[convWritingOnBBCase_Resource_Rel.IdXzCollege].ToString().Trim(); //学院流水号
objvWritingOnBBCase_Resource_RelEN.IdXzMajor = objRow[convWritingOnBBCase_Resource_Rel.IdXzMajor] == DBNull.Value ? null : objRow[convWritingOnBBCase_Resource_Rel.IdXzMajor].ToString().Trim(); //专业流水号
objvWritingOnBBCase_Resource_RelEN.IdGradeBase = objRow[convWritingOnBBCase_Resource_Rel.IdGradeBase] == DBNull.Value ? null : objRow[convWritingOnBBCase_Resource_Rel.IdGradeBase].ToString().Trim(); //年级流水号
objvWritingOnBBCase_Resource_RelEN.IdAdminCls = objRow[convWritingOnBBCase_Resource_Rel.IdAdminCls] == DBNull.Value ? null : objRow[convWritingOnBBCase_Resource_Rel.IdAdminCls].ToString().Trim(); //行政班流水号
objvWritingOnBBCase_Resource_RelEN.CollegeNameA = objRow[convWritingOnBBCase_Resource_Rel.CollegeNameA] == DBNull.Value ? null : objRow[convWritingOnBBCase_Resource_Rel.CollegeNameA].ToString().Trim(); //学院名称简写
objvWritingOnBBCase_Resource_RelEN.IsDualVideo = TransNullToBool(objRow[convWritingOnBBCase_Resource_Rel.IsDualVideo].ToString().Trim()); //是否双视频
objvWritingOnBBCase_Resource_RelEN.RecommendedDegreeId = objRow[convWritingOnBBCase_Resource_Rel.RecommendedDegreeId] == DBNull.Value ? null : objRow[convWritingOnBBCase_Resource_Rel.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvWritingOnBBCase_Resource_RelEN.RecommendedDegreeName = objRow[convWritingOnBBCase_Resource_Rel.RecommendedDegreeName] == DBNull.Value ? null : objRow[convWritingOnBBCase_Resource_Rel.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvWritingOnBBCase_Resource_RelEN.BrowseCount4Case = objRow[convWritingOnBBCase_Resource_Rel.BrowseCount4Case] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convWritingOnBBCase_Resource_Rel.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvWritingOnBBCase_Resource_RelEN.IdResource = objRow[convWritingOnBBCase_Resource_Rel.IdResource].ToString().Trim(); //资源流水号
objvWritingOnBBCase_Resource_RelEN.ResourceID = objRow[convWritingOnBBCase_Resource_Rel.ResourceID].ToString().Trim(); //资源ID
objvWritingOnBBCase_Resource_RelEN.IdFtpResource = objRow[convWritingOnBBCase_Resource_Rel.IdFtpResource] == DBNull.Value ? null : objRow[convWritingOnBBCase_Resource_Rel.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvWritingOnBBCase_Resource_RelEN.IdFile = objRow[convWritingOnBBCase_Resource_Rel.IdFile] == DBNull.Value ? null : objRow[convWritingOnBBCase_Resource_Rel.IdFile].ToString().Trim(); //文件流水号
objvWritingOnBBCase_Resource_RelEN.FileName = objRow[convWritingOnBBCase_Resource_Rel.FileName] == DBNull.Value ? null : objRow[convWritingOnBBCase_Resource_Rel.FileName].ToString().Trim(); //文件名称
objvWritingOnBBCase_Resource_RelEN.FileType = objRow[convWritingOnBBCase_Resource_Rel.FileType] == DBNull.Value ? null : objRow[convWritingOnBBCase_Resource_Rel.FileType].ToString().Trim(); //文件类型
objvWritingOnBBCase_Resource_RelEN.SaveDate = objRow[convWritingOnBBCase_Resource_Rel.SaveDate] == DBNull.Value ? null : objRow[convWritingOnBBCase_Resource_Rel.SaveDate].ToString().Trim(); //创建日期
objvWritingOnBBCase_Resource_RelEN.FileSize = objRow[convWritingOnBBCase_Resource_Rel.FileSize] == DBNull.Value ? null : objRow[convWritingOnBBCase_Resource_Rel.FileSize].ToString().Trim(); //文件大小
objvWritingOnBBCase_Resource_RelEN.SaveTime = objRow[convWritingOnBBCase_Resource_Rel.SaveTime] == DBNull.Value ? null : objRow[convWritingOnBBCase_Resource_Rel.SaveTime].ToString().Trim(); //创建时间
objvWritingOnBBCase_Resource_RelEN.FtpResourceID = objRow[convWritingOnBBCase_Resource_Rel.FtpResourceID].ToString().Trim(); //FTP资源ID
objvWritingOnBBCase_Resource_RelEN.FileOriginalName = objRow[convWritingOnBBCase_Resource_Rel.FileOriginalName] == DBNull.Value ? null : objRow[convWritingOnBBCase_Resource_Rel.FileOriginalName].ToString().Trim(); //文件原名
objvWritingOnBBCase_Resource_RelEN.FileDirName = objRow[convWritingOnBBCase_Resource_Rel.FileDirName] == DBNull.Value ? null : objRow[convWritingOnBBCase_Resource_Rel.FileDirName].ToString().Trim(); //文件目录名
objvWritingOnBBCase_Resource_RelEN.FileRename = objRow[convWritingOnBBCase_Resource_Rel.FileRename] == DBNull.Value ? null : objRow[convWritingOnBBCase_Resource_Rel.FileRename].ToString().Trim(); //文件新名
objvWritingOnBBCase_Resource_RelEN.FileUpDate = objRow[convWritingOnBBCase_Resource_Rel.FileUpDate] == DBNull.Value ? null : objRow[convWritingOnBBCase_Resource_Rel.FileUpDate].ToString().Trim(); //创建日期
objvWritingOnBBCase_Resource_RelEN.FileUpTime = objRow[convWritingOnBBCase_Resource_Rel.FileUpTime] == DBNull.Value ? null : objRow[convWritingOnBBCase_Resource_Rel.FileUpTime].ToString().Trim(); //创建时间
objvWritingOnBBCase_Resource_RelEN.SaveMode = TransNullToBool(objRow[convWritingOnBBCase_Resource_Rel.SaveMode].ToString().Trim()); //文件存放方式
objvWritingOnBBCase_Resource_RelEN.IdResourceType = objRow[convWritingOnBBCase_Resource_Rel.IdResourceType].ToString().Trim(); //资源类型流水号
objvWritingOnBBCase_Resource_RelEN.ResourceTypeID = objRow[convWritingOnBBCase_Resource_Rel.ResourceTypeID].ToString().Trim(); //资源类型ID
objvWritingOnBBCase_Resource_RelEN.ResourceTypeName = objRow[convWritingOnBBCase_Resource_Rel.ResourceTypeName].ToString().Trim(); //资源类型名称
objvWritingOnBBCase_Resource_RelEN.ResourceOwner = objRow[convWritingOnBBCase_Resource_Rel.ResourceOwner].ToString().Trim(); //上传者
objvWritingOnBBCase_Resource_RelEN.ftpFileType = objRow[convWritingOnBBCase_Resource_Rel.ftpFileType] == DBNull.Value ? null : objRow[convWritingOnBBCase_Resource_Rel.ftpFileType].ToString().Trim(); //ftp文件类型
objvWritingOnBBCase_Resource_RelEN.ftpFileSize = objRow[convWritingOnBBCase_Resource_Rel.ftpFileSize] == DBNull.Value ? null : objRow[convWritingOnBBCase_Resource_Rel.ftpFileSize].ToString().Trim(); //ftp文件大小
objvWritingOnBBCase_Resource_RelEN.ftpResourceOwner = objRow[convWritingOnBBCase_Resource_Rel.ftpResourceOwner] == DBNull.Value ? null : objRow[convWritingOnBBCase_Resource_Rel.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvWritingOnBBCase_Resource_RelEN.FileOriginName = objRow[convWritingOnBBCase_Resource_Rel.FileOriginName] == DBNull.Value ? null : objRow[convWritingOnBBCase_Resource_Rel.FileOriginName].ToString().Trim(); //原文件名
objvWritingOnBBCase_Resource_RelEN.IsExistFile = TransNullToBool(objRow[convWritingOnBBCase_Resource_Rel.IsExistFile].ToString().Trim()); //是否存在文件
objvWritingOnBBCase_Resource_RelEN.FileNewName = objRow[convWritingOnBBCase_Resource_Rel.FileNewName] == DBNull.Value ? null : objRow[convWritingOnBBCase_Resource_Rel.FileNewName].ToString().Trim(); //新文件名
objvWritingOnBBCase_Resource_RelEN.FileOldName = objRow[convWritingOnBBCase_Resource_Rel.FileOldName] == DBNull.Value ? null : objRow[convWritingOnBBCase_Resource_Rel.FileOldName].ToString().Trim(); //旧文件名
objvWritingOnBBCase_Resource_RelEN.IsMain = TransNullToBool(objRow[convWritingOnBBCase_Resource_Rel.IsMain].ToString().Trim()); //是否主资源
objvWritingOnBBCase_Resource_RelEN.IdUsingMode = objRow[convWritingOnBBCase_Resource_Rel.IdUsingMode].ToString().Trim(); //资源使用模式流水号
objvWritingOnBBCase_Resource_RelEN.IsVisible = TransNullToBool(objRow[convWritingOnBBCase_Resource_Rel.IsVisible].ToString().Trim()); //是否显示
objvWritingOnBBCase_Resource_RelEN.IndexNO = objRow[convWritingOnBBCase_Resource_Rel.IndexNO] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convWritingOnBBCase_Resource_Rel.IndexNO].ToString().Trim()); //序号
objvWritingOnBBCase_Resource_RelEN.BrowseCount = objRow[convWritingOnBBCase_Resource_Rel.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convWritingOnBBCase_Resource_Rel.BrowseCount].ToString().Trim()); //浏览次数
objvWritingOnBBCase_Resource_RelEN.UpdDate = objRow[convWritingOnBBCase_Resource_Rel.UpdDate] == DBNull.Value ? null : objRow[convWritingOnBBCase_Resource_Rel.UpdDate].ToString().Trim(); //修改日期
objvWritingOnBBCase_Resource_RelEN.UpdUser = objRow[convWritingOnBBCase_Resource_Rel.UpdUser] == DBNull.Value ? null : objRow[convWritingOnBBCase_Resource_Rel.UpdUser].ToString().Trim(); //修改人
objvWritingOnBBCase_Resource_RelEN.Memo = objRow[convWritingOnBBCase_Resource_Rel.Memo] == DBNull.Value ? null : objRow[convWritingOnBBCase_Resource_Rel.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvWritingOnBBCase_Resource_RelDA: GetObjByDataRowvWritingOnBBCase_Resource_Rel)", objException.Message));
}
objvWritingOnBBCase_Resource_RelEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvWritingOnBBCase_Resource_RelEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvWritingOnBBCase_Resource_RelEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvWritingOnBBCase_Resource_RelEN objvWritingOnBBCase_Resource_RelEN = new clsvWritingOnBBCase_Resource_RelEN();
try
{
objvWritingOnBBCase_Resource_RelEN.IdMicroteachCaseResourceRel = TransNullToInt(objRow[convWritingOnBBCase_Resource_Rel.IdMicroteachCaseResourceRel].ToString().Trim()); //微格案例资源关系流水号
objvWritingOnBBCase_Resource_RelEN.FuncModuleId = objRow[convWritingOnBBCase_Resource_Rel.FuncModuleId].ToString().Trim(); //功能模块Id
objvWritingOnBBCase_Resource_RelEN.FuncModuleName = objRow[convWritingOnBBCase_Resource_Rel.FuncModuleName] == DBNull.Value ? null : objRow[convWritingOnBBCase_Resource_Rel.FuncModuleName].ToString().Trim(); //功能模块名称
objvWritingOnBBCase_Resource_RelEN.IdMicroteachCase = objRow[convWritingOnBBCase_Resource_Rel.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvWritingOnBBCase_Resource_RelEN.IdWritingOnBBCase = objRow[convWritingOnBBCase_Resource_Rel.IdWritingOnBBCase].ToString().Trim(); //板书案例流水号
objvWritingOnBBCase_Resource_RelEN.WritingOnBBCaseID = objRow[convWritingOnBBCase_Resource_Rel.WritingOnBBCaseID].ToString().Trim(); //板书教学案例ID
objvWritingOnBBCase_Resource_RelEN.WritingOnBBCaseName = objRow[convWritingOnBBCase_Resource_Rel.WritingOnBBCaseName].ToString().Trim(); //板书教学案例名称
objvWritingOnBBCase_Resource_RelEN.WritingOnBBCaseTheme = objRow[convWritingOnBBCase_Resource_Rel.WritingOnBBCaseTheme] == DBNull.Value ? null : objRow[convWritingOnBBCase_Resource_Rel.WritingOnBBCaseTheme].ToString().Trim(); //板书教学案例主题词
objvWritingOnBBCase_Resource_RelEN.IdDiscipline = objRow[convWritingOnBBCase_Resource_Rel.IdDiscipline].ToString().Trim(); //学科流水号
objvWritingOnBBCase_Resource_RelEN.DisciplineID = objRow[convWritingOnBBCase_Resource_Rel.DisciplineID].ToString().Trim(); //学科ID
objvWritingOnBBCase_Resource_RelEN.DisciplineName = objRow[convWritingOnBBCase_Resource_Rel.DisciplineName].ToString().Trim(); //学科名称
objvWritingOnBBCase_Resource_RelEN.WritingOnBBCaseDate = objRow[convWritingOnBBCase_Resource_Rel.WritingOnBBCaseDate] == DBNull.Value ? null : objRow[convWritingOnBBCase_Resource_Rel.WritingOnBBCaseDate].ToString().Trim(); //板书教学日期
objvWritingOnBBCase_Resource_RelEN.WritingOnBBCaseTime = objRow[convWritingOnBBCase_Resource_Rel.WritingOnBBCaseTime] == DBNull.Value ? null : objRow[convWritingOnBBCase_Resource_Rel.WritingOnBBCaseTime].ToString().Trim(); //板书教学时间
objvWritingOnBBCase_Resource_RelEN.WritingOnBBCaseDateIn = objRow[convWritingOnBBCase_Resource_Rel.WritingOnBBCaseDateIn] == DBNull.Value ? null : objRow[convWritingOnBBCase_Resource_Rel.WritingOnBBCaseDateIn].ToString().Trim(); //案例入库日期
objvWritingOnBBCase_Resource_RelEN.WritingOnBBCaseTimeIn = objRow[convWritingOnBBCase_Resource_Rel.WritingOnBBCaseTimeIn] == DBNull.Value ? null : objRow[convWritingOnBBCase_Resource_Rel.WritingOnBBCaseTimeIn].ToString().Trim(); //案例入库时间
objvWritingOnBBCase_Resource_RelEN.IdStudyLevel = objRow[convWritingOnBBCase_Resource_Rel.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvWritingOnBBCase_Resource_RelEN.StudyLevelName = objRow[convWritingOnBBCase_Resource_Rel.StudyLevelName].ToString().Trim(); //学段名称
objvWritingOnBBCase_Resource_RelEN.CaseLevelId = objRow[convWritingOnBBCase_Resource_Rel.CaseLevelId] == DBNull.Value ? null : objRow[convWritingOnBBCase_Resource_Rel.CaseLevelId].ToString().Trim(); //课例等级Id
objvWritingOnBBCase_Resource_RelEN.senateGaugeVersionID = objRow[convWritingOnBBCase_Resource_Rel.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvWritingOnBBCase_Resource_RelEN.senateGaugeVersionName = objRow[convWritingOnBBCase_Resource_Rel.senateGaugeVersionName] == DBNull.Value ? null : objRow[convWritingOnBBCase_Resource_Rel.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvWritingOnBBCase_Resource_RelEN.senateGaugeVersionTtlScore = TransNullToFloat(objRow[convWritingOnBBCase_Resource_Rel.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvWritingOnBBCase_Resource_RelEN.VersionNo = objRow[convWritingOnBBCase_Resource_Rel.VersionNo] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convWritingOnBBCase_Resource_Rel.VersionNo].ToString().Trim()); //版本号
objvWritingOnBBCase_Resource_RelEN.OwnerId = objRow[convWritingOnBBCase_Resource_Rel.OwnerId] == DBNull.Value ? null : objRow[convWritingOnBBCase_Resource_Rel.OwnerId].ToString().Trim(); //拥有者Id
objvWritingOnBBCase_Resource_RelEN.StuName = objRow[convWritingOnBBCase_Resource_Rel.StuName].ToString().Trim(); //姓名
objvWritingOnBBCase_Resource_RelEN.StuID = objRow[convWritingOnBBCase_Resource_Rel.StuID].ToString().Trim(); //学号
objvWritingOnBBCase_Resource_RelEN.CollegeName = objRow[convWritingOnBBCase_Resource_Rel.CollegeName].ToString().Trim(); //学院名称
objvWritingOnBBCase_Resource_RelEN.IdXzCollege = objRow[convWritingOnBBCase_Resource_Rel.IdXzCollege] == DBNull.Value ? null : objRow[convWritingOnBBCase_Resource_Rel.IdXzCollege].ToString().Trim(); //学院流水号
objvWritingOnBBCase_Resource_RelEN.IdXzMajor = objRow[convWritingOnBBCase_Resource_Rel.IdXzMajor] == DBNull.Value ? null : objRow[convWritingOnBBCase_Resource_Rel.IdXzMajor].ToString().Trim(); //专业流水号
objvWritingOnBBCase_Resource_RelEN.IdGradeBase = objRow[convWritingOnBBCase_Resource_Rel.IdGradeBase] == DBNull.Value ? null : objRow[convWritingOnBBCase_Resource_Rel.IdGradeBase].ToString().Trim(); //年级流水号
objvWritingOnBBCase_Resource_RelEN.IdAdminCls = objRow[convWritingOnBBCase_Resource_Rel.IdAdminCls] == DBNull.Value ? null : objRow[convWritingOnBBCase_Resource_Rel.IdAdminCls].ToString().Trim(); //行政班流水号
objvWritingOnBBCase_Resource_RelEN.CollegeNameA = objRow[convWritingOnBBCase_Resource_Rel.CollegeNameA] == DBNull.Value ? null : objRow[convWritingOnBBCase_Resource_Rel.CollegeNameA].ToString().Trim(); //学院名称简写
objvWritingOnBBCase_Resource_RelEN.IsDualVideo = TransNullToBool(objRow[convWritingOnBBCase_Resource_Rel.IsDualVideo].ToString().Trim()); //是否双视频
objvWritingOnBBCase_Resource_RelEN.RecommendedDegreeId = objRow[convWritingOnBBCase_Resource_Rel.RecommendedDegreeId] == DBNull.Value ? null : objRow[convWritingOnBBCase_Resource_Rel.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvWritingOnBBCase_Resource_RelEN.RecommendedDegreeName = objRow[convWritingOnBBCase_Resource_Rel.RecommendedDegreeName] == DBNull.Value ? null : objRow[convWritingOnBBCase_Resource_Rel.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvWritingOnBBCase_Resource_RelEN.BrowseCount4Case = objRow[convWritingOnBBCase_Resource_Rel.BrowseCount4Case] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convWritingOnBBCase_Resource_Rel.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvWritingOnBBCase_Resource_RelEN.IdResource = objRow[convWritingOnBBCase_Resource_Rel.IdResource].ToString().Trim(); //资源流水号
objvWritingOnBBCase_Resource_RelEN.ResourceID = objRow[convWritingOnBBCase_Resource_Rel.ResourceID].ToString().Trim(); //资源ID
objvWritingOnBBCase_Resource_RelEN.IdFtpResource = objRow[convWritingOnBBCase_Resource_Rel.IdFtpResource] == DBNull.Value ? null : objRow[convWritingOnBBCase_Resource_Rel.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvWritingOnBBCase_Resource_RelEN.IdFile = objRow[convWritingOnBBCase_Resource_Rel.IdFile] == DBNull.Value ? null : objRow[convWritingOnBBCase_Resource_Rel.IdFile].ToString().Trim(); //文件流水号
objvWritingOnBBCase_Resource_RelEN.FileName = objRow[convWritingOnBBCase_Resource_Rel.FileName] == DBNull.Value ? null : objRow[convWritingOnBBCase_Resource_Rel.FileName].ToString().Trim(); //文件名称
objvWritingOnBBCase_Resource_RelEN.FileType = objRow[convWritingOnBBCase_Resource_Rel.FileType] == DBNull.Value ? null : objRow[convWritingOnBBCase_Resource_Rel.FileType].ToString().Trim(); //文件类型
objvWritingOnBBCase_Resource_RelEN.SaveDate = objRow[convWritingOnBBCase_Resource_Rel.SaveDate] == DBNull.Value ? null : objRow[convWritingOnBBCase_Resource_Rel.SaveDate].ToString().Trim(); //创建日期
objvWritingOnBBCase_Resource_RelEN.FileSize = objRow[convWritingOnBBCase_Resource_Rel.FileSize] == DBNull.Value ? null : objRow[convWritingOnBBCase_Resource_Rel.FileSize].ToString().Trim(); //文件大小
objvWritingOnBBCase_Resource_RelEN.SaveTime = objRow[convWritingOnBBCase_Resource_Rel.SaveTime] == DBNull.Value ? null : objRow[convWritingOnBBCase_Resource_Rel.SaveTime].ToString().Trim(); //创建时间
objvWritingOnBBCase_Resource_RelEN.FtpResourceID = objRow[convWritingOnBBCase_Resource_Rel.FtpResourceID].ToString().Trim(); //FTP资源ID
objvWritingOnBBCase_Resource_RelEN.FileOriginalName = objRow[convWritingOnBBCase_Resource_Rel.FileOriginalName] == DBNull.Value ? null : objRow[convWritingOnBBCase_Resource_Rel.FileOriginalName].ToString().Trim(); //文件原名
objvWritingOnBBCase_Resource_RelEN.FileDirName = objRow[convWritingOnBBCase_Resource_Rel.FileDirName] == DBNull.Value ? null : objRow[convWritingOnBBCase_Resource_Rel.FileDirName].ToString().Trim(); //文件目录名
objvWritingOnBBCase_Resource_RelEN.FileRename = objRow[convWritingOnBBCase_Resource_Rel.FileRename] == DBNull.Value ? null : objRow[convWritingOnBBCase_Resource_Rel.FileRename].ToString().Trim(); //文件新名
objvWritingOnBBCase_Resource_RelEN.FileUpDate = objRow[convWritingOnBBCase_Resource_Rel.FileUpDate] == DBNull.Value ? null : objRow[convWritingOnBBCase_Resource_Rel.FileUpDate].ToString().Trim(); //创建日期
objvWritingOnBBCase_Resource_RelEN.FileUpTime = objRow[convWritingOnBBCase_Resource_Rel.FileUpTime] == DBNull.Value ? null : objRow[convWritingOnBBCase_Resource_Rel.FileUpTime].ToString().Trim(); //创建时间
objvWritingOnBBCase_Resource_RelEN.SaveMode = TransNullToBool(objRow[convWritingOnBBCase_Resource_Rel.SaveMode].ToString().Trim()); //文件存放方式
objvWritingOnBBCase_Resource_RelEN.IdResourceType = objRow[convWritingOnBBCase_Resource_Rel.IdResourceType].ToString().Trim(); //资源类型流水号
objvWritingOnBBCase_Resource_RelEN.ResourceTypeID = objRow[convWritingOnBBCase_Resource_Rel.ResourceTypeID].ToString().Trim(); //资源类型ID
objvWritingOnBBCase_Resource_RelEN.ResourceTypeName = objRow[convWritingOnBBCase_Resource_Rel.ResourceTypeName].ToString().Trim(); //资源类型名称
objvWritingOnBBCase_Resource_RelEN.ResourceOwner = objRow[convWritingOnBBCase_Resource_Rel.ResourceOwner].ToString().Trim(); //上传者
objvWritingOnBBCase_Resource_RelEN.ftpFileType = objRow[convWritingOnBBCase_Resource_Rel.ftpFileType] == DBNull.Value ? null : objRow[convWritingOnBBCase_Resource_Rel.ftpFileType].ToString().Trim(); //ftp文件类型
objvWritingOnBBCase_Resource_RelEN.ftpFileSize = objRow[convWritingOnBBCase_Resource_Rel.ftpFileSize] == DBNull.Value ? null : objRow[convWritingOnBBCase_Resource_Rel.ftpFileSize].ToString().Trim(); //ftp文件大小
objvWritingOnBBCase_Resource_RelEN.ftpResourceOwner = objRow[convWritingOnBBCase_Resource_Rel.ftpResourceOwner] == DBNull.Value ? null : objRow[convWritingOnBBCase_Resource_Rel.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvWritingOnBBCase_Resource_RelEN.FileOriginName = objRow[convWritingOnBBCase_Resource_Rel.FileOriginName] == DBNull.Value ? null : objRow[convWritingOnBBCase_Resource_Rel.FileOriginName].ToString().Trim(); //原文件名
objvWritingOnBBCase_Resource_RelEN.IsExistFile = TransNullToBool(objRow[convWritingOnBBCase_Resource_Rel.IsExistFile].ToString().Trim()); //是否存在文件
objvWritingOnBBCase_Resource_RelEN.FileNewName = objRow[convWritingOnBBCase_Resource_Rel.FileNewName] == DBNull.Value ? null : objRow[convWritingOnBBCase_Resource_Rel.FileNewName].ToString().Trim(); //新文件名
objvWritingOnBBCase_Resource_RelEN.FileOldName = objRow[convWritingOnBBCase_Resource_Rel.FileOldName] == DBNull.Value ? null : objRow[convWritingOnBBCase_Resource_Rel.FileOldName].ToString().Trim(); //旧文件名
objvWritingOnBBCase_Resource_RelEN.IsMain = TransNullToBool(objRow[convWritingOnBBCase_Resource_Rel.IsMain].ToString().Trim()); //是否主资源
objvWritingOnBBCase_Resource_RelEN.IdUsingMode = objRow[convWritingOnBBCase_Resource_Rel.IdUsingMode].ToString().Trim(); //资源使用模式流水号
objvWritingOnBBCase_Resource_RelEN.IsVisible = TransNullToBool(objRow[convWritingOnBBCase_Resource_Rel.IsVisible].ToString().Trim()); //是否显示
objvWritingOnBBCase_Resource_RelEN.IndexNO = objRow[convWritingOnBBCase_Resource_Rel.IndexNO] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convWritingOnBBCase_Resource_Rel.IndexNO].ToString().Trim()); //序号
objvWritingOnBBCase_Resource_RelEN.BrowseCount = objRow[convWritingOnBBCase_Resource_Rel.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convWritingOnBBCase_Resource_Rel.BrowseCount].ToString().Trim()); //浏览次数
objvWritingOnBBCase_Resource_RelEN.UpdDate = objRow[convWritingOnBBCase_Resource_Rel.UpdDate] == DBNull.Value ? null : objRow[convWritingOnBBCase_Resource_Rel.UpdDate].ToString().Trim(); //修改日期
objvWritingOnBBCase_Resource_RelEN.UpdUser = objRow[convWritingOnBBCase_Resource_Rel.UpdUser] == DBNull.Value ? null : objRow[convWritingOnBBCase_Resource_Rel.UpdUser].ToString().Trim(); //修改人
objvWritingOnBBCase_Resource_RelEN.Memo = objRow[convWritingOnBBCase_Resource_Rel.Memo] == DBNull.Value ? null : objRow[convWritingOnBBCase_Resource_Rel.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvWritingOnBBCase_Resource_RelDA: GetObjByDataRow)", objException.Message));
}
objvWritingOnBBCase_Resource_RelEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvWritingOnBBCase_Resource_RelEN;
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
objSQL = clsvWritingOnBBCase_Resource_RelDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvWritingOnBBCase_Resource_RelEN._CurrTabName, convWritingOnBBCase_Resource_Rel.IdMicroteachCaseResourceRel, 8, "");
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
objSQL = clsvWritingOnBBCase_Resource_RelDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvWritingOnBBCase_Resource_RelEN._CurrTabName, convWritingOnBBCase_Resource_Rel.IdMicroteachCaseResourceRel, 8, strPrefix);
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
 objSQL = clsvWritingOnBBCase_Resource_RelDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select IdMicroteachCaseResourceRel from vWritingOnBBCase_Resource_Rel where " + strCondition;
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
 objSQL = clsvWritingOnBBCase_Resource_RelDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select IdMicroteachCaseResourceRel from vWritingOnBBCase_Resource_Rel where " + strCondition;
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
 /// <param name = "lngIdMicroteachCaseResourceRel">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(long lngIdMicroteachCaseResourceRel)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvWritingOnBBCase_Resource_RelDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vWritingOnBBCase_Resource_Rel", "IdMicroteachCaseResourceRel = " + ""+ lngIdMicroteachCaseResourceRel+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvWritingOnBBCase_Resource_RelDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvWritingOnBBCase_Resource_RelDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vWritingOnBBCase_Resource_Rel", strCondition))
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
objSQL = clsvWritingOnBBCase_Resource_RelDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vWritingOnBBCase_Resource_Rel");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvWritingOnBBCase_Resource_RelENS">源对象</param>
 /// <param name = "objvWritingOnBBCase_Resource_RelENT">目标对象</param>
public void CopyTo(clsvWritingOnBBCase_Resource_RelEN objvWritingOnBBCase_Resource_RelENS, clsvWritingOnBBCase_Resource_RelEN objvWritingOnBBCase_Resource_RelENT)
{
objvWritingOnBBCase_Resource_RelENT.IdMicroteachCaseResourceRel = objvWritingOnBBCase_Resource_RelENS.IdMicroteachCaseResourceRel; //微格案例资源关系流水号
objvWritingOnBBCase_Resource_RelENT.FuncModuleId = objvWritingOnBBCase_Resource_RelENS.FuncModuleId; //功能模块Id
objvWritingOnBBCase_Resource_RelENT.FuncModuleName = objvWritingOnBBCase_Resource_RelENS.FuncModuleName; //功能模块名称
objvWritingOnBBCase_Resource_RelENT.IdMicroteachCase = objvWritingOnBBCase_Resource_RelENS.IdMicroteachCase; //微格教学案例流水号
objvWritingOnBBCase_Resource_RelENT.IdWritingOnBBCase = objvWritingOnBBCase_Resource_RelENS.IdWritingOnBBCase; //板书案例流水号
objvWritingOnBBCase_Resource_RelENT.WritingOnBBCaseID = objvWritingOnBBCase_Resource_RelENS.WritingOnBBCaseID; //板书教学案例ID
objvWritingOnBBCase_Resource_RelENT.WritingOnBBCaseName = objvWritingOnBBCase_Resource_RelENS.WritingOnBBCaseName; //板书教学案例名称
objvWritingOnBBCase_Resource_RelENT.WritingOnBBCaseTheme = objvWritingOnBBCase_Resource_RelENS.WritingOnBBCaseTheme; //板书教学案例主题词
objvWritingOnBBCase_Resource_RelENT.IdDiscipline = objvWritingOnBBCase_Resource_RelENS.IdDiscipline; //学科流水号
objvWritingOnBBCase_Resource_RelENT.DisciplineID = objvWritingOnBBCase_Resource_RelENS.DisciplineID; //学科ID
objvWritingOnBBCase_Resource_RelENT.DisciplineName = objvWritingOnBBCase_Resource_RelENS.DisciplineName; //学科名称
objvWritingOnBBCase_Resource_RelENT.WritingOnBBCaseDate = objvWritingOnBBCase_Resource_RelENS.WritingOnBBCaseDate; //板书教学日期
objvWritingOnBBCase_Resource_RelENT.WritingOnBBCaseTime = objvWritingOnBBCase_Resource_RelENS.WritingOnBBCaseTime; //板书教学时间
objvWritingOnBBCase_Resource_RelENT.WritingOnBBCaseDateIn = objvWritingOnBBCase_Resource_RelENS.WritingOnBBCaseDateIn; //案例入库日期
objvWritingOnBBCase_Resource_RelENT.WritingOnBBCaseTimeIn = objvWritingOnBBCase_Resource_RelENS.WritingOnBBCaseTimeIn; //案例入库时间
objvWritingOnBBCase_Resource_RelENT.IdStudyLevel = objvWritingOnBBCase_Resource_RelENS.IdStudyLevel; //id_StudyLevel
objvWritingOnBBCase_Resource_RelENT.StudyLevelName = objvWritingOnBBCase_Resource_RelENS.StudyLevelName; //学段名称
objvWritingOnBBCase_Resource_RelENT.CaseLevelId = objvWritingOnBBCase_Resource_RelENS.CaseLevelId; //课例等级Id
objvWritingOnBBCase_Resource_RelENT.senateGaugeVersionID = objvWritingOnBBCase_Resource_RelENS.senateGaugeVersionID; //评价量表版本ID
objvWritingOnBBCase_Resource_RelENT.senateGaugeVersionName = objvWritingOnBBCase_Resource_RelENS.senateGaugeVersionName; //评价量表版本名称
objvWritingOnBBCase_Resource_RelENT.senateGaugeVersionTtlScore = objvWritingOnBBCase_Resource_RelENS.senateGaugeVersionTtlScore; //评价量表版本总分
objvWritingOnBBCase_Resource_RelENT.VersionNo = objvWritingOnBBCase_Resource_RelENS.VersionNo; //版本号
objvWritingOnBBCase_Resource_RelENT.OwnerId = objvWritingOnBBCase_Resource_RelENS.OwnerId; //拥有者Id
objvWritingOnBBCase_Resource_RelENT.StuName = objvWritingOnBBCase_Resource_RelENS.StuName; //姓名
objvWritingOnBBCase_Resource_RelENT.StuID = objvWritingOnBBCase_Resource_RelENS.StuID; //学号
objvWritingOnBBCase_Resource_RelENT.CollegeName = objvWritingOnBBCase_Resource_RelENS.CollegeName; //学院名称
objvWritingOnBBCase_Resource_RelENT.IdXzCollege = objvWritingOnBBCase_Resource_RelENS.IdXzCollege; //学院流水号
objvWritingOnBBCase_Resource_RelENT.IdXzMajor = objvWritingOnBBCase_Resource_RelENS.IdXzMajor; //专业流水号
objvWritingOnBBCase_Resource_RelENT.IdGradeBase = objvWritingOnBBCase_Resource_RelENS.IdGradeBase; //年级流水号
objvWritingOnBBCase_Resource_RelENT.IdAdminCls = objvWritingOnBBCase_Resource_RelENS.IdAdminCls; //行政班流水号
objvWritingOnBBCase_Resource_RelENT.CollegeNameA = objvWritingOnBBCase_Resource_RelENS.CollegeNameA; //学院名称简写
objvWritingOnBBCase_Resource_RelENT.IsDualVideo = objvWritingOnBBCase_Resource_RelENS.IsDualVideo; //是否双视频
objvWritingOnBBCase_Resource_RelENT.RecommendedDegreeId = objvWritingOnBBCase_Resource_RelENS.RecommendedDegreeId; //推荐度Id
objvWritingOnBBCase_Resource_RelENT.RecommendedDegreeName = objvWritingOnBBCase_Resource_RelENS.RecommendedDegreeName; //推荐度名称
objvWritingOnBBCase_Resource_RelENT.BrowseCount4Case = objvWritingOnBBCase_Resource_RelENS.BrowseCount4Case; //课例浏览次数
objvWritingOnBBCase_Resource_RelENT.IdResource = objvWritingOnBBCase_Resource_RelENS.IdResource; //资源流水号
objvWritingOnBBCase_Resource_RelENT.ResourceID = objvWritingOnBBCase_Resource_RelENS.ResourceID; //资源ID
objvWritingOnBBCase_Resource_RelENT.IdFtpResource = objvWritingOnBBCase_Resource_RelENS.IdFtpResource; //FTP资源流水号
objvWritingOnBBCase_Resource_RelENT.IdFile = objvWritingOnBBCase_Resource_RelENS.IdFile; //文件流水号
objvWritingOnBBCase_Resource_RelENT.FileName = objvWritingOnBBCase_Resource_RelENS.FileName; //文件名称
objvWritingOnBBCase_Resource_RelENT.FileType = objvWritingOnBBCase_Resource_RelENS.FileType; //文件类型
objvWritingOnBBCase_Resource_RelENT.SaveDate = objvWritingOnBBCase_Resource_RelENS.SaveDate; //创建日期
objvWritingOnBBCase_Resource_RelENT.FileSize = objvWritingOnBBCase_Resource_RelENS.FileSize; //文件大小
objvWritingOnBBCase_Resource_RelENT.SaveTime = objvWritingOnBBCase_Resource_RelENS.SaveTime; //创建时间
objvWritingOnBBCase_Resource_RelENT.FtpResourceID = objvWritingOnBBCase_Resource_RelENS.FtpResourceID; //FTP资源ID
objvWritingOnBBCase_Resource_RelENT.FileOriginalName = objvWritingOnBBCase_Resource_RelENS.FileOriginalName; //文件原名
objvWritingOnBBCase_Resource_RelENT.FileDirName = objvWritingOnBBCase_Resource_RelENS.FileDirName; //文件目录名
objvWritingOnBBCase_Resource_RelENT.FileRename = objvWritingOnBBCase_Resource_RelENS.FileRename; //文件新名
objvWritingOnBBCase_Resource_RelENT.FileUpDate = objvWritingOnBBCase_Resource_RelENS.FileUpDate; //创建日期
objvWritingOnBBCase_Resource_RelENT.FileUpTime = objvWritingOnBBCase_Resource_RelENS.FileUpTime; //创建时间
objvWritingOnBBCase_Resource_RelENT.SaveMode = objvWritingOnBBCase_Resource_RelENS.SaveMode; //文件存放方式
objvWritingOnBBCase_Resource_RelENT.IdResourceType = objvWritingOnBBCase_Resource_RelENS.IdResourceType; //资源类型流水号
objvWritingOnBBCase_Resource_RelENT.ResourceTypeID = objvWritingOnBBCase_Resource_RelENS.ResourceTypeID; //资源类型ID
objvWritingOnBBCase_Resource_RelENT.ResourceTypeName = objvWritingOnBBCase_Resource_RelENS.ResourceTypeName; //资源类型名称
objvWritingOnBBCase_Resource_RelENT.ResourceOwner = objvWritingOnBBCase_Resource_RelENS.ResourceOwner; //上传者
objvWritingOnBBCase_Resource_RelENT.ftpFileType = objvWritingOnBBCase_Resource_RelENS.ftpFileType; //ftp文件类型
objvWritingOnBBCase_Resource_RelENT.ftpFileSize = objvWritingOnBBCase_Resource_RelENS.ftpFileSize; //ftp文件大小
objvWritingOnBBCase_Resource_RelENT.ftpResourceOwner = objvWritingOnBBCase_Resource_RelENS.ftpResourceOwner; //Ftp资源拥有者
objvWritingOnBBCase_Resource_RelENT.FileOriginName = objvWritingOnBBCase_Resource_RelENS.FileOriginName; //原文件名
objvWritingOnBBCase_Resource_RelENT.IsExistFile = objvWritingOnBBCase_Resource_RelENS.IsExistFile; //是否存在文件
objvWritingOnBBCase_Resource_RelENT.FileNewName = objvWritingOnBBCase_Resource_RelENS.FileNewName; //新文件名
objvWritingOnBBCase_Resource_RelENT.FileOldName = objvWritingOnBBCase_Resource_RelENS.FileOldName; //旧文件名
objvWritingOnBBCase_Resource_RelENT.IsMain = objvWritingOnBBCase_Resource_RelENS.IsMain; //是否主资源
objvWritingOnBBCase_Resource_RelENT.IdUsingMode = objvWritingOnBBCase_Resource_RelENS.IdUsingMode; //资源使用模式流水号
objvWritingOnBBCase_Resource_RelENT.IsVisible = objvWritingOnBBCase_Resource_RelENS.IsVisible; //是否显示
objvWritingOnBBCase_Resource_RelENT.IndexNO = objvWritingOnBBCase_Resource_RelENS.IndexNO; //序号
objvWritingOnBBCase_Resource_RelENT.BrowseCount = objvWritingOnBBCase_Resource_RelENS.BrowseCount; //浏览次数
objvWritingOnBBCase_Resource_RelENT.UpdDate = objvWritingOnBBCase_Resource_RelENS.UpdDate; //修改日期
objvWritingOnBBCase_Resource_RelENT.UpdUser = objvWritingOnBBCase_Resource_RelENS.UpdUser; //修改人
objvWritingOnBBCase_Resource_RelENT.Memo = objvWritingOnBBCase_Resource_RelENS.Memo; //备注
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvWritingOnBBCase_Resource_RelEN objvWritingOnBBCase_Resource_RelEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvWritingOnBBCase_Resource_RelEN.FuncModuleId, 4, convWritingOnBBCase_Resource_Rel.FuncModuleId);
clsCheckSql.CheckFieldLen(objvWritingOnBBCase_Resource_RelEN.FuncModuleName, 30, convWritingOnBBCase_Resource_Rel.FuncModuleName);
clsCheckSql.CheckFieldLen(objvWritingOnBBCase_Resource_RelEN.IdMicroteachCase, 8, convWritingOnBBCase_Resource_Rel.IdMicroteachCase);
clsCheckSql.CheckFieldLen(objvWritingOnBBCase_Resource_RelEN.IdWritingOnBBCase, 8, convWritingOnBBCase_Resource_Rel.IdWritingOnBBCase);
clsCheckSql.CheckFieldLen(objvWritingOnBBCase_Resource_RelEN.WritingOnBBCaseID, 8, convWritingOnBBCase_Resource_Rel.WritingOnBBCaseID);
clsCheckSql.CheckFieldLen(objvWritingOnBBCase_Resource_RelEN.WritingOnBBCaseName, 100, convWritingOnBBCase_Resource_Rel.WritingOnBBCaseName);
clsCheckSql.CheckFieldLen(objvWritingOnBBCase_Resource_RelEN.WritingOnBBCaseTheme, 200, convWritingOnBBCase_Resource_Rel.WritingOnBBCaseTheme);
clsCheckSql.CheckFieldLen(objvWritingOnBBCase_Resource_RelEN.IdDiscipline, 4, convWritingOnBBCase_Resource_Rel.IdDiscipline);
clsCheckSql.CheckFieldLen(objvWritingOnBBCase_Resource_RelEN.DisciplineID, 4, convWritingOnBBCase_Resource_Rel.DisciplineID);
clsCheckSql.CheckFieldLen(objvWritingOnBBCase_Resource_RelEN.DisciplineName, 50, convWritingOnBBCase_Resource_Rel.DisciplineName);
clsCheckSql.CheckFieldLen(objvWritingOnBBCase_Resource_RelEN.WritingOnBBCaseDate, 8, convWritingOnBBCase_Resource_Rel.WritingOnBBCaseDate);
clsCheckSql.CheckFieldLen(objvWritingOnBBCase_Resource_RelEN.WritingOnBBCaseTime, 6, convWritingOnBBCase_Resource_Rel.WritingOnBBCaseTime);
clsCheckSql.CheckFieldLen(objvWritingOnBBCase_Resource_RelEN.WritingOnBBCaseDateIn, 8, convWritingOnBBCase_Resource_Rel.WritingOnBBCaseDateIn);
clsCheckSql.CheckFieldLen(objvWritingOnBBCase_Resource_RelEN.WritingOnBBCaseTimeIn, 6, convWritingOnBBCase_Resource_Rel.WritingOnBBCaseTimeIn);
clsCheckSql.CheckFieldLen(objvWritingOnBBCase_Resource_RelEN.IdStudyLevel, 4, convWritingOnBBCase_Resource_Rel.IdStudyLevel);
clsCheckSql.CheckFieldLen(objvWritingOnBBCase_Resource_RelEN.StudyLevelName, 50, convWritingOnBBCase_Resource_Rel.StudyLevelName);
clsCheckSql.CheckFieldLen(objvWritingOnBBCase_Resource_RelEN.CaseLevelId, 2, convWritingOnBBCase_Resource_Rel.CaseLevelId);
clsCheckSql.CheckFieldLen(objvWritingOnBBCase_Resource_RelEN.senateGaugeVersionID, 4, convWritingOnBBCase_Resource_Rel.senateGaugeVersionID);
clsCheckSql.CheckFieldLen(objvWritingOnBBCase_Resource_RelEN.senateGaugeVersionName, 200, convWritingOnBBCase_Resource_Rel.senateGaugeVersionName);
clsCheckSql.CheckFieldLen(objvWritingOnBBCase_Resource_RelEN.OwnerId, 20, convWritingOnBBCase_Resource_Rel.OwnerId);
clsCheckSql.CheckFieldLen(objvWritingOnBBCase_Resource_RelEN.StuName, 50, convWritingOnBBCase_Resource_Rel.StuName);
clsCheckSql.CheckFieldLen(objvWritingOnBBCase_Resource_RelEN.StuID, 20, convWritingOnBBCase_Resource_Rel.StuID);
clsCheckSql.CheckFieldLen(objvWritingOnBBCase_Resource_RelEN.CollegeName, 100, convWritingOnBBCase_Resource_Rel.CollegeName);
clsCheckSql.CheckFieldLen(objvWritingOnBBCase_Resource_RelEN.IdXzCollege, 4, convWritingOnBBCase_Resource_Rel.IdXzCollege);
clsCheckSql.CheckFieldLen(objvWritingOnBBCase_Resource_RelEN.IdXzMajor, 8, convWritingOnBBCase_Resource_Rel.IdXzMajor);
clsCheckSql.CheckFieldLen(objvWritingOnBBCase_Resource_RelEN.IdGradeBase, 4, convWritingOnBBCase_Resource_Rel.IdGradeBase);
clsCheckSql.CheckFieldLen(objvWritingOnBBCase_Resource_RelEN.IdAdminCls, 8, convWritingOnBBCase_Resource_Rel.IdAdminCls);
clsCheckSql.CheckFieldLen(objvWritingOnBBCase_Resource_RelEN.CollegeNameA, 12, convWritingOnBBCase_Resource_Rel.CollegeNameA);
clsCheckSql.CheckFieldLen(objvWritingOnBBCase_Resource_RelEN.RecommendedDegreeId, 2, convWritingOnBBCase_Resource_Rel.RecommendedDegreeId);
clsCheckSql.CheckFieldLen(objvWritingOnBBCase_Resource_RelEN.RecommendedDegreeName, 30, convWritingOnBBCase_Resource_Rel.RecommendedDegreeName);
clsCheckSql.CheckFieldLen(objvWritingOnBBCase_Resource_RelEN.IdResource, 8, convWritingOnBBCase_Resource_Rel.IdResource);
clsCheckSql.CheckFieldLen(objvWritingOnBBCase_Resource_RelEN.ResourceID, 8, convWritingOnBBCase_Resource_Rel.ResourceID);
clsCheckSql.CheckFieldLen(objvWritingOnBBCase_Resource_RelEN.IdFtpResource, 8, convWritingOnBBCase_Resource_Rel.IdFtpResource);
clsCheckSql.CheckFieldLen(objvWritingOnBBCase_Resource_RelEN.IdFile, 8, convWritingOnBBCase_Resource_Rel.IdFile);
clsCheckSql.CheckFieldLen(objvWritingOnBBCase_Resource_RelEN.FileName, 500, convWritingOnBBCase_Resource_Rel.FileName);
clsCheckSql.CheckFieldLen(objvWritingOnBBCase_Resource_RelEN.FileType, 30, convWritingOnBBCase_Resource_Rel.FileType);
clsCheckSql.CheckFieldLen(objvWritingOnBBCase_Resource_RelEN.SaveDate, 8, convWritingOnBBCase_Resource_Rel.SaveDate);
clsCheckSql.CheckFieldLen(objvWritingOnBBCase_Resource_RelEN.FileSize, 50, convWritingOnBBCase_Resource_Rel.FileSize);
clsCheckSql.CheckFieldLen(objvWritingOnBBCase_Resource_RelEN.SaveTime, 6, convWritingOnBBCase_Resource_Rel.SaveTime);
clsCheckSql.CheckFieldLen(objvWritingOnBBCase_Resource_RelEN.FtpResourceID, 8, convWritingOnBBCase_Resource_Rel.FtpResourceID);
clsCheckSql.CheckFieldLen(objvWritingOnBBCase_Resource_RelEN.FileOriginalName, 200, convWritingOnBBCase_Resource_Rel.FileOriginalName);
clsCheckSql.CheckFieldLen(objvWritingOnBBCase_Resource_RelEN.FileDirName, 200, convWritingOnBBCase_Resource_Rel.FileDirName);
clsCheckSql.CheckFieldLen(objvWritingOnBBCase_Resource_RelEN.FileRename, 200, convWritingOnBBCase_Resource_Rel.FileRename);
clsCheckSql.CheckFieldLen(objvWritingOnBBCase_Resource_RelEN.FileUpDate, 8, convWritingOnBBCase_Resource_Rel.FileUpDate);
clsCheckSql.CheckFieldLen(objvWritingOnBBCase_Resource_RelEN.FileUpTime, 6, convWritingOnBBCase_Resource_Rel.FileUpTime);
clsCheckSql.CheckFieldLen(objvWritingOnBBCase_Resource_RelEN.IdResourceType, 4, convWritingOnBBCase_Resource_Rel.IdResourceType);
clsCheckSql.CheckFieldLen(objvWritingOnBBCase_Resource_RelEN.ResourceTypeID, 4, convWritingOnBBCase_Resource_Rel.ResourceTypeID);
clsCheckSql.CheckFieldLen(objvWritingOnBBCase_Resource_RelEN.ResourceTypeName, 50, convWritingOnBBCase_Resource_Rel.ResourceTypeName);
clsCheckSql.CheckFieldLen(objvWritingOnBBCase_Resource_RelEN.ResourceOwner, 50, convWritingOnBBCase_Resource_Rel.ResourceOwner);
clsCheckSql.CheckFieldLen(objvWritingOnBBCase_Resource_RelEN.ftpFileType, 30, convWritingOnBBCase_Resource_Rel.ftpFileType);
clsCheckSql.CheckFieldLen(objvWritingOnBBCase_Resource_RelEN.ftpFileSize, 50, convWritingOnBBCase_Resource_Rel.ftpFileSize);
clsCheckSql.CheckFieldLen(objvWritingOnBBCase_Resource_RelEN.ftpResourceOwner, 50, convWritingOnBBCase_Resource_Rel.ftpResourceOwner);
clsCheckSql.CheckFieldLen(objvWritingOnBBCase_Resource_RelEN.FileOriginName, 500, convWritingOnBBCase_Resource_Rel.FileOriginName);
clsCheckSql.CheckFieldLen(objvWritingOnBBCase_Resource_RelEN.FileNewName, 530, convWritingOnBBCase_Resource_Rel.FileNewName);
clsCheckSql.CheckFieldLen(objvWritingOnBBCase_Resource_RelEN.FileOldName, 530, convWritingOnBBCase_Resource_Rel.FileOldName);
clsCheckSql.CheckFieldLen(objvWritingOnBBCase_Resource_RelEN.IdUsingMode, 4, convWritingOnBBCase_Resource_Rel.IdUsingMode);
clsCheckSql.CheckFieldLen(objvWritingOnBBCase_Resource_RelEN.UpdDate, 20, convWritingOnBBCase_Resource_Rel.UpdDate);
clsCheckSql.CheckFieldLen(objvWritingOnBBCase_Resource_RelEN.UpdUser, 20, convWritingOnBBCase_Resource_Rel.UpdUser);
clsCheckSql.CheckFieldLen(objvWritingOnBBCase_Resource_RelEN.Memo, 1000, convWritingOnBBCase_Resource_Rel.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvWritingOnBBCase_Resource_RelEN.FuncModuleId, convWritingOnBBCase_Resource_Rel.FuncModuleId);
clsCheckSql.CheckSqlInjection4Field(objvWritingOnBBCase_Resource_RelEN.FuncModuleName, convWritingOnBBCase_Resource_Rel.FuncModuleName);
clsCheckSql.CheckSqlInjection4Field(objvWritingOnBBCase_Resource_RelEN.IdMicroteachCase, convWritingOnBBCase_Resource_Rel.IdMicroteachCase);
clsCheckSql.CheckSqlInjection4Field(objvWritingOnBBCase_Resource_RelEN.IdWritingOnBBCase, convWritingOnBBCase_Resource_Rel.IdWritingOnBBCase);
clsCheckSql.CheckSqlInjection4Field(objvWritingOnBBCase_Resource_RelEN.WritingOnBBCaseID, convWritingOnBBCase_Resource_Rel.WritingOnBBCaseID);
clsCheckSql.CheckSqlInjection4Field(objvWritingOnBBCase_Resource_RelEN.WritingOnBBCaseName, convWritingOnBBCase_Resource_Rel.WritingOnBBCaseName);
clsCheckSql.CheckSqlInjection4Field(objvWritingOnBBCase_Resource_RelEN.WritingOnBBCaseTheme, convWritingOnBBCase_Resource_Rel.WritingOnBBCaseTheme);
clsCheckSql.CheckSqlInjection4Field(objvWritingOnBBCase_Resource_RelEN.IdDiscipline, convWritingOnBBCase_Resource_Rel.IdDiscipline);
clsCheckSql.CheckSqlInjection4Field(objvWritingOnBBCase_Resource_RelEN.DisciplineID, convWritingOnBBCase_Resource_Rel.DisciplineID);
clsCheckSql.CheckSqlInjection4Field(objvWritingOnBBCase_Resource_RelEN.DisciplineName, convWritingOnBBCase_Resource_Rel.DisciplineName);
clsCheckSql.CheckSqlInjection4Field(objvWritingOnBBCase_Resource_RelEN.WritingOnBBCaseDate, convWritingOnBBCase_Resource_Rel.WritingOnBBCaseDate);
clsCheckSql.CheckSqlInjection4Field(objvWritingOnBBCase_Resource_RelEN.WritingOnBBCaseTime, convWritingOnBBCase_Resource_Rel.WritingOnBBCaseTime);
clsCheckSql.CheckSqlInjection4Field(objvWritingOnBBCase_Resource_RelEN.WritingOnBBCaseDateIn, convWritingOnBBCase_Resource_Rel.WritingOnBBCaseDateIn);
clsCheckSql.CheckSqlInjection4Field(objvWritingOnBBCase_Resource_RelEN.WritingOnBBCaseTimeIn, convWritingOnBBCase_Resource_Rel.WritingOnBBCaseTimeIn);
clsCheckSql.CheckSqlInjection4Field(objvWritingOnBBCase_Resource_RelEN.IdStudyLevel, convWritingOnBBCase_Resource_Rel.IdStudyLevel);
clsCheckSql.CheckSqlInjection4Field(objvWritingOnBBCase_Resource_RelEN.StudyLevelName, convWritingOnBBCase_Resource_Rel.StudyLevelName);
clsCheckSql.CheckSqlInjection4Field(objvWritingOnBBCase_Resource_RelEN.CaseLevelId, convWritingOnBBCase_Resource_Rel.CaseLevelId);
clsCheckSql.CheckSqlInjection4Field(objvWritingOnBBCase_Resource_RelEN.senateGaugeVersionID, convWritingOnBBCase_Resource_Rel.senateGaugeVersionID);
clsCheckSql.CheckSqlInjection4Field(objvWritingOnBBCase_Resource_RelEN.senateGaugeVersionName, convWritingOnBBCase_Resource_Rel.senateGaugeVersionName);
clsCheckSql.CheckSqlInjection4Field(objvWritingOnBBCase_Resource_RelEN.OwnerId, convWritingOnBBCase_Resource_Rel.OwnerId);
clsCheckSql.CheckSqlInjection4Field(objvWritingOnBBCase_Resource_RelEN.StuName, convWritingOnBBCase_Resource_Rel.StuName);
clsCheckSql.CheckSqlInjection4Field(objvWritingOnBBCase_Resource_RelEN.StuID, convWritingOnBBCase_Resource_Rel.StuID);
clsCheckSql.CheckSqlInjection4Field(objvWritingOnBBCase_Resource_RelEN.CollegeName, convWritingOnBBCase_Resource_Rel.CollegeName);
clsCheckSql.CheckSqlInjection4Field(objvWritingOnBBCase_Resource_RelEN.IdXzCollege, convWritingOnBBCase_Resource_Rel.IdXzCollege);
clsCheckSql.CheckSqlInjection4Field(objvWritingOnBBCase_Resource_RelEN.IdXzMajor, convWritingOnBBCase_Resource_Rel.IdXzMajor);
clsCheckSql.CheckSqlInjection4Field(objvWritingOnBBCase_Resource_RelEN.IdGradeBase, convWritingOnBBCase_Resource_Rel.IdGradeBase);
clsCheckSql.CheckSqlInjection4Field(objvWritingOnBBCase_Resource_RelEN.IdAdminCls, convWritingOnBBCase_Resource_Rel.IdAdminCls);
clsCheckSql.CheckSqlInjection4Field(objvWritingOnBBCase_Resource_RelEN.CollegeNameA, convWritingOnBBCase_Resource_Rel.CollegeNameA);
clsCheckSql.CheckSqlInjection4Field(objvWritingOnBBCase_Resource_RelEN.RecommendedDegreeId, convWritingOnBBCase_Resource_Rel.RecommendedDegreeId);
clsCheckSql.CheckSqlInjection4Field(objvWritingOnBBCase_Resource_RelEN.RecommendedDegreeName, convWritingOnBBCase_Resource_Rel.RecommendedDegreeName);
clsCheckSql.CheckSqlInjection4Field(objvWritingOnBBCase_Resource_RelEN.IdResource, convWritingOnBBCase_Resource_Rel.IdResource);
clsCheckSql.CheckSqlInjection4Field(objvWritingOnBBCase_Resource_RelEN.ResourceID, convWritingOnBBCase_Resource_Rel.ResourceID);
clsCheckSql.CheckSqlInjection4Field(objvWritingOnBBCase_Resource_RelEN.IdFtpResource, convWritingOnBBCase_Resource_Rel.IdFtpResource);
clsCheckSql.CheckSqlInjection4Field(objvWritingOnBBCase_Resource_RelEN.IdFile, convWritingOnBBCase_Resource_Rel.IdFile);
clsCheckSql.CheckSqlInjection4Field(objvWritingOnBBCase_Resource_RelEN.FileName, convWritingOnBBCase_Resource_Rel.FileName);
clsCheckSql.CheckSqlInjection4Field(objvWritingOnBBCase_Resource_RelEN.FileType, convWritingOnBBCase_Resource_Rel.FileType);
clsCheckSql.CheckSqlInjection4Field(objvWritingOnBBCase_Resource_RelEN.SaveDate, convWritingOnBBCase_Resource_Rel.SaveDate);
clsCheckSql.CheckSqlInjection4Field(objvWritingOnBBCase_Resource_RelEN.FileSize, convWritingOnBBCase_Resource_Rel.FileSize);
clsCheckSql.CheckSqlInjection4Field(objvWritingOnBBCase_Resource_RelEN.SaveTime, convWritingOnBBCase_Resource_Rel.SaveTime);
clsCheckSql.CheckSqlInjection4Field(objvWritingOnBBCase_Resource_RelEN.FtpResourceID, convWritingOnBBCase_Resource_Rel.FtpResourceID);
clsCheckSql.CheckSqlInjection4Field(objvWritingOnBBCase_Resource_RelEN.FileOriginalName, convWritingOnBBCase_Resource_Rel.FileOriginalName);
clsCheckSql.CheckSqlInjection4Field(objvWritingOnBBCase_Resource_RelEN.FileDirName, convWritingOnBBCase_Resource_Rel.FileDirName);
clsCheckSql.CheckSqlInjection4Field(objvWritingOnBBCase_Resource_RelEN.FileRename, convWritingOnBBCase_Resource_Rel.FileRename);
clsCheckSql.CheckSqlInjection4Field(objvWritingOnBBCase_Resource_RelEN.FileUpDate, convWritingOnBBCase_Resource_Rel.FileUpDate);
clsCheckSql.CheckSqlInjection4Field(objvWritingOnBBCase_Resource_RelEN.FileUpTime, convWritingOnBBCase_Resource_Rel.FileUpTime);
clsCheckSql.CheckSqlInjection4Field(objvWritingOnBBCase_Resource_RelEN.IdResourceType, convWritingOnBBCase_Resource_Rel.IdResourceType);
clsCheckSql.CheckSqlInjection4Field(objvWritingOnBBCase_Resource_RelEN.ResourceTypeID, convWritingOnBBCase_Resource_Rel.ResourceTypeID);
clsCheckSql.CheckSqlInjection4Field(objvWritingOnBBCase_Resource_RelEN.ResourceTypeName, convWritingOnBBCase_Resource_Rel.ResourceTypeName);
clsCheckSql.CheckSqlInjection4Field(objvWritingOnBBCase_Resource_RelEN.ResourceOwner, convWritingOnBBCase_Resource_Rel.ResourceOwner);
clsCheckSql.CheckSqlInjection4Field(objvWritingOnBBCase_Resource_RelEN.ftpFileType, convWritingOnBBCase_Resource_Rel.ftpFileType);
clsCheckSql.CheckSqlInjection4Field(objvWritingOnBBCase_Resource_RelEN.ftpFileSize, convWritingOnBBCase_Resource_Rel.ftpFileSize);
clsCheckSql.CheckSqlInjection4Field(objvWritingOnBBCase_Resource_RelEN.ftpResourceOwner, convWritingOnBBCase_Resource_Rel.ftpResourceOwner);
clsCheckSql.CheckSqlInjection4Field(objvWritingOnBBCase_Resource_RelEN.FileOriginName, convWritingOnBBCase_Resource_Rel.FileOriginName);
clsCheckSql.CheckSqlInjection4Field(objvWritingOnBBCase_Resource_RelEN.FileNewName, convWritingOnBBCase_Resource_Rel.FileNewName);
clsCheckSql.CheckSqlInjection4Field(objvWritingOnBBCase_Resource_RelEN.FileOldName, convWritingOnBBCase_Resource_Rel.FileOldName);
clsCheckSql.CheckSqlInjection4Field(objvWritingOnBBCase_Resource_RelEN.IdUsingMode, convWritingOnBBCase_Resource_Rel.IdUsingMode);
clsCheckSql.CheckSqlInjection4Field(objvWritingOnBBCase_Resource_RelEN.UpdDate, convWritingOnBBCase_Resource_Rel.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objvWritingOnBBCase_Resource_RelEN.UpdUser, convWritingOnBBCase_Resource_Rel.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objvWritingOnBBCase_Resource_RelEN.Memo, convWritingOnBBCase_Resource_Rel.Memo);
//检查外键字段长度
 objvWritingOnBBCase_Resource_RelEN._IsCheckProperty = true;
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
 objSQL = clsvWritingOnBBCase_Resource_RelDA.GetSpecSQLObj();
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
 objSQL = clsvWritingOnBBCase_Resource_RelDA.GetSpecSQLObj();
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
 objSQL = clsvWritingOnBBCase_Resource_RelDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvWritingOnBBCase_Resource_RelEN._CurrTabName);
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
 objSQL = clsvWritingOnBBCase_Resource_RelDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvWritingOnBBCase_Resource_RelEN._CurrTabName, strCondition);
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
 objSQL = clsvWritingOnBBCase_Resource_RelDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}