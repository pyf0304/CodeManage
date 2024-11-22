
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvCoursewareResCaseQuantitySenateDA
 表名:vCoursewareResCaseQuantitySenate(01120453)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:46:20
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
 /// v课件资源量化评议(vCoursewareResCaseQuantitySenate)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvCoursewareResCaseQuantitySenateDA : clsCommBase4DA
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
 return clsvCoursewareResCaseQuantitySenateEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvCoursewareResCaseQuantitySenateEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvCoursewareResCaseQuantitySenateEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvCoursewareResCaseQuantitySenateEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvCoursewareResCaseQuantitySenateEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvCoursewareResCaseQuantitySenateDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCoursewareResCaseQuantitySenateDA.GetSpecSQLObj();
strSQL = "Select * from vCoursewareResCaseQuantitySenate where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vCoursewareResCaseQuantitySenate(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvCoursewareResCaseQuantitySenateDA: GetDataTable_vCoursewareResCaseQuantitySenate)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCoursewareResCaseQuantitySenateDA.GetSpecSQLObj();
strSQL = "Select * from vCoursewareResCaseQuantitySenate where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvCoursewareResCaseQuantitySenateDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCoursewareResCaseQuantitySenateDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvCoursewareResCaseQuantitySenateDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCoursewareResCaseQuantitySenateDA.GetSpecSQLObj();
strSQL = "Select * from vCoursewareResCaseQuantitySenate where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvCoursewareResCaseQuantitySenateDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCoursewareResCaseQuantitySenateDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvCoursewareResCaseQuantitySenateDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCoursewareResCaseQuantitySenateDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vCoursewareResCaseQuantitySenate where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vCoursewareResCaseQuantitySenate where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvCoursewareResCaseQuantitySenateDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCoursewareResCaseQuantitySenateDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vCoursewareResCaseQuantitySenate where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvCoursewareResCaseQuantitySenateDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCoursewareResCaseQuantitySenateDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vCoursewareResCaseQuantitySenate.* from vCoursewareResCaseQuantitySenate Left Join {1} on {2} where {3} and vCoursewareResCaseQuantitySenate.IdmicroteachCaseQuantitySenate not in (Select top {5} vCoursewareResCaseQuantitySenate.IdmicroteachCaseQuantitySenate from vCoursewareResCaseQuantitySenate Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vCoursewareResCaseQuantitySenate where {1} and IdmicroteachCaseQuantitySenate not in (Select top {2} IdmicroteachCaseQuantitySenate from vCoursewareResCaseQuantitySenate where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vCoursewareResCaseQuantitySenate where {1} and IdmicroteachCaseQuantitySenate not in (Select top {3} IdmicroteachCaseQuantitySenate from vCoursewareResCaseQuantitySenate where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvCoursewareResCaseQuantitySenateDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCoursewareResCaseQuantitySenateDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vCoursewareResCaseQuantitySenate.* from vCoursewareResCaseQuantitySenate Left Join {1} on {2} where {3} and vCoursewareResCaseQuantitySenate.IdmicroteachCaseQuantitySenate not in (Select top {5} vCoursewareResCaseQuantitySenate.IdmicroteachCaseQuantitySenate from vCoursewareResCaseQuantitySenate Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vCoursewareResCaseQuantitySenate where {1} and IdmicroteachCaseQuantitySenate not in (Select top {2} IdmicroteachCaseQuantitySenate from vCoursewareResCaseQuantitySenate where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vCoursewareResCaseQuantitySenate where {1} and IdmicroteachCaseQuantitySenate not in (Select top {3} IdmicroteachCaseQuantitySenate from vCoursewareResCaseQuantitySenate where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvCoursewareResCaseQuantitySenateEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvCoursewareResCaseQuantitySenateDA:GetObjLst)", objException.Message));
}
List<clsvCoursewareResCaseQuantitySenateEN> arrObjLst = new List<clsvCoursewareResCaseQuantitySenateEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCoursewareResCaseQuantitySenateDA.GetSpecSQLObj();
strSQL = "Select * from vCoursewareResCaseQuantitySenate where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCoursewareResCaseQuantitySenateEN objvCoursewareResCaseQuantitySenateEN = new clsvCoursewareResCaseQuantitySenateEN();
try
{
objvCoursewareResCaseQuantitySenateEN.IdmicroteachCaseQuantitySenate = TransNullToInt(objRow[convCoursewareResCaseQuantitySenate.IdmicroteachCaseQuantitySenate].ToString().Trim()); //微格量化评价流水号
objvCoursewareResCaseQuantitySenateEN.FuncModuleId = objRow[convCoursewareResCaseQuantitySenate.FuncModuleId].ToString().Trim(); //功能模块Id
objvCoursewareResCaseQuantitySenateEN.FuncModuleName = objRow[convCoursewareResCaseQuantitySenate.FuncModuleName] == DBNull.Value ? null : objRow[convCoursewareResCaseQuantitySenate.FuncModuleName].ToString().Trim(); //功能模块名称
objvCoursewareResCaseQuantitySenateEN.IdCoursewareResCase = objRow[convCoursewareResCaseQuantitySenate.IdCoursewareResCase] == DBNull.Value ? null : objRow[convCoursewareResCaseQuantitySenate.IdCoursewareResCase].ToString().Trim(); //课件资源案例流水号
objvCoursewareResCaseQuantitySenateEN.IdMicroteachCase = objRow[convCoursewareResCaseQuantitySenate.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvCoursewareResCaseQuantitySenateEN.CoursewareResCaseID = objRow[convCoursewareResCaseQuantitySenate.CoursewareResCaseID] == DBNull.Value ? null : objRow[convCoursewareResCaseQuantitySenate.CoursewareResCaseID].ToString().Trim(); //课件资源案例ID
objvCoursewareResCaseQuantitySenateEN.CoursewareResCaseName = objRow[convCoursewareResCaseQuantitySenate.CoursewareResCaseName] == DBNull.Value ? null : objRow[convCoursewareResCaseQuantitySenate.CoursewareResCaseName].ToString().Trim(); //课件资源案例名称
objvCoursewareResCaseQuantitySenateEN.CoursewareResCaseTheme = objRow[convCoursewareResCaseQuantitySenate.CoursewareResCaseTheme] == DBNull.Value ? null : objRow[convCoursewareResCaseQuantitySenate.CoursewareResCaseTheme].ToString().Trim(); //课件资源案例主题词
objvCoursewareResCaseQuantitySenateEN.CoursewareResCaseDate = objRow[convCoursewareResCaseQuantitySenate.CoursewareResCaseDate] == DBNull.Value ? null : objRow[convCoursewareResCaseQuantitySenate.CoursewareResCaseDate].ToString().Trim(); //视频资源日期
objvCoursewareResCaseQuantitySenateEN.CoursewareResCaseTime = objRow[convCoursewareResCaseQuantitySenate.CoursewareResCaseTime] == DBNull.Value ? null : objRow[convCoursewareResCaseQuantitySenate.CoursewareResCaseTime].ToString().Trim(); //视频资源时间
objvCoursewareResCaseQuantitySenateEN.CoursewareResCaseDateIn = objRow[convCoursewareResCaseQuantitySenate.CoursewareResCaseDateIn] == DBNull.Value ? null : objRow[convCoursewareResCaseQuantitySenate.CoursewareResCaseDateIn].ToString().Trim(); //案例入库日期
objvCoursewareResCaseQuantitySenateEN.CoursewareResCaseTimeIn = objRow[convCoursewareResCaseQuantitySenate.CoursewareResCaseTimeIn] == DBNull.Value ? null : objRow[convCoursewareResCaseQuantitySenate.CoursewareResCaseTimeIn].ToString().Trim(); //案例入库时间
objvCoursewareResCaseQuantitySenateEN.IdCoursewareResCaseType = objRow[convCoursewareResCaseQuantitySenate.IdCoursewareResCaseType] == DBNull.Value ? null : objRow[convCoursewareResCaseQuantitySenate.IdCoursewareResCaseType].ToString().Trim(); //课件资源类型流水号
objvCoursewareResCaseQuantitySenateEN.CoursewareResCaseTypeName = objRow[convCoursewareResCaseQuantitySenate.CoursewareResCaseTypeName] == DBNull.Value ? null : objRow[convCoursewareResCaseQuantitySenate.CoursewareResCaseTypeName].ToString().Trim(); //课件资源案例类型名称
objvCoursewareResCaseQuantitySenateEN.UserId = objRow[convCoursewareResCaseQuantitySenate.UserId].ToString().Trim(); //用户ID
objvCoursewareResCaseQuantitySenateEN.MajorID = objRow[convCoursewareResCaseQuantitySenate.MajorID] == DBNull.Value ? null : objRow[convCoursewareResCaseQuantitySenate.MajorID].ToString().Trim(); //专业ID
objvCoursewareResCaseQuantitySenateEN.MajorName = objRow[convCoursewareResCaseQuantitySenate.MajorName] == DBNull.Value ? null : objRow[convCoursewareResCaseQuantitySenate.MajorName].ToString().Trim(); //专业名称
objvCoursewareResCaseQuantitySenateEN.IdAppraiseType = objRow[convCoursewareResCaseQuantitySenate.IdAppraiseType].ToString().Trim(); //评议类型流水号
objvCoursewareResCaseQuantitySenateEN.AppraiseTypeName = objRow[convCoursewareResCaseQuantitySenate.AppraiseTypeName] == DBNull.Value ? null : objRow[convCoursewareResCaseQuantitySenate.AppraiseTypeName].ToString().Trim(); //评议类型名称
objvCoursewareResCaseQuantitySenateEN.CollegeID = objRow[convCoursewareResCaseQuantitySenate.CollegeID] == DBNull.Value ? null : objRow[convCoursewareResCaseQuantitySenate.CollegeID].ToString().Trim(); //学院ID
objvCoursewareResCaseQuantitySenateEN.CollegeName = objRow[convCoursewareResCaseQuantitySenate.CollegeName] == DBNull.Value ? null : objRow[convCoursewareResCaseQuantitySenate.CollegeName].ToString().Trim(); //学院名称
objvCoursewareResCaseQuantitySenateEN.CourseId = objRow[convCoursewareResCaseQuantitySenate.CourseId] == DBNull.Value ? null : objRow[convCoursewareResCaseQuantitySenate.CourseId].ToString().Trim(); //课程Id
objvCoursewareResCaseQuantitySenateEN.CourseCode = objRow[convCoursewareResCaseQuantitySenate.CourseCode] == DBNull.Value ? null : objRow[convCoursewareResCaseQuantitySenate.CourseCode].ToString().Trim(); //课程代码
objvCoursewareResCaseQuantitySenateEN.CourseName = objRow[convCoursewareResCaseQuantitySenate.CourseName] == DBNull.Value ? null : objRow[convCoursewareResCaseQuantitySenate.CourseName].ToString().Trim(); //课程名称
objvCoursewareResCaseQuantitySenateEN.BrowseCount = objRow[convCoursewareResCaseQuantitySenate.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCoursewareResCaseQuantitySenate.BrowseCount].ToString().Trim()); //浏览次数
objvCoursewareResCaseQuantitySenateEN.SenateTheme = objRow[convCoursewareResCaseQuantitySenate.SenateTheme] == DBNull.Value ? null : objRow[convCoursewareResCaseQuantitySenate.SenateTheme].ToString().Trim(); //量化评价主题
objvCoursewareResCaseQuantitySenateEN.SenateContent = objRow[convCoursewareResCaseQuantitySenate.SenateContent] == DBNull.Value ? null : objRow[convCoursewareResCaseQuantitySenate.SenateContent].ToString().Trim(); //评价内容
objvCoursewareResCaseQuantitySenateEN.SenateTotalScore = TransNullToFloat(objRow[convCoursewareResCaseQuantitySenate.SenateTotalScore].ToString().Trim()); //评价分数
objvCoursewareResCaseQuantitySenateEN.SenateDate = objRow[convCoursewareResCaseQuantitySenate.SenateDate] == DBNull.Value ? null : objRow[convCoursewareResCaseQuantitySenate.SenateDate].ToString().Trim(); //评价日期
objvCoursewareResCaseQuantitySenateEN.SenateTime = objRow[convCoursewareResCaseQuantitySenate.SenateTime] == DBNull.Value ? null : objRow[convCoursewareResCaseQuantitySenate.SenateTime].ToString().Trim(); //评价时间
objvCoursewareResCaseQuantitySenateEN.IdSenateGaugeVersion = objRow[convCoursewareResCaseQuantitySenate.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvCoursewareResCaseQuantitySenateEN.senateGaugeVersionID = objRow[convCoursewareResCaseQuantitySenate.senateGaugeVersionID] == DBNull.Value ? null : objRow[convCoursewareResCaseQuantitySenate.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvCoursewareResCaseQuantitySenateEN.senateGaugeVersionName = objRow[convCoursewareResCaseQuantitySenate.senateGaugeVersionName] == DBNull.Value ? null : objRow[convCoursewareResCaseQuantitySenate.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvCoursewareResCaseQuantitySenateEN.senateGaugeVersionTtlScore = objRow[convCoursewareResCaseQuantitySenate.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convCoursewareResCaseQuantitySenate.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvCoursewareResCaseQuantitySenateEN.UpdUserName = objRow[convCoursewareResCaseQuantitySenate.UpdUserName] == DBNull.Value ? null : objRow[convCoursewareResCaseQuantitySenate.UpdUserName].ToString().Trim(); //UpdUserName
objvCoursewareResCaseQuantitySenateEN.SenateIp = objRow[convCoursewareResCaseQuantitySenate.SenateIp].ToString().Trim(); //评议Ip
objvCoursewareResCaseQuantitySenateEN.UserTypeName = objRow[convCoursewareResCaseQuantitySenate.UserTypeName] == DBNull.Value ? null : objRow[convCoursewareResCaseQuantitySenate.UserTypeName].ToString().Trim(); //用户类型名称
objvCoursewareResCaseQuantitySenateEN.UserName = objRow[convCoursewareResCaseQuantitySenate.UserName].ToString().Trim(); //用户名
objvCoursewareResCaseQuantitySenateEN.UserNameWithUserId = objRow[convCoursewareResCaseQuantitySenate.UserNameWithUserId] == DBNull.Value ? null : objRow[convCoursewareResCaseQuantitySenate.UserNameWithUserId].ToString().Trim(); //UserNameWithUserId
objvCoursewareResCaseQuantitySenateEN.IsDualVideo = TransNullToBool(objRow[convCoursewareResCaseQuantitySenate.IsDualVideo].ToString().Trim()); //是否双视频
objvCoursewareResCaseQuantitySenateEN.UserKindId = objRow[convCoursewareResCaseQuantitySenate.UserKindId].ToString().Trim(); //用户类别Id
objvCoursewareResCaseQuantitySenateEN.UserKindName = objRow[convCoursewareResCaseQuantitySenate.UserKindName] == DBNull.Value ? null : objRow[convCoursewareResCaseQuantitySenate.UserKindName].ToString().Trim(); //用户类别名
objvCoursewareResCaseQuantitySenateEN.ViewCount = objRow[convCoursewareResCaseQuantitySenate.ViewCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCoursewareResCaseQuantitySenate.ViewCount].ToString().Trim()); //浏览量
objvCoursewareResCaseQuantitySenateEN.IsShow = TransNullToBool(objRow[convCoursewareResCaseQuantitySenate.IsShow].ToString().Trim()); //是否启用
objvCoursewareResCaseQuantitySenateEN.DownloadNumber = objRow[convCoursewareResCaseQuantitySenate.DownloadNumber] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCoursewareResCaseQuantitySenate.DownloadNumber].ToString().Trim()); //下载数目
objvCoursewareResCaseQuantitySenateEN.FileIntegration = objRow[convCoursewareResCaseQuantitySenate.FileIntegration] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCoursewareResCaseQuantitySenate.FileIntegration].ToString().Trim()); //文件积分
objvCoursewareResCaseQuantitySenateEN.LikeCount = objRow[convCoursewareResCaseQuantitySenate.LikeCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convCoursewareResCaseQuantitySenate.LikeCount].ToString().Trim()); //资源喜欢数量
objvCoursewareResCaseQuantitySenateEN.CollectionCount = objRow[convCoursewareResCaseQuantitySenate.CollectionCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convCoursewareResCaseQuantitySenate.CollectionCount].ToString().Trim()); //收藏数量
objvCoursewareResCaseQuantitySenateEN.UpdUser = objRow[convCoursewareResCaseQuantitySenate.UpdUser] == DBNull.Value ? null : objRow[convCoursewareResCaseQuantitySenate.UpdUser].ToString().Trim(); //修改人
objvCoursewareResCaseQuantitySenateEN.Memo = objRow[convCoursewareResCaseQuantitySenate.Memo] == DBNull.Value ? null : objRow[convCoursewareResCaseQuantitySenate.Memo].ToString().Trim(); //备注
objvCoursewareResCaseQuantitySenateEN.OwnerId = objRow[convCoursewareResCaseQuantitySenate.OwnerId] == DBNull.Value ? null : objRow[convCoursewareResCaseQuantitySenate.OwnerId].ToString().Trim(); //拥有者Id
objvCoursewareResCaseQuantitySenateEN.OwnerName = objRow[convCoursewareResCaseQuantitySenate.OwnerName] == DBNull.Value ? null : objRow[convCoursewareResCaseQuantitySenate.OwnerName].ToString().Trim(); //拥有者姓名
objvCoursewareResCaseQuantitySenateEN.OwnerNameWithId = objRow[convCoursewareResCaseQuantitySenate.OwnerNameWithId] == DBNull.Value ? null : objRow[convCoursewareResCaseQuantitySenate.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvCoursewareResCaseQuantitySenateEN.IdXzCollege = objRow[convCoursewareResCaseQuantitySenate.IdXzCollege] == DBNull.Value ? null : objRow[convCoursewareResCaseQuantitySenate.IdXzCollege].ToString().Trim(); //学院流水号
objvCoursewareResCaseQuantitySenateEN.IdXzMajor = objRow[convCoursewareResCaseQuantitySenate.IdXzMajor] == DBNull.Value ? null : objRow[convCoursewareResCaseQuantitySenate.IdXzMajor].ToString().Trim(); //专业流水号
objvCoursewareResCaseQuantitySenateEN.CollegeNameA = objRow[convCoursewareResCaseQuantitySenate.CollegeNameA] == DBNull.Value ? null : objRow[convCoursewareResCaseQuantitySenate.CollegeNameA].ToString().Trim(); //学院名称简写
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvCoursewareResCaseQuantitySenateDA: GetObjLst)", objException.Message));
}
objvCoursewareResCaseQuantitySenateEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvCoursewareResCaseQuantitySenateEN);
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
public List<clsvCoursewareResCaseQuantitySenateEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvCoursewareResCaseQuantitySenateDA:GetObjLstByTabName)", objException.Message));
}
List<clsvCoursewareResCaseQuantitySenateEN> arrObjLst = new List<clsvCoursewareResCaseQuantitySenateEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCoursewareResCaseQuantitySenateDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCoursewareResCaseQuantitySenateEN objvCoursewareResCaseQuantitySenateEN = new clsvCoursewareResCaseQuantitySenateEN();
try
{
objvCoursewareResCaseQuantitySenateEN.IdmicroteachCaseQuantitySenate = TransNullToInt(objRow[convCoursewareResCaseQuantitySenate.IdmicroteachCaseQuantitySenate].ToString().Trim()); //微格量化评价流水号
objvCoursewareResCaseQuantitySenateEN.FuncModuleId = objRow[convCoursewareResCaseQuantitySenate.FuncModuleId].ToString().Trim(); //功能模块Id
objvCoursewareResCaseQuantitySenateEN.FuncModuleName = objRow[convCoursewareResCaseQuantitySenate.FuncModuleName] == DBNull.Value ? null : objRow[convCoursewareResCaseQuantitySenate.FuncModuleName].ToString().Trim(); //功能模块名称
objvCoursewareResCaseQuantitySenateEN.IdCoursewareResCase = objRow[convCoursewareResCaseQuantitySenate.IdCoursewareResCase] == DBNull.Value ? null : objRow[convCoursewareResCaseQuantitySenate.IdCoursewareResCase].ToString().Trim(); //课件资源案例流水号
objvCoursewareResCaseQuantitySenateEN.IdMicroteachCase = objRow[convCoursewareResCaseQuantitySenate.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvCoursewareResCaseQuantitySenateEN.CoursewareResCaseID = objRow[convCoursewareResCaseQuantitySenate.CoursewareResCaseID] == DBNull.Value ? null : objRow[convCoursewareResCaseQuantitySenate.CoursewareResCaseID].ToString().Trim(); //课件资源案例ID
objvCoursewareResCaseQuantitySenateEN.CoursewareResCaseName = objRow[convCoursewareResCaseQuantitySenate.CoursewareResCaseName] == DBNull.Value ? null : objRow[convCoursewareResCaseQuantitySenate.CoursewareResCaseName].ToString().Trim(); //课件资源案例名称
objvCoursewareResCaseQuantitySenateEN.CoursewareResCaseTheme = objRow[convCoursewareResCaseQuantitySenate.CoursewareResCaseTheme] == DBNull.Value ? null : objRow[convCoursewareResCaseQuantitySenate.CoursewareResCaseTheme].ToString().Trim(); //课件资源案例主题词
objvCoursewareResCaseQuantitySenateEN.CoursewareResCaseDate = objRow[convCoursewareResCaseQuantitySenate.CoursewareResCaseDate] == DBNull.Value ? null : objRow[convCoursewareResCaseQuantitySenate.CoursewareResCaseDate].ToString().Trim(); //视频资源日期
objvCoursewareResCaseQuantitySenateEN.CoursewareResCaseTime = objRow[convCoursewareResCaseQuantitySenate.CoursewareResCaseTime] == DBNull.Value ? null : objRow[convCoursewareResCaseQuantitySenate.CoursewareResCaseTime].ToString().Trim(); //视频资源时间
objvCoursewareResCaseQuantitySenateEN.CoursewareResCaseDateIn = objRow[convCoursewareResCaseQuantitySenate.CoursewareResCaseDateIn] == DBNull.Value ? null : objRow[convCoursewareResCaseQuantitySenate.CoursewareResCaseDateIn].ToString().Trim(); //案例入库日期
objvCoursewareResCaseQuantitySenateEN.CoursewareResCaseTimeIn = objRow[convCoursewareResCaseQuantitySenate.CoursewareResCaseTimeIn] == DBNull.Value ? null : objRow[convCoursewareResCaseQuantitySenate.CoursewareResCaseTimeIn].ToString().Trim(); //案例入库时间
objvCoursewareResCaseQuantitySenateEN.IdCoursewareResCaseType = objRow[convCoursewareResCaseQuantitySenate.IdCoursewareResCaseType] == DBNull.Value ? null : objRow[convCoursewareResCaseQuantitySenate.IdCoursewareResCaseType].ToString().Trim(); //课件资源类型流水号
objvCoursewareResCaseQuantitySenateEN.CoursewareResCaseTypeName = objRow[convCoursewareResCaseQuantitySenate.CoursewareResCaseTypeName] == DBNull.Value ? null : objRow[convCoursewareResCaseQuantitySenate.CoursewareResCaseTypeName].ToString().Trim(); //课件资源案例类型名称
objvCoursewareResCaseQuantitySenateEN.UserId = objRow[convCoursewareResCaseQuantitySenate.UserId].ToString().Trim(); //用户ID
objvCoursewareResCaseQuantitySenateEN.MajorID = objRow[convCoursewareResCaseQuantitySenate.MajorID] == DBNull.Value ? null : objRow[convCoursewareResCaseQuantitySenate.MajorID].ToString().Trim(); //专业ID
objvCoursewareResCaseQuantitySenateEN.MajorName = objRow[convCoursewareResCaseQuantitySenate.MajorName] == DBNull.Value ? null : objRow[convCoursewareResCaseQuantitySenate.MajorName].ToString().Trim(); //专业名称
objvCoursewareResCaseQuantitySenateEN.IdAppraiseType = objRow[convCoursewareResCaseQuantitySenate.IdAppraiseType].ToString().Trim(); //评议类型流水号
objvCoursewareResCaseQuantitySenateEN.AppraiseTypeName = objRow[convCoursewareResCaseQuantitySenate.AppraiseTypeName] == DBNull.Value ? null : objRow[convCoursewareResCaseQuantitySenate.AppraiseTypeName].ToString().Trim(); //评议类型名称
objvCoursewareResCaseQuantitySenateEN.CollegeID = objRow[convCoursewareResCaseQuantitySenate.CollegeID] == DBNull.Value ? null : objRow[convCoursewareResCaseQuantitySenate.CollegeID].ToString().Trim(); //学院ID
objvCoursewareResCaseQuantitySenateEN.CollegeName = objRow[convCoursewareResCaseQuantitySenate.CollegeName] == DBNull.Value ? null : objRow[convCoursewareResCaseQuantitySenate.CollegeName].ToString().Trim(); //学院名称
objvCoursewareResCaseQuantitySenateEN.CourseId = objRow[convCoursewareResCaseQuantitySenate.CourseId] == DBNull.Value ? null : objRow[convCoursewareResCaseQuantitySenate.CourseId].ToString().Trim(); //课程Id
objvCoursewareResCaseQuantitySenateEN.CourseCode = objRow[convCoursewareResCaseQuantitySenate.CourseCode] == DBNull.Value ? null : objRow[convCoursewareResCaseQuantitySenate.CourseCode].ToString().Trim(); //课程代码
objvCoursewareResCaseQuantitySenateEN.CourseName = objRow[convCoursewareResCaseQuantitySenate.CourseName] == DBNull.Value ? null : objRow[convCoursewareResCaseQuantitySenate.CourseName].ToString().Trim(); //课程名称
objvCoursewareResCaseQuantitySenateEN.BrowseCount = objRow[convCoursewareResCaseQuantitySenate.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCoursewareResCaseQuantitySenate.BrowseCount].ToString().Trim()); //浏览次数
objvCoursewareResCaseQuantitySenateEN.SenateTheme = objRow[convCoursewareResCaseQuantitySenate.SenateTheme] == DBNull.Value ? null : objRow[convCoursewareResCaseQuantitySenate.SenateTheme].ToString().Trim(); //量化评价主题
objvCoursewareResCaseQuantitySenateEN.SenateContent = objRow[convCoursewareResCaseQuantitySenate.SenateContent] == DBNull.Value ? null : objRow[convCoursewareResCaseQuantitySenate.SenateContent].ToString().Trim(); //评价内容
objvCoursewareResCaseQuantitySenateEN.SenateTotalScore = TransNullToFloat(objRow[convCoursewareResCaseQuantitySenate.SenateTotalScore].ToString().Trim()); //评价分数
objvCoursewareResCaseQuantitySenateEN.SenateDate = objRow[convCoursewareResCaseQuantitySenate.SenateDate] == DBNull.Value ? null : objRow[convCoursewareResCaseQuantitySenate.SenateDate].ToString().Trim(); //评价日期
objvCoursewareResCaseQuantitySenateEN.SenateTime = objRow[convCoursewareResCaseQuantitySenate.SenateTime] == DBNull.Value ? null : objRow[convCoursewareResCaseQuantitySenate.SenateTime].ToString().Trim(); //评价时间
objvCoursewareResCaseQuantitySenateEN.IdSenateGaugeVersion = objRow[convCoursewareResCaseQuantitySenate.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvCoursewareResCaseQuantitySenateEN.senateGaugeVersionID = objRow[convCoursewareResCaseQuantitySenate.senateGaugeVersionID] == DBNull.Value ? null : objRow[convCoursewareResCaseQuantitySenate.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvCoursewareResCaseQuantitySenateEN.senateGaugeVersionName = objRow[convCoursewareResCaseQuantitySenate.senateGaugeVersionName] == DBNull.Value ? null : objRow[convCoursewareResCaseQuantitySenate.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvCoursewareResCaseQuantitySenateEN.senateGaugeVersionTtlScore = objRow[convCoursewareResCaseQuantitySenate.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convCoursewareResCaseQuantitySenate.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvCoursewareResCaseQuantitySenateEN.UpdUserName = objRow[convCoursewareResCaseQuantitySenate.UpdUserName] == DBNull.Value ? null : objRow[convCoursewareResCaseQuantitySenate.UpdUserName].ToString().Trim(); //UpdUserName
objvCoursewareResCaseQuantitySenateEN.SenateIp = objRow[convCoursewareResCaseQuantitySenate.SenateIp].ToString().Trim(); //评议Ip
objvCoursewareResCaseQuantitySenateEN.UserTypeName = objRow[convCoursewareResCaseQuantitySenate.UserTypeName] == DBNull.Value ? null : objRow[convCoursewareResCaseQuantitySenate.UserTypeName].ToString().Trim(); //用户类型名称
objvCoursewareResCaseQuantitySenateEN.UserName = objRow[convCoursewareResCaseQuantitySenate.UserName].ToString().Trim(); //用户名
objvCoursewareResCaseQuantitySenateEN.UserNameWithUserId = objRow[convCoursewareResCaseQuantitySenate.UserNameWithUserId] == DBNull.Value ? null : objRow[convCoursewareResCaseQuantitySenate.UserNameWithUserId].ToString().Trim(); //UserNameWithUserId
objvCoursewareResCaseQuantitySenateEN.IsDualVideo = TransNullToBool(objRow[convCoursewareResCaseQuantitySenate.IsDualVideo].ToString().Trim()); //是否双视频
objvCoursewareResCaseQuantitySenateEN.UserKindId = objRow[convCoursewareResCaseQuantitySenate.UserKindId].ToString().Trim(); //用户类别Id
objvCoursewareResCaseQuantitySenateEN.UserKindName = objRow[convCoursewareResCaseQuantitySenate.UserKindName] == DBNull.Value ? null : objRow[convCoursewareResCaseQuantitySenate.UserKindName].ToString().Trim(); //用户类别名
objvCoursewareResCaseQuantitySenateEN.ViewCount = objRow[convCoursewareResCaseQuantitySenate.ViewCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCoursewareResCaseQuantitySenate.ViewCount].ToString().Trim()); //浏览量
objvCoursewareResCaseQuantitySenateEN.IsShow = TransNullToBool(objRow[convCoursewareResCaseQuantitySenate.IsShow].ToString().Trim()); //是否启用
objvCoursewareResCaseQuantitySenateEN.DownloadNumber = objRow[convCoursewareResCaseQuantitySenate.DownloadNumber] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCoursewareResCaseQuantitySenate.DownloadNumber].ToString().Trim()); //下载数目
objvCoursewareResCaseQuantitySenateEN.FileIntegration = objRow[convCoursewareResCaseQuantitySenate.FileIntegration] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCoursewareResCaseQuantitySenate.FileIntegration].ToString().Trim()); //文件积分
objvCoursewareResCaseQuantitySenateEN.LikeCount = objRow[convCoursewareResCaseQuantitySenate.LikeCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convCoursewareResCaseQuantitySenate.LikeCount].ToString().Trim()); //资源喜欢数量
objvCoursewareResCaseQuantitySenateEN.CollectionCount = objRow[convCoursewareResCaseQuantitySenate.CollectionCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convCoursewareResCaseQuantitySenate.CollectionCount].ToString().Trim()); //收藏数量
objvCoursewareResCaseQuantitySenateEN.UpdUser = objRow[convCoursewareResCaseQuantitySenate.UpdUser] == DBNull.Value ? null : objRow[convCoursewareResCaseQuantitySenate.UpdUser].ToString().Trim(); //修改人
objvCoursewareResCaseQuantitySenateEN.Memo = objRow[convCoursewareResCaseQuantitySenate.Memo] == DBNull.Value ? null : objRow[convCoursewareResCaseQuantitySenate.Memo].ToString().Trim(); //备注
objvCoursewareResCaseQuantitySenateEN.OwnerId = objRow[convCoursewareResCaseQuantitySenate.OwnerId] == DBNull.Value ? null : objRow[convCoursewareResCaseQuantitySenate.OwnerId].ToString().Trim(); //拥有者Id
objvCoursewareResCaseQuantitySenateEN.OwnerName = objRow[convCoursewareResCaseQuantitySenate.OwnerName] == DBNull.Value ? null : objRow[convCoursewareResCaseQuantitySenate.OwnerName].ToString().Trim(); //拥有者姓名
objvCoursewareResCaseQuantitySenateEN.OwnerNameWithId = objRow[convCoursewareResCaseQuantitySenate.OwnerNameWithId] == DBNull.Value ? null : objRow[convCoursewareResCaseQuantitySenate.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvCoursewareResCaseQuantitySenateEN.IdXzCollege = objRow[convCoursewareResCaseQuantitySenate.IdXzCollege] == DBNull.Value ? null : objRow[convCoursewareResCaseQuantitySenate.IdXzCollege].ToString().Trim(); //学院流水号
objvCoursewareResCaseQuantitySenateEN.IdXzMajor = objRow[convCoursewareResCaseQuantitySenate.IdXzMajor] == DBNull.Value ? null : objRow[convCoursewareResCaseQuantitySenate.IdXzMajor].ToString().Trim(); //专业流水号
objvCoursewareResCaseQuantitySenateEN.CollegeNameA = objRow[convCoursewareResCaseQuantitySenate.CollegeNameA] == DBNull.Value ? null : objRow[convCoursewareResCaseQuantitySenate.CollegeNameA].ToString().Trim(); //学院名称简写
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvCoursewareResCaseQuantitySenateDA: GetObjLst)", objException.Message));
}
objvCoursewareResCaseQuantitySenateEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvCoursewareResCaseQuantitySenateEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvCoursewareResCaseQuantitySenateEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvCoursewareResCaseQuantitySenate(ref clsvCoursewareResCaseQuantitySenateEN objvCoursewareResCaseQuantitySenateEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCoursewareResCaseQuantitySenateDA.GetSpecSQLObj();
strSQL = "Select * from vCoursewareResCaseQuantitySenate where IdmicroteachCaseQuantitySenate = " + ""+ objvCoursewareResCaseQuantitySenateEN.IdmicroteachCaseQuantitySenate+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvCoursewareResCaseQuantitySenateEN.IdmicroteachCaseQuantitySenate = TransNullToInt(objDT.Rows[0][convCoursewareResCaseQuantitySenate.IdmicroteachCaseQuantitySenate].ToString().Trim()); //微格量化评价流水号(字段类型:bigint,字段长度:8,是否可空:False)
 objvCoursewareResCaseQuantitySenateEN.FuncModuleId = objDT.Rows[0][convCoursewareResCaseQuantitySenate.FuncModuleId].ToString().Trim(); //功能模块Id(字段类型:char,字段长度:4,是否可空:True)
 objvCoursewareResCaseQuantitySenateEN.FuncModuleName = objDT.Rows[0][convCoursewareResCaseQuantitySenate.FuncModuleName].ToString().Trim(); //功能模块名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvCoursewareResCaseQuantitySenateEN.IdCoursewareResCase = objDT.Rows[0][convCoursewareResCaseQuantitySenate.IdCoursewareResCase].ToString().Trim(); //课件资源案例流水号(字段类型:char,字段长度:8,是否可空:False)
 objvCoursewareResCaseQuantitySenateEN.IdMicroteachCase = objDT.Rows[0][convCoursewareResCaseQuantitySenate.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号(字段类型:char,字段长度:8,是否可空:False)
 objvCoursewareResCaseQuantitySenateEN.CoursewareResCaseID = objDT.Rows[0][convCoursewareResCaseQuantitySenate.CoursewareResCaseID].ToString().Trim(); //课件资源案例ID(字段类型:char,字段长度:8,是否可空:False)
 objvCoursewareResCaseQuantitySenateEN.CoursewareResCaseName = objDT.Rows[0][convCoursewareResCaseQuantitySenate.CoursewareResCaseName].ToString().Trim(); //课件资源案例名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvCoursewareResCaseQuantitySenateEN.CoursewareResCaseTheme = objDT.Rows[0][convCoursewareResCaseQuantitySenate.CoursewareResCaseTheme].ToString().Trim(); //课件资源案例主题词(字段类型:varchar,字段长度:200,是否可空:True)
 objvCoursewareResCaseQuantitySenateEN.CoursewareResCaseDate = objDT.Rows[0][convCoursewareResCaseQuantitySenate.CoursewareResCaseDate].ToString().Trim(); //视频资源日期(字段类型:char,字段长度:8,是否可空:True)
 objvCoursewareResCaseQuantitySenateEN.CoursewareResCaseTime = objDT.Rows[0][convCoursewareResCaseQuantitySenate.CoursewareResCaseTime].ToString().Trim(); //视频资源时间(字段类型:char,字段长度:6,是否可空:True)
 objvCoursewareResCaseQuantitySenateEN.CoursewareResCaseDateIn = objDT.Rows[0][convCoursewareResCaseQuantitySenate.CoursewareResCaseDateIn].ToString().Trim(); //案例入库日期(字段类型:char,字段长度:8,是否可空:True)
 objvCoursewareResCaseQuantitySenateEN.CoursewareResCaseTimeIn = objDT.Rows[0][convCoursewareResCaseQuantitySenate.CoursewareResCaseTimeIn].ToString().Trim(); //案例入库时间(字段类型:char,字段长度:6,是否可空:True)
 objvCoursewareResCaseQuantitySenateEN.IdCoursewareResCaseType = objDT.Rows[0][convCoursewareResCaseQuantitySenate.IdCoursewareResCaseType].ToString().Trim(); //课件资源类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvCoursewareResCaseQuantitySenateEN.CoursewareResCaseTypeName = objDT.Rows[0][convCoursewareResCaseQuantitySenate.CoursewareResCaseTypeName].ToString().Trim(); //课件资源案例类型名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvCoursewareResCaseQuantitySenateEN.UserId = objDT.Rows[0][convCoursewareResCaseQuantitySenate.UserId].ToString().Trim(); //用户ID(字段类型:varchar,字段长度:18,是否可空:True)
 objvCoursewareResCaseQuantitySenateEN.MajorID = objDT.Rows[0][convCoursewareResCaseQuantitySenate.MajorID].ToString().Trim(); //专业ID(字段类型:char,字段长度:4,是否可空:False)
 objvCoursewareResCaseQuantitySenateEN.MajorName = objDT.Rows[0][convCoursewareResCaseQuantitySenate.MajorName].ToString().Trim(); //专业名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvCoursewareResCaseQuantitySenateEN.IdAppraiseType = objDT.Rows[0][convCoursewareResCaseQuantitySenate.IdAppraiseType].ToString().Trim(); //评议类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvCoursewareResCaseQuantitySenateEN.AppraiseTypeName = objDT.Rows[0][convCoursewareResCaseQuantitySenate.AppraiseTypeName].ToString().Trim(); //评议类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvCoursewareResCaseQuantitySenateEN.CollegeID = objDT.Rows[0][convCoursewareResCaseQuantitySenate.CollegeID].ToString().Trim(); //学院ID(字段类型:varchar,字段长度:4,是否可空:False)
 objvCoursewareResCaseQuantitySenateEN.CollegeName = objDT.Rows[0][convCoursewareResCaseQuantitySenate.CollegeName].ToString().Trim(); //学院名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvCoursewareResCaseQuantitySenateEN.CourseId = objDT.Rows[0][convCoursewareResCaseQuantitySenate.CourseId].ToString().Trim(); //课程Id(字段类型:char,字段长度:8,是否可空:True)
 objvCoursewareResCaseQuantitySenateEN.CourseCode = objDT.Rows[0][convCoursewareResCaseQuantitySenate.CourseCode].ToString().Trim(); //课程代码(字段类型:varchar,字段长度:20,是否可空:True)
 objvCoursewareResCaseQuantitySenateEN.CourseName = objDT.Rows[0][convCoursewareResCaseQuantitySenate.CourseName].ToString().Trim(); //课程名称(字段类型:varchar,字段长度:100,是否可空:True)
 objvCoursewareResCaseQuantitySenateEN.BrowseCount = TransNullToInt(objDT.Rows[0][convCoursewareResCaseQuantitySenate.BrowseCount].ToString().Trim()); //浏览次数(字段类型:int,字段长度:4,是否可空:True)
 objvCoursewareResCaseQuantitySenateEN.SenateTheme = objDT.Rows[0][convCoursewareResCaseQuantitySenate.SenateTheme].ToString().Trim(); //量化评价主题(字段类型:varchar,字段长度:200,是否可空:True)
 objvCoursewareResCaseQuantitySenateEN.SenateContent = objDT.Rows[0][convCoursewareResCaseQuantitySenate.SenateContent].ToString().Trim(); //评价内容(字段类型:varchar,字段长度:2000,是否可空:True)
 objvCoursewareResCaseQuantitySenateEN.SenateTotalScore = TransNullToFloat(objDT.Rows[0][convCoursewareResCaseQuantitySenate.SenateTotalScore].ToString().Trim()); //评价分数(字段类型:float,字段长度:8,是否可空:False)
 objvCoursewareResCaseQuantitySenateEN.SenateDate = objDT.Rows[0][convCoursewareResCaseQuantitySenate.SenateDate].ToString().Trim(); //评价日期(字段类型:char,字段长度:8,是否可空:True)
 objvCoursewareResCaseQuantitySenateEN.SenateTime = objDT.Rows[0][convCoursewareResCaseQuantitySenate.SenateTime].ToString().Trim(); //评价时间(字段类型:char,字段长度:6,是否可空:True)
 objvCoursewareResCaseQuantitySenateEN.IdSenateGaugeVersion = objDT.Rows[0][convCoursewareResCaseQuantitySenate.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号(字段类型:char,字段长度:4,是否可空:False)
 objvCoursewareResCaseQuantitySenateEN.senateGaugeVersionID = objDT.Rows[0][convCoursewareResCaseQuantitySenate.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID(字段类型:char,字段长度:4,是否可空:False)
 objvCoursewareResCaseQuantitySenateEN.senateGaugeVersionName = objDT.Rows[0][convCoursewareResCaseQuantitySenate.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称(字段类型:varchar,字段长度:200,是否可空:True)
 objvCoursewareResCaseQuantitySenateEN.senateGaugeVersionTtlScore = TransNullToFloat(objDT.Rows[0][convCoursewareResCaseQuantitySenate.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分(字段类型:float,字段长度:8,是否可空:False)
 objvCoursewareResCaseQuantitySenateEN.UpdUserName = objDT.Rows[0][convCoursewareResCaseQuantitySenate.UpdUserName].ToString().Trim(); //UpdUserName(字段类型:varchar,字段长度:20,是否可空:True)
 objvCoursewareResCaseQuantitySenateEN.SenateIp = objDT.Rows[0][convCoursewareResCaseQuantitySenate.SenateIp].ToString().Trim(); //评议Ip(字段类型:varchar,字段长度:50,是否可空:True)
 objvCoursewareResCaseQuantitySenateEN.UserTypeName = objDT.Rows[0][convCoursewareResCaseQuantitySenate.UserTypeName].ToString().Trim(); //用户类型名称(字段类型:varchar,字段长度:20,是否可空:True)
 objvCoursewareResCaseQuantitySenateEN.UserName = objDT.Rows[0][convCoursewareResCaseQuantitySenate.UserName].ToString().Trim(); //用户名(字段类型:varchar,字段长度:30,是否可空:True)
 objvCoursewareResCaseQuantitySenateEN.UserNameWithUserId = objDT.Rows[0][convCoursewareResCaseQuantitySenate.UserNameWithUserId].ToString().Trim(); //UserNameWithUserId(字段类型:varchar,字段长度:51,是否可空:False)
 objvCoursewareResCaseQuantitySenateEN.IsDualVideo = TransNullToBool(objDT.Rows[0][convCoursewareResCaseQuantitySenate.IsDualVideo].ToString().Trim()); //是否双视频(字段类型:bit,字段长度:1,是否可空:False)
 objvCoursewareResCaseQuantitySenateEN.UserKindId = objDT.Rows[0][convCoursewareResCaseQuantitySenate.UserKindId].ToString().Trim(); //用户类别Id(字段类型:char,字段长度:2,是否可空:False)
 objvCoursewareResCaseQuantitySenateEN.UserKindName = objDT.Rows[0][convCoursewareResCaseQuantitySenate.UserKindName].ToString().Trim(); //用户类别名(字段类型:varchar,字段长度:30,是否可空:False)
 objvCoursewareResCaseQuantitySenateEN.ViewCount = TransNullToInt(objDT.Rows[0][convCoursewareResCaseQuantitySenate.ViewCount].ToString().Trim()); //浏览量(字段类型:int,字段长度:4,是否可空:True)
 objvCoursewareResCaseQuantitySenateEN.IsShow = TransNullToBool(objDT.Rows[0][convCoursewareResCaseQuantitySenate.IsShow].ToString().Trim()); //是否启用(字段类型:bit,字段长度:1,是否可空:True)
 objvCoursewareResCaseQuantitySenateEN.DownloadNumber = TransNullToInt(objDT.Rows[0][convCoursewareResCaseQuantitySenate.DownloadNumber].ToString().Trim()); //下载数目(字段类型:int,字段长度:4,是否可空:True)
 objvCoursewareResCaseQuantitySenateEN.FileIntegration = TransNullToInt(objDT.Rows[0][convCoursewareResCaseQuantitySenate.FileIntegration].ToString().Trim()); //文件积分(字段类型:int,字段长度:4,是否可空:True)
 objvCoursewareResCaseQuantitySenateEN.LikeCount = TransNullToInt(objDT.Rows[0][convCoursewareResCaseQuantitySenate.LikeCount].ToString().Trim()); //资源喜欢数量(字段类型:bigint,字段长度:8,是否可空:True)
 objvCoursewareResCaseQuantitySenateEN.CollectionCount = TransNullToInt(objDT.Rows[0][convCoursewareResCaseQuantitySenate.CollectionCount].ToString().Trim()); //收藏数量(字段类型:bigint,字段长度:8,是否可空:True)
 objvCoursewareResCaseQuantitySenateEN.UpdUser = objDT.Rows[0][convCoursewareResCaseQuantitySenate.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objvCoursewareResCaseQuantitySenateEN.Memo = objDT.Rows[0][convCoursewareResCaseQuantitySenate.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvCoursewareResCaseQuantitySenateEN.OwnerId = objDT.Rows[0][convCoursewareResCaseQuantitySenate.OwnerId].ToString().Trim(); //拥有者Id(字段类型:varchar,字段长度:20,是否可空:False)
 objvCoursewareResCaseQuantitySenateEN.OwnerName = objDT.Rows[0][convCoursewareResCaseQuantitySenate.OwnerName].ToString().Trim(); //拥有者姓名(字段类型:varchar,字段长度:30,是否可空:True)
 objvCoursewareResCaseQuantitySenateEN.OwnerNameWithId = objDT.Rows[0][convCoursewareResCaseQuantitySenate.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id(字段类型:varchar,字段长度:51,是否可空:True)
 objvCoursewareResCaseQuantitySenateEN.IdXzCollege = objDT.Rows[0][convCoursewareResCaseQuantitySenate.IdXzCollege].ToString().Trim(); //学院流水号(字段类型:char,字段长度:4,是否可空:True)
 objvCoursewareResCaseQuantitySenateEN.IdXzMajor = objDT.Rows[0][convCoursewareResCaseQuantitySenate.IdXzMajor].ToString().Trim(); //专业流水号(字段类型:char,字段长度:8,是否可空:False)
 objvCoursewareResCaseQuantitySenateEN.CollegeNameA = objDT.Rows[0][convCoursewareResCaseQuantitySenate.CollegeNameA].ToString().Trim(); //学院名称简写(字段类型:varchar,字段长度:12,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvCoursewareResCaseQuantitySenateDA: GetvCoursewareResCaseQuantitySenate)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngIdmicroteachCaseQuantitySenate">表关键字</param>
 /// <returns>表对象</returns>
public clsvCoursewareResCaseQuantitySenateEN GetObjByIdmicroteachCaseQuantitySenate(long lngIdmicroteachCaseQuantitySenate)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCoursewareResCaseQuantitySenateDA.GetSpecSQLObj();
strSQL = "Select * from vCoursewareResCaseQuantitySenate where IdmicroteachCaseQuantitySenate = " + ""+ lngIdmicroteachCaseQuantitySenate+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvCoursewareResCaseQuantitySenateEN objvCoursewareResCaseQuantitySenateEN = new clsvCoursewareResCaseQuantitySenateEN();
try
{
 objvCoursewareResCaseQuantitySenateEN.IdmicroteachCaseQuantitySenate = Int32.Parse(objRow[convCoursewareResCaseQuantitySenate.IdmicroteachCaseQuantitySenate].ToString().Trim()); //微格量化评价流水号(字段类型:bigint,字段长度:8,是否可空:False)
 objvCoursewareResCaseQuantitySenateEN.FuncModuleId = objRow[convCoursewareResCaseQuantitySenate.FuncModuleId].ToString().Trim(); //功能模块Id(字段类型:char,字段长度:4,是否可空:True)
 objvCoursewareResCaseQuantitySenateEN.FuncModuleName = objRow[convCoursewareResCaseQuantitySenate.FuncModuleName] == DBNull.Value ? null : objRow[convCoursewareResCaseQuantitySenate.FuncModuleName].ToString().Trim(); //功能模块名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvCoursewareResCaseQuantitySenateEN.IdCoursewareResCase = objRow[convCoursewareResCaseQuantitySenate.IdCoursewareResCase] == DBNull.Value ? null : objRow[convCoursewareResCaseQuantitySenate.IdCoursewareResCase].ToString().Trim(); //课件资源案例流水号(字段类型:char,字段长度:8,是否可空:False)
 objvCoursewareResCaseQuantitySenateEN.IdMicroteachCase = objRow[convCoursewareResCaseQuantitySenate.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号(字段类型:char,字段长度:8,是否可空:False)
 objvCoursewareResCaseQuantitySenateEN.CoursewareResCaseID = objRow[convCoursewareResCaseQuantitySenate.CoursewareResCaseID] == DBNull.Value ? null : objRow[convCoursewareResCaseQuantitySenate.CoursewareResCaseID].ToString().Trim(); //课件资源案例ID(字段类型:char,字段长度:8,是否可空:False)
 objvCoursewareResCaseQuantitySenateEN.CoursewareResCaseName = objRow[convCoursewareResCaseQuantitySenate.CoursewareResCaseName] == DBNull.Value ? null : objRow[convCoursewareResCaseQuantitySenate.CoursewareResCaseName].ToString().Trim(); //课件资源案例名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvCoursewareResCaseQuantitySenateEN.CoursewareResCaseTheme = objRow[convCoursewareResCaseQuantitySenate.CoursewareResCaseTheme] == DBNull.Value ? null : objRow[convCoursewareResCaseQuantitySenate.CoursewareResCaseTheme].ToString().Trim(); //课件资源案例主题词(字段类型:varchar,字段长度:200,是否可空:True)
 objvCoursewareResCaseQuantitySenateEN.CoursewareResCaseDate = objRow[convCoursewareResCaseQuantitySenate.CoursewareResCaseDate] == DBNull.Value ? null : objRow[convCoursewareResCaseQuantitySenate.CoursewareResCaseDate].ToString().Trim(); //视频资源日期(字段类型:char,字段长度:8,是否可空:True)
 objvCoursewareResCaseQuantitySenateEN.CoursewareResCaseTime = objRow[convCoursewareResCaseQuantitySenate.CoursewareResCaseTime] == DBNull.Value ? null : objRow[convCoursewareResCaseQuantitySenate.CoursewareResCaseTime].ToString().Trim(); //视频资源时间(字段类型:char,字段长度:6,是否可空:True)
 objvCoursewareResCaseQuantitySenateEN.CoursewareResCaseDateIn = objRow[convCoursewareResCaseQuantitySenate.CoursewareResCaseDateIn] == DBNull.Value ? null : objRow[convCoursewareResCaseQuantitySenate.CoursewareResCaseDateIn].ToString().Trim(); //案例入库日期(字段类型:char,字段长度:8,是否可空:True)
 objvCoursewareResCaseQuantitySenateEN.CoursewareResCaseTimeIn = objRow[convCoursewareResCaseQuantitySenate.CoursewareResCaseTimeIn] == DBNull.Value ? null : objRow[convCoursewareResCaseQuantitySenate.CoursewareResCaseTimeIn].ToString().Trim(); //案例入库时间(字段类型:char,字段长度:6,是否可空:True)
 objvCoursewareResCaseQuantitySenateEN.IdCoursewareResCaseType = objRow[convCoursewareResCaseQuantitySenate.IdCoursewareResCaseType] == DBNull.Value ? null : objRow[convCoursewareResCaseQuantitySenate.IdCoursewareResCaseType].ToString().Trim(); //课件资源类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvCoursewareResCaseQuantitySenateEN.CoursewareResCaseTypeName = objRow[convCoursewareResCaseQuantitySenate.CoursewareResCaseTypeName] == DBNull.Value ? null : objRow[convCoursewareResCaseQuantitySenate.CoursewareResCaseTypeName].ToString().Trim(); //课件资源案例类型名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvCoursewareResCaseQuantitySenateEN.UserId = objRow[convCoursewareResCaseQuantitySenate.UserId].ToString().Trim(); //用户ID(字段类型:varchar,字段长度:18,是否可空:True)
 objvCoursewareResCaseQuantitySenateEN.MajorID = objRow[convCoursewareResCaseQuantitySenate.MajorID] == DBNull.Value ? null : objRow[convCoursewareResCaseQuantitySenate.MajorID].ToString().Trim(); //专业ID(字段类型:char,字段长度:4,是否可空:False)
 objvCoursewareResCaseQuantitySenateEN.MajorName = objRow[convCoursewareResCaseQuantitySenate.MajorName] == DBNull.Value ? null : objRow[convCoursewareResCaseQuantitySenate.MajorName].ToString().Trim(); //专业名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvCoursewareResCaseQuantitySenateEN.IdAppraiseType = objRow[convCoursewareResCaseQuantitySenate.IdAppraiseType].ToString().Trim(); //评议类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvCoursewareResCaseQuantitySenateEN.AppraiseTypeName = objRow[convCoursewareResCaseQuantitySenate.AppraiseTypeName] == DBNull.Value ? null : objRow[convCoursewareResCaseQuantitySenate.AppraiseTypeName].ToString().Trim(); //评议类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvCoursewareResCaseQuantitySenateEN.CollegeID = objRow[convCoursewareResCaseQuantitySenate.CollegeID] == DBNull.Value ? null : objRow[convCoursewareResCaseQuantitySenate.CollegeID].ToString().Trim(); //学院ID(字段类型:varchar,字段长度:4,是否可空:False)
 objvCoursewareResCaseQuantitySenateEN.CollegeName = objRow[convCoursewareResCaseQuantitySenate.CollegeName] == DBNull.Value ? null : objRow[convCoursewareResCaseQuantitySenate.CollegeName].ToString().Trim(); //学院名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvCoursewareResCaseQuantitySenateEN.CourseId = objRow[convCoursewareResCaseQuantitySenate.CourseId] == DBNull.Value ? null : objRow[convCoursewareResCaseQuantitySenate.CourseId].ToString().Trim(); //课程Id(字段类型:char,字段长度:8,是否可空:True)
 objvCoursewareResCaseQuantitySenateEN.CourseCode = objRow[convCoursewareResCaseQuantitySenate.CourseCode] == DBNull.Value ? null : objRow[convCoursewareResCaseQuantitySenate.CourseCode].ToString().Trim(); //课程代码(字段类型:varchar,字段长度:20,是否可空:True)
 objvCoursewareResCaseQuantitySenateEN.CourseName = objRow[convCoursewareResCaseQuantitySenate.CourseName] == DBNull.Value ? null : objRow[convCoursewareResCaseQuantitySenate.CourseName].ToString().Trim(); //课程名称(字段类型:varchar,字段长度:100,是否可空:True)
 objvCoursewareResCaseQuantitySenateEN.BrowseCount = objRow[convCoursewareResCaseQuantitySenate.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCoursewareResCaseQuantitySenate.BrowseCount].ToString().Trim()); //浏览次数(字段类型:int,字段长度:4,是否可空:True)
 objvCoursewareResCaseQuantitySenateEN.SenateTheme = objRow[convCoursewareResCaseQuantitySenate.SenateTheme] == DBNull.Value ? null : objRow[convCoursewareResCaseQuantitySenate.SenateTheme].ToString().Trim(); //量化评价主题(字段类型:varchar,字段长度:200,是否可空:True)
 objvCoursewareResCaseQuantitySenateEN.SenateContent = objRow[convCoursewareResCaseQuantitySenate.SenateContent] == DBNull.Value ? null : objRow[convCoursewareResCaseQuantitySenate.SenateContent].ToString().Trim(); //评价内容(字段类型:varchar,字段长度:2000,是否可空:True)
 objvCoursewareResCaseQuantitySenateEN.SenateTotalScore = Single.Parse(objRow[convCoursewareResCaseQuantitySenate.SenateTotalScore].ToString().Trim()); //评价分数(字段类型:float,字段长度:8,是否可空:False)
 objvCoursewareResCaseQuantitySenateEN.SenateDate = objRow[convCoursewareResCaseQuantitySenate.SenateDate] == DBNull.Value ? null : objRow[convCoursewareResCaseQuantitySenate.SenateDate].ToString().Trim(); //评价日期(字段类型:char,字段长度:8,是否可空:True)
 objvCoursewareResCaseQuantitySenateEN.SenateTime = objRow[convCoursewareResCaseQuantitySenate.SenateTime] == DBNull.Value ? null : objRow[convCoursewareResCaseQuantitySenate.SenateTime].ToString().Trim(); //评价时间(字段类型:char,字段长度:6,是否可空:True)
 objvCoursewareResCaseQuantitySenateEN.IdSenateGaugeVersion = objRow[convCoursewareResCaseQuantitySenate.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号(字段类型:char,字段长度:4,是否可空:False)
 objvCoursewareResCaseQuantitySenateEN.senateGaugeVersionID = objRow[convCoursewareResCaseQuantitySenate.senateGaugeVersionID] == DBNull.Value ? null : objRow[convCoursewareResCaseQuantitySenate.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID(字段类型:char,字段长度:4,是否可空:False)
 objvCoursewareResCaseQuantitySenateEN.senateGaugeVersionName = objRow[convCoursewareResCaseQuantitySenate.senateGaugeVersionName] == DBNull.Value ? null : objRow[convCoursewareResCaseQuantitySenate.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称(字段类型:varchar,字段长度:200,是否可空:True)
 objvCoursewareResCaseQuantitySenateEN.senateGaugeVersionTtlScore = objRow[convCoursewareResCaseQuantitySenate.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convCoursewareResCaseQuantitySenate.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分(字段类型:float,字段长度:8,是否可空:False)
 objvCoursewareResCaseQuantitySenateEN.UpdUserName = objRow[convCoursewareResCaseQuantitySenate.UpdUserName] == DBNull.Value ? null : objRow[convCoursewareResCaseQuantitySenate.UpdUserName].ToString().Trim(); //UpdUserName(字段类型:varchar,字段长度:20,是否可空:True)
 objvCoursewareResCaseQuantitySenateEN.SenateIp = objRow[convCoursewareResCaseQuantitySenate.SenateIp].ToString().Trim(); //评议Ip(字段类型:varchar,字段长度:50,是否可空:True)
 objvCoursewareResCaseQuantitySenateEN.UserTypeName = objRow[convCoursewareResCaseQuantitySenate.UserTypeName] == DBNull.Value ? null : objRow[convCoursewareResCaseQuantitySenate.UserTypeName].ToString().Trim(); //用户类型名称(字段类型:varchar,字段长度:20,是否可空:True)
 objvCoursewareResCaseQuantitySenateEN.UserName = objRow[convCoursewareResCaseQuantitySenate.UserName].ToString().Trim(); //用户名(字段类型:varchar,字段长度:30,是否可空:True)
 objvCoursewareResCaseQuantitySenateEN.UserNameWithUserId = objRow[convCoursewareResCaseQuantitySenate.UserNameWithUserId] == DBNull.Value ? null : objRow[convCoursewareResCaseQuantitySenate.UserNameWithUserId].ToString().Trim(); //UserNameWithUserId(字段类型:varchar,字段长度:51,是否可空:False)
 objvCoursewareResCaseQuantitySenateEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convCoursewareResCaseQuantitySenate.IsDualVideo].ToString().Trim()); //是否双视频(字段类型:bit,字段长度:1,是否可空:False)
 objvCoursewareResCaseQuantitySenateEN.UserKindId = objRow[convCoursewareResCaseQuantitySenate.UserKindId].ToString().Trim(); //用户类别Id(字段类型:char,字段长度:2,是否可空:False)
 objvCoursewareResCaseQuantitySenateEN.UserKindName = objRow[convCoursewareResCaseQuantitySenate.UserKindName] == DBNull.Value ? null : objRow[convCoursewareResCaseQuantitySenate.UserKindName].ToString().Trim(); //用户类别名(字段类型:varchar,字段长度:30,是否可空:False)
 objvCoursewareResCaseQuantitySenateEN.ViewCount = objRow[convCoursewareResCaseQuantitySenate.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCoursewareResCaseQuantitySenate.ViewCount].ToString().Trim()); //浏览量(字段类型:int,字段长度:4,是否可空:True)
 objvCoursewareResCaseQuantitySenateEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[convCoursewareResCaseQuantitySenate.IsShow].ToString().Trim()); //是否启用(字段类型:bit,字段长度:1,是否可空:True)
 objvCoursewareResCaseQuantitySenateEN.DownloadNumber = objRow[convCoursewareResCaseQuantitySenate.DownloadNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCoursewareResCaseQuantitySenate.DownloadNumber].ToString().Trim()); //下载数目(字段类型:int,字段长度:4,是否可空:True)
 objvCoursewareResCaseQuantitySenateEN.FileIntegration = objRow[convCoursewareResCaseQuantitySenate.FileIntegration] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCoursewareResCaseQuantitySenate.FileIntegration].ToString().Trim()); //文件积分(字段类型:int,字段长度:4,是否可空:True)
 objvCoursewareResCaseQuantitySenateEN.LikeCount = objRow[convCoursewareResCaseQuantitySenate.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convCoursewareResCaseQuantitySenate.LikeCount].ToString().Trim()); //资源喜欢数量(字段类型:bigint,字段长度:8,是否可空:True)
 objvCoursewareResCaseQuantitySenateEN.CollectionCount = objRow[convCoursewareResCaseQuantitySenate.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convCoursewareResCaseQuantitySenate.CollectionCount].ToString().Trim()); //收藏数量(字段类型:bigint,字段长度:8,是否可空:True)
 objvCoursewareResCaseQuantitySenateEN.UpdUser = objRow[convCoursewareResCaseQuantitySenate.UpdUser] == DBNull.Value ? null : objRow[convCoursewareResCaseQuantitySenate.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objvCoursewareResCaseQuantitySenateEN.Memo = objRow[convCoursewareResCaseQuantitySenate.Memo] == DBNull.Value ? null : objRow[convCoursewareResCaseQuantitySenate.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvCoursewareResCaseQuantitySenateEN.OwnerId = objRow[convCoursewareResCaseQuantitySenate.OwnerId] == DBNull.Value ? null : objRow[convCoursewareResCaseQuantitySenate.OwnerId].ToString().Trim(); //拥有者Id(字段类型:varchar,字段长度:20,是否可空:False)
 objvCoursewareResCaseQuantitySenateEN.OwnerName = objRow[convCoursewareResCaseQuantitySenate.OwnerName] == DBNull.Value ? null : objRow[convCoursewareResCaseQuantitySenate.OwnerName].ToString().Trim(); //拥有者姓名(字段类型:varchar,字段长度:30,是否可空:True)
 objvCoursewareResCaseQuantitySenateEN.OwnerNameWithId = objRow[convCoursewareResCaseQuantitySenate.OwnerNameWithId] == DBNull.Value ? null : objRow[convCoursewareResCaseQuantitySenate.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id(字段类型:varchar,字段长度:51,是否可空:True)
 objvCoursewareResCaseQuantitySenateEN.IdXzCollege = objRow[convCoursewareResCaseQuantitySenate.IdXzCollege] == DBNull.Value ? null : objRow[convCoursewareResCaseQuantitySenate.IdXzCollege].ToString().Trim(); //学院流水号(字段类型:char,字段长度:4,是否可空:True)
 objvCoursewareResCaseQuantitySenateEN.IdXzMajor = objRow[convCoursewareResCaseQuantitySenate.IdXzMajor] == DBNull.Value ? null : objRow[convCoursewareResCaseQuantitySenate.IdXzMajor].ToString().Trim(); //专业流水号(字段类型:char,字段长度:8,是否可空:False)
 objvCoursewareResCaseQuantitySenateEN.CollegeNameA = objRow[convCoursewareResCaseQuantitySenate.CollegeNameA] == DBNull.Value ? null : objRow[convCoursewareResCaseQuantitySenate.CollegeNameA].ToString().Trim(); //学院名称简写(字段类型:varchar,字段长度:12,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvCoursewareResCaseQuantitySenateDA: GetObjByIdmicroteachCaseQuantitySenate)", objException.Message));
}
return objvCoursewareResCaseQuantitySenateEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvCoursewareResCaseQuantitySenateEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvCoursewareResCaseQuantitySenateDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCoursewareResCaseQuantitySenateDA.GetSpecSQLObj();
strSQL = "Select * from vCoursewareResCaseQuantitySenate where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvCoursewareResCaseQuantitySenateEN objvCoursewareResCaseQuantitySenateEN = new clsvCoursewareResCaseQuantitySenateEN()
{
IdmicroteachCaseQuantitySenate = TransNullToInt(objRow[convCoursewareResCaseQuantitySenate.IdmicroteachCaseQuantitySenate].ToString().Trim()), //微格量化评价流水号
FuncModuleId = objRow[convCoursewareResCaseQuantitySenate.FuncModuleId].ToString().Trim(), //功能模块Id
FuncModuleName = objRow[convCoursewareResCaseQuantitySenate.FuncModuleName] == DBNull.Value ? null : objRow[convCoursewareResCaseQuantitySenate.FuncModuleName].ToString().Trim(), //功能模块名称
IdCoursewareResCase = objRow[convCoursewareResCaseQuantitySenate.IdCoursewareResCase] == DBNull.Value ? null : objRow[convCoursewareResCaseQuantitySenate.IdCoursewareResCase].ToString().Trim(), //课件资源案例流水号
IdMicroteachCase = objRow[convCoursewareResCaseQuantitySenate.IdMicroteachCase].ToString().Trim(), //微格教学案例流水号
CoursewareResCaseID = objRow[convCoursewareResCaseQuantitySenate.CoursewareResCaseID] == DBNull.Value ? null : objRow[convCoursewareResCaseQuantitySenate.CoursewareResCaseID].ToString().Trim(), //课件资源案例ID
CoursewareResCaseName = objRow[convCoursewareResCaseQuantitySenate.CoursewareResCaseName] == DBNull.Value ? null : objRow[convCoursewareResCaseQuantitySenate.CoursewareResCaseName].ToString().Trim(), //课件资源案例名称
CoursewareResCaseTheme = objRow[convCoursewareResCaseQuantitySenate.CoursewareResCaseTheme] == DBNull.Value ? null : objRow[convCoursewareResCaseQuantitySenate.CoursewareResCaseTheme].ToString().Trim(), //课件资源案例主题词
CoursewareResCaseDate = objRow[convCoursewareResCaseQuantitySenate.CoursewareResCaseDate] == DBNull.Value ? null : objRow[convCoursewareResCaseQuantitySenate.CoursewareResCaseDate].ToString().Trim(), //视频资源日期
CoursewareResCaseTime = objRow[convCoursewareResCaseQuantitySenate.CoursewareResCaseTime] == DBNull.Value ? null : objRow[convCoursewareResCaseQuantitySenate.CoursewareResCaseTime].ToString().Trim(), //视频资源时间
CoursewareResCaseDateIn = objRow[convCoursewareResCaseQuantitySenate.CoursewareResCaseDateIn] == DBNull.Value ? null : objRow[convCoursewareResCaseQuantitySenate.CoursewareResCaseDateIn].ToString().Trim(), //案例入库日期
CoursewareResCaseTimeIn = objRow[convCoursewareResCaseQuantitySenate.CoursewareResCaseTimeIn] == DBNull.Value ? null : objRow[convCoursewareResCaseQuantitySenate.CoursewareResCaseTimeIn].ToString().Trim(), //案例入库时间
IdCoursewareResCaseType = objRow[convCoursewareResCaseQuantitySenate.IdCoursewareResCaseType] == DBNull.Value ? null : objRow[convCoursewareResCaseQuantitySenate.IdCoursewareResCaseType].ToString().Trim(), //课件资源类型流水号
CoursewareResCaseTypeName = objRow[convCoursewareResCaseQuantitySenate.CoursewareResCaseTypeName] == DBNull.Value ? null : objRow[convCoursewareResCaseQuantitySenate.CoursewareResCaseTypeName].ToString().Trim(), //课件资源案例类型名称
UserId = objRow[convCoursewareResCaseQuantitySenate.UserId].ToString().Trim(), //用户ID
MajorID = objRow[convCoursewareResCaseQuantitySenate.MajorID] == DBNull.Value ? null : objRow[convCoursewareResCaseQuantitySenate.MajorID].ToString().Trim(), //专业ID
MajorName = objRow[convCoursewareResCaseQuantitySenate.MajorName] == DBNull.Value ? null : objRow[convCoursewareResCaseQuantitySenate.MajorName].ToString().Trim(), //专业名称
IdAppraiseType = objRow[convCoursewareResCaseQuantitySenate.IdAppraiseType].ToString().Trim(), //评议类型流水号
AppraiseTypeName = objRow[convCoursewareResCaseQuantitySenate.AppraiseTypeName] == DBNull.Value ? null : objRow[convCoursewareResCaseQuantitySenate.AppraiseTypeName].ToString().Trim(), //评议类型名称
CollegeID = objRow[convCoursewareResCaseQuantitySenate.CollegeID] == DBNull.Value ? null : objRow[convCoursewareResCaseQuantitySenate.CollegeID].ToString().Trim(), //学院ID
CollegeName = objRow[convCoursewareResCaseQuantitySenate.CollegeName] == DBNull.Value ? null : objRow[convCoursewareResCaseQuantitySenate.CollegeName].ToString().Trim(), //学院名称
CourseId = objRow[convCoursewareResCaseQuantitySenate.CourseId] == DBNull.Value ? null : objRow[convCoursewareResCaseQuantitySenate.CourseId].ToString().Trim(), //课程Id
CourseCode = objRow[convCoursewareResCaseQuantitySenate.CourseCode] == DBNull.Value ? null : objRow[convCoursewareResCaseQuantitySenate.CourseCode].ToString().Trim(), //课程代码
CourseName = objRow[convCoursewareResCaseQuantitySenate.CourseName] == DBNull.Value ? null : objRow[convCoursewareResCaseQuantitySenate.CourseName].ToString().Trim(), //课程名称
BrowseCount = objRow[convCoursewareResCaseQuantitySenate.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCoursewareResCaseQuantitySenate.BrowseCount].ToString().Trim()), //浏览次数
SenateTheme = objRow[convCoursewareResCaseQuantitySenate.SenateTheme] == DBNull.Value ? null : objRow[convCoursewareResCaseQuantitySenate.SenateTheme].ToString().Trim(), //量化评价主题
SenateContent = objRow[convCoursewareResCaseQuantitySenate.SenateContent] == DBNull.Value ? null : objRow[convCoursewareResCaseQuantitySenate.SenateContent].ToString().Trim(), //评价内容
SenateTotalScore = TransNullToFloat(objRow[convCoursewareResCaseQuantitySenate.SenateTotalScore].ToString().Trim()), //评价分数
SenateDate = objRow[convCoursewareResCaseQuantitySenate.SenateDate] == DBNull.Value ? null : objRow[convCoursewareResCaseQuantitySenate.SenateDate].ToString().Trim(), //评价日期
SenateTime = objRow[convCoursewareResCaseQuantitySenate.SenateTime] == DBNull.Value ? null : objRow[convCoursewareResCaseQuantitySenate.SenateTime].ToString().Trim(), //评价时间
IdSenateGaugeVersion = objRow[convCoursewareResCaseQuantitySenate.IdSenateGaugeVersion].ToString().Trim(), //评价量表版本流水号
senateGaugeVersionID = objRow[convCoursewareResCaseQuantitySenate.senateGaugeVersionID] == DBNull.Value ? null : objRow[convCoursewareResCaseQuantitySenate.senateGaugeVersionID].ToString().Trim(), //评价量表版本ID
senateGaugeVersionName = objRow[convCoursewareResCaseQuantitySenate.senateGaugeVersionName] == DBNull.Value ? null : objRow[convCoursewareResCaseQuantitySenate.senateGaugeVersionName].ToString().Trim(), //评价量表版本名称
senateGaugeVersionTtlScore = objRow[convCoursewareResCaseQuantitySenate.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convCoursewareResCaseQuantitySenate.senateGaugeVersionTtlScore].ToString().Trim()), //评价量表版本总分
UpdUserName = objRow[convCoursewareResCaseQuantitySenate.UpdUserName] == DBNull.Value ? null : objRow[convCoursewareResCaseQuantitySenate.UpdUserName].ToString().Trim(), //UpdUserName
SenateIp = objRow[convCoursewareResCaseQuantitySenate.SenateIp].ToString().Trim(), //评议Ip
UserTypeName = objRow[convCoursewareResCaseQuantitySenate.UserTypeName] == DBNull.Value ? null : objRow[convCoursewareResCaseQuantitySenate.UserTypeName].ToString().Trim(), //用户类型名称
UserName = objRow[convCoursewareResCaseQuantitySenate.UserName].ToString().Trim(), //用户名
UserNameWithUserId = objRow[convCoursewareResCaseQuantitySenate.UserNameWithUserId] == DBNull.Value ? null : objRow[convCoursewareResCaseQuantitySenate.UserNameWithUserId].ToString().Trim(), //UserNameWithUserId
IsDualVideo = TransNullToBool(objRow[convCoursewareResCaseQuantitySenate.IsDualVideo].ToString().Trim()), //是否双视频
UserKindId = objRow[convCoursewareResCaseQuantitySenate.UserKindId].ToString().Trim(), //用户类别Id
UserKindName = objRow[convCoursewareResCaseQuantitySenate.UserKindName] == DBNull.Value ? null : objRow[convCoursewareResCaseQuantitySenate.UserKindName].ToString().Trim(), //用户类别名
ViewCount = objRow[convCoursewareResCaseQuantitySenate.ViewCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCoursewareResCaseQuantitySenate.ViewCount].ToString().Trim()), //浏览量
IsShow = TransNullToBool(objRow[convCoursewareResCaseQuantitySenate.IsShow].ToString().Trim()), //是否启用
DownloadNumber = objRow[convCoursewareResCaseQuantitySenate.DownloadNumber] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCoursewareResCaseQuantitySenate.DownloadNumber].ToString().Trim()), //下载数目
FileIntegration = objRow[convCoursewareResCaseQuantitySenate.FileIntegration] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCoursewareResCaseQuantitySenate.FileIntegration].ToString().Trim()), //文件积分
LikeCount = objRow[convCoursewareResCaseQuantitySenate.LikeCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convCoursewareResCaseQuantitySenate.LikeCount].ToString().Trim()), //资源喜欢数量
CollectionCount = objRow[convCoursewareResCaseQuantitySenate.CollectionCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convCoursewareResCaseQuantitySenate.CollectionCount].ToString().Trim()), //收藏数量
UpdUser = objRow[convCoursewareResCaseQuantitySenate.UpdUser] == DBNull.Value ? null : objRow[convCoursewareResCaseQuantitySenate.UpdUser].ToString().Trim(), //修改人
Memo = objRow[convCoursewareResCaseQuantitySenate.Memo] == DBNull.Value ? null : objRow[convCoursewareResCaseQuantitySenate.Memo].ToString().Trim(), //备注
OwnerId = objRow[convCoursewareResCaseQuantitySenate.OwnerId] == DBNull.Value ? null : objRow[convCoursewareResCaseQuantitySenate.OwnerId].ToString().Trim(), //拥有者Id
OwnerName = objRow[convCoursewareResCaseQuantitySenate.OwnerName] == DBNull.Value ? null : objRow[convCoursewareResCaseQuantitySenate.OwnerName].ToString().Trim(), //拥有者姓名
OwnerNameWithId = objRow[convCoursewareResCaseQuantitySenate.OwnerNameWithId] == DBNull.Value ? null : objRow[convCoursewareResCaseQuantitySenate.OwnerNameWithId].ToString().Trim(), //拥有者名称附Id
IdXzCollege = objRow[convCoursewareResCaseQuantitySenate.IdXzCollege] == DBNull.Value ? null : objRow[convCoursewareResCaseQuantitySenate.IdXzCollege].ToString().Trim(), //学院流水号
IdXzMajor = objRow[convCoursewareResCaseQuantitySenate.IdXzMajor] == DBNull.Value ? null : objRow[convCoursewareResCaseQuantitySenate.IdXzMajor].ToString().Trim(), //专业流水号
CollegeNameA = objRow[convCoursewareResCaseQuantitySenate.CollegeNameA] == DBNull.Value ? null : objRow[convCoursewareResCaseQuantitySenate.CollegeNameA].ToString().Trim() //学院名称简写
};
objvCoursewareResCaseQuantitySenateEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvCoursewareResCaseQuantitySenateEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvCoursewareResCaseQuantitySenateDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvCoursewareResCaseQuantitySenateEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvCoursewareResCaseQuantitySenateEN objvCoursewareResCaseQuantitySenateEN = new clsvCoursewareResCaseQuantitySenateEN();
try
{
objvCoursewareResCaseQuantitySenateEN.IdmicroteachCaseQuantitySenate = TransNullToInt(objRow[convCoursewareResCaseQuantitySenate.IdmicroteachCaseQuantitySenate].ToString().Trim()); //微格量化评价流水号
objvCoursewareResCaseQuantitySenateEN.FuncModuleId = objRow[convCoursewareResCaseQuantitySenate.FuncModuleId].ToString().Trim(); //功能模块Id
objvCoursewareResCaseQuantitySenateEN.FuncModuleName = objRow[convCoursewareResCaseQuantitySenate.FuncModuleName] == DBNull.Value ? null : objRow[convCoursewareResCaseQuantitySenate.FuncModuleName].ToString().Trim(); //功能模块名称
objvCoursewareResCaseQuantitySenateEN.IdCoursewareResCase = objRow[convCoursewareResCaseQuantitySenate.IdCoursewareResCase] == DBNull.Value ? null : objRow[convCoursewareResCaseQuantitySenate.IdCoursewareResCase].ToString().Trim(); //课件资源案例流水号
objvCoursewareResCaseQuantitySenateEN.IdMicroteachCase = objRow[convCoursewareResCaseQuantitySenate.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvCoursewareResCaseQuantitySenateEN.CoursewareResCaseID = objRow[convCoursewareResCaseQuantitySenate.CoursewareResCaseID] == DBNull.Value ? null : objRow[convCoursewareResCaseQuantitySenate.CoursewareResCaseID].ToString().Trim(); //课件资源案例ID
objvCoursewareResCaseQuantitySenateEN.CoursewareResCaseName = objRow[convCoursewareResCaseQuantitySenate.CoursewareResCaseName] == DBNull.Value ? null : objRow[convCoursewareResCaseQuantitySenate.CoursewareResCaseName].ToString().Trim(); //课件资源案例名称
objvCoursewareResCaseQuantitySenateEN.CoursewareResCaseTheme = objRow[convCoursewareResCaseQuantitySenate.CoursewareResCaseTheme] == DBNull.Value ? null : objRow[convCoursewareResCaseQuantitySenate.CoursewareResCaseTheme].ToString().Trim(); //课件资源案例主题词
objvCoursewareResCaseQuantitySenateEN.CoursewareResCaseDate = objRow[convCoursewareResCaseQuantitySenate.CoursewareResCaseDate] == DBNull.Value ? null : objRow[convCoursewareResCaseQuantitySenate.CoursewareResCaseDate].ToString().Trim(); //视频资源日期
objvCoursewareResCaseQuantitySenateEN.CoursewareResCaseTime = objRow[convCoursewareResCaseQuantitySenate.CoursewareResCaseTime] == DBNull.Value ? null : objRow[convCoursewareResCaseQuantitySenate.CoursewareResCaseTime].ToString().Trim(); //视频资源时间
objvCoursewareResCaseQuantitySenateEN.CoursewareResCaseDateIn = objRow[convCoursewareResCaseQuantitySenate.CoursewareResCaseDateIn] == DBNull.Value ? null : objRow[convCoursewareResCaseQuantitySenate.CoursewareResCaseDateIn].ToString().Trim(); //案例入库日期
objvCoursewareResCaseQuantitySenateEN.CoursewareResCaseTimeIn = objRow[convCoursewareResCaseQuantitySenate.CoursewareResCaseTimeIn] == DBNull.Value ? null : objRow[convCoursewareResCaseQuantitySenate.CoursewareResCaseTimeIn].ToString().Trim(); //案例入库时间
objvCoursewareResCaseQuantitySenateEN.IdCoursewareResCaseType = objRow[convCoursewareResCaseQuantitySenate.IdCoursewareResCaseType] == DBNull.Value ? null : objRow[convCoursewareResCaseQuantitySenate.IdCoursewareResCaseType].ToString().Trim(); //课件资源类型流水号
objvCoursewareResCaseQuantitySenateEN.CoursewareResCaseTypeName = objRow[convCoursewareResCaseQuantitySenate.CoursewareResCaseTypeName] == DBNull.Value ? null : objRow[convCoursewareResCaseQuantitySenate.CoursewareResCaseTypeName].ToString().Trim(); //课件资源案例类型名称
objvCoursewareResCaseQuantitySenateEN.UserId = objRow[convCoursewareResCaseQuantitySenate.UserId].ToString().Trim(); //用户ID
objvCoursewareResCaseQuantitySenateEN.MajorID = objRow[convCoursewareResCaseQuantitySenate.MajorID] == DBNull.Value ? null : objRow[convCoursewareResCaseQuantitySenate.MajorID].ToString().Trim(); //专业ID
objvCoursewareResCaseQuantitySenateEN.MajorName = objRow[convCoursewareResCaseQuantitySenate.MajorName] == DBNull.Value ? null : objRow[convCoursewareResCaseQuantitySenate.MajorName].ToString().Trim(); //专业名称
objvCoursewareResCaseQuantitySenateEN.IdAppraiseType = objRow[convCoursewareResCaseQuantitySenate.IdAppraiseType].ToString().Trim(); //评议类型流水号
objvCoursewareResCaseQuantitySenateEN.AppraiseTypeName = objRow[convCoursewareResCaseQuantitySenate.AppraiseTypeName] == DBNull.Value ? null : objRow[convCoursewareResCaseQuantitySenate.AppraiseTypeName].ToString().Trim(); //评议类型名称
objvCoursewareResCaseQuantitySenateEN.CollegeID = objRow[convCoursewareResCaseQuantitySenate.CollegeID] == DBNull.Value ? null : objRow[convCoursewareResCaseQuantitySenate.CollegeID].ToString().Trim(); //学院ID
objvCoursewareResCaseQuantitySenateEN.CollegeName = objRow[convCoursewareResCaseQuantitySenate.CollegeName] == DBNull.Value ? null : objRow[convCoursewareResCaseQuantitySenate.CollegeName].ToString().Trim(); //学院名称
objvCoursewareResCaseQuantitySenateEN.CourseId = objRow[convCoursewareResCaseQuantitySenate.CourseId] == DBNull.Value ? null : objRow[convCoursewareResCaseQuantitySenate.CourseId].ToString().Trim(); //课程Id
objvCoursewareResCaseQuantitySenateEN.CourseCode = objRow[convCoursewareResCaseQuantitySenate.CourseCode] == DBNull.Value ? null : objRow[convCoursewareResCaseQuantitySenate.CourseCode].ToString().Trim(); //课程代码
objvCoursewareResCaseQuantitySenateEN.CourseName = objRow[convCoursewareResCaseQuantitySenate.CourseName] == DBNull.Value ? null : objRow[convCoursewareResCaseQuantitySenate.CourseName].ToString().Trim(); //课程名称
objvCoursewareResCaseQuantitySenateEN.BrowseCount = objRow[convCoursewareResCaseQuantitySenate.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCoursewareResCaseQuantitySenate.BrowseCount].ToString().Trim()); //浏览次数
objvCoursewareResCaseQuantitySenateEN.SenateTheme = objRow[convCoursewareResCaseQuantitySenate.SenateTheme] == DBNull.Value ? null : objRow[convCoursewareResCaseQuantitySenate.SenateTheme].ToString().Trim(); //量化评价主题
objvCoursewareResCaseQuantitySenateEN.SenateContent = objRow[convCoursewareResCaseQuantitySenate.SenateContent] == DBNull.Value ? null : objRow[convCoursewareResCaseQuantitySenate.SenateContent].ToString().Trim(); //评价内容
objvCoursewareResCaseQuantitySenateEN.SenateTotalScore = TransNullToFloat(objRow[convCoursewareResCaseQuantitySenate.SenateTotalScore].ToString().Trim()); //评价分数
objvCoursewareResCaseQuantitySenateEN.SenateDate = objRow[convCoursewareResCaseQuantitySenate.SenateDate] == DBNull.Value ? null : objRow[convCoursewareResCaseQuantitySenate.SenateDate].ToString().Trim(); //评价日期
objvCoursewareResCaseQuantitySenateEN.SenateTime = objRow[convCoursewareResCaseQuantitySenate.SenateTime] == DBNull.Value ? null : objRow[convCoursewareResCaseQuantitySenate.SenateTime].ToString().Trim(); //评价时间
objvCoursewareResCaseQuantitySenateEN.IdSenateGaugeVersion = objRow[convCoursewareResCaseQuantitySenate.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvCoursewareResCaseQuantitySenateEN.senateGaugeVersionID = objRow[convCoursewareResCaseQuantitySenate.senateGaugeVersionID] == DBNull.Value ? null : objRow[convCoursewareResCaseQuantitySenate.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvCoursewareResCaseQuantitySenateEN.senateGaugeVersionName = objRow[convCoursewareResCaseQuantitySenate.senateGaugeVersionName] == DBNull.Value ? null : objRow[convCoursewareResCaseQuantitySenate.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvCoursewareResCaseQuantitySenateEN.senateGaugeVersionTtlScore = objRow[convCoursewareResCaseQuantitySenate.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convCoursewareResCaseQuantitySenate.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvCoursewareResCaseQuantitySenateEN.UpdUserName = objRow[convCoursewareResCaseQuantitySenate.UpdUserName] == DBNull.Value ? null : objRow[convCoursewareResCaseQuantitySenate.UpdUserName].ToString().Trim(); //UpdUserName
objvCoursewareResCaseQuantitySenateEN.SenateIp = objRow[convCoursewareResCaseQuantitySenate.SenateIp].ToString().Trim(); //评议Ip
objvCoursewareResCaseQuantitySenateEN.UserTypeName = objRow[convCoursewareResCaseQuantitySenate.UserTypeName] == DBNull.Value ? null : objRow[convCoursewareResCaseQuantitySenate.UserTypeName].ToString().Trim(); //用户类型名称
objvCoursewareResCaseQuantitySenateEN.UserName = objRow[convCoursewareResCaseQuantitySenate.UserName].ToString().Trim(); //用户名
objvCoursewareResCaseQuantitySenateEN.UserNameWithUserId = objRow[convCoursewareResCaseQuantitySenate.UserNameWithUserId] == DBNull.Value ? null : objRow[convCoursewareResCaseQuantitySenate.UserNameWithUserId].ToString().Trim(); //UserNameWithUserId
objvCoursewareResCaseQuantitySenateEN.IsDualVideo = TransNullToBool(objRow[convCoursewareResCaseQuantitySenate.IsDualVideo].ToString().Trim()); //是否双视频
objvCoursewareResCaseQuantitySenateEN.UserKindId = objRow[convCoursewareResCaseQuantitySenate.UserKindId].ToString().Trim(); //用户类别Id
objvCoursewareResCaseQuantitySenateEN.UserKindName = objRow[convCoursewareResCaseQuantitySenate.UserKindName] == DBNull.Value ? null : objRow[convCoursewareResCaseQuantitySenate.UserKindName].ToString().Trim(); //用户类别名
objvCoursewareResCaseQuantitySenateEN.ViewCount = objRow[convCoursewareResCaseQuantitySenate.ViewCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCoursewareResCaseQuantitySenate.ViewCount].ToString().Trim()); //浏览量
objvCoursewareResCaseQuantitySenateEN.IsShow = TransNullToBool(objRow[convCoursewareResCaseQuantitySenate.IsShow].ToString().Trim()); //是否启用
objvCoursewareResCaseQuantitySenateEN.DownloadNumber = objRow[convCoursewareResCaseQuantitySenate.DownloadNumber] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCoursewareResCaseQuantitySenate.DownloadNumber].ToString().Trim()); //下载数目
objvCoursewareResCaseQuantitySenateEN.FileIntegration = objRow[convCoursewareResCaseQuantitySenate.FileIntegration] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCoursewareResCaseQuantitySenate.FileIntegration].ToString().Trim()); //文件积分
objvCoursewareResCaseQuantitySenateEN.LikeCount = objRow[convCoursewareResCaseQuantitySenate.LikeCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convCoursewareResCaseQuantitySenate.LikeCount].ToString().Trim()); //资源喜欢数量
objvCoursewareResCaseQuantitySenateEN.CollectionCount = objRow[convCoursewareResCaseQuantitySenate.CollectionCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convCoursewareResCaseQuantitySenate.CollectionCount].ToString().Trim()); //收藏数量
objvCoursewareResCaseQuantitySenateEN.UpdUser = objRow[convCoursewareResCaseQuantitySenate.UpdUser] == DBNull.Value ? null : objRow[convCoursewareResCaseQuantitySenate.UpdUser].ToString().Trim(); //修改人
objvCoursewareResCaseQuantitySenateEN.Memo = objRow[convCoursewareResCaseQuantitySenate.Memo] == DBNull.Value ? null : objRow[convCoursewareResCaseQuantitySenate.Memo].ToString().Trim(); //备注
objvCoursewareResCaseQuantitySenateEN.OwnerId = objRow[convCoursewareResCaseQuantitySenate.OwnerId] == DBNull.Value ? null : objRow[convCoursewareResCaseQuantitySenate.OwnerId].ToString().Trim(); //拥有者Id
objvCoursewareResCaseQuantitySenateEN.OwnerName = objRow[convCoursewareResCaseQuantitySenate.OwnerName] == DBNull.Value ? null : objRow[convCoursewareResCaseQuantitySenate.OwnerName].ToString().Trim(); //拥有者姓名
objvCoursewareResCaseQuantitySenateEN.OwnerNameWithId = objRow[convCoursewareResCaseQuantitySenate.OwnerNameWithId] == DBNull.Value ? null : objRow[convCoursewareResCaseQuantitySenate.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvCoursewareResCaseQuantitySenateEN.IdXzCollege = objRow[convCoursewareResCaseQuantitySenate.IdXzCollege] == DBNull.Value ? null : objRow[convCoursewareResCaseQuantitySenate.IdXzCollege].ToString().Trim(); //学院流水号
objvCoursewareResCaseQuantitySenateEN.IdXzMajor = objRow[convCoursewareResCaseQuantitySenate.IdXzMajor] == DBNull.Value ? null : objRow[convCoursewareResCaseQuantitySenate.IdXzMajor].ToString().Trim(); //专业流水号
objvCoursewareResCaseQuantitySenateEN.CollegeNameA = objRow[convCoursewareResCaseQuantitySenate.CollegeNameA] == DBNull.Value ? null : objRow[convCoursewareResCaseQuantitySenate.CollegeNameA].ToString().Trim(); //学院名称简写
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvCoursewareResCaseQuantitySenateDA: GetObjByDataRowvCoursewareResCaseQuantitySenate)", objException.Message));
}
objvCoursewareResCaseQuantitySenateEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvCoursewareResCaseQuantitySenateEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvCoursewareResCaseQuantitySenateEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvCoursewareResCaseQuantitySenateEN objvCoursewareResCaseQuantitySenateEN = new clsvCoursewareResCaseQuantitySenateEN();
try
{
objvCoursewareResCaseQuantitySenateEN.IdmicroteachCaseQuantitySenate = TransNullToInt(objRow[convCoursewareResCaseQuantitySenate.IdmicroteachCaseQuantitySenate].ToString().Trim()); //微格量化评价流水号
objvCoursewareResCaseQuantitySenateEN.FuncModuleId = objRow[convCoursewareResCaseQuantitySenate.FuncModuleId].ToString().Trim(); //功能模块Id
objvCoursewareResCaseQuantitySenateEN.FuncModuleName = objRow[convCoursewareResCaseQuantitySenate.FuncModuleName] == DBNull.Value ? null : objRow[convCoursewareResCaseQuantitySenate.FuncModuleName].ToString().Trim(); //功能模块名称
objvCoursewareResCaseQuantitySenateEN.IdCoursewareResCase = objRow[convCoursewareResCaseQuantitySenate.IdCoursewareResCase] == DBNull.Value ? null : objRow[convCoursewareResCaseQuantitySenate.IdCoursewareResCase].ToString().Trim(); //课件资源案例流水号
objvCoursewareResCaseQuantitySenateEN.IdMicroteachCase = objRow[convCoursewareResCaseQuantitySenate.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvCoursewareResCaseQuantitySenateEN.CoursewareResCaseID = objRow[convCoursewareResCaseQuantitySenate.CoursewareResCaseID] == DBNull.Value ? null : objRow[convCoursewareResCaseQuantitySenate.CoursewareResCaseID].ToString().Trim(); //课件资源案例ID
objvCoursewareResCaseQuantitySenateEN.CoursewareResCaseName = objRow[convCoursewareResCaseQuantitySenate.CoursewareResCaseName] == DBNull.Value ? null : objRow[convCoursewareResCaseQuantitySenate.CoursewareResCaseName].ToString().Trim(); //课件资源案例名称
objvCoursewareResCaseQuantitySenateEN.CoursewareResCaseTheme = objRow[convCoursewareResCaseQuantitySenate.CoursewareResCaseTheme] == DBNull.Value ? null : objRow[convCoursewareResCaseQuantitySenate.CoursewareResCaseTheme].ToString().Trim(); //课件资源案例主题词
objvCoursewareResCaseQuantitySenateEN.CoursewareResCaseDate = objRow[convCoursewareResCaseQuantitySenate.CoursewareResCaseDate] == DBNull.Value ? null : objRow[convCoursewareResCaseQuantitySenate.CoursewareResCaseDate].ToString().Trim(); //视频资源日期
objvCoursewareResCaseQuantitySenateEN.CoursewareResCaseTime = objRow[convCoursewareResCaseQuantitySenate.CoursewareResCaseTime] == DBNull.Value ? null : objRow[convCoursewareResCaseQuantitySenate.CoursewareResCaseTime].ToString().Trim(); //视频资源时间
objvCoursewareResCaseQuantitySenateEN.CoursewareResCaseDateIn = objRow[convCoursewareResCaseQuantitySenate.CoursewareResCaseDateIn] == DBNull.Value ? null : objRow[convCoursewareResCaseQuantitySenate.CoursewareResCaseDateIn].ToString().Trim(); //案例入库日期
objvCoursewareResCaseQuantitySenateEN.CoursewareResCaseTimeIn = objRow[convCoursewareResCaseQuantitySenate.CoursewareResCaseTimeIn] == DBNull.Value ? null : objRow[convCoursewareResCaseQuantitySenate.CoursewareResCaseTimeIn].ToString().Trim(); //案例入库时间
objvCoursewareResCaseQuantitySenateEN.IdCoursewareResCaseType = objRow[convCoursewareResCaseQuantitySenate.IdCoursewareResCaseType] == DBNull.Value ? null : objRow[convCoursewareResCaseQuantitySenate.IdCoursewareResCaseType].ToString().Trim(); //课件资源类型流水号
objvCoursewareResCaseQuantitySenateEN.CoursewareResCaseTypeName = objRow[convCoursewareResCaseQuantitySenate.CoursewareResCaseTypeName] == DBNull.Value ? null : objRow[convCoursewareResCaseQuantitySenate.CoursewareResCaseTypeName].ToString().Trim(); //课件资源案例类型名称
objvCoursewareResCaseQuantitySenateEN.UserId = objRow[convCoursewareResCaseQuantitySenate.UserId].ToString().Trim(); //用户ID
objvCoursewareResCaseQuantitySenateEN.MajorID = objRow[convCoursewareResCaseQuantitySenate.MajorID] == DBNull.Value ? null : objRow[convCoursewareResCaseQuantitySenate.MajorID].ToString().Trim(); //专业ID
objvCoursewareResCaseQuantitySenateEN.MajorName = objRow[convCoursewareResCaseQuantitySenate.MajorName] == DBNull.Value ? null : objRow[convCoursewareResCaseQuantitySenate.MajorName].ToString().Trim(); //专业名称
objvCoursewareResCaseQuantitySenateEN.IdAppraiseType = objRow[convCoursewareResCaseQuantitySenate.IdAppraiseType].ToString().Trim(); //评议类型流水号
objvCoursewareResCaseQuantitySenateEN.AppraiseTypeName = objRow[convCoursewareResCaseQuantitySenate.AppraiseTypeName] == DBNull.Value ? null : objRow[convCoursewareResCaseQuantitySenate.AppraiseTypeName].ToString().Trim(); //评议类型名称
objvCoursewareResCaseQuantitySenateEN.CollegeID = objRow[convCoursewareResCaseQuantitySenate.CollegeID] == DBNull.Value ? null : objRow[convCoursewareResCaseQuantitySenate.CollegeID].ToString().Trim(); //学院ID
objvCoursewareResCaseQuantitySenateEN.CollegeName = objRow[convCoursewareResCaseQuantitySenate.CollegeName] == DBNull.Value ? null : objRow[convCoursewareResCaseQuantitySenate.CollegeName].ToString().Trim(); //学院名称
objvCoursewareResCaseQuantitySenateEN.CourseId = objRow[convCoursewareResCaseQuantitySenate.CourseId] == DBNull.Value ? null : objRow[convCoursewareResCaseQuantitySenate.CourseId].ToString().Trim(); //课程Id
objvCoursewareResCaseQuantitySenateEN.CourseCode = objRow[convCoursewareResCaseQuantitySenate.CourseCode] == DBNull.Value ? null : objRow[convCoursewareResCaseQuantitySenate.CourseCode].ToString().Trim(); //课程代码
objvCoursewareResCaseQuantitySenateEN.CourseName = objRow[convCoursewareResCaseQuantitySenate.CourseName] == DBNull.Value ? null : objRow[convCoursewareResCaseQuantitySenate.CourseName].ToString().Trim(); //课程名称
objvCoursewareResCaseQuantitySenateEN.BrowseCount = objRow[convCoursewareResCaseQuantitySenate.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCoursewareResCaseQuantitySenate.BrowseCount].ToString().Trim()); //浏览次数
objvCoursewareResCaseQuantitySenateEN.SenateTheme = objRow[convCoursewareResCaseQuantitySenate.SenateTheme] == DBNull.Value ? null : objRow[convCoursewareResCaseQuantitySenate.SenateTheme].ToString().Trim(); //量化评价主题
objvCoursewareResCaseQuantitySenateEN.SenateContent = objRow[convCoursewareResCaseQuantitySenate.SenateContent] == DBNull.Value ? null : objRow[convCoursewareResCaseQuantitySenate.SenateContent].ToString().Trim(); //评价内容
objvCoursewareResCaseQuantitySenateEN.SenateTotalScore = TransNullToFloat(objRow[convCoursewareResCaseQuantitySenate.SenateTotalScore].ToString().Trim()); //评价分数
objvCoursewareResCaseQuantitySenateEN.SenateDate = objRow[convCoursewareResCaseQuantitySenate.SenateDate] == DBNull.Value ? null : objRow[convCoursewareResCaseQuantitySenate.SenateDate].ToString().Trim(); //评价日期
objvCoursewareResCaseQuantitySenateEN.SenateTime = objRow[convCoursewareResCaseQuantitySenate.SenateTime] == DBNull.Value ? null : objRow[convCoursewareResCaseQuantitySenate.SenateTime].ToString().Trim(); //评价时间
objvCoursewareResCaseQuantitySenateEN.IdSenateGaugeVersion = objRow[convCoursewareResCaseQuantitySenate.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvCoursewareResCaseQuantitySenateEN.senateGaugeVersionID = objRow[convCoursewareResCaseQuantitySenate.senateGaugeVersionID] == DBNull.Value ? null : objRow[convCoursewareResCaseQuantitySenate.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvCoursewareResCaseQuantitySenateEN.senateGaugeVersionName = objRow[convCoursewareResCaseQuantitySenate.senateGaugeVersionName] == DBNull.Value ? null : objRow[convCoursewareResCaseQuantitySenate.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvCoursewareResCaseQuantitySenateEN.senateGaugeVersionTtlScore = objRow[convCoursewareResCaseQuantitySenate.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convCoursewareResCaseQuantitySenate.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvCoursewareResCaseQuantitySenateEN.UpdUserName = objRow[convCoursewareResCaseQuantitySenate.UpdUserName] == DBNull.Value ? null : objRow[convCoursewareResCaseQuantitySenate.UpdUserName].ToString().Trim(); //UpdUserName
objvCoursewareResCaseQuantitySenateEN.SenateIp = objRow[convCoursewareResCaseQuantitySenate.SenateIp].ToString().Trim(); //评议Ip
objvCoursewareResCaseQuantitySenateEN.UserTypeName = objRow[convCoursewareResCaseQuantitySenate.UserTypeName] == DBNull.Value ? null : objRow[convCoursewareResCaseQuantitySenate.UserTypeName].ToString().Trim(); //用户类型名称
objvCoursewareResCaseQuantitySenateEN.UserName = objRow[convCoursewareResCaseQuantitySenate.UserName].ToString().Trim(); //用户名
objvCoursewareResCaseQuantitySenateEN.UserNameWithUserId = objRow[convCoursewareResCaseQuantitySenate.UserNameWithUserId] == DBNull.Value ? null : objRow[convCoursewareResCaseQuantitySenate.UserNameWithUserId].ToString().Trim(); //UserNameWithUserId
objvCoursewareResCaseQuantitySenateEN.IsDualVideo = TransNullToBool(objRow[convCoursewareResCaseQuantitySenate.IsDualVideo].ToString().Trim()); //是否双视频
objvCoursewareResCaseQuantitySenateEN.UserKindId = objRow[convCoursewareResCaseQuantitySenate.UserKindId].ToString().Trim(); //用户类别Id
objvCoursewareResCaseQuantitySenateEN.UserKindName = objRow[convCoursewareResCaseQuantitySenate.UserKindName] == DBNull.Value ? null : objRow[convCoursewareResCaseQuantitySenate.UserKindName].ToString().Trim(); //用户类别名
objvCoursewareResCaseQuantitySenateEN.ViewCount = objRow[convCoursewareResCaseQuantitySenate.ViewCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCoursewareResCaseQuantitySenate.ViewCount].ToString().Trim()); //浏览量
objvCoursewareResCaseQuantitySenateEN.IsShow = TransNullToBool(objRow[convCoursewareResCaseQuantitySenate.IsShow].ToString().Trim()); //是否启用
objvCoursewareResCaseQuantitySenateEN.DownloadNumber = objRow[convCoursewareResCaseQuantitySenate.DownloadNumber] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCoursewareResCaseQuantitySenate.DownloadNumber].ToString().Trim()); //下载数目
objvCoursewareResCaseQuantitySenateEN.FileIntegration = objRow[convCoursewareResCaseQuantitySenate.FileIntegration] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCoursewareResCaseQuantitySenate.FileIntegration].ToString().Trim()); //文件积分
objvCoursewareResCaseQuantitySenateEN.LikeCount = objRow[convCoursewareResCaseQuantitySenate.LikeCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convCoursewareResCaseQuantitySenate.LikeCount].ToString().Trim()); //资源喜欢数量
objvCoursewareResCaseQuantitySenateEN.CollectionCount = objRow[convCoursewareResCaseQuantitySenate.CollectionCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convCoursewareResCaseQuantitySenate.CollectionCount].ToString().Trim()); //收藏数量
objvCoursewareResCaseQuantitySenateEN.UpdUser = objRow[convCoursewareResCaseQuantitySenate.UpdUser] == DBNull.Value ? null : objRow[convCoursewareResCaseQuantitySenate.UpdUser].ToString().Trim(); //修改人
objvCoursewareResCaseQuantitySenateEN.Memo = objRow[convCoursewareResCaseQuantitySenate.Memo] == DBNull.Value ? null : objRow[convCoursewareResCaseQuantitySenate.Memo].ToString().Trim(); //备注
objvCoursewareResCaseQuantitySenateEN.OwnerId = objRow[convCoursewareResCaseQuantitySenate.OwnerId] == DBNull.Value ? null : objRow[convCoursewareResCaseQuantitySenate.OwnerId].ToString().Trim(); //拥有者Id
objvCoursewareResCaseQuantitySenateEN.OwnerName = objRow[convCoursewareResCaseQuantitySenate.OwnerName] == DBNull.Value ? null : objRow[convCoursewareResCaseQuantitySenate.OwnerName].ToString().Trim(); //拥有者姓名
objvCoursewareResCaseQuantitySenateEN.OwnerNameWithId = objRow[convCoursewareResCaseQuantitySenate.OwnerNameWithId] == DBNull.Value ? null : objRow[convCoursewareResCaseQuantitySenate.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvCoursewareResCaseQuantitySenateEN.IdXzCollege = objRow[convCoursewareResCaseQuantitySenate.IdXzCollege] == DBNull.Value ? null : objRow[convCoursewareResCaseQuantitySenate.IdXzCollege].ToString().Trim(); //学院流水号
objvCoursewareResCaseQuantitySenateEN.IdXzMajor = objRow[convCoursewareResCaseQuantitySenate.IdXzMajor] == DBNull.Value ? null : objRow[convCoursewareResCaseQuantitySenate.IdXzMajor].ToString().Trim(); //专业流水号
objvCoursewareResCaseQuantitySenateEN.CollegeNameA = objRow[convCoursewareResCaseQuantitySenate.CollegeNameA] == DBNull.Value ? null : objRow[convCoursewareResCaseQuantitySenate.CollegeNameA].ToString().Trim(); //学院名称简写
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvCoursewareResCaseQuantitySenateDA: GetObjByDataRow)", objException.Message));
}
objvCoursewareResCaseQuantitySenateEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvCoursewareResCaseQuantitySenateEN;
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
objSQL = clsvCoursewareResCaseQuantitySenateDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvCoursewareResCaseQuantitySenateEN._CurrTabName, convCoursewareResCaseQuantitySenate.IdmicroteachCaseQuantitySenate, 8, "");
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
objSQL = clsvCoursewareResCaseQuantitySenateDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvCoursewareResCaseQuantitySenateEN._CurrTabName, convCoursewareResCaseQuantitySenate.IdmicroteachCaseQuantitySenate, 8, strPrefix);
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
 objSQL = clsvCoursewareResCaseQuantitySenateDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select IdmicroteachCaseQuantitySenate from vCoursewareResCaseQuantitySenate where " + strCondition;
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
 objSQL = clsvCoursewareResCaseQuantitySenateDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select IdmicroteachCaseQuantitySenate from vCoursewareResCaseQuantitySenate where " + strCondition;
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
 /// <param name = "lngIdmicroteachCaseQuantitySenate">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(long lngIdmicroteachCaseQuantitySenate)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCoursewareResCaseQuantitySenateDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vCoursewareResCaseQuantitySenate", "IdmicroteachCaseQuantitySenate = " + ""+ lngIdmicroteachCaseQuantitySenate+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvCoursewareResCaseQuantitySenateDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCoursewareResCaseQuantitySenateDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vCoursewareResCaseQuantitySenate", strCondition))
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
objSQL = clsvCoursewareResCaseQuantitySenateDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vCoursewareResCaseQuantitySenate");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvCoursewareResCaseQuantitySenateENS">源对象</param>
 /// <param name = "objvCoursewareResCaseQuantitySenateENT">目标对象</param>
