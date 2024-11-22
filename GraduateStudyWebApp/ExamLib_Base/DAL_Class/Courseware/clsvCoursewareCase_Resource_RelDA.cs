
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvCoursewareCase_Resource_RelDA
 表名:vCoursewareCase_Resource_Rel(01120433)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:46:08
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:课件(Courseware)
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
 /// v课件案例资源关系(vCoursewareCase_Resource_Rel)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvCoursewareCase_Resource_RelDA : clsCommBase4DA
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
 return clsvCoursewareCase_Resource_RelEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvCoursewareCase_Resource_RelEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvCoursewareCase_Resource_RelEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvCoursewareCase_Resource_RelEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvCoursewareCase_Resource_RelEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvCoursewareCase_Resource_RelDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCoursewareCase_Resource_RelDA.GetSpecSQLObj();
strSQL = "Select * from vCoursewareCase_Resource_Rel where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vCoursewareCase_Resource_Rel(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvCoursewareCase_Resource_RelDA: GetDataTable_vCoursewareCase_Resource_Rel)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCoursewareCase_Resource_RelDA.GetSpecSQLObj();
strSQL = "Select * from vCoursewareCase_Resource_Rel where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvCoursewareCase_Resource_RelDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCoursewareCase_Resource_RelDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvCoursewareCase_Resource_RelDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCoursewareCase_Resource_RelDA.GetSpecSQLObj();
strSQL = "Select * from vCoursewareCase_Resource_Rel where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvCoursewareCase_Resource_RelDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCoursewareCase_Resource_RelDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvCoursewareCase_Resource_RelDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCoursewareCase_Resource_RelDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vCoursewareCase_Resource_Rel where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vCoursewareCase_Resource_Rel where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvCoursewareCase_Resource_RelDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCoursewareCase_Resource_RelDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vCoursewareCase_Resource_Rel where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvCoursewareCase_Resource_RelDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCoursewareCase_Resource_RelDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vCoursewareCase_Resource_Rel.* from vCoursewareCase_Resource_Rel Left Join {1} on {2} where {3} and vCoursewareCase_Resource_Rel.IdMicroteachCaseResourceRel not in (Select top {5} vCoursewareCase_Resource_Rel.IdMicroteachCaseResourceRel from vCoursewareCase_Resource_Rel Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vCoursewareCase_Resource_Rel where {1} and IdMicroteachCaseResourceRel not in (Select top {2} IdMicroteachCaseResourceRel from vCoursewareCase_Resource_Rel where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vCoursewareCase_Resource_Rel where {1} and IdMicroteachCaseResourceRel not in (Select top {3} IdMicroteachCaseResourceRel from vCoursewareCase_Resource_Rel where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvCoursewareCase_Resource_RelDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCoursewareCase_Resource_RelDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vCoursewareCase_Resource_Rel.* from vCoursewareCase_Resource_Rel Left Join {1} on {2} where {3} and vCoursewareCase_Resource_Rel.IdMicroteachCaseResourceRel not in (Select top {5} vCoursewareCase_Resource_Rel.IdMicroteachCaseResourceRel from vCoursewareCase_Resource_Rel Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vCoursewareCase_Resource_Rel where {1} and IdMicroteachCaseResourceRel not in (Select top {2} IdMicroteachCaseResourceRel from vCoursewareCase_Resource_Rel where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vCoursewareCase_Resource_Rel where {1} and IdMicroteachCaseResourceRel not in (Select top {3} IdMicroteachCaseResourceRel from vCoursewareCase_Resource_Rel where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvCoursewareCase_Resource_RelEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvCoursewareCase_Resource_RelDA:GetObjLst)", objException.Message));
}
List<clsvCoursewareCase_Resource_RelEN> arrObjLst = new List<clsvCoursewareCase_Resource_RelEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCoursewareCase_Resource_RelDA.GetSpecSQLObj();
strSQL = "Select * from vCoursewareCase_Resource_Rel where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCoursewareCase_Resource_RelEN objvCoursewareCase_Resource_RelEN = new clsvCoursewareCase_Resource_RelEN();
try
{
objvCoursewareCase_Resource_RelEN.IdMicroteachCaseResourceRel = TransNullToInt(objRow[convCoursewareCase_Resource_Rel.IdMicroteachCaseResourceRel].ToString().Trim()); //微格案例资源关系流水号
objvCoursewareCase_Resource_RelEN.FuncModuleId = objRow[convCoursewareCase_Resource_Rel.FuncModuleId].ToString().Trim(); //功能模块Id
objvCoursewareCase_Resource_RelEN.FuncModuleName = objRow[convCoursewareCase_Resource_Rel.FuncModuleName] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.FuncModuleName].ToString().Trim(); //功能模块名称
objvCoursewareCase_Resource_RelEN.IdMicroteachCase = objRow[convCoursewareCase_Resource_Rel.IdMicroteachCase] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvCoursewareCase_Resource_RelEN.CoursewareCaseID = objRow[convCoursewareCase_Resource_Rel.CoursewareCaseID] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.CoursewareCaseID].ToString().Trim(); //课件教学案例ID
objvCoursewareCase_Resource_RelEN.CoursewareCaseName = objRow[convCoursewareCase_Resource_Rel.CoursewareCaseName] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.CoursewareCaseName].ToString().Trim(); //课件教学案例名称
objvCoursewareCase_Resource_RelEN.CoursewareCaseTheme = objRow[convCoursewareCase_Resource_Rel.CoursewareCaseTheme] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.CoursewareCaseTheme].ToString().Trim(); //课件教学案例主题词
objvCoursewareCase_Resource_RelEN.IdCoursewareCaseType = objRow[convCoursewareCase_Resource_Rel.IdCoursewareCaseType] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.IdCoursewareCaseType].ToString().Trim(); //课件案例类型流水号
objvCoursewareCase_Resource_RelEN.CoursewareCaseTypeName = objRow[convCoursewareCase_Resource_Rel.CoursewareCaseTypeName] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.CoursewareCaseTypeName].ToString().Trim(); //课件案例类型名称
objvCoursewareCase_Resource_RelEN.CoursewareCaseText = objRow[convCoursewareCase_Resource_Rel.CoursewareCaseText] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.CoursewareCaseText].ToString().Trim(); //案例文本内容
objvCoursewareCase_Resource_RelEN.CoursewareCaseDate = objRow[convCoursewareCase_Resource_Rel.CoursewareCaseDate] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.CoursewareCaseDate].ToString().Trim(); //课件教学日期
objvCoursewareCase_Resource_RelEN.CoursewareCaseTime = objRow[convCoursewareCase_Resource_Rel.CoursewareCaseTime] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.CoursewareCaseTime].ToString().Trim(); //课件教学时间
objvCoursewareCase_Resource_RelEN.CoursewareCaseDateIn = objRow[convCoursewareCase_Resource_Rel.CoursewareCaseDateIn] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.CoursewareCaseDateIn].ToString().Trim(); //案例入库日期
objvCoursewareCase_Resource_RelEN.CoursewareCaseTimeIn = objRow[convCoursewareCase_Resource_Rel.CoursewareCaseTimeIn] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.CoursewareCaseTimeIn].ToString().Trim(); //案例入库时间
objvCoursewareCase_Resource_RelEN.IdStudyLevel = objRow[convCoursewareCase_Resource_Rel.IdStudyLevel] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvCoursewareCase_Resource_RelEN.StudyLevelName = objRow[convCoursewareCase_Resource_Rel.StudyLevelName] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.StudyLevelName].ToString().Trim(); //学段名称
objvCoursewareCase_Resource_RelEN.IdTeachingPlan = objRow[convCoursewareCase_Resource_Rel.IdTeachingPlan] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.IdTeachingPlan].ToString().Trim(); //教案流水号
objvCoursewareCase_Resource_RelEN.IdCaseType = objRow[convCoursewareCase_Resource_Rel.IdCaseType].ToString().Trim(); //案例类型流水号
objvCoursewareCase_Resource_RelEN.IdDiscipline = objRow[convCoursewareCase_Resource_Rel.IdDiscipline].ToString().Trim(); //学科流水号
objvCoursewareCase_Resource_RelEN.DisciplineID = objRow[convCoursewareCase_Resource_Rel.DisciplineID] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.DisciplineID].ToString().Trim(); //学科ID
objvCoursewareCase_Resource_RelEN.DisciplineName = objRow[convCoursewareCase_Resource_Rel.DisciplineName] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.DisciplineName].ToString().Trim(); //学科名称
objvCoursewareCase_Resource_RelEN.senateGaugeVersionID = objRow[convCoursewareCase_Resource_Rel.senateGaugeVersionID] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvCoursewareCase_Resource_RelEN.senateGaugeVersionName = objRow[convCoursewareCase_Resource_Rel.senateGaugeVersionName] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvCoursewareCase_Resource_RelEN.senateGaugeVersionTtlScore = objRow[convCoursewareCase_Resource_Rel.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convCoursewareCase_Resource_Rel.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvCoursewareCase_Resource_RelEN.VersionNo = objRow[convCoursewareCase_Resource_Rel.VersionNo] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCoursewareCase_Resource_Rel.VersionNo].ToString().Trim()); //版本号
objvCoursewareCase_Resource_RelEN.IdTeachSkill = objRow[convCoursewareCase_Resource_Rel.IdTeachSkill] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvCoursewareCase_Resource_RelEN.TeachSkillID = objRow[convCoursewareCase_Resource_Rel.TeachSkillID] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.TeachSkillID].ToString().Trim(); //教学技能ID
objvCoursewareCase_Resource_RelEN.SkillTypeName = objRow[convCoursewareCase_Resource_Rel.SkillTypeName] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.SkillTypeName].ToString().Trim(); //技能类型名称
objvCoursewareCase_Resource_RelEN.TeachSkillName = objRow[convCoursewareCase_Resource_Rel.TeachSkillName] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.TeachSkillName].ToString().Trim(); //教学技能名称
objvCoursewareCase_Resource_RelEN.TeachSkillTheory = objRow[convCoursewareCase_Resource_Rel.TeachSkillTheory] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvCoursewareCase_Resource_RelEN.TeachSkillOperMethod = objRow[convCoursewareCase_Resource_Rel.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvCoursewareCase_Resource_RelEN.IdSkillType = objRow[convCoursewareCase_Resource_Rel.IdSkillType] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.IdSkillType].ToString().Trim(); //技能类型流水号
objvCoursewareCase_Resource_RelEN.SkillTypeID = objRow[convCoursewareCase_Resource_Rel.SkillTypeID] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.SkillTypeID].ToString().Trim(); //技能类型ID
objvCoursewareCase_Resource_RelEN.CaseLevelId = objRow[convCoursewareCase_Resource_Rel.CaseLevelId] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.CaseLevelId].ToString().Trim(); //课例等级Id
objvCoursewareCase_Resource_RelEN.OwnerId = objRow[convCoursewareCase_Resource_Rel.OwnerId] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.OwnerId].ToString().Trim(); //拥有者Id
objvCoursewareCase_Resource_RelEN.StuName = objRow[convCoursewareCase_Resource_Rel.StuName] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.StuName].ToString().Trim(); //姓名
objvCoursewareCase_Resource_RelEN.StuID = objRow[convCoursewareCase_Resource_Rel.StuID] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.StuID].ToString().Trim(); //学号
objvCoursewareCase_Resource_RelEN.PoliticsName = objRow[convCoursewareCase_Resource_Rel.PoliticsName] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.PoliticsName].ToString().Trim(); //政治面貌
objvCoursewareCase_Resource_RelEN.SexDesc = objRow[convCoursewareCase_Resource_Rel.SexDesc] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.SexDesc].ToString().Trim(); //性别名称
objvCoursewareCase_Resource_RelEN.EthnicName = objRow[convCoursewareCase_Resource_Rel.EthnicName] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.EthnicName].ToString().Trim(); //民族名称
objvCoursewareCase_Resource_RelEN.UniZoneDesc = objRow[convCoursewareCase_Resource_Rel.UniZoneDesc] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.UniZoneDesc].ToString().Trim(); //校区名称
objvCoursewareCase_Resource_RelEN.StuTypeDesc = objRow[convCoursewareCase_Resource_Rel.StuTypeDesc] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.StuTypeDesc].ToString().Trim(); //学生类别名称
objvCoursewareCase_Resource_RelEN.IdXzCollege = objRow[convCoursewareCase_Resource_Rel.IdXzCollege] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.IdXzCollege].ToString().Trim(); //学院流水号
objvCoursewareCase_Resource_RelEN.CollegeName = objRow[convCoursewareCase_Resource_Rel.CollegeName] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.CollegeName].ToString().Trim(); //学院名称
objvCoursewareCase_Resource_RelEN.CollegeNameA = objRow[convCoursewareCase_Resource_Rel.CollegeNameA] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.CollegeNameA].ToString().Trim(); //学院名称简写
objvCoursewareCase_Resource_RelEN.IdXzMajor = objRow[convCoursewareCase_Resource_Rel.IdXzMajor] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.IdXzMajor].ToString().Trim(); //专业流水号
objvCoursewareCase_Resource_RelEN.MajorName = objRow[convCoursewareCase_Resource_Rel.MajorName] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.MajorName].ToString().Trim(); //专业名称
objvCoursewareCase_Resource_RelEN.IdGradeBase = objRow[convCoursewareCase_Resource_Rel.IdGradeBase] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.IdGradeBase].ToString().Trim(); //年级流水号
objvCoursewareCase_Resource_RelEN.GradeBaseName = objRow[convCoursewareCase_Resource_Rel.GradeBaseName] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.GradeBaseName].ToString().Trim(); //年级名称
objvCoursewareCase_Resource_RelEN.IdAdminCls = objRow[convCoursewareCase_Resource_Rel.IdAdminCls] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.IdAdminCls].ToString().Trim(); //行政班流水号
objvCoursewareCase_Resource_RelEN.AdminClsId = objRow[convCoursewareCase_Resource_Rel.AdminClsId] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.AdminClsId].ToString().Trim(); //行政班代号
objvCoursewareCase_Resource_RelEN.AdminClsName = objRow[convCoursewareCase_Resource_Rel.AdminClsName] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.AdminClsName].ToString().Trim(); //行政班名称
objvCoursewareCase_Resource_RelEN.Birthday = objRow[convCoursewareCase_Resource_Rel.Birthday] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.Birthday].ToString().Trim(); //出生日期
objvCoursewareCase_Resource_RelEN.NativePlace = objRow[convCoursewareCase_Resource_Rel.NativePlace] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.NativePlace].ToString().Trim(); //籍贯
objvCoursewareCase_Resource_RelEN.Duty = objRow[convCoursewareCase_Resource_Rel.Duty] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.Duty].ToString().Trim(); //职位
objvCoursewareCase_Resource_RelEN.IDCardNo = objRow[convCoursewareCase_Resource_Rel.IDCardNo] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.IDCardNo].ToString().Trim(); //身份证号
objvCoursewareCase_Resource_RelEN.StuCardNo = objRow[convCoursewareCase_Resource_Rel.StuCardNo] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.StuCardNo].ToString().Trim(); //学生证号
objvCoursewareCase_Resource_RelEN.LiveAddress = objRow[convCoursewareCase_Resource_Rel.LiveAddress] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.LiveAddress].ToString().Trim(); //居住地址
objvCoursewareCase_Resource_RelEN.HomePhone = objRow[convCoursewareCase_Resource_Rel.HomePhone] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.HomePhone].ToString().Trim(); //住宅电话
objvCoursewareCase_Resource_RelEN.EnrollmentDate = objRow[convCoursewareCase_Resource_Rel.EnrollmentDate] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.EnrollmentDate].ToString().Trim(); //入校日期
objvCoursewareCase_Resource_RelEN.PostCode = objRow[convCoursewareCase_Resource_Rel.PostCode] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.PostCode].ToString().Trim(); //邮编
objvCoursewareCase_Resource_RelEN.UserKindId = objRow[convCoursewareCase_Resource_Rel.UserKindId] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.UserKindId].ToString().Trim(); //用户类别Id
objvCoursewareCase_Resource_RelEN.UserKindName = objRow[convCoursewareCase_Resource_Rel.UserKindName] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.UserKindName].ToString().Trim(); //用户类别名
objvCoursewareCase_Resource_RelEN.UserTypeId = objRow[convCoursewareCase_Resource_Rel.UserTypeId] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.UserTypeId].ToString().Trim(); //用户类型Id
objvCoursewareCase_Resource_RelEN.IsDualVideo = TransNullToBool(objRow[convCoursewareCase_Resource_Rel.IsDualVideo].ToString().Trim()); //是否双视频
objvCoursewareCase_Resource_RelEN.RecommendedDegreeId = objRow[convCoursewareCase_Resource_Rel.RecommendedDegreeId] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvCoursewareCase_Resource_RelEN.RecommendedDegreeName = objRow[convCoursewareCase_Resource_Rel.RecommendedDegreeName] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvCoursewareCase_Resource_RelEN.BrowseCount4Case = objRow[convCoursewareCase_Resource_Rel.BrowseCount4Case] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCoursewareCase_Resource_Rel.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvCoursewareCase_Resource_RelEN.IdResource = objRow[convCoursewareCase_Resource_Rel.IdResource].ToString().Trim(); //资源流水号
objvCoursewareCase_Resource_RelEN.ResourceID = objRow[convCoursewareCase_Resource_Rel.ResourceID] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.ResourceID].ToString().Trim(); //资源ID
objvCoursewareCase_Resource_RelEN.ResourceName = objRow[convCoursewareCase_Resource_Rel.ResourceName] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.ResourceName].ToString().Trim(); //资源名称
objvCoursewareCase_Resource_RelEN.IdFtpResource = objRow[convCoursewareCase_Resource_Rel.IdFtpResource] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvCoursewareCase_Resource_RelEN.IdFile = objRow[convCoursewareCase_Resource_Rel.IdFile] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.IdFile].ToString().Trim(); //文件流水号
objvCoursewareCase_Resource_RelEN.FileName = objRow[convCoursewareCase_Resource_Rel.FileName] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.FileName].ToString().Trim(); //文件名称
objvCoursewareCase_Resource_RelEN.FileType = objRow[convCoursewareCase_Resource_Rel.FileType] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.FileType].ToString().Trim(); //文件类型
objvCoursewareCase_Resource_RelEN.SaveDate = objRow[convCoursewareCase_Resource_Rel.SaveDate] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.SaveDate].ToString().Trim(); //创建日期
objvCoursewareCase_Resource_RelEN.FileSize = objRow[convCoursewareCase_Resource_Rel.FileSize] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.FileSize].ToString().Trim(); //文件大小
objvCoursewareCase_Resource_RelEN.SaveTime = objRow[convCoursewareCase_Resource_Rel.SaveTime] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.SaveTime].ToString().Trim(); //创建时间
objvCoursewareCase_Resource_RelEN.FtpResourceID = objRow[convCoursewareCase_Resource_Rel.FtpResourceID] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.FtpResourceID].ToString().Trim(); //FTP资源ID
objvCoursewareCase_Resource_RelEN.FileOriginalName = objRow[convCoursewareCase_Resource_Rel.FileOriginalName] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.FileOriginalName].ToString().Trim(); //文件原名
objvCoursewareCase_Resource_RelEN.FileDirName = objRow[convCoursewareCase_Resource_Rel.FileDirName] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.FileDirName].ToString().Trim(); //文件目录名
objvCoursewareCase_Resource_RelEN.FileRename = objRow[convCoursewareCase_Resource_Rel.FileRename] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.FileRename].ToString().Trim(); //文件新名
objvCoursewareCase_Resource_RelEN.FileUpDate = objRow[convCoursewareCase_Resource_Rel.FileUpDate] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.FileUpDate].ToString().Trim(); //创建日期
objvCoursewareCase_Resource_RelEN.FileUpTime = objRow[convCoursewareCase_Resource_Rel.FileUpTime] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.FileUpTime].ToString().Trim(); //创建时间
objvCoursewareCase_Resource_RelEN.SaveMode = TransNullToBool(objRow[convCoursewareCase_Resource_Rel.SaveMode].ToString().Trim()); //文件存放方式
objvCoursewareCase_Resource_RelEN.IdResourceType = objRow[convCoursewareCase_Resource_Rel.IdResourceType] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.IdResourceType].ToString().Trim(); //资源类型流水号
objvCoursewareCase_Resource_RelEN.ResourceTypeID = objRow[convCoursewareCase_Resource_Rel.ResourceTypeID] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.ResourceTypeID].ToString().Trim(); //资源类型ID
objvCoursewareCase_Resource_RelEN.ResourceTypeName = objRow[convCoursewareCase_Resource_Rel.ResourceTypeName] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.ResourceTypeName].ToString().Trim(); //资源类型名称
objvCoursewareCase_Resource_RelEN.ResourceOwner = objRow[convCoursewareCase_Resource_Rel.ResourceOwner] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.ResourceOwner].ToString().Trim(); //上传者
objvCoursewareCase_Resource_RelEN.ftpFileType = objRow[convCoursewareCase_Resource_Rel.ftpFileType] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.ftpFileType].ToString().Trim(); //ftp文件类型
objvCoursewareCase_Resource_RelEN.ftpFileSize = objRow[convCoursewareCase_Resource_Rel.ftpFileSize] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.ftpFileSize].ToString().Trim(); //ftp文件大小
objvCoursewareCase_Resource_RelEN.ftpResourceOwner = objRow[convCoursewareCase_Resource_Rel.ftpResourceOwner] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvCoursewareCase_Resource_RelEN.FileOriginName = objRow[convCoursewareCase_Resource_Rel.FileOriginName] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.FileOriginName].ToString().Trim(); //原文件名
objvCoursewareCase_Resource_RelEN.IsExistFile = TransNullToBool(objRow[convCoursewareCase_Resource_Rel.IsExistFile].ToString().Trim()); //是否存在文件
objvCoursewareCase_Resource_RelEN.FileNewName = objRow[convCoursewareCase_Resource_Rel.FileNewName] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.FileNewName].ToString().Trim(); //新文件名
objvCoursewareCase_Resource_RelEN.FileOldName = objRow[convCoursewareCase_Resource_Rel.FileOldName] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.FileOldName].ToString().Trim(); //旧文件名
objvCoursewareCase_Resource_RelEN.IsMain = TransNullToBool(objRow[convCoursewareCase_Resource_Rel.IsMain].ToString().Trim()); //是否主资源
objvCoursewareCase_Resource_RelEN.IdUsingMode = objRow[convCoursewareCase_Resource_Rel.IdUsingMode] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.IdUsingMode].ToString().Trim(); //资源使用模式流水号
objvCoursewareCase_Resource_RelEN.IsVisible = TransNullToBool(objRow[convCoursewareCase_Resource_Rel.IsVisible].ToString().Trim()); //是否显示
objvCoursewareCase_Resource_RelEN.IndexNO = objRow[convCoursewareCase_Resource_Rel.IndexNO] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCoursewareCase_Resource_Rel.IndexNO].ToString().Trim()); //序号
objvCoursewareCase_Resource_RelEN.BrowseCount = objRow[convCoursewareCase_Resource_Rel.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCoursewareCase_Resource_Rel.BrowseCount].ToString().Trim()); //浏览次数
objvCoursewareCase_Resource_RelEN.UpdDate = objRow[convCoursewareCase_Resource_Rel.UpdDate] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.UpdDate].ToString().Trim(); //修改日期
objvCoursewareCase_Resource_RelEN.UpdUser = objRow[convCoursewareCase_Resource_Rel.UpdUser] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.UpdUser].ToString().Trim(); //修改人
objvCoursewareCase_Resource_RelEN.Memo = objRow[convCoursewareCase_Resource_Rel.Memo] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvCoursewareCase_Resource_RelDA: GetObjLst)", objException.Message));
}
objvCoursewareCase_Resource_RelEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvCoursewareCase_Resource_RelEN);
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
public List<clsvCoursewareCase_Resource_RelEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvCoursewareCase_Resource_RelDA:GetObjLstByTabName)", objException.Message));
}
List<clsvCoursewareCase_Resource_RelEN> arrObjLst = new List<clsvCoursewareCase_Resource_RelEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCoursewareCase_Resource_RelDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCoursewareCase_Resource_RelEN objvCoursewareCase_Resource_RelEN = new clsvCoursewareCase_Resource_RelEN();
try
{
objvCoursewareCase_Resource_RelEN.IdMicroteachCaseResourceRel = TransNullToInt(objRow[convCoursewareCase_Resource_Rel.IdMicroteachCaseResourceRel].ToString().Trim()); //微格案例资源关系流水号
objvCoursewareCase_Resource_RelEN.FuncModuleId = objRow[convCoursewareCase_Resource_Rel.FuncModuleId].ToString().Trim(); //功能模块Id
objvCoursewareCase_Resource_RelEN.FuncModuleName = objRow[convCoursewareCase_Resource_Rel.FuncModuleName] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.FuncModuleName].ToString().Trim(); //功能模块名称
objvCoursewareCase_Resource_RelEN.IdMicroteachCase = objRow[convCoursewareCase_Resource_Rel.IdMicroteachCase] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvCoursewareCase_Resource_RelEN.CoursewareCaseID = objRow[convCoursewareCase_Resource_Rel.CoursewareCaseID] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.CoursewareCaseID].ToString().Trim(); //课件教学案例ID
objvCoursewareCase_Resource_RelEN.CoursewareCaseName = objRow[convCoursewareCase_Resource_Rel.CoursewareCaseName] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.CoursewareCaseName].ToString().Trim(); //课件教学案例名称
objvCoursewareCase_Resource_RelEN.CoursewareCaseTheme = objRow[convCoursewareCase_Resource_Rel.CoursewareCaseTheme] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.CoursewareCaseTheme].ToString().Trim(); //课件教学案例主题词
objvCoursewareCase_Resource_RelEN.IdCoursewareCaseType = objRow[convCoursewareCase_Resource_Rel.IdCoursewareCaseType] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.IdCoursewareCaseType].ToString().Trim(); //课件案例类型流水号
objvCoursewareCase_Resource_RelEN.CoursewareCaseTypeName = objRow[convCoursewareCase_Resource_Rel.CoursewareCaseTypeName] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.CoursewareCaseTypeName].ToString().Trim(); //课件案例类型名称
objvCoursewareCase_Resource_RelEN.CoursewareCaseText = objRow[convCoursewareCase_Resource_Rel.CoursewareCaseText] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.CoursewareCaseText].ToString().Trim(); //案例文本内容
objvCoursewareCase_Resource_RelEN.CoursewareCaseDate = objRow[convCoursewareCase_Resource_Rel.CoursewareCaseDate] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.CoursewareCaseDate].ToString().Trim(); //课件教学日期
objvCoursewareCase_Resource_RelEN.CoursewareCaseTime = objRow[convCoursewareCase_Resource_Rel.CoursewareCaseTime] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.CoursewareCaseTime].ToString().Trim(); //课件教学时间
objvCoursewareCase_Resource_RelEN.CoursewareCaseDateIn = objRow[convCoursewareCase_Resource_Rel.CoursewareCaseDateIn] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.CoursewareCaseDateIn].ToString().Trim(); //案例入库日期
objvCoursewareCase_Resource_RelEN.CoursewareCaseTimeIn = objRow[convCoursewareCase_Resource_Rel.CoursewareCaseTimeIn] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.CoursewareCaseTimeIn].ToString().Trim(); //案例入库时间
objvCoursewareCase_Resource_RelEN.IdStudyLevel = objRow[convCoursewareCase_Resource_Rel.IdStudyLevel] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvCoursewareCase_Resource_RelEN.StudyLevelName = objRow[convCoursewareCase_Resource_Rel.StudyLevelName] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.StudyLevelName].ToString().Trim(); //学段名称
objvCoursewareCase_Resource_RelEN.IdTeachingPlan = objRow[convCoursewareCase_Resource_Rel.IdTeachingPlan] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.IdTeachingPlan].ToString().Trim(); //教案流水号
objvCoursewareCase_Resource_RelEN.IdCaseType = objRow[convCoursewareCase_Resource_Rel.IdCaseType].ToString().Trim(); //案例类型流水号
objvCoursewareCase_Resource_RelEN.IdDiscipline = objRow[convCoursewareCase_Resource_Rel.IdDiscipline].ToString().Trim(); //学科流水号
objvCoursewareCase_Resource_RelEN.DisciplineID = objRow[convCoursewareCase_Resource_Rel.DisciplineID] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.DisciplineID].ToString().Trim(); //学科ID
objvCoursewareCase_Resource_RelEN.DisciplineName = objRow[convCoursewareCase_Resource_Rel.DisciplineName] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.DisciplineName].ToString().Trim(); //学科名称
objvCoursewareCase_Resource_RelEN.senateGaugeVersionID = objRow[convCoursewareCase_Resource_Rel.senateGaugeVersionID] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvCoursewareCase_Resource_RelEN.senateGaugeVersionName = objRow[convCoursewareCase_Resource_Rel.senateGaugeVersionName] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvCoursewareCase_Resource_RelEN.senateGaugeVersionTtlScore = objRow[convCoursewareCase_Resource_Rel.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convCoursewareCase_Resource_Rel.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvCoursewareCase_Resource_RelEN.VersionNo = objRow[convCoursewareCase_Resource_Rel.VersionNo] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCoursewareCase_Resource_Rel.VersionNo].ToString().Trim()); //版本号
objvCoursewareCase_Resource_RelEN.IdTeachSkill = objRow[convCoursewareCase_Resource_Rel.IdTeachSkill] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvCoursewareCase_Resource_RelEN.TeachSkillID = objRow[convCoursewareCase_Resource_Rel.TeachSkillID] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.TeachSkillID].ToString().Trim(); //教学技能ID
objvCoursewareCase_Resource_RelEN.SkillTypeName = objRow[convCoursewareCase_Resource_Rel.SkillTypeName] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.SkillTypeName].ToString().Trim(); //技能类型名称
objvCoursewareCase_Resource_RelEN.TeachSkillName = objRow[convCoursewareCase_Resource_Rel.TeachSkillName] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.TeachSkillName].ToString().Trim(); //教学技能名称
objvCoursewareCase_Resource_RelEN.TeachSkillTheory = objRow[convCoursewareCase_Resource_Rel.TeachSkillTheory] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvCoursewareCase_Resource_RelEN.TeachSkillOperMethod = objRow[convCoursewareCase_Resource_Rel.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvCoursewareCase_Resource_RelEN.IdSkillType = objRow[convCoursewareCase_Resource_Rel.IdSkillType] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.IdSkillType].ToString().Trim(); //技能类型流水号
objvCoursewareCase_Resource_RelEN.SkillTypeID = objRow[convCoursewareCase_Resource_Rel.SkillTypeID] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.SkillTypeID].ToString().Trim(); //技能类型ID
objvCoursewareCase_Resource_RelEN.CaseLevelId = objRow[convCoursewareCase_Resource_Rel.CaseLevelId] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.CaseLevelId].ToString().Trim(); //课例等级Id
objvCoursewareCase_Resource_RelEN.OwnerId = objRow[convCoursewareCase_Resource_Rel.OwnerId] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.OwnerId].ToString().Trim(); //拥有者Id
objvCoursewareCase_Resource_RelEN.StuName = objRow[convCoursewareCase_Resource_Rel.StuName] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.StuName].ToString().Trim(); //姓名
objvCoursewareCase_Resource_RelEN.StuID = objRow[convCoursewareCase_Resource_Rel.StuID] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.StuID].ToString().Trim(); //学号
objvCoursewareCase_Resource_RelEN.PoliticsName = objRow[convCoursewareCase_Resource_Rel.PoliticsName] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.PoliticsName].ToString().Trim(); //政治面貌
objvCoursewareCase_Resource_RelEN.SexDesc = objRow[convCoursewareCase_Resource_Rel.SexDesc] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.SexDesc].ToString().Trim(); //性别名称
objvCoursewareCase_Resource_RelEN.EthnicName = objRow[convCoursewareCase_Resource_Rel.EthnicName] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.EthnicName].ToString().Trim(); //民族名称
objvCoursewareCase_Resource_RelEN.UniZoneDesc = objRow[convCoursewareCase_Resource_Rel.UniZoneDesc] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.UniZoneDesc].ToString().Trim(); //校区名称
objvCoursewareCase_Resource_RelEN.StuTypeDesc = objRow[convCoursewareCase_Resource_Rel.StuTypeDesc] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.StuTypeDesc].ToString().Trim(); //学生类别名称
objvCoursewareCase_Resource_RelEN.IdXzCollege = objRow[convCoursewareCase_Resource_Rel.IdXzCollege] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.IdXzCollege].ToString().Trim(); //学院流水号
objvCoursewareCase_Resource_RelEN.CollegeName = objRow[convCoursewareCase_Resource_Rel.CollegeName] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.CollegeName].ToString().Trim(); //学院名称
objvCoursewareCase_Resource_RelEN.CollegeNameA = objRow[convCoursewareCase_Resource_Rel.CollegeNameA] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.CollegeNameA].ToString().Trim(); //学院名称简写
objvCoursewareCase_Resource_RelEN.IdXzMajor = objRow[convCoursewareCase_Resource_Rel.IdXzMajor] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.IdXzMajor].ToString().Trim(); //专业流水号
objvCoursewareCase_Resource_RelEN.MajorName = objRow[convCoursewareCase_Resource_Rel.MajorName] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.MajorName].ToString().Trim(); //专业名称
objvCoursewareCase_Resource_RelEN.IdGradeBase = objRow[convCoursewareCase_Resource_Rel.IdGradeBase] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.IdGradeBase].ToString().Trim(); //年级流水号
objvCoursewareCase_Resource_RelEN.GradeBaseName = objRow[convCoursewareCase_Resource_Rel.GradeBaseName] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.GradeBaseName].ToString().Trim(); //年级名称
objvCoursewareCase_Resource_RelEN.IdAdminCls = objRow[convCoursewareCase_Resource_Rel.IdAdminCls] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.IdAdminCls].ToString().Trim(); //行政班流水号
objvCoursewareCase_Resource_RelEN.AdminClsId = objRow[convCoursewareCase_Resource_Rel.AdminClsId] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.AdminClsId].ToString().Trim(); //行政班代号
objvCoursewareCase_Resource_RelEN.AdminClsName = objRow[convCoursewareCase_Resource_Rel.AdminClsName] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.AdminClsName].ToString().Trim(); //行政班名称
objvCoursewareCase_Resource_RelEN.Birthday = objRow[convCoursewareCase_Resource_Rel.Birthday] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.Birthday].ToString().Trim(); //出生日期
objvCoursewareCase_Resource_RelEN.NativePlace = objRow[convCoursewareCase_Resource_Rel.NativePlace] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.NativePlace].ToString().Trim(); //籍贯
objvCoursewareCase_Resource_RelEN.Duty = objRow[convCoursewareCase_Resource_Rel.Duty] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.Duty].ToString().Trim(); //职位
objvCoursewareCase_Resource_RelEN.IDCardNo = objRow[convCoursewareCase_Resource_Rel.IDCardNo] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.IDCardNo].ToString().Trim(); //身份证号
objvCoursewareCase_Resource_RelEN.StuCardNo = objRow[convCoursewareCase_Resource_Rel.StuCardNo] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.StuCardNo].ToString().Trim(); //学生证号
objvCoursewareCase_Resource_RelEN.LiveAddress = objRow[convCoursewareCase_Resource_Rel.LiveAddress] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.LiveAddress].ToString().Trim(); //居住地址
objvCoursewareCase_Resource_RelEN.HomePhone = objRow[convCoursewareCase_Resource_Rel.HomePhone] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.HomePhone].ToString().Trim(); //住宅电话
objvCoursewareCase_Resource_RelEN.EnrollmentDate = objRow[convCoursewareCase_Resource_Rel.EnrollmentDate] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.EnrollmentDate].ToString().Trim(); //入校日期
objvCoursewareCase_Resource_RelEN.PostCode = objRow[convCoursewareCase_Resource_Rel.PostCode] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.PostCode].ToString().Trim(); //邮编
objvCoursewareCase_Resource_RelEN.UserKindId = objRow[convCoursewareCase_Resource_Rel.UserKindId] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.UserKindId].ToString().Trim(); //用户类别Id
objvCoursewareCase_Resource_RelEN.UserKindName = objRow[convCoursewareCase_Resource_Rel.UserKindName] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.UserKindName].ToString().Trim(); //用户类别名
objvCoursewareCase_Resource_RelEN.UserTypeId = objRow[convCoursewareCase_Resource_Rel.UserTypeId] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.UserTypeId].ToString().Trim(); //用户类型Id
objvCoursewareCase_Resource_RelEN.IsDualVideo = TransNullToBool(objRow[convCoursewareCase_Resource_Rel.IsDualVideo].ToString().Trim()); //是否双视频
objvCoursewareCase_Resource_RelEN.RecommendedDegreeId = objRow[convCoursewareCase_Resource_Rel.RecommendedDegreeId] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvCoursewareCase_Resource_RelEN.RecommendedDegreeName = objRow[convCoursewareCase_Resource_Rel.RecommendedDegreeName] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvCoursewareCase_Resource_RelEN.BrowseCount4Case = objRow[convCoursewareCase_Resource_Rel.BrowseCount4Case] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCoursewareCase_Resource_Rel.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvCoursewareCase_Resource_RelEN.IdResource = objRow[convCoursewareCase_Resource_Rel.IdResource].ToString().Trim(); //资源流水号
objvCoursewareCase_Resource_RelEN.ResourceID = objRow[convCoursewareCase_Resource_Rel.ResourceID] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.ResourceID].ToString().Trim(); //资源ID
objvCoursewareCase_Resource_RelEN.ResourceName = objRow[convCoursewareCase_Resource_Rel.ResourceName] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.ResourceName].ToString().Trim(); //资源名称
objvCoursewareCase_Resource_RelEN.IdFtpResource = objRow[convCoursewareCase_Resource_Rel.IdFtpResource] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvCoursewareCase_Resource_RelEN.IdFile = objRow[convCoursewareCase_Resource_Rel.IdFile] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.IdFile].ToString().Trim(); //文件流水号
objvCoursewareCase_Resource_RelEN.FileName = objRow[convCoursewareCase_Resource_Rel.FileName] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.FileName].ToString().Trim(); //文件名称
objvCoursewareCase_Resource_RelEN.FileType = objRow[convCoursewareCase_Resource_Rel.FileType] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.FileType].ToString().Trim(); //文件类型
objvCoursewareCase_Resource_RelEN.SaveDate = objRow[convCoursewareCase_Resource_Rel.SaveDate] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.SaveDate].ToString().Trim(); //创建日期
objvCoursewareCase_Resource_RelEN.FileSize = objRow[convCoursewareCase_Resource_Rel.FileSize] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.FileSize].ToString().Trim(); //文件大小
objvCoursewareCase_Resource_RelEN.SaveTime = objRow[convCoursewareCase_Resource_Rel.SaveTime] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.SaveTime].ToString().Trim(); //创建时间
objvCoursewareCase_Resource_RelEN.FtpResourceID = objRow[convCoursewareCase_Resource_Rel.FtpResourceID] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.FtpResourceID].ToString().Trim(); //FTP资源ID
objvCoursewareCase_Resource_RelEN.FileOriginalName = objRow[convCoursewareCase_Resource_Rel.FileOriginalName] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.FileOriginalName].ToString().Trim(); //文件原名
objvCoursewareCase_Resource_RelEN.FileDirName = objRow[convCoursewareCase_Resource_Rel.FileDirName] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.FileDirName].ToString().Trim(); //文件目录名
objvCoursewareCase_Resource_RelEN.FileRename = objRow[convCoursewareCase_Resource_Rel.FileRename] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.FileRename].ToString().Trim(); //文件新名
objvCoursewareCase_Resource_RelEN.FileUpDate = objRow[convCoursewareCase_Resource_Rel.FileUpDate] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.FileUpDate].ToString().Trim(); //创建日期
objvCoursewareCase_Resource_RelEN.FileUpTime = objRow[convCoursewareCase_Resource_Rel.FileUpTime] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.FileUpTime].ToString().Trim(); //创建时间
objvCoursewareCase_Resource_RelEN.SaveMode = TransNullToBool(objRow[convCoursewareCase_Resource_Rel.SaveMode].ToString().Trim()); //文件存放方式
objvCoursewareCase_Resource_RelEN.IdResourceType = objRow[convCoursewareCase_Resource_Rel.IdResourceType] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.IdResourceType].ToString().Trim(); //资源类型流水号
objvCoursewareCase_Resource_RelEN.ResourceTypeID = objRow[convCoursewareCase_Resource_Rel.ResourceTypeID] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.ResourceTypeID].ToString().Trim(); //资源类型ID
objvCoursewareCase_Resource_RelEN.ResourceTypeName = objRow[convCoursewareCase_Resource_Rel.ResourceTypeName] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.ResourceTypeName].ToString().Trim(); //资源类型名称
objvCoursewareCase_Resource_RelEN.ResourceOwner = objRow[convCoursewareCase_Resource_Rel.ResourceOwner] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.ResourceOwner].ToString().Trim(); //上传者
objvCoursewareCase_Resource_RelEN.ftpFileType = objRow[convCoursewareCase_Resource_Rel.ftpFileType] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.ftpFileType].ToString().Trim(); //ftp文件类型
objvCoursewareCase_Resource_RelEN.ftpFileSize = objRow[convCoursewareCase_Resource_Rel.ftpFileSize] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.ftpFileSize].ToString().Trim(); //ftp文件大小
objvCoursewareCase_Resource_RelEN.ftpResourceOwner = objRow[convCoursewareCase_Resource_Rel.ftpResourceOwner] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvCoursewareCase_Resource_RelEN.FileOriginName = objRow[convCoursewareCase_Resource_Rel.FileOriginName] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.FileOriginName].ToString().Trim(); //原文件名
objvCoursewareCase_Resource_RelEN.IsExistFile = TransNullToBool(objRow[convCoursewareCase_Resource_Rel.IsExistFile].ToString().Trim()); //是否存在文件
objvCoursewareCase_Resource_RelEN.FileNewName = objRow[convCoursewareCase_Resource_Rel.FileNewName] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.FileNewName].ToString().Trim(); //新文件名
objvCoursewareCase_Resource_RelEN.FileOldName = objRow[convCoursewareCase_Resource_Rel.FileOldName] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.FileOldName].ToString().Trim(); //旧文件名
objvCoursewareCase_Resource_RelEN.IsMain = TransNullToBool(objRow[convCoursewareCase_Resource_Rel.IsMain].ToString().Trim()); //是否主资源
objvCoursewareCase_Resource_RelEN.IdUsingMode = objRow[convCoursewareCase_Resource_Rel.IdUsingMode] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.IdUsingMode].ToString().Trim(); //资源使用模式流水号
objvCoursewareCase_Resource_RelEN.IsVisible = TransNullToBool(objRow[convCoursewareCase_Resource_Rel.IsVisible].ToString().Trim()); //是否显示
objvCoursewareCase_Resource_RelEN.IndexNO = objRow[convCoursewareCase_Resource_Rel.IndexNO] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCoursewareCase_Resource_Rel.IndexNO].ToString().Trim()); //序号
objvCoursewareCase_Resource_RelEN.BrowseCount = objRow[convCoursewareCase_Resource_Rel.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCoursewareCase_Resource_Rel.BrowseCount].ToString().Trim()); //浏览次数
objvCoursewareCase_Resource_RelEN.UpdDate = objRow[convCoursewareCase_Resource_Rel.UpdDate] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.UpdDate].ToString().Trim(); //修改日期
objvCoursewareCase_Resource_RelEN.UpdUser = objRow[convCoursewareCase_Resource_Rel.UpdUser] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.UpdUser].ToString().Trim(); //修改人
objvCoursewareCase_Resource_RelEN.Memo = objRow[convCoursewareCase_Resource_Rel.Memo] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvCoursewareCase_Resource_RelDA: GetObjLst)", objException.Message));
}
objvCoursewareCase_Resource_RelEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvCoursewareCase_Resource_RelEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvCoursewareCase_Resource_RelEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvCoursewareCase_Resource_Rel(ref clsvCoursewareCase_Resource_RelEN objvCoursewareCase_Resource_RelEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCoursewareCase_Resource_RelDA.GetSpecSQLObj();
strSQL = "Select * from vCoursewareCase_Resource_Rel where IdMicroteachCaseResourceRel = " + ""+ objvCoursewareCase_Resource_RelEN.IdMicroteachCaseResourceRel+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvCoursewareCase_Resource_RelEN.IdMicroteachCaseResourceRel = TransNullToInt(objDT.Rows[0][convCoursewareCase_Resource_Rel.IdMicroteachCaseResourceRel].ToString().Trim()); //微格案例资源关系流水号(字段类型:bigint,字段长度:8,是否可空:False)
 objvCoursewareCase_Resource_RelEN.FuncModuleId = objDT.Rows[0][convCoursewareCase_Resource_Rel.FuncModuleId].ToString().Trim(); //功能模块Id(字段类型:char,字段长度:4,是否可空:True)
 objvCoursewareCase_Resource_RelEN.FuncModuleName = objDT.Rows[0][convCoursewareCase_Resource_Rel.FuncModuleName].ToString().Trim(); //功能模块名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvCoursewareCase_Resource_RelEN.IdMicroteachCase = objDT.Rows[0][convCoursewareCase_Resource_Rel.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号(字段类型:char,字段长度:8,是否可空:False)
 objvCoursewareCase_Resource_RelEN.CoursewareCaseID = objDT.Rows[0][convCoursewareCase_Resource_Rel.CoursewareCaseID].ToString().Trim(); //课件教学案例ID(字段类型:char,字段长度:8,是否可空:False)
 objvCoursewareCase_Resource_RelEN.CoursewareCaseName = objDT.Rows[0][convCoursewareCase_Resource_Rel.CoursewareCaseName].ToString().Trim(); //课件教学案例名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvCoursewareCase_Resource_RelEN.CoursewareCaseTheme = objDT.Rows[0][convCoursewareCase_Resource_Rel.CoursewareCaseTheme].ToString().Trim(); //课件教学案例主题词(字段类型:varchar,字段长度:200,是否可空:True)
 objvCoursewareCase_Resource_RelEN.IdCoursewareCaseType = objDT.Rows[0][convCoursewareCase_Resource_Rel.IdCoursewareCaseType].ToString().Trim(); //课件案例类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvCoursewareCase_Resource_RelEN.CoursewareCaseTypeName = objDT.Rows[0][convCoursewareCase_Resource_Rel.CoursewareCaseTypeName].ToString().Trim(); //课件案例类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvCoursewareCase_Resource_RelEN.CoursewareCaseText = objDT.Rows[0][convCoursewareCase_Resource_Rel.CoursewareCaseText].ToString().Trim(); //案例文本内容(字段类型:varchar,字段长度:8000,是否可空:True)
 objvCoursewareCase_Resource_RelEN.CoursewareCaseDate = objDT.Rows[0][convCoursewareCase_Resource_Rel.CoursewareCaseDate].ToString().Trim(); //课件教学日期(字段类型:char,字段长度:8,是否可空:True)
 objvCoursewareCase_Resource_RelEN.CoursewareCaseTime = objDT.Rows[0][convCoursewareCase_Resource_Rel.CoursewareCaseTime].ToString().Trim(); //课件教学时间(字段类型:char,字段长度:6,是否可空:True)
 objvCoursewareCase_Resource_RelEN.CoursewareCaseDateIn = objDT.Rows[0][convCoursewareCase_Resource_Rel.CoursewareCaseDateIn].ToString().Trim(); //案例入库日期(字段类型:char,字段长度:8,是否可空:True)
 objvCoursewareCase_Resource_RelEN.CoursewareCaseTimeIn = objDT.Rows[0][convCoursewareCase_Resource_Rel.CoursewareCaseTimeIn].ToString().Trim(); //案例入库时间(字段类型:char,字段长度:6,是否可空:True)
 objvCoursewareCase_Resource_RelEN.IdStudyLevel = objDT.Rows[0][convCoursewareCase_Resource_Rel.IdStudyLevel].ToString().Trim(); //id_StudyLevel(字段类型:char,字段长度:4,是否可空:True)
 objvCoursewareCase_Resource_RelEN.StudyLevelName = objDT.Rows[0][convCoursewareCase_Resource_Rel.StudyLevelName].ToString().Trim(); //学段名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvCoursewareCase_Resource_RelEN.IdTeachingPlan = objDT.Rows[0][convCoursewareCase_Resource_Rel.IdTeachingPlan].ToString().Trim(); //教案流水号(字段类型:char,字段长度:8,是否可空:False)
 objvCoursewareCase_Resource_RelEN.IdCaseType = objDT.Rows[0][convCoursewareCase_Resource_Rel.IdCaseType].ToString().Trim(); //案例类型流水号(字段类型:char,字段长度:4,是否可空:True)
 objvCoursewareCase_Resource_RelEN.IdDiscipline = objDT.Rows[0][convCoursewareCase_Resource_Rel.IdDiscipline].ToString().Trim(); //学科流水号(字段类型:char,字段长度:4,是否可空:False)
 objvCoursewareCase_Resource_RelEN.DisciplineID = objDT.Rows[0][convCoursewareCase_Resource_Rel.DisciplineID].ToString().Trim(); //学科ID(字段类型:char,字段长度:4,是否可空:False)
 objvCoursewareCase_Resource_RelEN.DisciplineName = objDT.Rows[0][convCoursewareCase_Resource_Rel.DisciplineName].ToString().Trim(); //学科名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvCoursewareCase_Resource_RelEN.senateGaugeVersionID = objDT.Rows[0][convCoursewareCase_Resource_Rel.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID(字段类型:char,字段长度:4,是否可空:False)
 objvCoursewareCase_Resource_RelEN.senateGaugeVersionName = objDT.Rows[0][convCoursewareCase_Resource_Rel.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称(字段类型:varchar,字段长度:200,是否可空:True)
 objvCoursewareCase_Resource_RelEN.senateGaugeVersionTtlScore = TransNullToFloat(objDT.Rows[0][convCoursewareCase_Resource_Rel.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分(字段类型:float,字段长度:8,是否可空:False)
 objvCoursewareCase_Resource_RelEN.VersionNo = TransNullToInt(objDT.Rows[0][convCoursewareCase_Resource_Rel.VersionNo].ToString().Trim()); //版本号(字段类型:int,字段长度:4,是否可空:True)
 objvCoursewareCase_Resource_RelEN.IdTeachSkill = objDT.Rows[0][convCoursewareCase_Resource_Rel.IdTeachSkill].ToString().Trim(); //教学技能流水号(字段类型:char,字段长度:8,是否可空:False)
 objvCoursewareCase_Resource_RelEN.TeachSkillID = objDT.Rows[0][convCoursewareCase_Resource_Rel.TeachSkillID].ToString().Trim(); //教学技能ID(字段类型:char,字段长度:8,是否可空:False)
 objvCoursewareCase_Resource_RelEN.SkillTypeName = objDT.Rows[0][convCoursewareCase_Resource_Rel.SkillTypeName].ToString().Trim(); //技能类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvCoursewareCase_Resource_RelEN.TeachSkillName = objDT.Rows[0][convCoursewareCase_Resource_Rel.TeachSkillName].ToString().Trim(); //教学技能名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvCoursewareCase_Resource_RelEN.TeachSkillTheory = objDT.Rows[0][convCoursewareCase_Resource_Rel.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述(字段类型:varchar,字段长度:8000,是否可空:True)
 objvCoursewareCase_Resource_RelEN.TeachSkillOperMethod = objDT.Rows[0][convCoursewareCase_Resource_Rel.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法(字段类型:varchar,字段长度:2000,是否可空:True)
 objvCoursewareCase_Resource_RelEN.IdSkillType = objDT.Rows[0][convCoursewareCase_Resource_Rel.IdSkillType].ToString().Trim(); //技能类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvCoursewareCase_Resource_RelEN.SkillTypeID = objDT.Rows[0][convCoursewareCase_Resource_Rel.SkillTypeID].ToString().Trim(); //技能类型ID(字段类型:char,字段长度:4,是否可空:False)
 objvCoursewareCase_Resource_RelEN.CaseLevelId = objDT.Rows[0][convCoursewareCase_Resource_Rel.CaseLevelId].ToString().Trim(); //课例等级Id(字段类型:char,字段长度:2,是否可空:True)
 objvCoursewareCase_Resource_RelEN.OwnerId = objDT.Rows[0][convCoursewareCase_Resource_Rel.OwnerId].ToString().Trim(); //拥有者Id(字段类型:varchar,字段长度:20,是否可空:False)
 objvCoursewareCase_Resource_RelEN.StuName = objDT.Rows[0][convCoursewareCase_Resource_Rel.StuName].ToString().Trim(); //姓名(字段类型:varchar,字段长度:50,是否可空:True)
 objvCoursewareCase_Resource_RelEN.StuID = objDT.Rows[0][convCoursewareCase_Resource_Rel.StuID].ToString().Trim(); //学号(字段类型:varchar,字段长度:20,是否可空:True)
 objvCoursewareCase_Resource_RelEN.PoliticsName = objDT.Rows[0][convCoursewareCase_Resource_Rel.PoliticsName].ToString().Trim(); //政治面貌(字段类型:varchar,字段长度:30,是否可空:False)
 objvCoursewareCase_Resource_RelEN.SexDesc = objDT.Rows[0][convCoursewareCase_Resource_Rel.SexDesc].ToString().Trim(); //性别名称(字段类型:varchar,字段长度:10,是否可空:True)
 objvCoursewareCase_Resource_RelEN.EthnicName = objDT.Rows[0][convCoursewareCase_Resource_Rel.EthnicName].ToString().Trim(); //民族名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvCoursewareCase_Resource_RelEN.UniZoneDesc = objDT.Rows[0][convCoursewareCase_Resource_Rel.UniZoneDesc].ToString().Trim(); //校区名称(字段类型:varchar,字段长度:20,是否可空:False)
 objvCoursewareCase_Resource_RelEN.StuTypeDesc = objDT.Rows[0][convCoursewareCase_Resource_Rel.StuTypeDesc].ToString().Trim(); //学生类别名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvCoursewareCase_Resource_RelEN.IdXzCollege = objDT.Rows[0][convCoursewareCase_Resource_Rel.IdXzCollege].ToString().Trim(); //学院流水号(字段类型:char,字段长度:4,是否可空:True)
 objvCoursewareCase_Resource_RelEN.CollegeName = objDT.Rows[0][convCoursewareCase_Resource_Rel.CollegeName].ToString().Trim(); //学院名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvCoursewareCase_Resource_RelEN.CollegeNameA = objDT.Rows[0][convCoursewareCase_Resource_Rel.CollegeNameA].ToString().Trim(); //学院名称简写(字段类型:varchar,字段长度:12,是否可空:True)
 objvCoursewareCase_Resource_RelEN.IdXzMajor = objDT.Rows[0][convCoursewareCase_Resource_Rel.IdXzMajor].ToString().Trim(); //专业流水号(字段类型:char,字段长度:8,是否可空:False)
 objvCoursewareCase_Resource_RelEN.MajorName = objDT.Rows[0][convCoursewareCase_Resource_Rel.MajorName].ToString().Trim(); //专业名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvCoursewareCase_Resource_RelEN.IdGradeBase = objDT.Rows[0][convCoursewareCase_Resource_Rel.IdGradeBase].ToString().Trim(); //年级流水号(字段类型:char,字段长度:4,是否可空:True)
 objvCoursewareCase_Resource_RelEN.GradeBaseName = objDT.Rows[0][convCoursewareCase_Resource_Rel.GradeBaseName].ToString().Trim(); //年级名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvCoursewareCase_Resource_RelEN.IdAdminCls = objDT.Rows[0][convCoursewareCase_Resource_Rel.IdAdminCls].ToString().Trim(); //行政班流水号(字段类型:char,字段长度:8,是否可空:True)
 objvCoursewareCase_Resource_RelEN.AdminClsId = objDT.Rows[0][convCoursewareCase_Resource_Rel.AdminClsId].ToString().Trim(); //行政班代号(字段类型:varchar,字段长度:8,是否可空:True)
 objvCoursewareCase_Resource_RelEN.AdminClsName = objDT.Rows[0][convCoursewareCase_Resource_Rel.AdminClsName].ToString().Trim(); //行政班名称(字段类型:varchar,字段长度:100,是否可空:True)
 objvCoursewareCase_Resource_RelEN.Birthday = objDT.Rows[0][convCoursewareCase_Resource_Rel.Birthday].ToString().Trim(); //出生日期(字段类型:char,字段长度:8,是否可空:True)
 objvCoursewareCase_Resource_RelEN.NativePlace = objDT.Rows[0][convCoursewareCase_Resource_Rel.NativePlace].ToString().Trim(); //籍贯(字段类型:varchar,字段长度:200,是否可空:True)
 objvCoursewareCase_Resource_RelEN.Duty = objDT.Rows[0][convCoursewareCase_Resource_Rel.Duty].ToString().Trim(); //职位(字段类型:varchar,字段长度:30,是否可空:True)
 objvCoursewareCase_Resource_RelEN.IDCardNo = objDT.Rows[0][convCoursewareCase_Resource_Rel.IDCardNo].ToString().Trim(); //身份证号(字段类型:varchar,字段长度:20,是否可空:True)
 objvCoursewareCase_Resource_RelEN.StuCardNo = objDT.Rows[0][convCoursewareCase_Resource_Rel.StuCardNo].ToString().Trim(); //学生证号(字段类型:varchar,字段长度:20,是否可空:True)
 objvCoursewareCase_Resource_RelEN.LiveAddress = objDT.Rows[0][convCoursewareCase_Resource_Rel.LiveAddress].ToString().Trim(); //居住地址(字段类型:varchar,字段长度:200,是否可空:True)
 objvCoursewareCase_Resource_RelEN.HomePhone = objDT.Rows[0][convCoursewareCase_Resource_Rel.HomePhone].ToString().Trim(); //住宅电话(字段类型:varchar,字段长度:20,是否可空:True)
 objvCoursewareCase_Resource_RelEN.EnrollmentDate = objDT.Rows[0][convCoursewareCase_Resource_Rel.EnrollmentDate].ToString().Trim(); //入校日期(字段类型:varchar,字段长度:8,是否可空:True)
 objvCoursewareCase_Resource_RelEN.PostCode = objDT.Rows[0][convCoursewareCase_Resource_Rel.PostCode].ToString().Trim(); //邮编(字段类型:char,字段长度:6,是否可空:True)
 objvCoursewareCase_Resource_RelEN.UserKindId = objDT.Rows[0][convCoursewareCase_Resource_Rel.UserKindId].ToString().Trim(); //用户类别Id(字段类型:char,字段长度:2,是否可空:False)
 objvCoursewareCase_Resource_RelEN.UserKindName = objDT.Rows[0][convCoursewareCase_Resource_Rel.UserKindName].ToString().Trim(); //用户类别名(字段类型:varchar,字段长度:30,是否可空:False)
 objvCoursewareCase_Resource_RelEN.UserTypeId = objDT.Rows[0][convCoursewareCase_Resource_Rel.UserTypeId].ToString().Trim(); //用户类型Id(字段类型:char,字段长度:2,是否可空:True)
 objvCoursewareCase_Resource_RelEN.IsDualVideo = TransNullToBool(objDT.Rows[0][convCoursewareCase_Resource_Rel.IsDualVideo].ToString().Trim()); //是否双视频(字段类型:bit,字段长度:1,是否可空:False)
 objvCoursewareCase_Resource_RelEN.RecommendedDegreeId = objDT.Rows[0][convCoursewareCase_Resource_Rel.RecommendedDegreeId].ToString().Trim(); //推荐度Id(字段类型:char,字段长度:2,是否可空:False)
 objvCoursewareCase_Resource_RelEN.RecommendedDegreeName = objDT.Rows[0][convCoursewareCase_Resource_Rel.RecommendedDegreeName].ToString().Trim(); //推荐度名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvCoursewareCase_Resource_RelEN.BrowseCount4Case = TransNullToInt(objDT.Rows[0][convCoursewareCase_Resource_Rel.BrowseCount4Case].ToString().Trim()); //课例浏览次数(字段类型:int,字段长度:4,是否可空:True)
 objvCoursewareCase_Resource_RelEN.IdResource = objDT.Rows[0][convCoursewareCase_Resource_Rel.IdResource].ToString().Trim(); //资源流水号(字段类型:char,字段长度:8,是否可空:False)
 objvCoursewareCase_Resource_RelEN.ResourceID = objDT.Rows[0][convCoursewareCase_Resource_Rel.ResourceID].ToString().Trim(); //资源ID(字段类型:char,字段长度:8,是否可空:False)
 objvCoursewareCase_Resource_RelEN.ResourceName = objDT.Rows[0][convCoursewareCase_Resource_Rel.ResourceName].ToString().Trim(); //资源名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvCoursewareCase_Resource_RelEN.IdFtpResource = objDT.Rows[0][convCoursewareCase_Resource_Rel.IdFtpResource].ToString().Trim(); //FTP资源流水号(字段类型:char,字段长度:8,是否可空:True)
 objvCoursewareCase_Resource_RelEN.IdFile = objDT.Rows[0][convCoursewareCase_Resource_Rel.IdFile].ToString().Trim(); //文件流水号(字段类型:char,字段长度:8,是否可空:True)
 objvCoursewareCase_Resource_RelEN.FileName = objDT.Rows[0][convCoursewareCase_Resource_Rel.FileName].ToString().Trim(); //文件名称(字段类型:varchar,字段长度:500,是否可空:True)
 objvCoursewareCase_Resource_RelEN.FileType = objDT.Rows[0][convCoursewareCase_Resource_Rel.FileType].ToString().Trim(); //文件类型(字段类型:varchar,字段长度:30,是否可空:True)
 objvCoursewareCase_Resource_RelEN.SaveDate = objDT.Rows[0][convCoursewareCase_Resource_Rel.SaveDate].ToString().Trim(); //创建日期(字段类型:char,字段长度:8,是否可空:True)
 objvCoursewareCase_Resource_RelEN.FileSize = objDT.Rows[0][convCoursewareCase_Resource_Rel.FileSize].ToString().Trim(); //文件大小(字段类型:varchar,字段长度:50,是否可空:True)
 objvCoursewareCase_Resource_RelEN.SaveTime = objDT.Rows[0][convCoursewareCase_Resource_Rel.SaveTime].ToString().Trim(); //创建时间(字段类型:char,字段长度:6,是否可空:True)
 objvCoursewareCase_Resource_RelEN.FtpResourceID = objDT.Rows[0][convCoursewareCase_Resource_Rel.FtpResourceID].ToString().Trim(); //FTP资源ID(字段类型:char,字段长度:8,是否可空:False)
 objvCoursewareCase_Resource_RelEN.FileOriginalName = objDT.Rows[0][convCoursewareCase_Resource_Rel.FileOriginalName].ToString().Trim(); //文件原名(字段类型:varchar,字段长度:200,是否可空:True)
 objvCoursewareCase_Resource_RelEN.FileDirName = objDT.Rows[0][convCoursewareCase_Resource_Rel.FileDirName].ToString().Trim(); //文件目录名(字段类型:varchar,字段长度:200,是否可空:True)
 objvCoursewareCase_Resource_RelEN.FileRename = objDT.Rows[0][convCoursewareCase_Resource_Rel.FileRename].ToString().Trim(); //文件新名(字段类型:varchar,字段长度:200,是否可空:True)
 objvCoursewareCase_Resource_RelEN.FileUpDate = objDT.Rows[0][convCoursewareCase_Resource_Rel.FileUpDate].ToString().Trim(); //创建日期(字段类型:char,字段长度:8,是否可空:True)
 objvCoursewareCase_Resource_RelEN.FileUpTime = objDT.Rows[0][convCoursewareCase_Resource_Rel.FileUpTime].ToString().Trim(); //创建时间(字段类型:char,字段长度:6,是否可空:True)
 objvCoursewareCase_Resource_RelEN.SaveMode = TransNullToBool(objDT.Rows[0][convCoursewareCase_Resource_Rel.SaveMode].ToString().Trim()); //文件存放方式(字段类型:bit,字段长度:1,是否可空:True)
 objvCoursewareCase_Resource_RelEN.IdResourceType = objDT.Rows[0][convCoursewareCase_Resource_Rel.IdResourceType].ToString().Trim(); //资源类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvCoursewareCase_Resource_RelEN.ResourceTypeID = objDT.Rows[0][convCoursewareCase_Resource_Rel.ResourceTypeID].ToString().Trim(); //资源类型ID(字段类型:char,字段长度:4,是否可空:False)
 objvCoursewareCase_Resource_RelEN.ResourceTypeName = objDT.Rows[0][convCoursewareCase_Resource_Rel.ResourceTypeName].ToString().Trim(); //资源类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvCoursewareCase_Resource_RelEN.ResourceOwner = objDT.Rows[0][convCoursewareCase_Resource_Rel.ResourceOwner].ToString().Trim(); //上传者(字段类型:varchar,字段长度:50,是否可空:False)
 objvCoursewareCase_Resource_RelEN.ftpFileType = objDT.Rows[0][convCoursewareCase_Resource_Rel.ftpFileType].ToString().Trim(); //ftp文件类型(字段类型:varchar,字段长度:30,是否可空:True)
 objvCoursewareCase_Resource_RelEN.ftpFileSize = objDT.Rows[0][convCoursewareCase_Resource_Rel.ftpFileSize].ToString().Trim(); //ftp文件大小(字段类型:varchar,字段长度:50,是否可空:True)
 objvCoursewareCase_Resource_RelEN.ftpResourceOwner = objDT.Rows[0][convCoursewareCase_Resource_Rel.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者(字段类型:varchar,字段长度:50,是否可空:True)
 objvCoursewareCase_Resource_RelEN.FileOriginName = objDT.Rows[0][convCoursewareCase_Resource_Rel.FileOriginName].ToString().Trim(); //原文件名(字段类型:varchar,字段长度:500,是否可空:True)
 objvCoursewareCase_Resource_RelEN.IsExistFile = TransNullToBool(objDT.Rows[0][convCoursewareCase_Resource_Rel.IsExistFile].ToString().Trim()); //是否存在文件(字段类型:bit,字段长度:1,是否可空:True)
 objvCoursewareCase_Resource_RelEN.FileNewName = objDT.Rows[0][convCoursewareCase_Resource_Rel.FileNewName].ToString().Trim(); //新文件名(字段类型:varchar,字段长度:530,是否可空:True)
 objvCoursewareCase_Resource_RelEN.FileOldName = objDT.Rows[0][convCoursewareCase_Resource_Rel.FileOldName].ToString().Trim(); //旧文件名(字段类型:varchar,字段长度:530,是否可空:True)
 objvCoursewareCase_Resource_RelEN.IsMain = TransNullToBool(objDT.Rows[0][convCoursewareCase_Resource_Rel.IsMain].ToString().Trim()); //是否主资源(字段类型:bit,字段长度:1,是否可空:True)
 objvCoursewareCase_Resource_RelEN.IdUsingMode = objDT.Rows[0][convCoursewareCase_Resource_Rel.IdUsingMode].ToString().Trim(); //资源使用模式流水号(字段类型:char,字段长度:4,是否可空:False)
 objvCoursewareCase_Resource_RelEN.IsVisible = TransNullToBool(objDT.Rows[0][convCoursewareCase_Resource_Rel.IsVisible].ToString().Trim()); //是否显示(字段类型:bit,字段长度:1,是否可空:True)
 objvCoursewareCase_Resource_RelEN.IndexNO = TransNullToInt(objDT.Rows[0][convCoursewareCase_Resource_Rel.IndexNO].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:True)
 objvCoursewareCase_Resource_RelEN.BrowseCount = TransNullToInt(objDT.Rows[0][convCoursewareCase_Resource_Rel.BrowseCount].ToString().Trim()); //浏览次数(字段类型:int,字段长度:4,是否可空:True)
 objvCoursewareCase_Resource_RelEN.UpdDate = objDT.Rows[0][convCoursewareCase_Resource_Rel.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvCoursewareCase_Resource_RelEN.UpdUser = objDT.Rows[0][convCoursewareCase_Resource_Rel.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objvCoursewareCase_Resource_RelEN.Memo = objDT.Rows[0][convCoursewareCase_Resource_Rel.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvCoursewareCase_Resource_RelDA: GetvCoursewareCase_Resource_Rel)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngIdMicroteachCaseResourceRel">表关键字</param>
 /// <returns>表对象</returns>
public clsvCoursewareCase_Resource_RelEN GetObjByIdMicroteachCaseResourceRel(long lngIdMicroteachCaseResourceRel)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCoursewareCase_Resource_RelDA.GetSpecSQLObj();
strSQL = "Select * from vCoursewareCase_Resource_Rel where IdMicroteachCaseResourceRel = " + ""+ lngIdMicroteachCaseResourceRel+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvCoursewareCase_Resource_RelEN objvCoursewareCase_Resource_RelEN = new clsvCoursewareCase_Resource_RelEN();
try
{
 objvCoursewareCase_Resource_RelEN.IdMicroteachCaseResourceRel = Int32.Parse(objRow[convCoursewareCase_Resource_Rel.IdMicroteachCaseResourceRel].ToString().Trim()); //微格案例资源关系流水号(字段类型:bigint,字段长度:8,是否可空:False)
 objvCoursewareCase_Resource_RelEN.FuncModuleId = objRow[convCoursewareCase_Resource_Rel.FuncModuleId].ToString().Trim(); //功能模块Id(字段类型:char,字段长度:4,是否可空:True)
 objvCoursewareCase_Resource_RelEN.FuncModuleName = objRow[convCoursewareCase_Resource_Rel.FuncModuleName] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.FuncModuleName].ToString().Trim(); //功能模块名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvCoursewareCase_Resource_RelEN.IdMicroteachCase = objRow[convCoursewareCase_Resource_Rel.IdMicroteachCase] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号(字段类型:char,字段长度:8,是否可空:False)
 objvCoursewareCase_Resource_RelEN.CoursewareCaseID = objRow[convCoursewareCase_Resource_Rel.CoursewareCaseID] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.CoursewareCaseID].ToString().Trim(); //课件教学案例ID(字段类型:char,字段长度:8,是否可空:False)
 objvCoursewareCase_Resource_RelEN.CoursewareCaseName = objRow[convCoursewareCase_Resource_Rel.CoursewareCaseName] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.CoursewareCaseName].ToString().Trim(); //课件教学案例名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvCoursewareCase_Resource_RelEN.CoursewareCaseTheme = objRow[convCoursewareCase_Resource_Rel.CoursewareCaseTheme] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.CoursewareCaseTheme].ToString().Trim(); //课件教学案例主题词(字段类型:varchar,字段长度:200,是否可空:True)
 objvCoursewareCase_Resource_RelEN.IdCoursewareCaseType = objRow[convCoursewareCase_Resource_Rel.IdCoursewareCaseType] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.IdCoursewareCaseType].ToString().Trim(); //课件案例类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvCoursewareCase_Resource_RelEN.CoursewareCaseTypeName = objRow[convCoursewareCase_Resource_Rel.CoursewareCaseTypeName] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.CoursewareCaseTypeName].ToString().Trim(); //课件案例类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvCoursewareCase_Resource_RelEN.CoursewareCaseText = objRow[convCoursewareCase_Resource_Rel.CoursewareCaseText] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.CoursewareCaseText].ToString().Trim(); //案例文本内容(字段类型:varchar,字段长度:8000,是否可空:True)
 objvCoursewareCase_Resource_RelEN.CoursewareCaseDate = objRow[convCoursewareCase_Resource_Rel.CoursewareCaseDate] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.CoursewareCaseDate].ToString().Trim(); //课件教学日期(字段类型:char,字段长度:8,是否可空:True)
 objvCoursewareCase_Resource_RelEN.CoursewareCaseTime = objRow[convCoursewareCase_Resource_Rel.CoursewareCaseTime] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.CoursewareCaseTime].ToString().Trim(); //课件教学时间(字段类型:char,字段长度:6,是否可空:True)
 objvCoursewareCase_Resource_RelEN.CoursewareCaseDateIn = objRow[convCoursewareCase_Resource_Rel.CoursewareCaseDateIn] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.CoursewareCaseDateIn].ToString().Trim(); //案例入库日期(字段类型:char,字段长度:8,是否可空:True)
 objvCoursewareCase_Resource_RelEN.CoursewareCaseTimeIn = objRow[convCoursewareCase_Resource_Rel.CoursewareCaseTimeIn] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.CoursewareCaseTimeIn].ToString().Trim(); //案例入库时间(字段类型:char,字段长度:6,是否可空:True)
 objvCoursewareCase_Resource_RelEN.IdStudyLevel = objRow[convCoursewareCase_Resource_Rel.IdStudyLevel] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.IdStudyLevel].ToString().Trim(); //id_StudyLevel(字段类型:char,字段长度:4,是否可空:True)
 objvCoursewareCase_Resource_RelEN.StudyLevelName = objRow[convCoursewareCase_Resource_Rel.StudyLevelName] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.StudyLevelName].ToString().Trim(); //学段名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvCoursewareCase_Resource_RelEN.IdTeachingPlan = objRow[convCoursewareCase_Resource_Rel.IdTeachingPlan] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.IdTeachingPlan].ToString().Trim(); //教案流水号(字段类型:char,字段长度:8,是否可空:False)
 objvCoursewareCase_Resource_RelEN.IdCaseType = objRow[convCoursewareCase_Resource_Rel.IdCaseType].ToString().Trim(); //案例类型流水号(字段类型:char,字段长度:4,是否可空:True)
 objvCoursewareCase_Resource_RelEN.IdDiscipline = objRow[convCoursewareCase_Resource_Rel.IdDiscipline].ToString().Trim(); //学科流水号(字段类型:char,字段长度:4,是否可空:False)
 objvCoursewareCase_Resource_RelEN.DisciplineID = objRow[convCoursewareCase_Resource_Rel.DisciplineID] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.DisciplineID].ToString().Trim(); //学科ID(字段类型:char,字段长度:4,是否可空:False)
 objvCoursewareCase_Resource_RelEN.DisciplineName = objRow[convCoursewareCase_Resource_Rel.DisciplineName] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.DisciplineName].ToString().Trim(); //学科名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvCoursewareCase_Resource_RelEN.senateGaugeVersionID = objRow[convCoursewareCase_Resource_Rel.senateGaugeVersionID] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID(字段类型:char,字段长度:4,是否可空:False)
 objvCoursewareCase_Resource_RelEN.senateGaugeVersionName = objRow[convCoursewareCase_Resource_Rel.senateGaugeVersionName] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称(字段类型:varchar,字段长度:200,是否可空:True)
 objvCoursewareCase_Resource_RelEN.senateGaugeVersionTtlScore = objRow[convCoursewareCase_Resource_Rel.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convCoursewareCase_Resource_Rel.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分(字段类型:float,字段长度:8,是否可空:False)
 objvCoursewareCase_Resource_RelEN.VersionNo = objRow[convCoursewareCase_Resource_Rel.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCoursewareCase_Resource_Rel.VersionNo].ToString().Trim()); //版本号(字段类型:int,字段长度:4,是否可空:True)
 objvCoursewareCase_Resource_RelEN.IdTeachSkill = objRow[convCoursewareCase_Resource_Rel.IdTeachSkill] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.IdTeachSkill].ToString().Trim(); //教学技能流水号(字段类型:char,字段长度:8,是否可空:False)
 objvCoursewareCase_Resource_RelEN.TeachSkillID = objRow[convCoursewareCase_Resource_Rel.TeachSkillID] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.TeachSkillID].ToString().Trim(); //教学技能ID(字段类型:char,字段长度:8,是否可空:False)
 objvCoursewareCase_Resource_RelEN.SkillTypeName = objRow[convCoursewareCase_Resource_Rel.SkillTypeName] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.SkillTypeName].ToString().Trim(); //技能类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvCoursewareCase_Resource_RelEN.TeachSkillName = objRow[convCoursewareCase_Resource_Rel.TeachSkillName] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.TeachSkillName].ToString().Trim(); //教学技能名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvCoursewareCase_Resource_RelEN.TeachSkillTheory = objRow[convCoursewareCase_Resource_Rel.TeachSkillTheory] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述(字段类型:varchar,字段长度:8000,是否可空:True)
 objvCoursewareCase_Resource_RelEN.TeachSkillOperMethod = objRow[convCoursewareCase_Resource_Rel.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法(字段类型:varchar,字段长度:2000,是否可空:True)
 objvCoursewareCase_Resource_RelEN.IdSkillType = objRow[convCoursewareCase_Resource_Rel.IdSkillType] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.IdSkillType].ToString().Trim(); //技能类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvCoursewareCase_Resource_RelEN.SkillTypeID = objRow[convCoursewareCase_Resource_Rel.SkillTypeID] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.SkillTypeID].ToString().Trim(); //技能类型ID(字段类型:char,字段长度:4,是否可空:False)
 objvCoursewareCase_Resource_RelEN.CaseLevelId = objRow[convCoursewareCase_Resource_Rel.CaseLevelId] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.CaseLevelId].ToString().Trim(); //课例等级Id(字段类型:char,字段长度:2,是否可空:True)
 objvCoursewareCase_Resource_RelEN.OwnerId = objRow[convCoursewareCase_Resource_Rel.OwnerId] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.OwnerId].ToString().Trim(); //拥有者Id(字段类型:varchar,字段长度:20,是否可空:False)
 objvCoursewareCase_Resource_RelEN.StuName = objRow[convCoursewareCase_Resource_Rel.StuName] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.StuName].ToString().Trim(); //姓名(字段类型:varchar,字段长度:50,是否可空:True)
 objvCoursewareCase_Resource_RelEN.StuID = objRow[convCoursewareCase_Resource_Rel.StuID] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.StuID].ToString().Trim(); //学号(字段类型:varchar,字段长度:20,是否可空:True)
 objvCoursewareCase_Resource_RelEN.PoliticsName = objRow[convCoursewareCase_Resource_Rel.PoliticsName] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.PoliticsName].ToString().Trim(); //政治面貌(字段类型:varchar,字段长度:30,是否可空:False)
 objvCoursewareCase_Resource_RelEN.SexDesc = objRow[convCoursewareCase_Resource_Rel.SexDesc] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.SexDesc].ToString().Trim(); //性别名称(字段类型:varchar,字段长度:10,是否可空:True)
 objvCoursewareCase_Resource_RelEN.EthnicName = objRow[convCoursewareCase_Resource_Rel.EthnicName] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.EthnicName].ToString().Trim(); //民族名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvCoursewareCase_Resource_RelEN.UniZoneDesc = objRow[convCoursewareCase_Resource_Rel.UniZoneDesc] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.UniZoneDesc].ToString().Trim(); //校区名称(字段类型:varchar,字段长度:20,是否可空:False)
 objvCoursewareCase_Resource_RelEN.StuTypeDesc = objRow[convCoursewareCase_Resource_Rel.StuTypeDesc] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.StuTypeDesc].ToString().Trim(); //学生类别名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvCoursewareCase_Resource_RelEN.IdXzCollege = objRow[convCoursewareCase_Resource_Rel.IdXzCollege] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.IdXzCollege].ToString().Trim(); //学院流水号(字段类型:char,字段长度:4,是否可空:True)
 objvCoursewareCase_Resource_RelEN.CollegeName = objRow[convCoursewareCase_Resource_Rel.CollegeName] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.CollegeName].ToString().Trim(); //学院名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvCoursewareCase_Resource_RelEN.CollegeNameA = objRow[convCoursewareCase_Resource_Rel.CollegeNameA] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.CollegeNameA].ToString().Trim(); //学院名称简写(字段类型:varchar,字段长度:12,是否可空:True)
 objvCoursewareCase_Resource_RelEN.IdXzMajor = objRow[convCoursewareCase_Resource_Rel.IdXzMajor] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.IdXzMajor].ToString().Trim(); //专业流水号(字段类型:char,字段长度:8,是否可空:False)
 objvCoursewareCase_Resource_RelEN.MajorName = objRow[convCoursewareCase_Resource_Rel.MajorName] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.MajorName].ToString().Trim(); //专业名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvCoursewareCase_Resource_RelEN.IdGradeBase = objRow[convCoursewareCase_Resource_Rel.IdGradeBase] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.IdGradeBase].ToString().Trim(); //年级流水号(字段类型:char,字段长度:4,是否可空:True)
 objvCoursewareCase_Resource_RelEN.GradeBaseName = objRow[convCoursewareCase_Resource_Rel.GradeBaseName] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.GradeBaseName].ToString().Trim(); //年级名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvCoursewareCase_Resource_RelEN.IdAdminCls = objRow[convCoursewareCase_Resource_Rel.IdAdminCls] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.IdAdminCls].ToString().Trim(); //行政班流水号(字段类型:char,字段长度:8,是否可空:True)
 objvCoursewareCase_Resource_RelEN.AdminClsId = objRow[convCoursewareCase_Resource_Rel.AdminClsId] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.AdminClsId].ToString().Trim(); //行政班代号(字段类型:varchar,字段长度:8,是否可空:True)
 objvCoursewareCase_Resource_RelEN.AdminClsName = objRow[convCoursewareCase_Resource_Rel.AdminClsName] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.AdminClsName].ToString().Trim(); //行政班名称(字段类型:varchar,字段长度:100,是否可空:True)
 objvCoursewareCase_Resource_RelEN.Birthday = objRow[convCoursewareCase_Resource_Rel.Birthday] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.Birthday].ToString().Trim(); //出生日期(字段类型:char,字段长度:8,是否可空:True)
 objvCoursewareCase_Resource_RelEN.NativePlace = objRow[convCoursewareCase_Resource_Rel.NativePlace] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.NativePlace].ToString().Trim(); //籍贯(字段类型:varchar,字段长度:200,是否可空:True)
 objvCoursewareCase_Resource_RelEN.Duty = objRow[convCoursewareCase_Resource_Rel.Duty] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.Duty].ToString().Trim(); //职位(字段类型:varchar,字段长度:30,是否可空:True)
 objvCoursewareCase_Resource_RelEN.IDCardNo = objRow[convCoursewareCase_Resource_Rel.IDCardNo] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.IDCardNo].ToString().Trim(); //身份证号(字段类型:varchar,字段长度:20,是否可空:True)
 objvCoursewareCase_Resource_RelEN.StuCardNo = objRow[convCoursewareCase_Resource_Rel.StuCardNo] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.StuCardNo].ToString().Trim(); //学生证号(字段类型:varchar,字段长度:20,是否可空:True)
 objvCoursewareCase_Resource_RelEN.LiveAddress = objRow[convCoursewareCase_Resource_Rel.LiveAddress] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.LiveAddress].ToString().Trim(); //居住地址(字段类型:varchar,字段长度:200,是否可空:True)
 objvCoursewareCase_Resource_RelEN.HomePhone = objRow[convCoursewareCase_Resource_Rel.HomePhone] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.HomePhone].ToString().Trim(); //住宅电话(字段类型:varchar,字段长度:20,是否可空:True)
 objvCoursewareCase_Resource_RelEN.EnrollmentDate = objRow[convCoursewareCase_Resource_Rel.EnrollmentDate] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.EnrollmentDate].ToString().Trim(); //入校日期(字段类型:varchar,字段长度:8,是否可空:True)
 objvCoursewareCase_Resource_RelEN.PostCode = objRow[convCoursewareCase_Resource_Rel.PostCode] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.PostCode].ToString().Trim(); //邮编(字段类型:char,字段长度:6,是否可空:True)
 objvCoursewareCase_Resource_RelEN.UserKindId = objRow[convCoursewareCase_Resource_Rel.UserKindId] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.UserKindId].ToString().Trim(); //用户类别Id(字段类型:char,字段长度:2,是否可空:False)
 objvCoursewareCase_Resource_RelEN.UserKindName = objRow[convCoursewareCase_Resource_Rel.UserKindName] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.UserKindName].ToString().Trim(); //用户类别名(字段类型:varchar,字段长度:30,是否可空:False)
 objvCoursewareCase_Resource_RelEN.UserTypeId = objRow[convCoursewareCase_Resource_Rel.UserTypeId] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.UserTypeId].ToString().Trim(); //用户类型Id(字段类型:char,字段长度:2,是否可空:True)
 objvCoursewareCase_Resource_RelEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convCoursewareCase_Resource_Rel.IsDualVideo].ToString().Trim()); //是否双视频(字段类型:bit,字段长度:1,是否可空:False)
 objvCoursewareCase_Resource_RelEN.RecommendedDegreeId = objRow[convCoursewareCase_Resource_Rel.RecommendedDegreeId] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.RecommendedDegreeId].ToString().Trim(); //推荐度Id(字段类型:char,字段长度:2,是否可空:False)
 objvCoursewareCase_Resource_RelEN.RecommendedDegreeName = objRow[convCoursewareCase_Resource_Rel.RecommendedDegreeName] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.RecommendedDegreeName].ToString().Trim(); //推荐度名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvCoursewareCase_Resource_RelEN.BrowseCount4Case = objRow[convCoursewareCase_Resource_Rel.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCoursewareCase_Resource_Rel.BrowseCount4Case].ToString().Trim()); //课例浏览次数(字段类型:int,字段长度:4,是否可空:True)
 objvCoursewareCase_Resource_RelEN.IdResource = objRow[convCoursewareCase_Resource_Rel.IdResource].ToString().Trim(); //资源流水号(字段类型:char,字段长度:8,是否可空:False)
 objvCoursewareCase_Resource_RelEN.ResourceID = objRow[convCoursewareCase_Resource_Rel.ResourceID] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.ResourceID].ToString().Trim(); //资源ID(字段类型:char,字段长度:8,是否可空:False)
 objvCoursewareCase_Resource_RelEN.ResourceName = objRow[convCoursewareCase_Resource_Rel.ResourceName] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.ResourceName].ToString().Trim(); //资源名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvCoursewareCase_Resource_RelEN.IdFtpResource = objRow[convCoursewareCase_Resource_Rel.IdFtpResource] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.IdFtpResource].ToString().Trim(); //FTP资源流水号(字段类型:char,字段长度:8,是否可空:True)
 objvCoursewareCase_Resource_RelEN.IdFile = objRow[convCoursewareCase_Resource_Rel.IdFile] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.IdFile].ToString().Trim(); //文件流水号(字段类型:char,字段长度:8,是否可空:True)
 objvCoursewareCase_Resource_RelEN.FileName = objRow[convCoursewareCase_Resource_Rel.FileName] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.FileName].ToString().Trim(); //文件名称(字段类型:varchar,字段长度:500,是否可空:True)
 objvCoursewareCase_Resource_RelEN.FileType = objRow[convCoursewareCase_Resource_Rel.FileType] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.FileType].ToString().Trim(); //文件类型(字段类型:varchar,字段长度:30,是否可空:True)
 objvCoursewareCase_Resource_RelEN.SaveDate = objRow[convCoursewareCase_Resource_Rel.SaveDate] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.SaveDate].ToString().Trim(); //创建日期(字段类型:char,字段长度:8,是否可空:True)
 objvCoursewareCase_Resource_RelEN.FileSize = objRow[convCoursewareCase_Resource_Rel.FileSize] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.FileSize].ToString().Trim(); //文件大小(字段类型:varchar,字段长度:50,是否可空:True)
 objvCoursewareCase_Resource_RelEN.SaveTime = objRow[convCoursewareCase_Resource_Rel.SaveTime] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.SaveTime].ToString().Trim(); //创建时间(字段类型:char,字段长度:6,是否可空:True)
 objvCoursewareCase_Resource_RelEN.FtpResourceID = objRow[convCoursewareCase_Resource_Rel.FtpResourceID] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.FtpResourceID].ToString().Trim(); //FTP资源ID(字段类型:char,字段长度:8,是否可空:False)
 objvCoursewareCase_Resource_RelEN.FileOriginalName = objRow[convCoursewareCase_Resource_Rel.FileOriginalName] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.FileOriginalName].ToString().Trim(); //文件原名(字段类型:varchar,字段长度:200,是否可空:True)
 objvCoursewareCase_Resource_RelEN.FileDirName = objRow[convCoursewareCase_Resource_Rel.FileDirName] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.FileDirName].ToString().Trim(); //文件目录名(字段类型:varchar,字段长度:200,是否可空:True)
 objvCoursewareCase_Resource_RelEN.FileRename = objRow[convCoursewareCase_Resource_Rel.FileRename] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.FileRename].ToString().Trim(); //文件新名(字段类型:varchar,字段长度:200,是否可空:True)
 objvCoursewareCase_Resource_RelEN.FileUpDate = objRow[convCoursewareCase_Resource_Rel.FileUpDate] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.FileUpDate].ToString().Trim(); //创建日期(字段类型:char,字段长度:8,是否可空:True)
 objvCoursewareCase_Resource_RelEN.FileUpTime = objRow[convCoursewareCase_Resource_Rel.FileUpTime] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.FileUpTime].ToString().Trim(); //创建时间(字段类型:char,字段长度:6,是否可空:True)
 objvCoursewareCase_Resource_RelEN.SaveMode = clsEntityBase2.TransNullToBool_S(objRow[convCoursewareCase_Resource_Rel.SaveMode].ToString().Trim()); //文件存放方式(字段类型:bit,字段长度:1,是否可空:True)
 objvCoursewareCase_Resource_RelEN.IdResourceType = objRow[convCoursewareCase_Resource_Rel.IdResourceType] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.IdResourceType].ToString().Trim(); //资源类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvCoursewareCase_Resource_RelEN.ResourceTypeID = objRow[convCoursewareCase_Resource_Rel.ResourceTypeID] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.ResourceTypeID].ToString().Trim(); //资源类型ID(字段类型:char,字段长度:4,是否可空:False)
 objvCoursewareCase_Resource_RelEN.ResourceTypeName = objRow[convCoursewareCase_Resource_Rel.ResourceTypeName] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.ResourceTypeName].ToString().Trim(); //资源类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvCoursewareCase_Resource_RelEN.ResourceOwner = objRow[convCoursewareCase_Resource_Rel.ResourceOwner] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.ResourceOwner].ToString().Trim(); //上传者(字段类型:varchar,字段长度:50,是否可空:False)
 objvCoursewareCase_Resource_RelEN.ftpFileType = objRow[convCoursewareCase_Resource_Rel.ftpFileType] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.ftpFileType].ToString().Trim(); //ftp文件类型(字段类型:varchar,字段长度:30,是否可空:True)
 objvCoursewareCase_Resource_RelEN.ftpFileSize = objRow[convCoursewareCase_Resource_Rel.ftpFileSize] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.ftpFileSize].ToString().Trim(); //ftp文件大小(字段类型:varchar,字段长度:50,是否可空:True)
 objvCoursewareCase_Resource_RelEN.ftpResourceOwner = objRow[convCoursewareCase_Resource_Rel.ftpResourceOwner] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者(字段类型:varchar,字段长度:50,是否可空:True)
 objvCoursewareCase_Resource_RelEN.FileOriginName = objRow[convCoursewareCase_Resource_Rel.FileOriginName] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.FileOriginName].ToString().Trim(); //原文件名(字段类型:varchar,字段长度:500,是否可空:True)
 objvCoursewareCase_Resource_RelEN.IsExistFile = clsEntityBase2.TransNullToBool_S(objRow[convCoursewareCase_Resource_Rel.IsExistFile].ToString().Trim()); //是否存在文件(字段类型:bit,字段长度:1,是否可空:True)
 objvCoursewareCase_Resource_RelEN.FileNewName = objRow[convCoursewareCase_Resource_Rel.FileNewName] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.FileNewName].ToString().Trim(); //新文件名(字段类型:varchar,字段长度:530,是否可空:True)
 objvCoursewareCase_Resource_RelEN.FileOldName = objRow[convCoursewareCase_Resource_Rel.FileOldName] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.FileOldName].ToString().Trim(); //旧文件名(字段类型:varchar,字段长度:530,是否可空:True)
 objvCoursewareCase_Resource_RelEN.IsMain = clsEntityBase2.TransNullToBool_S(objRow[convCoursewareCase_Resource_Rel.IsMain].ToString().Trim()); //是否主资源(字段类型:bit,字段长度:1,是否可空:True)
 objvCoursewareCase_Resource_RelEN.IdUsingMode = objRow[convCoursewareCase_Resource_Rel.IdUsingMode] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.IdUsingMode].ToString().Trim(); //资源使用模式流水号(字段类型:char,字段长度:4,是否可空:False)
 objvCoursewareCase_Resource_RelEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convCoursewareCase_Resource_Rel.IsVisible].ToString().Trim()); //是否显示(字段类型:bit,字段长度:1,是否可空:True)
 objvCoursewareCase_Resource_RelEN.IndexNO = objRow[convCoursewareCase_Resource_Rel.IndexNO] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCoursewareCase_Resource_Rel.IndexNO].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:True)
 objvCoursewareCase_Resource_RelEN.BrowseCount = objRow[convCoursewareCase_Resource_Rel.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCoursewareCase_Resource_Rel.BrowseCount].ToString().Trim()); //浏览次数(字段类型:int,字段长度:4,是否可空:True)
 objvCoursewareCase_Resource_RelEN.UpdDate = objRow[convCoursewareCase_Resource_Rel.UpdDate] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvCoursewareCase_Resource_RelEN.UpdUser = objRow[convCoursewareCase_Resource_Rel.UpdUser] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objvCoursewareCase_Resource_RelEN.Memo = objRow[convCoursewareCase_Resource_Rel.Memo] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvCoursewareCase_Resource_RelDA: GetObjByIdMicroteachCaseResourceRel)", objException.Message));
}
return objvCoursewareCase_Resource_RelEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvCoursewareCase_Resource_RelEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvCoursewareCase_Resource_RelDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCoursewareCase_Resource_RelDA.GetSpecSQLObj();
strSQL = "Select * from vCoursewareCase_Resource_Rel where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvCoursewareCase_Resource_RelEN objvCoursewareCase_Resource_RelEN = new clsvCoursewareCase_Resource_RelEN()
{
IdMicroteachCaseResourceRel = TransNullToInt(objRow[convCoursewareCase_Resource_Rel.IdMicroteachCaseResourceRel].ToString().Trim()), //微格案例资源关系流水号
FuncModuleId = objRow[convCoursewareCase_Resource_Rel.FuncModuleId].ToString().Trim(), //功能模块Id
FuncModuleName = objRow[convCoursewareCase_Resource_Rel.FuncModuleName] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.FuncModuleName].ToString().Trim(), //功能模块名称
IdMicroteachCase = objRow[convCoursewareCase_Resource_Rel.IdMicroteachCase] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.IdMicroteachCase].ToString().Trim(), //微格教学案例流水号
CoursewareCaseID = objRow[convCoursewareCase_Resource_Rel.CoursewareCaseID] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.CoursewareCaseID].ToString().Trim(), //课件教学案例ID
CoursewareCaseName = objRow[convCoursewareCase_Resource_Rel.CoursewareCaseName] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.CoursewareCaseName].ToString().Trim(), //课件教学案例名称
CoursewareCaseTheme = objRow[convCoursewareCase_Resource_Rel.CoursewareCaseTheme] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.CoursewareCaseTheme].ToString().Trim(), //课件教学案例主题词
IdCoursewareCaseType = objRow[convCoursewareCase_Resource_Rel.IdCoursewareCaseType] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.IdCoursewareCaseType].ToString().Trim(), //课件案例类型流水号
CoursewareCaseTypeName = objRow[convCoursewareCase_Resource_Rel.CoursewareCaseTypeName] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.CoursewareCaseTypeName].ToString().Trim(), //课件案例类型名称
CoursewareCaseText = objRow[convCoursewareCase_Resource_Rel.CoursewareCaseText] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.CoursewareCaseText].ToString().Trim(), //案例文本内容
CoursewareCaseDate = objRow[convCoursewareCase_Resource_Rel.CoursewareCaseDate] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.CoursewareCaseDate].ToString().Trim(), //课件教学日期
CoursewareCaseTime = objRow[convCoursewareCase_Resource_Rel.CoursewareCaseTime] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.CoursewareCaseTime].ToString().Trim(), //课件教学时间
CoursewareCaseDateIn = objRow[convCoursewareCase_Resource_Rel.CoursewareCaseDateIn] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.CoursewareCaseDateIn].ToString().Trim(), //案例入库日期
CoursewareCaseTimeIn = objRow[convCoursewareCase_Resource_Rel.CoursewareCaseTimeIn] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.CoursewareCaseTimeIn].ToString().Trim(), //案例入库时间
IdStudyLevel = objRow[convCoursewareCase_Resource_Rel.IdStudyLevel] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.IdStudyLevel].ToString().Trim(), //id_StudyLevel
StudyLevelName = objRow[convCoursewareCase_Resource_Rel.StudyLevelName] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.StudyLevelName].ToString().Trim(), //学段名称
IdTeachingPlan = objRow[convCoursewareCase_Resource_Rel.IdTeachingPlan] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.IdTeachingPlan].ToString().Trim(), //教案流水号
IdCaseType = objRow[convCoursewareCase_Resource_Rel.IdCaseType].ToString().Trim(), //案例类型流水号
IdDiscipline = objRow[convCoursewareCase_Resource_Rel.IdDiscipline].ToString().Trim(), //学科流水号
DisciplineID = objRow[convCoursewareCase_Resource_Rel.DisciplineID] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.DisciplineID].ToString().Trim(), //学科ID
DisciplineName = objRow[convCoursewareCase_Resource_Rel.DisciplineName] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.DisciplineName].ToString().Trim(), //学科名称
senateGaugeVersionID = objRow[convCoursewareCase_Resource_Rel.senateGaugeVersionID] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.senateGaugeVersionID].ToString().Trim(), //评价量表版本ID
senateGaugeVersionName = objRow[convCoursewareCase_Resource_Rel.senateGaugeVersionName] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.senateGaugeVersionName].ToString().Trim(), //评价量表版本名称
senateGaugeVersionTtlScore = objRow[convCoursewareCase_Resource_Rel.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convCoursewareCase_Resource_Rel.senateGaugeVersionTtlScore].ToString().Trim()), //评价量表版本总分
VersionNo = objRow[convCoursewareCase_Resource_Rel.VersionNo] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCoursewareCase_Resource_Rel.VersionNo].ToString().Trim()), //版本号
IdTeachSkill = objRow[convCoursewareCase_Resource_Rel.IdTeachSkill] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.IdTeachSkill].ToString().Trim(), //教学技能流水号
TeachSkillID = objRow[convCoursewareCase_Resource_Rel.TeachSkillID] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.TeachSkillID].ToString().Trim(), //教学技能ID
SkillTypeName = objRow[convCoursewareCase_Resource_Rel.SkillTypeName] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.SkillTypeName].ToString().Trim(), //技能类型名称
TeachSkillName = objRow[convCoursewareCase_Resource_Rel.TeachSkillName] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.TeachSkillName].ToString().Trim(), //教学技能名称
TeachSkillTheory = objRow[convCoursewareCase_Resource_Rel.TeachSkillTheory] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.TeachSkillTheory].ToString().Trim(), //教学技能理论阐述
TeachSkillOperMethod = objRow[convCoursewareCase_Resource_Rel.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.TeachSkillOperMethod].ToString().Trim(), //教学技能实践操作方法
IdSkillType = objRow[convCoursewareCase_Resource_Rel.IdSkillType] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.IdSkillType].ToString().Trim(), //技能类型流水号
SkillTypeID = objRow[convCoursewareCase_Resource_Rel.SkillTypeID] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.SkillTypeID].ToString().Trim(), //技能类型ID
CaseLevelId = objRow[convCoursewareCase_Resource_Rel.CaseLevelId] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.CaseLevelId].ToString().Trim(), //课例等级Id
OwnerId = objRow[convCoursewareCase_Resource_Rel.OwnerId] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.OwnerId].ToString().Trim(), //拥有者Id
StuName = objRow[convCoursewareCase_Resource_Rel.StuName] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.StuName].ToString().Trim(), //姓名
StuID = objRow[convCoursewareCase_Resource_Rel.StuID] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.StuID].ToString().Trim(), //学号
PoliticsName = objRow[convCoursewareCase_Resource_Rel.PoliticsName] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.PoliticsName].ToString().Trim(), //政治面貌
SexDesc = objRow[convCoursewareCase_Resource_Rel.SexDesc] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.SexDesc].ToString().Trim(), //性别名称
EthnicName = objRow[convCoursewareCase_Resource_Rel.EthnicName] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.EthnicName].ToString().Trim(), //民族名称
UniZoneDesc = objRow[convCoursewareCase_Resource_Rel.UniZoneDesc] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.UniZoneDesc].ToString().Trim(), //校区名称
StuTypeDesc = objRow[convCoursewareCase_Resource_Rel.StuTypeDesc] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.StuTypeDesc].ToString().Trim(), //学生类别名称
IdXzCollege = objRow[convCoursewareCase_Resource_Rel.IdXzCollege] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.IdXzCollege].ToString().Trim(), //学院流水号
CollegeName = objRow[convCoursewareCase_Resource_Rel.CollegeName] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.CollegeName].ToString().Trim(), //学院名称
CollegeNameA = objRow[convCoursewareCase_Resource_Rel.CollegeNameA] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.CollegeNameA].ToString().Trim(), //学院名称简写
IdXzMajor = objRow[convCoursewareCase_Resource_Rel.IdXzMajor] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.IdXzMajor].ToString().Trim(), //专业流水号
MajorName = objRow[convCoursewareCase_Resource_Rel.MajorName] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.MajorName].ToString().Trim(), //专业名称
IdGradeBase = objRow[convCoursewareCase_Resource_Rel.IdGradeBase] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.IdGradeBase].ToString().Trim(), //年级流水号
GradeBaseName = objRow[convCoursewareCase_Resource_Rel.GradeBaseName] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.GradeBaseName].ToString().Trim(), //年级名称
IdAdminCls = objRow[convCoursewareCase_Resource_Rel.IdAdminCls] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.IdAdminCls].ToString().Trim(), //行政班流水号
AdminClsId = objRow[convCoursewareCase_Resource_Rel.AdminClsId] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.AdminClsId].ToString().Trim(), //行政班代号
AdminClsName = objRow[convCoursewareCase_Resource_Rel.AdminClsName] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.AdminClsName].ToString().Trim(), //行政班名称
Birthday = objRow[convCoursewareCase_Resource_Rel.Birthday] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.Birthday].ToString().Trim(), //出生日期
NativePlace = objRow[convCoursewareCase_Resource_Rel.NativePlace] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.NativePlace].ToString().Trim(), //籍贯
Duty = objRow[convCoursewareCase_Resource_Rel.Duty] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.Duty].ToString().Trim(), //职位
IDCardNo = objRow[convCoursewareCase_Resource_Rel.IDCardNo] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.IDCardNo].ToString().Trim(), //身份证号
StuCardNo = objRow[convCoursewareCase_Resource_Rel.StuCardNo] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.StuCardNo].ToString().Trim(), //学生证号
LiveAddress = objRow[convCoursewareCase_Resource_Rel.LiveAddress] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.LiveAddress].ToString().Trim(), //居住地址
HomePhone = objRow[convCoursewareCase_Resource_Rel.HomePhone] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.HomePhone].ToString().Trim(), //住宅电话
EnrollmentDate = objRow[convCoursewareCase_Resource_Rel.EnrollmentDate] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.EnrollmentDate].ToString().Trim(), //入校日期
PostCode = objRow[convCoursewareCase_Resource_Rel.PostCode] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.PostCode].ToString().Trim(), //邮编
UserKindId = objRow[convCoursewareCase_Resource_Rel.UserKindId] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.UserKindId].ToString().Trim(), //用户类别Id
UserKindName = objRow[convCoursewareCase_Resource_Rel.UserKindName] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.UserKindName].ToString().Trim(), //用户类别名
UserTypeId = objRow[convCoursewareCase_Resource_Rel.UserTypeId] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.UserTypeId].ToString().Trim(), //用户类型Id
IsDualVideo = TransNullToBool(objRow[convCoursewareCase_Resource_Rel.IsDualVideo].ToString().Trim()), //是否双视频
RecommendedDegreeId = objRow[convCoursewareCase_Resource_Rel.RecommendedDegreeId] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.RecommendedDegreeId].ToString().Trim(), //推荐度Id
RecommendedDegreeName = objRow[convCoursewareCase_Resource_Rel.RecommendedDegreeName] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.RecommendedDegreeName].ToString().Trim(), //推荐度名称
BrowseCount4Case = objRow[convCoursewareCase_Resource_Rel.BrowseCount4Case] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCoursewareCase_Resource_Rel.BrowseCount4Case].ToString().Trim()), //课例浏览次数
IdResource = objRow[convCoursewareCase_Resource_Rel.IdResource].ToString().Trim(), //资源流水号
ResourceID = objRow[convCoursewareCase_Resource_Rel.ResourceID] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.ResourceID].ToString().Trim(), //资源ID
ResourceName = objRow[convCoursewareCase_Resource_Rel.ResourceName] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.ResourceName].ToString().Trim(), //资源名称
IdFtpResource = objRow[convCoursewareCase_Resource_Rel.IdFtpResource] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.IdFtpResource].ToString().Trim(), //FTP资源流水号
IdFile = objRow[convCoursewareCase_Resource_Rel.IdFile] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.IdFile].ToString().Trim(), //文件流水号
FileName = objRow[convCoursewareCase_Resource_Rel.FileName] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.FileName].ToString().Trim(), //文件名称
FileType = objRow[convCoursewareCase_Resource_Rel.FileType] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.FileType].ToString().Trim(), //文件类型
SaveDate = objRow[convCoursewareCase_Resource_Rel.SaveDate] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.SaveDate].ToString().Trim(), //创建日期
FileSize = objRow[convCoursewareCase_Resource_Rel.FileSize] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.FileSize].ToString().Trim(), //文件大小
SaveTime = objRow[convCoursewareCase_Resource_Rel.SaveTime] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.SaveTime].ToString().Trim(), //创建时间
FtpResourceID = objRow[convCoursewareCase_Resource_Rel.FtpResourceID] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.FtpResourceID].ToString().Trim(), //FTP资源ID
FileOriginalName = objRow[convCoursewareCase_Resource_Rel.FileOriginalName] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.FileOriginalName].ToString().Trim(), //文件原名
FileDirName = objRow[convCoursewareCase_Resource_Rel.FileDirName] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.FileDirName].ToString().Trim(), //文件目录名
FileRename = objRow[convCoursewareCase_Resource_Rel.FileRename] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.FileRename].ToString().Trim(), //文件新名
FileUpDate = objRow[convCoursewareCase_Resource_Rel.FileUpDate] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.FileUpDate].ToString().Trim(), //创建日期
FileUpTime = objRow[convCoursewareCase_Resource_Rel.FileUpTime] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.FileUpTime].ToString().Trim(), //创建时间
SaveMode = TransNullToBool(objRow[convCoursewareCase_Resource_Rel.SaveMode].ToString().Trim()), //文件存放方式
IdResourceType = objRow[convCoursewareCase_Resource_Rel.IdResourceType] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.IdResourceType].ToString().Trim(), //资源类型流水号
ResourceTypeID = objRow[convCoursewareCase_Resource_Rel.ResourceTypeID] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.ResourceTypeID].ToString().Trim(), //资源类型ID
ResourceTypeName = objRow[convCoursewareCase_Resource_Rel.ResourceTypeName] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.ResourceTypeName].ToString().Trim(), //资源类型名称
ResourceOwner = objRow[convCoursewareCase_Resource_Rel.ResourceOwner] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.ResourceOwner].ToString().Trim(), //上传者
ftpFileType = objRow[convCoursewareCase_Resource_Rel.ftpFileType] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.ftpFileType].ToString().Trim(), //ftp文件类型
ftpFileSize = objRow[convCoursewareCase_Resource_Rel.ftpFileSize] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.ftpFileSize].ToString().Trim(), //ftp文件大小
ftpResourceOwner = objRow[convCoursewareCase_Resource_Rel.ftpResourceOwner] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.ftpResourceOwner].ToString().Trim(), //Ftp资源拥有者
FileOriginName = objRow[convCoursewareCase_Resource_Rel.FileOriginName] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.FileOriginName].ToString().Trim(), //原文件名
IsExistFile = TransNullToBool(objRow[convCoursewareCase_Resource_Rel.IsExistFile].ToString().Trim()), //是否存在文件
FileNewName = objRow[convCoursewareCase_Resource_Rel.FileNewName] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.FileNewName].ToString().Trim(), //新文件名
FileOldName = objRow[convCoursewareCase_Resource_Rel.FileOldName] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.FileOldName].ToString().Trim(), //旧文件名
IsMain = TransNullToBool(objRow[convCoursewareCase_Resource_Rel.IsMain].ToString().Trim()), //是否主资源
IdUsingMode = objRow[convCoursewareCase_Resource_Rel.IdUsingMode] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.IdUsingMode].ToString().Trim(), //资源使用模式流水号
IsVisible = TransNullToBool(objRow[convCoursewareCase_Resource_Rel.IsVisible].ToString().Trim()), //是否显示
IndexNO = objRow[convCoursewareCase_Resource_Rel.IndexNO] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCoursewareCase_Resource_Rel.IndexNO].ToString().Trim()), //序号
BrowseCount = objRow[convCoursewareCase_Resource_Rel.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCoursewareCase_Resource_Rel.BrowseCount].ToString().Trim()), //浏览次数
UpdDate = objRow[convCoursewareCase_Resource_Rel.UpdDate] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[convCoursewareCase_Resource_Rel.UpdUser] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.UpdUser].ToString().Trim(), //修改人
Memo = objRow[convCoursewareCase_Resource_Rel.Memo] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.Memo].ToString().Trim() //备注
};
objvCoursewareCase_Resource_RelEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvCoursewareCase_Resource_RelEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvCoursewareCase_Resource_RelDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvCoursewareCase_Resource_RelEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvCoursewareCase_Resource_RelEN objvCoursewareCase_Resource_RelEN = new clsvCoursewareCase_Resource_RelEN();
try
{
objvCoursewareCase_Resource_RelEN.IdMicroteachCaseResourceRel = TransNullToInt(objRow[convCoursewareCase_Resource_Rel.IdMicroteachCaseResourceRel].ToString().Trim()); //微格案例资源关系流水号
objvCoursewareCase_Resource_RelEN.FuncModuleId = objRow[convCoursewareCase_Resource_Rel.FuncModuleId].ToString().Trim(); //功能模块Id
objvCoursewareCase_Resource_RelEN.FuncModuleName = objRow[convCoursewareCase_Resource_Rel.FuncModuleName] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.FuncModuleName].ToString().Trim(); //功能模块名称
objvCoursewareCase_Resource_RelEN.IdMicroteachCase = objRow[convCoursewareCase_Resource_Rel.IdMicroteachCase] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvCoursewareCase_Resource_RelEN.CoursewareCaseID = objRow[convCoursewareCase_Resource_Rel.CoursewareCaseID] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.CoursewareCaseID].ToString().Trim(); //课件教学案例ID
objvCoursewareCase_Resource_RelEN.CoursewareCaseName = objRow[convCoursewareCase_Resource_Rel.CoursewareCaseName] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.CoursewareCaseName].ToString().Trim(); //课件教学案例名称
objvCoursewareCase_Resource_RelEN.CoursewareCaseTheme = objRow[convCoursewareCase_Resource_Rel.CoursewareCaseTheme] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.CoursewareCaseTheme].ToString().Trim(); //课件教学案例主题词
objvCoursewareCase_Resource_RelEN.IdCoursewareCaseType = objRow[convCoursewareCase_Resource_Rel.IdCoursewareCaseType] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.IdCoursewareCaseType].ToString().Trim(); //课件案例类型流水号
objvCoursewareCase_Resource_RelEN.CoursewareCaseTypeName = objRow[convCoursewareCase_Resource_Rel.CoursewareCaseTypeName] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.CoursewareCaseTypeName].ToString().Trim(); //课件案例类型名称
objvCoursewareCase_Resource_RelEN.CoursewareCaseText = objRow[convCoursewareCase_Resource_Rel.CoursewareCaseText] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.CoursewareCaseText].ToString().Trim(); //案例文本内容
objvCoursewareCase_Resource_RelEN.CoursewareCaseDate = objRow[convCoursewareCase_Resource_Rel.CoursewareCaseDate] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.CoursewareCaseDate].ToString().Trim(); //课件教学日期
objvCoursewareCase_Resource_RelEN.CoursewareCaseTime = objRow[convCoursewareCase_Resource_Rel.CoursewareCaseTime] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.CoursewareCaseTime].ToString().Trim(); //课件教学时间
objvCoursewareCase_Resource_RelEN.CoursewareCaseDateIn = objRow[convCoursewareCase_Resource_Rel.CoursewareCaseDateIn] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.CoursewareCaseDateIn].ToString().Trim(); //案例入库日期
objvCoursewareCase_Resource_RelEN.CoursewareCaseTimeIn = objRow[convCoursewareCase_Resource_Rel.CoursewareCaseTimeIn] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.CoursewareCaseTimeIn].ToString().Trim(); //案例入库时间
objvCoursewareCase_Resource_RelEN.IdStudyLevel = objRow[convCoursewareCase_Resource_Rel.IdStudyLevel] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvCoursewareCase_Resource_RelEN.StudyLevelName = objRow[convCoursewareCase_Resource_Rel.StudyLevelName] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.StudyLevelName].ToString().Trim(); //学段名称
objvCoursewareCase_Resource_RelEN.IdTeachingPlan = objRow[convCoursewareCase_Resource_Rel.IdTeachingPlan] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.IdTeachingPlan].ToString().Trim(); //教案流水号
objvCoursewareCase_Resource_RelEN.IdCaseType = objRow[convCoursewareCase_Resource_Rel.IdCaseType].ToString().Trim(); //案例类型流水号
objvCoursewareCase_Resource_RelEN.IdDiscipline = objRow[convCoursewareCase_Resource_Rel.IdDiscipline].ToString().Trim(); //学科流水号
objvCoursewareCase_Resource_RelEN.DisciplineID = objRow[convCoursewareCase_Resource_Rel.DisciplineID] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.DisciplineID].ToString().Trim(); //学科ID
objvCoursewareCase_Resource_RelEN.DisciplineName = objRow[convCoursewareCase_Resource_Rel.DisciplineName] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.DisciplineName].ToString().Trim(); //学科名称
objvCoursewareCase_Resource_RelEN.senateGaugeVersionID = objRow[convCoursewareCase_Resource_Rel.senateGaugeVersionID] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvCoursewareCase_Resource_RelEN.senateGaugeVersionName = objRow[convCoursewareCase_Resource_Rel.senateGaugeVersionName] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvCoursewareCase_Resource_RelEN.senateGaugeVersionTtlScore = objRow[convCoursewareCase_Resource_Rel.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convCoursewareCase_Resource_Rel.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvCoursewareCase_Resource_RelEN.VersionNo = objRow[convCoursewareCase_Resource_Rel.VersionNo] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCoursewareCase_Resource_Rel.VersionNo].ToString().Trim()); //版本号
objvCoursewareCase_Resource_RelEN.IdTeachSkill = objRow[convCoursewareCase_Resource_Rel.IdTeachSkill] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvCoursewareCase_Resource_RelEN.TeachSkillID = objRow[convCoursewareCase_Resource_Rel.TeachSkillID] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.TeachSkillID].ToString().Trim(); //教学技能ID
objvCoursewareCase_Resource_RelEN.SkillTypeName = objRow[convCoursewareCase_Resource_Rel.SkillTypeName] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.SkillTypeName].ToString().Trim(); //技能类型名称
objvCoursewareCase_Resource_RelEN.TeachSkillName = objRow[convCoursewareCase_Resource_Rel.TeachSkillName] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.TeachSkillName].ToString().Trim(); //教学技能名称
objvCoursewareCase_Resource_RelEN.TeachSkillTheory = objRow[convCoursewareCase_Resource_Rel.TeachSkillTheory] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvCoursewareCase_Resource_RelEN.TeachSkillOperMethod = objRow[convCoursewareCase_Resource_Rel.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvCoursewareCase_Resource_RelEN.IdSkillType = objRow[convCoursewareCase_Resource_Rel.IdSkillType] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.IdSkillType].ToString().Trim(); //技能类型流水号
objvCoursewareCase_Resource_RelEN.SkillTypeID = objRow[convCoursewareCase_Resource_Rel.SkillTypeID] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.SkillTypeID].ToString().Trim(); //技能类型ID
objvCoursewareCase_Resource_RelEN.CaseLevelId = objRow[convCoursewareCase_Resource_Rel.CaseLevelId] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.CaseLevelId].ToString().Trim(); //课例等级Id
objvCoursewareCase_Resource_RelEN.OwnerId = objRow[convCoursewareCase_Resource_Rel.OwnerId] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.OwnerId].ToString().Trim(); //拥有者Id
objvCoursewareCase_Resource_RelEN.StuName = objRow[convCoursewareCase_Resource_Rel.StuName] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.StuName].ToString().Trim(); //姓名
objvCoursewareCase_Resource_RelEN.StuID = objRow[convCoursewareCase_Resource_Rel.StuID] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.StuID].ToString().Trim(); //学号
objvCoursewareCase_Resource_RelEN.PoliticsName = objRow[convCoursewareCase_Resource_Rel.PoliticsName] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.PoliticsName].ToString().Trim(); //政治面貌
objvCoursewareCase_Resource_RelEN.SexDesc = objRow[convCoursewareCase_Resource_Rel.SexDesc] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.SexDesc].ToString().Trim(); //性别名称
objvCoursewareCase_Resource_RelEN.EthnicName = objRow[convCoursewareCase_Resource_Rel.EthnicName] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.EthnicName].ToString().Trim(); //民族名称
objvCoursewareCase_Resource_RelEN.UniZoneDesc = objRow[convCoursewareCase_Resource_Rel.UniZoneDesc] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.UniZoneDesc].ToString().Trim(); //校区名称
objvCoursewareCase_Resource_RelEN.StuTypeDesc = objRow[convCoursewareCase_Resource_Rel.StuTypeDesc] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.StuTypeDesc].ToString().Trim(); //学生类别名称
objvCoursewareCase_Resource_RelEN.IdXzCollege = objRow[convCoursewareCase_Resource_Rel.IdXzCollege] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.IdXzCollege].ToString().Trim(); //学院流水号
objvCoursewareCase_Resource_RelEN.CollegeName = objRow[convCoursewareCase_Resource_Rel.CollegeName] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.CollegeName].ToString().Trim(); //学院名称
objvCoursewareCase_Resource_RelEN.CollegeNameA = objRow[convCoursewareCase_Resource_Rel.CollegeNameA] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.CollegeNameA].ToString().Trim(); //学院名称简写
objvCoursewareCase_Resource_RelEN.IdXzMajor = objRow[convCoursewareCase_Resource_Rel.IdXzMajor] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.IdXzMajor].ToString().Trim(); //专业流水号
objvCoursewareCase_Resource_RelEN.MajorName = objRow[convCoursewareCase_Resource_Rel.MajorName] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.MajorName].ToString().Trim(); //专业名称
objvCoursewareCase_Resource_RelEN.IdGradeBase = objRow[convCoursewareCase_Resource_Rel.IdGradeBase] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.IdGradeBase].ToString().Trim(); //年级流水号
objvCoursewareCase_Resource_RelEN.GradeBaseName = objRow[convCoursewareCase_Resource_Rel.GradeBaseName] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.GradeBaseName].ToString().Trim(); //年级名称
objvCoursewareCase_Resource_RelEN.IdAdminCls = objRow[convCoursewareCase_Resource_Rel.IdAdminCls] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.IdAdminCls].ToString().Trim(); //行政班流水号
objvCoursewareCase_Resource_RelEN.AdminClsId = objRow[convCoursewareCase_Resource_Rel.AdminClsId] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.AdminClsId].ToString().Trim(); //行政班代号
objvCoursewareCase_Resource_RelEN.AdminClsName = objRow[convCoursewareCase_Resource_Rel.AdminClsName] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.AdminClsName].ToString().Trim(); //行政班名称
objvCoursewareCase_Resource_RelEN.Birthday = objRow[convCoursewareCase_Resource_Rel.Birthday] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.Birthday].ToString().Trim(); //出生日期
objvCoursewareCase_Resource_RelEN.NativePlace = objRow[convCoursewareCase_Resource_Rel.NativePlace] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.NativePlace].ToString().Trim(); //籍贯
objvCoursewareCase_Resource_RelEN.Duty = objRow[convCoursewareCase_Resource_Rel.Duty] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.Duty].ToString().Trim(); //职位
objvCoursewareCase_Resource_RelEN.IDCardNo = objRow[convCoursewareCase_Resource_Rel.IDCardNo] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.IDCardNo].ToString().Trim(); //身份证号
objvCoursewareCase_Resource_RelEN.StuCardNo = objRow[convCoursewareCase_Resource_Rel.StuCardNo] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.StuCardNo].ToString().Trim(); //学生证号
objvCoursewareCase_Resource_RelEN.LiveAddress = objRow[convCoursewareCase_Resource_Rel.LiveAddress] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.LiveAddress].ToString().Trim(); //居住地址
objvCoursewareCase_Resource_RelEN.HomePhone = objRow[convCoursewareCase_Resource_Rel.HomePhone] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.HomePhone].ToString().Trim(); //住宅电话
objvCoursewareCase_Resource_RelEN.EnrollmentDate = objRow[convCoursewareCase_Resource_Rel.EnrollmentDate] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.EnrollmentDate].ToString().Trim(); //入校日期
objvCoursewareCase_Resource_RelEN.PostCode = objRow[convCoursewareCase_Resource_Rel.PostCode] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.PostCode].ToString().Trim(); //邮编
objvCoursewareCase_Resource_RelEN.UserKindId = objRow[convCoursewareCase_Resource_Rel.UserKindId] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.UserKindId].ToString().Trim(); //用户类别Id
objvCoursewareCase_Resource_RelEN.UserKindName = objRow[convCoursewareCase_Resource_Rel.UserKindName] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.UserKindName].ToString().Trim(); //用户类别名
objvCoursewareCase_Resource_RelEN.UserTypeId = objRow[convCoursewareCase_Resource_Rel.UserTypeId] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.UserTypeId].ToString().Trim(); //用户类型Id
objvCoursewareCase_Resource_RelEN.IsDualVideo = TransNullToBool(objRow[convCoursewareCase_Resource_Rel.IsDualVideo].ToString().Trim()); //是否双视频
objvCoursewareCase_Resource_RelEN.RecommendedDegreeId = objRow[convCoursewareCase_Resource_Rel.RecommendedDegreeId] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvCoursewareCase_Resource_RelEN.RecommendedDegreeName = objRow[convCoursewareCase_Resource_Rel.RecommendedDegreeName] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvCoursewareCase_Resource_RelEN.BrowseCount4Case = objRow[convCoursewareCase_Resource_Rel.BrowseCount4Case] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCoursewareCase_Resource_Rel.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvCoursewareCase_Resource_RelEN.IdResource = objRow[convCoursewareCase_Resource_Rel.IdResource].ToString().Trim(); //资源流水号
objvCoursewareCase_Resource_RelEN.ResourceID = objRow[convCoursewareCase_Resource_Rel.ResourceID] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.ResourceID].ToString().Trim(); //资源ID
objvCoursewareCase_Resource_RelEN.ResourceName = objRow[convCoursewareCase_Resource_Rel.ResourceName] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.ResourceName].ToString().Trim(); //资源名称
objvCoursewareCase_Resource_RelEN.IdFtpResource = objRow[convCoursewareCase_Resource_Rel.IdFtpResource] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvCoursewareCase_Resource_RelEN.IdFile = objRow[convCoursewareCase_Resource_Rel.IdFile] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.IdFile].ToString().Trim(); //文件流水号
objvCoursewareCase_Resource_RelEN.FileName = objRow[convCoursewareCase_Resource_Rel.FileName] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.FileName].ToString().Trim(); //文件名称
objvCoursewareCase_Resource_RelEN.FileType = objRow[convCoursewareCase_Resource_Rel.FileType] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.FileType].ToString().Trim(); //文件类型
objvCoursewareCase_Resource_RelEN.SaveDate = objRow[convCoursewareCase_Resource_Rel.SaveDate] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.SaveDate].ToString().Trim(); //创建日期
objvCoursewareCase_Resource_RelEN.FileSize = objRow[convCoursewareCase_Resource_Rel.FileSize] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.FileSize].ToString().Trim(); //文件大小
objvCoursewareCase_Resource_RelEN.SaveTime = objRow[convCoursewareCase_Resource_Rel.SaveTime] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.SaveTime].ToString().Trim(); //创建时间
objvCoursewareCase_Resource_RelEN.FtpResourceID = objRow[convCoursewareCase_Resource_Rel.FtpResourceID] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.FtpResourceID].ToString().Trim(); //FTP资源ID
objvCoursewareCase_Resource_RelEN.FileOriginalName = objRow[convCoursewareCase_Resource_Rel.FileOriginalName] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.FileOriginalName].ToString().Trim(); //文件原名
objvCoursewareCase_Resource_RelEN.FileDirName = objRow[convCoursewareCase_Resource_Rel.FileDirName] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.FileDirName].ToString().Trim(); //文件目录名
objvCoursewareCase_Resource_RelEN.FileRename = objRow[convCoursewareCase_Resource_Rel.FileRename] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.FileRename].ToString().Trim(); //文件新名
objvCoursewareCase_Resource_RelEN.FileUpDate = objRow[convCoursewareCase_Resource_Rel.FileUpDate] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.FileUpDate].ToString().Trim(); //创建日期
objvCoursewareCase_Resource_RelEN.FileUpTime = objRow[convCoursewareCase_Resource_Rel.FileUpTime] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.FileUpTime].ToString().Trim(); //创建时间
objvCoursewareCase_Resource_RelEN.SaveMode = TransNullToBool(objRow[convCoursewareCase_Resource_Rel.SaveMode].ToString().Trim()); //文件存放方式
objvCoursewareCase_Resource_RelEN.IdResourceType = objRow[convCoursewareCase_Resource_Rel.IdResourceType] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.IdResourceType].ToString().Trim(); //资源类型流水号
objvCoursewareCase_Resource_RelEN.ResourceTypeID = objRow[convCoursewareCase_Resource_Rel.ResourceTypeID] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.ResourceTypeID].ToString().Trim(); //资源类型ID
objvCoursewareCase_Resource_RelEN.ResourceTypeName = objRow[convCoursewareCase_Resource_Rel.ResourceTypeName] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.ResourceTypeName].ToString().Trim(); //资源类型名称
objvCoursewareCase_Resource_RelEN.ResourceOwner = objRow[convCoursewareCase_Resource_Rel.ResourceOwner] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.ResourceOwner].ToString().Trim(); //上传者
objvCoursewareCase_Resource_RelEN.ftpFileType = objRow[convCoursewareCase_Resource_Rel.ftpFileType] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.ftpFileType].ToString().Trim(); //ftp文件类型
objvCoursewareCase_Resource_RelEN.ftpFileSize = objRow[convCoursewareCase_Resource_Rel.ftpFileSize] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.ftpFileSize].ToString().Trim(); //ftp文件大小
objvCoursewareCase_Resource_RelEN.ftpResourceOwner = objRow[convCoursewareCase_Resource_Rel.ftpResourceOwner] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvCoursewareCase_Resource_RelEN.FileOriginName = objRow[convCoursewareCase_Resource_Rel.FileOriginName] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.FileOriginName].ToString().Trim(); //原文件名
objvCoursewareCase_Resource_RelEN.IsExistFile = TransNullToBool(objRow[convCoursewareCase_Resource_Rel.IsExistFile].ToString().Trim()); //是否存在文件
objvCoursewareCase_Resource_RelEN.FileNewName = objRow[convCoursewareCase_Resource_Rel.FileNewName] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.FileNewName].ToString().Trim(); //新文件名
objvCoursewareCase_Resource_RelEN.FileOldName = objRow[convCoursewareCase_Resource_Rel.FileOldName] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.FileOldName].ToString().Trim(); //旧文件名
objvCoursewareCase_Resource_RelEN.IsMain = TransNullToBool(objRow[convCoursewareCase_Resource_Rel.IsMain].ToString().Trim()); //是否主资源
objvCoursewareCase_Resource_RelEN.IdUsingMode = objRow[convCoursewareCase_Resource_Rel.IdUsingMode] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.IdUsingMode].ToString().Trim(); //资源使用模式流水号
objvCoursewareCase_Resource_RelEN.IsVisible = TransNullToBool(objRow[convCoursewareCase_Resource_Rel.IsVisible].ToString().Trim()); //是否显示
objvCoursewareCase_Resource_RelEN.IndexNO = objRow[convCoursewareCase_Resource_Rel.IndexNO] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCoursewareCase_Resource_Rel.IndexNO].ToString().Trim()); //序号
objvCoursewareCase_Resource_RelEN.BrowseCount = objRow[convCoursewareCase_Resource_Rel.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCoursewareCase_Resource_Rel.BrowseCount].ToString().Trim()); //浏览次数
objvCoursewareCase_Resource_RelEN.UpdDate = objRow[convCoursewareCase_Resource_Rel.UpdDate] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.UpdDate].ToString().Trim(); //修改日期
objvCoursewareCase_Resource_RelEN.UpdUser = objRow[convCoursewareCase_Resource_Rel.UpdUser] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.UpdUser].ToString().Trim(); //修改人
objvCoursewareCase_Resource_RelEN.Memo = objRow[convCoursewareCase_Resource_Rel.Memo] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvCoursewareCase_Resource_RelDA: GetObjByDataRowvCoursewareCase_Resource_Rel)", objException.Message));
}
objvCoursewareCase_Resource_RelEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvCoursewareCase_Resource_RelEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvCoursewareCase_Resource_RelEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvCoursewareCase_Resource_RelEN objvCoursewareCase_Resource_RelEN = new clsvCoursewareCase_Resource_RelEN();
try
{
objvCoursewareCase_Resource_RelEN.IdMicroteachCaseResourceRel = TransNullToInt(objRow[convCoursewareCase_Resource_Rel.IdMicroteachCaseResourceRel].ToString().Trim()); //微格案例资源关系流水号
objvCoursewareCase_Resource_RelEN.FuncModuleId = objRow[convCoursewareCase_Resource_Rel.FuncModuleId].ToString().Trim(); //功能模块Id
objvCoursewareCase_Resource_RelEN.FuncModuleName = objRow[convCoursewareCase_Resource_Rel.FuncModuleName] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.FuncModuleName].ToString().Trim(); //功能模块名称
objvCoursewareCase_Resource_RelEN.IdMicroteachCase = objRow[convCoursewareCase_Resource_Rel.IdMicroteachCase] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvCoursewareCase_Resource_RelEN.CoursewareCaseID = objRow[convCoursewareCase_Resource_Rel.CoursewareCaseID] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.CoursewareCaseID].ToString().Trim(); //课件教学案例ID
objvCoursewareCase_Resource_RelEN.CoursewareCaseName = objRow[convCoursewareCase_Resource_Rel.CoursewareCaseName] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.CoursewareCaseName].ToString().Trim(); //课件教学案例名称
objvCoursewareCase_Resource_RelEN.CoursewareCaseTheme = objRow[convCoursewareCase_Resource_Rel.CoursewareCaseTheme] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.CoursewareCaseTheme].ToString().Trim(); //课件教学案例主题词
objvCoursewareCase_Resource_RelEN.IdCoursewareCaseType = objRow[convCoursewareCase_Resource_Rel.IdCoursewareCaseType] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.IdCoursewareCaseType].ToString().Trim(); //课件案例类型流水号
objvCoursewareCase_Resource_RelEN.CoursewareCaseTypeName = objRow[convCoursewareCase_Resource_Rel.CoursewareCaseTypeName] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.CoursewareCaseTypeName].ToString().Trim(); //课件案例类型名称
objvCoursewareCase_Resource_RelEN.CoursewareCaseText = objRow[convCoursewareCase_Resource_Rel.CoursewareCaseText] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.CoursewareCaseText].ToString().Trim(); //案例文本内容
objvCoursewareCase_Resource_RelEN.CoursewareCaseDate = objRow[convCoursewareCase_Resource_Rel.CoursewareCaseDate] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.CoursewareCaseDate].ToString().Trim(); //课件教学日期
objvCoursewareCase_Resource_RelEN.CoursewareCaseTime = objRow[convCoursewareCase_Resource_Rel.CoursewareCaseTime] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.CoursewareCaseTime].ToString().Trim(); //课件教学时间
objvCoursewareCase_Resource_RelEN.CoursewareCaseDateIn = objRow[convCoursewareCase_Resource_Rel.CoursewareCaseDateIn] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.CoursewareCaseDateIn].ToString().Trim(); //案例入库日期
objvCoursewareCase_Resource_RelEN.CoursewareCaseTimeIn = objRow[convCoursewareCase_Resource_Rel.CoursewareCaseTimeIn] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.CoursewareCaseTimeIn].ToString().Trim(); //案例入库时间
objvCoursewareCase_Resource_RelEN.IdStudyLevel = objRow[convCoursewareCase_Resource_Rel.IdStudyLevel] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvCoursewareCase_Resource_RelEN.StudyLevelName = objRow[convCoursewareCase_Resource_Rel.StudyLevelName] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.StudyLevelName].ToString().Trim(); //学段名称
objvCoursewareCase_Resource_RelEN.IdTeachingPlan = objRow[convCoursewareCase_Resource_Rel.IdTeachingPlan] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.IdTeachingPlan].ToString().Trim(); //教案流水号
objvCoursewareCase_Resource_RelEN.IdCaseType = objRow[convCoursewareCase_Resource_Rel.IdCaseType].ToString().Trim(); //案例类型流水号
objvCoursewareCase_Resource_RelEN.IdDiscipline = objRow[convCoursewareCase_Resource_Rel.IdDiscipline].ToString().Trim(); //学科流水号
objvCoursewareCase_Resource_RelEN.DisciplineID = objRow[convCoursewareCase_Resource_Rel.DisciplineID] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.DisciplineID].ToString().Trim(); //学科ID
objvCoursewareCase_Resource_RelEN.DisciplineName = objRow[convCoursewareCase_Resource_Rel.DisciplineName] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.DisciplineName].ToString().Trim(); //学科名称
objvCoursewareCase_Resource_RelEN.senateGaugeVersionID = objRow[convCoursewareCase_Resource_Rel.senateGaugeVersionID] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvCoursewareCase_Resource_RelEN.senateGaugeVersionName = objRow[convCoursewareCase_Resource_Rel.senateGaugeVersionName] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvCoursewareCase_Resource_RelEN.senateGaugeVersionTtlScore = objRow[convCoursewareCase_Resource_Rel.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convCoursewareCase_Resource_Rel.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvCoursewareCase_Resource_RelEN.VersionNo = objRow[convCoursewareCase_Resource_Rel.VersionNo] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCoursewareCase_Resource_Rel.VersionNo].ToString().Trim()); //版本号
objvCoursewareCase_Resource_RelEN.IdTeachSkill = objRow[convCoursewareCase_Resource_Rel.IdTeachSkill] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvCoursewareCase_Resource_RelEN.TeachSkillID = objRow[convCoursewareCase_Resource_Rel.TeachSkillID] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.TeachSkillID].ToString().Trim(); //教学技能ID
objvCoursewareCase_Resource_RelEN.SkillTypeName = objRow[convCoursewareCase_Resource_Rel.SkillTypeName] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.SkillTypeName].ToString().Trim(); //技能类型名称
objvCoursewareCase_Resource_RelEN.TeachSkillName = objRow[convCoursewareCase_Resource_Rel.TeachSkillName] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.TeachSkillName].ToString().Trim(); //教学技能名称
objvCoursewareCase_Resource_RelEN.TeachSkillTheory = objRow[convCoursewareCase_Resource_Rel.TeachSkillTheory] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvCoursewareCase_Resource_RelEN.TeachSkillOperMethod = objRow[convCoursewareCase_Resource_Rel.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvCoursewareCase_Resource_RelEN.IdSkillType = objRow[convCoursewareCase_Resource_Rel.IdSkillType] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.IdSkillType].ToString().Trim(); //技能类型流水号
objvCoursewareCase_Resource_RelEN.SkillTypeID = objRow[convCoursewareCase_Resource_Rel.SkillTypeID] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.SkillTypeID].ToString().Trim(); //技能类型ID
objvCoursewareCase_Resource_RelEN.CaseLevelId = objRow[convCoursewareCase_Resource_Rel.CaseLevelId] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.CaseLevelId].ToString().Trim(); //课例等级Id
objvCoursewareCase_Resource_RelEN.OwnerId = objRow[convCoursewareCase_Resource_Rel.OwnerId] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.OwnerId].ToString().Trim(); //拥有者Id
objvCoursewareCase_Resource_RelEN.StuName = objRow[convCoursewareCase_Resource_Rel.StuName] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.StuName].ToString().Trim(); //姓名
objvCoursewareCase_Resource_RelEN.StuID = objRow[convCoursewareCase_Resource_Rel.StuID] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.StuID].ToString().Trim(); //学号
objvCoursewareCase_Resource_RelEN.PoliticsName = objRow[convCoursewareCase_Resource_Rel.PoliticsName] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.PoliticsName].ToString().Trim(); //政治面貌
objvCoursewareCase_Resource_RelEN.SexDesc = objRow[convCoursewareCase_Resource_Rel.SexDesc] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.SexDesc].ToString().Trim(); //性别名称
objvCoursewareCase_Resource_RelEN.EthnicName = objRow[convCoursewareCase_Resource_Rel.EthnicName] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.EthnicName].ToString().Trim(); //民族名称
objvCoursewareCase_Resource_RelEN.UniZoneDesc = objRow[convCoursewareCase_Resource_Rel.UniZoneDesc] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.UniZoneDesc].ToString().Trim(); //校区名称
objvCoursewareCase_Resource_RelEN.StuTypeDesc = objRow[convCoursewareCase_Resource_Rel.StuTypeDesc] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.StuTypeDesc].ToString().Trim(); //学生类别名称
objvCoursewareCase_Resource_RelEN.IdXzCollege = objRow[convCoursewareCase_Resource_Rel.IdXzCollege] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.IdXzCollege].ToString().Trim(); //学院流水号
objvCoursewareCase_Resource_RelEN.CollegeName = objRow[convCoursewareCase_Resource_Rel.CollegeName] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.CollegeName].ToString().Trim(); //学院名称
objvCoursewareCase_Resource_RelEN.CollegeNameA = objRow[convCoursewareCase_Resource_Rel.CollegeNameA] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.CollegeNameA].ToString().Trim(); //学院名称简写
objvCoursewareCase_Resource_RelEN.IdXzMajor = objRow[convCoursewareCase_Resource_Rel.IdXzMajor] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.IdXzMajor].ToString().Trim(); //专业流水号
objvCoursewareCase_Resource_RelEN.MajorName = objRow[convCoursewareCase_Resource_Rel.MajorName] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.MajorName].ToString().Trim(); //专业名称
objvCoursewareCase_Resource_RelEN.IdGradeBase = objRow[convCoursewareCase_Resource_Rel.IdGradeBase] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.IdGradeBase].ToString().Trim(); //年级流水号
objvCoursewareCase_Resource_RelEN.GradeBaseName = objRow[convCoursewareCase_Resource_Rel.GradeBaseName] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.GradeBaseName].ToString().Trim(); //年级名称
objvCoursewareCase_Resource_RelEN.IdAdminCls = objRow[convCoursewareCase_Resource_Rel.IdAdminCls] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.IdAdminCls].ToString().Trim(); //行政班流水号
objvCoursewareCase_Resource_RelEN.AdminClsId = objRow[convCoursewareCase_Resource_Rel.AdminClsId] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.AdminClsId].ToString().Trim(); //行政班代号
objvCoursewareCase_Resource_RelEN.AdminClsName = objRow[convCoursewareCase_Resource_Rel.AdminClsName] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.AdminClsName].ToString().Trim(); //行政班名称
objvCoursewareCase_Resource_RelEN.Birthday = objRow[convCoursewareCase_Resource_Rel.Birthday] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.Birthday].ToString().Trim(); //出生日期
objvCoursewareCase_Resource_RelEN.NativePlace = objRow[convCoursewareCase_Resource_Rel.NativePlace] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.NativePlace].ToString().Trim(); //籍贯
objvCoursewareCase_Resource_RelEN.Duty = objRow[convCoursewareCase_Resource_Rel.Duty] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.Duty].ToString().Trim(); //职位
objvCoursewareCase_Resource_RelEN.IDCardNo = objRow[convCoursewareCase_Resource_Rel.IDCardNo] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.IDCardNo].ToString().Trim(); //身份证号
objvCoursewareCase_Resource_RelEN.StuCardNo = objRow[convCoursewareCase_Resource_Rel.StuCardNo] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.StuCardNo].ToString().Trim(); //学生证号
objvCoursewareCase_Resource_RelEN.LiveAddress = objRow[convCoursewareCase_Resource_Rel.LiveAddress] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.LiveAddress].ToString().Trim(); //居住地址
objvCoursewareCase_Resource_RelEN.HomePhone = objRow[convCoursewareCase_Resource_Rel.HomePhone] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.HomePhone].ToString().Trim(); //住宅电话
objvCoursewareCase_Resource_RelEN.EnrollmentDate = objRow[convCoursewareCase_Resource_Rel.EnrollmentDate] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.EnrollmentDate].ToString().Trim(); //入校日期
objvCoursewareCase_Resource_RelEN.PostCode = objRow[convCoursewareCase_Resource_Rel.PostCode] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.PostCode].ToString().Trim(); //邮编
objvCoursewareCase_Resource_RelEN.UserKindId = objRow[convCoursewareCase_Resource_Rel.UserKindId] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.UserKindId].ToString().Trim(); //用户类别Id
objvCoursewareCase_Resource_RelEN.UserKindName = objRow[convCoursewareCase_Resource_Rel.UserKindName] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.UserKindName].ToString().Trim(); //用户类别名
objvCoursewareCase_Resource_RelEN.UserTypeId = objRow[convCoursewareCase_Resource_Rel.UserTypeId] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.UserTypeId].ToString().Trim(); //用户类型Id
objvCoursewareCase_Resource_RelEN.IsDualVideo = TransNullToBool(objRow[convCoursewareCase_Resource_Rel.IsDualVideo].ToString().Trim()); //是否双视频
objvCoursewareCase_Resource_RelEN.RecommendedDegreeId = objRow[convCoursewareCase_Resource_Rel.RecommendedDegreeId] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvCoursewareCase_Resource_RelEN.RecommendedDegreeName = objRow[convCoursewareCase_Resource_Rel.RecommendedDegreeName] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvCoursewareCase_Resource_RelEN.BrowseCount4Case = objRow[convCoursewareCase_Resource_Rel.BrowseCount4Case] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCoursewareCase_Resource_Rel.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvCoursewareCase_Resource_RelEN.IdResource = objRow[convCoursewareCase_Resource_Rel.IdResource].ToString().Trim(); //资源流水号
objvCoursewareCase_Resource_RelEN.ResourceID = objRow[convCoursewareCase_Resource_Rel.ResourceID] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.ResourceID].ToString().Trim(); //资源ID
objvCoursewareCase_Resource_RelEN.ResourceName = objRow[convCoursewareCase_Resource_Rel.ResourceName] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.ResourceName].ToString().Trim(); //资源名称
objvCoursewareCase_Resource_RelEN.IdFtpResource = objRow[convCoursewareCase_Resource_Rel.IdFtpResource] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvCoursewareCase_Resource_RelEN.IdFile = objRow[convCoursewareCase_Resource_Rel.IdFile] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.IdFile].ToString().Trim(); //文件流水号
objvCoursewareCase_Resource_RelEN.FileName = objRow[convCoursewareCase_Resource_Rel.FileName] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.FileName].ToString().Trim(); //文件名称
objvCoursewareCase_Resource_RelEN.FileType = objRow[convCoursewareCase_Resource_Rel.FileType] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.FileType].ToString().Trim(); //文件类型
objvCoursewareCase_Resource_RelEN.SaveDate = objRow[convCoursewareCase_Resource_Rel.SaveDate] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.SaveDate].ToString().Trim(); //创建日期
objvCoursewareCase_Resource_RelEN.FileSize = objRow[convCoursewareCase_Resource_Rel.FileSize] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.FileSize].ToString().Trim(); //文件大小
objvCoursewareCase_Resource_RelEN.SaveTime = objRow[convCoursewareCase_Resource_Rel.SaveTime] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.SaveTime].ToString().Trim(); //创建时间
objvCoursewareCase_Resource_RelEN.FtpResourceID = objRow[convCoursewareCase_Resource_Rel.FtpResourceID] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.FtpResourceID].ToString().Trim(); //FTP资源ID
objvCoursewareCase_Resource_RelEN.FileOriginalName = objRow[convCoursewareCase_Resource_Rel.FileOriginalName] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.FileOriginalName].ToString().Trim(); //文件原名
objvCoursewareCase_Resource_RelEN.FileDirName = objRow[convCoursewareCase_Resource_Rel.FileDirName] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.FileDirName].ToString().Trim(); //文件目录名
objvCoursewareCase_Resource_RelEN.FileRename = objRow[convCoursewareCase_Resource_Rel.FileRename] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.FileRename].ToString().Trim(); //文件新名
objvCoursewareCase_Resource_RelEN.FileUpDate = objRow[convCoursewareCase_Resource_Rel.FileUpDate] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.FileUpDate].ToString().Trim(); //创建日期
objvCoursewareCase_Resource_RelEN.FileUpTime = objRow[convCoursewareCase_Resource_Rel.FileUpTime] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.FileUpTime].ToString().Trim(); //创建时间
objvCoursewareCase_Resource_RelEN.SaveMode = TransNullToBool(objRow[convCoursewareCase_Resource_Rel.SaveMode].ToString().Trim()); //文件存放方式
objvCoursewareCase_Resource_RelEN.IdResourceType = objRow[convCoursewareCase_Resource_Rel.IdResourceType] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.IdResourceType].ToString().Trim(); //资源类型流水号
objvCoursewareCase_Resource_RelEN.ResourceTypeID = objRow[convCoursewareCase_Resource_Rel.ResourceTypeID] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.ResourceTypeID].ToString().Trim(); //资源类型ID
objvCoursewareCase_Resource_RelEN.ResourceTypeName = objRow[convCoursewareCase_Resource_Rel.ResourceTypeName] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.ResourceTypeName].ToString().Trim(); //资源类型名称
objvCoursewareCase_Resource_RelEN.ResourceOwner = objRow[convCoursewareCase_Resource_Rel.ResourceOwner] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.ResourceOwner].ToString().Trim(); //上传者
objvCoursewareCase_Resource_RelEN.ftpFileType = objRow[convCoursewareCase_Resource_Rel.ftpFileType] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.ftpFileType].ToString().Trim(); //ftp文件类型
objvCoursewareCase_Resource_RelEN.ftpFileSize = objRow[convCoursewareCase_Resource_Rel.ftpFileSize] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.ftpFileSize].ToString().Trim(); //ftp文件大小
objvCoursewareCase_Resource_RelEN.ftpResourceOwner = objRow[convCoursewareCase_Resource_Rel.ftpResourceOwner] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvCoursewareCase_Resource_RelEN.FileOriginName = objRow[convCoursewareCase_Resource_Rel.FileOriginName] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.FileOriginName].ToString().Trim(); //原文件名
objvCoursewareCase_Resource_RelEN.IsExistFile = TransNullToBool(objRow[convCoursewareCase_Resource_Rel.IsExistFile].ToString().Trim()); //是否存在文件
objvCoursewareCase_Resource_RelEN.FileNewName = objRow[convCoursewareCase_Resource_Rel.FileNewName] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.FileNewName].ToString().Trim(); //新文件名
objvCoursewareCase_Resource_RelEN.FileOldName = objRow[convCoursewareCase_Resource_Rel.FileOldName] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.FileOldName].ToString().Trim(); //旧文件名
objvCoursewareCase_Resource_RelEN.IsMain = TransNullToBool(objRow[convCoursewareCase_Resource_Rel.IsMain].ToString().Trim()); //是否主资源
objvCoursewareCase_Resource_RelEN.IdUsingMode = objRow[convCoursewareCase_Resource_Rel.IdUsingMode] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.IdUsingMode].ToString().Trim(); //资源使用模式流水号
objvCoursewareCase_Resource_RelEN.IsVisible = TransNullToBool(objRow[convCoursewareCase_Resource_Rel.IsVisible].ToString().Trim()); //是否显示
objvCoursewareCase_Resource_RelEN.IndexNO = objRow[convCoursewareCase_Resource_Rel.IndexNO] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCoursewareCase_Resource_Rel.IndexNO].ToString().Trim()); //序号
objvCoursewareCase_Resource_RelEN.BrowseCount = objRow[convCoursewareCase_Resource_Rel.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCoursewareCase_Resource_Rel.BrowseCount].ToString().Trim()); //浏览次数
objvCoursewareCase_Resource_RelEN.UpdDate = objRow[convCoursewareCase_Resource_Rel.UpdDate] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.UpdDate].ToString().Trim(); //修改日期
objvCoursewareCase_Resource_RelEN.UpdUser = objRow[convCoursewareCase_Resource_Rel.UpdUser] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.UpdUser].ToString().Trim(); //修改人
objvCoursewareCase_Resource_RelEN.Memo = objRow[convCoursewareCase_Resource_Rel.Memo] == DBNull.Value ? null : objRow[convCoursewareCase_Resource_Rel.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvCoursewareCase_Resource_RelDA: GetObjByDataRow)", objException.Message));
}
objvCoursewareCase_Resource_RelEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvCoursewareCase_Resource_RelEN;
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
objSQL = clsvCoursewareCase_Resource_RelDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvCoursewareCase_Resource_RelEN._CurrTabName, convCoursewareCase_Resource_Rel.IdMicroteachCaseResourceRel, 8, "");
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
objSQL = clsvCoursewareCase_Resource_RelDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvCoursewareCase_Resource_RelEN._CurrTabName, convCoursewareCase_Resource_Rel.IdMicroteachCaseResourceRel, 8, strPrefix);
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
 objSQL = clsvCoursewareCase_Resource_RelDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select IdMicroteachCaseResourceRel from vCoursewareCase_Resource_Rel where " + strCondition;
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
 objSQL = clsvCoursewareCase_Resource_RelDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select IdMicroteachCaseResourceRel from vCoursewareCase_Resource_Rel where " + strCondition;
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
 objSQL = clsvCoursewareCase_Resource_RelDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vCoursewareCase_Resource_Rel", "IdMicroteachCaseResourceRel = " + ""+ lngIdMicroteachCaseResourceRel+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvCoursewareCase_Resource_RelDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCoursewareCase_Resource_RelDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vCoursewareCase_Resource_Rel", strCondition))
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
objSQL = clsvCoursewareCase_Resource_RelDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vCoursewareCase_Resource_Rel");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvCoursewareCase_Resource_RelENS">源对象</param>
 /// <param name = "objvCoursewareCase_Resource_RelENT">目标对象</param>
