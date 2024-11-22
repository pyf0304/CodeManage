
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvCoursewareResCase_Resource_RelDA
 表名:vCoursewareResCase_Resource_Rel(01120432)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:46:17
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:课件资源库(CoursewareResLib)
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
 /// v课件资源案例资源关系(vCoursewareResCase_Resource_Rel)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvCoursewareResCase_Resource_RelDA : clsCommBase4DA
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
 return clsvCoursewareResCase_Resource_RelEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvCoursewareResCase_Resource_RelEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvCoursewareResCase_Resource_RelEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvCoursewareResCase_Resource_RelEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvCoursewareResCase_Resource_RelEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvCoursewareResCase_Resource_RelDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCoursewareResCase_Resource_RelDA.GetSpecSQLObj();
strSQL = "Select * from vCoursewareResCase_Resource_Rel where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vCoursewareResCase_Resource_Rel(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvCoursewareResCase_Resource_RelDA: GetDataTable_vCoursewareResCase_Resource_Rel)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCoursewareResCase_Resource_RelDA.GetSpecSQLObj();
strSQL = "Select * from vCoursewareResCase_Resource_Rel where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvCoursewareResCase_Resource_RelDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCoursewareResCase_Resource_RelDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvCoursewareResCase_Resource_RelDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCoursewareResCase_Resource_RelDA.GetSpecSQLObj();
strSQL = "Select * from vCoursewareResCase_Resource_Rel where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvCoursewareResCase_Resource_RelDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCoursewareResCase_Resource_RelDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvCoursewareResCase_Resource_RelDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCoursewareResCase_Resource_RelDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vCoursewareResCase_Resource_Rel where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vCoursewareResCase_Resource_Rel where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvCoursewareResCase_Resource_RelDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCoursewareResCase_Resource_RelDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vCoursewareResCase_Resource_Rel where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvCoursewareResCase_Resource_RelDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCoursewareResCase_Resource_RelDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vCoursewareResCase_Resource_Rel.* from vCoursewareResCase_Resource_Rel Left Join {1} on {2} where {3} and vCoursewareResCase_Resource_Rel.IdMicroteachCaseResourceRel not in (Select top {5} vCoursewareResCase_Resource_Rel.IdMicroteachCaseResourceRel from vCoursewareResCase_Resource_Rel Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vCoursewareResCase_Resource_Rel where {1} and IdMicroteachCaseResourceRel not in (Select top {2} IdMicroteachCaseResourceRel from vCoursewareResCase_Resource_Rel where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vCoursewareResCase_Resource_Rel where {1} and IdMicroteachCaseResourceRel not in (Select top {3} IdMicroteachCaseResourceRel from vCoursewareResCase_Resource_Rel where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvCoursewareResCase_Resource_RelDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCoursewareResCase_Resource_RelDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vCoursewareResCase_Resource_Rel.* from vCoursewareResCase_Resource_Rel Left Join {1} on {2} where {3} and vCoursewareResCase_Resource_Rel.IdMicroteachCaseResourceRel not in (Select top {5} vCoursewareResCase_Resource_Rel.IdMicroteachCaseResourceRel from vCoursewareResCase_Resource_Rel Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vCoursewareResCase_Resource_Rel where {1} and IdMicroteachCaseResourceRel not in (Select top {2} IdMicroteachCaseResourceRel from vCoursewareResCase_Resource_Rel where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vCoursewareResCase_Resource_Rel where {1} and IdMicroteachCaseResourceRel not in (Select top {3} IdMicroteachCaseResourceRel from vCoursewareResCase_Resource_Rel where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvCoursewareResCase_Resource_RelEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvCoursewareResCase_Resource_RelDA:GetObjLst)", objException.Message));
}
List<clsvCoursewareResCase_Resource_RelEN> arrObjLst = new List<clsvCoursewareResCase_Resource_RelEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCoursewareResCase_Resource_RelDA.GetSpecSQLObj();
strSQL = "Select * from vCoursewareResCase_Resource_Rel where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCoursewareResCase_Resource_RelEN objvCoursewareResCase_Resource_RelEN = new clsvCoursewareResCase_Resource_RelEN();
try
{
objvCoursewareResCase_Resource_RelEN.IdMicroteachCaseResourceRel = TransNullToInt(objRow[convCoursewareResCase_Resource_Rel.IdMicroteachCaseResourceRel].ToString().Trim()); //微格案例资源关系流水号
objvCoursewareResCase_Resource_RelEN.FuncModuleId = objRow[convCoursewareResCase_Resource_Rel.FuncModuleId].ToString().Trim(); //功能模块Id
objvCoursewareResCase_Resource_RelEN.FuncModuleName = objRow[convCoursewareResCase_Resource_Rel.FuncModuleName] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.FuncModuleName].ToString().Trim(); //功能模块名称
objvCoursewareResCase_Resource_RelEN.IdMicroteachCase = objRow[convCoursewareResCase_Resource_Rel.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvCoursewareResCase_Resource_RelEN.CoursewareResCaseID = objRow[convCoursewareResCase_Resource_Rel.CoursewareResCaseID] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.CoursewareResCaseID].ToString().Trim(); //课件资源案例ID
objvCoursewareResCase_Resource_RelEN.CoursewareResCaseName = objRow[convCoursewareResCase_Resource_Rel.CoursewareResCaseName] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.CoursewareResCaseName].ToString().Trim(); //课件资源案例名称
objvCoursewareResCase_Resource_RelEN.CoursewareResCaseTheme = objRow[convCoursewareResCase_Resource_Rel.CoursewareResCaseTheme] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.CoursewareResCaseTheme].ToString().Trim(); //课件资源案例主题词
objvCoursewareResCase_Resource_RelEN.CoursewareResCaseText = objRow[convCoursewareResCase_Resource_Rel.CoursewareResCaseText] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.CoursewareResCaseText].ToString().Trim(); //案例文本内容
objvCoursewareResCase_Resource_RelEN.IdCoursewareResCaseType = objRow[convCoursewareResCase_Resource_Rel.IdCoursewareResCaseType] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.IdCoursewareResCaseType].ToString().Trim(); //课件资源类型流水号
objvCoursewareResCase_Resource_RelEN.CoursewareResCaseTypeName = objRow[convCoursewareResCase_Resource_Rel.CoursewareResCaseTypeName] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.CoursewareResCaseTypeName].ToString().Trim(); //课件资源案例类型名称
objvCoursewareResCase_Resource_RelEN.CoursewareResCaseDate = objRow[convCoursewareResCase_Resource_Rel.CoursewareResCaseDate] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.CoursewareResCaseDate].ToString().Trim(); //视频资源日期
objvCoursewareResCase_Resource_RelEN.CoursewareResCaseTime = objRow[convCoursewareResCase_Resource_Rel.CoursewareResCaseTime] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.CoursewareResCaseTime].ToString().Trim(); //视频资源时间
objvCoursewareResCase_Resource_RelEN.CoursewareResCaseDateIn = objRow[convCoursewareResCase_Resource_Rel.CoursewareResCaseDateIn] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.CoursewareResCaseDateIn].ToString().Trim(); //案例入库日期
objvCoursewareResCase_Resource_RelEN.CoursewareResCaseTimeIn = objRow[convCoursewareResCase_Resource_Rel.CoursewareResCaseTimeIn] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.CoursewareResCaseTimeIn].ToString().Trim(); //案例入库时间
objvCoursewareResCase_Resource_RelEN.OwnerId = objRow[convCoursewareResCase_Resource_Rel.OwnerId] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.OwnerId].ToString().Trim(); //拥有者Id
objvCoursewareResCase_Resource_RelEN.OwnerName = objRow[convCoursewareResCase_Resource_Rel.OwnerName] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.OwnerName].ToString().Trim(); //拥有者姓名
objvCoursewareResCase_Resource_RelEN.OwnerNameWithId = objRow[convCoursewareResCase_Resource_Rel.OwnerNameWithId] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvCoursewareResCase_Resource_RelEN.IdStudyLevel = objRow[convCoursewareResCase_Resource_Rel.IdStudyLevel] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvCoursewareResCase_Resource_RelEN.StudyLevelName = objRow[convCoursewareResCase_Resource_Rel.StudyLevelName] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.StudyLevelName].ToString().Trim(); //学段名称
objvCoursewareResCase_Resource_RelEN.IdTeachingPlan = objRow[convCoursewareResCase_Resource_Rel.IdTeachingPlan] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.IdTeachingPlan].ToString().Trim(); //教案流水号
objvCoursewareResCase_Resource_RelEN.IdDiscipline = objRow[convCoursewareResCase_Resource_Rel.IdDiscipline] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.IdDiscipline].ToString().Trim(); //学科流水号
objvCoursewareResCase_Resource_RelEN.DisciplineID = objRow[convCoursewareResCase_Resource_Rel.DisciplineID] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.DisciplineID].ToString().Trim(); //学科ID
objvCoursewareResCase_Resource_RelEN.DisciplineName = objRow[convCoursewareResCase_Resource_Rel.DisciplineName] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.DisciplineName].ToString().Trim(); //学科名称
objvCoursewareResCase_Resource_RelEN.senateGaugeVersionID = objRow[convCoursewareResCase_Resource_Rel.senateGaugeVersionID] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvCoursewareResCase_Resource_RelEN.senateGaugeVersionName = objRow[convCoursewareResCase_Resource_Rel.senateGaugeVersionName] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvCoursewareResCase_Resource_RelEN.senateGaugeVersionTtlScore = objRow[convCoursewareResCase_Resource_Rel.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convCoursewareResCase_Resource_Rel.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvCoursewareResCase_Resource_RelEN.VersionNo = objRow[convCoursewareResCase_Resource_Rel.VersionNo] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCoursewareResCase_Resource_Rel.VersionNo].ToString().Trim()); //版本号
objvCoursewareResCase_Resource_RelEN.IdTeachSkill = objRow[convCoursewareResCase_Resource_Rel.IdTeachSkill] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvCoursewareResCase_Resource_RelEN.TeachSkillID = objRow[convCoursewareResCase_Resource_Rel.TeachSkillID] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.TeachSkillID].ToString().Trim(); //教学技能ID
objvCoursewareResCase_Resource_RelEN.SkillTypeName = objRow[convCoursewareResCase_Resource_Rel.SkillTypeName] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.SkillTypeName].ToString().Trim(); //技能类型名称
objvCoursewareResCase_Resource_RelEN.TeachSkillName = objRow[convCoursewareResCase_Resource_Rel.TeachSkillName] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.TeachSkillName].ToString().Trim(); //教学技能名称
objvCoursewareResCase_Resource_RelEN.TeachSkillTheory = objRow[convCoursewareResCase_Resource_Rel.TeachSkillTheory] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvCoursewareResCase_Resource_RelEN.TeachSkillOperMethod = objRow[convCoursewareResCase_Resource_Rel.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvCoursewareResCase_Resource_RelEN.IdSkillType = objRow[convCoursewareResCase_Resource_Rel.IdSkillType] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.IdSkillType].ToString().Trim(); //技能类型流水号
objvCoursewareResCase_Resource_RelEN.SkillTypeID = objRow[convCoursewareResCase_Resource_Rel.SkillTypeID] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.SkillTypeID].ToString().Trim(); //技能类型ID
objvCoursewareResCase_Resource_RelEN.CaseLevelId = objRow[convCoursewareResCase_Resource_Rel.CaseLevelId] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.CaseLevelId].ToString().Trim(); //课例等级Id
objvCoursewareResCase_Resource_RelEN.IsDualVideo = TransNullToBool(objRow[convCoursewareResCase_Resource_Rel.IsDualVideo].ToString().Trim()); //是否双视频
objvCoursewareResCase_Resource_RelEN.IdXzCollege = objRow[convCoursewareResCase_Resource_Rel.IdXzCollege] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.IdXzCollege].ToString().Trim(); //学院流水号
objvCoursewareResCase_Resource_RelEN.CollegeID = objRow[convCoursewareResCase_Resource_Rel.CollegeID] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.CollegeID].ToString().Trim(); //学院ID
objvCoursewareResCase_Resource_RelEN.CollegeName = objRow[convCoursewareResCase_Resource_Rel.CollegeName] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.CollegeName].ToString().Trim(); //学院名称
objvCoursewareResCase_Resource_RelEN.IdXzMajor = objRow[convCoursewareResCase_Resource_Rel.IdXzMajor] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.IdXzMajor].ToString().Trim(); //专业流水号
objvCoursewareResCase_Resource_RelEN.MajorID = objRow[convCoursewareResCase_Resource_Rel.MajorID] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.MajorID].ToString().Trim(); //专业ID
objvCoursewareResCase_Resource_RelEN.MajorName = objRow[convCoursewareResCase_Resource_Rel.MajorName] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.MajorName].ToString().Trim(); //专业名称
objvCoursewareResCase_Resource_RelEN.CourseId = objRow[convCoursewareResCase_Resource_Rel.CourseId] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.CourseId].ToString().Trim(); //课程Id
objvCoursewareResCase_Resource_RelEN.CourseCode = objRow[convCoursewareResCase_Resource_Rel.CourseCode] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.CourseCode].ToString().Trim(); //课程代码
objvCoursewareResCase_Resource_RelEN.CourseName = objRow[convCoursewareResCase_Resource_Rel.CourseName] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.CourseName].ToString().Trim(); //课程名称
objvCoursewareResCase_Resource_RelEN.CourseChapterId = objRow[convCoursewareResCase_Resource_Rel.CourseChapterId] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.CourseChapterId].ToString().Trim(); //课程章节ID
objvCoursewareResCase_Resource_RelEN.CourseChapterName = objRow[convCoursewareResCase_Resource_Rel.CourseChapterName] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.CourseChapterName].ToString().Trim(); //课程章节名称
objvCoursewareResCase_Resource_RelEN.ParentNodeID = objRow[convCoursewareResCase_Resource_Rel.ParentNodeID] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.ParentNodeID].ToString().Trim(); //父节点编号
objvCoursewareResCase_Resource_RelEN.ParentNodeName = objRow[convCoursewareResCase_Resource_Rel.ParentNodeName] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.ParentNodeName].ToString().Trim(); //父节点名称
objvCoursewareResCase_Resource_RelEN.ViewCount = objRow[convCoursewareResCase_Resource_Rel.ViewCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCoursewareResCase_Resource_Rel.ViewCount].ToString().Trim()); //浏览量
objvCoursewareResCase_Resource_RelEN.IsShow = TransNullToBool(objRow[convCoursewareResCase_Resource_Rel.IsShow].ToString().Trim()); //是否启用
objvCoursewareResCase_Resource_RelEN.DownloadNumber = objRow[convCoursewareResCase_Resource_Rel.DownloadNumber] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCoursewareResCase_Resource_Rel.DownloadNumber].ToString().Trim()); //下载数目
objvCoursewareResCase_Resource_RelEN.FileIntegration = objRow[convCoursewareResCase_Resource_Rel.FileIntegration] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCoursewareResCase_Resource_Rel.FileIntegration].ToString().Trim()); //文件积分
objvCoursewareResCase_Resource_RelEN.LikeCount = objRow[convCoursewareResCase_Resource_Rel.LikeCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convCoursewareResCase_Resource_Rel.LikeCount].ToString().Trim()); //资源喜欢数量
objvCoursewareResCase_Resource_RelEN.CollectionCount = objRow[convCoursewareResCase_Resource_Rel.CollectionCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convCoursewareResCase_Resource_Rel.CollectionCount].ToString().Trim()); //收藏数量
objvCoursewareResCase_Resource_RelEN.RecommendedDegreeId = objRow[convCoursewareResCase_Resource_Rel.RecommendedDegreeId] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvCoursewareResCase_Resource_RelEN.RecommendedDegreeName = objRow[convCoursewareResCase_Resource_Rel.RecommendedDegreeName] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvCoursewareResCase_Resource_RelEN.BrowseCount4Case = objRow[convCoursewareResCase_Resource_Rel.BrowseCount4Case] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCoursewareResCase_Resource_Rel.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvCoursewareResCase_Resource_RelEN.CollegeNameA = objRow[convCoursewareResCase_Resource_Rel.CollegeNameA] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.CollegeNameA].ToString().Trim(); //学院名称简写
objvCoursewareResCase_Resource_RelEN.IdResource = objRow[convCoursewareResCase_Resource_Rel.IdResource].ToString().Trim(); //资源流水号
objvCoursewareResCase_Resource_RelEN.ResourceID = objRow[convCoursewareResCase_Resource_Rel.ResourceID] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.ResourceID].ToString().Trim(); //资源ID
objvCoursewareResCase_Resource_RelEN.ResourceName = objRow[convCoursewareResCase_Resource_Rel.ResourceName] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.ResourceName].ToString().Trim(); //资源名称
objvCoursewareResCase_Resource_RelEN.IdFtpResource = objRow[convCoursewareResCase_Resource_Rel.IdFtpResource] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvCoursewareResCase_Resource_RelEN.IdFile = objRow[convCoursewareResCase_Resource_Rel.IdFile] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.IdFile].ToString().Trim(); //文件流水号
objvCoursewareResCase_Resource_RelEN.FileName = objRow[convCoursewareResCase_Resource_Rel.FileName] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.FileName].ToString().Trim(); //文件名称
objvCoursewareResCase_Resource_RelEN.FileType = objRow[convCoursewareResCase_Resource_Rel.FileType] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.FileType].ToString().Trim(); //文件类型
objvCoursewareResCase_Resource_RelEN.SaveDate = objRow[convCoursewareResCase_Resource_Rel.SaveDate] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.SaveDate].ToString().Trim(); //创建日期
objvCoursewareResCase_Resource_RelEN.FileSize = objRow[convCoursewareResCase_Resource_Rel.FileSize] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.FileSize].ToString().Trim(); //文件大小
objvCoursewareResCase_Resource_RelEN.SaveTime = objRow[convCoursewareResCase_Resource_Rel.SaveTime] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.SaveTime].ToString().Trim(); //创建时间
objvCoursewareResCase_Resource_RelEN.FtpResourceID = objRow[convCoursewareResCase_Resource_Rel.FtpResourceID] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.FtpResourceID].ToString().Trim(); //FTP资源ID
objvCoursewareResCase_Resource_RelEN.FileOriginalName = objRow[convCoursewareResCase_Resource_Rel.FileOriginalName] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.FileOriginalName].ToString().Trim(); //文件原名
objvCoursewareResCase_Resource_RelEN.FileDirName = objRow[convCoursewareResCase_Resource_Rel.FileDirName] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.FileDirName].ToString().Trim(); //文件目录名
objvCoursewareResCase_Resource_RelEN.FileRename = objRow[convCoursewareResCase_Resource_Rel.FileRename] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.FileRename].ToString().Trim(); //文件新名
objvCoursewareResCase_Resource_RelEN.FileUpDate = objRow[convCoursewareResCase_Resource_Rel.FileUpDate] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.FileUpDate].ToString().Trim(); //创建日期
objvCoursewareResCase_Resource_RelEN.FileUpTime = objRow[convCoursewareResCase_Resource_Rel.FileUpTime] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.FileUpTime].ToString().Trim(); //创建时间
objvCoursewareResCase_Resource_RelEN.SaveMode = TransNullToBool(objRow[convCoursewareResCase_Resource_Rel.SaveMode].ToString().Trim()); //文件存放方式
objvCoursewareResCase_Resource_RelEN.IdResourceType = objRow[convCoursewareResCase_Resource_Rel.IdResourceType] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.IdResourceType].ToString().Trim(); //资源类型流水号
objvCoursewareResCase_Resource_RelEN.ResourceTypeID = objRow[convCoursewareResCase_Resource_Rel.ResourceTypeID] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.ResourceTypeID].ToString().Trim(); //资源类型ID
objvCoursewareResCase_Resource_RelEN.ResourceTypeName = objRow[convCoursewareResCase_Resource_Rel.ResourceTypeName] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.ResourceTypeName].ToString().Trim(); //资源类型名称
objvCoursewareResCase_Resource_RelEN.ResourceOwner = objRow[convCoursewareResCase_Resource_Rel.ResourceOwner] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.ResourceOwner].ToString().Trim(); //上传者
objvCoursewareResCase_Resource_RelEN.ftpFileType = objRow[convCoursewareResCase_Resource_Rel.ftpFileType] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.ftpFileType].ToString().Trim(); //ftp文件类型
objvCoursewareResCase_Resource_RelEN.ftpFileSize = objRow[convCoursewareResCase_Resource_Rel.ftpFileSize] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.ftpFileSize].ToString().Trim(); //ftp文件大小
objvCoursewareResCase_Resource_RelEN.ftpResourceOwner = objRow[convCoursewareResCase_Resource_Rel.ftpResourceOwner] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvCoursewareResCase_Resource_RelEN.FileOriginName = objRow[convCoursewareResCase_Resource_Rel.FileOriginName] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.FileOriginName].ToString().Trim(); //原文件名
objvCoursewareResCase_Resource_RelEN.IsExistFile = TransNullToBool(objRow[convCoursewareResCase_Resource_Rel.IsExistFile].ToString().Trim()); //是否存在文件
objvCoursewareResCase_Resource_RelEN.FileNewName = objRow[convCoursewareResCase_Resource_Rel.FileNewName] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.FileNewName].ToString().Trim(); //新文件名
objvCoursewareResCase_Resource_RelEN.FileOldName = objRow[convCoursewareResCase_Resource_Rel.FileOldName] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.FileOldName].ToString().Trim(); //旧文件名
objvCoursewareResCase_Resource_RelEN.IsMain = TransNullToBool(objRow[convCoursewareResCase_Resource_Rel.IsMain].ToString().Trim()); //是否主资源
objvCoursewareResCase_Resource_RelEN.IdUsingMode = objRow[convCoursewareResCase_Resource_Rel.IdUsingMode] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.IdUsingMode].ToString().Trim(); //资源使用模式流水号
objvCoursewareResCase_Resource_RelEN.IsVisible = TransNullToBool(objRow[convCoursewareResCase_Resource_Rel.IsVisible].ToString().Trim()); //是否显示
objvCoursewareResCase_Resource_RelEN.IndexNO = objRow[convCoursewareResCase_Resource_Rel.IndexNO] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCoursewareResCase_Resource_Rel.IndexNO].ToString().Trim()); //序号
objvCoursewareResCase_Resource_RelEN.BrowseCount = objRow[convCoursewareResCase_Resource_Rel.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCoursewareResCase_Resource_Rel.BrowseCount].ToString().Trim()); //浏览次数
objvCoursewareResCase_Resource_RelEN.UpdDate = objRow[convCoursewareResCase_Resource_Rel.UpdDate] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.UpdDate].ToString().Trim(); //修改日期
objvCoursewareResCase_Resource_RelEN.UpdUser = objRow[convCoursewareResCase_Resource_Rel.UpdUser] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.UpdUser].ToString().Trim(); //修改人
objvCoursewareResCase_Resource_RelEN.Memo = objRow[convCoursewareResCase_Resource_Rel.Memo] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvCoursewareResCase_Resource_RelDA: GetObjLst)", objException.Message));
}
objvCoursewareResCase_Resource_RelEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvCoursewareResCase_Resource_RelEN);
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
public List<clsvCoursewareResCase_Resource_RelEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvCoursewareResCase_Resource_RelDA:GetObjLstByTabName)", objException.Message));
}
List<clsvCoursewareResCase_Resource_RelEN> arrObjLst = new List<clsvCoursewareResCase_Resource_RelEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCoursewareResCase_Resource_RelDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCoursewareResCase_Resource_RelEN objvCoursewareResCase_Resource_RelEN = new clsvCoursewareResCase_Resource_RelEN();
try
{
objvCoursewareResCase_Resource_RelEN.IdMicroteachCaseResourceRel = TransNullToInt(objRow[convCoursewareResCase_Resource_Rel.IdMicroteachCaseResourceRel].ToString().Trim()); //微格案例资源关系流水号
objvCoursewareResCase_Resource_RelEN.FuncModuleId = objRow[convCoursewareResCase_Resource_Rel.FuncModuleId].ToString().Trim(); //功能模块Id
objvCoursewareResCase_Resource_RelEN.FuncModuleName = objRow[convCoursewareResCase_Resource_Rel.FuncModuleName] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.FuncModuleName].ToString().Trim(); //功能模块名称
objvCoursewareResCase_Resource_RelEN.IdMicroteachCase = objRow[convCoursewareResCase_Resource_Rel.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvCoursewareResCase_Resource_RelEN.CoursewareResCaseID = objRow[convCoursewareResCase_Resource_Rel.CoursewareResCaseID] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.CoursewareResCaseID].ToString().Trim(); //课件资源案例ID
objvCoursewareResCase_Resource_RelEN.CoursewareResCaseName = objRow[convCoursewareResCase_Resource_Rel.CoursewareResCaseName] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.CoursewareResCaseName].ToString().Trim(); //课件资源案例名称
objvCoursewareResCase_Resource_RelEN.CoursewareResCaseTheme = objRow[convCoursewareResCase_Resource_Rel.CoursewareResCaseTheme] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.CoursewareResCaseTheme].ToString().Trim(); //课件资源案例主题词
objvCoursewareResCase_Resource_RelEN.CoursewareResCaseText = objRow[convCoursewareResCase_Resource_Rel.CoursewareResCaseText] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.CoursewareResCaseText].ToString().Trim(); //案例文本内容
objvCoursewareResCase_Resource_RelEN.IdCoursewareResCaseType = objRow[convCoursewareResCase_Resource_Rel.IdCoursewareResCaseType] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.IdCoursewareResCaseType].ToString().Trim(); //课件资源类型流水号
objvCoursewareResCase_Resource_RelEN.CoursewareResCaseTypeName = objRow[convCoursewareResCase_Resource_Rel.CoursewareResCaseTypeName] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.CoursewareResCaseTypeName].ToString().Trim(); //课件资源案例类型名称
objvCoursewareResCase_Resource_RelEN.CoursewareResCaseDate = objRow[convCoursewareResCase_Resource_Rel.CoursewareResCaseDate] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.CoursewareResCaseDate].ToString().Trim(); //视频资源日期
objvCoursewareResCase_Resource_RelEN.CoursewareResCaseTime = objRow[convCoursewareResCase_Resource_Rel.CoursewareResCaseTime] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.CoursewareResCaseTime].ToString().Trim(); //视频资源时间
objvCoursewareResCase_Resource_RelEN.CoursewareResCaseDateIn = objRow[convCoursewareResCase_Resource_Rel.CoursewareResCaseDateIn] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.CoursewareResCaseDateIn].ToString().Trim(); //案例入库日期
objvCoursewareResCase_Resource_RelEN.CoursewareResCaseTimeIn = objRow[convCoursewareResCase_Resource_Rel.CoursewareResCaseTimeIn] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.CoursewareResCaseTimeIn].ToString().Trim(); //案例入库时间
objvCoursewareResCase_Resource_RelEN.OwnerId = objRow[convCoursewareResCase_Resource_Rel.OwnerId] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.OwnerId].ToString().Trim(); //拥有者Id
objvCoursewareResCase_Resource_RelEN.OwnerName = objRow[convCoursewareResCase_Resource_Rel.OwnerName] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.OwnerName].ToString().Trim(); //拥有者姓名
objvCoursewareResCase_Resource_RelEN.OwnerNameWithId = objRow[convCoursewareResCase_Resource_Rel.OwnerNameWithId] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvCoursewareResCase_Resource_RelEN.IdStudyLevel = objRow[convCoursewareResCase_Resource_Rel.IdStudyLevel] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvCoursewareResCase_Resource_RelEN.StudyLevelName = objRow[convCoursewareResCase_Resource_Rel.StudyLevelName] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.StudyLevelName].ToString().Trim(); //学段名称
objvCoursewareResCase_Resource_RelEN.IdTeachingPlan = objRow[convCoursewareResCase_Resource_Rel.IdTeachingPlan] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.IdTeachingPlan].ToString().Trim(); //教案流水号
objvCoursewareResCase_Resource_RelEN.IdDiscipline = objRow[convCoursewareResCase_Resource_Rel.IdDiscipline] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.IdDiscipline].ToString().Trim(); //学科流水号
objvCoursewareResCase_Resource_RelEN.DisciplineID = objRow[convCoursewareResCase_Resource_Rel.DisciplineID] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.DisciplineID].ToString().Trim(); //学科ID
objvCoursewareResCase_Resource_RelEN.DisciplineName = objRow[convCoursewareResCase_Resource_Rel.DisciplineName] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.DisciplineName].ToString().Trim(); //学科名称
objvCoursewareResCase_Resource_RelEN.senateGaugeVersionID = objRow[convCoursewareResCase_Resource_Rel.senateGaugeVersionID] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvCoursewareResCase_Resource_RelEN.senateGaugeVersionName = objRow[convCoursewareResCase_Resource_Rel.senateGaugeVersionName] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvCoursewareResCase_Resource_RelEN.senateGaugeVersionTtlScore = objRow[convCoursewareResCase_Resource_Rel.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convCoursewareResCase_Resource_Rel.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvCoursewareResCase_Resource_RelEN.VersionNo = objRow[convCoursewareResCase_Resource_Rel.VersionNo] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCoursewareResCase_Resource_Rel.VersionNo].ToString().Trim()); //版本号
objvCoursewareResCase_Resource_RelEN.IdTeachSkill = objRow[convCoursewareResCase_Resource_Rel.IdTeachSkill] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvCoursewareResCase_Resource_RelEN.TeachSkillID = objRow[convCoursewareResCase_Resource_Rel.TeachSkillID] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.TeachSkillID].ToString().Trim(); //教学技能ID
objvCoursewareResCase_Resource_RelEN.SkillTypeName = objRow[convCoursewareResCase_Resource_Rel.SkillTypeName] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.SkillTypeName].ToString().Trim(); //技能类型名称
objvCoursewareResCase_Resource_RelEN.TeachSkillName = objRow[convCoursewareResCase_Resource_Rel.TeachSkillName] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.TeachSkillName].ToString().Trim(); //教学技能名称
objvCoursewareResCase_Resource_RelEN.TeachSkillTheory = objRow[convCoursewareResCase_Resource_Rel.TeachSkillTheory] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvCoursewareResCase_Resource_RelEN.TeachSkillOperMethod = objRow[convCoursewareResCase_Resource_Rel.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvCoursewareResCase_Resource_RelEN.IdSkillType = objRow[convCoursewareResCase_Resource_Rel.IdSkillType] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.IdSkillType].ToString().Trim(); //技能类型流水号
objvCoursewareResCase_Resource_RelEN.SkillTypeID = objRow[convCoursewareResCase_Resource_Rel.SkillTypeID] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.SkillTypeID].ToString().Trim(); //技能类型ID
objvCoursewareResCase_Resource_RelEN.CaseLevelId = objRow[convCoursewareResCase_Resource_Rel.CaseLevelId] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.CaseLevelId].ToString().Trim(); //课例等级Id
objvCoursewareResCase_Resource_RelEN.IsDualVideo = TransNullToBool(objRow[convCoursewareResCase_Resource_Rel.IsDualVideo].ToString().Trim()); //是否双视频
objvCoursewareResCase_Resource_RelEN.IdXzCollege = objRow[convCoursewareResCase_Resource_Rel.IdXzCollege] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.IdXzCollege].ToString().Trim(); //学院流水号
objvCoursewareResCase_Resource_RelEN.CollegeID = objRow[convCoursewareResCase_Resource_Rel.CollegeID] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.CollegeID].ToString().Trim(); //学院ID
objvCoursewareResCase_Resource_RelEN.CollegeName = objRow[convCoursewareResCase_Resource_Rel.CollegeName] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.CollegeName].ToString().Trim(); //学院名称
objvCoursewareResCase_Resource_RelEN.IdXzMajor = objRow[convCoursewareResCase_Resource_Rel.IdXzMajor] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.IdXzMajor].ToString().Trim(); //专业流水号
objvCoursewareResCase_Resource_RelEN.MajorID = objRow[convCoursewareResCase_Resource_Rel.MajorID] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.MajorID].ToString().Trim(); //专业ID
objvCoursewareResCase_Resource_RelEN.MajorName = objRow[convCoursewareResCase_Resource_Rel.MajorName] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.MajorName].ToString().Trim(); //专业名称
objvCoursewareResCase_Resource_RelEN.CourseId = objRow[convCoursewareResCase_Resource_Rel.CourseId] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.CourseId].ToString().Trim(); //课程Id
objvCoursewareResCase_Resource_RelEN.CourseCode = objRow[convCoursewareResCase_Resource_Rel.CourseCode] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.CourseCode].ToString().Trim(); //课程代码
objvCoursewareResCase_Resource_RelEN.CourseName = objRow[convCoursewareResCase_Resource_Rel.CourseName] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.CourseName].ToString().Trim(); //课程名称
objvCoursewareResCase_Resource_RelEN.CourseChapterId = objRow[convCoursewareResCase_Resource_Rel.CourseChapterId] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.CourseChapterId].ToString().Trim(); //课程章节ID
objvCoursewareResCase_Resource_RelEN.CourseChapterName = objRow[convCoursewareResCase_Resource_Rel.CourseChapterName] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.CourseChapterName].ToString().Trim(); //课程章节名称
objvCoursewareResCase_Resource_RelEN.ParentNodeID = objRow[convCoursewareResCase_Resource_Rel.ParentNodeID] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.ParentNodeID].ToString().Trim(); //父节点编号
objvCoursewareResCase_Resource_RelEN.ParentNodeName = objRow[convCoursewareResCase_Resource_Rel.ParentNodeName] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.ParentNodeName].ToString().Trim(); //父节点名称
objvCoursewareResCase_Resource_RelEN.ViewCount = objRow[convCoursewareResCase_Resource_Rel.ViewCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCoursewareResCase_Resource_Rel.ViewCount].ToString().Trim()); //浏览量
objvCoursewareResCase_Resource_RelEN.IsShow = TransNullToBool(objRow[convCoursewareResCase_Resource_Rel.IsShow].ToString().Trim()); //是否启用
objvCoursewareResCase_Resource_RelEN.DownloadNumber = objRow[convCoursewareResCase_Resource_Rel.DownloadNumber] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCoursewareResCase_Resource_Rel.DownloadNumber].ToString().Trim()); //下载数目
objvCoursewareResCase_Resource_RelEN.FileIntegration = objRow[convCoursewareResCase_Resource_Rel.FileIntegration] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCoursewareResCase_Resource_Rel.FileIntegration].ToString().Trim()); //文件积分
objvCoursewareResCase_Resource_RelEN.LikeCount = objRow[convCoursewareResCase_Resource_Rel.LikeCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convCoursewareResCase_Resource_Rel.LikeCount].ToString().Trim()); //资源喜欢数量
objvCoursewareResCase_Resource_RelEN.CollectionCount = objRow[convCoursewareResCase_Resource_Rel.CollectionCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convCoursewareResCase_Resource_Rel.CollectionCount].ToString().Trim()); //收藏数量
objvCoursewareResCase_Resource_RelEN.RecommendedDegreeId = objRow[convCoursewareResCase_Resource_Rel.RecommendedDegreeId] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvCoursewareResCase_Resource_RelEN.RecommendedDegreeName = objRow[convCoursewareResCase_Resource_Rel.RecommendedDegreeName] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvCoursewareResCase_Resource_RelEN.BrowseCount4Case = objRow[convCoursewareResCase_Resource_Rel.BrowseCount4Case] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCoursewareResCase_Resource_Rel.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvCoursewareResCase_Resource_RelEN.CollegeNameA = objRow[convCoursewareResCase_Resource_Rel.CollegeNameA] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.CollegeNameA].ToString().Trim(); //学院名称简写
objvCoursewareResCase_Resource_RelEN.IdResource = objRow[convCoursewareResCase_Resource_Rel.IdResource].ToString().Trim(); //资源流水号
objvCoursewareResCase_Resource_RelEN.ResourceID = objRow[convCoursewareResCase_Resource_Rel.ResourceID] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.ResourceID].ToString().Trim(); //资源ID
objvCoursewareResCase_Resource_RelEN.ResourceName = objRow[convCoursewareResCase_Resource_Rel.ResourceName] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.ResourceName].ToString().Trim(); //资源名称
objvCoursewareResCase_Resource_RelEN.IdFtpResource = objRow[convCoursewareResCase_Resource_Rel.IdFtpResource] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvCoursewareResCase_Resource_RelEN.IdFile = objRow[convCoursewareResCase_Resource_Rel.IdFile] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.IdFile].ToString().Trim(); //文件流水号
objvCoursewareResCase_Resource_RelEN.FileName = objRow[convCoursewareResCase_Resource_Rel.FileName] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.FileName].ToString().Trim(); //文件名称
objvCoursewareResCase_Resource_RelEN.FileType = objRow[convCoursewareResCase_Resource_Rel.FileType] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.FileType].ToString().Trim(); //文件类型
objvCoursewareResCase_Resource_RelEN.SaveDate = objRow[convCoursewareResCase_Resource_Rel.SaveDate] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.SaveDate].ToString().Trim(); //创建日期
objvCoursewareResCase_Resource_RelEN.FileSize = objRow[convCoursewareResCase_Resource_Rel.FileSize] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.FileSize].ToString().Trim(); //文件大小
objvCoursewareResCase_Resource_RelEN.SaveTime = objRow[convCoursewareResCase_Resource_Rel.SaveTime] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.SaveTime].ToString().Trim(); //创建时间
objvCoursewareResCase_Resource_RelEN.FtpResourceID = objRow[convCoursewareResCase_Resource_Rel.FtpResourceID] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.FtpResourceID].ToString().Trim(); //FTP资源ID
objvCoursewareResCase_Resource_RelEN.FileOriginalName = objRow[convCoursewareResCase_Resource_Rel.FileOriginalName] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.FileOriginalName].ToString().Trim(); //文件原名
objvCoursewareResCase_Resource_RelEN.FileDirName = objRow[convCoursewareResCase_Resource_Rel.FileDirName] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.FileDirName].ToString().Trim(); //文件目录名
objvCoursewareResCase_Resource_RelEN.FileRename = objRow[convCoursewareResCase_Resource_Rel.FileRename] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.FileRename].ToString().Trim(); //文件新名
objvCoursewareResCase_Resource_RelEN.FileUpDate = objRow[convCoursewareResCase_Resource_Rel.FileUpDate] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.FileUpDate].ToString().Trim(); //创建日期
objvCoursewareResCase_Resource_RelEN.FileUpTime = objRow[convCoursewareResCase_Resource_Rel.FileUpTime] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.FileUpTime].ToString().Trim(); //创建时间
objvCoursewareResCase_Resource_RelEN.SaveMode = TransNullToBool(objRow[convCoursewareResCase_Resource_Rel.SaveMode].ToString().Trim()); //文件存放方式
objvCoursewareResCase_Resource_RelEN.IdResourceType = objRow[convCoursewareResCase_Resource_Rel.IdResourceType] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.IdResourceType].ToString().Trim(); //资源类型流水号
objvCoursewareResCase_Resource_RelEN.ResourceTypeID = objRow[convCoursewareResCase_Resource_Rel.ResourceTypeID] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.ResourceTypeID].ToString().Trim(); //资源类型ID
objvCoursewareResCase_Resource_RelEN.ResourceTypeName = objRow[convCoursewareResCase_Resource_Rel.ResourceTypeName] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.ResourceTypeName].ToString().Trim(); //资源类型名称
objvCoursewareResCase_Resource_RelEN.ResourceOwner = objRow[convCoursewareResCase_Resource_Rel.ResourceOwner] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.ResourceOwner].ToString().Trim(); //上传者
objvCoursewareResCase_Resource_RelEN.ftpFileType = objRow[convCoursewareResCase_Resource_Rel.ftpFileType] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.ftpFileType].ToString().Trim(); //ftp文件类型
objvCoursewareResCase_Resource_RelEN.ftpFileSize = objRow[convCoursewareResCase_Resource_Rel.ftpFileSize] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.ftpFileSize].ToString().Trim(); //ftp文件大小
objvCoursewareResCase_Resource_RelEN.ftpResourceOwner = objRow[convCoursewareResCase_Resource_Rel.ftpResourceOwner] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvCoursewareResCase_Resource_RelEN.FileOriginName = objRow[convCoursewareResCase_Resource_Rel.FileOriginName] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.FileOriginName].ToString().Trim(); //原文件名
objvCoursewareResCase_Resource_RelEN.IsExistFile = TransNullToBool(objRow[convCoursewareResCase_Resource_Rel.IsExistFile].ToString().Trim()); //是否存在文件
objvCoursewareResCase_Resource_RelEN.FileNewName = objRow[convCoursewareResCase_Resource_Rel.FileNewName] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.FileNewName].ToString().Trim(); //新文件名
objvCoursewareResCase_Resource_RelEN.FileOldName = objRow[convCoursewareResCase_Resource_Rel.FileOldName] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.FileOldName].ToString().Trim(); //旧文件名
objvCoursewareResCase_Resource_RelEN.IsMain = TransNullToBool(objRow[convCoursewareResCase_Resource_Rel.IsMain].ToString().Trim()); //是否主资源
objvCoursewareResCase_Resource_RelEN.IdUsingMode = objRow[convCoursewareResCase_Resource_Rel.IdUsingMode] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.IdUsingMode].ToString().Trim(); //资源使用模式流水号
objvCoursewareResCase_Resource_RelEN.IsVisible = TransNullToBool(objRow[convCoursewareResCase_Resource_Rel.IsVisible].ToString().Trim()); //是否显示
objvCoursewareResCase_Resource_RelEN.IndexNO = objRow[convCoursewareResCase_Resource_Rel.IndexNO] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCoursewareResCase_Resource_Rel.IndexNO].ToString().Trim()); //序号
objvCoursewareResCase_Resource_RelEN.BrowseCount = objRow[convCoursewareResCase_Resource_Rel.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCoursewareResCase_Resource_Rel.BrowseCount].ToString().Trim()); //浏览次数
objvCoursewareResCase_Resource_RelEN.UpdDate = objRow[convCoursewareResCase_Resource_Rel.UpdDate] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.UpdDate].ToString().Trim(); //修改日期
objvCoursewareResCase_Resource_RelEN.UpdUser = objRow[convCoursewareResCase_Resource_Rel.UpdUser] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.UpdUser].ToString().Trim(); //修改人
objvCoursewareResCase_Resource_RelEN.Memo = objRow[convCoursewareResCase_Resource_Rel.Memo] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvCoursewareResCase_Resource_RelDA: GetObjLst)", objException.Message));
}
objvCoursewareResCase_Resource_RelEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvCoursewareResCase_Resource_RelEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvCoursewareResCase_Resource_RelEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvCoursewareResCase_Resource_Rel(ref clsvCoursewareResCase_Resource_RelEN objvCoursewareResCase_Resource_RelEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCoursewareResCase_Resource_RelDA.GetSpecSQLObj();
strSQL = "Select * from vCoursewareResCase_Resource_Rel where IdMicroteachCaseResourceRel = " + ""+ objvCoursewareResCase_Resource_RelEN.IdMicroteachCaseResourceRel+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvCoursewareResCase_Resource_RelEN.IdMicroteachCaseResourceRel = TransNullToInt(objDT.Rows[0][convCoursewareResCase_Resource_Rel.IdMicroteachCaseResourceRel].ToString().Trim()); //微格案例资源关系流水号(字段类型:bigint,字段长度:8,是否可空:False)
 objvCoursewareResCase_Resource_RelEN.FuncModuleId = objDT.Rows[0][convCoursewareResCase_Resource_Rel.FuncModuleId].ToString().Trim(); //功能模块Id(字段类型:char,字段长度:4,是否可空:True)
 objvCoursewareResCase_Resource_RelEN.FuncModuleName = objDT.Rows[0][convCoursewareResCase_Resource_Rel.FuncModuleName].ToString().Trim(); //功能模块名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvCoursewareResCase_Resource_RelEN.IdMicroteachCase = objDT.Rows[0][convCoursewareResCase_Resource_Rel.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号(字段类型:char,字段长度:8,是否可空:False)
 objvCoursewareResCase_Resource_RelEN.CoursewareResCaseID = objDT.Rows[0][convCoursewareResCase_Resource_Rel.CoursewareResCaseID].ToString().Trim(); //课件资源案例ID(字段类型:char,字段长度:8,是否可空:False)
 objvCoursewareResCase_Resource_RelEN.CoursewareResCaseName = objDT.Rows[0][convCoursewareResCase_Resource_Rel.CoursewareResCaseName].ToString().Trim(); //课件资源案例名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvCoursewareResCase_Resource_RelEN.CoursewareResCaseTheme = objDT.Rows[0][convCoursewareResCase_Resource_Rel.CoursewareResCaseTheme].ToString().Trim(); //课件资源案例主题词(字段类型:varchar,字段长度:200,是否可空:True)
 objvCoursewareResCase_Resource_RelEN.CoursewareResCaseText = objDT.Rows[0][convCoursewareResCase_Resource_Rel.CoursewareResCaseText].ToString().Trim(); //案例文本内容(字段类型:varchar,字段长度:8000,是否可空:True)
 objvCoursewareResCase_Resource_RelEN.IdCoursewareResCaseType = objDT.Rows[0][convCoursewareResCase_Resource_Rel.IdCoursewareResCaseType].ToString().Trim(); //课件资源类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvCoursewareResCase_Resource_RelEN.CoursewareResCaseTypeName = objDT.Rows[0][convCoursewareResCase_Resource_Rel.CoursewareResCaseTypeName].ToString().Trim(); //课件资源案例类型名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvCoursewareResCase_Resource_RelEN.CoursewareResCaseDate = objDT.Rows[0][convCoursewareResCase_Resource_Rel.CoursewareResCaseDate].ToString().Trim(); //视频资源日期(字段类型:char,字段长度:8,是否可空:True)
 objvCoursewareResCase_Resource_RelEN.CoursewareResCaseTime = objDT.Rows[0][convCoursewareResCase_Resource_Rel.CoursewareResCaseTime].ToString().Trim(); //视频资源时间(字段类型:char,字段长度:6,是否可空:True)
 objvCoursewareResCase_Resource_RelEN.CoursewareResCaseDateIn = objDT.Rows[0][convCoursewareResCase_Resource_Rel.CoursewareResCaseDateIn].ToString().Trim(); //案例入库日期(字段类型:char,字段长度:8,是否可空:True)
 objvCoursewareResCase_Resource_RelEN.CoursewareResCaseTimeIn = objDT.Rows[0][convCoursewareResCase_Resource_Rel.CoursewareResCaseTimeIn].ToString().Trim(); //案例入库时间(字段类型:char,字段长度:6,是否可空:True)
 objvCoursewareResCase_Resource_RelEN.OwnerId = objDT.Rows[0][convCoursewareResCase_Resource_Rel.OwnerId].ToString().Trim(); //拥有者Id(字段类型:varchar,字段长度:20,是否可空:False)
 objvCoursewareResCase_Resource_RelEN.OwnerName = objDT.Rows[0][convCoursewareResCase_Resource_Rel.OwnerName].ToString().Trim(); //拥有者姓名(字段类型:varchar,字段长度:30,是否可空:True)
 objvCoursewareResCase_Resource_RelEN.OwnerNameWithId = objDT.Rows[0][convCoursewareResCase_Resource_Rel.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id(字段类型:varchar,字段长度:51,是否可空:True)
 objvCoursewareResCase_Resource_RelEN.IdStudyLevel = objDT.Rows[0][convCoursewareResCase_Resource_Rel.IdStudyLevel].ToString().Trim(); //id_StudyLevel(字段类型:char,字段长度:4,是否可空:True)
 objvCoursewareResCase_Resource_RelEN.StudyLevelName = objDT.Rows[0][convCoursewareResCase_Resource_Rel.StudyLevelName].ToString().Trim(); //学段名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvCoursewareResCase_Resource_RelEN.IdTeachingPlan = objDT.Rows[0][convCoursewareResCase_Resource_Rel.IdTeachingPlan].ToString().Trim(); //教案流水号(字段类型:char,字段长度:8,是否可空:False)
 objvCoursewareResCase_Resource_RelEN.IdDiscipline = objDT.Rows[0][convCoursewareResCase_Resource_Rel.IdDiscipline].ToString().Trim(); //学科流水号(字段类型:char,字段长度:4,是否可空:False)
 objvCoursewareResCase_Resource_RelEN.DisciplineID = objDT.Rows[0][convCoursewareResCase_Resource_Rel.DisciplineID].ToString().Trim(); //学科ID(字段类型:char,字段长度:4,是否可空:False)
 objvCoursewareResCase_Resource_RelEN.DisciplineName = objDT.Rows[0][convCoursewareResCase_Resource_Rel.DisciplineName].ToString().Trim(); //学科名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvCoursewareResCase_Resource_RelEN.senateGaugeVersionID = objDT.Rows[0][convCoursewareResCase_Resource_Rel.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID(字段类型:char,字段长度:4,是否可空:False)
 objvCoursewareResCase_Resource_RelEN.senateGaugeVersionName = objDT.Rows[0][convCoursewareResCase_Resource_Rel.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称(字段类型:varchar,字段长度:200,是否可空:True)
 objvCoursewareResCase_Resource_RelEN.senateGaugeVersionTtlScore = TransNullToFloat(objDT.Rows[0][convCoursewareResCase_Resource_Rel.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分(字段类型:float,字段长度:8,是否可空:False)
 objvCoursewareResCase_Resource_RelEN.VersionNo = TransNullToInt(objDT.Rows[0][convCoursewareResCase_Resource_Rel.VersionNo].ToString().Trim()); //版本号(字段类型:int,字段长度:4,是否可空:True)
 objvCoursewareResCase_Resource_RelEN.IdTeachSkill = objDT.Rows[0][convCoursewareResCase_Resource_Rel.IdTeachSkill].ToString().Trim(); //教学技能流水号(字段类型:char,字段长度:8,是否可空:False)
 objvCoursewareResCase_Resource_RelEN.TeachSkillID = objDT.Rows[0][convCoursewareResCase_Resource_Rel.TeachSkillID].ToString().Trim(); //教学技能ID(字段类型:char,字段长度:8,是否可空:False)
 objvCoursewareResCase_Resource_RelEN.SkillTypeName = objDT.Rows[0][convCoursewareResCase_Resource_Rel.SkillTypeName].ToString().Trim(); //技能类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvCoursewareResCase_Resource_RelEN.TeachSkillName = objDT.Rows[0][convCoursewareResCase_Resource_Rel.TeachSkillName].ToString().Trim(); //教学技能名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvCoursewareResCase_Resource_RelEN.TeachSkillTheory = objDT.Rows[0][convCoursewareResCase_Resource_Rel.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述(字段类型:varchar,字段长度:8000,是否可空:True)
 objvCoursewareResCase_Resource_RelEN.TeachSkillOperMethod = objDT.Rows[0][convCoursewareResCase_Resource_Rel.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法(字段类型:varchar,字段长度:2000,是否可空:True)
 objvCoursewareResCase_Resource_RelEN.IdSkillType = objDT.Rows[0][convCoursewareResCase_Resource_Rel.IdSkillType].ToString().Trim(); //技能类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvCoursewareResCase_Resource_RelEN.SkillTypeID = objDT.Rows[0][convCoursewareResCase_Resource_Rel.SkillTypeID].ToString().Trim(); //技能类型ID(字段类型:char,字段长度:4,是否可空:False)
 objvCoursewareResCase_Resource_RelEN.CaseLevelId = objDT.Rows[0][convCoursewareResCase_Resource_Rel.CaseLevelId].ToString().Trim(); //课例等级Id(字段类型:char,字段长度:2,是否可空:True)
 objvCoursewareResCase_Resource_RelEN.IsDualVideo = TransNullToBool(objDT.Rows[0][convCoursewareResCase_Resource_Rel.IsDualVideo].ToString().Trim()); //是否双视频(字段类型:bit,字段长度:1,是否可空:False)
 objvCoursewareResCase_Resource_RelEN.IdXzCollege = objDT.Rows[0][convCoursewareResCase_Resource_Rel.IdXzCollege].ToString().Trim(); //学院流水号(字段类型:char,字段长度:4,是否可空:True)
 objvCoursewareResCase_Resource_RelEN.CollegeID = objDT.Rows[0][convCoursewareResCase_Resource_Rel.CollegeID].ToString().Trim(); //学院ID(字段类型:varchar,字段长度:4,是否可空:False)
 objvCoursewareResCase_Resource_RelEN.CollegeName = objDT.Rows[0][convCoursewareResCase_Resource_Rel.CollegeName].ToString().Trim(); //学院名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvCoursewareResCase_Resource_RelEN.IdXzMajor = objDT.Rows[0][convCoursewareResCase_Resource_Rel.IdXzMajor].ToString().Trim(); //专业流水号(字段类型:char,字段长度:8,是否可空:False)
 objvCoursewareResCase_Resource_RelEN.MajorID = objDT.Rows[0][convCoursewareResCase_Resource_Rel.MajorID].ToString().Trim(); //专业ID(字段类型:char,字段长度:4,是否可空:False)
 objvCoursewareResCase_Resource_RelEN.MajorName = objDT.Rows[0][convCoursewareResCase_Resource_Rel.MajorName].ToString().Trim(); //专业名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvCoursewareResCase_Resource_RelEN.CourseId = objDT.Rows[0][convCoursewareResCase_Resource_Rel.CourseId].ToString().Trim(); //课程Id(字段类型:char,字段长度:8,是否可空:True)
 objvCoursewareResCase_Resource_RelEN.CourseCode = objDT.Rows[0][convCoursewareResCase_Resource_Rel.CourseCode].ToString().Trim(); //课程代码(字段类型:varchar,字段长度:20,是否可空:True)
 objvCoursewareResCase_Resource_RelEN.CourseName = objDT.Rows[0][convCoursewareResCase_Resource_Rel.CourseName].ToString().Trim(); //课程名称(字段类型:varchar,字段长度:100,是否可空:True)
 objvCoursewareResCase_Resource_RelEN.CourseChapterId = objDT.Rows[0][convCoursewareResCase_Resource_Rel.CourseChapterId].ToString().Trim(); //课程章节ID(字段类型:char,字段长度:8,是否可空:False)
 objvCoursewareResCase_Resource_RelEN.CourseChapterName = objDT.Rows[0][convCoursewareResCase_Resource_Rel.CourseChapterName].ToString().Trim(); //课程章节名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvCoursewareResCase_Resource_RelEN.ParentNodeID = objDT.Rows[0][convCoursewareResCase_Resource_Rel.ParentNodeID].ToString().Trim(); //父节点编号(字段类型:varchar,字段长度:8,是否可空:True)
 objvCoursewareResCase_Resource_RelEN.ParentNodeName = objDT.Rows[0][convCoursewareResCase_Resource_Rel.ParentNodeName].ToString().Trim(); //父节点名称(字段类型:varchar,字段长度:50,是否可空:True)
 objvCoursewareResCase_Resource_RelEN.ViewCount = TransNullToInt(objDT.Rows[0][convCoursewareResCase_Resource_Rel.ViewCount].ToString().Trim()); //浏览量(字段类型:int,字段长度:4,是否可空:True)
 objvCoursewareResCase_Resource_RelEN.IsShow = TransNullToBool(objDT.Rows[0][convCoursewareResCase_Resource_Rel.IsShow].ToString().Trim()); //是否启用(字段类型:bit,字段长度:1,是否可空:True)
 objvCoursewareResCase_Resource_RelEN.DownloadNumber = TransNullToInt(objDT.Rows[0][convCoursewareResCase_Resource_Rel.DownloadNumber].ToString().Trim()); //下载数目(字段类型:int,字段长度:4,是否可空:True)
 objvCoursewareResCase_Resource_RelEN.FileIntegration = TransNullToInt(objDT.Rows[0][convCoursewareResCase_Resource_Rel.FileIntegration].ToString().Trim()); //文件积分(字段类型:int,字段长度:4,是否可空:True)
 objvCoursewareResCase_Resource_RelEN.LikeCount = TransNullToInt(objDT.Rows[0][convCoursewareResCase_Resource_Rel.LikeCount].ToString().Trim()); //资源喜欢数量(字段类型:bigint,字段长度:8,是否可空:True)
 objvCoursewareResCase_Resource_RelEN.CollectionCount = TransNullToInt(objDT.Rows[0][convCoursewareResCase_Resource_Rel.CollectionCount].ToString().Trim()); //收藏数量(字段类型:bigint,字段长度:8,是否可空:True)
 objvCoursewareResCase_Resource_RelEN.RecommendedDegreeId = objDT.Rows[0][convCoursewareResCase_Resource_Rel.RecommendedDegreeId].ToString().Trim(); //推荐度Id(字段类型:char,字段长度:2,是否可空:False)
 objvCoursewareResCase_Resource_RelEN.RecommendedDegreeName = objDT.Rows[0][convCoursewareResCase_Resource_Rel.RecommendedDegreeName].ToString().Trim(); //推荐度名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvCoursewareResCase_Resource_RelEN.BrowseCount4Case = TransNullToInt(objDT.Rows[0][convCoursewareResCase_Resource_Rel.BrowseCount4Case].ToString().Trim()); //课例浏览次数(字段类型:int,字段长度:4,是否可空:True)
 objvCoursewareResCase_Resource_RelEN.CollegeNameA = objDT.Rows[0][convCoursewareResCase_Resource_Rel.CollegeNameA].ToString().Trim(); //学院名称简写(字段类型:varchar,字段长度:12,是否可空:True)
 objvCoursewareResCase_Resource_RelEN.IdResource = objDT.Rows[0][convCoursewareResCase_Resource_Rel.IdResource].ToString().Trim(); //资源流水号(字段类型:char,字段长度:8,是否可空:False)
 objvCoursewareResCase_Resource_RelEN.ResourceID = objDT.Rows[0][convCoursewareResCase_Resource_Rel.ResourceID].ToString().Trim(); //资源ID(字段类型:char,字段长度:8,是否可空:False)
 objvCoursewareResCase_Resource_RelEN.ResourceName = objDT.Rows[0][convCoursewareResCase_Resource_Rel.ResourceName].ToString().Trim(); //资源名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvCoursewareResCase_Resource_RelEN.IdFtpResource = objDT.Rows[0][convCoursewareResCase_Resource_Rel.IdFtpResource].ToString().Trim(); //FTP资源流水号(字段类型:char,字段长度:8,是否可空:True)
 objvCoursewareResCase_Resource_RelEN.IdFile = objDT.Rows[0][convCoursewareResCase_Resource_Rel.IdFile].ToString().Trim(); //文件流水号(字段类型:char,字段长度:8,是否可空:True)
 objvCoursewareResCase_Resource_RelEN.FileName = objDT.Rows[0][convCoursewareResCase_Resource_Rel.FileName].ToString().Trim(); //文件名称(字段类型:varchar,字段长度:500,是否可空:True)
 objvCoursewareResCase_Resource_RelEN.FileType = objDT.Rows[0][convCoursewareResCase_Resource_Rel.FileType].ToString().Trim(); //文件类型(字段类型:varchar,字段长度:30,是否可空:True)
 objvCoursewareResCase_Resource_RelEN.SaveDate = objDT.Rows[0][convCoursewareResCase_Resource_Rel.SaveDate].ToString().Trim(); //创建日期(字段类型:char,字段长度:8,是否可空:True)
 objvCoursewareResCase_Resource_RelEN.FileSize = objDT.Rows[0][convCoursewareResCase_Resource_Rel.FileSize].ToString().Trim(); //文件大小(字段类型:varchar,字段长度:50,是否可空:True)
 objvCoursewareResCase_Resource_RelEN.SaveTime = objDT.Rows[0][convCoursewareResCase_Resource_Rel.SaveTime].ToString().Trim(); //创建时间(字段类型:char,字段长度:6,是否可空:True)
 objvCoursewareResCase_Resource_RelEN.FtpResourceID = objDT.Rows[0][convCoursewareResCase_Resource_Rel.FtpResourceID].ToString().Trim(); //FTP资源ID(字段类型:char,字段长度:8,是否可空:False)
 objvCoursewareResCase_Resource_RelEN.FileOriginalName = objDT.Rows[0][convCoursewareResCase_Resource_Rel.FileOriginalName].ToString().Trim(); //文件原名(字段类型:varchar,字段长度:200,是否可空:True)
 objvCoursewareResCase_Resource_RelEN.FileDirName = objDT.Rows[0][convCoursewareResCase_Resource_Rel.FileDirName].ToString().Trim(); //文件目录名(字段类型:varchar,字段长度:200,是否可空:True)
 objvCoursewareResCase_Resource_RelEN.FileRename = objDT.Rows[0][convCoursewareResCase_Resource_Rel.FileRename].ToString().Trim(); //文件新名(字段类型:varchar,字段长度:200,是否可空:True)
 objvCoursewareResCase_Resource_RelEN.FileUpDate = objDT.Rows[0][convCoursewareResCase_Resource_Rel.FileUpDate].ToString().Trim(); //创建日期(字段类型:char,字段长度:8,是否可空:True)
 objvCoursewareResCase_Resource_RelEN.FileUpTime = objDT.Rows[0][convCoursewareResCase_Resource_Rel.FileUpTime].ToString().Trim(); //创建时间(字段类型:char,字段长度:6,是否可空:True)
 objvCoursewareResCase_Resource_RelEN.SaveMode = TransNullToBool(objDT.Rows[0][convCoursewareResCase_Resource_Rel.SaveMode].ToString().Trim()); //文件存放方式(字段类型:bit,字段长度:1,是否可空:True)
 objvCoursewareResCase_Resource_RelEN.IdResourceType = objDT.Rows[0][convCoursewareResCase_Resource_Rel.IdResourceType].ToString().Trim(); //资源类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvCoursewareResCase_Resource_RelEN.ResourceTypeID = objDT.Rows[0][convCoursewareResCase_Resource_Rel.ResourceTypeID].ToString().Trim(); //资源类型ID(字段类型:char,字段长度:4,是否可空:False)
 objvCoursewareResCase_Resource_RelEN.ResourceTypeName = objDT.Rows[0][convCoursewareResCase_Resource_Rel.ResourceTypeName].ToString().Trim(); //资源类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvCoursewareResCase_Resource_RelEN.ResourceOwner = objDT.Rows[0][convCoursewareResCase_Resource_Rel.ResourceOwner].ToString().Trim(); //上传者(字段类型:varchar,字段长度:50,是否可空:False)
 objvCoursewareResCase_Resource_RelEN.ftpFileType = objDT.Rows[0][convCoursewareResCase_Resource_Rel.ftpFileType].ToString().Trim(); //ftp文件类型(字段类型:varchar,字段长度:30,是否可空:True)
 objvCoursewareResCase_Resource_RelEN.ftpFileSize = objDT.Rows[0][convCoursewareResCase_Resource_Rel.ftpFileSize].ToString().Trim(); //ftp文件大小(字段类型:varchar,字段长度:50,是否可空:True)
 objvCoursewareResCase_Resource_RelEN.ftpResourceOwner = objDT.Rows[0][convCoursewareResCase_Resource_Rel.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者(字段类型:varchar,字段长度:50,是否可空:True)
 objvCoursewareResCase_Resource_RelEN.FileOriginName = objDT.Rows[0][convCoursewareResCase_Resource_Rel.FileOriginName].ToString().Trim(); //原文件名(字段类型:varchar,字段长度:500,是否可空:True)
 objvCoursewareResCase_Resource_RelEN.IsExistFile = TransNullToBool(objDT.Rows[0][convCoursewareResCase_Resource_Rel.IsExistFile].ToString().Trim()); //是否存在文件(字段类型:bit,字段长度:1,是否可空:True)
 objvCoursewareResCase_Resource_RelEN.FileNewName = objDT.Rows[0][convCoursewareResCase_Resource_Rel.FileNewName].ToString().Trim(); //新文件名(字段类型:varchar,字段长度:530,是否可空:True)
 objvCoursewareResCase_Resource_RelEN.FileOldName = objDT.Rows[0][convCoursewareResCase_Resource_Rel.FileOldName].ToString().Trim(); //旧文件名(字段类型:varchar,字段长度:530,是否可空:True)
 objvCoursewareResCase_Resource_RelEN.IsMain = TransNullToBool(objDT.Rows[0][convCoursewareResCase_Resource_Rel.IsMain].ToString().Trim()); //是否主资源(字段类型:bit,字段长度:1,是否可空:True)
 objvCoursewareResCase_Resource_RelEN.IdUsingMode = objDT.Rows[0][convCoursewareResCase_Resource_Rel.IdUsingMode].ToString().Trim(); //资源使用模式流水号(字段类型:char,字段长度:4,是否可空:False)
 objvCoursewareResCase_Resource_RelEN.IsVisible = TransNullToBool(objDT.Rows[0][convCoursewareResCase_Resource_Rel.IsVisible].ToString().Trim()); //是否显示(字段类型:bit,字段长度:1,是否可空:True)
 objvCoursewareResCase_Resource_RelEN.IndexNO = TransNullToInt(objDT.Rows[0][convCoursewareResCase_Resource_Rel.IndexNO].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:True)
 objvCoursewareResCase_Resource_RelEN.BrowseCount = TransNullToInt(objDT.Rows[0][convCoursewareResCase_Resource_Rel.BrowseCount].ToString().Trim()); //浏览次数(字段类型:int,字段长度:4,是否可空:True)
 objvCoursewareResCase_Resource_RelEN.UpdDate = objDT.Rows[0][convCoursewareResCase_Resource_Rel.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvCoursewareResCase_Resource_RelEN.UpdUser = objDT.Rows[0][convCoursewareResCase_Resource_Rel.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objvCoursewareResCase_Resource_RelEN.Memo = objDT.Rows[0][convCoursewareResCase_Resource_Rel.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvCoursewareResCase_Resource_RelDA: GetvCoursewareResCase_Resource_Rel)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngIdMicroteachCaseResourceRel">表关键字</param>
 /// <returns>表对象</returns>
public clsvCoursewareResCase_Resource_RelEN GetObjByIdMicroteachCaseResourceRel(long lngIdMicroteachCaseResourceRel)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCoursewareResCase_Resource_RelDA.GetSpecSQLObj();
strSQL = "Select * from vCoursewareResCase_Resource_Rel where IdMicroteachCaseResourceRel = " + ""+ lngIdMicroteachCaseResourceRel+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvCoursewareResCase_Resource_RelEN objvCoursewareResCase_Resource_RelEN = new clsvCoursewareResCase_Resource_RelEN();
try
{
 objvCoursewareResCase_Resource_RelEN.IdMicroteachCaseResourceRel = Int32.Parse(objRow[convCoursewareResCase_Resource_Rel.IdMicroteachCaseResourceRel].ToString().Trim()); //微格案例资源关系流水号(字段类型:bigint,字段长度:8,是否可空:False)
 objvCoursewareResCase_Resource_RelEN.FuncModuleId = objRow[convCoursewareResCase_Resource_Rel.FuncModuleId].ToString().Trim(); //功能模块Id(字段类型:char,字段长度:4,是否可空:True)
 objvCoursewareResCase_Resource_RelEN.FuncModuleName = objRow[convCoursewareResCase_Resource_Rel.FuncModuleName] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.FuncModuleName].ToString().Trim(); //功能模块名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvCoursewareResCase_Resource_RelEN.IdMicroteachCase = objRow[convCoursewareResCase_Resource_Rel.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号(字段类型:char,字段长度:8,是否可空:False)
 objvCoursewareResCase_Resource_RelEN.CoursewareResCaseID = objRow[convCoursewareResCase_Resource_Rel.CoursewareResCaseID] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.CoursewareResCaseID].ToString().Trim(); //课件资源案例ID(字段类型:char,字段长度:8,是否可空:False)
 objvCoursewareResCase_Resource_RelEN.CoursewareResCaseName = objRow[convCoursewareResCase_Resource_Rel.CoursewareResCaseName] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.CoursewareResCaseName].ToString().Trim(); //课件资源案例名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvCoursewareResCase_Resource_RelEN.CoursewareResCaseTheme = objRow[convCoursewareResCase_Resource_Rel.CoursewareResCaseTheme] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.CoursewareResCaseTheme].ToString().Trim(); //课件资源案例主题词(字段类型:varchar,字段长度:200,是否可空:True)
 objvCoursewareResCase_Resource_RelEN.CoursewareResCaseText = objRow[convCoursewareResCase_Resource_Rel.CoursewareResCaseText] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.CoursewareResCaseText].ToString().Trim(); //案例文本内容(字段类型:varchar,字段长度:8000,是否可空:True)
 objvCoursewareResCase_Resource_RelEN.IdCoursewareResCaseType = objRow[convCoursewareResCase_Resource_Rel.IdCoursewareResCaseType] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.IdCoursewareResCaseType].ToString().Trim(); //课件资源类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvCoursewareResCase_Resource_RelEN.CoursewareResCaseTypeName = objRow[convCoursewareResCase_Resource_Rel.CoursewareResCaseTypeName] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.CoursewareResCaseTypeName].ToString().Trim(); //课件资源案例类型名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvCoursewareResCase_Resource_RelEN.CoursewareResCaseDate = objRow[convCoursewareResCase_Resource_Rel.CoursewareResCaseDate] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.CoursewareResCaseDate].ToString().Trim(); //视频资源日期(字段类型:char,字段长度:8,是否可空:True)
 objvCoursewareResCase_Resource_RelEN.CoursewareResCaseTime = objRow[convCoursewareResCase_Resource_Rel.CoursewareResCaseTime] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.CoursewareResCaseTime].ToString().Trim(); //视频资源时间(字段类型:char,字段长度:6,是否可空:True)
 objvCoursewareResCase_Resource_RelEN.CoursewareResCaseDateIn = objRow[convCoursewareResCase_Resource_Rel.CoursewareResCaseDateIn] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.CoursewareResCaseDateIn].ToString().Trim(); //案例入库日期(字段类型:char,字段长度:8,是否可空:True)
 objvCoursewareResCase_Resource_RelEN.CoursewareResCaseTimeIn = objRow[convCoursewareResCase_Resource_Rel.CoursewareResCaseTimeIn] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.CoursewareResCaseTimeIn].ToString().Trim(); //案例入库时间(字段类型:char,字段长度:6,是否可空:True)
 objvCoursewareResCase_Resource_RelEN.OwnerId = objRow[convCoursewareResCase_Resource_Rel.OwnerId] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.OwnerId].ToString().Trim(); //拥有者Id(字段类型:varchar,字段长度:20,是否可空:False)
 objvCoursewareResCase_Resource_RelEN.OwnerName = objRow[convCoursewareResCase_Resource_Rel.OwnerName] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.OwnerName].ToString().Trim(); //拥有者姓名(字段类型:varchar,字段长度:30,是否可空:True)
 objvCoursewareResCase_Resource_RelEN.OwnerNameWithId = objRow[convCoursewareResCase_Resource_Rel.OwnerNameWithId] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id(字段类型:varchar,字段长度:51,是否可空:True)
 objvCoursewareResCase_Resource_RelEN.IdStudyLevel = objRow[convCoursewareResCase_Resource_Rel.IdStudyLevel] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.IdStudyLevel].ToString().Trim(); //id_StudyLevel(字段类型:char,字段长度:4,是否可空:True)
 objvCoursewareResCase_Resource_RelEN.StudyLevelName = objRow[convCoursewareResCase_Resource_Rel.StudyLevelName] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.StudyLevelName].ToString().Trim(); //学段名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvCoursewareResCase_Resource_RelEN.IdTeachingPlan = objRow[convCoursewareResCase_Resource_Rel.IdTeachingPlan] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.IdTeachingPlan].ToString().Trim(); //教案流水号(字段类型:char,字段长度:8,是否可空:False)
 objvCoursewareResCase_Resource_RelEN.IdDiscipline = objRow[convCoursewareResCase_Resource_Rel.IdDiscipline] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.IdDiscipline].ToString().Trim(); //学科流水号(字段类型:char,字段长度:4,是否可空:False)
 objvCoursewareResCase_Resource_RelEN.DisciplineID = objRow[convCoursewareResCase_Resource_Rel.DisciplineID] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.DisciplineID].ToString().Trim(); //学科ID(字段类型:char,字段长度:4,是否可空:False)
 objvCoursewareResCase_Resource_RelEN.DisciplineName = objRow[convCoursewareResCase_Resource_Rel.DisciplineName] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.DisciplineName].ToString().Trim(); //学科名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvCoursewareResCase_Resource_RelEN.senateGaugeVersionID = objRow[convCoursewareResCase_Resource_Rel.senateGaugeVersionID] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID(字段类型:char,字段长度:4,是否可空:False)
 objvCoursewareResCase_Resource_RelEN.senateGaugeVersionName = objRow[convCoursewareResCase_Resource_Rel.senateGaugeVersionName] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称(字段类型:varchar,字段长度:200,是否可空:True)
 objvCoursewareResCase_Resource_RelEN.senateGaugeVersionTtlScore = objRow[convCoursewareResCase_Resource_Rel.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convCoursewareResCase_Resource_Rel.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分(字段类型:float,字段长度:8,是否可空:False)
 objvCoursewareResCase_Resource_RelEN.VersionNo = objRow[convCoursewareResCase_Resource_Rel.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCoursewareResCase_Resource_Rel.VersionNo].ToString().Trim()); //版本号(字段类型:int,字段长度:4,是否可空:True)
 objvCoursewareResCase_Resource_RelEN.IdTeachSkill = objRow[convCoursewareResCase_Resource_Rel.IdTeachSkill] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.IdTeachSkill].ToString().Trim(); //教学技能流水号(字段类型:char,字段长度:8,是否可空:False)
 objvCoursewareResCase_Resource_RelEN.TeachSkillID = objRow[convCoursewareResCase_Resource_Rel.TeachSkillID] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.TeachSkillID].ToString().Trim(); //教学技能ID(字段类型:char,字段长度:8,是否可空:False)
 objvCoursewareResCase_Resource_RelEN.SkillTypeName = objRow[convCoursewareResCase_Resource_Rel.SkillTypeName] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.SkillTypeName].ToString().Trim(); //技能类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvCoursewareResCase_Resource_RelEN.TeachSkillName = objRow[convCoursewareResCase_Resource_Rel.TeachSkillName] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.TeachSkillName].ToString().Trim(); //教学技能名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvCoursewareResCase_Resource_RelEN.TeachSkillTheory = objRow[convCoursewareResCase_Resource_Rel.TeachSkillTheory] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述(字段类型:varchar,字段长度:8000,是否可空:True)
 objvCoursewareResCase_Resource_RelEN.TeachSkillOperMethod = objRow[convCoursewareResCase_Resource_Rel.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法(字段类型:varchar,字段长度:2000,是否可空:True)
 objvCoursewareResCase_Resource_RelEN.IdSkillType = objRow[convCoursewareResCase_Resource_Rel.IdSkillType] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.IdSkillType].ToString().Trim(); //技能类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvCoursewareResCase_Resource_RelEN.SkillTypeID = objRow[convCoursewareResCase_Resource_Rel.SkillTypeID] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.SkillTypeID].ToString().Trim(); //技能类型ID(字段类型:char,字段长度:4,是否可空:False)
 objvCoursewareResCase_Resource_RelEN.CaseLevelId = objRow[convCoursewareResCase_Resource_Rel.CaseLevelId] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.CaseLevelId].ToString().Trim(); //课例等级Id(字段类型:char,字段长度:2,是否可空:True)
 objvCoursewareResCase_Resource_RelEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convCoursewareResCase_Resource_Rel.IsDualVideo].ToString().Trim()); //是否双视频(字段类型:bit,字段长度:1,是否可空:False)
 objvCoursewareResCase_Resource_RelEN.IdXzCollege = objRow[convCoursewareResCase_Resource_Rel.IdXzCollege] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.IdXzCollege].ToString().Trim(); //学院流水号(字段类型:char,字段长度:4,是否可空:True)
 objvCoursewareResCase_Resource_RelEN.CollegeID = objRow[convCoursewareResCase_Resource_Rel.CollegeID] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.CollegeID].ToString().Trim(); //学院ID(字段类型:varchar,字段长度:4,是否可空:False)
 objvCoursewareResCase_Resource_RelEN.CollegeName = objRow[convCoursewareResCase_Resource_Rel.CollegeName] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.CollegeName].ToString().Trim(); //学院名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvCoursewareResCase_Resource_RelEN.IdXzMajor = objRow[convCoursewareResCase_Resource_Rel.IdXzMajor] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.IdXzMajor].ToString().Trim(); //专业流水号(字段类型:char,字段长度:8,是否可空:False)
 objvCoursewareResCase_Resource_RelEN.MajorID = objRow[convCoursewareResCase_Resource_Rel.MajorID] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.MajorID].ToString().Trim(); //专业ID(字段类型:char,字段长度:4,是否可空:False)
 objvCoursewareResCase_Resource_RelEN.MajorName = objRow[convCoursewareResCase_Resource_Rel.MajorName] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.MajorName].ToString().Trim(); //专业名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvCoursewareResCase_Resource_RelEN.CourseId = objRow[convCoursewareResCase_Resource_Rel.CourseId] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.CourseId].ToString().Trim(); //课程Id(字段类型:char,字段长度:8,是否可空:True)
 objvCoursewareResCase_Resource_RelEN.CourseCode = objRow[convCoursewareResCase_Resource_Rel.CourseCode] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.CourseCode].ToString().Trim(); //课程代码(字段类型:varchar,字段长度:20,是否可空:True)
 objvCoursewareResCase_Resource_RelEN.CourseName = objRow[convCoursewareResCase_Resource_Rel.CourseName] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.CourseName].ToString().Trim(); //课程名称(字段类型:varchar,字段长度:100,是否可空:True)
 objvCoursewareResCase_Resource_RelEN.CourseChapterId = objRow[convCoursewareResCase_Resource_Rel.CourseChapterId] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.CourseChapterId].ToString().Trim(); //课程章节ID(字段类型:char,字段长度:8,是否可空:False)
 objvCoursewareResCase_Resource_RelEN.CourseChapterName = objRow[convCoursewareResCase_Resource_Rel.CourseChapterName] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.CourseChapterName].ToString().Trim(); //课程章节名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvCoursewareResCase_Resource_RelEN.ParentNodeID = objRow[convCoursewareResCase_Resource_Rel.ParentNodeID] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.ParentNodeID].ToString().Trim(); //父节点编号(字段类型:varchar,字段长度:8,是否可空:True)
 objvCoursewareResCase_Resource_RelEN.ParentNodeName = objRow[convCoursewareResCase_Resource_Rel.ParentNodeName] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.ParentNodeName].ToString().Trim(); //父节点名称(字段类型:varchar,字段长度:50,是否可空:True)
 objvCoursewareResCase_Resource_RelEN.ViewCount = objRow[convCoursewareResCase_Resource_Rel.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCoursewareResCase_Resource_Rel.ViewCount].ToString().Trim()); //浏览量(字段类型:int,字段长度:4,是否可空:True)
 objvCoursewareResCase_Resource_RelEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[convCoursewareResCase_Resource_Rel.IsShow].ToString().Trim()); //是否启用(字段类型:bit,字段长度:1,是否可空:True)
 objvCoursewareResCase_Resource_RelEN.DownloadNumber = objRow[convCoursewareResCase_Resource_Rel.DownloadNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCoursewareResCase_Resource_Rel.DownloadNumber].ToString().Trim()); //下载数目(字段类型:int,字段长度:4,是否可空:True)
 objvCoursewareResCase_Resource_RelEN.FileIntegration = objRow[convCoursewareResCase_Resource_Rel.FileIntegration] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCoursewareResCase_Resource_Rel.FileIntegration].ToString().Trim()); //文件积分(字段类型:int,字段长度:4,是否可空:True)
 objvCoursewareResCase_Resource_RelEN.LikeCount = objRow[convCoursewareResCase_Resource_Rel.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convCoursewareResCase_Resource_Rel.LikeCount].ToString().Trim()); //资源喜欢数量(字段类型:bigint,字段长度:8,是否可空:True)
 objvCoursewareResCase_Resource_RelEN.CollectionCount = objRow[convCoursewareResCase_Resource_Rel.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convCoursewareResCase_Resource_Rel.CollectionCount].ToString().Trim()); //收藏数量(字段类型:bigint,字段长度:8,是否可空:True)
 objvCoursewareResCase_Resource_RelEN.RecommendedDegreeId = objRow[convCoursewareResCase_Resource_Rel.RecommendedDegreeId] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.RecommendedDegreeId].ToString().Trim(); //推荐度Id(字段类型:char,字段长度:2,是否可空:False)
 objvCoursewareResCase_Resource_RelEN.RecommendedDegreeName = objRow[convCoursewareResCase_Resource_Rel.RecommendedDegreeName] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.RecommendedDegreeName].ToString().Trim(); //推荐度名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvCoursewareResCase_Resource_RelEN.BrowseCount4Case = objRow[convCoursewareResCase_Resource_Rel.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCoursewareResCase_Resource_Rel.BrowseCount4Case].ToString().Trim()); //课例浏览次数(字段类型:int,字段长度:4,是否可空:True)
 objvCoursewareResCase_Resource_RelEN.CollegeNameA = objRow[convCoursewareResCase_Resource_Rel.CollegeNameA] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.CollegeNameA].ToString().Trim(); //学院名称简写(字段类型:varchar,字段长度:12,是否可空:True)
 objvCoursewareResCase_Resource_RelEN.IdResource = objRow[convCoursewareResCase_Resource_Rel.IdResource].ToString().Trim(); //资源流水号(字段类型:char,字段长度:8,是否可空:False)
 objvCoursewareResCase_Resource_RelEN.ResourceID = objRow[convCoursewareResCase_Resource_Rel.ResourceID] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.ResourceID].ToString().Trim(); //资源ID(字段类型:char,字段长度:8,是否可空:False)
 objvCoursewareResCase_Resource_RelEN.ResourceName = objRow[convCoursewareResCase_Resource_Rel.ResourceName] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.ResourceName].ToString().Trim(); //资源名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvCoursewareResCase_Resource_RelEN.IdFtpResource = objRow[convCoursewareResCase_Resource_Rel.IdFtpResource] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.IdFtpResource].ToString().Trim(); //FTP资源流水号(字段类型:char,字段长度:8,是否可空:True)
 objvCoursewareResCase_Resource_RelEN.IdFile = objRow[convCoursewareResCase_Resource_Rel.IdFile] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.IdFile].ToString().Trim(); //文件流水号(字段类型:char,字段长度:8,是否可空:True)
 objvCoursewareResCase_Resource_RelEN.FileName = objRow[convCoursewareResCase_Resource_Rel.FileName] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.FileName].ToString().Trim(); //文件名称(字段类型:varchar,字段长度:500,是否可空:True)
 objvCoursewareResCase_Resource_RelEN.FileType = objRow[convCoursewareResCase_Resource_Rel.FileType] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.FileType].ToString().Trim(); //文件类型(字段类型:varchar,字段长度:30,是否可空:True)
 objvCoursewareResCase_Resource_RelEN.SaveDate = objRow[convCoursewareResCase_Resource_Rel.SaveDate] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.SaveDate].ToString().Trim(); //创建日期(字段类型:char,字段长度:8,是否可空:True)
 objvCoursewareResCase_Resource_RelEN.FileSize = objRow[convCoursewareResCase_Resource_Rel.FileSize] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.FileSize].ToString().Trim(); //文件大小(字段类型:varchar,字段长度:50,是否可空:True)
 objvCoursewareResCase_Resource_RelEN.SaveTime = objRow[convCoursewareResCase_Resource_Rel.SaveTime] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.SaveTime].ToString().Trim(); //创建时间(字段类型:char,字段长度:6,是否可空:True)
 objvCoursewareResCase_Resource_RelEN.FtpResourceID = objRow[convCoursewareResCase_Resource_Rel.FtpResourceID] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.FtpResourceID].ToString().Trim(); //FTP资源ID(字段类型:char,字段长度:8,是否可空:False)
 objvCoursewareResCase_Resource_RelEN.FileOriginalName = objRow[convCoursewareResCase_Resource_Rel.FileOriginalName] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.FileOriginalName].ToString().Trim(); //文件原名(字段类型:varchar,字段长度:200,是否可空:True)
 objvCoursewareResCase_Resource_RelEN.FileDirName = objRow[convCoursewareResCase_Resource_Rel.FileDirName] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.FileDirName].ToString().Trim(); //文件目录名(字段类型:varchar,字段长度:200,是否可空:True)
 objvCoursewareResCase_Resource_RelEN.FileRename = objRow[convCoursewareResCase_Resource_Rel.FileRename] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.FileRename].ToString().Trim(); //文件新名(字段类型:varchar,字段长度:200,是否可空:True)
 objvCoursewareResCase_Resource_RelEN.FileUpDate = objRow[convCoursewareResCase_Resource_Rel.FileUpDate] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.FileUpDate].ToString().Trim(); //创建日期(字段类型:char,字段长度:8,是否可空:True)
 objvCoursewareResCase_Resource_RelEN.FileUpTime = objRow[convCoursewareResCase_Resource_Rel.FileUpTime] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.FileUpTime].ToString().Trim(); //创建时间(字段类型:char,字段长度:6,是否可空:True)
 objvCoursewareResCase_Resource_RelEN.SaveMode = clsEntityBase2.TransNullToBool_S(objRow[convCoursewareResCase_Resource_Rel.SaveMode].ToString().Trim()); //文件存放方式(字段类型:bit,字段长度:1,是否可空:True)
 objvCoursewareResCase_Resource_RelEN.IdResourceType = objRow[convCoursewareResCase_Resource_Rel.IdResourceType] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.IdResourceType].ToString().Trim(); //资源类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvCoursewareResCase_Resource_RelEN.ResourceTypeID = objRow[convCoursewareResCase_Resource_Rel.ResourceTypeID] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.ResourceTypeID].ToString().Trim(); //资源类型ID(字段类型:char,字段长度:4,是否可空:False)
 objvCoursewareResCase_Resource_RelEN.ResourceTypeName = objRow[convCoursewareResCase_Resource_Rel.ResourceTypeName] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.ResourceTypeName].ToString().Trim(); //资源类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvCoursewareResCase_Resource_RelEN.ResourceOwner = objRow[convCoursewareResCase_Resource_Rel.ResourceOwner] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.ResourceOwner].ToString().Trim(); //上传者(字段类型:varchar,字段长度:50,是否可空:False)
 objvCoursewareResCase_Resource_RelEN.ftpFileType = objRow[convCoursewareResCase_Resource_Rel.ftpFileType] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.ftpFileType].ToString().Trim(); //ftp文件类型(字段类型:varchar,字段长度:30,是否可空:True)
 objvCoursewareResCase_Resource_RelEN.ftpFileSize = objRow[convCoursewareResCase_Resource_Rel.ftpFileSize] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.ftpFileSize].ToString().Trim(); //ftp文件大小(字段类型:varchar,字段长度:50,是否可空:True)
 objvCoursewareResCase_Resource_RelEN.ftpResourceOwner = objRow[convCoursewareResCase_Resource_Rel.ftpResourceOwner] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者(字段类型:varchar,字段长度:50,是否可空:True)
 objvCoursewareResCase_Resource_RelEN.FileOriginName = objRow[convCoursewareResCase_Resource_Rel.FileOriginName] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.FileOriginName].ToString().Trim(); //原文件名(字段类型:varchar,字段长度:500,是否可空:True)
 objvCoursewareResCase_Resource_RelEN.IsExistFile = clsEntityBase2.TransNullToBool_S(objRow[convCoursewareResCase_Resource_Rel.IsExistFile].ToString().Trim()); //是否存在文件(字段类型:bit,字段长度:1,是否可空:True)
 objvCoursewareResCase_Resource_RelEN.FileNewName = objRow[convCoursewareResCase_Resource_Rel.FileNewName] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.FileNewName].ToString().Trim(); //新文件名(字段类型:varchar,字段长度:530,是否可空:True)
 objvCoursewareResCase_Resource_RelEN.FileOldName = objRow[convCoursewareResCase_Resource_Rel.FileOldName] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.FileOldName].ToString().Trim(); //旧文件名(字段类型:varchar,字段长度:530,是否可空:True)
 objvCoursewareResCase_Resource_RelEN.IsMain = clsEntityBase2.TransNullToBool_S(objRow[convCoursewareResCase_Resource_Rel.IsMain].ToString().Trim()); //是否主资源(字段类型:bit,字段长度:1,是否可空:True)
 objvCoursewareResCase_Resource_RelEN.IdUsingMode = objRow[convCoursewareResCase_Resource_Rel.IdUsingMode] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.IdUsingMode].ToString().Trim(); //资源使用模式流水号(字段类型:char,字段长度:4,是否可空:False)
 objvCoursewareResCase_Resource_RelEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convCoursewareResCase_Resource_Rel.IsVisible].ToString().Trim()); //是否显示(字段类型:bit,字段长度:1,是否可空:True)
 objvCoursewareResCase_Resource_RelEN.IndexNO = objRow[convCoursewareResCase_Resource_Rel.IndexNO] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCoursewareResCase_Resource_Rel.IndexNO].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:True)
 objvCoursewareResCase_Resource_RelEN.BrowseCount = objRow[convCoursewareResCase_Resource_Rel.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCoursewareResCase_Resource_Rel.BrowseCount].ToString().Trim()); //浏览次数(字段类型:int,字段长度:4,是否可空:True)
 objvCoursewareResCase_Resource_RelEN.UpdDate = objRow[convCoursewareResCase_Resource_Rel.UpdDate] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvCoursewareResCase_Resource_RelEN.UpdUser = objRow[convCoursewareResCase_Resource_Rel.UpdUser] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objvCoursewareResCase_Resource_RelEN.Memo = objRow[convCoursewareResCase_Resource_Rel.Memo] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvCoursewareResCase_Resource_RelDA: GetObjByIdMicroteachCaseResourceRel)", objException.Message));
}
return objvCoursewareResCase_Resource_RelEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvCoursewareResCase_Resource_RelEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvCoursewareResCase_Resource_RelDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCoursewareResCase_Resource_RelDA.GetSpecSQLObj();
strSQL = "Select * from vCoursewareResCase_Resource_Rel where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvCoursewareResCase_Resource_RelEN objvCoursewareResCase_Resource_RelEN = new clsvCoursewareResCase_Resource_RelEN()
{
IdMicroteachCaseResourceRel = TransNullToInt(objRow[convCoursewareResCase_Resource_Rel.IdMicroteachCaseResourceRel].ToString().Trim()), //微格案例资源关系流水号
FuncModuleId = objRow[convCoursewareResCase_Resource_Rel.FuncModuleId].ToString().Trim(), //功能模块Id
FuncModuleName = objRow[convCoursewareResCase_Resource_Rel.FuncModuleName] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.FuncModuleName].ToString().Trim(), //功能模块名称
IdMicroteachCase = objRow[convCoursewareResCase_Resource_Rel.IdMicroteachCase].ToString().Trim(), //微格教学案例流水号
CoursewareResCaseID = objRow[convCoursewareResCase_Resource_Rel.CoursewareResCaseID] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.CoursewareResCaseID].ToString().Trim(), //课件资源案例ID
CoursewareResCaseName = objRow[convCoursewareResCase_Resource_Rel.CoursewareResCaseName] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.CoursewareResCaseName].ToString().Trim(), //课件资源案例名称
CoursewareResCaseTheme = objRow[convCoursewareResCase_Resource_Rel.CoursewareResCaseTheme] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.CoursewareResCaseTheme].ToString().Trim(), //课件资源案例主题词
CoursewareResCaseText = objRow[convCoursewareResCase_Resource_Rel.CoursewareResCaseText] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.CoursewareResCaseText].ToString().Trim(), //案例文本内容
IdCoursewareResCaseType = objRow[convCoursewareResCase_Resource_Rel.IdCoursewareResCaseType] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.IdCoursewareResCaseType].ToString().Trim(), //课件资源类型流水号
CoursewareResCaseTypeName = objRow[convCoursewareResCase_Resource_Rel.CoursewareResCaseTypeName] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.CoursewareResCaseTypeName].ToString().Trim(), //课件资源案例类型名称
CoursewareResCaseDate = objRow[convCoursewareResCase_Resource_Rel.CoursewareResCaseDate] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.CoursewareResCaseDate].ToString().Trim(), //视频资源日期
CoursewareResCaseTime = objRow[convCoursewareResCase_Resource_Rel.CoursewareResCaseTime] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.CoursewareResCaseTime].ToString().Trim(), //视频资源时间
CoursewareResCaseDateIn = objRow[convCoursewareResCase_Resource_Rel.CoursewareResCaseDateIn] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.CoursewareResCaseDateIn].ToString().Trim(), //案例入库日期
CoursewareResCaseTimeIn = objRow[convCoursewareResCase_Resource_Rel.CoursewareResCaseTimeIn] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.CoursewareResCaseTimeIn].ToString().Trim(), //案例入库时间
OwnerId = objRow[convCoursewareResCase_Resource_Rel.OwnerId] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.OwnerId].ToString().Trim(), //拥有者Id
OwnerName = objRow[convCoursewareResCase_Resource_Rel.OwnerName] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.OwnerName].ToString().Trim(), //拥有者姓名
OwnerNameWithId = objRow[convCoursewareResCase_Resource_Rel.OwnerNameWithId] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.OwnerNameWithId].ToString().Trim(), //拥有者名称附Id
IdStudyLevel = objRow[convCoursewareResCase_Resource_Rel.IdStudyLevel] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.IdStudyLevel].ToString().Trim(), //id_StudyLevel
StudyLevelName = objRow[convCoursewareResCase_Resource_Rel.StudyLevelName] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.StudyLevelName].ToString().Trim(), //学段名称
IdTeachingPlan = objRow[convCoursewareResCase_Resource_Rel.IdTeachingPlan] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.IdTeachingPlan].ToString().Trim(), //教案流水号
IdDiscipline = objRow[convCoursewareResCase_Resource_Rel.IdDiscipline] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.IdDiscipline].ToString().Trim(), //学科流水号
DisciplineID = objRow[convCoursewareResCase_Resource_Rel.DisciplineID] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.DisciplineID].ToString().Trim(), //学科ID
DisciplineName = objRow[convCoursewareResCase_Resource_Rel.DisciplineName] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.DisciplineName].ToString().Trim(), //学科名称
senateGaugeVersionID = objRow[convCoursewareResCase_Resource_Rel.senateGaugeVersionID] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.senateGaugeVersionID].ToString().Trim(), //评价量表版本ID
senateGaugeVersionName = objRow[convCoursewareResCase_Resource_Rel.senateGaugeVersionName] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.senateGaugeVersionName].ToString().Trim(), //评价量表版本名称
senateGaugeVersionTtlScore = objRow[convCoursewareResCase_Resource_Rel.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convCoursewareResCase_Resource_Rel.senateGaugeVersionTtlScore].ToString().Trim()), //评价量表版本总分
VersionNo = objRow[convCoursewareResCase_Resource_Rel.VersionNo] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCoursewareResCase_Resource_Rel.VersionNo].ToString().Trim()), //版本号
IdTeachSkill = objRow[convCoursewareResCase_Resource_Rel.IdTeachSkill] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.IdTeachSkill].ToString().Trim(), //教学技能流水号
TeachSkillID = objRow[convCoursewareResCase_Resource_Rel.TeachSkillID] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.TeachSkillID].ToString().Trim(), //教学技能ID
SkillTypeName = objRow[convCoursewareResCase_Resource_Rel.SkillTypeName] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.SkillTypeName].ToString().Trim(), //技能类型名称
TeachSkillName = objRow[convCoursewareResCase_Resource_Rel.TeachSkillName] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.TeachSkillName].ToString().Trim(), //教学技能名称
TeachSkillTheory = objRow[convCoursewareResCase_Resource_Rel.TeachSkillTheory] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.TeachSkillTheory].ToString().Trim(), //教学技能理论阐述
TeachSkillOperMethod = objRow[convCoursewareResCase_Resource_Rel.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.TeachSkillOperMethod].ToString().Trim(), //教学技能实践操作方法
IdSkillType = objRow[convCoursewareResCase_Resource_Rel.IdSkillType] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.IdSkillType].ToString().Trim(), //技能类型流水号
SkillTypeID = objRow[convCoursewareResCase_Resource_Rel.SkillTypeID] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.SkillTypeID].ToString().Trim(), //技能类型ID
CaseLevelId = objRow[convCoursewareResCase_Resource_Rel.CaseLevelId] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.CaseLevelId].ToString().Trim(), //课例等级Id
IsDualVideo = TransNullToBool(objRow[convCoursewareResCase_Resource_Rel.IsDualVideo].ToString().Trim()), //是否双视频
IdXzCollege = objRow[convCoursewareResCase_Resource_Rel.IdXzCollege] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.IdXzCollege].ToString().Trim(), //学院流水号
CollegeID = objRow[convCoursewareResCase_Resource_Rel.CollegeID] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.CollegeID].ToString().Trim(), //学院ID
CollegeName = objRow[convCoursewareResCase_Resource_Rel.CollegeName] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.CollegeName].ToString().Trim(), //学院名称
IdXzMajor = objRow[convCoursewareResCase_Resource_Rel.IdXzMajor] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.IdXzMajor].ToString().Trim(), //专业流水号
MajorID = objRow[convCoursewareResCase_Resource_Rel.MajorID] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.MajorID].ToString().Trim(), //专业ID
MajorName = objRow[convCoursewareResCase_Resource_Rel.MajorName] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.MajorName].ToString().Trim(), //专业名称
CourseId = objRow[convCoursewareResCase_Resource_Rel.CourseId] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.CourseId].ToString().Trim(), //课程Id
CourseCode = objRow[convCoursewareResCase_Resource_Rel.CourseCode] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.CourseCode].ToString().Trim(), //课程代码
CourseName = objRow[convCoursewareResCase_Resource_Rel.CourseName] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.CourseName].ToString().Trim(), //课程名称
CourseChapterId = objRow[convCoursewareResCase_Resource_Rel.CourseChapterId] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.CourseChapterId].ToString().Trim(), //课程章节ID
CourseChapterName = objRow[convCoursewareResCase_Resource_Rel.CourseChapterName] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.CourseChapterName].ToString().Trim(), //课程章节名称
ParentNodeID = objRow[convCoursewareResCase_Resource_Rel.ParentNodeID] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.ParentNodeID].ToString().Trim(), //父节点编号
ParentNodeName = objRow[convCoursewareResCase_Resource_Rel.ParentNodeName] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.ParentNodeName].ToString().Trim(), //父节点名称
ViewCount = objRow[convCoursewareResCase_Resource_Rel.ViewCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCoursewareResCase_Resource_Rel.ViewCount].ToString().Trim()), //浏览量
IsShow = TransNullToBool(objRow[convCoursewareResCase_Resource_Rel.IsShow].ToString().Trim()), //是否启用
DownloadNumber = objRow[convCoursewareResCase_Resource_Rel.DownloadNumber] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCoursewareResCase_Resource_Rel.DownloadNumber].ToString().Trim()), //下载数目
FileIntegration = objRow[convCoursewareResCase_Resource_Rel.FileIntegration] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCoursewareResCase_Resource_Rel.FileIntegration].ToString().Trim()), //文件积分
LikeCount = objRow[convCoursewareResCase_Resource_Rel.LikeCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convCoursewareResCase_Resource_Rel.LikeCount].ToString().Trim()), //资源喜欢数量
CollectionCount = objRow[convCoursewareResCase_Resource_Rel.CollectionCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convCoursewareResCase_Resource_Rel.CollectionCount].ToString().Trim()), //收藏数量
RecommendedDegreeId = objRow[convCoursewareResCase_Resource_Rel.RecommendedDegreeId] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.RecommendedDegreeId].ToString().Trim(), //推荐度Id
RecommendedDegreeName = objRow[convCoursewareResCase_Resource_Rel.RecommendedDegreeName] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.RecommendedDegreeName].ToString().Trim(), //推荐度名称
BrowseCount4Case = objRow[convCoursewareResCase_Resource_Rel.BrowseCount4Case] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCoursewareResCase_Resource_Rel.BrowseCount4Case].ToString().Trim()), //课例浏览次数
CollegeNameA = objRow[convCoursewareResCase_Resource_Rel.CollegeNameA] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.CollegeNameA].ToString().Trim(), //学院名称简写
IdResource = objRow[convCoursewareResCase_Resource_Rel.IdResource].ToString().Trim(), //资源流水号
ResourceID = objRow[convCoursewareResCase_Resource_Rel.ResourceID] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.ResourceID].ToString().Trim(), //资源ID
ResourceName = objRow[convCoursewareResCase_Resource_Rel.ResourceName] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.ResourceName].ToString().Trim(), //资源名称
IdFtpResource = objRow[convCoursewareResCase_Resource_Rel.IdFtpResource] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.IdFtpResource].ToString().Trim(), //FTP资源流水号
IdFile = objRow[convCoursewareResCase_Resource_Rel.IdFile] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.IdFile].ToString().Trim(), //文件流水号
FileName = objRow[convCoursewareResCase_Resource_Rel.FileName] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.FileName].ToString().Trim(), //文件名称
FileType = objRow[convCoursewareResCase_Resource_Rel.FileType] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.FileType].ToString().Trim(), //文件类型
SaveDate = objRow[convCoursewareResCase_Resource_Rel.SaveDate] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.SaveDate].ToString().Trim(), //创建日期
FileSize = objRow[convCoursewareResCase_Resource_Rel.FileSize] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.FileSize].ToString().Trim(), //文件大小
SaveTime = objRow[convCoursewareResCase_Resource_Rel.SaveTime] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.SaveTime].ToString().Trim(), //创建时间
FtpResourceID = objRow[convCoursewareResCase_Resource_Rel.FtpResourceID] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.FtpResourceID].ToString().Trim(), //FTP资源ID
FileOriginalName = objRow[convCoursewareResCase_Resource_Rel.FileOriginalName] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.FileOriginalName].ToString().Trim(), //文件原名
FileDirName = objRow[convCoursewareResCase_Resource_Rel.FileDirName] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.FileDirName].ToString().Trim(), //文件目录名
FileRename = objRow[convCoursewareResCase_Resource_Rel.FileRename] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.FileRename].ToString().Trim(), //文件新名
FileUpDate = objRow[convCoursewareResCase_Resource_Rel.FileUpDate] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.FileUpDate].ToString().Trim(), //创建日期
FileUpTime = objRow[convCoursewareResCase_Resource_Rel.FileUpTime] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.FileUpTime].ToString().Trim(), //创建时间
SaveMode = TransNullToBool(objRow[convCoursewareResCase_Resource_Rel.SaveMode].ToString().Trim()), //文件存放方式
IdResourceType = objRow[convCoursewareResCase_Resource_Rel.IdResourceType] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.IdResourceType].ToString().Trim(), //资源类型流水号
ResourceTypeID = objRow[convCoursewareResCase_Resource_Rel.ResourceTypeID] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.ResourceTypeID].ToString().Trim(), //资源类型ID
ResourceTypeName = objRow[convCoursewareResCase_Resource_Rel.ResourceTypeName] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.ResourceTypeName].ToString().Trim(), //资源类型名称
ResourceOwner = objRow[convCoursewareResCase_Resource_Rel.ResourceOwner] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.ResourceOwner].ToString().Trim(), //上传者
ftpFileType = objRow[convCoursewareResCase_Resource_Rel.ftpFileType] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.ftpFileType].ToString().Trim(), //ftp文件类型
ftpFileSize = objRow[convCoursewareResCase_Resource_Rel.ftpFileSize] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.ftpFileSize].ToString().Trim(), //ftp文件大小
ftpResourceOwner = objRow[convCoursewareResCase_Resource_Rel.ftpResourceOwner] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.ftpResourceOwner].ToString().Trim(), //Ftp资源拥有者
FileOriginName = objRow[convCoursewareResCase_Resource_Rel.FileOriginName] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.FileOriginName].ToString().Trim(), //原文件名
IsExistFile = TransNullToBool(objRow[convCoursewareResCase_Resource_Rel.IsExistFile].ToString().Trim()), //是否存在文件
FileNewName = objRow[convCoursewareResCase_Resource_Rel.FileNewName] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.FileNewName].ToString().Trim(), //新文件名
FileOldName = objRow[convCoursewareResCase_Resource_Rel.FileOldName] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.FileOldName].ToString().Trim(), //旧文件名
IsMain = TransNullToBool(objRow[convCoursewareResCase_Resource_Rel.IsMain].ToString().Trim()), //是否主资源
IdUsingMode = objRow[convCoursewareResCase_Resource_Rel.IdUsingMode] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.IdUsingMode].ToString().Trim(), //资源使用模式流水号
IsVisible = TransNullToBool(objRow[convCoursewareResCase_Resource_Rel.IsVisible].ToString().Trim()), //是否显示
IndexNO = objRow[convCoursewareResCase_Resource_Rel.IndexNO] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCoursewareResCase_Resource_Rel.IndexNO].ToString().Trim()), //序号
BrowseCount = objRow[convCoursewareResCase_Resource_Rel.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCoursewareResCase_Resource_Rel.BrowseCount].ToString().Trim()), //浏览次数
UpdDate = objRow[convCoursewareResCase_Resource_Rel.UpdDate] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[convCoursewareResCase_Resource_Rel.UpdUser] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.UpdUser].ToString().Trim(), //修改人
Memo = objRow[convCoursewareResCase_Resource_Rel.Memo] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.Memo].ToString().Trim() //备注
};
objvCoursewareResCase_Resource_RelEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvCoursewareResCase_Resource_RelEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvCoursewareResCase_Resource_RelDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvCoursewareResCase_Resource_RelEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvCoursewareResCase_Resource_RelEN objvCoursewareResCase_Resource_RelEN = new clsvCoursewareResCase_Resource_RelEN();
try
{
objvCoursewareResCase_Resource_RelEN.IdMicroteachCaseResourceRel = TransNullToInt(objRow[convCoursewareResCase_Resource_Rel.IdMicroteachCaseResourceRel].ToString().Trim()); //微格案例资源关系流水号
objvCoursewareResCase_Resource_RelEN.FuncModuleId = objRow[convCoursewareResCase_Resource_Rel.FuncModuleId].ToString().Trim(); //功能模块Id
objvCoursewareResCase_Resource_RelEN.FuncModuleName = objRow[convCoursewareResCase_Resource_Rel.FuncModuleName] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.FuncModuleName].ToString().Trim(); //功能模块名称
objvCoursewareResCase_Resource_RelEN.IdMicroteachCase = objRow[convCoursewareResCase_Resource_Rel.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvCoursewareResCase_Resource_RelEN.CoursewareResCaseID = objRow[convCoursewareResCase_Resource_Rel.CoursewareResCaseID] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.CoursewareResCaseID].ToString().Trim(); //课件资源案例ID
objvCoursewareResCase_Resource_RelEN.CoursewareResCaseName = objRow[convCoursewareResCase_Resource_Rel.CoursewareResCaseName] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.CoursewareResCaseName].ToString().Trim(); //课件资源案例名称
objvCoursewareResCase_Resource_RelEN.CoursewareResCaseTheme = objRow[convCoursewareResCase_Resource_Rel.CoursewareResCaseTheme] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.CoursewareResCaseTheme].ToString().Trim(); //课件资源案例主题词
objvCoursewareResCase_Resource_RelEN.CoursewareResCaseText = objRow[convCoursewareResCase_Resource_Rel.CoursewareResCaseText] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.CoursewareResCaseText].ToString().Trim(); //案例文本内容
objvCoursewareResCase_Resource_RelEN.IdCoursewareResCaseType = objRow[convCoursewareResCase_Resource_Rel.IdCoursewareResCaseType] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.IdCoursewareResCaseType].ToString().Trim(); //课件资源类型流水号
objvCoursewareResCase_Resource_RelEN.CoursewareResCaseTypeName = objRow[convCoursewareResCase_Resource_Rel.CoursewareResCaseTypeName] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.CoursewareResCaseTypeName].ToString().Trim(); //课件资源案例类型名称
objvCoursewareResCase_Resource_RelEN.CoursewareResCaseDate = objRow[convCoursewareResCase_Resource_Rel.CoursewareResCaseDate] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.CoursewareResCaseDate].ToString().Trim(); //视频资源日期
objvCoursewareResCase_Resource_RelEN.CoursewareResCaseTime = objRow[convCoursewareResCase_Resource_Rel.CoursewareResCaseTime] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.CoursewareResCaseTime].ToString().Trim(); //视频资源时间
objvCoursewareResCase_Resource_RelEN.CoursewareResCaseDateIn = objRow[convCoursewareResCase_Resource_Rel.CoursewareResCaseDateIn] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.CoursewareResCaseDateIn].ToString().Trim(); //案例入库日期
objvCoursewareResCase_Resource_RelEN.CoursewareResCaseTimeIn = objRow[convCoursewareResCase_Resource_Rel.CoursewareResCaseTimeIn] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.CoursewareResCaseTimeIn].ToString().Trim(); //案例入库时间
objvCoursewareResCase_Resource_RelEN.OwnerId = objRow[convCoursewareResCase_Resource_Rel.OwnerId] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.OwnerId].ToString().Trim(); //拥有者Id
objvCoursewareResCase_Resource_RelEN.OwnerName = objRow[convCoursewareResCase_Resource_Rel.OwnerName] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.OwnerName].ToString().Trim(); //拥有者姓名
objvCoursewareResCase_Resource_RelEN.OwnerNameWithId = objRow[convCoursewareResCase_Resource_Rel.OwnerNameWithId] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvCoursewareResCase_Resource_RelEN.IdStudyLevel = objRow[convCoursewareResCase_Resource_Rel.IdStudyLevel] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvCoursewareResCase_Resource_RelEN.StudyLevelName = objRow[convCoursewareResCase_Resource_Rel.StudyLevelName] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.StudyLevelName].ToString().Trim(); //学段名称
objvCoursewareResCase_Resource_RelEN.IdTeachingPlan = objRow[convCoursewareResCase_Resource_Rel.IdTeachingPlan] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.IdTeachingPlan].ToString().Trim(); //教案流水号
objvCoursewareResCase_Resource_RelEN.IdDiscipline = objRow[convCoursewareResCase_Resource_Rel.IdDiscipline] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.IdDiscipline].ToString().Trim(); //学科流水号
objvCoursewareResCase_Resource_RelEN.DisciplineID = objRow[convCoursewareResCase_Resource_Rel.DisciplineID] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.DisciplineID].ToString().Trim(); //学科ID
objvCoursewareResCase_Resource_RelEN.DisciplineName = objRow[convCoursewareResCase_Resource_Rel.DisciplineName] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.DisciplineName].ToString().Trim(); //学科名称
objvCoursewareResCase_Resource_RelEN.senateGaugeVersionID = objRow[convCoursewareResCase_Resource_Rel.senateGaugeVersionID] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvCoursewareResCase_Resource_RelEN.senateGaugeVersionName = objRow[convCoursewareResCase_Resource_Rel.senateGaugeVersionName] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvCoursewareResCase_Resource_RelEN.senateGaugeVersionTtlScore = objRow[convCoursewareResCase_Resource_Rel.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convCoursewareResCase_Resource_Rel.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvCoursewareResCase_Resource_RelEN.VersionNo = objRow[convCoursewareResCase_Resource_Rel.VersionNo] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCoursewareResCase_Resource_Rel.VersionNo].ToString().Trim()); //版本号
objvCoursewareResCase_Resource_RelEN.IdTeachSkill = objRow[convCoursewareResCase_Resource_Rel.IdTeachSkill] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvCoursewareResCase_Resource_RelEN.TeachSkillID = objRow[convCoursewareResCase_Resource_Rel.TeachSkillID] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.TeachSkillID].ToString().Trim(); //教学技能ID
objvCoursewareResCase_Resource_RelEN.SkillTypeName = objRow[convCoursewareResCase_Resource_Rel.SkillTypeName] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.SkillTypeName].ToString().Trim(); //技能类型名称
objvCoursewareResCase_Resource_RelEN.TeachSkillName = objRow[convCoursewareResCase_Resource_Rel.TeachSkillName] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.TeachSkillName].ToString().Trim(); //教学技能名称
objvCoursewareResCase_Resource_RelEN.TeachSkillTheory = objRow[convCoursewareResCase_Resource_Rel.TeachSkillTheory] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvCoursewareResCase_Resource_RelEN.TeachSkillOperMethod = objRow[convCoursewareResCase_Resource_Rel.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvCoursewareResCase_Resource_RelEN.IdSkillType = objRow[convCoursewareResCase_Resource_Rel.IdSkillType] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.IdSkillType].ToString().Trim(); //技能类型流水号
objvCoursewareResCase_Resource_RelEN.SkillTypeID = objRow[convCoursewareResCase_Resource_Rel.SkillTypeID] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.SkillTypeID].ToString().Trim(); //技能类型ID
objvCoursewareResCase_Resource_RelEN.CaseLevelId = objRow[convCoursewareResCase_Resource_Rel.CaseLevelId] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.CaseLevelId].ToString().Trim(); //课例等级Id
objvCoursewareResCase_Resource_RelEN.IsDualVideo = TransNullToBool(objRow[convCoursewareResCase_Resource_Rel.IsDualVideo].ToString().Trim()); //是否双视频
objvCoursewareResCase_Resource_RelEN.IdXzCollege = objRow[convCoursewareResCase_Resource_Rel.IdXzCollege] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.IdXzCollege].ToString().Trim(); //学院流水号
objvCoursewareResCase_Resource_RelEN.CollegeID = objRow[convCoursewareResCase_Resource_Rel.CollegeID] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.CollegeID].ToString().Trim(); //学院ID
objvCoursewareResCase_Resource_RelEN.CollegeName = objRow[convCoursewareResCase_Resource_Rel.CollegeName] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.CollegeName].ToString().Trim(); //学院名称
objvCoursewareResCase_Resource_RelEN.IdXzMajor = objRow[convCoursewareResCase_Resource_Rel.IdXzMajor] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.IdXzMajor].ToString().Trim(); //专业流水号
objvCoursewareResCase_Resource_RelEN.MajorID = objRow[convCoursewareResCase_Resource_Rel.MajorID] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.MajorID].ToString().Trim(); //专业ID
objvCoursewareResCase_Resource_RelEN.MajorName = objRow[convCoursewareResCase_Resource_Rel.MajorName] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.MajorName].ToString().Trim(); //专业名称
objvCoursewareResCase_Resource_RelEN.CourseId = objRow[convCoursewareResCase_Resource_Rel.CourseId] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.CourseId].ToString().Trim(); //课程Id
objvCoursewareResCase_Resource_RelEN.CourseCode = objRow[convCoursewareResCase_Resource_Rel.CourseCode] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.CourseCode].ToString().Trim(); //课程代码
objvCoursewareResCase_Resource_RelEN.CourseName = objRow[convCoursewareResCase_Resource_Rel.CourseName] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.CourseName].ToString().Trim(); //课程名称
objvCoursewareResCase_Resource_RelEN.CourseChapterId = objRow[convCoursewareResCase_Resource_Rel.CourseChapterId] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.CourseChapterId].ToString().Trim(); //课程章节ID
objvCoursewareResCase_Resource_RelEN.CourseChapterName = objRow[convCoursewareResCase_Resource_Rel.CourseChapterName] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.CourseChapterName].ToString().Trim(); //课程章节名称
objvCoursewareResCase_Resource_RelEN.ParentNodeID = objRow[convCoursewareResCase_Resource_Rel.ParentNodeID] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.ParentNodeID].ToString().Trim(); //父节点编号
objvCoursewareResCase_Resource_RelEN.ParentNodeName = objRow[convCoursewareResCase_Resource_Rel.ParentNodeName] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.ParentNodeName].ToString().Trim(); //父节点名称
objvCoursewareResCase_Resource_RelEN.ViewCount = objRow[convCoursewareResCase_Resource_Rel.ViewCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCoursewareResCase_Resource_Rel.ViewCount].ToString().Trim()); //浏览量
objvCoursewareResCase_Resource_RelEN.IsShow = TransNullToBool(objRow[convCoursewareResCase_Resource_Rel.IsShow].ToString().Trim()); //是否启用
objvCoursewareResCase_Resource_RelEN.DownloadNumber = objRow[convCoursewareResCase_Resource_Rel.DownloadNumber] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCoursewareResCase_Resource_Rel.DownloadNumber].ToString().Trim()); //下载数目
objvCoursewareResCase_Resource_RelEN.FileIntegration = objRow[convCoursewareResCase_Resource_Rel.FileIntegration] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCoursewareResCase_Resource_Rel.FileIntegration].ToString().Trim()); //文件积分
objvCoursewareResCase_Resource_RelEN.LikeCount = objRow[convCoursewareResCase_Resource_Rel.LikeCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convCoursewareResCase_Resource_Rel.LikeCount].ToString().Trim()); //资源喜欢数量
objvCoursewareResCase_Resource_RelEN.CollectionCount = objRow[convCoursewareResCase_Resource_Rel.CollectionCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convCoursewareResCase_Resource_Rel.CollectionCount].ToString().Trim()); //收藏数量
objvCoursewareResCase_Resource_RelEN.RecommendedDegreeId = objRow[convCoursewareResCase_Resource_Rel.RecommendedDegreeId] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvCoursewareResCase_Resource_RelEN.RecommendedDegreeName = objRow[convCoursewareResCase_Resource_Rel.RecommendedDegreeName] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvCoursewareResCase_Resource_RelEN.BrowseCount4Case = objRow[convCoursewareResCase_Resource_Rel.BrowseCount4Case] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCoursewareResCase_Resource_Rel.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvCoursewareResCase_Resource_RelEN.CollegeNameA = objRow[convCoursewareResCase_Resource_Rel.CollegeNameA] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.CollegeNameA].ToString().Trim(); //学院名称简写
objvCoursewareResCase_Resource_RelEN.IdResource = objRow[convCoursewareResCase_Resource_Rel.IdResource].ToString().Trim(); //资源流水号
objvCoursewareResCase_Resource_RelEN.ResourceID = objRow[convCoursewareResCase_Resource_Rel.ResourceID] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.ResourceID].ToString().Trim(); //资源ID
objvCoursewareResCase_Resource_RelEN.ResourceName = objRow[convCoursewareResCase_Resource_Rel.ResourceName] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.ResourceName].ToString().Trim(); //资源名称
objvCoursewareResCase_Resource_RelEN.IdFtpResource = objRow[convCoursewareResCase_Resource_Rel.IdFtpResource] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvCoursewareResCase_Resource_RelEN.IdFile = objRow[convCoursewareResCase_Resource_Rel.IdFile] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.IdFile].ToString().Trim(); //文件流水号
objvCoursewareResCase_Resource_RelEN.FileName = objRow[convCoursewareResCase_Resource_Rel.FileName] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.FileName].ToString().Trim(); //文件名称
objvCoursewareResCase_Resource_RelEN.FileType = objRow[convCoursewareResCase_Resource_Rel.FileType] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.FileType].ToString().Trim(); //文件类型
objvCoursewareResCase_Resource_RelEN.SaveDate = objRow[convCoursewareResCase_Resource_Rel.SaveDate] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.SaveDate].ToString().Trim(); //创建日期
objvCoursewareResCase_Resource_RelEN.FileSize = objRow[convCoursewareResCase_Resource_Rel.FileSize] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.FileSize].ToString().Trim(); //文件大小
objvCoursewareResCase_Resource_RelEN.SaveTime = objRow[convCoursewareResCase_Resource_Rel.SaveTime] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.SaveTime].ToString().Trim(); //创建时间
objvCoursewareResCase_Resource_RelEN.FtpResourceID = objRow[convCoursewareResCase_Resource_Rel.FtpResourceID] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.FtpResourceID].ToString().Trim(); //FTP资源ID
objvCoursewareResCase_Resource_RelEN.FileOriginalName = objRow[convCoursewareResCase_Resource_Rel.FileOriginalName] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.FileOriginalName].ToString().Trim(); //文件原名
objvCoursewareResCase_Resource_RelEN.FileDirName = objRow[convCoursewareResCase_Resource_Rel.FileDirName] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.FileDirName].ToString().Trim(); //文件目录名
objvCoursewareResCase_Resource_RelEN.FileRename = objRow[convCoursewareResCase_Resource_Rel.FileRename] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.FileRename].ToString().Trim(); //文件新名
objvCoursewareResCase_Resource_RelEN.FileUpDate = objRow[convCoursewareResCase_Resource_Rel.FileUpDate] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.FileUpDate].ToString().Trim(); //创建日期
objvCoursewareResCase_Resource_RelEN.FileUpTime = objRow[convCoursewareResCase_Resource_Rel.FileUpTime] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.FileUpTime].ToString().Trim(); //创建时间
objvCoursewareResCase_Resource_RelEN.SaveMode = TransNullToBool(objRow[convCoursewareResCase_Resource_Rel.SaveMode].ToString().Trim()); //文件存放方式
objvCoursewareResCase_Resource_RelEN.IdResourceType = objRow[convCoursewareResCase_Resource_Rel.IdResourceType] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.IdResourceType].ToString().Trim(); //资源类型流水号
objvCoursewareResCase_Resource_RelEN.ResourceTypeID = objRow[convCoursewareResCase_Resource_Rel.ResourceTypeID] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.ResourceTypeID].ToString().Trim(); //资源类型ID
objvCoursewareResCase_Resource_RelEN.ResourceTypeName = objRow[convCoursewareResCase_Resource_Rel.ResourceTypeName] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.ResourceTypeName].ToString().Trim(); //资源类型名称
objvCoursewareResCase_Resource_RelEN.ResourceOwner = objRow[convCoursewareResCase_Resource_Rel.ResourceOwner] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.ResourceOwner].ToString().Trim(); //上传者
objvCoursewareResCase_Resource_RelEN.ftpFileType = objRow[convCoursewareResCase_Resource_Rel.ftpFileType] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.ftpFileType].ToString().Trim(); //ftp文件类型
objvCoursewareResCase_Resource_RelEN.ftpFileSize = objRow[convCoursewareResCase_Resource_Rel.ftpFileSize] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.ftpFileSize].ToString().Trim(); //ftp文件大小
objvCoursewareResCase_Resource_RelEN.ftpResourceOwner = objRow[convCoursewareResCase_Resource_Rel.ftpResourceOwner] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvCoursewareResCase_Resource_RelEN.FileOriginName = objRow[convCoursewareResCase_Resource_Rel.FileOriginName] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.FileOriginName].ToString().Trim(); //原文件名
objvCoursewareResCase_Resource_RelEN.IsExistFile = TransNullToBool(objRow[convCoursewareResCase_Resource_Rel.IsExistFile].ToString().Trim()); //是否存在文件
objvCoursewareResCase_Resource_RelEN.FileNewName = objRow[convCoursewareResCase_Resource_Rel.FileNewName] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.FileNewName].ToString().Trim(); //新文件名
objvCoursewareResCase_Resource_RelEN.FileOldName = objRow[convCoursewareResCase_Resource_Rel.FileOldName] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.FileOldName].ToString().Trim(); //旧文件名
objvCoursewareResCase_Resource_RelEN.IsMain = TransNullToBool(objRow[convCoursewareResCase_Resource_Rel.IsMain].ToString().Trim()); //是否主资源
objvCoursewareResCase_Resource_RelEN.IdUsingMode = objRow[convCoursewareResCase_Resource_Rel.IdUsingMode] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.IdUsingMode].ToString().Trim(); //资源使用模式流水号
objvCoursewareResCase_Resource_RelEN.IsVisible = TransNullToBool(objRow[convCoursewareResCase_Resource_Rel.IsVisible].ToString().Trim()); //是否显示
objvCoursewareResCase_Resource_RelEN.IndexNO = objRow[convCoursewareResCase_Resource_Rel.IndexNO] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCoursewareResCase_Resource_Rel.IndexNO].ToString().Trim()); //序号
objvCoursewareResCase_Resource_RelEN.BrowseCount = objRow[convCoursewareResCase_Resource_Rel.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCoursewareResCase_Resource_Rel.BrowseCount].ToString().Trim()); //浏览次数
objvCoursewareResCase_Resource_RelEN.UpdDate = objRow[convCoursewareResCase_Resource_Rel.UpdDate] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.UpdDate].ToString().Trim(); //修改日期
objvCoursewareResCase_Resource_RelEN.UpdUser = objRow[convCoursewareResCase_Resource_Rel.UpdUser] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.UpdUser].ToString().Trim(); //修改人
objvCoursewareResCase_Resource_RelEN.Memo = objRow[convCoursewareResCase_Resource_Rel.Memo] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvCoursewareResCase_Resource_RelDA: GetObjByDataRowvCoursewareResCase_Resource_Rel)", objException.Message));
}
objvCoursewareResCase_Resource_RelEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvCoursewareResCase_Resource_RelEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvCoursewareResCase_Resource_RelEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvCoursewareResCase_Resource_RelEN objvCoursewareResCase_Resource_RelEN = new clsvCoursewareResCase_Resource_RelEN();
try
{
objvCoursewareResCase_Resource_RelEN.IdMicroteachCaseResourceRel = TransNullToInt(objRow[convCoursewareResCase_Resource_Rel.IdMicroteachCaseResourceRel].ToString().Trim()); //微格案例资源关系流水号
objvCoursewareResCase_Resource_RelEN.FuncModuleId = objRow[convCoursewareResCase_Resource_Rel.FuncModuleId].ToString().Trim(); //功能模块Id
objvCoursewareResCase_Resource_RelEN.FuncModuleName = objRow[convCoursewareResCase_Resource_Rel.FuncModuleName] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.FuncModuleName].ToString().Trim(); //功能模块名称
objvCoursewareResCase_Resource_RelEN.IdMicroteachCase = objRow[convCoursewareResCase_Resource_Rel.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvCoursewareResCase_Resource_RelEN.CoursewareResCaseID = objRow[convCoursewareResCase_Resource_Rel.CoursewareResCaseID] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.CoursewareResCaseID].ToString().Trim(); //课件资源案例ID
objvCoursewareResCase_Resource_RelEN.CoursewareResCaseName = objRow[convCoursewareResCase_Resource_Rel.CoursewareResCaseName] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.CoursewareResCaseName].ToString().Trim(); //课件资源案例名称
objvCoursewareResCase_Resource_RelEN.CoursewareResCaseTheme = objRow[convCoursewareResCase_Resource_Rel.CoursewareResCaseTheme] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.CoursewareResCaseTheme].ToString().Trim(); //课件资源案例主题词
objvCoursewareResCase_Resource_RelEN.CoursewareResCaseText = objRow[convCoursewareResCase_Resource_Rel.CoursewareResCaseText] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.CoursewareResCaseText].ToString().Trim(); //案例文本内容
objvCoursewareResCase_Resource_RelEN.IdCoursewareResCaseType = objRow[convCoursewareResCase_Resource_Rel.IdCoursewareResCaseType] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.IdCoursewareResCaseType].ToString().Trim(); //课件资源类型流水号
objvCoursewareResCase_Resource_RelEN.CoursewareResCaseTypeName = objRow[convCoursewareResCase_Resource_Rel.CoursewareResCaseTypeName] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.CoursewareResCaseTypeName].ToString().Trim(); //课件资源案例类型名称
objvCoursewareResCase_Resource_RelEN.CoursewareResCaseDate = objRow[convCoursewareResCase_Resource_Rel.CoursewareResCaseDate] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.CoursewareResCaseDate].ToString().Trim(); //视频资源日期
objvCoursewareResCase_Resource_RelEN.CoursewareResCaseTime = objRow[convCoursewareResCase_Resource_Rel.CoursewareResCaseTime] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.CoursewareResCaseTime].ToString().Trim(); //视频资源时间
objvCoursewareResCase_Resource_RelEN.CoursewareResCaseDateIn = objRow[convCoursewareResCase_Resource_Rel.CoursewareResCaseDateIn] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.CoursewareResCaseDateIn].ToString().Trim(); //案例入库日期
objvCoursewareResCase_Resource_RelEN.CoursewareResCaseTimeIn = objRow[convCoursewareResCase_Resource_Rel.CoursewareResCaseTimeIn] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.CoursewareResCaseTimeIn].ToString().Trim(); //案例入库时间
objvCoursewareResCase_Resource_RelEN.OwnerId = objRow[convCoursewareResCase_Resource_Rel.OwnerId] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.OwnerId].ToString().Trim(); //拥有者Id
objvCoursewareResCase_Resource_RelEN.OwnerName = objRow[convCoursewareResCase_Resource_Rel.OwnerName] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.OwnerName].ToString().Trim(); //拥有者姓名
objvCoursewareResCase_Resource_RelEN.OwnerNameWithId = objRow[convCoursewareResCase_Resource_Rel.OwnerNameWithId] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvCoursewareResCase_Resource_RelEN.IdStudyLevel = objRow[convCoursewareResCase_Resource_Rel.IdStudyLevel] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvCoursewareResCase_Resource_RelEN.StudyLevelName = objRow[convCoursewareResCase_Resource_Rel.StudyLevelName] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.StudyLevelName].ToString().Trim(); //学段名称
objvCoursewareResCase_Resource_RelEN.IdTeachingPlan = objRow[convCoursewareResCase_Resource_Rel.IdTeachingPlan] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.IdTeachingPlan].ToString().Trim(); //教案流水号
objvCoursewareResCase_Resource_RelEN.IdDiscipline = objRow[convCoursewareResCase_Resource_Rel.IdDiscipline] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.IdDiscipline].ToString().Trim(); //学科流水号
objvCoursewareResCase_Resource_RelEN.DisciplineID = objRow[convCoursewareResCase_Resource_Rel.DisciplineID] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.DisciplineID].ToString().Trim(); //学科ID
objvCoursewareResCase_Resource_RelEN.DisciplineName = objRow[convCoursewareResCase_Resource_Rel.DisciplineName] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.DisciplineName].ToString().Trim(); //学科名称
objvCoursewareResCase_Resource_RelEN.senateGaugeVersionID = objRow[convCoursewareResCase_Resource_Rel.senateGaugeVersionID] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvCoursewareResCase_Resource_RelEN.senateGaugeVersionName = objRow[convCoursewareResCase_Resource_Rel.senateGaugeVersionName] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvCoursewareResCase_Resource_RelEN.senateGaugeVersionTtlScore = objRow[convCoursewareResCase_Resource_Rel.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convCoursewareResCase_Resource_Rel.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvCoursewareResCase_Resource_RelEN.VersionNo = objRow[convCoursewareResCase_Resource_Rel.VersionNo] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCoursewareResCase_Resource_Rel.VersionNo].ToString().Trim()); //版本号
objvCoursewareResCase_Resource_RelEN.IdTeachSkill = objRow[convCoursewareResCase_Resource_Rel.IdTeachSkill] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvCoursewareResCase_Resource_RelEN.TeachSkillID = objRow[convCoursewareResCase_Resource_Rel.TeachSkillID] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.TeachSkillID].ToString().Trim(); //教学技能ID
objvCoursewareResCase_Resource_RelEN.SkillTypeName = objRow[convCoursewareResCase_Resource_Rel.SkillTypeName] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.SkillTypeName].ToString().Trim(); //技能类型名称
objvCoursewareResCase_Resource_RelEN.TeachSkillName = objRow[convCoursewareResCase_Resource_Rel.TeachSkillName] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.TeachSkillName].ToString().Trim(); //教学技能名称
objvCoursewareResCase_Resource_RelEN.TeachSkillTheory = objRow[convCoursewareResCase_Resource_Rel.TeachSkillTheory] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvCoursewareResCase_Resource_RelEN.TeachSkillOperMethod = objRow[convCoursewareResCase_Resource_Rel.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvCoursewareResCase_Resource_RelEN.IdSkillType = objRow[convCoursewareResCase_Resource_Rel.IdSkillType] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.IdSkillType].ToString().Trim(); //技能类型流水号
objvCoursewareResCase_Resource_RelEN.SkillTypeID = objRow[convCoursewareResCase_Resource_Rel.SkillTypeID] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.SkillTypeID].ToString().Trim(); //技能类型ID
objvCoursewareResCase_Resource_RelEN.CaseLevelId = objRow[convCoursewareResCase_Resource_Rel.CaseLevelId] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.CaseLevelId].ToString().Trim(); //课例等级Id
objvCoursewareResCase_Resource_RelEN.IsDualVideo = TransNullToBool(objRow[convCoursewareResCase_Resource_Rel.IsDualVideo].ToString().Trim()); //是否双视频
objvCoursewareResCase_Resource_RelEN.IdXzCollege = objRow[convCoursewareResCase_Resource_Rel.IdXzCollege] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.IdXzCollege].ToString().Trim(); //学院流水号
objvCoursewareResCase_Resource_RelEN.CollegeID = objRow[convCoursewareResCase_Resource_Rel.CollegeID] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.CollegeID].ToString().Trim(); //学院ID
objvCoursewareResCase_Resource_RelEN.CollegeName = objRow[convCoursewareResCase_Resource_Rel.CollegeName] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.CollegeName].ToString().Trim(); //学院名称
objvCoursewareResCase_Resource_RelEN.IdXzMajor = objRow[convCoursewareResCase_Resource_Rel.IdXzMajor] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.IdXzMajor].ToString().Trim(); //专业流水号
objvCoursewareResCase_Resource_RelEN.MajorID = objRow[convCoursewareResCase_Resource_Rel.MajorID] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.MajorID].ToString().Trim(); //专业ID
objvCoursewareResCase_Resource_RelEN.MajorName = objRow[convCoursewareResCase_Resource_Rel.MajorName] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.MajorName].ToString().Trim(); //专业名称
objvCoursewareResCase_Resource_RelEN.CourseId = objRow[convCoursewareResCase_Resource_Rel.CourseId] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.CourseId].ToString().Trim(); //课程Id
objvCoursewareResCase_Resource_RelEN.CourseCode = objRow[convCoursewareResCase_Resource_Rel.CourseCode] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.CourseCode].ToString().Trim(); //课程代码
objvCoursewareResCase_Resource_RelEN.CourseName = objRow[convCoursewareResCase_Resource_Rel.CourseName] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.CourseName].ToString().Trim(); //课程名称
objvCoursewareResCase_Resource_RelEN.CourseChapterId = objRow[convCoursewareResCase_Resource_Rel.CourseChapterId] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.CourseChapterId].ToString().Trim(); //课程章节ID
objvCoursewareResCase_Resource_RelEN.CourseChapterName = objRow[convCoursewareResCase_Resource_Rel.CourseChapterName] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.CourseChapterName].ToString().Trim(); //课程章节名称
objvCoursewareResCase_Resource_RelEN.ParentNodeID = objRow[convCoursewareResCase_Resource_Rel.ParentNodeID] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.ParentNodeID].ToString().Trim(); //父节点编号
objvCoursewareResCase_Resource_RelEN.ParentNodeName = objRow[convCoursewareResCase_Resource_Rel.ParentNodeName] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.ParentNodeName].ToString().Trim(); //父节点名称
objvCoursewareResCase_Resource_RelEN.ViewCount = objRow[convCoursewareResCase_Resource_Rel.ViewCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCoursewareResCase_Resource_Rel.ViewCount].ToString().Trim()); //浏览量
objvCoursewareResCase_Resource_RelEN.IsShow = TransNullToBool(objRow[convCoursewareResCase_Resource_Rel.IsShow].ToString().Trim()); //是否启用
objvCoursewareResCase_Resource_RelEN.DownloadNumber = objRow[convCoursewareResCase_Resource_Rel.DownloadNumber] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCoursewareResCase_Resource_Rel.DownloadNumber].ToString().Trim()); //下载数目
objvCoursewareResCase_Resource_RelEN.FileIntegration = objRow[convCoursewareResCase_Resource_Rel.FileIntegration] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCoursewareResCase_Resource_Rel.FileIntegration].ToString().Trim()); //文件积分
objvCoursewareResCase_Resource_RelEN.LikeCount = objRow[convCoursewareResCase_Resource_Rel.LikeCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convCoursewareResCase_Resource_Rel.LikeCount].ToString().Trim()); //资源喜欢数量
objvCoursewareResCase_Resource_RelEN.CollectionCount = objRow[convCoursewareResCase_Resource_Rel.CollectionCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convCoursewareResCase_Resource_Rel.CollectionCount].ToString().Trim()); //收藏数量
objvCoursewareResCase_Resource_RelEN.RecommendedDegreeId = objRow[convCoursewareResCase_Resource_Rel.RecommendedDegreeId] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvCoursewareResCase_Resource_RelEN.RecommendedDegreeName = objRow[convCoursewareResCase_Resource_Rel.RecommendedDegreeName] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvCoursewareResCase_Resource_RelEN.BrowseCount4Case = objRow[convCoursewareResCase_Resource_Rel.BrowseCount4Case] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCoursewareResCase_Resource_Rel.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvCoursewareResCase_Resource_RelEN.CollegeNameA = objRow[convCoursewareResCase_Resource_Rel.CollegeNameA] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.CollegeNameA].ToString().Trim(); //学院名称简写
objvCoursewareResCase_Resource_RelEN.IdResource = objRow[convCoursewareResCase_Resource_Rel.IdResource].ToString().Trim(); //资源流水号
objvCoursewareResCase_Resource_RelEN.ResourceID = objRow[convCoursewareResCase_Resource_Rel.ResourceID] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.ResourceID].ToString().Trim(); //资源ID
objvCoursewareResCase_Resource_RelEN.ResourceName = objRow[convCoursewareResCase_Resource_Rel.ResourceName] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.ResourceName].ToString().Trim(); //资源名称
objvCoursewareResCase_Resource_RelEN.IdFtpResource = objRow[convCoursewareResCase_Resource_Rel.IdFtpResource] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvCoursewareResCase_Resource_RelEN.IdFile = objRow[convCoursewareResCase_Resource_Rel.IdFile] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.IdFile].ToString().Trim(); //文件流水号
objvCoursewareResCase_Resource_RelEN.FileName = objRow[convCoursewareResCase_Resource_Rel.FileName] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.FileName].ToString().Trim(); //文件名称
objvCoursewareResCase_Resource_RelEN.FileType = objRow[convCoursewareResCase_Resource_Rel.FileType] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.FileType].ToString().Trim(); //文件类型
objvCoursewareResCase_Resource_RelEN.SaveDate = objRow[convCoursewareResCase_Resource_Rel.SaveDate] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.SaveDate].ToString().Trim(); //创建日期
objvCoursewareResCase_Resource_RelEN.FileSize = objRow[convCoursewareResCase_Resource_Rel.FileSize] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.FileSize].ToString().Trim(); //文件大小
objvCoursewareResCase_Resource_RelEN.SaveTime = objRow[convCoursewareResCase_Resource_Rel.SaveTime] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.SaveTime].ToString().Trim(); //创建时间
objvCoursewareResCase_Resource_RelEN.FtpResourceID = objRow[convCoursewareResCase_Resource_Rel.FtpResourceID] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.FtpResourceID].ToString().Trim(); //FTP资源ID
objvCoursewareResCase_Resource_RelEN.FileOriginalName = objRow[convCoursewareResCase_Resource_Rel.FileOriginalName] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.FileOriginalName].ToString().Trim(); //文件原名
objvCoursewareResCase_Resource_RelEN.FileDirName = objRow[convCoursewareResCase_Resource_Rel.FileDirName] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.FileDirName].ToString().Trim(); //文件目录名
objvCoursewareResCase_Resource_RelEN.FileRename = objRow[convCoursewareResCase_Resource_Rel.FileRename] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.FileRename].ToString().Trim(); //文件新名
objvCoursewareResCase_Resource_RelEN.FileUpDate = objRow[convCoursewareResCase_Resource_Rel.FileUpDate] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.FileUpDate].ToString().Trim(); //创建日期
objvCoursewareResCase_Resource_RelEN.FileUpTime = objRow[convCoursewareResCase_Resource_Rel.FileUpTime] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.FileUpTime].ToString().Trim(); //创建时间
objvCoursewareResCase_Resource_RelEN.SaveMode = TransNullToBool(objRow[convCoursewareResCase_Resource_Rel.SaveMode].ToString().Trim()); //文件存放方式
objvCoursewareResCase_Resource_RelEN.IdResourceType = objRow[convCoursewareResCase_Resource_Rel.IdResourceType] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.IdResourceType].ToString().Trim(); //资源类型流水号
objvCoursewareResCase_Resource_RelEN.ResourceTypeID = objRow[convCoursewareResCase_Resource_Rel.ResourceTypeID] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.ResourceTypeID].ToString().Trim(); //资源类型ID
objvCoursewareResCase_Resource_RelEN.ResourceTypeName = objRow[convCoursewareResCase_Resource_Rel.ResourceTypeName] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.ResourceTypeName].ToString().Trim(); //资源类型名称
objvCoursewareResCase_Resource_RelEN.ResourceOwner = objRow[convCoursewareResCase_Resource_Rel.ResourceOwner] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.ResourceOwner].ToString().Trim(); //上传者
objvCoursewareResCase_Resource_RelEN.ftpFileType = objRow[convCoursewareResCase_Resource_Rel.ftpFileType] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.ftpFileType].ToString().Trim(); //ftp文件类型
objvCoursewareResCase_Resource_RelEN.ftpFileSize = objRow[convCoursewareResCase_Resource_Rel.ftpFileSize] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.ftpFileSize].ToString().Trim(); //ftp文件大小
objvCoursewareResCase_Resource_RelEN.ftpResourceOwner = objRow[convCoursewareResCase_Resource_Rel.ftpResourceOwner] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvCoursewareResCase_Resource_RelEN.FileOriginName = objRow[convCoursewareResCase_Resource_Rel.FileOriginName] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.FileOriginName].ToString().Trim(); //原文件名
objvCoursewareResCase_Resource_RelEN.IsExistFile = TransNullToBool(objRow[convCoursewareResCase_Resource_Rel.IsExistFile].ToString().Trim()); //是否存在文件
objvCoursewareResCase_Resource_RelEN.FileNewName = objRow[convCoursewareResCase_Resource_Rel.FileNewName] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.FileNewName].ToString().Trim(); //新文件名
objvCoursewareResCase_Resource_RelEN.FileOldName = objRow[convCoursewareResCase_Resource_Rel.FileOldName] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.FileOldName].ToString().Trim(); //旧文件名
objvCoursewareResCase_Resource_RelEN.IsMain = TransNullToBool(objRow[convCoursewareResCase_Resource_Rel.IsMain].ToString().Trim()); //是否主资源
objvCoursewareResCase_Resource_RelEN.IdUsingMode = objRow[convCoursewareResCase_Resource_Rel.IdUsingMode] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.IdUsingMode].ToString().Trim(); //资源使用模式流水号
objvCoursewareResCase_Resource_RelEN.IsVisible = TransNullToBool(objRow[convCoursewareResCase_Resource_Rel.IsVisible].ToString().Trim()); //是否显示
objvCoursewareResCase_Resource_RelEN.IndexNO = objRow[convCoursewareResCase_Resource_Rel.IndexNO] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCoursewareResCase_Resource_Rel.IndexNO].ToString().Trim()); //序号
objvCoursewareResCase_Resource_RelEN.BrowseCount = objRow[convCoursewareResCase_Resource_Rel.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCoursewareResCase_Resource_Rel.BrowseCount].ToString().Trim()); //浏览次数
objvCoursewareResCase_Resource_RelEN.UpdDate = objRow[convCoursewareResCase_Resource_Rel.UpdDate] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.UpdDate].ToString().Trim(); //修改日期
objvCoursewareResCase_Resource_RelEN.UpdUser = objRow[convCoursewareResCase_Resource_Rel.UpdUser] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.UpdUser].ToString().Trim(); //修改人
objvCoursewareResCase_Resource_RelEN.Memo = objRow[convCoursewareResCase_Resource_Rel.Memo] == DBNull.Value ? null : objRow[convCoursewareResCase_Resource_Rel.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvCoursewareResCase_Resource_RelDA: GetObjByDataRow)", objException.Message));
}
objvCoursewareResCase_Resource_RelEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvCoursewareResCase_Resource_RelEN;
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
objSQL = clsvCoursewareResCase_Resource_RelDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvCoursewareResCase_Resource_RelEN._CurrTabName, convCoursewareResCase_Resource_Rel.IdMicroteachCaseResourceRel, 8, "");
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
objSQL = clsvCoursewareResCase_Resource_RelDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvCoursewareResCase_Resource_RelEN._CurrTabName, convCoursewareResCase_Resource_Rel.IdMicroteachCaseResourceRel, 8, strPrefix);
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
 objSQL = clsvCoursewareResCase_Resource_RelDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select IdMicroteachCaseResourceRel from vCoursewareResCase_Resource_Rel where " + strCondition;
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
 objSQL = clsvCoursewareResCase_Resource_RelDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select IdMicroteachCaseResourceRel from vCoursewareResCase_Resource_Rel where " + strCondition;
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
 objSQL = clsvCoursewareResCase_Resource_RelDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vCoursewareResCase_Resource_Rel", "IdMicroteachCaseResourceRel = " + ""+ lngIdMicroteachCaseResourceRel+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvCoursewareResCase_Resource_RelDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCoursewareResCase_Resource_RelDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vCoursewareResCase_Resource_Rel", strCondition))
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
objSQL = clsvCoursewareResCase_Resource_RelDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vCoursewareResCase_Resource_Rel");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvCoursewareResCase_Resource_RelENS">源对象</param>
 /// <param name = "objvCoursewareResCase_Resource_RelENT">目标对象</param>