public void CopyTo(clsvCoursewareResCaseQuantitySenateEN objvCoursewareResCaseQuantitySenateENS, clsvCoursewareResCaseQuantitySenateEN objvCoursewareResCaseQuantitySenateENT)
{
objvCoursewareResCaseQuantitySenateENT.IdmicroteachCaseQuantitySenate = objvCoursewareResCaseQuantitySenateENS.IdmicroteachCaseQuantitySenate; //微格量化评价流水号
objvCoursewareResCaseQuantitySenateENT.FuncModuleId = objvCoursewareResCaseQuantitySenateENS.FuncModuleId; //功能模块Id
objvCoursewareResCaseQuantitySenateENT.FuncModuleName = objvCoursewareResCaseQuantitySenateENS.FuncModuleName; //功能模块名称
objvCoursewareResCaseQuantitySenateENT.IdCoursewareResCase = objvCoursewareResCaseQuantitySenateENS.IdCoursewareResCase; //课件资源案例流水号
objvCoursewareResCaseQuantitySenateENT.IdMicroteachCase = objvCoursewareResCaseQuantitySenateENS.IdMicroteachCase; //微格教学案例流水号
objvCoursewareResCaseQuantitySenateENT.CoursewareResCaseID = objvCoursewareResCaseQuantitySenateENS.CoursewareResCaseID; //课件资源案例ID
objvCoursewareResCaseQuantitySenateENT.CoursewareResCaseName = objvCoursewareResCaseQuantitySenateENS.CoursewareResCaseName; //课件资源案例名称
objvCoursewareResCaseQuantitySenateENT.CoursewareResCaseTheme = objvCoursewareResCaseQuantitySenateENS.CoursewareResCaseTheme; //课件资源案例主题词
objvCoursewareResCaseQuantitySenateENT.CoursewareResCaseDate = objvCoursewareResCaseQuantitySenateENS.CoursewareResCaseDate; //视频资源日期
objvCoursewareResCaseQuantitySenateENT.CoursewareResCaseTime = objvCoursewareResCaseQuantitySenateENS.CoursewareResCaseTime; //视频资源时间
objvCoursewareResCaseQuantitySenateENT.CoursewareResCaseDateIn = objvCoursewareResCaseQuantitySenateENS.CoursewareResCaseDateIn; //案例入库日期
objvCoursewareResCaseQuantitySenateENT.CoursewareResCaseTimeIn = objvCoursewareResCaseQuantitySenateENS.CoursewareResCaseTimeIn; //案例入库时间
objvCoursewareResCaseQuantitySenateENT.IdCoursewareResCaseType = objvCoursewareResCaseQuantitySenateENS.IdCoursewareResCaseType; //课件资源类型流水号
objvCoursewareResCaseQuantitySenateENT.CoursewareResCaseTypeName = objvCoursewareResCaseQuantitySenateENS.CoursewareResCaseTypeName; //课件资源案例类型名称
objvCoursewareResCaseQuantitySenateENT.UserId = objvCoursewareResCaseQuantitySenateENS.UserId; //用户ID
objvCoursewareResCaseQuantitySenateENT.MajorID = objvCoursewareResCaseQuantitySenateENS.MajorID; //专业ID
objvCoursewareResCaseQuantitySenateENT.MajorName = objvCoursewareResCaseQuantitySenateENS.MajorName; //专业名称
objvCoursewareResCaseQuantitySenateENT.IdAppraiseType = objvCoursewareResCaseQuantitySenateENS.IdAppraiseType; //评议类型流水号
objvCoursewareResCaseQuantitySenateENT.AppraiseTypeName = objvCoursewareResCaseQuantitySenateENS.AppraiseTypeName; //评议类型名称
objvCoursewareResCaseQuantitySenateENT.CollegeID = objvCoursewareResCaseQuantitySenateENS.CollegeID; //学院ID
objvCoursewareResCaseQuantitySenateENT.CollegeName = objvCoursewareResCaseQuantitySenateENS.CollegeName; //学院名称
objvCoursewareResCaseQuantitySenateENT.CourseId = objvCoursewareResCaseQuantitySenateENS.CourseId; //课程Id
objvCoursewareResCaseQuantitySenateENT.CourseCode = objvCoursewareResCaseQuantitySenateENS.CourseCode; //课程代码
objvCoursewareResCaseQuantitySenateENT.CourseName = objvCoursewareResCaseQuantitySenateENS.CourseName; //课程名称
objvCoursewareResCaseQuantitySenateENT.BrowseCount = objvCoursewareResCaseQuantitySenateENS.BrowseCount; //浏览次数
objvCoursewareResCaseQuantitySenateENT.SenateTheme = objvCoursewareResCaseQuantitySenateENS.SenateTheme; //量化评价主题
objvCoursewareResCaseQuantitySenateENT.SenateContent = objvCoursewareResCaseQuantitySenateENS.SenateContent; //评价内容
objvCoursewareResCaseQuantitySenateENT.SenateTotalScore = objvCoursewareResCaseQuantitySenateENS.SenateTotalScore; //评价分数
objvCoursewareResCaseQuantitySenateENT.SenateDate = objvCoursewareResCaseQuantitySenateENS.SenateDate; //评价日期
objvCoursewareResCaseQuantitySenateENT.SenateTime = objvCoursewareResCaseQuantitySenateENS.SenateTime; //评价时间
objvCoursewareResCaseQuantitySenateENT.IdSenateGaugeVersion = objvCoursewareResCaseQuantitySenateENS.IdSenateGaugeVersion; //评价量表版本流水号
objvCoursewareResCaseQuantitySenateENT.senateGaugeVersionID = objvCoursewareResCaseQuantitySenateENS.senateGaugeVersionID; //评价量表版本ID
objvCoursewareResCaseQuantitySenateENT.senateGaugeVersionName = objvCoursewareResCaseQuantitySenateENS.senateGaugeVersionName; //评价量表版本名称
objvCoursewareResCaseQuantitySenateENT.senateGaugeVersionTtlScore = objvCoursewareResCaseQuantitySenateENS.senateGaugeVersionTtlScore; //评价量表版本总分
objvCoursewareResCaseQuantitySenateENT.UpdUserName = objvCoursewareResCaseQuantitySenateENS.UpdUserName; //UpdUserName
objvCoursewareResCaseQuantitySenateENT.SenateIp = objvCoursewareResCaseQuantitySenateENS.SenateIp; //评议Ip
objvCoursewareResCaseQuantitySenateENT.UserTypeName = objvCoursewareResCaseQuantitySenateENS.UserTypeName; //用户类型名称
objvCoursewareResCaseQuantitySenateENT.UserName = objvCoursewareResCaseQuantitySenateENS.UserName; //用户名
objvCoursewareResCaseQuantitySenateENT.UserNameWithUserId = objvCoursewareResCaseQuantitySenateENS.UserNameWithUserId; //UserNameWithUserId
objvCoursewareResCaseQuantitySenateENT.IsDualVideo = objvCoursewareResCaseQuantitySenateENS.IsDualVideo; //是否双视频
objvCoursewareResCaseQuantitySenateENT.UserKindId = objvCoursewareResCaseQuantitySenateENS.UserKindId; //用户类别Id
objvCoursewareResCaseQuantitySenateENT.UserKindName = objvCoursewareResCaseQuantitySenateENS.UserKindName; //用户类别名
objvCoursewareResCaseQuantitySenateENT.ViewCount = objvCoursewareResCaseQuantitySenateENS.ViewCount; //浏览量
objvCoursewareResCaseQuantitySenateENT.IsShow = objvCoursewareResCaseQuantitySenateENS.IsShow; //是否启用
objvCoursewareResCaseQuantitySenateENT.DownloadNumber = objvCoursewareResCaseQuantitySenateENS.DownloadNumber; //下载数目
objvCoursewareResCaseQuantitySenateENT.FileIntegration = objvCoursewareResCaseQuantitySenateENS.FileIntegration; //文件积分
objvCoursewareResCaseQuantitySenateENT.LikeCount = objvCoursewareResCaseQuantitySenateENS.LikeCount; //资源喜欢数量
objvCoursewareResCaseQuantitySenateENT.CollectionCount = objvCoursewareResCaseQuantitySenateENS.CollectionCount; //收藏数量
objvCoursewareResCaseQuantitySenateENT.UpdUser = objvCoursewareResCaseQuantitySenateENS.UpdUser; //修改人
objvCoursewareResCaseQuantitySenateENT.Memo = objvCoursewareResCaseQuantitySenateENS.Memo; //备注
objvCoursewareResCaseQuantitySenateENT.OwnerId = objvCoursewareResCaseQuantitySenateENS.OwnerId; //拥有者Id
objvCoursewareResCaseQuantitySenateENT.OwnerName = objvCoursewareResCaseQuantitySenateENS.OwnerName; //拥有者姓名
objvCoursewareResCaseQuantitySenateENT.OwnerNameWithId = objvCoursewareResCaseQuantitySenateENS.OwnerNameWithId; //拥有者名称附Id
objvCoursewareResCaseQuantitySenateENT.IdXzCollege = objvCoursewareResCaseQuantitySenateENS.IdXzCollege; //学院流水号
objvCoursewareResCaseQuantitySenateENT.IdXzMajor = objvCoursewareResCaseQuantitySenateENS.IdXzMajor; //专业流水号
objvCoursewareResCaseQuantitySenateENT.CollegeNameA = objvCoursewareResCaseQuantitySenateENS.CollegeNameA; //学院名称简写
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvCoursewareResCaseQuantitySenateEN objvCoursewareResCaseQuantitySenateEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvCoursewareResCaseQuantitySenateEN.FuncModuleId, 4, convCoursewareResCaseQuantitySenate.FuncModuleId);
clsCheckSql.CheckFieldLen(objvCoursewareResCaseQuantitySenateEN.FuncModuleName, 30, convCoursewareResCaseQuantitySenate.FuncModuleName);
clsCheckSql.CheckFieldLen(objvCoursewareResCaseQuantitySenateEN.IdCoursewareResCase, 8, convCoursewareResCaseQuantitySenate.IdCoursewareResCase);
clsCheckSql.CheckFieldLen(objvCoursewareResCaseQuantitySenateEN.IdMicroteachCase, 8, convCoursewareResCaseQuantitySenate.IdMicroteachCase);
clsCheckSql.CheckFieldLen(objvCoursewareResCaseQuantitySenateEN.CoursewareResCaseID, 8, convCoursewareResCaseQuantitySenate.CoursewareResCaseID);
clsCheckSql.CheckFieldLen(objvCoursewareResCaseQuantitySenateEN.CoursewareResCaseName, 100, convCoursewareResCaseQuantitySenate.CoursewareResCaseName);
clsCheckSql.CheckFieldLen(objvCoursewareResCaseQuantitySenateEN.CoursewareResCaseTheme, 200, convCoursewareResCaseQuantitySenate.CoursewareResCaseTheme);
clsCheckSql.CheckFieldLen(objvCoursewareResCaseQuantitySenateEN.CoursewareResCaseDate, 8, convCoursewareResCaseQuantitySenate.CoursewareResCaseDate);
clsCheckSql.CheckFieldLen(objvCoursewareResCaseQuantitySenateEN.CoursewareResCaseTime, 6, convCoursewareResCaseQuantitySenate.CoursewareResCaseTime);
clsCheckSql.CheckFieldLen(objvCoursewareResCaseQuantitySenateEN.CoursewareResCaseDateIn, 8, convCoursewareResCaseQuantitySenate.CoursewareResCaseDateIn);
clsCheckSql.CheckFieldLen(objvCoursewareResCaseQuantitySenateEN.CoursewareResCaseTimeIn, 6, convCoursewareResCaseQuantitySenate.CoursewareResCaseTimeIn);
clsCheckSql.CheckFieldLen(objvCoursewareResCaseQuantitySenateEN.IdCoursewareResCaseType, 4, convCoursewareResCaseQuantitySenate.IdCoursewareResCaseType);
clsCheckSql.CheckFieldLen(objvCoursewareResCaseQuantitySenateEN.CoursewareResCaseTypeName, 30, convCoursewareResCaseQuantitySenate.CoursewareResCaseTypeName);
clsCheckSql.CheckFieldLen(objvCoursewareResCaseQuantitySenateEN.UserId, 18, convCoursewareResCaseQuantitySenate.UserId);
clsCheckSql.CheckFieldLen(objvCoursewareResCaseQuantitySenateEN.MajorID, 4, convCoursewareResCaseQuantitySenate.MajorID);
clsCheckSql.CheckFieldLen(objvCoursewareResCaseQuantitySenateEN.MajorName, 100, convCoursewareResCaseQuantitySenate.MajorName);
clsCheckSql.CheckFieldLen(objvCoursewareResCaseQuantitySenateEN.IdAppraiseType, 4, convCoursewareResCaseQuantitySenate.IdAppraiseType);
clsCheckSql.CheckFieldLen(objvCoursewareResCaseQuantitySenateEN.AppraiseTypeName, 50, convCoursewareResCaseQuantitySenate.AppraiseTypeName);
clsCheckSql.CheckFieldLen(objvCoursewareResCaseQuantitySenateEN.CollegeID, 4, convCoursewareResCaseQuantitySenate.CollegeID);
clsCheckSql.CheckFieldLen(objvCoursewareResCaseQuantitySenateEN.CollegeName, 100, convCoursewareResCaseQuantitySenate.CollegeName);
clsCheckSql.CheckFieldLen(objvCoursewareResCaseQuantitySenateEN.CourseId, 8, convCoursewareResCaseQuantitySenate.CourseId);
clsCheckSql.CheckFieldLen(objvCoursewareResCaseQuantitySenateEN.CourseCode, 20, convCoursewareResCaseQuantitySenate.CourseCode);
clsCheckSql.CheckFieldLen(objvCoursewareResCaseQuantitySenateEN.CourseName, 100, convCoursewareResCaseQuantitySenate.CourseName);
clsCheckSql.CheckFieldLen(objvCoursewareResCaseQuantitySenateEN.SenateTheme, 200, convCoursewareResCaseQuantitySenate.SenateTheme);
clsCheckSql.CheckFieldLen(objvCoursewareResCaseQuantitySenateEN.SenateContent, 2000, convCoursewareResCaseQuantitySenate.SenateContent);
clsCheckSql.CheckFieldLen(objvCoursewareResCaseQuantitySenateEN.SenateDate, 8, convCoursewareResCaseQuantitySenate.SenateDate);
clsCheckSql.CheckFieldLen(objvCoursewareResCaseQuantitySenateEN.SenateTime, 6, convCoursewareResCaseQuantitySenate.SenateTime);
clsCheckSql.CheckFieldLen(objvCoursewareResCaseQuantitySenateEN.IdSenateGaugeVersion, 4, convCoursewareResCaseQuantitySenate.IdSenateGaugeVersion);
clsCheckSql.CheckFieldLen(objvCoursewareResCaseQuantitySenateEN.senateGaugeVersionID, 4, convCoursewareResCaseQuantitySenate.senateGaugeVersionID);
clsCheckSql.CheckFieldLen(objvCoursewareResCaseQuantitySenateEN.senateGaugeVersionName, 200, convCoursewareResCaseQuantitySenate.senateGaugeVersionName);
clsCheckSql.CheckFieldLen(objvCoursewareResCaseQuantitySenateEN.UpdUserName, 20, convCoursewareResCaseQuantitySenate.UpdUserName);
clsCheckSql.CheckFieldLen(objvCoursewareResCaseQuantitySenateEN.SenateIp, 50, convCoursewareResCaseQuantitySenate.SenateIp);
clsCheckSql.CheckFieldLen(objvCoursewareResCaseQuantitySenateEN.UserTypeName, 20, convCoursewareResCaseQuantitySenate.UserTypeName);
clsCheckSql.CheckFieldLen(objvCoursewareResCaseQuantitySenateEN.UserName, 30, convCoursewareResCaseQuantitySenate.UserName);
clsCheckSql.CheckFieldLen(objvCoursewareResCaseQuantitySenateEN.UserNameWithUserId, 51, convCoursewareResCaseQuantitySenate.UserNameWithUserId);
clsCheckSql.CheckFieldLen(objvCoursewareResCaseQuantitySenateEN.UserKindId, 2, convCoursewareResCaseQuantitySenate.UserKindId);
clsCheckSql.CheckFieldLen(objvCoursewareResCaseQuantitySenateEN.UserKindName, 30, convCoursewareResCaseQuantitySenate.UserKindName);
clsCheckSql.CheckFieldLen(objvCoursewareResCaseQuantitySenateEN.UpdUser, 20, convCoursewareResCaseQuantitySenate.UpdUser);
clsCheckSql.CheckFieldLen(objvCoursewareResCaseQuantitySenateEN.Memo, 1000, convCoursewareResCaseQuantitySenate.Memo);
clsCheckSql.CheckFieldLen(objvCoursewareResCaseQuantitySenateEN.OwnerId, 20, convCoursewareResCaseQuantitySenate.OwnerId);
clsCheckSql.CheckFieldLen(objvCoursewareResCaseQuantitySenateEN.OwnerName, 30, convCoursewareResCaseQuantitySenate.OwnerName);
clsCheckSql.CheckFieldLen(objvCoursewareResCaseQuantitySenateEN.OwnerNameWithId, 51, convCoursewareResCaseQuantitySenate.OwnerNameWithId);
clsCheckSql.CheckFieldLen(objvCoursewareResCaseQuantitySenateEN.IdXzCollege, 4, convCoursewareResCaseQuantitySenate.IdXzCollege);
clsCheckSql.CheckFieldLen(objvCoursewareResCaseQuantitySenateEN.IdXzMajor, 8, convCoursewareResCaseQuantitySenate.IdXzMajor);
clsCheckSql.CheckFieldLen(objvCoursewareResCaseQuantitySenateEN.CollegeNameA, 12, convCoursewareResCaseQuantitySenate.CollegeNameA);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCaseQuantitySenateEN.FuncModuleId, convCoursewareResCaseQuantitySenate.FuncModuleId);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCaseQuantitySenateEN.FuncModuleName, convCoursewareResCaseQuantitySenate.FuncModuleName);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCaseQuantitySenateEN.IdCoursewareResCase, convCoursewareResCaseQuantitySenate.IdCoursewareResCase);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCaseQuantitySenateEN.IdMicroteachCase, convCoursewareResCaseQuantitySenate.IdMicroteachCase);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCaseQuantitySenateEN.CoursewareResCaseID, convCoursewareResCaseQuantitySenate.CoursewareResCaseID);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCaseQuantitySenateEN.CoursewareResCaseName, convCoursewareResCaseQuantitySenate.CoursewareResCaseName);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCaseQuantitySenateEN.CoursewareResCaseTheme, convCoursewareResCaseQuantitySenate.CoursewareResCaseTheme);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCaseQuantitySenateEN.CoursewareResCaseDate, convCoursewareResCaseQuantitySenate.CoursewareResCaseDate);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCaseQuantitySenateEN.CoursewareResCaseTime, convCoursewareResCaseQuantitySenate.CoursewareResCaseTime);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCaseQuantitySenateEN.CoursewareResCaseDateIn, convCoursewareResCaseQuantitySenate.CoursewareResCaseDateIn);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCaseQuantitySenateEN.CoursewareResCaseTimeIn, convCoursewareResCaseQuantitySenate.CoursewareResCaseTimeIn);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCaseQuantitySenateEN.IdCoursewareResCaseType, convCoursewareResCaseQuantitySenate.IdCoursewareResCaseType);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCaseQuantitySenateEN.CoursewareResCaseTypeName, convCoursewareResCaseQuantitySenate.CoursewareResCaseTypeName);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCaseQuantitySenateEN.UserId, convCoursewareResCaseQuantitySenate.UserId);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCaseQuantitySenateEN.MajorID, convCoursewareResCaseQuantitySenate.MajorID);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCaseQuantitySenateEN.MajorName, convCoursewareResCaseQuantitySenate.MajorName);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCaseQuantitySenateEN.IdAppraiseType, convCoursewareResCaseQuantitySenate.IdAppraiseType);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCaseQuantitySenateEN.AppraiseTypeName, convCoursewareResCaseQuantitySenate.AppraiseTypeName);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCaseQuantitySenateEN.CollegeID, convCoursewareResCaseQuantitySenate.CollegeID);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCaseQuantitySenateEN.CollegeName, convCoursewareResCaseQuantitySenate.CollegeName);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCaseQuantitySenateEN.CourseId, convCoursewareResCaseQuantitySenate.CourseId);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCaseQuantitySenateEN.CourseCode, convCoursewareResCaseQuantitySenate.CourseCode);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCaseQuantitySenateEN.CourseName, convCoursewareResCaseQuantitySenate.CourseName);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCaseQuantitySenateEN.SenateTheme, convCoursewareResCaseQuantitySenate.SenateTheme);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCaseQuantitySenateEN.SenateContent, convCoursewareResCaseQuantitySenate.SenateContent);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCaseQuantitySenateEN.SenateDate, convCoursewareResCaseQuantitySenate.SenateDate);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCaseQuantitySenateEN.SenateTime, convCoursewareResCaseQuantitySenate.SenateTime);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCaseQuantitySenateEN.IdSenateGaugeVersion, convCoursewareResCaseQuantitySenate.IdSenateGaugeVersion);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCaseQuantitySenateEN.senateGaugeVersionID, convCoursewareResCaseQuantitySenate.senateGaugeVersionID);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCaseQuantitySenateEN.senateGaugeVersionName, convCoursewareResCaseQuantitySenate.senateGaugeVersionName);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCaseQuantitySenateEN.UpdUserName, convCoursewareResCaseQuantitySenate.UpdUserName);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCaseQuantitySenateEN.SenateIp, convCoursewareResCaseQuantitySenate.SenateIp);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCaseQuantitySenateEN.UserTypeName, convCoursewareResCaseQuantitySenate.UserTypeName);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCaseQuantitySenateEN.UserName, convCoursewareResCaseQuantitySenate.UserName);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCaseQuantitySenateEN.UserNameWithUserId, convCoursewareResCaseQuantitySenate.UserNameWithUserId);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCaseQuantitySenateEN.UserKindId, convCoursewareResCaseQuantitySenate.UserKindId);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCaseQuantitySenateEN.UserKindName, convCoursewareResCaseQuantitySenate.UserKindName);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCaseQuantitySenateEN.UpdUser, convCoursewareResCaseQuantitySenate.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCaseQuantitySenateEN.Memo, convCoursewareResCaseQuantitySenate.Memo);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCaseQuantitySenateEN.OwnerId, convCoursewareResCaseQuantitySenate.OwnerId);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCaseQuantitySenateEN.OwnerName, convCoursewareResCaseQuantitySenate.OwnerName);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCaseQuantitySenateEN.OwnerNameWithId, convCoursewareResCaseQuantitySenate.OwnerNameWithId);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCaseQuantitySenateEN.IdXzCollege, convCoursewareResCaseQuantitySenate.IdXzCollege);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCaseQuantitySenateEN.IdXzMajor, convCoursewareResCaseQuantitySenate.IdXzMajor);
clsCheckSql.CheckSqlInjection4Field(objvCoursewareResCaseQuantitySenateEN.CollegeNameA, convCoursewareResCaseQuantitySenate.CollegeNameA);
//检查外键字段长度
 objvCoursewareResCaseQuantitySenateEN._IsCheckProperty = true;
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
 objSQL = clsvCoursewareResCaseQuantitySenateDA.GetSpecSQLObj();
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
 objSQL = clsvCoursewareResCaseQuantitySenateDA.GetSpecSQLObj();
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
 objSQL = clsvCoursewareResCaseQuantitySenateDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvCoursewareResCaseQuantitySenateEN._CurrTabName);
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
 objSQL = clsvCoursewareResCaseQuantitySenateDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvCoursewareResCaseQuantitySenateEN._CurrTabName, strCondition);
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
 objSQL = clsvCoursewareResCaseQuantitySenateDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}