public void CopyTo(clsvCoursewareCase_Resource_RelEN objvCoursewareCase_Resource_RelENS, clsvCoursewareCase_Resource_RelEN objvCoursewareCase_Resource_RelENT)
{
objvCoursewareCase_Resource_RelENT.IdMicroteachCaseResourceRel = objvCoursewareCase_Resource_RelENS.IdMicroteachCaseResourceRel; //微格案例资源关系流水号
objvCoursewareCase_Resource_RelENT.FuncModuleId = objvCoursewareCase_Resource_RelENS.FuncModuleId; //功能模块Id
objvCoursewareCase_Resource_RelENT.FuncModuleName = objvCoursewareCase_Resource_RelENS.FuncModuleName; //功能模块名称
objvCoursewareCase_Resource_RelENT.IdMicroteachCase = objvCoursewareCase_Resource_RelENS.IdMicroteachCase; //微格教学案例流水号
objvCoursewareCase_Resource_RelENT.CoursewareCaseID = objvCoursewareCase_Resource_RelENS.CoursewareCaseID; //课件教学案例ID
objvCoursewareCase_Resource_RelENT.CoursewareCaseName = objvCoursewareCase_Resource_RelENS.CoursewareCaseName; //课件教学案例名称
objvCoursewareCase_Resource_RelENT.CoursewareCaseTheme = objvCoursewareCase_Resource_RelENS.CoursewareCaseTheme; //课件教学案例主题词
objvCoursewareCase_Resource_RelENT.IdCoursewareCaseType = objvCoursewareCase_Resource_RelENS.IdCoursewareCaseType; //课件案例类型流水号
objvCoursewareCase_Resource_RelENT.CoursewareCaseTypeName = objvCoursewareCase_Resource_RelENS.CoursewareCaseTypeName; //课件案例类型名称
objvCoursewareCase_Resource_RelENT.CoursewareCaseText = objvCoursewareCase_Resource_RelENS.CoursewareCaseText; //案例文本内容
objvCoursewareCase_Resource_RelENT.CoursewareCaseDate = objvCoursewareCase_Resource_RelENS.CoursewareCaseDate; //课件教学日期
objvCoursewareCase_Resource_RelENT.CoursewareCaseTime = objvCoursewareCase_Resource_RelENS.CoursewareCaseTime; //课件教学时间
objvCoursewareCase_Resource_RelENT.CoursewareCaseDateIn = objvCoursewareCase_Resource_RelENS.CoursewareCaseDateIn; //案例入库日期
objvCoursewareCase_Resource_RelENT.CoursewareCaseTimeIn = objvCoursewareCase_Resource_RelENS.CoursewareCaseTimeIn; //案例入库时间
objvCoursewareCase_Resource_RelENT.IdStudyLevel = objvCoursewareCase_Resource_RelENS.IdStudyLevel; //id_StudyLevel
objvCoursewareCase_Resource_RelENT.StudyLevelName = objvCoursewareCase_Resource_RelENS.StudyLevelName; //学段名称
objvCoursewareCase_Resource_RelENT.IdTeachingPlan = objvCoursewareCase_Resource_RelENS.IdTeachingPlan; //教案流水号
objvCoursewareCase_Resource_RelENT.IdCaseType = objvCoursewareCase_Resource_RelENS.IdCaseType; //案例类型流水号
objvCoursewareCase_Resource_RelENT.IdDiscipline = objvCoursewareCase_Resource_RelENS.IdDiscipline; //学科流水号
objvCoursewareCase_Resource_RelENT.DisciplineID = objvCoursewareCase_Resource_RelENS.DisciplineID; //学科ID
objvCoursewareCase_Resource_RelENT.DisciplineName = objvCoursewareCase_Resource_RelENS.DisciplineName; //学科名称
objvCoursewareCase_Resource_RelENT.senateGaugeVersionID = objvCoursewareCase_Resource_RelENS.senateGaugeVersionID; //评价量表版本ID
objvCoursewareCase_Resource_RelENT.senateGaugeVersionName = objvCoursewareCase_Resource_RelENS.senateGaugeVersionName; //评价量表版本名称
objvCoursewareCase_Resource_RelENT.senateGaugeVersionTtlScore = objvCoursewareCase_Resource_RelENS.senateGaugeVersionTtlScore; //评价量表版本总分
objvCoursewareCase_Resource_RelENT.VersionNo = objvCoursewareCase_Resource_RelENS.VersionNo; //版本号
objvCoursewareCase_Resource_RelENT.IdTeachSkill = objvCoursewareCase_Resource_RelENS.IdTeachSkill; //教学技能流水号
objvCoursewareCase_Resource_RelENT.TeachSkillID = objvCoursewareCase_Resource_RelENS.TeachSkillID; //教学技能ID
objvCoursewareCase_Resource_RelENT.SkillTypeName = objvCoursewareCase_Resource_RelENS.SkillTypeName; //技能类型名称
objvCoursewareCase_Resource_RelENT.TeachSkillName = objvCoursewareCase_Resource_RelENS.TeachSkillName; //教学技能名称
objvCoursewareCase_Resource_RelENT.TeachSkillTheory = objvCoursewareCase_Resource_RelENS.TeachSkillTheory; //教学技能理论阐述
objvCoursewareCase_Resource_RelENT.TeachSkillOperMethod = objvCoursewareCase_Resource_RelENS.TeachSkillOperMethod; //教学技能实践操作方法
objvCoursewareCase_Resource_RelENT.IdSkillType = objvCoursewareCase_Resource_RelENS.IdSkillType; //技能类型流水号
objvCoursewareCase_Resource_RelENT.SkillTypeID = objvCoursewareCase_Resource_RelENS.SkillTypeID; //技能类型ID
objvCoursewareCase_Resource_RelENT.CaseLevelId = objvCoursewareCase_Resource_RelENS.CaseLevelId; //课例等级Id
objvCoursewareCase_Resource_RelENT.OwnerId = objvCoursewareCase_Resource_RelENS.OwnerId; //拥有者Id
objvCoursewareCase_Resource_RelENT.StuName = objvCoursewareCase_Resource_RelENS.StuName; //姓名
objvCoursewareCase_Resource_RelENT.StuID = objvCoursewareCase_Resource_RelENS.StuID; //学号
objvCoursewareCase_Resource_RelENT.PoliticsName = objvCoursewareCase_Resource_RelENS.PoliticsName; //政治面貌
objvCoursewareCase_Resource_RelENT.SexDesc = objvCoursewareCase_Resource_RelENS.SexDesc; //性别名称
objvCoursewareCase_Resource_RelENT.EthnicName = objvCoursewareCase_Resource_RelENS.EthnicName; //民族名称
objvCoursewareCase_Resource_RelENT.UniZoneDesc = objvCoursewareCase_Resource_RelENS.UniZoneDesc; //校区名称
objvCoursewareCase_Resource_RelENT.StuTypeDesc = objvCoursewareCase_Resource_RelENS.StuTypeDesc; //学生类别名称
objvCoursewareCase_Resource_RelENT.IdXzCollege = objvCoursewareCase_Resource_RelENS.IdXzCollege; //学院流水号
objvCoursewareCase_Resource_RelENT.CollegeName = objvCoursewareCase_Resource_RelENS.CollegeName; //学院名称
objvCoursewareCase_Resource_RelENT.CollegeNameA = objvCoursewareCase_Resource_RelENS.CollegeNameA; //学院名称简写
objvCoursewareCase_Resource_RelENT.IdXzMajor = objvCoursewareCase_Resource_RelENS.IdXzMajor; //专业流水号
objvCoursewareCase_Resource_RelENT.MajorName = objvCoursewareCase_Resource_RelENS.MajorName; //专业名称
objvCoursewareCase_Resource_RelENT.IdGradeBase = objvCoursewareCase_Resource_RelENS.IdGradeBase; //年级流水号
objvCoursewareCase_Resource_RelENT.GradeBaseName = objvCoursewareCase_Resource_RelENS.GradeBaseName; //年级名称
objvCoursewareCase_Resource_RelENT.IdAdminCls = objvCoursewareCase_Resource_RelENS.IdAdminCls; //行政班流水号
objvCoursewareCase_Resource_RelENT.AdminClsId = objvCoursewareCase_Resource_RelENS.AdminClsId; //行政班代号
objvCoursewareCase_Resource_RelENT.AdminClsName = objvCoursewareCase_Resource_RelENS.AdminClsName; //行政班名称
objvCoursewareCase_Resource_RelENT.Birthday = objvCoursewareCase_Resource_RelENS.Birthday; //出生日期
objvCoursewareCase_Resource_RelENT.NativePlace = objvCoursewareCase_Resource_RelENS.NativePlace; //籍贯
objvCoursewareCase_Resource_RelENT.Duty = objvCoursewareCase_Resource_RelENS.Duty; //职位
objvCoursewareCase_Resource_RelENT.IDCardNo = objvCoursewareCase_Resource_RelENS.IDCardNo; //身份证号
objvCoursewareCase_Resource_RelENT.StuCardNo = objvCoursewareCase_Resource_RelENS.StuCardNo; //学生证号
objvCoursewareCase_Resource_RelENT.LiveAddress = objvCoursewareCase_Resource_RelENS.LiveAddress; //居住地址
objvCoursewareCase_Resource_RelENT.HomePhone = objvCoursewareCase_Resource_RelENS.HomePhone; //住宅电话
objvCoursewareCase_Resource_RelENT.EnrollmentDate = objvCoursewareCase_Resource_RelENS.EnrollmentDate; //入校日期
objvCoursewareCase_Resource_RelENT.PostCode = objvCoursewareCase_Resource_RelENS.PostCode; //邮编
objvCoursewareCase_Resource_RelENT.UserKindId = objvCoursewareCase_Resource_RelENS.UserKindId; //用户类别Id
objvCoursewareCase_Resource_RelENT.UserKindName = objvCoursewareCase_Resource_RelENS.UserKindName; //用户类别名
objvCoursewareCase_Resource_RelENT.UserTypeId = objvCoursewareCase_Resource_RelENS.UserTypeId; //用户类型Id
objvCoursewareCase_Resource_RelENT.IsDualVideo = objvCoursewareCase_Resource_RelENS.IsDualVideo; //是否双视频
objvCoursewareCase_Resource_RelENT.RecommendedDegreeId = objvCoursewareCase_Resource_RelENS.RecommendedDegreeId; //推荐度Id
objvCoursewareCase_Resource_RelENT.RecommendedDegreeName = objvCoursewareCase_Resource_RelENS.RecommendedDegreeName; //推荐度名称
objvCoursewareCase_Resource_RelENT.BrowseCount4Case = objvCoursewareCase_Resource_RelENS.BrowseCount4Case; //课例浏览次数
objvCoursewareCase_Resource_RelENT.IdResource = objvCoursewareCase_Resource_RelENS.IdResource; //资源流水号
objvCoursewareCase_Resource_RelENT.ResourceID = objvCoursewareCase_Resource_RelENS.ResourceID; //资源ID
objvCoursewareCase_Resource_RelENT.ResourceName = objvCoursewareCase_Resource_RelENS.ResourceName; //资源名称
objvCoursewareCase_Resource_RelENT.IdFtpResource = objvCoursewareCase_Resource_RelENS.IdFtpResource; //FTP资源流水号
objvCoursewareCase_Resource_RelENT.IdFile = objvCoursewareCase_Resource_RelENS.IdFile; //文件流水号
objvCoursewareCase_Resource_RelENT.FileName = objvCoursewareCase_Resource_RelENS.FileName; //文件名称
objvCoursewareCase_Resource_RelENT.FileType = objvCoursewareCase_Resource_RelENS.FileType; //文件类型
objvCoursewareCase_Resource_RelENT.SaveDate = objvCoursewareCase_Resource_RelENS.SaveDate; //创建日期
objvCoursewareCase_Resource_RelENT.FileSize = objvCoursewareCase_Resource_RelENS.FileSize; //文件大小
objvCoursewareCase_Resource_RelENT.SaveTime = objvCoursewareCase_Resource_RelENS.SaveTime; //创建时间
objvCoursewareCase_Resource_RelENT.FtpResourceID = objvCoursewareCase_Resource_RelENS.FtpResourceID; //FTP资源ID
objvCoursewareCase_Resource_RelENT.FileOriginalName = objvCoursewareCase_Resource_RelENS.FileOriginalName; //文件原名
objvCoursewareCase_Resource_RelENT.FileDirName = objvCoursewareCase_Resource_RelENS.FileDirName; //文件目录名
objvCoursewareCase_Resource_RelENT.FileRename = objvCoursewareCase_Resource_RelENS.FileRename; //文件新名
objvCoursewareCase_Resource_RelENT.FileUpDate = objvCoursewareCase_Resource_RelENS.FileUpDate; //创建日期
objvCoursewareCase_Resource_RelENT.FileUpTime = objvCoursewareCase_Resource_RelENS.FileUpTime; //创建时间
objvCoursewareCase_Resource_RelENT.SaveMode = objvCoursewareCase_Resource_RelENS.SaveMode; //文件存放方式
objvCoursewareCase_Resource_RelENT.IdResourceType = objvCoursewareCase_Resource_RelENS.IdResourceType; //资源类型流水号
objvCoursewareCase_Resource_RelENT.ResourceTypeID = objvCoursewareCase_Resource_RelENS.ResourceTypeID; //资源类型ID
objvCoursewareCase_Resource_RelENT.ResourceTypeName = objvCoursewareCase_Resource_RelENS.ResourceTypeName; //资源类型名称
objvCoursewareCase_Resource_RelENT.ResourceOwner = objvCoursewareCase_Resource_RelENS.ResourceOwner; //上传者
objvCoursewareCase_Resource_RelENT.ftpFileType = objvCoursewareCase_Resource_RelENS.ftpFileType; //ftp文件类型
objvCoursewareCase_Resource_RelENT.ftpFileSize = objvCoursewareCase_Resource_RelENS.ftpFileSize; //ftp文件大小
objvCoursewareCase_Resource_RelENT.ftpResourceOwner = objvCoursewareCase_Resource_RelENS.ftpResourceOwner; //Ftp资源拥有者
objvCoursewareCase_Resource_RelENT.FileOriginName = objvCoursewareCase_Resource_RelENS.FileOriginName; //原文件名
objvCoursewareCase_Resource_RelENT.IsExistFile = objvCoursewareCase_Resource_RelENS.IsExistFile; //是否存在文件
objvCoursewareCase_Resource_RelENT.FileNewName = objvCoursewareCase_Resource_RelENS.FileNewName; //新文件名
objvCoursewareCase_Resource_RelENT.FileOldName = objvCoursewareCase_Resource_RelENS.FileOldName; //旧文件名
objvCoursewareCase_Resource_RelENT.IsMain = objvCoursewareCase_Resource_RelENS.IsMain; //是否主资源
objvCoursewareCase_Resource_RelENT.IdUsingMode = objvCoursewareCase_Resource_RelENS.IdUsingMode; //资源使用模式流水号
objvCoursewareCase_Resource_RelENT.IsVisible = objvCoursewareCase_Resource_RelENS.IsVisible; //是否显示
objvCoursewareCase_Resource_RelENT.IndexNO = objvCoursewareCase_Resource_RelENS.IndexNO; //序号
objvCoursewareCase_Resource_RelENT.BrowseCount = objvCoursewareCase_Resource_RelENS.BrowseCount; //浏览次数
objvCoursewareCase_Resource_RelENT.UpdDate = objvCoursewareCase_Resource_RelENS.UpdDate; //修改日期
objvCoursewareCase_Resource_RelENT.UpdUser = objvCoursewareCase_Resource_RelENS.UpdUser; //修改人
objvCoursewareCase_Resource_RelENT.Memo = objvCoursewareCase_Resource_RelENS.Memo; //备注
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvCoursewareCase_Resource_RelEN objvCoursewareCase_Resource_RelEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvCoursewareCase_Resource_RelEN.FuncModuleId, 4, convCoursewareCase_Resource_Rel.FuncModuleId);
clsCheckSql.CheckFieldLen(objvCoursewareCase_Resource_RelEN.FuncModuleName, 30, convCoursewareCase_Resource_Rel.FuncModuleName);
clsCheckSql.CheckFieldLen(objvCoursewareCase_Resource_RelEN.IdMicroteachCase, 8, convCoursewareCase_Resource_Rel.IdMicroteachCase);
clsCheckSql.CheckFieldLen(objvCoursewareCase_Resource_RelEN.CoursewareCaseID, 8, convCoursewareCase_Resource_Rel.CoursewareCaseID);
clsCheckSql.CheckFieldLen(objvCoursewareCase_Resource_RelEN.CoursewareCaseName, 100, convCoursewareCase_Resource_Rel.CoursewareCaseName);
clsCheckSql.CheckFieldLen(objvCoursewareCase_Resource_RelEN.CoursewareCaseTheme, 200, convCoursewareCase_Resource_Rel.CoursewareCaseTheme);
clsCheckSql.CheckFieldLen(objvCoursewareCase_Resource_RelEN.IdCoursewareCaseType, 4, convCoursewareCase_Resource_Rel.IdCoursewareCaseType);
clsCheckSql.CheckFieldLen(objvCoursewareCase_Resource_RelEN.CoursewareCaseTypeName, 50, convCoursewareCase_Resource_Rel.CoursewareCaseTypeName);
clsCheckSql.CheckFieldLen(objvCoursewareCase_Resource_RelEN.CoursewareCaseText, 8000, convCoursewareCase_Resource_Rel.CoursewareCaseText);
clsCheckSql.CheckFieldLen(objvCoursewareCase_Resource_RelEN.CoursewareCaseDate, 8, convCoursewareCase_Resource_Rel.CoursewareCaseDate);
clsCheckSql.CheckFieldLen(objvCoursewareCase_Resource_RelEN.CoursewareCaseTime, 6, convCoursewareCase_Resource_Rel.CoursewareCaseTime);
clsCheckSql.CheckFieldLen(objvCoursewareCase_Resource_RelEN.CoursewareCaseDateIn, 8, convCoursewareCase_Resource_Rel.CoursewareCaseDateIn);
clsCheckSql.CheckFieldLen(objvCoursewareCase_Resource_RelEN.CoursewareCaseTimeIn, 6, convCoursewareCase_Resource_Rel.CoursewareCaseTimeIn);
clsCheckSql.CheckFieldLen(objvCoursewareCase_Resource_RelEN.IdStudyLevel, 4, convCoursewareCase_Resource_Rel.IdStudyLevel);
clsCheckSql.CheckFieldLen(objvCoursewareCase_Resource_RelEN.StudyLevelName, 50, convCoursewareCase_Resource_Rel.StudyLevelName);
clsCheckSql.CheckFieldLen(objvCoursewareCase_Resource_RelEN.IdTeachingPlan, 8, convCoursewareCase_Resource_Rel.IdTeachingPlan);
clsCheckSql.CheckFieldLen(objvCoursewareCase_Resource_RelEN.IdCaseType, 4, convCoursewareCase_Resource_Rel.IdCaseType);
clsCheckSql.CheckFieldLen(objvCoursewareCase_Resource_RelEN.IdDiscipline, 4, convCoursewareCase_Resource_Rel.IdDiscipline);
clsCheckSql.CheckFieldLen(objvCoursewareCase_Resource_RelEN.DisciplineID, 4, convCoursewareCase_Resource_Rel.DisciplineID);
clsCheckSql.CheckFieldLen(objvCoursewareCase_Resource_RelEN.DisciplineName, 50, convCoursewareCase_Resource_Rel.DisciplineName);
clsCheckSql.CheckFieldLen(objvCoursewareCase_Resource_RelEN.senateGaugeVersionID, 4, convCoursewareCase_Resource_Rel.senateGaugeVersionID);
clsCheckSql.CheckFieldLen(objvCoursewareCase_Resource_RelEN.senateGaugeVersionName, 200, convCoursewareCase_Resource_Rel.senateGaugeVersionName);
clsCheckSql.CheckFieldLen(objvCoursewareCase_Resource_RelEN.IdTeachSkill, 8, convCoursewareCase_Resource_Rel.IdTeachSkill);
clsCheckSql.CheckFieldLen(objvCoursewareCase_Resource_RelEN.TeachSkillID, 8, convCoursewareCase_Resource_Rel.TeachSkillID);
clsCheckSql.CheckFieldLen(objvCoursewareCase_Resource_RelEN.SkillTypeName, 50, convCoursewareCase_Resource_Rel.SkillTypeName);
clsCheckSql.CheckFieldLen(objvCoursewareCase_Resource_RelEN.TeachSkillName, 50, convCoursewareCase_Resource_Rel.TeachSkillName);
clsCheckSql.CheckFieldLen(objvCoursewareCase_Resource_RelEN.TeachSkillTheory, 8000, convCoursewareCase_Resource_Rel.TeachSkillTheory);
clsCheckSql.CheckFieldLen(objvCoursewareCase_Resource_RelEN.TeachSkillOperMethod, 2000, convCoursewareCase_Resource_Rel.TeachSkillOperMethod);
clsCheckSql.CheckFieldLen(objvCoursewareCase_Resource_RelEN.IdSkillType, 4, convCoursewareCase_Resource_Rel.IdSkillType);
clsCheckSql.CheckFieldLen(objvCoursewareCase_Resource_RelEN.SkillTypeID, 4, convCoursewareCase_Resource_Rel.SkillTypeID);
clsCheckSql.CheckFieldLen(objvCoursewareCase_Resource_RelEN.CaseLevelId, 2, convCoursewareCase_Resource_Rel.CaseLevelId);
clsCheckSql.CheckFieldLen(objvCoursewareCase_Resource_RelEN.OwnerId, 20, convCoursewareCase_Resource_Rel.OwnerId);
clsCheckSql.CheckFieldLen(objvCoursewareCase_Resource_RelEN.StuName, 50, convCoursewareCase_Resource_Rel.StuName);
clsCheckSql.CheckFieldLen(objvCoursewareCase_Resource_RelEN.StuID, 20, convCoursewareCase_Resource_Rel.StuID);
clsCheckSql.CheckFieldLen(objvCoursewareCase_Resource_RelEN.PoliticsName, 30, convCoursewareCase_Resource_Rel.PoliticsName);
clsCheckSql.CheckFieldLen(objvCoursewareCase_Resource_RelEN.SexDesc, 10, convCoursewareCase_Resource_Rel.SexDesc);
clsCheckSql.CheckFieldLen(objvCoursewareCase_Resource_RelEN.EthnicName, 30, convCoursewareCase_Resource_Rel.EthnicName);
clsCheckSql.CheckFieldLen(objvCoursewareCase_Resource_RelEN.UniZoneDesc, 20, convCoursewareCase_Resource_Rel.UniZoneDesc);
clsCheckSql.CheckFieldLen(objvCoursewareCase_Resource_RelEN.StuTypeDesc, 50, convCoursewareCase_Resource_Rel.StuTypeDesc);
clsCheckSql.CheckFieldLen(objvCoursewareCase_Resource_RelEN.IdXzCollege, 4, convCoursewareCase_Resource_Rel.IdXzCollege);
clsCheckSql.CheckFieldLen(objvCoursewareCase_Resource_RelEN.CollegeName, 100, convCoursewareCase_Resource_Rel.CollegeName);
clsCheckSql.CheckFieldLen(objvCoursewareCase_Resource_RelEN.CollegeNameA, 12, convCoursewareCase_Resource_Rel.CollegeNameA);
clsCheckSql.CheckFieldLen(objvCoursewareCase_Resource_RelEN.IdXzMajor, 8, convCoursewareCase_Resource_Rel.IdXzMajor);
clsCheckSql.CheckFieldLen(objvCoursewareCase_Resource_RelEN.MajorName, 100, convCoursewareCase_Resource_Rel.MajorName);
clsCheckSql.CheckFieldLen(objvCoursewareCase_Resource_RelEN.IdGradeBase, 4, convCoursewareCase_Resource_Rel.IdGradeBase);
clsCheckSql.CheckFieldLen(objvCoursewareCase_Resource_RelEN.GradeBaseName, 50, convCoursewareCase_Resource_Rel.GradeBaseName);
clsCheckSql.CheckFieldLen(objvCoursewareCase_Resource_RelEN.IdAdminCls, 8, convCoursewareCase_Resource_Rel.IdAdminCls);
clsCheckSql.CheckFieldLen(objvCoursewareCase_Resource_RelEN.AdminClsId, 8, convCoursewareCase_Resource_Rel.AdminClsId);
clsCheckSql.CheckFieldLen(objvCoursewareCase_Resource_RelEN.AdminClsName, 100, convCoursewareCase_Resource_Rel.AdminClsName);
clsCheckSql.CheckFieldLen(objvCoursewareCase_Resource_RelEN.Birthday, 8, convCoursewareCase_Resource_Rel.Birthday);
clsCheckSql.CheckFieldLen(objvCoursewareCase_Resource_RelEN.NativePlace, 200, convCoursewareCase_Resource_Rel.NativePlace);
clsCheckSql.CheckFieldLen(objvCoursewareCase_Resource_RelEN.Duty, 30, convCoursewareCase_Resource_Rel.Duty);
clsCheckSql.CheckFieldLen(objvCoursewareCase_Resource_RelEN.IDCardNo, 20, convCoursewareCase_Resource_Rel.IDCardNo);
clsCheckSql.CheckFieldLen(objvCoursewareCase_Resource_RelEN.StuCardNo, 20, convCoursewareCase_Resource_Rel.StuCardNo);
clsCheckSql.CheckFieldLen(objvCoursewareCase_Resource_RelEN.LiveAddress, 200, convCoursewareCase_Resource_Rel.LiveAddress);
clsCheckSql.CheckFieldLen(objvCoursewareCase_Resource_RelEN.HomePhone, 20, convCoursewareCase_Resource_Rel.HomePhone);
clsCheckSql.CheckFieldLen(objvCoursewareCase_Resource_RelEN.EnrollmentDate, 8, convCoursewareCase_Resource_Rel.EnrollmentDate);
clsCheckSql.CheckFieldLen(objvCoursewareCase_Resource_RelEN.PostCode, 6, convCoursewareCase_Resource_Rel.PostCode);
clsCheckSql.CheckFieldLen(objvCoursewareCase_Resource_RelEN.UserKindId, 2, convCoursewareCase_Resource_Rel.UserKindId);
clsCheckSql.CheckFieldLen(objvCoursewareCase_Resource_RelEN.UserKindName, 30, convCoursewareCase_Resource_Rel.UserKindName);
clsCheckSql.CheckFieldLen(objvCoursewareCase_Resource_RelEN.UserTypeId, 2, convCoursewareCase_Resource_Rel.UserTypeId);
clsCheckSql.CheckFieldLen(objvCoursewareCase_Resource_RelEN.RecommendedDegreeId, 2, convCoursewareCase_Resource_Rel.RecommendedDegreeId);
clsCheckSql.CheckFieldLen(objvCoursewareCase_Resource_RelEN.RecommendedDegreeName, 30, convCoursewareCase_Resource_Rel.RecommendedDegreeName);
clsCheckSql.CheckFieldLen(objvCoursewareCase_Resource_RelEN.IdResource, 8, convCoursewareCase_Resource_Rel.IdResource);
clsCheckSql.CheckFieldLen(objvCoursewareCase_Resource_RelEN.ResourceID, 8, convCoursewareCase_Resource_Rel.ResourceID);
clsCheckSql.CheckFieldLen(objvCoursewareCase_Resource_RelEN.ResourceName, 100, convCoursewareCase_Resource_Rel.ResourceName);
clsCheckSql.CheckFieldLen(objvCoursewareCase_Resource_RelEN.IdFtpResource, 8, convCoursewareCase_Resource_Rel.IdFtpResource);
clsCheckSql.CheckFieldLen(objvCoursewareCase_Resource_RelEN.IdFile, 8, convCoursewareCase_Resource_Rel.IdFile);
clsCheckSql.CheckFieldLen(objvCoursewareCase_Resource_RelEN.FileName, 500, convCoursewareCase_Resource_Rel.FileName);
clsCheckSql.CheckFieldLen(objvCoursewareCase_Resource_RelEN.FileType, 30, convCoursewareCase_Resource_Rel.FileType);
clsCheckSql.CheckFieldLen(objvCoursewareCase_Resource_RelEN.SaveDate, 8, convCoursewareCase_Resource_Rel.SaveDate);
clsCheckSql.CheckFieldLen(objvCoursewareCase_Resource_RelEN.FileSize, 50, convCoursewareCase_Resource_Rel.FileSize);
clsCheckSql.CheckFieldLen(objvCoursewareCase_Resource_RelEN.SaveTime, 6, convCoursewareCase_Resource_Rel.SaveTime);
clsCheckSql.CheckFieldLen(objvCoursewareCase_Resource_RelEN.FtpResourceID, 8, convCoursewareCase_Resource_Rel.FtpResourceID);
clsCheckSql.CheckFieldLen(objvCoursewareCase_Resource_RelEN.FileOriginalName, 200, convCoursewareCase_Resource_Rel.FileOriginalName);
clsCheckSql.CheckFieldLen(objvCoursewareCase_Resource_RelEN.FileDirName, 200, convCoursewareCase_Resource_Rel.FileDirName);
clsCheckSql.CheckFieldLen(objvCoursewareCase_Resource_RelEN.FileRename, 200, convCoursewareCase_Resource_Rel.FileRename);
clsCheckSql.CheckFieldLen(objvCoursewareCase_Resource_RelEN.FileUpDate, 8, convCoursewareCase_Resource_Rel.FileUpDate);
clsCheckSql.CheckFieldLen(objvCoursewareCase_Resource_RelEN.FileUpTime, 6, convCoursewareCase_Resource_Rel.FileUpTime);
clsCheckSql.CheckFieldLen(objvCoursewareCase_Resource_RelEN.IdResourceType, 4, convCoursewareCase_Resource_Rel.IdResourceType);
clsCheckSql.CheckFieldLen(objvCoursewareCase_Resource_RelEN.ResourceTypeID, 4, convCoursewareCase_Resource_Rel.ResourceTypeID);
clsCheckSql.CheckFieldLen(objvCoursewareCase_Resource_RelEN.ResourceTypeName, 50, convCoursewareCase_Resource_Rel.ResourceTypeName);
clsCheckSql.CheckFieldLen(objvCoursewareCase_Resource_RelEN.ResourceOwner, 50, convCoursewareCase_Resource_Rel.ResourceOwner);
clsCheckSql.CheckFieldLen(objvCoursewareCase_Resource_RelEN.ftpFileType, 30, convCoursewareCase_Resource_Rel.ftpFileType);
clsCheckSql.CheckFieldLen(objvCoursewareCase_Resource_RelEN.ftpFileSize, 50, convCoursewareCase_Resource_Rel.ftpFileSize);
clsCheckSql.CheckFieldLen(objvCoursewareCase_Resource_RelEN.ftpResourceOwner, 50, convCoursewareCase_Resource_Rel.ftpResourceOwner);
clsCheckSql.CheckFieldLen(objvCoursewareCase_Resource_RelEN.FileOriginName, 500, convCoursewareCase_Resource_Rel.FileOriginName);
clsCheckSql.CheckFieldLen(objvCoursewareCase_Resource_RelEN.FileNewName, 530, convCoursewareCase_Resource_Rel.FileNewName);
clsCheckSql.CheckFieldLen(objvCoursewareCase_Resource_RelEN.FileOldName, 530, convCoursewareCase_Resource_Rel.FileOldName);
clsCheckSql.CheckFieldLen(objvCoursewareCase_Resource_RelEN.IdUsingMode, 4, convCoursewareCase_Resource_Rel.IdUsingMode);
clsCheckSql.CheckFieldLen(objvCoursewareCase_Resource_RelEN.UpdDate, 20, convCoursewareCase_Resource_Rel.UpdDate);
clsCheckSql.CheckFieldLen(objvCoursewareCase_Resource_RelEN.UpdUser, 20, convCoursewareCase_Resource_Rel.UpdUser);
clsCheckSql.CheckFieldLen(objvCoursewareCase_Resource_RelEN.Memo, 1000, convCoursewareCase_Resource_Rel.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCase_Resource_RelEN.FuncModuleId, convCoursewareCase_Resource_Rel.FuncModuleId);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCase_Resource_RelEN.FuncModuleName, convCoursewareCase_Resource_Rel.FuncModuleName);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCase_Resource_RelEN.IdMicroteachCase, convCoursewareCase_Resource_Rel.IdMicroteachCase);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCase_Resource_RelEN.CoursewareCaseID, convCoursewareCase_Resource_Rel.CoursewareCaseID);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCase_Resource_RelEN.CoursewareCaseName, convCoursewareCase_Resource_Rel.CoursewareCaseName);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCase_Resource_RelEN.CoursewareCaseTheme, convCoursewareCase_Resource_Rel.CoursewareCaseTheme);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCase_Resource_RelEN.IdCoursewareCaseType, convCoursewareCase_Resource_Rel.IdCoursewareCaseType);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCase_Resource_RelEN.CoursewareCaseTypeName, convCoursewareCase_Resource_Rel.CoursewareCaseTypeName);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCase_Resource_RelEN.CoursewareCaseText, convCoursewareCase_Resource_Rel.CoursewareCaseText);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCase_Resource_RelEN.CoursewareCaseDate, convCoursewareCase_Resource_Rel.CoursewareCaseDate);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCase_Resource_RelEN.CoursewareCaseTime, convCoursewareCase_Resource_Rel.CoursewareCaseTime);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCase_Resource_RelEN.CoursewareCaseDateIn, convCoursewareCase_Resource_Rel.CoursewareCaseDateIn);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCase_Resource_RelEN.CoursewareCaseTimeIn, convCoursewareCase_Resource_Rel.CoursewareCaseTimeIn);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCase_Resource_RelEN.IdStudyLevel, convCoursewareCase_Resource_Rel.IdStudyLevel);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCase_Resource_RelEN.StudyLevelName, convCoursewareCase_Resource_Rel.StudyLevelName);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCase_Resource_RelEN.IdTeachingPlan, convCoursewareCase_Resource_Rel.IdTeachingPlan);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCase_Resource_RelEN.IdCaseType, convCoursewareCase_Resource_Rel.IdCaseType);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCase_Resource_RelEN.IdDiscipline, convCoursewareCase_Resource_Rel.IdDiscipline);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCase_Resource_RelEN.DisciplineID, convCoursewareCase_Resource_Rel.DisciplineID);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCase_Resource_RelEN.DisciplineName, convCoursewareCase_Resource_Rel.DisciplineName);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCase_Resource_RelEN.senateGaugeVersionID, convCoursewareCase_Resource_Rel.senateGaugeVersionID);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCase_Resource_RelEN.senateGaugeVersionName, convCoursewareCase_Resource_Rel.senateGaugeVersionName);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCase_Resource_RelEN.IdTeachSkill, convCoursewareCase_Resource_Rel.IdTeachSkill);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCase_Resource_RelEN.TeachSkillID, convCoursewareCase_Resource_Rel.TeachSkillID);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCase_Resource_RelEN.SkillTypeName, convCoursewareCase_Resource_Rel.SkillTypeName);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCase_Resource_RelEN.TeachSkillName, convCoursewareCase_Resource_Rel.TeachSkillName);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCase_Resource_RelEN.TeachSkillTheory, convCoursewareCase_Resource_Rel.TeachSkillTheory);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCase_Resource_RelEN.TeachSkillOperMethod, convCoursewareCase_Resource_Rel.TeachSkillOperMethod);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCase_Resource_RelEN.IdSkillType, convCoursewareCase_Resource_Rel.IdSkillType);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCase_Resource_RelEN.SkillTypeID, convCoursewareCase_Resource_Rel.SkillTypeID);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCase_Resource_RelEN.CaseLevelId, convCoursewareCase_Resource_Rel.CaseLevelId);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCase_Resource_RelEN.OwnerId, convCoursewareCase_Resource_Rel.OwnerId);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCase_Resource_RelEN.StuName, convCoursewareCase_Resource_Rel.StuName);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCase_Resource_RelEN.StuID, convCoursewareCase_Resource_Rel.StuID);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCase_Resource_RelEN.PoliticsName, convCoursewareCase_Resource_Rel.PoliticsName);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCase_Resource_RelEN.SexDesc, convCoursewareCase_Resource_Rel.SexDesc);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCase_Resource_RelEN.EthnicName, convCoursewareCase_Resource_Rel.EthnicName);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCase_Resource_RelEN.UniZoneDesc, convCoursewareCase_Resource_Rel.UniZoneDesc);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCase_Resource_RelEN.StuTypeDesc, convCoursewareCase_Resource_Rel.StuTypeDesc);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCase_Resource_RelEN.IdXzCollege, convCoursewareCase_Resource_Rel.IdXzCollege);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCase_Resource_RelEN.CollegeName, convCoursewareCase_Resource_Rel.CollegeName);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCase_Resource_RelEN.CollegeNameA, convCoursewareCase_Resource_Rel.CollegeNameA);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCase_Resource_RelEN.IdXzMajor, convCoursewareCase_Resource_Rel.IdXzMajor);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCase_Resource_RelEN.MajorName, convCoursewareCase_Resource_Rel.MajorName);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCase_Resource_RelEN.IdGradeBase, convCoursewareCase_Resource_Rel.IdGradeBase);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCase_Resource_RelEN.GradeBaseName, convCoursewareCase_Resource_Rel.GradeBaseName);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCase_Resource_RelEN.IdAdminCls, convCoursewareCase_Resource_Rel.IdAdminCls);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCase_Resource_RelEN.AdminClsId, convCoursewareCase_Resource_Rel.AdminClsId);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCase_Resource_RelEN.AdminClsName, convCoursewareCase_Resource_Rel.AdminClsName);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCase_Resource_RelEN.Birthday, convCoursewareCase_Resource_Rel.Birthday);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCase_Resource_RelEN.NativePlace, convCoursewareCase_Resource_Rel.NativePlace);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCase_Resource_RelEN.Duty, convCoursewareCase_Resource_Rel.Duty);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCase_Resource_RelEN.IDCardNo, convCoursewareCase_Resource_Rel.IDCardNo);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCase_Resource_RelEN.StuCardNo, convCoursewareCase_Resource_Rel.StuCardNo);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCase_Resource_RelEN.LiveAddress, convCoursewareCase_Resource_Rel.LiveAddress);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCase_Resource_RelEN.HomePhone, convCoursewareCase_Resource_Rel.HomePhone);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCase_Resource_RelEN.EnrollmentDate, convCoursewareCase_Resource_Rel.EnrollmentDate);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCase_Resource_RelEN.PostCode, convCoursewareCase_Resource_Rel.PostCode);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCase_Resource_RelEN.UserKindId, convCoursewareCase_Resource_Rel.UserKindId);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCase_Resource_RelEN.UserKindName, convCoursewareCase_Resource_Rel.UserKindName);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCase_Resource_RelEN.UserTypeId, convCoursewareCase_Resource_Rel.UserTypeId);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCase_Resource_RelEN.RecommendedDegreeId, convCoursewareCase_Resource_Rel.RecommendedDegreeId);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCase_Resource_RelEN.RecommendedDegreeName, convCoursewareCase_Resource_Rel.RecommendedDegreeName);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCase_Resource_RelEN.IdResource, convCoursewareCase_Resource_Rel.IdResource);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCase_Resource_RelEN.ResourceID, convCoursewareCase_Resource_Rel.ResourceID);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCase_Resource_RelEN.ResourceName, convCoursewareCase_Resource_Rel.ResourceName);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCase_Resource_RelEN.IdFtpResource, convCoursewareCase_Resource_Rel.IdFtpResource);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCase_Resource_RelEN.IdFile, convCoursewareCase_Resource_Rel.IdFile);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCase_Resource_RelEN.FileName, convCoursewareCase_Resource_Rel.FileName);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCase_Resource_RelEN.FileType, convCoursewareCase_Resource_Rel.FileType);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCase_Resource_RelEN.SaveDate, convCoursewareCase_Resource_Rel.SaveDate);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCase_Resource_RelEN.FileSize, convCoursewareCase_Resource_Rel.FileSize);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCase_Resource_RelEN.SaveTime, convCoursewareCase_Resource_Rel.SaveTime);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCase_Resource_RelEN.FtpResourceID, convCoursewareCase_Resource_Rel.FtpResourceID);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCase_Resource_RelEN.FileOriginalName, convCoursewareCase_Resource_Rel.FileOriginalName);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCase_Resource_RelEN.FileDirName, convCoursewareCase_Resource_Rel.FileDirName);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCase_Resource_RelEN.FileRename, convCoursewareCase_Resource_Rel.FileRename);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCase_Resource_RelEN.FileUpDate, convCoursewareCase_Resource_Rel.FileUpDate);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCase_Resource_RelEN.FileUpTime, convCoursewareCase_Resource_Rel.FileUpTime);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCase_Resource_RelEN.IdResourceType, convCoursewareCase_Resource_Rel.IdResourceType);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCase_Resource_RelEN.ResourceTypeID, convCoursewareCase_Resource_Rel.ResourceTypeID);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCase_Resource_RelEN.ResourceTypeName, convCoursewareCase_Resource_Rel.ResourceTypeName);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCase_Resource_RelEN.ResourceOwner, convCoursewareCase_Resource_Rel.ResourceOwner);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCase_Resource_RelEN.ftpFileType, convCoursewareCase_Resource_Rel.ftpFileType);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCase_Resource_RelEN.ftpFileSize, convCoursewareCase_Resource_Rel.ftpFileSize);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCase_Resource_RelEN.ftpResourceOwner, convCoursewareCase_Resource_Rel.ftpResourceOwner);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCase_Resource_RelEN.FileOriginName, convCoursewareCase_Resource_Rel.FileOriginName);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCase_Resource_RelEN.FileNewName, convCoursewareCase_Resource_Rel.FileNewName);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCase_Resource_RelEN.FileOldName, convCoursewareCase_Resource_Rel.FileOldName);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCase_Resource_RelEN.IdUsingMode, convCoursewareCase_Resource_Rel.IdUsingMode);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCase_Resource_RelEN.UpdDate, convCoursewareCase_Resource_Rel.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCase_Resource_RelEN.UpdUser, convCoursewareCase_Resource_Rel.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareCase_Resource_RelEN.Memo, convCoursewareCase_Resource_Rel.Memo);
//检查外键字段长度
 objvCoursewareCase_Resource_RelEN._IsCheckProperty = true;
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
 objSQL = clsvCoursewareCase_Resource_RelDA.GetSpecSQLObj();
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
 objSQL = clsvCoursewareCase_Resource_RelDA.GetSpecSQLObj();
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
 objSQL = clsvCoursewareCase_Resource_RelDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvCoursewareCase_Resource_RelEN._CurrTabName);
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
 objSQL = clsvCoursewareCase_Resource_RelDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvCoursewareCase_Resource_RelEN._CurrTabName, strCondition);
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
 objSQL = clsvCoursewareCase_Resource_RelDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}