public void CopyTo(clsvCoursewareResCase_Resource_RelEN objvCoursewareResCase_Resource_RelENS, clsvCoursewareResCase_Resource_RelEN objvCoursewareResCase_Resource_RelENT)
{
objvCoursewareResCase_Resource_RelENT.IdMicroteachCaseResourceRel = objvCoursewareResCase_Resource_RelENS.IdMicroteachCaseResourceRel; //微格案例资源关系流水号
objvCoursewareResCase_Resource_RelENT.FuncModuleId = objvCoursewareResCase_Resource_RelENS.FuncModuleId; //功能模块Id
objvCoursewareResCase_Resource_RelENT.FuncModuleName = objvCoursewareResCase_Resource_RelENS.FuncModuleName; //功能模块名称
objvCoursewareResCase_Resource_RelENT.IdMicroteachCase = objvCoursewareResCase_Resource_RelENS.IdMicroteachCase; //微格教学案例流水号
objvCoursewareResCase_Resource_RelENT.CoursewareResCaseID = objvCoursewareResCase_Resource_RelENS.CoursewareResCaseID; //课件资源案例ID
objvCoursewareResCase_Resource_RelENT.CoursewareResCaseName = objvCoursewareResCase_Resource_RelENS.CoursewareResCaseName; //课件资源案例名称
objvCoursewareResCase_Resource_RelENT.CoursewareResCaseTheme = objvCoursewareResCase_Resource_RelENS.CoursewareResCaseTheme; //课件资源案例主题词
objvCoursewareResCase_Resource_RelENT.CoursewareResCaseText = objvCoursewareResCase_Resource_RelENS.CoursewareResCaseText; //案例文本内容
objvCoursewareResCase_Resource_RelENT.IdCoursewareResCaseType = objvCoursewareResCase_Resource_RelENS.IdCoursewareResCaseType; //课件资源类型流水号
objvCoursewareResCase_Resource_RelENT.CoursewareResCaseTypeName = objvCoursewareResCase_Resource_RelENS.CoursewareResCaseTypeName; //课件资源案例类型名称
objvCoursewareResCase_Resource_RelENT.CoursewareResCaseDate = objvCoursewareResCase_Resource_RelENS.CoursewareResCaseDate; //视频资源日期
objvCoursewareResCase_Resource_RelENT.CoursewareResCaseTime = objvCoursewareResCase_Resource_RelENS.CoursewareResCaseTime; //视频资源时间
objvCoursewareResCase_Resource_RelENT.CoursewareResCaseDateIn = objvCoursewareResCase_Resource_RelENS.CoursewareResCaseDateIn; //案例入库日期
objvCoursewareResCase_Resource_RelENT.CoursewareResCaseTimeIn = objvCoursewareResCase_Resource_RelENS.CoursewareResCaseTimeIn; //案例入库时间
objvCoursewareResCase_Resource_RelENT.OwnerId = objvCoursewareResCase_Resource_RelENS.OwnerId; //拥有者Id
objvCoursewareResCase_Resource_RelENT.OwnerName = objvCoursewareResCase_Resource_RelENS.OwnerName; //拥有者姓名
objvCoursewareResCase_Resource_RelENT.OwnerNameWithId = objvCoursewareResCase_Resource_RelENS.OwnerNameWithId; //拥有者名称附Id
objvCoursewareResCase_Resource_RelENT.IdStudyLevel = objvCoursewareResCase_Resource_RelENS.IdStudyLevel; //id_StudyLevel
objvCoursewareResCase_Resource_RelENT.StudyLevelName = objvCoursewareResCase_Resource_RelENS.StudyLevelName; //学段名称
objvCoursewareResCase_Resource_RelENT.IdTeachingPlan = objvCoursewareResCase_Resource_RelENS.IdTeachingPlan; //教案流水号
objvCoursewareResCase_Resource_RelENT.IdDiscipline = objvCoursewareResCase_Resource_RelENS.IdDiscipline; //学科流水号
objvCoursewareResCase_Resource_RelENT.DisciplineID = objvCoursewareResCase_Resource_RelENS.DisciplineID; //学科ID
objvCoursewareResCase_Resource_RelENT.DisciplineName = objvCoursewareResCase_Resource_RelENS.DisciplineName; //学科名称
objvCoursewareResCase_Resource_RelENT.senateGaugeVersionID = objvCoursewareResCase_Resource_RelENS.senateGaugeVersionID; //评价量表版本ID
objvCoursewareResCase_Resource_RelENT.senateGaugeVersionName = objvCoursewareResCase_Resource_RelENS.senateGaugeVersionName; //评价量表版本名称
objvCoursewareResCase_Resource_RelENT.senateGaugeVersionTtlScore = objvCoursewareResCase_Resource_RelENS.senateGaugeVersionTtlScore; //评价量表版本总分
objvCoursewareResCase_Resource_RelENT.VersionNo = objvCoursewareResCase_Resource_RelENS.VersionNo; //版本号
objvCoursewareResCase_Resource_RelENT.IdTeachSkill = objvCoursewareResCase_Resource_RelENS.IdTeachSkill; //教学技能流水号
objvCoursewareResCase_Resource_RelENT.TeachSkillID = objvCoursewareResCase_Resource_RelENS.TeachSkillID; //教学技能ID
objvCoursewareResCase_Resource_RelENT.SkillTypeName = objvCoursewareResCase_Resource_RelENS.SkillTypeName; //技能类型名称
objvCoursewareResCase_Resource_RelENT.TeachSkillName = objvCoursewareResCase_Resource_RelENS.TeachSkillName; //教学技能名称
objvCoursewareResCase_Resource_RelENT.TeachSkillTheory = objvCoursewareResCase_Resource_RelENS.TeachSkillTheory; //教学技能理论阐述
objvCoursewareResCase_Resource_RelENT.TeachSkillOperMethod = objvCoursewareResCase_Resource_RelENS.TeachSkillOperMethod; //教学技能实践操作方法
objvCoursewareResCase_Resource_RelENT.IdSkillType = objvCoursewareResCase_Resource_RelENS.IdSkillType; //技能类型流水号
objvCoursewareResCase_Resource_RelENT.SkillTypeID = objvCoursewareResCase_Resource_RelENS.SkillTypeID; //技能类型ID
objvCoursewareResCase_Resource_RelENT.CaseLevelId = objvCoursewareResCase_Resource_RelENS.CaseLevelId; //课例等级Id
objvCoursewareResCase_Resource_RelENT.IsDualVideo = objvCoursewareResCase_Resource_RelENS.IsDualVideo; //是否双视频
objvCoursewareResCase_Resource_RelENT.IdXzCollege = objvCoursewareResCase_Resource_RelENS.IdXzCollege; //学院流水号
objvCoursewareResCase_Resource_RelENT.CollegeID = objvCoursewareResCase_Resource_RelENS.CollegeID; //学院ID
objvCoursewareResCase_Resource_RelENT.CollegeName = objvCoursewareResCase_Resource_RelENS.CollegeName; //学院名称
objvCoursewareResCase_Resource_RelENT.IdXzMajor = objvCoursewareResCase_Resource_RelENS.IdXzMajor; //专业流水号
objvCoursewareResCase_Resource_RelENT.MajorID = objvCoursewareResCase_Resource_RelENS.MajorID; //专业ID
objvCoursewareResCase_Resource_RelENT.MajorName = objvCoursewareResCase_Resource_RelENS.MajorName; //专业名称
objvCoursewareResCase_Resource_RelENT.CourseId = objvCoursewareResCase_Resource_RelENS.CourseId; //课程Id
objvCoursewareResCase_Resource_RelENT.CourseCode = objvCoursewareResCase_Resource_RelENS.CourseCode; //课程代码
objvCoursewareResCase_Resource_RelENT.CourseName = objvCoursewareResCase_Resource_RelENS.CourseName; //课程名称
objvCoursewareResCase_Resource_RelENT.CourseChapterId = objvCoursewareResCase_Resource_RelENS.CourseChapterId; //课程章节ID
objvCoursewareResCase_Resource_RelENT.CourseChapterName = objvCoursewareResCase_Resource_RelENS.CourseChapterName; //课程章节名称
objvCoursewareResCase_Resource_RelENT.ParentNodeID = objvCoursewareResCase_Resource_RelENS.ParentNodeID; //父节点编号
objvCoursewareResCase_Resource_RelENT.ParentNodeName = objvCoursewareResCase_Resource_RelENS.ParentNodeName; //父节点名称
objvCoursewareResCase_Resource_RelENT.ViewCount = objvCoursewareResCase_Resource_RelENS.ViewCount; //浏览量
objvCoursewareResCase_Resource_RelENT.IsShow = objvCoursewareResCase_Resource_RelENS.IsShow; //是否启用
objvCoursewareResCase_Resource_RelENT.DownloadNumber = objvCoursewareResCase_Resource_RelENS.DownloadNumber; //下载数目
objvCoursewareResCase_Resource_RelENT.FileIntegration = objvCoursewareResCase_Resource_RelENS.FileIntegration; //文件积分
objvCoursewareResCase_Resource_RelENT.LikeCount = objvCoursewareResCase_Resource_RelENS.LikeCount; //资源喜欢数量
objvCoursewareResCase_Resource_RelENT.CollectionCount = objvCoursewareResCase_Resource_RelENS.CollectionCount; //收藏数量
objvCoursewareResCase_Resource_RelENT.RecommendedDegreeId = objvCoursewareResCase_Resource_RelENS.RecommendedDegreeId; //推荐度Id
objvCoursewareResCase_Resource_RelENT.RecommendedDegreeName = objvCoursewareResCase_Resource_RelENS.RecommendedDegreeName; //推荐度名称
objvCoursewareResCase_Resource_RelENT.BrowseCount4Case = objvCoursewareResCase_Resource_RelENS.BrowseCount4Case; //课例浏览次数
objvCoursewareResCase_Resource_RelENT.CollegeNameA = objvCoursewareResCase_Resource_RelENS.CollegeNameA; //学院名称简写
objvCoursewareResCase_Resource_RelENT.IdResource = objvCoursewareResCase_Resource_RelENS.IdResource; //资源流水号
objvCoursewareResCase_Resource_RelENT.ResourceID = objvCoursewareResCase_Resource_RelENS.ResourceID; //资源ID
objvCoursewareResCase_Resource_RelENT.ResourceName = objvCoursewareResCase_Resource_RelENS.ResourceName; //资源名称
objvCoursewareResCase_Resource_RelENT.IdFtpResource = objvCoursewareResCase_Resource_RelENS.IdFtpResource; //FTP资源流水号
objvCoursewareResCase_Resource_RelENT.IdFile = objvCoursewareResCase_Resource_RelENS.IdFile; //文件流水号
objvCoursewareResCase_Resource_RelENT.FileName = objvCoursewareResCase_Resource_RelENS.FileName; //文件名称
objvCoursewareResCase_Resource_RelENT.FileType = objvCoursewareResCase_Resource_RelENS.FileType; //文件类型
objvCoursewareResCase_Resource_RelENT.SaveDate = objvCoursewareResCase_Resource_RelENS.SaveDate; //创建日期
objvCoursewareResCase_Resource_RelENT.FileSize = objvCoursewareResCase_Resource_RelENS.FileSize; //文件大小
objvCoursewareResCase_Resource_RelENT.SaveTime = objvCoursewareResCase_Resource_RelENS.SaveTime; //创建时间
objvCoursewareResCase_Resource_RelENT.FtpResourceID = objvCoursewareResCase_Resource_RelENS.FtpResourceID; //FTP资源ID
objvCoursewareResCase_Resource_RelENT.FileOriginalName = objvCoursewareResCase_Resource_RelENS.FileOriginalName; //文件原名
objvCoursewareResCase_Resource_RelENT.FileDirName = objvCoursewareResCase_Resource_RelENS.FileDirName; //文件目录名
objvCoursewareResCase_Resource_RelENT.FileRename = objvCoursewareResCase_Resource_RelENS.FileRename; //文件新名
objvCoursewareResCase_Resource_RelENT.FileUpDate = objvCoursewareResCase_Resource_RelENS.FileUpDate; //创建日期
objvCoursewareResCase_Resource_RelENT.FileUpTime = objvCoursewareResCase_Resource_RelENS.FileUpTime; //创建时间
objvCoursewareResCase_Resource_RelENT.SaveMode = objvCoursewareResCase_Resource_RelENS.SaveMode; //文件存放方式
objvCoursewareResCase_Resource_RelENT.IdResourceType = objvCoursewareResCase_Resource_RelENS.IdResourceType; //资源类型流水号
objvCoursewareResCase_Resource_RelENT.ResourceTypeID = objvCoursewareResCase_Resource_RelENS.ResourceTypeID; //资源类型ID
objvCoursewareResCase_Resource_RelENT.ResourceTypeName = objvCoursewareResCase_Resource_RelENS.ResourceTypeName; //资源类型名称
objvCoursewareResCase_Resource_RelENT.ResourceOwner = objvCoursewareResCase_Resource_RelENS.ResourceOwner; //上传者
objvCoursewareResCase_Resource_RelENT.ftpFileType = objvCoursewareResCase_Resource_RelENS.ftpFileType; //ftp文件类型
objvCoursewareResCase_Resource_RelENT.ftpFileSize = objvCoursewareResCase_Resource_RelENS.ftpFileSize; //ftp文件大小
objvCoursewareResCase_Resource_RelENT.ftpResourceOwner = objvCoursewareResCase_Resource_RelENS.ftpResourceOwner; //Ftp资源拥有者
objvCoursewareResCase_Resource_RelENT.FileOriginName = objvCoursewareResCase_Resource_RelENS.FileOriginName; //原文件名
objvCoursewareResCase_Resource_RelENT.IsExistFile = objvCoursewareResCase_Resource_RelENS.IsExistFile; //是否存在文件
objvCoursewareResCase_Resource_RelENT.FileNewName = objvCoursewareResCase_Resource_RelENS.FileNewName; //新文件名
objvCoursewareResCase_Resource_RelENT.FileOldName = objvCoursewareResCase_Resource_RelENS.FileOldName; //旧文件名
objvCoursewareResCase_Resource_RelENT.IsMain = objvCoursewareResCase_Resource_RelENS.IsMain; //是否主资源
objvCoursewareResCase_Resource_RelENT.IdUsingMode = objvCoursewareResCase_Resource_RelENS.IdUsingMode; //资源使用模式流水号
objvCoursewareResCase_Resource_RelENT.IsVisible = objvCoursewareResCase_Resource_RelENS.IsVisible; //是否显示
objvCoursewareResCase_Resource_RelENT.IndexNO = objvCoursewareResCase_Resource_RelENS.IndexNO; //序号
objvCoursewareResCase_Resource_RelENT.BrowseCount = objvCoursewareResCase_Resource_RelENS.BrowseCount; //浏览次数
objvCoursewareResCase_Resource_RelENT.UpdDate = objvCoursewareResCase_Resource_RelENS.UpdDate; //修改日期
objvCoursewareResCase_Resource_RelENT.UpdUser = objvCoursewareResCase_Resource_RelENS.UpdUser; //修改人
objvCoursewareResCase_Resource_RelENT.Memo = objvCoursewareResCase_Resource_RelENS.Memo; //备注
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvCoursewareResCase_Resource_RelEN objvCoursewareResCase_Resource_RelEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvCoursewareResCase_Resource_RelEN.FuncModuleId, 4, convCoursewareResCase_Resource_Rel.FuncModuleId);
clsCheckSql.CheckFieldLen(objvCoursewareResCase_Resource_RelEN.FuncModuleName, 30, convCoursewareResCase_Resource_Rel.FuncModuleName);
clsCheckSql.CheckFieldLen(objvCoursewareResCase_Resource_RelEN.IdMicroteachCase, 8, convCoursewareResCase_Resource_Rel.IdMicroteachCase);
clsCheckSql.CheckFieldLen(objvCoursewareResCase_Resource_RelEN.CoursewareResCaseID, 8, convCoursewareResCase_Resource_Rel.CoursewareResCaseID);
clsCheckSql.CheckFieldLen(objvCoursewareResCase_Resource_RelEN.CoursewareResCaseName, 100, convCoursewareResCase_Resource_Rel.CoursewareResCaseName);
clsCheckSql.CheckFieldLen(objvCoursewareResCase_Resource_RelEN.CoursewareResCaseTheme, 200, convCoursewareResCase_Resource_Rel.CoursewareResCaseTheme);
clsCheckSql.CheckFieldLen(objvCoursewareResCase_Resource_RelEN.CoursewareResCaseText, 8000, convCoursewareResCase_Resource_Rel.CoursewareResCaseText);
clsCheckSql.CheckFieldLen(objvCoursewareResCase_Resource_RelEN.IdCoursewareResCaseType, 4, convCoursewareResCase_Resource_Rel.IdCoursewareResCaseType);
clsCheckSql.CheckFieldLen(objvCoursewareResCase_Resource_RelEN.CoursewareResCaseTypeName, 30, convCoursewareResCase_Resource_Rel.CoursewareResCaseTypeName);
clsCheckSql.CheckFieldLen(objvCoursewareResCase_Resource_RelEN.CoursewareResCaseDate, 8, convCoursewareResCase_Resource_Rel.CoursewareResCaseDate);
clsCheckSql.CheckFieldLen(objvCoursewareResCase_Resource_RelEN.CoursewareResCaseTime, 6, convCoursewareResCase_Resource_Rel.CoursewareResCaseTime);
clsCheckSql.CheckFieldLen(objvCoursewareResCase_Resource_RelEN.CoursewareResCaseDateIn, 8, convCoursewareResCase_Resource_Rel.CoursewareResCaseDateIn);
clsCheckSql.CheckFieldLen(objvCoursewareResCase_Resource_RelEN.CoursewareResCaseTimeIn, 6, convCoursewareResCase_Resource_Rel.CoursewareResCaseTimeIn);
clsCheckSql.CheckFieldLen(objvCoursewareResCase_Resource_RelEN.OwnerId, 20, convCoursewareResCase_Resource_Rel.OwnerId);
clsCheckSql.CheckFieldLen(objvCoursewareResCase_Resource_RelEN.OwnerName, 30, convCoursewareResCase_Resource_Rel.OwnerName);
clsCheckSql.CheckFieldLen(objvCoursewareResCase_Resource_RelEN.OwnerNameWithId, 51, convCoursewareResCase_Resource_Rel.OwnerNameWithId);
clsCheckSql.CheckFieldLen(objvCoursewareResCase_Resource_RelEN.IdStudyLevel, 4, convCoursewareResCase_Resource_Rel.IdStudyLevel);
clsCheckSql.CheckFieldLen(objvCoursewareResCase_Resource_RelEN.StudyLevelName, 50, convCoursewareResCase_Resource_Rel.StudyLevelName);
clsCheckSql.CheckFieldLen(objvCoursewareResCase_Resource_RelEN.IdTeachingPlan, 8, convCoursewareResCase_Resource_Rel.IdTeachingPlan);
clsCheckSql.CheckFieldLen(objvCoursewareResCase_Resource_RelEN.IdDiscipline, 4, convCoursewareResCase_Resource_Rel.IdDiscipline);
clsCheckSql.CheckFieldLen(objvCoursewareResCase_Resource_RelEN.DisciplineID, 4, convCoursewareResCase_Resource_Rel.DisciplineID);
clsCheckSql.CheckFieldLen(objvCoursewareResCase_Resource_RelEN.DisciplineName, 50, convCoursewareResCase_Resource_Rel.DisciplineName);
clsCheckSql.CheckFieldLen(objvCoursewareResCase_Resource_RelEN.senateGaugeVersionID, 4, convCoursewareResCase_Resource_Rel.senateGaugeVersionID);
clsCheckSql.CheckFieldLen(objvCoursewareResCase_Resource_RelEN.senateGaugeVersionName, 200, convCoursewareResCase_Resource_Rel.senateGaugeVersionName);
clsCheckSql.CheckFieldLen(objvCoursewareResCase_Resource_RelEN.IdTeachSkill, 8, convCoursewareResCase_Resource_Rel.IdTeachSkill);
clsCheckSql.CheckFieldLen(objvCoursewareResCase_Resource_RelEN.TeachSkillID, 8, convCoursewareResCase_Resource_Rel.TeachSkillID);
clsCheckSql.CheckFieldLen(objvCoursewareResCase_Resource_RelEN.SkillTypeName, 50, convCoursewareResCase_Resource_Rel.SkillTypeName);
clsCheckSql.CheckFieldLen(objvCoursewareResCase_Resource_RelEN.TeachSkillName, 50, convCoursewareResCase_Resource_Rel.TeachSkillName);
clsCheckSql.CheckFieldLen(objvCoursewareResCase_Resource_RelEN.TeachSkillTheory, 8000, convCoursewareResCase_Resource_Rel.TeachSkillTheory);
clsCheckSql.CheckFieldLen(objvCoursewareResCase_Resource_RelEN.TeachSkillOperMethod, 2000, convCoursewareResCase_Resource_Rel.TeachSkillOperMethod);
clsCheckSql.CheckFieldLen(objvCoursewareResCase_Resource_RelEN.IdSkillType, 4, convCoursewareResCase_Resource_Rel.IdSkillType);
clsCheckSql.CheckFieldLen(objvCoursewareResCase_Resource_RelEN.SkillTypeID, 4, convCoursewareResCase_Resource_Rel.SkillTypeID);
clsCheckSql.CheckFieldLen(objvCoursewareResCase_Resource_RelEN.CaseLevelId, 2, convCoursewareResCase_Resource_Rel.CaseLevelId);
clsCheckSql.CheckFieldLen(objvCoursewareResCase_Resource_RelEN.IdXzCollege, 4, convCoursewareResCase_Resource_Rel.IdXzCollege);
clsCheckSql.CheckFieldLen(objvCoursewareResCase_Resource_RelEN.CollegeID, 4, convCoursewareResCase_Resource_Rel.CollegeID);
clsCheckSql.CheckFieldLen(objvCoursewareResCase_Resource_RelEN.CollegeName, 100, convCoursewareResCase_Resource_Rel.CollegeName);
clsCheckSql.CheckFieldLen(objvCoursewareResCase_Resource_RelEN.IdXzMajor, 8, convCoursewareResCase_Resource_Rel.IdXzMajor);
clsCheckSql.CheckFieldLen(objvCoursewareResCase_Resource_RelEN.MajorID, 4, convCoursewareResCase_Resource_Rel.MajorID);
clsCheckSql.CheckFieldLen(objvCoursewareResCase_Resource_RelEN.MajorName, 100, convCoursewareResCase_Resource_Rel.MajorName);
clsCheckSql.CheckFieldLen(objvCoursewareResCase_Resource_RelEN.CourseId, 8, convCoursewareResCase_Resource_Rel.CourseId);
clsCheckSql.CheckFieldLen(objvCoursewareResCase_Resource_RelEN.CourseCode, 20, convCoursewareResCase_Resource_Rel.CourseCode);
clsCheckSql.CheckFieldLen(objvCoursewareResCase_Resource_RelEN.CourseName, 100, convCoursewareResCase_Resource_Rel.CourseName);
clsCheckSql.CheckFieldLen(objvCoursewareResCase_Resource_RelEN.CourseChapterId, 8, convCoursewareResCase_Resource_Rel.CourseChapterId);
clsCheckSql.CheckFieldLen(objvCoursewareResCase_Resource_RelEN.CourseChapterName, 100, convCoursewareResCase_Resource_Rel.CourseChapterName);
clsCheckSql.CheckFieldLen(objvCoursewareResCase_Resource_RelEN.ParentNodeID, 8, convCoursewareResCase_Resource_Rel.ParentNodeID);
clsCheckSql.CheckFieldLen(objvCoursewareResCase_Resource_RelEN.ParentNodeName, 50, convCoursewareResCase_Resource_Rel.ParentNodeName);
clsCheckSql.CheckFieldLen(objvCoursewareResCase_Resource_RelEN.RecommendedDegreeId, 2, convCoursewareResCase_Resource_Rel.RecommendedDegreeId);
clsCheckSql.CheckFieldLen(objvCoursewareResCase_Resource_RelEN.RecommendedDegreeName, 30, convCoursewareResCase_Resource_Rel.RecommendedDegreeName);
clsCheckSql.CheckFieldLen(objvCoursewareResCase_Resource_RelEN.CollegeNameA, 12, convCoursewareResCase_Resource_Rel.CollegeNameA);
clsCheckSql.CheckFieldLen(objvCoursewareResCase_Resource_RelEN.IdResource, 8, convCoursewareResCase_Resource_Rel.IdResource);
clsCheckSql.CheckFieldLen(objvCoursewareResCase_Resource_RelEN.ResourceID, 8, convCoursewareResCase_Resource_Rel.ResourceID);
clsCheckSql.CheckFieldLen(objvCoursewareResCase_Resource_RelEN.ResourceName, 100, convCoursewareResCase_Resource_Rel.ResourceName);
clsCheckSql.CheckFieldLen(objvCoursewareResCase_Resource_RelEN.IdFtpResource, 8, convCoursewareResCase_Resource_Rel.IdFtpResource);
clsCheckSql.CheckFieldLen(objvCoursewareResCase_Resource_RelEN.IdFile, 8, convCoursewareResCase_Resource_Rel.IdFile);
clsCheckSql.CheckFieldLen(objvCoursewareResCase_Resource_RelEN.FileName, 500, convCoursewareResCase_Resource_Rel.FileName);
clsCheckSql.CheckFieldLen(objvCoursewareResCase_Resource_RelEN.FileType, 30, convCoursewareResCase_Resource_Rel.FileType);
clsCheckSql.CheckFieldLen(objvCoursewareResCase_Resource_RelEN.SaveDate, 8, convCoursewareResCase_Resource_Rel.SaveDate);
clsCheckSql.CheckFieldLen(objvCoursewareResCase_Resource_RelEN.FileSize, 50, convCoursewareResCase_Resource_Rel.FileSize);
clsCheckSql.CheckFieldLen(objvCoursewareResCase_Resource_RelEN.SaveTime, 6, convCoursewareResCase_Resource_Rel.SaveTime);
clsCheckSql.CheckFieldLen(objvCoursewareResCase_Resource_RelEN.FtpResourceID, 8, convCoursewareResCase_Resource_Rel.FtpResourceID);
clsCheckSql.CheckFieldLen(objvCoursewareResCase_Resource_RelEN.FileOriginalName, 200, convCoursewareResCase_Resource_Rel.FileOriginalName);
clsCheckSql.CheckFieldLen(objvCoursewareResCase_Resource_RelEN.FileDirName, 200, convCoursewareResCase_Resource_Rel.FileDirName);
clsCheckSql.CheckFieldLen(objvCoursewareResCase_Resource_RelEN.FileRename, 200, convCoursewareResCase_Resource_Rel.FileRename);
clsCheckSql.CheckFieldLen(objvCoursewareResCase_Resource_RelEN.FileUpDate, 8, convCoursewareResCase_Resource_Rel.FileUpDate);
clsCheckSql.CheckFieldLen(objvCoursewareResCase_Resource_RelEN.FileUpTime, 6, convCoursewareResCase_Resource_Rel.FileUpTime);
clsCheckSql.CheckFieldLen(objvCoursewareResCase_Resource_RelEN.IdResourceType, 4, convCoursewareResCase_Resource_Rel.IdResourceType);
clsCheckSql.CheckFieldLen(objvCoursewareResCase_Resource_RelEN.ResourceTypeID, 4, convCoursewareResCase_Resource_Rel.ResourceTypeID);
clsCheckSql.CheckFieldLen(objvCoursewareResCase_Resource_RelEN.ResourceTypeName, 50, convCoursewareResCase_Resource_Rel.ResourceTypeName);
clsCheckSql.CheckFieldLen(objvCoursewareResCase_Resource_RelEN.ResourceOwner, 50, convCoursewareResCase_Resource_Rel.ResourceOwner);
clsCheckSql.CheckFieldLen(objvCoursewareResCase_Resource_RelEN.ftpFileType, 30, convCoursewareResCase_Resource_Rel.ftpFileType);
clsCheckSql.CheckFieldLen(objvCoursewareResCase_Resource_RelEN.ftpFileSize, 50, convCoursewareResCase_Resource_Rel.ftpFileSize);
clsCheckSql.CheckFieldLen(objvCoursewareResCase_Resource_RelEN.ftpResourceOwner, 50, convCoursewareResCase_Resource_Rel.ftpResourceOwner);
clsCheckSql.CheckFieldLen(objvCoursewareResCase_Resource_RelEN.FileOriginName, 500, convCoursewareResCase_Resource_Rel.FileOriginName);
clsCheckSql.CheckFieldLen(objvCoursewareResCase_Resource_RelEN.FileNewName, 530, convCoursewareResCase_Resource_Rel.FileNewName);
clsCheckSql.CheckFieldLen(objvCoursewareResCase_Resource_RelEN.FileOldName, 530, convCoursewareResCase_Resource_Rel.FileOldName);
clsCheckSql.CheckFieldLen(objvCoursewareResCase_Resource_RelEN.IdUsingMode, 4, convCoursewareResCase_Resource_Rel.IdUsingMode);
clsCheckSql.CheckFieldLen(objvCoursewareResCase_Resource_RelEN.UpdDate, 20, convCoursewareResCase_Resource_Rel.UpdDate);
clsCheckSql.CheckFieldLen(objvCoursewareResCase_Resource_RelEN.UpdUser, 20, convCoursewareResCase_Resource_Rel.UpdUser);
clsCheckSql.CheckFieldLen(objvCoursewareResCase_Resource_RelEN.Memo, 1000, convCoursewareResCase_Resource_Rel.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCase_Resource_RelEN.FuncModuleId, convCoursewareResCase_Resource_Rel.FuncModuleId);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCase_Resource_RelEN.FuncModuleName, convCoursewareResCase_Resource_Rel.FuncModuleName);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCase_Resource_RelEN.IdMicroteachCase, convCoursewareResCase_Resource_Rel.IdMicroteachCase);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCase_Resource_RelEN.CoursewareResCaseID, convCoursewareResCase_Resource_Rel.CoursewareResCaseID);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCase_Resource_RelEN.CoursewareResCaseName, convCoursewareResCase_Resource_Rel.CoursewareResCaseName);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCase_Resource_RelEN.CoursewareResCaseTheme, convCoursewareResCase_Resource_Rel.CoursewareResCaseTheme);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCase_Resource_RelEN.CoursewareResCaseText, convCoursewareResCase_Resource_Rel.CoursewareResCaseText);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCase_Resource_RelEN.IdCoursewareResCaseType, convCoursewareResCase_Resource_Rel.IdCoursewareResCaseType);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCase_Resource_RelEN.CoursewareResCaseTypeName, convCoursewareResCase_Resource_Rel.CoursewareResCaseTypeName);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCase_Resource_RelEN.CoursewareResCaseDate, convCoursewareResCase_Resource_Rel.CoursewareResCaseDate);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCase_Resource_RelEN.CoursewareResCaseTime, convCoursewareResCase_Resource_Rel.CoursewareResCaseTime);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCase_Resource_RelEN.CoursewareResCaseDateIn, convCoursewareResCase_Resource_Rel.CoursewareResCaseDateIn);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCase_Resource_RelEN.CoursewareResCaseTimeIn, convCoursewareResCase_Resource_Rel.CoursewareResCaseTimeIn);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCase_Resource_RelEN.OwnerId, convCoursewareResCase_Resource_Rel.OwnerId);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCase_Resource_RelEN.OwnerName, convCoursewareResCase_Resource_Rel.OwnerName);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCase_Resource_RelEN.OwnerNameWithId, convCoursewareResCase_Resource_Rel.OwnerNameWithId);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCase_Resource_RelEN.IdStudyLevel, convCoursewareResCase_Resource_Rel.IdStudyLevel);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCase_Resource_RelEN.StudyLevelName, convCoursewareResCase_Resource_Rel.StudyLevelName);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCase_Resource_RelEN.IdTeachingPlan, convCoursewareResCase_Resource_Rel.IdTeachingPlan);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCase_Resource_RelEN.IdDiscipline, convCoursewareResCase_Resource_Rel.IdDiscipline);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCase_Resource_RelEN.DisciplineID, convCoursewareResCase_Resource_Rel.DisciplineID);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCase_Resource_RelEN.DisciplineName, convCoursewareResCase_Resource_Rel.DisciplineName);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCase_Resource_RelEN.senateGaugeVersionID, convCoursewareResCase_Resource_Rel.senateGaugeVersionID);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCase_Resource_RelEN.senateGaugeVersionName, convCoursewareResCase_Resource_Rel.senateGaugeVersionName);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCase_Resource_RelEN.IdTeachSkill, convCoursewareResCase_Resource_Rel.IdTeachSkill);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCase_Resource_RelEN.TeachSkillID, convCoursewareResCase_Resource_Rel.TeachSkillID);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCase_Resource_RelEN.SkillTypeName, convCoursewareResCase_Resource_Rel.SkillTypeName);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCase_Resource_RelEN.TeachSkillName, convCoursewareResCase_Resource_Rel.TeachSkillName);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCase_Resource_RelEN.TeachSkillTheory, convCoursewareResCase_Resource_Rel.TeachSkillTheory);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCase_Resource_RelEN.TeachSkillOperMethod, convCoursewareResCase_Resource_Rel.TeachSkillOperMethod);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCase_Resource_RelEN.IdSkillType, convCoursewareResCase_Resource_Rel.IdSkillType);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCase_Resource_RelEN.SkillTypeID, convCoursewareResCase_Resource_Rel.SkillTypeID);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCase_Resource_RelEN.CaseLevelId, convCoursewareResCase_Resource_Rel.CaseLevelId);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCase_Resource_RelEN.IdXzCollege, convCoursewareResCase_Resource_Rel.IdXzCollege);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCase_Resource_RelEN.CollegeID, convCoursewareResCase_Resource_Rel.CollegeID);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCase_Resource_RelEN.CollegeName, convCoursewareResCase_Resource_Rel.CollegeName);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCase_Resource_RelEN.IdXzMajor, convCoursewareResCase_Resource_Rel.IdXzMajor);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCase_Resource_RelEN.MajorID, convCoursewareResCase_Resource_Rel.MajorID);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCase_Resource_RelEN.MajorName, convCoursewareResCase_Resource_Rel.MajorName);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCase_Resource_RelEN.CourseId, convCoursewareResCase_Resource_Rel.CourseId);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCase_Resource_RelEN.CourseCode, convCoursewareResCase_Resource_Rel.CourseCode);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCase_Resource_RelEN.CourseName, convCoursewareResCase_Resource_Rel.CourseName);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCase_Resource_RelEN.CourseChapterId, convCoursewareResCase_Resource_Rel.CourseChapterId);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCase_Resource_RelEN.CourseChapterName, convCoursewareResCase_Resource_Rel.CourseChapterName);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCase_Resource_RelEN.ParentNodeID, convCoursewareResCase_Resource_Rel.ParentNodeID);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCase_Resource_RelEN.ParentNodeName, convCoursewareResCase_Resource_Rel.ParentNodeName);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCase_Resource_RelEN.RecommendedDegreeId, convCoursewareResCase_Resource_Rel.RecommendedDegreeId);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCase_Resource_RelEN.RecommendedDegreeName, convCoursewareResCase_Resource_Rel.RecommendedDegreeName);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCase_Resource_RelEN.CollegeNameA, convCoursewareResCase_Resource_Rel.CollegeNameA);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCase_Resource_RelEN.IdResource, convCoursewareResCase_Resource_Rel.IdResource);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCase_Resource_RelEN.ResourceID, convCoursewareResCase_Resource_Rel.ResourceID);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCase_Resource_RelEN.ResourceName, convCoursewareResCase_Resource_Rel.ResourceName);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCase_Resource_RelEN.IdFtpResource, convCoursewareResCase_Resource_Rel.IdFtpResource);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCase_Resource_RelEN.IdFile, convCoursewareResCase_Resource_Rel.IdFile);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCase_Resource_RelEN.FileName, convCoursewareResCase_Resource_Rel.FileName);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCase_Resource_RelEN.FileType, convCoursewareResCase_Resource_Rel.FileType);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCase_Resource_RelEN.SaveDate, convCoursewareResCase_Resource_Rel.SaveDate);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCase_Resource_RelEN.FileSize, convCoursewareResCase_Resource_Rel.FileSize);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCase_Resource_RelEN.SaveTime, convCoursewareResCase_Resource_Rel.SaveTime);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCase_Resource_RelEN.FtpResourceID, convCoursewareResCase_Resource_Rel.FtpResourceID);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCase_Resource_RelEN.FileOriginalName, convCoursewareResCase_Resource_Rel.FileOriginalName);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCase_Resource_RelEN.FileDirName, convCoursewareResCase_Resource_Rel.FileDirName);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCase_Resource_RelEN.FileRename, convCoursewareResCase_Resource_Rel.FileRename);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCase_Resource_RelEN.FileUpDate, convCoursewareResCase_Resource_Rel.FileUpDate);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCase_Resource_RelEN.FileUpTime, convCoursewareResCase_Resource_Rel.FileUpTime);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCase_Resource_RelEN.IdResourceType, convCoursewareResCase_Resource_Rel.IdResourceType);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCase_Resource_RelEN.ResourceTypeID, convCoursewareResCase_Resource_Rel.ResourceTypeID);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCase_Resource_RelEN.ResourceTypeName, convCoursewareResCase_Resource_Rel.ResourceTypeName);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCase_Resource_RelEN.ResourceOwner, convCoursewareResCase_Resource_Rel.ResourceOwner);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCase_Resource_RelEN.ftpFileType, convCoursewareResCase_Resource_Rel.ftpFileType);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCase_Resource_RelEN.ftpFileSize, convCoursewareResCase_Resource_Rel.ftpFileSize);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCase_Resource_RelEN.ftpResourceOwner, convCoursewareResCase_Resource_Rel.ftpResourceOwner);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCase_Resource_RelEN.FileOriginName, convCoursewareResCase_Resource_Rel.FileOriginName);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCase_Resource_RelEN.FileNewName, convCoursewareResCase_Resource_Rel.FileNewName);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCase_Resource_RelEN.FileOldName, convCoursewareResCase_Resource_Rel.FileOldName);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCase_Resource_RelEN.IdUsingMode, convCoursewareResCase_Resource_Rel.IdUsingMode);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCase_Resource_RelEN.UpdDate, convCoursewareResCase_Resource_Rel.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCase_Resource_RelEN.UpdUser, convCoursewareResCase_Resource_Rel.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCase_Resource_RelEN.Memo, convCoursewareResCase_Resource_Rel.Memo);
//检查外键字段长度
 objvCoursewareResCase_Resource_RelEN._IsCheckProperty = true;
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
 objSQL = clsvCoursewareResCase_Resource_RelDA.GetSpecSQLObj();
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
 objSQL = clsvCoursewareResCase_Resource_RelDA.GetSpecSQLObj();
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
 objSQL = clsvCoursewareResCase_Resource_RelDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvCoursewareResCase_Resource_RelEN._CurrTabName);
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
 objSQL = clsvCoursewareResCase_Resource_RelDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvCoursewareResCase_Resource_RelEN._CurrTabName, strCondition);
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
 objSQL = clsvCoursewareResCase_Resource_RelDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}